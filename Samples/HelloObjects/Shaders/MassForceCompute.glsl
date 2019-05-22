
#version 430

#include "/Mass.glsl"

#if !defined(COMPUTE_LOCAL_SIZE)
#define COMPUTE_LOCAL_SIZE 128
#endif

layout (std140, binding = 0) buffer MassBuffer
{
	Mass mass[];
};

uniform int glo_MassCount;
uniform float glo_Gravity;
uniform float glo_MinDistanceForGravity;

layout(local_size_x = COMPUTE_LOCAL_SIZE) in;

uniform float glo_DeltaTime;

void main()
{
	uint gid = gl_GlobalInvocationID.x;

	vec3 p1 = mass[gid].Position.xyz;
	vec3 s1 = mass[gid].Size.xyz;
	float m1 = mass[gid].Size.w;

	vec3 f = vec3(0.0f);

	for (int i = 0; i < glo_MassCount; ++i) {
		vec3 p2 = mass[i].Position.xyz;
		vec3 s2 = mass[i].Size.xyz;
		float m2 = mass[i].Size.w;

		vec3 dir = p2 - p1;
		float r2 = dot(dir, dir);

		if (r2 > glo_MinDistanceForGravity)
			f += (glo_Gravity * (m1 * m2) / r2) * normalize(dir);
	}

	mass[gid].Energy = vec4(f, 0.0f);
}