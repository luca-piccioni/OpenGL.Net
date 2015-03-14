
// Copyright (C) 2015 Luca Piccioni
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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_TEXTURE_BUFFER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_buffer_object")]
		public const int TEXTURE_BUFFER_EXT = 0x8C2A;

		/// <summary>
		/// Value of GL_MAX_TEXTURE_BUFFER_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_buffer_object")]
		public const int MAX_TEXTURE_BUFFER_SIZE_EXT = 0x8C2B;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_BUFFER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_buffer_object")]
		public const int TEXTURE_BINDING_BUFFER_EXT = 0x8C2C;

		/// <summary>
		/// Value of GL_TEXTURE_BUFFER_DATA_STORE_BINDING_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_buffer_object")]
		public const int TEXTURE_BUFFER_DATA_STORE_BINDING_EXT = 0x8C2D;

		/// <summary>
		/// Value of GL_TEXTURE_BUFFER_FORMAT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_buffer_object")]
		public const int TEXTURE_BUFFER_FORMAT_EXT = 0x8C2E;

		/// <summary>
		/// Binding for glTexBufferEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_texture_buffer_object")]
		public static void TexBufferEXT(TextureTarget target, int internalformat, UInt32 buffer)
		{
			Debug.Assert(Delegates.pglTexBufferEXT != null, "pglTexBufferEXT not implemented");
			Delegates.pglTexBufferEXT((int)target, internalformat, buffer);
			CallLog("glTexBufferEXT({0}, {1}, {2})", target, internalformat, buffer);
			DebugCheckErrors();
		}

	}

}
