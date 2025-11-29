
// Copyright (C) 2022 Luca Piccioni
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
using System.Runtime.CompilerServices;

namespace OpenGL.Objects
{
	/// <summary>
	/// Drawing command utilities.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This partial implementation of GraphicsContext defines drawing commands.
	/// </para>
	/// <para>
	/// The following methods are supported:
	/// - DrawPoint
	/// - DrawLines
	/// - DrawLineStrip
	/// - DrawLineLoop
	/// - TODO
	/// </para>
	/// <para>
	/// For each primitive, the following overrides should be available:
	/// - Immediate command: Draw*(ShaderProgram program, Vertex2f[] v, ...)
	///   - 'program': Default shader program, which state is set by <see cref="CurrentState"/>.
	///   - 'v': Vertices uploaded using a common array buffer.
	///   - '...': primitive parameters (i.e. size)
	/// </para>
	/// <para>
	/// - Draw*(ShaderProgram program, Vertex2f[] v, ...)
	///   - Any program able to rasterize the underlying primitive
	///   - 2D floating-point coordinates
	///   - ... primitive parameters (i.e. size, color...)
	///   
	/// </para>
	/// </remarks>
	public sealed partial class GraphicsContext
	{
		#region Drawing Resources

		private enum PrimitiveElement : int
		{
			Points = 0,
			Lines,
			LineStrip,
			LineLoop,
			Triangles,
			TriangleStrip,
			TriangleFan
		}

		private void CreateDrawResources()
		{
			CreateDrawResources2D(_DefaultDrawElementsCount);
			CreateDrawResources3D(_DefaultDrawElementsCount);
			CreateDrawResources2DHP(_DefaultDrawElementsCount);
		}

		private void CreateDrawResources2D(uint elementsCount)
		{
			// Note: use persistent buffer mapping to streaming on GPU
			// Note: if persistent mapping is not supported, the code still comply by mapping/unmapping

			_DrawPositions2D = new ArrayBuffer<Vertex2f>(BufferStorageMask.DynamicStorageBit | BufferStorageMask.MapPersistentBit | BufferStorageMask.MapCoherentBit | BufferStorageMask.MapWriteBit);
			_DrawPositions2D.Immutable = true;
			_DrawPositions2D.Create(this, elementsCount);
			_DrawPositions2D.IncRef();

			_DrawArrays2D = new VertexArrays();
			_DrawArrays2D.SetArray(_DrawPositions2D, VertexArraySemantic.Position);
			_DrawArrays2D.SetElementArray(PrimitiveType.Points);
			_DrawArrays2D.SetElementArray(PrimitiveType.Lines);
			_DrawArrays2D.SetElementArray(PrimitiveType.LineStrip);
			_DrawArrays2D.SetElementArray(PrimitiveType.LineLoop);
			_DrawArrays2D.SetElementArray(PrimitiveType.Triangles);
			_DrawArrays2D.SetElementArray(PrimitiveType.TriangleStrip);
			_DrawArrays2D.SetElementArray(PrimitiveType.TriangleFan);
			_DrawArrays2D.Create(this);
			_DrawArrays2D.IncRef();

			// Persistently map the draw buffers
			if (Extensions.BufferStorage_ARB && _DrawPositions2D.Immutable) {
				_DrawPositions2D.Map(this, BufferAccess.WriteOnly);
			}
		}

		private void ReallocDrawResources2D(uint elementsCount)
		{
			// Note: simple as that
			// The buffer will be effectively disposed only when the previously issues commands will complete
			// Current operation will use the newly allocated draw buffer

			Console.WriteLine($"Warning: reallocating 2D draw buffers to {elementsCount} elements ({elementsCount * 12 / 1024} Kb)");

			DisposeDrawResources2D();
			CreateDrawResources2D(elementsCount);
			ResetDrawCommandBuffer2D();
		}

		private void CreateDrawResources3D(uint elementsCount)
		{
			// Note: use persistent buffer mapping to streaming on GPU
			// Note: if persistent mapping is not supported, the code still comply by mapping/unmapping

			_DrawPositions3D = new ArrayBuffer<Vertex3f>(BufferStorageMask.DynamicStorageBit | BufferStorageMask.MapPersistentBit | BufferStorageMask.MapCoherentBit | BufferStorageMask.MapWriteBit);
			_DrawPositions3D.Immutable = true;
			_DrawPositions3D.Create(this, elementsCount);
			_DrawPositions3D.IncRef();

			_DrawArrays3D = new VertexArrays();
			_DrawArrays3D.SetArray(_DrawPositions3D, VertexArraySemantic.Position);
			_DrawArrays3D.SetElementArray(PrimitiveType.Points);
			_DrawArrays3D.SetElementArray(PrimitiveType.Lines);
			_DrawArrays3D.SetElementArray(PrimitiveType.LineStrip);
			_DrawArrays3D.SetElementArray(PrimitiveType.LineLoop);
			_DrawArrays3D.SetElementArray(PrimitiveType.Triangles);
			_DrawArrays3D.SetElementArray(PrimitiveType.TriangleStrip);
			_DrawArrays3D.SetElementArray(PrimitiveType.TriangleFan);
			_DrawArrays3D.Create(this);
			_DrawArrays3D.IncRef();

			// Persistently map the draw buffers
			if (Extensions.BufferStorage_ARB && _DrawPositions3D.Immutable) {
				_DrawPositions3D.Map(this, BufferAccess.WriteOnly);
			}
		}

		private void ReallocDrawResources3D(uint elementsCount)
		{
			// Note: simple as that
			// The buffer will be effectively disposed only when the previously issues commands will complete
			// Current operation will use the newly allocated draw buffer

			Console.WriteLine($"Warning: reallocating 3D draw buffers to {elementsCount} elements ({elementsCount * 12 / 1024} Kb)");

			DisposeDrawResources3D();
			CreateDrawResources3D(elementsCount);
			ResetDrawCommandBuffer3D();
		}

		private bool SupportDrawHP
		{
			get
			{
				return Extensions.GpuShaderFp64_ARB && (Extensions.VertexAttrib64bit_ARB || Version >= Gl.Version_410);
			}
		}

