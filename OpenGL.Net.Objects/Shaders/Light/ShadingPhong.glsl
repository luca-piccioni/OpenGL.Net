
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

#include </OpenGL/Light/LightState.glsl>
#include </OpenGL/Light/MaterialState.glsl>

// Generic light computation function
void ComputeLightContributions(vec4 eyePosition, in vec3 normal, float materialShininess, inout vec4 ambient, inout vec4 diffuse, inout vec4 specular);

vec4 ComputeLightShading(glo_MaterialType material, vec4 eyePosition, vec3 normal)
{
	vec4 lightAmbient = vec4(0.0), lightDiffuse = vec4(0.0), lightSpecular = vec4(0.0);

	// Phong equation:
	//
	// color =	<emission> +
	//			<ambient> * al +
	//			<diffuse> * max(N . L, 0) +
	//			<specular> * max(R . I, 0) ^ <shininess>
	// 
	// Where:
	// - al: ambient lighting
	// - N: normal vector
	// - L: light vector
	// - I: eye vector
	// - R: perfect reflection vector (reflect(L around N))

	ComputeLightContributions(eyePosition, normal, material.Shininess, lightAmbient, lightDiffuse, lightSpecular);

	return (
		material.EmissiveColor +
		material.AmbientColor * lightAmbient +
		material.DiffuseColor * lightDiffuse +
		material.SpecularColor * lightSpecular
	);
}