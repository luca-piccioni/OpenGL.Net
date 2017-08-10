
// Copyright (C) 2017 Luca Piccioni
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
LOCATION(0) ATTRIBUTE vec4 glo_Position;
// Vertex texture coordinates
LOCATION(3) ATTRIBUTE vec2 glo_TexCoord0;

// Vertex/Fragment color
SHADER_OUT vec4 glo_VertexColor;
// Vertex/Fragment texture coordinates
SHADER_OUT vec2 glo_VertexTexCoord[1];

void main()
{
	gl_Position = glo_ModelViewProjection * glo_Position;
	glo_VertexTexCoord[0] = glo_TexCoord0;
}
