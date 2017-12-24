
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
	internal class ColorRGB8Test : ColorTestBase
	{
		#region Constructors

		[Test(Description = "Test ColorRGB8(byte, byte, byte)")]
		public void ColorRGB8_TestConstructor1()
		{
			byte r = (byte)byte.MaxValue;
			byte g = (byte)byte.MaxValue;
			byte b = (byte)byte.MaxValue;
			
			ColorRGB8 v = new ColorRGB8(r, g, b);

			Assert.AreEqual(r, v.Red);
			Assert.AreEqual(g, v.Green);
			Assert.AreEqual(b, v.Blue);
		}

		#endregion

		#region Cast Operators


#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorRGB8)Color")]
		public void ColorRGB8_CastFromColor()
		{
			const double Epsilon = 0.25;

			Random random = new Random();
			double r = NextComponent(random, 1.0);
			double g = NextComponent(random, 1.0);
			double b = NextComponent(random, 1.0);

			Color c = Color.FromArgb(byte.MaxValue, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorRGB8 v = (ColorRGB8)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);

			// Not influenced by alpha
			c = Color.FromArgb(0, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			v = (ColorRGB8)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
		}

#endif

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorRGB8.PixelType")]
		public void ColorRGB8_PixelType()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);

			ColorRGB8 v = new ColorRGB8(r, g, b);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorRGB8int]")]
		public void ColorRGB8_Accessor()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);

			ColorRGB8 v = new ColorRGB8(r, g, b);
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
	internal class ColorRGB15Test : ColorTestBase
	{
		#region Constructors

		[Test(Description = "Test ColorRGB15(byte, byte, byte)")]
		public void ColorRGB15_TestConstructor1()
		{
			byte r = (byte)byte.MaxValue;
			byte g = (byte)byte.MaxValue;
			byte b = (byte)byte.MaxValue;
			
			ColorRGB15 v = new ColorRGB15(r, g, b);

			Assert.AreEqual(r, v.Red);
			Assert.AreEqual(g, v.Green);
			Assert.AreEqual(b, v.Blue);
		}

		#endregion

		#region Cast Operators


#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorRGB15)Color")]
		public void ColorRGB15_CastFromColor()
		{
			const double Epsilon = 0.25;

			Random random = new Random();
			double r = NextComponent(random, 1.0);
			double g = NextComponent(random, 1.0);
			double b = NextComponent(random, 1.0);

			Color c = Color.FromArgb(byte.MaxValue, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorRGB15 v = (ColorRGB15)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);

			// Not influenced by alpha
			c = Color.FromArgb(0, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			v = (ColorRGB15)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
		}

#endif

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorRGB15.PixelType")]
		public void ColorRGB15_PixelType()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);

			ColorRGB15 v = new ColorRGB15(r, g, b);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorRGB15int]")]
		public void ColorRGB15_Accessor()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);

			ColorRGB15 v = new ColorRGB15(r, g, b);
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
	internal class ColorRGB16Test : ColorTestBase
	{
		#region Constructors

		[Test(Description = "Test ColorRGB16(byte, byte, byte)")]
		public void ColorRGB16_TestConstructor1()
		{
			byte r = (byte)byte.MaxValue;
			byte g = (byte)byte.MaxValue;
			byte b = (byte)byte.MaxValue;
			
			ColorRGB16 v = new ColorRGB16(r, g, b);

			Assert.AreEqual(r, v.Red);
			Assert.AreEqual(g, v.Green);
			Assert.AreEqual(b, v.Blue);
		}

		#endregion

		#region Cast Operators


#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorRGB16)Color")]
		public void ColorRGB16_CastFromColor()
		{
			const double Epsilon = 0.25;

			Random random = new Random();
			double r = NextComponent(random, 1.0);
			double g = NextComponent(random, 1.0);
			double b = NextComponent(random, 1.0);

			Color c = Color.FromArgb(byte.MaxValue, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorRGB16 v = (ColorRGB16)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);

			// Not influenced by alpha
			c = Color.FromArgb(0, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			v = (ColorRGB16)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
		}

#endif

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorRGB16.PixelType")]
		public void ColorRGB16_PixelType()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);

			ColorRGB16 v = new ColorRGB16(r, g, b);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorRGB16int]")]
		public void ColorRGB16_Accessor()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);

			ColorRGB16 v = new ColorRGB16(r, g, b);
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
	internal class ColorRGB24Test : ColorTestBase
	{
		#region Constructors

		[Test(Description = "Test ColorRGB24(byte, byte, byte)")]
		public void ColorRGB24_TestConstructor1()
		{
			byte r = (byte)byte.MaxValue;
			byte g = (byte)byte.MaxValue;
			byte b = (byte)byte.MaxValue;
			
			ColorRGB24 v = new ColorRGB24(r, g, b);

			Assert.AreEqual(r, v.Red);
			Assert.AreEqual(g, v.Green);
			Assert.AreEqual(b, v.Blue);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test (Vertex4ub)ColorRGB24")]
		public void ColorRGB24_CastToVertex4()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);
			
			ColorRGB24 v = new ColorRGB24(r, g, b);
			Vertex3ub vArray = v;

			Assert.AreEqual(r, vArray.x);
			Assert.AreEqual(g, vArray.y);
			Assert.AreEqual(b, vArray.z);
		}

