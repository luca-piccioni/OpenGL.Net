
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

// Uniform color
uniform vec4 glo_UniformColor = vec4(1.0, 1.0, 1.0, 1.0);
// Glyph texture
uniform sampler2DArray glo_FontGlyph;

#if defined(GLO_OVERRIDE_FRAGMENT_DEPTH)
// Fragments has uniform depth (0.0 -> far, 1.0 -> near)
uniform float	glo_FragmentDepth = 1.0;
#endif

// Fragment texture coordinates
SHADER_IN vec3 glo_VertexTexCoord;

// Fragment color
OUT vec4		glo_FragColor;

void main()
{
	vec2 fontColor = texture(glo_FontGlyph, glo_VertexTexCoord).ra;

	glo_FragColor = vec4(glo_UniformColor.rgb * vec3(fontColor.r), glo_UniformColor.a * fontColor.g);
	if (glo_FragColor.a <= 0.0)
		discard;

#if   defined(GLO_OVERRIDE_FRAGMENT_DEPTH)
	gl_FragDepth = glo_FragmentDepth;
#endif
}