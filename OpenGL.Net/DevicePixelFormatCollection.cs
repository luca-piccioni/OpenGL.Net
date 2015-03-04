
// Copyright (C) 2009-2015 Luca Piccioni
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
using System.Diagnostics;

namespace OpenGL
{
	/// <summary>
	/// List of pixel format descriptions.
	/// </summary>
	[DebuggerDisplay("DevicePixelFormatCollection({Count} Pixel Formats)")]
	public class DevicePixelFormatCollection : List<DevicePixelFormat>
	{
		#region Render Window Format Filtering

		#region Window Color Bits

		/// <summary>
		/// Get all possible color bit values for rendering on visibile windows.
		/// </summary>
		/// <returns>
		/// It returns a list of integer values suitable for requesting color buffer bits.
		/// </returns>
		public IEnumerable<int> GetWindowColorBits()
		{
			return (GetWindowColorBits(-1, -1, -1));
		}

		/// <summary>
		/// Get all possible color bit values for rendering on visibile windows.
		/// </summary>
		/// <param name="bitsMultisample">
		/// A <see cref="System.Int32"/> that specifies the required multisample buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <returns>
		/// It returns a list of integer values suitable for requesting color buffer bits.
		/// </returns>
		public IEnumerable<int> GetWindowColorBits(int bitsMultisample)
		{
			return (GetWindowColorBits(-1, -1, bitsMultisample));
		}

		/// <summary>
		/// Get all possible color bit values for rendering on visibile windows.
		/// </summary>
		/// <param name="bitsDepth">
		/// A <see cref="System.Int32"/> that specifies the required depth buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <param name="bitsMultisample">
		/// A <see cref="System.Int32"/> that specifies the required multisample buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <returns>
		/// It returns a list of integer values suitable for requesting color buffer bits.
		/// </returns>
		public IEnumerable<int> GetWindowColorBits(int bitsDepth, int bitsMultisample)
		{
			return (GetWindowColorBits(bitsDepth, -1, bitsMultisample));
		}

		/// <summary>
		/// Get all possible color bit values for rendering on visibile windows.
		/// </summary>
		/// <param name="bitsDepth">
		/// A <see cref="System.Int32"/> that specifies the required depth buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <param name="bitsStencil">
		/// A <see cref="System.Int32"/> that specifies the required stencil buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <param name="bitsMultisample">
		/// A <see cref="System.Int32"/> that specifies the required multisample buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <returns>
		/// It returns a list of integer values suitable for requesting color buffer bits.
		/// </returns>
		public IEnumerable<int> GetWindowColorBits(int bitsDepth, int bitsStencil, int bitsMultisample)
		{
			List<DevicePixelFormat> windowPixelFormats = this;

			// Filter for window rendering type
			windowPixelFormats = FilterPixelFormatByWindow(windowPixelFormats);
			// Filter for buffer bits
			return (GetFormatColorBits(windowPixelFormats, bitsDepth, bitsStencil, bitsMultisample));
		}

		#endregion

		#region Window Depth Bits

		/// <summary>
		/// Get all possible depth bit values for rendering on visibile windows.
		/// </summary>
		/// <returns>
		/// It returns a list of integer values suitable for requesting depth buffer bits.
		/// </returns>
		public IEnumerable<int> GetWindowDepthBits()
		{
			return (GetWindowDepthBits(-1, -1, -1));
		}

		/// <summary>
		/// Get all possible depth bit values for rendering on visibile windows.
		/// </summary>
		/// <param name="bitsColor">
		/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <returns>
		/// It returns a list of integer values suitable for requesting depth buffer bits.
		/// </returns>
		public IEnumerable<int> GetWindowDepthBits(int bitsColor)
		{
			return (GetWindowDepthBits(bitsColor, -1, -1));
		}

		/// <summary>
		/// Get all possible depth bit values for rendering on visibile windows.
		/// </summary>
		/// <param name="bitsColor">
		/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <param name="bitsMultisample">
		/// A <see cref="System.Int32"/> that specifies the required multisample buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <returns>
		/// It returns a list of integer values suitable for requesting depth buffer bits.
		/// </returns>
		public IEnumerable<int> GetWindowDepthBits(int bitsColor, int bitsMultisample)
		{
			return (GetWindowDepthBits(bitsColor, -1, bitsMultisample));
		}

