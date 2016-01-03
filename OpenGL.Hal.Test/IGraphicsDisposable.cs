
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
	class IGraphicsDisposableTest : TestBase
	{
		[Test, TestCaseSource("TestTypes")]
		public void TestCurrentDispose(Type resourceType)
		{
			if (resourceType == null)
				throw new ArgumentNullException("resourceType");

			IGraphicsTypeSupport graphicsTypeSupport = GetGraphicsTypeSupport(resourceType);
			if (graphicsTypeSupport == null)
				Assert.Inconclusive(String.Format("no type support for {0}", resourceType.Name));

			// Assert currency of context
			Assert.IsTrue(_Context.IsCurrent);

			using (IGraphicsDisposable resource = graphicsTypeSupport.AllocateSpy<IGraphicsDisposable>(_Context)) {
				if (resource == null)
					Assert.Inconclusive(String.Format("unable to allocate an instance of {0}", resourceType.Name));

				// Create the resource
				Assert.DoesNotThrow(delegate () { graphicsTypeSupport.Create(resource, _Context); });
				// Call Dispose() method
				Assert.DoesNotThrow(delegate () { resource.Dispose(); });
				// Dispose() method shall call the Dispose(GraphicsContext) method since it is current
				resource.Received().Dispose(_Context);
			}
		}

		[Test, TestCaseSource("TestTypes")]
		public void TestVoidDispose(Type resourceType)
		{
			if (resourceType == null)
				throw new ArgumentNullException("resourceType");

			IGraphicsTypeSupport graphicsTypeSupport = GetGraphicsTypeSupport(resourceType);
			if (graphicsTypeSupport == null)
				Assert.Inconclusive(String.Format("no type support for {0}", resourceType.Name));

			using (IGraphicsDisposable resource = graphicsTypeSupport.AllocateSpy<IGraphicsDisposable>(_Context)) {
				if (resource == null)
					Assert.Inconclusive(String.Format("unable to allocate an instance of {0}", resourceType.Name));

				// Do NOT create the resource

				// Call Dispose() method
				resource.Dispose();
				// Dispose method shall not call the Dispose(GraphicsCo ntext) method since no object
				// need to be released
				resource.DidNotReceive().Dispose(_Context);
			}
		}

		/// <summary>
		/// Test all type
		/// </summary>
		private static Type[] TestTypes
		{
			get
			{
				Type[] libraryTypes = Assembly.GetAssembly(typeof(IGraphicsDisposable)).GetTypes();

				return (Array.FindAll(libraryTypes, delegate (Type item) {
					if (item.IsAbstract)
						return (false);
					if (item.IsInterface)
						return (false);
					if (item.IsGenericType)
						return (false);
					if (item.IsSealed)
						return (false);

					// Note: GraphicsWindow as IGraphicsDisposable is somewhat an exception to the design pattern, since
					// its object namespace cannot match with the device context. Need to rethink the GraphicsWindow.Dispose
					// implementation, since a GraphicsContext could be created within the class, and used to create resources
					// associated with the window.

					if (item.GetType() == typeof(GraphicsWindow))
						return (false);

					return (item.GetInterface("IGraphicsDisposable") != null);
				}));
			}
		}
	}
}
