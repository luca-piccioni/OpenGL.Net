
// Copyright (C) 2011-2017 Luca Piccioni
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
using System.Diagnostics;

namespace OpenGL.Objects
{
	/// <summary>
	/// A collection of vertex arrays and vertex indices.
	/// </summary>
	/// <remarks>
	/// <para>
	/// Vertex arrays are collected by semantic or name. The array buffers corresponding to vertex attributes
	/// can have any memory layout (offset and interleaving).
	/// </para>
	/// <para>
	/// Vertex arrays are rendered using a collection of vertex elements. Each vertex element issue a rendering
	/// command, referencing the vertex array data directly or using a deferencing index.
	/// </para>
	/// <para>
	/// A vertex array can have associated a shader program, and an render state set. Those two objects defines
	/// the rendering result of the collected arrays.
	/// </para>
	/// </remarks>
	public partial class VertexArrays : GraphicsResource, IBindingResource
	{
		#region Constructors

		/// <summary>
		/// Construct an empty vertex array.
		/// </summary>
		public VertexArrays()
		{

		}

		#endregion

		#region Draw

		/// <summary>
		/// Draw all elements.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for rendering.
		/// </param>
		/// <param name="shader">
		/// The <see cref="ShaderProgram"/> used for drawing the vertex arrays.
		/// </param>
		public void Draw(GraphicsContext ctx, ShaderProgram shader)
		{
			Draw(ctx, shader, null);
		}

		/// <summary>
		/// Draw a specific element set.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for rendering.
		/// </param>
		/// <param name="shader">
		/// The <see cref="ShaderProgram"/> used for drawing the vertex arrays.
		/// </param>
		/// <param name="elementIndex">
		/// A <see cref="Int32"/> that specifies the index of the element to draw. If it is less than 0, it draws
		/// all elements set. The index can be obtained by the value returned by <see cref="SetElementArray"/>.
		/// </param>
		public void Draw(GraphicsContext ctx, ShaderProgram shader, int elementIndex)
		{
			Draw(ctx, shader, GetElementArray(elementIndex));
		}

		/// <summary>
		/// Draw a specific element set.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for rendering.
		/// </param>
		/// <param name="shader">
		/// The <see cref="ShaderProgram"/> used for drawing the vertex arrays.
		/// </param>
		/// <param name="elementIndex">
		/// A <see cref="Int32"/> that specifies the index of the element to draw. If it is less than 0, it draws
		/// all elements set. The index can be obtained by the value returned by <see cref="SetElementArray"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="UInt32"/> that specifies the offset of the first element to draw.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specifies the number of items to draw.
		/// </param>
		public void Draw(GraphicsContext ctx, ShaderProgram shader, int elementIndex, uint offset, uint count)
		{
			Element drawElement = GetElementArray(elementIndex) as Element;
			if (drawElement == null)
				throw new InvalidOperationException("no element at index " + elementIndex);

			CheckThisExistence(ctx);

			// Set vertex arrays
			SetVertexArrayState(ctx, shader);

			// Fixed or programmable pipeline?
			if (shader != null)
				ctx.Bind(shader);
			else
				ctx.ResetProgram();

			if (_FeedbackBuffer != null)
				_FeedbackBuffer.Begin(ctx, drawElement.ElementsMode);

			drawElement.Draw(ctx, offset, count);

			if (_FeedbackBuffer != null)
				_FeedbackBuffer.End(ctx);
		}

