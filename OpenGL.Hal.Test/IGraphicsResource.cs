
// Copyright (C) 2010-2015 Luca Piccioni
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
using System.Reflection;

using NSubstitute;
using NUnit.Framework;

namespace OpenGL.Hal.Test
{
	[TestFixture()]
	class IGraphicsResourceTest : TestBase
	{
		[Test, TestCaseSource("TestTypes")]
		public void TestDeleteOnDispose(Type resourceType)
		{
			if (resourceType == null)
				throw new ArgumentNullException("resourceType");

			IGraphicsTypeSupport graphicsTypeSupport = GetGraphicsTypeSupport(resourceType);
			if (graphicsTypeSupport == null)
				Assert.Inconclusive(String.Format("no type support for {0}", resourceType.Name));

			// Assert currency of context
			Assert.IsTrue(_Context.IsCurrent);

			using (IGraphicsResource resource = graphicsTypeSupport.AllocateSpy<IGraphicsResource>(_Context)) {
				if (resource == null)
					Assert.Inconclusive(String.Format("unable to allocate an instance of {0}", resourceType.Name));

				// Create the resource
				Assert.DoesNotThrow(delegate () { graphicsTypeSupport.Create(resource, _Context); });

				Assert.AreNotEqual(0, resource.ObjectName);
				Assert.AreEqual(_Context.ObjectNameSpace, resource.ObjectNamespace);
				Assert.IsTrue(resource.Exists(_Context));

				// Delete the resource
				resource.Dispose();
				// Dispose(GraphicsContext) method shall call the Delete(GraphicsContext) method
				resource.Received().Delete(_Context);

				Assert.AreEqual(0, resource.ObjectName);
				Assert.AreEqual(Guid.Empty, resource.ObjectNamespace);
				Assert.DoesNotThrow(delegate () { resource.Exists(_Context); });
				Assert.IsFalse(resource.Exists(_Context));
			}
		}

		/// <summary>
		/// Test all type
		/// </summary>
		private static Type[] TestTypes
		{
			get
			{
				Type[] libraryTypes = Assembly.GetAssembly(typeof(IResource)).GetTypes();

				return (Array.FindAll(libraryTypes, delegate (Type item) {
					if (item.IsAbstract)
						return (false);
					if (item.IsInterface)
						return (false);
					if (item.IsGenericType)
						return (false);

					return (item.GetInterface("IGraphicsResource") != null);
				}));
			}
		}
	}
}
