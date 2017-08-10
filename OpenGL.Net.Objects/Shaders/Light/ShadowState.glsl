
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

#ifndef GLO_SHADOW_STATE
#define GLO_SHADOW_STATE

#ifndef GLO_MAX_SHADOWS_COUNT
#define GLO_MAX_SHADOWS_COUNT			4
#endif

// Model-view-projection matrix for object-space to light-space transformation
uniform mat4 glo_ShadowMap2D_MVP[GLO_MAX_SHADOWS_COUNT];
// Shadow maps sampled using sample2D
uniform sampler2DShadow glo_ShadowMap2D[GLO_MAX_SHADOWS_COUNT];
// Number of valid sampler2DShadow in glo_ShadowMap2D
uniform int glo_ShadowMap2D_Count = 0;

#endif
