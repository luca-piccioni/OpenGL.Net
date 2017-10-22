
// Copyright (C) 2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Runtime.InteropServices;

namespace OpenVX
{
	public partial class VX
	{
		#region CreateScalar

		public static Scalar CreateScalar(Context context, ref sbyte obj)
		{
			unsafe {
				fixed (sbyte* p_obj = &obj) {
					return (CreateScalar(context, Type.Int8, new IntPtr(p_obj)));
				}
			}
		}

		public static Scalar CreateScalar(Context context, ref byte obj)
		{
			unsafe {
				fixed (byte* p_obj = &obj) {
					return (CreateScalar(context, Type.Uint8, new IntPtr(p_obj)));
				}
			}
		}

		public static Scalar CreateScalar(Context context, ref short obj)
		{
			unsafe {
				fixed (short* p_obj = &obj) {
					return (CreateScalar(context, Type.Int16, new IntPtr(p_obj)));
				}
			}
		}

		public static Scalar CreateScalar(Context context, ref ushort obj)
		{
			unsafe {
				fixed (ushort* p_obj = &obj) {
					return (CreateScalar(context, Type.Uint16, new IntPtr(p_obj)));
				}
			}
		}

		public static Scalar CreateScalar(Context context, ref int obj)
		{
			unsafe {
				fixed (int* p_obj = &obj) {
					return (CreateScalar(context, Type.Int32, new IntPtr(p_obj)));
				}
			}
		}

		public static Scalar CreateScalar(Context context, ref uint obj)
		{
			unsafe {
				fixed (uint* p_obj = &obj) {
					return (CreateScalar(context, Type.Uint32, new IntPtr(p_obj)));
				}
			}
		}

		public static Scalar CreateScalar(Context context, ref long obj)
		{
			unsafe {
				fixed (long* p_obj = &obj) {
					return (CreateScalar(context, Type.Int64, new IntPtr(p_obj)));
				}
			}
		}

		public static Scalar CreateScalar(Context context, ref ulong obj)
		{
			unsafe {
				fixed (ulong* p_obj = &obj) {
					return (CreateScalar(context, Type.Uint64, new IntPtr(p_obj)));
				}
			}
		}

		public static Scalar CreateScalar(Context context, ref float obj)
		{
			unsafe {
				fixed (float* p_obj = &obj) {
					return (CreateScalar(context, Type.Float32, new IntPtr(p_obj)));
				}
			}
		}

		public static Scalar CreateScalar(Context context, ref double obj)
		{
			unsafe {
				fixed (double* p_obj = &obj) {
					return (CreateScalar(context, Type.Float64, new IntPtr(p_obj)));
				}
			}
		}

		public static Scalar CreateScalar(Context context, ref DfImage obj)
		{
			unsafe {
				fixed (DfImage* p_obj = &obj) {
					return (CreateScalar(context, Type.DfImage, new IntPtr(p_obj)));
				}
			}
		}

	
		#endregion

		#region Query(Array)

		public static Status Query(Array arr, ArrayAttribute attribute, out OpenVX.Type obj)
		{
			unsafe {
				fixed (OpenVX.Type *p_obj = &obj) {
					return (Query(arr, attribute, new IntPtr(p_obj), (UIntPtr)4));
				}
			}
		}

		public static Status Query(Array arr, ArrayAttribute attribute, out UIntPtr obj)
		{
			unsafe {
				fixed (UIntPtr *p_obj = &obj) {
					return (Query(arr, attribute, new IntPtr(p_obj), (UIntPtr)UIntPtr.Size));
				}
			}
		}

		#endregion

		#region Query(Delay)

		public static Status Query(Delay delay, DelayAttribute attribute, out OpenVX.Type obj)
		{
			unsafe {
				fixed (OpenVX.Type *p_obj = &obj) {
					return (Query(delay, attribute, new IntPtr(p_obj), (UIntPtr)4));
				}
			}
		}

		public static Status Query(Delay delay, DelayAttribute attribute, out UIntPtr obj)
		{
			unsafe {
				fixed (UIntPtr *p_obj = &obj) {
					return (Query(delay, attribute, new IntPtr(p_obj), (UIntPtr)UIntPtr.Size));
				}
			}
		}

