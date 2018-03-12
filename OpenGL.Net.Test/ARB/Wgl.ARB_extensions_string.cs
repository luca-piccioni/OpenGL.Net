
// Copyright (C) 2015-2018 Luca Piccioni
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
using System.Text.RegularExpressions;

using NUnit.Framework;

using Khronos;

namespace OpenGL.Test
{
	/// <summary>
	/// Class for testing WGL_ARB_extensions_string API.
	/// </summary>
	class WGL_ARB_extensions_string : TestBaseGL
	{
		/// <summary>
		/// Test Wgl.GetExtensionsStringARB
		/// </summary>
		[Test, RequiredByFeature("WGL_ARB_extensions_string")]
		public void TestGetExtensionsStringARB()
		{
			if (Wgl.HasGetExtensionsStringARB == false)
				Assert.Inconclusive("WGL_ARB_extensions_string not supported");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				DeviceContextWGL winDeviceContext = (DeviceContextWGL)device.Context;

				string extensions = Wgl.GetExtensionsStringARB(winDeviceContext.DeviceContext);

				Assert.IsNotNull(extensions);

				// No exposed extensions? No more assertion
				if (extensions == string.Empty)
					return;

				string[] extensionIds = Regex.Split(extensions, " ");

				// Filter empty IDs
				extensionIds = Array.FindAll(extensionIds, item => item.Trim().Length > 0);

				Console.WriteLine("Found {0} WGL extensions:", extensionIds.Length);
				foreach (string extensionId in extensionIds)
					Console.WriteLine("- {0}", extensionId);

				// Assert.IsTrue(Regex.IsMatch(extensions, @"(WGL_(\w+)( +)?)+"));
			}
		}
	}
}
