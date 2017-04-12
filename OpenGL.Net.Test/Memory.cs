
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
using System.Diagnostics;

using NUnit.Framework;

namespace OpenGL.Test
{
	[TestFixture]
	class TestMemory : BenchmarkBase
	{
		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		static TestMemory()
		{
			Random random = new Random(unchecked((int)DateTime.Now.Ticks));

			_BenchmarkDataMemoryCopy = new Vertex4f[MemoryCopySize];
			_BenchmarkDataMemoryCopyDst = new Vertex4f[_BenchmarkDataMemoryCopy.Length];
			for (int i = 0; i < _BenchmarkDataMemoryCopy.Length; i++) {
				float r1 = (float)random.NextDouble(), r2 = (float)random.NextDouble();
				_BenchmarkDataMemoryCopy[i] = new Vertex4f(r1, r2, r2, r1);
			}
		}

		#endregion

		#region MemoryCopy Benchmark

		/// <summary>
		/// Test memory copy methods (one large buffer).
		/// </summary>
		[Test]
		public void BenchmarkMemoryCopy()
		{
			RunBenchmarks<TestMemory>("BenchmarkMemoryCopy");
		}

		/// <summary>
		/// Test worst performance for copying arrays using managed method.
		/// </summary>
		[Benchmark("MemoryCopyManaged", Repetitions = MemoryCopyRepetitions)]
		public static void BenchmarkMemoryCopy_Managed()
		{
			for (int i = 0; i < MemoryCopySize; i++)
				_BenchmarkDataMemoryCopyDst[i] = _BenchmarkDataMemoryCopy[i];
		}

		/// <summary>
		/// Test worst performance for copying arrays using unsafe statement.
		/// </summary>
		[Benchmark("MemoryCopyUnsafe", Repetitions = MemoryCopyRepetitions)]
		public static void BenchmarkMemoryCopy_Unsafe()
		{
			unsafe {
				fixed (Vertex4f *srcPtr = _BenchmarkDataMemoryCopy)
				fixed (Vertex4f *dstPtr = _BenchmarkDataMemoryCopyDst)
				{
					Vertex4f* src = srcPtr, dst = dstPtr;

					for (int i = 0; i < MemoryCopySize; i++)
						dst[i] = src[i];
				}
			}
		}

		/// <summary>
		/// Test performance of <see cref="Array.Copy(Array, Array, int)"/>.
		/// </summary>
		[Benchmark("MemoryCopyFramework", Repetitions = MemoryCopyRepetitions)]
		public static void BenchmarkMemoryCopy_Framework()
		{
			Array.Copy(_BenchmarkDataMemoryCopy, _BenchmarkDataMemoryCopyDst, MemoryCopySize);
		}

		/// <summary>
		/// Test performance of <see cref="Memory.MemoryCopy"/>.
		/// </summary>
		[Benchmark("MemoryCopyMemory", Repetitions = MemoryCopyRepetitions)]
		public static void BenchmarkMemoryCopy_Memory()
		{
			Memory.MemoryCopy(_BenchmarkDataMemoryCopyDst, _BenchmarkDataMemoryCopy, MemoryCopySize * 12);
		}

		/// <summary>
		/// MemoryCopy benchmark data.
		/// </summary>
		private static readonly Vertex4f[] _BenchmarkDataMemoryCopy, _BenchmarkDataMemoryCopyDst;

		/// <summary>
		/// Size of the array used for testing: 256 MB.
		/// </summary>
		const uint MemoryCopySize = 1024 * 1024 * 256 / 12;

		/// <summary>
		/// Number of repetitions for MemoryCopy.
		/// </summary>
		private const int MemoryCopyRepetitions = 50;

		#endregion

		#region MemoryCopyLoop Benchmark

		/// <summary>
		/// Test memory copy methods (one large buffer).
		/// </summary>
		[Test]
		public void BenchmarkMemoryCopyLoop()
		{
			RunBenchmarks<TestMemory>("BenchmarkMemoryCopyLoop");
		}

		/// <summary>
		/// Test worst performance for copying arrays using managed method.
		/// </summary>
		[Benchmark("MemoryCopyManagedLoop", Repetitions = MemoryCopyLoopRepetitions)]
		public static void BenchmarkMemoryCopyLoop_Managed()
		{
			for (int i = 0; i < MemoryCopyLoopSize; i++)
				_BenchmarkDataMemoryCopyDst[i] = _BenchmarkDataMemoryCopy[i];
		}

		/// <summary>
		/// Test worst performance for copying arrays using unsafe statement.
		/// </summary>
		[Benchmark("MemoryCopyUnsafeLoop", Repetitions = MemoryCopyLoopRepetitions)]
		public static void BenchmarkMemoryCopyLoop_Unsafe()
		{
			unsafe {
				fixed (Vertex4f *srcPtr = _BenchmarkDataMemoryCopy)
				fixed (Vertex4f *dstPtr = _BenchmarkDataMemoryCopyDst)
				{
					Vertex4f* src = srcPtr, dst = dstPtr;

					for (int i = 0; i < MemoryCopyLoopSize; i++)
						dst[i] = src[i];
				}
			}
		}

		/// <summary>
		/// Test performance of <see cref="Memory.MemoryCopy"/>.
		/// </summary>
		[Benchmark("MemoryCopyMemoryLoop", Repetitions = MemoryCopyLoopRepetitions)]
		public static void BenchmarkMemoryCopyLoop_Memory()
		{
			for (int i = 0; i < MemoryCopyLoopSize; i++)
				Memory.MemoryCopy(_BenchmarkDataMemoryCopyDst, _BenchmarkDataMemoryCopy, 12 * MemoryCopyLoopSize);
		}

		/// <summary>
		/// Size of the array used for testing: 256 MB.
		/// </summary>
		const uint MemoryCopyLoopSize = 4;

		/// <summary>
		/// Number of repetitions for MemoryCopy.
		/// </summary>
		private const int MemoryCopyLoopRepetitions = 5000;

		#endregion
	}
}
