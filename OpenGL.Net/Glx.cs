
// Copyright (C) 2015-2017 Luca Piccioni
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
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;
using System.Reflection;

using Khronos;

namespace OpenGL
{
	/// <summary>
	/// GLX (GL for X) window system interface.
	/// </summary>
	[SuppressMessage("ReSharper", "InconsistentNaming")]
	public partial class Glx : KhronosApi
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static Glx()
		{
			BindAPI();
		}

		#endregion

		#region Platform Extensions

		/// <summary>
		/// OpenGL extension support.
		/// </summary>
		public static Extensions CurrentExtensions { get { return (_CurrentExtensions); } }

		/// <summary>
		/// OpenGL extension support.
		/// </summary>
		internal static Extensions _CurrentExtensions;

		#endregion

		#region API Binding

		/// <summary>
		/// Get whether GLX layer is avaialable.
		/// </summary>
		public static bool IsAvailable { get { return (Delegates.pglXCreateContext != null); } }

		/// <summary>
		/// Get or set whether <see cref="DeviceContextFactory"/> should create an GLX device context, if available.
		/// </summary>
		public static bool IsRequired
		{
			get { return (_IsRequired && IsAvailable); }
			set { _IsRequired = value; }
		}

		/// <summary>
		/// Flag for requesting an EGL device context, if available.
		/// </summary>
		private static bool _IsRequired;

		/// <summary>
		/// Get or set the delegate used for loading function pointers for this API.
		/// </summary>
		public GetAddressDelegate GetFunctionPointerDelegate
		{
			get { return _GetAddressDelegate; }
			set { _GetAddressDelegate = value ?? GetProcAddressGLOS; }
		}

		/// <summary>
		/// Delegate used for loading function pointers for this API.
		/// </summary>
		private static GetAddressDelegate _GetAddressDelegate = GetProcAddressOS;

		/// <summary>
		/// Bind Windows EGL delegates.
		/// </summary>
		private static void BindAPI()
		{
			try {
				BindAPI<Glx>(Library, _GetAddressDelegate, null);
			} catch (Exception) {
				/* Fail-safe (it may fail due Egl access) */
			}
		}

		/// <summary>
		/// Default import library.
		/// </summary>
		private const string Library = "libGL.so.1";

		#endregion

		#region Error Handling

		/// <summary>
		/// GLX error checking.
		/// </summary>
		/// <param name="returnValue">
		/// A <see cref="Object"/> that specifies the function returned value, if any.
		/// </param>
		[Conditional("GL_DEBUG")]
		private static void DebugCheckErrors(object returnValue)
		{
			IntPtr display = Delegates.pglXGetCurrentDisplay();		// Avoid recursion
			Debug.Assert(display != IntPtr.Zero);

			lock (DeviceContextGLX._DisplayErrorsLock) {
				Exception glxException;
				if (DeviceContextGLX._DisplayErrors.TryGetValue(display, out glxException) == true)
					throw glxException;
			}
		}

		#endregion

		#region Command Logging

		/// <summary>
		/// Load an API command call.
		/// </summary>
		/// <param name="name">
		/// A <see cref="String"/> that specifies the name of the API command.
		/// </param>
		/// <param name="returnValue">
		/// A <see cref="Object"/> that specifies the returned value, if any.
		/// </param>
		/// <param name="args">
		/// A <see cref="T:Object[]"/> that specifies the API command arguments, if any.
		/// </param>
		[Conditional("GL_DEBUG")]
		protected new static void LogCommand(string name, object returnValue, params object[] args)
		{
			if (_LogContext == null)
				_LogContext = new KhronosLogContext(typeof(Glx));
			RaiseLog(new KhronosLogEventArgs(_LogContext, name, args, returnValue));
		}

		/// <summary>
		/// Context for logging enumerant names instead of numerical values.
		/// </summary>
		private static KhronosLogContext _LogContext;

		#endregion

		#region Required External Declarations

		[StructLayout(LayoutKind.Sequential)]
		internal struct XAnyEvent
		{

			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr window;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XKeyEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr window;
			public IntPtr root;
			public IntPtr subwindow;
			public IntPtr time;
			public int x;
			public int y;
			public int x_root;
			public int y_root;
			public int state;
			public int keycode;
			public bool same_screen;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XButtonEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr window;
			public IntPtr root;
			public IntPtr subwindow;
			public IntPtr time;
			public int x;
			public int y;
			public int x_root;
			public int y_root;
			public int state;
			public int button;
			public bool same_screen;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XMotionEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr window;
			public IntPtr root;
			public IntPtr subwindow;
			public IntPtr time;
			public int x;
			public int y;
			public int x_root;
			public int y_root;
			public int state;
			public byte is_hint;
			public bool same_screen;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XCrossingEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr window;
			public IntPtr root;
			public IntPtr subwindow;
			public IntPtr time;
			public int x;
			public int y;
			public int x_root;
			public int y_root;
			public NotifyMode mode;
			public NotifyDetail detail;
			public bool same_screen;
			public bool focus;
			public int state;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XFocusChangeEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr window;
			public int mode;
			public NotifyDetail detail;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XKeymapEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr window;
			public byte key_vector0;
			public byte key_vector1;
			public byte key_vector2;
			public byte key_vector3;
			public byte key_vector4;
			public byte key_vector5;
			public byte key_vector6;
			public byte key_vector7;
			public byte key_vector8;
			public byte key_vector9;
			public byte key_vector10;
			public byte key_vector11;
			public byte key_vector12;
			public byte key_vector13;
			public byte key_vector14;
			public byte key_vector15;
			public byte key_vector16;
			public byte key_vector17;
			public byte key_vector18;
			public byte key_vector19;
			public byte key_vector20;
			public byte key_vector21;
			public byte key_vector22;
			public byte key_vector23;
			public byte key_vector24;
			public byte key_vector25;
			public byte key_vector26;
			public byte key_vector27;
			public byte key_vector28;
			public byte key_vector29;
			public byte key_vector30;
			public byte key_vector31;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XExposeEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr window;
			public int x;
			public int y;
			public int width;
			public int height;
			public int count;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XGraphicsExposeEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr drawable;
			public int x;
			public int y;
			public int width;
			public int height;
			public int count;
			public int major_code;
			public int minor_code;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XNoExposeEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr drawable;
			public int major_code;
			public int minor_code;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XVisibilityEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr window;
			public int state;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XCreateWindowEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr parent;
			public IntPtr window;
			public int x;
			public int y;
			public int width;
			public int height;
			public int border_width;
			public bool override_redirect;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XDestroyWindowEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr xevent;
			public IntPtr window;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XUnmapEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr xevent;
			public IntPtr window;
			public bool from_configure;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XMapEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr xevent;
			public IntPtr window;
			public bool override_redirect;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XMapRequestEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr parent;
			public IntPtr window;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XReparentEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr xevent;
			public IntPtr window;
			public IntPtr parent;
			public int x;
			public int y;
			public bool override_redirect;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XConfigureEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr xevent;
			public IntPtr window;
			public int x;
			public int y;
			public int width;
			public int height;
			public int border_width;
			public IntPtr above;
			public bool override_redirect;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XGravityEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr xevent;
			public IntPtr window;
			public int x;
			public int y;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XResizeRequestEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr window;
			public int width;
			public int height;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XConfigureRequestEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr parent;
			public IntPtr window;
			public int x;
			public int y;
			public int width;
			public int height;
			public int border_width;
			public IntPtr above;
			public int detail;
			public IntPtr value_mask;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XCirculateEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr xevent;
			public IntPtr window;
			public int place;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XCirculateRequestEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr parent;
			public IntPtr window;
			public int place;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XPropertyEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr window;
			public IntPtr atom;
			public IntPtr time;
			public int state;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XSelectionClearEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr window;
			public IntPtr selection;
			public IntPtr time;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XSelectionRequestEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr owner;
			public IntPtr requestor;
			public IntPtr selection;
			public IntPtr target;
			public IntPtr property;
			public IntPtr time;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XSelectionEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr requestor;
			public IntPtr selection;
			public IntPtr target;
			public IntPtr property;
			public IntPtr time;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XColormapEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr window;
			public IntPtr colormap;
			public bool c_new;
			public int state;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XClientMessageEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr window;
			public IntPtr message_type;
			public int format;
			public IntPtr ptr1;
			public IntPtr ptr2;
			public IntPtr ptr3;
			public IntPtr ptr4;
			public IntPtr ptr5;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XMappingEvent
		{
			public XEventName type;
			public IntPtr serial;
			public bool send_event;
			public IntPtr display;
			public IntPtr window;
			public int request;
			public int first_keycode;
			public int count;
		}

		/// <summary>
		/// 
		/// </summary>
		[StructLayout(LayoutKind.Sequential)]
		public struct XErrorEvent
		{
			/// <summary>
			/// 
			/// </summary>
			public XEventName type;

			/// <summary>
			/// 
			/// </summary>
			public IntPtr display;

			/// <summary>
			/// 
			/// </summary>
			public IntPtr resourceid;

			/// <summary>
			/// 
			/// </summary>
			public IntPtr serial;

			/// <summary>
			/// 
			/// </summary>
			public byte error_code;

			/// <summary>
			/// 
			/// </summary>
			public XRequest request_code;

			/// <summary>
			/// 
			/// </summary>
			public byte minor_code;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XEventPad
		{
			public IntPtr pad0;
			public IntPtr pad1;
			public IntPtr pad2;
			public IntPtr pad3;
			public IntPtr pad4;
			public IntPtr pad5;
			public IntPtr pad6;
			public IntPtr pad7;
			public IntPtr pad8;
			public IntPtr pad9;
			public IntPtr pad10;
			public IntPtr pad11;
			public IntPtr pad12;
			public IntPtr pad13;
			public IntPtr pad14;
			public IntPtr pad15;
			public IntPtr pad16;
			public IntPtr pad17;
			public IntPtr pad18;
			public IntPtr pad19;
			public IntPtr pad20;
			public IntPtr pad21;
			public IntPtr pad22;
			public IntPtr pad23;
		}