		private void CreateDrawResources2DHP(uint elementsCount)
		{
			if (!SupportDrawHP)
				return;     // Unable to support 2D douple-precision drawing

			// Note: use persistent buffer mapping to streaming on GPU
			// Note: if persistent mapping is not supported, the code still comply by mapping/unmapping

			_DrawPositions2DHP = new ArrayBuffer<Vertex2d>(BufferStorageMask.DynamicStorageBit | BufferStorageMask.MapPersistentBit | BufferStorageMask.MapCoherentBit | BufferStorageMask.MapWriteBit);
			_DrawPositions2DHP.Immutable = true;
			_DrawPositions2DHP.Create(this, elementsCount);
			_DrawPositions2DHP.IncRef();

			_DrawArrays2DHP = new VertexArrays();
			_DrawArrays2DHP.SetArray(_DrawPositions2DHP, VertexArraySemantic.Position);
			_DrawArrays2DHP.SetElementArray(PrimitiveType.Points);
			_DrawArrays2DHP.SetElementArray(PrimitiveType.Lines);
			_DrawArrays2DHP.SetElementArray(PrimitiveType.LineStrip);
			_DrawArrays2DHP.SetElementArray(PrimitiveType.LineLoop);
			_DrawArrays2DHP.SetElementArray(PrimitiveType.Triangles);
			_DrawArrays2DHP.SetElementArray(PrimitiveType.TriangleStrip);
			_DrawArrays2DHP.SetElementArray(PrimitiveType.TriangleFan);
			_DrawArrays2DHP.Create(this);
			_DrawArrays2DHP.IncRef();

			// Persistently map the draw buffers
			if (Extensions.BufferStorage_ARB && _DrawPositions2DHP.Immutable) {
				_DrawPositions2DHP.Map(this, BufferAccess.WriteOnly);
			}
		}

		private void ReallocDrawResources2DHP(uint elementsCount)
		{
			// Note: simple as that
			// The buffer will be effectively disposed only when the previously issues commands will complete
			// Current operation will use the newly allocated draw buffer

			Console.WriteLine($"Warning: reallocating 2D (double-prevision) draw buffers to {elementsCount} elements ({elementsCount * 12 / 1024} Kb)");

			DisposeDrawResources2DHP();
			CreateDrawResources2DHP(elementsCount);
			ResetDrawCommandBuffer2DHP();
		}

		private void DisposeDrawResources()
		{
			DisposeDrawResources2D();
			DisposeDrawResources3D();
			DisposeDrawResources2DHP();
		}

		private void DisposeDrawResources2D()
		{
			// Unmap persistent buffers
			if (_DrawPositions2D != null && Extensions.BufferStorage_ARB && _DrawPositions2D.Immutable) {
				// Note: not sure why it indicates the corrupted state
				_DrawPositions2D.Unmap(this, false);
			}

			_DrawArrays2D?.Dispose(this);
			_DrawArrays2D = null;

			_DrawPositions2D?.Dispose(this);
			_DrawPositions2D = null;
		}

		private void DisposeDrawResources3D()
		{
			// Unmap persistent buffers
			if (_DrawPositions3D != null && Extensions.BufferStorage_ARB && _DrawPositions3D.Immutable) {
				// Note: not sure why it indicates the corrupted state
				_DrawPositions3D.Unmap(this, false);
			}

			_DrawArrays3D?.Dispose(this);
			_DrawArrays3D = null;

			_DrawPositions3D?.Dispose(this);
			_DrawPositions3D = null;
		}

		private void DisposeDrawResources2DHP()
		{
			// Unmap persistent buffers
			if (_DrawPositions2DHP != null && Extensions.BufferStorage_ARB && _DrawPositions2DHP.Immutable) {
				// Note: not sure why it indicates the corrupted state
				_DrawPositions2DHP.Unmap(this, false);
			}

			_DrawArrays2DHP?.Dispose(this);
			_DrawArrays2DHP = null;

			_DrawPositions2DHP?.Dispose(this);
			_DrawPositions2DHP = null;
		}

		/// <summary>
		/// Buffer used for holding the data used for drawing.
		/// </summary>
		private ArrayBuffer<Vertex2f> _DrawPositions2D;

		/// <summary>
		/// Draw arrays used for linking draw buffers to shader attributes.
		/// </summary>
		private VertexArrays _DrawArrays2D;

		/// <summary>
		/// Buffer used for holding the data used for drawing.
		/// </summary>
		private ArrayBuffer<Vertex3f> _DrawPositions3D;

		/// <summary>
		/// Draw arrays used for linking draw buffers to shader attributes.
		/// </summary>
		private VertexArrays _DrawArrays3D;

		/// <summary>
		/// Buffer used for holding the data used for drawing.
		/// </summary>
		private ArrayBuffer<Vertex2d> _DrawPositions2DHP;

		/// <summary>
		/// Draw arrays used for linking draw buffers to shader attributes.
		/// </summary>
		private VertexArrays _DrawArrays2DHP;

		/// <summary>
		/// Maximum number of elements that can be stored in <see cref="_DrawPositions3D"/>.
		/// </summary>
		private const uint _DefaultDrawElementsCount = 1024 * 64;

		#endregion

		#region Drawing Commands

		/// <summary>
		/// Reset the drawing buffers.
		/// </summary>
		/// <remarks>
		/// This methos shall be called just after having swapped the OpenGL buffers on which drawing commands has been executed.
		/// </remarks>
		public void ResetDrawCommandBuffer()
		{
			ResetDrawCommandBuffer2D();
			ResetDrawCommandBuffer3D();
			ResetDrawCommandBuffer2DHP();
		}

		/// <summary>
		/// Reset the 2D drawing buffers.
		/// </summary>
		/// <remarks>
		/// This methos shall be called just after having swapped the OpenGL buffers on which drawing commands has been executed.
		/// </remarks>
		public void ResetDrawCommandBuffer2D()
		{
			_DrawBufferElementIndex2D = 0;
		}

		/// <summary>
		/// Drawing buffer element index.
		/// </summary>
		private uint _DrawBufferElementIndex2D = 0;

		/// <summary>
		/// Reset the 3D drawing buffers.
		/// </summary>
		/// <remarks>
		/// This methos shall be called just after having swapped the OpenGL buffers on which drawing commands has been executed.
		/// </remarks>
		public void ResetDrawCommandBuffer3D()
		{
			_DrawBufferElementIndex3D = 0;
		}

		/// <summary>
		/// Drawing buffer element index.
		/// </summary>
		private uint _DrawBufferElementIndex3D = 0;

		/// <summary>
		/// Reset the 2D drawing buffers (double-precision).
		/// </summary>
		/// <remarks>
		/// This methos shall be called just after having swapped the OpenGL buffers on which drawing commands has been executed.
		/// </remarks>
		public void ResetDrawCommandBuffer2DHP()
		{
			_DrawBufferElementIndex2DHP = 0;
		}

