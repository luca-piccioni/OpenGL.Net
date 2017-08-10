
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

#if defined(GL_ARB_shader_draw_parameters)

#ifndef GLO_FONT_MAX_LENGTH
#define GLO_FONT_MAX_LENGTH 256
#endif

// The model-view-projection matrix
uniform mat4 glo_CharModelViewProjection[GLO_FONT_MAX_LENGTH];

#endif

// Vertex position
LOCATION(0) ATTRIBUTE vec2 glo_Position;

void main()
{
#if defined(GL_ARB_shader_draw_parameters)
	gl_Position = glo_CharModelViewProjection[gl_DrawIDARB] * vec4(glo_Position, 0.0, 1.0);
#else
	gl_Position = glo_ModelViewProjection * vec4(glo_Position, 0.0, 1.0);
#endif
}