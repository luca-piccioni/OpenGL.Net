
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
using System.Collections.Generic;

namespace OpenGL.Objects
{
	/// <summary>
	/// A collection of vertex arrays and vertex indices.
	/// </summary>
	public class VertexMesh : VertexArrays
	{
		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public VertexMesh()
		{

		}

		/// <summary>
		/// Construct a VertexMesh with the default shader variant.
		/// </summary>
		public VertexMesh(string shaderPostfix)
		{
			if (shaderPostfix == null)
				throw new ArgumentNullException(nameof(shaderPostfix));

			_DefaultPolygonProgram += $"+{shaderPostfix}";
			_DefaultLineProgram += $"+{shaderPostfix}";
			_DefaultLineStippleProgram += $"+{shaderPostfix}";
		}

		#endregion

		#region Section Builder

		/// <summary>
		/// A section of the VertexArrayMesh with vertices information.
		/// </summary>
		/// <remarks>
		/// This class is used only for building the graphical resources required for rendering the mesh.
		/// </remarks>
		private class MeshSectionDefinition : MeshSection
		{
			#region Constructors

			/// <summary>
			/// Construct a MeshSectionDefinition specifying the type of the primitive to be drawn.
			/// </summary>
			/// <param name="primitive">
			/// A <see cref="PrimitiveType"/> that specifies how vertices data is drawn.
			/// </param>
			/// <param name="programID">
			/// The identifier of the <see cref="ShaderProgram"/> used for drawing the mesh section.
			/// </param>
			public MeshSectionDefinition(PrimitiveType primitive, string programID)
				: base(primitive)
			{
				if (programID == null)
					throw new ArgumentNullException(nameof(programID));
				ProgramID = programID;
			}

			#endregion

			#region Vertex Information

			/// <summary>
			/// Identifier of the ShaderProgram drawing the mesh section.
			/// </summary>
			public readonly string ProgramID;

			/// <summary>
			/// Positions vertex array data.
			/// </summary>
			public readonly List<Vertex3f> PositionVertexData = new List<Vertex3f>();

			#endregion
		}

		/// <summary>
		/// Context used to batch mesh primitives.
		/// </summary>
		private class MeshSectionContext
		{
			#region Context Information

			/// <summary>
			/// Sections defined by this MeshSectionContext.
			/// </summary>
			public readonly List<MeshSectionDefinition> Sections = new List<MeshSectionDefinition>();

			/// <summary>
			/// Get the flag indicating whether any state has changed.
			/// </summary>
			public bool IsDirty => CurrentColorDirty || CurrentLineWidthDirty || CurrentLineStippleDirty;

			/// <summary>
			/// Reset the flags indicating whether some state has changed.
			/// </summary>
			public void ResetDirtyFlags()
			{
				CurrentColorDirty = false;
				CurrentLineWidthDirty = false;
				CurrentLineStippleDirty = false;
			}

			/// <summary>
			/// Current color tracking field.
			/// </summary>
			public ColorRGBAF? CurrentColor;

			/// <summary>
			/// Flag indicating whether <see cref="CurrentColor"/> has been changed.
			/// </summary>
			public bool CurrentColorDirty = true;

			/// <summary>
			/// Current line width tracking field.
			/// </summary>
			public float CurrentLineWidth = 1.0f;

			/// <summary>
			/// Flag indicating whether <see cref="CurrentLineWidth"/> has been changed.
			/// </summary>
			public bool CurrentLineWidthDirty = true;

			/// <summary>
			/// Current line stipple pattern factor.
			/// </summary>
			public int CurrentLineStippleFactor = 1;

			/// <summary>
			/// Current line stipple pattern.
			/// </summary>
			public ushort CurrentLineStipplePattern = 0xFFFF;

			/// <summary>
			/// Flag indicating whether <see cref="CurrentLineStippleFactor"/> or <see cref="CurrentLineStipplePattern"/> have been changed.
			/// </summary>
			public bool CurrentLineStippleDirty = true;

			/// <summary>
			/// Factor used for scaling mesh vertices.
			/// </summary>
			public float CurrentScale = 1.0f;

			#endregion
		}

		/// <summary>
		/// Begin the definition of this VertexArrayMesh.
		/// </summary>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the method is called between <see cref="BeginDefinition()"/> and <see cref="EndDefinition"/>.
		/// </exception>
		public void BeginDefinition()
		{
			BeginDefinition(1.0f);
		}

		/// <summary>
		/// Begin the definition of this VertexArrayMesh.
		/// </summary>
		/// <param name="scaleFactor">
		/// A <see cref="float"/> that specifies the scale factor applied to the vertices included in the current definition.
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the method is called between <see cref="BeginDefinition()"/> and <see cref="EndDefinition"/>.
		/// </exception>
		public void BeginDefinition(float scaleFactor)
		{
			if (_MeshContext != null)
				throw new InvalidOperationException("already in definition state");
			_MeshContext = new MeshSectionContext();
			SetDefinitionScale(scaleFactor);
		}

		/// <summary>
		/// End the definition of this VertexArrayMesh.
		/// </summary>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the method is called before <see cref="BeginDefinition()"/>.
		/// </exception>
		public void EndDefinition(GraphicsContext ctx)
		{
			if (_MeshContext == null)
				throw new InvalidOperationException("not in definition state");

			// Generate mesh sections
			List<MeshSection> runtimeSections = new List<MeshSection>(_MeshContext.Sections.Count);
			List<Vertex3f> positionArray = new List<Vertex3f>();

			foreach (MeshSectionDefinition section in _MeshContext.Sections) {
				// Define runtime section
				MeshSection runtimeSection = new MeshSection(section.PrimitiveType);

				runtimeSection.Program = ctx.CreateProgram(section.ProgramID);
				runtimeSection.Program.IncRef();

				runtimeSection.Color = section.Color;
				runtimeSection.PointSize = section.PointSize;
				runtimeSection.LineWidth = section.LineWidth;
				runtimeSection.LineStippleFactor = section.LineStippleFactor;
				runtimeSection.LineStipplePattern = section.LineStipplePattern;
				runtimeSection.ElementsIndex = (uint)DrawElements.Count;
				runtimeSections.Add(runtimeSection);

				// Define runtime section elements
				SetElementArray(section.PrimitiveType, (uint)positionArray.Count, (uint)section.PositionVertexData.Count);

				// Define buffer object data for runtime section
				positionArray.AddRange(section.PositionVertexData);
			}

			// Define vertex array data
			ArrayBuffer<Vertex3f> vertexArrayPosition = new ArrayBuffer<Vertex3f>(BufferUsage.StaticDraw);
			vertexArrayPosition.Immutable = false;
			vertexArrayPosition.Create(positionArray.ToArray());

			SetArray(vertexArrayPosition, VertexArraySemantic.Position);

			// Set sections to be rendered
			_VertexArraySection.AddRange(runtimeSections);

			// Not in definition state anymore 
			_MeshContext = null;

			// Implicitly create resources
			Create(ctx);
		}

		/// <summary>
		/// Set the scale factor for the current definition.
		/// </summary>
		/// <param name="factor">
		/// A <see cref="float"/> that specifies the scale factor applied to the vertices included in the current definition.
		/// </param>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="factor"/> is zero or negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the method is called before <see cref="BeginDefinition(string)"/>.
		/// </exception>
		public void SetDefinitionScale(float factor)
		{
			if (factor <= 0.0f)
				throw new ArgumentOutOfRangeException(nameof(factor), "zero or negative values are not allowed");
			if (_MeshContext == null)
				throw new InvalidOperationException("not in definition state");

			_MeshContext.CurrentScale = factor;
		}

