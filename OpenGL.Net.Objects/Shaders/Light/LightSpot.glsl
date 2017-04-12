
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

// Model-view-projection matrix for object-space to light-space transformation
uniform mat4 glo_ShadowMap2D_MVP;
// Shadow maps sampled using sample2D
uniform sampler2DShadow glo_ShadowMap2D;

// Vertex/Fragment position in light-space
SHADER_IN vec4 glo_VertexPosition_ShadowMap;

// Ambient, diffuse and specular
void ComputeSpotLight(glo_LightType light, vec3 eye, vec3 ecPos3, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular);

void ComputeLightContributions(vec4 eyePosition, in vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular)
{
	float shadowFactor = 1.0;

	ComputeDirectionalLight(glo_Light, normal, materialShininess, ambient, diffuse, specular);

#if defined(GLO_SHADOWMAP)
	// Shadow mapping
	vec4 shadowPosition = glo_VertexPosition_ShadowMap;
	vec3 shadowPosition3 = shadowPosition.xyz / vec3(shadowPosition.w);
	shadowFactor = texture(glo_ShadowMap2D[shadowIndex], shadowPosition3);
#endif

	ambient  = ambient * glo_LightModel.AmbientLighting;
	diffuse  = diffuse * shadowFactor;
	specular = specular * shadowFactor;
}

