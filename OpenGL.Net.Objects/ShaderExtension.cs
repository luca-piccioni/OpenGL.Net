
// Copyright (c) 2013-2016 Luca Piccioni
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

using System;
using System.Xml.Serialization;

namespace OpenGL.Objects
{
	/// <summary>
	/// Shader program extension.
	/// </summary>
	[XmlType("Extension")]
	public class ShaderExtension
	{
		#region Constructor
		
		/// <summary>
		/// Parameterless constructor.
		/// </summary>
		public ShaderExtension()
		{
			
		}
		
		/// <summary>
		/// Construct a ShaderExtension specifying the extension name and behavior.
		/// </summary>
		public ShaderExtension(string extensionName, ShaderExtensionBehavior behavior)
		{
			if (extensionName == null)
				throw new ArgumentNullException("extensionName");
			
			Name = extensionName;
			Behavior = behavior;
		}
		
		#endregion
		
		#region Extension Information
		
		/// <summary>
		/// The interface name.
		/// </summary>
		[XmlAttribute("Name")]
		public string Name;
		
		/// <summary>
		/// The shader extension requested behavior.
		/// </summary>
		[XmlAttribute("Behavior")]
		public ShaderExtensionBehavior Behavior = ShaderExtensionBehavior.Warn;
		
		#endregion
	}
}

