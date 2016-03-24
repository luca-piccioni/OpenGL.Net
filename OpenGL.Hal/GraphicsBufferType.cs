
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

using System;

namespace OpenGL
{
	/// <summary>
	/// Graphic buffer type.
	/// </summary>
	/// <remarks>
	/// This enumeration specify surface buffers available of each RenderSurface, or duplication
	/// of defined buffers for double buffering or stereoscopic buffers.
	/// </remarks>
	[Flags]
	public enum GraphicsBufferType
	{
		/// <summary>
		/// Color buffer. 
		/// </summary>
		Color =				0x8000,

		/// <summary>
		/// Color buffer, but encoded in sRGB color space.
		/// </summary>
		ColorSRGB =			0x8001,

		/// <summary>
		/// Depth buffer.
		/// </summary>
		Depth =				0x0002,

		/// <summary>
		/// Stencil buffer.
		/// </summary>
		Stencil =			0x0004,

		/// <summary>
		/// Multisample buffer.
		/// </summary>
		Multisample =		0x0008,

		/// <summary>
		/// Double buffer.
		/// </summary>
		Double =			0x0010,
	}
}
