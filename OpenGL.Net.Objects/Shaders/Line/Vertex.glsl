
// Copyright (C) 2012-2015 Luca Piccioni
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
#include </Geo/GeoProject.glsl>

// Vertex position
LOCATION(0) ATTRIBUTE vec4 glo_Position;
// Vertex color
LOCATION(1) ATTRIBUTE vec4 glo_Color;

// Vertex depth.
LOCATION(11) ATTRIBUTE float glo_PrimitiveDepth;
// The vertex model-view-projection matrix, instanced.
LOCATION(12) ATTRIBUTE mat4 glo_PrimitiveModelViewProjection;

// Processed vertex color
SHADER_OUT vec4 glo_VertexColor;
// Vertex/Fragment depth of the primitive.
SHADER_OUT float glo_VertexDepth;
// Processed vertex distance
SHADER_OUT float glo_VertexDistance;

void main()
{
#if defined(GLO_PRIMITIVE_MVP)
	mat4 vMVP = glo_PrimitiveModelViewProjection;
#else
	mat4 vMVP = glo_ModelViewProjection;
#endif

	// Support stipple pattern
	// Does not work with negative scales
	// https://math.stackexchange.com/questions/237369/given-this-transformation-matrix-how-do-i-decompose-it-into-translation-rotati/417813
	float distanceScale = length(glo_ModelView[2].xyz);

#if defined(GLO_GEOPROJECTION)
	vec2 position = GeoProject(glo_Position.xy);
#else
	vec2 position = glo_Position.xy;
#endif

	// Vertex position
	gl_Position = vMVP * vec4(position, 0.0, 1.0);
	// Vertex color
	glo_VertexColor = glo_Color;
	// Primitive depth
	glo_VertexDepth = glo_PrimitiveDepth;
	// Vertex distance
	glo_VertexDistance = glo_Position.z + distanceScale;
}
