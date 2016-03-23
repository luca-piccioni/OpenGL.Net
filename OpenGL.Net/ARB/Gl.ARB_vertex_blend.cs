
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
		/// Value of GL_MAX_VERTEX_UNITS_ARB symbol.
		/// </summary>
		[AliasOf("GL_MAX_VERTEX_UNITS_OES")]
		[RequiredByFeature("GL_ARB_vertex_blend")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int MAX_VERTEX_UNITS_ARB = 0x86A4;

		/// <summary>
		/// Value of GL_ACTIVE_VERTEX_UNITS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int ACTIVE_VERTEX_UNITS_ARB = 0x86A5;

		/// <summary>
		/// Value of GL_WEIGHT_SUM_UNITY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int WEIGHT_SUM_UNITY_ARB = 0x86A6;

		/// <summary>
		/// Value of GL_VERTEX_BLEND_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int VERTEX_BLEND_ARB = 0x86A7;

		/// <summary>
		/// Value of GL_CURRENT_WEIGHT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int CURRENT_WEIGHT_ARB = 0x86A8;

		/// <summary>
		/// Value of GL_WEIGHT_ARRAY_TYPE_ARB symbol.
		/// </summary>
		[AliasOf("GL_WEIGHT_ARRAY_TYPE_OES")]
		[RequiredByFeature("GL_ARB_vertex_blend")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int WEIGHT_ARRAY_TYPE_ARB = 0x86A9;

		/// <summary>
		/// Value of GL_WEIGHT_ARRAY_STRIDE_ARB symbol.
		/// </summary>
		[AliasOf("GL_WEIGHT_ARRAY_STRIDE_OES")]
		[RequiredByFeature("GL_ARB_vertex_blend")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int WEIGHT_ARRAY_STRIDE_ARB = 0x86AA;

		/// <summary>
		/// Value of GL_WEIGHT_ARRAY_SIZE_ARB symbol.
		/// </summary>
		[AliasOf("GL_WEIGHT_ARRAY_SIZE_OES")]
		[RequiredByFeature("GL_ARB_vertex_blend")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int WEIGHT_ARRAY_SIZE_ARB = 0x86AB;

		/// <summary>
		/// Value of GL_WEIGHT_ARRAY_POINTER_ARB symbol.
		/// </summary>
		[AliasOf("GL_WEIGHT_ARRAY_POINTER_OES")]
		[RequiredByFeature("GL_ARB_vertex_blend")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int WEIGHT_ARRAY_POINTER_ARB = 0x86AC;

		/// <summary>
		/// Value of GL_WEIGHT_ARRAY_ARB symbol.
		/// </summary>
		[AliasOf("GL_WEIGHT_ARRAY_OES")]
		[RequiredByFeature("GL_ARB_vertex_blend")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int WEIGHT_ARRAY_ARB = 0x86AD;

		/// <summary>
		/// Value of GL_MODELVIEW0_ARB symbol.
		/// </summary>
		[AliasOf("GL_MODELVIEW0_EXT")]
		[RequiredByFeature("GL_ARB_vertex_blend")]
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int MODELVIEW0_ARB = 0x1700;

		/// <summary>
		/// Value of GL_MODELVIEW1_ARB symbol.
		/// </summary>
		[AliasOf("GL_MODELVIEW1_EXT")]
		[RequiredByFeature("GL_ARB_vertex_blend")]
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int MODELVIEW1_ARB = 0x850A;

		/// <summary>
		/// Value of GL_MODELVIEW2_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW2_ARB = 0x8722;

		/// <summary>
		/// Value of GL_MODELVIEW3_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW3_ARB = 0x8723;

		/// <summary>
		/// Value of GL_MODELVIEW4_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW4_ARB = 0x8724;

		/// <summary>
		/// Value of GL_MODELVIEW5_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW5_ARB = 0x8725;

		/// <summary>
		/// Value of GL_MODELVIEW6_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW6_ARB = 0x8726;

		/// <summary>
		/// Value of GL_MODELVIEW7_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW7_ARB = 0x8727;

		/// <summary>
		/// Value of GL_MODELVIEW8_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW8_ARB = 0x8728;

		/// <summary>
		/// Value of GL_MODELVIEW9_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW9_ARB = 0x8729;

		/// <summary>
		/// Value of GL_MODELVIEW10_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW10_ARB = 0x872A;

		/// <summary>
		/// Value of GL_MODELVIEW11_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW11_ARB = 0x872B;

		/// <summary>
		/// Value of GL_MODELVIEW12_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW12_ARB = 0x872C;

		/// <summary>
		/// Value of GL_MODELVIEW13_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW13_ARB = 0x872D;

		/// <summary>
		/// Value of GL_MODELVIEW14_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW14_ARB = 0x872E;

		/// <summary>
		/// Value of GL_MODELVIEW15_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW15_ARB = 0x872F;

		/// <summary>
		/// Value of GL_MODELVIEW16_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW16_ARB = 0x8730;

		/// <summary>
		/// Value of GL_MODELVIEW17_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW17_ARB = 0x8731;

		/// <summary>
		/// Value of GL_MODELVIEW18_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW18_ARB = 0x8732;

		/// <summary>
		/// Value of GL_MODELVIEW19_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW19_ARB = 0x8733;

		/// <summary>
		/// Value of GL_MODELVIEW20_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW20_ARB = 0x8734;

		/// <summary>
		/// Value of GL_MODELVIEW21_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW21_ARB = 0x8735;

		/// <summary>
		/// Value of GL_MODELVIEW22_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW22_ARB = 0x8736;

		/// <summary>
		/// Value of GL_MODELVIEW23_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW23_ARB = 0x8737;

		/// <summary>
		/// Value of GL_MODELVIEW24_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW24_ARB = 0x8738;

		/// <summary>
		/// Value of GL_MODELVIEW25_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW25_ARB = 0x8739;

		/// <summary>
		/// Value of GL_MODELVIEW26_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW26_ARB = 0x873A;

		/// <summary>
		/// Value of GL_MODELVIEW27_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW27_ARB = 0x873B;

		/// <summary>
		/// Value of GL_MODELVIEW28_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW28_ARB = 0x873C;

		/// <summary>
		/// Value of GL_MODELVIEW29_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW29_ARB = 0x873D;

		/// <summary>
		/// Value of GL_MODELVIEW30_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW30_ARB = 0x873E;

		/// <summary>
		/// Value of GL_MODELVIEW31_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public const int MODELVIEW31_ARB = 0x873F;

		/// <summary>
		/// Binding for glWeightbvARB.
		/// </summary>
		/// <param name="weights">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public static void WeightARB(sbyte[] weights)
		{
			unsafe {
				fixed (sbyte* p_weights = weights)
				{
					Debug.Assert(Delegates.pglWeightbvARB != null, "pglWeightbvARB not implemented");
					Delegates.pglWeightbvARB((Int32)weights.Length, p_weights);
					LogFunction("glWeightbvARB({0}, {1})", weights.Length, LogValue(weights));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWeightsvARB.
		/// </summary>
		/// <param name="weights">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public static void WeightARB(Int16[] weights)
		{
			unsafe {
				fixed (Int16* p_weights = weights)
				{
					Debug.Assert(Delegates.pglWeightsvARB != null, "pglWeightsvARB not implemented");
					Delegates.pglWeightsvARB((Int32)weights.Length, p_weights);
					LogFunction("glWeightsvARB({0}, {1})", weights.Length, LogValue(weights));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWeightivARB.
		/// </summary>
		/// <param name="weights">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public static void WeightARB(Int32[] weights)
		{
			unsafe {
				fixed (Int32* p_weights = weights)
				{
					Debug.Assert(Delegates.pglWeightivARB != null, "pglWeightivARB not implemented");
					Delegates.pglWeightivARB((Int32)weights.Length, p_weights);
					LogFunction("glWeightivARB({0}, {1})", weights.Length, LogValue(weights));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWeightfvARB.
		/// </summary>
		/// <param name="weights">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public static void WeightARB(float[] weights)
		{
			unsafe {
				fixed (float* p_weights = weights)
				{
					Debug.Assert(Delegates.pglWeightfvARB != null, "pglWeightfvARB not implemented");
					Delegates.pglWeightfvARB((Int32)weights.Length, p_weights);
					LogFunction("glWeightfvARB({0}, {1})", weights.Length, LogValue(weights));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWeightdvARB.
		/// </summary>
		/// <param name="weights">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public static void WeightARB(double[] weights)
		{
			unsafe {
				fixed (double* p_weights = weights)
				{
					Debug.Assert(Delegates.pglWeightdvARB != null, "pglWeightdvARB not implemented");
					Delegates.pglWeightdvARB((Int32)weights.Length, p_weights);
					LogFunction("glWeightdvARB({0}, {1})", weights.Length, LogValue(weights));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWeightubvARB.
		/// </summary>
		/// <param name="weights">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public static void WeightARB(byte[] weights)
		{
			unsafe {
				fixed (byte* p_weights = weights)
				{
					Debug.Assert(Delegates.pglWeightubvARB != null, "pglWeightubvARB not implemented");
					Delegates.pglWeightubvARB((Int32)weights.Length, p_weights);
					LogFunction("glWeightubvARB({0}, {1})", weights.Length, LogValue(weights));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWeightusvARB.
		/// </summary>
		/// <param name="weights">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public static void WeightARB(UInt16[] weights)
		{
			unsafe {
				fixed (UInt16* p_weights = weights)
				{
					Debug.Assert(Delegates.pglWeightusvARB != null, "pglWeightusvARB not implemented");
					Delegates.pglWeightusvARB((Int32)weights.Length, p_weights);
					LogFunction("glWeightusvARB({0}, {1})", weights.Length, LogValue(weights));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWeightuivARB.
		/// </summary>
		/// <param name="weights">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public static void WeightARB(UInt32[] weights)
		{
			unsafe {
				fixed (UInt32* p_weights = weights)
				{
					Debug.Assert(Delegates.pglWeightuivARB != null, "pglWeightuivARB not implemented");
					Delegates.pglWeightuivARB((Int32)weights.Length, p_weights);
					LogFunction("glWeightuivARB({0}, {1})", weights.Length, LogValue(weights));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWeightPointerARB.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public static void WeightPointerARB(Int32 size, Int32 type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglWeightPointerARB != null, "pglWeightPointerARB not implemented");
			Delegates.pglWeightPointerARB(size, type, stride, pointer);
			LogFunction("glWeightPointerARB({0}, {1}, {2}, 0x{3})", size, LogEnumName(type), stride, pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWeightPointerARB.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public static void WeightPointerARB(Int32 size, Int32 type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				WeightPointerARB(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glVertexBlendARB.
		/// </summary>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_blend")]
		public static void VertexBlendARB(Int32 count)
		{
			Debug.Assert(Delegates.pglVertexBlendARB != null, "pglVertexBlendARB not implemented");
			Delegates.pglVertexBlendARB(count);
			LogFunction("glVertexBlendARB({0})", count);
			DebugCheckErrors(null);
		}

	}

}
