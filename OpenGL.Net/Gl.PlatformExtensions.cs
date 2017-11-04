
// Copyright (C) 2009-2017 Luca Piccioni
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

using Khronos;

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
				get
				{
#if !MONODROID
					if (Egl.IsRequired == false) {
						switch (Platform.CurrentPlatformId) {
							case Platform.Id.WindowsNT:
								return (Wgl.CurrentExtensions != null && Wgl.CurrentExtensions.CreateContext_ARB);
							case Platform.Id.Linux:
								return (Glx.CurrentExtensions != null && Glx.CurrentExtensions.CreateContext_ARB);
							case Platform.Id.MacOS:
								if (Glx.IsRequired)
									return (Glx.CurrentExtensions != null && Glx.CurrentExtensions.CreateContext_ARB);
								else
									throw new NotSupportedException("platform MacOS not supported without Glx.IsRequired=true");
							default:
								return (false);
						}
					} else
#endif
						return (false);
				}
			}

			/// <summary>
			/// Support for extension WGL_ARB_create_context_profile or GLX_ARB_create_context_profile.
			/// </summary>
			public bool CreateContextProfile_ARB
			{
				get
				{
#if !MONODROID
					if (Egl.IsRequired == false) {
						switch (Platform.CurrentPlatformId) {
							case Platform.Id.WindowsNT:
								return (Wgl.CurrentExtensions != null && Wgl.CurrentExtensions.CreateContextProfile_ARB);
							case Platform.Id.Linux:
								return (Glx.CurrentExtensions != null && Glx.CurrentExtensions.CreateContextProfile_ARB);
							case Platform.Id.MacOS:
								if (Glx.IsRequired)
									return (Glx.CurrentExtensions != null && Glx.CurrentExtensions.CreateContextProfile_ARB);
								else
									throw new NotSupportedException("platform MacOS not supported without Glx.IsRequired=true");
							default:
								return (false);
						}
					} else
#endif
						return (false);
				}
			}

			/// <summary>
			/// Support for extension WGL_ARB_create_context_robustness or GLX_ARB_create_context_robustness.
			/// </summary>
			public bool CreateContextRobustness_ARB
			{
				get
				{
#if !MONODROID
					if (Egl.IsRequired == false) {
						switch (Platform.CurrentPlatformId) {
							case Platform.Id.WindowsNT:
								return (Wgl.CurrentExtensions != null && Wgl.CurrentExtensions.CreateContextRobustness_ARB);
							case Platform.Id.Linux:
								return (Glx.CurrentExtensions != null && Glx.CurrentExtensions.CreateContextRobustness_ARB);
							case Platform.Id.MacOS:
								if (Glx.IsRequired)
									return (Glx.CurrentExtensions != null && Glx.CurrentExtensions.CreateContextRobustness_ARB);
								else
									throw new NotSupportedException("platform MacOS not supported without Glx.IsRequired=true");
							default:
								return (false);
						}
					} else
#endif
						return (false);
				}
			}

			/// <summary>
			/// Support for extension WGL_EXT_create_context_es_profile or GLX_EXT_create_context_es_profile.
			/// </summary>
			public bool CreateContextEsProfile_EXT
			{
				get
				{
#if !MONODROID
					if (Egl.IsRequired == false) {
						switch (Platform.CurrentPlatformId) {
							case Platform.Id.WindowsNT:
								return (Wgl.CurrentExtensions != null && Wgl.CurrentExtensions.CreateContextEsProfile_EXT);
							case Platform.Id.Linux:
								return (Glx.CurrentExtensions != null && Glx.CurrentExtensions.CreateContextEsProfile_EXT);
							case Platform.Id.MacOS:
								if (Glx.IsRequired)
									return (Glx.CurrentExtensions != null && Glx.CurrentExtensions.CreateContextEsProfile_EXT);
								else
									throw new NotSupportedException("platform MacOS not supported without Glx.IsRequired=true");
							default:
								return (false);
						}
					} else
#endif
						return (false);
				}
			}

			/// <summary>
			/// Support for extension WGL_ARB_multisample or GLX_ARB_multisample.
			/// </summary>
			public bool Multisample_ARB
			{
				get
				{
#if !MONODROID
					if (Egl.IsRequired == false) {
						switch (Platform.CurrentPlatformId) {
							case Platform.Id.WindowsNT:
								return (Wgl.CurrentExtensions != null && Wgl.CurrentExtensions.Multisample_ARB);
							case Platform.Id.Linux:
								return (Glx.CurrentExtensions != null && Glx.CurrentExtensions.Multisample_ARB);
							case Platform.Id.MacOS:
								if (Glx.IsRequired)
									return (Glx.CurrentExtensions != null && Glx.CurrentExtensions.Multisample_ARB);
								else
									throw new NotSupportedException("platform MacOS not supported without Glx.IsRequired=true");
							default:
								return (false);
						}
					} else
#endif
						return (false);
				}
			}

			/// <summary>
			/// Support for extension WGL_swap_control_EXT or GLX_swap_control_EXT.
			/// </summary>
			public bool SwapControl
			{
				get
				{
#if !MONODROID
					if (Egl.IsRequired == false) {
						switch (Platform.CurrentPlatformId) {
							case Platform.Id.WindowsNT:
								return (Wgl.CurrentExtensions != null && Wgl.CurrentExtensions.SwapControl_EXT);
							case Platform.Id.Linux:
								return (Glx.CurrentExtensions != null && Glx.CurrentExtensions.SwapControl_EXT);
							case Platform.Id.MacOS:
								if (Glx.IsRequired)
									return (Glx.CurrentExtensions != null && Glx.CurrentExtensions.SwapControl_EXT);
								else
									throw new NotSupportedException("platform MacOS not supported without Glx.IsRequired=true");
							default:
								return (false);
						}
					} else
#endif
						return (false);
				}
			}

			/// <summary>
			/// Support for extension WGL_swap_control_tear_EXT or GLX_swap_control_tear_EXT.
			/// </summary>
			public bool SwapControlTear
			{
				get
				{
#if !MONODROID
					if (Egl.IsRequired == false) {
						switch (Platform.CurrentPlatformId) {
							case Platform.Id.WindowsNT:
								return (Wgl.CurrentExtensions != null && Wgl.CurrentExtensions.SwapControlTear_EXT);
							case Platform.Id.Linux:
								return (Glx.CurrentExtensions != null && Glx.CurrentExtensions.SwapControlTear_EXT);
							case Platform.Id.MacOS:
								if (Glx.IsRequired)
									return (Glx.CurrentExtensions != null && Glx.CurrentExtensions.SwapControlTear_EXT);
								else
									throw new NotSupportedException("platform MacOS not supported without Glx.IsRequired=true");
							default:
								return (false);
						}
					} else
#endif
						return (false);
				}
			}

			#endregion
		}

		/// <summary>
		/// Common platform extensions.
		/// </summary>
		public static readonly PlatformExtensionsCollection PlatformExtensions = new PlatformExtensionsCollection();
	}
}
