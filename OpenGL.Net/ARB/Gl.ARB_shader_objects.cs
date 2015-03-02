
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
		/// Value of GL_PROGRAM_OBJECT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int PROGRAM_OBJECT_ARB = 0x8B40;

		/// <summary>
		/// Value of GL_SHADER_OBJECT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int SHADER_OBJECT_ARB = 0x8B48;

		/// <summary>
		/// Value of GL_OBJECT_TYPE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int OBJECT_TYPE_ARB = 0x8B4E;

		/// <summary>
		/// Value of GL_OBJECT_SUBTYPE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int OBJECT_SUBTYPE_ARB = 0x8B4F;

		/// <summary>
		/// Value of GL_FLOAT_VEC2_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int FLOAT_VEC2_ARB = 0x8B50;

		/// <summary>
		/// Value of GL_FLOAT_VEC3_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int FLOAT_VEC3_ARB = 0x8B51;

		/// <summary>
		/// Value of GL_FLOAT_VEC4_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int FLOAT_VEC4_ARB = 0x8B52;

		/// <summary>
		/// Value of GL_INT_VEC2_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int INT_VEC2_ARB = 0x8B53;

		/// <summary>
		/// Value of GL_INT_VEC3_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int INT_VEC3_ARB = 0x8B54;

		/// <summary>
		/// Value of GL_INT_VEC4_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int INT_VEC4_ARB = 0x8B55;

		/// <summary>
		/// Value of GL_BOOL_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int BOOL_ARB = 0x8B56;

		/// <summary>
		/// Value of GL_BOOL_VEC2_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int BOOL_VEC2_ARB = 0x8B57;

		/// <summary>
		/// Value of GL_BOOL_VEC3_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int BOOL_VEC3_ARB = 0x8B58;

		/// <summary>
		/// Value of GL_BOOL_VEC4_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int BOOL_VEC4_ARB = 0x8B59;

		/// <summary>
		/// Value of GL_FLOAT_MAT2_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int FLOAT_MAT2_ARB = 0x8B5A;

		/// <summary>
		/// Value of GL_FLOAT_MAT3_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int FLOAT_MAT3_ARB = 0x8B5B;

		/// <summary>
		/// Value of GL_FLOAT_MAT4_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int FLOAT_MAT4_ARB = 0x8B5C;

		/// <summary>
		/// Value of GL_SAMPLER_1D_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int SAMPLER_1D_ARB = 0x8B5D;

		/// <summary>
		/// Value of GL_SAMPLER_2D_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int SAMPLER_2D_ARB = 0x8B5E;

		/// <summary>
		/// Value of GL_SAMPLER_3D_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int SAMPLER_3D_ARB = 0x8B5F;

		/// <summary>
		/// Value of GL_SAMPLER_CUBE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int SAMPLER_CUBE_ARB = 0x8B60;

		/// <summary>
		/// Value of GL_SAMPLER_1D_SHADOW_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int SAMPLER_1D_SHADOW_ARB = 0x8B61;

		/// <summary>
		/// Value of GL_SAMPLER_2D_SHADOW_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int SAMPLER_2D_SHADOW_ARB = 0x8B62;

		/// <summary>
		/// Value of GL_SAMPLER_2D_RECT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int SAMPLER_2D_RECT_ARB = 0x8B63;

		/// <summary>
		/// Value of GL_SAMPLER_2D_RECT_SHADOW_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int SAMPLER_2D_RECT_SHADOW_ARB = 0x8B64;

		/// <summary>
		/// Value of GL_OBJECT_DELETE_STATUS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int OBJECT_DELETE_STATUS_ARB = 0x8B80;

		/// <summary>
		/// Value of GL_OBJECT_COMPILE_STATUS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int OBJECT_COMPILE_STATUS_ARB = 0x8B81;

		/// <summary>
		/// Value of GL_OBJECT_LINK_STATUS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int OBJECT_LINK_STATUS_ARB = 0x8B82;

		/// <summary>
		/// Value of GL_OBJECT_VALIDATE_STATUS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int OBJECT_VALIDATE_STATUS_ARB = 0x8B83;

		/// <summary>
		/// Value of GL_OBJECT_INFO_LOG_LENGTH_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int OBJECT_INFO_LOG_LENGTH_ARB = 0x8B84;

		/// <summary>
		/// Value of GL_OBJECT_ATTACHED_OBJECTS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int OBJECT_ATTACHED_OBJECTS_ARB = 0x8B85;

		/// <summary>
		/// Value of GL_OBJECT_ACTIVE_UNIFORMS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int OBJECT_ACTIVE_UNIFORMS_ARB = 0x8B86;

		/// <summary>
		/// Value of GL_OBJECT_ACTIVE_UNIFORM_MAX_LENGTH_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int OBJECT_ACTIVE_UNIFORM_MAX_LENGTH_ARB = 0x8B87;

		/// <summary>
		/// Value of GL_OBJECT_SHADER_SOURCE_LENGTH_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int OBJECT_SHADER_SOURCE_LENGTH_ARB = 0x8B88;

		/// <summary>
		/// Binding for glDeleteObjectARB.
		/// </summary>
		/// <param name="obj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void DeleteObjectARB(UInt32 obj)
		{
			Debug.Assert(Delegates.pglDeleteObjectARB != null, "pglDeleteObjectARB not implemented");
			Delegates.pglDeleteObjectARB(obj);
			CallLog("glDeleteObjectARB({0})", obj);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetHandleARB.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		public static UInt32 GetHandleARB(int pname)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglGetHandleARB != null, "pglGetHandleARB not implemented");
			retValue = Delegates.pglGetHandleARB(pname);
			CallLog("glGetHandleARB({0}) = {1}", pname, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glDetachObjectARB.
		/// </summary>
		/// <param name="containerObj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="attachedObj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void DetachObjectARB(UInt32 containerObj, UInt32 attachedObj)
		{
			Debug.Assert(Delegates.pglDetachObjectARB != null, "pglDetachObjectARB not implemented");
			Delegates.pglDetachObjectARB(containerObj, attachedObj);
			CallLog("glDetachObjectARB({0}, {1})", containerObj, attachedObj);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCreateShaderObjectARB.
		/// </summary>
		/// <param name="shaderType">
		/// A <see cref="T:int"/>.
		/// </param>
		public static UInt32 CreateShaderObjectARB(int shaderType)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglCreateShaderObjectARB != null, "pglCreateShaderObjectARB not implemented");
			retValue = Delegates.pglCreateShaderObjectARB(shaderType);
			CallLog("glCreateShaderObjectARB({0}) = {1}", shaderType, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glShaderSourceARB.
		/// </summary>
		/// <param name="shaderObj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:String[]"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void ShaderSourceARB(UInt32 shaderObj, Int32 count, String[] @string, Int32[] length)
		{
			unsafe {
				fixed (Int32* p_length = length)
				{
					Debug.Assert(Delegates.pglShaderSourceARB != null, "pglShaderSourceARB not implemented");
					Delegates.pglShaderSourceARB(shaderObj, count, @string, p_length);
					CallLog("glShaderSourceARB({0}, {1}, {2}, {3})", shaderObj, count, @string, length);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCompileShaderARB.
		/// </summary>
		/// <param name="shaderObj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void CompileShaderARB(UInt32 shaderObj)
		{
			Debug.Assert(Delegates.pglCompileShaderARB != null, "pglCompileShaderARB not implemented");
			Delegates.pglCompileShaderARB(shaderObj);
			CallLog("glCompileShaderARB({0})", shaderObj);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCreateProgramObjectARB.
		/// </summary>
		public static UInt32 CreateProgramObjectARB()
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglCreateProgramObjectARB != null, "pglCreateProgramObjectARB not implemented");
			retValue = Delegates.pglCreateProgramObjectARB();
			CallLog("glCreateProgramObjectARB() = {0}", retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glAttachObjectARB.
		/// </summary>
		/// <param name="containerObj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="obj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void AttachObjectARB(UInt32 containerObj, UInt32 obj)
		{
			Debug.Assert(Delegates.pglAttachObjectARB != null, "pglAttachObjectARB not implemented");
			Delegates.pglAttachObjectARB(containerObj, obj);
			CallLog("glAttachObjectARB({0}, {1})", containerObj, obj);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLinkProgramARB.
		/// </summary>
		/// <param name="programObj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void LinkProgramARB(UInt32 programObj)
		{
			Debug.Assert(Delegates.pglLinkProgramARB != null, "pglLinkProgramARB not implemented");
			Delegates.pglLinkProgramARB(programObj);
			CallLog("glLinkProgramARB({0})", programObj);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUseProgramObjectARB.
		/// </summary>
		/// <param name="programObj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void UseProgramObjectARB(UInt32 programObj)
		{
			Debug.Assert(Delegates.pglUseProgramObjectARB != null, "pglUseProgramObjectARB not implemented");
			Delegates.pglUseProgramObjectARB(programObj);
			CallLog("glUseProgramObjectARB({0})", programObj);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glValidateProgramARB.
		/// </summary>
		/// <param name="programObj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void ValidateProgramARB(UInt32 programObj)
		{
			Debug.Assert(Delegates.pglValidateProgramARB != null, "pglValidateProgramARB not implemented");
			Delegates.pglValidateProgramARB(programObj);
			CallLog("glValidateProgramARB({0})", programObj);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform1fARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v0">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void Uniform1ARB(Int32 location, float v0)
		{
			Debug.Assert(Delegates.pglUniform1fARB != null, "pglUniform1fARB not implemented");
			Delegates.pglUniform1fARB(location, v0);
			CallLog("glUniform1fARB({0}, {1})", location, v0);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform2fARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v0">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="v1">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void Uniform2ARB(Int32 location, float v0, float v1)
		{
			Debug.Assert(Delegates.pglUniform2fARB != null, "pglUniform2fARB not implemented");
			Delegates.pglUniform2fARB(location, v0, v1);
			CallLog("glUniform2fARB({0}, {1}, {2})", location, v0, v1);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform3fARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v0">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="v1">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void Uniform3ARB(Int32 location, float v0, float v1, float v2)
		{
			Debug.Assert(Delegates.pglUniform3fARB != null, "pglUniform3fARB not implemented");
			Delegates.pglUniform3fARB(location, v0, v1, v2);
			CallLog("glUniform3fARB({0}, {1}, {2}, {3})", location, v0, v1, v2);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform4fARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v0">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="v1">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="v3">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void Uniform4ARB(Int32 location, float v0, float v1, float v2, float v3)
		{
			Debug.Assert(Delegates.pglUniform4fARB != null, "pglUniform4fARB not implemented");
			Delegates.pglUniform4fARB(location, v0, v1, v2, v3);
			CallLog("glUniform4fARB({0}, {1}, {2}, {3}, {4})", location, v0, v1, v2, v3);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform1iARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void Uniform1ARB(Int32 location, Int32 v0)
		{
			Debug.Assert(Delegates.pglUniform1iARB != null, "pglUniform1iARB not implemented");
			Delegates.pglUniform1iARB(location, v0);
			CallLog("glUniform1iARB({0}, {1})", location, v0);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform2iARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void Uniform2ARB(Int32 location, Int32 v0, Int32 v1)
		{
			Debug.Assert(Delegates.pglUniform2iARB != null, "pglUniform2iARB not implemented");
			Delegates.pglUniform2iARB(location, v0, v1);
			CallLog("glUniform2iARB({0}, {1}, {2})", location, v0, v1);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform3iARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void Uniform3ARB(Int32 location, Int32 v0, Int32 v1, Int32 v2)
		{
			Debug.Assert(Delegates.pglUniform3iARB != null, "pglUniform3iARB not implemented");
			Delegates.pglUniform3iARB(location, v0, v1, v2);
			CallLog("glUniform3iARB({0}, {1}, {2}, {3})", location, v0, v1, v2);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform4iARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v3">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void Uniform4ARB(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3)
		{
			Debug.Assert(Delegates.pglUniform4iARB != null, "pglUniform4iARB not implemented");
			Delegates.pglUniform4iARB(location, v0, v1, v2, v3);
			CallLog("glUniform4iARB({0}, {1}, {2}, {3}, {4})", location, v0, v1, v2, v3);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform1fvARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void Uniform1ARB(Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform1fvARB != null, "pglUniform1fvARB not implemented");
					Delegates.pglUniform1fvARB(location, count, p_value);
					CallLog("glUniform1fvARB({0}, {1}, {2})", location, count, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform2fvARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void Uniform2ARB(Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform2fvARB != null, "pglUniform2fvARB not implemented");
					Delegates.pglUniform2fvARB(location, count, p_value);
					CallLog("glUniform2fvARB({0}, {1}, {2})", location, count, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform3fvARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void Uniform3ARB(Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform3fvARB != null, "pglUniform3fvARB not implemented");
					Delegates.pglUniform3fvARB(location, count, p_value);
					CallLog("glUniform3fvARB({0}, {1}, {2})", location, count, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform4fvARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void Uniform4ARB(Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform4fvARB != null, "pglUniform4fvARB not implemented");
					Delegates.pglUniform4fvARB(location, count, p_value);
					CallLog("glUniform4fvARB({0}, {1}, {2})", location, count, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform1ivARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void Uniform1ARB(Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform1ivARB != null, "pglUniform1ivARB not implemented");
					Delegates.pglUniform1ivARB(location, count, p_value);
					CallLog("glUniform1ivARB({0}, {1}, {2})", location, count, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform2ivARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void Uniform2ARB(Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform2ivARB != null, "pglUniform2ivARB not implemented");
					Delegates.pglUniform2ivARB(location, count, p_value);
					CallLog("glUniform2ivARB({0}, {1}, {2})", location, count, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform3ivARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void Uniform3ARB(Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform3ivARB != null, "pglUniform3ivARB not implemented");
					Delegates.pglUniform3ivARB(location, count, p_value);
					CallLog("glUniform3ivARB({0}, {1}, {2})", location, count, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniform4ivARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void Uniform4ARB(Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform4ivARB != null, "pglUniform4ivARB not implemented");
					Delegates.pglUniform4ivARB(location, count, p_value);
					CallLog("glUniform4ivARB({0}, {1}, {2})", location, count, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniformMatrix2fvARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void UniformMatrix2ARB(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix2fvARB != null, "pglUniformMatrix2fvARB not implemented");
					Delegates.pglUniformMatrix2fvARB(location, count, transpose, p_value);
					CallLog("glUniformMatrix2fvARB({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniformMatrix3fvARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void UniformMatrix3ARB(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix3fvARB != null, "pglUniformMatrix3fvARB not implemented");
					Delegates.pglUniformMatrix3fvARB(location, count, transpose, p_value);
					CallLog("glUniformMatrix3fvARB({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniformMatrix4fvARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void UniformMatrix4ARB(Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformMatrix4fvARB != null, "pglUniformMatrix4fvARB not implemented");
					Delegates.pglUniformMatrix4fvARB(location, count, transpose, p_value);
					CallLog("glUniformMatrix4fvARB({0}, {1}, {2}, {3})", location, count, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetObjectParameterfvARB.
		/// </summary>
		/// <param name="obj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void GetObjectParameterARB(UInt32 obj, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetObjectParameterfvARB != null, "pglGetObjectParameterfvARB not implemented");
					Delegates.pglGetObjectParameterfvARB(obj, pname, p_params);
					CallLog("glGetObjectParameterfvARB({0}, {1}, {2})", obj, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetObjectParameterivARB.
		/// </summary>
		/// <param name="obj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void GetObjectParameterARB(UInt32 obj, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetObjectParameterivARB != null, "pglGetObjectParameterivARB not implemented");
					Delegates.pglGetObjectParameterivARB(obj, pname, p_params);
					CallLog("glGetObjectParameterivARB({0}, {1}, {2})", obj, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetInfoLogARB.
		/// </summary>
		/// <param name="obj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="maxLength">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="infoLog">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		public static void GetInfoLogARB(UInt32 obj, Int32 maxLength, out Int32 length, [Out] StringBuilder infoLog)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetInfoLogARB != null, "pglGetInfoLogARB not implemented");
					Delegates.pglGetInfoLogARB(obj, maxLength, p_length, infoLog);
					CallLog("glGetInfoLogARB({0}, {1}, {2}, {3})", obj, maxLength, length, infoLog);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetAttachedObjectsARB.
		/// </summary>
		/// <param name="containerObj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="maxCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="obj">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void GetAttachedObjectARB(UInt32 containerObj, Int32 maxCount, out Int32 count, UInt32[] obj)
		{
			unsafe {
				fixed (Int32* p_count = &count)
				fixed (UInt32* p_obj = obj)
				{
					Debug.Assert(Delegates.pglGetAttachedObjectsARB != null, "pglGetAttachedObjectsARB not implemented");
					Delegates.pglGetAttachedObjectsARB(containerObj, maxCount, p_count, p_obj);
					CallLog("glGetAttachedObjectsARB({0}, {1}, {2}, {3})", containerObj, maxCount, count, obj);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetUniformLocationARB.
		/// </summary>
		/// <param name="programObj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:String"/>.
		/// </param>
		public static Int32 GetUniformLocationARB(UInt32 programObj, String name)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetUniformLocationARB != null, "pglGetUniformLocationARB not implemented");
			retValue = Delegates.pglGetUniformLocationARB(programObj, name);
			CallLog("glGetUniformLocationARB({0}, {1}) = {2}", programObj, name, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetActiveUniformARB.
		/// </summary>
		/// <param name="programObj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="maxLength">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		public static void GetActiveUniformARB(UInt32 programObj, UInt32 index, Int32 maxLength, out Int32 length, out Int32 size, out int type, [Out] StringBuilder name)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				fixed (Int32* p_size = &size)
				fixed (int* p_type = &type)
				{
					Debug.Assert(Delegates.pglGetActiveUniformARB != null, "pglGetActiveUniformARB not implemented");
					Delegates.pglGetActiveUniformARB(programObj, index, maxLength, p_length, p_size, p_type, name);
					CallLog("glGetActiveUniformARB({0}, {1}, {2}, {3}, {4}, {5}, {6})", programObj, index, maxLength, length, size, type, name);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetUniformfvARB.
		/// </summary>
		/// <param name="programObj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void GetUniformARB(UInt32 programObj, Int32 location, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetUniformfvARB != null, "pglGetUniformfvARB not implemented");
					Delegates.pglGetUniformfvARB(programObj, location, p_params);
					CallLog("glGetUniformfvARB({0}, {1}, {2})", programObj, location, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetUniformivARB.
		/// </summary>
		/// <param name="programObj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void GetUniformARB(UInt32 programObj, Int32 location, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetUniformivARB != null, "pglGetUniformivARB not implemented");
					Delegates.pglGetUniformivARB(programObj, location, p_params);
					CallLog("glGetUniformivARB({0}, {1}, {2})", programObj, location, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetShaderSourceARB.
		/// </summary>
		/// <param name="obj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="maxLength">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="source">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		public static void GetShaderSourceARB(UInt32 obj, Int32 maxLength, out Int32 length, [Out] StringBuilder source)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetShaderSourceARB != null, "pglGetShaderSourceARB not implemented");
					Delegates.pglGetShaderSourceARB(obj, maxLength, p_length, source);
					CallLog("glGetShaderSourceARB({0}, {1}, {2}, {3})", obj, maxLength, length, source);
				}
			}
			DebugCheckErrors();
		}

	}

}
