
// Copyright (C) 2009-2016 Luca Piccioni
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
	[DebuggerDisplay("DevicePixelFormatCollection: Count={Count}")]
	public class DevicePixelFormatCollection : List<DevicePixelFormat>
	{
		/// <summary>
		/// Choose a <see cref="DevicePixelFormat"/>
		/// </summary>
		/// <param name="pixelFormat">
		/// A <see cref="DevicePixelFormat"/> that specify the minimum requirements
		/// </param>
		/// <returns></returns>
		public List<DevicePixelFormat> Choose(DevicePixelFormat pixelFormat)
		{
			if (pixelFormat == null)
				throw new ArgumentNullException("pixelFormat");

			List<DevicePixelFormat> pixelFormats = new List<DevicePixelFormat>(this);

			pixelFormats.RemoveAll(delegate (DevicePixelFormat item) {
				if (pixelFormat.RgbaUnsigned && !item.RgbaUnsigned)
					return (true);
				if (pixelFormat.RgbaFloat && !item.RgbaFloat)
					return (true);

				if (pixelFormat.RenderWindow && !item.RenderWindow)
					return (true);
				if (pixelFormat.RenderPBuffer && !item.RenderPBuffer)
					return (true);
				if (pixelFormat.RenderBuffer && !item.RenderBuffer)
					return (true);

				if (pixelFormat.SRGBCapable && !item.SRGBCapable)
					return (true);
				if (pixelFormat.DoubleBuffer && !item.DoubleBuffer)
					return (true);

				if (item.ColorBits < pixelFormat.ColorBits)
					return (true);
				if (item.RedBits < pixelFormat.RedBits)
					return (true);
				if (item.GreenBits < pixelFormat.GreenBits)
					return (true);
				if (item.BlueBits < pixelFormat.BlueBits)
					return (true);
				if (item.AlphaBits < pixelFormat.AlphaBits)
					return (true);

				if (item.DepthBits < pixelFormat.DepthBits)
					return (true);
				if (item.StencilBits < pixelFormat.StencilBits)
					return (true);

				return (false);
			});

			List<DevicePixelFormat> pixelFormatsCopy = new List<DevicePixelFormat>();

			foreach (DevicePixelFormat devicePixelFormat in pixelFormats)
				pixelFormatsCopy.Add(devicePixelFormat.Copy());

			// Sort (ascending by resource occupation)
			pixelFormatsCopy.Sort(delegate (DevicePixelFormat x, DevicePixelFormat y) {
				int compare;

				if ((compare = x.ColorBits.CompareTo(y.ColorBits)) != 0)
					return (compare);
				if ((compare = x.DepthBits.CompareTo(y.DepthBits)) != 0)
					return (compare);
				if ((compare = x.StencilBits.CompareTo(y.StencilBits)) != 0)
					return (compare);

				if ((compare = y.DoubleBuffer.CompareTo(x.DoubleBuffer)) != 0)
					return (compare);

				return (0);
			});

			return (pixelFormatsCopy);
		}

		/// <summary>
		/// Copy this DevicePixelFormatCollection.
		/// </summary>
		/// <returns>
		/// It returns a <see cref="DevicePixelFormatCollection"/> equivalent to this DevicePixelFormatCollection.
		/// </returns>
		public DevicePixelFormatCollection Copy()
		{
			DevicePixelFormatCollection pixelFormats = new DevicePixelFormatCollection();

			foreach (DevicePixelFormat devicePixelFormat in this)
				pixelFormats.Add(devicePixelFormat.Copy());

			return (pixelFormats);
		}
	}
}