		[StructLayout(LayoutKind.Explicit)]
		internal struct XEvent
		{
			[FieldOffset(0)]
			public XEventName type;
			[FieldOffset(0)]
			public XAnyEvent AnyEvent;
			[FieldOffset(0)]
			public XKeyEvent KeyEvent;
			[FieldOffset(0)]
			public XButtonEvent ButtonEvent;
			[FieldOffset(0)]
			public XMotionEvent MotionEvent;
			[FieldOffset(0)]
			public XCrossingEvent CrossingEvent;
			[FieldOffset(0)]
			public XFocusChangeEvent FocusChangeEvent;
			[FieldOffset(0)]
			public XExposeEvent ExposeEvent;
			[FieldOffset(0)]
			public XGraphicsExposeEvent GraphicsExposeEvent;
			[FieldOffset(0)]
			public XNoExposeEvent NoExposeEvent;
			[FieldOffset(0)]
			public XVisibilityEvent VisibilityEvent;
			[FieldOffset(0)]
			public XCreateWindowEvent CreateWindowEvent;
			[FieldOffset(0)]
			public XDestroyWindowEvent DestroyWindowEvent;
			[FieldOffset(0)]
			public XUnmapEvent UnmapEvent;
			[FieldOffset(0)]
			public XMapEvent MapEvent;
			[FieldOffset(0)]
			public XMapRequestEvent MapRequestEvent;
			[FieldOffset(0)]
			public XReparentEvent ReparentEvent;
			[FieldOffset(0)]
			public XConfigureEvent ConfigureEvent;
			[FieldOffset(0)]
			public XGravityEvent GravityEvent;
			[FieldOffset(0)]
			public XResizeRequestEvent ResizeRequestEvent;
			[FieldOffset(0)]
			public XConfigureRequestEvent ConfigureRequestEvent;
			[FieldOffset(0)]
			public XCirculateEvent CirculateEvent;
			[FieldOffset(0)]
			public XCirculateRequestEvent CirculateRequestEvent;
			[FieldOffset(0)]
			public XPropertyEvent PropertyEvent;
			[FieldOffset(0)]
			public XSelectionClearEvent SelectionClearEvent;
			[FieldOffset(0)]
			public XSelectionRequestEvent SelectionRequestEvent;
			[FieldOffset(0)]
			public XSelectionEvent SelectionEvent;
			[FieldOffset(0)]
			public XColormapEvent ColormapEvent;
			[FieldOffset(0)]
			public XClientMessageEvent ClientMessageEvent;
			[FieldOffset(0)]
			public XMappingEvent MappingEvent;
			[FieldOffset(0)]
			public XErrorEvent ErrorEvent;
			[FieldOffset(0)]
			public XKeymapEvent KeymapEvent;

			//[MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst=24)]
			//[ FieldOffset(0) ] public int[] pad;
			[FieldOffset(0)]
			public XEventPad Pad;
			public override string ToString()
			{
				switch (type) {
					case XEventName.PropertyNotify:
						return ToString(PropertyEvent);
					case XEventName.ResizeRequest:
						return ToString(ResizeRequestEvent);
					case XEventName.ConfigureNotify:
						return ToString(ConfigureEvent);
					default:
						return type.ToString();
				}
			}

