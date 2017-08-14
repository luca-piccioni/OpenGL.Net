
// Copyright (C) 2017 Luca Piccioni
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

namespace OpenGL.Objects
{
	/// <summary>
	/// Delegate used for generating texture coordinates on <see cref="VertexArrays"/>.
	/// </summary>
	/// <param name="position"></param>
	/// <returns></returns>
	public delegate Vertex2f VertexArrayTexGenDelegate(Vertex3f position);

	/// <summary>
	/// Interface used for generating texture coordinates on <see cref="VertexArrays"/>.
	/// </summary>
	public interface IVertexArrayTexGen
	{
		/// <summary>
		/// Initialize the IVertexArrayTexGen instance.
		/// </summary>
		void Initialize(VertexArrays vertexArray);

		/// <summary>
		/// Generate the texture coordinate for the specified vertex.
		/// </summary>
		/// <param name="position"></param>
		/// <returns></returns>
		Vertex2f Generate(Vertex3f position);
	}

	/// <summary>
	/// Collection of common texture generators.
	/// </summary>
	public static class VertexArrayTexGen
	{
		public abstract class TexGenBase : IVertexArrayTexGen
		{
			#region Constructors

			protected TexGenBase()
			{

			}

			protected TexGenBase(float xRepeat, float yRepeat)
			{
				Repeat = new Vertex2f(xRepeat, yRepeat);
			}

			#endregion

			#region Common Properties

			/// <summary>
			/// Get or set the texture coordinate repeat multipliers.
			/// </summary>
			public Vertex2f Repeat {
				get { return (_Repeat); }
				set { _Repeat = value; }
			}

			/// <summary>
			/// Repeat multipliers.
			/// </summary>
			private Vertex2f _Repeat = new Vertex2f(1.0f);

			#endregion

			#region IVertexArrayTexGen Implementation

			/// <summary>
			/// Initialize the IVertexArrayTexGen instance.
			/// </summary>
			public virtual void Initialize(VertexArrays vertexArray)
			{

			}

			/// <summary>
			/// Generate the texture coordinate for the specified vertex.
			/// </summary>
			/// <param name="position"></param>
			/// <returns></returns>
			public abstract Vertex2f Generate(Vertex3f position);

			#endregion
		}

		#region Sphere Mapping

		/// <summary>
		/// A <see cref="VertexArrayTexGenDelegate"/> mapping a sphere.
		/// </summary>
		/// <param name="v"></param>
		/// <returns></returns>
		public static Vertex2f SphereMap(Vertex3f v)
		{
			v.Normalize();

			float x = (float)(Math.Atan2(v.z, v.x) / Math.PI) * 0.5f + 0.5f;
			float y = (float)(Math.Asin(v.y) / (Math.PI / 2.0)) * 0.5f + 0.5f;

			Debug.Assert(x >= 0.0f && x <= 1.0f);
			Debug.Assert(y >= 0.0f && y <= 1.0f);

			return (new Vertex2f(x, y));
		}

		public sealed class Sphere : TexGenBase
		{
			#region Constructors

			public Sphere()
			{

			}

			public Sphere(float xRepeat, float yRepeat) : base(xRepeat, yRepeat)
			{
				
			}

			#endregion

			#region TexGenBase Overrides

			/// <summary>
			/// Initialize the IVertexArrayTexGen instance.
			/// </summary>
			public override void Initialize(VertexArrays vertexArray)
			{

			}

			/// <summary>
			/// Generate the texture coordinate for the specified vertex.
			/// </summary>
			/// <param name="v"></param>
			/// <returns></returns>
			public override Vertex2f Generate(Vertex3f v)
			{
				v.Normalize();

				float x = (float)(Math.Atan2(v.z, v.x) / Math.PI) * 0.5f + 0.5f;
				float y = (float)(Math.Asin(v.y) / (Math.PI / 2.0)) * 0.5f + 0.5f;

				Debug.Assert(x >= 0.0f && x <= 1.0f);
				Debug.Assert(y >= 0.0f && y <= 1.0f);

				return (new Vertex2f(x * Repeat.x, y * Repeat.y));
			}

			#endregion
		}

		#endregion
	}
}
