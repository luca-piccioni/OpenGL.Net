
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

using System.Collections.Generic;

using NUnit.Framework;

using Khronos;

namespace OpenGL.Test
{
	/// <summary>
	/// Class for testing WGL_ARB_pixel_format API.
	/// </summary>
	class WGL_ARB_pixel_format : TestBaseGL
	{
		/// <summary>
		/// Test Wgl.GetPixelFormatAttribARB.
		/// </summary>
		[Test, RequiredByFeature("WGL_ARB_pixel_format")]
		public void TestGetPixelFormatAttribARB()
		{
			if (IsWglExtensionSupported("WGL_ARB_pixel_format") == false)
				Assert.Inconclusive("OpenGL extension WGL_ARB_pixel_format not supported");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				DeviceContextWGL winDeviceContext = (DeviceContextWGL)device.Context;

				#region List the attributes to query

				List<int> pfAttributesCodes = new List<int>();

				// Minimum requirements
				pfAttributesCodes.Add(Wgl.SUPPORT_OPENGL_ARB); // Required to be Gl.TRUE
				pfAttributesCodes.Add(Wgl.ACCELERATION_ARB); // Required to be Wgl.FULL_ACCELERATION or Wgl.ACCELERATION_ARB
				pfAttributesCodes.Add(Wgl.PIXEL_TYPE_ARB);
				// Buffer destination
				pfAttributesCodes.Add(Wgl.DRAW_TO_WINDOW_ARB);
				pfAttributesCodes.Add(Wgl.DRAW_TO_BITMAP_ARB);
				pfAttributesCodes.Add(Wgl.DRAW_TO_PBUFFER_ARB);
				// Multiple buffers
				pfAttributesCodes.Add(Wgl.DOUBLE_BUFFER_ARB);
				pfAttributesCodes.Add(Wgl.SWAP_METHOD_ARB);
				pfAttributesCodes.Add(Wgl.STEREO_ARB);
				// Pixel description
				pfAttributesCodes.Add(Wgl.COLOR_BITS_ARB);
				pfAttributesCodes.Add(Wgl.DEPTH_BITS_ARB);
				pfAttributesCodes.Add(Wgl.STENCIL_BITS_ARB);
				// Multisample extension
				if (HasExtension("GL_ARB_multisample") || HasExtension("WGL_ARB_multisample") || HasExtension("GLX_ARB_multisample"))
				{
					pfAttributesCodes.Add(Wgl.SAMPLE_BUFFERS_ARB);
					pfAttributesCodes.Add(Wgl.SAMPLES_ARB);
				}

				#endregion

				#region Query Attributes

				int[] pfAttributesValue = new int[pfAttributesCodes.Count];
				int formatIndex = 1;

				while (Wgl.GetPixelFormatAttribARB(winDeviceContext.DeviceContext, formatIndex++, 0, (uint) pfAttributesCodes.Count,
					pfAttributesCodes.ToArray(), pfAttributesValue))
				{

				}

				#endregion
			}
		}
	}
}
