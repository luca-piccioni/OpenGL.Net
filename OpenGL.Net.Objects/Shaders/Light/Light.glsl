
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

#include </OpenGL/Compatibility.glsl>
#include </OpenGL/Light/Lighting.glsl>
#include </OpenGL/Light/LightState.glsl>

/// - Forward declarations ----------------------------------------------------

// Directional light methods
// Ambient
void ComputeDirectionalLight(int lightIdx, inout vec4 ambient);
// Ambient and diffuse
void ComputeDirectionalLight(int lightIdx, vec3 normal, inout vec4 ambient, inout vec4 diffuse);
// Specular
void ComputeDirectionalLight(int lightIdx, vec3 normal, float materialShininess, inout vec4 specular);
// Ambient, diffuse and specular
void ComputeDirectionalLight(int lightIdx, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular);

// Point light methods
void ComputePointLight(int lightIdx, vec3 ecPos3, inout vec4 ambient);
void ComputePointLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, inout vec4 ambient, inout vec4 diffuse);
void ComputePointLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 specular);
void ComputePointLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular);

// Spot light methods
void ComputeSpotLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, inout vec4 ambient, inout vec4 diffuse);
void ComputeSpotLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 specular);
void ComputeSpotLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular);

/// - State vector methods ----------------------------------------------------

void ComputeLightContributions(vec4 eyePosition, inout vec4 ambient)
{
	vec3 ecPosition3 = vec3(eyePosition) / eyePosition.w;		// Local viewer

	for (int i = 0; i < glo_LightsCount; i++) {
		if      (glo_Light[i].Position.w == 0.0)
			ComputeDirectionalLight(i, ambient);
		else if (glo_Light[i].FallOff[0] == 180.0)
			ComputePointLight(i, ecPosition3, ambient);
	}

	ambient = ambient * glo_LightModel.AmbientLighting;
}

void ComputeLightContributions(vec4 eyePosition, in vec3 normal, inout vec4 ambient, inout vec4 diffuse)
{
	vec3 ecPosition3 = vec3(eyePosition) / eyePosition.w;		// Local viewer

	for (int i = 0; i < glo_LightsCount; i++) {
		vec4 lightAmbient, lightDiffuse;

		int shadowIndex = glo_Light[i].ShadowMapIndex;
		float shadowFactor = 1.0;

		if        (glo_Light[i].Position.w == 0.0) {
			ComputeDirectionalLight(i, normal, ambient, diffuse);
		} else if (glo_Light[i].FallOff[0] == 180.0) {
			ComputePointLight(i, -normalize(ecPosition3), ecPosition3, normal, lightAmbient, lightDiffuse);
		} else {
			ComputeSpotLight(i, -normalize(ecPosition3), ecPosition3, normal, lightAmbient, lightDiffuse);
			if (shadowIndex >= 0) {
				vec4 lightPosition = glo_Light[i].ShadowMapMvp * eyePosition;
				vec3 lightPosition3 = vec3(lightPosition) / lightPosition.w;

				shadowFactor = texture(glo_ShadowMap2D[shadowIndex], lightPosition3);
			}
		}

		ambient += lightAmbient;
		diffuse += lightDiffuse * shadowFactor;
	}

	ambient = ambient * glo_LightModel.AmbientLighting;
}

void ComputeLightContributions(vec4 eyePosition, in vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular)
{
	vec3 ecPosition3 = vec3(eyePosition) / eyePosition.w;		// Local viewer

	for (int i = 0; i < glo_LightsCount; i++) {
		vec4 lightAmbient, lightDiffuse;

		int shadowIndex = glo_Light[i].ShadowMapIndex;
		float shadowFactor = 1.0;

		if      (glo_Light[i].Position.w == 0.0)
			ComputeDirectionalLight(i, normal, materialShininess, ambient, diffuse, specular);
		else if (glo_Light[i].FallOff[0] == 180.0)
			ComputePointLight(i, -normalize(ecPosition3), ecPosition3, normal, materialShininess, ambient, diffuse, specular);
		else {
			ComputeSpotLight(i, -normalize(ecPosition3), ecPosition3, normal, materialShininess, ambient, diffuse, specular);

			if (shadowIndex >= 0) {
				vec4 lightPosition = glo_Light[i].ShadowMapMvp * eyePosition;
				vec3 lightPosition3 = vec3(lightPosition) / lightPosition.w;

				shadowFactor = texture(glo_ShadowMap2D[shadowIndex], lightPosition3);
			}
		}

		ambient += lightAmbient;
		diffuse += lightDiffuse * shadowFactor;
	}

	ambient = ambient * glo_LightModel.AmbientLighting;
}

/// -----------------------------------------------------------------------------------------------
/// Light utilities

// Compute the attenuation factor
float ComputeAttenuationFactor(int lightIdx, float distance)
{
	// Compute attenuation
	return 1.0 / (
		glo_Light[lightIdx].AttenuationFactors[0] +
		glo_Light[lightIdx].AttenuationFactors[1] * distance +
		glo_Light[lightIdx].AttenuationFactors[2] * distance * distance
	);
}

/// -----------------------------------------------------------------------------------------------
/// Directional light

void ComputeDirectionalLight(int lightIdx, inout vec4 ambient)
{
	// Emit light color contribution
	ambient  += glo_Light[lightIdx].AmbientColor;
}