		#region States

		/// <summary>
		/// Set the color used for the next primitives defined.
		/// </summary>
		/// <param name="color">
		/// A <see cref="ColorRGBAF"/> that specifies the primitive color.
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the method is not called between <see cref="BeginDefinition()"/> and <see cref="EndDefinition"/>.
		/// </exception>
		public void SetCurrentColor(ColorRGBAF color)
		{
			if (_MeshContext == null)
				throw new InvalidOperationException("not in definition state");

			if (!_MeshContext.CurrentColor.HasValue || _MeshContext.CurrentColor.Value.Equals(color) == false) {
				_MeshContext.CurrentColor = color;
				_MeshContext.CurrentColorDirty = true;
			}
		}

		/// <summary>
		/// Reset the color used for the next primitives defined.
		/// </summary>
		/// <remarks>
		/// It is supposed that users will call <see cref="Draw(GraphicsContext, ColorRGBAF?)"/> specifying a color when it is unknown.
		/// </remarks>
		public void ResetCurrentColor()
		{
			if (_MeshContext == null)
				throw new InvalidOperationException("not in definition state");

			_MeshContext.CurrentColorDirty |= _MeshContext.CurrentColor.HasValue;
			_MeshContext.CurrentColor = null;
		}

		/// <summary>
		/// Set the line width used for the next primitives defined.
		/// </summary>
		/// <param name="width">
		/// A <see cref="float"/> that specifies the line width, in pixels.
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the method is not called between <see cref="BeginDefinition()"/> and <see cref="EndDefinition"/>.
		/// </exception>
		public void SetLineWidth(float width)
		{
			if (_MeshContext == null)
				throw new InvalidOperationException("not in definition state");

			if (Math.Abs(_MeshContext.CurrentLineWidth - width) >= float.Epsilon) {
				_MeshContext.CurrentLineWidth = width;
				_MeshContext.CurrentLineWidthDirty = true;
			}
		}

		public void SetLineStipple(int factor, ushort pattern)
		{
			if (_MeshContext == null)
				throw new InvalidOperationException("not in definition state");

			if (_MeshContext.CurrentLineStippleFactor != factor || _MeshContext.CurrentLineStipplePattern != pattern) {
				_MeshContext.CurrentLineStippleFactor = factor;
				_MeshContext.CurrentLineStipplePattern = pattern;
				_MeshContext.CurrentLineStippleDirty = true;
			}
		}

		public void ResetLineStipple()
		{
			SetLineStipple(1, 0xFFFF);
		}

		public void SetLineStipple(ushort pattern)
		{
			SetLineStipple(1, pattern);
		}

		#endregion

		#region Lines

		/// <summary>
		/// Define a single line.
		/// </summary>
		/// <param name="x1">
		/// A <see cref="float"/> that specifies the X coordinate of the begin point of the line.
		/// </param>
		/// <param name="y1">
		/// A <see cref="float"/> that specifies the Y coordinate of the begin point of the line.
		/// </param>
		/// <param name="x2">
		/// A <see cref="float"/> that specifies the X coordinate of the end point of the line.
		/// </param>
		/// <param name="y2">
		/// A <see cref="float"/> that specifies the Y coordinate of the end point of the line.
		/// </param>
		/// <param name="programId">
		/// The identifier of the program used to draw the geometry. If null, defaults to "OpenGL.Line"
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the method is not called between <see cref="BeginDefinition()"/> and <see cref="EndDefinition"/>.
		/// </exception>
		public void DefineLine(float x1, float y1, float x2, float y2, string programId = null)
		{
			if (_MeshContext == null)
				throw new InvalidOperationException("not in definition state");

			MeshSectionDefinition section = GetCurrentSection(PrimitiveType.Lines, programId);

			Vertex3f v1 = new Vertex3f(x1 * _MeshContext.CurrentScale, y1 * _MeshContext.CurrentScale, 0.0f);
			Vertex3f v2 = new Vertex3f(x2 * _MeshContext.CurrentScale, y2 * _MeshContext.CurrentScale, 0.0f);

			if (section.IsLineDashed)
				v2.z = (v2 - v1).Module();

			section.PositionVertexData.Add(v1);
			section.PositionVertexData.Add(v2);
		}

		/// <summary>
		/// Define a line strip.
		/// </summary>
		/// <param name="coords">
		/// A variable list of <see cref="float"/>, that specifies the X/Y coordinates of the points composing
		/// the line strip.
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the method is not called between <see cref="BeginDefinition()"/> and <see cref="EndDefinition"/>.
		/// </exception>
		public void DefineLineStrip(params float[] coords)
		{
			DefineLineStrip(null, coords);
		}

		/// <summary>
		/// Define a line strip.
		/// </summary>
		/// <param name="coords">
		/// A variable list of <see cref="float"/>, that specifies the X/Y coordinates of the points composing
		/// the line strip.
		/// </param>
		/// <param name="programId">
		/// The identifier of the program used to draw the geometry. If null, defaults to "OpenGL.Line"
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the method is not called between <see cref="BeginDefinition()"/> and <see cref="EndDefinition"/>.
		/// </exception>
		public void DefineLineStrip(string programId, params float[] coords)
		{
			if (_MeshContext == null)
				throw new InvalidOperationException("not in definition state");

			MeshSectionDefinition section = GetCurrentSection(PrimitiveType.Lines, programId);
			float distance = 0.0f;

			for (int i = 0; i < coords.Length - 2; i += 2) {
				Vertex3f v1 = new Vertex3f(coords[i + 0] * _MeshContext.CurrentScale, coords[i + 1] * _MeshContext.CurrentScale, 0.0f);
				Vertex3f v2 = new Vertex3f(coords[i + 2] * _MeshContext.CurrentScale, coords[i + 3] * _MeshContext.CurrentScale, 0.0f);

				if (section.IsLineDashed) {
					float lineDistance = (v2 - v1).Module();

					v1.z = distance;
					v2.z = distance + lineDistance;

					distance += lineDistance;
				}

				section.PositionVertexData.Add(v1);
				section.PositionVertexData.Add(v2);
			}
		}

		/// <summary>
		/// Define a line loop.
		/// </summary>
		/// <param name="coords">
		/// A variable list of <see cref="float"/>, that specifies the X/Y coordinates of the points composing
		/// the line loop.
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the method is not called between <see cref="BeginDefinition()"/> and <see cref="EndDefinition"/>.
		/// </exception>
		public void DefineLineLoop(params float[] coords)
		{
			DefineLineLoop(null, coords);
		}

