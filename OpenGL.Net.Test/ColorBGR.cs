
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
#if HAVE_SYSTEM_DRAWING
using System.Drawing;
#endif

using NUnit.Framework;

// ReSharper disable InconsistentNaming

namespace OpenGL.Test
{
	[TestFixture]
	[Category("Math")]
	internal class ColorBGR8Test : ColorTestBase
	{
		#region Constructors

		[Test(Description = "Test ColorBGR8(byte, byte, byte)")]
		public void ColorBGR8_TestConstructor1()
		{
			byte r = (byte)byte.MaxValue;
			byte g = (byte)byte.MaxValue;
			byte b = (byte)byte.MaxValue;
			
			ColorBGR8 v = new ColorBGR8(r, g, b);

			Assert.AreEqual(r, v.Red);
			Assert.AreEqual(g, v.Green);
			Assert.AreEqual(b, v.Blue);
		}

		#endregion

		#region Cast Operators


#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorBGR8)Color")]
		public void ColorBGR8_CastFromColor()
		{
			const double Epsilon = 0.25;

			Random random = new Random();
			double r = NextComponent(random, 1.0);
			double g = NextComponent(random, 1.0);
			double b = NextComponent(random, 1.0);

			Color c = Color.FromArgb(byte.MaxValue, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorBGR8 v = (ColorBGR8)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);

			// Not influenced by alpha
			c = Color.FromArgb(0, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			v = (ColorBGR8)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
		}

#endif

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorBGR8.PixelType")]
		public void ColorBGR8_PixelType()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);

