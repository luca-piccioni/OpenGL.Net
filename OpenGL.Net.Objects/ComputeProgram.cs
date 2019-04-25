
// Copyright (C) 2019 Luca Piccioni
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
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace OpenGL.Objects
{
	/// <summary>
	/// Compute program.
	/// </summary>
	[DebuggerDisplay("ComputeProgram: Name={ObjectName} Id={Identifier} Linked={IsLinked}")]
	public class ComputeProgram : ShaderProgram
	{
		#region Constructors

		/// <summary>
		/// Construct a ComputeProgram.
		/// </summary>
		/// <param name="programName">
		/// A <see cref="String"/> that specify the shader program name.
		/// </param>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if the parameter <paramref name="programName"/> is not a valid name.
		/// </exception>
		public ComputeProgram(string programName) : base(programName)
		{
			
		}

		#endregion

		#region Compute

		/// <summary>
		/// Dispatch the compute shader.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> on which the compute is dispatched.
		/// </param>
		/// <param name="x">
		/// The number of work groups to be launched in the X dimension.
		/// </param>
		/// <param name="y">
		/// The number of work groups to be launched in the Y dimension.
		/// </param>
		/// <param name="z">
		/// The number of work groups to be launched in the Z dimension.
		/// </param>
		public void Compute(GraphicsContext ctx, uint x, uint y = 1, uint z = 1)
		{
			CheckCurrentContext(ctx);
			CheckThisExistence(ctx);

			// Ensure program bound
			ctx.Bind(this);
			// Ensure linked I/O
			BindImages(ctx);
			// Dispatch
			Gl.DispatchCompute(x, y, z);
		}

		#endregion
	}
}