		/// <summary>
		/// Define a line loop.
		/// </summary>
		/// <param name="coords">
		/// A variable list of <see cref="float"/>, that specifies the X/Y coordinates of the points composing
		/// the line loop.
		/// </param>
		/// <param name="programId">
		/// The identifier of the program used to draw the geometry. If null, defaults to "OpenGL.Line"
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the method is not called between <see cref="BeginDefinition()"/> and <see cref="EndDefinition"/>.
		/// </exception>
		public void DefineLineLoop(string programId, params float[] coords)
		{
			if (_MeshContext == null)
				throw new InvalidOperationException("not in definition state");

			MeshSectionDefinition section = GetCurrentSection(PrimitiveType.Lines, programId);
			int coordsLength = coords.Length / 2 * 2 - 2;
			float distance = 0.0f;

			for (int i = 0; i < coordsLength; i += 2) {
				Vertex3f v1 = new Vertex3f(coords[i + 0] * _MeshContext.CurrentScale, coords[i + 1] * _MeshContext.CurrentScale, 0.0f);
				Vertex3f v2 = new Vertex3f(coords[i + 2] * _MeshContext.CurrentScale, coords[i + 3] * _MeshContext.CurrentScale, 0.0f);

				if (section.IsLineDashed) {
					float lineDistance = (v2 - v1).Module();

					v1.z = distance;
					v2.z = distance + lineDistance;

					distance += lineDistance;
				}

				section.PositionVertexData.Add(v1);
				section.PositionVertexData.Add(v2);
			}

			Vertex3f v1loop = new Vertex3f(coords[coordsLength + 0] * _MeshContext.CurrentScale, coords[coordsLength + 1] * _MeshContext.CurrentScale, 0.0f);
			Vertex3f v2loop = new Vertex3f(coords[0] * _MeshContext.CurrentScale, coords[1] * _MeshContext.CurrentScale, 0.0f);

			if (section.IsLineDashed) {
				float lineDistance = (v2loop - v1loop).Module();

				v1loop.z = distance;
				v2loop.z = distance + lineDistance;
			}

			section.PositionVertexData.Add(v1loop);
			section.PositionVertexData.Add(v2loop);
		}

		#endregion

		#region Triangles

		/// <summary>
		/// Define a single triangle.
		/// </summary>
		/// <param name="x1">
		/// A <see cref="float"/> that specifies the X coordinate of the 1th point of the triangle.
		/// </param>
		/// <param name="y1">
		/// A <see cref="float"/> that specifies the Y coordinate of the 1th point of the triangle.
		/// </param>
		/// <param name="x2">
		/// A <see cref="float"/> that specifies the X coordinate of the 2th point of the triangle.
		/// </param>
		/// <param name="y2">
		/// A <see cref="float"/> that specifies the Y coordinate of the 2th point of the triangle.
		/// </param>
		/// <param name="x3">
		/// A <see cref="float"/> that specifies the X coordinate of the 3th point of the triangle.
		/// </param>
		/// <param name="y3">
		/// A <see cref="float"/> that specifies the Y coordinate of the 3th point of the triangle.
		/// </param>
		/// <param name="filled">
		/// A <see cref="Boolean"/> that specifies whether the triangle is filled or not.
		/// </param>
		/// <param name="programId">
		/// The identifier of the program used to draw the geometry. If null, defaults to "OpenGL.Line"
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the method is not called between <see cref="BeginDefinition()"/> and <see cref="EndDefinition"/>.
		/// </exception>
		public void DefineTriangle(float x1, float y1, float x2, float y2, float x3, float y3, bool filled, string programId = null)
		{
			if (_MeshContext == null)
				throw new InvalidOperationException("not in definition state");

			if (filled == false) {
				MeshSectionDefinition section = GetCurrentSection(PrimitiveType.Lines, programId);
				

				Vertex3f v1 = new Vertex3f(x1 * _MeshContext.CurrentScale, y1 * _MeshContext.CurrentScale, 0.0f);
				Vertex3f v2 = new Vertex3f(x2 * _MeshContext.CurrentScale, y2 * _MeshContext.CurrentScale, 0.0f);
				Vertex3f v3 = new Vertex3f(x3 * _MeshContext.CurrentScale, y3 * _MeshContext.CurrentScale, 0.0f);

				if (section.IsLineDashed) {
					float distance2 = (v2 - v1).Module();
					float distance3 = (v3 - v1).Module();

					v2.z = distance2;
					v3.z = distance2 + distance3;
				}

				section.PositionVertexData.Add(v1);
				section.PositionVertexData.Add(v2);

				section.PositionVertexData.Add(v2);
				section.PositionVertexData.Add(v3);

				section.PositionVertexData.Add(v3);
				section.PositionVertexData.Add(v1);
			} else {
				MeshSectionDefinition section = GetCurrentSection(PrimitiveType.Triangles, programId);

				section.PositionVertexData.Add((Vertex3f)new Vertex2f(x1 * _MeshContext.CurrentScale, y1 * _MeshContext.CurrentScale));
				section.PositionVertexData.Add((Vertex3f)new Vertex2f(x2 * _MeshContext.CurrentScale, y2 * _MeshContext.CurrentScale));
				section.PositionVertexData.Add((Vertex3f)new Vertex2f(x3 * _MeshContext.CurrentScale, y3 * _MeshContext.CurrentScale));
			}
		}

		public void DefineTrapezium(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4, bool filled, string programId = null)
		{
			if (_MeshContext == null)
				throw new InvalidOperationException("not in definition state");

			if (filled == false) {
				MeshSectionDefinition section = GetCurrentSection(PrimitiveType.Lines, programId);


				Vertex3f v1 = new Vertex3f(x1 * _MeshContext.CurrentScale, y1 * _MeshContext.CurrentScale, 0.0f);
				Vertex3f v2 = new Vertex3f(x2 * _MeshContext.CurrentScale, y2 * _MeshContext.CurrentScale, 0.0f);
				Vertex3f v3 = new Vertex3f(x3 * _MeshContext.CurrentScale, y3 * _MeshContext.CurrentScale, 0.0f);
				Vertex3f v4 = new Vertex3f(x4 * _MeshContext.CurrentScale, y4 * _MeshContext.CurrentScale, 0.0f);

				section.PositionVertexData.Add(v1);
				section.PositionVertexData.Add(v2);

				section.PositionVertexData.Add(v2);
				section.PositionVertexData.Add(v3);

				section.PositionVertexData.Add(v3);
				section.PositionVertexData.Add(v4);

				section.PositionVertexData.Add(v4);
				section.PositionVertexData.Add(v1);

			} else {
				MeshSectionDefinition section = GetCurrentSection(PrimitiveType.Triangles, programId);

				section.PositionVertexData.Add((Vertex3f)new Vertex2f(x1 * _MeshContext.CurrentScale, y1 * _MeshContext.CurrentScale));
				section.PositionVertexData.Add((Vertex3f)new Vertex2f(x2 * _MeshContext.CurrentScale, y2 * _MeshContext.CurrentScale));
				section.PositionVertexData.Add((Vertex3f)new Vertex2f(x3 * _MeshContext.CurrentScale, y3 * _MeshContext.CurrentScale));
				section.PositionVertexData.Add((Vertex3f)new Vertex2f(x4 * _MeshContext.CurrentScale, y4 * _MeshContext.CurrentScale));
			}
		}

		/// <summary>
		/// Define a triangle strip.
		/// </summary>
		/// <param name="coords">
		/// A variable list of <see cref="float"/>, that specifies the X/Y coordinates of the points composing
		/// the triangle strip.
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the method is not called between <see cref="BeginDefinition()"/> and <see cref="EndDefinition"/>.
		/// </exception>
		public void DefineTriangleStrip(params float[] coords)
		{
			DefineTriangleStrip(null, coords);
		}

