
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

#pragma warning disable 618

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

using Khronos;

// ReSharper disable InheritdocConsiderUsage

namespace OpenGL
{
	/// <summary>
	/// WGL (GL for Windows) window system interface.
	/// </summary>
	[SuppressMessage("ReSharper", "InconsistentNaming")]
	public partial class Wgl : KhronosApi
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static Wgl()
		{
			// Load procedures
			BindAPI();
		}

		#endregion

		#region Platform Extensions

		/// <summary>
		/// WGL extension support.
		/// </summary>
		public static Extensions CurrentExtensions { get; internal set; }

		#endregion

		#region API Binding

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
		private static GetAddressDelegate _GetAddressDelegate = GetProcAddressGLOS;

		/// <summary>
		/// Bind Windows WGL delegates.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This method will load WGL function pointers. Basic function pointers are loaded at Wgl initialization (i.e. static constructor),
		/// but the complete set of function pointers can be loaded only when a GL context is made current.
		/// </para>
		/// <para>
		/// In the case OpenGL.Net is initializing (i.e. OPENGL_NET_INIT is not set to NOT), this function doesn't need to be called manually.
		/// Otherwise, users should call this method after making a GL context current in order to load WGL extensions methods.
		/// </para>
		/// </remarks>
		public static void BindAPI()
		{
			BindAPI<Wgl>(Library, _GetAddressDelegate, null);
		}

		/// <summary>
		/// Default import library.
		/// </summary>
		private const string Library = "opengl32.dll";

		#endregion

		#region Special API Implementations

		/// <summary>
		/// Utility method for testing whether wglGetExtensionsStringARB is implemented on the current system.
		/// </summary>
		public static bool HasGetExtensionsStringARB => Delegates.pwglGetExtensionsStringARB != null;

		#endregion

		#region Error Checking

		/// <summary>
		/// Error handling mode.
		/// </summary>
		public enum ErrorHandlingMode
		{
			/// <summary>
			/// Throw a <see cref="Win32Exception"/> when a WGL routine reports an error.
			/// </summary>
			Normal,

			/// <summary>
			/// Do not throw any exception when a WGL routine reports an error, but logs the error
			/// description.
			/// </summary>
			LogOnly,

			/// <summary>
			/// Ignore all errors reported by WGL routines.
			/// </summary>
			Ignore,
		}

		/// <summary>
		/// Current error handling mode.
		/// </summary>
		public static ErrorHandlingMode ErrorHandling = ErrorHandlingMode.LogOnly;

