
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
#include </OpenGL/ClipDistance.glsl>
#include </OpenGL/Light/LightState.glsl>
#include </Geo/GeoProject.glsl>

#if defined(GLO_POSITION_HP)
// Vertex position
LOCATION(0) ATTRIBUTE dvec4 glo_Position;
#else
// Vertex position
LOCATION(0) ATTRIBUTE vec4 glo_Position;
#endif

// Vertex color
// Note: this attribute can be instanced for batching uniform color per primitive
LOCATION(1) ATTRIBUTE vec4 glo_Color;
// Vertex normal
LOCATION(2) ATTRIBUTE vec3 glo_Normal;
// Vertex texture coordinates
LOCATION(3) ATTRIBUTE vec2 glo_TexCoord0;
// Vertex tangent
LOCATION(4) ATTRIBUTE vec3 glo_Tangent;
// Vertex bitangent
LOCATION(5) ATTRIBUTE vec3 glo_Bitangent;

// The depth of the primitive.
LOCATION(11) ATTRIBUTE float glo_PrimitiveDepthInstanced;
// The vertex model-view-projection matrix, instanced.
LOCATION(12) ATTRIBUTE mat4 glo_PrimitiveModelViewProjectionInstanced;

// Vertex/Fragment color
SHADER_OUT vec4 glo_VertexColor;
// Vertex/Fragment normal (view space)
SHADER_OUT vec3 glo_VertexNormal;
// Vertex/Fragment texture coordinates
SHADER_OUT vec2 glo_VertexTexCoord[1];
// Vertex/Fragment TBN space matrix
SHADER_OUT mat3 glo_VertexTBN;
// Vertex/Fragment depth of the primitive.
SHADER_OUT float glo_VertexPrimitiveDepthInstanced;

// Vertex/Fragment position (model-view space)
SHADER_OUT vec4 glo_VertexPositionModelView;

void main()
{
#if defined(GLO_GEOPROJECTION)
	// Note: only xy components are meaningful (x: lon, y: lat)
	vec2 gPosition = GeoProject(glo_Position.xy);
	// z component is likely 0: passthru value (i.e. depth)
	// w component always defaults to 1
	vec4 vPosition = vec4(gPosition.xy, 0.0, 1.0);
#else
	vec4 vPosition = glo_Position;
#endif

	vec3 vNormal = normalize(glo_Normal);
#if defined(GLO_MVP_INSTANCED)
	mat4 vMVP = glo_PrimitiveModelViewProjectionInstanced;
#else
	mat4 vMVP = glo_ModelViewProjection;
#endif

	gl_Position = vMVP * vPosition;

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

#if defined(GLO_LIGHTING_PER_VERTEX)

	// Positions required for lighting
	glo_VertexPositionModelView = glo_ModelView * glo_Position;

	// Material initially defined by uniform colors
	glo_MaterialType fragmentMaterial = glo_FrontMaterial;

#if defined(GLO_COLOR_PER_VERTEX)
	// Material diffuse color is vertex color, if specified
	fragmentMaterial.DiffuseColor = glo_Color;
#endif

	glo_VertexColor = ComputeLightShading(fragmentMaterial, glo_VertexPositionModelView, glo_VertexNormal);

#endif

	// Support clipping planes (loop unroll because MESA complaints about it)
	// for (int i = 0; i < 8; i++)
	// 	gl_ClipDistance[i] = dot(vPosition, glo_ClipPlanes[i]);
	gl_ClipDistance[0] = dot(vPosition, glo_ClipPlanes[0]);
	gl_ClipDistance[1] = dot(vPosition, glo_ClipPlanes[1]);
	gl_ClipDistance[2] = dot(vPosition, glo_ClipPlanes[2]);
	gl_ClipDistance[3] = dot(vPosition, glo_ClipPlanes[3]);
	gl_ClipDistance[4] = dot(vPosition, glo_ClipPlanes[4]);
	gl_ClipDistance[5] = dot(vPosition, glo_ClipPlanes[5]);
	gl_ClipDistance[6] = dot(vPosition, glo_ClipPlanes[6]);
	gl_ClipDistance[7] = dot(vPosition, glo_ClipPlanes[7]);
	// Primitive depth
	glo_VertexPrimitiveDepthInstanced = glo_PrimitiveDepthInstanced;
}