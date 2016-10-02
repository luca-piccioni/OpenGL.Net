
// Copyright (C) 2011-2015 Luca Piccioni
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
// 

#include </OpenGL/Light/MaterialState.glsl>

// The light model applied
struct hal_LightModelType
{
	// Two sided lighting
	bool TwoSided;
	// The ambient lighting.
	vec4 AmbientLighting;
};

// Light structure
struct hal_LightType
{
	// Light ambient color (used by all lights).
	vec4 AmbientColor;
	// Light diffuse color (used by all lights).
	vec4 DiffuseColor;
	// Light specular color (used by all lights).
	vec4 SpecularColor;
	// The light position vector (used by directional and spot lights).
	vec3 Direction;
	// The light position vector (used by point and spot lights).
	vec4 Position;
	// The light half-vector (used by directional lights).
	vec3 HalfVector;
	// The light attenuation factors (X: constant; Y: linear; Z: quadratic; used by point and spot lights).
	vec3 AttenuationFactors;
	// The spot fall-off parameters (X: fall-off angle in degrees; Y: fall-off exponent, used by spot lights).
	vec2 FallOff;
};

// If not overriden, define the maximum number of lights
#ifndef HAL_MAX_LIGHTS_COUNT
#define HAL_MAX_LIGHTS_COUNT			8
#endif

// The light model
uniform hal_LightModelType hal_LightModel;

// The lights
uniform hal_LightType hal_Light[HAL_MAX_LIGHTS_COUNT];

// The enabled lights count
uniform int hal_LightsCount;

// Compute the color contribution of all enabled lights (ambient)
void ComputeLightContributions(vec4 eyePosition, inout vec4 ambient);

// Compute the color contribution of all enabled lights (ambient and diffuse)
void ComputeLightContributions(vec4 eyePosition, vec3 normal, inout vec4 ambient, inout vec4 diffuse);

// Compute the color contribution of all enabled lights (specular)
void ComputeLightContributions(vec4 eyePosition, vec3 normal, float materialShininess, inout vec4 specular);

// Compute the color contribution of all enabled lights (ambient, diffuse, specular)
void ComputeLightContributions(vec4 eyePosition, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular);

/// -----------------------------------------------------------------------------------------------
/// Directional light methods

// Ambient
void ComputeDirectionalLight(int lightIdx, inout vec4 ambient);
// Ambient and diffuse
void ComputeDirectionalLight(int lightIdx, vec3 normal, inout vec4 ambient, inout vec4 diffuse);
// Specular
void ComputeDirectionalLight(int lightIdx, vec3 normal, float materialShininess, inout vec4 specular);
// Ambient, diffuse and specular
void ComputeDirectionalLight(int lightIdx, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular);

/// -----------------------------------------------------------------------------------------------
/// Point light methods

void ComputePointLight(int lightIdx, vec3 ecPos3, inout vec4 ambient);
void ComputePointLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, inout vec4 ambient, inout vec4 diffuse);
void ComputePointLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 specular);
void ComputePointLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular);

/// -----------------------------------------------------------------------------------------------
/// Spot light methods

void ComputeSpotLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, inout vec4 ambient, inout vec4 diffuse);
void ComputeSpotLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 specular);
void ComputeSpotLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular);

void ComputeLightContributions(vec4 eyePosition, inout vec4 ambient)
{
	vec3 ecPosition3 = vec3(eyePosition) / eyePosition.w;		// Local viewer

	for (int i = 0; i < hal_LightsCount; i++) {
		if (hal_Light[i].Position.w == 0.0)
			ComputeDirectionalLight(i, ambient);
		else if (hal_Light[i].FallOff[0] == 180.0)
			ComputePointLight(i, ecPosition3, ambient);
	}
}

void ComputeLightContributions(vec4 eyePosition, in vec3 normal, inout vec4 ambient, inout vec4 diffuse)
{
	vec3 ecPosition3 = vec3(eyePosition) / eyePosition.w;		// Local viewer

	for (int i = 0; i < hal_LightsCount; i++) {
		if (hal_Light[i].Position.w == 0.0)
			ComputeDirectionalLight(i, normal, ambient, diffuse);
		else if (hal_Light[i].FallOff[0] == 180.0)
			ComputePointLight(i, -normalize(ecPosition3), ecPosition3, normal, ambient, diffuse);
#if 0
		else
			ComputeSpotLight(i, normal, ambient, diffuse);
#endif
	}
}

