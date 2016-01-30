
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

#include </OpenGL/TransformState.glsl>

// The elevation map determining the vertex height
uniform sampler2DArray hal_ElevationMap;
// Value indicating an undefined value (to be compared with not scaled sample)
uniform float hal_ElevationNoDataValue = -1.0;
// The scale applied to the elevation map value
uniform float hal_ElevationMapScale = 32768.0;

// Alignment of the geometry clipmap grids.
uniform vec2 hal_GridOffset[16];

// Position/texture coord
in vec2 hal_Position;
// Block offset and scale factor (instanced)
// XY: offset
// ZW: scale
in vec4 hal_BlockOffset;
// Elevation map offset and scale factors (instanced)
// XY: offset
// ZW: scale
in vec4 hal_MapOffset;
// The actual LOD level associated to this instance (instanced)
in float hal_Lod;
// The instance color, for debugging (instanced)
in vec4 hal_BlockColor;

// Vertex color
out vec4 hal_VertexColor;

void main()
{
	// Offset and scale vertex position (and grid alignment)
	vec2 worldPosition = (hal_Position * hal_BlockOffset.zw) + hal_BlockOffset.xy + hal_GridOffset[int(hal_Lod)];
	// Offset and scale vertex texture coordinate
	vec2 elevationCoord = hal_Position * hal_MapOffset.zw + hal_MapOffset.xy;

	// Extract elevation map information
	vec4 elevationFragment = texture(hal_ElevationMap, vec3(elevationCoord, hal_Lod));

	if (elevationFragment.x == hal_ElevationNoDataValue)
		elevationFragment.x = 0.0;

	// Vertex position
	gl_Position = hal_ModelViewProjection * vec4(worldPosition.x, elevationFragment.x * hal_ElevationMapScale, worldPosition.y, 1.0);
	// Vertex color
	hal_VertexColor = hal_BlockColor;
}
