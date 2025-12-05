
// Copyright (c) 2017 Luca Piccioni
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

// ReSharper disable RedundantUsingDirective
// ReSharper disable UnusedMember.Local
// ReSharper disable InconsistentNaming

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenGL.CoreUI
{
	/// <summary>
	/// NativeWindow implementation for WindowsNT platform.
	/// </summary>
	partial class NativeWindowWinNT : NativeWindow
	{
		#region Constructors

		/// <summary>
		/// Create a NativeWindowWinNT.
		/// </summary>
		public NativeWindowWinNT()
		{
			_WindowsWndProc = WindowsWndProc;

			_HInstance = UnsafeNativeMethods.GetModuleHandle(typeof(Gl).Assembly.Location);
		}

		#endregion

		#region Platform Resources

		private IntPtr WindowsWndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
		{
			switch ((WM)msg) {
				case WM.CREATE:
					return WindowsWndProc_CREATE(hWnd, wParam, lParam);
				case WM.DESTROY:
					return WindowsWndProc_DESTROY(hWnd, wParam, lParam);
				case WM.PAINT:
					return WindowsWndProc_PAINT(hWnd, wParam, lParam);
				case WM.SIZE:
					return WindowsWndProc_SIZE(hWnd, wParam, lParam);

				case WM.SYSCOMMAND:
					break;

				case WM.KEYDOWN:
					return WindowsWndProc_KEYDOWN(hWnd, wParam, lParam);
				case WM.KEYUP:
					return WindowsWndProc_KEYUP(hWnd, wParam, lParam);

				case WM.MOUSELEAVE:
					return WindowsWndProc_MOUSELEAVE(hWnd, wParam, lParam);
				case WM.MOUSEMOVE:
					return WindowsWndProc_MOUSEMOVE(hWnd, wParam, lParam);
				case WM.LBUTTONDOWN:
				case WM.RBUTTONDOWN:
				case WM.MBUTTONDOWN:
				case WM.XBUTTONDOWN:
					return WindowsWndProc_BUTTONDOWN(hWnd, wParam, lParam);
				case WM.LBUTTONUP:
				case WM.RBUTTONUP:
				case WM.MBUTTONUP:
				case WM.XBUTTONUP:
					return WindowsWndProc_BUTTONUP(hWnd, wParam, lParam);
				case WM.LBUTTONDBLCLK:
				case WM.RBUTTONDBLCLK:
				case WM.MBUTTONDBLCLK:
				case WM.XBUTTONDBLCLK:
					return WindowsWndProc_BUTTONDOUBLECLICK(hWnd, wParam, lParam);
				case WM.MOUSEWHEEL:
					return WindowsWndProc_MOUSEWHEEL(hWnd, wParam, lParam);
			}

			// Callback default window procedure.
			return UnsafeNativeMethods.DefWindowProc(hWnd, msg, wParam, lParam);
		}

		// ReSharper disable UnusedParameter.Local
		
		private IntPtr WindowsWndProc_CREATE(IntPtr hWnd, IntPtr wParam, IntPtr lParam)
		{
			// Create device context
			CreateDeviceContext(IntPtr.Zero, hWnd);
			// Create OpenGL context
			CreateDesktopContext();
			// The context is made current unconditionally: event handlers allocate resources
			MakeCurrentContext();
			// Event handling
			OnContextCreated();

			return IntPtr.Zero;
		}
		
		private IntPtr WindowsWndProc_DESTROY(IntPtr hWnd, IntPtr wParam, IntPtr lParam)
		{
			DeleteContext();
			DestroyDeviceContext();

			return IntPtr.Zero;
		}
		
		private IntPtr WindowsWndProc_PAINT(IntPtr hWnd, IntPtr wParam, IntPtr lParam)
		{
			MakeCurrentContext();
			OnRender();
			OnContextUpdate();
			SwapBuffers();

			// Animation
			if (Animation) {
				if (AnimationTime > 0) {
					throw new NotImplementedException();
				} else {
					// Invalidate continuosly
					Invalidate();
				}
			}

			return IntPtr.Zero;
		}
		
		private IntPtr WindowsWndProc_SIZE(IntPtr hWnd, IntPtr wParam, IntPtr lParam)
		{
			// Notify about client area size changed
			// Note: 
			OnResize();

			return IntPtr.Zero;
		}
		
		private IntPtr WindowsWndProc_KEYDOWN(IntPtr hWnd, IntPtr wParam, IntPtr lParam)
		{
			VirtualKeys virtualKeyDown = (VirtualKeys)wParam.ToInt32();
			// bool extendedKeyDown = ((lParam.ToInt64() >> 24) & 1) != 0);
			KeyCode key = ToKeyCode(virtualKeyDown);

			if (key == KeyCode.None)
				return IntPtr.Zero;

			OnKeyDown(key);

			return IntPtr.Zero;
		}
		
		private IntPtr WindowsWndProc_KEYUP(IntPtr hWnd, IntPtr wParam, IntPtr lParam)
		{
			VirtualKeys virtualKeyUp = (VirtualKeys)wParam.ToInt32();
			// bool extendedKeyUp = ((lParam.ToInt64() >> 24) & 1) != 0);
			KeyCode key = ToKeyCode(virtualKeyUp);

			if (key == KeyCode.None)
				return IntPtr.Zero;

			OnKeyUp(key);

			return IntPtr.Zero;
		}
		
		private IntPtr WindowsWndProc_MOUSELEAVE(IntPtr hWnd, IntPtr wParam, IntPtr lParam)
		{
			// Next mouse event can track again mouse leave
			_TrackingMouseLeave = false;

			OnMouseLeave();

			return IntPtr.Zero;
		}

		/// <summary>
		/// Flag indicating whether the system is tracking the mouse leave.
		/// </summary>
		private bool _TrackingMouseLeave;

		private IntPtr WindowsWndProc_MOUSEMOVE(IntPtr hWnd, IntPtr wParam, IntPtr lParam)
		{
			Point mouseLocation = WindowsWndProc_GetMouseLocation(lParam);
			MouseButton mouseButton = WindowsWndProc_GetMouseButtons(wParam);

			if (_TrackingMouseLeave == false) {
				// Emulates 'WM_MOUSEENTER'
				OnMouseEnter(mouseLocation, mouseButton);
				// Keep tracking WM_MOUSELEAVE
				TRACKMOUSEEVENT tme = new TRACKMOUSEEVENT(TME.LEAVE, hWnd);
				_TrackingMouseLeave = UnsafeNativeMethods.TrackMouseEvent(ref tme);
				Debug.Assert(_TrackingMouseLeave, new Win32Exception(Marshal.GetLastWin32Error()).Message);
			}

			// Note: WM_MOUSEMOVE is execute just after 'WM_MOUSEENTER'
			OnMouseMove(mouseLocation, mouseButton);

			return IntPtr.Zero;
		}

		private IntPtr WindowsWndProc_BUTTONDOWN(IntPtr hWnd, IntPtr wParam, IntPtr lParam)
		{
			OnMouseDown(WindowsWndProc_GetMouseLocation(lParam), WindowsWndProc_GetMouseButtons(wParam));

			return IntPtr.Zero;
		}

		private IntPtr WindowsWndProc_BUTTONUP(IntPtr hWnd, IntPtr wParam, IntPtr lParam)
		{
			OnMouseUp(WindowsWndProc_GetMouseLocation(lParam), WindowsWndProc_GetMouseButtons(wParam));

			return IntPtr.Zero;
		}

		private IntPtr WindowsWndProc_BUTTONDOUBLECLICK(IntPtr hWnd, IntPtr wParam, IntPtr lParam)
		{
			OnMouseDoubleClick(WindowsWndProc_GetMouseLocation(lParam), WindowsWndProc_GetMouseButtons(wParam));

			return IntPtr.Zero;
		}
		
		private IntPtr WindowsWndProc_MOUSEWHEEL(IntPtr hWnd, IntPtr wParam, IntPtr lParam)
		{
			short wheelTicks = (short)(((wParam.ToInt64() >> 16) & 0xFFFF) / /* WHEEL_DELTA */ 120);

			OnMouseWheel(WindowsWndProc_GetMouseLocation(lParam), WindowsWndProc_GetMouseButtons(wParam), wheelTicks);

			return IntPtr.Zero;
		}

		// ReSharper restore UnusedParameter.Local

		private Point WindowsWndProc_GetMouseLocation(IntPtr lParam)
		{
			int x = lParam.ToInt32() & 0xFFFF;
			int y = (lParam.ToInt32() >> 16) & 0xFFFF;

			return new Point(x, (int)Height - y - 1);
		}

		private static MouseButton WindowsWndProc_GetMouseButtons(IntPtr wParam)
		{
			MouseButton buttons = MouseButton.None;
			int wParamValue = wParam.ToInt64() & 0xFFFF;

			if ((wParamValue & 0x0001) != 0)
				buttons |= MouseButton.Left;
			if ((wParamValue & 0x0002) != 0)
				buttons |= MouseButton.Right;
			if ((wParamValue & 0x0010) != 0)
				buttons |= MouseButton.Middle;
			if ((wParamValue & 0x0020) != 0)
				buttons |= MouseButton.X1;
			if ((wParamValue & 0x0040) != 0)
				buttons |= MouseButton.X2;

			return buttons;
		}

		/// <summary>
		/// Application instance handle.
		/// </summary>
		private readonly IntPtr _HInstance;

		/// <summary>
		/// The native window handle.
		/// </summary>
		private IntPtr _Handle;

		/// <summary>
		/// The atom associated to the window class.
		/// </summary>
		private ushort _ClassAtom;

		/// <summary>
		/// Windows procedure.
		/// </summary>
		private readonly UnsafeNativeMethods.WndProc _WindowsWndProc;

		#endregion

		#region Multithreading

		/// <summary>
		/// The ID of the thread that has created the window.
		/// </summary>
		private uint _OwnerThread;

		/// <summary>
		/// Get the current thread ID.
		/// </summary>
		/// <returns></returns>
		[DllImport("kernel32.dll")]
		private static extern uint GetCurrentThreadId();

		#endregion

		#region Error Checking

		private void CheckHandle()
		{
			if (_Handle == IntPtr.Zero)
				throw new InvalidOperationException("no handle");
		}

		private void CheckNotFullscreen()
		{
			if (Fullscreen)
				throw new InvalidOperationException("fullscreen");
		}

		private void CheckThread()
		{
			if (GetCurrentThreadId() != _OwnerThread)
				throw new InvalidOperationException("cross-thread operation not allowed");
		}

		#endregion

		#region NativeWindow Overrides

		/// <summary>
		/// Get the display handle associated this instance.
		/// </summary>
		public override IntPtr Display
		{
			get {
				return IntPtr.Zero;
			}
		}

		/// <summary>
		/// Get the native window handle.
		/// </summary>
		public override IntPtr Handle
		{
			get {
				return _Handle;
			}
		}

		/// <summary>
		/// Create the NativeWindow.
		/// </summary>
		/// <param name="x">
		/// A <see cref="Int32"/> that specifies the X coordinate of the window, in pixels.
		/// </param>
		/// <param name="y">
		/// A <see cref="Int32"/> that specifies the Y coordinate of the window, in pixels.
		/// </param>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specifies the window width, in pixels.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specifies the window height, in pixels.
		/// </param>
		/// <param name="style">
		/// The initial <see cref="NativeWindowStyle"/> of the window.
		/// </param>
		public override void Create(int x, int y, uint width, uint height, NativeWindowStyle style)
		{
			if (_Handle != IntPtr.Zero)
				throw new InvalidOperationException("already created");

			// Register window class
			WNDCLASSEX windowClass = new WNDCLASSEX();
			const string defaultWindowClass = "OpenGL.CoreUI2";

			windowClass.cbSize = Marshal.SizeOf(typeof(WNDCLASSEX));
			windowClass.style = (int)(UnsafeNativeMethods.CS_HREDRAW | UnsafeNativeMethods.CS_VREDRAW | UnsafeNativeMethods.CS_OWNDC);
			windowClass.lpfnWndProc = Marshal.GetFunctionPointerForDelegate(_WindowsWndProc);
			windowClass.hInstance = _HInstance;
			windowClass.lpszClassName = defaultWindowClass;

			if ((_ClassAtom = UnsafeNativeMethods.RegisterClassEx(ref windowClass)) == 0)
				throw new Win32Exception(Marshal.GetLastWin32Error());

			try {
				WindowStyles windowStyle = FromNativeWindowStyle(style);

				// Note: window size is meant as client area, but CreateWindowEx width/height specifies the external
				// frame size: compute offset for frame borders
				RECT clientSize = GetClientToFrameRect(x, y, width, height, windowStyle);
				// Create window
				_Handle = UnsafeNativeMethods.CreateWindowEx(
					0, windowClass.lpszClassName, string.Empty, (uint)windowStyle,
					clientSize.left, clientSize.top, clientSize.right - clientSize.left, clientSize.bottom - clientSize.top,
					IntPtr.Zero, IntPtr.Zero, windowClass.hInstance, IntPtr.Zero
				);

				if (_Handle == IntPtr.Zero)
					throw new Win32Exception(Marshal.GetLastWin32Error());

				_OwnerThread = GetCurrentThreadId();
			} catch {
				Dispose();
				throw;
			}
			
		}

		/// <summary>
		/// Closes the NativeWindow.
		/// </summary>
		public override void Destroy()
		{
			CheckHandle();

			UnsafeNativeMethods.PostMessage(_Handle, WM.DESTROY, IntPtr.Zero, IntPtr.Zero);

			Stop();
		}

		/// <summary>
		/// Run the event loop for this NativeWindow.
		/// </summary>
		public override void Run()
		{
			if (_LoopRunning)
				throw new InvalidOperationException("loop running");

			_LoopRunning = true;

			try {
				MSG msg;
				int ret;
				
				while ((ret = UnsafeNativeMethods.GetMessage(out msg, IntPtr.Zero, 0, 0)) != 0) {
					if (ret < 0)
						throw new Win32Exception(Marshal.GetLastWin32Error());

					switch (msg.message) {
						case (int)(WM.USER + 13):
							// Terminate message loop
							return;
						default:
							UnsafeNativeMethods.TranslateMessage(ref msg);
							UnsafeNativeMethods.DispatchMessage(ref msg);
							break;
					}
				}
			} finally {
				_LoopRunning = false;
			}
		}

		/// <summary>
		/// Stops the event loop running for this NativeWindow.
		/// </summary>
		public override void Stop()
		{
			if (_LoopRunning == false)
				throw new InvalidOperationException("loop not running");

			UnsafeNativeMethods.PostMessage(_Handle, WM.USER + 13, IntPtr.Zero, IntPtr.Zero);
		}

		/// <summary>
		/// The state of the message loop.
		/// </summary>
		private bool _LoopRunning;

		/// <summary>
		/// Get or set the NativeWindow location.
		/// </summary>
		public override Point Location
		{
			get {
				CheckHandle();

				RECT windowRect;

				if (UnsafeNativeMethods.GetWindowRect(_Handle, out windowRect) == false)
					throw new Win32Exception(Marshal.GetLastWin32Error());

				return (Point)windowRect;
			}
			set {
				CheckHandle();
				CheckThread();
				CheckNotFullscreen();

				const SetWindowPosFlags windowPosFlags =
					SetWindowPosFlags.SWP_NOSIZE | SetWindowPosFlags.SWP_NOZORDER |
					SetWindowPosFlags.SWP_NOACTIVATE |
					SetWindowPosFlags.SWP_FRAMECHANGED;
				
				if (UnsafeNativeMethods.SetWindowPos(_Handle, IntPtr.Zero, value.X, value.Y, 0, 0, windowPosFlags) == false)
					throw new Win32Exception(Marshal.GetLastWin32Error());
			}
		}

		/// <summary>
		/// Get or set the NativeWindow client area size.
		/// </summary>
		public override Size ClientSize
		{
			get {
				CheckHandle();
				CheckThread();

				RECT clientSize;

				if (UnsafeNativeMethods.GetClientRect(_Handle, out clientSize) == false)
					throw new Win32Exception(Marshal.GetLastWin32Error());

				return (Size)clientSize;
			}
			set {
				CheckHandle();
				CheckThread();
				CheckNotFullscreen();

				const SetWindowPosFlags windowPosFlags =
					SetWindowPosFlags.SWP_NOMOVE | SetWindowPosFlags.SWP_NOZORDER |
					SetWindowPosFlags.SWP_NOACTIVATE |
					SetWindowPosFlags.SWP_FRAMECHANGED;

				Size frameSize = (Size)GetClientToFrameRect(0, 0, (uint)value.Width, (uint)value.Height);

				if (UnsafeNativeMethods.SetWindowPos(_Handle, IntPtr.Zero, 0, 0, frameSize.Width, frameSize.Height, windowPosFlags) == false)
					throw new Win32Exception(Marshal.GetLastWin32Error());
			}
		}

		private static RECT GetClientToFrameRect(int x, int y, uint width, uint height, WindowStyles windowStyles)
		{
			RECT clientSize = new RECT {
				left = x,
				right = x + (int) width,
				top = y,
				bottom = y + (int) height
			};

			if ((windowStyles & WindowStyles.WS_THICKFRAME) != 0) {
				int cxSizeFrame = UnsafeNativeMethods.GetSystemMetrics(SystemMetric.CXSizeFrame) * 2;
				int cySizeFrame = UnsafeNativeMethods.GetSystemMetrics(SystemMetric.CYSizeFrame) * 2;

				clientSize.left -= cxSizeFrame;
				clientSize.right += cxSizeFrame;
				clientSize.top -= cySizeFrame;
				clientSize.bottom += cySizeFrame;
			}

			if ((windowStyles & WindowStyles.WS_CAPTION) != 0) {
				int cySizeCaption = UnsafeNativeMethods.GetSystemMetrics(SystemMetric.CYCaption);

				clientSize.bottom += cySizeCaption;
			}

			return clientSize;
		}

		private RECT GetClientToFrameRect(int x, int y, uint width, uint height)
		{
			WindowStyles windowStyle = (WindowStyles)UnsafeNativeMethods.GetWindowLong(_Handle, SetWindowLongIndex.GWL_STYLE);
			WindowStyles windowStyleEx = (WindowStyles)UnsafeNativeMethods.GetWindowLong(_Handle, SetWindowLongIndex.GWL_EXSTYLE);

			return GetClientToFrameRect(x, y, width, height, windowStyle | windowStyleEx);
		}

		/// <summary>
		/// Show the native window.
		/// </summary>
		public override void Show()
		{
			CheckHandle();
			CheckThread();

			UnsafeNativeMethods.ShowWindow(_Handle, WindowShowStyle.Show);
			Invalidate();
		}

		/// <summary>
		/// Hide the native window.
		/// </summary>
		public override void Hide()
		{
			CheckHandle();
			CheckThread();

			UnsafeNativeMethods.ShowWindow(_Handle, WindowShowStyle.Hide);
		}

		/// <summary>
		/// Get the implemented window styles by the underlying implementation.
		/// </summary>
		public override NativeWindowStyle SupportedStyles
		{
			get { return NativeWindowStyle.Border | NativeWindowStyle.Caption | NativeWindowStyle.Resizeable; }
		}

		/// <summary>
		/// The styles of this NativeWindow.
		/// </summary>
		public override NativeWindowStyle Styles
		{
			get
			{
				CheckHandle();
				CheckThread();

				WindowStyles win32Style = (WindowStyles)UnsafeNativeMethods.GetWindowLong(_Handle, SetWindowLongIndex.GWL_STYLE);

				return ToNativeWindowStyle(win32Style);
			}
			set
			{
				CheckHandle();
				CheckNotFullscreen();
				CheckThread();

				NativeWindowStyle styles = value;

				// No border? No caption!
				if ((styles & NativeWindowStyle.Border) == 0)
					styles &= (NativeWindowStyle)~(0x0001 | 0x0004);

				WindowStyles supportedStyles = FromNativeWindowStyle(SupportedStyles);
				WindowStyles win32Style = (WindowStyles)UnsafeNativeMethods.GetWindowLong(_Handle, SetWindowLongIndex.GWL_STYLE) & ~supportedStyles;
				WindowStyles win32StyleValue = FromNativeWindowStyle(styles);

				UnsafeNativeMethods.SetWindowLong(_Handle, SetWindowLongIndex.GWL_STYLE, (uint)(win32Style | win32StyleValue));
				UnsafeNativeMethods.SetWindowPos(_Handle, IntPtr.Zero, 0, 0, 0, 0, SetWindowPosFlags.SWP_FRAMECHANGED | SetWindowPosFlags.SWP_NOACTIVATE | SetWindowPosFlags.SWP_NOZORDER | SetWindowPosFlags.SWP_NOMOVE | SetWindowPosFlags.SWP_NOSIZE);
			}
		}

		/// <summary>
		/// Get or set the NativeWindow fullscreen state.
		/// </summary>
		public override bool Fullscreen
		{
			get
			{
				// Not required, but keep API behavior
				CheckHandle();
				CheckThread();

				return _Fullscreen;
			}
			set {
				CheckHandle();
				CheckThread();

				if (_Fullscreen == value)
					return;

				if (value) {
					// Get monitor size
					MONITORINFOEX monitorInfo = new MONITORINFOEX(string.Empty);
					IntPtr monitor = UnsafeNativeMethods.MonitorFromWindow(_Handle, UnsafeNativeMethods.MONITOR_DEFAULTTONEAREST);

					if (UnsafeNativeMethods.GetMonitorInfo(monitor, ref monitorInfo) == false)
						throw new InvalidOperationException("unable to get monitor info");

					// Store current location and size
					_FullscreenRestoreLocation = Location;
					_FullscreenRestoreSize = ClientSize;
					// Store current styles
					_FullscreenRestoreStyle = (WindowStyles)UnsafeNativeMethods.GetWindowLong(_Handle, SetWindowLongIndex.GWL_STYLE);
					_FullscreenRestoreStyleEx = (WindowStyles)UnsafeNativeMethods.GetWindowLong(_Handle, SetWindowLongIndex.GWL_EXSTYLE);

					// Set window styles
					WindowStyles fullscreenStyle = _FullscreenRestoreStyle & ~(WindowStyles.WS_CAPTION | WindowStyles.WS_THICKFRAME);

					UnsafeNativeMethods.SetWindowLong(_Handle, SetWindowLongIndex.GWL_STYLE, (uint)fullscreenStyle);

					// Set position and size
					Point location = (Point)monitorInfo.WorkArea;
					Size size = (Size)monitorInfo.Monitor;
					const SetWindowPosFlags windowPosFlags = SetWindowPosFlags.SWP_NOZORDER | SetWindowPosFlags.SWP_NOACTIVATE | SetWindowPosFlags.SWP_FRAMECHANGED;

					if (UnsafeNativeMethods.SetWindowPos(_Handle, IntPtr.Zero, location.X, location.Y, size.Width, size.Height, windowPosFlags) == false)
						throw new InvalidOperationException("unable to set client size");
				} else {
					// Restore previous styles
					UnsafeNativeMethods.SetWindowLong(_Handle, SetWindowLongIndex.GWL_STYLE, (uint)_FullscreenRestoreStyle);
					UnsafeNativeMethods.SetWindowLong(_Handle, SetWindowLongIndex.GWL_EXSTYLE, (uint)_FullscreenRestoreStyleEx);

					// Restore previous position and size
					Point location = _FullscreenRestoreLocation;
					Size size = _FullscreenRestoreSize;
					const SetWindowPosFlags windowPosFlags = SetWindowPosFlags.SWP_NOZORDER | SetWindowPosFlags.SWP_NOACTIVATE | SetWindowPosFlags.SWP_FRAMECHANGED;

					if (UnsafeNativeMethods.SetWindowPos(_Handle, IntPtr.Zero, location.X, location.Y, size.Width, size.Height, windowPosFlags) == false)
						throw new InvalidOperationException("unable to set client size");
				}

				_Fullscreen = value;
			}
		}

		/// <summary>
		/// The NativeWindow fullscreen state.
		/// </summary>
		private bool _Fullscreen;

		/// <summary>
		/// 
		/// </summary>
		private Point _FullscreenRestoreLocation;

		/// <summary>
		/// 
		/// </summary>
		private Size _FullscreenRestoreSize;

		/// <summary>
		/// 
		/// </summary>
		private WindowStyles _FullscreenRestoreStyle;

		/// <summary>
		/// 
		/// </summary>
		private WindowStyles _FullscreenRestoreStyleEx;

		/// <summary>
		/// Invalidate the window.
		/// </summary>
		public override void Invalidate()
		{
			CheckHandle();
			CheckThread();

			UnsafeNativeMethods.InvalidateRect(_Handle, IntPtr.Zero, true);
			UnsafeNativeMethods.UpdateWindow(_Handle);
		}

		/// <summary>
		/// Emulates the key pressed event.
		/// </summary>
		/// <param name="key">
		/// The <see cref="KeyCode"/> indicating what key is emulated.
		/// </param>
		/// <remarks>
		/// This method is mainly used for testing, but it may be useful for some application.
		/// </remarks>
		public override void EmulatesKeyPress(KeyCode key)
		{
			CheckHandle();

			// Determine arguments
			VirtualKeys virtualKey = ToVirtualKeys(key);

			// Event sequence
			UnsafeNativeMethods.SendMessage(_Handle, WM.KEYDOWN, new IntPtr((uint)virtualKey), IntPtr.Zero);
			UnsafeNativeMethods.SendMessage(_Handle, WM.KEYUP,   new IntPtr((uint)virtualKey), IntPtr.Zero);
		}

		/// <summary>
		/// Get or set the cursor visibility.
		/// </summary>
		public override bool CursorVisible { get; set; }

		/// <summary>
		/// Emulates the mouse move event.
		/// </summary>
		/// <param name="location">
		/// The <see cref="Point"/> indicating the location of the mouse at the event.
		/// </param>
		/// <remarks>
		/// This method is mainly used for testing, but it may be useful for some application.
		/// </remarks>
		public override void EmulatesMouseMove(Point location)
		{

		}

		/// <summary>
		/// Emulates the mouse buttons pressed event.
		/// </summary>
		/// <param name="location">
		/// The <see cref="Point"/> indicating the location of the mouse at the event.
		/// </param>
		/// <param name="buttons">
		/// The <see cref="MouseButton"/> indicating the buttons pressed at the event.
		/// </param>
		/// <remarks>
		/// This method is mainly used for testing, but it may be useful for some application.
		/// </remarks>
		public override void EmulatesMouseButtonClick(Point location, MouseButton buttons)
		{

		}

		/// <summary>
		/// Emulates the mouse buttons double-pressed event.
		/// </summary>
		/// <param name="location">
		/// The <see cref="Point"/> indicating the location of the mouse at the event.
		/// </param>
		/// <param name="buttons">
		/// The <see cref="MouseButton"/> indicating the buttons double-pressed at the event.
		/// </param>
		/// <remarks>
		/// This method is mainly used for testing, but it may be useful for some application.
		/// </remarks>
		public override void EmulatesMouseButtonDoubleClick(Point location, MouseButton buttons)
		{

		}

		/// <summary>
		/// Emulates the mouse buttons wheel event.
		/// </summary>
		/// <param name="location">
		/// The <see cref="Point"/> indicating the location of the mouse at the event.
		/// </param>
		/// <param name="ticks">
		/// The <see cref="Int32"/> indicating the the wheel ticks.
		/// </param>
		/// <remarks>
		/// This method is mainly used for testing, but it may be useful for some application.
		/// </remarks>
		public override void EmulatesMouseWheel(Point location, int ticks)
		{

		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="System.Boolean"/> indicating whether the disposition is requested explictly.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			DeleteContext();
			DestroyDeviceContext();

			if (_Handle != IntPtr.Zero) {
				CheckThread();

				UnsafeNativeMethods.DestroyWindow(_Handle);
				_Handle = IntPtr.Zero;
				_OwnerThread = 0;
			}

			if (_ClassAtom != 0) {
				UnsafeNativeMethods.UnregisterClass(_ClassAtom, _HInstance);
				_ClassAtom = 0;
			}

			// Base implementation
			base.Dispose(disposing);
		}

		#endregion
	}
}
