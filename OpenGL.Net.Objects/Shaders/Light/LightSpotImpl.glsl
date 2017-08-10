
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
#include </OpenGL/Light/LightState.glsl>

// Compute the attenuation factor
float ComputeSpotAttenuationFactor(glo_LightType light, float distance)
{
	// Compute attenuation
	return 1.0 / (
		light.AttenuationFactors[0] +
		light.AttenuationFactors[1] * distance +
		light.AttenuationFactors[2] * distance * distance
		);
}

void ComputeSpotLight(glo_LightType light, vec3 eye, vec3 ecPos3, vec3 normal, inout vec4 ambient, inout vec4 diffuse)
{

}

void ComputeSpotLight(glo_LightType light, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 specular)
{

}

void ComputeSpotLight(glo_LightType light, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular)
{
	vec3 lightVector = vec3(light.Position) - ecPos3;
	float attenuation = ComputeSpotAttenuationFactor(light, length(lightVector));

	lightVector = normalize(lightVector);

	float dotNL = max(0.0, dot(normal, lightVector));
	if (dotNL > 0.0) {
		float dotSpot = dot(normalize(light.Direction), -lightVector);

		if (dotSpot > light.FallOff[0]) {
			vec3 halfVector = normalize(lightVector + eye);
			float dotNH = max(0.0, dot(normal, halfVector));
			float powerFactor = pow(dotNH, materialShininess);

			attenuation *= pow(dotSpot, light.FallOff[1]);

			diffuse += light.DiffuseColor * dotNL * attenuation;
			specular += light.SpecularColor * powerFactor * attenuation;
		}
	}

	// Emit light color contribution
	ambient += light.AmbientColor;
}