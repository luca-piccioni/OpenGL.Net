
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
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
				mContext = CreateContext();

				// Make OpenGL context current
				if (Gl.MakeContextCurrent(_DeviceContext, mContext) == false)
					throw new InvalidOperationException("unable to make current the OpenGL context");

				// Get OpenGL version
				if ((_Version = Gl.GetString(StringName.Version)) == null)
					throw new InvalidOperationException("unable to get the OpenGL version");
				
				// Extract OpenGL version numbers
				Match versionMatch;

				if ((versionMatch = Regex.Match(_Version, @"(?<Major>\d+)\.(?<Minor>\d+)(\.(?<Rev>\d+))?(.*)?")).Success == false)
					throw new InvalidOperationException("unable to parse the OpenGL version");
				_VersionMajor = Int32.Parse(versionMatch.Groups["Major"].Value);
				_VersionMinor = Int32.Parse(versionMatch.Groups["Minor"].Value);
				_VersionRevision = versionMatch.Groups["Rev"].Success ? Int32.Parse(versionMatch.Groups["Rev"].Value) : 0;

				// Get OpenGL extensions
				_GlExtensions.Query();
				// Get OpenGL window system extensions
				switch (Environment.OSVersion.Platform) {
					case PlatformID.Win32Windows:
					case PlatformID.Win32NT:
						_WglExtensions.Query((WindowsDeviceContext)_DeviceContext);
						break;
					case PlatformID.Unix:
						_GlxExtensions.Query((XServerDeviceContext)_DeviceContext);
						break;
				}
				
			} catch {
				// Release resources manually
				FixtureTearDown();

				throw;
			}
		}

		/// <summary>
		/// Release resources allocated by <see cref="FixtureSetUp"/>.
		/// </summary>
		[TestFixtureTearDown]
		public new void FixtureTearDown()
		{
			// Detroy context
			WindowsDeviceContext winDeviceContext = _DeviceContext as WindowsDeviceContext;
			if ((winDeviceContext != null) && (Wgl.DeleteContext(mContext) == false))
				throw new InvalidOperationException("unable to delete OpenGL context");
			mContext = IntPtr.Zero;
		}

		/// <summary>
		/// The OpenGL context for this tst fixture.
		/// </summary>
		protected IntPtr mContext;

		#endregion

		#region Context Creation

		private IntPtr CreateContext()
		{
			IntPtr context;

			ContextAttribute contextAttribute = (ContextAttribute)Attribute.GetCustomAttribute(GetType(), typeof(ContextAttribute));

			if (contextAttribute == null) {
				// Create compatibility profile context
				if ((context = Gl.CreateContext(_DeviceContext)) == IntPtr.Zero)
					throw new InvalidOperationException("unable to create compatibility profile OpenGL context");
			} else {
				List<int> contextAttribs = new List<int>();

				if ((context = Gl.CreateContextAttrib(_DeviceContext, IntPtr.Zero, contextAttribs.ToArray())) == IntPtr.Zero)
					throw new InvalidOperationException("unable to create core profile OpenGL context");
			}

			return (context);
		}

		#endregion

		#region Version/Extension Support

		/// <summary>
		/// Get the OpenGL version of the OpenGL context.
		/// </summary>
		protected string Version { get { return (_Version); } }

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
			if (_VersionMajor > major)
				return (true);
			if ((_VersionMajor == major) && (_VersionMinor > minor))
				return (true);
			if ((_VersionMajor == major) && (_VersionMinor > minor) && (_VersionRevision >= revision))
				return (true);

			return (false);
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
		private string _Version;

		/// <summary>
		/// The OpenGL version of the OpenGL context: major number.
		/// </summary>
		private int _VersionMajor;

		/// <summary>
		/// The OpenGL version of the OpenGL context: minor number.
		/// </summary>
		private int _VersionMinor;

		/// <summary>
		/// The OpenGL version of the OpenGL context: revision number.
		/// </summary>
		private int _VersionRevision;

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

		#endregion
	}
}
