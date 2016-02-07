
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
uniform float hal_ElevationNoDataValue = -1.0;
// The scale applied to the elevation map value
uniform float hal_ElevationMapScale = 32767.0;

// Vertex texture coordinates
ATTRIBUTE vec2 hal_TexCoord0;

// Elevation of the clipmap vertex
out vec4 hal_ClipmapElevation;

void main()
{
	vec2 hal_ElevationMapSize = textureSize(hal_ElevationMap);

	// Elevation, normalized in [-1.0,+1.0]
	float elevation = texture(hal_ElevationMap, hal_TexCoord0);
}