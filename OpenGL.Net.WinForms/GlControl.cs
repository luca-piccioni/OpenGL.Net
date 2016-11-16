
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
using System.Text;
using System.Windows.Forms;

namespace OpenGL
{
	/// <summary>
	/// Basic <see cref="UserControl"/> for rendering using OpenGL.Net.
	/// </summary>
	public partial class GlControl : UserControl
	{
		#region Constructors

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
		[Description(
			"The version to be implemented by the context created by this GlControl. If null, the default version is created. " +
			"Considered only if WGL_ARB_create_context is supported."
		)]
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

			/// <summary>
			/// Embedded profile (OpenGL ES).
			/// </summary>
			Embedded,
		}

		/// <summary>
		/// Get or set the permission to create a debug context.
		/// </summary>
		[Browsable(true)]
		[Category("Context")]
		[Description("Select the type of profile of the context. Considered only if WGL_ARB_create_context is supported.")]
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
		[Description("Creates a debug context. Considered only if WGL_ARB_create_context_profile is supported.")]
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
		[Description("Creates a forward-compatible context. Considered only if WGL_ARB_create_context is supported.")]
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
		/// Get or set the permission to create a robust context.
		/// </summary>
		[Browsable(true)]
		[Category("Context")]
		[Description("Creates a robust context. Considered only if WGL_ARB_create_context_robustness is supported.")]
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
		[Description("Minimum number of bits of the color buffer.")]
		[DefaultValue(24)]
		public uint ColorBits
		{
			get { return (_ColorBits); }
			set
			{
				_ColorBits = value;
				// In-Designer pixel format checking
				DesignerValidatePixelFormat();
			}
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
		[Description("Minimum number of bits of the depth buffer.")]
		[DefaultValue(0)]
		public uint DepthBits
		{
			get { return (_DepthBits); }
			set
			{
				_DepthBits = value;
				// In-Designer pixel format checking
				DesignerValidatePixelFormat();
			}
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
		[Description("Minimum number of bits of the stencil buffer.")]
		[DefaultValue(0)]
		public uint StencilBits
		{
			get { return (_StencilBits); }
			set
			{
				_StencilBits = value;
				// In-Designer pixel format checking
				DesignerValidatePixelFormat();
			}
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
		[Description("Minimum number of samples of the multisample buffer.")]
		[DefaultValue(0)]
		public uint MultisampleBits
		{
			get { return (_MultisampleBits); }
			set
			{
				_MultisampleBits = value;
				// In-Designer pixel format checking
				DesignerValidatePixelFormat();
			}
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
		[Description("Flag indicating whether double buffering is required.")]
		[DefaultValue(true)]
		public bool DoubleBuffer
		{
			get { return (_DoubleBuffer); }
			set
			{
				_DoubleBuffer = value;
				// In-Designer pixel format checking
				DesignerValidatePixelFormat();
			}
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
		[Description(
			"Integer specifing the minimum number of video frames that are displayed before a buffer swap will occur. " +
			"Considered only if (WGL|GLX)_EXT_swap_control is supported: set to 1 to enable V-Sync or set to 0 to disable V-Sync. " +
			"If the (WGL|GLX)_EXT_swap_control_tear is supported, set to -1 to enable adaptive V-Sync."
		)]
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
				controlReqFormat.DoubleBuffer = DoubleBuffer && (_ProfileType != ProfileType.Embedded);     // DB not yet managed using ANGLE

				return (controlReqFormat);
			}
		}

		/// <summary>
		/// Performs a design-time check to validate the current pixel format.
		/// </summary>
		private void DesignerValidatePixelFormat()
		{
			if (DesignMode == false)
				return;

			try {
				if (_DeviceContext == null)
					CreateDeviceContext(new DevicePixelFormat(0));

				List<DevicePixelFormat> pixelFormats = _DeviceContext.PixelsFormats.Choose(ControlPixelFormat);

				if (pixelFormats.Count > 0) {
					_DesignerPixelFormatNotice = String.Format("Device pixel format:\n  > {0}", pixelFormats[0]);
				} else {
					_DesignerPixelFormatNotice = String.Format("Unable to find suitable pixel format:\n  > {0}", _DeviceContext.PixelsFormats.GuessChooseError(ControlPixelFormat));
				}
			} catch (Exception exception) {
				_DesignerPixelFormatNotice = exception.ToString();
			}

			Invalidate();
		}

		/// <summary>
		/// Notice to be displayed at design-time about current pixel format selection.
		/// </summary>
		private string _DesignerPixelFormatNotice;

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
			sysinfo.AppendFormat("  - OpenGL Shading Language version: {0}\n", Gl.CurrentShadingVersion);
			sysinfo.AppendFormat("  - Vendor: {0}\n", Gl.CurrentVendor);
			sysinfo.AppendFormat("  - Renderer: {0}\n", Gl.CurrentRenderer);
			if (Egl.IsAvailable)
				sysinfo.AppendFormat("- EGL is available.\n\n");

			if (_DesignerPixelFormatNotice != null)
				sysinfo.AppendFormat("{0}\n", _DesignerPixelFormatNotice);

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
		/// Get the <see cref="DeviceContext"/> created on this GlControl.
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
			#region Support embedded profile via ANGLE

			if (_ProfileType == ProfileType.Embedded) {
				if (Egl.IsAvailable == false)
					throw new InvalidOperationException("EGL/ANGLE platform not available");
				Egl.IsRequired = true;
			}

			#endregion

			#region Create device context

			_DeviceContext = DeviceContext.Create(GetDisplay(), this.Handle);
			_DeviceContext.IncRef();

			#endregion

			#region Set pixel format

			DevicePixelFormatCollection pixelFormats = _DeviceContext.PixelsFormats;
			List<DevicePixelFormat> matchingPixelFormats = pixelFormats.Choose(controlReqFormat);

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
		/// Get the display associated with this Control.
		/// </summary>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> valid for GLX functions as display parameter.
		/// </returns>
		protected IntPtr GetDisplay()
		{
			Type xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");

			if (xplatui != null) {
				// Get System.Windows.Forms display
				IntPtr display = (IntPtr)xplatui.GetField("DisplayHandle", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
				KhronosApi.LogComment("System.Windows.Forms.XplatUIX11.DisplayHandle is 0x{0}", display.ToString("X"));
				if (display == IntPtr.Zero)
					throw new InvalidOperationException("unable to connect to X server using XPlatUI");

				// Screen
				// _Screen = (int)xplatui.GetField("ScreenNo", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
				// KhronosApi.LogComment("System.Windows.Forms.XplatUIX11.ScreenNo is {0}", _Screen);

				return (display);
			} else
				return (IntPtr.Zero);
		}

		/// <summary>
		/// The <see cref="DeviceContext"/> created on this GlControl.
		/// </summary>
		protected DeviceContext _DeviceContext;

		#endregion

		#region OpenGL Context

		/// <summary>
		/// Create the GlControl context.
		/// </summary>
		protected virtual void CreateContext()
		{
			if (_RenderContext != IntPtr.Zero)
				throw new InvalidOperationException("context already created");

			switch (ContextSharing) {
				case ContextSharingOption.OwnContext:
					// This GlControl own its context
					if ((_ProfileType != ProfileType.Embedded) && (Gl.CurrentVersion.Api == KhronosVersion.ApiGl))
						CreateDesktopContext();
					else
						CreateEmbeddedContext();
					break;
				case ContextSharingOption.SingleContext:
					// This GlControl reuse a context previously created
					ReuseOtherContext();
					break;
			}

			Debug.Assert(_RenderContext != IntPtr.Zero);
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
			// Remove this context from the sharing group
			if (ContextSharing == ContextSharingOption.OwnContext && ContextSharingGroup != null) {
				List<IntPtr> sharingContextes;

				// Get the list previously created
				_SharingGroups.TryGetValue(ContextSharingGroup, out sharingContextes);
				// Remove this context
				bool res = sharingContextes.Remove(_RenderContext);
				Debug.Assert(res);
			}

			// Delete OpenGL context
			if (_RenderContext != IntPtr.Zero) {
				_DeviceContext.DeleteContext(_RenderContext);
				_RenderContext = IntPtr.Zero;
			}
		}

		/// <summary>
		/// Create the GlControl context, eventually shared with others.
		/// </summary>
		protected void CreateDesktopContext()
		{
			if (_RenderContext != IntPtr.Zero)
				throw new InvalidOperationException("context already created");

			KhronosVersion currentVersion = Gl.CurrentVersion;
			
			IntPtr sharingContext = IntPtr.Zero;
			bool shareResources = ContextSharing == ContextSharingOption.OwnContext && ContextSharingGroup != null;

			if (shareResources) {
				List<IntPtr> sharingContextes;

				if (_SharingGroups.TryGetValue(ContextSharingGroup, out sharingContextes))
					sharingContext = sharingContextes.Count > 0 ? sharingContextes[0] : IntPtr.Zero;
				else
					_SharingGroups.Add(ContextSharingGroup, new List<IntPtr>());
			}

			if (Gl.PlatformExtensions.CreateContext_ARB) {
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
					// Note: this shouldn't be necessary since defaults are defined. However, on certains drivers this arguments are
					// required for specifying CONTEXT_FLAGS_ARB and CONTEXT_PROFILE_MASK_ARB attributes:
					// - Required by NVIDIA 266.72 on GeForce GT 540M on Windows 7 x64
					attributes.AddRange(new int[] {
						Wgl.CONTEXT_MAJOR_VERSION_ARB, Gl.CurrentVersion.Major,
						Wgl.CONTEXT_MINOR_VERSION_ARB, Gl.CurrentVersion.Minor
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

				if (Gl.PlatformExtensions.CreateContextProfile_ARB) {

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

				if (Gl.PlatformExtensions.CreateContextRobustness_ARB) {

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
				Debug.Assert(contextProfile == 0 || Gl.PlatformExtensions.CreateContextProfile_ARB);
				if (contextProfile != 0)
					attributes.AddRange(new int[] { Wgl.CONTEXT_PROFILE_MASK_ARB, unchecked((int)contextProfile) });

				attributes.Add(0);

				if ((_RenderContext = _DeviceContext.CreateContextAttrib(sharingContext, attributes.ToArray())) == IntPtr.Zero)
					throw new InvalidOperationException(String.Format("unable to create render context ({0})", Gl.GetError()));
			} else {
				// Create OpenGL context using compatibility profile
				if ((_RenderContext = _DeviceContext.CreateContext(sharingContext)) == IntPtr.Zero)
					throw new InvalidOperationException("unable to create render context");
			}

			// Allow other GlControl instances to reuse this GlControl context
			if (shareResources) {
				if (_SharingControls.ContainsKey(ContextSharingGroup))
					throw new InvalidOperationException(String.Format("another GlControl has created sharing group {0}", ContextSharingGroup));
				_SharingControls.Add(ContextSharingGroup, this);
			}

			// Allow other GlControl instances to share resources with this context
			if (shareResources == true) {
				List<IntPtr> sharingContextes;

				// Get the list previously created
				_SharingGroups.TryGetValue(ContextSharingGroup, out sharingContextes);
				// ...and register this context among the others
				sharingContextes.Add(_RenderContext);
			}
		}

		/// <summary>
		/// Create the GlControl context, eventually shared with others.
		/// </summary>
		protected void CreateEmbeddedContext()
		{
			if (_RenderContext != IntPtr.Zero)
				throw new InvalidOperationException("context already created");

			IntPtr sharingContext = IntPtr.Zero;
			List<int> attributes = new List<int>();

			attributes.AddRange(new int[] { Egl.CONTEXT_CLIENT_VERSION, 2 });
			attributes.Add(Egl.NONE);

			if ((_RenderContext = _DeviceContext.CreateContextAttrib(sharingContext, attributes.ToArray())) == IntPtr.Zero)
				throw new InvalidOperationException(String.Format("unable to create render context ({0})", Gl.GetError()));
		}

		/// <summary>
		/// Reuse the GlControl context of another GlControl, eventually shared with others.
		/// </summary>
		protected void ReuseOtherContext()
		{
			if (ContextSharingGroup == null)
				throw new InvalidOperationException("undefined context sharing group");

			if (_SharingControls.TryGetValue(ContextSharingGroup, out _SharingControl) == false)
				throw new InvalidOperationException(String.Format("no GlControl sharing with {0}", ContextSharingGroup));

			// Resure context
			_RenderContext = _SharingControl._RenderContext;
			// ...but reset it when no more valid
			_SharingControl.ContextCreated += SharingControl_ContextCreated;
			_SharingControl.ContextDestroying += SharingControl_ContextDestroying;
		}

		/// <summary>
		/// Ensure <see cref="_RenderContext"/> is in sync with other <see cref="GlControl"/> owning the context.
		/// </summary>
		/// <param name="sender">
		/// The <see cref="GlControl"/> raising the event.
		/// </param>
		/// <param name="e">
		/// A <see cref="GlControlEventArgs"/> specifying the event arguments.
		/// </param>
		private void SharingControl_ContextCreated(object sender, GlControlEventArgs e)
		{
			Debug.Assert(ReferenceEquals(_SharingControl, sender));
			Debug.Assert(_RenderContext == IntPtr.Zero);

			// Copy context reference
			_RenderContext = _SharingControl._RenderContext;
			// Emulates event
			OnContextCreated();
		}

		/// <summary>
		/// Ensure <see cref="_RenderContext"/> is in sync with other <see cref="GlControl"/> owning the context.
		/// </summary>
		/// <param name="sender">
		/// The <see cref="GlControl"/> raising the event.
		/// </param>
		/// <param name="e">
		/// A <see cref="GlControlEventArgs"/> specifying the event arguments.
		/// </param>
		private void SharingControl_ContextDestroying(object sender, GlControlEventArgs e)
		{
			Debug.Assert(ReferenceEquals(_SharingControl, sender));
			Debug.Assert(_RenderContext != IntPtr.Zero);

			// Emulates event
			OnContextDestroying();
			// Loose reference
			_RenderContext = IntPtr.Zero;
		}

		/// <summary>
		/// The OpenGL context created on this GlControl.
		/// </summary>
		protected IntPtr _RenderContext;

		/// <summary>
		/// The <see cref="GlControl"/> that owns <see cref="_RenderContext"/>.
		/// </summary>
		private GlControl _SharingControl;

		#endregion

		#region Context Sharing

		/// <summary>
		/// Context sharing options.
		/// </summary>
		public enum ContextSharingOption
		{
			/// <summary>
			/// Create its own context.
			/// </summary>
			OwnContext,

			/// <summary>
			/// Do not create its own context, but reuse the first one created by application.
			/// </summary>
			SingleContext,
		}

		/// <summary>
		/// Get or set the context sharing option.
		/// </summary>
		[Browsable(true)]
		[Category("Context")]
		[Description("Option for sharing the context with other GlControl instances.")]
		[DefaultValue(ContextSharingOption.OwnContext)]
		public ContextSharingOption ContextSharing
		{
			get { return (_ContextSharing); }
			set
			{
				if (_RenderContext != IntPtr.Zero)
					throw new InvalidOperationException("read-only property");
				_ContextSharing = value;
			}
		}

		/// <summary>
		/// The context sharing option.
		/// </summary>
		private ContextSharingOption _ContextSharing = ContextSharingOption.OwnContext;

		/// <summary>
		/// Get or set a tag for defining sharing groups.
		/// </summary>
		[Browsable(true)]
		[Category("Context")]
		[Description("Tag for sharing resource with other GlControl instances. Each one having the same tag will share resources.")]
		[DefaultValue(null)]
		public string ContextSharingGroup
		{
			get { return (_ContextSharingGroup); }
			set
			{
				if (_RenderContext != IntPtr.Zero)
					throw new InvalidOperationException("read-only property");
				_ContextSharingGroup = value;
			}
		}

		/// <summary>
		/// A tag for defining sharing groups.
		/// </summary>
		private string _ContextSharingGroup;

		/// <summary>
		/// Map group names with the contextes sharing resources.
		/// </summary>
		private static readonly Dictionary<string, List<IntPtr>> _SharingGroups = new Dictionary<string, List<IntPtr>>();

		/// <summary>
		/// 
		/// </summary>
		private static readonly Dictionary<string, GlControl> _SharingControls = new Dictionary<string, GlControl>();

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
					CreateDeviceContext();
					// Create OpenGL context
					CreateContext();
					// The context is made current unconditionally: event handlers allocate resources
					MakeCurrentContext();
					// Event handling
					OnContextCreated();
				} catch (Exception exception) {
					_FailureException = exception;
					Debug.Fail(String.Format("OnHandleCreated: initialization exception ({0})\n{1}", exception.Message, exception.ToString()));
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
					if (_SharingControl == null)
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
						// Ensure that context is actually current on this device
						MakeCurrentContext();
						// Event handling
						OnRender();
						// Swap buffers if double-buffering
						_DeviceContext.SwapBuffers();

						// Invalidate();
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
		/// Exception caught while creating device context and render context.
		/// </summary>
		protected Exception _FailureException;

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

			// Avoid reference leaks
			if (_SharingControl != null) {
				_SharingControl.ContextDestroying -= SharingControl_ContextDestroying;
				_SharingControl.ContextCreated -= SharingControl_ContextCreated;
			}
			// This control cannot create context anymore
			if (ContextSharing == ContextSharingOption.OwnContext && ContextSharingGroup != null)
				_SharingControls.Remove(ContextSharingGroup);

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
		/// The <see cref="DeviceContext"/> used for the underlying <see cref="GlControl"/>.
		/// </param>
		/// <param name="renderContext">
		/// The OpenGL context used for rendering.
		/// </param>
		public GlControlEventArgs(DeviceContext deviceContext, IntPtr renderContext)
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
		/// The <see cref="DeviceContext"/> used for the underlying <see cref="GlControl"/>.
		/// </summary>
		public readonly DeviceContext DeviceContext;

		/// <summary>
		/// The OpenGL context used for rendering.
		/// </summary>
		public readonly IntPtr RenderContext;

		#endregion
	}

	/// <summary>
	/// Designer converter for <see cref="KhronosVersion"/> properties.
	/// </summary>
	internal class KhronosVersionConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type destinationType)
		{
			return (destinationType == typeof(string) || base.CanConvertTo(context, destinationType));
		}

		public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
		{
			if (Object.ReferenceEquals(value, null))
				return base.ConvertFrom(context, culture, value);
			
			Type valueType = value.GetType();

			if (valueType == typeof(string)) {
				try {
					string valueString = (string)value;

					if (valueString == String.Empty)
						return (null);

					return (KhronosVersion.Parse(valueString));
				} catch (Exception exception) {
					throw new NotSupportedException("unable to parse the value", exception);
				}
			}

			// Base implementation
			return base.ConvertFrom(context, culture, value);
		}

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return (destinationType == typeof(string) || base.CanConvertTo(context, destinationType));
		}

		public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == typeof(string)) {
				KhronosVersion version = (KhronosVersion)value;

				if (version == null)
					return ("Current");

				return (version.ToString());
			}

			// Base implementation
			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}
