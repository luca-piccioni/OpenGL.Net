
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
		/// Value of GL_CONTEXT_LOST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_robustness")]
		public const int CONTEXT_LOST = 0x0507;

		/// <summary>
		/// Value of GL_NEGATIVE_ONE_TO_ONE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_clip_control")]
		public const int NEGATIVE_ONE_TO_ONE = 0x935E;

		/// <summary>
		/// Value of GL_ZERO_TO_ONE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_clip_control")]
		public const int ZERO_TO_ONE = 0x935F;

		/// <summary>
		/// Value of GL_CLIP_ORIGIN symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_clip_control")]
		public const int CLIP_ORIGIN = 0x935C;

		/// <summary>
		/// Value of GL_CLIP_DEPTH_MODE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_clip_control")]
		public const int CLIP_DEPTH_MODE = 0x935D;

		/// <summary>
		/// Value of GL_QUERY_WAIT_INVERTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_conditional_render_inverted")]
		public const int QUERY_WAIT_INVERTED = 0x8E17;

		/// <summary>
		/// Value of GL_QUERY_NO_WAIT_INVERTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_conditional_render_inverted")]
		public const int QUERY_NO_WAIT_INVERTED = 0x8E18;

		/// <summary>
		/// Value of GL_QUERY_BY_REGION_WAIT_INVERTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_conditional_render_inverted")]
		public const int QUERY_BY_REGION_WAIT_INVERTED = 0x8E19;

		/// <summary>
		/// Value of GL_QUERY_BY_REGION_NO_WAIT_INVERTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_conditional_render_inverted")]
		public const int QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A;

		/// <summary>
		/// Value of GL_MAX_CULL_DISTANCES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_cull_distance")]
		public const int MAX_CULL_DISTANCES = 0x82F9;

		/// <summary>
		/// Value of GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_cull_distance")]
		public const int MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA;

		/// <summary>
		/// Value of GL_TEXTURE_TARGET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public const int TEXTURE_TARGET = 0x1006;

		/// <summary>
		/// Value of GL_QUERY_TARGET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public const int QUERY_TARGET = 0x82EA;

		/// <summary>
		/// Value of GL_GUILTY_CONTEXT_RESET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_robustness")]
		public const int GUILTY_CONTEXT_RESET = 0x8253;

		/// <summary>
		/// Value of GL_INNOCENT_CONTEXT_RESET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_robustness")]
		public const int INNOCENT_CONTEXT_RESET = 0x8254;

		/// <summary>
		/// Value of GL_UNKNOWN_CONTEXT_RESET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_robustness")]
		public const int UNKNOWN_CONTEXT_RESET = 0x8255;

		/// <summary>
		/// Value of GL_RESET_NOTIFICATION_STRATEGY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_robustness")]
		public const int RESET_NOTIFICATION_STRATEGY = 0x8256;

		/// <summary>
		/// Value of GL_LOSE_CONTEXT_ON_RESET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_robustness")]
		public const int LOSE_CONTEXT_ON_RESET = 0x8252;

		/// <summary>
		/// Value of GL_NO_RESET_NOTIFICATION symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_robustness")]
		public const int NO_RESET_NOTIFICATION = 0x8261;

		/// <summary>
		/// Value of GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		public const uint CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004;

		/// <summary>
		/// Value of GL_CONTEXT_RELEASE_BEHAVIOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_context_flush_control")]
		public const int CONTEXT_RELEASE_BEHAVIOR = 0x82FB;

		/// <summary>
		/// Value of GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_context_flush_control")]
		public const int CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC;

		/// <summary>
		/// control clip coordinate to window coordinate behavior
		/// </summary>
		/// <param name="origin">
		/// Specifies the clip control origin. Must be one of GL_LOWER_LEFT or GL_UPPER_LEFT. 
		/// </param>
		/// <param name="depth">
		/// Specifies the clip control depth mode. Must be one of GL_NEGATIVE_ONE_TO_ONE or GL_ZERO_TO_ONE. 
		/// </param>
		/// <remarks>
		/// glClipControl controls the clipping volume behavior and the clip coordinate to window coordinate transformation 
		/// behavior.
		/// The view volume is defined by $$z_{min} \leq z_c \leq w_c$$ where $z_{min} = -w_c$ when depth is GL_NEGATIVE_ONE_TO_ONE, 
		/// and$z_{min} = 0$ when depth is GL_ZERO_TO_ONE. 
		/// The normalized device coordinate $y_d$ is given by $$y_d = { { f \times y_c } \over w_c }$$ where $f = 1$ when origin is 
		/// GL_LOWER_LEFT,and $f = -1$ when origin is GL_UPPER_LEFT. 
		/// The window coordinate $z_w$ is given by $$z_w = s \times z_d + b$$ where $s = { { f - n } \over 2 }$ and $b = { {n + f} 
		/// \over2 }$ when depth is GL_NEGATIVE_ONE_TO_ONE, and $s = f - n$ and $b = n$ when depth is GL_ZERO_TO_ONE. $n$ and $f$ 
		/// arethe near and far depth range values set with glDepthRange. 
		/// Finally, the polygon area computation defined by gl_FrontFacing to determine if a polygon is front- or back-facing has 
		/// itssign negated when origin is GL_UPPER_LEFT. 
		/// <para>
		/// The following errors can be generated:
		/// - An GL_INVALID_ENUM error is generated if origin is not GL_LOWER_LEFT or GL_UPPER_LEFT. 
		/// - An GL_INVALID_ENUM error is generated if depth is not GL_NEGATIVE_ONE_TO_ONE or GL_ZERO_TO_ONE. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl._ClipDistance"/>
		/// <seealso cref="Gl._CullDistance"/>
		/// <seealso cref="Gl._FrontFacing"/>
		/// <seealso cref="Gl.DepthRange"/>
		public static void ClipControl(int origin, int depth)
		{
			Debug.Assert(Delegates.pglClipControl != null, "pglClipControl not implemented");
			Delegates.pglClipControl(origin, depth);
			CallLog("glClipControl({0}, {1})", origin, depth);
			DebugCheckErrors();
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
		/// <remarks>
		/// glCreateTransformFeedbacks returns n previously unused transform feedback object names in ids, each representing a new 
		/// transformfeedback object initialized to the default state. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if n is negative. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BeginTransformFeedback"/>
		/// <seealso cref="Gl.BindTransformFeedback"/>
		/// <seealso cref="Gl.DeleteTransformFeedbacks"/>
		/// <seealso cref="Gl.EndTransformFeedback"/>
		/// <seealso cref="Gl.GenTransformFeedbacks"/>
		/// <seealso cref="Gl.IsTransformFeedback"/>
		/// <seealso cref="Gl.PauseTransformFeedback"/>
		/// <seealso cref="Gl.ResumeTransformFeedback"/>
		public static void CreateTransformFeedback(Int32 n, UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglCreateTransformFeedbacks != null, "pglCreateTransformFeedbacks not implemented");
					Delegates.pglCreateTransformFeedbacks(n, p_ids);
					CallLog("glCreateTransformFeedbacks({0}, {1})", n, ids);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// bind a buffer object to a transform feedback buffer object
		/// </summary>
		/// <param name="xfb">
		/// Name of the transform feedback buffer object. 
		/// </param>
		/// <param name="index">
		/// Index of the binding point within xfb. 
		/// </param>
		/// <param name="buffer">
		/// Name of the buffer object to bind to the specified binding point. 
		/// </param>
		/// <remarks>
		/// glTransformFeedbackBufferBase binds the buffer object buffer to the binding point at index index of the transform 
		/// feedbackobject xfb. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if xfb is not the name of an existing transform feedback object. 
		/// - GL_INVALID_VALUE is generated if in buffer is not zero or the name of an existing buffer object. 
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to the number of transform feedback buffer binding 
		///   points(the value of GL_TRANSFORM_FEEDBACK_BUFFER_BINDING). 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.TransformFeedbackBufferRange"/>
		public static void TransformFeedbackBufferBase(UInt32 xfb, UInt32 index, UInt32 buffer)
		{
			Debug.Assert(Delegates.pglTransformFeedbackBufferBase != null, "pglTransformFeedbackBufferBase not implemented");
			Delegates.pglTransformFeedbackBufferBase(xfb, index, buffer);
			CallLog("glTransformFeedbackBufferBase({0}, {1}, {2})", xfb, index, buffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// bind a range within a buffer object to a transform feedback buffer object
		/// </summary>
		/// <param name="xfb">
		/// Name of the transform feedback buffer object. 
		/// </param>
		/// <param name="index">
		/// Index of the binding point within xfb. 
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
		/// <remarks>
		/// glTransformFeedbackBufferRange binds a range of the buffer object buffer represented by offset and size to the binding 
		/// pointat index index of the transform feedback object xfb. 
		/// offset specifies the offset in basic machine units into the buffer object buffer and size specifies the amount of data 
		/// thatcan be read from the buffer object while used as an indexed target. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if xfb is not the name of an existing transform feedback object. 
		/// - GL_INVALID_VALUE is generated if in buffer is not zero or the name of an existing buffer object. 
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to the number of transform feedback buffer binding 
		///   points(the value of GL_TRANSFORM_FEEDBACK_BUFFER_BINDING). 
		/// - GL_INVALID_VALUE is generated if offset is negative. 
		/// - GL_INVALID_VALUE is generated if buffer is non-zero and either size is less than or equal to zero, or offset + size is 
		///   greaterthan the value of GL_BUFFER_SIZE for buffer. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.TransformFeedbackBufferBase"/>
		public static void TransformFeedbackBufferRange(UInt32 xfb, UInt32 index, UInt32 buffer, IntPtr offset, UInt32 size)
		{
			Debug.Assert(Delegates.pglTransformFeedbackBufferRange != null, "pglTransformFeedbackBufferRange not implemented");
			Delegates.pglTransformFeedbackBufferRange(xfb, index, buffer, offset, size);
			CallLog("glTransformFeedbackBufferRange({0}, {1}, {2}, {3}, {4})", xfb, index, buffer, offset, size);
			DebugCheckErrors();
		}

		/// <summary>
		/// query the state of a transform feedback object.
		/// </summary>
		/// <param name="xfb">
		/// The name of an existing transform feedback object, or zero for the default transform feedback object. 
		/// </param>
		/// <param name="pname">
		/// Property to use for the query. Must be one of the values: GL_TRANSFORM_FEEDBACK_BUFFER_BINDING, 
		/// GL_TRANSFORM_FEEDBACK_BUFFER_START,GL_TRANSFORM_FEEDBACK_BUFFER_SIZE, GL_TRANSFORM_FEEDBACK_PAUSED, 
		/// GL_TRANSFORM_FEEDBACK_ACTIVE.
		/// </param>
		/// <param name="param">
		/// The address of a buffer into which will be written the requested state information. 
		/// </param>
		/// <remarks>
		/// In order to use the Transform Feedback functionality, you need to configure the Transform Feedback Buffer indexed 
		/// bindings.This can be achieved by either using glBindBufferBase or glBindBuffersBase to associate whole buffer object 
		/// storageto one of the Transform Feedback Binding Points, or by calling glBindBufferRange or glBindBuffersRange to use a 
		/// regionof a buffer object storage for the binding. You may want to (but are not required to) bind a Transform Feedback 
		/// Objectfirst, in order to cache the binding configuration. This usually allows you to restore the Transform Feedback 
		/// configurationfaster, than if you were to execute a list of API calls necessary to set up the Transform Feedback state of 
		/// yourliking. 
		/// This reference page discusses two types of getters that operate on Transform Feedback Objects and their bindings. 
		/// The first class operates on general Transform Feedback binding point and includes glGetTransformFeedbackiv function. 
		/// glGetTransformFeedbackivcan be used to retrieve information about Transform Feedback object bound to the general 
		/// TransformFeedback binding point, as configured with a glBindTransformFeedback call. In this case, you can check: 
		/// What the ID of the currently bound Transform Feedback Object is; (GL_TRANSFORM_FEEDBACK_BUFFER_BINDING)Whether the 
		/// TransformFeedback process is currently paused; (GL_TRANSFORM_FEEDBACK_PAUSED)Whether the Transform Feedback process has 
		/// beenbegun and is currently undergoing; (GL_TRANSFORM_FEEDBACK_ACTIVE) 
		/// The latter class, which includes glGetTransformFeedbacki_v and glGetTransformFeedbacki64_v functions, can be used to 
		/// checkwhat the current configuration of each of the buffer object regions bound to Transform Feedback Buffer binding 
		/// pointsis. This allows you to query for the following information: 
		/// glGetTransformFeedbacki_v only: What the ID of the Buffer Object bound to a Transform Feedback Binding Point of 
		/// user-specifiedindex is; (GL_TRANSFORM_FEEDBACK_BUFFER_BINDING).glGetTransformFeedbacki64_v only: What the start offset 
		/// configuredfor the binding is; (GL_TRANSFORM_FEEDBACK_BUFFER_START);glGetTransformFeedbacki64_v only: What the length of 
		/// theregion used for the binding is; (GL_TRANSFORM_FEEDBACK_BUFFER_SIZE); 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION error is generated if xfb is not zero or the name of an existing transform feedback object. 
		/// - GL_INVALID_ENUM error is generated by glGetTransformFeedbackiv if pname is not GL_TRANSFORM_FEEDBACK_PAUSED or 
		///   GL_TRANSFORM_FEEDBACK_ACTIVE.
		/// - GL_INVALID_ENUM error is generated by glGetTransformFeedbacki_v if pname is not GL_TRANSFORM_FEEDBACK_BUFFER_BINDING. 
		/// - GL_INVALID_ENUM error is generated by glGetTransformFeedbacki64_v if pname is not GL_TRANSFORM_FEEDBACK_BUFFER_START or 
		///   GL_TRANSFORM_FEEDBACK_BUFFER_SIZE.
		/// - GL_INVALID_VALUE error is generated by glGetTransformFeedbacki_v and glGetTransformFeedbacki64_v if index is greater 
		///   thanor equal to the number of binding points for transform feedback (the value of GL_MAX_TRANSFORM_FEEDBACK_BUFFERS). 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.BindBuffersBase"/>
		/// <seealso cref="Gl.BindBuffersRange"/>
		/// <seealso cref="Gl.BindTransformFeedback"/>
		public static void GetTransformFeedback(UInt32 xfb, int pname, Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglGetTransformFeedbackiv != null, "pglGetTransformFeedbackiv not implemented");
					Delegates.pglGetTransformFeedbackiv(xfb, pname, p_param);
					CallLog("glGetTransformFeedbackiv({0}, {1}, {2})", xfb, pname, param);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// query the state of a transform feedback object.
		/// </summary>
		/// <param name="xfb">
		/// The name of an existing transform feedback object, or zero for the default transform feedback object. 
		/// </param>
		/// <param name="pname">
		/// Property to use for the query. Must be one of the values: GL_TRANSFORM_FEEDBACK_BUFFER_BINDING, 
		/// GL_TRANSFORM_FEEDBACK_BUFFER_START,GL_TRANSFORM_FEEDBACK_BUFFER_SIZE, GL_TRANSFORM_FEEDBACK_PAUSED, 
		/// GL_TRANSFORM_FEEDBACK_ACTIVE.
		/// </param>
		/// <param name="index">
		/// Index of the transform feedback stream (for indexed state). 
		/// </param>
		/// <param name="param">
		/// The address of a buffer into which will be written the requested state information. 
		/// </param>
		/// <remarks>
		/// In order to use the Transform Feedback functionality, you need to configure the Transform Feedback Buffer indexed 
		/// bindings.This can be achieved by either using glBindBufferBase or glBindBuffersBase to associate whole buffer object 
		/// storageto one of the Transform Feedback Binding Points, or by calling glBindBufferRange or glBindBuffersRange to use a 
		/// regionof a buffer object storage for the binding. You may want to (but are not required to) bind a Transform Feedback 
		/// Objectfirst, in order to cache the binding configuration. This usually allows you to restore the Transform Feedback 
		/// configurationfaster, than if you were to execute a list of API calls necessary to set up the Transform Feedback state of 
		/// yourliking. 
		/// This reference page discusses two types of getters that operate on Transform Feedback Objects and their bindings. 
		/// The first class operates on general Transform Feedback binding point and includes glGetTransformFeedbackiv function. 
		/// glGetTransformFeedbackivcan be used to retrieve information about Transform Feedback object bound to the general 
		/// TransformFeedback binding point, as configured with a glBindTransformFeedback call. In this case, you can check: 
		/// What the ID of the currently bound Transform Feedback Object is; (GL_TRANSFORM_FEEDBACK_BUFFER_BINDING)Whether the 
		/// TransformFeedback process is currently paused; (GL_TRANSFORM_FEEDBACK_PAUSED)Whether the Transform Feedback process has 
		/// beenbegun and is currently undergoing; (GL_TRANSFORM_FEEDBACK_ACTIVE) 
		/// The latter class, which includes glGetTransformFeedbacki_v and glGetTransformFeedbacki64_v functions, can be used to 
		/// checkwhat the current configuration of each of the buffer object regions bound to Transform Feedback Buffer binding 
		/// pointsis. This allows you to query for the following information: 
		/// glGetTransformFeedbacki_v only: What the ID of the Buffer Object bound to a Transform Feedback Binding Point of 
		/// user-specifiedindex is; (GL_TRANSFORM_FEEDBACK_BUFFER_BINDING).glGetTransformFeedbacki64_v only: What the start offset 
		/// configuredfor the binding is; (GL_TRANSFORM_FEEDBACK_BUFFER_START);glGetTransformFeedbacki64_v only: What the length of 
		/// theregion used for the binding is; (GL_TRANSFORM_FEEDBACK_BUFFER_SIZE); 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION error is generated if xfb is not zero or the name of an existing transform feedback object. 
		/// - GL_INVALID_ENUM error is generated by glGetTransformFeedbackiv if pname is not GL_TRANSFORM_FEEDBACK_PAUSED or 
		///   GL_TRANSFORM_FEEDBACK_ACTIVE.
		/// - GL_INVALID_ENUM error is generated by glGetTransformFeedbacki_v if pname is not GL_TRANSFORM_FEEDBACK_BUFFER_BINDING. 
		/// - GL_INVALID_ENUM error is generated by glGetTransformFeedbacki64_v if pname is not GL_TRANSFORM_FEEDBACK_BUFFER_START or 
		///   GL_TRANSFORM_FEEDBACK_BUFFER_SIZE.
		/// - GL_INVALID_VALUE error is generated by glGetTransformFeedbacki_v and glGetTransformFeedbacki64_v if index is greater 
		///   thanor equal to the number of binding points for transform feedback (the value of GL_MAX_TRANSFORM_FEEDBACK_BUFFERS). 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.BindBuffersBase"/>
		/// <seealso cref="Gl.BindBuffersRange"/>
		/// <seealso cref="Gl.BindTransformFeedback"/>
		public static void GetTransformFeedback(UInt32 xfb, int pname, UInt32 index, Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglGetTransformFeedbacki_v != null, "pglGetTransformFeedbacki_v not implemented");
					Delegates.pglGetTransformFeedbacki_v(xfb, pname, index, p_param);
					CallLog("glGetTransformFeedbacki_v({0}, {1}, {2}, {3})", xfb, pname, index, param);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// query the state of a transform feedback object.
		/// </summary>
		/// <param name="xfb">
		/// The name of an existing transform feedback object, or zero for the default transform feedback object. 
		/// </param>
		/// <param name="pname">
		/// Property to use for the query. Must be one of the values: GL_TRANSFORM_FEEDBACK_BUFFER_BINDING, 
		/// GL_TRANSFORM_FEEDBACK_BUFFER_START,GL_TRANSFORM_FEEDBACK_BUFFER_SIZE, GL_TRANSFORM_FEEDBACK_PAUSED, 
		/// GL_TRANSFORM_FEEDBACK_ACTIVE.
		/// </param>
		/// <param name="index">
		/// Index of the transform feedback stream (for indexed state). 
		/// </param>
		/// <param name="param">
		/// The address of a buffer into which will be written the requested state information. 
		/// </param>
		/// <remarks>
		/// In order to use the Transform Feedback functionality, you need to configure the Transform Feedback Buffer indexed 
		/// bindings.This can be achieved by either using glBindBufferBase or glBindBuffersBase to associate whole buffer object 
		/// storageto one of the Transform Feedback Binding Points, or by calling glBindBufferRange or glBindBuffersRange to use a 
		/// regionof a buffer object storage for the binding. You may want to (but are not required to) bind a Transform Feedback 
		/// Objectfirst, in order to cache the binding configuration. This usually allows you to restore the Transform Feedback 
		/// configurationfaster, than if you were to execute a list of API calls necessary to set up the Transform Feedback state of 
		/// yourliking. 
		/// This reference page discusses two types of getters that operate on Transform Feedback Objects and their bindings. 
		/// The first class operates on general Transform Feedback binding point and includes glGetTransformFeedbackiv function. 
		/// glGetTransformFeedbackivcan be used to retrieve information about Transform Feedback object bound to the general 
		/// TransformFeedback binding point, as configured with a glBindTransformFeedback call. In this case, you can check: 
		/// What the ID of the currently bound Transform Feedback Object is; (GL_TRANSFORM_FEEDBACK_BUFFER_BINDING)Whether the 
		/// TransformFeedback process is currently paused; (GL_TRANSFORM_FEEDBACK_PAUSED)Whether the Transform Feedback process has 
		/// beenbegun and is currently undergoing; (GL_TRANSFORM_FEEDBACK_ACTIVE) 
		/// The latter class, which includes glGetTransformFeedbacki_v and glGetTransformFeedbacki64_v functions, can be used to 
		/// checkwhat the current configuration of each of the buffer object regions bound to Transform Feedback Buffer binding 
		/// pointsis. This allows you to query for the following information: 
		/// glGetTransformFeedbacki_v only: What the ID of the Buffer Object bound to a Transform Feedback Binding Point of 
		/// user-specifiedindex is; (GL_TRANSFORM_FEEDBACK_BUFFER_BINDING).glGetTransformFeedbacki64_v only: What the start offset 
		/// configuredfor the binding is; (GL_TRANSFORM_FEEDBACK_BUFFER_START);glGetTransformFeedbacki64_v only: What the length of 
		/// theregion used for the binding is; (GL_TRANSFORM_FEEDBACK_BUFFER_SIZE); 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION error is generated if xfb is not zero or the name of an existing transform feedback object. 
		/// - GL_INVALID_ENUM error is generated by glGetTransformFeedbackiv if pname is not GL_TRANSFORM_FEEDBACK_PAUSED or 
		///   GL_TRANSFORM_FEEDBACK_ACTIVE.
		/// - GL_INVALID_ENUM error is generated by glGetTransformFeedbacki_v if pname is not GL_TRANSFORM_FEEDBACK_BUFFER_BINDING. 
		/// - GL_INVALID_ENUM error is generated by glGetTransformFeedbacki64_v if pname is not GL_TRANSFORM_FEEDBACK_BUFFER_START or 
		///   GL_TRANSFORM_FEEDBACK_BUFFER_SIZE.
		/// - GL_INVALID_VALUE error is generated by glGetTransformFeedbacki_v and glGetTransformFeedbacki64_v if index is greater 
		///   thanor equal to the number of binding points for transform feedback (the value of GL_MAX_TRANSFORM_FEEDBACK_BUFFERS). 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.BindBuffersBase"/>
		/// <seealso cref="Gl.BindBuffersRange"/>
		/// <seealso cref="Gl.BindTransformFeedback"/>
		public static void GetTransformFeedback(UInt32 xfb, int pname, UInt32 index, Int64[] param)
		{
			unsafe {
				fixed (Int64* p_param = param)
				{
					Debug.Assert(Delegates.pglGetTransformFeedbacki64_v != null, "pglGetTransformFeedbacki64_v not implemented");
					Delegates.pglGetTransformFeedbacki64_v(xfb, pname, index, p_param);
					CallLog("glGetTransformFeedbacki64_v({0}, {1}, {2}, {3})", xfb, pname, index, param);
				}
			}
			DebugCheckErrors();
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
		/// <remarks>
		/// glCreateBuffers returns n previously unused buffer names in buffers, each representing a new buffer object initialized 
		/// asif it had been bound to an unspecified target. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if n is negative. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.IsBuffer"/>
		public static void CreateBuffers(Int32 n, UInt32[] buffers)
		{
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				{
					Debug.Assert(Delegates.pglCreateBuffers != null, "pglCreateBuffers not implemented");
					Delegates.pglCreateBuffers(n, p_buffers);
					CallLog("glCreateBuffers({0}, {1})", n, buffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// creates and initializes a buffer object's immutable data store
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for glNamedBufferStorage function. 
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the buffer object's new data store. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be 
		/// copied.
		/// </param>
		/// <param name="flags">
		/// Specifies the intended usage of the buffer's data store. Must be a bitwise combination of the following flags. 
		/// GL_DYNAMIC_STORAGE_BIT,GL_MAP_READ_BITGL_MAP_WRITE_BIT, GL_MAP_PERSISTENT_BIT, GL_MAP_COHERENT_BIT, and 
		/// GL_CLIENT_STORAGE_BIT.
		/// </param>
		/// <remarks>
		/// glBufferStorage and glNamedBufferStorage create a new immutable data store. For glBufferStorage, the buffer object 
		/// currentlybound to target will be initialized. For glNamedBufferStorage, buffer is the name of the buffer object that 
		/// willbe configured. The size of the data store is specified by size. If an initial data is available, its address may be 
		/// suppliedin data. Otherwise, to create an uninitialized data store, data should be NULL. 
		/// The flags parameters specifies the intended usage of the buffer's data store. It must be a bitwise combination of a 
		/// subsetof the following flags: GL_DYNAMIC_STORAGE_BITThe contents of the data store may be updated after creation through 
		/// callsto glBufferSubData. If this bit is not set, the buffer content may not be directly updated by the client. The data 
		/// argumentmay be used to specify the initial content of the buffer's data store regardless of the presence of the 
		/// GL_DYNAMIC_STORAGE_BIT.Regardless of the presence of this bit, buffers may always be updated with server-side calls such 
		/// asglCopyBufferSubData and glClearBufferSubData.GL_MAP_READ_BITThe data store may be mapped by the client for read access 
		/// anda pointer in the client's address space obtained that may be read from.GL_MAP_WRITE_BITThe data store may be mapped 
		/// bythe client for write access and a pointer in the client's address space obtained that may be written 
		/// through.GL_MAP_PERSISTENT_BITTheclient may request that the server read from or write to the buffer while it is mapped. 
		/// Theclient's pointer to the data store remains valid so long as the data store is mapped, even during execution of 
		/// drawingor dispatch commands.GL_MAP_COHERENT_BITShared access to buffers that are simultaneously mapped for client access 
		/// andare used by the server will be coherent, so long as that mapping is performed using glMapBufferRange. That is, data 
		/// writtento the store by either the client or server will be immediately visible to the other with no further action taken 
		/// bythe application. In particular,If GL_MAP_COHERENT_BIT is not set and the client performs a write followed by a call to 
		/// theglMemoryBarrier command with the GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT set, then in subsequent commands the server will 
		/// seethe writes.If GL_MAP_COHERENT_BIT is set and the client performs a write, then in subsequent commands the server will 
		/// seethe writes.If GL_MAP_COHERENT_BIT is not set and the server performs a write, the application must call 
		/// glMemoryBarrierwith the GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT set and then call glFenceSync with 
		/// GL_SYNC_GPU_COMMANDS_COMPLETE(or glFinish). Then the CPU will see the writes after the sync is complete.If 
		/// GL_MAP_COHERENT_BITis set and the server does a write, the app must call FenceSync with GL_SYNC_GPU_COMMANDS_COMPLETE 
		/// (orglFinish). Then the CPU will see the writes after the sync is complete.GL_CLIENT_STORAGE_BITWhen all other criteria 
		/// forthe buffer storage allocation are met, this bit may be used by an implementation to determine whether to use storage 
		/// thatis local to the server or to the client to serve as the backing store for the buffer. 
		/// The allowed combinations of flags are subject to certain restrictions. They are as follows: If flags contains 
		/// GL_MAP_PERSISTENT_BIT,it must also contain at least one of GL_MAP_READ_BIT or GL_MAP_WRITE_BIT.If flags contains 
		/// GL_MAP_COHERENT_BIT,it must also contain GL_MAP_PERSISTENT_BIT. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glBufferStorage if target is not one of the accepted buffer targets. 
		/// - GL_INVALID_OPERATION is generated by glNamedBufferStorage if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_VALUE is generated if size is less than or equal to zero. 
		/// - GL_INVALID_OPERATION is generated by glBufferStorage if the reserved buffer object name 0 is bound to target. 
		/// - GL_OUT_OF_MEMORY is generated if the GL is unable to create a data store with the properties requested in flags. 
		/// - GL_INVALID_VALUE is generated if flags has any bits set other than those defined above. 
		/// - GL_INVALID_VALUE error is generated if flags contains GL_MAP_PERSISTENT_BIT but does not contain at least one of 
		///   GL_MAP_READ_BITor GL_MAP_WRITE_BIT. 
		/// - GL_INVALID_VALUE is generated if flags contains GL_MAP_COHERENT_BIT, but does not also contain GL_MAP_PERSISTENT_BIT. 
		/// - GL_INVALID_OPERATION is generated by glBufferStorage if the GL_BUFFER_IMMUTABLE_STORAGE flag of the buffer bound to 
		///   targetis GL_TRUE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetBufferSubData 
		/// - glGetBufferParameter with argument GL_BUFFER_SIZE or GL_BUFFER_USAGE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		public static void NamedBufferStorage(UInt32 buffer, UInt32 size, IntPtr data, uint flags)
		{
			Debug.Assert(Delegates.pglNamedBufferStorage != null, "pglNamedBufferStorage not implemented");
			Delegates.pglNamedBufferStorage(buffer, size, data, flags);
			CallLog("glNamedBufferStorage({0}, {1}, {2}, {3})", buffer, size, data, flags);
			DebugCheckErrors();
		}

		/// <summary>
		/// creates and initializes a buffer object's immutable data store
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for glNamedBufferStorage function. 
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the buffer object's new data store. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be 
		/// copied.
		/// </param>
		/// <param name="flags">
		/// Specifies the intended usage of the buffer's data store. Must be a bitwise combination of the following flags. 
		/// GL_DYNAMIC_STORAGE_BIT,GL_MAP_READ_BITGL_MAP_WRITE_BIT, GL_MAP_PERSISTENT_BIT, GL_MAP_COHERENT_BIT, and 
		/// GL_CLIENT_STORAGE_BIT.
		/// </param>
		/// <remarks>
		/// glBufferStorage and glNamedBufferStorage create a new immutable data store. For glBufferStorage, the buffer object 
		/// currentlybound to target will be initialized. For glNamedBufferStorage, buffer is the name of the buffer object that 
		/// willbe configured. The size of the data store is specified by size. If an initial data is available, its address may be 
		/// suppliedin data. Otherwise, to create an uninitialized data store, data should be NULL. 
		/// The flags parameters specifies the intended usage of the buffer's data store. It must be a bitwise combination of a 
		/// subsetof the following flags: GL_DYNAMIC_STORAGE_BITThe contents of the data store may be updated after creation through 
		/// callsto glBufferSubData. If this bit is not set, the buffer content may not be directly updated by the client. The data 
		/// argumentmay be used to specify the initial content of the buffer's data store regardless of the presence of the 
		/// GL_DYNAMIC_STORAGE_BIT.Regardless of the presence of this bit, buffers may always be updated with server-side calls such 
		/// asglCopyBufferSubData and glClearBufferSubData.GL_MAP_READ_BITThe data store may be mapped by the client for read access 
		/// anda pointer in the client's address space obtained that may be read from.GL_MAP_WRITE_BITThe data store may be mapped 
		/// bythe client for write access and a pointer in the client's address space obtained that may be written 
		/// through.GL_MAP_PERSISTENT_BITTheclient may request that the server read from or write to the buffer while it is mapped. 
		/// Theclient's pointer to the data store remains valid so long as the data store is mapped, even during execution of 
		/// drawingor dispatch commands.GL_MAP_COHERENT_BITShared access to buffers that are simultaneously mapped for client access 
		/// andare used by the server will be coherent, so long as that mapping is performed using glMapBufferRange. That is, data 
		/// writtento the store by either the client or server will be immediately visible to the other with no further action taken 
		/// bythe application. In particular,If GL_MAP_COHERENT_BIT is not set and the client performs a write followed by a call to 
		/// theglMemoryBarrier command with the GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT set, then in subsequent commands the server will 
		/// seethe writes.If GL_MAP_COHERENT_BIT is set and the client performs a write, then in subsequent commands the server will 
		/// seethe writes.If GL_MAP_COHERENT_BIT is not set and the server performs a write, the application must call 
		/// glMemoryBarrierwith the GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT set and then call glFenceSync with 
		/// GL_SYNC_GPU_COMMANDS_COMPLETE(or glFinish). Then the CPU will see the writes after the sync is complete.If 
		/// GL_MAP_COHERENT_BITis set and the server does a write, the app must call FenceSync with GL_SYNC_GPU_COMMANDS_COMPLETE 
		/// (orglFinish). Then the CPU will see the writes after the sync is complete.GL_CLIENT_STORAGE_BITWhen all other criteria 
		/// forthe buffer storage allocation are met, this bit may be used by an implementation to determine whether to use storage 
		/// thatis local to the server or to the client to serve as the backing store for the buffer. 
		/// The allowed combinations of flags are subject to certain restrictions. They are as follows: If flags contains 
		/// GL_MAP_PERSISTENT_BIT,it must also contain at least one of GL_MAP_READ_BIT or GL_MAP_WRITE_BIT.If flags contains 
		/// GL_MAP_COHERENT_BIT,it must also contain GL_MAP_PERSISTENT_BIT. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glBufferStorage if target is not one of the accepted buffer targets. 
		/// - GL_INVALID_OPERATION is generated by glNamedBufferStorage if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_VALUE is generated if size is less than or equal to zero. 
		/// - GL_INVALID_OPERATION is generated by glBufferStorage if the reserved buffer object name 0 is bound to target. 
		/// - GL_OUT_OF_MEMORY is generated if the GL is unable to create a data store with the properties requested in flags. 
		/// - GL_INVALID_VALUE is generated if flags has any bits set other than those defined above. 
		/// - GL_INVALID_VALUE error is generated if flags contains GL_MAP_PERSISTENT_BIT but does not contain at least one of 
		///   GL_MAP_READ_BITor GL_MAP_WRITE_BIT. 
		/// - GL_INVALID_VALUE is generated if flags contains GL_MAP_COHERENT_BIT, but does not also contain GL_MAP_PERSISTENT_BIT. 
		/// - GL_INVALID_OPERATION is generated by glBufferStorage if the GL_BUFFER_IMMUTABLE_STORAGE flag of the buffer bound to 
		///   targetis GL_TRUE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetBufferSubData 
		/// - glGetBufferParameter with argument GL_BUFFER_SIZE or GL_BUFFER_USAGE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		public static void NamedBufferStorage(UInt32 buffer, UInt32 size, Object data, uint flags)
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
		/// Specifies the name of the buffer object for glNamedBufferData function. 
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the buffer object's new data store. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be 
		/// copied.
		/// </param>
		/// <param name="usage">
		/// Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, 
		/// GL_STREAM_COPY,GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY. 
		/// </param>
		/// <remarks>
		/// glBufferData and glNamedBufferData create a new data store for a buffer object. In case of glBufferData, the buffer 
		/// objectcurrently bound to target is used. For glNamedBufferData, a buffer object associated with ID specified by the 
		/// callerin buffer will be used instead. 
		/// While creating the new storage, any pre-existing data store is deleted. The new data store is created with the specified 
		/// sizein bytes and usage. If data is not NULL, the data store is initialized with data from this pointer. In its initial 
		/// state,the new data store is not mapped, it has a NULL mapped pointer, and its mapped access is GL_READ_WRITE. 
		/// usage is a hint to the GL implementation as to how a buffer object's data store will be accessed. This enables the GL 
		/// implementationto make more intelligent decisions that may significantly impact buffer object performance. It does not, 
		/// however,constrain the actual usage of the data store. usage can be broken down into two parts: first, the frequency of 
		/// access(modification and usage), and second, the nature of that access. The frequency of access may be one of these: 
		/// The nature of access may be one of these: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glBufferData if target is not one of the accepted buffer targets. 
		/// - GL_INVALID_ENUM is generated if usage is not GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, 
		///   GL_STATIC_READ,GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY. 
		/// - GL_INVALID_VALUE is generated if size is negative. 
		/// - GL_INVALID_OPERATION is generated by glBufferData if the reserved buffer object name 0 is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glNamedBufferData if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_OPERATION is generated if the GL_BUFFER_IMMUTABLE_STORAGE flag of the buffer object is GL_TRUE. 
		/// - GL_OUT_OF_MEMORY is generated if the GL is unable to create a data store with the specified size. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetBufferSubData 
		/// - glGetBufferParameter with argument GL_BUFFER_SIZE or GL_BUFFER_USAGE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		public static void NamedBufferData(UInt32 buffer, UInt32 size, IntPtr data, int usage)
		{
			Debug.Assert(Delegates.pglNamedBufferData != null, "pglNamedBufferData not implemented");
			Delegates.pglNamedBufferData(buffer, size, data, usage);
			CallLog("glNamedBufferData({0}, {1}, {2}, {3})", buffer, size, data, usage);
			DebugCheckErrors();
		}

		/// <summary>
		/// creates and initializes a buffer object's data store
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for glNamedBufferData function. 
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the buffer object's new data store. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be 
		/// copied.
		/// </param>
		/// <param name="usage">
		/// Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, 
		/// GL_STREAM_COPY,GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY. 
		/// </param>
		/// <remarks>
		/// glBufferData and glNamedBufferData create a new data store for a buffer object. In case of glBufferData, the buffer 
		/// objectcurrently bound to target is used. For glNamedBufferData, a buffer object associated with ID specified by the 
		/// callerin buffer will be used instead. 
		/// While creating the new storage, any pre-existing data store is deleted. The new data store is created with the specified 
		/// sizein bytes and usage. If data is not NULL, the data store is initialized with data from this pointer. In its initial 
		/// state,the new data store is not mapped, it has a NULL mapped pointer, and its mapped access is GL_READ_WRITE. 
		/// usage is a hint to the GL implementation as to how a buffer object's data store will be accessed. This enables the GL 
		/// implementationto make more intelligent decisions that may significantly impact buffer object performance. It does not, 
		/// however,constrain the actual usage of the data store. usage can be broken down into two parts: first, the frequency of 
		/// access(modification and usage), and second, the nature of that access. The frequency of access may be one of these: 
		/// The nature of access may be one of these: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glBufferData if target is not one of the accepted buffer targets. 
		/// - GL_INVALID_ENUM is generated if usage is not GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, 
		///   GL_STATIC_READ,GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY. 
		/// - GL_INVALID_VALUE is generated if size is negative. 
		/// - GL_INVALID_OPERATION is generated by glBufferData if the reserved buffer object name 0 is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glNamedBufferData if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_OPERATION is generated if the GL_BUFFER_IMMUTABLE_STORAGE flag of the buffer object is GL_TRUE. 
		/// - GL_OUT_OF_MEMORY is generated if the GL is unable to create a data store with the specified size. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetBufferSubData 
		/// - glGetBufferParameter with argument GL_BUFFER_SIZE or GL_BUFFER_USAGE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		public static void NamedBufferData(UInt32 buffer, UInt32 size, Object data, int usage)
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
		/// Specifies the name of the buffer object for glNamedBufferSubData. 
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
		/// <remarks>
		/// glBufferSubData and glNamedBufferSubData redefine some or all of the data store for the specified buffer object. Data 
		/// startingat byte offset offset and extending for size bytes is copied to the data store from the memory pointed to by 
		/// data.offset and size must define a range lying entirely within the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glBufferSubData if target is not one of the accepted buffer targets. 
		/// - GL_INVALID_OPERATION is generated by glBufferSubData if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glNamedBufferSubData if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_VALUE is generated if offset or size is negative, or if $offset + size$ is greater than the value of 
		///   GL_BUFFER_SIZEfor the specified buffer object. 
		/// - GL_INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		///   glMapBufferRangeor glMapBuffer, unless it was mapped with the GL_MAP_PERSISTENT_BIT bit set in the 
		///   glMapBufferRangeaccessflags. 
		/// - GL_INVALID_OPERATION is generated if the value of the GL_BUFFER_IMMUTABLE_STORAGE flag of the buffer object is GL_TRUE 
		///   andthe value of GL_BUFFER_STORAGE_FLAGS for the buffer object does not have the GL_DYNAMIC_STORAGE_BIT bit set. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetBufferSubData 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		public static void NamedBufferSubData(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data)
		{
			Debug.Assert(Delegates.pglNamedBufferSubData != null, "pglNamedBufferSubData not implemented");
			Delegates.pglNamedBufferSubData(buffer, offset, size, data);
			CallLog("glNamedBufferSubData({0}, {1}, {2}, {3})", buffer, offset, size, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// updates a subset of a buffer object's data store
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for glNamedBufferSubData. 
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
		/// <remarks>
		/// glBufferSubData and glNamedBufferSubData redefine some or all of the data store for the specified buffer object. Data 
		/// startingat byte offset offset and extending for size bytes is copied to the data store from the memory pointed to by 
		/// data.offset and size must define a range lying entirely within the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glBufferSubData if target is not one of the accepted buffer targets. 
		/// - GL_INVALID_OPERATION is generated by glBufferSubData if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glNamedBufferSubData if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_VALUE is generated if offset or size is negative, or if $offset + size$ is greater than the value of 
		///   GL_BUFFER_SIZEfor the specified buffer object. 
		/// - GL_INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		///   glMapBufferRangeor glMapBuffer, unless it was mapped with the GL_MAP_PERSISTENT_BIT bit set in the 
		///   glMapBufferRangeaccessflags. 
		/// - GL_INVALID_OPERATION is generated if the value of the GL_BUFFER_IMMUTABLE_STORAGE flag of the buffer object is GL_TRUE 
		///   andthe value of GL_BUFFER_STORAGE_FLAGS for the buffer object does not have the GL_DYNAMIC_STORAGE_BIT bit set. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetBufferSubData 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
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
		/// Specifies the name of the source buffer object for glCopyNamedBufferSubData. 
		/// </param>
		/// <param name="writeBuffer">
		/// Specifies the name of the destination buffer object for glCopyNamedBufferSubData. 
		/// </param>
		/// <param name="readOffset">
		/// Specifies the offset, in basic machine units, within the data store of the source buffer object at which data will be 
		/// read.
		/// </param>
		/// <param name="writeOffset">
		/// Specifies the offset, in basic machine units, within the data store of the destination buffer object at which data will 
		/// bewritten. 
		/// </param>
		/// <param name="size">
		/// Specifies the size, in basic machine units, of the data to be copied from the source buffer object to the destination 
		/// bufferobject. 
		/// </param>
		/// <remarks>
		/// glCopyBufferSubData and glCopyNamedBufferSubData copy part of the data store attached to a source buffer object to the 
		/// datastore attached to a destination buffer object. The number of basic machine units indicated by size is copied from 
		/// thesource at offset readOffset to the destination at writeOffset. readOffset, writeOffset and size are in terms of basic 
		/// machineunits. 
		/// For glCopyBufferSubData, readTarget and writeTarget specify the targets to which the source and destination buffer 
		/// objectsare bound, and must each be one of the buffer binding targets in the following table: 
		/// Any of these targets may be used, but the targets GL_COPY_READ_BUFFER and GL_COPY_WRITE_BUFFER are provided specifically 
		/// toallow copies between buffers without disturbing other GL state. 
		/// readOffset, writeOffset and size must all be greater than or equal to zero. Furthermore, $readOffset+size$ must not 
		/// exceeedthe size of the source buffer object, and $writeOffset+size$ must not exceeed the size of the buffer bound to 
		/// writeTarget.If the source and destination are the same buffer object, then the source and destination ranges must not 
		/// overlap.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glCopyBufferSubData if readTarget or writeTarget is not one of the buffer binding 
		///   targetslisted above. 
		/// - GL_INVALID_OPERATION is generated by glCopyBufferSubData if zero is bound to readTarget or writeTarget. 
		/// - GL_INVALID_OPERATION is generated by glCopyNamedBufferSubData if readBuffer or writeBuffer is not the name of an 
		///   existingbuffer object. 
		/// - GL_INVALID_VALUE is generated if any of readOffset, writeOffset or size is negative, if $readOffset + size$ is greater 
		///   thanthe size of the source buffer object (its value of GL_BUFFER_SIZE), or if $writeOffset + size$ is greater than the 
		///   sizeof the destination buffer object. 
		/// - GL_INVALID_VALUE is generated if the source and destination are the same buffer object, and the ranges 
		///   $[readOffset,readOffset+size)$and $[writeOffset,writeOffset+size)$ overlap. 
		/// - GL_INVALID_OPERATION is generated if either the source or destination buffer object is mapped with glMapBufferRange or 
		///   glMapBuffer,unless they were mapped with the GL_MAP_PERSISTENT bit set in the glMapBufferRangeaccess flags. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		public static void CopyNamedBufferSubData(UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, UInt32 size)
		{
			Debug.Assert(Delegates.pglCopyNamedBufferSubData != null, "pglCopyNamedBufferSubData not implemented");
			Delegates.pglCopyNamedBufferSubData(readBuffer, writeBuffer, readOffset, writeOffset, size);
			CallLog("glCopyNamedBufferSubData({0}, {1}, {2}, {3}, {4})", readBuffer, writeBuffer, readOffset, writeOffset, size);
			DebugCheckErrors();
		}

		/// <summary>
		/// fill a buffer object's data store with a fixed value
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for glClearNamedBufferData. 
		/// </param>
		/// <param name="internalformat">
		/// The internal format with which the data will be stored in the buffer object. 
		/// </param>
		/// <param name="format">
		/// The format of the data in memory addressed by data. 
		/// </param>
		/// <param name="type">
		/// The type of the data in memory addressed by data. 
		/// </param>
		/// <param name="data">
		/// The address of a memory location storing the data to be replicated into the buffer's data store. 
		/// </param>
		/// <remarks>
		/// glClearBufferData and glClearNamedBufferData fill the entirety of a buffer object's data store with data from client 
		/// memory.
		/// Data, initially supplied in a format specified by format in data type type is read from the memory address given by data 
		/// andconverted into the internal representation given by internalformat, which must be one of the following sized internal 
		/// formats:
		/// This converted data is then replicated throughout the buffer object's data store. If data is NULL, then the buffer's 
		/// datastore is filled with zeros. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glClearBufferData if target is not one of the generic buffer binding targets. 
		/// - GL_INVALID_VALUE is generated by glClearBufferData if no buffer is bound target. 
		/// - GL_INVALID_OPERATION is generated by glClearNamedBufferData if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_ENUM is generated if internalformat is not one of the valid sized internal formats listed in the table above. 
		/// - GL_INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		///   glMapBufferRangeor glMapBuffer, unless it was mapped with the GL_MAP_PERSISTENT_BIT bit set in the 
		///   glMapBufferRangeaccessflags. 
		/// - GL_INVALID_VALUE is generated if format is not a valid format, or type is not a valid type. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ClearBufferSubData"/>
		public static void ClearNamedBufferData(UInt32 buffer, int internalformat, int format, int type, IntPtr data)
		{
			Debug.Assert(Delegates.pglClearNamedBufferData != null, "pglClearNamedBufferData not implemented");
			Delegates.pglClearNamedBufferData(buffer, internalformat, format, type, data);
			CallLog("glClearNamedBufferData({0}, {1}, {2}, {3}, {4})", buffer, internalformat, format, type, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// fill a buffer object's data store with a fixed value
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for glClearNamedBufferData. 
		/// </param>
		/// <param name="internalformat">
		/// The internal format with which the data will be stored in the buffer object. 
		/// </param>
		/// <param name="format">
		/// The format of the data in memory addressed by data. 
		/// </param>
		/// <param name="type">
		/// The type of the data in memory addressed by data. 
		/// </param>
		/// <param name="data">
		/// The address of a memory location storing the data to be replicated into the buffer's data store. 
		/// </param>
		/// <remarks>
		/// glClearBufferData and glClearNamedBufferData fill the entirety of a buffer object's data store with data from client 
		/// memory.
		/// Data, initially supplied in a format specified by format in data type type is read from the memory address given by data 
		/// andconverted into the internal representation given by internalformat, which must be one of the following sized internal 
		/// formats:
		/// This converted data is then replicated throughout the buffer object's data store. If data is NULL, then the buffer's 
		/// datastore is filled with zeros. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glClearBufferData if target is not one of the generic buffer binding targets. 
		/// - GL_INVALID_VALUE is generated by glClearBufferData if no buffer is bound target. 
		/// - GL_INVALID_OPERATION is generated by glClearNamedBufferData if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_ENUM is generated if internalformat is not one of the valid sized internal formats listed in the table above. 
		/// - GL_INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		///   glMapBufferRangeor glMapBuffer, unless it was mapped with the GL_MAP_PERSISTENT_BIT bit set in the 
		///   glMapBufferRangeaccessflags. 
		/// - GL_INVALID_VALUE is generated if format is not a valid format, or type is not a valid type. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ClearBufferSubData"/>
		public static void ClearNamedBufferData(UInt32 buffer, int internalformat, int format, int type, Object data)
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
		/// Specifies the name of the buffer object for glClearNamedBufferSubData. 
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
		/// The format of the data in memory addressed by data. 
		/// </param>
		/// <param name="type">
		/// The type of the data in memory addressed by data. 
		/// </param>
		/// <param name="data">
		/// The address of a memory location storing the data to be replicated into the buffer's data store. 
		/// </param>
		/// <remarks>
		/// glClearBufferSubData and glClearNamedBufferSubData fill a specified region of a buffer object's data store with data 
		/// fromclient memory. 
		/// offset and size specify the extent of the region within the data store of the buffer object to fill with data. Data, 
		/// initiallysupplied in a format specified by format in data type type is read from the memory address given by data and 
		/// convertedinto the internal representation given by internalformat, which must be one of the following sized internal 
		/// formats:
		/// This converted data is then replicated throughout the specified region of the buffer object's data store. If data is 
		/// NULL,then the subrange of the buffer's data store is filled with zeros. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glClearBufferSubData if target is not one of the generic buffer binding targets. 
		/// - GL_INVALID_VALUE is generated by glClearBufferSubData if no buffer is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glClearNamedBufferSubData if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_ENUM is generated if internalformat is not one of the valid sized internal formats listed in the table above. 
		/// - GL_INVALID_VALUE is generated if offset or range are not multiples of the number of basic machine units per-element for 
		///   theinternal format specified by internalformat. This value may be computed by multiplying the number of components for 
		///   internalformatfrom the table by the size of the base type from the table. 
		/// - GL_INVALID_VALUE is generated if offset or size is negative, or if $offset + size$ is greater than the value of 
		///   GL_BUFFER_SIZEfor the buffer object. 
		/// - GL_INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		///   glMapBufferRangeor glMapBuffer, unless it was mapped with the GL_MAP_PERSISTENT_BIT bit set in the 
		///   glMapBufferRangeaccessflags. 
		/// - GL_INVALID_VALUE is generated if format is not a valid format, or type is not a valid type. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ClearBufferData"/>
		public static void ClearNamedBufferSubData(UInt32 buffer, int internalformat, IntPtr offset, UInt32 size, int format, int type, IntPtr data)
		{
			Debug.Assert(Delegates.pglClearNamedBufferSubData != null, "pglClearNamedBufferSubData not implemented");
			Delegates.pglClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
			CallLog("glClearNamedBufferSubData({0}, {1}, {2}, {3}, {4}, {5}, {6})", buffer, internalformat, offset, size, format, type, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// fill all or part of buffer object's data store with a fixed value
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for glClearNamedBufferSubData. 
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
		/// The format of the data in memory addressed by data. 
		/// </param>
		/// <param name="type">
		/// The type of the data in memory addressed by data. 
		/// </param>
		/// <param name="data">
		/// The address of a memory location storing the data to be replicated into the buffer's data store. 
		/// </param>
		/// <remarks>
		/// glClearBufferSubData and glClearNamedBufferSubData fill a specified region of a buffer object's data store with data 
		/// fromclient memory. 
		/// offset and size specify the extent of the region within the data store of the buffer object to fill with data. Data, 
		/// initiallysupplied in a format specified by format in data type type is read from the memory address given by data and 
		/// convertedinto the internal representation given by internalformat, which must be one of the following sized internal 
		/// formats:
		/// This converted data is then replicated throughout the specified region of the buffer object's data store. If data is 
		/// NULL,then the subrange of the buffer's data store is filled with zeros. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glClearBufferSubData if target is not one of the generic buffer binding targets. 
		/// - GL_INVALID_VALUE is generated by glClearBufferSubData if no buffer is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glClearNamedBufferSubData if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_ENUM is generated if internalformat is not one of the valid sized internal formats listed in the table above. 
		/// - GL_INVALID_VALUE is generated if offset or range are not multiples of the number of basic machine units per-element for 
		///   theinternal format specified by internalformat. This value may be computed by multiplying the number of components for 
		///   internalformatfrom the table by the size of the base type from the table. 
		/// - GL_INVALID_VALUE is generated if offset or size is negative, or if $offset + size$ is greater than the value of 
		///   GL_BUFFER_SIZEfor the buffer object. 
		/// - GL_INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		///   glMapBufferRangeor glMapBuffer, unless it was mapped with the GL_MAP_PERSISTENT_BIT bit set in the 
		///   glMapBufferRangeaccessflags. 
		/// - GL_INVALID_VALUE is generated if format is not a valid format, or type is not a valid type. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ClearBufferData"/>
		public static void ClearNamedBufferSubData(UInt32 buffer, int internalformat, IntPtr offset, UInt32 size, int format, int type, Object data)
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
		/// Specifies the name of the buffer object for glMapNamedBuffer. 
		/// </param>
		/// <param name="access">
		/// Specifies the access policy for glMapBuffer and glMapNamedBuffer, indicating whether it will be possible to read from, 
		/// writeto, or both read from and write to the buffer object's mapped data store. The symbolic constant must be 
		/// GL_READ_ONLY,GL_WRITE_ONLY, or GL_READ_WRITE. 
		/// </param>
		/// <remarks>
		/// glMapBuffer and glMapNamedBuffer map the entire data store of a specified buffer object into the client's address space. 
		/// Thedata can then be directly read and/or written relative to the returned pointer, depending on the specified access 
		/// policy.
		/// A pointer to the beginning of the mapped range is returned once all pending operations on that buffer object have 
		/// completed,and may be used to modify and/or query the corresponding range of the data store according to the value of 
		/// access:GL_READ_ONLY indicates that the returned pointer may be used to read buffer object data. GL_WRITE_ONLY indicates 
		/// thatthe returned pointer may be used to modify buffer object data. GL_READ_WRITE indicates that the returned pointer may 
		/// beused to read and to modify buffer object data. 
		/// If an error is generated, a NULL pointer is returned. 
		/// If no error occurs, the returned pointer will reflect an allocation aligned to the value of GL_MIN_MAP_BUFFER_ALIGNMENT 
		/// basicmachine units. 
		/// The returned pointer values may not be passed as parameter values to GL commands. For example, they may not be used to 
		/// specifyarray pointers, or to specify or query pixel or texture image data; such actions produce undefined results, 
		/// althoughimplementations may not check for such behavior for performance reasons. 
		/// No GL error is generated if the returned pointer is accessed in a way inconsistent with access (e.g. used to read from a 
		/// mappingmade with accessGL_WRITE_ONLY or write to a mapping made with accessGL_READ_ONLY), but the result is undefined 
		/// andsystem errors (possibly including program termination) may occur. 
		/// Mappings to the data stores of buffer objects may have nonstandard performance characteristics. For example, such 
		/// mappingsmay be marked as uncacheable regions of memory, and in such cases reading from them may be very slow. To ensure 
		/// optimalperformance, the client should use the mapping in a fashion consistent with the values of GL_BUFFER_USAGE for the 
		/// bufferobject and of access. Using a mapping in a fashion inconsistent with these values is liable to be multiple orders 
		/// ofmagnitude slower than using normal memory. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glMapBuffer if target is not one of the buffer binding targets listed above. 
		/// - GL_INVALID_OPERATION is generated by glMapBuffer if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glMapNamedBuffer if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_ENUM is generated if access is not GL_READ_ONLY, GL_WRITE_ONLY, or GL_READ_WRITE. 
		/// - GL_OUT_OF_MEMORY is generated if the GL is unable to map the buffer object's data store. This may occur for a variety of 
		///   system-specificreasons, such as the absence of sufficient remaining virtual memory. 
		/// - GL_INVALID_OPERATION is generated if the buffer object is in a mapped state. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetBufferPointerv with argument GL_BUFFER_MAP_POINTER 
		/// - glGetBufferParameter with argument GL_BUFFER_MAPPED, GL_BUFFER_ACCESS, or GL_BUFFER_USAGE 
		/// - glGet with pnameGL_MIN_MAP_BUFFER_ALIGNMENT. The value must be a power of two that is at least 64. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		public static IntPtr MapNamedBuffer(UInt32 buffer, int access)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglMapNamedBuffer != null, "pglMapNamedBuffer not implemented");
			retValue = Delegates.pglMapNamedBuffer(buffer, access);
			CallLog("glMapNamedBuffer({0}, {1}) = {2}", buffer, access, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// map all or part of a buffer object's data store into the client's address space
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for glMapNamedBufferRange. 
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
		/// <remarks>
		/// glMapBufferRange and glMapNamedBufferRange map all or part of the data store of a specified buffer object into the 
		/// client'saddress space. offset and length indicate the range of data in the buffer object that is to be mapped, in terms 
		/// ofbasic machine units. access is a bitfield containing flags which describe the requested mapping. These flags are 
		/// describedbelow. 
		/// A pointer to the beginning of the mapped range is returned once all pending operations on the buffer object have 
		/// completed,and may be used to modify and/or query the corresponding range of the data store according to the following 
		/// flagbits set in access: GL_MAP_READ_BIT indicates that the returned pointer may be used to read buffer object data. No 
		/// GLerror is generated if the pointer is used to query a mapping which excludes this flag, but the result is undefined and 
		/// systemerrors (possibly including program termination) may occur. GL_MAP_WRITE_BIT indicates that the returned pointer 
		/// maybe used to modify buffer object data. No GL error is generated if the pointer is used to modify a mapping which 
		/// excludesthis flag, but the result is undefined and system errors (possibly including program termination) may occur. 
		/// GL_MAP_PERSISTENT_BITindicates that the mapping is to be made in a persistent fassion and that the client intends to 
		/// holdand use the returned pointer during subsequent GL operation. It is not an error to call drawing commands (render) 
		/// whilebuffers are mapped using this flag. It is an error to specify this flag if the buffer's data store was not 
		/// allocatedthrough a call to the glBufferStorage command in which the GL_MAP_PERSISTENT_BIT was also set. 
		/// GL_MAP_COHERENT_BITindicates that a persistent mapping is also to be coherent. Coherent maps guarantee that the effect 
		/// ofwrites to a buffer's data store by either the client or server will eventually become visible to the other without 
		/// furtherintervention from the application. In the absence of this bit, persistent mappings are not coherent and modified 
		/// rangesof the buffer store must be explicitly communicated to the GL, either by unmapping the buffer, or through a call 
		/// toglFlushMappedBufferRange or glMemoryBarrier. 
		/// The following optional flag bits in access may be used to modify the mapping: GL_MAP_INVALIDATE_RANGE_BIT indicates that 
		/// theprevious contents of the specified range may be discarded. Data within this range are undefined with the exception of 
		/// subsequentlywritten data. No GL error is generated if subsequent GL operations access unwritten data, but the result is 
		/// undefinedand system errors (possibly including program termination) may occur. This flag may not be used in combination 
		/// withGL_MAP_READ_BIT. GL_MAP_INVALIDATE_BUFFER_BIT indicates that the previous contents of the entire buffer may be 
		/// discarded.Data within the entire buffer are undefined with the exception of subsequently written data. No GL error is 
		/// generatedif subsequent GL operations access unwritten data, but the result is undefined and system errors (possibly 
		/// includingprogram termination) may occur. This flag may not be used in combination with GL_MAP_READ_BIT. 
		/// GL_MAP_FLUSH_EXPLICIT_BITindicates that one or more discrete subranges of the mapping may be modified. When this flag is 
		/// set,modifications to each subrange must be explicitly flushed by calling glFlushMappedBufferRange. No GL error is set if 
		/// asubrange of the mapping is modified and not flushed, but data within the corresponding subrange of the buffer are 
		/// undefined.This flag may only be used in conjunction with GL_MAP_WRITE_BIT. When this option is selected, flushing is 
		/// strictlylimited to regions that are explicitly indicated with calls to glFlushMappedBufferRange prior to unmap; if this 
		/// optionis not selected glUnmapBuffer will automatically flush the entire mapped range when called. 
		/// GL_MAP_UNSYNCHRONIZED_BITindicates that the GL should not attempt to synchronize pending operations on the buffer prior 
		/// toreturning from glMapBufferRange or glMapNamedBufferRange. No GL error is generated if pending operations which source 
		/// ormodify the buffer overlap the mapped region, but the result of such previous and any subsequent operations is 
		/// undefined.
		/// If an error occurs, a NULL pointer is returned. 
		/// If no error occurs, the returned pointer will reflect an allocation aligned to the value of GL_MIN_MAP_BUFFER_ALIGNMENT 
		/// basicmachine units. Subtracting offset from this returned pointer will always produce a multiple of the value of 
		/// GL_MIN_MAP_BUFFER_ALIGNMENT.
		/// The returned pointer values may not be passed as parameter values to GL commands. For example, they may not be used to 
		/// specifyarray pointers, or to specify or query pixel or texture image data; such actions produce undefined results, 
		/// althoughimplementations may not check for such behavior for performance reasons. 
		/// Mappings to the data stores of buffer objects may have nonstandard performance characteristics. For example, such 
		/// mappingsmay be marked as uncacheable regions of memory, and in such cases reading from them may be very slow. To ensure 
		/// optimalperformance, the client should use the mapping in a fashion consistent with the values of GL_BUFFER_USAGE for the 
		/// bufferobject and of access. Using a mapping in a fashion inconsistent with these values is liable to be multiple orders 
		/// ofmagnitude slower than using normal memory. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glMapBufferRange if target is not one of the buffer binding targets listed above. 
		/// - GL_INVALID_OPERATION is generated by glMapBufferRange if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glMapNamedBufferRange if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_VALUE is generated if offset or length is negative, if $offset + length$ is greater than the value of 
		///   GL_BUFFER_SIZEfor the buffer object, or if access has any bits set other than those defined above. 
		/// - GL_INVALID_OPERATION is generated for any of the following conditions: length is zero. The buffer object is already in a 
		///   mappedstate. Neither GL_MAP_READ_BIT nor GL_MAP_WRITE_BIT is set. GL_MAP_READ_BIT is set and any of 
		///   GL_MAP_INVALIDATE_RANGE_BIT,GL_MAP_INVALIDATE_BUFFER_BIT or GL_MAP_UNSYNCHRONIZED_BIT is set. GL_MAP_FLUSH_EXPLICIT_BIT 
		///   isset and GL_MAP_WRITE_BIT is not set. Any of GL_MAP_READ_BIT, GL_MAP_WRITE_BIT, GL_MAP_PERSISTENT_BIT, or 
		///   GL_MAP_COHERENT_BITare set, but the same bit is not included in the buffer's storage flags. 
		/// - No error is generated if memory outside the mapped range is modified or queried, but the result is undefined and system 
		///   errors(possibly including program termination) may occur. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with pnameGL_MIN_MAP_BUFFER_ALIGNMENT. The value must be a power of two that is at least 64. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		/// <seealso cref="Gl.FlushMappedBufferRange"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferStorage"/>
		public static IntPtr MapNamedBufferRange(UInt32 buffer, IntPtr offset, UInt32 length, uint access)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglMapNamedBufferRange != null, "pglMapNamedBufferRange not implemented");
			retValue = Delegates.pglMapNamedBufferRange(buffer, offset, length, access);
			CallLog("glMapNamedBufferRange({0}, {1}, {2}, {3}) = {4}", buffer, offset, length, access, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// release the mapping of a buffer object's data store into the client's address space
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for glUnmapNamedBuffer. 
		/// </param>
		/// <remarks>
		/// glUnmapBuffer and glUnmapNamedBuffer unmap (release) any mapping of a specified buffer object into the client's address 
		/// space(see glMapBufferRange and glMapBuffer). 
		/// If a mapping is not unmapped before the corresponding buffer object's data store is used by the GL, an error will be 
		/// generatedby any GL command that attempts to dereference the buffer object's data store, unless the buffer was 
		/// successfullymapped with GL_MAP_PERSISTENT_BIT (see glMapBufferRange). When a data store is unmapped, the mapped pointer 
		/// becomesinvalid. 
		/// glUnmapBuffer returns GL_TRUE unless the data store contents have become corrupt during the time the data store was 
		/// mapped.This can occur for system-specific reasons that affect the availability of graphics memory, such as screen mode 
		/// changes.In such situations, GL_FALSE is returned and the data store contents are undefined. An application must detect 
		/// thisrare condition and reinitialize the data store. 
		/// A buffer object's mapped data store is automatically unmapped when the buffer object is deleted or its data store is 
		/// recreatedwith glBufferData). 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glUnmapBuffer if target is not one of the buffer binding targets listed above. 
		/// - GL_INVALID_OPERATION is generated by glUnmapBuffer if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glUnmapNamedBuffer if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_OPERATION is generated if the buffer object is not in a mapped state. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetBufferParameter with argument GL_BUFFER_MAPPED. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		public static bool UnmapNamedBuffer(UInt32 buffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglUnmapNamedBuffer != null, "pglUnmapNamedBuffer not implemented");
			retValue = Delegates.pglUnmapNamedBuffer(buffer);
			CallLog("glUnmapNamedBuffer({0}) = {1}", buffer, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// indicate modifications to a range of a mapped buffer
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for glFlushMappedNamedBufferRange. 
		/// </param>
		/// <param name="offset">
		/// Specifies the start of the buffer subrange, in basic machine units. 
		/// </param>
		/// <param name="length">
		/// Specifies the length of the buffer subrange, in basic machine units. 
		/// </param>
		/// <remarks>
		/// glFlushMappedBufferRange indicates that modifications have been made to a range of a mapped buffer object. The buffer 
		/// objectmust previously have been mapped with the GL_MAP_FLUSH_EXPLICIT_BIT flag. 
		/// offset and length indicate the modified subrange of the mapping, in basic machine units. The specified subrange to flush 
		/// isrelative to the start of the currently mapped range of the buffer. These commands may be called multiple times to 
		/// indicatedistinct subranges of the mapping which require flushing. 
		/// If a buffer range is mapped with both GL_MAP_PERSISTENT_BIT and GL_MAP_FLUSH_EXPLICIT_BIT set, then these commands may 
		/// becalled to ensure that data written by the client into the flushed region becomes visible to the server. Data written 
		/// toa coherent store will always become visible to the server after an unspecified period of time. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glFlushMappedBufferRange if target is not one of the buffer binding targets listed 
		///   above.
		/// - GL_INVALID_OPERATION is generated by glFlushMappedBufferRange if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glFlushMappedNamedBufferRange if buffer is not the name of an existing buffer 
		///   object.
		/// - GL_INVALID_VALUE is generated if offset or length is negative, or if offset + length exceeds the size of the mapping. 
		/// - GL_INVALID_OPERATION is generated if the buffer object is not mapped, or is mapped without the GL_MAP_FLUSH_EXPLICIT_BIT 
		///   flag.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.MapBufferRange"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		public static void FlushMappedNamedBufferRange(UInt32 buffer, IntPtr offset, UInt32 length)
		{
			Debug.Assert(Delegates.pglFlushMappedNamedBufferRange != null, "pglFlushMappedNamedBufferRange not implemented");
			Delegates.pglFlushMappedNamedBufferRange(buffer, offset, length);
			CallLog("glFlushMappedNamedBufferRange({0}, {1}, {2})", buffer, offset, length);
			DebugCheckErrors();
		}

		/// <summary>
		/// return parameters of a buffer object
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for glGetNamedBufferParameteriv and glGetNamedBufferParameteri64v. 
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// These functions return in data a selected parameter of the specified buffer object. 
		/// pname names a specific buffer object parameter, as follows: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glGetBufferParameter* if target is not one of the accepted buffer targets. 
		/// - GL_INVALID_OPERATION is generated by glGetBufferParameter* if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glGetNamedBufferParameter* if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_ENUM is generated if pname is not one of the buffer object parameter names described above. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		public static void GetNamedBufferParameter(UInt32 buffer, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetNamedBufferParameteriv != null, "pglGetNamedBufferParameteriv not implemented");
					Delegates.pglGetNamedBufferParameteriv(buffer, pname, p_params);
					CallLog("glGetNamedBufferParameteriv({0}, {1}, {2})", buffer, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return parameters of a buffer object
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for glGetNamedBufferParameteriv and glGetNamedBufferParameteri64v. 
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		/// <remarks>
		/// These functions return in data a selected parameter of the specified buffer object. 
		/// pname names a specific buffer object parameter, as follows: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glGetBufferParameter* if target is not one of the accepted buffer targets. 
		/// - GL_INVALID_OPERATION is generated by glGetBufferParameter* if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glGetNamedBufferParameter* if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_ENUM is generated if pname is not one of the buffer object parameter names described above. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		public static void GetNamedBufferParameter(UInt32 buffer, int pname, Int64[] @params)
		{
			unsafe {
				fixed (Int64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetNamedBufferParameteri64v != null, "pglGetNamedBufferParameteri64v not implemented");
					Delegates.pglGetNamedBufferParameteri64v(buffer, pname, p_params);
					CallLog("glGetNamedBufferParameteri64v({0}, {1}, {2})", buffer, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the pointer to a mapped buffer object's data store
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for glGetNamedBufferPointerv. 
		/// </param>
		/// <param name="pname">
		/// Specifies the name of the pointer to be returned. Must be GL_BUFFER_MAP_POINTER. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// glGetBufferPointerv and glGetNamedBufferPointerv return the buffer pointer pname, which must be GL_BUFFER_MAP_POINTER. 
		/// Thesingle buffer map pointer is returned in params. A NULL pointer is returned if the buffer object's data store is not 
		/// currentlymapped; or if the requesting context did not map the buffer object's data store, and the implementation is 
		/// unableto support mappings on multiple clients. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if by glGetBufferPointerv if target is not one of the accepted buffer targets, or if pname 
		///   isnot GL_BUFFER_MAP_POINTER. 
		/// - GL_INVALID_OPERATION is generated by glGetBufferPointerv if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glGetNamedBufferPointerv if buffer is not the name of an existing buffer object. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.MapBuffer"/>
		public static void GetNamedBufferPointer(UInt32 buffer, int pname, IntPtr @params)
		{
			Debug.Assert(Delegates.pglGetNamedBufferPointerv != null, "pglGetNamedBufferPointerv not implemented");
			Delegates.pglGetNamedBufferPointerv(buffer, pname, @params);
			CallLog("glGetNamedBufferPointerv({0}, {1}, {2})", buffer, pname, @params);
			DebugCheckErrors();
		}

		/// <summary>
		/// returns a subset of a buffer object's data store
		/// </summary>
		/// <param name="buffer">
		/// Specifies the name of the buffer object for glGetNamedBufferSubData. 
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
		/// <remarks>
		/// glGetBufferSubData and glGetNamedBufferSubData return some or all of the data contents of the data store of the 
		/// specifiedbuffer object. Data starting at byte offset offset and extending for size bytes is copied from the buffer 
		/// object'sdata store to the memory pointed to by data. An error is thrown if the buffer object is currently mapped, or if 
		/// offsetand size together define a range beyond the bounds of the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glGetBufferSubData if target is not one of the generic buffer binding targets. 
		/// - GL_INVALID_OPERATION is generated by glGetBufferSubData if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glGetNamedBufferSubData if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_VALUE is generated if offset or size is negative, or if $offset + size$ is greater than the value of 
		///   GL_BUFFER_SIZEfor the buffer object. 
		/// - GL_INVALID_OPERATION is generated if the buffer object is mapped with glMapBufferRange or glMapBuffer, unless it was 
		///   mappedwith the GL_MAP_PERSISTENT_BIT bit set in the glMapBufferRangeaccess flags. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		public static void GetNamedBufferSubData(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data)
		{
			Debug.Assert(Delegates.pglGetNamedBufferSubData != null, "pglGetNamedBufferSubData not implemented");
			Delegates.pglGetNamedBufferSubData(buffer, offset, size, data);
			CallLog("glGetNamedBufferSubData({0}, {1}, {2}, {3})", buffer, offset, size, data);
			DebugCheckErrors();
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
		/// <remarks>
		/// glCreateFramebuffers returns n previously unused framebuffer names in framebuffers, each representing a new framebuffer 
		/// objectinitialized to the default state. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if n is negative. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		/// <seealso cref="Gl.FramebufferTexture1D"/>
		/// <seealso cref="Gl.FramebufferTexture2D"/>
		/// <seealso cref="Gl.FramebufferTexture3D"/>
		/// <seealso cref="Gl.FramebufferTextureFace"/>
		/// <seealso cref="Gl.FramebufferTextureLayer"/>
		/// <seealso cref="Gl.DeleteFramebuffers"/>
		/// <seealso cref="Gl.IsFramebuffer"/>
		public static void CreateFramebuffers(Int32 n, UInt32[] framebuffers)
		{
			unsafe {
				fixed (UInt32* p_framebuffers = framebuffers)
				{
					Debug.Assert(Delegates.pglCreateFramebuffers != null, "pglCreateFramebuffers not implemented");
					Delegates.pglCreateFramebuffers(n, p_framebuffers);
					CallLog("glCreateFramebuffers({0}, {1})", n, framebuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// attach a renderbuffer as a logical buffer of a framebuffer object
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for glNamedFramebufferRenderbuffer. 
		/// </param>
		/// <param name="attachment">
		/// Specifies the attachment point of the framebuffer. 
		/// </param>
		/// <param name="renderbuffertarget">
		/// Specifies the renderbuffer target. Must be GL_RENDERBUFFER. 
		/// </param>
		/// <param name="renderbuffer">
		/// Specifies the name of an existing renderbuffer object of type renderbuffertarget to attach. 
		/// </param>
		/// <remarks>
		/// glFramebufferRenderbuffer and glNamedFramebufferRenderbuffer attaches a renderbuffer as one of the logical buffers of 
		/// thespecified framebuffer object. Renderbuffers cannot be attached to the default draw and read framebuffer, so they are 
		/// notvalid targets of these commands. 
		/// For glFramebufferRenderbuffer, the framebuffer object is that bound to target, which must be GL_DRAW_FRAMEBUFFER, 
		/// GL_READ_FRAMEBUFFERor GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. 
		/// For glNamedFramebufferRenderbuffer, framebuffer is the name of the framebuffer object. 
		/// renderbuffertarget must be GL_RENDERBUFFER. 
		/// renderbuffer must be zero or the name of an existing renderbuffer object of type renderbuffertarget. If renderbuffer is 
		/// notzero, then the specified renderbuffer will be used as the logical buffer identified by attachment of the specified 
		/// framebufferobject. If renderbuffer is zero, then the value of renderbuffertarget is ignored. 
		/// attachment specifies the logical attachment of the framebuffer and must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, 
		/// GL_STENCIL_ATTACHMENTor GL_DEPTH_STENCIL_ATTACHMENT. i in may range from zero to the value of GL_MAX_COLOR_ATTACHMENTS 
		/// minusone. Setting attachment to the value GL_DEPTH_STENCIL_ATTACHMENT is a special case causing both the depth and 
		/// stencilattachments of the specified framebuffer object to be set to renderbuffer, which should have the base internal 
		/// formatGL_DEPTH_STENCIL. 
		/// The value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE for the specified attachment point is set to GL_RENDERBUFFER and the 
		/// valueof GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME is set to renderbuffer. All other state values of specified attachment 
		/// pointare set to their default values. No change is made to the state of the renderbuuffer object and any previous 
		/// attachmentto the attachment logical buffer of the specified framebuffer object is broken. 
		/// If renderbuffer is zero, these commands will detach the image, if any, identified by the specified attachment point of 
		/// thespecified framebuffer object. All state values of the attachment point are set to their default values. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glFramebufferRenderbuffer if target is not one of the accepted framebuffer targets. 
		/// - GL_INVALID_OPERATION is generated by glFramebufferRenderbuffer if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glNamedFramebufferRenderbuffer if framebuffer is not the name of an existing 
		///   framebufferobject. 
		/// - GL_INVALID_ENUM is generated if attachment is not one of the accepted attachment points. 
		/// - GL_INVALID_ENUM is generated if renderbuffertarget is not GL_RENDERBUFFER. 
		/// - GL_INVALID_OPERATION is generated if renderbuffertarget is not zero or the name of an existing renderbuffer object of 
		///   typeGL_RENDERBUFFER. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		/// <seealso cref="Gl.FramebufferTexture1D"/>
		/// <seealso cref="Gl.FramebufferTexture2D"/>
		/// <seealso cref="Gl.FramebufferTexture3D"/>
		public static void NamedFramebufferRenderbuffer(UInt32 framebuffer, int attachment, int renderbuffertarget, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglNamedFramebufferRenderbuffer != null, "pglNamedFramebufferRenderbuffer not implemented");
			Delegates.pglNamedFramebufferRenderbuffer(framebuffer, attachment, renderbuffertarget, renderbuffer);
			CallLog("glNamedFramebufferRenderbuffer({0}, {1}, {2}, {3})", framebuffer, attachment, renderbuffertarget, renderbuffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// set a named parameter of a framebuffer object
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for glNamedFramebufferParameteri. 
		/// </param>
		/// <param name="pname">
		/// Specifies the framebuffer parameter to be modified. 
		/// </param>
		/// <param name="param">
		/// The new value for the parameter named pname. 
		/// </param>
		/// <remarks>
		/// glFramebufferParameteri and glNamedFramebufferParameteri modify the value of the parameter named pname in the specified 
		/// framebufferobject. There are no modifiable parameters of the default draw and read framebuffer, so they are not valid 
		/// targetsof these commands. 
		/// For glFramebufferParameteri, the framebuffer object is that bound to target, which must be GL_DRAW_FRAMEBUFFER, 
		/// GL_READ_FRAMEBUFFERor GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. 
		/// For glNamedFramebufferParameteri, framebuffer is the name of the framebuffer object. 
		/// pname specifies the parameter to be modified. The following values are accepted: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glFramebufferParameteri if target is not one of the accepted framebuffer targets. 
		/// - GL_INVALID_OPERATION is generated by glFramebufferParameteri if the default framebuffer is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glNamedFramebufferParameteri if framebuffer is not the name of an existing 
		///   framebufferobject. 
		/// - GL_INVALID_VALUE is generated if pname is GL_FRAMEBUFFER_DEFAULT_WIDTH and param is less than zero or greater than the 
		///   valueof GL_MAX_FRAMEBUFFER_WIDTH. 
		/// - GL_INVALID_VALUE is generated if pname is GL_FRAMEBUFFER_DEFAULT_HEIGHT and param is less than zero or greater than the 
		///   valueof GL_MAX_FRAMEBUFFER_HEIGHT. 
		/// - GL_INVALID_VALUE is generated if pname is GL_FRAMEBUFFER_DEFAULT_LAYERS and param is less than zero or greater than the 
		///   valueof GL_MAX_FRAMEBUFFER_LAYERS. 
		/// - GL_INVALID_VALUE is generated if pname is GL_FRAMEBUFFER_DEFAULT_SAMPLES and param is less than zero or greater than the 
		///   valueof GL_MAX_FRAMEBUFFER_SAMPLES. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetFramebufferParameteriv. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.CreateFramebuffers"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.GetFramebufferParameter"/>
		public static void NamedFramebufferParameter(UInt32 framebuffer, int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglNamedFramebufferParameteri != null, "pglNamedFramebufferParameteri not implemented");
			Delegates.pglNamedFramebufferParameteri(framebuffer, pname, param);
			CallLog("glNamedFramebufferParameteri({0}, {1}, {2})", framebuffer, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// attach a level of a texture object as a logical buffer of a framebuffer object
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for glNamedFramebufferTexture. 
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
		/// <remarks>
		/// These commands attach a selected mipmap level or image of a texture object as one of the logical buffers of the 
		/// specifiedframebuffer object. Textures cannot be attached to the default draw and read framebuffer, so they are not valid 
		/// targetsof these commands. 
		/// For all commands exceptglNamedFramebufferTexture, the framebuffer object is that bound to target, which must be 
		/// GL_DRAW_FRAMEBUFFER,GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. 
		/// For glNamedFramebufferTexture, framebuffer is the name of the framebuffer object. 
		/// attachment specifies the logical attachment of the framebuffer and must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, 
		/// GL_STENCIL_ATTACHMENTor GL_DEPTH_STENCIL_ATTACHMENT. i in GL_COLOR_ATTACHMENTi may range from zero to the value of 
		/// GL_MAX_COLOR_ATTACHMENTSminus one. Attaching a level of a texture to GL_DEPTH_STENCIL_ATTACHMENT is equivalent to 
		/// attachingthat level to both the GL_DEPTH_ATTACHMENTand the GL_STENCIL_ATTACHMENT attachment points simultaneously. 
		/// For glFramebufferTexture1D, glFramebufferTexture2D and glFramebufferTexture3D, textarget specifies what type of texture 
		/// isnamed by texture, and for cube map textures, specifies the face that is to be attached. If texture is not zero, it 
		/// mustbe the name of an existing texture object with effective target textarget unless it is a cube map texture, in which 
		/// casetextarget must be GL_TEXTURE_CUBE_MAP_POSITIVE_XGL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. 
		/// If texture is non-zero, the specified level of the texture object named texture is attached to the framebfufer 
		/// attachmentpoint named by attachment. For glFramebufferTexture1D, glFramebufferTexture2D, and glFramebufferTexture3D, 
		/// texturemust be zero or the name of an existing texture with an effective target of textarget, or texture must be the 
		/// nameof an existing cube-map texture and textarget must be one of GL_TEXTURE_CUBE_MAP_POSITIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. 
		/// If textarget is GL_TEXTURE_RECTANGLE, GL_TEXTURE_2D_MULTISAMPLE, or GL_TEXTURE_2D_MULTISAMPLE_ARRAY, then level must be 
		/// zero.
		/// If textarget is GL_TEXTURE_3D, then level must be greater than or equal to zero and less than or equal to $log_2$ of the 
		/// valueof GL_MAX_3D_TEXTURE_SIZE. 
		/// If textarget is one of GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_X,GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, then level must be 
		/// greaterthan or equal to zero and less than or equal to $log_2$ of the value of GL_MAX_CUBE_MAP_TEXTURE_SIZE. 
		/// For all other values of textarget, level must be greater than or equal to zero and less than or equal to $log_2$ of the 
		/// valueof GL_MAX_TEXTURE_SIZE. 
		/// layer specifies the layer of a 2-dimensional image within a 3-dimensional texture. 
		/// For glFramebufferTexture1D, if texture is not zero, then textarget must be GL_TEXTURE_1D. For glFramebufferTexture2D, if 
		/// textureis not zero, textarget must be one of GL_TEXTURE_2D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_2D_MULTISAMPLE. For glFramebufferTexture3D, 
		/// iftexture is not zero, then textarget must be GL_TEXTURE_3D. 
		/// For glFramebufferTexture and glNamedFramebufferTexture, if texture is the name of a three-dimensional, cube map array, 
		/// cubemap, one- or two-dimensional array, or two-dimensional multisample array texture, the specified texture level is an 
		/// arrayof images, and the framebuffer attachment is considered to be layered. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by all commands accepting a target parameter if it is not one of the accepted framebuffer 
		///   targets.
		/// - GL_INVALID_OPERATION is generated by all commands accepting a target parameter if zero is bound to that target. 
		/// - GL_INVALID_OPERATION is generated by glNamedFramebufferTexture if framebuffer is not the name of an existing framebuffer 
		///   object.
		/// - GL_INVALID_ENUM is generated if attachment is not one of the accepted attachment points. 
		/// - GL_INVALID_VALUE is generated if texture is not zero or the name of an existing texture object. 
		/// - GL_INVALID_VALUE is generated if texture is not zero and level is not a supported texture level for texture. 
		/// - GL_INVALID_VALUE is generated by glFramebufferTexture3D if texture is not zero and layer is larger than the value of 
		///   GL_MAX_3D_TEXTURE_SIZEminus one. 
		/// - GL_INVALID_OPERATION is generated by all commands accepting a textarget parameter if texture is not zero, and textarget 
		///   andthe effective target of texture are not compatible. 
		/// - GL_INVALID_OPERATION is generated by if texture is a buffer texture. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		/// <seealso cref="Gl.FramebufferTexture1D"/>
		/// <seealso cref="Gl.FramebufferTexture2D"/>
		/// <seealso cref="Gl.FramebufferTexture3D"/>
		public static void NamedFramebufferTexture(UInt32 framebuffer, int attachment, UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglNamedFramebufferTexture != null, "pglNamedFramebufferTexture not implemented");
			Delegates.pglNamedFramebufferTexture(framebuffer, attachment, texture, level);
			CallLog("glNamedFramebufferTexture({0}, {1}, {2}, {3})", framebuffer, attachment, texture, level);
			DebugCheckErrors();
		}

		/// <summary>
		/// attach a single layer of a texture object as a logical buffer of a framebuffer object
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for glNamedFramebufferTextureLayer. 
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
		/// <remarks>
		/// glFramebufferTextureLayer and glNamedFramebufferTextureLayer attach a single layer of a three-dimensional or array 
		/// textureobject as one of the logical buffers of the specified framebuffer object. Textures cannot be attached to the 
		/// defaultdraw and read framebuffer, so they are not valid targets of these commands. 
		/// For glFramebufferTextureLayer, the framebuffer object is that bound to target, which must be GL_DRAW_FRAMEBUFFER, 
		/// GL_READ_FRAMEBUFFER,or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. 
		/// For glNamedFramebufferTextureLayer, framebuffer is the name of the framebuffer object. 
		/// attachment specifies the logical attachment of the framebuffer and must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, 
		/// GL_STENCIL_ATTACHMENTor GL_DEPTH_STENCIL_ATTACHMENT. i in GL_COLOR_ATTACHMENTi may range from zero to the value of 
		/// GL_MAX_COLOR_ATTACHMENTSminus one. Attaching a level of a texture to GL_DEPTH_STENCIL_ATTACHMENT is equivalent to 
		/// attachingthat level to both the GL_DEPTH_ATTACHMENTand the GL_STENCIL_ATTACHMENT attachment points simultaneously. 
		/// If texture is not zero, it must be the name of a three-dimensional, two-dimensional multisample array, one- or 
		/// two-dimensionalarray, or cube map array texture. 
		/// If texture is a three-dimensional texture, then level must be greater than or equal to zero and less than or equal to 
		/// $log_2$of the value of GL_MAX_3D_TEXTURE_SIZE. 
		/// If texture is a two-dimensional array texture, then level must be greater than or equal to zero and less than or equal 
		/// to$log_2$ of the value of GL_MAX_TEXTURE_SIZE. 
		/// For cube map textures, layer is translated into a cube map face according to $$ face = k \bmod 6. $$ For cube map array 
		/// textures,layer is translated into an array layer and face according to $$ layer = \left\lfloor { layer \over 6 } 
		/// \right\rfloor$$and $$ face = k \bmod 6. $$ 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glFramebufferTexture if target is not one of the accepted framebuffer targets. 
		/// - GL_INVALID_OPERATION is generated by glFramebufferTexture if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glNamedFramebufferTexture if framebuffer is not the name of an existing framebuffer 
		///   object.
		/// - GL_INVALID_ENUM is generated if attachment is not one of the accepted attachment points. 
		/// - GL_INVALID_OPERATION is generated if texture is not zero and is not the name of an existing three-dimensional, 
		///   two-dimensionalmultisample array, one- or two-dimensional array, cube map, or cube map array texture. 
		/// - GL_INVALID_VALUE is generated if texture is not zero and level is not a supported texture level for texture, as 
		///   describedabove. 
		/// - GL_INVALID_VALUE is generated if texture is not zero and layer is larger than the value of GL_MAX_3D_TEXTURE_SIZE minus 
		///   one(for three-dimensional texture objects), or larger than the value of GL_MAX_ARRAY_TEXTURE_LAYERS minus one (for array 
		///   textureobjects). 
		/// - GL_INVALID_VALUE is generated if texture is not zero and layer is negative. 
		/// - GL_INVALID_OPERATION is generated by if texture is a buffer texture. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		/// <seealso cref="Gl.FramebufferTextureFace"/>
		public static void NamedFramebufferTextureLayer(UInt32 framebuffer, int attachment, UInt32 texture, Int32 level, Int32 layer)
		{
			Debug.Assert(Delegates.pglNamedFramebufferTextureLayer != null, "pglNamedFramebufferTextureLayer not implemented");
			Delegates.pglNamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer);
			CallLog("glNamedFramebufferTextureLayer({0}, {1}, {2}, {3}, {4})", framebuffer, attachment, texture, level, layer);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify which color buffers are to be drawn into
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for glNamedFramebufferDrawBuffer function. Must be zero or the name of a 
		/// framebufferobject. 
		/// </param>
		/// <param name="buf">
		/// For default framebuffer, the argument specifies up to four color buffers to be drawn into. Symbolic constants GL_NONE, 
		/// GL_FRONT_LEFT,GL_FRONT_RIGHT, GL_BACK_LEFT, GL_BACK_RIGHT, GL_FRONT, GL_BACK, GL_LEFT, GL_RIGHT, and GL_FRONT_AND_BACK 
		/// areaccepted. The initial value is GL_FRONT for single-buffered contexts, and GL_BACK for double-buffered contexts. For 
		/// framebufferobjects, GL_COLOR_ATTACHMENT$m$ and GL_NONE enums are accepted, where $m$ is a value between 0 and 
		/// GL_MAX_COLOR_ATTACHMENTS.
		/// </param>
		/// <remarks>
		/// When colors are written to the frame buffer, they are written into the color buffers specified by glDrawBuffer. One of 
		/// thefollowing values can be used for default framebuffer: 
		/// If more than one color buffer is selected for drawing, then blending or logical operations are computed and applied 
		/// independentlyfor each color buffer and can produce different results in each buffer. 
		/// Monoscopic contexts include only left buffers, and stereoscopic contexts include both left and right buffers. Likewise, 
		/// single-bufferedcontexts include only front buffers, and double-buffered contexts include both front and back buffers. 
		/// Thecontext is selected at GL initialization. 
		/// For framebuffer objects, GL_COLOR_ATTACHMENT$m$ and GL_NONE enums are accepted, where $m$ is a value between 0 and 
		/// GL_MAX_COLOR_ATTACHMENTS.glDrawBuffer will set the draw buffer for fragment colors other than zero to GL_NONE. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION error is generated by glNamedFramebufferDrawBuffer if framebuffer is not zero or the name of an 
		///   existingframebuffer object. 
		/// - GL_INVALID_ENUM is generated if buf is not an accepted value. 
		/// - GL_INVALID_OPERATION is generated if the default framebuffer is affected and none of the buffers indicated by buf 
		///   exists.
		/// - GL_INVALID_OPERATION is generated if a framebuffer object is affected and buf is not equal to GL_NONE or 
		///   GL_COLOR_ATTACHMENT$m$,where $m$ is a value between 0 and GL_MAX_COLOR_ATTACHMENTS. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_DRAW_BUFFER 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DrawBuffers"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		public static void NamedFramebufferDrawBuffer(UInt32 framebuffer, int buf)
		{
			Debug.Assert(Delegates.pglNamedFramebufferDrawBuffer != null, "pglNamedFramebufferDrawBuffer not implemented");
			Delegates.pglNamedFramebufferDrawBuffer(framebuffer, buf);
			CallLog("glNamedFramebufferDrawBuffer({0}, {1})", framebuffer, buf);
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies a list of color buffers to be drawn into
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for glNamedFramebufferDrawBuffers. 
		/// </param>
		/// <param name="n">
		/// Specifies the number of buffers in bufs. 
		/// </param>
		/// <param name="bufs">
		/// Points to an array of symbolic constants specifying the buffers into which fragment colors or data values will be 
		/// written.
		/// </param>
		/// <remarks>
		/// glDrawBuffers and glNamedFramebufferDrawBuffers define an array of buffers into which outputs from the fragment shader 
		/// datawill be written. If a fragment shader writes a value to one or more user defined output variables, then the value of 
		/// eachvariable will be written into the buffer specified at a location within bufs corresponding to the location assigned 
		/// tothat user defined output. The draw buffer used for user defined outputs assigned to locations greater than or equal to 
		/// nis implicitly set to GL_NONE and any data written to such an output is discarded. 
		/// For glDrawBuffers, the framebuffer object that is bound to the GL_DRAW_FRAMEBUFFER binding will be used. For 
		/// glNamedFramebufferDrawBuffers,framebuffer is the name of the framebuffer object. If framebuffer is zero, then the 
		/// defaultframebuffer is affected. 
		/// The symbolic constants contained in bufs may be any of the following: 
		/// Except for GL_NONE, the preceding symbolic constants may not appear more than once in bufs. The maximum number of draw 
		/// bufferssupported is implementation dependent and can be queried by calling glGet with the argument GL_MAX_DRAW_BUFFERS. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION error is generated by glNamedFramebufferDrawBuffers if framebuffer is not zero or the name of an 
		///   existingframebuffer object. 
		/// - GL_INVALID_ENUM is generated if one of the values in bufs is not an accepted value. 
		/// - GL_INVALID_ENUM is generated if the API call refers to the default framebuffer and one or more of the values in bufs is 
		///   oneof the GL_COLOR_ATTACHMENTn tokens. 
		/// - GL_INVALID_ENUM is generated if the API call refers to a framebuffer object and one or more of the values in bufs is 
		///   anythingother than GL_NONE or one of the GL_COLOR_ATTACHMENTn tokens. 
		/// - GL_INVALID_ENUM is generated if n is less than 0. 
		/// - GL_INVALID_OPERATION is generated if a symbolic constant other than GL_NONE appears more than once in bufs. 
		/// - GL_INVALID_OPERATION is generated if any of the entries in bufs (other than GL_NONE ) indicates a color buffer that does 
		///   notexist in the current GL context. 
		/// - GL_INVALID_OPERATION is generated if any value in bufs is GL_BACK, and n is not one. 
		/// - GL_INVALID_VALUE is generated if n is greater than GL_MAX_DRAW_BUFFERS. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_DRAW_BUFFERS 
		/// - glGet with argument GL_DRAW_BUFFERi where i indicates the number of the draw buffer whose value is to be queried 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DrawBuffers"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		public static void NamedFramebufferDrawBuffers(UInt32 framebuffer, Int32 n, int[] bufs)
		{
			unsafe {
				fixed (int* p_bufs = bufs)
				{
					Debug.Assert(Delegates.pglNamedFramebufferDrawBuffers != null, "pglNamedFramebufferDrawBuffers not implemented");
					Delegates.pglNamedFramebufferDrawBuffers(framebuffer, n, p_bufs);
					CallLog("glNamedFramebufferDrawBuffers({0}, {1}, {2})", framebuffer, n, bufs);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// select a color buffer source for pixels
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for glNamedFramebufferReadBuffer function. 
		/// </param>
		/// <param name="src">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <remarks>
		/// glReadBuffer specifies a color buffer as the source for subsequent glReadPixels, glCopyTexImage1D, glCopyTexImage2D, 
		/// glCopyTexSubImage1D,glCopyTexSubImage2D, and glCopyTexSubImage3D commands. mode accepts one of twelve or more predefined 
		/// values.In a fully configured system, GL_FRONT, GL_LEFT, and GL_FRONT_LEFT all name the front left buffer, GL_FRONT_RIGHT 
		/// andGL_RIGHT name the front right buffer, and GL_BACK_LEFT and GL_BACK name the back left buffer. Further more, the 
		/// constantsGL_COLOR_ATTACHMENTi may be used to indicate the ith color attachment where i ranges from zero to the value of 
		/// GL_MAX_COLOR_ATTACHMENTSminus one. 
		/// Nonstereo double-buffered configurations have only a front left and a back left buffer. Single-buffered configurations 
		/// havea front left and a front right buffer if stereo, and only a front left buffer if nonstereo. It is an error to 
		/// specifya nonexistent buffer to glReadBuffer. 
		/// mode is initially GL_FRONT in single-buffered configurations and GL_BACK in double-buffered configurations. 
		/// For glReadBuffer, the target framebuffer object is that bound to GL_READ_FRAMEBUFFER. For glNamedFramebufferReadBuffer, 
		/// framebuffermust either be zero or the name of the target framebuffer object. If framebuffer is zero, then the default 
		/// readframebuffer is affected. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not one of the twelve (or more) accepted values. 
		/// - GL_INVALID_OPERATION is generated if mode specifies a buffer that does not exist. 
		/// - GL_INVALID_OPERATION is generated by glNamedFramebufferReadBuffer if framebuffer is not zero or the name of an existing 
		///   framebufferobject. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_READ_BUFFER 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		public static void NamedFramebufferReadBuffer(UInt32 framebuffer, int src)
		{
			Debug.Assert(Delegates.pglNamedFramebufferReadBuffer != null, "pglNamedFramebufferReadBuffer not implemented");
			Delegates.pglNamedFramebufferReadBuffer(framebuffer, src);
			CallLog("glNamedFramebufferReadBuffer({0}, {1})", framebuffer, src);
			DebugCheckErrors();
		}

		/// <summary>
		/// invalidate the content of some or all of a framebuffer's attachments
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for glInvalidateNamedFramebufferData. 
		/// </param>
		/// <param name="numAttachments">
		/// Specifies the number of entries in the attachments array. 
		/// </param>
		/// <param name="attachments">
		/// Specifies a pointer to an array identifying the attachments to be invalidated. 
		/// </param>
		/// <remarks>
		/// glInvalidateFramebuffer and glInvalidateNamedFramebufferData invalidate the entire contents of a specified set of 
		/// attachmentsof a framebuffer. 
		/// For glInvalidateFramebuffer, the framebuffer object is that bound to target. target must be GL_FRAMEBUFFER, 
		/// GL_READ_FRAMEBUFFERor GL_DRAW_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. Default framebuffers may 
		/// alsobe invalidated if bound to target. 
		/// For glInvalidateNamedFramebufferData, framebuffer is the name of the framebuffer object. If framebuffer is zero, the 
		/// defaultdraw framebuffer is affected. 
		/// The set of attachments whose contents are to be invalidated are specified in the attachments array, which contains 
		/// numAttachmentselements. 
		/// If the specified framebuffer is a framebuffer object, each element of attachments must be one of GL_DEPTH_ATTACHMENT, 
		/// GL_STENCIL_ATTACHMENTGL_DEPTH_STENCIL_ATTACHMENT,or GL_COLOR_ATTACHMENTi, where i is between zero and the value of 
		/// GL_MAX_FRAMEBUFFER_ATTACHMENTSminus one. 
		/// If the specified framebuffer is a default framebuffer, each element of attachments must be one of GL_FRONT_LEFT, 
		/// GL_FRONT_RIGHT,GL_BACK_LEFT, GL_BACK_RIGHT, GL_AUXi, GL_ACCUM, GL_COLOR, GL_DEPTH, or GL_STENCIL. GL_COLOR, is treated 
		/// asGL_BACK_LEFT for a double-buffered context and GL_FRONT_LEFT for a single-buffered context. The other attachments 
		/// identifythe corresponding specific buffer. 
		/// The entire contents of each specified attachment become undefined after execution of glInvalidateFramebuffer or 
		/// glInvalidateNamedFramebufferData.
		/// If the framebuffer object is not complete, glInvalidateFramebuffer and glInvalidateNamedFramebufferData may be ignored. 
		/// Thisis not an error. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glInvalidateFramebuffer if target is not one of the accepted framebuffer targets. 
		/// - GL_INVALID_OPERATION is generated by glInvalidateNamedFramebufferData if framebuffer is not zero or the name of an 
		///   existingframebuffer object. 
		/// - GL_INVALID_VALUE is generated if numAttachments is negative. 
		/// - GL_INVALID_ENUM is generated if any element of attachments is not one of the accepted framebuffer attachment points, as 
		///   describedabove. 
		/// - GL_INVALID_OPERATION is generated if element of attachments is GL_COLOR_ATTACHMENTm where m is greater than or equal to 
		///   thevalue of GL_MAX_COLOR_ATTACHMENTS. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_COLOR_ATTACHMENTS 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.InvalidateTexSubImage"/>
		/// <seealso cref="Gl.InvalidateTexImage"/>
		/// <seealso cref="Gl.InvalidateBufferSubData"/>
		/// <seealso cref="Gl.InvalidateBufferData"/>
		/// <seealso cref="Gl.InvalidateSubFramebuffer"/>
		public static void InvalidateNamedFramebufferData(UInt32 framebuffer, Int32 numAttachments, int[] attachments)
		{
			unsafe {
				fixed (int* p_attachments = attachments)
				{
					Debug.Assert(Delegates.pglInvalidateNamedFramebufferData != null, "pglInvalidateNamedFramebufferData not implemented");
					Delegates.pglInvalidateNamedFramebufferData(framebuffer, numAttachments, p_attachments);
					CallLog("glInvalidateNamedFramebufferData({0}, {1}, {2})", framebuffer, numAttachments, attachments);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// invalidate the content of a region of some or all of a framebuffer's attachments
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for glInvalidateNamedFramebufferSubData. 
		/// </param>
		/// <param name="numAttachments">
		/// Specifies the number of entries in the attachments array. 
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
		/// <remarks>
		/// glInvalidateSubFramebuffer and glInvalidateNamedFramebufferSubData invalidate the contents of a specified region of a 
		/// specifiedset of attachments of a framebuffer. 
		/// For glInvalidateSubFramebuffer, the framebuffer object is that bound to target, which must be one of GL_FRAMEBUFFER, 
		/// GL_READ_FRAMEBUFFERor GL_DRAW_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. Default framebuffers may 
		/// alsobe invalidated if bound to target. 
		/// For glInvalidateNamedFramebufferSubData, framebuffer is the name of the framebuffer object. If framebuffer is zero, the 
		/// defaultdraw framebuffer is affected. 
		/// The set of attachments of which a region is to be invalidated are specified in the attachments array, which contains 
		/// numAttachmentselements. 
		/// If the specified framebuffer is a framebuffer object, each element of attachments must be one of GL_DEPTH_ATTACHMENT, 
		/// GL_STENCIL_ATTACHMENTGL_DEPTH_STENCIL_ATTACHMENT,or GL_COLOR_ATTACHMENTi, where i is between zero and the value of 
		/// GL_MAX_FRAMEBUFFER_ATTACHMENTSminus one. 
		/// If the specified framebuffer is a default framebuffer, each element of attachments must be one of GL_FRONT_LEFT, 
		/// GL_FRONT_RIGHT,GL_BACK_LEFT, GL_BACK_RIGHT, GL_AUXi, GL_ACCUM, GL_COLOR, GL_DEPTH, or GL_STENCIL. GL_COLOR, is treated 
		/// asGL_BACK_LEFT for a double-buffered context and GL_FRONT_LEFT for a single-buffered context. The other attachments 
		/// identifythe corresponding specific buffer. 
		/// The contents of the specified region of each specified attachment become undefined after execution of 
		/// glInvalidateSubFramebufferor glInvalidateNamedFramebufferSubData. The region to be invalidated is specified by x, y, 
		/// widthand height where x and y give the offset from the origin (with lower-left corner at $(0,0)$) and width and height 
		/// arethe width and height, respectively, of the region. Any pixels lying outside of the window allocated to the current GL 
		/// context(for the default framebuffer), or outside of the attachments of the framebuffer object, are ignored. If the 
		/// framebufferobject is not complete, these commands may be ignored. 
		/// If the framebuffer object is not complete, glInvalidateSubFramebuffer and glInvalidateNamedFramebufferSubData may be 
		/// ignored.This is not an error. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM by glInvalidateSubFramebuffer if target is not one of the accepted framebuffer targets. 
		/// - GL_INVALID_OPERATION by glInvalidateNamedFramebufferSubData if framebuffer is not zero of the name of an existing 
		///   framebufferobject. 
		/// - GL_INVALID_VALUE is generated if numAttachments, width or height is negative. 
		/// - GL_INVALID_ENUM is generated if any element of attachments is not one of the accepted framebuffer attachment points, as 
		///   describedabove. 
		/// - GL_INVALID_OPERATION is generated if element of attachments is GL_COLOR_ATTACHMENTm where m is greater than or equal to 
		///   thevalue of GL_MAX_COLOR_ATTACHMENTS. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_COLOR_ATTACHMENTS 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.InvalidateTexSubImage"/>
		/// <seealso cref="Gl.InvalidateTexImage"/>
		/// <seealso cref="Gl.InvalidateBufferSubData"/>
		/// <seealso cref="Gl.InvalidateBufferData"/>
		/// <seealso cref="Gl.InvalidateFramebuffer"/>
		public static void InvalidateNamedFramebufferSubData(UInt32 framebuffer, Int32 numAttachments, int[] attachments, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			unsafe {
				fixed (int* p_attachments = attachments)
				{
					Debug.Assert(Delegates.pglInvalidateNamedFramebufferSubData != null, "pglInvalidateNamedFramebufferSubData not implemented");
					Delegates.pglInvalidateNamedFramebufferSubData(framebuffer, numAttachments, p_attachments, x, y, width, height);
					CallLog("glInvalidateNamedFramebufferSubData({0}, {1}, {2}, {3}, {4}, {5}, {6})", framebuffer, numAttachments, attachments, x, y, width, height);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// clear individual buffers of a framebuffer
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for glClearNamedFramebuffer*. 
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
		/// <remarks>
		/// These commands clear a specified buffer of a framebuffer to specified value(s). For glClearBuffer*, the framebuffer is 
		/// thecurrently bound draw framebuffer object. For glClearNamedFramebuffer*, framebuffer is zero, indicating the default 
		/// drawframebuffer, or the name of a framebuffer object. 
		/// buffer and drawbuffer identify the buffer to clear. 
		/// If buffer is GL_COLOR, a particular draw buffer GL_DRAW_BUFFERi is specified by passing i as drawbuffer, and value 
		/// pointsto a four-element vector specifying the R, G, B and A color to clear that draw buffer to. If the value of 
		/// GL_DRAW_BUFFERiis GL_NONE, the command has no effect. Otherwise, the value of GL_DRAW_BUFFERi identifies one or more 
		/// colorbuffers, each of which is cleared to the same value. Clamping and type conversion for fixed-point color buffers are 
		/// performedin the same fashion as for glClearColor. The *fv, *iv and *uiv forms of these commands should be used to clear 
		/// fixed-and floating-point, signed integer, and unsigned integer color buffers respectively. 
		/// If buffer is GL_DEPTH, drawbuffer must be zero, and value points to a single value to clear the depth buffer to. 
		/// Clampingand type conversion for fixed-point depth buffers are performed in the same fashion as for glClearDepth. Only 
		/// the*fv forms of these commands should be used to clear depth buffers; other forms do not accept a buffer of GL_DEPTH. 
		/// If buffer is GL_STENCIL, drawbuffer must be zero, and value points to a single value to clear the stencil buffer to. 
		/// Maskingis performed in the same fashion as for glClearStencil. Only the *iv forms of these commands should be used to 
		/// clearstencil buffers; be used to clear stencil buffers; other forms do not accept a buffer of GL_STENCIL. 
		/// glClearBufferfi and glClearNamedFramebufferfi are used to clear the depth and stencil buffers simultaneously. buffer 
		/// mustbe GL_DEPTH_STENCIL and drawbuffer must be zero. depth and stencil are the values to clear the depth and stencil 
		/// buffersto, respectively. Clamping and type conversion of depth for fixed-point depth buffers are performed in the same 
		/// fashionas for glClearDepth. Masking of stencil for stencil buffers is performed in the same fashion as for 
		/// glClearStencil.These commands are equivalent to clearing the depth and stencil buffers separately, but may be faster 
		/// whena buffer of internal format GL_DEPTH_STENCIL is being cleared. The same per-fragment and masking operations defined 
		/// forglClear are applied. 
		/// The result of these commands is undefined if no conversion between the type of the specified value and the type of the 
		/// bufferbeing cleared is defined (for example, if glClearBufferiv is called for a fixed- or floating-point buffer, or if 
		/// glClearBufferfvis called for a signed or unsigned integer buffer). This is not an error. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glClearNamedFramebuffer* if framebuffer is not zero or the name of an existing 
		///   framebufferobject. 
		/// - GL_INVALID_ENUM is generated by glClearBufferiv and glClearNamedFramebufferivbuffer is not GL_COLOR or GL_STENCIL. 
		/// - GL_INVALID_ENUM is generated by glClearBufferuiv and glClearNamedFramebufferuivbuffer is not GL_COLOR. 
		/// - GL_INVALID_ENUM is generated by glClearBufferfv and glClearNamedFramebufferfvbuffer is not GL_COLOR or GL_DEPTH. 
		/// - GL_INVALID_ENUM is generated by glClearBufferfi and glClearNamedFramebufferfibuffer is not GL_DEPTH_STENCIL. 
		/// - GL_INVALID_VALUE is generated if buffer is GL_COLORdrawbuffer is negative, or greater than the value of 
		///   GL_MAX_DRAW_BUFFERSminus one. 
		/// - GL_INVALID_VALUE is generated if buffer is GL_DEPTH, GL_STENCIL or GL_DEPTH_STENCIL and drawbuffer is not zero. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ClearColor"/>
		/// <seealso cref="Gl.ClearDepth"/>
		/// <seealso cref="Gl.ClearStencil"/>
		/// <seealso cref="Gl.Clear"/>
		public static void ClearNamedFramebuffer(UInt32 framebuffer, int buffer, Int32 drawbuffer, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglClearNamedFramebufferiv != null, "pglClearNamedFramebufferiv not implemented");
					Delegates.pglClearNamedFramebufferiv(framebuffer, buffer, drawbuffer, p_value);
					CallLog("glClearNamedFramebufferiv({0}, {1}, {2}, {3})", framebuffer, buffer, drawbuffer, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// clear individual buffers of a framebuffer
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for glClearNamedFramebuffer*. 
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
		/// <remarks>
		/// These commands clear a specified buffer of a framebuffer to specified value(s). For glClearBuffer*, the framebuffer is 
		/// thecurrently bound draw framebuffer object. For glClearNamedFramebuffer*, framebuffer is zero, indicating the default 
		/// drawframebuffer, or the name of a framebuffer object. 
		/// buffer and drawbuffer identify the buffer to clear. 
		/// If buffer is GL_COLOR, a particular draw buffer GL_DRAW_BUFFERi is specified by passing i as drawbuffer, and value 
		/// pointsto a four-element vector specifying the R, G, B and A color to clear that draw buffer to. If the value of 
		/// GL_DRAW_BUFFERiis GL_NONE, the command has no effect. Otherwise, the value of GL_DRAW_BUFFERi identifies one or more 
		/// colorbuffers, each of which is cleared to the same value. Clamping and type conversion for fixed-point color buffers are 
		/// performedin the same fashion as for glClearColor. The *fv, *iv and *uiv forms of these commands should be used to clear 
		/// fixed-and floating-point, signed integer, and unsigned integer color buffers respectively. 
		/// If buffer is GL_DEPTH, drawbuffer must be zero, and value points to a single value to clear the depth buffer to. 
		/// Clampingand type conversion for fixed-point depth buffers are performed in the same fashion as for glClearDepth. Only 
		/// the*fv forms of these commands should be used to clear depth buffers; other forms do not accept a buffer of GL_DEPTH. 
		/// If buffer is GL_STENCIL, drawbuffer must be zero, and value points to a single value to clear the stencil buffer to. 
		/// Maskingis performed in the same fashion as for glClearStencil. Only the *iv forms of these commands should be used to 
		/// clearstencil buffers; be used to clear stencil buffers; other forms do not accept a buffer of GL_STENCIL. 
		/// glClearBufferfi and glClearNamedFramebufferfi are used to clear the depth and stencil buffers simultaneously. buffer 
		/// mustbe GL_DEPTH_STENCIL and drawbuffer must be zero. depth and stencil are the values to clear the depth and stencil 
		/// buffersto, respectively. Clamping and type conversion of depth for fixed-point depth buffers are performed in the same 
		/// fashionas for glClearDepth. Masking of stencil for stencil buffers is performed in the same fashion as for 
		/// glClearStencil.These commands are equivalent to clearing the depth and stencil buffers separately, but may be faster 
		/// whena buffer of internal format GL_DEPTH_STENCIL is being cleared. The same per-fragment and masking operations defined 
		/// forglClear are applied. 
		/// The result of these commands is undefined if no conversion between the type of the specified value and the type of the 
		/// bufferbeing cleared is defined (for example, if glClearBufferiv is called for a fixed- or floating-point buffer, or if 
		/// glClearBufferfvis called for a signed or unsigned integer buffer). This is not an error. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glClearNamedFramebuffer* if framebuffer is not zero or the name of an existing 
		///   framebufferobject. 
		/// - GL_INVALID_ENUM is generated by glClearBufferiv and glClearNamedFramebufferivbuffer is not GL_COLOR or GL_STENCIL. 
		/// - GL_INVALID_ENUM is generated by glClearBufferuiv and glClearNamedFramebufferuivbuffer is not GL_COLOR. 
		/// - GL_INVALID_ENUM is generated by glClearBufferfv and glClearNamedFramebufferfvbuffer is not GL_COLOR or GL_DEPTH. 
		/// - GL_INVALID_ENUM is generated by glClearBufferfi and glClearNamedFramebufferfibuffer is not GL_DEPTH_STENCIL. 
		/// - GL_INVALID_VALUE is generated if buffer is GL_COLORdrawbuffer is negative, or greater than the value of 
		///   GL_MAX_DRAW_BUFFERSminus one. 
		/// - GL_INVALID_VALUE is generated if buffer is GL_DEPTH, GL_STENCIL or GL_DEPTH_STENCIL and drawbuffer is not zero. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ClearColor"/>
		/// <seealso cref="Gl.ClearDepth"/>
		/// <seealso cref="Gl.ClearStencil"/>
		/// <seealso cref="Gl.Clear"/>
		public static void ClearNamedFramebuffer(UInt32 framebuffer, int buffer, Int32 drawbuffer, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglClearNamedFramebufferuiv != null, "pglClearNamedFramebufferuiv not implemented");
					Delegates.pglClearNamedFramebufferuiv(framebuffer, buffer, drawbuffer, p_value);
					CallLog("glClearNamedFramebufferuiv({0}, {1}, {2}, {3})", framebuffer, buffer, drawbuffer, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// clear individual buffers of a framebuffer
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for glClearNamedFramebuffer*. 
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
		/// <remarks>
		/// These commands clear a specified buffer of a framebuffer to specified value(s). For glClearBuffer*, the framebuffer is 
		/// thecurrently bound draw framebuffer object. For glClearNamedFramebuffer*, framebuffer is zero, indicating the default 
		/// drawframebuffer, or the name of a framebuffer object. 
		/// buffer and drawbuffer identify the buffer to clear. 
		/// If buffer is GL_COLOR, a particular draw buffer GL_DRAW_BUFFERi is specified by passing i as drawbuffer, and value 
		/// pointsto a four-element vector specifying the R, G, B and A color to clear that draw buffer to. If the value of 
		/// GL_DRAW_BUFFERiis GL_NONE, the command has no effect. Otherwise, the value of GL_DRAW_BUFFERi identifies one or more 
		/// colorbuffers, each of which is cleared to the same value. Clamping and type conversion for fixed-point color buffers are 
		/// performedin the same fashion as for glClearColor. The *fv, *iv and *uiv forms of these commands should be used to clear 
		/// fixed-and floating-point, signed integer, and unsigned integer color buffers respectively. 
		/// If buffer is GL_DEPTH, drawbuffer must be zero, and value points to a single value to clear the depth buffer to. 
		/// Clampingand type conversion for fixed-point depth buffers are performed in the same fashion as for glClearDepth. Only 
		/// the*fv forms of these commands should be used to clear depth buffers; other forms do not accept a buffer of GL_DEPTH. 
		/// If buffer is GL_STENCIL, drawbuffer must be zero, and value points to a single value to clear the stencil buffer to. 
		/// Maskingis performed in the same fashion as for glClearStencil. Only the *iv forms of these commands should be used to 
		/// clearstencil buffers; be used to clear stencil buffers; other forms do not accept a buffer of GL_STENCIL. 
		/// glClearBufferfi and glClearNamedFramebufferfi are used to clear the depth and stencil buffers simultaneously. buffer 
		/// mustbe GL_DEPTH_STENCIL and drawbuffer must be zero. depth and stencil are the values to clear the depth and stencil 
		/// buffersto, respectively. Clamping and type conversion of depth for fixed-point depth buffers are performed in the same 
		/// fashionas for glClearDepth. Masking of stencil for stencil buffers is performed in the same fashion as for 
		/// glClearStencil.These commands are equivalent to clearing the depth and stencil buffers separately, but may be faster 
		/// whena buffer of internal format GL_DEPTH_STENCIL is being cleared. The same per-fragment and masking operations defined 
		/// forglClear are applied. 
		/// The result of these commands is undefined if no conversion between the type of the specified value and the type of the 
		/// bufferbeing cleared is defined (for example, if glClearBufferiv is called for a fixed- or floating-point buffer, or if 
		/// glClearBufferfvis called for a signed or unsigned integer buffer). This is not an error. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glClearNamedFramebuffer* if framebuffer is not zero or the name of an existing 
		///   framebufferobject. 
		/// - GL_INVALID_ENUM is generated by glClearBufferiv and glClearNamedFramebufferivbuffer is not GL_COLOR or GL_STENCIL. 
		/// - GL_INVALID_ENUM is generated by glClearBufferuiv and glClearNamedFramebufferuivbuffer is not GL_COLOR. 
		/// - GL_INVALID_ENUM is generated by glClearBufferfv and glClearNamedFramebufferfvbuffer is not GL_COLOR or GL_DEPTH. 
		/// - GL_INVALID_ENUM is generated by glClearBufferfi and glClearNamedFramebufferfibuffer is not GL_DEPTH_STENCIL. 
		/// - GL_INVALID_VALUE is generated if buffer is GL_COLORdrawbuffer is negative, or greater than the value of 
		///   GL_MAX_DRAW_BUFFERSminus one. 
		/// - GL_INVALID_VALUE is generated if buffer is GL_DEPTH, GL_STENCIL or GL_DEPTH_STENCIL and drawbuffer is not zero. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ClearColor"/>
		/// <seealso cref="Gl.ClearDepth"/>
		/// <seealso cref="Gl.ClearStencil"/>
		/// <seealso cref="Gl.Clear"/>
		public static void ClearNamedFramebuffer(UInt32 framebuffer, int buffer, Int32 drawbuffer, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglClearNamedFramebufferfv != null, "pglClearNamedFramebufferfv not implemented");
					Delegates.pglClearNamedFramebufferfv(framebuffer, buffer, drawbuffer, p_value);
					CallLog("glClearNamedFramebufferfv({0}, {1}, {2}, {3})", framebuffer, buffer, drawbuffer, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// clear individual buffers of a framebuffer
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for glClearNamedFramebuffer*. 
		/// </param>
		/// <param name="buffer">
		/// Specify the buffer to clear. 
		/// </param>
		/// <param name="depth">
		/// The value to clear the depth buffer to. 
		/// </param>
		/// <param name="stencil">
		/// The value to clear the stencil buffer to. 
		/// </param>
		/// <remarks>
		/// These commands clear a specified buffer of a framebuffer to specified value(s). For glClearBuffer*, the framebuffer is 
		/// thecurrently bound draw framebuffer object. For glClearNamedFramebuffer*, framebuffer is zero, indicating the default 
		/// drawframebuffer, or the name of a framebuffer object. 
		/// buffer and drawbuffer identify the buffer to clear. 
		/// If buffer is GL_COLOR, a particular draw buffer GL_DRAW_BUFFERi is specified by passing i as drawbuffer, and value 
		/// pointsto a four-element vector specifying the R, G, B and A color to clear that draw buffer to. If the value of 
		/// GL_DRAW_BUFFERiis GL_NONE, the command has no effect. Otherwise, the value of GL_DRAW_BUFFERi identifies one or more 
		/// colorbuffers, each of which is cleared to the same value. Clamping and type conversion for fixed-point color buffers are 
		/// performedin the same fashion as for glClearColor. The *fv, *iv and *uiv forms of these commands should be used to clear 
		/// fixed-and floating-point, signed integer, and unsigned integer color buffers respectively. 
		/// If buffer is GL_DEPTH, drawbuffer must be zero, and value points to a single value to clear the depth buffer to. 
		/// Clampingand type conversion for fixed-point depth buffers are performed in the same fashion as for glClearDepth. Only 
		/// the*fv forms of these commands should be used to clear depth buffers; other forms do not accept a buffer of GL_DEPTH. 
		/// If buffer is GL_STENCIL, drawbuffer must be zero, and value points to a single value to clear the stencil buffer to. 
		/// Maskingis performed in the same fashion as for glClearStencil. Only the *iv forms of these commands should be used to 
		/// clearstencil buffers; be used to clear stencil buffers; other forms do not accept a buffer of GL_STENCIL. 
		/// glClearBufferfi and glClearNamedFramebufferfi are used to clear the depth and stencil buffers simultaneously. buffer 
		/// mustbe GL_DEPTH_STENCIL and drawbuffer must be zero. depth and stencil are the values to clear the depth and stencil 
		/// buffersto, respectively. Clamping and type conversion of depth for fixed-point depth buffers are performed in the same 
		/// fashionas for glClearDepth. Masking of stencil for stencil buffers is performed in the same fashion as for 
		/// glClearStencil.These commands are equivalent to clearing the depth and stencil buffers separately, but may be faster 
		/// whena buffer of internal format GL_DEPTH_STENCIL is being cleared. The same per-fragment and masking operations defined 
		/// forglClear are applied. 
		/// The result of these commands is undefined if no conversion between the type of the specified value and the type of the 
		/// bufferbeing cleared is defined (for example, if glClearBufferiv is called for a fixed- or floating-point buffer, or if 
		/// glClearBufferfvis called for a signed or unsigned integer buffer). This is not an error. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glClearNamedFramebuffer* if framebuffer is not zero or the name of an existing 
		///   framebufferobject. 
		/// - GL_INVALID_ENUM is generated by glClearBufferiv and glClearNamedFramebufferivbuffer is not GL_COLOR or GL_STENCIL. 
		/// - GL_INVALID_ENUM is generated by glClearBufferuiv and glClearNamedFramebufferuivbuffer is not GL_COLOR. 
		/// - GL_INVALID_ENUM is generated by glClearBufferfv and glClearNamedFramebufferfvbuffer is not GL_COLOR or GL_DEPTH. 
		/// - GL_INVALID_ENUM is generated by glClearBufferfi and glClearNamedFramebufferfibuffer is not GL_DEPTH_STENCIL. 
		/// - GL_INVALID_VALUE is generated if buffer is GL_COLORdrawbuffer is negative, or greater than the value of 
		///   GL_MAX_DRAW_BUFFERSminus one. 
		/// - GL_INVALID_VALUE is generated if buffer is GL_DEPTH, GL_STENCIL or GL_DEPTH_STENCIL and drawbuffer is not zero. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ClearColor"/>
		/// <seealso cref="Gl.ClearDepth"/>
		/// <seealso cref="Gl.ClearStencil"/>
		/// <seealso cref="Gl.Clear"/>
		public static void ClearNamedFramebuffer(UInt32 framebuffer, int buffer, float depth, Int32 stencil)
		{
			Debug.Assert(Delegates.pglClearNamedFramebufferfi != null, "pglClearNamedFramebufferfi not implemented");
			Delegates.pglClearNamedFramebufferfi(framebuffer, buffer, depth, stencil);
			CallLog("glClearNamedFramebufferfi({0}, {1}, {2}, {3})", framebuffer, buffer, depth, stencil);
			DebugCheckErrors();
		}

		/// <summary>
		/// copy a block of pixels from one framebuffer object to another
		/// </summary>
		/// <param name="readFramebuffer">
		/// Specifies the name of the source framebuffer object for glBlitNamedFramebuffer. 
		/// </param>
		/// <param name="drawFramebuffer">
		/// Specifies the name of the destination framebuffer object for glBlitNamedFramebuffer. 
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
		/// The bitwise OR of the flags indicating which buffers are to be copied. The allowed flags are GL_COLOR_BUFFER_BIT, 
		/// GL_DEPTH_BUFFER_BITand GL_STENCIL_BUFFER_BIT. 
		/// </param>
		/// <param name="filter">
		/// Specifies the interpolation to be applied if the image is stretched. Must be GL_NEAREST or GL_LINEAR. 
		/// </param>
		/// <remarks>
		/// glBlitFramebuffer and glBlitNamedFramebuffer transfer a rectangle of pixel values from one region of a read framebuffer 
		/// toanother region of a draw framebuffer. 
		/// For glBlitFramebuffer, the read and draw framebuffers are those bound to the GL_READ_FRAMEBUFFER and GL_DRAW_FRAMEBUFFER 
		/// targetsrespectively. 
		/// For glBlitNamedFramebuffer, readFramebuffer and drawFramebuffer are the names of the read read and draw framebuffer 
		/// objectsrespectively. If readFramebuffer or drawFramebuffer is zero, then the default read or draw framebuffer 
		/// respectivelyis used. 
		/// mask is the bitwise OR of a number of values indicating which buffers are to be copied. The values are 
		/// GL_COLOR_BUFFER_BIT,GL_DEPTH_BUFFER_BIT, and GL_STENCIL_BUFFER_BIT. The pixels corresponding to these buffers are copied 
		/// fromthe source rectangle bounded by the locations (srcX0, srcY0) and (srcX1, srcY1) to the destination rectangle bounded 
		/// bythe locations (dstX0, dstY0) and (dstX1, dstY1). The lower bounds of the rectangle are inclusive, while the upper 
		/// boundsare exclusive. 
		/// The actual region taken from the read framebuffer is limited to the intersection of the source buffers being 
		/// transferred,which may include the color buffer selected by the read buffer, the depth buffer, and/or the stencil buffer 
		/// dependingon mask. The actual region written to the draw framebuffer is limited to the intersection of the destination 
		/// buffersbeing written, which may include multiple draw buffers, the depth buffer, and/or the stencil buffer depending on 
		/// mask.Whether or not the source or destination regions are altered due to these limits, the scaling and offset applied to 
		/// pixelsbeing transferred is performed as though no such limits were present. 
		/// If the sizes of the source and destination rectangles are not equal, filter specifies the interpolation method that will 
		/// beapplied to resize the source image , and must be GL_NEAREST or GL_LINEAR. GL_LINEAR is only a valid interpolation 
		/// methodfor the color buffer. If filter is not GL_NEAREST and mask includes GL_DEPTH_BUFFER_BIT or GL_STENCIL_BUFFER_BIT, 
		/// nodata is transferred and a GL_INVALID_OPERATION error is generated. 
		/// If filter is GL_LINEAR and the source rectangle would require sampling outside the bounds of the source framebuffer, 
		/// valuesare read as if the GL_CLAMP_TO_EDGE texture wrapping mode were applied. 
		/// When the color buffer is transferred, values are taken from the read buffer of the specified read framebuffer and 
		/// writtento each of the draw buffers of the specified draw framebuffer. 
		/// If the source and destination rectangles overlap or are the same, and the read and draw buffers are the same, the result 
		/// ofthe operation is undefined. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by BlitNamedFramebuffer if readFramebuffer or drawFramebuffer is not zero or the name 
		///   ofan existing framebuffer object. 
		/// - GL_INVALID_OPERATION is generated if mask contains any of the GL_DEPTH_BUFFER_BIT or GL_STENCIL_BUFFER_BIT and filter is 
		///   notGL_NEAREST. 
		/// - GL_INVALID_OPERATION is generated if mask contains GL_COLOR_BUFFER_BIT and any of the following conditions hold: The 
		///   readbuffer contains fixed-point or floating-point values and any draw buffer contains neither fixed-point nor 
		///   floating-pointvalues. The read buffer contains unsigned integer values and any draw buffer does not contain unsigned 
		///   integervalues. The read buffer contains signed integer values and any draw buffer does not contain signed integer 
		///   values.
		/// - GL_INVALID_OPERATION is generated if mask contains GL_DEPTH_BUFFER_BIT or GL_STENCIL_BUFFER_BIT and the source and 
		///   destinationdepth and stencil formats do not match. 
		/// - GL_INVALID_OPERATION is generated if filter is GL_LINEAR and the read buffer contains integer data. 
		/// - GL_INVALID_OPERATION is generated if the effective value of GL_SAMPLES for the read and draw framebuffers is not 
		///   identical.
		/// - GL_INVALID_OPERATION is generated if the value of GL_SAMPLE_BUFFERS for both read and draw buffers is greater than zero 
		///   andthe dimensions of the source and destination rectangles is not identical. 
		/// - GL_INVALID_FRAMEBUFFER_OPERATION is generated if the specified read and draw framebuffers are not framebuffer complete. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.CheckFramebufferStatus"/>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.DeleteFramebuffers"/>
		public static void BlitNamedFramebuffer(UInt32 readFramebuffer, UInt32 drawFramebuffer, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, uint mask, int filter)
		{
			Debug.Assert(Delegates.pglBlitNamedFramebuffer != null, "pglBlitNamedFramebuffer not implemented");
			Delegates.pglBlitNamedFramebuffer(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			CallLog("glBlitNamedFramebuffer({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11})", readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			DebugCheckErrors();
		}

		/// <summary>
		/// check the completeness status of a framebuffer
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for glCheckNamedFramebufferStatus 
		/// </param>
		/// <param name="target">
		/// Specify the target to which the framebuffer is bound for glCheckFramebufferStatus, and the target against which 
		/// framebuffercompleteness of framebuffer is checked for glCheckNamedFramebufferStatus. 
		/// </param>
		/// <remarks>
		/// glCheckFramebufferStatus and glCheckNamedFramebufferStatus return the completeness status of a framebuffer object when 
		/// treatedas a read or draw framebuffer, depending on the value of target. 
		/// For glCheckFramebufferStatus, the framebuffer checked is that bound to target, which must be GL_DRAW_FRAMEBUFFER, 
		/// GL_READ_FRAMEBUFFERor GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. 
		/// For glCheckNamedFramebufferStatus, framebuffer is zero or the name of the framebuffer object to check. If framebuffer is 
		/// zero,then the status of the default read or draw framebuffer, as determined by target, is returned. 
		/// The return value is GL_FRAMEBUFFER_COMPLETE if the specified framebuffer is complete. Otherwise, the return value is 
		/// determinedas follows: GL_FRAMEBUFFER_UNDEFINED is returned if the specified framebuffer is the default read or draw 
		/// framebuffer,but the default framebuffer does not exist. GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT is returned if any of the 
		/// framebufferattachment points are framebuffer incomplete. GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT is returned if the 
		/// framebufferdoes not have at least one image attached to it. GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER is returned if the 
		/// valueof GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE is GL_NONE for any color attachment point(s) named by GL_DRAW_BUFFERi. 
		/// GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFERis returned if GL_READ_BUFFER is not GL_NONE and the value of 
		/// GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPEis GL_NONE for the color attachment point named by GL_READ_BUFFER. 
		/// GL_FRAMEBUFFER_UNSUPPORTEDis returned if the combination of internal formats of the attached images violates an 
		/// implementation-dependentset of restrictions. GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE is returned if the value of 
		/// GL_RENDERBUFFER_SAMPLESis not the same for all attached renderbuffers; if the value of GL_TEXTURE_SAMPLES is the not 
		/// samefor all attached textures; or, if the attached images are a mix of renderbuffers and textures, the value of 
		/// GL_RENDERBUFFER_SAMPLESdoes not match the value of GL_TEXTURE_SAMPLES. GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE is also 
		/// returnedif the value of GL_TEXTURE_FIXED_SAMPLE_LOCATIONS is not the same for all attached textures; or, if the attached 
		/// imagesare a mix of renderbuffers and textures, the value of GL_TEXTURE_FIXED_SAMPLE_LOCATIONS is not GL_TRUE for all 
		/// attachedtextures. GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS is returned if any framebuffer attachment is layered, and any 
		/// populatedattachment is not layered, or if all populated color attachments are not from textures of the same target. 
		/// Additionally, if an error occurs, zero is returned. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target is not GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER or GL_FRAMEBUFFER. 
		/// - GL_INVALID_OPERATION is generated by glCheckNamedFramebufferStatus if framebuffer is not zero or the name of an existing 
		///   framebufferobject. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.DeleteFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		public static int CheckNamedFramebufferStatus(UInt32 framebuffer, int target)
		{
			int retValue;

			Debug.Assert(Delegates.pglCheckNamedFramebufferStatus != null, "pglCheckNamedFramebufferStatus not implemented");
			retValue = Delegates.pglCheckNamedFramebufferStatus(framebuffer, target);
			CallLog("glCheckNamedFramebufferStatus({0}, {1}) = {2}", framebuffer, target, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// query a named parameter of a framebuffer object
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for glGetNamedFramebufferParameteriv. 
		/// </param>
		/// <param name="pname">
		/// Specifies the parameter of the framebuffer object to query. 
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetFramebufferParameteriv and glGetNamedFramebufferParameteriv query parameters of a specified framebuffer object. 
		/// For glGetFramebufferParameteriv, the framebuffer object is that bound to target, which must be one of 
		/// GL_DRAW_FRAMEBUFFER,GL_READ_FRAMEBUFFER or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. Default 
		/// framebuffersmay also be queried if bound to target. 
		/// For glGetNamedFramebufferParameteriv, framebuffer is the name of the framebuffer object. If framebuffer is zero, the 
		/// defaultdraw framebuffer is queried. 
		/// Upon successful return, param will contain the value of the framebuffer parameter specified by pname, as described 
		/// below.
		/// The following parameters can only be queried for framebuffer objects: 
		/// The following parameters can be queried for both default framebuffers and framebuffer objects: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glGetFramebufferParameteriv if target is not one of the accepted framebuffer targets. 
		/// - GL_INVALID_OPERATION is generated by glGetNamedFramebufferAttachmentParameteriv if framebuffer is not zero or the name 
		///   ofan existing framebuffer object. 
		/// - GL_INVALID_ENUM is generated if pname is not one of the accepted parameter names. 
		/// - GL_INVALID_OPERATION is generated if a default framebuffer is queried, and pname is not one of GL_DOUBLEBUFFER, 
		///   GL_IMPLEMENTATION_COLOR_READ_FORMAT,GL_IMPLEMENTATION_COLOR_READ_TYPE, GL_SAMPLES, GL_SAMPLE_BUFFERS or GL_STEREO. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetFramebufferAttachmentParameter 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.FramebufferParameteri"/>
		/// <seealso cref="Gl.GetFramebufferAttachmentParameter"/>
		public static void GetNamedFramebufferParameter(UInt32 framebuffer, int pname, Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglGetNamedFramebufferParameteriv != null, "pglGetNamedFramebufferParameteriv not implemented");
					Delegates.pglGetNamedFramebufferParameteriv(framebuffer, pname, p_param);
					CallLog("glGetNamedFramebufferParameteriv({0}, {1}, {2})", framebuffer, pname, param);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve information about attachments of a framebuffer object
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object for glGetNamedFramebufferAttachmentParameteriv. 
		/// </param>
		/// <param name="attachment">
		/// Specifies the attachment of the framebuffer object to query. 
		/// </param>
		/// <param name="pname">
		/// Specifies the parameter of attachment to query. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetFramebufferAttachmentParameteriv and glGetNamedFramebufferAttachmentParameteriv return parameters of attachments of 
		/// aspecified framebuffer object. 
		/// For glGetFramebufferAttachmentParameteriv, the framebuffer object is that bound to target, which must be one of 
		/// GL_DRAW_FRAMEBUFFER,GL_READ_FRAMEBUFFER or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. Buffers 
		/// ofdefault framebuffers may also be queried if bound to target. 
		/// For glGetNamedFramebufferAttachmentParameteriv, framebuffer is the name of the framebuffer object. If framebuffer is 
		/// zero,the default draw framebuffer is queried. 
		/// If the specified framebuffer is a framebuffer object, attachment must be one of GL_DEPTH_ATTACHMENT, 
		/// GL_STENCIL_ATTACHMENTGL_DEPTH_STENCIL_ATTACHMENT,or GL_COLOR_ATTACHMENTi, where i is between zero and the value of 
		/// GL_MAX_COLOR_ATTACHMENTSminus one. 
		/// If the specified framebuffer is a default framebuffer, target, attachment must be one of GL_FRONT_LEFT, GL_FRONT_RIGHT, 
		/// GL_BACK_LEFT,GL_BACK_RIGHT, GL_DEPTH or GL_STENCIL, identifying the corresponding buffer. 
		/// If attachment is GL_DEPTH_STENCIL_ATTACHMENT, the same object must be bound to both the depth and stencil attachment 
		/// pointsof the framebuffer object, and information about that object is returned. 
		/// Upon successful return, if pname is GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE, then params will contain one of GL_NONE, 
		/// GL_FRAMEBUFFER_DEFAULT,GL_TEXTURE, or GL_RENDERBUFFER, identifying the type of object which contains the attached image. 
		/// Othervalues accepted for pname depend on the type of object, as described below. 
		/// If the value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE is GL_NONE, then either no framebuffer is bound to target; or a 
		/// defaultframebuffer is queried, attachment is GL_DEPTH or GL_STENCIL, and the number of depth or stencil bits, 
		/// respectively,is zero. In this case querying pnameGL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME will return zero, and all other 
		/// querieswill generate an error. 
		/// If the value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE is not GL_NONE, these queries apply to all other framebuffer 
		/// types:
		/// If the value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE is GL_RENDERBUFFER, then 
		/// If the value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE is GL_TEXTURE, then 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glGetFramebufferAttachmentParameteriv if target is not one of the accepted framebuffer 
		///   targets.
		/// - GL_INVALID_OPERATION is generated by glGetNamedFramebufferAttachmentParameteriv if framebuffer is not zero or the name 
		///   ofan existing framebuffer object. 
		/// - GL_INVALID_ENUM is generated if pname is not valid for the value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE, as described 
		///   above.
		/// - GL_INVALID_OPERATION is generated if attachment is not one of the accepted framebuffer attachment points, as described 
		///   above.
		/// - GL_INVALID_OPERATION is generated if the value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE is GL_NONE and pname is not 
		///   GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAMEor GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE. 
		/// - GL_INVALID_OPERATION is generated if attachment is GL_DEPTH_STENCIL_ATTACHMENT and different objects are bound to the 
		///   depthand stencil attachment points of target. 
		/// - GL_INVALID_OPERATION is generated if attachment is GL_DEPTH_STENCIL_ATTACHMENT and pname is 
		///   GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.GetFramebufferParameter"/>
		public static void GetNamedFramebufferAttachmentParameter(UInt32 framebuffer, int attachment, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetNamedFramebufferAttachmentParameteriv != null, "pglGetNamedFramebufferAttachmentParameteriv not implemented");
					Delegates.pglGetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, p_params);
					CallLog("glGetNamedFramebufferAttachmentParameteriv({0}, {1}, {2}, {3})", framebuffer, attachment, pname, @params);
				}
			}
			DebugCheckErrors();
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
		/// <remarks>
		/// glCreateRenderbuffers returns n previously unused renderbuffer object names in renderbuffers, each representing a new 
		/// renderbufferobject initialized to the default state. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if n is negative. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindRenderbuffer"/>
		/// <seealso cref="Gl.DeleteRenderbuffers"/>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.IsRenderbuffer"/>
		/// <seealso cref="Gl.RenderbufferStorage"/>
		/// <seealso cref="Gl.RenderbufferStorageMultisample"/>
		public static void CreateRenderbuffer(Int32 n, UInt32[] renderbuffers)
		{
			unsafe {
				fixed (UInt32* p_renderbuffers = renderbuffers)
				{
					Debug.Assert(Delegates.pglCreateRenderbuffers != null, "pglCreateRenderbuffers not implemented");
					Delegates.pglCreateRenderbuffers(n, p_renderbuffers);
					CallLog("glCreateRenderbuffers({0}, {1})", n, renderbuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// establish data storage, format and dimensions of a renderbuffer object's image
		/// </summary>
		/// <param name="renderbuffer">
		/// Specifies the name of the renderbuffer object for glNamedRenderbufferStorage function. 
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
		/// <remarks>
		/// glRenderbufferStorage is equivalent to calling glRenderbufferStorageMultisample with the samples set to zero, and 
		/// glNamedRenderbufferStorageis equivalent to calling glNamedRenderbufferStorageMultisample with the samples set to zero. 
		/// For glRenderbufferStorage, the target of the operation, specified by target must be GL_RENDERBUFFER. For 
		/// glNamedRenderbufferStorage,renderbuffer must be a name of an existing renderbuffer object. internalformat specifies the 
		/// internalformat to be used for the renderbuffer object's storage and must be a color-renderable, depth-renderable, or 
		/// stencil-renderableformat. width and height are the dimensions, in pixels, of the renderbuffer. Both width and height 
		/// mustbe less than or equal to the value of GL_MAX_RENDERBUFFER_SIZE. 
		/// Upon success, glRenderbufferStorage and glNamedRenderbufferStorage delete any existing data store for the renderbuffer 
		/// imageand the contents of the data store after calling glRenderbufferStorage are undefined. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glRenderbufferStorage if target is not GL_RENDERBUFFER. 
		/// - GL_INVALID_OPERATION is generated by glNamedRenderbufferStorage if renderbuffer is not the name of an existing 
		///   renderbufferobject. 
		/// - GL_INVALID_VALUE is generated if either of width or height is negative, or greater than the value of 
		///   GL_MAX_RENDERBUFFER_SIZE.
		/// - GL_INVALID_ENUM is generated if internalformat is not a color-renderable, depth-renderable, or stencil-renderable 
		///   format.
		/// - GL_OUT_OF_MEMORY is generated if the GL is unable to create a data store of the requested size. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.BindRenderbuffer"/>
		/// <seealso cref="Gl.NamedRenderbufferStorageMultisample"/>
		/// <seealso cref="Gl.RenderbufferStorageMultisample"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.DeleteRenderbuffers"/>
		public static void NamedRenderbufferStorage(UInt32 renderbuffer, int internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglNamedRenderbufferStorage != null, "pglNamedRenderbufferStorage not implemented");
			Delegates.pglNamedRenderbufferStorage(renderbuffer, internalformat, width, height);
			CallLog("glNamedRenderbufferStorage({0}, {1}, {2}, {3})", renderbuffer, internalformat, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// establish data storage, format, dimensions and sample count of a renderbuffer object's image
		/// </summary>
		/// <param name="renderbuffer">
		/// Specifies the name of the renderbuffer object for glNamedRenderbufferStorageMultisample function. 
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
		/// <remarks>
		/// glRenderbufferStorageMultisample and glNamedRenderbufferStorageMultisample establish the data storage, format, 
		/// dimensionsand number of samples of a renderbuffer object's image. 
		/// For glRenderbufferStorageMultisample, the target of the operation, specified by target must be GL_RENDERBUFFER. For 
		/// glNamedRenderbufferStorageMultisample,renderbuffer must be an ID of an existing renderbuffer object. internalformat 
		/// specifiesthe internal format to be used for the renderbuffer object's storage and must be a color-renderable, 
		/// depth-renderable,or stencil-renderable format. width and height are the dimensions, in pixels, of the renderbuffer. Both 
		/// widthand height must be less than or equal to the value of GL_MAX_RENDERBUFFER_SIZE. samples specifies the number of 
		/// samplesto be used for the renderbuffer object's image, and must be less than or equal to the value of GL_MAX_SAMPLES. If 
		/// internalformatis a signed or unsigned integer format then samples must be less than or equal to the value of 
		/// GL_MAX_INTEGER_SAMPLES.
		/// Upon success, glRenderbufferStorageMultisample and glNamedRenderbufferStorageMultisample delete any existing data store 
		/// forthe renderbuffer image and the contents of the data store after calling either of the functions are undefined. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glRenderbufferStorageMultisample function if target is not GL_RENDERBUFFER. 
		/// - GL_INVALID_OPERATION is generated by glNamedRenderbufferStorageMultisample function if renderbuffer is not the name of 
		///   anexisting renderbuffer object. 
		/// - GL_INVALID_VALUE is generated if samples is greater than GL_MAX_SAMPLES. 
		/// - GL_INVALID_ENUM is generated if internalformat is not a color-renderable, depth-renderable, or stencil-renderable 
		///   format.
		/// - GL_INVALID_OPERATION is generated if internalformat is a signed or unsigned integer format and samples is greater than 
		///   thevalue of GL_MAX_INTEGER_SAMPLES 
		/// - GL_INVALID_VALUE is generated if either of width or height is negative, or greater than the value of 
		///   GL_MAX_RENDERBUFFER_SIZE.
		/// - GL_OUT_OF_MEMORY is generated if the GL is unable to create a data store of the requested size. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.BindRenderbuffer"/>
		/// <seealso cref="Gl.NamedRenderbufferStorage"/>
		/// <seealso cref="Gl.RenderbufferStorage"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.DeleteRenderbuffers"/>
		public static void NamedRenderbufferStorageMultisample(UInt32 renderbuffer, Int32 samples, int internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglNamedRenderbufferStorageMultisample != null, "pglNamedRenderbufferStorageMultisample not implemented");
			Delegates.pglNamedRenderbufferStorageMultisample(renderbuffer, samples, internalformat, width, height);
			CallLog("glNamedRenderbufferStorageMultisample({0}, {1}, {2}, {3}, {4})", renderbuffer, samples, internalformat, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// query a named parameter of a renderbuffer object
		/// </summary>
		/// <param name="renderbuffer">
		/// Specifies the name of the renderbuffer object for glGetNamedRenderbufferParameteriv. 
		/// </param>
		/// <param name="pname">
		/// Specifies the parameter of the renderbuffer object to query. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetRenderbufferParameteriv and glGetNamedRenderbufferParameteriv query parameters of a specified renderbuffer object. 
		/// For glGetRenderbufferParameteriv, the renderbuffer object is that bound to target, which must be GL_RENDERBUFFER. 
		/// For glGetNamedRenderbufferParameteriv, renderbuffer is the name of the renderbuffer object. 
		/// Upon successful return, param will contain the value of the renderbuffer parameter specified by pname, as described 
		/// below.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glGetRenderbufferParameteriv if target is not GL_RENDERBUFFER. 
		/// - GL_INVALID_OPERATION is generated by glGetRenderbufferParameteriv if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glGetNamedRenderbufferParameteriv if renderbuffer is not the name of an existing 
		///   renderbufferobject. 
		/// - GL_INVALID_ENUM is generated if pname is not one of the accepted parameter names described above. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.BindRenderbuffer"/>
		/// <seealso cref="Gl.RenderbufferStorage"/>
		/// <seealso cref="Gl.RenderbufferStorageMultisample"/>
		public static void GetNamedRenderbufferParameter(UInt32 renderbuffer, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetNamedRenderbufferParameteriv != null, "pglGetNamedRenderbufferParameteriv not implemented");
					Delegates.pglGetNamedRenderbufferParameteriv(renderbuffer, pname, p_params);
					CallLog("glGetNamedRenderbufferParameteriv({0}, {1}, {2})", renderbuffer, pname, @params);
				}
			}
			DebugCheckErrors();
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
		/// <remarks>
		/// glCreateTextures returns n previously unused texture names in textures, each representing a new texture object of the 
		/// dimensionalityand type specified by target and initialized to the default values for that texture type. 
		/// target must be one of GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, 
		/// GL_TEXTURE_RECTANGLE,GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_BUFFER, GL_TEXTURE_2D_MULTISAMPLE or 
		/// GL_TEXTURE_2D_MULTISAMPLE_ARRAY.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target is not one of the allowable values. 
		/// - GL_INVALID_VALUE is generated if n is negative. 
		/// </para>
		/// </remarks>
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
		public static void CreateTextures(int target, Int32 n, UInt32[] textures)
		{
			unsafe {
				fixed (UInt32* p_textures = textures)
				{
					Debug.Assert(Delegates.pglCreateTextures != null, "pglCreateTextures not implemented");
					Delegates.pglCreateTextures(target, n, p_textures);
					CallLog("glCreateTextures({0}, {1}, {2})", target, n, textures);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// attach a buffer object's data store to a buffer texture object
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for glTextureBuffer. 
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="buffer">
		/// Specifies the name of the buffer object whose storage to attach to the active buffer texture. 
		/// </param>
		/// <remarks>
		/// glTexBuffer and glTextureBuffer attaches the data store of a specified buffer object to a specified texture object, and 
		/// specifythe storage format for the texture image found found in the buffer object. The texture object must be a buffer 
		/// texture.
		/// If buffer is zero, any buffer object attached to the buffer texture is detached and no new buffer object is attached. If 
		/// bufferis non-zero, it must be the name of an existing buffer object. 
		/// internalformat specifies the storage format, and must be one of the following sized internal formats: 
		/// internalformat specifies the storage format, and must be one of the following sized internal formats: 
		/// When a buffer object is attached to a buffer texture, the buffer object's data store is taken as the texture's texel 
		/// array.The number of texels in the buffer texture's texel array is given by $$ \left\lfloor { size \over { components 
		/// \timessizeof(base\_type) } } \right\rfloor $$ where $size$ is the size of the buffer object in basic machine units (the 
		/// valueof GL_BUFFER_SIZE for buffer), and $components$ and $base\_type$ are the element count and base data type for 
		/// elements,as specified in the table above. The number of texels in the texel array is then clamped to the value of the 
		/// implementation-dependentlimit GL_MAX_TEXTURE_BUFFER_SIZE. When a buffer texture is accessed in a shader, the results of 
		/// atexel fetch are undefined if the specified texel coordinate is negative, or greater than or equal to the clamped number 
		/// oftexels in the texel array. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glTexBuffer if target is not GL_TEXTURE_BUFFER. 
		/// - GL_INVALID_OPERATION is generated by glTextureBuffer if texture is not the name of an existing texture object. 
		/// - GL_INVALID_ENUM is generated by glTextureBuffer if the effective target of texture is not GL_TEXTURE_BUFFER. 
		/// - GL_INVALID_ENUM is generated if internalformat is not one of the sized internal formats described above. 
		/// - GL_INVALID_OPERATION is generated if buffer is not zero and is not the name of an existing buffer object. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_TEXTURE_BUFFER_SIZE 
		/// - glGet with argument GL_TEXTURE_BINDING_BUFFER 
		/// - glGetTexLevelParameter with argument GL_TEXTURE_BUFFER_DATA_STORE_BINDING 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.DeleteTextures"/>
		public static void TextureBuffer(UInt32 texture, int internalformat, UInt32 buffer)
		{
			Debug.Assert(Delegates.pglTextureBuffer != null, "pglTextureBuffer not implemented");
			Delegates.pglTextureBuffer(texture, internalformat, buffer);
			CallLog("glTextureBuffer({0}, {1}, {2})", texture, internalformat, buffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// attach a range of a buffer object's data store to a buffer texture object
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for glTextureBufferRange. 
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
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
		/// <remarks>
		/// glTexBufferRange and glTextureBufferRange attach a range of the data store of a specified buffer object to a specified 
		/// textureobject, and specify the storage format for the texture image found found in the buffer object. The texture object 
		/// mustbe a buffer texture. 
		/// If buffer is zero, any buffer object attached to the buffer texture is detached and no new buffer object is attached. If 
		/// bufferis non-zero, it must be the name of an existing buffer object. 
		/// The start and size of the range are specified by offset and size respectively, both measured in basic machine units. 
		/// offsetmust be greater than or equal to zero, size must be greater than zero, and the sum of offset and size must not 
		/// exceedthe value of GL_BUFFER_SIZE for buffer. Furthermore, offset must be an integer multiple of the value of 
		/// GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT.
		/// internalformat specifies the storage format, and must be one of the following sized internal formats: 
		/// When a range of a buffer object is attached to a buffer texture, the specified range of the buffer object's data store 
		/// istaken as the texture's texel array. The number of texels in the buffer texture's texel array is given by $$ 
		/// \left\lfloor{ size \over { components \times sizeof(base\_type) } } \right\rfloor $$ where $components$ and $base\_type$ 
		/// arethe element count and base data type for elements, as specified in the table above. The number of texels in the texel 
		/// arrayis then clamped to the value of the implementation-dependent limit GL_MAX_TEXTURE_BUFFER_SIZE. When a buffer 
		/// textureis accessed in a shader, the results of a texel fetch are undefined if the specified texel coordinate is 
		/// negative,or greater than or equal to the clamped number of texels in the texel array. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glTexBufferRange if target is not GL_TEXTURE_BUFFER. 
		/// - GL_INVALID_OPERATION is generated by glTextureBufferRange if texture is not the name of an existing texture object. 
		/// - GL_INVALID_ENUM is generated by glTextureBufferRange if the effective target of texture is not GL_TEXTURE_BUFFER. 
		/// - GL_INVALID_ENUM is generated if internalformat is not one of the sized internal formats described above. 
		/// - GL_INVALID_OPERATION is generated if buffer is not zero and is not the name of an existing buffer object. 
		/// - GL_INVALID_VALUE is generated if offset is negative, if size is less than or equal to zero, or if offset + size is 
		///   greaterthan the value of GL_BUFFER_SIZE for buffer. 
		/// - GL_INVALID_VALUE is generated if offset is not an integer multiple of the value of GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT 
		/// - glGetTexLevelParameter with arguments GL_TEXTURE_BUFFER_OFFSET or GL_TEXTURE_BUFFER_SIZE. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexBuffer"/>
		public static void TextureBufferRange(UInt32 texture, int internalformat, UInt32 buffer, IntPtr offset, UInt32 size)
		{
			Debug.Assert(Delegates.pglTextureBufferRange != null, "pglTextureBufferRange not implemented");
			Delegates.pglTextureBufferRange(texture, internalformat, buffer, offset, size);
			CallLog("glTextureBufferRange({0}, {1}, {2}, {3}, {4})", texture, internalformat, buffer, offset, size);
			DebugCheckErrors();
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void TextureStorage1D(UInt32 texture, Int32 levels, int internalformat, Int32 width)
		{
			Debug.Assert(Delegates.pglTextureStorage1D != null, "pglTextureStorage1D not implemented");
			Delegates.pglTextureStorage1D(texture, levels, internalformat, width);
			CallLog("glTextureStorage1D({0}, {1}, {2}, {3})", texture, levels, internalformat, width);
			DebugCheckErrors();
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void TextureStorage2D(UInt32 texture, Int32 levels, int internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglTextureStorage2D != null, "pglTextureStorage2D not implemented");
			Delegates.pglTextureStorage2D(texture, levels, internalformat, width, height);
			CallLog("glTextureStorage2D({0}, {1}, {2}, {3}, {4})", texture, levels, internalformat, width, height);
			DebugCheckErrors();
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
		/// A <see cref="T:int"/>.
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
		public static void TextureStorage3D(UInt32 texture, Int32 levels, int internalformat, Int32 width, Int32 height, Int32 depth)
		{
			Debug.Assert(Delegates.pglTextureStorage3D != null, "pglTextureStorage3D not implemented");
			Delegates.pglTextureStorage3D(texture, levels, internalformat, width, height, depth);
			CallLog("glTextureStorage3D({0}, {1}, {2}, {3}, {4}, {5})", texture, levels, internalformat, width, height, depth);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify storage for a two-dimensional multisample texture
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for glTextureStorage2DMultisample. The effective target of texture must be one of the 
		/// validnon-proxy target values above. 
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
		/// image,and the sample locations will not depend on the internal format or size of the image. 
		/// </param>
		/// <remarks>
		/// glTexStorage2DMultisample and glTextureStorage2DMultisample specify the storage requirements for a two-dimensional 
		/// multisampletexture. Once a texture is specified with this command, its format and dimensions become immutable unless it 
		/// isa proxy texture. The contents of the image may still be modified, however, its storage requirements may not change. 
		/// Sucha texture is referred to as an immutable-format texture. 
		/// samples specifies the number of samples to be used for the texture and must be greater than zero and less than or equal 
		/// tothe value of GL_MAX_SAMPLES. internalformat must be a color-renderable, depth-renderable, or stencil-renderable 
		/// format.width and height specify the width and height, respectively, of the texture. If fixedsamplelocations is GL_TRUE, 
		/// theimage will use identical sample locations and the same number of samples for all texels in the image, and the sample 
		/// locationswill not depend on the internal format or size of the image. 
		///  
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glTexStorage2DMultisample if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glTextureStorage2DMultisample if texture is not the name of an existing texture 
		///   object.
		/// - GL_INVALID_ENUM is generated if internalformat is not a valid color-renderable, depth-renderable or stencil-renderable 
		///   format.
		/// - GL_INVALID_ENUM is generated if target or the effective target of texture is not one of the accepted targets described 
		///   above.
		/// - GL_INVALID_VALUE is generated if width or height are less than 1 or greater than the value of GL_MAX_TEXTURE_SIZE. 
		/// - GL_INVALID_VALUE is generated if levels is less than 1. 
		/// - GL_INVALID_VALUE is generated if samples is greater than the value of GL_MAX_SAMPLES. 
		/// - GL_INVALID_OPERATION is generated if the value of GL_TEXTURE_IMMUTABLE_FORMAT for the texture bound to target is not 
		///   GL_FALSE.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage2DMultisample"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		public static void TextureStorage2DMultisample(UInt32 texture, Int32 samples, int internalformat, Int32 width, Int32 height, bool fixedsamplelocations)
		{
			Debug.Assert(Delegates.pglTextureStorage2DMultisample != null, "pglTextureStorage2DMultisample not implemented");
			Delegates.pglTextureStorage2DMultisample(texture, samples, internalformat, width, height, fixedsamplelocations);
			CallLog("glTextureStorage2DMultisample({0}, {1}, {2}, {3}, {4}, {5})", texture, samples, internalformat, width, height, fixedsamplelocations);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify storage for a two-dimensional multisample array texture
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for glTextureStorage3DMultisample. The effective target of texture must be one of the 
		/// validnon-proxy target values above. 
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
		/// image,and the sample locations will not depend on the internal format or size of the image. 
		/// </param>
		/// <remarks>
		/// glTexStorage3DMultisample and glTextureStorage3DMultisample specify the storage requirements for a two-dimensional 
		/// multisamplearray texture. Once a texture is specified with this command, its format and dimensions become immutable 
		/// unlessit is a proxy texture. The contents of the image may still be modified, however, its storage requirements may not 
		/// change.Such a texture is referred to as an immutable-format texture. 
		/// samples specifies the number of samples to be used for the texture and must be greater than zero and less than or equal 
		/// tothe value of GL_MAX_SAMPLES. internalformat must be a color-renderable, depth-renderable, or stencil-renderable 
		/// format.width and height specify the width and height, respectively, of the texture and depth specifies the depth (or the 
		/// numberof layers) of the texture. If fixedsamplelocations is GL_TRUE, the image will use identical sample locations and 
		/// thesame number of samples for all texels in the image, and the sample locations will not depend on the internal format 
		/// orsize of the image. 
		///  
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glTexStorage3DMultisample if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glTextureStorage3DMultisample if texture is not the name of an existing texture 
		///   object.
		/// - GL_INVALID_ENUM is generated if internalformat is not a valid color-renderable, depth-renderable or stencil-renderable 
		///   format.
		/// - GL_INVALID_ENUM is generated if target or the effective target of texture is not one of the accepted targets described 
		///   above.
		/// - GL_INVALID_VALUE is generated if width or height are less than 1 or greater than the value of GL_MAX_TEXTURE_SIZE. 
		/// - GL_INVALID_VALUE is generated if depth is less than 1 or greater than the value of GL_MAX_ARRAY_TEXTURE_LAYERS. 
		/// - GL_INVALID_VALUE is generated if levels is less than 1. 
		/// - GL_INVALID_VALUE is generated if samples is greater than the value of GL_MAX_SAMPLES. 
		/// - GL_INVALID_OPERATION is generated if the value of GL_TEXTURE_IMMUTABLE_FORMAT for the texture bound to target is not 
		///   GL_FALSE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetInteger with arguments GL_MAX_TEXTURE_SIZE, GL_MAX_ARRAY_TEXTURE_LEVELS, GL_TEXTURE_VIEW_MIN_LAYER, 
		///   GL_TEXTURE_VIEW_NUM_LAYERS,or GL_TEXTURE_IMMUTABLE_LEVELS. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexImage3DMultisample"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2DMultisample"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		public static void TextureStorage3DMultisample(UInt32 texture, Int32 samples, int internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations)
		{
			Debug.Assert(Delegates.pglTextureStorage3DMultisample != null, "pglTextureStorage3DMultisample not implemented");
			Delegates.pglTextureStorage3DMultisample(texture, samples, internalformat, width, height, depth, fixedsamplelocations);
			CallLog("glTextureStorage3DMultisample({0}, {1}, {2}, {3}, {4}, {5}, {6})", texture, samples, internalformat, width, height, depth, fixedsamplelocations);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a one-dimensional texture subimage
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for glTextureSubImage1D. The effective target of texture must be one of the valid 
		/// targetvalues above. 
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, 
		/// GL_RGBA,GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX. 
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT,GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5,GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2,and GL_UNSIGNED_INT_2_10_10_10_REV. 
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enableor disable one-dimensional texturing, call glEnable and glDisable with argument GL_TEXTURE_1D. 
		/// glTexSubImage1D and glTextureSubImage1D redefine a contiguous subregion of an existing one-dimensional texture image. 
		/// Thetexels referenced by pixels replace the portion of the existing texture array with x indices xoffset and 
		/// xoffset+width-1,inclusive. This region may not include any texels outside the range of the texture array as it was 
		/// originallyspecified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, pixels is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target or the effective target of texture is not one of the allowable values. 
		/// - GL_INVALID_OPERATION is generated by glTextureSubImage1D if texture is not the name of an existing texture object. 
		/// - GL_INVALID_ENUM is generated if format is not an accepted format constant. 
		/// - GL_INVALID_ENUM is generated if type is not a type constant. 
		/// - GL_INVALID_VALUE is generated if level is less than 0. 
		/// - GL_INVALID_VALUE may be generated if level is greater than log2max, where max is the returned value of 
		///   GL_MAX_TEXTURE_SIZE.
		/// - GL_INVALID_VALUE is generated if xoffset&lt;-b, or if xoffset+width&gt;w-b, where w is the GL_TEXTURE_WIDTH, and b is 
		///   thewidth of the GL_TEXTURE_BORDER of the texture image being modified. Note that w includes twice the border width. 
		/// - GL_INVALID_VALUE is generated if width is less than 0. 
		/// - GL_INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage1D operation. 
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		///   GL_UNSIGNED_SHORT_5_6_5,or GL_UNSIGNED_SHORT_5_6_5_REV and format is not GL_RGB. 
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		///   GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		///   GL_UNSIGNED_INT_10_10_10_2,or GL_UNSIGNED_INT_2_10_10_10_REV and format is neither GL_RGBA nor GL_BGRA. 
		/// - GL_INVALID_OPERATION is generated if format is GL_STENCIL_INDEX and the base internal format is not GL_STENCIL_INDEX. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and 
		///   pixelsis not evenly divisible into the number of bytes needed to store in memory a datum indicated by type. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexImage 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// </para>
		/// </remarks>
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
		public static void TextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, int format, int type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTextureSubImage1D != null, "pglTextureSubImage1D not implemented");
			Delegates.pglTextureSubImage1D(texture, level, xoffset, width, format, type, pixels);
			CallLog("glTextureSubImage1D({0}, {1}, {2}, {3}, {4}, {5}, {6})", texture, level, xoffset, width, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a one-dimensional texture subimage
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for glTextureSubImage1D. The effective target of texture must be one of the valid 
		/// targetvalues above. 
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, 
		/// GL_RGBA,GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX. 
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT,GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5,GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2,and GL_UNSIGNED_INT_2_10_10_10_REV. 
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enableor disable one-dimensional texturing, call glEnable and glDisable with argument GL_TEXTURE_1D. 
		/// glTexSubImage1D and glTextureSubImage1D redefine a contiguous subregion of an existing one-dimensional texture image. 
		/// Thetexels referenced by pixels replace the portion of the existing texture array with x indices xoffset and 
		/// xoffset+width-1,inclusive. This region may not include any texels outside the range of the texture array as it was 
		/// originallyspecified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, pixels is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target or the effective target of texture is not one of the allowable values. 
		/// - GL_INVALID_OPERATION is generated by glTextureSubImage1D if texture is not the name of an existing texture object. 
		/// - GL_INVALID_ENUM is generated if format is not an accepted format constant. 
		/// - GL_INVALID_ENUM is generated if type is not a type constant. 
		/// - GL_INVALID_VALUE is generated if level is less than 0. 
		/// - GL_INVALID_VALUE may be generated if level is greater than log2max, where max is the returned value of 
		///   GL_MAX_TEXTURE_SIZE.
		/// - GL_INVALID_VALUE is generated if xoffset&lt;-b, or if xoffset+width&gt;w-b, where w is the GL_TEXTURE_WIDTH, and b is 
		///   thewidth of the GL_TEXTURE_BORDER of the texture image being modified. Note that w includes twice the border width. 
		/// - GL_INVALID_VALUE is generated if width is less than 0. 
		/// - GL_INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage1D operation. 
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		///   GL_UNSIGNED_SHORT_5_6_5,or GL_UNSIGNED_SHORT_5_6_5_REV and format is not GL_RGB. 
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		///   GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		///   GL_UNSIGNED_INT_10_10_10_2,or GL_UNSIGNED_INT_2_10_10_10_REV and format is neither GL_RGBA nor GL_BGRA. 
		/// - GL_INVALID_OPERATION is generated if format is GL_STENCIL_INDEX and the base internal format is not GL_STENCIL_INDEX. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and 
		///   pixelsis not evenly divisible into the number of bytes needed to store in memory a datum indicated by type. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexImage 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// </para>
		/// </remarks>
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
		public static void TextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, int format, int type, Object pixels)
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
		/// Specifies the texture object name for glTextureSubImage2D. The effective target of texture must be one of the valid 
		/// targetvalues above. 
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, 
		/// GL_RGBA,GL_BGRA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX. 
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT,GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5,GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2,and GL_UNSIGNED_INT_2_10_10_10_REV. 
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. 
		/// glTexSubImage2D and glTextureSubImage2D redefine a contiguous subregion of an existing two-dimensional or 
		/// one-dimensionalarray texture image. The texels referenced by pixels replace the portion of the existing texture array 
		/// withx indices xoffset and xoffset+width-1, inclusive, and y indices yoffset and yoffset+height-1, inclusive. This region 
		/// maynot include any texels outside the range of the texture array as it was originally specified. It is not an error to 
		/// specifya subtexture with zero width or height, but such a specification has no effect. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, pixels is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target or the effective target of texture is not GL_TEXTURE_2D, 
		///   GL_TEXTURE_CUBE_MAP_POSITIVE_X,GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		///   GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY. 
		/// - GL_INVALID_OPERATION is generated by glTextureSubImage2D if texture is not the name of an existing texture object. 
		/// - GL_INVALID_ENUM is generated if format is not an accepted format constant. 
		/// - GL_INVALID_ENUM is generated if type is not a type constant. 
		/// - GL_INVALID_VALUE is generated if level is less than 0. 
		/// - GL_INVALID_VALUE may be generated if level is greater than log2max, where max is the returned value of 
		///   GL_MAX_TEXTURE_SIZE.
		/// - GL_INVALID_VALUE is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or yoffset+height&gt;h-b, where w 
		///   isthe GL_TEXTURE_WIDTH, h is the GL_TEXTURE_HEIGHT, and b is the border width of the texture image being modified. Note 
		///   thatw and h include twice the border width. 
		/// - GL_INVALID_VALUE is generated if width or height is less than 0. 
		/// - GL_INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage2D operation. 
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		///   GL_UNSIGNED_SHORT_5_6_5,or GL_UNSIGNED_SHORT_5_6_5_REV and format is not GL_RGB. 
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		///   GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		///   GL_UNSIGNED_INT_10_10_10_2,or GL_UNSIGNED_INT_2_10_10_10_REV and format is neither GL_RGBA nor GL_BGRA. 
		/// - GL_INVALID_OPERATION is generated if format is GL_STENCIL_INDEX and the base internal format is not GL_STENCIL_INDEX. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and 
		///   pixelsis not evenly divisible into the number of bytes needed to store in memory a datum indicated by type. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexImage 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// </para>
		/// </remarks>
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
		public static void TextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, int type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTextureSubImage2D != null, "pglTextureSubImage2D not implemented");
			Delegates.pglTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);
			CallLog("glTextureSubImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", texture, level, xoffset, yoffset, width, height, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a two-dimensional texture subimage
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for glTextureSubImage2D. The effective target of texture must be one of the valid 
		/// targetvalues above. 
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, 
		/// GL_RGBA,GL_BGRA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX. 
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT,GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5,GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2,and GL_UNSIGNED_INT_2_10_10_10_REV. 
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. 
		/// glTexSubImage2D and glTextureSubImage2D redefine a contiguous subregion of an existing two-dimensional or 
		/// one-dimensionalarray texture image. The texels referenced by pixels replace the portion of the existing texture array 
		/// withx indices xoffset and xoffset+width-1, inclusive, and y indices yoffset and yoffset+height-1, inclusive. This region 
		/// maynot include any texels outside the range of the texture array as it was originally specified. It is not an error to 
		/// specifya subtexture with zero width or height, but such a specification has no effect. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, pixels is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target or the effective target of texture is not GL_TEXTURE_2D, 
		///   GL_TEXTURE_CUBE_MAP_POSITIVE_X,GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		///   GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY. 
		/// - GL_INVALID_OPERATION is generated by glTextureSubImage2D if texture is not the name of an existing texture object. 
		/// - GL_INVALID_ENUM is generated if format is not an accepted format constant. 
		/// - GL_INVALID_ENUM is generated if type is not a type constant. 
		/// - GL_INVALID_VALUE is generated if level is less than 0. 
		/// - GL_INVALID_VALUE may be generated if level is greater than log2max, where max is the returned value of 
		///   GL_MAX_TEXTURE_SIZE.
		/// - GL_INVALID_VALUE is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or yoffset+height&gt;h-b, where w 
		///   isthe GL_TEXTURE_WIDTH, h is the GL_TEXTURE_HEIGHT, and b is the border width of the texture image being modified. Note 
		///   thatw and h include twice the border width. 
		/// - GL_INVALID_VALUE is generated if width or height is less than 0. 
		/// - GL_INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage2D operation. 
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		///   GL_UNSIGNED_SHORT_5_6_5,or GL_UNSIGNED_SHORT_5_6_5_REV and format is not GL_RGB. 
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		///   GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		///   GL_UNSIGNED_INT_10_10_10_2,or GL_UNSIGNED_INT_2_10_10_10_REV and format is neither GL_RGBA nor GL_BGRA. 
		/// - GL_INVALID_OPERATION is generated if format is GL_STENCIL_INDEX and the base internal format is not GL_STENCIL_INDEX. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and 
		///   pixelsis not evenly divisible into the number of bytes needed to store in memory a datum indicated by type. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexImage 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// </para>
		/// </remarks>
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
		public static void TextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, int type, Object pixels)
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
		/// Specifies the texture object name for glTextureSubImage3D. The effective target of texture must be one of the valid 
		/// targetvalues above. 
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, 
		/// GL_RGBA,GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX. 
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT,GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5,GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2,and GL_UNSIGNED_INT_2_10_10_10_REV. 
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. 
		/// glTexSubImage3D and glTextureSubImage3D redefine a contiguous subregion of an existing three-dimensional or 
		/// two-dimensioanlarray texture image. The texels referenced by pixels replace the portion of the existing texture array 
		/// withx indices xoffset and xoffset+width-1, inclusive, y indices yoffset and yoffset+height-1, inclusive, and z indices 
		/// zoffsetand zoffset+depth-1, inclusive. For three-dimensional textures, the z index refers to the third dimension. For 
		/// two-dimensionalarray textures, the z index refers to the slice index. This region may not include any texels outside the 
		/// rangeof the texture array as it was originally specified. It is not an error to specify a subtexture with zero width, 
		/// height,or depth but such a specification has no effect. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, pixels is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target or the effective target of texture is not GL_TEXTURE_3D or GL_TEXTURE_2D_ARRAY. 
		/// - GL_INVALID_OPERATION is generated by glTextureSubImage3D if texture is not the name of an existing texture object. 
		/// - GL_INVALID_ENUM is generated if format is not an accepted format constant. 
		/// - GL_INVALID_ENUM is generated if type is not a type constant. 
		/// - GL_INVALID_VALUE is generated if level is less than 0. 
		/// - GL_INVALID_VALUE may be generated if level is greater than log2max, where max is the returned value of 
		///   GL_MAX_TEXTURE_SIZE.
		/// - GL_INVALID_VALUE is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or yoffset+height&gt;h-b, or 
		///   zoffset&lt;-b,or zoffset+depth&gt;d-b, where w is the GL_TEXTURE_WIDTH, h is the GL_TEXTURE_HEIGHT, d is the 
		///   GL_TEXTURE_DEPTHand b is the border width of the texture image being modified. Note that w, h, and d include twice the 
		///   borderwidth. 
		/// - GL_INVALID_VALUE is generated if width, height, or depth is less than 0. 
		/// - GL_INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage3D or glTexStorage3D 
		///   operation.
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		///   GL_UNSIGNED_SHORT_5_6_5,or GL_UNSIGNED_SHORT_5_6_5_REV and format is not GL_RGB. 
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		///   GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		///   GL_UNSIGNED_INT_10_10_10_2,or GL_UNSIGNED_INT_2_10_10_10_REV and format is neither GL_RGBA nor GL_BGRA. 
		/// - GL_INVALID_OPERATION is generated if format is GL_STENCIL_INDEX and the base internal format is not GL_STENCIL_INDEX. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and 
		///   pixelsis not evenly divisible into the number of bytes needed to store in memory a datum indicated by type. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexImage 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// </para>
		/// </remarks>
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
		public static void TextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTextureSubImage3D != null, "pglTextureSubImage3D not implemented");
			Delegates.pglTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
			CallLog("glTextureSubImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a three-dimensional texture subimage
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for glTextureSubImage3D. The effective target of texture must be one of the valid 
		/// targetvalues above. 
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, 
		/// GL_RGBA,GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX. 
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT,GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5,GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2,and GL_UNSIGNED_INT_2_10_10_10_REV. 
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. 
		/// glTexSubImage3D and glTextureSubImage3D redefine a contiguous subregion of an existing three-dimensional or 
		/// two-dimensioanlarray texture image. The texels referenced by pixels replace the portion of the existing texture array 
		/// withx indices xoffset and xoffset+width-1, inclusive, y indices yoffset and yoffset+height-1, inclusive, and z indices 
		/// zoffsetand zoffset+depth-1, inclusive. For three-dimensional textures, the z index refers to the third dimension. For 
		/// two-dimensionalarray textures, the z index refers to the slice index. This region may not include any texels outside the 
		/// rangeof the texture array as it was originally specified. It is not an error to specify a subtexture with zero width, 
		/// height,or depth but such a specification has no effect. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, pixels is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target or the effective target of texture is not GL_TEXTURE_3D or GL_TEXTURE_2D_ARRAY. 
		/// - GL_INVALID_OPERATION is generated by glTextureSubImage3D if texture is not the name of an existing texture object. 
		/// - GL_INVALID_ENUM is generated if format is not an accepted format constant. 
		/// - GL_INVALID_ENUM is generated if type is not a type constant. 
		/// - GL_INVALID_VALUE is generated if level is less than 0. 
		/// - GL_INVALID_VALUE may be generated if level is greater than log2max, where max is the returned value of 
		///   GL_MAX_TEXTURE_SIZE.
		/// - GL_INVALID_VALUE is generated if xoffset&lt;-b, xoffset+width&gt;w-b, yoffset&lt;-b, or yoffset+height&gt;h-b, or 
		///   zoffset&lt;-b,or zoffset+depth&gt;d-b, where w is the GL_TEXTURE_WIDTH, h is the GL_TEXTURE_HEIGHT, d is the 
		///   GL_TEXTURE_DEPTHand b is the border width of the texture image being modified. Note that w, h, and d include twice the 
		///   borderwidth. 
		/// - GL_INVALID_VALUE is generated if width, height, or depth is less than 0. 
		/// - GL_INVALID_OPERATION is generated if the texture array has not been defined by a previous glTexImage3D or glTexStorage3D 
		///   operation.
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		///   GL_UNSIGNED_SHORT_5_6_5,or GL_UNSIGNED_SHORT_5_6_5_REV and format is not GL_RGB. 
		/// - GL_INVALID_OPERATION is generated if type is one of GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		///   GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		///   GL_UNSIGNED_INT_10_10_10_2,or GL_UNSIGNED_INT_2_10_10_10_REV and format is neither GL_RGBA nor GL_BGRA. 
		/// - GL_INVALID_OPERATION is generated if format is GL_STENCIL_INDEX and the base internal format is not GL_STENCIL_INDEX. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and 
		///   pixelsis not evenly divisible into the number of bytes needed to store in memory a datum indicated by type. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexImage 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// </para>
		/// </remarks>
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
		public static void TextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, Object pixels)
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
		/// Specifies the texture object name for glCompressedTextureSubImage1D function. 
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
		/// Specifies the format of the compressed image data stored at address data. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by data. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing allows elements of an image array to be read by shaders. 
		/// glCompressedTexSubImage1D and glCompressedTextureSubImage1D redefine a contiguous subregion of an existing 
		/// one-dimensionaltexture image. The texels referenced by data replace the portion of the existing texture array with x 
		/// indicesxoffset and xoffset+width-1, inclusive. This region may not include any texels outside the range of the texture 
		/// arrayas it was originally specified. It is not an error to specify a subtexture with width of 0, but such a 
		/// specificationhas no effect. 
		/// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture 
		/// format.The format of the compressed texture image is selected by the GL implementation that compressed it (see 
		/// glTexImage1D),and should be queried at the time the texture was compressed with glGetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, data is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if internalformat is not one of the generic compressed internal formats: GL_COMPRESSED_RED, 
		///   GL_COMPRESSED_RG,GL_COMPRESSED_RGB, GL_COMPRESSED_RGBA. GL_COMPRESSED_SRGB, or GL_COMPRESSED_SRGB_ALPHA. 
		/// - GL_INVALID_VALUE is generated if imageSize is not consistent with the format, dimensions, and contents of the specified 
		///   compressedimage data. 
		/// - GL_INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		///   asspecified in the specific texture compression extension. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - GL_INVALID_OPERATION is generated by glCompressedTextureSubImage1D function if texture is not the name of an existing 
		///   textureobject. 
		/// - Undefined results, including abnormal program termination, are generated if data is not encoded in a manner consistent 
		///   withthe extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetCompressedTexImage 
		/// - glGet with argument GL_TEXTURE_COMPRESSED 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// - glGetTexLevelParameter with arguments GL_TEXTURE_INTERNAL_FORMAT and GL_TEXTURE_COMPRESSED_IMAGE_SIZE 
		/// </para>
		/// </remarks>
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
		public static void CompressedTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, int format, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTextureSubImage1D != null, "pglCompressedTextureSubImage1D not implemented");
			Delegates.pglCompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);
			CallLog("glCompressedTextureSubImage1D({0}, {1}, {2}, {3}, {4}, {5}, {6})", texture, level, xoffset, width, format, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a one-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for glCompressedTextureSubImage1D function. 
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
		/// Specifies the format of the compressed image data stored at address data. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by data. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing allows elements of an image array to be read by shaders. 
		/// glCompressedTexSubImage1D and glCompressedTextureSubImage1D redefine a contiguous subregion of an existing 
		/// one-dimensionaltexture image. The texels referenced by data replace the portion of the existing texture array with x 
		/// indicesxoffset and xoffset+width-1, inclusive. This region may not include any texels outside the range of the texture 
		/// arrayas it was originally specified. It is not an error to specify a subtexture with width of 0, but such a 
		/// specificationhas no effect. 
		/// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture 
		/// format.The format of the compressed texture image is selected by the GL implementation that compressed it (see 
		/// glTexImage1D),and should be queried at the time the texture was compressed with glGetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, data is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if internalformat is not one of the generic compressed internal formats: GL_COMPRESSED_RED, 
		///   GL_COMPRESSED_RG,GL_COMPRESSED_RGB, GL_COMPRESSED_RGBA. GL_COMPRESSED_SRGB, or GL_COMPRESSED_SRGB_ALPHA. 
		/// - GL_INVALID_VALUE is generated if imageSize is not consistent with the format, dimensions, and contents of the specified 
		///   compressedimage data. 
		/// - GL_INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		///   asspecified in the specific texture compression extension. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - GL_INVALID_OPERATION is generated by glCompressedTextureSubImage1D function if texture is not the name of an existing 
		///   textureobject. 
		/// - Undefined results, including abnormal program termination, are generated if data is not encoded in a manner consistent 
		///   withthe extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetCompressedTexImage 
		/// - glGet with argument GL_TEXTURE_COMPRESSED 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// - glGetTexLevelParameter with arguments GL_TEXTURE_INTERNAL_FORMAT and GL_TEXTURE_COMPRESSED_IMAGE_SIZE 
		/// </para>
		/// </remarks>
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
		public static void CompressedTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, int format, Int32 imageSize, Object data)
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
		/// Specifies the texture object name for glCompressedTextureSubImage2D function. 
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
		/// Specifies the format of the compressed image data stored at address data. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by data. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing allows elements of an image array to be read by shaders. 
		/// glCompressedTexSubImage2D and glCompressedTextureSubImage2D redefine a contiguous subregion of an existing 
		/// two-dimensionaltexture image. The texels referenced by data replace the portion of the existing texture array with x 
		/// indicesxoffset and xoffset+width-1, and the y indices yoffset and yoffset+height-1, inclusive. This region may not 
		/// includeany texels outside the range of the texture array as it was originally specified. It is not an error to specify a 
		/// subtexturewith width of 0, but such a specification has no effect. 
		/// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture 
		/// format.The format of the compressed texture image is selected by the GL implementation that compressed it (see 
		/// glTexImage2D)and should be queried at the time the texture was compressed with glGetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, data is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if internalformat is of the generic compressed internal formats: GL_COMPRESSED_RED, 
		///   GL_COMPRESSED_RG,GL_COMPRESSED_RGB, GL_COMPRESSED_RGBA. GL_COMPRESSED_SRGB, or GL_COMPRESSED_SRGB_ALPHA. 
		/// - GL_INVALID_ENUM is generated by glCompressedTexSubImage2D if target is GL_TEXTURE_RECTANGLE or 
		///   GL_PROXY_TEXTURE_RECTANGLE.
		/// - GL_INVALID_VALUE is generated if imageSize is not consistent with the format, dimensions, and contents of the specified 
		///   compressedimage data. 
		/// - GL_INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		///   asspecified in the specific texture compression extension. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - GL_INVALID_OPERATION is generated by glCompressedTextureSubImage2D if texture is not the name of an existing texture 
		///   object.
		/// - GL_INVALID_OPERATION is generated by glCompressedTextureSubImage2D if the effective target is GL_TEXTURE_RECTANGLE. 
		/// - Undefined results, including abnormal program termination, are generated if data is not encoded in a manner consistent 
		///   withthe extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetCompressedTexImage 
		/// - glGet with argument GL_TEXTURE_COMPRESSED 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// - glGetTexLevelParameter with arguments GL_TEXTURE_INTERNAL_FORMAT and GL_TEXTURE_COMPRESSED_IMAGE_SIZE 
		/// </para>
		/// </remarks>
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
		public static void CompressedTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTextureSubImage2D != null, "pglCompressedTextureSubImage2D not implemented");
			Delegates.pglCompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
			CallLog("glCompressedTextureSubImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", texture, level, xoffset, yoffset, width, height, format, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a two-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for glCompressedTextureSubImage2D function. 
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
		/// Specifies the format of the compressed image data stored at address data. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by data. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing allows elements of an image array to be read by shaders. 
		/// glCompressedTexSubImage2D and glCompressedTextureSubImage2D redefine a contiguous subregion of an existing 
		/// two-dimensionaltexture image. The texels referenced by data replace the portion of the existing texture array with x 
		/// indicesxoffset and xoffset+width-1, and the y indices yoffset and yoffset+height-1, inclusive. This region may not 
		/// includeany texels outside the range of the texture array as it was originally specified. It is not an error to specify a 
		/// subtexturewith width of 0, but such a specification has no effect. 
		/// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture 
		/// format.The format of the compressed texture image is selected by the GL implementation that compressed it (see 
		/// glTexImage2D)and should be queried at the time the texture was compressed with glGetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, data is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if internalformat is of the generic compressed internal formats: GL_COMPRESSED_RED, 
		///   GL_COMPRESSED_RG,GL_COMPRESSED_RGB, GL_COMPRESSED_RGBA. GL_COMPRESSED_SRGB, or GL_COMPRESSED_SRGB_ALPHA. 
		/// - GL_INVALID_ENUM is generated by glCompressedTexSubImage2D if target is GL_TEXTURE_RECTANGLE or 
		///   GL_PROXY_TEXTURE_RECTANGLE.
		/// - GL_INVALID_VALUE is generated if imageSize is not consistent with the format, dimensions, and contents of the specified 
		///   compressedimage data. 
		/// - GL_INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		///   asspecified in the specific texture compression extension. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - GL_INVALID_OPERATION is generated by glCompressedTextureSubImage2D if texture is not the name of an existing texture 
		///   object.
		/// - GL_INVALID_OPERATION is generated by glCompressedTextureSubImage2D if the effective target is GL_TEXTURE_RECTANGLE. 
		/// - Undefined results, including abnormal program termination, are generated if data is not encoded in a manner consistent 
		///   withthe extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetCompressedTexImage 
		/// - glGet with argument GL_TEXTURE_COMPRESSED 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// - glGetTexLevelParameter with arguments GL_TEXTURE_INTERNAL_FORMAT and GL_TEXTURE_COMPRESSED_IMAGE_SIZE 
		/// </para>
		/// </remarks>
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
		public static void CompressedTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, Int32 imageSize, Object data)
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
		/// Specifies the texture object name for glCompressedTextureSubImage3D function. 
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
		/// Specifies the format of the compressed image data stored at address data. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by data. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing allows elements of an image array to be read by shaders. 
		/// glCompressedTexSubImage3D and glCompressedTextureSubImage3D redefine a contiguous subregion of an existing 
		/// three-dimensionaltexture image. The texels referenced by data replace the portion of the existing texture array with x 
		/// indicesxoffset and xoffset+width-1, and the y indices yoffset and yoffset+height-1, and the z indices zoffset and 
		/// zoffset+depth-1,inclusive. This region may not include any texels outside the range of the texture array as it was 
		/// originallyspecified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect. 
		/// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture 
		/// format.The format of the compressed texture image is selected by the GL implementation that compressed it (see 
		/// glTexImage3D)and should be queried at the time the texture was compressed with glGetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, data is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if internalformat is one of the generic compressed internal formats: GL_COMPRESSED_RED, 
		///   GL_COMPRESSED_RG,GL_COMPRESSED_RGB, GL_COMPRESSED_RGBA. GL_COMPRESSED_SRGB, or GL_COMPRESSED_SRGB_ALPHA. 
		/// - GL_INVALID_ENUM is generated by glCompressedTexSubImage3D if target is not GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, or 
		///   GL_TEXTURE_CUBE_MAP_ARRAY.
		/// - GL_INVALID_OPERATION is generated by glCompressedTextureSubImage3D if texture is not the name of an existing texture 
		///   object.
		/// - GL_INVALID_VALUE is generated if imageSize is not consistent with the format, dimensions, and contents of the specified 
		///   compressedimage data. 
		/// - GL_INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		///   asspecified in the specific texture compression extension. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - Undefined results, including abnormal program termination, are generated if data is not encoded in a manner consistent 
		///   withthe extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetCompressedTexImage 
		/// - glGet with argument GL_TEXTURE_COMPRESSED 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// - glGetTexLevelParameter with arguments GL_TEXTURE_INTERNAL_FORMAT and GL_TEXTURE_COMPRESSED_IMAGE_SIZE 
		/// </para>
		/// </remarks>
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
		public static void CompressedTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, Int32 imageSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglCompressedTextureSubImage3D != null, "pglCompressedTextureSubImage3D not implemented");
			Delegates.pglCompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
			CallLog("glCompressedTextureSubImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a three-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for glCompressedTextureSubImage3D function. 
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
		/// Specifies the format of the compressed image data stored at address data. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by data. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing allows elements of an image array to be read by shaders. 
		/// glCompressedTexSubImage3D and glCompressedTextureSubImage3D redefine a contiguous subregion of an existing 
		/// three-dimensionaltexture image. The texels referenced by data replace the portion of the existing texture array with x 
		/// indicesxoffset and xoffset+width-1, and the y indices yoffset and yoffset+height-1, and the z indices zoffset and 
		/// zoffset+depth-1,inclusive. This region may not include any texels outside the range of the texture array as it was 
		/// originallyspecified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect. 
		/// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture 
		/// format.The format of the compressed texture image is selected by the GL implementation that compressed it (see 
		/// glTexImage3D)and should be queried at the time the texture was compressed with glGetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, data is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if internalformat is one of the generic compressed internal formats: GL_COMPRESSED_RED, 
		///   GL_COMPRESSED_RG,GL_COMPRESSED_RGB, GL_COMPRESSED_RGBA. GL_COMPRESSED_SRGB, or GL_COMPRESSED_SRGB_ALPHA. 
		/// - GL_INVALID_ENUM is generated by glCompressedTexSubImage3D if target is not GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, or 
		///   GL_TEXTURE_CUBE_MAP_ARRAY.
		/// - GL_INVALID_OPERATION is generated by glCompressedTextureSubImage3D if texture is not the name of an existing texture 
		///   object.
		/// - GL_INVALID_VALUE is generated if imageSize is not consistent with the format, dimensions, and contents of the specified 
		///   compressedimage data. 
		/// - GL_INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		///   asspecified in the specific texture compression extension. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - Undefined results, including abnormal program termination, are generated if data is not encoded in a manner consistent 
		///   withthe extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetCompressedTexImage 
		/// - glGet with argument GL_TEXTURE_COMPRESSED 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// - glGetTexLevelParameter with arguments GL_TEXTURE_INTERNAL_FORMAT and GL_TEXTURE_COMPRESSED_IMAGE_SIZE 
		/// </para>
		/// </remarks>
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
		public static void CompressedTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, Int32 imageSize, Object data)
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
		public static void CopyTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width)
		{
			Debug.Assert(Delegates.pglCopyTextureSubImage1D != null, "pglCopyTextureSubImage1D not implemented");
			Delegates.pglCopyTextureSubImage1D(texture, level, xoffset, x, y, width);
			CallLog("glCopyTextureSubImage1D({0}, {1}, {2}, {3}, {4}, {5})", texture, level, xoffset, x, y, width);
			DebugCheckErrors();
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
		public static void CopyTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglCopyTextureSubImage2D != null, "pglCopyTextureSubImage2D not implemented");
			Delegates.pglCopyTextureSubImage2D(texture, level, xoffset, yoffset, x, y, width, height);
			CallLog("glCopyTextureSubImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", texture, level, xoffset, yoffset, x, y, width, height);
			DebugCheckErrors();
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
		public static void CopyTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglCopyTextureSubImage3D != null, "pglCopyTextureSubImage3D not implemented");
			Delegates.pglCopyTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
			CallLog("glCopyTextureSubImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", texture, level, xoffset, yoffset, zoffset, x, y, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTextureParameterf.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void TextureParameter(UInt32 texture, int pname, float param)
		{
			Debug.Assert(Delegates.pglTextureParameterf != null, "pglTextureParameterf not implemented");
			Delegates.pglTextureParameterf(texture, pname, param);
			CallLog("glTextureParameterf({0}, {1}, {2})", texture, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTextureParameterfv.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void TextureParameter(UInt32 texture, int pname, float[] param)
		{
			unsafe {
				fixed (float* p_param = param)
				{
					Debug.Assert(Delegates.pglTextureParameterfv != null, "pglTextureParameterfv not implemented");
					Delegates.pglTextureParameterfv(texture, pname, p_param);
					CallLog("glTextureParameterfv({0}, {1}, {2})", texture, pname, param);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTextureParameteri.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void TextureParameter(UInt32 texture, int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTextureParameteri != null, "pglTextureParameteri not implemented");
			Delegates.pglTextureParameteri(texture, pname, param);
			CallLog("glTextureParameteri({0}, {1}, {2})", texture, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTextureParameterIiv.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void TextureParameterIiv(UInt32 texture, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTextureParameterIiv != null, "pglTextureParameterIiv not implemented");
					Delegates.pglTextureParameterIiv(texture, pname, p_params);
					CallLog("glTextureParameterIiv({0}, {1}, {2})", texture, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTextureParameterIuiv.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void TextureParameterIuiv(UInt32 texture, int pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTextureParameterIuiv != null, "pglTextureParameterIuiv not implemented");
					Delegates.pglTextureParameterIuiv(texture, pname, p_params);
					CallLog("glTextureParameterIuiv({0}, {1}, {2})", texture, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTextureParameteriv.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void TextureParameter(UInt32 texture, int pname, Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglTextureParameteriv != null, "pglTextureParameteriv not implemented");
					Delegates.pglTextureParameteriv(texture, pname, p_param);
					CallLog("glTextureParameteriv({0}, {1}, {2})", texture, pname, param);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// generate mipmaps for a specified texture object
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for glGenerateTextureMipmap. 
		/// </param>
		/// <remarks>
		/// glGenerateMipmap and glGenerateTextureMipmap generates mipmaps for the specified texture object. For glGenerateMipmap, 
		/// thetexture object is that bound to to target. For glGenerateTextureMipmap, texture is the name of the texture object. 
		/// For cube map and cube map array textures, the texture object must be cube complete or cube array complete respectively. 
		/// Mipmap generation replaces texel image levels $level_{base} + 1$ through $q$ with images derived from the $level_{base}$ 
		/// image,regardless of their previous contents. All other mimap images, including the $level_{base}+1$ image, are left 
		/// unchangedby this computation. 
		/// The internal formats of the derived mipmap images all match those of the $level_{base}$ image. The contents of the 
		/// derivedimages are computed by repeated, filtered reduction of the $level_{base} + 1$ image. For one- and two-dimensional 
		/// arrayand cube map array textures, each layer is filtered independently. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glGenerateMipmap if target is not one of the accepted texture targets. 
		/// - GL_INVALID_OPERATION is generated by glGenerateTextureMipmap if texture is not the name of an existing texture object. 
		/// - GL_INVALID_OPERATION is generated if target is GL_TEXTURE_CUBE_MAP or GL_TEXTURE_CUBE_MAP_ARRAY, and the specified 
		///   textureobject is not cube complete or cube array complete, respectively. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.GenTextures"/>
		public static void GenerateTextureMipmap(UInt32 texture)
		{
			Debug.Assert(Delegates.pglGenerateTextureMipmap != null, "pglGenerateTextureMipmap not implemented");
			Delegates.pglGenerateTextureMipmap(texture);
			CallLog("glGenerateTextureMipmap({0})", texture);
			DebugCheckErrors();
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
		/// <remarks>
		/// glBindTextureUnit binds an existing texture object to the texture unit numbered unit. 
		/// texture must be zero or the name of an existing texture object. When texture is the name of an existing texture object, 
		/// thatobject is bound to the target, in the corresponding texture unit, that was specified when the object was created. 
		/// Whentexture is zero, each of the targets enumerated at the beginning of this section is reset to its default texture for 
		/// thecorresponding texture image unit. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION error is generated if texture is not zero or the name of an existing texture object. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_TEXTURE_BINDING_1D, GL_TEXTURE_BINDING_2D, GL_TEXTURE_BINDING_3D, GL_TEXTURE_BINDING_1D_ARRAY, 
		///   GL_TEXTURE_BINDING_2D_ARRAY,GL_TEXTURE_BINDING_RECTANGLE, GL_TEXTURE_BINDING_BUFFER, GL_TEXTURE_BINDING_CUBE_MAP, 
		///   GL_TEXTURE_BINDING_CUBE_MAP_ARRAY,GL_TEXTURE_BINDING_2D_MULTISAMPLE or GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY. 
		/// </para>
		/// </remarks>
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
		public static void BindTextureUnit(UInt32 unit, UInt32 texture)
		{
			Debug.Assert(Delegates.pglBindTextureUnit != null, "pglBindTextureUnit not implemented");
			Delegates.pglBindTextureUnit(unit, texture);
			CallLog("glBindTextureUnit({0}, {1})", unit, texture);
			DebugCheckErrors();
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void GetTextureImage(UInt32 texture, Int32 level, int format, int type, Int32 bufSize, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetTextureImage != null, "pglGetTextureImage not implemented");
			Delegates.pglGetTextureImage(texture, level, format, type, bufSize, pixels);
			CallLog("glGetTextureImage({0}, {1}, {2}, {3}, {4}, {5})", texture, level, format, type, bufSize, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// return a compressed texture image
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for glGetCompressedTextureImage function. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level $n$ is the $n$-th 
		/// mipmapreduction image. 
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer pixels for glGetCompressedTextureImage and glGetnCompressedTexImage functions. 
		/// </param>
		/// <param name="pixels">
		/// Returns the compressed texture image. 
		/// </param>
		/// <remarks>
		/// glGetCompressedTexImage and glGetnCompressedTexImage return the compressed texture image associated with target and lod 
		/// intopixels. glGetCompressedTextureImage serves the same purpose, but instead of taking a texture target, it takes the ID 
		/// ofthe texture object. pixels should be an array of bufSize bytes for glGetnCompresedTexImage and 
		/// glGetCompressedTextureImagefunctions, and of GL_TEXTURE_COMPRESSED_IMAGE_SIZE bytes in case of glGetCompressedTexImage. 
		/// Ifthe actual data takes less space than bufSize, the remaining bytes will not be touched. target specifies the texture 
		/// target,to which the texture the data the function should extract the data from is bound to. lod specifies the 
		/// level-of-detailnumber of the desired image. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_PACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isrequested, pixels is treated as a byte offset into the buffer object's data store. 
		/// To minimize errors, first verify that the texture is compressed by calling glGetTexLevelParameter with argument 
		/// GL_TEXTURE_COMPRESSED.If the texture is compressed, you can determine the amount of memory required to store the 
		/// compressedtexture by calling glGetTexLevelParameter with argument GL_TEXTURE_COMPRESSED_IMAGE_SIZE. Finally, retrieve 
		/// theinternal format of the texture by calling glGetTexLevelParameter with argument GL_TEXTURE_INTERNAL_FORMAT. To store 
		/// thetexture for later use, associate the internal format and size with the retrieved texture image. These data can be 
		/// usedby the respective texture or subtexture loading routine used for loading target textures. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glGetCompressedTextureImage if texture is not the name of an existing texture 
		///   object.
		/// - GL_INVALID_VALUE is generated if level is less than zero or greater than the maximum number of LODs permitted by the 
		///   implementation.
		/// - GL_INVALID_OPERATION is generated if glGetCompressedTexImage, glGetnCompressedTexImage, and glGetCompressedTextureImage 
		///   isused to retrieve a texture that is in an uncompressed internal format. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_PACK_BUFFER target, the 
		///   bufferstorage was not initialized with glBufferStorage using GL_MAP_PERSISTENT_BIT flag, and the buffer object's data 
		///   storeis currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_PACK_BUFFER target and the 
		///   datawould be packed to the buffer object such that the memory writes required would exceed the data store size. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexLevelParameter with argument GL_TEXTURE_COMPRESSED 
		/// - glGetTexLevelParameter with argument GL_TEXTURE_COMPRESSED_IMAGE_SIZE 
		/// - glGetTexLevelParameter with argument GL_TEXTURE_INTERNAL_FORMAT 
		/// - glGet with argument GL_PIXEL_PACK_BUFFER_BINDING 
		/// </para>
		/// </remarks>
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
		public static void GetCompressedTextureImage(UInt32 texture, Int32 level, Int32 bufSize, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetCompressedTextureImage != null, "pglGetCompressedTextureImage not implemented");
			Delegates.pglGetCompressedTextureImage(texture, level, bufSize, pixels);
			CallLog("glGetCompressedTextureImage({0}, {1}, {2}, {3})", texture, level, bufSize, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values for a specific level of detail
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for glGetTextureLevelParameterfv and glGetTextureLevelParameteriv functions. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reductionimage. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, 
		/// GL_TEXTURE_INTERNAL_FORMAT,GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, 
		/// GL_TEXTURE_DEPTH_SIZE,GL_TEXTURE_COMPRESSED, GL_TEXTURE_COMPRESSED_IMAGE_SIZE, and GL_TEXTURE_BUFFER_OFFSET are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// glGetTexLevelParameterfv, glGetTexLevelParameteriv, glGetTextureLevelParameterfv and glGetTextureLevelParameteriv return 
		/// inparams texture parameter values for a specific level-of-detail value, specified as level. For the first two functions, 
		/// targetdefines the target texture, either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_PROXY_TEXTURE_1D, 
		/// GL_PROXY_TEXTURE_2D,GL_PROXY_TEXTURE_3D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_Y,GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Z,or GL_PROXY_TEXTURE_CUBE_MAP. The remaining two take a texture argument which specifies 
		/// thename of the texture object. 
		/// GL_MAX_TEXTURE_SIZE, and GL_MAX_3D_TEXTURE_SIZE are not really descriptive enough. It has to report the largest square 
		/// textureimage that can be accommodated with mipmaps but a long skinny texture, or a texture without mipmaps may easily 
		/// fitin texture memory. The proxy targets allow the user to more accurately query whether the GL can accommodate a texture 
		/// ofa given configuration. If the texture cannot be accommodated, the texture state variables, which may be queried with 
		/// glGetTexLevelParameterand glGetTextureLevelParameter, are set to 0. If the texture can be accommodated, the texture 
		/// statevalues will be set as they would be set for a non-proxy target. 
		/// pname specifies the texture parameter whose value or values will be returned. 
		/// The accepted parameter names are as follows: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glGetTextureLevelParameterfv and glGetTextureLevelParameteriv functions if texture 
		///   isnot the name of an existing texture object. 
		/// - GL_INVALID_ENUM is generated by glGetTexLevelParameterfv and glGetTexLevelParameteriv functions if target or pname is 
		///   notan accepted value. 
		/// - GL_INVALID_VALUE is generated if level is less than 0. 
		/// - GL_INVALID_VALUE may be generated if level is greater than log2max, where max is the returned value of 
		///   GL_MAX_TEXTURE_SIZE.
		/// - GL_INVALID_VALUE is generated if target is GL_TEXTURE_BUFFER and level is not zero. 
		/// - GL_INVALID_OPERATION is generated if GL_TEXTURE_COMPRESSED_IMAGE_SIZE is queried on texture images with an uncompressed 
		///   internalformat or on proxy targets. 
		/// </para>
		/// </remarks>
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
		public static void GetTextureLevelParameter(UInt32 texture, Int32 level, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTextureLevelParameterfv != null, "pglGetTextureLevelParameterfv not implemented");
					Delegates.pglGetTextureLevelParameterfv(texture, level, pname, p_params);
					CallLog("glGetTextureLevelParameterfv({0}, {1}, {2}, {3})", texture, level, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values for a specific level of detail
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for glGetTextureLevelParameterfv and glGetTextureLevelParameteriv functions. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reductionimage. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, 
		/// GL_TEXTURE_INTERNAL_FORMAT,GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, 
		/// GL_TEXTURE_DEPTH_SIZE,GL_TEXTURE_COMPRESSED, GL_TEXTURE_COMPRESSED_IMAGE_SIZE, and GL_TEXTURE_BUFFER_OFFSET are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetTexLevelParameterfv, glGetTexLevelParameteriv, glGetTextureLevelParameterfv and glGetTextureLevelParameteriv return 
		/// inparams texture parameter values for a specific level-of-detail value, specified as level. For the first two functions, 
		/// targetdefines the target texture, either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_PROXY_TEXTURE_1D, 
		/// GL_PROXY_TEXTURE_2D,GL_PROXY_TEXTURE_3D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_Y,GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Z,or GL_PROXY_TEXTURE_CUBE_MAP. The remaining two take a texture argument which specifies 
		/// thename of the texture object. 
		/// GL_MAX_TEXTURE_SIZE, and GL_MAX_3D_TEXTURE_SIZE are not really descriptive enough. It has to report the largest square 
		/// textureimage that can be accommodated with mipmaps but a long skinny texture, or a texture without mipmaps may easily 
		/// fitin texture memory. The proxy targets allow the user to more accurately query whether the GL can accommodate a texture 
		/// ofa given configuration. If the texture cannot be accommodated, the texture state variables, which may be queried with 
		/// glGetTexLevelParameterand glGetTextureLevelParameter, are set to 0. If the texture can be accommodated, the texture 
		/// statevalues will be set as they would be set for a non-proxy target. 
		/// pname specifies the texture parameter whose value or values will be returned. 
		/// The accepted parameter names are as follows: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glGetTextureLevelParameterfv and glGetTextureLevelParameteriv functions if texture 
		///   isnot the name of an existing texture object. 
		/// - GL_INVALID_ENUM is generated by glGetTexLevelParameterfv and glGetTexLevelParameteriv functions if target or pname is 
		///   notan accepted value. 
		/// - GL_INVALID_VALUE is generated if level is less than 0. 
		/// - GL_INVALID_VALUE may be generated if level is greater than log2max, where max is the returned value of 
		///   GL_MAX_TEXTURE_SIZE.
		/// - GL_INVALID_VALUE is generated if target is GL_TEXTURE_BUFFER and level is not zero. 
		/// - GL_INVALID_OPERATION is generated if GL_TEXTURE_COMPRESSED_IMAGE_SIZE is queried on texture images with an uncompressed 
		///   internalformat or on proxy targets. 
		/// </para>
		/// </remarks>
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
		public static void GetTextureLevelParameter(UInt32 texture, Int32 level, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTextureLevelParameteriv != null, "pglGetTextureLevelParameteriv not implemented");
					Delegates.pglGetTextureLevelParameteriv(texture, level, pname, p_params);
					CallLog("glGetTextureLevelParameteriv({0}, {1}, {2}, {3})", texture, level, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for glGetTextureParameterfv, glGetTextureParameteriv, glGetTextureParameterIiv, and 
		/// glGetTextureParameterIuivfunctions. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// GL_TEXTURE_BASE_LEVEL,GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, 
		/// GL_TEXTURE_IMMUTABLE_FORMAT,GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, 
		/// GL_TEXTURE_MAX_LEVEL,GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, 
		/// GL_TEXTURE_SWIZZLE_G,GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_TARGET, 
		/// GL_TEXTURE_VIEW_MIN_LAYER,GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, 
		/// GL_TEXTURE_WRAP_S,GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// glGetTexParameter and glGetTextureParameter return in params the value or values of the texture parameter specified as 
		/// pname.target defines the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D_ARRAY,GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, or 
		/// GL_TEXTURE_2D_MULTISAMPLE_ARRAYspecify one-, two-, or three-dimensional, one-dimensional array, two-dimensional array, 
		/// rectangle,cube-mapped or cube-mapped array, two-dimensional multisample, or two-dimensional multisample array texturing, 
		/// respectively.pname accepts the same symbols as glTexParameter, with the same interpretations: 
		/// In addition to the parameters that may be set with glTexParameter, glGetTexParameter and glGetTextureParameter accept 
		/// thefollowing read-only parameters: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_ENUM error is generated by glGetTexParameter if the effective target is not one of the accepted texture 
		///   targets.
		/// - GL_INVALID_OPERATION is generated by glGetTextureParameter* if texture is not the name of an existing texture object. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TextureParameter"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TextureStorage1D"/>
		/// <seealso cref="Gl.TextureStorage2D"/>
		/// <seealso cref="Gl.TextureStorage3D"/>
		/// <seealso cref="Gl.TextureView"/>
		public static void GetTextureParameter(UInt32 texture, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTextureParameterfv != null, "pglGetTextureParameterfv not implemented");
					Delegates.pglGetTextureParameterfv(texture, pname, p_params);
					CallLog("glGetTextureParameterfv({0}, {1}, {2})", texture, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for glGetTextureParameterfv, glGetTextureParameteriv, glGetTextureParameterIiv, and 
		/// glGetTextureParameterIuivfunctions. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// GL_TEXTURE_BASE_LEVEL,GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, 
		/// GL_TEXTURE_IMMUTABLE_FORMAT,GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, 
		/// GL_TEXTURE_MAX_LEVEL,GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, 
		/// GL_TEXTURE_SWIZZLE_G,GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_TARGET, 
		/// GL_TEXTURE_VIEW_MIN_LAYER,GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, 
		/// GL_TEXTURE_WRAP_S,GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetTexParameter and glGetTextureParameter return in params the value or values of the texture parameter specified as 
		/// pname.target defines the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D_ARRAY,GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, or 
		/// GL_TEXTURE_2D_MULTISAMPLE_ARRAYspecify one-, two-, or three-dimensional, one-dimensional array, two-dimensional array, 
		/// rectangle,cube-mapped or cube-mapped array, two-dimensional multisample, or two-dimensional multisample array texturing, 
		/// respectively.pname accepts the same symbols as glTexParameter, with the same interpretations: 
		/// In addition to the parameters that may be set with glTexParameter, glGetTexParameter and glGetTextureParameter accept 
		/// thefollowing read-only parameters: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_ENUM error is generated by glGetTexParameter if the effective target is not one of the accepted texture 
		///   targets.
		/// - GL_INVALID_OPERATION is generated by glGetTextureParameter* if texture is not the name of an existing texture object. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TextureParameter"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TextureStorage1D"/>
		/// <seealso cref="Gl.TextureStorage2D"/>
		/// <seealso cref="Gl.TextureStorage3D"/>
		/// <seealso cref="Gl.TextureView"/>
		public static void GetTextureParameterIiv(UInt32 texture, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTextureParameterIiv != null, "pglGetTextureParameterIiv not implemented");
					Delegates.pglGetTextureParameterIiv(texture, pname, p_params);
					CallLog("glGetTextureParameterIiv({0}, {1}, {2})", texture, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for glGetTextureParameterfv, glGetTextureParameteriv, glGetTextureParameterIiv, and 
		/// glGetTextureParameterIuivfunctions. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// GL_TEXTURE_BASE_LEVEL,GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, 
		/// GL_TEXTURE_IMMUTABLE_FORMAT,GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, 
		/// GL_TEXTURE_MAX_LEVEL,GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, 
		/// GL_TEXTURE_SWIZZLE_G,GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_TARGET, 
		/// GL_TEXTURE_VIEW_MIN_LAYER,GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, 
		/// GL_TEXTURE_WRAP_S,GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetTexParameter and glGetTextureParameter return in params the value or values of the texture parameter specified as 
		/// pname.target defines the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D_ARRAY,GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, or 
		/// GL_TEXTURE_2D_MULTISAMPLE_ARRAYspecify one-, two-, or three-dimensional, one-dimensional array, two-dimensional array, 
		/// rectangle,cube-mapped or cube-mapped array, two-dimensional multisample, or two-dimensional multisample array texturing, 
		/// respectively.pname accepts the same symbols as glTexParameter, with the same interpretations: 
		/// In addition to the parameters that may be set with glTexParameter, glGetTexParameter and glGetTextureParameter accept 
		/// thefollowing read-only parameters: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_ENUM error is generated by glGetTexParameter if the effective target is not one of the accepted texture 
		///   targets.
		/// - GL_INVALID_OPERATION is generated by glGetTextureParameter* if texture is not the name of an existing texture object. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TextureParameter"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TextureStorage1D"/>
		/// <seealso cref="Gl.TextureStorage2D"/>
		/// <seealso cref="Gl.TextureStorage3D"/>
		/// <seealso cref="Gl.TextureView"/>
		public static void GetTextureParameterIuiv(UInt32 texture, int pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTextureParameterIuiv != null, "pglGetTextureParameterIuiv not implemented");
					Delegates.pglGetTextureParameterIuiv(texture, pname, p_params);
					CallLog("glGetTextureParameterIuiv({0}, {1}, {2})", texture, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="texture">
		/// Specifies the texture object name for glGetTextureParameterfv, glGetTextureParameteriv, glGetTextureParameterIiv, and 
		/// glGetTextureParameterIuivfunctions. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// GL_TEXTURE_BASE_LEVEL,GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, 
		/// GL_TEXTURE_IMMUTABLE_FORMAT,GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, 
		/// GL_TEXTURE_MAX_LEVEL,GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, 
		/// GL_TEXTURE_SWIZZLE_G,GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_TARGET, 
		/// GL_TEXTURE_VIEW_MIN_LAYER,GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, 
		/// GL_TEXTURE_WRAP_S,GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetTexParameter and glGetTextureParameter return in params the value or values of the texture parameter specified as 
		/// pname.target defines the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D_ARRAY,GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, or 
		/// GL_TEXTURE_2D_MULTISAMPLE_ARRAYspecify one-, two-, or three-dimensional, one-dimensional array, two-dimensional array, 
		/// rectangle,cube-mapped or cube-mapped array, two-dimensional multisample, or two-dimensional multisample array texturing, 
		/// respectively.pname accepts the same symbols as glTexParameter, with the same interpretations: 
		/// In addition to the parameters that may be set with glTexParameter, glGetTexParameter and glGetTextureParameter accept 
		/// thefollowing read-only parameters: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_ENUM error is generated by glGetTexParameter if the effective target is not one of the accepted texture 
		///   targets.
		/// - GL_INVALID_OPERATION is generated by glGetTextureParameter* if texture is not the name of an existing texture object. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TextureParameter"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TextureStorage1D"/>
		/// <seealso cref="Gl.TextureStorage2D"/>
		/// <seealso cref="Gl.TextureStorage3D"/>
		/// <seealso cref="Gl.TextureView"/>
		public static void GetTextureParameter(UInt32 texture, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTextureParameteriv != null, "pglGetTextureParameteriv not implemented");
					Delegates.pglGetTextureParameteriv(texture, pname, p_params);
					CallLog("glGetTextureParameteriv({0}, {1}, {2})", texture, pname, @params);
				}
			}
			DebugCheckErrors();
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
		/// <remarks>
		/// glCreateVertexArrays returns n previously unused vertex array object names in arrays, each representing a new vertex 
		/// arrayobject initialized to the default state. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if n is negative. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindVertexArray"/>
		/// <seealso cref="Gl.DeleteVertexArrays"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.GenVertexArrays"/>
		/// <seealso cref="Gl.IsVertexArray"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void CreateVertexArrays(Int32 n, UInt32[] arrays)
		{
			unsafe {
				fixed (UInt32* p_arrays = arrays)
				{
					Debug.Assert(Delegates.pglCreateVertexArrays != null, "pglCreateVertexArrays not implemented");
					Delegates.pglCreateVertexArrays(n, p_arrays);
					CallLog("glCreateVertexArrays({0}, {1})", n, arrays);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Enable or disable a generic vertex attribute array
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of the vertex array object for glDisableVertexArrayAttrib and glEnableVertexArrayAttrib functions. 
		/// </param>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be enabled or disabled. 
		/// </param>
		/// <remarks>
		/// glEnableVertexAttribArray and glEnableVertexArrayAttrib enable the generic vertex attribute array specified by index. 
		/// glEnableVertexAttribArrayuses currently bound vertex array object for the operation, whereas glEnableVertexArrayAttrib 
		/// updatesstate of the vertex array object with ID vaobj. 
		/// glDisableVertexAttribArray and glDisableVertexArrayAttrib disable the generic vertex attribute array specified by index. 
		/// glDisableVertexAttribArrayuses currently bound vertex array object for the operation, whereas glDisableVertexArrayAttrib 
		/// updatesstate of the vertex array object with ID vaobj. 
		/// By default, all client-side capabilities are disabled, including all generic vertex attribute arrays. If enabled, the 
		/// valuesin the generic vertex attribute array will be accessed and used for rendering when calls are made to vertex array 
		/// commandssuch as glDrawArrays, glDrawElements, glDrawRangeElements, glMultiDrawElements, or glMultiDrawArrays. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glEnableVertexAttribArray and glDisableVertexAttribArray if no vertex array object 
		///   isbound. 
		/// - GL_INVALID_OPERATION is generated by glEnableVertexArrayAttrib and glDisableVertexArrayAttrib if vaobj is not the name 
		///   ofan existing vertex array object. 
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_VERTEX_ATTRIBS 
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_ENABLED 
		/// - glGetVertexAttribPointerv with arguments index and GL_VERTEX_ATTRIB_ARRAY_POINTER 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void DisableVertexArrayAttrib(UInt32 vaobj, UInt32 index)
		{
			Debug.Assert(Delegates.pglDisableVertexArrayAttrib != null, "pglDisableVertexArrayAttrib not implemented");
			Delegates.pglDisableVertexArrayAttrib(vaobj, index);
			CallLog("glDisableVertexArrayAttrib({0}, {1})", vaobj, index);
			DebugCheckErrors();
		}

		/// <summary>
		/// Enable or disable a generic vertex attribute array
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of the vertex array object for glDisableVertexArrayAttrib and glEnableVertexArrayAttrib functions. 
		/// </param>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be enabled or disabled. 
		/// </param>
		/// <remarks>
		/// glEnableVertexAttribArray and glEnableVertexArrayAttrib enable the generic vertex attribute array specified by index. 
		/// glEnableVertexAttribArrayuses currently bound vertex array object for the operation, whereas glEnableVertexArrayAttrib 
		/// updatesstate of the vertex array object with ID vaobj. 
		/// glDisableVertexAttribArray and glDisableVertexArrayAttrib disable the generic vertex attribute array specified by index. 
		/// glDisableVertexAttribArrayuses currently bound vertex array object for the operation, whereas glDisableVertexArrayAttrib 
		/// updatesstate of the vertex array object with ID vaobj. 
		/// By default, all client-side capabilities are disabled, including all generic vertex attribute arrays. If enabled, the 
		/// valuesin the generic vertex attribute array will be accessed and used for rendering when calls are made to vertex array 
		/// commandssuch as glDrawArrays, glDrawElements, glDrawRangeElements, glMultiDrawElements, or glMultiDrawArrays. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glEnableVertexAttribArray and glDisableVertexAttribArray if no vertex array object 
		///   isbound. 
		/// - GL_INVALID_OPERATION is generated by glEnableVertexArrayAttrib and glDisableVertexArrayAttrib if vaobj is not the name 
		///   ofan existing vertex array object. 
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_VERTEX_ATTRIBS 
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_ENABLED 
		/// - glGetVertexAttribPointerv with arguments index and GL_VERTEX_ATTRIB_ARRAY_POINTER 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void EnableVertexArrayAttrib(UInt32 vaobj, UInt32 index)
		{
			Debug.Assert(Delegates.pglEnableVertexArrayAttrib != null, "pglEnableVertexArrayAttrib not implemented");
			Delegates.pglEnableVertexArrayAttrib(vaobj, index);
			CallLog("glEnableVertexArrayAttrib({0}, {1})", vaobj, index);
			DebugCheckErrors();
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
		/// <remarks>
		/// glVertexArrayElementBuffer binds a buffer object with id buffer to the element array buffer bind point of a vertex array 
		/// objectwith id vaobj. If buffer is zero, any existing element array buffer binding to vaobj is removed. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION error is generated if vaobj is not the name of an existing vertex array object. 
		/// - GL_INVALID_OPERATION error is generated if buffer is not zero or the name of an existing buffer object. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_ELEMENT_ARRAY_BUFFER_BINDING. 
		/// - glGetVertexArrayiv with argument GL_ELEMENT_ARRAY_BUFFER_BINDING. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetVertexArrayiv"/>
		public static void VertexArrayElementBuffer(UInt32 vaobj, UInt32 buffer)
		{
			Debug.Assert(Delegates.pglVertexArrayElementBuffer != null, "pglVertexArrayElementBuffer not implemented");
			Delegates.pglVertexArrayElementBuffer(vaobj, buffer);
			CallLog("glVertexArrayElementBuffer({0}, {1})", vaobj, buffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// bind a buffer to a vertex buffer bind point
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of the vertex array object to be used by glVertexArrayVertexBuffer function. 
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
		/// <remarks>
		/// glBindVertexBuffer and glVertexArrayVertexBuffer bind the buffer named buffer to the vertex buffer binding point whose 
		/// indexis given by bindingindex. glBindVertexBuffer modifies the binding of the currently bound vertex array object, 
		/// whereasglVertexArrayVertexBuffer allows the caller to specify ID of the vertex array object with an argument named 
		/// vaobj,for which the binding should be modified. offset and stride specify the offset of the first element within the 
		/// bufferand the distance between elements within the buffer, respectively, and are both measured in basic machine units. 
		/// bindingindexmust be less than the value of GL_MAX_VERTEX_ATTRIB_BINDINGS. offset and stride must be greater than or 
		/// equalto zero. If buffer is zero, then any buffer currently bound to the specified binding point is unbound. 
		/// If buffer is not the name of an existing buffer object, the GL first creates a new state vector, initialized with a 
		/// zero-sizedmemory buffer and comprising all the state and with the same initial values as in case of glBindBuffer. buffer 
		/// isthen attached to the specified bindingindex of the vertex array object. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glBindVertexBuffer if no vertex array object is bound. 
		/// - GL_INVALID_OPERATION is generated by glVertexArrayVertexBuffer if vaobj is not the name of an existing vertex array 
		///   object.
		/// - GL_INVALID_VALUE is generated if bindingindex is greater than or equal to the value of GL_MAX_VERTEX_ATTRIB_BINDINGS. 
		/// - GL_INVALID_VALUE is generated if offset or stride is less than zero, or if stride is greater than the value of 
		///   GL_MAX_VERTEX_ATTRIB_STRIDE.
		/// - GL_INVALID_VALUE is generated if buffer is not zero or the name of an existing buffer object (as returned by 
		///   glGenBuffersor glCreateBuffers). 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_VERTEX_ATTRIB_BINDINGS. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribFormat"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		public static void VertexArrayVertexBuffer(UInt32 vaobj, UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride)
		{
			Debug.Assert(Delegates.pglVertexArrayVertexBuffer != null, "pglVertexArrayVertexBuffer not implemented");
			Delegates.pglVertexArrayVertexBuffer(vaobj, bindingindex, buffer, offset, stride);
			CallLog("glVertexArrayVertexBuffer({0}, {1}, {2}, {3}, {4})", vaobj, bindingindex, buffer, offset, stride);
			DebugCheckErrors();
		}

		/// <summary>
		/// attach multiple buffer objects to a vertex array object
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of the vertex array object for glVertexArrayVertexBuffers. 
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
		/// <remarks>
		/// glBindVertexBuffers and glVertexArrayVertexBuffers bind storage from an array of existing buffer objects to a specified 
		/// numberof consecutive vertex buffer binding points units in a vertex array object. For glBindVertexBuffers, the vertex 
		/// arrayobject is the currently bound vertex array object. For glVertexArrayVertexBuffers, vaobj is the name of the vertex 
		/// arrayobject. 
		/// count existing buffer objects are bound to vertex buffer binding points numbered $first$ through $first + count - 1$. If 
		/// buffersis not NULL, it specifies an array of count values, each of which must be zero or the name of an existing buffer 
		/// object.offsets and strides specify arrays of count values indicating the offset of the first element and stride between 
		/// elementsin each buffer, respectively. If buffers is NULL, each affected vertex buffer binding point from $first$ through 
		/// $first+ count - 1$ will be reset to have no bound buffer object. In this case, the offsets and strides associated with 
		/// thebinding points are set to default values, ignoring offsets and strides. 
		/// glBindVertexBuffers is equivalent (assuming no errors are generated) to: for (i = 0; i &lt; count; i++) { if (buffers == 
		/// NULL){ glBindVertexBuffer(first + i, 0, 0, 16); } else { glBindVertexBuffer(first + i, buffers[i], offsets[i], 
		/// strides[i]);} } except that buffers will not be created if they do not exist. 
		/// glVertexArrayVertexBuffers is equivalent to the pseudocode above, but replacing glBindVertexBuffers(args) with 
		/// glVertexArrayVertexBuffers(vaobj,args). 
		/// The values specified in buffers, offsets, and strides will be checked separately for each vertex buffer binding point. 
		/// Whena value for a specific vertex buffer binding point is invalid, the state for that binding point will be unchanged 
		/// andan error will be generated. However, state for other vertex buffer binding points will still be changed if their 
		/// correspondingvalues are valid. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glBindVertexBuffers if no vertex array object is bound. 
		/// - GL_INVALID_OPERATION is generated by glVertexArrayVertexBuffers if vaobj is not the name of the vertex array object. 
		/// - GL_INVALID_OPERATION is generated if $first + count$ is greater than the value of GL_MAX_VERTEX_ATTRIB_BINDINGS. 
		/// - GL_INVALID_OPERATION is generated if any value in buffers is not zero or the name of an existing buffer object. 
		/// - GL_INVALID_VALUE is generated if any value in offsets or strides is negative, or if a value is stride is greater than 
		///   thevalue of GL_MAX_VERTEX_ATTRIB_STRIDE. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.DeleteTextures"/>
		public static void VertexArrayVertexBuffers(UInt32 vaobj, UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, Int32[] strides)
		{
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				fixed (IntPtr* p_offsets = offsets)
				fixed (Int32* p_strides = strides)
				{
					Debug.Assert(Delegates.pglVertexArrayVertexBuffers != null, "pglVertexArrayVertexBuffers not implemented");
					Delegates.pglVertexArrayVertexBuffers(vaobj, first, count, p_buffers, p_offsets, p_strides);
					CallLog("glVertexArrayVertexBuffers({0}, {1}, {2}, {3}, {4}, {5})", vaobj, first, count, buffers, offsets, strides);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// associate a vertex attribute and a vertex buffer binding for a vertex array object
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of the vertex array object for glVertexArrayAttribBinding. 
		/// </param>
		/// <param name="attribindex">
		/// The index of the attribute to associate with a vertex buffer binding. 
		/// </param>
		/// <param name="bindingindex">
		/// The index of the vertex buffer binding with which to associate the generic vertex attribute. 
		/// </param>
		/// <remarks>
		/// glVertexAttribBinding and glVertexArrayAttribBinding establishes an association between the generic vertex attribute of 
		/// avertex array object whose index is given by attribindex, and a vertex buffer binding whose index is given by 
		/// bindingindex.For glVertexAttribBinding, the vertex array object affected is that currently bound. For 
		/// glVertexArrayAttribBinding,vaobj is the name of the vertex array object. 
		/// attribindex must be less than the value of GL_MAX_VERTEX_ATTRIBS and bindingindex must be less than the value of 
		/// GL_MAX_VERTEX_ATTRIB_BINDINGS.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glVertexAttribBinding if no vertex array object is bound. 
		/// - GL_INVALID_OPERATION is generated by glVertexArrayAttribBinding if vaobj is not the name of an existing vertex array 
		///   object.
		/// - GL_INVALID_VALUE is generated if attribindex is greater than or equal to the value of GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_VALUE is generated if bindingindex is greater than or equal to the value of GL_MAX_VERTEX_ATTRIB_BINDINGS. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with arguments GL_MAX_VERTEX_ATTRIB_BINDINGS, GL_VERTEX_BINDING_DIVISOR. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindVertexBuffer"/>
		/// <seealso cref="Gl.VertexAttribFormat"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexArrayAttribBinding(UInt32 vaobj, UInt32 attribindex, UInt32 bindingindex)
		{
			Debug.Assert(Delegates.pglVertexArrayAttribBinding != null, "pglVertexArrayAttribBinding not implemented");
			Delegates.pglVertexArrayAttribBinding(vaobj, attribindex, bindingindex);
			CallLog("glVertexArrayAttribBinding({0}, {1}, {2})", vaobj, attribindex, bindingindex);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the organization of vertex arrays
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of the vertex array object for glVertexArrayAttrib{I, L}Format functions. 
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
		/// The distance between elements within the buffer. 
		/// </param>
		/// <param name="relativeoffset">
		/// The distance between elements within the buffer. 
		/// </param>
		/// <remarks>
		/// glVertexAttribFormat, glVertexAttribIFormat and glVertexAttribLFormat, as well as glVertexArrayAttribFormat, 
		/// glVertexArrayAttribIFormatand glVertexArrayAttribLFormat specify the organization of data in vertex arrays. The first 
		/// threecalls operate on the bound vertex array object, whereas the last three ones modify the state of a vertex array 
		/// objectwith ID vaobj. attribindex specifies the index of the generic vertex attribute array whose data layout is being 
		/// described,and must be less than the value of GL_MAX_VERTEX_ATTRIBS. 
		/// size determines the number of components per vertex are allocated to the specified attribute and must be 1, 2, 3 or 4. 
		/// typeindicates the type of the data. If type is one of GL_BYTE, GL_SHORT, GL_INT, GL_FIXED, GL_FLOAT, GL_HALF_FLOAT, and 
		/// GL_DOUBLEindicate types GLbyte, GLshort, GLint, GLfixed, GLfloat, GLhalf, and GLdouble, respectively; the values 
		/// GL_UNSIGNED_BYTE,GL_UNSIGNED_SHORT, and GL_UNSIGNED_INT indicate types GLubyte, GLushort, and GLuint, respectively; the 
		/// valuesGL_INT_2_10_10_10_REV and GL_UNSIGNED_INT_2_10_10_10_REV indicating respectively four signed or unsigned elements 
		/// packedinto a single GLuint; and the value GL_UNSIGNED_INT_10F_11F_11F_REV indicating three floating point values packed 
		/// intoa single GLuint. 
		/// glVertexAttribLFormat and glVertexArrayAttribLFormat is used to specify layout for data associated with a generic 
		/// attributevariable declared as 64-bit double precision components. For glVertexAttribLFormat and 
		/// glVertexArrayAttribLFormat,type must be GL_DOUBLE. In contrast to glVertexAttribFormat or glVertexArrayAttribFormat, 
		/// whichwill cause data declared as GL_DOUBLE to be converted to 32-bit representation, glVertexAttribLFormat and 
		/// glVertexArrayAttribLFormatcause such data to be left in its natural, 64-bit representation. 
		/// For glVertexAttribFormat and glVertexArrayAttribFormat, if normalized is GL_TRUE, then integer data is normalized to the 
		/// range[-1, 1] or [0, 1] if it is signed or unsigned, respectively. If normalized is GL_FALSE then integer data is 
		/// directlyconverted to floating point. 
		/// relativeoffset is the offset, measured in basic machine units of the first element relative to the start of the vertex 
		/// bufferbinding this attribute fetches from. 
		/// glVertexAttribFormat and glVertexArrayAttribFormat should be used to describe vertex attribute layout for floating-point 
		/// vertexattributes, glVertexAttribIFormat and glVertexArrayAttribIFormat should be used to describe vertex attribute 
		/// layoutfor integer vertex attribute, and glVertexAttribLFormat and glVertexArrayAttribLFormat should be used to describe 
		/// thelayout for 64-bit vertex attributes. Data for an array specified by glVertexAttribIFormat and 
		/// glVertexArrayAttribIFormatwill always be left as integer values; such data are referred to as pure integers. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if attribindex is greater than or equal to the value of GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_VALUE is generated if size is not one of the accepted values. 
		/// - GL_INVALID_VALUE is generated if relativeoffset is greater than the value of GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET. 
		/// - GL_INVALID_ENUM is generated if type is not one of the accepted tokens. 
		/// - GL_INVALID_ENUM is generated by glVertexAttribIFormat, glVertexAttribLFormat, glVertexArrayAttribIFormat and 
		///   glVertexArrayAttribLFormatif type is GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_OPERATION is generated by glVertexAttribFormat, glVertexAttribIFormat and glVertexAttribLFormat if no vertex 
		///   arrayobject is bound. 
		/// - GL_INVALID_OPERATION is generated by glVertexArrayAttribFormat, glVertexArrayAttribIFormat and 
		///   glVertexArrayAttribLFormatif vaobj is not the name of an existing vertex array object. 
		/// - GL_INVALID_OPERATION is generated under any of the following conditions: 
		/// - size is GL_BGRA and type is not GL_UNSIGNED_BYTE, GL_INT_2_10_10_10_REV or GL_UNSIGNED_INT_2_10_10_10_REV.type is 
		///   GL_INT_2_10_10_10_REVor GL_UNSIGNED_INT_2_10_10_10_REV, and size is neither 4 nor GL_BGRA.type is 
		///   GL_UNSIGNED_INT_10F_11F_11F_REVand size is not 3.size is GL_BGRA and normalized is GL_FALSE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with arguments GL_MAX_VERTEX_ATTRIB_BINDINGS, or GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET. 
		/// - glGetVertexAttrib with argument GL_VERTEX_ATTRIB_RELATIVE_OFFSET. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindVertexBuffer"/>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexArrayAttribFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, int type, bool normalized, UInt32 relativeoffset)
		{
			Debug.Assert(Delegates.pglVertexArrayAttribFormat != null, "pglVertexArrayAttribFormat not implemented");
			Delegates.pglVertexArrayAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);
			CallLog("glVertexArrayAttribFormat({0}, {1}, {2}, {3}, {4}, {5})", vaobj, attribindex, size, type, normalized, relativeoffset);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the organization of vertex arrays
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of the vertex array object for glVertexArrayAttrib{I, L}Format functions. 
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
		/// <remarks>
		/// glVertexAttribFormat, glVertexAttribIFormat and glVertexAttribLFormat, as well as glVertexArrayAttribFormat, 
		/// glVertexArrayAttribIFormatand glVertexArrayAttribLFormat specify the organization of data in vertex arrays. The first 
		/// threecalls operate on the bound vertex array object, whereas the last three ones modify the state of a vertex array 
		/// objectwith ID vaobj. attribindex specifies the index of the generic vertex attribute array whose data layout is being 
		/// described,and must be less than the value of GL_MAX_VERTEX_ATTRIBS. 
		/// size determines the number of components per vertex are allocated to the specified attribute and must be 1, 2, 3 or 4. 
		/// typeindicates the type of the data. If type is one of GL_BYTE, GL_SHORT, GL_INT, GL_FIXED, GL_FLOAT, GL_HALF_FLOAT, and 
		/// GL_DOUBLEindicate types GLbyte, GLshort, GLint, GLfixed, GLfloat, GLhalf, and GLdouble, respectively; the values 
		/// GL_UNSIGNED_BYTE,GL_UNSIGNED_SHORT, and GL_UNSIGNED_INT indicate types GLubyte, GLushort, and GLuint, respectively; the 
		/// valuesGL_INT_2_10_10_10_REV and GL_UNSIGNED_INT_2_10_10_10_REV indicating respectively four signed or unsigned elements 
		/// packedinto a single GLuint; and the value GL_UNSIGNED_INT_10F_11F_11F_REV indicating three floating point values packed 
		/// intoa single GLuint. 
		/// glVertexAttribLFormat and glVertexArrayAttribLFormat is used to specify layout for data associated with a generic 
		/// attributevariable declared as 64-bit double precision components. For glVertexAttribLFormat and 
		/// glVertexArrayAttribLFormat,type must be GL_DOUBLE. In contrast to glVertexAttribFormat or glVertexArrayAttribFormat, 
		/// whichwill cause data declared as GL_DOUBLE to be converted to 32-bit representation, glVertexAttribLFormat and 
		/// glVertexArrayAttribLFormatcause such data to be left in its natural, 64-bit representation. 
		/// For glVertexAttribFormat and glVertexArrayAttribFormat, if normalized is GL_TRUE, then integer data is normalized to the 
		/// range[-1, 1] or [0, 1] if it is signed or unsigned, respectively. If normalized is GL_FALSE then integer data is 
		/// directlyconverted to floating point. 
		/// relativeoffset is the offset, measured in basic machine units of the first element relative to the start of the vertex 
		/// bufferbinding this attribute fetches from. 
		/// glVertexAttribFormat and glVertexArrayAttribFormat should be used to describe vertex attribute layout for floating-point 
		/// vertexattributes, glVertexAttribIFormat and glVertexArrayAttribIFormat should be used to describe vertex attribute 
		/// layoutfor integer vertex attribute, and glVertexAttribLFormat and glVertexArrayAttribLFormat should be used to describe 
		/// thelayout for 64-bit vertex attributes. Data for an array specified by glVertexAttribIFormat and 
		/// glVertexArrayAttribIFormatwill always be left as integer values; such data are referred to as pure integers. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if attribindex is greater than or equal to the value of GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_VALUE is generated if size is not one of the accepted values. 
		/// - GL_INVALID_VALUE is generated if relativeoffset is greater than the value of GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET. 
		/// - GL_INVALID_ENUM is generated if type is not one of the accepted tokens. 
		/// - GL_INVALID_ENUM is generated by glVertexAttribIFormat, glVertexAttribLFormat, glVertexArrayAttribIFormat and 
		///   glVertexArrayAttribLFormatif type is GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_OPERATION is generated by glVertexAttribFormat, glVertexAttribIFormat and glVertexAttribLFormat if no vertex 
		///   arrayobject is bound. 
		/// - GL_INVALID_OPERATION is generated by glVertexArrayAttribFormat, glVertexArrayAttribIFormat and 
		///   glVertexArrayAttribLFormatif vaobj is not the name of an existing vertex array object. 
		/// - GL_INVALID_OPERATION is generated under any of the following conditions: 
		/// - size is GL_BGRA and type is not GL_UNSIGNED_BYTE, GL_INT_2_10_10_10_REV or GL_UNSIGNED_INT_2_10_10_10_REV.type is 
		///   GL_INT_2_10_10_10_REVor GL_UNSIGNED_INT_2_10_10_10_REV, and size is neither 4 nor GL_BGRA.type is 
		///   GL_UNSIGNED_INT_10F_11F_11F_REVand size is not 3.size is GL_BGRA and normalized is GL_FALSE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with arguments GL_MAX_VERTEX_ATTRIB_BINDINGS, or GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET. 
		/// - glGetVertexAttrib with argument GL_VERTEX_ATTRIB_RELATIVE_OFFSET. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindVertexBuffer"/>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexArrayAttribIFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, int type, UInt32 relativeoffset)
		{
			Debug.Assert(Delegates.pglVertexArrayAttribIFormat != null, "pglVertexArrayAttribIFormat not implemented");
			Delegates.pglVertexArrayAttribIFormat(vaobj, attribindex, size, type, relativeoffset);
			CallLog("glVertexArrayAttribIFormat({0}, {1}, {2}, {3}, {4})", vaobj, attribindex, size, type, relativeoffset);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the organization of vertex arrays
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of the vertex array object for glVertexArrayAttrib{I, L}Format functions. 
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
		/// <remarks>
		/// glVertexAttribFormat, glVertexAttribIFormat and glVertexAttribLFormat, as well as glVertexArrayAttribFormat, 
		/// glVertexArrayAttribIFormatand glVertexArrayAttribLFormat specify the organization of data in vertex arrays. The first 
		/// threecalls operate on the bound vertex array object, whereas the last three ones modify the state of a vertex array 
		/// objectwith ID vaobj. attribindex specifies the index of the generic vertex attribute array whose data layout is being 
		/// described,and must be less than the value of GL_MAX_VERTEX_ATTRIBS. 
		/// size determines the number of components per vertex are allocated to the specified attribute and must be 1, 2, 3 or 4. 
		/// typeindicates the type of the data. If type is one of GL_BYTE, GL_SHORT, GL_INT, GL_FIXED, GL_FLOAT, GL_HALF_FLOAT, and 
		/// GL_DOUBLEindicate types GLbyte, GLshort, GLint, GLfixed, GLfloat, GLhalf, and GLdouble, respectively; the values 
		/// GL_UNSIGNED_BYTE,GL_UNSIGNED_SHORT, and GL_UNSIGNED_INT indicate types GLubyte, GLushort, and GLuint, respectively; the 
		/// valuesGL_INT_2_10_10_10_REV and GL_UNSIGNED_INT_2_10_10_10_REV indicating respectively four signed or unsigned elements 
		/// packedinto a single GLuint; and the value GL_UNSIGNED_INT_10F_11F_11F_REV indicating three floating point values packed 
		/// intoa single GLuint. 
		/// glVertexAttribLFormat and glVertexArrayAttribLFormat is used to specify layout for data associated with a generic 
		/// attributevariable declared as 64-bit double precision components. For glVertexAttribLFormat and 
		/// glVertexArrayAttribLFormat,type must be GL_DOUBLE. In contrast to glVertexAttribFormat or glVertexArrayAttribFormat, 
		/// whichwill cause data declared as GL_DOUBLE to be converted to 32-bit representation, glVertexAttribLFormat and 
		/// glVertexArrayAttribLFormatcause such data to be left in its natural, 64-bit representation. 
		/// For glVertexAttribFormat and glVertexArrayAttribFormat, if normalized is GL_TRUE, then integer data is normalized to the 
		/// range[-1, 1] or [0, 1] if it is signed or unsigned, respectively. If normalized is GL_FALSE then integer data is 
		/// directlyconverted to floating point. 
		/// relativeoffset is the offset, measured in basic machine units of the first element relative to the start of the vertex 
		/// bufferbinding this attribute fetches from. 
		/// glVertexAttribFormat and glVertexArrayAttribFormat should be used to describe vertex attribute layout for floating-point 
		/// vertexattributes, glVertexAttribIFormat and glVertexArrayAttribIFormat should be used to describe vertex attribute 
		/// layoutfor integer vertex attribute, and glVertexAttribLFormat and glVertexArrayAttribLFormat should be used to describe 
		/// thelayout for 64-bit vertex attributes. Data for an array specified by glVertexAttribIFormat and 
		/// glVertexArrayAttribIFormatwill always be left as integer values; such data are referred to as pure integers. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if attribindex is greater than or equal to the value of GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_VALUE is generated if size is not one of the accepted values. 
		/// - GL_INVALID_VALUE is generated if relativeoffset is greater than the value of GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET. 
		/// - GL_INVALID_ENUM is generated if type is not one of the accepted tokens. 
		/// - GL_INVALID_ENUM is generated by glVertexAttribIFormat, glVertexAttribLFormat, glVertexArrayAttribIFormat and 
		///   glVertexArrayAttribLFormatif type is GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_OPERATION is generated by glVertexAttribFormat, glVertexAttribIFormat and glVertexAttribLFormat if no vertex 
		///   arrayobject is bound. 
		/// - GL_INVALID_OPERATION is generated by glVertexArrayAttribFormat, glVertexArrayAttribIFormat and 
		///   glVertexArrayAttribLFormatif vaobj is not the name of an existing vertex array object. 
		/// - GL_INVALID_OPERATION is generated under any of the following conditions: 
		/// - size is GL_BGRA and type is not GL_UNSIGNED_BYTE, GL_INT_2_10_10_10_REV or GL_UNSIGNED_INT_2_10_10_10_REV.type is 
		///   GL_INT_2_10_10_10_REVor GL_UNSIGNED_INT_2_10_10_10_REV, and size is neither 4 nor GL_BGRA.type is 
		///   GL_UNSIGNED_INT_10F_11F_11F_REVand size is not 3.size is GL_BGRA and normalized is GL_FALSE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with arguments GL_MAX_VERTEX_ATTRIB_BINDINGS, or GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET. 
		/// - glGetVertexAttrib with argument GL_VERTEX_ATTRIB_RELATIVE_OFFSET. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindVertexBuffer"/>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexArrayAttribLFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, int type, UInt32 relativeoffset)
		{
			Debug.Assert(Delegates.pglVertexArrayAttribLFormat != null, "pglVertexArrayAttribLFormat not implemented");
			Delegates.pglVertexArrayAttribLFormat(vaobj, attribindex, size, type, relativeoffset);
			CallLog("glVertexArrayAttribLFormat({0}, {1}, {2}, {3}, {4})", vaobj, attribindex, size, type, relativeoffset);
			DebugCheckErrors();
		}

		/// <summary>
		/// modify the rate at which generic vertex attributes advance
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of the vertex array object for glVertexArrayBindingDivisor function. 
		/// </param>
		/// <param name="bindingindex">
		/// The index of the binding whose divisor to modify. 
		/// </param>
		/// <param name="divisor">
		/// The new value for the instance step rate to apply. 
		/// </param>
		/// <remarks>
		/// glVertexBindingDivisor and glVertexArrayBindingDivisor modify the rate at which generic vertex attributes advance when 
		/// renderingmultiple instances of primitives in a single draw command. If divisor is zero, the attributes using the buffer 
		/// boundto bindingindex advance once per vertex. If divisor is non-zero, the attributes advance once per divisor instances 
		/// ofthe set(s) of vertices being rendered. An attribute is referred to as instanced if the corresponding divisor value is 
		/// non-zero.
		/// glVertexBindingDivisor uses currently bound vertex array object , whereas glVertexArrayBindingDivisor updates state of 
		/// thevertex array object with ID vaobj. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if bindingindex is greater than or equal to the value of GL_MAX_VERTEX_ATTRIB_BINDINGS. 
		/// - GL_INVALID_OPERATION by glVertexBindingDivisor is generated if no vertex array object is bound. 
		/// - GL_INVALID_OPERATION is generated by glVertexArrayBindingDivisor if vaobj is not the name of an existing vertex array 
		///   object.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with arguments GL_MAX_VERTEX_ATTRIB_BINDINGS, GL_VERTEX_BINDING_DIVISOR. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindVertexBuffer"/>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexBindingDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexArrayBindingDivisor(UInt32 vaobj, UInt32 bindingindex, UInt32 divisor)
		{
			Debug.Assert(Delegates.pglVertexArrayBindingDivisor != null, "pglVertexArrayBindingDivisor not implemented");
			Delegates.pglVertexArrayBindingDivisor(vaobj, bindingindex, divisor);
			CallLog("glVertexArrayBindingDivisor({0}, {1}, {2})", vaobj, bindingindex, divisor);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetVertexArrayiv.
		/// </summary>
		/// <param name="vaobj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void GetVertexArray(UInt32 vaobj, int pname, Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglGetVertexArrayiv != null, "pglGetVertexArrayiv not implemented");
					Delegates.pglGetVertexArrayiv(vaobj, pname, p_param);
					CallLog("glGetVertexArrayiv({0}, {1}, {2})", vaobj, pname, param);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve parameters of an attribute of a vertex array object
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of a vertex array object. 
		/// </param>
		/// <param name="index">
		/// Specifies the index of the vertex array object attribute. Must be a number between 0 and (GL_MAX_VERTEX_ATTRIBS - 1). 
		/// </param>
		/// <param name="pname">
		/// Specifies the property to be used for the query. For glGetVertexArrayIndexediv, it must be one of the following values: 
		/// GL_VERTEX_ATTRIB_ARRAY_ENABLED,GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, 
		/// GL_VERTEX_ATTRIB_ARRAY_NORMALIZED,GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_LONG, 
		/// GL_VERTEX_ATTRIB_ARRAY_DIVISOR,or GL_VERTEX_ATTRIB_RELATIVE_OFFSET. For glGetVertexArrayIndexed64v, it must be equal to 
		/// GL_VERTEX_BINDING_OFFSET.
		/// </param>
		/// <param name="param">
		/// Returns the requested value. 
		/// </param>
		/// <remarks>
		/// glGetVertexArrayIndexediv and glGetVertexArrayIndexed64iv provide a way of querying parameters of an attribute at an 
		/// user-specifiedindex of a vertex array object. The vertex array object does not have to be bound to the rendering context 
		/// atthe time of the call, but must have been bound at least once prior to this call. 
		/// The following parameter values can be retrieved with glGetVertexArrayIndexediv for each of the attributes defined for a 
		/// vertexarray object: 
		/// GL_VERTEX_ATTRIB_ARRAY_ENABLED: param returns a value that is non-zero (true) if the vertex attribute array for index is 
		/// enabledand 0 (false) if it is disabled. The initial value is GL_FALSE.GL_VERTEX_ATTRIB_ARRAY_SIZE: param returns a 
		/// singlevalue, the size of the vertex attribute array for index. The size is the number of values for each element of the 
		/// vertexattribute array, and it will be 1, 2, 3 or 4. The initial value is 4.GL_VERTEX_ATTRIB_ARRAY_STRIDE: param returns 
		/// asingle value, the array stride for (number of bytes between successive elements in) the vertex attribute array for 
		/// index.A value of 0 indicates the array elements are stored sequentially in memory. The initial value is 
		/// 0.GL_VERTEX_ATTRIB_ARRAY_TYPE:param returns a single value, a symbolic constant indicating the array type for the vertex 
		/// attributearray for index. Possible values are GL_BYTE, GL_DOUBLE, GL_FIXED, GL_FLOAT, GL_HALF_FLOAT, GL_INT, 
		/// GL_INT_2_10_10_10_REV,GL_SHORT, GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, 
		/// andGL_UNSIGNED_INT_10F_11F_11F_REV . The initial value is GL_FLOAT.GL_VERTEX_ATTRIB_ARRAY_NORMALIZED: param returns a 
		/// singlevalue that is non-zero (true) if fixed-point data types for the vertex attribute array indicated by index are 
		/// normalizedwhen they are converted to floating-point, and 0 (false) otherwise. The initial value is 
		/// GL_FALSE.GL_VERTEX_ATTRIB_ARRAY_INTEGER:param returns a single value that is non-zero (true) if fixed-point data types 
		/// forthe vertex attribute array indicated by index have integer data type, and 0 (false) otherwise. The initial value is 0 
		/// (GL_FALSE).GL_VERTEX_ATTRIB_ARRAY_LONG:param returns a single value that is non-zero (true) if a vertex attribute is 
		/// storedas an unconverted double, and 0 (false) otherwise. The initial value is 0 
		/// (GL_FALSE).GL_VERTEX_ATTRIB_ARRAY_DIVISOR:param returns a single value that is the frequency divisor used for instanced 
		/// rendering.See glVertexAttribDivisor. The initial value is 0.GL_VERTEX_ATTRIB_RELATIVE_OFFSET: param returns a single 
		/// valuethat is the byte offset of the first element relative to the start of the vertex buffer binding specified attribute 
		/// fetchesfrom. The initial value is 0.glGetVertexArrayIndexed64iv can be used to retrieve GL_VERTEX_BINDING_OFFSET 
		/// parametervalue for any of the attributes defined for a vertex array object. When pname is set to 
		/// GL_VERTEX_BINDING_OFFSET,param returns a single value that is the byte offset of the first element in the bound buffer's 
		/// datastore. The initial value for this parameter is 0. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION error is generated if vaobj is not the name of an existing vertex array object. 
		/// - GL_INVALID_VALUE error is generated if index is greater than or equal to the value of GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM error is generated if pname is not one of the valid values. For more details, please see above. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribIPointer"/>
		/// <seealso cref="Gl.VertexAttribLPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void GetVertexArrayIndexed(UInt32 vaobj, UInt32 index, int pname, Int32[] param)
		{
			unsafe {
				fixed (Int32* p_param = param)
				{
					Debug.Assert(Delegates.pglGetVertexArrayIndexediv != null, "pglGetVertexArrayIndexediv not implemented");
					Delegates.pglGetVertexArrayIndexediv(vaobj, index, pname, p_param);
					CallLog("glGetVertexArrayIndexediv({0}, {1}, {2}, {3})", vaobj, index, pname, param);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve parameters of an attribute of a vertex array object
		/// </summary>
		/// <param name="vaobj">
		/// Specifies the name of a vertex array object. 
		/// </param>
		/// <param name="index">
		/// Specifies the index of the vertex array object attribute. Must be a number between 0 and (GL_MAX_VERTEX_ATTRIBS - 1). 
		/// </param>
		/// <param name="pname">
		/// Specifies the property to be used for the query. For glGetVertexArrayIndexediv, it must be one of the following values: 
		/// GL_VERTEX_ATTRIB_ARRAY_ENABLED,GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, 
		/// GL_VERTEX_ATTRIB_ARRAY_NORMALIZED,GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_LONG, 
		/// GL_VERTEX_ATTRIB_ARRAY_DIVISOR,or GL_VERTEX_ATTRIB_RELATIVE_OFFSET. For glGetVertexArrayIndexed64v, it must be equal to 
		/// GL_VERTEX_BINDING_OFFSET.
		/// </param>
		/// <param name="param">
		/// Returns the requested value. 
		/// </param>
		/// <remarks>
		/// glGetVertexArrayIndexediv and glGetVertexArrayIndexed64iv provide a way of querying parameters of an attribute at an 
		/// user-specifiedindex of a vertex array object. The vertex array object does not have to be bound to the rendering context 
		/// atthe time of the call, but must have been bound at least once prior to this call. 
		/// The following parameter values can be retrieved with glGetVertexArrayIndexediv for each of the attributes defined for a 
		/// vertexarray object: 
		/// GL_VERTEX_ATTRIB_ARRAY_ENABLED: param returns a value that is non-zero (true) if the vertex attribute array for index is 
		/// enabledand 0 (false) if it is disabled. The initial value is GL_FALSE.GL_VERTEX_ATTRIB_ARRAY_SIZE: param returns a 
		/// singlevalue, the size of the vertex attribute array for index. The size is the number of values for each element of the 
		/// vertexattribute array, and it will be 1, 2, 3 or 4. The initial value is 4.GL_VERTEX_ATTRIB_ARRAY_STRIDE: param returns 
		/// asingle value, the array stride for (number of bytes between successive elements in) the vertex attribute array for 
		/// index.A value of 0 indicates the array elements are stored sequentially in memory. The initial value is 
		/// 0.GL_VERTEX_ATTRIB_ARRAY_TYPE:param returns a single value, a symbolic constant indicating the array type for the vertex 
		/// attributearray for index. Possible values are GL_BYTE, GL_DOUBLE, GL_FIXED, GL_FLOAT, GL_HALF_FLOAT, GL_INT, 
		/// GL_INT_2_10_10_10_REV,GL_SHORT, GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, GL_UNSIGNED_INT, GL_UNSIGNED_INT_2_10_10_10_REV, 
		/// andGL_UNSIGNED_INT_10F_11F_11F_REV . The initial value is GL_FLOAT.GL_VERTEX_ATTRIB_ARRAY_NORMALIZED: param returns a 
		/// singlevalue that is non-zero (true) if fixed-point data types for the vertex attribute array indicated by index are 
		/// normalizedwhen they are converted to floating-point, and 0 (false) otherwise. The initial value is 
		/// GL_FALSE.GL_VERTEX_ATTRIB_ARRAY_INTEGER:param returns a single value that is non-zero (true) if fixed-point data types 
		/// forthe vertex attribute array indicated by index have integer data type, and 0 (false) otherwise. The initial value is 0 
		/// (GL_FALSE).GL_VERTEX_ATTRIB_ARRAY_LONG:param returns a single value that is non-zero (true) if a vertex attribute is 
		/// storedas an unconverted double, and 0 (false) otherwise. The initial value is 0 
		/// (GL_FALSE).GL_VERTEX_ATTRIB_ARRAY_DIVISOR:param returns a single value that is the frequency divisor used for instanced 
		/// rendering.See glVertexAttribDivisor. The initial value is 0.GL_VERTEX_ATTRIB_RELATIVE_OFFSET: param returns a single 
		/// valuethat is the byte offset of the first element relative to the start of the vertex buffer binding specified attribute 
		/// fetchesfrom. The initial value is 0.glGetVertexArrayIndexed64iv can be used to retrieve GL_VERTEX_BINDING_OFFSET 
		/// parametervalue for any of the attributes defined for a vertex array object. When pname is set to 
		/// GL_VERTEX_BINDING_OFFSET,param returns a single value that is the byte offset of the first element in the bound buffer's 
		/// datastore. The initial value for this parameter is 0. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION error is generated if vaobj is not the name of an existing vertex array object. 
		/// - GL_INVALID_VALUE error is generated if index is greater than or equal to the value of GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM error is generated if pname is not one of the valid values. For more details, please see above. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribBinding"/>
		/// <seealso cref="Gl.VertexAttribIPointer"/>
		/// <seealso cref="Gl.VertexAttribLPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void GetVertexArrayIndexed(UInt32 vaobj, UInt32 index, int pname, Int64[] param)
		{
			unsafe {
				fixed (Int64* p_param = param)
				{
					Debug.Assert(Delegates.pglGetVertexArrayIndexed64iv != null, "pglGetVertexArrayIndexed64iv not implemented");
					Delegates.pglGetVertexArrayIndexed64iv(vaobj, index, pname, p_param);
					CallLog("glGetVertexArrayIndexed64iv({0}, {1}, {2}, {3})", vaobj, index, pname, param);
				}
			}
			DebugCheckErrors();
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
		/// <remarks>
		/// glCreateSamplers returns n previously unused sampler names in samplers, each representing a new sampler object 
		/// initializedto the default state. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if n is negative. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindSampler"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.DeleteSamplers"/>
		/// <seealso cref="Gl.DeleteTextures"/>
		/// <seealso cref="Gl.GenSamplers"/>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetSamplerParameter"/>
		/// <seealso cref="Gl.SamplerParameter"/>
		public static void CreateSamplers(Int32 n, UInt32[] samplers)
		{
			unsafe {
				fixed (UInt32* p_samplers = samplers)
				{
					Debug.Assert(Delegates.pglCreateSamplers != null, "pglCreateSamplers not implemented");
					Delegates.pglCreateSamplers(n, p_samplers);
					CallLog("glCreateSamplers({0}, {1})", n, samplers);
				}
			}
			DebugCheckErrors();
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
		/// <remarks>
		/// glCreateProgramPipelines returns n previously unused program pipeline names in pipelines, each representing a new 
		/// programpipeline object initialized to the default state. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if n is negative. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindProgramPipeline"/>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.GenProgramPipelines"/>
		/// <seealso cref="Gl.DeleteProgramPipelines"/>
		/// <seealso cref="Gl.IsProgramPipeline"/>
		public static void CreateProgramPipelines(Int32 n, UInt32[] pipelines)
		{
			unsafe {
				fixed (UInt32* p_pipelines = pipelines)
				{
					Debug.Assert(Delegates.pglCreateProgramPipelines != null, "pglCreateProgramPipelines not implemented");
					Delegates.pglCreateProgramPipelines(n, p_pipelines);
					CallLog("glCreateProgramPipelines({0}, {1})", n, pipelines);
				}
			}
			DebugCheckErrors();
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
		/// <remarks>
		/// glCreateQueries returns n previously unused query object names in ids, each representing a new query object with the 
		/// specifiedtarget. 
		/// target may be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE, GL_TIME_ELAPSED, 
		/// GL_TIMESTAMP,GL_PRIMITIVES_GENERATED or GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if n is negative. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.BeginQueryIndexed"/>
		/// <seealso cref="Gl.DeleteQueries"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GenQueries"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.IsQuery"/>
		public static void CreateQueries(int target, Int32 n, UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglCreateQueries != null, "pglCreateQueries not implemented");
					Delegates.pglCreateQueries(target, n, p_ids);
					CallLog("glCreateQueries({0}, {1}, {2})", target, n, ids);
				}
			}
			DebugCheckErrors();
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void GetQueryBufferObjecti64v(UInt32 id, UInt32 buffer, int pname, IntPtr offset)
		{
			Debug.Assert(Delegates.pglGetQueryBufferObjecti64v != null, "pglGetQueryBufferObjecti64v not implemented");
			Delegates.pglGetQueryBufferObjecti64v(id, buffer, pname, offset);
			CallLog("glGetQueryBufferObjecti64v({0}, {1}, {2}, {3})", id, buffer, pname, offset);
			DebugCheckErrors();
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void GetQueryBufferObject(UInt32 id, UInt32 buffer, int pname, IntPtr offset)
		{
			Debug.Assert(Delegates.pglGetQueryBufferObjectiv != null, "pglGetQueryBufferObjectiv not implemented");
			Delegates.pglGetQueryBufferObjectiv(id, buffer, pname, offset);
			CallLog("glGetQueryBufferObjectiv({0}, {1}, {2}, {3})", id, buffer, pname, offset);
			DebugCheckErrors();
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void GetQueryBufferObjectui64v(UInt32 id, UInt32 buffer, int pname, IntPtr offset)
		{
			Debug.Assert(Delegates.pglGetQueryBufferObjectui64v != null, "pglGetQueryBufferObjectui64v not implemented");
			Delegates.pglGetQueryBufferObjectui64v(id, buffer, pname, offset);
			CallLog("glGetQueryBufferObjectui64v({0}, {1}, {2}, {3})", id, buffer, pname, offset);
			DebugCheckErrors();
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void GetQueryBufferObjectuiv(UInt32 id, UInt32 buffer, int pname, IntPtr offset)
		{
			Debug.Assert(Delegates.pglGetQueryBufferObjectuiv != null, "pglGetQueryBufferObjectuiv not implemented");
			Delegates.pglGetQueryBufferObjectuiv(id, buffer, pname, offset);
			CallLog("glGetQueryBufferObjectuiv({0}, {1}, {2}, {3})", id, buffer, pname, offset);
			DebugCheckErrors();
		}

		/// <summary>
		/// defines a barrier ordering memory transactions
		/// </summary>
		/// <param name="barriers">
		/// Specifies the barriers to insert. 
		/// </param>
		/// <remarks>
		/// glMemoryBarrier defines a barrier ordering the memory transactions issued prior to the command relative to those issued 
		/// afterthe barrier. For the purposes of this ordering, memory transactions performed by shaders are considered to be 
		/// issuedby the rendering command that triggered the execution of the shader. barriers is a bitfield indicating the set of 
		/// operationsthat are synchronized with shader stores; the bits used in barriers are as follows: 
		/// GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT If set, vertex data sourced from buffer objects after the barrier will reflect data 
		/// writtenby shaders prior to the barrier. The set of buffer objects affected by this bit is derived from the buffer object 
		/// bindingsused for generic vertex attributes derived from the GL_VERTEX_ATTRIB_ARRAY_BUFFER bindings. 
		/// GL_ELEMENT_ARRAY_BARRIER_BITIf set, vertex array indices sourced from buffer objects after the barrier will reflect data 
		/// writtenby shaders prior to the barrier. The buffer objects affected by this bit are derived from the 
		/// GL_ELEMENT_ARRAY_BUFFERbinding. GL_UNIFORM_BARRIER_BIT Shader uniforms sourced from buffer objects after the barrier 
		/// willreflect data written by shaders prior to the barrier. GL_TEXTURE_FETCH_BARRIER_BIT Texture fetches from shaders, 
		/// includingfetches from buffer object memory via buffer textures, after the barrier will reflect data written by shaders 
		/// priorto the barrier. GL_SHADER_IMAGE_ACCESS_BARRIER_BIT Memory accesses using shader image load, store, and atomic 
		/// built-infunctions issued after the barrier will reflect data written by shaders prior to the barrier. Additionally, 
		/// imagestores and atomics issued after the barrier will not execute until all memory accesses (e.g., loads, stores, 
		/// texturefetches, vertex fetches) initiated prior to the barrier complete. GL_COMMAND_BARRIER_BIT Command data sourced 
		/// frombuffer objects by Draw*Indirect commands after the barrier will reflect data written by shaders prior to the 
		/// barrier.The buffer objects affected by this bit are derived from the GL_DRAW_INDIRECT_BUFFER binding. 
		/// GL_PIXEL_BUFFER_BARRIER_BITReads and writes of buffer objects via the GL_PIXEL_PACK_BUFFER and GL_PIXEL_UNPACK_BUFFER 
		/// bindings(via glReadPixels, glTexSubImage, etc.) after the barrier will reflect data written by shaders prior to the 
		/// barrier.Additionally, buffer object writes issued after the barrier will wait on the completion of all shader writes 
		/// initiatedprior to the barrier. GL_TEXTURE_UPDATE_BARRIER_BIT Writes to a texture via glTex(Sub)Image*, 
		/// glCopyTex(Sub)Image*,glCompressedTex(Sub)Image*, and reads via glGetTexImage after the barrier will reflect data written 
		/// byshaders prior to the barrier. Additionally, texture writes from these commands issued after the barrier will not 
		/// executeuntil all shader writes initiated prior to the barrier complete. GL_BUFFER_UPDATE_BARRIER_BIT Reads or writes via 
		/// glBufferSubData,glCopyBufferSubData, or glGetBufferSubData, or to buffer object memory mapped by glMapBuffer or 
		/// glMapBufferRangeafter the barrier will reflect data written by shaders prior to the barrier. Additionally, writes via 
		/// thesecommands issued after the barrier will wait on the completion of any shader writes to the same memory initiated 
		/// priorto the barrier. GL_FRAMEBUFFER_BARRIER_BIT Reads and writes via framebuffer object attachments after the barrier 
		/// willreflect data written by shaders prior to the barrier. Additionally, framebuffer writes issued after the barrier will 
		/// waiton the completion of all shader writes issued prior to the barrier. GL_TRANSFORM_FEEDBACK_BARRIER_BIT Writes via 
		/// transformfeedback bindings after the barrier will reflect data written by shaders prior to the barrier. Additionally, 
		/// transformfeedback writes issued after the barrier will wait on the completion of all shader writes issued prior to the 
		/// barrier.GL_ATOMIC_COUNTER_BARRIER_BIT Accesses to atomic counters after the barrier will reflect writes prior to the 
		/// barrier.GL_SHADER_STORAGE_BARRIER_BIT Accesses to shader storage blocks after the barrier will reflect writes prior to 
		/// thebarrier. GL_QUERY_BUFFER_BARRIER_BIT Writes of buffer objects via the GL_QUERY_BUFFER binding after the barrier will 
		/// reflectdata written by shaders prior to the barrier. Additionally, buffer object writes issued after the barrier will 
		/// waiton the completion of all shader writes initiated prior to the barrier. 
		/// If barriers is GL_ALL_BARRIER_BITS, shader memory accesses will be synchronized relative to all the operations described 
		/// above.
		/// Implementations may cache buffer object and texture image memory that could be written by shaders in multiple caches; 
		/// forexample, there may be separate caches for texture, vertex fetching, and one or more caches for shader memory 
		/// accesses.Implementations are not required to keep these caches coherent with shader memory writes. Stores issued by one 
		/// invocationmay not be immediately observable by other pipeline stages or other shader invocations because the value 
		/// storedmay remain in a cache local to the processor executing the store, or because data overwritten by the store is 
		/// stillin a cache elsewhere in the system. When glMemoryBarrier is called, the GL flushes and/or invalidates any caches 
		/// relevantto the operations specified by the barriers parameter to ensure consistent ordering of operations across the 
		/// barrier.
		/// To allow for independent shader invocations to communicate by reads and writes to a common memory address, image 
		/// variablesin the OpenGL Shading Language may be declared as "coherent". Buffer object or texture image memory accessed 
		/// throughsuch variables may be cached only if caches are automatically updated due to stores issued by any other shader 
		/// invocation.If the same address is accessed using both coherent and non-coherent variables, the accesses using variables 
		/// declaredas coherent will observe the results stored using coherent variables in other invocations. Using variables 
		/// declaredas "coherent" guarantees only that the results of stores will be immediately visible to shader invocations using 
		/// similarly-declaredvariables; calling glMemoryBarrier is required to ensure that the stores are visible to other 
		/// operations.
		/// The following guidelines may be helpful in choosing when to use coherent memory accesses and when to use barriers. 
		/// Data that are read-only or constant may be accessed without using coherent variables or calling MemoryBarrier(). Updates 
		/// tothe read-only data via API calls such as glBufferSubData will invalidate shader caches implicitly as required. Data 
		/// thatare shared between shader invocations at a fine granularity (e.g., written by one invocation, consumed by another 
		/// invocation)should use coherent variables to read and write the shared data. Data written by one shader invocation and 
		/// consumedby other shader invocations launched as a result of its execution ("dependent invocations") should use coherent 
		/// variablesin the producing shader invocation and call memoryBarrier() after the last write. The consuming shader 
		/// invocationshould also use coherent variables. Data written to image variables in one rendering pass and read by the 
		/// shaderin a later pass need not use coherent variables or memoryBarrier(). Calling glMemoryBarrier with the 
		/// SHADER_IMAGE_ACCESS_BARRIER_BITset in barriers between passes is necessary. Data written by the shader in one rendering 
		/// passand read by another mechanism (e.g., vertex or index buffer pulling) in a later pass need not use coherent variables 
		/// ormemoryBarrier(). Calling glMemoryBarrier with the appropriate bits set in barriers between passes is necessary. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if barriers is not the special value GL_ALL_BARRIER_BITS, and has any bits set other than 
		///   thosedescribed above for glMemoryBarrier or glMemoryBarrierByRegion respectively. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindImageTexture"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		/// <seealso cref="Gl.FlushMappedBufferRange"/>
		/// <seealso cref="Gl.moryBarrier"/>
		public static void MemoryBarrierByRegion(uint barriers)
		{
			Debug.Assert(Delegates.pglMemoryBarrierByRegion != null, "pglMemoryBarrierByRegion not implemented");
			Delegates.pglMemoryBarrierByRegion(barriers);
			CallLog("glMemoryBarrierByRegion({0})", barriers);
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve a sub-region of a texture image from a texture object
		/// </summary>
		/// <param name="texture">
		/// Specifies the name of the source texture object. Must be GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, 
		/// GL_TEXTURE_2D_ARRAY,GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY or GL_TEXTURE_RECTANGLE. In specific, 
		/// bufferand multisample textures are not permitted. 
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, 
		/// GL_RGBA,GL_BGRA, GL_DEPTH_COMPONENT and GL_STENCIL_INDEX. 
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT,GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5,GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1,GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2,and GL_UNSIGNED_INT_2_10_10_10_REV. 
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer to receive the retrieved pixel data. 
		/// </param>
		/// <param name="pixels">
		/// Returns the texture subimage. Should be a pointer to an array of the type specified by type. 
		/// </param>
		/// <remarks>
		/// glGetTextureSubImage returns a texture subimage into pixels. 
		/// texture is the name of the source texture object and must not be a buffer or multisample texture. The effective target 
		/// parameteris the value of GL_TEXTURE_TARGET for texture. Level, format, type and pixels have the same meaning as for 
		/// glGetTexImage.bufSize is the size of the buffer to receive the retrieved pixel data. 
		/// For cube map textures, the behavior is as though GetTextureImage were called, but only texels from the requested cube 
		/// mapfaces (selected by zoffset and depth, as described below) were returned. 
		/// xoffset, yoffset and zoffset values indicate the position of the subregion to return. width, height and depth indicate 
		/// thesize of the region to return. These parameters have the same meaning as for glTexSubImage3D, though for one- and 
		/// two-dimensionaltextures there are extra restrictions, described in the errors section below. 
		/// For one-dimensional array textures, yoffset is interpreted as the first layer to access and height is the number of 
		/// layersto access. 
		/// For two-dimensional array textures, zoffset is interpreted as the first layer to access and depth is the number of 
		/// layersto access. 
		/// Cube map textures are treated as an array of six slices in the z-dimension, where the value of zoffset is interpreted as 
		/// specifyingthe cube map face for the corresponding layer (as presented in the table below) and depth is the number of 
		/// facesto access: 
		/// Layer numberCube Map 
		/// Face0GL_TEXTURE_CUBE_MAP_POSITIVE_X1GL_TEXTURE_CUBE_MAP_NEGATIVE_X2GL_TEXTURE_CUBE_MAP_POSITIVE_Y3GL_TEXTURE_CUBE_MAP_NEGATIVE_Y4GL_TEXTURE_CUBE_MAP_POSITIVE_Z5GL_TEXTURE_CUBE_MAP_NEGATIVE_Z
		/// For cube map array textures, zoffset is the first layer-face to access, and depth is the number of layer-faces to 
		/// access.A layer-face described by $k$ is translated into an array layer and face according to $$ layer = \left\lfloor { 
		/// layer\over 6 } \right\rfloor$$ and $$ face = k \bmod 6. $$ 
		/// Component groups from the specified sub-region are packed and placed into memory as described for glGetTextureImage, 
		/// startingwith the texel at (xoffset, yoffset, zoffset). 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE error is generated if texture is not the name of an existing texture object. 
		/// - GL_INVALID_OPERATION error is generated if texture is the name of a buffer or multisample texture. 
		/// - GL_INVALID_VALUE is generated if xoffset, yoffset or zoffset are negative. 
		/// - GL_INVALID_VALUE is generated if xoffset + width is greater than the texture's width, yoffset + height is greater than 
		///   thetexture's height, or zoffset + depth is greater than the texture's depth. 
		/// - GL_INVALID_VALUE error is generated if the effective target is GL_TEXTURE_1D and either yoffset is not zero, or height 
		///   isnot one. 
		/// - GL_INVALID_VALUE error is generated if the effective target is GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D or 
		///   GL_TEXTURE_RECTANGLEand either zoffset is not zero, or depth is not one. 
		/// - GL_INVALID_OPERATION error is generated if the buffer size required to store the requested data is greater than bufSize. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTextureImage"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void GetTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, Int32 bufSize, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetTextureSubImage != null, "pglGetTextureSubImage not implemented");
			Delegates.pglGetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
			CallLog("glGetTextureSubImage({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11})", texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve a sub-region of a compressed texture image from a compressed texture object
		/// </summary>
		/// <param name="texture">
		/// Specifies the name of the source texture object. Must be GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, 
		/// GL_TEXTURE_2D_ARRAY,GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY or GL_TEXTURE_RECTANGLE. In specific, 
		/// bufferand multisample textures are not permitted. 
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
		/// Specifies the width of the texture subimage. Must be a multiple of the compressed block's width, unless the offset is 
		/// zeroand the size equals the texture image size. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage. Must be a multiple of the compressed block's height, unless the offset is 
		/// zeroand the size equals the texture image size. 
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture subimage. Must be a multiple of the compressed block's depth, unless the offset is 
		/// zeroand the size equals the texture image size. 
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer to receive the retrieved pixel data. 
		/// </param>
		/// <param name="pixels">
		/// Returns the texture subimage. Should be a pointer to an array of the type specified by type. 
		/// </param>
		/// <remarks>
		/// glGetCompressedTextureSubImage can be used to obtain a sub-region of a compressed texture image instead of the whole 
		/// image,as long as the compressed data are arranged into fixed-size blocks of texels. texture is the name of the texture 
		/// object,and must not be a buffer or multisample texture. The effective target is the value of GL_TEXTURE_TARGET for 
		/// texture.level and pixels have the same meaning as the corresponding arguments of glCompressedTexSubImage3D. bufSize 
		/// indicatesthe size of the buffer to receive the retrieved pixel data. 
		/// For cube map textures, the behavior is as though glGetCompressedTexImage were called once for each requested face 
		/// (selectedby zoffset and depth, as described below) with target corresponding to the requested texture cube map face as 
		/// indicatedby the table presented below. pixels is offset appropriately for each successive image. 
		/// xoffset, yoffset and zoffset indicate the position of the subregion to return. width, height and depth indicate the size 
		/// ofthe region to return. These arguments have the same meaning as for glCompressedTexSubImage3D, though there are extra 
		/// restrictions,described in the errors section below. 
		/// The mapping between the xoffset, yoffset, zoffset, width, height and depth parameters and the faces, layers, and 
		/// layer-facesfor cube map, array, and cube map array textures is the same as for glGetTextureSubImage. 
		/// The xoffset, yoffset, zoffset offsets and width, height and depth sizes must be multiples of the values of 
		/// GL_PACK_COMPRESSED_BLOCK_WIDTH,GL_PACK_COMPRESSED_BLOCK_HEIGHT, and GL_PACK_COMPRESSED_BLOCK_DEPTH respectively, unless 
		/// offsetis zero and the corresponding size is the same as the texture size in that dimension. 
		/// Pixel storage modes are treated as for glGetCompressedTexSubImage. The texel at (xoffset, yoffset, zoffset) will be 
		/// storedat the location indicated by pixels and the current pixel packing parameters. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION error is generated if texture is the name of a buffer or multisample texture. 
		/// - GL_INVALID_OPERATION error is generated if the buffer size required to store the requested data is greater than bufSize. 
		/// - GL_INVALID_OPERATION error is generated if the texture compression format is not based on fixed-size blocks. 
		/// - GL_INVALID_VALUE error is generated if texture is not the name of an existing texture object. 
		/// - GL_INVALID_VALUE is generated if xoffset, yoffset or zoffset are negative. 
		/// - GL_INVALID_VALUE is generated if xoffset + width is greater than the texture's width, yoffset + height is greater than 
		///   thetexture's height, or zoffset + depth is greater than the texture's depth. 
		/// - GL_INVALID_VALUE error is generated if the effective target is GL_TEXTURE_1D and either yoffset is not zero, or height 
		///   isnot one. 
		/// - GL_INVALID_VALUE error is generated if the effective target is GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D or 
		///   GL_TEXTURE_RECTANGLEand either zoffset is not zero, or depth is not one. 
		/// - GL_INVALID_VALUE error is generated if xoffset, yoffset or zoffset is not a multiple of the compressed block width, 
		///   heightor depth respectively. 
		/// - GL_INVALID_VALUE error is generated if width, height or depth is not a multiple of the compressed block width, height or 
		///   depthrespectively, unless the offset is zero and the size equals the texture image size. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetCompressedTextureImage"/>
		/// <seealso cref="Gl.ReadPixels"/>
		public static void GetCompressedTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 bufSize, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetCompressedTextureSubImage != null, "pglGetCompressedTextureSubImage not implemented");
			Delegates.pglGetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
			CallLog("glGetCompressedTextureSubImage({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// check if the rendering context has not been lost due to software or hardware issues
		/// </summary>
		/// <remarks>
		/// Certain events can result in a reset of the GL context. Such a reset causes all context state to be lost and requires 
		/// theapplication to recreate all objects in the affected context. 
		/// glGetGraphicsResetStatus can return one of the following constants: 
		/// If a reset status other than GL_NO_ERROR is returned and subsequent calls return GL_NO_ERROR, the context reset was 
		/// encounteredand completed. If a reset status is repeatedly returned, the context may be in the process of resetting. 
		/// Reset notification behavior is determined at context creation time, and may be queried by calling GetIntegerv with the 
		/// symbolicconstant GL_RESET_NOTIFICATION_STRATEGY. 
		/// If the reset notification behavior is GL_NO_RESET_NOTIFICATION, then the implementation will never deliver notification 
		/// ofreset events, and glGetGraphicsResetStatus will always return GL_NO_ERROR. 
		/// If the behavior is GL_LOSE_CONTEXT_ON_RESET, a graphics reset will result in the loss of all context state, requiring 
		/// therecreation of all associated objects. In this case glGetGraphicsResetStatus may return any of the values described 
		/// above.
		/// If a graphics reset notification occurs in a context, a notification must also occur in all other contexts which share 
		/// objectswith that context. 
		/// After a graphics reset has occurred on a context, subsequent GL commands on that context (or any context which shares 
		/// withthat context) will generate a GL_CONTEXT_LOST error. Such commands will not have side effects (in particular, they 
		/// willnot modify memory passed by pointer for query results), and will not block indefinitely or cause termination of the 
		/// application.There are two important exceptions to this behavior: 
		/// glGetError and glGetGraphicsResetStatus behave normally following a graphics reset, so that the application can 
		/// determinea reset has occurred, and when it is safe to destroy and re-create the context. Any commands which might cause 
		/// apolling application to block indefinitely will generate a GL_CONTEXT_LOST error, but will also return a value 
		/// indicatingcompletion to the application. Such commands include: glGetSynciv with pname GL_SYNC_STATUS ignores the other 
		/// parametersand returns GL_SIGNALED in values. glGetQueryObjectuiv with pname GL_QUERY_RESULT_AVAILABLE ignores the other 
		/// parametersand returns TRUE in params. 
		/// </remarks>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetIntegerv"/>
		/// <seealso cref="Gl.GetQueryObjectuiv"/>
		/// <seealso cref="Gl.GetSynciv"/>
		public static int GetGraphicsResetStatus()
		{
			int retValue;

			if        (Delegates.pglGetGraphicsResetStatus != null) {
				retValue = Delegates.pglGetGraphicsResetStatus();
				CallLog("glGetGraphicsResetStatus() = {0}", retValue);
			} else if (Delegates.pglGetGraphicsResetStatusKHR != null) {
				retValue = Delegates.pglGetGraphicsResetStatusKHR();
				CallLog("glGetGraphicsResetStatusKHR() = {0}", retValue);
			} else
				throw new NotImplementedException("glGetGraphicsResetStatus (and other aliases) are not implemented");
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// return a compressed texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetCompressedTexImage and glGetnCompressedTexImage functions. 
		/// GL_TEXTURE_1D,GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP_ARRAY, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_X,GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, and GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_TEXTURE_RECTANGLE 
		/// areaccepted. 
		/// </param>
		/// <param name="lod">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer pixels for glGetCompressedTextureImage and glGetnCompressedTexImage functions. 
		/// </param>
		/// <param name="pixels">
		/// Returns the compressed texture image. 
		/// </param>
		/// <remarks>
		/// glGetCompressedTexImage and glGetnCompressedTexImage return the compressed texture image associated with target and lod 
		/// intopixels. glGetCompressedTextureImage serves the same purpose, but instead of taking a texture target, it takes the ID 
		/// ofthe texture object. pixels should be an array of bufSize bytes for glGetnCompresedTexImage and 
		/// glGetCompressedTextureImagefunctions, and of GL_TEXTURE_COMPRESSED_IMAGE_SIZE bytes in case of glGetCompressedTexImage. 
		/// Ifthe actual data takes less space than bufSize, the remaining bytes will not be touched. target specifies the texture 
		/// target,to which the texture the data the function should extract the data from is bound to. lod specifies the 
		/// level-of-detailnumber of the desired image. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_PACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isrequested, pixels is treated as a byte offset into the buffer object's data store. 
		/// To minimize errors, first verify that the texture is compressed by calling glGetTexLevelParameter with argument 
		/// GL_TEXTURE_COMPRESSED.If the texture is compressed, you can determine the amount of memory required to store the 
		/// compressedtexture by calling glGetTexLevelParameter with argument GL_TEXTURE_COMPRESSED_IMAGE_SIZE. Finally, retrieve 
		/// theinternal format of the texture by calling glGetTexLevelParameter with argument GL_TEXTURE_INTERNAL_FORMAT. To store 
		/// thetexture for later use, associate the internal format and size with the retrieved texture image. These data can be 
		/// usedby the respective texture or subtexture loading routine used for loading target textures. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glGetCompressedTextureImage if texture is not the name of an existing texture 
		///   object.
		/// - GL_INVALID_VALUE is generated if level is less than zero or greater than the maximum number of LODs permitted by the 
		///   implementation.
		/// - GL_INVALID_OPERATION is generated if glGetCompressedTexImage, glGetnCompressedTexImage, and glGetCompressedTextureImage 
		///   isused to retrieve a texture that is in an uncompressed internal format. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_PACK_BUFFER target, the 
		///   bufferstorage was not initialized with glBufferStorage using GL_MAP_PERSISTENT_BIT flag, and the buffer object's data 
		///   storeis currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_PACK_BUFFER target and the 
		///   datawould be packed to the buffer object such that the memory writes required would exceed the data store size. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexLevelParameter with argument GL_TEXTURE_COMPRESSED 
		/// - glGetTexLevelParameter with argument GL_TEXTURE_COMPRESSED_IMAGE_SIZE 
		/// - glGetTexLevelParameter with argument GL_TEXTURE_INTERNAL_FORMAT 
		/// - glGet with argument GL_PIXEL_PACK_BUFFER_BINDING 
		/// </para>
		/// </remarks>
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
		public static void GetnCompressedTexImage(int target, Int32 lod, Int32 bufSize, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetnCompressedTexImage != null, "pglGetnCompressedTexImage not implemented");
			Delegates.pglGetnCompressedTexImage(target, lod, bufSize, pixels);
			CallLog("glGetnCompressedTexImage({0}, {1}, {2}, {3})", target, lod, bufSize, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnTexImage.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void GetnTexImage(int target, Int32 level, int format, int type, Int32 bufSize, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetnTexImage != null, "pglGetnTexImage not implemented");
			Delegates.pglGetnTexImage(target, level, format, type, bufSize, pixels);
			CallLog("glGetnTexImage({0}, {1}, {2}, {3}, {4}, {5})", target, level, format, type, bufSize, pixels);
			DebugCheckErrors();
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
		/// Specifies the size of the buffer params. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// glGetUniform and glGetnUniform return in params the value(s) of the specified uniform variable. The type of the uniform 
		/// variablespecified by location determines the number of values returned. If the uniform variable is defined in the shader 
		/// asa boolean, int, or float, a single value will be returned. If it is defined as a vec2, ivec2, or bvec2, two values 
		/// willbe returned. If it is defined as a vec3, ivec3, or bvec3, three values will be returned, and so on. To query values 
		/// storedin uniform variables declared as arrays, call glGetUniform for each element of the array. To query values stored 
		/// inuniform variables declared as structures, call glGetUniform for each field in the structure. The values for uniform 
		/// variablesdeclared as a matrix will be returned in column major order. 
		/// The locations assigned to uniform variables are not known until the program object is linked. After linking has 
		/// occurred,the command glGetUniformLocation can be used to obtain the location of a uniform variable. This location value 
		/// canthen be passed to glGetUniform or glGetnUniform in order to query the current value of the uniform variable. After a 
		/// programobject has been linked successfully, the index values for uniform variables remain fixed until the next link 
		/// commandoccurs. The uniform variable values can only be queried after a link if the link was successful. 
		/// The only difference between glGetUniform and glGetnUniform is that glGetnUniform will generate an error if size of the 
		/// paramsbuffer,as described by bufSize, is not large enough to hold the result data. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not a value generated by OpenGL. 
		/// - GL_INVALID_OPERATION is generated if program is not a program object. 
		/// - GL_INVALID_OPERATION is generated if program has not been successfully linked. 
		/// - GL_INVALID_OPERATION is generated if location does not correspond to a valid uniform variable location for the specified 
		///   programobject. 
		/// - GL_INVALID_OPERATION is generated by glGetnUniform if the buffer size required to store the requested data is greater 
		///   thanbufSize. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetActiveUniform with arguments program and the index of an active uniform variable 
		/// - glGetProgram with arguments program and GL_ACTIVE_UNIFORMS or GL_ACTIVE_UNIFORM_MAX_LENGTH 
		/// - glGetUniformLocation with arguments program and the name of a uniform variable 
		/// - glIsProgram 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		public static void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformdv != null, "pglGetnUniformdv not implemented");
					Delegates.pglGetnUniformdv(program, location, bufSize, p_params);
					CallLog("glGetnUniformdv({0}, {1}, {2}, {3})", program, location, bufSize, @params);
				}
			}
			DebugCheckErrors();
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
		/// Specifies the size of the buffer params. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// glGetUniform and glGetnUniform return in params the value(s) of the specified uniform variable. The type of the uniform 
		/// variablespecified by location determines the number of values returned. If the uniform variable is defined in the shader 
		/// asa boolean, int, or float, a single value will be returned. If it is defined as a vec2, ivec2, or bvec2, two values 
		/// willbe returned. If it is defined as a vec3, ivec3, or bvec3, three values will be returned, and so on. To query values 
		/// storedin uniform variables declared as arrays, call glGetUniform for each element of the array. To query values stored 
		/// inuniform variables declared as structures, call glGetUniform for each field in the structure. The values for uniform 
		/// variablesdeclared as a matrix will be returned in column major order. 
		/// The locations assigned to uniform variables are not known until the program object is linked. After linking has 
		/// occurred,the command glGetUniformLocation can be used to obtain the location of a uniform variable. This location value 
		/// canthen be passed to glGetUniform or glGetnUniform in order to query the current value of the uniform variable. After a 
		/// programobject has been linked successfully, the index values for uniform variables remain fixed until the next link 
		/// commandoccurs. The uniform variable values can only be queried after a link if the link was successful. 
		/// The only difference between glGetUniform and glGetnUniform is that glGetnUniform will generate an error if size of the 
		/// paramsbuffer,as described by bufSize, is not large enough to hold the result data. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not a value generated by OpenGL. 
		/// - GL_INVALID_OPERATION is generated if program is not a program object. 
		/// - GL_INVALID_OPERATION is generated if program has not been successfully linked. 
		/// - GL_INVALID_OPERATION is generated if location does not correspond to a valid uniform variable location for the specified 
		///   programobject. 
		/// - GL_INVALID_OPERATION is generated by glGetnUniform if the buffer size required to store the requested data is greater 
		///   thanbufSize. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetActiveUniform with arguments program and the index of an active uniform variable 
		/// - glGetProgram with arguments program and GL_ACTIVE_UNIFORMS or GL_ACTIVE_UNIFORM_MAX_LENGTH 
		/// - glGetUniformLocation with arguments program and the name of a uniform variable 
		/// - glIsProgram 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		public static void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					if        (Delegates.pglGetnUniformfv != null) {
						Delegates.pglGetnUniformfv(program, location, bufSize, p_params);
						CallLog("glGetnUniformfv({0}, {1}, {2}, {3})", program, location, bufSize, @params);
					} else if (Delegates.pglGetnUniformfvKHR != null) {
						Delegates.pglGetnUniformfvKHR(program, location, bufSize, p_params);
						CallLog("glGetnUniformfvKHR({0}, {1}, {2}, {3})", program, location, bufSize, @params);
					} else
						throw new NotImplementedException("glGetnUniformfv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
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
		/// Specifies the size of the buffer params. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetUniform and glGetnUniform return in params the value(s) of the specified uniform variable. The type of the uniform 
		/// variablespecified by location determines the number of values returned. If the uniform variable is defined in the shader 
		/// asa boolean, int, or float, a single value will be returned. If it is defined as a vec2, ivec2, or bvec2, two values 
		/// willbe returned. If it is defined as a vec3, ivec3, or bvec3, three values will be returned, and so on. To query values 
		/// storedin uniform variables declared as arrays, call glGetUniform for each element of the array. To query values stored 
		/// inuniform variables declared as structures, call glGetUniform for each field in the structure. The values for uniform 
		/// variablesdeclared as a matrix will be returned in column major order. 
		/// The locations assigned to uniform variables are not known until the program object is linked. After linking has 
		/// occurred,the command glGetUniformLocation can be used to obtain the location of a uniform variable. This location value 
		/// canthen be passed to glGetUniform or glGetnUniform in order to query the current value of the uniform variable. After a 
		/// programobject has been linked successfully, the index values for uniform variables remain fixed until the next link 
		/// commandoccurs. The uniform variable values can only be queried after a link if the link was successful. 
		/// The only difference between glGetUniform and glGetnUniform is that glGetnUniform will generate an error if size of the 
		/// paramsbuffer,as described by bufSize, is not large enough to hold the result data. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not a value generated by OpenGL. 
		/// - GL_INVALID_OPERATION is generated if program is not a program object. 
		/// - GL_INVALID_OPERATION is generated if program has not been successfully linked. 
		/// - GL_INVALID_OPERATION is generated if location does not correspond to a valid uniform variable location for the specified 
		///   programobject. 
		/// - GL_INVALID_OPERATION is generated by glGetnUniform if the buffer size required to store the requested data is greater 
		///   thanbufSize. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetActiveUniform with arguments program and the index of an active uniform variable 
		/// - glGetProgram with arguments program and GL_ACTIVE_UNIFORMS or GL_ACTIVE_UNIFORM_MAX_LENGTH 
		/// - glGetUniformLocation with arguments program and the name of a uniform variable 
		/// - glIsProgram 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		public static void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					if        (Delegates.pglGetnUniformiv != null) {
						Delegates.pglGetnUniformiv(program, location, bufSize, p_params);
						CallLog("glGetnUniformiv({0}, {1}, {2}, {3})", program, location, bufSize, @params);
					} else if (Delegates.pglGetnUniformivKHR != null) {
						Delegates.pglGetnUniformivKHR(program, location, bufSize, p_params);
						CallLog("glGetnUniformivKHR({0}, {1}, {2}, {3})", program, location, bufSize, @params);
					} else
						throw new NotImplementedException("glGetnUniformiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
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
		/// Specifies the size of the buffer params. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetUniform and glGetnUniform return in params the value(s) of the specified uniform variable. The type of the uniform 
		/// variablespecified by location determines the number of values returned. If the uniform variable is defined in the shader 
		/// asa boolean, int, or float, a single value will be returned. If it is defined as a vec2, ivec2, or bvec2, two values 
		/// willbe returned. If it is defined as a vec3, ivec3, or bvec3, three values will be returned, and so on. To query values 
		/// storedin uniform variables declared as arrays, call glGetUniform for each element of the array. To query values stored 
		/// inuniform variables declared as structures, call glGetUniform for each field in the structure. The values for uniform 
		/// variablesdeclared as a matrix will be returned in column major order. 
		/// The locations assigned to uniform variables are not known until the program object is linked. After linking has 
		/// occurred,the command glGetUniformLocation can be used to obtain the location of a uniform variable. This location value 
		/// canthen be passed to glGetUniform or glGetnUniform in order to query the current value of the uniform variable. After a 
		/// programobject has been linked successfully, the index values for uniform variables remain fixed until the next link 
		/// commandoccurs. The uniform variable values can only be queried after a link if the link was successful. 
		/// The only difference between glGetUniform and glGetnUniform is that glGetnUniform will generate an error if size of the 
		/// paramsbuffer,as described by bufSize, is not large enough to hold the result data. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not a value generated by OpenGL. 
		/// - GL_INVALID_OPERATION is generated if program is not a program object. 
		/// - GL_INVALID_OPERATION is generated if program has not been successfully linked. 
		/// - GL_INVALID_OPERATION is generated if location does not correspond to a valid uniform variable location for the specified 
		///   programobject. 
		/// - GL_INVALID_OPERATION is generated by glGetnUniform if the buffer size required to store the requested data is greater 
		///   thanbufSize. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetActiveUniform with arguments program and the index of an active uniform variable 
		/// - glGetProgram with arguments program and GL_ACTIVE_UNIFORMS or GL_ACTIVE_UNIFORM_MAX_LENGTH 
		/// - glGetUniformLocation with arguments program and the name of a uniform variable 
		/// - glIsProgram 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		public static void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					if        (Delegates.pglGetnUniformuiv != null) {
						Delegates.pglGetnUniformuiv(program, location, bufSize, p_params);
						CallLog("glGetnUniformuiv({0}, {1}, {2}, {3})", program, location, bufSize, @params);
					} else if (Delegates.pglGetnUniformuivKHR != null) {
						Delegates.pglGetnUniformuivKHR(program, location, bufSize, p_params);
						CallLog("glGetnUniformuivKHR({0}, {1}, {2}, {3})", program, location, bufSize, @params);
					} else
						throw new NotImplementedException("glGetnUniformuiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
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
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void ReadnPixels(Int32 x, Int32 y, Int32 width, Int32 height, int format, int type, Int32 bufSize, IntPtr data)
		{
			if        (Delegates.pglReadnPixels != null) {
				Delegates.pglReadnPixels(x, y, width, height, format, type, bufSize, data);
				CallLog("glReadnPixels({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", x, y, width, height, format, type, bufSize, data);
			} else if (Delegates.pglReadnPixelsARB != null) {
				Delegates.pglReadnPixelsARB(x, y, width, height, format, type, bufSize, data);
				CallLog("glReadnPixelsARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", x, y, width, height, format, type, bufSize, data);
			} else if (Delegates.pglReadnPixelsEXT != null) {
				Delegates.pglReadnPixelsEXT(x, y, width, height, format, type, bufSize, data);
				CallLog("glReadnPixelsEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", x, y, width, height, format, type, bufSize, data);
			} else if (Delegates.pglReadnPixelsKHR != null) {
				Delegates.pglReadnPixelsKHR(x, y, width, height, format, type, bufSize, data);
				CallLog("glReadnPixelsKHR({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", x, y, width, height, format, type, bufSize, data);
			} else
				throw new NotImplementedException("glReadnPixels (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnMapdv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="query">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		public static void GetnMap(int target, int query, Int32 bufSize, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglGetnMapdv != null, "pglGetnMapdv not implemented");
					Delegates.pglGetnMapdv(target, query, bufSize, p_v);
					CallLog("glGetnMapdv({0}, {1}, {2}, {3})", target, query, bufSize, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnMapfv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="query">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void GetnMap(int target, int query, Int32 bufSize, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglGetnMapfv != null, "pglGetnMapfv not implemented");
					Delegates.pglGetnMapfv(target, query, bufSize, p_v);
					CallLog("glGetnMapfv({0}, {1}, {2}, {3})", target, query, bufSize, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnMapiv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="query">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void GetnMap(int target, int query, Int32 bufSize, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglGetnMapiv != null, "pglGetnMapiv not implemented");
					Delegates.pglGetnMapiv(target, query, bufSize, p_v);
					CallLog("glGetnMapiv({0}, {1}, {2}, {3})", target, query, bufSize, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnPixelMapfv.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void GetnPixelMap(int map, Int32 bufSize, float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglGetnPixelMapfv != null, "pglGetnPixelMapfv not implemented");
					Delegates.pglGetnPixelMapfv(map, bufSize, p_values);
					CallLog("glGetnPixelMapfv({0}, {1}, {2})", map, bufSize, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnPixelMapuiv.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void GetnPixelMap(int map, Int32 bufSize, UInt32[] values)
		{
			unsafe {
				fixed (UInt32* p_values = values)
				{
					Debug.Assert(Delegates.pglGetnPixelMapuiv != null, "pglGetnPixelMapuiv not implemented");
					Delegates.pglGetnPixelMapuiv(map, bufSize, p_values);
					CallLog("glGetnPixelMapuiv({0}, {1}, {2})", map, bufSize, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnPixelMapusv.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		public static void GetnPixelMap(int map, Int32 bufSize, UInt16[] values)
		{
			unsafe {
				fixed (UInt16* p_values = values)
				{
					Debug.Assert(Delegates.pglGetnPixelMapusv != null, "pglGetnPixelMapusv not implemented");
					Delegates.pglGetnPixelMapusv(map, bufSize, p_values);
					CallLog("glGetnPixelMapusv({0}, {1}, {2})", map, bufSize, values);
				}
			}
			DebugCheckErrors();
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
		public static void GetnPolygonStipple(Int32 bufSize, byte[] pattern)
		{
			unsafe {
				fixed (byte* p_pattern = pattern)
				{
					Debug.Assert(Delegates.pglGetnPolygonStipple != null, "pglGetnPolygonStipple not implemented");
					Delegates.pglGetnPolygonStipple(bufSize, p_pattern);
					CallLog("glGetnPolygonStipple({0}, {1})", bufSize, pattern);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnColorTable.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void GetnColorTable(int target, int format, int type, Int32 bufSize, IntPtr table)
		{
			Debug.Assert(Delegates.pglGetnColorTable != null, "pglGetnColorTable not implemented");
			Delegates.pglGetnColorTable(target, format, type, bufSize, table);
			CallLog("glGetnColorTable({0}, {1}, {2}, {3}, {4})", target, format, type, bufSize, table);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnConvolutionFilter.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void GetnConvolutionFilter(int target, int format, int type, Int32 bufSize, IntPtr image)
		{
			Debug.Assert(Delegates.pglGetnConvolutionFilter != null, "pglGetnConvolutionFilter not implemented");
			Delegates.pglGetnConvolutionFilter(target, format, type, bufSize, image);
			CallLog("glGetnConvolutionFilter({0}, {1}, {2}, {3}, {4})", target, format, type, bufSize, image);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnSeparableFilter.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
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
		public static void GetnSeparableFilter(int target, int format, int type, Int32 rowBufSize, IntPtr row, Int32 columnBufSize, IntPtr column, IntPtr span)
		{
			Debug.Assert(Delegates.pglGetnSeparableFilter != null, "pglGetnSeparableFilter not implemented");
			Delegates.pglGetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, span);
			CallLog("glGetnSeparableFilter({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, format, type, rowBufSize, row, columnBufSize, column, span);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnHistogram.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void GetnHistogram(int target, bool reset, int format, int type, Int32 bufSize, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetnHistogram != null, "pglGetnHistogram not implemented");
			Delegates.pglGetnHistogram(target, reset, format, type, bufSize, values);
			CallLog("glGetnHistogram({0}, {1}, {2}, {3}, {4}, {5})", target, reset, format, type, bufSize, values);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnMinmax.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void GetnMinmax(int target, bool reset, int format, int type, Int32 bufSize, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetnMinmax != null, "pglGetnMinmax not implemented");
			Delegates.pglGetnMinmax(target, reset, format, type, bufSize, values);
			CallLog("glGetnMinmax({0}, {1}, {2}, {3}, {4}, {5})", target, reset, format, type, bufSize, values);
			DebugCheckErrors();
		}

		/// <summary>
		/// controls the ordering of reads and writes to rendered fragments across drawing commands
		/// </summary>
		/// <remarks>
		/// The values of rendered fragments are undefined when a shader stage fetches texels and the same texels are written via 
		/// fragmentshader outputs, even if the reads and writes are not in the same drawing command. To safely read the result of a 
		/// writtentexel via a texel fetch in a subsequent drawing command, call glTextureBarrier between the two drawing commands 
		/// toguarantee that writes have completed and caches have been invalidated before subsequent drawing commands are executed. 
		/// <para>
		/// The following errors can be generated:
		/// - None. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.MemoryBarrier"/>
		public static void TextureBarrier()
		{
			Debug.Assert(Delegates.pglTextureBarrier != null, "pglTextureBarrier not implemented");
			Delegates.pglTextureBarrier();
			CallLog("glTextureBarrier()");
			DebugCheckErrors();
		}

	}

}
