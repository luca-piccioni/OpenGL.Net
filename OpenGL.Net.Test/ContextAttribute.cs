
// Copyright (C) 2015 Luca Piccioni
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

namespace OpenGL.Test
{
	/// <summary>
	/// Determine the OpenGL context requirement for the test fixture.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	class ContextAttribute : Attribute
	{
		/// <summary>
		/// Type of context required by the test fixture.
		/// </summary>
		public enum ContextMode
		{
			/// <summary>
			/// No special context requirement.
			/// </summary>
			Any,
			/// <summary>
			/// Requires a core profile context.
			/// </summary>
			CoreProfile,
			/// <summary>
			/// Requires a compatibility profile context.
			/// </summary>
			CompatibilityProfile
		}

		/// <summary>
		/// Type of context required by the test fixture.
		/// </summary>
		public ContextMode ContextRequired = ContextMode.Any;
	}
}
