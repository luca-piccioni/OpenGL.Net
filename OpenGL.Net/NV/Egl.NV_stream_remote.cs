
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
		/// Value of EGL_STREAM_STATE_INITIALIZING_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_remote")]
		public const int STREAM_STATE_INITIALIZING_NV = 0x3240;

		/// <summary>
		/// Value of EGL_STREAM_TYPE_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_remote")]
		public const int STREAM_TYPE_NV = 0x3241;

		/// <summary>
		/// Value of EGL_STREAM_PROTOCOL_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_remote")]
		public const int STREAM_PROTOCOL_NV = 0x3242;

		/// <summary>
		/// Value of EGL_STREAM_ENDPOINT_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_remote")]
		public const int STREAM_ENDPOINT_NV = 0x3243;

		/// <summary>
		/// Value of EGL_STREAM_LOCAL_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_remote")]
		public const int STREAM_LOCAL_NV = 0x3244;

		/// <summary>
		/// Value of EGL_STREAM_PRODUCER_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_remote")]
		public const int STREAM_PRODUCER_NV = 0x3247;

		/// <summary>
		/// Value of EGL_STREAM_CONSUMER_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_remote")]
		public const int STREAM_CONSUMER_NV = 0x3248;

		/// <summary>
		/// Value of EGL_STREAM_PROTOCOL_FD_NV symbol.
		/// </summary>
		[RequiredByFeature("EGL_NV_stream_remote")]
		public const int STREAM_PROTOCOL_FD_NV = 0x3246;

	}

}
