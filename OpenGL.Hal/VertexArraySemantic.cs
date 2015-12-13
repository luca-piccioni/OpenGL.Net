
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

using System;
using System.Collections.Generic;
using System.Reflection;

namespace OpenGL
{
	/// <summary>
	/// Commonly used semantic.
	/// </summary>
	public static class VertexArraySemantic
	{
		/// <summary>
		/// Static constructor.
		/// </summary>
		static VertexArraySemantic()
		{
			FieldInfo[] semanticFields = typeof(VertexArraySemantic).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.GetField);

			foreach (FieldInfo field in semanticFields) {
				object value = field.GetValue(null);

				if (value is string)
					sKnownSemantics.Add((string) value);
			}
		}

		/// <summary>
		/// Determine whether the semantic is known.
		/// </summary>
		/// <param name="semantic">
		/// A <see cref="System.String"/> that specify the vertex array semantic.
		/// </param>
		/// <returns>
		/// It returns true only in the case the semantic is known by this class.
		/// </returns>
		public static bool IsKnownSemantic(string semantic)
		{
			if (semantic == null)
				throw new ArgumentNullException("semantic");

			return (sKnownSemantics.Contains(semantic));
		}

		/// <summary>
		/// All known semantics.
		/// </summary>
		private static readonly List<string> sKnownSemantics = new List<string>();

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
