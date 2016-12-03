

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

// Vertex position
ATTRIBUTE vec4 glo_Position;
// Vertex color
ATTRIBUTE vec4 glo_Color;
// Vertex normal
ATTRIBUTE vec3 glo_Normal;
// Vertex texture coordinates
ATTRIBUTE vec2 glo_TexCoord0;
// Vertex texture coordinates
ATTRIBUTE vec2 glo_TexCoord1;
// Vertex texture coordinates
ATTRIBUTE vec2 glo_TexCoord2;

// Vertex/Fragment color
SHADER_OUT vec4 glo_VertexColor;
// Vertex/Fragment position (model space)
SHADER_OUT vec4 glo_VertexPosition;
// Vertex/Fragment normal (view space)
SHADER_OUT vec3 glo_VertexNormal;
// Vertex/Fragment normal (model space)
SHADER_OUT vec3 glo_VertexNormalModel;
// Vertex/Fragment texture coordinates
SHADER_OUT vec2 glo_VertexTexCoord[3];

void main()
{
	// Compute transformed vertex position
	gl_Position = glo_ModelViewProjection * glo_Position;
	// Vertex color "as is"
	glo_VertexColor = glo_Color;
	// Position is required for lighting
	glo_VertexPosition = glo_ModelView * glo_Position;
	// Normal is required for lighting
	glo_VertexNormal = glo_NormalMatrix * normalize(glo_Normal);
	// Normal (model) is required for environment mapping
	glo_VertexNormalModel = mat3x3(glo_ModelView) * normalize(glo_Normal);
	// Vertex texture coordinate "as is"
	glo_VertexTexCoord[0] = glo_TexCoord0;
	glo_VertexTexCoord[1] = glo_TexCoord1;
	glo_VertexTexCoord[2] = glo_TexCoord2;

#if defined(GLO_LIGHTING_PER_VERTEX)

	// Material initially defined by uniform colors
	glo_MaterialType fragmentMaterial = glo_FrontMaterial;

#if defined(GLO_COLOR_PER_VERTEX)
	// Material diffuse color is vertex color, if specified
	fragmentMaterial.DiffuseColor = glo_Color;
#endif

	// Vertex color
	glo_VertexColor = ComputeLightShading(fragmentMaterial, glo_ModelView * glo_Position, glo_NormalMatrix * normalize(ds_Normal));

#endif
}
