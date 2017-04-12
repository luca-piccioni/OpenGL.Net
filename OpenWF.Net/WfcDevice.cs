
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

using WfcDeviceId = System.Int32;
using WfcDeviceHandle = System.UInt32;

using System;
using System.Collections.Generic;

namespace OpenWF
{
	/// <summary>
	/// OpenWF Composition Device abstraction.
	/// </summary>
	public sealed class WfcDevice : IDisposable
	{
		#region Constructors

		/// <summary>
		/// Create the default OpenWF device.
		/// </summary>
		public WfcDevice() :
			this(Wfc.DEFAULT_DEVICE_ID)
		{

		}

		/// <summary>
		/// Open the OpenWF device.
		/// </summary>
		/// <param name="deviceId">
		/// A <see cref="Int32"/> that specifies the identifier of the device.
		/// </param>
		public WfcDevice(int deviceId)
		{
			if ((_Handle = Wfc.CreateDevice(deviceId, null)) == Wfc.INVALID_HANDLE)
				throw new InvalidOperationException(String.Format("unable to create OpenWF device {0}", deviceId));

			// Query device attributes
			Class = (WFCDeviceClass)Wfc.GetDeviceAttribi(_Handle, WFCDeviceAttrib.DeviceClass);
		}

		#endregion

		#region Handle

		/// <summary>
		/// Get the OpenWF device handle.
		/// </summary>
		internal WfcDeviceHandle Handle { get { return (_Handle); } }

		/// <summary>
		/// The OpenWF device handle.
		/// </summary>
		private WfcDeviceHandle _Handle;

		#endregion

		#region Attributes

		/// <summary>
		/// The class of this WfcDevice.
		/// </summary>
		public readonly WFCDeviceClass Class;

		#endregion

		#region Resources

		/// <summary>
		/// Enumerate OpenWF Composition devices.
		/// </summary>
		/// <returns>
		/// It returns the <see cref="List{WfcDeviceId}"/> specifying the available device identifiers.
		/// </returns>
		public List<WfcDeviceId> Enumerate()
		{
			int[] devices = new int[Wfc.EnumerateDevices(null, 0, null)];
			int deviceCount = Wfc.EnumerateDevices(devices, devices.Length, null);

			List<WfcDeviceId> wfcDevices = new List<WfcDeviceId>();

			for (int i = 0; i < Math.Min(deviceCount, devices.Length); i++)
				wfcDevices.Add(devices[i]);

			return (wfcDevices);
		}

		/// <summary>
		/// Create an OpenWF Composition (on-screen) context on the default screen of a device.
		/// </summary>
		public WfcContext CreateContext()
		{
			return (new WfcContext(this));
		}

		/// <summary>
		/// Create an OpenWF Composition (on-screen) context on the specified screen of a device.
		/// </summary>
		/// <param name="screenNumber">
		/// A <see cref="Int32"/> that identifies the screen.
		/// </param>
		public WfcContext CreateContext(int screenNumber)
		{
			return (new WfcContext(this, screenNumber));
		}

		#endregion

		#region IDisposable Implementation

		/// <summary>
		/// Finalizer.
		/// </summary>
		~WfcDevice()
		{
			Dispose(false);
		}

		// <summary>
		/// Releases all resource used by the <see cref="WfcDevice"/> object.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>
		/// Releases all resource used by the <see cref="WfcDevice"/> object.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="Boolean"/> indicating whether the disposition happens in a managed context.
		/// </param>
		private void Dispose(bool disposing)
		{
			if (_Disposed)
				return;

			if (_Handle != Wfc.INVALID_HANDLE) {
				WFCErrorCode err = Wfc.DestroyDevice(_Handle);
				_Handle = Wfc.INVALID_HANDLE;

				// Throw exception is disposition is managed
				if (disposing)
					Wfc.CheckErrors(err);
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
