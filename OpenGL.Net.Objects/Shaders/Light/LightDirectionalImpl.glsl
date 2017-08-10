
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

// Specular
void ComputeDirectionalLight(glo_LightType light, vec3 normal, float materialShininess, inout vec4 specular);
// Ambient, diffuse and specular

// Compute a directional light contribution for ambient component.
void ComputeDirectionalLight(glo_LightType light, inout vec4 ambient)
{
	// Emit light color contribution
	ambient += light.AmbientColor;
}

// Compute a directional light contribution for ambient and diffuse components.
void ComputeDirectionalLight(glo_LightType light, vec3 normal, inout vec4 ambient, inout vec4 diffuse)
{
	// Dot-product between normal and light direction
	float dotNL = max(0.0, dot(normal, normalize(light.Direction)));

	// Emit light color contribution
	ambient += light.AmbientColor;
	diffuse += light.DiffuseColor * dotNL;
}

// Compute a directional light contribution for specular only component.
void ComputeDirectionalLight(glo_LightType light, vec3 normal, float materialShininess, inout vec4 specular)
{
	// Dot-product between normal and light direction
	float dotNL = max(0.0, dot(normal, normalize(light.Direction)));
	// Dot-product between normal and light half-vector
	float dotNH = max(0.0, dot(normal, normalize(vec3(light.HalfVector))));

	// Compute specular power factor
	float powerFactor = 0.0;
	if (dotNL > 0.0)
		powerFactor = pow(dotNH, materialShininess);

	// Emit light color contribution
	specular += light.SpecularColor * powerFactor;
}

// Compute a directional light contribution for ambient, diffuse and specular components.
void ComputeDirectionalLight(glo_LightType light, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular)
{
	// Dot-product between normal and light direction
	float dotNL = max(0.0, dot(normal, normalize(light.Direction)));
	// Dot-product between normal and light half-vector
	float dotNH = max(0.0, dot(normal, normalize(vec3(light.HalfVector))));

	// Compute specular power factor
	float powerFactor = 0.0;
	if (dotNL > 0.0) {
		// Effective power factor
		powerFactor = pow(dotNH, materialShininess);
	}

	// Emit light color contribution
	ambient += light.AmbientColor;
	diffuse += light.DiffuseColor * dotNL;
	specular += light.SpecularColor * powerFactor;
}
