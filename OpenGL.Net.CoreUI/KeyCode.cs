
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

namespace OpenGL.CoreUI
{
	/// <summary>
	/// Keyboard key code.
	/// </summary>
	public enum KeyCode
	{
		/// <summary></summary>
		Tab = 0x09,
		/// <summary></summary>
		Clear = 0x0C,
		/// <summary></summary>
		Return = 0x0D,
		/// <summary></summary>
		Shift = 0x10,
		/// <summary></summary>
		Control = 0x11,
		/// <summary></summary>
		Menu = 0x12,
		/// <summary></summary>
		Pause = 0x13,
		/// <summary></summary>
		CapsLock = 0x14,
		/// <summary></summary>
		Escape = 0x1B,
		/// <summary></summary>
		Space = 0x20,
		/// <summary></summary>
		Prior = 0x21,
		/// <summary></summary>
		Next = 0x22,
		/// <summary></summary>
		End = 0x23,
		/// <summary></summary>
		Home = 0x24,
		/// <summary></summary>
		Left = 0x25,
		/// <summary></summary>
		Up = 0x26,
		/// <summary></summary>
		Right = 0x27,
		/// <summary></summary>
		Down = 0x28,
		/// <summary></summary>
		Select = 0x29,
		/// <summary></summary>
		Print = 0x2A,
		/// <summary></summary>
		Execute = 0x2B,
		/// <summary></summary>
		Snapshot = 0x2C,
		/// <summary></summary>
		Insert = 0x2D,
		/// <summary></summary>
		Delete = 0x2E,
		/// <summary></summary>
		N0 = 0x30,
		/// <summary></summary>
		N1 = 0x31,
		/// <summary></summary>
		N2 = 0x32,
		/// <summary></summary>
		N3 = 0x33,
		/// <summary></summary>
		N4 = 0x34,
		/// <summary></summary>
		N5 = 0x35,
		/// <summary></summary>
		N6 = 0x36,
		/// <summary></summary>
		N7 = 0x37,
		/// <summary></summary>
		N8 = 0x38,
		/// <summary></summary>
		N9 = 0x39,
		/// <summary></summary>
		A = 0x41,
		/// <summary></summary>
		B = 0x42,
		/// <summary></summary>
		C = 0x43,
		/// <summary></summary>
		D = 0x44,
		/// <summary></summary>
		E = 0x45,
		/// <summary></summary>
		F = 0x46,
		/// <summary></summary>
		G = 0x47,
		/// <summary></summary>
		H = 0x48,
		/// <summary></summary>
		I = 0x49,
		/// <summary></summary>
		J = 0x4A,
		/// <summary></summary>
		K = 0x4B,
		/// <summary></summary>
		L = 0x4C,
		/// <summary></summary>
		M = 0x4D,
		/// <summary></summary>
		N = 0x4E,
		/// <summary></summary>
		O = 0x4F,
		/// <summary></summary>
		P = 0x50,
		/// <summary></summary>
		Q = 0x51,
		/// <summary></summary>
		R = 0x52,
		/// <summary></summary>
		S = 0x53,
		/// <summary></summary>
		T = 0x54,
		/// <summary></summary>
		U = 0x55,
		/// <summary></summary>
		V = 0x56,
		/// <summary></summary>
		W = 0x57,
		/// <summary></summary>
		X = 0x58,
		/// <summary></summary>
		Y = 0x59,
		/// <summary></summary>
		Z = 0x5A,
		/// <summary></summary>
		LeftWindows = 0x5B,
		/// <summary></summary>
		RightWindows = 0x5C,
		/// <summary></summary>
		Application = 0x5D,
		/// <summary></summary>
		Numpad0 = 0x60,
		/// <summary></summary>
		Numpad1 = 0x61,
		/// <summary></summary>
		Numpad2 = 0x62,
		/// <summary></summary>
		Numpad3 = 0x63,
		/// <summary></summary>
		Numpad4 = 0x64,
		/// <summary></summary>
		Numpad5 = 0x65,
		/// <summary></summary>
		Numpad6 = 0x66,
		/// <summary></summary>
		Numpad7 = 0x67,
		/// <summary></summary>
		Numpad8 = 0x68,
		/// <summary></summary>
		Numpad9 = 0x69,
		/// <summary></summary>
		Multiply = 0x6A,
		/// <summary></summary>
		Add = 0x6B,
		/// <summary></summary>
		Separator = 0x6C,
		/// <summary></summary>
		Subtract = 0x6D,
		/// <summary></summary>
		Decimal = 0x6E,
		/// <summary></summary>
		Divide = 0x6F,
		/// <summary></summary>
		F1 = 0x70,
		/// <summary></summary>
		F2 = 0x71,
		/// <summary></summary>
		F3 = 0x72,
		/// <summary></summary>
		F4 = 0x73,
		/// <summary></summary>
		F5 = 0x74,
		/// <summary></summary>
		F6 = 0x75,
		/// <summary></summary>
		F7 = 0x76,
		/// <summary></summary>
		F8 = 0x77,
		/// <summary></summary>
		F9 = 0x78,
		/// <summary></summary>
		F10 = 0x79,
		/// <summary></summary>
		F11 = 0x7A,
		/// <summary></summary>
		F12 = 0x7B,
		/// <summary></summary>
		F13 = 0x7C,
		/// <summary></summary>
		F14 = 0x7D,
		/// <summary></summary>
		F15 = 0x7E,
		/// <summary></summary>
		F16 = 0x7F,
		/// <summary></summary>
		F17 = 0x80,
		/// <summary></summary>
		F18 = 0x81,
		/// <summary></summary>
		F19 = 0x82,
		/// <summary></summary>
		F20 = 0x83,
		/// <summary></summary>
		F21 = 0x84,
		/// <summary></summary>
		F22 = 0x85,
		/// <summary></summary>
		F23 = 0x86,
		/// <summary></summary>
		F24 = 0x87,
		/// <summary></summary>
		NumLock = 0x90,
		/// <summary></summary>
		ScrollLock = 0x91,

		/// <summary>
		/// Internal use: maximum number of keys recognized.
		/// </summary>
		MaxKeycode,
	}
}
