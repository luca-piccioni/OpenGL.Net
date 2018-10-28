
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

namespace OpenGL.Objects.Test
{
	abstract class BufferTest : TestBase
	{
		protected abstract void CreateCpuBuffer(Buffer buffer);

		protected abstract void CreateGpuBuffer(Buffer buffer);

		#region Buffer.Map()

		/// <summary>
		/// Test <see cref="Buffer"/> mapping, CPU buffer specifically.
		/// </summary>
		/// <param name="buffer">
		/// The <see cref="Buffer"/> instance to test.
		/// </param>
		protected void MapBufferCpu(Buffer buffer)
		{
			// Initially not existing
			Assert.IsFalse(buffer.Exists(_Context));
			// No CPU buffer
			Assert.AreEqual(0u, buffer.CpuBufferSize);
			// CPU buffer cannot be mapped
			Assert.IsFalse(buffer.IsMapped);
			Assert.Throws(Is.InstanceOf<Exception>(), delegate { buffer.Map(); });

			// Create a client instance
			CreateCpuBuffer(buffer);

			// Still not existing
			Assert.IsFalse(buffer.Exists(_Context));
			// We have CPU buffer
			Assert.Greater(buffer.CpuBufferSize, 0u);
			// Now it is possible to map
			Assert.DoesNotThrow(delegate { buffer.Map(); });
			Assert.IsTrue(buffer.IsMapped);

			// Unmap
			Assert.DoesNotThrow(delegate { buffer.Unmap(); });
			// We are not mapped
			Assert.IsFalse(buffer.IsMapped);
		}

		#endregion

		#region Immutability

		protected static void CreateMutableBuffer(Buffer buffer)
		{
			Assert.IsFalse(buffer.Immutable);
		}

		protected static void CreateImmutableBuffer(Buffer buffer)
		{
			Assert.IsTrue(buffer.Immutable);
		}

		#endregion
	}
}
