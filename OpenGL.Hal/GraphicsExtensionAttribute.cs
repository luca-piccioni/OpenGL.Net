
// Copyright (C) 2009-2015 Luca Piccioni
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
	/// <summary>
	/// Base class for managing extension offered by the OpenGL platform.
	/// </summary>
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
	class GraphicsExtensionAttribute : Attribute
	{
		#region Constructors

		/// <summary>
		/// Construct a GraphicsExtensionAttribute.
		/// </summary>
		/// <param name="extension">
		/// A <see cref="System.String"/> that specifies the main extension name string.
		/// </param>
		/// <param name="extensionAltenative">
		/// A <see cref="T:System.String[]"/> that specifies the alternative extension name strings.
		/// </param>
		public GraphicsExtensionAttribute(string extension, params string[] extensionAltenative)
		{
			if (String.IsNullOrEmpty(extension))
				throw new ArgumentException("invalid extension string", "extension");

			// Store main extention string
			_ExtensionString = extension;
			// Store alternative extension strings
			_ExtensionAlternatives = extensionAltenative;
		}

		#endregion

		/// <summary>
		/// Check whether one of the extention strings is supported.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that specifies the current OpenGL version to test for extension support. In the case this
		/// parameter is null, the test fallback to the current OpenGL version.
		/// </param>
		public bool IsSupported(GraphicsContext ctx, IDeviceContext deviceContext)
		{
			if (IsSupportedExtension(ctx, deviceContext, _ExtensionString) == true)
				return (true);
			if (_ExtensionAlternatives != null) {
				foreach (string ext in _ExtensionAlternatives)
					if (IsSupportedExtension(ctx, deviceContext, ext) == true)
						return (true);
			}

			return (false);
		}

		/// <summary>
		/// Determine whether an OpenGL extension is supported by a <see cref="GraphicsContext"/>.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that specifies the current OpenGL version to test for extension support. In the case this
		/// parameter is null, the test fallback to the current OpenGL version.
		/// </param>
		/// <param name="extension">
		/// A <see cref="System.String"/> that specifies the OpenGL extension for support.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the OpenGL extension is supported by a specific OpenGL version.
		/// </returns>
		private bool IsSupportedExtension(GraphicsContext ctx, IDeviceContext deviceContext, string extension)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (deviceContext == null)
				throw new ArgumentNullException("deviceContext");
			if (extension == null)
				throw new ArgumentNullException("ext");

			if (extension.StartsWith("GL_")) {
				if (ctx == null)
					return (Gl.HasExtension(extension));
				else
					return (Gl.HasExtension(GraphicsContext.GetGLVersionId(ctx.Version), extension));
			} else if (extension.StartsWith("GLX_")) {
				switch (Environment.OSVersion.Platform) {
					case PlatformID.Unix:
						return (Glx.HasExtension(deviceContext, extension));
					default:
						return (false);
				}
			} else if (extension.StartsWith("WGL_")) {
				switch (Environment.OSVersion.Platform) {
					case PlatformID.Win32Windows:
					case PlatformID.Win32NT:
					case PlatformID.WinCE:
						return (Wgl.HasExtension(deviceContext, extension));
					default:
						return (false);
				}
			} else
				throw new ArgumentException(extension + "is not a recognized GL extension", "ext");
		}

		/// <summary>
		/// Get the extension strings, including the alternative ones.
		/// </summary>
		public IEnumerable<string> ExtensionStrings
		{
			get
			{
				string[] extensionStrings = new string[1 + _ExtensionAlternatives.Length];

				extensionStrings[0] = _ExtensionString;
				Array.Copy(_ExtensionAlternatives, 0, extensionStrings, 1, _ExtensionAlternatives.Length);

				return (extensionStrings);
			}
		}

		/// <summary>
		/// Main extension string.
		/// </summary>
		private string _ExtensionString;

		/// <summary>
		/// Extension strings alternative to <see cref="_ExtensionString"/>.
		/// </summary>
		private string[] _ExtensionAlternatives;
	}
}
