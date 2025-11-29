
// Copyright (C) 2016-2017 Luca Piccioni
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
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

using OpenGL;
using OpenGL.Objects;
// using OpenGL.Objects.Scene;
using OpenGL.Objects.State;

namespace HelloObjects
{
	/// <summary>
	/// OpenGL.Objects sample application.
	/// </summary>
	public partial class SampleForm : Form
	{
		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public SampleForm()
		{
			InitializeComponent();
		}

		#endregion

		#region 

		private struct Mass
		{
			public Vertex4f Position;
			public Vertex4f Velocity;
			public Vertex4f Force;
		}

		private void CreateResources(GraphicsContext ctx)
		{
			// Program library
			ShadersLibrary.Merge("HelloObjects.Shaders._ShadersLibrary.xml");

			// // Mass buffer
			// _MassBuffer = new ArrayBufferInterleaved<Mass>(BufferUsage.StaticDraw);
			// _Context.LinkResource(_MassBuffer); 
			// 
			// // _MassBuffer.Immutable = false;
			// _MassBuffer.Create(_Size);
			// 
			// // Map arrays
			// _MassArrays = new VertexArrays();
			// _Context.LinkResource(_MassArrays);
			// 
			// _MassArrays.SetArray(_MassBuffer, 0, VertexArraySemantic.Position);
			// _MassArrays.SetElementArray(PrimitiveType.Points, 0, 1024);
			// _MassArrays.Create(_Context);
			// 
			// // Programs
			// _ComputeEnergy = _Context.CreateProgram("HelloObjects.MassForceCompute");
			// _ComputePosition = _Context.CreateProgram("HelloObjects.MassPositionCompute");
			// _DrawMass = _Context.CreateProgram("OpenGL.Standard");
			// 
			// // Initiailize mass buffer
			// Random random = new Random();
			// 
			// _MassBuffer.Map(_Context, BufferAccess.WriteOnly);
			// for (uint i = 0; i < _MassBuffer.ItemsCount; i++) {
			// 	Mass mass;
			// 
			// 	mass.Position = new Vertex4f((float)random.NextDouble(), (float)random.NextDouble(), (float)random.NextDouble(), 1.0f) * 256.0f;
			// 	mass.Velocity = new Vertex4f((float)random.NextDouble(), (float)random.NextDouble(), (float)random.NextDouble(), 1.0f) * 0.000f;
			// 	mass.Force = new Vertex4f(0.0f, 0.0f, 0.0f, (float)Math.Abs(random.NextDouble() * 100000.0));
			// 
			// 	_MassBuffer.SetElement(mass, i);
			// }
			// 
			// _MassBuffer.Unmap(_Context);
		}

		ArrayBufferInterleaved<Mass> _MassBuffer;

		private ShaderProgram _ComputeEnergy;

		private ShaderProgram _ComputePosition;

		private ShaderProgram _DrawMass;

		private VertexArrays _MassArrays;

		#endregion

		#region Event Handling

		private void SampleForm_Load(object sender, EventArgs e)
		{
			AnimationTimer.Enabled = true;
			ObjectsControl.MouseWheel += ObjectsControl_MouseWheel;
		}

		#region Rendering

		/// <summary>
		/// Allocate resources for rendering.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ObjectsControl_ContextCreated(object sender, GlControlEventArgs e)
		{
			// Wrap GL context with GraphicsContext
			_Context = new GraphicsContext(e.DeviceContext, e.RenderContext);
			// Create resources
			CreateResources(_Context);

			Gl.ClearColor(0.1f, 0.1f, 0.1f, 0.0f);

			Gl.Enable(EnableCap.Multisample);
		}

		/// <summary>
		/// Dispose resources allocated by <see cref="ObjectsControl_ContextCreated"/>
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ObjectsControl_ContextDestroying(object sender, GlControlEventArgs e)
		{
			_Context.Dispose();
		}

