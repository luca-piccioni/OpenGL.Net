
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
		/// Value of GL_DATA_BUFFER_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_name_gen_delete")]
		public const int DATA_BUFFER_AMD = 0x9151;

		/// <summary>
		/// Value of GL_PERFORMANCE_MONITOR_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_name_gen_delete")]
		public const int PERFORMANCE_MONITOR_AMD = 0x9152;

		/// <summary>
		/// Value of GL_SAMPLER_OBJECT_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_name_gen_delete")]
		public const int SAMPLER_OBJECT_AMD = 0x9155;

		/// <summary>
		/// Binding for glGenNamesAMD.
		/// </summary>
		/// <param name="identifier">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="names">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_name_gen_delete")]
		public static void GenNameAMD(Int32 identifier, UInt32[] names)
		{
			unsafe {
				fixed (UInt32* p_names = names)
				{
					Debug.Assert(Delegates.pglGenNamesAMD != null, "pglGenNamesAMD not implemented");
					Delegates.pglGenNamesAMD(identifier, (UInt32)names.Length, p_names);
					LogFunction("glGenNamesAMD({0}, {1}, {2})", LogEnumName(identifier), names.Length, LogValue(names));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenNamesAMD.
		/// </summary>
		/// <param name="identifier">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_name_gen_delete")]
		public static UInt32 GenNameAMD(Int32 identifier)
		{
			UInt32[] retValue = new UInt32[1];
			GenNameAMD(identifier, retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// Binding for glDeleteNamesAMD.
		/// </summary>
		/// <param name="identifier">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="names">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_name_gen_delete")]
		public static void DeleteNameAMD(Int32 identifier, UInt32[] names)
		{
			unsafe {
				fixed (UInt32* p_names = names)
				{
					Debug.Assert(Delegates.pglDeleteNamesAMD != null, "pglDeleteNamesAMD not implemented");
					Delegates.pglDeleteNamesAMD(identifier, (UInt32)names.Length, p_names);
					LogFunction("glDeleteNamesAMD({0}, {1}, {2})", LogEnumName(identifier), names.Length, LogValue(names));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glIsNameAMD.
		/// </summary>
		/// <param name="identifier">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_name_gen_delete")]
		public static bool IsNameAMD(Int32 identifier, UInt32 name)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsNameAMD != null, "pglIsNameAMD not implemented");
			retValue = Delegates.pglIsNameAMD(identifier, name);
			LogFunction("glIsNameAMD({0}, {1}) = {2}", LogEnumName(identifier), name, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
