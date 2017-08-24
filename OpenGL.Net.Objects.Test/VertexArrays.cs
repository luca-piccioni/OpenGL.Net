using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGL.Objects.Test
{
	class VertexArraysTest
	{
		public void ExampleCreateVertexArrays(GraphicsContext ctx)
		{
			VertexArrays vao = new VertexArrays();
			ArrayBuffer<Vertex3f> aboPosition = new ArrayBuffer<Vertex3f>(BufferUsage.StaticDraw);
			ArrayBuffer<ColorRGBAF> aboColor = new ArrayBuffer<ColorRGBAF>(BufferUsage.StaticDraw);
			
			// ... create buffers ...
			
			// Note: assumes that ShaderProgram has a semantic
			vao.SetArray(aboPosition, VertexArraySemantic.Position);
			// Note: uses raw variable name
			vao.SetArray(aboColor, "my_Color", null);
			// Note: default attribute value assigned to all shader invocation instances
			vao.SetArrayDefault(Vertex4d.One, "my_Offset", null);

			// ... continue ...
		}

		public void ExampleSetVertexArraysElements(GraphicsContext ctx, ShaderProgram shaderProgram)
		{
			VertexArrays vao = new VertexArrays();
			
			// ... create and setup buffers ...

			// Draw the first 4 vertices as GL_LINES
			int idx1 = vao.SetElementArray(PrimitiveType.Lines, 0, 4);
			// Draw all other vertices using GL_TRIANGLES
			int idx2 = vao.SetElementArray(PrimitiveType.Triangles, 4, vao.ArrayLength);
			// Draw all vertices using GL_POINTS
			int idx3 = vao.SetElementArray(PrimitiveType.Points);

			// Create/update all resources linked to this instance
			vao.Create(ctx);

			// Draw all elements
			vao.Draw(ctx, shaderProgram);
			// Draw only the triangles
			vao.Draw(ctx, shaderProgram, idx2);
			// Draw using IElement interface (idx1 and idx3)
			vao.Draw(ctx, shaderProgram, vao.GetElementArray(idx1), vao.GetElementArray(idx3));
		}

	public void ExampleSetVertexArraysIndexedElements(GraphicsContext ctx, ShaderProgram shaderProgram)
	{
		VertexArrays vao = new VertexArrays();
			
		// ... create and setup buffers ...

		ElementBuffer<int> indexBuffer = new ElementBuffer<int>(BufferUsage.StaticDraw);

		indexBuffer.Create(new int[] { 0, 1, 2, 3, 2, 1 });

		// Draw the first 6 deferenced vertices as GL_TRIANGLES
		int idx1 = vao.SetElementArray(PrimitiveType.Triangles, indexBuffer);
		// Draw the first two deferenced vertices as GL_LINES
		int idx2 = vao.SetElementArray(PrimitiveType.Lines, indexBuffer, 0, 2);

		// Create/update all resources linked to this instance
		vao.Create(ctx);

		// Draw all elements
		vao.Draw(ctx, shaderProgram);
		// Draw only the triangles
		vao.Draw(ctx, shaderProgram, idx1);
	}
	}
}
