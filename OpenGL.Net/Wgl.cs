
// Copyright (C) 2015 Luca Piccioni
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

#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Modern OpenGL bindings.
	/// </summary>
	public partial class Wgl : KhronosApi
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static Wgl()
		{
			LinkOpenGLProcImports(typeof(Wgl), out sImportMap, out sDelegates);
		}

		public static void Link()
		{
			LinkOpenGLProcImports(typeof(Wgl), out sImportMap, out sDelegates);
		}

		#endregion

		#region Imports/Delegates Management

		/// <summary>
		/// Synchronize Windows GL delegates.
		/// </summary>
		public static void SyncDelegates()
		{
			SynchDelegates(sImportMap, sDelegates);
		}

		/// <summary>
		/// Default import library.
		/// </summary>
		private const string Library = "opengl32.dll";

		/// <summary>
		/// Build a string->MethodInfo map to speed up extension loading.
		/// </summary>
		internal static SortedList<string, MethodInfo> sImportMap = null;

		/// <summary>
		/// Imported functions delegates.
		/// </summary>
		private static List<FieldInfo> sDelegates = null;

		#endregion

		#region Special API Implementations

		/// <summary>
		/// Utility method for testing whether wglGetExtensionsStringARB is implemented on the current system.
		/// </summary>
		public static bool HasGetExtensionsStringARB
		{
			get
			{
				return (Delegates.pwglGetExtensionsStringARB != null);
			}
		}

		/// <summary>
		/// The MakeCurrent function makes a specified OpenGL rendering context the calling thread's current rendering context. All subsequent OpenGL
		/// calls made by the thread are drawn on the device identified by hdc. You can also use MakeCurrent to change the calling thread's current
		/// rendering context so it's no longer current.
		/// </summary>
		/// <param name="hDc">
		/// Handle to a device context. Subsequent OpenGL calls made by the calling thread are drawn on the device identified by hdc.
		/// </param>
		/// <param name="newContext">
		/// Handle to an OpenGL rendering context that the function sets as the calling thread's rendering context. If hglrc is NULL, the function makes
		/// the calling thread's current rendering context no longer current, and releases the device context that is used by the rendering context. In this
		/// case, hdc is ignored. 
		/// </param>
		/// <returns>
		/// When the MakeCurrent function succeeds, the return value is Gl.TRUE; otherwise the return value is Gl.FALSE. To get extended error information, call GetLastError.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The hdc parameter must refer to a drawing surface supported by OpenGL. It need not be the same hdc that was passed to Wgl.CreateContext when hglrc was created,
		/// but it must be on the same device and have the same pixel format. GDI transformation and clipping in hdc are not supported by the rendering context. The current
		/// rendering context uses the hdc device context until the rendering context is no longer current.
		/// </para>
		/// <para>
		/// Before switching to the new rendering context, OpenGL flushes any previous rendering context that was current to the calling thread.
		/// </para>
		/// <para>
		/// A thread can have one current rendering context. A process can have multiple rendering contexts by means of multithreading. A thread must set a current rendering
		/// context before calling any OpenGL functions. Otherwise, all OpenGL calls are ignored.
		/// </para>
		/// <para>
		/// A rendering context can be current to only one thread at a time. You cannot make a rendering context current to multiple threads.
		/// </para>
		/// <para>
		/// An application can perform multithread drawing by making different rendering contexts current to different threads, supplying each thread with its own rendering
		/// context and device context.
		/// </para>
		/// If an error occurs, the MakeCurrent function makes the thread's current rendering context not current before returning.
		/// </remarks>
		public static bool MakeCurrent(IntPtr hDc, IntPtr newContext)
		{
			bool retvalue = MakeCurrentCore(hDc, newContext);

			if ((retvalue == true) && (newContext != IntPtr.Zero)) {
				// After having a current context on the caller thread, synchronize Gl.Delegates pointers to the
				// actual implementation
				Gl.SyncDelegates();
				// Since we have a current context on the caller thread, the API wglGetProcAddress is available; indeed
				// synchronize Wgl.Delegates as well
				SyncDelegates();
			}

			return (retvalue);
		}

		#endregion

		#region Debugging

		/// <summary>
		/// Get or set the enable flag for the OpenGL call log.
		/// </summary>
		public static bool CallLogEnabled
		{
			get { return (sCallLogEnabled); }
			set { sCallLogEnabled = value; }
		}

		/// <summary>
		/// OpenGL error checking.
		/// </summary>
		public static void CheckErrors()
		{
			int errorCode = Marshal.GetLastWin32Error();

			if (errorCode != 0)
				throw new Win32Exception(errorCode);
		}

		/// <summary>
		/// OpenGL logging utility.
		/// </summary>
		/// <param name="format">
		/// A <see cref="String"/> that speficies the format string.
		/// </param>
		/// <param name="args">
		/// A variable arrays of objects used for rendering the <paramref name="format"/>.
		/// </param>
		[Conditional("OPENGL_NET_CALL_LOG_ENABLED")]
		private static void CallLog(string format, params object[] args)
		{
			if (sCallLogEnabled == false)
				return;


		}

		/// <summary>
		/// The enable flag for the OpenGL call log.
		/// </summary>
		private static bool sCallLogEnabled;

		#endregion

		#region Required External Declarations

		public unsafe static partial class UnsafeNativeMethods
		{
			/// <summary>
			/// 
			/// </summary>
			/// <param name="deviceContext"></param>
			/// <param name="pixelFormatDescriptor"></param>
			/// <returns></returns>
			[DllImport("gdi32.dll", EntryPoint = "ChoosePixelFormat", ExactSpelling = true, SetLastError = true)]
			public static extern int GdiChoosePixelFormat(IntPtr deviceContext, [In] ref PIXELFORMATDESCRIPTOR pixelFormatDescriptor);

			/// <summary>
			/// 
			/// </summary>
			/// <param name="deviceContext"></param>
			/// <param name="pixelFormat"></param>
			/// <param name="pixelFormatDescriptor"></param>
			/// <returns></returns>
			[DllImport("gdi32.dll", EntryPoint = "SetPixelFormat", ExactSpelling = true, SetLastError = true)]
			public static extern bool GdiSetPixelFormat(IntPtr deviceContext, int pixelFormat, ref PIXELFORMATDESCRIPTOR pixelFormatDescriptor);

			/// <summary>
			/// 
			/// </summary>
			/// <param name="deviceContext"></param>
			/// <returns></returns>
			[DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "SwapBuffers")]
			public static extern int GdiSwapBuffersFast([In] IntPtr deviceContext);

			/// <summary>
			/// 
			/// </summary>
			/// <param name="lpszDriver"></param>
			/// <param name="lpszDevice"></param>
			/// <param name="lpszOutput"></param>
			/// <param name="lpInitData"></param>
			/// <returns></returns>
			[DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "CreateDC")]
			public static extern IntPtr GdiCreateDC(string lpszDriver, string lpszDevice, string lpszOutput, IntPtr lpInitData);

			/// <summary>
			/// 
			/// </summary>
			/// <param name="hdc"></param>
			/// <returns></returns>
			[DllImport("gdi32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "DeleteDC")]
			static extern bool GdiDeleteDC(IntPtr hdc);

			/// <summary>
			/// 
			/// </summary>
			/// <param name="windowHandle"></param>
			/// <returns></returns>
			[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "GetDC")]
			public static extern IntPtr GdiGetDC(IntPtr windowHandle);

			/// <summary>
			/// 
			/// </summary>
			/// <param name="windowHandle"></param>
			/// <param name="deviceContext"></param>
			/// <returns></returns>
			[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "ReleaseDC")]
			public static extern bool GdiReleaseDC(IntPtr windowHandle, IntPtr deviceContext);

			/// <summary>
			/// 
			/// </summary>
			/// <param name="lpDevice"></param>
			/// <param name="iDevNum"></param>
			/// <param name="lpDisplayDevice"></param>
			/// <param name="dwFlags"></param>
			/// <returns></returns>
			/// <remarks>
			/// Thanks to www.pinvoke.net.
			/// </remarks>
			[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)]
			public static extern bool EnumDisplayDevices(string lpDevice, uint iDevNum, ref DISPLAY_DEVICE lpDisplayDevice, uint dwFlags);
		}

		/// <summary>
		/// Structure to describe the display device.
		/// </summary>
		/// <remarks>
		/// Thanks to www.pinvoke.net.
		/// </remarks>
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct DISPLAY_DEVICE
		{
			/// <summary>
			/// 
			/// </summary>
			[MarshalAs(UnmanagedType.U4)]
			public int cb;
			/// <summary>
			/// 
			/// </summary>
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string DeviceName;
			/// <summary>
			/// 
			/// </summary>
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string DeviceString;
			/// <summary>
			/// 
			/// </summary>
			[MarshalAs(UnmanagedType.U4)]
			public DisplayDeviceStateFlags StateFlags;
			/// <summary>
			/// 
			/// </summary>
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string DeviceID;
			/// <summary>
			/// 
			/// </summary>
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string DeviceKey;
		}

		/// <summary>
		/// Display device state flags.
		/// </summary>
		/// <remarks>
		/// Thanks to www.pinvoke.net.
		/// </remarks>
		[Flags()]
		public enum DisplayDeviceStateFlags : int
		{
			/// <summary>
			/// The device is part of the desktop.
			/// </summary>
			AttachedToDesktop = 0x1,
			/// <summary>
			/// 
			/// </summary>
			MultiDriver = 0x2,
			/// <summary>
			/// The device is part of the desktop.
			/// </summary>
			PrimaryDevice = 0x4,
			/// <summary>
			/// Represents a pseudo device used to mirror application drawing for remoting or other purposes.
			/// </summary>
			MirroringDriver = 0x8,
			/// <summary>
			/// The device is VGA compatible.
			/// </summary>
			VGACompatible = 0x16,
			/// <summary>
			/// The device is removable; it cannot be the primary display.
			/// </summary>
			Removable = 0x20,
			/// <summary>
			/// The device has more display modes than its output devices support.
			/// </summary>
			ModesPruned = 0x8000000,
			/// <summary>
			/// 
			/// </summary>
			Remote = 0x4000000,
			/// <summary>
			/// 
			/// </summary>
			Disconnect = 0x2000000
		}

		/// <summary>
		/// Structure to describe the pixel format of a drawing surface.
		/// </summary>
		/// <remarks>
		/// Thanks to TaoFramework.
		/// </remarks>
		[StructLayout(LayoutKind.Sequential)]
		public struct PIXELFORMATDESCRIPTOR
		{
			/// <summary>
			/// Specifies the size of this data structure. This value should be set to <c>sizeof(PIXELFORMATDESCRIPTOR)</c>.
			/// </summary>
			public Int16 nSize;
			/// <summary>
			/// Specifies the version of this data structure. This value should be set to 1.
			/// </summary>
			public Int16 nVersion;
			/// <summary>
			/// A set of bit flags that specify properties of the pixel buffer. The properties are generally not mutually exclusive;
			/// you can set any combination of bit flags, with the exceptions noted.
			/// </summary>
			public Int32 dwFlags;
			/// <summary>
			/// Specifies the type of pixel data. The following types are defined.
			/// </summary>
			public Byte iPixelType;
			/// <summary>
			/// Specifies the number of color bitplanes in each color buffer. For RGBA pixel types, it is the size
			/// of the color buffer, excluding the alpha bitplanes. For color-index pixels, it is the size of the
			/// color-index buffer.
			/// </summary>
			public Byte cColorBits;
			/// <summary>
			/// Specifies the number of red bitplanes in each RGBA color buffer.
			/// </summary>
			public Byte cRedBits;
			/// <summary>
			/// Specifies the shift count for red bitplanes in each RGBA color buffer.
			/// </summary>
			public Byte cRedShift;
			/// <summary>
			/// Specifies the number of green bitplanes in each RGBA color buffer.
			/// </summary>
			public Byte cGreenBits;
			/// <summary>
			/// Specifies the shift count for green bitplanes in each RGBA color buffer.
			/// </summary>
			public Byte cGreenShift;
			/// <summary>
			/// Specifies the number of blue bitplanes in each RGBA color buffer.
			/// </summary>
			public Byte cBlueBits;
			/// <summary>
			/// Specifies the shift count for blue bitplanes in each RGBA color buffer.
			/// </summary>
			public Byte cBlueShift;
			/// <summary>
			/// Specifies the number of alpha bitplanes in each RGBA color buffer. Alpha bitplanes are not supported.
			/// </summary>
			public Byte cAlphaBits;
			/// <summary>
			/// Specifies the shift count for alpha bitplanes in each RGBA color buffer. Alpha bitplanes are not supported.
			/// </summary>
			public Byte cAlphaShift;
			/// <summary>
			/// Specifies the total number of bitplanes in the accumulation buffer.
			/// </summary>
			public Byte cAccumBits;
			/// <summary>
			/// Specifies the number of red bitplanes in the accumulation buffer.
			/// </summary>
			public Byte cAccumRedBits;
			/// <summary>
			/// Specifies the number of green bitplanes in the accumulation buffer.
			/// </summary>
			public Byte cAccumGreenBits;
			/// <summary>
			/// Specifies the number of blue bitplanes in the accumulation buffer.
			/// </summary>
			public Byte cAccumBlueBits;
			/// <summary>
			/// Specifies the number of alpha bitplanes in the accumulation buffer.
			/// </summary>
			public Byte cAccumAlphaBits;
			/// <summary>
			/// Specifies the depth of the depth (z-axis) buffer.
			/// </summary>
			public Byte cDepthBits;
			/// <summary>
			/// Specifies the depth of the stencil buffer.
			/// </summary>
			public Byte cStencilBits;
			/// <summary>
			/// Specifies the number of auxiliary buffers. Auxiliary buffers are not supported.
			/// </summary>
			public Byte cAuxBuffers;
			/// <summary>
			/// Ignored. Earlier implementations of OpenGL used this member, but it is no longer used.
			/// </summary>
			/// <remarks>Specifies the type of layer.</remarks>
			public Byte iLayerType;
			/// <summary>
			/// Specifies the number of overlay and underlay planes. Bits 0 through 3 specify up to 15 overlay planes and
			/// bits 4 through 7 specify up to 15 underlay planes.
			/// </summary>
			public Byte bReserved;
			/// <summary>
			/// Ignored. Earlier implementations of OpenGL used this member, but it is no longer used.
			/// </summary>
			public Int32 dwLayerMask;
			/// <summary>
			/// Specifies the transparent color or index of an underlay plane. When the pixel type is RGBA, <b>dwVisibleMask</b>
			/// is a transparent RGB color value. When the pixel type is color index, it is a transparent index value.
			/// </summary>
			public Int32 dwVisibleMask;
			/// <summary>
			/// Ignored. Earlier implementations of OpenGL used this member, but it is no longer used.
			/// </summary>
			public Int32 dwDamageMask;
		};

		/// <summary>
		/// RGBA pixels.
		/// </summary>
		/// <remarks>
		/// Each pixel has four components in this order: red, green, blue,
		/// and alpha.
		/// </remarks>
		public const int PFD_TYPE_RGBA = 0;
		/// <summary>
		///	 The layer is the main plane.
		/// </summary>
		public const int PFD_MAIN_PLANE = 0;

		/// <summary>
		/// The buffer is double-buffered.
		/// </summary>
		public const int PFD_DOUBLEBUFFER = 0x00000001;
		/// <summary>
		/// The buffer is stereoscopic.
		/// </summary>
		public const int PFD_STEREO = 0x00000002;

		/// <summary>
		/// The buffer can draw to a window or device surface.
		/// </summary>
		public const int PFD_DRAW_TO_WINDOW = 0x00000004;
		/// <summary>
		/// The buffer can draw to a memory bitmap.
		/// </summary>
		public const int PFD_DRAW_TO_BITMAP = 0x00000008;
		/// <summary>
		/// The buffer supports OpenGL drawing.
		/// </summary>
		public const int PFD_SUPPORT_OPENGL = 0x00000020;
		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// Specifies the content of the back buffer in the double-buffered main color
		/// plane following a buffer swap.  Swapping the color buffers causes the
		/// exchange of the back buffer's content with the front buffer's content.
		/// Following the swap, the back buffer's content contains the front buffer's
		/// content before the swap. <b>PFD_SWAP_EXCHANGE</b> is a hint only and might
		/// not be provided by a driver.
		/// </remarks>
		public const int PFD_SWAP_EXCHANGE = 0x00000200;
		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// Specifies the content of the back buffer in the double-buffered main color
		/// plane following a buffer swap.  Swapping the color buffers causes the content
		/// of the back buffer to be copied to the front buffer.  The content of the back
		/// buffer is not affected by the swap.  <b>PFD_SWAP_COPY</b> is a hint only and
		/// might not be provided by a driver.
		/// </remarks>
		public const int PFD_SWAP_COPY = 0x00000400;

		#endregion
	}
}