			ColorBGR8 v = new ColorBGR8(r, g, b);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorBGR8int]")]
		public void ColorBGR8_Accessor()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);

			ColorBGR8 v = new ColorBGR8(r, g, b);
			float c;

			Assert.DoesNotThrow(() => c = v[0]);
			Assert.DoesNotThrow(() => c = v[1]);
			Assert.DoesNotThrow(() => c = v[2]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[+3]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[-1]);

			Assert.DoesNotThrow(() => v[0] = 1.0f);
			Assert.DoesNotThrow(() => v[1] = 1.0f);
			Assert.DoesNotThrow(() => v[2] = 1.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[+3] = 0.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[-1] = 0.0f);

			Assert.DoesNotThrow(() => v[2] = 0.0f);
			Assert.DoesNotThrow(() => v[2] = 1.0f);
			Assert.Throws<InvalidOperationException>(() => v[2] = -1.0f);
			Assert.Throws<InvalidOperationException>(() => v[2] = +1.1f);
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class ColorBGR15Test : ColorTestBase
	{
		#region Constructors

		[Test(Description = "Test ColorBGR15(byte, byte, byte)")]
		public void ColorBGR15_TestConstructor1()
		{
			byte r = (byte)byte.MaxValue;
			byte g = (byte)byte.MaxValue;
			byte b = (byte)byte.MaxValue;
			
			ColorBGR15 v = new ColorBGR15(r, g, b);

			Assert.AreEqual(r, v.Red);
			Assert.AreEqual(g, v.Green);
			Assert.AreEqual(b, v.Blue);
		}

		#endregion

		#region Cast Operators


#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorBGR15)Color")]
		public void ColorBGR15_CastFromColor()
		{
			const double Epsilon = 0.25;

			Random random = new Random();
			double r = NextComponent(random, 1.0);
			double g = NextComponent(random, 1.0);
			double b = NextComponent(random, 1.0);

			Color c = Color.FromArgb(byte.MaxValue, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorBGR15 v = (ColorBGR15)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);

			// Not influenced by alpha
			c = Color.FromArgb(0, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			v = (ColorBGR15)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
		}

#endif

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorBGR15.PixelType")]
		public void ColorBGR15_PixelType()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);

			ColorBGR15 v = new ColorBGR15(r, g, b);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorBGR15int]")]
		public void ColorBGR15_Accessor()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);

			ColorBGR15 v = new ColorBGR15(r, g, b);
			float c;

			Assert.DoesNotThrow(() => c = v[0]);
			Assert.DoesNotThrow(() => c = v[1]);
			Assert.DoesNotThrow(() => c = v[2]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[+3]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[-1]);

			Assert.DoesNotThrow(() => v[0] = 1.0f);
			Assert.DoesNotThrow(() => v[1] = 1.0f);
			Assert.DoesNotThrow(() => v[2] = 1.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[+3] = 0.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[-1] = 0.0f);

			Assert.DoesNotThrow(() => v[2] = 0.0f);
			Assert.DoesNotThrow(() => v[2] = 1.0f);
			Assert.Throws<InvalidOperationException>(() => v[2] = -1.0f);
			Assert.Throws<InvalidOperationException>(() => v[2] = +1.1f);
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class ColorBGR16Test : ColorTestBase
	{
		#region Constructors

		[Test(Description = "Test ColorBGR16(byte, byte, byte)")]
		public void ColorBGR16_TestConstructor1()
		{
			byte r = (byte)byte.MaxValue;
			byte g = (byte)byte.MaxValue;
			byte b = (byte)byte.MaxValue;
			
			ColorBGR16 v = new ColorBGR16(r, g, b);

			Assert.AreEqual(r, v.Red);
			Assert.AreEqual(g, v.Green);
			Assert.AreEqual(b, v.Blue);
		}

		#endregion

		#region Cast Operators


#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorBGR16)Color")]
		public void ColorBGR16_CastFromColor()
		{
			const double Epsilon = 0.25;

			Random random = new Random();
			double r = NextComponent(random, 1.0);
			double g = NextComponent(random, 1.0);
			double b = NextComponent(random, 1.0);

			Color c = Color.FromArgb(byte.MaxValue, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorBGR16 v = (ColorBGR16)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);

			// Not influenced by alpha
			c = Color.FromArgb(0, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			v = (ColorBGR16)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
		}

#endif

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorBGR16.PixelType")]
		public void ColorBGR16_PixelType()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);

			ColorBGR16 v = new ColorBGR16(r, g, b);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorBGR16int]")]
		public void ColorBGR16_Accessor()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);

			ColorBGR16 v = new ColorBGR16(r, g, b);
			float c;

			Assert.DoesNotThrow(() => c = v[0]);
			Assert.DoesNotThrow(() => c = v[1]);
			Assert.DoesNotThrow(() => c = v[2]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[+3]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[-1]);

			Assert.DoesNotThrow(() => v[0] = 1.0f);
			Assert.DoesNotThrow(() => v[1] = 1.0f);
			Assert.DoesNotThrow(() => v[2] = 1.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[+3] = 0.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[-1] = 0.0f);

			Assert.DoesNotThrow(() => v[2] = 0.0f);
			Assert.DoesNotThrow(() => v[2] = 1.0f);
			Assert.Throws<InvalidOperationException>(() => v[2] = -1.0f);
			Assert.Throws<InvalidOperationException>(() => v[2] = +1.1f);
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class ColorBGR24Test : ColorTestBase
	{
		#region Constructors

		[Test(Description = "Test ColorBGR24(byte, byte, byte)")]
		public void ColorBGR24_TestConstructor1()
		{
			byte r = (byte)byte.MaxValue;
			byte g = (byte)byte.MaxValue;
			byte b = (byte)byte.MaxValue;
			
			ColorBGR24 v = new ColorBGR24(r, g, b);

			Assert.AreEqual(r, v.Red);
			Assert.AreEqual(g, v.Green);
			Assert.AreEqual(b, v.Blue);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test (ColorBGRA32)ColorBGR24")]
		public void ColorBGR24_CastToBGRA()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);

			ColorBGR24 v = new ColorBGR24(r, g, b);
			ColorBGRA32 vBGRA = v;

			Assert.AreEqual(v.Red, vBGRA.Red);
			Assert.AreEqual(v.Green, vBGRA.Green);
			Assert.AreEqual(v.Blue, vBGRA.Blue);
			Assert.AreEqual(byte.MaxValue, vBGRA.Alpha);
		}

		[Test(Description = "Test (Vertex4ub)ColorBGR24")]
		public void ColorBGR24_CastToArray()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);

			ColorBGR24 v = new ColorBGR24(r, g, b);
			byte[] vArray = v;

			Assert.AreEqual(3, vArray.Length);
			Assert.AreEqual(b, vArray[0]);
			Assert.AreEqual(g, vArray[1]);
			Assert.AreEqual(r, vArray[2]);
		}

		[Test(Description = "Test (Vertex4ub)ColorBGR24")]
		public void ColorBGR24_CastToVertex4()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);
			
			ColorBGR24 v = new ColorBGR24(r, g, b);
			Vertex3ub vArray = v;

			Assert.AreEqual(b, vArray.x);
			Assert.AreEqual(g, vArray.y);
			Assert.AreEqual(r, vArray.z);
		}

