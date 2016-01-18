
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
#include </OpenGL/Time.glsl>
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
	const float G = 6.674e−11;

	vec3 newtonAcceleration = vec3(0.0);

	// Compute contributions of centers of gravity
	for (int i = 0; i < hal_GravityPointsCount; i++) {

		// Note: Newton's law of universal gravitation
		// F = G * m1 * m2

		vec3 cogVector = hal_GravityPoints[i].Position - hal_Position;
		float cogDistance = length(cogVector);
		float cogForce = (hal_VertexMass * hal_GravityPoints[i].Mass * G) / pow(cogDistance, 2);

		// Note: Newton's law of motion (second law)
		// F = m * a --> a = F / M
		float cogAcceleration =  cogForce / hal_VertexMass;

		newtonAcceleration += normalize(cogVector) * cogAcceleration;
	}

	// Compute acceleration
	hal_VertexAcceleration = hal_Acceleration + newtonAcceleration;
	// Compute speed
	hal_VertexSpeed = hal_Speed + (hal_VertexAcceleration * hal_FrameTimeInterval);
	// Compute mass
	hal_VertexMass = hal_Mass;
	// Compute position
	hal_VertexPosition = hal_Position + (hal_VertexSpeed * hal_FrameTimeInterval);

	// Project vertex position
	gl_Position = hal_ModelViewProjection * vec4(hal_Position, 1.0);
}
