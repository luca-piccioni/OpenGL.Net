
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
using System.Runtime.InteropServices;
using System.Windows.Forms;

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
				// Create window
				Form = new TestForm(this);
				// Create device context
				_DeviceContext = DeviceContextFactory.Create(Form);

				// Set pixel format
				if      (_DeviceContext is WindowsDeviceContext)
					SetPixelFormatWgl();
				else if (_DeviceContext is NativeDeviceContext)
					SetPixelFormatEgl();
				else
					throw new NotImplementedException("platform not supported");
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
		/// Set the pixel format on Windows platform.
		/// </summary>
		private void SetPixelFormatWgl()
		{
			WindowsDeviceContext winDeviceContext = (WindowsDeviceContext)_DeviceContext;

			// Define most compatible pixel format
			Wgl.PIXELFORMATDESCRIPTOR pfd = new Wgl.PIXELFORMATDESCRIPTOR(24);
			int pFormat;

			// Find pixel format match
			pFormat = Wgl.ChoosePixelFormat(winDeviceContext.DeviceContext, ref pfd);
			// Get exact description of the pixel format
			Wgl.DescribePixelFormat(winDeviceContext.DeviceContext, pFormat, (uint)pfd.nSize, ref pfd);
			// Set pixel format before creating OpenGL context
			Wgl.SetPixelFormat(winDeviceContext.DeviceContext, pFormat, ref pfd);
		}

		/// <summary>
		/// Set the pixel format on EGL platform.
		/// </summary>
		private void SetPixelFormatEgl()
		{
			NativeDeviceContext eglDeviceContext = (NativeDeviceContext)_DeviceContext;

			// Require the pixel formats
			DevicePixelFormatCollection pixelFormats = eglDeviceContext.PixelsFormats;

			eglDeviceContext.SetPixelFormat(pixelFormats[0]);
		}

		/// <summary>
		/// Form used for unit testing.
		/// </summary>
		protected TestForm Form;

		/// <summary>
		/// The device context.
		/// </summary>
		protected IDeviceContext _DeviceContext;

		#endregion

		#region Test Form

		/// <summary>
		/// Form used for unit testing. 
		/// </summary>
		protected class TestForm : Form
		{
			/// <summary>
			/// RenderForm constructor. 
			/// </summary>
			public TestForm(TestBase unitTest)
			{
				if (unitTest == null)
					throw new ArgumentNullException("unitTest");

				mUnitTest = unitTest;

				// No need to erase window background
				SetStyle(ControlStyles.AllPaintingInWmPaint, true);
				// No need to draw window background
				SetStyle(ControlStyles.Opaque, true);
				// Buffer control
				SetStyle(ControlStyles.DoubleBuffer, false);
				// Redraw window on resize
				SetStyle(ControlStyles.ResizeRedraw, true);
				// Painting handled by user
				SetStyle(ControlStyles.UserPaint, true);
			}

			/// <summary>
			/// The unit test that has created this TestForm.
			/// </summary>
			private readonly TestBase mUnitTest;
		}

		#endregion
	}
}
