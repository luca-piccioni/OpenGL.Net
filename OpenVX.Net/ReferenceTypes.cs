







// Copyright (C) 2009-2017 Luca Piccioni
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

#pragma warning disable 649

using System;

namespace OpenVX
{

	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Array
	{
		/// <summary>
		/// Reference handle.
		/// </summary>
		private IntPtr _Reference;

		/// <summary>
		/// Implicit cast to <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Array"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Reference(Array obj) { return (new Reference(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Context
	{
		/// <summary>
		/// Reference handle.
		/// </summary>
		private IntPtr _Reference;

		/// <summary>
		/// Implicit cast to <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Context"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Reference(Context obj) { return (new Reference(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Convolution
	{
		/// <summary>
		/// Reference handle.
		/// </summary>
		private IntPtr _Reference;

		/// <summary>
		/// Implicit cast to <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Convolution"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Reference(Convolution obj) { return (new Reference(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Delay
	{
		/// <summary>
		/// Reference handle.
		/// </summary>
		private IntPtr _Reference;

		/// <summary>
		/// Implicit cast to <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Delay"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Reference(Delay obj) { return (new Reference(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Distribution
	{
		/// <summary>
		/// Reference handle.
		/// </summary>
		private IntPtr _Reference;

		/// <summary>
		/// Implicit cast to <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Distribution"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Reference(Distribution obj) { return (new Reference(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Graph
	{
		/// <summary>
		/// Reference handle.
		/// </summary>
		private IntPtr _Reference;

		/// <summary>
		/// Implicit cast to <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Graph"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Reference(Graph obj) { return (new Reference(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Kernel
	{
		/// <summary>
		/// Reference handle.
		/// </summary>
		private IntPtr _Reference;

		/// <summary>
		/// Implicit cast to <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Kernel"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Reference(Kernel obj) { return (new Reference(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Image
	{
		/// <summary>
		/// Reference handle.
		/// </summary>
		private IntPtr _Reference;

		/// <summary>
		/// Implicit cast to <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Image"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Reference(Image obj) { return (new Reference(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Import
	{
		/// <summary>
		/// Reference handle.
		/// </summary>
		private IntPtr _Reference;

		/// <summary>
		/// Implicit cast to <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Import"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Reference(Import obj) { return (new Reference(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Lut
	{
		/// <summary>
		/// Reference handle.
		/// </summary>
		private IntPtr _Reference;

		/// <summary>
		/// Implicit cast to <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Lut"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Reference(Lut obj) { return (new Reference(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct MapId
	{
		/// <summary>
		/// Reference handle.
		/// </summary>
		private IntPtr _Reference;

		/// <summary>
		/// Implicit cast to <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="MapId"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Reference(MapId obj) { return (new Reference(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Matrix
	{
		/// <summary>
		/// Reference handle.
		/// </summary>
		private IntPtr _Reference;

		/// <summary>
		/// Implicit cast to <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Matrix"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Reference(Matrix obj) { return (new Reference(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct MetaFormat
	{
		/// <summary>
		/// Reference handle.
		/// </summary>
		private IntPtr _Reference;

		/// <summary>
		/// Implicit cast to <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="MetaFormat"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Reference(MetaFormat obj) { return (new Reference(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Node
	{
		/// <summary>
		/// Reference handle.
		/// </summary>
		private IntPtr _Reference;

		/// <summary>
		/// Implicit cast to <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Node"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Reference(Node obj) { return (new Reference(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct ObjectArray
	{
		/// <summary>
		/// Reference handle.
		/// </summary>
		private IntPtr _Reference;

		/// <summary>
		/// Implicit cast to <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="ObjectArray"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Reference(ObjectArray obj) { return (new Reference(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Parameter
	{
		/// <summary>
		/// Reference handle.
		/// </summary>
		private IntPtr _Reference;

		/// <summary>
		/// Implicit cast to <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Parameter"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Reference(Parameter obj) { return (new Reference(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Pyramid
	{
		/// <summary>
		/// Reference handle.
		/// </summary>
		private IntPtr _Reference;

		/// <summary>
		/// Implicit cast to <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Pyramid"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Reference(Pyramid obj) { return (new Reference(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Remap
	{
		/// <summary>
		/// Reference handle.
		/// </summary>
		private IntPtr _Reference;

		/// <summary>
		/// Implicit cast to <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Remap"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Reference(Remap obj) { return (new Reference(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Scalar
	{
		/// <summary>
		/// Reference handle.
		/// </summary>
		private IntPtr _Reference;

		/// <summary>
		/// Implicit cast to <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Scalar"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Reference(Scalar obj) { return (new Reference(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Tensor
	{
		/// <summary>
		/// Reference handle.
		/// </summary>
		private IntPtr _Reference;

		/// <summary>
		/// Implicit cast to <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Tensor"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Reference(Tensor obj) { return (new Reference(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Threshold
	{
		/// <summary>
		/// Reference handle.
		/// </summary>
		private IntPtr _Reference;

		/// <summary>
		/// Implicit cast to <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Threshold"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Reference(Threshold obj) { return (new Reference(obj._Reference)); }
	}


}