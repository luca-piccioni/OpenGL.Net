
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

#include </OpenGL/Light/LightState.glsl>
#include </OpenGL/Light/MaterialState.glsl>

vec4 ComputeLightShading(hal_MaterialType material, vec4 eyePosition, vec3 normal)
{
	vec4 lightAmbient = vec4(0.0), lightDiffuse = vec4(0.0);

	// Lambert equation:
	//
	// color =	<emission> +
	//			<ambient> * al +
	//			<diffuse> * max(N . L, 0) +
	// 
	// Where:
	// - al: ambient lighting
	// - N: normal vector
	// - L: light vector

	ComputeLightContributions(eyePosition, normal, lightAmbient, lightDiffuse);

	return (
		material.EmissiveColor +
		material.AmbientColor * lightAmbient * hal_LightModel.AmbientLighting +
		material.DiffuseColor * lightDiffuse
		);
}