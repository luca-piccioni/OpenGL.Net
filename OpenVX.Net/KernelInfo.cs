
// MIT License
// 
// Copyright (c) 2017 Luca Piccioni
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

#pragma warning disable 169

using System.Runtime.InteropServices;

namespace OpenVX
{
	/// <summary>
	/// The Kernel Information Structure. This is returned by the Context to indicate which kernels
	/// are available in the OpenVX implementation.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct KernelInfo
	{
		/// <summary>
		/// The kernel enumeration value from <tt>\ref vx_kernel_e</tt> (or an extension thereof).
		/// </summary>
		public KernelType Enumeration;

		/// <summary>
		/// The kernel name in dotted hierarchical format (e.g. "org.khronos.openvx.sobel_3x3").
		/// </summary>
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string Name;
	}
}
