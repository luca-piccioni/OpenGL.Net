
// Copyright (C) 2016-2017 Luca Piccioni
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

using NUnit.Framework;

using System.Numerics;

namespace OpenGL.Test
{
	class Vertex4 : TestBaseBenchmark
	{
		#region Constructors

		public Vertex4()
		{
			Random random = new Random();

			_MinArray = new Vertex4f[MinArraySize];
			for (int i = 0; i < _MinArray.Length; i++)
				_MinArray[i] = new Vertex4f((float)random.NextDouble(), (float)random.NextDouble(), (float)random.NextDouble(), Math.Max(0.1f, (float)random.NextDouble()));

			_MaxArray = new Vertex4f[MaxArraySize];
			for (int i = 0; i < _MaxArray.Length; i++)
				_MaxArray[i] = new Vertex4f((float)random.NextDouble(), (float)random.NextDouble(), (float)random.NextDouble(), Math.Max(0.1f, (float)random.NextDouble()));
		}

		#endregion

		#region Min

		[Test]
		public void BenchmarkVertex4Min()
		{
			RunBenchmarks<Vertex4>("BenchmarkVector4Min");
		}

		[Benchmark("BenchmarkMinManaged", Repetitions = MinRepetitions)]
		public static void BenchmarkVector4Min_Managed()
		{
			float x = (float)float.MaxValue, y = (float)float.MaxValue, z = (float)float.MaxValue;

			for (int i = 0; i < _MinArray.Length; i++) {
				float w = _MinArray[i].w;
				x = (float)Math.Min(x, _MinArray[i].x / w);
				y = (float)Math.Min(y, _MinArray[i].y / w);
				z = (float)Math.Min(z, _MinArray[i].z / w);
			}
		}

		[Benchmark("BenchmarkMinManagedUnsafe", Repetitions = MinRepetitions)]
		public static void BenchmarkVector4Min_ManagedUnsafe()
		{
			unsafe
			{
				fixed (Vertex4f *v = _MinArray) {
					float x = (float)float.MaxValue, y = (float)float.MaxValue, z = (float)float.MaxValue;

					for (int i = 0; i < _MinArray.Length; i++) {
						float w = v[i].w;
						x = (float)Math.Min(x, v[i].x / w);
						y = (float)Math.Min(y, v[i].y / w);
						z = (float)Math.Min(z, v[i].z / w);
					}
				}
			}
		}

		[Benchmark("BenchmarkMinNumerics", Repetitions = MinRepetitions)]
		public static void BenchmarkVector4Min_NumericsSafe()
		{
			Vector3 min = new Vector3(Single.MaxValue, Single.MaxValue, Single.MaxValue);

			for (int i = 0; i < _MinArray.Length; i++)
				min = Vector3.Min(min, new Vector3(_MinArray[i].x, _MinArray[i].y, _MinArray[i].z) / _MinArray[i].w);
		}

		[Benchmark("BenchmarkMinNumericsUnsafe", Repetitions = MinRepetitions)]
		public static void BenchmarkVector4Min_NumericsUnsafe()
		{
			unsafe
			{
				Vector3 min = new Vector3(Single.MaxValue, Single.MaxValue, Single.MaxValue);

				fixed (Vertex4f *v = _MinArray) {
					for (int i = 0; i < _MinArray.Length; i++)
						min = Vector3.Min(min, new Vector3(v[i].x, v[i].y, v[i].z) / v[i].w);
				}
			}
		}

		private static Vertex4f[] _MinArray;

		/// <summary>
		/// Size of the array used for testing: 50K vertices.
		/// </summary>
		private const uint MinArraySize = 1024 * 50;

		/// <summary>
		/// Number of repetitions for Min.
		/// </summary>
		private const int MinRepetitions = 100;

		#endregion

		#region Max

		[Test]
		public void BenchmarkVertex4Max()
		{
			RunBenchmarks<Vertex4>("BenchmarkVector4Max");
		}

		[Benchmark("BenchmarkMaxManaged", Repetitions = MaxRepetitions)]
		public static void BenchmarkVector4Max_Managed()
		{
			float x = (float)float.MaxValue, y = (float)float.MaxValue, z = (float)float.MaxValue;

			for (int i = 0; i < _MaxArray.Length; i++) {
				float w = _MaxArray[i].w;
				x = (float)Math.Max(x, _MaxArray[i].x / w);
				y = (float)Math.Max(y, _MaxArray[i].y / w);
				z = (float)Math.Max(z, _MaxArray[i].z / w);
			}
		}

		[Benchmark("BenchmarkMaxManagedUnsafe", Repetitions = MaxRepetitions)]
		public static void BenchmarkVector4Max_ManagedUnsafe()
		{
			unsafe
			{
				fixed (Vertex4f *v = _MaxArray) {
					float x = (float)float.MaxValue, y = (float)float.MaxValue, z = (float)float.MaxValue;

					for (int i = 0; i < _MaxArray.Length; i++) {
						float w = v[i].w;
						x = (float)Math.Max(x, v[i].x / w);
						y = (float)Math.Max(y, v[i].y / w);
						z = (float)Math.Max(z, v[i].z / w);
					}
				}
			}
		}

		[Benchmark("BenchmarkMaxNumerics", Repetitions = MinRepetitions)]
		public static void BenchmarkVector4Max_NumericsSafe()
		{
			Vector3 max = new Vector3(Single.MinValue, Single.MinValue, Single.MinValue);

			for (int i = 0; i < _MaxArray.Length; i++)
				max = Vector3.Max(max, new Vector3(_MaxArray[i].x, _MaxArray[i].y, _MaxArray[i].z) / _MaxArray[i].w);
		}

		[Benchmark("BenchmarkMaxNumerics2", Repetitions = MinRepetitions)]
		private static void BenchmarkVector4Max_Numerics2Safe()
		{
			Vector3 max = new Vector3(Single.MinValue, Single.MinValue, Single.MinValue);

			for (int i = 0; i < _MaxArray.Length; i += 2) {
				Vector3 v1 = new Vector3(_MaxArray[i].x, _MaxArray[i].y, _MaxArray[i].z) / _MaxArray[i].w;
				Vector3 v2 = new Vector3(_MaxArray[i+1].x, _MaxArray[i+1].y, _MaxArray[i+1].z) / _MaxArray[i+1].w;

				v1 = Vector3.Max(v1, v2);
				max = Vector3.Max(max, v1);
			}
		}

		[Benchmark("BenchmarkMaxNumericsVectorUnsafe", Repetitions = MinRepetitions)]
		private static void BenchmarkVector4Max_NumericsVectorUnsafe()
		{
			int count = Vector<float>.Count;

			Vector<float> max = new Vector<float>(Single.MinValue);

			
		}

		[Benchmark("BenchmarkMaxNumericsUnsafe", Repetitions = MinRepetitions)]
		public static void BenchmarkVector4Max_NumericsUnsafe()
		{
			unsafe
			{
				Vector3 max = new Vector3(Single.MinValue, Single.MinValue, Single.MinValue);

				fixed (Vertex4f *v = _MaxArray) {
					for (int i = 0; i < _MaxArray.Length; i++)
						max = Vector3.Max(max, new Vector3(v[i].x, v[i].y, v[i].z) / v[i].w);
				}
			}
		}

		private static Vertex4f[] _MaxArray;

		/// <summary>
		/// Size of the array used for testing: 50K vertices.
		/// </summary>
		private const uint MaxArraySize = 1024 * 50;

		/// <summary>
		/// Number of repetitions for Min.
		/// </summary>
		private const int MaxRepetitions = 100;

		#endregion
	}
}
