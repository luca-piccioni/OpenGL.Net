
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
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

using Android.Content;
using Android.Graphics;
using Android.Util;
using Android.Views;
using Android.Runtime;

namespace OpenGL
{
	/// <summary>
	/// Basic <see cref="SurfaceView"/> for rendering.
	/// </summary>
	[Register("OpenGL.Net/GLSurfaceView")]
	public class GLSurfaceView : SurfaceView, ISurfaceHolderCallback
	{
		#region Constructors

		/// <summary>
		/// 
		/// </summary>
		/// <param name="context"></param>
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public GLSurfaceView(Context context) :
			base (context)
		{
			Initialize();
		}

		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public GLSurfaceView(Context context, IAttributeSet attrs) :
			base (context, attrs)
		{
			Initialize();
		}

		public GLSurfaceView(IntPtr handle, global::Android.Runtime.JniHandleOwnership transfer) :
			base (handle, transfer)
		{
			Initialize();
		}

		private void Initialize()
		{
			_Holder = Holder;
			_Holder.AddCallback(this);
			_Holder.SetType(SurfaceType.Gpu);
		}

		#endregion

		#region Device Context

		private IntPtr _NativeWindowHandle;

		/// <summary>
		/// The <see cref="DeviceContext"/> created on this GlSurfaceView.
		/// </summary>
		protected DeviceContext _DeviceContext;

		/// <summary>
		/// The OpenGL context created on this GlSurfaceView.
		/// </summary>
		protected IntPtr _RenderContext;

		/// <summary>
		/// Get native window from surface
		/// </summary>
		/// <param name="jni"></param>
		/// <param name="surface"></param>
		/// <returns></returns>
		[DllImport("android")]
		private static extern IntPtr ANativeWindow_fromSurface(IntPtr jni, IntPtr surface);

		/// <summary>
		/// Get native window from surface
		/// </summary>
		/// <param name="surface"></param>
		[DllImport("android")]
		private static extern void ANativeWindow_release(IntPtr surface);

		#endregion

		#region Rendering

		private void StartRendering(float fps)
		{
			if (_RenderTimer != null)
				throw new InvalidOperationException("rendering already active");
			_RenderTimerDueTime = (int)Math.Ceiling(1000.0f / fps);
			_RenderTimer = new Timer(RenderTimerCallback, null, _RenderTimerDueTime, Timeout.Infinite);
		}

		private void StopRendering()
		{
			if (_RenderTimer != null) {
				_RenderTimer.Change(Timeout.Infinite, Timeout.Infinite);
				_RenderTimer.Dispose();
				_RenderTimer = null;
			}
		}

		private void RenderTimerCallback(object state)
		{
			try {
				// Rendering on main UI thread
				Android.App.Application.SynchronizationContext.Send(delegate {
					OnRender();
				}, null);
			} finally {
				try {
					_RenderTimer.Change(_RenderTimerDueTime, Timeout.Infinite);
				} catch { /* Fail-safe */ }
			}
		}

		/// <summary>
		/// Timer used for triggering rendering.
		/// </summary>
		private Timer _RenderTimer;

		/// <summary>
		/// Due time for triggering rendering, in milliseconds.
		/// </summary>
		private int _RenderTimerDueTime;

		#endregion

		#region Events

		/// <summary>
		/// Event raised on control creation time, allow user to allocate resource on control.
		/// </summary>
		public event EventHandler<GlSurfaceViewEventArgs> ContextCreated
		{
			add { _ContextCreated += value; }
			remove { _ContextCreated -= value; }
		}

		/// <summary>
		/// Underlying EventHandler for <see cref="ContextCreated"/>.
		/// </summary>
		private EventHandler<GlSurfaceViewEventArgs> _ContextCreated;

		/// <summary>
		/// Raise the event <see cref="ContextCreated"/>.
		/// </summary>
		protected virtual void OnContextCreated()
		{
			if (_ContextCreated != null) {
				GlSurfaceViewEventArgs glControlEventArgs = new GlSurfaceViewEventArgs(_DeviceContext, _RenderContext);

				foreach(EventHandler<GlSurfaceViewEventArgs> handler in _ContextCreated.GetInvocationList()) {
					try {
						handler(this, glControlEventArgs);
					} catch (Exception) {
						// Fail-safe
					}
				}
			}

			Invalidate();
		}

		/// <summary>
		/// Event raised on control disposition time, allow user to dispose resources on control.
		/// </summary>
		public event EventHandler<GlSurfaceViewEventArgs> ContextDestroying;

		/// <summary>
		/// Raise the event <see cref="ContextDestroying"/>.
		/// </summary>
		protected virtual void OnContextDestroying()
		{
			if (ContextDestroying != null)
				ContextDestroying(this, new GlSurfaceViewEventArgs(_DeviceContext, _RenderContext));
		}

		/// <summary>
		/// Event raised on control render time, allow user to draw on control.
		/// </summary>
		public event EventHandler<GlSurfaceViewEventArgs> Render;