#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorBGR24)Color")]
		public void ColorBGR24_CastFromColor()
		{
			const double Epsilon = 0.25;

			Random random = new Random();
			double r = NextComponent(random, 1.0);
			double g = NextComponent(random, 1.0);
			double b = NextComponent(random, 1.0);

			Color c = Color.FromArgb(byte.MaxValue, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorBGR24 v = (ColorBGR24)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);

			// Not influenced by alpha
			c = Color.FromArgb(0, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			v = (ColorBGR24)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
		}

#endif

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorBGR24.PixelType")]
		public void ColorBGR24_PixelType()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);

			ColorBGR24 v = new ColorBGR24(r, g, b);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorBGR24int]")]
		public void ColorBGR24_Accessor()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);

			ColorBGR24 v = new ColorBGR24(r, g, b);
			float c;

			Assert.DoesNotThrow(() => c = v[0]);
			Assert.DoesNotThrow(() => c = v[1]);
			Assert.DoesNotThrow(() => c = v[2]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[+3]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[-1]);

			Assert.DoesNotThrow(() => v[0] = 1.0f);
			Assert.DoesNotThrow(() => v[1] = 1.0f);
			Assert.DoesNotThrow(() => v[2] = 1.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[+3] = 0.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[-1] = 0.0f);

			Assert.DoesNotThrow(() => v[2] = 0.0f);
			Assert.DoesNotThrow(() => v[2] = 1.0f);
			Assert.Throws<InvalidOperationException>(() => v[2] = -1.0f);
			Assert.Throws<InvalidOperationException>(() => v[2] = +1.1f);
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class ColorBGR48Test : ColorTestBase
	{
		#region Constructors

		[Test(Description = "Test ColorBGR48(ushort, ushort, ushort)")]
		public void ColorBGR48_TestConstructor1()
		{
			ushort r = (ushort)ushort.MaxValue;
			ushort g = (ushort)ushort.MaxValue;
			ushort b = (ushort)ushort.MaxValue;
			
			ColorBGR48 v = new ColorBGR48(r, g, b);

			Assert.AreEqual(r, v.Red);
			Assert.AreEqual(g, v.Green);
			Assert.AreEqual(b, v.Blue);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test (ColorBGRA64)ColorBGR48")]
		public void ColorBGR48_CastToBGRA()
		{
			Random random = new Random();
			ushort r = (ushort)NextComponent(random, ushort.MaxValue);
			ushort g = (ushort)NextComponent(random, ushort.MaxValue);
			ushort b = (ushort)NextComponent(random, ushort.MaxValue);

			ColorBGR48 v = new ColorBGR48(r, g, b);
			ColorBGRA64 vBGRA = v;

			Assert.AreEqual(v.Red, vBGRA.Red);
			Assert.AreEqual(v.Green, vBGRA.Green);
			Assert.AreEqual(v.Blue, vBGRA.Blue);
			Assert.AreEqual(ushort.MaxValue, vBGRA.Alpha);
		}

		[Test(Description = "Test (Vertex4ub)ColorBGR48")]
		public void ColorBGR48_CastToArray()
		{
			Random random = new Random();
			ushort r = (ushort)NextComponent(random, ushort.MaxValue);
			ushort g = (ushort)NextComponent(random, ushort.MaxValue);
			ushort b = (ushort)NextComponent(random, ushort.MaxValue);

			ColorBGR48 v = new ColorBGR48(r, g, b);
			ushort[] vArray = v;

			Assert.AreEqual(3, vArray.Length);
			Assert.AreEqual(b, vArray[0]);
			Assert.AreEqual(g, vArray[1]);
			Assert.AreEqual(r, vArray[2]);
		}

		[Test(Description = "Test (Vertex4ub)ColorBGR48")]
		public void ColorBGR48_CastToVertex4()
		{
			Random random = new Random();
			ushort r = (ushort)NextComponent(random, ushort.MaxValue);
			ushort g = (ushort)NextComponent(random, ushort.MaxValue);
			ushort b = (ushort)NextComponent(random, ushort.MaxValue);
			
			ColorBGR48 v = new ColorBGR48(r, g, b);
			Vertex3us vArray = v;

			Assert.AreEqual(b, vArray.x);
			Assert.AreEqual(g, vArray.y);
			Assert.AreEqual(r, vArray.z);
		}

#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorBGR48)Color")]
		public void ColorBGR48_CastFromColor()
		{
			const double Epsilon = 0.25;

			Random random = new Random();
			double r = NextComponent(random, 1.0);
			double g = NextComponent(random, 1.0);
			double b = NextComponent(random, 1.0);

			Color c = Color.FromArgb(byte.MaxValue, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorBGR48 v = (ColorBGR48)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);

			// Not influenced by alpha
			c = Color.FromArgb(0, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			v = (ColorBGR48)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
		}

#endif

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorBGR48.PixelType")]
		public void ColorBGR48_PixelType()
		{
			Random random = new Random();
			ushort r = (ushort)NextComponent(random, ushort.MaxValue);
			ushort g = (ushort)NextComponent(random, ushort.MaxValue);
			ushort b = (ushort)NextComponent(random, ushort.MaxValue);

			ColorBGR48 v = new ColorBGR48(r, g, b);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorBGR48int]")]
		public void ColorBGR48_Accessor()
		{
			Random random = new Random();
			ushort r = (ushort)NextComponent(random, ushort.MaxValue);
			ushort g = (ushort)NextComponent(random, ushort.MaxValue);
			ushort b = (ushort)NextComponent(random, ushort.MaxValue);

			ColorBGR48 v = new ColorBGR48(r, g, b);
			float c;

			Assert.DoesNotThrow(() => c = v[0]);
			Assert.DoesNotThrow(() => c = v[1]);
			Assert.DoesNotThrow(() => c = v[2]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[+3]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[-1]);

			Assert.DoesNotThrow(() => v[0] = 1.0f);
			Assert.DoesNotThrow(() => v[1] = 1.0f);
			Assert.DoesNotThrow(() => v[2] = 1.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[+3] = 0.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[-1] = 0.0f);

			Assert.DoesNotThrow(() => v[2] = 0.0f);
			Assert.DoesNotThrow(() => v[2] = 1.0f);
			Assert.Throws<InvalidOperationException>(() => v[2] = -1.0f);
			Assert.Throws<InvalidOperationException>(() => v[2] = +1.1f);
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class ColorBGR96Test : ColorTestBase
	{
		#region Constructors

		[Test(Description = "Test ColorBGR96(uint, uint, uint)")]
		public void ColorBGR96_TestConstructor1()
		{
			uint r = (uint)uint.MaxValue;
			uint g = (uint)uint.MaxValue;
			uint b = (uint)uint.MaxValue;
			
			ColorBGR96 v = new ColorBGR96(r, g, b);

			Assert.AreEqual(r, v.Red);
			Assert.AreEqual(g, v.Green);
			Assert.AreEqual(b, v.Blue);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test (Vertex4ub)ColorBGR96")]
		public void ColorBGR96_CastToArray()
		{
			Random random = new Random();
			uint r = (uint)NextComponent(random, uint.MaxValue);
			uint g = (uint)NextComponent(random, uint.MaxValue);
			uint b = (uint)NextComponent(random, uint.MaxValue);

			ColorBGR96 v = new ColorBGR96(r, g, b);
			uint[] vArray = v;

			Assert.AreEqual(3, vArray.Length);
			Assert.AreEqual(b, vArray[0]);
			Assert.AreEqual(g, vArray[1]);
			Assert.AreEqual(r, vArray[2]);
		}

		[Test(Description = "Test (Vertex4ub)ColorBGR96")]
		public void ColorBGR96_CastToVertex4()
		{
			Random random = new Random();
			uint r = (uint)NextComponent(random, uint.MaxValue);
			uint g = (uint)NextComponent(random, uint.MaxValue);
			uint b = (uint)NextComponent(random, uint.MaxValue);
			
			ColorBGR96 v = new ColorBGR96(r, g, b);
			Vertex3ui vArray = v;

			Assert.AreEqual(b, vArray.x);
			Assert.AreEqual(g, vArray.y);
			Assert.AreEqual(r, vArray.z);
		}

#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorBGR96)Color")]
		public void ColorBGR96_CastFromColor()
		{
			const double Epsilon = 0.25;

			Random random = new Random();
			double r = NextComponent(random, 1.0);
			double g = NextComponent(random, 1.0);
			double b = NextComponent(random, 1.0);

			Color c = Color.FromArgb(byte.MaxValue, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorBGR96 v = (ColorBGR96)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);

			// Not influenced by alpha
			c = Color.FromArgb(0, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			v = (ColorBGR96)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
		}

#endif

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorBGR96.PixelType")]
		public void ColorBGR96_PixelType()
		{
			Random random = new Random();
			uint r = (uint)NextComponent(random, uint.MaxValue);
			uint g = (uint)NextComponent(random, uint.MaxValue);
			uint b = (uint)NextComponent(random, uint.MaxValue);

			ColorBGR96 v = new ColorBGR96(r, g, b);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorBGR96int]")]
		public void ColorBGR96_Accessor()
		{
			Random random = new Random();
			uint r = (uint)NextComponent(random, uint.MaxValue);
			uint g = (uint)NextComponent(random, uint.MaxValue);
			uint b = (uint)NextComponent(random, uint.MaxValue);

			ColorBGR96 v = new ColorBGR96(r, g, b);
			float c;

			Assert.DoesNotThrow(() => c = v[0]);
			Assert.DoesNotThrow(() => c = v[1]);
			Assert.DoesNotThrow(() => c = v[2]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[+3]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[-1]);

			Assert.DoesNotThrow(() => v[0] = 1.0f);
			Assert.DoesNotThrow(() => v[1] = 1.0f);
			Assert.DoesNotThrow(() => v[2] = 1.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[+3] = 0.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[-1] = 0.0f);

			Assert.DoesNotThrow(() => v[2] = 0.0f);
			Assert.DoesNotThrow(() => v[2] = 1.0f);
			Assert.Throws<InvalidOperationException>(() => v[2] = -1.0f);
			Assert.Throws<InvalidOperationException>(() => v[2] = +1.1f);
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class ColorBGRFTest : ColorTestBase
	{
		#region Constructors

		[Test(Description = "Test ColorBGRF(float, float, float)")]
		public void ColorBGRF_TestConstructor1()
		{
			float r = (float)1.0f;
			float g = (float)1.0f;
			float b = (float)1.0f;
			
			ColorBGRF v = new ColorBGRF(r, g, b);

			Assert.AreEqual(r, v.Red);
			Assert.AreEqual(g, v.Green);
			Assert.AreEqual(b, v.Blue);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test (ColorBGRAF)ColorBGRF")]
		public void ColorBGRF_CastToBGRA()
		{
			Random random = new Random();
			float r = (float)NextComponent(random, 1.0f);
			float g = (float)NextComponent(random, 1.0f);
			float b = (float)NextComponent(random, 1.0f);

			ColorBGRF v = new ColorBGRF(r, g, b);
			ColorBGRAF vBGRA = v;

			Assert.AreEqual(v.Red, vBGRA.Red);
			Assert.AreEqual(v.Green, vBGRA.Green);
			Assert.AreEqual(v.Blue, vBGRA.Blue);
			Assert.AreEqual(1.0f, vBGRA.Alpha);
		}

		[Test(Description = "Test (Vertex4ub)ColorBGRF")]
		public void ColorBGRF_CastToArray()
		{
			Random random = new Random();
			float r = (float)NextComponent(random, 1.0f);
			float g = (float)NextComponent(random, 1.0f);
			float b = (float)NextComponent(random, 1.0f);

			ColorBGRF v = new ColorBGRF(r, g, b);
			float[] vArray = v;

			Assert.AreEqual(3, vArray.Length);
			Assert.AreEqual(b, vArray[0]);
			Assert.AreEqual(g, vArray[1]);
			Assert.AreEqual(r, vArray[2]);
		}

		[Test(Description = "Test (Vertex4ub)ColorBGRF")]
		public void ColorBGRF_CastToVertex4()
		{
			Random random = new Random();
			float r = (float)NextComponent(random, 1.0f);
			float g = (float)NextComponent(random, 1.0f);
			float b = (float)NextComponent(random, 1.0f);
			
			ColorBGRF v = new ColorBGRF(r, g, b);
			Vertex3f vArray = v;

			Assert.AreEqual(b, vArray.x);
			Assert.AreEqual(g, vArray.y);
			Assert.AreEqual(r, vArray.z);
		}

#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorBGRF)Color")]
		public void ColorBGRF_CastFromColor()
		{
			const double Epsilon = 0.25;

			Random random = new Random();
			double r = NextComponent(random, 1.0);
			double g = NextComponent(random, 1.0);
			double b = NextComponent(random, 1.0);

			Color c = Color.FromArgb(byte.MaxValue, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorBGRF v = (ColorBGRF)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);

			// Not influenced by alpha
			c = Color.FromArgb(0, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			v = (ColorBGRF)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
		}

#endif

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorBGRF.PixelType")]
		public void ColorBGRF_PixelType()
		{
			Random random = new Random();
			float r = (float)NextComponent(random, 1.0f);
			float g = (float)NextComponent(random, 1.0f);
			float b = (float)NextComponent(random, 1.0f);

			ColorBGRF v = new ColorBGRF(r, g, b);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorBGRFint]")]
		public void ColorBGRF_Accessor()
		{
			Random random = new Random();
			float r = (float)NextComponent(random, 1.0f);
			float g = (float)NextComponent(random, 1.0f);
			float b = (float)NextComponent(random, 1.0f);

			ColorBGRF v = new ColorBGRF(r, g, b);
			float c;

			Assert.DoesNotThrow(() => c = v[0]);
			Assert.DoesNotThrow(() => c = v[1]);
			Assert.DoesNotThrow(() => c = v[2]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[+3]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[-1]);

			Assert.DoesNotThrow(() => v[0] = 1.0f);
			Assert.DoesNotThrow(() => v[1] = 1.0f);
			Assert.DoesNotThrow(() => v[2] = 1.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[+3] = 0.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[-1] = 0.0f);

			Assert.DoesNotThrow(() => v[2] = 0.0f);
			Assert.DoesNotThrow(() => v[2] = 1.0f);
			Assert.Throws<InvalidOperationException>(() => v[2] = -1.0f);
			Assert.Throws<InvalidOperationException>(() => v[2] = +1.1f);
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class ColorBGRDTest : ColorTestBase
	{
		#region Constructors

		[Test(Description = "Test ColorBGRD(double, double, double)")]
		public void ColorBGRD_TestConstructor1()
		{
			double r = (double)1.0;
			double g = (double)1.0;
			double b = (double)1.0;
			
			ColorBGRD v = new ColorBGRD(r, g, b);

			Assert.AreEqual(r, v.Red);
			Assert.AreEqual(g, v.Green);
			Assert.AreEqual(b, v.Blue);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test (Vertex4ub)ColorBGRD")]
		public void ColorBGRD_CastToArray()
		{
			Random random = new Random();
			double r = (double)NextComponent(random, 1.0);
			double g = (double)NextComponent(random, 1.0);
			double b = (double)NextComponent(random, 1.0);

			ColorBGRD v = new ColorBGRD(r, g, b);
			double[] vArray = v;

			Assert.AreEqual(3, vArray.Length);
			Assert.AreEqual(b, vArray[0]);
			Assert.AreEqual(g, vArray[1]);
			Assert.AreEqual(r, vArray[2]);
		}

		[Test(Description = "Test (Vertex4ub)ColorBGRD")]
		public void ColorBGRD_CastToVertex4()
		{
			Random random = new Random();
			double r = (double)NextComponent(random, 1.0);
			double g = (double)NextComponent(random, 1.0);
			double b = (double)NextComponent(random, 1.0);
			
			ColorBGRD v = new ColorBGRD(r, g, b);
			Vertex3d vArray = v;

			Assert.AreEqual(b, vArray.x);
			Assert.AreEqual(g, vArray.y);
			Assert.AreEqual(r, vArray.z);
		}

#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorBGRD)Color")]
		public void ColorBGRD_CastFromColor()
		{
			const double Epsilon = 0.25;

			Random random = new Random();
			double r = NextComponent(random, 1.0);
			double g = NextComponent(random, 1.0);
			double b = NextComponent(random, 1.0);

			Color c = Color.FromArgb(byte.MaxValue, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorBGRD v = (ColorBGRD)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);

			// Not influenced by alpha
			c = Color.FromArgb(0, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			v = (ColorBGRD)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
		}

#endif

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorBGRD.PixelType")]
		public void ColorBGRD_PixelType()
		{
			Random random = new Random();
			double r = (double)NextComponent(random, 1.0);
			double g = (double)NextComponent(random, 1.0);
			double b = (double)NextComponent(random, 1.0);

			ColorBGRD v = new ColorBGRD(r, g, b);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorBGRDint]")]
		public void ColorBGRD_Accessor()
		{
			Random random = new Random();
			double r = (double)NextComponent(random, 1.0);
			double g = (double)NextComponent(random, 1.0);
			double b = (double)NextComponent(random, 1.0);

			ColorBGRD v = new ColorBGRD(r, g, b);
			float c;

			Assert.DoesNotThrow(() => c = v[0]);
			Assert.DoesNotThrow(() => c = v[1]);
			Assert.DoesNotThrow(() => c = v[2]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[+3]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[-1]);

			Assert.DoesNotThrow(() => v[0] = 1.0f);
			Assert.DoesNotThrow(() => v[1] = 1.0f);
			Assert.DoesNotThrow(() => v[2] = 1.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[+3] = 0.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[-1] = 0.0f);

			Assert.DoesNotThrow(() => v[2] = 0.0f);
			Assert.DoesNotThrow(() => v[2] = 1.0f);
			Assert.Throws<InvalidOperationException>(() => v[2] = -1.0f);
			Assert.Throws<InvalidOperationException>(() => v[2] = +1.1f);
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class ColorBGRHFTest : ColorTestBase
	{
		#region Constructors

		[Test(Description = "Test ColorBGRHF(HalfFloat, HalfFloat, HalfFloat)")]
		public void ColorBGRHF_TestConstructor1()
		{
			HalfFloat r = (HalfFloat)(HalfFloat)1.0f;
			HalfFloat g = (HalfFloat)(HalfFloat)1.0f;
			HalfFloat b = (HalfFloat)(HalfFloat)1.0f;
			
			ColorBGRHF v = new ColorBGRHF(r, g, b);

			Assert.AreEqual(r, v.Red);
			Assert.AreEqual(g, v.Green);
			Assert.AreEqual(b, v.Blue);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test (ColorBGRAHF)ColorBGRHF")]
		public void ColorBGRHF_CastToBGRA()
		{
			Random random = new Random();
			HalfFloat r = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat g = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat b = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);

			ColorBGRHF v = new ColorBGRHF(r, g, b);
			ColorBGRAHF vBGRA = v;

			Assert.AreEqual(v.Red, vBGRA.Red);
			Assert.AreEqual(v.Green, vBGRA.Green);
			Assert.AreEqual(v.Blue, vBGRA.Blue);
			Assert.AreEqual((HalfFloat)1.0f, vBGRA.Alpha);
		}

		[Test(Description = "Test (Vertex4ub)ColorBGRHF")]
		public void ColorBGRHF_CastToArray()
		{
			Random random = new Random();
			HalfFloat r = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat g = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat b = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);

			ColorBGRHF v = new ColorBGRHF(r, g, b);
			HalfFloat[] vArray = v;

			Assert.AreEqual(3, vArray.Length);
			Assert.AreEqual(b, vArray[0]);
			Assert.AreEqual(g, vArray[1]);
			Assert.AreEqual(r, vArray[2]);
		}

		[Test(Description = "Test (Vertex4ub)ColorBGRHF")]
		public void ColorBGRHF_CastToVertex4()
		{
			Random random = new Random();
			HalfFloat r = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat g = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat b = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			
			ColorBGRHF v = new ColorBGRHF(r, g, b);
			Vertex3hf vArray = v;

			Assert.AreEqual(b, vArray.x);
			Assert.AreEqual(g, vArray.y);
			Assert.AreEqual(r, vArray.z);
		}

#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorBGRHF)Color")]
		public void ColorBGRHF_CastFromColor()
		{
			const double Epsilon = 0.25;

			Random random = new Random();
			double r = NextComponent(random, 1.0);
			double g = NextComponent(random, 1.0);
			double b = NextComponent(random, 1.0);

			Color c = Color.FromArgb(byte.MaxValue, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorBGRHF v = (ColorBGRHF)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);

			// Not influenced by alpha
			c = Color.FromArgb(0, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			v = (ColorBGRHF)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
		}

#endif

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorBGRHF.PixelType")]
		public void ColorBGRHF_PixelType()
		{
			Random random = new Random();
			HalfFloat r = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat g = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat b = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);

			ColorBGRHF v = new ColorBGRHF(r, g, b);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorBGRHFint]")]
		public void ColorBGRHF_Accessor()
		{
			Random random = new Random();
			HalfFloat r = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat g = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat b = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);

			ColorBGRHF v = new ColorBGRHF(r, g, b);
			float c;

			Assert.DoesNotThrow(() => c = v[0]);
			Assert.DoesNotThrow(() => c = v[1]);
			Assert.DoesNotThrow(() => c = v[2]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[+3]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[-1]);

			Assert.DoesNotThrow(() => v[0] = 1.0f);
			Assert.DoesNotThrow(() => v[1] = 1.0f);
			Assert.DoesNotThrow(() => v[2] = 1.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[+3] = 0.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[-1] = 0.0f);

			Assert.DoesNotThrow(() => v[2] = 0.0f);
			Assert.DoesNotThrow(() => v[2] = 1.0f);
			Assert.Throws<InvalidOperationException>(() => v[2] = -1.0f);
			Assert.Throws<InvalidOperationException>(() => v[2] = +1.1f);
		}

		#endregion
	}

}