			public static string ToString(object ev)
			{
				string result = string.Empty;
				Type type = ev.GetType();
#if NETSTANDARD1_1 || NETSTANDARD1_4
				IEnumerable<FieldInfo> fields = type.GetTypeInfo().DeclaredFields;
#else
				FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
#endif
				foreach (FieldInfo field in fields) {
					if (result != string.Empty) {
						result += ", ";
					}
					object value = field.GetValue(ev);
					result += field.Name + "=" + (value?.ToString() ?? "<null>");
				}
				return type.Name + " (" + result + ")";
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[StructLayout(LayoutKind.Sequential)]
		public class XVisualInfo
		{
			/// <summary>
			/// 
			/// </summary>
			public IntPtr visual;

			/// <summary>
			/// 
			/// </summary>
			public IntPtr visualid;

			/// <summary>
			/// 
			/// </summary>
			public int screen;

			/// <summary>
			/// 
			/// </summary>
			public int depth;

			/// <summary>
			/// 
			/// </summary>
			public XVisualClass @class;

			/// <summary>
			/// 
			/// </summary>
			public long redMask;

			/// <summary>
			/// 
			/// </summary>
			public long greenMask;

			/// <summary>
			/// 
			/// </summary>
			public long blueMask;

			/// <summary>
			/// 
			/// </summary>
			public int colormap_size;

			/// <summary>
			/// 
			/// </summary>
			public int bits_per_rgb;

			/// <summary>
			/// 
			/// </summary>
			/// <returns></returns>
			public override string ToString()
			{
				return String.Format(
					"XVisualInfo {{ visual=0x{0} id=0x{1}, screen={2}, depth={3}, class={4} colormap_size={5} bits_per_rgb={6} }}",
					visual.ToString("X"), visualid.ToString("X"), screen, depth,
					@class, colormap_size, bits_per_rgb
				);
			}
		}

		public enum XVisualClass : int
		{
			StaticGray = 0,
			GrayScale = 1,
			StaticColor = 2,
			PseudoColor = 3,
			TrueColor = 4,
			DirectColor = 5
		}

		/// <summary>
		/// 
		/// </summary>
		[StructLayout(LayoutKind.Sequential)]
		public struct XSetWindowAttributes
		{
			/// <summary>
			/// 
			/// </summary>
			public IntPtr background_pixmap;

			/// <summary>
			/// 
			/// </summary>
			public IntPtr background_pixel;

			/// <summary>
			/// 
			/// </summary>
			public IntPtr border_pixmap;

			/// <summary>
			/// 
			/// </summary>
			public IntPtr border_pixel;

			/// <summary>
			/// 
			/// </summary>
			public Gravity bit_gravity;

			/// <summary>
			/// 
			/// </summary>
			public Gravity win_gravity;

			/// <summary>
			/// 
			/// </summary>
			public int backing_store;

			/// <summary>
			/// 
			/// </summary>
			public IntPtr backing_planes;

			/// <summary>
			/// 
			/// </summary>
			public IntPtr backing_pixel;

			/// <summary>
			/// 
			/// </summary>
			public bool save_under;

			/// <summary>
			/// 
			/// </summary>
			public IntPtr event_mask;

			/// <summary>
			/// 
			/// </summary>
			public IntPtr do_not_propagate_mask;

			/// <summary>
			/// 
			/// </summary>
			public bool override_redirect;

			/// <summary>
			/// 
			/// </summary>
			public IntPtr colormap;

			/// <summary>
			/// 
			/// </summary>
			public IntPtr cursor;

			/// <summary>
			/// 
			/// </summary>
			/// <returns></returns>
			public override string ToString()
			{
                StringBuilder sb = new StringBuilder();

                sb.Append("XSetWindowAttributes {");
                if (background_pixmap != IntPtr.Zero)
                    sb.Append(" background_pixmap=0x" + background_pixmap.ToString("X"));
				if (background_pixel != IntPtr.Zero)
					sb.Append(" background_pixel=0x" + background_pixel.ToString("X"));
				if (border_pixmap != IntPtr.Zero)
					sb.Append(" border_pixmap=0x" + border_pixmap.ToString("X"));
				if (backing_store != 0)
					sb.Append(" backing_store=" + backing_store);
				if (backing_planes != IntPtr.Zero)
					sb.Append(" backing_planes=0x" + backing_planes.ToString("X"));
				if (backing_pixel != IntPtr.Zero)
					sb.Append(" backing_pixel=0x" + backing_pixel.ToString("X"));
				if (save_under)
					sb.Append(" save_under=true");
				if (event_mask != IntPtr.Zero)
					sb.Append(" event_mask=0x" + event_mask.ToString("X"));
				if (do_not_propagate_mask != IntPtr.Zero)
					sb.Append(" do_not_propagate_mask=0x" + do_not_propagate_mask.ToString("X"));
				if (override_redirect)
					sb.Append(" override_redirect=true");
				if (colormap != IntPtr.Zero)
					sb.Append(" colormap=0x" + colormap.ToString("X"));
				if (cursor != IntPtr.Zero)
					sb.Append(" cursor=0x" + cursor.ToString("X"));
                sb.Append("}");

                return (sb.ToString());
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XWindowAttributes
		{
			public int x;
			public int y;
			public int width;
			public int height;
			public int border_width;
			public int depth;
			public IntPtr visual;
			public IntPtr root;
			public int c_class;
			public Gravity bit_gravity;
			public Gravity win_gravity;
			public int backing_store;
			public IntPtr backing_planes;
			public IntPtr backing_pixel;
			public bool save_under;
			public IntPtr colormap;
			public bool map_installed;
			public MapState map_state;
			public IntPtr all_event_masks;
			public IntPtr your_event_mask;
			public IntPtr do_not_propagate_mask;
			public bool override_direct;
			public IntPtr screen;

			public override string ToString()
			{
				return XEvent.ToString(this);
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XTextProperty
		{
			public string value;
			public IntPtr encoding;
			public int format;
			public IntPtr nitems;
		}

		internal enum XWindowClass
		{
			InputOutput = 1,
			InputOnly = 2
		}

		public enum XEventName
		{
			KeyPress = 2,
			KeyRelease = 3,
			ButtonPress = 4,
			ButtonRelease = 5,
			MotionNotify = 6,
			EnterNotify = 7,
			LeaveNotify = 8,
			FocusIn = 9,
			FocusOut = 10,
			KeymapNotify = 11,
			Expose = 12,
			GraphicsExpose = 13,
			NoExpose = 14,
			VisibilityNotify = 15,
			CreateNotify = 16,
			DestroyNotify = 17,
			UnmapNotify = 18,
			MapNotify = 19,
			MapRequest = 20,
			ReparentNotify = 21,
			ConfigureNotify = 22,
			ConfigureRequest = 23,
			GravityNotify = 24,
			ResizeRequest = 25,
			CirculateNotify = 26,
			CirculateRequest = 27,
			PropertyNotify = 28,
			SelectionClear = 29,
			SelectionRequest = 30,
			SelectionNotify = 31,
			ColormapNotify = 32,
			ClientMessage = 33,
			MappingNotify = 34,

			LASTEvent
		}

		[Flags]
		internal enum SetWindowValuemask
		{
			Nothing = 0,
			BackPixmap = 1,
			BackPixel = 2,
			BorderPixmap = 4,
			BorderPixel = 8,
			BitGravity = 16,
			WinGravity = 32,
			BackingStore = 64,
			BackingPlanes = 128,
			BackingPixel = 256,
			OverrideRedirect = 512,
			SaveUnder = 1024,
			EventMask = 2048,
			DontPropagate = 4096,
			ColorMap = 8192,
			Cursor = 16384
		}

		internal enum CreateWindowArgs
		{
			CopyFromParent = 0,
			ParentRelative = 1,
			InputOutput = 1,
			InputOnly = 2
		}

		public enum Gravity
		{
			ForgetGravity = 0,
			NorthWestGravity = 1,
			NorthGravity = 2,
			NorthEastGravity = 3,
			WestGravity = 4,
			CenterGravity = 5,
			EastGravity = 6,
			SouthWestGravity = 7,
			SouthGravity = 8,
			SouthEastGravity = 9,
			StaticGravity = 10
		}

		internal enum XKeySym : uint
		{
			XK_BackSpace = 0xFF08,
			XK_Tab = 0xFF09,
			XK_Clear = 0xFF0B,
			XK_Return = 0xFF0D,
			XK_Home = 0xFF50,
			XK_Left = 0xFF51,
			XK_Up = 0xFF52,
			XK_Right = 0xFF53,
			XK_Down = 0xFF54,
			XK_Page_Up = 0xFF55,
			XK_Page_Down = 0xFF56,
			XK_End = 0xFF57,
			XK_Begin = 0xFF58,
			XK_Menu = 0xFF67,
			XK_Shift_L = 0xFFE1,
			XK_Shift_R = 0xFFE2,
			XK_Control_L = 0xFFE3,
			XK_Control_R = 0xFFE4,
			XK_Caps_Lock = 0xFFE5,
			XK_Shift_Lock = 0xFFE6,
			XK_Meta_L = 0xFFE7,
			XK_Meta_R = 0xFFE8,
			XK_Alt_L = 0xFFE9,
			XK_Alt_R = 0xFFEA,
			XK_Super_L = 0xFFEB,
			XK_Super_R = 0xFFEC,
			XK_Hyper_L = 0xFFED,
			XK_Hyper_R = 0xFFEE,
		}

		[Flags]
		internal enum EventMask
		{
			NoEventMask = 0,
			KeyPressMask = 1 << 0,
			KeyReleaseMask = 1 << 1,
			ButtonPressMask = 1 << 2,
			ButtonReleaseMask = 1 << 3,
			EnterWindowMask = 1 << 4,
			LeaveWindowMask = 1 << 5,
			PointerMotionMask = 1 << 6,
			PointerMotionHintMask = 1 << 7,
			Button1MotionMask = 1 << 8,
			Button2MotionMask = 1 << 9,
			Button3MotionMask = 1 << 10,
			Button4MotionMask = 1 << 11,
			Button5MotionMask = 1 << 12,
			ButtonMotionMask = 1 << 13,
			KeymapStateMask = 1 << 14,
			ExposureMask = 1 << 15,
			VisibilityChangeMask = 1 << 16,
			StructureNotifyMask = 1 << 17,
			ResizeRedirectMask = 1 << 18,
			SubstructureNotifyMask = 1 << 19,
			SubstructureRedirectMask = 1 << 20,
			FocusChangeMask = 1 << 21,
			PropertyChangeMask = 1 << 22,
			ColormapChangeMask = 1 << 23,
			OwnerGrabButtonMask = 1 << 24
		}

		internal enum GrabMode
		{
			GrabModeSync = 0,
			GrabModeAsync = 1
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XStandardColormap
		{
			public IntPtr colormap;
			public IntPtr red_max;
			public IntPtr red_mult;
			public IntPtr green_max;
			public IntPtr green_mult;
			public IntPtr blue_max;
			public IntPtr blue_mult;
			public IntPtr base_pixel;
			public IntPtr visualid;
			public IntPtr killid;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 2)]
		internal struct XColor
		{
			public IntPtr pixel;
			public ushort red;
			public ushort green;
			public ushort blue;
			public byte flags;
			public byte pad;
		}

		internal enum Atom
		{
			AnyPropertyType = 0,
			XA_PRIMARY = 1,
			XA_SECONDARY = 2,
			XA_ARC = 3,
			XA_ATOM = 4,
			XA_BITMAP = 5,
			XA_CARDINAL = 6,
			XA_COLORMAP = 7,
			XA_CURSOR = 8,
			XA_CUT_BUFFER0 = 9,
			XA_CUT_BUFFER1 = 10,
			XA_CUT_BUFFER2 = 11,
			XA_CUT_BUFFER3 = 12,
			XA_CUT_BUFFER4 = 13,
			XA_CUT_BUFFER5 = 14,
			XA_CUT_BUFFER6 = 15,
			XA_CUT_BUFFER7 = 16,
			XA_DRAWABLE = 17,
			XA_FONT = 18,
			XA_INTEGER = 19,
			XA_PIXMAP = 20,
			XA_POINT = 21,
			XA_RECTANGLE = 22,
			XA_RESOURCE_MANAGER = 23,
			XA_RGB_COLOR_MAP = 24,
			XA_RGB_BEST_MAP = 25,
			XA_RGB_BLUE_MAP = 26,
			XA_RGB_DEFAULT_MAP = 27,
			XA_RGB_GRAY_MAP = 28,
			XA_RGB_GREEN_MAP = 29,
			XA_RGB_RED_MAP = 30,
			XA_STRING = 31,
			XA_VISUALID = 32,
			XA_WINDOW = 33,
			XA_WM_COMMAND = 34,
			XA_WM_HINTS = 35,
			XA_WM_CLIENT_MACHINE = 36,
			XA_WM_ICON_NAME = 37,
			XA_WM_ICON_SIZE = 38,
			XA_WM_NAME = 39,
			XA_WM_NORMAL_HINTS = 40,
			XA_WM_SIZE_HINTS = 41,
			XA_WM_ZOOM_HINTS = 42,
			XA_MIN_SPACE = 43,
			XA_NORM_SPACE = 44,
			XA_MAX_SPACE = 45,
			XA_END_SPACE = 46,
			XA_SUPERSCRIPT_X = 47,
			XA_SUPERSCRIPT_Y = 48,
			XA_SUBSCRIPT_X = 49,
			XA_SUBSCRIPT_Y = 50,
			XA_UNDERLINE_POSITION = 51,
			XA_UNDERLINE_THICKNESS = 52,
			XA_STRIKEOUT_ASCENT = 53,
			XA_STRIKEOUT_DESCENT = 54,
			XA_ITALIC_ANGLE = 55,
			XA_X_HEIGHT = 56,
			XA_QUAD_WIDTH = 57,
			XA_WEIGHT = 58,
			XA_POINT_SIZE = 59,
			XA_RESOLUTION = 60,
			XA_COPYRIGHT = 61,
			XA_NOTICE = 62,
			XA_FONT_NAME = 63,
			XA_FAMILY_NAME = 64,
			XA_FULL_NAME = 65,
			XA_CAP_HEIGHT = 66,
			XA_WM_CLASS = 67,
			XA_WM_TRANSIENT_FOR = 68,

			XA_LAST_PREDEFINED = 68
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XScreen
		{
			public IntPtr ext_data;
			public IntPtr display;
			public IntPtr root;
			public int width;
			public int height;
			public int mwidth;
			public int mheight;
			public int ndepths;
			public IntPtr depths;
			public int root_depth;
			public IntPtr root_visual;
			public IntPtr default_gc;
			public IntPtr cmap;
			public IntPtr white_pixel;
			public IntPtr black_pixel;
			public int max_maps;
			public int min_maps;
			public int backing_store;
			public bool save_unders;
			public IntPtr root_input_mask;
		}

		[Flags]
		internal enum ChangeWindowFlags
		{
			CWX = 1 << 0,
			CWY = 1 << 1,
			CWWidth = 1 << 2,
			CWHeight = 1 << 3,
			CWBorderWidth = 1 << 4,
			CWSibling = 1 << 5,
			CWStackMode = 1 << 6
		}

		internal enum StackMode
		{
			Above = 0,
			Below = 1,
			TopIf = 2,
			BottomIf = 3,
			Opposite = 4
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XWindowChanges
		{
			public int x;
			public int y;
			public int width;
			public int height;
			public int border_width;
			public IntPtr sibling;
			public StackMode stack_mode;
		}

		[Flags]
		internal enum ColorFlags
		{
			DoRed = 1 << 0,
			DoGreen = 1 << 1,
			DoBlue = 1 << 2
		}

		internal enum NotifyMode
		{
			NotifyNormal = 0,
			NotifyGrab = 1,
			NotifyUngrab = 2
		}

		internal enum NotifyDetail
		{
			NotifyAncestor = 0,
			NotifyVirtual = 1,
			NotifyInferior = 2,
			NotifyNonlinear = 3,
			NotifyNonlinearVirtual = 4,
			NotifyPointer = 5,
			NotifyPointerRoot = 6,
			NotifyDetailNone = 7
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct MotifWmHints
		{
			public IntPtr flags;
			public IntPtr functions;
			public IntPtr decorations;
			public IntPtr input_mode;
			public IntPtr status;

			public override string ToString()
			{
				return string.Format("MotifWmHints <flags={0}, functions={1}, decorations={2}, input_mode={3}, status={4}", (MotifFlags)flags.ToInt32(), (MotifFunctions)functions.ToInt32(), (MotifDecorations)decorations.ToInt32(), (MotifInputMode)input_mode.ToInt32(), status.ToInt32());
			}
		}

		[Flags]
		internal enum MotifFlags
		{
			Functions = 1,
			Decorations = 2,
			InputMode = 4,
			Status = 8
		}

		[Flags]
		internal enum MotifFunctions
		{
			All = 0x01,
			Resize = 0x02,
			Move = 0x04,
			Minimize = 0x08,
			Maximize = 0x10,
			Close = 0x20
		}

		[Flags]
		internal enum MotifDecorations
		{
			All = 0x01,
			Border = 0x02,
			ResizeH = 0x04,
			Title = 0x08,
			Menu = 0x10,
			Minimize = 0x20,
			Maximize = 0x40,

		}

		[Flags]
		internal enum MotifInputMode
		{
			Modeless = 0,
			ApplicationModal = 1,
			SystemModal = 2,
			FullApplicationModal = 3
		}

		[Flags]
		internal enum KeyMasks
		{
			ShiftMask = (1 << 0),
			LockMask = (1 << 1),
			ControlMask = (1 << 2),
			Mod1Mask = (1 << 3),
			Mod2Mask = (1 << 4),
			Mod3Mask = (1 << 5),
			Mod4Mask = (1 << 6),
			Mod5Mask = (1 << 7),

			ModMasks = Mod1Mask | Mod2Mask | Mod3Mask | Mod4Mask | Mod5Mask
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XModifierKeymap
		{
			public int max_keypermod;
			public IntPtr modifiermap;
		}

		internal enum PropertyMode
		{
			Replace = 0,
			Prepend = 1,
			Append = 2
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XKeyBoardState
		{
			public int key_click_percent;
			public int bell_percent;
			public uint bell_pitch, bell_duration;
			public IntPtr led_mask;
			public int global_auto_repeat;
			public AutoRepeats auto_repeats;

			[StructLayout(LayoutKind.Explicit)]
			public struct AutoRepeats
			{
				[FieldOffset(0)]
				public byte first;

				[FieldOffset(31)]
				public byte last;
			}
		}

		[Flags]
		internal enum GCFunction
		{
			GCFunction = 1 << 0,
			GCPlaneMask = 1 << 1,
			GCForeground = 1 << 2,
			GCBackground = 1 << 3,
			GCLineWidth = 1 << 4,
			GCLineStyle = 1 << 5,
			GCCapStyle = 1 << 6,
			GCJoinStyle = 1 << 7,
			GCFillStyle = 1 << 8,
			GCFillRule = 1 << 9,
			GCTile = 1 << 10,
			GCStipple = 1 << 11,
			GCTileStipXOrigin = 1 << 12,
			GCTileStipYOrigin = 1 << 13,
			GCFont = 1 << 14,
			GCSubwindowMode = 1 << 15,
			GCGraphicsExposures = 1 << 16,
			GCClipXOrigin = 1 << 17,
			GCClipYOrigin = 1 << 18,
			GCClipMask = 1 << 19,
			GCDashOffset = 1 << 20,
			GCDashList = 1 << 21,
			GCArcMode = 1 << 22
		}

		internal enum GCJoinStyle
		{
			JoinMiter = 0,
			JoinRound = 1,
			JoinBevel = 2
		}

		internal enum GCLineStyle
		{
			LineSolid = 0,
			LineOnOffDash = 1,
			LineDoubleDash = 2
		}

		internal enum GCCapStyle
		{
			CapNotLast = 0,
			CapButt = 1,
			CapRound = 2,
			CapProjecting = 3
		}

		internal enum GCFillStyle
		{
			FillSolid = 0,
			FillTiled = 1,
			FillStippled = 2,
			FillOpaqueStppled = 3
		}

		internal enum GCFillRule
		{
			EvenOddRule = 0,
			WindingRule = 1
		}

		internal enum GCArcMode
		{
			ArcChord = 0,
			ArcPieSlice = 1
		}

		internal enum GCSubwindowMode
		{
			ClipByChildren = 0,
			IncludeInferiors = 1
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XGCValues
		{
			public GXFunction function;
			public IntPtr plane_mask;
			public IntPtr foreground;
			public IntPtr background;
			public int line_width;
			public GCLineStyle line_style;
			public GCCapStyle cap_style;
			public GCJoinStyle join_style;
			public GCFillStyle fill_style;
			public GCFillRule fill_rule;
			public GCArcMode arc_mode;
			public IntPtr tile;
			public IntPtr stipple;
			public int ts_x_origin;
			public int ts_y_origin;
			public IntPtr font;
			public GCSubwindowMode subwindow_mode;
			public bool graphics_exposures;
			public int clip_x_origin;
			public int clib_y_origin;
			public IntPtr clip_mask;
			public int dash_offset;
			public byte dashes;
		}

		internal enum GXFunction
		{
			GXclear = 0x0,		/* 0 */
			GXand = 0x1,		/* src AND dst */
			GXandReverse = 0x2,		/* src AND NOT dst */
			GXcopy = 0x3,		/* src */
			GXandInverted = 0x4,		/* NOT src AND dst */
			GXnoop = 0x5,		/* dst */
			GXxor = 0x6,		/* src XOR dst */
			GXor = 0x7,		/* src OR dst */
			GXnor = 0x8,		/* NOT src AND NOT dst */
			GXequiv = 0x9,		/* NOT src XOR dst */
			GXinvert = 0xa,		/* NOT dst */
			GXorReverse = 0xb,		/* src OR NOT dst */
			GXcopyInverted = 0xc,		/* NOT src */
			GXorInverted = 0xd,		/* NOT src OR dst */
			GXnand = 0xe,		/* NOT src OR NOT dst */
			GXset = 0xf		/* 1 */
		}

		internal enum NetWindowManagerState
		{
			Remove = 0,
			Add = 1,
			Toggle = 2
		}

		internal enum RevertTo
		{
			None = 0,
			PointerRoot = 1,
			Parent = 2
		}

		internal enum MapState
		{
			IsUnmapped = 0,
			IsUnviewable = 1,
			IsViewable = 2
		}

		internal enum CursorFontShape
		{
			XC_X_cursor = 0,
			XC_arrow = 2,
			XC_based_arrow_down = 4,
			XC_based_arrow_up = 6,
			XC_boat = 8,
			XC_bogosity = 10,
			XC_bottom_left_corner = 12,
			XC_bottom_right_corner = 14,
			XC_bottom_side = 16,
			XC_bottom_tee = 18,
			XC_box_spiral = 20,
			XC_center_ptr = 22,

			XC_circle = 24,
			XC_clock = 26,
			XC_coffee_mug = 28,
			XC_cross = 30,
			XC_cross_reverse = 32,
			XC_crosshair = 34,
			XC_diamond_cross = 36,
			XC_dot = 38,
			XC_dotbox = 40,
			XC_double_arrow = 42,
			XC_draft_large = 44,
			XC_draft_small = 46,

			XC_draped_box = 48,
			XC_exchange = 50,
			XC_fleur = 52,
			XC_gobbler = 54,
			XC_gumby = 56,
			XC_hand1 = 58,
			XC_hand2 = 60,
			XC_heart = 62,
			XC_icon = 64,
			XC_iron_cross = 66,
			XC_left_ptr = 68,
			XC_left_side = 70,

			XC_left_tee = 72,
			XC_left_button = 74,
			XC_ll_angle = 76,
			XC_lr_angle = 78,
			XC_man = 80,
			XC_middlebutton = 82,
			XC_mouse = 84,
			XC_pencil = 86,
			XC_pirate = 88,
			XC_plus = 90,
			XC_question_arrow = 92,
			XC_right_ptr = 94,

			XC_right_side = 96,
			XC_right_tee = 98,
			XC_rightbutton = 100,
			XC_rtl_logo = 102,
			XC_sailboat = 104,
			XC_sb_down_arrow = 106,
			XC_sb_h_double_arrow = 108,
			XC_sb_left_arrow = 110,
			XC_sb_right_arrow = 112,
			XC_sb_up_arrow = 114,
			XC_sb_v_double_arrow = 116,
			XC_sb_shuttle = 118,

			XC_sizing = 120,
			XC_spider = 122,
			XC_spraycan = 124,
			XC_star = 126,
			XC_target = 128,
			XC_tcross = 130,
			XC_top_left_arrow = 132,
			XC_top_left_corner = 134,
			XC_top_right_corner = 136,
			XC_top_side = 138,
			XC_top_tee = 140,
			XC_trek = 142,

			XC_ul_angle = 144,
			XC_umbrella = 146,
			XC_ur_angle = 148,
			XC_watch = 150,
			XC_xterm = 152,
			XC_num_glyphs = 154
		}

		internal enum SystrayRequest
		{
			SYSTEM_TRAY_REQUEST_DOCK = 0,
			SYSTEM_TRAY_BEGIN_MESSAGE = 1,
			SYSTEM_TRAY_CANCEL_MESSAGE = 2
		}

		[Flags]
		internal enum XSizeHintsFlags
		{
			USPosition = (1 << 0),
			USSize = (1 << 1),
			PPosition = (1 << 2),
			PSize = (1 << 3),
			PMinSize = (1 << 4),
			PMaxSize = (1 << 5),
			PResizeInc = (1 << 6),
			PAspect = (1 << 7),
			PAllHints = (PPosition | PSize | PMinSize | PMaxSize | PResizeInc | PAspect),
			PBaseSize = (1 << 8),
			PWinGravity = (1 << 9),
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XSizeHints
		{
			public IntPtr flags;
			public int x;
			public int y;
			public int width;
			public int height;
			public int min_width;
			public int min_height;
			public int max_width;
			public int max_height;
			public int width_inc;
			public int height_inc;
			public int min_aspect_x;
			public int min_aspect_y;
			public int max_aspect_x;
			public int max_aspect_y;
			public int base_width;
			public int base_height;
			public int win_gravity;
		}

		[Flags]
		internal enum XWMHintsFlags
		{
			InputHint = (1 << 0),
			StateHint = (1 << 1),
			IconPixmapHint = (1 << 2),
			IconWindowHint = (1 << 3),
			IconPositionHint = (1 << 4),
			IconMaskHint = (1 << 5),
			WindowGroupHint = (1 << 6),
			AllHints = (InputHint | StateHint | IconPixmapHint | IconWindowHint | IconPositionHint | IconMaskHint | WindowGroupHint)
		}

		internal enum XInitialState
		{
			DontCareState = 0,
			NormalState = 1,
			ZoomState = 2,
			IconicState = 3,
			InactiveState = 4
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XWMHints
		{
			public IntPtr flags;
			public bool input;
			public XInitialState initial_state;
			public IntPtr icon_pixmap;
			public IntPtr icon_window;
			public int icon_x;
			public int icon_y;
			public IntPtr icon_mask;
			public IntPtr window_group;
		}

		[StructLayout(LayoutKind.Sequential)]
		internal struct XIconSize
		{
			public int min_width;
			public int min_height;
			public int max_width;
			public int max_height;
			public int width_inc;
			public int height_inc;
		}

		internal delegate int XErrorHandler(IntPtr DisplayHandle, ref XErrorEvent error_event);

		/// <summary>
		/// 
		/// </summary>
		public enum XRequest : byte
		{
			/// <summary>
			/// 
			/// </summary>
			X_CreateWindow = 1,

			/// <summary>
			/// 
			/// </summary>
			X_ChangeWindowAttributes = 2,
			
			/// <summary>
			/// 
			/// </summary>
			X_GetWindowAttributes = 3,
			
			/// <summary>
			/// 
			/// </summary>
			X_DestroyWindow = 4,
			
			/// <summary>
			/// 
			/// </summary>
			X_DestroySubwindows = 5,
			
			/// <summary>
			/// 
			/// </summary>
			X_ChangeSaveSet = 6,
			
			/// <summary>
			/// 
			/// </summary>
			X_ReparentWindow = 7,
			
			/// <summary>
			/// 
			/// </summary>
			X_MapWindow = 8,
			
			/// <summary>
			/// 
			/// </summary>
			X_MapSubwindows = 9,
			
			/// <summary>
			/// 
			/// </summary>
			X_UnmapWindow = 10,
			
			/// <summary>
			/// 
			/// </summary>
			X_UnmapSubwindows = 11,
			
			/// <summary>
			/// 
			/// </summary>
			X_ConfigureWindow = 12,
			
			/// <summary>
			/// 
			/// </summary>
			X_CirculateWindow = 13,
			
			/// <summary>
			/// 
			/// </summary>
			X_GetGeometry = 14,
			
			/// <summary>
			/// 
			/// </summary>
			X_QueryTree = 15,
			
			/// <summary>
			/// 
			/// </summary>
			X_InternAtom = 16,
			
			/// <summary>
			/// 
			/// </summary>
			X_GetAtomName = 17,
			
			/// <summary>
			/// 
			/// </summary>
			X_ChangeProperty = 18,
			
			/// <summary>
			/// 
			/// </summary>
			X_DeleteProperty = 19,
			
			/// <summary>
			/// 
			/// </summary>
			X_GetProperty = 20,
			
			/// <summary>
			/// 
			/// </summary>
			X_ListProperties = 21,
			
			/// <summary>
			/// 
			/// </summary>
			X_SetSelectionOwner = 22,
			
			/// <summary>
			/// 
			/// </summary>
			X_GetSelectionOwner = 23,
			
			/// <summary>
			/// 
			/// </summary>
			X_ConvertSelection = 24,
			
			/// <summary>
			/// 
			/// </summary>
			X_SendEvent = 25,
			
			/// <summary>
			/// 
			/// </summary>
			X_GrabPointer = 26,
			
			/// <summary>
			/// 
			/// </summary>
			X_UngrabPointer = 27,
			
			/// <summary>
			/// 
			/// </summary>
			X_GrabButton = 28,
			
			/// <summary>
			/// 
			/// </summary>
			X_UngrabButton = 29,
			
			/// <summary>
			/// 
			/// </summary>
			X_ChangeActivePointerGrab = 30,
			
			/// <summary>
			/// 
			/// </summary>
			X_GrabKeyboard = 31,
			
			/// <summary>
			/// 
			/// </summary>
			X_UngrabKeyboard = 32,
			
			/// <summary>
			/// 
			/// </summary>
			X_GrabKey = 33,
			
			/// <summary>
			/// 
			/// </summary>
			X_UngrabKey = 34,
			
			/// <summary>
			/// 
			/// </summary>
			X_AllowEvents = 35,
			
			/// <summary>
			/// 
			/// </summary>
			X_GrabServer = 36,
			
			/// <summary>
			/// 
			/// </summary>
			X_UngrabServer = 37,
			
			/// <summary>
			/// 
			/// </summary>
			X_QueryPointer = 38,
			
			/// <summary>
			/// 
			/// </summary>
			X_GetMotionEvents = 39,
			
			/// <summary>
			/// 
			/// </summary>
			X_TranslateCoords = 40,
			
			/// <summary>
			/// 
			/// </summary>
			X_WarpPointer = 41,
			
			/// <summary>
			/// 
			/// </summary>
			X_SetInputFocus = 42,
			
			/// <summary>
			/// 
			/// </summary>
			X_GetInputFocus = 43,
			
			/// <summary>
			/// 
			/// </summary>
			X_QueryKeymap = 44,
			
			/// <summary>
			/// 
			/// </summary>
			X_OpenFont = 45,
			
			/// <summary>
			/// 
			/// </summary>
			X_CloseFont = 46,
			
			/// <summary>
			/// 
			/// </summary>
			X_QueryFont = 47,
			
			/// <summary>
			/// 
			/// </summary>
			X_QueryTextExtents = 48,
			
			/// <summary>
			/// 
			/// </summary>
			X_ListFonts = 49,
			
			/// <summary>
			/// 
			/// </summary>
			X_ListFontsWithInfo = 50,
			
			/// <summary>
			/// 
			/// </summary>
			X_SetFontPath = 51,
			
			/// <summary>
			/// 
			/// </summary>
			X_GetFontPath = 52,
			
			/// <summary>
			/// 
			/// </summary>
			X_CreatePixmap = 53,
			
			/// <summary>
			/// 
			/// </summary>
			X_FreePixmap = 54,
			
			/// <summary>
			/// 
			/// </summary>
			X_CreateGC = 55,
			
			/// <summary>
			/// 
			/// </summary>
			X_ChangeGC = 56,
			
			/// <summary>
			/// 
			/// </summary>
			X_CopyGC = 57,
			
			/// <summary>
			/// 
			/// </summary>
			X_SetDashes = 58,
			
			/// <summary>
			/// 
			/// </summary>
			X_SetClipRectangles = 59,
			
			/// <summary>
			/// 
			/// </summary>
			X_FreeGC = 60,
			
			/// <summary>
			/// 
			/// </summary>
			X_ClearArea = 61,
			
			/// <summary>
			/// 
			/// </summary>
			X_CopyArea = 62,
			
			/// <summary>
			/// 
			/// </summary>
			X_CopyPlane = 63,
			
			/// <summary>
			/// 
			/// </summary>
			X_PolyPoint = 64,
			
			/// <summary>
			/// 
			/// </summary>
			X_PolyLine = 65,
			
			/// <summary>
			/// 
			/// </summary>
			X_PolySegment = 66,
			
			/// <summary>
			/// 
			/// </summary>
			X_PolyRectangle = 67,
			
			/// <summary>
			/// 
			/// </summary>
			X_PolyArc = 68,
			
			/// <summary>
			/// 
			/// </summary>
			X_FillPoly = 69,
			
			/// <summary>
			/// 
			/// </summary>
			X_PolyFillRectangle = 70,
			
			/// <summary>
			/// 
			/// </summary>
			X_PolyFillArc = 71,
			
			/// <summary>
			/// 
			/// </summary>
			X_PutImage = 72,
			
			/// <summary>
			/// 
			/// </summary>
			X_GetImage = 73,
			
			/// <summary>
			/// 
			/// </summary>
			X_PolyText8 = 74,
			
			/// <summary>
			/// 
			/// </summary>
			X_PolyText16 = 75,
			
			/// <summary>
			/// 
			/// </summary>
			X_ImageText8 = 76,
			
			/// <summary>
			/// 
			/// </summary>
			X_ImageText16 = 77,
			
			/// <summary>
			/// 
			/// </summary>
			X_CreateColormap = 78,
			
			/// <summary>
			/// 
			/// </summary>
			X_FreeColormap = 79,
			
			/// <summary>
			/// 
			/// </summary>
			X_CopyColormapAndFree = 80,
			
			/// <summary>
			/// 
			/// </summary>
			X_InstallColormap = 81,
			
			/// <summary>
			/// 
			/// </summary>
			X_UninstallColormap = 82,
			
			/// <summary>
			/// 
			/// </summary>
			X_ListInstalledColormaps = 83,
			
			/// <summary>
			/// 
			/// </summary>
			X_AllocColor = 84,
			
			/// <summary>
			/// 
			/// </summary>
			X_AllocNamedColor = 85,
			
			/// <summary>
			/// 
			/// </summary>
			X_AllocColorCells = 86,
			
			/// <summary>
			/// 
			/// </summary>
			X_AllocColorPlanes = 87,
			
			/// <summary>
			/// 
			/// </summary>
			X_FreeColors = 88,
			
			/// <summary>
			/// 
			/// </summary>
			X_StoreColors = 89,
			
			/// <summary>
			/// 
			/// </summary>
			X_StoreNamedColor = 90,
			
			/// <summary>
			/// 
			/// </summary>
			X_QueryColors = 91,
			
			/// <summary>
			/// 
			/// </summary>
			X_LookupColor = 92,
			
			/// <summary>
			/// 
			/// </summary>
			X_CreateCursor = 93,
			
			/// <summary>
			/// 
			/// </summary>
			X_CreateGlyphCursor = 94,
			
			/// <summary>
			/// 
			/// </summary>
			X_FreeCursor = 95,
			
			/// <summary>
			/// 
			/// </summary>
			X_RecolorCursor = 96,
			
			/// <summary>
			/// 
			/// </summary>
			X_QueryBestSize = 97,
			
			/// <summary>
			/// 
			/// </summary>
			X_QueryExtension = 98,
			
			/// <summary>
			/// 
			/// </summary>
			X_ListExtensions = 99,
			
			/// <summary>
			/// 
			/// </summary>
			X_ChangeKeyboardMapping = 100,
			
			/// <summary>
			/// 
			/// </summary>
			X_GetKeyboardMapping = 101,
			
			/// <summary>
			/// 
			/// </summary>
			X_ChangeKeyboardControl = 102,
			
			/// <summary>
			/// 
			/// </summary>
			X_GetKeyboardControl = 103,
			
			/// <summary>
			/// 
			/// </summary>
			X_Bell = 104,
			
			/// <summary>
			/// 
			/// </summary>
			X_ChangePointerControl = 105,
			
			/// <summary>
			/// 
			/// </summary>
			X_GetPointerControl = 106,
			
			/// <summary>
			/// 
			/// </summary>
			X_SetScreenSaver = 107,
			
			/// <summary>
			/// 
			/// </summary>
			X_GetScreenSaver = 108,
			
			/// <summary>
			/// 
			/// </summary>
			X_ChangeHosts = 109,
			
			/// <summary>
			/// 
			/// </summary>
			X_ListHosts = 110,
			
			/// <summary>
			/// 
			/// </summary>
			X_SetAccessControl = 111,
			
			/// <summary>
			/// 
			/// </summary>
			X_SetCloseDownMode = 112,
			
			/// <summary>
			/// 
			/// </summary>
			X_KillClient = 113,
			
			/// <summary>
			/// 
			/// </summary>
			X_RotateProperties = 114,
			
			/// <summary>
			/// 
			/// </summary>
			X_ForceScreenSaver = 115,
			
			/// <summary>
			/// 
			/// </summary>
			X_SetPointerMapping = 116,
			
			/// <summary>
			/// 
			/// </summary>
			X_GetPointerMapping = 117,
			
			/// <summary>
			/// 
			/// </summary>
			X_SetModifierMapping = 118,
			
			/// <summary>
			/// 
			/// </summary>
			X_GetModifierMapping = 119,
			
			/// <summary>
			/// 
			/// </summary>
			X_NoOperation = 127
		}

		[Flags]
		internal enum XIMProperties
		{
			XIMPreeditArea = 0x0001,
			XIMPreeditCallbacks = 0x0002,
			XIMPreeditPosition = 0x0004,
			XIMPreeditNothing = 0x0008,
			XIMPreeditNone = 0x0010,
			XIMStatusArea = 0x0100,
			XIMStatusCallbacks = 0x0200,
			XIMStatusNothing = 0x0400,
			XIMStatusNone = 0x0800,
		}

		[Flags]
		internal enum WindowType
		{
			Client = 1,
			Whole = 2,
			Both = 3
		}

		internal enum XEmbedMessage
		{
			EmbeddedNotify = 0,
			WindowActivate = 1,
			WindowDeactivate = 2,
			RequestFocus = 3,
			FocusIn = 4,
			FocusOut = 5,
			FocusNext = 6,
			FocusPrev = 7,
			/* 8-9 were used for XEMBED_GRAB_KEY/XEMBED_UNGRAB_KEY */
			ModalityOn = 10,
			ModalityOff = 11,
			RegisterAccelerator = 12,
			UnregisterAccelerator = 13,
			ActivateAccelerator = 14
		}

		/// <summary>
		/// Utility class for locking X11 threaded server.
		/// </summary>
		internal struct XLock : IDisposable
		{
			/// <summary>
			/// Initializes a new instance of the <see cref="XLock"/> struct.
			/// </summary>
			/// <param name='display'>
			/// Display.
			/// </param>
			/// <exception cref='ArgumentException'>
			/// Is thrown when an argument passed to a method is invalid.
			/// </exception>
			public XLock(IntPtr display)
			{
				if (display == IntPtr.Zero)
					throw new ArgumentException("invalid", "display");
				_LockedDisplay = display;

				if (DeviceContextGLX.IsMultithreadingInitialized)
					UnsafeNativeMethods.XLockDisplay(_LockedDisplay);
			}

			/// <summary>
			/// Releases all resource used by the <see cref="XLock"/> object.
			/// </summary>
			/// <remarks>
			/// Call <see cref="Dispose"/> when you are finished using the <see cref="XLock"/>. The
			/// <see cref="Dispose"/> method leaves the <see cref="XLock"/> in an unusable state. After calling
			/// <see cref="Dispose"/>, you must release all references to the <see cref="XLock"/> so the garbage
			/// collector can reclaim the memory that the <see cref="XLock"/> was occupying.
			/// </remarks>
			public void Dispose()
			{
				if (DeviceContextGLX.IsMultithreadingInitialized)
					UnsafeNativeMethods.XUnlockDisplay(_LockedDisplay);
			}

			/// <summary>
			/// The locked display.
			/// </summary>
			private readonly IntPtr _LockedDisplay;
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[DllImport("libX11", EntryPoint = "XOpenDisplay")]
			public extern static IntPtr XOpenDisplay(IntPtr display);
			[DllImport("libX11", EntryPoint = "XCloseDisplay")]
			public extern static int XCloseDisplay(IntPtr display);
			[DllImport("libX11", EntryPoint = "XSynchronize")]
			public extern static IntPtr XSynchronize(IntPtr display, bool onoff);
			[DllImport("libX11", EntryPoint = "XInitThreads")]
			public extern static int XInitThreads();
			[DllImport("libX11", EntryPoint = "XLockDisplay")]
			public static extern void XLockDisplay(IntPtr display);
			[DllImport("libX11", EntryPoint = "XUnlockDisplay")]
			public static extern void XUnlockDisplay(IntPtr display);
			[DllImport("libX11", EntryPoint = "XCreateWindow")]
			public extern static IntPtr XCreateWindow(IntPtr display, IntPtr parent, int x, int y, int width, int height, int border_width, int depth, int xclass, IntPtr visual, UIntPtr valuemask, ref XSetWindowAttributes attributes);
			[DllImport("libX11", EntryPoint = "XCreateSimpleWindow")]
			public extern static IntPtr XCreateSimpleWindow(IntPtr display, IntPtr parent, int x, int y, int width, int height, int border_width, UIntPtr border, UIntPtr background);
			[DllImport("libX11", EntryPoint = "XMapWindow")]
			public extern static int XMapWindow(IntPtr display, IntPtr window);
			[DllImport("libX11", EntryPoint = "XUnmapWindow")]
			public extern static int XUnmapWindow(IntPtr display, IntPtr window);
			[DllImport("libX11", EntryPoint = "XMapSubwindows")]
			public extern static int XMapSubindows(IntPtr display, IntPtr window);
			[DllImport("libX11", EntryPoint = "XUnmapSubwindows")]
			public extern static int XUnmapSubwindows(IntPtr display, IntPtr window);
			[DllImport("libX11", EntryPoint = "XRootWindow")]
			public extern static IntPtr XRootWindow(IntPtr display, int screen_number);
			[DllImport("libX11", EntryPoint = "XNextEvent")]
			public extern static IntPtr XNextEvent(IntPtr display, ref XEvent xevent);
			[DllImport("libX11")]
			public extern static int XConnectionNumber(IntPtr diplay);
			[DllImport("libX11")]
			public extern static int XPending(IntPtr diplay);
			[DllImport("libX11", EntryPoint = "XSelectInput")]
			public extern static IntPtr XSelectInput(IntPtr display, IntPtr window, IntPtr mask);

			[DllImport("libX11", EntryPoint = "XDestroyWindow")]
			public extern static int XDestroyWindow(IntPtr display, IntPtr window);

			[DllImport("libX11", EntryPoint = "XReparentWindow")]
			public extern static int XReparentWindow(IntPtr display, IntPtr window, IntPtr parent, int x, int y);
			[DllImport("libX11", EntryPoint = "XMoveResizeWindow")]
			public extern static int XMoveResizeWindow(IntPtr display, IntPtr window, int x, int y, int width, int height);

			[DllImport("libX11", EntryPoint = "XResizeWindow")]
			public extern static int XResizeWindow(IntPtr display, IntPtr window, int width, int height);

			[DllImport("libX11", EntryPoint = "XGetWindowAttributes")]
			public extern static int XGetWindowAttributes(IntPtr display, IntPtr window, ref XWindowAttributes attributes);

			[DllImport("libX11", EntryPoint = "XFlush")]
			public extern static int XFlush(IntPtr display);

			[DllImport("libX11", EntryPoint = "XSetWMName")]
			public extern static int XSetWMName(IntPtr display, IntPtr window, ref XTextProperty text_prop);

			[DllImport("libX11", EntryPoint = "XStoreName")]
			public extern static int XStoreName(IntPtr display, IntPtr window, string window_name);

			[DllImport("libX11", EntryPoint = "XFetchName")]
			public extern static int XFetchName(IntPtr display, IntPtr window, ref IntPtr window_name);

			[DllImport("libX11", EntryPoint = "XSendEvent")]
			public extern static int XSendEvent(IntPtr display, IntPtr window, bool propagate, IntPtr event_mask, ref XEvent send_event);

			[DllImport("libX11", EntryPoint = "XQueryTree")]
			public extern static int XQueryTree(IntPtr display, IntPtr window, out IntPtr root_return, out IntPtr parent_return, out IntPtr children_return, out int nchildren_return);

			[DllImport("libX11", EntryPoint = "XFree")]
			public extern static int XFree(IntPtr data);

			[DllImport("libX11", EntryPoint = "XRaiseWindow")]
			public extern static int XRaiseWindow(IntPtr display, IntPtr window);

			[DllImport("libX11", EntryPoint = "XLowerWindow")]
			public extern static uint XLowerWindow(IntPtr display, IntPtr window);

			[DllImport("libX11", EntryPoint = "XConfigureWindow")]
			public extern static uint XConfigureWindow(IntPtr display, IntPtr window, ChangeWindowFlags value_mask, ref XWindowChanges values);

			[DllImport("libX11", EntryPoint = "XInternAtom")]
			public extern static IntPtr XInternAtom(IntPtr display, string atom_name, bool only_if_exists);

			[DllImport("libX11", EntryPoint = "XInternAtoms")]
			public extern static int XInternAtoms(IntPtr display, string[] atom_names, int atom_count, bool only_if_exists, IntPtr[] atoms);

			[DllImport("libX11", EntryPoint = "XSetWMProtocols")]
			public extern static int XSetWMProtocols(IntPtr display, IntPtr window, IntPtr[] protocols, int count);

			[DllImport("libX11", EntryPoint = "XGrabPointer")]
			public extern static int XGrabPointer(IntPtr display, IntPtr window, bool owner_events, EventMask event_mask, GrabMode pointer_mode, GrabMode keyboard_mode, IntPtr confine_to, IntPtr cursor, IntPtr timestamp);

			[DllImport("libX11", EntryPoint = "XUngrabPointer")]
			public extern static int XUngrabPointer(IntPtr display, IntPtr timestamp);

			[DllImport("libX11", EntryPoint = "XQueryPointer")]
			public extern static bool XQueryPointer(IntPtr display, IntPtr window, out IntPtr root, out IntPtr child, out int root_x, out int root_y, out int win_x, out int win_y, out int keys_buttons);

			[DllImport("libX11", EntryPoint = "XTranslateCoordinates")]
			public extern static bool XTranslateCoordinates(IntPtr display, IntPtr src_w, IntPtr dest_w, int src_x, int src_y, out int intdest_x_return, out int dest_y_return, out IntPtr child_return);

			[DllImport("libX11", EntryPoint = "XGetGeometry")]
			public extern static bool XGetGeometry(IntPtr display, IntPtr window, out IntPtr root, out int x, out int y, out int width, out int height, out int border_width, out int depth);

			[DllImport("libX11", EntryPoint = "XGetGeometry")]
			public extern static bool XGetGeometry(IntPtr display, IntPtr window, IntPtr root, out int x, out int y, out int width, out int height, IntPtr border_width, IntPtr depth);

			[DllImport("libX11", EntryPoint = "XGetGeometry")]
			public extern static bool XGetGeometry(IntPtr display, IntPtr window, IntPtr root, out int x, out int y, IntPtr width, IntPtr height, IntPtr border_width, IntPtr depth);

			[DllImport("libX11", EntryPoint = "XGetGeometry")]
			public extern static bool XGetGeometry(IntPtr display, IntPtr window, IntPtr root, IntPtr x, IntPtr y, out int width, out int height, IntPtr border_width, IntPtr depth);

			[DllImport("libX11", EntryPoint = "XWarpPointer")]
			public extern static uint XWarpPointer(IntPtr display, IntPtr src_w, IntPtr dest_w, int src_x, int src_y, uint src_width, uint src_height, int dest_x, int dest_y);

			[DllImport("libX11", EntryPoint = "XClearWindow")]
			public extern static int XClearWindow(IntPtr display, IntPtr window);

			[DllImport("libX11", EntryPoint = "XClearArea")]
			public extern static int XClearArea(IntPtr display, IntPtr window, int x, int y, int width, int height, bool exposures);

			// Colormaps
			[DllImport("libX11", EntryPoint = "XDefaultScreenOfDisplay")]
			public extern static IntPtr XDefaultScreenOfDisplay(IntPtr display);

			[DllImport("libX11", EntryPoint = "XScreenNumberOfScreen")]
			public extern static int XScreenNumberOfScreen(IntPtr display, IntPtr Screen);

			[DllImport("libX11", EntryPoint = "XDefaultVisual")]
			public extern static IntPtr XDefaultVisual(IntPtr display, int screen_number);

			[DllImport("libX11", EntryPoint = "XDefaultDepth")]
			public extern static uint XDefaultDepth(IntPtr display, int screen_number);

			[DllImport("libX11", EntryPoint = "XDefaultScreen")]
			public extern static int XDefaultScreen(IntPtr display);

			[DllImport("libX11", EntryPoint = "XDefaultColormap")]
			public extern static IntPtr XDefaultColormap(IntPtr display, int screen_number);

			[DllImport("libX11", EntryPoint = "XCreateColormap")]
			public extern static IntPtr XCreateColormap(IntPtr display, IntPtr w, IntPtr visual, int alloc);

			[DllImport("libX11", EntryPoint = "XLookupColor")]
			public extern static int XLookupColor(IntPtr display, IntPtr Colormap, string Coloranem, ref XColor exact_def_color, ref XColor screen_def_color);

			[DllImport("libX11", EntryPoint = "XAllocColor")]
			public extern static int XAllocColor(IntPtr display, IntPtr Colormap, ref XColor colorcell_def);

			[DllImport("libX11", EntryPoint = "XSetTransientForHint")]
			public extern static int XSetTransientForHint(IntPtr display, IntPtr window, IntPtr prop_window);

			[DllImport("libX11", EntryPoint = "XChangeProperty")]
			public extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, ref MotifWmHints data, int nelements);

			[DllImport("libX11", EntryPoint = "XChangeProperty")]
			public extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, ref uint value, int nelements);

			[DllImport("libX11", EntryPoint = "XChangeProperty")]
			public extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, ref IntPtr value, int nelements);

			[DllImport("libX11", EntryPoint = "XChangeProperty")]
			public extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, uint[] data, int nelements);

			[DllImport("libX11", EntryPoint = "XChangeProperty")]
			public extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, int[] data, int nelements);

			[DllImport("libX11", EntryPoint = "XChangeProperty")]
			public extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, IntPtr[] data, int nelements);

			[DllImport("libX11", EntryPoint = "XChangeProperty")]
			public extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, IntPtr atoms, int nelements);

			[DllImport("libX11", EntryPoint = "XChangeProperty", CharSet = CharSet.Ansi)]
			public extern static int XChangeProperty(IntPtr display, IntPtr window, IntPtr property, IntPtr type, int format, PropertyMode mode, string text, int text_length);

			[DllImport("libX11", EntryPoint = "XDeleteProperty")]
			public extern static int XDeleteProperty(IntPtr display, IntPtr window, IntPtr property);

			// Drawing
			[DllImport("libX11", EntryPoint = "XCreateGC")]
			public extern static IntPtr XCreateGC(IntPtr display, IntPtr window, IntPtr valuemask, ref XGCValues values);

			[DllImport("libX11", EntryPoint = "XFreeGC")]
			public extern static int XFreeGC(IntPtr display, IntPtr gc);

			[DllImport("libX11", EntryPoint = "XSetFunction")]
			public extern static int XSetFunction(IntPtr display, IntPtr gc, GXFunction function);

			[DllImport("libX11", EntryPoint = "XSetLineAttributes")]
			public extern static int XSetLineAttributes(IntPtr display, IntPtr gc, int line_width, GCLineStyle line_style, GCCapStyle cap_style, GCJoinStyle join_style);

			[DllImport("libX11", EntryPoint = "XDrawLine")]
			public extern static int XDrawLine(IntPtr display, IntPtr drawable, IntPtr gc, int x1, int y1, int x2, int y2);

			[DllImport("libX11", EntryPoint = "XDrawRectangle")]
			public extern static int XDrawRectangle(IntPtr display, IntPtr drawable, IntPtr gc, int x1, int y1, int width, int height);

			[DllImport("libX11", EntryPoint = "XFillRectangle")]
			public extern static int XFillRectangle(IntPtr display, IntPtr drawable, IntPtr gc, int x1, int y1, int width, int height);

			[DllImport("libX11", EntryPoint = "XSetWindowBackground")]
			public extern static int XSetWindowBackground(IntPtr display, IntPtr window, IntPtr background);

			[DllImport("libX11", EntryPoint = "XCopyArea")]
			public extern static int XCopyArea(IntPtr display, IntPtr src, IntPtr dest, IntPtr gc, int src_x, int src_y, int width, int height, int dest_x, int dest_y);

			[DllImport("libX11", EntryPoint = "XGetWindowProperty")]
			public extern static int XGetWindowProperty(IntPtr display, IntPtr window, IntPtr atom, IntPtr long_offset, IntPtr long_length, bool delete, IntPtr req_type, out IntPtr actual_type, out int actual_format, out IntPtr nitems, out IntPtr bytes_after, ref IntPtr prop);

			[DllImport("libX11", EntryPoint = "XSetInputFocus")]
			public extern static int XSetInputFocus(IntPtr display, IntPtr window, RevertTo revert_to, IntPtr time);

			[DllImport("libX11", EntryPoint = "XIconifyWindow")]
			public extern static int XIconifyWindow(IntPtr display, IntPtr window, int screen_number);

			[DllImport("libX11", EntryPoint = "XDefineCursor")]
			public extern static int XDefineCursor(IntPtr display, IntPtr window, IntPtr cursor);

			[DllImport("libX11", EntryPoint = "XUndefineCursor")]
			public extern static int XUndefineCursor(IntPtr display, IntPtr window);

			[DllImport("libX11", EntryPoint = "XFreeCursor")]
			public extern static int XFreeCursor(IntPtr display, IntPtr cursor);

			[DllImport("libX11", EntryPoint = "XCreateFontCursor")]
			public extern static IntPtr XCreateFontCursor(IntPtr display, CursorFontShape shape);

			[DllImport("libX11", EntryPoint = "XCreatePixmapCursor")]
			public extern static IntPtr XCreatePixmapCursor(IntPtr display, IntPtr source, IntPtr mask, ref XColor foreground_color, ref XColor background_color, int x_hot, int y_hot);

			[DllImport("libX11", EntryPoint = "XCreatePixmapFromBitmapData")]
			public extern static IntPtr XCreatePixmapFromBitmapData(IntPtr display, IntPtr drawable, byte[] data, int width, int height, IntPtr fg, IntPtr bg, int depth);

			[DllImport("libX11", EntryPoint = "XCreatePixmap")]
			public extern static IntPtr XCreatePixmap(IntPtr display, IntPtr d, int width, int height, int depth);

			[DllImport("libX11", EntryPoint = "XFreePixmap")]
			public extern static IntPtr XFreePixmap(IntPtr display, IntPtr pixmap);

			[DllImport("libX11", EntryPoint = "XQueryBestCursor")]
			public extern static int XQueryBestCursor(IntPtr display, IntPtr drawable, int width, int height, out int best_width, out int best_height);

			[DllImport("libX11", EntryPoint = "XQueryExtension")]
			public extern static int XQueryExtension(IntPtr display, string extension_name, ref int major, ref int first_event, ref int first_error);

			[DllImport("libX11", EntryPoint = "XWhitePixel")]
			public extern static IntPtr XWhitePixel(IntPtr display, int screen_no);

			[DllImport("libX11", EntryPoint = "XBlackPixel")]
			public extern static IntPtr XBlackPixel(IntPtr display, int screen_no);

			[DllImport("libX11", EntryPoint = "XGrabServer")]
			public extern static void XGrabServer(IntPtr display);

			[DllImport("libX11", EntryPoint = "XUngrabServer")]
			public extern static void XUngrabServer(IntPtr display);

			[DllImport("libX11", EntryPoint = "XGetWMNormalHints")]
			public extern static void XGetWMNormalHints(IntPtr display, IntPtr window, ref XSizeHints hints, out IntPtr supplied_return);

			[DllImport("libX11", EntryPoint = "XSetWMNormalHints")]
			public extern static void XSetWMNormalHints(IntPtr display, IntPtr window, ref XSizeHints hints);

			[DllImport("libX11", EntryPoint = "XSetZoomHints")]
			public extern static void XSetZoomHints(IntPtr display, IntPtr window, ref XSizeHints hints);

			[DllImport("libX11", EntryPoint = "XSetWMHints")]
			public extern static void XSetWMHints(IntPtr display, IntPtr window, ref XWMHints wmhints);

			[DllImport("libX11", EntryPoint = "XGetIconSizes")]
			public extern static int XGetIconSizes(IntPtr display, IntPtr window, out IntPtr size_list, out int count);

			[DllImport("libX11", EntryPoint = "XSetErrorHandler")]
			public extern static IntPtr XSetErrorHandler(XErrorHandler error_handler);

			[DllImport("libX11", EntryPoint = "XGetErrorText")]
			public extern static IntPtr XGetErrorText(IntPtr display, byte code, StringBuilder buffer, int length);

			[DllImport("libX11", EntryPoint = "XConvertSelection")]
			public extern static int XConvertSelection(IntPtr display, IntPtr selection, IntPtr target, IntPtr property, IntPtr requestor, IntPtr time);

			[DllImport("libX11", EntryPoint = "XGetSelectionOwner")]
			public extern static IntPtr XGetSelectionOwner(IntPtr display, IntPtr selection);

			[DllImport("libX11", EntryPoint = "XSetSelectionOwner")]
			public extern static int XSetSelectionOwner(IntPtr display, IntPtr selection, IntPtr owner, IntPtr time);

			[DllImport("libX11", EntryPoint = "XSetPlaneMask")]
			public extern static int XSetPlaneMask(IntPtr display, IntPtr gc, IntPtr mask);

			[DllImport("libX11", EntryPoint = "XSetForeground")]
			public extern static int XSetForeground(IntPtr display, IntPtr gc, UIntPtr foreground);

			[DllImport("libX11", EntryPoint = "XSetBackground")]
			public extern static int XSetBackground(IntPtr display, IntPtr gc, UIntPtr background);

			[DllImport("libX11", EntryPoint = "XBell")]
			public extern static int XBell(IntPtr display, int percent);

			[DllImport("libX11", EntryPoint = "XChangeActivePointerGrab")]
			public extern static int XChangeActivePointerGrab(IntPtr display, EventMask event_mask, IntPtr cursor, IntPtr time);

			[DllImport("libX11", EntryPoint = "XFilterEvent")]
			public extern static bool XFilterEvent(ref XEvent xevent, IntPtr window);

			[DllImport("libX11")]
			public extern static void XkbSetDetectableAutoRepeat(IntPtr display, bool detectable, IntPtr supported);

			[DllImport("libX11")]
			public extern static void XPeekEvent(IntPtr display, ref XEvent xevent);

		}

		#endregion

		#region X Wrappers

		public static IntPtr XOpenDisplay(IntPtr display)
		{
			IntPtr retValue;

			retValue = UnsafeNativeMethods.XOpenDisplay(display);
			LogCommand("XOpenDisplay", retValue, display);

			return (retValue);
		}


		public static int XDefaultScreen(IntPtr display)
		{
			int retValue;

			retValue = UnsafeNativeMethods.XDefaultScreen(display);
			LogCommand("XDefaultScreen", retValue, display);

			return (retValue);
		}

		public static int XFree(IntPtr data)
		{
			int retValue;

			retValue = UnsafeNativeMethods.XFree(data);
			LogCommand("XFree", retValue, data);

			return (retValue);
		}

		public static IntPtr XCreateColormap(IntPtr display, IntPtr w, IntPtr visual, int alloc)
		{
			IntPtr retValue;

			retValue = UnsafeNativeMethods.XCreateColormap(display, w, visual, alloc);
			LogCommand("XCreateColormap", retValue, display, w, visual, alloc);

			return (retValue);
		}

		public static IntPtr XCreateWindow(IntPtr display, IntPtr parent, int x, int y, int width, int height, int border_width, int depth, int xclass, IntPtr visual, UIntPtr valuemask, ref XSetWindowAttributes attributes)
		{
			IntPtr retValue;

			retValue = UnsafeNativeMethods.XCreateWindow(display, parent, x, y, width, height, border_width, depth, xclass, visual, valuemask, ref attributes);
			LogCommand("XCreateWindow", retValue, display, parent, x, y, width, height, border_width, depth, xclass, visual, valuemask, attributes);

			return (retValue);
		}

		public static IntPtr XRootWindow(IntPtr display, int screen_number)
		{
			IntPtr retValue;

			retValue = UnsafeNativeMethods.XRootWindow(display, screen_number);
			LogCommand("XRootWindow", retValue, display, screen_number);

			return (retValue);
		}

		#endregion

		#region Manually Crafted Wrappers

		/// <summary>
		/// [GL2.1] glXChooseVisual: return a visual that matches specified attributes
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="screen">
		/// Specifies the screen number.
		/// </param>
		/// <param name="attribList">
		/// Specifies a list of boolean attributes and integer attribute/value pairs. The last attribute must be Glx..
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static Glx.XVisualInfo ChooseVisual(IntPtr dpy, int screen, int[] attribList)
		{
			IntPtr retValue = ChooseVisualCore(dpy, screen, attribList);

			if (retValue != IntPtr.Zero)
				return ((XVisualInfo)Marshal.PtrToStructure(retValue, typeof(XVisualInfo)));
			else
				return (new XVisualInfo());
		}

		/// <summary>
		/// [GL2.1] glXCreateContext: create a new GLX rendering context
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="vis">
		/// Specifies the visual that defines the frame buffer resources available to the rendering context. It is a pointer to an 
		/// Glx.ualInfo structure, not a visual ID or a pointer to a Glx.al.
		/// </param>
		/// <param name="shareList">
		/// Specifies the context with which to share display lists. Glx. indicates that no sharing is to take place.
		/// </param>
		/// <param name="direct">
		/// Specifies whether rendering is to be done with a direct connection to the graphics system if possible (Glx.) or through 
		/// the X server (Glx.e).
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static IntPtr CreateContext(IntPtr dpy, XVisualInfo vis, IntPtr shareList, bool direct)
		{
			IntPtr retValue;

			using (MemoryLock visLock = new MemoryLock(vis)) {
				retValue = CreateContext(dpy, visLock.Address, shareList, direct);
			}

			return (retValue);
		}

		/// <summary>
		/// [GL2.1] glXCreateGLXPixmap: create an off-screen GLX rendering area
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="visual">
		/// A <see cref="T:Glx.XVisualInfo"/>.
		/// </param>
		/// <param name="pixmap">
		/// Specifies the X pixmap that will be used as the front left color buffer of the off-screen rendering area.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static IntPtr CreateGLXPixmap(IntPtr dpy, Glx.XVisualInfo visual, IntPtr pixmap)
		{
			IntPtr retValue;

			using (MemoryLock visLock = new MemoryLock(visual)) {
				retValue = CreateGLXPixmap(dpy, visLock.Address, pixmap);
			}

			return (retValue);
		}

		/// <summary>
		/// [GL2.1] glXGetConfig: return information about GLX visuals
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="visual">
		/// A <see cref="T:Glx.XVisualInfo"/>.
		/// </param>
		/// <param name="attrib">
		/// Specifies the visual attribute to be returned.
		/// </param>
		/// <param name="value">
		/// Returns the requested value.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static int GetConfig(IntPtr dpy, XVisualInfo visual, int attrib, [Out] int[] value)
		{
			int retValue;

			using (MemoryLock visLock = new MemoryLock(visual)) {
				retValue = GetConfig(dpy, visLock.Address, attrib, value);
			}

			return (retValue);
		}

		/// <summary>
		/// [GL2.1] glXGetVisualFromFBConfig: return visual that is associated with the frame buffer configuration
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="config">
		/// Specifies the GLX frame buffer configuration.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public static XVisualInfo GetVisualFromFBConfig(IntPtr dpy, IntPtr config)
		{
            IntPtr retValue = GetVisualFromFBConfigCore(dpy, config);

            // Marshal returned value
            XVisualInfo visualInfo = new XVisualInfo();

            if (retValue != IntPtr.Zero) {
                visualInfo = (XVisualInfo)Marshal.PtrToStructure(retValue, typeof(XVisualInfo));
                XFree(retValue);
            }

            return (visualInfo);
		}

		#endregion
	}
}
