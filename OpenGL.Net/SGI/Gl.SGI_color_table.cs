
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
		/// Binding for glGetColorTableSGI.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ColorTableTargetSGI"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_SGI_color_table")]
		public static void GetColorTableSGI(ColorTableTargetSGI target, PixelFormat format, PixelType type, IntPtr table)
		{
			Debug.Assert(Delegates.pglGetColorTableSGI != null, "pglGetColorTableSGI not implemented");
			Delegates.pglGetColorTableSGI((Int32)target, (Int32)format, (Int32)type, table);
			LogCommand("glGetColorTableSGI", null, target, format, type, table			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetColorTableSGI.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ColorTableTargetSGI"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_SGI_color_table")]
		public static void GetColorTableSGI(ColorTableTargetSGI target, PixelFormat format, PixelType type, Object table)
		{
			GCHandle pin_table = GCHandle.Alloc(table, GCHandleType.Pinned);
			try {
				GetColorTableSGI(target, format, type, pin_table.AddrOfPinnedObject());
			} finally {
				pin_table.Free();
			}
		}

		/// <summary>
		/// Binding for glGetColorTableParameterfvSGI.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ColorTableTargetSGI"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetColorTableParameterPNameSGI"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGI_color_table")]
		public static void GetColorTableParameterSGI(ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetColorTableParameterfvSGI != null, "pglGetColorTableParameterfvSGI not implemented");
					Delegates.pglGetColorTableParameterfvSGI((Int32)target, (Int32)pname, p_params);
					LogCommand("glGetColorTableParameterfvSGI", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetColorTableParameterivSGI.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ColorTableTargetSGI"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetColorTableParameterPNameSGI"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGI_color_table")]
		public static void GetColorTableParameterSGI(ColorTableTargetSGI target, GetColorTableParameterPNameSGI pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetColorTableParameterivSGI != null, "pglGetColorTableParameterivSGI not implemented");
					Delegates.pglGetColorTableParameterivSGI((Int32)target, (Int32)pname, p_params);
					LogCommand("glGetColorTableParameterivSGI", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetColorTableSGI", ExactSpelling = true)]
			internal extern static unsafe void glGetColorTableSGI(Int32 target, Int32 format, Int32 type, IntPtr table);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetColorTableParameterfvSGI", ExactSpelling = true)]
			internal extern static unsafe void glGetColorTableParameterfvSGI(Int32 target, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetColorTableParameterivSGI", ExactSpelling = true)]
			internal extern static unsafe void glGetColorTableParameterivSGI(Int32 target, Int32 pname, Int32* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_SGI_color_table")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetColorTableSGI(Int32 target, Int32 format, Int32 type, IntPtr table);

			[ThreadStatic]
			internal static glGetColorTableSGI pglGetColorTableSGI;

			[RequiredByFeature("GL_SGI_color_table")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetColorTableParameterfvSGI(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetColorTableParameterfvSGI pglGetColorTableParameterfvSGI;

			[RequiredByFeature("GL_SGI_color_table")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetColorTableParameterivSGI(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetColorTableParameterivSGI pglGetColorTableParameterivSGI;

		}
	}

}
