







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
		/// Construct a Array from a raw handle.
		/// </summary>
		/// <param name="context">
		/// The <see cref="IntPtr"/> to be converted to Array.
		/// </param>
		internal Array(IntPtr reference)
		{
			_Reference = reference;
		}

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

		/// <summary>
		/// Implicit cast to <see cref="Array"/> from <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Array"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Array(Reference obj) { return (new Array(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Context
	{
		/// <summary>
		/// Construct a Context from a raw handle.
		/// </summary>
		/// <param name="context">
		/// The <see cref="IntPtr"/> to be converted to Context.
		/// </param>
		internal Context(IntPtr reference)
		{
			_Reference = reference;
		}

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

		/// <summary>
		/// Implicit cast to <see cref="Context"/> from <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Context"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Context(Reference obj) { return (new Context(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Convolution
	{
		/// <summary>
		/// Construct a Convolution from a raw handle.
		/// </summary>
		/// <param name="context">
		/// The <see cref="IntPtr"/> to be converted to Convolution.
		/// </param>
		internal Convolution(IntPtr reference)
		{
			_Reference = reference;
		}

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

		/// <summary>
		/// Implicit cast to <see cref="Convolution"/> from <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Convolution"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Convolution(Reference obj) { return (new Convolution(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Delay
	{
		/// <summary>
		/// Construct a Delay from a raw handle.
		/// </summary>
		/// <param name="context">
		/// The <see cref="IntPtr"/> to be converted to Delay.
		/// </param>
		internal Delay(IntPtr reference)
		{
			_Reference = reference;
		}

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

		/// <summary>
		/// Implicit cast to <see cref="Delay"/> from <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Delay"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Delay(Reference obj) { return (new Delay(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Distribution
	{
		/// <summary>
		/// Construct a Distribution from a raw handle.
		/// </summary>
		/// <param name="context">
		/// The <see cref="IntPtr"/> to be converted to Distribution.
		/// </param>
		internal Distribution(IntPtr reference)
		{
			_Reference = reference;
		}

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

		/// <summary>
		/// Implicit cast to <see cref="Distribution"/> from <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Distribution"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Distribution(Reference obj) { return (new Distribution(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Graph
	{
		/// <summary>
		/// Construct a Graph from a raw handle.
		/// </summary>
		/// <param name="context">
		/// The <see cref="IntPtr"/> to be converted to Graph.
		/// </param>
		internal Graph(IntPtr reference)
		{
			_Reference = reference;
		}

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

		/// <summary>
		/// Implicit cast to <see cref="Graph"/> from <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Graph"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Graph(Reference obj) { return (new Graph(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Kernel
	{
		/// <summary>
		/// Construct a Kernel from a raw handle.
		/// </summary>
		/// <param name="context">
		/// The <see cref="IntPtr"/> to be converted to Kernel.
		/// </param>
		internal Kernel(IntPtr reference)
		{
			_Reference = reference;
		}

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

		/// <summary>
		/// Implicit cast to <see cref="Kernel"/> from <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Kernel"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Kernel(Reference obj) { return (new Kernel(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Image
	{
		/// <summary>
		/// Construct a Image from a raw handle.
		/// </summary>
		/// <param name="context">
		/// The <see cref="IntPtr"/> to be converted to Image.
		/// </param>
		internal Image(IntPtr reference)
		{
			_Reference = reference;
		}

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

		/// <summary>
		/// Implicit cast to <see cref="Image"/> from <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Image"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Image(Reference obj) { return (new Image(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Import
	{
		/// <summary>
		/// Construct a Import from a raw handle.
		/// </summary>
		/// <param name="context">
		/// The <see cref="IntPtr"/> to be converted to Import.
		/// </param>
		internal Import(IntPtr reference)
		{
			_Reference = reference;
		}

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

		/// <summary>
		/// Implicit cast to <see cref="Import"/> from <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Import"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Import(Reference obj) { return (new Import(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Lut
	{
		/// <summary>
		/// Construct a Lut from a raw handle.
		/// </summary>
		/// <param name="context">
		/// The <see cref="IntPtr"/> to be converted to Lut.
		/// </param>
		internal Lut(IntPtr reference)
		{
			_Reference = reference;
		}

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

		/// <summary>
		/// Implicit cast to <see cref="Lut"/> from <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Lut"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Lut(Reference obj) { return (new Lut(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct MapId
	{
		/// <summary>
		/// Construct a MapId from a raw handle.
		/// </summary>
		/// <param name="context">
		/// The <see cref="IntPtr"/> to be converted to MapId.
		/// </param>
		internal MapId(IntPtr reference)
		{
			_Reference = reference;
		}

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

		/// <summary>
		/// Implicit cast to <see cref="MapId"/> from <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="MapId"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator MapId(Reference obj) { return (new MapId(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Matrix
	{
		/// <summary>
		/// Construct a Matrix from a raw handle.
		/// </summary>
		/// <param name="context">
		/// The <see cref="IntPtr"/> to be converted to Matrix.
		/// </param>
		internal Matrix(IntPtr reference)
		{
			_Reference = reference;
		}

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

		/// <summary>
		/// Implicit cast to <see cref="Matrix"/> from <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Matrix"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Matrix(Reference obj) { return (new Matrix(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct MetaFormat
	{
		/// <summary>
		/// Construct a MetaFormat from a raw handle.
		/// </summary>
		/// <param name="context">
		/// The <see cref="IntPtr"/> to be converted to MetaFormat.
		/// </param>
		internal MetaFormat(IntPtr reference)
		{
			_Reference = reference;
		}

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

		/// <summary>
		/// Implicit cast to <see cref="MetaFormat"/> from <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="MetaFormat"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator MetaFormat(Reference obj) { return (new MetaFormat(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Node
	{
		/// <summary>
		/// Construct a Node from a raw handle.
		/// </summary>
		/// <param name="context">
		/// The <see cref="IntPtr"/> to be converted to Node.
		/// </param>
		internal Node(IntPtr reference)
		{
			_Reference = reference;
		}

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

		/// <summary>
		/// Implicit cast to <see cref="Node"/> from <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Node"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Node(Reference obj) { return (new Node(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct ObjectArray
	{
		/// <summary>
		/// Construct a ObjectArray from a raw handle.
		/// </summary>
		/// <param name="context">
		/// The <see cref="IntPtr"/> to be converted to ObjectArray.
		/// </param>
		internal ObjectArray(IntPtr reference)
		{
			_Reference = reference;
		}

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

		/// <summary>
		/// Implicit cast to <see cref="ObjectArray"/> from <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="ObjectArray"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator ObjectArray(Reference obj) { return (new ObjectArray(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Parameter
	{
		/// <summary>
		/// Construct a Parameter from a raw handle.
		/// </summary>
		/// <param name="context">
		/// The <see cref="IntPtr"/> to be converted to Parameter.
		/// </param>
		internal Parameter(IntPtr reference)
		{
			_Reference = reference;
		}

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

		/// <summary>
		/// Implicit cast to <see cref="Parameter"/> from <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Parameter"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Parameter(Reference obj) { return (new Parameter(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Pyramid
	{
		/// <summary>
		/// Construct a Pyramid from a raw handle.
		/// </summary>
		/// <param name="context">
		/// The <see cref="IntPtr"/> to be converted to Pyramid.
		/// </param>
		internal Pyramid(IntPtr reference)
		{
			_Reference = reference;
		}

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

		/// <summary>
		/// Implicit cast to <see cref="Pyramid"/> from <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Pyramid"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Pyramid(Reference obj) { return (new Pyramid(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Remap
	{
		/// <summary>
		/// Construct a Remap from a raw handle.
		/// </summary>
		/// <param name="context">
		/// The <see cref="IntPtr"/> to be converted to Remap.
		/// </param>
		internal Remap(IntPtr reference)
		{
			_Reference = reference;
		}

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

		/// <summary>
		/// Implicit cast to <see cref="Remap"/> from <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Remap"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Remap(Reference obj) { return (new Remap(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Scalar
	{
		/// <summary>
		/// Construct a Scalar from a raw handle.
		/// </summary>
		/// <param name="context">
		/// The <see cref="IntPtr"/> to be converted to Scalar.
		/// </param>
		internal Scalar(IntPtr reference)
		{
			_Reference = reference;
		}

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

		/// <summary>
		/// Implicit cast to <see cref="Scalar"/> from <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Scalar"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Scalar(Reference obj) { return (new Scalar(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Tensor
	{
		/// <summary>
		/// Construct a Tensor from a raw handle.
		/// </summary>
		/// <param name="context">
		/// The <see cref="IntPtr"/> to be converted to Tensor.
		/// </param>
		internal Tensor(IntPtr reference)
		{
			_Reference = reference;
		}

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

		/// <summary>
		/// Implicit cast to <see cref="Tensor"/> from <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Tensor"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Tensor(Reference obj) { return (new Tensor(obj._Reference)); }
	}


	/// <summary>
	/// OpenVX object.
	/// </summary>
	public struct Threshold
	{
		/// <summary>
		/// Construct a Threshold from a raw handle.
		/// </summary>
		/// <param name="context">
		/// The <see cref="IntPtr"/> to be converted to Threshold.
		/// </param>
		internal Threshold(IntPtr reference)
		{
			_Reference = reference;
		}

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

		/// <summary>
		/// Implicit cast to <see cref="Threshold"/> from <see cref="Reference"/>.
		/// </summary>
		/// <param name="context">
		/// The <see cref="Threshold"/> to be converted to <see cref="Reference"/>.
		/// </param>
		public static implicit operator Threshold(Reference obj) { return (new Threshold(obj._Reference)); }
	}


}