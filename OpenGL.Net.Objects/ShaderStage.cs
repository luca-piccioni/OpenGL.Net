
// Copyright (C) 2015-2017 Luca Piccioni
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

using System.Xml.Serialization;

namespace OpenGL.Objects
{
	/// <summary>
	/// Shader object stages.
	/// </summary>
	[XmlType("ShaderStage")]
	public enum ShaderStage
	{
		/// <summary>
		/// Shader object is linkable at vertex stage.
		/// </summary>
		[XmlEnum("Vertex")]
		Vertex = Gl.VERTEX_SHADER,

		/// <summary>
		/// Shader object is linkable at tesselation control stage.
		/// </summary>
		[XmlEnum("TessControl")]
		TessellationControl = Gl.TESS_CONTROL_SHADER,

		/// <summary>
		/// Shader object is linkable at tesselation evaluation stage.
		/// </summary>
		[XmlEnum("TessEvaluation")]
		TessellationEvaluation = Gl.TESS_EVALUATION_SHADER,

		/// <summary>
		/// Shader object is linkable at geometry stage.
		/// </summary>
		[XmlEnum("Geometry")]
		Geometry = Gl.GEOMETRY_SHADER,

		/// <summary>
		/// Shader object is linkable at fragment stage.
		/// </summary>
		[XmlEnum("Fragment")]
		Fragment = Gl.FRAGMENT_SHADER,
	}
}
