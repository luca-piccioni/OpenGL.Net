
// Copyright (C) 2012-2017 Luca Piccioni
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
