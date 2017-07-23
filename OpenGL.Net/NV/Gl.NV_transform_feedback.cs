
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
		/// [GL] Value of GL_BACK_PRIMARY_COLOR_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int BACK_PRIMARY_COLOR_NV = 0x8C77;

		/// <summary>
		/// [GL] Value of GL_BACK_SECONDARY_COLOR_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int BACK_SECONDARY_COLOR_NV = 0x8C78;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_COORD_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int TEXTURE_COORD_NV = 0x8C79;

		/// <summary>
		/// [GL] Value of GL_CLIP_DISTANCE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int CLIP_DISTANCE_NV = 0x8C7A;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ID_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int VERTEX_ID_NV = 0x8C7B;

		/// <summary>
		/// [GL] Value of GL_PRIMITIVE_ID_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int PRIMITIVE_ID_NV = 0x8C7C;

		/// <summary>
		/// [GL] Value of GL_GENERIC_ATTRIB_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int GENERIC_ATTRIB_NV = 0x8C7D;

		/// <summary>
		/// [GL] Value of GL_TRANSFORM_FEEDBACK_ATTRIBS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_ATTRIBS_NV = 0x8C7E;

		/// <summary>
		/// [GL] Value of GL_ACTIVE_VARYINGS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int ACTIVE_VARYINGS_NV = 0x8C81;

		/// <summary>
		/// [GL] Value of GL_ACTIVE_VARYING_MAX_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int ACTIVE_VARYING_MAX_LENGTH_NV = 0x8C82;

		/// <summary>
		/// [GL] Value of GL_TRANSFORM_FEEDBACK_RECORD_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int TRANSFORM_FEEDBACK_RECORD_NV = 0x8C86;

		/// <summary>
		/// [GL] Value of GL_LAYER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int LAYER_NV = 0x8DAA;

		/// <summary>
		/// [GL] Value of GL_NEXT_BUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int NEXT_BUFFER_NV = -2;

		/// <summary>
		/// [GL] Value of GL_SKIP_COMPONENTS4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int SKIP_COMPONENTS4_NV = -3;

		/// <summary>
		/// [GL] Value of GL_SKIP_COMPONENTS3_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int SKIP_COMPONENTS3_NV = -4;

		/// <summary>
		/// [GL] Value of GL_SKIP_COMPONENTS2_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int SKIP_COMPONENTS2_NV = -5;

		/// <summary>
		/// [GL] Value of GL_SKIP_COMPONENTS1_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public const int SKIP_COMPONENTS1_NV = -6;

		/// <summary>
		/// [GL] Binding for glTransformFeedbackAttribsNV.
		/// </summary>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="attribs">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="bufferMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public static void TransformFeedbackAttribsNV(Int32 count, Int32[] attribs, Int32 bufferMode)
		{
			unsafe {
				fixed (Int32* p_attribs = attribs)
				{
					Debug.Assert(Delegates.pglTransformFeedbackAttribsNV != null, "pglTransformFeedbackAttribsNV not implemented");
					Delegates.pglTransformFeedbackAttribsNV(count, p_attribs, bufferMode);
					LogCommand("glTransformFeedbackAttribsNV", null, count, attribs, bufferMode					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTransformFeedbackVaryingsNV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="locations">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="bufferMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public static void TransformFeedbackVaryingsNV(UInt32 program, Int32[] locations, Int32 bufferMode)
		{
			unsafe {
				fixed (Int32* p_locations = locations)
				{
					Debug.Assert(Delegates.pglTransformFeedbackVaryingsNV != null, "pglTransformFeedbackVaryingsNV not implemented");
					Delegates.pglTransformFeedbackVaryingsNV(program, (Int32)locations.Length, p_locations, bufferMode);
					LogCommand("glTransformFeedbackVaryingsNV", null, program, locations.Length, locations, bufferMode					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glActiveVaryingNV.
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
			LogCommand("glActiveVaryingNV", null, program, name			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetVaryingLocationNV.
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
			LogCommand("glGetVaryingLocationNV", retValue, program, name			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] Binding for glGetActiveVaryingNV.
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
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public static void GetActiveVaryingNV(UInt32 program, UInt32 index, Int32 bufSize, out Int32 length, out Int32 size, out Int32 type, [Out] StringBuilder name)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				fixed (Int32* p_size = &size)
				fixed (Int32* p_type = &type)
				{
					Debug.Assert(Delegates.pglGetActiveVaryingNV != null, "pglGetActiveVaryingNV not implemented");
					Delegates.pglGetActiveVaryingNV(program, index, bufSize, p_length, p_size, p_type, name);
					LogCommand("glGetActiveVaryingNV", null, program, index, bufSize, length, size, type, name					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetTransformFeedbackVaryingNV.
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
					LogCommand("glGetTransformFeedbackVaryingNV", null, program, index, location					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTransformFeedbackStreamAttribsNV.
		/// </summary>
		/// <param name="attribs">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="bufstreams">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="bufferMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_transform_feedback")]
		public static void TransformFeedbackStreamAttribsNV(Int32[] attribs, Int32[] bufstreams, Int32 bufferMode)
		{
			unsafe {
				fixed (Int32* p_attribs = attribs)
				fixed (Int32* p_bufstreams = bufstreams)
				{
					Debug.Assert(Delegates.pglTransformFeedbackStreamAttribsNV != null, "pglTransformFeedbackStreamAttribsNV not implemented");
					Delegates.pglTransformFeedbackStreamAttribsNV((Int32)attribs.Length, p_attribs, (Int32)bufstreams.Length, p_bufstreams, bufferMode);
					LogCommand("glTransformFeedbackStreamAttribsNV", null, attribs.Length, attribs, bufstreams.Length, bufstreams, bufferMode					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTransformFeedbackAttribsNV", ExactSpelling = true)]
			internal extern static unsafe void glTransformFeedbackAttribsNV(Int32 count, Int32* attribs, Int32 bufferMode);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTransformFeedbackVaryingsNV", ExactSpelling = true)]
			internal extern static unsafe void glTransformFeedbackVaryingsNV(UInt32 program, Int32 count, Int32* locations, Int32 bufferMode);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glActiveVaryingNV", ExactSpelling = true)]
			internal extern static void glActiveVaryingNV(UInt32 program, String name);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetVaryingLocationNV", ExactSpelling = true)]
			internal extern static Int32 glGetVaryingLocationNV(UInt32 program, String name);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetActiveVaryingNV", ExactSpelling = true)]
			internal extern static unsafe void glGetActiveVaryingNV(UInt32 program, UInt32 index, Int32 bufSize, Int32* length, Int32* size, Int32* type, String name);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetTransformFeedbackVaryingNV", ExactSpelling = true)]
			internal extern static unsafe void glGetTransformFeedbackVaryingNV(UInt32 program, UInt32 index, Int32* location);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTransformFeedbackStreamAttribsNV", ExactSpelling = true)]
			internal extern static unsafe void glTransformFeedbackStreamAttribsNV(Int32 count, Int32* attribs, Int32 nbuffers, Int32* bufstreams, Int32 bufferMode);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_transform_feedback")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTransformFeedbackAttribsNV(Int32 count, Int32* attribs, Int32 bufferMode);

			[RequiredByFeature("GL_NV_transform_feedback")]
			[ThreadStatic]
			internal static glTransformFeedbackAttribsNV pglTransformFeedbackAttribsNV;

			[RequiredByFeature("GL_NV_transform_feedback")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTransformFeedbackVaryingsNV(UInt32 program, Int32 count, Int32* locations, Int32 bufferMode);

			[RequiredByFeature("GL_NV_transform_feedback")]
			[ThreadStatic]
			internal static glTransformFeedbackVaryingsNV pglTransformFeedbackVaryingsNV;

			[RequiredByFeature("GL_NV_transform_feedback")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glActiveVaryingNV(UInt32 program, String name);

			[RequiredByFeature("GL_NV_transform_feedback")]
			[ThreadStatic]
			internal static glActiveVaryingNV pglActiveVaryingNV;

			[RequiredByFeature("GL_NV_transform_feedback")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate Int32 glGetVaryingLocationNV(UInt32 program, String name);

			[RequiredByFeature("GL_NV_transform_feedback")]
			[ThreadStatic]
			internal static glGetVaryingLocationNV pglGetVaryingLocationNV;

			[RequiredByFeature("GL_NV_transform_feedback")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetActiveVaryingNV(UInt32 program, UInt32 index, Int32 bufSize, Int32* length, Int32* size, Int32* type, [Out] StringBuilder name);

			[RequiredByFeature("GL_NV_transform_feedback")]
			[ThreadStatic]
			internal static glGetActiveVaryingNV pglGetActiveVaryingNV;

			[RequiredByFeature("GL_NV_transform_feedback")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetTransformFeedbackVaryingNV(UInt32 program, UInt32 index, Int32* location);

			[RequiredByFeature("GL_NV_transform_feedback")]
			[ThreadStatic]
			internal static glGetTransformFeedbackVaryingNV pglGetTransformFeedbackVaryingNV;

			[RequiredByFeature("GL_NV_transform_feedback")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTransformFeedbackStreamAttribsNV(Int32 count, Int32* attribs, Int32 nbuffers, Int32* bufstreams, Int32 bufferMode);

			[RequiredByFeature("GL_NV_transform_feedback")]
			[ThreadStatic]
			internal static glTransformFeedbackStreamAttribsNV pglTransformFeedbackStreamAttribsNV;

		}
	}

}
