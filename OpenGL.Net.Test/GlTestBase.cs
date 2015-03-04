
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
				WindowsDeviceContext winDeviceContext = mDeviceContext as WindowsDeviceContext;
				if ((winDeviceContext != null) && (mContext = Wgl.CreateContext(winDeviceContext.DeviceContext)) == IntPtr.Zero)
					throw new InvalidOperationException("unable to create the OpenGL context");

				// Make OpenGL context current
				if (Gl.MakeContextCurrent(mDeviceContext, mContext) == false)
					throw new InvalidOperationException("unable to make current the OpenGL context");

				// Get OpenGL version
				if ((mVersion = Gl.GetString(StringName.Version)) == null)
					throw new InvalidOperationException("unable to get the OpenGL version");

				// Get OpenGL extensions
				string extensionList = Gl.GetString(StringName.Extensions);

				if (extensionList == null)
					throw new InvalidOperationException("unable to get the OpenGL extensions");

				mSupportedExtensions = new Dictionary<string, bool>();
				foreach (string extension in Regex.Split(extensionList, " "))
					mSupportedExtensions.Add(extension, true);
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
			WindowsDeviceContext winDeviceContext = mDeviceContext as WindowsDeviceContext;
			if ((winDeviceContext != null) && (Wgl.DeleteContext(mContext) == false))
				throw new InvalidOperationException("unable to delete OpenGL context");
			mContext = IntPtr.Zero;
		}

		/// <summary>
		/// The OpenGL context for this tst fixture.
		/// </summary>
		protected IntPtr mContext;

		#endregion

		#region Extension Support

		/// <summary>
		/// Get the OpenGL version of the OpenGL context.
		/// </summary>
		protected string Version { get { return (mVersion); } }

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
		protected bool IsExtensionSupported(string extension)
		{
			if (extension == null)
				throw new ArgumentNullException("extension");

			bool support;

			if (mSupportedExtensions.TryGetValue(extension, out support))
				return (support);

			return (false);
		}

		/// <summary>
		/// The OpenGL version of the OpenGL context.
		/// </summary>
		private string mVersion;

		/// <summary>
		/// 
		/// </summary>
		private Dictionary<string, bool> mSupportedExtensions;

		#endregion
	}
}
