
// Copyright (C) 2009-2015 Luca Piccioni
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
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace OpenGL
{
	/// <summary>
	/// Rendering window.
	/// </summary>
	/// <remarks>
	/// <para>
	/// A GraphicsWindow shall be considered an object able to output the graphical result
	/// of some rendering operation. A GraphicsWindow instance must have associated a GraphicsContext
	/// instance.
	/// </para>
	/// </remarks>
	public class GraphicsWindow : GraphicsSurface
	{
		#region Constructors

		/// <summary>
		/// Construct a GraphicsWindow.
		/// </summary>
		public GraphicsWindow() :
			this(0, 0)
		{

		}

		/// <summary>
		/// Construct a GraphicsWindow specifying its extents.
		/// </summary>
		/// <param name="w">
		/// A <see cref="System.Int32"/> specifing window width (in pixels).
		/// </param>
		/// <param name="h">
		/// A <see cref="System.Int32"/> specifing window height (in pixels).
		/// </param>
		public GraphicsWindow(uint w, uint h) :
			base(w, h)
		{
			// Create Form linked with this GraphicsWindow
			_RenderControl = _RenderForm = new RenderForm(this);
			// Obtain device context (relative to window)
			_DeviceContext = DeviceContextFactory.Create(_RenderForm);
		}

		/// <summary>
		/// Construct a GraphicsWindow bound to a Control.
		/// </summary>
		/// <param name="control">
		/// A <see cref="Control"/> which is used for creating a OpenGL surface.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="control"/> is null.
		/// </exception>
		public GraphicsWindow(Control control)
		{
			if (control == null)
				throw new ArgumentNullException("control");

			// No form: using directly the handle passed as argument
			_RenderControl = control;
			// Constructor used for rendering on any Control but not Form instances, indeed it cannot break
			// the main application window
			_MainWindow = false;
		}
		
		#endregion
		
		#region User Interface Management
		
		/// <summary>
		/// Main window property. 
		/// </summary>
		public bool MainWindow
		{
			get { return (_MainWindow); }
			set { _MainWindow = value; }
		}

		/// <summary>
		/// Make this GraphicsWindow visible.
		/// </summary>
		public void ShowWindow()
		{
			_RenderControl.Show();
		}

		/// <summary>
		/// Make this GraphicsWindow invisible.
		/// </summary>
		public void HideWindow()
		{
			_RenderControl.Hide();
		}

		/// <summary>
		/// Check whether this GraphicsWindow is visible.
		/// </summary>
		public bool Visible
		{
			get
			{
				return (_RenderControl.Visible);
			}
		}

		/// <summary>
		/// Invalidate the content of the window.
		/// </summary>
		public void Invalidate()
		{
			_RenderControl.Invalidate();
		}

		/// <summary>
		/// Main window flag. 
		/// </summary>
		private bool _MainWindow = true;
		
		#endregion
		
		#region Nested Form/Control Management
		
		/// <summary>
		/// Form used for rendering. 
		/// </summary>
		private class RenderForm : Form
		{
			/// <summary>
			/// RenderForm constructor. 
			/// </summary>
			public RenderForm(GraphicsWindow win)
			{
				if (win == null)
					throw new ArgumentNullException("win");

				// Store GraphicsWindow reference
				_Window = win;
				// Initialize Form extents
				//SetClientSizeCore((int)win.Width, (int)win.Height);
				ClientSize = new Size((int)win.Width, (int)win.Height);
				
				// No need to erase window background
				SetStyle(ControlStyles.AllPaintingInWmPaint, true);
				// No need to draw window background
				SetStyle(ControlStyles.Opaque, true);
				// Buffer control
				SetStyle(ControlStyles.DoubleBuffer, false);
				// Redraw window on resize
				SetStyle(ControlStyles.ResizeRedraw, true);
				// Painting handled by user
				SetStyle(ControlStyles.UserPaint, true);
				
				// React on window resize event
				Resize += _Window.FormResize;
				// React on window closed event
				FormClosed += _Window.FormClosed;
			}
			
			protected override void CreateHandle()
			{
				// "Select" device pixel format before creating control handle
				switch (Environment.OSVersion.Platform) {
					case PlatformID.Unix:
						_Window.PreCreateObjectX11(_Window._SurfaceFormat);
						break;
				}
				
				// Base implementation
				base.CreateHandle();
			}
			
			/// <summary>
			/// GraphicsWindow linked with this Form. 
			/// </summary>
			private readonly GraphicsWindow _Window;
		}

		/// <summary>
		/// Get the Form handle used for rendering.
		/// </summary>
		public Form NestedForm
		{
			get { return (_RenderForm); }
		}

		/// <summary>
		/// Form where rendering results are drawn. 
		/// </summary>
		private readonly RenderForm _RenderForm;

		/// <summary>
		/// Control where rendering result are drawn.
		/// </summary>
		private readonly Control _RenderControl;
		
		#endregion
		
		#region Form Event Handlers
		
		/// <summary>
		///  
		/// </summary>
		/// <param name="sender">
		/// A <see cref="System.Object"/>
		/// </param>
		/// <param name="e">
		/// A <see cref="EventArgs"/>
		/// </param>
		private void FormResize(object sender, EventArgs e)
		{
			Control control = (Control)sender;
			
			// Store new form extents
			Height = (uint)control.ClientSize.Height;
			Width = (uint)control.ClientSize.Width;
		}
		
		/// <summary>
		/// Form closed event handler.
		/// </summary>
		/// <param name="sender">
		/// A <see cref="System.Object"/> which has raised the event.
		/// </param>
		/// <param name="e">
		/// A <see cref="EventArgs"/> that specifies the event parameters.
		/// </param>
		/// <remarks>
		/// In the case this GraphicsWindow has the property MainWindow as true, it closes
		/// the RenderKernel main thread and exit from the application.
		/// </remarks>
		private void FormClosed(object sender, EventArgs e)
		{
			if (MainWindow)
				Application.Exit();
		}

		#endregion

		#region Form Fullscreen Management

		/// <summary>
		/// Fullscreen window property.
		/// </summary>
		public bool Fullscreen
		{
			get {
				return (mFullscreen);
			}
			set {
				if (value) {
					SetFullscreen();
				} else {
					ResetFullscreen();
				}
			}
		}

		/// <summary>
		/// Set this GraphicsWindow fullscreen, bounds to the primary screen position and size.
		/// </summary>
		public void SetFullscreen()
		{
			SetFullscreen(Screen.PrimaryScreen);
		}

		/// <summary>
		/// Set the window into fullscreen mode, bounds to a screen position and size.
		/// </summary>
		/// <param name="screen">
		/// A <see cref="Screen"/> that specifies the position and dimension of the GraphicsWindow.
		/// </param>
		public void SetFullscreen(Screen screen)
		{
			if (screen == null)
				throw new ArgumentNullException("screen");

			// The window is fullscren
			SetFullscreenCore();
			// The window is bound to a screen
			_RenderForm.Bounds = screen.Bounds;
		}

		/// <summary>
		/// Set the window into fullscreen mode.
		/// </summary>
		private void SetFullscreenCore()
		{
			// Windows state
			_RenderForm.WindowState = FormWindowState.Normal;
			// No border
			_RenderForm.FormBorderStyle = FormBorderStyle.None;

			bool raiseEvent = mFullscreen == false;

			// Keep track of fullscreen state
			mFullscreen = true;

			if (raiseEvent)
				RaiseFullscreenChangedEvent();
		}

		/// <summary>
		/// Reset this GraphicsWindow fullscreen state.
		/// </summary>
		public void ResetFullscreen()
		{
			// With border
			_RenderForm.FormBorderStyle = FormBorderStyle.Sizable;
			// Normal
			_RenderForm.WindowState = FormWindowState.Normal;
			// Not top most
			_RenderForm.TopMost = false;
			// Cursor visible
			Cursor.Show();

			bool raiseEvent = mFullscreen;

			// Keep track of fullscreen state
			mFullscreen = false;

			if (raiseEvent)
				RaiseFullscreenChangedEvent();
		}

		/// <summary>
		/// Event raised whenever the GraphicsWindow fullscreen state changes.
		/// </summary>
		public event EventHandler FullscreenChanged;

		/// <summary>
		/// Raised the <see cref="FullscreenChanged"/> event.
		/// </summary>
		private void RaiseFullscreenChangedEvent()
		{
			if (FullscreenChanged != null)
				FullscreenChanged(this, EventArgs.Empty);
		}
		
		/// <summary>
		/// GraphicsWindow fullscreen flag.
		/// </summary>
		private bool mFullscreen;
		
		#endregion

		#region GraphicsWindow Creation

		/// <summary>
		/// Create this GraphicsWindow.
		/// </summary>
		/// <param name="surfaceFormat"></param>
		public void Create(GraphicsBuffersFormat surfaceFormat)
		{
			if ((surfaceFormat == null) && (_SurfaceFormat == null))
				throw new ArgumentNullException("surfaceFormat");

			// Store surface format
			if (surfaceFormat != null)
				_SurfaceFormat = surfaceFormat;
			// Actually create this GraphicsWindow
			Create((GraphicsContext)null);
		}

		#endregion

		#region Stereoscopic Windows Management

		/// <summary>
		/// The phisical position of a window in a stereoscopic context.
		/// </summary>
		public enum StereoSide
		{
			/// <summary>
			/// Left channel.
			/// </summary>
			Left,
			/// <summary>
			/// Right channel.
			/// </summary>
			Right,
		}

		/// <summary>
		/// The phisical position of this window in a stereoscopic context.
		/// </summary>
		public StereoSide Stereo
		{
			get { return (mStereoSide); }
			set {
				mStereoSide = value;
			}
		}

		/// <summary>
		/// Default value.
		/// </summary>
		private StereoSide mStereoSide = StereoSide.Left;

		#endregion

		#region Window Grabbing

		/// <summary>
		/// Read this RenderSurface color buffer.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/>
		/// </param>
		/// <param name="x">
		/// A <see cref="System.Int32"/> that specifies the x coordinate of the lower left corder of the rectangle area to read.
		/// </param>
		/// <param name="y">
		/// A <see cref="System.Int32"/> that specifies the y coordinate of the lower left corder of the rectangle area to read.
		/// </param>
		/// <param name="width">
		/// A <see cref="System.Int32"/> that specifies the width of the rectangle area to read.
		/// </param>
		/// <param name="height">
		/// A <see cref="System.Int32"/> that specifies the height of the rectangle area to read.
		/// </param>
		/// <param name="pType">
		/// A <see cref="PixelFormat"/> which determine the pixel storage of the returned image.
		/// </param>
		/// <returns>
		/// It returns an <see cref="Raster.Image"/> representing the current read buffer.
		/// </returns>
		public Image ReadFrontColorBuffer(GraphicsContext ctx, uint x, uint y, uint width, uint height, PixelLayout pType)
		{
			return (ReadBuffer(ctx, (Stereo == StereoSide.Left) ? ReadBufferMode.FrontLeft : ReadBufferMode.FrontRight, x, y, width, height, pType));
		}

		/// <summary>
		/// Read this RenderSurface color buffer.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/>
		/// </param>
		/// <param name="x">
		/// A <see cref="System.Int32"/> that specifies the x coordinate of the lower left corder of the rectangle area to read.
		/// </param>
		/// <param name="y">
		/// A <see cref="System.Int32"/> that specifies the y coordinate of the lower left corder of the rectangle area to read.
		/// </param>
		/// <param name="width">
		/// A <see cref="System.Int32"/> that specifies the width of the rectangle area to read.
		/// </param>
		/// <param name="height">
		/// A <see cref="System.Int32"/> that specifies the height of the rectangle area to read.
		/// </param>
		/// <param name="pType">
		/// A <see cref="PixelFormat"/> which determine the pixel storage of the returned image.
		/// </param>
		/// <returns>
		/// It returns an <see cref="Image"/> representing the current read buffer.
		/// </returns>
		public Image ReadBackColorBuffer(GraphicsContext ctx, uint x, uint y, uint width, uint height, PixelLayout pType)
		{
			return (ReadBuffer(ctx, (Stereo == StereoSide.Left) ? ReadBufferMode.BackLeft : ReadBufferMode.BackRight, x, y, width, height, pType));
		}

		#endregion

		#region Logging

		/// <summary>
		/// Logger of this class.
		/// </summary>
		private static readonly ILogger sLog = Log.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		#endregion

		#region GraphicsSurface Overrides

		/// <summary>
		/// Get the device context associated to this GraphicsWindow. 
		/// </summary>
		/// <returns>
		/// A <see cref="OpenGL.IDeviceContext"/> representing the device context related to this GraphicsWindow.
		/// </returns>
		public override IDeviceContext GetDeviceContext()
		{
			return (_DeviceContext);
		}

		/// <summary>
		/// Current surface configuration.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This read-only property shall return a <see cref="GraphicsBuffersFormat"/> indicating the current
		/// buffer configuration. The object returned shall not be used to modify this GraphicsBuffersFormat buffers,
		/// but it shall be used to know which is the buffer configuration.
		/// </para>
		/// </remarks>
		public override GraphicsBuffersFormat BufferFormat { get { return (_SurfaceFormat.Copy()); } }

		/// <summary>
		/// Bind this RenderSurface for drawing.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> to wich associate its rendering result to this RenderSurface.
		/// </param>
		public override void BindDraw(GraphicsContext ctx)
		{
			// Eventually unbind a framebuffer
			if (ctx.Caps.GlExtensions.FramebufferObject_ARB)
				Gl.BindFramebuffer(Gl.DRAW_FRAMEBUFFER, InvalidObjectName);
		}

		/// <summary>
		/// Bind this RenderSurface for reading.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> to wich associate its read result to this RenderSurface.
		/// </param>
		public override void BindRead(GraphicsContext ctx)
		{
			// Eventually unbind a framebuffer
			if (ctx.Caps.GlExtensions.FramebufferObject_ARB)
				Gl.BindFramebuffer(Gl.READ_FRAMEBUFFER, InvalidObjectName);
		}

		/// <summary>
		/// Determine whether this surface has to be swapped.
		/// </summary>
		public override bool Swappable
		{
			get { return (_SurfaceFormat.HasBuffer(GraphicsBuffersFormat.BufferType.Double)); }
		}
		
		/// <summary>
		/// Gets or sets the buffer swap interval desired on this surface.
		/// </summary>
		/// <remarks>
		/// This property returns always 0.
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this property is set with any value.
		/// </exception>
		public override int SwapInterval
		{
			get { return (_SwapInterval); }
			set { _SwapInterval = value; }
		}

		/// <summary>
		/// Swap render surface. 
		/// </summary>
		public override void SwapSurface()
		{
			if (_DeviceContext == null)
				throw new InvalidOperationException();
			
			if (_SurfaceFormat.HasBuffer(GraphicsBuffersFormat.BufferType.Double))
				Gl.SwapBuffers(_DeviceContext);
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// </param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				// Base implementation
				base.Dispose(true);
				// Dispose unmanaged resources
				if (_DeviceContext != null) {
					_DeviceContext.Dispose();
					_DeviceContext = null;
				}
			}

			// Dispose managed resources

		}

		/// <summary>
		/// Device context associated to mRenderWindow. 
		/// </summary>
		private IDeviceContext _DeviceContext;
		
		/// <summary>
		/// The swap interval.
		/// </summary>
		private int _SwapInterval = 1;
		
		#endregion

		#region GraphicsResource Overrides

		/// <summary>
		/// GraphicsResource object class.
		/// </summary>
		internal static readonly Guid ObjectClassId = new Guid("DE73B51E-2932-436C-BEC4-FD77203012F6");

		/// <summary>
		/// GraphicsResource object class.
		/// </summary>
		public override Guid ObjectClass { get { return (ObjectClassId); } }

		/// <summary>
		/// Determine whether this object requires a name bound to a context or not.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// It returns a false, since this is not a real OpenGL object.
		/// </returns>
		protected override bool RequiresName(GraphicsContext ctx)
		{
			return (false);
		}

		/// <summary>
		/// Actually create this GraphicsWindow resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void CreateObject(GraphicsContext ctx)
		{
			if (ctx != null)
				throw new ArgumentException("context not required", "ctx");

			sLog.Info("Create rendering window '{0}'.", NestedForm != null ? NestedForm.Text : "untitled");

			// Choose "best" pixel format matching with surface configuration
			if (_DeviceFormat == null)
				_DeviceFormat = _SurfaceFormat.ChoosePixelFormat(_DeviceContext, ValidPixelFormat);
			// Set device pixel format
			_DeviceContext.SetPixelFormat(_DeviceFormat);
			// Confirm surface configuration
			_SurfaceFormat.SetBufferConfiguration(_DeviceFormat);

			// Set swap interval
			int swapInterval = SwapInterval;
			
			if (swapInterval != 1) {
				if (GraphicsContext.CurrentCaps.WglExtensions.SwapControl_EXT == true) {
					if (swapInterval < 0) {
						if (GraphicsContext.CurrentCaps.WglExtensions.SwapControlTear_EXT == false) {
							sLog.Warn("Ignoring tearing swap interval ({0}) because is not supported.", swapInterval);
							swapInterval = -swapInterval;
						}
					}
					if (swapInterval != 1) {
						if (Gl.SwapInterval(_DeviceContext, swapInterval) == false) {
							Exception platformException = Gl.GetPlatformException(_DeviceContext);
							sLog.Warn("Unable to set swap interval to {0}: {1}.", swapInterval, platformException != null ? platformException.ToString() : "null");
						}
					}
				} else
					sLog.Warn("Ignoring swap interval ({0}) because is not supported.", swapInterval);
			}
		}
		
		/// <summary>
		/// Actually create this GraphicsWindow resources in Unix platform.
		/// </summary>
		/// <param name="surfaceFormat">
		/// A <see cref="GraphicsBuffersFormat"/> used for selecting the most appropriate visual.
		/// </param>
		internal void PreCreateObjectX11(GraphicsBuffersFormat surfaceFormat)
		{
			if (surfaceFormat == null)
				throw new ArgumentNullException("surfaceFormat");
			
			// Choose "best" pixel format matching with surface configuration
			_DeviceFormat = surfaceFormat.ChoosePixelFormat(_DeviceContext, ValidPixelFormat);
			
			sLog.Debug("Choosen frame buffer configuration: 0x{0} (visual 0x{1}).", _DeviceFormat.XFbConfig.ToString("X3"), _DeviceFormat.XVisualInfo.visualid.ToString("X3"));

			Type xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");

			if (xplatui == null)
				throw new PlatformNotSupportedException("mono runtime version no supported");
			
			IntPtr display = (IntPtr)xplatui.GetField("DisplayHandle", BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
			IntPtr rootWindow = (IntPtr)xplatui.GetField("RootWindow", BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
			IntPtr colorMap = Glx.UnsafeNativeMethods.XCreateColormap(display, rootWindow, _DeviceFormat.XVisualInfo.visual, 0);
			KhronosApi.LogProc("XCreateColormap(0x{0}, {1}, {2}. 0) = {0}", display.ToString("X"), rootWindow.ToString("X"), _DeviceFormat.XVisualInfo.visual.ToString());

			IntPtr customVisual = _DeviceFormat.XVisualInfo.visual;
			IntPtr origCustomVisual = (IntPtr)xplatui.GetField("CustomVisual", BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);

			KhronosApi.LogComment("Set System.Windows.Forms.XplatUIX11.CustomVisual change from {0} to {1}", origCustomVisual.ToString("X"), customVisual.ToString("X"));
			xplatui.GetField("CustomVisual", BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, customVisual);
			
			KhronosApi.LogComment("Create System.Windows.Forms.XplatUIX11.CustomColormap ({0})", colorMap.ToString("X"));
			xplatui.GetField("CustomColormap", BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, colorMap);
		}

		/// <summary>
		/// Callback method for filtering valid pixel formats for this GraphicsSurface.
		/// </summary>
		/// <param name="pFormat">
		/// A <see cref="DevicePixelFormat"/> to be validated by derived implementation.
		/// </param>
		/// <returns>
		/// It returns true in the case the pixel format is valid for usage in the derived implementation,
		/// otherwise it returns false.
		/// </returns>
		private static bool ValidPixelFormat(DevicePixelFormat pFormat)
		{
			// The pixel format must be able to render on a window
			return (pFormat.RenderWindow);
		}
		
		/// <summary>
		/// Window surface buffers format.
		/// </summary>
		private GraphicsBuffersFormat _SurfaceFormat = new GraphicsBuffersFormat(PixelLayout.RGB24);

		/// <summary>
		/// The device format.
		/// </summary>
		private DevicePixelFormat _DeviceFormat;

		#endregion
	}
}