		/// <summary>
		/// Raise the event <see cref="Render"/>.
		/// </summary>
		protected virtual void OnRender()
		{
			if (Render != null && _DeviceContext != null && _RenderContext != IntPtr.Zero) {
				Render(this, new GlSurfaceViewEventArgs(_DeviceContext, _RenderContext));

				_DeviceContext.SwapBuffers();
			}
		}

		#endregion

		#region SurfaceView Overrides

		/// <summary>
		/// Dispose this GLSurfaceView.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="Boolean"/> that specifies whether the Dispose method has been called.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			// Base implementation
			base.Dispose(disposing);

			// Release native window handle
			if (_NativeWindowHandle != IntPtr.Zero) {
				ANativeWindow_release(_NativeWindowHandle);
				_NativeWindowHandle = IntPtr.Zero;
			}
		}

		#endregion

		#region ISurfaceHolderCallback Implementation

		/// <summary>
		/// This is called immediately after the surface is first created.
		/// </summary>
		/// <param name="holder">
		/// The SurfaceHolder whose surface is being created.
		/// </param>
		public void SurfaceCreated(ISurfaceHolder holder)
		{
			// Problem with static constructors? Ensure manual initialization
			Egl.Initialize(); Gl.Initialize();

			// Get actual native window handle
			_NativeWindowHandle = ANativeWindow_fromSurface(JNIEnv.Handle, holder.Surface.Handle);

			// Create device context
			_DeviceContext = DeviceContext.Create(_NativeWindowHandle);
			_DeviceContext.IncRef();

			// Set pixel format
			DevicePixelFormatCollection pixelFormats = _DeviceContext.PixelsFormats;
			DevicePixelFormat controlReqFormat = new DevicePixelFormat();

			controlReqFormat.RgbaUnsigned = true;
			controlReqFormat.RenderWindow = true;

			controlReqFormat.ColorBits = 24;
			//controlReqFormat.DepthBits = (int)DepthBits;
			//controlReqFormat.StencilBits = (int)StencilBits;
			//controlReqFormat.MultisampleBits = (int)MultisampleBits;
			//controlReqFormat.DoubleBuffer = true;

			List<DevicePixelFormat> matchingPixelFormats = pixelFormats.Choose(controlReqFormat);
			if (matchingPixelFormats.Count == 0)
				throw new InvalidOperationException("unable to find a suitable pixel format");

			_DeviceContext.SetPixelFormat(matchingPixelFormats[0]);

			// Create OpenGL context using compatibility profile
			if ((_RenderContext = _DeviceContext.CreateContext(IntPtr.Zero)) == IntPtr.Zero)
				throw new InvalidOperationException("unable to create render context");
			// Make context current
			if (_DeviceContext.MakeCurrent(_RenderContext) == false)
				throw new InvalidOperationException("unable to make context current");
			// Raise relative event
			OnContextCreated();

			StartRendering(30.0f);
		}

		/// <summary>
		/// This is called immediately before a surface is being destroyed.
		/// </summary>
		/// <param name="holder">
		/// The SurfaceHolder whose surface is being destroyed.
		/// </param>
		public void SurfaceDestroyed(ISurfaceHolder holder)
		{
			StopRendering();

			if (_DeviceContext != null) {
				if (_RenderContext != IntPtr.Zero)
					_DeviceContext.DeleteContext(_RenderContext);
				_DeviceContext.Dispose();
				_DeviceContext = null;
			}
		}

		/// <summary>
		/// This is called immediately after any structural changes (format or size) have been made to the surface.
		/// </summary>
		/// <param name="holder">
		/// The SurfaceHolder whose surface has changed.
		/// </param>
		/// <param name="format">
		/// The new PixelFormat of the surface.
		/// </param>
		/// <param name="w">
		/// The new width of the surface.
		/// </param>
		/// <param name="h">
		/// The new height of the surface.
		/// </param>
		public void SurfaceChanged(ISurfaceHolder holder, Format format, int w, int h)
		{
			
		}

		/// <summary>
		/// Surface holder.
		/// </summary>
		private ISurfaceHolder _Holder;

		#endregion
	}

	/// <summary>
	/// Arguments for <see cref="GlSurfaceView"/> events.
	/// </summary>
	public class GlSurfaceViewEventArgs : EventArgs
	{
		#region Constructors

		/// <summary>
		/// Construct a GlSurfaceViewEventArgs.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="DeviceContext"/> used for the underlying <see cref="GlSurfaceView"/>.
		/// </param>
		/// <param name="renderContext">
		/// The OpenGL context used for rendering.
		/// </param>
		public GlSurfaceViewEventArgs(DeviceContext deviceContext, IntPtr renderContext)
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
		/// The <see cref="DeviceContext"/> used for the underlying <see cref="GlSurfaceView"/>.
		/// </summary>
		public readonly DeviceContext DeviceContext;

		/// <summary>
		/// The OpenGL context used for rendering.
		/// </summary>
		public readonly IntPtr RenderContext;

		#endregion
	}
}
