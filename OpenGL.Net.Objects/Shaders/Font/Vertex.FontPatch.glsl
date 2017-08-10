
// Copyright (C) 2017 Luca Piccioni
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