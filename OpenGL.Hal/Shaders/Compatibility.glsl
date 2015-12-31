
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

#ifndef HAL_COMPATIBILITY
#define HAL_COMPATIBILITY

// Shader renderer

// Symbol defined if running on NVIDIA renderer.
#define HAL_VENDOR_NVIDIA			1
// Symbol defined if running on ATI/AMD renderer.
#define HAL_VENDOR_AMD				2
// Symbol defined if running on INTEL renderer
#define HAL_VENDOR_INTEL				3

// Shader inputs and outputs keywords
//
// - ATTRIBUTE: used to mark a vertex shader inputs
// - SHADER_IN: used to mark a non-vertex shader inputs
// - SHADER_OUT: used to mark a non-fragment shader output
// - OUT: used to mark a fragment shader output
#if __VERSION__ >= 130

#define ATTRIBUTE in
#define SHADER_IN in
#define SHADER_OUT out
#define OUT out

#else

#define ATTRIBUTE attribute
#define SHADER_IN varying
#define SHADER_OUT varying
#define OUT

#endif

// Support array attributes
#if __VERSION__ >= 130

#define ARRAY_ATTRIBUTE(name, size)	name[size]

#else

#define ARRAY_ATTRIBUTE(name, size)	name[size]

#endif

// Uniform blocks
#if __VERSION__ >= 130

#define BEGIN_UNIFORM_BLOCK(name)	uniform name {

#define END_UNIFORM_BLOCK() };

#else

#define BEGIN_UNIFORM_BLOCK(name)

#define END_UNIFORM_BLOCK()

#endif

// Input and output blocks
#if __VERSION__ >= 150

#define BEGIN_INPUT_BLOCK(name)	in name {
#define END_INPUT_BLOCK() };

#define BEGIN_OUTPUT_BLOCK(name) out name {
#define END_OUTPUT_BLOCK() };

#else

#define BEGIN_INPUT_BLOCK(name)
#define END_INPUT_BLOCK()

#define BEGIN_OUTPUT_BLOCK(name)
#define END_OUTPUT_BLOCK()

#endif

// Texturing functions
#if __VERSION__ >= 130

#define TEXTURE_2D texture
#define TEXTURE_3D texture
#define TEXTURE_RECT texture
#define TEXTURE_CUBE texture

#if __VERSION__ >= 150
#define TEXTURE_SIZE(sampler) textureSize(sampler)
#else
#define TEXTURE_SIZE(sampler) sampler ## _Size
#endif

#else

#define TEXTURE_2D texture2D
#define TEXTURE_3D texture3D
#define TEXTURE_RECT texture2DRect
#define TEXTURE_CUBE textureCube

#endif

// Invariance
#if __VERSION__ >= 120
#define INVARIANT invariant
#else
#define INVARIANT
#endif

// Attribute location
#if defined(GL_ARB_explicit_attrib_location)
#define LOCATION(loc)		layout(location = loc)
#else
#define LOCATION(loc)
#endif

// Geometry shader layout
#if __VERSION__ >= 150
#define GEOMETRY_LAYOUT_IN(from) layout (from) in
#define GEOMETRY_LAYOUT(to, max) layout (to, max_vertices = max) out
#else
#define GEOMETRY_LAYOUT_IN(from)
#define GEOMETRY_LAYOUT(to, max)
#endif

#endif