
// Copyright (C) 2015 Luca Piccioni
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

using NUnit.Framework;

namespace OpenGL.Hal.Test
{
	/// <summary>
	/// Base test clas for testing rendering on GraphicsSurface.
	/// </summary>
	[TestFixture]
	abstract class GraphicsSurfaceTest : TestBase
	{
		/// <summary>
		/// Get the GraphicsSurface subject to test.
		/// </summary>
		public abstract GraphicsSurface Surface { get; }

		/// <summary>
		/// Delegate used for executing animation initialization.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="animationTime">
		/// A <see cref="TimeSpan"/> that specifies the animation time.
		/// </param>
		/// <param name="data">
		/// A <see cref="Object"/> used to pass information to animation drawing delegate.
		/// </param>
		protected delegate void AnimationInitDelegate(GraphicsContext ctx, object data);

		/// <summary>
		/// Delegate used for executing animation drawing.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="animationTime">
		/// A <see cref="TimeSpan"/> that specifies the animation time.
		/// </param>
		/// <param name="data">
		/// A <see cref="Object"/> used to pass information to animation drawing delegate.
		/// </param>
		protected delegate void AnimationDrawDelegate(GraphicsContext ctx, TimeSpan animationTime, object data);

		/// <summary>
		/// Delegates modeling the animation.
		/// </summary>
		protected struct AnimationDelegates
		{
			/// <summary>
			/// Animation initialization delegate.
			/// </summary>
			public AnimationInitDelegate Init;

			/// <summary>
			/// Animation drawing delegate.
			/// </summary>
			public AnimationDrawDelegate Draw;
		}

		/// <summary>
		/// Delegate used for executing animation drawing.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="animationTime">
		/// A <see cref="TimeSpan"/> that specifies the total animation time.
		/// </param>
		/// <param name="data">
		/// A <see cref="Object"/> used to pass information to animation drawing delegate.
		/// </param>
		protected void StartAnimation(GraphicsContext ctx, TimeSpan animationTime, AnimationDelegates animationDelegates, object data)
		{
			DateTime animationBegin = DateTime.UtcNow;
			TimeSpan animationElapsedTime;

			// Initialize animation
			if (animationDelegates.Init != null)
				animationDelegates.Init(ctx, data);

			// Execute animation
			while ((animationElapsedTime = (DateTime.UtcNow - animationBegin)) < animationTime) {
				// Clear surface
				Surface.Clear(ctx);
				// Execute drawing
				animationDelegates.Draw(ctx, animationElapsedTime, data);
				// Swap buffers
			}
		}
	}
}
