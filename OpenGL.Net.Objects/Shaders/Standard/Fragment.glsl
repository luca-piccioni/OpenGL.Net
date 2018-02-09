
// Copyright (C) 2011-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

#include </OpenGL/Compatibility.glsl>
#include </OpenGL/TransformState.glsl>
#include </OpenGL/Light/MaterialState.glsl>
#include </OpenGL/Light/LightState.glsl>

// Vertex uniform color
uniform vec4 glo_UniformColor = vec4(1.0);

// Fragment color
SHADER_IN vec4 glo_VertexColor;
// Fragment normal (view space)
SHADER_IN vec3 glo_VertexNormal;
// Fragment texture coordinates
SHADER_IN vec2 glo_VertexTexCoord[1];
// Vertex/Fragment TBN space matrix
SHADER_IN mat3 glo_VertexTBN;
// Fragment vertex position (model-view space)
SHADER_IN vec4 glo_VertexPositionModelView;

// Fragment color
OUT vec4		glo_FragColor;

#if defined(GLO_LIGHTING_PER_FRAGMENT)

void mainLightingPerFragment()
{
	// Material initially defined by uniform colors
	glo_MaterialType fragmentMaterial = glo_FrontMaterial;
	int index;

	index = glo_FrontMaterialAmbientTexCoord;
	if (index >= 0)
		fragmentMaterial.AmbientColor = fragmentMaterial.AmbientColor * TEXTURE_2D(glo_FrontMaterialAmbientTexture, glo_VertexTexCoord[index]);

	index = glo_FrontMaterialEmissionTexCoord;
	if (index >= 0)
		fragmentMaterial.EmissiveColor = fragmentMaterial.EmissiveColor * TEXTURE_2D(glo_FrontMaterialEmissionTexture, glo_VertexTexCoord[index]);

	index = glo_FrontMaterialEmissionTexCoord;
	if (index >= 0)
		fragmentMaterial.EmissiveColor = fragmentMaterial.EmissiveColor * TEXTURE_2D(glo_FrontMaterialEmissionTexture, glo_VertexTexCoord[index]);

	index = glo_FrontMaterialSpecularTexCoord;
	if (index >= 0)
		fragmentMaterial.SpecularColor = fragmentMaterial.SpecularColor * TEXTURE_2D(glo_FrontMaterialSpecularTexture, glo_VertexTexCoord[index]);

#if defined(GLO_COLOR_PER_VERTEX)
	fragmentMaterial.DiffuseColor = fragmentMaterial.DiffuseColor * glo_VertexColor;
#endif

	index = glo_FrontMaterialDiffuseTexCoord;
	if (index >= 0)
		fragmentMaterial.DiffuseColor = fragmentMaterial.DiffuseColor * TEXTURE_2D(glo_FrontMaterialDiffuseTexture, glo_VertexTexCoord[index]);

	// Normal
	vec3 normal = normalize(glo_VertexNormal);

	index = glo_FrontMaterialNormalTexCoord;
	if (index >= 0) {
		normal = TEXTURE_2D(glo_FrontMaterialNormalTexture, glo_VertexTexCoord[index]).xyz * 2.0 - 1.0;
		normal = normalize(glo_VertexTBN * normalize(normal));
	}

#if   defined(GLO_DEBUG_NORMAL)
	glo_FragColor = vec4(abs(normalize(inverse(glo_NormalMatrix) * normal)), 1.0);
#elif defined(GLO_DEBUG_TANGENT)
	glo_FragColor = vec4(abs(glo_VertexTBN[0]), 1.0);
#elif defined(GLO_DEBUG_BITANGENT)
	glo_FragColor = vec4(abs(glo_VertexTBN[1]), 1.0);
#elif defined(GLO_DEBUG_TEXCOORD)
	glo_FragColor = vec4(abs(glo_VertexTexCoord[0].x), 0.0, 0.0, 1.0);
#else
	glo_FragColor = ComputeLightShading(fragmentMaterial, glo_VertexPositionModelView, normal);
#endif
}

#endif

#if defined(GLO_LIGHTING_PER_VERTEX)

void mainLightingPerVertex()
{
	int index;

	// Default
	glo_FragColor = glo_VertexColor;

	// No emission texture support!

	// Diffuse color from texture (modulated with vertex color)
	index = glo_FrontMaterialDiffuseTexCoord;
	if (glo_FrontMaterialDiffuseTexCoord >= 0)
		glo_FragColor = TEXTURE_2D(glo_FrontMaterialDiffuseTexture, glo_VertexTexCoord[index]) * glo_FragColor;
}

#endif

#if defined(GLO_TEXTURED)

uniform sampler2D glo_Texture;

void mainTextured()
{
#if defined(GLO_COLOR_PER_VERTEX)
	vec4 envColor = glo_VertexColor;
#else
	vec4 envColor = vec4(1.0, 1.0, 1.0, 1.0);
#endif

	glo_FragColor = TEXTURE_2D(glo_Texture, glo_VertexTexCoord[0]) * envColor;
}

#endif

void main()
{
#if defined(GLO_LIGHTING_PER_FRAGMENT)
	mainLightingPerFragment();
#elif defined(GLO_LIGHTING_PER_VERTEX)
	mainLightingPerVertex();
#elif defined(GLO_COLOR_PER_VERTEX)
	glo_FragColor = glo_VertexColor;
#elif defined(GLO_TEXTURED)
	mainTextured();
#else
	glo_FragColor = glo_UniformColor;
#endif
}