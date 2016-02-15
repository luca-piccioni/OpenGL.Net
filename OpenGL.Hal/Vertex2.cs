
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
	/// Bidimensional vertex value type (byte coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Byte, 2)]
	[DebuggerDisplay("Vertex2b: X={x} Y={y}")]
	public struct Vertex2b : IVertex2
	{
		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public sbyte x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public sbyte y;

		#endregion
		
		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3f.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}|", x, y));
		}

		#endregion

		#region IVertex2 Implementation

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
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// Bidimensional vertex value type (byte coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UByte, 2)]
	[DebuggerDisplay("Vertex2ub: X={x} Y={y}")]
	public struct Vertex2ub : IVertex2
	{
		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public byte x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public byte y;

		#endregion
		
		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3f.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}|", x, y));
		}

		#endregion

		#region IVertex2 Implementation

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
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// Bidimensional vertex value type (short coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Short, 2)]
	[DebuggerDisplay("Vertex2s: X={x} Y={y}")]
	public struct Vertex2s : IVertex2
	{
		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public short x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public short y;

		#endregion
		
		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3f.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}|", x, y));
		}

		#endregion

		#region IVertex2 Implementation

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
		/// </exception>
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0:
						return (X);
					case 1:
						return (Y);
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
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// Bidimensional vertex value type (unsigned short coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UShort, 2)]
	[DebuggerDisplay("Vertex2us: X={x} Y={y}")]
	public struct Vertex2us : IVertex2
	{
		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public ushort x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public ushort y;

		#endregion
		
		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3f.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}|", x, y));
		}

		#endregion

		#region IVertex2 Implementation

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
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// Bidimensional vertex value type (integer coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Int, 2)]
	[DebuggerDisplay("Vertex2i: X={x} Y={y}")]
	public struct Vertex2i : IVertex2, IColorInteger2<int>
	{
		#region Constructors

		/// <summary>
		/// Constructor a bidimensional vertex using coordinates.
		/// </summary>
		/// <param name="x">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="Single"/>
		/// </param>
		public Vertex2i(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// Constructor a bidimensional vertex using coordinate array.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Single"/>
		/// </param>
		public Vertex2i(int[] v)
			: this(v[0], v[1])
		{

		}

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public int x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public int y;

		#endregion
		
		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3f.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}|", x, y));
		}

		#endregion

		#region IVertex2 Implementation

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
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion

		#region IColorInteger2<int> Implementation

		/// <summary>
		/// PixelLayout of this IFragment.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.Integer2); } }

		/// <summary>
		/// Get the first integer component.
		/// </summary>
		int IColorInteger2<int>.X { get { return (x); } }

		/// <summary>
		/// Get the second integer component.
		/// </summary>
		int IColorInteger2<int>.Y { get { return (y); } }

		#endregion
	}

	/// <summary>
	/// Bidimensional vertex value type (integer coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UInt, 2)]
	[DebuggerDisplay("Vertex2ui: X={x} Y={y}")]
	public struct Vertex2ui : IVertex2, IColorInteger2<uint>
	{
		#region Constructors

		/// <summary>
		/// Constructor a bidimensional vertex using coordinates.
		/// </summary>
		/// <param name="x">
		/// A <see cref="UInt32"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="UInt32"/>
		/// </param>
		public Vertex2ui(uint x, uint y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// Constructor a bidimensional vertex using coordinate array.
		/// </summary>
		/// <param name="v">
		/// An array of <see cref="UInt32"/>
		/// </param>
		public Vertex2ui(uint[] v)
			: this(v[0], v[1])
		{

		}

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public uint x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public uint y;

		#endregion
		
		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3f.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}|", x, y));
		}

		#endregion

		#region IVertex2 Implementation

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
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion

		#region IColorInteger2<int> Implementation

		/// <summary>
		/// PixelLayout of this IFragment.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.UInteger2); } }

		/// <summary>
		/// Get the first integer component.
		/// </summary>
		uint IColorInteger2<uint>.X { get { return (x); } }

		/// <summary>
		/// Get the second integer component.
		/// </summary>
		uint IColorInteger2<uint>.Y { get { return (y); } }

		#endregion
	}

	/// <summary>
	/// Bidimensional vertex value type (float coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Float, 2)]
	[DebuggerDisplay("Vertex2f: X={x} Y={y}")]
	public struct Vertex2f : IVertex2, IEquatable<IVertex2>
	{
		#region Constructors

		/// <summary>
		/// Vertex2f constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="Single"/>
		/// </param>
		public Vertex2f(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// Vertex2f constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Single"/>
		/// </param>
		public Vertex2f(float[] v)
			:
			this(v[0], v[1])
		{

		}

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public float x;
		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public float y;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator
		/// </summary>
		/// <param name="v1">
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v1"/>.
		/// </returns>
		public static Vertex2f operator -(Vertex2f v1)
		{
			Vertex2f v;

			v.x = -v1.x;
			v.y = -v1.y;

			return (v);
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2f"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/>
		/// </returns>
		public static Vertex2f operator +(Vertex2f v1, Vertex2f v2)
		{
			Vertex2f v;

			v.x = v1.x + v2.x;
			v.y = v1.y + v2.y;

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2f"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/>
		/// </returns>
		public static Vertex2f operator -(Vertex2f v1, Vertex2f v2)
		{
			Vertex2f v;

			v.x = v1.x - v2.x;
			v.y = v1.y - v2.y;

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2f"/>
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/>
		/// </returns>
		public static Vertex2f operator *(Vertex2f v1, float scalar)
		{
			Vertex2f v;

			v.x = v1.x * scalar;
			v.y = v1.y * scalar;

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2f"/>
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/>
		/// </returns>
		public static Vertex2f operator /(Vertex2f v1, float scalar)
		{
			Vertex2f v;

			v.x = v1.x / scalar;
			v.y = v1.y / scalar;

			return (v);
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute bidimensional vertex module.
		/// </summary>
		/// <returns>It returns the vertex vector module.</returns>
		public float Module()
		{
			float x2 = (x * y);
			float y2 = (x * y);

			return ((float)Math.Sqrt(x2 + y2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			this /= Module();
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex2f v1, Vertex2f v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex2f v1, Vertex2f v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to float[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/>
		/// </returns>
		public static explicit operator float[](Vertex2f a)
		{
			float[] v = new float[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/>
		/// </returns>
		public static explicit operator Vertex2d(Vertex2f a)
		{
			Vertex2d v;

			v.x = a.x;
			v.y = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/>
		/// </returns>
		public static explicit operator Vertex3f(Vertex2f a)
		{
			Vertex3f v;

			v.x = a.x;
			v.y = a.y;
			v.z = 0.0f;

			return (v);
		}

		#endregion
		
		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3f.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}|", x, y));
		}

		#endregion

		#region IVertex2 Implementation

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
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex2> Implementation

		/// <summary>
		/// Indicates whether the this Vertex3f is equal to another Vertex3f.
		/// </summary>
		/// <param name="other">
		/// A Matrix to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex2 other)
		{
			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= 1e-6f)
				return (false);
			if (Math.Abs(Y - other.Y) >= 1e-6f)
				return (false);

			return (true);
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (obj.GetType().GetInterface("IVertex") == null)
				return (false);

			return (Equals((IVertex2)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = X.GetHashCode();
				result = (result * 397) ^ Y.GetHashCode();

				return result;
			}
		}

		#endregion
	}

	/// <summary>
	/// Bidimensional vertex value type (double coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Double, 2)]
	[DebuggerDisplay("Vertex2d: X={x} Y={y}")]
	public struct Vertex2d : IVertex2
	{
		#region Constructors

		/// <summary>
		/// Vertex2d constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="Double"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="Double"/>
		/// </param>
		public Vertex2d(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// Vertex2d constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Double"/>
		/// </param>
		public Vertex2d(double[] v)
			: this(v[0], v[1])
		{

		}

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public double x;
		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public double y;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v1">
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v1"/>.
		/// </returns>
		public static Vertex2d operator -(Vertex2d v1)
		{
			return (new Vertex2d(-v1.x, -v1.y));
		}

		/// <summary>
		/// Addition operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2d"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2d"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/>
		/// </returns>
		public static Vertex2d operator +(Vertex2d v1, Vertex2d v2)
		{
			return (new Vertex2d(v1.x + v2.x, v1.y + v2.y));
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2d"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2d"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/>
		/// </returns>
		public static Vertex2d operator -(Vertex2d v1, Vertex2d v2)
		{
			return (new Vertex2d(v1.x - v2.x, v1.y - v2.y));
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2d"/>
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/>
		/// </returns>
		public static Vertex2d operator *(Vertex2d v1, double scalar)
		{
			return (new Vertex2d(v1.x * scalar, v1.y * scalar));
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2d"/>
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/>
		/// </returns>
		public static Vertex2d operator /(Vertex2d v1, double scalar)
		{
			return (new Vertex2d(v1.x / scalar, v1.y / scalar));
		}

		/// <summary>
		/// Modulus operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2d"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2d"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/>
		/// </returns>
		public static Vertex2d operator %(Vertex2d v1, Vertex2d v2)
		{
			return (new Vertex2d(v1.x % v2.x, v1.y % v2.y));
		}

		/// <summary>
		/// Modulus operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2d"/>
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/>
		/// </returns>
		public static Vertex2d operator %(Vertex2d v1, double scalar)
		{
			return (new Vertex2d(v1.x % scalar, v1.y % scalar));
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2d"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/>
		/// </returns>
		public static explicit operator Vertex3d(Vertex2d a)
		{
			Vertex3d v;

			v.x = a.x;
			v.y = a.y;
			v.z = 0.0f;

			return (v);
		}

		#endregion
		
		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3f.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}|", x, y));
		}

		#endregion

		#region IVertex2 Implementation

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
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// Bidimensional vertex value type (float coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Half, 2)]
	[DebuggerDisplay("Vertex2hf: X={x} Y={y}")]
	public struct Vertex2hf : IVertex2, IEquatable<IVertex2>
	{
		#region Constructors

		/// <summary>
		/// Vertex2hf constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="Single"/>
		/// </param>
		/// <param name="y">
		/// A <see cref="Single"/>
		/// </param>
		public Vertex2hf(float x, float y)
		{
			this.x = (HalfFloat)x;
			this.y = (HalfFloat)y;
		}

		/// <summary>
		/// Vertex2f constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="Single"/>
		/// </param>
		public Vertex2hf(float[] v)
			: this(v[0], v[1])
		{

		}

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public HalfFloat x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public HalfFloat y;

		#endregion

		#region Operator Overloading

		/// <summary>
		/// Negate operator
		/// </summary>
		/// <param name="v1">
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v1"/>.
		/// </returns>
		public static Vertex2hf operator -(Vertex2hf v1)
		{
			Vertex2hf v;

			v.x = (HalfFloat)(-v1.x);
			v.y = (HalfFloat)(-v1.y);

			return (v);
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2hf"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2hf"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2hf"/>
		/// </returns>
		public static Vertex2hf operator +(Vertex2hf v1, Vertex2hf v2)
		{
			Vertex2hf v;

			v.x = (HalfFloat)(v1.x + v2.x);
			v.y = (HalfFloat)(v1.y + v2.y);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2hf"/>
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2hf"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2hf"/>
		/// </returns>
		public static Vertex2hf operator -(Vertex2hf v1, Vertex2hf v2)
		{
			Vertex2hf v;

			v.x = (HalfFloat)(v1.x - v2.x);
			v.y = (HalfFloat)(v1.y - v2.y);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2hf"/>
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2hf"/>
		/// </returns>
		public static Vertex2hf operator *(Vertex2hf v1, float scalar)
		{
			Vertex2hf v;

			v.x = (HalfFloat)(v1.x * scalar);
			v.y = (HalfFloat)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2hf"/>
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2hf"/>
		/// </returns>
		public static Vertex2hf operator /(Vertex2hf v1, float scalar)
		{
			Vertex2hf v;

			v.x = (HalfFloat)(v1.x / scalar);
			v.y = (HalfFloat)(v1.y / scalar);

			return (v);
		}

		#endregion

		#region Vertex Methods

		/// <summary>
		/// Compute bidimensional vertex module.
		/// </summary>
		/// <returns>It returns the vertex vector module.</returns>
		public float Module()
		{
			float x2 = (x * y);
			float y2 = (x * y);

			return ((float)Math.Sqrt(x2 + y2));
		}

		/// <summary>
		/// Normalize vertex coordinates.
		/// </summary>
		public void Normalize()
		{
			this /= Module();
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex2hf v1, Vertex2hf v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex2hf v1, Vertex2hf v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Cast

		/// <summary>
		/// Cast to float[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/>
		/// </returns>
		public static explicit operator float[](Vertex2hf a)
		{
			float[] v = new float[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex3f"/>
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/>
		/// </returns>
		public static explicit operator Vertex2d(Vertex2hf a)
		{
			Vertex2d v;

			v.x = a.x;
			v.y = a.y;

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
		public static explicit operator Vertex3f(Vertex2hf a)
		{
			Vertex3f v;

			v.x = a.x;
			v.y = a.y;
			v.z = 0.0f;

			return (v);
		}

		#endregion
		
		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex3f.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}|", x, y));
		}

		#endregion

		#region IVertex2 Implementation

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
					default:
						throw new ArgumentException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex2> Implementation

		/// <summary>
		/// Indicates whether the this Vertex3f is equal to another Vertex3f.
		/// </summary>
		/// <param name="other">
		/// A Matrix to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex2 other)
		{
			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= 1e-6f)
				return (false);
			if (Math.Abs(Y - other.Y) >= 1e-6f)
				return (false);

			return (true);
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (obj.GetType().GetInterface("IVertex") == null)
				return (false);

			return (Equals((IVertex2)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = X.GetHashCode();
				result = (result * 397) ^ Y.GetHashCode();

				return result;
			}
		}

		#endregion
	}
}