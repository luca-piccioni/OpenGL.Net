
// Copyright (C) 2009-2015 Luca Piccioni
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

namespace OpenGL
{
	/// <summary>
	/// Homogeneous tridimensional vertex value type (unsigned byte coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Byte, 4)]
	[DebuggerDisplay("Vertex4b: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4b : IVertex4
	{
		#region Structure

		/// <summary>
		/// X coordinate for fourdimensional vertex.
		/// </summary>
		public sbyte x;
		/// <summary>
		/// Y coordinate for fourdimensional vertex.
		/// </summary>
		public sbyte y;
		/// <summary>
		/// Z coordinate for fourdimensional vertex.
		/// </summary>
		public sbyte z;
		/// <summary>
		/// W coordinate for fourdimensional vertex.
		/// </summary>
		public sbyte w;

		#endregion

		#region IVertex4 Implementation

		/// <summary>
		/// Vertex coordinate X.
		/// </summary>
		public float X
		{
			get { return (x); }
			set { x = checked((sbyte)value); }
		}

		/// <summary>
		/// Vertex coordinate Y.
		/// </summary>
		public float Y
		{
			get { return (y); }
			set { y = checked((sbyte)value); }
		}

		/// <summary>
		/// Vertex coordinate Z.
		/// </summary>
		public float Z
		{
			get { return (z); }
			set { z = checked((sbyte)value); }
		}

		/// <summary>
		/// Vertex coordinate w.
		/// </summary>
		public float W
		{
			get { return (w); }
			set { w = checked((sbyte)value); }
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="idx"/> is negative or exceed the maximum allowed component index.
		/// </exception>
		/// <exception cref="OverflowException">
		/// Exception thrown if the set value is outside the representable range of signed byte.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0:
						return (X);
					case 1:
						return (Y);
					case 2:
						return (Z);
					case 3:
						return (W);
					default:
						throw new ArgumentException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0:
						X = value;
						break;
					case 1:
						Y = value;
						break;
					case 2:
						Z = value;
						break;
					case 3:
						W = value;
						break;
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// Homogeneous tridimensional vertex value type (unsigned byte coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UByte, 4)]
	[DebuggerDisplay("Vertex4ub: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4ub : IVertex4
	{
		#region Structure

		/// <summary>
		/// X coordinate for fourdimensional vertex.
		/// </summary>
		public byte x;
		/// <summary>
		/// Y coordinate for fourdimensional vertex.
		/// </summary>
		public byte y;
		/// <summary>
		/// Z coordinate for fourdimensional vertex.
		/// </summary>
		public byte z;
		/// <summary>
		/// W coordinate for fourdimensional vertex.
		/// </summary>
		public byte w;

		#endregion

		#region IVertex4 Implementation

		/// <summary>
		/// Vertex coordinate X.
		/// </summary>
		public float X
		{
			get { return (x); }
			set { x = checked((byte)value); }
		}

		/// <summary>
		/// Vertex coordinate Y.
		/// </summary>
		public float Y
		{
			get { return (y); }
			set { y = checked((byte)value); }
		}

		/// <summary>
		/// Vertex coordinate Z.
		/// </summary>
		public float Z
		{
			get { return (z); }
			set { z = checked((byte)value); }
		}

		/// <summary>
		/// Vertex coordinate w.
		/// </summary>
		public float W
		{
			get { return (w); }
			set { w = checked((byte)value); }
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="idx"/> is negative or exceed the maximum allowed component index.
		/// </exception>
		/// <exception cref="OverflowException">
		/// Exception thrown if the set value is outside the representable range of signed byte.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0:
						return (X);
					case 1:
						return (Y);
					case 2:
						return (Z);
					case 3:
						return (W);
					default:
						throw new ArgumentException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0:
						X = value;
						break;
					case 1:
						Y = value;
						break;
					case 2:
						Z = value;
						break;
					case 3:
						W = value;
						break;
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// Homogeneous tridimensional vertex value type (short coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Short, 4)]
	[DebuggerDisplay("Vertex4s: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4s : IVertex4
	{
		#region Structure

		/// <summary>
		/// X coordinate for fourdimensional vertex.
		/// </summary>
		public short x;

		/// <summary>
		/// Y coordinate for fourdimensional vertex.
		/// </summary>
		public short y;

		/// <summary>
		/// Z coordinate for fourdimensional vertex.
		/// </summary>
		public short z;

		/// <summary>
		/// W coordinate for fourdimensional vertex.
		/// </summary>
		public short w;

		#endregion

		#region IVertex4 Implementation

		/// <summary>
		/// Vertex coordinate X.
		/// </summary>
		public float X
		{
			get { return (x); }
			set { x = checked((short)value); }
		}

		/// <summary>
		/// Vertex coordinate Y.
		/// </summary>
		public float Y
		{
			get { return (y); }
			set { y = checked((short)value); }
		}

		/// <summary>
		/// Vertex coordinate Z.
		/// </summary>
		public float Z
		{
			get { return (z); }
			set { z = checked((short)value); }
		}

		/// <summary>
		/// Vertex coordinate w.
		/// </summary>
		public float W
		{
			get { return (w); }
			set { w = checked((short)value); }
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="idx"/> is negative or exceed the maximum allowed component index.
		/// </exception>
		/// <exception cref="OverflowException">
		/// Exception thrown if the set value is outside the representable range of signed byte.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0:
						return (X);
					case 1:
						return (Y);
					case 2:
						return (Z);
					case 3:
						return (W);
					default:
						throw new ArgumentException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0:
						X = value;
						break;
					case 1:
						Y = value;
						break;
					case 2:
						Z = value;
						break;
					case 3:
						W = value;
						break;
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// Homogeneous tridimensional vertex value type (short coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UShort, 4)]
	[DebuggerDisplay("Vertex4us: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4us : IVertex4
	{
		#region Structure

		/// <summary>
		/// X coordinate for fourdimensional vertex.
		/// </summary>
		public ushort x;

		/// <summary>
		/// Y coordinate for fourdimensional vertex.
		/// </summary>
		public ushort y;

		/// <summary>
		/// Z coordinate for fourdimensional vertex.
		/// </summary>
		public ushort z;

		/// <summary>
		/// W coordinate for fourdimensional vertex.
		/// </summary>
		public ushort w;

		#endregion

		#region IVertex4 Implementation

		/// <summary>
		/// Vertex coordinate X.
		/// </summary>
		public float X
		{
			get { return (x); }
			set { x = checked((ushort)value); }
		}

		/// <summary>
		/// Vertex coordinate Y.
		/// </summary>
		public float Y
		{
			get { return (y); }
			set { y = checked((ushort)value); }
		}

		/// <summary>
		/// Vertex coordinate Z.
		/// </summary>
		public float Z
		{
			get { return (z); }
			set { z = checked((ushort)value); }
		}

		/// <summary>
		/// Vertex coordinate w.
		/// </summary>
		public float W
		{
			get { return (w); }
			set { w = checked((ushort)value); }
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="idx"/> is negative or exceed the maximum allowed component index.
		/// </exception>
		/// <exception cref="OverflowException">
		/// Exception thrown if the set value is outside the representable range of signed byte.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0:
						return (X);
					case 1:
						return (Y);
					case 2:
						return (Z);
					case 3:
						return (W);
					default:
						throw new ArgumentException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0:
						X = value;
						break;
					case 1:
						Y = value;
						break;
					case 2:
						Z = value;
						break;
					case 3:
						W = value;
						break;
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// Homogeneous tridimensional vertex value type (integer coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Int, 4)]
	[DebuggerDisplay("Vertex4i: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4i : IVertex4, IColorInteger4<int>
	{
		#region Structure

		/// <summary>
		/// X coordinate for fourdimensional vertex.
		/// </summary>
		public int x;

		/// <summary>
		/// Y coordinate for fourdimensional vertex.
		/// </summary>
		public int y;

		/// <summary>
		/// Z coordinate for fourdimensional vertex.
		/// </summary>
		public int z;

		/// <summary>
		/// W coordinate for fourdimensional vertex.
		/// </summary>
		public int w;

		#endregion

		#region IVertex4 Implementation

		/// <summary>
		/// Vertex coordinate X.
		/// </summary>
		public float X
		{
			get { return (x); }
			set { x = checked((int)value); }
		}

		/// <summary>
		/// Vertex coordinate Y.
		/// </summary>
		public float Y
		{
			get { return (y); }
			set { y = checked((int)value); }
		}

		/// <summary>
		/// Vertex coordinate Z.
		/// </summary>
		public float Z
		{
			get { return (z); }
			set { z = checked((int)value); }
		}

		/// <summary>
		/// Vertex coordinate w.
		/// </summary>
		public float W
		{
			get { return (w); }
			set { w = checked((int)value); }
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="idx"/> is negative or exceed the maximum allowed component index.
		/// </exception>
		/// <exception cref="OverflowException">
		/// Exception thrown if the set value is outside the representable range of signed byte.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0:
						return (X);
					case 1:
						return (Y);
					case 2:
						return (Z);
					case 3:
						return (W);
					default:
						throw new ArgumentException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0:
						X = value;
						break;
					case 1:
						Y = value;
						break;
					case 2:
						Z = value;
						break;
					case 3:
						W = value;
						break;
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion

		#region IColorInteger4<int> Implementation

		/// <summary>
		/// PixelLayout of this IFragment.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.Integer4); } }

		/// <summary>
		/// Get the first integer component.
		/// </summary>
		int IColorInteger4<int>.X { get { return (x); } }

		/// <summary>
		/// Get the second integer component.
		/// </summary>
		int IColorInteger4<int>.Y { get { return (y); } }

		/// <summary>
		/// Get the third integer component.
		/// </summary>
		int IColorInteger4<int>.Z { get { return (z); } }

		/// <summary>
		/// Get the fourth integer component.
		/// </summary>
		int IColorInteger4<int>.W { get { return (w); } }

		#endregion
	}

	/// <summary>
	/// Homogeneous tridimensional vertex value type (integer coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UInt, 4)]
	[DebuggerDisplay("Vertex4ui: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4ui : IVertex4, IColorInteger4<uint>
	{
		#region Structure

		/// <summary>
		/// X coordinate for fourdimensional vertex.
		/// </summary>
		public uint x;

		/// <summary>
		/// Y coordinate for fourdimensional vertex.
		/// </summary>
		public uint y;

		/// <summary>
		/// Z coordinate for fourdimensional vertex.
		/// </summary>
		public uint z;

		/// <summary>
		/// W coordinate for fourdimensional vertex.
		/// </summary>
		public uint w;

		#endregion

		#region IVertex4 Implementation

		/// <summary>
		/// Vertex coordinate X.
		/// </summary>
		public float X
		{
			get { return (x); }
			set { x = checked((uint)value); }
		}

		/// <summary>
		/// Vertex coordinate Y.
		/// </summary>
		public float Y
		{
			get { return (y); }
			set { y = checked((uint)value); }
		}

		/// <summary>
		/// Vertex coordinate Z.
		/// </summary>
		public float Z
		{
			get { return (z); }
			set { z = checked((uint)value); }
		}

		/// <summary>
		/// Vertex coordinate w.
		/// </summary>
		public float W
		{
			get { return (w); }
			set { w = checked((uint)value); }
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="idx"/> is negative or exceed the maximum allowed component index.
		/// </exception>
		/// <exception cref="OverflowException">
		/// Exception thrown if the set value is outside the representable range of signed byte.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0:
						return (X);
					case 1:
						return (Y);
					case 2:
						return (Z);
					case 3:
						return (W);
					default:
						throw new ArgumentException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0:
						X = value;
						break;
					case 1:
						Y = value;
						break;
					case 2:
						Z = value;
						break;
					case 3:
						W = value;
						break;
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion

		#region IColorInteger4<int> Implementation

		/// <summary>
		/// PixelLayout of this IFragment.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.UInteger4); } }

		/// <summary>
		/// Get the first integer component.
		/// </summary>
		uint IColorInteger4<uint>.X { get { return (x); } }

		/// <summary>
		/// Get the second integer component.
		/// </summary>
		uint IColorInteger4<uint>.Y { get { return (y); } }

		/// <summary>
		/// Get the third integer component.
		/// </summary>
		uint IColorInteger4<uint>.Z { get { return (z); } }

		/// <summary>
		/// Get the fourth integer component.
		/// </summary>
		uint IColorInteger4<uint>.W { get { return (w); } }

		#endregion
	}

	/// <summary>
	/// Homogeneous tridimensional vertex value type (float coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Float, 4)]
	[DebuggerDisplay("Vertex4f: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4f : IVertex4
	{
		#region Constructors

		/// <summary>
		/// Vertex4f constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Single"/> that specify the value of every component.
		/// </param>
		public Vertex4f(float v)
			: this(v, v, v, v)
		{

		}

		/// <summary>
		/// Vertex4f constructor.
		/// </summary>
		/// <param name="v">
		/// A an array of values that specify the vertex components.
		/// </param>
		public Vertex4f(float[] v)
			: this(v[0], v[1], v[2], v[3])
		{

		}

		/// <summary>
		/// Vertex4f constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="z">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="w">
		/// A <see cref="Single"/>
		/// </param>
		public Vertex4f(float x, float y, float z, float w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		/// <summary>
		/// Vertex4f constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="z">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="w">
		/// A <see cref="Single"/>
		/// </param>
		public Vertex4f(float x, float y, float z) :
			this(x, y, z, 1.0f)
		{
			
		}

		/// <summary>
		/// Vertex4f constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="z">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="w">
		/// A <see cref="Single"/>
		/// </param>
		public Vertex4f(float x, float y) :
			this(x, y, 0.0f, 1.0f)
		{
			
		}

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for fourdimensional vertex.
		/// </summary>
		public float x;

		/// <summary>
		/// Y coordinate for fourdimensional vertex.
		/// </summary>
		public float y;

		/// <summary>
		/// Z coordinate for fourdimensional vertex.
		/// </summary>
		public float z;

		/// <summary>
		/// W coordinate for fourdimensional vertex.
		/// </summary>
		public float w;

		#endregion

		#region Operators

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4f"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/>
		/// </returns>
		public static Vertex4f operator +(Vertex4f v1, Vertex4f v2)
		{
			Vertex4f v;

			v.x = v1.x + v2.x;
			v.y = v1.y + v2.y;
			v.z = v1.z + v2.z;
			v.w = v1.w + v2.w;

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4f"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/>
		/// </returns>
		public static Vertex4f operator -(Vertex4f v1, Vertex4f v2)
		{
			Vertex4f v;

			v.x = v1.x - v2.x;
			v.y = v1.y - v2.y;
			v.z = v1.z - v2.z;
			v.w = v1.w - v2.w;

			return (v);
		}

		/// <summary>
		/// Multiply with scalar operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4f"/> that specify the vertex to be transformed.
		/// </param>
		/// <param name="s">
		/// A <see cref="Single"/> that specify the scalar value to divide.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex4f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex4f operator *(Vertex4f v, float s)
		{
			Vertex4f r;

			r.x = v.x * s;
			r.y = v.y * s;
			r.z = v.z * s;
			r.w = v.w * s;

			return (r);
		}

		/// <summary>
		/// Divide with scalar operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4f"/> that specify the vertex to be transformed.
		/// </param>
		/// <param name="s">
		/// A <see cref="Single"/> that specify the scalar value to divide.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex4f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex4f operator /(Vertex4f v, float s)
		{
			Vertex4f r;

			r.x = v.x / s;
			r.y = v.y / s;
			r.z = v.z / s;
			r.w = v.w / s;

			return (r);
		}

		/// <summary>
		/// Transform vertex using transformation matrix.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4f"/> that specify the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> that specify the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex4f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex4f operator *(Vertex4f v, Matrix4x4 m)
		{
			Vertex4f r;

			r.x = (v.x * m[0, 0]) + (v.y * m[1, 0]) + (v.z * m[2, 0]) + m[3, 0];
			r.y = (v.x * m[0, 1]) + (v.y * m[1, 1]) + (v.z * m[2, 1]) + m[3, 1];
			r.z = (v.x * m[0, 2]) + (v.y * m[1, 2]) + (v.z * m[2, 2]) + m[3, 2];
			r.w = (v.x * m[0, 3]) + (v.y * m[1, 3]) + (v.z * m[2, 3]) + m[3, 3];

			return (r);
		}

		#endregion

		#region Cast

		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <returns>
		/// </returns>
		public static explicit operator float[](Vertex4f a)
		{
			float[] v = new float[4];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;
			v[3] = a.w;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/>
		/// </returns>
		public static explicit operator Vertex3f(Vertex4f a)
		{
			return (new Vertex3f(a.x / a.w, a.y / a.w, a.z / a.w));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/>
		/// </returns>
		public static implicit operator Vertex4d(Vertex4f a)
		{
			return (new Vertex4d(a.x, a.y, a.z, a.w));
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex4f Zero = new Vertex4f(0.0f, 0.0f, 0.0f, 1.0f);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex4f One = new Vertex4f(1.0f);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex4f UnitX = new Vertex4f(1.0f, 0.0f, 0.0f, 1.0f);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex4f UnitY = new Vertex4f(0.0f, 1.0f, 0.0f, 1.0f);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex4f UnitZ = new Vertex4f(0.0f, 0.0f, 1.0f, 1.0f);

		#endregion

		#region IVertex4 Implementation

		/// <summary>
		/// Vertex coordinate X.
		/// </summary>
		public float X
		{
			get { return (x); }
			set { x = value; }
		}

		/// <summary>
		/// Vertex coordinate Y.
		/// </summary>
		public float Y
		{
			get { return (y); }
			set { y = value; }
		}

		/// <summary>
		/// Vertex coordinate Z.
		/// </summary>
		public float Z
		{
			get { return (z); }
			set { z = value; }
		}

		/// <summary>
		/// Vertex coordinate w.
		/// </summary>
		public float W
		{
			get { return (w); }
			set { w = value; }
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="idx"/> is negative or exceed the maximum allowed component index.
		/// </exception>
		/// <exception cref="OverflowException">
		/// Exception thrown if the set value is outside the representable range of signed byte.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0:
						return (X);
					case 1:
						return (Y);
					case 2:
						return (Z);
					case 3:
						return (W);
					default:
						throw new ArgumentException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0:
						X = value;
						break;
					case 1:
						Y = value;
						break;
					case 2:
						Z = value;
						break;
					case 3:
						W = value;
						break;
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex3f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3f.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}, {2}, {3}|", x, y, z, w));
		}

		#endregion
	}

	/// <summary>
	/// Homogeneous tridimensional vertex value type (double coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Double, 4)]
	[DebuggerDisplay("Vertex4d: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4d : IVertex4
	{
		#region Constructors

		/// <summary>
		/// Vertex4d constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Double"/> that specify the value of every component.
		/// </param>
		public Vertex4d(double v)
			: this(v, v, v, v)
		{

		}

		/// <summary>
		/// Vertex4d constructor.
		/// </summary>
		/// <param name="v">
		/// A an array of values that specify the vertex components.
		/// </param>
		public Vertex4d(double[] v)
			: this(v[0], v[1], v[2], v[3])
		{

		}

		/// <summary>
		/// Vertex4d constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="Double"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="Double"/>
		/// </param>
		/// <param name="z">
		/// A <see cref="Double"/>
		/// </param>
		/// <param name="w">
		/// A <see cref="Double"/>
		/// </param>
		public Vertex4d(double x, double y, double z, double w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		/// <summary>
		/// Vertex4d constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex3d"/>
		/// </param>
		/// <param name="w">
		/// A <see cref="Double"/>
		/// </param>
		public Vertex4d(Vertex3d v, double w)
		{
			this.x = v.x;
			this.y = v.y;
			this.z = v.z;
			this.w = w;
		}

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for fourdimensional vertex.
		/// </summary>
		public double x;

		/// <summary>
		/// Y coordinate for fourdimensional vertex.
		/// </summary>
		public double y;

		/// <summary>
		/// Z coordinate for fourdimensional vertex.
		/// </summary>
		public double z;

		/// <summary>
		/// W coordinate for fourdimensional vertex.
		/// </summary>
		public double w;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4d"/>
		/// <returns>
		/// A <see cref="Vertex4d"/>
		/// </returns>
		public static Vertex4d operator -(Vertex4d v1)
		{
			return (new Vertex4d(-v1.x, -v1.y, -v1.z, -v1.w));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4d"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4d"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/>
		/// </returns>
		public static Vertex4d operator +(Vertex4d v1, Vertex4d v2)
		{
			return (new Vertex4d(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z, v1.w + v2.w));
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4d"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4d"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/>
		/// </returns>
		public static Vertex4d operator -(Vertex4d v1, Vertex4d v2)
		{
			return (new Vertex4d(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z, v1.w - v2.w));
		}

		/// <summary>
		/// Multiply with scalar operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4d"/> that specify the vertex to be transformed.
		/// </param>
		/// <param name="s">
		/// A <see cref="Double"/> that specify the scalar value to divide.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex4d"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex4d operator *(Vertex4d v, double s)
		{
			return (new Vertex4d(v.x * s, v.y * s, v.z * s, v.w * s));
		}

		/// <summary>
		/// Divide with scalar operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4d"/> that specify the vertex to be transformed.
		/// </param>
		/// <param name="s">
		/// A <see cref="Double"/> that specify the scalar value to divide.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex4d"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex4d operator /(Vertex4d v, double s)
		{
			return (new Vertex4d(v.x / s, v.y / s, v.z / s, v.w / s));
		}

		/// <summary>
		/// Modulus operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4d"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4d"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/>
		/// </returns>
		public static Vertex4d operator %(Vertex4d v1, Vertex4d v2)
		{
			return (new Vertex4d(v1.x % v2.x, v1.y % v2.y, v1.z % v2.z, v1.w % v2.w));
		}

		/// <summary>
		/// Modulus operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4d"/>
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/>
		/// </returns>
		public static Vertex4d operator %(Vertex4d v1, double scalar)
		{
			return (new Vertex4d(v1.x % scalar, v1.y % scalar, v1.z % scalar, v1.w % scalar));
		}

		#endregion

		#region Cast

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4d"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/>
		/// </returns>
		public static explicit operator Vertex2f(Vertex4d a)
		{
			return (new Vertex2f((float)(a.x / a.w), (float)(a.y / a.w)));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4d"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/>
		/// </returns>
		public static explicit operator Vertex3f(Vertex4d a)
		{
			return (new Vertex3f((float)(a.x / a.w), (float)(a.y / a.w), (float)(a.z / a.w)));
		}

		/// <summary>
		/// Cast to Vertex4f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4d"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/>
		/// </returns>
		public static explicit operator Vertex4f(Vertex4d a)
		{
			return (new Vertex4f((float)a.x, (float)a.y, (float)a.z, (float)a.w));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex4d"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/>
		/// </returns>
		public static implicit operator Vertex3d(Vertex4d a)
		{
			return (new Vertex3d(a.x / a.w, a.y / a.w, a.z / a.w));
		}

		#endregion
		
		#region Vertex Methods

		/// <summary>
		/// Compute bidimensional vertex module.
		/// </summary>
		/// <returns>
		/// It returns the vertex vector module.
		/// </returns>
		public double Module()
		{
			return (((Vertex3d)this).Module());
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			double length = Module();

			if (Math.Abs(length) < Single.Epsilon)
				return;
				//throw new DivideByZeroException("zero length normalization");

			this /= Module();
			w = 1.0;
		}

		/// <summary>
		/// This vertex, but normalized.
		/// </summary>
		public Vertex4d Normalized
		{
			get
			{
				Vertex4d normalized = this;

				normalized.Normalize();

				return (normalized);
			}
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex4d Zero = new Vertex4d(0.0, 0.0, 0.0, 1.0);

		/// <summary>
		/// Unit vertex along all axes (1,1,1,1).
		/// </summary>
		public static readonly Vertex4d One = new Vertex4d(1.0);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex4d UnitX = new Vertex4d(1.0, 0.0, 0.0, 1.0f);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex4d UnitY = new Vertex4d(0.0, 1.0, 0.0, 1.0);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex4d UnitZ = new Vertex4d(0.0, 0.0, 1.0, 1.0);

		#endregion

		#region IVertex4 Implementation

		/// <summary>
		/// Vertex coordinate X.
		/// </summary>
		public float X
		{
			get { return ((float)x); }
			set { x = value; }
		}

		/// <summary>
		/// Vertex coordinate Y.
		/// </summary>
		public float Y
		{
			get { return ((float)y); }
			set { y = value; }
		}

		/// <summary>
		/// Vertex coordinate Z.
		/// </summary>
		public float Z
		{
			get { return ((float)z); }
			set { z = value; }
		}

		/// <summary>
		/// Vertex coordinate w.
		/// </summary>
		public float W
		{
			get { return ((float)w); }
			set { w = value; }
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="idx"/> is negative or exceed the maximum allowed component index.
		/// </exception>
		/// <exception cref="OverflowException">
		/// Exception thrown if the set value is outside the representable range of signed byte.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0:
						return (X);
					case 1:
						return (Y);
					case 2:
						return (Z);
					case 3:
						return (W);
					default:
						throw new ArgumentException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0:
						X = value;
						break;
					case 1:
						Y = value;
						break;
					case 2:
						Z = value;
						break;
					case 3:
						W = value;
						break;
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// Homogeneous tridimensional vertex value type (half-float coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Half, 4)]
	[DebuggerDisplay("Vertex4hf: X={x} Y={y} Z={z} W={w}")]
	public struct Vertex4hf : IVertex4
	{
		#region Constructors

		/// <summary>
		/// Vertex4hf constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="HalfFloat"/> that specify the value of every component.
		/// </param>
		public Vertex4hf(HalfFloat v)
			: this(v, v, v, v)
		{

		}

		/// <summary>
		/// Vertex4hf constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Single"/> that specify the value of every component.
		/// </param>
		public Vertex4hf(float v)
			: this((HalfFloat)v, (HalfFloat)v, (HalfFloat)v, (HalfFloat)v)
		{

		}

		/// <summary>
		/// Vertex4hf constructor.
		/// </summary>
		/// <param name="v">
		/// A an array of values that specify the vertex components.
		/// </param>
		public Vertex4hf(HalfFloat[] v)
			: this(v[0], v[1], v[2], v[3])
		{

		}

		/// <summary>
		/// Vertex4hf constructor.
		/// </summary>
		/// <param name="v">
		/// A an array of values that specify the vertex components.
		/// </param>
		public Vertex4hf(float[] v)
			: this((HalfFloat)v[0], (HalfFloat)v[1], (HalfFloat)v[2], (HalfFloat)v[3])
		{

		}

		/// <summary>
		/// Vertex4hf constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="HalfFloat"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="HalfFloat"/>
		/// </param>
		/// <param name="z">
		/// A <see cref="HalfFloat"/>
		/// </param>
		/// <param name="w">
		/// A <see cref="HalfFloat"/>
		/// </param>
		public Vertex4hf(HalfFloat x, HalfFloat y, HalfFloat z, HalfFloat w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		/// <summary>
		/// Vertex4hf constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="HalfFloat"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="HalfFloat"/>
		/// </param>
		/// <param name="z">
		/// A <see cref="HalfFloat"/>
		/// </param>
		/// <param name="w">
		/// A <see cref="HalfFloat"/>
		/// </param>
		public Vertex4hf(float x, float y, float z, float w)
			: this((HalfFloat)x, (HalfFloat)y, (HalfFloat)z, (HalfFloat)w)
		{

		}

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for fourdimensional vertex.
		/// </summary>
		public HalfFloat x;

		/// <summary>
		/// Y coordinate for fourdimensional vertex.
		/// </summary>
		public HalfFloat y;

		/// <summary>
		/// Z coordinate for fourdimensional vertex.
		/// </summary>
		public HalfFloat z;

		/// <summary>
		/// W coordinate for fourdimensional vertex.
		/// </summary>
		public HalfFloat w;

		#endregion

		#region Operators

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4f"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/>
		/// </returns>
		public static Vertex4hf operator +(Vertex4hf v1, Vertex4hf v2)
		{
			Vertex4hf v;

			v.x = (HalfFloat)(v1.x + v2.x);
			v.y = (HalfFloat)(v1.y + v2.y);
			v.z = (HalfFloat)(v1.z + v2.z);
			v.w = (HalfFloat)(v1.w + v2.w);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex4f"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex4f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/>
		/// </returns>
		public static Vertex4hf operator -(Vertex4hf v1, Vertex4hf v2)
		{
			Vertex4hf v;

			v.x = (HalfFloat)(v1.x - v2.x);
			v.y = (HalfFloat)(v1.y - v2.y);
			v.z = (HalfFloat)(v1.z - v2.z);
			v.w = (HalfFloat)(v1.w - v2.w);

			return (v);
		}

		/// <summary>
		/// Multiply with scalar operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4f"/> that specify the vertex to be transformed.
		/// </param>
		/// <param name="s">
		/// A <see cref="Single"/> that specify the scalar value to divide.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex4f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex4hf operator *(Vertex4hf v, float s)
		{
			Vertex4hf r;

			r.x = (HalfFloat)(v.x * s);
			r.y = (HalfFloat)(v.y * s);
			r.z = (HalfFloat)(v.z * s);
			r.w = (HalfFloat)(v.w * s);

			return (r);
		}

		/// <summary>
		/// Divide with scalar operator.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4f"/> that specify the vertex to be transformed.
		/// </param>
		/// <param name="s">
		/// A <see cref="Single"/> that specify the scalar value to divide.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex4f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex4hf operator /(Vertex4hf v, float s)
		{
			Vertex4hf r;

			r.x = (HalfFloat)(v.x / s);
			r.y = (HalfFloat)(v.y / s);
			r.z = (HalfFloat)(v.z / s);
			r.w = (HalfFloat)(v.w / s);

			return (r);
		}

		/// <summary>
		/// Transform vertex using transformation matrix.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Vertex4f"/> that specify the vertex to be transformed.
		/// </param>
		/// <param name="m">
		/// A <see cref="Matrix4x4"/> that specify the transformation matrix.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex4f"/> which represents the transformed vertex.
		/// </returns>
		public static Vertex4hf operator *(Vertex4hf v, Matrix4x4 m)
		{
			Vertex4hf r;

			r.x = (HalfFloat)((v.x * m[0, 0]) + (v.y * m[1, 0]) + (v.z * m[2, 0]) + m[3, 0]);
			r.y = (HalfFloat)((v.x * m[0, 1]) + (v.y * m[1, 1]) + (v.z * m[2, 1]) + m[3, 1]);
			r.z = (HalfFloat)((v.x * m[0, 2]) + (v.y * m[1, 2]) + (v.z * m[2, 2]) + m[3, 2]);
			r.w = (HalfFloat)((v.x * m[0, 3]) + (v.y * m[1, 3]) + (v.z * m[2, 3]) + m[3, 3]);

			return (r);
		}

		#endregion

		#region Cast

		/// <summary>
		/// 
		/// </summary>
		/// <param name="a"></param>
		/// <returns>
		/// </returns>
		public static explicit operator float[](Vertex4hf a)
		{
			float[] v = new float[4];

			v[0] = a.x;
			v[1] = a.y;
			v[2] = a.z;
			v[3] = a.w;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/>
		/// </returns>
		public static explicit operator Vertex3f(Vertex4hf a)
		{
			Vertex3f v;

			v.x = a.x / a.w;
			v.y = a.y / a.w;
			v.z = a.z / a.w;

			return (v);
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex4hf Zero = new Vertex4hf(0.0f, 0.0f, 0.0f, 1.0f);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex4hf One = new Vertex4hf(1.0f);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex4hf UnitX = new Vertex4hf(1.0f, 0.0f, 0.0f, 1.0f);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex4hf UnitY = new Vertex4hf(0.0f, 1.0f, 0.0f, 1.0f);

		/// <summary>
		/// Unit vertex along Z axis.
		/// </summary>
		public static readonly Vertex4hf UnitZ = new Vertex4hf(0.0f, 0.0f, 1.0f, 1.0f);

		#endregion

		#region IVertex4 Implementation

		/// <summary>
		/// Vertex coordinate X.
		/// </summary>
		public float X
		{
			get { return (x); }
			set { x = (HalfFloat)value; }
		}

		/// <summary>
		/// Vertex coordinate Y.
		/// </summary>
		public float Y
		{
			get { return (y); }
			set { y = (HalfFloat)value; }
		}

		/// <summary>
		/// Vertex coordinate Z.
		/// </summary>
		public float Z
		{
			get { return (z); }
			set { z = (HalfFloat)value; }
		}

		/// <summary>
		/// Vertex coordinate w.
		/// </summary>
		public float W
		{
			get { return (w); }
			set { w = (HalfFloat)value; }
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="idx"/> is negative or exceed the maximum allowed component index.
		/// </exception>
		/// <exception cref="OverflowException">
		/// Exception thrown if the set value is outside the representable range of signed byte.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0:
						return (X);
					case 1:
						return (Y);
					case 2:
						return (Z);
					case 3:
						return (W);
					default:
						throw new ArgumentException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0:
						X = value;
						break;
					case 1:
						Y = value;
						break;
					case 2:
						Z = value;
						break;
					case 3:
						W = value;
						break;
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex3f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3f.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}, {2}, {3}|", x, y, z, w));
		}

		#endregion
	}
}