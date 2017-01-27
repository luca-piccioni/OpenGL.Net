
// Copyright (C) 2012-2016 Luca Piccioni
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
uniform int glo_FrontMaterialEmissionTexCoord = -1;

// Diffuse texture
uniform sampler2D glo_FrontMaterialDiffuseTexture;
uniform int glo_FrontMaterialDiffuseTexCoord = -1;

// Normal texture
uniform sampler2D glo_FrontMaterialNormalTexture;
uniform int glo_FrontMaterialNormalTexCoord = -1;

// Specular texture
uniform sampler2D glo_FrontMaterialSpecularTexture;
uniform int glo_FrontMaterialSpecularTexCoord = -1;

// Ambient texture
uniform sampler2D glo_FrontMaterialAmbientTexture;
uniform int glo_FrontMaterialAmbientTexCoord = -1;

// Displacement texture
uniform sampler2D glo_FrontMaterialDisplacementTexture;
uniform int glo_FrontMaterialDisplacementTexCoord = -1;
uniform float glo_FrontMaterialDisplacementFactor = 1.0;

#endif
