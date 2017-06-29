
// Copyright (C) 2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

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
			byte randomValue = (byte)Next(random, byte.MinValue, byte.MaxValue);
			
			Vertex3ub v = new Vertex3ub(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex3ub(byte[])")]
		public void Vertex3ub_TestConstructor2()
		{
			Random random = new Random();
			byte randomValueX = (byte)Next(random, byte.MinValue, byte.MaxValue);
			byte randomValueY = (byte)Next(random, byte.MinValue, byte.MaxValue);
			byte randomValueZ = (byte)Next(random, byte.MinValue, byte.MaxValue);

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
			byte randomValueX = (byte)Next(random, byte.MinValue, byte.MaxValue);
			byte randomValueY = (byte)Next(random, byte.MinValue, byte.MaxValue);
			byte randomValueZ = (byte)Next(random, byte.MinValue, byte.MaxValue);

			Vertex3ub v = new Vertex3ub(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		[Test(Description = "Test Vertex3ub(Vertex3ub)")]
		public void Vertex3ub_TestConstructor4()
		{
			Random random = new Random();
			byte randomValueX = (byte)Next(random, byte.MinValue, byte.MaxValue);
			byte randomValueY = (byte)Next(random, byte.MinValue, byte.MaxValue);
			byte randomValueZ = (byte)Next(random, byte.MinValue, byte.MaxValue);

			Vertex3ub v1 = new Vertex3ub(
				randomValueX, randomValueY, randomValueZ
			);
			Vertex3ub v2 = new Vertex3ub(v1);

			Assert.AreEqual(v1.x, v2.x);
			Assert.AreEqual(v1.y, v2.y);
			Assert.AreEqual(v1.z, v2.z);
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
			
			byte x1 = (byte)Next(random, byte.MinValue / 2.0f, byte.MaxValue / 2.0f);
			byte y1 = (byte)Next(random, byte.MinValue / 2.0f, byte.MaxValue / 2.0f);
			byte z1 = (byte)Next(random, byte.MinValue / 2.0f, byte.MaxValue / 2.0f);

			Vertex3ub v1 = new Vertex3ub(x1, y1, z1);

			byte x2 = (byte)Next(random, byte.MinValue / 2.0f, byte.MaxValue / 2.0f);
			byte y2 = (byte)Next(random, byte.MinValue / 2.0f, byte.MaxValue / 2.0f);
			byte z2 = (byte)Next(random, byte.MinValue / 2.0f, byte.MaxValue / 2.0f);

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
			
			byte x1 = (byte)Next(random, byte.MinValue / 2.0f, byte.MaxValue / 2.0f);
			byte y1 = (byte)Next(random, byte.MinValue / 2.0f, byte.MaxValue / 2.0f);
			byte z1 = (byte)Next(random, byte.MinValue / 2.0f, byte.MaxValue / 2.0f);

			Vertex3ub v1 = new Vertex3ub(x1, y1, z1);

			byte x2 = (byte)Next(random, byte.MinValue / 2.0f, byte.MaxValue / 2.0f);
			byte y2 = (byte)Next(random, byte.MinValue / 2.0f, byte.MaxValue / 2.0f);
			byte z2 = (byte)Next(random, byte.MinValue / 2.0f, byte.MaxValue / 2.0f);

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
			
			byte x1 = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);
			byte y1 = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);
			byte z1 = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);
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
			
			byte x1 = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);
			byte y1 = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);
			byte z1 = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);
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
			
			byte x1 = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);
			byte y1 = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);
			byte z1 = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);
			double s = Next(random, 0.0, 32.0);

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
			
			byte x1 = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);
			byte y1 = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);
			byte z1 = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);
			double s = Next(random, 0.0, 32.0);

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

		[Test(Description = "Test Vertex3ub.operator*(Vertex3ub, Matrix4x4)")]
		public void Vertex3ub_TestOperatorMatrixProduct()
		{
			Assert.Inconclusive("not implemented yet");
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex3ub.operator==(Vertex3ub, Vertex3ub)")]
		public void Vertex3ub_TestOperatorEquality()
		{
			Assert.Inconclusive("not implemented yet");
		}

		[Test(Description = "Test Vertex3ub.operator!=(Vertex3ub, Vertex3ub)")]
		public void Vertex3ub_TestOperatorInequality()
		{
			Assert.Inconclusive("not implemented yet");
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex3ub.operator float[](Vertex3ub)")]
		public void Vertex3ub_TestCastToArray()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);
			byte y = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);
			byte z = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);

			Vertex3ub v = new Vertex3ub(x, y, z);
			byte[] vArray = (byte[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex3ub.operator Vertex2f(Vertex3ub)")]
		public void Vertex3ub_TestCastToVertex2f()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);
			byte y = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);
			byte z = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);

			Vertex3ub v = new Vertex3ub(x, y, z);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.X, v2f.x);
			Assert.AreEqual(v.Y, v2f.y);
		}

		[Test(Description = "Test Vertex3ub.operator Vertex3f(Vertex3ub)")]
		public void Vertex3ub_TestCastToVertex3f()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);
			byte y = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);
			byte z = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);

			Vertex3ub v = new Vertex3ub(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.X, v3f.x);
			Assert.AreEqual(v.Y, v3f.y);
			Assert.AreEqual(v.Z, v3f.z);
		}

		[Test(Description = "Test Vertex3ub.operator Vertex3d(Vertex3ub)")]
		public void Vertex3ub_TestCastToVertex3d()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);
			byte y = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);
			byte z = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);

			Vertex3ub v = new Vertex3ub(x, y, z);
			Vertex3d v3d = (Vertex3d)v;

			Assert.AreEqual(v.X, (float)v3d.x);
			Assert.AreEqual(v.Y, (float)v3d.y);
			Assert.AreEqual(v.Z, (float)v3d.z);
		}

		[Test(Description = "Test Vertex3ub.operator Vertex4d(Vertex3ub)")]
		public void Vertex3ub_TestCastToVertex4d()
		{
			Random random = new Random();
			
			byte x = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);
			byte y = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);
			byte z = (byte)Next(random, byte.MinValue / 32.0, byte.MaxValue / 32.0);

			Vertex3ub v = new Vertex3ub(x, y, z);
			Vertex4d v4d = (Vertex4d)v;

			Assert.AreEqual(v.X, (float)v4d.x);
			Assert.AreEqual(v.Y, (float)v4d.y);
			Assert.AreEqual(v.Z, (float)v4d.z);
			Assert.AreEqual(1.0f, (float)v4d.w);
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
			sbyte randomValue = (sbyte)Next(random, sbyte.MinValue, sbyte.MaxValue);
			
			Vertex3b v = new Vertex3b(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex3b(sbyte[])")]
		public void Vertex3b_TestConstructor2()
		{
			Random random = new Random();
			sbyte randomValueX = (sbyte)Next(random, sbyte.MinValue, sbyte.MaxValue);
			sbyte randomValueY = (sbyte)Next(random, sbyte.MinValue, sbyte.MaxValue);
			sbyte randomValueZ = (sbyte)Next(random, sbyte.MinValue, sbyte.MaxValue);

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
			sbyte randomValueX = (sbyte)Next(random, sbyte.MinValue, sbyte.MaxValue);
			sbyte randomValueY = (sbyte)Next(random, sbyte.MinValue, sbyte.MaxValue);
			sbyte randomValueZ = (sbyte)Next(random, sbyte.MinValue, sbyte.MaxValue);

			Vertex3b v = new Vertex3b(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		[Test(Description = "Test Vertex3b(Vertex3b)")]
		public void Vertex3b_TestConstructor4()
		{
			Random random = new Random();
			sbyte randomValueX = (sbyte)Next(random, sbyte.MinValue, sbyte.MaxValue);
			sbyte randomValueY = (sbyte)Next(random, sbyte.MinValue, sbyte.MaxValue);
			sbyte randomValueZ = (sbyte)Next(random, sbyte.MinValue, sbyte.MaxValue);

			Vertex3b v1 = new Vertex3b(
				randomValueX, randomValueY, randomValueZ
			);
			Vertex3b v2 = new Vertex3b(v1);

			Assert.AreEqual(v1.x, v2.x);
			Assert.AreEqual(v1.y, v2.y);
			Assert.AreEqual(v1.z, v2.z);
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

		[Test(Description = "Test Vertex3b.operator+(Vertex3b, Vertex3b)")]
		public void Vertex3b_TestOperatorAdd()
		{
			Random random = new Random();
			
			sbyte x1 = (sbyte)Next(random, sbyte.MinValue / 2.0f, sbyte.MaxValue / 2.0f);
			sbyte y1 = (sbyte)Next(random, sbyte.MinValue / 2.0f, sbyte.MaxValue / 2.0f);
			sbyte z1 = (sbyte)Next(random, sbyte.MinValue / 2.0f, sbyte.MaxValue / 2.0f);

			Vertex3b v1 = new Vertex3b(x1, y1, z1);

			sbyte x2 = (sbyte)Next(random, sbyte.MinValue / 2.0f, sbyte.MaxValue / 2.0f);
			sbyte y2 = (sbyte)Next(random, sbyte.MinValue / 2.0f, sbyte.MaxValue / 2.0f);
			sbyte z2 = (sbyte)Next(random, sbyte.MinValue / 2.0f, sbyte.MaxValue / 2.0f);

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
			
			sbyte x1 = (sbyte)Next(random, sbyte.MinValue / 2.0f, sbyte.MaxValue / 2.0f);
			sbyte y1 = (sbyte)Next(random, sbyte.MinValue / 2.0f, sbyte.MaxValue / 2.0f);
			sbyte z1 = (sbyte)Next(random, sbyte.MinValue / 2.0f, sbyte.MaxValue / 2.0f);

			Vertex3b v1 = new Vertex3b(x1, y1, z1);

			sbyte x2 = (sbyte)Next(random, sbyte.MinValue / 2.0f, sbyte.MaxValue / 2.0f);
			sbyte y2 = (sbyte)Next(random, sbyte.MinValue / 2.0f, sbyte.MaxValue / 2.0f);
			sbyte z2 = (sbyte)Next(random, sbyte.MinValue / 2.0f, sbyte.MaxValue / 2.0f);

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
			
			sbyte x1 = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);
			sbyte y1 = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);
			sbyte z1 = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);
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
			
			sbyte x1 = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);
			sbyte y1 = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);
			sbyte z1 = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);
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
			
			sbyte x1 = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);
			sbyte y1 = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);
			sbyte z1 = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);
			double s = Next(random, 0.0, 32.0);

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
			
			sbyte x1 = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);
			sbyte y1 = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);
			sbyte z1 = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);
			double s = Next(random, 0.0, 32.0);

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

		[Test(Description = "Test Vertex3b.operator*(Vertex3b, Matrix4x4)")]
		public void Vertex3b_TestOperatorMatrixProduct()
		{
			Assert.Inconclusive("not implemented yet");
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex3b.operator==(Vertex3b, Vertex3b)")]
		public void Vertex3b_TestOperatorEquality()
		{
			Assert.Inconclusive("not implemented yet");
		}

		[Test(Description = "Test Vertex3b.operator!=(Vertex3b, Vertex3b)")]
		public void Vertex3b_TestOperatorInequality()
		{
			Assert.Inconclusive("not implemented yet");
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex3b.operator float[](Vertex3b)")]
		public void Vertex3b_TestCastToArray()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);
			sbyte y = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);
			sbyte z = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);

			Vertex3b v = new Vertex3b(x, y, z);
			sbyte[] vArray = (sbyte[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex3b.operator Vertex2f(Vertex3b)")]
		public void Vertex3b_TestCastToVertex2f()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);
			sbyte y = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);
			sbyte z = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);

			Vertex3b v = new Vertex3b(x, y, z);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.X, v2f.x);
			Assert.AreEqual(v.Y, v2f.y);
		}

		[Test(Description = "Test Vertex3b.operator Vertex3f(Vertex3b)")]
		public void Vertex3b_TestCastToVertex3f()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);
			sbyte y = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);
			sbyte z = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);

			Vertex3b v = new Vertex3b(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.X, v3f.x);
			Assert.AreEqual(v.Y, v3f.y);
			Assert.AreEqual(v.Z, v3f.z);
		}

		[Test(Description = "Test Vertex3b.operator Vertex3d(Vertex3b)")]
		public void Vertex3b_TestCastToVertex3d()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);
			sbyte y = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);
			sbyte z = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);

			Vertex3b v = new Vertex3b(x, y, z);
			Vertex3d v3d = (Vertex3d)v;

			Assert.AreEqual(v.X, (float)v3d.x);
			Assert.AreEqual(v.Y, (float)v3d.y);
			Assert.AreEqual(v.Z, (float)v3d.z);
		}

		[Test(Description = "Test Vertex3b.operator Vertex4d(Vertex3b)")]
		public void Vertex3b_TestCastToVertex4d()
		{
			Random random = new Random();
			
			sbyte x = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);
			sbyte y = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);
			sbyte z = (sbyte)Next(random, sbyte.MinValue / 32.0, sbyte.MaxValue / 32.0);

			Vertex3b v = new Vertex3b(x, y, z);
			Vertex4d v4d = (Vertex4d)v;

			Assert.AreEqual(v.X, (float)v4d.x);
			Assert.AreEqual(v.Y, (float)v4d.y);
			Assert.AreEqual(v.Z, (float)v4d.z);
			Assert.AreEqual(1.0f, (float)v4d.w);
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
			ushort randomValue = (ushort)Next(random, ushort.MinValue, ushort.MaxValue);
			
			Vertex3us v = new Vertex3us(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex3us(ushort[])")]
		public void Vertex3us_TestConstructor2()
		{
			Random random = new Random();
			ushort randomValueX = (ushort)Next(random, ushort.MinValue, ushort.MaxValue);
			ushort randomValueY = (ushort)Next(random, ushort.MinValue, ushort.MaxValue);
			ushort randomValueZ = (ushort)Next(random, ushort.MinValue, ushort.MaxValue);

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
			ushort randomValueX = (ushort)Next(random, ushort.MinValue, ushort.MaxValue);
			ushort randomValueY = (ushort)Next(random, ushort.MinValue, ushort.MaxValue);
			ushort randomValueZ = (ushort)Next(random, ushort.MinValue, ushort.MaxValue);

			Vertex3us v = new Vertex3us(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		[Test(Description = "Test Vertex3us(Vertex3us)")]
		public void Vertex3us_TestConstructor4()
		{
			Random random = new Random();
			ushort randomValueX = (ushort)Next(random, ushort.MinValue, ushort.MaxValue);
			ushort randomValueY = (ushort)Next(random, ushort.MinValue, ushort.MaxValue);
			ushort randomValueZ = (ushort)Next(random, ushort.MinValue, ushort.MaxValue);

			Vertex3us v1 = new Vertex3us(
				randomValueX, randomValueY, randomValueZ
			);
			Vertex3us v2 = new Vertex3us(v1);

			Assert.AreEqual(v1.x, v2.x);
			Assert.AreEqual(v1.y, v2.y);
			Assert.AreEqual(v1.z, v2.z);
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
			
			ushort x1 = (ushort)Next(random, ushort.MinValue / 2.0f, ushort.MaxValue / 2.0f);
			ushort y1 = (ushort)Next(random, ushort.MinValue / 2.0f, ushort.MaxValue / 2.0f);
			ushort z1 = (ushort)Next(random, ushort.MinValue / 2.0f, ushort.MaxValue / 2.0f);

			Vertex3us v1 = new Vertex3us(x1, y1, z1);

			ushort x2 = (ushort)Next(random, ushort.MinValue / 2.0f, ushort.MaxValue / 2.0f);
			ushort y2 = (ushort)Next(random, ushort.MinValue / 2.0f, ushort.MaxValue / 2.0f);
			ushort z2 = (ushort)Next(random, ushort.MinValue / 2.0f, ushort.MaxValue / 2.0f);

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
			
			ushort x1 = (ushort)Next(random, ushort.MinValue / 2.0f, ushort.MaxValue / 2.0f);
			ushort y1 = (ushort)Next(random, ushort.MinValue / 2.0f, ushort.MaxValue / 2.0f);
			ushort z1 = (ushort)Next(random, ushort.MinValue / 2.0f, ushort.MaxValue / 2.0f);

			Vertex3us v1 = new Vertex3us(x1, y1, z1);

			ushort x2 = (ushort)Next(random, ushort.MinValue / 2.0f, ushort.MaxValue / 2.0f);
			ushort y2 = (ushort)Next(random, ushort.MinValue / 2.0f, ushort.MaxValue / 2.0f);
			ushort z2 = (ushort)Next(random, ushort.MinValue / 2.0f, ushort.MaxValue / 2.0f);

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
			
			ushort x1 = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);
			ushort y1 = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);
			ushort z1 = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);
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
			
			ushort x1 = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);
			ushort y1 = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);
			ushort z1 = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);
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
			
			ushort x1 = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);
			ushort y1 = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);
			ushort z1 = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);
			double s = Next(random, 0.0, 32.0);

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
			
			ushort x1 = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);
			ushort y1 = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);
			ushort z1 = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);
			double s = Next(random, 0.0, 32.0);

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

		[Test(Description = "Test Vertex3us.operator*(Vertex3us, Matrix4x4)")]
		public void Vertex3us_TestOperatorMatrixProduct()
		{
			Assert.Inconclusive("not implemented yet");
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex3us.operator==(Vertex3us, Vertex3us)")]
		public void Vertex3us_TestOperatorEquality()
		{
			Assert.Inconclusive("not implemented yet");
		}

		[Test(Description = "Test Vertex3us.operator!=(Vertex3us, Vertex3us)")]
		public void Vertex3us_TestOperatorInequality()
		{
			Assert.Inconclusive("not implemented yet");
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex3us.operator float[](Vertex3us)")]
		public void Vertex3us_TestCastToArray()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);
			ushort y = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);
			ushort z = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);

			Vertex3us v = new Vertex3us(x, y, z);
			ushort[] vArray = (ushort[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex3us.operator Vertex2f(Vertex3us)")]
		public void Vertex3us_TestCastToVertex2f()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);
			ushort y = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);
			ushort z = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);

			Vertex3us v = new Vertex3us(x, y, z);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.X, v2f.x);
			Assert.AreEqual(v.Y, v2f.y);
		}

		[Test(Description = "Test Vertex3us.operator Vertex3f(Vertex3us)")]
		public void Vertex3us_TestCastToVertex3f()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);
			ushort y = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);
			ushort z = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);

			Vertex3us v = new Vertex3us(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.X, v3f.x);
			Assert.AreEqual(v.Y, v3f.y);
			Assert.AreEqual(v.Z, v3f.z);
		}

		[Test(Description = "Test Vertex3us.operator Vertex3d(Vertex3us)")]
		public void Vertex3us_TestCastToVertex3d()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);
			ushort y = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);
			ushort z = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);

			Vertex3us v = new Vertex3us(x, y, z);
			Vertex3d v3d = (Vertex3d)v;

			Assert.AreEqual(v.X, (float)v3d.x);
			Assert.AreEqual(v.Y, (float)v3d.y);
			Assert.AreEqual(v.Z, (float)v3d.z);
		}

		[Test(Description = "Test Vertex3us.operator Vertex4d(Vertex3us)")]
		public void Vertex3us_TestCastToVertex4d()
		{
			Random random = new Random();
			
			ushort x = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);
			ushort y = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);
			ushort z = (ushort)Next(random, ushort.MinValue / 32.0, ushort.MaxValue / 32.0);

			Vertex3us v = new Vertex3us(x, y, z);
			Vertex4d v4d = (Vertex4d)v;

			Assert.AreEqual(v.X, (float)v4d.x);
			Assert.AreEqual(v.Y, (float)v4d.y);
			Assert.AreEqual(v.Z, (float)v4d.z);
			Assert.AreEqual(1.0f, (float)v4d.w);
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
			short randomValue = (short)Next(random, short.MinValue, short.MaxValue);
			
			Vertex3s v = new Vertex3s(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex3s(short[])")]
		public void Vertex3s_TestConstructor2()
		{
			Random random = new Random();
			short randomValueX = (short)Next(random, short.MinValue, short.MaxValue);
			short randomValueY = (short)Next(random, short.MinValue, short.MaxValue);
			short randomValueZ = (short)Next(random, short.MinValue, short.MaxValue);

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
			short randomValueX = (short)Next(random, short.MinValue, short.MaxValue);
			short randomValueY = (short)Next(random, short.MinValue, short.MaxValue);
			short randomValueZ = (short)Next(random, short.MinValue, short.MaxValue);

			Vertex3s v = new Vertex3s(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		[Test(Description = "Test Vertex3s(Vertex3s)")]
		public void Vertex3s_TestConstructor4()
		{
			Random random = new Random();
			short randomValueX = (short)Next(random, short.MinValue, short.MaxValue);
			short randomValueY = (short)Next(random, short.MinValue, short.MaxValue);
			short randomValueZ = (short)Next(random, short.MinValue, short.MaxValue);

			Vertex3s v1 = new Vertex3s(
				randomValueX, randomValueY, randomValueZ
			);
			Vertex3s v2 = new Vertex3s(v1);

			Assert.AreEqual(v1.x, v2.x);
			Assert.AreEqual(v1.y, v2.y);
			Assert.AreEqual(v1.z, v2.z);
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

		[Test(Description = "Test Vertex3s.operator+(Vertex3s, Vertex3s)")]
		public void Vertex3s_TestOperatorAdd()
		{
			Random random = new Random();
			
			short x1 = (short)Next(random, short.MinValue / 2.0f, short.MaxValue / 2.0f);
			short y1 = (short)Next(random, short.MinValue / 2.0f, short.MaxValue / 2.0f);
			short z1 = (short)Next(random, short.MinValue / 2.0f, short.MaxValue / 2.0f);

			Vertex3s v1 = new Vertex3s(x1, y1, z1);

			short x2 = (short)Next(random, short.MinValue / 2.0f, short.MaxValue / 2.0f);
			short y2 = (short)Next(random, short.MinValue / 2.0f, short.MaxValue / 2.0f);
			short z2 = (short)Next(random, short.MinValue / 2.0f, short.MaxValue / 2.0f);

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
			
			short x1 = (short)Next(random, short.MinValue / 2.0f, short.MaxValue / 2.0f);
			short y1 = (short)Next(random, short.MinValue / 2.0f, short.MaxValue / 2.0f);
			short z1 = (short)Next(random, short.MinValue / 2.0f, short.MaxValue / 2.0f);

			Vertex3s v1 = new Vertex3s(x1, y1, z1);

			short x2 = (short)Next(random, short.MinValue / 2.0f, short.MaxValue / 2.0f);
			short y2 = (short)Next(random, short.MinValue / 2.0f, short.MaxValue / 2.0f);
			short z2 = (short)Next(random, short.MinValue / 2.0f, short.MaxValue / 2.0f);

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
			
			short x1 = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);
			short y1 = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);
			short z1 = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);
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
			
			short x1 = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);
			short y1 = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);
			short z1 = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);
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
			
			short x1 = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);
			short y1 = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);
			short z1 = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);
			double s = Next(random, 0.0, 32.0);

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
			
			short x1 = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);
			short y1 = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);
			short z1 = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);
			double s = Next(random, 0.0, 32.0);

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

		[Test(Description = "Test Vertex3s.operator*(Vertex3s, Matrix4x4)")]
		public void Vertex3s_TestOperatorMatrixProduct()
		{
			Assert.Inconclusive("not implemented yet");
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex3s.operator==(Vertex3s, Vertex3s)")]
		public void Vertex3s_TestOperatorEquality()
		{
			Assert.Inconclusive("not implemented yet");
		}

		[Test(Description = "Test Vertex3s.operator!=(Vertex3s, Vertex3s)")]
		public void Vertex3s_TestOperatorInequality()
		{
			Assert.Inconclusive("not implemented yet");
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex3s.operator float[](Vertex3s)")]
		public void Vertex3s_TestCastToArray()
		{
			Random random = new Random();
			
			short x = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);
			short y = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);
			short z = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);

			Vertex3s v = new Vertex3s(x, y, z);
			short[] vArray = (short[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex3s.operator Vertex2f(Vertex3s)")]
		public void Vertex3s_TestCastToVertex2f()
		{
			Random random = new Random();
			
			short x = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);
			short y = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);
			short z = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);

			Vertex3s v = new Vertex3s(x, y, z);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.X, v2f.x);
			Assert.AreEqual(v.Y, v2f.y);
		}

		[Test(Description = "Test Vertex3s.operator Vertex3f(Vertex3s)")]
		public void Vertex3s_TestCastToVertex3f()
		{
			Random random = new Random();
			
			short x = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);
			short y = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);
			short z = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);

			Vertex3s v = new Vertex3s(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.X, v3f.x);
			Assert.AreEqual(v.Y, v3f.y);
			Assert.AreEqual(v.Z, v3f.z);
		}

		[Test(Description = "Test Vertex3s.operator Vertex3d(Vertex3s)")]
		public void Vertex3s_TestCastToVertex3d()
		{
			Random random = new Random();
			
			short x = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);
			short y = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);
			short z = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);

			Vertex3s v = new Vertex3s(x, y, z);
			Vertex3d v3d = (Vertex3d)v;

			Assert.AreEqual(v.X, (float)v3d.x);
			Assert.AreEqual(v.Y, (float)v3d.y);
			Assert.AreEqual(v.Z, (float)v3d.z);
		}

		[Test(Description = "Test Vertex3s.operator Vertex4d(Vertex3s)")]
		public void Vertex3s_TestCastToVertex4d()
		{
			Random random = new Random();
			
			short x = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);
			short y = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);
			short z = (short)Next(random, short.MinValue / 32.0, short.MaxValue / 32.0);

			Vertex3s v = new Vertex3s(x, y, z);
			Vertex4d v4d = (Vertex4d)v;

			Assert.AreEqual(v.X, (float)v4d.x);
			Assert.AreEqual(v.Y, (float)v4d.y);
			Assert.AreEqual(v.Z, (float)v4d.z);
			Assert.AreEqual(1.0f, (float)v4d.w);
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
			uint randomValue = (uint)Next(random, uint.MinValue, uint.MaxValue);
			
			Vertex3ui v = new Vertex3ui(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex3ui(uint[])")]
		public void Vertex3ui_TestConstructor2()
		{
			Random random = new Random();
			uint randomValueX = (uint)Next(random, uint.MinValue, uint.MaxValue);
			uint randomValueY = (uint)Next(random, uint.MinValue, uint.MaxValue);
			uint randomValueZ = (uint)Next(random, uint.MinValue, uint.MaxValue);

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
			uint randomValueX = (uint)Next(random, uint.MinValue, uint.MaxValue);
			uint randomValueY = (uint)Next(random, uint.MinValue, uint.MaxValue);
			uint randomValueZ = (uint)Next(random, uint.MinValue, uint.MaxValue);

			Vertex3ui v = new Vertex3ui(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		[Test(Description = "Test Vertex3ui(Vertex3ui)")]
		public void Vertex3ui_TestConstructor4()
		{
			Random random = new Random();
			uint randomValueX = (uint)Next(random, uint.MinValue, uint.MaxValue);
			uint randomValueY = (uint)Next(random, uint.MinValue, uint.MaxValue);
			uint randomValueZ = (uint)Next(random, uint.MinValue, uint.MaxValue);

			Vertex3ui v1 = new Vertex3ui(
				randomValueX, randomValueY, randomValueZ
			);
			Vertex3ui v2 = new Vertex3ui(v1);

			Assert.AreEqual(v1.x, v2.x);
			Assert.AreEqual(v1.y, v2.y);
			Assert.AreEqual(v1.z, v2.z);
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
			
			uint x1 = (uint)Next(random, uint.MinValue / 2.0f, uint.MaxValue / 2.0f);
			uint y1 = (uint)Next(random, uint.MinValue / 2.0f, uint.MaxValue / 2.0f);
			uint z1 = (uint)Next(random, uint.MinValue / 2.0f, uint.MaxValue / 2.0f);

			Vertex3ui v1 = new Vertex3ui(x1, y1, z1);

			uint x2 = (uint)Next(random, uint.MinValue / 2.0f, uint.MaxValue / 2.0f);
			uint y2 = (uint)Next(random, uint.MinValue / 2.0f, uint.MaxValue / 2.0f);
			uint z2 = (uint)Next(random, uint.MinValue / 2.0f, uint.MaxValue / 2.0f);

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
			
			uint x1 = (uint)Next(random, uint.MinValue / 2.0f, uint.MaxValue / 2.0f);
			uint y1 = (uint)Next(random, uint.MinValue / 2.0f, uint.MaxValue / 2.0f);
			uint z1 = (uint)Next(random, uint.MinValue / 2.0f, uint.MaxValue / 2.0f);

			Vertex3ui v1 = new Vertex3ui(x1, y1, z1);

			uint x2 = (uint)Next(random, uint.MinValue / 2.0f, uint.MaxValue / 2.0f);
			uint y2 = (uint)Next(random, uint.MinValue / 2.0f, uint.MaxValue / 2.0f);
			uint z2 = (uint)Next(random, uint.MinValue / 2.0f, uint.MaxValue / 2.0f);

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
			
			uint x1 = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);
			uint y1 = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);
			uint z1 = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);
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
			
			uint x1 = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);
			uint y1 = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);
			uint z1 = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);
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
			
			uint x1 = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);
			uint y1 = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);
			uint z1 = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);
			double s = Next(random, 0.0, 32.0);

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
			
			uint x1 = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);
			uint y1 = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);
			uint z1 = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);
			double s = Next(random, 0.0, 32.0);

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

		[Test(Description = "Test Vertex3ui.operator*(Vertex3ui, Matrix4x4)")]
		public void Vertex3ui_TestOperatorMatrixProduct()
		{
			Assert.Inconclusive("not implemented yet");
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex3ui.operator==(Vertex3ui, Vertex3ui)")]
		public void Vertex3ui_TestOperatorEquality()
		{
			Assert.Inconclusive("not implemented yet");
		}

		[Test(Description = "Test Vertex3ui.operator!=(Vertex3ui, Vertex3ui)")]
		public void Vertex3ui_TestOperatorInequality()
		{
			Assert.Inconclusive("not implemented yet");
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex3ui.operator float[](Vertex3ui)")]
		public void Vertex3ui_TestCastToArray()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);
			uint y = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);
			uint z = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);

			Vertex3ui v = new Vertex3ui(x, y, z);
			uint[] vArray = (uint[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex3ui.operator Vertex2f(Vertex3ui)")]
		public void Vertex3ui_TestCastToVertex2f()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);
			uint y = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);
			uint z = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);

			Vertex3ui v = new Vertex3ui(x, y, z);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.X, v2f.x);
			Assert.AreEqual(v.Y, v2f.y);
		}

		[Test(Description = "Test Vertex3ui.operator Vertex3f(Vertex3ui)")]
		public void Vertex3ui_TestCastToVertex3f()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);
			uint y = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);
			uint z = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);

			Vertex3ui v = new Vertex3ui(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.X, v3f.x);
			Assert.AreEqual(v.Y, v3f.y);
			Assert.AreEqual(v.Z, v3f.z);
		}

		[Test(Description = "Test Vertex3ui.operator Vertex3d(Vertex3ui)")]
		public void Vertex3ui_TestCastToVertex3d()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);
			uint y = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);
			uint z = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);

			Vertex3ui v = new Vertex3ui(x, y, z);
			Vertex3d v3d = (Vertex3d)v;

			Assert.AreEqual(v.X, (float)v3d.x);
			Assert.AreEqual(v.Y, (float)v3d.y);
			Assert.AreEqual(v.Z, (float)v3d.z);
		}

		[Test(Description = "Test Vertex3ui.operator Vertex4d(Vertex3ui)")]
		public void Vertex3ui_TestCastToVertex4d()
		{
			Random random = new Random();
			
			uint x = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);
			uint y = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);
			uint z = (uint)Next(random, uint.MinValue / 32.0, uint.MaxValue / 32.0);

			Vertex3ui v = new Vertex3ui(x, y, z);
			Vertex4d v4d = (Vertex4d)v;

			Assert.AreEqual(v.X, (float)v4d.x);
			Assert.AreEqual(v.Y, (float)v4d.y);
			Assert.AreEqual(v.Z, (float)v4d.z);
			Assert.AreEqual(1.0f, (float)v4d.w);
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
			int randomValue = (int)Next(random, int.MinValue, int.MaxValue);
			
			Vertex3i v = new Vertex3i(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex3i(int[])")]
		public void Vertex3i_TestConstructor2()
		{
			Random random = new Random();
			int randomValueX = (int)Next(random, int.MinValue, int.MaxValue);
			int randomValueY = (int)Next(random, int.MinValue, int.MaxValue);
			int randomValueZ = (int)Next(random, int.MinValue, int.MaxValue);

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
			int randomValueX = (int)Next(random, int.MinValue, int.MaxValue);
			int randomValueY = (int)Next(random, int.MinValue, int.MaxValue);
			int randomValueZ = (int)Next(random, int.MinValue, int.MaxValue);

			Vertex3i v = new Vertex3i(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		[Test(Description = "Test Vertex3i(Vertex3i)")]
		public void Vertex3i_TestConstructor4()
		{
			Random random = new Random();
			int randomValueX = (int)Next(random, int.MinValue, int.MaxValue);
			int randomValueY = (int)Next(random, int.MinValue, int.MaxValue);
			int randomValueZ = (int)Next(random, int.MinValue, int.MaxValue);

			Vertex3i v1 = new Vertex3i(
				randomValueX, randomValueY, randomValueZ
			);
			Vertex3i v2 = new Vertex3i(v1);

			Assert.AreEqual(v1.x, v2.x);
			Assert.AreEqual(v1.y, v2.y);
			Assert.AreEqual(v1.z, v2.z);
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

		[Test(Description = "Test Vertex3i.operator+(Vertex3i, Vertex3i)")]
		public void Vertex3i_TestOperatorAdd()
		{
			Random random = new Random();
			
			int x1 = (int)Next(random, int.MinValue / 2.0f, int.MaxValue / 2.0f);
			int y1 = (int)Next(random, int.MinValue / 2.0f, int.MaxValue / 2.0f);
			int z1 = (int)Next(random, int.MinValue / 2.0f, int.MaxValue / 2.0f);

			Vertex3i v1 = new Vertex3i(x1, y1, z1);

			int x2 = (int)Next(random, int.MinValue / 2.0f, int.MaxValue / 2.0f);
			int y2 = (int)Next(random, int.MinValue / 2.0f, int.MaxValue / 2.0f);
			int z2 = (int)Next(random, int.MinValue / 2.0f, int.MaxValue / 2.0f);

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
			
			int x1 = (int)Next(random, int.MinValue / 2.0f, int.MaxValue / 2.0f);
			int y1 = (int)Next(random, int.MinValue / 2.0f, int.MaxValue / 2.0f);
			int z1 = (int)Next(random, int.MinValue / 2.0f, int.MaxValue / 2.0f);

			Vertex3i v1 = new Vertex3i(x1, y1, z1);

			int x2 = (int)Next(random, int.MinValue / 2.0f, int.MaxValue / 2.0f);
			int y2 = (int)Next(random, int.MinValue / 2.0f, int.MaxValue / 2.0f);
			int z2 = (int)Next(random, int.MinValue / 2.0f, int.MaxValue / 2.0f);

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
			
			int x1 = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);
			int y1 = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);
			int z1 = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);
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
			
			int x1 = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);
			int y1 = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);
			int z1 = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);
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
			
			int x1 = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);
			int y1 = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);
			int z1 = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);
			double s = Next(random, 0.0, 32.0);

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
			
			int x1 = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);
			int y1 = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);
			int z1 = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);
			double s = Next(random, 0.0, 32.0);

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

		[Test(Description = "Test Vertex3i.operator*(Vertex3i, Matrix4x4)")]
		public void Vertex3i_TestOperatorMatrixProduct()
		{
			Assert.Inconclusive("not implemented yet");
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex3i.operator==(Vertex3i, Vertex3i)")]
		public void Vertex3i_TestOperatorEquality()
		{
			Assert.Inconclusive("not implemented yet");
		}

		[Test(Description = "Test Vertex3i.operator!=(Vertex3i, Vertex3i)")]
		public void Vertex3i_TestOperatorInequality()
		{
			Assert.Inconclusive("not implemented yet");
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex3i.operator float[](Vertex3i)")]
		public void Vertex3i_TestCastToArray()
		{
			Random random = new Random();
			
			int x = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);
			int y = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);
			int z = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);

			Vertex3i v = new Vertex3i(x, y, z);
			int[] vArray = (int[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex3i.operator Vertex2f(Vertex3i)")]
		public void Vertex3i_TestCastToVertex2f()
		{
			Random random = new Random();
			
			int x = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);
			int y = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);
			int z = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);

			Vertex3i v = new Vertex3i(x, y, z);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.X, v2f.x);
			Assert.AreEqual(v.Y, v2f.y);
		}

		[Test(Description = "Test Vertex3i.operator Vertex3f(Vertex3i)")]
		public void Vertex3i_TestCastToVertex3f()
		{
			Random random = new Random();
			
			int x = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);
			int y = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);
			int z = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);

			Vertex3i v = new Vertex3i(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.X, v3f.x);
			Assert.AreEqual(v.Y, v3f.y);
			Assert.AreEqual(v.Z, v3f.z);
		}

		[Test(Description = "Test Vertex3i.operator Vertex3d(Vertex3i)")]
		public void Vertex3i_TestCastToVertex3d()
		{
			Random random = new Random();
			
			int x = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);
			int y = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);
			int z = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);

			Vertex3i v = new Vertex3i(x, y, z);
			Vertex3d v3d = (Vertex3d)v;

			Assert.AreEqual(v.X, (float)v3d.x);
			Assert.AreEqual(v.Y, (float)v3d.y);
			Assert.AreEqual(v.Z, (float)v3d.z);
		}

		[Test(Description = "Test Vertex3i.operator Vertex4d(Vertex3i)")]
		public void Vertex3i_TestCastToVertex4d()
		{
			Random random = new Random();
			
			int x = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);
			int y = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);
			int z = (int)Next(random, int.MinValue / 32.0, int.MaxValue / 32.0);

			Vertex3i v = new Vertex3i(x, y, z);
			Vertex4d v4d = (Vertex4d)v;

			Assert.AreEqual(v.X, (float)v4d.x);
			Assert.AreEqual(v.Y, (float)v4d.y);
			Assert.AreEqual(v.Z, (float)v4d.z);
			Assert.AreEqual(1.0f, (float)v4d.w);
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
			float randomValue = (float)Next(random, float.MinValue, float.MaxValue);
			
			Vertex3f v = new Vertex3f(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex3f(float[])")]
		public void Vertex3f_TestConstructor2()
		{
			Random random = new Random();
			float randomValueX = (float)Next(random, float.MinValue, float.MaxValue);
			float randomValueY = (float)Next(random, float.MinValue, float.MaxValue);
			float randomValueZ = (float)Next(random, float.MinValue, float.MaxValue);

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
			float randomValueX = (float)Next(random, float.MinValue, float.MaxValue);
			float randomValueY = (float)Next(random, float.MinValue, float.MaxValue);
			float randomValueZ = (float)Next(random, float.MinValue, float.MaxValue);

			Vertex3f v = new Vertex3f(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		[Test(Description = "Test Vertex3f(Vertex3f)")]
		public void Vertex3f_TestConstructor4()
		{
			Random random = new Random();
			float randomValueX = (float)Next(random, float.MinValue, float.MaxValue);
			float randomValueY = (float)Next(random, float.MinValue, float.MaxValue);
			float randomValueZ = (float)Next(random, float.MinValue, float.MaxValue);

			Vertex3f v1 = new Vertex3f(
				randomValueX, randomValueY, randomValueZ
			);
			Vertex3f v2 = new Vertex3f(v1);

			Assert.AreEqual(v1.x, v2.x);
			Assert.AreEqual(v1.y, v2.y);
			Assert.AreEqual(v1.z, v2.z);
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

		[Test(Description = "Test Vertex3f.operator+(Vertex3f, Vertex3f)")]
		public void Vertex3f_TestOperatorAdd()
		{
			Random random = new Random();
			
			float x1 = (float)Next(random, float.MinValue / 2.0f, float.MaxValue / 2.0f);
			float y1 = (float)Next(random, float.MinValue / 2.0f, float.MaxValue / 2.0f);
			float z1 = (float)Next(random, float.MinValue / 2.0f, float.MaxValue / 2.0f);

			Vertex3f v1 = new Vertex3f(x1, y1, z1);

			float x2 = (float)Next(random, float.MinValue / 2.0f, float.MaxValue / 2.0f);
			float y2 = (float)Next(random, float.MinValue / 2.0f, float.MaxValue / 2.0f);
			float z2 = (float)Next(random, float.MinValue / 2.0f, float.MaxValue / 2.0f);

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
			
			float x1 = (float)Next(random, float.MinValue / 2.0f, float.MaxValue / 2.0f);
			float y1 = (float)Next(random, float.MinValue / 2.0f, float.MaxValue / 2.0f);
			float z1 = (float)Next(random, float.MinValue / 2.0f, float.MaxValue / 2.0f);

			Vertex3f v1 = new Vertex3f(x1, y1, z1);

			float x2 = (float)Next(random, float.MinValue / 2.0f, float.MaxValue / 2.0f);
			float y2 = (float)Next(random, float.MinValue / 2.0f, float.MaxValue / 2.0f);
			float z2 = (float)Next(random, float.MinValue / 2.0f, float.MaxValue / 2.0f);

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
			
			float x1 = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);
			float y1 = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);
			float z1 = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);
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
			
			float x1 = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);
			float y1 = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);
			float z1 = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);
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
			
			float x1 = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);
			float y1 = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);
			float z1 = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);
			double s = Next(random, 0.0, 32.0);

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
			
			float x1 = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);
			float y1 = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);
			float z1 = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);
			double s = Next(random, 0.0, 32.0);

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

		[Test(Description = "Test Vertex3f.operator*(Vertex3f, Matrix4x4)")]
		public void Vertex3f_TestOperatorMatrixProduct()
		{
			Assert.Inconclusive("not implemented yet");
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex3f.operator==(Vertex3f, Vertex3f)")]
		public void Vertex3f_TestOperatorEquality()
		{
			Assert.Inconclusive("not implemented yet");
		}

		[Test(Description = "Test Vertex3f.operator!=(Vertex3f, Vertex3f)")]
		public void Vertex3f_TestOperatorInequality()
		{
			Assert.Inconclusive("not implemented yet");
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex3f.operator float[](Vertex3f)")]
		public void Vertex3f_TestCastToArray()
		{
			Random random = new Random();
			
			float x = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);
			float y = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);
			float z = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);

			Vertex3f v = new Vertex3f(x, y, z);
			float[] vArray = (float[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex3f.operator Vertex2f(Vertex3f)")]
		public void Vertex3f_TestCastToVertex2f()
		{
			Random random = new Random();
			
			float x = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);
			float y = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);
			float z = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);

			Vertex3f v = new Vertex3f(x, y, z);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.X, v2f.x);
			Assert.AreEqual(v.Y, v2f.y);
		}

		[Test(Description = "Test Vertex3f.operator Vertex3f(Vertex3f)")]
		public void Vertex3f_TestCastToVertex3f()
		{
			Random random = new Random();
			
			float x = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);
			float y = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);
			float z = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);

			Vertex3f v = new Vertex3f(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.X, v3f.x);
			Assert.AreEqual(v.Y, v3f.y);
			Assert.AreEqual(v.Z, v3f.z);
		}

		[Test(Description = "Test Vertex3f.operator Vertex3d(Vertex3f)")]
		public void Vertex3f_TestCastToVertex3d()
		{
			Random random = new Random();
			
			float x = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);
			float y = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);
			float z = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);

			Vertex3f v = new Vertex3f(x, y, z);
			Vertex3d v3d = (Vertex3d)v;

			Assert.AreEqual(v.X, (float)v3d.x);
			Assert.AreEqual(v.Y, (float)v3d.y);
			Assert.AreEqual(v.Z, (float)v3d.z);
		}

		[Test(Description = "Test Vertex3f.operator Vertex4d(Vertex3f)")]
		public void Vertex3f_TestCastToVertex4d()
		{
			Random random = new Random();
			
			float x = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);
			float y = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);
			float z = (float)Next(random, float.MinValue / 32.0, float.MaxValue / 32.0);

			Vertex3f v = new Vertex3f(x, y, z);
			Vertex4d v4d = (Vertex4d)v;

			Assert.AreEqual(v.X, (float)v4d.x);
			Assert.AreEqual(v.Y, (float)v4d.y);
			Assert.AreEqual(v.Z, (float)v4d.z);
			Assert.AreEqual(1.0f, (float)v4d.w);
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
			double randomValue = (double)Next(random, double.MinValue, double.MaxValue);
			
			Vertex3d v = new Vertex3d(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex3d(double[])")]
		public void Vertex3d_TestConstructor2()
		{
			Random random = new Random();
			double randomValueX = (double)Next(random, double.MinValue, double.MaxValue);
			double randomValueY = (double)Next(random, double.MinValue, double.MaxValue);
			double randomValueZ = (double)Next(random, double.MinValue, double.MaxValue);

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
			double randomValueX = (double)Next(random, double.MinValue, double.MaxValue);
			double randomValueY = (double)Next(random, double.MinValue, double.MaxValue);
			double randomValueZ = (double)Next(random, double.MinValue, double.MaxValue);

			Vertex3d v = new Vertex3d(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		[Test(Description = "Test Vertex3d(Vertex3d)")]
		public void Vertex3d_TestConstructor4()
		{
			Random random = new Random();
			double randomValueX = (double)Next(random, double.MinValue, double.MaxValue);
			double randomValueY = (double)Next(random, double.MinValue, double.MaxValue);
			double randomValueZ = (double)Next(random, double.MinValue, double.MaxValue);

			Vertex3d v1 = new Vertex3d(
				randomValueX, randomValueY, randomValueZ
			);
			Vertex3d v2 = new Vertex3d(v1);

			Assert.AreEqual(v1.x, v2.x);
			Assert.AreEqual(v1.y, v2.y);
			Assert.AreEqual(v1.z, v2.z);
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

		[Test(Description = "Test Vertex3d.operator+(Vertex3d, Vertex3d)")]
		public void Vertex3d_TestOperatorAdd()
		{
			Random random = new Random();
			
			double x1 = (double)Next(random, double.MinValue / 2.0f, double.MaxValue / 2.0f);
			double y1 = (double)Next(random, double.MinValue / 2.0f, double.MaxValue / 2.0f);
			double z1 = (double)Next(random, double.MinValue / 2.0f, double.MaxValue / 2.0f);

			Vertex3d v1 = new Vertex3d(x1, y1, z1);

			double x2 = (double)Next(random, double.MinValue / 2.0f, double.MaxValue / 2.0f);
			double y2 = (double)Next(random, double.MinValue / 2.0f, double.MaxValue / 2.0f);
			double z2 = (double)Next(random, double.MinValue / 2.0f, double.MaxValue / 2.0f);

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
			
			double x1 = (double)Next(random, double.MinValue / 2.0f, double.MaxValue / 2.0f);
			double y1 = (double)Next(random, double.MinValue / 2.0f, double.MaxValue / 2.0f);
			double z1 = (double)Next(random, double.MinValue / 2.0f, double.MaxValue / 2.0f);

			Vertex3d v1 = new Vertex3d(x1, y1, z1);

			double x2 = (double)Next(random, double.MinValue / 2.0f, double.MaxValue / 2.0f);
			double y2 = (double)Next(random, double.MinValue / 2.0f, double.MaxValue / 2.0f);
			double z2 = (double)Next(random, double.MinValue / 2.0f, double.MaxValue / 2.0f);

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
			
			double x1 = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);
			double y1 = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);
			double z1 = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);
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
			
			double x1 = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);
			double y1 = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);
			double z1 = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);
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
			
			double x1 = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);
			double y1 = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);
			double z1 = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);
			double s = Next(random, 0.0, 32.0);

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
			
			double x1 = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);
			double y1 = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);
			double z1 = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);
			double s = Next(random, 0.0, 32.0);

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

		[Test(Description = "Test Vertex3d.operator*(Vertex3d, Matrix4x4)")]
		public void Vertex3d_TestOperatorMatrixProduct()
		{
			Assert.Inconclusive("not implemented yet");
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex3d.operator==(Vertex3d, Vertex3d)")]
		public void Vertex3d_TestOperatorEquality()
		{
			Assert.Inconclusive("not implemented yet");
		}

		[Test(Description = "Test Vertex3d.operator!=(Vertex3d, Vertex3d)")]
		public void Vertex3d_TestOperatorInequality()
		{
			Assert.Inconclusive("not implemented yet");
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex3d.operator float[](Vertex3d)")]
		public void Vertex3d_TestCastToArray()
		{
			Random random = new Random();
			
			double x = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);
			double y = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);
			double z = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);

			Vertex3d v = new Vertex3d(x, y, z);
			double[] vArray = (double[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex3d.operator Vertex2f(Vertex3d)")]
		public void Vertex3d_TestCastToVertex2f()
		{
			Random random = new Random();
			
			double x = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);
			double y = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);
			double z = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);

			Vertex3d v = new Vertex3d(x, y, z);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.X, v2f.x);
			Assert.AreEqual(v.Y, v2f.y);
		}

		[Test(Description = "Test Vertex3d.operator Vertex3f(Vertex3d)")]
		public void Vertex3d_TestCastToVertex3f()
		{
			Random random = new Random();
			
			double x = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);
			double y = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);
			double z = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);

			Vertex3d v = new Vertex3d(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.X, v3f.x);
			Assert.AreEqual(v.Y, v3f.y);
			Assert.AreEqual(v.Z, v3f.z);
		}

		[Test(Description = "Test Vertex3d.operator Vertex3d(Vertex3d)")]
		public void Vertex3d_TestCastToVertex3d()
		{
			Random random = new Random();
			
			double x = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);
			double y = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);
			double z = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);

			Vertex3d v = new Vertex3d(x, y, z);
			Vertex3d v3d = (Vertex3d)v;

			Assert.AreEqual(v.X, (float)v3d.x);
			Assert.AreEqual(v.Y, (float)v3d.y);
			Assert.AreEqual(v.Z, (float)v3d.z);
		}

		[Test(Description = "Test Vertex3d.operator Vertex4d(Vertex3d)")]
		public void Vertex3d_TestCastToVertex4d()
		{
			Random random = new Random();
			
			double x = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);
			double y = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);
			double z = (double)Next(random, double.MinValue / 32.0, double.MaxValue / 32.0);

			Vertex3d v = new Vertex3d(x, y, z);
			Vertex4d v4d = (Vertex4d)v;

			Assert.AreEqual(v.X, (float)v4d.x);
			Assert.AreEqual(v.Y, (float)v4d.y);
			Assert.AreEqual(v.Z, (float)v4d.z);
			Assert.AreEqual(1.0f, (float)v4d.w);
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
			HalfFloat randomValue = (HalfFloat)Next(random, HalfFloat.MinValue, HalfFloat.MaxValue);
			
			Vertex3hf v = new Vertex3hf(randomValue);

			Assert.AreEqual(randomValue, v.x);
			Assert.AreEqual(randomValue, v.y);
			Assert.AreEqual(randomValue, v.z);
		}

		[Test(Description = "Test Vertex3hf(HalfFloat[])")]
		public void Vertex3hf_TestConstructor2()
		{
			Random random = new Random();
			HalfFloat randomValueX = (HalfFloat)Next(random, HalfFloat.MinValue, HalfFloat.MaxValue);
			HalfFloat randomValueY = (HalfFloat)Next(random, HalfFloat.MinValue, HalfFloat.MaxValue);
			HalfFloat randomValueZ = (HalfFloat)Next(random, HalfFloat.MinValue, HalfFloat.MaxValue);

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
			HalfFloat randomValueX = (HalfFloat)Next(random, HalfFloat.MinValue, HalfFloat.MaxValue);
			HalfFloat randomValueY = (HalfFloat)Next(random, HalfFloat.MinValue, HalfFloat.MaxValue);
			HalfFloat randomValueZ = (HalfFloat)Next(random, HalfFloat.MinValue, HalfFloat.MaxValue);

			Vertex3hf v = new Vertex3hf(
				randomValueX, randomValueY, randomValueZ
			);

			Assert.AreEqual(randomValueX, v.x);
			Assert.AreEqual(randomValueY, v.y);
			Assert.AreEqual(randomValueZ, v.z);
		}

		[Test(Description = "Test Vertex3hf(Vertex3hf)")]
		public void Vertex3hf_TestConstructor4()
		{
			Random random = new Random();
			HalfFloat randomValueX = (HalfFloat)Next(random, HalfFloat.MinValue, HalfFloat.MaxValue);
			HalfFloat randomValueY = (HalfFloat)Next(random, HalfFloat.MinValue, HalfFloat.MaxValue);
			HalfFloat randomValueZ = (HalfFloat)Next(random, HalfFloat.MinValue, HalfFloat.MaxValue);

			Vertex3hf v1 = new Vertex3hf(
				randomValueX, randomValueY, randomValueZ
			);
			Vertex3hf v2 = new Vertex3hf(v1);

			Assert.AreEqual(v1.x, v2.x);
			Assert.AreEqual(v1.y, v2.y);
			Assert.AreEqual(v1.z, v2.z);
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
			
			HalfFloat x1 = (HalfFloat)Next(random, HalfFloat.MinValue / 2.0f, HalfFloat.MaxValue / 2.0f);
			HalfFloat y1 = (HalfFloat)Next(random, HalfFloat.MinValue / 2.0f, HalfFloat.MaxValue / 2.0f);
			HalfFloat z1 = (HalfFloat)Next(random, HalfFloat.MinValue / 2.0f, HalfFloat.MaxValue / 2.0f);

			Vertex3hf v1 = new Vertex3hf(x1, y1, z1);

			HalfFloat x2 = (HalfFloat)Next(random, HalfFloat.MinValue / 2.0f, HalfFloat.MaxValue / 2.0f);
			HalfFloat y2 = (HalfFloat)Next(random, HalfFloat.MinValue / 2.0f, HalfFloat.MaxValue / 2.0f);
			HalfFloat z2 = (HalfFloat)Next(random, HalfFloat.MinValue / 2.0f, HalfFloat.MaxValue / 2.0f);

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
			
			HalfFloat x1 = (HalfFloat)Next(random, HalfFloat.MinValue / 2.0f, HalfFloat.MaxValue / 2.0f);
			HalfFloat y1 = (HalfFloat)Next(random, HalfFloat.MinValue / 2.0f, HalfFloat.MaxValue / 2.0f);
			HalfFloat z1 = (HalfFloat)Next(random, HalfFloat.MinValue / 2.0f, HalfFloat.MaxValue / 2.0f);

			Vertex3hf v1 = new Vertex3hf(x1, y1, z1);

			HalfFloat x2 = (HalfFloat)Next(random, HalfFloat.MinValue / 2.0f, HalfFloat.MaxValue / 2.0f);
			HalfFloat y2 = (HalfFloat)Next(random, HalfFloat.MinValue / 2.0f, HalfFloat.MaxValue / 2.0f);
			HalfFloat z2 = (HalfFloat)Next(random, HalfFloat.MinValue / 2.0f, HalfFloat.MaxValue / 2.0f);

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
			
			HalfFloat x1 = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);
			HalfFloat y1 = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);
			HalfFloat z1 = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);
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
			
			HalfFloat x1 = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);
			HalfFloat y1 = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);
			HalfFloat z1 = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);
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
			
			HalfFloat x1 = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);
			HalfFloat y1 = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);
			HalfFloat z1 = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);
			double s = Next(random, 0.0, 32.0);

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
			
			HalfFloat x1 = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);
			HalfFloat y1 = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);
			HalfFloat z1 = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);
			double s = Next(random, 0.0, 32.0);

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

		[Test(Description = "Test Vertex3hf.operator*(Vertex3hf, Matrix4x4)")]
		public void Vertex3hf_TestOperatorMatrixProduct()
		{
			Assert.Inconclusive("not implemented yet");
		}

		#endregion

		#region Equality Operators

		[Test(Description = "Test Vertex3hf.operator==(Vertex3hf, Vertex3hf)")]
		public void Vertex3hf_TestOperatorEquality()
		{
			Assert.Inconclusive("not implemented yet");
		}

		[Test(Description = "Test Vertex3hf.operator!=(Vertex3hf, Vertex3hf)")]
		public void Vertex3hf_TestOperatorInequality()
		{
			Assert.Inconclusive("not implemented yet");
		}

		#endregion

		#region Cast Operators

		[Test(Description = "Test Vertex3hf.operator float[](Vertex3hf)")]
		public void Vertex3hf_TestCastToArray()
		{
			Random random = new Random();
			
			HalfFloat x = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);
			HalfFloat y = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);
			HalfFloat z = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);

			Vertex3hf v = new Vertex3hf(x, y, z);
			HalfFloat[] vArray = (HalfFloat[])v;

			Assert.AreEqual(v.x, vArray[0]);
			Assert.AreEqual(v.y, vArray[1]);
			Assert.AreEqual(v.z, vArray[2]);
		}

		[Test(Description = "Test Vertex3hf.operator Vertex2f(Vertex3hf)")]
		public void Vertex3hf_TestCastToVertex2f()
		{
			Random random = new Random();
			
			HalfFloat x = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);
			HalfFloat y = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);
			HalfFloat z = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);

			Vertex3hf v = new Vertex3hf(x, y, z);
			Vertex2f v2f = (Vertex2f)v;

			Assert.AreEqual(v.X, v2f.x);
			Assert.AreEqual(v.Y, v2f.y);
		}

		[Test(Description = "Test Vertex3hf.operator Vertex3f(Vertex3hf)")]
		public void Vertex3hf_TestCastToVertex3f()
		{
			Random random = new Random();
			
			HalfFloat x = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);
			HalfFloat y = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);
			HalfFloat z = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);

			Vertex3hf v = new Vertex3hf(x, y, z);
			Vertex3f v3f = (Vertex3f)v;

			Assert.AreEqual(v.X, v3f.x);
			Assert.AreEqual(v.Y, v3f.y);
			Assert.AreEqual(v.Z, v3f.z);
		}

		[Test(Description = "Test Vertex3hf.operator Vertex3d(Vertex3hf)")]
		public void Vertex3hf_TestCastToVertex3d()
		{
			Random random = new Random();
			
			HalfFloat x = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);
			HalfFloat y = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);
			HalfFloat z = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);

			Vertex3hf v = new Vertex3hf(x, y, z);
			Vertex3d v3d = (Vertex3d)v;

			Assert.AreEqual(v.X, (float)v3d.x);
			Assert.AreEqual(v.Y, (float)v3d.y);
			Assert.AreEqual(v.Z, (float)v3d.z);
		}

		[Test(Description = "Test Vertex3hf.operator Vertex4d(Vertex3hf)")]
		public void Vertex3hf_TestCastToVertex4d()
		{
			Random random = new Random();
			
			HalfFloat x = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);
			HalfFloat y = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);
			HalfFloat z = (HalfFloat)Next(random, HalfFloat.MinValue / 32.0, HalfFloat.MaxValue / 32.0);

			Vertex3hf v = new Vertex3hf(x, y, z);
			Vertex4d v4d = (Vertex4d)v;

			Assert.AreEqual(v.X, (float)v4d.x);
			Assert.AreEqual(v.Y, (float)v4d.y);
			Assert.AreEqual(v.Z, (float)v4d.z);
			Assert.AreEqual(1.0f, (float)v4d.w);
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

		#endregion
	}

}
