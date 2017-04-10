
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

// Light model
struct glo_LightModelType
{
	// Global ambient lighting
	vec4 AmbientLighting;
};

// Light instance
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
};

// Generic light shading entry point
vec4 ComputeLightShading(glo_MaterialType material, vec4 eyePosition, vec3 normal);

#endif
