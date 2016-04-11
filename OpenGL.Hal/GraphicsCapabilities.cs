
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

			KhronosApi.LogComment("Query OpenGL extensions.");

			// OpenGL extensions
			graphicsCapabilities._GlExtensions = Gl.CurrentExtensions;
			// Windows OpenGL extensions
			WindowsDeviceContext windowsDeviceContext = deviceContext as WindowsDeviceContext;
			if (windowsDeviceContext != null)
				graphicsCapabilities._WglExtensions = Wgl.CurrentExtensions;
			// GLX OpenGL extensions
			XServerDeviceContext xserverDeviceContext = deviceContext as XServerDeviceContext;
			if (xserverDeviceContext != null)
				graphicsCapabilities._GlxExtensions = Glx.CurrentExtensions;
			// EGL OpenGL extensions
			NativeDeviceContext nativeDeviceContext = deviceContext as NativeDeviceContext;
			if (nativeDeviceContext != null)
				graphicsCapabilities._EglExtensions = Egl.CurrentExtensions;

			// Query implementation limits
			graphicsCapabilities._GraphicsLimits = GraphicsLimits.Query(graphicsCapabilities._GlExtensions);

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

			/// <summary>
			/// Support for extension WGL_swap_control_EXT or GLX_swap_control_EXT.
			/// </summary>
			public bool SwapControl
			{
				get { return (_GraphicsCapabilities.WglExtensions.SwapControl_EXT || _GraphicsCapabilities.GlxExtensions.SwapControl_EXT); }
			}

			/// <summary>
			/// Support for extension WGL_swap_control_tear_EXT or GLX_swap_control_tear_EXT.
			/// </summary>
			public bool SwapControlTear
			{
				get { return (_GraphicsCapabilities.WglExtensions.SwapControlTear_EXT || _GraphicsCapabilities.GlxExtensions.SwapControlTear_EXT); }
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
		private Gl.Extensions _GlExtensions = new Gl.Extensions();

		/// <summary>
		/// Get Windows OpenGL extensions support.
		/// </summary>
		public Wgl.Extensions WglExtensions { get { return (_WglExtensions); } }

		/// <summary>
		/// Windows OpenGL extensions support.
		/// </summary>
		private Wgl.Extensions _WglExtensions = new Wgl.Extensions();

		/// <summary>
		/// Get GLX OpenGL extensions support.
		/// </summary>
		public Glx.Extensions GlxExtensions { get { return (_GlxExtensions); } }

		/// <summary>
		/// GLX OpenGL extensions support.
		/// </summary>
		private Glx.Extensions _GlxExtensions = new Glx.Extensions();

		/// <summary>
		/// Get  EGL OpenGL extensions support.
		/// </summary>
		public Egl.Extensions EglExtensions { get { return (_EglExtensions); } }

		/// <summary>
		/// EGL OpenGL extensions support.
		/// </summary>
		private Egl.Extensions _EglExtensions = new Egl.Extensions();

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

		#region Clone

		/// <summary>
		/// Clone this GraphicsCapabilities.
		/// </summary>
		/// <returns></returns>
		public GraphicsCapabilities Clone()
		{
			GraphicsCapabilities clone = (GraphicsCapabilities)MemberwiseClone();

			clone._GlExtensions = _GlExtensions.Clone();
			clone._WglExtensions = _WglExtensions.Clone();
			clone._GlxExtensions = _GlxExtensions.Clone();

			return (clone);
		}

		#endregion
	}
}
