
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
using System.Diagnostics;

namespace OpenGL.Objects.State
{
	[DebuggerDisplay("CullFaceState: FrontFaceMode={FrontFaceMode} Culling={Culling} CulledFace={CulledFace}")]
	public class ClippingPlaneState : GraphicsState
	{
		#region Constructors
		
		/// <summary>
		/// Construct a default CullFaceState (front face is CCW, culling backfaces).
		/// </summary>
		public ClippingPlaneState()
		{
			
		}

		/// <summary>
		/// Construct the current CullFaceState.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> defining this GraphicsState.
		/// </param>
		public ClippingPlaneState(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException(nameof(ctx));

			for (int i = 0; i < Enabled.Length; i++)
				Enabled[i] = Gl.IsEnabled(EnableCap.ClipPlane0 + i);
		}
		
		#endregion

		#region Information

		/// <summary>
		/// Clipping plane/distance enabled state.
		/// </summary>
		public readonly bool[] Enabled = new bool[8];

		/// <summary>
		/// Clipping planes equations.
		/// </summary>
		public readonly Planef[] Planes = new Planef[8];
		
		#endregion

		#region Default State

		/// <summary>
		/// The system default state for CullFaceState.
		/// </summary>
		public static ClippingPlaneState DefaultState { get { return new ClippingPlaneState(); } }

		#endregion

		#region GraphicsState Overrides

		/// <summary>
		/// The identifier of the state.
		/// </summary>
		public static readonly string StateId = "OpenGL.ClippingPlanes";

		/// <summary>
		/// The identifier of this GraphicsState.
		/// </summary>
		public override string StateIdentifier { get { return StateId; } }

		/// <summary>
		/// Unique index assigned to this GraphicsState.
		/// </summary>
		public static int StateSetIndex { get { return _StateIndex; } }

		/// <summary>
		/// Unique index assigned to this GraphicsState.
		/// </summary>
		public override int StateIndex { get { return _StateIndex; } }

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
				throw new ArgumentNullException(nameof(ctx));

			ClippingPlaneState currentState = (ClippingPlaneState)ctx.GetCurrentState(StateIndex);

			if (currentState != null)
				ApplyStateCore(ctx, program, currentState);
			else
				ApplyStateCore(ctx, program);

			ctx.SetCurrentState(this);
		}

		private void ApplyStateCore(GraphicsContext ctx, ShaderProgram program)
		{
			if (ctx == null)
				throw new ArgumentNullException(nameof(ctx));

			for (int i = 0; i < Enabled.Length; i++)
				if (Enabled[i]) Gl.Enable(EnableCap.ClipPlane0 + i); else Gl.Disable(EnableCap.ClipPlane0 + i);

			if (ctx.Version.Profile == Khronos.KhronosVersion.ProfileCompatibility) {
				for (int i = 0; i < Planes.Length; i++)
					if (Enabled[i])
						Gl.ClipPlane(ClipPlaneName.ClipPlane0 + i, (double[])Planes[i]);
			}

			if (program != null) {
				for (int i = 0; i < Planes.Length; i++)
					if (Enabled[i])
						program.SetUniform(ctx, $"glo_ClipPlanes[{i}]", Planes[i]);
			}
		}

		private void ApplyStateCore(GraphicsContext ctx, ShaderProgram program, ClippingPlaneState currentState)
		{
			if (ctx == null)
				throw new ArgumentNullException(nameof(ctx));

			for (int i = 0; i < Enabled.Length; i++) {
				if (Enabled[i] == currentState.Enabled[i])
					continue;

				if (Enabled[i])
					Gl.Enable(EnableCap.ClipPlane0 + i);
				else
					Gl.Disable(EnableCap.ClipPlane0 + i);
			}

			if (ctx.Version.Profile == Khronos.KhronosVersion.ProfileCompatibility) {
				for (int i = 0; i < Planes.Length; i++) {
					if (!Enabled[i])
						continue;

					if (Planes[i] != currentState.Planes[i])
						Gl.ClipPlane(ClipPlaneName.ClipPlane0 + i, (double[])Planes[i]);
				}
			}

			if (program != null) {
				for (int i = 0; i < Planes.Length; i++) {
					if (!Enabled[i])
						continue;

					program.SetUniform(ctx, $"glo_ClipPlanes[{i}]", Planes[i]);
				}
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
				throw new ArgumentNullException(nameof(state));

			ClippingPlaneState otherState = state as ClippingPlaneState;

			if (otherState == null)
				throw new ArgumentException("not a ClippingPlaneState", nameof(state));

			for (int i = 0; i < Enabled.Length; i++) {
				Enabled[i] = otherState.Enabled[i];
				Planes[i] = otherState.Planes[i];
			}
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
				return false;
			Debug.Assert(other is ClippingPlaneState);

			ClippingPlaneState otherState = (ClippingPlaneState) other;

			for (int i = 0; i < Enabled.Length; i++) {
				if (Enabled[i] != otherState.Enabled[i])
					return false;
				if (Planes[i] != otherState.Planes[i])
					return false;
			}

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
			return "";
		}

		#endregion
	}
}
