
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
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OpenGL
{
	/// <summary>
	/// Basic <see cref="UserControl"/> for rendering.
	/// </summary>
	public partial class GlControl : UserControl
	{
		#region Constructors

		static GlControl()
		{
			Gl.Initialize();
		}

		/// <summary>
		/// Construct a GlControl.
		/// </summary>
		public GlControl()
		{
			InitializeComponent();
		}

		#endregion

		#region Design Properties

		/// <summary>
		/// Get or set the OpenGL color buffer bits.
		/// </summary>
		[Browsable(true)]
		[Description("Number of bits of the color buffer.")]
		[DefaultValue(24)]
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
		/// Get or set the OpenGL depth buffer bits.
		/// </summary>
		[Browsable(true)]
		[Description("Number of bits of the depth buffer.")]
		[DefaultValue(0)]
		public uint DepthBits
		{
			get { return (_DepthBits); }
			set {_DepthBits = value; }
		}

		/// <summary>
		/// The OpenGL depth buffer bits.
		/// </summary>
		private uint _DepthBits = 0;

		/// <summary>
		/// Get or set the OpenGL stencil buffer bits.
		/// </summary>
		[Browsable(true)]
		[Description("Number of bits of the stencil buffer.")]
		[DefaultValue(0)]
		public uint StencilBits
		{
			get { return (_StencilBits); }
			set { _StencilBits = value; }
		}

		/// <summary>
		/// The OpenGL stencil buffer bits.
		/// </summary>
		private uint _StencilBits = 0;

		/// <summary>
		/// Get or set the OpenGL multisample buffer "bits".
		/// </summary>
		[Browsable(true)]
		[Description("Number of bits of the multisample buffer.")]
		[DefaultValue(0)]
		public uint MultisampleBits
		{
			get { return (_MultisampleBits); }
			set { _MultisampleBits = value; }
		}

		/// <summary>
		/// The OpenGL multisample buffer bits.
		/// </summary>
		private uint _MultisampleBits = 0;

		/// <summary>
		/// Get or set the OpenGL double buffering flag.
		/// </summary>
		[Browsable(true)]
		[Description("Flag indicating whether double buffering is enabled.")]
		[DefaultValue(true)]
		public bool DoubleBuffer
		{
			get { return (_DoubleBuffer); }
			set { _DoubleBuffer = value; }
		}

		/// <summary>
		/// The OpenGL double buffering flag.
		/// </summary>
		private bool _DoubleBuffer = true;
		
		/// <summary>
		/// Get or set the OpenGL swap buffers interval.
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
		/// The OpenGL swap buffers interval.
		/// </summary>
		private int _SwapInterval = 1;

		#endregion

		#region Design/Debug Graphics

		/// <summary>
		/// Draw design mode graphics.
		/// </summary>
		/// <param name="e">
		/// A <see cref="PaintEventArgs"/> that specify the event arguments.
		/// </param>
		private void DrawDesign(PaintEventArgs e)
		{
			Size clientSize = ClientSize;

			e.Graphics.Clear(BackColor);
			e.Graphics.DrawLines(_DesignPen, new Point[] {
				new Point(0, 0), new Point(clientSize.Width, clientSize.Height),
				new Point(0, clientSize.Height), new Point(clientSize.Width, 0),
			});

			StringBuilder sysinfo = new StringBuilder();

			sysinfo.AppendFormat("Running on OpenGL {0}, GLSL {1}", Gl.CurrentVersion, Gl.CurrentShadingVersion);

			e.Graphics.DrawString(sysinfo.ToString(), _FailureFont, _FailureBrush, new RectangleF(PointF.Empty, clientSize));
		}

		/// <summary>
		/// Draw design mode graphics in case of failures.
		/// </summary>
		/// <param name="e">
		/// A <see cref="PaintEventArgs"/> that specify the event arguments.
		/// </param>
		private void DrawFailure(PaintEventArgs e, Exception exception)
		{
			Size clientSize = ClientSize;

			e.Graphics.Clear(BackColor);

			if (exception != null) {
				StringBuilder exceptionMessage = new StringBuilder();

				exceptionMessage.AppendFormat("Exception of type {0}: {1}\n", exception.GetType().Name, exception.Message);
				exceptionMessage.AppendFormat("Exception stacktrace: {0}\n", exception.StackTrace);

				e.Graphics.DrawString(exceptionMessage.ToString(), _FailureFont, _FailureBrush, new RectangleF(PointF.Empty, clientSize));
			} else {
				e.Graphics.DrawLines(_FailurePen, new Point[] {
					new Point(0, 0), new Point(clientSize.Width, clientSize.Height),
					new Point(0, clientSize.Height), new Point(clientSize.Width, 0),
				});
			}
		}

		/// <summary>
		/// Pen used for drawing in the case the UserControl at design time.
		/// </summary>
		private readonly Pen _DesignPen = new Pen(Color.Black, 1.5f);

		/// <summary>
		/// Pen used for drawing in the case of failures.
		/// </summary>
		private readonly Pen _FailurePen = new Pen(Color.Red, 1.5f);

		/// <summary>
		/// Brush used for drawing in the case of failures.
		/// </summary>
		private readonly Brush _FailureBrush = new SolidBrush(Color.Red);

		/// <summary>
		/// Font used for drawing in the case of failures.
		/// </summary>
		private readonly Font _FailureFont = new Font(FontFamily.GenericMonospace, 9.0f);

		#endregion

		#region Device Context

		/// <summary>
		/// The <see cref="DeviceContext"/> created on this GlControl.
		/// </summary>
		private IDeviceContext _DeviceContext;

		/// <summary>
		/// The OpenGL context created on this GlControl.
		/// </summary>
		private IntPtr _RenderContext;

		/// <summary>
		/// Exception caught while creating device context and render context.
		/// </summary>
		private Exception _FailureException;

		#endregion

		#region Events

		/// <summary>
		/// Event raised on control creation time, allow user to allocate resource on control.
		/// </summary>
		public event EventHandler<GlControlEventArgs> ContextCreated;

		/// <summary>
		/// Raise the event <see cref="ContextCreated"/>.
		/// </summary>
		protected virtual void OnContextCreated()
		{
			if (ContextCreated != null)
				ContextCreated(this, new GlControlEventArgs(_DeviceContext, _RenderContext));
		}

		/// <summary>
		/// Event raised on control disposition time, allow user to dispose resources on control.
		/// </summary>
		public event EventHandler<GlControlEventArgs> ContextDestroying;

		/// <summary>
		/// Raise the event <see cref="ContextDestroying"/>.
		/// </summary>
		protected virtual void OnContextDestroying()
		{
			if (ContextDestroying != null)
				ContextDestroying(this, new GlControlEventArgs(_DeviceContext, _RenderContext));
		}

		/// <summary>
		/// Event raised on control render time, allow user to draw on control.
		/// </summary>
		[Browsable(true)]
		public event EventHandler<GlControlEventArgs> Render;

		/// <summary>
		/// Raise the event <see cref="Render"/>.
		/// </summary>
		protected virtual void OnRender()
		{
			if (Render != null)
				Render(this, new GlControlEventArgs(_DeviceContext, _RenderContext));
		}

		#endregion

		#region UserControl Overrides

		/// <summary>
		/// Creates a handle for the control.
		/// </summary>
		protected override void CreateHandle()
		{
			// "Select" device pixel format before creating control handle
			switch (Environment.OSVersion.Platform) {
				case PlatformID.Unix:
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
				try {
					// Create device context
					_DeviceContext = DeviceContextFactory.Create(this);
					// Set pixel format
					DevicePixelFormat controlReqFormat = new DevicePixelFormat();
					controlReqFormat.ColorBits = (int)ColorBits;
					controlReqFormat.DepthBits = (int)DepthBits;
					controlReqFormat.StencilBits = (int)StencilBits;
					controlReqFormat.MultisampleBits = (int)MultisampleBits;
					controlReqFormat.DoubleBuffer = DoubleBuffer;

					DevicePixelFormatCollection pixelFormats = _DeviceContext.PixelsFormats;
					List<DevicePixelFormat> matchingPixelFormats = pixelFormats.Choose(controlReqFormat);

					if (matchingPixelFormats.Count == 0)
						throw new InvalidOperationException("unable to find a suitable pixel format");

					_DeviceContext.SetPixelFormat(matchingPixelFormats[0]);

					// Create OpenGL context
					if ((_RenderContext = _DeviceContext.CreateContext(IntPtr.Zero)) == IntPtr.Zero)
						throw new InvalidOperationException("unable to create render context");
					// Make context current
					if (_DeviceContext.MakeCurrent(_RenderContext) == false)
						throw new InvalidOperationException("unable to make current render context");
					// Event handling
					OnContextCreated();
				} catch (Exception exception) {
					_FailureException = exception;
				}
			}
			// Base implementation
			base.OnHandleCreated(e);
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
				if (_RenderContext != IntPtr.Zero) {
					// Event handling
					OnContextDestroying();
					// Destroy context
					_DeviceContext.DeleteContext(_RenderContext);
				}
				// Destroy device context
				_DeviceContext.Dispose();
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
				if (_RenderContext != IntPtr.Zero) {
					try {
						// Event handling
						OnRender();
						// Swap buffers if double-buffering
						_DeviceContext.SwapBuffers();
					} catch (Exception exception) {
						DrawFailure(e, exception);
					}
				} else
					DrawFailure(e, _FailureException);
			} else
				DrawDesign(e);
			// Base implementation
			base.OnPaint(e);
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">
		/// true if managed resources should be disposed; otherwise, false.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			// Designer components disposition
			if (disposing && (components != null))
				components.Dispose();
			// Dispose resources
			_DesignPen.Dispose();
			_FailurePen.Dispose();
			// Base implementation
			base.Dispose(disposing);
		}

		#endregion
	}

	/// <summary>
	/// Arguments for <see cref="GlControl"/> events.
	/// </summary>
	public class GlControlEventArgs : EventArgs
	{
		#region Constructors

		/// <summary>
		/// Construct a GlControlEventArgs.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="IDeviceContext"/> used for the underlying <see cref="GlControl"/>.
		/// </param>
		/// <param name="renderContext">
		/// The OpenGL context used for rendering.
		/// </param>
		public GlControlEventArgs(IDeviceContext deviceContext, IntPtr renderContext)
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
		/// The <see cref="IDeviceContext"/> used for the underlying <see cref="GlControl"/>.
		/// </summary>
		public readonly IDeviceContext DeviceContext;

		/// <summary>
		/// The OpenGL context used for rendering.
		/// </summary>
		public readonly IntPtr RenderContext;

		#endregion
	}
}
