
// Copyright (C) 2016-2017 Luca Piccioni
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

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Khronos;

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
			SetStyle(ControlStyles.Opaque, true);
			// No double buffering
			SetStyle(ControlStyles.DoubleBuffer, false);
			DoubleBuffered = false;
			// Redraw window on resize
			SetStyle(ControlStyles.ResizeRedraw, true);
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
		public KhronosVersion ContextVersion { get; set; }

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

			/// <summary>
			/// Security Critical (OpenGL SC 2).
			/// </summary>
			SecurityCritical2,
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

		#region Design Properties - Animation

		/// <summary>
		/// Get or set the flag indicating whether control should update itself continuosly.
		/// </summary>
		[Browsable(true)]
		[Category("Animation")]
		[Description("Flag indicating whether control should update itself continuosly.")]
		[DefaultValue(false)]
		public bool Animation
		{
			get { return (_Animation); }
			set
			{
				_Animation = value;
				
				if (DesignMode == false) {
					if      (_AnimationTimer != null && AnimationTimer)
						_AnimationTimer.Enabled = Animation;
					else if (!AnimationTimer && Animation && !AnimationTimer && IsHandleCreated)
						BeginInvoke(new Action(delegate() { Invalidate(); }));
				}
			}
		}

		/// <summary>
		/// Flag indicating whether control should update itself continuosly.
		/// </summary>
		private bool _Animation;

		/// <summary>
		/// Get or set the time interval between animation updates, in milliseconds.
		/// </summary>
		[Browsable(true)]
		[Category("Animation")]
		[Description("Animation update time, in milliseconds. Zero means continuos update, limited to V-Sync (see SwapInterval property).")]
		[DefaultValue(0)]
		public int AnimationTime
		{
			get { return (_AnimationTime); }
			set
			{
				_AnimationTime = value;

				if (_AnimationTimer != null && !DesignMode)
					_AnimationTimer.Interval = Math.Max(1, _AnimationTime);
			}
		}

		/// <summary>
		/// The time interval between animation updates, in milliseconds.
		/// </summary>
		private int _AnimationTime;

		/// <summary>
		/// Get or set the flag for enabling animation using timers.
		/// </summary>
		[Browsable(true)]
		[Category("Animation")]
		[Description("Animation triggered by a Timer. Enable when integrated with other Forms control.")]
		[DefaultValue(true)]
		public bool AnimationTimer
		{
			get { return (_AnimationTimerFlag); }
			set
			{
				_AnimationTimerFlag = value;

				if      (_AnimationTimer == null && AnimationTimer && !DesignMode)
					CreateAnimationTimer();
				else if (_AnimationTimer != null && !AnimationTimer && !DesignMode)
					_AnimationTimer.Enabled = false;
			}
		}

		/// <summary>
		/// The flag for enabling animation using timers.
		/// </summary>
		private bool _AnimationTimerFlag = true;

		/// <summary>
		/// Create animation timer resources.
		/// </summary>
		private void CreateAnimationTimer()
		{
			if (_AnimationTimer == null) {
				_AnimationTimer = new Timer();
				_AnimationTimer.Tick += AnimationTimer_Tick;
				_AnimationTimer.Interval = Math.Max(1, _AnimationTime);
				_AnimationTimer.Enabled = Animation;
			}
		}

		/// <summary>
		/// Animation timer callback.
		/// </summary>
		/// <param name="sender">
		/// The <see cref="Timer"/> that has triggered the event.
		/// </param>
		/// <param name="e">
		/// The event arguments.
		/// </param>
		private void AnimationTimer_Tick(object sender, EventArgs e)
		{
			if (_AnimationInvalidated == 0)
				Invalidate();
			System.Threading.Interlocked.Add(ref _AnimationInvalidated, 1);
		}

		/// <summary>
		/// Timer used 
		/// </summary>
		private Timer _AnimationTimer;

		/// <summary>
		/// Boolean used for avoiding excessive Invalidate() calls
		/// </summary>
		private int _AnimationInvalidated;

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

			sysinfo.AppendFormat("Running on OpenGL {0}\n", Gl.CurrentVersion != null ? Gl.CurrentVersion.ToString() : "unknown (not initialized)");
			sysinfo.AppendFormat("  - OpenGL Shading Language version: {0}\n", Gl.CurrentShadingVersion != null ? Gl.CurrentShadingVersion.ToString() : "unknown (not initialized)");
			sysinfo.AppendFormat("  - Vendor: {0}\n", Gl.CurrentVendor ?? "unknown (not initialized)");
			sysinfo.AppendFormat("  - Renderer: {0}\n", Gl.CurrentRenderer ?? "unknown (not initialized)");
			if (Egl.IsAvailable)
				sysinfo.AppendFormat("- EGL is available.\n\n");

			if (_DesignerPixelFormatNotice != null)
				sysinfo.AppendFormat("{0}\n", _DesignerPixelFormatNotice);

			e.Graphics.DrawString(sysinfo.ToString(), _DesignFont, _DesignBrush, clientRect);
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
		/// Draw design mode graphics in case of failures.
		/// </summary>
		/// <param name="e">
		/// A <see cref="PaintEventArgs"/> that specify the event arguments.
		/// </param>
		/// <param name="exception">
		/// An <see cref="Exception"/> that describe the error encountered.
		/// </param>
		protected void DrawFailure(PaintEventArgs e, Exception exception)
		{
			Size clientSize = ClientSize;

			e.Graphics.Clear(BackColor);

			if (exception != null) {
				StringBuilder exceptionMessage = new StringBuilder();

				exceptionMessage.AppendFormat("Exception of type {0}: {1}\n", exception.GetType().Name, exception.ToString());
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
		[Browsable(false)]
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
			#region Support ES/SC API

			switch (_ProfileType) {
				case ProfileType.Embedded:
					DeviceContext.DefaultAPI = KhronosVersion.ApiGles2;
					break;
				case ProfileType.SecurityCritical2:
					DeviceContext.DefaultAPI = KhronosVersion.ApiGlsc2;
					break;
			}

			#endregion

			#region Create device context

			_DeviceContext = DeviceContext.Create(GetDisplay(), this.Handle);
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
		/// Get the display associated with this Control.
		/// </summary>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> valid for GLX functions as display parameter.
		/// </returns>
		protected IntPtr GetDisplay()
		{
			switch (Platform.CurrentPlatformId) {
				case Platform.Id.WindowsNT:
					return (IntPtr.Zero);
				case Platform.Id.Linux:
					Type xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");
					if (xplatui == null)
						throw new InvalidOperationException("no XPlatUI implementation");
					IntPtr display = (IntPtr)xplatui.GetField("DisplayHandle", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
					KhronosApi.LogComment($"System.Windows.Forms.XplatUIX11.DisplayHandle is 0x{display.ToString("X")}");
					if (display == IntPtr.Zero)
						throw new InvalidOperationException("unable to connect to X server using XPlatUI");

					// Screen
					// _Screen = (int)xplatui.GetField("ScreenNo", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
					// KhronosApi.LogComment("System.Windows.Forms.XplatUIX11.ScreenNo is {0}", _Screen);

					return (display);
				default:
					throw new NotSupportedException("platform " + Platform.CurrentPlatformId + " not supported");
			}
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
					CreateDesktopContext();
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

			IntPtr sharingContext = IntPtr.Zero;

			if (ContextSharing == ContextSharingOption.OwnContext && ContextSharingGroup != null) {
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
				if (ContextVersion != null) {
					attributes.AddRange(new int[] {
						Wgl.CONTEXT_MAJOR_VERSION_ARB, ContextVersion.Major,
						Wgl.CONTEXT_MINOR_VERSION_ARB, ContextVersion.Minor
					});
				} else {
					// Note: this shouldn't be necessary since defaults are defined. However, on certains drivers this arguments are
					// required for specifying CONTEXT_FLAGS_ARB and CONTEXT_PROFILE_MASK_ARB attributes:
					// - Required by NVIDIA 266.72 on GeForce GT 540M on Windows 7 x64
					attributes.AddRange(new int[] {
						Wgl.CONTEXT_MAJOR_VERSION_ARB, 1,
						Wgl.CONTEXT_MINOR_VERSION_ARB, 0
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

			// Allow other GlControl instances to share resources with this context
			if (ContextSharing == ContextSharingOption.OwnContext && ContextSharingGroup != null) {
				List<IntPtr> sharingContextes;

				// Get the list previously created
				_SharingGroups.TryGetValue(ContextSharingGroup, out sharingContextes);
				// ...and register this context among the others
				sharingContextes.Add(_RenderContext);
			}
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
		/// Map group names with the contextes for sharing resources (glShareLists or other means).
		/// </summary>
		private static readonly Dictionary<string, List<IntPtr>> _SharingGroups = new Dictionary<string, List<IntPtr>>();

		/// <summary>
		/// Map group names with the GlControl that has created a context, reused by others.
		/// </summary>
		private static readonly Dictionary<string, GlControl> _SharingControls = new Dictionary<string, GlControl>();

		#endregion

		#region Events

		/// <summary>
		/// Event raised on control creation time, allow user to allocate resource on control.
		/// </summary>
		[Browsable(true)]
		[Category("Rendering")]
		[Description("Generated when the relative OpenGL context has been created.")]
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
		[Browsable(true)]
		[Category("Rendering")]
		[Description("Generated just before the relative OpenGL context is being released.")]
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
		[Category("Rendering")]
		[Description("Generated when the GlControl has been requested to update its contents.")]
		public event EventHandler<GlControlEventArgs> Render;

		/// <summary>
		/// Raise the event <see cref="Render"/>.
		/// </summary>
		protected virtual void OnRender()
		{
			if (Render != null && _RenderContext != IntPtr.Zero)
				Render(this, new GlControlEventArgs(_DeviceContext, _RenderContext));
		}

		/// <summary>
		/// Event raised on control render time, allow user to update resources. It is executed AFTER the <see cref="Render"/>
		/// event.
		/// </summary>
		[Browsable(true)]
		[Category("Rendering")]
		[Description("Generated when the GlControl drawing commands are executed, but before the back-buffer is swapped.")]
		public event EventHandler<GlControlEventArgs> ContextUpdate;

		/// <summary>
		/// Raise the event <see cref="ContextUpdate"/>.
		/// </summary>
		protected virtual void OnContextUpdate()
		{
			if (ContextUpdate != null && _RenderContext != IntPtr.Zero)
				ContextUpdate(this, new GlControlEventArgs(_DeviceContext, _RenderContext));
		}

		#endregion

		#region Statistics

		/// <summary>
		/// Get the time spent for drawing the last frame.
		/// </summary>
		[Browsable(false)]
		public TimeSpan FrameDrawTime
		{
			get { return (_FrameDrawTime); }
		}

		/// <summary>
		/// The time spent for drawing the last frame.
		/// </summary>
		private TimeSpan _FrameDrawTime;

		/// <summary>
		/// Get the time spent for swapping the last frame.
		/// </summary>
		[Browsable(false)]
		public TimeSpan FrameSwapTime
		{
			get { return (_FrameSwapTime); }
		}

		/// <summary>
		/// The time spent for drawing the last frame.
		/// </summary>
		private TimeSpan _FrameSwapTime;

		#endregion

		#region UserControl Overrides

		/// <summary>
		/// Get the <see cref="CreateParams"/> relative this UserControl.
		/// </summary>
		protected override CreateParams CreateParams
		{
			get
			{
				const int CS_VREDRAW = 0x1, CS_HREDRAW = 0x2, CS_OWNDC = 0x20;
			
				// Base implementation
				CreateParams createParams = base.CreateParams;

				// Style customization
				switch (Platform.CurrentPlatformId) {
					case Platform.Id.WindowsNT:
						createParams.ClassStyle |= CS_VREDRAW | CS_HREDRAW | CS_OWNDC;
						break;
				}

				return (createParams);
			}
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
				// Create device context
				CreateDeviceContext();
				// Create OpenGL context
				CreateContext();
				// The context is made current unconditionally: event handlers allocate resources
				MakeCurrentContext();
				// Event handling
				OnContextCreated();
				// Animation support
				if (AnimationTimer && Animation)
					CreateAnimationTimer();
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
				Stopwatch sw = Stopwatch.StartNew();
				
				MakeCurrentContext();

				// Draw
				OnRender();
				_FrameDrawTime = sw.Elapsed;

				// Update
				OnContextUpdate();

				// Swap
				_DeviceContext.SwapBuffers();
				_FrameSwapTime = sw.Elapsed;
			} else
				DrawDesign(e);

			// Base implementation
			base.OnPaint(e);

			// Animation support
			System.Threading.Interlocked.Exchange(ref _AnimationInvalidated, 0);
			// Exclusive animation
			if (Animation && !AnimationTimer && !DesignMode) {
				if (AnimationTime > 0)
					System.Threading.Thread.Sleep(AnimationTime);
				Invalidate();
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
			// Designer components disposition
			if (disposing && (components != null))
				components.Dispose();

			// Dispose animation timer
			if (_AnimationTimer != null) {
				_AnimationTimer.Tick -= AnimationTimer_Tick;
				_AnimationTimer.Dispose();
			}

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
		/// <param name="deviceContext">
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
}
