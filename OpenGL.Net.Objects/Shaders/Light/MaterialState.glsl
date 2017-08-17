
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

#ifndef GLO_MATERIAL_STATE
#define GLO_MATERIAL_STATE

// Common material type
struct glo_MaterialType
{
	// Material ambient color.
	vec4 AmbientColor;
	// Material emissive color.
	vec4 EmissiveColor;
	// Material diffuse color.
	vec4 DiffuseColor;
	// Material emissive color.
	vec4 SpecularColor;
	// Material shininess.
	float Shininess;
};

// The front face material
uniform glo_MaterialType glo_FrontMaterial;

// Emission texture
uniform sampler2D glo_FrontMaterialEmissionTexture;
uniform int glo_FrontMaterialEmissionTexCoord;

// Diffuse texture
uniform sampler2D glo_FrontMaterialDiffuseTexture;
uniform int glo_FrontMaterialDiffuseTexCoord;

// Normal texture
uniform sampler2D glo_FrontMaterialNormalTexture;
uniform int glo_FrontMaterialNormalTexCoord;

// Specular texture
uniform sampler2D glo_FrontMaterialSpecularTexture;
uniform int glo_FrontMaterialSpecularTexCoord;

// Ambient texture
uniform sampler2D glo_FrontMaterialAmbientTexture;
uniform int glo_FrontMaterialAmbientTexCoord;

// Displacement texture
uniform sampler2D glo_FrontMaterialDisplacementTexture;
uniform int glo_FrontMaterialDisplacementTexCoord;
uniform float glo_FrontMaterialDisplacementFactor;

#endif