		/// <summary>
		/// Update framebuffer.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ObjectsControl_Render(object sender, GlControlEventArgs e)
		{
			float deltaTime = (float)_Crono.Elapsed.TotalSeconds * _TimeSpeed;
			_Crono.Restart();

			// Update force
			// _ComputeEnergy.SetStorageBuffer(_Context, "MassBuffer", _MassBuffer);
			// 
			// _ComputeEnergy.SetUniform(_Context, "glo_MassCount", (int)_MassBuffer.ItemsCount);
			// _ComputeEnergy.SetUniform(_Context, "glo_Gravity", _Gravity);
			// _ComputeEnergy.SetUniform(_Context, "glo_MinDistanceForGravity", 0.1f);
			// 
			// _ComputeEnergy.SetUniform(_Context, "glo_DeltaTime", deltaTime);
			// 
			// _ComputeEnergy.Compute(_Context, 1024);
			// _ComputeEnergy.MemoryBarrier(MemoryBarrierMask.ShaderStorageBarrierBit);
			// 
			// // Update positions
			// _ComputePosition.SetStorageBuffer(_Context, "MassBuffer", _MassBuffer);
			// 
			// _ComputePosition.SetUniform(_Context, "glo_MassCount", (int)_MassBuffer.ItemsCount);
			// _ComputePosition.SetUniform(_Context, "glo_Gravity", _Gravity);
			// _ComputePosition.SetUniform(_Context, "glo_MinDistanceForGravity", 0.1f);
			// 
			// _ComputePosition.SetUniform(_Context, "glo_DeltaTime", deltaTime);
			// _ComputePosition.Compute(_Context, 1024);
			// _ComputePosition.MemoryBarrier(MemoryBarrierMask.VertexAttribArrayBarrierBit);
			// 
			// // Draw scene
			// GlControl senderControl = (GlControl)sender;
			// float senderAspectRatio = (float)senderControl.Width / senderControl.Height;
			// 
			// // Clear
			// Gl.Viewport(0, 0, senderControl.Width, senderControl.Height);
			// Gl.ClearColor(1.0f, 0.0f, 0.0f, 1.0f);
			// Gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
			// 
			// Matrix4x4f mvp = Matrix4x4f.Perspective(60.0f, senderAspectRatio, 0.1f, 16535.0f) * Matrix4x4f.Translated(-128.0f, -128.0f, -256.0f);
			// 
			// _DrawMass.SetUniform(_Context, "glo_ModelViewProjection", mvp);
			// 
			// _MassArrays.Draw(_Context, _DrawMass);
		}

		const uint _Size = 128;

		float _Gravity = 1800f;

		float _TimeSpeed = 1000.0f;

		private Stopwatch _Crono = new Stopwatch();

		/// <summary>
		/// The GL context.
		/// </summary>
		GraphicsContext _Context;

		/// <summary>
		/// Azimuth angle of the view-point.
		/// </summary>
		private float _ViewAzimuth;

		/// <summary>
		/// Elevation angle of the view-point.
		/// </summary>
		private float _ViewElevation;

		/// <summary>
		/// lever arm of the view-point.
		/// </summary>
		private float _ViewLever = 4.0f;

		private float _ViewStrideLat, _ViewStrideAlt;

		private void UpdateGlobalLight()
		{
			float az = Angle.ToRadians(_GlobalLightAz);
			float el = Angle.ToRadians(_GlobalLightEl);
			float xAz = (float)Math.Cos(az), yAz = (float)Math.Sin(az);
			float xEl = (float)Math.Cos(el), yEl = (float)Math.Sin(el);

			Vertex3f dir = new Vertex3f(
				xAz, yEl, yAz
			);

			// _GlobalLightObject.Direction = dir.Normalized;
		}

		private float _GlobalLightAz, _GlobalLightEl;

		#endregion

		#region Mouse Input

		private void ObjectsControl_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				_Mouse = e.Location;
		}

		private void ObjectsControl_MouseMove(object sender, MouseEventArgs e)
		{
			if (_Mouse.HasValue) {
				System.Drawing.Point delta = _Mouse.Value - (System.Drawing.Size)e.Location;

				_ViewAzimuth += delta.X * 0.5f;
				_ViewElevation += delta.Y * 0.5f;

				_Mouse = e.Location;
			}
		}

		private void ObjectsControl_MouseUp(object sender, MouseEventArgs e)
		{
			_Mouse = null;
		}

		private System.Drawing.Point? _Mouse;

		private void ObjectsControl_MouseWheel(object sender, MouseEventArgs e)
		{
			_ViewLever += e.Delta / 60.0f;
			_ViewLever = Math.Max(2.5f, _ViewLever);
		}

		private void ObjectsControl_KeyDown(object sender, KeyEventArgs e)
		{
			if (_PressedKeys.Contains(e.KeyCode) == false)
				_PressedKeys.Add(e.KeyCode);
		}

		private void ObjectsControl_KeyUp(object sender, KeyEventArgs e)
		{
			_PressedKeys.Remove(e.KeyCode);
		}

		/// <summary>
		/// Currently pressed keys
		/// </summary>
		private readonly List<Keys> _PressedKeys = new List<Keys>();

		#endregion

		#region Animation

		private void UpdateTimer_Tick(object sender, EventArgs args)
		{
			foreach (Keys pressedKey in _PressedKeys) {
				switch (pressedKey) {
					case Keys.A:
						_ViewStrideLat -= 0.1f;
						break;
					case Keys.D:
						_ViewStrideLat += 0.1f;
						break;
					case Keys.W:
						_ViewStrideAlt += 0.1f;
						break;
					case Keys.S:
						_ViewStrideAlt -= 0.1f;
						break;

					case Keys.J:
						_GlobalLightAz += 1.0f;
						UpdateGlobalLight();
						break;
					case Keys.L:
						_GlobalLightAz -= 1.0f;
						UpdateGlobalLight();
						break;
					case Keys.I:
						_GlobalLightEl += 1.0f;
						UpdateGlobalLight();
						break;
					case Keys.K:
						_GlobalLightEl -= 1.0f;
						UpdateGlobalLight();
						break;
				}
			}

			ObjectsControl.Invalidate();
		}

		#endregion

		#endregion
	}
}
