
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

using NUnit.Framework;

namespace OpenGL.Hal.Test
{
	[TestFixture, RequiresSTA]
	public class TestBase
	{
		#region Setup & Tear Down

		/// <summary>
		/// Create a window, create the device context and set a basic pixel format.
		/// </summary>
		[TestFixtureSetUp]
		public void FixtureSetUp()
		{
			try {
				// Create window on which tests are run
				_Window = new GraphicsWindow(800, 600);
				_Window.Create(new GraphicsBuffersFormat(PixelLayout.RGB24));
				// Create graphics context
				_Context = new GraphicsContext(_Window.GetDeviceContext());
				// Show window
				_Window.ShowWindow();
				_Window.Clear(_Context);
			} catch {
				// Release resources manually
				FixtureTearDown();
				throw;
			}
		}

		[SetUp()]
		public void SetUp()
		{
			_Context.MakeCurrent(true);
        }

		/// <summary>
		/// Release resources allocated by <see cref="FixtureSetUp"/>.
		/// </summary>
		[TestFixtureTearDown]
		public void FixtureTearDown()
		{
			// Dispose graphics context
			if (_Context != null) {
				_Context.Dispose();
				_Context = null;
			}
			// Dispose graphics window
			if (_Window != null) {
				_Window.Dispose();
				_Window = null;
			}
		}

		/// <summary>
		/// The device context.
		/// </summary>
		protected GraphicsWindow _Window;

		/// <summary>
		/// The graphics context.
		/// </summary>
		protected GraphicsContext _Context;

		#endregion
	}
}
