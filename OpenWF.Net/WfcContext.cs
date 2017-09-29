
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
using System.Drawing;

namespace OpenWF
{
	/// <summary>
	/// OpenWF Composition Context abstraction.
	/// </summary>
	public sealed class WfcContext : IDisposable
	{
		#region Constructors

		/// <summary>
		/// Create an OpenWF Composition (on-screen) context on the default screen of a device.
		/// </summary>
		/// <param name="device">
		/// A <see cref="WfcDevice"/> which the context is created on.
		/// </param>
		internal WfcContext(WfcDevice device) : this(device, 0)
		{

		}

		/// <summary>
		/// Create an OpenWF Composition (on-screen) context on the specified screen of a device.
		/// </summary>
		/// <param name="device">
		/// A <see cref="WfcDevice"/> which the context is created on.
		/// </param>
		/// <param name="screenNumber">
		/// A <see cref="Int32"/> that identifies the screen.
		/// </param>
		internal WfcContext(WfcDevice device, int screenNumber)
		{
			if (device == null)
				throw new ArgumentNullException("device");

			if ((_Handle = Wfc.Create(device.Handle, screenNumber, null)) == Wfc.INVALID_HANDLE)
				throw new InvalidOperationException(String.Format("unable to create OpenWF context"));

			_Device = device;
			
			ContextType = WFCContextType.ContextTypeOnScreen;
		}

		#endregion

		#region Handle

		/// <summary>
		/// Get the context handle.
		/// </summary>
		internal Handle Handle { get { return (_Handle); } }

		/// <summary>
		/// The context handle.
		/// </summary>
		private Handle _Handle;

		/// <summary>
		/// The device handle.
		/// </summary>
		private readonly WfcDevice _Device;

		#endregion

		#region Attributes

		public readonly WFCContextType ContextType;

		public Size TargetSize
		{
			get
			{
				int w = Wfc.GetContextAttribi(_Device.Handle, _Handle, WFCContextAttrib.ContextTargetWidth);
				int h = Wfc.GetContextAttribi(_Device.Handle, _Handle, WFCContextAttrib.ContextTargetHeight);

				return (new Size(w, h));
			}
		}

		public WFCRotation Rotation
		{
			get { return ((WFCRotation)Wfc.GetContextAttribi(_Device.Handle, _Handle, WFCContextAttrib.ContextRotation)); }
			set { Wfc.SetContextAttribi(_Device.Handle, _Handle, WFCContextAttrib.ContextRotation, (int)value); }
		}

		//public ColorRGBA32 BackgroundColor
		//{
		//	get
		//	{
		//		UInt32 bgColor = (UInt32)Wfc.GetContextAttribi(_Device.Handle, _Handle, WFCContextAttrib.ContextBgColor);

		//		return (new ColorRGBA32(
		//			(byte)(bgColor & 0xFF),
		//			(byte)((bgColor >> 8) & 0xFF),
		//			(byte)((bgColor >> 16) & 0xFF),
		//			(byte)((bgColor >> 24) & 0xFF)
		//		));
		//	}
		//	set
		//	{
		//		int bgColor = value.r | value.g << 8 | value.b << 16 | value.a << 24;

		//		Wfc.SetContextAttribi(_Device.Handle, _Handle, WFCContextAttrib.ContextBgColor, bgColor);
		//	}
		//}

		#endregion

		#region Resources

		/// <summary>
		/// Create an OpenWF Composition source.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="NativeStreamType"/> that specifies the native source stream.
		/// </param>
		public WfcSource CreateSource(NativeStreamType stream)
		{
			return (new WfcSource(_Device, this, stream));
		}

		/// <summary>
		/// Create an OpenWF Composition element.
		/// </summary>
		public WfcElement CreateElement()
		{
			return (new WfcElement(_Device, this));
		}

		public void InsertElement(WfcElement element)
		{
			InsertElement(element, null);
		}

		public void InsertElement(WfcElement element, WfcElement position)
		{
			if (element == null)
				throw new ArgumentNullException("element");
			Wfc.InsertElement(_Device.Handle, element.Handle, position != null ? position.Handle : Wfc.INVALID_HANDLE);
		}

		public void RemoveElement(WfcElement element)
		{
			if (element == null)
				throw new ArgumentNullException("element");
			Wfc.RemoveElement(_Device.Handle, element.Handle);
		}

		#endregion

		#region Methods

		public void Commit()
		{
			Wfc.Commit(_Device.Handle, _Handle, true);
		}

		public void CommitAsync()
		{
			Wfc.Commit(_Device.Handle, _Handle, false);
		}

		public void Compose()
		{
			Wfc.Compose(_Device.Handle, _Handle, true);
		}

		public void ComposeAsync()
		{
			Wfc.Compose(_Device.Handle, _Handle, false);
		}

		public void Activate()
		{
			Wfc.Activate(_Device.Handle, _Handle);
		}

		#endregion

		#region IDisposable Implementation

		/// <summary>
		/// Finalizer.
		/// </summary>
		~WfcContext()
		{
			Dispose(false);
		}

		// <summary>
		/// Releases all resource used by the <see cref="WfcContext"/> object.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>
		/// Releases all resource used by the <see cref="WfcContext"/> object.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="Boolean"/> indicating whether the disposition happens in a managed context.
		/// </param>
		private void Dispose(bool disposing)
		{
			if (_Disposed)
				return;

			if (_Handle != Wfc.INVALID_HANDLE) {
				Wfc.Destroy(_Device.Handle, _Handle);
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
