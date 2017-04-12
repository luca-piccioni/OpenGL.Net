
// Copyright (C) 2015-2017 Luca Piccioni
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

// Macro utility for enabling OpenGL function calls logging
#undef GL_LOG_ENABLED

using System;
using System.Reflection;

using NSubstitute;
using NUnit.Framework;

namespace OpenGL.Objects.Test
{
	/// <summary>
	/// Base test for OpenGL.Objects namespace.
	/// </summary>
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
			_DeviceContext = DeviceContext.Create();
			_Context = new GraphicsContext(_DeviceContext);
		}

		[SetUp()]
		public void SetUp()
		{
			if (_Context.IsCurrent == false)
				_Context.MakeCurrent(true);
		}

		/// <summary>
		/// Release resources allocated by <see cref="FixtureSetUp"/>.
		/// </summary>
		[TestFixtureTearDown]
		public void FixtureTearDown()
		{
			if (_Context != null) {
				_Context.Dispose();
				_Context = null;
			}

			if (_DeviceContext != null) {
				_DeviceContext.Dispose();
				_DeviceContext = null;
			}
		}

		/// <summary>
		/// Determine whether this test is testing OpenGL ES API.
		/// </summary>
		protected virtual bool IsEsTest
		{
			get { return (false); }
		}

		/// <summary>
		/// The device context.
		/// </summary>
		protected DeviceContext _DeviceContext;

		/// <summary>
		/// The graphics context.
		/// </summary>
		protected GraphicsContext _Context;

		#endregion
	}
}
