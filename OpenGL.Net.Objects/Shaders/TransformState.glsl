
// Copyright (C) 2011-2017 Luca Piccioni
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

#ifndef GLO_TRANSFORM_STATE
#define GLO_TRANSFORM_STATE

// Projection matrix
uniform mat4 glo_Projection;

// The model matrix
uniform mat4 glo_Model;

// The model-view matrix
uniform mat4 glo_ModelView;

// The model-view-projection matrix
uniform mat4 glo_ModelViewProjection;

// Normal transformation matrix
uniform mat3 glo_NormalMatrix;

// Inverse projection matrix
uniform mat4 glo_InverseProjection;

// Inverse of the model-view matrix
uniform mat4 glo_InverseModelView;

// Inverse of glo_ModelViewProjection
uniform mat4 glo_InverseModelViewProjection;

// Projection near/far planes distances
// - x: near plane distance
// - y: far plane distance.
uniform vec2 glo_DepthDistances;

#endif
