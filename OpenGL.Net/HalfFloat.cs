
// Copyright (C) 2011 - 2018 Luca Piccioni
// Copyright (c) 2006 - 2008 The Open Toolkit library.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
// of the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
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
// 
// The conversion functions are derived from OpenEXR's implementation and are
// governed by the following license:
//
// Copyright (c) 2002, Industrial Light & Magic, a division of Lucas
// Digital Ltd. LLC
// 
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are
// met:
// *       Redistributions of source code must retain the above copyright
// notice, this list of conditions and the following disclaimer.
// *       Redistributions in binary form must reproduce the above
// copyright notice, this list of conditions and the following disclaimer
// in the documentation and/or other materials provided with the
// distribution.
// *       Neither the name of Industrial Light & Magic nor the names of
// its contributors may be used to endorse or promote products derived
// from this software without specific prior written permission. 
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
// OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
// LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;
#if NETFRAMEWORK
using System.Runtime.Serialization;
using System.Security.Permissions;
#endif

namespace OpenGL
{
	/// <summary>
	/// HalfFloat floating-point number (16 bit).
	/// </summary>
#if NETFRAMEWORK
	[Serializable]
#endif
	[StructLayout(LayoutKind.Sequential)]
	[SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator")]
	public struct HalfFloat : IComparable<HalfFloat>, IFormattable, IEquatable<HalfFloat>
#if NETFRAMEWORK
		, ISerializable
#endif
	{
		#region Constructors

		/// <summary>
		/// Constuct a HalfFloat by specifying its value.
		/// </summary>
		/// <param name="f">
		/// Floating-point (single precision) number.
		/// </param>
		public HalfFloat(float f) : this()
		{
			unsafe {
				_Bits = FloatToHalf(*(int*)&f);
			}
		}

		#endregion

		#region Structure Storage

		/// <summary>
		/// The half-float mBits.
		/// </summary>
		private readonly ushort _Bits;

		#endregion

		#region Data Type Conversions

		/// <summary>
		/// Converts the 16-bit half to 32-bit floating-point.
		/// </summary>
		/// <returns>
		/// A single-precision floating-point number equivalent to this HalfFloat.
		/// </returns>
		public float ToSingle()
		{
			int i = HalfToFloat(_Bits);

			unsafe {
				return *(float*)&i;
			}
		}

		/// <summary>
		/// Converts the 16-bit half to 32-bit floating-point.
		/// </summary>
		/// <param name="ui16">
		/// A <see cref="ushort"/> that specifies the bit representation of the half-precision
		/// floating-point.
		/// </param>
		/// <returns>
		/// A single-precision floating-point number equivalent to <paramref name="ui16"/>.
		/// </returns>
		public static float ToFloat(ushort ui16)
		{
			unsafe {
				int i = HalfToFloat(ui16);

				return *(float*)&i;
			}
		}

		/// <summary>
		/// Ported from OpenEXR's IlmBase 1.0.1
		/// </summary>
		public static int HalfToFloat(ushort ui16)
		{
			int sign = (ui16 >> 15) & 0x00000001;
			int exponent = (ui16 >> 10) & 0x0000001f;
			int mantissa = ui16 & 0x000003ff;

			if (exponent == 0)
			{
				if (mantissa == 0)
				{
					// Plus or minus zero

					return sign << 31;
				}
				else
				{
					// Denormalized number -- renormalize it

					while ((mantissa & 0x00000400) == 0)
					{
						mantissa <<= 1;
						exponent -= 1;
					}

					exponent += 1;
					mantissa &= ~0x00000400;
				}
			}
			else if (exponent == 31)
			{
				if (mantissa == 0)
				{
					// Positive or negative infinity

					return (sign << 31) | 0x7f800000;
				}
				else
				{
					// Nan -- preserve sign and significand mBits

					return (sign << 31) | 0x7f800000 | (mantissa << 13);
				}
			}

			// Normalized number

			exponent = exponent + (127 - 15);
			mantissa = mantissa << 13;

			// Assemble S, E and M.

			return (sign << 31) | (exponent << 23) | mantissa;
		}

		/// <summary>
		/// Ported from OpenEXR's IlmBase 1.0.1
		/// </summary>
		public static ushort FloatToHalf(int si32)
		{
			// Our floating point number, F, is represented by the bit pattern in integer i.
			// Disassemble that bit pattern into the sign, S, the exponent, E, and the significand, M.
			// Shift S into the position where it will go in in the resulting half number.
			// Adjust E, accounting for the different exponent bias of float and half (127 versus 15).

			int sign = (si32 >> 16) & 0x00008000;
			int exponent = ((si32 >> 23) & 0x000000ff) - (127 - 15);
			int mantissa = si32 & 0x007fffff;

			// Now reassemble S, E and M into a half:

			if (exponent <= 0) {
				if (exponent < -10) {
					// E is less than -10. The absolute value of F is less than HalfFloat.MinValue
					// (F may be a small normalized float, a denormalized float or a zero).
					//
					// We convert F to a half zero with the same sign as F.

					return (ushort)sign;
				}

				// E is between -10 and 0. F is a normalized float whose magnitude is less than HalfFloat.MinNormalizedValue.
				//
				// We convert F to a denormalized half.

				// Add an explicit leading 1 to the significand.

				mantissa = mantissa | 0x00800000;

				// Round to M to the nearest (10+E)-bit value (with E between -10 and 0); in case of a tie, round to the nearest even value.
				//
				// Rounding may cause the significand to overflow and make our number normalized. Because of the way a half's bits
				// are laid out, we don't have to treat this case separately; the code below will handle it correctly.

				int t = 14 - exponent;
				int a = (1 << (t - 1)) - 1;
				int b = (mantissa >> t) & 1;

				mantissa = (mantissa + a + b) >> t;

				// Assemble the half from S, E (==zero) and M.

				return (ushort)(sign | mantissa);
			} else if (exponent == 0xff - (127 - 15)) {
				if (mantissa == 0) {
					// F is an infinity; convert F to a half infinity with the same sign as F.

					return (ushort)(sign | 0x7c00);
				} else {
					// F is a NAN; we produce a half NAN that preserves the sign bit and the 10 leftmost bits of the
					// significand of F, with one exception: If the 10 leftmost bits are all zero, the NAN would turn 
					// into an infinity, so we have to set at least one bit in the significand.

					mantissa >>= 13;
					return (ushort)(sign | 0x7c00 | mantissa | (mantissa == 0 ? 1 : 0));
				}
			} else {
				// E is greater than zero.  F is a normalized float. We try to convert F to a normalized half.

				// Round to M to the nearest 10-bit value. In case of a tie, round to the nearest even value.

				mantissa = mantissa + 0x00000fff + ((mantissa >> 13) & 1);

				if ((mantissa & 0x00800000) == 1) {
					mantissa = 0;		// overflow in significand,
					exponent += 1;		// adjust exponent
				}

				// exponent overflow
				if (exponent > 30) throw new ArithmeticException("HalfFloat: Hardware floating-point overflow.");

				// Assemble the half from S, E and M.

				return (ushort)(sign | (exponent << 10) | (mantissa >> 13));
			}
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Converts a <see cref="float"/> to a HalfFloat.
		/// </summary>
		/// <param name="f">
		/// A <see cref="float"/> to convert.
		/// </param>
		/// <returns>
		/// A <see cref="HalfFloat"/> corresponding to <paramref name="f"/>.
		/// </returns>
		public static explicit operator HalfFloat(float f)
		{
			return new HalfFloat(f);
		}

		/// <summary>
		/// Converts a HalfFloat to a <see cref="float"/>.
		/// </summary>
		/// <param name="h">
		/// A <see cref="HalfFloat"/> to convert.
		/// </param>
		/// <returns>
		/// A <see cref="float"/> corresponding to <paramref name="h"/>.
		/// </returns>
		public static implicit operator float(HalfFloat h)
		{
			return h.ToSingle();
		}

		/// <summary>
		/// Converts a HalfFloat to a <see cref="double"/>.
		/// </summary>
		/// <param name="h">
		/// A <see cref="HalfFloat"/> to convert.
		/// </param>
		/// <returns>
		/// A <see cref="double"/> corresponding to <paramref name="h"/>.
		/// </returns>
		public static implicit operator double(HalfFloat h)
		{
			return h.ToSingle();
		}

		#endregion

		#region Constants

		/// <summary>
		/// Smallest positive value represented by a HalfFloat.
		/// </summary>
		public const float MinValue = 5.96046448e-08f;

		/// <summary>
		/// Smallest positive (normalized) value represented by a HalfFloat.
		/// </summary>
		public const float MinNormalizedValue = 6.10351562e-05f;

		/// <summary>
		/// Largest positive value represented by a HalfFloat.
		/// </summary>
		public const float MaxValue = 65504.0f;

		/// <summary>
		/// Smallest positive value 'e' for which half(1.0 + e) != half(1.0).
		/// </summary>
		public const float Epsilon = 0.00097656f;

		#endregion

		#region Special Value Check

		/// <summary>
		/// Returns a boolean value indicating whether this half-float represents zero.
		/// </summary>
		public bool IsZero { get { return _Bits == 0 || _Bits == 0x8000; } }

		/// <summary>
		/// Returns a boolean value indicating whether this half-float represents NaN (not a number).
		/// </summary>
		public bool IsNaN { get { return (_Bits & 0x7C00) == 0x7C00 && (_Bits & 0x03FF) != 0x0000; } }

		/// <summary>
		/// Returns a boolean value indicating whether this half-float represents a positive infinite value.
		/// </summary>
		public bool IsPositiveInfinity { get { return _Bits == 31744; } }

		/// <summary>
		/// Returns a boolean value indicating whether this half-float represents a negative infinite value.
		/// </summary>
		public bool IsNegativeInfinity { get { return _Bits == 64512; } }

		#endregion

		#region String Parser

		/// <summary>
		/// Converts the string representation of a number to a HalfFloat.
		/// </summary>
		/// <param name="s">
		/// String representation of the number to convert.
		/// </param>
		/// <returns>
		/// A HalfFloat instance which value is represented by <paramref name="s"/>.
		/// </returns>
		public static HalfFloat Parse(string s)
		{
			return (HalfFloat)float.Parse(s);
		}

		/// <summary>
		/// Converts the string representation of a number to a HalfFloat.
		/// </summary>
		/// <param name="s">
		/// String representation of the number to convert.
		/// </param>
		/// <param name="style">
		/// Specifies the format of <paramref name="s"/>.
		/// </param>
		/// <param name="provider">
		/// Culture-specific formatting information used in string parsing.
		/// </param>
		/// <returns>
		/// A HalfFloat instance which value is represented by <paramref name="s"/>.
		/// </returns>
		public static HalfFloat Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			return (HalfFloat)float.Parse(s, style, provider);
		}

		/// <summary>
		/// Converts the string representation of a number to a HalfFloat.
		/// </summary>
		/// <param name="s">
		/// String representation of the number to convert.
		/// </param>
		/// <param name="result">
		/// The parsed HalfFloat value.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="s"/> was parsed correctly to HalfFloat.
		/// </returns>
		public static bool TryParse(string s, out HalfFloat result)
		{
			float f;
			bool parsed;

			// Single.TryPause implementation
			parsed = float.TryParse(s, out f);
			// Store result all the same
			result = (HalfFloat)f;

			return parsed;
		}

		/// <summary>
		/// Converts the string representation of a number to a HalfFloat.
		/// </summary>
		/// <param name="s">
		/// String representation of the number to convert.
		/// </param>
		/// <param name="style">
		/// Specifies the format of <paramref name="s"/>.
		/// </param>
		/// <param name="provider">
		/// Culture-specific formatting information used in string parsing.
		/// </param>
		/// <param name="result">
		/// The parsed HalfFloat value.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="s"/> was parsed correctly to HalfFloat.
		/// </returns>
		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out HalfFloat result)
		{
			float f;

			// Single.TryPause implementation
			bool parsed = float.TryParse(s, style, provider, out f);
			// Store result all the same
			result = (HalfFloat)f;

			return parsed;
		}

		#endregion

#if NETFRAMEWORK

		#region ISerializable Implementation

		/// <summary>
		/// Constructor used by ISerializable to deserialize the object.
		/// </summary>
		/// <param name="info">
		/// </param>
		/// <param name="context">
		/// </param>
		private HalfFloat(SerializationInfo info, StreamingContext context)
		{
			_Bits = (ushort)info.GetValue("HalfFloat.mBits", typeof(ushort));
		}

		/// <summary>
		/// Used by ISerialize to serialize the object.
		/// </summary>
		/// <param name="info">
		/// </param>
		/// <param name="context">
		/// </param>
#if NETFRAMEWORK
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
#endif
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("HalfFloat.mBits", _Bits);
		}

