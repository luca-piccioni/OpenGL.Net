
// Copyright (C) 2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

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