
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
		/// Binding for glColorMaskIndexedEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="g">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="a">
		/// A <see cref="T:bool"/>.
		/// </param>
		public static void ColorMaskIndexedEXT(UInt32 index, bool r, bool g, bool b, bool a)
		{
			Debug.Assert(Delegates.pglColorMaskIndexedEXT != null, "pglColorMaskIndexedEXT not implemented");
			Delegates.pglColorMaskIndexedEXT(index, r, g, b, a);
			CallLog("glColorMaskIndexedEXT({0}, {1}, {2}, {3}, {4})", index, r, g, b, a);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetBooleanIndexedvEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:bool[]"/>.
		/// </param>
		public static void GetBooleanIndexedEXT(int target, UInt32 index, bool[] data)
		{
			unsafe {
				fixed (bool* p_data = data)
				{
					Debug.Assert(Delegates.pglGetBooleanIndexedvEXT != null, "pglGetBooleanIndexedvEXT not implemented");
					Delegates.pglGetBooleanIndexedvEXT(target, index, p_data);
					CallLog("glGetBooleanIndexedvEXT({0}, {1}, {2})", target, index, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetIntegerIndexedvEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void GetIntegerIndexedEXT(int target, UInt32 index, Int32[] data)
		{
			unsafe {
				fixed (Int32* p_data = data)
				{
					Debug.Assert(Delegates.pglGetIntegerIndexedvEXT != null, "pglGetIntegerIndexedvEXT not implemented");
					Delegates.pglGetIntegerIndexedvEXT(target, index, p_data);
					CallLog("glGetIntegerIndexedvEXT({0}, {1}, {2})", target, index, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEnableIndexedEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void EnableIndexedEXT(int target, UInt32 index)
		{
			Debug.Assert(Delegates.pglEnableIndexedEXT != null, "pglEnableIndexedEXT not implemented");
			Delegates.pglEnableIndexedEXT(target, index);
			CallLog("glEnableIndexedEXT({0}, {1})", target, index);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDisableIndexedEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void DisableIndexedEXT(int target, UInt32 index)
		{
			Debug.Assert(Delegates.pglDisableIndexedEXT != null, "pglDisableIndexedEXT not implemented");
			Delegates.pglDisableIndexedEXT(target, index);
			CallLog("glDisableIndexedEXT({0}, {1})", target, index);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIsEnabledIndexedEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static bool IsEnabledIndexedEXT(int target, UInt32 index)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsEnabledIndexedEXT != null, "pglIsEnabledIndexedEXT not implemented");
			retValue = Delegates.pglIsEnabledIndexedEXT(target, index);
			CallLog("glIsEnabledIndexedEXT({0}, {1}) = {2}", target, index, retValue);
			DebugCheckErrors();

			return (retValue);
		}

	}

}
