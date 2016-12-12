
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
	/// Scene object representing a geometry.
	/// </summary>
	public class SceneObjectGeometry : SceneObject
	{
		#region Constructors

		/// <summary>
		/// Construct a SceneObjectGeometry.
		/// </summary>
		public SceneObjectGeometry()
		{
			
		}

		/// <summary>
		/// Construct a SceneObjectGeometry.
		/// </summary>
		/// <param name="id">
		/// A <see cref="String"/> that specify the node identifier. It can be null for unnamed objects.
		/// </param>
		public SceneObjectGeometry(string id) : base(id)
		{
			
		}

		/// <summary>
		/// Construct a SceneObjectGeometry.
		/// </summary>
		/// <param name="id">
		/// A <see cref="String"/> that specify the node identifier. It can be null for unnamed objects.
		/// </param>
		/// <param name="vertexArray">
		/// A <see cref="VertexArrayObject"/> that specifies the geometry primitive arrays.
		/// </param>
		/// <param name="program">
		/// A <see cref="ShaderProgram"/> that specifies the program used for shading <paramref name="vertexArray"/>.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="vertexArray"/> is null.
		/// </exception>
		public SceneObjectGeometry(string id, VertexArrayObject vertexArray, ShaderProgram program) : base(id)
		{
			if (vertexArray == null)
				throw new ArgumentNullException("vertexArray");

			_VertexArray = vertexArray;
			_Program = program;
		}

		#endregion

		#region Geometry Definition

		/// <summary>
		/// Get or set the geometry primitive arrays.
		/// </summary>
		public VertexArrayObject VertexArray
		{
			get { return (_VertexArray); }
			set
			{
				if (_VertexArray != null)
					_VertexArray.DecRef();

				_VertexArray = value;

				if (_VertexArray != null)
					_VertexArray.IncRef();
			}
		}

		/// <summary>
		/// Primitive arrays.
		/// </summary>
		private VertexArrayObject _VertexArray;

		/// <summary>
		/// Get or set the shader used for drawing the geometry.
		/// </summary>
		public ShaderProgram Program
		{
			get { return (_Program); }
			set
			{
				if (_Program != null)
					_Program.DecRef();

				_Program = value;

				if (_Program != null)
					_Program.IncRef();
			}
		}

		/// <summary>
		/// Shader used for drawing the geometry.
		/// </summary>
		private ShaderProgram _Program;

		#endregion

		#region SceneObjectGeometry Overrides

		/// <summary>
		/// Draw this SceneGraphObject instance.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="ctxScene">
		/// The <see cref="SceneGraphContext"/> used for drawing.
		/// </param>
		protected override void DrawThis(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			// Apply current state
			ctxScene.GraphicsStateStack.Current.Apply(ctx, _Program);
			// Draw arrays
			_VertexArray.Draw(ctx, _Program);
		}

		/// <summary>
		/// Actually create this GraphicsResource resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		/// <remarks>
		/// All resources linked with <see cref="LinkResource(IGraphicsResource)"/> will be automatically created.
		/// </remarks>
		protected override void CreateObject(GraphicsContext ctx)
		{
			// Create geometry state
			VertexArray.Create(ctx);
			if (Program != null)
				Program.Create(ctx);

			// Base implementation
			base.CreateObject(ctx);
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="Boolean"/> indicating whether this method is called by <see cref="Dispose()"/>. If it is false,
		/// this method is called by the finalizer.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				VertexArray = null;
				Program = null;
			}
			// Base implementation
			base.Dispose(disposing);
		}

		#endregion
	}
}
