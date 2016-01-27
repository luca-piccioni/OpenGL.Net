
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

// Vertex position (ligth-years, about 9.461e+12 km == 1e13 km)
ATTRIBUTE vec3 hal_Position;
// Vertex speed (normalized value of the universal constant c, about 300e6 m/s)
ATTRIBUTE vec3 hal_Speed;
// Vertex acceleration (normalized value of the universal constant c in years, about )
ATTRIBUTE vec3 hal_Acceleration;
// Vertex mass (in Solar masses, about 1.98855e20 kg == 2e20)
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
	vec3 newtonAcceleration = vec3(0.0);

#if 0
	// Compute contributions of centers of gravity
	for (int i = 0; i < hal_GravityPointsCount; i++) {
		const float G = 6.674; // 6.674e−11;

		// Note: Newton's law of universal gravitation
		//  F  =       G      * m1 * m2 /  r^2
		// [N] = [N·m^2/kg^2] * [kg^2]  / [m^2]
		//            e-11    * e20^2    / e13^2  ==> -11 + 40 - 26 ==> -3
		// Note: (unity values for mass and distance give e-3N) i.e.
		// Two objects having mass 1.0 (solar mass) at 1 distance (light-year) apply a force of 1e-3N
		// Indeed adjusting the magnitude of constant G by 1e11, cogForce should be meant as e8N; this gain will
		// be recovered in the acceleration derivation

		vec3 cogVector = hal_GravityPoints[i].Position - hal_Position;
		float cogDistance = length(cogVector);
		float cogForce = (hal_VertexMass * hal_GravityPoints[i].Mass * G) / pow(cogDistance, 2);

		// Note: Newton's law of motion (second law)
		//  F  =  m   *    a     --> a = F / m
		// [N] / [kg] = [m/s^2]
		//  e8 / e20 =   e-12
		// But the acceleration must be integrated for 1e3 years, that are 0.031536e12 seconds, and than scaled with
		// the frametime interval, indeed 
		float cogAcceleration = (cogForce / hal_Mass) * 0.031536 * hal_FrameTimeInterval;

		newtonAcceleration += normalize(cogVector) * cogAcceleration;		// in
	}
#else
	// Compute contributions of centers of gravity
	for (int i = 0; i < hal_GravityPointsCount; i++) {
		const float G = 1e-6;
		vec3 cogVector = hal_GravityPoints[i].Position - hal_Position;
		float cogDistance = length(cogVector);
		float cogForce = G * (hal_Mass * hal_GravityPoints[i].Mass) / pow(cogDistance, 2);

		float cogAcceleration = cogForce / hal_Mass;

		newtonAcceleration = normalize(cogVector) * vec3(cogAcceleration);
	}
#endif

	// Compute acceleration (used next cycle)
	hal_VertexAcceleration = newtonAcceleration;

	// Note: hal_FrameTimeInterval is meant in 1e3 years.
	
	// Compute speed
	hal_VertexSpeed = hal_Speed + (hal_Acceleration * vec3(hal_FrameTimeInterval));
	// Compute mass
	hal_VertexMass = hal_Mass;
	// Compute position
	hal_VertexPosition = hal_Position + (hal_VertexSpeed * vec3(hal_FrameTimeInterval));

	// Project vertex position
	gl_Position = hal_ModelViewProjection * vec4(hal_VertexPosition, 1.0);
}
