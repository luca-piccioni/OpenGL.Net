
// Copyright (C) 2015-2016 Luca Piccioni
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
	public partial class Egl
	{
		/// <summary>
		/// Value of EGL_MAX_STREAM_METADATA_BLOCKS_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int MAX_STREAM_METADATA_BLOCKS_NV = 0x3250;

		/// <summary>
		/// Value of EGL_MAX_STREAM_METADATA_BLOCK_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int MAX_STREAM_METADATA_BLOCK_SIZE_NV = 0x3251;

		/// <summary>
		/// Value of EGL_MAX_STREAM_METADATA_TOTAL_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int MAX_STREAM_METADATA_TOTAL_SIZE_NV = 0x3252;

		/// <summary>
		/// Value of EGL_PRODUCER_METADATA_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int PRODUCER_METADATA_NV = 0x3253;

		/// <summary>
		/// Value of EGL_CONSUMER_METADATA_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int CONSUMER_METADATA_NV = 0x3254;

		/// <summary>
		/// Value of EGL_PENDING_METADATA_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int PENDING_METADATA_NV = 0x3328;

		/// <summary>
		/// Value of EGL_METADATA0_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int METADATA0_SIZE_NV = 0x3255;

		/// <summary>
		/// Value of EGL_METADATA1_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int METADATA1_SIZE_NV = 0x3256;

		/// <summary>
		/// Value of EGL_METADATA2_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int METADATA2_SIZE_NV = 0x3257;

		/// <summary>
		/// Value of EGL_METADATA3_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int METADATA3_SIZE_NV = 0x3258;

		/// <summary>
		/// Value of EGL_METADATA0_TYPE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int METADATA0_TYPE_NV = 0x3259;

		/// <summary>
		/// Value of EGL_METADATA1_TYPE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int METADATA1_TYPE_NV = 0x325A;

		/// <summary>
		/// Value of EGL_METADATA2_TYPE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int METADATA2_TYPE_NV = 0x325B;

		/// <summary>
		/// Value of EGL_METADATA3_TYPE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public const int METADATA3_TYPE_NV = 0x325C;

		/// <summary>
		/// Binding for eglSetStreamMetadataNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public static bool SetStreamNV(IntPtr dpy, IntPtr stream, int n, int offset, int size, IntPtr data)
		{
			bool retValue;

			Debug.Assert(Delegates.peglSetStreamMetadataNV != null, "peglSetStreamMetadataNV not implemented");
			retValue = Delegates.peglSetStreamMetadataNV(dpy, stream, n, offset, size, data);
			LogFunction("eglSetStreamMetadataNV(0x{0}, 0x{1}, {2}, {3}, {4}, 0x{5}) = {6}", dpy.ToString("X8"), stream.ToString("X8"), n, offset, size, data.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglQueryStreamMetadataNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_NV_stream_metadata")]
		public static bool QueryStreamNV(IntPtr dpy, IntPtr stream, uint name, int n, int offset, int size, IntPtr data)
		{
			bool retValue;

			Debug.Assert(Delegates.peglQueryStreamMetadataNV != null, "peglQueryStreamMetadataNV not implemented");
			retValue = Delegates.peglQueryStreamMetadataNV(dpy, stream, name, n, offset, size, data);
			LogFunction("eglQueryStreamMetadataNV(0x{0}, 0x{1}, {2}, {3}, {4}, {5}, 0x{6}) = {7}", dpy.ToString("X8"), stream.ToString("X8"), name, n, offset, size, data.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglSetStreamMetadataNV", ExactSpelling = true)]
			internal extern static unsafe bool eglSetStreamMetadataNV(IntPtr dpy, IntPtr stream, int n, int offset, int size, IntPtr data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglQueryStreamMetadataNV", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryStreamMetadataNV(IntPtr dpy, IntPtr stream, uint name, int n, int offset, int size, IntPtr data);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_NV_stream_metadata")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglSetStreamMetadataNV(IntPtr dpy, IntPtr stream, int n, int offset, int size, IntPtr data);

			internal static eglSetStreamMetadataNV peglSetStreamMetadataNV;

			[RequiredByFeature("EGL_NV_stream_metadata")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryStreamMetadataNV(IntPtr dpy, IntPtr stream, uint name, int n, int offset, int size, IntPtr data);

			internal static eglQueryStreamMetadataNV peglQueryStreamMetadataNV;

		}
	}

}
