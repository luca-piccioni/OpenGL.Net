
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
		/// Value of GL_DEBUG_CATEGORY_API_ERROR_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_debug_output")]
		public const int DEBUG_CATEGORY_API_ERROR_AMD = 0x9149;

		/// <summary>
		/// Value of GL_DEBUG_CATEGORY_WINDOW_SYSTEM_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_debug_output")]
		public const int DEBUG_CATEGORY_WINDOW_SYSTEM_AMD = 0x914A;

		/// <summary>
		/// Value of GL_DEBUG_CATEGORY_DEPRECATION_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_debug_output")]
		public const int DEBUG_CATEGORY_DEPRECATION_AMD = 0x914B;

		/// <summary>
		/// Value of GL_DEBUG_CATEGORY_UNDEFINED_BEHAVIOR_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_debug_output")]
		public const int DEBUG_CATEGORY_UNDEFINED_BEHAVIOR_AMD = 0x914C;

		/// <summary>
		/// Value of GL_DEBUG_CATEGORY_PERFORMANCE_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_debug_output")]
		public const int DEBUG_CATEGORY_PERFORMANCE_AMD = 0x914D;

		/// <summary>
		/// Value of GL_DEBUG_CATEGORY_SHADER_COMPILER_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_debug_output")]
		public const int DEBUG_CATEGORY_SHADER_COMPILER_AMD = 0x914E;

		/// <summary>
		/// Value of GL_DEBUG_CATEGORY_APPLICATION_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_debug_output")]
		public const int DEBUG_CATEGORY_APPLICATION_AMD = 0x914F;

		/// <summary>
		/// Value of GL_DEBUG_CATEGORY_OTHER_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_debug_output")]
		public const int DEBUG_CATEGORY_OTHER_AMD = 0x9150;

		/// <summary>
		/// Binding for glDebugMessageEnableAMD.
		/// </summary>
		/// <param name="category">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="severity">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="enabled">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_debug_output")]
		public static void DebugMessageEnableAMD(Int32 category, Int32 severity, UInt32[] ids, bool enabled)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglDebugMessageEnableAMD != null, "pglDebugMessageEnableAMD not implemented");
					Delegates.pglDebugMessageEnableAMD(category, severity, (Int32)ids.Length, p_ids, enabled);
					LogFunction("glDebugMessageEnableAMD({0}, {1}, {2}, {3}, {4})", LogEnumName(category), LogEnumName(severity), ids.Length, LogValue(ids), enabled);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDebugMessageInsertAMD.
		/// </summary>
		/// <param name="category">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="severity">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="buf">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_debug_output")]
		public static void DebugMessageInsertAMD(Int32 category, Int32 severity, UInt32 id, Int32 length, String buf)
		{
			Debug.Assert(Delegates.pglDebugMessageInsertAMD != null, "pglDebugMessageInsertAMD not implemented");
			Delegates.pglDebugMessageInsertAMD(category, severity, id, length, buf);
			LogFunction("glDebugMessageInsertAMD({0}, {1}, {2}, {3}, {4})", LogEnumName(category), LogEnumName(severity), id, length, buf);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDebugMessageCallbackAMD.
		/// </summary>
		/// <param name="callback">
		/// A <see cref="T:Gl.DebugProc"/>.
		/// </param>
		/// <param name="userParam">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_debug_output")]
		public static void DebugMessageCallbackAMD(Gl.DebugProc callback, IntPtr userParam)
		{
			Debug.Assert(Delegates.pglDebugMessageCallbackAMD != null, "pglDebugMessageCallbackAMD not implemented");
			Delegates.pglDebugMessageCallbackAMD(callback, userParam);
			LogFunction("glDebugMessageCallbackAMD({0}, 0x{1})", callback, userParam.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetDebugMessageLogAMD.
		/// </summary>
		/// <param name="bufsize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="categories">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="severities">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="lengths">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="message">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_debug_output")]
		public static UInt32 GetDebugMessageLogAMD(Int32 bufsize, [Out] Int32[] categories, [Out] UInt32[] severities, [Out] UInt32[] ids, [Out] Int32[] lengths, [Out] StringBuilder message)
		{
			UInt32 retValue;

			unsafe {
				fixed (Int32* p_categories = categories)
				fixed (UInt32* p_severities = severities)
				fixed (UInt32* p_ids = ids)
				fixed (Int32* p_lengths = lengths)
				{
					Debug.Assert(Delegates.pglGetDebugMessageLogAMD != null, "pglGetDebugMessageLogAMD not implemented");
					retValue = Delegates.pglGetDebugMessageLogAMD((UInt32)categories.Length, bufsize, p_categories, p_severities, p_ids, p_lengths, message);
					LogFunction("glGetDebugMessageLogAMD({0}, {1}, {2}, {3}, {4}, {5}, {6}) = {7}", categories.Length, bufsize, LogEnumName(categories), LogValue(severities), LogValue(ids), LogValue(lengths), message, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
