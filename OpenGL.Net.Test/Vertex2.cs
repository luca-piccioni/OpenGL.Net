
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
using System.Diagnostics;
using System.Runtime.InteropServices;

using NUnit.Framework;

#if HAVE_NUMERICS
using System.Numerics;
#endif

namespace OpenGL.Test
{
	class Vertex2TestBase
	{
		protected static double Next(Random random)
		{
			return (Next(random, 16.0, 32.0));
		}

		protected static double Next(Random random, double minValue, double maxValue)
		{
			return (random.NextDouble() * (maxValue - minValue) + minValue);
		}
	}

	[TestFixture]
	[Category("Math")]
	class Vertex2ubTest : Vertex2TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex2ub(byte)")]
		public void Vertex2ub_TestConstructor1()
		{
			Random random = new Random();
			byte randomValue = (byte)Next(random);
			
			Vertex2ub v = new Vertex2ub(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
		}

		[Test(Description = "Test Vertex2ub(byte[])")]
		public void Vertex2ub_TestConstructor2()
		{
			Random random = new Random();
			byte randomValueX = (byte)Next(random);
			byte randomValueY = (byte)Next(random);

			Vertex2ub v = new Vertex2ub(new byte[] {
				randomValueX, randomValueY
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
		}

		[Test(Description = "Test Vertex2ub(byte, byte, byte)")]
		public void Vertex2ub_TestConstructor3()
		{
			Random random = new Random();
			byte randomValueX = (byte)Next(random);
			byte randomValueY = (byte)Next(random);

			Vertex2ub v = new Vertex2ub(
				randomValueX, randomValueY
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex2ub.Size against Marshal.SizeOf")]
		public void Vertex2ub_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex2ub)), Vertex2ub.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex2ub.operator+(Vertex2ub, Vertex2ub)")]
		public void Vertex2ub_TestOperatorAdd()
		{
			Random random = new Random();
			
			byte x1 = (byte)Next(random);
			byte y1 = (byte)Next(random);

			Vertex2ub v1 = new Vertex2ub(x1, y1);

			byte x2 = (byte)Next(random);
			byte y2 = (byte)Next(random);

			Vertex2ub v2 = new Vertex2ub(x2, y2);

			Vertex2ub v = v1 + v2;

			Assert.AreEqual((byte)(x1 + x2), v.x);
			Assert.AreEqual((byte)(y1 + y2), v.y);
		}

		[Test(Description = "Test Vertex2ub.operator-(Vertex2ub, Vertex2ub)")]
		public void Vertex2ub_TestOperatorSub()
		{
			Random random = new Random();
			
			byte x1 = (byte)Next(random);
			byte y1 = (byte)Next(random);

			Vertex2ub v1 = new Vertex2ub(x1, y1);

			byte x2 = (byte)Next(random);
			byte y2 = (byte)Next(random);

			Vertex2ub v2 = new Vertex2ub(x2, y2);

			Vertex2ub v = v1 - v2;

			Assert.AreEqual((byte)(x1 - x2), v.x);
			Assert.AreEqual((byte)(y1 - y2), v.y);
		}

		[Test(Description = "Test Vertex2ub.operator*(Vertex2ub, Single)")]
		public void Vertex2ub_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			byte x1 = (byte)Next(random);
			byte y1 = (byte)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex2ub v1 = new Vertex2ub(x1, y1);

			Vertex2ub v = v1 * (float)s;

			Assert.AreEqual((byte)(x1 * (float)s), v.x);
			Assert.AreEqual((byte)(y1 * (float)s), v.y);
		}

		[Test(Description = "Test Vertex2ub.operator*(Vertex2ub, Double)")]
		public void Vertex2ub_TestOperatorMultiplyDouble()
		{
			Random random = new Random();
			
			byte x1 = (byte)Next(random);
			byte y1 = (byte)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex2ub v1 = new Vertex2ub(x1, y1);

			Vertex2ub v = v1 * s;

			Assert.AreEqual((byte)(x1 * s), v.x);
			Assert.AreEqual((byte)(y1 * s), v.y);
		}

		[Test(Description = "Test Vertex2ub.operator/(Vertex2ub, Single)")]
		public void Vertex2ub_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			byte x1 = (byte)Next(random);
			byte y1 = (byte)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex2ub v1 = new Vertex2ub(x1, y1);

			Vertex2ub v = v1 / (float)s;

			Assert.AreEqual((byte)(x1 / (float)s), v.x);
			Assert.AreEqual((byte)(y1 / (float)s), v.y);
		}

		[Test(Description = "Test Vertex2ub.operator/(Vertex2ub, Double)")]
		public void Vertex2ub_TestOperatorDivideDouble()
		{
			Random random = new Random();
			
			byte x1 = (byte)Next(random);
			byte y1 = (byte)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex2ub v1 = new Vertex2ub(x1, y1);

			Vertex2ub v = v1 / s;

			Assert.AreEqual((byte)(x1 / s), v.x);
			Assert.AreEqual((byte)(y1 / s), v.y);
		}

		[Test(Description = "Test Vertex2ub.operator*(Vertex2ub, byte)")]
		public void Vertex2ub_TestOperatorScalarMultiply()
		{
			Random random = new Random();
			
			byte x1 = (byte)Next(random);
			byte y1 = (byte)Next(random);
			byte s = (byte)Next(random, 0.0, 32.0);

			Vertex2ub v1 = new Vertex2ub(x1, y1);

			Vertex2ub v = v1 * s;

			Assert.AreEqual((byte)(x1 * s), v.x);
			Assert.AreEqual((byte)(y1 * s), v.y);
		}

		[Test(Description = "Test Vertex2ub.operator/(Vertex2ub, byte)")]
		public void Vertex2ub_TestOperatorScalarDivide()
		{
			Random random = new Random();
			
			byte x1 = (byte)Next(random);
			byte y1 = (byte)Next(random);
			byte s = (byte)Next(random, 1.0, 32.0);

			Vertex2ub v1 = new Vertex2ub(x1, y1);

			Vertex2ub v = v1 / s;

			Assert.AreEqual((byte)(x1 / s), v.x);
			Assert.AreEqual((byte)(y1 / s), v.y);
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex2ub.operator==(Vertex2ub, Vertex2ub)")]
		public void Vertex2ub_TestOperatorEquality()
		{
			Vertex2ub v = Vertex2ub.UnitX;

			Assert.IsTrue(v == Vertex2ub.UnitX);
			Assert.IsFalse(v == Vertex2ub.UnitY);
		}

		[Test(Description = "Test Vertex2ub.operator!=(Vertex2ub, Vertex2ub)")]
		public void Vertex2ub_TestOperatorInequality()
		{
			Vertex2ub v = Vertex2ub.UnitX;

			Assert.IsFalse(v != Vertex2ub.UnitX);
			Assert.IsTrue(v != Vertex2ub.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex2ub.operator byte[](Vertex2ub)")]
		public void Vertex2ub_TestCastToArray()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random);
			byte y = (byte)Next(random);

			Vertex2ub v = new Vertex2ub(x, y);
			byte[] vArray = (byte[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
		}

		[Test(Description = "Test Vertex2ub.operator Vertex2f(Vertex2ub)")]
		public void Vertex2ub_TestCastToVertex2f()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random);
			byte y = (byte)Next(random);

			Vertex2ub v = new Vertex2ub(x, y);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.x, (float)v2f.x, 1e-4f);
			Assert.AreEqual(v.y, (float)v2f.y, 1e-4f);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex2ub.Module()")]
		public void Vertex2ub_TestModule()
		{
			Assert.AreEqual(2.236068f, new Vertex2ub((byte)1.0, (byte)2.0).Module(), 1e-4f);
			Assert.AreEqual(5.385165f, new Vertex2ub((byte)2.0, (byte)5.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex2ub.ModuleSquared()")]
		public void Vertex2ub_TestModuleSquared()
		{
			Assert.AreEqual(5f, new Vertex2ub((byte)1.0, (byte)2.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(29f, new Vertex2ub((byte)2.0, (byte)5.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex2ub.Normalize()")]
		public void Vertex2ub_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex2ub.Zero.Normalize(); });

			Vertex2ub v;

			v = Vertex2ub.UnitX * (byte)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex2ub.UnitX, v);

			v = Vertex2ub.UnitY * (byte)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex2ub.UnitY, v);
		}

		[Test(Description = "Test Vertex2ub.Normalized")]
		public void Vertex2ub_TestNormalized()
		{
			Vertex2ub v;

			Assert.DoesNotThrow(delegate() { v = Vertex2ub.Zero.Normalized; });

			v = Vertex2ub.UnitX * (byte)2.0f;
			Assert.AreEqual(Vertex2ub.UnitX, v.Normalized);

			v = Vertex2ub.UnitY * (byte)2.0f;
			Assert.AreEqual(Vertex2ub.UnitY, v.Normalized);
		}

		[Test(Description = "Test Vertex2ub.Min(Vertex2ub[])")]
		public void Vertex2ub_TestMin()
		{
			Vertex2ub[] v = new Vertex2ub[] {
				new Vertex2ub((byte)1.0f, (byte)13.0f),
				new Vertex2ub((byte)2.0f, (byte)12.0f),
				new Vertex2ub((byte)3.0f, (byte)11.0f),
			};

			Vertex2ub min = Vertex2ub.Min(v);

			Assert.AreEqual(
				new Vertex2ub((byte)1.0f, (byte)11.0f),
				min
			);
		}

		[Test(Description = "Test Vertex2ub.Min(Vertex2ub[]) ArgumentNullException")]
		public void Vertex2ub_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2ub.Min(null));
		}

		[Test(Description = "Test Vertex2ub.Min(Vertex2ub*)")]
		public void Vertex2ub_TestMin_Unsafe()
		{
			Vertex2ub[] v = new Vertex2ub[] {
				new Vertex2ub((byte)1.0f, (byte)13.0f),
				new Vertex2ub((byte)2.0f, (byte)12.0f),
				new Vertex2ub((byte)3.0f, (byte)11.0f),
			};

			Vertex2ub min;

			unsafe {
				fixed (Vertex2ub* vPtr = v) {
					min = Vertex2ub.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex2ub((byte)1.0f, (byte)11.0f),
				min
			);
		}

		[Test(Description = "Test Vertex2ub.Min(Vertex2ub*) ArgumentNullException")]
		public void Vertex2ub_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2ub.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex2ub.Max(Vertex2ub[])")]
		public void Vertex2ub_TestMax()
		{
			Vertex2ub[] v = new Vertex2ub[] {
				new Vertex2ub((byte)1.0f, (byte)13.0f),
				new Vertex2ub((byte)2.0f, (byte)12.0f),
				new Vertex2ub((byte)3.0f, (byte)11.0f),
			};

			Vertex2ub max = Vertex2ub.Max(v);

			Assert.AreEqual(
				new Vertex2ub((byte)3.0f, (byte)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2ub.Max(Vertex2ub[]) ArgumentNullException")]
		public void Vertex2ub_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2ub.Max(null));
		}

		[Test(Description = "Test Vertex2ub.Max(Vertex2ub*)")]
		public void Vertex2ub_TestMax_Unsafe()
		{
			Vertex2ub[] v = new Vertex2ub[] {
				new Vertex2ub((byte)1.0f, (byte)13.0f),
				new Vertex2ub((byte)2.0f, (byte)12.0f),
				new Vertex2ub((byte)3.0f, (byte)11.0f),
			};

			Vertex2ub max;

			unsafe {
				fixed (Vertex2ub* vPtr = v) {
					max = Vertex2ub.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex2ub((byte)3.0f, (byte)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2ub.Max(Vertex2ub*) ArgumentNullException")]
		public void Vertex2ub_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2ub.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex2ub.Max(Vertex2ub[])")]
		public void Vertex2ub_TestMinMax()
		{
			Vertex2ub[] v = new Vertex2ub[] {
				new Vertex2ub((byte)1.0f, (byte)13.0f),
				new Vertex2ub((byte)2.0f, (byte)12.0f),
				new Vertex2ub((byte)3.0f, (byte)11.0f),
			};

			Vertex2ub min, max;

			Vertex2ub.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex2ub((byte)1.0f, (byte)11.0f),
				min
			);
			Assert.AreEqual(
				new Vertex2ub((byte)3.0f, (byte)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2ub.Max(Vertex2ub[]) ArgumentNullException")]
		public void Vertex2ub_TestMinMax_ArgumentNullException()
		{
			Vertex2ub min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex2ub.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex2ub.MinMax(Vertex2ub*)")]
		public void Vertex2ub_TestMinMax_Unsafe()
		{
			Vertex2ub[] v = new Vertex2ub[] {
				new Vertex2ub((byte)1.0f, (byte)13.0f),
				new Vertex2ub((byte)2.0f, (byte)12.0f),
				new Vertex2ub((byte)3.0f, (byte)11.0f),
			};

			Vertex2ub min, max;

			unsafe {
				fixed (Vertex2ub* vPtr = v) {
					Vertex2ub.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex2ub((byte)1.0f, (byte)11.0f),
				min
			);
			Assert.AreEqual(
				new Vertex2ub((byte)3.0f, (byte)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2ub.MinMax(Vertex2ub*) ArgumentNullException")]
		public void Vertex2ub_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex2ub min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2ub.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex2ub.Equals(Vertex2ub)")]
		public void Vertex2ub_TestEquals_Vertex2ub()
		{
			Vertex2ub v = Vertex2ub.UnitX;

			Assert.IsTrue(v.Equals(Vertex2ub.UnitX));
			Assert.IsFalse(v.Equals(Vertex2ub.UnitY));
		}

		[Test(Description = "Test Vertex2ub.Equals(object)")]
		public void Vertex2ub_TestEquals_True()
		{
			Vertex2ub v = Vertex2ub.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex2ub.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex2ub.UnitY));
		}

		[Test(Description = "Test Vertex2ub.GetHashCode()")]
		public void Vertex2ub_TestGetHashCode()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random);
			byte y = (byte)Next(random);

			Vertex2ub v = new Vertex2ub(x, y);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex2ub.ToString()")]
		public void Vertex2ub_TestToString()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random);
			byte y = (byte)Next(random);

			Vertex2ub v = new Vertex2ub(x, y);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex2bTest : Vertex2TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex2b(sbyte)")]
		public void Vertex2b_TestConstructor1()
		{
			Random random = new Random();
			sbyte randomValue = (sbyte)Next(random);
			
			Vertex2b v = new Vertex2b(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
		}

		[Test(Description = "Test Vertex2b(sbyte[])")]
		public void Vertex2b_TestConstructor2()
		{
			Random random = new Random();
			sbyte randomValueX = (sbyte)Next(random);
			sbyte randomValueY = (sbyte)Next(random);

			Vertex2b v = new Vertex2b(new sbyte[] {
				randomValueX, randomValueY
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
		}

		[Test(Description = "Test Vertex2b(sbyte, sbyte, sbyte)")]
		public void Vertex2b_TestConstructor3()
		{
			Random random = new Random();
			sbyte randomValueX = (sbyte)Next(random);
			sbyte randomValueY = (sbyte)Next(random);

			Vertex2b v = new Vertex2b(
				randomValueX, randomValueY
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex2b.Size against Marshal.SizeOf")]
		public void Vertex2b_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex2b)), Vertex2b.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex2b.operator-(Vertex2b))")]
		public void Vertex2b_TestOperatorNegate()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random);
			sbyte y = (sbyte)Next(random);

			Vertex2b v = new Vertex2b(x, y);
			Vertex2b n = -v;

			Assert.AreEqual(-x, n.x);
			Assert.AreEqual(-y, n.y);
		}
		[Test(Description = "Test Vertex2b.operator+(Vertex2b, Vertex2b)")]
		public void Vertex2b_TestOperatorAdd()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random);
			sbyte y1 = (sbyte)Next(random);

			Vertex2b v1 = new Vertex2b(x1, y1);

			sbyte x2 = (sbyte)Next(random);
			sbyte y2 = (sbyte)Next(random);

			Vertex2b v2 = new Vertex2b(x2, y2);

			Vertex2b v = v1 + v2;

			Assert.AreEqual((sbyte)(x1 + x2), v.x);
			Assert.AreEqual((sbyte)(y1 + y2), v.y);
		}

		[Test(Description = "Test Vertex2b.operator-(Vertex2b, Vertex2b)")]
		public void Vertex2b_TestOperatorSub()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random);
			sbyte y1 = (sbyte)Next(random);

			Vertex2b v1 = new Vertex2b(x1, y1);

			sbyte x2 = (sbyte)Next(random);
			sbyte y2 = (sbyte)Next(random);

			Vertex2b v2 = new Vertex2b(x2, y2);

			Vertex2b v = v1 - v2;

			Assert.AreEqual((sbyte)(x1 - x2), v.x);
			Assert.AreEqual((sbyte)(y1 - y2), v.y);
		}

		[Test(Description = "Test Vertex2b.operator*(Vertex2b, Single)")]
		public void Vertex2b_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random);
			sbyte y1 = (sbyte)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex2b v1 = new Vertex2b(x1, y1);

			Vertex2b v = v1 * (float)s;

			Assert.AreEqual((sbyte)(x1 * (float)s), v.x);
			Assert.AreEqual((sbyte)(y1 * (float)s), v.y);
		}

		[Test(Description = "Test Vertex2b.operator*(Vertex2b, Double)")]
		public void Vertex2b_TestOperatorMultiplyDouble()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random);
			sbyte y1 = (sbyte)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex2b v1 = new Vertex2b(x1, y1);

			Vertex2b v = v1 * s;

			Assert.AreEqual((sbyte)(x1 * s), v.x);
			Assert.AreEqual((sbyte)(y1 * s), v.y);
		}

		[Test(Description = "Test Vertex2b.operator/(Vertex2b, Single)")]
		public void Vertex2b_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random);
			sbyte y1 = (sbyte)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex2b v1 = new Vertex2b(x1, y1);

			Vertex2b v = v1 / (float)s;

			Assert.AreEqual((sbyte)(x1 / (float)s), v.x);
			Assert.AreEqual((sbyte)(y1 / (float)s), v.y);
		}

		[Test(Description = "Test Vertex2b.operator/(Vertex2b, Double)")]
		public void Vertex2b_TestOperatorDivideDouble()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random);
			sbyte y1 = (sbyte)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex2b v1 = new Vertex2b(x1, y1);

			Vertex2b v = v1 / s;

			Assert.AreEqual((sbyte)(x1 / s), v.x);
			Assert.AreEqual((sbyte)(y1 / s), v.y);
		}

