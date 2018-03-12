
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
			ViewFrustumPlanes = Planef.GetFrustumPlanes(Scene.ProjectionMatrix);
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
		public readonly IEnumerable<Planef> ViewFrustumPlanes;

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
