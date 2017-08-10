
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