		/// <summary>
		/// Get all possible depth bit values for rendering on visibile windows.
		/// </summary>
		/// <param name="colorBits">
		/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <param name="bitsStencil">
		/// A <see cref="System.Int32"/> that specifies the required stencil buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <param name="bitsMultisample">
		/// A <see cref="System.Int32"/> that specifies the required multisample buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <returns>
		/// It returns a list of integer values suitable for requesting depth buffer bits.
		/// </returns>
		public IEnumerable<int> GetWindowDepthBits(int colorBits, int bitsStencil, int bitsMultisample)
		{
			List<DevicePixelFormat> windowPixelFormats = this;

			// Filter for window rendering type
			windowPixelFormats = FilterPixelFormatByWindow(windowPixelFormats);
			// Filter for buffer bits
			return (GetFormatDepthBits(windowPixelFormats, colorBits, bitsStencil, bitsMultisample));
		}

		#endregion

		#region Window Stencil Bits

		/// <summary>
		/// Get all possible multisample bit values for rendering on visibile windows.
		/// </summary>
		/// <returns>
		/// It returns a list of integer values suitable for requesting depth buffer bits.
		/// </returns>
		public IEnumerable<int> GetWindowStencilBits()
		{
			return (GetWindowStencilBits(-1, -1, -1));
		}

		/// <summary>
		/// Get all possible multisample bit values for rendering on visibile windows.
		/// </summary>
		/// <param name="bitsColor">
		/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <returns>
		/// It returns a list of integer values suitable for requesting depth buffer bits.
		/// </returns>
		public IEnumerable<int> GetWindowStencilBits(int bitsColor)
		{
			return (GetWindowStencilBits(bitsColor, -1, -1));
		}

		/// <summary>
		/// Get all possible multisample bit values for rendering on visibile windows.
		/// </summary>
		/// <param name="bitsColor">
		/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <param name="bitsDepth">
		/// A <see cref="System.Int32"/> that specifies the required depth buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <returns>
		/// It returns a list of integer values suitable for requesting depth buffer bits.
		/// </returns>
		public IEnumerable<int> GetWindowStencilBits(int bitsColor, int bitsDepth)
		{
			return (GetWindowStencilBits(bitsColor, bitsDepth, -1));
		}

		/// <summary>
		/// Get all possible multisample bit values for rendering on visibile windows.
		/// </summary>
		/// <param name="bitsColor">
		/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <param name="bitsDepth">
		/// A <see cref="System.Int32"/> that specifies the required depth buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <param name="bitsMultisample">
		/// A <see cref="System.Int32"/> that specifies the required multisample buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <returns>
		/// It returns a list of integer values suitable for requesting depth buffer bits.
		/// </returns>
		public IEnumerable<int> GetWindowStencilBits(int bitsColor, int bitsDepth, int bitsMultisample)
		{
			List<DevicePixelFormat> windowPixelFormats = this;

			// Filter for window rendering type
			windowPixelFormats = FilterPixelFormatByWindow(windowPixelFormats);
			// Filter for buffer bits
			return (GetFormatStencilBits(windowPixelFormats, bitsColor, bitsDepth, bitsMultisample));
		}

		#endregion

		#region Window Multisample Bits

		/// <summary>
		/// Get all possible multisample bit values for rendering on visibile windows.
		/// </summary>
		/// <returns>
		/// It returns a list of integer values suitable for requesting depth buffer bits.
		/// </returns>
		public IEnumerable<int> GetWindowMultisampleBits()
		{
			return (GetWindowMultisampleBits(-1, -1, -1));
		}

		/// <summary>
		/// Get all possible multisample bit values for rendering on visibile windows.
		/// </summary>
		/// <param name="bitsColor">
		/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <returns>
		/// It returns a list of integer values suitable for requesting depth buffer bits.
		/// </returns>
		public IEnumerable<int> GetWindowMultisampleBits(int bitsColor)
		{
			return (GetWindowMultisampleBits(bitsColor, -1, -1));
		}

		/// <summary>
		/// Get all possible multisample bit values for rendering on visibile windows.
		/// </summary>
		/// <param name="bitsColor">
		/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <param name="bitsDepth">
		/// A <see cref="System.Int32"/> that specifies the required depth buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <returns>
		/// It returns a list of integer values suitable for requesting depth buffer bits.
		/// </returns>
		public IEnumerable<int> GetWindowMultisampleBits(int bitsColor, int bitsDepth)
		{
			return (GetWindowMultisampleBits(bitsColor, bitsDepth, -1));
		}

		/// <summary>
		/// Get all possible multisample bit values for rendering on visibile windows.
		/// </summary>
		/// <param name="bitsColor">
		/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <param name="bitsDepth">
		/// A <see cref="System.Int32"/> that specifies the required depth buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <param name="bitsStencil">
		/// A <see cref="System.Int32"/> that specifies the required stencil buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <returns>
		/// It returns a list of integer values suitable for requesting depth buffer bits.
		/// </returns>
		public IEnumerable<int> GetWindowMultisampleBits(int bitsColor, int bitsDepth, int bitsStencil)
		{
			List<DevicePixelFormat> windowPixelFormats = this;

			// Filter for window rendering type
			windowPixelFormats = FilterPixelFormatByWindow(windowPixelFormats);
			// Filter for buffer bits
			return (GetFormatMultisampleBits(windowPixelFormats, bitsColor, bitsStencil, bitsStencil));
		}

