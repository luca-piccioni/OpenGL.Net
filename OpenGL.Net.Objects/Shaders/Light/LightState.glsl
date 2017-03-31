
// Copyright (C) 2011-2016 Luca Piccioni
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

#ifndef GLO_LIGHT_STATE
#define GLO_LIGHT_STATE

#include </OpenGL/Compatibility.glsl>
#include </OpenGL/Light/MaterialState.glsl>

struct glo_LightModelType
{
	vec4 AmbientLighting;
};

struct glo_LightType
{
	// Light colors (all lights).
	vec4 AmbientColor;
	vec4 DiffuseColor;
	vec4 SpecularColor;

	// The light position vector (directional and spot lights).
	vec3 Direction;
	// The light position vector (point and spot lights).
	vec4 Position;
	// The light half-vector (directional lights).
	vec3 HalfVector;
	
	// The light attenuation factors (X: constant; Y: linear; Z: quadratic; point and spot lights).
	vec3 AttenuationFactors;
	// The spot fall-off parameters (X: fall-off angle in degrees; Y: fall-off exponent, spot lights).
	vec2 FallOff;

	// Index of the shadow map used for this light.
	int ShadowMapIndex;
	// Model-view-projection matrix for light-space transformation.
	mat4 ShadowMapMvp;
};

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

// Shadow maps sampled using sampler2D
uniform sampler2DShadow glo_ShadowMap2D[GLO_MAX_LIGHTS_COUNT];

// Compute the color contribution of all enabled lights (ambient)
void ComputeLightContributions(vec4 eyePosition, inout vec4 ambient);

// Compute the color contribution of all enabled lights (ambient and diffuse)
void ComputeLightContributions(vec4 eyePosition, vec3 normal, inout vec4 ambient, inout vec4 diffuse);

// Compute the color contribution of all enabled lights (specular)
void ComputeLightContributions(vec4 eyePosition, vec3 normal, float materialShininess, inout vec4 specular);

// Compute the color contribution of all enabled lights (ambient, diffuse, specular)
void ComputeLightContributions(vec4 eyePosition, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular);

#endif
