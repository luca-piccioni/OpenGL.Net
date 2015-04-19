
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
			Delegates.pglGetColorTableSGI((int)target, (int)format, (int)type, table);
			CallLog("glGetColorTableSGI({0}, {1}, {2}, {3})", target, format, type, table);
			DebugCheckErrors();
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
					Delegates.pglGetColorTableParameterfvSGI((int)target, (int)pname, p_params);
					CallLog("glGetColorTableParameterfvSGI({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
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
					Delegates.pglGetColorTableParameterivSGI((int)target, (int)pname, p_params);
					CallLog("glGetColorTableParameterivSGI({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

	}

}
