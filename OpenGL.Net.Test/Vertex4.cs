
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

	[TestFixture, Category("Math")]
	class Vertex4ubTest : Vertex3TestBase
	{
		#region Constructors

		[Test]
		public void Vertex4ub_Constructor1()
		{
			Random random = new Random();
			byte randomValue = (byte)Next(random);
			
			Vertex4ub v = new Vertex4ub(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test]
		public void Vertex4ub_Constructor2()
		{
			Random random = new Random();
			byte randomValueX = (byte)Next(random);
			byte randomValueY = (byte)Next(random);
			byte randomValueZ = (byte)Next(random);
			byte randomValueW = (byte)Next(random);
			Vertex4ub v = new Vertex4ub();

			Assert.DoesNotThrow(() => v = new Vertex4ub(new byte[] {
				randomValueX, randomValueY, randomValueZ
			}));

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

		[Test]
		public void Vertex4ub_Constructor3()
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

		[Test]
		public void Vertex4ub_MarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex4ub)), Vertex4ub.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test]
		public void Vertex4ub_OperatorAdd()
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

		[Test]
		public void Vertex4ub_OperatorSub()
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

		[Test]
		public void Vertex4ub_OperatorMultiplySingle()
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

		[Test]
		public void Vertex4ub_OperatorDivideSingle()
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

		[Test]
		public void Vertex4ub_OperatorScalarMultiply()
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

		[Test]
		public void Vertex4ub_OperatorScalarDivide()
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

		[Test]
		public void Vertex4ub_OperatorEquality()
		{
			Vertex4ub v = Vertex4ub.UnitX;

			Assert.IsTrue(v == Vertex4ub.UnitX);
			Assert.IsFalse(v == Vertex4ub.UnitY);
		}

		[Test]
		public void Vertex4ub_OperatorInequality()
		{
			Vertex4ub v = Vertex4ub.UnitX;

			Assert.IsFalse(v != Vertex4ub.UnitX);
			Assert.IsTrue(v != Vertex4ub.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Vertex4ub_CastToArray()
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

		[Test]
		public void Vertex4ub_CastToVertex2f()
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

		[Test]
		public void Vertex4ub_CastToVertex3f()
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

		[Test]
		public void Vertex4ub_CastToVertex3d()
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

		[Test]
		public void Vertex4ub_CastToVertex4f()
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

		[Test]
		public void Vertex4ub_CastToVertex4d()
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

		[Test]
		public void Vertex4ub_Module()
		{
			Assert.AreEqual(3.741657f, new Vertex4ub((byte)1.0, (byte)2.0, (byte)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex4ub((byte)2.0, (byte)5.0, (byte)7.0).Module(), 1e-4f);
		}

		[Test]
		public void Vertex4ub_ModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex4ub((byte)1.0, (byte)2.0, (byte)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex4ub((byte)2.0, (byte)5.0, (byte)7.0).ModuleSquared(), 1e-4f);
		}

		[Test]
		public void Vertex4ub_Normalize()
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

		[Test]
		public void Vertex4ub_Normalized()
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

		[Test]
		public void Vertex4ub_Min()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4ub.Min(null));

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

		[Test]
		public void Vertex4ub_Min_Unsafe()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4ub.Min(null, 0));
			}

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

		[Test]
		public void Vertex4ub_Max()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4ub.Max(null));

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

		[Test]
		public void Vertex4ub_Max_Unsafe()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4ub.Max(null, 0));
			}

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

		[Test]
		public void Vertex4ub_MinMax()
		{
			Vertex4ub min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex4ub.MinMax(null, out min, out max));

			Vertex4ub[] v = new Vertex4ub[] {
				new Vertex4ub((byte)1.0f, (byte)13.0f, (byte)22.0f),
				new Vertex4ub((byte)2.0f, (byte)12.0f, (byte)21.0f),
				new Vertex4ub((byte)3.0f, (byte)11.0f, (byte)23.0f),
			};

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

		[Test]
		public void Vertex4ub_MinMax_Unsafe()
		{
			Vertex4ub min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4ub.MinMax(null, 0, out min, out max));
			}

			Vertex4ub[] v = new Vertex4ub[] {
				new Vertex4ub((byte)1.0f, (byte)13.0f, (byte)22.0f),
				new Vertex4ub((byte)2.0f, (byte)12.0f, (byte)21.0f),
				new Vertex4ub((byte)3.0f, (byte)11.0f, (byte)23.0f),
			};

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

		#endregion

		#region IEquatable Implementation

		[Test]
		public void Vertex4ub_Equals_Vertex4ub_AbsPrecision()
		{
			Vertex4ub v = Vertex4ub.UnitX;

			Assert.IsTrue(v.Equals(Vertex4ub.UnitX, (byte)0));
			Assert.IsFalse(v.Equals(Vertex4ub.UnitY, (byte)0));
			Assert.IsFalse(v.Equals(Vertex4ub.UnitZ, (byte)0));

			// Defined vs Undefined equality
			Vertex4ub v1 = new Vertex4ub(1, 1, 1, 1);
			Vertex4ub v2 = new Vertex4ub(1, 1, 1, 0);

			Assert.IsFalse(v1.Equals(v2, (byte)0));
			Assert.IsFalse(v2.Equals(v1, (byte)0));

			// Undefined vs Undefined equality
			v1 = new Vertex4ub(1, 1, 1, 0);
			v2 = new Vertex4ub(1, 1, 1, 0);

			Assert.IsTrue(v1.Equals(v2, (byte)0));
			Assert.IsTrue(v2.Equals(v1, (byte)0));

			// Normalized equality
			v1 = new Vertex4ub(1);
			v2 = new Vertex4ub((byte)(1 + 1));

			Assert.IsTrue(v1.Equals(v2, (byte)0));
			Assert.IsTrue(v2.Equals(v1, (byte)0));
		}

		[Test]
		public void Vertex4ub_Equals_Vertex4ub()
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

		[Test]
		public void Vertex4ub_Equals_Object()
		{
			Vertex4ub v = Vertex4ub.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex4ub.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex4ub.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex4ub.UnitZ));
		}

		[Test]
		public void Vertex4ub_GetHashCode()
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

		[Test]
		public void Vertex4ub_ToString()
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

	[TestFixture, Category("Math")]
	class Vertex4bTest : Vertex3TestBase
	{
		#region Constructors

		[Test]
		public void Vertex4b_Constructor1()
		{
			Random random = new Random();
			sbyte randomValue = (sbyte)Next(random);
			
			Vertex4b v = new Vertex4b(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test]
		public void Vertex4b_Constructor2()
		{
			Random random = new Random();
			sbyte randomValueX = (sbyte)Next(random);
			sbyte randomValueY = (sbyte)Next(random);
			sbyte randomValueZ = (sbyte)Next(random);
			sbyte randomValueW = (sbyte)Next(random);
			Vertex4b v = new Vertex4b();

			Assert.DoesNotThrow(() => v = new Vertex4b(new sbyte[] {
				randomValueX, randomValueY, randomValueZ
			}));

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

		[Test]
		public void Vertex4b_Constructor3()
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

		[Test]
		public void Vertex4b_MarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex4b)), Vertex4b.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test]
		public void Vertex4b_OperatorNegate()
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
		[Test]
		public void Vertex4b_OperatorAdd()
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

		[Test]
		public void Vertex4b_OperatorSub()
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

		[Test]
		public void Vertex4b_OperatorMultiplySingle()
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

		[Test]
		public void Vertex4b_OperatorDivideSingle()
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

		[Test]
		public void Vertex4b_OperatorScalarMultiply()
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

		[Test]
		public void Vertex4b_OperatorScalarDivide()
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

		[Test]
		public void Vertex4b_OperatorEquality()
		{
			Vertex4b v = Vertex4b.UnitX;

			Assert.IsTrue(v == Vertex4b.UnitX);
			Assert.IsFalse(v == Vertex4b.UnitY);
		}

		[Test]
		public void Vertex4b_OperatorInequality()
		{
			Vertex4b v = Vertex4b.UnitX;

			Assert.IsFalse(v != Vertex4b.UnitX);
			Assert.IsTrue(v != Vertex4b.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Vertex4b_CastToArray()
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

		[Test]
		public void Vertex4b_CastToVertex2f()
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

		[Test]
		public void Vertex4b_CastToVertex3f()
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

		[Test]
		public void Vertex4b_CastToVertex3d()
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

		[Test]
		public void Vertex4b_CastToVertex4f()
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

		[Test]
		public void Vertex4b_CastToVertex4d()
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

		[Test]
		public void Vertex4b_Module()
		{
			Assert.AreEqual(3.741657f, new Vertex4b((sbyte)1.0, (sbyte)2.0, (sbyte)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex4b((sbyte)2.0, (sbyte)5.0, (sbyte)7.0).Module(), 1e-4f);
		}

		[Test]
		public void Vertex4b_ModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex4b((sbyte)1.0, (sbyte)2.0, (sbyte)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex4b((sbyte)2.0, (sbyte)5.0, (sbyte)7.0).ModuleSquared(), 1e-4f);
		}

		[Test]
		public void Vertex4b_Normalize()
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

		[Test]
		public void Vertex4b_Normalized()
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

		[Test]
		public void Vertex4b_Min()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4b.Min(null));

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

		[Test]
		public void Vertex4b_Min_Unsafe()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4b.Min(null, 0));
			}

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

		[Test]
		public void Vertex4b_Max()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4b.Max(null));

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

		[Test]
		public void Vertex4b_Max_Unsafe()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4b.Max(null, 0));
			}

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

		[Test]
		public void Vertex4b_MinMax()
		{
			Vertex4b min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex4b.MinMax(null, out min, out max));

			Vertex4b[] v = new Vertex4b[] {
				new Vertex4b((sbyte)1.0f, (sbyte)13.0f, (sbyte)22.0f),
				new Vertex4b((sbyte)2.0f, (sbyte)12.0f, (sbyte)21.0f),
				new Vertex4b((sbyte)3.0f, (sbyte)11.0f, (sbyte)23.0f),
			};

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

		[Test]
		public void Vertex4b_MinMax_Unsafe()
		{
			Vertex4b min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4b.MinMax(null, 0, out min, out max));
			}

			Vertex4b[] v = new Vertex4b[] {
				new Vertex4b((sbyte)1.0f, (sbyte)13.0f, (sbyte)22.0f),
				new Vertex4b((sbyte)2.0f, (sbyte)12.0f, (sbyte)21.0f),
				new Vertex4b((sbyte)3.0f, (sbyte)11.0f, (sbyte)23.0f),
			};

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

		#endregion

		#region IEquatable Implementation

		[Test]
		public void Vertex4b_Equals_Vertex4b_AbsPrecision()
		{
			Vertex4b v = Vertex4b.UnitX;

			Assert.IsTrue(v.Equals(Vertex4b.UnitX, (sbyte)0));
			Assert.IsFalse(v.Equals(Vertex4b.UnitY, (sbyte)0));
			Assert.IsFalse(v.Equals(Vertex4b.UnitZ, (sbyte)0));

			// Defined vs Undefined equality
			Vertex4b v1 = new Vertex4b(1, 1, 1, 1);
			Vertex4b v2 = new Vertex4b(1, 1, 1, 0);

			Assert.IsFalse(v1.Equals(v2, (sbyte)0));
			Assert.IsFalse(v2.Equals(v1, (sbyte)0));

			// Undefined vs Undefined equality
			v1 = new Vertex4b(1, 1, 1, 0);
			v2 = new Vertex4b(1, 1, 1, 0);

			Assert.IsTrue(v1.Equals(v2, (sbyte)0));
			Assert.IsTrue(v2.Equals(v1, (sbyte)0));

			// Normalized equality
			v1 = new Vertex4b(1);
			v2 = new Vertex4b((sbyte)(1 + 1));

			Assert.IsTrue(v1.Equals(v2, (sbyte)0));
			Assert.IsTrue(v2.Equals(v1, (sbyte)0));
		}

		[Test]
		public void Vertex4b_Equals_Vertex4b()
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

		[Test]
		public void Vertex4b_Equals_Object()
		{
			Vertex4b v = Vertex4b.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex4b.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex4b.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex4b.UnitZ));
		}

		[Test]
		public void Vertex4b_GetHashCode()
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

		[Test]
		public void Vertex4b_ToString()
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

	[TestFixture, Category("Math")]
	class Vertex4usTest : Vertex3TestBase
	{
		#region Constructors

		[Test]
		public void Vertex4us_Constructor1()
		{
			Random random = new Random();
			ushort randomValue = (ushort)Next(random);
			
			Vertex4us v = new Vertex4us(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test]
		public void Vertex4us_Constructor2()
		{
			Random random = new Random();
			ushort randomValueX = (ushort)Next(random);
			ushort randomValueY = (ushort)Next(random);
			ushort randomValueZ = (ushort)Next(random);
			ushort randomValueW = (ushort)Next(random);
			Vertex4us v = new Vertex4us();

			Assert.DoesNotThrow(() => v = new Vertex4us(new ushort[] {
				randomValueX, randomValueY, randomValueZ
			}));

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

		[Test]
		public void Vertex4us_Constructor3()
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

		[Test]
		public void Vertex4us_MarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex4us)), Vertex4us.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test]
		public void Vertex4us_OperatorAdd()
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

		[Test]
		public void Vertex4us_OperatorSub()
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

		[Test]
		public void Vertex4us_OperatorMultiplySingle()
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

		[Test]
		public void Vertex4us_OperatorDivideSingle()
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

		[Test]
		public void Vertex4us_OperatorScalarMultiply()
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

		[Test]
		public void Vertex4us_OperatorScalarDivide()
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

		[Test]
		public void Vertex4us_OperatorEquality()
		{
			Vertex4us v = Vertex4us.UnitX;

			Assert.IsTrue(v == Vertex4us.UnitX);
			Assert.IsFalse(v == Vertex4us.UnitY);
		}

		[Test]
		public void Vertex4us_OperatorInequality()
		{
			Vertex4us v = Vertex4us.UnitX;

			Assert.IsFalse(v != Vertex4us.UnitX);
			Assert.IsTrue(v != Vertex4us.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Vertex4us_CastToArray()
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

		[Test]
		public void Vertex4us_CastToVertex2f()
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

		[Test]
		public void Vertex4us_CastToVertex3f()
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

		[Test]
		public void Vertex4us_CastToVertex3d()
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

		[Test]
		public void Vertex4us_CastToVertex4f()
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

		[Test]
		public void Vertex4us_CastToVertex4d()
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

		[Test]
		public void Vertex4us_Module()
		{
			Assert.AreEqual(3.741657f, new Vertex4us((ushort)1.0, (ushort)2.0, (ushort)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex4us((ushort)2.0, (ushort)5.0, (ushort)7.0).Module(), 1e-4f);
		}

		[Test]
		public void Vertex4us_ModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex4us((ushort)1.0, (ushort)2.0, (ushort)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex4us((ushort)2.0, (ushort)5.0, (ushort)7.0).ModuleSquared(), 1e-4f);
		}

		[Test]
		public void Vertex4us_Normalize()
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

		[Test]
		public void Vertex4us_Normalized()
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

		[Test]
		public void Vertex4us_Min()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4us.Min(null));

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

		[Test]
		public void Vertex4us_Min_Unsafe()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4us.Min(null, 0));
			}

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

		[Test]
		public void Vertex4us_Max()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4us.Max(null));

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

		[Test]
		public void Vertex4us_Max_Unsafe()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4us.Max(null, 0));
			}

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

		[Test]
		public void Vertex4us_MinMax()
		{
			Vertex4us min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex4us.MinMax(null, out min, out max));

			Vertex4us[] v = new Vertex4us[] {
				new Vertex4us((ushort)1.0f, (ushort)13.0f, (ushort)22.0f),
				new Vertex4us((ushort)2.0f, (ushort)12.0f, (ushort)21.0f),
				new Vertex4us((ushort)3.0f, (ushort)11.0f, (ushort)23.0f),
			};

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

		[Test]
		public void Vertex4us_MinMax_Unsafe()
		{
			Vertex4us min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4us.MinMax(null, 0, out min, out max));
			}

			Vertex4us[] v = new Vertex4us[] {
				new Vertex4us((ushort)1.0f, (ushort)13.0f, (ushort)22.0f),
				new Vertex4us((ushort)2.0f, (ushort)12.0f, (ushort)21.0f),
				new Vertex4us((ushort)3.0f, (ushort)11.0f, (ushort)23.0f),
			};

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

		#endregion

		#region IEquatable Implementation

		[Test]
		public void Vertex4us_Equals_Vertex4us_AbsPrecision()
		{
			Vertex4us v = Vertex4us.UnitX;

			Assert.IsTrue(v.Equals(Vertex4us.UnitX, (ushort)0));
			Assert.IsFalse(v.Equals(Vertex4us.UnitY, (ushort)0));
			Assert.IsFalse(v.Equals(Vertex4us.UnitZ, (ushort)0));

			// Defined vs Undefined equality
			Vertex4us v1 = new Vertex4us(1, 1, 1, 1);
			Vertex4us v2 = new Vertex4us(1, 1, 1, 0);

			Assert.IsFalse(v1.Equals(v2, (ushort)0));
			Assert.IsFalse(v2.Equals(v1, (ushort)0));

			// Undefined vs Undefined equality
			v1 = new Vertex4us(1, 1, 1, 0);
			v2 = new Vertex4us(1, 1, 1, 0);

			Assert.IsTrue(v1.Equals(v2, (ushort)0));
			Assert.IsTrue(v2.Equals(v1, (ushort)0));

			// Normalized equality
			v1 = new Vertex4us(1);
			v2 = new Vertex4us((ushort)(1 + 1));

			Assert.IsTrue(v1.Equals(v2, (ushort)0));
			Assert.IsTrue(v2.Equals(v1, (ushort)0));
		}

		[Test]
		public void Vertex4us_Equals_Vertex4us()
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

		[Test]
		public void Vertex4us_Equals_Object()
		{
			Vertex4us v = Vertex4us.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex4us.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex4us.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex4us.UnitZ));
		}

		[Test]
		public void Vertex4us_GetHashCode()
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

		[Test]
		public void Vertex4us_ToString()
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

	[TestFixture, Category("Math")]
	class Vertex4sTest : Vertex3TestBase
	{
		#region Constructors

		[Test]
		public void Vertex4s_Constructor1()
		{
			Random random = new Random();
			short randomValue = (short)Next(random);
			
			Vertex4s v = new Vertex4s(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test]
		public void Vertex4s_Constructor2()
		{
			Random random = new Random();
			short randomValueX = (short)Next(random);
			short randomValueY = (short)Next(random);
			short randomValueZ = (short)Next(random);
			short randomValueW = (short)Next(random);
			Vertex4s v = new Vertex4s();

			Assert.DoesNotThrow(() => v = new Vertex4s(new short[] {
				randomValueX, randomValueY, randomValueZ
			}));

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

		[Test]
		public void Vertex4s_Constructor3()
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

		[Test]
		public void Vertex4s_MarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex4s)), Vertex4s.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test]
		public void Vertex4s_OperatorNegate()
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
		[Test]
		public void Vertex4s_OperatorAdd()
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

		[Test]
		public void Vertex4s_OperatorSub()
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

		[Test]
		public void Vertex4s_OperatorMultiplySingle()
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

		[Test]
		public void Vertex4s_OperatorDivideSingle()
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

		[Test]
		public void Vertex4s_OperatorScalarMultiply()
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

		[Test]
		public void Vertex4s_OperatorScalarDivide()
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

		[Test]
		public void Vertex4s_OperatorEquality()
		{
			Vertex4s v = Vertex4s.UnitX;

			Assert.IsTrue(v == Vertex4s.UnitX);
			Assert.IsFalse(v == Vertex4s.UnitY);
		}

		[Test]
		public void Vertex4s_OperatorInequality()
		{
			Vertex4s v = Vertex4s.UnitX;

			Assert.IsFalse(v != Vertex4s.UnitX);
			Assert.IsTrue(v != Vertex4s.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Vertex4s_CastToArray()
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

		[Test]
		public void Vertex4s_CastToVertex2f()
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

		[Test]
		public void Vertex4s_CastToVertex3f()
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

		[Test]
		public void Vertex4s_CastToVertex3d()
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

		[Test]
		public void Vertex4s_CastToVertex4f()
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

		[Test]
		public void Vertex4s_CastToVertex4d()
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

		[Test]
		public void Vertex4s_Module()
		{
			Assert.AreEqual(3.741657f, new Vertex4s((short)1.0, (short)2.0, (short)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex4s((short)2.0, (short)5.0, (short)7.0).Module(), 1e-4f);
		}

		[Test]
		public void Vertex4s_ModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex4s((short)1.0, (short)2.0, (short)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex4s((short)2.0, (short)5.0, (short)7.0).ModuleSquared(), 1e-4f);
		}

		[Test]
		public void Vertex4s_Normalize()
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

		[Test]
		public void Vertex4s_Normalized()
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

		[Test]
		public void Vertex4s_Min()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4s.Min(null));

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

		[Test]
		public void Vertex4s_Min_Unsafe()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4s.Min(null, 0));
			}

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

		[Test]
		public void Vertex4s_Max()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4s.Max(null));

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

		[Test]
		public void Vertex4s_Max_Unsafe()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4s.Max(null, 0));
			}

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

		[Test]
		public void Vertex4s_MinMax()
		{
			Vertex4s min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex4s.MinMax(null, out min, out max));

			Vertex4s[] v = new Vertex4s[] {
				new Vertex4s((short)1.0f, (short)13.0f, (short)22.0f),
				new Vertex4s((short)2.0f, (short)12.0f, (short)21.0f),
				new Vertex4s((short)3.0f, (short)11.0f, (short)23.0f),
			};

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

		[Test]
		public void Vertex4s_MinMax_Unsafe()
		{
			Vertex4s min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4s.MinMax(null, 0, out min, out max));
			}

			Vertex4s[] v = new Vertex4s[] {
				new Vertex4s((short)1.0f, (short)13.0f, (short)22.0f),
				new Vertex4s((short)2.0f, (short)12.0f, (short)21.0f),
				new Vertex4s((short)3.0f, (short)11.0f, (short)23.0f),
			};

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

		#endregion

		#region IEquatable Implementation

		[Test]
		public void Vertex4s_Equals_Vertex4s_AbsPrecision()
		{
			Vertex4s v = Vertex4s.UnitX;

			Assert.IsTrue(v.Equals(Vertex4s.UnitX, (short)0));
			Assert.IsFalse(v.Equals(Vertex4s.UnitY, (short)0));
			Assert.IsFalse(v.Equals(Vertex4s.UnitZ, (short)0));

			// Defined vs Undefined equality
			Vertex4s v1 = new Vertex4s(1, 1, 1, 1);
			Vertex4s v2 = new Vertex4s(1, 1, 1, 0);

			Assert.IsFalse(v1.Equals(v2, (short)0));
			Assert.IsFalse(v2.Equals(v1, (short)0));

			// Undefined vs Undefined equality
			v1 = new Vertex4s(1, 1, 1, 0);
			v2 = new Vertex4s(1, 1, 1, 0);

			Assert.IsTrue(v1.Equals(v2, (short)0));
			Assert.IsTrue(v2.Equals(v1, (short)0));

			// Normalized equality
			v1 = new Vertex4s(1);
			v2 = new Vertex4s((short)(1 + 1));

			Assert.IsTrue(v1.Equals(v2, (short)0));
			Assert.IsTrue(v2.Equals(v1, (short)0));
		}

		[Test]
		public void Vertex4s_Equals_Vertex4s()
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

		[Test]
		public void Vertex4s_Equals_Object()
		{
			Vertex4s v = Vertex4s.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex4s.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex4s.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex4s.UnitZ));
		}

		[Test]
		public void Vertex4s_GetHashCode()
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

		[Test]
		public void Vertex4s_ToString()
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

	[TestFixture, Category("Math")]
	class Vertex4uiTest : Vertex3TestBase
	{
		#region Constructors

		[Test]
		public void Vertex4ui_Constructor1()
		{
			Random random = new Random();
			uint randomValue = (uint)Next(random);
			
			Vertex4ui v = new Vertex4ui(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test]
		public void Vertex4ui_Constructor2()
		{
			Random random = new Random();
			uint randomValueX = (uint)Next(random);
			uint randomValueY = (uint)Next(random);
			uint randomValueZ = (uint)Next(random);
			uint randomValueW = (uint)Next(random);
			Vertex4ui v = new Vertex4ui();

			Assert.DoesNotThrow(() => v = new Vertex4ui(new uint[] {
				randomValueX, randomValueY, randomValueZ
			}));

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

		[Test]
		public void Vertex4ui_Constructor3()
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

		[Test]
		public void Vertex4ui_MarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex4ui)), Vertex4ui.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test]
		public void Vertex4ui_OperatorAdd()
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

		[Test]
		public void Vertex4ui_OperatorSub()
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

		[Test]
		public void Vertex4ui_OperatorMultiplySingle()
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

		[Test]
		public void Vertex4ui_OperatorDivideSingle()
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

		[Test]
		public void Vertex4ui_OperatorScalarMultiply()
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

		[Test]
		public void Vertex4ui_OperatorScalarDivide()
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

		[Test]
		public void Vertex4ui_OperatorEquality()
		{
			Vertex4ui v = Vertex4ui.UnitX;

			Assert.IsTrue(v == Vertex4ui.UnitX);
			Assert.IsFalse(v == Vertex4ui.UnitY);
		}

		[Test]
		public void Vertex4ui_OperatorInequality()
		{
			Vertex4ui v = Vertex4ui.UnitX;

			Assert.IsFalse(v != Vertex4ui.UnitX);
			Assert.IsTrue(v != Vertex4ui.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Vertex4ui_CastToArray()
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

		[Test]
		public void Vertex4ui_CastToVertex2f()
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

		[Test]
		public void Vertex4ui_CastToVertex3f()
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

		[Test]
		public void Vertex4ui_CastToVertex3d()
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

		[Test]
		public void Vertex4ui_CastToVertex4f()
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

		[Test]
		public void Vertex4ui_CastToVertex4d()
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

		[Test]
		public void Vertex4ui_Module()
		{
			Assert.AreEqual(3.741657f, new Vertex4ui((uint)1.0, (uint)2.0, (uint)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex4ui((uint)2.0, (uint)5.0, (uint)7.0).Module(), 1e-4f);
		}

		[Test]
		public void Vertex4ui_ModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex4ui((uint)1.0, (uint)2.0, (uint)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex4ui((uint)2.0, (uint)5.0, (uint)7.0).ModuleSquared(), 1e-4f);
		}

		[Test]
		public void Vertex4ui_Normalize()
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

		[Test]
		public void Vertex4ui_Normalized()
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

		[Test]
		public void Vertex4ui_Min()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4ui.Min(null));

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

		[Test]
		public void Vertex4ui_Min_Unsafe()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4ui.Min(null, 0));
			}

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

		[Test]
		public void Vertex4ui_Max()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4ui.Max(null));

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

		[Test]
		public void Vertex4ui_Max_Unsafe()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4ui.Max(null, 0));
			}

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

		[Test]
		public void Vertex4ui_MinMax()
		{
			Vertex4ui min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex4ui.MinMax(null, out min, out max));

			Vertex4ui[] v = new Vertex4ui[] {
				new Vertex4ui((uint)1.0f, (uint)13.0f, (uint)22.0f),
				new Vertex4ui((uint)2.0f, (uint)12.0f, (uint)21.0f),
				new Vertex4ui((uint)3.0f, (uint)11.0f, (uint)23.0f),
			};

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

		[Test]
		public void Vertex4ui_MinMax_Unsafe()
		{
			Vertex4ui min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4ui.MinMax(null, 0, out min, out max));
			}

			Vertex4ui[] v = new Vertex4ui[] {
				new Vertex4ui((uint)1.0f, (uint)13.0f, (uint)22.0f),
				new Vertex4ui((uint)2.0f, (uint)12.0f, (uint)21.0f),
				new Vertex4ui((uint)3.0f, (uint)11.0f, (uint)23.0f),
			};

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

		#endregion

		#region IEquatable Implementation

		[Test]
		public void Vertex4ui_Equals_Vertex4ui_AbsPrecision()
		{
			Vertex4ui v = Vertex4ui.UnitX;

			Assert.IsTrue(v.Equals(Vertex4ui.UnitX, (uint)0));
			Assert.IsFalse(v.Equals(Vertex4ui.UnitY, (uint)0));
			Assert.IsFalse(v.Equals(Vertex4ui.UnitZ, (uint)0));

			// Defined vs Undefined equality
			Vertex4ui v1 = new Vertex4ui(1, 1, 1, 1);
			Vertex4ui v2 = new Vertex4ui(1, 1, 1, 0);

			Assert.IsFalse(v1.Equals(v2, (uint)0));
			Assert.IsFalse(v2.Equals(v1, (uint)0));

			// Undefined vs Undefined equality
			v1 = new Vertex4ui(1, 1, 1, 0);
			v2 = new Vertex4ui(1, 1, 1, 0);

			Assert.IsTrue(v1.Equals(v2, (uint)0));
			Assert.IsTrue(v2.Equals(v1, (uint)0));

			// Normalized equality
			v1 = new Vertex4ui(1);
			v2 = new Vertex4ui((uint)(1 + 1));

			Assert.IsTrue(v1.Equals(v2, (uint)0));
			Assert.IsTrue(v2.Equals(v1, (uint)0));
		}

		[Test]
		public void Vertex4ui_Equals_Vertex4ui()
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

		[Test]
		public void Vertex4ui_Equals_Object()
		{
			Vertex4ui v = Vertex4ui.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex4ui.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex4ui.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex4ui.UnitZ));
		}

		[Test]
		public void Vertex4ui_GetHashCode()
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

		[Test]
		public void Vertex4ui_ToString()
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

	[TestFixture, Category("Math")]
	class Vertex4iTest : Vertex3TestBase
	{
		#region Constructors

		[Test]
		public void Vertex4i_Constructor1()
		{
			Random random = new Random();
			int randomValue = (int)Next(random);
			
			Vertex4i v = new Vertex4i(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test]
		public void Vertex4i_Constructor2()
		{
			Random random = new Random();
			int randomValueX = (int)Next(random);
			int randomValueY = (int)Next(random);
			int randomValueZ = (int)Next(random);
			int randomValueW = (int)Next(random);
			Vertex4i v = new Vertex4i();

			Assert.DoesNotThrow(() => v = new Vertex4i(new int[] {
				randomValueX, randomValueY, randomValueZ
			}));

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

		[Test]
		public void Vertex4i_Constructor3()
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

		[Test]
		public void Vertex4i_MarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex4i)), Vertex4i.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test]
		public void Vertex4i_OperatorNegate()
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
		[Test]
		public void Vertex4i_OperatorAdd()
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

		[Test]
		public void Vertex4i_OperatorSub()
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

		[Test]
		public void Vertex4i_OperatorMultiplySingle()
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

		[Test]
		public void Vertex4i_OperatorDivideSingle()
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

		[Test]
		public void Vertex4i_OperatorScalarMultiply()
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

		[Test]
		public void Vertex4i_OperatorScalarDivide()
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

		[Test]
		public void Vertex4i_OperatorEquality()
		{
			Vertex4i v = Vertex4i.UnitX;

			Assert.IsTrue(v == Vertex4i.UnitX);
			Assert.IsFalse(v == Vertex4i.UnitY);
		}

		[Test]
		public void Vertex4i_OperatorInequality()
		{
			Vertex4i v = Vertex4i.UnitX;

			Assert.IsFalse(v != Vertex4i.UnitX);
			Assert.IsTrue(v != Vertex4i.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Vertex4i_CastToArray()
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

		[Test]
		public void Vertex4i_CastToVertex2f()
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

		[Test]
		public void Vertex4i_CastToVertex3f()
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

		[Test]
		public void Vertex4i_CastToVertex3d()
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

		[Test]
		public void Vertex4i_CastToVertex4f()
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

		[Test]
		public void Vertex4i_CastToVertex4d()
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

		[Test]
		public void Vertex4i_Module()
		{
			Assert.AreEqual(3.741657f, new Vertex4i((int)1.0, (int)2.0, (int)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex4i((int)2.0, (int)5.0, (int)7.0).Module(), 1e-4f);
		}

		[Test]
		public void Vertex4i_ModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex4i((int)1.0, (int)2.0, (int)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex4i((int)2.0, (int)5.0, (int)7.0).ModuleSquared(), 1e-4f);
		}

		[Test]
		public void Vertex4i_Normalize()
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

		[Test]
		public void Vertex4i_Normalized()
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

		[Test]
		public void Vertex4i_Min()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4i.Min(null));

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

		[Test]
		public void Vertex4i_Min_Unsafe()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4i.Min(null, 0));
			}

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

		[Test]
		public void Vertex4i_Max()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4i.Max(null));

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

		[Test]
		public void Vertex4i_Max_Unsafe()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4i.Max(null, 0));
			}

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

		[Test]
		public void Vertex4i_MinMax()
		{
			Vertex4i min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex4i.MinMax(null, out min, out max));

			Vertex4i[] v = new Vertex4i[] {
				new Vertex4i((int)1.0f, (int)13.0f, (int)22.0f),
				new Vertex4i((int)2.0f, (int)12.0f, (int)21.0f),
				new Vertex4i((int)3.0f, (int)11.0f, (int)23.0f),
			};

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

		[Test]
		public void Vertex4i_MinMax_Unsafe()
		{
			Vertex4i min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4i.MinMax(null, 0, out min, out max));
			}

			Vertex4i[] v = new Vertex4i[] {
				new Vertex4i((int)1.0f, (int)13.0f, (int)22.0f),
				new Vertex4i((int)2.0f, (int)12.0f, (int)21.0f),
				new Vertex4i((int)3.0f, (int)11.0f, (int)23.0f),
			};

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

		#endregion

		#region IEquatable Implementation

		[Test]
		public void Vertex4i_Equals_Vertex4i_AbsPrecision()
		{
			Vertex4i v = Vertex4i.UnitX;

			Assert.IsTrue(v.Equals(Vertex4i.UnitX, (int)0));
			Assert.IsFalse(v.Equals(Vertex4i.UnitY, (int)0));
			Assert.IsFalse(v.Equals(Vertex4i.UnitZ, (int)0));

			// Defined vs Undefined equality
			Vertex4i v1 = new Vertex4i(1, 1, 1, 1);
			Vertex4i v2 = new Vertex4i(1, 1, 1, 0);

			Assert.IsFalse(v1.Equals(v2, (int)0));
			Assert.IsFalse(v2.Equals(v1, (int)0));

			// Undefined vs Undefined equality
			v1 = new Vertex4i(1, 1, 1, 0);
			v2 = new Vertex4i(1, 1, 1, 0);

			Assert.IsTrue(v1.Equals(v2, (int)0));
			Assert.IsTrue(v2.Equals(v1, (int)0));

			// Normalized equality
			v1 = new Vertex4i(1);
			v2 = new Vertex4i((int)(1 + 1));

			Assert.IsTrue(v1.Equals(v2, (int)0));
			Assert.IsTrue(v2.Equals(v1, (int)0));
		}

		[Test]
		public void Vertex4i_Equals_Vertex4i()
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

		[Test]
		public void Vertex4i_Equals_Object()
		{
			Vertex4i v = Vertex4i.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex4i.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex4i.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex4i.UnitZ));
		}

		[Test]
		public void Vertex4i_GetHashCode()
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

		[Test]
		public void Vertex4i_ToString()
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

	[TestFixture, Category("Math")]
	class Vertex4fTest : Vertex3TestBase
	{
		#region Constructors

		[Test]
		public void Vertex4f_Constructor1()
		{
			Random random = new Random();
			float randomValue = (float)Next(random);
			
			Vertex4f v = new Vertex4f(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test]
		public void Vertex4f_Constructor2()
		{
			Random random = new Random();
			float randomValueX = (float)Next(random);
			float randomValueY = (float)Next(random);
			float randomValueZ = (float)Next(random);
			float randomValueW = (float)Next(random);
			Vertex4f v = new Vertex4f();

			Assert.DoesNotThrow(() => v = new Vertex4f(new float[] {
				randomValueX, randomValueY, randomValueZ
			}));

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

		[Test]
		public void Vertex4f_Constructor3()
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

		[Test]
		public void Vertex4f_MarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex4f)), Vertex4f.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test]
		public void Vertex4f_OperatorNegate()
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
		[Test]
		public void Vertex4f_OperatorAdd()
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

		[Test]
		public void Vertex4f_OperatorSub()
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

		[Test]
		public void Vertex4f_OperatorMultiplySingle()
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

		[Test]
		public void Vertex4f_OperatorDivideSingle()
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

		[Test]
		public void Vertex4f_OperatorEquality()
		{
			Vertex4f v = Vertex4f.UnitX;

			Assert.IsTrue(v == Vertex4f.UnitX);
			Assert.IsFalse(v == Vertex4f.UnitY);
		}

		[Test]
		public void Vertex4f_OperatorInequality()
		{
			Vertex4f v = Vertex4f.UnitX;

			Assert.IsFalse(v != Vertex4f.UnitX);
			Assert.IsTrue(v != Vertex4f.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Vertex4f_CastToArray()
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

		[Test]
		public void Vertex4f_CastToVertex2f()
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

		[Test]
		public void Vertex4f_CastToVertex3f()
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

		[Test]
		public void Vertex4f_CastToVertex3d()
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

		[Test]
		public void Vertex4f_CastToVertex4f()
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

		[Test]
		public void Vertex4f_CastToVertex4d()
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

		[Test]
		public void Vertex4f_Module()
		{
			Assert.AreEqual(3.741657f, new Vertex4f((float)1.0, (float)2.0, (float)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex4f((float)2.0, (float)5.0, (float)7.0).Module(), 1e-4f);
		}

		[Test]
		public void Vertex4f_ModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex4f((float)1.0, (float)2.0, (float)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex4f((float)2.0, (float)5.0, (float)7.0).ModuleSquared(), 1e-4f);
		}

		[Test]
		public void Vertex4f_Normalize()
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

		[Test]
		public void Vertex4f_Normalized()
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

		[Test]
		public void Vertex4f_Min()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4f.Min(null));

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

		[Test]
		public void Vertex4f_Min_Unsafe()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4f.Min(null, 0));
			}

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

		[Test]
		public void Vertex4f_Max()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4f.Max(null));

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

		[Test]
		public void Vertex4f_Max_Unsafe()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4f.Max(null, 0));
			}

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

		[Test]
		public void Vertex4f_MinMax()
		{
			Vertex4f min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex4f.MinMax(null, out min, out max));

			Vertex4f[] v = new Vertex4f[] {
				new Vertex4f((float)1.0f, (float)13.0f, (float)22.0f),
				new Vertex4f((float)2.0f, (float)12.0f, (float)21.0f),
				new Vertex4f((float)3.0f, (float)11.0f, (float)23.0f),
			};

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

		[Test]
		public void Vertex4f_MinMax_Unsafe()
		{
			Vertex4f min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4f.MinMax(null, 0, out min, out max));
			}

			Vertex4f[] v = new Vertex4f[] {
				new Vertex4f((float)1.0f, (float)13.0f, (float)22.0f),
				new Vertex4f((float)2.0f, (float)12.0f, (float)21.0f),
				new Vertex4f((float)3.0f, (float)11.0f, (float)23.0f),
			};

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

		#endregion

		#region IEquatable Implementation

		[Test]
		public void Vertex4f_Equals_Vertex4f_AbsPrecision()
		{
			Vertex4f v = Vertex4f.UnitX;

			Assert.IsTrue(v.Equals(Vertex4f.UnitX, (float)1e-5));
			Assert.IsFalse(v.Equals(Vertex4f.UnitY, (float)1e-5));
			Assert.IsFalse(v.Equals(Vertex4f.UnitZ, (float)1e-5));

			// Defined vs Undefined equality
			Vertex4f v1 = new Vertex4f(1.0f, 1.0f, 1.0f, 1.0f);
			Vertex4f v2 = new Vertex4f(1.0f, 1.0f, 1.0f, 0.0f);

			Assert.IsFalse(v1.Equals(v2, (float)1e-5));
			Assert.IsFalse(v2.Equals(v1, (float)1e-5));

			// Undefined vs Undefined equality
			v1 = new Vertex4f(1.0f, 1.0f, 1.0f, 0.0f);
			v2 = new Vertex4f(1.0f, 1.0f, 1.0f, 0.0f);

			Assert.IsTrue(v1.Equals(v2, (float)1e-5));
			Assert.IsTrue(v2.Equals(v1, (float)1e-5));

			// Normalized equality
			v1 = new Vertex4f(1.0f);
			v2 = new Vertex4f((float)(1.0f + 1.0f));

			Assert.IsTrue(v1.Equals(v2, (float)1e-5));
			Assert.IsTrue(v2.Equals(v1, (float)1e-5));
		}

		[Test]
		public void Vertex4f_Equals_Vertex4f()
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

		[Test]
		public void Vertex4f_Equals_Object()
		{
			Vertex4f v = Vertex4f.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex4f.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex4f.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex4f.UnitZ));
		}

		[Test]
		public void Vertex4f_GetHashCode()
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

		[Test]
		public void Vertex4f_ToString()
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

	[TestFixture, Category("Math")]
	class Vertex4dTest : Vertex3TestBase
	{
		#region Constructors

		[Test]
		public void Vertex4d_Constructor1()
		{
			Random random = new Random();
			double randomValue = (double)Next(random);
			
			Vertex4d v = new Vertex4d(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test]
		public void Vertex4d_Constructor2()
		{
			Random random = new Random();
			double randomValueX = (double)Next(random);
			double randomValueY = (double)Next(random);
			double randomValueZ = (double)Next(random);
			double randomValueW = (double)Next(random);
			Vertex4d v = new Vertex4d();

			Assert.DoesNotThrow(() => v = new Vertex4d(new double[] {
				randomValueX, randomValueY, randomValueZ
			}));

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

		[Test]
		public void Vertex4d_Constructor3()
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

		[Test]
		public void Vertex4d_MarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex4d)), Vertex4d.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test]
		public void Vertex4d_OperatorNegate()
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
		[Test]
		public void Vertex4d_OperatorAdd()
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

		[Test]
		public void Vertex4d_OperatorSub()
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

		[Test]
		public void Vertex4d_OperatorMultiplySingle()
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

		[Test]
		public void Vertex4d_OperatorDivideSingle()
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

		[Test]
		public void Vertex4d_OperatorEquality()
		{
			Vertex4d v = Vertex4d.UnitX;

			Assert.IsTrue(v == Vertex4d.UnitX);
			Assert.IsFalse(v == Vertex4d.UnitY);
		}

		[Test]
		public void Vertex4d_OperatorInequality()
		{
			Vertex4d v = Vertex4d.UnitX;

			Assert.IsFalse(v != Vertex4d.UnitX);
			Assert.IsTrue(v != Vertex4d.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Vertex4d_CastToArray()
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

		[Test]
		public void Vertex4d_CastToVertex2f()
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

		[Test]
		public void Vertex4d_CastToVertex3f()
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

		[Test]
		public void Vertex4d_CastToVertex3d()
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

		[Test]
		public void Vertex4d_CastToVertex4f()
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

		[Test]
		public void Vertex4d_CastToVertex4d()
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

		[Test]
		public void Vertex4d_Module()
		{
			Assert.AreEqual(3.741657f, new Vertex4d((double)1.0, (double)2.0, (double)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex4d((double)2.0, (double)5.0, (double)7.0).Module(), 1e-4f);
		}

		[Test]
		public void Vertex4d_ModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex4d((double)1.0, (double)2.0, (double)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex4d((double)2.0, (double)5.0, (double)7.0).ModuleSquared(), 1e-4f);
		}

		[Test]
		public void Vertex4d_Normalize()
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

		[Test]
		public void Vertex4d_Normalized()
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

		[Test]
		public void Vertex4d_Min()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4d.Min(null));

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

		[Test]
		public void Vertex4d_Min_Unsafe()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4d.Min(null, 0));
			}

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

		[Test]
		public void Vertex4d_Max()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4d.Max(null));

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

		[Test]
		public void Vertex4d_Max_Unsafe()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4d.Max(null, 0));
			}

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

		[Test]
		public void Vertex4d_MinMax()
		{
			Vertex4d min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex4d.MinMax(null, out min, out max));

			Vertex4d[] v = new Vertex4d[] {
				new Vertex4d((double)1.0f, (double)13.0f, (double)22.0f),
				new Vertex4d((double)2.0f, (double)12.0f, (double)21.0f),
				new Vertex4d((double)3.0f, (double)11.0f, (double)23.0f),
			};

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

		[Test]
		public void Vertex4d_MinMax_Unsafe()
		{
			Vertex4d min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4d.MinMax(null, 0, out min, out max));
			}

			Vertex4d[] v = new Vertex4d[] {
				new Vertex4d((double)1.0f, (double)13.0f, (double)22.0f),
				new Vertex4d((double)2.0f, (double)12.0f, (double)21.0f),
				new Vertex4d((double)3.0f, (double)11.0f, (double)23.0f),
			};

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

		#endregion

		#region IEquatable Implementation

		[Test]
		public void Vertex4d_Equals_Vertex4d_AbsPrecision()
		{
			Vertex4d v = Vertex4d.UnitX;

			Assert.IsTrue(v.Equals(Vertex4d.UnitX, (double)1e-10));
			Assert.IsFalse(v.Equals(Vertex4d.UnitY, (double)1e-10));
			Assert.IsFalse(v.Equals(Vertex4d.UnitZ, (double)1e-10));

			// Defined vs Undefined equality
			Vertex4d v1 = new Vertex4d(1.0, 1.0, 1.0, 1.0);
			Vertex4d v2 = new Vertex4d(1.0, 1.0, 1.0, 0.0);

			Assert.IsFalse(v1.Equals(v2, (double)1e-10));
			Assert.IsFalse(v2.Equals(v1, (double)1e-10));

			// Undefined vs Undefined equality
			v1 = new Vertex4d(1.0, 1.0, 1.0, 0.0);
			v2 = new Vertex4d(1.0, 1.0, 1.0, 0.0);

			Assert.IsTrue(v1.Equals(v2, (double)1e-10));
			Assert.IsTrue(v2.Equals(v1, (double)1e-10));

			// Normalized equality
			v1 = new Vertex4d(1.0);
			v2 = new Vertex4d((double)(1.0 + 1.0));

			Assert.IsTrue(v1.Equals(v2, (double)1e-10));
			Assert.IsTrue(v2.Equals(v1, (double)1e-10));
		}

		[Test]
		public void Vertex4d_Equals_Vertex4d()
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

		[Test]
		public void Vertex4d_Equals_Object()
		{
			Vertex4d v = Vertex4d.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex4d.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex4d.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex4d.UnitZ));
		}

		[Test]
		public void Vertex4d_GetHashCode()
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

		[Test]
		public void Vertex4d_ToString()
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

	[TestFixture, Category("Math")]
	class Vertex4hfTest : Vertex3TestBase
	{
		#region Constructors

		[Test]
		public void Vertex4hf_Constructor1()
		{
			Random random = new Random();
			HalfFloat randomValue = (HalfFloat)Next(random);
			
			Vertex4hf v = new Vertex4hf(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test]
		public void Vertex4hf_Constructor2()
		{
			Random random = new Random();
			HalfFloat randomValueX = (HalfFloat)Next(random);
			HalfFloat randomValueY = (HalfFloat)Next(random);
			HalfFloat randomValueZ = (HalfFloat)Next(random);
			HalfFloat randomValueW = (HalfFloat)Next(random);
			Vertex4hf v = new Vertex4hf();

			Assert.DoesNotThrow(() => v = new Vertex4hf(new HalfFloat[] {
				randomValueX, randomValueY, randomValueZ
			}));

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

		[Test]
		public void Vertex4hf_Constructor3()
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

		[Test]
		public void Vertex4hf_MarshalSize()
		{
			Assert.AreEqual(Marshal.SizeOf(typeof(Vertex4hf)), Vertex4hf.Size);
		}

		#endregion

		#region Arithmetic Operators

		[Test]
		public void Vertex4hf_OperatorAdd()
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

		[Test]
		public void Vertex4hf_OperatorSub()
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

		[Test]
		public void Vertex4hf_OperatorMultiplySingle()
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

		[Test]
		public void Vertex4hf_OperatorDivideSingle()
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

		[Test]
		public void Vertex4hf_OperatorEquality()
		{
			Vertex4hf v = Vertex4hf.UnitX;

			Assert.IsTrue(v == Vertex4hf.UnitX);
			Assert.IsFalse(v == Vertex4hf.UnitY);
		}

		[Test]
		public void Vertex4hf_OperatorInequality()
		{
			Vertex4hf v = Vertex4hf.UnitX;

			Assert.IsFalse(v != Vertex4hf.UnitX);
			Assert.IsTrue(v != Vertex4hf.UnitY);
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Vertex4hf_CastToArray()
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

		[Test]
		public void Vertex4hf_CastToVertex2f()
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

		[Test]
		public void Vertex4hf_CastToVertex3f()
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

		[Test]
		public void Vertex4hf_CastToVertex3d()
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

		[Test]
		public void Vertex4hf_CastToVertex4f()
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

		[Test]
		public void Vertex4hf_CastToVertex4d()
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

		[Test]
		public void Vertex4hf_Module()
		{
			Assert.AreEqual(3.741657f, new Vertex4hf((HalfFloat)1.0, (HalfFloat)2.0, (HalfFloat)3.0).Module(), 1e-4f);
			Assert.AreEqual(8.83176f, new Vertex4hf((HalfFloat)2.0, (HalfFloat)5.0, (HalfFloat)7.0).Module(), 1e-4f);
		}

		[Test]
		public void Vertex4hf_ModuleSquared()
		{
			Assert.AreEqual(14f, new Vertex4hf((HalfFloat)1.0, (HalfFloat)2.0, (HalfFloat)3.0).ModuleSquared(), 1e-4f);
			Assert.AreEqual(78f, new Vertex4hf((HalfFloat)2.0, (HalfFloat)5.0, (HalfFloat)7.0).ModuleSquared(), 1e-4f);
		}

		[Test]
		public void Vertex4hf_Normalize()
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

		[Test]
		public void Vertex4hf_Normalized()
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

		[Test]
		public void Vertex4hf_Min()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4hf.Min(null));

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

		[Test]
		public void Vertex4hf_Min_Unsafe()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4hf.Min(null, 0));
			}

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

		[Test]
		public void Vertex4hf_Max()
		{
			Assert.Throws<ArgumentNullException>(() => Vertex4hf.Max(null));

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

		[Test]
		public void Vertex4hf_Max_Unsafe()
		{
			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4hf.Max(null, 0));
			}

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

		[Test]
		public void Vertex4hf_MinMax()
		{
			Vertex4hf min, max;

			Assert.Throws<ArgumentNullException>(() => Vertex4hf.MinMax(null, out min, out max));

			Vertex4hf[] v = new Vertex4hf[] {
				new Vertex4hf((HalfFloat)1.0f, (HalfFloat)13.0f, (HalfFloat)22.0f),
				new Vertex4hf((HalfFloat)2.0f, (HalfFloat)12.0f, (HalfFloat)21.0f),
				new Vertex4hf((HalfFloat)3.0f, (HalfFloat)11.0f, (HalfFloat)23.0f),
			};

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

		[Test]
		public void Vertex4hf_MinMax_Unsafe()
		{
			Vertex4hf min, max;

			unsafe {
				Assert.Throws<ArgumentNullException>(() => Vertex4hf.MinMax(null, 0, out min, out max));
			}

			Vertex4hf[] v = new Vertex4hf[] {
				new Vertex4hf((HalfFloat)1.0f, (HalfFloat)13.0f, (HalfFloat)22.0f),
				new Vertex4hf((HalfFloat)2.0f, (HalfFloat)12.0f, (HalfFloat)21.0f),
				new Vertex4hf((HalfFloat)3.0f, (HalfFloat)11.0f, (HalfFloat)23.0f),
			};

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

		#endregion

		#region IEquatable Implementation

		[Test]
		public void Vertex4hf_Equals_Vertex4hf_AbsPrecision()
		{
			Vertex4hf v = Vertex4hf.UnitX;

			Assert.IsTrue(v.Equals(Vertex4hf.UnitX, (HalfFloat)(HalfFloat)1e-3));
			Assert.IsFalse(v.Equals(Vertex4hf.UnitY, (HalfFloat)(HalfFloat)1e-3));
			Assert.IsFalse(v.Equals(Vertex4hf.UnitZ, (HalfFloat)(HalfFloat)1e-3));

			// Defined vs Undefined equality
			Vertex4hf v1 = new Vertex4hf((HalfFloat)1.0f, (HalfFloat)1.0f, (HalfFloat)1.0f, (HalfFloat)1.0f);
			Vertex4hf v2 = new Vertex4hf((HalfFloat)1.0f, (HalfFloat)1.0f, (HalfFloat)1.0f, (HalfFloat)0.0f);

			Assert.IsFalse(v1.Equals(v2, (HalfFloat)(HalfFloat)1e-3));
			Assert.IsFalse(v2.Equals(v1, (HalfFloat)(HalfFloat)1e-3));

			// Undefined vs Undefined equality
			v1 = new Vertex4hf((HalfFloat)1.0f, (HalfFloat)1.0f, (HalfFloat)1.0f, (HalfFloat)0.0f);
			v2 = new Vertex4hf((HalfFloat)1.0f, (HalfFloat)1.0f, (HalfFloat)1.0f, (HalfFloat)0.0f);

			Assert.IsTrue(v1.Equals(v2, (HalfFloat)(HalfFloat)1e-3));
			Assert.IsTrue(v2.Equals(v1, (HalfFloat)(HalfFloat)1e-3));

			// Normalized equality
			v1 = new Vertex4hf((HalfFloat)1.0f);
			v2 = new Vertex4hf((HalfFloat)((HalfFloat)1.0f + (HalfFloat)1.0f));

			Assert.IsTrue(v1.Equals(v2, (HalfFloat)(HalfFloat)1e-3));
			Assert.IsTrue(v2.Equals(v1, (HalfFloat)(HalfFloat)1e-3));
		}

		[Test]
		public void Vertex4hf_Equals_Vertex4hf()
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

		[Test]
		public void Vertex4hf_Equals_Object()
		{
			Vertex4hf v = Vertex4hf.UnitX;

			Assert.IsFalse(v.Equals(null));
			Assert.IsFalse(v.Equals(String.Empty));
			Assert.IsFalse(v.Equals(0.0f));

			Assert.IsTrue(v.Equals((object)Vertex4hf.UnitX));
			Assert.IsFalse(v.Equals((object)Vertex4hf.UnitY));
			Assert.IsFalse(v.Equals((object)Vertex4hf.UnitZ));
		}

		[Test]
		public void Vertex4hf_GetHashCode()
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

		[Test]
		public void Vertex4hf_ToString()
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
