
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
		/// Value of GL_MULTISAMPLE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		public const int MULTISAMPLE_EXT = 0x809D;

		/// <summary>
		/// Value of GL_SAMPLE_ALPHA_TO_MASK_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		public const int SAMPLE_ALPHA_TO_MASK_EXT = 0x809E;

		/// <summary>
		/// Value of GL_SAMPLE_ALPHA_TO_ONE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		public const int SAMPLE_ALPHA_TO_ONE_EXT = 0x809F;

		/// <summary>
		/// Value of GL_SAMPLE_MASK_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		public const int SAMPLE_MASK_EXT = 0x80A0;

		/// <summary>
		/// Value of GL_1PASS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		public const int _1PASS_EXT = 0x80A1;

		/// <summary>
		/// Value of GL_2PASS_0_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		public const int _2PASS_0_EXT = 0x80A2;

		/// <summary>
		/// Value of GL_2PASS_1_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		public const int _2PASS_1_EXT = 0x80A3;

		/// <summary>
		/// Value of GL_4PASS_0_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		public const int _4PASS_0_EXT = 0x80A4;

		/// <summary>
		/// Value of GL_4PASS_1_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		public const int _4PASS_1_EXT = 0x80A5;

		/// <summary>
		/// Value of GL_4PASS_2_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		public const int _4PASS_2_EXT = 0x80A6;

		/// <summary>
		/// Value of GL_4PASS_3_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		public const int _4PASS_3_EXT = 0x80A7;

		/// <summary>
		/// Value of GL_SAMPLE_BUFFERS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		public const int SAMPLE_BUFFERS_EXT = 0x80A8;

		/// <summary>
		/// Value of GL_SAMPLES_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		public const int SAMPLES_EXT = 0x80A9;

		/// <summary>
		/// Value of GL_SAMPLE_MASK_VALUE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		public const int SAMPLE_MASK_VALUE_EXT = 0x80AA;

		/// <summary>
		/// Value of GL_SAMPLE_MASK_INVERT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		public const int SAMPLE_MASK_INVERT_EXT = 0x80AB;

		/// <summary>
		/// Value of GL_SAMPLE_PATTERN_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		public const int SAMPLE_PATTERN_EXT = 0x80AC;

		/// <summary>
		/// Value of GL_MULTISAMPLE_BIT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		public const uint MULTISAMPLE_BIT_EXT = 0x20000000;

		/// <summary>
		/// Binding for glSampleMaskEXT.
		/// </summary>
		/// <param name="value">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="invert">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_multisample")]
		public static void SampleMaskEXT(float value, bool invert)
		{
			if        (Delegates.pglSampleMaskEXT != null) {
				Delegates.pglSampleMaskEXT(value, invert);
				CallLog("glSampleMaskEXT({0}, {1})", value, invert);
			} else if (Delegates.pglSampleMaskSGIS != null) {
				Delegates.pglSampleMaskSGIS(value, invert);
				CallLog("glSampleMaskSGIS({0}, {1})", value, invert);
			} else
				throw new NotImplementedException("glSampleMaskEXT (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSamplePatternEXT.
		/// </summary>
		/// <param name="pattern">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_multisample")]
		public static void SamplePatternEXT(int pattern)
		{
			if        (Delegates.pglSamplePatternEXT != null) {
				Delegates.pglSamplePatternEXT(pattern);
				CallLog("glSamplePatternEXT({0})", pattern);
			} else if (Delegates.pglSamplePatternSGIS != null) {
				Delegates.pglSamplePatternSGIS(pattern);
				CallLog("glSamplePatternSGIS({0})", pattern);
			} else
				throw new NotImplementedException("glSamplePatternEXT (and other aliases) are not implemented");
			DebugCheckErrors();
		}

	}

}