		/// <summary>
		/// OpenGL on Windows error checking.
		/// </summary>
		/// <param name="returnValue">
		/// A <see cref="Object"/> that specifies the function returned value, if any.
		/// </param>
		public static void DebugCheckErrors(object returnValue)
		{
			// Note (from MSDN): The Return Value section of the documentation for each function that sets the last-error code notes the conditions
			// under which the function sets the last-error code. Most functions that set the thread's last-error code set it when they fail. However,
			// some functions also set the last-error code when they succeed. If the function is not documented to set the last-error code, the value
			// returned by this function is simply the most recent last-error code to have been set; some functions set the last-error code to 0 on
			// success and others do not.

			// Log errors returned (instead of throwing exception) in the case of successfull cases
			ErrorHandlingMode methodErrorHandling = ErrorHandling;

			if (methodErrorHandling == ErrorHandlingMode.Normal && returnValue != null) {
#if NETSTANDARD1_1 || NETSTANDARD1_4
				Type returnValueType = returnValue.GetType();

				if        (returnValueType == typeof(Boolean)) {
					if ((bool)returnValue == true)
							methodErrorHandling = ErrorHandlingMode.LogOnly;
				} else if (returnValueType == typeof(String)) {
					if ((string)returnValue != null)
							methodErrorHandling = ErrorHandlingMode.LogOnly;
				}
#else
				switch (Type.GetTypeCode(returnValue.GetType())) {
					case TypeCode.Boolean:
						if ((bool)returnValue)
							methodErrorHandling = ErrorHandlingMode.LogOnly;
						break;
					case TypeCode.String:
						if ((string)returnValue != null)
							methodErrorHandling = ErrorHandlingMode.LogOnly;
						break;
				}
#endif
			}

			// All WGl routines set error using SetLastError routine (*)
			int errorCode = Marshal.GetLastWin32Error();

			switch (errorCode) {
				case 0:
					// Success
					break;
				default:
					switch (ErrorHandling) {
						case ErrorHandlingMode.Normal:
						default:
							throw new WglException(errorCode);
						case ErrorHandlingMode.LogOnly:
							LogComment(string.Format("GetLastError() = {0} [Error code {0}: {1}]", errorCode, new Win32Exception(errorCode).Message));
							break;
						case ErrorHandlingMode.Ignore:
							break;
					}
					break;
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
				_LogContext = new KhronosLogContext(typeof(Wgl));
			RaiseLog(new KhronosLogEventArgs(_LogContext, name, args, returnValue));
		}

		/// <summary>
		/// Context for logging enumerant names instead of numerical values.
		/// </summary>
		private static KhronosLogContext _LogContext;

		#endregion

		#region Required External Declarations

		/// <summary>
		/// 
		/// </summary>
		/// <param name="deviceContext"></param>
		/// <param name="pixelFormatDescriptor"></param>
		/// <returns></returns>
		public static int ChoosePixelFormat(IntPtr deviceContext, [In] ref PIXELFORMATDESCRIPTOR pixelFormatDescriptor)
		{
			int retValue = UnsafeNativeMethods.ChoosePixelFormat(deviceContext, ref pixelFormatDescriptor);

			LogCommand("ChoosePixelFormat", retValue, deviceContext, pixelFormatDescriptor);
			DebugCheckErrors(null);

			return retValue;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="hdc"></param>
		/// <param name="iPixelFormat"></param>
		/// <param name="nBytes"></param>
		/// <param name="pixelFormatDescriptor"></param>
		/// <returns></returns>
		public static int DescribePixelFormat(IntPtr hdc, int iPixelFormat, uint nBytes, [In, Out] ref PIXELFORMATDESCRIPTOR pixelFormatDescriptor)
		{
			int retValue = UnsafeNativeMethods.DescribePixelFormat(hdc, iPixelFormat, nBytes, ref pixelFormatDescriptor);

			LogCommand("DescribePixelFormat", retValue, hdc, iPixelFormat, nBytes, pixelFormatDescriptor);
			DebugCheckErrors(null);

			return retValue;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="deviceContext"></param>
		/// <param name="pixelFormat"></param>
		/// <param name="pixelFormatDescriptor"></param>
		/// <returns></returns>
		public static bool SetPixelFormat(IntPtr deviceContext, int pixelFormat, ref PIXELFORMATDESCRIPTOR pixelFormatDescriptor)
		{
			bool retValue = UnsafeNativeMethods.SetPixelFormat(deviceContext, pixelFormat, ref pixelFormatDescriptor);

			LogCommand("SetPixelFormat", retValue, deviceContext, pixelFormat, pixelFormatDescriptor);
			DebugCheckErrors(null);

			return retValue;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="windowHandle"></param>
		/// <returns></returns>
		public static IntPtr GetDC(IntPtr windowHandle)
		{
			IntPtr retValue = UnsafeNativeMethods.GetDC(windowHandle);

			LogCommand("GetDC", retValue, windowHandle.ToString("X8"));
			DebugCheckErrors(null);

			return retValue;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="windowHandle"></param>
		/// <param name="deviceContext"></param>
		/// <returns></returns>
		public static bool ReleaseDC(IntPtr windowHandle, IntPtr deviceContext)
		{
			bool retValue = UnsafeNativeMethods.ReleaseDC(windowHandle, deviceContext);

			LogCommand("ReleaseDC", windowHandle.ToString("X8"), deviceContext.ToString("X8"), retValue);
			DebugCheckErrors(null);

			return retValue;
		}

		public static class UnsafeNativeMethods
		{
			/// <summary>
			/// 
			/// </summary>
			/// <param name="deviceContext"></param>
			/// <param name="pixelFormatDescriptor"></param>
			/// <returns></returns>
			[DllImport("gdi32.dll", EntryPoint = "ChoosePixelFormat", ExactSpelling = true, SetLastError = true)]
			public static extern int ChoosePixelFormat(IntPtr deviceContext, [In] ref PIXELFORMATDESCRIPTOR pixelFormatDescriptor);

			/// <summary>
			/// 
			/// </summary>
			/// <param name="hdc"></param>
			/// <param name="iPixelFormat"></param>
			/// <param name="nBytes"></param>
			/// <param name="ppfd"></param>
			/// <returns></returns>
			[DllImport("gdi32.dll", EntryPoint = "DescribePixelFormat", ExactSpelling = true, SetLastError = true)]
			public static extern int DescribePixelFormat(IntPtr hdc, int iPixelFormat, uint nBytes, [In, Out] ref PIXELFORMATDESCRIPTOR ppfd);

			/// <summary>
			/// 
			/// </summary>
			/// <param name="deviceContext"></param>
			/// <param name="pixelFormat"></param>
			/// <param name="pixelFormatDescriptor"></param>
			/// <returns></returns>
			[DllImport("gdi32.dll", EntryPoint = "SetPixelFormat", ExactSpelling = true, SetLastError = true)]
			public static extern bool SetPixelFormat(IntPtr deviceContext, int pixelFormat, ref PIXELFORMATDESCRIPTOR pixelFormatDescriptor);

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
			/// <param name="windowHandle"></param>
			/// <returns></returns>
			[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "GetDC")]
			public static extern IntPtr GetDC(IntPtr windowHandle);

			/// <summary>
			/// 
			/// </summary>
			/// <param name="windowHandle"></param>
			/// <param name="deviceContext"></param>
			/// <returns></returns>
			[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "ReleaseDC")]
			public static extern bool ReleaseDC(IntPtr windowHandle, IntPtr deviceContext);
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
		[Flags]
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
		/// Specifies the type of layer.
		/// </summary>
		public enum PixelFormatDescriptorLayerType : byte
		{
			/// <summary>
			/// Main plane.
			/// </summary>
			Main = PFD_MAIN_PLANE,

			/// <summary>
			/// Overlay plane.
			/// </summary>
			Overlay = PFD_OVERLAY_PLANE,

			/// <summary>
			/// Underlay plane.
			/// </summary>
			Underlay = unchecked((byte)PFD_UNDERLAY_PLANE)
		}

		/// <summary>
		/// Flags for the pixel format of a drawing surface.
		/// </summary>
		[Flags]
		public enum PixelFormatDescriptorFlags : int
		{
			/// <summary>
			/// No flags.
			/// </summary>
			None = 0,

			/// <summary>
			/// The buffer is double-buffered. This flag and PFD_SUPPORT_GDI are mutually exclusive in the current generic implementation.
			/// </summary>
			Doublebuffer = PFD_DOUBLEBUFFER,

			/// <summary>
			/// The buffer is stereoscopic. This flag is not supported in the current generic implementation.
			/// </summary>
			Stereo = PFD_STEREO,

			/// <summary>
			/// The buffer can draw to a window or device surface.
			/// </summary>
			DrawToWindow = PFD_DRAW_TO_WINDOW,

			/// <summary>
			/// The buffer can draw to a memory bitmap.
			/// </summary>
			DrawToBitmap = PFD_DRAW_TO_BITMAP,

			/// <summary>
			/// The buffer supports GDI drawing. This flag and PFD_DOUBLEBUFFER are mutually exclusive in the current generic implementation.
			/// </summary>
			SupportGdi = PFD_SUPPORT_GDI,

			/// <summary>
			/// The buffer supports OpenGL drawing.
			/// </summary>
			SupportOpenGL = PFD_SUPPORT_OPENGL,

			/// <summary>
			/// The pixel format is supported by the GDI software implementation, which is also known as the generic implementation.
			/// If this bit is clear, the pixel format is supported by a device driver or hardware.
			/// </summary>
			GenericFormat = PFD_GENERIC_FORMAT,

			/// <summary>
			/// The buffer uses RGBA pixels on a palette-managed device. A logical palette is required to achieve the best results for
			/// this pixel type. Colors in the palette should be specified according to the values of the cRedBits, cRedShift, cGreenBits,
			/// cGreenShift, cBluebits, and cBlueShift members. The palette should be created and realized in the device context before
			/// calling wglMakeCurrent.
			/// </summary>
			NeedPalette = PFD_NEED_PALETTE,

			/// <summary>
			/// Defined in the pixel format descriptors of hardware that supports one hardware palette in 256-color mode only. For such
			/// systems to use hardware acceleration, the hardware palette must be in a fixed order (for example, 3-3-2) when in RGBA
			/// mode or must match the logical palette when in color-index mode.
			/// When this flag is set, you must call SetSystemPaletteUse in your program to force a one-to-one mapping of the logical
			/// palette and the system palette. If your OpenGL hardware supports multiple hardware palettes and the device driver can
			/// allocate spare hardware palettes for OpenGL, this flag is typically clear.
			/// </summary>
			/// <remarks>
			/// This flag is not set in the generic pixel formats.
			/// </remarks>
			NeedSystemPalette = PFD_NEED_SYSTEM_PALETTE,

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
			SwapExchange = PFD_SWAP_EXCHANGE,

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
			SwapCopy = PFD_SWAP_COPY,

			/// <summary>
			/// Indicates whether a device can swap individual layer planes with pixel formats that include double-buffered
			/// overlay or underlay planes. Otherwise all layer planes are swapped together as a group. When this flag is set,
			/// wglSwapLayerBuffers is supported.
			/// </summary>
			SwapLayerBuffers = PFD_SWAP_LAYER_BUFFERS,

			/// <summary>
			/// The pixel format is supported by a device driver that accelerates the generic implementation. If this flag is clear
			/// and the PFD_GENERIC_FORMAT flag is set, the pixel format is supported by the generic implementation only.
			/// </summary>
			GenericAccelerated = PFD_GENERIC_ACCELERATED,

			/// <summary>
			/// Undocumented.
			/// </summary>
			SupportDirectDraw = PFD_SUPPORT_DIRECTDRAW,

			/// <summary>
			/// Undocumented.
			/// </summary>
			Direct3dAccelerated = PFD_DIRECT3D_ACCELERATED,

			/// <summary>
			/// Undocumented.
			/// </summary>
			SupportComposition = PFD_SUPPORT_COMPOSITION,

			/// <summary>
			/// The requested pixel format can either have or not have a depth buffer. To select a pixel format without
			/// a depth buffer, you must specify this flag. The requested pixel format can be with or without a depth
			/// buffer. Otherwise, only pixel formats with a depth buffer are considered.
			/// </summary>
			/// <remarks>
			/// This value can be used only with <see cref="ChoosePixelFormat(IntPtr, ref PIXELFORMATDESCRIPTOR)"/>.
			/// </remarks>
			DepthDontCare = PFD_DEPTH_DONTCARE,

			/// <summary>
			/// The requested pixel format can be either single- or double-buffered.
			/// </summary>
			/// <remarks>
			/// This value can be used only with <see cref="ChoosePixelFormat(IntPtr, ref PIXELFORMATDESCRIPTOR)"/>.
			/// </remarks>
			DoublebufferDontCare = PFD_DOUBLEBUFFER_DONTCARE,

			/// <summary>
			/// The requested pixel format can be either monoscopic or stereoscopic.
			/// </summary>
			/// <remarks>
			/// This value can be used only with <see cref="ChoosePixelFormat(IntPtr, ref PIXELFORMATDESCRIPTOR)"/>.
			/// </remarks>
			StereoDontCare = PFD_STEREO_DONTCARE
		}

		/// <summary>
		/// Specifies the type of pixel data.
		/// </summary>
		public enum PixelFormatDescriptorPixelType : byte
		{
			/// <summary>
			/// RGBA pixels. Each pixel has four components in this order: red, green, blue, and alpha.
			/// </summary>
			Rgba = PFD_TYPE_RGBA,

			/// <summary>
			/// 
			/// </summary>
			ColorIndexed = PFD_TYPE_COLORINDEX
		}

		/// <summary>
		/// Structure to describe the pixel format of a drawing surface.
		/// </summary>
		/// <remarks>
		/// Thanks to TaoFramework.
		/// </remarks>
		[StructLayout(LayoutKind.Sequential)]
		[SuppressMessage("ReSharper", "InconsistentNaming")]
		public struct PIXELFORMATDESCRIPTOR
		{
			#region Constructors

			/// <summary>
			/// Construct a pixel format descriptor.
			/// </summary>
			/// <param name="colorBits">
			/// Specifies the number of color bitplanes in each color buffer. It is the size of the color buffer, excluding the alpha
			/// bitplanes.
			/// </param>
			public PIXELFORMATDESCRIPTOR(byte colorBits)
			{
				nVersion = 1;
				nSize = (short)Marshal.SizeOf(typeof(PIXELFORMATDESCRIPTOR));

				iLayerType = PixelFormatDescriptorLayerType.Main;
				dwFlags = PixelFormatDescriptorFlags.SupportOpenGL | PixelFormatDescriptorFlags.DrawToWindow | PixelFormatDescriptorFlags.Doublebuffer;
				iPixelType = PixelFormatDescriptorPixelType.Rgba;

				dwLayerMask = 0; dwVisibleMask = 0; dwDamageMask = 0;
				cAuxBuffers = 0;
				bReserved = 0;

				cColorBits = colorBits;

				cRedBits = 0; cRedShift = 0;
				cGreenBits = 0; cGreenShift = 0;
				cBlueBits = 0; cBlueShift = 0;
				cAlphaBits = 0; cAlphaShift = 0;
				cDepthBits = 0;
				cStencilBits = 0;
				cAccumBits = 0;
				cAccumRedBits = 0; cAccumGreenBits = 0; cAccumBlueBits = 0; cAccumAlphaBits = 0;
			}

			#endregion

			#region Structure

			/// <summary>
			/// Specifies the size of this data structure. This value should be set to <c>sizeof(PIXELFORMATDESCRIPTOR)</c>.
			/// </summary>
			public short nSize;

			/// <summary>
			/// Specifies the version of this data structure. This value should be set to 1.
			/// </summary>
			public short nVersion;

			/// <summary>
			/// A set of bit flags that specify properties of the pixel buffer. The properties are generally not mutually exclusive;
			/// you can set any combination of bit flags, with the exceptions noted.
			/// </summary>
			public PixelFormatDescriptorFlags dwFlags;

			/// <summary>
			/// Specifies the type of pixel data. The following types are defined.
			/// </summary>
			public PixelFormatDescriptorPixelType iPixelType;

			/// <summary>
			/// Specifies the number of color bitplanes in each color buffer. For RGBA pixel types, it is the size
			/// of the color buffer, excluding the alpha bitplanes. For color-index pixels, it is the size of the
			/// color-index buffer.
			/// </summary>
			public byte cColorBits;

			/// <summary>
			/// Specifies the number of red bitplanes in each RGBA color buffer.
			/// </summary>
			public byte cRedBits;

			/// <summary>
			/// Specifies the shift count for red bitplanes in each RGBA color buffer.
			/// </summary>
			public byte cRedShift;

			/// <summary>
			/// Specifies the number of green bitplanes in each RGBA color buffer.
			/// </summary>
			public byte cGreenBits;

			/// <summary>
			/// Specifies the shift count for green bitplanes in each RGBA color buffer.
			/// </summary>
			public byte cGreenShift;

			/// <summary>
			/// Specifies the number of blue bitplanes in each RGBA color buffer.
			/// </summary>
			public byte cBlueBits;

			/// <summary>
			/// Specifies the shift count for blue bitplanes in each RGBA color buffer.
			/// </summary>
			public byte cBlueShift;

			/// <summary>
			/// Specifies the number of alpha bitplanes in each RGBA color buffer. Alpha bitplanes are not supported.
			/// </summary>
			public byte cAlphaBits;

			/// <summary>
			/// Specifies the shift count for alpha bitplanes in each RGBA color buffer. Alpha bitplanes are not supported.
			/// </summary>
			public byte cAlphaShift;

			/// <summary>
			/// Specifies the total number of bitplanes in the accumulation buffer.
			/// </summary>
			public byte cAccumBits;

			/// <summary>
			/// Specifies the number of red bitplanes in the accumulation buffer.
			/// </summary>
			public byte cAccumRedBits;

			/// <summary>
			/// Specifies the number of green bitplanes in the accumulation buffer.
			/// </summary>
			public byte cAccumGreenBits;

			/// <summary>
			/// Specifies the number of blue bitplanes in the accumulation buffer.
			/// </summary>
			public byte cAccumBlueBits;

			/// <summary>
			/// Specifies the number of alpha bitplanes in the accumulation buffer.
			/// </summary>
			public byte cAccumAlphaBits;

			/// <summary>
			/// Specifies the depth of the depth (z-axis) buffer.
			/// </summary>
			public byte cDepthBits;

			/// <summary>
			/// Specifies the depth of the stencil buffer.
			/// </summary>
			public byte cStencilBits;

			/// <summary>
			/// Specifies the number of auxiliary buffers. Auxiliary buffers are not supported.
			/// </summary>
			public byte cAuxBuffers;

			/// <summary>
			/// Ignored. Earlier implementations of OpenGL used this member, but it is no longer used.
			/// </summary>
			/// <remarks>Specifies the type of layer.</remarks>
			public PixelFormatDescriptorLayerType iLayerType;

			/// <summary>
			/// Specifies the number of overlay and underlay planes. Bits 0 through 3 specify up to 15 overlay planes and
			/// bits 4 through 7 specify up to 15 underlay planes.
			/// </summary>
			public byte bReserved;

			/// <summary>
			/// Ignored. Earlier implementations of OpenGL used this member, but it is no longer used.
			/// </summary>
			public int dwLayerMask;

			/// <summary>
			/// Specifies the transparent color or index of an underlay plane. When the pixel type is RGBA, <b>dwVisibleMask</b>
			/// is a transparent RGB color value. When the pixel type is color index, it is a transparent index value.
			/// </summary>
			public int dwVisibleMask;

			/// <summary>
			/// Ignored. Earlier implementations of OpenGL used this member, but it is no longer used.
			/// </summary>
			public int dwDamageMask;

			#endregion

			#region Object Overrides

			///<summary>
			/// Converts this PIXELFORMATDESCRIPTOR into a human-legible string representation.
			///</summary>
			///<returns>
			/// The string representation of this instance.
			///</returns>
			public override string ToString()
			{
				StringBuilder sb = new StringBuilder();

				sb.Append("PIXELFORMATDESCRIPTOR={");
				sb.AppendFormat("PixelType={0},", iPixelType);
				if (cColorBits != 0)
					sb.AppendFormat("ColorBits={0},", cColorBits);
				if (cDepthBits != 0)
					sb.AppendFormat("DepthBits={0},", cDepthBits);
				if (cStencilBits != 0)
					sb.AppendFormat("StencilBits={0},", cStencilBits);
				sb.AppendFormat("Flags={0},", dwFlags);
				sb.Remove(sb.Length - 1, 1);
				sb.Append("}");

				return sb.ToString();
			}

			#endregion
		};

		#region Pixel Type Enumeration

		/// <summary>
		/// RGBA pixels.
		/// </summary>
		/// <remarks>
		/// Each pixel has four components in this order: red, green, blue,
		/// and alpha.
		/// </remarks>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public const int PFD_TYPE_RGBA = 0;

		/// <summary>
		/// Color-index pixels.
		/// </summary>
		/// <remarks>
		/// Each pixel uses a color-index value.
		/// </remarks>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public const int PFD_TYPE_COLORINDEX = 1;

		#endregion

		#region Layer Type Enumeration

		/// <summary>
		/// The layer is the main plane.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public const int PFD_MAIN_PLANE = 0;

		/// <summary>
		/// The layer is the overlay plane
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public const int PFD_OVERLAY_PLANE = 1;

		/// <summary>
		/// The layer is the underlay plane.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		public const int PFD_UNDERLAY_PLANE = -1;

		#endregion

		#region PIXELFORMATDESCRIPTOR flags

		/// <summary>
		/// The buffer is double-buffered. This flag and PFD_SUPPORT_GDI are mutually exclusive in the current generic implementation.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLPixelFormatDescriptorFlags")]
		public const int PFD_DOUBLEBUFFER = 0x00000001;

		/// <summary>
		/// The buffer is stereoscopic. This flag is not supported in the current generic implementation.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLPixelFormatDescriptorFlags")]
		public const int PFD_STEREO = 0x00000002;

		/// <summary>
		/// The buffer can draw to a window or device surface.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLPixelFormatDescriptorFlags")]
		public const int PFD_DRAW_TO_WINDOW = 0x00000004;

		/// <summary>
		/// The buffer can draw to a memory bitmap.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLPixelFormatDescriptorFlags")]
		public const int PFD_DRAW_TO_BITMAP = 0x00000008;

		/// <summary>
		/// The buffer supports GDI drawing. This flag and PFD_DOUBLEBUFFER are mutually exclusive in the current generic implementation.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLPixelFormatDescriptorFlags")]
		public const int PFD_SUPPORT_GDI = 0x00000010;

		/// <summary>
		/// The buffer supports OpenGL drawing.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLPixelFormatDescriptorFlags")]
		public const int PFD_SUPPORT_OPENGL = 0x00000020;

		/// <summary>
		/// The pixel format is supported by the GDI software implementation, which is also known as the generic implementation.
		/// If this bit is clear, the pixel format is supported by a device driver or hardware.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLPixelFormatDescriptorFlags")]
		public const int PFD_GENERIC_FORMAT = 0x00000040;

		/// <summary>
		/// The buffer uses RGBA pixels on a palette-managed device. A logical palette is required to achieve the best results for
		/// this pixel type. Colors in the palette should be specified according to the values of the cRedBits, cRedShift, cGreenBits,
		/// cGreenShift, cBluebits, and cBlueShift members. The palette should be created and realized in the device context before
		/// calling wglMakeCurrent.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLPixelFormatDescriptorFlags")]
		public const int PFD_NEED_PALETTE = 0x00000080;

		/// <summary>
		/// Defined in the pixel format descriptors of hardware that supports one hardware palette in 256-color mode only. For such
		/// systems to use hardware acceleration, the hardware palette must be in a fixed order (for example, 3-3-2) when in RGBA
		/// mode or must match the logical palette when in color-index mode.
		/// When this flag is set, you must call SetSystemPaletteUse in your program to force a one-to-one mapping of the logical
		/// palette and the system palette. If your OpenGL hardware supports multiple hardware palettes and the device driver can
		/// allocate spare hardware palettes for OpenGL, this flag is typically clear.
		/// </summary>
		/// <remarks>
		/// This flag is not set in the generic pixel formats.
		/// </remarks>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLPixelFormatDescriptorFlags")]
		public const int PFD_NEED_SYSTEM_PALETTE =		0x00000100;

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
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLPixelFormatDescriptorFlags")]
		public const int PFD_SWAP_EXCHANGE =			0x00000200;

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
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLPixelFormatDescriptorFlags")]
		public const int PFD_SWAP_COPY =				0x00000400;

		/// <summary>
		/// Indicates whether a device can swap individual layer planes with pixel formats that include double-buffered
		/// overlay or underlay planes. Otherwise all layer planes are swapped together as a group. When this flag is set,
		/// wglSwapLayerBuffers is supported.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLPixelFormatDescriptorFlags")]
		public const int PFD_SWAP_LAYER_BUFFERS =		0x00000800;

		/// <summary>
		/// The pixel format is supported by a device driver that accelerates the generic implementation. If this flag is clear
		/// and the PFD_GENERIC_FORMAT flag is set, the pixel format is supported by the generic implementation only.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLPixelFormatDescriptorFlags")]
		public const int PFD_GENERIC_ACCELERATED =		0x00001000;

		/// <summary>
		/// Undocumented.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLPixelFormatDescriptorFlags")]
		public const int PFD_SUPPORT_DIRECTDRAW =		0x00002000;

		/// <summary>
		/// Undocumented.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLPixelFormatDescriptorFlags")]
		public const int PFD_DIRECT3D_ACCELERATED =		0x00004000;

		/// <summary>
		/// Undocumented.
		/// </summary>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLPixelFormatDescriptorFlags")]
		public const int PFD_SUPPORT_COMPOSITION =		0x00008000;

		/// <summary>
		/// The requested pixel format can either have or not have a depth buffer. To select a pixel format without
		/// a depth buffer, you must specify this flag. The requested pixel format can be with or without a depth
		/// buffer. Otherwise, only pixel formats with a depth buffer are considered.
		/// </summary>
		/// <remarks>
		/// This value can be used only with <see cref="ChoosePixelFormat(IntPtr, ref PIXELFORMATDESCRIPTOR)"/>.
		/// </remarks>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLPixelFormatDescriptorFlags")]
		public const int PFD_DEPTH_DONTCARE =			0x20000000;

		/// <summary>
		/// The requested pixel format can be either single- or double-buffered.
		/// </summary>
		/// <remarks>
		/// This value can be used only with <see cref="ChoosePixelFormat(IntPtr, ref PIXELFORMATDESCRIPTOR)"/>.
		/// </remarks>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLPixelFormatDescriptorFlags")]
		public const int PFD_DOUBLEBUFFER_DONTCARE =	0x40000000;

		/// <summary>
		/// The requested pixel format can be either monoscopic or stereoscopic.
		/// </summary>
		/// <remarks>
		/// This value can be used only with <see cref="ChoosePixelFormat(IntPtr, ref PIXELFORMATDESCRIPTOR)"/>.
		/// </remarks>
		[RequiredByFeature("WGL_VERSION_1_0")]
		[Log(BitmaskName = "WGLPixelFormatDescriptorFlags")]
		public const int PFD_STEREO_DONTCARE =			unchecked((int)0x80000000);

		#endregion

		#endregion
	}
}
