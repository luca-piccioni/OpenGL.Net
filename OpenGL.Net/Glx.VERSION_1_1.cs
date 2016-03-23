
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
	public partial class Glx
	{
		/// <summary>
		/// Value of GLX_VENDOR symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_1")]
		public const int VENDOR = 0x1;

		/// <summary>
		/// Value of GLX_VERSION symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_1")]
		public const int VERSION = 0x2;

		/// <summary>
		/// Value of GLX_EXTENSIONS symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_1")]
		public const int EXTENSIONS = 0x3;

		/// <summary>
		/// return list of supported extensions
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="screen">
		/// Specifies the screen number.
		/// </param>
		/// <seealso cref="Glx.etString"/>
		/// <seealso cref="Glx.QueryVersion"/>
		/// <seealso cref="Glx.QueryServerString"/>
		/// <seealso cref="Glx.GetClientString"/>
		[RequiredByFeature("GLX_VERSION_1_1")]
		public static string QueryExtensionsString(IntPtr dpy, int screen)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXQueryExtensionsString != null, "pglXQueryExtensionsString not implemented");
			retValue = Delegates.pglXQueryExtensionsString(dpy, screen);
			LogFunction("glXQueryExtensionsString(0x{0}, {1}) = {2}", dpy.ToString("X8"), screen, Marshal.PtrToStringAnsi(retValue));

			return (Marshal.PtrToStringAnsi(retValue));
		}

		/// <summary>
		/// return string describing the server
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="screen">
		/// Specifies the screen number.
		/// </param>
		/// <param name="name">
		/// Specifies which string is returned: one of Glx.VENDOR, Glx.VERSION, or Glx.EXTENSIONS.
		/// </param>
		/// <seealso cref="Glx.QueryVersion"/>
		/// <seealso cref="Glx.GetClientString"/>
		/// <seealso cref="Glx.QueryExtensionsString"/>
		[RequiredByFeature("GLX_VERSION_1_1")]
		public static string QueryServerString(IntPtr dpy, int screen, int name)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXQueryServerString != null, "pglXQueryServerString not implemented");
			retValue = Delegates.pglXQueryServerString(dpy, screen, name);
			LogFunction("glXQueryServerString(0x{0}, {1}, {2}) = {3}", dpy.ToString("X8"), screen, name, Marshal.PtrToStringAnsi(retValue));

			return (Marshal.PtrToStringAnsi(retValue));
		}

		/// <summary>
		/// return a string describing the client
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="name">
		/// Specifies which string is returned. The symbolic constants Glx.VENDOR, Glx.VERSION, and Glx.EXTENSIONS are accepted.
		/// </param>
		/// <seealso cref="Glx.QueryVersion"/>
		/// <seealso cref="Glx.QueryExtensionsString"/>
		/// <seealso cref="Glx.QueryServerString"/>
		[RequiredByFeature("GLX_VERSION_1_1")]
		public static string GetClientString(IntPtr dpy, int name)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXGetClientString != null, "pglXGetClientString not implemented");
			retValue = Delegates.pglXGetClientString(dpy, name);
			LogFunction("glXGetClientString(0x{0}, {1}) = {2}", dpy.ToString("X8"), name, Marshal.PtrToStringAnsi(retValue));

			return (Marshal.PtrToStringAnsi(retValue));
		}

	}

}
