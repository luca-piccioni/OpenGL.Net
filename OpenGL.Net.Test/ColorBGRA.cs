
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
	internal class ColorBGRA32Test : ColorTestBase
	{
		#region Constructors

		[Test(Description = "Test ColorBGRA32(byte, byte, byte)")]
		public void ColorBGRA32_TestConstructor1()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);
			
			ColorBGRA32 v = new ColorBGRA32(r, g, b);

			Assert.AreEqual(r, v.r);
			Assert.AreEqual(g, v.g);
			Assert.AreEqual(b, v.b);
			Assert.AreEqual(byte.MaxValue, v.a);
		}

		[Test(Description = "Test ColorBGRA32(byte, byte, byte, byte)")]
		public void ColorBGRA32_TestConstructor2()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);
			byte a = (byte)NextComponent(random, byte.MaxValue);
			
			ColorBGRA32 v = new ColorBGRA32(r, g, b, a);

			Assert.AreEqual(r, v.r);
			Assert.AreEqual(g, v.g);
			Assert.AreEqual(b, v.b);
			Assert.AreEqual(a, v.a);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test (byte[])ColorBGRA32")]
		public void ColorBGRA32_CastToArray()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);
			byte a = (byte)NextComponent(random, byte.MaxValue);
			
			ColorBGRA32 v = new ColorBGRA32(r, g, b, a);
			byte[] vArray = v;

			Assert.AreEqual(4, vArray.Length);
			Assert.AreEqual(r, vArray[0]);
			Assert.AreEqual(g, vArray[1]);
			Assert.AreEqual(b, vArray[2]);
			Assert.AreEqual(a, vArray[3]);
		}

		[Test(Description = "Test (Vertex4ub)ColorBGRA32")]
		public void ColorBGRA32_CastToVertex4()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);
			byte a = (byte)NextComponent(random, byte.MaxValue);
			
			ColorBGRA32 v = new ColorBGRA32(r, g, b, a);
			Vertex4ub vArray = v;

			Assert.AreEqual(r, vArray.x);
			Assert.AreEqual(g, vArray.y);
			Assert.AreEqual(b, vArray.z);
			Assert.AreEqual(a, vArray.w);
		}

