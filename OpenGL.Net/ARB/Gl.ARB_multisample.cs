
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
		/// Value of GL_MULTISAMPLE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multisample")]
		public const int MULTISAMPLE_ARB = 0x809D;

		/// <summary>
		/// Value of GL_SAMPLE_ALPHA_TO_COVERAGE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multisample")]
		public const int SAMPLE_ALPHA_TO_COVERAGE_ARB = 0x809E;

		/// <summary>
		/// Value of GL_SAMPLE_ALPHA_TO_ONE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multisample")]
		public const int SAMPLE_ALPHA_TO_ONE_ARB = 0x809F;

		/// <summary>
		/// Value of GL_SAMPLE_COVERAGE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multisample")]
		public const int SAMPLE_COVERAGE_ARB = 0x80A0;

		/// <summary>
		/// Value of GL_SAMPLE_BUFFERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multisample")]
		public const int SAMPLE_BUFFERS_ARB = 0x80A8;

		/// <summary>
		/// Value of GL_SAMPLE_COVERAGE_VALUE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multisample")]
		public const int SAMPLE_COVERAGE_VALUE_ARB = 0x80AA;

		/// <summary>
		/// Value of GL_SAMPLE_COVERAGE_INVERT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multisample")]
		public const int SAMPLE_COVERAGE_INVERT_ARB = 0x80AB;

		/// <summary>
		/// Value of GL_MULTISAMPLE_BIT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multisample")]
		public const uint MULTISAMPLE_BIT_ARB = 0x20000000;

		/// <summary>
		/// Binding for glSampleCoverageARB.
		/// </summary>
		/// <param name="value">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="invert">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multisample")]
		public static void SampleCoverageARB(float value, bool invert)
		{
			Debug.Assert(Delegates.pglSampleCoverageARB != null, "pglSampleCoverageARB not implemented");
			Delegates.pglSampleCoverageARB(value, invert);
			CallLog("glSampleCoverageARB({0}, {1})", value, invert);
			DebugCheckErrors();
		}

	}

}
