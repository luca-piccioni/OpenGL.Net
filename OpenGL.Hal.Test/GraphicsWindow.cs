
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
using System.Windows.Forms;

using NUnit.Framework;

namespace OpenGL.Hal.Test
{
	/// <summary>
	/// Test GraphicsWindow class.
	/// </summary>
	[TestFixture]
	class GraphicsWindowTest : GraphicsSurfaceTest
	{
		/// <summary>
		/// Test version properties.
		/// </summary>
		[Test]
		public void TestRender()
		{
			_Window.ShowWindow();

			try {
				StartAnimation(_Context, new TimeSpan(0, 0, 10), GetAnimationDelegates(), null);
			} finally {
				_Window.HideWindow();
			}
		}

		#region GraphicsSurfaceTest Overrides

		/// <summary>
		/// Get the GraphicsSurface subject to test.
		/// </summary>
		public override GraphicsSurface Surface { get { return (_Window); } }

		/// <summary>
		/// Get the animation delegates required to this test ficture.
		/// </summary>
		/// <returns></returns>
		private AnimationDelegates GetAnimationDelegates()
		{
			AnimationDelegates animationDelegates = new AnimationDelegates();

			animationDelegates.Init = AnimationInit;
			animationDelegates.Draw = AnimationDraw;

			return (animationDelegates);
		}

		/// <summary>
		/// Method used for executing animation initialization.
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
		protected void AnimationInit(GraphicsContext ctx, object data)
		{
			// Make window visible
			_Window.ShowWindow();
			// Bind surface for drawing
			Surface.BindDraw(_Context);

			// Setup viewport
			Gl.Viewport(0, 0, (int)Surface.Width, (int)Surface.Height);

			// Setup projection matrix
			Gl.MatrixMode(MatrixMode.Projection);
			Gl.LoadIdentity();
			Gl.Ortho(-2.0f, +2.0f, -2.0f, +2.0f, 0.0f, 1.0f);
		}

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
		protected void AnimationDraw(GraphicsContext ctx, TimeSpan animationTime, object data)
		{
			const float DEG_PER_SEC = 45.0f;

			// Clear surface
			Surface.Clear(_Context);

			// Set modelview matrix
			Gl.MatrixMode(MatrixMode.Modelview);
			Gl.LoadIdentity();

			// Animation: rotate triangle
			Gl.Rotate(Angle.Normalize(animationTime.TotalSeconds * DEG_PER_SEC), 0.0f, 0.0f, 1.0f);

			// Red triangle
			Gl.Color3(1.0f, 0.0f, 0.0f);

			Gl.Begin(PrimitiveType.Triangles);
			Gl.Vertex2(-1.0f, -1.0f);
			Gl.Vertex2(0.0f, 1.0f);
			Gl.Vertex2(+1.0f, -1.0f);
			Gl.End();
		}

		#endregion
	}
}
