
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
using System.Reflection;				// Do not delete me! .NET Core include extension methods
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

#if !NETCORE
			_HInstance = Marshal.GetHINSTANCE(typeof(Gl).Module);
#else
			_HInstance = UnsafeNativeMethods.GetModuleHandle(typeof(Gl).GetTypeInfo().Assembly.Location);
#endif
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
						Debug.Fail(String.Format("OnCreate: ({0})\n{1}", exception.Message, exception.ToString()));
					}

					return (IntPtr.Zero);
				case WM.DESTROY:
					try {
						DeleteContext();
						DestroyDeviceContext();
					} catch (Exception exception) {
						Debug.Fail(String.Format("OnDestroy: ({0})\n{1}", exception.Message, exception.ToString()));
					}
					return (IntPtr.Zero);
				case WM.SIZE:
					break;
				case WM.PAINT:
					try {
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
					} catch (Exception exception) {
						Debug.Fail(String.Format("OnPaint: ({0})\n{1}", exception.Message, exception.ToString()));
					}

					return (IntPtr.Zero);
			}

			// Callback default window procedure.
			return (UnsafeNativeMethods.DefWindowProc(hWnd, msg, wParam, lParam));
		}

		/// <summary>
		/// Application instance handle.
		/// </summary>
		private IntPtr _HInstance;

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
		public enum SystemMetric:int
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

			[DllImport("user32.dll")]
			internal static extern bool InvalidateRect(IntPtr hWnd, IntPtr lpRect, bool bErase);

			[DllImport("user32.dll")]
			internal static extern bool UpdateWindow(IntPtr hWnd);

			//[DllImport("user32.dll")]
			//internal static extern bool RedrawWindow(IntPtr hWnd, [In] ref RECT lprcUpdate, IntPtr hrgnUpdate, RedrawWindowFlags flags);

			[DllImport("user32.dll")]
			internal static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprcUpdate, IntPtr hrgnUpdate, RedrawWindowFlags flags);

			[DllImport("user32.dll")]
			internal static extern int GetSystemMetrics(SystemMetric smIndex);

			[DllImport("user32.dll")]
			internal static extern bool AdjustWindowRectEx([In, Out] ref RECT lpRect, uint dwStyle, bool bMenu, uint dwExStyle);
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

			while (UnsafeNativeMethods.GetMessage(out msg, IntPtr.Zero, 0, 0) != 0) {
				UnsafeNativeMethods.TranslateMessage(ref msg); 
				UnsafeNativeMethods.DispatchMessage(ref msg); 
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
			windowClass.style =  (int)(UnsafeNativeMethods.CS_HREDRAW | UnsafeNativeMethods.CS_VREDRAW | UnsafeNativeMethods.CS_OWNDC);
			windowClass.lpfnWndProc = Marshal.GetFunctionPointerForDelegate(_WindowsWndProc);
			windowClass.hInstance = _HInstance;
			windowClass.lpszClassName = DefaultWindowClass;

			if ((_ClassAtom = UnsafeNativeMethods.RegisterClassEx(ref windowClass)) == 0)
				throw new Win32Exception(Marshal.GetLastWin32Error());

			// Note: window size is meant as client area, but CreateWindowEx width/height specifies the external
			// frame size: compute offset for frame borders
			RECT clientSize = new RECT();

			clientSize.left = x;
			clientSize.right = x + (int)width;
			clientSize.top = y;
			clientSize.bottom = y + (int)height;

			int cxSizeFrame = UnsafeNativeMethods.GetSystemMetrics(SystemMetric.CXSizeFrame) * 2;
			int cySizeFrame = UnsafeNativeMethods.GetSystemMetrics(SystemMetric.CYSizeFrame) * 2;
			int cySizeCaption = UnsafeNativeMethods.GetSystemMetrics(SystemMetric.CYCaption);

			clientSize.left   -= cxSizeFrame;
			clientSize.right  += cxSizeFrame;
			clientSize.top    -= cySizeFrame;
			clientSize.bottom += cySizeFrame + cySizeCaption;

			// Create window
			const uint DefaultWindowStyleEx = UnsafeNativeMethods.WS_EX_APPWINDOW | UnsafeNativeMethods.WS_EX_WINDOWEDGE;
			const uint DefaultWindowStyle = UnsafeNativeMethods.WS_OVERLAPPED | UnsafeNativeMethods.WS_CLIPCHILDREN | UnsafeNativeMethods.WS_CLIPSIBLINGS;

			_Handle = UnsafeNativeMethods.CreateWindowEx(
				DefaultWindowStyleEx, windowClass.lpszClassName, String.Empty, DefaultWindowStyle,
				clientSize.left, clientSize.top, clientSize.right - clientSize.left, clientSize.bottom - clientSize.top,
				IntPtr.Zero, IntPtr.Zero, windowClass.hInstance, IntPtr.Zero
			);

			if (_Handle == IntPtr.Zero)
				throw new Win32Exception(Marshal.GetLastWin32Error());

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
		/// Invalidate the window.
		/// </summary>
		public override void Invalidate()
		{
			UnsafeNativeMethods.InvalidateRect(_Handle, IntPtr.Zero, true);
			UnsafeNativeMethods.UpdateWindow(_Handle);
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
				UnsafeNativeMethods.UnregisterClass(_ClassAtom, _HInstance);
				_ClassAtom = 0;
			}

			// Base implementation
			base.Dispose(disposing);
		}

		#endregion
	}
}
