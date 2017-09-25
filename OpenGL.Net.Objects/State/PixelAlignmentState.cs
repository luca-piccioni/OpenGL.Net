
// Copyright (C) 2017 Luca Piccioni
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
	/// Depth test render state.
	/// </summary>
	[DebuggerDisplay("PixelAlignmentState: Pack={PackAlignment} Unpack={UnpackAlignment}")]
	public class PixelAlignmentState : GraphicsState
	{
		#region Constructors
		
		/// <summary>
		/// Construct a default PixelAlignmentState.
		/// </summary>
		public PixelAlignmentState()
		{
			
		}

		/// <summary>
		/// Construct a PixelAlignmentState specifying the pack/unpack alignments.
		/// </summary>
		/// <param name="packAlign"></param>
		/// <param name="unpackAlign"></param>
		public PixelAlignmentState(int packAlign, int unpackAlign)
		{
			if (packAlign != 1 && packAlign != 2 && packAlign != 4 && packAlign != 8)
				throw new ArgumentException("invalid value", "packAlign");
			if (unpackAlign != 1 && unpackAlign != 2 && unpackAlign != 4 && unpackAlign != 8)
				throw new ArgumentException("invalid value", "unpackAlign");

			PackAlignment = packAlign;
			UnpackAlignment = unpackAlign;
		}

		#endregion

		#region Information

		/// <summary>
		/// Get or set the pixel pack alignment (GPU to CPU).
		/// </summary>
		/// <remarks>
		/// The default value is 4.
		/// </remarks>
		public int PackAlignment
		{
			get { return (_PackAlignment); }
			set { _PackAlignment = value; }
		}

		/// <summary>
		/// Pixel pack alignment.
		/// </summary>
		private int _PackAlignment = 4;

		/// <summary>
		/// Get or set the pixel unpack alignment (CPU to GPU).
		/// </summary>
		/// <remarks>
		/// The default value is 4.
		/// </remarks>
		public int UnpackAlignment
		{
			get { return (_UnpackAlignment); }
			set { _UnpackAlignment = value; }
		}

		/// <summary>
		/// Pixel pack alignment.
		/// </summary>
		private int _UnpackAlignment = 4;
		
		#endregion

		#region Default State

		/// <summary>
		/// The system default state for PixelAlignmentState.
		/// </summary>
		public static PixelAlignmentState DefaultState { get { return (new PixelAlignmentState()); } }

		#endregion

		#region Pack/Unpack States

		public static PixelAlignmentState Pack(uint stride)
		{
			return (new PixelAlignmentState(GetStrideAlignment(stride), 4));
		}

		public static PixelAlignmentState Unpack(uint stride)
		{
			return (new PixelAlignmentState(4, GetStrideAlignment(stride)));
		}

		private static int GetStrideAlignment(uint stride)
		{
			foreach (int alignment in new int[] { 8, 4, 2, 1 }) {
				if (stride % alignment == 0)
					return (alignment);
			}

			return (1);
		}

		#endregion

		#region GraphicsState Overrides

		/// <summary>
		/// The identifier of the state.
		/// </summary>
		public static string StateId = "OpenGL.PixelAlignment";

		/// <summary>
		/// The identifier of this GraphicsState.
		/// </summary>
		public override string StateIdentifier { get { return (StateId); } }

		/// <summary>
		/// Unique index assigned to this GraphicsState.
		/// </summary>
		public static int StateSetIndex { get { return (_StateIndex); } }

		/// <summary>
		/// Unique index assigned to this GraphicsState.
		/// </summary>
		public override int StateIndex { get { return (_StateIndex); } }

		/// <summary>
		/// The index for this GraphicsState.
		/// </summary>
		private static int _StateIndex = NextStateIndex();

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
				throw new ArgumentNullException("ctx");

			PixelAlignmentState currentState = (PixelAlignmentState)ctx.GetCurrentState(StateIndex);

			if (currentState != null)
				ApplyStateCore(ctx, program, currentState);
			else
				ApplyStateCore(ctx, program);

			ctx.SetCurrentState(this);
		}

		private void ApplyStateCore(GraphicsContext ctx, ShaderProgram program)
		{
			Gl.PixelStore(PixelStoreParameter.PackAlignment, PackAlignment);
			Gl.PixelStore(PixelStoreParameter.UnpackAlignment, UnpackAlignment);
		}

		private void ApplyStateCore(GraphicsContext ctx, ShaderProgram program, PixelAlignmentState currentState)
		{
			if (currentState.PackAlignment != PackAlignment)
				Gl.PixelStore(PixelStoreParameter.PackAlignment, PackAlignment);
			if (currentState.UnpackAlignment != UnpackAlignment)
				Gl.PixelStore(PixelStoreParameter.UnpackAlignment, UnpackAlignment);
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
				throw new ArgumentNullException("state");

			PixelAlignmentState otherState = state as PixelAlignmentState;

			if (otherState == null)
				throw new ArgumentException("not a PixelAlignmentState", "state");

			PackAlignment = otherState.PackAlignment;
			UnpackAlignment = otherState.UnpackAlignment;
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
			Debug.Assert(other is PixelAlignmentState);

			PixelAlignmentState otherState = (PixelAlignmentState)other;

			if (otherState.PackAlignment != PackAlignment)
				return (false);
			if (otherState.UnpackAlignment != UnpackAlignment)
				return (false);

			return (true);
		}
		
		/// <summary>
		/// Represents the current <see cref="GraphicsState"/> for logging.
		/// </summary>
		/// <returns>
		/// A <see cref="String"/> that represents the current <see cref="GraphicsState"/>.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("{0}: PackAlign={1} UnpackAlign", StateIdentifier, PackAlignment, UnpackAlignment));
		}

		#endregion
	}
}
