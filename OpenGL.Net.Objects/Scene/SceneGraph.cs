
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

namespace OpenGL.Objects.Scene
{
	/// <summary>
	/// Directed graphs of <see cref="SceneObject"/>.
	/// </summary>
	public class SceneGraph : SceneObject
	{
		#region Scene References

		/// <summary>
		/// 
		/// </summary>
		public SceneObjectCamera CurrentView { get { return (_CurrentView); } }

		/// <summary>
		/// 
		/// </summary>
		private SceneObjectCamera _CurrentView;

		#endregion

		#region Draw

		/// <summary>
		/// Draw this SceneGraphObject.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		public void Draw(GraphicsContext ctx)
		{
			CheckCurrentContext(ctx);

			using (SceneGraphContext ctxScene = new SceneGraphContext(this, _CurrentView)) {
				// Override model-view-projection matrices if a camera is defined
				if (_CurrentView != null) {
					LocalProjection = _CurrentView.ProjectionMatrix;
					LocalModel = _CurrentView.LocalModel.GetInverseMatrix();
				}
				// Update
				base.Update(ctx, ctxScene);
				// Base implementation
				base.Draw(ctx, ctxScene);
			}
		}

		#endregion

		#region SceneGraphObject Overrides

		/// <summary>
		/// Add a <see cref="SceneObject"/> as child of this instance.
		/// </summary>
		/// <param name="sceneGraphObject">
		/// The <see cref="SceneObject"/> to be included in the children list of this instance.
		/// </param>
		public override void AddChild(SceneObject sceneGraphObject)
		{
			// Base implementation
			base.AddChild(sceneGraphObject);
			// Set default view
			if ((_CurrentView == null) && (sceneGraphObject is SceneObjectCamera))
				_CurrentView = (SceneObjectCamera)sceneGraphObject;
		}

		/// <summary>
		/// Draw this SceneGraphObject hierarchy.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="ctxScene">
		/// The <see cref="SceneGraphContext"/> used for drawing.
		/// </param>
		protected internal override void Draw(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			if (ctxScene == null)
				throw new ArgumentNullException("ctxScene");

			CheckCurrentContext(ctx);

			// Push and merge the graphics state
			ctxScene.GraphicsStateStack.Push(ObjectState);
			try {
				// Draw all children
				foreach (SceneObject sceneGraphObject in _Children)
					sceneGraphObject.Draw(ctx, ctxScene);
			} finally {
				ctxScene.GraphicsStateStack.Pop();
			}
		}

		#endregion
	}
}
