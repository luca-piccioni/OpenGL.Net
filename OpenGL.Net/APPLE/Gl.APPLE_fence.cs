
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
		/// Value of GL_DRAW_PIXELS_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_fence")]
		public const int DRAW_PIXELS_APPLE = 0x8A0A;

		/// <summary>
		/// Value of GL_FENCE_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_fence")]
		public const int FENCE_APPLE = 0x8A0B;

		/// <summary>
		/// Binding for glGenFencesAPPLE.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fences">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void GenFencesAPPLE(Int32 n, UInt32[] fences)
		{
			unsafe {
				fixed (UInt32* p_fences = fences)
				{
					Debug.Assert(Delegates.pglGenFencesAPPLE != null, "pglGenFencesAPPLE not implemented");
					Delegates.pglGenFencesAPPLE(n, p_fences);
					CallLog("glGenFencesAPPLE({0}, {1})", n, fences);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteFencesAPPLE.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fences">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void DeleteFencesAPPLE(Int32 n, UInt32[] fences)
		{
			unsafe {
				fixed (UInt32* p_fences = fences)
				{
					Debug.Assert(Delegates.pglDeleteFencesAPPLE != null, "pglDeleteFencesAPPLE not implemented");
					Delegates.pglDeleteFencesAPPLE(n, p_fences);
					CallLog("glDeleteFencesAPPLE({0}, {1})", n, fences);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSetFenceAPPLE.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void SetFenceAPPLE(UInt32 fence)
		{
			Debug.Assert(Delegates.pglSetFenceAPPLE != null, "pglSetFenceAPPLE not implemented");
			Delegates.pglSetFenceAPPLE(fence);
			CallLog("glSetFenceAPPLE({0})", fence);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIsFenceAPPLE.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static bool IsFenceAPPLE(UInt32 fence)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsFenceAPPLE != null, "pglIsFenceAPPLE not implemented");
			retValue = Delegates.pglIsFenceAPPLE(fence);
			CallLog("glIsFenceAPPLE({0}) = {1}", fence, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glTestFenceAPPLE.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static bool TestFenceAPPLE(UInt32 fence)
		{
			bool retValue;

			Debug.Assert(Delegates.pglTestFenceAPPLE != null, "pglTestFenceAPPLE not implemented");
			retValue = Delegates.pglTestFenceAPPLE(fence);
			CallLog("glTestFenceAPPLE({0}) = {1}", fence, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glFinishFenceAPPLE.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void FinishFenceAPPLE(UInt32 fence)
		{
			Debug.Assert(Delegates.pglFinishFenceAPPLE != null, "pglFinishFenceAPPLE not implemented");
			Delegates.pglFinishFenceAPPLE(fence);
			CallLog("glFinishFenceAPPLE({0})", fence);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTestObjectAPPLE.
		/// </summary>
		/// <param name="object">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static bool TestObjectAPPLE(int @object, UInt32 name)
		{
			bool retValue;

			Debug.Assert(Delegates.pglTestObjectAPPLE != null, "pglTestObjectAPPLE not implemented");
			retValue = Delegates.pglTestObjectAPPLE(@object, name);
			CallLog("glTestObjectAPPLE({0}, {1}) = {2}", @object, name, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glFinishObjectAPPLE.
		/// </summary>
		/// <param name="object">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void FinishObjectAPPLE(int @object, Int32 name)
		{
			Debug.Assert(Delegates.pglFinishObjectAPPLE != null, "pglFinishObjectAPPLE not implemented");
			Delegates.pglFinishObjectAPPLE(@object, name);
			CallLog("glFinishObjectAPPLE({0}, {1})", @object, name);
			DebugCheckErrors();
		}

	}

}
