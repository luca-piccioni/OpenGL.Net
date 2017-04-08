
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
#include </OpenGL/TransformState.glsl>
#include </OpenGL/Light/Lighting.glsl>
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

// Vertex/Fragment position (model space)
SHADER_OUT vec4 glo_VertexPositionModel;
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
	glo_VertexPositionModel = glo_Model * glo_Position;
	glo_VertexPositionModelView = glo_ModelView * glo_Position;

#if defined(GLO_LIGHTING_PER_VERTEX)

	// Material initially defined by uniform colors
	glo_MaterialType fragmentMaterial = glo_FrontMaterial;

#if defined(GLO_COLOR_PER_VERTEX)
	// Material diffuse color is vertex color, if specified
	fragmentMaterial.DiffuseColor = glo_Color;
#endif

#if !defined(GLO_DEBUG_NORMAL)
	glo_VertexColor = ComputeLightShading(fragmentMaterial, glo_VertexPositionModelView, glo_VertexNormal);
#else
	glo_VertexColor = vec4(normalize(glo_Normal), 1.0);
#endif

#endif
}