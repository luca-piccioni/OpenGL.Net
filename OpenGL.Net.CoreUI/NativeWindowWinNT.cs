
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
using System.Diagnostics.CodeAnalysis;
using System.Reflection;                // Do not delete me! .NET Core include extension methods
using System.Runtime.InteropServices;

namespace OpenGL.CoreUI
{
	/// <summary>
	/// NativeWindow implementation for WindowsNT platform.
	/// </summary>
	class NativeWindowWinNT : NativeWindow
	{
		#region Constructors

		/// <summary>
		/// Create a NativeWindowWinNT.
		/// </summary>
		public NativeWindowWinNT()
		{
			_WindowsWndProc = WindowsWndProc;

#if NETCORE
			_HInstance = UnsafeNativeMethods.GetModuleHandle(typeof(Gl).GetTypeInfo().Assembly.Location);
#else
			_HInstance = Marshal.GetHINSTANCE(typeof(Gl).Module);
#endif
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
			short wheelTicks = (short)(((wParam.ToInt32() >> 16) & 0xFFFF) / /* WHEEL_DELTA */ 120);

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
			int wParamValue = wParam.ToInt32() & 0xFFFF;

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

		#region P/Invoke

		// ReSharper disable FieldCanBeMadeReadOnly.Local
		// ReSharper disable PrivateFieldCanBeConvertedToLocalVariable

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		private struct WNDCLASSEX
		{
			public int cbSize;
			public int style;
			public IntPtr lpfnWndProc;
			private int _ClsExtra;
			private int _WndExtra;
			public IntPtr hInstance;
			private IntPtr _Icon;
			private IntPtr _Cursor;
			private IntPtr _Background;
			[MarshalAs(UnmanagedType.LPTStr)]
			private string _MenuName;
			[MarshalAs(UnmanagedType.LPTStr)]
			public string lpszClassName;
			private IntPtr _IconSm;
		}

		[StructLayout(LayoutKind.Sequential)]
		private struct MSG
		{
			public IntPtr hwnd;
			public uint message;
			public UIntPtr wParam;
			public UIntPtr lParam;
			public uint time;
			public POINT pt;
		}

		[StructLayout(LayoutKind.Sequential)]
		private struct POINT
		{
			public int x;
			public int y;
		}

		[StructLayout(LayoutKind.Sequential)]
		[DebuggerDisplay("RECT: left={left} right={right} top={top} bottom={bottom}")]
		private struct RECT
		{
			public int left;
			public int top;
			public int right;
			public int bottom;

			public static explicit operator Point(RECT rect)
			{
				return new Point(rect.left, rect.top);
			}

			public static explicit operator Size(RECT rect)
			{
				return new Size(rect.right - rect.left, rect.bottom - rect.top);
			}
		}

		/// <summary>
		/// The MONITORINFO structure contains information about a display monitor.
		/// The GetMonitorInfo function stores information into a MONITORINFOEX structure or a MONITORINFO structure.
		/// The MONITORINFOEX structure is a superset of the MONITORINFO structure. The MONITORINFOEX structure adds a string member to contain a name 
		/// for the display monitor.
		/// </summary>
		[StructLayout(LayoutKind.Sequential)]
		private struct MONITORINFO
		{
			/// <summary>
			/// 
			/// </summary>
			/// <param name="flags"></param>
			public MONITORINFO(uint flags)
			{
				Size = Marshal.SizeOf(typeof(MONITORINFOEX));
				Monitor = new RECT();
				WorkArea = new RECT();
				Flags = flags;
			}

			/// <summary>
			/// The size, in bytes, of the structure. Set this member to sizeof(MONITORINFOEX) (72) before calling the GetMonitorInfo function. 
			/// Doing so lets the function determine the type of structure you are passing to it.
			/// </summary>
			public int Size;

			/// <summary>
			/// A RECT structure that specifies the display monitor rectangle, expressed in virtual-screen coordinates. 
			/// Note that if the monitor is not the primary display monitor, some of the rectangle's coordinates may be negative values.
			/// </summary>
			public RECT Monitor;

			/// <summary>
			/// A RECT structure that specifies the work area rectangle of the display monitor that can be used by applications, 
			/// expressed in virtual-screen coordinates. Windows uses this rectangle to maximize an application on the monitor. 
			/// The rest of the area in rcMonitor contains system windows such as the task bar and side bars. 
			/// Note that if the monitor is not the primary display monitor, some of the rectangle's coordinates may be negative values.
			/// </summary>
			public RECT WorkArea;

			/// <summary>
			/// The attributes of the display monitor.
			/// 
			/// This member can be the following value:
			///   1 : MONITORINFOF_PRIMARY
			/// </summary>
			public uint Flags;
		}

		/// <summary>
		/// The MONITORINFOEX structure contains information about a display monitor.
		/// The GetMonitorInfo function stores information into a MONITORINFOEX structure or a MONITORINFO structure.
		/// The MONITORINFOEX structure is a superset of the MONITORINFO structure. The MONITORINFOEX structure adds a string member to contain a name 
		/// for the display monitor.
		/// </summary>
		[StructLayout(LayoutKind.Sequential)]
		private struct MONITORINFOEX
		{
			/// <summary>
			/// 
			/// </summary>
			/// <param name="deviceName"></param>
			public MONITORINFOEX(string deviceName)
			{
				_Size = Marshal.SizeOf(typeof(MONITORINFOEX));
				Monitor = new RECT();
				WorkArea = new RECT();
				_Flags = 0;
				_DeviceName = deviceName ?? string.Empty;
			}

			/// <summary>
			/// The size, in bytes, of the structure. Set this member to sizeof(MONITORINFOEX) (72) before calling the GetMonitorInfo function. 
			/// Doing so lets the function determine the type of structure you are passing to it.
			/// </summary>
			private int _Size;

			/// <summary>
			/// A RECT structure that specifies the display monitor rectangle, expressed in virtual-screen coordinates. 
			/// Note that if the monitor is not the primary display monitor, some of the rectangle's coordinates may be negative values.
			/// </summary>
			public RECT Monitor;

			/// <summary>
			/// A RECT structure that specifies the work area rectangle of the display monitor that can be used by applications, 
			/// expressed in virtual-screen coordinates. Windows uses this rectangle to maximize an application on the monitor. 
			/// The rest of the area in rcMonitor contains system windows such as the task bar and side bars. 
			/// Note that if the monitor is not the primary display monitor, some of the rectangle's coordinates may be negative values.
			/// </summary>
			public RECT WorkArea;

			/// <summary>
			/// The attributes of the display monitor.
			/// 
			/// This member can be the following value:
			///   1 : MONITORINFOF_PRIMARY
			/// </summary>
			private uint _Flags;

			// size of a device name string
			private const int CCHDEVICENAME = 32;

			/// <summary>
			/// A string that specifies the device name of the monitor being used. Most applications have no use for a display monitor name, 
			/// and so can save some bytes by using a MONITORINFO structure.
			/// </summary>
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHDEVICENAME)]
			private string _DeviceName;
		}

		// ReSharper restore FieldCanBeMadeReadOnly.Local
		// ReSharper restore PrivateFieldCanBeConvertedToLocalVariable

		/// <summary>
		/// Windows Messages
		/// Defined in winuser.h from Windows SDK v6.1
		/// Documentation pulled from MSDN.
		/// http://www.pinvoke.net/default.aspx/Enums.WindowsMessages
		/// </summary>
		private enum WM : uint
		{
			/// <summary>
			/// The WM_NULL message performs no operation. An application sends the WM_NULL message if it wants to post a message that the recipient window will ignore.
			/// </summary>
			NULL = 0x0000,
			/// <summary>
			/// The WM_CREATE message is sent when an application requests that a window be created by calling the CreateWindowEx or CreateWindow function. (The message is sent before the function returns.) The window procedure of the new window receives this message after the window is created, but before the window becomes visible.
			/// </summary>
			CREATE = 0x0001,
			/// <summary>
			/// The WM_DESTROY message is sent when a window is being destroyed. It is sent to the window procedure of the window being destroyed after the window is removed from the screen. 
			/// This message is sent first to the window being destroyed and then to the child windows (if any) as they are destroyed. During the processing of the message, it can be assumed that all child windows still exist.
			/// /// </summary>
			DESTROY = 0x0002,
			/// <summary>
			/// The WM_MOVE message is sent after a window has been moved. 
			/// </summary>
			MOVE = 0x0003,
			/// <summary>
			/// The WM_SIZE message is sent to a window after its size has changed.
			/// </summary>
			SIZE = 0x0005,
			/// <summary>
			/// The WM_ACTIVATE message is sent to both the window being activated and the window being deactivated. If the windows use the same input queue, the message is sent synchronously, first to the window procedure of the top-level window being deactivated, then to the window procedure of the top-level window being activated. If the windows use different input queues, the message is sent asynchronously, so the window is activated immediately. 
			/// </summary>
			ACTIVATE = 0x0006,
			/// <summary>
			/// The WM_SETFOCUS message is sent to a window after it has gained the keyboard focus. 
			/// </summary>
			SETFOCUS = 0x0007,
			/// <summary>
			/// The WM_KILLFOCUS message is sent to a window immediately before it loses the keyboard focus. 
			/// </summary>
			KILLFOCUS = 0x0008,
			/// <summary>
			/// The WM_ENABLE message is sent when an application changes the enabled state of a window. It is sent to the window whose enabled state is changing. This message is sent before the EnableWindow function returns, but after the enabled state (WS_DISABLED style bit) of the window has changed. 
			/// </summary>
			ENABLE = 0x000A,
			/// <summary>
			/// An application sends the WM_SETREDRAW message to a window to allow changes in that window to be redrawn or to prevent changes in that window from being redrawn. 
			/// </summary>
			SETREDRAW = 0x000B,
			/// <summary>
			/// An application sends a WM_SETTEXT message to set the text of a window. 
			/// </summary>
			SETTEXT = 0x000C,
			/// <summary>
			/// An application sends a WM_GETTEXT message to copy the text that corresponds to a window into a buffer provided by the caller. 
			/// </summary>
			GETTEXT = 0x000D,
			/// <summary>
			/// An application sends a WM_GETTEXTLENGTH message to determine the length, in characters, of the text associated with a window. 
			/// </summary>
			GETTEXTLENGTH = 0x000E,
			/// <summary>
			/// The WM_PAINT message is sent when the system or another application makes a request to paint a portion of an application's window. The message is sent when the UpdateWindow or RedrawWindow function is called, or by the DispatchMessage function when the application obtains a WM_PAINT message by using the GetMessage or PeekMessage function. 
			/// </summary>
			PAINT = 0x000F,
			/// <summary>
			/// The WM_CLOSE message is sent as a signal that a window or an application should terminate.
			/// </summary>
			CLOSE = 0x0010,
			/// <summary>
			/// The WM_QUERYENDSESSION message is sent when the user chooses to end the session or when an application calls one of the system shutdown functions. If any application returns zero, the session is not ended. The system stops sending WM_QUERYENDSESSION messages as soon as one application returns zero.
			/// After processing this message, the system sends the WM_ENDSESSION message with the wParam parameter set to the results of the WM_QUERYENDSESSION message.
			/// </summary>
			QUERYENDSESSION = 0x0011,
			/// <summary>
			/// The WM_QUERYOPEN message is sent to an icon when the user requests that the window be restored to its previous size and position.
			/// </summary>
			QUERYOPEN = 0x0013,
			/// <summary>
			/// The WM_ENDSESSION message is sent to an application after the system processes the results of the WM_QUERYENDSESSION message. The WM_ENDSESSION message informs the application whether the session is ending.
			/// </summary>
			ENDSESSION = 0x0016,
			/// <summary>
			/// The WM_QUIT message indicates a request to terminate an application and is generated when the application calls the PostQuitMessage function. It causes the GetMessage function to return zero.
			/// </summary>
			QUIT = 0x0012,

