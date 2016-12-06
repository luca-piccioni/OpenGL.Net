
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

#include </OpenGL/Light/MaterialState.glsl>

// The light model applied
struct glo_LightModelType
{
	// The ambient lighting.
	vec4 AmbientLighting;
};

// Light structure
struct glo_LightType
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
#ifndef GLO_MAX_LIGHTS_COUNT
#define GLO_MAX_LIGHTS_COUNT			8
#endif

// The light model
uniform glo_LightModelType glo_LightModel;

// The lights
uniform glo_LightType glo_Light[GLO_MAX_LIGHTS_COUNT];

// The enabled lights count
uniform int glo_LightsCount;

// Compute the color contribution of all enabled lights (ambient)
void ComputeLightContributions(vec4 eyePosition, inout vec4 ambient);

// Compute the color contribution of all enabled lights (ambient and diffuse)
void ComputeLightContributions(vec4 eyePosition, vec3 normal, inout vec4 ambient, inout vec4 diffuse);

// Compute the color contribution of all enabled lights (specular)
void ComputeLightContributions(vec4 eyePosition, vec3 normal, float materialShininess, inout vec4 specular);

// Compute the color contribution of all enabled lights (ambient, diffuse, specular)
void ComputeLightContributions(vec4 eyePosition, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular);

#endif
