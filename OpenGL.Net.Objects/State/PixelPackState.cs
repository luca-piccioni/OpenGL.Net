
// Copyright (C) 2018 Luca Piccioni
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
using System.Diagnostics;

namespace OpenGL.Objects.State
{
	/// <summary>
	/// State for tracking pixel storage modes (unpack, i.e. from CPU to GPU).
	/// </summary>
	[DebuggerDisplay("PixelPackState: SwapBytes={SwapBytes} Alignment={Alignment}")]
	public class PixelPackState : GraphicsState
	{
		#region Information

		/// <summary>
		/// f true, byte ordering for multi-byte color components, depth components, or stencil indices is reversed. That is,
		/// if a four-byte component consists of bytes b0, b1, b2, b3, it is taken from memory as b3, b2, b1, b0 if GL_UNPACK_SWAP_BYTES
		/// is true. GL_UNPACK_SWAP_BYTES has no effect on the memory order of components within a pixel, only on the order of bytes
		/// within components or indices. For example, the three components of a GL_RGB format pixel are always stored with red first,
		/// green second, and blue third, regardless of the value of GL_UNPACK_SWAP_BYTES.
		/// </summary>
		public bool SwapBytes { get; set; } = false;

		/// <summary>
		/// Get or set the pixel unpack alignment (CPU to GPU).
		/// </summary>
		/// <remarks>
		/// The default value is 4.
		/// </remarks>
		public int Alignment { get; set; } = 4;

		#endregion

		#region Default State

		/// <summary>
		/// The system default state for PixelAlignmentState.
		/// </summary>
		public static PixelPackState DefaultState => new PixelPackState();

		#endregion

		#region Alignment

		/// <summary>
		/// Create a PixelPackState for setting pack alignment.
		/// </summary>
		/// <param name="stride">
		/// A <see cref="uint"/> that specifies the line stride, in bytes.
		/// </param>
		/// <returns>
		/// It returns a <see cref="PixelPackState"/> which properly set alignment for <paramref name="stride"/>.
		/// </returns>
		public static PixelPackState Align(uint stride)
		{
			return new PixelPackState() { Alignment = GetStrideAlignment(stride) };
		}

		/// <summary>
		/// Utility routine for getting the most appropriate pack alignment.
		/// </summary>
		/// <param name="stride">
		/// A <see cref="uint"/> that specifies the line stride, in bytes.
		/// </param>
		/// <returns>
		/// It returns the most appropriate alignment for <paramref name="stride."/>
		/// </returns>
		private static int GetStrideAlignment(uint stride)
		{
			foreach (int alignment in new[] { 8, 4, 2, 1 }) {
				if (stride % alignment == 0)
					return alignment;
			}

			return 1;
		}

		#endregion

		#region GraphicsState Overrides

		/// <summary>
		/// The identifier of the state.
		/// </summary>
		public static string StateId = "OpenGL.PixelPack";

		/// <summary>
		/// The identifier of this GraphicsState.
		/// </summary>
		public override string StateIdentifier => StateId;

		/// <summary>
		/// Unique index assigned to this GraphicsState.
		/// </summary>
		public static int StateSetIndex => _StateIndex;

		/// <summary>
		/// Unique index assigned to this GraphicsState.
		/// </summary>
		public override int StateIndex => _StateIndex;

		/// <summary>
		/// The index for this GraphicsState.
		/// </summary>
		private static readonly int _StateIndex = NextStateIndex();

		/// <summary>
		/// Apply this depth test render state.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> which has defined the shader program <paramref name="program"/>.
		/// </param>
		/// <param name="program">
		/// The <see cref="ShaderProgram"/> which has the state set.
		/// </param>
		public override void Apply(GraphicsContext ctx, ShaderProgram program)
		{
			if (ctx == null)
				throw new ArgumentNullException(nameof(ctx));

			PixelPackState currentState = (PixelPackState)ctx.GetCurrentState(StateIndex);

			if (currentState != null)
				ApplyStateCore(ctx, program, currentState);
			else
				ApplyStateCore(ctx, program);

			ctx.SetCurrentState(this);
		}

		private void ApplyStateCore(GraphicsContext ctx, ShaderProgram program)
		{
			Gl.PixelStore(PixelStoreParameter.PackSwapBytes, SwapBytes ? 1 : 0);
			Gl.PixelStore(PixelStoreParameter.PackAlignment, Alignment);
		}

		private void ApplyStateCore(GraphicsContext ctx, ShaderProgram program, PixelPackState currentState)
		{
			if (currentState.SwapBytes != SwapBytes)
				Gl.PixelStore(PixelStoreParameter.PackSwapBytes, SwapBytes ? 1 : 0);
			if (currentState.Alignment != Alignment)
				Gl.PixelStore(PixelStoreParameter.PackAlignment, Alignment);
		}

		/// <summary>
		/// Merge this state with another one.
		/// </summary>
		/// <param name="state">
		/// A <see cref="IGraphicsState"/> having the same <see cref="StateIdentifier"/> of this state.
		/// </param>
		public override void Merge(IGraphicsState state)
		{
			if (state == null)
				throw new ArgumentNullException(nameof(state));

			PixelPackState otherState = state as PixelPackState;

			if (otherState == null)
				throw new ArgumentException("not a PixelPackState", nameof(state));

			SwapBytes = otherState.SwapBytes;
			Alignment = otherState.Alignment;
		}

		/// <summary>
		/// Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		/// <param name="other">
		/// A <see cref="GraphicsState"/> to compare to this GraphicsState.
		/// </param>
		/// <returns>
		/// It returns true if the current object is equal to <paramref name="other"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// This method test only whether <paramref name="other"/> type equals to this type.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="other"/> is null.
		/// </exception>
		public override bool Equals(IGraphicsState other)
		{
			if (base.Equals(other) == false)
				return (false);
			Debug.Assert(other is PixelPackState);

			PixelPackState otherState = (PixelPackState)other;

			if (otherState.SwapBytes != SwapBytes)
				return false;
			if (otherState.Alignment != Alignment)
				return false;

			return true;
		}
		
		/// <summary>
		/// Represents the current <see cref="GraphicsState"/> for logging.
		/// </summary>
		/// <returns>
		/// A <see cref="String"/> that represents the current <see cref="GraphicsState"/>.
		/// </returns>
		public override string ToString()
		{
			return ($"{StateIdentifier}: SwapBytes={SwapBytes} Alignment={Alignment}");
		}

		#endregion
	}
}
