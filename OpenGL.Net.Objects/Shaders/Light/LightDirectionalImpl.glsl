
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
