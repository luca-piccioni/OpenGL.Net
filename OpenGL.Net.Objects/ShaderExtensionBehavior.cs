
// Copyright (C) 2013-2017 Luca Piccioni
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
	}
}

