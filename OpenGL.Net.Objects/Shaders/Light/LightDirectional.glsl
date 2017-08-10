
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

BLOCK_BEGIN_LAYOUT(LightState, shared)
	// The light model
	BLOCK_FIELD glo_LightModelType glo_LightModel;
	// The directional light
	BLOCK_FIELD glo_LightType glo_Light;
BLOCK_END_ANON()

// Ambient
void ComputeDirectionalLight(glo_LightType light, inout vec4 ambient);

void ComputeLightContributions(vec4 eyePosition, inout vec4 ambient)
{
	ComputeDirectionalLight(glo_Light, ambient);

	ambient = ambient * glo_LightModel.AmbientLighting;
}

// Ambient and diffuse
void ComputeDirectionalLight(glo_LightType light, vec3 normal, inout vec4 ambient, inout vec4 diffuse);

void ComputeLightContributions(vec4 eyePosition, in vec3 normal, inout vec4 ambient, inout vec4 diffuse)
{
	ComputeDirectionalLight(glo_Light, normal, ambient, diffuse);

	ambient = ambient * glo_LightModel.AmbientLighting;
}

// Ambient, diffuse and specular
void ComputeDirectionalLight(glo_LightType light, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular);

void ComputeLightContributions(vec4 eyePosition, in vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular)
{
	ComputeDirectionalLight(glo_Light, normal, materialShininess, ambient, diffuse, specular);

	ambient = ambient * glo_LightModel.AmbientLighting;
}
