
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

uniform sampler2D glo_Texture;
uniform vec2 glo_NearFar;

SHADER_IN vec4 glo_VertexColor;
SHADER_IN vec2 glo_VertexTexCoord[1];

OUT vec4		glo_FragColor;

void main()
{
	float depth = TEXTURE_2D(glo_Texture, glo_VertexTexCoord[0]).r;
	
	depth = depth * 2.0 - 1.0;			// To NDC
	depth = (2.0 * glo_NearFar.x * glo_NearFar.y) / (glo_NearFar.x + glo_NearFar.y - depth * (glo_NearFar.y - glo_NearFar.x));
	depth = depth / glo_NearFar.y;

	glo_FragColor = vec4(vec3(depth), 1.0);
}

