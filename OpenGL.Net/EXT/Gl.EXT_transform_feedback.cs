
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
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_BUFFER_EXT = 0x8C8E;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_START_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_BUFFER_START_EXT = 0x8C84;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_BUFFER_SIZE_EXT = 0x8C85;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_BUFFER_BINDING_EXT = 0x8C8F;

		/// <summary>
		/// Value of GL_INTERLEAVED_ATTRIBS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public const int INTERLEAVED_ATTRIBS_EXT = 0x8C8C;

		/// <summary>
		/// Value of GL_SEPARATE_ATTRIBS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public const int SEPARATE_ATTRIBS_EXT = 0x8C8D;

		/// <summary>
		/// Value of GL_PRIMITIVES_GENERATED_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public const int PRIMITIVES_GENERATED_EXT = 0x8C87;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_EXT = 0x8C88;

		/// <summary>
		/// Value of GL_RASTERIZER_DISCARD_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public const int RASTERIZER_DISCARD_EXT = 0x8C89;

		/// <summary>
		/// Value of GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public const int MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_EXT = 0x8C8A;

		/// <summary>
		/// Value of GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public const int MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_EXT = 0x8C8B;

		/// <summary>
		/// Value of GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public const int MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_EXT = 0x8C80;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_VARYINGS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_VARYINGS_EXT = 0x8C83;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_MODE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_BUFFER_MODE_EXT = 0x8C7F;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH_EXT = 0x8C76;

		/// <summary>
		/// Binding for glBeginTransformFeedbackEXT.
		/// </summary>
		/// <param name="primitiveMode">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public static void BeginTransformFeedbackEXT(int primitiveMode)
		{
			Debug.Assert(Delegates.pglBeginTransformFeedbackEXT != null, "pglBeginTransformFeedbackEXT not implemented");
			Delegates.pglBeginTransformFeedbackEXT(primitiveMode);
			CallLog("glBeginTransformFeedbackEXT({0})", primitiveMode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEndTransformFeedbackEXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public static void EndTransformFeedbackEXT()
		{
			Debug.Assert(Delegates.pglEndTransformFeedbackEXT != null, "pglEndTransformFeedbackEXT not implemented");
			Delegates.pglEndTransformFeedbackEXT();
			CallLog("glEndTransformFeedbackEXT()");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBindBufferRangeEXT.
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
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public static void BindBufferRangeEXT(int target, UInt32 index, UInt32 buffer, IntPtr offset, UInt32 size)
		{
			Debug.Assert(Delegates.pglBindBufferRangeEXT != null, "pglBindBufferRangeEXT not implemented");
			Delegates.pglBindBufferRangeEXT(target, index, buffer, offset, size);
			CallLog("glBindBufferRangeEXT({0}, {1}, {2}, {3}, {4})", target, index, buffer, offset, size);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBindBufferOffsetEXT.
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
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public static void BindBufferOffsetEXT(int target, UInt32 index, UInt32 buffer, IntPtr offset)
		{
			if        (Delegates.pglBindBufferOffsetEXT != null) {
				Delegates.pglBindBufferOffsetEXT(target, index, buffer, offset);
				CallLog("glBindBufferOffsetEXT({0}, {1}, {2}, {3})", target, index, buffer, offset);
			} else if (Delegates.pglBindBufferOffsetNV != null) {
				Delegates.pglBindBufferOffsetNV(target, index, buffer, offset);
				CallLog("glBindBufferOffsetNV({0}, {1}, {2}, {3})", target, index, buffer, offset);
			} else
				throw new NotImplementedException("glBindBufferOffsetEXT (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBindBufferBaseEXT.
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
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public static void BindBufferBaseEXT(int target, UInt32 index, UInt32 buffer)
		{
			Debug.Assert(Delegates.pglBindBufferBaseEXT != null, "pglBindBufferBaseEXT not implemented");
			Delegates.pglBindBufferBaseEXT(target, index, buffer);
			CallLog("glBindBufferBaseEXT({0}, {1}, {2})", target, index, buffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTransformFeedbackVaryingsEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="varyings">
		/// A <see cref="T:String[]"/>.
		/// </param>
		/// <param name="bufferMode">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public static void TransformFeedbackVaryingEXT(UInt32 program, Int32 count, String[] varyings, int bufferMode)
		{
			Debug.Assert(varyings.Length >= count);
			Debug.Assert(Delegates.pglTransformFeedbackVaryingsEXT != null, "pglTransformFeedbackVaryingsEXT not implemented");
			Delegates.pglTransformFeedbackVaryingsEXT(program, count, varyings, bufferMode);
			CallLog("glTransformFeedbackVaryingsEXT({0}, {1}, {2}, {3})", program, count, varyings, bufferMode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTransformFeedbackVaryingsEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="varyings">
		/// A <see cref="T:String[]"/>.
		/// </param>
		/// <param name="bufferMode">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public static void TransformFeedbackVaryingEXT(UInt32 program, String[] varyings, int bufferMode)
		{
			Debug.Assert(Delegates.pglTransformFeedbackVaryingsEXT != null, "pglTransformFeedbackVaryingsEXT not implemented");
			Delegates.pglTransformFeedbackVaryingsEXT(program, (Int32)varyings.Length, varyings, bufferMode);
			CallLog("glTransformFeedbackVaryingsEXT({0}, {1}, {2}, {3})", program, varyings.Length, varyings, bufferMode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTransformFeedbackVaryingEXT.
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
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public static void GetTransformFeedbackVaryingEXT(UInt32 program, UInt32 index, Int32 bufSize, out Int32 length, out Int32 size, out int type, [Out] StringBuilder name)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				fixed (Int32* p_size = &size)
				fixed (int* p_type = &type)
				{
					Debug.Assert(Delegates.pglGetTransformFeedbackVaryingEXT != null, "pglGetTransformFeedbackVaryingEXT not implemented");
					Delegates.pglGetTransformFeedbackVaryingEXT(program, index, bufSize, p_length, p_size, p_type, name);
					CallLog("glGetTransformFeedbackVaryingEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", program, index, bufSize, length, size, type, name);
				}
			}
			DebugCheckErrors();
		}

	}

}
