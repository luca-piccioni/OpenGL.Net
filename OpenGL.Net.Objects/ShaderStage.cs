
// Copyright (C) 2015-2016 Luca Piccioni
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
	/// Shader object stages.
	/// </summary>
	public enum ShaderStage
	{
		/// <summary>
		/// Shader object is linkable at vertex stage.
		/// </summary>
		Vertex = Gl.VERTEX_SHADER,

		/// <summary>
		/// Shader object is linkable at tesselation control stage.
		/// </summary>
		TessellationControl = Gl.TESS_CONTROL_SHADER,

		/// <summary>
		/// Shader object is linkable at tesselation evaluation stage.
		/// </summary>
		TessellationEvaluation = Gl.TESS_EVALUATION_SHADER,

		/// <summary>
		/// Shader object is linkable at geometry stage.
		/// </summary>
		Geometry = Gl.GEOMETRY_SHADER,

		/// <summary>
		/// Shader object is linkable at fragment stage.
		/// </summary>
		Fragment = Gl.FRAGMENT_SHADER,
	}
}
