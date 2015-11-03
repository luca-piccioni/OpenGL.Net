
//  Copyright (C) 2009-2013 Luca Piccioni
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace OpenGL
{
	/// <summary>
	/// Image codec criteria.
	/// </summary>
	public class ImageCodecCriteria : MediaCodecCriteria
	{
		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ImageCodecCriteria()
		{
			// Default values

			// Good compromize between quality and size
			this[QualityPreset] = 0.75f;
			// Uses software support: wider pixel format support
			this[SoftwareSupport] = true;
		}

		#endregion

		#region ImageCodecCriteria Value Names

		/// <summary>
		/// Floating-point value used by selected plugins to determine some generic quality preset.
		/// </summary>
		/// <remarks>
		/// <para>
		/// The plugin can ignore the quality setting specified. The value is normalized in the range [0.0, 1.0], where 1.0 means the
		/// highest quality. Usually this preset shall not reduce fundamental image parameters, such as image extents or pixel precision.
		/// </para>
		/// </remarks>
		public static readonly string QualityPreset = "QualityPreset";

		/// <summary>
		/// Boolean value used by selected plugin to determine whether to convert image in order to support hardware formats.
		/// </summary>
		/// <remarks>
		/// <para>
		/// The plugin will check whether the native pixel format is available on current hardware. In the case hardware is not capable
		/// to represent the image and this criteria is set to false, then the plugin refuse to load the image. Otherwise, it try to
		/// convert the image pixel format in order to have a pixel format compatible with the hardware.
		/// </para>
		/// </remarks>
		public static readonly string SoftwareSupport = "SoftwareSupport";

		#endregion
	}
}