		/// <summary>
		/// Define a triangle strip.
		/// </summary>
		/// <param name="coords">
		/// A variable list of <see cref="float"/>, that specifies the X/Y coordinates of the points composing
		/// the triangle strip.
		/// </param>
		/// <param name="programId">
		/// The identifier of the program used to draw the geometry. If null, defaults to "OpenGL.Line"
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the method is not called between <see cref="BeginDefinition()"/> and <see cref="EndDefinition"/>.
		/// </exception>
		public void DefineTriangleStrip(string programId, params float[] coords)
		{
			if (_MeshContext == null)
				throw new InvalidOperationException("not in definition state");

			MeshSectionDefinition section = GetCurrentSection(PrimitiveType.TriangleStrip, programId);
			int coordsLength = coords.Length / 2 * 2;

			for (int i = 0; i < coordsLength; i += 2)
				section.PositionVertexData.Add((Vertex3f)new Vertex2f(coords[i+0] * _MeshContext.CurrentScale, coords[i+1] * _MeshContext.CurrentScale));
		}

		/// <summary>
		/// Define a triangle fan.
		/// </summary>
		/// <param name="coords">
		/// A variable list of <see cref="float"/>, that specifies the X/Y coordinates of the points composing
		/// the triangle fan.
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the method is not called between <see cref="BeginDefinition()"/> and <see cref="EndDefinition"/>.
		/// </exception>
		public void DefineTriangleFan(params float[] coords)
		{
			DefineTriangleFan(null, coords);
		}

		/// <summary>
		/// Define a triangle fan.
		/// </summary>
		/// <param name="coords">
		/// A variable list of <see cref="float"/>, that specifies the X/Y coordinates of the points composing
		/// the triangle fan.
		/// </param>
		/// <param name="programId">
		/// The identifier of the program used to draw the geometry. If null, defaults to "OpenGL.Line"
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the method is not called between <see cref="BeginDefinition()"/> and <see cref="EndDefinition"/>.
		/// </exception>
		public void DefineTriangleFan(string programId, params float[] coords)
		{
			if (_MeshContext == null)
				throw new InvalidOperationException("not in definition state");

			MeshSectionDefinition section = GetCurrentSection(PrimitiveType.TriangleFan, programId);
			int coordsLength = coords.Length / 2 * 2;

			for (int i = 0; i < coordsLength; i += 2)
				section.PositionVertexData.Add((Vertex3f)new Vertex2f(coords[i+0] * _MeshContext.CurrentScale, coords[i+1] * _MeshContext.CurrentScale));
		}

		#endregion

		#region Quadrilaterals

		/// <summary>
		/// Define a rectangle.
		/// </summary>
		/// <param name="x">
		/// A <see cref="float"/> that specifies the X coordinate of the lower-left corner of the rectangle.
		/// </param>
		/// <param name="y">
		/// A <see cref="float"/> that specifies the Y coordinate of the lower-left corner of the rectangle.
		/// </param>
		/// <param name="width">
		/// A <see cref="float"/> that specifies the width of the rectangle.
		/// </param>
		/// <param name="height">
		/// A <see cref="float"/> that specifies the height of the rectangle.
		/// </param>
		/// <param name="filled">
		/// A <see cref="Boolean"/> that specifies whether the triangle is filled or not.
		/// </param>
		/// <param name="programId">
		/// The identifier of the program used to draw the geometry. If null, defaults to "OpenGL.Line"
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the method is not called between <see cref="BeginDefinition()"/> and <see cref="EndDefinition"/>.
		/// </exception>
		public void DefineRectangle(float x, float y, float width, float height, bool filled, string programId = null)
		{
			if (_MeshContext == null)
				throw new InvalidOperationException("not in definition state");

			float x0 = x, x1 = x + width;
			float y0 = y, y1 = y + height;

			if (filled == false) {
				MeshSectionDefinition section = GetCurrentSection(PrimitiveType.Lines, programId);

				Vertex3f v00 = new Vertex3f(x0 * _MeshContext.CurrentScale, y0 * _MeshContext.CurrentScale, 0.0f);
				Vertex3f v10 = new Vertex3f(x1 * _MeshContext.CurrentScale, y0 * _MeshContext.CurrentScale, 0.0f);
				Vertex3f v01 = new Vertex3f(x0 * _MeshContext.CurrentScale, y1 * _MeshContext.CurrentScale, 0.0f);
				Vertex3f v11 = new Vertex3f(x1 * _MeshContext.CurrentScale, y1 * _MeshContext.CurrentScale, 0.0f);
				Vertex3f v22 = v00;		// Closing polygon

				if (section.IsLineDashed) {
					float distance10 = (v10 - v00).Module();
					float distance11 = (v11 - v10).Module();
					float distance01 = (v01 - v11).Module();
					float distance22 = (v11 - v00).Module();

					v10.z = v00.z + distance10;
					v11.z = v10.z + distance11;
					v01.z = v11.z + distance01;
					v22.z = v01.z + distance22;
				}

				section.PositionVertexData.Add(v00);
				section.PositionVertexData.Add(v10);

				section.PositionVertexData.Add(v10);
				section.PositionVertexData.Add(v11);

				section.PositionVertexData.Add(v11);
				section.PositionVertexData.Add(v01);

				section.PositionVertexData.Add(v01);
				section.PositionVertexData.Add(v22);
			} else {
				MeshSectionDefinition section = GetCurrentSection(PrimitiveType.Triangles, programId);

				section.PositionVertexData.Add((Vertex3f)new Vertex2f(x0 * _MeshContext.CurrentScale, y0 * _MeshContext.CurrentScale));
				section.PositionVertexData.Add((Vertex3f)new Vertex2f(x1 * _MeshContext.CurrentScale, y0 * _MeshContext.CurrentScale));
				section.PositionVertexData.Add((Vertex3f)new Vertex2f(x0 * _MeshContext.CurrentScale, y1 * _MeshContext.CurrentScale));

				section.PositionVertexData.Add((Vertex3f)new Vertex2f(x0 * _MeshContext.CurrentScale, y1 * _MeshContext.CurrentScale));
				section.PositionVertexData.Add((Vertex3f)new Vertex2f(x1 * _MeshContext.CurrentScale, y0 * _MeshContext.CurrentScale));
				section.PositionVertexData.Add((Vertex3f)new Vertex2f(x1 * _MeshContext.CurrentScale, y1 * _MeshContext.CurrentScale));
			}
		}

		#endregion

		#region Quadratics

