
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
#include </OpenGL/Light/LightState.glsl>

// Vertex position
LOCATION(0) ATTRIBUTE vec4 glo_Position;
// Vertex color
LOCATION(1) ATTRIBUTE vec4 glo_Color;
// Vertex normal
LOCATION(2) ATTRIBUTE vec3 glo_Normal;
// Vertex texture coordinates
LOCATION(3) ATTRIBUTE vec2 glo_TexCoord0;
// Vertex tangent
LOCATION(4) ATTRIBUTE vec3 glo_Tangent;
// Vertex bitangent
LOCATION(5) ATTRIBUTE vec3 glo_Bitangent;

// Vertex/Fragment color
SHADER_OUT vec4 glo_VertexColor;
// Vertex/Fragment normal (view space)
SHADER_OUT vec3 glo_VertexNormal;
// Vertex/Fragment texture coordinates
SHADER_OUT vec2 glo_VertexTexCoord[1];
// Vertex/Fragment TBN space matrix
SHADER_OUT mat3 glo_VertexTBN;

// Vertex/Fragment position (model-view space)
SHADER_OUT vec4 glo_VertexPositionModelView;

void main()
{
	vec4 vPosition = glo_Position;
	vec3 vNormal = normalize(glo_Normal);

	gl_Position = glo_ModelViewProjection * vPosition;

	vec3 vNormalView = normalize(glo_NormalMatrix * vNormal);
	vec3 vTangent = normalize(glo_Tangent);

	glo_VertexColor = glo_Color;
	glo_VertexNormal = vNormalView;
	glo_VertexTexCoord[0] = glo_TexCoord0;

	// Tangent to view
	vec3 tbnT = normalize(glo_NormalMatrix * vTangent);
	vec3 tbnB = normalize(glo_NormalMatrix * glo_Bitangent);
	vec3 tbnN = vNormalView;
	// re-orthogonalize T with respect to N
	// tbnT = normalize(tbnT - dot(tbnT, tbnN) * tbnN);
	glo_VertexTBN = mat3(tbnT, tbnB, tbnN);

	// Positions required for lighting
	glo_VertexPositionModelView = glo_ModelView * glo_Position;

#if defined(GLO_LIGHTING_PER_VERTEX)

	// Material initially defined by uniform colors
	glo_MaterialType fragmentMaterial = glo_FrontMaterial;

#if defined(GLO_COLOR_PER_VERTEX)
	// Material diffuse color is vertex color, if specified
	fragmentMaterial.DiffuseColor = glo_Color;
#endif

	glo_VertexColor = ComputeLightShading(fragmentMaterial, glo_VertexPositionModelView, glo_VertexNormal);

#endif
}