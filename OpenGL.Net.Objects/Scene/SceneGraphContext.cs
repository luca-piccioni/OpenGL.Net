
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
using System.Collections.Generic;
using OpenGL.Objects.State;

namespace OpenGL.Objects.Scene
{
	/// <summary>
	/// Context used for drawing a SceneGraph.
	/// </summary>
	public sealed class SceneGraphContext : IDisposable
	{
		#region Constructors

		public SceneGraphContext(SceneGraph sceneGraph)
		{
			if (sceneGraph == null)
				throw new ArgumentNullException("sceneGraph");

			Scene = sceneGraph;
			ViewFrustumPlanes = Plane.GetFrustumPlanes(Scene.ProjectionMatrix);
		}

		#endregion

		#region Scene State

		/// <summary>
		/// The scene currently rendering.
		/// </summary>
		public readonly SceneGraph Scene;

		/// <summary>
		/// The <see cref="GraphicsStateSetStack"/> supporting state variation during the scene graph traversal.
		/// </summary>
		public readonly GraphicsStateSetStack GraphicsStateStack = new GraphicsStateSetStack();

		/// <summary>
		/// Pre-compute view-frustum planes to cull scene objects.
		/// </summary>
		public readonly IEnumerable<Plane> ViewFrustumPlanes;

		#endregion

		#region IDisposable Implementation

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{

		}

		#endregion
	}
}
