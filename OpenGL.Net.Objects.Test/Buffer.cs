
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

		/// <summary>
		/// Test <see cref="Buffer"/> mapping, CPU buffer specifically.
		/// </summary>
		/// <param name="buffer">
		/// The <see cref="Buffer"/> instance to test.
		/// </param>
		protected void MapBuffer(Buffer buffer)
		{
			// Initially not existing
			Assert.IsFalse(buffer.Exists(_Context));
			Assert.AreEqual(0u, buffer.GpuBufferSize);

			// CPU buffer cannot be mapped
			Assert.IsFalse(buffer.IsMapped);
			Assert.Throws(Is.InstanceOf<Exception>(), delegate { buffer.Map(_Context, BufferAccess.ReadOnly); });

			// Create a client instance
			CreateCpuBuffer(buffer);

			// Still not existing
			Assert.IsFalse(buffer.Exists(_Context));
			// We have CPU buffer
			Assert.Greater(buffer.GpuBufferSize, 0u);
			// Now it is possible to map
			Assert.DoesNotThrow(delegate { buffer.Map(_Context, BufferAccess.ReadOnly); });
			Assert.IsTrue(buffer.IsMapped);

			// Unmap
			Assert.DoesNotThrow(delegate { buffer.Unmap(_Context); });
			// We are not mapped
			Assert.IsFalse(buffer.IsMapped);
		}
	}
}
