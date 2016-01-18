
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
using System.Drawing;
using System.Windows.Forms;

namespace OpenGL
{
	/// <summary>
	/// Control able to render using OpenGL.
	/// </summary>
	public partial class GraphicsControl : UserControl
	{
		#region Constructors

		/// <summary>
		/// Construct a RenderControl.
		/// </summary>
		public GraphicsControl()
		{
			// No need to erase window background
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			// No need to draw window background
			SetStyle(ControlStyles.Opaque, true);
			// Buffer control
			SetStyle(ControlStyles.DoubleBuffer, false);
			// Redraw window on resize
			SetStyle(ControlStyles.ResizeRedraw, false);
			// Painting handled by user
			SetStyle(ControlStyles.UserPaint, true);

			InitializeComponent();
		}

		#endregion

		#region Design Properties

		/// <summary>
		/// OpenGL color buffer format, using <see cref="PixelLayout"/> notation.
		/// </summary>
		[Browsable(true)]
		[Description("The type of the color buffer.")]
		[DefaultValue(PixelLayout.RGB24)]
		public PixelLayout ColorFormat
		{
			get { return (SurfaceFormat.ColorType); }
			set
			{
				SurfaceFormat.DefineColorBuffer(value, GraphicsBuffersFormat.BufferPolicy.RequiredAndDegradable);
			}
		}

		/// <summary>
		/// OpenGL depth buffer bits.
		/// </summary>
		[Browsable(true)]
		[Description("Number of bits of the depth buffer.")]
		[DefaultValue(24)]
		public uint DepthBits
		{
			get { return (SurfaceFormat.DepthBits); }
			set
			{
				if (value > 0)
					SurfaceFormat.DefineDepthBuffer(value, GraphicsBuffersFormat.BufferPolicy.RequiredAndDegradable);
				else
					SurfaceFormat.UndefineDepthBuffer();
			}
		}

		/// <summary>
		/// OpenGL stencil buffer bits.
		/// </summary>
		[Browsable(true)]
		[Description("Number of bits of the stencil buffer.")]
		[DefaultValue(0)]
		public uint StencilBits
		{
			get { return (SurfaceFormat.StencilBits); }
			set
			{
				if (value > 0)
					SurfaceFormat.DefineStencilBuffer(value, GraphicsBuffersFormat.BufferPolicy.RequiredAndDegradable);
				else
					SurfaceFormat.UndefineStencilBuffer();
			}
		}

		/// <summary>
		/// OpenGL multisample buffer "bits".
		/// </summary>
		[Browsable(true)]
		[Description("Number of bits of the multisample buffer.")]
		[DefaultValue(0)]
		public uint MultisampleBits
		{
			get { return (SurfaceFormat.MultisampleBits); }
			set
			{
				if (value > 0)
					SurfaceFormat.DefineMultisampleBuffer(value, GraphicsBuffersFormat.BufferPolicy.RequiredAndDegradable);
				else
					SurfaceFormat.UndefineMultisampleBuffer();
			}
		}

		/// <summary>
		/// OpenGL double buffering flag.
		/// </summary>
		[Browsable(true)]
		[Description("Flag indicating whether double buffering is enabled.")]
		[DefaultValue(true)]
		public bool DoubleBuffer
		{
			get { return (SurfaceFormat.DoubleBuffers); }
			set
			{
				if (value)
					SurfaceFormat.DefineDoubleBuffers(GraphicsBuffersFormat.BufferPolicy.RequiredAndDegradable);
				else
					SurfaceFormat.UndefineDoubleBuffers();
			}
		}
		
		/// <summary>
		/// OpenGL swap buffers interval.
		/// </summary>
		[Browsable(true)]
		[Description("Integer specifing the minimum number of video frames that are displayed before a buffer swap will occur.")]
		[DefaultValue(1)]
		public int SwapInterval
		{
			get { return (_SwapInterval); }
			set { _SwapInterval = value; }
		}

		/// <summary>
		/// The surface format used for creating OpenGL visual.
		/// </summary>
		private readonly GraphicsBuffersFormat SurfaceFormat = new GraphicsBuffersFormat();

		#endregion

		#region Graphics Context
		