void ComputeLightContributions(float materialShininess, in vec3 normal, inout vec4 specular)
{

}

void ComputeLightContributions(vec4 eyePosition, in vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular)
{
	vec3 ecPosition3 = vec3(eyePosition) / eyePosition.w;		// Local viewer

	for (int i = 0; i < hal_LightsCount; i++) {
		if (hal_Light[i].Position.w == 0.0)
			ComputeDirectionalLight(i, normal, materialShininess, ambient, diffuse, specular);
		else if (hal_Light[i].FallOff[0] == 180.0)
			ComputePointLight(i, -normalize(ecPosition3), ecPosition3, normal, materialShininess, ambient, diffuse, specular);
#if 0
		else
			ComputeSpotLight(i, normal, materialShininess, ambient, diffuse, specular);
#endif
	}
}

/// -----------------------------------------------------------------------------------------------
/// Light utilities
/// -----------------------------------------------------------------------------------------------

// Compute the attenuation factor
float ComputeAttenuationFactor(int lightIdx, float distance)
{
	// Compute attenuation
	return 1.0 / (
		ds_Light[lightIdx].AttenuationFactors[0] +
		ds_Light[lightIdx].AttenuationFactors[1] * distance +
		ds_Light[lightIdx].AttenuationFactors[2] * distance * distance
		);
}

/// -----------------------------------------------------------------------------------------------
/// Directional light
/// -----------------------------------------------------------------------------------------------

void ComputeDirectionalLight(int lightIdx, inout vec4 ambient)
{
	// Emit light color contribution
	ambient  += hal_Light[lightIdx].AmbientColor;
}

/// <summary>
/// Compute a directional light contribution for ambient and diffuse components.
/// <summary/>
void ComputeDirectionalLight(int lightIdx, vec3 normal, inout vec4 ambient, inout vec4 diffuse)
{
	// Dot-product between normal and light direction
	float dotNL = max(0.0, dot(normal, normalize(hal_Light[lightIdx].Direction)));

	// Emit light color contribution
	ambient  += hal_Light[lightIdx].AmbientColor;
	diffuse  += hal_Light[lightIdx].DiffuseColor * dotNL;
}

/// <summary>
/// Compute a directional light contribution for specular only component.
/// <summary/>
void ComputeDirectionalLight(int lightIdx, vec3 normal, float materialShininess, inout vec4 specular)
{
	// Dot-product between normal and light direction
	float dotNL = max(0.0, dot(normal, normalize(hal_Light[lightIdx].Direction)));
	// Dot-product between normal and light half-vector
	float dotNH = max(0.0, dot(normal, normalize(vec3(hal_Light[lightIdx].HalfVector))));

	// Compute specular power factor
	float powerFactor = 0.0;
	if (dotNL != 0) {
		// Effective power factor
		powerFactor = pow(dotNH, materialShininess);
	}

	// Emit light color contribution
	specular += hal_Light[lightIdx].SpecularColor * powerFactor;
}

/// <summary>
/// Compute a directional light contribution for ambient, diffuse and specular components.
/// <summary/>
void ComputeDirectionalLight(int lightIdx, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular)
{
	// Dot-product between normal and light direction
	float dotNL = max(0.0, dot(normal, normalize(hal_Light[lightIdx].Direction)));
	// Dot-product between normal and light half-vector
	float dotNH = max(0.0, dot(normal, normalize(vec3(hal_Light[lightIdx].HalfVector))));

	// Compute specular power factor
	float powerFactor = 0.0;
	if (dotNL != 0) {
		// Effective power factor
		powerFactor = pow(dotNH, materialShininess);
	}

	// Emit light color contribution
	ambient  += hal_Light[lightIdx].AmbientColor;
	diffuse  += hal_Light[lightIdx].DiffuseColor * dotNL;
	specular += hal_Light[lightIdx].SpecularColor * powerFactor;
}

