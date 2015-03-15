
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
		[AliasOf("GL_GUILTY_CONTEXT_RESET_ARB")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_robustness")]
		public const int GUILTY_CONTEXT_RESET = 0x8253;

		/// <summary>
		/// Value of GL_INNOCENT_CONTEXT_RESET symbol.
		/// </summary>
		[AliasOf("GL_INNOCENT_CONTEXT_RESET_ARB")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_robustness")]
		public const int INNOCENT_CONTEXT_RESET = 0x8254;

		/// <summary>
		/// Value of GL_UNKNOWN_CONTEXT_RESET symbol.
		/// </summary>
		[AliasOf("GL_UNKNOWN_CONTEXT_RESET_ARB")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_robustness")]
		public const int UNKNOWN_CONTEXT_RESET = 0x8255;

		/// <summary>
		/// Value of GL_RESET_NOTIFICATION_STRATEGY symbol.
		/// </summary>
		[AliasOf("GL_RESET_NOTIFICATION_STRATEGY_ARB")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_robustness")]
		public const int RESET_NOTIFICATION_STRATEGY = 0x8256;

		/// <summary>
		/// Value of GL_LOSE_CONTEXT_ON_RESET symbol.
		/// </summary>
		[AliasOf("GL_LOSE_CONTEXT_ON_RESET_ARB")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_robustness")]
		public const int LOSE_CONTEXT_ON_RESET = 0x8252;

		/// <summary>
		/// Value of GL_NO_RESET_NOTIFICATION symbol.
		/// </summary>
		[AliasOf("GL_NO_RESET_NOTIFICATION_ARB")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_robustness")]
		public const int NO_RESET_NOTIFICATION = 0x8261;

		/// <summary>
		/// Value of GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT symbol.
		/// </summary>
		[AliasOf("GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_clip_control")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// GL_TRANSFORM_FEEDBACK_BUFFER_START, GL_TRANSFORM_FEEDBACK_BUFFER_SIZE, GL_TRANSFORM_FEEDBACK_PAUSED, 
		/// GL_TRANSFORM_FEEDBACK_ACTIVE.
		/// </param>
		/// <param name="param">
		/// The address of a buffer into which will be written the requested state information.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// GL_TRANSFORM_FEEDBACK_BUFFER_START, GL_TRANSFORM_FEEDBACK_BUFFER_SIZE, GL_TRANSFORM_FEEDBACK_PAUSED, 
		/// GL_TRANSFORM_FEEDBACK_ACTIVE.
		/// </param>
		/// <param name="index">
		/// Index of the transform feedback stream (for indexed state).
		/// </param>
		/// <param name="param">
		/// The address of a buffer into which will be written the requested state information.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// GL_TRANSFORM_FEEDBACK_BUFFER_START, GL_TRANSFORM_FEEDBACK_BUFFER_SIZE, GL_TRANSFORM_FEEDBACK_PAUSED, 
		/// GL_TRANSFORM_FEEDBACK_ACTIVE.
		/// </param>
		/// <param name="index">
		/// Index of the transform feedback stream (for indexed state).
		/// </param>
		/// <param name="param">
		/// The address of a buffer into which will be written the requested state information.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// GL_DYNAMIC_STORAGE_BIT, GL_MAP_READ_BITGL_MAP_WRITE_BIT, GL_MAP_PERSISTENT_BIT, GL_MAP_COHERENT_BIT, and 
		/// GL_CLIENT_STORAGE_BIT.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// GL_DYNAMIC_STORAGE_BIT, GL_MAP_READ_BITGL_MAP_WRITE_BIT, GL_MAP_PERSISTENT_BIT, GL_MAP_COHERENT_BIT, and 
		/// GL_CLIENT_STORAGE_BIT.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// be written.
		/// </param>
		/// <param name="size">
		/// Specifies the size, in basic machine units, of the data to be copied from the source buffer object to the destination 
		/// buffer object.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// write to, or both read from and write to the buffer object's mapped data store. The symbolic constant must be 
		/// GL_READ_ONLY, GL_WRITE_ONLY, or GL_READ_WRITE.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// Returns the pointer value specified by pname.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public static void GetNamedBufferPointer(UInt32 buffer, int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetNamedBufferPointerv != null, "pglGetNamedBufferPointerv not implemented");
					Delegates.pglGetNamedBufferPointerv(buffer, pname, p_params);
					CallLog("glGetNamedBufferPointerv({0}, {1}, {2})", buffer, pname, @params);
				}
			}
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public static void GetNamedBufferSubData(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data)
		{
			Debug.Assert(Delegates.pglGetNamedBufferSubData != null, "pglGetNamedBufferSubData not implemented");
			Delegates.pglGetNamedBufferSubData(buffer, offset, size, data);
			CallLog("glGetNamedBufferSubData({0}, {1}, {2}, {3})", buffer, offset, size, data);
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// framebuffer object.
		/// </param>
		/// <param name="buf">
		/// For default framebuffer, the argument specifies up to four color buffers to be drawn into. Symbolic constants GL_NONE, 
		/// GL_FRONT_LEFT, GL_FRONT_RIGHT, GL_BACK_LEFT, GL_BACK_RIGHT, GL_FRONT, GL_BACK, GL_LEFT, GL_RIGHT, and GL_FRONT_AND_BACK 
		/// are accepted. The initial value is GL_FRONT for single-buffered contexts, and GL_BACK for double-buffered contexts. For 
		/// framebuffer objects, GL_COLOR_ATTACHMENT$m$ and GL_NONE enums are accepted, where $m$ is a value between 0 and 
		/// GL_MAX_COLOR_ATTACHMENTS.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// GL_DEPTH_BUFFER_BIT and GL_STENCIL_BUFFER_BIT.
		/// </param>
		/// <param name="filter">
		/// Specifies the interpolation to be applied if the image is stretched. Must be GL_NEAREST or GL_LINEAR.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// framebuffer completeness of framebuffer is checked for glCheckNamedFramebufferStatus.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// Returns the value of parameter pname for attachment.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// Returns the value of parameter pname for the renderbuffer object.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// valid non-proxy target values above.
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// valid non-proxy target values above.
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// target values above.
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
		/// GL_RGBA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// target values above.
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
		/// GL_RGBA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// target values above.
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
		/// GL_RGBA, GL_BGRA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// target values above.
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
		/// GL_RGBA, GL_BGRA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// target values above.
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
		/// GL_RGBA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// target values above.
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
		/// GL_RGBA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Specifies a pointer to the image data in memory.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public static void GetTextureImage(UInt32 texture, Int32 level, int format, int type, Int32 bufSize, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetTextureImage != null, "pglGetTextureImage not implemented");
			Delegates.pglGetTextureImage(texture, level, format, type, bufSize, pixels);
			CallLog("glGetTextureImage({0}, {1}, {2}, {3}, {4}, {5})", texture, level, format, type, bufSize, pixels);
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
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public static void GetTextureImage(UInt32 texture, Int32 level, int format, int type, Int32 bufSize, Object pixels)
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
		/// Specifies the texture object name for glGetCompressedTextureImage function.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level $n$ is the $n$-th 
		/// mipmap reduction image.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer pixels for glGetCompressedTextureImage and glGetnCompressedTexImage functions.
		/// </param>
		/// <param name="pixels">
		/// Returns the compressed texture image.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public static void GetCompressedTextureImage(UInt32 texture, Int32 level, Int32 bufSize, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetCompressedTextureImage != null, "pglGetCompressedTextureImage not implemented");
			Delegates.pglGetCompressedTextureImage(texture, level, bufSize, pixels);
			CallLog("glGetCompressedTextureImage({0}, {1}, {2}, {3})", texture, level, bufSize, pixels);
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
		/// mipmap reduction image.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer pixels for glGetCompressedTextureImage and glGetnCompressedTexImage functions.
		/// </param>
		/// <param name="pixels">
		/// Returns the compressed texture image.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// Specifies the texture object name for glGetTextureLevelParameterfv and glGetTextureLevelParameteriv functions.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reduction image.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, 
		/// GL_TEXTURE_INTERNAL_FORMAT, GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, 
		/// GL_TEXTURE_DEPTH_SIZE, GL_TEXTURE_COMPRESSED, GL_TEXTURE_COMPRESSED_IMAGE_SIZE, and GL_TEXTURE_BUFFER_OFFSET are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// reduction image.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, 
		/// GL_TEXTURE_INTERNAL_FORMAT, GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, 
		/// GL_TEXTURE_DEPTH_SIZE, GL_TEXTURE_COMPRESSED, GL_TEXTURE_COMPRESSED_IMAGE_SIZE, and GL_TEXTURE_BUFFER_OFFSET are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// glGetTextureParameterIuiv functions.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, 
		/// GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, 
		/// GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, 
		/// GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_TARGET, 
		/// GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, 
		/// GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the texture parameters.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// glGetTextureParameterIuiv functions.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, 
		/// GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, 
		/// GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, 
		/// GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_TARGET, 
		/// GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, 
		/// GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the texture parameters.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// glGetTextureParameterIuiv functions.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, 
		/// GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, 
		/// GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, 
		/// GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_TARGET, 
		/// GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, 
		/// GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the texture parameters.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// glGetTextureParameterIuiv functions.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, 
		/// GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, 
		/// GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, 
		/// GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_TARGET, 
		/// GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, 
		/// GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the texture parameters.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, 
		/// GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_LONG, 
		/// GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_RELATIVE_OFFSET. For glGetVertexArrayIndexed64v, it must be equal to 
		/// GL_VERTEX_BINDING_OFFSET.
		/// </param>
		/// <param name="param">
		/// Returns the requested value.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		/// GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, 
		/// GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_LONG, 
		/// GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_VERTEX_ATTRIB_RELATIVE_OFFSET. For glGetVertexArrayIndexed64v, it must be equal to 
		/// GL_VERTEX_BINDING_OFFSET.
		/// </param>
		/// <param name="param">
		/// Returns the requested value.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_ES3_1_compatibility")]
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
		/// GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY or GL_TEXTURE_RECTANGLE. In specific, 
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, 
		/// GL_RGBA, GL_BGRA, GL_DEPTH_COMPONENT and GL_STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer to receive the retrieved pixel data.
		/// </param>
		/// <param name="pixels">
		/// Returns the texture subimage. Should be a pointer to an array of the type specified by type.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_get_texture_sub_image")]
		public static void GetTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, Int32 bufSize, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetTextureSubImage != null, "pglGetTextureSubImage not implemented");
			Delegates.pglGetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
			CallLog("glGetTextureSubImage({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11})", texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve a sub-region of a texture image from a texture object
		/// </summary>
		/// <param name="texture">
		/// Specifies the name of the source texture object. Must be GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, 
		/// GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY or GL_TEXTURE_RECTANGLE. In specific, 
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, 
		/// GL_RGBA, GL_BGRA, GL_DEPTH_COMPONENT and GL_STENCIL_INDEX.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, 
		/// GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, 
		/// GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, 
		/// GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, 
		/// GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer to receive the retrieved pixel data.
		/// </param>
		/// <param name="pixels">
		/// Returns the texture subimage. Should be a pointer to an array of the type specified by type.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_get_texture_sub_image")]
		public static void GetTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, Int32 bufSize, Object pixels)
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
		/// Specifies the name of the source texture object. Must be GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, 
		/// GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY or GL_TEXTURE_RECTANGLE. In specific, 
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
		/// Specifies the width of the texture subimage. Must be a multiple of the compressed block's width, unless the offset is 
		/// zero and the size equals the texture image size.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage. Must be a multiple of the compressed block's height, unless the offset is 
		/// zero and the size equals the texture image size.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture subimage. Must be a multiple of the compressed block's depth, unless the offset is 
		/// zero and the size equals the texture image size.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer to receive the retrieved pixel data.
		/// </param>
		/// <param name="pixels">
		/// Returns the texture subimage. Should be a pointer to an array of the type specified by type.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_get_texture_sub_image")]
		public static void GetCompressedTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 bufSize, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetCompressedTextureSubImage != null, "pglGetCompressedTextureSubImage not implemented");
			Delegates.pglGetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
			CallLog("glGetCompressedTextureSubImage({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve a sub-region of a compressed texture image from a compressed texture object
		/// </summary>
		/// <param name="texture">
		/// Specifies the name of the source texture object. Must be GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, 
		/// GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY or GL_TEXTURE_RECTANGLE. In specific, 
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
		/// Specifies the width of the texture subimage. Must be a multiple of the compressed block's width, unless the offset is 
		/// zero and the size equals the texture image size.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage. Must be a multiple of the compressed block's height, unless the offset is 
		/// zero and the size equals the texture image size.
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture subimage. Must be a multiple of the compressed block's depth, unless the offset is 
		/// zero and the size equals the texture image size.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer to receive the retrieved pixel data.
		/// </param>
		/// <param name="pixels">
		/// Returns the texture subimage. Should be a pointer to an array of the type specified by type.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_get_texture_sub_image")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_robustness")]
		public static int GetGraphicsResetStatus()
		{
			int retValue;

			Debug.Assert(Delegates.pglGetGraphicsResetStatus != null, "pglGetGraphicsResetStatus not implemented");
			retValue = Delegates.pglGetGraphicsResetStatus();
			CallLog("glGetGraphicsResetStatus() = {0}", retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// return a compressed texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetCompressedTexImage and glGetnCompressedTexImage functions. 
		/// GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP_ARRAY, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, and GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_TEXTURE_RECTANGLE 
		/// are accepted.
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
		[RequiredByFeature("GL_VERSION_4_5")]
		public static void GetnCompressedTexImage(int target, Int32 lod, Int32 bufSize, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetnCompressedTexImage != null, "pglGetnCompressedTexImage not implemented");
			Delegates.pglGetnCompressedTexImage(target, lod, bufSize, pixels);
			CallLog("glGetnCompressedTexImage({0}, {1}, {2}, {3})", target, lod, bufSize, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// return a compressed texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetCompressedTexImage and glGetnCompressedTexImage functions. 
		/// GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP_ARRAY, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, and GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_TEXTURE_RECTANGLE 
		/// are accepted.
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
		[RequiredByFeature("GL_VERSION_4_5")]
		public static void GetnCompressedTexImage(int target, Int32 lod, Int32 bufSize, Object pixels)
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
		[RequiredByFeature("GL_VERSION_4_5")]
		public static void GetnTexImage(int target, Int32 level, int format, int type, Int32 bufSize, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetnTexImage != null, "pglGetnTexImage not implemented");
			Delegates.pglGetnTexImage(target, level, format, type, bufSize, pixels);
			CallLog("glGetnTexImage({0}, {1}, {2}, {3}, {4}, {5})", target, level, format, type, bufSize, pixels);
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
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		public static void GetnTexImage(int target, Int32 level, int format, int type, Int32 bufSize, Object pixels)
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
		/// Specifies the size of the buffer params.
		/// </param>
		/// <param name="params">
		/// Returns the value of the specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
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
		/// Returns the value of the specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_robustness")]
		public static void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformfv != null, "pglGetnUniformfv not implemented");
					Delegates.pglGetnUniformfv(program, location, bufSize, p_params);
					CallLog("glGetnUniformfv({0}, {1}, {2}, {3})", program, location, bufSize, @params);
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
		/// Returns the value of the specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_robustness")]
		public static void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformiv != null, "pglGetnUniformiv not implemented");
					Delegates.pglGetnUniformiv(program, location, bufSize, p_params);
					CallLog("glGetnUniformiv({0}, {1}, {2}, {3})", program, location, bufSize, @params);
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
		/// Returns the value of the specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_robustness")]
		public static void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformuiv != null, "pglGetnUniformuiv not implemented");
					Delegates.pglGetnUniformuiv(program, location, bufSize, p_params);
					CallLog("glGetnUniformuiv({0}, {1}, {2}, {3})", program, location, bufSize, @params);
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_KHR_robustness")]
		public static void ReadnPixels(Int32 x, Int32 y, Int32 width, Int32 height, int format, int type, Int32 bufSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglReadnPixels != null, "pglReadnPixels not implemented");
			Delegates.pglReadnPixels(x, y, width, height, format, type, bufSize, data);
			CallLog("glReadnPixels({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", x, y, width, height, format, type, bufSize, data);
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
		[RequiredByFeature("GL_VERSION_4_5")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
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
		[RequiredByFeature("GL_VERSION_4_5")]
		public static void GetnColorTable(int target, int format, int type, Int32 bufSize, IntPtr table)
		{
			Debug.Assert(Delegates.pglGetnColorTable != null, "pglGetnColorTable not implemented");
			Delegates.pglGetnColorTable(target, format, type, bufSize, table);
			CallLog("glGetnColorTable({0}, {1}, {2}, {3}, {4})", target, format, type, bufSize, table);
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
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		public static void GetnColorTable(int target, int format, int type, Int32 bufSize, Object table)
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
		[RequiredByFeature("GL_VERSION_4_5")]
		public static void GetnConvolutionFilter(int target, int format, int type, Int32 bufSize, IntPtr image)
		{
			Debug.Assert(Delegates.pglGetnConvolutionFilter != null, "pglGetnConvolutionFilter not implemented");
			Delegates.pglGetnConvolutionFilter(target, format, type, bufSize, image);
			CallLog("glGetnConvolutionFilter({0}, {1}, {2}, {3}, {4})", target, format, type, bufSize, image);
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
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		public static void GetnConvolutionFilter(int target, int format, int type, Int32 bufSize, Object image)
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
		[RequiredByFeature("GL_VERSION_4_5")]
		public static void GetnSeparableFilter(int target, int format, int type, Int32 rowBufSize, IntPtr row, Int32 columnBufSize, IntPtr column, IntPtr span)
		{
			Debug.Assert(Delegates.pglGetnSeparableFilter != null, "pglGetnSeparableFilter not implemented");
			Delegates.pglGetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, span);
			CallLog("glGetnSeparableFilter({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, format, type, rowBufSize, row, columnBufSize, column, span);
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
		[RequiredByFeature("GL_VERSION_4_5")]
		public static void GetnSeparableFilter(int target, int format, int type, Int32 rowBufSize, Object row, Int32 columnBufSize, Object column, Object span)
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
		[RequiredByFeature("GL_VERSION_4_5")]
		public static void GetnHistogram(int target, bool reset, int format, int type, Int32 bufSize, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetnHistogram != null, "pglGetnHistogram not implemented");
			Delegates.pglGetnHistogram(target, reset, format, type, bufSize, values);
			CallLog("glGetnHistogram({0}, {1}, {2}, {3}, {4}, {5})", target, reset, format, type, bufSize, values);
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
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		public static void GetnHistogram(int target, bool reset, int format, int type, Int32 bufSize, Object values)
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
		[RequiredByFeature("GL_VERSION_4_5")]
		public static void GetnMinmax(int target, bool reset, int format, int type, Int32 bufSize, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetnMinmax != null, "pglGetnMinmax not implemented");
			Delegates.pglGetnMinmax(target, reset, format, type, bufSize, values);
			CallLog("glGetnMinmax({0}, {1}, {2}, {3}, {4}, {5})", target, reset, format, type, bufSize, values);
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
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_5")]
		public static void GetnMinmax(int target, bool reset, int format, int type, Int32 bufSize, Object values)
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
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_texture_barrier")]
		public static void TextureBarrier()
		{
			Debug.Assert(Delegates.pglTextureBarrier != null, "pglTextureBarrier not implemented");
			Delegates.pglTextureBarrier();
			CallLog("glTextureBarrier()");
			DebugCheckErrors();
		}

	}

}
