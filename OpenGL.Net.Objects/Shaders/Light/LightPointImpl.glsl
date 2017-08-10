
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

void ComputePointLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 specular);
void ComputePointLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular);

// Compute the attenuation factor
float ComputePointAttenuationFactor(glo_LightType light, float distance)
{
	// Compute attenuation
	return 1.0 / (
		light.AttenuationFactors[0] +
		light.AttenuationFactors[1] * distance +
		light.AttenuationFactors[2] * distance * distance
		);
}

// Compute a point light contribution for ambient component.
void ComputePointLight(glo_LightType light, vec3 ecPos3, inout vec4 ambient)
{
	// Compute vector from surface to light position
	vec3 lightVector = vec3(light.Position) - ecPos3;
	// Compute attenuation
	float attenuation = ComputePointAttenuationFactor(light, length(lightVector));

	// Emit light color contribution
	ambient += light.AmbientColor * attenuation;
}

// Compute a point light contribution for ambient and diffuse components.
void ComputePointLight(glo_LightType light, vec3 eye, vec3 ecPos3, vec3 normal, inout vec4 ambient, inout vec4 diffuse)
{
	// Compute vector from surface to light position
	vec3 lightVector = vec3(light.Position) - ecPos3;
	// Compute attenuation
	float attenuation = ComputePointAttenuationFactor(light, length(lightVector));

	// Dot-product between normal and light direction
	float dotVP = max(0.0, dot(normal, normalize(lightVector)));

	// Emit light color contribution
	ambient += light.AmbientColor * attenuation;
	diffuse += light.DiffuseColor * dotVP * attenuation;
}

// Compute a point light contribution for ambient, diffuse and specular components.
void ComputePointLight(glo_LightType light, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 specular)
{
	// Compute vector from surface to light position
	vec3 lightVector = vec3(light.Position) - ecPos3;
	// Compute attenuation
	float attenuation = ComputePointAttenuationFactor(light, length(lightVector));

	// Normalize vector from surface to light position
	lightVector = normalize(lightVector);

	// Compute the half-vector
	vec3 halfVector = normalize(lightVector + eye);
	// Dot-product between normal and light direction
	float dotVP = max(0.0, dot(normal, lightVector));
	// Dot-product between normal and light half-vector
	float dotHV = max(0.0, dot(normal, halfVector));

	// Compute specular power factor
	float powerFactor = 0.0;
	if (dotVP != 0)
		powerFactor = pow(dotHV, materialShininess);

	// Emit light color contribution
	specular += light.SpecularColor * powerFactor * attenuation;
}

// Compute a point light contribution for ambient, diffuse and specular components.
void ComputePointLight(glo_LightType light, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular)
{
	// Compute vector from surface to light position
	vec3 lightVector = vec3(light.Position) - ecPos3;
	// Compute attenuation
	float attenuation = ComputePointAttenuationFactor(light, length(lightVector));

	// Normalize vector from surface to light position
	lightVector = normalize(lightVector);

	// Compute the half-vector
	vec3 halfVector = normalize(lightVector + eye);
	// Dot-product between normal and light direction
	float dotVP = max(0.0, dot(normal, lightVector));
	// Dot-product between normal and light half-vector
	float dotHV = max(0.0, dot(normal, halfVector));

	// Compute specular power factor
	float powerFactor = 0.0;
	if (dotVP != 0)
		powerFactor = pow(dotHV, materialShininess);

	// Emit light color contribution
	ambient += light.AmbientColor * attenuation;
	diffuse += light.DiffuseColor * dotVP * attenuation;
	specular += light.SpecularColor * powerFactor * attenuation;
}