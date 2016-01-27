

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
#include </OpenGL/TransformState.glsl>
// #include </OpenGL/Light/ILightShading.glsl>

// Vertex position
ATTRIBUTE vec4 hal_Position;
// Vertex color
ATTRIBUTE vec4 hal_Color;
// Vertex normal
ATTRIBUTE vec3 hal_Normal;
// Vertex texture coordinates
ATTRIBUTE vec2 hal_TexCoord0;
// Vertex texture coordinates
ATTRIBUTE vec2 hal_TexCoord1;
// Vertex texture coordinates
ATTRIBUTE vec2 hal_TexCoord2;

BEGIN_OUTPUT_BLOCK(ds_PerVertex)
	// Vertex/Fragment color
	SHADER_OUT vec4 hal_VertexColor;
	// Vertex/Fragment position (model space)
	SHADER_OUT vec4 hal_VertexPosition;
	// Vertex/Fragment normal (view space)
	SHADER_OUT vec3 hal_VertexNormal;
	// Vertex/Fragment normal (model space)
	SHADER_OUT vec3 hal_VertexNormalModel;
	// Vertex/Fragment texture coordinates
	SHADER_OUT vec2 hal_VertexTexCoord[3];
END_OUTPUT_BLOCK()

void main()
{
	// Compute transformed vertex position
	gl_Position = hal_ModelViewProjection * hal_Position;
	// Normal is required for lighting
	hal_VertexNormal = hal_NormalMatrix * normalize(hal_Normal);
	// Normal (model) is required for environment mapping
	hal_VertexNormalModel = mat3x3(hal_ModelView) * normalize(hal_Normal);
	// Vertex texture coordinate "as is"
	hal_VertexTexCoord[0] = hal_TexCoord0;
	hal_VertexTexCoord[1] = hal_TexCoord1;
	hal_VertexTexCoord[2] = hal_TexCoord2;

#if defined(HAL_LIGHTING_PER_VERTEX)

	// Material initially defined by uniform colors
	hal_MaterialType fragmentMaterial = hal_FrontMaterial;

#if defined(HAL_COLOR_PER_VERTEX)
	// Material diffuse color is vertex color, if specified
	fragmentMaterial.DiffuseColor = hal_Color;
#endif

	// Vertex color
	hal_VertexColor = ComputeLightShading(fragmentMaterial, hal_ModelView * hal_Position, hal_NormalMatrix * normalize(ds_Normal));

#elif defined(HAL_LIGHTING_PER_FRAGMENT)

	// Position is required for lighting
	hal_VertexPosition = hal_ModelView * hal_Position;
	// Vertex color "as is"
	hal_VertexColor = hal_Color;

#elif defined(HAL_COLOR_PER_VERTEX)

	// Vertex color "as is"
	hal_VertexColor = hal_Color;

#endif
}
