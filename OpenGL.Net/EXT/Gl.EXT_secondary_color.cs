
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
		/// Value of GL_COLOR_SUM_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public const int COLOR_SUM_EXT = 0x8458;

		/// <summary>
		/// Value of GL_CURRENT_SECONDARY_COLOR_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public const int CURRENT_SECONDARY_COLOR_EXT = 0x8459;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_ARRAY_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public const int SECONDARY_COLOR_ARRAY_SIZE_EXT = 0x845A;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_ARRAY_TYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public const int SECONDARY_COLOR_ARRAY_TYPE_EXT = 0x845B;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_ARRAY_STRIDE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public const int SECONDARY_COLOR_ARRAY_STRIDE_EXT = 0x845C;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_ARRAY_POINTER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public const int SECONDARY_COLOR_ARRAY_POINTER_EXT = 0x845D;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public const int SECONDARY_COLOR_ARRAY_EXT = 0x845E;

		/// <summary>
		/// Binding for glSecondaryColor3bEXT.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public static void SecondaryColor3EXT(sbyte red, sbyte green, sbyte blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3bEXT != null, "pglSecondaryColor3bEXT not implemented");
			Delegates.pglSecondaryColor3bEXT(red, green, blue);
			CallLog("glSecondaryColor3bEXT({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSecondaryColor3bvEXT.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public static void SecondaryColor3EXT(sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3bvEXT != null, "pglSecondaryColor3bvEXT not implemented");
					Delegates.pglSecondaryColor3bvEXT(p_v);
					CallLog("glSecondaryColor3bvEXT({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSecondaryColor3dEXT.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public static void SecondaryColor3EXT(double red, double green, double blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3dEXT != null, "pglSecondaryColor3dEXT not implemented");
			Delegates.pglSecondaryColor3dEXT(red, green, blue);
			CallLog("glSecondaryColor3dEXT({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSecondaryColor3dvEXT.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public static void SecondaryColor3EXT(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3dvEXT != null, "pglSecondaryColor3dvEXT not implemented");
					Delegates.pglSecondaryColor3dvEXT(p_v);
					CallLog("glSecondaryColor3dvEXT({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSecondaryColor3fEXT.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public static void SecondaryColor3EXT(float red, float green, float blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3fEXT != null, "pglSecondaryColor3fEXT not implemented");
			Delegates.pglSecondaryColor3fEXT(red, green, blue);
			CallLog("glSecondaryColor3fEXT({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSecondaryColor3fvEXT.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public static void SecondaryColor3EXT(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3fvEXT != null, "pglSecondaryColor3fvEXT not implemented");
					Delegates.pglSecondaryColor3fvEXT(p_v);
					CallLog("glSecondaryColor3fvEXT({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSecondaryColor3iEXT.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public static void SecondaryColor3EXT(Int32 red, Int32 green, Int32 blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3iEXT != null, "pglSecondaryColor3iEXT not implemented");
			Delegates.pglSecondaryColor3iEXT(red, green, blue);
			CallLog("glSecondaryColor3iEXT({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSecondaryColor3ivEXT.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public static void SecondaryColor3EXT(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3ivEXT != null, "pglSecondaryColor3ivEXT not implemented");
					Delegates.pglSecondaryColor3ivEXT(p_v);
					CallLog("glSecondaryColor3ivEXT({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSecondaryColor3sEXT.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public static void SecondaryColor3EXT(Int16 red, Int16 green, Int16 blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3sEXT != null, "pglSecondaryColor3sEXT not implemented");
			Delegates.pglSecondaryColor3sEXT(red, green, blue);
			CallLog("glSecondaryColor3sEXT({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSecondaryColor3svEXT.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public static void SecondaryColor3EXT(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3svEXT != null, "pglSecondaryColor3svEXT not implemented");
					Delegates.pglSecondaryColor3svEXT(p_v);
					CallLog("glSecondaryColor3svEXT({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSecondaryColor3ubEXT.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:byte"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:byte"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public static void SecondaryColor3EXT(byte red, byte green, byte blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3ubEXT != null, "pglSecondaryColor3ubEXT not implemented");
			Delegates.pglSecondaryColor3ubEXT(red, green, blue);
			CallLog("glSecondaryColor3ubEXT({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSecondaryColor3ubvEXT.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public static void SecondaryColor3EXT(byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3ubvEXT != null, "pglSecondaryColor3ubvEXT not implemented");
					Delegates.pglSecondaryColor3ubvEXT(p_v);
					CallLog("glSecondaryColor3ubvEXT({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSecondaryColor3uiEXT.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public static void SecondaryColor3EXT(UInt32 red, UInt32 green, UInt32 blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3uiEXT != null, "pglSecondaryColor3uiEXT not implemented");
			Delegates.pglSecondaryColor3uiEXT(red, green, blue);
			CallLog("glSecondaryColor3uiEXT({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSecondaryColor3uivEXT.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public static void SecondaryColor3EXT(UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3uivEXT != null, "pglSecondaryColor3uivEXT not implemented");
					Delegates.pglSecondaryColor3uivEXT(p_v);
					CallLog("glSecondaryColor3uivEXT({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSecondaryColor3usEXT.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public static void SecondaryColor3EXT(UInt16 red, UInt16 green, UInt16 blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3usEXT != null, "pglSecondaryColor3usEXT not implemented");
			Delegates.pglSecondaryColor3usEXT(red, green, blue);
			CallLog("glSecondaryColor3usEXT({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSecondaryColor3usvEXT.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public static void SecondaryColor3EXT(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3usvEXT != null, "pglSecondaryColor3usvEXT not implemented");
					Delegates.pglSecondaryColor3usvEXT(p_v);
					CallLog("glSecondaryColor3usvEXT({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSecondaryColorPointerEXT.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public static void SecondaryColorPointerEXT(Int32 size, int type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglSecondaryColorPointerEXT != null, "pglSecondaryColorPointerEXT not implemented");
			Delegates.pglSecondaryColorPointerEXT(size, type, stride, pointer);
			CallLog("glSecondaryColorPointerEXT({0}, {1}, {2}, {3})", size, type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSecondaryColorPointerEXT.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public static void SecondaryColorPointerEXT(Int32 size, ColorPointerType type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglSecondaryColorPointerEXT != null, "pglSecondaryColorPointerEXT not implemented");
			Delegates.pglSecondaryColorPointerEXT(size, (int)type, stride, pointer);
			CallLog("glSecondaryColorPointerEXT({0}, {1}, {2}, {3})", size, type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSecondaryColorPointerEXT.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public static void SecondaryColorPointerEXT(Int32 size, int type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				SecondaryColorPointerEXT(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glSecondaryColorPointerEXT.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_secondary_color")]
		public static void SecondaryColorPointerEXT(Int32 size, ColorPointerType type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				SecondaryColorPointerEXT(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

	}

}
