
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
	public partial class Wgl
	{
		/// <summary>
		/// Binding for wglCreateDisplayColorTableEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_display_color_table")]
		public static bool CreateDisplayColorTableEXT(UInt16 id)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglCreateDisplayColorTableEXT != null, "pwglCreateDisplayColorTableEXT not implemented");
			retValue = Delegates.pwglCreateDisplayColorTableEXT(id);
			LogFunction("wglCreateDisplayColorTableEXT({0}) = {1}", id, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglLoadDisplayColorTableEXT.
		/// </summary>
		/// <param name="table">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_display_color_table")]
		public static bool LoadDisplayColorTableEXT(UInt16[] table, UInt32 length)
		{
			bool retValue;

			unsafe {
				fixed (UInt16* p_table = table)
				{
					Debug.Assert(Delegates.pwglLoadDisplayColorTableEXT != null, "pwglLoadDisplayColorTableEXT not implemented");
					retValue = Delegates.pwglLoadDisplayColorTableEXT(p_table, length);
					LogFunction("wglLoadDisplayColorTableEXT({0}, {1}) = {2}", LogValue(table), length, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglBindDisplayColorTableEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_display_color_table")]
		public static bool BindDisplayColorTableEXT(UInt16 id)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglBindDisplayColorTableEXT != null, "pwglBindDisplayColorTableEXT not implemented");
			retValue = Delegates.pwglBindDisplayColorTableEXT(id);
			LogFunction("wglBindDisplayColorTableEXT({0}) = {1}", id, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglDestroyDisplayColorTableEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_display_color_table")]
		public static void DestroyDisplayColorTableEXT(UInt16 id)
		{
			Debug.Assert(Delegates.pwglDestroyDisplayColorTableEXT != null, "pwglDestroyDisplayColorTableEXT not implemented");
			Delegates.pwglDestroyDisplayColorTableEXT(id);
			LogFunction("wglDestroyDisplayColorTableEXT({0})", id);
			DebugCheckErrors(null);
		}

	}

}
