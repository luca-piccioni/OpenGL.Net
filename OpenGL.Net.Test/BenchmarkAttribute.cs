
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

using System;

namespace OpenGL.Test
{
	/// <summary>
	/// Attribute for marking benchmark methods.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public class BenchmarkAttribute : Attribute
	{
		#region Constructors

		/// <summary>
		/// Construct a BenchmarkAttribute.
		/// </summary>
		/// <param name="name">
		/// A <see cref="String"/> that specifies the name of the benchmark.
		/// </param>
		public BenchmarkAttribute(string name)
		{
			if (name == null)
				throw new ArgumentNullException("name");

			Name = name;
		}

		#endregion

		#region Properties

		/// <summary>
		/// The name of the benchmark.
		/// </summary>
		public readonly string Name;

		/// <summary>
		/// Number of repetitions.
		/// </summary>
		public int Repetitions = 1;

		#endregion
	}
}