		#endregion

		#endregion

		#region Render Buffer Format Filtering



		#endregion

		#region Render PBuffer Format Filtering



		#endregion

		#region Pixel Format Filtering

		#region Combined Bits Filter

		/// <summary>
		/// Get all possible color bit values for rendering on a certain pixel format list.
		/// </summary>
		/// <param name="pFormats">
		/// A <see cref="System.Int32"/> that specifies the initially available pixel formats.
		/// </param>
		/// <param name="bitsDepth">
		/// A <see cref="System.Int32"/> that specifies the required depth buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <param name="bitsStencil">
		/// A <see cref="System.Int32"/> that specifies the required stencil buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <param name="bitsMultisample">
		/// A <see cref="System.Int32"/> that specifies the required multisample buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <returns>
		/// It returns a list of integer values suitable for requesting color buffer bits.
		/// </returns>
		private static IEnumerable<int> GetFormatColorBits(List<DevicePixelFormat> pFormats, int bitsDepth, int bitsStencil, int bitsMultisample)
		{
			SortedDictionary<int, int> windowColorBits = new SortedDictionary<int, int>();

			// Filter for buffer bits
			if (bitsDepth > 0)
				pFormats = FilterPixelFormatByDepthBits(pFormats, bitsDepth);
			if (bitsStencil > 0)
				pFormats = FilterPixelFormatByStencilBits(pFormats, bitsStencil);
			if (bitsMultisample > 0)
				pFormats = FilterPixelFormatByMultisampleBits(pFormats, bitsMultisample);
			// Find all unique color bits combinations
			foreach (DevicePixelFormat pFormat in pFormats)
				if (windowColorBits.ContainsKey(pFormat.ColorBits) == false)
					windowColorBits.Add(pFormat.ColorBits, pFormat.ColorBits);

			return (windowColorBits.Keys);
		}

		/// <summary>
		/// Get all possible depth bit values for rendering on a certain pixel format list.
		/// </summary>
		/// <param name="pFormats">
		/// A <see cref="System.Int32"/> that specifies the initially available pixel formats.
		/// </param>
		/// <param name="bitsColor">
		/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <param name="bitsStencil">
		/// A <see cref="System.Int32"/> that specifies the required stencil buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <param name="bitsMultisample">
		/// A <see cref="System.Int32"/> that specifies the required multisample buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <returns>
		/// It returns a list of integer values suitable for requesting color buffer bits.
		/// </returns>
		private static IEnumerable<int> GetFormatDepthBits(List<DevicePixelFormat> pFormats, int bitsColor, int bitsStencil, int bitsMultisample)
		{
			SortedDictionary<int, int> windowColorBits = new SortedDictionary<int, int>();

			// Filter for buffer bits
			if (bitsColor > 0)
				pFormats = FilterPixelFormatByColorBits(pFormats, bitsColor);
			if (bitsStencil > 0)
				pFormats = FilterPixelFormatByStencilBits(pFormats, bitsStencil);
			if (bitsMultisample > 0)
				pFormats = FilterPixelFormatByMultisampleBits(pFormats, bitsMultisample);
			// Find all unique color bits combinations
			foreach (DevicePixelFormat pFormat in pFormats)
				if (windowColorBits.ContainsKey(pFormat.DepthBits) == false)
					windowColorBits.Add(pFormat.DepthBits, pFormat.ColorBits);

			return (windowColorBits.Keys);
		}

		/// <summary>
		/// Get all possible stencil bit values for rendering on a certain pixel format list.
		/// </summary>
		/// <param name="pFormats">
		/// A <see cref="System.Int32"/> that specifies the initially available pixel formats.
		/// </param>
		/// <param name="bitsColor">
		/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <param name="bitsDepth">
		/// A <see cref="System.Int32"/> that specifies the required depth buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <param name="bitsMultisample">
		/// A <see cref="System.Int32"/> that specifies the required multisample buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <returns>
		/// It returns a list of integer values suitable for requesting depth buffer bits.
		/// </returns>
		private static IEnumerable<int> GetFormatStencilBits(List<DevicePixelFormat> pFormats, int bitsColor, int bitsDepth, int bitsMultisample)
		{
			SortedDictionary<int, int> windowColorBits = new SortedDictionary<int, int>();

			// Filter for buffer bits
			if (bitsColor > 0)
				pFormats = FilterPixelFormatByColorBits(pFormats, bitsColor);
			if (bitsDepth > 0)
				pFormats = FilterPixelFormatByDepthBits(pFormats, bitsDepth);
			if (bitsMultisample > 0)
				pFormats = FilterPixelFormatByMultisampleBits(pFormats, bitsMultisample);
			// Find all unique color bits combinations
			foreach (DevicePixelFormat pFormat in pFormats)
				if (windowColorBits.ContainsKey(pFormat.StencilBits) == false)
					windowColorBits.Add(pFormat.StencilBits, pFormat.ColorBits);

			return (windowColorBits.Keys);
		}

