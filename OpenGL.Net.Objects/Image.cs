
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
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenGL.Objects
{
	/// <summary>
	/// Generic image.
	/// </summary>
	public class Image : Resource, IMedia<ImageInfo>
	{
		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Image()
		{
		
		}

		/// <summary>
		/// Construct an image.
		/// </summary>
		/// <param name="format">
		/// A <see cref="PixelLayout"/> indicating the image pixel format.
		/// </param>
		/// <param name="width">
		/// A <see cref="UInt32"/> indicating the image width, in pixels.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> indicating the image height, in pixels.
		/// </param>
		public Image(PixelLayout format, uint width, uint height)
		{
			if (format == PixelLayout.None)
				throw new ArgumentException("invalid", "format");
			if (width == 0)
				throw new ArgumentException("invalid", "width");
			if (height == 0)
				throw new ArgumentException("invalid", "height");

			// Allocate
			Create(format, width, height);
		}

		#endregion

		#region Image Pixels

		/// <summary>
		/// Allocate pixel data for this Image.
		/// </summary>
		/// <param name="format">
		/// A <see cref="PixelLayout"/> indicating the image pixel format.
		/// </param>
		/// <param name="w">
		/// A <see cref="Int32"/> indicating the image width, in pixels.
		/// </param>
		/// <param name="h">
		/// A <see cref="Int32"/> indicating the image height, in pixels.
		/// </param>
		public void Create(PixelLayout format, uint w, uint h)
		{
			PixelLayoutInfo formatInfo = format.GetPixelFormat();

			switch (format) {
				// Single plane formats
				case PixelLayout.R8:
				case PixelLayout.R16:
				case PixelLayout.GRAY16S:
				case PixelLayout.RF:
				case PixelLayout.RHF:
				//case PixelLayout.GRAYAF:
				case PixelLayout.RGB8:
				case PixelLayout.RGB15:
				case PixelLayout.RGB16:
				case PixelLayout.RGB24:
				case PixelLayout.RGB48:
				case PixelLayout.RGBF:
				case PixelLayout.RGBHF:
				case PixelLayout.RGBD:
				case PixelLayout.SRGB24:
				case PixelLayout.SBGR24:
				//case PixelLayout.RGB30A2:
				case PixelLayout.RGBA32:
				case PixelLayout.RGBA64:
				case PixelLayout.RGBAF:
				case PixelLayout.RGBAHF:
				case PixelLayout.BGR8:
				case PixelLayout.BGR15:
				case PixelLayout.BGR16:
				case PixelLayout.BGR24:
				case PixelLayout.BGR48:
				case PixelLayout.BGRF:
				case PixelLayout.BGRHF:
				//case PixelLayout.BGR30A2:
				case PixelLayout.BGRA32:
				case PixelLayout.BGRA64:
				case PixelLayout.BGRAF:
				case PixelLayout.BGRAHF:
				case PixelLayout.CMY24:
				case PixelLayout.CMYK32:
				case PixelLayout.CMYK64:
				case PixelLayout.CMYKA40:
				case PixelLayout.Depth16:
				case PixelLayout.Depth24:
				case PixelLayout.Depth32:
				case PixelLayout.DepthF:
				case PixelLayout.Depth24Stencil8:
				case PixelLayout.Depth32FStencil8:
				case PixelLayout.Integer1:
				case PixelLayout.Integer2:
				case PixelLayout.Integer3:
				case PixelLayout.Integer4:
				case PixelLayout.UInteger1:
				case PixelLayout.UInteger2:
				case PixelLayout.UInteger3:
				case PixelLayout.UInteger4:
					_PixelBuffers = new AlignedMemoryBuffer(w * h * formatInfo.PixelBytes, 16);
					// Define planes
					_PixelPlanes = new IntPtr[] { _PixelBuffers.AlignedBuffer };
					break; 
				case PixelLayout.YUYV:
				case PixelLayout.YYUV:
				case PixelLayout.YVYU:
				case PixelLayout.UYVY:
				case PixelLayout.VYUY:
					if (((w % 2) != 0) || ((h % 2) != 0))
						throw new InvalidOperationException(String.Format("invalid image extents for pixel format {0}", format));
					// Define planes
					_PixelBuffers = new AlignedMemoryBuffer(w * h * formatInfo.PixelBytes, 16);
					_PixelPlanes = new IntPtr[] { _PixelBuffers.AlignedBuffer };
					break;
				case PixelLayout.YVU410:
				case PixelLayout.YUV410:
					if (((w % 16) != 0) || ((h % 16) != 0))
						throw new InvalidOperationException(String.Format("invalid image extents for pixel format {0}", format));
					_PixelBuffers = new AlignedMemoryBuffer(w * h + (w * h / 16) * 2, 16);
					// Define planes
					_PixelPlanes = new IntPtr[3];
					_PixelPlanes[0] = _PixelBuffers.AlignedBuffer;
					_PixelPlanes[1] = new IntPtr(_PixelBuffers.AlignedBuffer.ToInt64() + w * h);
					_PixelPlanes[2] = new IntPtr(_PixelBuffers.AlignedBuffer.ToInt64() + w * h + (w * h / 16));
					break;
				case PixelLayout.YVU420:
				case PixelLayout.YUV420:
					if (((w % 4) != 0) || ((h % 4) != 0))
						throw new InvalidOperationException(String.Format("invalid image extents for pixel format {0}", format));
					_PixelBuffers = new AlignedMemoryBuffer(w * h + (w * h / 4), 16);
					// Define planes
					_PixelPlanes = new IntPtr[3];
					_PixelPlanes[0] = _PixelBuffers.AlignedBuffer;
					_PixelPlanes[1] = new IntPtr(_PixelBuffers.AlignedBuffer.ToInt64() + w * h);
					_PixelPlanes[2] = new IntPtr(_PixelBuffers.AlignedBuffer.ToInt64() + w * h + (w * h / 4));
					break;
				case PixelLayout.YUV422P:
					if ((w % 2) != 0)
						throw new InvalidOperationException(String.Format("invalid image extents for pixel format {0}", format));
					_PixelBuffers = new AlignedMemoryBuffer(w * h + (w * h / 2), 16);
					// Define planes
					_PixelPlanes = new IntPtr[3];
					_PixelPlanes[0] = _PixelBuffers.AlignedBuffer;
					_PixelPlanes[1] = new IntPtr(_PixelBuffers.AlignedBuffer.ToInt64() + w * h);
					_PixelPlanes[2] = new IntPtr(_PixelBuffers.AlignedBuffer.ToInt64() + w * h + (w * h / 2));
					break;
				case PixelLayout.YUV411P:
					if ((w % 4) != 0)
						throw new InvalidOperationException(String.Format("invalid image extents for pixel format {0}", format));
					_PixelBuffers = new AlignedMemoryBuffer(w * h + (w * h / 4), 16);
					// Define planes
					_PixelPlanes = new IntPtr[3];
					_PixelPlanes[0] = _PixelBuffers.AlignedBuffer;
					_PixelPlanes[1] = new IntPtr(_PixelBuffers.AlignedBuffer.ToInt64() + w * h);
					_PixelPlanes[2] = new IntPtr(_PixelBuffers.AlignedBuffer.ToInt64() + w * h + (w * h / 4));
					break;
				case PixelLayout.Y41P:
					if ((w % 8) != 0)
						throw new InvalidOperationException(String.Format("invalid image extents for pixel format {0}", format));
					_PixelBuffers = new AlignedMemoryBuffer(w * h * 12 / 8, 16);
					// Define planes
					_PixelPlanes = new IntPtr[3];
					_PixelPlanes[0] = _PixelBuffers.AlignedBuffer;
					_PixelPlanes[1] = new IntPtr(_PixelBuffers.AlignedBuffer.ToInt64() + w * h);
					_PixelPlanes[2] = new IntPtr(_PixelBuffers.AlignedBuffer.ToInt64() + w * h + (w * h / 4));
					break;
				default:
					throw new NotSupportedException(String.Format("pixel format {0} is not supported", format));
			}
			// Set image information
			_ImageInfo.PixelType = formatInfo.DataFormat;
			_ImageInfo.Width = w;
			_ImageInfo.Height = h;
			// Store pixel format
			_PixelFormat = formatInfo;

			Debug.Assert(_PixelPlanes != null);
			Debug.Assert(_PixelPlanes.Length != 0);
			Debug.Assert(Array.TrueForAll(_PixelPlanes, delegate(IntPtr pixelPlane) { return (pixelPlane != IntPtr.Zero); }));
		}

		/// <summary>
		/// Image width property.
		/// </summary>
		public uint Width
		{
			get { return (_ImageInfo.Width); }
			protected set { _ImageInfo.Width = value; }
		}

		/// <summary>
		/// Image height property.
		/// </summary>
		public uint Height
		{
			get { return (_ImageInfo.Height); }
			protected set { _ImageInfo.Height = value; }
		}

		/// <summary>
		/// Gets the image buffer for every image plane scanlines. Image planes are allocated contiguosly, as defined
		/// by the specific pixel format, if planar.
		/// </summary>
		public IntPtr ImageBuffer { get { return (_PixelBuffers.AlignedBuffer); } }

		/// <summary>
		/// Gets the image planes scan-lines.
		/// </summary>
		public IntPtr[] ImagePlanes { get { return (_PixelPlanes); } }

		/// <summary>
		/// Image line width, in bytes
		/// </summary>
		public uint Stride { get { return (_ImageInfo.Width * _PixelFormat.PixelBytes); } }

		/// <summary>
		/// Image size, in bytes.
		/// </summary>
		public uint Size { get { return (_PixelBuffers != null ? _PixelBuffers.Size : 0); } }

		/// <summary>
		/// Image pixel format.
		/// </summary>
		/// <returns>
		/// It returns a <see cref="PixelLayout"/> that specify the image color resolution.
		/// </returns>
		public PixelLayout PixelLayout { get { return (_PixelFormat.DataFormat); } }

		/// <summary>
		/// The actual pixel format.
		/// </summary>
		private PixelLayoutInfo _PixelFormat;

		/// <summary>
		/// Pixel arrays defining image layers.
		/// </summary>
		private AlignedMemoryBuffer _PixelBuffers;

		/// <summary>
		/// Pixel arrays pointers mapped onto pixel planes.
		/// </summary>
		private IntPtr[] _PixelPlanes;

		#endregion

		#region Managed Pixel Access

		/// <summary>
		/// Get and set image pixel.
		/// </summary>
		/// <param name="w">
		/// A <see cref="UInt32"/> that specify the horizontal position of the image pixel, from the left bound
		/// of the image.
		/// </param>
		/// <param name="h">
		/// A <see cref="UInt32"/> that specify the vertical position of the image pixel, from the bottom bound
		/// of the image.
		/// </param>
		/// <returns>
		/// It returns the pixel of the image in the specified position.
		/// </returns>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="w"/> is equal or greater than <see cref="Width"/> or if <paramref name="h"/>
		/// is equal or greater than <see cref="Height"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the value is not the same of <see cref="PixelLayout"/>. This exxception is thrown only by
		/// the setter.
		/// </exception>
		public IColor this[uint w, uint h]
		{
			get
			{
				if (w >= Width)
					throw new ArgumentOutOfRangeException("w", w, "greater than image width");
				if (h >= Height)
					throw new ArgumentOutOfRangeException("h", h, "greater than image height");

				// Determine pixel data offset
				IntPtr pixelData = GetPixelDataOffset(w, h);
				// Copy from memory to structure
				object pixelStruct = Marshal.PtrToStructure(pixelData, _PixelFormat.PixelStructType);

				return ((IColor)pixelStruct);
			}
			set
			{
				if (value.PixelType != PixelLayout)
					throw new InvalidOperationException("value have not the same pixel format of image");
				if (w >= Width)
					throw new ArgumentOutOfRangeException("w", w, "greater than image width");
				if (h >= Height)
					throw new ArgumentOutOfRangeException("h", h, "greater than image height");

				// Determine pixel data offset
				IntPtr pixelData = GetPixelDataOffset(w, h);
				// Copy from memory to structure
				Marshal.StructureToPtr(value, pixelData, false);
			}
		}

		private IntPtr GetPixelDataOffset(uint w, uint h)
		{
			switch (PixelLayout) {
				// Single plane formats
				case PixelLayout.R8:
				case PixelLayout.R16:
				case PixelLayout.GRAY16S:
				//case PixelLayout.GRAYF:
				case PixelLayout.RHF:
				//case PixelLayout.GRAYAF:
				case PixelLayout.RGB8:
				case PixelLayout.RGB15:
				case PixelLayout.RGB16:
				case PixelLayout.RGB24:
				case PixelLayout.RGB48:
				case PixelLayout.RGBF:
				case PixelLayout.RGBHF:
				case PixelLayout.RGBD:
				case PixelLayout.SRGB24:
				case PixelLayout.SBGR24:
				//case PixelLayout.RGB30A2:
				case PixelLayout.RGBA32:
				case PixelLayout.RGBA64:
				case PixelLayout.RGBAF:
				case PixelLayout.RGBAHF:
				case PixelLayout.BGR8:
				case PixelLayout.BGR15:
				case PixelLayout.BGR16:
				case PixelLayout.BGR24:
				case PixelLayout.BGR48:
				case PixelLayout.BGRF:
				case PixelLayout.BGRHF:
				//case PixelLayout.BGR30A2:
				case PixelLayout.BGRA32:
				case PixelLayout.BGRA64:
				case PixelLayout.BGRAF:
				case PixelLayout.BGRAHF:
				case PixelLayout.CMY24:
				case PixelLayout.CMYK32:
				case PixelLayout.CMYK64:
				case PixelLayout.CMYKA40:
				case PixelLayout.Depth16:
				case PixelLayout.Depth24:
				case PixelLayout.Depth32:
				case PixelLayout.DepthF:
				case PixelLayout.Depth24Stencil8:
				case PixelLayout.Depth32FStencil8:
				case PixelLayout.Integer1:
				case PixelLayout.Integer2:
				case PixelLayout.Integer3:
				case PixelLayout.Integer4:
				case PixelLayout.UInteger1:
				case PixelLayout.UInteger2:
				case PixelLayout.UInteger3:
				case PixelLayout.UInteger4:
					return new IntPtr(_PixelBuffers.AlignedBuffer.ToInt64() + (w * _PixelFormat.PixelBytes) + (h * Width * _PixelFormat.PixelBytes));
				default:
					throw new NotSupportedException(String.Format("pixel format {0} is not supported", PixelLayout));
			}
		}

		#endregion

		#region Conversions

		/// <summary>
		/// ConvertItemType this image to another pixel type.
		/// </summary>
		/// <param name="dstFormat">
		/// A <see cref="PixelLayout"/> that specify the destination image pixel type.
		/// </param>
		/// <returns>
		/// It returns an <see cref="Image"/> visually equalivalent to this Image, but having a pixel format corresponding to
		/// <paramref name="dstFormat"/>
		/// </returns>
		/// <exception cref="ArgumentException">
		/// Exception thrown in the case <paramref name="dstFormat"/> is PixelLayout.None.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown in the case the conversion from <see cref="PixelLayout"/> to <paramref name="dstFormat"/> is not
		/// implemented. To check for image conversion support, check <see cref="Pixel.IsConvertionSupported"/>.
		/// </exception>
		public Image Convert(PixelLayout dstFormat)
		{
			if (dstFormat == PixelLayout.None)
				throw new ArgumentException(String.Format("invalid conversion pixel format {0}", dstFormat), "dstFormat");
			if (Pixel.IsConvertionSupported(PixelLayout, dstFormat) == false)
				throw new InvalidOperationException(String.Format("pixel convertion from {0} to {1} not implemented", PixelLayout, dstFormat));

			// Allocate destination image
			Image dstImage = new Image(dstFormat, Width, Height);
			// ConvertItemType this image
			Pixel.Convert(ImageBuffer, PixelLayout, dstImage.ImageBuffer, dstFormat, Width, Height);

			return (dstImage);
		}

		#endregion

		#region Image Transformation

		#region Flipping

		/// <summary>
		/// Flip the image vertically.
		/// </summary>
		public void FlipVertically()
		{
			IntPtr imageData = ImageBuffer;
			byte[] tmpScanline = new byte[Stride];

			unsafe {
				byte* hImageDataPtrBottom = (byte*)imageData.ToPointer();
				byte* hImageDataPtrTop = hImageDataPtrBottom + Stride * (Height - 1);

				while (hImageDataPtrBottom < hImageDataPtrTop) {
					// Copy to temporary scaline
					Marshal.Copy(new IntPtr(hImageDataPtrTop), tmpScanline, 0, (int)Stride);
					// Swap scan lines
					Memory.MemoryCopy(hImageDataPtrTop, hImageDataPtrBottom, Stride);
					Marshal.Copy(tmpScanline, 0, new IntPtr(hImageDataPtrBottom), (int)Stride);

					hImageDataPtrBottom += Stride;
					hImageDataPtrTop -= Stride;
				}
			}
		}

		#endregion

		#endregion

		#region Resource Overrides

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// </param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (_PixelBuffers != null) {
					// Release the buffer buffer
					_PixelBuffers.Dispose();
					_PixelBuffers = null;
				}
			}
		}

		#endregion

		#region IMedia<ImageInfo> Implementation

		/// <summary>
		/// Gets the media information of this instance.
		/// </summary>
		public ImageInfo MediaInformation
		{
			get
			{
				// Ensure updated information
				_ImageInfo.PixelType = this.PixelLayout;
				_ImageInfo.Width = Width;
				_ImageInfo.Height = Height;

				// Other information may be modified by external code

				return (_ImageInfo);
			}
		}

		/// <summary>
		/// Media information.
		/// </summary>
		private readonly ImageInfo _ImageInfo = new ImageInfo();

		#endregion
	}
}
