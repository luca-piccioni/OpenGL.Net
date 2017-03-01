
// Copyright (C) 2009-2017 Luca Piccioni
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
	/// R color (single component).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Byte, 1)]
	public struct ColorR8 : IColor
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorR8 specifying R component.
		/// </summary>
		/// <param name="r">
		/// A <see cref="byte"/> that specify the red component.
		/// </param>
		public ColorR8(byte r)
		{
			// Setup R components
			this.r = r;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Red color component.
		/// </summary>
		public byte r;

		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.R8); } }

		/// <summary>
		/// Get of set color components.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index.
		/// </param>
		/// <returns>
		/// The color component converted from a normalized floating point number.
		/// </returns>
		/// <exception cref="IndexOutOfRangeException">
		/// Exception thrown when <paramref name="c"/> is less than 0 or greater than the number of components of this IColor implementation.
		/// </exception>
		public float this[int c]
		{
			get
			{
				switch (c) {
					case 0: return ((float)r   / byte.MaxValue);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 0: r =   (byte)(value * byte.MaxValue); break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// R color (single component).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UShort, 1)]
	public struct ColorR16 : IColor
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorR16 specifying R component.
		/// </summary>
		/// <param name="r">
		/// A <see cref="byte"/> that specify the red component.
		/// </param>
		public ColorR16(byte r)
		{
			// Setup R components
			this.r = r;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Red color component.
		/// </summary>
		public ushort r;

		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.R16); } }

		/// <summary>
		/// Get of set color components.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index.
		/// </param>
		/// <returns>
		/// The color component converted from a normalized floating point number.
		/// </returns>
		/// <exception cref="IndexOutOfRangeException">
		/// Exception thrown when <paramref name="c"/> is less than 0 or greater than the number of components of this IColor implementation.
		/// </exception>
		public float this[int c]
		{
			get
			{
				switch (c) {
					case 0: return ((float)r   / byte.MaxValue);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 0: r =   (byte)(value * byte.MaxValue); break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// R color (single component).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UInt, 1)]
	public struct ColorR32 : IColor
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorR32 specifying R component.
		/// </summary>
		/// <param name="r">
		/// A <see cref="byte"/> that specify the red component.
		/// </param>
		public ColorR32(byte r)
		{
			// Setup R components
			this.r = r;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Red color component.
		/// </summary>
		public uint r;

		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.R32); } }

		/// <summary>
		/// Get of set color components.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index.
		/// </param>
		/// <returns>
		/// The color component converted from a normalized floating point number.
		/// </returns>
		/// <exception cref="IndexOutOfRangeException">
		/// Exception thrown when <paramref name="c"/> is less than 0 or greater than the number of components of this IColor implementation.
		/// </exception>
		public float this[int c]
		{
			get
			{
				switch (c) {
					case 0: return ((float)r   / byte.MaxValue);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 0: r =   (byte)(value * byte.MaxValue); break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// R color (single component).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Float, 1)]
	public struct ColorRF : IColor
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorRF specifying R component.
		/// </summary>
		/// <param name="r">
		/// A <see cref="float"/> that specify the red component.
		/// </param>
		public ColorRF(float r)
		{
			// Setup R components
			this.r = r;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Red color component.
		/// </summary>
		public float r;

		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RF); } }

		/// <summary>
		/// Get of set color components.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index.
		/// </param>
		/// <returns>
		/// The color component converted from a normalized floating point number.
		/// </returns>
		/// <exception cref="IndexOutOfRangeException">
		/// Exception thrown when <paramref name="c"/> is less than 0 or greater than the number of components of this IColor implementation.
		/// </exception>
		public float this[int c]
		{
			get
			{
				switch (c) {
					case 0: return (r);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 0: r =   (float)value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// R color (single component).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Double, 1)]
	public struct ColorRD : IColor
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorRD specifying R component.
		/// </summary>
		/// <param name="r">
		/// A <see cref="double"/> that specify the red component.
		/// </param>
		public ColorRD(double r)
		{
			// Setup R components
			this.r = r;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Red color component.
		/// </summary>
		public double r;

		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RD); } }

		/// <summary>
		/// Get of set color components.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index.
		/// </param>
		/// <returns>
		/// The color component converted from a normalized floating point number.
		/// </returns>
		/// <exception cref="IndexOutOfRangeException">
		/// Exception thrown when <paramref name="c"/> is less than 0 or greater than the number of components of this IColor implementation.
		/// </exception>
		public float this[int c]
		{
			get
			{
				switch (c) {
					case 0: return ((float)r);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 0: r =   (double)value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion
	}

	/// <summary>
	/// R color (single component).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Half, 1)]
	public struct ColorRHF : IColor
	{
		#region Constructors

		/// <summary>
		/// Construct a ColorRHF specifying R component.
		/// </summary>
		/// <param name="r">
		/// A <see cref="HalfFloat"/> that specify the red component.
		/// </param>
		public ColorRHF(HalfFloat r)
		{
			// Setup R components
			this.r = r;
		}

		#endregion

		#region Structure

		/// <summary>
		/// Red color component.
		/// </summary>
		public HalfFloat r;

		#endregion

		#region IColor Implementation

		/// <summary>
		/// Get the PixelLayout correponding to this IColor.
		/// </summary>
		public PixelLayout PixelType { get { return (PixelLayout.RHF); } }

		/// <summary>
		/// Get of set color components.
		/// </summary>
		/// <param name="c">
		/// A <see cref="Int32"/> indicating the color component index.
		/// </param>
		/// <returns>
		/// The color component converted from a normalized floating point number.
		/// </returns>
		/// <exception cref="IndexOutOfRangeException">
		/// Exception thrown when <paramref name="c"/> is less than 0 or greater than the number of components of this IColor implementation.
		/// </exception>
		public float this[int c]
		{
			get
			{
				switch (c) {
					case 0: return (r);
					default:
						throw new IndexOutOfRangeException();
				}
			}
			set
			{
				if (value < 0.0f || value > 1.0f)
					throw new InvalidOperationException("value out of range");
				switch (c) {
					case 0: r =   (HalfFloat)value; break;
					default:
						throw new IndexOutOfRangeException();
				}
			}
		}

		#endregion
	}

}
