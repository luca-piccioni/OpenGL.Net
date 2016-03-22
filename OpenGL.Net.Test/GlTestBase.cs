
// Copyright (C) 2015 Luca Piccioni
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

using NUnit.Framework;

namespace OpenGL.Test
{
	/// <summary>
	/// Abstract base test creating an OpenGL context used for testing.
	/// </summary>
	[TestFixture]
	abstract class GlTestBase : TestBase
	{
		#region Setup & Tear Down

		/// <summary>
		/// Create a an OpenGL context, and get the OpenGL extensions supported.
		/// </summary>
		[TestFixtureSetUp]
		public new void FixtureSetUp()
		{
			try {
				// Create context
				_Context = CreateContext();

				// Make OpenGL context current
				if (_DeviceContext.MakeCurrent(_Context) == false)
					throw new InvalidOperationException("unable to make current the OpenGL context");

				// Get OpenGL version
				if ((_VersionString = Gl.GetString(StringName.Version)) == null)
					throw new InvalidOperationException("unable to get the OpenGL version");
				// Extract OpenGL version numbers
				_Version = KhronosVersion.Parse(_VersionString);
				// Get OpenGL extensions
				_GlExtensions.Query();
				// Get OpenGL window system extensions
				// Windows OpenGL extensions
				WindowsDeviceContext windowsDeviceContext = _DeviceContext as WindowsDeviceContext;
				if (windowsDeviceContext != null)
					_WglExtensions.Query(windowsDeviceContext);
				// GLX OpenGL extensions
				XServerDeviceContext xserverDeviceContext = _DeviceContext as XServerDeviceContext;
				if (xserverDeviceContext != null)
					_GlxExtensions.Query(xserverDeviceContext);
				// EGL OpenGL extensions
				NativeDeviceContext nativeDeviceContext = _DeviceContext as NativeDeviceContext;
				if (nativeDeviceContext != null)
					_EglExtensions.Query(nativeDeviceContext);
				
			} catch {
				// Release resources manually
				FixtureTearDown();

				throw;
			}
		}

		/// <summary>
		/// Synchronize thread-local delegates.
		/// </summary>
		[SetUp]
		public void SetUp()
		{
			// Make OpenGL context current
			if (_DeviceContext.MakeCurrent(_Context) == false)
				throw new InvalidOperationException("unable to make current the OpenGL context");
		}

		/// <summary>
		/// Release resources allocated by <see cref="FixtureSetUp"/>.
		/// </summary>
		[TestFixtureTearDown]
		public new void FixtureTearDown()
		{
			// Detroy context
			WindowsDeviceContext winDeviceContext = _DeviceContext as WindowsDeviceContext;
			if ((winDeviceContext != null) && (Wgl.DeleteContext(_Context) == false))
				throw new InvalidOperationException("unable to delete OpenGL context");
			_Context = IntPtr.Zero;
		}

		/// <summary>
		/// The OpenGL context for this tst fixture.
		/// </summary>
		protected IntPtr _Context;

		#endregion

		#region Context Creation

		private IntPtr CreateContext()
		{
			IntPtr context;

			ContextAttribute contextAttribute = (ContextAttribute)Attribute.GetCustomAttribute(GetType(), typeof(ContextAttribute));

			if (contextAttribute == null) {
				// Create compatibility profile context
				if ((context = _DeviceContext.CreateContext(IntPtr.Zero)) == IntPtr.Zero)
					throw new InvalidOperationException("unable to create compatibility profile OpenGL context");
			} else {
				List<int> contextAttribs = new List<int>();

				if ((context = _DeviceContext.CreateContextAttrib(IntPtr.Zero, contextAttribs.ToArray())) == IntPtr.Zero)
					throw new InvalidOperationException("unable to create core profile OpenGL context");
			}

			return (context);
		}

		#endregion

		#region Version/Extension Support

		/// <summary>
		/// Get the OpenGL version of the OpenGL context.
		/// </summary>
		protected string Version { get { return (_VersionString); } }

		/// <summary>
		/// Check whether a specific OpenGL version is supported.
		/// </summary>
		/// <param name="major">
		/// A <see cref="Int32"/> that specifies the major OpenGL version to test for support.
		/// </param>
		/// <param name="minor">
		/// A <see cref="Int32"/> that specifies the minor OpenGL version to test for support.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the specified OpenGL version is supported.
		/// </returns>
		protected bool HasVersion(int major, int minor)
		{
			return (HasVersion(major, minor, 0));
		}

		/// <summary>
		/// Check whether a specific OpenGL version is supported.
		/// </summary>
		/// <param name="major">
		/// A <see cref="Int32"/> that specifies the major OpenGL version to test for support.
		/// </param>
		/// <param name="minor">
		/// A <see cref="Int32"/> that specifies the minor OpenGL version to test for support.
		/// </param>
		/// <param name="revision">
		/// A <see cref="Int32"/> that specifies the revision OpenGL version to test for support.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the specified OpenGL version is supported.
		/// </returns>
		protected bool HasVersion(int major, int minor, int revision)
		{
			return (_Version.Api == KhronosVersion.ApiGl && _Version >= new KhronosVersion(major, minor, revision, KhronosVersion.ApiGl));
		}

		/// <summary>
		/// Check whether a specific OpenGL ES version is supported.
		/// </summary>
		/// <param name="major">
		/// A <see cref="Int32"/> that specifies the major OpenGL version to test for support.
		/// </param>
		/// <param name="minor">
		/// A <see cref="Int32"/> that specifies the minor OpenGL version to test for support.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the specified OpenGL version is supported.
		/// </returns>
		protected bool HasEsVersion(int major, int minor)
		{
			switch (_Version.Api) {
				case KhronosVersion.ApiGles1:
					return (_Version >= new KhronosVersion(major, minor, 0, KhronosVersion.ApiGles1));
				case KhronosVersion.ApiGles2:
					return (_Version >= new KhronosVersion(major, minor, 0, KhronosVersion.ApiGles2));
				default:
					return (false);
			}
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
		protected bool IsGlExtensionSupported(string extension)
		{
			return (_GlExtensions.HasExtensions(extension));
		}

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
			return (_WglExtensions.HasExtensions(extension));
		}

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
			return (_GlxExtensions.HasExtensions(extension));
		}

		/// <summary>
		/// The OpenGL version of the OpenGL context.
		/// </summary>
		private string _VersionString;

		/// <summary>
		/// The OpenGL version of the OpenGL context.
		/// </summary>
		private KhronosVersion _Version;

		/// <summary>
		/// OpenGL extensions support.
		/// </summary>
		private readonly Gl.Extensions _GlExtensions = new Gl.Extensions();

		/// <summary>
		/// Windows OpenGL extensions support.
		/// </summary>
		private readonly Wgl.Extensions _WglExtensions = new Wgl.Extensions();

		/// <summary>
		/// Windows OpenGL extensions support.
		/// </summary>
		private readonly Glx.Extensions _GlxExtensions = new Glx.Extensions();

		/// <summary>
		/// Windows OpenGL extensions support.
		/// </summary>
		private readonly Egl.Extensions _EglExtensions = new Egl.Extensions();

		#endregion
	}
}
