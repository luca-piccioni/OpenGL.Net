
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
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;

namespace OpenGL
{
	public sealed partial class GraphicsContext
	{
		#region Geometry Storage

		/// <summary>
		/// Array buffer used to store geometry information.
		/// </summary>
		private readonly ArrayBufferObject _DrawArrayBuffer = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.DynamicCpuDraw);

		private readonly VertexArrayObject _VertexArray = new VertexArrayObject();

		#endregion

		#region Geometry Callbacks Management

		public void QueryDrawMethods(KhronosVersion version)
		{
			FieldInfo[] drawDelegates = typeof(GeometryDrawDelegates).GetFields(BindingFlags.Public | BindingFlags.Instance);
			MethodInfo[] drawMethods = typeof(GraphicsContext).GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

			// Filter draw methods
			drawMethods = Array.FindAll(drawMethods, delegate (MethodInfo item) {
				return (item.Name.StartsWith("Draw"));
			});

			foreach (FieldInfo drawDelegate in drawDelegates) {
				Type drawDelegateType = typeof(GeometryDrawDelegates).GetNestedType(String.Format("{0}Delegate", drawDelegate.Name), BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
				if (drawDelegateType == null)
					continue;

				List<MethodInfo> drawDelegateMethods = new List<MethodInfo>(Array.FindAll(drawMethods, delegate (MethodInfo item) {
					return (item.Name.StartsWith(drawDelegate.Name));
				}));

				if (drawDelegateMethods.Count == 0)
					continue;

				drawDelegateMethods.Sort(delegate (MethodInfo a, MethodInfo b) {
					KhronosVersion aVersion = GetDrawMethodVersion(drawDelegate, a);
					KhronosVersion bVersion = GetDrawMethodVersion(drawDelegate, b);

					return (bVersion.CompareTo(aVersion));
				});

				// Select the delegate designed for the most advanced version
				for (int i = 0; i < drawDelegateMethods.Count; i++) {
					KhronosVersion drawDelegateVersion = GetDrawMethodVersion(drawDelegate, drawDelegateMethods[i]);

					if (drawDelegateVersion <= version) {
						Delegate drawDelegateValue = Delegate.CreateDelegate(drawDelegateType, this, drawDelegateMethods[i]);

						drawDelegate.SetValue(_GeometryDrawDelegates, drawDelegateValue);
						break;
					}
				}
			}
		}

		private static KhronosVersion GetDrawMethodVersion(FieldInfo drawDelegate, MethodInfo methodInfo)
		{
			Match versionMatch = Regex.Match(methodInfo.Name, String.Format(@"{0}_GL_(?<Major>\d+)_(?<Minor>\d+)", drawDelegate.Name));

			if (versionMatch.Success == false)
				throw new InvalidOperationException("unable to match draw method version");

			int major = Int32.Parse(versionMatch.Groups["Major"].Value);
			int minor = Int32.Parse(versionMatch.Groups["Minor"].Value);

			return (new KhronosVersion(major, minor, KhronosVersion.ApiGl));
		}

		#endregion

		#region Geometry Draw Delegates

		/// <summary>
		/// Geometry draw delegates container.
		/// </summary>
		private class GeometryDrawDelegates
		{
			#region Lines

			/// <summary>
			/// Delegate used for drawing a set of lines using <see cref="Vertex2f"/> coordinates.
			/// </summary>
			/// <param name="vertices">
			/// A <see cref="Vertex2f[]"/> that specify the vertices 2D position coordinates.
			/// </param>
			public delegate void DrawLines2fDelegate(Vertex2f[] vertices);

			/// <summary>
			/// Most appropriate delegate for drawing a line using a <see cref="DrawLine2fDelegate"/>.
			/// </summary>
			public DrawLines2fDelegate DrawLines2f;

			#endregion
		}

		/// <summary>
		/// Geometry draw delegates.
		/// </summary>
		private readonly GeometryDrawDelegates _GeometryDrawDelegates = new GeometryDrawDelegates();

		#endregion

		#region Lines

		public void DrawLines(params Vertex2f[] vertices)
		{
			if (vertices == null)
				throw new ArgumentNullException("vertices");
			if (vertices.Length == 0)
				return;

			// Draw geometry
			_GeometryDrawDelegates.DrawLines2f(vertices);
		}

		private void DrawLines2f_GL_1_0(Vertex2f[] vertices)
		{
			if ((vertices.Length % 2) != 0)
				throw new ArgumentException("length not a multiple of 2", "vertices");

			Gl.Begin(PrimitiveType.Lines);
			for (int i = 0; i < vertices.Length; i += 2) {
				Vertex2f v1 = vertices[i], v2 = vertices[i + 1];

				Gl.Vertex2(v1.x, v1.y);
				Gl.Vertex2(v2.x, v2.y);
			}
			Gl.End();
		}

		private void DrawLines2f_GL_1_1(Vertex2f[] vertices)
		{
			if ((vertices.Length % 2) != 0)
				throw new ArgumentException("length not a multiple of 2", "vertices");

			using (MemoryLock memoryLock = new MemoryLock(vertices)) {
				// Setup arrays
				Gl.VertexPointer(2, VertexPointerType.Float, 0, memoryLock.Address);
				Gl.EnableClientState(EnableCap.VertexArray);
				// Draw arrays
				Gl.DrawArrays(PrimitiveType.Lines, 0, vertices.Length);
			}
		}

		private void DrawLines2f_GL_3_2(Vertex2f[] vertices)
		{
			// Define geometry buffer
			_DrawArrayBuffer.Create(this, vertices);
			// Define geometry arrays
			_VertexArray.SetArray(_DrawArrayBuffer, VertexArraySemantic.Position);
			// Draw arrays
			_VertexArray.Draw(this, null);
		}

		#endregion
	}
}
