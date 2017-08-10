
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

namespace OpenGL.Objects
{
	/// <summary>
	/// Commonly used semantic for program vertex inputs.
	/// </summary>
	public static class VertexArraySemantic
	{
		/// <summary>
		/// Get the default location for known attribute semantic.
		/// </summary>
		/// <param name="semantic"></param>
		/// <returns></returns>
		public static uint GetLocation(string semantic)
		{
			switch (semantic) {
				case Position:
					return (0);
				case Color:
					return (1);
				case Normal:
					return (2);
				case TexCoord:
					return (3);
				case Tangent:
					return (4);
				case Bitangent:
					return (5);
				default:
					return (ShaderProgram.AttributeBinding.InvalidLocation);
			}
		}

		public static string ToArray(string semantic, int index)
		{
			return (string.Format("{0}[{1}]", semantic, index));
		}

		/// <summary>
		/// Vertices position.
		/// </summary>
		public const string Position = "Position";

		/// <summary>
		/// Vertices position segment.
		/// </summary>
		public const string PositionSegment = "PositionSegment";

		/// <summary>
		/// Color.
		/// </summary>
		public const string Color = "Color";

		/// <summary>
		/// Normal vector.
		/// </summary>
		public const string Normal = "Normal";

		/// <summary>
		/// Tangent vector.
		/// </summary>
		public const string Tangent = "Tangent";

		/// <summary>
		/// Bitangent vector.
		/// </summary>
		public const string Bitangent = "Bitangent";

		/// <summary>
		/// Texture coordinate.
		/// </summary>
		public const string TexCoord = "TexCoord";
	}
}