			/// <summary>
			/// A window receives this message when the user chooses a command from the Window menu, clicks the maximize button, minimize button, restore button, close button, or moves the form. You can stop the form from moving by filtering this out.
			/// </summary>
			SYSCOMMAND = 0x0112,

			/// <summary>
			/// The WM_KEYDOWN message is posted to the window with the keyboard focus when a nonsystem key is pressed. A nonsystem key is a key that is pressed when the ALT key is not pressed. 
			/// </summary>
			KEYDOWN = 0x0100,
			/// <summary>
			/// The WM_KEYUP message is posted to the window with the keyboard focus when a nonsystem key is released. A nonsystem key is a key that is pressed when the ALT key is not pressed, or a keyboard key that is pressed when a window has the keyboard focus. 
			/// </summary>
			KEYUP = 0x0101,

			/// <summary>
			/// The WM_MOUSEMOVE message is posted to a window when the cursor moves. If the mouse is not captured, the message is posted to the window that contains the cursor. Otherwise, the message is posted to the window that has captured the mouse.
			/// </summary>
			MOUSEMOVE = 0x0200,
			/// <summary>
			/// The WM_LBUTTONDOWN message is posted when the user presses the left mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
			/// </summary>
			LBUTTONDOWN = 0x0201,
			/// <summary>
			/// The WM_LBUTTONUP message is posted when the user releases the left mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
			/// </summary>
			LBUTTONUP = 0x0202,
			/// <summary>
			/// The WM_LBUTTONDBLCLK message is posted when the user double-clicks the left mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
			/// </summary>
			LBUTTONDBLCLK = 0x0203,
			/// <summary>
			/// The WM_RBUTTONDOWN message is posted when the user presses the right mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
			/// </summary>
			RBUTTONDOWN = 0x0204,
			/// <summary>
			/// The WM_RBUTTONUP message is posted when the user releases the right mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
			/// </summary>
			RBUTTONUP = 0x0205,
			/// <summary>
			/// The WM_RBUTTONDBLCLK message is posted when the user double-clicks the right mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
			/// </summary>
			RBUTTONDBLCLK = 0x0206,
			/// <summary>
			/// The WM_MBUTTONDOWN message is posted when the user presses the middle mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
			/// </summary>
			MBUTTONDOWN = 0x0207,
			/// <summary>
			/// The WM_MBUTTONUP message is posted when the user releases the middle mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
			/// </summary>
			MBUTTONUP = 0x0208,
			/// <summary>
			/// The WM_MBUTTONDBLCLK message is posted when the user double-clicks the middle mouse button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
			/// </summary>
			MBUTTONDBLCLK = 0x0209,
			/// <summary>
			/// The WM_MOUSEWHEEL message is sent to the focus window when the mouse wheel is rotated. The DefWindowProc function propagates the message to the window's parent. There should be no internal forwarding of the message, since DefWindowProc propagates it up the parent chain until it finds a window that processes it.
			/// </summary>
			MOUSEWHEEL = 0x020A,
			/// <summary>
			/// The WM_XBUTTONDOWN message is posted when the user presses the first or second X button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse. 
			/// </summary>
			XBUTTONDOWN = 0x020B,
			/// <summary>
			/// The WM_XBUTTONUP message is posted when the user releases the first or second X button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
			/// </summary>
			XBUTTONUP = 0x020C,
			/// <summary>
			/// The WM_XBUTTONDBLCLK message is posted when the user double-clicks the first or second X button while the cursor is in the client area of a window. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.
			/// </summary>
			XBUTTONDBLCLK = 0x020D,
			/// <summary>
			/// The WM_MOUSEHWHEEL message is sent to the focus window when the mouse's horizontal scroll wheel is tilted or rotated. The DefWindowProc function propagates the message to the window's parent. There should be no internal forwarding of the message, since DefWindowProc propagates it up the parent chain until it finds a window that processes it.
			/// </summary>
			MOUSEHWHEEL = 0x020E,
			/// <summary>
			/// The WM_MOUSEHOVER message is posted to a window when the cursor hovers over the client area of the window for the period of time specified in a prior call to TrackMouseEvent.
			/// </summary>
			MOUSEHOVER = 0x02A1,
			/// <summary>
			/// The WM_MOUSELEAVE message is posted to a window when the cursor leaves the client area of the window specified in a prior call to TrackMouseEvent.
			/// </summary>
			MOUSELEAVE = 0x02A3,

			/// <summary>
			/// The WM_USER constant is used by applications to help define private messages for use by private window classes, usually of the form WM_USER+X, where X is an integer value. 
			/// </summary>
			USER = 0x0400,

		}

		/// <summary>
		/// Enumeration of the different ways of showing a window using ShowWindow.
		/// </summary>
		private enum WindowShowStyle
		{
			/// <summary>Hides the window and activates another window.</summary>
			/// <remarks>See SW_HIDE</remarks>
			Hide = 0,
			/// <summary>Activates and displays a window. If the window is minimized 
			/// or maximized, the system restores it to its original size and 
			/// position. An application should specify this flag when displaying 
			/// the window for the first time.</summary>
			/// <remarks>See SW_SHOWNORMAL</remarks>
			ShowNormal = 1,
			/// <summary>Activates the window and displays it as a minimized window.</summary>
			/// <remarks>See SW_SHOWMINIMIZED</remarks>
			ShowMinimized = 2,
			/// <summary>Activates the window and displays it as a maximized window.</summary>
			/// <remarks>See SW_SHOWMAXIMIZED</remarks>
			ShowMaximized = 3,
			/// <summary>Maximizes the specified window.</summary>
			/// <remarks>See SW_MAXIMIZE</remarks>
			Maximize = 3,
			/// <summary>Displays a window in its most recent size and position. 
			/// This value is similar to "ShowNormal", except the window is not 
			/// actived.</summary>
			/// <remarks>See SW_SHOWNOACTIVATE</remarks>
			ShowNormalNoActivate = 4,
			/// <summary>Activates the window and displays it in its current size 
			/// and position.</summary>
			/// <remarks>See SW_SHOW</remarks>
			Show = 5,
			/// <summary>Minimizes the specified window and activates the next 
			/// top-level window in the Z order.</summary>
			/// <remarks>See SW_MINIMIZE</remarks>
			Minimize = 6,
			/// <summary>Displays the window as a minimized window. This value is 
			/// similar to "ShowMinimized", except the window is not activated.</summary>
			/// <remarks>See SW_SHOWMINNOACTIVE</remarks>
			ShowMinNoActivate = 7,
			/// <summary>Displays the window in its current size and position. This 
			/// value is similar to "Show", except the window is not activated.</summary>
			/// <remarks>See SW_SHOWNA</remarks>
			ShowNoActivate = 8,
			/// <summary>Activates and displays the window. If the window is 
			/// minimized or maximized, the system restores it to its original size 
			/// and position. An application should specify this flag when restoring 
			/// a minimized window.</summary>
			/// <remarks>See SW_RESTORE</remarks>
			Restore = 9,
			/// <summary>Sets the show state based on the SW_ value specified in the 
			/// STARTUPINFO structure passed to the CreateProcess function by the 
			/// program that started the application.</summary>
			/// <remarks>See SW_SHOWDEFAULT</remarks>
			ShowDefault = 10,
			/// <summary>Windows 2000/XP: Minimizes a window, even if the thread 
			/// that owns the window is hung. This flag should only be used when 
			/// minimizing windows from a different thread.</summary>
			/// <remarks>See SW_FORCEMINIMIZE</remarks>
			ForceMinimized = 11
		}

		/// <summary>
		/// http://www.pinvoke.net/default.aspx/Enums/RedrawWindowFlags.html
		/// </summary>
		[Flags()]
		private enum RedrawWindowFlags : uint
		{
			/// <summary>
			/// Invalidates the rectangle or region that you specify in lprcUpdate or hrgnUpdate.
			/// You can set only one of these parameters to a non-NULL value. If both are NULL, RDW_INVALIDATE invalidates the entire window.
			/// </summary>
			Invalidate = 0x1,

			/// <summary>
			/// Causes the OS to post a WM_PAINT message to the window regardless of whether a portion of the window is invalid.
			/// </summary>
			InternalPaint = 0x2,

			/// <summary>
			/// Causes the window to receive a WM_ERASEBKGND message when the window is repainted.
			/// Specify this value in combination with the RDW_INVALIDATE value; otherwise, RDW_ERASE has no effect.
			/// </summary>
			Erase = 0x4,

