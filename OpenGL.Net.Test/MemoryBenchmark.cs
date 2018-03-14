
// Copyright (C) 2018 Luca Piccioni
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

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Jobs;

namespace OpenGL.Test
{
	[ClrJob(true), RankColumn]
	public class MemoryBenchmarkCopy
	{
		[GlobalSetup]
		public void Memory_CopyBenchmarkSetup()
		{
			_BenchmarkArraySrc = new byte[ushort.MaxValue];
			_BenchmarkArrayDst = new byte[ushort.MaxValue];
		}

		private byte[] _BenchmarkArraySrc, _BenchmarkArrayDst;

		[Params(4, 16, 256, 512, 4096, 8192)]
		public int Memory_CopyBenchmarkParams;

		[Benchmark()]
		public void Memory_CopyBenchmarkSystem()
		{
			Memory.UseSystemCopy = true;
			using (MemoryLock srcLock = new MemoryLock(_BenchmarkArraySrc)) {
				Memory.Copy(_BenchmarkArrayDst, srcLock.Address, (ulong)Memory_CopyBenchmarkParams);
			}
		}

		[Benchmark]
		public void Memory_CopyBenchmarkManaged()
		{
			Memory.UseSystemCopy = false;
			using (MemoryLock srcLock = new MemoryLock(_BenchmarkArraySrc)) {
				Memory.Copy(_BenchmarkArrayDst, srcLock.Address, (ulong)Memory_CopyBenchmarkParams);
			}
		}
	}
}
