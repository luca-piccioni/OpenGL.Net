
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
	public partial class GraphicsControl : GlControl, IGraphicsSurface
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

		#region Design Properties

		/// <summary>
		/// OpenGL context flags.
		/// </summary>
		[Browsable(true)]
		[Description("The graphics context flags.")]
		[DefaultValue(GraphicsContextFlags.None)]
		[Editor(typeof(GraphicsContextFlagsEditor), typeof(System.Drawing.Design.UITypeEditor))]
		public GraphicsContextFlags ContextFlags
		{
			get { return (_ContextFlags); }
			set { _ContextFlags = value; }
		}

		/// <summary>
		/// Graphics context flags.
		/// </summary>
		private GraphicsContextFlags _ContextFlags = GraphicsContextFlags.None;

		#endregion

		#region Graphics Context

		/// <summary>
		/// The render context used for rendering on this UserControl.
		/// </summary>
		private GraphicsContext _GraphicsContext;

		#endregion

		#region Events

		/// <summary>
		/// Event raised on control creation time, allow user to allocate resource on control.
		/// </summary>
		public event EventHandler<GraphicsControlEventArgs> GraphicsContextCreated;

		/// <summary>
		/// Raise the event <see cref="GraphicsContextCreated"/>.
		/// </summary>
		protected virtual void OnGraphicsContextCreated()
		{
			if (GraphicsContextCreated != null) {
				MakeCurrentContext();
				GraphicsContextCreated(this, new GraphicsControlEventArgs(_GraphicsContext, this));
			}
		}

		/// <summary>
		/// Event raised on control disposition time, allow user to dispose resources on control.
		/// </summary>
		public event EventHandler<GraphicsControlEventArgs> GraphicsContextDestroying;

		/// <summary>
		/// Raise the event <see cref="GraphicsContextDestroying"/>.
		/// </summary>
		protected void OnGraphicsContextDestroying()
		{
			if (GraphicsContextDestroying != null)
				GraphicsContextDestroying(this, new GraphicsControlEventArgs(_GraphicsContext, this));
		}

		/// <summary>
		/// Event raised on control render time, allow user to draw on control.
		/// </summary>
		public event EventHandler<GraphicsControlEventArgs> Draw;

		/// <summary>
		/// Raise the event <see cref="Draw"/>.
		/// </summary>
		protected virtual void OnDraw()
		{
			if (Draw != null)
				Draw(this, new GraphicsControlEventArgs(_GraphicsContext, this));
		}

		#endregion

		#region Logging

		/// <summary>
		/// Logger of this class.
		/// </summary>
		private static readonly ILogger sLog = Log.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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
			_GraphicsContext = new GraphicsContext(_DeviceContext, null, null, _ContextFlags);
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
			// Event handling
			OnGraphicsContextDestroying();
			// Delete OpenGL context
			_GraphicsContext.Dispose();
			_GraphicsContext = null;
			// Emulates GlControl behaviour
			_RenderContext = IntPtr.Zero;
		}

		/// <summary>
		/// Raise the event <see cref="ContextCreated"/>.
		/// </summary>
		protected override void OnContextCreated()
		{
			// Own event arguments
			OnGraphicsContextCreated();
			// Base implementation
			base.OnContextCreated();
		}

		/// <summary>
		/// Raise the event <see cref="ContextDestroying"/>.
		/// </summary>
		protected override void OnContextDestroying()
		{
			// Own event arguments
			OnGraphicsContextDestroying();
			// Base implementation
			base.OnContextDestroying();
		}

		/// <summary>
		/// Raise the event <see cref="Render"/>.
		/// </summary>
		protected override void OnRender()
		{
			// Own event arguments
			OnDraw();
			// Base implementation
			base.OnRender();
		}

		#endregion

		#region IGraphicsSurface Implementation

		/// <summary>
		/// The width of the surface, in pixels.
		/// </summary>
		uint IGraphicsSurface.Width { get { return ((uint)ClientSize.Width); } }

		/// <summary>
		/// The width of the surface, in pixels.
		/// </summary>
		uint IGraphicsSurface.Height { get { return ((uint)ClientSize.Height); } }

		#endregion
	}

	/// <summary>
	/// The arguments of the events defined by <see cref="GraphicsControl"/>.
	/// </summary>
	public class GraphicsControlEventArgs : EventArgs
	{
		#region Constructors

		/// <summary>
		/// Construct a GraphicsControlEventArgs.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for the <see cref="GraphicsControl"/>.
		/// </param>
		/// <param name="framebuffer">
		/// The <see cref="IGraphicsSurface"/> holding the drawing operation result.
		/// </param>
		public GraphicsControlEventArgs(GraphicsContext ctx, IGraphicsSurface framebuffer)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (framebuffer == null)
				throw new ArgumentNullException("framebuffer");

			Context = ctx;
			Framebuffer = framebuffer;
		}

		#endregion

		#region Event Arguments

		/// <summary>
		/// The graphics context used for rendering.
		/// </summary>
		public readonly GraphicsContext Context;

		/// <summary>
		/// The actual surface used for rendering.
		/// </summary>
		public readonly IGraphicsSurface Framebuffer;

		#endregion
	}
}
