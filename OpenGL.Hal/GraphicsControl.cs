
// Copyright (C) 2011-2016 Luca Piccioni
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
using System.ComponentModel;

namespace OpenGL
{
	/// <summary>
	/// Basic <see cref="GlControl"/> for rendering.
	/// </summary>
	public partial class GraphicsControl : GlControl
	{
		#region Constructors

		/// <summary>
		/// Construct a GraphicsControl.
		/// </summary>
		public GraphicsControl()
		{
			InitializeComponent();
		}

		#endregion

		#region Graphics Context

		/// <summary>
		/// The render context used for rendering on this GraphicsControl.
		/// </summary>
		public GraphicsContext Context
		{
			get { return (_GraphicsContext); }
		}

		/// <summary>
		/// The render context used for rendering on this GraphicsControl.
		/// </summary>
		private GraphicsContext _GraphicsContext;

		#endregion

		#region GlControl Overrides

		/// <summary>
		/// Create the GlControl context.
		/// </summary>
		protected override void CreateContext()
		{
			if (_GraphicsContext != null)
				throw new InvalidOperationException("context already created");

			// Create OpenGL context
			_GraphicsContext = new GraphicsContext(_DeviceContext, null, null, GraphicsContextFlags.CompatibilityProfile);
			// Emulates GlControl behaviour
			_RenderContext = _GraphicsContext.Handle;
		}

		/// <summary>
		/// Make the GlControl context current.
		/// </summary>
		protected override void MakeCurrentContext()
		{
			// Make context current
			_GraphicsContext.MakeCurrent(true);
		}

		/// <summary>
		/// Delete the GlControl context.
		/// </summary>
		protected override void DeleteContext()
		{
			// Delete OpenGL context
			_GraphicsContext.Dispose();
			_GraphicsContext = null;
			// Emulates GlControl behaviour
			_RenderContext = IntPtr.Zero;
		}

		#endregion
	}
}
