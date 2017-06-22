
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
		/// [GL] Value of GL_SAMPLE_ALPHA_TO_MASK_EXT symbol.
		/// </summary>
		[AliasOf("GL_SAMPLE_ALPHA_TO_MASK_SGIS")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int SAMPLE_ALPHA_TO_MASK_EXT = 0x809E;

		/// <summary>
		/// [GL] Value of GL_SAMPLE_MASK_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		public const int SAMPLE_MASK_EXT = 0x80A0;

		/// <summary>
		/// [GL] Value of GL_1PASS_EXT symbol.
		/// </summary>
		[AliasOf("GL_1PASS_SGIS")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int _1PASS_EXT = 0x80A1;

		/// <summary>
		/// [GL] Value of GL_2PASS_0_EXT symbol.
		/// </summary>
		[AliasOf("GL_2PASS_0_SGIS")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int _2PASS_0_EXT = 0x80A2;

		/// <summary>
		/// [GL] Value of GL_2PASS_1_EXT symbol.
		/// </summary>
		[AliasOf("GL_2PASS_1_SGIS")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int _2PASS_1_EXT = 0x80A3;

		/// <summary>
		/// [GL] Value of GL_4PASS_0_EXT symbol.
		/// </summary>
		[AliasOf("GL_4PASS_0_SGIS")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int _4PASS_0_EXT = 0x80A4;

		/// <summary>
		/// [GL] Value of GL_4PASS_1_EXT symbol.
		/// </summary>
		[AliasOf("GL_4PASS_1_SGIS")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int _4PASS_1_EXT = 0x80A5;

		/// <summary>
		/// [GL] Value of GL_4PASS_2_EXT symbol.
		/// </summary>
		[AliasOf("GL_4PASS_2_SGIS")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int _4PASS_2_EXT = 0x80A6;

		/// <summary>
		/// [GL] Value of GL_4PASS_3_EXT symbol.
		/// </summary>
		[AliasOf("GL_4PASS_3_SGIS")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int _4PASS_3_EXT = 0x80A7;

		/// <summary>
		/// [GL] Value of GL_SAMPLE_MASK_VALUE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		public const int SAMPLE_MASK_VALUE_EXT = 0x80AA;

		/// <summary>
		/// [GL] Value of GL_SAMPLE_MASK_INVERT_EXT symbol.
		/// </summary>
		[AliasOf("GL_SAMPLE_MASK_INVERT_SGIS")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int SAMPLE_MASK_INVERT_EXT = 0x80AB;

		/// <summary>
		/// [GL] Value of GL_SAMPLE_PATTERN_EXT symbol.
		/// </summary>
		[AliasOf("GL_SAMPLE_PATTERN_SGIS")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int SAMPLE_PATTERN_EXT = 0x80AC;

		/// <summary>
		/// [GL] Binding for glSampleMaskEXT.
		/// </summary>
		/// <param name="value">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="invert">
		/// A <see cref="T:bool"/>.
		/// </param>
		[AliasOf("glSampleMaskSGIS")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
		public static void SampleMaskEXT(float value, bool invert)
		{
			Debug.Assert(Delegates.pglSampleMaskEXT != null, "pglSampleMaskEXT not implemented");
			Delegates.pglSampleMaskEXT(value, invert);
			LogCommand("glSampleMaskEXT", null, value, invert			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glSamplePatternEXT.
		/// </summary>
		/// <param name="pattern">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[AliasOf("glSamplePatternSGIS")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
		public static void SamplePatternEXT(Int32 pattern)
		{
			Debug.Assert(Delegates.pglSamplePatternEXT != null, "pglSamplePatternEXT not implemented");
			Delegates.pglSamplePatternEXT(pattern);
			LogCommand("glSamplePatternEXT", null, pattern			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSampleMaskEXT", ExactSpelling = true)]
			internal extern static void glSampleMaskEXT(float value, bool invert);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSamplePatternEXT", ExactSpelling = true)]
			internal extern static void glSamplePatternEXT(Int32 pattern);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_multisample")]
			[RequiredByFeature("GL_SGIS_multisample")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSampleMaskEXT(float value, bool invert);

			[AliasOf("glSampleMaskEXT")]
			[AliasOf("glSampleMaskSGIS")]
			[RequiredByFeature("GL_EXT_multisample")]
			[RequiredByFeature("GL_SGIS_multisample")]
			[ThreadStatic]
			internal static glSampleMaskEXT pglSampleMaskEXT;

			[RequiredByFeature("GL_EXT_multisample")]
			[RequiredByFeature("GL_SGIS_multisample")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSamplePatternEXT(Int32 pattern);

			[AliasOf("glSamplePatternEXT")]
			[AliasOf("glSamplePatternSGIS")]
			[RequiredByFeature("GL_EXT_multisample")]
			[RequiredByFeature("GL_SGIS_multisample")]
			[ThreadStatic]
			internal static glSamplePatternEXT pglSamplePatternEXT;

		}
	}

}
