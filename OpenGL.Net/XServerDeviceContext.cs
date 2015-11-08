
// Copyright (C) 2012-2015 Luca Piccioni
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
using System.Windows.Forms;

namespace OpenGL
{
	/// <summary>
	///Device context for Unix-based platforms.
	/// </summary>
	public sealed class XServerDeviceContext : DeviceContext
	{
		#region Constructors

		/// <summary>
		/// Initializes the <see cref="XServerDeviceContext"/> class.
		/// </summary>
		static XServerDeviceContext()
		{
			// Be notified about XServer errors
			Glx.UnsafeNativeMethods.XSetErrorHandler(Gl.XServerErrorHandler);
		}
		
		/// <summary>
		/// Construct a <see cref="Derm.Render.XServerDeviceContext"/> class that opens the local display.
		/// </summary>
		/// <remarks>
		/// The property <see cref="WindowHandle"/> must be set to a valid value, since no window is created. The
		/// window handle shall be created using the display <see cref="Display"/>.
		/// </remarks>
		/// <exception cref='InvalidOperationException'>
		/// Exception thrown in the case it is not possible to connect with the display 0.
		/// </exception>
		public XServerDeviceContext()
			: this(IntPtr.Zero)
		{

		}

		/// <summary>
		/// Construct a <see cref="Derm.Render.XServerDeviceContext"/> class that opens the specified display.
		/// </summary>
		/// <param name="display">
		/// A <see cref="System.IntpPtr"/> that will be argument of <see cref="Glx.XOpenDisplay"/>, indeed
		/// specifying the display to connect to.
		/// </param>
		/// <remarks>
		/// The property <see cref="WindowHandle"/> must be set to a valid value, since no window is created. The
		/// window handle shall be created using the display <see cref="Display"/>.
		/// </remarks>
		/// <exception cref='InvalidOperationException'>
		/// Exception thrown in the case it is not possible to connect with the display <paramref name="display"/>.
		/// </exception>
		public XServerDeviceContext(IntPtr display)
		{
			// Open display (follows DISPLAY environment variable)
			_Display = Glx.UnsafeNativeMethods.XOpenDisplay(display);
			ProcLoader.LogProc("XOpenDisplay(0x0) = 0x{0}", _Display.ToString("X"));
			if (_Display == IntPtr.Zero)
				throw new InvalidOperationException(String.Format("unable to connect to X server display {0}", display.ToInt32()));
			// Need to close display
			_OwnDisplay = true;

			// Screen
			_Screen = Glx.UnsafeNativeMethods.XDefaultScreen(_Display);
			
			// Query GLX extensions
			QueryExtensions();
		}

