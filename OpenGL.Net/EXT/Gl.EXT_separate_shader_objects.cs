
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
		/// [GL] Binding for glUseShaderProgramEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static void UseShaderProgramEXT(Int32 type, UInt32 program)
		{
			Debug.Assert(Delegates.pglUseShaderProgramEXT != null, "pglUseShaderProgramEXT not implemented");
			Delegates.pglUseShaderProgramEXT(type, program);
			LogCommand("glUseShaderProgramEXT", null, type, program			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glActiveProgramEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static void ActiveProgramEXT(UInt32 program)
		{
			Debug.Assert(Delegates.pglActiveProgramEXT != null, "pglActiveProgramEXT not implemented");
			Delegates.pglActiveProgramEXT(program);
			LogCommand("glActiveProgramEXT", null, program			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glCreateShaderProgramEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:ShaderType"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static UInt32 CreateShaderProgramEXT(ShaderType type, String @string)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglCreateShaderProgramEXT != null, "pglCreateShaderProgramEXT not implemented");
			retValue = Delegates.pglCreateShaderProgramEXT((Int32)type, @string);
			LogCommand("glCreateShaderProgramEXT", retValue, type, @string			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] Binding for glActiveShaderProgramEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ActiveShaderProgramEXT(UInt32 pipeline, UInt32 program)
		{
			Debug.Assert(Delegates.pglActiveShaderProgramEXT != null, "pglActiveShaderProgramEXT not implemented");
			Delegates.pglActiveShaderProgramEXT(pipeline, program);
			LogCommand("glActiveShaderProgramEXT", null, pipeline, program			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glBindProgramPipelineEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void BindProgramPipelineEXT(UInt32 pipeline)
		{
			Debug.Assert(Delegates.pglBindProgramPipelineEXT != null, "pglBindProgramPipelineEXT not implemented");
			Delegates.pglBindProgramPipelineEXT(pipeline);
			LogCommand("glBindProgramPipelineEXT", null, pipeline			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glCreateShaderProgramvEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:ShaderType"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="strings">
		/// A <see cref="T:String[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static UInt32 CreateShaderProgramEXT(ShaderType type, Int32 count, String[] strings)
		{
			Debug.Assert(strings.Length >= count);
			UInt32 retValue;

			Debug.Assert(Delegates.pglCreateShaderProgramvEXT != null, "pglCreateShaderProgramvEXT not implemented");
			retValue = Delegates.pglCreateShaderProgramvEXT((Int32)type, count, strings);
			LogCommand("glCreateShaderProgramvEXT", retValue, type, count, strings			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] Binding for glCreateShaderProgramvEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:ShaderType"/>.
		/// </param>
		/// <param name="strings">
		/// A <see cref="T:String[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static UInt32 CreateShaderProgramEXT(ShaderType type, String[] strings)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglCreateShaderProgramvEXT != null, "pglCreateShaderProgramvEXT not implemented");
			retValue = Delegates.pglCreateShaderProgramvEXT((Int32)type, (Int32)strings.Length, strings);
			LogCommand("glCreateShaderProgramvEXT", retValue, type, strings.Length, strings			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] Binding for glDeleteProgramPipelinesEXT.
		/// </summary>
		/// <param name="pipelines">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void DeleteProgramPipelinesEXT(params UInt32[] pipelines)
		{
			unsafe {
				fixed (UInt32* p_pipelines = pipelines)
				{
					Debug.Assert(Delegates.pglDeleteProgramPipelinesEXT != null, "pglDeleteProgramPipelinesEXT not implemented");
					Delegates.pglDeleteProgramPipelinesEXT((Int32)pipelines.Length, p_pipelines);
					LogCommand("glDeleteProgramPipelinesEXT", null, pipelines.Length, pipelines					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGenProgramPipelinesEXT.
		/// </summary>
		/// <param name="pipelines">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void GenProgramPipelinesEXT(UInt32[] pipelines)
		{
			unsafe {
				fixed (UInt32* p_pipelines = pipelines)
				{
					Debug.Assert(Delegates.pglGenProgramPipelinesEXT != null, "pglGenProgramPipelinesEXT not implemented");
					Delegates.pglGenProgramPipelinesEXT((Int32)pipelines.Length, p_pipelines);
					LogCommand("glGenProgramPipelinesEXT", null, pipelines.Length, pipelines					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGenProgramPipelinesEXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static UInt32 GenProgramPipelinesEXT()
		{
			UInt32[] retValue = new UInt32[1];
			GenProgramPipelinesEXT(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// [GL] Binding for glGetProgramPipelineInfoLogEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="infoLog">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void GetProgramPipelineInfoLogEXT(UInt32 pipeline, Int32 bufSize, out Int32 length, [Out] StringBuilder infoLog)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetProgramPipelineInfoLogEXT != null, "pglGetProgramPipelineInfoLogEXT not implemented");
					Delegates.pglGetProgramPipelineInfoLogEXT(pipeline, bufSize, p_length, infoLog);
					LogCommand("glGetProgramPipelineInfoLogEXT", null, pipeline, bufSize, length, infoLog					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetProgramPipelineivEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:PipelineParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void GetProgramPipelineEXT(UInt32 pipeline, PipelineParameterName pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramPipelineivEXT != null, "pglGetProgramPipelineivEXT not implemented");
					Delegates.pglGetProgramPipelineivEXT(pipeline, (Int32)pname, p_params);
					LogCommand("glGetProgramPipelineivEXT", null, pipeline, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glIsProgramPipelineEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static bool IsProgramPipelineEXT(UInt32 pipeline)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsProgramPipelineEXT != null, "pglIsProgramPipelineEXT not implemented");
			retValue = Delegates.pglIsProgramPipelineEXT(pipeline);
			LogCommand("glIsProgramPipelineEXT", retValue, pipeline			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] Binding for glUseProgramStagesEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stages">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void UseProgramStageEXT(UInt32 pipeline, UInt32 stages, UInt32 program)
		{
			Debug.Assert(Delegates.pglUseProgramStagesEXT != null, "pglUseProgramStagesEXT not implemented");
			Delegates.pglUseProgramStagesEXT(pipeline, stages, program);
			LogCommand("glUseProgramStagesEXT", null, pipeline, stages, program			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glValidateProgramPipelineEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
		public static void ValidateProgramPipelineEXT(UInt32 pipeline)
		{
			Debug.Assert(Delegates.pglValidateProgramPipelineEXT != null, "pglValidateProgramPipelineEXT not implemented");
			Delegates.pglValidateProgramPipelineEXT(pipeline);
			LogCommand("glValidateProgramPipelineEXT", null, pipeline			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUseShaderProgramEXT", ExactSpelling = true)]
			internal extern static void glUseShaderProgramEXT(Int32 type, UInt32 program);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glActiveProgramEXT", ExactSpelling = true)]
			internal extern static void glActiveProgramEXT(UInt32 program);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCreateShaderProgramEXT", ExactSpelling = true)]
			internal extern static UInt32 glCreateShaderProgramEXT(Int32 type, String @string);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glActiveShaderProgramEXT", ExactSpelling = true)]
			internal extern static void glActiveShaderProgramEXT(UInt32 pipeline, UInt32 program);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBindProgramPipelineEXT", ExactSpelling = true)]
			internal extern static void glBindProgramPipelineEXT(UInt32 pipeline);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCreateShaderProgramvEXT", ExactSpelling = true)]
			internal extern static UInt32 glCreateShaderProgramvEXT(Int32 type, Int32 count, String[] strings);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDeleteProgramPipelinesEXT", ExactSpelling = true)]
			internal extern static unsafe void glDeleteProgramPipelinesEXT(Int32 n, UInt32* pipelines);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGenProgramPipelinesEXT", ExactSpelling = true)]
			internal extern static unsafe void glGenProgramPipelinesEXT(Int32 n, UInt32* pipelines);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetProgramPipelineInfoLogEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramPipelineInfoLogEXT(UInt32 pipeline, Int32 bufSize, Int32* length, String infoLog);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetProgramPipelineivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetProgramPipelineivEXT(UInt32 pipeline, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIsProgramPipelineEXT", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.U1)]
			internal extern static bool glIsProgramPipelineEXT(UInt32 pipeline);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUseProgramStagesEXT", ExactSpelling = true)]
			internal extern static void glUseProgramStagesEXT(UInt32 pipeline, UInt32 stages, UInt32 program);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glValidateProgramPipelineEXT", ExactSpelling = true)]
			internal extern static void glValidateProgramPipelineEXT(UInt32 pipeline);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_separate_shader_objects")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUseShaderProgramEXT(Int32 type, UInt32 program);

			[RequiredByFeature("GL_EXT_separate_shader_objects")]
			[ThreadStatic]
			internal static glUseShaderProgramEXT pglUseShaderProgramEXT;

			[RequiredByFeature("GL_EXT_separate_shader_objects")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glActiveProgramEXT(UInt32 program);

			[RequiredByFeature("GL_EXT_separate_shader_objects")]
			[ThreadStatic]
			internal static glActiveProgramEXT pglActiveProgramEXT;

			[RequiredByFeature("GL_EXT_separate_shader_objects")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glCreateShaderProgramEXT(Int32 type, String @string);

			[RequiredByFeature("GL_EXT_separate_shader_objects")]
			[ThreadStatic]
			internal static glCreateShaderProgramEXT pglCreateShaderProgramEXT;

			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glActiveShaderProgramEXT(UInt32 pipeline, UInt32 program);

			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glActiveShaderProgramEXT pglActiveShaderProgramEXT;

			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindProgramPipelineEXT(UInt32 pipeline);

			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glBindProgramPipelineEXT pglBindProgramPipelineEXT;

			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glCreateShaderProgramvEXT(Int32 type, Int32 count, String[] strings);

			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glCreateShaderProgramvEXT pglCreateShaderProgramvEXT;

			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteProgramPipelinesEXT(Int32 n, UInt32* pipelines);

			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glDeleteProgramPipelinesEXT pglDeleteProgramPipelinesEXT;

			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenProgramPipelinesEXT(Int32 n, UInt32* pipelines);

			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glGenProgramPipelinesEXT pglGenProgramPipelinesEXT;

			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramPipelineInfoLogEXT(UInt32 pipeline, Int32 bufSize, Int32* length, [Out] StringBuilder infoLog);

			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glGetProgramPipelineInfoLogEXT pglGetProgramPipelineInfoLogEXT;

			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramPipelineivEXT(UInt32 pipeline, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glGetProgramPipelineivEXT pglGetProgramPipelineivEXT;

			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsProgramPipelineEXT(UInt32 pipeline);

			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glIsProgramPipelineEXT pglIsProgramPipelineEXT;

			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUseProgramStagesEXT(UInt32 pipeline, UInt32 stages, UInt32 program);

			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glUseProgramStagesEXT pglUseProgramStagesEXT;

			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glValidateProgramPipelineEXT(UInt32 pipeline);

			[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gles2")]
			[ThreadStatic]
			internal static glValidateProgramPipelineEXT pglValidateProgramPipelineEXT;

		}
	}

}