			/// <summary>
			/// Validates the rectangle or region that you specify in lprcUpdate or hrgnUpdate.
			/// You can set only one of these parameters to a non-NULL value. If both are NULL, RDW_VALIDATE validates the entire window.
			/// This value does not affect internal WM_PAINT messages.
			/// </summary>
			Validate = 0x8,

			NoInternalPaint = 0x10,

			/// <summary>
			/// Suppresses any pending WM_ERASEBKGND messages.
			/// </summary>
			NoErase = 0x20,

			/// <summary>
			/// Excludes child windows, if any, from the repainting operation.
			/// </summary>
			NoChildren = 0x40,

			/// <summary>
			/// Includes child windows, if any, in the repainting operation.
			/// </summary>
			AllChildren = 0x80,

			/// <summary>
			/// Causes the affected windows, which you specify by setting the RDW_ALLCHILDREN and RDW_NOCHILDREN values,
			/// to receive WM_ERASEBKGND and WM_PAINT messages before the RedrawWindow returns, if necessary.
			/// </summary>
			UpdateNow = 0x100,

			/// <summary>
			/// Causes the affected windows, which you specify by setting the RDW_ALLCHILDREN and RDW_NOCHILDREN values,
			/// to receive WM_ERASEBKGND messages before RedrawWindow returns, if necessary. The affected windows receive
			/// WM_PAINT messages at the ordinary time.
			/// </summary>
			EraseNow = 0x200,

			Frame = 0x400,

			NoFrame = 0x800
		}

		/// <summary>
		/// Flags used with the Windows API (User32.dll):GetSystemMetrics(SystemMetric smIndex)
		/// 
		/// This Enum and declaration signature was written by Gabriel T. Sharp
		/// ai_productions@verizon.net or osirisgothra@hotmail.com
		/// Obtained on pinvoke.net, please contribute your code to support the wiki!
		/// </summary>
		private enum SystemMetric
		{
			/// <summary>
			/// The flags that specify how the system arranged minimized windows. For more information, see the Remarks section in this topic.
			/// </summary>
			Arrange = 56,

			/// <summary>
			/// The value that specifies how the system is started: 
			/// 0 Normal boot
			/// 1 Fail-safe boot
			/// 2 Fail-safe with network boot
			/// A fail-safe boot (also called SafeBoot, Safe Mode, or Clean Boot) bypasses the user startup files.
			/// </summary>
			CleanBoot = 67,

			/// <summary>
			/// The number of display monitors on a desktop. For more information, see the Remarks section in this topic.
			/// </summary>
			CMonitors = 80,

			/// <summary>
			/// The number of buttons on a mouse, or zero if no mouse is installed.
			/// </summary>
			CMouseButtons = 43,

			/// <summary>
			/// The width of a window border, in pixels. This is equivalent to the SM_CXEDGE value for windows with the 3-D look.
			/// </summary>
			CXBorder = 5,

			/// <summary>
			/// The width of a cursor, in pixels. The system cannot create cursors of other sizes.
			/// </summary>
			CXCursor = 13,

			/// <summary>
			/// This value is the same as SM_CXFIXEDFRAME.
			/// </summary>
			CXDlgFrame = 7,

			/// <summary>
			/// The width of the rectangle around the location of a first click in a double-click sequence, in pixels. ,
			/// The second click must occur within the rectangle that is defined by SM_CXDOUBLECLK and SM_CYDOUBLECLK for the system
			/// to consider the two clicks a double-click. The two clicks must also occur within a specified time.
			/// To set the width of the double-click rectangle, call SystemParametersInfo with SPI_SETDOUBLECLKWIDTH.
			/// </summary>
			CXDoubleClk = 36,

			/// <summary>
			/// The number of pixels on either side of a mouse-down point that the mouse pointer can move before a drag operation begins. 
			/// This allows the user to click and release the mouse button easily without unintentionally starting a drag operation. 
			/// If this value is negative, it is subtracted from the left of the mouse-down point and added to the right of it.
			/// </summary>
			CxDrag = 68,

			/// <summary>
			/// The width of a 3-D border, in pixels. This metric is the 3-D counterpart of SM_CXBORDER.
			/// </summary>
			CXEdge = 45,

			/// <summary>
			/// The thickness of the frame around the perimeter of a window that has a caption but is not sizable, in pixels.
			/// SM_CXFIXEDFRAME is the height of the horizontal border, and SM_CYFIXEDFRAME is the width of the vertical border.
			/// This value is the same as SM_CXDLGFRAME.
			/// </summary>
			CXFixedFrame = 7,

			/// <summary>
			/// The width of the left and right edges of the focus rectangle that the DrawFocusRectdraws. 
			/// This value is in pixels. 
			/// Windows 2000:  This value is not supported.
			/// </summary>
			CXForcusBorder = 83,

			/// <summary>
			/// This value is the same as SM_CXSIZEFRAME.
			/// </summary>
			CXFrame = 32,

			/// <summary>
			/// The width of the client area for a full-screen window on the primary display monitor, in pixels. 
			/// To get the coordinates of the portion of the screen that is not obscured by the system taskbar or by application desktop toolbars, 
			/// call the SystemParametersInfofunction with the SPI_GETWORKAREA value.
			/// </summary>
			CXFullscreen = 16,

			/// <summary>
			/// The width of the arrow bitmap on a horizontal scroll bar, in pixels.
			/// </summary>
			CXHscroll = 21,

			/// <summary>
			/// The width of the thumb box in a horizontal scroll bar, in pixels.
			/// </summary>
			CXHThunb = 10,

			/// <summary>
			/// The default width of an icon, in pixels. The LoadIcon function can load only icons with the dimensions 
			/// that SM_CXICON and SM_CYICON specifies.
			/// </summary>
			CXIcon = 11,

			/// <summary>
			/// The width of a grid cell for items in large icon view, in pixels. Each item fits into a rectangle of size 
			/// SM_CXICONSPACING by SM_CYICONSPACING when arranged. This value is always greater than or equal to SM_CXICON.
			/// </summary>
			CXIconSpacing = 38,

			/// <summary>
			/// The default width, in pixels, of a maximized top-level window on the primary display monitor.
			/// </summary>
			CXMaximized = 61,

			/// <summary>
			/// The default maximum width of a window that has a caption and sizing borders, in pixels. 
			/// This metric refers to the entire desktop. The user cannot drag the window frame to a size larger than these dimensions. 
			/// A window can override this value by processing the WM_GETMINMAXINFO message.
			/// </summary>
			CXMaxTrack = 59,

			/// <summary>
			/// The width of the default menu check-mark bitmap, in pixels.
			/// </summary>
			CXMenuCheck = 71,

			/// <summary>
			/// The width of menu bar buttons, such as the child window close button that is used in the multiple document interface, in pixels.
			/// </summary>
			CXMenuSize = 54,

			/// <summary>
			/// The minimum width of a window, in pixels.
			/// </summary>
			CXMin = 28,

			/// <summary>
			/// The width of a minimized window, in pixels.
			/// </summary>
			CXMinimized = 57,

			/// <summary>
			/// The width of a grid cell for a minimized window, in pixels. Each minimized window fits into a rectangle this size when arranged. 
			/// This value is always greater than or equal to SM_CXMINIMIZED.
			/// </summary>
			CXMinSpacing = 47,

			/// <summary>
			/// The minimum tracking width of a window, in pixels. The user cannot drag the window frame to a size smaller than these dimensions. 
			/// A window can override this value by processing the WM_GETMINMAXINFO message.
			/// </summary>
			CXMinTrack = 34,

			/// <summary>
			/// The amount of border padding for captioned windows, in pixels. Windows XP/2000:  This value is not supported.
			/// </summary>
			CXPaddedBorder = 92,

			/// <summary>
			/// The width of the screen of the primary display monitor, in pixels. This is the same value obtained by calling 
			/// GetDeviceCaps as follows: GetDeviceCaps( hdcPrimaryMonitor, HORZRES).
			/// </summary>
			CXScreen = 0,

			/// <summary>
			/// The width of a button in a window caption or title bar, in pixels.
			/// </summary>
			CXSize = 30,

			/// <summary>
			/// The thickness of the sizing border around the perimeter of a window that can be resized, in pixels. 
			/// SM_CXSIZEFRAME is the width of the horizontal border, and SM_CYSIZEFRAME is the height of the vertical border. 
			/// This value is the same as SM_CXFRAME.
			/// </summary>
			CXSizeFrame = 32,

			/// <summary>
			/// The recommended width of a small icon, in pixels. Small icons typically appear in window captions and in small icon view.
			/// </summary>
			CXSmallIcon = 49,

			/// <summary>
			/// The width of small caption buttons, in pixels.
			/// </summary>
			CXSmallSize = 52,

			/// <summary>
			/// The width of the virtual screen, in pixels. The virtual screen is the bounding rectangle of all display monitors. 
			/// The SM_XVIRTUALSCREEN metric is the coordinates for the left side of the virtual screen.
			/// </summary>
			CXVirtualScreen = 78,

			/// <summary>
			/// The width of a vertical scroll bar, in pixels.
			/// </summary>
			CXVScroll = 2,

			/// <summary>
			/// The height of a window border, in pixels. This is equivalent to the SM_CYEDGE value for windows with the 3-D look.
			/// </summary>
			CYBorder = 6,

			/// <summary>
			/// The height of a caption area, in pixels.
			/// </summary>
			CYCaption = 4,

			/// <summary>
			/// The height of a cursor, in pixels. The system cannot create cursors of other sizes.
			/// </summary>
			CYCursor = 14,

			/// <summary>
			/// This value is the same as SM_CYFIXEDFRAME.
			/// </summary>
			CYDlgFrame = 8,

			/// <summary>
			/// The height of the rectangle around the location of a first click in a double-click sequence, in pixels. 
			/// The second click must occur within the rectangle defined by SM_CXDOUBLECLK and SM_CYDOUBLECLK for the system to consider 
			/// the two clicks a double-click. The two clicks must also occur within a specified time. To set the height of the double-click 
			/// rectangle, call SystemParametersInfo with SPI_SETDOUBLECLKHEIGHT.
			/// </summary>
			CYDoubleClk = 37,

			/// <summary>
			/// The number of pixels above and below a mouse-down point that the mouse pointer can move before a drag operation begins. 
			/// This allows the user to click and release the mouse button easily without unintentionally starting a drag operation. 
			/// If this value is negative, it is subtracted from above the mouse-down point and added below it.
			/// </summary>
			CYDrag = 69,

