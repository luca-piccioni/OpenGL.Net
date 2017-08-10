
// Copyright (C) 2012-2017 Luca Piccioni
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

#ifndef GLO_MAX_LIGHTS_COUNT
#define GLO_MAX_LIGHTS_COUNT			4
#endif

BLOCK_BEGIN_LAYOUT(LightState, shared)
	// The light model
	BLOCK_FIELD glo_LightModelType glo_LightModel;
	// The lights
	BLOCK_FIELD glo_LightType glo_Light[GLO_MAX_LIGHTS_COUNT];
	// The enabled lights count
	BLOCK_FIELD int glo_LightsCount;
BLOCK_END_ANON()

// Ambient
void ComputeDirectionalLight(glo_LightType light,              inout vec4 ambient);
void ComputePointLight      (glo_LightType light, vec3 ecPos3, inout vec4 ambient);

void ComputeLightContributions(vec4 eyePosition, inout vec4 ambient)
{
	vec3 ecPosition3 = vec3(eyePosition) / eyePosition.w;		// Local viewer

	for (int i = 0; i < glo_LightsCount; i++) {
		if      (glo_Light[i].Position.w == 0.0)
			ComputeDirectionalLight(glo_Light[i], ambient);
		else if (glo_Light[i].FallOff[0] == 180.0)
			ComputePointLight(glo_Light[i], ecPosition3, ambient);
	}

	ambient = ambient * glo_LightModel.AmbientLighting;
}

// Ambient and diffuse
void ComputeDirectionalLight(glo_LightType light,                        vec3 normal, inout vec4 ambient, inout vec4 diffuse);
void ComputePointLight      (glo_LightType light, vec3 eye, vec3 ecPos3, vec3 normal, inout vec4 ambient, inout vec4 diffuse);
void ComputeSpotLight       (glo_LightType light, vec3 eye, vec3 ecPos3, vec3 normal, inout vec4 ambient, inout vec4 diffuse);

void ComputeLightContributions(vec4 eyePosition, in vec3 normal, inout vec4 ambient, inout vec4 diffuse)
{
	vec3 ecPosition3 = vec3(eyePosition) / eyePosition.w;		// Local viewer

	for (int i = 0; i < glo_LightsCount; i++) {
		vec4 lightAmbient, lightDiffuse;

		int shadowIndex = glo_Light[i].ShadowMapIndex;
		float shadowFactor = 1.0;

		if        (glo_Light[i].Position.w == 0.0) {
			ComputeDirectionalLight(glo_Light[i], normal, ambient, diffuse);
		} else if (glo_Light[i].FallOff[0] == 180.0) {
			ComputePointLight(glo_Light[i], -normalize(ecPosition3), ecPosition3, normal, lightAmbient, lightDiffuse);
		} else {
			ComputeSpotLight(glo_Light[i], -normalize(ecPosition3), ecPosition3, normal, lightAmbient, lightDiffuse);
		}

		ambient += lightAmbient;
		diffuse += lightDiffuse * shadowFactor;
	}

	ambient = ambient * glo_LightModel.AmbientLighting;
}

// Ambient, diffuse and specular
void ComputeDirectionalLight(glo_LightType light,                        vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular);
void ComputePointLight      (glo_LightType light, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular);
void ComputeSpotLight       (glo_LightType light, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular);

void ComputeLightContributions(vec4 eyePosition, in vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular)
{
	vec3 ecPosition3 = vec3(eyePosition) / eyePosition.w;		// Local viewer

	for (int i = 0; i < glo_LightsCount; i++) {
		vec4 lightAmbient = vec4(0.0), lightDiffuse = vec4(0.0), lightSpecular = vec4(0.0);

		int shadowIndex = glo_Light[i].ShadowMapIndex;
		float shadowFactor = 1.0;

		if      (glo_Light[i].Position.w == 0.0)
			ComputeDirectionalLight(glo_Light[i], normal, materialShininess, lightAmbient, lightDiffuse, lightSpecular);
		else if (glo_Light[i].FallOff[0] == 180.0)
			ComputePointLight(glo_Light[i], -normalize(ecPosition3), ecPosition3, normal, materialShininess, lightAmbient, lightDiffuse, lightSpecular);
		else {
			ComputeSpotLight(glo_Light[i], -normalize(ecPosition3), ecPosition3, normal, materialShininess, lightAmbient, lightDiffuse, lightSpecular);

			/*if (shadowIndex >= 0) {
				vec4 shadowPosition = glo_VertexPosition_ShadowMap[shadowIndex];
				vec3 shadowPosition3 = shadowPosition.xyz / vec3(shadowPosition.w);
				shadowFactor = texture(glo_ShadowMap2D[shadowIndex], shadowPosition3);
			}*/
		}

		ambient += lightAmbient;
		diffuse += lightDiffuse * shadowFactor;
		specular += lightSpecular * shadowFactor;
	}

	ambient = ambient * glo_LightModel.AmbientLighting;
}