		/// <summary>
		/// Draw a specific element set.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for rendering.
		/// </param>
		/// <param name="shader">
		/// The <see cref="ShaderProgram"/> used for drawing the vertex arrays.
		/// </param>
		/// <param name="elementIndex">
		/// A <see cref="Int32"/> that specifies the index of the element to draw. If it is less than 0, it draws
		/// all elements set. The index can be obtained by the value returned by <see cref="SetElementArray"/>.
		/// </param>
		public void Draw(GraphicsContext ctx, ShaderProgram shader, params IElement[] elements)
		{
			CheckThisExistence(ctx);

			// Set vertex arrays
			SetVertexArrayState(ctx, shader);

			// Fixed or programmable pipeline?
			if (shader != null)
				ctx.Bind(shader);
			else
				ctx.ResetProgram();

			IEnumerable<IElement> drawElements = DrawElements;

			if (elements != null)
				drawElements = elements;

			foreach (Element attributeElement in drawElements) {
				if (_FeedbackBuffer != null)
					_FeedbackBuffer.Begin(ctx, attributeElement.ElementsMode);

				attributeElement.Draw(ctx);

				if (_FeedbackBuffer != null)
					_FeedbackBuffer.End(ctx);
			}
		}

		/// <summary>
		/// Set the vertex arrays state for the shader program.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> on which the shader program is bound.
		/// </param>
		/// <param name="shaderProgram">
		/// A <see cref="ShaderProgram"/> on which the vertex arrays shall be bound.
		/// </param>
		private void SetVertexArrayState(GraphicsContext ctx, ShaderProgram shaderProgram)
		{
			CheckThisExistence(ctx);

			// Set vertex array state all at once...
			ctx.Bind(this, true);

			if (shaderProgram != null) {
				ICollection<string> activeAttributes = shaderProgram.ActiveAttributes;
				uint attributesSet = 0;

				// Set vertex array state
				foreach (string attributeName in activeAttributes) {
					IVertexArray shaderVertexArray = GetVertexArray(attributeName, shaderProgram);
					if (shaderVertexArray == null)
						continue;

					ShaderProgram.AttributeBinding attributeBinding = shaderProgram.GetActiveAttribute(attributeName);

					IVertexArray currentVertexArray = _VertexArrayState[attributeBinding.Location];
					//if (ReferenceEquals(shaderVertexArray, currentVertexArray) == false) {
					shaderVertexArray.SetVertexAttribute(ctx, attributeBinding, attributeName);
					_VertexArrayState[attributeBinding.Location] = shaderVertexArray;
					//}

					attributesSet++;
				}

				if (attributesSet == 0)
					throw new InvalidOperationException("no attribute is set");
			} else {
				IVertexArray attributeArray;

				// No shader program: using fixed pipeline program. ATM enable all attributes having a semantic
				if ((attributeArray = GetVertexArray(VertexArraySemantic.Position)) == null)
					throw new InvalidOperationException("no position semantic array defined");
				attributeArray.SetVertexAttribute(ctx, null, VertexArraySemantic.Position);

				// Optional attributes
				if ((attributeArray = GetVertexArray(VertexArraySemantic.Color)) != null)
					attributeArray.SetVertexAttribute(ctx, null, VertexArraySemantic.Color);
				if ((attributeArray = GetVertexArray(VertexArraySemantic.Normal)) != null)
					attributeArray.SetVertexAttribute(ctx, null, VertexArraySemantic.Normal);
				if ((attributeArray = GetVertexArray(VertexArraySemantic.TexCoord)) != null)
					attributeArray.SetVertexAttribute(ctx, null, VertexArraySemantic.TexCoord);
			}
		}

		/// <summary>
		/// Utility routine for checking the vertex array state.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> on which the shader program is bound.
		/// </param>
		/// <param name="shaderProgram">
		/// A <see cref="ShaderProgram"/> on which the vertex arrays shall be bound.
		/// </param>
		[Conditional("GL_DEBUG")]
		private void CheckVertexAttributes(GraphicsContext ctx, ShaderProgram shaderProgram)
		{
			// Vertex array state overall check
			foreach (string attributeName in shaderProgram.ActiveAttributes) {
				ShaderProgram.AttributeBinding attributeBinding = shaderProgram.GetActiveAttribute(attributeName);
				VertexArray shaderVertexArray = GetVertexArray(attributeName, shaderProgram) as VertexArray;
				if (shaderVertexArray == null)
					continue;

				shaderVertexArray.CheckVertexAttribute(ctx, attributeBinding.Location);
			}
		}