			/// <summary>
			/// The height of a 3-D border, in pixels. This is the 3-D counterpart of SM_CYBORDER.
			/// </summary>
			CYEdge = 46,

			/// <summary>
			/// The thickness of the frame around the perimeter of a window that has a caption but is not sizable, in pixels. 
			/// SM_CXFIXEDFRAME is the height of the horizontal border, and SM_CYFIXEDFRAME is the width of the vertical border. 
			/// This value is the same as SM_CYDLGFRAME.
			/// </summary>
			CYFixedFrame = 8,

			/// <summary>
			/// The height of the top and bottom edges of the focus rectangle drawn byDrawFocusRect. 
			/// This value is in pixels. 
			/// Windows 2000:  This value is not supported.
			/// </summary>
			CYFocusBorder = 84,

			/// <summary>
			/// This value is the same as SM_CYSIZEFRAME.
			/// </summary>
			CYFrame = 33,

			/// <summary>
			/// The height of the client area for a full-screen window on the primary display monitor, in pixels. 
			/// To get the coordinates of the portion of the screen not obscured by the system taskbar or by application desktop toolbars,
			/// call the SystemParametersInfo function with the SPI_GETWORKAREA value.
			/// </summary>
			CYFullscreen = 17,

			/// <summary>
			/// The height of a horizontal scroll bar, in pixels.
			/// </summary>
			CYHScroll = 3,

			/// <summary>
			/// The default height of an icon, in pixels. The LoadIcon function can load only icons with the dimensions SM_CXICON and SM_CYICON.
			/// </summary>
			CYIcon = 12,

			/// <summary>
			/// The height of a grid cell for items in large icon view, in pixels. Each item fits into a rectangle of size 
			/// SM_CXICONSPACING by SM_CYICONSPACING when arranged. This value is always greater than or equal to SM_CYICON.
			/// </summary>
			CYIconSpacing = 39,

			/// <summary>
			/// For double byte character set versions of the system, this is the height of the Kanji window at the bottom of the screen, in pixels.
			/// </summary>
			CYKanjiWindow = 18,

			/// <summary>
			/// The default height, in pixels, of a maximized top-level window on the primary display monitor.
			/// </summary>
			CYMaximized = 62,

			/// <summary>
			/// The default maximum height of a window that has a caption and sizing borders, in pixels. This metric refers to the entire desktop. 
			/// The user cannot drag the window frame to a size larger than these dimensions. A window can override this value by processing 
			/// the WM_GETMINMAXINFO message.
			/// </summary>
			CYMaxTrack = 60,

			/// <summary>
			/// The height of a single-line menu bar, in pixels.
			/// </summary>
			CYMenu = 15,

			/// <summary>
			/// The height of the default menu check-mark bitmap, in pixels.
			/// </summary>
			CYMenuCheck = 72,

			/// <summary>
			/// The height of menu bar buttons, such as the child window close button that is used in the multiple document interface, in pixels.
			/// </summary>
			CYMenuSize = 55,

			/// <summary>
			/// The minimum height of a window, in pixels.
			/// </summary>
			CYMin = 29,

			/// <summary>
			/// The height of a minimized window, in pixels.
			/// </summary>
			CYMinimized = 58,

			/// <summary>
			/// The height of a grid cell for a minimized window, in pixels. Each minimized window fits into a rectangle this size when arranged. 
			/// This value is always greater than or equal to SM_CYMINIMIZED.
			/// </summary>
			CYMinSpacing = 48,

			/// <summary>
			/// The minimum tracking height of a window, in pixels. The user cannot drag the window frame to a size smaller than these dimensions. 
			/// A window can override this value by processing the WM_GETMINMAXINFO message.
			/// </summary>
			CYMinTrack = 35,

			/// <summary>
			/// The height of the screen of the primary display monitor, in pixels. This is the same value obtained by calling 
			/// GetDeviceCaps as follows: GetDeviceCaps( hdcPrimaryMonitor, VERTRES).
			/// </summary>
			CYScreen = 1,

			/// <summary>
			/// The height of a button in a window caption or title bar, in pixels.
			/// </summary>
			CYSize = 31,

			/// <summary>
			/// The thickness of the sizing border around the perimeter of a window that can be resized, in pixels. 
			/// SM_CXSIZEFRAME is the width of the horizontal border, and SM_CYSIZEFRAME is the height of the vertical border. 
			/// This value is the same as SM_CYFRAME.
			/// </summary>
			CYSizeFrame = 33,

			/// <summary>
			/// The height of a small caption, in pixels.
			/// </summary>
			CYSmallCaption = 51,

			/// <summary>
			/// The recommended height of a small icon, in pixels. Small icons typically appear in window captions and in small icon view.
			/// </summary>
			CYSmallIcon = 50,

			/// <summary>
			/// The height of small caption buttons, in pixels.
			/// </summary>
			CYSmallSize = 53,

			/// <summary>
			/// The height of the virtual screen, in pixels. The virtual screen is the bounding rectangle of all display monitors. 
			/// The SM_YVIRTUALSCREEN metric is the coordinates for the top of the virtual screen.
			/// </summary>
			CYVirtualScreen = 79,

			/// <summary>
			/// The height of the arrow bitmap on a vertical scroll bar, in pixels.
			/// </summary>
			CYVScroll = 20,

			/// <summary>
			/// The height of the thumb box in a vertical scroll bar, in pixels.
			/// </summary>
			CYVThumb = 9,

			/// <summary>
			/// Nonzero if User32.dll supports DBCS; otherwise, 0.
			/// </summary>
			DBCSEnabled = 42,

			/// <summary>
			/// Nonzero if the debug version of User.exe is installed; otherwise, 0.
			/// </summary>
			Debug = 22,

			/// <summary>
			/// Nonzero if the current operating system is Windows 7 or Windows Server 2008 R2 and the Tablet PC Input 
			/// service is started; otherwise, 0. The return value is a bitmask that specifies the type of digitizer input supported by the device. 
			/// For more information, see Remarks. 
			/// Windows Server 2008, Windows Vista, and Windows XP/2000:  This value is not supported.
			/// </summary>
			Digitizer = 94,

			/// <summary>
			/// Nonzero if Input Method Manager/Input Method Editor features are enabled; otherwise, 0. 
			/// SM_IMMENABLED indicates whether the system is ready to use a Unicode-based IME on a Unicode application. 
			/// To ensure that a language-dependent IME works, check SM_DBCSENABLED and the system ANSI code page.
			/// Otherwise the ANSI-to-Unicode conversion may not be performed correctly, or some components like fonts
			/// or registry settings may not be present.
			/// </summary>
			IMMEnable = 82,

			/// <summary>
			/// Nonzero if there are digitizers in the system; otherwise, 0. SM_MAXIMUMTOUCHES returns the aggregate maximum of the 
			/// maximum number of contacts supported by every digitizer in the system. If the system has only single-touch digitizers, 
			/// the return value is 1. If the system has multi-touch digitizers, the return value is the number of simultaneous contacts 
			/// the hardware can provide. Windows Server 2008, Windows Vista, and Windows XP/2000:  This value is not supported.
			/// </summary>
			MaximumTouches = 95,

			/// <summary>
			/// Nonzero if the current operating system is the Windows XP, Media Center Edition, 0 if not.
			/// </summary>
			MediaCenter = 87,

			/// <summary>
			/// Nonzero if drop-down menus are right-aligned with the corresponding menu-bar item; 0 if the menus are left-aligned.
			/// </summary>
			MenuDropAlignment = 40,

			/// <summary>
			/// Nonzero if the system is enabled for Hebrew and Arabic languages, 0 if not.
			/// </summary>
			MidEastEnabeld = 74,

			/// <summary>
			/// Nonzero if a mouse is installed; otherwise, 0. This value is rarely zero, because of support for virtual mice and because 
			/// some systems detect the presence of the port instead of the presence of a mouse.
			/// </summary>
			MousePresent = 19,

			/// <summary>
			/// Nonzero if a mouse with a horizontal scroll wheel is installed; otherwise 0.
			/// </summary>
			MouseHorizontalWheelPreset = 91,

			/// <summary>
			/// Nonzero if a mouse with a vertical scroll wheel is installed; otherwise 0.
			/// </summary>
			MouseWheelPresent = 75,

			/// <summary>
			/// The least significant bit is set if a network is present; otherwise, it is cleared. The other bits are reserved for future use.
			/// </summary>
			Network = 63,

			/// <summary>
			/// Nonzero if the Microsoft Windows for Pen computing extensions are installed; zero otherwise.
			/// </summary>
			PenWindows = 41,

			/// <summary>
			/// This system metric is used in a Terminal Services environment to determine if the current Terminal Server session is 
			/// being remotely controlled. Its value is nonzero if the current session is remotely controlled; otherwise, 0. 
			/// You can use terminal services management tools such as Terminal Services Manager (tsadmin.msc) and shadow.exe to 
			/// control a remote session. When a session is being remotely controlled, another user can view the contents of that session 
			/// and potentially interact with it.
			/// </summary>
			RemoteControl = 0x2001,

			/// <summary>
			/// This system metric is used in a Terminal Services environment. If the calling process is associated with a Terminal Services 
			/// client session, the return value is nonzero. If the calling process is associated with the Terminal Services console session, 
			/// the return value is 0. 
			/// Windows Server 2003 and Windows XP:  The console session is not necessarily the physical console. 
			/// For more information, seeWTSGetActiveConsoleSessionId.
			/// </summary>
			RemoteSession = 0x1000,

			/// <summary>
			/// Nonzero if all the display monitors have the same color format, otherwise, 0. Two displays can have the same bit depth, 
			/// but different color formats. For example, the red, green, and blue pixels can be encoded with different numbers of bits, 
			/// or those bits can be located in different places in a pixel color value.
			/// </summary>
			SameDisplayFormat = 81,

			/// <summary>
			/// This system metric should be ignored; it always returns 0.
			/// </summary>
			Secure = 44,

			/// <summary>
			/// The build number if the system is Windows Server 2003 R2; otherwise, 0.
			/// </summary>
			ServerR2 = 89,

