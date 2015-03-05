
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
		/// Value of GL_BACK_PRIMARY_COLOR_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int BACK_PRIMARY_COLOR_NV = 0x8C77;

		/// <summary>
		/// Value of GL_BACK_SECONDARY_COLOR_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int BACK_SECONDARY_COLOR_NV = 0x8C78;

		/// <summary>
		/// Value of GL_TEXTURE_COORD_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int TEXTURE_COORD_NV = 0x8C79;

		/// <summary>
		/// Value of GL_CLIP_DISTANCE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int CLIP_DISTANCE_NV = 0x8C7A;

		/// <summary>
		/// Value of GL_VERTEX_ID_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int VERTEX_ID_NV = 0x8C7B;

		/// <summary>
		/// Value of GL_PRIMITIVE_ID_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int PRIMITIVE_ID_NV = 0x8C7C;

		/// <summary>
		/// Value of GL_GENERIC_ATTRIB_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int GENERIC_ATTRIB_NV = 0x8C7D;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_ATTRIBS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_ATTRIBS_NV = 0x8C7E;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_MODE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_BUFFER_MODE_NV = 0x8C7F;

		/// <summary>
		/// Value of GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_NV = 0x8C80;

		/// <summary>
		/// Value of GL_ACTIVE_VARYINGS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int ACTIVE_VARYINGS_NV = 0x8C81;

		/// <summary>
		/// Value of GL_ACTIVE_VARYING_MAX_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int ACTIVE_VARYING_MAX_LENGTH_NV = 0x8C82;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_VARYINGS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_VARYINGS_NV = 0x8C83;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_START_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_BUFFER_START_NV = 0x8C84;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_BUFFER_SIZE_NV = 0x8C85;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_RECORD_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_RECORD_NV = 0x8C86;

		/// <summary>
		/// Value of GL_PRIMITIVES_GENERATED_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int PRIMITIVES_GENERATED_NV = 0x8C87;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_NV = 0x8C88;

		/// <summary>
		/// Value of GL_RASTERIZER_DISCARD_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int RASTERIZER_DISCARD_NV = 0x8C89;

		/// <summary>
		/// Value of GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_NV = 0x8C8A;

		/// <summary>
		/// Value of GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_NV = 0x8C8B;

		/// <summary>
		/// Value of GL_INTERLEAVED_ATTRIBS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int INTERLEAVED_ATTRIBS_NV = 0x8C8C;

		/// <summary>
		/// Value of GL_SEPARATE_ATTRIBS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int SEPARATE_ATTRIBS_NV = 0x8C8D;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_BUFFER_NV = 0x8C8E;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_BUFFER_BINDING_NV = 0x8C8F;

		/// <summary>
		/// Value of GL_LAYER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int LAYER_NV = 0x8DAA;

		/// <summary>
		/// Value of GL_NEXT_BUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int NEXT_BUFFER_NV = -2;

		/// <summary>
		/// Value of GL_SKIP_COMPONENTS4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int SKIP_COMPONENTS4_NV = -3;

		/// <summary>
		/// Value of GL_SKIP_COMPONENTS3_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int SKIP_COMPONENTS3_NV = -4;

		/// <summary>
		/// Value of GL_SKIP_COMPONENTS2_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int SKIP_COMPONENTS2_NV = -5;

		/// <summary>
		/// Value of GL_SKIP_COMPONENTS1_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int SKIP_COMPONENTS1_NV = -6;

		/// <summary>
		/// Binding for glBeginTransformFeedbackNV.
		/// </summary>
		/// <param name="primitiveMode">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public static void BeginTransformFeedbackNV(int primitiveMode)
		{
			Debug.Assert(Delegates.pglBeginTransformFeedbackNV != null, "pglBeginTransformFeedbackNV not implemented");
			Delegates.pglBeginTransformFeedbackNV(primitiveMode);
			CallLog("glBeginTransformFeedbackNV({0})", primitiveMode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEndTransformFeedbackNV.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public static void EndTransformFeedbackNV()
		{
			Debug.Assert(Delegates.pglEndTransformFeedbackNV != null, "pglEndTransformFeedbackNV not implemented");
			Delegates.pglEndTransformFeedbackNV();
			CallLog("glEndTransformFeedbackNV()");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTransformFeedbackAttribsNV.
		/// </summary>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="attribs">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="bufferMode">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public static void TransformFeedbackAttribsNV(Int32 count, Int32[] attribs, int bufferMode)
		{
			unsafe {
				fixed (Int32* p_attribs = attribs)
				{
					Debug.Assert(Delegates.pglTransformFeedbackAttribsNV != null, "pglTransformFeedbackAttribsNV not implemented");
					Delegates.pglTransformFeedbackAttribsNV(count, p_attribs, bufferMode);
					CallLog("glTransformFeedbackAttribsNV({0}, {1}, {2})", count, attribs, bufferMode);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBindBufferRangeNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public static void BindBufferRangeNV(int target, UInt32 index, UInt32 buffer, IntPtr offset, UInt32 size)
		{
			Debug.Assert(Delegates.pglBindBufferRangeNV != null, "pglBindBufferRangeNV not implemented");
			Delegates.pglBindBufferRangeNV(target, index, buffer, offset, size);
			CallLog("glBindBufferRangeNV({0}, {1}, {2}, {3}, {4})", target, index, buffer, offset, size);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBindBufferOffsetNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public static void BindBufferOffsetNV(int target, UInt32 index, UInt32 buffer, IntPtr offset)
		{
			Debug.Assert(Delegates.pglBindBufferOffsetNV != null, "pglBindBufferOffsetNV not implemented");
			Delegates.pglBindBufferOffsetNV(target, index, buffer, offset);
			CallLog("glBindBufferOffsetNV({0}, {1}, {2}, {3})", target, index, buffer, offset);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBindBufferBaseNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public static void BindBufferBaseNV(int target, UInt32 index, UInt32 buffer)
		{
			Debug.Assert(Delegates.pglBindBufferBaseNV != null, "pglBindBufferBaseNV not implemented");
			Delegates.pglBindBufferBaseNV(target, index, buffer);
			CallLog("glBindBufferBaseNV({0}, {1}, {2})", target, index, buffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTransformFeedbackVaryingsNV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="locations">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="bufferMode">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public static void TransformFeedbackVaryingNV(UInt32 program, Int32 count, Int32[] locations, int bufferMode)
		{
			Debug.Assert(locations.Length >= count);

			unsafe {
				fixed (Int32* p_locations = locations)
				{
					Debug.Assert(Delegates.pglTransformFeedbackVaryingsNV != null, "pglTransformFeedbackVaryingsNV not implemented");
					Delegates.pglTransformFeedbackVaryingsNV(program, count, p_locations, bufferMode);
					CallLog("glTransformFeedbackVaryingsNV({0}, {1}, {2}, {3})", program, count, locations, bufferMode);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glActiveVaryingNV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public static void ActiveVaryingNV(UInt32 program, String name)
		{
			Debug.Assert(Delegates.pglActiveVaryingNV != null, "pglActiveVaryingNV not implemented");
			Delegates.pglActiveVaryingNV(program, name);
			CallLog("glActiveVaryingNV({0}, {1})", program, name);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetVaryingLocationNV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public static Int32 GetVaryingLocationNV(UInt32 program, String name)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetVaryingLocationNV != null, "pglGetVaryingLocationNV not implemented");
			retValue = Delegates.pglGetVaryingLocationNV(program, name);
			CallLog("glGetVaryingLocationNV({0}, {1}) = {2}", program, name, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetActiveVaryingNV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bufSize">
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
		[RequiredByFeature("GL_NV_transform_feedback")]
		public static void GetActiveVaryingNV(UInt32 program, UInt32 index, Int32 bufSize, out Int32 length, out Int32 size, out int type, [Out] StringBuilder name)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				fixed (Int32* p_size = &size)
				fixed (int* p_type = &type)
				{
					Debug.Assert(Delegates.pglGetActiveVaryingNV != null, "pglGetActiveVaryingNV not implemented");
					Delegates.pglGetActiveVaryingNV(program, index, bufSize, p_length, p_size, p_type, name);
					CallLog("glGetActiveVaryingNV({0}, {1}, {2}, {3}, {4}, {5}, {6})", program, index, bufSize, length, size, type, name);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTransformFeedbackVaryingNV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public static void GetTransformFeedbackVaryingNV(UInt32 program, UInt32 index, out Int32 location)
		{
			unsafe {
				fixed (Int32* p_location = &location)
				{
					Debug.Assert(Delegates.pglGetTransformFeedbackVaryingNV != null, "pglGetTransformFeedbackVaryingNV not implemented");
					Delegates.pglGetTransformFeedbackVaryingNV(program, index, p_location);
					CallLog("glGetTransformFeedbackVaryingNV({0}, {1}, {2})", program, index, location);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTransformFeedbackStreamAttribsNV.
		/// </summary>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="attribs">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="nbuffers">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufstreams">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="bufferMode">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public static void TransformFeedbackStreamAttribsNV(Int32 count, Int32[] attribs, Int32 nbuffers, Int32[] bufstreams, int bufferMode)
		{
			Debug.Assert(attribs.Length >= count);
			Debug.Assert(bufstreams.Length >= nbuffers);

			unsafe {
				fixed (Int32* p_attribs = attribs)
				fixed (Int32* p_bufstreams = bufstreams)
				{
					Debug.Assert(Delegates.pglTransformFeedbackStreamAttribsNV != null, "pglTransformFeedbackStreamAttribsNV not implemented");
					Delegates.pglTransformFeedbackStreamAttribsNV(count, p_attribs, nbuffers, p_bufstreams, bufferMode);
					CallLog("glTransformFeedbackStreamAttribsNV({0}, {1}, {2}, {3}, {4})", count, attribs, nbuffers, bufstreams, bufferMode);
				}
			}
			DebugCheckErrors();
		}

	}

}