		/// <summary>
		/// Define an arc based on circle.
		/// </summary>
		/// <param name="cx">
		/// A <see cref="float"/> that specifies the X coordinate of the center of the arc.
		/// </param>
		/// <param name="cy">
		/// A <see cref="float"/> that specifies the Y coordinate of the center of the arc.
		/// </param>
		/// <param name="radius">
		/// A <see cref="float"/> that specifies the radius of the arc.
		/// </param>
		/// <param name="beginAngle">
		/// A <see cref="float"/> tha specifies the begin angle of the arc, in degrees.
		/// </param>
		/// <param name="endAngle">
		/// A <see cref="float"/> tha specifies the end angle of the arc, in degrees.
		/// </param>
		/// <param name="filled">
		/// A <see cref="Boolean"/> that specifies whether the arc is filled or not.
		/// </param>
		/// <param name="programId">
		/// The identifier of the program used to draw the geometry. If null, defaults to "OpenGL.Line"
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the method is not called between <see cref="BeginDefinition()"/> and <see cref="EndDefinition"/>.
		/// </exception>
		public void DefineArcCircle(float cx, float cy, float radius, float beginAngle, float endAngle, bool filled, int sweepDiv = 32, string programId = null)
		{
			if (_MeshContext == null)
				throw new InvalidOperationException("not in definition state");

			// Ensure end angle greater than start angle
			if (endAngle < beginAngle)
				endAngle += 360.0f;

			float sweep = (float)Math.Round(endAngle - beginAngle, MidpointRounding.ToEven);
			float sweepStep = sweep / (int)(sweep / (360.0f /sweepDiv));

			if (filled == false) {
				MeshSectionDefinition section = GetCurrentSection(PrimitiveType.LineStrip, programId);
				Vertex3f? prevVertex = null;
				float distance = 0.0f;

				for (float angle = beginAngle; angle <= beginAngle + sweep; angle += sweepStep) {
					float radians = Angle.ToRadians(angle);
					float x = (float)Math.Cos(radians) * radius + cx;
					float y = (float)Math.Sin(radians) * radius + cy;

					Vertex3f v = new Vertex3f(x * _MeshContext.CurrentScale, y * _MeshContext.CurrentScale, 0.0f);

					if (section.IsLineDashed) {
						if (prevVertex.HasValue)
							distance += (v - prevVertex.Value).Module();
						v.z = distance;

						// Note: reset z component to get Module() as 2D distance
						prevVertex = new Vertex3f(v.x, v.y, 0.0f);
					}

					section.PositionVertexData.Add(v);
				}
			} else {
				MeshSectionDefinition section = GetCurrentSection(PrimitiveType.TriangleFan, programId);

				section.PositionVertexData.Add((Vertex3f)new Vertex2f(cx * _MeshContext.CurrentScale, cy * _MeshContext.CurrentScale));

				for (float angle = beginAngle; angle <= beginAngle + sweep; angle += sweepStep) {
					float radians = Angle.ToRadians(angle);
					float x = (float)Math.Cos(radians) * radius + cx;
					float y = (float)Math.Sin(radians) * radius + cy;

					section.PositionVertexData.Add((Vertex3f)new Vertex2f(x * _MeshContext.CurrentScale, y * _MeshContext.CurrentScale));
				}
			}
		}

		/// <summary>
		/// Define an arc based on ellipse.
		/// </summary>
		/// <param name="cx">
		/// A <see cref="float"/> that specifies the X coordinate of the lower-left "corner" of the arc.
		/// </param>
		/// <param name="cy">
		/// A <see cref="float"/> that specifies the Y coordinate of the lower-left "corner" of the arc.
		/// </param>
		/// <param name="major">
		/// A <see cref="float"/> that specifies the major (horizontal) axis of the arc.
		/// </param>
		/// <param name="minor">
		/// A <see cref="float"/> that specifies the minor (vertical) axis of the arc.
		/// </param>
		/// <param name="beginAngle">
		/// A <see cref="float"/> tha specifies the begin angle of the arc, in degrees.
		/// </param>
		/// <param name="endAngle">
		/// A <see cref="float"/> tha specifies the end angle of the arc, in degrees.
		/// </param>
		/// <param name="filled">
		/// A <see cref="Boolean"/> that specifies whether the arc is filled or not.
		/// </param>
		/// <param name="sweepSteps">
		/// A <see cref="float"/> tha specifies the the number of point to be drawn to represent the ellipse.
		/// </param>
		/// <param name="programId">
		/// The identifier of the program used to draw the geometry. If null, defaults to "OpenGL.Line"
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the method is not called between <see cref="BeginDefinition()"/> and <see cref="EndDefinition"/>.
		/// </exception>
		public void DefineArcEllipse(float cx, float cy, float major, float minor, float beginAngle, float endAngle, bool filled, float sweepSteps = 32.0f, string programId = null)
		{
			if (_MeshContext == null)
				throw new InvalidOperationException("not in definition state");

			// Ensure end angle greater than start angle
			if (endAngle < beginAngle)
				endAngle += 360.0f;

			float sweepStep = 360.0f / sweepSteps;

			if (filled == false) {
				MeshSectionDefinition section = GetCurrentSection(PrimitiveType.LineStrip, programId);
				Vertex3f? prevVertex = null;
				float distance = 0.0f;

				for (float angle = beginAngle; angle <= endAngle; angle += sweepStep) {
					float x = (float)Math.Cos(Angle.ToRadians(angle)) * (major / 2.0f) + cx;
					float y = (float)Math.Sin(Angle.ToRadians(angle)) * (minor / 2.0f) + cy;

					Vertex3f v = new Vertex3f(x * _MeshContext.CurrentScale, y * _MeshContext.CurrentScale, 0.0f);

					if (section.IsLineDashed) {
						if (prevVertex.HasValue)
							distance += (v - prevVertex.Value).Module();
						v.z = distance;

						// Note: reset z component to get Module() as 2D distance
						prevVertex = new Vertex3f(v.x, v.y, 0.0f);
					}

					section.PositionVertexData.Add(v);
				}
			} else {
				MeshSectionDefinition section = GetCurrentSection(PrimitiveType.TriangleFan, programId);

				section.PositionVertexData.Add((Vertex3f)new Vertex2f(cx * _MeshContext.CurrentScale, cy * _MeshContext.CurrentScale));

				for (float angle = beginAngle; angle <= endAngle; angle += sweepStep) {
					float x = (float)Math.Cos(Angle.ToRadians(angle)) * (major / 2.0f) + cx;
					float y = (float)Math.Sin(Angle.ToRadians(angle)) * (minor / 2.0f) + cy;
					section.PositionVertexData.Add((Vertex3f)new Vertex2f(x * _MeshContext.CurrentScale, y * _MeshContext.CurrentScale));
				}
			}
		}

