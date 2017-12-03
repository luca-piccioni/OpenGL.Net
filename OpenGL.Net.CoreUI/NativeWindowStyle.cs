
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

using System;

namespace OpenGL.CoreUI
{
	/// <summary>
	/// Styles associated to a <see cref="NativeWindow"/>.
	/// </summary>
	[Flags]
	public enum NativeWindowStyle
	{
		/// <summary>
		/// No window style.
		/// </summary>
		None =			0x0000,

		/// <summary>
		/// Window caption is visible. Caption imply <see cref="Border"/>.
		/// </summary>
		Caption =		0x0001 | Border,

		/// <summary>
		/// Window borders are visible. Without border, <see cref="Caption"/> is disabled.
		/// </summary>
		Border =		0x0002,

		/// <summary>
		/// Window can be resized using borders. Resizeable imply <see cref="Border"/>.
		/// </summary>
		Resizeable =	0x0004 | Border,

		/// <summary>
		/// Overlapped window (shortcut).
		/// </summary>
		Overlapped = Caption | Border | Resizeable,
	}
}
