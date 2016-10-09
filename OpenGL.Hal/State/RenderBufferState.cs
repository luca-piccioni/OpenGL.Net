
// Copyright (C) 2012-2015 Luca Piccioni
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
using System.Text;

namespace OpenGL.State
{
	/// <summary>
	/// Draw framebuffer state.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This state is responsible to manage the draw framebuffers and relative state that affect the draw and read
	/// commands. The following OpenGL state is managed by this <see cref="GraphicsState"/>:
	/// - <see cref="Gl.DRAW_FRAMEBUFFER_BINDING"/>
	/// - <see cref="Gl.DRAW_BUFFER"/> (or any Gl.DRAW_BUFFERi value).
	/// </para>
	/// </remarks>
	[DebuggerDisplay("RenderBufferState")]
	public class RenderBufferState : GraphicsState
	{
		#region Constructors

		/// <summary>
		/// Construct a default RenderBufferState (default framebuffer).
		/// </summary>
		public RenderBufferState()
		{
			mDrawBuffers = new int[Gl.CurrentLimits.MaxColorAttachments];
			mDrawBuffers[0] = Gl.BACK_LEFT;
			for (int i = 1; i < mDrawBuffers.Length; i++)
				mDrawBuffers[i] = Gl.NONE;
		}

		/// <summary>
		/// Construct a RenderBufferState indicating a <see cref="RenderFramebuffer"/> as draw binding.
		/// </summary>
		public RenderBufferState(Framebuffer framebuffer)
		{
			if (framebuffer == null)
				throw new ArgumentNullException("framebuffer");
			
			mDrawBuffers = new int[Gl.CurrentLimits.MaxColorAttachments];
			mDrawBuffers[0] = Gl.COLOR_ATTACHMENT0;
			for (int i = 1; i < mDrawBuffers.Length; i++)
				mDrawBuffers[i] = Gl.NONE;
			
			mDrawFramebuffer = framebuffer;
			mDrawFramebuffer.IncRef();
		}

		/// <summary>
		/// Construct the current RenderBufferState.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> defining this RenderBufferState.
		/// </param>
		public RenderBufferState(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			int drawBinding;

			// Draw buffer binding
			Gl.Get(Gl.DRAW_FRAMEBUFFER_BINDING, out drawBinding);
			mDrawBinding = (uint)drawBinding;

			// Draw buffers
			mDrawBuffers = new int[Gl.CurrentLimits.MaxColorAttachments];
			for (int i = 0; i < Gl.CurrentLimits.MaxColorAttachments; i++) {
				Gl.Get(Gl.DRAW_BUFFER0 + i, out mDrawBuffers[i]);
			}
			
#if false
			// Linux, Mono, NVIDIA Corporation, NVIDIA 310.44, GeForce 8800 GTS 512/PCIe/SSE2
			// - Gl.DrawBuffers(1, {Gl.FRONT_LEFT}); -> Gl.INVALID_OPERATION
			if (mDrawBuffers[0] == Gl.FRONT_LEFT)
				mDrawBuffers[0] = Gl.FRONT;
#endif
		}

		#endregion

		#region Draw Binding & Buffers

		/// <summary>
		/// Framebuffer name used for storing processed fragments.
		/// </summary>
		private uint mDrawBinding;

		/// <summary>
		/// Framebuffer used for storing processed fragments.
		/// </summary>
		private Framebuffer mDrawFramebuffer;

		/// <summary>
		/// Actual combination of indices for redirecting drawing command to bound framebuffer attachments.
		/// </summary>
		private int[] mDrawBuffers;

		#endregion

		#region Default State

		/// <summary>
		/// The system default state for RenderBufferState.
		/// </summary>
		public static RenderBufferState DefaultState { get { return (new RenderBufferState()); } }

		#endregion

		#region GraphicsState Overrides

		/// <summary>
		/// The identifier for the blend state.
		/// </summary>
		public const string StateId = "OpenGL.RenderBuffers";

		/// <summary>
		/// The identifier of this GraphicsState.
		/// </summary>
		public override string StateIdentifier { get { return (StateId); } }

		/// <summary>
		/// Set ShaderProgram state.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> which has defined the shader program <paramref name="sProgram"/>.
		/// </param>
		/// <param name="sProgram">
		/// The <see cref="ShaderProgram"/> which has the state set.
		/// </param>
		public override void ApplyState(GraphicsContext ctx, ShaderProgram sProgram)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			// Framebuffer object must be existing to apply state
			if (mDrawFramebuffer != null && !mDrawFramebuffer.Exists(ctx))
				throw new InvalidOperationException("RenderFramebuffer not existing");

			// Setup binding
			if (mDrawFramebuffer == null) {
				// The draw binding is stored in 'mDrawBinding': 0 indicates the default framebuffer
				Gl.BindFramebuffer(Gl.DRAW_FRAMEBUFFER, mDrawBinding);
			} else {
				// Bind a framebuffer object instead of any framebuffer (including the default one)
				// Here a default draw buffers configuration is setup
				mDrawFramebuffer.BindDraw(ctx);
			}

			// Setup draw buffers
			if (mDrawBuffers != null)
				Gl.DrawBuffers(mDrawBuffers);
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

			RenderBufferState otherState = state as RenderBufferState;

			if (otherState == null)
				throw new ArgumentException("not a RenderBufferState", "state");

			// The actual binding name
			mDrawBinding = otherState.mDrawBinding;
			
			// The framebuffer object
			mDrawFramebuffer = otherState.mDrawFramebuffer;
			if (mDrawFramebuffer != null)
				mDrawFramebuffer.IncRef();

			// The draw buffers
			if (otherState.mDrawBuffers != null) {
				mDrawBuffers = new int[otherState.mDrawBuffers.Length];
				Array.Copy(otherState.mDrawBuffers, mDrawBuffers, mDrawBuffers.Length);
			} else
				mDrawBuffers = null;
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
			Debug.Assert(other is RenderBufferState);

			RenderBufferState otherState = (RenderBufferState)other;

			if (mDrawBinding != otherState.mDrawBinding)
				return (false);

			return (true);
		}

		/// <summary>
		/// Performs a deep copy of this <see cref="IGraphicsState"/>.
		/// </summary>
		/// <returns>
		/// It returns the equivalent of this <see cref="IGraphicsState"/>, but all objects referenced
		/// are not referred by both instances.
		/// </returns>
		public override IGraphicsState Copy()
		{
			RenderBufferState copy = base.Copy() as RenderBufferState;
			
			copy.mDrawBuffers = new int[mDrawBuffers.Length];
			Array.Copy(mDrawBuffers, copy.mDrawBuffers, mDrawBuffers.Length);
			
			return (copy);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (mDrawFramebuffer != null)
					mDrawFramebuffer.DecRef();
			}

			// Base implementation
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// Represents the current <see cref="GraphicsState"/> for logging.
		/// </summary>
		/// <returns>
		/// A <see cref="String"/> that represents the current <see cref="GraphicsState"/>.
		/// </returns>
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			
			sb.Append(String.Format("{0}: DrawBinding={1} ", StateIdentifier, mDrawBinding));
			for (int i = 0; i < mDrawBuffers.Length; i++)
				if (mDrawBuffers[i] != Gl.NONE)
					sb.Append(String.Format("Buffer[{0}]={1} ", i, mDrawBuffers[i]));
			sb.Remove(sb.Length - 1, 1);
			
			return (sb.ToString());
		}

		#endregion
	}
}