		#endregion

#endif

		#region IEquatable<HalfFloat> Implementation

		/// <summary>
		/// Returns a boolean value indicating whether this instance is equal to <paramref name="other"/>.
		/// </summary>
		/// <param name="other">
		/// The HalfFloat to be compared with this HalfFloat.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="other"/> euquals dst this instance.
		/// </returns>
		public bool Equals(HalfFloat other)
		{
			const int maxUlps = 1;

			short aInt, bInt;
			unchecked { aInt = (short)other._Bits; }
			unchecked { bInt = (short)_Bits; }

			// Make aInt lexicographically ordered as a twos-complement int
			if (aInt < 0)
				aInt = (short)(0x8000 - aInt);

			// Make bInt lexicographically ordered as a twos-complement int
			if (bInt < 0)
				bInt = (short)(0x8000 - bInt);

			short intDiff = Math.Abs((short)(aInt - bInt));

			return intDiff <= maxUlps;
		}

		#endregion

		#region IComparable<HalfFloat> Implementation

		/// <summary>
		/// Compares this instance to a specified half-precision floating-point number
		/// and returns an integer that indicates whether the value of this instance
		/// is less than, equal to, or greater than the value of the specified half-precision
		/// floating-point number. 
		/// </summary>
		/// <param name="other">A half-precision floating-point number to compare.</param>
		/// <returns>
		/// </returns>
		public int CompareTo(HalfFloat other)
		{
			return ((float)this).CompareTo(other);
		}

		#endregion

		#region IFormattable Implementation

		///<summary>
		/// Converts this HalfFloat into a human-legible string representation.
		///</summary>
		///<returns>
		///The string representation of this instance.
		///</returns>
		public override string ToString()
		{
			return ToSingle().ToString(CultureInfo.InvariantCulture);
		}

		///<summary>
		/// Converts this HalfFloat into a human-legible string representation.
		///</summary>
		///<param name="format">
		/// Formatting for the output string.
		///</param>
		///<param name="formatProvider">
		/// Culture-specific formatting information.
		///</param>
		///<returns>
		///The string representation of this instance.
		///</returns>
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return ToSingle().ToString(format, formatProvider);
		}

		#endregion
	}
}