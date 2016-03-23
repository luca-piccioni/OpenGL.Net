
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
		/// Value of GL_COLOR_BUFFER_BIT0_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint COLOR_BUFFER_BIT0_QCOM = 0x00000001;

		/// <summary>
		/// Value of GL_COLOR_BUFFER_BIT1_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint COLOR_BUFFER_BIT1_QCOM = 0x00000002;

		/// <summary>
		/// Value of GL_COLOR_BUFFER_BIT2_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint COLOR_BUFFER_BIT2_QCOM = 0x00000004;

		/// <summary>
		/// Value of GL_COLOR_BUFFER_BIT3_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint COLOR_BUFFER_BIT3_QCOM = 0x00000008;

		/// <summary>
		/// Value of GL_COLOR_BUFFER_BIT4_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint COLOR_BUFFER_BIT4_QCOM = 0x00000010;

		/// <summary>
		/// Value of GL_COLOR_BUFFER_BIT5_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint COLOR_BUFFER_BIT5_QCOM = 0x00000020;

		/// <summary>
		/// Value of GL_COLOR_BUFFER_BIT6_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint COLOR_BUFFER_BIT6_QCOM = 0x00000040;

		/// <summary>
		/// Value of GL_COLOR_BUFFER_BIT7_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint COLOR_BUFFER_BIT7_QCOM = 0x00000080;

		/// <summary>
		/// Value of GL_DEPTH_BUFFER_BIT0_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint DEPTH_BUFFER_BIT0_QCOM = 0x00000100;

		/// <summary>
		/// Value of GL_DEPTH_BUFFER_BIT1_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint DEPTH_BUFFER_BIT1_QCOM = 0x00000200;

		/// <summary>
		/// Value of GL_DEPTH_BUFFER_BIT2_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint DEPTH_BUFFER_BIT2_QCOM = 0x00000400;

		/// <summary>
		/// Value of GL_DEPTH_BUFFER_BIT3_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint DEPTH_BUFFER_BIT3_QCOM = 0x00000800;

		/// <summary>
		/// Value of GL_DEPTH_BUFFER_BIT4_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint DEPTH_BUFFER_BIT4_QCOM = 0x00001000;

		/// <summary>
		/// Value of GL_DEPTH_BUFFER_BIT5_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint DEPTH_BUFFER_BIT5_QCOM = 0x00002000;

		/// <summary>
		/// Value of GL_DEPTH_BUFFER_BIT6_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint DEPTH_BUFFER_BIT6_QCOM = 0x00004000;

		/// <summary>
		/// Value of GL_DEPTH_BUFFER_BIT7_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint DEPTH_BUFFER_BIT7_QCOM = 0x00008000;

		/// <summary>
		/// Value of GL_STENCIL_BUFFER_BIT0_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint STENCIL_BUFFER_BIT0_QCOM = 0x00010000;

		/// <summary>
		/// Value of GL_STENCIL_BUFFER_BIT1_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint STENCIL_BUFFER_BIT1_QCOM = 0x00020000;

		/// <summary>
		/// Value of GL_STENCIL_BUFFER_BIT2_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint STENCIL_BUFFER_BIT2_QCOM = 0x00040000;

		/// <summary>
		/// Value of GL_STENCIL_BUFFER_BIT3_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint STENCIL_BUFFER_BIT3_QCOM = 0x00080000;

		/// <summary>
		/// Value of GL_STENCIL_BUFFER_BIT4_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint STENCIL_BUFFER_BIT4_QCOM = 0x00100000;

		/// <summary>
		/// Value of GL_STENCIL_BUFFER_BIT5_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint STENCIL_BUFFER_BIT5_QCOM = 0x00200000;

		/// <summary>
		/// Value of GL_STENCIL_BUFFER_BIT6_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint STENCIL_BUFFER_BIT6_QCOM = 0x00400000;

		/// <summary>
		/// Value of GL_STENCIL_BUFFER_BIT7_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint STENCIL_BUFFER_BIT7_QCOM = 0x00800000;

		/// <summary>
		/// Value of GL_MULTISAMPLE_BUFFER_BIT0_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint MULTISAMPLE_BUFFER_BIT0_QCOM = 0x01000000;

		/// <summary>
		/// Value of GL_MULTISAMPLE_BUFFER_BIT1_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint MULTISAMPLE_BUFFER_BIT1_QCOM = 0x02000000;

		/// <summary>
		/// Value of GL_MULTISAMPLE_BUFFER_BIT2_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint MULTISAMPLE_BUFFER_BIT2_QCOM = 0x04000000;

		/// <summary>
		/// Value of GL_MULTISAMPLE_BUFFER_BIT3_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint MULTISAMPLE_BUFFER_BIT3_QCOM = 0x08000000;

		/// <summary>
		/// Value of GL_MULTISAMPLE_BUFFER_BIT4_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint MULTISAMPLE_BUFFER_BIT4_QCOM = 0x10000000;

		/// <summary>
		/// Value of GL_MULTISAMPLE_BUFFER_BIT5_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint MULTISAMPLE_BUFFER_BIT5_QCOM = 0x20000000;

		/// <summary>
		/// Value of GL_MULTISAMPLE_BUFFER_BIT6_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint MULTISAMPLE_BUFFER_BIT6_QCOM = 0x40000000;

		/// <summary>
		/// Value of GL_MULTISAMPLE_BUFFER_BIT7_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint MULTISAMPLE_BUFFER_BIT7_QCOM = 0x80000000;

		/// <summary>
		/// Binding for glStartTilingQCOM.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="preserveMask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		public static void StartQCOM(UInt32 x, UInt32 y, UInt32 width, UInt32 height, UInt32 preserveMask)
		{
			Debug.Assert(Delegates.pglStartTilingQCOM != null, "pglStartTilingQCOM not implemented");
			Delegates.pglStartTilingQCOM(x, y, width, height, preserveMask);
			LogFunction("glStartTilingQCOM({0}, {1}, {2}, {3}, {4})", x, y, width, height, preserveMask);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEndTilingQCOM.
		/// </summary>
		/// <param name="preserveMask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_tiled_rendering", Api = "gles1|gles2")]
		public static void EndQCOM(UInt32 preserveMask)
		{
			Debug.Assert(Delegates.pglEndTilingQCOM != null, "pglEndTilingQCOM not implemented");
			Delegates.pglEndTilingQCOM(preserveMask);
			LogFunction("glEndTilingQCOM({0})", preserveMask);
			DebugCheckErrors(null);
		}

	}

}
