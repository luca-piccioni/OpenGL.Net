
// Copyright (C) 2012-2016 Luca Piccioni
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

namespace OpenGL
{
	/// <summary>
	/// Commonly used semantic for program vertex inputs.
	/// </summary>
	public static class VertexArraySemantic
	{
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
		/// Texture coordinate.
		/// </summary>
		public const string TexCoord = "TexCoord";

		/// <summary>
		/// Skinning bones count.
		/// </summary>
		public const string BonesCount = "BonesCount";

		/// <summary>
		/// Skinning bones indices assigned of the vertex.
		/// </summary>
		public const string BonesIndices = "BonesIndices";

		/// <summary>
		/// Skinning bones weights assigned of the vertex.
		/// </summary>
		public const string BonesWeights = "BonesWeights";

		/// <summary>
		/// Normal vector.
		/// </summary>
		public const string Normal = "Normal";

		/// <summary>
		/// Speed vector.
		/// </summary>
		public const string Speed = "Speed";
		
		/// <summary>
		/// Acceleration vector.
		/// </summary>
		public const string Acceleration = "Acceleration";

		/// <summary>
		/// Mass scalar.
		/// </summary>
		public const string Mass = "Mass";
	}
}
