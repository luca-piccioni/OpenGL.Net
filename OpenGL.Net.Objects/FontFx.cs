
// Copyright (C) 2017 Luca Piccioni
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
