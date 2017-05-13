
// Copyright (C) 2015-2017 Luca Piccioni
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_TEXTURE_BINDING_RENDERBUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int TEXTURE_BINDING_RENDERBUFFER_NV = 0x8E53;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_RENDERBUFFER_DATA_STORE_BINDING_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int TEXTURE_RENDERBUFFER_DATA_STORE_BINDING_NV = 0x8E54;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_RENDERBUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int TEXTURE_RENDERBUFFER_NV = 0x8E55;

		/// <summary>
		/// [GL] Value of GL_SAMPLER_RENDERBUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int SAMPLER_RENDERBUFFER_NV = 0x8E56;

		/// <summary>
		/// [GL] Value of GL_INT_SAMPLER_RENDERBUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int INT_SAMPLER_RENDERBUFFER_NV = 0x8E57;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT_SAMPLER_RENDERBUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int UNSIGNED_INT_SAMPLER_RENDERBUFFER_NV = 0x8E58;

		/// <summary>
		/// Binding for glSampleMaskIndexedNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public static void SampleMaskIndexedNV(UInt32 index, UInt32 mask)
		{
			Debug.Assert(Delegates.pglSampleMaskIndexedNV != null, "pglSampleMaskIndexedNV not implemented");
			Delegates.pglSampleMaskIndexedNV(index, mask);
			LogCommand("glSampleMaskIndexedNV", null, index, mask			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexRenderbufferNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public static void TexRenderbufferNV(TextureTarget target, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglTexRenderbufferNV != null, "pglTexRenderbufferNV not implemented");
			Delegates.pglTexRenderbufferNV((Int32)target, renderbuffer);
			LogCommand("glTexRenderbufferNV", null, target, renderbuffer			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSampleMaskIndexedNV", ExactSpelling = true)]
			internal extern static void glSampleMaskIndexedNV(UInt32 index, UInt32 mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexRenderbufferNV", ExactSpelling = true)]
			internal extern static void glTexRenderbufferNV(Int32 target, UInt32 renderbuffer);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_explicit_multisample")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSampleMaskIndexedNV(UInt32 index, UInt32 mask);

			[RequiredByFeature("GL_NV_explicit_multisample")]
			[ThreadStatic]
			internal static glSampleMaskIndexedNV pglSampleMaskIndexedNV;

			[RequiredByFeature("GL_NV_explicit_multisample")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexRenderbufferNV(Int32 target, UInt32 renderbuffer);

			[RequiredByFeature("GL_NV_explicit_multisample")]
			[ThreadStatic]
			internal static glTexRenderbufferNV pglTexRenderbufferNV;

		}
	}

}
