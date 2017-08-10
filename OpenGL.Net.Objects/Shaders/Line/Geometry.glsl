
// Copyright (C) 2012-2017 Luca Piccioni
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