		/// <summary>
		/// Define an arc based on ellipse.
		/// </summary>
		/// <param name="cx">
		/// A <see cref="float"/> that specifies the X coordinate of the lower-left "corner" of the arc.
		/// </param>
		/// <param name="cy">
		/// A <see cref="float"/> that specifies the Y coordinate of the lower-left "corner" of the arc.
		/// </param>
		/// <param name="majorOuter">
		/// A <see cref="float"/> that specifies the major (horizontal) axis of the external arc.
		/// </param>
		/// <param name="minorOuter">
		/// A <see cref="float"/> that specifies the minor (vertical) axis of the external arc.
		/// </param>
		/// <param name="majorInner">
		/// A <see cref="float"/> that specifies the major (horizontal) axis of the internal arc.
		/// </param>
		/// <param name="minorInner">
		/// A <see cref="float"/> that specifies the minor (vertical) axis of the internal arc.
		/// </param>
		/// <param name="beginAngle">
		/// A <see cref="float"/> tha specifies the begin angle of the arc, in degrees.
		/// </param>
		/// <param name="endAngle">
		/// A <see cref="float"/> tha specifies the end angle of the arc, in degrees.
		/// </param>
		/// <param name="filled">
		/// A <see cref="Boolean"/> that specifies whether the arc is filled or not.
		/// </param>
		/// <param name="sweepSteps">
		/// A <see cref="float"/> tha specifies the the number of point to be drawn to represent the ellipse.
		/// </param>
		/// <param name="programId">
		/// The identifier of the program used to draw the geometry. If null, defaults to "OpenGL.Line"
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the method is not called between <see cref="BeginDefinition()"/> and <see cref="EndDefinition"/>.
		/// </exception>
		public void DefineArcEllipse(float cx, float cy, float majorOuter, float minorOuter, float majorInner, float minorInner, float beginAngle, float endAngle, bool filled, float sweepSteps  = 32.0f, string programId = null)
		{
			if (_MeshContext == null)
				throw new InvalidOperationException("not in definition state");

			// Ensure end angle greater than start angle
			if (endAngle < beginAngle)
				endAngle += 360.0f;

			float sweepStep = 360.0f / sweepSteps;

			if (!filled) {
				MeshSectionDefinition section = GetCurrentSection(PrimitiveType.LineStrip, programId);
				Vertex3f? prevOutVertex = null;
				Vertex3f? prevInVertex = null;
				float distanceOut = 0.0f;
				float distanceIn = 0.0f;

				// The first internal...
				float xIn = (float)Math.Cos(Angle.ToRadians(beginAngle)) * (majorInner / 2.0f) + cx;
				float yIn = (float)Math.Sin(Angle.ToRadians(beginAngle)) * (minorInner / 2.0f) + cy;
				Vertex3f vIn = new Vertex3f(xIn * _MeshContext.CurrentScale, yIn * _MeshContext.CurrentScale, 0.0f);
				if (section.IsLineDashed) {
					if (prevInVertex.HasValue)
						distanceIn += (vIn - prevInVertex.Value).Module();
					vIn.z = distanceIn;
					// Note: reset z component to get Module() as 2D distance
					prevInVertex = new Vertex3f(vIn.x, vIn.y, 0.0f);
				}
				section.PositionVertexData.Add(vIn);

				// All the external
				for (float angle = beginAngle; angle <= endAngle; angle += sweepStep) {
					float xOut = (float)Math.Cos(Angle.ToRadians(angle)) * (majorOuter / 2.0f) + cx;
					float yOut = (float)Math.Sin(Angle.ToRadians(angle)) * (minorOuter / 2.0f) + cy;

					Vertex3f vOut = new Vertex3f(xOut * _MeshContext.CurrentScale, yOut * _MeshContext.CurrentScale, 0.0f);

					if (section.IsLineDashed) {
						if (prevOutVertex.HasValue)
							distanceOut += (vOut - prevOutVertex.Value).Module();
						vOut.z = distanceOut;
						// Note: reset z component to get Module() as 2D distance
						prevOutVertex = new Vertex3f(vOut.x, vOut.y, 0.0f);
					}
					section.PositionVertexData.Add(vOut);
				}

				// All the interal starting from the reverse
				for (float angle = endAngle; angle >= beginAngle; angle -= sweepStep) {
					xIn = (float)Math.Cos(Angle.ToRadians(angle)) * (majorInner / 2.0f) + cx;
					yIn = (float)Math.Sin(Angle.ToRadians(angle)) * (minorInner / 2.0f) + cy;

					vIn = new Vertex3f(xIn * _MeshContext.CurrentScale, yIn * _MeshContext.CurrentScale, 0.0f);

					if (section.IsLineDashed) {
						if (prevInVertex.HasValue)
							distanceIn += (vIn - prevInVertex.Value).Module();
						vIn.z = distanceIn;
						// Note: reset z component to get Module() as 2D distance
						prevInVertex = new Vertex3f(vIn.x, vIn.y, 0.0f);
					}
					section.PositionVertexData.Add(vIn);
				}

			} else {
				MeshSectionDefinition section = GetCurrentSection(PrimitiveType.TriangleStrip, programId);
				// First internal point
				float xIn, yIn, xOut, yOut;

				xIn = (float)Math.Cos(Angle.ToRadians(beginAngle)) * (majorInner / 2.0f) + cx;
				yIn = (float)Math.Sin(Angle.ToRadians(beginAngle)) * (minorInner / 2.0f) + cy;
				section.PositionVertexData.Add((Vertex3f)new Vertex2f(xIn * _MeshContext.CurrentScale, yIn * _MeshContext.CurrentScale));

				

				// All the other
				for (float angle = beginAngle; angle <= endAngle - sweepStep; angle += sweepStep) {
					xOut = (float)Math.Cos(Angle.ToRadians(angle)) * (majorOuter / 2.0f) + cx;
					yOut = (float)Math.Sin(Angle.ToRadians(angle)) * (minorOuter / 2.0f) + cy;
					xIn = (float)Math.Cos(Angle.ToRadians(angle + sweepStep)) * (majorInner / 2.0f) + cx;
					yIn = (float)Math.Sin(Angle.ToRadians(angle + sweepStep)) * (minorInner / 2.0f) + cy;
					section.PositionVertexData.Add((Vertex3f)new Vertex2f(xOut * _MeshContext.CurrentScale, yOut * _MeshContext.CurrentScale));
					section.PositionVertexData.Add((Vertex3f)new Vertex2f(xIn * _MeshContext.CurrentScale, yIn * _MeshContext.CurrentScale));
				}

				xOut = (float)Math.Cos(Angle.ToRadians(endAngle)) * (majorOuter / 2.0f) + cx;
				yOut = (float)Math.Sin(Angle.ToRadians(endAngle)) * (minorOuter / 2.0f) + cy;
				section.PositionVertexData.Add((Vertex3f)new Vertex2f(xOut * _MeshContext.CurrentScale, yOut * _MeshContext.CurrentScale));
			}
		}

		#endregion

		#region 

		/// <summary>
		/// Define a single triangle.
		/// </summary>
		public void Begin(PrimitiveType primitive)
		{
			if (_MeshContext == null)
				throw new InvalidOperationException("not in definition state");

			switch (primitive) {
				case PrimitiveType.Lines:
				case PrimitiveType.LineStrip:
				case PrimitiveType.LineLoop:
					GetCurrentSection(primitive, "OpenGL.Line");
					break;
				default:
					GetCurrentSection(primitive, "OpenGL.Standard");
					break;
			}
		}

		public void AddVertex(Vertex2f v)
		{
			MeshSectionDefinition section = _MeshContext.Sections[_MeshContext.Sections.Count - 1];

			section.PositionVertexData.Add((Vertex3f)(v * _MeshContext.CurrentScale));
		}

		public void End()
		{

		}

		#endregion

		/// <summary>
		/// Gets (or create lazily) a <see cref="MeshSectionDefinition"/> depending on the current primitive.
		/// </summary>
		/// <param name="primitive">
		/// A <see cref="PrimitiveType"/> that specifies the required section type.
		/// </param>
		/// <param name="programId">
		/// A <see cref="string"/> that specifies the program to be sued for rendering this section.
		/// </param>
		/// <returns>
		/// It returns a <see cref="MeshSectionDefinition"/> for drawing the primitive of type <paramref name="primitive"/>. It tries to reuse
		/// the last created section, if possible.
		/// </returns>
		private MeshSectionDefinition GetCurrentSection(PrimitiveType primitive, string programId = null)
		{
			MeshSectionDefinition section = null;

			// Determine
			string sectionProgramId = programId;

			if (sectionProgramId == null) {
				switch (primitive) {
					case PrimitiveType.Lines:
					case PrimitiveType.LineLoop:
					case PrimitiveType.LineStrip:
						if (_MeshContext.CurrentLineStipplePattern == 0xFFFF)
							sectionProgramId = _DefaultLineProgram;
						else
							sectionProgramId = _DefaultLineStippleProgram;
						break;
					case PrimitiveType.Triangles:
					case PrimitiveType.TriangleStrip:
					case PrimitiveType.TriangleFan:
						sectionProgramId = _DefaultPolygonProgram;
						break;
					default:
						throw new NotSupportedException($"unsupported primitive {primitive}");
				}
			}

			// Try to reuse the last section
			if (_MeshContext.Sections.Count > 0 && _MeshContext.IsDirty == false) {
				MeshSectionDefinition lastSectionDefinition = _MeshContext.Sections[_MeshContext.Sections.Count - 1];

				switch (primitive) {
					case PrimitiveType.Points:
					case PrimitiveType.Lines:
					case PrimitiveType.Triangles:
						if (lastSectionDefinition.PrimitiveType == primitive && lastSectionDefinition.ProgramID == sectionProgramId)
							return _MeshContext.Sections[_MeshContext.Sections.Count - 1];
						break;
				}
			}

			// Create a new section, if necessary
			if (section == null) {
				switch (primitive) {
					case PrimitiveType.Lines:
					case PrimitiveType.LineLoop:
					case PrimitiveType.LineStrip:
					case PrimitiveType.Triangles:
					case PrimitiveType.TriangleStrip:
					case PrimitiveType.TriangleFan:
						section = new MeshSectionDefinition(primitive, sectionProgramId);
						break;
					default:
						throw new NotSupportedException($"unsupported primitive {primitive}");
				}

				// Derive current state
				if (_MeshContext.CurrentColor.HasValue)
					section.Color = _MeshContext.CurrentColor.Value;
				section.LineWidth = _MeshContext.CurrentLineWidth;
				section.LineStippleFactor = _MeshContext.CurrentLineStippleFactor;
				section.LineStipplePattern = _MeshContext.CurrentLineStipplePattern;

				// Make the returned section the current one
				_MeshContext.Sections.Add(section);
			}

			// Reset dirty flags
			_MeshContext.ResetDirtyFlags();

			return section;
		}

