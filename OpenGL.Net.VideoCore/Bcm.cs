
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

using DISPMANX_DISPLAY_HANDLE_T = System.UInt32;
using DISPMANX_ELEMENT_HANDLE_T = System.UInt32;
using DISPMANX_PROTECTION_T = System.UInt32;
using DISPMANX_RESOURCE_HANDLE_T = System.UInt32;
using DISPMANX_UPDATE_HANDLE_T = System.UInt32;

using VCHI_INSTANCE_T = System.IntPtr;
using VCHI_MEM_HANDLE_T = System.Int32;

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;

using Khronos;

namespace OpenGL
{
	/// <summary>
	/// BCM (Broadcom) Raspberry PI Video Core component.
	/// </summary>
	internal class Bcm : KhronosApi
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static Bcm()
		{
			// Load procedures
			try {
				LogComment($"Querying BCM VideoCore from {Library}");
				BindAPI<Bcm>(Library, GetProcAddressOS, null);
				LogComment($"BCM VideoCore availability: {IsAvailable}");
			} catch (Exception exception) {
				/* Fail-safe (it may fail due BCM access) */
				LogComment($"BCM not available:\n{exception}");
			}
		}

		#endregion

		#region API Binding

		/// <summary>
		/// Get whether EGL layer is avaialable.
		/// </summary>
		public static bool IsAvailable { get { return (Delegates.pbcm_host_init != null); } }

