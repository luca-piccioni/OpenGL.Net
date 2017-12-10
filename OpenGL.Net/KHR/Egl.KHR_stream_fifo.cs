
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer

namespace OpenGL
{
	public partial class Egl
	{
		/// <summary>
		/// [EGL] Value of EGL_STREAM_FIFO_LENGTH_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream_fifo")]
		public const int STREAM_FIFO_LENGTH_KHR = 0x31FC;

		/// <summary>
		/// [EGL] Value of EGL_STREAM_TIME_NOW_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream_fifo")]
		public const int STREAM_TIME_NOW_KHR = 0x31FD;

		/// <summary>
		/// [EGL] Value of EGL_STREAM_TIME_CONSUMER_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream_fifo")]
		public const int STREAM_TIME_CONSUMER_KHR = 0x31FE;

		/// <summary>
		/// [EGL] Value of EGL_STREAM_TIME_PRODUCER_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream_fifo")]
		public const int STREAM_TIME_PRODUCER_KHR = 0x31FF;

		/// <summary>
		/// [EGL] eglQueryStreamTimeKHR: Binding for eglQueryStreamTimeKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:ulong[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream_fifo")]
		public static bool QueryStreamTimeKHR(IntPtr dpy, IntPtr stream, uint attribute, ulong[] value)
		{
			bool retValue;

			unsafe {
				fixed (ulong* p_value = value)
				{
					Debug.Assert(Delegates.peglQueryStreamTimeKHR != null, "peglQueryStreamTimeKHR not implemented");
					retValue = Delegates.peglQueryStreamTimeKHR(dpy, stream, attribute, p_value);
					LogCommand("eglQueryStreamTimeKHR", retValue, dpy, stream, attribute, value					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("EGL_KHR_stream_fifo")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool eglQueryStreamTimeKHR(IntPtr dpy, IntPtr stream, uint attribute, ulong* value);

			[RequiredByFeature("EGL_KHR_stream_fifo")]
			internal static eglQueryStreamTimeKHR peglQueryStreamTimeKHR;

		}
	}

}
