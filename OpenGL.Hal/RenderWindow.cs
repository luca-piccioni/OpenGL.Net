
// Copyright (C) 2009-2013 Luca Piccioni
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//  
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

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
	/// A RenderWindow shall be considered an object able to output the graphical result
	/// of some rendering operation. A RenderWindow instance must have associated a GraphicsContext
	/// instance.
	/// </para>
	/// </remarks>
	public class RenderWindow : RenderSurface
	{
		#region Constructors

		/// <summary>
		/// Construct a RenderWindow.
		/// </summary>
		public RenderWindow() : this(0, 0) { }

		/// <summary>
		/// Construct a RenderWindow specifying its extents.
		/// </summary>
		/// <param name="w">
		/// A <see cref="System.Int32"/> specifing window width (in pixels).
		/// </param>
		/// <param name="h">
		/// A <see cref="System.Int32"/> specifing window height (in pixels).
		/// </param>
		public RenderWindow(uint w, uint h) : base(w, h)
		{
			// Create Form linked with this RenderWindow
			mRenderControl = mRenderForm = new RenderForm(this);
			// Obtain device context (relative to window)
			mDeviceContext = DeviceContextFactory.Create(mRenderForm);
		}

		/// <summary>
		/// Construct a RenderWindow bound to a Control.
		/// </summary>
		/// <param name="control">
		/// A <see cref="Control"/> which is used for creating a OpenGL surface.
		/// </param>
		public RenderWindow(Control control)
		{
			if (control == null)
				throw new ArgumentNullException("control");

			// No form: using directly the handle passed as argument
			mRenderControl = control;
			// Constructor used for rendering on any Control but not Form instances, indeed it cannot break
			// the RenderKernel since probably there's not RenderKernel instance
			mMainWindow = false;
		}
		
		#endregion
		
		#region User Interface Management
		
		/// <summary>
		/// Main window property. 
		/// </summary>
		public bool MainWindow
		{
			get { return (mMainWindow); }
			set { mMainWindow = value; }
		}

		/// <summary>
		/// Make this RenderWindow visible.
		/// </summary>
		public void ShowWindow()
		{
			mRenderControl.Show();
		}

		/// <summary>
		/// Make this RenderWindow invisible.
		/// </summary>
		public void HideWindow()
		{
			mRenderControl.Hide();
		}

		/// <summary>
		/// Check whether this RenderWindow is visible.
		/// </summary>
		public bool Visible
		{
			get
			{
				return (mRenderControl.Visible);
			}
		}

		/// <summary>
		/// Invalidate the content of the window.
		/// </summary>
		public void Invalidate()
		{
			mRenderControl.Invalidate();
		}

		/// <summary>
		/// Main window flag. 
		/// </summary>
		private bool mMainWindow = true;
		
		#endregion
		
		#region Nested Form Management
		
		/// <summary>
		/// Form used for rendering. 
		/// </summary>
		private class RenderForm : Form
		{
			/// <summary>
			/// RenderForm constructor. 
			/// </summary>
			public RenderForm(RenderWindow win)
			{
				if (win == null)
					throw new ArgumentNullException("win");

				// Store RenderWindow reference
				mWindow = win;
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
				Resize += mWindow.FormResize;
				// React on window closed event
				FormClosed += mWindow.FormClosed;
			}
			
			protected override void CreateHandle()
			{
				// "Select" device pixel format before creating control handle
				switch (Environment.OSVersion.Platform) {
					case PlatformID.Win32Windows:
					case PlatformID.Win32NT:
						mWindow.PreCreateObjectWgl(mWindow.mSurfaceFormat);
						break;
					case PlatformID.Unix:
						mWindow.PreCreateObjectX11(mWindow.mSurfaceFormat);
						break;
				}
				
				// Base implementation
				base.CreateHandle();
			}
			
			/// <summary>
			/// RenderWindow linked with this Form. 
			/// </summary>
			private readonly RenderWindow mWindow;
		}

		/// <summary>
		/// Set this RenderWindow position.
		/// </summary>
		/// <param name="x">
		/// A <see cref="System.Int32"/> that specifies the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="System.Int32"/> that specifies the Y coordinate.
		/// </param>
		public void SetPosition(int x, int y)
		{
			mRenderControl.Location = new Point(x, y);
		}

		/// <summary>
		/// Get this RenderWindow position.
		/// </summary>
		/// <param name="x">
		/// A <see cref="System.Int32"/> returning the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="System.Int32"/> returning the Y coordinate.
		/// </param>
		public void GetPosition(out int x, out int y)
		{
			x = mRenderControl.Location.X;
			y = mRenderControl.Location.Y;
		}

		/// <summary>
		/// Set this RenderWindow size.
		/// </summary>
		/// <param name="w">
		/// A <see cref="System.Int32"/> that specifies the RenderWindow width.
		/// </param>
		/// <param name="h">
		/// A <see cref="System.Int32"/> that specifies the RenderWindow height.
		/// </param>
		public void SetSize(uint w, uint h)
		{
			mRenderControl.Size = new Size((int)w, (int)h);
		}

		/// <summary>
		/// Set this RenderWindow client size.
		/// </summary>
		/// <param name="w">
		/// A <see cref="System.Int32"/> that specifies the RenderWindow width.
		/// </param>
		/// <param name="h">
		/// A <see cref="System.Int32"/> that specifies the RenderWindow height.
		/// </param>
		public void SetClientSize(uint w, uint h)
		{
			mRenderControl.ClientSize = new Size((int)w, (int)h);
		}

		/// <summary>
		/// Get this RenderWindow extents.
		/// </summary>
		/// <param name="w">
		/// A <see cref="System.Int32"/> returning the RenderWindow width.
		/// </param>
		/// <param name="h">
		/// A <see cref="System.Int32"/> returning the RenderWindow height.
		/// </param>
		public void GetExtents(out uint w, out uint h)
		{
			w = (uint)mRenderControl.ClientSize.Width;
			h = (uint)mRenderControl.ClientSize.Height;
		}

		/// <summary>
		/// Get the Form handle used for rendering.
		/// </summary>
		public Form NestedForm
		{
			get { return (mRenderForm); }
		}

		/// <summary>
		/// Form where rendering results are drawn. 
		/// </summary>
		private readonly RenderForm mRenderForm;

		/// <summary>
		/// Control where rendering result are drawn.
		/// </summary>
		private readonly Control mRenderControl;
		
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
		/// In the case this RenderWindow has the property MainWindow as true, it closes
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
		/// Set this RenderWindow fullscreen, bounds to the primary screen position and size.
		/// </summary>
		public void SetFullscreen()
		{
			SetFullscreen(Screen.PrimaryScreen);
		}

		/// <summary>
		/// Set the window into fullscreen mode, bounds to a screen position and size.
		/// </summary>
		/// <param name="screen">
		/// A <see cref="Screen"/> that specifies the position and dimension of the RenderWindow.
		/// </param>
		public void SetFullscreen(Screen screen)
		{
			if (screen == null)
				throw new ArgumentNullException("screen");

			// The window is fullscren
			SetFullscreenCore();
			// The window is bound to a screen
			mRenderForm.Bounds = screen.Bounds;
		}

		/// <summary>
		/// Set the window into fullscreen mode.
		/// </summary>
		private void SetFullscreenCore()
		{
			// Windows state
			mRenderForm.WindowState = FormWindowState.Normal;
			// No border
			mRenderForm.FormBorderStyle = FormBorderStyle.None;

			bool raiseEvent = mFullscreen == false;

			// Keep track of fullscreen state
			mFullscreen = true;

			if (raiseEvent)
				RaiseFullscreenChangedEvent();
		}

		/// <summary>
		/// Reset this RenderWindow fullscreen state.
		/// </summary>
		public void ResetFullscreen()
		{
			// With border
			mRenderForm.FormBorderStyle = FormBorderStyle.Sizable;
			// Normal
			mRenderForm.WindowState = FormWindowState.Normal;
			// Not top most
			mRenderForm.TopMost = false;
			// Cursor visible
			Cursor.Show();

			bool raiseEvent = mFullscreen;

			// Keep track of fullscreen state
			mFullscreen = false;

			if (raiseEvent)
				RaiseFullscreenChangedEvent();
		}

		/// <summary>
		/// Event raised whenever the RenderWindow fullscreen state changes.
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
		/// RenderWindow fullscreen flag.
		/// </summary>
		private bool mFullscreen;
		
		#endregion

		#region RenderWindow Creation

		/// <summary>
		/// Create this RenderWindow.
		/// </summary>
		/// <param name="surfaceFormat"></param>
		public void Create(GraphicsBuffersFormat surfaceFormat)
		{
			if ((surfaceFormat == null) && (mSurfaceFormat == null))
				throw new ArgumentNullException("surfaceFormat");

			// Store surface format
			if (surfaceFormat != null)
				mSurfaceFormat = surfaceFormat;
			// Actually create this RenderWindow
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

		#region RenderSurface Overrides

		/// <summary>
		/// Get the device context associated to this RenderWindow. 
		/// </summary>
		/// <returns>
		/// A <see cref="OpenGL.IDeviceContext"/> representing the device context related to this RenderWindow.
		/// </returns>
		public override IDeviceContext GetDeviceContext()
		{
			return (mDeviceContext);
		}

		/// <summary>
		/// Current surface configuration.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This read-only property shall return a <see cref="GraphicsBuffersFormat"/> indicating the current
		/// buffer configuration. The object returned shall not be used to modify this RenderSurface buffers,
		/// but it shall be used to know which is the buffer configuration.
		/// </para>
		/// </remarks>
		public override GraphicsBuffersFormat BufferFormat { get { return (mSurfaceFormat.Copy()); } }

		/// <summary>
		/// Bind this RenderSurface for drawing.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> to wich associate its rendering result to this RenderSurface.
		/// </param>
		public override void BindDraw(GraphicsContext ctx)
		{
			// Eventually unbind a framebuffer
			if (ctx.Caps.GlExtensions.FramebufferObject_ARB) {
				Gl.BindFramebuffer(Gl.DRAW_FRAMEBUFFER, InvalidObjectName);
			}
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
			if (ctx.Caps.GlExtensions.FramebufferObject_ARB) {
				Gl.BindFramebuffer(Gl.READ_FRAMEBUFFER, InvalidObjectName);
			}
		}

		/// <summary>
		/// Determine whether this surface has to be swapped.
		/// </summary>
		public override bool Swappable
		{
			get { return (mSurfaceFormat.HasBuffer(GraphicsBuffersFormat.BufferType.Double)); }
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
			get { return (mSwapInterval); }
			set { mSwapInterval = value; }
		}

		/// <summary>
		/// Swap render surface. 
		/// </summary>
		public override void SwapSurface()
		{
			if (mDeviceContext == null)
				throw new InvalidOperationException();
			
			if (mSurfaceFormat.HasBuffer(GraphicsBuffersFormat.BufferType.Double))
				Gl.SwapBuffers(mDeviceContext);
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
				if (mDeviceContext != null) {
					mDeviceContext.Dispose();
					mDeviceContext = null;
				}
			}

			// Dispose managed resources

		}

		/// <summary>
		/// Device context associated to mRenderWindow. 
		/// </summary>
		private IDeviceContext mDeviceContext;
		
		/// <summary>
		/// The swap interval.
		/// </summary>
		private int mSwapInterval = 1;
		
		#endregion

		#region RenderResource Overrides

		/// <summary>
		/// RenderResource object class.
		/// </summary>
		internal static readonly Guid RenderWindowObjectClass = new Guid("DE73B51E-2932-436C-BEC4-FD77203012F6");

		/// <summary>
		/// RenderResource object class.
		/// </summary>
		public override Guid ObjectClass { get { return (RenderWindowObjectClass); } }

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
		/// Actually create this RenderWindow resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void CreateObject(GraphicsContext ctx)
		{
			if (ctx != null)
				throw new ArgumentException("context not required", "ctx");

			switch (Environment.OSVersion.Platform) {
				case PlatformID.Win32Windows:
				case PlatformID.Win32NT:
					CreateObjectWgl((GraphicsContext)null);
					break;
				case PlatformID.Unix:
					CreateObjectX11((GraphicsContext)null);
					break;
				default:
					throw new NotSupportedException(String.Format("platform {0} not supported", Environment.OSVersion.Platform));
			}
			
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
						if (Gl.SwapInterval(mDeviceContext, swapInterval) == false) {
							Exception platformException = Gl.GetPlatformException(mDeviceContext);
							sLog.Warn("Unable to set swap interval to {0}: {1}.", swapInterval, platformException != null ? platformException.ToString() : "null");
						}
					}
				} else
					sLog.Warn("Ignoring swap interval ({0}) because is not supported.", swapInterval);
			}
		}
		
		/// <summary>
		/// Actually create this RenderWindow resources in Windows platform.
		/// </summary>
		/// <param name="surfaceFormat">
		/// A <see cref="GraphicsBuffersFormat"/> used for selecting the most appropriate visual.
		/// </param>
		internal void PreCreateObjectWgl(GraphicsBuffersFormat surfaceFormat)
		{
			if (surfaceFormat == null)
				throw new ArgumentNullException("surfaceFormat");
			
			// Store pixel format, without formally setup the pixel format)
			mSurfaceFormat = surfaceFormat;
		}
		
		/// <summary>
		/// Actually create this RenderWindow resources in Windows platform.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		private void CreateObjectWgl(GraphicsContext ctx)
		{
			// Obtain device context (relative to control)
			if (mRenderForm == null)
				mDeviceContext = DeviceContextFactory.Create(mRenderControl);
			
			WindowsDeviceContext winDeviceContext = (WindowsDeviceContext)mDeviceContext;
			Wgl.PIXELFORMATDESCRIPTOR pDescriptor;
			
			sLog.Info("Create rendering window '{0}'.", NestedForm != null ? NestedForm.Text : "untitled");

			// Choose "best" pixel format matching with surface configuration
			DevicePixelFormat pFormat = mSurfaceFormat.ChoosePixelFormat(mDeviceContext, ValidPixelFormat);

			// Set choosen pixel format
			if (Wgl.UnsafeNativeMethods.GdiSetPixelFormat(winDeviceContext.DeviceContext, pFormat.FormatIndex, out pDescriptor) == false)
				throw new InvalidOperationException("unable to select surface pixel format");
			// Confirm surface configuration
			mSurfaceFormat.SetBufferConfiguration(pFormat);
		}
		
		/// <summary>
		/// Actually create this RenderWindow resources in Unix platform.
		/// </summary>
		/// <param name="surfaceFormat">
		/// A <see cref="GraphicsBuffersFormat"/> used for selecting the most appropriate visual.
		/// </param>
		internal void PreCreateObjectX11(GraphicsBuffersFormat surfaceFormat)
		{
			if (surfaceFormat == null)
				throw new ArgumentNullException("surfaceFormat");
			
			// Choose "best" pixel format matching with surface configuration
			mDeviceFormat = surfaceFormat.ChoosePixelFormat(mDeviceContext, ValidPixelFormat);
			
			sLog.Debug("Choosen frame buffer configuration: 0x{0} (visual 0x{1}).", mDeviceFormat.XFbConfig.ToString("X3"), mDeviceFormat.XVisualInfo.visualid.ToString("X3"));

			Type xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");

			if (xplatui == null)
				throw new PlatformNotSupportedException("mono runtime version no supported");
			
			IntPtr display = (IntPtr)xplatui.GetField("DisplayHandle", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
			IntPtr rootWindow = (IntPtr)xplatui.GetField("RootWindow", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
			IntPtr colorMap = Glx.UnsafeNativeMethods.XCreateColormap(display, rootWindow, mDeviceFormat.XVisualInfo.visual, 0);
			KhronosApi.LogProc("XCreateColormap(0x{0}, {1}, {2}. 0) = {0}", display.ToString("X"), rootWindow.ToString("X"), mDeviceFormat.XVisualInfo.visual.ToString());

			IntPtr customVisual = mDeviceFormat.XVisualInfo.visual;
			IntPtr origCustomVisual = (IntPtr)xplatui.GetField("CustomVisual", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);

			KhronosApi.LogComment("Set System.Windows.Forms.XplatUIX11.CustomVisual change from {0} to {1}", origCustomVisual.ToString("X"), customVisual.ToString("X"));
			xplatui.GetField("CustomVisual", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).SetValue(null, customVisual);
			
			KhronosApi.LogComment("Create System.Windows.Forms.XplatUIX11.CustomColormap ({0})", colorMap.ToString("X"));
			xplatui.GetField("CustomColormap", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).SetValue(null, colorMap);
		}

		/// <summary>
		/// Actually create this RenderWindow resources in Unix platform.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		private void CreateObjectX11(GraphicsContext ctx)
		{
			// Obtain device context (relative to control)
			if (mRenderForm == null)
				mDeviceContext = DeviceContextFactory.Create(mRenderControl);
			
			XServerDeviceContext x11DeviceContext = (XServerDeviceContext)mDeviceContext;
			
			if (mDeviceFormat == null)
				throw new InvalidOperationException("no device format selected");
			mSurfaceFormat.SetBufferConfiguration(mDeviceFormat);
			
			sLog.Debug("Choosen frame buffer configuration: 0x{0} (visual 0x{1}).", mDeviceFormat.XFbConfig.ToString("X3"), mDeviceFormat.XVisualInfo.visualid.ToString("X3"));

			x11DeviceContext.FBConfig = mDeviceFormat.XFbConfig;
			x11DeviceContext.XVisualInfo = mDeviceFormat.XVisualInfo;
		}
		
		/// <summary>
		/// The device format.
		/// </summary>
		private DevicePixelFormat mDeviceFormat;
		
		[System.Runtime.InteropServices.DllImport("libX11", EntryPoint = "XGetVisualInfo")]
        private static extern IntPtr XGetVisualInfoInternal(IntPtr display, IntPtr vinfo_mask, ref Glx.XVisualInfo template, out int nitems);

        private static IntPtr XGetVisualInfo(IntPtr display, int vinfo_mask, ref Glx.XVisualInfo template, out int nitems)
        {
            return XGetVisualInfoInternal(display, (IntPtr)vinfo_mask, ref template, out nitems);
        }

		/// <summary>
		/// Derived implementation status for passing surface pixel format.
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
			return (pFormat.RenderWindow);
		}
		
		/// <summary>
		/// Window surface format.
		/// </summary>
		private GraphicsBuffersFormat mSurfaceFormat = new GraphicsBuffersFormat(PixelLayout.RGB24);

		#endregion
	}
}
