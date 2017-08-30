
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

#ifndef GLO_VIEWPORT
#define GLO_VIEWPORT

// The size of the viewport, in pixels
uniform vec2 glo_ViewportSize;
// The projection depth in model space
uniform vec2 glo_ViewportDepth;

// Manually clip line vertices
// @param a		Coordinate of the line (in clip space).
// @param b		Coordinate of the line (in clip space).
bool ClipLineVertices(inout vec4 a, inout vec4 b)
{
	float t0 = a.z + a.w;
	float t1 = b.z + b.w;

	float nearClipFactor = (0.0 - t0) / (t1 - t0);

	if (t0 < 0.0)
		a = mix(a, b, nearClipFactor);
	if (t1 < 0.0)
		b = mix(a, b, nearClipFactor);

	return (t0 < 0.0 && t1 < 0.0);
}

#endif