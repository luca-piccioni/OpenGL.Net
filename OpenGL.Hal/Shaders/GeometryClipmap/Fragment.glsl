
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

// Symbol for debugging texture coordinates
#undef DEBUG_TEX_COORD
// Symbol for debugging normals
#undef DEBUG_NORMAL

// Direction of the sun's rays
uniform vec3 hal_SunDirection = vec3(1.0, 1.0, 0.0);

// Normal vector
in vec3 hal_VertexNormal;
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
#elif defined(DEBUG_NORMAL)
	hal_FragColor = vec4(hal_VertexNormal, 1.0);
#else
	// Base color
	hal_FragColor = hal_VertexColor;
	// Diffuse lighting
	float diffuse = dot(hal_VertexNormal, normalize(hal_SunDirection));
	hal_FragColor = hal_VertexColor * clamp(diffuse, 0.0, 1.0);

	// Perspective correction
	// gl_FragDepth = log2(flogz) * Fcoef_half; where Fcoef_half = 0.5 * Fcoef
#endif
}