		/// <summary>
		/// Drawing buffer element index.
		/// </summary>
		private uint _DrawBufferElementIndex2DHP = 0;

		#region Points

		/// <summary>
		/// Draw a point.
		/// </summary>
		/// <param name="program">
		/// The <see cref="ShaderProgram"/> used for drawing the point.
		/// </param>
		/// <param name="v">
		/// The position of the point.
		/// </param>
		/// <param name="size">
		/// The size of the point, in pixels.
		/// </param>
		public void DrawPoint(ShaderProgram program, Vertex2f v, float size)
		{
			uint drawCommandOffset = _DrawBufferElementIndex2D;

			MapDrawBuffers2D();
			try {
				AddDrawVertices2D(v);
			} finally {
				UnmapDrawBuffers2D();
			}

			// Not tracked by OpenGL.Objects.State
			Gl.PointSize(size);
			// Apply current state
			CurrentState.Apply(this, program);
			
			// Draw
			_DrawArrays2D.Draw(this, program, (int)PrimitiveElement.Points, drawCommandOffset, 1);
		}

		/// <summary>
		/// Draw a point using the default shader.
		/// </summary>
		/// <param name="v">
		/// The position of the point.
		/// </param>
		/// <param name="size">
		/// The size of the point, in pixels.
		/// </param>
		/// <param name="color">
		/// The color of the point.
		/// </param>
		public void DrawPoint(Vertex2f v, float size, ColorRGBAF color)
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.Standard");

			Bind(program);
			program.SetUniform(this, "glo_UniformColor", color);

			DrawPoint(program, v, size);
		}

		/// <summary>
		/// Draw a set of points using the default shader.
		/// </summary>
		/// <param name="v">
		/// The positions of the points.
		/// </param>
		/// <param name="size">
		/// The size of the points, in pixels.
		/// </param>
		/// <param name="color">
		/// The color of the points.
		/// </param>
		public void DrawPoint(Vertex2f v, float size, ColorRGBAF color, float depth)
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.Standard+OverrideDepth");

			Bind(program);
			program.SetUniform(this, "glo_UniformColor", color);
			program.SetUniform(this, "glo_FragmentDepth", depth);

