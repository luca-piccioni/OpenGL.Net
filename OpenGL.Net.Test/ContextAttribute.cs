
// Copyright (C) 2015 Luca Piccioni
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

using System;

namespace OpenGL.Test
{
	/// <summary>
	/// Determine the OpenGL context requirement for the test fixture.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	class ContextAttribute : Attribute
	{
		/// <summary>
		/// Type of context required by the test fixture.
		/// </summary>
		public enum ContextMode
		{
			/// <summary>
			/// No special context requirement.
			/// </summary>
			Any,
			/// <summary>
			/// Requires a core profile context.
			/// </summary>
			CoreProfile,
			/// <summary>
			/// Requires a compatibility profile context.
			/// </summary>
			CompatibilityProfile
		}

		/// <summary>
		/// Type of context required by the test fixture.
		/// </summary>
		public ContextMode ContextRequired = ContextMode.Any;
	}
}