		/// <summary>
		/// The <see cref="MeshSectionContext"/> used for defining this VertexArrayObject.
		/// </summary>
		private MeshSectionContext _MeshContext;

		/// <summary>
		/// Default program when drawing polygons.
		/// </summary>
		private string _DefaultPolygonProgram = "OpenGL.Standard";

		/// <summary>
		/// Default program when drawing solid lines.
		/// </summary>
		private string _DefaultLineProgram = "OpenGL.Line";

		/// <summary>
		/// Default program when drawing dashed lines.
		/// </summary>
		private string _DefaultLineStippleProgram = "OpenGL.LineStipple";

		#endregion

		#region Rendering

		/// <summary>
		/// A section of the VertexArrayMesh.
		/// </summary>
		private class MeshSection
		{
			#region Constructors

			/// <summary>
			/// Construct a MeshSection specifying the type of the primitive to be drawn.
			/// </summary>
			/// <param name="primitive">
			/// A <see cref="PrimitiveType"/> that specifies how vertices data is drawn.
			/// </param>
			public MeshSection(PrimitiveType primitive)
			{
				if (primitive == PrimitiveType.Quads || primitive == PrimitiveType.QuadStrip || primitive == PrimitiveType.Patches)
					throw new ArgumentException("not allowed value", nameof(primitive));
				PrimitiveType = primitive;
			}

			#endregion

			#region Common Information

			/// <summary>
			/// Elements index within a vertex array object.
			/// </summary>
			public uint ElementsIndex;

			/// <summary>
			/// The program used for drawing this MeshSection.
			/// </summary>
			public ShaderProgram Program;

			/// <summary>
			/// The type of the primitive to be rendered.
			/// </summary>
			public readonly PrimitiveType PrimitiveType;

			/// <summary>
			/// The section color, any
			/// </summary>
			public ColorRGBAF? Color;

			#endregion

			#region Point PrimitiveType Information

			/// <summary>
			/// The point size.
			/// </summary>
			public float PointSize;

			#endregion

			#region Line PrimitiveType Information

			/// <summary>
			/// Determine whether the line geometry is dashed.
			/// </summary>
			public bool IsLineDashed
			{
				get { return LineStipplePattern != 0xFFFF; }
			}

			/// <summary>
			/// The line width, in pixels.
			/// </summary>
			public float LineWidth = 1.0f;

			/// <summary>
			/// The line stipple pattern factor.
			/// </summary>
			public int LineStippleFactor = 1;

			/// <summary>
			/// The line stipple pattern.
			/// </summary>
			public ushort LineStipplePattern = 0xFFFF;

			#endregion
		}

		/// <summary>
		/// Get or set the default color to set before rendering.
		/// </summary>
		public ColorRGBAF DefaultColor
		{
			get { return _DefaultColor; }
			set
			{
				if (value == null)
					throw new InvalidOperationException("null default color not allowed");
				_DefaultColor = value;
			}
		}

		/// <summary>
		/// The default color to set before rendering.
		/// </summary>
		private ColorRGBAF _DefaultColor = new ColorRGBAF(1.0f, 1.0f, 1.0f);

		/// <summary>
		/// Sections composing this VertexArrayMesh.
		/// </summary>
		private readonly List<MeshSection> _VertexArraySection = new List<MeshSection>();

		#endregion

		#region Custom Uniform State

		/// <summary>
		/// Set a custom uniform value.
		/// </summary>
		/// <param name="uniformName"></param>
		/// <param name="uniformValue"></param>
		public void SetUniform(string uniformName, object uniformValue)
		{
			if (uniformName == null)
				throw new ArgumentNullException(nameof(uniformName));
			if (uniformValue == null)
				throw new ArgumentNullException(nameof(uniformValue));

			_CustomUniforms[uniformName] = uniformValue;
		}

		private void ApplyUniforms(GraphicsContext ctx, ShaderProgram program)
		{
			if (program == null)
				throw new ArgumentNullException(nameof(program));

			foreach (KeyValuePair<string, object> pair in _CustomUniforms) {
				string uniformName = pair.Key;
				object uniformValue = pair.Value;

				if (!program.IsActiveUniform(uniformName))
					continue;

				program.SetUniform(ctx, uniformName, uniformValue);
			}
		}

		/// <summary>
		/// Collect custom uniform values for drawing with this VertexMesh.
		/// </summary>
		private readonly Dictionary<string, object> _CustomUniforms = new Dictionary<string, object>();

		#endregion

		#region Overrides

		/// <summary>
		/// Draw all elements.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for rendering.
		/// </param>
		/// <param name="color">
		/// The color to be used when the mesh geometry hasn't defined a color.
		/// </param>
		public void Draw(GraphicsContext ctx, ColorRGBAF? color = null)
		{
			foreach (MeshSection meshSection in _VertexArraySection) {
				ctx.Bind(meshSection.Program);
				ctx.CurrentState.Apply(ctx, meshSection.Program);

				ColorRGBAF meshSectionColor = color.HasValue ? color.Value : ColorRGBAF.ColorWhite;

				// Mesh color always override color parameter
				if (meshSection.Color.HasValue)
					meshSectionColor = meshSection.Color.Value;

				meshSection.Program.SetUniform(ctx, "glo_UniformColor", meshSectionColor);
				meshSection.Program.SetUniform(ctx, "glo_LineWidth", meshSection.LineWidth);
				meshSection.Program.SetUniform(ctx, "glo_LineStipple", (uint)meshSection.LineStipplePattern);
				meshSection.Program.SetUniform(ctx, "glo_LineStippleFactor", (float)meshSection.LineStippleFactor);

				ApplyUniforms(ctx, meshSection.Program);

				Draw(ctx, meshSection.Program, (int)meshSection.ElementsIndex);
			}
		}