#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorRGB24)Color")]
		public void ColorRGB24_CastFromColor()
		{
			const double Epsilon = 0.25;

			Random random = new Random();
			double r = NextComponent(random, 1.0);
			double g = NextComponent(random, 1.0);
			double b = NextComponent(random, 1.0);

			Color c = Color.FromArgb(byte.MaxValue, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorRGB24 v = (ColorRGB24)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);

			// Not influenced by alpha
			c = Color.FromArgb(0, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			v = (ColorRGB24)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
		}

#endif

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorRGB24.PixelType")]
		public void ColorRGB24_PixelType()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);

			ColorRGB24 v = new ColorRGB24(r, g, b);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorRGB24int]")]
		public void ColorRGB24_Accessor()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);

			ColorRGB24 v = new ColorRGB24(r, g, b);
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
	internal class ColorRGB48Test : ColorTestBase
	{
		#region Constructors

		[Test(Description = "Test ColorRGB48(ushort, ushort, ushort)")]
		public void ColorRGB48_TestConstructor1()
		{
			ushort r = (ushort)ushort.MaxValue;
			ushort g = (ushort)ushort.MaxValue;
			ushort b = (ushort)ushort.MaxValue;
			
			ColorRGB48 v = new ColorRGB48(r, g, b);

			Assert.AreEqual(r, v.Red);
			Assert.AreEqual(g, v.Green);
			Assert.AreEqual(b, v.Blue);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test (Vertex4ub)ColorRGB48")]
		public void ColorRGB48_CastToVertex4()
		{
			Random random = new Random();
			ushort r = (ushort)NextComponent(random, ushort.MaxValue);
			ushort g = (ushort)NextComponent(random, ushort.MaxValue);
			ushort b = (ushort)NextComponent(random, ushort.MaxValue);
			
			ColorRGB48 v = new ColorRGB48(r, g, b);
			Vertex3us vArray = v;

			Assert.AreEqual(r, vArray.x);
			Assert.AreEqual(g, vArray.y);
			Assert.AreEqual(b, vArray.z);
		}

#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorRGB48)Color")]
		public void ColorRGB48_CastFromColor()
		{
			const double Epsilon = 0.25;

			Random random = new Random();
			double r = NextComponent(random, 1.0);
			double g = NextComponent(random, 1.0);
			double b = NextComponent(random, 1.0);

			Color c = Color.FromArgb(byte.MaxValue, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorRGB48 v = (ColorRGB48)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);

			// Not influenced by alpha
			c = Color.FromArgb(0, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			v = (ColorRGB48)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
		}

#endif

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorRGB48.PixelType")]
		public void ColorRGB48_PixelType()
		{
			Random random = new Random();
			ushort r = (ushort)NextComponent(random, ushort.MaxValue);
			ushort g = (ushort)NextComponent(random, ushort.MaxValue);
			ushort b = (ushort)NextComponent(random, ushort.MaxValue);

			ColorRGB48 v = new ColorRGB48(r, g, b);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorRGB48int]")]
		public void ColorRGB48_Accessor()
		{
			Random random = new Random();
			ushort r = (ushort)NextComponent(random, ushort.MaxValue);
			ushort g = (ushort)NextComponent(random, ushort.MaxValue);
			ushort b = (ushort)NextComponent(random, ushort.MaxValue);

			ColorRGB48 v = new ColorRGB48(r, g, b);
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
	internal class ColorRGB96Test : ColorTestBase
	{
		#region Constructors

		[Test(Description = "Test ColorRGB96(uint, uint, uint)")]
		public void ColorRGB96_TestConstructor1()
		{
			uint r = (uint)uint.MaxValue;
			uint g = (uint)uint.MaxValue;
			uint b = (uint)uint.MaxValue;
			
			ColorRGB96 v = new ColorRGB96(r, g, b);

			Assert.AreEqual(r, v.Red);
			Assert.AreEqual(g, v.Green);
			Assert.AreEqual(b, v.Blue);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test (Vertex4ub)ColorRGB96")]
		public void ColorRGB96_CastToVertex4()
		{
			Random random = new Random();
			uint r = (uint)NextComponent(random, uint.MaxValue);
			uint g = (uint)NextComponent(random, uint.MaxValue);
			uint b = (uint)NextComponent(random, uint.MaxValue);
			
			ColorRGB96 v = new ColorRGB96(r, g, b);
			Vertex3ui vArray = v;

			Assert.AreEqual(r, vArray.x);
			Assert.AreEqual(g, vArray.y);
			Assert.AreEqual(b, vArray.z);
		}

#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorRGB96)Color")]
		public void ColorRGB96_CastFromColor()
		{
			const double Epsilon = 0.25;

			Random random = new Random();
			double r = NextComponent(random, 1.0);
			double g = NextComponent(random, 1.0);
			double b = NextComponent(random, 1.0);

			Color c = Color.FromArgb(byte.MaxValue, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorRGB96 v = (ColorRGB96)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);

			// Not influenced by alpha
			c = Color.FromArgb(0, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			v = (ColorRGB96)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
		}

#endif

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorRGB96.PixelType")]
		public void ColorRGB96_PixelType()
		{
			Random random = new Random();
			uint r = (uint)NextComponent(random, uint.MaxValue);
			uint g = (uint)NextComponent(random, uint.MaxValue);
			uint b = (uint)NextComponent(random, uint.MaxValue);

			ColorRGB96 v = new ColorRGB96(r, g, b);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorRGB96int]")]
		public void ColorRGB96_Accessor()
		{
			Random random = new Random();
			uint r = (uint)NextComponent(random, uint.MaxValue);
			uint g = (uint)NextComponent(random, uint.MaxValue);
			uint b = (uint)NextComponent(random, uint.MaxValue);

			ColorRGB96 v = new ColorRGB96(r, g, b);
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
	internal class ColorRGBFTest : ColorTestBase
	{
		#region Constructors

		[Test(Description = "Test ColorRGBF(float, float, float)")]
		public void ColorRGBF_TestConstructor1()
		{
			float r = (float)1.0f;
			float g = (float)1.0f;
			float b = (float)1.0f;
			
			ColorRGBF v = new ColorRGBF(r, g, b);

			Assert.AreEqual(r, v.Red);
			Assert.AreEqual(g, v.Green);
			Assert.AreEqual(b, v.Blue);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test (Vertex4ub)ColorRGBF")]
		public void ColorRGBF_CastToVertex4()
		{
			Random random = new Random();
			float r = (float)NextComponent(random, 1.0f);
			float g = (float)NextComponent(random, 1.0f);
			float b = (float)NextComponent(random, 1.0f);
			
			ColorRGBF v = new ColorRGBF(r, g, b);
			Vertex3f vArray = v;

			Assert.AreEqual(r, vArray.x);
			Assert.AreEqual(g, vArray.y);
			Assert.AreEqual(b, vArray.z);
		}

#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorRGBF)Color")]
		public void ColorRGBF_CastFromColor()
		{
			const double Epsilon = 0.25;

			Random random = new Random();
			double r = NextComponent(random, 1.0);
			double g = NextComponent(random, 1.0);
			double b = NextComponent(random, 1.0);

			Color c = Color.FromArgb(byte.MaxValue, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorRGBF v = (ColorRGBF)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);

			// Not influenced by alpha
			c = Color.FromArgb(0, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			v = (ColorRGBF)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
		}

#endif

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorRGBF.PixelType")]
		public void ColorRGBF_PixelType()
		{
			Random random = new Random();
			float r = (float)NextComponent(random, 1.0f);
			float g = (float)NextComponent(random, 1.0f);
			float b = (float)NextComponent(random, 1.0f);

			ColorRGBF v = new ColorRGBF(r, g, b);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorRGBFint]")]
		public void ColorRGBF_Accessor()
		{
			Random random = new Random();
			float r = (float)NextComponent(random, 1.0f);
			float g = (float)NextComponent(random, 1.0f);
			float b = (float)NextComponent(random, 1.0f);

			ColorRGBF v = new ColorRGBF(r, g, b);
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
	internal class ColorRGBDTest : ColorTestBase
	{
		#region Constructors

		[Test(Description = "Test ColorRGBD(double, double, double)")]
		public void ColorRGBD_TestConstructor1()
		{
			double r = (double)1.0;
			double g = (double)1.0;
			double b = (double)1.0;
			
			ColorRGBD v = new ColorRGBD(r, g, b);

			Assert.AreEqual(r, v.Red);
			Assert.AreEqual(g, v.Green);
			Assert.AreEqual(b, v.Blue);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test (Vertex4ub)ColorRGBD")]
		public void ColorRGBD_CastToVertex4()
		{
			Random random = new Random();
			double r = (double)NextComponent(random, 1.0);
			double g = (double)NextComponent(random, 1.0);
			double b = (double)NextComponent(random, 1.0);
			
			ColorRGBD v = new ColorRGBD(r, g, b);
			Vertex3d vArray = v;

			Assert.AreEqual(r, vArray.x);
			Assert.AreEqual(g, vArray.y);
			Assert.AreEqual(b, vArray.z);
		}

#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorRGBD)Color")]
		public void ColorRGBD_CastFromColor()
		{
			const double Epsilon = 0.25;

			Random random = new Random();
			double r = NextComponent(random, 1.0);
			double g = NextComponent(random, 1.0);
			double b = NextComponent(random, 1.0);

			Color c = Color.FromArgb(byte.MaxValue, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorRGBD v = (ColorRGBD)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);

			// Not influenced by alpha
			c = Color.FromArgb(0, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			v = (ColorRGBD)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
		}

#endif

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorRGBD.PixelType")]
		public void ColorRGBD_PixelType()
		{
			Random random = new Random();
			double r = (double)NextComponent(random, 1.0);
			double g = (double)NextComponent(random, 1.0);
			double b = (double)NextComponent(random, 1.0);

			ColorRGBD v = new ColorRGBD(r, g, b);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorRGBDint]")]
		public void ColorRGBD_Accessor()
		{
			Random random = new Random();
			double r = (double)NextComponent(random, 1.0);
			double g = (double)NextComponent(random, 1.0);
			double b = (double)NextComponent(random, 1.0);

			ColorRGBD v = new ColorRGBD(r, g, b);
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
	internal class ColorRGBHFTest : ColorTestBase
	{
		#region Constructors

		[Test(Description = "Test ColorRGBHF(HalfFloat, HalfFloat, HalfFloat)")]
		public void ColorRGBHF_TestConstructor1()
		{
			HalfFloat r = (HalfFloat)(HalfFloat)1.0f;
			HalfFloat g = (HalfFloat)(HalfFloat)1.0f;
			HalfFloat b = (HalfFloat)(HalfFloat)1.0f;
			
			ColorRGBHF v = new ColorRGBHF(r, g, b);

			Assert.AreEqual(r, v.Red);
			Assert.AreEqual(g, v.Green);
			Assert.AreEqual(b, v.Blue);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test (Vertex4ub)ColorRGBHF")]
		public void ColorRGBHF_CastToVertex4()
		{
			Random random = new Random();
			HalfFloat r = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat g = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat b = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			
			ColorRGBHF v = new ColorRGBHF(r, g, b);
			Vertex3hf vArray = v;

			Assert.AreEqual(r, vArray.x);
			Assert.AreEqual(g, vArray.y);
			Assert.AreEqual(b, vArray.z);
		}

#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorRGBHF)Color")]
		public void ColorRGBHF_CastFromColor()
		{
			const double Epsilon = 0.25;

			Random random = new Random();
			double r = NextComponent(random, 1.0);
			double g = NextComponent(random, 1.0);
			double b = NextComponent(random, 1.0);

			Color c = Color.FromArgb(byte.MaxValue, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorRGBHF v = (ColorRGBHF)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);

			// Not influenced by alpha
			c = Color.FromArgb(0, (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			v = (ColorRGBHF)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
		}

#endif

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorRGBHF.PixelType")]
		public void ColorRGBHF_PixelType()
		{
			Random random = new Random();
			HalfFloat r = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat g = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat b = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);

			ColorRGBHF v = new ColorRGBHF(r, g, b);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorRGBHFint]")]
		public void ColorRGBHF_Accessor()
		{
			Random random = new Random();
			HalfFloat r = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat g = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat b = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);

			ColorRGBHF v = new ColorRGBHF(r, g, b);
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