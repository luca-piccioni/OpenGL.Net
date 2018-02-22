
// Copyright (C) 2015-2018 Luca Piccioni
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
using System.Diagnostics;
using System.Threading;

using Khronos;

using NUnit.Framework;

namespace OpenGL.Test
{
	/// <summary>
	/// Abstract base test creating an OpenGL context used for testing.
	/// </summary>
#if !NETCORE && !MONODROID
	[Apartment(ApartmentState.STA)]
#endif
	internal abstract class TestBaseGL : TestBaseDevice
	{
		#region Context

		/// <summary>
		/// Very simple GL context abstraction implementing IDisposable.
		/// </summary>
		protected class GLContext : IDisposable
		{
			public GLContext(Device device)
			{
				_Device = device;
				Context = device.Context.CreateContext(IntPtr.Zero);

				// Make OpenGL context current
				if (_Device.Context.MakeCurrent(Context) == false)
					throw new InvalidOperationException("unable to make current the OpenGL context");
			}

			private readonly Device _Device;

			public readonly IntPtr Context;

			public void Dispose()
			{
				if (Context != IntPtr.Zero)
					_Device.Context.DeleteContext(Context);
			}
		}

		#endregion

		#region Version/Extension Support

		/// <summary>
		/// Check whether a specific OpenGL version is supported.
		/// </summary>
		protected bool HasVersion(KhronosVersion version)
		{
			Debug.Assert(version != null);

			if (Gl.CurrentVersion == null)
				return false;
			if (Gl.CurrentVersion.Api != version.Api)
				return false;

			return Gl.CurrentVersion >= version;
		}

		/// <summary>
		/// Check whether an OpenGL extension is supported by the OpenGL context.
		/// </summary>
		/// <param name="extension">
		/// A <see cref="String"/> that specifies the extension to test for support.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the extension identified with <paramref name="extension"/> is
		/// actually supported.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="extension"/> is null.
		/// </exception>
		protected bool HasExtension(string extension)
		{
			return Gl.CurrentExtensions != null && Gl.CurrentExtensions.HasExtensions(extension);
		}

#if !MONODROID

		/// <summary>
		/// Check whether an OpenGL for Windows extension is supported by the OpenGL context.
		/// </summary>
		/// <param name="extension">
		/// A <see cref="String"/> that specifies the extension to test for support.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the extension identified with <paramref name="extension"/> is
		/// actually supported.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="extension"/> is null.
		/// </exception>
		protected bool IsWglExtensionSupported(string extension)
		{
			return _WglExtensions.HasExtensions(extension);
		}

		/// <summary>
		/// Windows OpenGL extensions support.
		/// </summary>
		private readonly Wgl.Extensions _WglExtensions = new Wgl.Extensions();

		/// <summary>
		/// Check whether an OpenGL for X extension is supported by the OpenGL context.
		/// </summary>
		/// <param name="extension">
		/// A <see cref="String"/> that specifies the extension to test for support.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the extension identified with <paramref name="extension"/> is
		/// actually supported.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="extension"/> is null.
		/// </exception>
		protected bool IsGlxExtensionSupported(string extension)
		{
			return _GlxExtensions.HasExtensions(extension);
		}

		/// <summary>
		/// Windows OpenGL extensions support.
		/// </summary>
		private readonly Glx.Extensions _GlxExtensions = new Glx.Extensions();

#endif

		/// <summary>
		/// Windows OpenGL extensions support.
		/// </summary>
		private readonly Egl.Extensions _EglExtensions = new Egl.Extensions();

		#endregion
	}
}
