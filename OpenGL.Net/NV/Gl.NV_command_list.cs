
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
		/// Value of GL_TERMINATE_SEQUENCE_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list")]
		public const int TERMINATE_SEQUENCE_COMMAND_NV = 0x0000;

		/// <summary>
		/// Value of GL_NOP_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list")]
		public const int NOP_COMMAND_NV = 0x0001;

		/// <summary>
		/// Value of GL_DRAW_ELEMENTS_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list")]
		public const int DRAW_ELEMENTS_COMMAND_NV = 0x0002;

		/// <summary>
		/// Value of GL_DRAW_ARRAYS_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list")]
		public const int DRAW_ARRAYS_COMMAND_NV = 0x0003;

		/// <summary>
		/// Value of GL_DRAW_ELEMENTS_STRIP_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list")]
		public const int DRAW_ELEMENTS_STRIP_COMMAND_NV = 0x0004;

		/// <summary>
		/// Value of GL_DRAW_ARRAYS_STRIP_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list")]
		public const int DRAW_ARRAYS_STRIP_COMMAND_NV = 0x0005;

		/// <summary>
		/// Value of GL_DRAW_ELEMENTS_INSTANCED_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list")]
		public const int DRAW_ELEMENTS_INSTANCED_COMMAND_NV = 0x0006;

		/// <summary>
		/// Value of GL_DRAW_ARRAYS_INSTANCED_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list")]
		public const int DRAW_ARRAYS_INSTANCED_COMMAND_NV = 0x0007;

		/// <summary>
		/// Value of GL_ELEMENT_ADDRESS_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list")]
		public const int ELEMENT_ADDRESS_COMMAND_NV = 0x0008;

		/// <summary>
		/// Value of GL_ATTRIBUTE_ADDRESS_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list")]
		public const int ATTRIBUTE_ADDRESS_COMMAND_NV = 0x0009;

		/// <summary>
		/// Value of GL_UNIFORM_ADDRESS_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list")]
		public const int UNIFORM_ADDRESS_COMMAND_NV = 0x000A;

		/// <summary>
		/// Value of GL_BLEND_COLOR_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list")]
		public const int BLEND_COLOR_COMMAND_NV = 0x000B;

		/// <summary>
		/// Value of GL_STENCIL_REF_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list")]
		public const int STENCIL_REF_COMMAND_NV = 0x000C;

		/// <summary>
		/// Value of GL_LINE_WIDTH_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list")]
		public const int LINE_WIDTH_COMMAND_NV = 0x000D;

		/// <summary>
		/// Value of GL_POLYGON_OFFSET_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list")]
		public const int POLYGON_OFFSET_COMMAND_NV = 0x000E;

		/// <summary>
		/// Value of GL_ALPHA_REF_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list")]
		public const int ALPHA_REF_COMMAND_NV = 0x000F;

		/// <summary>
		/// Value of GL_VIEWPORT_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list")]
		public const int VIEWPORT_COMMAND_NV = 0x0010;

		/// <summary>
		/// Value of GL_SCISSOR_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list")]
		public const int SCISSOR_COMMAND_NV = 0x0011;

		/// <summary>
		/// Value of GL_FRONT_FACE_COMMAND_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_command_list")]
		public const int FRONT_FACE_COMMAND_NV = 0x0012;

		/// <summary>
		/// Binding for glCreateStatesNV.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="states">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list")]
		public static void CreateStateNV(Int32 n, UInt32[] states)
		{
			unsafe {
				fixed (UInt32* p_states = states)
				{
					Debug.Assert(Delegates.pglCreateStatesNV != null, "pglCreateStatesNV not implemented");
					Delegates.pglCreateStatesNV(n, p_states);
					LogFunction("glCreateStatesNV({0}, {1})", n, LogValue(states));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDeleteStatesNV.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="states">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list")]
		public static void DeleteStateNV(Int32 n, UInt32[] states)
		{
			unsafe {
				fixed (UInt32* p_states = states)
				{
					Debug.Assert(Delegates.pglDeleteStatesNV != null, "pglDeleteStatesNV not implemented");
					Delegates.pglDeleteStatesNV(n, p_states);
					LogFunction("glDeleteStatesNV({0}, {1})", n, LogValue(states));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glIsStateNV.
		/// </summary>
		/// <param name="state">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list")]
		public static bool IsStateNV(UInt32 state)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsStateNV != null, "pglIsStateNV not implemented");
			retValue = Delegates.pglIsStateNV(state);
			LogFunction("glIsStateNV({0}) = {1}", state, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glStateCaptureNV.
		/// </summary>
		/// <param name="state">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="mode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list")]
		public static void StateCaptureNV(UInt32 state, Int32 mode)
		{
			Debug.Assert(Delegates.pglStateCaptureNV != null, "pglStateCaptureNV not implemented");
			Delegates.pglStateCaptureNV(state, mode);
			LogFunction("glStateCaptureNV({0}, {1})", state, LogEnumName(mode));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetCommandHeaderNV.
		/// </summary>
		/// <param name="tokenID">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list")]
		public static UInt32 GetNV(Int32 tokenID, UInt32 size)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglGetCommandHeaderNV != null, "pglGetCommandHeaderNV not implemented");
			retValue = Delegates.pglGetCommandHeaderNV(tokenID, size);
			LogFunction("glGetCommandHeaderNV({0}, {1}) = {2}", LogEnumName(tokenID), size, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetStageIndexNV.
		/// </summary>
		/// <param name="shadertype">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list")]
		public static UInt16 GetStageIndexNV(Int32 shadertype)
		{
			UInt16 retValue;

			Debug.Assert(Delegates.pglGetStageIndexNV != null, "pglGetStageIndexNV not implemented");
			retValue = Delegates.pglGetStageIndexNV(shadertype);
			LogFunction("glGetStageIndexNV({0}) = {1}", LogEnumName(shadertype), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glDrawCommandsNV.
		/// </summary>
		/// <param name="primitiveMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="indirects">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="sizes">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list")]
		public static void DrawCommandsNV(Int32 primitiveMode, UInt32 buffer, IntPtr[] indirects, Int32[] sizes, UInt32 count)
		{
			unsafe {
				fixed (IntPtr* p_indirects = indirects)
				fixed (Int32* p_sizes = sizes)
				{
					Debug.Assert(Delegates.pglDrawCommandsNV != null, "pglDrawCommandsNV not implemented");
					Delegates.pglDrawCommandsNV(primitiveMode, buffer, p_indirects, p_sizes, count);
					LogFunction("glDrawCommandsNV({0}, {1}, {2}, {3}, {4})", LogEnumName(primitiveMode), buffer, LogValue(indirects), LogValue(sizes), count);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDrawCommandsAddressNV.
		/// </summary>
		/// <param name="primitiveMode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="indirects">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		/// <param name="sizes">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list")]
		public static void DrawCommandsAddressNV(Int32 primitiveMode, UInt64[] indirects, Int32[] sizes, UInt32 count)
		{
			unsafe {
				fixed (UInt64* p_indirects = indirects)
				fixed (Int32* p_sizes = sizes)
				{
					Debug.Assert(Delegates.pglDrawCommandsAddressNV != null, "pglDrawCommandsAddressNV not implemented");
					Delegates.pglDrawCommandsAddressNV(primitiveMode, p_indirects, p_sizes, count);
					LogFunction("glDrawCommandsAddressNV({0}, {1}, {2}, {3})", LogEnumName(primitiveMode), LogValue(indirects), LogValue(sizes), count);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDrawCommandsStatesNV.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="indirects">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="sizes">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="states">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="fbos">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list")]
		public static void DrawCommandsStateNV(UInt32 buffer, IntPtr[] indirects, Int32[] sizes, UInt32[] states, UInt32[] fbos, UInt32 count)
		{
			unsafe {
				fixed (IntPtr* p_indirects = indirects)
				fixed (Int32* p_sizes = sizes)
				fixed (UInt32* p_states = states)
				fixed (UInt32* p_fbos = fbos)
				{
					Debug.Assert(Delegates.pglDrawCommandsStatesNV != null, "pglDrawCommandsStatesNV not implemented");
					Delegates.pglDrawCommandsStatesNV(buffer, p_indirects, p_sizes, p_states, p_fbos, count);
					LogFunction("glDrawCommandsStatesNV({0}, {1}, {2}, {3}, {4}, {5})", buffer, LogValue(indirects), LogValue(sizes), LogValue(states), LogValue(fbos), count);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDrawCommandsStatesAddressNV.
		/// </summary>
		/// <param name="indirects">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		/// <param name="sizes">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="states">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="fbos">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list")]
		public static void DrawCommandsStatesAddresNV(UInt64[] indirects, Int32[] sizes, UInt32[] states, UInt32[] fbos, UInt32 count)
		{
			unsafe {
				fixed (UInt64* p_indirects = indirects)
				fixed (Int32* p_sizes = sizes)
				fixed (UInt32* p_states = states)
				fixed (UInt32* p_fbos = fbos)
				{
					Debug.Assert(Delegates.pglDrawCommandsStatesAddressNV != null, "pglDrawCommandsStatesAddressNV not implemented");
					Delegates.pglDrawCommandsStatesAddressNV(p_indirects, p_sizes, p_states, p_fbos, count);
					LogFunction("glDrawCommandsStatesAddressNV({0}, {1}, {2}, {3}, {4})", LogValue(indirects), LogValue(sizes), LogValue(states), LogValue(fbos), count);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCreateCommandListsNV.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="lists">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list")]
		public static void CreateCommandListsNV(Int32 n, UInt32[] lists)
		{
			unsafe {
				fixed (UInt32* p_lists = lists)
				{
					Debug.Assert(Delegates.pglCreateCommandListsNV != null, "pglCreateCommandListsNV not implemented");
					Delegates.pglCreateCommandListsNV(n, p_lists);
					LogFunction("glCreateCommandListsNV({0}, {1})", n, LogValue(lists));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDeleteCommandListsNV.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="lists">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list")]
		public static void DeleteCommandListsNV(Int32 n, UInt32[] lists)
		{
			unsafe {
				fixed (UInt32* p_lists = lists)
				{
					Debug.Assert(Delegates.pglDeleteCommandListsNV != null, "pglDeleteCommandListsNV not implemented");
					Delegates.pglDeleteCommandListsNV(n, p_lists);
					LogFunction("glDeleteCommandListsNV({0}, {1})", n, LogValue(lists));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glIsCommandListNV.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list")]
		public static bool IsCommandListNV(UInt32 list)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsCommandListNV != null, "pglIsCommandListNV not implemented");
			retValue = Delegates.pglIsCommandListNV(list);
			LogFunction("glIsCommandListNV({0}) = {1}", list, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glListDrawCommandsStatesClientNV.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="segment">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="indirects">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="sizes">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="states">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="fbos">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list")]
		public static void ListDrawCommandsStatesClientNV(UInt32 list, UInt32 segment, IntPtr[] indirects, Int32[] sizes, UInt32[] states, UInt32[] fbos, UInt32 count)
		{
			unsafe {
				fixed (IntPtr* p_indirects = indirects)
				fixed (Int32* p_sizes = sizes)
				fixed (UInt32* p_states = states)
				fixed (UInt32* p_fbos = fbos)
				{
					Debug.Assert(Delegates.pglListDrawCommandsStatesClientNV != null, "pglListDrawCommandsStatesClientNV not implemented");
					Delegates.pglListDrawCommandsStatesClientNV(list, segment, p_indirects, p_sizes, p_states, p_fbos, count);
					LogFunction("glListDrawCommandsStatesClientNV({0}, {1}, {2}, {3}, {4}, {5}, {6})", list, segment, LogValue(indirects), LogValue(sizes), LogValue(states), LogValue(fbos), count);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCommandListSegmentsNV.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="segments">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list")]
		public static void CommandListSegmentsNV(UInt32 list, UInt32 segments)
		{
			Debug.Assert(Delegates.pglCommandListSegmentsNV != null, "pglCommandListSegmentsNV not implemented");
			Delegates.pglCommandListSegmentsNV(list, segments);
			LogFunction("glCommandListSegmentsNV({0}, {1})", list, segments);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCompileCommandListNV.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list")]
		public static void CompileCommandListNV(UInt32 list)
		{
			Debug.Assert(Delegates.pglCompileCommandListNV != null, "pglCompileCommandListNV not implemented");
			Delegates.pglCompileCommandListNV(list);
			LogFunction("glCompileCommandListNV({0})", list);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCallCommandListNV.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_command_list")]
		public static void CallCommandListNV(UInt32 list)
		{
			Debug.Assert(Delegates.pglCallCommandListNV != null, "pglCallCommandListNV not implemented");
			Delegates.pglCallCommandListNV(list);
			LogFunction("glCallCommandListNV({0})", list);
			DebugCheckErrors(null);
		}

	}

}
