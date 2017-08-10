
// Copyright (C) 2017 Luca Piccioni
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

namespace OpenGL.Objects
{
	/// <summary>
	/// Additional effect for styling the font.
	/// </summary>
	public abstract class FontFx
	{
		
	}

	/// <summary>
	/// Font shadow.
	/// </summary>
	public sealed class FontFxShadow : FontFx
	{
		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public FontFxShadow()
		{

		}

		/// <summary>
		/// Construct a FontFxShadow specifying the shadow offset.
		/// </summary>
		/// <param name="offset">
		/// The <see cref="Vertex2f"/> that specifies the shadow offset.
		/// </param>
		public FontFxShadow(Vertex2f offset)
		{
			Offset = offset;
		}

		/// <summary>
		/// Construct a FontFxShadow specifying the shadow color and offset.
		/// </summary>
		/// <param name="color">
		/// The <see cref="ColorRGBAF"/> that specifies the shadow color.
		/// </param>
		/// <param name="offset">
		/// The <see cref="Vertex2f"/> that specifies the shadow offset.
		/// </param>
		public FontFxShadow(ColorRGBAF color, Vertex2f offset)
		{
			Color = color;
			Offset = offset;
		}

		#endregion

		#region Parameters

		/// <summary>
		/// Halo color.
		/// </summary>
		internal ColorRGBAF Color = ColorRGBAF.ColorBlack;

		/// <summary>
		/// Shadow offset.
		/// </summary>
		public Vertex2f Offset = new Vertex2f(1.5f, -1.5f);

		#endregion
	}

	/// <summary>
	/// Halo effect.
	/// </summary>
	public class FontFxHalo : FontFx
	{
		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public FontFxHalo()
		{

		}

		#endregion

		#region Parameters

		/// <summary>
		/// Halo color.
		/// </summary>
		internal ColorRGBAF HaloColor = ColorRGBAF.ColorBlack;

		/// <summary>
		/// Halo thickness, in pixels.
		/// </summary>
		internal float HaloWidth = 1.5f;

		#endregion
	}
}
