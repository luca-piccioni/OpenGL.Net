
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
	internal class ColorRGBA32Test : TestBase
	{
		#region Constructors

		[Test(Description = "Test ColorRGBA32(byte, byte, byte)")]
		public void ColorRGBA32_TestConstructor1()
		{
			byte r = (byte)NextComponent(byte.MaxValue);
			byte g = (byte)NextComponent(byte.MaxValue);
			byte b = (byte)NextComponent(byte.MaxValue);
			
			ColorRGBA32 v = new ColorRGBA32(r, g, b);

			Assert.AreEqual(r, v.r);
			Assert.AreEqual(g, v.g);
			Assert.AreEqual(b, v.b);
			Assert.AreEqual(byte.MaxValue, v.a);
		}

		[Test(Description = "Test ColorRGBA32(byte, byte, byte, byte)")]
		public void ColorRGBA32_TestConstructor2()
		{
			byte r = (byte)NextComponent(byte.MaxValue);
			byte g = (byte)NextComponent(byte.MaxValue);
			byte b = (byte)NextComponent(byte.MaxValue);
			byte a = (byte)NextComponent(byte.MaxValue);
			
			ColorRGBA32 v = new ColorRGBA32(r, g, b, a);

			Assert.AreEqual(r, v.r);
			Assert.AreEqual(g, v.g);
			Assert.AreEqual(b, v.b);
			Assert.AreEqual(a, v.a);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test (byte[])ColorRGBA32")]
		public void ColorRGBA32_CastToArray()
		{
			byte r = (byte)NextComponent(byte.MaxValue);
			byte g = (byte)NextComponent(byte.MaxValue);
			byte b = (byte)NextComponent(byte.MaxValue);
			byte a = (byte)NextComponent(byte.MaxValue);
			
			ColorRGBA32 v = new ColorRGBA32(r, g, b, a);
			byte[] vArray = v;

			Assert.AreEqual(4, vArray.Length);
			Assert.AreEqual(r, vArray[0]);
			Assert.AreEqual(g, vArray[1]);
			Assert.AreEqual(b, vArray[2]);
			Assert.AreEqual(a, vArray[3]);
		}

		[Test(Description = "Test (Vertex4ub)ColorRGBA32")]
		public void ColorRGBA32_CastToVertex4()
		{
			byte r = (byte)NextComponent(byte.MaxValue);
			byte g = (byte)NextComponent(byte.MaxValue);
			byte b = (byte)NextComponent(byte.MaxValue);
			byte a = (byte)NextComponent(byte.MaxValue);
			
			ColorRGBA32 v = new ColorRGBA32(r, g, b, a);
			Vertex4ub vArray = v;

			Assert.AreEqual(r, vArray.x);
			Assert.AreEqual(g, vArray.y);
			Assert.AreEqual(b, vArray.z);
			Assert.AreEqual(a, vArray.w);
		}

#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorRGBA32)Color")]
		public void ColorRGBA32_CastFromColor()
		{
			const double Epsilon = 1e-2;

			double r = NextComponent(1.0);
			double g = NextComponent(1.0);
			double b = NextComponent(1.0);
			double a = NextComponent(1.0);

			Color c = Color.FromArgb((int)(a * byte.MaxValue), (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorRGBA32 v = (ColorRGBA32)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
			Assert.AreEqual((float)a, v[3], Epsilon);
		}

#endif

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test ColorRGBA32.operator*")]
		public void ColorRGBA32_Multiply()
		{
			byte r = (byte)NextComponent(byte.MaxValue);
			byte g = (byte)NextComponent(byte.MaxValue);
			byte b = (byte)NextComponent(byte.MaxValue);
			byte a = (byte)NextComponent(byte.MaxValue);

			ColorRGBA32 v = new ColorRGBA32(r, g, b, a);
			ColorRGBA32 c = v * 0.5f;

			c = c * 2.0f;

			Assert.AreEqual(c.r, v.r, 1.0);
			Assert.AreEqual(c.g, v.g, 1.0);
			Assert.AreEqual(c.b, v.b, 1.0);
			Assert.AreEqual(c.a, v.a, 1.0);
		}

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorRGBA32.PixelType")]
		public void ColorRGBA32_PixelType()
		{
			byte r = (byte)NextComponent(byte.MaxValue);
			byte g = (byte)NextComponent(byte.MaxValue);
			byte b = (byte)NextComponent(byte.MaxValue);
			byte a = (byte)NextComponent(byte.MaxValue);

			ColorRGBA32 v = new ColorRGBA32(r, g, b, a);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorRGBA32int]")]
		public void ColorRGBA32_Accessor()
		{
			byte r = (byte)NextComponent(byte.MaxValue);
			byte g = (byte)NextComponent(byte.MaxValue);
			byte b = (byte)NextComponent(byte.MaxValue);
			byte a = (byte)NextComponent(byte.MaxValue);

			ColorRGBA32 v = new ColorRGBA32(r, g, b, a);
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
	internal class ColorRGBA64Test : TestBase
	{
		#region Constructors

		[Test(Description = "Test ColorRGBA64(ushort, ushort, ushort)")]
		public void ColorRGBA64_TestConstructor1()
		{
			ushort r = (ushort)NextComponent(ushort.MaxValue);
			ushort g = (ushort)NextComponent(ushort.MaxValue);
			ushort b = (ushort)NextComponent(ushort.MaxValue);
			
			ColorRGBA64 v = new ColorRGBA64(r, g, b);

			Assert.AreEqual(r, v.r);
			Assert.AreEqual(g, v.g);
			Assert.AreEqual(b, v.b);
			Assert.AreEqual(ushort.MaxValue, v.a);
		}

		[Test(Description = "Test ColorRGBA64(ushort, ushort, ushort, ushort)")]
		public void ColorRGBA64_TestConstructor2()
		{
			ushort r = (ushort)NextComponent(ushort.MaxValue);
			ushort g = (ushort)NextComponent(ushort.MaxValue);
			ushort b = (ushort)NextComponent(ushort.MaxValue);
			ushort a = (ushort)NextComponent(ushort.MaxValue);
			
			ColorRGBA64 v = new ColorRGBA64(r, g, b, a);

			Assert.AreEqual(r, v.r);
			Assert.AreEqual(g, v.g);
			Assert.AreEqual(b, v.b);
			Assert.AreEqual(a, v.a);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test (ushort[])ColorRGBA64")]
		public void ColorRGBA64_CastToArray()
		{
			ushort r = (ushort)NextComponent(ushort.MaxValue);
			ushort g = (ushort)NextComponent(ushort.MaxValue);
			ushort b = (ushort)NextComponent(ushort.MaxValue);
			ushort a = (ushort)NextComponent(ushort.MaxValue);
			
			ColorRGBA64 v = new ColorRGBA64(r, g, b, a);
			ushort[] vArray = v;

			Assert.AreEqual(4, vArray.Length);
			Assert.AreEqual(r, vArray[0]);
			Assert.AreEqual(g, vArray[1]);
			Assert.AreEqual(b, vArray[2]);
			Assert.AreEqual(a, vArray[3]);
		}

		[Test(Description = "Test (Vertex4ub)ColorRGBA64")]
		public void ColorRGBA64_CastToVertex4()
		{
			ushort r = (ushort)NextComponent(ushort.MaxValue);
			ushort g = (ushort)NextComponent(ushort.MaxValue);
			ushort b = (ushort)NextComponent(ushort.MaxValue);
			ushort a = (ushort)NextComponent(ushort.MaxValue);
			
			ColorRGBA64 v = new ColorRGBA64(r, g, b, a);
			Vertex4us vArray = v;

			Assert.AreEqual(r, vArray.x);
			Assert.AreEqual(g, vArray.y);
			Assert.AreEqual(b, vArray.z);
			Assert.AreEqual(a, vArray.w);
		}

#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorRGBA64)Color")]
		public void ColorRGBA64_CastFromColor()
		{
			const double Epsilon = 1e-2;

			double r = NextComponent(1.0);
			double g = NextComponent(1.0);
			double b = NextComponent(1.0);
			double a = NextComponent(1.0);

			Color c = Color.FromArgb((int)(a * byte.MaxValue), (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorRGBA64 v = (ColorRGBA64)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
			Assert.AreEqual((float)a, v[3], Epsilon);
		}

#endif

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test ColorRGBA64.operator*")]
		public void ColorRGBA64_Multiply()
		{
			ushort r = (ushort)NextComponent(ushort.MaxValue);
			ushort g = (ushort)NextComponent(ushort.MaxValue);
			ushort b = (ushort)NextComponent(ushort.MaxValue);
			ushort a = (ushort)NextComponent(ushort.MaxValue);

			ColorRGBA64 v = new ColorRGBA64(r, g, b, a);
			ColorRGBA64 c = v * 0.5f;

			c = c * 2.0f;

			Assert.AreEqual(c.r, v.r, 1.0);
			Assert.AreEqual(c.g, v.g, 1.0);
			Assert.AreEqual(c.b, v.b, 1.0);
			Assert.AreEqual(c.a, v.a, 1.0);
		}

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorRGBA64.PixelType")]
		public void ColorRGBA64_PixelType()
		{
			ushort r = (ushort)NextComponent(ushort.MaxValue);
			ushort g = (ushort)NextComponent(ushort.MaxValue);
			ushort b = (ushort)NextComponent(ushort.MaxValue);
			ushort a = (ushort)NextComponent(ushort.MaxValue);

			ColorRGBA64 v = new ColorRGBA64(r, g, b, a);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorRGBA64int]")]
		public void ColorRGBA64_Accessor()
		{
			ushort r = (ushort)NextComponent(ushort.MaxValue);
			ushort g = (ushort)NextComponent(ushort.MaxValue);
			ushort b = (ushort)NextComponent(ushort.MaxValue);
			ushort a = (ushort)NextComponent(ushort.MaxValue);

			ColorRGBA64 v = new ColorRGBA64(r, g, b, a);
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
	internal class ColorRGBAFTest : TestBase
	{
		#region Constructors

		[Test(Description = "Test ColorRGBAF(float, float, float)")]
		public void ColorRGBAF_TestConstructor1()
		{
			float r = (float)NextComponent(1.0f);
			float g = (float)NextComponent(1.0f);
			float b = (float)NextComponent(1.0f);
			
			ColorRGBAF v = new ColorRGBAF(r, g, b);

			Assert.AreEqual(r, v.r);
			Assert.AreEqual(g, v.g);
			Assert.AreEqual(b, v.b);
			Assert.AreEqual(1.0f, v.a);
		}

		[Test(Description = "Test ColorRGBAF(float, float, float, float)")]
		public void ColorRGBAF_TestConstructor2()
		{
			float r = (float)NextComponent(1.0f);
			float g = (float)NextComponent(1.0f);
			float b = (float)NextComponent(1.0f);
			float a = (float)NextComponent(1.0f);
			
			ColorRGBAF v = new ColorRGBAF(r, g, b, a);

			Assert.AreEqual(r, v.r);
			Assert.AreEqual(g, v.g);
			Assert.AreEqual(b, v.b);
			Assert.AreEqual(a, v.a);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test (float[])ColorRGBAF")]
		public void ColorRGBAF_CastToArray()
		{
			float r = (float)NextComponent(1.0f);
			float g = (float)NextComponent(1.0f);
			float b = (float)NextComponent(1.0f);
			float a = (float)NextComponent(1.0f);
			
			ColorRGBAF v = new ColorRGBAF(r, g, b, a);
			float[] vArray = v;

			Assert.AreEqual(4, vArray.Length);
			Assert.AreEqual(r, vArray[0]);
			Assert.AreEqual(g, vArray[1]);
			Assert.AreEqual(b, vArray[2]);
			Assert.AreEqual(a, vArray[3]);
		}

		[Test(Description = "Test (Vertex4ub)ColorRGBAF")]
		public void ColorRGBAF_CastToVertex4()
		{
			float r = (float)NextComponent(1.0f);
			float g = (float)NextComponent(1.0f);
			float b = (float)NextComponent(1.0f);
			float a = (float)NextComponent(1.0f);
			
			ColorRGBAF v = new ColorRGBAF(r, g, b, a);
			Vertex4f vArray = v;

			Assert.AreEqual(r, vArray.x);
			Assert.AreEqual(g, vArray.y);
			Assert.AreEqual(b, vArray.z);
			Assert.AreEqual(a, vArray.w);
		}

#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorRGBAF)Color")]
		public void ColorRGBAF_CastFromColor()
		{
			const double Epsilon = 1e-2;

			double r = NextComponent(1.0);
			double g = NextComponent(1.0);
			double b = NextComponent(1.0);
			double a = NextComponent(1.0);

			Color c = Color.FromArgb((int)(a * byte.MaxValue), (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorRGBAF v = (ColorRGBAF)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
			Assert.AreEqual((float)a, v[3], Epsilon);
		}

#endif

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test ColorRGBAF.operator*")]
		public void ColorRGBAF_Multiply()
		{
			float r = (float)NextComponent(1.0f);
			float g = (float)NextComponent(1.0f);
			float b = (float)NextComponent(1.0f);
			float a = (float)NextComponent(1.0f);

			ColorRGBAF v = new ColorRGBAF(r, g, b, a);
			ColorRGBAF c = v * 0.5f;

			c = c * 2.0f;

			Assert.AreEqual(c.r, v.r, 1.0);
			Assert.AreEqual(c.g, v.g, 1.0);
			Assert.AreEqual(c.b, v.b, 1.0);
			Assert.AreEqual(c.a, v.a, 1.0);
		}

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorRGBAF.PixelType")]
		public void ColorRGBAF_PixelType()
		{
			float r = (float)NextComponent(1.0f);
			float g = (float)NextComponent(1.0f);
			float b = (float)NextComponent(1.0f);
			float a = (float)NextComponent(1.0f);

			ColorRGBAF v = new ColorRGBAF(r, g, b, a);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorRGBAFint]")]
		public void ColorRGBAF_Accessor()
		{
			float r = (float)NextComponent(1.0f);
			float g = (float)NextComponent(1.0f);
			float b = (float)NextComponent(1.0f);
			float a = (float)NextComponent(1.0f);

			ColorRGBAF v = new ColorRGBAF(r, g, b, a);
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
	internal class ColorRGBAHFTest : TestBase
	{
		#region Constructors

		[Test(Description = "Test ColorRGBAHF(HalfFloat, HalfFloat, HalfFloat)")]
		public void ColorRGBAHF_TestConstructor1()
		{
			HalfFloat r = (HalfFloat)NextComponent((HalfFloat)1.0f);
			HalfFloat g = (HalfFloat)NextComponent((HalfFloat)1.0f);
			HalfFloat b = (HalfFloat)NextComponent((HalfFloat)1.0f);
			
			ColorRGBAHF v = new ColorRGBAHF(r, g, b);

			Assert.AreEqual(r, v.r);
			Assert.AreEqual(g, v.g);
			Assert.AreEqual(b, v.b);
			Assert.AreEqual((HalfFloat)1.0f, v.a);
		}

		[Test(Description = "Test ColorRGBAHF(HalfFloat, HalfFloat, HalfFloat, HalfFloat)")]
		public void ColorRGBAHF_TestConstructor2()
		{
			HalfFloat r = (HalfFloat)NextComponent((HalfFloat)1.0f);
			HalfFloat g = (HalfFloat)NextComponent((HalfFloat)1.0f);
			HalfFloat b = (HalfFloat)NextComponent((HalfFloat)1.0f);
			HalfFloat a = (HalfFloat)NextComponent((HalfFloat)1.0f);
			
			ColorRGBAHF v = new ColorRGBAHF(r, g, b, a);

			Assert.AreEqual(r, v.r);
			Assert.AreEqual(g, v.g);
			Assert.AreEqual(b, v.b);
			Assert.AreEqual(a, v.a);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test (HalfFloat[])ColorRGBAHF")]
		public void ColorRGBAHF_CastToArray()
		{
			HalfFloat r = (HalfFloat)NextComponent((HalfFloat)1.0f);
			HalfFloat g = (HalfFloat)NextComponent((HalfFloat)1.0f);
			HalfFloat b = (HalfFloat)NextComponent((HalfFloat)1.0f);
			HalfFloat a = (HalfFloat)NextComponent((HalfFloat)1.0f);
			
			ColorRGBAHF v = new ColorRGBAHF(r, g, b, a);
			HalfFloat[] vArray = v;

			Assert.AreEqual(4, vArray.Length);
			Assert.AreEqual(r, vArray[0]);
			Assert.AreEqual(g, vArray[1]);
			Assert.AreEqual(b, vArray[2]);
			Assert.AreEqual(a, vArray[3]);
		}

		[Test(Description = "Test (Vertex4ub)ColorRGBAHF")]
		public void ColorRGBAHF_CastToVertex4()
		{
			HalfFloat r = (HalfFloat)NextComponent((HalfFloat)1.0f);
			HalfFloat g = (HalfFloat)NextComponent((HalfFloat)1.0f);
			HalfFloat b = (HalfFloat)NextComponent((HalfFloat)1.0f);
			HalfFloat a = (HalfFloat)NextComponent((HalfFloat)1.0f);
			
			ColorRGBAHF v = new ColorRGBAHF(r, g, b, a);
			Vertex4hf vArray = v;

			Assert.AreEqual(r, vArray.x);
			Assert.AreEqual(g, vArray.y);
			Assert.AreEqual(b, vArray.z);
			Assert.AreEqual(a, vArray.w);
		}

#if HAVE_SYSTEM_DRAWING

		[Test(Description = "Test (ColorRGBAHF)Color")]
		public void ColorRGBAHF_CastFromColor()
		{
			const double Epsilon = 1e-2;

			double r = NextComponent(1.0);
			double g = NextComponent(1.0);
			double b = NextComponent(1.0);
			double a = NextComponent(1.0);

			Color c = Color.FromArgb((int)(a * byte.MaxValue), (int)(r * byte.MaxValue), (int)(g * byte.MaxValue), (int)(b * byte.MaxValue));
			
			ColorRGBAHF v = (ColorRGBAHF)c;

			Assert.AreEqual((float)r, v[0], Epsilon);
			Assert.AreEqual((float)g, v[1], Epsilon);
			Assert.AreEqual((float)b, v[2], Epsilon);
			Assert.AreEqual((float)a, v[3], Epsilon);
		}

#endif

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test ColorRGBAHF.operator*")]
		public void ColorRGBAHF_Multiply()
		{
			HalfFloat r = (HalfFloat)NextComponent((HalfFloat)1.0f);
			HalfFloat g = (HalfFloat)NextComponent((HalfFloat)1.0f);
			HalfFloat b = (HalfFloat)NextComponent((HalfFloat)1.0f);
			HalfFloat a = (HalfFloat)NextComponent((HalfFloat)1.0f);

			ColorRGBAHF v = new ColorRGBAHF(r, g, b, a);
			ColorRGBAHF c = v * 0.5f;

			c = c * 2.0f;

			Assert.AreEqual(c.r, v.r, 1.0);
			Assert.AreEqual(c.g, v.g, 1.0);
			Assert.AreEqual(c.b, v.b, 1.0);
			Assert.AreEqual(c.a, v.a, 1.0);
		}

		#endregion

		#region IColor Implementation

		[Test(Description = "Test ColorRGBAHF.PixelType")]
		public void ColorRGBAHF_PixelType()
		{
			HalfFloat r = (HalfFloat)NextComponent((HalfFloat)1.0f);
			HalfFloat g = (HalfFloat)NextComponent((HalfFloat)1.0f);
			HalfFloat b = (HalfFloat)NextComponent((HalfFloat)1.0f);
			HalfFloat a = (HalfFloat)NextComponent((HalfFloat)1.0f);

			ColorRGBAHF v = new ColorRGBAHF(r, g, b, a);

			Assert.AreNotEqual(PixelLayout.None, v.PixelType);
		}

		[Test(Description = "Test ColorRGBAHFint]")]
		public void ColorRGBAHF_Accessor()
		{
			HalfFloat r = (HalfFloat)NextComponent((HalfFloat)1.0f);
			HalfFloat g = (HalfFloat)NextComponent((HalfFloat)1.0f);
			HalfFloat b = (HalfFloat)NextComponent((HalfFloat)1.0f);
			HalfFloat a = (HalfFloat)NextComponent((HalfFloat)1.0f);

			ColorRGBAHF v = new ColorRGBAHF(r, g, b, a);
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