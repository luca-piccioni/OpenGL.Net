
// Copyright (C) 2012-2017 Luca Piccioni
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

// Vertex uniform color
uniform vec4 glo_UniformColor = vec4(1.0, 1.0, 1.0, 1.0);
// Line stipple pattern
uniform uint glo_LineStipple = uint(0x0000FFFF);
// Line stipple repeat factor
uniform float glo_LineStippleFactor = 1.0;
// Line stipple repeat factor scalle
uniform float glo_LineStippleFactorScale = 1.0;

// Processed primitive vertex color (vertex color)
SHADER_IN vec4 glo_VertexColor;
// Processed primitive vertex color (geometry color)
SHADER_IN vec4 glo_GeoColor;
// Processed primitive depth
SHADER_IN float glo_GeoDepth;
// Processed primitive stipple coordinate
SHADER_IN float glo_GeoStippleCoord;

#if defined(GLO_OVERRIDE_FRAGMENT_DEPTH)
// Fragments has uniform depth (0.0 -> far, 1.0 -> near)
uniform float	glo_FragmentDepth = 1.0;
#endif

// The fragment color
SHADER_OUT vec4 glo_FragColor;
// Fragment depth
// OUT float		gl_FragDepth;

void main()
{
#if defined(GLO_LINE_STIPPLE)
	uint patternBitPosition = uint(round(glo_GeoStippleCoord * glo_LineStippleFactorScale / glo_LineStippleFactor)) & 15U;
	if ((glo_LineStipple & (1U << patternBitPosition)) == 0U)
		discard;
#endif

#if defined(GLO_COLOR_PER_VERTEX)

#if __VERSION__ >= 150
	glo_FragColor = glo_GeoColor;
#else
	glo_FragColor = glo_VertexColor;
#endif
	
#else
	glo_FragColor = glo_UniformColor;
#endif

#if   defined(GLO_OVERRIDE_FRAGMENT_DEPTH)
	gl_FragDepth = glo_FragmentDepth;
#elif defined(GLO_OVERRIDE_FRAGMENT_DEPTH_INSTANCED)
	gl_FragDepth = glo_GeoDepth;
#endif
}

