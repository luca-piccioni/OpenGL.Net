
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
				mDeviceContext = DeviceContextFactory.Create(Form);
				// Set pixel format
				SetPixelFormatWgl();
				// Synch delegates
				SetUp();
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
			Gl.SyncDelegates();
			Wgl.SyncDelegates();
			Glx.SyncDelegates();
		}

		/// <summary>
		/// Release resources allocated by <see cref="FixtureSetUp"/>.
		/// </summary>
		[TestFixtureTearDown]
		public void FixtureTearDown()
		{
			// Dispose device context
			if (mDeviceContext != null)
				mDeviceContext.Dispose();
			mDeviceContext = null;
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
			WindowsDeviceContext winDeviceContext = (WindowsDeviceContext)mDeviceContext;

			// Define most compatible pixel format
			Wgl.PIXELFORMATDESCRIPTOR pfd;
			int pFormat;

			// Describe the pixel format fundamentals
			pfd.nVersion = 1; pfd.nSize = (short)Marshal.SizeOf(typeof(Wgl.PIXELFORMATDESCRIPTOR));
			pfd.iLayerType = Wgl.PFD_MAIN_PLANE;
			pfd.dwFlags = (Wgl.PFD_SUPPORT_OPENGL|Wgl.PFD_DOUBLEBUFFER|Wgl.PFD_DRAW_TO_WINDOW);
			pfd.iPixelType = Wgl.PFD_TYPE_RGBA;
			pfd.dwLayerMask = 0; pfd.dwVisibleMask = 0; pfd.dwDamageMask = 0;
			pfd.cAuxBuffers = 0;
			pfd.bReserved = 0;
			pfd.cColorBits = 32;
			pfd.cRedBits = 0; pfd.cRedShift = 0;
			pfd.cGreenBits = 0; pfd.cGreenShift = 0;
			pfd.cBlueBits = 0; pfd.cBlueShift = 0;
			pfd.cAlphaBits = 0; pfd.cAlphaShift = 0;
			pfd.cDepthBits = 0;
			pfd.cStencilBits = 0;
			pfd.cAccumBits = 0;
			pfd.cAccumRedBits = 0; pfd.cAccumGreenBits = 0; pfd.cAccumBlueBits = 0; pfd.cAccumAlphaBits = 0;

			// Find pixel format match
			if ((pFormat = Wgl.GdiChoosePixelFormat(winDeviceContext.DeviceContext, out pfd)) == 0)
				throw new NotSupportedException("unable to choose basic pixel format, error code " + Marshal.GetLastWin32Error());

			if (pfd.cColorBits == 0)
				throw new InvalidOperationException("unable to select valid pixel format");
			// Set pixel format before creating OpenGL context
            if (Wgl.GdiSetPixelFormat(winDeviceContext.DeviceContext, pFormat, out pfd) == false)
				throw new InvalidOperationException("unable to set valid pixel format");
		}

		/// <summary>
		/// Form used for unit testing.
		/// </summary>
		protected TestForm Form;

		/// <summary>
		/// The device context.
		/// </summary>
		protected IDeviceContext mDeviceContext;

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