			DrawPoint(program, v, size);
		}

		/// <summary>
		/// Draw a set of points.
		/// </summary>
		/// <param name="program">
		/// The <see cref="ShaderProgram"/> used for drawing the points.
		/// </param>
		/// <param name="v">
		/// The positions of the points.
		/// </param>
		/// <param name="size">
		/// The size of the points, in pixels.
		/// </param>
		public void DrawPoints(ShaderProgram program, Vertex2f[] v, float size)
		{
			uint drawCommandOffset = _DrawBufferElementIndex2D;

			MapDrawBuffers2D();
			try {
				AddDrawVertices2D(v);
			} finally {
				UnmapDrawBuffers2D();
			}

			// Not tracked by OpenGL.Objects.State
			Gl.PointSize(size);
			// Apply current state
			CurrentState.Apply(this, program);
			// Draw
			_DrawArrays2D.Draw(this, program, (int)PrimitiveElement.Points, drawCommandOffset, (uint)v.Length);
		}

		/// <summary>
		/// Draw a set of points.
		/// </summary>
		/// <param name="program">
		/// The <see cref="ShaderProgram"/> used for drawing the points.
		/// </param>
		/// <param name="v">
		/// The positions of the points.
		/// </param>
		/// <param name="size">
		/// The size of the points, in pixels.
		/// </param>
		public void DrawPoints(ShaderProgram program, Vertex2d[] v, float size)
		{
			uint drawCommandOffset = _DrawBufferElementIndex2D;

			MapDrawBuffers2DHP();
			try {
				AddDrawVertices2DHP(v);
			} finally {
				UnmapDrawBuffers2DHP();
			}

			// Not tracked by OpenGL.Objects.State
			Gl.PointSize(size);
			// Apply current state
			CurrentState.Apply(this, program);

			// Draw
			(_DrawArrays2DHP ?? _DrawArrays2D).Draw(this, program, (int)PrimitiveElement.Points, drawCommandOffset, (uint)v.Length);
		}

		/// <summary>
		/// Draw a set of points using the default shader.
		/// </summary>
		/// <param name="v">
		/// The positions of the points.
		/// </param>
		/// <param name="size">
		/// The size of the points, in pixels.
		/// </param>
		/// <param name="color">
		/// The color of the points.
		/// </param>
		public void DrawPoints(Vertex2f[] v, float size, ColorRGBAF color)
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.Standard");

			Bind(program);
			program.SetUniform(this, "glo_UniformColor", color);

			DrawPoints(program, v, size);
		}

		/// <summary>
		/// Draw a set of points using the default shader (with uniform depth support).
		/// </summary>
		/// <param name="v">
		/// The positions of the points.
		/// </param>
		/// <param name="size">
		/// The size of the points, in pixels.
		/// </param>
		/// <param name="color">
		/// The color of the points.
		/// </param>
		/// <param name="depth">
		/// The uniform depth to apply to the point fragments.
		/// </param>
		public void DrawPoints(Vertex2f[] v, float size, ColorRGBAF color, float depth)
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.Standard+OverrideDepth");

			Bind(program);
			program.SetUniform(this, "glo_UniformColor", color);
			program.SetUniform(this, "glo_FragmentDepth", depth);

			DrawPoints(program, v, size);
		}

		#endregion

		#region Points (Geographic Projection)

		public void DrawGeoPoints(Vertex2f[] v, Vertex2f projectionCenter, float minPrecision, float size, ColorRGBAF color, float depth, string projection = "Vincenty")
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram($"OpenGL.Standard+{projection}Projection+OverrideDepth");

			Bind(program);
			program.SetUniform(this, "glo_GeoProjectOrigin", projectionCenter);
			program.SetUniform(this, "glo_GeoProjectMinPrecision", minPrecision);
			program.SetUniform(this, "glo_UniformColor", color);
			program.SetUniform(this, "glo_FragmentDepth", depth);

			DrawPoints(program, v, size);
		}

		public void DrawGeoPoints(Vertex2d[] v, Vertex2d projectionCenter, double minPrecision, float size, ColorRGBAF color, float depth, string projection = "Vincenty")
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram($"OpenGL.Standard+{projection}ProjectionHP+OverrideDepth");

			Bind(program);
			program.SetUniform(this, "glo_GeoProjectOrigin", projectionCenter);
			program.SetUniform(this, "glo_GeoProjectMinPrecision", minPrecision);
			program.SetUniform(this, "glo_UniformColor", color);
			program.SetUniform(this, "glo_FragmentDepth", depth);

			DrawPoints(program, v, size);
		}

		#endregion

		#region Lines

		/// <summary>
		/// Draw a line.
		/// </summary>
		/// <param name="program">
		/// The <see cref="ShaderProgram"/> used for drawing the points.
		/// </param>
		/// <param name="a">
		/// The position of the line beginning.
		/// </param>
		/// <param name="b">
		/// The position of the line ending.
		/// </param>
		private void DrawLines(ShaderProgram program, params Vertex2f[] v)
		{
			uint drawCommandOffset = _DrawBufferElementIndex2D;

			MapDrawBuffers2D();
			try {
				AddDrawVertices2D(v);
			} finally {
				UnmapDrawBuffers2D();
			}

			// Apply current state
			CurrentState.Apply(this, program);
			// Draw
			_DrawArrays2D.Draw(this, program, (int)PrimitiveElement.Lines, drawCommandOffset, (uint)v.Length);
		}

		/// <summary>
		/// Draw a set of points using the default shader.
		/// </summary>
		/// <param name="v">
		/// The positions of the points.
		/// </param>
		/// <param name="size">
		/// The size of the points, in pixels.
		/// </param>
		/// <param name="color">
		/// The color of the points.
		/// </param>
		public void DrawLines(Vertex2f[] v, float size, ColorRGBAF color)
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.Line");

			Bind(program);
			program.SetUniform(this, "glo_UniformColor", color);
			program.SetUniform(this, "glo_LineWidth", size);

			DrawLines(program, v);
		}

		/// <summary>
		/// Draw a set of points using the default shader.
		/// </summary>
		/// <param name="v">
		/// The positions of the points.
		/// </param>
		/// <param name="width">
		/// The size of the points, in pixels.
		/// </param>
		/// <param name="color">
		/// The color of the points.
		/// </param>
		public void DrawLines(Vertex2f[] v, float width, ColorRGBAF color, float depth)
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.Line+OverrideDepth");

			Bind(program);
			program.SetUniform(this, "glo_UniformColor", color);
			program.SetUniform(this, "glo_LineWidth", width);
			program.SetUniform(this, "glo_FragmentDepth", depth);

			DrawLines(program, v);
		}

		/// <summary>
		/// Draw a set of points using the default shader.
		/// </summary>
		/// <param name="v">
		/// The positions of the points.
		/// </param>
		/// <param name="width">
		/// The size of the points, in pixels.
		/// </param>
		/// <param name="color">
		/// The color of the points.
		/// </param>
		public void DrawLinesHalo(Vertex2f[] v, float width, float iwidth, ColorRGBAF color, float depth)
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.Line+OverrideDepth");

			Bind(program);
			program.SetUniform(this, "glo_FragmentDepth", depth);

			program.SetUniform(this, "glo_LineWidth", width);
			program.SetUniform(this, "glo_UniformColor", ColorRGBAF.ColorBlack);
			DrawLines(program, v);

			program.SetUniform(this, "glo_LineWidth", iwidth);
			program.SetUniform(this, "glo_UniformColor", color);
			DrawLines(program, v);
		}

		#endregion

		#region Lines (Geographic Projection)

		public void DrawGeoLines(Vertex2f[] v, Vertex2f projectionCenter, float minPrecision, float size, ColorRGBAF color, float depth, string projection = "Vincenty")
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram($"OpenGL.Line+{projection}Projection+OverrideDepth");

			Bind(program);
			program.SetUniform(this, "glo_GeoProjectOrigin", projectionCenter);
			program.SetUniform(this, "glo_GeoProjectMinPrecision", minPrecision);
			program.SetUniform(this, "glo_UniformColor", color);
			program.SetUniform(this, "glo_LineWidth", size);
			program.SetUniform(this, "glo_FragmentDepth", depth);

			DrawLines(program, v);
		}

		#endregion

		#region Line Strip

		private static Vertex3f[] GenerateStippleLines(Vertex2f[] v)
		{
			Vertex3f[] vStippled = new Vertex3f[v.Length];
			float vStippledLength = 0.0f;

			for (int i = 0; i < v.Length; ++i) {
				vStippled[i] = new Vertex3f(v[i].x, v[i].y, vStippledLength);
				if (i < v.Length - 1)
					vStippledLength += (v[i + 1] - v[i]).Module();
			}

			return vStippled;
		}

		/// <summary>
		/// Draw a line strip.
		/// </summary>
		/// <param name="program">
		/// The <see cref="ShaderProgram"/> used for drawing the points.
		/// </param>
		/// <param name="v">
		/// The position of the line strip vertices.
		/// </param>
		public void DrawLineStrip(ShaderProgram program, params Vertex2f[] v)
		{
			uint drawCommandOffset = _DrawBufferElementIndex2D;

			MapDrawBuffers2D();
			try {
				AddDrawVertices2D(v);
			} finally {
				UnmapDrawBuffers2D();
			}

			// Apply current state
			CurrentState.Apply(this, program);
			// Draw
			_DrawArrays2D.Draw(this, program, (int)PrimitiveElement.LineStrip, drawCommandOffset, (uint)v.Length);
		}

		/// <summary>
		/// Draw a line strip.
		/// </summary>
		/// <param name="program">
		/// The <see cref="ShaderProgram"/> used for drawing the points.
		/// </param>
		/// <param name="v">
		/// The position of the line strip vertices.
		/// </param>
		public void DrawLineStrip(ShaderProgram program, params Vertex3f[] v)
		{
			uint drawCommandOffset = _DrawBufferElementIndex3D;

			MapDrawBuffers3D();
			try {
				AddDrawVertices3D(v);
			} finally {
				UnmapDrawBuffers3D();
			}

			// Apply current state
			CurrentState.Apply(this, program);
			// Draw
			_DrawArrays3D.Draw(this, program, (int)PrimitiveElement.LineStrip, drawCommandOffset, (uint)v.Length);
		}

		/// <summary>
		/// Draw a line strip using the default shader.
		/// </summary>
		/// <param name="v"></param>
		/// <param name="width"></param>
		/// <param name="color"></param>
		public void DrawLineStrip(Vertex2f[] v, float width, ColorRGBAF color)
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.Line");

			Bind(program);
			program.SetUniform(this, "glo_LineWidth", width);
			program.SetUniform(this, "glo_UniformColor", color);

			DrawLineStrip(program, v);
		}

		/// <summary>
		/// Draw a line strip using the default shader.
		/// </summary>
		/// <param name="v"></param>
		/// <param name="width"></param>
		/// <param name="color"></param>
		/// <param name="depth"></param>
		public void DrawLineStripHalo(Vertex2f[] v, float width, float iwidth, ColorRGBAF color)
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.Line");

			Bind(program);

			program.SetUniform(this, "glo_LineWidth", width);
			program.SetUniform(this, "glo_UniformColor", ColorRGBAF.ColorBlack);
			DrawLineStrip(program, v);

			program.SetUniform(this, "glo_LineWidth", iwidth);
			program.SetUniform(this, "glo_UniformColor", color);
			DrawLineStrip(program, v);
		}

		/// <summary>
		/// Draw a line strip using the default shader.
		/// </summary>
		/// <param name="v"></param>
		/// <param name="width"></param>
		/// <param name="color"></param>
		/// <param name="depth"></param>
		public void DrawLineStrip(Vertex2f[] v, float width, ColorRGBAF color, float depth)
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.Line+OverrideDepth");

			Bind(program);
			program.SetUniform(this, "glo_LineWidth", width);
			program.SetUniform(this, "glo_UniformColor", color);
			program.SetUniform(this, "glo_FragmentDepth", depth);

			DrawLineStrip(program, v);
		}

		/// <summary>
		/// Draw a line strip using the default shader.
		/// </summary>
		/// <param name="v"></param>
		/// <param name="width"></param>
		/// <param name="color"></param>
		/// <param name="depth"></param>
		public void DrawLineStripHalo(Vertex2f[] v, float width, float iwidth, ColorRGBAF color, float depth)
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.Line+OverrideDepth");

			Bind(program);
			program.SetUniform(this, "glo_FragmentDepth", depth);

			program.SetUniform(this, "glo_LineWidth", width);
			program.SetUniform(this, "glo_UniformColor", ColorRGBAF.ColorBlack);
			DrawLineStrip(program, v);

			program.SetUniform(this, "glo_LineWidth", iwidth);
			program.SetUniform(this, "glo_UniformColor", color);
			DrawLineStrip(program, v);
		}

		/// <summary>
		/// Draw a stippled line strip using the default shader.
		/// </summary>
		/// <param name="v"></param>
		/// <param name="width"></param>
		/// <param name="color"></param>
		/// <param name="stipplePattern"></param>
		/// <param name="stippleFactor"></param>
		public void DrawLineStrip(Vertex3f[] v, float width, ColorRGBAF color, uint stipplePattern, float stippleFactor = 1.0f)
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.LineStipple");

			Bind(program);
			program.SetUniform(this, "glo_LineWidth", width);
			program.SetUniform(this, "glo_UniformColor", color);
			program.SetUniform(this, "glo_LineStipple", stipplePattern);
			program.SetUniform(this, "glo_LineStippleFactor", stippleFactor);

			DrawLineStrip(program, v);
		}

		/// <summary>
		/// Draw a stippled line strip using the default shader.
		/// </summary>
		/// <param name="v"></param>
		/// <param name="width"></param>
		/// <param name="color"></param>
		/// <param name="stipplePattern"></param>
		/// <param name="stippleFactor"></param>
		public void DrawLineStrip(Vertex3f[] v, float width, ColorRGBAF color, float depth, uint stipplePattern, float stippleFactor = 1.0f)
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.LineStipple+OverrideDepth");

			Bind(program);
			program.SetUniform(this, "glo_LineWidth", width);
			program.SetUniform(this, "glo_UniformColor", color);
			program.SetUniform(this, "glo_LineStipple", stipplePattern);
			program.SetUniform(this, "glo_LineStippleFactor", stippleFactor);
			program.SetUniform(this, "glo_FragmentDepth", depth);

			DrawLineStrip(program, v);
		}

		/// <summary>
		/// Draw a stippled line using the default shader;
		/// </summary>
		/// <param name="v"></param>
		/// <param name="width"></param>
		/// <param name="color"></param>
		/// <param name="stipplePattern"></param>
		/// <param name="stippleFactor"></param>
		public void DrawLineStrip(Vertex2f[] v, float width, ColorRGBAF color, uint stipplePattern, float stippleFactor = 1.0f)
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.LineStipple");

			Bind(program);
			program.SetUniform(this, "glo_LineWidth", width);
			program.SetUniform(this, "glo_UniformColor", color);
			program.SetUniform(this, "glo_LineStipple", stipplePattern);
			program.SetUniform(this, "glo_LineStippleFactor", stippleFactor);

			DrawLineStrip(program, GenerateStippleLines(v));
		}

		/// <summary>
		/// Draw a stippled line using the default shader;
		/// </summary>
		/// <param name="v"></param>
		/// <param name="width"></param>
		/// <param name="color"></param>
		/// <param name="stipplePattern"></param>
		/// <param name="stippleFactor"></param>
		public void DrawLineStrip(Vertex2f[] v, float width, ColorRGBAF color, float depth, uint stipplePattern, float stippleFactor = 1.0f)
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.LineStipple+OverrideDepth");

			Bind(program);
			program.SetUniform(this, "glo_LineWidth", width);
			program.SetUniform(this, "glo_UniformColor", color);
			program.SetUniform(this, "glo_LineStipple", stipplePattern);
			program.SetUniform(this, "glo_LineStippleFactor", stippleFactor);
			program.SetUniform(this, "glo_FragmentDepth", depth);

			DrawLineStrip(program, GenerateStippleLines(v));
		}

		/// <summary>
		/// Draw a stippled line using the default shader;
		/// </summary>
		/// <param name="v"></param>
		/// <param name="width"></param>
		/// <param name="iwidth"></param>
		/// <param name="color"></param>
		/// <param name="stipplePattern"></param>
		/// <param name="stippleFactor"></param>
		public void DrawLineStripHalo(Vertex2f[] v, float width, float iwidth, ColorRGBAF color, float depth, uint stipplePattern, float stippleFactor = 1.0f)
		{
			Vertex3f[] vStippled = GenerateStippleLines(v);

			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.LineStipple+OverrideDepth");

			Bind(program);
			
			program.SetUniform(this, "glo_LineStipple", stipplePattern);
			program.SetUniform(this, "glo_LineStippleFactor", stippleFactor);
			program.SetUniform(this, "glo_FragmentDepth", depth);

			program.SetUniform(this, "glo_LineWidth", width);
			program.SetUniform(this, "glo_UniformColor", ColorRGBAF.ColorBlack);
			DrawLineStrip(program, vStippled);

			program.SetUniform(this, "glo_LineWidth", iwidth);
			program.SetUniform(this, "glo_UniformColor", color);
			DrawLineStrip(program, vStippled);
		}

		#endregion

		#region Line Strip (Geographic Projection)

		public void DrawGeoLineStrip(Vertex2f[] v, Vertex2f projectionCenter, float minPrecision, float size, ColorRGBAF color, float depth, string projection = "Vincenty")
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram($"OpenGL.Line+{projection}Projection+OverrideDepth");

			Bind(program);
			program.SetUniform(this, "glo_GeoProjectOrigin", projectionCenter);
			program.SetUniform(this, "glo_GeoProjectMinPrecision", minPrecision);
			program.SetUniform(this, "glo_UniformColor", color);
			program.SetUniform(this, "glo_LineWidth", size);
			program.SetUniform(this, "glo_FragmentDepth", depth);

			DrawLineStrip(program, v);
		}

		#endregion

		#region Line Loop

		/// <summary>
		/// Draw a line loop.
		/// </summary>
		/// <param name="program">
		/// The <see cref="ShaderProgram"/> used for drawing the line.
		/// </param>
		/// <param name="a">
		/// The position of the line beginning.
		/// </param>
		/// <param name="b">
		/// The position of the line ending.
		/// </param>
		public void DrawLineLoop(ShaderProgram program, params Vertex2f[] v)
		{
			uint drawCommandOffset = _DrawBufferElementIndex2D;

			MapDrawBuffers2D();
			try {
				AddDrawVertices2D(v);
			} finally {
				UnmapDrawBuffers2D();
			}

			// Apply current state
			CurrentState.Apply(this, program);
			// Draw
			_DrawArrays2D.Draw(this, program, (int)PrimitiveElement.LineLoop, drawCommandOffset, (uint)v.Length);
		}

		/// <summary>
		/// Draw a line strip using the default shader.
		/// </summary>
		/// <param name="v"></param>
		/// <param name="width"></param>
		/// <param name="color"></param>
		public void DrawLineLoop(Vertex2f[] v, float width, ColorRGBAF color)
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.Line");

			Bind(program);
			program.SetUniform(this, "glo_LineWidth", width);
			program.SetUniform(this, "glo_UniformColor", color);

			DrawLineLoop(program, v);
		}

		/// <summary>
		/// Draw a line strip using the default shader.
		/// </summary>
		/// <param name="v"></param>
		/// <param name="width"></param>
		/// <param name="color"></param>
		/// <param name="depth"></param>
		public void DrawLineLoop(Vertex2f[] v, float width, ColorRGBAF color, float depth)
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.Line+OverrideDepth");

			Bind(program);
			program.SetUniform(this, "glo_LineWidth", width);
			program.SetUniform(this, "glo_UniformColor", color);
			program.SetUniform(this, "glo_FragmentDepth", depth);

			DrawLineLoop(program, v);
		}

		#endregion

		#region Triangle

		/// <summary>
		/// Draw a line.
		/// </summary>
		/// <param name="program">
		/// The <see cref="ShaderProgram"/> used for drawing the points.
		/// </param>
		/// <param name="a">
		/// The position of the line beginning.
		/// </param>
		/// <param name="b">
		/// The position of the line ending.
		/// </param>
		private void DrawTriangle(ShaderProgram program, bool filled, Vertex2f[] v)
		{
			uint drawCommandOffset = _DrawBufferElementIndex2D;

			MapDrawBuffers2D();
			try {
				AddDrawVertices2D(v);
			} finally {
				UnmapDrawBuffers2D();
			}

			// Apply current state
			CurrentState.Apply(this, program);
			// Draw
			_DrawArrays2D.Draw(this, program, filled ? (int)PrimitiveElement.Triangles : (int)PrimitiveElement.Lines, drawCommandOffset, (uint)v.Length);
		}

		/// <summary>
		/// Draw a set of points using the default shader.
		/// </summary>
		/// <param name="v">
		/// The positions of the points.
		/// </param>
		/// <param name="size">
		/// The size of the points, in pixels.
		/// </param>
		/// <param name="color">
		/// The color of the points.
		/// </param>
		public void DrawTriangle(Vertex2f[] v, float size, ColorRGBAF color, bool filled)
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.Standard");

			Bind(program);
			program.SetUniform(this, "glo_UniformColor", color);
			program.SetUniform(this, "glo_LineWidth", size);

			DrawTriangle(program, filled, v);
		}

		#endregion

		#region Triangle Fan

		/// <summary>
		/// Draw a trangle fan.
		/// </summary>
		/// <param name="program">
		/// The <see cref="ShaderProgram"/> used for drawing the points.
		/// </param>
		/// <param name="v">
		/// The position of the triangle fan vertices.
		/// </param>
		private void DrawTriangleFan(ShaderProgram program, Vertex2f[] v)
		{
			uint drawCommandOffset = _DrawBufferElementIndex2D;

			MapDrawBuffers2D();
			try {
				AddDrawVertices2D(v);
			} finally {
				UnmapDrawBuffers2D();
			}

			// Apply current state
			CurrentState.Apply(this, program);
			// Draw
			_DrawArrays2D.Draw(this, program, (int)PrimitiveElement.TriangleFan, drawCommandOffset, (uint)v.Length);
		}

		/// <summary>
		/// Draw a trangle fan. using the default shader.
		/// </summary>
		/// <param name="v">
		/// The position of the triangle fan vertices.
		/// </param>
		/// <param name="color"></param>
		/// <param name="depth"></param>
		public void DrawTriangleFan(Vertex2f[] v, ColorRGBAF color)
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.Standard");

			Bind(program);
			program.SetUniform(this, "glo_UniformColor", color);

			DrawTriangleFan(program, v);
		}

		/// <summary>
		/// Draw a trangle fan. using the default shader.
		/// </summary>
		/// <param name="v">
		/// The position of the triangle fan vertices.
		/// </param>
		/// <param name="color"></param>
		/// <param name="depth"></param>
		public void DrawTriangleFan(Vertex2f[] v, ColorRGBAF color, float depth)
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.Standard+OverrideDepth");

			Bind(program);
			program.SetUniform(this, "glo_UniformColor", color);
			program.SetUniform(this, "glo_FragmentDepth", depth);

			DrawTriangleFan(program, v);
		}

		#endregion

		#region Triangle Strip

		/// <summary>
		/// Draw a trangle strip.
		/// </summary>
		/// <param name="program">
		/// The <see cref="ShaderProgram"/> used for drawing the points.
		/// </param>
		/// <param name="v">
		/// The position of the triangle fan vertices.
		/// </param>
		private void DrawTriangleStrip(ShaderProgram program, Vertex2f[] v)
		{
			uint drawCommandOffset = _DrawBufferElementIndex2D;

			MapDrawBuffers2D();
			try {
				AddDrawVertices2D(v);
			} finally {
				UnmapDrawBuffers2D();
			}

			// Apply current state
			CurrentState.Apply(this, program);
			// Draw
			_DrawArrays2D.Draw(this, program, (int)PrimitiveElement.TriangleStrip, drawCommandOffset, (uint)v.Length);
		}

		/// <summary>
		/// Draw a trangle strip. using the default shader.
		/// </summary>
		/// <param name="v">
		/// The position of the triangle fan vertices.
		/// </param>
		/// <param name="color"></param>
		/// <param name="depth"></param>
		public void DrawTriangleStrip(Vertex2f[] v, ColorRGBAF color)
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.Standard");

			Bind(program);
			program.SetUniform(this, "glo_UniformColor", color);

			DrawTriangleStrip(program, v);
		}

		/// <summary>
		/// Draw a trangle strip. using the default shader.
		/// </summary>
		/// <param name="v">
		/// The position of the triangle fan vertices.
		/// </param>
		/// <param name="color"></param>
		/// <param name="depth"></param>
		public void DrawTriangleStrip(Vertex2f[] v, ColorRGBAF color, float depth)
		{
			// Note: to not reference program (shared resource kept in this context)
			ShaderProgram program = CreateProgram("OpenGL.Standard+OverrideDepth");

			Bind(program);
			program.SetUniform(this, "glo_UniformColor", color);
			program.SetUniform(this, "glo_FragmentDepth", depth);

			DrawTriangleStrip(program, v);
		}

		#endregion

		#region Rectangle

		/// <summary>
		/// Draw a rectangle. using the default shader.
		/// </summary>
		/// <param name="v">
		/// The position of the bottom left corner of the rectangle.
		/// </param>
		/// <param name="color"></param>
		/// <param name="depth"></param>
		public void DrawRectangle(Vertex2f v, float w, float h, ColorRGBAF color, float depth)
		{
			Vertex2f[] vertices = new Vertex2f[] {
				v,
				new Vertex2f(v.x + w, v.y),
				new Vertex2f(v.x + w, v.y + h),
				new Vertex2f(v.x, v.y + h)
			};

			DrawTriangleStrip(vertices, color, depth);
		}

		#endregion

		#region Circle

		private static Vertex2f[] GenerateCircle(Vertex2f origin, float r, uint subdivs)
		{
			return GenerateArcSector(origin, r, 0.0f, 360.0f, subdivs);
		}

		public void DrawCircle(Vertex2f origin, float r, uint subdivs, float width, ColorRGBAF color, float depth)
		{
			DrawLineLoop(GenerateCircle(origin, r, subdivs), width, color, depth);
		}

		#endregion

		#region Circle Sector

		private static Vertex2f[] GenerateCircleSector(Vertex2f origin, float r, float a0, float a1, uint subdivs)
		{
			Vertex2f[] v = new Vertex2f[1 + subdivs + 1];

			v[0] = origin;

			double d = (a0 < a1) ? Angle.ToRadians(a1 - a0) / subdivs : Angle.ToRadians(360.0f - (a0 - a1)) / subdivs;
			double v0 = Angle.ToRadians(a0);

			for (uint i = 0; i < subdivs + 1; ++i) {
				double a = v0 + d * i;
				v[i + 1] = origin + new Vertex2f((float)Math.Cos(a) * r, (float)Math.Sin(a) * r);
			}

			return v;
		}

		public void DrawCircleSector(Vertex2f origin, float r, uint subdivs, float a0, float a1, ColorRGBAF color)
		{
			DrawTriangleFan(GenerateCircleSector(origin, r, a0, a1, subdivs), color);
		}

		public void DrawCircleSector(Vertex2f origin, float r, uint subdivs, float a0, float a1, ColorRGBAF color, float depth)
		{
			DrawTriangleFan(GenerateCircleSector(origin, r, a0, a1, subdivs), color, depth);
		}

		#endregion

		#region Arc Sector

		private static Vertex2f[] GenerateArcSector(Vertex2f origin, float r, float a0, float a1, uint subdivs)
		{
			Vertex2f[] v = new Vertex2f[2 + subdivs + 1];

			v[0] = v[v.Length - 1] = origin;

			double d = Angle.ToRadians(a1 - a0) / subdivs;
			double v0 = Angle.ToRadians(a0);

			for (uint i = 0; i < subdivs + 1; ++i) {
				double a = v0 + d * i;
				v[i + 1] = origin + new Vertex2f((float)Math.Cos(a) * r, (float)Math.Sin(a) * r);
			}

			return v;
		}

		/// <summary>
		/// Draw an arc sector using the default shader.
		/// </summary>
		/// <param name="origin"></param>
		/// <param name="a0"></param>
		/// <param name="a1"></param>
		/// <param name="subdivs"></param>
		/// <param name="width"></param>
		/// <param name="color"></param>
		/// <param name="stipplePattern"></param>
		/// <param name="stippleFactor"></param>
		public void DrawArcSector(Vertex2f origin, float r, float a0, float a1, uint subdivs, float width, ColorRGBAF color, float depth)
		{
			DrawLineStrip(GenerateArcSector(origin, r, a0, a1, subdivs), width, color, depth);
		}

		/// <summary>
		/// Draw an arc sector using the default shader.
		/// </summary>
		/// <param name="origin"></param>
		/// <param name="a0"></param>
		/// <param name="a1"></param>
		/// <param name="subdivs"></param>
		/// <param name="width"></param>
		/// <param name="color"></param>
		/// <param name="stipplePattern"></param>
		/// <param name="stippleFactor"></param>
		public void DrawArcSectorHalo(Vertex2f origin, float r, float a0, float a1, uint subdivs, float width, float iwidth, ColorRGBAF color, float depth)
		{
			DrawLineStripHalo(GenerateArcSector(origin, r, a0, a1, subdivs), width, iwidth, color, depth);
		}

		/// <summary>
		/// Draw a stippled arc sector using the default shader.
		/// </summary>
		/// <param name="origin"></param>
		/// <param name="a0"></param>
		/// <param name="a1"></param>
		/// <param name="subdivs"></param>
		/// <param name="width"></param>
		/// <param name="color"></param>
		/// <param name="stipplePattern"></param>
		/// <param name="stippleFactor"></param>
		public void DrawArcSector(Vertex2f origin, float r, float a0, float a1, uint subdivs, float width, ColorRGBAF color, float depth, uint stipplePattern, float stippleFactor = 1.0f)
		{
			DrawLineStrip(GenerateArcSector(origin, r, a0, a1, subdivs), width, color, depth, stipplePattern, stippleFactor);
		}

		/// <summary>
		/// Draw a stippled arc sector using the default shader.
		/// </summary>
		/// <param name="origin"></param>
		/// <param name="a0"></param>
		/// <param name="a1"></param>
		/// <param name="subdivs"></param>
		/// <param name="width"></param>
		/// <param name="color"></param>
		/// <param name="stipplePattern"></param>
		/// <param name="stippleFactor"></param>
		public void DrawArcSectorHalo(Vertex2f origin, float r, float a0, float a1, uint subdivs, float width, float iwidth, ColorRGBAF color, float depth, uint stipplePattern, float stippleFactor = 1.0f)
		{
			DrawLineStripHalo(GenerateArcSector(origin, r, a0, a1, subdivs), width, iwidth, color, depth, stipplePattern, stippleFactor);
		}

		#endregion

		#region Buffer Mapping

		/// <summary>
		/// Map the drawing buffers.
		/// </summary>
		private void MapDrawBuffers2D()
		{
			if (!Extensions.BufferStorage_ARB || !_DrawPositions2D.Immutable)
				_DrawPositions2D.Map(this, BufferAccess.WriteOnly);
		}

		/// <summary>
		/// Map the drawing buffers.
		/// </summary>
		private void MapDrawBuffers3D()
		{
			if (!Extensions.BufferStorage_ARB || !_DrawPositions3D.Immutable)
				_DrawPositions3D.Map(this, BufferAccess.WriteOnly);
		}

		/// <summary>
		/// Map the drawing buffers.
		/// </summary>
		private void MapDrawBuffers2DHP()
		{
			if (_DrawPositions2DHP != null) {
				if (!Extensions.BufferStorage_ARB || !_DrawPositions2DHP.Immutable)
					_DrawPositions2DHP.Map(this, BufferAccess.WriteOnly);
			} else
				MapDrawBuffers2D();
		}

		/// <summary>
		/// Store vertices in the mapped buffer.
		/// </summary>
		/// <param name="vertices"></param>
		private void AddDrawVertices2D(params Vertex2f[] vertices)
		{
			Debug.Assert(_DrawPositions2D.IsMapped);

			if (_DrawBufferElementIndex2D + vertices.Length > _DrawPositions2D.GpuItemsCount)
				ReallocDrawResources2D(_DrawPositions2D.GpuItemsCount + _DefaultDrawElementsCount);

			unsafe
			{
				Vertex2f* mappedVertices = (Vertex2f*)_DrawPositions2D.MappedBuffer;
				Vertex2f* positionPtr = mappedVertices + _DrawBufferElementIndex2D;

				fixed (Vertex2f* sourcePtr = vertices) {
					Unsafe.CopyBlock(positionPtr, sourcePtr, (uint)(vertices.Length * Vertex2f.Size));
				}
			}

			_DrawBufferElementIndex2D += (uint)vertices.Length;
		}

		/// <summary>
		/// Store vertices in the mapped buffer.
		/// </summary>
		/// <param name="vertices"></param>
		private void AddDrawVertices3D(params Vertex3f[] vertices)
		{
			Debug.Assert(_DrawPositions3D.IsMapped);

			if (_DrawBufferElementIndex3D + vertices.Length > _DrawPositions3D.GpuItemsCount)
				ReallocDrawResources3D(_DrawPositions3D.GpuItemsCount + _DefaultDrawElementsCount);

			unsafe
			{
				Vertex3f* mappedVertices = (Vertex3f*)_DrawPositions3D.MappedBuffer;
				Vertex3f* positionPtr = mappedVertices + _DrawBufferElementIndex3D;

				fixed (Vertex3f* sourcePtr = vertices) {
					Unsafe.CopyBlock(positionPtr, sourcePtr, (uint)(vertices.Length * Vertex3f.Size));
				}
			}

			_DrawBufferElementIndex3D += (uint)vertices.Length;
		}

		/// <summary>
		/// Store vertices in the mapped buffer.
		/// </summary>
		/// <param name="vertices"></param>
		private void AddDrawVertices2DHP(params Vertex2d[] vertices)
		{
			if (_DrawPositions2DHP != null) {
				Debug.Assert(_DrawPositions2DHP.IsMapped);

				if (_DrawBufferElementIndex2DHP + vertices.Length > _DrawPositions2DHP.GpuItemsCount)
					ReallocDrawResources2D(_DrawPositions2DHP.GpuItemsCount + _DefaultDrawElementsCount);

				unsafe
				{
					Vertex2d* mappedVertices = (Vertex2d*)_DrawPositions2DHP.MappedBuffer;
					Vertex2d* positionPtr = mappedVertices + _DrawBufferElementIndex2DHP;

					fixed (Vertex2d* sourcePtr = vertices) {
						Unsafe.CopyBlock(positionPtr, sourcePtr, (uint)(vertices.Length * Vertex2d.Size));
					}
				}

				_DrawBufferElementIndex2DHP += (uint)vertices.Length;
			} else
				AddDrawVertices2D(Array.ConvertAll(vertices, (item) => (Vertex2f)item));
		}

		/// <summary>
		/// Unmap 3D drawing buffers.
		/// </summary>
		private void UnmapDrawBuffers2D()
		{
			if (!Extensions.BufferStorage_ARB || !_DrawPositions2D.Immutable)
				_DrawPositions2D.Unmap(this);
		}

		/// <summary>
		/// Unmap 3D drawing buffers.
		/// </summary>
		private void UnmapDrawBuffers3D()
		{
			if (!Extensions.BufferStorage_ARB || !_DrawPositions3D.Immutable)
				_DrawPositions3D.Unmap(this);
		}

		/// <summary>
		/// Unmap 2D drawing buffers (double-precision).
		/// </summary>
		private void UnmapDrawBuffers2DHP()
		{
			if (_DrawPositions2DHP != null) {
				if (!Extensions.BufferStorage_ARB || !_DrawPositions2D.Immutable)
					_DrawPositions2DHP.Unmap(this);
			} else
				UnmapDrawBuffers2D();
		}

		#endregion

		#endregion
	}
}
