
// Copyright (C) 2016 Luca Piccioni
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

using NUnit.Framework;

using System.Numerics;

namespace OpenGL.Test
{
	[TestFixture]
	class Vertex3Test
	{
		#region Constructors

		public Vertex3Test()
		{
			Random random = new Random();

			_MinArray = new Vertex3f[100000];
			for (int i = 0; i < _MinArray.Length; i++)
				_MinArray[i] = new Vertex3f((float)random.NextDouble(), (float)random.NextDouble(), (float)random.NextDouble());
		}

		#endregion

		#region Min

		[Test]
		public void TestMinPerformance()
		{
			Stopwatch sw = Stopwatch.StartNew();
			for (int i = 0; i < 10000; i++)
				Vertex3f.Min(_MinArray);
			sw.Stop();

			Console.WriteLine("Min: {0} ms", sw.ElapsedMilliseconds);
		}

		[Test]
		public void TestVector3Min_Impl()
		{
			Stopwatch sw = Stopwatch.StartNew();

			for (int r = 0; r < 10000; r++) {
				unsafe
				{
					fixed (Vertex3f *v = _MinArray) {
						float x = (float)float.MaxValue, y = (float)float.MaxValue, z = (float)float.MaxValue;

						for (int i = 0; i < _MinArray.Length; i++) {
							x = (float)Math.Min(x, v[i].x);
							y = (float)Math.Min(y, v[i].y);
							z = (float)Math.Min(z, v[i].z);
						}
					}
				}
				
			}

			sw.Stop();

			Console.WriteLine("Min: {0} ms", sw.ElapsedMilliseconds);
		}

		[Test]
		public void TestVector3Min_VecImpl()
		{
			Stopwatch sw = Stopwatch.StartNew();

			for (int r = 0; r < 10000; r++) {
				unsafe
				{
					Vector4 min = new Vector4(Single.MaxValue, Single.MaxValue, Single.MaxValue, Single.MaxValue);

					fixed (Vertex3f *v = _MinArray) {
						for (int i = 0; i < _MinArray.Length; i++)
							min = Vector4.Min(min, new Vector4(v[i].x, v[i].y, v[i].z, 1.0f));
					}
				}
			}

			sw.Stop();

			Console.WriteLine("Min: {0} ms", sw.ElapsedMilliseconds);
		}

		[Test]
		public void TestVector3Min_VecImpl2()
		{
			Stopwatch sw = Stopwatch.StartNew();

			for (int r = 0; r < 10000; r++) {
				

				Vector<float> minx = new Vector<float>(Single.MaxValue);
				Vector<float> miny = new Vector<float>(Single.MaxValue);
				Vector<float> minz = new Vector<float>(Single.MaxValue);

				for (int i = 0; i < _MinArray.Length; i += Vector<float>.Count) {
					Vector<float> vx = new Vector<float>(new float[] {
						
					});
				}
			}

			sw.Stop();

			Console.WriteLine("Min: {0} ms", sw.ElapsedMilliseconds);
		}

		private Vertex3f[] _MinArray;

		#endregion
	}
}
