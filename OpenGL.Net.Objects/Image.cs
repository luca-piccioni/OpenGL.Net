
// Copyright (C) 2009-2017 Luca Piccioni
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
					_PixelBuffers = new AlignedMemoryBuffer(w * h * format.GetBytesCount(), 16);
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
					_PixelBuffers = new AlignedMemoryBuffer(w * h * format.GetBytesCount(), 16);
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
			_ImageInfo.PixelType = format;
			_ImageInfo.Width = w;
			_ImageInfo.Height = h;

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
		public uint Stride { get { return (_ImageInfo.Width * PixelLayout.GetBytesCount()); } }

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
		public PixelLayout PixelLayout { get { return (_ImageInfo.PixelType); } }

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
					return new IntPtr(_PixelBuffers.AlignedBuffer.ToInt64() + (w * PixelLayout.GetBytesCount()) + (h * Width * PixelLayout.GetBytesCount()));
				default:
					throw new NotSupportedException(String.Format("pixel format {0} is not supported", PixelLayout));
			}
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
					Memory.Copy(hImageDataPtrTop, hImageDataPtrBottom, Stride);
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
