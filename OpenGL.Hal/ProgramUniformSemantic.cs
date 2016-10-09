
// Copyright (C) 2016 Luca Piccioni
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
	/// Commonly used semantic for program uniforms.
	/// </summary>
	public static class ProgramUniformSemantic
	{
		#region Transform State

		/// <summary>
		/// Projection matrix.
		/// </summary>
		public const string Projection = "Projection";

		/// <summary>
		/// Model-view matrix.
		/// </summary>
		public const string ModelView = "ModelView";

		/// <summary>
		/// Model-view-projection matrix.
		/// </summary>
		public const string ModelViewProjection = "ModelViewProjection";

		/// <summary>
		/// Normal transformation matrix.
		/// </summary>
		public const string NormalMatrix = "NormalMatrix";

		/// <summary>
		/// Inverse of Projection matrix.
		/// </summary>
		public const string InverseProjection = "InverseProjection";

		/// <summary>
		/// Inverse of Model-view matrix.
		/// </summary>
		public const string InverseModelView = "InverseModelView";

		/// <summary>
		/// Inverse of Model-view-projection matrix.
		/// </summary>
		public const string InverseModelViewProjection = "InverseModelViewProjection";

		#endregion

		#region Viewport

		/// <summary>
		/// The size of the viewport, in pixels.
		/// </summary>
		public const string ViewportSize = "ViewportSize";

		/// <summary>
		/// The projection depth in model space.
		/// </summary>
		public const string ViewportDepth = "ViewportDepth";

		#endregion

		#region Time

		/// <summary>
		/// The animation time, in seconds.
		/// </summary>
		public const string AnimationTime = "AnimationTime";

		/// <summary>
		/// The frame time interval, in seconds.
		/// </summary>
		public const string FrameTimeInterval = "FrameTimeInterval";

		#endregion
	}
}
