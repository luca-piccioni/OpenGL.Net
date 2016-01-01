
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

using NUnit.Framework;

namespace OpenGL.Hal.Test
{
	[TestFixture()]
	class GraphicsResourceTest : TestBase
	{
		#region Basic Support Routines

		private void TestLifetime(Type resourceType)
		{
			if (resourceType == null)
				throw new ArgumentNullException("resourceType");

			GraphicsResource resource = null;

			try {
				// Allocate resource
				Assert.DoesNotThrow(delegate { resource = AllocateResource(resourceType, _Context); });
				Assert.IsNotNull(resource, "resource not allocated");
				Assert.IsFalse(resource.Exists(_Context), "resource existing after allocation");

				// Create resource
				Assert.DoesNotThrow(delegate { CreateResource(resourceType, _Context, resource); });
				Assert.IsTrue(resource.Exists(_Context), "resource not existing after creation");

				// After deletion, it doesn't exists
				Assert.DoesNotThrow(delegate { DisposeResource(resourceType, _Context, resource); });
				Assert.IsFalse(resource.Exists(_Context), "resource existing after deleation");

				// After disposition, it does not exists
				Assert.DoesNotThrow(delegate { resource.Create(_Context); }, "unable to re-created resource after deletion");
				Assert.DoesNotThrow(delegate { resource.Dispose(); }, "disposition cause exceptions");
				Assert.IsFalse(resource.Exists(_Context), "resource existing after disposition");

				resource = null;
			} finally {
				if (resource != null)
					resource.Dispose();
			}
		}

		private GraphicsResource AllocateResource(Type resourceType, GraphicsContext ctx)
		{
			if (resourceType == null)
				throw new ArgumentNullException("resourceType");
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			MethodInfo allocateMethod = GetType().GetMethod("Allocate" + resourceType.Name, new Type[0]);
			
			GraphicsResource resource;

			if (allocateMethod == null) {

				// Invoke parameterless conctructor

				if (resourceType.ContainsGenericParameters) {
					resource = (GraphicsResource)Activator.CreateInstance(resourceType.MakeGenericType(typeof(float)));
				} else {
					resource = (GraphicsResource)Activator.CreateInstance(resourceType);
				}

			} else {

				// Invoke specific allocator

				resource = (GraphicsResource)allocateMethod.Invoke(this, new object[0]);
			}

			return (resource);
		}

		private void CreateResource(Type resourceType, GraphicsContext ctx, GraphicsResource resource)
		{
			if (resourceType == null)
				throw new ArgumentNullException("resourceType");
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (resource == null)
				throw new ArgumentNullException("resource");

			MethodInfo createMethod = GetType().GetMethod("Create" + resourceType.Name, new Type[] { typeof(GraphicsContext), typeof(GraphicsResource) });

			if (createMethod != null)
				createMethod.Invoke(this, new object[] { ctx, resource });
			else
				resource.Create(ctx);
		}

		private void DisposeResource(Type resourceType, GraphicsContext ctx, GraphicsResource resource)
		{
			if (resourceType == null)
				throw new ArgumentNullException("resourceType");
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (resource == null)
				throw new ArgumentNullException("resource");

			MethodInfo disposeMethod = GetType().GetMethod("Delete" + resourceType.Name, new Type[] { typeof(GraphicsContext), typeof(GraphicsResource) });

			if (disposeMethod != null)
				disposeMethod.Invoke(this, new object[] { ctx, resource });
			else
				resource.Dispose();
		}

		#endregion

		[Test]
		public void TestLifetime()
		{
			Type[] resourceTypes = new Type[] {
				typeof(ShaderObject), typeof(ShaderProgram),
				typeof(Texture2d), typeof(TextureRectangle)
			};
			
			foreach (Type resourceType in resourceTypes) {
				TestLifetime(resourceType);
			}
		}
	}
}
