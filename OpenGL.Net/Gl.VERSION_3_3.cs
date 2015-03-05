
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
		/// Value of GL_VERTEX_ATTRIB_ARRAY_DIVISOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		public const int VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;

		/// <summary>
		/// Value of GL_SRC1_COLOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_blend_func_extended")]
		public const int SRC1_COLOR = 0x88F9;

		/// <summary>
		/// Value of GL_ONE_MINUS_SRC1_COLOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_blend_func_extended")]
		public const int ONE_MINUS_SRC1_COLOR = 0x88FA;

		/// <summary>
		/// Value of GL_ONE_MINUS_SRC1_ALPHA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_blend_func_extended")]
		public const int ONE_MINUS_SRC1_ALPHA = 0x88FB;

		/// <summary>
		/// Value of GL_MAX_DUAL_SOURCE_DRAW_BUFFERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_blend_func_extended")]
		public const int MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC;

		/// <summary>
		/// Value of GL_ANY_SAMPLES_PASSED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_occlusion_query2")]
		public const int ANY_SAMPLES_PASSED = 0x8C2F;

		/// <summary>
		/// Value of GL_SAMPLER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_sampler_objects")]
		public const int SAMPLER_BINDING = 0x8919;

		/// <summary>
		/// Value of GL_RGB10_A2UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_texture_rgb10_a2ui")]
		public const int RGB10_A2UI = 0x906F;

		/// <summary>
		/// Value of GL_TEXTURE_SWIZZLE_R symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_texture_swizzle")]
		public const int TEXTURE_SWIZZLE_R = 0x8E42;

		/// <summary>
		/// Value of GL_TEXTURE_SWIZZLE_G symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_texture_swizzle")]
		public const int TEXTURE_SWIZZLE_G = 0x8E43;

		/// <summary>
		/// Value of GL_TEXTURE_SWIZZLE_B symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_texture_swizzle")]
		public const int TEXTURE_SWIZZLE_B = 0x8E44;

		/// <summary>
		/// Value of GL_TEXTURE_SWIZZLE_A symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_texture_swizzle")]
		public const int TEXTURE_SWIZZLE_A = 0x8E45;

		/// <summary>
		/// Value of GL_TEXTURE_SWIZZLE_RGBA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_texture_swizzle")]
		public const int TEXTURE_SWIZZLE_RGBA = 0x8E46;

		/// <summary>
		/// Value of GL_TIME_ELAPSED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_timer_query")]
		public const int TIME_ELAPSED = 0x88BF;

		/// <summary>
		/// Value of GL_TIMESTAMP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_timer_query")]
		public const int TIMESTAMP = 0x8E28;

		/// <summary>
		/// Value of GL_INT_2_10_10_10_REV symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public const int INT_2_10_10_10_REV = 0x8D9F;

		/// <summary>
		/// bind a user-defined varying out variable to a fragment shader color number and index
		/// </summary>
		/// <param name="program">
		/// The name of the program containing varying out variable whose binding to modify
		/// </param>
		/// <param name="colorNumber">
		/// The color number to bind the user-defined varying out variable to
		/// </param>
		/// <param name="index">
		/// The index of the color input to bind the user-defined varying out variable to
		/// </param>
		/// <param name="name">
		/// The name of the user-defined varying out variable whose binding to modify
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_blend_func_extended")]
		public static void BindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, String name)
		{
			Debug.Assert(Delegates.pglBindFragDataLocationIndexed != null, "pglBindFragDataLocationIndexed not implemented");
			Delegates.pglBindFragDataLocationIndexed(program, colorNumber, index, name);
			CallLog("glBindFragDataLocationIndexed({0}, {1}, {2}, {3})", program, colorNumber, index, name);
			DebugCheckErrors();
		}

		/// <summary>
		/// query the bindings of color indices to user-defined varying out variables
		/// </summary>
		/// <param name="program">
		/// The name of the program containing varying out variable whose binding to query
		/// </param>
		/// <param name="name">
		/// The name of the user-defined varying out variable whose index to query
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_blend_func_extended")]
		public static Int32 GetFragDataIndex(UInt32 program, String name)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetFragDataIndex != null, "pglGetFragDataIndex not implemented");
			retValue = Delegates.pglGetFragDataIndex(program, name);
			CallLog("glGetFragDataIndex({0}, {1}) = {2}", program, name, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// generate sampler object names
		/// </summary>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="samplers">
		/// Specifies an array in which the generated sampler object names are stored.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_sampler_objects")]
		public static void GenSamplers(Int32 count, UInt32[] samplers)
		{
			Debug.Assert(samplers.Length >= count);

			unsafe {
				fixed (UInt32* p_samplers = samplers)
				{
					Debug.Assert(Delegates.pglGenSamplers != null, "pglGenSamplers not implemented");
					Delegates.pglGenSamplers(count, p_samplers);
					CallLog("glGenSamplers({0}, {1})", count, samplers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// delete named sampler objects
		/// </summary>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="samplers">
		/// Specifies an array of sampler objects to be deleted.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_sampler_objects")]
		public static void DeleteSamplers(Int32 count, UInt32[] samplers)
		{
			Debug.Assert(samplers.Length >= count);

			unsafe {
				fixed (UInt32* p_samplers = samplers)
				{
					Debug.Assert(Delegates.pglDeleteSamplers != null, "pglDeleteSamplers not implemented");
					Delegates.pglDeleteSamplers(count, p_samplers);
					CallLog("glDeleteSamplers({0}, {1})", count, samplers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// determine if a name corresponds to a sampler object
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_sampler_objects")]
		public static bool IsSampler(UInt32 sampler)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsSampler != null, "pglIsSampler not implemented");
			retValue = Delegates.pglIsSampler(sampler);
			CallLog("glIsSampler({0}) = {1}", sampler, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// bind a named sampler to a texturing target
		/// </summary>
		/// <param name="unit">
		/// Specifies the index of the texture unit to which the sampler is bound.
		/// </param>
		/// <param name="sampler">
		/// Specifies the name of a sampler.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_sampler_objects")]
		public static void BindSampler(UInt32 unit, UInt32 sampler)
		{
			Debug.Assert(Delegates.pglBindSampler != null, "pglBindSampler not implemented");
			Delegates.pglBindSampler(unit, sampler);
			CallLog("glBindSampler({0}, {1})", unit, sampler);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSamplerParameteri.
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_sampler_objects")]
		public static void SamplerParameter(UInt32 sampler, int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglSamplerParameteri != null, "pglSamplerParameteri not implemented");
			Delegates.pglSamplerParameteri(sampler, pname, param);
			CallLog("glSamplerParameteri({0}, {1}, {2})", sampler, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSamplerParameteriv.
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_sampler_objects")]
		public static void SamplerParameter(UInt32 sampler, int pname, Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglSamplerParameteriv != null, "pglSamplerParameteriv not implemented");
					Delegates.pglSamplerParameteriv(sampler, pname, p_param);
					CallLog("glSamplerParameteriv({0}, {1}, {2})", sampler, pname, param);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSamplerParameterf.
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_sampler_objects")]
		public static void SamplerParameter(UInt32 sampler, int pname, float param)
		{
			Debug.Assert(Delegates.pglSamplerParameterf != null, "pglSamplerParameterf not implemented");
			Delegates.pglSamplerParameterf(sampler, pname, param);
			CallLog("glSamplerParameterf({0}, {1}, {2})", sampler, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSamplerParameterfv.
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_sampler_objects")]
		public static void SamplerParameter(UInt32 sampler, int pname, float[] param)
		{
			unsafe {
				fixed (float* p_param = param)
				{
					Debug.Assert(Delegates.pglSamplerParameterfv != null, "pglSamplerParameterfv not implemented");
					Delegates.pglSamplerParameterfv(sampler, pname, p_param);
					CallLog("glSamplerParameterfv({0}, {1}, {2})", sampler, pname, param);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSamplerParameterIiv.
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_sampler_objects")]
		public static void SamplerParameterIiv(UInt32 sampler, int pname, Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					if        (Delegates.pglSamplerParameterIiv != null) {
						Delegates.pglSamplerParameterIiv(sampler, pname, p_param);
						CallLog("glSamplerParameterIiv({0}, {1}, {2})", sampler, pname, param);
					} else if (Delegates.pglSamplerParameterIivEXT != null) {
						Delegates.pglSamplerParameterIivEXT(sampler, pname, p_param);
						CallLog("glSamplerParameterIivEXT({0}, {1}, {2})", sampler, pname, param);
					} else if (Delegates.pglSamplerParameterIivOES != null) {
						Delegates.pglSamplerParameterIivOES(sampler, pname, p_param);
						CallLog("glSamplerParameterIivOES({0}, {1}, {2})", sampler, pname, param);
					} else
						throw new NotImplementedException("glSamplerParameterIiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSamplerParameterIuiv.
		/// </summary>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_sampler_objects")]
		public static void SamplerParameterIuiv(UInt32 sampler, int pname, UInt32[] param)
		{
			unsafe {
				fixed (UInt32* p_param = param)
				{
					if        (Delegates.pglSamplerParameterIuiv != null) {
						Delegates.pglSamplerParameterIuiv(sampler, pname, p_param);
						CallLog("glSamplerParameterIuiv({0}, {1}, {2})", sampler, pname, param);
					} else if (Delegates.pglSamplerParameterIuivEXT != null) {
						Delegates.pglSamplerParameterIuivEXT(sampler, pname, p_param);
						CallLog("glSamplerParameterIuivEXT({0}, {1}, {2})", sampler, pname, param);
					} else if (Delegates.pglSamplerParameterIuivOES != null) {
						Delegates.pglSamplerParameterIuivOES(sampler, pname, p_param);
						CallLog("glSamplerParameterIuivOES({0}, {1}, {2})", sampler, pname, param);
					} else
						throw new NotImplementedException("glSamplerParameterIuiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return sampler parameter values
		/// </summary>
		/// <param name="sampler">
		/// Specifies name of the sampler object from which to retrieve parameters.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, 
		/// GL_TEXTURE_MAX_LOD, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, 
		/// GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, and GL_TEXTURE_COMPARE_FUNC are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_sampler_objects")]
		public static void GetSamplerParameter(UInt32 sampler, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetSamplerParameteriv != null, "pglGetSamplerParameteriv not implemented");
					Delegates.pglGetSamplerParameteriv(sampler, pname, p_params);
					CallLog("glGetSamplerParameteriv({0}, {1}, {2})", sampler, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return sampler parameter values
		/// </summary>
		/// <param name="sampler">
		/// Specifies name of the sampler object from which to retrieve parameters.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, 
		/// GL_TEXTURE_MAX_LOD, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, 
		/// GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, and GL_TEXTURE_COMPARE_FUNC are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_sampler_objects")]
		public static void GetSamplerParameterIiv(UInt32 sampler, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					if        (Delegates.pglGetSamplerParameterIiv != null) {
						Delegates.pglGetSamplerParameterIiv(sampler, pname, p_params);
						CallLog("glGetSamplerParameterIiv({0}, {1}, {2})", sampler, pname, @params);
					} else if (Delegates.pglGetSamplerParameterIivEXT != null) {
						Delegates.pglGetSamplerParameterIivEXT(sampler, pname, p_params);
						CallLog("glGetSamplerParameterIivEXT({0}, {1}, {2})", sampler, pname, @params);
					} else if (Delegates.pglGetSamplerParameterIivOES != null) {
						Delegates.pglGetSamplerParameterIivOES(sampler, pname, p_params);
						CallLog("glGetSamplerParameterIivOES({0}, {1}, {2})", sampler, pname, @params);
					} else
						throw new NotImplementedException("glGetSamplerParameterIiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return sampler parameter values
		/// </summary>
		/// <param name="sampler">
		/// Specifies name of the sampler object from which to retrieve parameters.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, 
		/// GL_TEXTURE_MAX_LOD, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, 
		/// GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, and GL_TEXTURE_COMPARE_FUNC are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_sampler_objects")]
		public static void GetSamplerParameter(UInt32 sampler, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetSamplerParameterfv != null, "pglGetSamplerParameterfv not implemented");
					Delegates.pglGetSamplerParameterfv(sampler, pname, p_params);
					CallLog("glGetSamplerParameterfv({0}, {1}, {2})", sampler, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return sampler parameter values
		/// </summary>
		/// <param name="sampler">
		/// Specifies name of the sampler object from which to retrieve parameters.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a sampler parameter. GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, 
		/// GL_TEXTURE_MAX_LOD, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, GL_TEXTURE_WRAP_R, 
		/// GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, and GL_TEXTURE_COMPARE_FUNC are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_sampler_objects")]
		public static void GetSamplerParameterIuiv(UInt32 sampler, int pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					if        (Delegates.pglGetSamplerParameterIuiv != null) {
						Delegates.pglGetSamplerParameterIuiv(sampler, pname, p_params);
						CallLog("glGetSamplerParameterIuiv({0}, {1}, {2})", sampler, pname, @params);
					} else if (Delegates.pglGetSamplerParameterIuivEXT != null) {
						Delegates.pglGetSamplerParameterIuivEXT(sampler, pname, p_params);
						CallLog("glGetSamplerParameterIuivEXT({0}, {1}, {2})", sampler, pname, @params);
					} else if (Delegates.pglGetSamplerParameterIuivOES != null) {
						Delegates.pglGetSamplerParameterIuivOES(sampler, pname, p_params);
						CallLog("glGetSamplerParameterIuivOES({0}, {1}, {2})", sampler, pname, @params);
					} else
						throw new NotImplementedException("glGetSamplerParameterIuiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// record the GL time into a query object after all previous commands have reached the GL server but have not yet necessarily executed.
		/// </summary>
		/// <param name="id">
		/// Specify the name of a query object into which to record the GL time.
		/// </param>
		/// <param name="target">
		/// Specify the counter to query. target must be GL_TIMESTAMP.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_timer_query")]
		public static void QueryCounter(UInt32 id, int target)
		{
			if        (Delegates.pglQueryCounter != null) {
				Delegates.pglQueryCounter(id, target);
				CallLog("glQueryCounter({0}, {1})", id, target);
			} else if (Delegates.pglQueryCounterEXT != null) {
				Delegates.pglQueryCounterEXT(id, target);
				CallLog("glQueryCounterEXT({0}, {1})", id, target);
			} else
				throw new NotImplementedException("glQueryCounter (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// return parameters of a query object
		/// </summary>
		/// <param name="id">
		/// Specifies the name of a query object.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or 
		/// GL_QUERY_RESULT_AVAILABLE.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_timer_query")]
		public static void GetQueryObjecti64v(UInt32 id, int pname, Int64[] @params)
		{
			unsafe {
				fixed (Int64* p_params = @params)
				{
					if        (Delegates.pglGetQueryObjecti64v != null) {
						Delegates.pglGetQueryObjecti64v(id, pname, p_params);
						CallLog("glGetQueryObjecti64v({0}, {1}, {2})", id, pname, @params);
					} else if (Delegates.pglGetQueryObjecti64vEXT != null) {
						Delegates.pglGetQueryObjecti64vEXT(id, pname, p_params);
						CallLog("glGetQueryObjecti64vEXT({0}, {1}, {2})", id, pname, @params);
					} else
						throw new NotImplementedException("glGetQueryObjecti64v (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return parameters of a query object
		/// </summary>
		/// <param name="id">
		/// Specifies the name of a query object.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or 
		/// GL_QUERY_RESULT_AVAILABLE.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_timer_query")]
		public static void GetQueryObjectui64v(UInt32 id, int pname, UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					if        (Delegates.pglGetQueryObjectui64v != null) {
						Delegates.pglGetQueryObjectui64v(id, pname, p_params);
						CallLog("glGetQueryObjectui64v({0}, {1}, {2})", id, pname, @params);
					} else if (Delegates.pglGetQueryObjectui64vEXT != null) {
						Delegates.pglGetQueryObjectui64vEXT(id, pname, p_params);
						CallLog("glGetQueryObjectui64vEXT({0}, {1}, {2})", id, pname, @params);
					} else
						throw new NotImplementedException("glGetQueryObjectui64v (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// modify the rate at which generic vertex attributes advance during instanced rendering
		/// </summary>
		/// <param name="index">
		/// Specify the index of the generic vertex attribute.
		/// </param>
		/// <param name="divisor">
		/// Specify the number of instances that will pass between updates of the generic attribute at slot index.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		public static void VertexAttribDivisor(UInt32 index, UInt32 divisor)
		{
			if        (Delegates.pglVertexAttribDivisor != null) {
				Delegates.pglVertexAttribDivisor(index, divisor);
				CallLog("glVertexAttribDivisor({0}, {1})", index, divisor);
			} else if (Delegates.pglVertexAttribDivisorANGLE != null) {
				Delegates.pglVertexAttribDivisorANGLE(index, divisor);
				CallLog("glVertexAttribDivisorANGLE({0}, {1})", index, divisor);
			} else if (Delegates.pglVertexAttribDivisorARB != null) {
				Delegates.pglVertexAttribDivisorARB(index, divisor);
				CallLog("glVertexAttribDivisorARB({0}, {1})", index, divisor);
			} else if (Delegates.pglVertexAttribDivisorEXT != null) {
				Delegates.pglVertexAttribDivisorEXT(index, divisor);
				CallLog("glVertexAttribDivisorEXT({0}, {1})", index, divisor);
			} else if (Delegates.pglVertexAttribDivisorNV != null) {
				Delegates.pglVertexAttribDivisorNV(index, divisor);
				CallLog("glVertexAttribDivisorNV({0}, {1})", index, divisor);
			} else
				throw new NotImplementedException("glVertexAttribDivisor (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="type">
		/// For the packed commands (glVertexAttribP*), specified the type of packing used on the data. This parameter must be 
		/// GL_INT_2_10_10_10_REV or GL_UNSIGNED_INT_2_10_10_10_REV, to specify signed or unsigned data, respectively, or 
		/// GL_UNSIGNED_INT_10F_11F_11F_REV to specify floating point data.
		/// </param>
		/// <param name="normalized">
		/// For the packed commands, if GL_TRUE, then the values are to be converted to floating point values by normalizing. 
		/// Otherwise, they are converted directly to floating-point values. If type indicates a floating-pont format, then 
		/// normalized value must be GL_FALSE.
		/// </param>
		/// <param name="value">
		/// For the packed commands, specifies the new packed value to be used for the specified vertex attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void VertexAttribP1(UInt32 index, int type, bool normalized, UInt32 value)
		{
			Debug.Assert(Delegates.pglVertexAttribP1ui != null, "pglVertexAttribP1ui not implemented");
			Delegates.pglVertexAttribP1ui(index, type, normalized, value);
			CallLog("glVertexAttribP1ui({0}, {1}, {2}, {3})", index, type, normalized, value);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribP1uiv.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="normalized">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void VertexAttribP1(UInt32 index, int type, bool normalized, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglVertexAttribP1uiv != null, "pglVertexAttribP1uiv not implemented");
					Delegates.pglVertexAttribP1uiv(index, type, normalized, p_value);
					CallLog("glVertexAttribP1uiv({0}, {1}, {2}, {3})", index, type, normalized, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="type">
		/// For the packed commands (glVertexAttribP*), specified the type of packing used on the data. This parameter must be 
		/// GL_INT_2_10_10_10_REV or GL_UNSIGNED_INT_2_10_10_10_REV, to specify signed or unsigned data, respectively, or 
		/// GL_UNSIGNED_INT_10F_11F_11F_REV to specify floating point data.
		/// </param>
		/// <param name="normalized">
		/// For the packed commands, if GL_TRUE, then the values are to be converted to floating point values by normalizing. 
		/// Otherwise, they are converted directly to floating-point values. If type indicates a floating-pont format, then 
		/// normalized value must be GL_FALSE.
		/// </param>
		/// <param name="value">
		/// For the packed commands, specifies the new packed value to be used for the specified vertex attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void VertexAttribP2(UInt32 index, int type, bool normalized, UInt32 value)
		{
			Debug.Assert(Delegates.pglVertexAttribP2ui != null, "pglVertexAttribP2ui not implemented");
			Delegates.pglVertexAttribP2ui(index, type, normalized, value);
			CallLog("glVertexAttribP2ui({0}, {1}, {2}, {3})", index, type, normalized, value);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribP2uiv.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="normalized">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void VertexAttribP2(UInt32 index, int type, bool normalized, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglVertexAttribP2uiv != null, "pglVertexAttribP2uiv not implemented");
					Delegates.pglVertexAttribP2uiv(index, type, normalized, p_value);
					CallLog("glVertexAttribP2uiv({0}, {1}, {2}, {3})", index, type, normalized, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="type">
		/// For the packed commands (glVertexAttribP*), specified the type of packing used on the data. This parameter must be 
		/// GL_INT_2_10_10_10_REV or GL_UNSIGNED_INT_2_10_10_10_REV, to specify signed or unsigned data, respectively, or 
		/// GL_UNSIGNED_INT_10F_11F_11F_REV to specify floating point data.
		/// </param>
		/// <param name="normalized">
		/// For the packed commands, if GL_TRUE, then the values are to be converted to floating point values by normalizing. 
		/// Otherwise, they are converted directly to floating-point values. If type indicates a floating-pont format, then 
		/// normalized value must be GL_FALSE.
		/// </param>
		/// <param name="value">
		/// For the packed commands, specifies the new packed value to be used for the specified vertex attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void VertexAttribP3(UInt32 index, int type, bool normalized, UInt32 value)
		{
			Debug.Assert(Delegates.pglVertexAttribP3ui != null, "pglVertexAttribP3ui not implemented");
			Delegates.pglVertexAttribP3ui(index, type, normalized, value);
			CallLog("glVertexAttribP3ui({0}, {1}, {2}, {3})", index, type, normalized, value);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribP3uiv.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="normalized">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void VertexAttribP3(UInt32 index, int type, bool normalized, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglVertexAttribP3uiv != null, "pglVertexAttribP3uiv not implemented");
					Delegates.pglVertexAttribP3uiv(index, type, normalized, p_value);
					CallLog("glVertexAttribP3uiv({0}, {1}, {2}, {3})", index, type, normalized, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="type">
		/// For the packed commands (glVertexAttribP*), specified the type of packing used on the data. This parameter must be 
		/// GL_INT_2_10_10_10_REV or GL_UNSIGNED_INT_2_10_10_10_REV, to specify signed or unsigned data, respectively, or 
		/// GL_UNSIGNED_INT_10F_11F_11F_REV to specify floating point data.
		/// </param>
		/// <param name="normalized">
		/// For the packed commands, if GL_TRUE, then the values are to be converted to floating point values by normalizing. 
		/// Otherwise, they are converted directly to floating-point values. If type indicates a floating-pont format, then 
		/// normalized value must be GL_FALSE.
		/// </param>
		/// <param name="value">
		/// For the packed commands, specifies the new packed value to be used for the specified vertex attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void VertexAttribP4(UInt32 index, int type, bool normalized, UInt32 value)
		{
			Debug.Assert(Delegates.pglVertexAttribP4ui != null, "pglVertexAttribP4ui not implemented");
			Delegates.pglVertexAttribP4ui(index, type, normalized, value);
			CallLog("glVertexAttribP4ui({0}, {1}, {2}, {3})", index, type, normalized, value);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribP4uiv.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="normalized">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void VertexAttribP4(UInt32 index, int type, bool normalized, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglVertexAttribP4uiv != null, "pglVertexAttribP4uiv not implemented");
					Delegates.pglVertexAttribP4uiv(index, type, normalized, p_value);
					CallLog("glVertexAttribP4uiv({0}, {1}, {2}, {3})", index, type, normalized, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexP2ui.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void VertexP2(int type, UInt32 value)
		{
			Debug.Assert(Delegates.pglVertexP2ui != null, "pglVertexP2ui not implemented");
			Delegates.pglVertexP2ui(type, value);
			CallLog("glVertexP2ui({0}, {1})", type, value);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexP2uiv.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void VertexP2(int type, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglVertexP2uiv != null, "pglVertexP2uiv not implemented");
					Delegates.pglVertexP2uiv(type, p_value);
					CallLog("glVertexP2uiv({0}, {1})", type, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexP3ui.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void VertexP3(int type, UInt32 value)
		{
			Debug.Assert(Delegates.pglVertexP3ui != null, "pglVertexP3ui not implemented");
			Delegates.pglVertexP3ui(type, value);
			CallLog("glVertexP3ui({0}, {1})", type, value);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexP3uiv.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void VertexP3(int type, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglVertexP3uiv != null, "pglVertexP3uiv not implemented");
					Delegates.pglVertexP3uiv(type, p_value);
					CallLog("glVertexP3uiv({0}, {1})", type, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexP4ui.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void VertexP4(int type, UInt32 value)
		{
			Debug.Assert(Delegates.pglVertexP4ui != null, "pglVertexP4ui not implemented");
			Delegates.pglVertexP4ui(type, value);
			CallLog("glVertexP4ui({0}, {1})", type, value);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexP4uiv.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void VertexP4(int type, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglVertexP4uiv != null, "pglVertexP4uiv not implemented");
					Delegates.pglVertexP4uiv(type, p_value);
					CallLog("glVertexP4uiv({0}, {1})", type, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoordP1ui.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void TexCoordP1(int type, UInt32 coords)
		{
			Debug.Assert(Delegates.pglTexCoordP1ui != null, "pglTexCoordP1ui not implemented");
			Delegates.pglTexCoordP1ui(type, coords);
			CallLog("glTexCoordP1ui({0}, {1})", type, coords);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoordP1uiv.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void TexCoordP1(int type, UInt32[] coords)
		{
			unsafe {
				fixed (UInt32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoordP1uiv != null, "pglTexCoordP1uiv not implemented");
					Delegates.pglTexCoordP1uiv(type, p_coords);
					CallLog("glTexCoordP1uiv({0}, {1})", type, coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoordP2ui.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void TexCoordP2(int type, UInt32 coords)
		{
			Debug.Assert(Delegates.pglTexCoordP2ui != null, "pglTexCoordP2ui not implemented");
			Delegates.pglTexCoordP2ui(type, coords);
			CallLog("glTexCoordP2ui({0}, {1})", type, coords);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoordP2uiv.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void TexCoordP2(int type, UInt32[] coords)
		{
			unsafe {
				fixed (UInt32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoordP2uiv != null, "pglTexCoordP2uiv not implemented");
					Delegates.pglTexCoordP2uiv(type, p_coords);
					CallLog("glTexCoordP2uiv({0}, {1})", type, coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoordP3ui.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void TexCoordP3(int type, UInt32 coords)
		{
			Debug.Assert(Delegates.pglTexCoordP3ui != null, "pglTexCoordP3ui not implemented");
			Delegates.pglTexCoordP3ui(type, coords);
			CallLog("glTexCoordP3ui({0}, {1})", type, coords);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoordP3uiv.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void TexCoordP3(int type, UInt32[] coords)
		{
			unsafe {
				fixed (UInt32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoordP3uiv != null, "pglTexCoordP3uiv not implemented");
					Delegates.pglTexCoordP3uiv(type, p_coords);
					CallLog("glTexCoordP3uiv({0}, {1})", type, coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoordP4ui.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void TexCoordP4(int type, UInt32 coords)
		{
			Debug.Assert(Delegates.pglTexCoordP4ui != null, "pglTexCoordP4ui not implemented");
			Delegates.pglTexCoordP4ui(type, coords);
			CallLog("glTexCoordP4ui({0}, {1})", type, coords);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoordP4uiv.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void TexCoordP4(int type, UInt32[] coords)
		{
			unsafe {
				fixed (UInt32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoordP4uiv != null, "pglTexCoordP4uiv not implemented");
					Delegates.pglTexCoordP4uiv(type, p_coords);
					CallLog("glTexCoordP4uiv({0}, {1})", type, coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoordP1ui.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void MultiTexCoordP1(int texture, int type, UInt32 coords)
		{
			Debug.Assert(Delegates.pglMultiTexCoordP1ui != null, "pglMultiTexCoordP1ui not implemented");
			Delegates.pglMultiTexCoordP1ui(texture, type, coords);
			CallLog("glMultiTexCoordP1ui({0}, {1}, {2})", texture, type, coords);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoordP1uiv.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void MultiTexCoordP1(int texture, int type, UInt32[] coords)
		{
			unsafe {
				fixed (UInt32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoordP1uiv != null, "pglMultiTexCoordP1uiv not implemented");
					Delegates.pglMultiTexCoordP1uiv(texture, type, p_coords);
					CallLog("glMultiTexCoordP1uiv({0}, {1}, {2})", texture, type, coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoordP2ui.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void MultiTexCoordP2(int texture, int type, UInt32 coords)
		{
			Debug.Assert(Delegates.pglMultiTexCoordP2ui != null, "pglMultiTexCoordP2ui not implemented");
			Delegates.pglMultiTexCoordP2ui(texture, type, coords);
			CallLog("glMultiTexCoordP2ui({0}, {1}, {2})", texture, type, coords);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoordP2uiv.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void MultiTexCoordP2(int texture, int type, UInt32[] coords)
		{
			unsafe {
				fixed (UInt32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoordP2uiv != null, "pglMultiTexCoordP2uiv not implemented");
					Delegates.pglMultiTexCoordP2uiv(texture, type, p_coords);
					CallLog("glMultiTexCoordP2uiv({0}, {1}, {2})", texture, type, coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoordP3ui.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void MultiTexCoordP3(int texture, int type, UInt32 coords)
		{
			Debug.Assert(Delegates.pglMultiTexCoordP3ui != null, "pglMultiTexCoordP3ui not implemented");
			Delegates.pglMultiTexCoordP3ui(texture, type, coords);
			CallLog("glMultiTexCoordP3ui({0}, {1}, {2})", texture, type, coords);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoordP3uiv.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void MultiTexCoordP3(int texture, int type, UInt32[] coords)
		{
			unsafe {
				fixed (UInt32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoordP3uiv != null, "pglMultiTexCoordP3uiv not implemented");
					Delegates.pglMultiTexCoordP3uiv(texture, type, p_coords);
					CallLog("glMultiTexCoordP3uiv({0}, {1}, {2})", texture, type, coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoordP4ui.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void MultiTexCoordP4(int texture, int type, UInt32 coords)
		{
			Debug.Assert(Delegates.pglMultiTexCoordP4ui != null, "pglMultiTexCoordP4ui not implemented");
			Delegates.pglMultiTexCoordP4ui(texture, type, coords);
			CallLog("glMultiTexCoordP4ui({0}, {1}, {2})", texture, type, coords);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoordP4uiv.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void MultiTexCoordP4(int texture, int type, UInt32[] coords)
		{
			unsafe {
				fixed (UInt32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoordP4uiv != null, "pglMultiTexCoordP4uiv not implemented");
					Delegates.pglMultiTexCoordP4uiv(texture, type, p_coords);
					CallLog("glMultiTexCoordP4uiv({0}, {1}, {2})", texture, type, coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNormalP3ui.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void NormalP3(int type, UInt32 coords)
		{
			Debug.Assert(Delegates.pglNormalP3ui != null, "pglNormalP3ui not implemented");
			Delegates.pglNormalP3ui(type, coords);
			CallLog("glNormalP3ui({0}, {1})", type, coords);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNormalP3uiv.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void NormalP3(int type, UInt32[] coords)
		{
			unsafe {
				fixed (UInt32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglNormalP3uiv != null, "pglNormalP3uiv not implemented");
					Delegates.pglNormalP3uiv(type, p_coords);
					CallLog("glNormalP3uiv({0}, {1})", type, coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorP3ui.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="color">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void ColorP3(int type, UInt32 color)
		{
			Debug.Assert(Delegates.pglColorP3ui != null, "pglColorP3ui not implemented");
			Delegates.pglColorP3ui(type, color);
			CallLog("glColorP3ui({0}, {1})", type, color);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorP3uiv.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="color">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void ColorP3(int type, UInt32[] color)
		{
			unsafe {
				fixed (UInt32* p_color = color)
				{
					Debug.Assert(Delegates.pglColorP3uiv != null, "pglColorP3uiv not implemented");
					Delegates.pglColorP3uiv(type, p_color);
					CallLog("glColorP3uiv({0}, {1})", type, color);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorP4ui.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="color">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void ColorP4(int type, UInt32 color)
		{
			Debug.Assert(Delegates.pglColorP4ui != null, "pglColorP4ui not implemented");
			Delegates.pglColorP4ui(type, color);
			CallLog("glColorP4ui({0}, {1})", type, color);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorP4uiv.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="color">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void ColorP4(int type, UInt32[] color)
		{
			unsafe {
				fixed (UInt32* p_color = color)
				{
					Debug.Assert(Delegates.pglColorP4uiv != null, "pglColorP4uiv not implemented");
					Delegates.pglColorP4uiv(type, p_color);
					CallLog("glColorP4uiv({0}, {1})", type, color);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSecondaryColorP3ui.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="color">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void SecondaryColorP3(int type, UInt32 color)
		{
			Debug.Assert(Delegates.pglSecondaryColorP3ui != null, "pglSecondaryColorP3ui not implemented");
			Delegates.pglSecondaryColorP3ui(type, color);
			CallLog("glSecondaryColorP3ui({0}, {1})", type, color);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSecondaryColorP3uiv.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="color">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev")]
		public static void SecondaryColorP3(int type, UInt32[] color)
		{
			unsafe {
				fixed (UInt32* p_color = color)
				{
					Debug.Assert(Delegates.pglSecondaryColorP3uiv != null, "pglSecondaryColorP3uiv not implemented");
					Delegates.pglSecondaryColorP3uiv(type, p_color);
					CallLog("glSecondaryColorP3uiv({0}, {1})", type, color);
				}
			}
			DebugCheckErrors();
		}

	}

}
