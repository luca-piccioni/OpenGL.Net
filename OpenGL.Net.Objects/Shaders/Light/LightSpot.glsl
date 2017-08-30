
// Copyright (C) 2017 Luca Piccioni
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
void ComputeSpotLight(glo_LightType light, vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular);

void ComputeLightContributions(vec4 eyePosition, in vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular)
{
	float shadowFactor = 1.0;

	ComputeSpotLight(glo_Light, normal, materialShininess, ambient, diffuse, specular);

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

