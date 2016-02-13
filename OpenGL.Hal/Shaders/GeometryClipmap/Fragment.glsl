
// Copyright (C) 2016 Luca Piccioni
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

#undef DEBUG_TEX_COORD

// Texture coord
in vec2 hal_VertexTexCoord;
// Vertex color
in vec4 hal_VertexColor;

// The fragment color
out vec4 hal_FragColor;

void main()
{
#if defined(DEBUG_TEX_COORD)
	vec4 defaultColor = hal_VertexColor;

	if (hal_VertexTexCoord.x > (0.5 - 0.1) && hal_VertexTexCoord.x < (0.5 + 0.1))
		defaultColor = vec4(1.0, 0.0, 0.0, 1.0);

	hal_FragColor = defaultColor;
#else
	hal_FragColor = hal_VertexColor;
#endif
}