
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

#ifndef GLO_COMPATIBILITY
#define GLO_COMPATIBILITY

#if __VERSION__ >= 120
#define INVARIANT invariant
#else
#define INVARIANT
#endif

#if __VERSION__ >= 130

#define ATTRIBUTE in
#define SHADER_IN in
#define SHADER_OUT out
#define OUT out

#define TEXTURE_2D							texture
#define TEXTURE_3D							texture
#define TEXTURE_RECT						texture
#define TEXTURE_CUBE						texture

#else

#define ATTRIBUTE							attribute
#define SHADER_IN							varying
#define SHADER_OUT							varying
#define OUT

#define TEXTURE_2D							texture2D
#define TEXTURE_3D							texture3D
#define TEXTURE_RECT						texture2DRect
#define TEXTURE_CUBE						textureCube

#endif

#if __VERSION__ >= 150

#define BEGIN_INPUT_BLOCK(name)				in name {
#define END_INPUT_BLOCK_ANON()				};
#define BEGIN_OUTPUT_BLOCK(name)			out name {
#define END_OUTPUT_BLOCK_ANON()				};

#define TEXTURE_SIZE(sampler)				textureSize(sampler)

#define GEOMETRY_LAYOUT_IN(from)			layout (from) in
#define GEOMETRY_LAYOUT(to, max)			layout (to, max_vertices = max) out

#else

#define BEGIN_INPUT_BLOCK(name)
#define END_INPUT_BLOCK_ANON()
#define BEGIN_OUTPUT_BLOCK(name)
#define END_INPUT_BLOCK_ANON()

#define TEXTURE_SIZE(sampler)				sampler ## _Size

#define GEOMETRY_LAYOUT_IN(from)
#define GEOMETRY_LAYOUT(to, max)

#endif

#if defined(GL_ARB_explicit_attrib_location)
#define LOCATION(loc)						layout(location = loc)
#else
#define LOCATION(loc)
#endif

#if defined(GL_ARB_uniform_buffer_object) && !defined(DISABLE_GL_ARB_uniform_buffer_object)
#define BLOCK_BEGIN(block_name)						layout(std140) uniform block_name {
#define BLOCK_BEGIN_LAYOUT(block_name, layoutName)	layout(layoutName) uniform block_name {
#define BLOCK_END(instance_name)					} instance_name;
#define BLOCK_END_ANON()							};
#define BLOCK_FIELD
#define BLOCK_GET(instance_name, field_name)		instance_name.field_name
#else
#define BLOCK_BEGIN(name)
#define BLOCK_BEGIN_LAYOUT(block_name, layout)
#define BLOCK_END(instance_name)
#define BLOCK_END_ANON()
#define BLOCK_FIELD									uniform
#define BLOCK_GET(instance_name, field_name)		field_name
#endif

#endif