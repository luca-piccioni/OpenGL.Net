
// Copyright (C) 2015-2016 Luca Piccioni
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
		/// Value of GL_TANGENT_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public const int TANGENT_ARRAY_EXT = 0x8439;

		/// <summary>
		/// Value of GL_BINORMAL_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public const int BINORMAL_ARRAY_EXT = 0x843A;

		/// <summary>
		/// Value of GL_CURRENT_TANGENT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public const int CURRENT_TANGENT_EXT = 0x843B;

		/// <summary>
		/// Value of GL_CURRENT_BINORMAL_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public const int CURRENT_BINORMAL_EXT = 0x843C;

		/// <summary>
		/// Value of GL_TANGENT_ARRAY_TYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public const int TANGENT_ARRAY_TYPE_EXT = 0x843E;

		/// <summary>
		/// Value of GL_TANGENT_ARRAY_STRIDE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public const int TANGENT_ARRAY_STRIDE_EXT = 0x843F;

		/// <summary>
		/// Value of GL_BINORMAL_ARRAY_TYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public const int BINORMAL_ARRAY_TYPE_EXT = 0x8440;

		/// <summary>
		/// Value of GL_BINORMAL_ARRAY_STRIDE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public const int BINORMAL_ARRAY_STRIDE_EXT = 0x8441;

		/// <summary>
		/// Value of GL_TANGENT_ARRAY_POINTER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public const int TANGENT_ARRAY_POINTER_EXT = 0x8442;

		/// <summary>
		/// Value of GL_BINORMAL_ARRAY_POINTER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public const int BINORMAL_ARRAY_POINTER_EXT = 0x8443;

		/// <summary>
		/// Value of GL_MAP1_TANGENT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public const int MAP1_TANGENT_EXT = 0x8444;

		/// <summary>
		/// Value of GL_MAP2_TANGENT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public const int MAP2_TANGENT_EXT = 0x8445;

		/// <summary>
		/// Value of GL_MAP1_BINORMAL_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public const int MAP1_BINORMAL_EXT = 0x8446;

		/// <summary>
		/// Value of GL_MAP2_BINORMAL_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public const int MAP2_BINORMAL_EXT = 0x8447;

		/// <summary>
		/// Binding for glTangent3bEXT.
		/// </summary>
		/// <param name="tx">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="ty">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="tz">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void Tangent3EXT(sbyte tx, sbyte ty, sbyte tz)
		{
			Debug.Assert(Delegates.pglTangent3bEXT != null, "pglTangent3bEXT not implemented");
			Delegates.pglTangent3bEXT(tx, ty, tz);
			LogFunction("glTangent3bEXT({0}, {1}, {2})", tx, ty, tz);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTangent3bvEXT.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void Tangent3EXT(sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglTangent3bvEXT != null, "pglTangent3bvEXT not implemented");
					Delegates.pglTangent3bvEXT(p_v);
					LogFunction("glTangent3bvEXT({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTangent3dEXT.
		/// </summary>
		/// <param name="tx">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="ty">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="tz">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void Tangent3EXT(double tx, double ty, double tz)
		{
			Debug.Assert(Delegates.pglTangent3dEXT != null, "pglTangent3dEXT not implemented");
			Delegates.pglTangent3dEXT(tx, ty, tz);
			LogFunction("glTangent3dEXT({0}, {1}, {2})", tx, ty, tz);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTangent3dvEXT.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void Tangent3EXT(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglTangent3dvEXT != null, "pglTangent3dvEXT not implemented");
					Delegates.pglTangent3dvEXT(p_v);
					LogFunction("glTangent3dvEXT({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTangent3fEXT.
		/// </summary>
		/// <param name="tx">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="ty">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="tz">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void Tangent3EXT(float tx, float ty, float tz)
		{
			Debug.Assert(Delegates.pglTangent3fEXT != null, "pglTangent3fEXT not implemented");
			Delegates.pglTangent3fEXT(tx, ty, tz);
			LogFunction("glTangent3fEXT({0}, {1}, {2})", tx, ty, tz);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTangent3fvEXT.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void Tangent3EXT(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTangent3fvEXT != null, "pglTangent3fvEXT not implemented");
					Delegates.pglTangent3fvEXT(p_v);
					LogFunction("glTangent3fvEXT({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTangent3iEXT.
		/// </summary>
		/// <param name="tx">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ty">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="tz">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void Tangent3EXT(Int32 tx, Int32 ty, Int32 tz)
		{
			Debug.Assert(Delegates.pglTangent3iEXT != null, "pglTangent3iEXT not implemented");
			Delegates.pglTangent3iEXT(tx, ty, tz);
			LogFunction("glTangent3iEXT({0}, {1}, {2})", tx, ty, tz);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTangent3ivEXT.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void Tangent3EXT(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglTangent3ivEXT != null, "pglTangent3ivEXT not implemented");
					Delegates.pglTangent3ivEXT(p_v);
					LogFunction("glTangent3ivEXT({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTangent3sEXT.
		/// </summary>
		/// <param name="tx">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="ty">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="tz">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void Tangent3EXT(Int16 tx, Int16 ty, Int16 tz)
		{
			Debug.Assert(Delegates.pglTangent3sEXT != null, "pglTangent3sEXT not implemented");
			Delegates.pglTangent3sEXT(tx, ty, tz);
			LogFunction("glTangent3sEXT({0}, {1}, {2})", tx, ty, tz);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTangent3svEXT.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void Tangent3EXT(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglTangent3svEXT != null, "pglTangent3svEXT not implemented");
					Delegates.pglTangent3svEXT(p_v);
					LogFunction("glTangent3svEXT({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBinormal3bEXT.
		/// </summary>
		/// <param name="bx">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="by">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="bz">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void Binormal3EXT(sbyte bx, sbyte by, sbyte bz)
		{
			Debug.Assert(Delegates.pglBinormal3bEXT != null, "pglBinormal3bEXT not implemented");
			Delegates.pglBinormal3bEXT(bx, by, bz);
			LogFunction("glBinormal3bEXT({0}, {1}, {2})", bx, by, bz);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBinormal3bvEXT.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void Binormal3EXT(sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglBinormal3bvEXT != null, "pglBinormal3bvEXT not implemented");
					Delegates.pglBinormal3bvEXT(p_v);
					LogFunction("glBinormal3bvEXT({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBinormal3dEXT.
		/// </summary>
		/// <param name="bx">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="by">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="bz">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void Binormal3EXT(double bx, double by, double bz)
		{
			Debug.Assert(Delegates.pglBinormal3dEXT != null, "pglBinormal3dEXT not implemented");
			Delegates.pglBinormal3dEXT(bx, by, bz);
			LogFunction("glBinormal3dEXT({0}, {1}, {2})", bx, by, bz);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBinormal3dvEXT.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void Binormal3EXT(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglBinormal3dvEXT != null, "pglBinormal3dvEXT not implemented");
					Delegates.pglBinormal3dvEXT(p_v);
					LogFunction("glBinormal3dvEXT({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBinormal3fEXT.
		/// </summary>
		/// <param name="bx">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="by">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="bz">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void Binormal3EXT(float bx, float by, float bz)
		{
			Debug.Assert(Delegates.pglBinormal3fEXT != null, "pglBinormal3fEXT not implemented");
			Delegates.pglBinormal3fEXT(bx, by, bz);
			LogFunction("glBinormal3fEXT({0}, {1}, {2})", bx, by, bz);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBinormal3fvEXT.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void Binormal3EXT(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglBinormal3fvEXT != null, "pglBinormal3fvEXT not implemented");
					Delegates.pglBinormal3fvEXT(p_v);
					LogFunction("glBinormal3fvEXT({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBinormal3iEXT.
		/// </summary>
		/// <param name="bx">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="by">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bz">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void Binormal3EXT(Int32 bx, Int32 by, Int32 bz)
		{
			Debug.Assert(Delegates.pglBinormal3iEXT != null, "pglBinormal3iEXT not implemented");
			Delegates.pglBinormal3iEXT(bx, by, bz);
			LogFunction("glBinormal3iEXT({0}, {1}, {2})", bx, by, bz);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBinormal3ivEXT.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void Binormal3EXT(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglBinormal3ivEXT != null, "pglBinormal3ivEXT not implemented");
					Delegates.pglBinormal3ivEXT(p_v);
					LogFunction("glBinormal3ivEXT({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBinormal3sEXT.
		/// </summary>
		/// <param name="bx">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="by">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="bz">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void Binormal3EXT(Int16 bx, Int16 by, Int16 bz)
		{
			Debug.Assert(Delegates.pglBinormal3sEXT != null, "pglBinormal3sEXT not implemented");
			Delegates.pglBinormal3sEXT(bx, by, bz);
			LogFunction("glBinormal3sEXT({0}, {1}, {2})", bx, by, bz);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBinormal3svEXT.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void Binormal3EXT(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglBinormal3svEXT != null, "pglBinormal3svEXT not implemented");
					Delegates.pglBinormal3svEXT(p_v);
					LogFunction("glBinormal3svEXT({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTangentPointerEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void TangentPointerEXT(Int32 type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglTangentPointerEXT != null, "pglTangentPointerEXT not implemented");
			Delegates.pglTangentPointerEXT(type, stride, pointer);
			LogFunction("glTangentPointerEXT({0}, {1}, 0x{2})", LogEnumName(type), stride, pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTangentPointerEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void TangentPointerEXT(Int32 type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				TangentPointerEXT(type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glBinormalPointerEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void BinormalPointerEXT(Int32 type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglBinormalPointerEXT != null, "pglBinormalPointerEXT not implemented");
			Delegates.pglBinormalPointerEXT(type, stride, pointer);
			LogFunction("glBinormalPointerEXT({0}, {1}, 0x{2})", LogEnumName(type), stride, pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBinormalPointerEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_coordinate_frame")]
		public static void BinormalPointerEXT(Int32 type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				BinormalPointerEXT(type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTangent3bEXT", ExactSpelling = true)]
			internal extern static void glTangent3bEXT(sbyte tx, sbyte ty, sbyte tz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTangent3bvEXT", ExactSpelling = true)]
			internal extern static unsafe void glTangent3bvEXT(sbyte* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTangent3dEXT", ExactSpelling = true)]
			internal extern static void glTangent3dEXT(double tx, double ty, double tz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTangent3dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glTangent3dvEXT(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTangent3fEXT", ExactSpelling = true)]
			internal extern static void glTangent3fEXT(float tx, float ty, float tz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTangent3fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glTangent3fvEXT(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTangent3iEXT", ExactSpelling = true)]
			internal extern static void glTangent3iEXT(Int32 tx, Int32 ty, Int32 tz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTangent3ivEXT", ExactSpelling = true)]
			internal extern static unsafe void glTangent3ivEXT(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTangent3sEXT", ExactSpelling = true)]
			internal extern static void glTangent3sEXT(Int16 tx, Int16 ty, Int16 tz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTangent3svEXT", ExactSpelling = true)]
			internal extern static unsafe void glTangent3svEXT(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBinormal3bEXT", ExactSpelling = true)]
			internal extern static void glBinormal3bEXT(sbyte bx, sbyte by, sbyte bz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBinormal3bvEXT", ExactSpelling = true)]
			internal extern static unsafe void glBinormal3bvEXT(sbyte* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBinormal3dEXT", ExactSpelling = true)]
			internal extern static void glBinormal3dEXT(double bx, double by, double bz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBinormal3dvEXT", ExactSpelling = true)]
			internal extern static unsafe void glBinormal3dvEXT(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBinormal3fEXT", ExactSpelling = true)]
			internal extern static void glBinormal3fEXT(float bx, float by, float bz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBinormal3fvEXT", ExactSpelling = true)]
			internal extern static unsafe void glBinormal3fvEXT(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBinormal3iEXT", ExactSpelling = true)]
			internal extern static void glBinormal3iEXT(Int32 bx, Int32 by, Int32 bz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBinormal3ivEXT", ExactSpelling = true)]
			internal extern static unsafe void glBinormal3ivEXT(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBinormal3sEXT", ExactSpelling = true)]
			internal extern static void glBinormal3sEXT(Int16 bx, Int16 by, Int16 bz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBinormal3svEXT", ExactSpelling = true)]
			internal extern static unsafe void glBinormal3svEXT(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTangentPointerEXT", ExactSpelling = true)]
			internal extern static unsafe void glTangentPointerEXT(Int32 type, Int32 stride, IntPtr pointer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBinormalPointerEXT", ExactSpelling = true)]
			internal extern static unsafe void glBinormalPointerEXT(Int32 type, Int32 stride, IntPtr pointer);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_coordinate_frame")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTangent3bEXT(sbyte tx, sbyte ty, sbyte tz);

			[ThreadStatic]
			internal static glTangent3bEXT pglTangent3bEXT;

			[RequiredByFeature("GL_EXT_coordinate_frame")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTangent3bvEXT(sbyte* v);

			[ThreadStatic]
			internal static glTangent3bvEXT pglTangent3bvEXT;

			[RequiredByFeature("GL_EXT_coordinate_frame")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTangent3dEXT(double tx, double ty, double tz);

			[ThreadStatic]
			internal static glTangent3dEXT pglTangent3dEXT;

			[RequiredByFeature("GL_EXT_coordinate_frame")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTangent3dvEXT(double* v);

			[ThreadStatic]
			internal static glTangent3dvEXT pglTangent3dvEXT;

			[RequiredByFeature("GL_EXT_coordinate_frame")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTangent3fEXT(float tx, float ty, float tz);

			[ThreadStatic]
			internal static glTangent3fEXT pglTangent3fEXT;

			[RequiredByFeature("GL_EXT_coordinate_frame")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTangent3fvEXT(float* v);

			[ThreadStatic]
			internal static glTangent3fvEXT pglTangent3fvEXT;

			[RequiredByFeature("GL_EXT_coordinate_frame")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTangent3iEXT(Int32 tx, Int32 ty, Int32 tz);

			[ThreadStatic]
			internal static glTangent3iEXT pglTangent3iEXT;

			[RequiredByFeature("GL_EXT_coordinate_frame")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTangent3ivEXT(Int32* v);

			[ThreadStatic]
			internal static glTangent3ivEXT pglTangent3ivEXT;

			[RequiredByFeature("GL_EXT_coordinate_frame")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTangent3sEXT(Int16 tx, Int16 ty, Int16 tz);

			[ThreadStatic]
			internal static glTangent3sEXT pglTangent3sEXT;

			[RequiredByFeature("GL_EXT_coordinate_frame")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTangent3svEXT(Int16* v);

			[ThreadStatic]
			internal static glTangent3svEXT pglTangent3svEXT;

			[RequiredByFeature("GL_EXT_coordinate_frame")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBinormal3bEXT(sbyte bx, sbyte by, sbyte bz);

			[ThreadStatic]
			internal static glBinormal3bEXT pglBinormal3bEXT;

			[RequiredByFeature("GL_EXT_coordinate_frame")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBinormal3bvEXT(sbyte* v);

			[ThreadStatic]
			internal static glBinormal3bvEXT pglBinormal3bvEXT;

			[RequiredByFeature("GL_EXT_coordinate_frame")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBinormal3dEXT(double bx, double by, double bz);

			[ThreadStatic]
			internal static glBinormal3dEXT pglBinormal3dEXT;

			[RequiredByFeature("GL_EXT_coordinate_frame")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBinormal3dvEXT(double* v);

			[ThreadStatic]
			internal static glBinormal3dvEXT pglBinormal3dvEXT;

			[RequiredByFeature("GL_EXT_coordinate_frame")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBinormal3fEXT(float bx, float by, float bz);

			[ThreadStatic]
			internal static glBinormal3fEXT pglBinormal3fEXT;

			[RequiredByFeature("GL_EXT_coordinate_frame")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBinormal3fvEXT(float* v);

			[ThreadStatic]
			internal static glBinormal3fvEXT pglBinormal3fvEXT;

			[RequiredByFeature("GL_EXT_coordinate_frame")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBinormal3iEXT(Int32 bx, Int32 by, Int32 bz);

			[ThreadStatic]
			internal static glBinormal3iEXT pglBinormal3iEXT;

			[RequiredByFeature("GL_EXT_coordinate_frame")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBinormal3ivEXT(Int32* v);

			[ThreadStatic]
			internal static glBinormal3ivEXT pglBinormal3ivEXT;

			[RequiredByFeature("GL_EXT_coordinate_frame")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBinormal3sEXT(Int16 bx, Int16 by, Int16 bz);

			[ThreadStatic]
			internal static glBinormal3sEXT pglBinormal3sEXT;

			[RequiredByFeature("GL_EXT_coordinate_frame")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBinormal3svEXT(Int16* v);

			[ThreadStatic]
			internal static glBinormal3svEXT pglBinormal3svEXT;

			[RequiredByFeature("GL_EXT_coordinate_frame")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTangentPointerEXT(Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glTangentPointerEXT pglTangentPointerEXT;

			[RequiredByFeature("GL_EXT_coordinate_frame")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBinormalPointerEXT(Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glBinormalPointerEXT pglBinormalPointerEXT;

		}
	}

}
