
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

// Vertex position (object space)
SHADER_IN vec4 glo_VertexPositionObject[];
// Vertex normal (object space)
SHADER_IN vec3 glo_VertexNormalObject[];
// Vertex TBN space matrix
SHADER_IN mat3 glo_VertexTBN[];

// Fragment color
SHADER_OUT vec4 glo_VertexColor;

layout(line_strip, max_vertices = 6) out;
layout(points) in;

void main()
{
	vec4 v = glo_VertexPositionObject[0];

	// Homogeneous coordinates required
	v = vec4(v.xyz / v.w, 1.0);

#if defined(GLO_NORMALS_TBN)
	vec3 t, b, n;
	vec4 v0 = glo_ModelViewProjection * v;

	// Tangent
	gl_Position = v;
	glo_VertexColor = vec4(1.0, 0.0, 0.0, 1.0);
	EmitVertex();
	gl_Position = gl_PositionIn[0] + vec4(t, 1.0);
	glo_VertexColor = vec4(1.0, 0.0, 0.0, 1.0);
	EmitVertex();
	EndPrimitive();

	// Bitangent
	gl_Position = v;
	glo_VertexColor = vec4(0.0, 1.0, 0.0, 1.0);
	EmitVertex();
	gl_Position = gl_PositionIn[0] + vec4(b, 1.0);
	glo_VertexColor = vec4(0.0, 1.0, 0.0, 1.0);
	EmitVertex();
	EndPrimitive();

	// Normal
	gl_Position = v;
	glo_VertexColor = vec4(0.0, 0.0, 1.0, 1.0);
	EmitVertex();
	gl_Position = gl_PositionIn[0] + vec4(n, 1.0);
	glo_VertexColor = vec4(0.0, 0.0, 1.0, 1.0);
	EmitVertex();
	EndPrimitive();
#else
	// Normal
	gl_Position = glo_ModelViewProjection * v;
	glo_VertexColor = vec4(0.0, 0.0, 1.0, 1.0);
	EmitVertex();
	gl_Position = glo_ModelViewProjection * (v + vec4(glo_VertexNormalObject[0], 1.0));
	glo_VertexColor = vec4(0.0, 0.0, 1.0, 1.0);
	EmitVertex();
	EndPrimitive();
#endif
}