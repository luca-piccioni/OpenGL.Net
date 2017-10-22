







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

		public static Scalar CreateScalar(Context context, Type data_type, object obj)
		{
			GCHandle pin_obj = GCHandle.Alloc(obj, GCHandleType.Pinned);
			try {
				return (CreateScalar(context, data_type, pin_obj.AddrOfPinnedObject()));
			} finally {
				pin_obj.Free();
			}
		}

		public static Scalar CreateScalar(Context context, sbyte obj)
		{
			return (CreateScalar(context, OpenVX.Type.Int8, obj));
		}

		public static Scalar CreateScalar(Context context, byte obj)
		{
			return (CreateScalar(context, OpenVX.Type.Uint8, obj));
		}

		public static Scalar CreateScalar(Context context, short obj)
		{
			return (CreateScalar(context, OpenVX.Type.Int16, obj));
		}

		public static Scalar CreateScalar(Context context, ushort obj)
		{
			return (CreateScalar(context, OpenVX.Type.Uint16, obj));
		}

		public static Scalar CreateScalar(Context context, int obj)
		{
			return (CreateScalar(context, OpenVX.Type.Int32, obj));
		}

		public static Scalar CreateScalar(Context context, uint obj)
		{
			return (CreateScalar(context, OpenVX.Type.Uint32, obj));
		}

		public static Scalar CreateScalar(Context context, long obj)
		{
			return (CreateScalar(context, OpenVX.Type.Int64, obj));
		}

		public static Scalar CreateScalar(Context context, ulong obj)
		{
			return (CreateScalar(context, OpenVX.Type.Uint64, obj));
		}

		public static Scalar CreateScalar(Context context, float obj)
		{
			return (CreateScalar(context, OpenVX.Type.Float32, obj));
		}

		public static Scalar CreateScalar(Context context, double obj)
		{
			return (CreateScalar(context, OpenVX.Type.Float64, obj));
		}

		public static Scalar CreateScalar(Context context, DfImage obj)
		{
			return (CreateScalar(context, OpenVX.Type.DfImage, obj));
		}

		public static Scalar CreateScalar(Context context, bool obj)
		{
			return (CreateScalar(context, OpenVX.Type.Bool, obj));
		}

	
		#endregion

		#region Query(Array)

		public static Status Query(Array arr, ArrayAttribute attribute, out OpenVX.Type obj)
		{
			unsafe {
				fixed (OpenVX.Type *p_obj = &obj) {
					return (Query(arr, attribute, new IntPtr(p_obj), 4));
				}
			}
		}

		public static Status Query(Array arr, ArrayAttribute attribute, out uint obj)
		{
			unsafe {
				fixed (uint *p_obj = &obj) {
					return (Query(arr, attribute, new IntPtr(p_obj), 4));
				}
			}
		}

		#endregion

		#region Query(Graph)

		public static Status Query(Graph graph, GraphAttribute attribute, out uint obj)
		{
			unsafe {
				fixed (uint *p_obj = &obj) {
					return (Query(graph, attribute, new IntPtr(p_obj), 4));
				}
			}
		}

		public static Status Query(Graph graph, GraphAttribute attribute, out Status obj)
		{
			unsafe {
				fixed (Status *p_obj = &obj) {
					return (Query(graph, attribute, new IntPtr(p_obj), 4));
				}
			}
		}

		public static Status Query(Graph graph, GraphAttribute attribute, out Perf obj)
		{
			unsafe {
				fixed (Perf *p_obj = &obj) {
					return (Query(graph, attribute, new IntPtr(p_obj), 64));
				}
			}
		}

		#endregion
	}
}