
// Copyright (C) 2011-2017 Luca Piccioni
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
	/// Interface implemented by all plugin implementations.
	/// </summary>
	public interface IPlugin
	{
		#region Plugin Identification

		/// <summary>
		/// Plugin name.
		/// </summary>
		/// <remarks>
		/// This name identity the plugin implementation. It shall be unique in the plugin set available at runtime.
		/// </remarks>
		string Name { get; }

		/// <summary>
		/// Determine whether this plugin is available for the current process.
		/// </summary>
		/// <returns>
		/// It returns a boolean value indicating whether the plugin is available for the current process.
		/// </returns>
		bool CheckAvailability();

		#endregion
	}
}