			/// <summary>
			/// Nonzero if the user requires an application to present information visually in situations where it would otherwise present 
			/// the information only in audible form; otherwise, 0.
			/// </summary>
			ShowSound = 70,

			/// <summary>
			/// Nonzero if the current session is shutting down; otherwise, 0. Windows 2000:  This value is not supported.
			/// </summary>
			ShuttingDown = 0x2000,

			/// <summary>
			/// Nonzero if the computer has a low-end (slow) processor; otherwise, 0.
			/// </summary>
			SlowMachine = 73,

			/// <summary>
			/// Nonzero if the current operating system is Windows 7 Starter Edition, Windows Vista Starter, or Windows XP Starter Edition; otherwise, 0.
			/// </summary>
			Starter = 88,

			/// <summary>
			/// Nonzero if the meanings of the left and right mouse buttons are swapped; otherwise, 0.
			/// </summary>
			SwapButton = 23,

			/// <summary>
			/// Nonzero if the current operating system is the Windows XP Tablet PC edition or if the current operating system is Windows Vista
			/// or Windows 7 and the Tablet PC Input service is started; otherwise, 0. The SM_DIGITIZER setting indicates the type of digitizer 
			/// input supported by a device running Windows 7 or Windows Server 2008 R2. For more information, see Remarks.
			/// </summary>
			TabledPC = 86,

			/// <summary>
			/// The coordinates for the left side of the virtual screen. The virtual screen is the bounding rectangle of all display monitors. 
			/// The SM_CXVIRTUALSCREEN metric is the width of the virtual screen.
			/// </summary>
			XVirtualScreen = 76,

			/// <summary>
			/// The coordinates for the top of the virtual screen. The virtual screen is the bounding rectangle of all display monitors. 
			/// The SM_CYVIRTUALSCREEN metric is the height of the virtual screen.
			/// </summary>
			YVirtualScreen = 77,
		}

		[Flags]
		private enum SetWindowPosFlags : uint
		{
			// ReSharper disable InconsistentNaming

			/// <summary>
			///     If the calling thread and the thread that owns the window are attached to different input queues, the system posts the request to the thread that owns the window. This prevents the calling thread from blocking its execution while other threads process the request.
			/// </summary>
			SWP_ASYNCWINDOWPOS = 0x4000,

			/// <summary>
			///     Prevents generation of the WM_SYNCPAINT message.
			/// </summary>
			SWP_DEFERERASE = 0x2000,

			/// <summary>
			///     Draws a frame (defined in the window's class description) around the window.
			/// </summary>
			SWP_DRAWFRAME = 0x0020,

			/// <summary>
			///     Applies new frame styles set using the SetWindowLong function. Sends a WM_NCCALCSIZE message to the window, even if the window's size is not being changed. If this flag is not specified, WM_NCCALCSIZE is sent only when the window's size is being changed.
			/// </summary>
			SWP_FRAMECHANGED = 0x0020,

			/// <summary>
			///     Hides the window.
			/// </summary>
			SWP_HIDEWINDOW = 0x0080,

			/// <summary>
			///     Does not activate the window. If this flag is not set, the window is activated and moved to the top of either the topmost or non-topmost group (depending on the setting of the hWndInsertAfter parameter).
			/// </summary>
			SWP_NOACTIVATE = 0x0010,

			/// <summary>
			///     Discards the entire contents of the client area. If this flag is not specified, the valid contents of the client area are saved and copied back into the client area after the window is sized or repositioned.
			/// </summary>
			SWP_NOCOPYBITS = 0x0100,

			/// <summary>
			///     Retains the current position (ignores X and Y parameters).
			/// </summary>
			SWP_NOMOVE = 0x0002,

			/// <summary>
			///     Does not change the owner window's position in the Z order.
			/// </summary>
			SWP_NOOWNERZORDER = 0x0200,

			/// <summary>
			///     Does not redraw changes. If this flag is set, no repainting of any kind occurs. This applies to the client area, the nonclient area (including the title bar and scroll bars), and any part of the parent window uncovered as a result of the window being moved. When this flag is set, the application must explicitly invalidate or redraw any parts of the window and parent window that need redrawing.
			/// </summary>
			SWP_NOREDRAW = 0x0008,

			/// <summary>
			///     Same as the SWP_NOOWNERZORDER flag.
			/// </summary>
			SWP_NOREPOSITION = 0x0200,

			/// <summary>
			///     Prevents the window from receiving the WM_WINDOWPOSCHANGING message.
			/// </summary>
			SWP_NOSENDCHANGING = 0x0400,

			/// <summary>
			///     Retains the current size (ignores the cx and cy parameters).
			/// </summary>
			SWP_NOSIZE = 0x0001,

			/// <summary>
			///     Retains the current Z order (ignores the hWndInsertAfter parameter).
			/// </summary>
			SWP_NOZORDER = 0x0004,

			/// <summary>
			///     Displays the window.
			/// </summary>
			SWP_SHOWWINDOW = 0x0040,

			/// <summary>
			///     No flags.
			/// </summary>
			SWP_NONE = 0x0000,

			// ReSharper restore InconsistentNaming
		}

		private enum SetWindowLongIndex
		{
			GWL_WNDPROC = -4,
			GWL_HINSTANCE = -6,
			GWL_HWNDPARENT = -8,
			GWL_STYLE = -16,
			GWL_EXSTYLE = -20,
			GWL_USERDATA = -21,
			GWL_ID = -12
		}

		[Flags]
		private enum WindowStyles : uint
		{
			WS_OVERLAPPED = 0x00000000,
			WS_POPUP = 0x80000000,
			WS_CHILD = 0x40000000,
			WS_MINIMIZE = 0x20000000,
			WS_VISIBLE = 0x10000000,
			WS_DISABLED = 0x08000000,
			WS_CLIPSIBLINGS = 0x04000000,
			WS_CLIPCHILDREN = 0x02000000,
			WS_MAXIMIZE = 0x01000000,
			WS_CAPTION = 0x00C00000,     /* WS_BORDER | WS_DLGFRAME  */
			WS_BORDER = 0x00800000,
			WS_DLGFRAME = 0x00400000,
			WS_VSCROLL = 0x00200000,
			WS_HSCROLL = 0x00100000,
			WS_SYSMENU = 0x00080000,
			WS_THICKFRAME = 0x00040000,
			WS_GROUP = 0x00020000,
			WS_TABSTOP = 0x00010000,

			WS_MINIMIZEBOX = 0x00020000,
			WS_MAXIMIZEBOX = 0x00010000,

			WS_TILED = WS_OVERLAPPED,
			WS_ICONIC = WS_MINIMIZE,
			WS_SIZEBOX = WS_THICKFRAME,
			WS_TILEDWINDOW = WS_OVERLAPPEDWINDOW,

			// Common Window Styles

			WS_OVERLAPPEDWINDOW =
				WS_OVERLAPPED |
				WS_CAPTION |
				WS_SYSMENU |
				WS_THICKFRAME |
				WS_MINIMIZEBOX |
				WS_MAXIMIZEBOX,

			WS_POPUPWINDOW =
				WS_POPUP |
				WS_BORDER |
				WS_SYSMENU,

			WS_CHILDWINDOW = WS_CHILD,

			//Extended Window Styles

			WS_EX_DLGMODALFRAME = 0x00000001,
			WS_EX_NOPARENTNOTIFY = 0x00000004,
			WS_EX_TOPMOST = 0x00000008,
			WS_EX_ACCEPTFILES = 0x00000010,
			WS_EX_TRANSPARENT = 0x00000020,

			//#if(WINVER >= 0x0400)
			WS_EX_MDICHILD = 0x00000040,
			WS_EX_TOOLWINDOW = 0x00000080,
			WS_EX_WINDOWEDGE = 0x00000100,
			WS_EX_CLIENTEDGE = 0x00000200,
			WS_EX_CONTEXTHELP = 0x00000400,

			WS_EX_RIGHT = 0x00001000,
			WS_EX_LEFT = 0x00000000,
			WS_EX_RTLREADING = 0x00002000,
			WS_EX_LTRREADING = 0x00000000,
			WS_EX_LEFTSCROLLBAR = 0x00004000,
			WS_EX_RIGHTSCROLLBAR = 0x00000000,

			WS_EX_CONTROLPARENT = 0x00010000,
			WS_EX_STATICEDGE = 0x00020000,
			WS_EX_APPWINDOW = 0x00040000,

			WS_EX_OVERLAPPEDWINDOW = WS_EX_WINDOWEDGE | WS_EX_CLIENTEDGE,
			WS_EX_PALETTEWINDOW = WS_EX_WINDOWEDGE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST,
			//#endif /* WINVER >= 0x0400 */

			//#if(_WIN32_WINNT >= 0x0500)
			WS_EX_LAYERED = 0x00080000,
			//#endif /* _WIN32_WINNT >= 0x0500 */

			//#if(WINVER >= 0x0500)
			WS_EX_NOINHERITLAYOUT = 0x00100000, // Disable inheritence of mirroring by children
			WS_EX_LAYOUTRTL = 0x00400000, // Right to left mirroring
										  //#endif /* WINVER >= 0x0500 */

			//#if(_WIN32_WINNT >= 0x0500)
			WS_EX_COMPOSITED = 0x02000000,
			WS_EX_NOACTIVATE = 0x08000000,
			//#endif /* _WIN32_WINNT >= 0x0500 */
		}

		private static NativeWindowStyle ToNativeWindowStyle(WindowStyles styles)
		{
			NativeWindowStyle windowStyles = NativeWindowStyle.None;

			if ((styles & WindowStyles.WS_BORDER) != 0)
				windowStyles |= NativeWindowStyle.Border;
			if ((styles & WindowStyles.WS_CAPTION) != 0)
				windowStyles |= NativeWindowStyle.Caption;
			if ((styles & WindowStyles.WS_THICKFRAME) != 0)
				windowStyles |= NativeWindowStyle.Resizeable;

			return windowStyles;
		}

		private static WindowStyles FromNativeWindowStyle(NativeWindowStyle styles)
		{
			WindowStyles windowStyles = 0;

			if ((styles & NativeWindowStyle.Border) != 0)
				windowStyles |= WindowStyles.WS_BORDER;
			if ((styles & NativeWindowStyle.Caption) == NativeWindowStyle.Caption)
				windowStyles |= WindowStyles.WS_CAPTION | WindowStyles.WS_BORDER;
			if ((styles & NativeWindowStyle.Resizeable) == NativeWindowStyle.Resizeable)
				windowStyles |= WindowStyles.WS_THICKFRAME;

			return windowStyles;
		}

