
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

// Vertex position
LOCATION(0) ATTRIBUTE vec4 glo_Position;
// Vertex color
LOCATION(1) ATTRIBUTE vec4 glo_Color;
// Vertex normal
LOCATION(2) ATTRIBUTE vec3 glo_Normal;
// Vertex texture coordinates
LOCATION(3) ATTRIBUTE vec2 glo_TexCoord0;
// Vertex texture coordinates
LOCATION(3) ATTRIBUTE vec3 glo_Tangent;

// Vertex/Fragment color
SHADER_OUT vec4 glo_VertexColor;
// Vertex/Fragment normal (view space)
SHADER_OUT vec3 glo_VertexNormal;
// Vertex/Fragment texture coordinates
SHADER_OUT vec2 glo_VertexTexCoord[1];
// Vertex/Fragment TBN space matrix
SHADER_OUT mat3 glo_VertexTBN;

// Vertex/Fragment position (model space)
SHADER_OUT vec4 glo_VertexPosition;
// Vertex/Fragment normal (model space)
SHADER_OUT vec3 glo_VertexNormalModel;

void main()
{
	gl_Position = glo_ModelViewProjection * glo_Position;

	glo_VertexColor = glo_Color;
	glo_VertexNormal =  normalize(glo_NormalMatrix * normalize(glo_Normal));
	glo_VertexTexCoord[0] = glo_TexCoord0;

	vec3 tbnT = normalize(vec3(glo_ModelView * vec4(glo_Tangent, 0.0)));
	vec3 tbnB = normalize(vec3(glo_ModelView * vec4(cross(glo_Tangent, glo_Normal), 0.0)));
	vec3 tbnN = normalize(vec3(glo_ModelView * vec4(glo_Normal, 0.0)));
	
	glo_VertexTBN = mat3(tbnT, tbnB, tbnN);

	// Position is required for lighting
	glo_VertexPosition = glo_ModelView * glo_Position;
	// Normal (model) is required for environment mapping
	glo_VertexNormalModel = normalize(mat3x3(glo_ModelView) * normalize(glo_Normal));

#if defined(GLO_LIGHTING_PER_VERTEX)

	// Material initially defined by uniform colors
	glo_MaterialType fragmentMaterial = glo_FrontMaterial;

#if defined(GLO_COLOR_PER_VERTEX)
	// Material diffuse color is vertex color, if specified
	fragmentMaterial.DiffuseColor = glo_Color;
#endif

#if !defined(GLO_DEBUG_NORMAL)
	glo_VertexColor = ComputeLightShading(fragmentMaterial, glo_VertexPosition, glo_VertexNormal);
#else
	glo_VertexColor = vec4(normalize(glo_Normal), 1.0);
#endif

#endif
}
