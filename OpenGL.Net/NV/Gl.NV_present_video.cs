
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
		/// Value of GL_FRAME_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_present_video")]
		public const int FRAME_NV = 0x8E26;

		/// <summary>
		/// Value of GL_FIELDS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_present_video")]
		public const int FIELDS_NV = 0x8E27;

		/// <summary>
		/// Value of GL_CURRENT_TIME_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_present_video")]
		public const int CURRENT_TIME_NV = 0x8E28;

		/// <summary>
		/// Value of GL_NUM_FILL_STREAMS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_present_video")]
		public const int NUM_FILL_STREAMS_NV = 0x8E29;

		/// <summary>
		/// Value of GL_PRESENT_TIME_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_present_video")]
		public const int PRESENT_TIME_NV = 0x8E2A;

		/// <summary>
		/// Value of GL_PRESENT_DURATION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_present_video")]
		public const int PRESENT_DURATION_NV = 0x8E2B;

		/// <summary>
		/// Binding for glPresentFrameKeyedNV.
		/// </summary>
		/// <param name="video_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="minPresentTime">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="beginPresentTimeId">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="presentDurationId">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fill0">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="key0">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fill1">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="key1">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_present_video")]
		public static void PresentFrameKeyedNV(UInt32 video_slot, UInt64 minPresentTime, UInt32 beginPresentTimeId, UInt32 presentDurationId, Int32 type, Int32 target0, UInt32 fill0, UInt32 key0, Int32 target1, UInt32 fill1, UInt32 key1)
		{
			Debug.Assert(Delegates.pglPresentFrameKeyedNV != null, "pglPresentFrameKeyedNV not implemented");
			Delegates.pglPresentFrameKeyedNV(video_slot, minPresentTime, beginPresentTimeId, presentDurationId, type, target0, fill0, key0, target1, fill1, key1);
			LogFunction("glPresentFrameKeyedNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", video_slot, minPresentTime, beginPresentTimeId, presentDurationId, LogEnumName(type), LogEnumName(target0), fill0, key0, LogEnumName(target1), fill1, key1);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPresentFrameDualFillNV.
		/// </summary>
		/// <param name="video_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="minPresentTime">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="beginPresentTimeId">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="presentDurationId">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fill0">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fill1">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target2">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fill2">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target3">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fill3">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_present_video")]
		public static void PresentFrameDualFillNV(UInt32 video_slot, UInt64 minPresentTime, UInt32 beginPresentTimeId, UInt32 presentDurationId, Int32 type, Int32 target0, UInt32 fill0, Int32 target1, UInt32 fill1, Int32 target2, UInt32 fill2, Int32 target3, UInt32 fill3)
		{
			Debug.Assert(Delegates.pglPresentFrameDualFillNV != null, "pglPresentFrameDualFillNV not implemented");
			Delegates.pglPresentFrameDualFillNV(video_slot, minPresentTime, beginPresentTimeId, presentDurationId, type, target0, fill0, target1, fill1, target2, fill2, target3, fill3);
			LogFunction("glPresentFrameDualFillNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12})", video_slot, minPresentTime, beginPresentTimeId, presentDurationId, LogEnumName(type), LogEnumName(target0), fill0, LogEnumName(target1), fill1, LogEnumName(target2), fill2, LogEnumName(target3), fill3);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetVideoivNV.
		/// </summary>
		/// <param name="video_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_present_video")]
		public static void GetVideoNV(UInt32 video_slot, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVideoivNV != null, "pglGetVideoivNV not implemented");
					Delegates.pglGetVideoivNV(video_slot, pname, p_params);
					LogFunction("glGetVideoivNV({0}, {1}, {2})", video_slot, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetVideouivNV.
		/// </summary>
		/// <param name="video_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_present_video")]
		public static void GetVideoNV(UInt32 video_slot, Int32 pname, [Out] UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVideouivNV != null, "pglGetVideouivNV not implemented");
					Delegates.pglGetVideouivNV(video_slot, pname, p_params);
					LogFunction("glGetVideouivNV({0}, {1}, {2})", video_slot, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetVideoi64vNV.
		/// </summary>
		/// <param name="video_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_present_video")]
		public static void GetVideoNV(UInt32 video_slot, Int32 pname, [Out] Int64[] @params)
		{
			unsafe {
				fixed (Int64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVideoi64vNV != null, "pglGetVideoi64vNV not implemented");
					Delegates.pglGetVideoi64vNV(video_slot, pname, p_params);
					LogFunction("glGetVideoi64vNV({0}, {1}, {2})", video_slot, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetVideoui64vNV.
		/// </summary>
		/// <param name="video_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_present_video")]
		public static void GetVideoui64vNV(UInt32 video_slot, Int32 pname, [Out] UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVideoui64vNV != null, "pglGetVideoui64vNV not implemented");
					Delegates.pglGetVideoui64vNV(video_slot, pname, p_params);
					LogFunction("glGetVideoui64vNV({0}, {1}, {2})", video_slot, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