		/// <summary>
		/// Enumeration for virtual keys.
		/// </summary>
		private enum VirtualKeys : ushort
		{
			/// <summary></summary>
			LeftButton = 0x01,
			/// <summary></summary>
			RightButton = 0x02,
			/// <summary></summary>
			Cancel = 0x03,
			/// <summary></summary>
			MiddleButton = 0x04,
			/// <summary></summary>
			ExtraButton1 = 0x05,
			/// <summary></summary>
			ExtraButton2 = 0x06,
			/// <summary></summary>
			Back = 0x08,
			/// <summary></summary>
			Tab = 0x09,
			/// <summary></summary>
			Clear = 0x0C,
			/// <summary></summary>
			Return = 0x0D,
			/// <summary></summary>
			Shift = 0x10,
			/// <summary></summary>
			Control = 0x11,
			/// <summary></summary>
			Menu = 0x12,
			/// <summary></summary>
			Pause = 0x13,
			/// <summary></summary>
			CapsLock = 0x14,
			/// <summary></summary>
			Kana = 0x15,
			/// <summary></summary>
			Hangeul = 0x15,
			/// <summary></summary>
			Hangul = 0x15,
			/// <summary></summary>
			Junja = 0x17,
			/// <summary></summary>
			Final = 0x18,
			/// <summary></summary>
			Hanja = 0x19,
			/// <summary></summary>
			Kanji = 0x19,
			/// <summary></summary>
			Escape = 0x1B,
			/// <summary></summary>
			Convert = 0x1C,
			/// <summary></summary>
			NonConvert = 0x1D,
			/// <summary></summary>
			Accept = 0x1E,
			/// <summary></summary>
			ModeChange = 0x1F,
			/// <summary></summary>
			Space = 0x20,
			/// <summary></summary>
			Prior = 0x21,
			/// <summary></summary>
			Next = 0x22,
			/// <summary></summary>
			End = 0x23,
			/// <summary></summary>
			Home = 0x24,
			/// <summary></summary>
			Left = 0x25,
			/// <summary></summary>
			Up = 0x26,
			/// <summary></summary>
			Right = 0x27,
			/// <summary></summary>
			Down = 0x28,
			/// <summary></summary>
			Select = 0x29,
			/// <summary></summary>
			Print = 0x2A,
			/// <summary></summary>
			Execute = 0x2B,
			/// <summary></summary>
			Snapshot = 0x2C,
			/// <summary></summary>
			Insert = 0x2D,
			/// <summary></summary>
			Delete = 0x2E,
			/// <summary></summary>
			Help = 0x2F,
			/// <summary></summary>
			N0 = 0x30,
			/// <summary></summary>
			N1 = 0x31,
			/// <summary></summary>
			N2 = 0x32,
			/// <summary></summary>
			N3 = 0x33,
			/// <summary></summary>
			N4 = 0x34,
			/// <summary></summary>
			N5 = 0x35,
			/// <summary></summary>
			N6 = 0x36,
			/// <summary></summary>
			N7 = 0x37,
			/// <summary></summary>
			N8 = 0x38,
			/// <summary></summary>
			N9 = 0x39,
			/// <summary></summary>
			A = 0x41,
			/// <summary></summary>
			B = 0x42,
			/// <summary></summary>
			C = 0x43,
			/// <summary></summary>
			D = 0x44,
			/// <summary></summary>
			E = 0x45,
			/// <summary></summary>
			F = 0x46,
			/// <summary></summary>
			G = 0x47,
			/// <summary></summary>
			H = 0x48,
			/// <summary></summary>
			I = 0x49,
			/// <summary></summary>
			J = 0x4A,
			/// <summary></summary>
			K = 0x4B,
			/// <summary></summary>
			L = 0x4C,
			/// <summary></summary>
			M = 0x4D,
			/// <summary></summary>
			N = 0x4E,
			/// <summary></summary>
			O = 0x4F,
			/// <summary></summary>
			P = 0x50,
			/// <summary></summary>
			Q = 0x51,
			/// <summary></summary>
			R = 0x52,
			/// <summary></summary>
			S = 0x53,
			/// <summary></summary>
			T = 0x54,
			/// <summary></summary>
			U = 0x55,
			/// <summary></summary>
			V = 0x56,
			/// <summary></summary>
			W = 0x57,
			/// <summary></summary>
			X = 0x58,
			/// <summary></summary>
			Y = 0x59,
			/// <summary></summary>
			Z = 0x5A,
			/// <summary></summary>
			LeftWindows = 0x5B,
			/// <summary></summary>
			RightWindows = 0x5C,
			/// <summary></summary>
			Application = 0x5D,
			/// <summary></summary>
			Sleep = 0x5F,
			/// <summary></summary>
			Numpad0 = 0x60,
			/// <summary></summary>
			Numpad1 = 0x61,
			/// <summary></summary>
			Numpad2 = 0x62,
			/// <summary></summary>
			Numpad3 = 0x63,
			/// <summary></summary>
			Numpad4 = 0x64,
			/// <summary></summary>
			Numpad5 = 0x65,
			/// <summary></summary>
			Numpad6 = 0x66,
			/// <summary></summary>
			Numpad7 = 0x67,
			/// <summary></summary>
			Numpad8 = 0x68,
			/// <summary></summary>
			Numpad9 = 0x69,
			/// <summary></summary>
			Multiply = 0x6A,
			/// <summary></summary>
			Add = 0x6B,
			/// <summary></summary>
			Separator = 0x6C,
			/// <summary></summary>
			Subtract = 0x6D,
			/// <summary></summary>
			Decimal = 0x6E,
			/// <summary></summary>
			Divide = 0x6F,
			/// <summary></summary>
			F1 = 0x70,
			/// <summary></summary>
			F2 = 0x71,
			/// <summary></summary>
			F3 = 0x72,
			/// <summary></summary>
			F4 = 0x73,
			/// <summary></summary>
			F5 = 0x74,
			/// <summary></summary>
			F6 = 0x75,
			/// <summary></summary>
			F7 = 0x76,
			/// <summary></summary>
			F8 = 0x77,
			/// <summary></summary>
			F9 = 0x78,
			/// <summary></summary>
			F10 = 0x79,
			/// <summary></summary>
			F11 = 0x7A,
			/// <summary></summary>
			F12 = 0x7B,
			/// <summary></summary>
			F13 = 0x7C,
			/// <summary></summary>
			F14 = 0x7D,
			/// <summary></summary>
			F15 = 0x7E,
			/// <summary></summary>
			F16 = 0x7F,
			/// <summary></summary>
			F17 = 0x80,
			/// <summary></summary>
			F18 = 0x81,
			/// <summary></summary>
			F19 = 0x82,
			/// <summary></summary>
			F20 = 0x83,
			/// <summary></summary>
			F21 = 0x84,
			/// <summary></summary>
			F22 = 0x85,
			/// <summary></summary>
			F23 = 0x86,
			/// <summary></summary>
			F24 = 0x87,
			/// <summary></summary>
			NumLock = 0x90,
			/// <summary></summary>
			ScrollLock = 0x91,
			/// <summary></summary>
			NEC_Equal = 0x92,
			/// <summary></summary>
			Fujitsu_Jisho = 0x92,
			/// <summary></summary>
			Fujitsu_Masshou = 0x93,
			/// <summary></summary>
			Fujitsu_Touroku = 0x94,
			/// <summary></summary>
			Fujitsu_Loya = 0x95,
			/// <summary></summary>
			Fujitsu_Roya = 0x96,
			/// <summary></summary>
			LeftShift = 0xA0,
			/// <summary></summary>
			RightShift = 0xA1,
			/// <summary></summary>
			LeftControl = 0xA2,
			/// <summary></summary>
			RightControl = 0xA3,
			/// <summary></summary>
			LeftMenu = 0xA4,
			/// <summary></summary>
			RightMenu = 0xA5,
			/// <summary></summary>
			BrowserBack = 0xA6,
			/// <summary></summary>
			BrowserForward = 0xA7,
			/// <summary></summary>
			BrowserRefresh = 0xA8,
			/// <summary></summary>
			BrowserStop = 0xA9,
			/// <summary></summary>
			BrowserSearch = 0xAA,
			/// <summary></summary>
			BrowserFavorites = 0xAB,
			/// <summary></summary>
			BrowserHome = 0xAC,
			/// <summary></summary>
			VolumeMute = 0xAD,
			/// <summary></summary>
			VolumeDown = 0xAE,
			/// <summary></summary>
			VolumeUp = 0xAF,
			/// <summary></summary>
			MediaNextTrack = 0xB0,
			/// <summary></summary>
			MediaPrevTrack = 0xB1,
			/// <summary></summary>
			MediaStop = 0xB2,
			/// <summary></summary>
			MediaPlayPause = 0xB3,
			/// <summary></summary>
			LaunchMail = 0xB4,
			/// <summary></summary>
			LaunchMediaSelect = 0xB5,
			/// <summary></summary>
			LaunchApplication1 = 0xB6,
			/// <summary></summary>
			LaunchApplication2 = 0xB7,
			/// <summary></summary>
			OEM1 = 0xBA,
			/// <summary></summary>
			OEMPlus = 0xBB,
			/// <summary></summary>
			OEMComma = 0xBC,
			/// <summary></summary>
			OEMMinus = 0xBD,
			/// <summary></summary>
			OEMPeriod = 0xBE,
			/// <summary></summary>
			OEM2 = 0xBF,
			/// <summary></summary>
			OEM3 = 0xC0,
			/// <summary></summary>
			OEM4 = 0xDB,
			/// <summary></summary>
			OEM5 = 0xDC,
			/// <summary></summary>
			OEM6 = 0xDD,
			/// <summary></summary>
			OEM7 = 0xDE,
			/// <summary></summary>
			OEM8 = 0xDF,
			/// <summary></summary>
			OEMAX = 0xE1,
			/// <summary></summary>
			OEM102 = 0xE2,
			/// <summary></summary>
			ICOHelp = 0xE3,
			/// <summary></summary>
			ICO00 = 0xE4,
			/// <summary></summary>
			ProcessKey = 0xE5,
			/// <summary></summary>
			ICOClear = 0xE6,
			/// <summary></summary>
			Packet = 0xE7,
			/// <summary></summary>
			OEMReset = 0xE9,
			/// <summary></summary>
			OEMJump = 0xEA,
			/// <summary></summary>
			OEMPA1 = 0xEB,
			/// <summary></summary>
			OEMPA2 = 0xEC,
			/// <summary></summary>
			OEMPA3 = 0xED,
			/// <summary></summary>
			OEMWSCtrl = 0xEE,
			/// <summary></summary>
			OEMCUSel = 0xEF,
			/// <summary></summary>
			OEMATTN = 0xF0,
			/// <summary></summary>
			OEMFinish = 0xF1,
			/// <summary></summary>
			OEMCopy = 0xF2,
			/// <summary></summary>
			OEMAuto = 0xF3,
			/// <summary></summary>
			OEMENLW = 0xF4,
			/// <summary></summary>
			OEMBackTab = 0xF5,
			/// <summary></summary>
			ATTN = 0xF6,
			/// <summary></summary>
			CRSel = 0xF7,
			/// <summary></summary>
			EXSel = 0xF8,
			/// <summary></summary>
			EREOF = 0xF9,
			/// <summary></summary>
			Play = 0xFA,
			/// <summary></summary>
			Zoom = 0xFB,
			/// <summary></summary>
			Noname = 0xFC,
			/// <summary></summary>
			PA1 = 0xFD,
			/// <summary></summary>
			OEMClear = 0xFE
		}

