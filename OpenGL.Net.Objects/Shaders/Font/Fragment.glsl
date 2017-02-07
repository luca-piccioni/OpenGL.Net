
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

// Uniform color
uniform vec4 glo_UniformColor = vec4(1.0, 1.0, 1.0, 1.0);
// Glyph texture
uniform sampler2DArray glo_FontGlyph;

// Fragment texture coordinates
SHADER_IN vec3 glo_VertexTexCoord;

// Fragment color
OUT vec4		glo_FragColor;

void main()
{
#if defined(GLO_FONT_TEXTURE_ARRAY)
	glo_FragColor = vec4(glo_UniformColor.rgb, glo_UniformColor.a * texture(glo_FontGlyph, glo_VertexTexCoord).r);
#else
	glo_FragColor = glo_UniformColor;
#endif
}