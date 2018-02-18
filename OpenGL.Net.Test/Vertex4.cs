
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
	class Vertex4TestBase
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
	class Vertex4ubTest : Vertex3TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex4ub(byte)")]
		public void Vertex4ub_TestConstructor1()
		{
			Random random = new Random();
			byte randomValue = (byte)Next(random);
			
			Vertex4ub v = new Vertex4ub(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex4ub(byte[])")]
		public void Vertex4ub_TestConstructor2()
		{
			Random random = new Random();
			byte randomValueX = (byte)Next(random);
			byte randomValueY = (byte)Next(random);
			byte randomValueZ = (byte)Next(random);
			byte randomValueW = (byte)Next(random);
			Vertex4ub v;

			v = new Vertex4ub(new byte[] {
				randomValueX, randomValueY, randomValueZ
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);

			v = new Vertex4ub(new byte[] {
				randomValueX, randomValueY, randomValueZ, randomValueW
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
			Assert.AreEqual(randomValueW, v.w);
		}

		[Test(Description = "Test Vertex4ub(byte, byte, byte)")]
		public void Vertex4ub_TestConstructor3()
		{
			Random random = new Random();
			byte randomValueX = (byte)Next(random);
			byte randomValueY = (byte)Next(random);
			byte randomValueZ = (byte)Next(random);

			Vertex4ub v = new Vertex4ub(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex4ub.Size against Marshal.SizeOf")]
		public void Vertex4ub_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex4ub)), Vertex4ub.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex4ub.operator+(Vertex4ub, Vertex4ub)")]
		public void Vertex4ub_TestOperatorAdd()
		{
			Random random = new Random();
			
			byte x1 = (byte)Next(random);
			byte y1 = (byte)Next(random);
			byte z1 = (byte)Next(random);

			Vertex4ub v1 = new Vertex4ub(x1, y1, z1);

			byte x2 = (byte)Next(random);
			byte y2 = (byte)Next(random);
			byte z2 = (byte)Next(random);

			Vertex4ub v2 = new Vertex4ub(x2, y2, z2);

			Vertex4ub v = v1 + v2;

			Assert.AreEqual((byte)(x1 + x2), v.x);
			Assert.AreEqual((byte)(y1 + y2), v.y);
			Assert.AreEqual((byte)(z1 + z2), v.z);
		}

		[Test(Description = "Test Vertex4ub.operator-(Vertex4ub, Vertex4ub)")]
		public void Vertex4ub_TestOperatorSub()
		{
			Random random = new Random();
			
			byte x1 = (byte)Next(random);
			byte y1 = (byte)Next(random);
			byte z1 = (byte)Next(random);

			Vertex4ub v1 = new Vertex4ub(x1, y1, z1);

			byte x2 = (byte)Next(random);
			byte y2 = (byte)Next(random);
			byte z2 = (byte)Next(random);

			Vertex4ub v2 = new Vertex4ub(x2, y2, z2);

			Vertex4ub v = v1 - v2;

			Assert.AreEqual((byte)(x1 - x2), v.x);
			Assert.AreEqual((byte)(y1 - y2), v.y);
			Assert.AreEqual((byte)(z1 - z2), v.z);
		}

		[Test(Description = "Test Vertex4ub.operator*(Vertex4ub, Single)")]
		public void Vertex4ub_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			byte x1 = (byte)Next(random);
			byte y1 = (byte)Next(random);
			byte z1 = (byte)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex4ub v1 = new Vertex4ub(x1, y1, z1);

			Vertex4ub v = v1 * (float)s;

			Assert.AreEqual((byte)(x1 * (float)s), v.x);
			Assert.AreEqual((byte)(y1 * (float)s), v.y);
			Assert.AreEqual((byte)(z1 * (float)s), v.z);
		}

		[Test(Description = "Test Vertex4ub.operator/(Vertex4ub, Single)")]
		public void Vertex4ub_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			byte x1 = (byte)Next(random);
			byte y1 = (byte)Next(random);
			byte z1 = (byte)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex4ub v1 = new Vertex4ub(x1, y1, z1);

			Vertex4ub v = v1 / (float)s;

			Assert.AreEqual((byte)(x1 / (float)s), v.x);
			Assert.AreEqual((byte)(y1 / (float)s), v.y);
			Assert.AreEqual((byte)(z1 / (float)s), v.z);
		}

		[Test(Description = "Test Vertex4ub.operator*(Vertex4ub, byte)")]
		public void Vertex4ub_TestOperatorScalarMultiply()
		{
			Random random = new Random();
			
			byte x1 = (byte)Next(random);
			byte y1 = (byte)Next(random);
			byte z1 = (byte)Next(random);
			byte s = (byte)Next(random, 0.0, 32.0);

			Vertex4ub v1 = new Vertex4ub(x1, y1, z1);

			Vertex4ub v = v1 * s;

			Assert.AreEqual((byte)(x1 * s), v.x);
			Assert.AreEqual((byte)(y1 * s), v.y);
			Assert.AreEqual((byte)(z1 * s), v.z);
		}

		[Test(Description = "Test Vertex4ub.operator/(Vertex4ub, byte)")]
		public void Vertex4ub_TestOperatorScalarDivide()
		{
			Random random = new Random();
			
			byte x1 = (byte)Next(random);
			byte y1 = (byte)Next(random);
			byte z1 = (byte)Next(random);
			byte s = (byte)Next(random, 1.0, 32.0);

			Vertex4ub v1 = new Vertex4ub(x1, y1, z1);

			Vertex4ub v = v1 / s;

			Assert.AreEqual((byte)(x1 / s), v.x);
			Assert.AreEqual((byte)(y1 / s), v.y);
			Assert.AreEqual((byte)(z1 / s), v.z);
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex4ub.operator==(Vertex4ub, Vertex4ub)")]
		public void Vertex4ub_TestOperatorEquality()
		{
			Vertex4ub v = Vertex4ub.UnitX;

			Assert.IsTrue(v == Vertex4ub.UnitX);
			Assert.IsFalse(v == Vertex4ub.UnitY);
		}

		[Test(Description = "Test Vertex4ub.operator!=(Vertex4ub, Vertex4ub)")]
		public void Vertex4ub_TestOperatorInequality()
		{
			Vertex4ub v = Vertex4ub.UnitX;

			Assert.IsFalse(v != Vertex4ub.UnitX);
			Assert.IsTrue(v != Vertex4ub.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex4ub.operator byte[](Vertex4ub)")]
		public void Vertex4ub_TestCastToArray()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random);
			byte y = (byte)Next(random);
			byte z = (byte)Next(random);

			Vertex4ub v = new Vertex4ub(x, y, z);
			byte[] vArray = (byte[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex4ub.operator Vertex2f(Vertex4ub)")]
		public void Vertex4ub_TestCastToVertex2f()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random);
			byte y = (byte)Next(random);
			byte z = (byte)Next(random);

			Vertex4ub v = new Vertex4ub(x, y, z);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.x, (float)v2f.x, 1e-4f);
			Assert.AreEqual(v.y, (float)v2f.y, 1e-4f);
		}

		[Test(Description = "Test Vertex4ub.operator Vertex3f(Vertex4ub)")]
		public void Vertex4ub_TestCastToVertex3f()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random);
			byte y = (byte)Next(random);
			byte z = (byte)Next(random);

			Vertex4ub v = new Vertex4ub(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.x, v3f.x, 1e-4f);
			Assert.AreEqual(v.y, v3f.y, 1e-4f);
			Assert.AreEqual(v.z, v3f.z, 1e-4f);
		}

		[Test(Description = "Test Vertex4ub.operator Vertex3d(Vertex4ub)")]
		public void Vertex4ub_TestCastToVertex3d()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random);
			byte y = (byte)Next(random);
			byte z = (byte)Next(random);

			Vertex4ub v = new Vertex4ub(x, y, z);
			Vertex3d v3d = (Vertex3d)v;

			Assert.AreEqual(v.x, v3d.x, 1e-4);
			Assert.AreEqual(v.y, v3d.y, 1e-4);
			Assert.AreEqual(v.z, v3d.z, 1e-4);
		}

		[Test(Description = "Test Vertex4ub.operator Vertex4f(Vertex4ub)")]
		public void Vertex4ub_TestCastToVertex4f()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random);
			byte y = (byte)Next(random);
			byte z = (byte)Next(random);

			Vertex4ub v = new Vertex4ub(x, y, z);
			Vertex4f v4f = (Vertex4f)v;

			Assert.AreEqual(v.x, v4f.x, 1e-4);
			Assert.AreEqual(v.y, v4f.y, 1e-4);
			Assert.AreEqual(v.z, v4f.z, 1e-4);
			Assert.AreEqual(1.0f, v4f.w, 1e-4);
		}

		[Test(Description = "Test Vertex4ub.operator Vertex4d(Vertex4ub)")]
		public void Vertex4ub_TestCastToVertex4d()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random);
			byte y = (byte)Next(random);
			byte z = (byte)Next(random);

			Vertex4ub v = new Vertex4ub(x, y, z);
			Vertex4d v4d = (Vertex4d)v;

			Assert.AreEqual(v.x, v4d.x, 1e-4);
			Assert.AreEqual(v.y, v4d.y, 1e-4);
			Assert.AreEqual(v.z, v4d.z, 1e-4);
			Assert.AreEqual(1.0f, v4d.w, 1e-4);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex4ub.Module()")]
		public void Vertex4ub_TestModule()
		{
			Assert.AreEqual(3.741657f, new Vertex4ub((byte)1.0, (byte)2.0, (byte)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex4ub((byte)2.0, (byte)5.0, (byte)7.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex4ub.ModuleSquared()")]
		public void Vertex4ub_TestModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex4ub((byte)1.0, (byte)2.0, (byte)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex4ub((byte)2.0, (byte)5.0, (byte)7.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex4ub.Normalize()")]
		public void Vertex4ub_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex4ub.Zero.Normalize(); });

			Vertex4ub v;

			v = Vertex4ub.UnitX * (byte)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4ub.UnitX, v);

			v = Vertex4ub.UnitY * (byte)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4ub.UnitY, v);

			v = Vertex4ub.UnitZ * (byte)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4ub.UnitZ, v);
		}

		[Test(Description = "Test Vertex4ub.Normalized")]
		public void Vertex4ub_TestNormalized()
		{
			Vertex4ub v;

			Assert.DoesNotThrow(delegate() { v = Vertex4ub.Zero.Normalized; });

			v = Vertex4ub.UnitX * (byte)2.0f;
			Assert.AreEqual(Vertex4ub.UnitX, v.Normalized);

			v = Vertex4ub.UnitY * (byte)2.0f;
			Assert.AreEqual(Vertex4ub.UnitY, v.Normalized);

			v = Vertex4ub.UnitZ * (byte)2.0f;
			Assert.AreEqual(Vertex4ub.UnitZ, v.Normalized);
		}

		[Test(Description = "Test Vertex4ub.Min(Vertex4ub[])")]
		public void Vertex4ub_TestMin()
		{
			Vertex4ub[] v = new Vertex4ub[] {
				new Vertex4ub((byte)1.0f, (byte)13.0f, (byte)22.0f),
				new Vertex4ub((byte)2.0f, (byte)12.0f, (byte)21.0f),
				new Vertex4ub((byte)3.0f, (byte)11.0f, (byte)23.0f),
			};

			Vertex4ub min = Vertex4ub.Min(v);

			Assert.AreEqual(
				new Vertex4ub((byte)1.0f, (byte)11.0f, (byte)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex4ub.Min(Vertex4ub[]) ArgumentNullException")]
		public void Vertex4ub_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4ub.Min(null));
		}

		[Test(Description = "Test Vertex4ub.Min(Vertex4ub*)")]
		public void Vertex4ub_TestMin_Unsafe()
		{
			Vertex4ub[] v = new Vertex4ub[] {
				new Vertex4ub((byte)1.0f, (byte)13.0f, (byte)22.0f),
				new Vertex4ub((byte)2.0f, (byte)12.0f, (byte)21.0f),
				new Vertex4ub((byte)3.0f, (byte)11.0f, (byte)23.0f),
			};

			Vertex4ub min;

			unsafe {
				fixed (Vertex4ub* vPtr = v) {
					min = Vertex4ub.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex4ub((byte)1.0f, (byte)11.0f, (byte)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex4ub.Min(Vertex4ub*) ArgumentNullException")]
		public void Vertex4ub_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4ub.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex4ub.Max(Vertex4ub[])")]
		public void Vertex4ub_TestMax()
		{
			Vertex4ub[] v = new Vertex4ub[] {
				new Vertex4ub((byte)1.0f, (byte)13.0f, (byte)22.0f),
				new Vertex4ub((byte)2.0f, (byte)12.0f, (byte)21.0f),
				new Vertex4ub((byte)3.0f, (byte)11.0f, (byte)23.0f),
			};

			Vertex4ub max = Vertex4ub.Max(v);

			Assert.AreEqual(
				new Vertex4ub((byte)3.0f, (byte)13.0f, (byte)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4ub.Max(Vertex4ub[]) ArgumentNullException")]
		public void Vertex4ub_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4ub.Max(null));
		}

		[Test(Description = "Test Vertex4ub.Max(Vertex4ub*)")]
		public void Vertex4ub_TestMax_Unsafe()
		{
			Vertex4ub[] v = new Vertex4ub[] {
				new Vertex4ub((byte)1.0f, (byte)13.0f, (byte)22.0f),
				new Vertex4ub((byte)2.0f, (byte)12.0f, (byte)21.0f),
				new Vertex4ub((byte)3.0f, (byte)11.0f, (byte)23.0f),
			};

			Vertex4ub max;

			unsafe {
				fixed (Vertex4ub* vPtr = v) {
					max = Vertex4ub.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex4ub((byte)3.0f, (byte)13.0f, (byte)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4ub.Max(Vertex4ub*) ArgumentNullException")]
		public void Vertex4ub_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4ub.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex4ub.Max(Vertex4ub[])")]
		public void Vertex4ub_TestMinMax()
		{
			Vertex4ub[] v = new Vertex4ub[] {
				new Vertex4ub((byte)1.0f, (byte)13.0f, (byte)22.0f),
				new Vertex4ub((byte)2.0f, (byte)12.0f, (byte)21.0f),
				new Vertex4ub((byte)3.0f, (byte)11.0f, (byte)23.0f),
			};

			Vertex4ub min, max;

			Vertex4ub.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex4ub((byte)1.0f, (byte)11.0f, (byte)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex4ub((byte)3.0f, (byte)13.0f, (byte)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4ub.Max(Vertex4ub[]) ArgumentNullException")]
		public void Vertex4ub_TestMinMax_ArgumentNullException()
		{
			Vertex4ub min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex4ub.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex4ub.MinMax(Vertex4ub*)")]
		public void Vertex4ub_TestMinMax_Unsafe()
		{
			Vertex4ub[] v = new Vertex4ub[] {
				new Vertex4ub((byte)1.0f, (byte)13.0f, (byte)22.0f),
				new Vertex4ub((byte)2.0f, (byte)12.0f, (byte)21.0f),
				new Vertex4ub((byte)3.0f, (byte)11.0f, (byte)23.0f),
			};

			Vertex4ub min, max;

			unsafe {
				fixed (Vertex4ub* vPtr = v) {
					Vertex4ub.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex4ub((byte)1.0f, (byte)11.0f, (byte)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex4ub((byte)3.0f, (byte)13.0f, (byte)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4ub.MinMax(Vertex4ub*) ArgumentNullException")]
		public void Vertex4ub_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex4ub min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4ub.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex4ub.Equals(Vertex4ub)")]
		public void Vertex4ub_TestEquals_Vertex4ub()
		{
			Vertex4ub v = Vertex4ub.UnitX;

			Assert.IsTrue(v.Equals(Vertex4ub.UnitX));
			Assert.IsFalse(v.Equals(Vertex4ub.UnitY));
			Assert.IsFalse(v.Equals(Vertex4ub.UnitZ));

			// Defined vs Undefined equality
			Vertex4ub v1 = new Vertex4ub(1, 1, 1, 1);
			Vertex4ub v2 = new Vertex4ub(1, 1, 1, 0);

			Assert.IsFalse(v1.Equals(v2));
			Assert.IsFalse(v2.Equals(v1));

			// Undefined vs Undefined equality
			v1 = new Vertex4ub(1, 1, 1, 0);
			v2 = new Vertex4ub(1, 1, 1, 0);

			Assert.IsTrue(v1.Equals(v2));
			Assert.IsTrue(v2.Equals(v1));

			// Normalized equality
			v1 = new Vertex4ub(1);
			v2 = new Vertex4ub((byte)(1 + 1));

			Assert.IsTrue(v1.Equals(v2));
			Assert.IsTrue(v2.Equals(v1));
		}

		[Test(Description = "Test Vertex4ub.Equals(object)")]
		public void Vertex4ub_TestEquals_Object()
		{
			Vertex4ub v = Vertex4ub.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex4ub.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex4ub.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex4ub.UnitZ));
		}

		[Test(Description = "Test Vertex4ub.GetHashCode()")]
		public void Vertex4ub_TestGetHashCode()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random);
			byte y = (byte)Next(random);
			byte z = (byte)Next(random);

			Vertex4ub v = new Vertex4ub(x, y, z);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex4ub.ToString()")]
		public void Vertex4ub_TestToString()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random);
			byte y = (byte)Next(random);
			byte z = (byte)Next(random);

			Vertex4ub v = new Vertex4ub(x, y, z);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex4bTest : Vertex3TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex4b(sbyte)")]
		public void Vertex4b_TestConstructor1()
		{
			Random random = new Random();
			sbyte randomValue = (sbyte)Next(random);
			
			Vertex4b v = new Vertex4b(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex4b(sbyte[])")]
		public void Vertex4b_TestConstructor2()
		{
			Random random = new Random();
			sbyte randomValueX = (sbyte)Next(random);
			sbyte randomValueY = (sbyte)Next(random);
			sbyte randomValueZ = (sbyte)Next(random);
			sbyte randomValueW = (sbyte)Next(random);
			Vertex4b v;

			v = new Vertex4b(new sbyte[] {
				randomValueX, randomValueY, randomValueZ
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);

			v = new Vertex4b(new sbyte[] {
				randomValueX, randomValueY, randomValueZ, randomValueW
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
			Assert.AreEqual(randomValueW, v.w);
		}

		[Test(Description = "Test Vertex4b(sbyte, sbyte, sbyte)")]
		public void Vertex4b_TestConstructor3()
		{
			Random random = new Random();
			sbyte randomValueX = (sbyte)Next(random);
			sbyte randomValueY = (sbyte)Next(random);
			sbyte randomValueZ = (sbyte)Next(random);

			Vertex4b v = new Vertex4b(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex4b.Size against Marshal.SizeOf")]
		public void Vertex4b_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex4b)), Vertex4b.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex4b.operator-(Vertex4b))")]
		public void Vertex4b_TestOperatorNegate()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random);
			sbyte y = (sbyte)Next(random);
			sbyte z = (sbyte)Next(random);

			Vertex4b v = new Vertex4b(x, y, z);
			Vertex4b n = -v;

			Assert.AreEqual(-x, n.x);
			Assert.AreEqual(-y, n.y);
			Assert.AreEqual(-z, n.z);
		}
		[Test(Description = "Test Vertex4b.operator+(Vertex4b, Vertex4b)")]
		public void Vertex4b_TestOperatorAdd()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random);
			sbyte y1 = (sbyte)Next(random);
			sbyte z1 = (sbyte)Next(random);

			Vertex4b v1 = new Vertex4b(x1, y1, z1);

			sbyte x2 = (sbyte)Next(random);
			sbyte y2 = (sbyte)Next(random);
			sbyte z2 = (sbyte)Next(random);

			Vertex4b v2 = new Vertex4b(x2, y2, z2);

			Vertex4b v = v1 + v2;

			Assert.AreEqual((sbyte)(x1 + x2), v.x);
			Assert.AreEqual((sbyte)(y1 + y2), v.y);
			Assert.AreEqual((sbyte)(z1 + z2), v.z);
		}

		[Test(Description = "Test Vertex4b.operator-(Vertex4b, Vertex4b)")]
		public void Vertex4b_TestOperatorSub()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random);
			sbyte y1 = (sbyte)Next(random);
			sbyte z1 = (sbyte)Next(random);

			Vertex4b v1 = new Vertex4b(x1, y1, z1);

			sbyte x2 = (sbyte)Next(random);
			sbyte y2 = (sbyte)Next(random);
			sbyte z2 = (sbyte)Next(random);

			Vertex4b v2 = new Vertex4b(x2, y2, z2);

			Vertex4b v = v1 - v2;

			Assert.AreEqual((sbyte)(x1 - x2), v.x);
			Assert.AreEqual((sbyte)(y1 - y2), v.y);
			Assert.AreEqual((sbyte)(z1 - z2), v.z);
		}

		[Test(Description = "Test Vertex4b.operator*(Vertex4b, Single)")]
		public void Vertex4b_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random);
			sbyte y1 = (sbyte)Next(random);
			sbyte z1 = (sbyte)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex4b v1 = new Vertex4b(x1, y1, z1);

			Vertex4b v = v1 * (float)s;

			Assert.AreEqual((sbyte)(x1 * (float)s), v.x);
			Assert.AreEqual((sbyte)(y1 * (float)s), v.y);
			Assert.AreEqual((sbyte)(z1 * (float)s), v.z);
		}

		[Test(Description = "Test Vertex4b.operator/(Vertex4b, Single)")]
		public void Vertex4b_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random);
			sbyte y1 = (sbyte)Next(random);
			sbyte z1 = (sbyte)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex4b v1 = new Vertex4b(x1, y1, z1);

			Vertex4b v = v1 / (float)s;

			Assert.AreEqual((sbyte)(x1 / (float)s), v.x);
			Assert.AreEqual((sbyte)(y1 / (float)s), v.y);
			Assert.AreEqual((sbyte)(z1 / (float)s), v.z);
		}

		[Test(Description = "Test Vertex4b.operator*(Vertex4b, sbyte)")]
		public void Vertex4b_TestOperatorScalarMultiply()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random);
			sbyte y1 = (sbyte)Next(random);
			sbyte z1 = (sbyte)Next(random);
			sbyte s = (sbyte)Next(random, 0.0, 32.0);

			Vertex4b v1 = new Vertex4b(x1, y1, z1);

			Vertex4b v = v1 * s;

			Assert.AreEqual((sbyte)(x1 * s), v.x);
			Assert.AreEqual((sbyte)(y1 * s), v.y);
			Assert.AreEqual((sbyte)(z1 * s), v.z);
		}

		[Test(Description = "Test Vertex4b.operator/(Vertex4b, sbyte)")]
		public void Vertex4b_TestOperatorScalarDivide()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random);
			sbyte y1 = (sbyte)Next(random);
			sbyte z1 = (sbyte)Next(random);
			sbyte s = (sbyte)Next(random, 1.0, 32.0);

			Vertex4b v1 = new Vertex4b(x1, y1, z1);

			Vertex4b v = v1 / s;

			Assert.AreEqual((sbyte)(x1 / s), v.x);
			Assert.AreEqual((sbyte)(y1 / s), v.y);
			Assert.AreEqual((sbyte)(z1 / s), v.z);
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex4b.operator==(Vertex4b, Vertex4b)")]
		public void Vertex4b_TestOperatorEquality()
		{
			Vertex4b v = Vertex4b.UnitX;

			Assert.IsTrue(v == Vertex4b.UnitX);
			Assert.IsFalse(v == Vertex4b.UnitY);
		}

		[Test(Description = "Test Vertex4b.operator!=(Vertex4b, Vertex4b)")]
		public void Vertex4b_TestOperatorInequality()
		{
			Vertex4b v = Vertex4b.UnitX;

			Assert.IsFalse(v != Vertex4b.UnitX);
			Assert.IsTrue(v != Vertex4b.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex4b.operator sbyte[](Vertex4b)")]
		public void Vertex4b_TestCastToArray()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random);
			sbyte y = (sbyte)Next(random);
			sbyte z = (sbyte)Next(random);

			Vertex4b v = new Vertex4b(x, y, z);
			sbyte[] vArray = (sbyte[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex4b.operator Vertex2f(Vertex4b)")]
		public void Vertex4b_TestCastToVertex2f()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random);
			sbyte y = (sbyte)Next(random);
			sbyte z = (sbyte)Next(random);

			Vertex4b v = new Vertex4b(x, y, z);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.x, (float)v2f.x, 1e-4f);
			Assert.AreEqual(v.y, (float)v2f.y, 1e-4f);
		}

		[Test(Description = "Test Vertex4b.operator Vertex3f(Vertex4b)")]
		public void Vertex4b_TestCastToVertex3f()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random);
			sbyte y = (sbyte)Next(random);
			sbyte z = (sbyte)Next(random);

			Vertex4b v = new Vertex4b(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.x, v3f.x, 1e-4f);
			Assert.AreEqual(v.y, v3f.y, 1e-4f);
			Assert.AreEqual(v.z, v3f.z, 1e-4f);
		}

		[Test(Description = "Test Vertex4b.operator Vertex3d(Vertex4b)")]
		public void Vertex4b_TestCastToVertex3d()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random);
			sbyte y = (sbyte)Next(random);
			sbyte z = (sbyte)Next(random);

			Vertex4b v = new Vertex4b(x, y, z);
			Vertex3d v3d = (Vertex3d)v;

			Assert.AreEqual(v.x, v3d.x, 1e-4);
			Assert.AreEqual(v.y, v3d.y, 1e-4);
			Assert.AreEqual(v.z, v3d.z, 1e-4);
		}

		[Test(Description = "Test Vertex4b.operator Vertex4f(Vertex4b)")]
		public void Vertex4b_TestCastToVertex4f()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random);
			sbyte y = (sbyte)Next(random);
			sbyte z = (sbyte)Next(random);

			Vertex4b v = new Vertex4b(x, y, z);
			Vertex4f v4f = (Vertex4f)v;

			Assert.AreEqual(v.x, v4f.x, 1e-4);
			Assert.AreEqual(v.y, v4f.y, 1e-4);
			Assert.AreEqual(v.z, v4f.z, 1e-4);
			Assert.AreEqual(1.0f, v4f.w, 1e-4);
		}

		[Test(Description = "Test Vertex4b.operator Vertex4d(Vertex4b)")]
		public void Vertex4b_TestCastToVertex4d()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random);
			sbyte y = (sbyte)Next(random);
			sbyte z = (sbyte)Next(random);

			Vertex4b v = new Vertex4b(x, y, z);
			Vertex4d v4d = (Vertex4d)v;

			Assert.AreEqual(v.x, v4d.x, 1e-4);
			Assert.AreEqual(v.y, v4d.y, 1e-4);
			Assert.AreEqual(v.z, v4d.z, 1e-4);
			Assert.AreEqual(1.0f, v4d.w, 1e-4);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex4b.Module()")]
		public void Vertex4b_TestModule()
		{
			Assert.AreEqual(3.741657f, new Vertex4b((sbyte)1.0, (sbyte)2.0, (sbyte)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex4b((sbyte)2.0, (sbyte)5.0, (sbyte)7.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex4b.ModuleSquared()")]
		public void Vertex4b_TestModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex4b((sbyte)1.0, (sbyte)2.0, (sbyte)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex4b((sbyte)2.0, (sbyte)5.0, (sbyte)7.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex4b.Normalize()")]
		public void Vertex4b_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex4b.Zero.Normalize(); });

			Vertex4b v;

			v = Vertex4b.UnitX * (sbyte)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4b.UnitX, v);

			v = Vertex4b.UnitY * (sbyte)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4b.UnitY, v);

			v = Vertex4b.UnitZ * (sbyte)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4b.UnitZ, v);
		}

		[Test(Description = "Test Vertex4b.Normalized")]
		public void Vertex4b_TestNormalized()
		{
			Vertex4b v;

			Assert.DoesNotThrow(delegate() { v = Vertex4b.Zero.Normalized; });

			v = Vertex4b.UnitX * (sbyte)2.0f;
			Assert.AreEqual(Vertex4b.UnitX, v.Normalized);

			v = Vertex4b.UnitY * (sbyte)2.0f;
			Assert.AreEqual(Vertex4b.UnitY, v.Normalized);

			v = Vertex4b.UnitZ * (sbyte)2.0f;
			Assert.AreEqual(Vertex4b.UnitZ, v.Normalized);
		}

		[Test(Description = "Test Vertex4b.Min(Vertex4b[])")]
		public void Vertex4b_TestMin()
		{
			Vertex4b[] v = new Vertex4b[] {
				new Vertex4b((sbyte)1.0f, (sbyte)13.0f, (sbyte)22.0f),
				new Vertex4b((sbyte)2.0f, (sbyte)12.0f, (sbyte)21.0f),
				new Vertex4b((sbyte)3.0f, (sbyte)11.0f, (sbyte)23.0f),
			};

			Vertex4b min = Vertex4b.Min(v);

			Assert.AreEqual(
				new Vertex4b((sbyte)1.0f, (sbyte)11.0f, (sbyte)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex4b.Min(Vertex4b[]) ArgumentNullException")]
		public void Vertex4b_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4b.Min(null));
		}

		[Test(Description = "Test Vertex4b.Min(Vertex4b*)")]
		public void Vertex4b_TestMin_Unsafe()
		{
			Vertex4b[] v = new Vertex4b[] {
				new Vertex4b((sbyte)1.0f, (sbyte)13.0f, (sbyte)22.0f),
				new Vertex4b((sbyte)2.0f, (sbyte)12.0f, (sbyte)21.0f),
				new Vertex4b((sbyte)3.0f, (sbyte)11.0f, (sbyte)23.0f),
			};

			Vertex4b min;

			unsafe {
				fixed (Vertex4b* vPtr = v) {
					min = Vertex4b.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex4b((sbyte)1.0f, (sbyte)11.0f, (sbyte)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex4b.Min(Vertex4b*) ArgumentNullException")]
		public void Vertex4b_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4b.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex4b.Max(Vertex4b[])")]
		public void Vertex4b_TestMax()
		{
			Vertex4b[] v = new Vertex4b[] {
				new Vertex4b((sbyte)1.0f, (sbyte)13.0f, (sbyte)22.0f),
				new Vertex4b((sbyte)2.0f, (sbyte)12.0f, (sbyte)21.0f),
				new Vertex4b((sbyte)3.0f, (sbyte)11.0f, (sbyte)23.0f),
			};

			Vertex4b max = Vertex4b.Max(v);

			Assert.AreEqual(
				new Vertex4b((sbyte)3.0f, (sbyte)13.0f, (sbyte)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4b.Max(Vertex4b[]) ArgumentNullException")]
		public void Vertex4b_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4b.Max(null));
		}

		[Test(Description = "Test Vertex4b.Max(Vertex4b*)")]
		public void Vertex4b_TestMax_Unsafe()
		{
			Vertex4b[] v = new Vertex4b[] {
				new Vertex4b((sbyte)1.0f, (sbyte)13.0f, (sbyte)22.0f),
				new Vertex4b((sbyte)2.0f, (sbyte)12.0f, (sbyte)21.0f),
				new Vertex4b((sbyte)3.0f, (sbyte)11.0f, (sbyte)23.0f),
			};

			Vertex4b max;

			unsafe {
				fixed (Vertex4b* vPtr = v) {
					max = Vertex4b.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex4b((sbyte)3.0f, (sbyte)13.0f, (sbyte)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4b.Max(Vertex4b*) ArgumentNullException")]
		public void Vertex4b_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4b.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex4b.Max(Vertex4b[])")]
		public void Vertex4b_TestMinMax()
		{
			Vertex4b[] v = new Vertex4b[] {
				new Vertex4b((sbyte)1.0f, (sbyte)13.0f, (sbyte)22.0f),
				new Vertex4b((sbyte)2.0f, (sbyte)12.0f, (sbyte)21.0f),
				new Vertex4b((sbyte)3.0f, (sbyte)11.0f, (sbyte)23.0f),
			};

			Vertex4b min, max;

			Vertex4b.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex4b((sbyte)1.0f, (sbyte)11.0f, (sbyte)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex4b((sbyte)3.0f, (sbyte)13.0f, (sbyte)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4b.Max(Vertex4b[]) ArgumentNullException")]
		public void Vertex4b_TestMinMax_ArgumentNullException()
		{
			Vertex4b min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex4b.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex4b.MinMax(Vertex4b*)")]
		public void Vertex4b_TestMinMax_Unsafe()
		{
			Vertex4b[] v = new Vertex4b[] {
				new Vertex4b((sbyte)1.0f, (sbyte)13.0f, (sbyte)22.0f),
				new Vertex4b((sbyte)2.0f, (sbyte)12.0f, (sbyte)21.0f),
				new Vertex4b((sbyte)3.0f, (sbyte)11.0f, (sbyte)23.0f),
			};

			Vertex4b min, max;

			unsafe {
				fixed (Vertex4b* vPtr = v) {
					Vertex4b.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex4b((sbyte)1.0f, (sbyte)11.0f, (sbyte)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex4b((sbyte)3.0f, (sbyte)13.0f, (sbyte)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4b.MinMax(Vertex4b*) ArgumentNullException")]
		public void Vertex4b_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex4b min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4b.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex4b.Equals(Vertex4b)")]
		public void Vertex4b_TestEquals_Vertex4b()
		{
			Vertex4b v = Vertex4b.UnitX;

			Assert.IsTrue(v.Equals(Vertex4b.UnitX));
			Assert.IsFalse(v.Equals(Vertex4b.UnitY));
			Assert.IsFalse(v.Equals(Vertex4b.UnitZ));

			// Defined vs Undefined equality
			Vertex4b v1 = new Vertex4b(1, 1, 1, 1);
			Vertex4b v2 = new Vertex4b(1, 1, 1, 0);

			Assert.IsFalse(v1.Equals(v2));
			Assert.IsFalse(v2.Equals(v1));

			// Undefined vs Undefined equality
			v1 = new Vertex4b(1, 1, 1, 0);
			v2 = new Vertex4b(1, 1, 1, 0);

			Assert.IsTrue(v1.Equals(v2));
			Assert.IsTrue(v2.Equals(v1));

			// Normalized equality
			v1 = new Vertex4b(1);
			v2 = new Vertex4b((sbyte)(1 + 1));

			Assert.IsTrue(v1.Equals(v2));
			Assert.IsTrue(v2.Equals(v1));
		}

		[Test(Description = "Test Vertex4b.Equals(object)")]
		public void Vertex4b_TestEquals_Object()
		{
			Vertex4b v = Vertex4b.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex4b.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex4b.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex4b.UnitZ));
		}

		[Test(Description = "Test Vertex4b.GetHashCode()")]
		public void Vertex4b_TestGetHashCode()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random);
			sbyte y = (sbyte)Next(random);
			sbyte z = (sbyte)Next(random);

			Vertex4b v = new Vertex4b(x, y, z);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex4b.ToString()")]
		public void Vertex4b_TestToString()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random);
			sbyte y = (sbyte)Next(random);
			sbyte z = (sbyte)Next(random);

			Vertex4b v = new Vertex4b(x, y, z);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex4usTest : Vertex3TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex4us(ushort)")]
		public void Vertex4us_TestConstructor1()
		{
			Random random = new Random();
			ushort randomValue = (ushort)Next(random);
			
			Vertex4us v = new Vertex4us(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex4us(ushort[])")]
		public void Vertex4us_TestConstructor2()
		{
			Random random = new Random();
			ushort randomValueX = (ushort)Next(random);
			ushort randomValueY = (ushort)Next(random);
			ushort randomValueZ = (ushort)Next(random);
			ushort randomValueW = (ushort)Next(random);
			Vertex4us v;

			v = new Vertex4us(new ushort[] {
				randomValueX, randomValueY, randomValueZ
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);

			v = new Vertex4us(new ushort[] {
				randomValueX, randomValueY, randomValueZ, randomValueW
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
			Assert.AreEqual(randomValueW, v.w);
		}

		[Test(Description = "Test Vertex4us(ushort, ushort, ushort)")]
		public void Vertex4us_TestConstructor3()
		{
			Random random = new Random();
			ushort randomValueX = (ushort)Next(random);
			ushort randomValueY = (ushort)Next(random);
			ushort randomValueZ = (ushort)Next(random);

			Vertex4us v = new Vertex4us(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex4us.Size against Marshal.SizeOf")]
		public void Vertex4us_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex4us)), Vertex4us.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex4us.operator+(Vertex4us, Vertex4us)")]
		public void Vertex4us_TestOperatorAdd()
		{
			Random random = new Random();
			
			ushort x1 = (ushort)Next(random);
			ushort y1 = (ushort)Next(random);
			ushort z1 = (ushort)Next(random);

			Vertex4us v1 = new Vertex4us(x1, y1, z1);

			ushort x2 = (ushort)Next(random);
			ushort y2 = (ushort)Next(random);
			ushort z2 = (ushort)Next(random);

			Vertex4us v2 = new Vertex4us(x2, y2, z2);

			Vertex4us v = v1 + v2;

			Assert.AreEqual((ushort)(x1 + x2), v.x);
			Assert.AreEqual((ushort)(y1 + y2), v.y);
			Assert.AreEqual((ushort)(z1 + z2), v.z);
		}

		[Test(Description = "Test Vertex4us.operator-(Vertex4us, Vertex4us)")]
		public void Vertex4us_TestOperatorSub()
		{
			Random random = new Random();
			
			ushort x1 = (ushort)Next(random);
			ushort y1 = (ushort)Next(random);
			ushort z1 = (ushort)Next(random);

			Vertex4us v1 = new Vertex4us(x1, y1, z1);

			ushort x2 = (ushort)Next(random);
			ushort y2 = (ushort)Next(random);
			ushort z2 = (ushort)Next(random);

			Vertex4us v2 = new Vertex4us(x2, y2, z2);

			Vertex4us v = v1 - v2;

			Assert.AreEqual((ushort)(x1 - x2), v.x);
			Assert.AreEqual((ushort)(y1 - y2), v.y);
			Assert.AreEqual((ushort)(z1 - z2), v.z);
		}

		[Test(Description = "Test Vertex4us.operator*(Vertex4us, Single)")]
		public void Vertex4us_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			ushort x1 = (ushort)Next(random);
			ushort y1 = (ushort)Next(random);
			ushort z1 = (ushort)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex4us v1 = new Vertex4us(x1, y1, z1);

			Vertex4us v = v1 * (float)s;

			Assert.AreEqual((ushort)(x1 * (float)s), v.x);
			Assert.AreEqual((ushort)(y1 * (float)s), v.y);
			Assert.AreEqual((ushort)(z1 * (float)s), v.z);
		}

		[Test(Description = "Test Vertex4us.operator/(Vertex4us, Single)")]
		public void Vertex4us_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			ushort x1 = (ushort)Next(random);
			ushort y1 = (ushort)Next(random);
			ushort z1 = (ushort)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex4us v1 = new Vertex4us(x1, y1, z1);

			Vertex4us v = v1 / (float)s;

			Assert.AreEqual((ushort)(x1 / (float)s), v.x);
			Assert.AreEqual((ushort)(y1 / (float)s), v.y);
			Assert.AreEqual((ushort)(z1 / (float)s), v.z);
		}

		[Test(Description = "Test Vertex4us.operator*(Vertex4us, ushort)")]
		public void Vertex4us_TestOperatorScalarMultiply()
		{
			Random random = new Random();
			
			ushort x1 = (ushort)Next(random);
			ushort y1 = (ushort)Next(random);
			ushort z1 = (ushort)Next(random);
			ushort s = (ushort)Next(random, 0.0, 32.0);

			Vertex4us v1 = new Vertex4us(x1, y1, z1);

			Vertex4us v = v1 * s;

			Assert.AreEqual((ushort)(x1 * s), v.x);
			Assert.AreEqual((ushort)(y1 * s), v.y);
			Assert.AreEqual((ushort)(z1 * s), v.z);
		}

		[Test(Description = "Test Vertex4us.operator/(Vertex4us, ushort)")]
		public void Vertex4us_TestOperatorScalarDivide()
		{
			Random random = new Random();
			
			ushort x1 = (ushort)Next(random);
			ushort y1 = (ushort)Next(random);
			ushort z1 = (ushort)Next(random);
			ushort s = (ushort)Next(random, 1.0, 32.0);

			Vertex4us v1 = new Vertex4us(x1, y1, z1);

			Vertex4us v = v1 / s;

			Assert.AreEqual((ushort)(x1 / s), v.x);
			Assert.AreEqual((ushort)(y1 / s), v.y);
			Assert.AreEqual((ushort)(z1 / s), v.z);
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex4us.operator==(Vertex4us, Vertex4us)")]
		public void Vertex4us_TestOperatorEquality()
		{
			Vertex4us v = Vertex4us.UnitX;

			Assert.IsTrue(v == Vertex4us.UnitX);
			Assert.IsFalse(v == Vertex4us.UnitY);
		}

		[Test(Description = "Test Vertex4us.operator!=(Vertex4us, Vertex4us)")]
		public void Vertex4us_TestOperatorInequality()
		{
			Vertex4us v = Vertex4us.UnitX;

			Assert.IsFalse(v != Vertex4us.UnitX);
			Assert.IsTrue(v != Vertex4us.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex4us.operator ushort[](Vertex4us)")]
		public void Vertex4us_TestCastToArray()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random);
			ushort y = (ushort)Next(random);
			ushort z = (ushort)Next(random);

			Vertex4us v = new Vertex4us(x, y, z);
			ushort[] vArray = (ushort[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex4us.operator Vertex2f(Vertex4us)")]
		public void Vertex4us_TestCastToVertex2f()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random);
			ushort y = (ushort)Next(random);
			ushort z = (ushort)Next(random);

			Vertex4us v = new Vertex4us(x, y, z);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.x, (float)v2f.x, 1e-4f);
			Assert.AreEqual(v.y, (float)v2f.y, 1e-4f);
		}

		[Test(Description = "Test Vertex4us.operator Vertex3f(Vertex4us)")]
		public void Vertex4us_TestCastToVertex3f()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random);
			ushort y = (ushort)Next(random);
			ushort z = (ushort)Next(random);

			Vertex4us v = new Vertex4us(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.x, v3f.x, 1e-4f);
			Assert.AreEqual(v.y, v3f.y, 1e-4f);
			Assert.AreEqual(v.z, v3f.z, 1e-4f);
		}

		[Test(Description = "Test Vertex4us.operator Vertex3d(Vertex4us)")]
		public void Vertex4us_TestCastToVertex3d()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random);
			ushort y = (ushort)Next(random);
			ushort z = (ushort)Next(random);

			Vertex4us v = new Vertex4us(x, y, z);
			Vertex3d v3d = (Vertex3d)v;

			Assert.AreEqual(v.x, v3d.x, 1e-4);
			Assert.AreEqual(v.y, v3d.y, 1e-4);
			Assert.AreEqual(v.z, v3d.z, 1e-4);
		}

		[Test(Description = "Test Vertex4us.operator Vertex4f(Vertex4us)")]
		public void Vertex4us_TestCastToVertex4f()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random);
			ushort y = (ushort)Next(random);
			ushort z = (ushort)Next(random);

			Vertex4us v = new Vertex4us(x, y, z);
			Vertex4f v4f = (Vertex4f)v;

			Assert.AreEqual(v.x, v4f.x, 1e-4);
			Assert.AreEqual(v.y, v4f.y, 1e-4);
			Assert.AreEqual(v.z, v4f.z, 1e-4);
			Assert.AreEqual(1.0f, v4f.w, 1e-4);
		}

		[Test(Description = "Test Vertex4us.operator Vertex4d(Vertex4us)")]
		public void Vertex4us_TestCastToVertex4d()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random);
			ushort y = (ushort)Next(random);
			ushort z = (ushort)Next(random);

			Vertex4us v = new Vertex4us(x, y, z);
			Vertex4d v4d = (Vertex4d)v;

			Assert.AreEqual(v.x, v4d.x, 1e-4);
			Assert.AreEqual(v.y, v4d.y, 1e-4);
			Assert.AreEqual(v.z, v4d.z, 1e-4);
			Assert.AreEqual(1.0f, v4d.w, 1e-4);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex4us.Module()")]
		public void Vertex4us_TestModule()
		{
			Assert.AreEqual(3.741657f, new Vertex4us((ushort)1.0, (ushort)2.0, (ushort)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex4us((ushort)2.0, (ushort)5.0, (ushort)7.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex4us.ModuleSquared()")]
		public void Vertex4us_TestModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex4us((ushort)1.0, (ushort)2.0, (ushort)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex4us((ushort)2.0, (ushort)5.0, (ushort)7.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex4us.Normalize()")]
		public void Vertex4us_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex4us.Zero.Normalize(); });

			Vertex4us v;

			v = Vertex4us.UnitX * (ushort)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4us.UnitX, v);

			v = Vertex4us.UnitY * (ushort)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4us.UnitY, v);

			v = Vertex4us.UnitZ * (ushort)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4us.UnitZ, v);
		}

		[Test(Description = "Test Vertex4us.Normalized")]
		public void Vertex4us_TestNormalized()
		{
			Vertex4us v;

			Assert.DoesNotThrow(delegate() { v = Vertex4us.Zero.Normalized; });

			v = Vertex4us.UnitX * (ushort)2.0f;
			Assert.AreEqual(Vertex4us.UnitX, v.Normalized);

			v = Vertex4us.UnitY * (ushort)2.0f;
			Assert.AreEqual(Vertex4us.UnitY, v.Normalized);

			v = Vertex4us.UnitZ * (ushort)2.0f;
			Assert.AreEqual(Vertex4us.UnitZ, v.Normalized);
		}

		[Test(Description = "Test Vertex4us.Min(Vertex4us[])")]
		public void Vertex4us_TestMin()
		{
			Vertex4us[] v = new Vertex4us[] {
				new Vertex4us((ushort)1.0f, (ushort)13.0f, (ushort)22.0f),
				new Vertex4us((ushort)2.0f, (ushort)12.0f, (ushort)21.0f),
				new Vertex4us((ushort)3.0f, (ushort)11.0f, (ushort)23.0f),
			};

			Vertex4us min = Vertex4us.Min(v);

			Assert.AreEqual(
				new Vertex4us((ushort)1.0f, (ushort)11.0f, (ushort)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex4us.Min(Vertex4us[]) ArgumentNullException")]
		public void Vertex4us_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4us.Min(null));
		}

		[Test(Description = "Test Vertex4us.Min(Vertex4us*)")]
		public void Vertex4us_TestMin_Unsafe()
		{
			Vertex4us[] v = new Vertex4us[] {
				new Vertex4us((ushort)1.0f, (ushort)13.0f, (ushort)22.0f),
				new Vertex4us((ushort)2.0f, (ushort)12.0f, (ushort)21.0f),
				new Vertex4us((ushort)3.0f, (ushort)11.0f, (ushort)23.0f),
			};

			Vertex4us min;

			unsafe {
				fixed (Vertex4us* vPtr = v) {
					min = Vertex4us.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex4us((ushort)1.0f, (ushort)11.0f, (ushort)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex4us.Min(Vertex4us*) ArgumentNullException")]
		public void Vertex4us_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4us.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex4us.Max(Vertex4us[])")]
		public void Vertex4us_TestMax()
		{
			Vertex4us[] v = new Vertex4us[] {
				new Vertex4us((ushort)1.0f, (ushort)13.0f, (ushort)22.0f),
				new Vertex4us((ushort)2.0f, (ushort)12.0f, (ushort)21.0f),
				new Vertex4us((ushort)3.0f, (ushort)11.0f, (ushort)23.0f),
			};

			Vertex4us max = Vertex4us.Max(v);

			Assert.AreEqual(
				new Vertex4us((ushort)3.0f, (ushort)13.0f, (ushort)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4us.Max(Vertex4us[]) ArgumentNullException")]
		public void Vertex4us_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4us.Max(null));
		}

		[Test(Description = "Test Vertex4us.Max(Vertex4us*)")]
		public void Vertex4us_TestMax_Unsafe()
		{
			Vertex4us[] v = new Vertex4us[] {
				new Vertex4us((ushort)1.0f, (ushort)13.0f, (ushort)22.0f),
				new Vertex4us((ushort)2.0f, (ushort)12.0f, (ushort)21.0f),
				new Vertex4us((ushort)3.0f, (ushort)11.0f, (ushort)23.0f),
			};

			Vertex4us max;

			unsafe {
				fixed (Vertex4us* vPtr = v) {
					max = Vertex4us.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex4us((ushort)3.0f, (ushort)13.0f, (ushort)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4us.Max(Vertex4us*) ArgumentNullException")]
		public void Vertex4us_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4us.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex4us.Max(Vertex4us[])")]
		public void Vertex4us_TestMinMax()
		{
			Vertex4us[] v = new Vertex4us[] {
				new Vertex4us((ushort)1.0f, (ushort)13.0f, (ushort)22.0f),
				new Vertex4us((ushort)2.0f, (ushort)12.0f, (ushort)21.0f),
				new Vertex4us((ushort)3.0f, (ushort)11.0f, (ushort)23.0f),
			};

			Vertex4us min, max;

			Vertex4us.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex4us((ushort)1.0f, (ushort)11.0f, (ushort)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex4us((ushort)3.0f, (ushort)13.0f, (ushort)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4us.Max(Vertex4us[]) ArgumentNullException")]
		public void Vertex4us_TestMinMax_ArgumentNullException()
		{
			Vertex4us min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex4us.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex4us.MinMax(Vertex4us*)")]
		public void Vertex4us_TestMinMax_Unsafe()
		{
			Vertex4us[] v = new Vertex4us[] {
				new Vertex4us((ushort)1.0f, (ushort)13.0f, (ushort)22.0f),
				new Vertex4us((ushort)2.0f, (ushort)12.0f, (ushort)21.0f),
				new Vertex4us((ushort)3.0f, (ushort)11.0f, (ushort)23.0f),
			};

			Vertex4us min, max;

			unsafe {
				fixed (Vertex4us* vPtr = v) {
					Vertex4us.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex4us((ushort)1.0f, (ushort)11.0f, (ushort)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex4us((ushort)3.0f, (ushort)13.0f, (ushort)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4us.MinMax(Vertex4us*) ArgumentNullException")]
		public void Vertex4us_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex4us min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4us.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex4us.Equals(Vertex4us)")]
		public void Vertex4us_TestEquals_Vertex4us()
		{
			Vertex4us v = Vertex4us.UnitX;

			Assert.IsTrue(v.Equals(Vertex4us.UnitX));
			Assert.IsFalse(v.Equals(Vertex4us.UnitY));
			Assert.IsFalse(v.Equals(Vertex4us.UnitZ));

			// Defined vs Undefined equality
			Vertex4us v1 = new Vertex4us(1, 1, 1, 1);
			Vertex4us v2 = new Vertex4us(1, 1, 1, 0);

			Assert.IsFalse(v1.Equals(v2));
			Assert.IsFalse(v2.Equals(v1));

			// Undefined vs Undefined equality
			v1 = new Vertex4us(1, 1, 1, 0);
			v2 = new Vertex4us(1, 1, 1, 0);

			Assert.IsTrue(v1.Equals(v2));
			Assert.IsTrue(v2.Equals(v1));

			// Normalized equality
			v1 = new Vertex4us(1);
			v2 = new Vertex4us((ushort)(1 + 1));

			Assert.IsTrue(v1.Equals(v2));
			Assert.IsTrue(v2.Equals(v1));
		}

		[Test(Description = "Test Vertex4us.Equals(object)")]
		public void Vertex4us_TestEquals_Object()
		{
			Vertex4us v = Vertex4us.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex4us.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex4us.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex4us.UnitZ));
		}

		[Test(Description = "Test Vertex4us.GetHashCode()")]
		public void Vertex4us_TestGetHashCode()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random);
			ushort y = (ushort)Next(random);
			ushort z = (ushort)Next(random);

			Vertex4us v = new Vertex4us(x, y, z);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex4us.ToString()")]
		public void Vertex4us_TestToString()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random);
			ushort y = (ushort)Next(random);
			ushort z = (ushort)Next(random);

			Vertex4us v = new Vertex4us(x, y, z);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex4sTest : Vertex3TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex4s(short)")]
		public void Vertex4s_TestConstructor1()
		{
			Random random = new Random();
			short randomValue = (short)Next(random);
			
			Vertex4s v = new Vertex4s(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex4s(short[])")]
		public void Vertex4s_TestConstructor2()
		{
			Random random = new Random();
			short randomValueX = (short)Next(random);
			short randomValueY = (short)Next(random);
			short randomValueZ = (short)Next(random);
			short randomValueW = (short)Next(random);
			Vertex4s v;

			v = new Vertex4s(new short[] {
				randomValueX, randomValueY, randomValueZ
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);

			v = new Vertex4s(new short[] {
				randomValueX, randomValueY, randomValueZ, randomValueW
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
			Assert.AreEqual(randomValueW, v.w);
		}

		[Test(Description = "Test Vertex4s(short, short, short)")]
		public void Vertex4s_TestConstructor3()
		{
			Random random = new Random();
			short randomValueX = (short)Next(random);
			short randomValueY = (short)Next(random);
			short randomValueZ = (short)Next(random);

			Vertex4s v = new Vertex4s(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex4s.Size against Marshal.SizeOf")]
		public void Vertex4s_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex4s)), Vertex4s.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex4s.operator-(Vertex4s))")]
		public void Vertex4s_TestOperatorNegate()
		{
			Random random = new Random();
			
			short x = (short)Next(random);
			short y = (short)Next(random);
			short z = (short)Next(random);

			Vertex4s v = new Vertex4s(x, y, z);
			Vertex4s n = -v;

			Assert.AreEqual(-x, n.x);
			Assert.AreEqual(-y, n.y);
			Assert.AreEqual(-z, n.z);
		}
		[Test(Description = "Test Vertex4s.operator+(Vertex4s, Vertex4s)")]
		public void Vertex4s_TestOperatorAdd()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random);
			short y1 = (short)Next(random);
			short z1 = (short)Next(random);

			Vertex4s v1 = new Vertex4s(x1, y1, z1);

			short x2 = (short)Next(random);
			short y2 = (short)Next(random);
			short z2 = (short)Next(random);

			Vertex4s v2 = new Vertex4s(x2, y2, z2);

			Vertex4s v = v1 + v2;

			Assert.AreEqual((short)(x1 + x2), v.x);
			Assert.AreEqual((short)(y1 + y2), v.y);
			Assert.AreEqual((short)(z1 + z2), v.z);
		}

		[Test(Description = "Test Vertex4s.operator-(Vertex4s, Vertex4s)")]
		public void Vertex4s_TestOperatorSub()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random);
			short y1 = (short)Next(random);
			short z1 = (short)Next(random);

			Vertex4s v1 = new Vertex4s(x1, y1, z1);

			short x2 = (short)Next(random);
			short y2 = (short)Next(random);
			short z2 = (short)Next(random);

			Vertex4s v2 = new Vertex4s(x2, y2, z2);

			Vertex4s v = v1 - v2;

			Assert.AreEqual((short)(x1 - x2), v.x);
			Assert.AreEqual((short)(y1 - y2), v.y);
			Assert.AreEqual((short)(z1 - z2), v.z);
		}

		[Test(Description = "Test Vertex4s.operator*(Vertex4s, Single)")]
		public void Vertex4s_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random);
			short y1 = (short)Next(random);
			short z1 = (short)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex4s v1 = new Vertex4s(x1, y1, z1);

			Vertex4s v = v1 * (float)s;

			Assert.AreEqual((short)(x1 * (float)s), v.x);
			Assert.AreEqual((short)(y1 * (float)s), v.y);
			Assert.AreEqual((short)(z1 * (float)s), v.z);
		}

		[Test(Description = "Test Vertex4s.operator/(Vertex4s, Single)")]
		public void Vertex4s_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random);
			short y1 = (short)Next(random);
			short z1 = (short)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex4s v1 = new Vertex4s(x1, y1, z1);

			Vertex4s v = v1 / (float)s;

			Assert.AreEqual((short)(x1 / (float)s), v.x);
			Assert.AreEqual((short)(y1 / (float)s), v.y);
			Assert.AreEqual((short)(z1 / (float)s), v.z);
		}

		[Test(Description = "Test Vertex4s.operator*(Vertex4s, short)")]
		public void Vertex4s_TestOperatorScalarMultiply()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random);
			short y1 = (short)Next(random);
			short z1 = (short)Next(random);
			short s = (short)Next(random, 0.0, 32.0);

			Vertex4s v1 = new Vertex4s(x1, y1, z1);

			Vertex4s v = v1 * s;

			Assert.AreEqual((short)(x1 * s), v.x);
			Assert.AreEqual((short)(y1 * s), v.y);
			Assert.AreEqual((short)(z1 * s), v.z);
		}

		[Test(Description = "Test Vertex4s.operator/(Vertex4s, short)")]
		public void Vertex4s_TestOperatorScalarDivide()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random);
			short y1 = (short)Next(random);
			short z1 = (short)Next(random);
			short s = (short)Next(random, 1.0, 32.0);

			Vertex4s v1 = new Vertex4s(x1, y1, z1);

			Vertex4s v = v1 / s;

			Assert.AreEqual((short)(x1 / s), v.x);
			Assert.AreEqual((short)(y1 / s), v.y);
			Assert.AreEqual((short)(z1 / s), v.z);
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex4s.operator==(Vertex4s, Vertex4s)")]
		public void Vertex4s_TestOperatorEquality()
		{
			Vertex4s v = Vertex4s.UnitX;

			Assert.IsTrue(v == Vertex4s.UnitX);
			Assert.IsFalse(v == Vertex4s.UnitY);
		}

		[Test(Description = "Test Vertex4s.operator!=(Vertex4s, Vertex4s)")]
		public void Vertex4s_TestOperatorInequality()
		{
			Vertex4s v = Vertex4s.UnitX;

			Assert.IsFalse(v != Vertex4s.UnitX);
			Assert.IsTrue(v != Vertex4s.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex4s.operator short[](Vertex4s)")]
		public void Vertex4s_TestCastToArray()
		{
			Random random = new Random();
			
			short x = (short)Next(random);
			short y = (short)Next(random);
			short z = (short)Next(random);

			Vertex4s v = new Vertex4s(x, y, z);
			short[] vArray = (short[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex4s.operator Vertex2f(Vertex4s)")]
		public void Vertex4s_TestCastToVertex2f()
		{
			Random random = new Random();
			
			short x = (short)Next(random);
			short y = (short)Next(random);
			short z = (short)Next(random);

			Vertex4s v = new Vertex4s(x, y, z);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.x, (float)v2f.x, 1e-4f);
			Assert.AreEqual(v.y, (float)v2f.y, 1e-4f);
		}

		[Test(Description = "Test Vertex4s.operator Vertex3f(Vertex4s)")]
		public void Vertex4s_TestCastToVertex3f()
		{
			Random random = new Random();
			
			short x = (short)Next(random);
			short y = (short)Next(random);
			short z = (short)Next(random);

			Vertex4s v = new Vertex4s(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.x, v3f.x, 1e-4f);
			Assert.AreEqual(v.y, v3f.y, 1e-4f);
			Assert.AreEqual(v.z, v3f.z, 1e-4f);
		}

		[Test(Description = "Test Vertex4s.operator Vertex3d(Vertex4s)")]
		public void Vertex4s_TestCastToVertex3d()
		{
			Random random = new Random();
			
			short x = (short)Next(random);
			short y = (short)Next(random);
			short z = (short)Next(random);

			Vertex4s v = new Vertex4s(x, y, z);
			Vertex3d v3d = (Vertex3d)v;

			Assert.AreEqual(v.x, v3d.x, 1e-4);
			Assert.AreEqual(v.y, v3d.y, 1e-4);
			Assert.AreEqual(v.z, v3d.z, 1e-4);
		}

		[Test(Description = "Test Vertex4s.operator Vertex4f(Vertex4s)")]
		public void Vertex4s_TestCastToVertex4f()
		{
			Random random = new Random();
			
			short x = (short)Next(random);
			short y = (short)Next(random);
			short z = (short)Next(random);

			Vertex4s v = new Vertex4s(x, y, z);
			Vertex4f v4f = (Vertex4f)v;

			Assert.AreEqual(v.x, v4f.x, 1e-4);
			Assert.AreEqual(v.y, v4f.y, 1e-4);
			Assert.AreEqual(v.z, v4f.z, 1e-4);
			Assert.AreEqual(1.0f, v4f.w, 1e-4);
		}

		[Test(Description = "Test Vertex4s.operator Vertex4d(Vertex4s)")]
		public void Vertex4s_TestCastToVertex4d()
		{
			Random random = new Random();
			
			short x = (short)Next(random);
			short y = (short)Next(random);
			short z = (short)Next(random);

			Vertex4s v = new Vertex4s(x, y, z);
			Vertex4d v4d = (Vertex4d)v;

			Assert.AreEqual(v.x, v4d.x, 1e-4);
			Assert.AreEqual(v.y, v4d.y, 1e-4);
			Assert.AreEqual(v.z, v4d.z, 1e-4);
			Assert.AreEqual(1.0f, v4d.w, 1e-4);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex4s.Module()")]
		public void Vertex4s_TestModule()
		{
			Assert.AreEqual(3.741657f, new Vertex4s((short)1.0, (short)2.0, (short)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex4s((short)2.0, (short)5.0, (short)7.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex4s.ModuleSquared()")]
		public void Vertex4s_TestModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex4s((short)1.0, (short)2.0, (short)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex4s((short)2.0, (short)5.0, (short)7.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex4s.Normalize()")]
		public void Vertex4s_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex4s.Zero.Normalize(); });

			Vertex4s v;

			v = Vertex4s.UnitX * (short)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4s.UnitX, v);

			v = Vertex4s.UnitY * (short)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4s.UnitY, v);

			v = Vertex4s.UnitZ * (short)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4s.UnitZ, v);
		}

		[Test(Description = "Test Vertex4s.Normalized")]
		public void Vertex4s_TestNormalized()
		{
			Vertex4s v;

			Assert.DoesNotThrow(delegate() { v = Vertex4s.Zero.Normalized; });

			v = Vertex4s.UnitX * (short)2.0f;
			Assert.AreEqual(Vertex4s.UnitX, v.Normalized);

			v = Vertex4s.UnitY * (short)2.0f;
			Assert.AreEqual(Vertex4s.UnitY, v.Normalized);

			v = Vertex4s.UnitZ * (short)2.0f;
			Assert.AreEqual(Vertex4s.UnitZ, v.Normalized);
		}

		[Test(Description = "Test Vertex4s.Min(Vertex4s[])")]
		public void Vertex4s_TestMin()
		{
			Vertex4s[] v = new Vertex4s[] {
				new Vertex4s((short)1.0f, (short)13.0f, (short)22.0f),
				new Vertex4s((short)2.0f, (short)12.0f, (short)21.0f),
				new Vertex4s((short)3.0f, (short)11.0f, (short)23.0f),
			};

			Vertex4s min = Vertex4s.Min(v);

			Assert.AreEqual(
				new Vertex4s((short)1.0f, (short)11.0f, (short)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex4s.Min(Vertex4s[]) ArgumentNullException")]
		public void Vertex4s_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4s.Min(null));
		}

		[Test(Description = "Test Vertex4s.Min(Vertex4s*)")]
		public void Vertex4s_TestMin_Unsafe()
		{
			Vertex4s[] v = new Vertex4s[] {
				new Vertex4s((short)1.0f, (short)13.0f, (short)22.0f),
				new Vertex4s((short)2.0f, (short)12.0f, (short)21.0f),
				new Vertex4s((short)3.0f, (short)11.0f, (short)23.0f),
			};

			Vertex4s min;

			unsafe {
				fixed (Vertex4s* vPtr = v) {
					min = Vertex4s.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex4s((short)1.0f, (short)11.0f, (short)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex4s.Min(Vertex4s*) ArgumentNullException")]
		public void Vertex4s_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4s.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex4s.Max(Vertex4s[])")]
		public void Vertex4s_TestMax()
		{
			Vertex4s[] v = new Vertex4s[] {
				new Vertex4s((short)1.0f, (short)13.0f, (short)22.0f),
				new Vertex4s((short)2.0f, (short)12.0f, (short)21.0f),
				new Vertex4s((short)3.0f, (short)11.0f, (short)23.0f),
			};

			Vertex4s max = Vertex4s.Max(v);

			Assert.AreEqual(
				new Vertex4s((short)3.0f, (short)13.0f, (short)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4s.Max(Vertex4s[]) ArgumentNullException")]
		public void Vertex4s_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4s.Max(null));
		}

		[Test(Description = "Test Vertex4s.Max(Vertex4s*)")]
		public void Vertex4s_TestMax_Unsafe()
		{
			Vertex4s[] v = new Vertex4s[] {
				new Vertex4s((short)1.0f, (short)13.0f, (short)22.0f),
				new Vertex4s((short)2.0f, (short)12.0f, (short)21.0f),
				new Vertex4s((short)3.0f, (short)11.0f, (short)23.0f),
			};

			Vertex4s max;

			unsafe {
				fixed (Vertex4s* vPtr = v) {
					max = Vertex4s.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex4s((short)3.0f, (short)13.0f, (short)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4s.Max(Vertex4s*) ArgumentNullException")]
		public void Vertex4s_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4s.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex4s.Max(Vertex4s[])")]
		public void Vertex4s_TestMinMax()
		{
			Vertex4s[] v = new Vertex4s[] {
				new Vertex4s((short)1.0f, (short)13.0f, (short)22.0f),
				new Vertex4s((short)2.0f, (short)12.0f, (short)21.0f),
				new Vertex4s((short)3.0f, (short)11.0f, (short)23.0f),
			};

			Vertex4s min, max;

			Vertex4s.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex4s((short)1.0f, (short)11.0f, (short)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex4s((short)3.0f, (short)13.0f, (short)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4s.Max(Vertex4s[]) ArgumentNullException")]
		public void Vertex4s_TestMinMax_ArgumentNullException()
		{
			Vertex4s min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex4s.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex4s.MinMax(Vertex4s*)")]
		public void Vertex4s_TestMinMax_Unsafe()
		{
			Vertex4s[] v = new Vertex4s[] {
				new Vertex4s((short)1.0f, (short)13.0f, (short)22.0f),
				new Vertex4s((short)2.0f, (short)12.0f, (short)21.0f),
				new Vertex4s((short)3.0f, (short)11.0f, (short)23.0f),
			};

			Vertex4s min, max;

			unsafe {
				fixed (Vertex4s* vPtr = v) {
					Vertex4s.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex4s((short)1.0f, (short)11.0f, (short)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex4s((short)3.0f, (short)13.0f, (short)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4s.MinMax(Vertex4s*) ArgumentNullException")]
		public void Vertex4s_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex4s min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4s.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex4s.Equals(Vertex4s)")]
		public void Vertex4s_TestEquals_Vertex4s()
		{
			Vertex4s v = Vertex4s.UnitX;

			Assert.IsTrue(v.Equals(Vertex4s.UnitX));
			Assert.IsFalse(v.Equals(Vertex4s.UnitY));
			Assert.IsFalse(v.Equals(Vertex4s.UnitZ));

			// Defined vs Undefined equality
			Vertex4s v1 = new Vertex4s(1, 1, 1, 1);
			Vertex4s v2 = new Vertex4s(1, 1, 1, 0);

			Assert.IsFalse(v1.Equals(v2));
			Assert.IsFalse(v2.Equals(v1));

			// Undefined vs Undefined equality
			v1 = new Vertex4s(1, 1, 1, 0);
			v2 = new Vertex4s(1, 1, 1, 0);

			Assert.IsTrue(v1.Equals(v2));
			Assert.IsTrue(v2.Equals(v1));

			// Normalized equality
			v1 = new Vertex4s(1);
			v2 = new Vertex4s((short)(1 + 1));

			Assert.IsTrue(v1.Equals(v2));
			Assert.IsTrue(v2.Equals(v1));
		}

		[Test(Description = "Test Vertex4s.Equals(object)")]
		public void Vertex4s_TestEquals_Object()
		{
			Vertex4s v = Vertex4s.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex4s.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex4s.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex4s.UnitZ));
		}

		[Test(Description = "Test Vertex4s.GetHashCode()")]
		public void Vertex4s_TestGetHashCode()
		{
			Random random = new Random();
			
			short x = (short)Next(random);
			short y = (short)Next(random);
			short z = (short)Next(random);

			Vertex4s v = new Vertex4s(x, y, z);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex4s.ToString()")]
		public void Vertex4s_TestToString()
		{
			Random random = new Random();
			
			short x = (short)Next(random);
			short y = (short)Next(random);
			short z = (short)Next(random);

			Vertex4s v = new Vertex4s(x, y, z);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex4uiTest : Vertex3TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex4ui(uint)")]
		public void Vertex4ui_TestConstructor1()
		{
			Random random = new Random();
			uint randomValue = (uint)Next(random);
			
			Vertex4ui v = new Vertex4ui(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex4ui(uint[])")]
		public void Vertex4ui_TestConstructor2()
		{
			Random random = new Random();
			uint randomValueX = (uint)Next(random);
			uint randomValueY = (uint)Next(random);
			uint randomValueZ = (uint)Next(random);
			uint randomValueW = (uint)Next(random);
			Vertex4ui v;

			v = new Vertex4ui(new uint[] {
				randomValueX, randomValueY, randomValueZ
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);

			v = new Vertex4ui(new uint[] {
				randomValueX, randomValueY, randomValueZ, randomValueW
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
			Assert.AreEqual(randomValueW, v.w);
		}

		[Test(Description = "Test Vertex4ui(uint, uint, uint)")]
		public void Vertex4ui_TestConstructor3()
		{
			Random random = new Random();
			uint randomValueX = (uint)Next(random);
			uint randomValueY = (uint)Next(random);
			uint randomValueZ = (uint)Next(random);

			Vertex4ui v = new Vertex4ui(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex4ui.Size against Marshal.SizeOf")]
		public void Vertex4ui_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex4ui)), Vertex4ui.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex4ui.operator+(Vertex4ui, Vertex4ui)")]
		public void Vertex4ui_TestOperatorAdd()
		{
			Random random = new Random();
			
			uint x1 = (uint)Next(random);
			uint y1 = (uint)Next(random);
			uint z1 = (uint)Next(random);

			Vertex4ui v1 = new Vertex4ui(x1, y1, z1);

			uint x2 = (uint)Next(random);
			uint y2 = (uint)Next(random);
			uint z2 = (uint)Next(random);

			Vertex4ui v2 = new Vertex4ui(x2, y2, z2);

			Vertex4ui v = v1 + v2;

			Assert.AreEqual((uint)(x1 + x2), v.x);
			Assert.AreEqual((uint)(y1 + y2), v.y);
			Assert.AreEqual((uint)(z1 + z2), v.z);
		}

		[Test(Description = "Test Vertex4ui.operator-(Vertex4ui, Vertex4ui)")]
		public void Vertex4ui_TestOperatorSub()
		{
			Random random = new Random();
			
			uint x1 = (uint)Next(random);
			uint y1 = (uint)Next(random);
			uint z1 = (uint)Next(random);

			Vertex4ui v1 = new Vertex4ui(x1, y1, z1);

			uint x2 = (uint)Next(random);
			uint y2 = (uint)Next(random);
			uint z2 = (uint)Next(random);

			Vertex4ui v2 = new Vertex4ui(x2, y2, z2);

			Vertex4ui v = v1 - v2;

			Assert.AreEqual((uint)(x1 - x2), v.x);
			Assert.AreEqual((uint)(y1 - y2), v.y);
			Assert.AreEqual((uint)(z1 - z2), v.z);
		}

		[Test(Description = "Test Vertex4ui.operator*(Vertex4ui, Single)")]
		public void Vertex4ui_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			uint x1 = (uint)Next(random);
			uint y1 = (uint)Next(random);
			uint z1 = (uint)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex4ui v1 = new Vertex4ui(x1, y1, z1);

			Vertex4ui v = v1 * (float)s;

			Assert.AreEqual((uint)(x1 * (float)s), v.x);
			Assert.AreEqual((uint)(y1 * (float)s), v.y);
			Assert.AreEqual((uint)(z1 * (float)s), v.z);
		}

		[Test(Description = "Test Vertex4ui.operator/(Vertex4ui, Single)")]
		public void Vertex4ui_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			uint x1 = (uint)Next(random);
			uint y1 = (uint)Next(random);
			uint z1 = (uint)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex4ui v1 = new Vertex4ui(x1, y1, z1);

			Vertex4ui v = v1 / (float)s;

			Assert.AreEqual((uint)(x1 / (float)s), v.x);
			Assert.AreEqual((uint)(y1 / (float)s), v.y);
			Assert.AreEqual((uint)(z1 / (float)s), v.z);
		}

		[Test(Description = "Test Vertex4ui.operator*(Vertex4ui, uint)")]
		public void Vertex4ui_TestOperatorScalarMultiply()
		{
			Random random = new Random();
			
			uint x1 = (uint)Next(random);
			uint y1 = (uint)Next(random);
			uint z1 = (uint)Next(random);
			uint s = (uint)Next(random, 0.0, 32.0);

			Vertex4ui v1 = new Vertex4ui(x1, y1, z1);

			Vertex4ui v = v1 * s;

			Assert.AreEqual((uint)(x1 * s), v.x);
			Assert.AreEqual((uint)(y1 * s), v.y);
			Assert.AreEqual((uint)(z1 * s), v.z);
		}

		[Test(Description = "Test Vertex4ui.operator/(Vertex4ui, uint)")]
		public void Vertex4ui_TestOperatorScalarDivide()
		{
			Random random = new Random();
			
			uint x1 = (uint)Next(random);
			uint y1 = (uint)Next(random);
			uint z1 = (uint)Next(random);
			uint s = (uint)Next(random, 1.0, 32.0);

			Vertex4ui v1 = new Vertex4ui(x1, y1, z1);

			Vertex4ui v = v1 / s;

			Assert.AreEqual((uint)(x1 / s), v.x);
			Assert.AreEqual((uint)(y1 / s), v.y);
			Assert.AreEqual((uint)(z1 / s), v.z);
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex4ui.operator==(Vertex4ui, Vertex4ui)")]
		public void Vertex4ui_TestOperatorEquality()
		{
			Vertex4ui v = Vertex4ui.UnitX;

			Assert.IsTrue(v == Vertex4ui.UnitX);
			Assert.IsFalse(v == Vertex4ui.UnitY);
		}

		[Test(Description = "Test Vertex4ui.operator!=(Vertex4ui, Vertex4ui)")]
		public void Vertex4ui_TestOperatorInequality()
		{
			Vertex4ui v = Vertex4ui.UnitX;

			Assert.IsFalse(v != Vertex4ui.UnitX);
			Assert.IsTrue(v != Vertex4ui.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex4ui.operator uint[](Vertex4ui)")]
		public void Vertex4ui_TestCastToArray()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random);
			uint y = (uint)Next(random);
			uint z = (uint)Next(random);

			Vertex4ui v = new Vertex4ui(x, y, z);
			uint[] vArray = (uint[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex4ui.operator Vertex2f(Vertex4ui)")]
		public void Vertex4ui_TestCastToVertex2f()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random);
			uint y = (uint)Next(random);
			uint z = (uint)Next(random);

			Vertex4ui v = new Vertex4ui(x, y, z);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.x, (float)v2f.x, 1e-4f);
			Assert.AreEqual(v.y, (float)v2f.y, 1e-4f);
		}

		[Test(Description = "Test Vertex4ui.operator Vertex3f(Vertex4ui)")]
		public void Vertex4ui_TestCastToVertex3f()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random);
			uint y = (uint)Next(random);
			uint z = (uint)Next(random);

			Vertex4ui v = new Vertex4ui(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.x, v3f.x, 1e-4f);
			Assert.AreEqual(v.y, v3f.y, 1e-4f);
			Assert.AreEqual(v.z, v3f.z, 1e-4f);
		}

		[Test(Description = "Test Vertex4ui.operator Vertex3d(Vertex4ui)")]
		public void Vertex4ui_TestCastToVertex3d()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random);
			uint y = (uint)Next(random);
			uint z = (uint)Next(random);

			Vertex4ui v = new Vertex4ui(x, y, z);
			Vertex3d v3d = (Vertex3d)v;

			Assert.AreEqual(v.x, v3d.x, 1e-4);
			Assert.AreEqual(v.y, v3d.y, 1e-4);
			Assert.AreEqual(v.z, v3d.z, 1e-4);
		}

		[Test(Description = "Test Vertex4ui.operator Vertex4f(Vertex4ui)")]
		public void Vertex4ui_TestCastToVertex4f()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random);
			uint y = (uint)Next(random);
			uint z = (uint)Next(random);

			Vertex4ui v = new Vertex4ui(x, y, z);
			Vertex4f v4f = (Vertex4f)v;

			Assert.AreEqual(v.x, v4f.x, 1e-4);
			Assert.AreEqual(v.y, v4f.y, 1e-4);
			Assert.AreEqual(v.z, v4f.z, 1e-4);
			Assert.AreEqual(1.0f, v4f.w, 1e-4);
		}

		[Test(Description = "Test Vertex4ui.operator Vertex4d(Vertex4ui)")]
		public void Vertex4ui_TestCastToVertex4d()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random);
			uint y = (uint)Next(random);
			uint z = (uint)Next(random);

			Vertex4ui v = new Vertex4ui(x, y, z);
			Vertex4d v4d = (Vertex4d)v;

			Assert.AreEqual(v.x, v4d.x, 1e-4);
			Assert.AreEqual(v.y, v4d.y, 1e-4);
			Assert.AreEqual(v.z, v4d.z, 1e-4);
			Assert.AreEqual(1.0f, v4d.w, 1e-4);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex4ui.Module()")]
		public void Vertex4ui_TestModule()
		{
			Assert.AreEqual(3.741657f, new Vertex4ui((uint)1.0, (uint)2.0, (uint)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex4ui((uint)2.0, (uint)5.0, (uint)7.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex4ui.ModuleSquared()")]
		public void Vertex4ui_TestModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex4ui((uint)1.0, (uint)2.0, (uint)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex4ui((uint)2.0, (uint)5.0, (uint)7.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex4ui.Normalize()")]
		public void Vertex4ui_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex4ui.Zero.Normalize(); });

			Vertex4ui v;

			v = Vertex4ui.UnitX * (uint)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4ui.UnitX, v);

			v = Vertex4ui.UnitY * (uint)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4ui.UnitY, v);

			v = Vertex4ui.UnitZ * (uint)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4ui.UnitZ, v);
		}

		[Test(Description = "Test Vertex4ui.Normalized")]
		public void Vertex4ui_TestNormalized()
		{
			Vertex4ui v;

			Assert.DoesNotThrow(delegate() { v = Vertex4ui.Zero.Normalized; });

			v = Vertex4ui.UnitX * (uint)2.0f;
			Assert.AreEqual(Vertex4ui.UnitX, v.Normalized);

			v = Vertex4ui.UnitY * (uint)2.0f;
			Assert.AreEqual(Vertex4ui.UnitY, v.Normalized);

			v = Vertex4ui.UnitZ * (uint)2.0f;
			Assert.AreEqual(Vertex4ui.UnitZ, v.Normalized);
		}

		[Test(Description = "Test Vertex4ui.Min(Vertex4ui[])")]
		public void Vertex4ui_TestMin()
		{
			Vertex4ui[] v = new Vertex4ui[] {
				new Vertex4ui((uint)1.0f, (uint)13.0f, (uint)22.0f),
				new Vertex4ui((uint)2.0f, (uint)12.0f, (uint)21.0f),
				new Vertex4ui((uint)3.0f, (uint)11.0f, (uint)23.0f),
			};

			Vertex4ui min = Vertex4ui.Min(v);

			Assert.AreEqual(
				new Vertex4ui((uint)1.0f, (uint)11.0f, (uint)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex4ui.Min(Vertex4ui[]) ArgumentNullException")]
		public void Vertex4ui_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4ui.Min(null));
		}

		[Test(Description = "Test Vertex4ui.Min(Vertex4ui*)")]
		public void Vertex4ui_TestMin_Unsafe()
		{
			Vertex4ui[] v = new Vertex4ui[] {
				new Vertex4ui((uint)1.0f, (uint)13.0f, (uint)22.0f),
				new Vertex4ui((uint)2.0f, (uint)12.0f, (uint)21.0f),
				new Vertex4ui((uint)3.0f, (uint)11.0f, (uint)23.0f),
			};

			Vertex4ui min;

			unsafe {
				fixed (Vertex4ui* vPtr = v) {
					min = Vertex4ui.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex4ui((uint)1.0f, (uint)11.0f, (uint)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex4ui.Min(Vertex4ui*) ArgumentNullException")]
		public void Vertex4ui_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4ui.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex4ui.Max(Vertex4ui[])")]
		public void Vertex4ui_TestMax()
		{
			Vertex4ui[] v = new Vertex4ui[] {
				new Vertex4ui((uint)1.0f, (uint)13.0f, (uint)22.0f),
				new Vertex4ui((uint)2.0f, (uint)12.0f, (uint)21.0f),
				new Vertex4ui((uint)3.0f, (uint)11.0f, (uint)23.0f),
			};

			Vertex4ui max = Vertex4ui.Max(v);

			Assert.AreEqual(
				new Vertex4ui((uint)3.0f, (uint)13.0f, (uint)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4ui.Max(Vertex4ui[]) ArgumentNullException")]
		public void Vertex4ui_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4ui.Max(null));
		}

		[Test(Description = "Test Vertex4ui.Max(Vertex4ui*)")]
		public void Vertex4ui_TestMax_Unsafe()
		{
			Vertex4ui[] v = new Vertex4ui[] {
				new Vertex4ui((uint)1.0f, (uint)13.0f, (uint)22.0f),
				new Vertex4ui((uint)2.0f, (uint)12.0f, (uint)21.0f),
				new Vertex4ui((uint)3.0f, (uint)11.0f, (uint)23.0f),
			};

			Vertex4ui max;

			unsafe {
				fixed (Vertex4ui* vPtr = v) {
					max = Vertex4ui.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex4ui((uint)3.0f, (uint)13.0f, (uint)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4ui.Max(Vertex4ui*) ArgumentNullException")]
		public void Vertex4ui_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4ui.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex4ui.Max(Vertex4ui[])")]
		public void Vertex4ui_TestMinMax()
		{
			Vertex4ui[] v = new Vertex4ui[] {
				new Vertex4ui((uint)1.0f, (uint)13.0f, (uint)22.0f),
				new Vertex4ui((uint)2.0f, (uint)12.0f, (uint)21.0f),
				new Vertex4ui((uint)3.0f, (uint)11.0f, (uint)23.0f),
			};

			Vertex4ui min, max;

			Vertex4ui.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex4ui((uint)1.0f, (uint)11.0f, (uint)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex4ui((uint)3.0f, (uint)13.0f, (uint)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4ui.Max(Vertex4ui[]) ArgumentNullException")]
		public void Vertex4ui_TestMinMax_ArgumentNullException()
		{
			Vertex4ui min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex4ui.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex4ui.MinMax(Vertex4ui*)")]
		public void Vertex4ui_TestMinMax_Unsafe()
		{
			Vertex4ui[] v = new Vertex4ui[] {
				new Vertex4ui((uint)1.0f, (uint)13.0f, (uint)22.0f),
				new Vertex4ui((uint)2.0f, (uint)12.0f, (uint)21.0f),
				new Vertex4ui((uint)3.0f, (uint)11.0f, (uint)23.0f),
			};

			Vertex4ui min, max;

			unsafe {
				fixed (Vertex4ui* vPtr = v) {
					Vertex4ui.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex4ui((uint)1.0f, (uint)11.0f, (uint)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex4ui((uint)3.0f, (uint)13.0f, (uint)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4ui.MinMax(Vertex4ui*) ArgumentNullException")]
		public void Vertex4ui_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex4ui min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4ui.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex4ui.Equals(Vertex4ui)")]
		public void Vertex4ui_TestEquals_Vertex4ui()
		{
			Vertex4ui v = Vertex4ui.UnitX;

			Assert.IsTrue(v.Equals(Vertex4ui.UnitX));
			Assert.IsFalse(v.Equals(Vertex4ui.UnitY));
			Assert.IsFalse(v.Equals(Vertex4ui.UnitZ));

			// Defined vs Undefined equality
			Vertex4ui v1 = new Vertex4ui(1, 1, 1, 1);
			Vertex4ui v2 = new Vertex4ui(1, 1, 1, 0);

			Assert.IsFalse(v1.Equals(v2));
			Assert.IsFalse(v2.Equals(v1));

			// Undefined vs Undefined equality
			v1 = new Vertex4ui(1, 1, 1, 0);
			v2 = new Vertex4ui(1, 1, 1, 0);

			Assert.IsTrue(v1.Equals(v2));
			Assert.IsTrue(v2.Equals(v1));

			// Normalized equality
			v1 = new Vertex4ui(1);
			v2 = new Vertex4ui((uint)(1 + 1));

			Assert.IsTrue(v1.Equals(v2));
			Assert.IsTrue(v2.Equals(v1));
		}

		[Test(Description = "Test Vertex4ui.Equals(object)")]
		public void Vertex4ui_TestEquals_Object()
		{
			Vertex4ui v = Vertex4ui.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex4ui.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex4ui.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex4ui.UnitZ));
		}

		[Test(Description = "Test Vertex4ui.GetHashCode()")]
		public void Vertex4ui_TestGetHashCode()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random);
			uint y = (uint)Next(random);
			uint z = (uint)Next(random);

			Vertex4ui v = new Vertex4ui(x, y, z);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex4ui.ToString()")]
		public void Vertex4ui_TestToString()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random);
			uint y = (uint)Next(random);
			uint z = (uint)Next(random);

			Vertex4ui v = new Vertex4ui(x, y, z);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex4iTest : Vertex3TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex4i(int)")]
		public void Vertex4i_TestConstructor1()
		{
			Random random = new Random();
			int randomValue = (int)Next(random);
			
			Vertex4i v = new Vertex4i(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex4i(int[])")]
		public void Vertex4i_TestConstructor2()
		{
			Random random = new Random();
			int randomValueX = (int)Next(random);
			int randomValueY = (int)Next(random);
			int randomValueZ = (int)Next(random);
			int randomValueW = (int)Next(random);
			Vertex4i v;

			v = new Vertex4i(new int[] {
				randomValueX, randomValueY, randomValueZ
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);

			v = new Vertex4i(new int[] {
				randomValueX, randomValueY, randomValueZ, randomValueW
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
			Assert.AreEqual(randomValueW, v.w);
		}

		[Test(Description = "Test Vertex4i(int, int, int)")]
		public void Vertex4i_TestConstructor3()
		{
			Random random = new Random();
			int randomValueX = (int)Next(random);
			int randomValueY = (int)Next(random);
			int randomValueZ = (int)Next(random);

			Vertex4i v = new Vertex4i(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex4i.Size against Marshal.SizeOf")]
		public void Vertex4i_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex4i)), Vertex4i.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex4i.operator-(Vertex4i))")]
		public void Vertex4i_TestOperatorNegate()
		{
			Random random = new Random();
			
			int x = (int)Next(random);
			int y = (int)Next(random);
			int z = (int)Next(random);

			Vertex4i v = new Vertex4i(x, y, z);
			Vertex4i n = -v;

			Assert.AreEqual(-x, n.x);
			Assert.AreEqual(-y, n.y);
			Assert.AreEqual(-z, n.z);
		}
		[Test(Description = "Test Vertex4i.operator+(Vertex4i, Vertex4i)")]
		public void Vertex4i_TestOperatorAdd()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random);
			int y1 = (int)Next(random);
			int z1 = (int)Next(random);

			Vertex4i v1 = new Vertex4i(x1, y1, z1);

			int x2 = (int)Next(random);
			int y2 = (int)Next(random);
			int z2 = (int)Next(random);

			Vertex4i v2 = new Vertex4i(x2, y2, z2);

			Vertex4i v = v1 + v2;

			Assert.AreEqual((int)(x1 + x2), v.x);
			Assert.AreEqual((int)(y1 + y2), v.y);
			Assert.AreEqual((int)(z1 + z2), v.z);
		}

		[Test(Description = "Test Vertex4i.operator-(Vertex4i, Vertex4i)")]
		public void Vertex4i_TestOperatorSub()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random);
			int y1 = (int)Next(random);
			int z1 = (int)Next(random);

			Vertex4i v1 = new Vertex4i(x1, y1, z1);

			int x2 = (int)Next(random);
			int y2 = (int)Next(random);
			int z2 = (int)Next(random);

			Vertex4i v2 = new Vertex4i(x2, y2, z2);

			Vertex4i v = v1 - v2;

			Assert.AreEqual((int)(x1 - x2), v.x);
			Assert.AreEqual((int)(y1 - y2), v.y);
			Assert.AreEqual((int)(z1 - z2), v.z);
		}

		[Test(Description = "Test Vertex4i.operator*(Vertex4i, Single)")]
		public void Vertex4i_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random);
			int y1 = (int)Next(random);
			int z1 = (int)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex4i v1 = new Vertex4i(x1, y1, z1);

			Vertex4i v = v1 * (float)s;

			Assert.AreEqual((int)(x1 * (float)s), v.x);
			Assert.AreEqual((int)(y1 * (float)s), v.y);
			Assert.AreEqual((int)(z1 * (float)s), v.z);
		}

		[Test(Description = "Test Vertex4i.operator/(Vertex4i, Single)")]
		public void Vertex4i_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random);
			int y1 = (int)Next(random);
			int z1 = (int)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex4i v1 = new Vertex4i(x1, y1, z1);

			Vertex4i v = v1 / (float)s;

			Assert.AreEqual((int)(x1 / (float)s), v.x);
			Assert.AreEqual((int)(y1 / (float)s), v.y);
			Assert.AreEqual((int)(z1 / (float)s), v.z);
		}

		[Test(Description = "Test Vertex4i.operator*(Vertex4i, int)")]
		public void Vertex4i_TestOperatorScalarMultiply()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random);
			int y1 = (int)Next(random);
			int z1 = (int)Next(random);
			int s = (int)Next(random, 0.0, 32.0);

			Vertex4i v1 = new Vertex4i(x1, y1, z1);

			Vertex4i v = v1 * s;

			Assert.AreEqual((int)(x1 * s), v.x);
			Assert.AreEqual((int)(y1 * s), v.y);
			Assert.AreEqual((int)(z1 * s), v.z);
		}

		[Test(Description = "Test Vertex4i.operator/(Vertex4i, int)")]
		public void Vertex4i_TestOperatorScalarDivide()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random);
			int y1 = (int)Next(random);
			int z1 = (int)Next(random);
			int s = (int)Next(random, 1.0, 32.0);

			Vertex4i v1 = new Vertex4i(x1, y1, z1);

			Vertex4i v = v1 / s;

			Assert.AreEqual((int)(x1 / s), v.x);
			Assert.AreEqual((int)(y1 / s), v.y);
			Assert.AreEqual((int)(z1 / s), v.z);
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex4i.operator==(Vertex4i, Vertex4i)")]
		public void Vertex4i_TestOperatorEquality()
		{
			Vertex4i v = Vertex4i.UnitX;

			Assert.IsTrue(v == Vertex4i.UnitX);
			Assert.IsFalse(v == Vertex4i.UnitY);
		}

		[Test(Description = "Test Vertex4i.operator!=(Vertex4i, Vertex4i)")]
		public void Vertex4i_TestOperatorInequality()
		{
			Vertex4i v = Vertex4i.UnitX;

			Assert.IsFalse(v != Vertex4i.UnitX);
			Assert.IsTrue(v != Vertex4i.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex4i.operator int[](Vertex4i)")]
		public void Vertex4i_TestCastToArray()
		{
			Random random = new Random();
			
			int x = (int)Next(random);
			int y = (int)Next(random);
			int z = (int)Next(random);

			Vertex4i v = new Vertex4i(x, y, z);
			int[] vArray = (int[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex4i.operator Vertex2f(Vertex4i)")]
		public void Vertex4i_TestCastToVertex2f()
		{
			Random random = new Random();
			
			int x = (int)Next(random);
			int y = (int)Next(random);
			int z = (int)Next(random);

			Vertex4i v = new Vertex4i(x, y, z);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.x, (float)v2f.x, 1e-4f);
			Assert.AreEqual(v.y, (float)v2f.y, 1e-4f);
		}

		[Test(Description = "Test Vertex4i.operator Vertex3f(Vertex4i)")]
		public void Vertex4i_TestCastToVertex3f()
		{
			Random random = new Random();
			
			int x = (int)Next(random);
			int y = (int)Next(random);
			int z = (int)Next(random);

			Vertex4i v = new Vertex4i(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.x, v3f.x, 1e-4f);
			Assert.AreEqual(v.y, v3f.y, 1e-4f);
			Assert.AreEqual(v.z, v3f.z, 1e-4f);
		}

		[Test(Description = "Test Vertex4i.operator Vertex3d(Vertex4i)")]
		public void Vertex4i_TestCastToVertex3d()
		{
			Random random = new Random();
			
			int x = (int)Next(random);
			int y = (int)Next(random);
			int z = (int)Next(random);

			Vertex4i v = new Vertex4i(x, y, z);
			Vertex3d v3d = (Vertex3d)v;

			Assert.AreEqual(v.x, v3d.x, 1e-4);
			Assert.AreEqual(v.y, v3d.y, 1e-4);
			Assert.AreEqual(v.z, v3d.z, 1e-4);
		}

		[Test(Description = "Test Vertex4i.operator Vertex4f(Vertex4i)")]
		public void Vertex4i_TestCastToVertex4f()
		{
			Random random = new Random();
			
			int x = (int)Next(random);
			int y = (int)Next(random);
			int z = (int)Next(random);

			Vertex4i v = new Vertex4i(x, y, z);
			Vertex4f v4f = (Vertex4f)v;

			Assert.AreEqual(v.x, v4f.x, 1e-4);
			Assert.AreEqual(v.y, v4f.y, 1e-4);
			Assert.AreEqual(v.z, v4f.z, 1e-4);
			Assert.AreEqual(1.0f, v4f.w, 1e-4);
		}

		[Test(Description = "Test Vertex4i.operator Vertex4d(Vertex4i)")]
		public void Vertex4i_TestCastToVertex4d()
		{
			Random random = new Random();
			
			int x = (int)Next(random);
			int y = (int)Next(random);
			int z = (int)Next(random);

			Vertex4i v = new Vertex4i(x, y, z);
			Vertex4d v4d = (Vertex4d)v;

			Assert.AreEqual(v.x, v4d.x, 1e-4);
			Assert.AreEqual(v.y, v4d.y, 1e-4);
			Assert.AreEqual(v.z, v4d.z, 1e-4);
			Assert.AreEqual(1.0f, v4d.w, 1e-4);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex4i.Module()")]
		public void Vertex4i_TestModule()
		{
			Assert.AreEqual(3.741657f, new Vertex4i((int)1.0, (int)2.0, (int)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex4i((int)2.0, (int)5.0, (int)7.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex4i.ModuleSquared()")]
		public void Vertex4i_TestModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex4i((int)1.0, (int)2.0, (int)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex4i((int)2.0, (int)5.0, (int)7.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex4i.Normalize()")]
		public void Vertex4i_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex4i.Zero.Normalize(); });

			Vertex4i v;

			v = Vertex4i.UnitX * (int)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4i.UnitX, v);

			v = Vertex4i.UnitY * (int)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4i.UnitY, v);

			v = Vertex4i.UnitZ * (int)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4i.UnitZ, v);
		}

		[Test(Description = "Test Vertex4i.Normalized")]
		public void Vertex4i_TestNormalized()
		{
			Vertex4i v;

			Assert.DoesNotThrow(delegate() { v = Vertex4i.Zero.Normalized; });

			v = Vertex4i.UnitX * (int)2.0f;
			Assert.AreEqual(Vertex4i.UnitX, v.Normalized);

			v = Vertex4i.UnitY * (int)2.0f;
			Assert.AreEqual(Vertex4i.UnitY, v.Normalized);

			v = Vertex4i.UnitZ * (int)2.0f;
			Assert.AreEqual(Vertex4i.UnitZ, v.Normalized);
		}

		[Test(Description = "Test Vertex4i.Min(Vertex4i[])")]
		public void Vertex4i_TestMin()
		{
			Vertex4i[] v = new Vertex4i[] {
				new Vertex4i((int)1.0f, (int)13.0f, (int)22.0f),
				new Vertex4i((int)2.0f, (int)12.0f, (int)21.0f),
				new Vertex4i((int)3.0f, (int)11.0f, (int)23.0f),
			};

			Vertex4i min = Vertex4i.Min(v);

			Assert.AreEqual(
				new Vertex4i((int)1.0f, (int)11.0f, (int)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex4i.Min(Vertex4i[]) ArgumentNullException")]
		public void Vertex4i_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4i.Min(null));
		}

		[Test(Description = "Test Vertex4i.Min(Vertex4i*)")]
		public void Vertex4i_TestMin_Unsafe()
		{
			Vertex4i[] v = new Vertex4i[] {
				new Vertex4i((int)1.0f, (int)13.0f, (int)22.0f),
				new Vertex4i((int)2.0f, (int)12.0f, (int)21.0f),
				new Vertex4i((int)3.0f, (int)11.0f, (int)23.0f),
			};

			Vertex4i min;

			unsafe {
				fixed (Vertex4i* vPtr = v) {
					min = Vertex4i.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex4i((int)1.0f, (int)11.0f, (int)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex4i.Min(Vertex4i*) ArgumentNullException")]
		public void Vertex4i_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4i.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex4i.Max(Vertex4i[])")]
		public void Vertex4i_TestMax()
		{
			Vertex4i[] v = new Vertex4i[] {
				new Vertex4i((int)1.0f, (int)13.0f, (int)22.0f),
				new Vertex4i((int)2.0f, (int)12.0f, (int)21.0f),
				new Vertex4i((int)3.0f, (int)11.0f, (int)23.0f),
			};

			Vertex4i max = Vertex4i.Max(v);

			Assert.AreEqual(
				new Vertex4i((int)3.0f, (int)13.0f, (int)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4i.Max(Vertex4i[]) ArgumentNullException")]
		public void Vertex4i_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4i.Max(null));
		}

		[Test(Description = "Test Vertex4i.Max(Vertex4i*)")]
		public void Vertex4i_TestMax_Unsafe()
		{
			Vertex4i[] v = new Vertex4i[] {
				new Vertex4i((int)1.0f, (int)13.0f, (int)22.0f),
				new Vertex4i((int)2.0f, (int)12.0f, (int)21.0f),
				new Vertex4i((int)3.0f, (int)11.0f, (int)23.0f),
			};

			Vertex4i max;

			unsafe {
				fixed (Vertex4i* vPtr = v) {
					max = Vertex4i.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex4i((int)3.0f, (int)13.0f, (int)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4i.Max(Vertex4i*) ArgumentNullException")]
		public void Vertex4i_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4i.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex4i.Max(Vertex4i[])")]
		public void Vertex4i_TestMinMax()
		{
			Vertex4i[] v = new Vertex4i[] {
				new Vertex4i((int)1.0f, (int)13.0f, (int)22.0f),
				new Vertex4i((int)2.0f, (int)12.0f, (int)21.0f),
				new Vertex4i((int)3.0f, (int)11.0f, (int)23.0f),
			};

			Vertex4i min, max;

			Vertex4i.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex4i((int)1.0f, (int)11.0f, (int)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex4i((int)3.0f, (int)13.0f, (int)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4i.Max(Vertex4i[]) ArgumentNullException")]
		public void Vertex4i_TestMinMax_ArgumentNullException()
		{
			Vertex4i min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex4i.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex4i.MinMax(Vertex4i*)")]
		public void Vertex4i_TestMinMax_Unsafe()
		{
			Vertex4i[] v = new Vertex4i[] {
				new Vertex4i((int)1.0f, (int)13.0f, (int)22.0f),
				new Vertex4i((int)2.0f, (int)12.0f, (int)21.0f),
				new Vertex4i((int)3.0f, (int)11.0f, (int)23.0f),
			};

			Vertex4i min, max;

			unsafe {
				fixed (Vertex4i* vPtr = v) {
					Vertex4i.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex4i((int)1.0f, (int)11.0f, (int)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex4i((int)3.0f, (int)13.0f, (int)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4i.MinMax(Vertex4i*) ArgumentNullException")]
		public void Vertex4i_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex4i min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4i.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex4i.Equals(Vertex4i)")]
		public void Vertex4i_TestEquals_Vertex4i()
		{
			Vertex4i v = Vertex4i.UnitX;

			Assert.IsTrue(v.Equals(Vertex4i.UnitX));
			Assert.IsFalse(v.Equals(Vertex4i.UnitY));
			Assert.IsFalse(v.Equals(Vertex4i.UnitZ));

			// Defined vs Undefined equality
			Vertex4i v1 = new Vertex4i(1, 1, 1, 1);
			Vertex4i v2 = new Vertex4i(1, 1, 1, 0);

			Assert.IsFalse(v1.Equals(v2));
			Assert.IsFalse(v2.Equals(v1));

			// Undefined vs Undefined equality
			v1 = new Vertex4i(1, 1, 1, 0);
			v2 = new Vertex4i(1, 1, 1, 0);

			Assert.IsTrue(v1.Equals(v2));
			Assert.IsTrue(v2.Equals(v1));

			// Normalized equality
			v1 = new Vertex4i(1);
			v2 = new Vertex4i((int)(1 + 1));

			Assert.IsTrue(v1.Equals(v2));
			Assert.IsTrue(v2.Equals(v1));
		}

		[Test(Description = "Test Vertex4i.Equals(object)")]
		public void Vertex4i_TestEquals_Object()
		{
			Vertex4i v = Vertex4i.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex4i.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex4i.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex4i.UnitZ));
		}

		[Test(Description = "Test Vertex4i.GetHashCode()")]
		public void Vertex4i_TestGetHashCode()
		{
			Random random = new Random();
			
			int x = (int)Next(random);
			int y = (int)Next(random);
			int z = (int)Next(random);

			Vertex4i v = new Vertex4i(x, y, z);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex4i.ToString()")]
		public void Vertex4i_TestToString()
		{
			Random random = new Random();
			
			int x = (int)Next(random);
			int y = (int)Next(random);
			int z = (int)Next(random);

			Vertex4i v = new Vertex4i(x, y, z);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex4fTest : Vertex3TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex4f(float)")]
		public void Vertex4f_TestConstructor1()
		{
			Random random = new Random();
			float randomValue = (float)Next(random);
			
			Vertex4f v = new Vertex4f(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex4f(float[])")]
		public void Vertex4f_TestConstructor2()
		{
			Random random = new Random();
			float randomValueX = (float)Next(random);
			float randomValueY = (float)Next(random);
			float randomValueZ = (float)Next(random);
			float randomValueW = (float)Next(random);
			Vertex4f v;

			v = new Vertex4f(new float[] {
				randomValueX, randomValueY, randomValueZ
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);

			v = new Vertex4f(new float[] {
				randomValueX, randomValueY, randomValueZ, randomValueW
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
			Assert.AreEqual(randomValueW, v.w);
		}

		[Test(Description = "Test Vertex4f(float, float, float)")]
		public void Vertex4f_TestConstructor3()
		{
			Random random = new Random();
			float randomValueX = (float)Next(random);
			float randomValueY = (float)Next(random);
			float randomValueZ = (float)Next(random);

			Vertex4f v = new Vertex4f(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex4f.Size against Marshal.SizeOf")]
		public void Vertex4f_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex4f)), Vertex4f.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex4f.operator-(Vertex4f))")]
		public void Vertex4f_TestOperatorNegate()
		{
			Random random = new Random();
			
			float x = (float)Next(random);
			float y = (float)Next(random);
			float z = (float)Next(random);

			Vertex4f v = new Vertex4f(x, y, z);
			Vertex4f n = -v;

			Assert.AreEqual(-x, n.x);
			Assert.AreEqual(-y, n.y);
			Assert.AreEqual(-z, n.z);
		}
		[Test(Description = "Test Vertex4f.operator+(Vertex4f, Vertex4f)")]
		public void Vertex4f_TestOperatorAdd()
		{
			Random random = new Random();
			
			float x1 = (float)Next(random);
			float y1 = (float)Next(random);
			float z1 = (float)Next(random);

			Vertex4f v1 = new Vertex4f(x1, y1, z1);

			float x2 = (float)Next(random);
			float y2 = (float)Next(random);
			float z2 = (float)Next(random);

			Vertex4f v2 = new Vertex4f(x2, y2, z2);

			Vertex4f v = v1 + v2;

			Assert.AreEqual((float)(x1 + x2), v.x);
			Assert.AreEqual((float)(y1 + y2), v.y);
			Assert.AreEqual((float)(z1 + z2), v.z);
		}

		[Test(Description = "Test Vertex4f.operator-(Vertex4f, Vertex4f)")]
		public void Vertex4f_TestOperatorSub()
		{
			Random random = new Random();
			
			float x1 = (float)Next(random);
			float y1 = (float)Next(random);
			float z1 = (float)Next(random);

			Vertex4f v1 = new Vertex4f(x1, y1, z1);

			float x2 = (float)Next(random);
			float y2 = (float)Next(random);
			float z2 = (float)Next(random);

			Vertex4f v2 = new Vertex4f(x2, y2, z2);

			Vertex4f v = v1 - v2;

			Assert.AreEqual((float)(x1 - x2), v.x);
			Assert.AreEqual((float)(y1 - y2), v.y);
			Assert.AreEqual((float)(z1 - z2), v.z);
		}

		[Test(Description = "Test Vertex4f.operator*(Vertex4f, Single)")]
		public void Vertex4f_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			float x1 = (float)Next(random);
			float y1 = (float)Next(random);
			float z1 = (float)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex4f v1 = new Vertex4f(x1, y1, z1);

			Vertex4f v = v1 * (float)s;

			Assert.AreEqual((float)(x1 * (float)s), v.x);
			Assert.AreEqual((float)(y1 * (float)s), v.y);
			Assert.AreEqual((float)(z1 * (float)s), v.z);
		}

		[Test(Description = "Test Vertex4f.operator/(Vertex4f, Single)")]
		public void Vertex4f_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			float x1 = (float)Next(random);
			float y1 = (float)Next(random);
			float z1 = (float)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex4f v1 = new Vertex4f(x1, y1, z1);

			Vertex4f v = v1 / (float)s;

			Assert.AreEqual((float)(x1 / (float)s), v.x);
			Assert.AreEqual((float)(y1 / (float)s), v.y);
			Assert.AreEqual((float)(z1 / (float)s), v.z);
		}


		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex4f.operator==(Vertex4f, Vertex4f)")]
		public void Vertex4f_TestOperatorEquality()
		{
			Vertex4f v = Vertex4f.UnitX;

			Assert.IsTrue(v == Vertex4f.UnitX);
			Assert.IsFalse(v == Vertex4f.UnitY);
		}

		[Test(Description = "Test Vertex4f.operator!=(Vertex4f, Vertex4f)")]
		public void Vertex4f_TestOperatorInequality()
		{
			Vertex4f v = Vertex4f.UnitX;

			Assert.IsFalse(v != Vertex4f.UnitX);
			Assert.IsTrue(v != Vertex4f.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex4f.operator float[](Vertex4f)")]
		public void Vertex4f_TestCastToArray()
		{
			Random random = new Random();
			
			float x = (float)Next(random);
			float y = (float)Next(random);
			float z = (float)Next(random);

			Vertex4f v = new Vertex4f(x, y, z);
			float[] vArray = (float[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex4f.operator Vertex2f(Vertex4f)")]
		public void Vertex4f_TestCastToVertex2f()
		{
			Random random = new Random();
			
			float x = (float)Next(random);
			float y = (float)Next(random);
			float z = (float)Next(random);

			Vertex4f v = new Vertex4f(x, y, z);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.x, (float)v2f.x, 1e-4f);
			Assert.AreEqual(v.y, (float)v2f.y, 1e-4f);
		}

		[Test(Description = "Test Vertex4f.operator Vertex3f(Vertex4f)")]
		public void Vertex4f_TestCastToVertex3f()
		{
			Random random = new Random();
			
			float x = (float)Next(random);
			float y = (float)Next(random);
			float z = (float)Next(random);

			Vertex4f v = new Vertex4f(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.x, v3f.x, 1e-4f);
			Assert.AreEqual(v.y, v3f.y, 1e-4f);
			Assert.AreEqual(v.z, v3f.z, 1e-4f);
		}

		[Test(Description = "Test Vertex4f.operator Vertex3d(Vertex4f)")]
		public void Vertex4f_TestCastToVertex3d()
		{
			Random random = new Random();
			
			float x = (float)Next(random);
			float y = (float)Next(random);
			float z = (float)Next(random);

			Vertex4f v = new Vertex4f(x, y, z);
			Vertex3d v3d = (Vertex3d)v;

			Assert.AreEqual(v.x, v3d.x, 1e-4);
			Assert.AreEqual(v.y, v3d.y, 1e-4);
			Assert.AreEqual(v.z, v3d.z, 1e-4);
		}

		[Test(Description = "Test Vertex4f.operator Vertex4f(Vertex4f)")]
		public void Vertex4f_TestCastToVertex4f()
		{
			Random random = new Random();
			
			float x = (float)Next(random);
			float y = (float)Next(random);
			float z = (float)Next(random);

			Vertex4f v = new Vertex4f(x, y, z);
			Vertex4f v4f = (Vertex4f)v;

			Assert.AreEqual(v.x, v4f.x, 1e-4);
			Assert.AreEqual(v.y, v4f.y, 1e-4);
			Assert.AreEqual(v.z, v4f.z, 1e-4);
			Assert.AreEqual(1.0f, v4f.w, 1e-4);
		}

		[Test(Description = "Test Vertex4f.operator Vertex4d(Vertex4f)")]
		public void Vertex4f_TestCastToVertex4d()
		{
			Random random = new Random();
			
			float x = (float)Next(random);
			float y = (float)Next(random);
			float z = (float)Next(random);

			Vertex4f v = new Vertex4f(x, y, z);
			Vertex4d v4d = (Vertex4d)v;

			Assert.AreEqual(v.x, v4d.x, 1e-4);
			Assert.AreEqual(v.y, v4d.y, 1e-4);
			Assert.AreEqual(v.z, v4d.z, 1e-4);
			Assert.AreEqual(1.0f, v4d.w, 1e-4);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex4f.Module()")]
		public void Vertex4f_TestModule()
		{
			Assert.AreEqual(3.741657f, new Vertex4f((float)1.0, (float)2.0, (float)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex4f((float)2.0, (float)5.0, (float)7.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex4f.ModuleSquared()")]
		public void Vertex4f_TestModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex4f((float)1.0, (float)2.0, (float)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex4f((float)2.0, (float)5.0, (float)7.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex4f.Normalize()")]
		public void Vertex4f_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex4f.Zero.Normalize(); });

			Vertex4f v;

			v = Vertex4f.UnitX * (float)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4f.UnitX, v);

			v = Vertex4f.UnitY * (float)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4f.UnitY, v);

			v = Vertex4f.UnitZ * (float)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4f.UnitZ, v);
		}

		[Test(Description = "Test Vertex4f.Normalized")]
		public void Vertex4f_TestNormalized()
		{
			Vertex4f v;

			Assert.DoesNotThrow(delegate() { v = Vertex4f.Zero.Normalized; });

			v = Vertex4f.UnitX * (float)2.0f;
			Assert.AreEqual(Vertex4f.UnitX, v.Normalized);

			v = Vertex4f.UnitY * (float)2.0f;
			Assert.AreEqual(Vertex4f.UnitY, v.Normalized);

			v = Vertex4f.UnitZ * (float)2.0f;
			Assert.AreEqual(Vertex4f.UnitZ, v.Normalized);
		}

		[Test(Description = "Test Vertex4f.Min(Vertex4f[])")]
		public void Vertex4f_TestMin()
		{
			Vertex4f[] v = new Vertex4f[] {
				new Vertex4f((float)1.0f, (float)13.0f, (float)22.0f),
				new Vertex4f((float)2.0f, (float)12.0f, (float)21.0f),
				new Vertex4f((float)3.0f, (float)11.0f, (float)23.0f),
			};

			Vertex4f min = Vertex4f.Min(v);

			Assert.AreEqual(
				new Vertex4f((float)1.0f, (float)11.0f, (float)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex4f.Min(Vertex4f[]) ArgumentNullException")]
		public void Vertex4f_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4f.Min(null));
		}

		[Test(Description = "Test Vertex4f.Min(Vertex4f*)")]
		public void Vertex4f_TestMin_Unsafe()
		{
			Vertex4f[] v = new Vertex4f[] {
				new Vertex4f((float)1.0f, (float)13.0f, (float)22.0f),
				new Vertex4f((float)2.0f, (float)12.0f, (float)21.0f),
				new Vertex4f((float)3.0f, (float)11.0f, (float)23.0f),
			};

			Vertex4f min;

			unsafe {
				fixed (Vertex4f* vPtr = v) {
					min = Vertex4f.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex4f((float)1.0f, (float)11.0f, (float)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex4f.Min(Vertex4f*) ArgumentNullException")]
		public void Vertex4f_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4f.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex4f.Max(Vertex4f[])")]
		public void Vertex4f_TestMax()
		{
			Vertex4f[] v = new Vertex4f[] {
				new Vertex4f((float)1.0f, (float)13.0f, (float)22.0f),
				new Vertex4f((float)2.0f, (float)12.0f, (float)21.0f),
				new Vertex4f((float)3.0f, (float)11.0f, (float)23.0f),
			};

			Vertex4f max = Vertex4f.Max(v);

			Assert.AreEqual(
				new Vertex4f((float)3.0f, (float)13.0f, (float)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4f.Max(Vertex4f[]) ArgumentNullException")]
		public void Vertex4f_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4f.Max(null));
		}

		[Test(Description = "Test Vertex4f.Max(Vertex4f*)")]
		public void Vertex4f_TestMax_Unsafe()
		{
			Vertex4f[] v = new Vertex4f[] {
				new Vertex4f((float)1.0f, (float)13.0f, (float)22.0f),
				new Vertex4f((float)2.0f, (float)12.0f, (float)21.0f),
				new Vertex4f((float)3.0f, (float)11.0f, (float)23.0f),
			};

			Vertex4f max;

			unsafe {
				fixed (Vertex4f* vPtr = v) {
					max = Vertex4f.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex4f((float)3.0f, (float)13.0f, (float)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4f.Max(Vertex4f*) ArgumentNullException")]
		public void Vertex4f_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4f.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex4f.Max(Vertex4f[])")]
		public void Vertex4f_TestMinMax()
		{
			Vertex4f[] v = new Vertex4f[] {
				new Vertex4f((float)1.0f, (float)13.0f, (float)22.0f),
				new Vertex4f((float)2.0f, (float)12.0f, (float)21.0f),
				new Vertex4f((float)3.0f, (float)11.0f, (float)23.0f),
			};

			Vertex4f min, max;

			Vertex4f.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex4f((float)1.0f, (float)11.0f, (float)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex4f((float)3.0f, (float)13.0f, (float)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4f.Max(Vertex4f[]) ArgumentNullException")]
		public void Vertex4f_TestMinMax_ArgumentNullException()
		{
			Vertex4f min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex4f.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex4f.MinMax(Vertex4f*)")]
		public void Vertex4f_TestMinMax_Unsafe()
		{
			Vertex4f[] v = new Vertex4f[] {
				new Vertex4f((float)1.0f, (float)13.0f, (float)22.0f),
				new Vertex4f((float)2.0f, (float)12.0f, (float)21.0f),
				new Vertex4f((float)3.0f, (float)11.0f, (float)23.0f),
			};

			Vertex4f min, max;

			unsafe {
				fixed (Vertex4f* vPtr = v) {
					Vertex4f.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex4f((float)1.0f, (float)11.0f, (float)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex4f((float)3.0f, (float)13.0f, (float)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4f.MinMax(Vertex4f*) ArgumentNullException")]
		public void Vertex4f_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex4f min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4f.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex4f.Equals(Vertex4f)")]
		public void Vertex4f_TestEquals_Vertex4f()
		{
			Vertex4f v = Vertex4f.UnitX;

			Assert.IsTrue(v.Equals(Vertex4f.UnitX));
			Assert.IsFalse(v.Equals(Vertex4f.UnitY));
			Assert.IsFalse(v.Equals(Vertex4f.UnitZ));

			// Defined vs Undefined equality
			Vertex4f v1 = new Vertex4f(1.0f, 1.0f, 1.0f, 1.0f);
			Vertex4f v2 = new Vertex4f(1.0f, 1.0f, 1.0f, 0.0f);

			Assert.IsFalse(v1.Equals(v2));
			Assert.IsFalse(v2.Equals(v1));

			// Undefined vs Undefined equality
			v1 = new Vertex4f(1.0f, 1.0f, 1.0f, 0.0f);
			v2 = new Vertex4f(1.0f, 1.0f, 1.0f, 0.0f);

			Assert.IsTrue(v1.Equals(v2));
			Assert.IsTrue(v2.Equals(v1));

			// Normalized equality
			v1 = new Vertex4f(1.0f);
			v2 = new Vertex4f((float)(1.0f + 1.0f));

			Assert.IsTrue(v1.Equals(v2));
			Assert.IsTrue(v2.Equals(v1));
		}

		[Test(Description = "Test Vertex4f.Equals(object)")]
		public void Vertex4f_TestEquals_Object()
		{
			Vertex4f v = Vertex4f.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex4f.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex4f.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex4f.UnitZ));
		}

		[Test(Description = "Test Vertex4f.GetHashCode()")]
		public void Vertex4f_TestGetHashCode()
		{
			Random random = new Random();
			
			float x = (float)Next(random);
			float y = (float)Next(random);
			float z = (float)Next(random);

			Vertex4f v = new Vertex4f(x, y, z);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex4f.ToString()")]
		public void Vertex4f_TestToString()
		{
			Random random = new Random();
			
			float x = (float)Next(random);
			float y = (float)Next(random);
			float z = (float)Next(random);

			Vertex4f v = new Vertex4f(x, y, z);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex4dTest : Vertex3TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex4d(double)")]
		public void Vertex4d_TestConstructor1()
		{
			Random random = new Random();
			double randomValue = (double)Next(random);
			
			Vertex4d v = new Vertex4d(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex4d(double[])")]
		public void Vertex4d_TestConstructor2()
		{
			Random random = new Random();
			double randomValueX = (double)Next(random);
			double randomValueY = (double)Next(random);
			double randomValueZ = (double)Next(random);
			double randomValueW = (double)Next(random);
			Vertex4d v;

			v = new Vertex4d(new double[] {
				randomValueX, randomValueY, randomValueZ
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);

			v = new Vertex4d(new double[] {
				randomValueX, randomValueY, randomValueZ, randomValueW
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
			Assert.AreEqual(randomValueW, v.w);
		}

		[Test(Description = "Test Vertex4d(double, double, double)")]
		public void Vertex4d_TestConstructor3()
		{
			Random random = new Random();
			double randomValueX = (double)Next(random);
			double randomValueY = (double)Next(random);
			double randomValueZ = (double)Next(random);

			Vertex4d v = new Vertex4d(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex4d.Size against Marshal.SizeOf")]
		public void Vertex4d_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex4d)), Vertex4d.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex4d.operator-(Vertex4d))")]
		public void Vertex4d_TestOperatorNegate()
		{
			Random random = new Random();
			
			double x = (double)Next(random);
			double y = (double)Next(random);
			double z = (double)Next(random);

			Vertex4d v = new Vertex4d(x, y, z);
			Vertex4d n = -v;

			Assert.AreEqual(-x, n.x);
			Assert.AreEqual(-y, n.y);
			Assert.AreEqual(-z, n.z);
		}
		[Test(Description = "Test Vertex4d.operator+(Vertex4d, Vertex4d)")]
		public void Vertex4d_TestOperatorAdd()
		{
			Random random = new Random();
			
			double x1 = (double)Next(random);
			double y1 = (double)Next(random);
			double z1 = (double)Next(random);

			Vertex4d v1 = new Vertex4d(x1, y1, z1);

			double x2 = (double)Next(random);
			double y2 = (double)Next(random);
			double z2 = (double)Next(random);

			Vertex4d v2 = new Vertex4d(x2, y2, z2);

			Vertex4d v = v1 + v2;

			Assert.AreEqual((double)(x1 + x2), v.x);
			Assert.AreEqual((double)(y1 + y2), v.y);
			Assert.AreEqual((double)(z1 + z2), v.z);
		}

		[Test(Description = "Test Vertex4d.operator-(Vertex4d, Vertex4d)")]
		public void Vertex4d_TestOperatorSub()
		{
			Random random = new Random();
			
			double x1 = (double)Next(random);
			double y1 = (double)Next(random);
			double z1 = (double)Next(random);

			Vertex4d v1 = new Vertex4d(x1, y1, z1);

			double x2 = (double)Next(random);
			double y2 = (double)Next(random);
			double z2 = (double)Next(random);

			Vertex4d v2 = new Vertex4d(x2, y2, z2);

			Vertex4d v = v1 - v2;

			Assert.AreEqual((double)(x1 - x2), v.x);
			Assert.AreEqual((double)(y1 - y2), v.y);
			Assert.AreEqual((double)(z1 - z2), v.z);
		}

		[Test(Description = "Test Vertex4d.operator*(Vertex4d, Single)")]
		public void Vertex4d_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			double x1 = (double)Next(random);
			double y1 = (double)Next(random);
			double z1 = (double)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex4d v1 = new Vertex4d(x1, y1, z1);

			Vertex4d v = v1 * (float)s;

			Assert.AreEqual((double)(x1 * (float)s), v.x);
			Assert.AreEqual((double)(y1 * (float)s), v.y);
			Assert.AreEqual((double)(z1 * (float)s), v.z);
		}

		[Test(Description = "Test Vertex4d.operator/(Vertex4d, Single)")]
		public void Vertex4d_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			double x1 = (double)Next(random);
			double y1 = (double)Next(random);
			double z1 = (double)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex4d v1 = new Vertex4d(x1, y1, z1);

			Vertex4d v = v1 / (float)s;

			Assert.AreEqual((double)(x1 / (float)s), v.x);
			Assert.AreEqual((double)(y1 / (float)s), v.y);
			Assert.AreEqual((double)(z1 / (float)s), v.z);
		}


		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex4d.operator==(Vertex4d, Vertex4d)")]
		public void Vertex4d_TestOperatorEquality()
		{
			Vertex4d v = Vertex4d.UnitX;

			Assert.IsTrue(v == Vertex4d.UnitX);
			Assert.IsFalse(v == Vertex4d.UnitY);
		}

		[Test(Description = "Test Vertex4d.operator!=(Vertex4d, Vertex4d)")]
		public void Vertex4d_TestOperatorInequality()
		{
			Vertex4d v = Vertex4d.UnitX;

			Assert.IsFalse(v != Vertex4d.UnitX);
			Assert.IsTrue(v != Vertex4d.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex4d.operator double[](Vertex4d)")]
		public void Vertex4d_TestCastToArray()
		{
			Random random = new Random();
			
			double x = (double)Next(random);
			double y = (double)Next(random);
			double z = (double)Next(random);

			Vertex4d v = new Vertex4d(x, y, z);
			double[] vArray = (double[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex4d.operator Vertex2f(Vertex4d)")]
		public void Vertex4d_TestCastToVertex2f()
		{
			Random random = new Random();
			
			double x = (double)Next(random);
			double y = (double)Next(random);
			double z = (double)Next(random);

			Vertex4d v = new Vertex4d(x, y, z);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.x, (float)v2f.x, 1e-4f);
			Assert.AreEqual(v.y, (float)v2f.y, 1e-4f);
		}

		[Test(Description = "Test Vertex4d.operator Vertex3f(Vertex4d)")]
		public void Vertex4d_TestCastToVertex3f()
		{
			Random random = new Random();
			
			double x = (double)Next(random);
			double y = (double)Next(random);
			double z = (double)Next(random);

			Vertex4d v = new Vertex4d(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.x, v3f.x, 1e-4f);
			Assert.AreEqual(v.y, v3f.y, 1e-4f);
			Assert.AreEqual(v.z, v3f.z, 1e-4f);
		}

		[Test(Description = "Test Vertex4d.operator Vertex3d(Vertex4d)")]
		public void Vertex4d_TestCastToVertex3d()
		{
			Random random = new Random();
			
			double x = (double)Next(random);
			double y = (double)Next(random);
			double z = (double)Next(random);

			Vertex4d v = new Vertex4d(x, y, z);
			Vertex3d v3d = (Vertex3d)v;

			Assert.AreEqual(v.x, v3d.x, 1e-4);
			Assert.AreEqual(v.y, v3d.y, 1e-4);
			Assert.AreEqual(v.z, v3d.z, 1e-4);
		}

		[Test(Description = "Test Vertex4d.operator Vertex4f(Vertex4d)")]
		public void Vertex4d_TestCastToVertex4f()
		{
			Random random = new Random();
			
			double x = (double)Next(random);
			double y = (double)Next(random);
			double z = (double)Next(random);

			Vertex4d v = new Vertex4d(x, y, z);
			Vertex4f v4f = (Vertex4f)v;

			Assert.AreEqual(v.x, v4f.x, 1e-4);
			Assert.AreEqual(v.y, v4f.y, 1e-4);
			Assert.AreEqual(v.z, v4f.z, 1e-4);
			Assert.AreEqual(1.0f, v4f.w, 1e-4);
		}

		[Test(Description = "Test Vertex4d.operator Vertex4d(Vertex4d)")]
		public void Vertex4d_TestCastToVertex4d()
		{
			Random random = new Random();
			
			double x = (double)Next(random);
			double y = (double)Next(random);
			double z = (double)Next(random);

			Vertex4d v = new Vertex4d(x, y, z);
			Vertex4d v4d = (Vertex4d)v;

			Assert.AreEqual(v.x, v4d.x, 1e-4);
			Assert.AreEqual(v.y, v4d.y, 1e-4);
			Assert.AreEqual(v.z, v4d.z, 1e-4);
			Assert.AreEqual(1.0f, v4d.w, 1e-4);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex4d.Module()")]
		public void Vertex4d_TestModule()
		{
			Assert.AreEqual(3.741657f, new Vertex4d((double)1.0, (double)2.0, (double)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex4d((double)2.0, (double)5.0, (double)7.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex4d.ModuleSquared()")]
		public void Vertex4d_TestModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex4d((double)1.0, (double)2.0, (double)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex4d((double)2.0, (double)5.0, (double)7.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex4d.Normalize()")]
		public void Vertex4d_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex4d.Zero.Normalize(); });

			Vertex4d v;

			v = Vertex4d.UnitX * (double)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4d.UnitX, v);

			v = Vertex4d.UnitY * (double)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4d.UnitY, v);

			v = Vertex4d.UnitZ * (double)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4d.UnitZ, v);
		}

		[Test(Description = "Test Vertex4d.Normalized")]
		public void Vertex4d_TestNormalized()
		{
			Vertex4d v;

			Assert.DoesNotThrow(delegate() { v = Vertex4d.Zero.Normalized; });

			v = Vertex4d.UnitX * (double)2.0f;
			Assert.AreEqual(Vertex4d.UnitX, v.Normalized);

			v = Vertex4d.UnitY * (double)2.0f;
			Assert.AreEqual(Vertex4d.UnitY, v.Normalized);

			v = Vertex4d.UnitZ * (double)2.0f;
			Assert.AreEqual(Vertex4d.UnitZ, v.Normalized);
		}

		[Test(Description = "Test Vertex4d.Min(Vertex4d[])")]
		public void Vertex4d_TestMin()
		{
			Vertex4d[] v = new Vertex4d[] {
				new Vertex4d((double)1.0f, (double)13.0f, (double)22.0f),
				new Vertex4d((double)2.0f, (double)12.0f, (double)21.0f),
				new Vertex4d((double)3.0f, (double)11.0f, (double)23.0f),
			};

			Vertex4d min = Vertex4d.Min(v);

			Assert.AreEqual(
				new Vertex4d((double)1.0f, (double)11.0f, (double)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex4d.Min(Vertex4d[]) ArgumentNullException")]
		public void Vertex4d_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4d.Min(null));
		}

		[Test(Description = "Test Vertex4d.Min(Vertex4d*)")]
		public void Vertex4d_TestMin_Unsafe()
		{
			Vertex4d[] v = new Vertex4d[] {
				new Vertex4d((double)1.0f, (double)13.0f, (double)22.0f),
				new Vertex4d((double)2.0f, (double)12.0f, (double)21.0f),
				new Vertex4d((double)3.0f, (double)11.0f, (double)23.0f),
			};

			Vertex4d min;

			unsafe {
				fixed (Vertex4d* vPtr = v) {
					min = Vertex4d.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex4d((double)1.0f, (double)11.0f, (double)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex4d.Min(Vertex4d*) ArgumentNullException")]
		public void Vertex4d_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4d.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex4d.Max(Vertex4d[])")]
		public void Vertex4d_TestMax()
		{
			Vertex4d[] v = new Vertex4d[] {
				new Vertex4d((double)1.0f, (double)13.0f, (double)22.0f),
				new Vertex4d((double)2.0f, (double)12.0f, (double)21.0f),
				new Vertex4d((double)3.0f, (double)11.0f, (double)23.0f),
			};

			Vertex4d max = Vertex4d.Max(v);

			Assert.AreEqual(
				new Vertex4d((double)3.0f, (double)13.0f, (double)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4d.Max(Vertex4d[]) ArgumentNullException")]
		public void Vertex4d_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4d.Max(null));
		}

		[Test(Description = "Test Vertex4d.Max(Vertex4d*)")]
		public void Vertex4d_TestMax_Unsafe()
		{
			Vertex4d[] v = new Vertex4d[] {
				new Vertex4d((double)1.0f, (double)13.0f, (double)22.0f),
				new Vertex4d((double)2.0f, (double)12.0f, (double)21.0f),
				new Vertex4d((double)3.0f, (double)11.0f, (double)23.0f),
			};

			Vertex4d max;

			unsafe {
				fixed (Vertex4d* vPtr = v) {
					max = Vertex4d.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex4d((double)3.0f, (double)13.0f, (double)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4d.Max(Vertex4d*) ArgumentNullException")]
		public void Vertex4d_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4d.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex4d.Max(Vertex4d[])")]
		public void Vertex4d_TestMinMax()
		{
			Vertex4d[] v = new Vertex4d[] {
				new Vertex4d((double)1.0f, (double)13.0f, (double)22.0f),
				new Vertex4d((double)2.0f, (double)12.0f, (double)21.0f),
				new Vertex4d((double)3.0f, (double)11.0f, (double)23.0f),
			};

			Vertex4d min, max;

			Vertex4d.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex4d((double)1.0f, (double)11.0f, (double)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex4d((double)3.0f, (double)13.0f, (double)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4d.Max(Vertex4d[]) ArgumentNullException")]
		public void Vertex4d_TestMinMax_ArgumentNullException()
		{
			Vertex4d min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex4d.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex4d.MinMax(Vertex4d*)")]
		public void Vertex4d_TestMinMax_Unsafe()
		{
			Vertex4d[] v = new Vertex4d[] {
				new Vertex4d((double)1.0f, (double)13.0f, (double)22.0f),
				new Vertex4d((double)2.0f, (double)12.0f, (double)21.0f),
				new Vertex4d((double)3.0f, (double)11.0f, (double)23.0f),
			};

			Vertex4d min, max;

			unsafe {
				fixed (Vertex4d* vPtr = v) {
					Vertex4d.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex4d((double)1.0f, (double)11.0f, (double)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex4d((double)3.0f, (double)13.0f, (double)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4d.MinMax(Vertex4d*) ArgumentNullException")]
		public void Vertex4d_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex4d min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4d.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex4d.Equals(Vertex4d)")]
		public void Vertex4d_TestEquals_Vertex4d()
		{
			Vertex4d v = Vertex4d.UnitX;

			Assert.IsTrue(v.Equals(Vertex4d.UnitX));
			Assert.IsFalse(v.Equals(Vertex4d.UnitY));
			Assert.IsFalse(v.Equals(Vertex4d.UnitZ));

			// Defined vs Undefined equality
			Vertex4d v1 = new Vertex4d(1.0, 1.0, 1.0, 1.0);
			Vertex4d v2 = new Vertex4d(1.0, 1.0, 1.0, 0.0);

			Assert.IsFalse(v1.Equals(v2));
			Assert.IsFalse(v2.Equals(v1));

			// Undefined vs Undefined equality
			v1 = new Vertex4d(1.0, 1.0, 1.0, 0.0);
			v2 = new Vertex4d(1.0, 1.0, 1.0, 0.0);

			Assert.IsTrue(v1.Equals(v2));
			Assert.IsTrue(v2.Equals(v1));

			// Normalized equality
			v1 = new Vertex4d(1.0);
			v2 = new Vertex4d((double)(1.0 + 1.0));

			Assert.IsTrue(v1.Equals(v2));
			Assert.IsTrue(v2.Equals(v1));
		}

		[Test(Description = "Test Vertex4d.Equals(object)")]
		public void Vertex4d_TestEquals_Object()
		{
			Vertex4d v = Vertex4d.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex4d.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex4d.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex4d.UnitZ));
		}

		[Test(Description = "Test Vertex4d.GetHashCode()")]
		public void Vertex4d_TestGetHashCode()
		{
			Random random = new Random();
			
			double x = (double)Next(random);
			double y = (double)Next(random);
			double z = (double)Next(random);

			Vertex4d v = new Vertex4d(x, y, z);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex4d.ToString()")]
		public void Vertex4d_TestToString()
		{
			Random random = new Random();
			
			double x = (double)Next(random);
			double y = (double)Next(random);
			double z = (double)Next(random);

			Vertex4d v = new Vertex4d(x, y, z);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	class Vertex4hfTest : Vertex3TestBase
	{
		#region Constructors

		[Test(Description = "Test Vertex4hf(HalfFloat)")]
		public void Vertex4hf_TestConstructor1()
		{
			Random random = new Random();
			HalfFloat randomValue = (HalfFloat)Next(random);
			
			Vertex4hf v = new Vertex4hf(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex4hf(HalfFloat[])")]
		public void Vertex4hf_TestConstructor2()
		{
			Random random = new Random();
			HalfFloat randomValueX = (HalfFloat)Next(random);
			HalfFloat randomValueY = (HalfFloat)Next(random);
			HalfFloat randomValueZ = (HalfFloat)Next(random);
			HalfFloat randomValueW = (HalfFloat)Next(random);
			Vertex4hf v;

			v = new Vertex4hf(new HalfFloat[] {
				randomValueX, randomValueY, randomValueZ
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);

			v = new Vertex4hf(new HalfFloat[] {
				randomValueX, randomValueY, randomValueZ, randomValueW
			});

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
			Assert.AreEqual(randomValueW, v.w);
		}

		[Test(Description = "Test Vertex4hf(HalfFloat, HalfFloat, HalfFloat)")]
		public void Vertex4hf_TestConstructor3()
		{
			Random random = new Random();
			HalfFloat randomValueX = (HalfFloat)Next(random);
			HalfFloat randomValueY = (HalfFloat)Next(random);
			HalfFloat randomValueZ = (HalfFloat)Next(random);

			Vertex4hf v = new Vertex4hf(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		#endregion

		#region Properties

		[Test(Description = "Test Vertex4hf.Size against Marshal.SizeOf")]
		public void Vertex4hf_TestMarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex4hf)), Vertex4hf.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test(Description = "Test Vertex4hf.operator+(Vertex4hf, Vertex4hf)")]
		public void Vertex4hf_TestOperatorAdd()
		{
			Random random = new Random();
			
			HalfFloat x1 = (HalfFloat)Next(random);
			HalfFloat y1 = (HalfFloat)Next(random);
			HalfFloat z1 = (HalfFloat)Next(random);

			Vertex4hf v1 = new Vertex4hf(x1, y1, z1);

			HalfFloat x2 = (HalfFloat)Next(random);
			HalfFloat y2 = (HalfFloat)Next(random);
			HalfFloat z2 = (HalfFloat)Next(random);

			Vertex4hf v2 = new Vertex4hf(x2, y2, z2);

			Vertex4hf v = v1 + v2;

			Assert.AreEqual((HalfFloat)(x1 + x2), v.x);
			Assert.AreEqual((HalfFloat)(y1 + y2), v.y);
			Assert.AreEqual((HalfFloat)(z1 + z2), v.z);
		}

		[Test(Description = "Test Vertex4hf.operator-(Vertex4hf, Vertex4hf)")]
		public void Vertex4hf_TestOperatorSub()
		{
			Random random = new Random();
			
			HalfFloat x1 = (HalfFloat)Next(random);
			HalfFloat y1 = (HalfFloat)Next(random);
			HalfFloat z1 = (HalfFloat)Next(random);

			Vertex4hf v1 = new Vertex4hf(x1, y1, z1);

			HalfFloat x2 = (HalfFloat)Next(random);
			HalfFloat y2 = (HalfFloat)Next(random);
			HalfFloat z2 = (HalfFloat)Next(random);

			Vertex4hf v2 = new Vertex4hf(x2, y2, z2);

			Vertex4hf v = v1 - v2;

			Assert.AreEqual((HalfFloat)(x1 - x2), v.x);
			Assert.AreEqual((HalfFloat)(y1 - y2), v.y);
			Assert.AreEqual((HalfFloat)(z1 - z2), v.z);
		}

		[Test(Description = "Test Vertex4hf.operator*(Vertex4hf, Single)")]
		public void Vertex4hf_TestOperatorMultiplySingle()
		{
			Random random = new Random();
			
			HalfFloat x1 = (HalfFloat)Next(random);
			HalfFloat y1 = (HalfFloat)Next(random);
			HalfFloat z1 = (HalfFloat)Next(random);
			double s = Next(random, 0.0, 32.0);

			Vertex4hf v1 = new Vertex4hf(x1, y1, z1);

			Vertex4hf v = v1 * (float)s;

			Assert.AreEqual((HalfFloat)(x1 * (float)s), v.x);
			Assert.AreEqual((HalfFloat)(y1 * (float)s), v.y);
			Assert.AreEqual((HalfFloat)(z1 * (float)s), v.z);
		}

		[Test(Description = "Test Vertex4hf.operator/(Vertex4hf, Single)")]
		public void Vertex4hf_TestOperatorDivideSingle()
		{
			Random random = new Random();
			
			HalfFloat x1 = (HalfFloat)Next(random);
			HalfFloat y1 = (HalfFloat)Next(random);
			HalfFloat z1 = (HalfFloat)Next(random);
			double s = Next(random, 1.0, 32.0);

			Vertex4hf v1 = new Vertex4hf(x1, y1, z1);

			Vertex4hf v = v1 / (float)s;

			Assert.AreEqual((HalfFloat)(x1 / (float)s), v.x);
			Assert.AreEqual((HalfFloat)(y1 / (float)s), v.y);
			Assert.AreEqual((HalfFloat)(z1 / (float)s), v.z);
		}


		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex4hf.operator==(Vertex4hf, Vertex4hf)")]
		public void Vertex4hf_TestOperatorEquality()
		{
			Vertex4hf v = Vertex4hf.UnitX;

			Assert.IsTrue(v == Vertex4hf.UnitX);
			Assert.IsFalse(v == Vertex4hf.UnitY);
		}

		[Test(Description = "Test Vertex4hf.operator!=(Vertex4hf, Vertex4hf)")]
		public void Vertex4hf_TestOperatorInequality()
		{
			Vertex4hf v = Vertex4hf.UnitX;

			Assert.IsFalse(v != Vertex4hf.UnitX);
			Assert.IsTrue(v != Vertex4hf.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex4hf.operator HalfFloat[](Vertex4hf)")]
		public void Vertex4hf_TestCastToArray()
		{
			Random random = new Random();
			
			HalfFloat x = (HalfFloat)Next(random);
			HalfFloat y = (HalfFloat)Next(random);
			HalfFloat z = (HalfFloat)Next(random);

			Vertex4hf v = new Vertex4hf(x, y, z);
			HalfFloat[] vArray = (HalfFloat[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex4hf.operator Vertex2f(Vertex4hf)")]
		public void Vertex4hf_TestCastToVertex2f()
		{
			Random random = new Random();
			
			HalfFloat x = (HalfFloat)Next(random);
			HalfFloat y = (HalfFloat)Next(random);
			HalfFloat z = (HalfFloat)Next(random);

			Vertex4hf v = new Vertex4hf(x, y, z);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.x, (float)v2f.x, 1e-4f);
			Assert.AreEqual(v.y, (float)v2f.y, 1e-4f);
		}

		[Test(Description = "Test Vertex4hf.operator Vertex3f(Vertex4hf)")]
		public void Vertex4hf_TestCastToVertex3f()
		{
			Random random = new Random();
			
			HalfFloat x = (HalfFloat)Next(random);
			HalfFloat y = (HalfFloat)Next(random);
			HalfFloat z = (HalfFloat)Next(random);

			Vertex4hf v = new Vertex4hf(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.x, v3f.x, 1e-4f);
			Assert.AreEqual(v.y, v3f.y, 1e-4f);
			Assert.AreEqual(v.z, v3f.z, 1e-4f);
		}

		[Test(Description = "Test Vertex4hf.operator Vertex3d(Vertex4hf)")]
		public void Vertex4hf_TestCastToVertex3d()
		{
			Random random = new Random();
			
			HalfFloat x = (HalfFloat)Next(random);
			HalfFloat y = (HalfFloat)Next(random);
			HalfFloat z = (HalfFloat)Next(random);

			Vertex4hf v = new Vertex4hf(x, y, z);
			Vertex3d v3d = (Vertex3d)v;

			Assert.AreEqual(v.x, v3d.x, 1e-4);
			Assert.AreEqual(v.y, v3d.y, 1e-4);
			Assert.AreEqual(v.z, v3d.z, 1e-4);
		}

		[Test(Description = "Test Vertex4hf.operator Vertex4f(Vertex4hf)")]
		public void Vertex4hf_TestCastToVertex4f()
		{
			Random random = new Random();
			
			HalfFloat x = (HalfFloat)Next(random);
			HalfFloat y = (HalfFloat)Next(random);
			HalfFloat z = (HalfFloat)Next(random);

			Vertex4hf v = new Vertex4hf(x, y, z);
			Vertex4f v4f = (Vertex4f)v;

			Assert.AreEqual(v.x, v4f.x, 1e-4);
			Assert.AreEqual(v.y, v4f.y, 1e-4);
			Assert.AreEqual(v.z, v4f.z, 1e-4);
			Assert.AreEqual(1.0f, v4f.w, 1e-4);
		}

		[Test(Description = "Test Vertex4hf.operator Vertex4d(Vertex4hf)")]
		public void Vertex4hf_TestCastToVertex4d()
		{
			Random random = new Random();
			
			HalfFloat x = (HalfFloat)Next(random);
			HalfFloat y = (HalfFloat)Next(random);
			HalfFloat z = (HalfFloat)Next(random);

			Vertex4hf v = new Vertex4hf(x, y, z);
			Vertex4d v4d = (Vertex4d)v;

			Assert.AreEqual(v.x, v4d.x, 1e-4);
			Assert.AreEqual(v.y, v4d.y, 1e-4);
			Assert.AreEqual(v.z, v4d.z, 1e-4);
			Assert.AreEqual(1.0f, v4d.w, 1e-4);
		}

		#endregion

		#region Vertex Methods

		[Test(Description = "Test Vertex4hf.Module()")]
		public void Vertex4hf_TestModule()
		{
			Assert.AreEqual(3.741657f, new Vertex4hf((HalfFloat)1.0, (HalfFloat)2.0, (HalfFloat)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex4hf((HalfFloat)2.0, (HalfFloat)5.0, (HalfFloat)7.0).Module(), 1e-4f);
		}

		[Test(Description = "Test Vertex4hf.ModuleSquared()")]
		public void Vertex4hf_TestModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex4hf((HalfFloat)1.0, (HalfFloat)2.0, (HalfFloat)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex4hf((HalfFloat)2.0, (HalfFloat)5.0, (HalfFloat)7.0).ModuleSquared(), 1e-4f);
		}

		[Test(Description = "Test Vertex4hf.Normalize()")]
		public void Vertex4hf_TestNormalize()
		{
			Assert.DoesNotThrow(delegate() { Vertex4hf.Zero.Normalize(); });

			Vertex4hf v;

			v = Vertex4hf.UnitX * (HalfFloat)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4hf.UnitX, v);

			v = Vertex4hf.UnitY * (HalfFloat)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4hf.UnitY, v);

			v = Vertex4hf.UnitZ * (HalfFloat)2.0f;
			v.Normalize();
			Assert.AreEqual(Vertex4hf.UnitZ, v);
		}

		[Test(Description = "Test Vertex4hf.Normalized")]
		public void Vertex4hf_TestNormalized()
		{
			Vertex4hf v;

			Assert.DoesNotThrow(delegate() { v = Vertex4hf.Zero.Normalized; });

			v = Vertex4hf.UnitX * (HalfFloat)2.0f;
			Assert.AreEqual(Vertex4hf.UnitX, v.Normalized);

			v = Vertex4hf.UnitY * (HalfFloat)2.0f;
			Assert.AreEqual(Vertex4hf.UnitY, v.Normalized);

			v = Vertex4hf.UnitZ * (HalfFloat)2.0f;
			Assert.AreEqual(Vertex4hf.UnitZ, v.Normalized);
		}

		[Test(Description = "Test Vertex4hf.Min(Vertex4hf[])")]
		public void Vertex4hf_TestMin()
		{
			Vertex4hf[] v = new Vertex4hf[] {
				new Vertex4hf((HalfFloat)1.0f, (HalfFloat)13.0f, (HalfFloat)22.0f),
				new Vertex4hf((HalfFloat)2.0f, (HalfFloat)12.0f, (HalfFloat)21.0f),
				new Vertex4hf((HalfFloat)3.0f, (HalfFloat)11.0f, (HalfFloat)23.0f),
			};

			Vertex4hf min = Vertex4hf.Min(v);

			Assert.AreEqual(
				new Vertex4hf((HalfFloat)1.0f, (HalfFloat)11.0f, (HalfFloat)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex4hf.Min(Vertex4hf[]) ArgumentNullException")]
		public void Vertex4hf_TestMin_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4hf.Min(null));
		}

		[Test(Description = "Test Vertex4hf.Min(Vertex4hf*)")]
		public void Vertex4hf_TestMin_Unsafe()
		{
			Vertex4hf[] v = new Vertex4hf[] {
				new Vertex4hf((HalfFloat)1.0f, (HalfFloat)13.0f, (HalfFloat)22.0f),
				new Vertex4hf((HalfFloat)2.0f, (HalfFloat)12.0f, (HalfFloat)21.0f),
				new Vertex4hf((HalfFloat)3.0f, (HalfFloat)11.0f, (HalfFloat)23.0f),
			};

			Vertex4hf min;

			unsafe {
				fixed (Vertex4hf* vPtr = v) {
					min = Vertex4hf.Min(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex4hf((HalfFloat)1.0f, (HalfFloat)11.0f, (HalfFloat)21.0f),
				min
			);
		}

		[Test(Description = "Test Vertex4hf.Min(Vertex4hf*) ArgumentNullException")]
		public void Vertex4hf_TestMin_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4hf.Min(null, 0));
			}
		}

		[Test(Description = "Test Vertex4hf.Max(Vertex4hf[])")]
		public void Vertex4hf_TestMax()
		{
			Vertex4hf[] v = new Vertex4hf[] {
				new Vertex4hf((HalfFloat)1.0f, (HalfFloat)13.0f, (HalfFloat)22.0f),
				new Vertex4hf((HalfFloat)2.0f, (HalfFloat)12.0f, (HalfFloat)21.0f),
				new Vertex4hf((HalfFloat)3.0f, (HalfFloat)11.0f, (HalfFloat)23.0f),
			};

			Vertex4hf max = Vertex4hf.Max(v);

			Assert.AreEqual(
				new Vertex4hf((HalfFloat)3.0f, (HalfFloat)13.0f, (HalfFloat)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4hf.Max(Vertex4hf[]) ArgumentNullException")]
		public void Vertex4hf_TestMax_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4hf.Max(null));
		}

		[Test(Description = "Test Vertex4hf.Max(Vertex4hf*)")]
		public void Vertex4hf_TestMax_Unsafe()
		{
			Vertex4hf[] v = new Vertex4hf[] {
				new Vertex4hf((HalfFloat)1.0f, (HalfFloat)13.0f, (HalfFloat)22.0f),
				new Vertex4hf((HalfFloat)2.0f, (HalfFloat)12.0f, (HalfFloat)21.0f),
				new Vertex4hf((HalfFloat)3.0f, (HalfFloat)11.0f, (HalfFloat)23.0f),
			};

			Vertex4hf max;

			unsafe {
				fixed (Vertex4hf* vPtr = v) {
					max = Vertex4hf.Max(vPtr, (uint)v.Length);
				}
			}

			Assert.AreEqual(
				new Vertex4hf((HalfFloat)3.0f, (HalfFloat)13.0f, (HalfFloat)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4hf.Max(Vertex4hf*) ArgumentNullException")]
		public void Vertex4hf_TestMax_Unsafe_ArgumentNullException()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4hf.Max(null, 0));
			}
		}

		[Test(Description = "Test Vertex4hf.Max(Vertex4hf[])")]
		public void Vertex4hf_TestMinMax()
		{
			Vertex4hf[] v = new Vertex4hf[] {
				new Vertex4hf((HalfFloat)1.0f, (HalfFloat)13.0f, (HalfFloat)22.0f),
				new Vertex4hf((HalfFloat)2.0f, (HalfFloat)12.0f, (HalfFloat)21.0f),
				new Vertex4hf((HalfFloat)3.0f, (HalfFloat)11.0f, (HalfFloat)23.0f),
			};

			Vertex4hf min, max;

			Vertex4hf.MinMax(v, out min, out max);

			Assert.AreEqual(
				new Vertex4hf((HalfFloat)1.0f, (HalfFloat)11.0f, (HalfFloat)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex4hf((HalfFloat)3.0f, (HalfFloat)13.0f, (HalfFloat)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4hf.Max(Vertex4hf[]) ArgumentNullException")]
		public void Vertex4hf_TestMinMax_ArgumentNullException()
		{
			Vertex4hf min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex4hf.MinMax(null, out min, out max));
		}

		[Test(Description = "Test Vertex4hf.MinMax(Vertex4hf*)")]
		public void Vertex4hf_TestMinMax_Unsafe()
		{
			Vertex4hf[] v = new Vertex4hf[] {
				new Vertex4hf((HalfFloat)1.0f, (HalfFloat)13.0f, (HalfFloat)22.0f),
				new Vertex4hf((HalfFloat)2.0f, (HalfFloat)12.0f, (HalfFloat)21.0f),
				new Vertex4hf((HalfFloat)3.0f, (HalfFloat)11.0f, (HalfFloat)23.0f),
			};

			Vertex4hf min, max;

			unsafe {
				fixed (Vertex4hf* vPtr = v) {
					Vertex4hf.MinMax(vPtr, (uint)v.Length, out min, out max);
				}
			}

			Assert.AreEqual(
				new Vertex4hf((HalfFloat)1.0f, (HalfFloat)11.0f, (HalfFloat)21.0f),
				min
			);
			Assert.AreEqual(
				new Vertex4hf((HalfFloat)3.0f, (HalfFloat)13.0f, (HalfFloat)23.0f),
				max
			);
		}

		[Test(Description = "Test Vertex4hf.MinMax(Vertex4hf*) ArgumentNullException")]
		public void Vertex4hf_TestMinMax_Unsafe_ArgumentNullException()
		{
			Vertex4hf min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4hf.MinMax(null, 0, out min, out max));
			}
		}

		#endregion

		#region IEquatable Implementation

		[Test(Description = "Test Vertex4hf.Equals(Vertex4hf)")]
		public void Vertex4hf_TestEquals_Vertex4hf()
		{
			Vertex4hf v = Vertex4hf.UnitX;

			Assert.IsTrue(v.Equals(Vertex4hf.UnitX));
			Assert.IsFalse(v.Equals(Vertex4hf.UnitY));
			Assert.IsFalse(v.Equals(Vertex4hf.UnitZ));

			// Defined vs Undefined equality
			Vertex4hf v1 = new Vertex4hf((HalfFloat)1.0f, (HalfFloat)1.0f, (HalfFloat)1.0f, (HalfFloat)1.0f);
			Vertex4hf v2 = new Vertex4hf((HalfFloat)1.0f, (HalfFloat)1.0f, (HalfFloat)1.0f, (HalfFloat)0.0f);

			Assert.IsFalse(v1.Equals(v2));
			Assert.IsFalse(v2.Equals(v1));

			// Undefined vs Undefined equality
			v1 = new Vertex4hf((HalfFloat)1.0f, (HalfFloat)1.0f, (HalfFloat)1.0f, (HalfFloat)0.0f);
			v2 = new Vertex4hf((HalfFloat)1.0f, (HalfFloat)1.0f, (HalfFloat)1.0f, (HalfFloat)0.0f);

			Assert.IsTrue(v1.Equals(v2));
			Assert.IsTrue(v2.Equals(v1));

			// Normalized equality
			v1 = new Vertex4hf((HalfFloat)1.0f);
			v2 = new Vertex4hf((HalfFloat)((HalfFloat)1.0f + (HalfFloat)1.0f));

			Assert.IsTrue(v1.Equals(v2));
			Assert.IsTrue(v2.Equals(v1));
		}

		[Test(Description = "Test Vertex4hf.Equals(object)")]
		public void Vertex4hf_TestEquals_Object()
		{
			Vertex4hf v = Vertex4hf.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex4hf.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex4hf.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex4hf.UnitZ));
		}

		[Test(Description = "Test Vertex4hf.GetHashCode()")]
		public void Vertex4hf_TestGetHashCode()
		{
			Random random = new Random();
			
			HalfFloat x = (HalfFloat)Next(random);
			HalfFloat y = (HalfFloat)Next(random);
			HalfFloat z = (HalfFloat)Next(random);

			Vertex4hf v = new Vertex4hf(x, y, z);

			Assert.DoesNotThrow(delegate() { v.GetHashCode(); });
		}

		#endregion

		#region Object Overrides

		[Test(Description = "Test Vertex4hf.ToString()")]
		public void Vertex4hf_TestToString()
		{
			Random random = new Random();
			
			HalfFloat x = (HalfFloat)Next(random);
			HalfFloat y = (HalfFloat)Next(random);
			HalfFloat z = (HalfFloat)Next(random);

			Vertex4hf v = new Vertex4hf(x, y, z);

			Assert.DoesNotThrow(delegate() { v.ToString(); });
		}

		#endregion
	}

}