/// -----------------------------------------------------------------------------------------------
/// Point light
/// -----------------------------------------------------------------------------------------------

/// <summary>
/// Compute a point light contribution for ambient component.
/// <summary/>
void ComputePointLight(int lightIdx, vec3 ecPos3, inout vec4 ambient)
{
	// Compute vector from surface to light position
	vec3 lightVector = vec3(hal_Light[lightIdx].Position) - ecPos3;
	// Compute attenuation
	float attenuation = ComputeAttenuationFactor(lightIdx, length(lightVector));

	// Emit light color contribution
	ambient  += hal_Light[lightIdx].AmbientColor * attenuation;
}

/// <summary>
/// Compute a point light contribution for ambient and diffuse components.
/// <summary/>
void ComputePointLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, inout vec4 ambient, inout vec4 diffuse)
{
	// Compute vector from surface to light position
	vec3 lightVector = vec3(hal_Light[lightIdx].Position) - ecPos3;
	// Compute attenuation
	float attenuation = ComputeAttenuationFactor(lightIdx, length(lightVector));
	
	// Dot-product between normal and light direction
	float dotVP = max(0.0, dot(normal, normalize(lightVector)));

	// Emit light color contribution
	ambient  += hal_Light[lightIdx].AmbientColor * attenuation;
	diffuse  += hal_Light[lightIdx].DiffuseColor * dotVP * attenuation;
}

/// <summary>
/// Compute a point light contribution for ambient, diffuse and specular components.
/// <summary/>
void ComputePointLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 specular)
{
	// Compute vector from surface to light position
	vec3 lightVector = vec3(hal_Light[lightIdx].Position) - ecPos3;
	// Compute attenuation
	float attenuation = ComputeAttenuationFactor(lightIdx, length(lightVector));
	
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
	specular += hal_Light[lightIdx].SpecularColor * powerFactor * attenuation;
}

/// <summary>
/// Compute a point light contribution for ambient, diffuse and specular components.
/// <summary/>
void ComputePointLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular)
{
	// Compute vector from surface to light position
	vec3 lightVector = vec3(hal_Light[lightIdx].Position) - ecPos3;
	// Compute attenuation
	float attenuation = ComputeAttenuationFactor(lightIdx, length(lightVector));
	
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
	ambient  += hal_Light[lightIdx].AmbientColor * attenuation;
	diffuse  += hal_Light[lightIdx].DiffuseColor * dotVP * attenuation;
	specular += hal_Light[lightIdx].SpecularColor * powerFactor * attenuation;
}

/// -----------------------------------------------------------------------------------------------
/// Spot light
/// -----------------------------------------------------------------------------------------------

void ComputeSpotLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, inout vec4 ambient, inout vec4 diffuse)
{

}

void ComputeSpotLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 specular)
{

}

void ComputeSpotLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular)
{
	// Compute vector from surface to light position
	vec3 lightVector = vec3(hal_Light[lightIdx].Position) - ecPos3;
	// Compute attenuation
	float attenuation = ComputeAttenuationFactor(lightIdx, length(lightVector));
	
	// Normalize vector from surface to light position
	lightVector = normalize(lightVector);

	// Check whether position in inside the spot
	float dotSpot = dot(-lightVector, normalize(hal_Light[lightIdx].Direction));
	if (dotSpot < hal_Light[lightIdx].FallOff[0])
		return;		/* No contribution */
	else
		attenuation *= pow(dotSpot, hal_Light[lightIdx].FallOff[1]);

	// Compute the half-vector
	vec3 halfVector = normalize(lightVector + eye);
	// Dot-product between normal and light direction
	float dotVP = max(0.0, dot(normal, lightVector));
	// Dot-product between normal and light half-vector
	float dotHV = max(0.0, dot(normal, halfVector));

	// Compute specular power factor
	float powerFactor = 0.0;
	if (dotVP != 0)
		powerFactor = pow(dotHV, hal_FrontMaterial.Shininess);

	// Emit light color contribution
	ambient  += hal_Light[lightIdx].AmbientColor * attenuation;
	diffuse  += hal_Light[lightIdx].DiffuseColor * dotVP * attenuation;
	specular += hal_Light[lightIdx].SpecularColor * powerFactor * attenuation;
}