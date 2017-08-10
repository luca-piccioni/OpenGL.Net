
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
#include </OpenGL/Viewport.glsl>

// Line width, in pixels
uniform float glo_LineWidth = 1.0;

// Processed vertex color
SHADER_IN vec4 glo_VertexColor[2];

// Processed primitive vertex color
SHADER_OUT vec4 glo_GeoColor;

GEOMETRY_LAYOUT_IN(lines);
GEOMETRY_LAYOUT(triangle_strip, 4);

void main()
{
	vec4 a = gl_in[0].gl_Position, b = gl_in[1].gl_Position;

	// Manually clip line before NDC homogenization
	if (ClipLineVertices(a, b))
		return;

	// Compute homogenized coordinates
	vec3 ndc0 = a.xyz / a.w;
	vec3 ndc1 = b.xyz / b.w;

	// Generate quad corresponding to the line (width in screen space)
	vec2 lineScreenForward = normalize(ndc1.xy - ndc0.xy);
	vec2 lineScreenRight = vec2(-lineScreenForward.y, lineScreenForward.x);
	vec2 lineScreenOffset = (vec2(glo_LineWidth) / glo_ViewportSize) * lineScreenRight;

	gl_Position = vec4(ndc0.xy + lineScreenOffset, ndc0.z, 1.0);
	glo_GeoColor = glo_VertexColor[0];
	EmitVertex();

	gl_Position = vec4(ndc0.xy - lineScreenOffset, ndc0.z, 1.0);
	glo_GeoColor = glo_VertexColor[0];
	EmitVertex();

	gl_Position = vec4(ndc1.xy + lineScreenOffset, ndc1.z, 1.0);
	glo_GeoColor = glo_VertexColor[1];
	EmitVertex();

	gl_Position = vec4(ndc1.xy - lineScreenOffset, ndc1.z, 1.0);
	glo_GeoColor = glo_VertexColor[1];
	EmitVertex();

	EndPrimitive();
}