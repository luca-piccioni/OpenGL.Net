
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

uniform vec4 glo_UniformColor = vec4(1.0, 1.0, 1.0, 1.0);
uniform sampler2D glo_Texture;

SHADER_IN vec4 glo_VertexColor;
SHADER_IN vec2 glo_VertexTexCoord[1];

OUT vec4		glo_FragColor;

void main()
{
#if defined(GLO_COLOR_PER_VERTEX)
	vec4 envColor = glo_VertexColor;
#else
	vec4 envColor = glo_UniformColor;
#endif

	glo_FragColor = TEXTURE_2D(glo_Texture, glo_VertexTexCoord[0]) * envColor;
}

