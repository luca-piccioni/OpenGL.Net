﻿
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
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
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

		/// <summary>
		/// Static constructor.
		/// </summary>
		static GlControl()
		{
			Gl.Initialize();
		}

		/// <summary>
		/// Construct a GlControl.
		/// </summary>
		public GlControl()
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

		#region Design Properties - Context Attributes

		/// <summary>
		/// Get or set the version to be requested to the OpenGL driver.
		/// </summary>
		[Browsable(true)]
		[Category("Context")]
		[Description("The version to be implemented by the context created by this GlControl. If null, a compatibility profile is created.")]
		[DefaultValue(null)]
		[TypeConverter(typeof(KhronosVersionConverter))]
		public KhronosVersion Version
		{
			get { return (_Version); }
			set { _Version = value; }
		}

		/// <summary>
		/// Version to be requested to the OpenGL driver.
		/// </summary>
		private KhronosVersion _Version;

		/// <summary>
		/// Profile permission.
		/// </summary>
		public enum ProfileType
		{
			/// <summary>
			/// Requires the core profile
			/// </summary>
			Core,

			/// <summary>
			/// Requires the compatibility profile.
			/// </summary>
			Compatibility,
		}

		/// <summary>
		/// Get or set the permission to create a debug context.
		/// </summary>
		[Browsable(true)]
		[Category("Context")]
		[Description("The actual context profile implemented.")]
		[DefaultValue(ProfileType.Compatibility)]
		public ProfileType ContextProfile
		{
			get { return (_ProfileType); }
			set { _ProfileType = value; }
		}

		/// <summary>
		/// The permission to create a debug context.
		/// </summary>
		private ProfileType _ProfileType = ProfileType.Compatibility;

		/// <summary>
		/// Attribute permission.
		/// </summary>
		public enum AttributePermission
		{
			/// <summary>
			/// Requires the attribute. Throw an error is not supported.
			/// </summary>
			Required,

			/// <summary>
			/// Enable the attribute to be set, if supported.
			/// </summary>
			Enabled,

			/// <summary>
			/// Requires the attrbute to be set, but only when a debugger is attached.
			/// </summary>
			EnabledInDebugger,

			/// <summary>
			/// Do not specify the attribute.
			/// </summary>
			DonCare
		}

		/// <summary>
		/// Get or set the permission to create a debug context.
		/// </summary>
		[Browsable(true)]
		[Category("Context")]
		[Description("Permission to create a debug context.")]
		[DefaultValue(AttributePermission.EnabledInDebugger)]
		public AttributePermission DebugContext
		{
			get { return (_DebugContextBit); }
			set { _DebugContextBit = value; }
		}

		/// <summary>
		/// The permission to create a debug context.
		/// </summary>
		private AttributePermission _DebugContextBit = AttributePermission.EnabledInDebugger;

		/// <summary>
		/// Get or set the permission to create a forward compatible context.
		/// </summary>
		[Browsable(true)]
		[Category("Context")]
		[Description("Permission to create a forward compatible context.")]
		[DefaultValue(AttributePermission.DonCare)]
		public AttributePermission ForwardCompatibleContext
		{
			get { return (_ForwardCompatibleContextBit); }
			set { _ForwardCompatibleContextBit = value; }
		}

		/// <summary>
		/// The permission to create a debug context.
		/// </summary>
		private AttributePermission _ForwardCompatibleContextBit = AttributePermission.DonCare;

		/// <summary>
		/// Get or set the permission to create a context with the compatibility profile.
		/// </summary>
		[Browsable(true)]
		[Category("Context")]
		[Description("Permission to create a context with the compatibility profile.")]
		[DefaultValue(AttributePermission.DonCare)]
		public AttributePermission RobustContext
		{
			get { return (_RobustContextBit); }
			set { _RobustContextBit = value; }
		}

		/// <summary>
		/// The permission to create a robust context.
		/// </summary>
		private AttributePermission _RobustContextBit = AttributePermission.DonCare;

		#endregion

		#region Design Properties - Framebuffer

		/// <summary>
		/// Get or set the OpenGL minimum color buffer bits.
		/// </summary>
		[Browsable(true)]
		[Category("Framebuffer")]
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
		/// Get or set the OpenGL minimum depth buffer bits.
		/// </summary>
		[Browsable(true)]
		[Category("Framebuffer")]
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
		private uint _DepthBits;

		/// <summary>
		/// Get or set the OpenGL minimum stencil buffer bits.
		/// </summary>
		[Browsable(true)]
		[Category("Framebuffer")]
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
		private uint _StencilBits;

		/// <summary>
		/// Get or set the OpenGL minimum multisample buffer "bits".
		/// </summary>
		[Browsable(true)]
		[Category("Framebuffer")]
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
		private uint _MultisampleBits;

		/// <summary>
		/// Get or set the OpenGL double buffering flag.
		/// </summary>
		[Browsable(true)]
		[Category("Framebuffer")]
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
		[Category("Framebuffer")]
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
		protected void DrawDesign(PaintEventArgs e)
		{
			Size clientSize = ClientSize;
			RectangleF clientRect = new RectangleF(PointF.Empty, clientSize);

			e.Graphics.SetClip(clientRect);
			e.Graphics.Clear(BackColor);

			StringBuilder sysinfo = new StringBuilder();

			sysinfo.AppendFormat("Running on OpenGL {0}\n", Gl.CurrentVersion);
			sysinfo.AppendFormat("  - OpenGL Shading Language {0}\n", Gl.CurrentShadingVersion);

			e.Graphics.DrawString(sysinfo.ToString(), _DesignFont, _DesignBrush, clientRect);
		}

		/// <summary>
		/// Draw design mode graphics in case of failures.
		/// </summary>
		/// <param name="e">
		/// A <see cref="PaintEventArgs"/> that specify the event arguments.
		/// </param>
		protected void DrawFailure(PaintEventArgs e, Exception exception)
		{
			Size clientSize = ClientSize;

			e.Graphics.Clear(BackColor);

			if (exception != null) {
				StringBuilder exceptionMessage = new StringBuilder();

				exceptionMessage.AppendFormat("Exception of type {0}: {1}\n", exception.GetType().Name, exception.Message);
				exceptionMessage.AppendFormat("Exception stacktrace: {0}\n", exception.StackTrace);

				e.Graphics.DrawString(exceptionMessage.ToString(), _DesignFont, _FailureBrush, new RectangleF(PointF.Empty, clientSize));
			} else {
				e.Graphics.DrawLines(_FailurePen, new Point[] {
					new Point(0, 0), new Point(clientSize.Width, clientSize.Height),
					new Point(0, clientSize.Height), new Point(clientSize.Width, 0),
				});
			}
		}

		/// <summary>
		/// Pen used for drawing the UserControl at design time.
		/// </summary>
		private readonly Pen _DesignPen = new Pen(Color.Black, 1.5f);

		/// <summary>
		/// Brush used for drawing the UserControl at design time.
		/// </summary>
		private readonly Brush _DesignBrush = new SolidBrush(Color.Black);

		/// <summary>
		/// Font used for drawing  the UserControl in the case of failures.
		/// </summary>
		private readonly Font _DesignFont = new Font(FontFamily.GenericMonospace, 9.0f);

		/// <summary>
		/// Pen used for drawing  the UserControl in the case of failures.
		/// </summary>
		private readonly Pen _FailurePen = new Pen(Color.Red, 1.5f);

		/// <summary>
		/// Brush used for drawing the UserControl in the case of failures.
		/// </summary>
		private readonly Brush _FailureBrush = new SolidBrush(Color.Red);

		#endregion

		#region Device Context

		/// <summary>
		/// Create the device context and set the pixel format.
		/// </summary>
		protected void CreateDeviceContext()
		{
			// Create device context
			_DeviceContext = DeviceContextFactory.Create(this.Handle);
			_DeviceContext.IncRef();

			// Set pixel format
			DevicePixelFormatCollection pixelFormats = _DeviceContext.PixelsFormats;
			DevicePixelFormat controlReqFormat = new DevicePixelFormat();
			controlReqFormat.ColorBits = (int)ColorBits;
			controlReqFormat.DepthBits = (int)DepthBits;
			controlReqFormat.StencilBits = (int)StencilBits;
			controlReqFormat.MultisampleBits = (int)MultisampleBits;
			controlReqFormat.DoubleBuffer = DoubleBuffer;

			List<DevicePixelFormat> matchingPixelFormats = pixelFormats.Choose(controlReqFormat);
			if (matchingPixelFormats.Count == 0)
				throw new InvalidOperationException("unable to find a suitable pixel format");

			_DeviceContext.SetPixelFormat(matchingPixelFormats[0]);
		}

		/// <summary>
		/// Create the GlControl context.
		/// </summary>
		protected virtual void CreateContext()
		{
			if (_RenderContext != IntPtr.Zero)
				throw new InvalidOperationException("context already created");

			KhronosVersion currentVersion = Gl.CurrentVersion;
			Gl.Extensions currentExtensions = Gl.CurrentExtensions;
			
			bool hasCreateContext = true;
			bool hasCreateContextProfile = true;
			bool hasCreateContextRobustness = true;

			hasCreateContextProfile &= currentVersion.Api == KhronosVersion.ApiGl && currentVersion >= Gl.Version_300;
			switch (Environment.OSVersion.Platform) {
				case PlatformID.Win32NT:
					Wgl.Extensions currentWglExtensions = Wgl.CurrentExtensions;
					hasCreateContext &= currentWglExtensions.CreateContext_ARB || currentWglExtensions.CreateContextProfile_ARB;
					hasCreateContextProfile &= currentWglExtensions.CreateContextProfile_ARB;
					hasCreateContextRobustness = currentWglExtensions.CreateContextRobustness_ARB;
					break;
				case PlatformID.Unix:
					Glx.Extensions currentGlxExtensions = Glx.CurrentExtensions;
					hasCreateContext &= currentGlxExtensions.CreateContext_ARB;
					hasCreateContextProfile &= currentGlxExtensions.CreateContextProfile_ARB;
					hasCreateContextRobustness = currentGlxExtensions.CreateContextRobustness_ARB;
					break;
			}

			if (hasCreateContext) {
				List<int> attributes = new List<int>();
				uint contextProfile = 0, contextFlags = 0;
				bool debuggerAttached = Debugger.IsAttached;

				#region WGL_ARB_create_context|GLX_ARB_create_context

				// The default values for WGL_CONTEXT_MAJOR_VERSION_ARB and WGL_CONTEXT_MINOR_VERSION_ARB are 1 and 0 respectively. In this
				// case, implementations will typically return the most recent version of OpenGL they support which is backwards compatible with OpenGL 1.0
				// (e.g. 3.0, 3.1 + GL_ARB_compatibility, or 3.2 compatibility profile) [from WGL_ARB_create_context spec]
				Debug.Assert(Wgl.CONTEXT_MAJOR_VERSION_ARB == Glx.CONTEXT_MAJOR_VERSION_ARB);
				Debug.Assert(Wgl.CONTEXT_MINOR_VERSION_ARB == Glx.CONTEXT_MINOR_VERSION_ARB);
				if (Version != null) {
					attributes.AddRange(new int[] {
						Wgl.CONTEXT_MAJOR_VERSION_ARB, Version.Major,
						Wgl.CONTEXT_MINOR_VERSION_ARB, Version.Minor
					});
				} else {
					attributes.AddRange(new int[] {
						Wgl.CONTEXT_MAJOR_VERSION_ARB, currentVersion.Major,
						Wgl.CONTEXT_MINOR_VERSION_ARB, currentVersion.Minor
					});
				}

				if ((_DebugContextBit == AttributePermission.Enabled) || (debuggerAttached && _DebugContextBit == AttributePermission.EnabledInDebugger)) {
					Debug.Assert(Wgl.CONTEXT_DEBUG_BIT_ARB == Glx.CONTEXT_DEBUG_BIT_ARB);
					contextFlags |= Wgl.CONTEXT_DEBUG_BIT_ARB;
				}

				if ((_ForwardCompatibleContextBit == AttributePermission.Enabled) || (debuggerAttached && _ForwardCompatibleContextBit == AttributePermission.EnabledInDebugger)) {
					Debug.Assert(Wgl.CONTEXT_FORWARD_COMPATIBLE_BIT_ARB == Glx.CONTEXT_FORWARD_COMPATIBLE_BIT_ARB);
					contextFlags |= Wgl.CONTEXT_FORWARD_COMPATIBLE_BIT_ARB;
				}

				#endregion

				#region WGL_ARB_create_context_profile|GLX_ARB_create_context_profile

				if (hasCreateContextProfile) {

					switch (_ProfileType) {
						case ProfileType.Core:
							Debug.Assert(Wgl.CONTEXT_CORE_PROFILE_BIT_ARB == Glx.CONTEXT_CORE_PROFILE_BIT_ARB);
							contextProfile |= Wgl.CONTEXT_CORE_PROFILE_BIT_ARB;
							break;
						case ProfileType.Compatibility:
							Debug.Assert(Wgl.CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB == Glx.CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB);
							contextProfile |= Wgl.CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB;
							break;
					}
				}

				#endregion

				#region WGL_ARB_create_context_robustness|GLX_ARB_create_context_robustness

				if (hasCreateContextRobustness) {

					if ((_RobustContextBit == AttributePermission.Enabled) || (debuggerAttached && _RobustContextBit == AttributePermission.EnabledInDebugger)) {
						Debug.Assert(Wgl.CONTEXT_ROBUST_ACCESS_BIT_ARB == Glx.CONTEXT_ROBUST_ACCESS_BIT_ARB);
						contextFlags |= Wgl.CONTEXT_ROBUST_ACCESS_BIT_ARB;
					}

				}

				#endregion

				Debug.Assert(Wgl.CONTEXT_FLAGS_ARB == Glx.CONTEXT_FLAGS_ARB);
				if (contextFlags != 0)
					attributes.AddRange(new int[] { Wgl.CONTEXT_FLAGS_ARB, unchecked((int)contextFlags) });

				Debug.Assert(Wgl.CONTEXT_PROFILE_MASK_ARB == Glx.CONTEXT_PROFILE_MASK_ARB);
				if (contextProfile != 0)
					attributes.AddRange(new int[] { Wgl.CONTEXT_PROFILE_MASK_ARB, unchecked((int)contextProfile) });

				attributes.Add(0);

				if ((_RenderContext = _DeviceContext.CreateContextAttrib(IntPtr.Zero, attributes.ToArray())) == IntPtr.Zero)
					throw new InvalidOperationException(String.Format("unable to create render context ({0})", Gl.GetError()));
			} else {
				// Create OpenGL context using compatibility profile
				if ((_RenderContext = _DeviceContext.CreateContext(IntPtr.Zero)) == IntPtr.Zero)
					throw new InvalidOperationException("unable to create render context");
			}
		}

		/// <summary>
		/// Make the GlControl context current.
		/// </summary>
		protected virtual void MakeCurrentContext()
		{
			// Make context current
			if (_DeviceContext.MakeCurrent(_RenderContext) == false)
				throw new InvalidOperationException("unable to make context current");
		}

		/// <summary>
		/// Delete the GlControl context.
		/// </summary>
		protected virtual void DeleteContext()
		{
			// Delete OpenGL context
			_DeviceContext.DeleteContext(_RenderContext);
			_RenderContext = IntPtr.Zero;
		}

		/// <summary>
		/// The <see cref="DeviceContext"/> created on this GlControl.
		/// </summary>
		protected IDeviceContext _DeviceContext;

		/// <summary>
		/// The OpenGL context created on this GlControl.
		/// </summary>
		protected IntPtr _RenderContext;

		/// <summary>
		/// Exception caught while creating device context and render context.
		/// </summary>
		protected Exception _FailureException;

		#endregion

		#region Events

		/// <summary>
		/// Event raised on control creation time, allow user to allocate resource on control.
		/// </summary>
		public event EventHandler<GlControlEventArgs> ContextCreated
		{
			add { _ContextCreated += value; }
			remove { _ContextCreated -= value; }
		}

		/// <summary>
		/// Underlying EventHandler for <see cref="ContextCreated"/>.
		/// </summary>
		private EventHandler<GlControlEventArgs> _ContextCreated;

		/// <summary>
		/// Raise the event <see cref="ContextCreated"/>.
		/// </summary>
		protected virtual void OnContextCreated()
		{
			if (_ContextCreated != null) {
				GlControlEventArgs glControlEventArgs = new GlControlEventArgs(_DeviceContext, _RenderContext);

				foreach(EventHandler<GlControlEventArgs> handler in _ContextCreated.GetInvocationList()) {
					try {
						handler(this, glControlEventArgs);
					} catch (Exception) {
						// Fail-safe
					}
				}
			}
				
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
		public event EventHandler<GlControlEventArgs> Render;

		/// <summary>
		/// Raise the event <see cref="Render"/>.
		/// </summary>
		protected virtual void OnRender()
		{
			if (Render != null && _RenderContext != IntPtr.Zero)
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
					// Create device/render context
					CreateDeviceContext();
					CreateContext();

					// The context is made current unconditionally: it will be current also on OnPaint, avoiding
					// rendundant calls to glMakeCurrent ini nominal implementations
					MakeCurrentContext();

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
					DeleteContext();
				}
				// Destroy device context
				_DeviceContext.DecRef();
				_DeviceContext = null;
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
				if (_FailureException == null) {
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
