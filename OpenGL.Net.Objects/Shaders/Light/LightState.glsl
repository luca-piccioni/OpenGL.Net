
// Copyright (C) 2011-2017 Luca Piccioni
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
