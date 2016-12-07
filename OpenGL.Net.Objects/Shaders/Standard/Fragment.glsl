
// Copyright (C) 2011-2016 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

#include </OpenGL/Compatibility.glsl>
#include </OpenGL/Light/Lighting.glsl>
//#include </OpenGL/EnvironMap/EnvironReflection>
//#include </OpenGL/EnvironMap/EnvironRefraction>
//#include </OpenGL/Shadow/ShadowMap>

// Vertex uniform color
uniform vec4 glo_UniformColor = vec4(1.0, 1.0, 1.0, 1.0);

// Additional destination blend factor texture
uniform sampler2D glo_TransparentTexture;
// Additional destination blend factor texture coordinate index
uniform int glo_TransparentTexCoord = -1;
// Trasparency factor for modulating destination blend factor texture fragment
uniform float glo_Transparency = 1.0;

// Fragment color
SHADER_IN vec4 glo_VertexColor;
// Fragment vertex position (model space)
SHADER_IN vec4 glo_VertexPosition;
// Fragment normal (view space)
SHADER_IN vec3 glo_VertexNormal;
// Fragment normal (model space)
SHADER_IN vec3 glo_VertexNormalModel;
// Fragment texture coordinates
SHADER_IN vec2 glo_VertexTexCoord[3];

// Fragment color
OUT vec4		glo_FragColor;

// Fragment shader entry point
void main()
{
#if defined(GLO_LIGHTING_PER_FRAGMENT)
	// Material initially defined by uniform colors
	glo_MaterialType fragmentMaterial = glo_FrontMaterial;
	int index;

#if defined(GLO_COLOR_PER_VERTEX)
	// Material diffuse color is vertex color, if specified
	fragmentMaterial.DiffuseColor = glo_VertexColor;
#endif

	// Emission color from texture
	index = glo_FrontMaterialEmissionTexCoord;
	if (index >= 0) {
		fragmentMaterial.EmissiveColor = TEXTURE_2D(glo_FrontMaterialEmissionTexture, glo_VertexTexCoord[index]);
	}

	// Ambient color from texture
	index = glo_FrontMaterialAmbientTexCoord;
	if (index >= 0) {
		fragmentMaterial.AmbientColor = TEXTURE_2D(glo_FrontMaterialAmbientTexture, glo_VertexTexCoord[index]);
	}

	// Diffuse color from texture
	index = glo_FrontMaterialDiffuseTexCoord;
	if (glo_FrontMaterialDiffuseTexCoord >= 0) {
		fragmentMaterial.DiffuseColor = TEXTURE_2D(glo_FrontMaterialDiffuseTexture, glo_VertexTexCoord[index]);

#if defined(GLO_COLOR_PER_VERTEX)
		// Modulate diffuse texture with vertex color, if defined
		fragmentMaterial.DiffuseColor = fragmentMaterial.DiffuseColor * glo_VertexColor;
#endif
	}

	// Fragment color
	glo_FragColor = ComputeLightShading(fragmentMaterial, glo_VertexPosition, normalize(glo_VertexNormal));
	
#elif defined(GLO_LIGHTING_PER_VERTEX)

	int index;

	// Vertex shader computes fragment color
	glo_FragColor = glo_VertexColor;

	// No emission texture support!

	// Diffuse color from texture (modulated with vertex color)
	index = glo_FrontMaterialDiffuseTexCoord;
	if (glo_FrontMaterialDiffuseTexCoord >= 0)
		glo_FragColor = TEXTURE_2D(glo_FrontMaterialDiffuseTexture, glo_VertexTexCoord[index]) * glo_FragColor;

#elif defined(GLO_COLOR_PER_VERTEX)

	// Vertex shader computes fragment color
	glo_FragColor = glo_VertexColor;

#else

	// Default to uniform color
	glo_FragColor = glo_UniformColor;

#endif

#if defined(GLO_SHADOW_MAP2)

	// Test shadow map
	vec4 shadowAttenuation = ComputeShadowShading();
	// Modulate color
	glo_FragColor = glo_FragColor * shadowAttenuation;

#endif

	// --- Reflection effect --------------------------------------------------

#if defined(GLO_REFLECTION_PER_FRAGMENT)

	// Perform reflection computation
	vec4 reflectedColor = ComputeEnvironmentReflection(-vec3(glo_VertexPosition), glo_VertexNormalModel);
	// Mix reflected color with material color
	glo_FragColor += reflectedColor;

#endif

	// --- Refraction effect --------------------------------------------------

#if defined(GLO_REFRACTION_PER_FRAGMENT)

	// Perform reflection computation
	vec4 refractedColor = ComputeEnvironmentRefraction(-vec3(glo_VertexPosition), glo_VertexNormalModel);
	// Mix reflected color with material color
	glo_FragColor += refractedColor;

#endif

	// --- COLLADA blending ---------------------------------------------------

#if defined(GLO_COLLADA_TRASPARENCY_PER_FRAGMENT2)

	if (glo_TransparentTexCoord >= 0) {
		// Get transparency value
		vec4 alphaFragment = TEXTURE_2D(glo_TransparentTexture, glo_VertexTexCoord[glo_TransparentTexCoord]);

		// Module transparency value
		alphaFragment *= glo_Transparency;

		// Blend functions: Src=ONE Dst=ONE_MINUS_ALPHA
		// -> Blend Src in shader (because blend function is ONE)
		glo_FragColor *= alphaFragment.a;
		// -> Set Src.a to blend Dst
		glo_FragColor.a = alphaFragment.a;
	}

#endif
}
