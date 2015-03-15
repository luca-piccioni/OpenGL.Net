
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
		/// Value of GL_UNSIGNED_INT64_ARB symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT64_NV"]
		[RequiredByFeature("GL_ARB_bindless_texture")]
		public const int UNSIGNED_INT64_ARB = 0x140F;

		/// <summary>
		/// Binding for glGetTextureHandleARB.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture")]
		public static UInt64 GetTextureHandleARB(UInt32 texture)
		{
			UInt64 retValue;

			Debug.Assert(Delegates.pglGetTextureHandleARB != null, "pglGetTextureHandleARB not implemented");
			retValue = Delegates.pglGetTextureHandleARB(texture);
			CallLog("glGetTextureHandleARB({0}) = {1}", texture, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetTextureSamplerHandleARB.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture")]
		public static UInt64 GetTextureSamplerHandleARB(UInt32 texture, UInt32 sampler)
		{
			UInt64 retValue;

			Debug.Assert(Delegates.pglGetTextureSamplerHandleARB != null, "pglGetTextureSamplerHandleARB not implemented");
			retValue = Delegates.pglGetTextureSamplerHandleARB(texture, sampler);
			CallLog("glGetTextureSamplerHandleARB({0}, {1}) = {2}", texture, sampler, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glMakeTextureHandleResidentARB.
		/// </summary>
		/// <param name="handle">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture")]
		public static void MakeTextureHandleResidentARB(UInt64 handle)
		{
			Debug.Assert(Delegates.pglMakeTextureHandleResidentARB != null, "pglMakeTextureHandleResidentARB not implemented");
			Delegates.pglMakeTextureHandleResidentARB(handle);
			CallLog("glMakeTextureHandleResidentARB({0})", handle);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMakeTextureHandleNonResidentARB.
		/// </summary>
		/// <param name="handle">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture")]
		public static void MakeTextureHandleNonResidentARB(UInt64 handle)
		{
			Debug.Assert(Delegates.pglMakeTextureHandleNonResidentARB != null, "pglMakeTextureHandleNonResidentARB not implemented");
			Delegates.pglMakeTextureHandleNonResidentARB(handle);
			CallLog("glMakeTextureHandleNonResidentARB({0})", handle);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetImageHandleARB.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="layered">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="layer">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture")]
		public static UInt64 GetImageHandleARB(UInt32 texture, Int32 level, bool layered, Int32 layer, int format)
		{
			UInt64 retValue;

			Debug.Assert(Delegates.pglGetImageHandleARB != null, "pglGetImageHandleARB not implemented");
			retValue = Delegates.pglGetImageHandleARB(texture, level, layered, layer, format);
			CallLog("glGetImageHandleARB({0}, {1}, {2}, {3}, {4}) = {5}", texture, level, layered, layer, format, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glMakeImageHandleResidentARB.
		/// </summary>
		/// <param name="handle">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture")]
		public static void MakeImageHandleResidentARB(UInt64 handle, int access)
		{
			Debug.Assert(Delegates.pglMakeImageHandleResidentARB != null, "pglMakeImageHandleResidentARB not implemented");
			Delegates.pglMakeImageHandleResidentARB(handle, access);
			CallLog("glMakeImageHandleResidentARB({0}, {1})", handle, access);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMakeImageHandleNonResidentARB.
		/// </summary>
		/// <param name="handle">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture")]
		public static void MakeImageHandleNonResidentARB(UInt64 handle)
		{
			Debug.Assert(Delegates.pglMakeImageHandleNonResidentARB != null, "pglMakeImageHandleNonResidentARB not implemented");
			Delegates.pglMakeImageHandleNonResidentARB(handle);
			CallLog("glMakeImageHandleNonResidentARB({0})", handle);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniformHandleui64ARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture")]
		public static void UniformHandleARB(Int32 location, UInt64 value)
		{
			Debug.Assert(Delegates.pglUniformHandleui64ARB != null, "pglUniformHandleui64ARB not implemented");
			Delegates.pglUniformHandleui64ARB(location, value);
			CallLog("glUniformHandleui64ARB({0}, {1})", location, value);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniformHandleui64vARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture")]
		public static void UniformHandleARB(Int32 location, params UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformHandleui64vARB != null, "pglUniformHandleui64vARB not implemented");
					Delegates.pglUniformHandleui64vARB(location, (Int32)value.Length, p_value);
					CallLog("glUniformHandleui64vARB({0}, {1}, {2})", location, value.Length, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramUniformHandleui64ARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture")]
		public static void ProgramUniformHandleARB(UInt32 program, Int32 location, UInt64 value)
		{
			Debug.Assert(Delegates.pglProgramUniformHandleui64ARB != null, "pglProgramUniformHandleui64ARB not implemented");
			Delegates.pglProgramUniformHandleui64ARB(program, location, value);
			CallLog("glProgramUniformHandleui64ARB({0}, {1}, {2})", program, location, value);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramUniformHandleui64vARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture")]
		public static void ProgramUniformHandleARB(UInt32 program, Int32 location, params UInt64[] values)
		{
			unsafe {
				fixed (UInt64* p_values = values)
				{
					Debug.Assert(Delegates.pglProgramUniformHandleui64vARB != null, "pglProgramUniformHandleui64vARB not implemented");
					Delegates.pglProgramUniformHandleui64vARB(program, location, (Int32)values.Length, p_values);
					CallLog("glProgramUniformHandleui64vARB({0}, {1}, {2}, {3})", program, location, values.Length, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIsTextureHandleResidentARB.
		/// </summary>
		/// <param name="handle">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture")]
		public static bool IsTextureHandleResidentARB(UInt64 handle)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsTextureHandleResidentARB != null, "pglIsTextureHandleResidentARB not implemented");
			retValue = Delegates.pglIsTextureHandleResidentARB(handle);
			CallLog("glIsTextureHandleResidentARB({0}) = {1}", handle, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glIsImageHandleResidentARB.
		/// </summary>
		/// <param name="handle">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture")]
		public static bool IsImageHandleResidentARB(UInt64 handle)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsImageHandleResidentARB != null, "pglIsImageHandleResidentARB not implemented");
			retValue = Delegates.pglIsImageHandleResidentARB(handle);
			CallLog("glIsImageHandleResidentARB({0}) = {1}", handle, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glVertexAttribL1ui64ARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture")]
		public static void VertexAttribL1ARB(UInt32 index, UInt64 x)
		{
			Debug.Assert(Delegates.pglVertexAttribL1ui64ARB != null, "pglVertexAttribL1ui64ARB not implemented");
			Delegates.pglVertexAttribL1ui64ARB(index, x);
			CallLog("glVertexAttribL1ui64ARB({0}, {1})", index, x);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribL1ui64vARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture")]
		public static void VertexAttribL1ARB(UInt32 index, UInt64[] v)
		{
			unsafe {
				fixed (UInt64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL1ui64vARB != null, "pglVertexAttribL1ui64vARB not implemented");
					Delegates.pglVertexAttribL1ui64vARB(index, p_v);
					CallLog("glVertexAttribL1ui64vARB({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetVertexAttribLui64vARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture")]
		public static void GetVertexAttribLARB(UInt32 index, int pname, UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribLui64vARB != null, "pglGetVertexAttribLui64vARB not implemented");
					Delegates.pglGetVertexAttribLui64vARB(index, pname, p_params);
					CallLog("glGetVertexAttribLui64vARB({0}, {1}, {2})", index, pname, @params);
				}
			}
			DebugCheckErrors();
		}

	}

}
