
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
		/// Value of GL_ALL_COMPLETED_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
		public const int ALL_COMPLETED_NV = 0x84F2;

		/// <summary>
		/// Value of GL_FENCE_STATUS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
		public const int FENCE_STATUS_NV = 0x84F3;

		/// <summary>
		/// Value of GL_FENCE_CONDITION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
		public const int FENCE_CONDITION_NV = 0x84F4;

		/// <summary>
		/// Binding for glDeleteFencesNV.
		/// </summary>
		/// <param name="fences">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
		public static void DeleteFencesNV(params UInt32[] fences)
		{
			unsafe {
				fixed (UInt32* p_fences = fences)
				{
					Debug.Assert(Delegates.pglDeleteFencesNV != null, "pglDeleteFencesNV not implemented");
					Delegates.pglDeleteFencesNV((Int32)fences.Length, p_fences);
					LogFunction("glDeleteFencesNV({0}, {1})", fences.Length, LogValue(fences));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenFencesNV.
		/// </summary>
		/// <param name="fences">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
		public static void GenFencesNV(UInt32[] fences)
		{
			unsafe {
				fixed (UInt32* p_fences = fences)
				{
					Debug.Assert(Delegates.pglGenFencesNV != null, "pglGenFencesNV not implemented");
					Delegates.pglGenFencesNV((Int32)fences.Length, p_fences);
					LogFunction("glGenFencesNV({0}, {1})", fences.Length, LogValue(fences));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenFencesNV.
		/// </summary>
		[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
		public static UInt32 GenFencesNV()
		{
			UInt32[] retValue = new UInt32[1];
			GenFencesNV(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// Binding for glIsFenceNV.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
		public static bool IsFenceNV(UInt32 fence)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsFenceNV != null, "pglIsFenceNV not implemented");
			retValue = Delegates.pglIsFenceNV(fence);
			LogFunction("glIsFenceNV({0}) = {1}", fence, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glTestFenceNV.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
		public static bool TestFenceNV(UInt32 fence)
		{
			bool retValue;

			Debug.Assert(Delegates.pglTestFenceNV != null, "pglTestFenceNV not implemented");
			retValue = Delegates.pglTestFenceNV(fence);
			LogFunction("glTestFenceNV({0}) = {1}", fence, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetFenceivNV.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
		public static void GetFenceNV(UInt32 fence, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFenceivNV != null, "pglGetFenceivNV not implemented");
					Delegates.pglGetFenceivNV(fence, pname, p_params);
					LogFunction("glGetFenceivNV({0}, {1}, {2})", fence, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFinishFenceNV.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
		public static void FinishFenceNV(UInt32 fence)
		{
			Debug.Assert(Delegates.pglFinishFenceNV != null, "pglFinishFenceNV not implemented");
			Delegates.pglFinishFenceNV(fence);
			LogFunction("glFinishFenceNV({0})", fence);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSetFenceNV.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="condition">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
		public static void SetFenceNV(UInt32 fence, Int32 condition)
		{
			Debug.Assert(Delegates.pglSetFenceNV != null, "pglSetFenceNV not implemented");
			Delegates.pglSetFenceNV(fence, condition);
			LogFunction("glSetFenceNV({0}, {1})", fence, LogEnumName(condition));
			DebugCheckErrors(null);
		}

	}

}
