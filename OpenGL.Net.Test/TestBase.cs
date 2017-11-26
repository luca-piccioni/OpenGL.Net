
// Copyright (C) 2015-2017 Luca Piccioni
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
using System.Collections.Generic;
using System.Threading;

using NUnit.Framework;

namespace OpenGL.Test
{
	/// <summary>
	/// Abstract base test creating a device context used for testing.
	/// </summary>
	[TestFixture]
#if !NETCORE
	[Apartment(ApartmentState.STA)]
#endif
	abstract class TestBase
	{
		#region Setup & Tear Down

		/// <summary>
		/// Create a window, create the device context and set a basic pixel format.
		/// </summary>
		[OneTimeSetUp]
		public void FixtureSetUp()
		{
			try {
				// Support ES tests
				Egl.IsRequired = IsEsTest;

				// Create device context
				_DeviceContext = DeviceContext.Create();
				List<DevicePixelFormat> pixelFormats = _DeviceContext.PixelsFormats.Choose(new DevicePixelFormat(24));

				if (pixelFormats.Count == 0)
					throw new NotSupportedException("unable to find suitable pixel format");
			} catch (Exception exception) {
				Console.WriteLine("Unable to initialize base Fixture: " + exception.ToString());

				// Release resources manually
				FixtureTearDown();
				throw;
			}
		}

		/// <summary>
		/// Release resources allocated by <see cref="FixtureSetUp"/>.
		/// </summary>
		[OneTimeTearDown]
		public void FixtureTearDown()
		{
			// Dispose device context
			if (_DeviceContext != null)
				_DeviceContext.Dispose();
			_DeviceContext = null;
		}

		/// <summary>
		/// The device context.
		/// </summary>
		protected DeviceContext _DeviceContext;

		#endregion

		#region ES Testing

		/// <summary>
		/// Determine whether this test is testing OpenGL ES API.
		/// </summary>
		protected virtual bool IsEsTest
		{
			get { return (false); }
		}

		#endregion
	}
}
