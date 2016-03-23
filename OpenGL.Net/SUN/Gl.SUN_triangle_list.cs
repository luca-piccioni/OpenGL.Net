
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
		/// Value of GL_RESTART_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public const int RESTART_SUN = 0x0001;

		/// <summary>
		/// Value of GL_REPLACE_MIDDLE_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public const int REPLACE_MIDDLE_SUN = 0x0002;

		/// <summary>
		/// Value of GL_REPLACE_OLDEST_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public const int REPLACE_OLDEST_SUN = 0x0003;

		/// <summary>
		/// Value of GL_TRIANGLE_LIST_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public const int TRIANGLE_LIST_SUN = 0x81D7;

		/// <summary>
		/// Value of GL_REPLACEMENT_CODE_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public const int REPLACEMENT_CODE_SUN = 0x81D8;

		/// <summary>
		/// Value of GL_REPLACEMENT_CODE_ARRAY_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public const int REPLACEMENT_CODE_ARRAY_SUN = 0x85C0;

		/// <summary>
		/// Value of GL_REPLACEMENT_CODE_ARRAY_TYPE_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public const int REPLACEMENT_CODE_ARRAY_TYPE_SUN = 0x85C1;

		/// <summary>
		/// Value of GL_REPLACEMENT_CODE_ARRAY_STRIDE_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public const int REPLACEMENT_CODE_ARRAY_STRIDE_SUN = 0x85C2;

		/// <summary>
		/// Value of GL_REPLACEMENT_CODE_ARRAY_POINTER_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public const int REPLACEMENT_CODE_ARRAY_POINTER_SUN = 0x85C3;

		/// <summary>
		/// Value of GL_R1UI_V3F_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public const int R1UI_V3F_SUN = 0x85C4;

		/// <summary>
		/// Value of GL_R1UI_C4UB_V3F_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public const int R1UI_C4UB_V3F_SUN = 0x85C5;

		/// <summary>
		/// Value of GL_R1UI_C3F_V3F_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public const int R1UI_C3F_V3F_SUN = 0x85C6;

		/// <summary>
		/// Value of GL_R1UI_N3F_V3F_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public const int R1UI_N3F_V3F_SUN = 0x85C7;

		/// <summary>
		/// Value of GL_R1UI_C4F_N3F_V3F_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public const int R1UI_C4F_N3F_V3F_SUN = 0x85C8;

		/// <summary>
		/// Value of GL_R1UI_T2F_V3F_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public const int R1UI_T2F_V3F_SUN = 0x85C9;

		/// <summary>
		/// Value of GL_R1UI_T2F_N3F_V3F_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public const int R1UI_T2F_N3F_V3F_SUN = 0x85CA;

		/// <summary>
		/// Value of GL_R1UI_T2F_C4F_N3F_V3F_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public const int R1UI_T2F_C4F_N3F_V3F_SUN = 0x85CB;

		/// <summary>
		/// Binding for glReplacementCodeuiSUN.
		/// </summary>
		/// <param name="code">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public static void ReplacementCodeuiSUN(UInt32 code)
		{
			Debug.Assert(Delegates.pglReplacementCodeuiSUN != null, "pglReplacementCodeuiSUN not implemented");
			Delegates.pglReplacementCodeuiSUN(code);
			LogFunction("glReplacementCodeuiSUN({0})", code);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glReplacementCodeusSUN.
		/// </summary>
		/// <param name="code">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public static void ReplacementCodeusSUN(UInt16 code)
		{
			Debug.Assert(Delegates.pglReplacementCodeusSUN != null, "pglReplacementCodeusSUN not implemented");
			Delegates.pglReplacementCodeusSUN(code);
			LogFunction("glReplacementCodeusSUN({0})", code);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glReplacementCodeubSUN.
		/// </summary>
		/// <param name="code">
		/// A <see cref="T:byte"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public static void ReplacementCodeubSUN(byte code)
		{
			Debug.Assert(Delegates.pglReplacementCodeubSUN != null, "pglReplacementCodeubSUN not implemented");
			Delegates.pglReplacementCodeubSUN(code);
			LogFunction("glReplacementCodeubSUN({0})", code);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glReplacementCodeuivSUN.
		/// </summary>
		/// <param name="code">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public static void ReplacementCodeuiSUN(UInt32[] code)
		{
			unsafe {
				fixed (UInt32* p_code = code)
				{
					Debug.Assert(Delegates.pglReplacementCodeuivSUN != null, "pglReplacementCodeuivSUN not implemented");
					Delegates.pglReplacementCodeuivSUN(p_code);
					LogFunction("glReplacementCodeuivSUN({0})", LogValue(code));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glReplacementCodeusvSUN.
		/// </summary>
		/// <param name="code">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public static void ReplacementCodeusSUN(UInt16[] code)
		{
			unsafe {
				fixed (UInt16* p_code = code)
				{
					Debug.Assert(Delegates.pglReplacementCodeusvSUN != null, "pglReplacementCodeusvSUN not implemented");
					Delegates.pglReplacementCodeusvSUN(p_code);
					LogFunction("glReplacementCodeusvSUN({0})", LogValue(code));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glReplacementCodeubvSUN.
		/// </summary>
		/// <param name="code">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public static void ReplacementCodeubSUN(byte[] code)
		{
			unsafe {
				fixed (byte* p_code = code)
				{
					Debug.Assert(Delegates.pglReplacementCodeubvSUN != null, "pglReplacementCodeubvSUN not implemented");
					Delegates.pglReplacementCodeubvSUN(p_code);
					LogFunction("glReplacementCodeubvSUN({0})", LogValue(code));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glReplacementCodePointerSUN.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_triangle_list")]
		public static void ReplacementCodePointerSUN(Int32 type, Int32 stride, IntPtr[] pointer)
		{
			unsafe {
				fixed (IntPtr* p_pointer = pointer)
				{
					Debug.Assert(Delegates.pglReplacementCodePointerSUN != null, "pglReplacementCodePointerSUN not implemented");
					Delegates.pglReplacementCodePointerSUN(type, stride, p_pointer);
					LogFunction("glReplacementCodePointerSUN({0}, {1}, {2})", LogEnumName(type), stride, LogValue(pointer));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