		/// <summary>
		/// Convert a <see cref="VirtualKeys"/> to the corresponding <see cref="KeyCode"/>.
		/// </summary>
		/// <param name="key">
		/// The <see cref="VirtualKeys"/> to be converted.
		/// </param>
		/// <returns>
		/// The <see cref="KeyCode"/> corresponding to <paramref name="key"/>. In case the
		/// conversion is not possible, returns <see cref="KeyCode.None"/>.
		/// </returns>
		private static KeyCode ToKeyCode(VirtualKeys key)
		{
			switch (key) {
				case VirtualKeys.Tab:
					return KeyCode.Tab;

				case VirtualKeys.Return:
					return KeyCode.Return;
				case VirtualKeys.Shift:
					return KeyCode.Shift;
				case VirtualKeys.Control:
					return KeyCode.Control;
				case VirtualKeys.Menu:
					return KeyCode.Menu;
				case VirtualKeys.CapsLock:
					return KeyCode.CapsLock;
				case VirtualKeys.Escape:
					return KeyCode.Escape;

				case VirtualKeys.Space:
					return KeyCode.Space;

				case VirtualKeys.End:
					return KeyCode.End;
				case VirtualKeys.Home:
					return KeyCode.Home;

				case VirtualKeys.Left:
					return KeyCode.Left;
				case VirtualKeys.Up:
					return KeyCode.Up;
				case VirtualKeys.Right:
					return KeyCode.Right;
				case VirtualKeys.Down:
					return KeyCode.Down;

				case VirtualKeys.Insert:
					return KeyCode.Insert;
				case VirtualKeys.Delete:
					return KeyCode.Delete;

				case VirtualKeys.N0:
					return KeyCode.N0;
				case VirtualKeys.N1:
					return KeyCode.N1;
				case VirtualKeys.N2:
					return KeyCode.N2;
				case VirtualKeys.N3:
					return KeyCode.N3;
				case VirtualKeys.N4:
					return KeyCode.N4;
				case VirtualKeys.N5:
					return KeyCode.N5;
				case VirtualKeys.N6:
					return KeyCode.N6;
				case VirtualKeys.N7:
					return KeyCode.N7;
				case VirtualKeys.N8:
					return KeyCode.N8;
				case VirtualKeys.N9:
					return KeyCode.N9;

				case VirtualKeys.A:
					return KeyCode.A;
				case VirtualKeys.B:
					return KeyCode.B;
				case VirtualKeys.C:
					return KeyCode.C;
				case VirtualKeys.D:
					return KeyCode.D;
				case VirtualKeys.E:
					return KeyCode.E;
				case VirtualKeys.F:
					return KeyCode.F;
				case VirtualKeys.G:
					return KeyCode.G;
				case VirtualKeys.H:
					return KeyCode.H;
				case VirtualKeys.I:
					return KeyCode.I;
				case VirtualKeys.J:
					return KeyCode.J;
				case VirtualKeys.K:
					return KeyCode.K;
				case VirtualKeys.L:
					return KeyCode.L;
				case VirtualKeys.M:
					return KeyCode.M;
				case VirtualKeys.N:
					return KeyCode.N;
				case VirtualKeys.O:
					return KeyCode.O;
				case VirtualKeys.P:
					return KeyCode.P;
				case VirtualKeys.Q:
					return KeyCode.Q;
				case VirtualKeys.R:
					return KeyCode.R;
				case VirtualKeys.S:
					return KeyCode.S;
				case VirtualKeys.T:
					return KeyCode.T;
				case VirtualKeys.U:
					return KeyCode.U;
				case VirtualKeys.V:
					return KeyCode.V;
				case VirtualKeys.W:
					return KeyCode.W;
				case VirtualKeys.X:
					return KeyCode.X;
				case VirtualKeys.Y:
					return KeyCode.Y;
				case VirtualKeys.Z:
					return KeyCode.Z;

				case VirtualKeys.LeftWindows:
					return KeyCode.LeftWindows;
				case VirtualKeys.RightWindows:
					return KeyCode.RightWindows;
				case VirtualKeys.Application:
					return KeyCode.Application;

				case VirtualKeys.Numpad0:
					return KeyCode.Numpad0;
				case VirtualKeys.Numpad1:
					return KeyCode.Numpad1;
				case VirtualKeys.Numpad2:
					return KeyCode.Numpad2;
				case VirtualKeys.Numpad3:
					return KeyCode.Numpad3;
				case VirtualKeys.Numpad4:
					return KeyCode.Numpad4;
				case VirtualKeys.Numpad5:
					return KeyCode.Numpad5;
				case VirtualKeys.Numpad6:
					return KeyCode.Numpad6;
				case VirtualKeys.Numpad7:
					return KeyCode.Numpad7;
				case VirtualKeys.Numpad8:
					return KeyCode.Numpad8;
				case VirtualKeys.Numpad9:
					return KeyCode.Numpad9;
				case VirtualKeys.Multiply:
					return KeyCode.Multiply;
				case VirtualKeys.Add:
					return KeyCode.Add;
				case VirtualKeys.Separator:
					return KeyCode.Separator;
				case VirtualKeys.Subtract:
					return KeyCode.Subtract;
				case VirtualKeys.Decimal:
					return KeyCode.Decimal;
				case VirtualKeys.Divide:
					return KeyCode.Divide;
				case VirtualKeys.F1:
					return KeyCode.F1;
				case VirtualKeys.F2:
					return KeyCode.F2;
				case VirtualKeys.F3:
					return KeyCode.F3;
				case VirtualKeys.F4:
					return KeyCode.F4;
				case VirtualKeys.F5:
					return KeyCode.F5;
				case VirtualKeys.F6:
					return KeyCode.F6;
				case VirtualKeys.F7:
					return KeyCode.F7;
				case VirtualKeys.F8:
					return KeyCode.F8;
				case VirtualKeys.F9:
					return KeyCode.F9;
				case VirtualKeys.F10:
					return KeyCode.F10;
				case VirtualKeys.F11:
					return KeyCode.F11;
				case VirtualKeys.F12:
					return KeyCode.F12;
				case VirtualKeys.F13:
					return KeyCode.F13;
				case VirtualKeys.F14:
					return KeyCode.F14;
				case VirtualKeys.F15:
					return KeyCode.F15;
				case VirtualKeys.F16:
					return KeyCode.F16;
				case VirtualKeys.F17:
					return KeyCode.F17;
				case VirtualKeys.F18:
					return KeyCode.F18;
				case VirtualKeys.F19:
					return KeyCode.F19;
				case VirtualKeys.F20:
					return KeyCode.F20;
				case VirtualKeys.F21:
					return KeyCode.F21;
				case VirtualKeys.F22:
					return KeyCode.F22;
				case VirtualKeys.F23:
					return KeyCode.F23;
				case VirtualKeys.F24:
					return KeyCode.F24;
				case VirtualKeys.NumLock:
					return KeyCode.NumLock;
				case VirtualKeys.ScrollLock:
					return KeyCode.ScrollLock;
				default:
					return KeyCode.None;
			}
		}