/// <summary>
/// Compute a directional light contribution for ambient and diffuse components.
/// <summary/>
void ComputeDirectionalLight(int lightIdx, vec3 normal, inout vec4 ambient, inout vec4 diffuse)
{
	// Dot-product between normal and light direction
	float dotNL = max(0.0, dot(normal, normalize(glo_Light[lightIdx].Direction)));

	// Emit light color contribution
	ambient  += glo_Light[lightIdx].AmbientColor;
	diffuse  += glo_Light[lightIdx].DiffuseColor * dotNL;
}

/// <summary>
/// Compute a directional light contribution for specular only component.
/// <summary/>
void ComputeDirectionalLight(int lightIdx, vec3 normal, float materialShininess, inout vec4 specular)
{
	// Dot-product between normal and light direction
	float dotNL = max(0.0, dot(normal, normalize(glo_Light[lightIdx].Direction)));
	// Dot-product between normal and light half-vector
	float dotNH = max(0.0, dot(normal, normalize(vec3(glo_Light[lightIdx].HalfVector))));

	// Compute specular power factor
	float powerFactor = 0.0;
	if (dotNL > 0.0)
		powerFactor = pow(dotNH, materialShininess);

	// Emit light color contribution
	specular += glo_Light[lightIdx].SpecularColor * powerFactor;
}

/// <summary>
/// Compute a directional light contribution for ambient, diffuse and specular components.
/// <summary/>
void ComputeDirectionalLight(int lightIdx, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular)
{
	// Dot-product between normal and light direction
	float dotNL = max(0.0, dot(normal, normalize(glo_Light[lightIdx].Direction)));
	// Dot-product between normal and light half-vector
	float dotNH = max(0.0, dot(normal, normalize(vec3(glo_Light[lightIdx].HalfVector))));

	// Compute specular power factor
	float powerFactor = 0.0;
	if (dotNL > 0.0) {
		// Effective power factor
		powerFactor = pow(dotNH, materialShininess);
	}

	// Emit light color contribution
	ambient  += glo_Light[lightIdx].AmbientColor;
	diffuse  += glo_Light[lightIdx].DiffuseColor * dotNL;
	specular += glo_Light[lightIdx].SpecularColor * powerFactor;
}

/// -----------------------------------------------------------------------------------------------
/// Point light

/// <summary>
/// Compute a point light contribution for ambient component.
/// <summary/>
void ComputePointLight(int lightIdx, vec3 ecPos3, inout vec4 ambient)
{
	// Compute vector from surface to light position
	vec3 lightVector = vec3(glo_Light[lightIdx].Position) - ecPos3;
	// Compute attenuation
	float attenuation = ComputeAttenuationFactor(lightIdx, length(lightVector));

	// Emit light color contribution
	ambient  += glo_Light[lightIdx].AmbientColor * attenuation;
}

/// <summary>
/// Compute a point light contribution for ambient and diffuse components.
/// <summary/>
void ComputePointLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, inout vec4 ambient, inout vec4 diffuse)
{
	// Compute vector from surface to light position
	vec3 lightVector = vec3(glo_Light[lightIdx].Position) - ecPos3;
	// Compute attenuation
	float attenuation = ComputeAttenuationFactor(lightIdx, length(lightVector));
	
	// Dot-product between normal and light direction
	float dotVP = max(0.0, dot(normal, normalize(lightVector)));

	// Emit light color contribution
	ambient  += glo_Light[lightIdx].AmbientColor * attenuation;
	diffuse  += glo_Light[lightIdx].DiffuseColor * dotVP * attenuation;
}

/// <summary>
/// Compute a point light contribution for ambient, diffuse and specular components.
/// <summary/>
void ComputePointLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 specular)
{
	// Compute vector from surface to light position
	vec3 lightVector = vec3(glo_Light[lightIdx].Position) - ecPos3;
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
	specular += glo_Light[lightIdx].SpecularColor * powerFactor * attenuation;
}

/// <summary>
/// Compute a point light contribution for ambient, diffuse and specular components.
/// <summary/>
void ComputePointLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular)
{
	// Compute vector from surface to light position
	vec3 lightVector = vec3(glo_Light[lightIdx].Position) - ecPos3;
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
	ambient  += glo_Light[lightIdx].AmbientColor * attenuation;
	diffuse  += glo_Light[lightIdx].DiffuseColor * dotVP * attenuation;
	specular += glo_Light[lightIdx].SpecularColor * powerFactor * attenuation;
}

/// -----------------------------------------------------------------------------------------------
/// Spot light

void ComputeSpotLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, inout vec4 ambient, inout vec4 diffuse)
{

}

void ComputeSpotLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 specular)
{

}

void ComputeSpotLight(int lightIdx, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular)
{
	vec3 lightVector = vec3(glo_Light[lightIdx].Position) - ecPos3;
	float attenuation = ComputeAttenuationFactor(lightIdx, length(lightVector));
	
	lightVector = normalize(lightVector);
	
	float dotNL = max(0.0, dot(normal, lightVector));
	if (dotNL > 0.0) {
		float dotSpot = dot(normalize(glo_Light[lightIdx].Direction), -lightVector);

		if (dotSpot > glo_Light[lightIdx].FallOff[0]) {
			vec3 halfVector = normalize(lightVector + eye);
			float dotNH = max(0.0, dot(normal, halfVector));
			float powerFactor = pow(dotNH, materialShininess);

			attenuation *= pow(dotSpot, glo_Light[lightIdx].FallOff[1]);

			diffuse += glo_Light[lightIdx].DiffuseColor * dotNL * attenuation;
			specular += glo_Light[lightIdx].SpecularColor * powerFactor * attenuation;
		}
	}

	// Emit light color contribution
	ambient  += glo_Light[lightIdx].AmbientColor;
}