
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

#include </OpenGL/TransformState.glsl>

// The elevation map determining the vertex height
uniform sampler2DArray hal_ElevationMap;
// Size of hal_ElevationMap
// Note: on my system, textureSize seems not working in this case
uniform float hal_ElevationMapSize = 16.0;
// Value indicating an undefined value (to be compared with not scaled sample)
uniform float hal_ElevationNoDataValue = -1.0;
// The scale applied to the elevation map value
uniform float hal_ElevationMapScale = 32767.0;

// Alignment of the geometry clipmap grids
uniform vec2 hal_GridOffset[16];
// Size of the unit quad
uniform float hal_GridUnitScale = 100.0;

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
// X: LOD for texturing
// Y: LOD for position offset
in vec2 hal_Lod;
// The instance color, for debugging (instanced)
in vec4 hal_BlockColor;

// Normal vector
out vec3 hal_VertexNormal;
// Texture coord
out vec2 hal_VertexTexCoord;
// Vertex color
out vec4 hal_VertexColor;
// Perspective correction for logarithmic depth
out float hal_VertexLogZ;

void main()
{
	vec2 gridOffsetPos = hal_GridOffset[int(hal_Lod.y)];
	vec2 gridOffsetTex = hal_GridOffset[int(hal_Lod.x)];

	// Offset and scale vertex position and texture coord
	vec2 worldPosition = hal_Position * hal_BlockOffset.zw + hal_BlockOffset.xy + gridOffsetPos;
	vec2 elevationCoord = hal_Position * hal_MapOffset.zw + hal_MapOffset.xy;

	// If position and texture coordinate uses different offset, translate texture coordinates accordingly
	vec2 elevationCoordOffset = gridOffsetTex - gridOffsetPos;
	float vertexUnitQuad = hal_GridUnitScale * pow(2.0, hal_Lod.x - 1);
	vec2 elevationCoordGridOffset = elevationCoordOffset / vec2(vertexUnitQuad);
	vec3 elevationMapSize = textureSize(hal_ElevationMap, int(hal_Lod.x));
	vec2 elevationTextelSize = vec2(0.5) / elevationMapSize.xy;
	
	elevationCoord -= elevationCoordGridOffset * vec2(0.5 / hal_ElevationMapSize);

	vec4 elevationFragment = texture(hal_ElevationMap, vec3(elevationCoord, hal_Lod.x));

	// Vertex attributes
	gl_Position = hal_ModelViewProjection * vec4(worldPosition.x, elevationFragment.x * hal_ElevationMapScale, worldPosition.y, 1.0);
	hal_VertexNormal = vec3(0.0, 1.0, 0.0);
	hal_VertexTexCoord = elevationCoord;
	hal_VertexColor = hal_BlockColor;

#if defined(LOGARITHMIC_DEPTH)
	const float Far = 250000.0f;
	const float Fcoef = 2.0 / log2(Far + 1.0);

	float logz = 1.0 + gl_Position.w;

	hal_VertexLogZ = logz;
	gl_Position.z = log2(max(1e-6, logz)) * Fcoef - 1.0;
#endif
}
