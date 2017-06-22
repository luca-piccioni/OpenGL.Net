
// Copyright (C) 2015-2017 Luca Piccioni
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
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_MAX_COMPUTE_VARIABLE_GROUP_INVOCATIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_compute_variable_group_size", Api = "gl|glcore")]
		public const int MAX_COMPUTE_VARIABLE_GROUP_INVOCATIONS_ARB = 0x9344;

		/// <summary>
		/// [GL] Value of GL_MAX_COMPUTE_VARIABLE_GROUP_SIZE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_compute_variable_group_size", Api = "gl|glcore")]
		public const int MAX_COMPUTE_VARIABLE_GROUP_SIZE_ARB = 0x9345;

		/// <summary>
		/// [GL] Binding for glDispatchComputeGroupSizeARB.
		/// </summary>
		/// <param name="num_groups_x">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="num_groups_y">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="num_groups_z">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="group_size_x">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="group_size_y">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="group_size_z">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_compute_variable_group_size", Api = "gl|glcore")]
		public static void DispatchComputeGroupSizeARB(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z, UInt32 group_size_x, UInt32 group_size_y, UInt32 group_size_z)
		{
			Debug.Assert(Delegates.pglDispatchComputeGroupSizeARB != null, "pglDispatchComputeGroupSizeARB not implemented");
			Delegates.pglDispatchComputeGroupSizeARB(num_groups_x, num_groups_y, num_groups_z, group_size_x, group_size_y, group_size_z);
			LogCommand("glDispatchComputeGroupSizeARB", null, num_groups_x, num_groups_y, num_groups_z, group_size_x, group_size_y, group_size_z			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDispatchComputeGroupSizeARB", ExactSpelling = true)]
			internal extern static void glDispatchComputeGroupSizeARB(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z, UInt32 group_size_x, UInt32 group_size_y, UInt32 group_size_z);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ARB_compute_variable_group_size", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDispatchComputeGroupSizeARB(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z, UInt32 group_size_x, UInt32 group_size_y, UInt32 group_size_z);

			[RequiredByFeature("GL_ARB_compute_variable_group_size", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glDispatchComputeGroupSizeARB pglDispatchComputeGroupSizeARB;

		}
	}

}
