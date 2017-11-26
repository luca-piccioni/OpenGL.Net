
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
using System.Diagnostics;
using System.Reflection;

using NUnit.Framework;

namespace OpenGL.Test
{
	/// <summary>
	/// Abstract base test creating benchmarking methods.
	/// </summary>
	[TestFixture]
//#if !NETCORE
//	[Apartment(ApartmentState.STA)]
//#endif
	[Category("Benchmark")]
	abstract class TestBaseBenchmark
	{
		public static void RunBenchmarks<T>(string prefix) where T : class
		{
			foreach (MethodInfo method in typeof(T).GetMethods(BindingFlags.Static | BindingFlags.Public)) {
				if (prefix != null && method.Name.StartsWith(prefix) == false)
					continue;

				object[] benchmarkAttrs = method.GetCustomAttributes(typeof(BenchmarkAttribute), true);
				if (benchmarkAttrs.Length == 0)
					continue;

				Run((BenchmarkAttribute)benchmarkAttrs[0], method);
			}
		}

		/// <summary>
		/// Run a benchmark.
		/// </summary>
		/// <param name="name">
		/// A <see cref="String"/> that specifies the name of the benchmark.
		/// </param>
		/// <param name="action"></param>
		private static void Run(BenchmarkAttribute benchmark, MethodInfo method)
		{
			Stopwatch crono = new Stopwatch();

			crono.Start();
			for (int r = 0; r < benchmark.Repetitions; r++)
				method.Invoke(null, null);

			crono.Stop();
			
			Console.WriteLine("{0}: {1} [ms]", benchmark.Name, crono.ElapsedMilliseconds);
		}
	}
}
