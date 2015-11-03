
//  Copyright (C) 2012-2013 Luca Piccioni
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
	/// The semantic of the image data.
	/// </summary>
	public enum ImageSemantic
	{
		/// <summary>
		/// Image represent colors.
		/// </summary>
		Color,
		/// <summary>
		/// Image represent colors, but not clamped to the emittible range.
		/// </summary>
		HighDefinitionColor,
		/// <summary>
		/// Image represents terrain elevation data (i.e. height map).
		/// </summary>
		Elevation,
	}
}
