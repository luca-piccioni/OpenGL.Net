
// Copyright (C) 2017 Luca Piccioni
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

// warning CS0612: GlWidget.DoubleBuffered could be obsolete, but it is required
#pragma warning disable 612

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;

using Cairo;
using GLib;
using Gtk;

namespace OpenGL.GTK3
{
	/// <summary>
	/// GTK3 widget for rendering using OpenGL.Net.
	/// </summary>
	[ToolboxItem(true)]
	public class GlWidget : DrawingArea
	{
		#region Constructors

		/// <summary>
		/// Construct a GlWidget.
		/// </summary>
		public GlWidget()
		{
			DoubleBuffered = false;
		}

		#endregion

		#region Design Properties - Context Attributes

		#endregion

		#region Design Properties - Framebuffer

		/// <summary>
		/// Get or set the OpenGL minimum color buffer bits.
		/// </summary>
		[Property("color-bits")]
		public uint ColorBits
		{
			get { return (_ColorBits); }
			set { _ColorBits = value; }
		}

		/// <summary>
		/// The OpenGL color buffer bits.
		/// </summary>
		private uint _ColorBits = 24;

		/// <summary>
		/// Get or set the OpenGL minimum depth buffer bits.
		/// </summary>
		[Property("depth-bits")]
		public uint DepthBits
		{
			get { return (_DepthBits); }
			set { _DepthBits = value; }
		}

		/// <summary>
		/// The OpenGL color buffer bits.
		/// </summary>
		private uint _DepthBits;

		/// <summary>
		/// Get or set the OpenGL minimum stencil buffer bits.
		/// </summary>
		[Property("stencil-bits")]
		public uint StencilBits
		{
			get { return (_StencilBits); }
			set { _StencilBits = value; }
		}

		/// <summary>
		/// The OpenGL color buffer bits.
		/// </summary>
		private uint _StencilBits;

		/// <summary>
		/// Get or set the OpenGL minimum multisample buffer "bits".
		/// </summary>
		[Property("multisample-bits")]
		public uint MultisampleBits
		{
			get { return (_MultisampleBits); }
			set { _MultisampleBits = value; }
		}

		/// <summary>
		/// The OpenGL multisample buffer bits.
		/// </summary>
		private uint _MultisampleBits;

		/// <summary>
		/// Get or set the OpenGL swap buffers interval.
		/// </summary>
		[Property("swap-interval")]
		public int SwapInterval
		{
			get { return (_SwapInterval); }
			set { _SwapInterval = value; }
		}

		/// <summary>
		/// The OpenGL swap buffers interval.
		/// </summary>
		private int _SwapInterval = 1;

		/// <summary>
		/// The <see cref="DevicePixelFormat"/> describing the minimum pixel format required by this control.
		/// </summary>
		private DevicePixelFormat ControlPixelFormat
		{
			get
			{
				DevicePixelFormat controlReqFormat = new DevicePixelFormat();

				controlReqFormat.RgbaUnsigned = true;
				controlReqFormat.RenderWindow = true;

				controlReqFormat.ColorBits = (int)ColorBits;
				controlReqFormat.DepthBits = (int)DepthBits;
				controlReqFormat.StencilBits = (int)StencilBits;
				controlReqFormat.MultisampleBits = (int)MultisampleBits;
				controlReqFormat.DoubleBuffer = true;

				return (controlReqFormat);
			}
		}

		#endregion

		#region Device Context

		/// <summary>
		/// Get the <see cref="DeviceContext"/> created on this GlWidget.
		/// </summary>
		public DeviceContext Device
		{
			get { return (_DeviceContext); }
		}

		/// <summary>
		/// Create the device context and set the pixel format.
		/// </summary>
		protected void CreateDeviceContext()
		{
			CreateDeviceContext(ControlPixelFormat);
		}

		/// <summary>
		/// Create the device context and set the pixel format.
		/// </summary>
		private void CreateDeviceContext(DevicePixelFormat controlReqFormat)
		{
			#region Create device context

			_DeviceContext = DeviceContext.Create(GetDisplay(), GetWindowHandle());
			_DeviceContext.IncRef();

			#endregion

			#region Set pixel format

			DevicePixelFormatCollection pixelFormats = _DeviceContext.PixelsFormats;
			List<DevicePixelFormat> matchingPixelFormats = pixelFormats.Choose(controlReqFormat);

			if ((matchingPixelFormats.Count == 0) && controlReqFormat.MultisampleBits > 0) {
				// Try to select the maximum multisample configuration
				int multisampleBits = 0;

				pixelFormats.ForEach(delegate (DevicePixelFormat item) { multisampleBits = Math.Max(multisampleBits, item.MultisampleBits); });

				controlReqFormat.MultisampleBits = multisampleBits;

				matchingPixelFormats = pixelFormats.Choose(controlReqFormat);
			}

			if ((matchingPixelFormats.Count == 0) && controlReqFormat.DoubleBuffer) {
				// Try single buffered pixel formats
				controlReqFormat.DoubleBuffer = false;

				matchingPixelFormats = pixelFormats.Choose(controlReqFormat);
				if (matchingPixelFormats.Count == 0)
					throw new InvalidOperationException(String.Format("unable to find a suitable pixel format: {0}", pixelFormats.GuessChooseError(controlReqFormat)));
			} else if (matchingPixelFormats.Count == 0)
				throw new InvalidOperationException(String.Format("unable to find a suitable pixel format: {0}", pixelFormats.GuessChooseError(controlReqFormat)));

			_DeviceContext.SetPixelFormat(matchingPixelFormats[0]);

			#endregion

			#region Set V-Sync

			if (Gl.PlatformExtensions.SwapControl) {
				int swapInterval = SwapInterval;

				// Mask value in case it is not supported
				if (!Gl.PlatformExtensions.SwapControlTear && swapInterval == -1)
					swapInterval = 1;

				_DeviceContext.SwapInterval(swapInterval);
			}

			#endregion
		}

