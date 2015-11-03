
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

#pragma warning disable 1734

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_SPARSE_STORAGE_BIT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_sparse_buffer")]
		public const int SPARSE_STORAGE_BIT_ARB = 0x0400;

		/// <summary>
		/// Value of GL_SPARSE_BUFFER_PAGE_SIZE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_sparse_buffer")]
		public const int SPARSE_BUFFER_PAGE_SIZE_ARB = 0x82F8;

		/// <summary>
		/// Binding for glBufferPageCommitmentARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="commit">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_sparse_buffer")]
		public static void BufferPageCommitmentARB(Int32 target, IntPtr offset, UInt32 size, bool commit)
		{
			Debug.Assert(Delegates.pglBufferPageCommitmentARB != null, "pglBufferPageCommitmentARB not implemented");
			Delegates.pglBufferPageCommitmentARB(target, offset, size, commit);
			CallLog("glBufferPageCommitmentARB({0}, 0x{1}, {2}, {3})", target, offset.ToString("X8"), size, commit);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNamedBufferPageCommitmentEXT.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="commit">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_sparse_buffer")]
		public static void NamedBufferPageCommitmentEXT(UInt32 buffer, IntPtr offset, UInt32 size, bool commit)
		{
			Debug.Assert(Delegates.pglNamedBufferPageCommitmentEXT != null, "pglNamedBufferPageCommitmentEXT not implemented");
			Delegates.pglNamedBufferPageCommitmentEXT(buffer, offset, size, commit);
			CallLog("glNamedBufferPageCommitmentEXT({0}, 0x{1}, {2}, {3})", buffer, offset.ToString("X8"), size, commit);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNamedBufferPageCommitmentARB.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="commit">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_sparse_buffer")]
		public static void NamedBufferPageCommitmentARB(UInt32 buffer, IntPtr offset, UInt32 size, bool commit)
		{
			Debug.Assert(Delegates.pglNamedBufferPageCommitmentARB != null, "pglNamedBufferPageCommitmentARB not implemented");
			Delegates.pglNamedBufferPageCommitmentARB(buffer, offset, size, commit);
			CallLog("glNamedBufferPageCommitmentARB({0}, 0x{1}, {2}, {3})", buffer, offset.ToString("X8"), size, commit);
			DebugCheckErrors();
		}

	}

}
