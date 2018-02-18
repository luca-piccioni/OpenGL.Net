
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
	class Vertex3TestBase
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
	class Vertex3ubTest : Vertex3TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex3ub(byte)")]
		public void Vertex3ub_TestConstructor1()
		{
			Random random = new Random();
			byte randomValue = (byte)Next(random);
			
			Vertex3ub v = new Vertex3ub(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex3ub(byte[])")]
		public void Vertex3ub_TestConstructor2()
		{
			Random random = new Random();
			byte randomValueX = (byte)Next(random);
			byte randomValueY = (byte)Next(random);
			byte randomValueZ = (byte)Next(random);

			Vertex3ub v = new Vertex3ub(new byte[] {
				randomValueX, randomValueY, randomValueZ
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		[Test(Description = "Test Vertex3ub(byte, byte, byte)")]
		public void Vertex3ub_TestConstructor3()
		{
			Random random = new Random();
			byte randomValueX = (byte)Next(random);
			byte randomValueY = (byte)Next(random);
			byte randomValueZ = (byte)Next(random);

			Vertex3ub v = new Vertex3ub(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex3ub.Size against Marshal.SizeOf")]
		public void Vertex3ub_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex3ub)), Vertex3ub.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex3ub.operator+(Vertex3ub, Vertex3ub)")]
		public void Vertex3ub_TestOperatorAdd()
		{
			Random random = new Random();
			
			byte x1 = (byte)Next(random);
			byte y1 = (byte)Next(random);
			byte z1 = (byte)Next(random);

			Vertex3ub v1 = new Vertex3ub(x1, y1, z1);

			byte x2 = (byte)Next(random);
			byte y2 = (byte)Next(random);
			byte z2 = (byte)Next(random);

			Vertex3ub v2 = new Vertex3ub(x2, y2, z2);

			Vertex3ub v = v1 + v2;

			Assert.AreEqual((byte)(x1 + x2), v.x);
			Assert.AreEqual((byte)(y1 + y2), v.y);
			Assert.AreEqual((byte)(z1 + z2), v.z);
		}

		[Test(Description = "Test Vertex3ub.operator-(Vertex3ub, Vertex3ub)")]
		public void Vertex3ub_TestOperatorSub()
		{
			Random random = new Random();
			
			byte x1 = (byte)Next(random);
			byte y1 = (byte)Next(random);
			byte z1 = (byte)Next(random);

			Vertex3ub v1 = new Vertex3ub(x1, y1, z1);

			byte x2 = (byte)Next(random);
			byte y2 = (byte)Next(random);
			byte z2 = (byte)Next(random);

			Vertex3ub v2 = new Vertex3ub(x2, y2, z2);

			Vertex3ub v = v1 - v2;

			Assert.AreEqual((byte)(x1 - x2), v.x);
			Assert.AreEqual((byte)(y1 - y2), v.y);
			Assert.AreEqual((byte)(z1 - z2), v.z);
		}

		[Test(Description = "Test Vertex3ub.operator*(Vertex3ub, Single)")]
		public void Vertex3ub_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			byte x1 = (byte)Next(random);
			byte y1 = (byte)Next(random);
			byte z1 = (byte)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex3ub v1 = new Vertex3ub(x1, y1, z1);

			Vertex3ub v = v1 * (float)s;

			Assert.AreEqual((byte)(x1 * (float)s), v.x);
			Assert.AreEqual((byte)(y1 * (float)s), v.y);
			Assert.AreEqual((byte)(z1 * (float)s), v.z);
		}

		[Test(Description = "Test Vertex3ub.operator*(Vertex3ub, Double)")]
		public void Vertex3ub_TestOperatorMultiplyDouble()
		{
			Random random = new Random();
			
			byte x1 = (byte)Next(random);
			byte y1 = (byte)Next(random);
			byte z1 = (byte)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex3ub v1 = new Vertex3ub(x1, y1, z1);

			Vertex3ub v = v1 * s;

			Assert.AreEqual((byte)(x1 * s), v.x);
			Assert.AreEqual((byte)(y1 * s), v.y);
			Assert.AreEqual((byte)(z1 * s), v.z);
		}

		[Test(Description = "Test Vertex3ub.operator/(Vertex3ub, Single)")]
		public void Vertex3ub_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			byte x1 = (byte)Next(random);
			byte y1 = (byte)Next(random);
			byte z1 = (byte)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex3ub v1 = new Vertex3ub(x1, y1, z1);

			Vertex3ub v = v1 / (float)s;

			Assert.AreEqual((byte)(x1 / (float)s), v.x);
			Assert.AreEqual((byte)(y1 / (float)s), v.y);
			Assert.AreEqual((byte)(z1 / (float)s), v.z);
		}

		[Test(Description = "Test Vertex3ub.operator/(Vertex3ub, Double)")]
		public void Vertex3ub_TestOperatorDivideDouble()
		{
			Random random = new Random();
			
			byte x1 = (byte)Next(random);
			byte y1 = (byte)Next(random);
			byte z1 = (byte)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex3ub v1 = new Vertex3ub(x1, y1, z1);

			Vertex3ub v = v1 / s;

			Assert.AreEqual((byte)(x1 / s), v.x);
			Assert.AreEqual((byte)(y1 / s), v.y);
			Assert.AreEqual((byte)(z1 / s), v.z);
		}

		[Test(Description = "Test Vertex3ub.operator*(Vertex3ub, Vertex3ub)")]
		public void Vertex3ub_TestOperatorDotProduct()
		{
			Vertex3ub a, b;
			float d;

			a = Vertex3ub.UnitX;
			b = Vertex3ub.UnitY;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3ub.UnitY;
			b = Vertex3ub.UnitZ;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3ub.UnitX;
			b = Vertex3ub.UnitZ;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3ub.UnitX;
			b = Vertex3ub.UnitX;
			d = a * b;
			Assert.AreEqual(1.0, d);

			a = Vertex3ub.UnitY;
			b = Vertex3ub.UnitY;
			d = a * b;
			Assert.AreEqual(1.0, d);

			a = Vertex3ub.UnitZ;
			b = Vertex3ub.UnitZ;
			d = a * b;
			Assert.AreEqual(1.0, d);
		}

		[Test(Description = "Test Vertex3ub.operator^(Vertex3ub, Vertex3ub)")]
		public void Vertex3ub_TestOperatorCrossProduct()
		{
			Vertex3ub a, b;
			Vertex3f c;

			a = Vertex3ub.UnitX;
			b = Vertex3ub.UnitY;
			c = a ^ b;
			Assert.AreEqual(Vertex3f.UnitZ, c);
		}

		[Test(Description = "Test Vertex3ub.operator*(Vertex3ub, byte)")]
		public void Vertex3ub_TestOperatorScalarMultiply()
		{
			Random random = new Random();
			
			byte x1 = (byte)Next(random);
			byte y1 = (byte)Next(random);
			byte z1 = (byte)Next(random);
			byte s = (byte)Next(random, 0.0, 32.0);

			Vertex3ub v1 = new Vertex3ub(x1, y1, z1);

			Vertex3ub v = v1 * s;

			Assert.AreEqual((byte)(x1 * s), v.x);
			Assert.AreEqual((byte)(y1 * s), v.y);
			Assert.AreEqual((byte)(z1 * s), v.z);
		}

		[Test(Description = "Test Vertex3ub.operator/(Vertex3ub, byte)")]
		public void Vertex3ub_TestOperatorScalarDivide()
		{
			Random random = new Random();
			
			byte x1 = (byte)Next(random);
			byte y1 = (byte)Next(random);
			byte z1 = (byte)Next(random);
			byte s = (byte)Next(random, 1.0, 32.0);

			Vertex3ub v1 = new Vertex3ub(x1, y1, z1);

			Vertex3ub v = v1 / s;

			Assert.AreEqual((byte)(x1 / s), v.x);
			Assert.AreEqual((byte)(y1 / s), v.y);
			Assert.AreEqual((byte)(z1 / s), v.z);
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex3ub.operator==(Vertex3ub, Vertex3ub)")]
		public void Vertex3ub_TestOperatorEquality()
		{
			Vertex3ub v = Vertex3ub.UnitX;

			Assert.IsTrue(v == Vertex3ub.UnitX);
			Assert.IsFalse(v == Vertex3ub.UnitY);
		}

		[Test(Description = "Test Vertex3ub.operator!=(Vertex3ub, Vertex3ub)")]
		public void Vertex3ub_TestOperatorInequality()
		{
			Vertex3ub v = Vertex3ub.UnitX;

			Assert.IsFalse(v != Vertex3ub.UnitX);
			Assert.IsTrue(v != Vertex3ub.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex3ub.operator byte[](Vertex3ub)")]
		public void Vertex3ub_TestCastToArray()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random);
			byte y = (byte)Next(random);
			byte z = (byte)Next(random);

			Vertex3ub v = new Vertex3ub(x, y, z);
			byte[] vArray = (byte[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex3ub.operator Vertex3f(Vertex3ub)")]
		public void Vertex3ub_TestCastToVertex3f()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random);
			byte y = (byte)Next(random);
			byte z = (byte)Next(random);

			Vertex3ub v = new Vertex3ub(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.x, v3f.x, 1e-4f);
			Assert.AreEqual(v.y, v3f.y, 1e-4f);
			Assert.AreEqual(v.z, v3f.z, 1e-4f);
		}

		[Test(Description = "Test Vertex3ub.operator Vertex4f(Vertex3ub)")]
		public void Vertex3ub_TestCastToVertex4f()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random);
			byte y = (byte)Next(random);
			byte z = (byte)Next(random);

			Vertex3ub v = new Vertex3ub(x, y, z);
			Vertex4f v4f = (Vertex4f)v;

			Assert.AreEqual(v.x, v4f.x, 1e-4);
			Assert.AreEqual(v.y, v4f.y, 1e-4);
			Assert.AreEqual(v.z, v4f.z, 1e-4);
			Assert.AreEqual(1.0f, v4f.w, 1e-4);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex3ub.Module()")]
		public void Vertex3ub_TestModule()
		{
			Assert.AreEqual(3.741657f, new Vertex3ub((byte)1.0, (byte)2.0, (byte)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex3ub((byte)2.0, (byte)5.0, (byte)7.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex3ub.ModuleSquared()")]
		public void Vertex3ub_TestModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex3ub((byte)1.0, (byte)2.0, (byte)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex3ub((byte)2.0, (byte)5.0, (byte)7.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex3ub.Normalize()")]
		public void Vertex3ub_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex3ub.Zero.Normalize(); });

			Vertex3ub v;

			v = Vertex3ub.UnitX * (byte)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3ub.UnitX, v);

			v = Vertex3ub.UnitY * (byte)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3ub.UnitY, v);

			v = Vertex3ub.UnitZ * (byte)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3ub.UnitZ, v);
		}

		[Test(Description = "Test Vertex3ub.Normalized")]
		public void Vertex3ub_TestNormalized()
		{
			Vertex3ub v;

			Assert.DoesNotThrow(delegate() { v = Vertex3ub.Zero.Normalized; });

			v = Vertex3ub.UnitX * (byte)2.0f;
			Assert.AreEqual(Vertex3ub.UnitX, v.Normalized);

			v = Vertex3ub.UnitY * (byte)2.0f;
			Assert.AreEqual(Vertex3ub.UnitY, v.Normalized);

			v = Vertex3ub.UnitZ * (byte)2.0f;
			Assert.AreEqual(Vertex3ub.UnitZ, v.Normalized);
		}

		[Test(Description = "Test Vertex3ub.Min(Vertex3ub[])")]
		public void Vertex3ub_TestMin()
		{
			Vertex3ub[] v = new Vertex3ub[] {
				new Vertex3ub((byte)1.0f, (byte)13.0f, (byte)22.0f),
				new Vertex3ub((byte)2.0f, (byte)12.0f, (byte)21.0f),
				new Vertex3ub((byte)3.0f, (byte)11.0f, (byte)23.0f),
			};

			Vertex3ub min = Vertex3ub.Min(v);

			Assert.AreEqual(
				new Vertex3ub((byte)1.0f, (byte)11.0f, (byte)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex3ub.Min(Vertex3ub[]) ArgumentNullException")]
		public void Vertex3ub_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex3ub.Min(null));
		}

		[Test(Description = "Test Vertex3ub.Min(Vertex3ub*)")]
		public void Vertex3ub_TestMin_Unsafe()
		{
			Vertex3ub[] v = new Vertex3ub[] {
				new Vertex3ub((byte)1.0f, (byte)13.0f, (byte)22.0f),
				new Vertex3ub((byte)2.0f, (byte)12.0f, (byte)21.0f),
				new Vertex3ub((byte)3.0f, (byte)11.0f, (byte)23.0f),
			};

			Vertex3ub min;

			unsafe {
				fixed (Vertex3ub* vPtr = v) {
					min = Vertex3ub.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex3ub((byte)1.0f, (byte)11.0f, (byte)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex3ub.Min(Vertex3ub*) ArgumentNullException")]
		public void Vertex3ub_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3ub.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex3ub.Max(Vertex3ub[])")]
		public void Vertex3ub_TestMax()
		{
			Vertex3ub[] v = new Vertex3ub[] {
				new Vertex3ub((byte)1.0f, (byte)13.0f, (byte)22.0f),
				new Vertex3ub((byte)2.0f, (byte)12.0f, (byte)21.0f),
				new Vertex3ub((byte)3.0f, (byte)11.0f, (byte)23.0f),
			};

			Vertex3ub max = Vertex3ub.Max(v);

			Assert.AreEqual(
				new Vertex3ub((byte)3.0f, (byte)13.0f, (byte)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3ub.Max(Vertex3ub[]) ArgumentNullException")]
		public void Vertex3ub_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex3ub.Max(null));
		}

		[Test(Description = "Test Vertex3ub.Max(Vertex3ub*)")]
		public void Vertex3ub_TestMax_Unsafe()
		{
			Vertex3ub[] v = new Vertex3ub[] {
				new Vertex3ub((byte)1.0f, (byte)13.0f, (byte)22.0f),
				new Vertex3ub((byte)2.0f, (byte)12.0f, (byte)21.0f),
				new Vertex3ub((byte)3.0f, (byte)11.0f, (byte)23.0f),
			};

			Vertex3ub max;

			unsafe {
				fixed (Vertex3ub* vPtr = v) {
					max = Vertex3ub.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex3ub((byte)3.0f, (byte)13.0f, (byte)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3ub.Max(Vertex3ub*) ArgumentNullException")]
		public void Vertex3ub_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3ub.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex3ub.Max(Vertex3ub[])")]
		public void Vertex3ub_TestMinMax()
		{
			Vertex3ub[] v = new Vertex3ub[] {
				new Vertex3ub((byte)1.0f, (byte)13.0f, (byte)22.0f),
				new Vertex3ub((byte)2.0f, (byte)12.0f, (byte)21.0f),
				new Vertex3ub((byte)3.0f, (byte)11.0f, (byte)23.0f),
			};

			Vertex3ub min, max;

			Vertex3ub.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex3ub((byte)1.0f, (byte)11.0f, (byte)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex3ub((byte)3.0f, (byte)13.0f, (byte)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3ub.Max(Vertex3ub[]) ArgumentNullException")]
		public void Vertex3ub_TestMinMax_ArgumentNullException()
		{
			Vertex3ub min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex3ub.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex3ub.MinMax(Vertex3ub*)")]
		public void Vertex3ub_TestMinMax_Unsafe()
		{
			Vertex3ub[] v = new Vertex3ub[] {
				new Vertex3ub((byte)1.0f, (byte)13.0f, (byte)22.0f),
				new Vertex3ub((byte)2.0f, (byte)12.0f, (byte)21.0f),
				new Vertex3ub((byte)3.0f, (byte)11.0f, (byte)23.0f),
			};

			Vertex3ub min, max;

			unsafe {
				fixed (Vertex3ub* vPtr = v) {
					Vertex3ub.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex3ub((byte)1.0f, (byte)11.0f, (byte)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex3ub((byte)3.0f, (byte)13.0f, (byte)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3ub.MinMax(Vertex3ub*) ArgumentNullException")]
		public void Vertex3ub_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex3ub min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3ub.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex3ub.Equals(Vertex3ub)")]
		public void Vertex3ub_TestEquals_Vertex3ub()
		{
			Vertex3ub v = Vertex3ub.UnitX;

			Assert.IsTrue(v.Equals(Vertex3ub.UnitX));
			Assert.IsFalse(v.Equals(Vertex3ub.UnitY));
			Assert.IsFalse(v.Equals(Vertex3ub.UnitZ));
		}

		[Test(Description = "Test Vertex3ub.Equals(object)")]
		public void Vertex3ub_TestEquals_Object()
		{
			Vertex3ub v = Vertex3ub.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex3ub.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex3ub.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex3ub.UnitZ));
		}

		[Test(Description = "Test Vertex3ub.GetHashCode()")]
		public void Vertex3ub_TestGetHashCode()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random);
			byte y = (byte)Next(random);
			byte z = (byte)Next(random);

			Vertex3ub v = new Vertex3ub(x, y, z);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex3ub.ToString()")]
		public void Vertex3ub_TestToString()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random);
			byte y = (byte)Next(random);
			byte z = (byte)Next(random);

			Vertex3ub v = new Vertex3ub(x, y, z);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex3bTest : Vertex3TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex3b(sbyte)")]
		public void Vertex3b_TestConstructor1()
		{
			Random random = new Random();
			sbyte randomValue = (sbyte)Next(random);
			
			Vertex3b v = new Vertex3b(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex3b(sbyte[])")]
		public void Vertex3b_TestConstructor2()
		{
			Random random = new Random();
			sbyte randomValueX = (sbyte)Next(random);
			sbyte randomValueY = (sbyte)Next(random);
			sbyte randomValueZ = (sbyte)Next(random);

			Vertex3b v = new Vertex3b(new sbyte[] {
				randomValueX, randomValueY, randomValueZ
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		[Test(Description = "Test Vertex3b(sbyte, sbyte, sbyte)")]
		public void Vertex3b_TestConstructor3()
		{
			Random random = new Random();
			sbyte randomValueX = (sbyte)Next(random);
			sbyte randomValueY = (sbyte)Next(random);
			sbyte randomValueZ = (sbyte)Next(random);

			Vertex3b v = new Vertex3b(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex3b.Size against Marshal.SizeOf")]
		public void Vertex3b_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex3b)), Vertex3b.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex3b.operator-(Vertex3b))")]
		public void Vertex3b_TestOperatorNegate()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random);
			sbyte y = (sbyte)Next(random);
			sbyte z = (sbyte)Next(random);

			Vertex3b v = new Vertex3b(x, y, z);
			Vertex3b n = -v;

			Assert.AreEqual(-x, n.x);
			Assert.AreEqual(-y, n.y);
			Assert.AreEqual(-z, n.z);
		}
		[Test(Description = "Test Vertex3b.operator+(Vertex3b, Vertex3b)")]
		public void Vertex3b_TestOperatorAdd()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random);
			sbyte y1 = (sbyte)Next(random);
			sbyte z1 = (sbyte)Next(random);

			Vertex3b v1 = new Vertex3b(x1, y1, z1);

			sbyte x2 = (sbyte)Next(random);
			sbyte y2 = (sbyte)Next(random);
			sbyte z2 = (sbyte)Next(random);

			Vertex3b v2 = new Vertex3b(x2, y2, z2);

			Vertex3b v = v1 + v2;

			Assert.AreEqual((sbyte)(x1 + x2), v.x);
			Assert.AreEqual((sbyte)(y1 + y2), v.y);
			Assert.AreEqual((sbyte)(z1 + z2), v.z);
		}

		[Test(Description = "Test Vertex3b.operator-(Vertex3b, Vertex3b)")]
		public void Vertex3b_TestOperatorSub()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random);
			sbyte y1 = (sbyte)Next(random);
			sbyte z1 = (sbyte)Next(random);

			Vertex3b v1 = new Vertex3b(x1, y1, z1);

			sbyte x2 = (sbyte)Next(random);
			sbyte y2 = (sbyte)Next(random);
			sbyte z2 = (sbyte)Next(random);

			Vertex3b v2 = new Vertex3b(x2, y2, z2);

			Vertex3b v = v1 - v2;

			Assert.AreEqual((sbyte)(x1 - x2), v.x);
			Assert.AreEqual((sbyte)(y1 - y2), v.y);
			Assert.AreEqual((sbyte)(z1 - z2), v.z);
		}

		[Test(Description = "Test Vertex3b.operator*(Vertex3b, Single)")]
		public void Vertex3b_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random);
			sbyte y1 = (sbyte)Next(random);
			sbyte z1 = (sbyte)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex3b v1 = new Vertex3b(x1, y1, z1);

			Vertex3b v = v1 * (float)s;

			Assert.AreEqual((sbyte)(x1 * (float)s), v.x);
			Assert.AreEqual((sbyte)(y1 * (float)s), v.y);
			Assert.AreEqual((sbyte)(z1 * (float)s), v.z);
		}

		[Test(Description = "Test Vertex3b.operator*(Vertex3b, Double)")]
		public void Vertex3b_TestOperatorMultiplyDouble()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random);
			sbyte y1 = (sbyte)Next(random);
			sbyte z1 = (sbyte)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex3b v1 = new Vertex3b(x1, y1, z1);

			Vertex3b v = v1 * s;

			Assert.AreEqual((sbyte)(x1 * s), v.x);
			Assert.AreEqual((sbyte)(y1 * s), v.y);
			Assert.AreEqual((sbyte)(z1 * s), v.z);
		}

		[Test(Description = "Test Vertex3b.operator/(Vertex3b, Single)")]
		public void Vertex3b_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random);
			sbyte y1 = (sbyte)Next(random);
			sbyte z1 = (sbyte)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex3b v1 = new Vertex3b(x1, y1, z1);

			Vertex3b v = v1 / (float)s;

			Assert.AreEqual((sbyte)(x1 / (float)s), v.x);
			Assert.AreEqual((sbyte)(y1 / (float)s), v.y);
			Assert.AreEqual((sbyte)(z1 / (float)s), v.z);
		}

		[Test(Description = "Test Vertex3b.operator/(Vertex3b, Double)")]
		public void Vertex3b_TestOperatorDivideDouble()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random);
			sbyte y1 = (sbyte)Next(random);
			sbyte z1 = (sbyte)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex3b v1 = new Vertex3b(x1, y1, z1);

			Vertex3b v = v1 / s;

			Assert.AreEqual((sbyte)(x1 / s), v.x);
			Assert.AreEqual((sbyte)(y1 / s), v.y);
			Assert.AreEqual((sbyte)(z1 / s), v.z);
		}

		[Test(Description = "Test Vertex3b.operator*(Vertex3b, Vertex3b)")]
		public void Vertex3b_TestOperatorDotProduct()
		{
			Vertex3b a, b;
			float d;

			a = Vertex3b.UnitX;
			b = Vertex3b.UnitY;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3b.UnitY;
			b = Vertex3b.UnitZ;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3b.UnitX;
			b = Vertex3b.UnitZ;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3b.UnitX;
			b = Vertex3b.UnitX;
			d = a * b;
			Assert.AreEqual(1.0, d);

			a = Vertex3b.UnitY;
			b = Vertex3b.UnitY;
			d = a * b;
			Assert.AreEqual(1.0, d);

			a = Vertex3b.UnitZ;
			b = Vertex3b.UnitZ;
			d = a * b;
			Assert.AreEqual(1.0, d);
		}

		[Test(Description = "Test Vertex3b.operator^(Vertex3b, Vertex3b)")]
		public void Vertex3b_TestOperatorCrossProduct()
		{
			Vertex3b a, b;
			Vertex3f c;

			a = Vertex3b.UnitX;
			b = Vertex3b.UnitY;
			c = a ^ b;
			Assert.AreEqual(Vertex3f.UnitZ, c);
		}

		[Test(Description = "Test Vertex3b.operator*(Vertex3b, sbyte)")]
		public void Vertex3b_TestOperatorScalarMultiply()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random);
			sbyte y1 = (sbyte)Next(random);
			sbyte z1 = (sbyte)Next(random);
			sbyte s = (sbyte)Next(random, 0.0, 32.0);

			Vertex3b v1 = new Vertex3b(x1, y1, z1);

			Vertex3b v = v1 * s;

			Assert.AreEqual((sbyte)(x1 * s), v.x);
			Assert.AreEqual((sbyte)(y1 * s), v.y);
			Assert.AreEqual((sbyte)(z1 * s), v.z);
		}

		[Test(Description = "Test Vertex3b.operator/(Vertex3b, sbyte)")]
		public void Vertex3b_TestOperatorScalarDivide()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random);
			sbyte y1 = (sbyte)Next(random);
			sbyte z1 = (sbyte)Next(random);
			sbyte s = (sbyte)Next(random, 1.0, 32.0);

			Vertex3b v1 = new Vertex3b(x1, y1, z1);

			Vertex3b v = v1 / s;

			Assert.AreEqual((sbyte)(x1 / s), v.x);
			Assert.AreEqual((sbyte)(y1 / s), v.y);
			Assert.AreEqual((sbyte)(z1 / s), v.z);
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex3b.operator==(Vertex3b, Vertex3b)")]
		public void Vertex3b_TestOperatorEquality()
		{
			Vertex3b v = Vertex3b.UnitX;

			Assert.IsTrue(v == Vertex3b.UnitX);
			Assert.IsFalse(v == Vertex3b.UnitY);
		}

		[Test(Description = "Test Vertex3b.operator!=(Vertex3b, Vertex3b)")]
		public void Vertex3b_TestOperatorInequality()
		{
			Vertex3b v = Vertex3b.UnitX;

			Assert.IsFalse(v != Vertex3b.UnitX);
			Assert.IsTrue(v != Vertex3b.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex3b.operator sbyte[](Vertex3b)")]
		public void Vertex3b_TestCastToArray()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random);
			sbyte y = (sbyte)Next(random);
			sbyte z = (sbyte)Next(random);

			Vertex3b v = new Vertex3b(x, y, z);
			sbyte[] vArray = (sbyte[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex3b.operator Vertex3f(Vertex3b)")]
		public void Vertex3b_TestCastToVertex3f()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random);
			sbyte y = (sbyte)Next(random);
			sbyte z = (sbyte)Next(random);

			Vertex3b v = new Vertex3b(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.x, v3f.x, 1e-4f);
			Assert.AreEqual(v.y, v3f.y, 1e-4f);
			Assert.AreEqual(v.z, v3f.z, 1e-4f);
		}

		[Test(Description = "Test Vertex3b.operator Vertex4f(Vertex3b)")]
		public void Vertex3b_TestCastToVertex4f()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random);
			sbyte y = (sbyte)Next(random);
			sbyte z = (sbyte)Next(random);

			Vertex3b v = new Vertex3b(x, y, z);
			Vertex4f v4f = (Vertex4f)v;

			Assert.AreEqual(v.x, v4f.x, 1e-4);
			Assert.AreEqual(v.y, v4f.y, 1e-4);
			Assert.AreEqual(v.z, v4f.z, 1e-4);
			Assert.AreEqual(1.0f, v4f.w, 1e-4);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex3b.Module()")]
		public void Vertex3b_TestModule()
		{
			Assert.AreEqual(3.741657f, new Vertex3b((sbyte)1.0, (sbyte)2.0, (sbyte)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex3b((sbyte)2.0, (sbyte)5.0, (sbyte)7.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex3b.ModuleSquared()")]
		public void Vertex3b_TestModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex3b((sbyte)1.0, (sbyte)2.0, (sbyte)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex3b((sbyte)2.0, (sbyte)5.0, (sbyte)7.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex3b.Normalize()")]
		public void Vertex3b_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex3b.Zero.Normalize(); });

			Vertex3b v;

			v = Vertex3b.UnitX * (sbyte)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3b.UnitX, v);

			v = Vertex3b.UnitY * (sbyte)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3b.UnitY, v);

			v = Vertex3b.UnitZ * (sbyte)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3b.UnitZ, v);
		}

		[Test(Description = "Test Vertex3b.Normalized")]
		public void Vertex3b_TestNormalized()
		{
			Vertex3b v;

			Assert.DoesNotThrow(delegate() { v = Vertex3b.Zero.Normalized; });

			v = Vertex3b.UnitX * (sbyte)2.0f;
			Assert.AreEqual(Vertex3b.UnitX, v.Normalized);

			v = Vertex3b.UnitY * (sbyte)2.0f;
			Assert.AreEqual(Vertex3b.UnitY, v.Normalized);

			v = Vertex3b.UnitZ * (sbyte)2.0f;
			Assert.AreEqual(Vertex3b.UnitZ, v.Normalized);
		}

		[Test(Description = "Test Vertex3b.Min(Vertex3b[])")]
		public void Vertex3b_TestMin()
		{
			Vertex3b[] v = new Vertex3b[] {
				new Vertex3b((sbyte)1.0f, (sbyte)13.0f, (sbyte)22.0f),
				new Vertex3b((sbyte)2.0f, (sbyte)12.0f, (sbyte)21.0f),
				new Vertex3b((sbyte)3.0f, (sbyte)11.0f, (sbyte)23.0f),
			};

			Vertex3b min = Vertex3b.Min(v);

			Assert.AreEqual(
				new Vertex3b((sbyte)1.0f, (sbyte)11.0f, (sbyte)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex3b.Min(Vertex3b[]) ArgumentNullException")]
		public void Vertex3b_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex3b.Min(null));
		}

		[Test(Description = "Test Vertex3b.Min(Vertex3b*)")]
		public void Vertex3b_TestMin_Unsafe()
		{
			Vertex3b[] v = new Vertex3b[] {
				new Vertex3b((sbyte)1.0f, (sbyte)13.0f, (sbyte)22.0f),
				new Vertex3b((sbyte)2.0f, (sbyte)12.0f, (sbyte)21.0f),
				new Vertex3b((sbyte)3.0f, (sbyte)11.0f, (sbyte)23.0f),
			};

			Vertex3b min;

			unsafe {
				fixed (Vertex3b* vPtr = v) {
					min = Vertex3b.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex3b((sbyte)1.0f, (sbyte)11.0f, (sbyte)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex3b.Min(Vertex3b*) ArgumentNullException")]
		public void Vertex3b_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3b.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex3b.Max(Vertex3b[])")]
		public void Vertex3b_TestMax()
		{
			Vertex3b[] v = new Vertex3b[] {
				new Vertex3b((sbyte)1.0f, (sbyte)13.0f, (sbyte)22.0f),
				new Vertex3b((sbyte)2.0f, (sbyte)12.0f, (sbyte)21.0f),
				new Vertex3b((sbyte)3.0f, (sbyte)11.0f, (sbyte)23.0f),
			};

			Vertex3b max = Vertex3b.Max(v);

			Assert.AreEqual(
				new Vertex3b((sbyte)3.0f, (sbyte)13.0f, (sbyte)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3b.Max(Vertex3b[]) ArgumentNullException")]
		public void Vertex3b_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex3b.Max(null));
		}

		[Test(Description = "Test Vertex3b.Max(Vertex3b*)")]
		public void Vertex3b_TestMax_Unsafe()
		{
			Vertex3b[] v = new Vertex3b[] {
				new Vertex3b((sbyte)1.0f, (sbyte)13.0f, (sbyte)22.0f),
				new Vertex3b((sbyte)2.0f, (sbyte)12.0f, (sbyte)21.0f),
				new Vertex3b((sbyte)3.0f, (sbyte)11.0f, (sbyte)23.0f),
			};

			Vertex3b max;

			unsafe {
				fixed (Vertex3b* vPtr = v) {
					max = Vertex3b.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex3b((sbyte)3.0f, (sbyte)13.0f, (sbyte)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3b.Max(Vertex3b*) ArgumentNullException")]
		public void Vertex3b_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3b.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex3b.Max(Vertex3b[])")]
		public void Vertex3b_TestMinMax()
		{
			Vertex3b[] v = new Vertex3b[] {
				new Vertex3b((sbyte)1.0f, (sbyte)13.0f, (sbyte)22.0f),
				new Vertex3b((sbyte)2.0f, (sbyte)12.0f, (sbyte)21.0f),
				new Vertex3b((sbyte)3.0f, (sbyte)11.0f, (sbyte)23.0f),
			};

			Vertex3b min, max;

			Vertex3b.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex3b((sbyte)1.0f, (sbyte)11.0f, (sbyte)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex3b((sbyte)3.0f, (sbyte)13.0f, (sbyte)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3b.Max(Vertex3b[]) ArgumentNullException")]
		public void Vertex3b_TestMinMax_ArgumentNullException()
		{
			Vertex3b min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex3b.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex3b.MinMax(Vertex3b*)")]
		public void Vertex3b_TestMinMax_Unsafe()
		{
			Vertex3b[] v = new Vertex3b[] {
				new Vertex3b((sbyte)1.0f, (sbyte)13.0f, (sbyte)22.0f),
				new Vertex3b((sbyte)2.0f, (sbyte)12.0f, (sbyte)21.0f),
				new Vertex3b((sbyte)3.0f, (sbyte)11.0f, (sbyte)23.0f),
			};

			Vertex3b min, max;

			unsafe {
				fixed (Vertex3b* vPtr = v) {
					Vertex3b.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex3b((sbyte)1.0f, (sbyte)11.0f, (sbyte)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex3b((sbyte)3.0f, (sbyte)13.0f, (sbyte)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3b.MinMax(Vertex3b*) ArgumentNullException")]
		public void Vertex3b_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex3b min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3b.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex3b.Equals(Vertex3b)")]
		public void Vertex3b_TestEquals_Vertex3b()
		{
			Vertex3b v = Vertex3b.UnitX;

			Assert.IsTrue(v.Equals(Vertex3b.UnitX));
			Assert.IsFalse(v.Equals(Vertex3b.UnitY));
			Assert.IsFalse(v.Equals(Vertex3b.UnitZ));
		}

		[Test(Description = "Test Vertex3b.Equals(object)")]
		public void Vertex3b_TestEquals_Object()
		{
			Vertex3b v = Vertex3b.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex3b.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex3b.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex3b.UnitZ));
		}

		[Test(Description = "Test Vertex3b.GetHashCode()")]
		public void Vertex3b_TestGetHashCode()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random);
			sbyte y = (sbyte)Next(random);
			sbyte z = (sbyte)Next(random);

			Vertex3b v = new Vertex3b(x, y, z);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex3b.ToString()")]
		public void Vertex3b_TestToString()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random);
			sbyte y = (sbyte)Next(random);
			sbyte z = (sbyte)Next(random);

			Vertex3b v = new Vertex3b(x, y, z);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex3usTest : Vertex3TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex3us(ushort)")]
		public void Vertex3us_TestConstructor1()
		{
			Random random = new Random();
			ushort randomValue = (ushort)Next(random);
			
			Vertex3us v = new Vertex3us(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex3us(ushort[])")]
		public void Vertex3us_TestConstructor2()
		{
			Random random = new Random();
			ushort randomValueX = (ushort)Next(random);
			ushort randomValueY = (ushort)Next(random);
			ushort randomValueZ = (ushort)Next(random);

			Vertex3us v = new Vertex3us(new ushort[] {
				randomValueX, randomValueY, randomValueZ
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		[Test(Description = "Test Vertex3us(ushort, ushort, ushort)")]
		public void Vertex3us_TestConstructor3()
		{
			Random random = new Random();
			ushort randomValueX = (ushort)Next(random);
			ushort randomValueY = (ushort)Next(random);
			ushort randomValueZ = (ushort)Next(random);

			Vertex3us v = new Vertex3us(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex3us.Size against Marshal.SizeOf")]
		public void Vertex3us_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex3us)), Vertex3us.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex3us.operator+(Vertex3us, Vertex3us)")]
		public void Vertex3us_TestOperatorAdd()
		{
			Random random = new Random();
			
			ushort x1 = (ushort)Next(random);
			ushort y1 = (ushort)Next(random);
			ushort z1 = (ushort)Next(random);

			Vertex3us v1 = new Vertex3us(x1, y1, z1);

			ushort x2 = (ushort)Next(random);
			ushort y2 = (ushort)Next(random);
			ushort z2 = (ushort)Next(random);

			Vertex3us v2 = new Vertex3us(x2, y2, z2);

			Vertex3us v = v1 + v2;

			Assert.AreEqual((ushort)(x1 + x2), v.x);
			Assert.AreEqual((ushort)(y1 + y2), v.y);
			Assert.AreEqual((ushort)(z1 + z2), v.z);
		}

		[Test(Description = "Test Vertex3us.operator-(Vertex3us, Vertex3us)")]
		public void Vertex3us_TestOperatorSub()
		{
			Random random = new Random();
			
			ushort x1 = (ushort)Next(random);
			ushort y1 = (ushort)Next(random);
			ushort z1 = (ushort)Next(random);

			Vertex3us v1 = new Vertex3us(x1, y1, z1);

			ushort x2 = (ushort)Next(random);
			ushort y2 = (ushort)Next(random);
			ushort z2 = (ushort)Next(random);

			Vertex3us v2 = new Vertex3us(x2, y2, z2);

			Vertex3us v = v1 - v2;

			Assert.AreEqual((ushort)(x1 - x2), v.x);
			Assert.AreEqual((ushort)(y1 - y2), v.y);
			Assert.AreEqual((ushort)(z1 - z2), v.z);
		}

		[Test(Description = "Test Vertex3us.operator*(Vertex3us, Single)")]
		public void Vertex3us_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			ushort x1 = (ushort)Next(random);
			ushort y1 = (ushort)Next(random);
			ushort z1 = (ushort)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex3us v1 = new Vertex3us(x1, y1, z1);

			Vertex3us v = v1 * (float)s;

			Assert.AreEqual((ushort)(x1 * (float)s), v.x);
			Assert.AreEqual((ushort)(y1 * (float)s), v.y);
			Assert.AreEqual((ushort)(z1 * (float)s), v.z);
		}

		[Test(Description = "Test Vertex3us.operator*(Vertex3us, Double)")]
		public void Vertex3us_TestOperatorMultiplyDouble()
		{
			Random random = new Random();
			
			ushort x1 = (ushort)Next(random);
			ushort y1 = (ushort)Next(random);
			ushort z1 = (ushort)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex3us v1 = new Vertex3us(x1, y1, z1);

			Vertex3us v = v1 * s;

			Assert.AreEqual((ushort)(x1 * s), v.x);
			Assert.AreEqual((ushort)(y1 * s), v.y);
			Assert.AreEqual((ushort)(z1 * s), v.z);
		}

		[Test(Description = "Test Vertex3us.operator/(Vertex3us, Single)")]
		public void Vertex3us_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			ushort x1 = (ushort)Next(random);
			ushort y1 = (ushort)Next(random);
			ushort z1 = (ushort)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex3us v1 = new Vertex3us(x1, y1, z1);

			Vertex3us v = v1 / (float)s;

			Assert.AreEqual((ushort)(x1 / (float)s), v.x);
			Assert.AreEqual((ushort)(y1 / (float)s), v.y);
			Assert.AreEqual((ushort)(z1 / (float)s), v.z);
		}

		[Test(Description = "Test Vertex3us.operator/(Vertex3us, Double)")]
		public void Vertex3us_TestOperatorDivideDouble()
		{
			Random random = new Random();
			
			ushort x1 = (ushort)Next(random);
			ushort y1 = (ushort)Next(random);
			ushort z1 = (ushort)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex3us v1 = new Vertex3us(x1, y1, z1);

			Vertex3us v = v1 / s;

			Assert.AreEqual((ushort)(x1 / s), v.x);
			Assert.AreEqual((ushort)(y1 / s), v.y);
			Assert.AreEqual((ushort)(z1 / s), v.z);
		}

		[Test(Description = "Test Vertex3us.operator*(Vertex3us, Vertex3us)")]
		public void Vertex3us_TestOperatorDotProduct()
		{
			Vertex3us a, b;
			float d;

			a = Vertex3us.UnitX;
			b = Vertex3us.UnitY;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3us.UnitY;
			b = Vertex3us.UnitZ;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3us.UnitX;
			b = Vertex3us.UnitZ;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3us.UnitX;
			b = Vertex3us.UnitX;
			d = a * b;
			Assert.AreEqual(1.0, d);

			a = Vertex3us.UnitY;
			b = Vertex3us.UnitY;
			d = a * b;
			Assert.AreEqual(1.0, d);

			a = Vertex3us.UnitZ;
			b = Vertex3us.UnitZ;
			d = a * b;
			Assert.AreEqual(1.0, d);
		}

		[Test(Description = "Test Vertex3us.operator^(Vertex3us, Vertex3us)")]
		public void Vertex3us_TestOperatorCrossProduct()
		{
			Vertex3us a, b;
			Vertex3f c;

			a = Vertex3us.UnitX;
			b = Vertex3us.UnitY;
			c = a ^ b;
			Assert.AreEqual(Vertex3f.UnitZ, c);
		}

		[Test(Description = "Test Vertex3us.operator*(Vertex3us, ushort)")]
		public void Vertex3us_TestOperatorScalarMultiply()
		{
			Random random = new Random();
			
			ushort x1 = (ushort)Next(random);
			ushort y1 = (ushort)Next(random);
			ushort z1 = (ushort)Next(random);
			ushort s = (ushort)Next(random, 0.0, 32.0);

			Vertex3us v1 = new Vertex3us(x1, y1, z1);

			Vertex3us v = v1 * s;

			Assert.AreEqual((ushort)(x1 * s), v.x);
			Assert.AreEqual((ushort)(y1 * s), v.y);
			Assert.AreEqual((ushort)(z1 * s), v.z);
		}

		[Test(Description = "Test Vertex3us.operator/(Vertex3us, ushort)")]
		public void Vertex3us_TestOperatorScalarDivide()
		{
			Random random = new Random();
			
			ushort x1 = (ushort)Next(random);
			ushort y1 = (ushort)Next(random);
			ushort z1 = (ushort)Next(random);
			ushort s = (ushort)Next(random, 1.0, 32.0);

			Vertex3us v1 = new Vertex3us(x1, y1, z1);

			Vertex3us v = v1 / s;

			Assert.AreEqual((ushort)(x1 / s), v.x);
			Assert.AreEqual((ushort)(y1 / s), v.y);
			Assert.AreEqual((ushort)(z1 / s), v.z);
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex3us.operator==(Vertex3us, Vertex3us)")]
		public void Vertex3us_TestOperatorEquality()
		{
			Vertex3us v = Vertex3us.UnitX;

			Assert.IsTrue(v == Vertex3us.UnitX);
			Assert.IsFalse(v == Vertex3us.UnitY);
		}

		[Test(Description = "Test Vertex3us.operator!=(Vertex3us, Vertex3us)")]
		public void Vertex3us_TestOperatorInequality()
		{
			Vertex3us v = Vertex3us.UnitX;

			Assert.IsFalse(v != Vertex3us.UnitX);
			Assert.IsTrue(v != Vertex3us.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex3us.operator ushort[](Vertex3us)")]
		public void Vertex3us_TestCastToArray()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random);
			ushort y = (ushort)Next(random);
			ushort z = (ushort)Next(random);

			Vertex3us v = new Vertex3us(x, y, z);
			ushort[] vArray = (ushort[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex3us.operator Vertex3f(Vertex3us)")]
		public void Vertex3us_TestCastToVertex3f()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random);
			ushort y = (ushort)Next(random);
			ushort z = (ushort)Next(random);

			Vertex3us v = new Vertex3us(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.x, v3f.x, 1e-4f);
			Assert.AreEqual(v.y, v3f.y, 1e-4f);
			Assert.AreEqual(v.z, v3f.z, 1e-4f);
		}

		[Test(Description = "Test Vertex3us.operator Vertex4f(Vertex3us)")]
		public void Vertex3us_TestCastToVertex4f()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random);
			ushort y = (ushort)Next(random);
			ushort z = (ushort)Next(random);

			Vertex3us v = new Vertex3us(x, y, z);
			Vertex4f v4f = (Vertex4f)v;

			Assert.AreEqual(v.x, v4f.x, 1e-4);
			Assert.AreEqual(v.y, v4f.y, 1e-4);
			Assert.AreEqual(v.z, v4f.z, 1e-4);
			Assert.AreEqual(1.0f, v4f.w, 1e-4);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex3us.Module()")]
		public void Vertex3us_TestModule()
		{
			Assert.AreEqual(3.741657f, new Vertex3us((ushort)1.0, (ushort)2.0, (ushort)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex3us((ushort)2.0, (ushort)5.0, (ushort)7.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex3us.ModuleSquared()")]
		public void Vertex3us_TestModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex3us((ushort)1.0, (ushort)2.0, (ushort)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex3us((ushort)2.0, (ushort)5.0, (ushort)7.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex3us.Normalize()")]
		public void Vertex3us_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex3us.Zero.Normalize(); });

			Vertex3us v;

			v = Vertex3us.UnitX * (ushort)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3us.UnitX, v);

			v = Vertex3us.UnitY * (ushort)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3us.UnitY, v);

			v = Vertex3us.UnitZ * (ushort)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3us.UnitZ, v);
		}

		[Test(Description = "Test Vertex3us.Normalized")]
		public void Vertex3us_TestNormalized()
		{
			Vertex3us v;

			Assert.DoesNotThrow(delegate() { v = Vertex3us.Zero.Normalized; });

			v = Vertex3us.UnitX * (ushort)2.0f;
			Assert.AreEqual(Vertex3us.UnitX, v.Normalized);

			v = Vertex3us.UnitY * (ushort)2.0f;
			Assert.AreEqual(Vertex3us.UnitY, v.Normalized);

			v = Vertex3us.UnitZ * (ushort)2.0f;
			Assert.AreEqual(Vertex3us.UnitZ, v.Normalized);
		}

		[Test(Description = "Test Vertex3us.Min(Vertex3us[])")]
		public void Vertex3us_TestMin()
		{
			Vertex3us[] v = new Vertex3us[] {
				new Vertex3us((ushort)1.0f, (ushort)13.0f, (ushort)22.0f),
				new Vertex3us((ushort)2.0f, (ushort)12.0f, (ushort)21.0f),
				new Vertex3us((ushort)3.0f, (ushort)11.0f, (ushort)23.0f),
			};

			Vertex3us min = Vertex3us.Min(v);

			Assert.AreEqual(
				new Vertex3us((ushort)1.0f, (ushort)11.0f, (ushort)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex3us.Min(Vertex3us[]) ArgumentNullException")]
		public void Vertex3us_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex3us.Min(null));
		}

		[Test(Description = "Test Vertex3us.Min(Vertex3us*)")]
		public void Vertex3us_TestMin_Unsafe()
		{
			Vertex3us[] v = new Vertex3us[] {
				new Vertex3us((ushort)1.0f, (ushort)13.0f, (ushort)22.0f),
				new Vertex3us((ushort)2.0f, (ushort)12.0f, (ushort)21.0f),
				new Vertex3us((ushort)3.0f, (ushort)11.0f, (ushort)23.0f),
			};

			Vertex3us min;

			unsafe {
				fixed (Vertex3us* vPtr = v) {
					min = Vertex3us.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex3us((ushort)1.0f, (ushort)11.0f, (ushort)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex3us.Min(Vertex3us*) ArgumentNullException")]
		public void Vertex3us_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3us.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex3us.Max(Vertex3us[])")]
		public void Vertex3us_TestMax()
		{
			Vertex3us[] v = new Vertex3us[] {
				new Vertex3us((ushort)1.0f, (ushort)13.0f, (ushort)22.0f),
				new Vertex3us((ushort)2.0f, (ushort)12.0f, (ushort)21.0f),
				new Vertex3us((ushort)3.0f, (ushort)11.0f, (ushort)23.0f),
			};

			Vertex3us max = Vertex3us.Max(v);

			Assert.AreEqual(
				new Vertex3us((ushort)3.0f, (ushort)13.0f, (ushort)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3us.Max(Vertex3us[]) ArgumentNullException")]
		public void Vertex3us_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex3us.Max(null));
		}

		[Test(Description = "Test Vertex3us.Max(Vertex3us*)")]
		public void Vertex3us_TestMax_Unsafe()
		{
			Vertex3us[] v = new Vertex3us[] {
				new Vertex3us((ushort)1.0f, (ushort)13.0f, (ushort)22.0f),
				new Vertex3us((ushort)2.0f, (ushort)12.0f, (ushort)21.0f),
				new Vertex3us((ushort)3.0f, (ushort)11.0f, (ushort)23.0f),
			};

			Vertex3us max;

			unsafe {
				fixed (Vertex3us* vPtr = v) {
					max = Vertex3us.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex3us((ushort)3.0f, (ushort)13.0f, (ushort)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3us.Max(Vertex3us*) ArgumentNullException")]
		public void Vertex3us_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3us.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex3us.Max(Vertex3us[])")]
		public void Vertex3us_TestMinMax()
		{
			Vertex3us[] v = new Vertex3us[] {
				new Vertex3us((ushort)1.0f, (ushort)13.0f, (ushort)22.0f),
				new Vertex3us((ushort)2.0f, (ushort)12.0f, (ushort)21.0f),
				new Vertex3us((ushort)3.0f, (ushort)11.0f, (ushort)23.0f),
			};

			Vertex3us min, max;

			Vertex3us.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex3us((ushort)1.0f, (ushort)11.0f, (ushort)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex3us((ushort)3.0f, (ushort)13.0f, (ushort)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3us.Max(Vertex3us[]) ArgumentNullException")]
		public void Vertex3us_TestMinMax_ArgumentNullException()
		{
			Vertex3us min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex3us.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex3us.MinMax(Vertex3us*)")]
		public void Vertex3us_TestMinMax_Unsafe()
		{
			Vertex3us[] v = new Vertex3us[] {
				new Vertex3us((ushort)1.0f, (ushort)13.0f, (ushort)22.0f),
				new Vertex3us((ushort)2.0f, (ushort)12.0f, (ushort)21.0f),
				new Vertex3us((ushort)3.0f, (ushort)11.0f, (ushort)23.0f),
			};

			Vertex3us min, max;

			unsafe {
				fixed (Vertex3us* vPtr = v) {
					Vertex3us.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex3us((ushort)1.0f, (ushort)11.0f, (ushort)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex3us((ushort)3.0f, (ushort)13.0f, (ushort)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3us.MinMax(Vertex3us*) ArgumentNullException")]
		public void Vertex3us_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex3us min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3us.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex3us.Equals(Vertex3us)")]
		public void Vertex3us_TestEquals_Vertex3us()
		{
			Vertex3us v = Vertex3us.UnitX;

			Assert.IsTrue(v.Equals(Vertex3us.UnitX));
			Assert.IsFalse(v.Equals(Vertex3us.UnitY));
			Assert.IsFalse(v.Equals(Vertex3us.UnitZ));
		}

		[Test(Description = "Test Vertex3us.Equals(object)")]
		public void Vertex3us_TestEquals_Object()
		{
			Vertex3us v = Vertex3us.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex3us.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex3us.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex3us.UnitZ));
		}

		[Test(Description = "Test Vertex3us.GetHashCode()")]
		public void Vertex3us_TestGetHashCode()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random);
			ushort y = (ushort)Next(random);
			ushort z = (ushort)Next(random);

			Vertex3us v = new Vertex3us(x, y, z);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex3us.ToString()")]
		public void Vertex3us_TestToString()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random);
			ushort y = (ushort)Next(random);
			ushort z = (ushort)Next(random);

			Vertex3us v = new Vertex3us(x, y, z);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex3sTest : Vertex3TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex3s(short)")]
		public void Vertex3s_TestConstructor1()
		{
			Random random = new Random();
			short randomValue = (short)Next(random);
			
			Vertex3s v = new Vertex3s(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex3s(short[])")]
		public void Vertex3s_TestConstructor2()
		{
			Random random = new Random();
			short randomValueX = (short)Next(random);
			short randomValueY = (short)Next(random);
			short randomValueZ = (short)Next(random);

			Vertex3s v = new Vertex3s(new short[] {
				randomValueX, randomValueY, randomValueZ
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		[Test(Description = "Test Vertex3s(short, short, short)")]
		public void Vertex3s_TestConstructor3()
		{
			Random random = new Random();
			short randomValueX = (short)Next(random);
			short randomValueY = (short)Next(random);
			short randomValueZ = (short)Next(random);

			Vertex3s v = new Vertex3s(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex3s.Size against Marshal.SizeOf")]
		public void Vertex3s_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex3s)), Vertex3s.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex3s.operator-(Vertex3s))")]
		public void Vertex3s_TestOperatorNegate()
		{
			Random random = new Random();
			
			short x = (short)Next(random);
			short y = (short)Next(random);
			short z = (short)Next(random);

			Vertex3s v = new Vertex3s(x, y, z);
			Vertex3s n = -v;

			Assert.AreEqual(-x, n.x);
			Assert.AreEqual(-y, n.y);
			Assert.AreEqual(-z, n.z);
		}
		[Test(Description = "Test Vertex3s.operator+(Vertex3s, Vertex3s)")]
		public void Vertex3s_TestOperatorAdd()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random);
			short y1 = (short)Next(random);
			short z1 = (short)Next(random);

			Vertex3s v1 = new Vertex3s(x1, y1, z1);

			short x2 = (short)Next(random);
			short y2 = (short)Next(random);
			short z2 = (short)Next(random);

			Vertex3s v2 = new Vertex3s(x2, y2, z2);

			Vertex3s v = v1 + v2;

			Assert.AreEqual((short)(x1 + x2), v.x);
			Assert.AreEqual((short)(y1 + y2), v.y);
			Assert.AreEqual((short)(z1 + z2), v.z);
		}

		[Test(Description = "Test Vertex3s.operator-(Vertex3s, Vertex3s)")]
		public void Vertex3s_TestOperatorSub()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random);
			short y1 = (short)Next(random);
			short z1 = (short)Next(random);

			Vertex3s v1 = new Vertex3s(x1, y1, z1);

			short x2 = (short)Next(random);
			short y2 = (short)Next(random);
			short z2 = (short)Next(random);

			Vertex3s v2 = new Vertex3s(x2, y2, z2);

			Vertex3s v = v1 - v2;

			Assert.AreEqual((short)(x1 - x2), v.x);
			Assert.AreEqual((short)(y1 - y2), v.y);
			Assert.AreEqual((short)(z1 - z2), v.z);
		}

		[Test(Description = "Test Vertex3s.operator*(Vertex3s, Single)")]
		public void Vertex3s_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random);
			short y1 = (short)Next(random);
			short z1 = (short)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex3s v1 = new Vertex3s(x1, y1, z1);

			Vertex3s v = v1 * (float)s;

			Assert.AreEqual((short)(x1 * (float)s), v.x);
			Assert.AreEqual((short)(y1 * (float)s), v.y);
			Assert.AreEqual((short)(z1 * (float)s), v.z);
		}

		[Test(Description = "Test Vertex3s.operator*(Vertex3s, Double)")]
		public void Vertex3s_TestOperatorMultiplyDouble()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random);
			short y1 = (short)Next(random);
			short z1 = (short)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex3s v1 = new Vertex3s(x1, y1, z1);

			Vertex3s v = v1 * s;

			Assert.AreEqual((short)(x1 * s), v.x);
			Assert.AreEqual((short)(y1 * s), v.y);
			Assert.AreEqual((short)(z1 * s), v.z);
		}

		[Test(Description = "Test Vertex3s.operator/(Vertex3s, Single)")]
		public void Vertex3s_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random);
			short y1 = (short)Next(random);
			short z1 = (short)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex3s v1 = new Vertex3s(x1, y1, z1);

			Vertex3s v = v1 / (float)s;

			Assert.AreEqual((short)(x1 / (float)s), v.x);
			Assert.AreEqual((short)(y1 / (float)s), v.y);
			Assert.AreEqual((short)(z1 / (float)s), v.z);
		}

		[Test(Description = "Test Vertex3s.operator/(Vertex3s, Double)")]
		public void Vertex3s_TestOperatorDivideDouble()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random);
			short y1 = (short)Next(random);
			short z1 = (short)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex3s v1 = new Vertex3s(x1, y1, z1);

			Vertex3s v = v1 / s;

			Assert.AreEqual((short)(x1 / s), v.x);
			Assert.AreEqual((short)(y1 / s), v.y);
			Assert.AreEqual((short)(z1 / s), v.z);
		}

		[Test(Description = "Test Vertex3s.operator*(Vertex3s, Vertex3s)")]
		public void Vertex3s_TestOperatorDotProduct()
		{
			Vertex3s a, b;
			float d;

			a = Vertex3s.UnitX;
			b = Vertex3s.UnitY;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3s.UnitY;
			b = Vertex3s.UnitZ;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3s.UnitX;
			b = Vertex3s.UnitZ;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3s.UnitX;
			b = Vertex3s.UnitX;
			d = a * b;
			Assert.AreEqual(1.0, d);

			a = Vertex3s.UnitY;
			b = Vertex3s.UnitY;
			d = a * b;
			Assert.AreEqual(1.0, d);

			a = Vertex3s.UnitZ;
			b = Vertex3s.UnitZ;
			d = a * b;
			Assert.AreEqual(1.0, d);
		}

		[Test(Description = "Test Vertex3s.operator^(Vertex3s, Vertex3s)")]
		public void Vertex3s_TestOperatorCrossProduct()
		{
			Vertex3s a, b;
			Vertex3f c;

			a = Vertex3s.UnitX;
			b = Vertex3s.UnitY;
			c = a ^ b;
			Assert.AreEqual(Vertex3f.UnitZ, c);
		}

		[Test(Description = "Test Vertex3s.operator*(Vertex3s, short)")]
		public void Vertex3s_TestOperatorScalarMultiply()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random);
			short y1 = (short)Next(random);
			short z1 = (short)Next(random);
			short s = (short)Next(random, 0.0, 32.0);

			Vertex3s v1 = new Vertex3s(x1, y1, z1);

			Vertex3s v = v1 * s;

			Assert.AreEqual((short)(x1 * s), v.x);
			Assert.AreEqual((short)(y1 * s), v.y);
			Assert.AreEqual((short)(z1 * s), v.z);
		}

		[Test(Description = "Test Vertex3s.operator/(Vertex3s, short)")]
		public void Vertex3s_TestOperatorScalarDivide()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random);
			short y1 = (short)Next(random);
			short z1 = (short)Next(random);
			short s = (short)Next(random, 1.0, 32.0);

			Vertex3s v1 = new Vertex3s(x1, y1, z1);

			Vertex3s v = v1 / s;

			Assert.AreEqual((short)(x1 / s), v.x);
			Assert.AreEqual((short)(y1 / s), v.y);
			Assert.AreEqual((short)(z1 / s), v.z);
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex3s.operator==(Vertex3s, Vertex3s)")]
		public void Vertex3s_TestOperatorEquality()
		{
			Vertex3s v = Vertex3s.UnitX;

			Assert.IsTrue(v == Vertex3s.UnitX);
			Assert.IsFalse(v == Vertex3s.UnitY);
		}

		[Test(Description = "Test Vertex3s.operator!=(Vertex3s, Vertex3s)")]
		public void Vertex3s_TestOperatorInequality()
		{
			Vertex3s v = Vertex3s.UnitX;

			Assert.IsFalse(v != Vertex3s.UnitX);
			Assert.IsTrue(v != Vertex3s.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex3s.operator short[](Vertex3s)")]
		public void Vertex3s_TestCastToArray()
		{
			Random random = new Random();
			
			short x = (short)Next(random);
			short y = (short)Next(random);
			short z = (short)Next(random);

			Vertex3s v = new Vertex3s(x, y, z);
			short[] vArray = (short[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex3s.operator Vertex3f(Vertex3s)")]
		public void Vertex3s_TestCastToVertex3f()
		{
			Random random = new Random();
			
			short x = (short)Next(random);
			short y = (short)Next(random);
			short z = (short)Next(random);

			Vertex3s v = new Vertex3s(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.x, v3f.x, 1e-4f);
			Assert.AreEqual(v.y, v3f.y, 1e-4f);
			Assert.AreEqual(v.z, v3f.z, 1e-4f);
		}

		[Test(Description = "Test Vertex3s.operator Vertex4f(Vertex3s)")]
		public void Vertex3s_TestCastToVertex4f()
		{
			Random random = new Random();
			
			short x = (short)Next(random);
			short y = (short)Next(random);
			short z = (short)Next(random);

			Vertex3s v = new Vertex3s(x, y, z);
			Vertex4f v4f = (Vertex4f)v;

			Assert.AreEqual(v.x, v4f.x, 1e-4);
			Assert.AreEqual(v.y, v4f.y, 1e-4);
			Assert.AreEqual(v.z, v4f.z, 1e-4);
			Assert.AreEqual(1.0f, v4f.w, 1e-4);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex3s.Module()")]
		public void Vertex3s_TestModule()
		{
			Assert.AreEqual(3.741657f, new Vertex3s((short)1.0, (short)2.0, (short)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex3s((short)2.0, (short)5.0, (short)7.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex3s.ModuleSquared()")]
		public void Vertex3s_TestModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex3s((short)1.0, (short)2.0, (short)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex3s((short)2.0, (short)5.0, (short)7.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex3s.Normalize()")]
		public void Vertex3s_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex3s.Zero.Normalize(); });

			Vertex3s v;

			v = Vertex3s.UnitX * (short)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3s.UnitX, v);

			v = Vertex3s.UnitY * (short)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3s.UnitY, v);

			v = Vertex3s.UnitZ * (short)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3s.UnitZ, v);
		}

		[Test(Description = "Test Vertex3s.Normalized")]
		public void Vertex3s_TestNormalized()
		{
			Vertex3s v;

			Assert.DoesNotThrow(delegate() { v = Vertex3s.Zero.Normalized; });

			v = Vertex3s.UnitX * (short)2.0f;
			Assert.AreEqual(Vertex3s.UnitX, v.Normalized);

			v = Vertex3s.UnitY * (short)2.0f;
			Assert.AreEqual(Vertex3s.UnitY, v.Normalized);

			v = Vertex3s.UnitZ * (short)2.0f;
			Assert.AreEqual(Vertex3s.UnitZ, v.Normalized);
		}

		[Test(Description = "Test Vertex3s.Min(Vertex3s[])")]
		public void Vertex3s_TestMin()
		{
			Vertex3s[] v = new Vertex3s[] {
				new Vertex3s((short)1.0f, (short)13.0f, (short)22.0f),
				new Vertex3s((short)2.0f, (short)12.0f, (short)21.0f),
				new Vertex3s((short)3.0f, (short)11.0f, (short)23.0f),
			};

			Vertex3s min = Vertex3s.Min(v);

			Assert.AreEqual(
				new Vertex3s((short)1.0f, (short)11.0f, (short)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex3s.Min(Vertex3s[]) ArgumentNullException")]
		public void Vertex3s_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex3s.Min(null));
		}

		[Test(Description = "Test Vertex3s.Min(Vertex3s*)")]
		public void Vertex3s_TestMin_Unsafe()
		{
			Vertex3s[] v = new Vertex3s[] {
				new Vertex3s((short)1.0f, (short)13.0f, (short)22.0f),
				new Vertex3s((short)2.0f, (short)12.0f, (short)21.0f),
				new Vertex3s((short)3.0f, (short)11.0f, (short)23.0f),
			};

			Vertex3s min;

			unsafe {
				fixed (Vertex3s* vPtr = v) {
					min = Vertex3s.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex3s((short)1.0f, (short)11.0f, (short)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex3s.Min(Vertex3s*) ArgumentNullException")]
		public void Vertex3s_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3s.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex3s.Max(Vertex3s[])")]
		public void Vertex3s_TestMax()
		{
			Vertex3s[] v = new Vertex3s[] {
				new Vertex3s((short)1.0f, (short)13.0f, (short)22.0f),
				new Vertex3s((short)2.0f, (short)12.0f, (short)21.0f),
				new Vertex3s((short)3.0f, (short)11.0f, (short)23.0f),
			};

			Vertex3s max = Vertex3s.Max(v);

			Assert.AreEqual(
				new Vertex3s((short)3.0f, (short)13.0f, (short)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3s.Max(Vertex3s[]) ArgumentNullException")]
		public void Vertex3s_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex3s.Max(null));
		}

		[Test(Description = "Test Vertex3s.Max(Vertex3s*)")]
		public void Vertex3s_TestMax_Unsafe()
		{
			Vertex3s[] v = new Vertex3s[] {
				new Vertex3s((short)1.0f, (short)13.0f, (short)22.0f),
				new Vertex3s((short)2.0f, (short)12.0f, (short)21.0f),
				new Vertex3s((short)3.0f, (short)11.0f, (short)23.0f),
			};

			Vertex3s max;

			unsafe {
				fixed (Vertex3s* vPtr = v) {
					max = Vertex3s.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex3s((short)3.0f, (short)13.0f, (short)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3s.Max(Vertex3s*) ArgumentNullException")]
		public void Vertex3s_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3s.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex3s.Max(Vertex3s[])")]
		public void Vertex3s_TestMinMax()
		{
			Vertex3s[] v = new Vertex3s[] {
				new Vertex3s((short)1.0f, (short)13.0f, (short)22.0f),
				new Vertex3s((short)2.0f, (short)12.0f, (short)21.0f),
				new Vertex3s((short)3.0f, (short)11.0f, (short)23.0f),
			};

			Vertex3s min, max;

			Vertex3s.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex3s((short)1.0f, (short)11.0f, (short)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex3s((short)3.0f, (short)13.0f, (short)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3s.Max(Vertex3s[]) ArgumentNullException")]
		public void Vertex3s_TestMinMax_ArgumentNullException()
		{
			Vertex3s min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex3s.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex3s.MinMax(Vertex3s*)")]
		public void Vertex3s_TestMinMax_Unsafe()
		{
			Vertex3s[] v = new Vertex3s[] {
				new Vertex3s((short)1.0f, (short)13.0f, (short)22.0f),
				new Vertex3s((short)2.0f, (short)12.0f, (short)21.0f),
				new Vertex3s((short)3.0f, (short)11.0f, (short)23.0f),
			};

			Vertex3s min, max;

			unsafe {
				fixed (Vertex3s* vPtr = v) {
					Vertex3s.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex3s((short)1.0f, (short)11.0f, (short)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex3s((short)3.0f, (short)13.0f, (short)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3s.MinMax(Vertex3s*) ArgumentNullException")]
		public void Vertex3s_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex3s min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3s.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex3s.Equals(Vertex3s)")]
		public void Vertex3s_TestEquals_Vertex3s()
		{
			Vertex3s v = Vertex3s.UnitX;

			Assert.IsTrue(v.Equals(Vertex3s.UnitX));
			Assert.IsFalse(v.Equals(Vertex3s.UnitY));
			Assert.IsFalse(v.Equals(Vertex3s.UnitZ));
		}

		[Test(Description = "Test Vertex3s.Equals(object)")]
		public void Vertex3s_TestEquals_Object()
		{
			Vertex3s v = Vertex3s.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex3s.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex3s.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex3s.UnitZ));
		}

		[Test(Description = "Test Vertex3s.GetHashCode()")]
		public void Vertex3s_TestGetHashCode()
		{
			Random random = new Random();
			
			short x = (short)Next(random);
			short y = (short)Next(random);
			short z = (short)Next(random);

			Vertex3s v = new Vertex3s(x, y, z);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex3s.ToString()")]
		public void Vertex3s_TestToString()
		{
			Random random = new Random();
			
			short x = (short)Next(random);
			short y = (short)Next(random);
			short z = (short)Next(random);

			Vertex3s v = new Vertex3s(x, y, z);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex3uiTest : Vertex3TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex3ui(uint)")]
		public void Vertex3ui_TestConstructor1()
		{
			Random random = new Random();
			uint randomValue = (uint)Next(random);
			
			Vertex3ui v = new Vertex3ui(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex3ui(uint[])")]
		public void Vertex3ui_TestConstructor2()
		{
			Random random = new Random();
			uint randomValueX = (uint)Next(random);
			uint randomValueY = (uint)Next(random);
			uint randomValueZ = (uint)Next(random);

			Vertex3ui v = new Vertex3ui(new uint[] {
				randomValueX, randomValueY, randomValueZ
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		[Test(Description = "Test Vertex3ui(uint, uint, uint)")]
		public void Vertex3ui_TestConstructor3()
		{
			Random random = new Random();
			uint randomValueX = (uint)Next(random);
			uint randomValueY = (uint)Next(random);
			uint randomValueZ = (uint)Next(random);

			Vertex3ui v = new Vertex3ui(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex3ui.Size against Marshal.SizeOf")]
		public void Vertex3ui_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex3ui)), Vertex3ui.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex3ui.operator+(Vertex3ui, Vertex3ui)")]
		public void Vertex3ui_TestOperatorAdd()
		{
			Random random = new Random();
			
			uint x1 = (uint)Next(random);
			uint y1 = (uint)Next(random);
			uint z1 = (uint)Next(random);

			Vertex3ui v1 = new Vertex3ui(x1, y1, z1);

			uint x2 = (uint)Next(random);
			uint y2 = (uint)Next(random);
			uint z2 = (uint)Next(random);

			Vertex3ui v2 = new Vertex3ui(x2, y2, z2);

			Vertex3ui v = v1 + v2;

			Assert.AreEqual((uint)(x1 + x2), v.x);
			Assert.AreEqual((uint)(y1 + y2), v.y);
			Assert.AreEqual((uint)(z1 + z2), v.z);
		}

		[Test(Description = "Test Vertex3ui.operator-(Vertex3ui, Vertex3ui)")]
		public void Vertex3ui_TestOperatorSub()
		{
			Random random = new Random();
			
			uint x1 = (uint)Next(random);
			uint y1 = (uint)Next(random);
			uint z1 = (uint)Next(random);

			Vertex3ui v1 = new Vertex3ui(x1, y1, z1);

			uint x2 = (uint)Next(random);
			uint y2 = (uint)Next(random);
			uint z2 = (uint)Next(random);

			Vertex3ui v2 = new Vertex3ui(x2, y2, z2);

			Vertex3ui v = v1 - v2;

			Assert.AreEqual((uint)(x1 - x2), v.x);
			Assert.AreEqual((uint)(y1 - y2), v.y);
			Assert.AreEqual((uint)(z1 - z2), v.z);
		}

		[Test(Description = "Test Vertex3ui.operator*(Vertex3ui, Single)")]
		public void Vertex3ui_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			uint x1 = (uint)Next(random);
			uint y1 = (uint)Next(random);
			uint z1 = (uint)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex3ui v1 = new Vertex3ui(x1, y1, z1);

			Vertex3ui v = v1 * (float)s;

			Assert.AreEqual((uint)(x1 * (float)s), v.x);
			Assert.AreEqual((uint)(y1 * (float)s), v.y);
			Assert.AreEqual((uint)(z1 * (float)s), v.z);
		}

		[Test(Description = "Test Vertex3ui.operator*(Vertex3ui, Double)")]
		public void Vertex3ui_TestOperatorMultiplyDouble()
		{
			Random random = new Random();
			
			uint x1 = (uint)Next(random);
			uint y1 = (uint)Next(random);
			uint z1 = (uint)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex3ui v1 = new Vertex3ui(x1, y1, z1);

			Vertex3ui v = v1 * s;

			Assert.AreEqual((uint)(x1 * s), v.x);
			Assert.AreEqual((uint)(y1 * s), v.y);
			Assert.AreEqual((uint)(z1 * s), v.z);
		}

		[Test(Description = "Test Vertex3ui.operator/(Vertex3ui, Single)")]
		public void Vertex3ui_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			uint x1 = (uint)Next(random);
			uint y1 = (uint)Next(random);
			uint z1 = (uint)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex3ui v1 = new Vertex3ui(x1, y1, z1);

			Vertex3ui v = v1 / (float)s;

			Assert.AreEqual((uint)(x1 / (float)s), v.x);
			Assert.AreEqual((uint)(y1 / (float)s), v.y);
			Assert.AreEqual((uint)(z1 / (float)s), v.z);
		}

		[Test(Description = "Test Vertex3ui.operator/(Vertex3ui, Double)")]
		public void Vertex3ui_TestOperatorDivideDouble()
		{
			Random random = new Random();
			
			uint x1 = (uint)Next(random);
			uint y1 = (uint)Next(random);
			uint z1 = (uint)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex3ui v1 = new Vertex3ui(x1, y1, z1);

			Vertex3ui v = v1 / s;

			Assert.AreEqual((uint)(x1 / s), v.x);
			Assert.AreEqual((uint)(y1 / s), v.y);
			Assert.AreEqual((uint)(z1 / s), v.z);
		}

		[Test(Description = "Test Vertex3ui.operator*(Vertex3ui, Vertex3ui)")]
		public void Vertex3ui_TestOperatorDotProduct()
		{
			Vertex3ui a, b;
			float d;

			a = Vertex3ui.UnitX;
			b = Vertex3ui.UnitY;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3ui.UnitY;
			b = Vertex3ui.UnitZ;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3ui.UnitX;
			b = Vertex3ui.UnitZ;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3ui.UnitX;
			b = Vertex3ui.UnitX;
			d = a * b;
			Assert.AreEqual(1.0, d);

			a = Vertex3ui.UnitY;
			b = Vertex3ui.UnitY;
			d = a * b;
			Assert.AreEqual(1.0, d);

			a = Vertex3ui.UnitZ;
			b = Vertex3ui.UnitZ;
			d = a * b;
			Assert.AreEqual(1.0, d);
		}

		[Test(Description = "Test Vertex3ui.operator^(Vertex3ui, Vertex3ui)")]
		public void Vertex3ui_TestOperatorCrossProduct()
		{
			Vertex3ui a, b;
			Vertex3f c;

			a = Vertex3ui.UnitX;
			b = Vertex3ui.UnitY;
			c = a ^ b;
			Assert.AreEqual(Vertex3f.UnitZ, c);
		}

		[Test(Description = "Test Vertex3ui.operator*(Vertex3ui, uint)")]
		public void Vertex3ui_TestOperatorScalarMultiply()
		{
			Random random = new Random();
			
			uint x1 = (uint)Next(random);
			uint y1 = (uint)Next(random);
			uint z1 = (uint)Next(random);
			uint s = (uint)Next(random, 0.0, 32.0);

			Vertex3ui v1 = new Vertex3ui(x1, y1, z1);

			Vertex3ui v = v1 * s;

			Assert.AreEqual((uint)(x1 * s), v.x);
			Assert.AreEqual((uint)(y1 * s), v.y);
			Assert.AreEqual((uint)(z1 * s), v.z);
		}

		[Test(Description = "Test Vertex3ui.operator/(Vertex3ui, uint)")]
		public void Vertex3ui_TestOperatorScalarDivide()
		{
			Random random = new Random();
			
			uint x1 = (uint)Next(random);
			uint y1 = (uint)Next(random);
			uint z1 = (uint)Next(random);
			uint s = (uint)Next(random, 1.0, 32.0);

			Vertex3ui v1 = new Vertex3ui(x1, y1, z1);

			Vertex3ui v = v1 / s;

			Assert.AreEqual((uint)(x1 / s), v.x);
			Assert.AreEqual((uint)(y1 / s), v.y);
			Assert.AreEqual((uint)(z1 / s), v.z);
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex3ui.operator==(Vertex3ui, Vertex3ui)")]
		public void Vertex3ui_TestOperatorEquality()
		{
			Vertex3ui v = Vertex3ui.UnitX;

			Assert.IsTrue(v == Vertex3ui.UnitX);
			Assert.IsFalse(v == Vertex3ui.UnitY);
		}

		[Test(Description = "Test Vertex3ui.operator!=(Vertex3ui, Vertex3ui)")]
		public void Vertex3ui_TestOperatorInequality()
		{
			Vertex3ui v = Vertex3ui.UnitX;

			Assert.IsFalse(v != Vertex3ui.UnitX);
			Assert.IsTrue(v != Vertex3ui.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex3ui.operator uint[](Vertex3ui)")]
		public void Vertex3ui_TestCastToArray()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random);
			uint y = (uint)Next(random);
			uint z = (uint)Next(random);

			Vertex3ui v = new Vertex3ui(x, y, z);
			uint[] vArray = (uint[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex3ui.operator Vertex3f(Vertex3ui)")]
		public void Vertex3ui_TestCastToVertex3f()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random);
			uint y = (uint)Next(random);
			uint z = (uint)Next(random);

			Vertex3ui v = new Vertex3ui(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.x, v3f.x, 1e-4f);
			Assert.AreEqual(v.y, v3f.y, 1e-4f);
			Assert.AreEqual(v.z, v3f.z, 1e-4f);
		}

		[Test(Description = "Test Vertex3ui.operator Vertex4f(Vertex3ui)")]
		public void Vertex3ui_TestCastToVertex4f()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random);
			uint y = (uint)Next(random);
			uint z = (uint)Next(random);

			Vertex3ui v = new Vertex3ui(x, y, z);
			Vertex4f v4f = (Vertex4f)v;

			Assert.AreEqual(v.x, v4f.x, 1e-4);
			Assert.AreEqual(v.y, v4f.y, 1e-4);
			Assert.AreEqual(v.z, v4f.z, 1e-4);
			Assert.AreEqual(1.0f, v4f.w, 1e-4);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex3ui.Module()")]
		public void Vertex3ui_TestModule()
		{
			Assert.AreEqual(3.741657f, new Vertex3ui((uint)1.0, (uint)2.0, (uint)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex3ui((uint)2.0, (uint)5.0, (uint)7.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex3ui.ModuleSquared()")]
		public void Vertex3ui_TestModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex3ui((uint)1.0, (uint)2.0, (uint)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex3ui((uint)2.0, (uint)5.0, (uint)7.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex3ui.Normalize()")]
		public void Vertex3ui_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex3ui.Zero.Normalize(); });

			Vertex3ui v;

			v = Vertex3ui.UnitX * (uint)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3ui.UnitX, v);

			v = Vertex3ui.UnitY * (uint)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3ui.UnitY, v);

			v = Vertex3ui.UnitZ * (uint)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3ui.UnitZ, v);
		}

		[Test(Description = "Test Vertex3ui.Normalized")]
		public void Vertex3ui_TestNormalized()
		{
			Vertex3ui v;

			Assert.DoesNotThrow(delegate() { v = Vertex3ui.Zero.Normalized; });

			v = Vertex3ui.UnitX * (uint)2.0f;
			Assert.AreEqual(Vertex3ui.UnitX, v.Normalized);

			v = Vertex3ui.UnitY * (uint)2.0f;
			Assert.AreEqual(Vertex3ui.UnitY, v.Normalized);

			v = Vertex3ui.UnitZ * (uint)2.0f;
			Assert.AreEqual(Vertex3ui.UnitZ, v.Normalized);
		}

		[Test(Description = "Test Vertex3ui.Min(Vertex3ui[])")]
		public void Vertex3ui_TestMin()
		{
			Vertex3ui[] v = new Vertex3ui[] {
				new Vertex3ui((uint)1.0f, (uint)13.0f, (uint)22.0f),
				new Vertex3ui((uint)2.0f, (uint)12.0f, (uint)21.0f),
				new Vertex3ui((uint)3.0f, (uint)11.0f, (uint)23.0f),
			};

			Vertex3ui min = Vertex3ui.Min(v);

			Assert.AreEqual(
				new Vertex3ui((uint)1.0f, (uint)11.0f, (uint)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex3ui.Min(Vertex3ui[]) ArgumentNullException")]
		public void Vertex3ui_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex3ui.Min(null));
		}

		[Test(Description = "Test Vertex3ui.Min(Vertex3ui*)")]
		public void Vertex3ui_TestMin_Unsafe()
		{
			Vertex3ui[] v = new Vertex3ui[] {
				new Vertex3ui((uint)1.0f, (uint)13.0f, (uint)22.0f),
				new Vertex3ui((uint)2.0f, (uint)12.0f, (uint)21.0f),
				new Vertex3ui((uint)3.0f, (uint)11.0f, (uint)23.0f),
			};

			Vertex3ui min;

			unsafe {
				fixed (Vertex3ui* vPtr = v) {
					min = Vertex3ui.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex3ui((uint)1.0f, (uint)11.0f, (uint)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex3ui.Min(Vertex3ui*) ArgumentNullException")]
		public void Vertex3ui_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3ui.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex3ui.Max(Vertex3ui[])")]
		public void Vertex3ui_TestMax()
		{
			Vertex3ui[] v = new Vertex3ui[] {
				new Vertex3ui((uint)1.0f, (uint)13.0f, (uint)22.0f),
				new Vertex3ui((uint)2.0f, (uint)12.0f, (uint)21.0f),
				new Vertex3ui((uint)3.0f, (uint)11.0f, (uint)23.0f),
			};

			Vertex3ui max = Vertex3ui.Max(v);

			Assert.AreEqual(
				new Vertex3ui((uint)3.0f, (uint)13.0f, (uint)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3ui.Max(Vertex3ui[]) ArgumentNullException")]
		public void Vertex3ui_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex3ui.Max(null));
		}

		[Test(Description = "Test Vertex3ui.Max(Vertex3ui*)")]
		public void Vertex3ui_TestMax_Unsafe()
		{
			Vertex3ui[] v = new Vertex3ui[] {
				new Vertex3ui((uint)1.0f, (uint)13.0f, (uint)22.0f),
				new Vertex3ui((uint)2.0f, (uint)12.0f, (uint)21.0f),
				new Vertex3ui((uint)3.0f, (uint)11.0f, (uint)23.0f),
			};

			Vertex3ui max;

			unsafe {
				fixed (Vertex3ui* vPtr = v) {
					max = Vertex3ui.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex3ui((uint)3.0f, (uint)13.0f, (uint)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3ui.Max(Vertex3ui*) ArgumentNullException")]
		public void Vertex3ui_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3ui.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex3ui.Max(Vertex3ui[])")]
		public void Vertex3ui_TestMinMax()
		{
			Vertex3ui[] v = new Vertex3ui[] {
				new Vertex3ui((uint)1.0f, (uint)13.0f, (uint)22.0f),
				new Vertex3ui((uint)2.0f, (uint)12.0f, (uint)21.0f),
				new Vertex3ui((uint)3.0f, (uint)11.0f, (uint)23.0f),
			};

			Vertex3ui min, max;

			Vertex3ui.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex3ui((uint)1.0f, (uint)11.0f, (uint)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex3ui((uint)3.0f, (uint)13.0f, (uint)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3ui.Max(Vertex3ui[]) ArgumentNullException")]
		public void Vertex3ui_TestMinMax_ArgumentNullException()
		{
			Vertex3ui min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex3ui.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex3ui.MinMax(Vertex3ui*)")]
		public void Vertex3ui_TestMinMax_Unsafe()
		{
			Vertex3ui[] v = new Vertex3ui[] {
				new Vertex3ui((uint)1.0f, (uint)13.0f, (uint)22.0f),
				new Vertex3ui((uint)2.0f, (uint)12.0f, (uint)21.0f),
				new Vertex3ui((uint)3.0f, (uint)11.0f, (uint)23.0f),
			};

			Vertex3ui min, max;

			unsafe {
				fixed (Vertex3ui* vPtr = v) {
					Vertex3ui.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex3ui((uint)1.0f, (uint)11.0f, (uint)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex3ui((uint)3.0f, (uint)13.0f, (uint)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3ui.MinMax(Vertex3ui*) ArgumentNullException")]
		public void Vertex3ui_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex3ui min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3ui.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex3ui.Equals(Vertex3ui)")]
		public void Vertex3ui_TestEquals_Vertex3ui()
		{
			Vertex3ui v = Vertex3ui.UnitX;

			Assert.IsTrue(v.Equals(Vertex3ui.UnitX));
			Assert.IsFalse(v.Equals(Vertex3ui.UnitY));
			Assert.IsFalse(v.Equals(Vertex3ui.UnitZ));
		}

		[Test(Description = "Test Vertex3ui.Equals(object)")]
		public void Vertex3ui_TestEquals_Object()
		{
			Vertex3ui v = Vertex3ui.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex3ui.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex3ui.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex3ui.UnitZ));
		}

		[Test(Description = "Test Vertex3ui.GetHashCode()")]
		public void Vertex3ui_TestGetHashCode()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random);
			uint y = (uint)Next(random);
			uint z = (uint)Next(random);

			Vertex3ui v = new Vertex3ui(x, y, z);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex3ui.ToString()")]
		public void Vertex3ui_TestToString()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random);
			uint y = (uint)Next(random);
			uint z = (uint)Next(random);

			Vertex3ui v = new Vertex3ui(x, y, z);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex3iTest : Vertex3TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex3i(int)")]
		public void Vertex3i_TestConstructor1()
		{
			Random random = new Random();
			int randomValue = (int)Next(random);
			
			Vertex3i v = new Vertex3i(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex3i(int[])")]
		public void Vertex3i_TestConstructor2()
		{
			Random random = new Random();
			int randomValueX = (int)Next(random);
			int randomValueY = (int)Next(random);
			int randomValueZ = (int)Next(random);

			Vertex3i v = new Vertex3i(new int[] {
				randomValueX, randomValueY, randomValueZ
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		[Test(Description = "Test Vertex3i(int, int, int)")]
		public void Vertex3i_TestConstructor3()
		{
			Random random = new Random();
			int randomValueX = (int)Next(random);
			int randomValueY = (int)Next(random);
			int randomValueZ = (int)Next(random);

			Vertex3i v = new Vertex3i(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex3i.Size against Marshal.SizeOf")]
		public void Vertex3i_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex3i)), Vertex3i.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex3i.operator-(Vertex3i))")]
		public void Vertex3i_TestOperatorNegate()
		{
			Random random = new Random();
			
			int x = (int)Next(random);
			int y = (int)Next(random);
			int z = (int)Next(random);

			Vertex3i v = new Vertex3i(x, y, z);
			Vertex3i n = -v;

			Assert.AreEqual(-x, n.x);
			Assert.AreEqual(-y, n.y);
			Assert.AreEqual(-z, n.z);
		}
		[Test(Description = "Test Vertex3i.operator+(Vertex3i, Vertex3i)")]
		public void Vertex3i_TestOperatorAdd()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random);
			int y1 = (int)Next(random);
			int z1 = (int)Next(random);

			Vertex3i v1 = new Vertex3i(x1, y1, z1);

			int x2 = (int)Next(random);
			int y2 = (int)Next(random);
			int z2 = (int)Next(random);

			Vertex3i v2 = new Vertex3i(x2, y2, z2);

			Vertex3i v = v1 + v2;

			Assert.AreEqual((int)(x1 + x2), v.x);
			Assert.AreEqual((int)(y1 + y2), v.y);
			Assert.AreEqual((int)(z1 + z2), v.z);
		}

		[Test(Description = "Test Vertex3i.operator-(Vertex3i, Vertex3i)")]
		public void Vertex3i_TestOperatorSub()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random);
			int y1 = (int)Next(random);
			int z1 = (int)Next(random);

			Vertex3i v1 = new Vertex3i(x1, y1, z1);

			int x2 = (int)Next(random);
			int y2 = (int)Next(random);
			int z2 = (int)Next(random);

			Vertex3i v2 = new Vertex3i(x2, y2, z2);

			Vertex3i v = v1 - v2;

			Assert.AreEqual((int)(x1 - x2), v.x);
			Assert.AreEqual((int)(y1 - y2), v.y);
			Assert.AreEqual((int)(z1 - z2), v.z);
		}

		[Test(Description = "Test Vertex3i.operator*(Vertex3i, Single)")]
		public void Vertex3i_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random);
			int y1 = (int)Next(random);
			int z1 = (int)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex3i v1 = new Vertex3i(x1, y1, z1);

			Vertex3i v = v1 * (float)s;

			Assert.AreEqual((int)(x1 * (float)s), v.x);
			Assert.AreEqual((int)(y1 * (float)s), v.y);
			Assert.AreEqual((int)(z1 * (float)s), v.z);
		}

		[Test(Description = "Test Vertex3i.operator*(Vertex3i, Double)")]
		public void Vertex3i_TestOperatorMultiplyDouble()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random);
			int y1 = (int)Next(random);
			int z1 = (int)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex3i v1 = new Vertex3i(x1, y1, z1);

			Vertex3i v = v1 * s;

			Assert.AreEqual((int)(x1 * s), v.x);
			Assert.AreEqual((int)(y1 * s), v.y);
			Assert.AreEqual((int)(z1 * s), v.z);
		}

		[Test(Description = "Test Vertex3i.operator/(Vertex3i, Single)")]
		public void Vertex3i_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random);
			int y1 = (int)Next(random);
			int z1 = (int)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex3i v1 = new Vertex3i(x1, y1, z1);

			Vertex3i v = v1 / (float)s;

			Assert.AreEqual((int)(x1 / (float)s), v.x);
			Assert.AreEqual((int)(y1 / (float)s), v.y);
			Assert.AreEqual((int)(z1 / (float)s), v.z);
		}

		[Test(Description = "Test Vertex3i.operator/(Vertex3i, Double)")]
		public void Vertex3i_TestOperatorDivideDouble()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random);
			int y1 = (int)Next(random);
			int z1 = (int)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex3i v1 = new Vertex3i(x1, y1, z1);

			Vertex3i v = v1 / s;

			Assert.AreEqual((int)(x1 / s), v.x);
			Assert.AreEqual((int)(y1 / s), v.y);
			Assert.AreEqual((int)(z1 / s), v.z);
		}

		[Test(Description = "Test Vertex3i.operator*(Vertex3i, Vertex3i)")]
		public void Vertex3i_TestOperatorDotProduct()
		{
			Vertex3i a, b;
			float d;

			a = Vertex3i.UnitX;
			b = Vertex3i.UnitY;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3i.UnitY;
			b = Vertex3i.UnitZ;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3i.UnitX;
			b = Vertex3i.UnitZ;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3i.UnitX;
			b = Vertex3i.UnitX;
			d = a * b;
			Assert.AreEqual(1.0, d);

			a = Vertex3i.UnitY;
			b = Vertex3i.UnitY;
			d = a * b;
			Assert.AreEqual(1.0, d);

			a = Vertex3i.UnitZ;
			b = Vertex3i.UnitZ;
			d = a * b;
			Assert.AreEqual(1.0, d);
		}

		[Test(Description = "Test Vertex3i.operator^(Vertex3i, Vertex3i)")]
		public void Vertex3i_TestOperatorCrossProduct()
		{
			Vertex3i a, b;
			Vertex3f c;

			a = Vertex3i.UnitX;
			b = Vertex3i.UnitY;
			c = a ^ b;
			Assert.AreEqual(Vertex3f.UnitZ, c);
		}

		[Test(Description = "Test Vertex3i.operator*(Vertex3i, int)")]
		public void Vertex3i_TestOperatorScalarMultiply()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random);
			int y1 = (int)Next(random);
			int z1 = (int)Next(random);
			int s = (int)Next(random, 0.0, 32.0);

			Vertex3i v1 = new Vertex3i(x1, y1, z1);

			Vertex3i v = v1 * s;

			Assert.AreEqual((int)(x1 * s), v.x);
			Assert.AreEqual((int)(y1 * s), v.y);
			Assert.AreEqual((int)(z1 * s), v.z);
		}

		[Test(Description = "Test Vertex3i.operator/(Vertex3i, int)")]
		public void Vertex3i_TestOperatorScalarDivide()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random);
			int y1 = (int)Next(random);
			int z1 = (int)Next(random);
			int s = (int)Next(random, 1.0, 32.0);

			Vertex3i v1 = new Vertex3i(x1, y1, z1);

			Vertex3i v = v1 / s;

			Assert.AreEqual((int)(x1 / s), v.x);
			Assert.AreEqual((int)(y1 / s), v.y);
			Assert.AreEqual((int)(z1 / s), v.z);
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex3i.operator==(Vertex3i, Vertex3i)")]
		public void Vertex3i_TestOperatorEquality()
		{
			Vertex3i v = Vertex3i.UnitX;

			Assert.IsTrue(v == Vertex3i.UnitX);
			Assert.IsFalse(v == Vertex3i.UnitY);
		}

		[Test(Description = "Test Vertex3i.operator!=(Vertex3i, Vertex3i)")]
		public void Vertex3i_TestOperatorInequality()
		{
			Vertex3i v = Vertex3i.UnitX;

			Assert.IsFalse(v != Vertex3i.UnitX);
			Assert.IsTrue(v != Vertex3i.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex3i.operator int[](Vertex3i)")]
		public void Vertex3i_TestCastToArray()
		{
			Random random = new Random();
			
			int x = (int)Next(random);
			int y = (int)Next(random);
			int z = (int)Next(random);

			Vertex3i v = new Vertex3i(x, y, z);
			int[] vArray = (int[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex3i.operator Vertex3f(Vertex3i)")]
		public void Vertex3i_TestCastToVertex3f()
		{
			Random random = new Random();
			
			int x = (int)Next(random);
			int y = (int)Next(random);
			int z = (int)Next(random);

			Vertex3i v = new Vertex3i(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.x, v3f.x, 1e-4f);
			Assert.AreEqual(v.y, v3f.y, 1e-4f);
			Assert.AreEqual(v.z, v3f.z, 1e-4f);
		}

		[Test(Description = "Test Vertex3i.operator Vertex4f(Vertex3i)")]
		public void Vertex3i_TestCastToVertex4f()
		{
			Random random = new Random();
			
			int x = (int)Next(random);
			int y = (int)Next(random);
			int z = (int)Next(random);

			Vertex3i v = new Vertex3i(x, y, z);
			Vertex4f v4f = (Vertex4f)v;

			Assert.AreEqual(v.x, v4f.x, 1e-4);
			Assert.AreEqual(v.y, v4f.y, 1e-4);
			Assert.AreEqual(v.z, v4f.z, 1e-4);
			Assert.AreEqual(1.0f, v4f.w, 1e-4);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex3i.Module()")]
		public void Vertex3i_TestModule()
		{
			Assert.AreEqual(3.741657f, new Vertex3i((int)1.0, (int)2.0, (int)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex3i((int)2.0, (int)5.0, (int)7.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex3i.ModuleSquared()")]
		public void Vertex3i_TestModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex3i((int)1.0, (int)2.0, (int)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex3i((int)2.0, (int)5.0, (int)7.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex3i.Normalize()")]
		public void Vertex3i_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex3i.Zero.Normalize(); });

			Vertex3i v;

			v = Vertex3i.UnitX * (int)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3i.UnitX, v);

			v = Vertex3i.UnitY * (int)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3i.UnitY, v);

			v = Vertex3i.UnitZ * (int)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3i.UnitZ, v);
		}

		[Test(Description = "Test Vertex3i.Normalized")]
		public void Vertex3i_TestNormalized()
		{
			Vertex3i v;

			Assert.DoesNotThrow(delegate() { v = Vertex3i.Zero.Normalized; });

			v = Vertex3i.UnitX * (int)2.0f;
			Assert.AreEqual(Vertex3i.UnitX, v.Normalized);

			v = Vertex3i.UnitY * (int)2.0f;
			Assert.AreEqual(Vertex3i.UnitY, v.Normalized);

			v = Vertex3i.UnitZ * (int)2.0f;
			Assert.AreEqual(Vertex3i.UnitZ, v.Normalized);
		}

		[Test(Description = "Test Vertex3i.Min(Vertex3i[])")]
		public void Vertex3i_TestMin()
		{
			Vertex3i[] v = new Vertex3i[] {
				new Vertex3i((int)1.0f, (int)13.0f, (int)22.0f),
				new Vertex3i((int)2.0f, (int)12.0f, (int)21.0f),
				new Vertex3i((int)3.0f, (int)11.0f, (int)23.0f),
			};

			Vertex3i min = Vertex3i.Min(v);

			Assert.AreEqual(
				new Vertex3i((int)1.0f, (int)11.0f, (int)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex3i.Min(Vertex3i[]) ArgumentNullException")]
		public void Vertex3i_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex3i.Min(null));
		}

		[Test(Description = "Test Vertex3i.Min(Vertex3i*)")]
		public void Vertex3i_TestMin_Unsafe()
		{
			Vertex3i[] v = new Vertex3i[] {
				new Vertex3i((int)1.0f, (int)13.0f, (int)22.0f),
				new Vertex3i((int)2.0f, (int)12.0f, (int)21.0f),
				new Vertex3i((int)3.0f, (int)11.0f, (int)23.0f),
			};

			Vertex3i min;

			unsafe {
				fixed (Vertex3i* vPtr = v) {
					min = Vertex3i.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex3i((int)1.0f, (int)11.0f, (int)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex3i.Min(Vertex3i*) ArgumentNullException")]
		public void Vertex3i_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3i.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex3i.Max(Vertex3i[])")]
		public void Vertex3i_TestMax()
		{
			Vertex3i[] v = new Vertex3i[] {
				new Vertex3i((int)1.0f, (int)13.0f, (int)22.0f),
				new Vertex3i((int)2.0f, (int)12.0f, (int)21.0f),
				new Vertex3i((int)3.0f, (int)11.0f, (int)23.0f),
			};

			Vertex3i max = Vertex3i.Max(v);

			Assert.AreEqual(
				new Vertex3i((int)3.0f, (int)13.0f, (int)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3i.Max(Vertex3i[]) ArgumentNullException")]
		public void Vertex3i_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex3i.Max(null));
		}

		[Test(Description = "Test Vertex3i.Max(Vertex3i*)")]
		public void Vertex3i_TestMax_Unsafe()
		{
			Vertex3i[] v = new Vertex3i[] {
				new Vertex3i((int)1.0f, (int)13.0f, (int)22.0f),
				new Vertex3i((int)2.0f, (int)12.0f, (int)21.0f),
				new Vertex3i((int)3.0f, (int)11.0f, (int)23.0f),
			};

			Vertex3i max;

			unsafe {
				fixed (Vertex3i* vPtr = v) {
					max = Vertex3i.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex3i((int)3.0f, (int)13.0f, (int)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3i.Max(Vertex3i*) ArgumentNullException")]
		public void Vertex3i_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3i.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex3i.Max(Vertex3i[])")]
		public void Vertex3i_TestMinMax()
		{
			Vertex3i[] v = new Vertex3i[] {
				new Vertex3i((int)1.0f, (int)13.0f, (int)22.0f),
				new Vertex3i((int)2.0f, (int)12.0f, (int)21.0f),
				new Vertex3i((int)3.0f, (int)11.0f, (int)23.0f),
			};

			Vertex3i min, max;

			Vertex3i.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex3i((int)1.0f, (int)11.0f, (int)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex3i((int)3.0f, (int)13.0f, (int)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3i.Max(Vertex3i[]) ArgumentNullException")]
		public void Vertex3i_TestMinMax_ArgumentNullException()
		{
			Vertex3i min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex3i.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex3i.MinMax(Vertex3i*)")]
		public void Vertex3i_TestMinMax_Unsafe()
		{
			Vertex3i[] v = new Vertex3i[] {
				new Vertex3i((int)1.0f, (int)13.0f, (int)22.0f),
				new Vertex3i((int)2.0f, (int)12.0f, (int)21.0f),
				new Vertex3i((int)3.0f, (int)11.0f, (int)23.0f),
			};

			Vertex3i min, max;

			unsafe {
				fixed (Vertex3i* vPtr = v) {
					Vertex3i.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex3i((int)1.0f, (int)11.0f, (int)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex3i((int)3.0f, (int)13.0f, (int)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3i.MinMax(Vertex3i*) ArgumentNullException")]
		public void Vertex3i_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex3i min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3i.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex3i.Equals(Vertex3i)")]
		public void Vertex3i_TestEquals_Vertex3i()
		{
			Vertex3i v = Vertex3i.UnitX;

			Assert.IsTrue(v.Equals(Vertex3i.UnitX));
			Assert.IsFalse(v.Equals(Vertex3i.UnitY));
			Assert.IsFalse(v.Equals(Vertex3i.UnitZ));
		}

		[Test(Description = "Test Vertex3i.Equals(object)")]
		public void Vertex3i_TestEquals_Object()
		{
			Vertex3i v = Vertex3i.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex3i.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex3i.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex3i.UnitZ));
		}

		[Test(Description = "Test Vertex3i.GetHashCode()")]
		public void Vertex3i_TestGetHashCode()
		{
			Random random = new Random();
			
			int x = (int)Next(random);
			int y = (int)Next(random);
			int z = (int)Next(random);

			Vertex3i v = new Vertex3i(x, y, z);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex3i.ToString()")]
		public void Vertex3i_TestToString()
		{
			Random random = new Random();
			
			int x = (int)Next(random);
			int y = (int)Next(random);
			int z = (int)Next(random);

			Vertex3i v = new Vertex3i(x, y, z);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex3fTest : Vertex3TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex3f(float)")]
		public void Vertex3f_TestConstructor1()
		{
			Random random = new Random();
			float randomValue = (float)Next(random);
			
			Vertex3f v = new Vertex3f(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex3f(float[])")]
		public void Vertex3f_TestConstructor2()
		{
			Random random = new Random();
			float randomValueX = (float)Next(random);
			float randomValueY = (float)Next(random);
			float randomValueZ = (float)Next(random);

			Vertex3f v = new Vertex3f(new float[] {
				randomValueX, randomValueY, randomValueZ
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		[Test(Description = "Test Vertex3f(float, float, float)")]
		public void Vertex3f_TestConstructor3()
		{
			Random random = new Random();
			float randomValueX = (float)Next(random);
			float randomValueY = (float)Next(random);
			float randomValueZ = (float)Next(random);

			Vertex3f v = new Vertex3f(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex3f.Size against Marshal.SizeOf")]
		public void Vertex3f_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex3f)), Vertex3f.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex3f.operator-(Vertex3f))")]
		public void Vertex3f_TestOperatorNegate()
		{
			Random random = new Random();
			
			float x = (float)Next(random);
			float y = (float)Next(random);
			float z = (float)Next(random);

			Vertex3f v = new Vertex3f(x, y, z);
			Vertex3f n = -v;

			Assert.AreEqual(-x, n.x);
			Assert.AreEqual(-y, n.y);
			Assert.AreEqual(-z, n.z);
		}
		[Test(Description = "Test Vertex3f.operator+(Vertex3f, Vertex3f)")]
		public void Vertex3f_TestOperatorAdd()
		{
			Random random = new Random();
			
			float x1 = (float)Next(random);
			float y1 = (float)Next(random);
			float z1 = (float)Next(random);

			Vertex3f v1 = new Vertex3f(x1, y1, z1);

			float x2 = (float)Next(random);
			float y2 = (float)Next(random);
			float z2 = (float)Next(random);

			Vertex3f v2 = new Vertex3f(x2, y2, z2);

			Vertex3f v = v1 + v2;

			Assert.AreEqual((float)(x1 + x2), v.x);
			Assert.AreEqual((float)(y1 + y2), v.y);
			Assert.AreEqual((float)(z1 + z2), v.z);
		}

		[Test(Description = "Test Vertex3f.operator-(Vertex3f, Vertex3f)")]
		public void Vertex3f_TestOperatorSub()
		{
			Random random = new Random();
			
			float x1 = (float)Next(random);
			float y1 = (float)Next(random);
			float z1 = (float)Next(random);

			Vertex3f v1 = new Vertex3f(x1, y1, z1);

			float x2 = (float)Next(random);
			float y2 = (float)Next(random);
			float z2 = (float)Next(random);

			Vertex3f v2 = new Vertex3f(x2, y2, z2);

			Vertex3f v = v1 - v2;

			Assert.AreEqual((float)(x1 - x2), v.x);
			Assert.AreEqual((float)(y1 - y2), v.y);
			Assert.AreEqual((float)(z1 - z2), v.z);
		}

		[Test(Description = "Test Vertex3f.operator*(Vertex3f, Single)")]
		public void Vertex3f_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			float x1 = (float)Next(random);
			float y1 = (float)Next(random);
			float z1 = (float)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex3f v1 = new Vertex3f(x1, y1, z1);

			Vertex3f v = v1 * (float)s;

			Assert.AreEqual((float)(x1 * (float)s), v.x);
			Assert.AreEqual((float)(y1 * (float)s), v.y);
			Assert.AreEqual((float)(z1 * (float)s), v.z);
		}

		[Test(Description = "Test Vertex3f.operator*(Vertex3f, Double)")]
		public void Vertex3f_TestOperatorMultiplyDouble()
		{
			Random random = new Random();
			
			float x1 = (float)Next(random);
			float y1 = (float)Next(random);
			float z1 = (float)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex3f v1 = new Vertex3f(x1, y1, z1);

			Vertex3f v = v1 * s;

			Assert.AreEqual((float)(x1 * s), v.x);
			Assert.AreEqual((float)(y1 * s), v.y);
			Assert.AreEqual((float)(z1 * s), v.z);
		}

		[Test(Description = "Test Vertex3f.operator/(Vertex3f, Single)")]
		public void Vertex3f_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			float x1 = (float)Next(random);
			float y1 = (float)Next(random);
			float z1 = (float)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex3f v1 = new Vertex3f(x1, y1, z1);

			Vertex3f v = v1 / (float)s;

			Assert.AreEqual((float)(x1 / (float)s), v.x);
			Assert.AreEqual((float)(y1 / (float)s), v.y);
			Assert.AreEqual((float)(z1 / (float)s), v.z);
		}

		[Test(Description = "Test Vertex3f.operator/(Vertex3f, Double)")]
		public void Vertex3f_TestOperatorDivideDouble()
		{
			Random random = new Random();
			
			float x1 = (float)Next(random);
			float y1 = (float)Next(random);
			float z1 = (float)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex3f v1 = new Vertex3f(x1, y1, z1);

			Vertex3f v = v1 / s;

			Assert.AreEqual((float)(x1 / s), v.x);
			Assert.AreEqual((float)(y1 / s), v.y);
			Assert.AreEqual((float)(z1 / s), v.z);
		}

		[Test(Description = "Test Vertex3f.operator*(Vertex3f, Vertex3f)")]
		public void Vertex3f_TestOperatorDotProduct()
		{
			Vertex3f a, b;
			float d;

			a = Vertex3f.UnitX;
			b = Vertex3f.UnitY;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3f.UnitY;
			b = Vertex3f.UnitZ;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3f.UnitX;
			b = Vertex3f.UnitZ;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3f.UnitX;
			b = Vertex3f.UnitX;
			d = a * b;
			Assert.AreEqual(1.0, d);

			a = Vertex3f.UnitY;
			b = Vertex3f.UnitY;
			d = a * b;
			Assert.AreEqual(1.0, d);

			a = Vertex3f.UnitZ;
			b = Vertex3f.UnitZ;
			d = a * b;
			Assert.AreEqual(1.0, d);
		}

		[Test(Description = "Test Vertex3f.operator^(Vertex3f, Vertex3f)")]
		public void Vertex3f_TestOperatorCrossProduct()
		{
			Vertex3f a, b;
			Vertex3f c;

			a = Vertex3f.UnitX;
			b = Vertex3f.UnitY;
			c = a ^ b;
			Assert.AreEqual(Vertex3f.UnitZ, c);
		}


		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex3f.operator==(Vertex3f, Vertex3f)")]
		public void Vertex3f_TestOperatorEquality()
		{
			Vertex3f v = Vertex3f.UnitX;

			Assert.IsTrue(v == Vertex3f.UnitX);
			Assert.IsFalse(v == Vertex3f.UnitY);
		}

		[Test(Description = "Test Vertex3f.operator!=(Vertex3f, Vertex3f)")]
		public void Vertex3f_TestOperatorInequality()
		{
			Vertex3f v = Vertex3f.UnitX;

			Assert.IsFalse(v != Vertex3f.UnitX);
			Assert.IsTrue(v != Vertex3f.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex3f.operator float[](Vertex3f)")]
		public void Vertex3f_TestCastToArray()
		{
			Random random = new Random();
			
			float x = (float)Next(random);
			float y = (float)Next(random);
			float z = (float)Next(random);

			Vertex3f v = new Vertex3f(x, y, z);
			float[] vArray = (float[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex3f.operator Vertex3f(Vertex3f)")]
		public void Vertex3f_TestCastToVertex3f()
		{
			Random random = new Random();
			
			float x = (float)Next(random);
			float y = (float)Next(random);
			float z = (float)Next(random);

			Vertex3f v = new Vertex3f(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.x, v3f.x, 1e-4f);
			Assert.AreEqual(v.y, v3f.y, 1e-4f);
			Assert.AreEqual(v.z, v3f.z, 1e-4f);
		}

		[Test(Description = "Test Vertex3f.operator Vertex4f(Vertex3f)")]
		public void Vertex3f_TestCastToVertex4f()
		{
			Random random = new Random();
			
			float x = (float)Next(random);
			float y = (float)Next(random);
			float z = (float)Next(random);

			Vertex3f v = new Vertex3f(x, y, z);
			Vertex4f v4f = (Vertex4f)v;

			Assert.AreEqual(v.x, v4f.x, 1e-4);
			Assert.AreEqual(v.y, v4f.y, 1e-4);
			Assert.AreEqual(v.z, v4f.z, 1e-4);
			Assert.AreEqual(1.0f, v4f.w, 1e-4);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex3f.Module()")]
		public void Vertex3f_TestModule()
		{
			Assert.AreEqual(3.741657f, new Vertex3f((float)1.0, (float)2.0, (float)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex3f((float)2.0, (float)5.0, (float)7.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex3f.ModuleSquared()")]
		public void Vertex3f_TestModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex3f((float)1.0, (float)2.0, (float)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex3f((float)2.0, (float)5.0, (float)7.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex3f.Normalize()")]
		public void Vertex3f_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex3f.Zero.Normalize(); });

			Vertex3f v;

			v = Vertex3f.UnitX * (float)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3f.UnitX, v);

			v = Vertex3f.UnitY * (float)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3f.UnitY, v);

			v = Vertex3f.UnitZ * (float)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3f.UnitZ, v);
		}

		[Test(Description = "Test Vertex3f.Normalized")]
		public void Vertex3f_TestNormalized()
		{
			Vertex3f v;

			Assert.DoesNotThrow(delegate() { v = Vertex3f.Zero.Normalized; });

			v = Vertex3f.UnitX * (float)2.0f;
			Assert.AreEqual(Vertex3f.UnitX, v.Normalized);

			v = Vertex3f.UnitY * (float)2.0f;
			Assert.AreEqual(Vertex3f.UnitY, v.Normalized);

			v = Vertex3f.UnitZ * (float)2.0f;
			Assert.AreEqual(Vertex3f.UnitZ, v.Normalized);
		}

		[Test(Description = "Test Vertex3f.Min(Vertex3f[])")]
		public void Vertex3f_TestMin()
		{
			Vertex3f[] v = new Vertex3f[] {
				new Vertex3f((float)1.0f, (float)13.0f, (float)22.0f),
				new Vertex3f((float)2.0f, (float)12.0f, (float)21.0f),
				new Vertex3f((float)3.0f, (float)11.0f, (float)23.0f),
			};

			Vertex3f min = Vertex3f.Min(v);

			Assert.AreEqual(
				new Vertex3f((float)1.0f, (float)11.0f, (float)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex3f.Min(Vertex3f[]) ArgumentNullException")]
		public void Vertex3f_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex3f.Min(null));
		}

		[Test(Description = "Test Vertex3f.Min(Vertex3f*)")]
		public void Vertex3f_TestMin_Unsafe()
		{
			Vertex3f[] v = new Vertex3f[] {
				new Vertex3f((float)1.0f, (float)13.0f, (float)22.0f),
				new Vertex3f((float)2.0f, (float)12.0f, (float)21.0f),
				new Vertex3f((float)3.0f, (float)11.0f, (float)23.0f),
			};

			Vertex3f min;

			unsafe {
				fixed (Vertex3f* vPtr = v) {
					min = Vertex3f.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex3f((float)1.0f, (float)11.0f, (float)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex3f.Min(Vertex3f*) ArgumentNullException")]
		public void Vertex3f_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3f.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex3f.Max(Vertex3f[])")]
		public void Vertex3f_TestMax()
		{
			Vertex3f[] v = new Vertex3f[] {
				new Vertex3f((float)1.0f, (float)13.0f, (float)22.0f),
				new Vertex3f((float)2.0f, (float)12.0f, (float)21.0f),
				new Vertex3f((float)3.0f, (float)11.0f, (float)23.0f),
			};

			Vertex3f max = Vertex3f.Max(v);

			Assert.AreEqual(
				new Vertex3f((float)3.0f, (float)13.0f, (float)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3f.Max(Vertex3f[]) ArgumentNullException")]
		public void Vertex3f_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex3f.Max(null));
		}

		[Test(Description = "Test Vertex3f.Max(Vertex3f*)")]
		public void Vertex3f_TestMax_Unsafe()
		{
			Vertex3f[] v = new Vertex3f[] {
				new Vertex3f((float)1.0f, (float)13.0f, (float)22.0f),
				new Vertex3f((float)2.0f, (float)12.0f, (float)21.0f),
				new Vertex3f((float)3.0f, (float)11.0f, (float)23.0f),
			};

			Vertex3f max;

			unsafe {
				fixed (Vertex3f* vPtr = v) {
					max = Vertex3f.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex3f((float)3.0f, (float)13.0f, (float)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3f.Max(Vertex3f*) ArgumentNullException")]
		public void Vertex3f_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3f.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex3f.Max(Vertex3f[])")]
		public void Vertex3f_TestMinMax()
		{
			Vertex3f[] v = new Vertex3f[] {
				new Vertex3f((float)1.0f, (float)13.0f, (float)22.0f),
				new Vertex3f((float)2.0f, (float)12.0f, (float)21.0f),
				new Vertex3f((float)3.0f, (float)11.0f, (float)23.0f),
			};

			Vertex3f min, max;

			Vertex3f.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex3f((float)1.0f, (float)11.0f, (float)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex3f((float)3.0f, (float)13.0f, (float)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3f.Max(Vertex3f[]) ArgumentNullException")]
		public void Vertex3f_TestMinMax_ArgumentNullException()
		{
			Vertex3f min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex3f.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex3f.MinMax(Vertex3f*)")]
		public void Vertex3f_TestMinMax_Unsafe()
		{
			Vertex3f[] v = new Vertex3f[] {
				new Vertex3f((float)1.0f, (float)13.0f, (float)22.0f),
				new Vertex3f((float)2.0f, (float)12.0f, (float)21.0f),
				new Vertex3f((float)3.0f, (float)11.0f, (float)23.0f),
			};

			Vertex3f min, max;

			unsafe {
				fixed (Vertex3f* vPtr = v) {
					Vertex3f.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex3f((float)1.0f, (float)11.0f, (float)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex3f((float)3.0f, (float)13.0f, (float)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3f.MinMax(Vertex3f*) ArgumentNullException")]
		public void Vertex3f_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex3f min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3f.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex3f.Equals(Vertex3f)")]
		public void Vertex3f_TestEquals_Vertex3f()
		{
			Vertex3f v = Vertex3f.UnitX;

			Assert.IsTrue(v.Equals(Vertex3f.UnitX));
			Assert.IsFalse(v.Equals(Vertex3f.UnitY));
			Assert.IsFalse(v.Equals(Vertex3f.UnitZ));
		}

		[Test(Description = "Test Vertex3f.Equals(object)")]
		public void Vertex3f_TestEquals_Object()
		{
			Vertex3f v = Vertex3f.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex3f.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex3f.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex3f.UnitZ));
		}

		[Test(Description = "Test Vertex3f.GetHashCode()")]
		public void Vertex3f_TestGetHashCode()
		{
			Random random = new Random();
			
			float x = (float)Next(random);
			float y = (float)Next(random);
			float z = (float)Next(random);

			Vertex3f v = new Vertex3f(x, y, z);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex3f.ToString()")]
		public void Vertex3f_TestToString()
		{
			Random random = new Random();
			
			float x = (float)Next(random);
			float y = (float)Next(random);
			float z = (float)Next(random);

			Vertex3f v = new Vertex3f(x, y, z);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex3dTest : Vertex3TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex3d(double)")]
		public void Vertex3d_TestConstructor1()
		{
			Random random = new Random();
			double randomValue = (double)Next(random);
			
			Vertex3d v = new Vertex3d(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex3d(double[])")]
		public void Vertex3d_TestConstructor2()
		{
			Random random = new Random();
			double randomValueX = (double)Next(random);
			double randomValueY = (double)Next(random);
			double randomValueZ = (double)Next(random);

			Vertex3d v = new Vertex3d(new double[] {
				randomValueX, randomValueY, randomValueZ
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		[Test(Description = "Test Vertex3d(double, double, double)")]
		public void Vertex3d_TestConstructor3()
		{
			Random random = new Random();
			double randomValueX = (double)Next(random);
			double randomValueY = (double)Next(random);
			double randomValueZ = (double)Next(random);

			Vertex3d v = new Vertex3d(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex3d.Size against Marshal.SizeOf")]
		public void Vertex3d_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex3d)), Vertex3d.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex3d.operator-(Vertex3d))")]
		public void Vertex3d_TestOperatorNegate()
		{
			Random random = new Random();
			
			double x = (double)Next(random);
			double y = (double)Next(random);
			double z = (double)Next(random);

			Vertex3d v = new Vertex3d(x, y, z);
			Vertex3d n = -v;

			Assert.AreEqual(-x, n.x);
			Assert.AreEqual(-y, n.y);
			Assert.AreEqual(-z, n.z);
		}
		[Test(Description = "Test Vertex3d.operator+(Vertex3d, Vertex3d)")]
		public void Vertex3d_TestOperatorAdd()
		{
			Random random = new Random();
			
			double x1 = (double)Next(random);
			double y1 = (double)Next(random);
			double z1 = (double)Next(random);

			Vertex3d v1 = new Vertex3d(x1, y1, z1);

			double x2 = (double)Next(random);
			double y2 = (double)Next(random);
			double z2 = (double)Next(random);

			Vertex3d v2 = new Vertex3d(x2, y2, z2);

			Vertex3d v = v1 + v2;

			Assert.AreEqual((double)(x1 + x2), v.x);
			Assert.AreEqual((double)(y1 + y2), v.y);
			Assert.AreEqual((double)(z1 + z2), v.z);
		}

		[Test(Description = "Test Vertex3d.operator-(Vertex3d, Vertex3d)")]
		public void Vertex3d_TestOperatorSub()
		{
			Random random = new Random();
			
			double x1 = (double)Next(random);
			double y1 = (double)Next(random);
			double z1 = (double)Next(random);

			Vertex3d v1 = new Vertex3d(x1, y1, z1);

			double x2 = (double)Next(random);
			double y2 = (double)Next(random);
			double z2 = (double)Next(random);

			Vertex3d v2 = new Vertex3d(x2, y2, z2);

			Vertex3d v = v1 - v2;

			Assert.AreEqual((double)(x1 - x2), v.x);
			Assert.AreEqual((double)(y1 - y2), v.y);
			Assert.AreEqual((double)(z1 - z2), v.z);
		}

		[Test(Description = "Test Vertex3d.operator*(Vertex3d, Single)")]
		public void Vertex3d_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			double x1 = (double)Next(random);
			double y1 = (double)Next(random);
			double z1 = (double)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex3d v1 = new Vertex3d(x1, y1, z1);

			Vertex3d v = v1 * (float)s;

			Assert.AreEqual((double)(x1 * (float)s), v.x);
			Assert.AreEqual((double)(y1 * (float)s), v.y);
			Assert.AreEqual((double)(z1 * (float)s), v.z);
		}

		[Test(Description = "Test Vertex3d.operator*(Vertex3d, Double)")]
		public void Vertex3d_TestOperatorMultiplyDouble()
		{
			Random random = new Random();
			
			double x1 = (double)Next(random);
			double y1 = (double)Next(random);
			double z1 = (double)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex3d v1 = new Vertex3d(x1, y1, z1);

			Vertex3d v = v1 * s;

			Assert.AreEqual((double)(x1 * s), v.x);
			Assert.AreEqual((double)(y1 * s), v.y);
			Assert.AreEqual((double)(z1 * s), v.z);
		}

		[Test(Description = "Test Vertex3d.operator/(Vertex3d, Single)")]
		public void Vertex3d_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			double x1 = (double)Next(random);
			double y1 = (double)Next(random);
			double z1 = (double)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex3d v1 = new Vertex3d(x1, y1, z1);

			Vertex3d v = v1 / (float)s;

			Assert.AreEqual((double)(x1 / (float)s), v.x);
			Assert.AreEqual((double)(y1 / (float)s), v.y);
			Assert.AreEqual((double)(z1 / (float)s), v.z);
		}

		[Test(Description = "Test Vertex3d.operator/(Vertex3d, Double)")]
		public void Vertex3d_TestOperatorDivideDouble()
		{
			Random random = new Random();
			
			double x1 = (double)Next(random);
			double y1 = (double)Next(random);
			double z1 = (double)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex3d v1 = new Vertex3d(x1, y1, z1);

			Vertex3d v = v1 / s;

			Assert.AreEqual((double)(x1 / s), v.x);
			Assert.AreEqual((double)(y1 / s), v.y);
			Assert.AreEqual((double)(z1 / s), v.z);
		}

		[Test(Description = "Test Vertex3d.operator*(Vertex3d, Vertex3d)")]
		public void Vertex3d_TestOperatorDotProduct()
		{
			Vertex3d a, b;
			float d;

			a = Vertex3d.UnitX;
			b = Vertex3d.UnitY;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3d.UnitY;
			b = Vertex3d.UnitZ;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3d.UnitX;
			b = Vertex3d.UnitZ;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3d.UnitX;
			b = Vertex3d.UnitX;
			d = a * b;
			Assert.AreEqual(1.0, d);

			a = Vertex3d.UnitY;
			b = Vertex3d.UnitY;
			d = a * b;
			Assert.AreEqual(1.0, d);

			a = Vertex3d.UnitZ;
			b = Vertex3d.UnitZ;
			d = a * b;
			Assert.AreEqual(1.0, d);
		}

		[Test(Description = "Test Vertex3d.operator^(Vertex3d, Vertex3d)")]
		public void Vertex3d_TestOperatorCrossProduct()
		{
			Vertex3d a, b;
			Vertex3f c;

			a = Vertex3d.UnitX;
			b = Vertex3d.UnitY;
			c = a ^ b;
			Assert.AreEqual(Vertex3f.UnitZ, c);
		}


		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex3d.operator==(Vertex3d, Vertex3d)")]
		public void Vertex3d_TestOperatorEquality()
		{
			Vertex3d v = Vertex3d.UnitX;

			Assert.IsTrue(v == Vertex3d.UnitX);
			Assert.IsFalse(v == Vertex3d.UnitY);
		}

		[Test(Description = "Test Vertex3d.operator!=(Vertex3d, Vertex3d)")]
		public void Vertex3d_TestOperatorInequality()
		{
			Vertex3d v = Vertex3d.UnitX;

			Assert.IsFalse(v != Vertex3d.UnitX);
			Assert.IsTrue(v != Vertex3d.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex3d.operator double[](Vertex3d)")]
		public void Vertex3d_TestCastToArray()
		{
			Random random = new Random();
			
			double x = (double)Next(random);
			double y = (double)Next(random);
			double z = (double)Next(random);

			Vertex3d v = new Vertex3d(x, y, z);
			double[] vArray = (double[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex3d.operator Vertex3f(Vertex3d)")]
		public void Vertex3d_TestCastToVertex3f()
		{
			Random random = new Random();
			
			double x = (double)Next(random);
			double y = (double)Next(random);
			double z = (double)Next(random);

			Vertex3d v = new Vertex3d(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.x, v3f.x, 1e-4f);
			Assert.AreEqual(v.y, v3f.y, 1e-4f);
			Assert.AreEqual(v.z, v3f.z, 1e-4f);
		}

		[Test(Description = "Test Vertex3d.operator Vertex4f(Vertex3d)")]
		public void Vertex3d_TestCastToVertex4f()
		{
			Random random = new Random();
			
			double x = (double)Next(random);
			double y = (double)Next(random);
			double z = (double)Next(random);

			Vertex3d v = new Vertex3d(x, y, z);
			Vertex4f v4f = (Vertex4f)v;

			Assert.AreEqual(v.x, v4f.x, 1e-4);
			Assert.AreEqual(v.y, v4f.y, 1e-4);
			Assert.AreEqual(v.z, v4f.z, 1e-4);
			Assert.AreEqual(1.0f, v4f.w, 1e-4);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex3d.Module()")]
		public void Vertex3d_TestModule()
		{
			Assert.AreEqual(3.741657f, new Vertex3d((double)1.0, (double)2.0, (double)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex3d((double)2.0, (double)5.0, (double)7.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex3d.ModuleSquared()")]
		public void Vertex3d_TestModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex3d((double)1.0, (double)2.0, (double)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex3d((double)2.0, (double)5.0, (double)7.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex3d.Normalize()")]
		public void Vertex3d_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex3d.Zero.Normalize(); });

			Vertex3d v;

			v = Vertex3d.UnitX * (double)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3d.UnitX, v);

			v = Vertex3d.UnitY * (double)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3d.UnitY, v);

			v = Vertex3d.UnitZ * (double)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3d.UnitZ, v);
		}

		[Test(Description = "Test Vertex3d.Normalized")]
		public void Vertex3d_TestNormalized()
		{
			Vertex3d v;

			Assert.DoesNotThrow(delegate() { v = Vertex3d.Zero.Normalized; });

			v = Vertex3d.UnitX * (double)2.0f;
			Assert.AreEqual(Vertex3d.UnitX, v.Normalized);

			v = Vertex3d.UnitY * (double)2.0f;
			Assert.AreEqual(Vertex3d.UnitY, v.Normalized);

			v = Vertex3d.UnitZ * (double)2.0f;
			Assert.AreEqual(Vertex3d.UnitZ, v.Normalized);
		}

		[Test(Description = "Test Vertex3d.Min(Vertex3d[])")]
		public void Vertex3d_TestMin()
		{
			Vertex3d[] v = new Vertex3d[] {
				new Vertex3d((double)1.0f, (double)13.0f, (double)22.0f),
				new Vertex3d((double)2.0f, (double)12.0f, (double)21.0f),
				new Vertex3d((double)3.0f, (double)11.0f, (double)23.0f),
			};

			Vertex3d min = Vertex3d.Min(v);

			Assert.AreEqual(
				new Vertex3d((double)1.0f, (double)11.0f, (double)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex3d.Min(Vertex3d[]) ArgumentNullException")]
		public void Vertex3d_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex3d.Min(null));
		}

		[Test(Description = "Test Vertex3d.Min(Vertex3d*)")]
		public void Vertex3d_TestMin_Unsafe()
		{
			Vertex3d[] v = new Vertex3d[] {
				new Vertex3d((double)1.0f, (double)13.0f, (double)22.0f),
				new Vertex3d((double)2.0f, (double)12.0f, (double)21.0f),
				new Vertex3d((double)3.0f, (double)11.0f, (double)23.0f),
			};

			Vertex3d min;

			unsafe {
				fixed (Vertex3d* vPtr = v) {
					min = Vertex3d.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex3d((double)1.0f, (double)11.0f, (double)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex3d.Min(Vertex3d*) ArgumentNullException")]
		public void Vertex3d_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3d.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex3d.Max(Vertex3d[])")]
		public void Vertex3d_TestMax()
		{
			Vertex3d[] v = new Vertex3d[] {
				new Vertex3d((double)1.0f, (double)13.0f, (double)22.0f),
				new Vertex3d((double)2.0f, (double)12.0f, (double)21.0f),
				new Vertex3d((double)3.0f, (double)11.0f, (double)23.0f),
			};

			Vertex3d max = Vertex3d.Max(v);

			Assert.AreEqual(
				new Vertex3d((double)3.0f, (double)13.0f, (double)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3d.Max(Vertex3d[]) ArgumentNullException")]
		public void Vertex3d_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex3d.Max(null));
		}

		[Test(Description = "Test Vertex3d.Max(Vertex3d*)")]
		public void Vertex3d_TestMax_Unsafe()
		{
			Vertex3d[] v = new Vertex3d[] {
				new Vertex3d((double)1.0f, (double)13.0f, (double)22.0f),
				new Vertex3d((double)2.0f, (double)12.0f, (double)21.0f),
				new Vertex3d((double)3.0f, (double)11.0f, (double)23.0f),
			};

			Vertex3d max;

			unsafe {
				fixed (Vertex3d* vPtr = v) {
					max = Vertex3d.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex3d((double)3.0f, (double)13.0f, (double)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3d.Max(Vertex3d*) ArgumentNullException")]
		public void Vertex3d_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3d.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex3d.Max(Vertex3d[])")]
		public void Vertex3d_TestMinMax()
		{
			Vertex3d[] v = new Vertex3d[] {
				new Vertex3d((double)1.0f, (double)13.0f, (double)22.0f),
				new Vertex3d((double)2.0f, (double)12.0f, (double)21.0f),
				new Vertex3d((double)3.0f, (double)11.0f, (double)23.0f),
			};

			Vertex3d min, max;

			Vertex3d.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex3d((double)1.0f, (double)11.0f, (double)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex3d((double)3.0f, (double)13.0f, (double)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3d.Max(Vertex3d[]) ArgumentNullException")]
		public void Vertex3d_TestMinMax_ArgumentNullException()
		{
			Vertex3d min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex3d.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex3d.MinMax(Vertex3d*)")]
		public void Vertex3d_TestMinMax_Unsafe()
		{
			Vertex3d[] v = new Vertex3d[] {
				new Vertex3d((double)1.0f, (double)13.0f, (double)22.0f),
				new Vertex3d((double)2.0f, (double)12.0f, (double)21.0f),
				new Vertex3d((double)3.0f, (double)11.0f, (double)23.0f),
			};

			Vertex3d min, max;

			unsafe {
				fixed (Vertex3d* vPtr = v) {
					Vertex3d.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex3d((double)1.0f, (double)11.0f, (double)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex3d((double)3.0f, (double)13.0f, (double)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3d.MinMax(Vertex3d*) ArgumentNullException")]
		public void Vertex3d_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex3d min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3d.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex3d.Equals(Vertex3d)")]
		public void Vertex3d_TestEquals_Vertex3d()
		{
			Vertex3d v = Vertex3d.UnitX;

			Assert.IsTrue(v.Equals(Vertex3d.UnitX));
			Assert.IsFalse(v.Equals(Vertex3d.UnitY));
			Assert.IsFalse(v.Equals(Vertex3d.UnitZ));
		}

		[Test(Description = "Test Vertex3d.Equals(object)")]
		public void Vertex3d_TestEquals_Object()
		{
			Vertex3d v = Vertex3d.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex3d.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex3d.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex3d.UnitZ));
		}

		[Test(Description = "Test Vertex3d.GetHashCode()")]
		public void Vertex3d_TestGetHashCode()
		{
			Random random = new Random();
			
			double x = (double)Next(random);
			double y = (double)Next(random);
			double z = (double)Next(random);

			Vertex3d v = new Vertex3d(x, y, z);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex3d.ToString()")]
		public void Vertex3d_TestToString()
		{
			Random random = new Random();
			
			double x = (double)Next(random);
			double y = (double)Next(random);
			double z = (double)Next(random);

			Vertex3d v = new Vertex3d(x, y, z);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex3hfTest : Vertex3TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex3hf(HalfFloat)")]
		public void Vertex3hf_TestConstructor1()
		{
			Random random = new Random();
			HalfFloat randomValue = (HalfFloat)Next(random);
			
			Vertex3hf v = new Vertex3hf(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex3hf(HalfFloat[])")]
		public void Vertex3hf_TestConstructor2()
		{
			Random random = new Random();
			HalfFloat randomValueX = (HalfFloat)Next(random);
			HalfFloat randomValueY = (HalfFloat)Next(random);
			HalfFloat randomValueZ = (HalfFloat)Next(random);

			Vertex3hf v = new Vertex3hf(new HalfFloat[] {
				randomValueX, randomValueY, randomValueZ
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		[Test(Description = "Test Vertex3hf(HalfFloat, HalfFloat, HalfFloat)")]
		public void Vertex3hf_TestConstructor3()
		{
			Random random = new Random();
			HalfFloat randomValueX = (HalfFloat)Next(random);
			HalfFloat randomValueY = (HalfFloat)Next(random);
			HalfFloat randomValueZ = (HalfFloat)Next(random);

			Vertex3hf v = new Vertex3hf(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex3hf.Size against Marshal.SizeOf")]
		public void Vertex3hf_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex3hf)), Vertex3hf.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex3hf.operator+(Vertex3hf, Vertex3hf)")]
		public void Vertex3hf_TestOperatorAdd()
		{
			Random random = new Random();
			
			HalfFloat x1 = (HalfFloat)Next(random);
			HalfFloat y1 = (HalfFloat)Next(random);
			HalfFloat z1 = (HalfFloat)Next(random);

			Vertex3hf v1 = new Vertex3hf(x1, y1, z1);

			HalfFloat x2 = (HalfFloat)Next(random);
			HalfFloat y2 = (HalfFloat)Next(random);
			HalfFloat z2 = (HalfFloat)Next(random);

			Vertex3hf v2 = new Vertex3hf(x2, y2, z2);

			Vertex3hf v = v1 + v2;

			Assert.AreEqual((HalfFloat)(x1 + x2), v.x);
			Assert.AreEqual((HalfFloat)(y1 + y2), v.y);
			Assert.AreEqual((HalfFloat)(z1 + z2), v.z);
		}

		[Test(Description = "Test Vertex3hf.operator-(Vertex3hf, Vertex3hf)")]
		public void Vertex3hf_TestOperatorSub()
		{
			Random random = new Random();
			
			HalfFloat x1 = (HalfFloat)Next(random);
			HalfFloat y1 = (HalfFloat)Next(random);
			HalfFloat z1 = (HalfFloat)Next(random);

			Vertex3hf v1 = new Vertex3hf(x1, y1, z1);

			HalfFloat x2 = (HalfFloat)Next(random);
			HalfFloat y2 = (HalfFloat)Next(random);
			HalfFloat z2 = (HalfFloat)Next(random);

			Vertex3hf v2 = new Vertex3hf(x2, y2, z2);

			Vertex3hf v = v1 - v2;

			Assert.AreEqual((HalfFloat)(x1 - x2), v.x);
			Assert.AreEqual((HalfFloat)(y1 - y2), v.y);
			Assert.AreEqual((HalfFloat)(z1 - z2), v.z);
		}

		[Test(Description = "Test Vertex3hf.operator*(Vertex3hf, Single)")]
		public void Vertex3hf_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			HalfFloat x1 = (HalfFloat)Next(random);
			HalfFloat y1 = (HalfFloat)Next(random);
			HalfFloat z1 = (HalfFloat)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex3hf v1 = new Vertex3hf(x1, y1, z1);

			Vertex3hf v = v1 * (float)s;

			Assert.AreEqual((HalfFloat)(x1 * (float)s), v.x);
			Assert.AreEqual((HalfFloat)(y1 * (float)s), v.y);
			Assert.AreEqual((HalfFloat)(z1 * (float)s), v.z);
		}

		[Test(Description = "Test Vertex3hf.operator*(Vertex3hf, Double)")]
		public void Vertex3hf_TestOperatorMultiplyDouble()
		{
			Random random = new Random();
			
			HalfFloat x1 = (HalfFloat)Next(random);
			HalfFloat y1 = (HalfFloat)Next(random);
			HalfFloat z1 = (HalfFloat)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex3hf v1 = new Vertex3hf(x1, y1, z1);

			Vertex3hf v = v1 * s;

			Assert.AreEqual((HalfFloat)(x1 * s), v.x);
			Assert.AreEqual((HalfFloat)(y1 * s), v.y);
			Assert.AreEqual((HalfFloat)(z1 * s), v.z);
		}

		[Test(Description = "Test Vertex3hf.operator/(Vertex3hf, Single)")]
		public void Vertex3hf_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			HalfFloat x1 = (HalfFloat)Next(random);
			HalfFloat y1 = (HalfFloat)Next(random);
			HalfFloat z1 = (HalfFloat)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex3hf v1 = new Vertex3hf(x1, y1, z1);

			Vertex3hf v = v1 / (float)s;

			Assert.AreEqual((HalfFloat)(x1 / (float)s), v.x);
			Assert.AreEqual((HalfFloat)(y1 / (float)s), v.y);
			Assert.AreEqual((HalfFloat)(z1 / (float)s), v.z);
		}

		[Test(Description = "Test Vertex3hf.operator/(Vertex3hf, Double)")]
		public void Vertex3hf_TestOperatorDivideDouble()
		{
			Random random = new Random();
			
			HalfFloat x1 = (HalfFloat)Next(random);
			HalfFloat y1 = (HalfFloat)Next(random);
			HalfFloat z1 = (HalfFloat)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex3hf v1 = new Vertex3hf(x1, y1, z1);

			Vertex3hf v = v1 / s;

			Assert.AreEqual((HalfFloat)(x1 / s), v.x);
			Assert.AreEqual((HalfFloat)(y1 / s), v.y);
			Assert.AreEqual((HalfFloat)(z1 / s), v.z);
		}

		[Test(Description = "Test Vertex3hf.operator*(Vertex3hf, Vertex3hf)")]
		public void Vertex3hf_TestOperatorDotProduct()
		{
			Vertex3hf a, b;
			float d;

			a = Vertex3hf.UnitX;
			b = Vertex3hf.UnitY;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3hf.UnitY;
			b = Vertex3hf.UnitZ;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3hf.UnitX;
			b = Vertex3hf.UnitZ;
			d = a * b;
			Assert.AreEqual(0.0, d);

			a = Vertex3hf.UnitX;
			b = Vertex3hf.UnitX;
			d = a * b;
			Assert.AreEqual(1.0, d);

			a = Vertex3hf.UnitY;
			b = Vertex3hf.UnitY;
			d = a * b;
			Assert.AreEqual(1.0, d);

			a = Vertex3hf.UnitZ;
			b = Vertex3hf.UnitZ;
			d = a * b;
			Assert.AreEqual(1.0, d);
		}

		[Test(Description = "Test Vertex3hf.operator^(Vertex3hf, Vertex3hf)")]
		public void Vertex3hf_TestOperatorCrossProduct()
		{
			Vertex3hf a, b;
			Vertex3f c;

			a = Vertex3hf.UnitX;
			b = Vertex3hf.UnitY;
			c = a ^ b;
			Assert.AreEqual(Vertex3f.UnitZ, c);
		}


		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex3hf.operator==(Vertex3hf, Vertex3hf)")]
		public void Vertex3hf_TestOperatorEquality()
		{
			Vertex3hf v = Vertex3hf.UnitX;

			Assert.IsTrue(v == Vertex3hf.UnitX);
			Assert.IsFalse(v == Vertex3hf.UnitY);
		}

		[Test(Description = "Test Vertex3hf.operator!=(Vertex3hf, Vertex3hf)")]
		public void Vertex3hf_TestOperatorInequality()
		{
			Vertex3hf v = Vertex3hf.UnitX;

			Assert.IsFalse(v != Vertex3hf.UnitX);
			Assert.IsTrue(v != Vertex3hf.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex3hf.operator HalfFloat[](Vertex3hf)")]
		public void Vertex3hf_TestCastToArray()
		{
			Random random = new Random();
			
			HalfFloat x = (HalfFloat)Next(random);
			HalfFloat y = (HalfFloat)Next(random);
			HalfFloat z = (HalfFloat)Next(random);

			Vertex3hf v = new Vertex3hf(x, y, z);
			HalfFloat[] vArray = (HalfFloat[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex3hf.operator Vertex3f(Vertex3hf)")]
		public void Vertex3hf_TestCastToVertex3f()
		{
			Random random = new Random();
			
			HalfFloat x = (HalfFloat)Next(random);
			HalfFloat y = (HalfFloat)Next(random);
			HalfFloat z = (HalfFloat)Next(random);

			Vertex3hf v = new Vertex3hf(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.x, v3f.x, 1e-4f);
			Assert.AreEqual(v.y, v3f.y, 1e-4f);
			Assert.AreEqual(v.z, v3f.z, 1e-4f);
		}

		[Test(Description = "Test Vertex3hf.operator Vertex4f(Vertex3hf)")]
		public void Vertex3hf_TestCastToVertex4f()
		{
			Random random = new Random();
			
			HalfFloat x = (HalfFloat)Next(random);
			HalfFloat y = (HalfFloat)Next(random);
			HalfFloat z = (HalfFloat)Next(random);

			Vertex3hf v = new Vertex3hf(x, y, z);
			Vertex4f v4f = (Vertex4f)v;

			Assert.AreEqual(v.x, v4f.x, 1e-4);
			Assert.AreEqual(v.y, v4f.y, 1e-4);
			Assert.AreEqual(v.z, v4f.z, 1e-4);
			Assert.AreEqual(1.0f, v4f.w, 1e-4);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex3hf.Module()")]
		public void Vertex3hf_TestModule()
		{
			Assert.AreEqual(3.741657f, new Vertex3hf((HalfFloat)1.0, (HalfFloat)2.0, (HalfFloat)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex3hf((HalfFloat)2.0, (HalfFloat)5.0, (HalfFloat)7.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex3hf.ModuleSquared()")]
		public void Vertex3hf_TestModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex3hf((HalfFloat)1.0, (HalfFloat)2.0, (HalfFloat)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex3hf((HalfFloat)2.0, (HalfFloat)5.0, (HalfFloat)7.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex3hf.Normalize()")]
		public void Vertex3hf_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex3hf.Zero.Normalize(); });

			Vertex3hf v;

			v = Vertex3hf.UnitX * (HalfFloat)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3hf.UnitX, v);

			v = Vertex3hf.UnitY * (HalfFloat)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3hf.UnitY, v);

			v = Vertex3hf.UnitZ * (HalfFloat)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex3hf.UnitZ, v);
		}

		[Test(Description = "Test Vertex3hf.Normalized")]
		public void Vertex3hf_TestNormalized()
		{
			Vertex3hf v;

			Assert.DoesNotThrow(delegate() { v = Vertex3hf.Zero.Normalized; });

			v = Vertex3hf.UnitX * (HalfFloat)2.0f;
			Assert.AreEqual(Vertex3hf.UnitX, v.Normalized);

			v = Vertex3hf.UnitY * (HalfFloat)2.0f;
			Assert.AreEqual(Vertex3hf.UnitY, v.Normalized);

			v = Vertex3hf.UnitZ * (HalfFloat)2.0f;
			Assert.AreEqual(Vertex3hf.UnitZ, v.Normalized);
		}

		[Test(Description = "Test Vertex3hf.Min(Vertex3hf[])")]
		public void Vertex3hf_TestMin()
		{
			Vertex3hf[] v = new Vertex3hf[] {
				new Vertex3hf((HalfFloat)1.0f, (HalfFloat)13.0f, (HalfFloat)22.0f),
				new Vertex3hf((HalfFloat)2.0f, (HalfFloat)12.0f, (HalfFloat)21.0f),
				new Vertex3hf((HalfFloat)3.0f, (HalfFloat)11.0f, (HalfFloat)23.0f),
			};

			Vertex3hf min = Vertex3hf.Min(v);

			Assert.AreEqual(
				new Vertex3hf((HalfFloat)1.0f, (HalfFloat)11.0f, (HalfFloat)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex3hf.Min(Vertex3hf[]) ArgumentNullException")]
		public void Vertex3hf_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex3hf.Min(null));
		}

		[Test(Description = "Test Vertex3hf.Min(Vertex3hf*)")]
		public void Vertex3hf_TestMin_Unsafe()
		{
			Vertex3hf[] v = new Vertex3hf[] {
				new Vertex3hf((HalfFloat)1.0f, (HalfFloat)13.0f, (HalfFloat)22.0f),
				new Vertex3hf((HalfFloat)2.0f, (HalfFloat)12.0f, (HalfFloat)21.0f),
				new Vertex3hf((HalfFloat)3.0f, (HalfFloat)11.0f, (HalfFloat)23.0f),
			};

			Vertex3hf min;

			unsafe {
				fixed (Vertex3hf* vPtr = v) {
					min = Vertex3hf.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex3hf((HalfFloat)1.0f, (HalfFloat)11.0f, (HalfFloat)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex3hf.Min(Vertex3hf*) ArgumentNullException")]
		public void Vertex3hf_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3hf.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex3hf.Max(Vertex3hf[])")]
		public void Vertex3hf_TestMax()
		{
			Vertex3hf[] v = new Vertex3hf[] {
				new Vertex3hf((HalfFloat)1.0f, (HalfFloat)13.0f, (HalfFloat)22.0f),
				new Vertex3hf((HalfFloat)2.0f, (HalfFloat)12.0f, (HalfFloat)21.0f),
				new Vertex3hf((HalfFloat)3.0f, (HalfFloat)11.0f, (HalfFloat)23.0f),
			};

			Vertex3hf max = Vertex3hf.Max(v);

			Assert.AreEqual(
				new Vertex3hf((HalfFloat)3.0f, (HalfFloat)13.0f, (HalfFloat)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3hf.Max(Vertex3hf[]) ArgumentNullException")]
		public void Vertex3hf_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex3hf.Max(null));
		}

		[Test(Description = "Test Vertex3hf.Max(Vertex3hf*)")]
		public void Vertex3hf_TestMax_Unsafe()
		{
			Vertex3hf[] v = new Vertex3hf[] {
				new Vertex3hf((HalfFloat)1.0f, (HalfFloat)13.0f, (HalfFloat)22.0f),
				new Vertex3hf((HalfFloat)2.0f, (HalfFloat)12.0f, (HalfFloat)21.0f),
				new Vertex3hf((HalfFloat)3.0f, (HalfFloat)11.0f, (HalfFloat)23.0f),
			};

			Vertex3hf max;

			unsafe {
				fixed (Vertex3hf* vPtr = v) {
					max = Vertex3hf.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex3hf((HalfFloat)3.0f, (HalfFloat)13.0f, (HalfFloat)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3hf.Max(Vertex3hf*) ArgumentNullException")]
		public void Vertex3hf_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3hf.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex3hf.Max(Vertex3hf[])")]
		public void Vertex3hf_TestMinMax()
		{
			Vertex3hf[] v = new Vertex3hf[] {
				new Vertex3hf((HalfFloat)1.0f, (HalfFloat)13.0f, (HalfFloat)22.0f),
				new Vertex3hf((HalfFloat)2.0f, (HalfFloat)12.0f, (HalfFloat)21.0f),
				new Vertex3hf((HalfFloat)3.0f, (HalfFloat)11.0f, (HalfFloat)23.0f),
			};

			Vertex3hf min, max;

			Vertex3hf.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex3hf((HalfFloat)1.0f, (HalfFloat)11.0f, (HalfFloat)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex3hf((HalfFloat)3.0f, (HalfFloat)13.0f, (HalfFloat)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3hf.Max(Vertex3hf[]) ArgumentNullException")]
		public void Vertex3hf_TestMinMax_ArgumentNullException()
		{
			Vertex3hf min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex3hf.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex3hf.MinMax(Vertex3hf*)")]
		public void Vertex3hf_TestMinMax_Unsafe()
		{
			Vertex3hf[] v = new Vertex3hf[] {
				new Vertex3hf((HalfFloat)1.0f, (HalfFloat)13.0f, (HalfFloat)22.0f),
				new Vertex3hf((HalfFloat)2.0f, (HalfFloat)12.0f, (HalfFloat)21.0f),
				new Vertex3hf((HalfFloat)3.0f, (HalfFloat)11.0f, (HalfFloat)23.0f),
			};

			Vertex3hf min, max;

			unsafe {
				fixed (Vertex3hf* vPtr = v) {
					Vertex3hf.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex3hf((HalfFloat)1.0f, (HalfFloat)11.0f, (HalfFloat)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex3hf((HalfFloat)3.0f, (HalfFloat)13.0f, (HalfFloat)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex3hf.MinMax(Vertex3hf*) ArgumentNullException")]
		public void Vertex3hf_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex3hf min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex3hf.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex3hf.Equals(Vertex3hf)")]
		public void Vertex3hf_TestEquals_Vertex3hf()
		{
			Vertex3hf v = Vertex3hf.UnitX;

			Assert.IsTrue(v.Equals(Vertex3hf.UnitX));
			Assert.IsFalse(v.Equals(Vertex3hf.UnitY));
			Assert.IsFalse(v.Equals(Vertex3hf.UnitZ));
		}

		[Test(Description = "Test Vertex3hf.Equals(object)")]
		public void Vertex3hf_TestEquals_Object()
		{
			Vertex3hf v = Vertex3hf.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex3hf.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex3hf.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex3hf.UnitZ));
		}

		[Test(Description = "Test Vertex3hf.GetHashCode()")]
		public void Vertex3hf_TestGetHashCode()
		{
			Random random = new Random();
			
			HalfFloat x = (HalfFloat)Next(random);
			HalfFloat y = (HalfFloat)Next(random);
			HalfFloat z = (HalfFloat)Next(random);

			Vertex3hf v = new Vertex3hf(x, y, z);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex3hf.ToString()")]
		public void Vertex3hf_TestToString()
		{
			Random random = new Random();
			
			HalfFloat x = (HalfFloat)Next(random);
			HalfFloat y = (HalfFloat)Next(random);
			HalfFloat z = (HalfFloat)Next(random);

			Vertex3hf v = new Vertex3hf(x, y, z);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

}