		/// <summary>
		/// The render context used for rendering on this UserControl.
		/// </summary>
		public GraphicsContext Context { get { return (_RenderContext); } }
		
		/// <summary>
		/// Event raised on control paint time, when a <see cref="GraphicsContext"/> is current.
		/// </summary>
		[Browsable(true)]
		public event EventHandler<GraphicsControlEventArgs> GraphicsContextCreated;

		/// <summary>
		/// Method for raising <see cref="GraphicsContextCreated"/>
		/// </summary>
		/// <param name="args">
		/// The <see cref="GraphicsControlEventArgs"/> that specify the event arguments.
		/// </param>
		protected void RaiseGraphicsContextCreated(GraphicsControlEventArgs args)
		{
			if (GraphicsContextCreated != null) {
				try {
					GraphicsContextCreated(this, args);
				} catch (Exception exception) {
					sLog.Error("Unable to create resources.", exception);
				}
			}
		}

		/// <summary>
		/// Event raised on control paint time, when a <see cref="GraphicsContext"/> is current.
		/// </summary>
		[Browsable(true)]
		public event EventHandler<GraphicsControlEventArgs> GraphicsContextDestroyed;

		/// <summary>
		/// Method for raising <see cref="GraphicsContextDestroyed"/>
		/// </summary>
		/// <param name="args">
		/// The <see cref="GraphicsControlEventArgs"/> that specify the event arguments.
		/// </param>
		protected void RaiseGraphicsContextDestroyed(GraphicsControlEventArgs args)
		{
			if (GraphicsContextDestroyed != null)
				GraphicsContextDestroyed(this, args);
		}

		/// <summary>
		/// A RenderWindow (bound to this UserControl) used for instancing a render context.
		/// </summary>
		private GraphicsWindow _RenderWindow;

		/// <summary>
		/// The swap interval.
		/// </summary>
		private int _SwapInterval = 1;

		/// <summary>
		/// The render context used for rendering on this UserControl.
		/// </summary>
		private GraphicsContext _RenderContext;

		#endregion

		#region Control Rendering

		/// <summary>
		/// Event raised on control paint time, when a <see cref="GraphicsContext"/> is current.
		/// </summary>
		[Browsable(true)]
		public event EventHandler<GraphicsControlEventArgs> Render;

		/// <summary>
		/// Method for raising <see cref="Render"/>
		/// </summary>
		/// <param name="args">
		/// The <see cref="GraphicsControlEventArgs"/> that specify the event arguments.
		/// </param>
		protected void RaiseRenderEvent(GraphicsControlEventArgs args)
		{
			if (Render != null) {
				try {
					Render(this, args);
				} catch (Exception exception) {
					sLog.Error("RenderControl.Render exception caught", exception);
				}
			}
				
		}

		/// <summary>
		/// Render on this UserControl.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for rendering this UserControl.
		/// </param>
		protected virtual void RenderThis(GraphicsContext ctx)
		{
			
		}

		#endregion
		
		#region Logging

		/// <summary>
		/// Logger of this class.
		/// </summary>
		private static readonly ILogger sLog = Log.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion

		#region UserControl Overrides

		/// <summary>
		/// Creates a handle for the control.
		/// </summary>
		protected override void CreateHandle()
		{
			// Create the render window
			_RenderWindow = new GraphicsWindow(this);
			_RenderWindow.Width = (uint)base.ClientSize.Width;
			_RenderWindow.Height = (uint)base.ClientSize.Height;
			// OVerride default swap interval
			_RenderWindow.SwapInterval = SwapInterval;

			// "Select" device pixel format before creating control handle
			switch (Environment.OSVersion.Platform) {
				case PlatformID.Unix:
					_RenderWindow.PreCreateObjectX11(SurfaceFormat);
					break;
			}
			// Base implementation
			base.CreateHandle();
		}
		
		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.Control.HandleCreated"/> event.
		/// </summary>
		/// <param name="e">
		/// An <see cref="T:System.EventArgs"/> that contains the event data.
		/// </param>
		protected override void OnHandleCreated(EventArgs e)
		{
			if (DesignMode == false) {
				// Finalize control handle creation
				// - WGL: SetPixelFormat
				// - GLX: store FBConfig and XVisualInfo selected in CreateHandle()
				// ...
				// - Setup swap interval, if supported
				_RenderWindow.Create((GraphicsContext)null);
				// Create the render context (before event handling)
				_RenderContext = new GraphicsContext(_RenderWindow.GetDeviceContext());
			}
			// Base implementation
			base.OnHandleCreated(e);
			// Raise CreateContext event
			if (DesignMode == false) {
				// It should remains current on the current UI thread
				_RenderContext.MakeCurrent(true);
				RaiseGraphicsContextCreated(new GraphicsControlEventArgs(_RenderContext, _RenderWindow));
			}
		}