		/// <summary>
		/// Get or set whether <see cref="DeviceContext"/> should create an EGL handles, if available.
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
		/// Default import library.
		/// </summary>
		private const string Library = "libbcm_host.so";

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
				_LogContext = new KhronosLogContext(typeof(Bcm));
			RaiseLog(new KhronosLogEventArgs(_LogContext, name, args, returnValue));
		}

		/// <summary>
		/// Context for logging enumerant names instead of numerical values.
		/// </summary>
		private static KhronosLogContext _LogContext;

		#endregion

		#region Native Methods and Delegates

		#region Types

		[StructLayout(LayoutKind.Sequential)]
		public struct VC_RECT_T
		{
			public VC_RECT_T(int x, int y, int w, int h)
			{
				this.x = x;
				this.y = y;
				this.width = w;
				this.height = h;
			}

			public Int32 x;

			public Int32 y;

			public Int32 width;

			public Int32 height;

			public override string ToString()
			{
				return (String.Format("VC_RECT_T={{ x={0} y={1} w={2} h={3} }}", x, y, width, height));
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct DISPMANX_MODEINFO_T {
		  Int32 width;
		  Int32 height;
		  DISPMANX_TRANSFORM_T transform;
		  DISPLAY_INPUT_FORMAT_T input_format;
		  UInt32 display_num;
		}

		public enum DISPLAY_INPUT_FORMAT_T
		{
			VCOS_DISPLAY_INPUT_FORMAT_INVALID = 0,
			VCOS_DISPLAY_INPUT_FORMAT_RGB888,
			VCOS_DISPLAY_INPUT_FORMAT_RGB565
		}

		public enum VC_IMAGE_TYPE_T
		{
			VC_IMAGE_MIN = 0, //bounds for error checking

			VC_IMAGE_RGB565 = 1,
			VC_IMAGE_1BPP,
			VC_IMAGE_YUV420,
			VC_IMAGE_48BPP,
			VC_IMAGE_RGB888,
			VC_IMAGE_8BPP,
			VC_IMAGE_4BPP,    // 4bpp palettised image
			VC_IMAGE_3D32,    /* A separated format of 16 colour/light shorts followed by 16 z values */
			VC_IMAGE_3D32B,   /* 16 colours followed by 16 z values */
			VC_IMAGE_3D32MAT, /* A separated format of 16 material/colour/light shorts followed by 16 z values */
			VC_IMAGE_RGB2X9,   /* 32 bit format containing 18 bits of 6.6.6 RGB, 9 bits per short */
			VC_IMAGE_RGB666,   /* 32-bit format holding 18 bits of 6.6.6 RGB */
			VC_IMAGE_PAL4_OBSOLETE,     // 4bpp palettised image with embedded palette
			VC_IMAGE_PAL8_OBSOLETE,     // 8bpp palettised image with embedded palette
			VC_IMAGE_RGBA32,   /* RGB888 with an alpha byte after each pixel */ /* xxx: isn't it BEFORE each pixel? */
			VC_IMAGE_YUV422,   /* a line of Y (32-byte padded), a line of U (16-byte padded), and a line of V (16-byte padded) */
			VC_IMAGE_RGBA565,  /* RGB565 with a transparent patch */
			VC_IMAGE_RGBA16,   /* Compressed (4444) version of RGBA32 */
			VC_IMAGE_YUV_UV,   /* VCIII codec format */
			VC_IMAGE_TF_RGBA32, /* VCIII T-format RGBA8888 */
			VC_IMAGE_TF_RGBX32,  /* VCIII T-format RGBx8888 */
			VC_IMAGE_TF_FLOAT, /* VCIII T-format float */
			VC_IMAGE_TF_RGBA16, /* VCIII T-format RGBA4444 */
			VC_IMAGE_TF_RGBA5551, /* VCIII T-format RGB5551 */
			VC_IMAGE_TF_RGB565, /* VCIII T-format RGB565 */
			VC_IMAGE_TF_YA88, /* VCIII T-format 8-bit luma and 8-bit alpha */
			VC_IMAGE_TF_BYTE, /* VCIII T-format 8 bit generic sample */
			VC_IMAGE_TF_PAL8, /* VCIII T-format 8-bit palette */
			VC_IMAGE_TF_PAL4, /* VCIII T-format 4-bit palette */
			VC_IMAGE_TF_ETC1, /* VCIII T-format Ericsson Texture Compressed */
			VC_IMAGE_BGR888,  /* RGB888 with R & B swapped */
			VC_IMAGE_BGR888_NP,  /* RGB888 with R & B swapped, but with no pitch, i.e. no padding after each row of pixels */
			VC_IMAGE_BAYER,  /* Bayer image, extra defines which variant is being used */
			VC_IMAGE_CODEC,  /* General wrapper for codec images e.g. JPEG from camera */
			VC_IMAGE_YUV_UV32,   /* VCIII codec format */
			VC_IMAGE_TF_Y8,   /* VCIII T-format 8-bit luma */
			VC_IMAGE_TF_A8,   /* VCIII T-format 8-bit alpha */
			VC_IMAGE_TF_SHORT,/* VCIII T-format 16-bit generic sample */
			VC_IMAGE_TF_1BPP, /* VCIII T-format 1bpp black/white */
			VC_IMAGE_OPENGL,
			VC_IMAGE_YUV444I, /* VCIII-B0 HVS YUV 4:4:4 interleaved samples */
			VC_IMAGE_YUV422PLANAR,  /* Y, U, & V planes separately (VC_IMAGE_YUV422 has them interleaved on a per line basis) */
			VC_IMAGE_ARGB8888,   /* 32bpp with 8bit alpha at MS byte, with R, G, B (LS byte) */
			VC_IMAGE_XRGB8888,   /* 32bpp with 8bit unused at MS byte, with R, G, B (LS byte) */

			VC_IMAGE_YUV422YUYV,  /* interleaved 8 bit samples of Y, U, Y, V */
			VC_IMAGE_YUV422YVYU,  /* interleaved 8 bit samples of Y, V, Y, U */
			VC_IMAGE_YUV422UYVY,  /* interleaved 8 bit samples of U, Y, V, Y */
			VC_IMAGE_YUV422VYUY,  /* interleaved 8 bit samples of V, Y, U, Y */

			VC_IMAGE_RGBX32,      /* 32bpp like RGBA32 but with unused alpha */
			VC_IMAGE_RGBX8888,    /* 32bpp, corresponding to RGBA with unused alpha */
			VC_IMAGE_BGRX8888,    /* 32bpp, corresponding to BGRA with unused alpha */

			VC_IMAGE_YUV420SP,    /* Y as a plane, then UV byte interleaved in plane with with same pitch, half height */

			VC_IMAGE_YUV444PLANAR,  /* Y, U, & V planes separately 4:4:4 */

			VC_IMAGE_TF_U8,   /* T-format 8-bit U - same as TF_Y8 buf from U plane */
			VC_IMAGE_TF_V8,   /* T-format 8-bit U - same as TF_Y8 buf from V plane */

			VC_IMAGE_MAX,     //bounds for error checking
			VC_IMAGE_FORCE_ENUM_16BIT = 0xffff,
		}

		public enum DISPMANX_TRANSFORM_T
		{
			/* Bottom 2 bits sets the orientation */
			DISPMANX_NO_ROTATE = 0,
			DISPMANX_ROTATE_90 = 1,
			DISPMANX_ROTATE_180 = 2,
			DISPMANX_ROTATE_270 = 3,

			DISPMANX_FLIP_HRIZ = 1 << 16,
			DISPMANX_FLIP_VERT = 1 << 17,

			/* invert left/right images */
			DISPMANX_STEREOSCOPIC_INVERT =  1 << 19,
			/* extra flags for controlling 3d duplication behaviour */
			DISPMANX_STEREOSCOPIC_NONE   =  0 << 20,
			DISPMANX_STEREOSCOPIC_MONO   =  1 << 20,
			DISPMANX_STEREOSCOPIC_SBS    =  2 << 20,
			DISPMANX_STEREOSCOPIC_TB     =  3 << 20,
			DISPMANX_STEREOSCOPIC_MASK   = 15 << 20,

			/* extra flags for controlling snapshot behaviour */
			DISPMANX_SNAPSHOT_NO_YUV = 1 << 24,
			DISPMANX_SNAPSHOT_NO_RGB = 1 << 25,
			DISPMANX_SNAPSHOT_FILL = 1 << 26,
			DISPMANX_SNAPSHOT_SWAP_RED_BLUE = 1 << 27,
			DISPMANX_SNAPSHOT_PACK = 1 << 28
		}

		public enum DISPMANX_FLAGS_ALPHA_T
		{
			/* Bottom 2 bits sets the alpha mode */
			DISPMANX_FLAGS_ALPHA_FROM_SOURCE = 0,
			DISPMANX_FLAGS_ALPHA_FIXED_ALL_PIXELS = 1,
			DISPMANX_FLAGS_ALPHA_FIXED_NON_ZERO = 2,
			DISPMANX_FLAGS_ALPHA_FIXED_EXCEED_0X07 = 3,

			DISPMANX_FLAGS_ALPHA_PREMULT = 1 << 16,
			DISPMANX_FLAGS_ALPHA_MIX = 1 << 17
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct VC_DISPMANX_ALPHA_T
		{
			DISPMANX_FLAGS_ALPHA_T flags;
			UInt32 opacity;
			DISPMANX_RESOURCE_HANDLE_T mask;
		}

		public enum DISPMANX_FLAGS_CLAMP_T
		{
			DISPMANX_FLAGS_CLAMP_NONE = 0,
			DISPMANX_FLAGS_CLAMP_LUMA_TRANSPARENT = 1,

			// If __VCCOREVER__ >= 0x04000000
			DISPMANX_FLAGS_CLAMP_TRANSPARENT = 2,
			DISPMANX_FLAGS_CLAMP_REPLACE = 3

			// If __VCCOREVER__ < 0x04000000
			// DISPMANX_FLAGS_CLAMP_CHROMA_TRANSPARENT = 2,
			// DISPMANX_FLAGS_CLAMP_TRANSPARENT = 3
		}

		public enum DISPMANX_FLAGS_KEYMASK_T
		{
			DISPMANX_FLAGS_KEYMASK_OVERRIDE = 1,
			DISPMANX_FLAGS_KEYMASK_SMOOTH = 1 << 1,
			DISPMANX_FLAGS_KEYMASK_CR_INV = 1 << 2,
			DISPMANX_FLAGS_KEYMASK_CB_INV = 1 << 3,
			DISPMANX_FLAGS_KEYMASK_YY_INV = 1 << 4
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct DISPMANX_CLAMP_KEYS_T
		{
			[FieldOffset(0)]
			Byte yuv_yy_upper;
			[FieldOffset(1)]
			Byte yuv_yy_lower;
			[FieldOffset(2)]
			Byte yuv_cr_upper;
			[FieldOffset(3)]
			Byte yuv_cr_lower;
			[FieldOffset(4)]
			Byte yuv_cb_upper;
			[FieldOffset(5)]
			Byte yuv_cb_lower;
			
			[FieldOffset(0)]
			Byte rgb_red_upper;
			[FieldOffset(1)]
			Byte rgb_red_lower;
			[FieldOffset(2)]
			Byte rgb_blue_upper;
			[FieldOffset(3)]
			Byte rgb_blue_lower;
			[FieldOffset(4)]
			Byte rgb_green_upper;
			[FieldOffset(5)]
			Byte rgb_green_lower;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct DISPMANX_CLAMP_T {
			DISPMANX_FLAGS_CLAMP_T mode;
			DISPMANX_FLAGS_KEYMASK_T key_mask;
			DISPMANX_CLAMP_KEYS_T key_value;
			UInt32 replace_value;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct EGL_DISPMANX_WINDOW_T
		{
			public UInt32 element;
			public int width;
			public int height;
		}

		public delegate void DISPMANX_CALLBACK_FUNC_T(DISPMANX_UPDATE_HANDLE_T u, IntPtr arg);

		#endregion

		public static void bcm_host_init()
		{
			Debug.Assert(Delegates.pbcm_host_init != null, "pbcm_host_init not implemented");
			Delegates.pbcm_host_init();
			LogCommand("bcm_host_init", null);
		}

		public static void bcm_host_deinit()
		{
			Debug.Assert(Delegates.pbcm_host_deinit != null, "pbcm_host_deinit not implemented");
			Delegates.pbcm_host_deinit();
			LogCommand("bcm_host_deinit", null);
		}

		public static int graphics_get_display_size(Int16 display_number, out Int32 width, out Int32 height)
		{
			int retvalue;

			Debug.Assert(Delegates.pgraphics_get_display_size != null, "pgraphics_get_display_size not implemented");
			retvalue = Delegates.pgraphics_get_display_size(display_number, out width, out height);
			LogCommand("graphics_get_display_size", retvalue, display_number, width, height);

			return (retvalue);
		}

		public static DISPMANX_DISPLAY_HANDLE_T vc_dispmanx_display_open(UInt32 device)
		{
			DISPMANX_DISPLAY_HANDLE_T retvalue;

			Debug.Assert(Delegates.pvc_dispmanx_display_open != null, "vc_dispmanx_display_open not implemented");
			retvalue = Delegates.pvc_dispmanx_display_open(device);
			LogCommand("vc_dispmanx_display_open", retvalue, device);

			return (retvalue);
		}

		public static int vc_dispmanx_display_close(DISPMANX_DISPLAY_HANDLE_T display)
		{
			int retvalue;

			Debug.Assert(Delegates.pvc_dispmanx_display_close != null, "vc_dispmanx_display_close not implemented");
			retvalue = Delegates.pvc_dispmanx_display_close(display);
			LogCommand("vc_dispmanx_display_close", retvalue, display);

			return (retvalue);
		}

		public static DISPMANX_UPDATE_HANDLE_T vc_dispmanx_update_start(Int32 priority)
		{
			DISPMANX_UPDATE_HANDLE_T retvalue;

			Debug.Assert(Delegates.pvc_dispmanx_update_start != null, "vc_dispmanx_update_start not implemented");
			retvalue = Delegates.pvc_dispmanx_update_start(priority);
			LogCommand("vc_dispmanx_update_start", retvalue, priority);

			return (retvalue);
		}

		public static DISPMANX_ELEMENT_HANDLE_T vc_dispmanx_element_add(DISPMANX_UPDATE_HANDLE_T update, DISPMANX_DISPLAY_HANDLE_T display, Int32 layer, VC_RECT_T dest_rect, DISPMANX_RESOURCE_HANDLE_T src, VC_RECT_T src_rect, DISPMANX_PROTECTION_T protection, IntPtr alpha, IntPtr clamp, DISPMANX_TRANSFORM_T transform)
		{
			DISPMANX_ELEMENT_HANDLE_T retvalue;

			GCHandle dest_rectHandle = GCHandle.Alloc(dest_rect, GCHandleType.Pinned);
			GCHandle src_rectHandle = GCHandle.Alloc(src_rect, GCHandleType.Pinned);
			try {
				Debug.Assert(Delegates.pvc_dispmanx_element_add != null, "vc_dispmanx_element_add not implemented");
				retvalue = Delegates.pvc_dispmanx_element_add(update, display, layer, dest_rectHandle.AddrOfPinnedObject(), src, src_rectHandle.AddrOfPinnedObject(), protection, alpha, clamp, transform);
				LogCommand("vc_dispmanx_element_add", retvalue, update, display, layer, dest_rect, src, src_rect, protection, alpha, clamp, transform);
			} finally {
				dest_rectHandle.Free();
				src_rectHandle.Free();
			}
			
			return (retvalue);
		}

		public static int vc_dispmanx_element_remove(DISPMANX_UPDATE_HANDLE_T update, DISPMANX_ELEMENT_HANDLE_T element)
		{
			int retvalue;

			Debug.Assert(Delegates.pvc_dispmanx_element_remove != null, "vc_dispmanx_element_remove not implemented");
			retvalue = Delegates.pvc_dispmanx_element_remove(update, element);
			LogCommand("vc_dispmanx_element_remove", retvalue, update, element);
			
			return (retvalue);
		}
			
		public static int vc_dispmanx_update_submit_sync(DISPMANX_UPDATE_HANDLE_T update)
		{
			int retvalue;

			Debug.Assert(Delegates.pvc_dispmanx_update_submit_sync != null, "vc_dispmanx_update_submit_sync not implemented");
			retvalue = Delegates.pvc_dispmanx_update_submit_sync(update);
			LogCommand("vc_dispmanx_update_submit_sync", retvalue, update);

			return (retvalue);
		}

		internal static class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "bcm_host_init")]
			internal static extern void bcm_host_init();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "bcm_host_deinit")]
			internal static extern void bcm_host_deinit();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "graphics_get_display_size")]
			internal static extern int graphics_get_display_size(Int16 display_number, out Int32 width, out Int32 height);

			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispman_init")]
			//internal extern static int vc_dispman_init();
			
			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_stop")]
			//internal extern static void vc_dispmanx_stop();

			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_rect_set")]
			//internal extern static int vc_dispmanx_rect_set(VC_RECT_T *rect, UInt32 x_offset, UInt32 y_offset, UInt32 width, UInt32 height);

			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_resource_create")]
			//internal extern static DISPMANX_RESOURCE_HANDLE_T vc_dispmanx_resource_create(VC_IMAGE_TYPE_T type, UInt32 width, UInt32 height, UInt32 *native_image_handle );

			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_resource_write_data")]
			//internal extern static int vc_dispmanx_resource_write_data(DISPMANX_RESOURCE_HANDLE_T res, VC_IMAGE_TYPE_T src_type, int src_pitch, void * src_address, ref VC_RECT_T rect);

			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_resource_write_data_handle")]
			//internal extern static int vc_dispmanx_resource_write_data_handle(DISPMANX_RESOURCE_HANDLE_T res, VC_IMAGE_TYPE_T src_type, int src_pitch, VCHI_MEM_HANDLE_T handle, UInt32 offset, ref VC_RECT_T rect );

			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_resource_read_data")]
			//internal extern static int vc_dispmanx_resource_read_data(DISPMANX_RESOURCE_HANDLE_T handle, ref VC_RECT_T p_rect, IntPtr dst_address, UInt32 dst_pitch);

			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_resource_delete")]
			//internal extern static int vc_dispmanx_resource_delete(DISPMANX_RESOURCE_HANDLE_T res);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "vc_dispmanx_display_open")]
			internal static extern DISPMANX_DISPLAY_HANDLE_T vc_dispmanx_display_open(UInt32 device);
			
			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_display_open_mode")]
			//internal extern static DISPMANX_DISPLAY_HANDLE_T vc_dispmanx_display_open_mode(UInt32 device, UInt32 mode);
			
			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_display_open_offscreen")]
			//internal extern static DISPMANX_DISPLAY_HANDLE_T vc_dispmanx_display_open_offscreen(DISPMANX_RESOURCE_HANDLE_T dest, DISPMANX_TRANSFORM_T orientation);
			
			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_display_reconfigure")]
			//internal extern static int vc_dispmanx_display_reconfigure(DISPMANX_DISPLAY_HANDLE_T display, UInt32 mode);
			
			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_display_set_destination")]
			//internal extern static int vc_dispmanx_display_set_destination(DISPMANX_DISPLAY_HANDLE_T display, DISPMANX_RESOURCE_HANDLE_T dest);
			
			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_display_set_background")]
			//internal extern static int vc_dispmanx_display_set_background(DISPMANX_UPDATE_HANDLE_T update, DISPMANX_DISPLAY_HANDLE_T display, Byte red, Byte green, Byte blue );
			
			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_display_get_info")]
			//internal extern static int vc_dispmanx_display_get_info(DISPMANX_DISPLAY_HANDLE_T display, DISPMANX_MODEINFO_T * pinfo);
			
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "vc_dispmanx_display_close")]
			internal static extern int vc_dispmanx_display_close(DISPMANX_DISPLAY_HANDLE_T display);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "vc_dispmanx_update_start")]
			internal static extern DISPMANX_UPDATE_HANDLE_T vc_dispmanx_update_start(Int32 priority);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "vc_dispmanx_element_add")]
			internal static extern DISPMANX_ELEMENT_HANDLE_T vc_dispmanx_element_add(DISPMANX_UPDATE_HANDLE_T update, DISPMANX_DISPLAY_HANDLE_T display, Int32 layer, IntPtr dest_rect, DISPMANX_RESOURCE_HANDLE_T src, IntPtr src_rect, DISPMANX_PROTECTION_T protection, IntPtr alpha, IntPtr clamp, DISPMANX_TRANSFORM_T transform);
			
			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_element_change_source")]
			//internal extern static int vc_dispmanx_element_change_source(DISPMANX_UPDATE_HANDLE_T update, DISPMANX_ELEMENT_HANDLE_T element, DISPMANX_RESOURCE_HANDLE_T src);
			
			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_element_change_layer")]
			//internal extern static int vc_dispmanx_element_change_layer(DISPMANX_UPDATE_HANDLE_T update, DISPMANX_ELEMENT_HANDLE_T element, Int32 layer);
			
			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_element_modified")]
			//internal extern static int vc_dispmanx_element_modified(DISPMANX_UPDATE_HANDLE_T update, DISPMANX_ELEMENT_HANDLE_T element, ref VC_RECT_T rect);
			
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "vc_dispmanx_element_remove")]
			internal static extern int vc_dispmanx_element_remove(DISPMANX_UPDATE_HANDLE_T update, DISPMANX_ELEMENT_HANDLE_T element);
			
			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_update_submit")]
			//internal extern static int vc_dispmanx_update_submit(DISPMANX_UPDATE_HANDLE_T update, DISPMANX_CALLBACK_FUNC_T cb_func, void *cb_arg);
			
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "vc_dispmanx_update_submit_sync")]
			internal static extern int vc_dispmanx_update_submit_sync(DISPMANX_UPDATE_HANDLE_T update);
			
			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_query_image_formats")]
			//internal extern static int vc_dispmanx_query_image_formats(UInt32 *supported_formats);

			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_element_change_attributes")]
			//internal extern static int vc_dispmanx_element_change_attributes(DISPMANX_UPDATE_HANDLE_T update, DISPMANX_ELEMENT_HANDLE_T element, UInt32 change_flags, Int32 layer, Byte opacity,  ref VC_RECT_T dest_rect, ref VC_RECT_T src_rect, DISPMANX_RESOURCE_HANDLE_T mask, DISPMANX_TRANSFORM_T transform);

			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_resource_get_image_handle")]
			//internal extern static UInt32 vc_dispmanx_resource_get_image_handle(DISPMANX_RESOURCE_HANDLE_T res);

			// [SuppressUnmanagedCodeSecurity()]
			// [DllImport(Library, EntryPoint = "vc_vchi_dispmanx_init")]
			// internal extern static void vc_vchi_dispmanx_init(VCHI_INSTANCE_T initialise_instance, VCHI_CONNECTION_T **connections, UInt32 num_connections );

			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_snapshot")]
			//internal extern static int vc_dispmanx_snapshot( DISPMANX_DISPLAY_HANDLE_T display, DISPMANX_RESOURCE_HANDLE_T snapshot_resource, DISPMANX_TRANSFORM_T transform);

			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_resource_set_palette")]
			//internal extern static int vc_dispmanx_resource_set_palette(DISPMANX_RESOURCE_HANDLE_T handle, IntPtr src_address, int offset, int size);

			//[SuppressUnmanagedCodeSecurity()]
			//[DllImport(Library, EntryPoint = "vc_dispmanx_vsync_callback")]
			//internal extern static int vc_dispmanx_vsync_callback(DISPMANX_DISPLAY_HANDLE_T display, DISPMANX_CALLBACK_FUNC_T cb_func, void *cb_arg);
		}

		internal static class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void bcm_host_init();

			internal static bcm_host_init pbcm_host_init;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void bcm_host_deinit();

			internal static bcm_host_deinit pbcm_host_deinit;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int graphics_get_display_size(Int16 display_number, out Int32 width, out Int32 height);

			internal static graphics_get_display_size pgraphics_get_display_size;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate DISPMANX_DISPLAY_HANDLE_T vc_dispmanx_display_open(UInt32 device);

			internal static vc_dispmanx_display_open pvc_dispmanx_display_open;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int vc_dispmanx_display_close(DISPMANX_DISPLAY_HANDLE_T display);

			internal static vc_dispmanx_display_close pvc_dispmanx_display_close;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate DISPMANX_UPDATE_HANDLE_T vc_dispmanx_update_start(Int32 priority);

			internal static vc_dispmanx_update_start pvc_dispmanx_update_start;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate DISPMANX_ELEMENT_HANDLE_T vc_dispmanx_element_add(DISPMANX_UPDATE_HANDLE_T update, DISPMANX_DISPLAY_HANDLE_T display, Int32 layer, IntPtr dest_rect, DISPMANX_RESOURCE_HANDLE_T src, IntPtr src_rect, DISPMANX_PROTECTION_T protection, IntPtr alpha, IntPtr clamp, DISPMANX_TRANSFORM_T transform);

			internal static vc_dispmanx_element_add pvc_dispmanx_element_add;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int vc_dispmanx_element_remove(DISPMANX_UPDATE_HANDLE_T update, DISPMANX_ELEMENT_HANDLE_T element);

			internal static vc_dispmanx_element_remove pvc_dispmanx_element_remove;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int vc_dispmanx_update_submit_sync(DISPMANX_UPDATE_HANDLE_T update);

			internal static vc_dispmanx_update_submit_sync pvc_dispmanx_update_submit_sync;
			
		}

		#endregion
	}
}