		/// <summary>
		/// Currently bound vertex array state.
		/// </summary>
		private IVertexArray[] _VertexArrayState = new IVertexArray[Gl.CurrentLimits.MaxVertexAttribs];

		#endregion

		#region Draw Instanced

		/// <summary>
		/// Draw a number of instances of the attributes of this vertex array.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for rendering.
		/// </param>
		/// <param name="instances">
		/// A <see cref="UInt32"/> that specify the number of instances to draw.
		/// </param>
		public virtual void DrawInstanced(GraphicsContext ctx, uint instances)
		{
			DrawInstanced(ctx, null, instances);
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
		public virtual void DrawInstanced(GraphicsContext ctx, ShaderProgram shader, uint instances)
		{
			CheckThisExistence(ctx);

			if (!ctx.Extensions.DrawInstanced_ARB)
				throw new NotSupportedException("GL_ARB_draw_instanced not implemented");
			if (shader != null && shader.Exists(ctx) == false)
				throw new ArgumentException("not existing", "shader");

			// Set vertex arrays
			SetVertexArrayState(ctx, shader);

			// Fixed or programmable pipeline?
			if (shader != null)
				ctx.Bind(shader);
			else
				ctx.ResetProgram();

			// Issue rendering using shader
			foreach (Element attributeElement in DrawElements) {
				if (_FeedbackBuffer != null)
					_FeedbackBuffer.Begin(ctx, attributeElement.ElementsMode);

				attributeElement.DrawInstanced(ctx, instances);

				if (_FeedbackBuffer != null)
					_FeedbackBuffer.End(ctx);
			}
		}

		#endregion

		#region Transform Feedback

		public void SetTransformFeedback(FeedbackBuffer feedbackObject)
		{
			if (_FeedbackBuffer != null)
				_FeedbackBuffer.DecRef();

			_FeedbackBuffer = feedbackObject;

			if (_FeedbackBuffer != null)
				_FeedbackBuffer.IncRef();
		}

		/// <summary>
		/// The feedback buffer object that specify the feedback array buffers.
		/// </summary>
		private FeedbackBuffer _FeedbackBuffer;

		#endregion

		#region Generation Methods

		/// <summary>
		/// Generate normals for the elements defined in this vertex array.
		/// </summary>
		/// <exception cref="InvalidOperationException">
		/// This exception is thown in the case the vertex array does not defines the requires arrays. Normals
		/// generation requires user to allocate normal buffer following the other elements; and the position semantic
		/// must be defined and meaninfull.
		/// </exception>
		public void GenerateNormals()
		{
			foreach (Element vertexElement in DrawElements)
				vertexElement.GenerateNormals(this);
		}

		/// <summary>
		/// Generate texture coordinates for the elements defined in this vertex array.
		/// </summary>
		/// <param name="genTexCoordCallback">
		/// A <see cref="VertexArrayTexGenDelegate"/> used for generating texture coordinates.
		/// </param>
		public void GenerateTexCoords(VertexArrayTexGenDelegate genTexCoordCallback)
		{
			foreach (Element vertexElement in DrawElements)
				vertexElement.GenerateTexCoord(this, genTexCoordCallback);
		}

		/// <summary>
		/// Generate texture coordinates for the elements defined in this vertex array.
		/// </summary>
		/// <param name="vertexArrayTexGen">
		/// A <see cref="IVertexArrayTexGen"/> used for generating texture coordinates.
		/// </param>
		public void GenerateTexCoords(IVertexArrayTexGen vertexArrayTexGen)
		{
			// Interface initialization (i.e. stats and other information)
			vertexArrayTexGen.Initialize(this);
			// Process texture coords as usual
			GenerateTexCoords(delegate (Vertex3f position) {
				return (vertexArrayTexGen.Generate(position));
			});
		}

		/// <summary>
		/// Generate tangents and bitangents for the elements defined in this vertex array.
		/// </summary>
		/// <exception cref="InvalidOperationException">
		/// This exception is thown in the case the vertex array does not defines the requires arrays. Tangent and bitangents
		/// generation requires user to allocate relatives buffer following the other elements; and the position semantic
		/// and the texture coordinate semantic must be defined and meaninfull.
		/// </exception>
		public void GenerateTangents()
		{
			foreach (Element vertexElement in DrawElements)
				vertexElement.GenerateTangents(this);
		}

		#endregion

		#region Polygon Generation - Sphere

		/// <summary>
		/// Create a sphere.
		/// </summary>
		/// <param name="radius">
		/// A <see cref="Single"/> that specifies the radius of the sphere.
		/// </param>
		/// <param name="slices">
		/// A <see cref="Int32"/> that specifies the number of horizontal subdivisions of the sphere.
		/// </param>
		/// <param name="stacks">
		/// A <see cref="Int32"/> that specifies the number of vertical subdivisions of the sphere.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Objects.VertexArrays"/> defining the following semantics:
		/// - Positions
		/// - Normals
		/// </returns>
		public static VertexArrays CreateSphere(float radius, int slices, int stacks)
		{
			VertexArrays vertexArray = new VertexArrays();

			// Vertex generation
			Vertex3f[] position, normal;
			ushort[] indices;
			int vertexCount;

			GenerateSphere(radius, slices, stacks, out position, out normal, out indices, out vertexCount);

			// Buffer definition
			ArrayBuffer<Vertex3f> positionBuffer = new ArrayBuffer<Vertex3f>();
			positionBuffer.Create(position);
			vertexArray.SetArray(positionBuffer, VertexArraySemantic.Position);

			ArrayBuffer<Vertex3f> normalBuffer = new ArrayBuffer<Vertex3f>();
			normalBuffer.Create(normal);
			vertexArray.SetArray(normalBuffer, VertexArraySemantic.Normal);

			ElementBuffer<ushort> elementBuffer = new ElementBuffer<ushort>();
			elementBuffer.Create(indices);
			vertexArray.SetElementArray(PrimitiveType.TriangleStrip, elementBuffer);

			return (vertexArray);
		}

		/// <summary>
		/// Utility method for <see cref="CreateSphere"/>.
		/// </summary>
		/// <param name="radius"></param>
		/// <param name="slices"></param>
		/// <param name="stacks"></param>
		/// <param name="vertices"></param>
		/// <param name="normals"></param>
		/// <param name="indices"></param>
		/// <param name="vertexCount"></param>
		private static void GenerateSphere(float radius, int slices, int stacks, out Vertex3f[] vertices, out Vertex3f[] normals, out ushort[] indices, out int vertexCount)
		{
			if (slices == 0 || stacks < 2)
				throw new ArgumentException();

			// Generate geometry vertices
			float[] sint1, cost1;
			float[] sint2, cost2;

			vertexCount = slices * (stacks - 1) + 2;
			vertexCount = Math.Min(vertexCount, UInt16.MaxValue);

			GenerateCircleTable(out sint1, out cost1, -slices, false);
			GenerateCircleTable(out sint2, out cost2, stacks, true);

			vertices = new Vertex3f[vertexCount];
			normals = new Vertex3f[vertexCount];

			vertices[0] = new Vertex3f(0.0f, 0.0f, radius);
			normals[0] = Vertex3f.UnitZ;

			int idx = 1;

			for (int i = 1; i < stacks; i++) {
				for (int j = 0; j < slices; j++, idx++) {
					float x = cost1[j] * sint2[i];
					float y = sint1[j] * sint2[i];
					float z = cost2[i];

					vertices[idx] = new Vertex3f(x * radius, y * radius, z * radius);
					normals[idx] = new Vertex3f(x, y, z);
					Debug.Assert(normals[idx].Module() > 0.1f);
				}
			}

			vertices[idx] = new Vertex3f(0.0f, 0.0f, -radius);
			normals[idx] = -Vertex3f.UnitZ;

			// Generate indices for triangle strip
			indices = new UInt16[(slices + 1) * stacks * 2];
			/* Create index vector */
			int offset;

			idx = 0;

			/* top stack */
			for (int j = 0; j < slices; j++, idx += 2) {
				indices[idx] = (ushort)(j + 1); /* 0 is top vertex, 1 is first for first stack */
				indices[idx + 1] = 0;
			}
			indices[idx] = 1;                       /* repeat first slice's idx for closing off shape */
			indices[idx + 1] = 0;
			idx += 2;

			/* middle stacks: */
			/* Strip indices are relative to first index belonging to strip, NOT relative to first vertex/normal pair in array */
			for (int i = 0; i < stacks - 2; i++, idx += 2) {
				offset = 1 + i * slices;                        /* triangle_strip indices start at 1 (0 is top vertex), and we advance one stack down as we go along */
				for (int j = 0; j < slices; j++, idx += 2) {
					indices[idx] = (ushort)(offset + j + slices);
					indices[idx + 1] = (ushort)(offset + j);
				}
				indices[idx] = (ushort)(offset + slices);       /* repeat first slice's idx for closing off shape */
				indices[idx + 1] = (ushort)offset;
			}

			/* bottom stack */
			offset = 1 + (stacks - 2) * slices;                 /* triangle_strip indices start at 1 (0 is top vertex), and we advance one stack down as we go along */
			for (int j = 0; j < slices; j++, idx += 2) {
				indices[idx] = (ushort)(vertexCount - 1);       /* zero based index, last element in array (bottom vertex)... */
				indices[idx + 1] = (ushort)(offset + j);
			}
			indices[idx] = (ushort)(vertexCount - 1);           /* repeat first slice's idx for closing off shape */
			indices[idx + 1] = (ushort)(offset);
		}

		/// <summary>
		/// Utility method for <see cref="GenerateSphere"/>.
		/// </summary>
		/// <param name="sint"></param>
		/// <param name="cost"></param>
		/// <param name="n"></param>
		/// <param name="halfCircle"></param>
		private static void GenerateCircleTable(out float[] sint, out float[] cost, int n, bool halfCircle)
		{
			/* Table size, the sign of n flips the circle direction */
			int size = Math.Abs(n);

			/* Determine the angle between samples */
			float angle = (halfCircle ? 1 : 2) * (float)Math.PI / (float)((n == 0) ? 1 : n);

			/* Allocate memory for n samples, plus duplicate of first entry at the end */
			sint = new float[size + 1];
			cost = new float[size + 1];

			/* Compute cos and sin around the circle */
			sint[0] = 0.0f;
			cost[0] = 1.0f;

			for (int i = 1; i < size; i++) {
				sint[i] = (float)Math.Sin(angle * i);
				cost[i] = (float)Math.Cos(angle * i);
			}

			if (halfCircle) {
				sint[size] = 0.0f;  /* sin PI */
				cost[size] = -1.0f;  /* cos PI */
			} else {
				/* Last sample is duplicate of the first (sin or cos of 2 PI) */
				sint[size] = sint[0];
				cost[size] = cost[0];
			}
		}

		#endregion

		#region Polygon Generation - Plane

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="dx"></param>
		/// <param name="dy"></param>
		/// <returns></returns>
		public static VertexArrays CreatePlane(float x, float y, float z, uint dx, uint dy)
		{
			VertexArrays vertexArray = new VertexArrays();

			// Vertex generation
			Vertex3f[] position = new Vertex3f[(dx + 1) * (dy + 1)];
			float x2 = x / 2.0f, y2 = y / 2.0f;
			float vdx = x / dx, vdy = y / dy;
			int vidx = 0;

			for (float vy = -y2; vy <= y2; vy += vdy) {
				for (float vx = -x2; vx <= x2; vx += vdx) {
					Debug.Assert(vidx < position.Length);
					position[vidx++] = new Vertex3f(vx, vy, z);
				}
			}

			// Elements generation
			List<uint> indices = new List<uint>();
			uint restartIndex = ElementBuffer<uint>.DefaultRestartIndex;
			uint vstride = dx + 1;

			for (uint i = 0; i < dy; i++) {
				uint yoffset = i * vstride;

				// Triangle strip start
				indices.Add(yoffset + vstride);

				for (uint ix = 0; ix < dx; ix++) {
					uint xoffset = yoffset + ix;

					indices.Add(xoffset);
					indices.Add(xoffset + vstride + 1);
				}

				indices.Add(yoffset + vstride - 1);

				indices.Add(restartIndex);
			}

			// Buffer definition
			ArrayBuffer<Vertex3f> positionBuffer = new ArrayBuffer<Vertex3f>();
			positionBuffer.Create(position);
			vertexArray.SetArray(positionBuffer, VertexArraySemantic.Position);

			ElementBuffer<uint> elementBuffer = new ElementBuffer<uint>();
			elementBuffer.Create(indices.ToArray());
			elementBuffer.RestartIndexEnabled = true;
			vertexArray.SetElementArray(PrimitiveType.TriangleStrip, elementBuffer);

			return (vertexArray);
		}

		#endregion

		#region Polygon Generation - Cone

		public static VertexArrays CreateCone(float radius, float height, uint dr)
		{
			VertexArrays vertexArray = new VertexArrays();

			// Vertex generation
			Vertex3f[] position = new Vertex3f[dr + 2];
			int positionIndex = 0;

			position[positionIndex++] = new Vertex3f(0.0f, 0.0f, -height);

			double angleStep = Math.PI * 2.0 / dr;

			for (double angle = 0.0f; angle <= Math.PI * 2.0; angle += angleStep) {
				float x = radius * (float)Math.Cos(angle);
				float y = radius * (float)Math.Sin(angle);

				Debug.Assert(positionIndex < position.Length);
				position[positionIndex++] = new Vertex3f(x, y, 0.0f);
			}
			position[positionIndex++] = position[1];

			// Buffer definition
			ArrayBuffer<Vertex3f> positionBuffer = new ArrayBuffer<Vertex3f>();
			positionBuffer.Create(position);
			vertexArray.SetArray(positionBuffer, VertexArraySemantic.Position);

			vertexArray.SetElementArray(PrimitiveType.TriangleFan);

			return (vertexArray);
		}

		#endregion

		#region GraphicsResource Overrides

		/// <summary>
		/// Vertex array object class.
		/// </summary>
		internal static readonly Guid ThisObjectClass = new Guid("821E9AC8-6118-4543-B561-7C85BB998287");

		/// <summary>
		/// Vertex array object class.
		/// </summary>
		public override Guid ObjectClass
		{
			get {
				return (ThisObjectClass);
			}
		}

		/// <summary>
		/// Determine whether this BufferObject really exists for a specific context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that would have created (or a sharing one) the object. This context shall be current to
		/// the calling thread.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this BufferObject exists in the object space of <paramref name="ctx"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The object existence is done by checking a valid object by its name <see cref="IGraphicsResource.ObjectName"/>. This routine will test whether
		/// <paramref name="ctx"/> has created this BufferObject (or is sharing with the creator).
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current to the calling thread.
		/// </exception>
		public override bool Exists(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current", "ctx");

			// Object name space test (and 'ctx' sanity checks)
			if (base.Exists(ctx) == false)
				return (false);

			return (!RequiresName(ctx) || Gl.IsVertexArray(ObjectName));
		}

		/// <summary>
		/// Determine whether this object requires a name bound to a context or not.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// It returns always false. Names are managed manually
		/// </returns>
		protected override bool RequiresName(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			return (ctx.Extensions.VertexArrayObject_ARB || ctx.Extensions.VertexArrayObject_OES);
		}

		/// <summary>
		/// Create a BufferObject name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this buffer object name.
		/// </param>
		/// <returns>
		/// It returns a valid object name for this BufferObject.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		protected override uint CreateName(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current");

			Debug.Assert(ctx.Extensions.VertexArrayObject_ARB || ctx.Extensions.VertexArrayObject_OES || ctx.Version.IsCompatible(Gl.Version_300_ES));

			return (Gl.GenVertexArray());
		}

