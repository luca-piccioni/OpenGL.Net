
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
		/// Value of GL_VERTEX_ATTRIB_ARRAY_INTEGER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int VERTEX_ATTRIB_ARRAY_INTEGER_EXT = 0x88FD;

		/// <summary>
		/// Value of GL_SAMPLER_1D_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int SAMPLER_1D_ARRAY_EXT = 0x8DC0;

		/// <summary>
		/// Value of GL_SAMPLER_2D_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int SAMPLER_2D_ARRAY_EXT = 0x8DC1;

		/// <summary>
		/// Value of GL_SAMPLER_BUFFER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		[RequiredByFeature("GL_EXT_texture_buffer")]
		public const int SAMPLER_BUFFER_EXT = 0x8DC2;

		/// <summary>
		/// Value of GL_SAMPLER_1D_ARRAY_SHADOW_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int SAMPLER_1D_ARRAY_SHADOW_EXT = 0x8DC3;

		/// <summary>
		/// Value of GL_SAMPLER_2D_ARRAY_SHADOW_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int SAMPLER_2D_ARRAY_SHADOW_EXT = 0x8DC4;

		/// <summary>
		/// Value of GL_SAMPLER_CUBE_SHADOW_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int SAMPLER_CUBE_SHADOW_EXT = 0x8DC5;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_VEC2_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int UNSIGNED_INT_VEC2_EXT = 0x8DC6;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_VEC3_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int UNSIGNED_INT_VEC3_EXT = 0x8DC7;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_VEC4_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int UNSIGNED_INT_VEC4_EXT = 0x8DC8;

		/// <summary>
		/// Value of GL_INT_SAMPLER_1D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int INT_SAMPLER_1D_EXT = 0x8DC9;

		/// <summary>
		/// Value of GL_INT_SAMPLER_2D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int INT_SAMPLER_2D_EXT = 0x8DCA;

		/// <summary>
		/// Value of GL_INT_SAMPLER_3D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int INT_SAMPLER_3D_EXT = 0x8DCB;

		/// <summary>
		/// Value of GL_INT_SAMPLER_CUBE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int INT_SAMPLER_CUBE_EXT = 0x8DCC;

		/// <summary>
		/// Value of GL_INT_SAMPLER_2D_RECT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int INT_SAMPLER_2D_RECT_EXT = 0x8DCD;

		/// <summary>
		/// Value of GL_INT_SAMPLER_1D_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int INT_SAMPLER_1D_ARRAY_EXT = 0x8DCE;

		/// <summary>
		/// Value of GL_INT_SAMPLER_2D_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int INT_SAMPLER_2D_ARRAY_EXT = 0x8DCF;

		/// <summary>
		/// Value of GL_INT_SAMPLER_BUFFER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		[RequiredByFeature("GL_EXT_texture_buffer")]
		public const int INT_SAMPLER_BUFFER_EXT = 0x8DD0;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_1D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int UNSIGNED_INT_SAMPLER_1D_EXT = 0x8DD1;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_2D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int UNSIGNED_INT_SAMPLER_2D_EXT = 0x8DD2;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_3D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int UNSIGNED_INT_SAMPLER_3D_EXT = 0x8DD3;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_CUBE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int UNSIGNED_INT_SAMPLER_CUBE_EXT = 0x8DD4;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_2D_RECT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int UNSIGNED_INT_SAMPLER_2D_RECT_EXT = 0x8DD5;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_1D_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int UNSIGNED_INT_SAMPLER_1D_ARRAY_EXT = 0x8DD6;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_2D_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int UNSIGNED_INT_SAMPLER_2D_ARRAY_EXT = 0x8DD7;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_BUFFER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		[RequiredByFeature("GL_EXT_texture_buffer")]
		public const int UNSIGNED_INT_SAMPLER_BUFFER_EXT = 0x8DD8;

		/// <summary>
		/// Value of GL_MIN_PROGRAM_TEXEL_OFFSET_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int MIN_PROGRAM_TEXEL_OFFSET_EXT = 0x8904;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_TEXEL_OFFSET_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int MAX_PROGRAM_TEXEL_OFFSET_EXT = 0x8905;

		/// <summary>
		/// Binding for glGetUniformuivEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void GetUniformEXT(UInt32 program, Int32 location, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetUniformuivEXT != null, "pglGetUniformuivEXT not implemented");
					Delegates.pglGetUniformuivEXT(program, location, p_params);
					CallLog("glGetUniformuivEXT({0}, {1}, {2})", program, location, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBindFragDataLocationEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="color">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:String"/>.
		/// </param>
		public static void BindFragDataLocationEXT(UInt32 program, UInt32 color, String name)
		{
			Debug.Assert(Delegates.pglBindFragDataLocationEXT != null, "pglBindFragDataLocationEXT not implemented");
			Delegates.pglBindFragDataLocationEXT(program, color, name);
			CallLog("glBindFragDataLocationEXT({0}, {1}, {2})", program, color, name);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetFragDataLocationEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:String"/>.
		/// </param>
		public static Int32 GetFragDataLocationEXT(UInt32 program, String name)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetFragDataLocationEXT != null, "pglGetFragDataLocationEXT not implemented");
			retValue = Delegates.pglGetFragDataLocationEXT(program, name);
			CallLog("glGetFragDataLocationEXT({0}, {1}) = {2}", program, name, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glUniform1uiEXT.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v0">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void Uniform1EXT(Int32 location, UInt32 v0)
		{
			Debug.Assert(Delegates.pglUniform1uiEXT != null, "pglUniform1uiEXT not implemented");
			Delegates.pglUniform1uiEXT(location, v0);
			CallLog("glUniform1uiEXT({0}, {1})", location, v0);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform2uiEXT.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v0">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v1">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void Uniform2EXT(Int32 location, UInt32 v0, UInt32 v1)
		{
			Debug.Assert(Delegates.pglUniform2uiEXT != null, "pglUniform2uiEXT not implemented");
			Delegates.pglUniform2uiEXT(location, v0, v1);
			CallLog("glUniform2uiEXT({0}, {1}, {2})", location, v0, v1);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform3uiEXT.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v0">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v1">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void Uniform3EXT(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2)
		{
			Debug.Assert(Delegates.pglUniform3uiEXT != null, "pglUniform3uiEXT not implemented");
			Delegates.pglUniform3uiEXT(location, v0, v1, v2);
			CallLog("glUniform3uiEXT({0}, {1}, {2}, {3})", location, v0, v1, v2);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform4uiEXT.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v0">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v1">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v3">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void Uniform4EXT(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3)
		{
			Debug.Assert(Delegates.pglUniform4uiEXT != null, "pglUniform4uiEXT not implemented");
			Delegates.pglUniform4uiEXT(location, v0, v1, v2, v3);
			CallLog("glUniform4uiEXT({0}, {1}, {2}, {3}, {4})", location, v0, v1, v2, v3);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform1uivEXT.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void Uniform1EXT(Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform1uivEXT != null, "pglUniform1uivEXT not implemented");
					Delegates.pglUniform1uivEXT(location, count, p_value);
					CallLog("glUniform1uivEXT({0}, {1}, {2})", location, count, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform2uivEXT.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void Uniform2EXT(Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform2uivEXT != null, "pglUniform2uivEXT not implemented");
					Delegates.pglUniform2uivEXT(location, count, p_value);
					CallLog("glUniform2uivEXT({0}, {1}, {2})", location, count, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform3uivEXT.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void Uniform3EXT(Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform3uivEXT != null, "pglUniform3uivEXT not implemented");
					Delegates.pglUniform3uivEXT(location, count, p_value);
					CallLog("glUniform3uivEXT({0}, {1}, {2})", location, count, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform4uivEXT.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void Uniform4EXT(Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform4uivEXT != null, "pglUniform4uivEXT not implemented");
					Delegates.pglUniform4uivEXT(location, count, p_value);
					CallLog("glUniform4uivEXT({0}, {1}, {2})", location, count, value);
				}
			}
			DebugCheckErrors();
		}

	}

}