		private static VirtualKeys ToVirtualKeys(KeyCode key)
		{
			switch (key) {
				case KeyCode.Tab:
					return VirtualKeys.Tab;

				case KeyCode.Return:
					return VirtualKeys.Return;
				case KeyCode.Shift:
					return VirtualKeys.Shift;
				case KeyCode.Control:
					return VirtualKeys.Control;
				case KeyCode.Menu:
					return VirtualKeys.Menu;
				case KeyCode.CapsLock:
					return VirtualKeys.CapsLock;
				case KeyCode.Escape:
					return VirtualKeys.Escape;

				case KeyCode.Space:
					return VirtualKeys.Space;

				case KeyCode.End:
					return VirtualKeys.End;
				case KeyCode.Home:
					return VirtualKeys.Home;

				case KeyCode.Left:
					return VirtualKeys.Left;
				case KeyCode.Up:
					return VirtualKeys.Up;
				case KeyCode.Right:
					return VirtualKeys.Right;
				case KeyCode.Down:
					return VirtualKeys.Down;

				case KeyCode.Insert:
					return VirtualKeys.Insert;
				case KeyCode.Delete:
					return VirtualKeys.Delete;

				case KeyCode.N0:
					return VirtualKeys.N0;
				case KeyCode.N1:
					return VirtualKeys.N1;
				case KeyCode.N2:
					return VirtualKeys.N2;
				case KeyCode.N3:
					return VirtualKeys.N3;
				case KeyCode.N4:
					return VirtualKeys.N4;
				case KeyCode.N5:
					return VirtualKeys.N5;
				case KeyCode.N6:
					return VirtualKeys.N6;
				case KeyCode.N7:
					return VirtualKeys.N7;
				case KeyCode.N8:
					return VirtualKeys.N8;
				case KeyCode.N9:
					return VirtualKeys.N9;

				case KeyCode.A:
					return VirtualKeys.A;
				case KeyCode.B:
					return VirtualKeys.B;
				case KeyCode.C:
					return VirtualKeys.C;
				case KeyCode.D:
					return VirtualKeys.D;
				case KeyCode.E:
					return VirtualKeys.E;
				case KeyCode.F:
					return VirtualKeys.F;
				case KeyCode.G:
					return VirtualKeys.G;
				case KeyCode.H:
					return VirtualKeys.H;
				case KeyCode.I:
					return VirtualKeys.I;
				case KeyCode.J:
					return VirtualKeys.J;
				case KeyCode.K:
					return VirtualKeys.K;
				case KeyCode.L:
					return VirtualKeys.L;
				case KeyCode.M:
					return VirtualKeys.M;
				case KeyCode.N:
					return VirtualKeys.N;
				case KeyCode.O:
					return VirtualKeys.O;
				case KeyCode.P:
					return VirtualKeys.P;
				case KeyCode.Q:
					return VirtualKeys.Q;
				case KeyCode.R:
					return VirtualKeys.R;
				case KeyCode.S:
					return VirtualKeys.S;
				case KeyCode.T:
					return VirtualKeys.T;
				case KeyCode.U:
					return VirtualKeys.U;
				case KeyCode.V:
					return VirtualKeys.V;
				case KeyCode.W:
					return VirtualKeys.W;
				case KeyCode.X:
					return VirtualKeys.X;
				case KeyCode.Y:
					return VirtualKeys.Y;
				case KeyCode.Z:
					return VirtualKeys.Z;

				case KeyCode.LeftWindows:
					return VirtualKeys.LeftWindows;
				case KeyCode.RightWindows:
					return VirtualKeys.RightWindows;
				case KeyCode.Application:
					return VirtualKeys.Application;

				case KeyCode.Numpad0:
					return VirtualKeys.Numpad0;
				case KeyCode.Numpad1:
					return VirtualKeys.Numpad1;
				case KeyCode.Numpad2:
					return VirtualKeys.Numpad2;
				case KeyCode.Numpad3:
					return VirtualKeys.Numpad3;
				case KeyCode.Numpad4:
					return VirtualKeys.Numpad4;
				case KeyCode.Numpad5:
					return VirtualKeys.Numpad5;
				case KeyCode.Numpad6:
					return VirtualKeys.Numpad6;
				case KeyCode.Numpad7:
					return VirtualKeys.Numpad7;
				case KeyCode.Numpad8:
					return VirtualKeys.Numpad8;
				case KeyCode.Numpad9:
					return VirtualKeys.Numpad9;
				case KeyCode.Multiply:
					return VirtualKeys.Multiply;
				case KeyCode.Add:
					return VirtualKeys.Add;
				case KeyCode.Separator:
					return VirtualKeys.Separator;
				case KeyCode.Subtract:
					return VirtualKeys.Subtract;
				case KeyCode.Decimal:
					return VirtualKeys.Decimal;
				case KeyCode.Divide:
					return VirtualKeys.Divide;
				case KeyCode.F1:
					return VirtualKeys.F1;
				case KeyCode.F2:
					return VirtualKeys.F2;
				case KeyCode.F3:
					return VirtualKeys.F3;
				case KeyCode.F4:
					return VirtualKeys.F4;
				case KeyCode.F5:
					return VirtualKeys.F5;
				case KeyCode.F6:
					return VirtualKeys.F6;
				case KeyCode.F7:
					return VirtualKeys.F7;
				case KeyCode.F8:
					return VirtualKeys.F8;
				case KeyCode.F9:
					return VirtualKeys.F9;
				case KeyCode.F10:
					return VirtualKeys.F10;
				case KeyCode.F11:
					return VirtualKeys.F11;
				case KeyCode.F12:
					return VirtualKeys.F12;
				case KeyCode.F13:
					return VirtualKeys.F13;
				case KeyCode.F14:
					return VirtualKeys.F14;
				case KeyCode.F15:
					return VirtualKeys.F15;
				case KeyCode.F16:
					return VirtualKeys.F16;
				case KeyCode.F17:
					return VirtualKeys.F17;
				case KeyCode.F18:
					return VirtualKeys.F18;
				case KeyCode.F19:
					return VirtualKeys.F19;
				case KeyCode.F20:
					return VirtualKeys.F20;
				case KeyCode.F21:
					return VirtualKeys.F21;
				case KeyCode.F22:
					return VirtualKeys.F22;
				case KeyCode.F23:
					return VirtualKeys.F23;
				case KeyCode.F24:
					return VirtualKeys.F24;
				case KeyCode.NumLock:
					return VirtualKeys.NumLock;
				case KeyCode.ScrollLock:
					return VirtualKeys.ScrollLock;

				default:
					throw new NotSupportedException("unsupported key code " + key);
			}
		}

		[Flags]
		private enum TME : uint
		{
			CANCEL = 0x80000000,
			HOVER = 0x00000001,
			LEAVE = 0x00000002,
			NONCLIENT = 0x00000010,
			QUERY = 0x40000000
		}

		[StructLayout(LayoutKind.Sequential)]
		[SuppressMessage("ReSharper", "PrivateFieldCanBeConvertedToLocalVariable")]
		private struct TRACKMOUSEEVENT
		{
			/// <summary>
			/// 
			/// </summary>
			/// <param name="flags"></param>
			/// <param name="hwndTrack"></param>
			public TRACKMOUSEEVENT(TME flags, IntPtr hwndTrack)
			{
				_Size = Marshal.SizeOf(typeof(TRACKMOUSEEVENT));
				_Flags = flags;
				_HwndTrack = hwndTrack;
				_HoverTime = unchecked((int)0xFFFFFFFF);		// HOVER_DEFAULT
			}

			private readonly int _Size;

			private readonly TME _Flags;

			private readonly IntPtr _HwndTrack;

			private readonly int _HoverTime;
		}

		private static class UnsafeNativeMethods
		{
			// CLASS STYLE
			public const uint CS_VREDRAW = 0x0001;
			public const uint CS_HREDRAW = 0x0002;
			public const uint CS_OWNDC = 0x0020;

			internal delegate IntPtr WndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

			[DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
			internal static extern IntPtr GetModuleHandle(string lpModuleName);

			[DllImport("user32.dll", EntryPoint = "DefWindowProc", SetLastError = true)]
			internal static extern IntPtr DefWindowProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

			[DllImport("user32.dll", EntryPoint = "RegisterClassEx", SetLastError = true, CharSet = CharSet.Unicode)]
			internal static extern ushort RegisterClassEx([In] ref WNDCLASSEX lpWndClass);

			[DllImport("user32.dll", EntryPoint = "UnregisterClass", SetLastError = true)]
			internal static extern bool UnregisterClass(ushort lpClassAtom, IntPtr hInstance);

			[DllImport("user32.dll", EntryPoint = "CreateWindowEx", SetLastError = true, CharSet = CharSet.Unicode)]
			internal static extern IntPtr CreateWindowEx(uint dwExStyle, string lpClassName, string lpWindowName, uint dwStyle, int x, int y, int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, IntPtr lpParam);

			[DllImport("user32.dll", SetLastError = true)]
			internal static extern bool DestroyWindow(IntPtr hWnd);

			[DllImport("user32.dll")]
			internal static extern int GetMessage(out MSG lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax);

			[DllImport("user32.dll")]
			internal static extern bool TranslateMessage(ref MSG lpMsg);

			[DllImport("user32.dll")]
			internal static extern IntPtr DispatchMessage(ref MSG lpmsg);

			[DllImport("user32.dll")]
			internal static extern bool ShowWindow(IntPtr hWnd, WindowShowStyle nCmdShow);

			[DllImport("user32.dll", SetLastError = true)]
			internal static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

			[DllImport("user32.dll", SetLastError = true)]
			internal static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);

			[DllImport("user32.dll")]
			internal static extern bool InvalidateRect(IntPtr hWnd, IntPtr lpRect, bool bErase);

			[DllImport("user32.dll")]
			internal static extern bool UpdateWindow(IntPtr hWnd);

			[DllImport("user32.dll")]
			internal static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprcUpdate, IntPtr hrgnUpdate, RedrawWindowFlags flags);

			[DllImport("user32.dll")]
			internal static extern int GetSystemMetrics(SystemMetric smIndex);

			[DllImport("user32.dll")]
			internal static extern bool AdjustWindowRectEx([In, Out] ref RECT lpRect, uint dwStyle, bool bMenu, uint dwExStyle);

			[DllImport("user32.dll", SetLastError = true)]
			internal static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, SetWindowPosFlags uFlags);

			[DllImport("user32.dll", SetLastError = true)]
			internal static extern int SetWindowLong(IntPtr hWnd, SetWindowLongIndex nIndex, uint dwNewLong);

			[DllImport("user32.dll", SetLastError = true)]
			internal static extern int GetWindowLong(IntPtr hWnd, SetWindowLongIndex nIndex);

			[DllImport("user32.dll")]
			internal static extern bool GetMonitorInfo(IntPtr hMonitor, ref MONITORINFOEX lpmi);

			internal const int MONITOR_DEFAULTTONULL = 0;
			internal const int MONITOR_DEFAULTTOPRIMARY = 1;
			internal const int MONITOR_DEFAULTTONEAREST = 2;

			[DllImport("user32.dll")]
			internal static extern IntPtr MonitorFromWindow(IntPtr hwnd, uint dwFlags);

			[DllImport("user32.dll", SetLastError = false)]
			public static extern IntPtr SendMessage(IntPtr hWnd, WM Msg, IntPtr wParam, IntPtr lParam);

			[DllImport("user32.dll", SetLastError = true)]
			public static extern bool PostMessage(IntPtr hWnd, WM Msg, IntPtr wParam, IntPtr lParam);

			[DllImport("user32.dll", SetLastError = false)]
			public static extern void PostQuitMessage(int nExitCode);

			[DllImport("user32.dll", SetLastError = true)]
			public static extern bool TrackMouseEvent(ref TRACKMOUSEEVENT lpEventTrack);
		}

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