		/// <summary>
		/// Delete a BufferObject name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for deleting this buffer object name.
		/// </param>
		/// <param name="name">
		/// A <see cref="UInt32"/> that specify the object name to delete.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject does not exist.
		/// </exception>
		protected override void DeleteName(GraphicsContext ctx, uint name)
		{
			CheckThisExistence(ctx);

			Debug.Assert(ctx.Extensions.VertexArrayObject_ARB || ctx.Extensions.VertexArrayObject_OES || ctx.Version.IsCompatible(Gl.Version_300_ES));

			// Delete buffer object
			Gl.DeleteVertexArrays(name);
		}

		/// <summary>
		/// Actually create this BufferObject resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject has not client memory allocated and the hint is different from
		/// <see cref="BufferHint.StaticCpuDraw"/> or <see cref="BufferHint.DynamicCpuDraw"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject is currently mapped.
		/// </exception>
		protected override void CreateObject(GraphicsContext ctx)
		{
			CheckCurrentContext(ctx);

			// Validate vertex array object
			Validate();

			// Create vertex arrays
			foreach (IVertexArray vertexArray in DrawArrays)
				vertexArray.Create(ctx);

			// Create element arrays
			foreach (Element element in DrawElements)
				element.Create(ctx);

			// Create feedback buffer
			if (_FeedbackBuffer != null)
				_FeedbackBuffer.Create(ctx);

			ctx.Bind(this);
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="Boolean"/> indicating whether this method is called by <see cref="Dispose()"/>. If it is false,
		/// this method is called by the finalizer.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			// Base implementation
			base.Dispose(disposing);
			// Dispose related resources
			if (disposing) {
				// Unreference all collected array buffer objects
				foreach (VertexArray vertexArray in _VertexArrays.Values)
					vertexArray.Dispose();
				// Unreference all collected array indices
				foreach (Element vertexIndices in _Elements)
					vertexIndices.Dispose();
			}
		}

