
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
		/// Value of GL_PARAMETER_BUFFER_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_indirect_parameters", Api = "gl|glcore")]
		public const int PARAMETER_BUFFER_ARB = 0x80EE;

		/// <summary>
		/// Value of GL_PARAMETER_BUFFER_BINDING_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_indirect_parameters", Api = "gl|glcore")]
		public const int PARAMETER_BUFFER_BINDING_ARB = 0x80EF;

		/// <summary>
		/// Binding for glMultiDrawArraysIndirectCountARB.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:Int32"/>.
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
		public static void MultiDrawArraysIndirectARB(Int32 mode, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride)
		{
			Debug.Assert(Delegates.pglMultiDrawArraysIndirectCountARB != null, "pglMultiDrawArraysIndirectCountARB not implemented");
			Delegates.pglMultiDrawArraysIndirectCountARB(mode, indirect, drawcount, maxdrawcount, stride);
			LogFunction("glMultiDrawArraysIndirectCountARB({0}, 0x{1}, 0x{2}, {3}, {4})", LogEnumName(mode), indirect.ToString("X8"), drawcount.ToString("X8"), maxdrawcount, stride);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiDrawElementsIndirectCountARB.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
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
		public static void MultiDrawElementsIndirectARB(Int32 mode, Int32 type, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride)
		{
			Debug.Assert(Delegates.pglMultiDrawElementsIndirectCountARB != null, "pglMultiDrawElementsIndirectCountARB not implemented");
			Delegates.pglMultiDrawElementsIndirectCountARB(mode, type, indirect, drawcount, maxdrawcount, stride);
			LogFunction("glMultiDrawElementsIndirectCountARB({0}, {1}, 0x{2}, 0x{3}, {4}, {5})", LogEnumName(mode), LogEnumName(type), indirect.ToString("X8"), drawcount.ToString("X8"), maxdrawcount, stride);
			DebugCheckErrors(null);
		}

	}

}