		/// <summary>
		/// Get all possible multisample bit values for rendering on a certain pixel format list.
		/// </summary>
		/// <param name="pFormats">
		/// A <see cref="System.Int32"/> that specifies the initially available pixel formats.
		/// </param>
		/// <param name="bitsColor">
		/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <param name="bitsDepth">
		/// A <see cref="System.Int32"/> that specifies the required depth buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <param name="bitsStencil">
		/// A <see cref="System.Int32"/> that specifies the required stencil buffer bits. This parameter is ignored in the case is
		/// less or equals to 0.
		/// </param>
		/// <returns>
		/// It returns a list of integer values suitable for requesting multisample buffer bits.
		/// </returns>
		private static IEnumerable<int> GetFormatMultisampleBits(List<DevicePixelFormat> pFormats, int bitsColor, int bitsDepth, int bitsStencil)
		{
			SortedDictionary<int, int> windowColorBits = new SortedDictionary<int, int>();

			// Filter for buffer bits
			if (bitsColor > 0)
				pFormats = FilterPixelFormatByColorBits(pFormats, bitsColor);
			if (bitsDepth > 0)
				pFormats = FilterPixelFormatByDepthBits(pFormats, bitsDepth);
			if (bitsStencil > 0)
				pFormats = FilterPixelFormatByStencilBits(pFormats, bitsStencil);
			// Find all unique color bits combinations
			foreach (DevicePixelFormat pFormat in pFormats)
				if (windowColorBits.ContainsKey(pFormat.MultisampleBits) == false)
					windowColorBits.Add(pFormat.MultisampleBits, pFormat.ColorBits);

			return (windowColorBits.Keys);
		}

		#endregion

		#region Render Mode Filter

		private List<DevicePixelFormat> FilterPixelFormatByWindow(List<DevicePixelFormat> formats)
		{
			if (formats == null)
				throw new ArgumentNullException("formats");

			return (formats.FindAll(delegate(DevicePixelFormat pFormat) { return (pFormat.RenderWindow); }));
		}

		private List<DevicePixelFormat> FilterPixelFormatByBuffer(List<DevicePixelFormat> formats)
		{
			if (formats == null)
				throw new ArgumentNullException("formats");

			return (formats.FindAll(delegate(DevicePixelFormat pFormat) { return (pFormat.RenderBuffer); }));
		}

		private List<DevicePixelFormat> FilterPixelFormatByPBuffer(List<DevicePixelFormat> formats)
		{
			if (formats == null)
				throw new ArgumentNullException("formats");

			return (formats.FindAll(delegate(DevicePixelFormat pFormat) { return (pFormat.RenderPBuffer); }));
		}

		#endregion

		#region Color/Depth/Stencil/Multisample Bits Filter

		private static List<DevicePixelFormat> FilterPixelFormatByColorBits(List<DevicePixelFormat> formats, int bits)
		{
			if (formats == null)
				throw new ArgumentNullException("formats");

			return (formats.FindAll(delegate(DevicePixelFormat pFormat) { return (pFormat.ColorBits == bits); }));
		}

		private static List<DevicePixelFormat> FilterPixelFormatByDepthBits(List<DevicePixelFormat> formats, int bits)
		{
			if (formats == null)
				throw new ArgumentNullException("formats");

			return (formats.FindAll(delegate(DevicePixelFormat pFormat) { return (pFormat.DepthBits == bits); }));
		}

		private static List<DevicePixelFormat> FilterPixelFormatByStencilBits(List<DevicePixelFormat> formats, int bits)
		{
			if (formats == null)
				throw new ArgumentNullException("formats");

			return (formats.FindAll(delegate(DevicePixelFormat pFormat) { return (pFormat.StencilBits == bits); }));
		}

		private static List<DevicePixelFormat> FilterPixelFormatByMultisampleBits(List<DevicePixelFormat> formats, int bits)
		{
			if (formats == null)
				throw new ArgumentNullException("formats");

			return (formats.FindAll(delegate(DevicePixelFormat pFormat) { return (pFormat.MultisampleBits == bits); }));
		}

		#endregion

		#endregion
	}
}
