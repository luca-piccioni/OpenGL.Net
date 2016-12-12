
// Copyright (C) 2016 Luca Piccioni
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

// Vertex/Fragment texture coordinates
SHADER_OUT vec3 glo_VertexCubeTexCoord;

void main()
{
	// Compute transformed vertex position
	vec4 position = glo_ModelViewProjection * glo_Position;
	// Vertex texture coordinate (assume centered geometry)
	glo_VertexCubeTexCoord = glo_Position.xyz / glo_Position.w;

	gl_Position = position.xyww;
}