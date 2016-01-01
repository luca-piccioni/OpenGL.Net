
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

namespace OpenGL.Hal.Test.Shaders
{
	/// <summary>
	/// Base class for testing shader programs.
	/// </summary>
	class ShaderTestBase : TestBase
	{
		#region Setup & Tear Down

		/// <summary>
		/// Create a window, create the device context and set a basic pixel format.
		/// </summary>
		[TestFixtureSetUp]
		public new void FixtureSetUp()
		{
			try {
				// Required to be current
				_Context.MakeCurrent(true);

				// Create window on which tests are run
				_Framebuffer = new Framebuffer();
				_Framebuffer.AttachColor(new RenderBuffer(RenderBuffer.Type.Color, PixelLayout.GRAY8, 16, 16));
				_Framebuffer.Create(_Context);
			} catch {
				// Release resources manually
				FixtureTearDown();
				throw;
			}
		}

		[SetUp()]
		public new void SetUp()
		{
			_Framebuffer.BindDraw(_Context);
		}

		/// <summary>
		/// Release resources allocated by <see cref="FixtureSetUp"/>.
		/// </summary>
		[TestFixtureTearDown]
		public new void FixtureTearDown()
		{
			if (_Framebuffer != null) {
				_Framebuffer.Dispose(_Context);
				_Framebuffer = null;
			}
		}

		/// <summary>
		/// The device context.
		/// </summary>
		protected Framebuffer _Framebuffer;

		#endregion
	}
}