		/// <summary>
		/// Get the display associated with this Widget.
		/// </summary>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> valid for GLX functions as display parameter.
		/// </returns>
		private IntPtr GetDisplay()
		{
			return (IntPtr.Zero);
		}

		/// <summary>
		/// Get platform independent GTL widget handle.
		/// </summary>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that is the handle of this GlWidget.
		/// </returns>
		private IntPtr GetWindowHandle()
		{
			return (gdk_win32_window_get_handle(Window.Handle));
		}

		/// <summary>
		/// GDK method for getting the GTK widget handle on Windows platform.
		/// </summary>
		/// <param name="d"></param>
		/// <returns></returns>
		[SuppressUnmanagedCodeSecurity, DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr gdk_win32_window_get_handle(IntPtr d);

		/// <summary>
		/// Device context created on the GTK widget handle.
		/// </summary>
		private DeviceContext _DeviceContext;

		#endregion

		#region OpenGL Context

		/// <summary>
		/// Create the GlWidget context.
		/// </summary>
		private void CreateContext()
		{
			if (_GraphicsContext != IntPtr.Zero)
				throw new InvalidOperationException("context already created");

			IntPtr sharingContext = IntPtr.Zero;

			if (Gl.PlatformExtensions.CreateContext_ARB) {
				List<int> attributes = new List<int>();
				uint contextProfile = 0, contextFlags = 0;
				bool debuggerAttached = Debugger.IsAttached;

				#region WGL_ARB_create_context|GLX_ARB_create_context

				#endregion

				#region WGL_ARB_create_context_profile|GLX_ARB_create_context_profile

				if (Gl.PlatformExtensions.CreateContextProfile_ARB) {

				}

				#endregion

				#region WGL_ARB_create_context_robustness|GLX_ARB_create_context_robustness

				if (Gl.PlatformExtensions.CreateContextRobustness_ARB) {

				}

				#endregion

				Debug.Assert(Wgl.CONTEXT_FLAGS_ARB == Glx.CONTEXT_FLAGS_ARB);
				if (contextFlags != 0)
					attributes.AddRange(new int[] { Wgl.CONTEXT_FLAGS_ARB, unchecked((int)contextFlags) });

				Debug.Assert(Wgl.CONTEXT_PROFILE_MASK_ARB == Glx.CONTEXT_PROFILE_MASK_ARB);
				Debug.Assert(contextProfile == 0 || Gl.PlatformExtensions.CreateContextProfile_ARB);
				if (contextProfile != 0)
					attributes.AddRange(new int[] { Wgl.CONTEXT_PROFILE_MASK_ARB, unchecked((int)contextProfile) });

				attributes.Add(0);

				if ((_GraphicsContext = _DeviceContext.CreateContextAttrib(sharingContext, attributes.ToArray())) == IntPtr.Zero)
					throw new InvalidOperationException(String.Format("unable to create render context ({0})", Gl.GetError()));
			} else {
				// Create OpenGL context using compatibility profile
				if ((_GraphicsContext = _DeviceContext.CreateContext(sharingContext)) == IntPtr.Zero)
					throw new InvalidOperationException("unable to create render context");
			}
		}

		/// <summary>
		/// Make the GlWidget context current.
		/// </summary>
		private void MakeCurrentContext()
		{
			// Make context current
			if (_DeviceContext.MakeCurrent(_GraphicsContext) == false)
				throw new InvalidOperationException("unable to make context current");
		}

		/// <summary>
		/// Delete the GlWidget context.
		/// </summary>
		private void DeleteContext()
		{
			// Delete OpenGL context
			if (_GraphicsContext != IntPtr.Zero) {
				_DeviceContext.DeleteContext(_GraphicsContext);
				_GraphicsContext = IntPtr.Zero;
			}
		}

		/// <summary>
		/// OpenGL context created on <see cref="_DeviceContext"/>.
		/// </summary>
		private IntPtr _GraphicsContext;

		#endregion

		#region Events

		/// <summary>
		/// Event raised on control creation time, allow user to allocate resource on control.
		/// </summary>
		[Signal("context-created")]
		public event EventHandler<GlWidgetEventArgs> ContextCreated
		{
			add { _ContextCreated += value; }
			remove { _ContextCreated -= value; }
		}

		/// <summary>
		/// Underlying EventHandler for <see cref="ContextCreated"/>.
		/// </summary>
		private EventHandler<GlWidgetEventArgs> _ContextCreated;

		/// <summary>
		/// Raise the event <see cref="ContextCreated"/>.
		/// </summary>
		protected virtual void OnContextCreated()
		{
			if (_ContextCreated != null) {
				GlWidgetEventArgs glControlEventArgs = new GlWidgetEventArgs(_DeviceContext, _GraphicsContext);

				foreach (EventHandler<GlWidgetEventArgs> handler in _ContextCreated.GetInvocationList()) {
					try {
						handler(this, glControlEventArgs);
					} catch (Exception exception) {
						Debug.Fail(String.Format("OnContextCreated: exception ({0})\n{1}", exception.Message, exception.ToString()));
					}
				}
			}
		}

		/// <summary>
		/// Event raised on control disposition time, allow user to dispose resources on control.
		/// </summary>
		[Signal("context-destroying")]
		public event EventHandler<GlWidgetEventArgs> ContextDestroying;

		/// <summary>
		/// Raise the event <see cref="ContextDestroying"/>.
		/// </summary>
		protected virtual void OnContextDestroying()
		{
			if (ContextDestroying != null)
				ContextDestroying(this, new GlWidgetEventArgs(_DeviceContext, _GraphicsContext));
		}

		/// <summary>
		/// Event raised on control render time, allow user to draw on control.
		/// </summary>
		[Signal("render")]
		public event EventHandler<GlWidgetEventArgs> Render;

		/// <summary>
		/// Raise the event <see cref="Render"/>.
		/// </summary>
		protected virtual void OnRender()
		{
			if (Render != null && _GraphicsContext != IntPtr.Zero)
				Render(this, new GlWidgetEventArgs(_DeviceContext, _GraphicsContext));
		}

		/// <summary>
		/// Event raised on control render time, allow user to update resources. It is executed AFTER the <see cref="Render"/>
		/// event.
		/// </summary>
		[Signal("context-update")]
		public event EventHandler<GlWidgetEventArgs> ContextUpdate;

		/// <summary>
		/// Raise the event <see cref="ContextUpdate"/>.
		/// </summary>
		protected virtual void OnContextUpdate()
		{
			if (ContextUpdate != null && _GraphicsContext != IntPtr.Zero)
				ContextUpdate(this, new GlWidgetEventArgs(_DeviceContext, _GraphicsContext));
		}

		#endregion

		#region DrawingArea Overrides

		protected override void OnRealized()
		{
			// Base implementation
			base.OnRealized();

			// Create device context
			CreateDeviceContext();
			// Create OpenGL context
			CreateContext();
			// The context is made current unconditionally: event handlers allocate resources
			MakeCurrentContext();
			// Event handling
			OnContextCreated();
		}

		protected override void OnUnrealized()
		{
			if (_GraphicsContext != IntPtr.Zero) {
				// Event handling
				OnContextDestroying();
				// Destroy context
				DeleteContext();
			}
			// Destroy device context
			_DeviceContext.DecRef();
			_DeviceContext = null;

			// Base implementation
			base.OnUnrealized();
		}

		protected override bool OnDrawn(Context cr)
		{
			try {
				MakeCurrentContext();

				// Draw
				OnRender();

				// Update
				OnContextUpdate();

				// Swap
				_DeviceContext.SwapBuffers();
			} catch (Exception exception) {
				
			}

			return (true);
		}

		#endregion
	}

	/// <summary>
	/// Arguments for <see cref="GlWidget"/> events.
	/// </summary>
	public class GlWidgetEventArgs : System.EventArgs
	{
		#region Constructors

		/// <summary>
		/// Construct a GlWidgetEventArgs.
		/// </summary>
		/// <param name="deviceContext">
		/// The <see cref="DeviceContext"/> used for the underlying <see cref="GlWidget"/>.
		/// </param>
		/// <param name="renderContext">
		/// The OpenGL context used for rendering.
		/// </param>
		public GlWidgetEventArgs(DeviceContext deviceContext, IntPtr renderContext)
		{
			if (deviceContext == null)
				throw new ArgumentNullException("deviceContext");
			if (renderContext == IntPtr.Zero)
				throw new ArgumentException("renderContext");

			DeviceContext = deviceContext;
			RenderContext = renderContext;
		}

		#endregion

		#region Event Arguments

		/// <summary>
		/// The <see cref="DeviceContext"/> used for the underlying <see cref="GlWidget"/>.
		/// </summary>
		public readonly DeviceContext DeviceContext;

		/// <summary>
		/// The OpenGL context used for rendering.
		/// </summary>
		public readonly IntPtr RenderContext;

		#endregion
	}
}
