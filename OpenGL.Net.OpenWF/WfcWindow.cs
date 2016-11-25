
// Copyright (C) 2016 Luca Piccioni
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

namespace OpenWF
{
	public class WfcWindow : IDisposable
	{
		#region Constructors

		public WfcWindow()
		{
			if (Wfc.IsAvailable == false)
				throw new InvalidOperationException("OpenWF Compositor is not available");

			_WfcDevice = new WfcDevice();
			_WfcContext = _WfcDevice.CreateContext();
			WfcElement wfcElement = _WfcContext.CreateElement();

			WfcSource wfcSource = _WfcContext.CreateSource(0);	// XXX
			wfcElement.Source = wfcSource;

			_WfcContext.InsertElement(wfcElement);
			_WfcContext.Commit();
		}

		#endregion

		#region WFC Handles

		private readonly WfcDevice _WfcDevice;

		private readonly WfcContext _WfcContext;

		#endregion

		#region IDisposable Implementation

		// <summary>
		/// Releases all resource used by the <see cref="WfcDevice"/> object.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>
		/// Finalizer.
		/// </summary>
		~WfcWindow()
		{
			Dispose(false);
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

			if (disposing) {
				
			}

			if (_WfcContext != null)
				_WfcContext.Dispose();
			if (_WfcDevice != null)
				_WfcDevice.Dispose();

			_Disposed = true;
		}

		/// <summary>
		/// Flag indicating that this instance has been disposed.
		/// </summary>
		private bool _Disposed;

		#endregion
	}
}