		/// <summary>
		/// Construct a <see cref="Derm.Render.XServerDeviceContext"/> class, initialized with the display of a control.
		/// </summary>
		/// <param name="control">
		/// Control.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="control"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="control"/> handle is not created.
		/// </exception>
		/// <exception cref="PlatformNotSupportedException">
		/// Exception thrown if the current assembly is not executed by a (supported) Mono runtime.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the current Mono runtime has not yet opened a display connection.
		/// </exception>
		public XServerDeviceContext(Control control)
		{
			if (control == null)
				throw new ArgumentNullException("control");

			IntPtr controlHandle = control.Handle;
			if (control.IsHandleCreated == false)
				throw new ArgumentException("handle not created", "control");

			Type xplatui = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");
        
			if (xplatui == null)
				throw new PlatformNotSupportedException("mono runtime version no supported");
			
			// Get System.Windows.Forms display
			_Display = (IntPtr)xplatui.GetField("DisplayHandle", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
			ProcLoader.LogComment("System.Windows.Forms.XplatUIX11.DisplayHandle is 0x{0}", _Display.ToString("X"));
			if (_Display == IntPtr.Zero)
				throw new InvalidOperationException("unable to connect to X server using XPlatUI");
			
			// Screen
			_Screen = (int)xplatui.GetField("ScreenNo", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic).GetValue(null);
			ProcLoader.LogComment("System.Windows.Forms.XplatUIX11.ScreenNo is {0}", _Screen);

			// Window handle
			_WindowHandle = controlHandle;
			
			// Query GLX extensions
			QueryExtensions();
		}

		#endregion

		#region Device Information

		/// <summary>
		/// The opened display.
		/// </summary>
		public IntPtr Display
		{
			get
			{
				if (IsDisposed)
					throw new ObjectDisposedException("XServerDeviceContext");
				return (_Display);
			}
		}

		/// <summary>
		/// The screen.
		/// </summary>
		public int Screen
		{
			get
			{
				if (IsDisposed)
					throw new ObjectDisposedException("XServerDeviceContext");
				return (_Screen);
			}
		}

		/// <summary>
		/// The window handle.
		/// </summary>
		public IntPtr WindowHandle
		{
			get
			{
				if (IsDisposed)
					throw new ObjectDisposedException("XServerDeviceContext");
				return (_WindowHandle);
			}
			set
			{
				if (IsDisposed)
					throw new ObjectDisposedException("XServerDeviceContext");
				if (_OwnDisplay == false)
					throw new InvalidOperationException("display not owned");
				_WindowHandle = value;
			}
		}

		/// <summary>
		/// The frame buffer configuration index.
		/// </summary>
		public IntPtr FBConfig
		{
			get
			{
				if (IsDisposed)
					throw new ObjectDisposedException("XServerDeviceContext");
				return (_FBConfig);
			}
			set
			{
				if (IsDisposed)
					throw new ObjectDisposedException("XServerDeviceContext");
				_FBConfig = value;
			}
		}



		/// <summary>
		/// The visual information (related with <see cref="FBConfig"/>.
		/// </summary>
		public Glx.XVisualInfo XVisualInfo
		{
			get
			{
				if (IsDisposed)
					throw new ObjectDisposedException("XServerDeviceContext");
				return (_VisualInfo);
			}
			set
			{
				if (IsDisposed)
					throw new ObjectDisposedException("XServerDeviceContext");
				_VisualInfo = value;
			}
		}

		/// <summary>
		/// The opened display.
		/// </summary>
		private readonly IntPtr _Display;

		/// <summary>
		/// The screen.
		/// </summary>
		private readonly int _Screen;

		/// <summary>
		/// The window handle.
		/// </summary>
		private IntPtr _WindowHandle;

		/// <summary>
		/// The frame buffer configuration.
		/// </summary>
		private IntPtr _FBConfig;

		/// <summary>
		/// The visual information.
		/// </summary>
		private Glx.XVisualInfo _VisualInfo;
		
		#endregion
		
		#region Multithreading Support
		
		/// <summary>
		/// Initializes the X11 multithreading.
		/// </summary>
		/// <exception cref='InvalidOperationException'>
		/// Is thrown when an operation cannot be performed.
		/// </exception>
		public static void InitializeMultithreading()
		{
			// Ensure to have X11 thread system initialized
			int initialized = Glx.UnsafeNativeMethods.XInitThreads();
			ProcLoader.LogProc("XInitThreads() = {0}", initialized);
			
			if (initialized == 0)
				throw new InvalidOperationException("platform does not support multithreading");
			
			_MultithreadingInitialized = true;
		}
		
		/// <summary>
		/// Gets a value indicating whether if X11 multithreading is initialized.
		/// </summary>
		/// <value>
		/// It returns <c>true</c> if this instance is X11 multithreading is initialized; otherwise, <c>false</c>.
		/// </value>
		internal static bool IsMultithreadingInitialized { get { return (_MultithreadingInitialized); } }
		
		/// <summary>
		/// Flag indicating whether X11 multithreading is initialized.
		/// </summary>
		private static bool _MultithreadingInitialized;
		
		#endregion
		
		#region Extension Support
		
		/// <summary>
		/// The GLX major version.
		/// </summary>
		public int GlxMajor { get { return (_GlxMajor); } }
		
		/// <summary>
		/// The GLX minor version.
		/// </summary>
		public int GlxMinor { get { return (_GlxMinor); } }
		
		/// <summary>
		/// Check whether current X11 implementation supports the extension.
		/// </summary>
		/// <param name="eName">
		/// A <see cref="System.String"/> that specifies the name of the X11 extension.
		/// </param>
		/// <returns>
		/// Returns a boolean value that indicates support for the X11 extension.
		/// </returns>
		public bool HasExtension(string eName)
		{
			return (_Extensions.ContainsKey(eName));
		}
		
		/// <summary>
		/// Query all X11 extensions supported by current implementation.
		/// </summary>
		private void QueryExtensions()
		{
			using (Glx.XLock xLock = new Glx.XLock(Display)) {
				string extString;
				int[] majorArg = new int[1], minorArg = new int[1];
	
				Glx.QueryVersion(Display, majorArg, minorArg);
	
				_GlxMajor = majorArg[0];
				_GlxMinor = minorArg[0];
	
				if ((_GlxMajor >= 1) && (_GlxMinor >= 1)) {
					extString = Glx.QueryExtensionsString(Display, 0);
					if (!String.IsNullOrEmpty(extString)) {
						string[] extTokens = extString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
						foreach (string e in extTokens)
							_Extensions.Add(e, true);
					}
				}
			}
		}
		
		/// <summary>
		/// The GLX major version.
		/// </summary>
		private int _GlxMajor;
		
		/// <summary>
		/// The GLX minor version.
		/// </summary>
		private int _GlxMinor;
		
		/// <summary>
		/// Available extensions.
		/// </summary>
		private readonly Dictionary<string, bool> _Extensions = new Dictionary<string, bool>();
		
		#endregion

		#region DeviceContext Overrides
		
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="System.Boolean"/> indicating whether the disposition is requested explictly.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if ((_OwnDisplay == true) && (Display != IntPtr.Zero)) {
					Glx.UnsafeNativeMethods.XCloseDisplay(Display);
					ProcLoader.LogProc("XCloseDisplay({0})", Display.ToString("X"));
				}
			}
		}
		
		/// <summary>
		/// Flag indicating whether the display has been opened with XOpenDisplay.
		/// </summary>
		private bool _OwnDisplay;

		#endregion
	}
}