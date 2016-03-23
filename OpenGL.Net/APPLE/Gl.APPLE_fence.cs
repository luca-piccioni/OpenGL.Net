
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
		/// <param name="fences">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static void GenFencesAPPLE(UInt32[] fences)
		{
			unsafe {
				fixed (UInt32* p_fences = fences)
				{
					Debug.Assert(Delegates.pglGenFencesAPPLE != null, "pglGenFencesAPPLE not implemented");
					Delegates.pglGenFencesAPPLE((Int32)fences.Length, p_fences);
					LogFunction("glGenFencesAPPLE({0}, {1})", fences.Length, LogValue(fences));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenFencesAPPLE.
		/// </summary>
		[RequiredByFeature("GL_APPLE_fence")]
		public static UInt32 GenFencesAPPLE()
		{
			UInt32[] retValue = new UInt32[1];
			GenFencesAPPLE(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// Binding for glDeleteFencesAPPLE.
		/// </summary>
		/// <param name="fences">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static void DeleteFencesAPPLE(params UInt32[] fences)
		{
			unsafe {
				fixed (UInt32* p_fences = fences)
				{
					Debug.Assert(Delegates.pglDeleteFencesAPPLE != null, "pglDeleteFencesAPPLE not implemented");
					Delegates.pglDeleteFencesAPPLE((Int32)fences.Length, p_fences);
					LogFunction("glDeleteFencesAPPLE({0}, {1})", fences.Length, LogValue(fences));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSetFenceAPPLE.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static void SetFenceAPPLE(UInt32 fence)
		{
			Debug.Assert(Delegates.pglSetFenceAPPLE != null, "pglSetFenceAPPLE not implemented");
			Delegates.pglSetFenceAPPLE(fence);
			LogFunction("glSetFenceAPPLE({0})", fence);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glIsFenceAPPLE.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static bool IsFenceAPPLE(UInt32 fence)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsFenceAPPLE != null, "pglIsFenceAPPLE not implemented");
			retValue = Delegates.pglIsFenceAPPLE(fence);
			LogFunction("glIsFenceAPPLE({0}) = {1}", fence, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glTestFenceAPPLE.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static bool TestFenceAPPLE(UInt32 fence)
		{
			bool retValue;

			Debug.Assert(Delegates.pglTestFenceAPPLE != null, "pglTestFenceAPPLE not implemented");
			retValue = Delegates.pglTestFenceAPPLE(fence);
			LogFunction("glTestFenceAPPLE({0}) = {1}", fence, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glFinishFenceAPPLE.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static void FinishFenceAPPLE(UInt32 fence)
		{
			Debug.Assert(Delegates.pglFinishFenceAPPLE != null, "pglFinishFenceAPPLE not implemented");
			Delegates.pglFinishFenceAPPLE(fence);
			LogFunction("glFinishFenceAPPLE({0})", fence);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTestObjectAPPLE.
		/// </summary>
		/// <param name="object">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static bool TestObjectAPPLE(Int32 @object, UInt32 name)
		{
			bool retValue;

			Debug.Assert(Delegates.pglTestObjectAPPLE != null, "pglTestObjectAPPLE not implemented");
			retValue = Delegates.pglTestObjectAPPLE(@object, name);
			LogFunction("glTestObjectAPPLE({0}, {1}) = {2}", LogEnumName(@object), name, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glFinishObjectAPPLE.
		/// </summary>
		/// <param name="object">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static void FinishObjectAPPLE(Int32 @object, Int32 name)
		{
			Debug.Assert(Delegates.pglFinishObjectAPPLE != null, "pglFinishObjectAPPLE not implemented");
			Delegates.pglFinishObjectAPPLE(@object, name);
			LogFunction("glFinishObjectAPPLE({0}, {1})", LogEnumName(@object), name);
			DebugCheckErrors(null);
		}

	}

}