		#endregion

		#region Query(Graph)

		public static Status Query(Graph graph, GraphAttribute attribute, out UIntPtr obj)
		{
			unsafe {
				fixed (UIntPtr *p_obj = &obj) {
					return (Query(graph, attribute, new IntPtr(p_obj), (UIntPtr)UIntPtr.Size));
				}
			}
		}

		public static Status Query(Graph graph, GraphAttribute attribute, out Status obj)
		{
			unsafe {
				fixed (Status *p_obj = &obj) {
					return (Query(graph, attribute, new IntPtr(p_obj), (UIntPtr)4));
				}
			}
		}

		public static Status Query(Graph graph, GraphAttribute attribute, out Perf obj)
		{
			unsafe {
				fixed (Perf *p_obj = &obj) {
					return (Query(graph, attribute, new IntPtr(p_obj), (UIntPtr)64));
				}
			}
		}

		#endregion

		#region Query(Scalar)

		public static Status Query(Scalar scalar, ScalarAttribute attribute, out OpenVX.Type obj)
		{
			unsafe {
				fixed (OpenVX.Type *p_obj = &obj) {
					return (Query(scalar, attribute, new IntPtr(p_obj), (UIntPtr)4));
				}
			}
		}

		#endregion

		#region Release(params Object[])

		public static void Release(params Array[] objs)
		{
			for (int i = 0; i < objs.Length; i++)
				Release(ref objs[i]);
		}

		public static void Release(params Context[] objs)
		{
			for (int i = 0; i < objs.Length; i++)
				Release(ref objs[i]);
		}

		public static void Release(params Convolution[] objs)
		{
			for (int i = 0; i < objs.Length; i++)
				Release(ref objs[i]);
		}

		public static void Release(params Delay[] objs)
		{
			for (int i = 0; i < objs.Length; i++)
				Release(ref objs[i]);
		}

		public static void Release(params Distribution[] objs)
		{
			for (int i = 0; i < objs.Length; i++)
				Release(ref objs[i]);
		}

		public static void Release(params Graph[] objs)
		{
			for (int i = 0; i < objs.Length; i++)
				Release(ref objs[i]);
		}

		public static void Release(params Kernel[] objs)
		{
			for (int i = 0; i < objs.Length; i++)
				Release(ref objs[i]);
		}

		public static void Release(params Image[] objs)
		{
			for (int i = 0; i < objs.Length; i++)
				Release(ref objs[i]);
		}

		public static void Release(params Import[] objs)
		{
			for (int i = 0; i < objs.Length; i++)
				Release(ref objs[i]);
		}

		public static void Release(params Lut[] objs)
		{
			for (int i = 0; i < objs.Length; i++)
				Release(ref objs[i]);
		}

		public static void Release(params Matrix[] objs)
		{
			for (int i = 0; i < objs.Length; i++)
				Release(ref objs[i]);
		}

		public static void Release(params Node[] objs)
		{
			for (int i = 0; i < objs.Length; i++)
				Release(ref objs[i]);
		}

		public static void Release(params ObjectArray[] objs)
		{
			for (int i = 0; i < objs.Length; i++)
				Release(ref objs[i]);
		}

		public static void Release(params Parameter[] objs)
		{
			for (int i = 0; i < objs.Length; i++)
				Release(ref objs[i]);
		}

		public static void Release(params Pyramid[] objs)
		{
			for (int i = 0; i < objs.Length; i++)
				Release(ref objs[i]);
		}

		public static void Release(params Remap[] objs)
		{
			for (int i = 0; i < objs.Length; i++)
				Release(ref objs[i]);
		}

		public static void Release(params Scalar[] objs)
		{
			for (int i = 0; i < objs.Length; i++)
				Release(ref objs[i]);
		}

		public static void Release(params Tensor[] objs)
		{
			for (int i = 0; i < objs.Length; i++)
				Release(ref objs[i]);
		}

		public static void Release(params Threshold[] objs)
		{
			for (int i = 0; i < objs.Length; i++)
				Release(ref objs[i]);
		}

		#endregion
	}
}