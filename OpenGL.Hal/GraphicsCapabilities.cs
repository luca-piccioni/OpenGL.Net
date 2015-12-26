
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
using System.Reflection;

namespace OpenGL
{
	/// <summary>
	/// OpenGL implementation capabilities.
	/// </summary>
	public class GraphicsCapabilities
	{
		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public GraphicsCapabilities()
		{
			_PlatformExtensions = new PlatformExtensionsCollection(this);
		}

		#endregion

		#region Query

		/// <summary>
		/// Query OpenGL implementation extensions.
		/// </summary>
		/// <param name="ctx"></param>
		/// <returns></returns>
		public static GraphicsCapabilities Query(GraphicsContext ctx, IDeviceContext deviceContext)
		{
			GraphicsCapabilities graphicsCapabilities = new GraphicsCapabilities();

			#region Platform Extension Reload

			// Since at this point there's a current OpenGL context, it's possible to use
			// {glx|wgl}GetExtensionsString to retrieve platform specific extensions

			switch (Environment.OSVersion.Platform) {
				case PlatformID.Win32NT:
				case PlatformID.Win32Windows:
				case PlatformID.Win32S:
				case PlatformID.WinCE:
					// Wgl.SyncDelegates();
					break;
			}

			#endregion

			// OpenGL extensions
			graphicsCapabilities._GlExtensions.Query();
			// Windows OpenGL extensions
			WindowsDeviceContext windowsDeviceContext = deviceContext as WindowsDeviceContext;
			if (windowsDeviceContext != null)
				graphicsCapabilities._WglExtensions.Query(windowsDeviceContext);
			// GLX OpenGL extensions
			XServerDeviceContext xserverDeviceContext = deviceContext as XServerDeviceContext;
			if (xserverDeviceContext != null)
				graphicsCapabilities._GlxExtensions.Query(xserverDeviceContext);

			// Query implementation limits
			graphicsCapabilities._GraphicsLimits = GraphicsLimits.Query(ctx, deviceContext);

			return (graphicsCapabilities);
		}

		#endregion

		#region OpenGL Information

		/// <summary>
		/// The graphic adapter used as renderer.
		/// </summary>
		[GraphicsInfo(Gl.RENDERER)]
		public string RendererString;

		/// <summary>
		/// The renderer vendor.
		/// </summary>
		[GraphicsInfo(Gl.VENDOR)]
		public string VendorString;

		/// <summary>
		/// The implemented OpenGL version.
		/// </summary>
		[GraphicsInfo(Gl.VERSION)]
		public string VersionString;

		/// <summary>
		/// The implemented OpenGL Shading Language version.
		/// </summary>
		[GraphicsInfo(Gl.SHADING_LANGUAGE_VERSION)]
		public string ShadingLanguageVersion;

		#endregion

		#region Extensions Support

		/// <summary>
		/// Platform extensions (common OpenGL extensions for WGL and GLX platforms).
		/// </summary>
		public sealed class PlatformExtensionsCollection
		{
			#region Constructors

			/// <summary>
			/// Construct a PlatformExtensions specifying the GraphicsCapabilities which it belongs to.
			/// </summary>
			/// <param name="caps"></param>
			internal PlatformExtensionsCollection(GraphicsCapabilities caps)
			{
				if (caps == null)
					throw new ArgumentNullException("caps");

				_GraphicsCapabilities = caps;
			}

			private readonly GraphicsCapabilities _GraphicsCapabilities;

			#endregion

			#region Common Extensions Between Platforms

			/// <summary>
			/// Support for extension WGL_ARB_create_context or GLX_ARB_create_context.
			/// </summary>
			public bool CreateContext_ARB
			{
				get { return (_GraphicsCapabilities.WglExtensions.CreateContext_ARB || _GraphicsCapabilities.GlxExtensions.CreateContext_ARB); }
			}

			/// <summary>
			/// Support for extension WGL_ARB_create_context_profile or GLX_ARB_create_context_profile.
			/// </summary>
			public bool CreateContextProfile_ARB
			{
				get { return (_GraphicsCapabilities.WglExtensions.CreateContextProfile_ARB || _GraphicsCapabilities.GlxExtensions.CreateContextProfile_ARB); }
			}

			/// <summary>
			/// Support for extension WGL_ARB_multisample or GLX_ARB_multisample.
			/// </summary>
			public bool Multisample_ARB
			{
				get { return (_GraphicsCapabilities.WglExtensions.Multisample_ARB || _GraphicsCapabilities.GlxExtensions.Multisample_ARB); }
			}

			#endregion
		}

		/// <summary>
		/// Get OpenGL extensions support.
		/// </summary>
		public Gl.Extensions GlExtensions { get { return (_GlExtensions); } }

		/// <summary>
		/// OpenGL extensions support.
		/// </summary>
		private readonly Gl.Extensions _GlExtensions = new Gl.Extensions();

		/// <summary>
		/// Get Windows OpenGL extensions support.
		/// </summary>
		public Wgl.Extensions WglExtensions { get { return (_WglExtensions); } }

		/// <summary>
		/// Windows OpenGL extensions support.
		/// </summary>
		private readonly Wgl.Extensions _WglExtensions = new Wgl.Extensions();

		/// <summary>
		/// Get GLX OpenGL extensions support.
		/// </summary>
		public Glx.Extensions GlxExtensions { get { return (_GlxExtensions); } }

		/// <summary>
		/// GLX OpenGL extensions support.
		/// </summary>
		private readonly Glx.Extensions _GlxExtensions = new Glx.Extensions();

		/// <summary>
		/// Get platform extensions (WGL and GLX common extensions).
		/// </summary>
		public PlatformExtensionsCollection PlatformExtensions { get { return (_PlatformExtensions); } }

		/// <summary>
		/// Platform extensions (WGL and GLX common extensions).
		/// </summary>
		private readonly PlatformExtensionsCollection _PlatformExtensions;

		#endregion

		#region OpenGL Implementation Limits

		/// <summary>
		/// Get the OpenGL implementation limits.
		/// </summary>
		public GraphicsLimits Limits { get { return (_GraphicsLimits); } }

		/// <summary>
		/// OpenGL implementation limits.
		/// </summary>
		private GraphicsLimits _GraphicsLimits;

		#endregion
	}
}
