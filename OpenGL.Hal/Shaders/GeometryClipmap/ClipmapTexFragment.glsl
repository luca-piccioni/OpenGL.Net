
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

// The elevation map determining the vertex height
uniform sampler2D hal_ElevationMap;
// Value indicating an undefined value (to be compared with not scaled sample)
uniform float hal_ElevationNoDataValue = -9999.0;
// The scale applied to the elevation map value
uniform float hal_ElevationMapScale = 32767.0;

// Vertex texture coordinates
ATTRIBUTE vec2 hal_TexCoord0;

// Elevation of the clipmap vertex
// w: normalized elevation
// xyz: normal vector (normalized)
out vec4 hal_ClipmapElevation;

void main()
{
	vec2 elevationMapSize = textureSize(hal_ElevationMap);
	vec3 texOffset = vec3(+1.0 / elevationMapSize.x, +1.0 / elevationMapSize.y, 0.0);

	// Elevation, normalized in [-1.0,+1.0]
	float ele = texture(hal_ElevationMap, hal_TexCoord0).r;
	// Get normal
	float eleX = texture(hal_ElevationMap, hal_TexCoord0 + texOffset.xz).r;
	float eleY = texture(hal_ElevationMap, hal_TexCoord0 - texOffset.yz).r;

	vec3 normalX = vec3(1.0f, eleX - ele, 0.0);
	vec3 normalZ = vec3(0.0f, eleY - ele, 1.0);
	vec3 normal = cross(normalX, normalZ);

	hal_ClipmapElevation = vec4(normalize(normal), ele);
}