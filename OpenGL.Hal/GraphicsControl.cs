
// Copyright (C) 2011-2015 Luca Piccioni
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
			// No need to draw window background
			SetStyle(ControlStyles.Opaque, true);
			// Painting handled by user
			SetStyle(ControlStyles.UserPaint, true);
			// No need to erase window background
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			// Redraw window on resize
			SetStyle(ControlStyles.ResizeRedraw, true);
			// Buffer control
			SetStyle(ControlStyles.DoubleBuffer, false);

			InitializeComponent();
		}

		#endregion

		#region Render Surface

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
		[DefaultValue(false)]
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
		/// The actual surface implementation used for rendering.
		/// </summary>
		public GraphicsSurface Surface { get { return (_RenderWindow); } }

		/// <summary>
		/// The surface format used for creating OpenGL visual.
		/// </summary>
		public readonly GraphicsBuffersFormat SurfaceFormat = new GraphicsBuffersFormat();
		
		/// <summary>
		/// A RenderWindow (bound to this UserControl) used for instancing a render context.
		/// </summary>
		private GraphicsWindow _RenderWindow;
		
		/// <summary>
		/// The swap interval.
		/// </summary>
		private int _SwapInterval = 1;

		#endregion

		#region Render Context
		
		/// <summary>
		/// Create a resource to be used withing this RenderControl.
		/// </summary>
		/// <param name="resource">
		/// A <see cref="IRenderResource"/> that needs to be created to be used within this RenderControl.
		/// </param>
		public void Create(IGraphicsResource resource)
		{
			if (resource == null)
				throw new ArgumentNullException("resource");

			if (!_RenderContext.IsCurrent)
				_RenderContext.MakeCurrent(true);

			resource.Create(_RenderContext);
		}

		/// <summary>
		/// The render context used for rendering on this UserControl.
		/// </summary>
		public GraphicsContext Context { get { return (_RenderContext); } }
		
		/// <summary>
		/// Event raised on control paint time, when a <see cref="GraphicsContext"/> is current.
		/// </summary>
		[Browsable(true)]
		public event RenderEventHandler CreateContext;

		/// <summary>
		/// Event raised on control paint time, when a <see cref="GraphicsContext"/> is current.
		/// </summary>
		[Browsable(true)]
		public event RenderEventHandler DestroyContext;

		protected void RaiseCreateContextEvent(RenderEventArgs args)
		{
			if (CreateContext != null)
				CreateContext(this, args);
		}

		protected void RaiseDestroyContextEvent(RenderEventArgs args)
		{
			if (DestroyContext != null)
				DestroyContext(this, args);
		}

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
		public event RenderEventHandler Render;

		protected void RaiseRenderEvent(RenderEventArgs args)
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
		
		protected override void CreateHandle()
		{
			// Create the render window
			_RenderWindow = new GraphicsWindow(this);
			_RenderWindow.Width = (uint)base.ClientSize.Width;
			_RenderWindow.Height = (uint)base.ClientSize.Height;
			
			// "Select" device pixel format before creating control handle
			switch (Environment.OSVersion.Platform) {
				case PlatformID.Unix:
					_RenderWindow.PreCreateObjectX11(SurfaceFormat);
					break;
			}
			
			// OVerride default swap interval
			_RenderWindow.SwapInterval = SwapInterval;
			
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
				_RenderContext.MakeCurrent(true);
				RaiseCreateContextEvent(new RenderEventArgs(_RenderContext, _RenderWindow));
				_RenderContext.MakeCurrent(false);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		protected override void OnHandleDestroyed(EventArgs e)
		{
			if (DesignMode == false) {
				if (_RenderContext != null) {
					// Raise DestroyContext event
					_RenderContext.MakeCurrent(true);
					RaiseDestroyContextEvent(new RenderEventArgs(_RenderContext, _RenderWindow));
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
		/// 
		/// </summary>
		/// <param name="e"></param>
		protected override void OnPaint(PaintEventArgs e)
		{
			if (DesignMode == false) {
				if (_RenderContext != null) {
					// Render the UserControl
					_RenderContext.MakeCurrent(true);
					// Define viewport
					Gl.Viewport(0, 0, ClientSize.Width, ClientSize.Height);

					// Derived class implementation
					RenderThis(_RenderContext);
					
					// Render event
					RaiseRenderEvent(new RenderEventArgs(_RenderContext, _RenderWindow));

					// Swap buffers if double-buffering
					Surface.SwapSurface();

					// Base implementation
					base.OnPaint(e);

					_RenderContext.MakeCurrent(false);
				} else {
					e.Graphics.DrawLines(mFailurePen, new Point[] {
						new Point(e.ClipRectangle.Left, e.ClipRectangle.Bottom), new Point(e.ClipRectangle.Right, e.ClipRectangle.Top),
						new Point(e.ClipRectangle.Left, e.ClipRectangle.Top), new Point(e.ClipRectangle.Right, e.ClipRectangle.Bottom),
					});

					// Base implementation
					base.OnPaint(e);
				}
			} else {
				e.Graphics.Clear(Color.Black);
				e.Graphics.DrawLines(mDesignPen, new Point[] {
						new Point(e.ClipRectangle.Left, e.ClipRectangle.Bottom), new Point(e.ClipRectangle.Right, e.ClipRectangle.Top),
						new Point(e.ClipRectangle.Left, e.ClipRectangle.Top), new Point(e.ClipRectangle.Right, e.ClipRectangle.Bottom),
					});

				// Base implementation
				base.OnPaint(e);
			}
		}
		
		protected override void OnClientSizeChanged(EventArgs e)
		{
			if (_RenderWindow != null) {
				_RenderWindow.Width = (uint)base.ClientSize.Width;
				_RenderWindow.Height = (uint)base.ClientSize.Height;
			}
			
			// Base implementation
			base.OnClientSizeChanged(e);
		}
		
		private static readonly Pen mFailurePen = new Pen(Color.Red, 1.5f);

		private static readonly Pen mDesignPen = new Pen(Color.Green, 1.0f);

		#endregion
	}

	/// <summary>
	/// 
	/// </summary>
	public class RenderEventArgs : EventArgs
	{
		/// <summary>
		/// Construct a RenderEventArgs.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for rendering.
		/// </param>
		/// <param name="window">
		/// The <see cref="GraphicsWindow"/> displaying the rendering result.
		/// </param>
		public RenderEventArgs(GraphicsContext ctx, GraphicsWindow window)
		{
			Context = ctx;
			Window = window;
		}

		/// <summary>
		/// The render context used for rendering.
		/// </summary>
		public readonly GraphicsContext Context;

		/// <summary>
		/// The surface displaying the rendering result.
		/// </summary>
		public readonly GraphicsWindow Window;
	}

	/// <summary>
	/// Delegate for handling <see cref="GraphicsControl.Render"/> event.
	/// </summary>
	public delegate void RenderEventHandler(object sender, RenderEventArgs args);
}
