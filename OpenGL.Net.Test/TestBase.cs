
// Copyright (C) 2015-2016 Luca Piccioni
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
	/// Abstract base test creating a device context used for testing.
	/// </summary>
	[TestFixture, RequiresSTA]
	abstract class TestBase
	{
		#region Setup & Tear Down

		/// <summary>
		/// Create a window, create the device context and set a basic pixel format.
		/// </summary>
		[TestFixtureSetUp]
		public void FixtureSetUp()
		{
			try {
				// Support ES tests
				Egl.IsRequired = IsEsTest;

				// Create window
				Form = DeviceContext.CreateHiddenWindow();
				// Create device context
				_DeviceContext = DeviceContext.Create(Form.Display, Form.Handle);
				List<DevicePixelFormat> pixelFormats = _DeviceContext.PixelsFormats.Choose(new DevicePixelFormat(24));

				if (pixelFormats.Count == 0)
					throw new NotSupportedException("unable to find suitable pixel format");
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
		public void FixtureTearDown()
		{
			// Dispose device context
			if (_DeviceContext != null)
				_DeviceContext.Dispose();
			_DeviceContext = null;
			// Dispose window
			if (Form != null)
				Form.Dispose();
			Form = null;
		}

		/// <summary>
		/// Determine whether this test is testing OpenGL ES API.
		/// </summary>
		protected virtual bool IsEsTest
		{
			get { return (false); }
		}

		/// <summary>
		/// Form used for unit testing.
		/// </summary>
		protected INativeWindow Form;

		/// <summary>
		/// The device context.
		/// </summary>
		protected DeviceContext _DeviceContext;

		#endregion
	}
}
