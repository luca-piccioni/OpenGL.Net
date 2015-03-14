
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
		/// Value of GL_DEBUG_OUTPUT_SYNCHRONOUS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_debug_output")]
		public const int DEBUG_OUTPUT_SYNCHRONOUS_ARB = 0x8242;

		/// <summary>
		/// Value of GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_debug_output")]
		public const int DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_ARB = 0x8243;

		/// <summary>
		/// Value of GL_DEBUG_CALLBACK_FUNCTION_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_debug_output")]
		public const int DEBUG_CALLBACK_FUNCTION_ARB = 0x8244;

		/// <summary>
		/// Value of GL_DEBUG_CALLBACK_USER_PARAM_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_debug_output")]
		public const int DEBUG_CALLBACK_USER_PARAM_ARB = 0x8245;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_API_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_debug_output")]
		public const int DEBUG_SOURCE_API_ARB = 0x8246;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_WINDOW_SYSTEM_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_debug_output")]
		public const int DEBUG_SOURCE_WINDOW_SYSTEM_ARB = 0x8247;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_SHADER_COMPILER_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_debug_output")]
		public const int DEBUG_SOURCE_SHADER_COMPILER_ARB = 0x8248;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_THIRD_PARTY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_debug_output")]
		public const int DEBUG_SOURCE_THIRD_PARTY_ARB = 0x8249;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_APPLICATION_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_debug_output")]
		public const int DEBUG_SOURCE_APPLICATION_ARB = 0x824A;

		/// <summary>
		/// Value of GL_DEBUG_SOURCE_OTHER_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_debug_output")]
		public const int DEBUG_SOURCE_OTHER_ARB = 0x824B;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_ERROR_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_debug_output")]
		public const int DEBUG_TYPE_ERROR_ARB = 0x824C;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_debug_output")]
		public const int DEBUG_TYPE_DEPRECATED_BEHAVIOR_ARB = 0x824D;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_debug_output")]
		public const int DEBUG_TYPE_UNDEFINED_BEHAVIOR_ARB = 0x824E;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_PORTABILITY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_debug_output")]
		public const int DEBUG_TYPE_PORTABILITY_ARB = 0x824F;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_PERFORMANCE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_debug_output")]
		public const int DEBUG_TYPE_PERFORMANCE_ARB = 0x8250;

		/// <summary>
		/// Value of GL_DEBUG_TYPE_OTHER_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_debug_output")]
		public const int DEBUG_TYPE_OTHER_ARB = 0x8251;

		/// <summary>
		/// Value of GL_MAX_DEBUG_MESSAGE_LENGTH_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_debug_output")]
		public const int MAX_DEBUG_MESSAGE_LENGTH_ARB = 0x9143;

		/// <summary>
		/// Value of GL_MAX_DEBUG_LOGGED_MESSAGES_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_debug_output")]
		public const int MAX_DEBUG_LOGGED_MESSAGES_ARB = 0x9144;

		/// <summary>
		/// Value of GL_DEBUG_LOGGED_MESSAGES_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_debug_output")]
		public const int DEBUG_LOGGED_MESSAGES_ARB = 0x9145;

		/// <summary>
		/// Value of GL_DEBUG_SEVERITY_HIGH_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_debug_output")]
		public const int DEBUG_SEVERITY_HIGH_ARB = 0x9146;

		/// <summary>
		/// Value of GL_DEBUG_SEVERITY_MEDIUM_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_debug_output")]
		public const int DEBUG_SEVERITY_MEDIUM_ARB = 0x9147;

		/// <summary>
		/// Value of GL_DEBUG_SEVERITY_LOW_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_debug_output")]
		public const int DEBUG_SEVERITY_LOW_ARB = 0x9148;

		/// <summary>
		/// Binding for glDebugMessageControlARB.
		/// </summary>
		/// <param name="source">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="severity">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="enabled">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_debug_output")]
		public static void DebugMessageControlARB(int source, int type, int severity, UInt32[] ids, bool enabled)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglDebugMessageControlARB != null, "pglDebugMessageControlARB not implemented");
					Delegates.pglDebugMessageControlARB(source, type, severity, (Int32)ids.Length, p_ids, enabled);
					CallLog("glDebugMessageControlARB({0}, {1}, {2}, {3}, {4}, {5})", source, type, severity, ids.Length, ids, enabled);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDebugMessageInsertARB.
		/// </summary>
		/// <param name="source">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="severity">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="buf">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_debug_output")]
		public static void DebugMessageInsertARB(int source, int type, UInt32 id, int severity, Int32 length, String buf)
		{
			Debug.Assert(Delegates.pglDebugMessageInsertARB != null, "pglDebugMessageInsertARB not implemented");
			Delegates.pglDebugMessageInsertARB(source, type, id, severity, length, buf);
			CallLog("glDebugMessageInsertARB({0}, {1}, {2}, {3}, {4}, {5})", source, type, id, severity, length, buf);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDebugMessageCallbackARB.
		/// </summary>
		/// <param name="callback">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="userParam">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_debug_output")]
		public static void DebugMessageCallbackARB(IntPtr callback, IntPtr userParam)
		{
			Debug.Assert(Delegates.pglDebugMessageCallbackARB != null, "pglDebugMessageCallbackARB not implemented");
			Delegates.pglDebugMessageCallbackARB(callback, userParam);
			CallLog("glDebugMessageCallbackARB({0}, {1})", callback, userParam);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDebugMessageCallbackARB.
		/// </summary>
		/// <param name="callback">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="userParam">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_debug_output")]
		public static void DebugMessageCallbackARB(IntPtr callback, Object userParam)
		{
			GCHandle pin_userParam = GCHandle.Alloc(userParam, GCHandleType.Pinned);
			try {
				DebugMessageCallbackARB(callback, pin_userParam.AddrOfPinnedObject());
			} finally {
				pin_userParam.Free();
			}
		}

		/// <summary>
		/// Binding for glGetDebugMessageLogARB.
		/// </summary>
		/// <param name="count">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="sources">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="types">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="severities">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="lengths">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="messageLog">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_debug_output")]
		public static UInt32 GetDebugMessageLogARB(Int32 bufSize, int[] sources, int[] types, UInt32[] ids, int[] severities, Int32[] lengths, [Out] StringBuilder messageLog)
		{
			UInt32 retValue;

			unsafe {
				fixed (int* p_sources = sources)
				fixed (int* p_types = types)
				fixed (UInt32* p_ids = ids)
				fixed (int* p_severities = severities)
				fixed (Int32* p_lengths = lengths)
				{
					Debug.Assert(Delegates.pglGetDebugMessageLogARB != null, "pglGetDebugMessageLogARB not implemented");
					retValue = Delegates.pglGetDebugMessageLogARB((UInt32)sources.Length, bufSize, p_sources, p_types, p_ids, p_severities, p_lengths, messageLog);
					CallLog("glGetDebugMessageLogARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}) = {8}", sources.Length, bufSize, sources, types, ids, severities, lengths, messageLog, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

	}

}
