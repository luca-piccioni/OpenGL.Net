
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

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Egl
	{
		/// <summary>
		/// Value of EGL_NO_OUTPUT_LAYER_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_output_base")]
		public const int NO_OUTPUT_LAYER_EXT = 0;

		/// <summary>
		/// Value of EGL_NO_OUTPUT_PORT_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_output_base")]
		public const int NO_OUTPUT_PORT_EXT = 0;

		/// <summary>
		/// Value of EGL_BAD_OUTPUT_LAYER_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_output_base")]
		public const int BAD_OUTPUT_LAYER_EXT = 0x322D;

		/// <summary>
		/// Value of EGL_BAD_OUTPUT_PORT_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_output_base")]
		public const int BAD_OUTPUT_PORT_EXT = 0x322E;

		/// <summary>
		/// Value of EGL_SWAP_INTERVAL_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_output_base")]
		public const int SWAP_INTERVAL_EXT = 0x322F;

		/// <summary>
		/// Binding for eglGetOutputLayersEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="layers">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="max_layers">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="num_layers">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_output_base")]
		public static bool GetOutputLayersEXT(IntPtr dpy, IntPtr[] attrib_list, [Out] IntPtr[] layers, int max_layers, [Out] int[] num_layers)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				fixed (IntPtr* p_layers = layers)
				fixed (int* p_num_layers = num_layers)
				{
					Debug.Assert(Delegates.peglGetOutputLayersEXT != null, "peglGetOutputLayersEXT not implemented");
					retValue = Delegates.peglGetOutputLayersEXT(dpy, p_attrib_list, p_layers, max_layers, p_num_layers);
					LogFunction("eglGetOutputLayersEXT(0x{0}, {1}, {2}, {3}, {4}) = {5}", dpy.ToString("X8"), LogValue(attrib_list), LogValue(layers), max_layers, LogValue(num_layers), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglGetOutputPortsEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="ports">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="max_ports">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="num_ports">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_output_base")]
		public static bool GetOutputPortsEXT(IntPtr dpy, IntPtr[] attrib_list, [Out] IntPtr[] ports, int max_ports, [Out] int[] num_ports)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				fixed (IntPtr* p_ports = ports)
				fixed (int* p_num_ports = num_ports)
				{
					Debug.Assert(Delegates.peglGetOutputPortsEXT != null, "peglGetOutputPortsEXT not implemented");
					retValue = Delegates.peglGetOutputPortsEXT(dpy, p_attrib_list, p_ports, max_ports, p_num_ports);
					LogFunction("eglGetOutputPortsEXT(0x{0}, {1}, {2}, {3}, {4}) = {5}", dpy.ToString("X8"), LogValue(attrib_list), LogValue(ports), max_ports, LogValue(num_ports), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglOutputLayerAttribEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="layer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_output_base")]
		public static bool OutputLayerAttribEXT(IntPtr dpy, IntPtr layer, int attribute, IntPtr value)
		{
			bool retValue;

			Debug.Assert(Delegates.peglOutputLayerAttribEXT != null, "peglOutputLayerAttribEXT not implemented");
			retValue = Delegates.peglOutputLayerAttribEXT(dpy, layer, attribute, value);
			LogFunction("eglOutputLayerAttribEXT(0x{0}, 0x{1}, {2}, 0x{3}) = {4}", dpy.ToString("X8"), layer.ToString("X8"), attribute, value.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglQueryOutputLayerAttribEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="layer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_output_base")]
		public static bool QueryOutputLayerAttribEXT(IntPtr dpy, IntPtr layer, int attribute, IntPtr[] value)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_value = value)
				{
					Debug.Assert(Delegates.peglQueryOutputLayerAttribEXT != null, "peglQueryOutputLayerAttribEXT not implemented");
					retValue = Delegates.peglQueryOutputLayerAttribEXT(dpy, layer, attribute, p_value);
					LogFunction("eglQueryOutputLayerAttribEXT(0x{0}, 0x{1}, {2}, {3}) = {4}", dpy.ToString("X8"), layer.ToString("X8"), attribute, LogValue(value), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglQueryOutputLayerStringEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="layer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_output_base")]
		public static string QueryOutputLayerStringEXT(IntPtr dpy, IntPtr layer, int name)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglQueryOutputLayerStringEXT != null, "peglQueryOutputLayerStringEXT not implemented");
			retValue = Delegates.peglQueryOutputLayerStringEXT(dpy, layer, name);
			LogFunction("eglQueryOutputLayerStringEXT(0x{0}, 0x{1}, {2}) = {3}", dpy.ToString("X8"), layer.ToString("X8"), name, Marshal.PtrToStringAnsi(retValue));
			DebugCheckErrors(retValue);

			return (Marshal.PtrToStringAnsi(retValue));
		}

		/// <summary>
		/// Binding for eglOutputPortAttribEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="port">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_output_base")]
		public static bool OutputPortAttribEXT(IntPtr dpy, IntPtr port, int attribute, IntPtr value)
		{
			bool retValue;

			Debug.Assert(Delegates.peglOutputPortAttribEXT != null, "peglOutputPortAttribEXT not implemented");
			retValue = Delegates.peglOutputPortAttribEXT(dpy, port, attribute, value);
			LogFunction("eglOutputPortAttribEXT(0x{0}, 0x{1}, {2}, 0x{3}) = {4}", dpy.ToString("X8"), port.ToString("X8"), attribute, value.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglQueryOutputPortAttribEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="port">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_output_base")]
		public static bool QueryOutputPortAttribEXT(IntPtr dpy, IntPtr port, int attribute, IntPtr[] value)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_value = value)
				{
					Debug.Assert(Delegates.peglQueryOutputPortAttribEXT != null, "peglQueryOutputPortAttribEXT not implemented");
					retValue = Delegates.peglQueryOutputPortAttribEXT(dpy, port, attribute, p_value);
					LogFunction("eglQueryOutputPortAttribEXT(0x{0}, 0x{1}, {2}, {3}) = {4}", dpy.ToString("X8"), port.ToString("X8"), attribute, LogValue(value), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglQueryOutputPortStringEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="port">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_output_base")]
		public static string QueryOutputPortStringEXT(IntPtr dpy, IntPtr port, int name)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglQueryOutputPortStringEXT != null, "peglQueryOutputPortStringEXT not implemented");
			retValue = Delegates.peglQueryOutputPortStringEXT(dpy, port, name);
			LogFunction("eglQueryOutputPortStringEXT(0x{0}, 0x{1}, {2}) = {3}", dpy.ToString("X8"), port.ToString("X8"), name, Marshal.PtrToStringAnsi(retValue));
			DebugCheckErrors(retValue);

			return (Marshal.PtrToStringAnsi(retValue));
		}

	}

}
