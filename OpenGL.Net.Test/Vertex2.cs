
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

	[TestFixture, Category("Math")]
	class Vertex2ubTest : Vertex2TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex2ub(byte)")]
		public void Vertex2ub_Constructor1()
		{
			Random random = new Random();
			byte randomValue = (byte)Next(random);
			
			Vertex2ub v = new Vertex2ub(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
		}

		[Test(Description = "Test Vertex2ub(byte[])")]
		public void Vertex2ub_Constructor2()
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
		public void Vertex2ub_Constructor3()
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
		public void Vertex2ub_MarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex2ub)), Vertex2ub.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex2ub.operator+(Vertex2ub, Vertex2ub)")]
		public void Vertex2ub_OperatorAdd()
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
		public void Vertex2ub_OperatorSub()
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
		public void Vertex2ub_OperatorMultiplySingle()
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
		public void Vertex2ub_OperatorMultiplyDouble()
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
		public void Vertex2ub_OperatorDivideSingle()
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
		public void Vertex2ub_OperatorDivideDouble()
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
		public void Vertex2ub_OperatorScalarMultiply()
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
		public void Vertex2ub_OperatorScalarDivide()
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
		public void Vertex2ub_OperatorEquality()
		{
			Vertex2ub v = Vertex2ub.UnitX;

			Assert.IsTrue(v == Vertex2ub.UnitX);
			Assert.IsFalse(v == Vertex2ub.UnitY);
		}

		[Test(Description = "Test Vertex2ub.operator!=(Vertex2ub, Vertex2ub)")]
		public void Vertex2ub_OperatorInequality()
		{
			Vertex2ub v = Vertex2ub.UnitX;

			Assert.IsFalse(v != Vertex2ub.UnitX);
			Assert.IsTrue(v != Vertex2ub.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex2ub.operator byte[](Vertex2ub)")]
		public void Vertex2ub_CastToArray()
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
		public void Vertex2ub_CastToVertex2f()
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
		public void Vertex2ub_Module()
		{
			Assert.AreEqual(2.236068f, new Vertex2ub((byte)1.0, (byte)2.0).Module(), 1e-4f);
			Assert.AreEqual(5.385165f, new Vertex2ub((byte)2.0, (byte)5.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex2ub.ModuleSquared()")]
		public void Vertex2ub_ModuleSquared()
		{
			Assert.AreEqual(5f, new Vertex2ub((byte)1.0, (byte)2.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(29f, new Vertex2ub((byte)2.0, (byte)5.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex2ub.Normalize()")]
		public void Vertex2ub_Normalize()
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
		public void Vertex2ub_Normalized()
		{
			Vertex2ub v;

			Assert.DoesNotThrow(delegate() { v = Vertex2ub.Zero.Normalized; });

			v = Vertex2ub.UnitX * (byte)2.0f;
			Assert.AreEqual(Vertex2ub.UnitX, v.Normalized);

			v = Vertex2ub.UnitY * (byte)2.0f;
			Assert.AreEqual(Vertex2ub.UnitY, v.Normalized);
		}

		[Test(Description = "Test Vertex2ub.Min(Vertex2ub[])")]
		public void Vertex2ub_Min()
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
		public void Vertex2ub_Min_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2ub.Min(null));
		}

		[Test(Description = "Test Vertex2ub.Min(Vertex2ub*)")]
		public void Vertex2ub_Min_Unsafe()
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
		public void Vertex2ub_Min_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2ub.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex2ub.Max(Vertex2ub[])")]
		public void Vertex2ub_Max()
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
		public void Vertex2ub_Max_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2ub.Max(null));
		}

		[Test(Description = "Test Vertex2ub.Max(Vertex2ub*)")]
		public void Vertex2ub_Max_Unsafe()
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
		public void Vertex2ub_Max_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2ub.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex2ub.Max(Vertex2ub[])")]
		public void Vertex2ub_MinMax()
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
		public void Vertex2ub_MinMax_ArgumentNullException()
		{
			Vertex2ub min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex2ub.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex2ub.MinMax(Vertex2ub*)")]
		public void Vertex2ub_MinMax_Unsafe()
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
		public void Vertex2ub_MinMax_Unsafe_ArgumentNullException()
		{
			Vertex2ub min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2ub.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex2ub.Equals(Vertex2ub)")]
		public void Vertex2ub_Equals_Vertex2ub()
		{
			Vertex2ub v = Vertex2ub.UnitX;

			Assert.IsTrue(v.Equals(Vertex2ub.UnitX));
			Assert.IsFalse(v.Equals(Vertex2ub.UnitY));
		}

		[Test(Description = "Test Vertex2ub.Equals(object)")]
		public void Vertex2ub_Equals_True()
		{
			Vertex2ub v = Vertex2ub.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex2ub.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex2ub.UnitY));
		}

		[Test(Description = "Test Vertex2ub.GetHashCode()")]
		public void Vertex2ub_GetHashCode()
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
		public void Vertex2ub_ToString()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random);
			byte y = (byte)Next(random);

			Vertex2ub v = new Vertex2ub(x, y);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture, Category("Math")]
	class Vertex2bTest : Vertex2TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex2b(sbyte)")]
		public void Vertex2b_Constructor1()
		{
			Random random = new Random();
			sbyte randomValue = (sbyte)Next(random);
			
			Vertex2b v = new Vertex2b(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
		}

		[Test(Description = "Test Vertex2b(sbyte[])")]
		public void Vertex2b_Constructor2()
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
		public void Vertex2b_Constructor3()
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
		public void Vertex2b_MarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex2b)), Vertex2b.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex2b.operator-(Vertex2b))")]
		public void Vertex2b_OperatorNegate()
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
		public void Vertex2b_OperatorAdd()
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
		public void Vertex2b_OperatorSub()
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
		public void Vertex2b_OperatorMultiplySingle()
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
		public void Vertex2b_OperatorMultiplyDouble()
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
		public void Vertex2b_OperatorDivideSingle()
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
		public void Vertex2b_OperatorDivideDouble()
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
		public void Vertex2b_OperatorScalarMultiply()
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
		public void Vertex2b_OperatorScalarDivide()
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
		public void Vertex2b_OperatorEquality()
		{
			Vertex2b v = Vertex2b.UnitX;

			Assert.IsTrue(v == Vertex2b.UnitX);
			Assert.IsFalse(v == Vertex2b.UnitY);
		}

		[Test(Description = "Test Vertex2b.operator!=(Vertex2b, Vertex2b)")]
		public void Vertex2b_OperatorInequality()
		{
			Vertex2b v = Vertex2b.UnitX;

			Assert.IsFalse(v != Vertex2b.UnitX);
			Assert.IsTrue(v != Vertex2b.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex2b.operator sbyte[](Vertex2b)")]
		public void Vertex2b_CastToArray()
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
		public void Vertex2b_CastToVertex2f()
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
		public void Vertex2b_Module()
		{
			Assert.AreEqual(2.236068f, new Vertex2b((sbyte)1.0, (sbyte)2.0).Module(), 1e-4f);
			Assert.AreEqual(5.385165f, new Vertex2b((sbyte)2.0, (sbyte)5.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex2b.ModuleSquared()")]
		public void Vertex2b_ModuleSquared()
		{
			Assert.AreEqual(5f, new Vertex2b((sbyte)1.0, (sbyte)2.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(29f, new Vertex2b((sbyte)2.0, (sbyte)5.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex2b.Normalize()")]
		public void Vertex2b_Normalize()
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
		public void Vertex2b_Normalized()
		{
			Vertex2b v;

			Assert.DoesNotThrow(delegate() { v = Vertex2b.Zero.Normalized; });

			v = Vertex2b.UnitX * (sbyte)2.0f;
			Assert.AreEqual(Vertex2b.UnitX, v.Normalized);

			v = Vertex2b.UnitY * (sbyte)2.0f;
			Assert.AreEqual(Vertex2b.UnitY, v.Normalized);
		}

		[Test(Description = "Test Vertex2b.Min(Vertex2b[])")]
		public void Vertex2b_Min()
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
		public void Vertex2b_Min_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2b.Min(null));
		}

		[Test(Description = "Test Vertex2b.Min(Vertex2b*)")]
		public void Vertex2b_Min_Unsafe()
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
		public void Vertex2b_Min_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2b.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex2b.Max(Vertex2b[])")]
		public void Vertex2b_Max()
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
		public void Vertex2b_Max_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2b.Max(null));
		}

		[Test(Description = "Test Vertex2b.Max(Vertex2b*)")]
		public void Vertex2b_Max_Unsafe()
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
		public void Vertex2b_Max_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2b.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex2b.Max(Vertex2b[])")]
		public void Vertex2b_MinMax()
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
		public void Vertex2b_MinMax_ArgumentNullException()
		{
			Vertex2b min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex2b.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex2b.MinMax(Vertex2b*)")]
		public void Vertex2b_MinMax_Unsafe()
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
		public void Vertex2b_MinMax_Unsafe_ArgumentNullException()
		{
			Vertex2b min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2b.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex2b.Equals(Vertex2b)")]
		public void Vertex2b_Equals_Vertex2b()
		{
			Vertex2b v = Vertex2b.UnitX;

			Assert.IsTrue(v.Equals(Vertex2b.UnitX));
			Assert.IsFalse(v.Equals(Vertex2b.UnitY));
		}

		[Test(Description = "Test Vertex2b.Equals(object)")]
		public void Vertex2b_Equals_True()
		{
			Vertex2b v = Vertex2b.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex2b.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex2b.UnitY));
		}

		[Test(Description = "Test Vertex2b.GetHashCode()")]
		public void Vertex2b_GetHashCode()
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
		public void Vertex2b_ToString()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random);
			sbyte y = (sbyte)Next(random);

			Vertex2b v = new Vertex2b(x, y);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture, Category("Math")]
	class Vertex2usTest : Vertex2TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex2us(ushort)")]
		public void Vertex2us_Constructor1()
		{
			Random random = new Random();
			ushort randomValue = (ushort)Next(random);
			
			Vertex2us v = new Vertex2us(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
		}

		[Test(Description = "Test Vertex2us(ushort[])")]
		public void Vertex2us_Constructor2()
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
		public void Vertex2us_Constructor3()
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
		public void Vertex2us_MarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex2us)), Vertex2us.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex2us.operator+(Vertex2us, Vertex2us)")]
		public void Vertex2us_OperatorAdd()
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
		public void Vertex2us_OperatorSub()
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
		public void Vertex2us_OperatorMultiplySingle()
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
		public void Vertex2us_OperatorMultiplyDouble()
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
		public void Vertex2us_OperatorDivideSingle()
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
		public void Vertex2us_OperatorDivideDouble()
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
		public void Vertex2us_OperatorScalarMultiply()
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
		public void Vertex2us_OperatorScalarDivide()
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
		public void Vertex2us_OperatorEquality()
		{
			Vertex2us v = Vertex2us.UnitX;

			Assert.IsTrue(v == Vertex2us.UnitX);
			Assert.IsFalse(v == Vertex2us.UnitY);
		}

		[Test(Description = "Test Vertex2us.operator!=(Vertex2us, Vertex2us)")]
		public void Vertex2us_OperatorInequality()
		{
			Vertex2us v = Vertex2us.UnitX;

			Assert.IsFalse(v != Vertex2us.UnitX);
			Assert.IsTrue(v != Vertex2us.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex2us.operator ushort[](Vertex2us)")]
		public void Vertex2us_CastToArray()
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
		public void Vertex2us_CastToVertex2f()
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
		public void Vertex2us_Module()
		{
			Assert.AreEqual(2.236068f, new Vertex2us((ushort)1.0, (ushort)2.0).Module(), 1e-4f);
			Assert.AreEqual(5.385165f, new Vertex2us((ushort)2.0, (ushort)5.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex2us.ModuleSquared()")]
		public void Vertex2us_ModuleSquared()
		{
			Assert.AreEqual(5f, new Vertex2us((ushort)1.0, (ushort)2.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(29f, new Vertex2us((ushort)2.0, (ushort)5.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex2us.Normalize()")]
		public void Vertex2us_Normalize()
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
		public void Vertex2us_Normalized()
		{
			Vertex2us v;

			Assert.DoesNotThrow(delegate() { v = Vertex2us.Zero.Normalized; });

			v = Vertex2us.UnitX * (ushort)2.0f;
			Assert.AreEqual(Vertex2us.UnitX, v.Normalized);

			v = Vertex2us.UnitY * (ushort)2.0f;
			Assert.AreEqual(Vertex2us.UnitY, v.Normalized);
		}

		[Test(Description = "Test Vertex2us.Min(Vertex2us[])")]
		public void Vertex2us_Min()
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
		public void Vertex2us_Min_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2us.Min(null));
		}

		[Test(Description = "Test Vertex2us.Min(Vertex2us*)")]
		public void Vertex2us_Min_Unsafe()
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
		public void Vertex2us_Min_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2us.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex2us.Max(Vertex2us[])")]
		public void Vertex2us_Max()
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
		public void Vertex2us_Max_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2us.Max(null));
		}

		[Test(Description = "Test Vertex2us.Max(Vertex2us*)")]
		public void Vertex2us_Max_Unsafe()
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
		public void Vertex2us_Max_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2us.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex2us.Max(Vertex2us[])")]
		public void Vertex2us_MinMax()
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
		public void Vertex2us_MinMax_ArgumentNullException()
		{
			Vertex2us min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex2us.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex2us.MinMax(Vertex2us*)")]
		public void Vertex2us_MinMax_Unsafe()
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
		public void Vertex2us_MinMax_Unsafe_ArgumentNullException()
		{
			Vertex2us min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2us.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex2us.Equals(Vertex2us)")]
		public void Vertex2us_Equals_Vertex2us()
		{
			Vertex2us v = Vertex2us.UnitX;

			Assert.IsTrue(v.Equals(Vertex2us.UnitX));
			Assert.IsFalse(v.Equals(Vertex2us.UnitY));
		}

		[Test(Description = "Test Vertex2us.Equals(object)")]
		public void Vertex2us_Equals_True()
		{
			Vertex2us v = Vertex2us.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex2us.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex2us.UnitY));
		}

		[Test(Description = "Test Vertex2us.GetHashCode()")]
		public void Vertex2us_GetHashCode()
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
		public void Vertex2us_ToString()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random);
			ushort y = (ushort)Next(random);

			Vertex2us v = new Vertex2us(x, y);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture, Category("Math")]
	class Vertex2sTest : Vertex2TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex2s(short)")]
		public void Vertex2s_Constructor1()
		{
			Random random = new Random();
			short randomValue = (short)Next(random);
			
			Vertex2s v = new Vertex2s(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
		}

		[Test(Description = "Test Vertex2s(short[])")]
		public void Vertex2s_Constructor2()
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
		public void Vertex2s_Constructor3()
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
		public void Vertex2s_MarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex2s)), Vertex2s.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex2s.operator-(Vertex2s))")]
		public void Vertex2s_OperatorNegate()
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
		public void Vertex2s_OperatorAdd()
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
		public void Vertex2s_OperatorSub()
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
		public void Vertex2s_OperatorMultiplySingle()
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
		public void Vertex2s_OperatorMultiplyDouble()
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
		public void Vertex2s_OperatorDivideSingle()
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
		public void Vertex2s_OperatorDivideDouble()
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
		public void Vertex2s_OperatorScalarMultiply()
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
		public void Vertex2s_OperatorScalarDivide()
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
		public void Vertex2s_OperatorEquality()
		{
			Vertex2s v = Vertex2s.UnitX;

			Assert.IsTrue(v == Vertex2s.UnitX);
			Assert.IsFalse(v == Vertex2s.UnitY);
		}

		[Test(Description = "Test Vertex2s.operator!=(Vertex2s, Vertex2s)")]
		public void Vertex2s_OperatorInequality()
		{
			Vertex2s v = Vertex2s.UnitX;

			Assert.IsFalse(v != Vertex2s.UnitX);
			Assert.IsTrue(v != Vertex2s.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex2s.operator short[](Vertex2s)")]
		public void Vertex2s_CastToArray()
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
		public void Vertex2s_CastToVertex2f()
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
		public void Vertex2s_Module()
		{
			Assert.AreEqual(2.236068f, new Vertex2s((short)1.0, (short)2.0).Module(), 1e-4f);
			Assert.AreEqual(5.385165f, new Vertex2s((short)2.0, (short)5.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex2s.ModuleSquared()")]
		public void Vertex2s_ModuleSquared()
		{
			Assert.AreEqual(5f, new Vertex2s((short)1.0, (short)2.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(29f, new Vertex2s((short)2.0, (short)5.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex2s.Normalize()")]
		public void Vertex2s_Normalize()
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
		public void Vertex2s_Normalized()
		{
			Vertex2s v;

			Assert.DoesNotThrow(delegate() { v = Vertex2s.Zero.Normalized; });

			v = Vertex2s.UnitX * (short)2.0f;
			Assert.AreEqual(Vertex2s.UnitX, v.Normalized);

			v = Vertex2s.UnitY * (short)2.0f;
			Assert.AreEqual(Vertex2s.UnitY, v.Normalized);
		}

		[Test(Description = "Test Vertex2s.Min(Vertex2s[])")]
		public void Vertex2s_Min()
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
		public void Vertex2s_Min_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2s.Min(null));
		}

		[Test(Description = "Test Vertex2s.Min(Vertex2s*)")]
		public void Vertex2s_Min_Unsafe()
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
		public void Vertex2s_Min_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2s.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex2s.Max(Vertex2s[])")]
		public void Vertex2s_Max()
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
		public void Vertex2s_Max_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2s.Max(null));
		}

		[Test(Description = "Test Vertex2s.Max(Vertex2s*)")]
		public void Vertex2s_Max_Unsafe()
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
		public void Vertex2s_Max_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2s.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex2s.Max(Vertex2s[])")]
		public void Vertex2s_MinMax()
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
		public void Vertex2s_MinMax_ArgumentNullException()
		{
			Vertex2s min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex2s.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex2s.MinMax(Vertex2s*)")]
		public void Vertex2s_MinMax_Unsafe()
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
		public void Vertex2s_MinMax_Unsafe_ArgumentNullException()
		{
			Vertex2s min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2s.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex2s.Equals(Vertex2s)")]
		public void Vertex2s_Equals_Vertex2s()
		{
			Vertex2s v = Vertex2s.UnitX;

			Assert.IsTrue(v.Equals(Vertex2s.UnitX));
			Assert.IsFalse(v.Equals(Vertex2s.UnitY));
		}

		[Test(Description = "Test Vertex2s.Equals(object)")]
		public void Vertex2s_Equals_True()
		{
			Vertex2s v = Vertex2s.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex2s.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex2s.UnitY));
		}

		[Test(Description = "Test Vertex2s.GetHashCode()")]
		public void Vertex2s_GetHashCode()
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
		public void Vertex2s_ToString()
		{
			Random random = new Random();
			
			short x = (short)Next(random);
			short y = (short)Next(random);

			Vertex2s v = new Vertex2s(x, y);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture, Category("Math")]
	class Vertex2uiTest : Vertex2TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex2ui(uint)")]
		public void Vertex2ui_Constructor1()
		{
			Random random = new Random();
			uint randomValue = (uint)Next(random);
			
			Vertex2ui v = new Vertex2ui(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
		}

		[Test(Description = "Test Vertex2ui(uint[])")]
		public void Vertex2ui_Constructor2()
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
		public void Vertex2ui_Constructor3()
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
		public void Vertex2ui_MarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex2ui)), Vertex2ui.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex2ui.operator+(Vertex2ui, Vertex2ui)")]
		public void Vertex2ui_OperatorAdd()
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
		public void Vertex2ui_OperatorSub()
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
		public void Vertex2ui_OperatorMultiplySingle()
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
		public void Vertex2ui_OperatorMultiplyDouble()
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
		public void Vertex2ui_OperatorDivideSingle()
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
		public void Vertex2ui_OperatorDivideDouble()
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
		public void Vertex2ui_OperatorScalarMultiply()
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
		public void Vertex2ui_OperatorScalarDivide()
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
		public void Vertex2ui_OperatorEquality()
		{
			Vertex2ui v = Vertex2ui.UnitX;

			Assert.IsTrue(v == Vertex2ui.UnitX);
			Assert.IsFalse(v == Vertex2ui.UnitY);
		}

		[Test(Description = "Test Vertex2ui.operator!=(Vertex2ui, Vertex2ui)")]
		public void Vertex2ui_OperatorInequality()
		{
			Vertex2ui v = Vertex2ui.UnitX;

			Assert.IsFalse(v != Vertex2ui.UnitX);
			Assert.IsTrue(v != Vertex2ui.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex2ui.operator uint[](Vertex2ui)")]
		public void Vertex2ui_CastToArray()
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
		public void Vertex2ui_CastToVertex2f()
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
		public void Vertex2ui_Module()
		{
			Assert.AreEqual(2.236068f, new Vertex2ui((uint)1.0, (uint)2.0).Module(), 1e-4f);
			Assert.AreEqual(5.385165f, new Vertex2ui((uint)2.0, (uint)5.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex2ui.ModuleSquared()")]
		public void Vertex2ui_ModuleSquared()
		{
			Assert.AreEqual(5f, new Vertex2ui((uint)1.0, (uint)2.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(29f, new Vertex2ui((uint)2.0, (uint)5.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex2ui.Normalize()")]
		public void Vertex2ui_Normalize()
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
		public void Vertex2ui_Normalized()
		{
			Vertex2ui v;

			Assert.DoesNotThrow(delegate() { v = Vertex2ui.Zero.Normalized; });

			v = Vertex2ui.UnitX * (uint)2.0f;
			Assert.AreEqual(Vertex2ui.UnitX, v.Normalized);

			v = Vertex2ui.UnitY * (uint)2.0f;
			Assert.AreEqual(Vertex2ui.UnitY, v.Normalized);
		}

		[Test(Description = "Test Vertex2ui.Min(Vertex2ui[])")]
		public void Vertex2ui_Min()
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
		public void Vertex2ui_Min_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2ui.Min(null));
		}

		[Test(Description = "Test Vertex2ui.Min(Vertex2ui*)")]
		public void Vertex2ui_Min_Unsafe()
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
		public void Vertex2ui_Min_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2ui.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex2ui.Max(Vertex2ui[])")]
		public void Vertex2ui_Max()
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
		public void Vertex2ui_Max_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2ui.Max(null));
		}

		[Test(Description = "Test Vertex2ui.Max(Vertex2ui*)")]
		public void Vertex2ui_Max_Unsafe()
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
		public void Vertex2ui_Max_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2ui.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex2ui.Max(Vertex2ui[])")]
		public void Vertex2ui_MinMax()
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
		public void Vertex2ui_MinMax_ArgumentNullException()
		{
			Vertex2ui min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex2ui.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex2ui.MinMax(Vertex2ui*)")]
		public void Vertex2ui_MinMax_Unsafe()
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
		public void Vertex2ui_MinMax_Unsafe_ArgumentNullException()
		{
			Vertex2ui min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2ui.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex2ui.Equals(Vertex2ui)")]
		public void Vertex2ui_Equals_Vertex2ui()
		{
			Vertex2ui v = Vertex2ui.UnitX;

			Assert.IsTrue(v.Equals(Vertex2ui.UnitX));
			Assert.IsFalse(v.Equals(Vertex2ui.UnitY));
		}

		[Test(Description = "Test Vertex2ui.Equals(object)")]
		public void Vertex2ui_Equals_True()
		{
			Vertex2ui v = Vertex2ui.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex2ui.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex2ui.UnitY));
		}

		[Test(Description = "Test Vertex2ui.GetHashCode()")]
		public void Vertex2ui_GetHashCode()
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
		public void Vertex2ui_ToString()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random);
			uint y = (uint)Next(random);

			Vertex2ui v = new Vertex2ui(x, y);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture, Category("Math")]
	class Vertex2iTest : Vertex2TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex2i(int)")]
		public void Vertex2i_Constructor1()
		{
			Random random = new Random();
			int randomValue = (int)Next(random);
			
			Vertex2i v = new Vertex2i(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
		}

		[Test(Description = "Test Vertex2i(int[])")]
		public void Vertex2i_Constructor2()
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
		public void Vertex2i_Constructor3()
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
		public void Vertex2i_MarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex2i)), Vertex2i.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex2i.operator-(Vertex2i))")]
		public void Vertex2i_OperatorNegate()
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
		public void Vertex2i_OperatorAdd()
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
		public void Vertex2i_OperatorSub()
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
		public void Vertex2i_OperatorMultiplySingle()
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
		public void Vertex2i_OperatorMultiplyDouble()
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
		public void Vertex2i_OperatorDivideSingle()
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
		public void Vertex2i_OperatorDivideDouble()
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
		public void Vertex2i_OperatorScalarMultiply()
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
		public void Vertex2i_OperatorScalarDivide()
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
		public void Vertex2i_OperatorEquality()
		{
			Vertex2i v = Vertex2i.UnitX;

			Assert.IsTrue(v == Vertex2i.UnitX);
			Assert.IsFalse(v == Vertex2i.UnitY);
		}

		[Test(Description = "Test Vertex2i.operator!=(Vertex2i, Vertex2i)")]
		public void Vertex2i_OperatorInequality()
		{
			Vertex2i v = Vertex2i.UnitX;

			Assert.IsFalse(v != Vertex2i.UnitX);
			Assert.IsTrue(v != Vertex2i.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex2i.operator int[](Vertex2i)")]
		public void Vertex2i_CastToArray()
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
		public void Vertex2i_CastToVertex2f()
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
		public void Vertex2i_Module()
		{
			Assert.AreEqual(2.236068f, new Vertex2i((int)1.0, (int)2.0).Module(), 1e-4f);
			Assert.AreEqual(5.385165f, new Vertex2i((int)2.0, (int)5.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex2i.ModuleSquared()")]
		public void Vertex2i_ModuleSquared()
		{
			Assert.AreEqual(5f, new Vertex2i((int)1.0, (int)2.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(29f, new Vertex2i((int)2.0, (int)5.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex2i.Normalize()")]
		public void Vertex2i_Normalize()
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
		public void Vertex2i_Normalized()
		{
			Vertex2i v;

			Assert.DoesNotThrow(delegate() { v = Vertex2i.Zero.Normalized; });

			v = Vertex2i.UnitX * (int)2.0f;
			Assert.AreEqual(Vertex2i.UnitX, v.Normalized);

			v = Vertex2i.UnitY * (int)2.0f;
			Assert.AreEqual(Vertex2i.UnitY, v.Normalized);
		}

		[Test(Description = "Test Vertex2i.Min(Vertex2i[])")]
		public void Vertex2i_Min()
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
		public void Vertex2i_Min_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2i.Min(null));
		}

		[Test(Description = "Test Vertex2i.Min(Vertex2i*)")]
		public void Vertex2i_Min_Unsafe()
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
		public void Vertex2i_Min_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2i.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex2i.Max(Vertex2i[])")]
		public void Vertex2i_Max()
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
		public void Vertex2i_Max_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2i.Max(null));
		}

		[Test(Description = "Test Vertex2i.Max(Vertex2i*)")]
		public void Vertex2i_Max_Unsafe()
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
		public void Vertex2i_Max_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2i.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex2i.Max(Vertex2i[])")]
		public void Vertex2i_MinMax()
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
		public void Vertex2i_MinMax_ArgumentNullException()
		{
			Vertex2i min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex2i.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex2i.MinMax(Vertex2i*)")]
		public void Vertex2i_MinMax_Unsafe()
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
		public void Vertex2i_MinMax_Unsafe_ArgumentNullException()
		{
			Vertex2i min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2i.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex2i.Equals(Vertex2i)")]
		public void Vertex2i_Equals_Vertex2i()
		{
			Vertex2i v = Vertex2i.UnitX;

			Assert.IsTrue(v.Equals(Vertex2i.UnitX));
			Assert.IsFalse(v.Equals(Vertex2i.UnitY));
		}

		[Test(Description = "Test Vertex2i.Equals(object)")]
		public void Vertex2i_Equals_True()
		{
			Vertex2i v = Vertex2i.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex2i.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex2i.UnitY));
		}

		[Test(Description = "Test Vertex2i.GetHashCode()")]
		public void Vertex2i_GetHashCode()
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
		public void Vertex2i_ToString()
		{
			Random random = new Random();
			
			int x = (int)Next(random);
			int y = (int)Next(random);

			Vertex2i v = new Vertex2i(x, y);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture, Category("Math")]
	class Vertex2fTest : Vertex2TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex2f(float)")]
		public void Vertex2f_Constructor1()
		{
			Random random = new Random();
			float randomValue = (float)Next(random);
			
			Vertex2f v = new Vertex2f(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
		}

		[Test(Description = "Test Vertex2f(float[])")]
		public void Vertex2f_Constructor2()
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
		public void Vertex2f_Constructor3()
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
		public void Vertex2f_MarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex2f)), Vertex2f.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex2f.operator-(Vertex2f))")]
		public void Vertex2f_OperatorNegate()
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
		public void Vertex2f_OperatorAdd()
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
		public void Vertex2f_OperatorSub()
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
		public void Vertex2f_OperatorMultiplySingle()
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
		public void Vertex2f_OperatorMultiplyDouble()
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
		public void Vertex2f_OperatorDivideSingle()
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
		public void Vertex2f_OperatorDivideDouble()
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
		public void Vertex2f_OperatorEquality()
		{
			Vertex2f v = Vertex2f.UnitX;

			Assert.IsTrue(v == Vertex2f.UnitX);
			Assert.IsFalse(v == Vertex2f.UnitY);
		}

		[Test(Description = "Test Vertex2f.operator!=(Vertex2f, Vertex2f)")]
		public void Vertex2f_OperatorInequality()
		{
			Vertex2f v = Vertex2f.UnitX;

			Assert.IsFalse(v != Vertex2f.UnitX);
			Assert.IsTrue(v != Vertex2f.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex2f.operator float[](Vertex2f)")]
		public void Vertex2f_CastToArray()
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
		public void Vertex2f_CastToVertex2f()
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
		public void Vertex2f_Module()
		{
			Assert.AreEqual(2.236068f, new Vertex2f((float)1.0, (float)2.0).Module(), 1e-4f);
			Assert.AreEqual(5.385165f, new Vertex2f((float)2.0, (float)5.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex2f.ModuleSquared()")]
		public void Vertex2f_ModuleSquared()
		{
			Assert.AreEqual(5f, new Vertex2f((float)1.0, (float)2.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(29f, new Vertex2f((float)2.0, (float)5.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex2f.Normalize()")]
		public void Vertex2f_Normalize()
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
		public void Vertex2f_Normalized()
		{
			Vertex2f v;

			Assert.DoesNotThrow(delegate() { v = Vertex2f.Zero.Normalized; });

			v = Vertex2f.UnitX * (float)2.0f;
			Assert.AreEqual(Vertex2f.UnitX, v.Normalized);

			v = Vertex2f.UnitY * (float)2.0f;
			Assert.AreEqual(Vertex2f.UnitY, v.Normalized);
		}

		[Test(Description = "Test Vertex2f.Min(Vertex2f[])")]
		public void Vertex2f_Min()
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
		public void Vertex2f_Min_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2f.Min(null));
		}

		[Test(Description = "Test Vertex2f.Min(Vertex2f*)")]
		public void Vertex2f_Min_Unsafe()
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
		public void Vertex2f_Min_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2f.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex2f.Max(Vertex2f[])")]
		public void Vertex2f_Max()
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
		public void Vertex2f_Max_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2f.Max(null));
		}

		[Test(Description = "Test Vertex2f.Max(Vertex2f*)")]
		public void Vertex2f_Max_Unsafe()
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
		public void Vertex2f_Max_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2f.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex2f.Max(Vertex2f[])")]
		public void Vertex2f_MinMax()
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
		public void Vertex2f_MinMax_ArgumentNullException()
		{
			Vertex2f min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex2f.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex2f.MinMax(Vertex2f*)")]
		public void Vertex2f_MinMax_Unsafe()
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
		public void Vertex2f_MinMax_Unsafe_ArgumentNullException()
		{
			Vertex2f min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2f.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex2f.Equals(Vertex2f)")]
		public void Vertex2f_Equals_Vertex2f()
		{
			Vertex2f v = Vertex2f.UnitX;

			Assert.IsTrue(v.Equals(Vertex2f.UnitX));
			Assert.IsFalse(v.Equals(Vertex2f.UnitY));
		}

		[Test(Description = "Test Vertex2f.Equals(object)")]
		public void Vertex2f_Equals_True()
		{
			Vertex2f v = Vertex2f.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex2f.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex2f.UnitY));
		}

		[Test(Description = "Test Vertex2f.GetHashCode()")]
		public void Vertex2f_GetHashCode()
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
		public void Vertex2f_ToString()
		{
			Random random = new Random();
			
			float x = (float)Next(random);
			float y = (float)Next(random);

			Vertex2f v = new Vertex2f(x, y);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture, Category("Math")]
	class Vertex2dTest : Vertex2TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex2d(double)")]
		public void Vertex2d_Constructor1()
		{
			Random random = new Random();
			double randomValue = (double)Next(random);
			
			Vertex2d v = new Vertex2d(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
		}

		[Test(Description = "Test Vertex2d(double[])")]
		public void Vertex2d_Constructor2()
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
		public void Vertex2d_Constructor3()
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
		public void Vertex2d_MarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex2d)), Vertex2d.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex2d.operator-(Vertex2d))")]
		public void Vertex2d_OperatorNegate()
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
		public void Vertex2d_OperatorAdd()
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
		public void Vertex2d_OperatorSub()
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
		public void Vertex2d_OperatorMultiplySingle()
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
		public void Vertex2d_OperatorMultiplyDouble()
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
		public void Vertex2d_OperatorDivideSingle()
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
		public void Vertex2d_OperatorDivideDouble()
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
		public void Vertex2d_OperatorEquality()
		{
			Vertex2d v = Vertex2d.UnitX;

			Assert.IsTrue(v == Vertex2d.UnitX);
			Assert.IsFalse(v == Vertex2d.UnitY);
		}

		[Test(Description = "Test Vertex2d.operator!=(Vertex2d, Vertex2d)")]
		public void Vertex2d_OperatorInequality()
		{
			Vertex2d v = Vertex2d.UnitX;

			Assert.IsFalse(v != Vertex2d.UnitX);
			Assert.IsTrue(v != Vertex2d.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex2d.operator double[](Vertex2d)")]
		public void Vertex2d_CastToArray()
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
		public void Vertex2d_CastToVertex2f()
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
		public void Vertex2d_Module()
		{
			Assert.AreEqual(2.236068f, new Vertex2d((double)1.0, (double)2.0).Module(), 1e-4f);
			Assert.AreEqual(5.385165f, new Vertex2d((double)2.0, (double)5.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex2d.ModuleSquared()")]
		public void Vertex2d_ModuleSquared()
		{
			Assert.AreEqual(5f, new Vertex2d((double)1.0, (double)2.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(29f, new Vertex2d((double)2.0, (double)5.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex2d.Normalize()")]
		public void Vertex2d_Normalize()
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
		public void Vertex2d_Normalized()
		{
			Vertex2d v;

			Assert.DoesNotThrow(delegate() { v = Vertex2d.Zero.Normalized; });

			v = Vertex2d.UnitX * (double)2.0f;
			Assert.AreEqual(Vertex2d.UnitX, v.Normalized);

			v = Vertex2d.UnitY * (double)2.0f;
			Assert.AreEqual(Vertex2d.UnitY, v.Normalized);
		}

		[Test(Description = "Test Vertex2d.Min(Vertex2d[])")]
		public void Vertex2d_Min()
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
		public void Vertex2d_Min_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2d.Min(null));
		}

		[Test(Description = "Test Vertex2d.Min(Vertex2d*)")]
		public void Vertex2d_Min_Unsafe()
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
		public void Vertex2d_Min_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2d.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex2d.Max(Vertex2d[])")]
		public void Vertex2d_Max()
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
		public void Vertex2d_Max_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2d.Max(null));
		}

		[Test(Description = "Test Vertex2d.Max(Vertex2d*)")]
		public void Vertex2d_Max_Unsafe()
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
		public void Vertex2d_Max_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2d.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex2d.Max(Vertex2d[])")]
		public void Vertex2d_MinMax()
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
		public void Vertex2d_MinMax_ArgumentNullException()
		{
			Vertex2d min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex2d.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex2d.MinMax(Vertex2d*)")]
		public void Vertex2d_MinMax_Unsafe()
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
		public void Vertex2d_MinMax_Unsafe_ArgumentNullException()
		{
			Vertex2d min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2d.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex2d.Equals(Vertex2d)")]
		public void Vertex2d_Equals_Vertex2d()
		{
			Vertex2d v = Vertex2d.UnitX;

			Assert.IsTrue(v.Equals(Vertex2d.UnitX));
			Assert.IsFalse(v.Equals(Vertex2d.UnitY));
		}

		[Test(Description = "Test Vertex2d.Equals(object)")]
		public void Vertex2d_Equals_True()
		{
			Vertex2d v = Vertex2d.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex2d.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex2d.UnitY));
		}

		[Test(Description = "Test Vertex2d.GetHashCode()")]
		public void Vertex2d_GetHashCode()
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
		public void Vertex2d_ToString()
		{
			Random random = new Random();
			
			double x = (double)Next(random);
			double y = (double)Next(random);

			Vertex2d v = new Vertex2d(x, y);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture, Category("Math")]
	class Vertex2hfTest : Vertex2TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex2hf(HalfFloat)")]
		public void Vertex2hf_Constructor1()
		{
			Random random = new Random();
			HalfFloat randomValue = (HalfFloat)Next(random);
			
			Vertex2hf v = new Vertex2hf(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
		}

		[Test(Description = "Test Vertex2hf(HalfFloat[])")]
		public void Vertex2hf_Constructor2()
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
		public void Vertex2hf_Constructor3()
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
		public void Vertex2hf_MarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex2hf)), Vertex2hf.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex2hf.operator+(Vertex2hf, Vertex2hf)")]
		public void Vertex2hf_OperatorAdd()
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
		public void Vertex2hf_OperatorSub()
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
		public void Vertex2hf_OperatorMultiplySingle()
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
		public void Vertex2hf_OperatorMultiplyDouble()
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
		public void Vertex2hf_OperatorDivideSingle()
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
		public void Vertex2hf_OperatorDivideDouble()
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
		public void Vertex2hf_OperatorEquality()
		{
			Vertex2hf v = Vertex2hf.UnitX;

			Assert.IsTrue(v == Vertex2hf.UnitX);
			Assert.IsFalse(v == Vertex2hf.UnitY);
		}

		[Test(Description = "Test Vertex2hf.operator!=(Vertex2hf, Vertex2hf)")]
		public void Vertex2hf_OperatorInequality()
		{
			Vertex2hf v = Vertex2hf.UnitX;

			Assert.IsFalse(v != Vertex2hf.UnitX);
			Assert.IsTrue(v != Vertex2hf.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex2hf.operator HalfFloat[](Vertex2hf)")]
		public void Vertex2hf_CastToArray()
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
		public void Vertex2hf_CastToVertex2f()
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
		public void Vertex2hf_Module()
		{
			Assert.AreEqual(2.236068f, new Vertex2hf((HalfFloat)1.0, (HalfFloat)2.0).Module(), 1e-4f);
			Assert.AreEqual(5.385165f, new Vertex2hf((HalfFloat)2.0, (HalfFloat)5.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex2hf.ModuleSquared()")]
		public void Vertex2hf_ModuleSquared()
		{
			Assert.AreEqual(5f, new Vertex2hf((HalfFloat)1.0, (HalfFloat)2.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(29f, new Vertex2hf((HalfFloat)2.0, (HalfFloat)5.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex2hf.Normalize()")]
		public void Vertex2hf_Normalize()
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
		public void Vertex2hf_Normalized()
		{
			Vertex2hf v;

			Assert.DoesNotThrow(delegate() { v = Vertex2hf.Zero.Normalized; });

			v = Vertex2hf.UnitX * (HalfFloat)2.0f;
			Assert.AreEqual(Vertex2hf.UnitX, v.Normalized);

			v = Vertex2hf.UnitY * (HalfFloat)2.0f;
			Assert.AreEqual(Vertex2hf.UnitY, v.Normalized);
		}

		[Test(Description = "Test Vertex2hf.Min(Vertex2hf[])")]
		public void Vertex2hf_Min()
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
		public void Vertex2hf_Min_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2hf.Min(null));
		}

		[Test(Description = "Test Vertex2hf.Min(Vertex2hf*)")]
		public void Vertex2hf_Min_Unsafe()
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
		public void Vertex2hf_Min_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2hf.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex2hf.Max(Vertex2hf[])")]
		public void Vertex2hf_Max()
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
		public void Vertex2hf_Max_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex2hf.Max(null));
		}

		[Test(Description = "Test Vertex2hf.Max(Vertex2hf*)")]
		public void Vertex2hf_Max_Unsafe()
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
		public void Vertex2hf_Max_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2hf.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex2hf.Max(Vertex2hf[])")]
		public void Vertex2hf_MinMax()
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
		public void Vertex2hf_MinMax_ArgumentNullException()
		{
			Vertex2hf min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex2hf.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex2hf.MinMax(Vertex2hf*)")]
		public void Vertex2hf_MinMax_Unsafe()
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
		public void Vertex2hf_MinMax_Unsafe_ArgumentNullException()
		{
			Vertex2hf min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex2hf.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex2hf.Equals(Vertex2hf)")]
		public void Vertex2hf_Equals_Vertex2hf()
		{
			Vertex2hf v = Vertex2hf.UnitX;

			Assert.IsTrue(v.Equals(Vertex2hf.UnitX));
			Assert.IsFalse(v.Equals(Vertex2hf.UnitY));
		}

		[Test(Description = "Test Vertex2hf.Equals(object)")]
		public void Vertex2hf_Equals_True()
		{
			Vertex2hf v = Vertex2hf.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex2hf.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex2hf.UnitY));
		}

		[Test(Description = "Test Vertex2hf.GetHashCode()")]
		public void Vertex2hf_GetHashCode()
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
		public void Vertex2hf_ToString()
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