#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorBGRA32)Color")]
		public void ColorBGRA32_CastFromColor()
		{
			const double Epsilon = 1e-2;

			Random random = new Random();
			double r = NextComponent(random, 1.0);
			double g = NextComponent(random, 1.0);
			double b = NextComponent(random, 1.0);
			double a = NextComponent(random, 1.0);

			Color c = Color.FromArgb((int)(a * byte.MaxValue), (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorBGRA32 v = (ColorBGRA32)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
			Assert.AreEqual((float)a, v[3], Epsilon);
		}

#endif

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test ColorBGRA32.operator*")]
		public void ColorBGRA32_Multiply()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);
			byte a = (byte)NextComponent(random, byte.MaxValue);

			ColorBGRA32 v = new ColorBGRA32(r, g, b, a);
			ColorBGRA32 c = v * 0.5f;

			c = c * 2.0f;

			Assert.AreEqual(c.r, v.r, 1.0);
			Assert.AreEqual(c.g, v.g, 1.0);
			Assert.AreEqual(c.b, v.b, 1.0);
			Assert.AreEqual(c.a, v.a, 1.0);
		}

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorBGRA32.PixelType")]
		public void ColorBGRA32_PixelType()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);
			byte a = (byte)NextComponent(random, byte.MaxValue);

			ColorBGRA32 v = new ColorBGRA32(r, g, b, a);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorBGRA32int]")]
		public void ColorBGRA32_Accessor()
		{
			Random random = new Random();
			byte r = (byte)NextComponent(random, byte.MaxValue);
			byte g = (byte)NextComponent(random, byte.MaxValue);
			byte b = (byte)NextComponent(random, byte.MaxValue);
			byte a = (byte)NextComponent(random, byte.MaxValue);

			ColorBGRA32 v = new ColorBGRA32(r, g, b, a);
			float c;

			Assert.DoesNotThrow(() => c = v[0]);
			Assert.DoesNotThrow(() => c = v[1]);
			Assert.DoesNotThrow(() => c = v[2]);
			Assert.DoesNotThrow(() => c = v[3]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[+4]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[-1]);

			Assert.DoesNotThrow(() => v[0] = 1.0f);
			Assert.DoesNotThrow(() => v[1] = 1.0f);
			Assert.DoesNotThrow(() => v[2] = 1.0f);
			Assert.DoesNotThrow(() => v[3] = 1.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[+4] = 0.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[-1] = 0.0f);

			Assert.DoesNotThrow(() => v[3] = 0.0f);
			Assert.DoesNotThrow(() => v[3] = 1.0f);
			Assert.Throws<InvalidOperationException>(() => v[3] = -1.0f);
			Assert.Throws<InvalidOperationException>(() => v[3] = +1.1f);
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class ColorBGRA64Test : ColorTestBase
	{
		#region Constructors

		[Test(Description = "Test ColorBGRA64(ushort, ushort, ushort)")]
		public void ColorBGRA64_TestConstructor1()
		{
			Random random = new Random();
			ushort r = (ushort)NextComponent(random, ushort.MaxValue);
			ushort g = (ushort)NextComponent(random, ushort.MaxValue);
			ushort b = (ushort)NextComponent(random, ushort.MaxValue);
			
			ColorBGRA64 v = new ColorBGRA64(r, g, b);

			Assert.AreEqual(r, v.r);
			Assert.AreEqual(g, v.g);
			Assert.AreEqual(b, v.b);
			Assert.AreEqual(ushort.MaxValue, v.a);
		}

		[Test(Description = "Test ColorBGRA64(ushort, ushort, ushort, ushort)")]
		public void ColorBGRA64_TestConstructor2()
		{
			Random random = new Random();
			ushort r = (ushort)NextComponent(random, ushort.MaxValue);
			ushort g = (ushort)NextComponent(random, ushort.MaxValue);
			ushort b = (ushort)NextComponent(random, ushort.MaxValue);
			ushort a = (ushort)NextComponent(random, ushort.MaxValue);
			
			ColorBGRA64 v = new ColorBGRA64(r, g, b, a);

			Assert.AreEqual(r, v.r);
			Assert.AreEqual(g, v.g);
			Assert.AreEqual(b, v.b);
			Assert.AreEqual(a, v.a);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test (ushort[])ColorBGRA64")]
		public void ColorBGRA64_CastToArray()
		{
			Random random = new Random();
			ushort r = (ushort)NextComponent(random, ushort.MaxValue);
			ushort g = (ushort)NextComponent(random, ushort.MaxValue);
			ushort b = (ushort)NextComponent(random, ushort.MaxValue);
			ushort a = (ushort)NextComponent(random, ushort.MaxValue);
			
			ColorBGRA64 v = new ColorBGRA64(r, g, b, a);
			ushort[] vArray = v;

			Assert.AreEqual(4, vArray.Length);
			Assert.AreEqual(r, vArray[0]);
			Assert.AreEqual(g, vArray[1]);
			Assert.AreEqual(b, vArray[2]);
			Assert.AreEqual(a, vArray[3]);
		}

		[Test(Description = "Test (Vertex4ub)ColorBGRA64")]
		public void ColorBGRA64_CastToVertex4()
		{
			Random random = new Random();
			ushort r = (ushort)NextComponent(random, ushort.MaxValue);
			ushort g = (ushort)NextComponent(random, ushort.MaxValue);
			ushort b = (ushort)NextComponent(random, ushort.MaxValue);
			ushort a = (ushort)NextComponent(random, ushort.MaxValue);
			
			ColorBGRA64 v = new ColorBGRA64(r, g, b, a);
			Vertex4us vArray = v;

			Assert.AreEqual(r, vArray.x);
			Assert.AreEqual(g, vArray.y);
			Assert.AreEqual(b, vArray.z);
			Assert.AreEqual(a, vArray.w);
		}

#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorBGRA64)Color")]
		public void ColorBGRA64_CastFromColor()
		{
			const double Epsilon = 1e-2;

			Random random = new Random();
			double r = NextComponent(random, 1.0);
			double g = NextComponent(random, 1.0);
			double b = NextComponent(random, 1.0);
			double a = NextComponent(random, 1.0);

			Color c = Color.FromArgb((int)(a * byte.MaxValue), (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorBGRA64 v = (ColorBGRA64)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
			Assert.AreEqual((float)a, v[3], Epsilon);
		}

#endif

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test ColorBGRA64.operator*")]
		public void ColorBGRA64_Multiply()
		{
			Random random = new Random();
			ushort r = (ushort)NextComponent(random, ushort.MaxValue);
			ushort g = (ushort)NextComponent(random, ushort.MaxValue);
			ushort b = (ushort)NextComponent(random, ushort.MaxValue);
			ushort a = (ushort)NextComponent(random, ushort.MaxValue);

			ColorBGRA64 v = new ColorBGRA64(r, g, b, a);
			ColorBGRA64 c = v * 0.5f;

			c = c * 2.0f;

			Assert.AreEqual(c.r, v.r, 1.0);
			Assert.AreEqual(c.g, v.g, 1.0);
			Assert.AreEqual(c.b, v.b, 1.0);
			Assert.AreEqual(c.a, v.a, 1.0);
		}

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorBGRA64.PixelType")]
		public void ColorBGRA64_PixelType()
		{
			Random random = new Random();
			ushort r = (ushort)NextComponent(random, ushort.MaxValue);
			ushort g = (ushort)NextComponent(random, ushort.MaxValue);
			ushort b = (ushort)NextComponent(random, ushort.MaxValue);
			ushort a = (ushort)NextComponent(random, ushort.MaxValue);

			ColorBGRA64 v = new ColorBGRA64(r, g, b, a);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorBGRA64int]")]
		public void ColorBGRA64_Accessor()
		{
			Random random = new Random();
			ushort r = (ushort)NextComponent(random, ushort.MaxValue);
			ushort g = (ushort)NextComponent(random, ushort.MaxValue);
			ushort b = (ushort)NextComponent(random, ushort.MaxValue);
			ushort a = (ushort)NextComponent(random, ushort.MaxValue);

			ColorBGRA64 v = new ColorBGRA64(r, g, b, a);
			float c;

			Assert.DoesNotThrow(() => c = v[0]);
			Assert.DoesNotThrow(() => c = v[1]);
			Assert.DoesNotThrow(() => c = v[2]);
			Assert.DoesNotThrow(() => c = v[3]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[+4]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[-1]);

			Assert.DoesNotThrow(() => v[0] = 1.0f);
			Assert.DoesNotThrow(() => v[1] = 1.0f);
			Assert.DoesNotThrow(() => v[2] = 1.0f);
			Assert.DoesNotThrow(() => v[3] = 1.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[+4] = 0.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[-1] = 0.0f);

			Assert.DoesNotThrow(() => v[3] = 0.0f);
			Assert.DoesNotThrow(() => v[3] = 1.0f);
			Assert.Throws<InvalidOperationException>(() => v[3] = -1.0f);
			Assert.Throws<InvalidOperationException>(() => v[3] = +1.1f);
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class ColorBGRAFTest : ColorTestBase
	{
		#region Constructors

		[Test(Description = "Test ColorBGRAF(float, float, float)")]
		public void ColorBGRAF_TestConstructor1()
		{
			Random random = new Random();
			float r = (float)NextComponent(random, 1.0f);
			float g = (float)NextComponent(random, 1.0f);
			float b = (float)NextComponent(random, 1.0f);
			
			ColorBGRAF v = new ColorBGRAF(r, g, b);

			Assert.AreEqual(r, v.r);
			Assert.AreEqual(g, v.g);
			Assert.AreEqual(b, v.b);
			Assert.AreEqual(1.0f, v.a);
		}

		[Test(Description = "Test ColorBGRAF(float, float, float, float)")]
		public void ColorBGRAF_TestConstructor2()
		{
			Random random = new Random();
			float r = (float)NextComponent(random, 1.0f);
			float g = (float)NextComponent(random, 1.0f);
			float b = (float)NextComponent(random, 1.0f);
			float a = (float)NextComponent(random, 1.0f);
			
			ColorBGRAF v = new ColorBGRAF(r, g, b, a);

			Assert.AreEqual(r, v.r);
			Assert.AreEqual(g, v.g);
			Assert.AreEqual(b, v.b);
			Assert.AreEqual(a, v.a);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test (float[])ColorBGRAF")]
		public void ColorBGRAF_CastToArray()
		{
			Random random = new Random();
			float r = (float)NextComponent(random, 1.0f);
			float g = (float)NextComponent(random, 1.0f);
			float b = (float)NextComponent(random, 1.0f);
			float a = (float)NextComponent(random, 1.0f);
			
			ColorBGRAF v = new ColorBGRAF(r, g, b, a);
			float[] vArray = v;

			Assert.AreEqual(4, vArray.Length);
			Assert.AreEqual(r, vArray[0]);
			Assert.AreEqual(g, vArray[1]);
			Assert.AreEqual(b, vArray[2]);
			Assert.AreEqual(a, vArray[3]);
		}

		[Test(Description = "Test (Vertex4ub)ColorBGRAF")]
		public void ColorBGRAF_CastToVertex4()
		{
			Random random = new Random();
			float r = (float)NextComponent(random, 1.0f);
			float g = (float)NextComponent(random, 1.0f);
			float b = (float)NextComponent(random, 1.0f);
			float a = (float)NextComponent(random, 1.0f);
			
			ColorBGRAF v = new ColorBGRAF(r, g, b, a);
			Vertex4f vArray = v;

			Assert.AreEqual(r, vArray.x);
			Assert.AreEqual(g, vArray.y);
			Assert.AreEqual(b, vArray.z);
			Assert.AreEqual(a, vArray.w);
		}

#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorBGRAF)Color")]
		public void ColorBGRAF_CastFromColor()
		{
			const double Epsilon = 1e-2;

			Random random = new Random();
			double r = NextComponent(random, 1.0);
			double g = NextComponent(random, 1.0);
			double b = NextComponent(random, 1.0);
			double a = NextComponent(random, 1.0);

			Color c = Color.FromArgb((int)(a * byte.MaxValue), (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorBGRAF v = (ColorBGRAF)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
			Assert.AreEqual((float)a, v[3], Epsilon);
		}

#endif

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test ColorBGRAF.operator*")]
		public void ColorBGRAF_Multiply()
		{
			Random random = new Random();
			float r = (float)NextComponent(random, 1.0f);
			float g = (float)NextComponent(random, 1.0f);
			float b = (float)NextComponent(random, 1.0f);
			float a = (float)NextComponent(random, 1.0f);

			ColorBGRAF v = new ColorBGRAF(r, g, b, a);
			ColorBGRAF c = v * 0.5f;

			c = c * 2.0f;

			Assert.AreEqual(c.r, v.r, 1.0);
			Assert.AreEqual(c.g, v.g, 1.0);
			Assert.AreEqual(c.b, v.b, 1.0);
			Assert.AreEqual(c.a, v.a, 1.0);
		}

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorBGRAF.PixelType")]
		public void ColorBGRAF_PixelType()
		{
			Random random = new Random();
			float r = (float)NextComponent(random, 1.0f);
			float g = (float)NextComponent(random, 1.0f);
			float b = (float)NextComponent(random, 1.0f);
			float a = (float)NextComponent(random, 1.0f);

			ColorBGRAF v = new ColorBGRAF(r, g, b, a);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorBGRAFint]")]
		public void ColorBGRAF_Accessor()
		{
			Random random = new Random();
			float r = (float)NextComponent(random, 1.0f);
			float g = (float)NextComponent(random, 1.0f);
			float b = (float)NextComponent(random, 1.0f);
			float a = (float)NextComponent(random, 1.0f);

			ColorBGRAF v = new ColorBGRAF(r, g, b, a);
			float c;

			Assert.DoesNotThrow(() => c = v[0]);
			Assert.DoesNotThrow(() => c = v[1]);
			Assert.DoesNotThrow(() => c = v[2]);
			Assert.DoesNotThrow(() => c = v[3]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[+4]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[-1]);

			Assert.DoesNotThrow(() => v[0] = 1.0f);
			Assert.DoesNotThrow(() => v[1] = 1.0f);
			Assert.DoesNotThrow(() => v[2] = 1.0f);
			Assert.DoesNotThrow(() => v[3] = 1.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[+4] = 0.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[-1] = 0.0f);

			Assert.DoesNotThrow(() => v[3] = 0.0f);
			Assert.DoesNotThrow(() => v[3] = 1.0f);
			Assert.Throws<InvalidOperationException>(() => v[3] = -1.0f);
			Assert.Throws<InvalidOperationException>(() => v[3] = +1.1f);
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class ColorBGRAHFTest : ColorTestBase
	{
		#region Constructors

		[Test(Description = "Test ColorBGRAHF(HalfFloat, HalfFloat, HalfFloat)")]
		public void ColorBGRAHF_TestConstructor1()
		{
			Random random = new Random();
			HalfFloat r = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat g = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat b = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			
			ColorBGRAHF v = new ColorBGRAHF(r, g, b);

			Assert.AreEqual(r, v.r);
			Assert.AreEqual(g, v.g);
			Assert.AreEqual(b, v.b);
			Assert.AreEqual((HalfFloat)1.0f, v.a);
		}

		[Test(Description = "Test ColorBGRAHF(HalfFloat, HalfFloat, HalfFloat, HalfFloat)")]
		public void ColorBGRAHF_TestConstructor2()
		{
			Random random = new Random();
			HalfFloat r = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat g = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat b = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat a = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			
			ColorBGRAHF v = new ColorBGRAHF(r, g, b, a);

			Assert.AreEqual(r, v.r);
			Assert.AreEqual(g, v.g);
			Assert.AreEqual(b, v.b);
			Assert.AreEqual(a, v.a);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test (HalfFloat[])ColorBGRAHF")]
		public void ColorBGRAHF_CastToArray()
		{
			Random random = new Random();
			HalfFloat r = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat g = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat b = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat a = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			
			ColorBGRAHF v = new ColorBGRAHF(r, g, b, a);
			HalfFloat[] vArray = v;

			Assert.AreEqual(4, vArray.Length);
			Assert.AreEqual(r, vArray[0]);
			Assert.AreEqual(g, vArray[1]);
			Assert.AreEqual(b, vArray[2]);
			Assert.AreEqual(a, vArray[3]);
		}

		[Test(Description = "Test (Vertex4ub)ColorBGRAHF")]
		public void ColorBGRAHF_CastToVertex4()
		{
			Random random = new Random();
			HalfFloat r = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat g = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat b = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat a = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			
			ColorBGRAHF v = new ColorBGRAHF(r, g, b, a);
			Vertex4hf vArray = v;

			Assert.AreEqual(r, vArray.x);
			Assert.AreEqual(g, vArray.y);
			Assert.AreEqual(b, vArray.z);
			Assert.AreEqual(a, vArray.w);
		}

#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorBGRAHF)Color")]
		public void ColorBGRAHF_CastFromColor()
		{
			const double Epsilon = 1e-2;

			Random random = new Random();
			double r = NextComponent(random, 1.0);
			double g = NextComponent(random, 1.0);
			double b = NextComponent(random, 1.0);
			double a = NextComponent(random, 1.0);

			Color c = Color.FromArgb((int)(a * byte.MaxValue), (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorBGRAHF v = (ColorBGRAHF)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
			Assert.AreEqual((float)a, v[3], Epsilon);
		}

#endif

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test ColorBGRAHF.operator*")]
		public void ColorBGRAHF_Multiply()
		{
			Random random = new Random();
			HalfFloat r = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat g = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat b = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat a = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);

			ColorBGRAHF v = new ColorBGRAHF(r, g, b, a);
			ColorBGRAHF c = v * 0.5f;

			c = c * 2.0f;

			Assert.AreEqual(c.r, v.r, 1.0);
			Assert.AreEqual(c.g, v.g, 1.0);
			Assert.AreEqual(c.b, v.b, 1.0);
			Assert.AreEqual(c.a, v.a, 1.0);
		}

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorBGRAHF.PixelType")]
		public void ColorBGRAHF_PixelType()
		{
			Random random = new Random();
			HalfFloat r = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat g = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat b = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat a = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);

			ColorBGRAHF v = new ColorBGRAHF(r, g, b, a);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorBGRAHFint]")]
		public void ColorBGRAHF_Accessor()
		{
			Random random = new Random();
			HalfFloat r = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat g = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat b = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);
			HalfFloat a = (HalfFloat)NextComponent(random, (HalfFloat)1.0f);

			ColorBGRAHF v = new ColorBGRAHF(r, g, b, a);
			float c;

			Assert.DoesNotThrow(() => c = v[0]);
			Assert.DoesNotThrow(() => c = v[1]);
			Assert.DoesNotThrow(() => c = v[2]);
			Assert.DoesNotThrow(() => c = v[3]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[+4]);
			Assert.Throws<IndexOutOfRangeException>(() => c = v[-1]);

			Assert.DoesNotThrow(() => v[0] = 1.0f);
			Assert.DoesNotThrow(() => v[1] = 1.0f);
			Assert.DoesNotThrow(() => v[2] = 1.0f);
			Assert.DoesNotThrow(() => v[3] = 1.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[+4] = 0.0f);
			Assert.Throws<IndexOutOfRangeException>(() => v[-1] = 0.0f);

			Assert.DoesNotThrow(() => v[3] = 0.0f);
			Assert.DoesNotThrow(() => v[3] = 1.0f);
			Assert.Throws<InvalidOperationException>(() => v[3] = -1.0f);
			Assert.Throws<InvalidOperationException>(() => v[3] = +1.1f);
		}

		#endregion
	}

}