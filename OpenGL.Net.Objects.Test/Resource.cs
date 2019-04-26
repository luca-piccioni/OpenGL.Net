
// Copyright (C) 2019 Luca Piccioni
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

using NUnit.Framework;

namespace OpenGL.Objects.Test
{
	[TestFixture(Category = "Objects")]
	class ResourceTest
	{
		class TestResource : Resource
		{

		}

		[Test]
		public void Resource_IncRef()
		{
			Resource resurrection;

			using (Resource resource = new TestResource()) {
				// Keep reference outside the using statement
				resurrection = resource;

				Assert.IsFalse(resource.IsDisposed);

				// IncRef increment the reference count
				resource.IncRef();
				Assert.AreEqual(1u, resource.RefCount);
			}
			Assert.IsTrue(resurrection.IsDisposed);

			using (Resource resource = new TestResource()) {
				// Keep reference outside the using statement
				resurrection = resource;

				Assert.IsFalse(resource.IsDisposed);

				// IncRef increment the reference count
				resource.IncRef();
				resource.IncRef();
				Assert.AreEqual(2u, resource.RefCount);

				// The resource shall not be disposed even is exiting from a using statement
			}
			Assert.IsFalse(resurrection.IsDisposed);

			// Really dispose, since decrementing reference count
			resurrection.DecRef();
			Assert.IsTrue(resurrection.IsDisposed);
		}

		[Test]
		public void Resource_DecRef()
		{
			Resource resource;

			// Calling DecRef with a RefCount equal to 0 dispose
			resource = new TestResource();
			Assert.IsFalse(resource.IsDisposed);
			Assert.AreEqual(0u, resource.RefCount);

			resource.DecRef();
			Assert.IsTrue(resource.IsDisposed);

			// Calling DecRef with a RefCount equal to 1 dispose all the same
			resource = new TestResource();
			Assert.IsFalse(resource.IsDisposed);
			Assert.AreEqual(0u, resource.RefCount);

			resource.IncRef();
			Assert.AreEqual(1u, resource.RefCount);

			resource.DecRef();
			Assert.IsTrue(resource.IsDisposed);
		}

		[Test]
		public void Resource_IDisposable()
		{
			Resource resurrection;

			// Resource usable in using blocks as usual
			using (Resource resource = new TestResource()) {
				Assert.IsFalse(resource.IsDisposed);

				Assert.AreEqual(0u, resource.RefCount);

				resurrection = resource;
			}
			Assert.IsTrue(resurrection.IsDisposed);
		}
	}
}
