
// Copyright (C) 2012-2016 Luca Piccioni
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

vec4 ComputeLightShading(glo_MaterialType material, vec4 eyePosition, vec3 normal)
{
	vec4 lightAmbient = vec4(0.0), lightDiffuse = vec4(0.0), lightSpecular = vec4(0.0);

	// Phong equation:
	//
	// color =	<emission> +
	//			<ambient> * al +
	//			<diffuse> * max(N . L, 0) +
	//			<specular> * max(R . I, 0) ^ <shininess>
	// 
	// Where:
	// - al: ambient lighting
	// - N: normal vector
	// - L: light vector
	// - I: eye vector
	// - R: perfect reflection vector (reflect(L around N))

	ComputeLightContributions(eyePosition, normal, material.Shininess, lightAmbient, lightDiffuse, lightSpecular);

	return (
		material.EmissiveColor +
		lightAmbient +
		material.DiffuseColor * lightDiffuse +
		material.SpecularColor * lightSpecular
	);
}