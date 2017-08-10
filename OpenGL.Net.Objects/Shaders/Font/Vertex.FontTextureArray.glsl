
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

// Vertex position
LOCATION(0) ATTRIBUTE vec2 glo_Position;

#if defined(GLO_INSTANCED_ARRAY)

// Glyph model-view-projection matrix (instanced array)
LOCATION(1) ATTRIBUTE mat4 glo_GlyphModelViewProjection;
// Glyph vertex parameters (instanced); xy=vertex scale z=texture layer (instanced array)
LOCATION(5) ATTRIBUTE vec3 glo_GlyphVertexParams;
// Glyph vertex parameters  (instanced array)
LOCATION(6) ATTRIBUTE vec2 glo_GlyphTexParams;

#elif defined(GLO_INSTANCED)

// The glyph model applied
struct glo_GlyphType
{
	// Glyph model-view-projection matrix.
	mat4 ModelViewProjection;
	// Glyph model-view-projection matrix.
	vec3 VertexParams;
	// Glyph vertex parameters
	vec2 TexParams;
};

BLOCK_BEGIN_LAYOUT(Glyphs, std140)
	// Glyphs information (instanced)
	BLOCK_FIELD glo_GlyphType glo_Glyphs[64];
BLOCK_END_ANON()

#else

#include </OpenGL/TransformState.glsl>

// Glyph model-view-projection matrix.
uniform vec3 glo_VertexParams;
// Glyph vertex parameters
uniform vec2 glo_TexParams;

#endif


// Vertex/Fragment texture coordinates
SHADER_OUT vec3 glo_VertexTexCoord;

void main()
{
#if defined(GLO_INSTANCED_ARRAY)
	gl_Position = glo_GlyphModelViewProjection * vec4(glo_Position * glo_GlyphVertexParams.xy, 0.0, 1.0);
	glo_VertexTexCoord = vec3(glo_Position * glo_GlyphTexParams, glo_GlyphVertexParams.z);
#elif defined(GLO_INSTANCED)
	mat4 mvp = glo_Glyphs[gl_InstanceID].ModelViewProjection;
	vec3 vparams = glo_Glyphs[gl_InstanceID].VertexParams;
	vec2 tparams = glo_Glyphs[gl_InstanceID].TexParams;

	gl_Position = mvp * vec4(glo_Position * vparams.xy, 0.0, 1.0);
	glo_VertexTexCoord = vec3(glo_Position * tparams, vparams.z);
#else
	gl_Position = glo_ModelViewProjection * vec4(glo_Position * glo_VertexParams.xy, 0.0, 1.0);
	glo_VertexTexCoord = vec3(glo_Position * glo_TexParams, glo_VertexParams.z);
#endif
}