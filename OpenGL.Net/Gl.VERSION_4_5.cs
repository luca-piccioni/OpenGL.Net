
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
		/// [GL] Value of GL_CONTEXT_LOST symbol.
		/// </summary>
		[AliasOf("GL_CONTEXT_LOST_KHR")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		public const int CONTEXT_LOST = 0x0507;

		/// <summary>
		/// [GL] Value of GL_NEGATIVE_ONE_TO_ONE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_clip_control", Api = "gl|glcore")]
		public const int NEGATIVE_ONE_TO_ONE = 0x935E;

		/// <summary>
		/// [GL] Value of GL_ZERO_TO_ONE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_clip_control", Api = "gl|glcore")]
		public const int ZERO_TO_ONE = 0x935F;

		/// <summary>
		/// [GL] Value of GL_CLIP_ORIGIN symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_clip_control", Api = "gl|glcore")]
		public const int CLIP_ORIGIN = 0x935C;

		/// <summary>
		/// [GL] Value of GL_CLIP_DEPTH_MODE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_clip_control", Api = "gl|glcore")]
		public const int CLIP_DEPTH_MODE = 0x935D;

		/// <summary>
		/// [GL] Value of GL_QUERY_WAIT_INVERTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_conditional_render_inverted", Api = "gl|glcore")]
		public const int QUERY_WAIT_INVERTED = 0x8E17;

		/// <summary>
		/// [GL] Value of GL_QUERY_NO_WAIT_INVERTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_conditional_render_inverted", Api = "gl|glcore")]
		public const int QUERY_NO_WAIT_INVERTED = 0x8E18;

		/// <summary>
		/// [GL] Value of GL_QUERY_BY_REGION_WAIT_INVERTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_conditional_render_inverted", Api = "gl|glcore")]
		public const int QUERY_BY_REGION_WAIT_INVERTED = 0x8E19;

		/// <summary>
		/// [GL] Value of GL_QUERY_BY_REGION_NO_WAIT_INVERTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_conditional_render_inverted", Api = "gl|glcore")]
		public const int QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A;

		/// <summary>
		/// [GL] Value of GL_MAX_CULL_DISTANCES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_cull_distance", Api = "gl|glcore")]
		public const int MAX_CULL_DISTANCES = 0x82F9;

		/// <summary>
		/// [GL] Value of GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_cull_distance", Api = "gl|glcore")]
		public const int MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA;

		/// <summary>
		/// [GL4] Gl.GetTexParameter: Returns the effective target of the texture object. For glGetTex*Parameter functions, this is 
		/// the target parameter. For glGetTextureParameter*, it is the target to which the texture was initially bound when it was 
		/// created, or the value of the target parameter to the call to glCreateTextures which created the texture.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public const int TEXTURE_TARGET = 0x1006;

		/// <summary>
		/// [GL] Value of GL_QUERY_TARGET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public const int QUERY_TARGET = 0x82EA;

		/// <summary>
		/// [GL4|GLES3.2] Gl.GetGraphicsResetStatus: Indicates that a reset has been detected that is attributable to the current GL 
		/// context.
		/// </summary>
		[AliasOf("GL_GUILTY_CONTEXT_RESET_ARB")]
		[AliasOf("GL_GUILTY_CONTEXT_RESET_EXT")]
		[AliasOf("GL_GUILTY_CONTEXT_RESET_KHR")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		public const int GUILTY_CONTEXT_RESET = 0x8253;

		/// <summary>
		/// [GL4|GLES3.2] Gl.GetGraphicsResetStatus: Indicates a reset has been detected that is not attributable to the current GL 
		/// context.
		/// </summary>
		[AliasOf("GL_INNOCENT_CONTEXT_RESET_ARB")]
		[AliasOf("GL_INNOCENT_CONTEXT_RESET_EXT")]
		[AliasOf("GL_INNOCENT_CONTEXT_RESET_KHR")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		public const int INNOCENT_CONTEXT_RESET = 0x8254;

		/// <summary>
		/// [GL4|GLES3.2] Gl.GetGraphicsResetStatus: Indicates a detected graphics reset whose cause is unknown.
		/// </summary>
		[AliasOf("GL_UNKNOWN_CONTEXT_RESET_ARB")]
		[AliasOf("GL_UNKNOWN_CONTEXT_RESET_EXT")]
		[AliasOf("GL_UNKNOWN_CONTEXT_RESET_KHR")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		public const int UNKNOWN_CONTEXT_RESET = 0x8255;

		/// <summary>
		/// [GLES3.2] Gl.Get: data returns a single value, the behaviour of reset notification. Valid values are 
		/// Gl.NO_RESET_NOTIFICATION, indicating that no reset notification events will be provided by the implementation, or 
		/// Gl.LOSE_CONTEXT_ON_RESET, indicating that a reset will result in the loss of graphics context. This loss can be found by 
		/// querying Gl.GetGraphicsResetStatus.
		/// </summary>
		[AliasOf("GL_RESET_NOTIFICATION_STRATEGY_ARB")]
		[AliasOf("GL_RESET_NOTIFICATION_STRATEGY_EXT")]
		[AliasOf("GL_RESET_NOTIFICATION_STRATEGY_KHR")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		public const int RESET_NOTIFICATION_STRATEGY = 0x8256;

		/// <summary>
		/// [GL] Value of GL_LOSE_CONTEXT_ON_RESET symbol.
		/// </summary>
		[AliasOf("GL_LOSE_CONTEXT_ON_RESET_ARB")]
		[AliasOf("GL_LOSE_CONTEXT_ON_RESET_EXT")]
		[AliasOf("GL_LOSE_CONTEXT_ON_RESET_KHR")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		public const int LOSE_CONTEXT_ON_RESET = 0x8252;

		/// <summary>
		/// [GL] Value of GL_NO_RESET_NOTIFICATION symbol.
		/// </summary>
		[AliasOf("GL_NO_RESET_NOTIFICATION_ARB")]
		[AliasOf("GL_NO_RESET_NOTIFICATION_EXT")]
		[AliasOf("GL_NO_RESET_NOTIFICATION_KHR")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		public const int NO_RESET_NOTIFICATION = 0x8261;

		/// <summary>
		/// [GL] Value of GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT symbol.
		/// </summary>
		[AliasOf("GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		[Log(BitmaskName = "GL")]
		public const uint CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004;

		/// <summary>
		/// [GL] Value of GL_CONTEXT_RELEASE_BEHAVIOR symbol.
		/// </summary>
		[AliasOf("GL_CONTEXT_RELEASE_BEHAVIOR_KHR")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_context_flush_control", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_context_flush_control", Api = "gl|glcore|gles2")]
		public const int CONTEXT_RELEASE_BEHAVIOR = 0x82FB;

		/// <summary>
		/// [GL] Value of GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH symbol.
		/// </summary>
		[AliasOf("GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH_KHR")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_context_flush_control", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_context_flush_control", Api = "gl|glcore|gles2")]
		public const int CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC;

		/// <summary>
		/// control clip coordinate to window coordinate behavior
		/// </summary>
		/// <param name="origin">
		/// Specifies the clip control origin. Must be one of Gl.LOWER_LEFT or Gl.UPPER_LEFT.
		/// </param>
		/// <param name="depth">
		/// Specifies the clip control depth mode. Must be one of Gl.NEGATIVE_ONE_TO_ONE or Gl.ZERO_TO_ONE.
		/// </param>
		/// <exception cref="KhronosException">
		/// An Gl.INVALID_ENUM error is generated if <paramref name="origin"/> is not Gl.LOWER_LEFT or Gl.UPPER_LEFT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// An Gl.INVALID_ENUM error is generated if <paramref name="depth"/> is not Gl.NEGATIVE_ONE_TO_ONE or Gl.ZERO_TO_ONE.
		/// </exception>
		/// <seealso cref="Gl._ClipDistance"/>
		/// <seealso cref="Gl._CullDistance"/>
		/// <seealso cref="Gl._FrontFacing"/>
		/// <seealso cref="Gl.DepthRange"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_clip_control", Api = "gl|glcore")]
		public static void ClipControl(ClipControlOrigin origin, ClipControlDepth depth)
		{
			Debug.Assert(Delegates.pglClipControl != null, "pglClipControl not implemented");
			Delegates.pglClipControl((Int32)origin, (Int32)depth);
			LogCommand("glClipControl", null, origin, depth			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// create transform feedback objects
		/// </summary>
		/// <param name="n">
		/// Number of transform feedback objects to create.
		/// </param>
		/// <param name="ids">
		/// Specifies an array in which names of the new transform feedback objects are stored.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BeginTransformFeedback"/>
		/// <seealso cref="Gl.BindTransformFeedback"/>
		/// <seealso cref="Gl.DeleteTransformFeedbacks"/>
		/// <seealso cref="Gl.GenTransformFeedbacks"/>
		/// <seealso cref="Gl.IsTransformFeedback"/>
		/// <seealso cref="Gl.PauseTransformFeedback"/>
		/// <seealso cref="Gl.ResumeTransformFeedback"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void CreateTransformFeedbacks(Int32 n, UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglCreateTransformFeedbacks != null, "pglCreateTransformFeedbacks not implemented");
					Delegates.pglCreateTransformFeedbacks(n, p_ids);
					LogCommand("glCreateTransformFeedbacks", null, n, ids					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// bind a buffer object to a transform feedback buffer object
		/// </summary>
		/// <param name="xfb">
		/// Name of the transform feedback buffer object.
		/// </param>
		/// <param name="index">
		/// Index of the binding point within <paramref name="xfb"/>.
		/// </param>
		/// <param name="buffer">
		/// Name of the buffer object to bind to the specified binding point.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="xfb"/> is not the name of an existing transform feedback object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if in <paramref name="buffer"/> is not zero or the name of an existing buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the number of transform feedback 
		/// buffer binding points (the value of Gl.TRANSFORM_FEEDBACK_BUFFER_BINDING).
		/// </exception>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.TransformFeedbackBufferRange"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void TransformFeedbackBufferBase(UInt32 xfb, UInt32 index, UInt32 buffer)
		{
			Debug.Assert(Delegates.pglTransformFeedbackBufferBase != null, "pglTransformFeedbackBufferBase not implemented");
			Delegates.pglTransformFeedbackBufferBase(xfb, index, buffer);
			LogCommand("glTransformFeedbackBufferBase", null, xfb, index, buffer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// bind a range within a buffer object to a transform feedback buffer object
		/// </summary>
		/// <param name="xfb">
		/// Name of the transform feedback buffer object.
		/// </param>
		/// <param name="index">
		/// Index of the binding point within <paramref name="xfb"/>.
		/// </param>
		/// <param name="buffer">
		/// Name of the buffer object to bind to the specified binding point.
		/// </param>
		/// <param name="offset">
		/// The starting offset in basic machine units into the buffer object.
		/// </param>
		/// <param name="size">
		/// The amount of data in basic machine units that can be read from or written to the buffer object while used as an indexed 
		/// target.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="xfb"/> is not the name of an existing transform feedback object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if in <paramref name="buffer"/> is not zero or the name of an existing buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the number of transform feedback 
		/// buffer binding points (the value of Gl.TRANSFORM_FEEDBACK_BUFFER_BINDING).
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> is non-zero and either <paramref name="size"/> is less than 
		/// or equal to zero, or <paramref name="offset"/> + <paramref name="size"/> is greater than the value of Gl.BUFFER_SIZE for 
		/// <paramref name="buffer"/>.
		/// </exception>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.TransformFeedbackBufferBase"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void TransformFeedbackBufferRange(UInt32 xfb, UInt32 index, UInt32 buffer, IntPtr offset, UInt32 size)
		{
			Debug.Assert(Delegates.pglTransformFeedbackBufferRange != null, "pglTransformFeedbackBufferRange not implemented");
			Delegates.pglTransformFeedbackBufferRange(xfb, index, buffer, offset, size);
			LogCommand("glTransformFeedbackBufferRange", null, xfb, index, buffer, offset, size			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// query the state of a transform feedback object.
		/// </summary>
		/// <param name="xfb">
		/// The name of an existing transform feedback object, or zero for the default transform feedback object.
		/// </param>
		/// <param name="pname">
		/// Property to use for the query. Must be one of the values: Gl.TRANSFORM_FEEDBACK_BUFFER_BINDING, 
		/// Gl.TRANSFORM_FEEDBACK_BUFFER_START, Gl.TRANSFORM_FEEDBACK_BUFFER_SIZE, Gl.TRANSFORM_FEEDBACK_PAUSED, 
		/// Gl.TRANSFORM_FEEDBACK_ACTIVE.
		/// </param>
		/// <param name="param">
		/// The address of a buffer into which will be written the requested state information.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION error is generated if <paramref name="xfb"/> is not zero or the name of an existing transform 
		/// feedback object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM error is generated by Gl.GetTransformFeedbackiv if <paramref name="pname"/> is not 
		/// Gl.TRANSFORM_FEEDBACK_PAUSED or Gl.TRANSFORM_FEEDBACK_ACTIVE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM error is generated by Gl.GetTransformFeedbacki_v if <paramref name="pname"/> is not 
		/// Gl.TRANSFORM_FEEDBACK_BUFFER_BINDING.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM error is generated by Gl.GetTransformFeedbacki64_v if <paramref name="pname"/> is not 
		/// Gl.TRANSFORM_FEEDBACK_BUFFER_START or Gl.TRANSFORM_FEEDBACK_BUFFER_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated by Gl.GetTransformFeedbacki_v and Gl.GetTransformFeedbacki64_v if <paramref 
		/// name="index"/> is greater than or equal to the number of binding points for transform feedback (the value of 
		/// Gl.MAX_TRANSFORM_FEEDBACK_BUFFERS).
		/// </exception>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.BindBuffersBase"/>
		/// <seealso cref="Gl.BindBuffersRange"/>
		/// <seealso cref="Gl.BindTransformFeedback"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetTransformFeedback(UInt32 xfb, TransformFeedbackPName pname, [Out] Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglGetTransformFeedbackiv != null, "pglGetTransformFeedbackiv not implemented");
					Delegates.pglGetTransformFeedbackiv(xfb, (Int32)pname, p_param);
					LogCommand("glGetTransformFeedbackiv", null, xfb, pname, param					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// query the state of a transform feedback object.
		/// </summary>
		/// <param name="xfb">
		/// The name of an existing transform feedback object, or zero for the default transform feedback object.
		/// </param>
		/// <param name="pname">
		/// Property to use for the query. Must be one of the values: Gl.TRANSFORM_FEEDBACK_BUFFER_BINDING, 
		/// Gl.TRANSFORM_FEEDBACK_BUFFER_START, Gl.TRANSFORM_FEEDBACK_BUFFER_SIZE, Gl.TRANSFORM_FEEDBACK_PAUSED, 
		/// Gl.TRANSFORM_FEEDBACK_ACTIVE.
		/// </param>
		/// <param name="index">
		/// Index of the transform feedback stream (for indexed state).
		/// </param>
		/// <param name="param">
		/// The address of a buffer into which will be written the requested state information.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION error is generated if <paramref name="xfb"/> is not zero or the name of an existing transform 
		/// feedback object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM error is generated by Gl.GetTransformFeedbackiv if <paramref name="pname"/> is not 
		/// Gl.TRANSFORM_FEEDBACK_PAUSED or Gl.TRANSFORM_FEEDBACK_ACTIVE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM error is generated by Gl.GetTransformFeedbacki_v if <paramref name="pname"/> is not 
		/// Gl.TRANSFORM_FEEDBACK_BUFFER_BINDING.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM error is generated by Gl.GetTransformFeedbacki64_v if <paramref name="pname"/> is not 
		/// Gl.TRANSFORM_FEEDBACK_BUFFER_START or Gl.TRANSFORM_FEEDBACK_BUFFER_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated by Gl.GetTransformFeedbacki_v and Gl.GetTransformFeedbacki64_v if <paramref 
		/// name="index"/> is greater than or equal to the number of binding points for transform feedback (the value of 
		/// Gl.MAX_TRANSFORM_FEEDBACK_BUFFERS).
		/// </exception>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.BindBuffersBase"/>
		/// <seealso cref="Gl.BindBuffersRange"/>
		/// <seealso cref="Gl.BindTransformFeedback"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetTransformFeedback(UInt32 xfb, TransformFeedbackPName pname, UInt32 index, [Out] Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglGetTransformFeedbacki_v != null, "pglGetTransformFeedbacki_v not implemented");
					Delegates.pglGetTransformFeedbacki_v(xfb, (Int32)pname, index, p_param);
					LogCommand("glGetTransformFeedbacki_v", null, xfb, pname, index, param					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// query the state of a transform feedback object.
		/// </summary>
		/// <param name="xfb">
		/// The name of an existing transform feedback object, or zero for the default transform feedback object.
		/// </param>
		/// <param name="pname">
		/// Property to use for the query. Must be one of the values: Gl.TRANSFORM_FEEDBACK_BUFFER_BINDING, 
		/// Gl.TRANSFORM_FEEDBACK_BUFFER_START, Gl.TRANSFORM_FEEDBACK_BUFFER_SIZE, Gl.TRANSFORM_FEEDBACK_PAUSED, 
		/// Gl.TRANSFORM_FEEDBACK_ACTIVE.
		/// </param>
		/// <param name="index">
		/// Index of the transform feedback stream (for indexed state).
		/// </param>
		/// <param name="param">
		/// The address of a buffer into which will be written the requested state information.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION error is generated if <paramref name="xfb"/> is not zero or the name of an existing transform 
		/// feedback object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM error is generated by Gl.GetTransformFeedbackiv if <paramref name="pname"/> is not 
		/// Gl.TRANSFORM_FEEDBACK_PAUSED or Gl.TRANSFORM_FEEDBACK_ACTIVE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM error is generated by Gl.GetTransformFeedbacki_v if <paramref name="pname"/> is not 
		/// Gl.TRANSFORM_FEEDBACK_BUFFER_BINDING.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM error is generated by Gl.GetTransformFeedbacki64_v if <paramref name="pname"/> is not 
		/// Gl.TRANSFORM_FEEDBACK_BUFFER_START or Gl.TRANSFORM_FEEDBACK_BUFFER_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated by Gl.GetTransformFeedbacki_v and Gl.GetTransformFeedbacki64_v if <paramref 
		/// name="index"/> is greater than or equal to the number of binding points for transform feedback (the value of 
		/// Gl.MAX_TRANSFORM_FEEDBACK_BUFFERS).
		/// </exception>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.BindBuffersBase"/>
		/// <seealso cref="Gl.BindBuffersRange"/>
		/// <seealso cref="Gl.BindTransformFeedback"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetTransformFeedback(UInt32 xfb, TransformFeedbackPName pname, UInt32 index, [Out] Int64[] param)
		{
			unsafe {
				fixed (Int64* p_param = param)
				{
					Debug.Assert(Delegates.pglGetTransformFeedbacki64_v != null, "pglGetTransformFeedbacki64_v not implemented");
					Delegates.pglGetTransformFeedbacki64_v(xfb, (Int32)pname, index, p_param);
					LogCommand("glGetTransformFeedbacki64_v", null, xfb, pname, index, param					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// create buffer objects
		/// </summary>
		/// <param name="n">
		/// Specifies the number of buffer objects to create.
		/// </param>
		/// <param name="buffers">
		/// Specifies an array in which names of the new buffer objects are stored.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.IsBuffer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void CreateBuffers(Int32 n, UInt32[] buffers)
		{
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				{
					Debug.Assert(Delegates.pglCreateBuffers != null, "pglCreateBuffers not implemented");
					Delegates.pglCreateBuffers(n, p_buffers);
					LogCommand("glCreateBuffers", null, n, buffers					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// creates and initializes a buffer object's immutable data store
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for Gl.NamedBufferStorage function.
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the buffer object's new data store.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to data that will be copied into the data store for initialization, or Gl.L if no data is to be 
		/// copied.
		/// </param>
		/// <param name="flags">
		/// Specifies the intended usage of the buffer's data store. Must be a bitwise combination of the following flags. 
		/// Gl.DYNAMIC_STORAGE_BIT, Gl.MAP_READ_BITGl.MAP_WRITE_BIT, Gl.MAP_PERSISTENT_BIT, Gl.MAP_COHERENT_BIT, and 
		/// Gl.CLIENT_STORAGE_BIT.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.BufferStorage if <paramref name="target"/> is not one of the accepted buffer targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedBufferStorage if buffer is not the name of an existing buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is less than or equal to zero.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.BufferStorage if the reserved buffer object name 0 is bound to <paramref 
		/// name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.OUT_OF_MEMORY is generated if the GL is unable to create a data store with the properties requested in <paramref 
		/// name="flags"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="flags"/> has any bits set other than those defined above.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated if <paramref name="flags"/> contains Gl.MAP_PERSISTENT_BIT but does not contain at 
		/// least one of Gl.MAP_READ_BIT or Gl.MAP_WRITE_BIT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="flags"/> contains Gl.MAP_COHERENT_BIT, but does not also contain 
		/// Gl.MAP_PERSISTENT_BIT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.BufferStorage if the Gl.BUFFER_IMMUTABLE_STORAGE flag of the buffer bound to 
		/// <paramref name="target"/> is Gl.TRUE.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[AliasOf("glNamedBufferStorageEXT")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedBufferStorage(UInt32 buffer, UInt32 size, IntPtr data, UInt32 flags)
		{
			Debug.Assert(Delegates.pglNamedBufferStorage != null, "pglNamedBufferStorage not implemented");
			Delegates.pglNamedBufferStorage(buffer, size, data, flags);
			LogCommand("glNamedBufferStorage", null, buffer, size, data, flags			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// creates and initializes a buffer object's immutable data store
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for Gl.NamedBufferStorage function.
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the buffer object's new data store.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to data that will be copied into the data store for initialization, or Gl.L if no data is to be 
		/// copied.
		/// </param>
		/// <param name="flags">
		/// Specifies the intended usage of the buffer's data store. Must be a bitwise combination of the following flags. 
		/// Gl.DYNAMIC_STORAGE_BIT, Gl.MAP_READ_BITGl.MAP_WRITE_BIT, Gl.MAP_PERSISTENT_BIT, Gl.MAP_COHERENT_BIT, and 
		/// Gl.CLIENT_STORAGE_BIT.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.BufferStorage if <paramref name="target"/> is not one of the accepted buffer targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedBufferStorage if buffer is not the name of an existing buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is less than or equal to zero.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.BufferStorage if the reserved buffer object name 0 is bound to <paramref 
		/// name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.OUT_OF_MEMORY is generated if the GL is unable to create a data store with the properties requested in <paramref 
		/// name="flags"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="flags"/> has any bits set other than those defined above.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated if <paramref name="flags"/> contains Gl.MAP_PERSISTENT_BIT but does not contain at 
		/// least one of Gl.MAP_READ_BIT or Gl.MAP_WRITE_BIT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="flags"/> contains Gl.MAP_COHERENT_BIT, but does not also contain 
		/// Gl.MAP_PERSISTENT_BIT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.BufferStorage if the Gl.BUFFER_IMMUTABLE_STORAGE flag of the buffer bound to 
		/// <paramref name="target"/> is Gl.TRUE.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[AliasOf("glNamedBufferStorageEXT")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedBufferStorage(UInt32 buffer, UInt32 size, Object data, UInt32 flags)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				NamedBufferStorage(buffer, size, pin_data.AddrOfPinnedObject(), flags);
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// creates and initializes a buffer object's data store
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for Gl.NamedBufferData function.
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the buffer object's new data store.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to data that will be copied into the data store for initialization, or Gl.L if no data is to be 
		/// copied.
		/// </param>
		/// <param name="usage">
		/// Specifies the expected usage pattern of the data store. The symbolic constant must be Gl.STREAM_DRAW, Gl.STREAM_READ, 
		/// Gl.STREAM_COPY, Gl.STATIC_DRAW, Gl.STATIC_READ, Gl.STATIC_COPY, Gl.DYNAMIC_DRAW, Gl.DYNAMIC_READ, or Gl.DYNAMIC_COPY.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.BufferData if <paramref name="target"/> is not one of the accepted buffer targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="usage"/> is not Gl.STREAM_DRAW, Gl.STREAM_READ, Gl.STREAM_COPY, 
		/// Gl.STATIC_DRAW, Gl.STATIC_READ, Gl.STATIC_COPY, Gl.DYNAMIC_DRAW, Gl.DYNAMIC_READ, or Gl.DYNAMIC_COPY.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.BufferData if the reserved buffer object name 0 is bound to <paramref 
		/// name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedBufferData if buffer is not the name of an existing buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the Gl.BUFFER_IMMUTABLE_STORAGE flag of the buffer object is Gl.TRUE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.OUT_OF_MEMORY is generated if the GL is unable to create a data store with the specified <paramref name="size"/>.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void NamedBufferData(UInt32 buffer, UInt32 size, IntPtr data, VertexBufferObjectUsage usage)
		{
			Debug.Assert(Delegates.pglNamedBufferData != null, "pglNamedBufferData not implemented");
			Delegates.pglNamedBufferData(buffer, size, data, (Int32)usage);
			LogCommand("glNamedBufferData", null, buffer, size, data, usage			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// creates and initializes a buffer object's data store
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for Gl.NamedBufferData function.
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the buffer object's new data store.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to data that will be copied into the data store for initialization, or Gl.L if no data is to be 
		/// copied.
		/// </param>
		/// <param name="usage">
		/// Specifies the expected usage pattern of the data store. The symbolic constant must be Gl.STREAM_DRAW, Gl.STREAM_READ, 
		/// Gl.STREAM_COPY, Gl.STATIC_DRAW, Gl.STATIC_READ, Gl.STATIC_COPY, Gl.DYNAMIC_DRAW, Gl.DYNAMIC_READ, or Gl.DYNAMIC_COPY.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.BufferData if <paramref name="target"/> is not one of the accepted buffer targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="usage"/> is not Gl.STREAM_DRAW, Gl.STREAM_READ, Gl.STREAM_COPY, 
		/// Gl.STATIC_DRAW, Gl.STATIC_READ, Gl.STATIC_COPY, Gl.DYNAMIC_DRAW, Gl.DYNAMIC_READ, or Gl.DYNAMIC_COPY.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.BufferData if the reserved buffer object name 0 is bound to <paramref 
		/// name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedBufferData if buffer is not the name of an existing buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the Gl.BUFFER_IMMUTABLE_STORAGE flag of the buffer object is Gl.TRUE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.OUT_OF_MEMORY is generated if the GL is unable to create a data store with the specified <paramref name="size"/>.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void NamedBufferData(UInt32 buffer, UInt32 size, Object data, VertexBufferObjectUsage usage)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				NamedBufferData(buffer, size, pin_data.AddrOfPinnedObject(), usage);
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// updates a subset of a buffer object's data store
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for Gl.NamedBufferSubData.
		/// </param>
		/// <param name="offset">
		/// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the data store region being replaced.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the new data that will be copied into the data store.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.BufferSubData if <paramref name="target"/> is not one of the accepted buffer targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.BufferSubData if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedBufferSubData if <paramref name="buffer"/> is not the name of an existing 
		/// buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="size"/> is negative, or if $offset + size$ 
		/// is greater than the value of Gl.BUFFER_SIZE for the specified buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		/// glMapBufferRange or glMapBuffer, unless it was mapped with the Gl.MAP_PERSISTENT_BIT bit set in the 
		/// Gl.MapBufferRange<paramref name="access"/> flags.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the value of the Gl.BUFFER_IMMUTABLE_STORAGE flag of the buffer object is Gl.TRUE 
		/// and the value of Gl.BUFFER_STORAGE_FLAGS for the buffer object does not have the Gl.DYNAMIC_STORAGE_BIT bit set.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[AliasOf("glNamedBufferSubDataEXT")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedBufferSubData(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data)
		{
			Debug.Assert(Delegates.pglNamedBufferSubData != null, "pglNamedBufferSubData not implemented");
			Delegates.pglNamedBufferSubData(buffer, offset, size, data);
			LogCommand("glNamedBufferSubData", null, buffer, offset, size, data			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// updates a subset of a buffer object's data store
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for Gl.NamedBufferSubData.
		/// </param>
		/// <param name="offset">
		/// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the data store region being replaced.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the new data that will be copied into the data store.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.BufferSubData if <paramref name="target"/> is not one of the accepted buffer targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.BufferSubData if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedBufferSubData if <paramref name="buffer"/> is not the name of an existing 
		/// buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="size"/> is negative, or if $offset + size$ 
		/// is greater than the value of Gl.BUFFER_SIZE for the specified buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		/// glMapBufferRange or glMapBuffer, unless it was mapped with the Gl.MAP_PERSISTENT_BIT bit set in the 
		/// Gl.MapBufferRange<paramref name="access"/> flags.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the value of the Gl.BUFFER_IMMUTABLE_STORAGE flag of the buffer object is Gl.TRUE 
		/// and the value of Gl.BUFFER_STORAGE_FLAGS for the buffer object does not have the Gl.DYNAMIC_STORAGE_BIT bit set.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[AliasOf("glNamedBufferSubDataEXT")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
		public static void NamedBufferSubData(UInt32 buffer, IntPtr offset, UInt32 size, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				NamedBufferSubData(buffer, offset, size, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// copy all or part of the data store of a buffer object to the data store of another buffer object
		/// </summary>
		/// <param name="readBuffer">
		/// Specifies the name of the source buffer object for Gl.CopyNamedBufferSubData.
		/// </param>
		/// <param name="writeBuffer">
		/// Specifies the name of the destination buffer object for Gl.CopyNamedBufferSubData.
		/// </param>
		/// <param name="readOffset">
		/// Specifies the offset, in basic machine units, within the data store of the source buffer object at which data will be 
		/// read.
		/// </param>
		/// <param name="writeOffset">
		/// Specifies the offset, in basic machine units, within the data store of the destination buffer object at which data will 
		/// be written.
		/// </param>
		/// <param name="size">
		/// Specifies the size, in basic machine units, of the data to be copied from the source buffer object to the destination 
		/// buffer object.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.CopyBufferSubData if <paramref name="readTarget"/> or <paramref name="writeTarget"/> 
		/// is not one of the buffer binding targets listed above.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.CopyBufferSubData if zero is bound to <paramref name="readTarget"/> or <paramref 
		/// name="writeTarget"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.CopyNamedBufferSubData if <paramref name="readBuffer"/> or <paramref 
		/// name="writeBuffer"/> is not the name of an existing buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if any of <paramref name="readOffset"/>, <paramref name="writeOffset"/> or <paramref 
		/// name="size"/> is negative, if $readOffset + size$ is greater than the size of the source buffer object (its value of 
		/// Gl.BUFFER_SIZE), or if $writeOffset + size$ is greater than the size of the destination buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if the source and destination are the same buffer object, and the ranges 
		/// $[readOffset,readOffset+size)$ and $[writeOffset,writeOffset+size)$ overlap.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if either the source or destination buffer object is mapped with glMapBufferRange or 
		/// glMapBuffer, unless they were mapped with the Gl.MAP_PERSISTENT bit set in the Gl.MapBufferRange<paramref 
		/// name="access"/> flags.
		/// </exception>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void CopyNamedBufferSubData(UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, UInt32 size)
		{
			Debug.Assert(Delegates.pglCopyNamedBufferSubData != null, "pglCopyNamedBufferSubData not implemented");
			Delegates.pglCopyNamedBufferSubData(readBuffer, writeBuffer, readOffset, writeOffset, size);
			LogCommand("glCopyNamedBufferSubData", null, readBuffer, writeBuffer, readOffset, writeOffset, size			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// fill a buffer object's data store with a fixed value
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for Gl.ClearNamedBufferData.
		/// </param>
		/// <param name="internalformat">
		/// The internal format with which the data will be stored in the buffer object.
		/// </param>
		/// <param name="format">
		/// The format of the data in memory addressed by <paramref name="data"/>.
		/// </param>
		/// <param name="type">
		/// The type of the data in memory addressed by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// The address of a memory location storing the data to be replicated into the buffer's data store.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferData if <paramref name="target"/> is not one of the generic buffer binding 
		/// targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated by Gl.ClearBufferData if no buffer is bound <paramref name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.ClearNamedBufferData if <paramref name="buffer"/> is not the name of an existing 
		/// buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the valid sized internal formats listed 
		/// in the table above.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		/// glMapBufferRange or glMapBuffer, unless it was mapped with the Gl.MAP_PERSISTENT_BIT bit set in the 
		/// Gl.MapBufferRange<paramref name="access"/> flags.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="format"/> is not a valid format, or <paramref name="type"/> is not a 
		/// valid type.
		/// </exception>
		/// <seealso cref="Gl.ClearBufferSubData"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void ClearNamedBufferData(UInt32 buffer, InternalFormat internalformat, PixelFormat format, PixelType type, IntPtr data)
		{
			Debug.Assert(Delegates.pglClearNamedBufferData != null, "pglClearNamedBufferData not implemented");
			Delegates.pglClearNamedBufferData(buffer, (Int32)internalformat, (Int32)format, (Int32)type, data);
			LogCommand("glClearNamedBufferData", null, buffer, internalformat, format, type, data			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// fill a buffer object's data store with a fixed value
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for Gl.ClearNamedBufferData.
		/// </param>
		/// <param name="internalformat">
		/// The internal format with which the data will be stored in the buffer object.
		/// </param>
		/// <param name="format">
		/// The format of the data in memory addressed by <paramref name="data"/>.
		/// </param>
		/// <param name="type">
		/// The type of the data in memory addressed by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// The address of a memory location storing the data to be replicated into the buffer's data store.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferData if <paramref name="target"/> is not one of the generic buffer binding 
		/// targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated by Gl.ClearBufferData if no buffer is bound <paramref name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.ClearNamedBufferData if <paramref name="buffer"/> is not the name of an existing 
		/// buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the valid sized internal formats listed 
		/// in the table above.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		/// glMapBufferRange or glMapBuffer, unless it was mapped with the Gl.MAP_PERSISTENT_BIT bit set in the 
		/// Gl.MapBufferRange<paramref name="access"/> flags.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="format"/> is not a valid format, or <paramref name="type"/> is not a 
		/// valid type.
		/// </exception>
		/// <seealso cref="Gl.ClearBufferSubData"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void ClearNamedBufferData(UInt32 buffer, InternalFormat internalformat, PixelFormat format, PixelType type, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				ClearNamedBufferData(buffer, internalformat, format, type, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// fill all or part of buffer object's data store with a fixed value
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for Gl.ClearNamedBufferSubData.
		/// </param>
		/// <param name="internalformat">
		/// The internal format with which the data will be stored in the buffer object.
		/// </param>
		/// <param name="offset">
		/// The offset in basic machine units into the buffer object's data store at which to start filling.
		/// </param>
		/// <param name="size">
		/// The size in basic machine units of the range of the data store to fill.
		/// </param>
		/// <param name="format">
		/// The format of the data in memory addressed by <paramref name="data"/>.
		/// </param>
		/// <param name="type">
		/// The type of the data in memory addressed by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// The address of a memory location storing the data to be replicated into the buffer's data store.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferSubData if <paramref name="target"/> is not one of the generic buffer 
		/// binding targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated by Gl.ClearBufferSubData if no buffer is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.ClearNamedBufferSubData if <paramref name="buffer"/> is not the name of an 
		/// existing buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the valid sized internal formats listed 
		/// in the table above.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="range"/> are not multiples of the number 
		/// of basic machine units per-element for the internal format specified by <paramref name="internalformat"/>. This value 
		/// may be computed by multiplying the number of components for <paramref name="internalformat"/> from the table by the size 
		/// of the base type from the table.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="size"/> is negative, or if $offset + size$ 
		/// is greater than the value of Gl.BUFFER_SIZE for the buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		/// glMapBufferRange or glMapBuffer, unless it was mapped with the Gl.MAP_PERSISTENT_BIT bit set in the 
		/// Gl.MapBufferRange<paramref name="access"/> flags.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="format"/> is not a valid format, or <paramref name="type"/> is not a 
		/// valid type.
		/// </exception>
		/// <seealso cref="Gl.ClearBufferData"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void ClearNamedBufferSubData(UInt32 buffer, InternalFormat internalformat, IntPtr offset, UInt32 size, PixelFormat format, PixelType type, IntPtr data)
		{
			Debug.Assert(Delegates.pglClearNamedBufferSubData != null, "pglClearNamedBufferSubData not implemented");
			Delegates.pglClearNamedBufferSubData(buffer, (Int32)internalformat, offset, size, (Int32)format, (Int32)type, data);
			LogCommand("glClearNamedBufferSubData", null, buffer, internalformat, offset, size, format, type, data			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// fill all or part of buffer object's data store with a fixed value
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for Gl.ClearNamedBufferSubData.
		/// </param>
		/// <param name="internalformat">
		/// The internal format with which the data will be stored in the buffer object.
		/// </param>
		/// <param name="offset">
		/// The offset in basic machine units into the buffer object's data store at which to start filling.
		/// </param>
		/// <param name="size">
		/// The size in basic machine units of the range of the data store to fill.
		/// </param>
		/// <param name="format">
		/// The format of the data in memory addressed by <paramref name="data"/>.
		/// </param>
		/// <param name="type">
		/// The type of the data in memory addressed by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// The address of a memory location storing the data to be replicated into the buffer's data store.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferSubData if <paramref name="target"/> is not one of the generic buffer 
		/// binding targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated by Gl.ClearBufferSubData if no buffer is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.ClearNamedBufferSubData if <paramref name="buffer"/> is not the name of an 
		/// existing buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the valid sized internal formats listed 
		/// in the table above.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="range"/> are not multiples of the number 
		/// of basic machine units per-element for the internal format specified by <paramref name="internalformat"/>. This value 
		/// may be computed by multiplying the number of components for <paramref name="internalformat"/> from the table by the size 
		/// of the base type from the table.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="size"/> is negative, or if $offset + size$ 
		/// is greater than the value of Gl.BUFFER_SIZE for the buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		/// glMapBufferRange or glMapBuffer, unless it was mapped with the Gl.MAP_PERSISTENT_BIT bit set in the 
		/// Gl.MapBufferRange<paramref name="access"/> flags.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="format"/> is not a valid format, or <paramref name="type"/> is not a 
		/// valid type.
		/// </exception>
		/// <seealso cref="Gl.ClearBufferData"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void ClearNamedBufferSubData(UInt32 buffer, InternalFormat internalformat, IntPtr offset, UInt32 size, PixelFormat format, PixelType type, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// map all of a buffer object's data store into the client's address space
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for Gl.MapNamedBuffer.
		/// </param>
		/// <param name="access">
		/// Specifies the access policy for Gl.MapBuffer and Gl.MapNamedBuffer, indicating whether it will be possible to read from, 
		/// write to, or both read from and write to the buffer object's mapped data store. The symbolic constant must be 
		/// Gl.READ_ONLY, Gl.WRITE_ONLY, or Gl.READ_WRITE.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.MapBuffer if <paramref name="target"/> is not one of the buffer binding targets 
		/// listed above.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.MapBuffer if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.MapNamedBuffer if <paramref name="buffer"/> is not the name of an existing 
		/// buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="access"/> is not Gl.READ_ONLY, Gl.WRITE_ONLY, or Gl.READ_WRITE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.OUT_OF_MEMORY is generated if the GL is unable to map the buffer object's data store. This may occur for a variety of 
		/// system-specific reasons, such as the absence of sufficient remaining virtual memory.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the buffer object is in a mapped state.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static IntPtr MapNamedBuffer(UInt32 buffer, BufferAccess access)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglMapNamedBuffer != null, "pglMapNamedBuffer not implemented");
			retValue = Delegates.pglMapNamedBuffer(buffer, (Int32)access);
			LogCommand("glMapNamedBuffer", retValue, buffer, access			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// map all or part of a buffer object's data store into the client's address space
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for Gl.MapNamedBufferRange.
		/// </param>
		/// <param name="offset">
		/// Specifies the starting offset within the buffer of the range to be mapped.
		/// </param>
		/// <param name="length">
		/// Specifies the length of the range to be mapped.
		/// </param>
		/// <param name="access">
		/// Specifies a combination of access flags indicating the desired access to the mapped range.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.MapBufferRange if <paramref name="target"/> is not one of the buffer binding targets 
		/// listed above.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.MapBufferRange if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.MapNamedBufferRange if <paramref name="buffer"/> is not the name of an existing 
		/// buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="length"/> is negative, if $offset + 
		/// length$ is greater than the value of Gl.BUFFER_SIZE for the buffer object, or if <paramref name="access"/> has any bits 
		/// set other than those defined above.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated for any of the following conditions: <paramref name="length"/> is zero. The buffer 
		/// object is already in a mapped state. Neither Gl.MAP_READ_BIT nor Gl.MAP_WRITE_BIT is set. Gl.MAP_READ_BIT is set and any 
		/// of Gl.MAP_INVALIDATE_RANGE_BIT, Gl.MAP_INVALIDATE_BUFFER_BIT or Gl.MAP_UNSYNCHRONIZED_BIT is set. 
		/// Gl.MAP_FLUSH_EXPLICIT_BIT is set and Gl.MAP_WRITE_BIT is not set. Any of Gl.MAP_READ_BIT, Gl.MAP_WRITE_BIT, 
		/// Gl.MAP_PERSISTENT_BIT, or Gl.MAP_COHERENT_BIT are set, but the same bit is not included in the buffer's storage flags.
		/// </exception>
		/// <exception cref="KhronosException">
		/// No error is generated if memory outside the mapped range is modified or queried, but the result is undefined and system 
		/// errors (possibly including program termination) may occur.
		/// </exception>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		/// <seealso cref="Gl.FlushMappedBufferRange"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferStorage"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static IntPtr MapNamedBufferRange(UInt32 buffer, IntPtr offset, UInt32 length, UInt32 access)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglMapNamedBufferRange != null, "pglMapNamedBufferRange not implemented");
			retValue = Delegates.pglMapNamedBufferRange(buffer, offset, length, access);
			LogCommand("glMapNamedBufferRange", retValue, buffer, offset, length, access			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// release the mapping of a buffer object's data store into the client's address space
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for Gl.UnmapNamedBuffer.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.UnmapBuffer if <paramref name="target"/> is not one of the buffer binding targets 
		/// listed above.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.UnmapBuffer if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.UnmapNamedBuffer if <paramref name="buffer"/> is not the name of an existing 
		/// buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the buffer object is not in a mapped state.
		/// </exception>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static bool UnmapNamedBuffer(UInt32 buffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglUnmapNamedBuffer != null, "pglUnmapNamedBuffer not implemented");
			retValue = Delegates.pglUnmapNamedBuffer(buffer);
			LogCommand("glUnmapNamedBuffer", retValue, buffer			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// indicate modifications to a range of a mapped buffer
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for Gl.FlushMappedNamedBufferRange.
		/// </param>
		/// <param name="offset">
		/// Specifies the start of the buffer subrange, in basic machine units.
		/// </param>
		/// <param name="length">
		/// Specifies the length of the buffer subrange, in basic machine units.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.FlushMappedBufferRange if <paramref name="target"/> is not one of the buffer binding 
		/// targets listed above.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.FlushMappedBufferRange if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.FlushMappedNamedBufferRange if <paramref name="buffer"/> is not the name of an 
		/// existing buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="length"/> is negative, or if <paramref 
		/// name="offset"/> + <paramref name="length"/> exceeds the size of the mapping.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the buffer object is not mapped, or is mapped without the Gl.MAP_FLUSH_EXPLICIT_BIT 
		/// flag.
		/// </exception>
		/// <seealso cref="Gl.MapBufferRange"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void FlushMappedNamedBufferRange(UInt32 buffer, IntPtr offset, UInt32 length)
		{
			Debug.Assert(Delegates.pglFlushMappedNamedBufferRange != null, "pglFlushMappedNamedBufferRange not implemented");
			Delegates.pglFlushMappedNamedBufferRange(buffer, offset, length);
			LogCommand("glFlushMappedNamedBufferRange", null, buffer, offset, length			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return parameters of a buffer object
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for Gl.GetNamedBufferParameteriv and Gl.GetNamedBufferParameteri64v.
		/// </param>
		/// <param name="value">
		/// Specifies the name of the buffer object parameter to query.
		/// </param>
		/// <param name="data">
		/// Returns the requested parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.GetBufferParameter* if <paramref name="target"/> is not one of the accepted buffer 
		/// targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetBufferParameter* if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetNamedBufferParameter* if <paramref name="buffer"/> is not the name of an 
		/// existing buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the buffer object parameter names described 
		/// above.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedBufferParameter(UInt32 buffer, VertexBufferObjectParameter value, [Out] Int32[] data)
		{
			unsafe {
				fixed (Int32* p_params = data)
				{
					Debug.Assert(Delegates.pglGetNamedBufferParameteriv != null, "pglGetNamedBufferParameteriv not implemented");
					Delegates.pglGetNamedBufferParameteriv(buffer, (Int32)value, p_params);
					LogCommand("glGetNamedBufferParameteriv", null, buffer, value, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return parameters of a buffer object
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for Gl.GetNamedBufferParameteriv and Gl.GetNamedBufferParameteri64v.
		/// </param>
		/// <param name="value">
		/// Specifies the name of the buffer object parameter to query.
		/// </param>
		/// <param name="data">
		/// Returns the requested parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.GetBufferParameter* if <paramref name="target"/> is not one of the accepted buffer 
		/// targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetBufferParameter* if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetNamedBufferParameter* if <paramref name="buffer"/> is not the name of an 
		/// existing buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the buffer object parameter names described 
		/// above.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedBufferParameter(UInt32 buffer, VertexBufferObjectParameter value, [Out] Int64[] data)
		{
			unsafe {
				fixed (Int64* p_params = data)
				{
					Debug.Assert(Delegates.pglGetNamedBufferParameteri64v != null, "pglGetNamedBufferParameteri64v not implemented");
					Delegates.pglGetNamedBufferParameteri64v(buffer, (Int32)value, p_params);
					LogCommand("glGetNamedBufferParameteri64v", null, buffer, value, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the pointer to a mapped buffer object's data store
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for Gl.GetNamedBufferPointerv.
		/// </param>
		/// <param name="pname">
		/// Specifies the name of the pointer to be returned. Must be Gl.BUFFER_MAP_POINTER.
		/// </param>
		/// <param name="params">
		/// Returns the pointer value specified by <paramref name="pname"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if by Gl.GetBufferPointerv if <paramref name="target"/> is not one of the accepted buffer 
		/// targets, or if <paramref name="pname"/> is not Gl.BUFFER_MAP_POINTER.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetBufferPointerv if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetNamedBufferPointerv if <paramref name="buffer"/> is not the name of an 
		/// existing buffer object.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.MapBuffer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedBufferPointer(UInt32 buffer, VertexBufferObjectParameter pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetNamedBufferPointerv != null, "pglGetNamedBufferPointerv not implemented");
					Delegates.pglGetNamedBufferPointerv(buffer, (Int32)pname, p_params);
					LogCommand("glGetNamedBufferPointerv", null, buffer, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// returns a subset of a buffer object's data store
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for Gl.GetNamedBufferSubData.
		/// </param>
		/// <param name="offset">
		/// Specifies the offset into the buffer object's data store from which data will be returned, measured in bytes.
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the data store region being returned.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the location where buffer object data is returned.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.GetBufferSubData if <paramref name="target"/> is not one of the generic buffer 
		/// binding targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetBufferSubData if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetNamedBufferSubData if <paramref name="buffer"/> is not the name of an 
		/// existing buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="size"/> is negative, or if $offset + size$ 
		/// is greater than the value of Gl.BUFFER_SIZE for the buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the buffer object is mapped with glMapBufferRange or glMapBuffer, unless it was 
		/// mapped with the Gl.MAP_PERSISTENT_BIT bit set in the Gl.MapBufferRange<paramref name="access"/> flags.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedBufferSubData(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data)
		{
			Debug.Assert(Delegates.pglGetNamedBufferSubData != null, "pglGetNamedBufferSubData not implemented");
			Delegates.pglGetNamedBufferSubData(buffer, offset, size, data);
			LogCommand("glGetNamedBufferSubData", null, buffer, offset, size, data			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// returns a subset of a buffer object's data store
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for Gl.GetNamedBufferSubData.
		/// </param>
		/// <param name="offset">
		/// Specifies the offset into the buffer object's data store from which data will be returned, measured in bytes.
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the data store region being returned.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the location where buffer object data is returned.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.GetBufferSubData if <paramref name="target"/> is not one of the generic buffer 
		/// binding targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetBufferSubData if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetNamedBufferSubData if <paramref name="buffer"/> is not the name of an 
		/// existing buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="size"/> is negative, or if $offset + size$ 
		/// is greater than the value of Gl.BUFFER_SIZE for the buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the buffer object is mapped with glMapBufferRange or glMapBuffer, unless it was 
		/// mapped with the Gl.MAP_PERSISTENT_BIT bit set in the Gl.MapBufferRange<paramref name="access"/> flags.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedBufferSubData(UInt32 buffer, IntPtr offset, UInt32 size, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				GetNamedBufferSubData(buffer, offset, size, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// create framebuffer objects
		/// </summary>
		/// <param name="n">
		/// Number of framebuffer objects to create.
		/// </param>
		/// <param name="framebuffers">
		/// Specifies an array in which names of the new framebuffer objects are stored.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		/// <seealso cref="Gl.FramebufferTextureLayer"/>
		/// <seealso cref="Gl.DeleteFramebuffers"/>
		/// <seealso cref="Gl.IsFramebuffer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void CreateFramebuffers(Int32 n, UInt32[] framebuffers)
		{
			unsafe {
				fixed (UInt32* p_framebuffers = framebuffers)
				{
					Debug.Assert(Delegates.pglCreateFramebuffers != null, "pglCreateFramebuffers not implemented");
					Delegates.pglCreateFramebuffers(n, p_framebuffers);
					LogCommand("glCreateFramebuffers", null, n, framebuffers					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// attach a renderbuffer as a logical buffer of a framebuffer object
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for Gl.NamedFramebufferRenderbuffer.
		/// </param>
		/// <param name="attachment">
		/// Specifies the attachment point of the framebuffer.
		/// </param>
		/// <param name="renderbuffertarget">
		/// Specifies the renderbuffer target. Must be Gl.RENDERBUFFER.
		/// </param>
		/// <param name="renderbuffer">
		/// Specifies the name of an existing renderbuffer object of type <paramref name="renderbuffertarget"/> to attach.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.FramebufferRenderbuffer if <paramref name="target"/> is not one of the accepted 
		/// framebuffer targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.FramebufferRenderbuffer if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedFramebufferRenderbuffer if <paramref name="framebuffer"/> is not the name 
		/// of an existing framebuffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="attachment"/> is not one of the accepted attachment points.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="renderbuffertarget"/> is not Gl.RENDERBUFFER.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="renderbuffertarget"/> is not zero or the name of an existing 
		/// renderbuffer object of type Gl.RENDERBUFFER.
		/// </exception>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void NamedFramebufferRenderbuffer(UInt32 framebuffer, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglNamedFramebufferRenderbuffer != null, "pglNamedFramebufferRenderbuffer not implemented");
			Delegates.pglNamedFramebufferRenderbuffer(framebuffer, (Int32)attachment, (Int32)renderbuffertarget, renderbuffer);
			LogCommand("glNamedFramebufferRenderbuffer", null, framebuffer, attachment, renderbuffertarget, renderbuffer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set a named parameter of a framebuffer object
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for Gl.NamedFramebufferParameteri.
		/// </param>
		/// <param name="pname">
		/// Specifies the framebuffer parameter to be modified.
		/// </param>
		/// <param name="param">
		/// The new value for the parameter named <paramref name="pname"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.FramebufferParameteri if <paramref name="target"/> is not one of the accepted 
		/// framebuffer targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.FramebufferParameteri if the default framebuffer is bound to <paramref 
		/// name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedFramebufferParameteri if <paramref name="framebuffer"/> is not the name of 
		/// an existing framebuffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.FRAMEBUFFER_DEFAULT_WIDTH and <paramref name="param"/> 
		/// is less than zero or greater than the value of Gl.MAX_FRAMEBUFFER_WIDTH.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.FRAMEBUFFER_DEFAULT_HEIGHT and <paramref name="param"/> 
		/// is less than zero or greater than the value of Gl.MAX_FRAMEBUFFER_HEIGHT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.FRAMEBUFFER_DEFAULT_LAYERS and <paramref name="param"/> 
		/// is less than zero or greater than the value of Gl.MAX_FRAMEBUFFER_LAYERS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.FRAMEBUFFER_DEFAULT_SAMPLES and <paramref name="param"/> 
		/// is less than zero or greater than the value of Gl.MAX_FRAMEBUFFER_SAMPLES.
		/// </exception>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.CreateFramebuffers"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.GetFramebufferParameter"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void NamedFramebufferParameter(UInt32 framebuffer, FramebufferParameterName pname, Int32 param)
		{
			Debug.Assert(Delegates.pglNamedFramebufferParameteri != null, "pglNamedFramebufferParameteri not implemented");
			Delegates.pglNamedFramebufferParameteri(framebuffer, (Int32)pname, param);
			LogCommand("glNamedFramebufferParameteri", null, framebuffer, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// attach a level of a texture object as a logical buffer of a framebuffer object
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for Gl.NamedFramebufferTexture.
		/// </param>
		/// <param name="attachment">
		/// Specifies the attachment point of the framebuffer.
		/// </param>
		/// <param name="texture">
		/// Specifies the name of an existing texture object to attach.
		/// </param>
		/// <param name="level">
		/// Specifies the mipmap level of the texture object to attach.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by all commands accepting a <paramref name="target"/> parameter if it is not one of the 
		/// accepted framebuffer targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by all commands accepting a <paramref name="target"/> parameter if zero is bound to 
		/// that target.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedFramebufferTexture if <paramref name="framebuffer"/> is not the name of an 
		/// existing framebuffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="attachment"/> is not one of the accepted attachment points.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="texture"/> is not zero or the name of an existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="texture"/> is not zero and <paramref name="level"/> is not a supported 
		/// texture level for <paramref name="texture"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated by Gl.FramebufferTexture3D if <paramref name="texture"/> is not zero and <paramref 
		/// name="layer"/> is larger than the value of Gl.MAX_3D_TEXTURE_SIZE minus one.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by all commands accepting a <paramref name="textarget"/> parameter if <paramref 
		/// name="texture"/> is not zero, and <paramref name="textarget"/> and the effective target of <paramref name="texture"/> 
		/// are not compatible.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by if <paramref name="texture"/> is a buffer texture.
		/// </exception>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void NamedFramebufferTexture(UInt32 framebuffer, FramebufferAttachment attachment, UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglNamedFramebufferTexture != null, "pglNamedFramebufferTexture not implemented");
			Delegates.pglNamedFramebufferTexture(framebuffer, (Int32)attachment, texture, level);
			LogCommand("glNamedFramebufferTexture", null, framebuffer, attachment, texture, level			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// attach a single layer of a texture object as a logical buffer of a framebuffer object
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for Gl.NamedFramebufferTextureLayer.
		/// </param>
		/// <param name="attachment">
		/// Specifies the attachment point of the framebuffer.
		/// </param>
		/// <param name="texture">
		/// Specifies the name of an existing texture object to attach.
		/// </param>
		/// <param name="level">
		/// Specifies the mipmap level of the texture object to attach.
		/// </param>
		/// <param name="layer">
		/// Specifies the layer of the texture object to attach.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.FramebufferTexture if <paramref name="target"/> is not one of the accepted 
		/// framebuffer targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.FramebufferTexture if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedFramebufferTexture if <paramref name="framebuffer"/> is not the name of an 
		/// existing framebuffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="attachment"/> is not one of the accepted attachment points.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="texture"/> is not zero and is not the name of an existing 
		/// three-dimensional, two-dimensional multisample array, one- or two-dimensional array, cube map, or cube map array 
		/// texture.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="texture"/> is not zero and <paramref name="level"/> is not a supported 
		/// texture level for <paramref name="texture"/>, as described above.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="texture"/> is not zero and <paramref name="layer"/> is larger than the 
		/// value of Gl.MAX_3D_TEXTURE_SIZE minus one (for three-dimensional texture objects), or larger than the value of 
		/// Gl.MAX_ARRAY_TEXTURE_LAYERS minus one (for array texture objects).
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="texture"/> is not zero and <paramref name="layer"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by if <paramref name="texture"/> is a buffer texture.
		/// </exception>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void NamedFramebufferTextureLayer(UInt32 framebuffer, FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer)
		{
			Debug.Assert(Delegates.pglNamedFramebufferTextureLayer != null, "pglNamedFramebufferTextureLayer not implemented");
			Delegates.pglNamedFramebufferTextureLayer(framebuffer, (Int32)attachment, texture, level, layer);
			LogCommand("glNamedFramebufferTextureLayer", null, framebuffer, attachment, texture, level, layer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify which color buffers are to be drawn into
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for Gl.NamedFramebufferDrawBuffer function. Must be zero or the name of a 
		/// framebuffer object.
		/// </param>
		/// <param name="buf">
		/// For default framebuffer, the argument specifies up to four color buffers to be drawn into. Symbolic constants Gl.NONE, 
		/// Gl.FRONT_LEFT, Gl.FRONT_RIGHT, Gl.BACK_LEFT, Gl.BACK_RIGHT, Gl.FRONT, Gl.BACK, Gl.LEFT, Gl.RIGHT, and Gl.FRONT_AND_BACK 
		/// are accepted. The initial value is Gl.FRONT for single-buffered contexts, and Gl.BACK for double-buffered contexts. For 
		/// framebuffer objects, Gl.COLOR_ATTACHMENT$m$ and Gl.NONE enums are accepted, where Gl. is a value between 0 and 
		/// Gl.MAX_COLOR_ATTACHMENTS.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION error is generated by Gl.NamedFramebufferDrawBuffer if <paramref name="framebuffer"/> is not zero 
		/// or the name of an existing framebuffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="buf"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the default framebuffer is affected and none of the buffers indicated by <paramref 
		/// name="buf"/> exists.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a framebuffer object is affected and <paramref name="buf"/> is not equal to Gl.NONE 
		/// or Gl.COLOR_ATTACHMENT$m$, where Gl. is a value between 0 and Gl.MAX_COLOR_ATTACHMENTS.
		/// </exception>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DrawBuffers"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void NamedFramebufferDrawBuffer(UInt32 framebuffer, ColorBuffer buf)
		{
			Debug.Assert(Delegates.pglNamedFramebufferDrawBuffer != null, "pglNamedFramebufferDrawBuffer not implemented");
			Delegates.pglNamedFramebufferDrawBuffer(framebuffer, (Int32)buf);
			LogCommand("glNamedFramebufferDrawBuffer", null, framebuffer, buf			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies a list of color buffers to be drawn into
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for Gl.NamedFramebufferDrawBuffers.
		/// </param>
		/// <param name="n">
		/// Specifies the number of buffers in <paramref name="bufs"/>.
		/// </param>
		/// <param name="bufs">
		/// Points to an array of symbolic constants specifying the buffers into which fragment colors or data values will be 
		/// written.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION error is generated by Gl.NamedFramebufferDrawBuffers if <paramref name="framebuffer"/> is not zero 
		/// or the name of an existing framebuffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if one of the values in <paramref name="bufs"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if the API call refers to the default framebuffer and one or more of the values in 
		/// <paramref name="bufs"/> is one of the Gl.COLOR_ATTACHMENTn tokens.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if the API call refers to a framebuffer object and one or more of the values in <paramref 
		/// name="bufs"/> is anything other than Gl.NONE or one of the Gl.COLOR_ATTACHMENTn tokens.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="n"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a symbolic constant other than Gl.NONE appears more than once in <paramref 
		/// name="bufs"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if any of the entries in <paramref name="bufs"/> (other than Gl.NONE ) indicates a 
		/// color buffer that does not exist in the current GL context.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if any value in <paramref name="bufs"/> is Gl.BACK, and <paramref name="n"/> is not 
		/// one.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is greater than Gl.MAX_DRAW_BUFFERS.
		/// </exception>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DrawBuffers"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void NamedFramebufferDrawBuffers(UInt32 framebuffer, Int32 n, Int32[] bufs)
		{
			unsafe {
				fixed (Int32* p_bufs = bufs)
				{
					Debug.Assert(Delegates.pglNamedFramebufferDrawBuffers != null, "pglNamedFramebufferDrawBuffers not implemented");
					Delegates.pglNamedFramebufferDrawBuffers(framebuffer, n, p_bufs);
					LogCommand("glNamedFramebufferDrawBuffers", null, framebuffer, n, bufs					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// select a color buffer source for pixels
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for Gl.NamedFramebufferReadBuffer function.
		/// </param>
		/// <param name="mode">
		/// Specifies a color buffer. Accepted values are Gl.FRONT_LEFT, Gl.FRONT_RIGHT, Gl.BACK_LEFT, Gl.BACK_RIGHT, Gl.FRONT, 
		/// Gl.BACK, Gl.LEFT, Gl.RIGHT, and the constants Gl.COLOR_ATTACHMENTi.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not one of the twelve (or more) accepted values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="mode"/> specifies a buffer that does not exist.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedFramebufferReadBuffer if <paramref name="framebuffer"/> is not zero or the 
		/// name of an existing framebuffer object.
		/// </exception>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void NamedFramebufferReadBuffer(UInt32 framebuffer, ColorBuffer mode)
		{
			Debug.Assert(Delegates.pglNamedFramebufferReadBuffer != null, "pglNamedFramebufferReadBuffer not implemented");
			Delegates.pglNamedFramebufferReadBuffer(framebuffer, (Int32)mode);
			LogCommand("glNamedFramebufferReadBuffer", null, framebuffer, mode			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// invalidate the content of some or all of a framebuffer's attachments
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for Gl.InvalidateNamedFramebufferData.
		/// </param>
		/// <param name="numAttachments">
		/// Specifies the number of entries in the <paramref name="attachments"/> array.
		/// </param>
		/// <param name="attachments">
		/// Specifies a pointer to an array identifying the attachments to be invalidated.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.InvalidateFramebuffer if <paramref name="target"/> is not one of the accepted 
		/// framebuffer targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.InvalidateNamedFramebufferData if <paramref name="framebuffer"/> is not zero or 
		/// the name of an existing framebuffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="numAttachments"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if any element of <paramref name="attachments"/> is not one of the accepted framebuffer 
		/// attachment points, as described above.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if element of <paramref name="attachments"/> is Gl.COLOR_ATTACHMENTm where m is 
		/// greater than or equal to the value of Gl.MAX_COLOR_ATTACHMENTS.
		/// </exception>
		/// <seealso cref="Gl.InvalidateTexSubImage"/>
		/// <seealso cref="Gl.InvalidateTexImage"/>
		/// <seealso cref="Gl.InvalidateBufferSubData"/>
		/// <seealso cref="Gl.InvalidateBufferData"/>
		/// <seealso cref="Gl.InvalidateSubFramebuffer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void InvalidateNamedFramebufferData(UInt32 framebuffer, Int32 numAttachments, Int32[] attachments)
		{
			unsafe {
				fixed (Int32* p_attachments = attachments)
				{
					Debug.Assert(Delegates.pglInvalidateNamedFramebufferData != null, "pglInvalidateNamedFramebufferData not implemented");
					Delegates.pglInvalidateNamedFramebufferData(framebuffer, numAttachments, p_attachments);
					LogCommand("glInvalidateNamedFramebufferData", null, framebuffer, numAttachments, attachments					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// invalidate the content of a region of some or all of a framebuffer's attachments
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for Gl.InvalidateNamedFramebufferSubData.
		/// </param>
		/// <param name="numAttachments">
		/// Specifies the number of entries in the <paramref name="attachments"/> array.
		/// </param>
		/// <param name="attachments">
		/// Specifies a pointer to an array identifying the attachments to be invalidated.
		/// </param>
		/// <param name="x">
		/// Specifies the X offset of the region to be invalidated.
		/// </param>
		/// <param name="y">
		/// Specifies the Y offset of the region to be invalidated.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the region to be invalidated.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the region to be invalidated.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM by Gl.InvalidateSubFramebuffer if <paramref name="target"/> is not one of the accepted framebuffer 
		/// targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION by Gl.InvalidateNamedFramebufferSubData if <paramref name="framebuffer"/> is not zero of the name 
		/// of an existing framebuffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="numAttachments"/>, <paramref name="width"/> or <paramref 
		/// name="height"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if any element of <paramref name="attachments"/> is not one of the accepted framebuffer 
		/// attachment points, as described above.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if element of <paramref name="attachments"/> is Gl.COLOR_ATTACHMENTm where m is 
		/// greater than or equal to the value of Gl.MAX_COLOR_ATTACHMENTS.
		/// </exception>
		/// <seealso cref="Gl.InvalidateTexSubImage"/>
		/// <seealso cref="Gl.InvalidateTexImage"/>
		/// <seealso cref="Gl.InvalidateBufferSubData"/>
		/// <seealso cref="Gl.InvalidateBufferData"/>
		/// <seealso cref="Gl.InvalidateFramebuffer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void InvalidateNamedFramebufferSubData(UInt32 framebuffer, Int32 numAttachments, Int32[] attachments, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			unsafe {
				fixed (Int32* p_attachments = attachments)
				{
					Debug.Assert(Delegates.pglInvalidateNamedFramebufferSubData != null, "pglInvalidateNamedFramebufferSubData not implemented");
					Delegates.pglInvalidateNamedFramebufferSubData(framebuffer, numAttachments, p_attachments, x, y, width, height);
					LogCommand("glInvalidateNamedFramebufferSubData", null, framebuffer, numAttachments, attachments, x, y, width, height					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// clear individual buffers of a framebuffer
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for Gl.ClearNamedFramebuffer*.
		/// </param>
		/// <param name="buffer">
		/// Specify the buffer to clear.
		/// </param>
		/// <param name="drawbuffer">
		/// Specify a particular draw buffer to clear.
		/// </param>
		/// <param name="value">
		/// A pointer to the value or values to clear the buffer to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.ClearNamedFramebuffer* if <paramref name="framebuffer"/> is not zero or the name 
		/// of an existing framebuffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferiv and Gl.ClearNamedFramebufferiv<paramref name="buffer"/> is not Gl.COLOR 
		/// or Gl.STENCIL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferuiv and Gl.ClearNamedFramebufferuiv<paramref name="buffer"/> is not 
		/// Gl.COLOR.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferfv and Gl.ClearNamedFramebufferfv<paramref name="buffer"/> is not Gl.COLOR 
		/// or Gl.DEPTH.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferfi and Gl.ClearNamedFramebufferfi<paramref name="buffer"/> is not 
		/// Gl.DEPTH_STENCIL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> is Gl.COLOR<paramref name="drawbuffer"/> is negative, or 
		/// greater than the value of Gl.MAX_DRAW_BUFFERS minus one.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> is Gl.DEPTH, Gl.STENCIL or Gl.DEPTH_STENCIL and <paramref 
		/// name="drawbuffer"/> is not zero.
		/// </exception>
		/// <seealso cref="Gl.ClearColor"/>
		/// <seealso cref="Gl.ClearDepth"/>
		/// <seealso cref="Gl.ClearStencil"/>
		/// <seealso cref="Gl.Clear"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void ClearNamedFramebuffer(UInt32 framebuffer, Buffer buffer, Int32 drawbuffer, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglClearNamedFramebufferiv != null, "pglClearNamedFramebufferiv not implemented");
					Delegates.pglClearNamedFramebufferiv(framebuffer, (Int32)buffer, drawbuffer, p_value);
					LogCommand("glClearNamedFramebufferiv", null, framebuffer, buffer, drawbuffer, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// clear individual buffers of a framebuffer
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for Gl.ClearNamedFramebuffer*.
		/// </param>
		/// <param name="buffer">
		/// Specify the buffer to clear.
		/// </param>
		/// <param name="drawbuffer">
		/// Specify a particular draw buffer to clear.
		/// </param>
		/// <param name="value">
		/// A pointer to the value or values to clear the buffer to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.ClearNamedFramebuffer* if <paramref name="framebuffer"/> is not zero or the name 
		/// of an existing framebuffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferiv and Gl.ClearNamedFramebufferiv<paramref name="buffer"/> is not Gl.COLOR 
		/// or Gl.STENCIL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferuiv and Gl.ClearNamedFramebufferuiv<paramref name="buffer"/> is not 
		/// Gl.COLOR.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferfv and Gl.ClearNamedFramebufferfv<paramref name="buffer"/> is not Gl.COLOR 
		/// or Gl.DEPTH.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferfi and Gl.ClearNamedFramebufferfi<paramref name="buffer"/> is not 
		/// Gl.DEPTH_STENCIL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> is Gl.COLOR<paramref name="drawbuffer"/> is negative, or 
		/// greater than the value of Gl.MAX_DRAW_BUFFERS minus one.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> is Gl.DEPTH, Gl.STENCIL or Gl.DEPTH_STENCIL and <paramref 
		/// name="drawbuffer"/> is not zero.
		/// </exception>
		/// <seealso cref="Gl.ClearColor"/>
		/// <seealso cref="Gl.ClearDepth"/>
		/// <seealso cref="Gl.ClearStencil"/>
		/// <seealso cref="Gl.Clear"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void ClearNamedFramebuffer(UInt32 framebuffer, Buffer buffer, Int32 drawbuffer, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglClearNamedFramebufferuiv != null, "pglClearNamedFramebufferuiv not implemented");
					Delegates.pglClearNamedFramebufferuiv(framebuffer, (Int32)buffer, drawbuffer, p_value);
					LogCommand("glClearNamedFramebufferuiv", null, framebuffer, buffer, drawbuffer, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// clear individual buffers of a framebuffer
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for Gl.ClearNamedFramebuffer*.
		/// </param>
		/// <param name="buffer">
		/// Specify the buffer to clear.
		/// </param>
		/// <param name="drawbuffer">
		/// Specify a particular draw buffer to clear.
		/// </param>
		/// <param name="value">
		/// A pointer to the value or values to clear the buffer to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.ClearNamedFramebuffer* if <paramref name="framebuffer"/> is not zero or the name 
		/// of an existing framebuffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferiv and Gl.ClearNamedFramebufferiv<paramref name="buffer"/> is not Gl.COLOR 
		/// or Gl.STENCIL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferuiv and Gl.ClearNamedFramebufferuiv<paramref name="buffer"/> is not 
		/// Gl.COLOR.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferfv and Gl.ClearNamedFramebufferfv<paramref name="buffer"/> is not Gl.COLOR 
		/// or Gl.DEPTH.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferfi and Gl.ClearNamedFramebufferfi<paramref name="buffer"/> is not 
		/// Gl.DEPTH_STENCIL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> is Gl.COLOR<paramref name="drawbuffer"/> is negative, or 
		/// greater than the value of Gl.MAX_DRAW_BUFFERS minus one.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> is Gl.DEPTH, Gl.STENCIL or Gl.DEPTH_STENCIL and <paramref 
		/// name="drawbuffer"/> is not zero.
		/// </exception>
		/// <seealso cref="Gl.ClearColor"/>
		/// <seealso cref="Gl.ClearDepth"/>
		/// <seealso cref="Gl.ClearStencil"/>
		/// <seealso cref="Gl.Clear"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void ClearNamedFramebuffer(UInt32 framebuffer, Buffer buffer, Int32 drawbuffer, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglClearNamedFramebufferfv != null, "pglClearNamedFramebufferfv not implemented");
					Delegates.pglClearNamedFramebufferfv(framebuffer, (Int32)buffer, drawbuffer, p_value);
					LogCommand("glClearNamedFramebufferfv", null, framebuffer, buffer, drawbuffer, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// clear individual buffers of a framebuffer
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for Gl.ClearNamedFramebuffer*.
		/// </param>
		/// <param name="buffer">
		/// Specify the buffer to clear.
		/// </param>
		/// <param name="drawbuffer">
		/// Specify a particular draw buffer to clear.
		/// </param>
		/// <param name="depth">
		/// The value to clear the depth buffer to.
		/// </param>
		/// <param name="stencil">
		/// The value to clear the stencil buffer to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.ClearNamedFramebuffer* if <paramref name="framebuffer"/> is not zero or the name 
		/// of an existing framebuffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferiv and Gl.ClearNamedFramebufferiv<paramref name="buffer"/> is not Gl.COLOR 
		/// or Gl.STENCIL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferuiv and Gl.ClearNamedFramebufferuiv<paramref name="buffer"/> is not 
		/// Gl.COLOR.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferfv and Gl.ClearNamedFramebufferfv<paramref name="buffer"/> is not Gl.COLOR 
		/// or Gl.DEPTH.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.ClearBufferfi and Gl.ClearNamedFramebufferfi<paramref name="buffer"/> is not 
		/// Gl.DEPTH_STENCIL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> is Gl.COLOR<paramref name="drawbuffer"/> is negative, or 
		/// greater than the value of Gl.MAX_DRAW_BUFFERS minus one.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> is Gl.DEPTH, Gl.STENCIL or Gl.DEPTH_STENCIL and <paramref 
		/// name="drawbuffer"/> is not zero.
		/// </exception>
		/// <seealso cref="Gl.ClearColor"/>
		/// <seealso cref="Gl.ClearDepth"/>
		/// <seealso cref="Gl.ClearStencil"/>
		/// <seealso cref="Gl.Clear"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void ClearNamedFramebuffer(UInt32 framebuffer, Buffer buffer, Int32 drawbuffer, float depth, Int32 stencil)
		{
			Debug.Assert(Delegates.pglClearNamedFramebufferfi != null, "pglClearNamedFramebufferfi not implemented");
			Delegates.pglClearNamedFramebufferfi(framebuffer, (Int32)buffer, drawbuffer, depth, stencil);
			LogCommand("glClearNamedFramebufferfi", null, framebuffer, buffer, drawbuffer, depth, stencil			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// copy a block of pixels from one framebuffer object to another
		/// </summary>
		/// <param name="readFramebuffer">
		/// Specifies the name of the source framebuffer object for Gl.BlitNamedFramebuffer.
		/// </param>
		/// <param name="drawFramebuffer">
		/// Specifies the name of the destination framebuffer object for Gl.BlitNamedFramebuffer.
		/// </param>
		/// <param name="srcX0">
		/// Specify the bounds of the source rectangle within the read buffer of the read framebuffer.
		/// </param>
		/// <param name="srcY0">
		/// Specify the bounds of the source rectangle within the read buffer of the read framebuffer.
		/// </param>
		/// <param name="srcX1">
		/// Specify the bounds of the source rectangle within the read buffer of the read framebuffer.
		/// </param>
		/// <param name="srcY1">
		/// Specify the bounds of the source rectangle within the read buffer of the read framebuffer.
		/// </param>
		/// <param name="dstX0">
		/// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer.
		/// </param>
		/// <param name="dstY0">
		/// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer.
		/// </param>
		/// <param name="dstX1">
		/// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer.
		/// </param>
		/// <param name="dstY1">
		/// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer.
		/// </param>
		/// <param name="mask">
		/// The bitwise OR of the flags indicating which buffers are to be copied. The allowed flags are Gl.COLOR_BUFFER_BIT, 
		/// Gl.DEPTH_BUFFER_BIT and Gl.STENCIL_BUFFER_BIT.
		/// </param>
		/// <param name="filter">
		/// Specifies the interpolation to be applied if the image is stretched. Must be Gl.NEAREST or Gl.LINEAR.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.itNamedFramebuffer if <paramref name="readFramebuffer"/> or <paramref 
		/// name="drawFramebuffer"/> is not zero or the name of an existing framebuffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="mask"/> contains any of the Gl.DEPTH_BUFFER_BIT or 
		/// Gl.STENCIL_BUFFER_BIT and <paramref name="filter"/> is not Gl.NEAREST.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="mask"/> contains Gl.COLOR_BUFFER_BIT and any of the following 
		/// conditions hold: The read buffer contains fixed-point or floating-point values and any draw buffer contains neither 
		/// fixed-point nor floating-point values. The read buffer contains unsigned integer values and any draw buffer does not 
		/// contain unsigned integer values. The read buffer contains signed integer values and any draw buffer does not contain 
		/// signed integer values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="mask"/> contains Gl.DEPTH_BUFFER_BIT or Gl.STENCIL_BUFFER_BIT and 
		/// the source and destination depth and stencil formats do not match.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="filter"/> is Gl.LINEAR and the read buffer contains integer data.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the effective value of Gl.SAMPLES for the read and draw framebuffers is not 
		/// identical.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the value of Gl.SAMPLE_BUFFERS for both read and draw buffers is greater than zero 
		/// and the dimensions of the source and destination rectangles is not identical.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_FRAMEBUFFER_OPERATION is generated if the specified read and draw framebuffers are not framebuffer complete.
		/// </exception>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.CheckFramebufferStatus"/>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.DeleteFramebuffers"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void BlitNamedFramebuffer(UInt32 readFramebuffer, UInt32 drawFramebuffer, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, BlitFramebufferFilter filter)
		{
			Debug.Assert(Delegates.pglBlitNamedFramebuffer != null, "pglBlitNamedFramebuffer not implemented");
			Delegates.pglBlitNamedFramebuffer(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, (Int32)filter);
			LogCommand("glBlitNamedFramebuffer", null, readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// check the completeness status of a framebuffer
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for Gl.CheckNamedFramebufferStatus
		/// </param>
		/// <param name="target">
		/// Specify the target to which the framebuffer is bound for Gl.CheckFramebufferStatus, and the target against which 
		/// framebuffer completeness of <paramref name="framebuffer"/> is checked for Gl.CheckNamedFramebufferStatus.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.DRAW_FRAMEBUFFER, Gl.READ_FRAMEBUFFER or 
		/// Gl.FRAMEBUFFER.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.CheckNamedFramebufferStatus if <paramref name="framebuffer"/> is not zero or the 
		/// name of an existing framebuffer object.
		/// </exception>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.DeleteFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static FramebufferStatus CheckNamedFramebufferStatus(UInt32 framebuffer, FramebufferTarget target)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglCheckNamedFramebufferStatus != null, "pglCheckNamedFramebufferStatus not implemented");
			retValue = Delegates.pglCheckNamedFramebufferStatus(framebuffer, (Int32)target);
			LogCommand("glCheckNamedFramebufferStatus", (FramebufferStatus)retValue, framebuffer, target			);
			DebugCheckErrors(retValue);

			return ((FramebufferStatus)retValue);
		}

		/// <summary>
		/// query a named parameter of a framebuffer object
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for Gl.GetNamedFramebufferParameteriv.
		/// </param>
		/// <param name="pname">
		/// Specifies the parameter of the framebuffer object to query.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.GetFramebufferParameteriv if <paramref name="target"/> is not one of the accepted 
		/// framebuffer targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetNamedFramebufferAttachmentParameteriv if <paramref name="framebuffer"/> is 
		/// not zero or the name of an existing framebuffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the accepted parameter names.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a default framebuffer is queried, and <paramref name="pname"/> is not one of 
		/// Gl.DOUBLEBUFFER, Gl.IMPLEMENTATION_COLOR_READ_FORMAT, Gl.IMPLEMENTATION_COLOR_READ_TYPE, Gl.SAMPLES, Gl.SAMPLE_BUFFERS 
		/// or Gl.STEREO.
		/// </exception>
		/// <seealso cref="Gl.FramebufferParameteri"/>
		/// <seealso cref="Gl.GetFramebufferAttachmentParameter"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedFramebufferParameter(UInt32 framebuffer, GetFramebufferParameter pname, [Out] Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglGetNamedFramebufferParameteriv != null, "pglGetNamedFramebufferParameteriv not implemented");
					Delegates.pglGetNamedFramebufferParameteriv(framebuffer, (Int32)pname, p_param);
					LogCommand("glGetNamedFramebufferParameteriv", null, framebuffer, pname, param					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve information about attachments of a framebuffer object
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for Gl.GetNamedFramebufferAttachmentParameteriv.
		/// </param>
		/// <param name="attachment">
		/// Specifies the attachment of the framebuffer object to query.
		/// </param>
		/// <param name="pname">
		/// Specifies the parameter of <paramref name="attachment"/> to query.
		/// </param>
		/// <param name="params">
		/// Returns the value of parameter <paramref name="pname"/> for <paramref name="attachment"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.GetFramebufferAttachmentParameteriv if <paramref name="target"/> is not one of the 
		/// accepted framebuffer targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetNamedFramebufferAttachmentParameteriv if <paramref name="framebuffer"/> is 
		/// not zero or the name of an existing framebuffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not valid for the value of 
		/// Gl.FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE, as described above.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="attachment"/> is not one of the accepted framebuffer attachment 
		/// points, as described above.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the value of Gl.FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE is Gl.NONE and <paramref 
		/// name="pname"/> is not Gl.FRAMEBUFFER_ATTACHMENT_OBJECT_NAME or Gl.FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="attachment"/> is Gl.DEPTH_STENCIL_ATTACHMENT and different objects 
		/// are bound to the depth and stencil attachment points of <paramref name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="attachment"/> is Gl.DEPTH_STENCIL_ATTACHMENT and <paramref 
		/// name="pname"/> is Gl.FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE.
		/// </exception>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.GetFramebufferParameter"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedFramebufferAttachmentParameter(UInt32 framebuffer, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetNamedFramebufferAttachmentParameteriv != null, "pglGetNamedFramebufferAttachmentParameteriv not implemented");
					Delegates.pglGetNamedFramebufferAttachmentParameteriv(framebuffer, (Int32)attachment, (Int32)pname, p_params);
					LogCommand("glGetNamedFramebufferAttachmentParameteriv", null, framebuffer, attachment, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// create renderbuffer objects
		/// </summary>
		/// <param name="n">
		/// Number of renderbuffer objects to create.
		/// </param>
		/// <param name="renderbuffers">
		/// Specifies an array in which names of the new renderbuffer objects are stored.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BindRenderbuffer"/>
		/// <seealso cref="Gl.DeleteRenderbuffers"/>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.IsRenderbuffer"/>
		/// <seealso cref="Gl.RenderbufferStorage"/>
		/// <seealso cref="Gl.RenderbufferStorageMultisample"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void CreateRenderbuffers(Int32 n, UInt32[] renderbuffers)
		{
			unsafe {
				fixed (UInt32* p_renderbuffers = renderbuffers)
				{
					Debug.Assert(Delegates.pglCreateRenderbuffers != null, "pglCreateRenderbuffers not implemented");
					Delegates.pglCreateRenderbuffers(n, p_renderbuffers);
					LogCommand("glCreateRenderbuffers", null, n, renderbuffers					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// establish data storage, format and dimensions of a renderbuffer object's image
		/// </summary>
		/// <param name="renderbuffer">
		/// Specifies the name of the renderbuffer object for Gl.NamedRenderbufferStorage function.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the internal format to use for the renderbuffer object's image.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the renderbuffer, in pixels.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the renderbuffer, in pixels.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.RenderbufferStorage if <paramref name="target"/> is not Gl.RENDERBUFFER.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by glNamedRenderbufferStorage if <paramref name="renderbuffer"/> is not the name of an 
		/// existing renderbuffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either of <paramref name="width"/> or <paramref name="height"/> is negative, or greater 
		/// than the value of Gl.MAX_RENDERBUFFER_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not a color-renderable, depth-renderable, or 
		/// stencil-renderable format.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.OUT_OF_MEMORY is generated if the GL is unable to create a data store of the requested size.
		/// </exception>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.BindRenderbuffer"/>
		/// <seealso cref="Gl.RenderbufferStorageMultisample"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.DeleteRenderbuffers"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void NamedRenderbufferStorage(UInt32 renderbuffer, InternalFormat internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglNamedRenderbufferStorage != null, "pglNamedRenderbufferStorage not implemented");
			Delegates.pglNamedRenderbufferStorage(renderbuffer, (Int32)internalformat, width, height);
			LogCommand("glNamedRenderbufferStorage", null, renderbuffer, internalformat, width, height			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// establish data storage, format, dimensions and sample count of a renderbuffer object's image
		/// </summary>
		/// <param name="renderbuffer">
		/// Specifies the name of the renderbuffer object for Gl.NamedRenderbufferStorageMultisample function.
		/// </param>
		/// <param name="samples">
		/// Specifies the number of samples to be used for the renderbuffer object's storage.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the internal format to use for the renderbuffer object's image.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the renderbuffer, in pixels.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the renderbuffer, in pixels.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.RenderbufferStorageMultisample function if <paramref name="target"/> is not 
		/// Gl.RENDERBUFFER.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedRenderbufferStorageMultisample function if <paramref name="renderbuffer"/> 
		/// is not the name of an existing renderbuffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="samples"/> is greater than the maximum number of samples supported 
		/// for <paramref name="internalformat"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not a color-renderable, depth-renderable, or 
		/// stencil-renderable format.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalformat"/> is a signed or unsigned integer format and 
		/// <paramref name="samples"/> is greater than the value of Gl.MAX_INTEGER_SAMPLES
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either of <paramref name="width"/> or <paramref name="height"/> is negative, or greater 
		/// than the value of Gl.MAX_RENDERBUFFER_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.OUT_OF_MEMORY is generated if the GL is unable to create a data store of the requested size.
		/// </exception>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.BindRenderbuffer"/>
		/// <seealso cref="Gl.RenderbufferStorage"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.DeleteRenderbuffers"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void NamedRenderbufferStorageMultisample(UInt32 renderbuffer, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglNamedRenderbufferStorageMultisample != null, "pglNamedRenderbufferStorageMultisample not implemented");
			Delegates.pglNamedRenderbufferStorageMultisample(renderbuffer, samples, (Int32)internalformat, width, height);
			LogCommand("glNamedRenderbufferStorageMultisample", null, renderbuffer, samples, internalformat, width, height			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// query a named parameter of a renderbuffer object
		/// </summary>
		/// <param name="renderbuffer">
		/// Specifies the name of the renderbuffer object for Gl.GetNamedRenderbufferParameteriv.
		/// </param>
		/// <param name="pname">
		/// Specifies the parameter of the renderbuffer object to query.
		/// </param>
		/// <param name="params">
		/// Returns the value of parameter <paramref name="pname"/> for the renderbuffer object.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.GetRenderbufferParameteriv if <paramref name="target"/> is not Gl.RENDERBUFFER.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetRenderbufferParameteriv if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetNamedRenderbufferParameteriv if <paramref name="renderbuffer"/> is not the 
		/// name of an existing renderbuffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the accepted parameter names described above.
		/// </exception>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.BindRenderbuffer"/>
		/// <seealso cref="Gl.RenderbufferStorage"/>
		/// <seealso cref="Gl.RenderbufferStorageMultisample"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetNamedRenderbufferParameter(UInt32 renderbuffer, RenderbufferParameterName pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetNamedRenderbufferParameteriv != null, "pglGetNamedRenderbufferParameteriv not implemented");
					Delegates.pglGetNamedRenderbufferParameteriv(renderbuffer, (Int32)pname, p_params);
					LogCommand("glGetNamedRenderbufferParameteriv", null, renderbuffer, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// create texture objects
		/// </summary>
		/// <param name="target">
		/// Specifies the effective texture target of each created texture.
		/// </param>
		/// <param name="n">
		/// Number of texture objects to create.
		/// </param>
		/// <param name="textures">
		/// Specifies an array in which names of the new texture objects are stored.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.DeleteTextures"/>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.IsTexture"/>
		/// <seealso cref="Gl.TexBuffer"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage2DMultisample"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexImage3DMultisample"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void CreateTextures(TextureTarget target, Int32 n, UInt32[] textures)
		{
			unsafe {
				fixed (UInt32* p_textures = textures)
				{
					Debug.Assert(Delegates.pglCreateTextures != null, "pglCreateTextures not implemented");
					Delegates.pglCreateTextures((Int32)target, n, p_textures);
					LogCommand("glCreateTextures", null, target, n, textures					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// attach a buffer object's data store to a buffer texture object
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.TextureBuffer.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:InternalFormat"/>.
		/// </param>
		/// <param name="buffer">
		/// Specifies the name of the buffer object whose storage to attach to the active buffer texture.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.TexBuffer if <paramref name="target"/> is not Gl.TEXTURE_BUFFER.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureBuffer if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.TextureBuffer if the effective target of <paramref name="texture"/> is not 
		/// Gl.TEXTURE_BUFFER.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the sized internal formats described 
		/// above.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="buffer"/> is not zero and is not the name of an existing buffer 
		/// object.
		/// </exception>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.DeleteTextures"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void TextureBuffer(UInt32 texture, InternalFormat internalformat, UInt32 buffer)
		{
			Debug.Assert(Delegates.pglTextureBuffer != null, "pglTextureBuffer not implemented");
			Delegates.pglTextureBuffer(texture, (Int32)internalformat, buffer);
			LogCommand("glTextureBuffer", null, texture, internalformat, buffer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// attach a range of a buffer object's data store to a buffer texture object
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.TextureBufferRange.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:InternalFormat"/>.
		/// </param>
		/// <param name="buffer">
		/// Specifies the name of the buffer object whose storage to attach to the active buffer texture.
		/// </param>
		/// <param name="offset">
		/// Specifies the offset of the start of the range of the buffer's data store to attach.
		/// </param>
		/// <param name="size">
		/// Specifies the size of the range of the buffer's data store to attach.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.TexBufferRange if <paramref name="target"/> is not Gl.TEXTURE_BUFFER.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureBufferRange if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.TextureBufferRange if the effective target of <paramref name="texture"/> is not 
		/// Gl.TEXTURE_BUFFER.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the sized internal formats described 
		/// above.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="buffer"/> is not zero and is not the name of an existing buffer 
		/// object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> is negative, if <paramref name="size"/> is less than or equal 
		/// to zero, or if <paramref name="offset"/> + <paramref name="size"/> is greater than the value of Gl.BUFFER_SIZE for 
		/// <paramref name="buffer"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> is not an integer multiple of the value of 
		/// Gl.TEXTURE_BUFFER_OFFSET_ALIGNMENT.
		/// </exception>
		/// <seealso cref="Gl.TexBuffer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void TextureBufferRange(UInt32 texture, InternalFormat internalformat, UInt32 buffer, IntPtr offset, UInt32 size)
		{
			Debug.Assert(Delegates.pglTextureBufferRange != null, "pglTextureBufferRange not implemented");
			Delegates.pglTextureBufferRange(texture, (Int32)internalformat, buffer, offset, size);
			LogCommand("glTextureBufferRange", null, texture, internalformat, buffer, offset, size			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureStorage1D.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="levels">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:InternalFormat"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void TextureStorage1D(UInt32 texture, Int32 levels, InternalFormat internalformat, Int32 width)
		{
			Debug.Assert(Delegates.pglTextureStorage1D != null, "pglTextureStorage1D not implemented");
			Delegates.pglTextureStorage1D(texture, levels, (Int32)internalformat, width);
			LogCommand("glTextureStorage1D", null, texture, levels, internalformat, width			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureStorage2D.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="levels">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:InternalFormat"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void TextureStorage2D(UInt32 texture, Int32 levels, InternalFormat internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglTextureStorage2D != null, "pglTextureStorage2D not implemented");
			Delegates.pglTextureStorage2D(texture, levels, (Int32)internalformat, width, height);
			LogCommand("glTextureStorage2D", null, texture, levels, internalformat, width, height			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureStorage3D.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="levels">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:InternalFormat"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void TextureStorage3D(UInt32 texture, Int32 levels, InternalFormat internalformat, Int32 width, Int32 height, Int32 depth)
		{
			Debug.Assert(Delegates.pglTextureStorage3D != null, "pglTextureStorage3D not implemented");
			Delegates.pglTextureStorage3D(texture, levels, (Int32)internalformat, width, height, depth);
			LogCommand("glTextureStorage3D", null, texture, levels, internalformat, width, height, depth			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify storage for a two-dimensional multisample texture
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.TextureStorage2DMultisample. The effective target of <paramref name="texture"/> 
		/// must be one of the valid non-proxy <paramref name="target"/> values above.
		/// </param>
		/// <param name="samples">
		/// Specify the number of samples in the texture.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the sized internal format to be used to store texture image data.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture, in texels.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture, in texels.
		/// </param>
		/// <param name="fixedsamplelocations">
		/// Specifies whether the image will use identical sample locations and the same number of samples for all texels in the 
		/// image, and the sample locations will not depend on the internal format or size of the image.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.TexStorage2DMultisample if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureStorage2DMultisample if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not a valid color-renderable, depth-renderable or 
		/// stencil-renderable format.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// one of the accepted targets described above.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> or <paramref name="height"/> are less than 1 or greater than 
		/// the value of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="levels"/> is less than 1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="samples"/> is zero.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="samples"/> is greater than the maximum number of samples supported 
		/// for this <paramref name="target"/> and <paramref name="internalformat"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the value of Gl.TEXTURE_IMMUTABLE_FORMAT for the texture bound to <paramref 
		/// name="target"/> is not Gl.FALSE.
		/// </exception>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage2DMultisample"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void TextureStorage2DMultisample(UInt32 texture, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height, bool fixedsamplelocations)
		{
			Debug.Assert(Delegates.pglTextureStorage2DMultisample != null, "pglTextureStorage2DMultisample not implemented");
			Delegates.pglTextureStorage2DMultisample(texture, samples, (Int32)internalformat, width, height, fixedsamplelocations);
			LogCommand("glTextureStorage2DMultisample", null, texture, samples, internalformat, width, height, fixedsamplelocations			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify storage for a two-dimensional multisample array texture
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.TextureStorage3DMultisample. The effective target of <paramref name="texture"/> 
		/// must be one of the valid non-proxy <paramref name="target"/> values above.
		/// </param>
		/// <param name="samples">
		/// Specify the number of samples in the texture.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the sized internal format to be used to store texture image data.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture, in texels.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture, in texels.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture, in layers.
		/// </param>
		/// <param name="fixedsamplelocations">
		/// Specifies whether the image will use identical sample locations and the same number of samples for all texels in the 
		/// image, and the sample locations will not depend on the internal format or size of the image.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.TexStorage3DMultisample if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureStorage3DMultisample if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not a valid color-renderable, depth-renderable or 
		/// stencil-renderable format.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// one of the accepted targets described above.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> or <paramref name="height"/> are less than 1 or greater than 
		/// the value of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="depth"/> is less than 1 or greater than the value of 
		/// Gl.MAX_ARRAY_TEXTURE_LAYERS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="levels"/> is less than 1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="samples"/> is zero.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="samples"/> is greater than the maximum number of samples supported 
		/// for this <paramref name="target"/> and <paramref name="internalformat"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the value of Gl.TEXTURE_IMMUTABLE_FORMAT for the texture bound to <paramref 
		/// name="target"/> is not Gl.FALSE.
		/// </exception>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexImage3DMultisample"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2DMultisample"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void TextureStorage3DMultisample(UInt32 texture, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations)
		{
			Debug.Assert(Delegates.pglTextureStorage3DMultisample != null, "pglTextureStorage3DMultisample not implemented");
			Delegates.pglTextureStorage3DMultisample(texture, samples, (Int32)internalformat, width, height, depth, fixedsamplelocations);
			LogCommand("glTextureStorage3DMultisample", null, texture, samples, internalformat, width, height, depth, fixedsamplelocations			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a one-dimensional texture subimage
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.TextureSubImage1D. The effective target of <paramref name="texture"/> must be 
		/// one of the valid <paramref name="target"/> values above.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.RED, Gl.RG, Gl.RGB, Gl.BGR, 
		/// Gl.RGBA, Gl.DEPTH_COMPONENT, and Gl.STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureSubImage1D if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted format constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if xoffset&lt;-b, or if xoffset+width&gt;w-b, where w is the Gl.TEXTURE_WIDTH, and b is 
		/// the width of the Gl.TEXTURE_BORDER of the texture image being modified. Note that w includes twice the border width.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage1D operation.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.STENCIL_INDEX and the base internal format is not 
		/// Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="pixels"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated 
		/// by <paramref name="type"/>.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void TextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTextureSubImage1D != null, "pglTextureSubImage1D not implemented");
			Delegates.pglTextureSubImage1D(texture, level, xoffset, width, (Int32)format, (Int32)type, pixels);
			LogCommand("glTextureSubImage1D", null, texture, level, xoffset, width, format, type, pixels			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a one-dimensional texture subimage
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.TextureSubImage1D. The effective target of <paramref name="texture"/> must be 
		/// one of the valid <paramref name="target"/> values above.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.RED, Gl.RG, Gl.RGB, Gl.BGR, 
		/// Gl.RGBA, Gl.DEPTH_COMPONENT, and Gl.STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// one of the allowable values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureSubImage1D if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted format constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if xoffset&lt;-b, or if xoffset+width&gt;w-b, where w is the Gl.TEXTURE_WIDTH, and b is 
		/// the width of the Gl.TEXTURE_BORDER of the texture image being modified. Note that w includes twice the border width.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage1D operation.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.STENCIL_INDEX and the base internal format is not 
		/// Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="pixels"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated 
		/// by <paramref name="type"/>.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void TextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TextureSubImage1D(texture, level, xoffset, width, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// specify a two-dimensional texture subimage
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.TextureSubImage2D. The effective target of <paramref name="texture"/> must be 
		/// one of the valid <paramref name="target"/> values above.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.RED, Gl.RG, Gl.RGB, Gl.BGR, 
		/// Gl.RGBA, Gl.BGRA, Gl.DEPTH_COMPONENT, and Gl.STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// Gl.TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, or Gl.TEXTURE_1D_ARRAY.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureSubImage2D if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted format constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or yoffset+height&gt;h-b, where w 
		/// is the Gl.TEXTURE_WIDTH, h is the Gl.TEXTURE_HEIGHT, and b is the border width of the texture image being modified. Note 
		/// that w and h include twice the border width.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> or <paramref name="height"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage2D operation.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.STENCIL_INDEX and the base internal format is not 
		/// Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="pixels"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated 
		/// by <paramref name="type"/>.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void TextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTextureSubImage2D != null, "pglTextureSubImage2D not implemented");
			Delegates.pglTextureSubImage2D(texture, level, xoffset, yoffset, width, height, (Int32)format, (Int32)type, pixels);
			LogCommand("glTextureSubImage2D", null, texture, level, xoffset, yoffset, width, height, format, type, pixels			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a two-dimensional texture subimage
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.TextureSubImage2D. The effective target of <paramref name="texture"/> must be 
		/// one of the valid <paramref name="target"/> values above.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.RED, Gl.RG, Gl.RGB, Gl.BGR, 
		/// Gl.RGBA, Gl.BGRA, Gl.DEPTH_COMPONENT, and Gl.STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// Gl.TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, or Gl.TEXTURE_1D_ARRAY.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureSubImage2D if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted format constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or yoffset+height&gt;h-b, where w 
		/// is the Gl.TEXTURE_WIDTH, h is the Gl.TEXTURE_HEIGHT, and b is the border width of the texture image being modified. Note 
		/// that w and h include twice the border width.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> or <paramref name="height"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage2D operation.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.STENCIL_INDEX and the base internal format is not 
		/// Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="pixels"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated 
		/// by <paramref name="type"/>.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void TextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// specify a three-dimensional texture subimage
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.TextureSubImage3D. The effective target of <paramref name="texture"/> must be 
		/// one of the valid <paramref name="target"/> values above.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="zoffset">
		/// Specifies a texel offset in the z direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.RED, Gl.RG, Gl.RGB, Gl.BGR, 
		/// Gl.RGBA, Gl.DEPTH_COMPONENT, and Gl.STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// Gl.TEXTURE_3D or Gl.TEXTURE_2D_ARRAY.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureSubImage3D if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted format constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or yoffset+height&gt;h-b, or 
		/// zoffset&lt;-b, or zoffset+depth&gt;d-b, where w is the Gl.TEXTURE_WIDTH, h is the Gl.TEXTURE_HEIGHT, d is the 
		/// Gl.TEXTURE_DEPTH and b is the border width of the texture image being modified. Note that w, h, and d include twice the 
		/// border width.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/>, <paramref name="height"/>, or <paramref name="depth"/> is 
		/// less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage3D or glTexStorage3D 
		/// operation.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.STENCIL_INDEX and the base internal format is not 
		/// Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="pixels"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated 
		/// by <paramref name="type"/>.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void TextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTextureSubImage3D != null, "pglTextureSubImage3D not implemented");
			Delegates.pglTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, (Int32)format, (Int32)type, pixels);
			LogCommand("glTextureSubImage3D", null, texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a three-dimensional texture subimage
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.TextureSubImage3D. The effective target of <paramref name="texture"/> must be 
		/// one of the valid <paramref name="target"/> values above.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="zoffset">
		/// Specifies a texel offset in the z direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.RED, Gl.RG, Gl.RGB, Gl.BGR, 
		/// Gl.RGBA, Gl.DEPTH_COMPONENT, and Gl.STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or the effective target of <paramref name="texture"/> is not 
		/// Gl.TEXTURE_3D or Gl.TEXTURE_2D_ARRAY.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureSubImage3D if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted format constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or yoffset+height&gt;h-b, or 
		/// zoffset&lt;-b, or zoffset+depth&gt;d-b, where w is the Gl.TEXTURE_WIDTH, h is the Gl.TEXTURE_HEIGHT, d is the 
		/// Gl.TEXTURE_DEPTH and b is the border width of the texture image being modified. Note that w, h, and d include twice the 
		/// border width.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/>, <paramref name="height"/>, or <paramref name="depth"/> is 
		/// less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage3D or glTexStorage3D 
		/// operation.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.STENCIL_INDEX and the base internal format is not 
		/// Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="pixels"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated 
		/// by <paramref name="type"/>.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void TextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// specify a one-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.CompressedTextureSubImage1D function.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the generic compressed internal formats: 
		/// Gl.COMPRESSED_RED, Gl.COMPRESSED_RG, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA. Gl.COMPRESSED_SRGB, or 
		/// Gl.COMPRESSED_SRGB_ALPHA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="imageSize"/> is not consistent with the format, dimensions, and 
		/// contents of the specified compressed image data.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		/// as specified in the specific texture compression extension.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// GL_INVALID_OPERATION is generated by Gl.CompressedTextureSubImage1D function if texture is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		/// manner consistent with the extension specification defining the internal compression format.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void CompressedTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTextureSubImage1D != null, "pglCompressedTextureSubImage1D not implemented");
			Delegates.pglCompressedTextureSubImage1D(texture, level, xoffset, width, (Int32)format, imageSize, data);
			LogCommand("glCompressedTextureSubImage1D", null, texture, level, xoffset, width, format, imageSize, data			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a one-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.CompressedTextureSubImage1D function.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the generic compressed internal formats: 
		/// Gl.COMPRESSED_RED, Gl.COMPRESSED_RG, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA. Gl.COMPRESSED_SRGB, or 
		/// Gl.COMPRESSED_SRGB_ALPHA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="imageSize"/> is not consistent with the format, dimensions, and 
		/// contents of the specified compressed image data.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		/// as specified in the specific texture compression extension.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// GL_INVALID_OPERATION is generated by Gl.CompressedTextureSubImage1D function if texture is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		/// manner consistent with the extension specification defining the internal compression format.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void CompressedTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// specify a two-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.CompressedTextureSubImage2D function.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is of the generic compressed internal formats: 
		/// Gl.COMPRESSED_RED, Gl.COMPRESSED_RG, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA. Gl.COMPRESSED_SRGB, or 
		/// Gl.COMPRESSED_SRGB_ALPHA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.CompressedTexSubImage2D if <paramref name="target"/> is Gl.TEXTURE_RECTANGLE or 
		/// Gl.PROXY_TEXTURE_RECTANGLE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="imageSize"/> is not consistent with the format, dimensions, and 
		/// contents of the specified compressed image data.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		/// as specified in the specific texture compression extension.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.CompressedTextureSubImage2D if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.CompressedTextureSubImage2D if the effective target is Gl.TEXTURE_RECTANGLE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		/// manner consistent with the extension specification defining the internal compression format.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void CompressedTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTextureSubImage2D != null, "pglCompressedTextureSubImage2D not implemented");
			Delegates.pglCompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, (Int32)format, imageSize, data);
			LogCommand("glCompressedTextureSubImage2D", null, texture, level, xoffset, yoffset, width, height, format, imageSize, data			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a two-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.CompressedTextureSubImage2D function.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is of the generic compressed internal formats: 
		/// Gl.COMPRESSED_RED, Gl.COMPRESSED_RG, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA. Gl.COMPRESSED_SRGB, or 
		/// Gl.COMPRESSED_SRGB_ALPHA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.CompressedTexSubImage2D if <paramref name="target"/> is Gl.TEXTURE_RECTANGLE or 
		/// Gl.PROXY_TEXTURE_RECTANGLE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="imageSize"/> is not consistent with the format, dimensions, and 
		/// contents of the specified compressed image data.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		/// as specified in the specific texture compression extension.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.CompressedTextureSubImage2D if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.CompressedTextureSubImage2D if the effective target is Gl.TEXTURE_RECTANGLE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		/// manner consistent with the extension specification defining the internal compression format.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void CompressedTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// specify a three-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.CompressedTextureSubImage3D function.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is one of the generic compressed internal formats: 
		/// Gl.COMPRESSED_RED, Gl.COMPRESSED_RG, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA. Gl.COMPRESSED_SRGB, or 
		/// Gl.COMPRESSED_SRGB_ALPHA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.CompressedTexSubImage3D if <paramref name="target"/> is not Gl.TEXTURE_2D_ARRAY, 
		/// Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP_ARRAY.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.CompressedTextureSubImage3D if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="imageSize"/> is not consistent with the format, dimensions, and 
		/// contents of the specified compressed image data.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		/// as specified in the specific texture compression extension.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		/// manner consistent with the extension specification defining the internal compression format.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void CompressedTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTextureSubImage3D != null, "pglCompressedTextureSubImage3D not implemented");
			Delegates.pglCompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, (Int32)format, imageSize, data);
			LogCommand("glCompressedTextureSubImage3D", null, texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a three-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.CompressedTextureSubImage3D function.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>.
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is one of the generic compressed internal formats: 
		/// Gl.COMPRESSED_RED, Gl.COMPRESSED_RG, Gl.COMPRESSED_RGB, Gl.COMPRESSED_RGBA. Gl.COMPRESSED_SRGB, or 
		/// Gl.COMPRESSED_SRGB_ALPHA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.CompressedTexSubImage3D if <paramref name="target"/> is not Gl.TEXTURE_2D_ARRAY, 
		/// Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP_ARRAY.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.CompressedTextureSubImage3D if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="imageSize"/> is not consistent with the format, dimensions, and 
		/// contents of the specified compressed image data.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		/// as specified in the specific texture compression extension.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		/// manner consistent with the extension specification defining the internal compression format.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void CompressedTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glCopyTextureSubImage1D.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void CopyTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width)
		{
			Debug.Assert(Delegates.pglCopyTextureSubImage1D != null, "pglCopyTextureSubImage1D not implemented");
			Delegates.pglCopyTextureSubImage1D(texture, level, xoffset, x, y, width);
			LogCommand("glCopyTextureSubImage1D", null, texture, level, xoffset, x, y, width			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCopyTextureSubImage2D.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void CopyTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglCopyTextureSubImage2D != null, "pglCopyTextureSubImage2D not implemented");
			Delegates.pglCopyTextureSubImage2D(texture, level, xoffset, yoffset, x, y, width, height);
			LogCommand("glCopyTextureSubImage2D", null, texture, level, xoffset, yoffset, x, y, width, height			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCopyTextureSubImage3D.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void CopyTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglCopyTextureSubImage3D != null, "pglCopyTextureSubImage3D not implemented");
			Delegates.pglCopyTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
			LogCommand("glCopyTextureSubImage3D", null, texture, level, xoffset, yoffset, zoffset, x, y, width, height			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureParameterf.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureParameterName"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void TextureParameter(UInt32 texture, TextureParameterName pname, float param)
		{
			Debug.Assert(Delegates.pglTextureParameterf != null, "pglTextureParameterf not implemented");
			Delegates.pglTextureParameterf(texture, (Int32)pname, param);
			LogCommand("glTextureParameterf", null, texture, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureParameterfv.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureParameterName"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void TextureParameter(UInt32 texture, TextureParameterName pname, float[] param)
		{
			unsafe {
				fixed (float* p_param = param)
				{
					Debug.Assert(Delegates.pglTextureParameterfv != null, "pglTextureParameterfv not implemented");
					Delegates.pglTextureParameterfv(texture, (Int32)pname, p_param);
					LogCommand("glTextureParameterfv", null, texture, pname, param					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureParameteri.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureParameterName"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void TextureParameter(UInt32 texture, TextureParameterName pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTextureParameteri != null, "pglTextureParameteri not implemented");
			Delegates.pglTextureParameteri(texture, (Int32)pname, param);
			LogCommand("glTextureParameteri", null, texture, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureParameterIiv.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void TextureParameterI(UInt32 texture, TextureParameterName pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTextureParameterIiv != null, "pglTextureParameterIiv not implemented");
					Delegates.pglTextureParameterIiv(texture, (Int32)pname, p_params);
					LogCommand("glTextureParameterIiv", null, texture, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureParameterIuiv.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void TextureParameterI(UInt32 texture, TextureParameterName pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTextureParameterIuiv != null, "pglTextureParameterIuiv not implemented");
					Delegates.pglTextureParameterIuiv(texture, (Int32)pname, p_params);
					LogCommand("glTextureParameterIuiv", null, texture, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureParameteriv.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureParameterName"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void TextureParameter(UInt32 texture, TextureParameterName pname, Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglTextureParameteriv != null, "pglTextureParameteriv not implemented");
					Delegates.pglTextureParameteriv(texture, (Int32)pname, p_param);
					LogCommand("glTextureParameteriv", null, texture, pname, param					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// generate mipmaps for a specified texture object
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.GenerateTextureMipmap.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.GenerateMipmap if <paramref name="target"/> is not one of the accepted texture 
		/// targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GenerateTextureMipmap if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="target"/> is Gl.TEXTURE_CUBE_MAP or Gl.TEXTURE_CUBE_MAP_ARRAY, and 
		/// the specified texture object is not cube complete or cube array complete, respectively.
		/// </exception>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.GenTextures"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GenerateTextureMipmap(UInt32 texture)
		{
			Debug.Assert(Delegates.pglGenerateTextureMipmap != null, "pglGenerateTextureMipmap not implemented");
			Delegates.pglGenerateTextureMipmap(texture);
			LogCommand("glGenerateTextureMipmap", null, texture			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// bind an existing texture object to the specified texture unit
		/// </summary>
		/// <param name="unit">
		/// Specifies the texture unit, to which the texture object should be bound to.
		/// </param>
		/// <param name="texture">
		/// Specifies the name of a texture.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION error is generated if <paramref name="texture"/> is not zero or the name of an existing texture 
		/// object.
		/// </exception>
		/// <seealso cref="Gl.DeleteTextures"/>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.IsTexture"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage2DMultisample"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexImage3DMultisample"/>
		/// <seealso cref="Gl.TexBuffer"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void BindTextureUnit(UInt32 unit, UInt32 texture)
		{
			Debug.Assert(Delegates.pglBindTextureUnit != null, "pglBindTextureUnit not implemented");
			Delegates.pglBindTextureUnit(unit, texture);
			LogCommand("glBindTextureUnit", null, unit, texture			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetTextureImage.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetTextureImage(UInt32 texture, Int32 level, PixelFormat format, PixelType type, Int32 bufSize, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetTextureImage != null, "pglGetTextureImage not implemented");
			Delegates.pglGetTextureImage(texture, level, (Int32)format, (Int32)type, bufSize, pixels);
			LogCommand("glGetTextureImage", null, texture, level, format, type, bufSize, pixels			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetTextureImage.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetTextureImage(UInt32 texture, Int32 level, PixelFormat format, PixelType type, Int32 bufSize, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				GetTextureImage(texture, level, format, type, bufSize, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// return a compressed texture image
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.GetCompressedTextureImage function.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level $n$ is the $n$-th 
		/// mipmap reduction image.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer <paramref name="pixels"/> for Gl.GetCompressedTextureImage and 
		/// Gl.GetnCompressedTexImage functions.
		/// </param>
		/// <param name="pixels">
		/// Returns the compressed texture image.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetCompressedTextureImage if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than zero or greater than the maximum number of LODs 
		/// permitted by the implementation.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetCompressedTexImage, Gl.GetnCompressedTexImage, and 
		/// Gl.GetCompressedTextureImage is used to retrieve a texture that is in an uncompressed internal format.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target, the 
		/// buffer storage was not initialized with Gl.BufferStorage using Gl.MAP_PERSISTENT_BIT flag, and the buffer object's data 
		/// store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetCompressedTextureImage(UInt32 texture, Int32 level, Int32 bufSize, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetCompressedTextureImage != null, "pglGetCompressedTextureImage not implemented");
			Delegates.pglGetCompressedTextureImage(texture, level, bufSize, pixels);
			LogCommand("glGetCompressedTextureImage", null, texture, level, bufSize, pixels			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return a compressed texture image
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.GetCompressedTextureImage function.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level $n$ is the $n$-th 
		/// mipmap reduction image.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer <paramref name="pixels"/> for Gl.GetCompressedTextureImage and 
		/// Gl.GetnCompressedTexImage functions.
		/// </param>
		/// <param name="pixels">
		/// Returns the compressed texture image.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetCompressedTextureImage if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than zero or greater than the maximum number of LODs 
		/// permitted by the implementation.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetCompressedTexImage, Gl.GetnCompressedTexImage, and 
		/// Gl.GetCompressedTextureImage is used to retrieve a texture that is in an uncompressed internal format.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target, the 
		/// buffer storage was not initialized with Gl.BufferStorage using Gl.MAP_PERSISTENT_BIT flag, and the buffer object's data 
		/// store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetCompressedTextureImage(UInt32 texture, Int32 level, Int32 bufSize, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				GetCompressedTextureImage(texture, level, bufSize, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// return texture parameter values for a specific level of detail
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.GetTextureLevelParameterfv and Gl.GetTextureLevelParameteriv functions.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reduction image.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. Gl.TEXTURE_WIDTH, Gl.TEXTURE_HEIGHT, Gl.TEXTURE_DEPTH, 
		/// Gl.TEXTURE_INTERNAL_FORMAT, Gl.TEXTURE_RED_SIZE, Gl.TEXTURE_GREEN_SIZE, Gl.TEXTURE_BLUE_SIZE, Gl.TEXTURE_ALPHA_SIZE, 
		/// Gl.TEXTURE_DEPTH_SIZE, Gl.TEXTURE_COMPRESSED, Gl.TEXTURE_COMPRESSED_IMAGE_SIZE, and Gl.TEXTURE_BUFFER_OFFSET are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetTextureLevelParameterfv and Gl.GetTextureLevelParameteriv functions if 
		/// <paramref name="texture"/> is not the name of an existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.GetTexLevelParameterfv and Gl.GetTexLevelParameteriv functions if <paramref 
		/// name="target"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="target"/> is Gl.TEXTURE_BUFFER and <paramref name="level"/> is not 
		/// zero.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TEXTURE_COMPRESSED_IMAGE_SIZE is queried on texture images with an uncompressed 
		/// internal format or on proxy targets.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetTextureLevelParameter(UInt32 texture, Int32 level, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTextureLevelParameterfv != null, "pglGetTextureLevelParameterfv not implemented");
					Delegates.pglGetTextureLevelParameterfv(texture, level, pname, p_params);
					LogCommand("glGetTextureLevelParameterfv", null, texture, level, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture parameter values for a specific level of detail
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.GetTextureLevelParameterfv and Gl.GetTextureLevelParameteriv functions.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reduction image.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. Gl.TEXTURE_WIDTH, Gl.TEXTURE_HEIGHT, Gl.TEXTURE_DEPTH, 
		/// Gl.TEXTURE_INTERNAL_FORMAT, Gl.TEXTURE_RED_SIZE, Gl.TEXTURE_GREEN_SIZE, Gl.TEXTURE_BLUE_SIZE, Gl.TEXTURE_ALPHA_SIZE, 
		/// Gl.TEXTURE_DEPTH_SIZE, Gl.TEXTURE_COMPRESSED, Gl.TEXTURE_COMPRESSED_IMAGE_SIZE, and Gl.TEXTURE_BUFFER_OFFSET are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetTextureLevelParameterfv and Gl.GetTextureLevelParameteriv functions if 
		/// <paramref name="texture"/> is not the name of an existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.GetTexLevelParameterfv and Gl.GetTexLevelParameteriv functions if <paramref 
		/// name="target"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="target"/> is Gl.TEXTURE_BUFFER and <paramref name="level"/> is not 
		/// zero.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TEXTURE_COMPRESSED_IMAGE_SIZE is queried on texture images with an uncompressed 
		/// internal format or on proxy targets.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetTextureLevelParameter(UInt32 texture, Int32 level, GetTextureParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTextureLevelParameteriv != null, "pglGetTextureLevelParameteriv not implemented");
					Delegates.pglGetTextureLevelParameteriv(texture, level, (Int32)pname, p_params);
					LogCommand("glGetTextureLevelParameteriv", null, texture, level, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.GetTextureParameterfv, Gl.GetTextureParameteriv, Gl.GetTextureParameterIiv, and 
		/// Gl.GetTextureParameterIuiv functions.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, 
		/// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER, 
		/// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R, 
		/// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET, 
		/// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS, 
		/// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the texture parameters.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM error is generated by Gl.GetTexParameter if the effective <paramref name="target"/> is not one of the 
		/// accepted texture targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetTextureParameter* if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TextureView"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetTextureParameter(UInt32 texture, GetTextureParameter pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTextureParameterfv != null, "pglGetTextureParameterfv not implemented");
					Delegates.pglGetTextureParameterfv(texture, (Int32)pname, p_params);
					LogCommand("glGetTextureParameterfv", null, texture, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.GetTextureParameterfv, Gl.GetTextureParameteriv, Gl.GetTextureParameterIiv, and 
		/// Gl.GetTextureParameterIuiv functions.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, 
		/// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER, 
		/// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R, 
		/// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET, 
		/// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS, 
		/// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the texture parameters.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM error is generated by Gl.GetTexParameter if the effective <paramref name="target"/> is not one of the 
		/// accepted texture targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetTextureParameter* if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TextureView"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetTextureParameterI(UInt32 texture, GetTextureParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTextureParameterIiv != null, "pglGetTextureParameterIiv not implemented");
					Delegates.pglGetTextureParameterIiv(texture, (Int32)pname, p_params);
					LogCommand("glGetTextureParameterIiv", null, texture, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.GetTextureParameterfv, Gl.GetTextureParameteriv, Gl.GetTextureParameterIiv, and 
		/// Gl.GetTextureParameterIuiv functions.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, 
		/// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER, 
		/// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R, 
		/// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET, 
		/// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS, 
		/// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the texture parameters.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM error is generated by Gl.GetTexParameter if the effective <paramref name="target"/> is not one of the 
		/// accepted texture targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetTextureParameter* if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TextureView"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetTextureParameterI(UInt32 texture, GetTextureParameter pname, [Out] UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTextureParameterIuiv != null, "pglGetTextureParameterIuiv not implemented");
					Delegates.pglGetTextureParameterIuiv(texture, (Int32)pname, p_params);
					LogCommand("glGetTextureParameterIuiv", null, texture, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for Gl.GetTextureParameterfv, Gl.GetTextureParameteriv, Gl.GetTextureParameterIiv, and 
		/// Gl.GetTextureParameterIuiv functions.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, 
		/// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER, 
		/// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R, 
		/// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET, 
		/// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS, 
		/// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the texture parameters.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM error is generated by Gl.GetTexParameter if the effective <paramref name="target"/> is not one of the 
		/// accepted texture targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetTextureParameter* if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TextureView"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetTextureParameter(UInt32 texture, GetTextureParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTextureParameteriv != null, "pglGetTextureParameteriv not implemented");
					Delegates.pglGetTextureParameteriv(texture, (Int32)pname, p_params);
					LogCommand("glGetTextureParameteriv", null, texture, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// create vertex array objects
		/// </summary>
		/// <param name="n">
		/// Number of vertex array objects to create.
		/// </param>
		/// <param name="arrays">
		/// Specifies an array in which names of the new vertex array objects are stored.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BindVertexArray"/>
		/// <seealso cref="Gl.DeleteVertexArrays"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.GenVertexArrays"/>
		/// <seealso cref="Gl.IsVertexArray"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void CreateVertexArrays(Int32 n, UInt32[] arrays)
		{
			unsafe {
				fixed (UInt32* p_arrays = arrays)
				{
					Debug.Assert(Delegates.pglCreateVertexArrays != null, "pglCreateVertexArrays not implemented");
					Delegates.pglCreateVertexArrays(n, p_arrays);
					LogCommand("glCreateVertexArrays", null, n, arrays					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Enable or disable a generic vertex attribute array
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of the vertex array object for Gl.DisableVertexArrayAttrib and Gl.EnableVertexArrayAttrib functions.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be enabled or disabled.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.EnableVertexAttribArray and Gl.DisableVertexAttribArray if no vertex array 
		/// object is bound.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.EnableVertexArrayAttrib and Gl.DisableVertexArrayAttrib if <paramref 
		/// name="vaobj"/> is not the name of an existing vertex array object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void DisableVertexArrayAttrib(UInt32 vaobj, UInt32 index)
		{
			Debug.Assert(Delegates.pglDisableVertexArrayAttrib != null, "pglDisableVertexArrayAttrib not implemented");
			Delegates.pglDisableVertexArrayAttrib(vaobj, index);
			LogCommand("glDisableVertexArrayAttrib", null, vaobj, index			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Enable or disable a generic vertex attribute array
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of the vertex array object for Gl.DisableVertexArrayAttrib and Gl.EnableVertexArrayAttrib functions.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be enabled or disabled.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.EnableVertexAttribArray and Gl.DisableVertexAttribArray if no vertex array 
		/// object is bound.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.EnableVertexArrayAttrib and Gl.DisableVertexArrayAttrib if <paramref 
		/// name="vaobj"/> is not the name of an existing vertex array object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void EnableVertexArrayAttrib(UInt32 vaobj, UInt32 index)
		{
			Debug.Assert(Delegates.pglEnableVertexArrayAttrib != null, "pglEnableVertexArrayAttrib not implemented");
			Delegates.pglEnableVertexArrayAttrib(vaobj, index);
			LogCommand("glEnableVertexArrayAttrib", null, vaobj, index			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// configures element array buffer binding of a vertex array object
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of the vertex array object.
		/// </param>
		/// <param name="buffer">
		/// Specifies the name of the buffer object to use for the element array buffer binding.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION error is generated if <paramref name="vaobj"/> is not the name of an existing vertex array object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION error is generated if <paramref name="buffer"/> is not zero or the name of an existing buffer 
		/// object.
		/// </exception>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetVertexArrayiv"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayElementBuffer(UInt32 vaobj, UInt32 buffer)
		{
			Debug.Assert(Delegates.pglVertexArrayElementBuffer != null, "pglVertexArrayElementBuffer not implemented");
			Delegates.pglVertexArrayElementBuffer(vaobj, buffer);
			LogCommand("glVertexArrayElementBuffer", null, vaobj, buffer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// bind a buffer to a vertex buffer bind point
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of the vertex array object to be used by Gl.VertexArrayVertexBuffer function.
		/// </param>
		/// <param name="bindingindex">
		/// The index of the vertex buffer binding point to which to bind the buffer.
		/// </param>
		/// <param name="buffer">
		/// The name of a buffer to bind to the vertex buffer binding point.
		/// </param>
		/// <param name="offset">
		/// The offset of the first element of the buffer.
		/// </param>
		/// <param name="stride">
		/// The distance between elements within the buffer.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.BindVertexBuffer if no vertex array object is bound.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexArrayVertexBuffer if <paramref name="vaobj"/> is not the name of an 
		/// existing vertex array object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bindingindex"/> is greater than or equal to the value of 
		/// Gl.MAX_VERTEX_ATTRIB_BINDINGS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="stride"/> is less than zero, or if stride 
		/// is greater than the value of Gl.MAX_VERTEX_ATTRIB_STRIDE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> is not zero or the name of an existing buffer object (as 
		/// returned by Gl.GenBuffers or Gl.CreateBuffers).
		/// </exception>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribFormat"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayVertexBuffer(UInt32 vaobj, UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride)
		{
			Debug.Assert(Delegates.pglVertexArrayVertexBuffer != null, "pglVertexArrayVertexBuffer not implemented");
			Delegates.pglVertexArrayVertexBuffer(vaobj, bindingindex, buffer, offset, stride);
			LogCommand("glVertexArrayVertexBuffer", null, vaobj, bindingindex, buffer, offset, stride			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// attach multiple buffer objects to a vertex array object
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of the vertex array object for Gl.VertexArrayVertexBuffers.
		/// </param>
		/// <param name="first">
		/// Specifies the first vertex buffer binding point to which a buffer object is to be bound.
		/// </param>
		/// <param name="count">
		/// Specifies the number of buffers to bind.
		/// </param>
		/// <param name="buffers">
		/// Specifies the address of an array of names of existing buffer objects.
		/// </param>
		/// <param name="offsets">
		/// Specifies the address of an array of offsets to associate with the binding points.
		/// </param>
		/// <param name="strides">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.BindVertexBuffers if no vertex array object is bound.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexArrayVertexBuffers if <paramref name="vaobj"/> is not the name of the 
		/// vertex array object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if $first + count$ is greater than the value of Gl.MAX_VERTEX_ATTRIB_BINDINGS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if any value in Gl.fers is not zero or the name of an existing buffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if any value in <paramref name="offsets"/> or <paramref name="strides"/> is negative, or 
		/// if a value is <paramref name="stride"/> is greater than the value of Gl.MAX_VERTEX_ATTRIB_STRIDE.
		/// </exception>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.DeleteTextures"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayVertexBuffers(UInt32 vaobj, UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, Int32[] strides)
		{
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				fixed (IntPtr* p_offsets = offsets)
				fixed (Int32* p_strides = strides)
				{
					Debug.Assert(Delegates.pglVertexArrayVertexBuffers != null, "pglVertexArrayVertexBuffers not implemented");
					Delegates.pglVertexArrayVertexBuffers(vaobj, first, count, p_buffers, p_offsets, p_strides);
					LogCommand("glVertexArrayVertexBuffers", null, vaobj, first, count, buffers, offsets, strides					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// associate a vertex attribute and a vertex buffer binding for a vertex array object
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of the vertex array object for Gl.VertexArrayAttribBinding.
		/// </param>
		/// <param name="attribindex">
		/// The index of the attribute to associate with a vertex buffer binding.
		/// </param>
		/// <param name="bindingindex">
		/// The index of the vertex buffer binding with which to associate the generic vertex attribute.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexAttribBinding if no vertex array object is bound.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexArrayAttribBinding if <paramref name="vaobj"/> is not the name of an 
		/// existing vertex array object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="attribindex"/> is greater than or equal to the value of 
		/// Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bindingindex"/> is greater than or equal to the value of 
		/// Gl.MAX_VERTEX_ATTRIB_BINDINGS.
		/// </exception>
		/// <seealso cref="Gl.BindVertexBuffer"/>
		/// <seealso cref="Gl.VertexAttribFormat"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayAttribBinding(UInt32 vaobj, UInt32 attribindex, UInt32 bindingindex)
		{
			Debug.Assert(Delegates.pglVertexArrayAttribBinding != null, "pglVertexArrayAttribBinding not implemented");
			Delegates.pglVertexArrayAttribBinding(vaobj, attribindex, bindingindex);
			LogCommand("glVertexArrayAttribBinding", null, vaobj, attribindex, bindingindex			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the organization of vertex arrays
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of the vertex array object for Gl.VertexArrayAttrib{I, L}Format functions.
		/// </param>
		/// <param name="attribindex">
		/// The generic vertex attribute array being described.
		/// </param>
		/// <param name="size">
		/// The number of values per vertex that are stored in the array.
		/// </param>
		/// <param name="type">
		/// The type of the data stored in the array.
		/// </param>
		/// <param name="normalized">
		/// Specifies whether fixed-point data values should be normalized (Gl.TRUE) or converted directly as fixed-point values 
		/// (Gl.FALSE) when they are accessed. This parameter is ignored if <paramref name="type"/> is Gl.FIXED.
		/// </param>
		/// <param name="relativeoffset">
		/// The distance between elements within the buffer.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="attribindex"/> is greater than or equal to the value of 
		/// Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not one of the accepted values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="relativeoffset"/> is greater than the value of 
		/// Gl.MAX_VERTEX_ATTRIB_RELATIVE_OFFSET.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the accepted tokens.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.VertexAttribIFormat, Gl.VertexAttribLFormat, Gl.VertexArrayAttribIFormat and 
		/// Gl.VertexArrayAttribLFormat if <paramref name="type"/> is Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexAttribFormat, Gl.VertexAttribIFormat and Gl.VertexAttribLFormat if no 
		/// vertex array object is bound.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexArrayAttribFormat, Gl.VertexArrayAttribIFormat and 
		/// Gl.VertexArrayAttribLFormat if <paramref name="vaobj"/> is not the name of an existing vertex array object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated under any of the following conditions:
		/// </exception>
		/// <exception cref="KhronosException">
		/// <paramref name="size"/> is Gl.BGRA and <paramref name="type"/> is not Gl.UNSIGNED_BYTE, Gl.INT_2_10_10_10_REV or 
		/// Gl.UNSIGNED_INT_2_10_10_10_REV.<paramref name="type"/> is Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV, and 
		/// <paramref name="size"/> is neither 4 nor Gl.BGRA.<paramref name="type"/> is Gl.UNSIGNED_INT_10F_11F_11F_REV and 
		/// <paramref name="size"/> is not 3.<paramref name="size"/> is Gl.BGRA and <paramref name="normalized"/> is Gl.FALSE.
		/// </exception>
		/// <seealso cref="Gl.BindVertexBuffer"/>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayAttribFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, VertexAttribType type, bool normalized, UInt32 relativeoffset)
		{
			Debug.Assert(Delegates.pglVertexArrayAttribFormat != null, "pglVertexArrayAttribFormat not implemented");
			Delegates.pglVertexArrayAttribFormat(vaobj, attribindex, size, (Int32)type, normalized, relativeoffset);
			LogCommand("glVertexArrayAttribFormat", null, vaobj, attribindex, size, type, normalized, relativeoffset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the organization of vertex arrays
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of the vertex array object for Gl.VertexArrayAttrib{I, L}Format functions.
		/// </param>
		/// <param name="attribindex">
		/// The generic vertex attribute array being described.
		/// </param>
		/// <param name="size">
		/// The number of values per vertex that are stored in the array.
		/// </param>
		/// <param name="type">
		/// The type of the data stored in the array.
		/// </param>
		/// <param name="relativeoffset">
		/// The distance between elements within the buffer.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="attribindex"/> is greater than or equal to the value of 
		/// Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not one of the accepted values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="relativeoffset"/> is greater than the value of 
		/// Gl.MAX_VERTEX_ATTRIB_RELATIVE_OFFSET.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the accepted tokens.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.VertexAttribIFormat, Gl.VertexAttribLFormat, Gl.VertexArrayAttribIFormat and 
		/// Gl.VertexArrayAttribLFormat if <paramref name="type"/> is Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexAttribFormat, Gl.VertexAttribIFormat and Gl.VertexAttribLFormat if no 
		/// vertex array object is bound.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexArrayAttribFormat, Gl.VertexArrayAttribIFormat and 
		/// Gl.VertexArrayAttribLFormat if <paramref name="vaobj"/> is not the name of an existing vertex array object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated under any of the following conditions:
		/// </exception>
		/// <exception cref="KhronosException">
		/// <paramref name="size"/> is Gl.BGRA and <paramref name="type"/> is not Gl.UNSIGNED_BYTE, Gl.INT_2_10_10_10_REV or 
		/// Gl.UNSIGNED_INT_2_10_10_10_REV.<paramref name="type"/> is Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV, and 
		/// <paramref name="size"/> is neither 4 nor Gl.BGRA.<paramref name="type"/> is Gl.UNSIGNED_INT_10F_11F_11F_REV and 
		/// <paramref name="size"/> is not 3.<paramref name="size"/> is Gl.BGRA and <paramref name="normalized"/> is Gl.FALSE.
		/// </exception>
		/// <seealso cref="Gl.BindVertexBuffer"/>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayAttribIFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, VertexAttribType type, UInt32 relativeoffset)
		{
			Debug.Assert(Delegates.pglVertexArrayAttribIFormat != null, "pglVertexArrayAttribIFormat not implemented");
			Delegates.pglVertexArrayAttribIFormat(vaobj, attribindex, size, (Int32)type, relativeoffset);
			LogCommand("glVertexArrayAttribIFormat", null, vaobj, attribindex, size, type, relativeoffset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the organization of vertex arrays
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of the vertex array object for Gl.VertexArrayAttrib{I, L}Format functions.
		/// </param>
		/// <param name="attribindex">
		/// The generic vertex attribute array being described.
		/// </param>
		/// <param name="size">
		/// The number of values per vertex that are stored in the array.
		/// </param>
		/// <param name="type">
		/// The type of the data stored in the array.
		/// </param>
		/// <param name="relativeoffset">
		/// The distance between elements within the buffer.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="attribindex"/> is greater than or equal to the value of 
		/// Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not one of the accepted values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="relativeoffset"/> is greater than the value of 
		/// Gl.MAX_VERTEX_ATTRIB_RELATIVE_OFFSET.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of the accepted tokens.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.VertexAttribIFormat, Gl.VertexAttribLFormat, Gl.VertexArrayAttribIFormat and 
		/// Gl.VertexArrayAttribLFormat if <paramref name="type"/> is Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexAttribFormat, Gl.VertexAttribIFormat and Gl.VertexAttribLFormat if no 
		/// vertex array object is bound.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexArrayAttribFormat, Gl.VertexArrayAttribIFormat and 
		/// Gl.VertexArrayAttribLFormat if <paramref name="vaobj"/> is not the name of an existing vertex array object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated under any of the following conditions:
		/// </exception>
		/// <exception cref="KhronosException">
		/// <paramref name="size"/> is Gl.BGRA and <paramref name="type"/> is not Gl.UNSIGNED_BYTE, Gl.INT_2_10_10_10_REV or 
		/// Gl.UNSIGNED_INT_2_10_10_10_REV.<paramref name="type"/> is Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV, and 
		/// <paramref name="size"/> is neither 4 nor Gl.BGRA.<paramref name="type"/> is Gl.UNSIGNED_INT_10F_11F_11F_REV and 
		/// <paramref name="size"/> is not 3.<paramref name="size"/> is Gl.BGRA and <paramref name="normalized"/> is Gl.FALSE.
		/// </exception>
		/// <seealso cref="Gl.BindVertexBuffer"/>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayAttribLFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, VertexAttribType type, UInt32 relativeoffset)
		{
			Debug.Assert(Delegates.pglVertexArrayAttribLFormat != null, "pglVertexArrayAttribLFormat not implemented");
			Delegates.pglVertexArrayAttribLFormat(vaobj, attribindex, size, (Int32)type, relativeoffset);
			LogCommand("glVertexArrayAttribLFormat", null, vaobj, attribindex, size, type, relativeoffset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// modify the rate at which generic vertex attributes advance
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of the vertex array object for Gl.VertexArrayBindingDivisor function.
		/// </param>
		/// <param name="bindingindex">
		/// The index of the binding whose divisor to modify.
		/// </param>
		/// <param name="divisor">
		/// The new value for the instance step rate to apply.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bindingindex"/> is greater than or equal to the value of 
		/// Gl.MAX_VERTEX_ATTRIB_BINDINGS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION by Gl.VertexBindingDivisor is generated if no vertex array object is bound.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexArrayBindingDivisor if <paramref name="vaobj"/> is not the name of an 
		/// existing vertex array object.
		/// </exception>
		/// <seealso cref="Gl.BindVertexBuffer"/>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void VertexArrayBindingDivisor(UInt32 vaobj, UInt32 bindingindex, UInt32 divisor)
		{
			Debug.Assert(Delegates.pglVertexArrayBindingDivisor != null, "pglVertexArrayBindingDivisor not implemented");
			Delegates.pglVertexArrayBindingDivisor(vaobj, bindingindex, divisor);
			LogCommand("glVertexArrayBindingDivisor", null, vaobj, bindingindex, divisor			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetVertexArrayiv.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:VertexArrayPName"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetVertexArray(UInt32 vaobj, VertexArrayPName pname, [Out] Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglGetVertexArrayiv != null, "pglGetVertexArrayiv not implemented");
					Delegates.pglGetVertexArrayiv(vaobj, (Int32)pname, p_param);
					LogCommand("glGetVertexArrayiv", null, vaobj, pname, param					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve parameters of an attribute of a vertex array object
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of a vertex array object.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the vertex array object attribute. Must be a number between 0 and (Gl.MAX_VERTEX_ATTRIBS - 1).
		/// </param>
		/// <param name="pname">
		/// Specifies the property to be used for the query. For Gl.GetVertexArrayIndexediv, it must be one of the following values: 
		/// Gl.VERTEX_ATTRIB_ARRAY_ENABLED, Gl.VERTEX_ATTRIB_ARRAY_SIZE, Gl.VERTEX_ATTRIB_ARRAY_STRIDE, Gl.VERTEX_ATTRIB_ARRAY_TYPE, 
		/// Gl.VERTEX_ATTRIB_ARRAY_NORMALIZED, Gl.VERTEX_ATTRIB_ARRAY_INTEGER, Gl.VERTEX_ATTRIB_ARRAY_LONG, 
		/// Gl.VERTEX_ATTRIB_ARRAY_DIVISOR, or Gl.VERTEX_ATTRIB_RELATIVE_OFFSET. For Gl.GetVertexArrayIndexed64v, it must be equal 
		/// to Gl.VERTEX_BINDING_OFFSET.
		/// </param>
		/// <param name="param">
		/// Returns the requested value.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION error is generated if <paramref name="vaobj"/> is not the name of an existing vertex array object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated if index is greater than or equal to the value of Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM error is generated if <paramref name="pname"/> is not one of the valid values. For more details, please 
		/// see above.
		/// </exception>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetVertexArrayIndexed(UInt32 vaobj, UInt32 index, VertexArrayPName pname, [Out] Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglGetVertexArrayIndexediv != null, "pglGetVertexArrayIndexediv not implemented");
					Delegates.pglGetVertexArrayIndexediv(vaobj, index, (Int32)pname, p_param);
					LogCommand("glGetVertexArrayIndexediv", null, vaobj, index, pname, param					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve parameters of an attribute of a vertex array object
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of a vertex array object.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the vertex array object attribute. Must be a number between 0 and (Gl.MAX_VERTEX_ATTRIBS - 1).
		/// </param>
		/// <param name="pname">
		/// Specifies the property to be used for the query. For Gl.GetVertexArrayIndexediv, it must be one of the following values: 
		/// Gl.VERTEX_ATTRIB_ARRAY_ENABLED, Gl.VERTEX_ATTRIB_ARRAY_SIZE, Gl.VERTEX_ATTRIB_ARRAY_STRIDE, Gl.VERTEX_ATTRIB_ARRAY_TYPE, 
		/// Gl.VERTEX_ATTRIB_ARRAY_NORMALIZED, Gl.VERTEX_ATTRIB_ARRAY_INTEGER, Gl.VERTEX_ATTRIB_ARRAY_LONG, 
		/// Gl.VERTEX_ATTRIB_ARRAY_DIVISOR, or Gl.VERTEX_ATTRIB_RELATIVE_OFFSET. For Gl.GetVertexArrayIndexed64v, it must be equal 
		/// to Gl.VERTEX_BINDING_OFFSET.
		/// </param>
		/// <param name="param">
		/// Returns the requested value.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION error is generated if <paramref name="vaobj"/> is not the name of an existing vertex array object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated if index is greater than or equal to the value of Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM error is generated if <paramref name="pname"/> is not one of the valid values. For more details, please 
		/// see above.
		/// </exception>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetVertexArrayIndexed(UInt32 vaobj, UInt32 index, VertexArrayPName pname, [Out] Int64[] param)
		{
			unsafe {
				fixed (Int64* p_param = param)
				{
					Debug.Assert(Delegates.pglGetVertexArrayIndexed64iv != null, "pglGetVertexArrayIndexed64iv not implemented");
					Delegates.pglGetVertexArrayIndexed64iv(vaobj, index, (Int32)pname, p_param);
					LogCommand("glGetVertexArrayIndexed64iv", null, vaobj, index, pname, param					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// create sampler objects
		/// </summary>
		/// <param name="n">
		/// Number of sampler objects to create.
		/// </param>
		/// <param name="samplers">
		/// Specifies an array in which names of the new sampler objects are stored.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BindSampler"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.DeleteSamplers"/>
		/// <seealso cref="Gl.DeleteTextures"/>
		/// <seealso cref="Gl.GenSamplers"/>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetSamplerParameter"/>
		/// <seealso cref="Gl.SamplerParameter"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void CreateSamplers(Int32 n, UInt32[] samplers)
		{
			unsafe {
				fixed (UInt32* p_samplers = samplers)
				{
					Debug.Assert(Delegates.pglCreateSamplers != null, "pglCreateSamplers not implemented");
					Delegates.pglCreateSamplers(n, p_samplers);
					LogCommand("glCreateSamplers", null, n, samplers					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// create program pipeline objects
		/// </summary>
		/// <param name="n">
		/// Number of program pipeline objects to create.
		/// </param>
		/// <param name="pipelines">
		/// Specifies an array in which names of the new program pipeline objects are stored.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BindProgramPipeline"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.GenProgramPipelines"/>
		/// <seealso cref="Gl.DeleteProgramPipelines"/>
		/// <seealso cref="Gl.IsProgramPipeline"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void CreateProgramPipelines(Int32 n, UInt32[] pipelines)
		{
			unsafe {
				fixed (UInt32* p_pipelines = pipelines)
				{
					Debug.Assert(Delegates.pglCreateProgramPipelines != null, "pglCreateProgramPipelines not implemented");
					Delegates.pglCreateProgramPipelines(n, p_pipelines);
					LogCommand("glCreateProgramPipelines", null, n, pipelines					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// create query objects
		/// </summary>
		/// <param name="target">
		/// Specifies the target of each created query object.
		/// </param>
		/// <param name="n">
		/// Number of query objects to create.
		/// </param>
		/// <param name="ids">
		/// Specifies an array in which names of the new query objects are stored.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.BeginQueryIndexed"/>
		/// <seealso cref="Gl.DeleteQueries"/>
		/// <seealso cref="Gl.GenQueries"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.IsQuery"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void CreateQueries(QueryTarget target, Int32 n, UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglCreateQueries != null, "pglCreateQueries not implemented");
					Delegates.pglCreateQueries((Int32)target, n, p_ids);
					LogCommand("glCreateQueries", null, target, n, ids					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetQueryBufferObjecti64v.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:QueryObjectParameterName"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetQueryBufferObject64i(UInt32 id, UInt32 buffer, QueryObjectParameterName pname, IntPtr offset)
		{
			Debug.Assert(Delegates.pglGetQueryBufferObjecti64v != null, "pglGetQueryBufferObjecti64v not implemented");
			Delegates.pglGetQueryBufferObjecti64v(id, buffer, (Int32)pname, offset);
			LogCommand("glGetQueryBufferObjecti64v", null, id, buffer, pname, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetQueryBufferObjectiv.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:QueryObjectParameterName"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetQueryBufferObject32i(UInt32 id, UInt32 buffer, QueryObjectParameterName pname, IntPtr offset)
		{
			Debug.Assert(Delegates.pglGetQueryBufferObjectiv != null, "pglGetQueryBufferObjectiv not implemented");
			Delegates.pglGetQueryBufferObjectiv(id, buffer, (Int32)pname, offset);
			LogCommand("glGetQueryBufferObjectiv", null, id, buffer, pname, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetQueryBufferObjectui64v.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:QueryObjectParameterName"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetQueryBufferObject64ui(UInt32 id, UInt32 buffer, QueryObjectParameterName pname, IntPtr offset)
		{
			Debug.Assert(Delegates.pglGetQueryBufferObjectui64v != null, "pglGetQueryBufferObjectui64v not implemented");
			Delegates.pglGetQueryBufferObjectui64v(id, buffer, (Int32)pname, offset);
			LogCommand("glGetQueryBufferObjectui64v", null, id, buffer, pname, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetQueryBufferObjectuiv.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:QueryObjectParameterName"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		public static void GetQueryBufferObject32ui(UInt32 id, UInt32 buffer, QueryObjectParameterName pname, IntPtr offset)
		{
			Debug.Assert(Delegates.pglGetQueryBufferObjectuiv != null, "pglGetQueryBufferObjectuiv not implemented");
			Delegates.pglGetQueryBufferObjectuiv(id, buffer, (Int32)pname, offset);
			LogCommand("glGetQueryBufferObjectuiv", null, id, buffer, pname, offset			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// defines a barrier ordering memory transactions
		/// </summary>
		/// <param name="barriers">
		/// Specifies the barriers to insert.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="barriers"/> is not the special value Gl.ALL_BARRIER_BITS, and has any 
		/// bits set other than those described above for Gl.MemoryBarrier or Gl.MemoryBarrierByRegion respectively.
		/// </exception>
		/// <seealso cref="Gl.BindImageTexture"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		/// <seealso cref="Gl.FlushMappedBufferRange"/>
		/// <seealso cref="Gl.moryBarrier"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_1_compatibility", Api = "gl|glcore")]
		public static void MemoryBarrierByRegion(UInt32 barriers)
		{
			Debug.Assert(Delegates.pglMemoryBarrierByRegion != null, "pglMemoryBarrierByRegion not implemented");
			Delegates.pglMemoryBarrierByRegion(barriers);
			LogCommand("glMemoryBarrierByRegion", null, barriers			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve a sub-region of a texture image from a texture object
		/// </summary>
		/// <param name="texture">
		/// Specifies the name of the source texture object. Must be Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D, 
		/// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP, Gl.TEXTURE_CUBE_MAP_ARRAY or Gl.TEXTURE_RECTANGLE. In specific, 
		/// buffer and multisample textures are not permitted.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level $n$ is the $n$th mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="zoffset">
		/// Specifies a texel offset in the z direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.RED, Gl.RG, Gl.RGB, Gl.BGR, 
		/// Gl.RGBA, Gl.BGRA, Gl.DEPTH_COMPONENT and Gl.STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer to receive the retrieved pixel data.
		/// </param>
		/// <param name="pixels">
		/// Returns the texture subimage. Should be a pointer to an array of the type specified by <paramref name="type"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated if <paramref name="texture"/> is not the name of an existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION error is generated if <paramref name="texture"/> is the name of a buffer or multisample texture.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="xoffset"/>, <paramref name="yoffset"/> or <paramref name="zoffset"/> 
		/// are negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="xoffset"/> + <paramref name="width"/> is greater than the texture's 
		/// width, <paramref name="yoffset"/> + <paramref name="height"/> is greater than the texture's height, or <paramref 
		/// name="zoffset"/> + <paramref name="depth"/> is greater than the texture's depth.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated if the effective target is Gl.TEXTURE_1D and either <paramref name="yoffset"/> is 
		/// not zero, or <paramref name="height"/> is not one.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated if the effective target is Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D or 
		/// Gl.TEXTURE_RECTANGLE and either <paramref name="zoffset"/> is not zero, or <paramref name="depth"/> is not one.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION error is generated if the buffer size required to store the requested data is greater than 
		/// <paramref name="bufSize"/>.
		/// </exception>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_get_texture_sub_image", Api = "gl|glcore")]
		public static void GetTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, Int32 bufSize, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetTextureSubImage != null, "pglGetTextureSubImage not implemented");
			Delegates.pglGetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, (Int32)format, (Int32)type, bufSize, pixels);
			LogCommand("glGetTextureSubImage", null, texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve a sub-region of a texture image from a texture object
		/// </summary>
		/// <param name="texture">
		/// Specifies the name of the source texture object. Must be Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D, 
		/// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP, Gl.TEXTURE_CUBE_MAP_ARRAY or Gl.TEXTURE_RECTANGLE. In specific, 
		/// buffer and multisample textures are not permitted.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level $n$ is the $n$th mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="zoffset">
		/// Specifies a texel offset in the z direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture subimage.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.RED, Gl.RG, Gl.RGB, Gl.BGR, 
		/// Gl.RGBA, Gl.BGRA, Gl.DEPTH_COMPONENT and Gl.STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer to receive the retrieved pixel data.
		/// </param>
		/// <param name="pixels">
		/// Returns the texture subimage. Should be a pointer to an array of the type specified by <paramref name="type"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated if <paramref name="texture"/> is not the name of an existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION error is generated if <paramref name="texture"/> is the name of a buffer or multisample texture.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="xoffset"/>, <paramref name="yoffset"/> or <paramref name="zoffset"/> 
		/// are negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="xoffset"/> + <paramref name="width"/> is greater than the texture's 
		/// width, <paramref name="yoffset"/> + <paramref name="height"/> is greater than the texture's height, or <paramref 
		/// name="zoffset"/> + <paramref name="depth"/> is greater than the texture's depth.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated if the effective target is Gl.TEXTURE_1D and either <paramref name="yoffset"/> is 
		/// not zero, or <paramref name="height"/> is not one.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated if the effective target is Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D or 
		/// Gl.TEXTURE_RECTANGLE and either <paramref name="zoffset"/> is not zero, or <paramref name="depth"/> is not one.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION error is generated if the buffer size required to store the requested data is greater than 
		/// <paramref name="bufSize"/>.
		/// </exception>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_get_texture_sub_image", Api = "gl|glcore")]
		public static void GetTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, PixelType type, Int32 bufSize, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// retrieve a sub-region of a compressed texture image from a compressed texture object
		/// </summary>
		/// <param name="texture">
		/// Specifies the name of the source texture object. Must be Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D, 
		/// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP, Gl.TEXTURE_CUBE_MAP_ARRAY or Gl.TEXTURE_RECTANGLE. In specific, 
		/// buffer and multisample textures are not permitted.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level $n$ is the $n$th mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="zoffset">
		/// Specifies a texel offset in the z direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage. Must be a multiple of the compressed block's width, unless the <paramref 
		/// name="offset"/> is zero and the size equals the texture image size.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage. Must be a multiple of the compressed block's height, unless the <paramref 
		/// name="offset"/> is zero and the size equals the texture image size.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture subimage. Must be a multiple of the compressed block's depth, unless the <paramref 
		/// name="offset"/> is zero and the size equals the texture image size.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer to receive the retrieved pixel data.
		/// </param>
		/// <param name="pixels">
		/// Returns the texture subimage. Should be a pointer to an array of the type specified by type.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION error is generated if <paramref name="texture"/> is the name of a buffer or multisample texture.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION error is generated if the buffer size required to store the requested data is greater than 
		/// <paramref name="bufSize"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION error is generated if the texture compression format is not based on fixed-size blocks.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated if <paramref name="texture"/> is not the name of an existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="xoffset"/>, <paramref name="yoffset"/> or <paramref name="zoffset"/> 
		/// are negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="xoffset"/> + <paramref name="width"/> is greater than the texture's 
		/// width, <paramref name="yoffset"/> + <paramref name="height"/> is greater than the texture's height, or <paramref 
		/// name="zoffset"/> + <paramref name="depth"/> is greater than the texture's depth.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated if the effective target is Gl.TEXTURE_1D and either <paramref name="yoffset"/> is 
		/// not zero, or <paramref name="height"/> is not one.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated if the effective target is Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D or 
		/// Gl.TEXTURE_RECTANGLE and either <paramref name="zoffset"/> is not zero, or <paramref name="depth"/> is not one.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated if <paramref name="xoffset"/>, <paramref name="yoffset"/> or <paramref 
		/// name="zoffset"/> is not a multiple of the compressed block width, height or depth respectively.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated if <paramref name="width"/>, <paramref name="height"/> or <paramref name="depth"/> 
		/// is not a multiple of the compressed block width, height or depth respectively, unless the <paramref name="offset"/> is 
		/// zero and the <paramref name="size"/> equals the texture image size.
		/// </exception>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.ReadPixels"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_get_texture_sub_image", Api = "gl|glcore")]
		public static void GetCompressedTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 bufSize, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetCompressedTextureSubImage != null, "pglGetCompressedTextureSubImage not implemented");
			Delegates.pglGetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
			LogCommand("glGetCompressedTextureSubImage", null, texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve a sub-region of a compressed texture image from a compressed texture object
		/// </summary>
		/// <param name="texture">
		/// Specifies the name of the source texture object. Must be Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D, 
		/// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP, Gl.TEXTURE_CUBE_MAP_ARRAY or Gl.TEXTURE_RECTANGLE. In specific, 
		/// buffer and multisample textures are not permitted.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level $n$ is the $n$th mipmap reduction image.
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array.
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array.
		/// </param>
		/// <param name="zoffset">
		/// Specifies a texel offset in the z direction within the texture array.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage. Must be a multiple of the compressed block's width, unless the <paramref 
		/// name="offset"/> is zero and the size equals the texture image size.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage. Must be a multiple of the compressed block's height, unless the <paramref 
		/// name="offset"/> is zero and the size equals the texture image size.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture subimage. Must be a multiple of the compressed block's depth, unless the <paramref 
		/// name="offset"/> is zero and the size equals the texture image size.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer to receive the retrieved pixel data.
		/// </param>
		/// <param name="pixels">
		/// Returns the texture subimage. Should be a pointer to an array of the type specified by type.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION error is generated if <paramref name="texture"/> is the name of a buffer or multisample texture.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION error is generated if the buffer size required to store the requested data is greater than 
		/// <paramref name="bufSize"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION error is generated if the texture compression format is not based on fixed-size blocks.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated if <paramref name="texture"/> is not the name of an existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="xoffset"/>, <paramref name="yoffset"/> or <paramref name="zoffset"/> 
		/// are negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="xoffset"/> + <paramref name="width"/> is greater than the texture's 
		/// width, <paramref name="yoffset"/> + <paramref name="height"/> is greater than the texture's height, or <paramref 
		/// name="zoffset"/> + <paramref name="depth"/> is greater than the texture's depth.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated if the effective target is Gl.TEXTURE_1D and either <paramref name="yoffset"/> is 
		/// not zero, or <paramref name="height"/> is not one.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated if the effective target is Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D or 
		/// Gl.TEXTURE_RECTANGLE and either <paramref name="zoffset"/> is not zero, or <paramref name="depth"/> is not one.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated if <paramref name="xoffset"/>, <paramref name="yoffset"/> or <paramref 
		/// name="zoffset"/> is not a multiple of the compressed block width, height or depth respectively.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE error is generated if <paramref name="width"/>, <paramref name="height"/> or <paramref name="depth"/> 
		/// is not a multiple of the compressed block width, height or depth respectively, unless the <paramref name="offset"/> is 
		/// zero and the <paramref name="size"/> equals the texture image size.
		/// </exception>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.ReadPixels"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_get_texture_sub_image", Api = "gl|glcore")]
		public static void GetCompressedTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 bufSize, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				GetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// check if the rendering context has not been lost due to software or hardware issues
		/// </summary>
		/// <seealso cref="Gl.GetError"/>
		[AliasOf("glGetGraphicsResetStatusKHR")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_robustness")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gles2")]
		public static GraphicsResetStatus GetGraphicsResetStatus()
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetGraphicsResetStatus != null, "pglGetGraphicsResetStatus not implemented");
			retValue = Delegates.pglGetGraphicsResetStatus();
			LogCommand("glGetGraphicsResetStatus", (GraphicsResetStatus)retValue			);
			DebugCheckErrors(retValue);

			return ((GraphicsResetStatus)retValue);
		}

		/// <summary>
		/// return a compressed texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.GetCompressedTexImage and Gl.GetnCompressedTexImage functions. 
		/// Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D, Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP_ARRAY, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, and Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, Gl.TEXTURE_RECTANGLE 
		/// are accepted.
		/// </param>
		/// <param name="lod">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer <paramref name="pixels"/> for Gl.GetCompressedTextureImage and 
		/// Gl.GetnCompressedTexImage functions.
		/// </param>
		/// <param name="pixels">
		/// Returns the compressed texture image.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetCompressedTextureImage if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than zero or greater than the maximum number of LODs 
		/// permitted by the implementation.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetCompressedTexImage, Gl.GetnCompressedTexImage, and 
		/// Gl.GetCompressedTextureImage is used to retrieve a texture that is in an uncompressed internal format.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target, the 
		/// buffer storage was not initialized with Gl.BufferStorage using Gl.MAP_PERSISTENT_BIT flag, and the buffer object's data 
		/// store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		public static void GetnCompressedTexImage(TextureTarget target, Int32 lod, Int32 bufSize, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetnCompressedTexImage != null, "pglGetnCompressedTexImage not implemented");
			Delegates.pglGetnCompressedTexImage((Int32)target, lod, bufSize, pixels);
			LogCommand("glGetnCompressedTexImage", null, target, lod, bufSize, pixels			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return a compressed texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.GetCompressedTexImage and Gl.GetnCompressedTexImage functions. 
		/// Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D, Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP_ARRAY, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, and Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, Gl.TEXTURE_RECTANGLE 
		/// are accepted.
		/// </param>
		/// <param name="lod">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer <paramref name="pixels"/> for Gl.GetCompressedTextureImage and 
		/// Gl.GetnCompressedTexImage functions.
		/// </param>
		/// <param name="pixels">
		/// Returns the compressed texture image.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetCompressedTextureImage if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than zero or greater than the maximum number of LODs 
		/// permitted by the implementation.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetCompressedTexImage, Gl.GetnCompressedTexImage, and 
		/// Gl.GetCompressedTextureImage is used to retrieve a texture that is in an uncompressed internal format.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target, the 
		/// buffer storage was not initialized with Gl.BufferStorage using Gl.MAP_PERSISTENT_BIT flag, and the buffer object's data 
		/// store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		public static void GetnCompressedTexImage(TextureTarget target, Int32 lod, Int32 bufSize, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				GetnCompressedTexImage(target, lod, bufSize, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// Binding for glGetnTexImage.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		public static void GetnTexImage(TextureTarget target, Int32 level, PixelFormat format, PixelType type, Int32 bufSize, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetnTexImage != null, "pglGetnTexImage not implemented");
			Delegates.pglGetnTexImage((Int32)target, level, (Int32)format, (Int32)type, bufSize, pixels);
			LogCommand("glGetnTexImage", null, target, level, format, type, bufSize, pixels			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnTexImage.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		public static void GetnTexImage(TextureTarget target, Int32 level, PixelFormat format, PixelType type, Int32 bufSize, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				GetnTexImage(target, level, format, type, bufSize, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// Returns the value of a uniform variable
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be queried.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer <paramref name="params"/>.
		/// </param>
		/// <param name="params">
		/// Returns the value of the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> has not been successfully linked.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> does not correspond to a valid uniform variable 
		/// location for the specified program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetnUniform if the buffer size required to store the requested data is greater 
		/// than <paramref name="bufSize"/>.
		/// </exception>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		public static void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [Out] double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformdv != null, "pglGetnUniformdv not implemented");
					Delegates.pglGetnUniformdv(program, location, bufSize, p_params);
					LogCommand("glGetnUniformdv", null, program, location, bufSize, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Returns the value of a uniform variable
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be queried.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer <paramref name="params"/>.
		/// </param>
		/// <param name="params">
		/// Returns the value of the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> has not been successfully linked.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> does not correspond to a valid uniform variable 
		/// location for the specified program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetnUniform if the buffer size required to store the requested data is greater 
		/// than <paramref name="bufSize"/>.
		/// </exception>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		[AliasOf("glGetnUniformfvEXT")]
		[AliasOf("glGetnUniformfvKHR")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
		[RequiredByFeature("GL_KHR_robustness")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gles2")]
		public static void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformfv != null, "pglGetnUniformfv not implemented");
					Delegates.pglGetnUniformfv(program, location, bufSize, p_params);
					LogCommand("glGetnUniformfv", null, program, location, bufSize, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Returns the value of a uniform variable
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be queried.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer <paramref name="params"/>.
		/// </param>
		/// <param name="params">
		/// Returns the value of the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> has not been successfully linked.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> does not correspond to a valid uniform variable 
		/// location for the specified program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetnUniform if the buffer size required to store the requested data is greater 
		/// than <paramref name="bufSize"/>.
		/// </exception>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		[AliasOf("glGetnUniformivEXT")]
		[AliasOf("glGetnUniformivKHR")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
		[RequiredByFeature("GL_KHR_robustness")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gles2")]
		public static void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformiv != null, "pglGetnUniformiv not implemented");
					Delegates.pglGetnUniformiv(program, location, bufSize, p_params);
					LogCommand("glGetnUniformiv", null, program, location, bufSize, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Returns the value of a uniform variable
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be queried.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer <paramref name="params"/>.
		/// </param>
		/// <param name="params">
		/// Returns the value of the specified uniform variable.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> has not been successfully linked.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> does not correspond to a valid uniform variable 
		/// location for the specified program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetnUniform if the buffer size required to store the requested data is greater 
		/// than <paramref name="bufSize"/>.
		/// </exception>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		[AliasOf("glGetnUniformuivKHR")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_robustness")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gles2")]
		public static void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [Out] UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformuiv != null, "pglGetnUniformuiv not implemented");
					Delegates.pglGetnUniformuiv(program, location, bufSize, p_params);
					LogCommand("glGetnUniformuiv", null, program, location, bufSize, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glReadnPixels.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[AliasOf("glReadnPixelsARB")]
		[AliasOf("glReadnPixelsEXT")]
		[AliasOf("glReadnPixelsKHR")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
		[RequiredByFeature("GL_KHR_robustness")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gles2")]
		public static void ReadnPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelFormat format, PixelType type, Int32 bufSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglReadnPixels != null, "pglReadnPixels not implemented");
			Delegates.pglReadnPixels(x, y, width, height, (Int32)format, (Int32)type, bufSize, data);
			LogCommand("glReadnPixels", null, x, y, width, height, format, type, bufSize, data			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnMapdv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:EvaluatorTarget"/>.
		/// </param>
		/// <param name="query">
		/// A <see cref="T:EvaluatorParameterName"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
		public static void GetnMap(EvaluatorTarget target, EvaluatorParameterName query, Int32 bufSize, [Out] double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglGetnMapdv != null, "pglGetnMapdv not implemented");
					Delegates.pglGetnMapdv((Int32)target, (Int32)query, bufSize, p_v);
					LogCommand("glGetnMapdv", null, target, query, bufSize, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnMapfv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:EvaluatorTarget"/>.
		/// </param>
		/// <param name="query">
		/// A <see cref="T:EvaluatorParameterName"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
		public static void GetnMap(EvaluatorTarget target, EvaluatorParameterName query, Int32 bufSize, [Out] float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglGetnMapfv != null, "pglGetnMapfv not implemented");
					Delegates.pglGetnMapfv((Int32)target, (Int32)query, bufSize, p_v);
					LogCommand("glGetnMapfv", null, target, query, bufSize, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnMapiv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:EvaluatorTarget"/>.
		/// </param>
		/// <param name="query">
		/// A <see cref="T:EvaluatorParameterName"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
		public static void GetnMap(EvaluatorTarget target, EvaluatorParameterName query, Int32 bufSize, [Out] Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglGetnMapiv != null, "pglGetnMapiv not implemented");
					Delegates.pglGetnMapiv((Int32)target, (Int32)query, bufSize, p_v);
					LogCommand("glGetnMapiv", null, target, query, bufSize, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnPixelMapfv.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:PixelMap"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
		public static void GetnPixelMap(PixelMap map, Int32 bufSize, [Out] float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglGetnPixelMapfv != null, "pglGetnPixelMapfv not implemented");
					Delegates.pglGetnPixelMapfv((Int32)map, bufSize, p_values);
					LogCommand("glGetnPixelMapfv", null, map, bufSize, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnPixelMapuiv.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:PixelMap"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
		public static void GetnPixelMap(PixelMap map, Int32 bufSize, [Out] UInt32[] values)
		{
			unsafe {
				fixed (UInt32* p_values = values)
				{
					Debug.Assert(Delegates.pglGetnPixelMapuiv != null, "pglGetnPixelMapuiv not implemented");
					Delegates.pglGetnPixelMapuiv((Int32)map, bufSize, p_values);
					LogCommand("glGetnPixelMapuiv", null, map, bufSize, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnPixelMapusv.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:PixelMap"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
		public static void GetnPixelMap(PixelMap map, Int32 bufSize, [Out] UInt16[] values)
		{
			unsafe {
				fixed (UInt16* p_values = values)
				{
					Debug.Assert(Delegates.pglGetnPixelMapusv != null, "pglGetnPixelMapusv not implemented");
					Delegates.pglGetnPixelMapusv((Int32)map, bufSize, p_values);
					LogCommand("glGetnPixelMapusv", null, map, bufSize, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnPolygonStipple.
		/// </summary>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pattern">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
		public static void GetnPolygonStipple(Int32 bufSize, [Out] byte[] pattern)
		{
			unsafe {
				fixed (byte* p_pattern = pattern)
				{
					Debug.Assert(Delegates.pglGetnPolygonStipple != null, "pglGetnPolygonStipple not implemented");
					Delegates.pglGetnPolygonStipple(bufSize, p_pattern);
					LogCommand("glGetnPolygonStipple", null, bufSize, pattern					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnColorTable.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ColorTableTarget"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
		public static void GetnColorTable(ColorTableTarget target, PixelFormat format, PixelType type, Int32 bufSize, IntPtr table)
		{
			Debug.Assert(Delegates.pglGetnColorTable != null, "pglGetnColorTable not implemented");
			Delegates.pglGetnColorTable((Int32)target, (Int32)format, (Int32)type, bufSize, table);
			LogCommand("glGetnColorTable", null, target, format, type, bufSize, table			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnColorTable.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ColorTableTarget"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
		public static void GetnColorTable(ColorTableTarget target, PixelFormat format, PixelType type, Int32 bufSize, Object table)
		{
			GCHandle pin_table = GCHandle.Alloc(table, GCHandleType.Pinned);
			try {
				GetnColorTable(target, format, type, bufSize, pin_table.AddrOfPinnedObject());
			} finally {
				pin_table.Free();
			}
		}

		/// <summary>
		/// Binding for glGetnConvolutionFilter.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTarget"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
		public static void GetnConvolutionFilter(ConvolutionTarget target, PixelFormat format, PixelType type, Int32 bufSize, IntPtr image)
		{
			Debug.Assert(Delegates.pglGetnConvolutionFilter != null, "pglGetnConvolutionFilter not implemented");
			Delegates.pglGetnConvolutionFilter((Int32)target, (Int32)format, (Int32)type, bufSize, image);
			LogCommand("glGetnConvolutionFilter", null, target, format, type, bufSize, image			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnConvolutionFilter.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTarget"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
		public static void GetnConvolutionFilter(ConvolutionTarget target, PixelFormat format, PixelType type, Int32 bufSize, Object image)
		{
			GCHandle pin_image = GCHandle.Alloc(image, GCHandleType.Pinned);
			try {
				GetnConvolutionFilter(target, format, type, bufSize, pin_image.AddrOfPinnedObject());
			} finally {
				pin_image.Free();
			}
		}

		/// <summary>
		/// Binding for glGetnSeparableFilter.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:SeparableTarget"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="rowBufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="columnBufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="span">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
		public static void GetnSeparableFilter(SeparableTarget target, PixelFormat format, PixelType type, Int32 rowBufSize, IntPtr row, Int32 columnBufSize, IntPtr column, IntPtr span)
		{
			Debug.Assert(Delegates.pglGetnSeparableFilter != null, "pglGetnSeparableFilter not implemented");
			Delegates.pglGetnSeparableFilter((Int32)target, (Int32)format, (Int32)type, rowBufSize, row, columnBufSize, column, span);
			LogCommand("glGetnSeparableFilter", null, target, format, type, rowBufSize, row, columnBufSize, column, span			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnSeparableFilter.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:SeparableTarget"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="rowBufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="columnBufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="span">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
		public static void GetnSeparableFilter(SeparableTarget target, PixelFormat format, PixelType type, Int32 rowBufSize, Object row, Int32 columnBufSize, Object column, Object span)
		{
			GCHandle pin_row = GCHandle.Alloc(row, GCHandleType.Pinned);
			GCHandle pin_column = GCHandle.Alloc(column, GCHandleType.Pinned);
			GCHandle pin_span = GCHandle.Alloc(span, GCHandleType.Pinned);
			try {
				GetnSeparableFilter(target, format, type, rowBufSize, pin_row.AddrOfPinnedObject(), columnBufSize, pin_column.AddrOfPinnedObject(), pin_span.AddrOfPinnedObject());
			} finally {
				pin_row.Free();
				pin_column.Free();
				pin_span.Free();
			}
		}

		/// <summary>
		/// Binding for glGetnHistogram.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:HistogramTargetEXT"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
		public static void GetnHistogram(HistogramTargetEXT target, bool reset, PixelFormat format, PixelType type, Int32 bufSize, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetnHistogram != null, "pglGetnHistogram not implemented");
			Delegates.pglGetnHistogram((Int32)target, reset, (Int32)format, (Int32)type, bufSize, values);
			LogCommand("glGetnHistogram", null, target, reset, format, type, bufSize, values			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnHistogram.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:HistogramTargetEXT"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
		public static void GetnHistogram(HistogramTargetEXT target, bool reset, PixelFormat format, PixelType type, Int32 bufSize, Object values)
		{
			GCHandle pin_values = GCHandle.Alloc(values, GCHandleType.Pinned);
			try {
				GetnHistogram(target, reset, format, type, bufSize, pin_values.AddrOfPinnedObject());
			} finally {
				pin_values.Free();
			}
		}

		/// <summary>
		/// Binding for glGetnMinmax.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:MinmaxTarget"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
		public static void GetnMinmax(MinmaxTarget target, bool reset, PixelFormat format, PixelType type, Int32 bufSize, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetnMinmax != null, "pglGetnMinmax not implemented");
			Delegates.pglGetnMinmax((Int32)target, reset, (Int32)format, (Int32)type, bufSize, values);
			LogCommand("glGetnMinmax", null, target, reset, format, type, bufSize, values			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnMinmax.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:MinmaxTarget"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
		public static void GetnMinmax(MinmaxTarget target, bool reset, PixelFormat format, PixelType type, Int32 bufSize, Object values)
		{
			GCHandle pin_values = GCHandle.Alloc(values, GCHandleType.Pinned);
			try {
				GetnMinmax(target, reset, format, type, bufSize, pin_values.AddrOfPinnedObject());
			} finally {
				pin_values.Free();
			}
		}

		/// <summary>
		/// controls the ordering of reads and writes to rendered fragments across drawing commands
		/// </summary>
		/// <exception cref="KhronosException">
		/// None.
		/// </exception>
		/// <seealso cref="Gl.MemoryBarrier"/>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_texture_barrier", Api = "gl|glcore")]
		public static void TextureBarrier()
		{
			Debug.Assert(Delegates.pglTextureBarrier != null, "pglTextureBarrier not implemented");
			Delegates.pglTextureBarrier();
			LogCommand("glTextureBarrier", null			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClipControl", ExactSpelling = true)]
			internal extern static void glClipControl(Int32 origin, Int32 depth);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCreateTransformFeedbacks", ExactSpelling = true)]
			internal extern static unsafe void glCreateTransformFeedbacks(Int32 n, UInt32* ids);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTransformFeedbackBufferBase", ExactSpelling = true)]
			internal extern static void glTransformFeedbackBufferBase(UInt32 xfb, UInt32 index, UInt32 buffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTransformFeedbackBufferRange", ExactSpelling = true)]
			internal extern static unsafe void glTransformFeedbackBufferRange(UInt32 xfb, UInt32 index, UInt32 buffer, IntPtr offset, UInt32 size);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTransformFeedbackiv", ExactSpelling = true)]
			internal extern static unsafe void glGetTransformFeedbackiv(UInt32 xfb, Int32 pname, Int32* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTransformFeedbacki_v", ExactSpelling = true)]
			internal extern static unsafe void glGetTransformFeedbacki_v(UInt32 xfb, Int32 pname, UInt32 index, Int32* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTransformFeedbacki64_v", ExactSpelling = true)]
			internal extern static unsafe void glGetTransformFeedbacki64_v(UInt32 xfb, Int32 pname, UInt32 index, Int64* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCreateBuffers", ExactSpelling = true)]
			internal extern static unsafe void glCreateBuffers(Int32 n, UInt32* buffers);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedBufferStorage", ExactSpelling = true)]
			internal extern static unsafe void glNamedBufferStorage(UInt32 buffer, UInt32 size, IntPtr data, UInt32 flags);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedBufferData", ExactSpelling = true)]
			internal extern static unsafe void glNamedBufferData(UInt32 buffer, UInt32 size, IntPtr data, Int32 usage);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedBufferSubData", ExactSpelling = true)]
			internal extern static unsafe void glNamedBufferSubData(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCopyNamedBufferSubData", ExactSpelling = true)]
			internal extern static unsafe void glCopyNamedBufferSubData(UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, UInt32 size);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearNamedBufferData", ExactSpelling = true)]
			internal extern static unsafe void glClearNamedBufferData(UInt32 buffer, Int32 internalformat, Int32 format, Int32 type, IntPtr data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearNamedBufferSubData", ExactSpelling = true)]
			internal extern static unsafe void glClearNamedBufferSubData(UInt32 buffer, Int32 internalformat, IntPtr offset, UInt32 size, Int32 format, Int32 type, IntPtr data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMapNamedBuffer", ExactSpelling = true)]
			internal extern static IntPtr glMapNamedBuffer(UInt32 buffer, Int32 access);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMapNamedBufferRange", ExactSpelling = true)]
			internal extern static unsafe IntPtr glMapNamedBufferRange(UInt32 buffer, IntPtr offset, UInt32 length, UInt32 access);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUnmapNamedBuffer", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glUnmapNamedBuffer(UInt32 buffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFlushMappedNamedBufferRange", ExactSpelling = true)]
			internal extern static unsafe void glFlushMappedNamedBufferRange(UInt32 buffer, IntPtr offset, UInt32 length);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedBufferParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedBufferParameteriv(UInt32 buffer, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedBufferParameteri64v", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedBufferParameteri64v(UInt32 buffer, Int32 pname, Int64* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedBufferPointerv", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedBufferPointerv(UInt32 buffer, Int32 pname, IntPtr* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedBufferSubData", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedBufferSubData(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCreateFramebuffers", ExactSpelling = true)]
			internal extern static unsafe void glCreateFramebuffers(Int32 n, UInt32* framebuffers);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedFramebufferRenderbuffer", ExactSpelling = true)]
			internal extern static void glNamedFramebufferRenderbuffer(UInt32 framebuffer, Int32 attachment, Int32 renderbuffertarget, UInt32 renderbuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedFramebufferParameteri", ExactSpelling = true)]
			internal extern static void glNamedFramebufferParameteri(UInt32 framebuffer, Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedFramebufferTexture", ExactSpelling = true)]
			internal extern static void glNamedFramebufferTexture(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedFramebufferTextureLayer", ExactSpelling = true)]
			internal extern static void glNamedFramebufferTextureLayer(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level, Int32 layer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedFramebufferDrawBuffer", ExactSpelling = true)]
			internal extern static void glNamedFramebufferDrawBuffer(UInt32 framebuffer, Int32 buf);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedFramebufferDrawBuffers", ExactSpelling = true)]
			internal extern static unsafe void glNamedFramebufferDrawBuffers(UInt32 framebuffer, Int32 n, Int32* bufs);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedFramebufferReadBuffer", ExactSpelling = true)]
			internal extern static void glNamedFramebufferReadBuffer(UInt32 framebuffer, Int32 src);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glInvalidateNamedFramebufferData", ExactSpelling = true)]
			internal extern static unsafe void glInvalidateNamedFramebufferData(UInt32 framebuffer, Int32 numAttachments, Int32* attachments);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glInvalidateNamedFramebufferSubData", ExactSpelling = true)]
			internal extern static unsafe void glInvalidateNamedFramebufferSubData(UInt32 framebuffer, Int32 numAttachments, Int32* attachments, Int32 x, Int32 y, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearNamedFramebufferiv", ExactSpelling = true)]
			internal extern static unsafe void glClearNamedFramebufferiv(UInt32 framebuffer, Int32 buffer, Int32 drawbuffer, Int32* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearNamedFramebufferuiv", ExactSpelling = true)]
			internal extern static unsafe void glClearNamedFramebufferuiv(UInt32 framebuffer, Int32 buffer, Int32 drawbuffer, UInt32* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearNamedFramebufferfv", ExactSpelling = true)]
			internal extern static unsafe void glClearNamedFramebufferfv(UInt32 framebuffer, Int32 buffer, Int32 drawbuffer, float* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearNamedFramebufferfi", ExactSpelling = true)]
			internal extern static void glClearNamedFramebufferfi(UInt32 framebuffer, Int32 buffer, Int32 drawbuffer, float depth, Int32 stencil);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBlitNamedFramebuffer", ExactSpelling = true)]
			internal extern static void glBlitNamedFramebuffer(UInt32 readFramebuffer, UInt32 drawFramebuffer, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCheckNamedFramebufferStatus", ExactSpelling = true)]
			internal extern static Int32 glCheckNamedFramebufferStatus(UInt32 framebuffer, Int32 target);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedFramebufferParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedFramebufferParameteriv(UInt32 framebuffer, Int32 pname, Int32* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedFramebufferAttachmentParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedFramebufferAttachmentParameteriv(UInt32 framebuffer, Int32 attachment, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCreateRenderbuffers", ExactSpelling = true)]
			internal extern static unsafe void glCreateRenderbuffers(Int32 n, UInt32* renderbuffers);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedRenderbufferStorage", ExactSpelling = true)]
			internal extern static void glNamedRenderbufferStorage(UInt32 renderbuffer, Int32 internalformat, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedRenderbufferStorageMultisample", ExactSpelling = true)]
			internal extern static void glNamedRenderbufferStorageMultisample(UInt32 renderbuffer, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedRenderbufferParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedRenderbufferParameteriv(UInt32 renderbuffer, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCreateTextures", ExactSpelling = true)]
			internal extern static unsafe void glCreateTextures(Int32 target, Int32 n, UInt32* textures);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureBuffer", ExactSpelling = true)]
			internal extern static void glTextureBuffer(UInt32 texture, Int32 internalformat, UInt32 buffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureBufferRange", ExactSpelling = true)]
			internal extern static unsafe void glTextureBufferRange(UInt32 texture, Int32 internalformat, UInt32 buffer, IntPtr offset, UInt32 size);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureStorage1D", ExactSpelling = true)]
			internal extern static void glTextureStorage1D(UInt32 texture, Int32 levels, Int32 internalformat, Int32 width);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureStorage2D", ExactSpelling = true)]
			internal extern static void glTextureStorage2D(UInt32 texture, Int32 levels, Int32 internalformat, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureStorage3D", ExactSpelling = true)]
			internal extern static void glTextureStorage3D(UInt32 texture, Int32 levels, Int32 internalformat, Int32 width, Int32 height, Int32 depth);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureStorage2DMultisample", ExactSpelling = true)]
			internal extern static void glTextureStorage2DMultisample(UInt32 texture, Int32 samples, Int32 internalformat, Int32 width, Int32 height, bool fixedsamplelocations);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureStorage3DMultisample", ExactSpelling = true)]
			internal extern static void glTextureStorage3DMultisample(UInt32 texture, Int32 samples, Int32 internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureSubImage1D", ExactSpelling = true)]
			internal extern static unsafe void glTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureSubImage2D", ExactSpelling = true)]
			internal extern static unsafe void glTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureSubImage3D", ExactSpelling = true)]
			internal extern static unsafe void glTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCompressedTextureSubImage1D", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 imageSize, IntPtr data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCompressedTextureSubImage2D", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 imageSize, IntPtr data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCompressedTextureSubImage3D", ExactSpelling = true)]
			internal extern static unsafe void glCompressedTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 imageSize, IntPtr data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCopyTextureSubImage1D", ExactSpelling = true)]
			internal extern static void glCopyTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCopyTextureSubImage2D", ExactSpelling = true)]
			internal extern static void glCopyTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCopyTextureSubImage3D", ExactSpelling = true)]
			internal extern static void glCopyTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureParameterf", ExactSpelling = true)]
			internal extern static void glTextureParameterf(UInt32 texture, Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glTextureParameterfv(UInt32 texture, Int32 pname, float* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureParameteri", ExactSpelling = true)]
			internal extern static void glTextureParameteri(UInt32 texture, Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureParameterIiv", ExactSpelling = true)]
			internal extern static unsafe void glTextureParameterIiv(UInt32 texture, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureParameterIuiv", ExactSpelling = true)]
			internal extern static unsafe void glTextureParameterIuiv(UInt32 texture, Int32 pname, UInt32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glTextureParameteriv(UInt32 texture, Int32 pname, Int32* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGenerateTextureMipmap", ExactSpelling = true)]
			internal extern static void glGenerateTextureMipmap(UInt32 texture);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBindTextureUnit", ExactSpelling = true)]
			internal extern static void glBindTextureUnit(UInt32 unit, UInt32 texture);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTextureImage", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureImage(UInt32 texture, Int32 level, Int32 format, Int32 type, Int32 bufSize, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetCompressedTextureImage", ExactSpelling = true)]
			internal extern static unsafe void glGetCompressedTextureImage(UInt32 texture, Int32 level, Int32 bufSize, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTextureLevelParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureLevelParameterfv(UInt32 texture, Int32 level, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTextureLevelParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureLevelParameteriv(UInt32 texture, Int32 level, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTextureParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureParameterfv(UInt32 texture, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTextureParameterIiv", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureParameterIiv(UInt32 texture, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTextureParameterIuiv", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureParameterIuiv(UInt32 texture, Int32 pname, UInt32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTextureParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureParameteriv(UInt32 texture, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCreateVertexArrays", ExactSpelling = true)]
			internal extern static unsafe void glCreateVertexArrays(Int32 n, UInt32* arrays);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDisableVertexArrayAttrib", ExactSpelling = true)]
			internal extern static void glDisableVertexArrayAttrib(UInt32 vaobj, UInt32 index);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEnableVertexArrayAttrib", ExactSpelling = true)]
			internal extern static void glEnableVertexArrayAttrib(UInt32 vaobj, UInt32 index);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayElementBuffer", ExactSpelling = true)]
			internal extern static void glVertexArrayElementBuffer(UInt32 vaobj, UInt32 buffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayVertexBuffer", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayVertexBuffer(UInt32 vaobj, UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayVertexBuffers", ExactSpelling = true)]
			internal extern static unsafe void glVertexArrayVertexBuffers(UInt32 vaobj, UInt32 first, Int32 count, UInt32* buffers, IntPtr* offsets, Int32* strides);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayAttribBinding", ExactSpelling = true)]
			internal extern static void glVertexArrayAttribBinding(UInt32 vaobj, UInt32 attribindex, UInt32 bindingindex);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayAttribFormat", ExactSpelling = true)]
			internal extern static void glVertexArrayAttribFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, bool normalized, UInt32 relativeoffset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayAttribIFormat", ExactSpelling = true)]
			internal extern static void glVertexArrayAttribIFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayAttribLFormat", ExactSpelling = true)]
			internal extern static void glVertexArrayAttribLFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexArrayBindingDivisor", ExactSpelling = true)]
			internal extern static void glVertexArrayBindingDivisor(UInt32 vaobj, UInt32 bindingindex, UInt32 divisor);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetVertexArrayiv", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexArrayiv(UInt32 vaobj, Int32 pname, Int32* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetVertexArrayIndexediv", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexArrayIndexediv(UInt32 vaobj, UInt32 index, Int32 pname, Int32* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetVertexArrayIndexed64iv", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexArrayIndexed64iv(UInt32 vaobj, UInt32 index, Int32 pname, Int64* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCreateSamplers", ExactSpelling = true)]
			internal extern static unsafe void glCreateSamplers(Int32 n, UInt32* samplers);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCreateProgramPipelines", ExactSpelling = true)]
			internal extern static unsafe void glCreateProgramPipelines(Int32 n, UInt32* pipelines);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCreateQueries", ExactSpelling = true)]
			internal extern static unsafe void glCreateQueries(Int32 target, Int32 n, UInt32* ids);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetQueryBufferObjecti64v", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryBufferObjecti64v(UInt32 id, UInt32 buffer, Int32 pname, IntPtr offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetQueryBufferObjectiv", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryBufferObjectiv(UInt32 id, UInt32 buffer, Int32 pname, IntPtr offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetQueryBufferObjectui64v", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryBufferObjectui64v(UInt32 id, UInt32 buffer, Int32 pname, IntPtr offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetQueryBufferObjectuiv", ExactSpelling = true)]
			internal extern static unsafe void glGetQueryBufferObjectuiv(UInt32 id, UInt32 buffer, Int32 pname, IntPtr offset);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMemoryBarrierByRegion", ExactSpelling = true)]
			internal extern static void glMemoryBarrierByRegion(UInt32 barriers);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTextureSubImage", ExactSpelling = true)]
			internal extern static unsafe void glGetTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, Int32 bufSize, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetCompressedTextureSubImage", ExactSpelling = true)]
			internal extern static unsafe void glGetCompressedTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 bufSize, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetGraphicsResetStatus", ExactSpelling = true)]
			internal extern static Int32 glGetGraphicsResetStatus();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnCompressedTexImage", ExactSpelling = true)]
			internal extern static unsafe void glGetnCompressedTexImage(Int32 target, Int32 lod, Int32 bufSize, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnTexImage", ExactSpelling = true)]
			internal extern static unsafe void glGetnTexImage(Int32 target, Int32 level, Int32 format, Int32 type, Int32 bufSize, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnUniformdv", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformdv(UInt32 program, Int32 location, Int32 bufSize, double* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnUniformfv", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformfv(UInt32 program, Int32 location, Int32 bufSize, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnUniformiv", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformiv(UInt32 program, Int32 location, Int32 bufSize, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnUniformuiv", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformuiv(UInt32 program, Int32 location, Int32 bufSize, UInt32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReadnPixels", ExactSpelling = true)]
			internal extern static unsafe void glReadnPixels(Int32 x, Int32 y, Int32 width, Int32 height, Int32 format, Int32 type, Int32 bufSize, IntPtr data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnMapdv", ExactSpelling = true)]
			internal extern static unsafe void glGetnMapdv(Int32 target, Int32 query, Int32 bufSize, double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnMapfv", ExactSpelling = true)]
			internal extern static unsafe void glGetnMapfv(Int32 target, Int32 query, Int32 bufSize, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnMapiv", ExactSpelling = true)]
			internal extern static unsafe void glGetnMapiv(Int32 target, Int32 query, Int32 bufSize, Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnPixelMapfv", ExactSpelling = true)]
			internal extern static unsafe void glGetnPixelMapfv(Int32 map, Int32 bufSize, float* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnPixelMapuiv", ExactSpelling = true)]
			internal extern static unsafe void glGetnPixelMapuiv(Int32 map, Int32 bufSize, UInt32* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnPixelMapusv", ExactSpelling = true)]
			internal extern static unsafe void glGetnPixelMapusv(Int32 map, Int32 bufSize, UInt16* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnPolygonStipple", ExactSpelling = true)]
			internal extern static unsafe void glGetnPolygonStipple(Int32 bufSize, byte* pattern);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnColorTable", ExactSpelling = true)]
			internal extern static unsafe void glGetnColorTable(Int32 target, Int32 format, Int32 type, Int32 bufSize, IntPtr table);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnConvolutionFilter", ExactSpelling = true)]
			internal extern static unsafe void glGetnConvolutionFilter(Int32 target, Int32 format, Int32 type, Int32 bufSize, IntPtr image);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnSeparableFilter", ExactSpelling = true)]
			internal extern static unsafe void glGetnSeparableFilter(Int32 target, Int32 format, Int32 type, Int32 rowBufSize, IntPtr row, Int32 columnBufSize, IntPtr column, IntPtr span);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnHistogram", ExactSpelling = true)]
			internal extern static unsafe void glGetnHistogram(Int32 target, bool reset, Int32 format, Int32 type, Int32 bufSize, IntPtr values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnMinmax", ExactSpelling = true)]
			internal extern static unsafe void glGetnMinmax(Int32 target, bool reset, Int32 format, Int32 type, Int32 bufSize, IntPtr values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureBarrier", ExactSpelling = true)]
			internal extern static void glTextureBarrier();

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_clip_control", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClipControl(Int32 origin, Int32 depth);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_clip_control", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glClipControl pglClipControl;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCreateTransformFeedbacks(Int32 n, UInt32* ids);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCreateTransformFeedbacks pglCreateTransformFeedbacks;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTransformFeedbackBufferBase(UInt32 xfb, UInt32 index, UInt32 buffer);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glTransformFeedbackBufferBase pglTransformFeedbackBufferBase;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTransformFeedbackBufferRange(UInt32 xfb, UInt32 index, UInt32 buffer, IntPtr offset, UInt32 size);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glTransformFeedbackBufferRange pglTransformFeedbackBufferRange;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTransformFeedbackiv(UInt32 xfb, Int32 pname, Int32* param);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetTransformFeedbackiv pglGetTransformFeedbackiv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTransformFeedbacki_v(UInt32 xfb, Int32 pname, UInt32 index, Int32* param);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetTransformFeedbacki_v pglGetTransformFeedbacki_v;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTransformFeedbacki64_v(UInt32 xfb, Int32 pname, UInt32 index, Int64* param);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetTransformFeedbacki64_v pglGetTransformFeedbacki64_v;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCreateBuffers(Int32 n, UInt32* buffers);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCreateBuffers pglCreateBuffers;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedBufferStorage(UInt32 buffer, UInt32 size, IntPtr data, UInt32 flags);

			[AliasOf("glNamedBufferStorage")]
			[AliasOf("glNamedBufferStorageEXT")]
			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glNamedBufferStorage pglNamedBufferStorage;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedBufferData(UInt32 buffer, UInt32 size, IntPtr data, Int32 usage);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glNamedBufferData pglNamedBufferData;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedBufferSubData(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data);

			[AliasOf("glNamedBufferSubData")]
			[AliasOf("glNamedBufferSubDataEXT")]
			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glNamedBufferSubData pglNamedBufferSubData;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCopyNamedBufferSubData(UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, UInt32 size);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCopyNamedBufferSubData pglCopyNamedBufferSubData;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearNamedBufferData(UInt32 buffer, Int32 internalformat, Int32 format, Int32 type, IntPtr data);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glClearNamedBufferData pglClearNamedBufferData;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearNamedBufferSubData(UInt32 buffer, Int32 internalformat, IntPtr offset, UInt32 size, Int32 format, Int32 type, IntPtr data);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glClearNamedBufferSubData pglClearNamedBufferSubData;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glMapNamedBuffer(UInt32 buffer, Int32 access);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glMapNamedBuffer pglMapNamedBuffer;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glMapNamedBufferRange(UInt32 buffer, IntPtr offset, UInt32 length, UInt32 access);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glMapNamedBufferRange pglMapNamedBufferRange;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glUnmapNamedBuffer(UInt32 buffer);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glUnmapNamedBuffer pglUnmapNamedBuffer;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFlushMappedNamedBufferRange(UInt32 buffer, IntPtr offset, UInt32 length);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glFlushMappedNamedBufferRange pglFlushMappedNamedBufferRange;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedBufferParameteriv(UInt32 buffer, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetNamedBufferParameteriv pglGetNamedBufferParameteriv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedBufferParameteri64v(UInt32 buffer, Int32 pname, Int64* @params);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetNamedBufferParameteri64v pglGetNamedBufferParameteri64v;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedBufferPointerv(UInt32 buffer, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetNamedBufferPointerv pglGetNamedBufferPointerv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedBufferSubData(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetNamedBufferSubData pglGetNamedBufferSubData;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCreateFramebuffers(Int32 n, UInt32* framebuffers);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCreateFramebuffers pglCreateFramebuffers;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferRenderbuffer(UInt32 framebuffer, Int32 attachment, Int32 renderbuffertarget, UInt32 renderbuffer);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glNamedFramebufferRenderbuffer pglNamedFramebufferRenderbuffer;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferParameteri(UInt32 framebuffer, Int32 pname, Int32 param);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glNamedFramebufferParameteri pglNamedFramebufferParameteri;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferTexture(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glNamedFramebufferTexture pglNamedFramebufferTexture;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferTextureLayer(UInt32 framebuffer, Int32 attachment, UInt32 texture, Int32 level, Int32 layer);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glNamedFramebufferTextureLayer pglNamedFramebufferTextureLayer;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferDrawBuffer(UInt32 framebuffer, Int32 buf);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glNamedFramebufferDrawBuffer pglNamedFramebufferDrawBuffer;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedFramebufferDrawBuffers(UInt32 framebuffer, Int32 n, Int32* bufs);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glNamedFramebufferDrawBuffers pglNamedFramebufferDrawBuffers;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferReadBuffer(UInt32 framebuffer, Int32 src);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glNamedFramebufferReadBuffer pglNamedFramebufferReadBuffer;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glInvalidateNamedFramebufferData(UInt32 framebuffer, Int32 numAttachments, Int32* attachments);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glInvalidateNamedFramebufferData pglInvalidateNamedFramebufferData;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glInvalidateNamedFramebufferSubData(UInt32 framebuffer, Int32 numAttachments, Int32* attachments, Int32 x, Int32 y, Int32 width, Int32 height);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glInvalidateNamedFramebufferSubData pglInvalidateNamedFramebufferSubData;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearNamedFramebufferiv(UInt32 framebuffer, Int32 buffer, Int32 drawbuffer, Int32* value);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glClearNamedFramebufferiv pglClearNamedFramebufferiv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearNamedFramebufferuiv(UInt32 framebuffer, Int32 buffer, Int32 drawbuffer, UInt32* value);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glClearNamedFramebufferuiv pglClearNamedFramebufferuiv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearNamedFramebufferfv(UInt32 framebuffer, Int32 buffer, Int32 drawbuffer, float* value);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glClearNamedFramebufferfv pglClearNamedFramebufferfv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearNamedFramebufferfi(UInt32 framebuffer, Int32 buffer, Int32 drawbuffer, float depth, Int32 stencil);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glClearNamedFramebufferfi pglClearNamedFramebufferfi;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlitNamedFramebuffer(UInt32 readFramebuffer, UInt32 drawFramebuffer, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glBlitNamedFramebuffer pglBlitNamedFramebuffer;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glCheckNamedFramebufferStatus(UInt32 framebuffer, Int32 target);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCheckNamedFramebufferStatus pglCheckNamedFramebufferStatus;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedFramebufferParameteriv(UInt32 framebuffer, Int32 pname, Int32* param);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetNamedFramebufferParameteriv pglGetNamedFramebufferParameteriv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedFramebufferAttachmentParameteriv(UInt32 framebuffer, Int32 attachment, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetNamedFramebufferAttachmentParameteriv pglGetNamedFramebufferAttachmentParameteriv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCreateRenderbuffers(Int32 n, UInt32* renderbuffers);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCreateRenderbuffers pglCreateRenderbuffers;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedRenderbufferStorage(UInt32 renderbuffer, Int32 internalformat, Int32 width, Int32 height);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glNamedRenderbufferStorage pglNamedRenderbufferStorage;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedRenderbufferStorageMultisample(UInt32 renderbuffer, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glNamedRenderbufferStorageMultisample pglNamedRenderbufferStorageMultisample;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedRenderbufferParameteriv(UInt32 renderbuffer, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetNamedRenderbufferParameteriv pglGetNamedRenderbufferParameteriv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCreateTextures(Int32 target, Int32 n, UInt32* textures);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCreateTextures pglCreateTextures;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureBuffer(UInt32 texture, Int32 internalformat, UInt32 buffer);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glTextureBuffer pglTextureBuffer;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureBufferRange(UInt32 texture, Int32 internalformat, UInt32 buffer, IntPtr offset, UInt32 size);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glTextureBufferRange pglTextureBufferRange;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorage1D(UInt32 texture, Int32 levels, Int32 internalformat, Int32 width);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glTextureStorage1D pglTextureStorage1D;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorage2D(UInt32 texture, Int32 levels, Int32 internalformat, Int32 width, Int32 height);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glTextureStorage2D pglTextureStorage2D;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorage3D(UInt32 texture, Int32 levels, Int32 internalformat, Int32 width, Int32 height, Int32 depth);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glTextureStorage3D pglTextureStorage3D;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorage2DMultisample(UInt32 texture, Int32 samples, Int32 internalformat, Int32 width, Int32 height, bool fixedsamplelocations);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glTextureStorage2DMultisample pglTextureStorage2DMultisample;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorage3DMultisample(UInt32 texture, Int32 samples, Int32 internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glTextureStorage3DMultisample pglTextureStorage3DMultisample;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 type, IntPtr pixels);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glTextureSubImage1D pglTextureSubImage1D;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glTextureSubImage2D pglTextureSubImage2D;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, IntPtr pixels);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glTextureSubImage3D pglTextureSubImage3D;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, Int32 format, Int32 imageSize, IntPtr data);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCompressedTextureSubImage1D pglCompressedTextureSubImage1D;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Int32 format, Int32 imageSize, IntPtr data);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCompressedTextureSubImage2D pglCompressedTextureSubImage2D;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 imageSize, IntPtr data);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCompressedTextureSubImage3D pglCompressedTextureSubImage3D;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCopyTextureSubImage1D pglCopyTextureSubImage1D;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCopyTextureSubImage2D pglCopyTextureSubImage2D;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCopyTextureSubImage3D pglCopyTextureSubImage3D;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureParameterf(UInt32 texture, Int32 pname, float param);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glTextureParameterf pglTextureParameterf;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureParameterfv(UInt32 texture, Int32 pname, float* param);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glTextureParameterfv pglTextureParameterfv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureParameteri(UInt32 texture, Int32 pname, Int32 param);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glTextureParameteri pglTextureParameteri;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureParameterIiv(UInt32 texture, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glTextureParameterIiv pglTextureParameterIiv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureParameterIuiv(UInt32 texture, Int32 pname, UInt32* @params);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glTextureParameterIuiv pglTextureParameterIuiv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureParameteriv(UInt32 texture, Int32 pname, Int32* param);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glTextureParameteriv pglTextureParameteriv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGenerateTextureMipmap(UInt32 texture);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGenerateTextureMipmap pglGenerateTextureMipmap;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindTextureUnit(UInt32 unit, UInt32 texture);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glBindTextureUnit pglBindTextureUnit;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureImage(UInt32 texture, Int32 level, Int32 format, Int32 type, Int32 bufSize, IntPtr pixels);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetTextureImage pglGetTextureImage;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetCompressedTextureImage(UInt32 texture, Int32 level, Int32 bufSize, IntPtr pixels);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetCompressedTextureImage pglGetCompressedTextureImage;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureLevelParameterfv(UInt32 texture, Int32 level, Int32 pname, float* @params);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetTextureLevelParameterfv pglGetTextureLevelParameterfv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureLevelParameteriv(UInt32 texture, Int32 level, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetTextureLevelParameteriv pglGetTextureLevelParameteriv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureParameterfv(UInt32 texture, Int32 pname, float* @params);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetTextureParameterfv pglGetTextureParameterfv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureParameterIiv(UInt32 texture, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetTextureParameterIiv pglGetTextureParameterIiv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureParameterIuiv(UInt32 texture, Int32 pname, UInt32* @params);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetTextureParameterIuiv pglGetTextureParameterIuiv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureParameteriv(UInt32 texture, Int32 pname, Int32* @params);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetTextureParameteriv pglGetTextureParameteriv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCreateVertexArrays(Int32 n, UInt32* arrays);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCreateVertexArrays pglCreateVertexArrays;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDisableVertexArrayAttrib(UInt32 vaobj, UInt32 index);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glDisableVertexArrayAttrib pglDisableVertexArrayAttrib;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnableVertexArrayAttrib(UInt32 vaobj, UInt32 index);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glEnableVertexArrayAttrib pglEnableVertexArrayAttrib;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayElementBuffer(UInt32 vaobj, UInt32 buffer);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexArrayElementBuffer pglVertexArrayElementBuffer;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayVertexBuffer(UInt32 vaobj, UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexArrayVertexBuffer pglVertexArrayVertexBuffer;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayVertexBuffers(UInt32 vaobj, UInt32 first, Int32 count, UInt32* buffers, IntPtr* offsets, Int32* strides);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexArrayVertexBuffers pglVertexArrayVertexBuffers;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayAttribBinding(UInt32 vaobj, UInt32 attribindex, UInt32 bindingindex);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexArrayAttribBinding pglVertexArrayAttribBinding;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayAttribFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, bool normalized, UInt32 relativeoffset);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexArrayAttribFormat pglVertexArrayAttribFormat;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayAttribIFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexArrayAttribIFormat pglVertexArrayAttribIFormat;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayAttribLFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, Int32 type, UInt32 relativeoffset);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexArrayAttribLFormat pglVertexArrayAttribLFormat;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayBindingDivisor(UInt32 vaobj, UInt32 bindingindex, UInt32 divisor);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexArrayBindingDivisor pglVertexArrayBindingDivisor;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexArrayiv(UInt32 vaobj, Int32 pname, Int32* param);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetVertexArrayiv pglGetVertexArrayiv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexArrayIndexediv(UInt32 vaobj, UInt32 index, Int32 pname, Int32* param);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetVertexArrayIndexediv pglGetVertexArrayIndexediv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexArrayIndexed64iv(UInt32 vaobj, UInt32 index, Int32 pname, Int64* param);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetVertexArrayIndexed64iv pglGetVertexArrayIndexed64iv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCreateSamplers(Int32 n, UInt32* samplers);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCreateSamplers pglCreateSamplers;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCreateProgramPipelines(Int32 n, UInt32* pipelines);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCreateProgramPipelines pglCreateProgramPipelines;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCreateQueries(Int32 target, Int32 n, UInt32* ids);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glCreateQueries pglCreateQueries;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetQueryBufferObjecti64v(UInt32 id, UInt32 buffer, Int32 pname, IntPtr offset);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetQueryBufferObjecti64v pglGetQueryBufferObjecti64v;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetQueryBufferObjectiv(UInt32 id, UInt32 buffer, Int32 pname, IntPtr offset);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetQueryBufferObjectiv pglGetQueryBufferObjectiv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetQueryBufferObjectui64v(UInt32 id, UInt32 buffer, Int32 pname, IntPtr offset);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetQueryBufferObjectui64v pglGetQueryBufferObjectui64v;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetQueryBufferObjectuiv(UInt32 id, UInt32 buffer, Int32 pname, IntPtr offset);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetQueryBufferObjectuiv pglGetQueryBufferObjectuiv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_ES3_1_compatibility", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMemoryBarrierByRegion(UInt32 barriers);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_ES3_1_compatibility", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glMemoryBarrierByRegion pglMemoryBarrierByRegion;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_get_texture_sub_image", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, Int32 bufSize, IntPtr pixels);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_get_texture_sub_image", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetTextureSubImage pglGetTextureSubImage;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_get_texture_sub_image", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetCompressedTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 bufSize, IntPtr pixels);

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_get_texture_sub_image", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetCompressedTextureSubImage pglGetCompressedTextureSubImage;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_KHR_robustness")]
			[RequiredByFeature("GL_KHR_robustness", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetGraphicsResetStatus();

			[AliasOf("glGetGraphicsResetStatus")]
			[AliasOf("glGetGraphicsResetStatusKHR")]
			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_KHR_robustness")]
			[RequiredByFeature("GL_KHR_robustness", Api = "gles2")]
			[ThreadStatic]
			internal static glGetGraphicsResetStatus pglGetGraphicsResetStatus;

			[RequiredByFeature("GL_VERSION_4_5")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnCompressedTexImage(Int32 target, Int32 lod, Int32 bufSize, IntPtr pixels);

			[RequiredByFeature("GL_VERSION_4_5")]
			[ThreadStatic]
			internal static glGetnCompressedTexImage pglGetnCompressedTexImage;

			[RequiredByFeature("GL_VERSION_4_5")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnTexImage(Int32 target, Int32 level, Int32 format, Int32 type, Int32 bufSize, IntPtr pixels);

			[RequiredByFeature("GL_VERSION_4_5")]
			[ThreadStatic]
			internal static glGetnTexImage pglGetnTexImage;

			[RequiredByFeature("GL_VERSION_4_5")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnUniformdv(UInt32 program, Int32 location, Int32 bufSize, double* @params);

			[RequiredByFeature("GL_VERSION_4_5")]
			[ThreadStatic]
			internal static glGetnUniformdv pglGetnUniformdv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
			[RequiredByFeature("GL_KHR_robustness")]
			[RequiredByFeature("GL_KHR_robustness", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnUniformfv(UInt32 program, Int32 location, Int32 bufSize, float* @params);

			[AliasOf("glGetnUniformfv")]
			[AliasOf("glGetnUniformfvEXT")]
			[AliasOf("glGetnUniformfvKHR")]
			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
			[RequiredByFeature("GL_KHR_robustness")]
			[RequiredByFeature("GL_KHR_robustness", Api = "gles2")]
			[ThreadStatic]
			internal static glGetnUniformfv pglGetnUniformfv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
			[RequiredByFeature("GL_KHR_robustness")]
			[RequiredByFeature("GL_KHR_robustness", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnUniformiv(UInt32 program, Int32 location, Int32 bufSize, Int32* @params);

			[AliasOf("glGetnUniformiv")]
			[AliasOf("glGetnUniformivEXT")]
			[AliasOf("glGetnUniformivKHR")]
			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
			[RequiredByFeature("GL_KHR_robustness")]
			[RequiredByFeature("GL_KHR_robustness", Api = "gles2")]
			[ThreadStatic]
			internal static glGetnUniformiv pglGetnUniformiv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_KHR_robustness")]
			[RequiredByFeature("GL_KHR_robustness", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnUniformuiv(UInt32 program, Int32 location, Int32 bufSize, UInt32* @params);

			[AliasOf("glGetnUniformuiv")]
			[AliasOf("glGetnUniformuivKHR")]
			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_KHR_robustness")]
			[RequiredByFeature("GL_KHR_robustness", Api = "gles2")]
			[ThreadStatic]
			internal static glGetnUniformuiv pglGetnUniformuiv;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
			[RequiredByFeature("GL_KHR_robustness")]
			[RequiredByFeature("GL_KHR_robustness", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReadnPixels(Int32 x, Int32 y, Int32 width, Int32 height, Int32 format, Int32 type, Int32 bufSize, IntPtr data);

			[AliasOf("glReadnPixels")]
			[AliasOf("glReadnPixelsARB")]
			[AliasOf("glReadnPixelsEXT")]
			[AliasOf("glReadnPixelsKHR")]
			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
			[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
			[RequiredByFeature("GL_KHR_robustness")]
			[RequiredByFeature("GL_KHR_robustness", Api = "gles2")]
			[ThreadStatic]
			internal static glReadnPixels pglReadnPixels;

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnMapdv(Int32 target, Int32 query, Int32 bufSize, double* v);

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[ThreadStatic]
			internal static glGetnMapdv pglGetnMapdv;

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnMapfv(Int32 target, Int32 query, Int32 bufSize, float* v);

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[ThreadStatic]
			internal static glGetnMapfv pglGetnMapfv;

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnMapiv(Int32 target, Int32 query, Int32 bufSize, Int32* v);

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[ThreadStatic]
			internal static glGetnMapiv pglGetnMapiv;

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnPixelMapfv(Int32 map, Int32 bufSize, float* values);

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[ThreadStatic]
			internal static glGetnPixelMapfv pglGetnPixelMapfv;

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnPixelMapuiv(Int32 map, Int32 bufSize, UInt32* values);

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[ThreadStatic]
			internal static glGetnPixelMapuiv pglGetnPixelMapuiv;

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnPixelMapusv(Int32 map, Int32 bufSize, UInt16* values);

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[ThreadStatic]
			internal static glGetnPixelMapusv pglGetnPixelMapusv;

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnPolygonStipple(Int32 bufSize, byte* pattern);

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[ThreadStatic]
			internal static glGetnPolygonStipple pglGetnPolygonStipple;

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnColorTable(Int32 target, Int32 format, Int32 type, Int32 bufSize, IntPtr table);

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[ThreadStatic]
			internal static glGetnColorTable pglGetnColorTable;

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnConvolutionFilter(Int32 target, Int32 format, Int32 type, Int32 bufSize, IntPtr image);

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[ThreadStatic]
			internal static glGetnConvolutionFilter pglGetnConvolutionFilter;

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnSeparableFilter(Int32 target, Int32 format, Int32 type, Int32 rowBufSize, IntPtr row, Int32 columnBufSize, IntPtr column, IntPtr span);

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[ThreadStatic]
			internal static glGetnSeparableFilter pglGetnSeparableFilter;

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnHistogram(Int32 target, bool reset, Int32 format, Int32 type, Int32 bufSize, IntPtr values);

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[ThreadStatic]
			internal static glGetnHistogram pglGetnHistogram;

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnMinmax(Int32 target, bool reset, Int32 format, Int32 type, Int32 bufSize, IntPtr values);

			[RequiredByFeature("GL_VERSION_4_5", Profile = "compatibility")]
			[ThreadStatic]
			internal static glGetnMinmax pglGetnMinmax;

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_texture_barrier", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureBarrier();

			[RequiredByFeature("GL_VERSION_4_5")]
			[RequiredByFeature("GL_ARB_texture_barrier", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glTextureBarrier pglTextureBarrier;

		}
	}

}
