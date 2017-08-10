
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
