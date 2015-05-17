
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
		/// A <see cref="PixelLayout"/> that specifies the pixel type (unique characteristic). All required information
		/// is retrieved using attributes of the enumeration field.
		/// </param>
		public PixelLayoutInfo(PixelLayout pType)
		{
			if (pType == PixelLayout.None)
				throw new ArgumentException("invalid pixel type " + pType, "pType");

			Type pixelType = typeof(PixelLayout);

			PixelColorspaceAttribute colorSpaceAttribute = (PixelColorspaceAttribute)Attribute.GetCustomAttribute(pixelType.GetField(Enum.GetName(pixelType, pType)), typeof(PixelColorspaceAttribute));
			PixelComponentsAttribute colorComponentsAttribute = (PixelComponentsAttribute)Attribute.GetCustomAttribute(pixelType.GetField(Enum.GetName(pixelType, pType)), typeof(PixelComponentsAttribute));
			PixelPlanesAttribute colorPlanesAttribute = (PixelPlanesAttribute)Attribute.GetCustomAttribute(pixelType.GetField(Enum.GetName(pixelType, pType)), typeof(PixelPlanesAttribute));
			PixelPrecisionAttribute colorPrecisionAttribute = (PixelPrecisionAttribute)Attribute.GetCustomAttribute(pixelType.GetField(Enum.GetName(pixelType, pType)), typeof(PixelPrecisionAttribute));
			PixelNonLinearAttribute colorNonLinearAttribute = (PixelNonLinearAttribute)Attribute.GetCustomAttribute(pixelType.GetField(Enum.GetName(pixelType, pType)), typeof(PixelNonLinearAttribute));
			PixelStructureAttribute structAttribute = (PixelStructureAttribute)Attribute.GetCustomAttribute(pixelType.GetField(Enum.GetName(pixelType, pType)), typeof(PixelStructureAttribute));

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

			mPixelStructType = (structAttribute != null) ? structAttribute.PixelStructureType : null;
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
			if (mPixelStructType == null)
				throw new InvalidOperationException("no pixel structure for pixel format");

			return (Activator.CreateInstance(mPixelStructType));
		}

		/// <summary>
		/// Structure of the pixel format.
		/// </summary>
		private readonly Type mPixelStructType;

		#endregion
	}
}

