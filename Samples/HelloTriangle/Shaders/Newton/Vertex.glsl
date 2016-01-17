
// Copyright (C) 2016 Luca Piccioni
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
#include </OpenGL/TransformState.glsl>
#include </Newton/NewtonState.glsl>

// Vertex position
ATTRIBUTE vec3 hal_Position;
// Vertex speed
ATTRIBUTE vec3 hal_Speed;
// Vertex acceleration
ATTRIBUTE vec3 hal_Acceleration;
// Vertex mass
ATTRIBUTE float hal_Mass;

// Varying position (feedback support)
SHADER_OUT vec3 hal_VertexPosition;
// Varying speed (feedback support)
SHADER_OUT vec3 hal_VertexSpeed;
// Varying acceleration (feedback support)
SHADER_OUT vec3 hal_VertexAcceleration;
// Varying mass (feedback support)
SHADER_OUT float hal_VertexMass;

void main()
{
	// Compute acceleration
	hal_VertexAcceleration = hal_Acceleration;
	// Compute speed
	hal_VertexSpeed = hal_Speed;
	// Compute mass
	hal_VertexMass = hal_Mass;
	// Compute position
	hal_VertexPosition = hal_Position;

	// Project vertex position
	gl_Position = hal_ModelViewProjection * vec4(hal_VertexPosition, 1.0);
}
