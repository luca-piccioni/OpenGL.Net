
// Copyright (c) 2013-2016 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

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

