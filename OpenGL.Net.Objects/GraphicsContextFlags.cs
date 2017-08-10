
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

namespace OpenGL.Objects
{
	/// <summary>
	/// Flags controlling the <see cref="GraphicsContext"/> bahvior.
	/// </summary>
	[Flags]
	public enum GraphicsContextFlags
	{
		/// <summary>
		/// No flag.
		/// </summary>
		None = 					0x0000,

		#region Flags

		/// <summary>
		/// Construct a context using the debug profile.
		/// </summary>
		/// <remarks>
		/// One of the following extension must be implemented for supporting this flag:
		/// - GLX_ARB_create_context
		/// - WGL_ARB_create_context
		/// </remarks>
		Debug = 				0x0001,
		
		/// <summary>
		/// Constant a forward compatible context.
		/// </summary>
		/// <remarks>
		/// Forward compatibility is considered only if the following extensions are implemented:
		/// - GLX_ARB_create_context
		/// - WGL_ARB_create_context
		/// </remarks>
		ForwardCompatible = 	0x0002,

		/// <summary>
		/// Construct a context using the robust profile.
		/// </summary>
		/// <remarks>
		/// One of the following extensions set must be implemented for supporting this flag:
		/// - GLX_ARB_create_context, GLX_ARB_create_context_robustness and GL_ARB_robustness
		/// - WGL_ARB_create_context, WGL_ARB_create_context_robustness and GL_ARB_robustness
		/// </remarks>
		Robust =				0x0004,

		/// <summary>
		/// Reset event is guaranteed to do not affect other applications.
		/// </summary>
		ResetIsolation =		0x0080,

		#endregion

		#region Profiles

		/// <summary>
		/// Construct a context using the compatibility profile.
		/// </summary>
		/// <remarks>
		/// One of the following extension must be implemented for supporting this flag:
		/// - GLX_ARB_create_context_profile
		/// - WGL_ARB_create_context_profile
		/// </remarks>
		CoreProfile =			0x0100,

		/// <summary>
		/// Construct a context using the compatibility profile.
		/// </summary>
		/// <remarks>
		/// One of the following extension must be implemented for supporting this flag:
		/// - GLX_ARB_create_context_profile
		/// - WGL_ARB_create_context_profile
		/// </remarks>
		CompatibilityProfile =	0x0200,
		
		/// <summary>
		/// Constant a context using a ES/ES2 compatible implementation.
		/// </summary>
		/// <remarks>
		/// One of the following extensions set must be implemented for supporting this flag:
		/// - GLX_ARB_create_context_profile and GLX_EXT_create_context_es_profile/GLX_EXT_create_context_es2_profile
		/// - WGL_ARB_create_context_profile and WGL_EXT_create_context_es_profile/WGL_EXT_create_context_es2_profile
		/// </remarks>
		EmbeddedProfile =		0x0400

		#endregion
	}
}

