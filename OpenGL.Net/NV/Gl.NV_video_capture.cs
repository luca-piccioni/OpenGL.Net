
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
		/// Value of GL_VIDEO_BUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_BUFFER_NV = 0x9020;

		/// <summary>
		/// Value of GL_VIDEO_BUFFER_BINDING_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_BUFFER_BINDING_NV = 0x9021;

		/// <summary>
		/// Value of GL_FIELD_UPPER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int FIELD_UPPER_NV = 0x9022;

		/// <summary>
		/// Value of GL_FIELD_LOWER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int FIELD_LOWER_NV = 0x9023;

		/// <summary>
		/// Value of GL_NUM_VIDEO_CAPTURE_STREAMS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int NUM_VIDEO_CAPTURE_STREAMS_NV = 0x9024;

		/// <summary>
		/// Value of GL_NEXT_VIDEO_CAPTURE_BUFFER_STATUS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int NEXT_VIDEO_CAPTURE_BUFFER_STATUS_NV = 0x9025;

		/// <summary>
		/// Value of GL_VIDEO_CAPTURE_TO_422_SUPPORTED_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_CAPTURE_TO_422_SUPPORTED_NV = 0x9026;

		/// <summary>
		/// Value of GL_LAST_VIDEO_CAPTURE_STATUS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int LAST_VIDEO_CAPTURE_STATUS_NV = 0x9027;

		/// <summary>
		/// Value of GL_VIDEO_BUFFER_PITCH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_BUFFER_PITCH_NV = 0x9028;

		/// <summary>
		/// Value of GL_VIDEO_COLOR_CONVERSION_MATRIX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_COLOR_CONVERSION_MATRIX_NV = 0x9029;

		/// <summary>
		/// Value of GL_VIDEO_COLOR_CONVERSION_MAX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_COLOR_CONVERSION_MAX_NV = 0x902A;

		/// <summary>
		/// Value of GL_VIDEO_COLOR_CONVERSION_MIN_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_COLOR_CONVERSION_MIN_NV = 0x902B;

		/// <summary>
		/// Value of GL_VIDEO_COLOR_CONVERSION_OFFSET_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_COLOR_CONVERSION_OFFSET_NV = 0x902C;

		/// <summary>
		/// Value of GL_VIDEO_BUFFER_INTERNAL_FORMAT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_BUFFER_INTERNAL_FORMAT_NV = 0x902D;

		/// <summary>
		/// Value of GL_PARTIAL_SUCCESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int PARTIAL_SUCCESS_NV = 0x902E;

		/// <summary>
		/// Value of GL_SUCCESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int SUCCESS_NV = 0x902F;

		/// <summary>
		/// Value of GL_FAILURE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int FAILURE_NV = 0x9030;

		/// <summary>
		/// Value of GL_YCBYCR8_422_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int YCBYCR8_422_NV = 0x9031;

		/// <summary>
		/// Value of GL_YCBAYCR8A_4224_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int YCBAYCR8A_4224_NV = 0x9032;

		/// <summary>
		/// Value of GL_Z6Y10Z6CB10Z6Y10Z6CR10_422_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int Z6Y10Z6CB10Z6Y10Z6CR10_422_NV = 0x9033;

		/// <summary>
		/// Value of GL_Z6Y10Z6CB10Z6A10Z6Y10Z6CR10Z6A10_4224_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int Z6Y10Z6CB10Z6A10Z6Y10Z6CR10Z6A10_4224_NV = 0x9034;

		/// <summary>
		/// Value of GL_Z4Y12Z4CB12Z4Y12Z4CR12_422_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int Z4Y12Z4CB12Z4Y12Z4CR12_422_NV = 0x9035;

		/// <summary>
		/// Value of GL_Z4Y12Z4CB12Z4A12Z4Y12Z4CR12Z4A12_4224_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int Z4Y12Z4CB12Z4A12Z4Y12Z4CR12Z4A12_4224_NV = 0x9036;

		/// <summary>
		/// Value of GL_Z4Y12Z4CB12Z4CR12_444_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int Z4Y12Z4CB12Z4CR12_444_NV = 0x9037;

		/// <summary>
		/// Value of GL_VIDEO_CAPTURE_FRAME_WIDTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_CAPTURE_FRAME_WIDTH_NV = 0x9038;

		/// <summary>
		/// Value of GL_VIDEO_CAPTURE_FRAME_HEIGHT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_CAPTURE_FRAME_HEIGHT_NV = 0x9039;

		/// <summary>
		/// Value of GL_VIDEO_CAPTURE_FIELD_UPPER_HEIGHT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_CAPTURE_FIELD_UPPER_HEIGHT_NV = 0x903A;

		/// <summary>
		/// Value of GL_VIDEO_CAPTURE_FIELD_LOWER_HEIGHT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_CAPTURE_FIELD_LOWER_HEIGHT_NV = 0x903B;

		/// <summary>
		/// Value of GL_VIDEO_CAPTURE_SURFACE_ORIGIN_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_video_capture")]
		public const int VIDEO_CAPTURE_SURFACE_ORIGIN_NV = 0x903C;

		/// <summary>
		/// Binding for glBeginVideoCaptureNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static void BeginVideoCaptureNV(UInt32 video_capture_slot)
		{
			Debug.Assert(Delegates.pglBeginVideoCaptureNV != null, "pglBeginVideoCaptureNV not implemented");
			Delegates.pglBeginVideoCaptureNV(video_capture_slot);
			LogFunction("glBeginVideoCaptureNV({0})", video_capture_slot);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBindVideoCaptureStreamBufferNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="frame_region">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static void BindVideoCaptureStreamBufferNV(UInt32 video_capture_slot, UInt32 stream, Int32 frame_region, IntPtr offset)
		{
			Debug.Assert(Delegates.pglBindVideoCaptureStreamBufferNV != null, "pglBindVideoCaptureStreamBufferNV not implemented");
			Delegates.pglBindVideoCaptureStreamBufferNV(video_capture_slot, stream, frame_region, offset);
			LogFunction("glBindVideoCaptureStreamBufferNV({0}, {1}, {2}, 0x{3})", video_capture_slot, stream, LogEnumName(frame_region), offset.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBindVideoCaptureStreamTextureNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="frame_region">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static void BindVideoCaptureStreamTextureNV(UInt32 video_capture_slot, UInt32 stream, Int32 frame_region, Int32 target, UInt32 texture)
		{
			Debug.Assert(Delegates.pglBindVideoCaptureStreamTextureNV != null, "pglBindVideoCaptureStreamTextureNV not implemented");
			Delegates.pglBindVideoCaptureStreamTextureNV(video_capture_slot, stream, frame_region, target, texture);
			LogFunction("glBindVideoCaptureStreamTextureNV({0}, {1}, {2}, {3}, {4})", video_capture_slot, stream, LogEnumName(frame_region), LogEnumName(target), texture);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEndVideoCaptureNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static void EndVideoCaptureNV(UInt32 video_capture_slot)
		{
			Debug.Assert(Delegates.pglEndVideoCaptureNV != null, "pglEndVideoCaptureNV not implemented");
			Delegates.pglEndVideoCaptureNV(video_capture_slot);
			LogFunction("glEndVideoCaptureNV({0})", video_capture_slot);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetVideoCaptureivNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static void GetVideoCaptureNV(UInt32 video_capture_slot, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVideoCaptureivNV != null, "pglGetVideoCaptureivNV not implemented");
					Delegates.pglGetVideoCaptureivNV(video_capture_slot, pname, p_params);
					LogFunction("glGetVideoCaptureivNV({0}, {1}, {2})", video_capture_slot, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetVideoCaptureStreamivNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static void GetVideoCaptureStreamNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVideoCaptureStreamivNV != null, "pglGetVideoCaptureStreamivNV not implemented");
					Delegates.pglGetVideoCaptureStreamivNV(video_capture_slot, stream, pname, p_params);
					LogFunction("glGetVideoCaptureStreamivNV({0}, {1}, {2}, {3})", video_capture_slot, stream, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetVideoCaptureStreamfvNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static void GetVideoCaptureStreamNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVideoCaptureStreamfvNV != null, "pglGetVideoCaptureStreamfvNV not implemented");
					Delegates.pglGetVideoCaptureStreamfvNV(video_capture_slot, stream, pname, p_params);
					LogFunction("glGetVideoCaptureStreamfvNV({0}, {1}, {2}, {3})", video_capture_slot, stream, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetVideoCaptureStreamdvNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static void GetVideoCaptureStreamNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, [Out] double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVideoCaptureStreamdvNV != null, "pglGetVideoCaptureStreamdvNV not implemented");
					Delegates.pglGetVideoCaptureStreamdvNV(video_capture_slot, stream, pname, p_params);
					LogFunction("glGetVideoCaptureStreamdvNV({0}, {1}, {2}, {3})", video_capture_slot, stream, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVideoCaptureNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="sequence_num">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="capture_time">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static Int32 VideoCaptureNV(UInt32 video_capture_slot, UInt32[] sequence_num, UInt64[] capture_time)
		{
			Int32 retValue;

			unsafe {
				fixed (UInt32* p_sequence_num = sequence_num)
				fixed (UInt64* p_capture_time = capture_time)
				{
					Debug.Assert(Delegates.pglVideoCaptureNV != null, "pglVideoCaptureNV not implemented");
					retValue = Delegates.pglVideoCaptureNV(video_capture_slot, p_sequence_num, p_capture_time);
					LogFunction("glVideoCaptureNV({0}, {1}, {2}) = {3}", video_capture_slot, LogValue(sequence_num), LogValue(capture_time), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glVideoCaptureStreamParameterivNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static void VideoCaptureStreamParameterNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglVideoCaptureStreamParameterivNV != null, "pglVideoCaptureStreamParameterivNV not implemented");
					Delegates.pglVideoCaptureStreamParameterivNV(video_capture_slot, stream, pname, p_params);
					LogFunction("glVideoCaptureStreamParameterivNV({0}, {1}, {2}, {3})", video_capture_slot, stream, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVideoCaptureStreamParameterfvNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static void VideoCaptureStreamParameterNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglVideoCaptureStreamParameterfvNV != null, "pglVideoCaptureStreamParameterfvNV not implemented");
					Delegates.pglVideoCaptureStreamParameterfvNV(video_capture_slot, stream, pname, p_params);
					LogFunction("glVideoCaptureStreamParameterfvNV({0}, {1}, {2}, {3})", video_capture_slot, stream, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVideoCaptureStreamParameterdvNV.
		/// </summary>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_video_capture")]
		public static void VideoCaptureStreamParameterNV(UInt32 video_capture_slot, UInt32 stream, Int32 pname, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglVideoCaptureStreamParameterdvNV != null, "pglVideoCaptureStreamParameterdvNV not implemented");
					Delegates.pglVideoCaptureStreamParameterdvNV(video_capture_slot, stream, pname, p_params);
					LogFunction("glVideoCaptureStreamParameterdvNV({0}, {1}, {2}, {3})", video_capture_slot, stream, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
