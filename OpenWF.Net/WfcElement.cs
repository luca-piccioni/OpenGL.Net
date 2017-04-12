
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

using System;
using System.Drawing;

namespace OpenWF
{
	/// <summary>
	/// OpenWF Composition Element abstraction.
	/// </summary>
	public sealed class WfcElement : IDisposable
	{
		#region Constructors

		/// <summary>
		/// Create an OpenWF Composition element.
		/// </summary>
		/// <param name="device">
		/// A <see cref="WfcDevice"/> which the source is created on.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="WfcContext"/> which the source is created on.
		/// </param>
		internal WfcElement(WfcDevice device, WfcContext ctx)
		{
			if (device == null)
				throw new ArgumentNullException("device");

			if ((_Handle = Wfc.CreateElement(device.Handle, ctx.Handle, null)) == Wfc.INVALID_HANDLE)
				throw new InvalidOperationException(String.Format("unable to create OpenWF element"));

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

		#region Attributes

		/// <summary>
		/// Get or set the placement of the WfcElement’s content within the WfcContext coordinate system.
		/// </summary>
		public Rectangle DestinationRectangle
		{
			get
			{
				int[] attrib = new int[4];

				Wfc.GetElementAttribi(_Device.Handle, _Handle, WFCElementAttrib.ElementDestinationRectangle, 4, attrib);

				return (new Rectangle(attrib[0], attrib[1], attrib[2], attrib[3]));
			}
			set
			{
				int[] attrib = new int[4] { value.X, value.Y, value.Width, value.Height };

				Wfc.SetElementAttribi(_Device.Handle, _Handle, WFCElementAttrib.ElementDestinationRectangle, 4, attrib);
			}
		}

		/// <summary>
		/// The Element’s Source image provider that will supply the color data. It is legitimate for
		/// multiple Elements to use the same Source.
		/// </summary>
		public WfcSource Source
		{
			get { return (_Source); }
			set
			{
				Wfc.SetElementAttribi(_Device.Handle, _Handle, WFCElementAttrib.ElementSource, (int)_Source.Handle);
				_Source = value;
			}
		}

		/// <summary>
		/// The Element’s Source image provider that will supply the color data. It is legitimate for
		/// multiple Elements to use the same Source.
		/// </summary>
		private WfcSource _Source;

		/// <summary>
		/// Get or set the rectangular sub-area of the Element’s Source that will be used when rendering
		/// the Element. It is specified in the Source image coordinate space.
		/// </summary>
		public Rectangle SourceRectangle
		{
			get
			{
				int[] attrib = new int[4];

				Wfc.GetElementAttribi(_Device.Handle, _Handle, WFCElementAttrib.ElementSourceRectangle, 4, attrib);

				return (new Rectangle(attrib[0], attrib[1], attrib[2], attrib[3]));
			}
			set
			{
				int[] attrib = new int[4] { value.X, value.Y, value.Width, value.Height };

				Wfc.SetElementAttribi(_Device.Handle, _Handle, WFCElementAttrib.ElementSourceRectangle, 4, attrib);
			}
		} 

		/// <summary>
		/// Get of set whether the flip feature is enabled. Flipping consists of inverting the Crop stage
		/// output image top-to-bottom about the horizontal centerline of the image.
		/// </summary>
		public bool SourceFlipping
		{
			get { return (Wfc.GetElementAttribi(_Device.Handle, _Handle, WFCElementAttrib.ElementSourceFlip) != 0); }
			set { Wfc.SetElementAttribi(_Device.Handle, _Handle, WFCElementAttrib.ElementSourceFlip, value ? 1 : 0); }
		}

		/// <summary>
		/// Get or set the clockwise rotation to be applied to the contents of Flipping stage output.
		/// </summary>
		public WFCRotation SourceRotation
		{
			get { return ((WFCRotation)Wfc.GetElementAttribi(_Device.Handle, _Handle, WFCElementAttrib.ElementSourceRotation)); }
			set { Wfc.SetElementAttribi(_Device.Handle, _Handle, WFCElementAttrib.ElementSourceRotation, (int)value); }
		}

		/// <summary>
		/// Get or set the type of filtering that can be used when scaling content. Filtering involves determining an
		/// approximate value for a source point using a function of the nearby pixel center values.
		/// </summary>
		public WFCScaleFilter SourceScaleFilter
		{
			get { return ((WFCScaleFilter)Wfc.GetElementAttribi(_Device.Handle, _Handle, WFCElementAttrib.ElementSourceScaleFilter)); }
			set { Wfc.SetElementAttribi(_Device.Handle, _Handle, WFCElementAttrib.ElementSourceScaleFilter, (int)value); }
		}

		#endregion

		#region IDisposable Implementation

		/// <summary>
		/// Finalizer.
		/// </summary>
		~WfcElement()
		{
			Dispose(false);
		}

		// <summary>
		/// Releases all resource used by the <see cref="WfcElement"/> object.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>
		/// Releases all resource used by the <see cref="WfcElement"/> object.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="Boolean"/> indicating whether the disposition happens in a managed context.
		/// </param>
		private void Dispose(bool disposing)
		{
			if (_Disposed)
				return;

			if (_Handle != Wfc.INVALID_HANDLE) {
				Wfc.DestroyElement(_Device.Handle, _Handle);
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
