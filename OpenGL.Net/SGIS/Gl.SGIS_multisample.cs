
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
		/// Value of GL_MULTISAMPLE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int MULTISAMPLE_SGIS = 0x809D;

		/// <summary>
		/// Value of GL_SAMPLE_ALPHA_TO_MASK_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E;

		/// <summary>
		/// Value of GL_SAMPLE_ALPHA_TO_ONE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F;

		/// <summary>
		/// Value of GL_SAMPLE_MASK_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int SAMPLE_MASK_SGIS = 0x80A0;

		/// <summary>
		/// Value of GL_1PASS_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int _1PASS_SGIS = 0x80A1;

		/// <summary>
		/// Value of GL_2PASS_0_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int _2PASS_0_SGIS = 0x80A2;

		/// <summary>
		/// Value of GL_2PASS_1_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int _2PASS_1_SGIS = 0x80A3;

		/// <summary>
		/// Value of GL_4PASS_0_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int _4PASS_0_SGIS = 0x80A4;

		/// <summary>
		/// Value of GL_4PASS_1_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int _4PASS_1_SGIS = 0x80A5;

		/// <summary>
		/// Value of GL_4PASS_2_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int _4PASS_2_SGIS = 0x80A6;

		/// <summary>
		/// Value of GL_4PASS_3_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int _4PASS_3_SGIS = 0x80A7;

		/// <summary>
		/// Value of GL_SAMPLE_BUFFERS_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int SAMPLE_BUFFERS_SGIS = 0x80A8;

		/// <summary>
		/// Value of GL_SAMPLES_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int SAMPLES_SGIS = 0x80A9;

		/// <summary>
		/// Value of GL_SAMPLE_MASK_VALUE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int SAMPLE_MASK_VALUE_SGIS = 0x80AA;

		/// <summary>
		/// Value of GL_SAMPLE_MASK_INVERT_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int SAMPLE_MASK_INVERT_SGIS = 0x80AB;

		/// <summary>
		/// Value of GL_SAMPLE_PATTERN_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_multisample")]
		public const int SAMPLE_PATTERN_SGIS = 0x80AC;

		/// <summary>
		/// Binding for glSampleMaskSGIS.
		/// </summary>
		/// <param name="value">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="invert">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_multisample")]
		public static void SampleMaskSGIS(float value, bool invert)
		{
			Debug.Assert(Delegates.pglSampleMaskSGIS != null, "pglSampleMaskSGIS not implemented");
			Delegates.pglSampleMaskSGIS(value, invert);
			CallLog("glSampleMaskSGIS({0}, {1})", value, invert);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSamplePatternSGIS.
		/// </summary>
		/// <param name="pattern">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_multisample")]
		public static void SamplePatternSGIS(int pattern)
		{
			Debug.Assert(Delegates.pglSamplePatternSGIS != null, "pglSamplePatternSGIS not implemented");
			Delegates.pglSamplePatternSGIS(pattern);
			CallLog("glSamplePatternSGIS({0})", pattern);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSamplePatternSGIS.
		/// </summary>
		/// <param name="pattern">
		/// A <see cref="T:SamplePatternSGIS"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_multisample")]
		public static void SamplePatternSGIS(SamplePatternSGIS pattern)
		{
			Debug.Assert(Delegates.pglSamplePatternSGIS != null, "pglSamplePatternSGIS not implemented");
			Delegates.pglSamplePatternSGIS((int)pattern);
			CallLog("glSamplePatternSGIS({0})", pattern);
			DebugCheckErrors();
		}

	}

}
