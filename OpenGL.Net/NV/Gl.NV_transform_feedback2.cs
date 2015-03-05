
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
		/// Value of GL_TRANSFORM_FEEDBACK_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback2")]
		public const int TRANSFORM_FEEDBACK_NV = 0x8E22;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback2")]
		public const int TRANSFORM_FEEDBACK_BUFFER_PAUSED_NV = 0x8E23;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback2")]
		public const int TRANSFORM_FEEDBACK_BUFFER_ACTIVE_NV = 0x8E24;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BINDING_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback2")]
		public const int TRANSFORM_FEEDBACK_BINDING_NV = 0x8E25;

		/// <summary>
		/// Binding for glBindTransformFeedbackNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_transform_feedback2")]
		public static void BindTransformFeedbackNV(int target, UInt32 id)
		{
			Debug.Assert(Delegates.pglBindTransformFeedbackNV != null, "pglBindTransformFeedbackNV not implemented");
			Delegates.pglBindTransformFeedbackNV(target, id);
			CallLog("glBindTransformFeedbackNV({0}, {1})", target, id);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBindTransformFeedbackNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_transform_feedback2")]
		public static void BindTransformFeedbackNV(BufferTargetARB target, UInt32 id)
		{
			Debug.Assert(Delegates.pglBindTransformFeedbackNV != null, "pglBindTransformFeedbackNV not implemented");
			Delegates.pglBindTransformFeedbackNV((int)target, id);
			CallLog("glBindTransformFeedbackNV({0}, {1})", target, id);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteTransformFeedbacksNV.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_transform_feedback2")]
		public static void DeleteTransformFeedbackNV(Int32 n, UInt32[] ids)
		{
			Debug.Assert(ids.Length >= n);
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglDeleteTransformFeedbacksNV != null, "pglDeleteTransformFeedbacksNV not implemented");
					Delegates.pglDeleteTransformFeedbacksNV(n, p_ids);
					CallLog("glDeleteTransformFeedbacksNV({0}, {1})", n, ids);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenTransformFeedbacksNV.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_transform_feedback2")]
		public static void GenTransformFeedbackNV(Int32 n, UInt32[] ids)
		{
			Debug.Assert(ids.Length >= n);
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglGenTransformFeedbacksNV != null, "pglGenTransformFeedbacksNV not implemented");
					Delegates.pglGenTransformFeedbacksNV(n, p_ids);
					CallLog("glGenTransformFeedbacksNV({0}, {1})", n, ids);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIsTransformFeedbackNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_transform_feedback2")]
		public static bool IsTransformFeedbackNV(UInt32 id)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsTransformFeedbackNV != null, "pglIsTransformFeedbackNV not implemented");
			retValue = Delegates.pglIsTransformFeedbackNV(id);
			CallLog("glIsTransformFeedbackNV({0}) = {1}", id, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glPauseTransformFeedbackNV.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback2")]
		public static void PauseTransformFeedbackNV()
		{
			Debug.Assert(Delegates.pglPauseTransformFeedbackNV != null, "pglPauseTransformFeedbackNV not implemented");
			Delegates.pglPauseTransformFeedbackNV();
			CallLog("glPauseTransformFeedbackNV()");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glResumeTransformFeedbackNV.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback2")]
		public static void ResumeTransformFeedbackNV()
		{
			Debug.Assert(Delegates.pglResumeTransformFeedbackNV != null, "pglResumeTransformFeedbackNV not implemented");
			Delegates.pglResumeTransformFeedbackNV();
			CallLog("glResumeTransformFeedbackNV()");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawTransformFeedbackNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_transform_feedback2")]
		public static void DrawTransformFeedbackNV(int mode, UInt32 id)
		{
			Debug.Assert(Delegates.pglDrawTransformFeedbackNV != null, "pglDrawTransformFeedbackNV not implemented");
			Delegates.pglDrawTransformFeedbackNV(mode, id);
			CallLog("glDrawTransformFeedbackNV({0}, {1})", mode, id);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawTransformFeedbackNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_transform_feedback2")]
		public static void DrawTransformFeedbackNV(PrimitiveType mode, UInt32 id)
		{
			Debug.Assert(Delegates.pglDrawTransformFeedbackNV != null, "pglDrawTransformFeedbackNV not implemented");
			Delegates.pglDrawTransformFeedbackNV((int)mode, id);
			CallLog("glDrawTransformFeedbackNV({0}, {1})", mode, id);
			DebugCheckErrors();
		}

	}

}