		#endregion

		#region IBindingResource Implementation

		/// <summary>
		/// Get the identifier of the binding point.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for binding.
		/// </param>
		int IBindingResource.GetBindingTarget(GraphicsContext ctx)
		{
			// Cannot lazy binding on textures if GL_ARB_vertex_array_object is not supported
			if (!ctx.Extensions.VertexArrayObject_ARB && !ctx.Extensions.VertexArrayObject_OES && !ctx.Version.IsCompatible(Gl.Version_300_ES))
				return (0);

			return (Gl.VERTEX_ARRAY_BINDING);
		}

		/// <summary>
		/// Bind this IBindingResource.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for binding.
		/// </param>
		void IBindingResource.Bind(GraphicsContext ctx)
		{
			if (ctx.Extensions.VertexArrayObject_ARB || ctx.Extensions.VertexArrayObject_OES || ctx.Version.IsCompatible(Gl.Version_300_ES))
				Gl.BindVertexArray(ObjectName);
		}

		/// <summary>
		/// Bind this IBindingResource.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for binding.
		/// </param>
		void IBindingResource.Unbind(GraphicsContext ctx)
		{
			if (ctx.Extensions.VertexArrayObject_ARB || ctx.Extensions.VertexArrayObject_OES || ctx.Version.IsCompatible(Gl.Version_300_ES)) {
				CheckThisExistence(ctx);
				Gl.BindVertexArray(InvalidObjectName);
			}
		}

		/// <summary>
		/// Check whether this IBindingResource is currently bound on the specified graphics context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for querying the current binding state.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this IBindingResource is currently bound on <paramref name="ctx"/>.
		/// </returns>
		bool IBindingResource.IsBound(GraphicsContext ctx)
		{
			int bindingTarget = ((IBindingResource)this).GetBindingTarget(ctx);
			int currentBufferObject;

			Debug.Assert(bindingTarget != 0);
			Gl.Get(bindingTarget, out currentBufferObject);

			return (currentBufferObject == (int)ObjectName);
		}

		#endregion
	}
}
