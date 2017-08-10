
// Copyright (C) 2012-2017 Luca Piccioni
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

namespace OpenGL
{
	/// <summary>
	/// Structure providing an overview of a pixel format.
	/// </summary>
	/// <remarks>
	/// <para>
	/// A <see cref="PixelLayout"/> structure provides all the useful information of a specific pixel
	/// format. This information is defined by:
	/// - The color space
	/// - The color linearity
	/// - The components count
	/// - The bits count for each component
	/// - The precision of each component
	/// - The precision of the color
	/// - The bits count of the color
	/// - The bytes count of the color
	/// - The separate planes count of the color
	/// </para>
	/// </remarks>
	public class PixelLayoutInfo
	{
		#region Constructors

		/// <summary>
		/// Construct a PixelLayoutInfo for a pixel format.
		/// </summary>
		/// <param name="pType">
		/// A <see cref="PixelLayout"/> that specify the pixel type (unique characteristic). All required information
		/// is retrieved using attributes of the enumeration field.
		/// </param>
		public PixelLayoutInfo(PixelLayout pType)
		{
			if (pType == PixelLayout.None)
				throw new ArgumentException("invalid pixel type " + pType, "pType");

			Type pixelType = typeof(PixelLayout);

#if !NETCORE && !NETSTANDARD1_4
			PixelColorspaceAttribute colorSpaceAttribute = (PixelColorspaceAttribute)Attribute.GetCustomAttribute(pixelType.GetField(Enum.GetName(pixelType, pType)), typeof(PixelColorspaceAttribute));
			PixelComponentsAttribute colorComponentsAttribute = (PixelComponentsAttribute)Attribute.GetCustomAttribute(pixelType.GetField(Enum.GetName(pixelType, pType)), typeof(PixelComponentsAttribute));
			PixelPlanesAttribute colorPlanesAttribute = (PixelPlanesAttribute)Attribute.GetCustomAttribute(pixelType.GetField(Enum.GetName(pixelType, pType)), typeof(PixelPlanesAttribute));
			PixelPrecisionAttribute colorPrecisionAttribute = (PixelPrecisionAttribute)Attribute.GetCustomAttribute(pixelType.GetField(Enum.GetName(pixelType, pType)), typeof(PixelPrecisionAttribute));
			PixelNonLinearAttribute colorNonLinearAttribute = (PixelNonLinearAttribute)Attribute.GetCustomAttribute(pixelType.GetField(Enum.GetName(pixelType, pType)), typeof(PixelNonLinearAttribute));
			PixelStructureAttribute structAttribute = (PixelStructureAttribute)Attribute.GetCustomAttribute(pixelType.GetField(Enum.GetName(pixelType, pType)), typeof(PixelStructureAttribute));
#else
			PixelColorspaceAttribute colorSpaceAttribute = null;
			PixelComponentsAttribute colorComponentsAttribute = null;
			PixelPlanesAttribute colorPlanesAttribute = null;
			PixelPrecisionAttribute colorPrecisionAttribute = null;
			PixelNonLinearAttribute colorNonLinearAttribute = null;
			PixelStructureAttribute structAttribute = null;

			
#endif
			if (colorSpaceAttribute == null)
				throw new InvalidOperationException(String.Format("pixel format {0} does not declare PixelColorspaceAttribute"));
			if ((colorComponentsAttribute == null) && (colorPlanesAttribute == null))
				throw new InvalidOperationException(String.Format("pixel format {0} does not declare PixelComponentsAttribute or PixelPlanesAttribute"));
			if (colorPrecisionAttribute == null)
				throw new InvalidOperationException(String.Format("pixel format {0} does not declare PixelPrecisionAttribute"));

			// Store type
			DataFormat = pType;
			// Store color space
			ColorSpace = colorSpaceAttribute.PixelSpace;
			// Store components bits
			ComponentsCount = 0;
			ChromaXRatio = ChromaYRatio = 0;

			if (colorComponentsAttribute != null) {
				ComponentsCount = colorComponentsAttribute.PixelComponents;
				ChromaXRatio = ChromaYRatio = 1;
			}
			if (colorPlanesAttribute != null) {
				ComponentsCount = colorPlanesAttribute.PixelPlanes;
				ChromaXRatio = colorPlanesAttribute.XRatio;
				ChromaYRatio = colorPlanesAttribute.YRatio;
			}

			PixelBits = colorPrecisionAttribute.PixelBits;
			PixelBytes = (byte)(((PixelBits + 7) / 8) & 0xFF);

			Linear = colorNonLinearAttribute == null;

			_PixelStructType = (structAttribute != null) ? structAttribute.PixelStructureType : null;
		}

		#endregion

		#region Format Information

		/// <summary>
		/// Pixel data format.
		/// </summary>
		public readonly PixelLayout DataFormat;

		/// <summary>
		/// Pixel color space.
		/// </summary>
		public readonly PixelSpace ColorSpace;

		/// <summary>
		/// The pixel components count.
		/// </summary>
		public readonly byte ComponentsCount;

		/// <summary>
		/// The chrominance plane horizontal length ratio respect the other planes.
		/// </summary>
		public readonly byte ChromaXRatio;

		/// <summary>
		/// The other planes vertical length ratio respect the other planes.
		/// </summary>
		public readonly byte ChromaYRatio;

		/// <summary>
		/// Meaninful bits for representing a pixel color.
		/// </summary>
		public readonly byte PixelBits;

		/// <summary>
		/// Used bytes for representing a pixel color.
		/// </summary>
		public readonly byte PixelBytes;

		/// <summary>
		/// Color components linearity.
		/// </summary>
		public readonly bool Linear;

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public object CreatePixelStruct()
		{
			if (_PixelStructType == null)
				throw new InvalidOperationException("no pixel structure for pixel format");

			return (Activator.CreateInstance(_PixelStructType));
		}

		/// <summary>
		/// Get the type of the structure of the pixel format.
		/// </summary>
		public Type PixelStructType { get { return (_PixelStructType); } }

		/// <summary>
		/// Structure of the pixel format.
		/// </summary>
		private readonly Type _PixelStructType;

		#endregion
	}
}

