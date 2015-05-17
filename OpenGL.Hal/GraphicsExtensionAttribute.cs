
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
			mExtensionString = extension;
			// Store alternative extension strings
			mExtensionAlternatives = extensionAltenative;
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
			if (IsSupportedExtension(ctx, deviceContext, mExtensionString) == true)
				return (true);
			if (mExtensionAlternatives != null) {
				foreach (string ext in mExtensionAlternatives)
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
		/// <param name="ext">
		/// A <see cref="System.String"/> that specifies the OpenGL extension for support.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the OpenGL extension is supported by a specific OpenGL version.
		/// </returns>
		private bool IsSupportedExtension(GraphicsContext ctx, IDeviceContext deviceContext, string ext)
		{
			if (ext.StartsWith("GL_")) {
				if (ctx == null)
					return (Gl.HasExtension(ext));
				else
					return (Gl.HasExtension(GraphicsContext.GetGLVersionId(ctx.Version), ext));
			} else if (ext.StartsWith("GLX_")) {
				switch (Environment.OSVersion.Platform) {
					case PlatformID.Unix:
						return (Glx.HasExtension(deviceContext, ext));
					default:
						return (false);
				}
			} else if (ext.StartsWith("WGL_")) {
				switch (Environment.OSVersion.Platform) {
					case PlatformID.Win32Windows:
					case PlatformID.Win32NT:
					case PlatformID.WinCE:
						return (Wgl.HasExtension(deviceContext, ext));
					default:
						return (false);
				}
			} else
				throw new ArgumentException(ext + "is not a recognized GL extension", "ext");
		}

		/// <summary>
		/// Get the extension strings, including the alternative ones.
		/// </summary>
		public IEnumerable<string> ExtensionStrings
		{
			get
			{
				string[] extensionStrings = new string[1 + mExtensionAlternatives.Length];

				extensionStrings[0] = mExtensionString;
				Array.Copy(mExtensionAlternatives, 0, extensionStrings, 1, mExtensionAlternatives.Length);

				return (extensionStrings);
			}
		}

		/// <summary>
		/// Main extension string.
		/// </summary>
		private string mExtensionString;

		/// <summary>
		/// Extension strings alternative to <see cref="mExtensionString"/>.
		/// </summary>
		private string[] mExtensionAlternatives;
	}
}