		[Test(Description = "Test Vertex2b.operator*(Vertex2b, sbyte)")]
		public void Vertex2b_TestOperatorScalarMultiply()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random);
			sbyte y1 = (sbyte)Next(random);
			sbyte s = (sbyte)Next(random, 0.0, 32.0);

			Vertex2b v1 = new Vertex2b(x1, y1);

			Vertex2b v = v1 * s;

			Assert.AreEqual((sbyte)(x1 * s), v.x);
			Assert.AreEqual((sbyte)(y1 * s), v.y);
		}

		[Test(Description = "Test Vertex2b.operator/(Vertex2b, sbyte)")]
		public void Vertex2b_TestOperatorScalarDivide()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random);
			sbyte y1 = (sbyte)Next(random);
			sbyte s = (sbyte)Next(random, 1.0, 32.0);

			Vertex2b v1 = new Vertex2b(x1, y1);

			Vertex2b v = v1 / s;

			Assert.AreEqual((sbyte)(x1 / s), v.x);
			Assert.AreEqual((sbyte)(y1 / s), v.y);
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex2b.operator==(Vertex2b, Vertex2b)")]
		public void Vertex2b_TestOperatorEquality()
		{
			Vertex2b v = Vertex2b.UnitX;

			Assert.IsTrue(v == Vertex2b.UnitX);
			Assert.IsFalse(v == Vertex2b.UnitY);
		}

		[Test(Description = "Test Vertex2b.operator!=(Vertex2b, Vertex2b)")]
		public void Vertex2b_TestOperatorInequality()
		{
			Vertex2b v = Vertex2b.UnitX;

			Assert.IsFalse(v != Vertex2b.UnitX);
			Assert.IsTrue(v != Vertex2b.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex2b.operator sbyte[](Vertex2b)")]
		public void Vertex2b_TestCastToArray()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random);
			sbyte y = (sbyte)Next(random);

			Vertex2b v = new Vertex2b(x, y);
			sbyte[] vArray = (sbyte[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
		}

		[Test(Description = "Test Vertex2b.operator Vertex2f(Vertex2b)")]
		public void Vertex2b_TestCastToVertex2f()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random);
			sbyte y = (sbyte)Next(random);

			Vertex2b v = new Vertex2b(x, y);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.x, (float)v2f.x, 1e-4f);
			Assert.AreEqual(v.y, (float)v2f.y, 1e-4f);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex2b.Module()")]
		public void Vertex2b_TestModule()
		{
			Assert.AreEqual(2.236068f, new Vertex2b((sbyte)1.0, (sbyte)2.0).Module(), 1e-4f);
			Assert.AreEqual(5.385165f, new Vertex2b((sbyte)2.0, (sbyte)5.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex2b.ModuleSquared()")]
		public void Vertex2b_TestModuleSquared()
		{
			Assert.AreEqual(5f, new Vertex2b((sbyte)1.0, (sbyte)2.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(29f, new Vertex2b((sbyte)2.0, (sbyte)5.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex2b.Normalize()")]
		public void Vertex2b_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex2b.Zero.Normalize(); });

			Vertex2b v;

			v = Vertex2b.UnitX * (sbyte)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex2b.UnitX, v);

			v = Vertex2b.UnitY * (sbyte)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex2b.UnitY, v);
		}

		[Test(Description = "Test Vertex2b.Normalized")]
		public void Vertex2b_TestNormalized()
		{
			Vertex2b v;

			Assert.DoesNotThrow(delegate() { v = Vertex2b.Zero.Normalized; });

			v = Vertex2b.UnitX * (sbyte)2.0f;
			Assert.AreEqual(Vertex2b.UnitX, v.Normalized);

			v = Vertex2b.UnitY * (sbyte)2.0f;
			Assert.AreEqual(Vertex2b.UnitY, v.Normalized);
		}

		[Test(Description = "Test Vertex2b.Min(Vertex2b[])")]
		public void Vertex2b_TestMin()
		{
			Vertex2b[] v = new Vertex2b[] {
				new Vertex2b((sbyte)1.0f, (sbyte)13.0f),
				new Vertex2b((sbyte)2.0f, (sbyte)12.0f),
				new Vertex2b((sbyte)3.0f, (sbyte)11.0f),
			};

			Vertex2b min = Vertex2b.Min(v);

			Assert.AreEqual(
				new Vertex2b((sbyte)1.0f, (sbyte)11.0f),
				min
			);
		}

		[Test(Description = "Test Vertex2b.Min(Vertex2b[]) ArgumentNullException")]
		public void Vertex2b_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2b.Min(null));
		}

		[Test(Description = "Test Vertex2b.Min(Vertex2b*)")]
		public void Vertex2b_TestMin_Unsafe()
		{
			Vertex2b[] v = new Vertex2b[] {
				new Vertex2b((sbyte)1.0f, (sbyte)13.0f),
				new Vertex2b((sbyte)2.0f, (sbyte)12.0f),
				new Vertex2b((sbyte)3.0f, (sbyte)11.0f),
			};

			Vertex2b min;

			unsafe {
				fixed (Vertex2b* vPtr = v) {
					min = Vertex2b.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex2b((sbyte)1.0f, (sbyte)11.0f),
				min
			);
		}

		[Test(Description = "Test Vertex2b.Min(Vertex2b*) ArgumentNullException")]
		public void Vertex2b_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2b.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex2b.Max(Vertex2b[])")]
		public void Vertex2b_TestMax()
		{
			Vertex2b[] v = new Vertex2b[] {
				new Vertex2b((sbyte)1.0f, (sbyte)13.0f),
				new Vertex2b((sbyte)2.0f, (sbyte)12.0f),
				new Vertex2b((sbyte)3.0f, (sbyte)11.0f),
			};

			Vertex2b max = Vertex2b.Max(v);

			Assert.AreEqual(
				new Vertex2b((sbyte)3.0f, (sbyte)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2b.Max(Vertex2b[]) ArgumentNullException")]
		public void Vertex2b_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2b.Max(null));
		}

		[Test(Description = "Test Vertex2b.Max(Vertex2b*)")]
		public void Vertex2b_TestMax_Unsafe()
		{
			Vertex2b[] v = new Vertex2b[] {
				new Vertex2b((sbyte)1.0f, (sbyte)13.0f),
				new Vertex2b((sbyte)2.0f, (sbyte)12.0f),
				new Vertex2b((sbyte)3.0f, (sbyte)11.0f),
			};

			Vertex2b max;

			unsafe {
				fixed (Vertex2b* vPtr = v) {
					max = Vertex2b.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex2b((sbyte)3.0f, (sbyte)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2b.Max(Vertex2b*) ArgumentNullException")]
		public void Vertex2b_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2b.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex2b.Max(Vertex2b[])")]
		public void Vertex2b_TestMinMax()
		{
			Vertex2b[] v = new Vertex2b[] {
				new Vertex2b((sbyte)1.0f, (sbyte)13.0f),
				new Vertex2b((sbyte)2.0f, (sbyte)12.0f),
				new Vertex2b((sbyte)3.0f, (sbyte)11.0f),
			};

			Vertex2b min, max;

			Vertex2b.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex2b((sbyte)1.0f, (sbyte)11.0f),
				min
			);
			Assert.AreEqual(
				new Vertex2b((sbyte)3.0f, (sbyte)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2b.Max(Vertex2b[]) ArgumentNullException")]
		public void Vertex2b_TestMinMax_ArgumentNullException()
		{
			Vertex2b min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex2b.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex2b.MinMax(Vertex2b*)")]
		public void Vertex2b_TestMinMax_Unsafe()
		{
			Vertex2b[] v = new Vertex2b[] {
				new Vertex2b((sbyte)1.0f, (sbyte)13.0f),
				new Vertex2b((sbyte)2.0f, (sbyte)12.0f),
				new Vertex2b((sbyte)3.0f, (sbyte)11.0f),
			};

			Vertex2b min, max;

			unsafe {
				fixed (Vertex2b* vPtr = v) {
					Vertex2b.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex2b((sbyte)1.0f, (sbyte)11.0f),
				min
			);
			Assert.AreEqual(
				new Vertex2b((sbyte)3.0f, (sbyte)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2b.MinMax(Vertex2b*) ArgumentNullException")]
		public void Vertex2b_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex2b min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2b.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex2b.Equals(Vertex2b)")]
		public void Vertex2b_TestEquals_Vertex2b()
		{
			Vertex2b v = Vertex2b.UnitX;

			Assert.IsTrue(v.Equals(Vertex2b.UnitX));
			Assert.IsFalse(v.Equals(Vertex2b.UnitY));
		}

		[Test(Description = "Test Vertex2b.Equals(object)")]
		public void Vertex2b_TestEquals_True()
		{
			Vertex2b v = Vertex2b.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex2b.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex2b.UnitY));
		}

		[Test(Description = "Test Vertex2b.GetHashCode()")]
		public void Vertex2b_TestGetHashCode()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random);
			sbyte y = (sbyte)Next(random);

			Vertex2b v = new Vertex2b(x, y);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex2b.ToString()")]
		public void Vertex2b_TestToString()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random);
			sbyte y = (sbyte)Next(random);

			Vertex2b v = new Vertex2b(x, y);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex2usTest : Vertex2TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex2us(ushort)")]
		public void Vertex2us_TestConstructor1()
		{
			Random random = new Random();
			ushort randomValue = (ushort)Next(random);
			
			Vertex2us v = new Vertex2us(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
		}

		[Test(Description = "Test Vertex2us(ushort[])")]
		public void Vertex2us_TestConstructor2()
		{
			Random random = new Random();
			ushort randomValueX = (ushort)Next(random);
			ushort randomValueY = (ushort)Next(random);

			Vertex2us v = new Vertex2us(new ushort[] {
				randomValueX, randomValueY
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
		}

		[Test(Description = "Test Vertex2us(ushort, ushort, ushort)")]
		public void Vertex2us_TestConstructor3()
		{
			Random random = new Random();
			ushort randomValueX = (ushort)Next(random);
			ushort randomValueY = (ushort)Next(random);

			Vertex2us v = new Vertex2us(
				randomValueX, randomValueY
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex2us.Size against Marshal.SizeOf")]
		public void Vertex2us_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex2us)), Vertex2us.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex2us.operator+(Vertex2us, Vertex2us)")]
		public void Vertex2us_TestOperatorAdd()
		{
			Random random = new Random();
			
			ushort x1 = (ushort)Next(random);
			ushort y1 = (ushort)Next(random);

			Vertex2us v1 = new Vertex2us(x1, y1);

			ushort x2 = (ushort)Next(random);
			ushort y2 = (ushort)Next(random);

			Vertex2us v2 = new Vertex2us(x2, y2);

			Vertex2us v = v1 + v2;

			Assert.AreEqual((ushort)(x1 + x2), v.x);
			Assert.AreEqual((ushort)(y1 + y2), v.y);
		}

		[Test(Description = "Test Vertex2us.operator-(Vertex2us, Vertex2us)")]
		public void Vertex2us_TestOperatorSub()
		{
			Random random = new Random();
			
			ushort x1 = (ushort)Next(random);
			ushort y1 = (ushort)Next(random);

			Vertex2us v1 = new Vertex2us(x1, y1);

			ushort x2 = (ushort)Next(random);
			ushort y2 = (ushort)Next(random);

			Vertex2us v2 = new Vertex2us(x2, y2);

			Vertex2us v = v1 - v2;

			Assert.AreEqual((ushort)(x1 - x2), v.x);
			Assert.AreEqual((ushort)(y1 - y2), v.y);
		}

		[Test(Description = "Test Vertex2us.operator*(Vertex2us, Single)")]
		public void Vertex2us_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			ushort x1 = (ushort)Next(random);
			ushort y1 = (ushort)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex2us v1 = new Vertex2us(x1, y1);

			Vertex2us v = v1 * (float)s;

			Assert.AreEqual((ushort)(x1 * (float)s), v.x);
			Assert.AreEqual((ushort)(y1 * (float)s), v.y);
		}

		[Test(Description = "Test Vertex2us.operator*(Vertex2us, Double)")]
		public void Vertex2us_TestOperatorMultiplyDouble()
		{
			Random random = new Random();
			
			ushort x1 = (ushort)Next(random);
			ushort y1 = (ushort)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex2us v1 = new Vertex2us(x1, y1);

			Vertex2us v = v1 * s;

			Assert.AreEqual((ushort)(x1 * s), v.x);
			Assert.AreEqual((ushort)(y1 * s), v.y);
		}

		[Test(Description = "Test Vertex2us.operator/(Vertex2us, Single)")]
		public void Vertex2us_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			ushort x1 = (ushort)Next(random);
			ushort y1 = (ushort)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex2us v1 = new Vertex2us(x1, y1);

			Vertex2us v = v1 / (float)s;

			Assert.AreEqual((ushort)(x1 / (float)s), v.x);
			Assert.AreEqual((ushort)(y1 / (float)s), v.y);
		}

		[Test(Description = "Test Vertex2us.operator/(Vertex2us, Double)")]
		public void Vertex2us_TestOperatorDivideDouble()
		{
			Random random = new Random();
			
			ushort x1 = (ushort)Next(random);
			ushort y1 = (ushort)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex2us v1 = new Vertex2us(x1, y1);

			Vertex2us v = v1 / s;

			Assert.AreEqual((ushort)(x1 / s), v.x);
			Assert.AreEqual((ushort)(y1 / s), v.y);
		}

		[Test(Description = "Test Vertex2us.operator*(Vertex2us, ushort)")]
		public void Vertex2us_TestOperatorScalarMultiply()
		{
			Random random = new Random();
			
			ushort x1 = (ushort)Next(random);
			ushort y1 = (ushort)Next(random);
			ushort s = (ushort)Next(random, 0.0, 32.0);

			Vertex2us v1 = new Vertex2us(x1, y1);

			Vertex2us v = v1 * s;

			Assert.AreEqual((ushort)(x1 * s), v.x);
			Assert.AreEqual((ushort)(y1 * s), v.y);
		}

		[Test(Description = "Test Vertex2us.operator/(Vertex2us, ushort)")]
		public void Vertex2us_TestOperatorScalarDivide()
		{
			Random random = new Random();
			
			ushort x1 = (ushort)Next(random);
			ushort y1 = (ushort)Next(random);
			ushort s = (ushort)Next(random, 1.0, 32.0);

			Vertex2us v1 = new Vertex2us(x1, y1);

			Vertex2us v = v1 / s;

			Assert.AreEqual((ushort)(x1 / s), v.x);
			Assert.AreEqual((ushort)(y1 / s), v.y);
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex2us.operator==(Vertex2us, Vertex2us)")]
		public void Vertex2us_TestOperatorEquality()
		{
			Vertex2us v = Vertex2us.UnitX;

			Assert.IsTrue(v == Vertex2us.UnitX);
			Assert.IsFalse(v == Vertex2us.UnitY);
		}

		[Test(Description = "Test Vertex2us.operator!=(Vertex2us, Vertex2us)")]
		public void Vertex2us_TestOperatorInequality()
		{
			Vertex2us v = Vertex2us.UnitX;

			Assert.IsFalse(v != Vertex2us.UnitX);
			Assert.IsTrue(v != Vertex2us.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex2us.operator ushort[](Vertex2us)")]
		public void Vertex2us_TestCastToArray()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random);
			ushort y = (ushort)Next(random);

			Vertex2us v = new Vertex2us(x, y);
			ushort[] vArray = (ushort[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
		}

		[Test(Description = "Test Vertex2us.operator Vertex2f(Vertex2us)")]
		public void Vertex2us_TestCastToVertex2f()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random);
			ushort y = (ushort)Next(random);

			Vertex2us v = new Vertex2us(x, y);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.x, (float)v2f.x, 1e-4f);
			Assert.AreEqual(v.y, (float)v2f.y, 1e-4f);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex2us.Module()")]
		public void Vertex2us_TestModule()
		{
			Assert.AreEqual(2.236068f, new Vertex2us((ushort)1.0, (ushort)2.0).Module(), 1e-4f);
			Assert.AreEqual(5.385165f, new Vertex2us((ushort)2.0, (ushort)5.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex2us.ModuleSquared()")]
		public void Vertex2us_TestModuleSquared()
		{
			Assert.AreEqual(5f, new Vertex2us((ushort)1.0, (ushort)2.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(29f, new Vertex2us((ushort)2.0, (ushort)5.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex2us.Normalize()")]
		public void Vertex2us_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex2us.Zero.Normalize(); });

			Vertex2us v;

			v = Vertex2us.UnitX * (ushort)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex2us.UnitX, v);

			v = Vertex2us.UnitY * (ushort)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex2us.UnitY, v);
		}

		[Test(Description = "Test Vertex2us.Normalized")]
		public void Vertex2us_TestNormalized()
		{
			Vertex2us v;

			Assert.DoesNotThrow(delegate() { v = Vertex2us.Zero.Normalized; });

			v = Vertex2us.UnitX * (ushort)2.0f;
			Assert.AreEqual(Vertex2us.UnitX, v.Normalized);

			v = Vertex2us.UnitY * (ushort)2.0f;
			Assert.AreEqual(Vertex2us.UnitY, v.Normalized);
		}

		[Test(Description = "Test Vertex2us.Min(Vertex2us[])")]
		public void Vertex2us_TestMin()
		{
			Vertex2us[] v = new Vertex2us[] {
				new Vertex2us((ushort)1.0f, (ushort)13.0f),
				new Vertex2us((ushort)2.0f, (ushort)12.0f),
				new Vertex2us((ushort)3.0f, (ushort)11.0f),
			};

			Vertex2us min = Vertex2us.Min(v);

			Assert.AreEqual(
				new Vertex2us((ushort)1.0f, (ushort)11.0f),
				min
			);
		}

		[Test(Description = "Test Vertex2us.Min(Vertex2us[]) ArgumentNullException")]
		public void Vertex2us_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2us.Min(null));
		}

		[Test(Description = "Test Vertex2us.Min(Vertex2us*)")]
		public void Vertex2us_TestMin_Unsafe()
		{
			Vertex2us[] v = new Vertex2us[] {
				new Vertex2us((ushort)1.0f, (ushort)13.0f),
				new Vertex2us((ushort)2.0f, (ushort)12.0f),
				new Vertex2us((ushort)3.0f, (ushort)11.0f),
			};

			Vertex2us min;

			unsafe {
				fixed (Vertex2us* vPtr = v) {
					min = Vertex2us.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex2us((ushort)1.0f, (ushort)11.0f),
				min
			);
		}

		[Test(Description = "Test Vertex2us.Min(Vertex2us*) ArgumentNullException")]
		public void Vertex2us_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2us.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex2us.Max(Vertex2us[])")]
		public void Vertex2us_TestMax()
		{
			Vertex2us[] v = new Vertex2us[] {
				new Vertex2us((ushort)1.0f, (ushort)13.0f),
				new Vertex2us((ushort)2.0f, (ushort)12.0f),
				new Vertex2us((ushort)3.0f, (ushort)11.0f),
			};

			Vertex2us max = Vertex2us.Max(v);

			Assert.AreEqual(
				new Vertex2us((ushort)3.0f, (ushort)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2us.Max(Vertex2us[]) ArgumentNullException")]
		public void Vertex2us_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2us.Max(null));
		}

		[Test(Description = "Test Vertex2us.Max(Vertex2us*)")]
		public void Vertex2us_TestMax_Unsafe()
		{
			Vertex2us[] v = new Vertex2us[] {
				new Vertex2us((ushort)1.0f, (ushort)13.0f),
				new Vertex2us((ushort)2.0f, (ushort)12.0f),
				new Vertex2us((ushort)3.0f, (ushort)11.0f),
			};

			Vertex2us max;

			unsafe {
				fixed (Vertex2us* vPtr = v) {
					max = Vertex2us.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex2us((ushort)3.0f, (ushort)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2us.Max(Vertex2us*) ArgumentNullException")]
		public void Vertex2us_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2us.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex2us.Max(Vertex2us[])")]
		public void Vertex2us_TestMinMax()
		{
			Vertex2us[] v = new Vertex2us[] {
				new Vertex2us((ushort)1.0f, (ushort)13.0f),
				new Vertex2us((ushort)2.0f, (ushort)12.0f),
				new Vertex2us((ushort)3.0f, (ushort)11.0f),
			};

			Vertex2us min, max;

			Vertex2us.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex2us((ushort)1.0f, (ushort)11.0f),
				min
			);
			Assert.AreEqual(
				new Vertex2us((ushort)3.0f, (ushort)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2us.Max(Vertex2us[]) ArgumentNullException")]
		public void Vertex2us_TestMinMax_ArgumentNullException()
		{
			Vertex2us min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex2us.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex2us.MinMax(Vertex2us*)")]
		public void Vertex2us_TestMinMax_Unsafe()
		{
			Vertex2us[] v = new Vertex2us[] {
				new Vertex2us((ushort)1.0f, (ushort)13.0f),
				new Vertex2us((ushort)2.0f, (ushort)12.0f),
				new Vertex2us((ushort)3.0f, (ushort)11.0f),
			};

			Vertex2us min, max;

			unsafe {
				fixed (Vertex2us* vPtr = v) {
					Vertex2us.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex2us((ushort)1.0f, (ushort)11.0f),
				min
			);
			Assert.AreEqual(
				new Vertex2us((ushort)3.0f, (ushort)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2us.MinMax(Vertex2us*) ArgumentNullException")]
		public void Vertex2us_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex2us min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2us.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex2us.Equals(Vertex2us)")]
		public void Vertex2us_TestEquals_Vertex2us()
		{
			Vertex2us v = Vertex2us.UnitX;

			Assert.IsTrue(v.Equals(Vertex2us.UnitX));
			Assert.IsFalse(v.Equals(Vertex2us.UnitY));
		}

		[Test(Description = "Test Vertex2us.Equals(object)")]
		public void Vertex2us_TestEquals_True()
		{
			Vertex2us v = Vertex2us.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex2us.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex2us.UnitY));
		}

		[Test(Description = "Test Vertex2us.GetHashCode()")]
		public void Vertex2us_TestGetHashCode()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random);
			ushort y = (ushort)Next(random);

			Vertex2us v = new Vertex2us(x, y);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex2us.ToString()")]
		public void Vertex2us_TestToString()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random);
			ushort y = (ushort)Next(random);

			Vertex2us v = new Vertex2us(x, y);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex2sTest : Vertex2TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex2s(short)")]
		public void Vertex2s_TestConstructor1()
		{
			Random random = new Random();
			short randomValue = (short)Next(random);
			
			Vertex2s v = new Vertex2s(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
		}

		[Test(Description = "Test Vertex2s(short[])")]
		public void Vertex2s_TestConstructor2()
		{
			Random random = new Random();
			short randomValueX = (short)Next(random);
			short randomValueY = (short)Next(random);

			Vertex2s v = new Vertex2s(new short[] {
				randomValueX, randomValueY
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
		}

		[Test(Description = "Test Vertex2s(short, short, short)")]
		public void Vertex2s_TestConstructor3()
		{
			Random random = new Random();
			short randomValueX = (short)Next(random);
			short randomValueY = (short)Next(random);

			Vertex2s v = new Vertex2s(
				randomValueX, randomValueY
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex2s.Size against Marshal.SizeOf")]
		public void Vertex2s_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex2s)), Vertex2s.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex2s.operator-(Vertex2s))")]
		public void Vertex2s_TestOperatorNegate()
		{
			Random random = new Random();
			
			short x = (short)Next(random);
			short y = (short)Next(random);

			Vertex2s v = new Vertex2s(x, y);
			Vertex2s n = -v;

			Assert.AreEqual(-x, n.x);
			Assert.AreEqual(-y, n.y);
		}
		[Test(Description = "Test Vertex2s.operator+(Vertex2s, Vertex2s)")]
		public void Vertex2s_TestOperatorAdd()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random);
			short y1 = (short)Next(random);

			Vertex2s v1 = new Vertex2s(x1, y1);

			short x2 = (short)Next(random);
			short y2 = (short)Next(random);

			Vertex2s v2 = new Vertex2s(x2, y2);

			Vertex2s v = v1 + v2;

			Assert.AreEqual((short)(x1 + x2), v.x);
			Assert.AreEqual((short)(y1 + y2), v.y);
		}

		[Test(Description = "Test Vertex2s.operator-(Vertex2s, Vertex2s)")]
		public void Vertex2s_TestOperatorSub()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random);
			short y1 = (short)Next(random);

			Vertex2s v1 = new Vertex2s(x1, y1);

			short x2 = (short)Next(random);
			short y2 = (short)Next(random);

			Vertex2s v2 = new Vertex2s(x2, y2);

			Vertex2s v = v1 - v2;

			Assert.AreEqual((short)(x1 - x2), v.x);
			Assert.AreEqual((short)(y1 - y2), v.y);
		}

		[Test(Description = "Test Vertex2s.operator*(Vertex2s, Single)")]
		public void Vertex2s_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random);
			short y1 = (short)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex2s v1 = new Vertex2s(x1, y1);

			Vertex2s v = v1 * (float)s;

			Assert.AreEqual((short)(x1 * (float)s), v.x);
			Assert.AreEqual((short)(y1 * (float)s), v.y);
		}

		[Test(Description = "Test Vertex2s.operator*(Vertex2s, Double)")]
		public void Vertex2s_TestOperatorMultiplyDouble()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random);
			short y1 = (short)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex2s v1 = new Vertex2s(x1, y1);

			Vertex2s v = v1 * s;

			Assert.AreEqual((short)(x1 * s), v.x);
			Assert.AreEqual((short)(y1 * s), v.y);
		}

		[Test(Description = "Test Vertex2s.operator/(Vertex2s, Single)")]
		public void Vertex2s_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random);
			short y1 = (short)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex2s v1 = new Vertex2s(x1, y1);

			Vertex2s v = v1 / (float)s;

			Assert.AreEqual((short)(x1 / (float)s), v.x);
			Assert.AreEqual((short)(y1 / (float)s), v.y);
		}

		[Test(Description = "Test Vertex2s.operator/(Vertex2s, Double)")]
		public void Vertex2s_TestOperatorDivideDouble()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random);
			short y1 = (short)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex2s v1 = new Vertex2s(x1, y1);

			Vertex2s v = v1 / s;

			Assert.AreEqual((short)(x1 / s), v.x);
			Assert.AreEqual((short)(y1 / s), v.y);
		}

		[Test(Description = "Test Vertex2s.operator*(Vertex2s, short)")]
		public void Vertex2s_TestOperatorScalarMultiply()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random);
			short y1 = (short)Next(random);
			short s = (short)Next(random, 0.0, 32.0);

			Vertex2s v1 = new Vertex2s(x1, y1);

			Vertex2s v = v1 * s;

			Assert.AreEqual((short)(x1 * s), v.x);
			Assert.AreEqual((short)(y1 * s), v.y);
		}

		[Test(Description = "Test Vertex2s.operator/(Vertex2s, short)")]
		public void Vertex2s_TestOperatorScalarDivide()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random);
			short y1 = (short)Next(random);
			short s = (short)Next(random, 1.0, 32.0);

			Vertex2s v1 = new Vertex2s(x1, y1);

			Vertex2s v = v1 / s;

			Assert.AreEqual((short)(x1 / s), v.x);
			Assert.AreEqual((short)(y1 / s), v.y);
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex2s.operator==(Vertex2s, Vertex2s)")]
		public void Vertex2s_TestOperatorEquality()
		{
			Vertex2s v = Vertex2s.UnitX;

			Assert.IsTrue(v == Vertex2s.UnitX);
			Assert.IsFalse(v == Vertex2s.UnitY);
		}

		[Test(Description = "Test Vertex2s.operator!=(Vertex2s, Vertex2s)")]
		public void Vertex2s_TestOperatorInequality()
		{
			Vertex2s v = Vertex2s.UnitX;

			Assert.IsFalse(v != Vertex2s.UnitX);
			Assert.IsTrue(v != Vertex2s.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex2s.operator short[](Vertex2s)")]
		public void Vertex2s_TestCastToArray()
		{
			Random random = new Random();
			
			short x = (short)Next(random);
			short y = (short)Next(random);

			Vertex2s v = new Vertex2s(x, y);
			short[] vArray = (short[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
		}

		[Test(Description = "Test Vertex2s.operator Vertex2f(Vertex2s)")]
		public void Vertex2s_TestCastToVertex2f()
		{
			Random random = new Random();
			
			short x = (short)Next(random);
			short y = (short)Next(random);

			Vertex2s v = new Vertex2s(x, y);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.x, (float)v2f.x, 1e-4f);
			Assert.AreEqual(v.y, (float)v2f.y, 1e-4f);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex2s.Module()")]
		public void Vertex2s_TestModule()
		{
			Assert.AreEqual(2.236068f, new Vertex2s((short)1.0, (short)2.0).Module(), 1e-4f);
			Assert.AreEqual(5.385165f, new Vertex2s((short)2.0, (short)5.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex2s.ModuleSquared()")]
		public void Vertex2s_TestModuleSquared()
		{
			Assert.AreEqual(5f, new Vertex2s((short)1.0, (short)2.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(29f, new Vertex2s((short)2.0, (short)5.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex2s.Normalize()")]
		public void Vertex2s_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex2s.Zero.Normalize(); });

			Vertex2s v;

			v = Vertex2s.UnitX * (short)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex2s.UnitX, v);

			v = Vertex2s.UnitY * (short)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex2s.UnitY, v);
		}

		[Test(Description = "Test Vertex2s.Normalized")]
		public void Vertex2s_TestNormalized()
		{
			Vertex2s v;

			Assert.DoesNotThrow(delegate() { v = Vertex2s.Zero.Normalized; });

			v = Vertex2s.UnitX * (short)2.0f;
			Assert.AreEqual(Vertex2s.UnitX, v.Normalized);

			v = Vertex2s.UnitY * (short)2.0f;
			Assert.AreEqual(Vertex2s.UnitY, v.Normalized);
		}

		[Test(Description = "Test Vertex2s.Min(Vertex2s[])")]
		public void Vertex2s_TestMin()
		{
			Vertex2s[] v = new Vertex2s[] {
				new Vertex2s((short)1.0f, (short)13.0f),
				new Vertex2s((short)2.0f, (short)12.0f),
				new Vertex2s((short)3.0f, (short)11.0f),
			};

			Vertex2s min = Vertex2s.Min(v);

			Assert.AreEqual(
				new Vertex2s((short)1.0f, (short)11.0f),
				min
			);
		}

		[Test(Description = "Test Vertex2s.Min(Vertex2s[]) ArgumentNullException")]
		public void Vertex2s_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2s.Min(null));
		}

		[Test(Description = "Test Vertex2s.Min(Vertex2s*)")]
		public void Vertex2s_TestMin_Unsafe()
		{
			Vertex2s[] v = new Vertex2s[] {
				new Vertex2s((short)1.0f, (short)13.0f),
				new Vertex2s((short)2.0f, (short)12.0f),
				new Vertex2s((short)3.0f, (short)11.0f),
			};

			Vertex2s min;

			unsafe {
				fixed (Vertex2s* vPtr = v) {
					min = Vertex2s.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex2s((short)1.0f, (short)11.0f),
				min
			);
		}

		[Test(Description = "Test Vertex2s.Min(Vertex2s*) ArgumentNullException")]
		public void Vertex2s_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2s.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex2s.Max(Vertex2s[])")]
		public void Vertex2s_TestMax()
		{
			Vertex2s[] v = new Vertex2s[] {
				new Vertex2s((short)1.0f, (short)13.0f),
				new Vertex2s((short)2.0f, (short)12.0f),
				new Vertex2s((short)3.0f, (short)11.0f),
			};

			Vertex2s max = Vertex2s.Max(v);

			Assert.AreEqual(
				new Vertex2s((short)3.0f, (short)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2s.Max(Vertex2s[]) ArgumentNullException")]
		public void Vertex2s_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2s.Max(null));
		}

		[Test(Description = "Test Vertex2s.Max(Vertex2s*)")]
		public void Vertex2s_TestMax_Unsafe()
		{
			Vertex2s[] v = new Vertex2s[] {
				new Vertex2s((short)1.0f, (short)13.0f),
				new Vertex2s((short)2.0f, (short)12.0f),
				new Vertex2s((short)3.0f, (short)11.0f),
			};

			Vertex2s max;

			unsafe {
				fixed (Vertex2s* vPtr = v) {
					max = Vertex2s.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex2s((short)3.0f, (short)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2s.Max(Vertex2s*) ArgumentNullException")]
		public void Vertex2s_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2s.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex2s.Max(Vertex2s[])")]
		public void Vertex2s_TestMinMax()
		{
			Vertex2s[] v = new Vertex2s[] {
				new Vertex2s((short)1.0f, (short)13.0f),
				new Vertex2s((short)2.0f, (short)12.0f),
				new Vertex2s((short)3.0f, (short)11.0f),
			};

			Vertex2s min, max;

			Vertex2s.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex2s((short)1.0f, (short)11.0f),
				min
			);
			Assert.AreEqual(
				new Vertex2s((short)3.0f, (short)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2s.Max(Vertex2s[]) ArgumentNullException")]
		public void Vertex2s_TestMinMax_ArgumentNullException()
		{
			Vertex2s min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex2s.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex2s.MinMax(Vertex2s*)")]
		public void Vertex2s_TestMinMax_Unsafe()
		{
			Vertex2s[] v = new Vertex2s[] {
				new Vertex2s((short)1.0f, (short)13.0f),
				new Vertex2s((short)2.0f, (short)12.0f),
				new Vertex2s((short)3.0f, (short)11.0f),
			};

			Vertex2s min, max;

			unsafe {
				fixed (Vertex2s* vPtr = v) {
					Vertex2s.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex2s((short)1.0f, (short)11.0f),
				min
			);
			Assert.AreEqual(
				new Vertex2s((short)3.0f, (short)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2s.MinMax(Vertex2s*) ArgumentNullException")]
		public void Vertex2s_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex2s min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2s.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex2s.Equals(Vertex2s)")]
		public void Vertex2s_TestEquals_Vertex2s()
		{
			Vertex2s v = Vertex2s.UnitX;

			Assert.IsTrue(v.Equals(Vertex2s.UnitX));
			Assert.IsFalse(v.Equals(Vertex2s.UnitY));
		}

		[Test(Description = "Test Vertex2s.Equals(object)")]
		public void Vertex2s_TestEquals_True()
		{
			Vertex2s v = Vertex2s.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex2s.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex2s.UnitY));
		}

		[Test(Description = "Test Vertex2s.GetHashCode()")]
		public void Vertex2s_TestGetHashCode()
		{
			Random random = new Random();
			
			short x = (short)Next(random);
			short y = (short)Next(random);

			Vertex2s v = new Vertex2s(x, y);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex2s.ToString()")]
		public void Vertex2s_TestToString()
		{
			Random random = new Random();
			
			short x = (short)Next(random);
			short y = (short)Next(random);

			Vertex2s v = new Vertex2s(x, y);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex2uiTest : Vertex2TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex2ui(uint)")]
		public void Vertex2ui_TestConstructor1()
		{
			Random random = new Random();
			uint randomValue = (uint)Next(random);
			
			Vertex2ui v = new Vertex2ui(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
		}

		[Test(Description = "Test Vertex2ui(uint[])")]
		public void Vertex2ui_TestConstructor2()
		{
			Random random = new Random();
			uint randomValueX = (uint)Next(random);
			uint randomValueY = (uint)Next(random);

			Vertex2ui v = new Vertex2ui(new uint[] {
				randomValueX, randomValueY
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
		}

		[Test(Description = "Test Vertex2ui(uint, uint, uint)")]
		public void Vertex2ui_TestConstructor3()
		{
			Random random = new Random();
			uint randomValueX = (uint)Next(random);
			uint randomValueY = (uint)Next(random);

			Vertex2ui v = new Vertex2ui(
				randomValueX, randomValueY
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex2ui.Size against Marshal.SizeOf")]
		public void Vertex2ui_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex2ui)), Vertex2ui.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex2ui.operator+(Vertex2ui, Vertex2ui)")]
		public void Vertex2ui_TestOperatorAdd()
		{
			Random random = new Random();
			
			uint x1 = (uint)Next(random);
			uint y1 = (uint)Next(random);

			Vertex2ui v1 = new Vertex2ui(x1, y1);

			uint x2 = (uint)Next(random);
			uint y2 = (uint)Next(random);

			Vertex2ui v2 = new Vertex2ui(x2, y2);

			Vertex2ui v = v1 + v2;

			Assert.AreEqual((uint)(x1 + x2), v.x);
			Assert.AreEqual((uint)(y1 + y2), v.y);
		}

		[Test(Description = "Test Vertex2ui.operator-(Vertex2ui, Vertex2ui)")]
		public void Vertex2ui_TestOperatorSub()
		{
			Random random = new Random();
			
			uint x1 = (uint)Next(random);
			uint y1 = (uint)Next(random);

			Vertex2ui v1 = new Vertex2ui(x1, y1);

			uint x2 = (uint)Next(random);
			uint y2 = (uint)Next(random);

			Vertex2ui v2 = new Vertex2ui(x2, y2);

			Vertex2ui v = v1 - v2;

			Assert.AreEqual((uint)(x1 - x2), v.x);
			Assert.AreEqual((uint)(y1 - y2), v.y);
		}

		[Test(Description = "Test Vertex2ui.operator*(Vertex2ui, Single)")]
		public void Vertex2ui_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			uint x1 = (uint)Next(random);
			uint y1 = (uint)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex2ui v1 = new Vertex2ui(x1, y1);

			Vertex2ui v = v1 * (float)s;

			Assert.AreEqual((uint)(x1 * (float)s), v.x);
			Assert.AreEqual((uint)(y1 * (float)s), v.y);
		}

		[Test(Description = "Test Vertex2ui.operator*(Vertex2ui, Double)")]
		public void Vertex2ui_TestOperatorMultiplyDouble()
		{
			Random random = new Random();
			
			uint x1 = (uint)Next(random);
			uint y1 = (uint)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex2ui v1 = new Vertex2ui(x1, y1);

			Vertex2ui v = v1 * s;

			Assert.AreEqual((uint)(x1 * s), v.x);
			Assert.AreEqual((uint)(y1 * s), v.y);
		}

		[Test(Description = "Test Vertex2ui.operator/(Vertex2ui, Single)")]
		public void Vertex2ui_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			uint x1 = (uint)Next(random);
			uint y1 = (uint)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex2ui v1 = new Vertex2ui(x1, y1);

			Vertex2ui v = v1 / (float)s;

			Assert.AreEqual((uint)(x1 / (float)s), v.x);
			Assert.AreEqual((uint)(y1 / (float)s), v.y);
		}

		[Test(Description = "Test Vertex2ui.operator/(Vertex2ui, Double)")]
		public void Vertex2ui_TestOperatorDivideDouble()
		{
			Random random = new Random();
			
			uint x1 = (uint)Next(random);
			uint y1 = (uint)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex2ui v1 = new Vertex2ui(x1, y1);

			Vertex2ui v = v1 / s;

			Assert.AreEqual((uint)(x1 / s), v.x);
			Assert.AreEqual((uint)(y1 / s), v.y);
		}

		[Test(Description = "Test Vertex2ui.operator*(Vertex2ui, uint)")]
		public void Vertex2ui_TestOperatorScalarMultiply()
		{
			Random random = new Random();
			
			uint x1 = (uint)Next(random);
			uint y1 = (uint)Next(random);
			uint s = (uint)Next(random, 0.0, 32.0);

			Vertex2ui v1 = new Vertex2ui(x1, y1);

			Vertex2ui v = v1 * s;

			Assert.AreEqual((uint)(x1 * s), v.x);
			Assert.AreEqual((uint)(y1 * s), v.y);
		}

		[Test(Description = "Test Vertex2ui.operator/(Vertex2ui, uint)")]
		public void Vertex2ui_TestOperatorScalarDivide()
		{
			Random random = new Random();
			
			uint x1 = (uint)Next(random);
			uint y1 = (uint)Next(random);
			uint s = (uint)Next(random, 1.0, 32.0);

			Vertex2ui v1 = new Vertex2ui(x1, y1);

			Vertex2ui v = v1 / s;

			Assert.AreEqual((uint)(x1 / s), v.x);
			Assert.AreEqual((uint)(y1 / s), v.y);
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex2ui.operator==(Vertex2ui, Vertex2ui)")]
		public void Vertex2ui_TestOperatorEquality()
		{
			Vertex2ui v = Vertex2ui.UnitX;

			Assert.IsTrue(v == Vertex2ui.UnitX);
			Assert.IsFalse(v == Vertex2ui.UnitY);
		}

		[Test(Description = "Test Vertex2ui.operator!=(Vertex2ui, Vertex2ui)")]
		public void Vertex2ui_TestOperatorInequality()
		{
			Vertex2ui v = Vertex2ui.UnitX;

			Assert.IsFalse(v != Vertex2ui.UnitX);
			Assert.IsTrue(v != Vertex2ui.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex2ui.operator uint[](Vertex2ui)")]
		public void Vertex2ui_TestCastToArray()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random);
			uint y = (uint)Next(random);

			Vertex2ui v = new Vertex2ui(x, y);
			uint[] vArray = (uint[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
		}

		[Test(Description = "Test Vertex2ui.operator Vertex2f(Vertex2ui)")]
		public void Vertex2ui_TestCastToVertex2f()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random);
			uint y = (uint)Next(random);

			Vertex2ui v = new Vertex2ui(x, y);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.x, (float)v2f.x, 1e-4f);
			Assert.AreEqual(v.y, (float)v2f.y, 1e-4f);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex2ui.Module()")]
		public void Vertex2ui_TestModule()
		{
			Assert.AreEqual(2.236068f, new Vertex2ui((uint)1.0, (uint)2.0).Module(), 1e-4f);
			Assert.AreEqual(5.385165f, new Vertex2ui((uint)2.0, (uint)5.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex2ui.ModuleSquared()")]
		public void Vertex2ui_TestModuleSquared()
		{
			Assert.AreEqual(5f, new Vertex2ui((uint)1.0, (uint)2.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(29f, new Vertex2ui((uint)2.0, (uint)5.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex2ui.Normalize()")]
		public void Vertex2ui_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex2ui.Zero.Normalize(); });

			Vertex2ui v;

			v = Vertex2ui.UnitX * (uint)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex2ui.UnitX, v);

			v = Vertex2ui.UnitY * (uint)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex2ui.UnitY, v);
		}

		[Test(Description = "Test Vertex2ui.Normalized")]
		public void Vertex2ui_TestNormalized()
		{
			Vertex2ui v;

			Assert.DoesNotThrow(delegate() { v = Vertex2ui.Zero.Normalized; });

			v = Vertex2ui.UnitX * (uint)2.0f;
			Assert.AreEqual(Vertex2ui.UnitX, v.Normalized);

			v = Vertex2ui.UnitY * (uint)2.0f;
			Assert.AreEqual(Vertex2ui.UnitY, v.Normalized);
		}

		[Test(Description = "Test Vertex2ui.Min(Vertex2ui[])")]
		public void Vertex2ui_TestMin()
		{
			Vertex2ui[] v = new Vertex2ui[] {
				new Vertex2ui((uint)1.0f, (uint)13.0f),
				new Vertex2ui((uint)2.0f, (uint)12.0f),
				new Vertex2ui((uint)3.0f, (uint)11.0f),
			};

			Vertex2ui min = Vertex2ui.Min(v);

			Assert.AreEqual(
				new Vertex2ui((uint)1.0f, (uint)11.0f),
				min
			);
		}

		[Test(Description = "Test Vertex2ui.Min(Vertex2ui[]) ArgumentNullException")]
		public void Vertex2ui_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2ui.Min(null));
		}

		[Test(Description = "Test Vertex2ui.Min(Vertex2ui*)")]
		public void Vertex2ui_TestMin_Unsafe()
		{
			Vertex2ui[] v = new Vertex2ui[] {
				new Vertex2ui((uint)1.0f, (uint)13.0f),
				new Vertex2ui((uint)2.0f, (uint)12.0f),
				new Vertex2ui((uint)3.0f, (uint)11.0f),
			};

			Vertex2ui min;

			unsafe {
				fixed (Vertex2ui* vPtr = v) {
					min = Vertex2ui.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex2ui((uint)1.0f, (uint)11.0f),
				min
			);
		}

		[Test(Description = "Test Vertex2ui.Min(Vertex2ui*) ArgumentNullException")]
		public void Vertex2ui_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2ui.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex2ui.Max(Vertex2ui[])")]
		public void Vertex2ui_TestMax()
		{
			Vertex2ui[] v = new Vertex2ui[] {
				new Vertex2ui((uint)1.0f, (uint)13.0f),
				new Vertex2ui((uint)2.0f, (uint)12.0f),
				new Vertex2ui((uint)3.0f, (uint)11.0f),
			};

			Vertex2ui max = Vertex2ui.Max(v);

			Assert.AreEqual(
				new Vertex2ui((uint)3.0f, (uint)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2ui.Max(Vertex2ui[]) ArgumentNullException")]
		public void Vertex2ui_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2ui.Max(null));
		}

		[Test(Description = "Test Vertex2ui.Max(Vertex2ui*)")]
		public void Vertex2ui_TestMax_Unsafe()
		{
			Vertex2ui[] v = new Vertex2ui[] {
				new Vertex2ui((uint)1.0f, (uint)13.0f),
				new Vertex2ui((uint)2.0f, (uint)12.0f),
				new Vertex2ui((uint)3.0f, (uint)11.0f),
			};

			Vertex2ui max;

			unsafe {
				fixed (Vertex2ui* vPtr = v) {
					max = Vertex2ui.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex2ui((uint)3.0f, (uint)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2ui.Max(Vertex2ui*) ArgumentNullException")]
		public void Vertex2ui_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2ui.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex2ui.Max(Vertex2ui[])")]
		public void Vertex2ui_TestMinMax()
		{
			Vertex2ui[] v = new Vertex2ui[] {
				new Vertex2ui((uint)1.0f, (uint)13.0f),
				new Vertex2ui((uint)2.0f, (uint)12.0f),
				new Vertex2ui((uint)3.0f, (uint)11.0f),
			};

			Vertex2ui min, max;

			Vertex2ui.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex2ui((uint)1.0f, (uint)11.0f),
				min
			);
			Assert.AreEqual(
				new Vertex2ui((uint)3.0f, (uint)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2ui.Max(Vertex2ui[]) ArgumentNullException")]
		public void Vertex2ui_TestMinMax_ArgumentNullException()
		{
			Vertex2ui min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex2ui.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex2ui.MinMax(Vertex2ui*)")]
		public void Vertex2ui_TestMinMax_Unsafe()
		{
			Vertex2ui[] v = new Vertex2ui[] {
				new Vertex2ui((uint)1.0f, (uint)13.0f),
				new Vertex2ui((uint)2.0f, (uint)12.0f),
				new Vertex2ui((uint)3.0f, (uint)11.0f),
			};

			Vertex2ui min, max;

			unsafe {
				fixed (Vertex2ui* vPtr = v) {
					Vertex2ui.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex2ui((uint)1.0f, (uint)11.0f),
				min
			);
			Assert.AreEqual(
				new Vertex2ui((uint)3.0f, (uint)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2ui.MinMax(Vertex2ui*) ArgumentNullException")]
		public void Vertex2ui_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex2ui min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2ui.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex2ui.Equals(Vertex2ui)")]
		public void Vertex2ui_TestEquals_Vertex2ui()
		{
			Vertex2ui v = Vertex2ui.UnitX;

			Assert.IsTrue(v.Equals(Vertex2ui.UnitX));
			Assert.IsFalse(v.Equals(Vertex2ui.UnitY));
		}

		[Test(Description = "Test Vertex2ui.Equals(object)")]
		public void Vertex2ui_TestEquals_True()
		{
			Vertex2ui v = Vertex2ui.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex2ui.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex2ui.UnitY));
		}

		[Test(Description = "Test Vertex2ui.GetHashCode()")]
		public void Vertex2ui_TestGetHashCode()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random);
			uint y = (uint)Next(random);

			Vertex2ui v = new Vertex2ui(x, y);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex2ui.ToString()")]
		public void Vertex2ui_TestToString()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random);
			uint y = (uint)Next(random);

			Vertex2ui v = new Vertex2ui(x, y);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex2iTest : Vertex2TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex2i(int)")]
		public void Vertex2i_TestConstructor1()
		{
			Random random = new Random();
			int randomValue = (int)Next(random);
			
			Vertex2i v = new Vertex2i(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
		}

		[Test(Description = "Test Vertex2i(int[])")]
		public void Vertex2i_TestConstructor2()
		{
			Random random = new Random();
			int randomValueX = (int)Next(random);
			int randomValueY = (int)Next(random);

			Vertex2i v = new Vertex2i(new int[] {
				randomValueX, randomValueY
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
		}

		[Test(Description = "Test Vertex2i(int, int, int)")]
		public void Vertex2i_TestConstructor3()
		{
			Random random = new Random();
			int randomValueX = (int)Next(random);
			int randomValueY = (int)Next(random);

			Vertex2i v = new Vertex2i(
				randomValueX, randomValueY
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex2i.Size against Marshal.SizeOf")]
		public void Vertex2i_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex2i)), Vertex2i.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex2i.operator-(Vertex2i))")]
		public void Vertex2i_TestOperatorNegate()
		{
			Random random = new Random();
			
			int x = (int)Next(random);
			int y = (int)Next(random);

			Vertex2i v = new Vertex2i(x, y);
			Vertex2i n = -v;

			Assert.AreEqual(-x, n.x);
			Assert.AreEqual(-y, n.y);
		}
		[Test(Description = "Test Vertex2i.operator+(Vertex2i, Vertex2i)")]
		public void Vertex2i_TestOperatorAdd()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random);
			int y1 = (int)Next(random);

			Vertex2i v1 = new Vertex2i(x1, y1);

			int x2 = (int)Next(random);
			int y2 = (int)Next(random);

			Vertex2i v2 = new Vertex2i(x2, y2);

			Vertex2i v = v1 + v2;

			Assert.AreEqual((int)(x1 + x2), v.x);
			Assert.AreEqual((int)(y1 + y2), v.y);
		}

		[Test(Description = "Test Vertex2i.operator-(Vertex2i, Vertex2i)")]
		public void Vertex2i_TestOperatorSub()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random);
			int y1 = (int)Next(random);

			Vertex2i v1 = new Vertex2i(x1, y1);

			int x2 = (int)Next(random);
			int y2 = (int)Next(random);

			Vertex2i v2 = new Vertex2i(x2, y2);

			Vertex2i v = v1 - v2;

			Assert.AreEqual((int)(x1 - x2), v.x);
			Assert.AreEqual((int)(y1 - y2), v.y);
		}

		[Test(Description = "Test Vertex2i.operator*(Vertex2i, Single)")]
		public void Vertex2i_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random);
			int y1 = (int)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex2i v1 = new Vertex2i(x1, y1);

			Vertex2i v = v1 * (float)s;

			Assert.AreEqual((int)(x1 * (float)s), v.x);
			Assert.AreEqual((int)(y1 * (float)s), v.y);
		}

		[Test(Description = "Test Vertex2i.operator*(Vertex2i, Double)")]
		public void Vertex2i_TestOperatorMultiplyDouble()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random);
			int y1 = (int)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex2i v1 = new Vertex2i(x1, y1);

			Vertex2i v = v1 * s;

			Assert.AreEqual((int)(x1 * s), v.x);
			Assert.AreEqual((int)(y1 * s), v.y);
		}

		[Test(Description = "Test Vertex2i.operator/(Vertex2i, Single)")]
		public void Vertex2i_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random);
			int y1 = (int)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex2i v1 = new Vertex2i(x1, y1);

			Vertex2i v = v1 / (float)s;

			Assert.AreEqual((int)(x1 / (float)s), v.x);
			Assert.AreEqual((int)(y1 / (float)s), v.y);
		}

		[Test(Description = "Test Vertex2i.operator/(Vertex2i, Double)")]
		public void Vertex2i_TestOperatorDivideDouble()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random);
			int y1 = (int)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex2i v1 = new Vertex2i(x1, y1);

			Vertex2i v = v1 / s;

			Assert.AreEqual((int)(x1 / s), v.x);
			Assert.AreEqual((int)(y1 / s), v.y);
		}

		[Test(Description = "Test Vertex2i.operator*(Vertex2i, int)")]
		public void Vertex2i_TestOperatorScalarMultiply()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random);
			int y1 = (int)Next(random);
			int s = (int)Next(random, 0.0, 32.0);

			Vertex2i v1 = new Vertex2i(x1, y1);

			Vertex2i v = v1 * s;

			Assert.AreEqual((int)(x1 * s), v.x);
			Assert.AreEqual((int)(y1 * s), v.y);
		}

		[Test(Description = "Test Vertex2i.operator/(Vertex2i, int)")]
		public void Vertex2i_TestOperatorScalarDivide()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random);
			int y1 = (int)Next(random);
			int s = (int)Next(random, 1.0, 32.0);

			Vertex2i v1 = new Vertex2i(x1, y1);

			Vertex2i v = v1 / s;

			Assert.AreEqual((int)(x1 / s), v.x);
			Assert.AreEqual((int)(y1 / s), v.y);
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex2i.operator==(Vertex2i, Vertex2i)")]
		public void Vertex2i_TestOperatorEquality()
		{
			Vertex2i v = Vertex2i.UnitX;

			Assert.IsTrue(v == Vertex2i.UnitX);
			Assert.IsFalse(v == Vertex2i.UnitY);
		}

		[Test(Description = "Test Vertex2i.operator!=(Vertex2i, Vertex2i)")]
		public void Vertex2i_TestOperatorInequality()
		{
			Vertex2i v = Vertex2i.UnitX;

			Assert.IsFalse(v != Vertex2i.UnitX);
			Assert.IsTrue(v != Vertex2i.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex2i.operator int[](Vertex2i)")]
		public void Vertex2i_TestCastToArray()
		{
			Random random = new Random();
			
			int x = (int)Next(random);
			int y = (int)Next(random);

			Vertex2i v = new Vertex2i(x, y);
			int[] vArray = (int[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
		}

		[Test(Description = "Test Vertex2i.operator Vertex2f(Vertex2i)")]
		public void Vertex2i_TestCastToVertex2f()
		{
			Random random = new Random();
			
			int x = (int)Next(random);
			int y = (int)Next(random);

			Vertex2i v = new Vertex2i(x, y);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.x, (float)v2f.x, 1e-4f);
			Assert.AreEqual(v.y, (float)v2f.y, 1e-4f);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex2i.Module()")]
		public void Vertex2i_TestModule()
		{
			Assert.AreEqual(2.236068f, new Vertex2i((int)1.0, (int)2.0).Module(), 1e-4f);
			Assert.AreEqual(5.385165f, new Vertex2i((int)2.0, (int)5.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex2i.ModuleSquared()")]
		public void Vertex2i_TestModuleSquared()
		{
			Assert.AreEqual(5f, new Vertex2i((int)1.0, (int)2.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(29f, new Vertex2i((int)2.0, (int)5.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex2i.Normalize()")]
		public void Vertex2i_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex2i.Zero.Normalize(); });

			Vertex2i v;

			v = Vertex2i.UnitX * (int)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex2i.UnitX, v);

			v = Vertex2i.UnitY * (int)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex2i.UnitY, v);
		}

		[Test(Description = "Test Vertex2i.Normalized")]
		public void Vertex2i_TestNormalized()
		{
			Vertex2i v;

			Assert.DoesNotThrow(delegate() { v = Vertex2i.Zero.Normalized; });

			v = Vertex2i.UnitX * (int)2.0f;
			Assert.AreEqual(Vertex2i.UnitX, v.Normalized);

			v = Vertex2i.UnitY * (int)2.0f;
			Assert.AreEqual(Vertex2i.UnitY, v.Normalized);
		}

		[Test(Description = "Test Vertex2i.Min(Vertex2i[])")]
		public void Vertex2i_TestMin()
		{
			Vertex2i[] v = new Vertex2i[] {
				new Vertex2i((int)1.0f, (int)13.0f),
				new Vertex2i((int)2.0f, (int)12.0f),
				new Vertex2i((int)3.0f, (int)11.0f),
			};

			Vertex2i min = Vertex2i.Min(v);

			Assert.AreEqual(
				new Vertex2i((int)1.0f, (int)11.0f),
				min
			);
		}

		[Test(Description = "Test Vertex2i.Min(Vertex2i[]) ArgumentNullException")]
		public void Vertex2i_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2i.Min(null));
		}

		[Test(Description = "Test Vertex2i.Min(Vertex2i*)")]
		public void Vertex2i_TestMin_Unsafe()
		{
			Vertex2i[] v = new Vertex2i[] {
				new Vertex2i((int)1.0f, (int)13.0f),
				new Vertex2i((int)2.0f, (int)12.0f),
				new Vertex2i((int)3.0f, (int)11.0f),
			};

			Vertex2i min;

			unsafe {
				fixed (Vertex2i* vPtr = v) {
					min = Vertex2i.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex2i((int)1.0f, (int)11.0f),
				min
			);
		}

		[Test(Description = "Test Vertex2i.Min(Vertex2i*) ArgumentNullException")]
		public void Vertex2i_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2i.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex2i.Max(Vertex2i[])")]
		public void Vertex2i_TestMax()
		{
			Vertex2i[] v = new Vertex2i[] {
				new Vertex2i((int)1.0f, (int)13.0f),
				new Vertex2i((int)2.0f, (int)12.0f),
				new Vertex2i((int)3.0f, (int)11.0f),
			};

			Vertex2i max = Vertex2i.Max(v);

			Assert.AreEqual(
				new Vertex2i((int)3.0f, (int)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2i.Max(Vertex2i[]) ArgumentNullException")]
		public void Vertex2i_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2i.Max(null));
		}

		[Test(Description = "Test Vertex2i.Max(Vertex2i*)")]
		public void Vertex2i_TestMax_Unsafe()
		{
			Vertex2i[] v = new Vertex2i[] {
				new Vertex2i((int)1.0f, (int)13.0f),
				new Vertex2i((int)2.0f, (int)12.0f),
				new Vertex2i((int)3.0f, (int)11.0f),
			};

			Vertex2i max;

			unsafe {
				fixed (Vertex2i* vPtr = v) {
					max = Vertex2i.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex2i((int)3.0f, (int)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2i.Max(Vertex2i*) ArgumentNullException")]
		public void Vertex2i_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2i.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex2i.Max(Vertex2i[])")]
		public void Vertex2i_TestMinMax()
		{
			Vertex2i[] v = new Vertex2i[] {
				new Vertex2i((int)1.0f, (int)13.0f),
				new Vertex2i((int)2.0f, (int)12.0f),
				new Vertex2i((int)3.0f, (int)11.0f),
			};

			Vertex2i min, max;

			Vertex2i.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex2i((int)1.0f, (int)11.0f),
				min
			);
			Assert.AreEqual(
				new Vertex2i((int)3.0f, (int)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2i.Max(Vertex2i[]) ArgumentNullException")]
		public void Vertex2i_TestMinMax_ArgumentNullException()
		{
			Vertex2i min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex2i.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex2i.MinMax(Vertex2i*)")]
		public void Vertex2i_TestMinMax_Unsafe()
		{
			Vertex2i[] v = new Vertex2i[] {
				new Vertex2i((int)1.0f, (int)13.0f),
				new Vertex2i((int)2.0f, (int)12.0f),
				new Vertex2i((int)3.0f, (int)11.0f),
			};

			Vertex2i min, max;

			unsafe {
				fixed (Vertex2i* vPtr = v) {
					Vertex2i.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex2i((int)1.0f, (int)11.0f),
				min
			);
			Assert.AreEqual(
				new Vertex2i((int)3.0f, (int)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2i.MinMax(Vertex2i*) ArgumentNullException")]
		public void Vertex2i_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex2i min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2i.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex2i.Equals(Vertex2i)")]
		public void Vertex2i_TestEquals_Vertex2i()
		{
			Vertex2i v = Vertex2i.UnitX;

			Assert.IsTrue(v.Equals(Vertex2i.UnitX));
			Assert.IsFalse(v.Equals(Vertex2i.UnitY));
		}

		[Test(Description = "Test Vertex2i.Equals(object)")]
		public void Vertex2i_TestEquals_True()
		{
			Vertex2i v = Vertex2i.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex2i.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex2i.UnitY));
		}

		[Test(Description = "Test Vertex2i.GetHashCode()")]
		public void Vertex2i_TestGetHashCode()
		{
			Random random = new Random();
			
			int x = (int)Next(random);
			int y = (int)Next(random);

			Vertex2i v = new Vertex2i(x, y);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex2i.ToString()")]
		public void Vertex2i_TestToString()
		{
			Random random = new Random();
			
			int x = (int)Next(random);
			int y = (int)Next(random);

			Vertex2i v = new Vertex2i(x, y);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex2fTest : Vertex2TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex2f(float)")]
		public void Vertex2f_TestConstructor1()
		{
			Random random = new Random();
			float randomValue = (float)Next(random);
			
			Vertex2f v = new Vertex2f(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
		}

		[Test(Description = "Test Vertex2f(float[])")]
		public void Vertex2f_TestConstructor2()
		{
			Random random = new Random();
			float randomValueX = (float)Next(random);
			float randomValueY = (float)Next(random);

			Vertex2f v = new Vertex2f(new float[] {
				randomValueX, randomValueY
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
		}

		[Test(Description = "Test Vertex2f(float, float, float)")]
		public void Vertex2f_TestConstructor3()
		{
			Random random = new Random();
			float randomValueX = (float)Next(random);
			float randomValueY = (float)Next(random);

			Vertex2f v = new Vertex2f(
				randomValueX, randomValueY
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex2f.Size against Marshal.SizeOf")]
		public void Vertex2f_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex2f)), Vertex2f.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex2f.operator-(Vertex2f))")]
		public void Vertex2f_TestOperatorNegate()
		{
			Random random = new Random();
			
			float x = (float)Next(random);
			float y = (float)Next(random);

			Vertex2f v = new Vertex2f(x, y);
			Vertex2f n = -v;

			Assert.AreEqual(-x, n.x);
			Assert.AreEqual(-y, n.y);
		}
		[Test(Description = "Test Vertex2f.operator+(Vertex2f, Vertex2f)")]
		public void Vertex2f_TestOperatorAdd()
		{
			Random random = new Random();
			
			float x1 = (float)Next(random);
			float y1 = (float)Next(random);

			Vertex2f v1 = new Vertex2f(x1, y1);

			float x2 = (float)Next(random);
			float y2 = (float)Next(random);

			Vertex2f v2 = new Vertex2f(x2, y2);

			Vertex2f v = v1 + v2;

			Assert.AreEqual((float)(x1 + x2), v.x);
			Assert.AreEqual((float)(y1 + y2), v.y);
		}

		[Test(Description = "Test Vertex2f.operator-(Vertex2f, Vertex2f)")]
		public void Vertex2f_TestOperatorSub()
		{
			Random random = new Random();
			
			float x1 = (float)Next(random);
			float y1 = (float)Next(random);

			Vertex2f v1 = new Vertex2f(x1, y1);

			float x2 = (float)Next(random);
			float y2 = (float)Next(random);

			Vertex2f v2 = new Vertex2f(x2, y2);

			Vertex2f v = v1 - v2;

			Assert.AreEqual((float)(x1 - x2), v.x);
			Assert.AreEqual((float)(y1 - y2), v.y);
		}

		[Test(Description = "Test Vertex2f.operator*(Vertex2f, Single)")]
		public void Vertex2f_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			float x1 = (float)Next(random);
			float y1 = (float)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex2f v1 = new Vertex2f(x1, y1);

			Vertex2f v = v1 * (float)s;

			Assert.AreEqual((float)(x1 * (float)s), v.x);
			Assert.AreEqual((float)(y1 * (float)s), v.y);
		}

		[Test(Description = "Test Vertex2f.operator*(Vertex2f, Double)")]
		public void Vertex2f_TestOperatorMultiplyDouble()
		{
			Random random = new Random();
			
			float x1 = (float)Next(random);
			float y1 = (float)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex2f v1 = new Vertex2f(x1, y1);

			Vertex2f v = v1 * s;

			Assert.AreEqual((float)(x1 * s), v.x);
			Assert.AreEqual((float)(y1 * s), v.y);
		}

		[Test(Description = "Test Vertex2f.operator/(Vertex2f, Single)")]
		public void Vertex2f_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			float x1 = (float)Next(random);
			float y1 = (float)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex2f v1 = new Vertex2f(x1, y1);

			Vertex2f v = v1 / (float)s;

			Assert.AreEqual((float)(x1 / (float)s), v.x);
			Assert.AreEqual((float)(y1 / (float)s), v.y);
		}

		[Test(Description = "Test Vertex2f.operator/(Vertex2f, Double)")]
		public void Vertex2f_TestOperatorDivideDouble()
		{
			Random random = new Random();
			
			float x1 = (float)Next(random);
			float y1 = (float)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex2f v1 = new Vertex2f(x1, y1);

			Vertex2f v = v1 / s;

			Assert.AreEqual((float)(x1 / s), v.x);
			Assert.AreEqual((float)(y1 / s), v.y);
		}


		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex2f.operator==(Vertex2f, Vertex2f)")]
		public void Vertex2f_TestOperatorEquality()
		{
			Vertex2f v = Vertex2f.UnitX;

			Assert.IsTrue(v == Vertex2f.UnitX);
			Assert.IsFalse(v == Vertex2f.UnitY);
		}

		[Test(Description = "Test Vertex2f.operator!=(Vertex2f, Vertex2f)")]
		public void Vertex2f_TestOperatorInequality()
		{
			Vertex2f v = Vertex2f.UnitX;

			Assert.IsFalse(v != Vertex2f.UnitX);
			Assert.IsTrue(v != Vertex2f.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex2f.operator float[](Vertex2f)")]
		public void Vertex2f_TestCastToArray()
		{
			Random random = new Random();
			
			float x = (float)Next(random);
			float y = (float)Next(random);

			Vertex2f v = new Vertex2f(x, y);
			float[] vArray = (float[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
		}

		[Test(Description = "Test Vertex2f.operator Vertex2f(Vertex2f)")]
		public void Vertex2f_TestCastToVertex2f()
		{
			Random random = new Random();
			
			float x = (float)Next(random);
			float y = (float)Next(random);

			Vertex2f v = new Vertex2f(x, y);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.x, (float)v2f.x, 1e-4f);
			Assert.AreEqual(v.y, (float)v2f.y, 1e-4f);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex2f.Module()")]
		public void Vertex2f_TestModule()
		{
			Assert.AreEqual(2.236068f, new Vertex2f((float)1.0, (float)2.0).Module(), 1e-4f);
			Assert.AreEqual(5.385165f, new Vertex2f((float)2.0, (float)5.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex2f.ModuleSquared()")]
		public void Vertex2f_TestModuleSquared()
		{
			Assert.AreEqual(5f, new Vertex2f((float)1.0, (float)2.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(29f, new Vertex2f((float)2.0, (float)5.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex2f.Normalize()")]
		public void Vertex2f_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex2f.Zero.Normalize(); });

			Vertex2f v;

			v = Vertex2f.UnitX * (float)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex2f.UnitX, v);

			v = Vertex2f.UnitY * (float)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex2f.UnitY, v);
		}

		[Test(Description = "Test Vertex2f.Normalized")]
		public void Vertex2f_TestNormalized()
		{
			Vertex2f v;

			Assert.DoesNotThrow(delegate() { v = Vertex2f.Zero.Normalized; });

			v = Vertex2f.UnitX * (float)2.0f;
			Assert.AreEqual(Vertex2f.UnitX, v.Normalized);

			v = Vertex2f.UnitY * (float)2.0f;
			Assert.AreEqual(Vertex2f.UnitY, v.Normalized);
		}

		[Test(Description = "Test Vertex2f.Min(Vertex2f[])")]
		public void Vertex2f_TestMin()
		{
			Vertex2f[] v = new Vertex2f[] {
				new Vertex2f((float)1.0f, (float)13.0f),
				new Vertex2f((float)2.0f, (float)12.0f),
				new Vertex2f((float)3.0f, (float)11.0f),
			};

			Vertex2f min = Vertex2f.Min(v);

			Assert.AreEqual(
				new Vertex2f((float)1.0f, (float)11.0f),
				min
			);
		}

		[Test(Description = "Test Vertex2f.Min(Vertex2f[]) ArgumentNullException")]
		public void Vertex2f_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2f.Min(null));
		}

		[Test(Description = "Test Vertex2f.Min(Vertex2f*)")]
		public void Vertex2f_TestMin_Unsafe()
		{
			Vertex2f[] v = new Vertex2f[] {
				new Vertex2f((float)1.0f, (float)13.0f),
				new Vertex2f((float)2.0f, (float)12.0f),
				new Vertex2f((float)3.0f, (float)11.0f),
			};

			Vertex2f min;

			unsafe {
				fixed (Vertex2f* vPtr = v) {
					min = Vertex2f.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex2f((float)1.0f, (float)11.0f),
				min
			);
		}

		[Test(Description = "Test Vertex2f.Min(Vertex2f*) ArgumentNullException")]
		public void Vertex2f_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2f.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex2f.Max(Vertex2f[])")]
		public void Vertex2f_TestMax()
		{
			Vertex2f[] v = new Vertex2f[] {
				new Vertex2f((float)1.0f, (float)13.0f),
				new Vertex2f((float)2.0f, (float)12.0f),
				new Vertex2f((float)3.0f, (float)11.0f),
			};

			Vertex2f max = Vertex2f.Max(v);

			Assert.AreEqual(
				new Vertex2f((float)3.0f, (float)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2f.Max(Vertex2f[]) ArgumentNullException")]
		public void Vertex2f_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2f.Max(null));
		}

		[Test(Description = "Test Vertex2f.Max(Vertex2f*)")]
		public void Vertex2f_TestMax_Unsafe()
		{
			Vertex2f[] v = new Vertex2f[] {
				new Vertex2f((float)1.0f, (float)13.0f),
				new Vertex2f((float)2.0f, (float)12.0f),
				new Vertex2f((float)3.0f, (float)11.0f),
			};

			Vertex2f max;

			unsafe {
				fixed (Vertex2f* vPtr = v) {
					max = Vertex2f.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex2f((float)3.0f, (float)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2f.Max(Vertex2f*) ArgumentNullException")]
		public void Vertex2f_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2f.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex2f.Max(Vertex2f[])")]
		public void Vertex2f_TestMinMax()
		{
			Vertex2f[] v = new Vertex2f[] {
				new Vertex2f((float)1.0f, (float)13.0f),
				new Vertex2f((float)2.0f, (float)12.0f),
				new Vertex2f((float)3.0f, (float)11.0f),
			};

			Vertex2f min, max;

			Vertex2f.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex2f((float)1.0f, (float)11.0f),
				min
			);
			Assert.AreEqual(
				new Vertex2f((float)3.0f, (float)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2f.Max(Vertex2f[]) ArgumentNullException")]
		public void Vertex2f_TestMinMax_ArgumentNullException()
		{
			Vertex2f min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex2f.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex2f.MinMax(Vertex2f*)")]
		public void Vertex2f_TestMinMax_Unsafe()
		{
			Vertex2f[] v = new Vertex2f[] {
				new Vertex2f((float)1.0f, (float)13.0f),
				new Vertex2f((float)2.0f, (float)12.0f),
				new Vertex2f((float)3.0f, (float)11.0f),
			};

			Vertex2f min, max;

			unsafe {
				fixed (Vertex2f* vPtr = v) {
					Vertex2f.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex2f((float)1.0f, (float)11.0f),
				min
			);
			Assert.AreEqual(
				new Vertex2f((float)3.0f, (float)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2f.MinMax(Vertex2f*) ArgumentNullException")]
		public void Vertex2f_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex2f min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2f.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex2f.Equals(Vertex2f)")]
		public void Vertex2f_TestEquals_Vertex2f()
		{
			Vertex2f v = Vertex2f.UnitX;

			Assert.IsTrue(v.Equals(Vertex2f.UnitX));
			Assert.IsFalse(v.Equals(Vertex2f.UnitY));
		}

		[Test(Description = "Test Vertex2f.Equals(object)")]
		public void Vertex2f_TestEquals_True()
		{
			Vertex2f v = Vertex2f.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex2f.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex2f.UnitY));
		}

		[Test(Description = "Test Vertex2f.GetHashCode()")]
		public void Vertex2f_TestGetHashCode()
		{
			Random random = new Random();
			
			float x = (float)Next(random);
			float y = (float)Next(random);

			Vertex2f v = new Vertex2f(x, y);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex2f.ToString()")]
		public void Vertex2f_TestToString()
		{
			Random random = new Random();
			
			float x = (float)Next(random);
			float y = (float)Next(random);

			Vertex2f v = new Vertex2f(x, y);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex2dTest : Vertex2TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex2d(double)")]
		public void Vertex2d_TestConstructor1()
		{
			Random random = new Random();
			double randomValue = (double)Next(random);
			
			Vertex2d v = new Vertex2d(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
		}

		[Test(Description = "Test Vertex2d(double[])")]
		public void Vertex2d_TestConstructor2()
		{
			Random random = new Random();
			double randomValueX = (double)Next(random);
			double randomValueY = (double)Next(random);

			Vertex2d v = new Vertex2d(new double[] {
				randomValueX, randomValueY
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
		}

		[Test(Description = "Test Vertex2d(double, double, double)")]
		public void Vertex2d_TestConstructor3()
		{
			Random random = new Random();
			double randomValueX = (double)Next(random);
			double randomValueY = (double)Next(random);

			Vertex2d v = new Vertex2d(
				randomValueX, randomValueY
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex2d.Size against Marshal.SizeOf")]
		public void Vertex2d_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex2d)), Vertex2d.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex2d.operator-(Vertex2d))")]
		public void Vertex2d_TestOperatorNegate()
		{
			Random random = new Random();
			
			double x = (double)Next(random);
			double y = (double)Next(random);

			Vertex2d v = new Vertex2d(x, y);
			Vertex2d n = -v;

			Assert.AreEqual(-x, n.x);
			Assert.AreEqual(-y, n.y);
		}
		[Test(Description = "Test Vertex2d.operator+(Vertex2d, Vertex2d)")]
		public void Vertex2d_TestOperatorAdd()
		{
			Random random = new Random();
			
			double x1 = (double)Next(random);
			double y1 = (double)Next(random);

			Vertex2d v1 = new Vertex2d(x1, y1);

			double x2 = (double)Next(random);
			double y2 = (double)Next(random);

			Vertex2d v2 = new Vertex2d(x2, y2);

			Vertex2d v = v1 + v2;

			Assert.AreEqual((double)(x1 + x2), v.x);
			Assert.AreEqual((double)(y1 + y2), v.y);
		}

		[Test(Description = "Test Vertex2d.operator-(Vertex2d, Vertex2d)")]
		public void Vertex2d_TestOperatorSub()
		{
			Random random = new Random();
			
			double x1 = (double)Next(random);
			double y1 = (double)Next(random);

			Vertex2d v1 = new Vertex2d(x1, y1);

			double x2 = (double)Next(random);
			double y2 = (double)Next(random);

			Vertex2d v2 = new Vertex2d(x2, y2);

			Vertex2d v = v1 - v2;

			Assert.AreEqual((double)(x1 - x2), v.x);
			Assert.AreEqual((double)(y1 - y2), v.y);
		}

		[Test(Description = "Test Vertex2d.operator*(Vertex2d, Single)")]
		public void Vertex2d_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			double x1 = (double)Next(random);
			double y1 = (double)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex2d v1 = new Vertex2d(x1, y1);

			Vertex2d v = v1 * (float)s;

			Assert.AreEqual((double)(x1 * (float)s), v.x);
			Assert.AreEqual((double)(y1 * (float)s), v.y);
		}

		[Test(Description = "Test Vertex2d.operator*(Vertex2d, Double)")]
		public void Vertex2d_TestOperatorMultiplyDouble()
		{
			Random random = new Random();
			
			double x1 = (double)Next(random);
			double y1 = (double)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex2d v1 = new Vertex2d(x1, y1);

			Vertex2d v = v1 * s;

			Assert.AreEqual((double)(x1 * s), v.x);
			Assert.AreEqual((double)(y1 * s), v.y);
		}

		[Test(Description = "Test Vertex2d.operator/(Vertex2d, Single)")]
		public void Vertex2d_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			double x1 = (double)Next(random);
			double y1 = (double)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex2d v1 = new Vertex2d(x1, y1);

			Vertex2d v = v1 / (float)s;

			Assert.AreEqual((double)(x1 / (float)s), v.x);
			Assert.AreEqual((double)(y1 / (float)s), v.y);
		}

		[Test(Description = "Test Vertex2d.operator/(Vertex2d, Double)")]
		public void Vertex2d_TestOperatorDivideDouble()
		{
			Random random = new Random();
			
			double x1 = (double)Next(random);
			double y1 = (double)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex2d v1 = new Vertex2d(x1, y1);

			Vertex2d v = v1 / s;

			Assert.AreEqual((double)(x1 / s), v.x);
			Assert.AreEqual((double)(y1 / s), v.y);
		}


		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex2d.operator==(Vertex2d, Vertex2d)")]
		public void Vertex2d_TestOperatorEquality()
		{
			Vertex2d v = Vertex2d.UnitX;

			Assert.IsTrue(v == Vertex2d.UnitX);
			Assert.IsFalse(v == Vertex2d.UnitY);
		}

		[Test(Description = "Test Vertex2d.operator!=(Vertex2d, Vertex2d)")]
		public void Vertex2d_TestOperatorInequality()
		{
			Vertex2d v = Vertex2d.UnitX;

			Assert.IsFalse(v != Vertex2d.UnitX);
			Assert.IsTrue(v != Vertex2d.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex2d.operator double[](Vertex2d)")]
		public void Vertex2d_TestCastToArray()
		{
			Random random = new Random();
			
			double x = (double)Next(random);
			double y = (double)Next(random);

			Vertex2d v = new Vertex2d(x, y);
			double[] vArray = (double[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
		}

		[Test(Description = "Test Vertex2d.operator Vertex2f(Vertex2d)")]
		public void Vertex2d_TestCastToVertex2f()
		{
			Random random = new Random();
			
			double x = (double)Next(random);
			double y = (double)Next(random);

			Vertex2d v = new Vertex2d(x, y);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.x, (float)v2f.x, 1e-4f);
			Assert.AreEqual(v.y, (float)v2f.y, 1e-4f);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex2d.Module()")]
		public void Vertex2d_TestModule()
		{
			Assert.AreEqual(2.236068f, new Vertex2d((double)1.0, (double)2.0).Module(), 1e-4f);
			Assert.AreEqual(5.385165f, new Vertex2d((double)2.0, (double)5.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex2d.ModuleSquared()")]
		public void Vertex2d_TestModuleSquared()
		{
			Assert.AreEqual(5f, new Vertex2d((double)1.0, (double)2.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(29f, new Vertex2d((double)2.0, (double)5.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex2d.Normalize()")]
		public void Vertex2d_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex2d.Zero.Normalize(); });

			Vertex2d v;

			v = Vertex2d.UnitX * (double)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex2d.UnitX, v);

			v = Vertex2d.UnitY * (double)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex2d.UnitY, v);
		}

		[Test(Description = "Test Vertex2d.Normalized")]
		public void Vertex2d_TestNormalized()
		{
			Vertex2d v;

			Assert.DoesNotThrow(delegate() { v = Vertex2d.Zero.Normalized; });

			v = Vertex2d.UnitX * (double)2.0f;
			Assert.AreEqual(Vertex2d.UnitX, v.Normalized);

			v = Vertex2d.UnitY * (double)2.0f;
			Assert.AreEqual(Vertex2d.UnitY, v.Normalized);
		}

		[Test(Description = "Test Vertex2d.Min(Vertex2d[])")]
		public void Vertex2d_TestMin()
		{
			Vertex2d[] v = new Vertex2d[] {
				new Vertex2d((double)1.0f, (double)13.0f),
				new Vertex2d((double)2.0f, (double)12.0f),
				new Vertex2d((double)3.0f, (double)11.0f),
			};

			Vertex2d min = Vertex2d.Min(v);

			Assert.AreEqual(
				new Vertex2d((double)1.0f, (double)11.0f),
				min
			);
		}

		[Test(Description = "Test Vertex2d.Min(Vertex2d[]) ArgumentNullException")]
		public void Vertex2d_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2d.Min(null));
		}

		[Test(Description = "Test Vertex2d.Min(Vertex2d*)")]
		public void Vertex2d_TestMin_Unsafe()
		{
			Vertex2d[] v = new Vertex2d[] {
				new Vertex2d((double)1.0f, (double)13.0f),
				new Vertex2d((double)2.0f, (double)12.0f),
				new Vertex2d((double)3.0f, (double)11.0f),
			};

			Vertex2d min;

			unsafe {
				fixed (Vertex2d* vPtr = v) {
					min = Vertex2d.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex2d((double)1.0f, (double)11.0f),
				min
			);
		}

		[Test(Description = "Test Vertex2d.Min(Vertex2d*) ArgumentNullException")]
		public void Vertex2d_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2d.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex2d.Max(Vertex2d[])")]
		public void Vertex2d_TestMax()
		{
			Vertex2d[] v = new Vertex2d[] {
				new Vertex2d((double)1.0f, (double)13.0f),
				new Vertex2d((double)2.0f, (double)12.0f),
				new Vertex2d((double)3.0f, (double)11.0f),
			};

			Vertex2d max = Vertex2d.Max(v);

			Assert.AreEqual(
				new Vertex2d((double)3.0f, (double)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2d.Max(Vertex2d[]) ArgumentNullException")]
		public void Vertex2d_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2d.Max(null));
		}

		[Test(Description = "Test Vertex2d.Max(Vertex2d*)")]
		public void Vertex2d_TestMax_Unsafe()
		{
			Vertex2d[] v = new Vertex2d[] {
				new Vertex2d((double)1.0f, (double)13.0f),
				new Vertex2d((double)2.0f, (double)12.0f),
				new Vertex2d((double)3.0f, (double)11.0f),
			};

			Vertex2d max;

			unsafe {
				fixed (Vertex2d* vPtr = v) {
					max = Vertex2d.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex2d((double)3.0f, (double)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2d.Max(Vertex2d*) ArgumentNullException")]
		public void Vertex2d_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2d.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex2d.Max(Vertex2d[])")]
		public void Vertex2d_TestMinMax()
		{
			Vertex2d[] v = new Vertex2d[] {
				new Vertex2d((double)1.0f, (double)13.0f),
				new Vertex2d((double)2.0f, (double)12.0f),
				new Vertex2d((double)3.0f, (double)11.0f),
			};

			Vertex2d min, max;

			Vertex2d.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex2d((double)1.0f, (double)11.0f),
				min
			);
			Assert.AreEqual(
				new Vertex2d((double)3.0f, (double)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2d.Max(Vertex2d[]) ArgumentNullException")]
		public void Vertex2d_TestMinMax_ArgumentNullException()
		{
			Vertex2d min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex2d.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex2d.MinMax(Vertex2d*)")]
		public void Vertex2d_TestMinMax_Unsafe()
		{
			Vertex2d[] v = new Vertex2d[] {
				new Vertex2d((double)1.0f, (double)13.0f),
				new Vertex2d((double)2.0f, (double)12.0f),
				new Vertex2d((double)3.0f, (double)11.0f),
			};

			Vertex2d min, max;

			unsafe {
				fixed (Vertex2d* vPtr = v) {
					Vertex2d.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex2d((double)1.0f, (double)11.0f),
				min
			);
			Assert.AreEqual(
				new Vertex2d((double)3.0f, (double)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2d.MinMax(Vertex2d*) ArgumentNullException")]
		public void Vertex2d_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex2d min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2d.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex2d.Equals(Vertex2d)")]
		public void Vertex2d_TestEquals_Vertex2d()
		{
			Vertex2d v = Vertex2d.UnitX;

			Assert.IsTrue(v.Equals(Vertex2d.UnitX));
			Assert.IsFalse(v.Equals(Vertex2d.UnitY));
		}

		[Test(Description = "Test Vertex2d.Equals(object)")]
		public void Vertex2d_TestEquals_True()
		{
			Vertex2d v = Vertex2d.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex2d.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex2d.UnitY));
		}

		[Test(Description = "Test Vertex2d.GetHashCode()")]
		public void Vertex2d_TestGetHashCode()
		{
			Random random = new Random();
			
			double x = (double)Next(random);
			double y = (double)Next(random);

			Vertex2d v = new Vertex2d(x, y);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex2d.ToString()")]
		public void Vertex2d_TestToString()
		{
			Random random = new Random();
			
			double x = (double)Next(random);
			double y = (double)Next(random);

			Vertex2d v = new Vertex2d(x, y);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex2hfTest : Vertex2TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex2hf(HalfFloat)")]
		public void Vertex2hf_TestConstructor1()
		{
			Random random = new Random();
			HalfFloat randomValue = (HalfFloat)Next(random);
			
			Vertex2hf v = new Vertex2hf(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
		}

		[Test(Description = "Test Vertex2hf(HalfFloat[])")]
		public void Vertex2hf_TestConstructor2()
		{
			Random random = new Random();
			HalfFloat randomValueX = (HalfFloat)Next(random);
			HalfFloat randomValueY = (HalfFloat)Next(random);

			Vertex2hf v = new Vertex2hf(new HalfFloat[] {
				randomValueX, randomValueY
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
		}

		[Test(Description = "Test Vertex2hf(HalfFloat, HalfFloat, HalfFloat)")]
		public void Vertex2hf_TestConstructor3()
		{
			Random random = new Random();
			HalfFloat randomValueX = (HalfFloat)Next(random);
			HalfFloat randomValueY = (HalfFloat)Next(random);

			Vertex2hf v = new Vertex2hf(
				randomValueX, randomValueY
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex2hf.Size against Marshal.SizeOf")]
		public void Vertex2hf_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex2hf)), Vertex2hf.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex2hf.operator+(Vertex2hf, Vertex2hf)")]
		public void Vertex2hf_TestOperatorAdd()
		{
			Random random = new Random();
			
			HalfFloat x1 = (HalfFloat)Next(random);
			HalfFloat y1 = (HalfFloat)Next(random);

			Vertex2hf v1 = new Vertex2hf(x1, y1);

			HalfFloat x2 = (HalfFloat)Next(random);
			HalfFloat y2 = (HalfFloat)Next(random);

			Vertex2hf v2 = new Vertex2hf(x2, y2);

			Vertex2hf v = v1 + v2;

			Assert.AreEqual((HalfFloat)(x1 + x2), v.x);
			Assert.AreEqual((HalfFloat)(y1 + y2), v.y);
		}

		[Test(Description = "Test Vertex2hf.operator-(Vertex2hf, Vertex2hf)")]
		public void Vertex2hf_TestOperatorSub()
		{
			Random random = new Random();
			
			HalfFloat x1 = (HalfFloat)Next(random);
			HalfFloat y1 = (HalfFloat)Next(random);

			Vertex2hf v1 = new Vertex2hf(x1, y1);

			HalfFloat x2 = (HalfFloat)Next(random);
			HalfFloat y2 = (HalfFloat)Next(random);

			Vertex2hf v2 = new Vertex2hf(x2, y2);

			Vertex2hf v = v1 - v2;

			Assert.AreEqual((HalfFloat)(x1 - x2), v.x);
			Assert.AreEqual((HalfFloat)(y1 - y2), v.y);
		}

		[Test(Description = "Test Vertex2hf.operator*(Vertex2hf, Single)")]
		public void Vertex2hf_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			HalfFloat x1 = (HalfFloat)Next(random);
			HalfFloat y1 = (HalfFloat)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex2hf v1 = new Vertex2hf(x1, y1);

			Vertex2hf v = v1 * (float)s;

			Assert.AreEqual((HalfFloat)(x1 * (float)s), v.x);
			Assert.AreEqual((HalfFloat)(y1 * (float)s), v.y);
		}

		[Test(Description = "Test Vertex2hf.operator*(Vertex2hf, Double)")]
		public void Vertex2hf_TestOperatorMultiplyDouble()
		{
			Random random = new Random();
			
			HalfFloat x1 = (HalfFloat)Next(random);
			HalfFloat y1 = (HalfFloat)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex2hf v1 = new Vertex2hf(x1, y1);

			Vertex2hf v = v1 * s;

			Assert.AreEqual((HalfFloat)(x1 * s), v.x);
			Assert.AreEqual((HalfFloat)(y1 * s), v.y);
		}

		[Test(Description = "Test Vertex2hf.operator/(Vertex2hf, Single)")]
		public void Vertex2hf_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			HalfFloat x1 = (HalfFloat)Next(random);
			HalfFloat y1 = (HalfFloat)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex2hf v1 = new Vertex2hf(x1, y1);

			Vertex2hf v = v1 / (float)s;

			Assert.AreEqual((HalfFloat)(x1 / (float)s), v.x);
			Assert.AreEqual((HalfFloat)(y1 / (float)s), v.y);
		}

		[Test(Description = "Test Vertex2hf.operator/(Vertex2hf, Double)")]
		public void Vertex2hf_TestOperatorDivideDouble()
		{
			Random random = new Random();
			
			HalfFloat x1 = (HalfFloat)Next(random);
			HalfFloat y1 = (HalfFloat)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex2hf v1 = new Vertex2hf(x1, y1);

			Vertex2hf v = v1 / s;

			Assert.AreEqual((HalfFloat)(x1 / s), v.x);
			Assert.AreEqual((HalfFloat)(y1 / s), v.y);
		}


		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex2hf.operator==(Vertex2hf, Vertex2hf)")]
		public void Vertex2hf_TestOperatorEquality()
		{
			Vertex2hf v = Vertex2hf.UnitX;

			Assert.IsTrue(v == Vertex2hf.UnitX);
			Assert.IsFalse(v == Vertex2hf.UnitY);
		}

		[Test(Description = "Test Vertex2hf.operator!=(Vertex2hf, Vertex2hf)")]
		public void Vertex2hf_TestOperatorInequality()
		{
			Vertex2hf v = Vertex2hf.UnitX;

			Assert.IsFalse(v != Vertex2hf.UnitX);
			Assert.IsTrue(v != Vertex2hf.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex2hf.operator HalfFloat[](Vertex2hf)")]
		public void Vertex2hf_TestCastToArray()
		{
			Random random = new Random();
			
			HalfFloat x = (HalfFloat)Next(random);
			HalfFloat y = (HalfFloat)Next(random);

			Vertex2hf v = new Vertex2hf(x, y);
			HalfFloat[] vArray = (HalfFloat[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
		}

		[Test(Description = "Test Vertex2hf.operator Vertex2f(Vertex2hf)")]
		public void Vertex2hf_TestCastToVertex2f()
		{
			Random random = new Random();
			
			HalfFloat x = (HalfFloat)Next(random);
			HalfFloat y = (HalfFloat)Next(random);

			Vertex2hf v = new Vertex2hf(x, y);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.x, (float)v2f.x, 1e-4f);
			Assert.AreEqual(v.y, (float)v2f.y, 1e-4f);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex2hf.Module()")]
		public void Vertex2hf_TestModule()
		{
			Assert.AreEqual(2.236068f, new Vertex2hf((HalfFloat)1.0, (HalfFloat)2.0).Module(), 1e-4f);
			Assert.AreEqual(5.385165f, new Vertex2hf((HalfFloat)2.0, (HalfFloat)5.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex2hf.ModuleSquared()")]
		public void Vertex2hf_TestModuleSquared()
		{
			Assert.AreEqual(5f, new Vertex2hf((HalfFloat)1.0, (HalfFloat)2.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(29f, new Vertex2hf((HalfFloat)2.0, (HalfFloat)5.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex2hf.Normalize()")]
		public void Vertex2hf_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex2hf.Zero.Normalize(); });

			Vertex2hf v;

			v = Vertex2hf.UnitX * (HalfFloat)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex2hf.UnitX, v);

			v = Vertex2hf.UnitY * (HalfFloat)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex2hf.UnitY, v);
		}

		[Test(Description = "Test Vertex2hf.Normalized")]
		public void Vertex2hf_TestNormalized()
		{
			Vertex2hf v;

			Assert.DoesNotThrow(delegate() { v = Vertex2hf.Zero.Normalized; });

			v = Vertex2hf.UnitX * (HalfFloat)2.0f;
			Assert.AreEqual(Vertex2hf.UnitX, v.Normalized);

			v = Vertex2hf.UnitY * (HalfFloat)2.0f;
			Assert.AreEqual(Vertex2hf.UnitY, v.Normalized);
		}

		[Test(Description = "Test Vertex2hf.Min(Vertex2hf[])")]
		public void Vertex2hf_TestMin()
		{
			Vertex2hf[] v = new Vertex2hf[] {
				new Vertex2hf((HalfFloat)1.0f, (HalfFloat)13.0f),
				new Vertex2hf((HalfFloat)2.0f, (HalfFloat)12.0f),
				new Vertex2hf((HalfFloat)3.0f, (HalfFloat)11.0f),
			};

			Vertex2hf min = Vertex2hf.Min(v);

			Assert.AreEqual(
				new Vertex2hf((HalfFloat)1.0f, (HalfFloat)11.0f),
				min
			);
		}

		[Test(Description = "Test Vertex2hf.Min(Vertex2hf[]) ArgumentNullException")]
		public void Vertex2hf_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2hf.Min(null));
		}

		[Test(Description = "Test Vertex2hf.Min(Vertex2hf*)")]
		public void Vertex2hf_TestMin_Unsafe()
		{
			Vertex2hf[] v = new Vertex2hf[] {
				new Vertex2hf((HalfFloat)1.0f, (HalfFloat)13.0f),
				new Vertex2hf((HalfFloat)2.0f, (HalfFloat)12.0f),
				new Vertex2hf((HalfFloat)3.0f, (HalfFloat)11.0f),
			};

			Vertex2hf min;

			unsafe {
				fixed (Vertex2hf* vPtr = v) {
					min = Vertex2hf.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex2hf((HalfFloat)1.0f, (HalfFloat)11.0f),
				min
			);
		}

		[Test(Description = "Test Vertex2hf.Min(Vertex2hf*) ArgumentNullException")]
		public void Vertex2hf_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2hf.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex2hf.Max(Vertex2hf[])")]
		public void Vertex2hf_TestMax()
		{
			Vertex2hf[] v = new Vertex2hf[] {
				new Vertex2hf((HalfFloat)1.0f, (HalfFloat)13.0f),
				new Vertex2hf((HalfFloat)2.0f, (HalfFloat)12.0f),
				new Vertex2hf((HalfFloat)3.0f, (HalfFloat)11.0f),
			};

			Vertex2hf max = Vertex2hf.Max(v);

			Assert.AreEqual(
				new Vertex2hf((HalfFloat)3.0f, (HalfFloat)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2hf.Max(Vertex2hf[]) ArgumentNullException")]
		public void Vertex2hf_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2hf.Max(null));
		}

		[Test(Description = "Test Vertex2hf.Max(Vertex2hf*)")]
		public void Vertex2hf_TestMax_Unsafe()
		{
			Vertex2hf[] v = new Vertex2hf[] {
				new Vertex2hf((HalfFloat)1.0f, (HalfFloat)13.0f),
				new Vertex2hf((HalfFloat)2.0f, (HalfFloat)12.0f),
				new Vertex2hf((HalfFloat)3.0f, (HalfFloat)11.0f),
			};

			Vertex2hf max;

			unsafe {
				fixed (Vertex2hf* vPtr = v) {
					max = Vertex2hf.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex2hf((HalfFloat)3.0f, (HalfFloat)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2hf.Max(Vertex2hf*) ArgumentNullException")]
		public void Vertex2hf_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2hf.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex2hf.Max(Vertex2hf[])")]
		public void Vertex2hf_TestMinMax()
		{
			Vertex2hf[] v = new Vertex2hf[] {
				new Vertex2hf((HalfFloat)1.0f, (HalfFloat)13.0f),
				new Vertex2hf((HalfFloat)2.0f, (HalfFloat)12.0f),
				new Vertex2hf((HalfFloat)3.0f, (HalfFloat)11.0f),
			};

			Vertex2hf min, max;

			Vertex2hf.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex2hf((HalfFloat)1.0f, (HalfFloat)11.0f),
				min
			);
			Assert.AreEqual(
				new Vertex2hf((HalfFloat)3.0f, (HalfFloat)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2hf.Max(Vertex2hf[]) ArgumentNullException")]
		public void Vertex2hf_TestMinMax_ArgumentNullException()
		{
			Vertex2hf min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex2hf.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex2hf.MinMax(Vertex2hf*)")]
		public void Vertex2hf_TestMinMax_Unsafe()
		{
			Vertex2hf[] v = new Vertex2hf[] {
				new Vertex2hf((HalfFloat)1.0f, (HalfFloat)13.0f),
				new Vertex2hf((HalfFloat)2.0f, (HalfFloat)12.0f),
				new Vertex2hf((HalfFloat)3.0f, (HalfFloat)11.0f),
			};

			Vertex2hf min, max;

			unsafe {
				fixed (Vertex2hf* vPtr = v) {
					Vertex2hf.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex2hf((HalfFloat)1.0f, (HalfFloat)11.0f),
				min
			);
			Assert.AreEqual(
				new Vertex2hf((HalfFloat)3.0f, (HalfFloat)13.0f),
				max
			);
		}

		[Test(Description = "Test Vertex2hf.MinMax(Vertex2hf*) ArgumentNullException")]
		public void Vertex2hf_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex2hf min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2hf.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex2hf.Equals(Vertex2hf)")]
		public void Vertex2hf_TestEquals_Vertex2hf()
		{
			Vertex2hf v = Vertex2hf.UnitX;

			Assert.IsTrue(v.Equals(Vertex2hf.UnitX));
			Assert.IsFalse(v.Equals(Vertex2hf.UnitY));
		}

		[Test(Description = "Test Vertex2hf.Equals(object)")]
		public void Vertex2hf_TestEquals_True()
		{
			Vertex2hf v = Vertex2hf.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex2hf.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex2hf.UnitY));
		}

		[Test(Description = "Test Vertex2hf.GetHashCode()")]
		public void Vertex2hf_TestGetHashCode()
		{
			Random random = new Random();
			
			HalfFloat x = (HalfFloat)Next(random);
			HalfFloat y = (HalfFloat)Next(random);

			Vertex2hf v = new Vertex2hf(x, y);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex2hf.ToString()")]
		public void Vertex2hf_TestToString()
		{
			Random random = new Random();
			
			HalfFloat x = (HalfFloat)Next(random);
			HalfFloat y = (HalfFloat)Next(random);

			Vertex2hf v = new Vertex2hf(x, y);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

}
