
// Copyright (C) 2010 Luca
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

using System.Collections.Generic;
using System.Diagnostics;

namespace OpenGL
{
	/// <summary>
	/// Generic shader interface.
	/// </summary>
	public interface IShaderInterface
	{
		/// <summary>
		/// Exposed symbols by ShaderInterface implementation.
		/// </summary>
		string[] Interface { get; }

		/// <summary>
		/// Shader source ShaderInterface implementation.
		/// </summary>
		string[] Source { get; }
	}

	/// <summary>
	/// Commonly used shader interface.
	/// </summary>
	/// <remarks>
	/// <para>
	/// <b>Vertex projection</b>
	/// The interface used for projecting vertices on a homogeneous space is named <b>IProjectVertex</b>. It is
	/// fundamental for transforming vertices and normals.
	/// </para>
	/// </remarks>
	public abstract class ShaderInterface : IShaderInterface
	{
		#region Constructors & Destructor

		/// <summary>
		/// Construct an empty ShaderInterface
		/// </summary>
		/// <remarks>
		/// This constructor is used by ShaderObject class.
		/// </remarks>
		protected ShaderInterface() { }

		/// <summary>
		/// Construct a ShaderInterface defining its declarations.
		/// </summary>
		/// <param name="interface">
		/// A <see cref="System.String[]"/> defining the interface declarations.
		/// </param>
		/// <remarks>
		/// This constructor is used by classes deriving ShaderInterface and has
		/// only a fixed interface source strings.
		/// </remarks>
		protected ShaderInterface(string[] @interface)
		{
#if DEBUG
			Debug.Assert(@interface != null);
			foreach (string s in @interface)
				Debug.Assert(s != null);
#endif

			// Store interface declarations
			mInterface = @interface;
		}

		#endregion

		#region IShaderInterface Implementation

		/// <summary>
		/// Implementation of <see cref="IShaderInterface"/>.
		/// </summary>
		public virtual string[] Interface { get { return (mInterface); } }

		/// <summary>
		/// Implementation of <see cref="IShaderInterface"/>.
		/// </summary>
		public virtual string[] Source { get { return (null); } }

		/// <summary>
		/// Interface declarations.
		/// </summary>
		protected string[] mInterface = null;

		#endregion
	}
}