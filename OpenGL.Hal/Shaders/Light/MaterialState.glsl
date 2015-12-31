
// Copyright (C) 2012-2015 Luca Piccioni
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

#ifndef HAL_MATERIAL_STATE
#define HAL_MATERIAL_STATE

// Common material type
struct hal_MaterialType
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
uniform hal_MaterialType hal_FrontMaterial;

// The front face material texture for emission component, if any
uniform sampler2D hal_FrontMaterialEmissionTexture;
// The front face material texture for emission component, if any
uniform int hal_FrontMaterialEmissionTexCoord;

// The front face material texture for ambient component, if any
uniform sampler2D hal_FrontMaterialAmbientTexture;
// The front face material texture for ambient component, if any
uniform int hal_FrontMaterialAmbientTexCoord;

// The front face material texture for diffuse component, if any
uniform sampler2D hal_FrontMaterialDiffuseTexture;
// The front face material texture for diffuse component, if any
uniform int hal_FrontMaterialDiffuseTexCoord;

#endif
