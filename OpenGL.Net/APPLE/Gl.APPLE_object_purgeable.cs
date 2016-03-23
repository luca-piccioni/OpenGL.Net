
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
		/// Value of GL_BUFFER_OBJECT_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_object_purgeable")]
		public const int BUFFER_OBJECT_APPLE = 0x85B3;

		/// <summary>
		/// Value of GL_RELEASED_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_object_purgeable")]
		public const int RELEASED_APPLE = 0x8A19;

		/// <summary>
		/// Value of GL_VOLATILE_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_object_purgeable")]
		public const int VOLATILE_APPLE = 0x8A1A;

		/// <summary>
		/// Value of GL_RETAINED_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_object_purgeable")]
		public const int RETAINED_APPLE = 0x8A1B;

		/// <summary>
		/// Value of GL_UNDEFINED_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_object_purgeable")]
		public const int UNDEFINED_APPLE = 0x8A1C;

		/// <summary>
		/// Value of GL_PURGEABLE_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_object_purgeable")]
		public const int PURGEABLE_APPLE = 0x8A1D;

		/// <summary>
		/// Binding for glObjectPurgeableAPPLE.
		/// </summary>
		/// <param name="objectType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="option">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_object_purgeable")]
		public static Int32 ObjectPurgeableAPPLE(Int32 objectType, UInt32 name, Int32 option)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglObjectPurgeableAPPLE != null, "pglObjectPurgeableAPPLE not implemented");
			retValue = Delegates.pglObjectPurgeableAPPLE(objectType, name, option);
			LogFunction("glObjectPurgeableAPPLE({0}, {1}, {2}) = {3}", LogEnumName(objectType), name, LogEnumName(option), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glObjectUnpurgeableAPPLE.
		/// </summary>
		/// <param name="objectType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="option">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_object_purgeable")]
		public static Int32 ObjectUnpurgeableAPPLE(Int32 objectType, UInt32 name, Int32 option)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglObjectUnpurgeableAPPLE != null, "pglObjectUnpurgeableAPPLE not implemented");
			retValue = Delegates.pglObjectUnpurgeableAPPLE(objectType, name, option);
			LogFunction("glObjectUnpurgeableAPPLE({0}, {1}, {2}) = {3}", LogEnumName(objectType), name, LogEnumName(option), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetObjectParameterivAPPLE.
		/// </summary>
		/// <param name="objectType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_object_purgeable")]
		public static void GetObjectParameterAPPLE(Int32 objectType, UInt32 name, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetObjectParameterivAPPLE != null, "pglGetObjectParameterivAPPLE not implemented");
					Delegates.pglGetObjectParameterivAPPLE(objectType, name, pname, p_params);
					LogFunction("glGetObjectParameterivAPPLE({0}, {1}, {2}, {3})", LogEnumName(objectType), name, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
