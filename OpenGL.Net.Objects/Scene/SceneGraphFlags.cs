
// Copyright (C) 2016-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;

namespace OpenGL.Objects.Scene
{
	/// <summary>
	/// Flags controlling the <see cref="SceneGraph"/>.
	/// </summary>
	[Flags]
	public enum SceneGraphFlags
	{
		/// <summary>
		/// No flags placeholder.
		/// </summary>
		None =						0x0000,

		/// <summary>
		/// Culling based on view-frustum.
		/// </summary>
		CullingViewFrustum =		0x0001,

		/// <summary>
		/// Sort scene objects depending on their state.
		/// </summary>
		StateSorting =				0x0002,

		/// <summary>
		/// Bounding boxes are visible.
		/// </summary>
		BoundingVolumes =			0x0004,

		/// <summary>
		/// Light management.
		/// </summary>
		Lighting =					0x0008,

		/// <summary>
		/// Shadow maps are updated.
		/// </summary>
		ShadowMaps =				0x0010,
	}
}
