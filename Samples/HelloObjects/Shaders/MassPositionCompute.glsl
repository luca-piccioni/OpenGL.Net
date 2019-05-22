
#version 430

#include "/Mass.glsl"

#if !defined(COMPUTE_LOCAL_SIZE)
#define COMPUTE_LOCAL_SIZE 128
#endif

layout (std140, binding = 0) buffer MassBuffer
{
	Mass mass[];
};

layout(local_size_x = COMPUTE_LOCAL_SIZE) in;

uniform float glo_DeltaTime;

void main()
{
	uint gid = gl_GlobalInvocationID.x;

	vec3 p = mass[gid].Position.xyz;
	vec3 v = mass[gid].Velocity.xyz;
	vec3 e = mass[gid].Energy.xyz;
	float m = mass[gid].Size.w;

	v += (e / vec3(m)) * glo_DeltaTime;
	p += v * glo_DeltaTime;

	mass[gid].Position = vec4(p, 1.0f);
	mass[gid].Velocity = vec4(v, 0.0f);
}
