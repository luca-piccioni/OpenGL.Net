
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
using System.Reflection;

using NUnit.Framework;

namespace OpenGL.Test
{
	/// <summary>
	/// Abstract base test creating benchmarking methods.
	/// </summary>
	[TestFixture, RequiresSTA]
	abstract class BenchmarkBase
	{
		protected static void RunBenchmarks<T>(string prefix) where T : BenchmarkBase
		{
			foreach (MethodInfo method in typeof(T).GetMethods(BindingFlags.Static | BindingFlags.Public)) {
				if (prefix != null && method.Name.StartsWith(prefix) == false)
					continue;

				BenchmarkAttribute benchmarkAttr = (BenchmarkAttribute)method.GetCustomAttribute(typeof(BenchmarkAttribute));
				if (benchmarkAttr == null)
					continue;

				Run(benchmarkAttr, method);
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
