
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

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;		// Do not delete me! .NET Core include extension methods
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
			_WindowsWndProc = new UnsafeNativeMethods.WndProc(WindowsWndProc);
		}

		#endregion

		#region Platform Resources

		private IntPtr WindowsWndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
		{
			switch ((WM)msg) {
				case WM.CREATE:
					try {
						// Create device context
						CreateDeviceContext(IntPtr.Zero, hWnd);
						// Create OpenGL context
						CreateDesktopContext();
						// The context is made current unconditionally: event handlers allocate resources
						MakeCurrentContext();
						// Event handling
						OnContextCreated();
					} catch (Exception exception) {
						_FailureException = exception;
						Debug.Fail(String.Format("OnHandleCreated: initialization exception ({0})\n{1}", exception.Message, exception.ToString()));
					}
					break;
				case WM.DESTROY:
					DeleteContext();
					DestroyDeviceContext();
					break;
				case WM.SIZE:
					break;
				case WM.PAINT:
					MakeCurrentContext();
					OnRender();
					OnContextUpdate();
					SwapBuffers();
					break;
			}

			// Callback default window procedure.
			return (UnsafeNativeMethods.DefWindowProc(hWnd, msg, wParam, lParam));
		}

		/// <summary>
		/// The native window handle.
		/// </summary>
		private IntPtr _Handle;

		/// <summary>
		/// The atom associated to the window class.
		/// </summary>
		private UInt16 _ClassAtom;

		/// <summary>
		/// Windows procedure.
		/// </summary>
		private readonly UnsafeNativeMethods.WndProc _WindowsWndProc;

		/// <summary>
		/// Exception caught while creating device context and render context.
		/// </summary>
		private Exception _FailureException;

		#endregion

		#region P/Invoke

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		private struct WNDCLASSEX {
			public int cbSize;
			public int style;
			public IntPtr lpfnWndProc; 
			public int cbClsExtra;
			public int cbWndExtra;
			public IntPtr hInstance;
			public IntPtr hIcon;
			public IntPtr hCursor;
			public IntPtr hbrBackground;
			[MarshalAs(UnmanagedType.LPTStr)]
			public string lpszMenuName;
			[MarshalAs(UnmanagedType.LPTStr)]
			public string lpszClassName;
			public IntPtr hIconSm;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct MSG  
		{  
			public IntPtr hwnd;
			public UInt32 message;
			public UIntPtr wParam;
			public UIntPtr lParam;
			public UInt32 time;
			public POINT pt;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct POINT
		{  
			public Int32 x;
			public Int32 y;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct RECT
		{  
			public Int32 left;
			public Int32 top;
			public Int32 right;
			public Int32 bottom;
		}

		/// <summary>
		/// Windows Messages
		/// Defined in winuser.h from Windows SDK v6.1
		/// Documentation pulled from MSDN.
		/// http://www.pinvoke.net/default.aspx/Enums.WindowsMessages
		/// </summary>
		public enum WM : uint
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
		}

		/// <summary>
		/// Enumeration of the different ways of showing a window using ShowWindow.
		/// </summary>
		private enum WindowShowStyle : int
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

		private unsafe static partial class UnsafeNativeMethods
		{
			// CLASS STYLE
			public const UInt32 CS_VREDRAW =	0x0001;
			public const UInt32 CS_HREDRAW =	0x0002;
			public const UInt32 CS_OWNDC =		0x0020;

			// WINDOWS STYLE
			public const UInt32 WS_CLIPCHILDREN =			0x2000000;
			public const UInt32 WS_CLIPSIBLINGS =			0x4000000;
			public const UInt32 WS_OVERLAPPED =				0x0;

			// WINDOWS STYLE EX
			public const UInt32 WS_EX_APPWINDOW =			0x00040000;
			public const UInt32 WS_EX_WINDOWEDGE =			0x00000100;

			internal delegate IntPtr WndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

			[DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
			internal static extern IntPtr GetModuleHandle(string lpModuleName);

			[DllImport("user32.dll", EntryPoint = "DefWindowProc", SetLastError = true)]
			internal static extern IntPtr DefWindowProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

			[DllImport("user32.dll", EntryPoint = "RegisterClassEx", SetLastError = true, CharSet = CharSet.Unicode)]
			internal static extern UInt16 RegisterClassEx([In] ref WNDCLASSEX lpWndClass);

			[DllImport("user32.dll", EntryPoint = "UnregisterClass", SetLastError = true)]
			internal static extern bool UnregisterClass(UInt16 lpClassAtom, IntPtr hInstance);

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

			[DllImport("user32.dll")]
			internal static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);
		}

		#endregion

		#region NativeWindow Overrides

		/// <summary>
		/// Get the display handle associated this instance.
		/// </summary>
		public override IntPtr Display { get { return (IntPtr.Zero); } }

		/// <summary>
		/// Get the native window handle.
		/// </summary>
		public override IntPtr Handle { get { return (_Handle); } }

		/// <summary>
		/// Run the event loop for this NativeWindow.
		/// </summary>
		public override void Run()
		{
			MSG msg;
			int bRet;

			while( (bRet = UnsafeNativeMethods.GetMessage(out msg, IntPtr.Zero, 0, 0)) != 0) { 
				if (bRet == -1) {
					
				} else {
					UnsafeNativeMethods.TranslateMessage(ref msg); 
					UnsafeNativeMethods.DispatchMessage(ref msg); 
				}
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
		public override void Create(int x, int y, uint width, uint height)
		{
			// Register window class
			WNDCLASSEX windowClass = new WNDCLASSEX();
			const string DefaultWindowClass = "OpenGL.CoreUI2";

			windowClass.cbSize = Marshal.SizeOf(typeof(WNDCLASSEX));
			windowClass.style = (int)(UnsafeNativeMethods.CS_HREDRAW | UnsafeNativeMethods.CS_VREDRAW | UnsafeNativeMethods.CS_OWNDC);
			windowClass.lpfnWndProc = Marshal.GetFunctionPointerForDelegate(_WindowsWndProc);
#if !NETCORE
			windowClass.hInstance = Marshal.GetHINSTANCE(typeof(Gl).Module);
#else
			windowClass.hInstance = UnsafeNativeMethods.GetModuleHandle(typeof(Gl).GetTypeInfo().Assembly.Location);
#endif
			windowClass.lpszClassName = DefaultWindowClass;

			if ((_ClassAtom = UnsafeNativeMethods.RegisterClassEx(ref windowClass)) == 0)
				throw new Win32Exception(Marshal.GetLastWin32Error());

			// Create window
			const uint DefaultWindowStyleEx = UnsafeNativeMethods.WS_EX_APPWINDOW | UnsafeNativeMethods.WS_EX_WINDOWEDGE;
			const uint DefaultWindowStyle = UnsafeNativeMethods.WS_OVERLAPPED | UnsafeNativeMethods.WS_CLIPCHILDREN | UnsafeNativeMethods.WS_CLIPSIBLINGS;

			_Handle = UnsafeNativeMethods.CreateWindowEx(
				DefaultWindowStyleEx, windowClass.lpszClassName, String.Empty, DefaultWindowStyle,
				x, y, (int)width, (int)height,
				IntPtr.Zero, IntPtr.Zero, windowClass.hInstance, IntPtr.Zero
			);

			if (_Handle == IntPtr.Zero)
				throw new Win32Exception(Marshal.GetLastWin32Error());

			RECT clientSize;

			UnsafeNativeMethods.GetClientRect(_Handle, out clientSize);
			_Width = (uint)clientSize.right;
			_Height = (uint)clientSize.bottom;
		}

		/// <summary>
		/// The NativeWindow width of the client area, in pixels.
		/// </summary>
		public override uint Width { get { return (_Width); } }

		/// <summary>
		/// The NativeWindow width of the client area, in pixels.
		/// </summary>
		private uint _Width;

		/// <summary>
		/// The NativeWindow height of the client area, in pixels.
		/// </summary>
		public override uint Height { get { return (_Height); } }

		/// <summary>
		/// The NativeWindow height of the client area, in pixels.
		/// </summary>
		private uint _Height;

		/// <summary>
		/// Show the native window.
		/// </summary>
		public override void Show()
		{
			UnsafeNativeMethods.ShowWindow(_Handle, WindowShowStyle.Show);
		}

		/// <summary>
		/// Hide the native window.
		/// </summary>
		public override void Hide()
		{
			UnsafeNativeMethods.ShowWindow(_Handle, WindowShowStyle.Hide);
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="System.Boolean"/> indicating whether the disposition is requested explictly.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			if (_Handle != IntPtr.Zero) {
				UnsafeNativeMethods.DestroyWindow(_Handle);
				_Handle = IntPtr.Zero;
			}

			if (_ClassAtom != 0) {
#if !NETCORE
				UnsafeNativeMethods.UnregisterClass(_ClassAtom, Marshal.GetHINSTANCE(typeof(Gl).Module));
#else
					
#endif
				_ClassAtom = 0;
			}

			// Base implementation
			base.Dispose(disposing);
		}

		#endregion
	}
}
