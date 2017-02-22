
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

// Vertex position
LOCATION(0) ATTRIBUTE vec2 glo_Position;
// Glyph model-view-projection matrix (instanced)
LOCATION(1) ATTRIBUTE mat4 glo_GlyphModelViewProjection;
// Glyph vertex parameters (instanced); xy=vertex scale z=texture layer
LOCATION(5) ATTRIBUTE vec3 glo_GlyphVertexParams;
// Glyph vertex parameters (instanced);
LOCATION(6) ATTRIBUTE vec2 glo_GlyphTexParams;

// Vertex/Fragment texture coordinates
SHADER_OUT vec3 glo_VertexTexCoord;

void main()
{
	gl_Position = glo_GlyphModelViewProjection * vec4(glo_Position * glo_GlyphVertexParams.xy, 0.0, 1.0);
	glo_VertexTexCoord = vec3(glo_Position * glo_GlyphTexParams, glo_GlyphVertexParams.z);
}