		/// <summary>
		/// Draw all elements.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for rendering.
		/// </param>
		/// <param name="color">
		/// The color to be used when the mesh geometry hasn't defined a color.
		/// </param>
		public void Draw(GraphicsContext ctx, float depth, ColorRGBAF? color = null)
		{
			foreach (MeshSection meshSection in _VertexArraySection) {
				ctx.Bind(meshSection.Program);
				ctx.CurrentState.Apply(ctx, meshSection.Program);

				ColorRGBAF meshSectionColor = color.HasValue ? color.Value : ColorRGBAF.ColorWhite;

				// Mesh color always override color parameter
				if (meshSection.Color.HasValue)
					meshSectionColor = meshSection.Color.Value;

				meshSection.Program.SetUniform(ctx, "glo_UniformColor", meshSectionColor);
				meshSection.Program.SetUniform(ctx, "glo_LineWidth", meshSection.LineWidth);
				meshSection.Program.SetUniform(ctx, "glo_LineStipple", (uint)meshSection.LineStipplePattern);
				meshSection.Program.SetUniform(ctx, "glo_LineStippleFactor", (float)meshSection.LineStippleFactor);
				meshSection.Program.SetUniform(ctx, "glo_FragmentDepth", depth);

				ApplyUniforms(ctx, meshSection.Program);

				Draw(ctx, meshSection.Program, (int)meshSection.ElementsIndex);
			}
		}

		/// <summary>
		/// Draw a number of instances of the attributes of this vertex array.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for rendering.
		/// </param>
		/// <param name="instances">
		/// A <see cref="UInt32"/> that specify the number of instances to draw.
		/// </param>
		/// <remarks>
		/// It is supposed the VertexMesh user has configured attributes with a divisor greater than 0.
		/// </remarks>
		public void DrawInstanced(GraphicsContext ctx, uint instances, ColorRGBAF? color = null)
		{
			// Draw each section using instanced shader program
			foreach (MeshSection meshSection in _VertexArraySection) {
				ctx.Bind(meshSection.Program);
				ctx.CurrentState.Apply(ctx, meshSection.Program);

				ColorRGBAF meshSectionColor = color.HasValue ? color.Value : ColorRGBAF.ColorWhite;

				// Mesh color always override color parameter
				if (meshSection.Color.HasValue)
					meshSectionColor = meshSection.Color.Value;

				meshSection.Program.SetUniform(ctx, "glo_UniformColor", meshSectionColor);
				meshSection.Program.SetUniform(ctx, "glo_LineWidth", meshSection.LineWidth);
				meshSection.Program.SetUniform(ctx, "glo_LineStipple", (uint)meshSection.LineStipplePattern);
				meshSection.Program.SetUniform(ctx, "glo_LineStippleFactor", (float)meshSection.LineStippleFactor);

				base.DrawInstanced(ctx, meshSection.Program, instances);
			}
		}

		/// <summary>
		/// Draw a number of instances of the attributes of this vertex array.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for rendering.
		/// </param>
		/// <param name="instances">
		/// A <see cref="UInt32"/> that specify the number of instances to draw.
		/// </param>
		/// <remarks>
		/// It is supposed the VertexMesh user has configured attributes with a divisor greater than 0.
		/// </remarks>
		public void DrawInstanced(GraphicsContext ctx, uint instances, float depth, ColorRGBAF? color = null)
		{
			// Draw each section using instanced shader program
			foreach (MeshSection meshSection in _VertexArraySection) {
				ctx.Bind(meshSection.Program);
				ctx.CurrentState.Apply(ctx, meshSection.Program);

				ColorRGBAF meshSectionColor = color.HasValue ? color.Value : ColorRGBAF.ColorWhite;

				// Mesh color always override color parameter
				if (meshSection.Color.HasValue)
					meshSectionColor = meshSection.Color.Value;

				meshSection.Program.SetUniform(ctx, "glo_UniformColor", meshSectionColor);
				meshSection.Program.SetUniform(ctx, "glo_LineWidth", meshSection.LineWidth);
				meshSection.Program.SetUniform(ctx, "glo_LineStipple", (uint)meshSection.LineStipplePattern);
				meshSection.Program.SetUniform(ctx, "glo_LineStippleFactor", (float)meshSection.LineStippleFactor);
				meshSection.Program.SetUniform(ctx, "glo_FragmentDepth", depth);

				base.DrawInstanced(ctx, meshSection.Program, instances);
			}
		}

		#endregion

		#region Overrides

		/// <summary>
		/// Draw a number of instances of the attributes of this vertex array.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for rendering.
		/// </param>
		/// <param name="instances">
		/// A <see cref="UInt32"/> that specify the number of instances to draw.
		/// </param>
		/// <remarks>
		/// It is supposed the VertexMesh user has configured attributes with a divisor greater than 0.
		/// </remarks>
		public override void DrawInstanced(GraphicsContext ctx, uint instances)
		{
			// Draw each section using instanced shader program
			foreach (MeshSection meshSection in _VertexArraySection) {
				ctx.Bind(meshSection.Program);
				ctx.CurrentState.Apply(ctx, meshSection.Program);

				ColorRGBAF meshSectionColor = ColorRGBAF.ColorWhite;

				// Mesh color always override color parameter
				if (meshSection.Color.HasValue)
					meshSectionColor = meshSection.Color.Value;

				meshSection.Program.SetUniform(ctx, "glo_UniformColor", meshSectionColor);
				meshSection.Program.SetUniform(ctx, "glo_LineWidth", meshSection.LineWidth);
				meshSection.Program.SetUniform(ctx, "glo_LineStipple", (uint)meshSection.LineStipplePattern);
				meshSection.Program.SetUniform(ctx, "glo_LineStippleFactor", (float)meshSection.LineStippleFactor);

				base.DrawInstanced(ctx, meshSection.Program, instances);
			}
		}

		/// <summary>
		/// Draw a number of instances of the attributes of this vertex array.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for rendering.
		/// </param>
		/// <param name="shader">
		/// The <see cref="ShaderProgram"/> used for drawing the vertex arrays.
		/// </param>
		/// <param name="instances">
		/// A <see cref="UInt32"/> that specify the number of instances to draw.
		/// </param>
		/// <remarks>
		/// It is supposed the VertexMesh user has configured attributes with a divisor greater than 0.
		/// </remarks>
		public override void DrawInstanced(GraphicsContext ctx, ShaderProgram shader, uint instances)
		{
			// Draw each section using instanced shader program
			foreach (MeshSection meshSection in _VertexArraySection) {
				ctx.Bind(shader);
				ctx.CurrentState.Apply(ctx, shader);

				base.DrawInstanced(ctx, shader, instances);
			}
		}

		/// <summary>
		/// Dispose graphics resources using the underlying <see cref="GraphicsContext"/>.
		/// </summary>
		/// <param name='ctx'>
		/// A <see cref="GraphicsContext"/> which have access to the <see cref="IRenderDisposable"/> graphics resources.
		/// </param>
		/// <remarks>
		/// <para>
		/// The instance shall be considered disposed as it were called <see cref="IDisposable.Dispose"/>, but in addition
		/// this method will release this instance resources.
		/// </para>
		/// <para>
		/// The <see cref="Dispose()"/> method should try to release the underlying resources by getting the optional graphics
		/// context current on the calling thread.
		/// </para>
		/// </remarks>
		public override void Dispose(GraphicsContext ctx)
		{
			// Dispose is equivalent to DecRef()...
			// This allow using{} even on referenced variables, as long the GraphicsResource is referenced in the using block
			if (RefCount > 0)
				DecRef();
			if (RefCount > 0)
				return;

			foreach (MeshSection meshSection in _VertexArraySection)
				meshSection.Program.DecRef();
			_VertexArraySection.Clear();

			// Base implementation
			base.Dispose(ctx);
		}

		#endregion
	}
}
