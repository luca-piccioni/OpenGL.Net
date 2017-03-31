
// Copyright (C) 2017 Luca Piccioni
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
using System.Diagnostics;

namespace OpenGL.Objects.State
{
	/// <summary>
	/// Specify how fragments are rasterized on the current framebuffer.
	/// </summary>
	[DebuggerDisplay("WriteMaskState: Modes={Modes} Factor={Factor} Units={Units}")]
	public class WriteMaskState : GraphicsState
	{
		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public WriteMaskState()
		{

		}

		/// <summary>
		/// Construct a WriteMaskState for masking color and depth buffers.
		/// </summary>
		/// <param name="colorMask"></param>
		/// <param name="depthMask"></param>
		public WriteMaskState(bool colorMask, bool depthMask)
		{
			ColorMask = colorMask;
			DepthMask = depthMask;
		}

		#endregion

		#region Information

		/// <summary>
		/// Color mask, for R color component.
		/// </summary>
		public bool ColorMaskR = true;
		
		/// <summary>
		/// Color mask, for G color component.
		/// </summary>
		public bool ColorMaskG = true;

		/// <summary>
		/// Color mask, for B color component.
		/// </summary>
		public bool ColorMaskB = true;

		/// <summary>
		/// Color mask, for A color component.
		/// </summary>
		public bool ColorMaskA = true;

		/// <summary>
		/// Color mask, all color components.
		/// </summary>
		public bool ColorMask
		{
			get { return (ColorMaskR || ColorMaskG || ColorMaskB || ColorMaskA); }
			set { ColorMaskR = ColorMaskG = ColorMaskB = ColorMaskA = value; }
		}
			
		/// <summary>
		/// Flag indicating whether masking writes to depth component of the framebuffer.
		/// </summary>
		public bool DepthMask = true;

		/// <summary>
		/// Stencil mask, for front faces.
		/// </summary>
		public uint StencilMaskFront = UInt32.MaxValue;

		/// <summary>
		/// Stencil mask, for back faces.
		/// </summary>
		public uint StencilMaskBack = UInt32.MaxValue;

		/// <summary>
		/// Stencil mask, for all face directions.
		/// </summary>
		public bool StencilMask
		{
			get { return (StencilMaskFront != UInt32.MaxValue || StencilMaskBack != UInt32.MaxValue); }
			set { StencilMaskFront = StencilMaskBack = value ? UInt32.MaxValue : 0; }
		}

		#endregion

		#region Default State

		/// <summary>
		/// The system default state for WriteMaskState.
		/// </summary>
		public static WriteMaskState DefaultState { get { return (new WriteMaskState()); } }

		/// <summary>
		/// WriteMaskState masking color writing.
		/// </summary>
		public static WriteMaskState NonColorMaskState { get { return (new WriteMaskState(false, true)); } }

		#endregion

		#region GraphicsState Overrides

		/// <summary>
		/// The identifier for the blend state.
		/// </summary>
		public static string StateId = "OpenGL.WriteMask";

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
		/// Set ShaderProgram state.
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

			WriteMaskState currentState = (WriteMaskState)ctx.GetCurrentState(StateIndex);

			if (currentState != null)
				ApplyStateCore(ctx, program, currentState);
			else
				ApplyStateCore(ctx, program);

			ctx.SetCurrentState(this);
		}

		private void ApplyStateCore(GraphicsContext ctx, ShaderProgram program)
		{
			// Color
			Gl.ColorMask(ColorMaskR, ColorMaskG, ColorMaskB, ColorMaskA);
			// Depth
			Gl.DepthMask(DepthMask);
			// Stencil
			if (ctx.Version >= Gl.Version_200) {
				if (StencilMaskFront != StencilMaskBack) {
					Gl.StencilMaskSeparate(StencilFaceDirection.Front, StencilMaskFront);
					Gl.StencilMaskSeparate(StencilFaceDirection.Back, StencilMaskBack);
				} else
					Gl.StencilMaskSeparate(StencilFaceDirection.FrontAndBack, StencilMaskFront);
			} else {
				if (StencilMaskFront != StencilMaskBack)
					throw new InvalidOperationException("seperate stencil mask not supported");
				Gl.StencilMask(StencilMaskFront);
			}
		}

		private void ApplyStateCore(GraphicsContext ctx, ShaderProgram program, WriteMaskState currentState)
		{
			// Color
			if (ColorMaskR != currentState.ColorMaskR || ColorMaskG != currentState.ColorMaskG || ColorMaskB != currentState.ColorMaskB || ColorMaskA != currentState.ColorMaskA)
				Gl.ColorMask(ColorMaskR, ColorMaskG, ColorMaskB, ColorMaskA);
			// Depth
			if (DepthMask != currentState.DepthMask)
				Gl.DepthMask(DepthMask);
			// Stencil
			if (ctx.Version >= Gl.Version_200) {
				if (StencilMaskFront != StencilMaskBack) {
					if (StencilMaskFront != currentState.StencilMaskFront)
						Gl.StencilMaskSeparate(StencilFaceDirection.Front, StencilMaskFront);
					if (StencilMaskBack != currentState.StencilMaskBack)
						Gl.StencilMaskSeparate(StencilFaceDirection.Back, StencilMaskBack);
				} else {
					if (StencilMaskFront != currentState.StencilMaskFront || StencilMaskFront != currentState.StencilMaskBack)
						Gl.StencilMaskSeparate(StencilFaceDirection.FrontAndBack, StencilMaskFront);
				}
			} else {
				if (StencilMaskFront != StencilMaskBack)
					throw new InvalidOperationException("seperate stencil mask not supported");
				if (StencilMaskFront != currentState.StencilMaskFront)
					Gl.StencilMask(StencilMaskFront);
			}
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

			WriteMaskState otherState = state as WriteMaskState;

			if (otherState == null)
				throw new ArgumentException("not a WriteMaskState", "state");

			
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
			Debug.Assert(other is WriteMaskState);

			WriteMaskState otherState = (WriteMaskState)other;

			return (true);
		}

		#endregion
	}
}
