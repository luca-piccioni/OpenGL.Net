
// Copyright (C) 2016-2017 Luca Piccioni
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

using Handle = System.UInt32;
using NativeStreamType = System.UInt32;

using System;

namespace OpenWF
{
	/// <summary>
	/// OpenWF Composition Source abstraction.
	/// </summary>
	public sealed class WfcSource : IDisposable
	{
		#region Constructors

		/// <summary>
		/// Create an OpenWF Composition source.
		/// </summary>
		/// <param name="device">
		/// A <see cref="WfcDevice"/> which the source is created on.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="WfcContext"/> which the source is created on.
		/// </param>
		/// <param name="stream">
		/// A <see cref="NativeStreamType"/> that specifies the native source stream.
		/// </param>
		internal WfcSource(WfcDevice device, WfcContext ctx, NativeStreamType stream)
		{
			if (device == null)
				throw new ArgumentNullException("device");

			if ((_Handle = Wfc.CreateSourceFromStream(device.Handle, ctx.Handle, stream, null)) == Wfc.INVALID_HANDLE)
				throw new InvalidOperationException(String.Format("unable to create OpenWF source"));

			_Device = device;
		}

		#endregion

		#region Handle

		/// <summary>
		/// Get the source handle.
		/// </summary>
		internal Handle Handle { get { return (_Handle); } }

		/// <summary>
		/// The source handle.
		/// </summary>
		private Handle _Handle;

		/// <summary>
		/// The device handle.
		/// </summary>
		private readonly WfcDevice _Device;

		#endregion

		#region IDisposable Implementation

		/// <summary>
		/// Finalizer.
		/// </summary>
		~WfcSource()
		{
			Dispose(false);
		}

		// <summary>
		/// Releases all resource used by the <see cref="WfcSource"/> object.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>
		/// Releases all resource used by the <see cref="WfcSource"/> object.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="Boolean"/> indicating whether the disposition happens in a managed context.
		/// </param>
		private void Dispose(bool disposing)
		{
			if (_Disposed)
				return;

			if (_Handle != Wfc.INVALID_HANDLE) {
				Wfc.DestroySource(_Device.Handle, _Handle);
				_Handle = Wfc.INVALID_HANDLE;
			}

			_Disposed = true;
		}

		/// <summary>
		/// Flag indicating that this instance has been disposed.
		/// </summary>
		private bool _Disposed;

		#endregion
	}
}
