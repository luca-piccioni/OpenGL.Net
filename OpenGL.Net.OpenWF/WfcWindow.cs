
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
