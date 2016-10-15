
// Copyright (C) 2015-2016 Luca Piccioni
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
		/// Value of GL_PROGRAM_OBJECT_ARB symbol.
		/// </summary>
		[AliasOf("GL_PROGRAM_OBJECT_EXT")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_EXT_debug_label", Api = "gl|gles2")]
		public const int PROGRAM_OBJECT_ARB = 0x8B40;

		/// <summary>
		/// Value of GL_SHADER_OBJECT_ARB symbol.
		/// </summary>
		[AliasOf("GL_SHADER_OBJECT_EXT")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_EXT_debug_label", Api = "gl|gles2")]
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
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void DeleteObjectARB(UInt32 obj)
		{
			Debug.Assert(Delegates.pglDeleteObjectARB != null, "pglDeleteObjectARB not implemented");
			Delegates.pglDeleteObjectARB(obj);
			LogFunction("glDeleteObjectARB({0})", obj);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetHandleARB.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static UInt32 GetHandleARB(Int32 pname)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglGetHandleARB != null, "pglGetHandleARB not implemented");
			retValue = Delegates.pglGetHandleARB(pname);
			LogFunction("glGetHandleARB({0}) = {1}", LogEnumName(pname), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetObjectParameterfvARB.
		/// </summary>
		/// <param name="obj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void GetObjectParameterARB(UInt32 obj, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetObjectParameterfvARB != null, "pglGetObjectParameterfvARB not implemented");
					Delegates.pglGetObjectParameterfvARB(obj, pname, p_params);
					LogFunction("glGetObjectParameterfvARB({0}, {1}, {2})", obj, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetObjectParameterfvARB.
		/// </summary>
		/// <param name="obj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void GetObjectParameterARB(UInt32 obj, Int32 pname, out float @params)
		{
			unsafe {
				fixed (float* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetObjectParameterfvARB != null, "pglGetObjectParameterfvARB not implemented");
					Delegates.pglGetObjectParameterfvARB(obj, pname, p_params);
					LogFunction("glGetObjectParameterfvARB({0}, {1}, {2})", obj, LogEnumName(pname), @params);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetObjectParameterivARB.
		/// </summary>
		/// <param name="obj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void GetObjectParameterARB(UInt32 obj, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetObjectParameterivARB != null, "pglGetObjectParameterivARB not implemented");
					Delegates.pglGetObjectParameterivARB(obj, pname, p_params);
					LogFunction("glGetObjectParameterivARB({0}, {1}, {2})", obj, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetObjectParameterivARB.
		/// </summary>
		/// <param name="obj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void GetObjectParameterARB(UInt32 obj, Int32 pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetObjectParameterivARB != null, "pglGetObjectParameterivARB not implemented");
					Delegates.pglGetObjectParameterivARB(obj, pname, p_params);
					LogFunction("glGetObjectParameterivARB({0}, {1}, {2})", obj, LogEnumName(pname), @params);
				}
			}
			DebugCheckErrors(null);
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
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void GetInfoLogARB(UInt32 obj, Int32 maxLength, out Int32 length, [Out] StringBuilder infoLog)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetInfoLogARB != null, "pglGetInfoLogARB not implemented");
					Delegates.pglGetInfoLogARB(obj, maxLength, p_length, infoLog);
					LogFunction("glGetInfoLogARB({0}, {1}, {2}, {3})", obj, maxLength, length, infoLog);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetAttachedObjectsARB.
		/// </summary>
		/// <param name="containerObj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="obj">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_shader_objects")]
		public static void GetAttachedObjectARB(UInt32 containerObj, out Int32 count, [Out] UInt32[] obj)
		{
			unsafe {
				fixed (Int32* p_count = &count)
				fixed (UInt32* p_obj = obj)
				{
					Debug.Assert(Delegates.pglGetAttachedObjectsARB != null, "pglGetAttachedObjectsARB not implemented");
					Delegates.pglGetAttachedObjectsARB(containerObj, (Int32)obj.Length, p_count, p_obj);
					LogFunction("glGetAttachedObjectsARB({0}, {1}, {2}, {3})", containerObj, obj.Length, count, LogValue(obj));
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDeleteObjectARB", ExactSpelling = true)]
			internal extern static void glDeleteObjectARB(UInt32 obj);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetHandleARB", ExactSpelling = true)]
			internal extern static UInt32 glGetHandleARB(Int32 pname);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetObjectParameterfvARB", ExactSpelling = true)]
			internal extern static unsafe void glGetObjectParameterfvARB(UInt32 obj, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetObjectParameterivARB", ExactSpelling = true)]
			internal extern static unsafe void glGetObjectParameterivARB(UInt32 obj, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetInfoLogARB", ExactSpelling = true)]
			internal extern static unsafe void glGetInfoLogARB(UInt32 obj, Int32 maxLength, Int32* length, String infoLog);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetAttachedObjectsARB", ExactSpelling = true)]
			internal extern static unsafe void glGetAttachedObjectsARB(UInt32 containerObj, Int32 maxCount, Int32* count, UInt32* obj);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDeleteObjectARB(UInt32 obj);

			[ThreadStatic]
			internal static glDeleteObjectARB pglDeleteObjectARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glGetHandleARB(Int32 pname);

			[ThreadStatic]
			internal static glGetHandleARB pglGetHandleARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetObjectParameterfvARB(UInt32 obj, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetObjectParameterfvARB pglGetObjectParameterfvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetObjectParameterivARB(UInt32 obj, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetObjectParameterivARB pglGetObjectParameterivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetInfoLogARB(UInt32 obj, Int32 maxLength, Int32* length, [Out] StringBuilder infoLog);

			[ThreadStatic]
			internal static glGetInfoLogARB pglGetInfoLogARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetAttachedObjectsARB(UInt32 containerObj, Int32 maxCount, Int32* count, UInt32* obj);

			[ThreadStatic]
			internal static glGetAttachedObjectsARB pglGetAttachedObjectsARB;

		}
	}

}
