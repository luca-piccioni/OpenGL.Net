
// Copyright (C) 2011-2015 Luca Piccioni
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
//#include </OpenGL/EnvironMap/EnvironReflection>
//#include </OpenGL/EnvironMap/EnvironRefraction>
//#include </OpenGL/Light/ILightShading>
//#include </OpenGL/Shadow/ShadowMap>

// Vertex uniform color
uniform vec4 hal_UniformColor = vec4(1.0, 1.0, 1.0, 1.0);

// Additional destination blend factor texture
uniform sampler2D hal_TransparentTexture;
// Additional destination blend factor texture coordinate index
uniform int hal_TransparentTexCoord = -1;
// Trasparency factor for modulating destination blend factor texture fragment
uniform float hal_Transparency = 1.0;

BEGIN_INPUT_BLOCK(hal_PerVertex)
	// Fragment color
	SHADER_IN vec4 hal_VertexColor;
	// Fragment vertex position (model space)
	SHADER_IN vec4 hal_VertexPosition;
	// Fragment normal (view space)
	SHADER_IN vec3 hal_VertexNormal;
	// Fragment normal (model space)
	SHADER_IN vec3 hal_VertexNormalModel;
	// Fragment texture coordinates
	SHADER_IN vec2 hal_VertexTexCoord[3];
END_INPUT_BLOCK()

// Fragment color
OUT vec4		hal_FragColor;

// Fragment shader entry point
void main()
{
#if defined(HAL_LIGHTING_PER_FRAGMENT)

	// Material initially defined by uniform colors
	ds_MaterialType fragmentMaterial = hal_FrontMaterial;
	int index;

#if defined(HAL_COLOR_PER_VERTEX)
	// Material diffuse color is vertex color, if specified
	fragmentMaterial.DiffuseColor = hal_VertexColor;
#endif

	// Emission color from texture
	index = hal_FrontMaterialEmissionTexCoord;
	if (index >= 0) {
		fragmentMaterial.EmissiveColor = TEXTURE_2D(hal_FrontMaterialEmissionTexture, hal_VertexTexCoord[index]);
	}

	// Ambient color from texture
	index = hal_FrontMaterialAmbientTexCoord;
	if (index >= 0) {
		fragmentMaterial.AmbientColor = TEXTURE_2D(hal_FrontMaterialAmbientTexture, hal_VertexTexCoord[index]);
	}

	// Diffuse color from texture
	index = hal_FrontMaterialDiffuseTexCoord;
	if (hal_FrontMaterialDiffuseTexCoord >= 0) {
		fragmentMaterial.DiffuseColor = TEXTURE_2D(hal_FrontMaterialDiffuseTexture, hal_VertexTexCoord[index]);

#if defined(HAL_COLOR_PER_VERTEX)
		// Modulate diffuse texture with vertex color, if defined
		fragmentMaterial.DiffuseColor = fragmentMaterial.DiffuseColor * hal_VertexColor;
#endif
	}

	// Fragment color
	hal_FragColor = ComputeLightShading(fragmentMaterial, hal_VertexPosition, normalize(hal_VertexNormal));
	
#elif defined(HAL_LIGHTING_PER_VERTEX)

	int index;

	// Vertex shader computes fragment color
	hal_FragColor = hal_VertexColor;

	// No emission texture support!

	// Diffuse color from texture (modulated with vertex color)
	index = hal_FrontMaterialDiffuseTexCoord;
	if (hal_FrontMaterialDiffuseTexCoord >= 0)
		hal_FragColor = TEXTURE_2D(hal_FrontMaterialDiffuseTexture, hal_VertexTexCoord[index]) * hal_FragColor;

#elif defined(HAL_COLOR_PER_VERTEX)

	// Vertex shader computes fragment color
	hal_FragColor = hal_VertexColor;

#else

	// Default to uniform color
	hal_FragColor = hal_UniformColor;

#endif

#if defined(HAL_SHADOW_MAP2)

	// Test shadow map
	vec4 shadowAttenuation = ComputeShadowShading();
	// Modulate color
	hal_FragColor = hal_FragColor * shadowAttenuation;

#endif

	// --- Reflection effect --------------------------------------------------

#if defined(HAL_REFLECTION_PER_FRAGMENT)

	// Perform reflection computation
	vec4 reflectedColor = ComputeEnvironmentReflection(-vec3(hal_VertexPosition), hal_VertexNormalModel);
	// Mix reflected color with material color
	hal_FragColor += reflectedColor;

#endif

	// --- Refraction effect --------------------------------------------------

#if defined(HAL_REFRACTION_PER_FRAGMENT)

	// Perform reflection computation
	vec4 refractedColor = ComputeEnvironmentRefraction(-vec3(hal_VertexPosition), hal_VertexNormalModel);
	// Mix reflected color with material color
	hal_FragColor += refractedColor;

#endif

	// --- COLLADA blending ---------------------------------------------------

#if defined(HAL_COLLADA_TRASPARENCY_PER_FRAGMENT2)

	if (hal_TransparentTexCoord >= 0) {
		// Get transparency value
		vec4 alphaFragment = TEXTURE_2D(hal_TransparentTexture, hal_VertexTexCoord[ds_TransparentTexCoord]);

		// Module transparency value
		alphaFragment *= hal_Transparency;

		// Blend functions: Src=ONE Dst=ONE_MINUS_ALPHA
		// -> Blend Src in shader (because blend function is ONE)
		hal_FragColor *= alphaFragment.a;
		// -> Set Src.a to blend Dst
		hal_FragColor.a = alphaFragment.a;
	}

#endif
}
