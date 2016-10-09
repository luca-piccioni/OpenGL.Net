
// Copyright (C) 2009-2016 Luca Piccioni
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

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Platform extensions (common OpenGL extensions for WGL and GLX platforms).
		/// </summary>
		public sealed class PlatformExtensionsCollection
		{
			#region Common Extensions Between Platforms

			/// <summary>
			/// Support for extension WGL_ARB_create_context or GLX_ARB_create_context.
			/// </summary>
			public bool CreateContext_ARB
			{
				get { return (Wgl.CurrentExtensions.CreateContext_ARB || Glx.CurrentExtensions.CreateContext_ARB); }
			}

			/// <summary>
			/// Support for extension WGL_ARB_create_context_profile or GLX_ARB_create_context_profile.
			/// </summary>
			public bool CreateContextProfile_ARB
			{
				get { return (Wgl.CurrentExtensions.CreateContextProfile_ARB || Glx.CurrentExtensions.CreateContextProfile_ARB); }
			}

			/// <summary>
			/// Support for extension WGL_ARB_multisample or GLX_ARB_multisample.
			/// </summary>
			public bool Multisample_ARB
			{
				get { return (Wgl.CurrentExtensions.Multisample_ARB || Glx.CurrentExtensions.Multisample_ARB); }
			}

			/// <summary>
			/// Support for extension WGL_swap_control_EXT or GLX_swap_control_EXT.
			/// </summary>
			public bool SwapControl
			{
				get { return (Wgl.CurrentExtensions.SwapControl_EXT || Glx.CurrentExtensions.SwapControl_EXT); }
			}

			/// <summary>
			/// Support for extension WGL_swap_control_tear_EXT or GLX_swap_control_tear_EXT.
			/// </summary>
			public bool SwapControlTear
			{
				get { return (Wgl.CurrentExtensions.SwapControlTear_EXT || Glx.CurrentExtensions.SwapControlTear_EXT); }
			}

			#endregion
		}

		/// <summary>
		/// Common platform extensions.
		/// </summary>
		public static readonly PlatformExtensionsCollection PlatformExtensions = new PlatformExtensionsCollection();
	}
}
