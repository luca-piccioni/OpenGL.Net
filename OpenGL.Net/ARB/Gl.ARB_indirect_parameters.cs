
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
		/// [GL] Value of GL_PARAMETER_BUFFER_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_indirect_parameters", Api = "gl|glcore")]
		public const int PARAMETER_BUFFER_ARB = 0x80EE;

		/// <summary>
		/// [GL] Value of GL_PARAMETER_BUFFER_BINDING_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_indirect_parameters", Api = "gl|glcore")]
		public const int PARAMETER_BUFFER_BINDING_ARB = 0x80EF;

		/// <summary>
		/// Binding for glMultiDrawArraysIndirectCountARB.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawcount">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="maxdrawcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_indirect_parameters", Api = "gl|glcore")]
		public static void MultiDrawArraysIndirectARB(PrimitiveType mode, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride)
		{
			Debug.Assert(Delegates.pglMultiDrawArraysIndirectCountARB != null, "pglMultiDrawArraysIndirectCountARB not implemented");
			Delegates.pglMultiDrawArraysIndirectCountARB((Int32)mode, indirect, drawcount, maxdrawcount, stride);
			LogCommand("glMultiDrawArraysIndirectCountARB", null, mode, indirect, drawcount, maxdrawcount, stride			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiDrawElementsIndirectCountARB.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:DrawElementsType"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawcount">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="maxdrawcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_indirect_parameters", Api = "gl|glcore")]
		public static void MultiDrawElementsIndirectARB(PrimitiveType mode, DrawElementsType type, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride)
		{
			Debug.Assert(Delegates.pglMultiDrawElementsIndirectCountARB != null, "pglMultiDrawElementsIndirectCountARB not implemented");
			Delegates.pglMultiDrawElementsIndirectCountARB((Int32)mode, (Int32)type, indirect, drawcount, maxdrawcount, stride);
			LogCommand("glMultiDrawElementsIndirectCountARB", null, mode, type, indirect, drawcount, maxdrawcount, stride			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiDrawArraysIndirectCountARB", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawArraysIndirectCountARB(Int32 mode, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiDrawElementsIndirectCountARB", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawElementsIndirectCountARB(Int32 mode, Int32 type, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ARB_indirect_parameters", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiDrawArraysIndirectCountARB(Int32 mode, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride);

			[RequiredByFeature("GL_ARB_indirect_parameters", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glMultiDrawArraysIndirectCountARB pglMultiDrawArraysIndirectCountARB;

			[RequiredByFeature("GL_ARB_indirect_parameters", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiDrawElementsIndirectCountARB(Int32 mode, Int32 type, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride);

			[RequiredByFeature("GL_ARB_indirect_parameters", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glMultiDrawElementsIndirectCountARB pglMultiDrawElementsIndirectCountARB;

		}
	}

}
