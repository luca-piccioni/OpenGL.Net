
// Copyright (C) 2016-2017 Luca Piccioni
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

using NUnit.Framework;

namespace OpenGL.Test
{
	//[TestFixture]
	class TestMemory : TestBaseBenchmark
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
			Array.Copy(_BenchmarkDataMemoryCopy, _BenchmarkDataMemoryCopyDst, (int)MemoryCopySize);
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
		/// Size of the array used for testing: 16 MB.
		/// </summary>
		const uint MemoryCopySize = 1024 * 1024 * 16;

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
