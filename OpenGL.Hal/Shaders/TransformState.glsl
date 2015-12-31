
// Copyright (C) 2011-2015 Luca Piccioni
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

#ifndef HAL_TRANSFORM_STATE
#define HAL_TRANSFORM_STATE

// Projection matrix
uniform mat4 hal_Projection;

// The model-view matrix
uniform mat4 hal_ModelView;

// The model-view-projection matrix
uniform mat4 hal_ModelViewProjection;

// Inverse projection matrix
uniform mat4 hal_InverseProjection;

// Inverse of the model-view matrix
uniform mat4 hal_InverseModelView;

// Inverse of hal_ModelViewProjection
uniform mat4 hal_InverseModelViewProjection;

// Normal transformation matrix
uniform mat3 hal_NormalMatrix;

#endif
