
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
	public partial class Egl
	{
		/// <summary>
		/// Value of EGL_CL_EVENT_HANDLE_KHR symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to CL_EVENT_HANDLE.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_KHR_cl_event")]
		[RequiredByFeature("EGL_KHR_cl_event2")]
		public const int CL_EVENT_HANDLE_KHR = 0x309C;

		/// <summary>
		/// Value of EGL_SYNC_CL_EVENT_KHR symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to SYNC_CL_EVENT.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_KHR_cl_event")]
		[RequiredByFeature("EGL_KHR_cl_event2")]
		public const int SYNC_CL_EVENT_KHR = 0x30FE;

		/// <summary>
		/// Value of EGL_SYNC_CL_EVENT_COMPLETE_KHR symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to SYNC_CL_EVENT_COMPLETE.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_KHR_cl_event")]
		[RequiredByFeature("EGL_KHR_cl_event2")]
		public const int SYNC_CL_EVENT_COMPLETE_KHR = 0x30FF;

	}

}
