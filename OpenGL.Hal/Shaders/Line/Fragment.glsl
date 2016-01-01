
// Copyright (C) 2012-2015 Luca Piccioni
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

// Vertex uniform color
uniform vec4 hal_UniformColor = vec4(1.0, 1.0, 1.0, 1.0);

// Processed primitive vertex color (vertex color)
SHADER_IN vec4 hal_VertexColor;
// Processed primitive vertex color (geometry color)
SHADER_IN vec4 hal_GeoColor;

// The fragment color
SHADER_OUT vec4 hal_FragColor;

void main()
{
#if defined(HAL_COLOR_PER_VERTEX)

#if __VERSION__ >= 150
	hal_FragColor = hal_GeoColor;
#else
	hal_FragColor = hal_VertexColor;
#endif
	
#else

	hal_FragColor = hal_UniformColor;

#endif
}

