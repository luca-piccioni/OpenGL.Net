
// Copyright (C) 2012-2015 Luca Piccioni
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
using System.Windows.Forms;

namespace OpenGL
{
	/// <summary>
	/// An opaque handle that represents the platform dependent device context.
	/// </summary>
	public interface IDeviceContext : IDisposable
	{
		#region Referenceable Instance
		
		/// <summary>
		/// Number of shared instances of this IRenderResource.
		/// </summary>
		/// <remarks>
		/// The reference count shall be initially 0 on new instances.
		/// </remarks>
		uint RefCount { get; }

		/// <summary>
		/// Increment the shared IRenderResource reference count.
		/// </summary>
		/// <remarks>
		/// Incrementing the reference count for this resource prevents the system to dispose this instance.
		/// </remarks>
		void IncRef();

		/// <summary>
		/// Decrement the shared IResource reference count.
		/// </summary>
		/// <remarks>
		/// Decrementing the reference count for this resource could cause this instance disposition. In the case
		/// the reference count equals 0 (with or without decrementing it), this instance will be disposed.
		/// </remarks>
		void DecRef();

		#endregion

		#region Pixel Formats

		/// <summary>
		/// Get the pixel formats supported by this device.
		/// </summary>
		DevicePixelFormatCollection PixelsFormats { get; }

		/// <summary>
		/// Set the device pixel format.
		/// </summary>
		/// <param name="pixelFormat">
		/// A <see cref="DevicePixelFormat"/> that specifies the pixel format to set.
		/// </param>
		void SetPixelFormat(DevicePixelFormat pixelFormat);

		#endregion
	}
}