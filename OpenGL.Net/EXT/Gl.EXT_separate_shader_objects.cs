
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
		/// Binding for glUseShaderProgramEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void UseShaderProgramEXT(Int32 type, UInt32 program)
		{
			Debug.Assert(Delegates.pglUseShaderProgramEXT != null, "pglUseShaderProgramEXT not implemented");
			Delegates.pglUseShaderProgramEXT(type, program);
			LogFunction("glUseShaderProgramEXT({0}, {1})", LogEnumName(type), program);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glActiveProgramEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ActiveProgramEXT(UInt32 program)
		{
			Debug.Assert(Delegates.pglActiveProgramEXT != null, "pglActiveProgramEXT not implemented");
			Delegates.pglActiveProgramEXT(program);
			LogFunction("glActiveProgramEXT({0})", program);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCreateShaderProgramEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static UInt32 CreateShaderProgramEXT(Int32 type, String @string)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglCreateShaderProgramEXT != null, "pglCreateShaderProgramEXT not implemented");
			retValue = Delegates.pglCreateShaderProgramEXT(type, @string);
			LogFunction("glCreateShaderProgramEXT({0}, {1}) = {2}", LogEnumName(type), @string, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glActiveShaderProgramEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ActiveShaderProgramEXT(UInt32 pipeline, UInt32 program)
		{
			Debug.Assert(Delegates.pglActiveShaderProgramEXT != null, "pglActiveShaderProgramEXT not implemented");
			Delegates.pglActiveShaderProgramEXT(pipeline, program);
			LogFunction("glActiveShaderProgramEXT({0}, {1})", pipeline, program);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBindProgramPipelineEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void BindProgramPipelineEXT(UInt32 pipeline)
		{
			Debug.Assert(Delegates.pglBindProgramPipelineEXT != null, "pglBindProgramPipelineEXT not implemented");
			Delegates.pglBindProgramPipelineEXT(pipeline);
			LogFunction("glBindProgramPipelineEXT({0})", pipeline);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCreateShaderProgramvEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="strings">
		/// A <see cref="T:String[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static UInt32 CreateShaderProgramEXT(Int32 type, String[] strings)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglCreateShaderProgramvEXT != null, "pglCreateShaderProgramvEXT not implemented");
			retValue = Delegates.pglCreateShaderProgramvEXT(type, (Int32)strings.Length, strings);
			LogFunction("glCreateShaderProgramvEXT({0}, {1}, {2}) = {3}", LogEnumName(type), strings.Length, LogValue(strings), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glDeleteProgramPipelinesEXT.
		/// </summary>
		/// <param name="pipelines">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void DeleteProgramPipelinesEXT(params UInt32[] pipelines)
		{
			unsafe {
				fixed (UInt32* p_pipelines = pipelines)
				{
					Debug.Assert(Delegates.pglDeleteProgramPipelinesEXT != null, "pglDeleteProgramPipelinesEXT not implemented");
					Delegates.pglDeleteProgramPipelinesEXT((Int32)pipelines.Length, p_pipelines);
					LogFunction("glDeleteProgramPipelinesEXT({0}, {1})", pipelines.Length, LogValue(pipelines));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenProgramPipelinesEXT.
		/// </summary>
		/// <param name="pipelines">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void GenProgramPipelinesEXT(UInt32[] pipelines)
		{
			unsafe {
				fixed (UInt32* p_pipelines = pipelines)
				{
					Debug.Assert(Delegates.pglGenProgramPipelinesEXT != null, "pglGenProgramPipelinesEXT not implemented");
					Delegates.pglGenProgramPipelinesEXT((Int32)pipelines.Length, p_pipelines);
					LogFunction("glGenProgramPipelinesEXT({0}, {1})", pipelines.Length, LogValue(pipelines));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenProgramPipelinesEXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static UInt32 GenProgramPipelinesEXT()
		{
			UInt32[] retValue = new UInt32[1];
			GenProgramPipelinesEXT(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// Binding for glGetProgramPipelineInfoLogEXT.
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
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void GetProgramPipelineInfoLogEXT(UInt32 pipeline, Int32 bufSize, out Int32 length, [Out] StringBuilder infoLog)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetProgramPipelineInfoLogEXT != null, "pglGetProgramPipelineInfoLogEXT not implemented");
					Delegates.pglGetProgramPipelineInfoLogEXT(pipeline, bufSize, p_length, infoLog);
					LogFunction("glGetProgramPipelineInfoLogEXT({0}, {1}, {2}, {3})", pipeline, bufSize, length, infoLog);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetProgramPipelineivEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void GetProgramPipelineEXT(UInt32 pipeline, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramPipelineivEXT != null, "pglGetProgramPipelineivEXT not implemented");
					Delegates.pglGetProgramPipelineivEXT(pipeline, pname, p_params);
					LogFunction("glGetProgramPipelineivEXT({0}, {1}, {2})", pipeline, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glIsProgramPipelineEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static bool IsProgramPipelineEXT(UInt32 pipeline)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsProgramPipelineEXT != null, "pglIsProgramPipelineEXT not implemented");
			retValue = Delegates.pglIsProgramPipelineEXT(pipeline);
			LogFunction("glIsProgramPipelineEXT({0}) = {1}", pipeline, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glUseProgramStagesEXT.
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
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void UseProgramStageEXT(UInt32 pipeline, UInt32 stages, UInt32 program)
		{
			Debug.Assert(Delegates.pglUseProgramStagesEXT != null, "pglUseProgramStagesEXT not implemented");
			Delegates.pglUseProgramStagesEXT(pipeline, stages, program);
			LogFunction("glUseProgramStagesEXT({0}, {1}, {2})", pipeline, stages, program);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glValidateProgramPipelineEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ValidateProgramPipelineEXT(UInt32 pipeline)
		{
			Debug.Assert(Delegates.pglValidateProgramPipelineEXT != null, "pglValidateProgramPipelineEXT not implemented");
			Delegates.pglValidateProgramPipelineEXT(pipeline);
			LogFunction("glValidateProgramPipelineEXT({0})", pipeline);
			DebugCheckErrors(null);
		}

	}

}
