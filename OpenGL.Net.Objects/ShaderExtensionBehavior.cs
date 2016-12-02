
// Copyright (C) 2013-2016 Luca Piccioni
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

using System.Xml.Serialization;

namespace OpenGL.Objects
{
	/// <summary>
	/// Enumeration that specify the shader exception behavior..
	/// </summary>
	[XmlType("ShaderExtensionBehavior")]
	public enum ShaderExtensionBehavior
	{
		#region Standard Behaviors
		
		/// <summary>
		/// Behave as specified by the extension extension_name.
		/// </summary>
		/// <remarks>
		/// Give an error on the #extension if the extension extension_name is not supported, or if all is specified.
		/// </remarks>
		[XmlEnum("Require")] 
		Require,
		
		/// <summary>
		/// Behave as specified by the extension extension_name.
		/// </summary>
		/// <remarks>
		/// <para>
		/// Warn on the #extension if the extension extension_name is not supported.
		/// </para>
		/// <para>
		/// Give an error on the #extension if all is specified.
		/// </para>
		/// </remarks>
		[XmlEnum("Enable")] 
		Enable,
		
		/// <summary>
		/// Behave as specified by the extension extension_name, except issue warnings
		/// on any detectable use of that extension, unless such use is supported by other
		/// enabled or required extensions.
		/// </summary>
		/// <remarks>
		/// If all is specified, then warn on all detectable uses of any extension used.
		/// </remarks>
		[XmlEnum("Warn")] 
		Warn,
		
		/// <summary>
		/// Behave (including issuing errors and warnings) as if the extension
		/// extension_name is not part of the language definition.
		/// </summary>
		/// <remarks>
		/// <para>
		/// If all is specified, then behavior must revert back to that of the non-extended
		/// core version of the language being compiled to.
		/// </para>
		/// <para>
		/// Warn on the #extension if the extension extension_name is not supported.
		/// </para>
		/// </remarks>
		[XmlEnum("Disable")] 
		Disable,
		
		#endregion
		
		#region Sophisticated Behaviors
		
		/// <summary>
		/// Behave as specified by the extension, but declare the extension even in the case
		/// the extension is supported by the actual GLSL version.
		/// </summary>
		[XmlEnum("ForceEnable")] 
		ForceEnable,
		
		#endregion
	}
}

