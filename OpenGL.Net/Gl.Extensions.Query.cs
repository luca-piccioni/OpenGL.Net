
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
using System.Collections.Generic;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Extension support listing.
		/// </summary>
		public partial class Extensions
		{
			/// <summary>
			/// Query the extensions supported by current platform.
			/// </summary>
			/// <remarks>
			/// An OpenGL context must be current on the calling thread.
			/// </remarks>
			public void Query()
			{
				LogComment("Query GL extensions.");

				string glVersionString = GetString(StringName.Version);
				if (glVersionString == null)
					throw new InvalidOperationException("unable to determine OpenGL version");

				KhronosVersion glVersion = KhronosVersion.Parse(glVersionString);
				bool indexedExtensions = (glVersion.Major >= 3) && (Delegates.pglGetStringi != null);

				if (indexedExtensions) {
					int extensionCount;

					Get(GetPName.NumExtensions, out extensionCount);

					List<string> extensions = new List<string>();
					for (uint i = 0; i < (uint)extensionCount; i++)
						extensions.Add(GetString((int)StringName.Extensions, i));

					Query(glVersion, extensions.ToArray());
				} else {
					Query(glVersion, GetString(StringName.Extensions));
				}
			}

			/// <summary>
			/// Clone this instance.
			/// </summary>
			/// <returns>
			/// It returns a deep copy of this Extension.
			/// </returns>
			public Extensions Clone()
			{
				return ((Extensions)MemberwiseClone());
			}
		}
	}
}
