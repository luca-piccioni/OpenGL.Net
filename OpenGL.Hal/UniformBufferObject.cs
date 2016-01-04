
// Copyright (C) 2010-2013 Luca Piccioni
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//  
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//  
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace OpenGL
{
	/// <summary>
	/// A buffer object containing a set of uniform variables, which can be bound to a <see cref="ShaderProgram"/>.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class UniformBufferObject<T> : BufferObject where T : struct
	{
		#region Constructors

		/// <summary>
		/// Construct an UniformBufferObject.
		/// </summary>
		/// <param name="hint">
		/// An <see cref="BufferObjectHint"/> that specify the data buffer usage hint.
		/// </param>
		public UniformBufferObject(BufferObjectHint hint) :
			base(BufferTargetARB.UniformBuffer, hint)
		{

		}

		#endregion
	}
}