		/// <summary>
		/// Raises the <see cref="E:System.Windows.Forms.Control.HandleDestroyed"/> event.
		/// </summary>
		/// <param name="e">
		/// An <see cref="T:System.EventArgs"/> that contains the event data.
		/// </param>
		protected override void OnHandleDestroyed(EventArgs e)
		{
			if (DesignMode == false) {
				if (_RenderContext != null) {
					// Raise DestroyContext event
					_RenderContext.MakeCurrent(true);
					RaiseGraphicsContextDestroyed(new GraphicsControlEventArgs(_RenderContext, _RenderWindow));
					_RenderContext.MakeCurrent(false);
					// Dispose the renderer context
					_RenderContext.Dispose();
					_RenderContext = null;
				}
				// Dispose the renderer window
				if (_RenderWindow != null) {
					_RenderWindow.Dispose();
					_RenderWindow = null;
				}
			}
			// Base implementation
			base.OnHandleDestroyed(e);
		}

		/// <summary>
		/// Raises the Paint event.
		/// </summary>
		/// <param name="e">
		/// A <see cref="PaintEventArgs"/> that contains the event data.
		/// </param>
		protected override void OnPaint(PaintEventArgs e)
		{
			if (DesignMode == false) {
				if (_RenderContext != null) {
					// Render the UserControl
					if (_RenderContext.IsCurrent == false)
						_RenderContext.MakeCurrent(true);
					// Define viewport
					Gl.Viewport(0, 0, ClientSize.Width, ClientSize.Height);
					// Clear
					_RenderWindow.Clear(_RenderContext);

					// Derived class implementation
					RenderThis(_RenderContext);
					// Render event
					RaiseRenderEvent(new GraphicsControlEventArgs(_RenderContext, _RenderWindow));

					// Swap buffers if double-buffering
					_RenderWindow.SwapSurface();

					// Base implementation (overlay GDI graphics)
					base.OnPaint(e);
				} else {
					e.Graphics.DrawLines(_FailurePen, new Point[] {
						new Point(0, 0), new Point(ClientSize.Width, ClientSize.Height),
						new Point(0, ClientSize.Height), new Point(ClientSize.Width, 0),
					});

					// Base implementation
					base.OnPaint(e);
				}
			} else {
				e.Graphics.Clear(Color.Black);
				e.Graphics.DrawLines(_DesignPen, new Point[] {
					new Point(0, 0), new Point(ClientSize.Width, ClientSize.Height),
					new Point(0, ClientSize.Height), new Point(ClientSize.Width, 0),
				});

				// Base implementation
				base.OnPaint(e);
			}
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">
		/// true if managed resources should be disposed; otherwise, false.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			// Dispose designer components
			if (disposing && (components != null))
				components.Dispose();

			// Dispose pens
			_FailurePen.Dispose();
			_DesignPen.Dispose();

			// Base implementation
			base.Dispose(disposing);
		}

		/// <summary>
		/// Pen used for drawing in the case of failures.
		/// </summary>
		private static readonly Pen _FailurePen = new Pen(Color.Red, 1.5f);

		/// <summary>
		/// Pen used for drawing in the case the UserControl at design time.
		/// </summary>
		private static readonly Pen _DesignPen = new Pen(Color.Green, 1.0f);

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
		/// The <see cref="GraphicsSurface"/> displaying the rendering result.
		/// </param>
		public GraphicsControlEventArgs(GraphicsContext ctx, GraphicsSurface framebuffer)
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
		/// The render context used for rendering.
		/// </summary>
		public readonly GraphicsContext Context;

		/// <summary>
		/// The actual surface used for rendering.
		/// </summary>
		public readonly GraphicsSurface Framebuffer;

		#endregion
	}
}
