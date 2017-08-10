
// Copyright (C) 2010-2017 Luca Piccioni
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

using UniformSegmentDictionary = OpenGL.Objects.Collections.StringDictionary<OpenGL.Objects.UniformBuffer.UniformSegment>;

using System;
using System.Diagnostics;

namespace OpenGL.Objects
{
	/// <summary>
	/// A buffer object containing a set of uniform variables, which can be bound to a <see cref="ShaderProgram"/>.
	/// </summary>
	public partial class UniformBuffer : Buffer, IShaderUniformContainer
	{
		#region Constructors

		/// <summary>
		/// Construct an UniformBufferObject.
		/// </summary>
		/// <param name="hint">
		/// An <see cref="BufferHint"/> that specify the data buffer usage hint.
		/// </param>
		public UniformBuffer(BufferUsage hint) :
			base(BufferTarget.UniformBuffer, hint)
		{
			
		}

		/// <summary>
		/// Construct an UniformBufferObject.
		/// </summary>
		/// <param name="usageMask">
		/// An <see cref="MapBufferUsageMask"/> that specify the buffer storage usage mask.
		/// </param>
		public UniformBuffer(MapBufferUsageMask usageMask) :
			base(BufferTarget.UniformBuffer, usageMask)
		{
			
		}

		#endregion

		#region Create

		#region Create(uint dataSize)

		/// <summary>
		/// Create this UniformBufferObject by specifing only the number of items.
		/// </summary>
		/// <param name="dataSize">
		/// A <see cref="UInt32"/> that specify the size of the data hold by this UniformBufferObject, in bytes.
		/// </param>
		/// <remarks>
		/// <para>
		/// Previous content of the client buffer is discarded.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="dataSize"/> is zero.
		/// </exception>
		public void Create(uint dataSize)
		{
			if (dataSize == 0)
				throw new ArgumentException("invalid", "itemsCount");

			// Allocate buffer
			CreateCpuBuffer(dataSize);
		}

		#endregion

		#region Create(GraphicsContext ctx, uint dataSize)

		/// <summary>
		/// Create this UniformBufferObject by specifing only the number of items.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used to define this UniformBufferObject.
		/// </param>
		/// <param name="dataSize">
		/// A <see cref="UInt32"/> that specify the size of the data hold by this UniformBufferObject, in bytes.
		/// </param>
		/// <remarks>
		/// <para>
		/// Previous content of the client buffer is discarded, if any was defined.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="dataSize"/> is zero.
		/// </exception>
		public void Create(GraphicsContext ctx, uint dataSize)
		{
			CheckCurrentContext(ctx);

			if (dataSize == 0)
				throw new ArgumentException("invalid", "itemsCount");

			// Object already existing: resize client buffer, if any
			if (CpuBufferAddress != IntPtr.Zero)
				CreateCpuBuffer(dataSize);
			// If not exists, set GPU buffer size; otherwise keep in synch with client buffer size
			CpuBufferSize = dataSize;
			// Allocate object
			Create(ctx);
		}

		#endregion

		#endregion

		#region Binding Index

		/// <summary>
		/// Current binding point of the UniformBufferObject.
		/// </summary>
		/// <remarks>
		/// The UNIFORM_BUFFER target has a binding index.
		/// </remarks>
		internal uint BindingIndex = GraphicsContext.InvalidBindingIndex;

		#endregion

		#region Elements Mapping

		/// <summary>
		/// Uniform segment localizing an uniform buffer variable.
		/// </summary>
		internal class UniformSegment
		{
			/// <summary>
			/// The index of the uniform variable.
			/// </summary>
			public uint UniformIndex;

			/// <summary>
			/// The type of the uniform variable.
			/// </summary>
			public ShaderUniformType Type;

			/// <summary>
			/// Check uniform variable coherence.
			/// </summary>
			/// <param name="uniform">
			/// A <see cref="UniformBinding"/> that specify the uniform name to check.
			/// </param>
			/// <param name="uniformRequestTypes">
			/// A sequence of OpenGL constants that are the allowed types for the specified uniform.
			/// </param>
			/// <exception cref="InvalidOperationException">
			/// Exception thrown if the type of the uniform variable <paramref name="uniform"/> does not match any value specified by <paramref name="uniformRequestTypes"/>.
			/// </exception>
			[Conditional("GL_DEBUG_PENDANTIC")]
			public void CheckType(params int[] uniformRequestTypes)
			{
				if (uniformRequestTypes == null)
					throw new ArgumentNullException("uniformRequestTypes");

				/* ! Check: required uniform type shall correspond */
				foreach (int uniformReqtype in uniformRequestTypes)
					if ((int)Type == uniformReqtype)
						return;

				// 3.3.0 NVIDIA 310.44 confuse float uniforms (maybe in structs?) as vec4
				if (Type == ShaderUniformType.Vec4)
					return;
				// Allow unknown uniform type
				if (Type == ShaderUniformType.Unknown)
					return;

				throw new InvalidOperationException("uniform type mismatch");
			}

			/// <summary>
			/// The offset of the uniform variable from the beginning of the uniform buffer, in bytes.
			/// </summary>
			public int Offset;

			/// <summary>
			/// The stride between array elements, in case the uniform variable is an array variable, in bytes.
			/// </summary>
			public int ArrayStride;

			/// <summary>
			/// The stride between matrix elements, in case the uniform variable is an array of matrix variable, in bytes.
			/// </summary>
			public int MatrixStride;

			/// <summary>
			/// The flag indicating whether the the matrix components are stored in row-major order.
			/// </summary>
			public bool RowMajor;
		}

		/// <summary>
		/// Get the <see cref="UniformSegment"/> corresponding to the specified uniform variable name.
		/// </summary>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specifies the uniform varialble name.
		/// </param>
		/// <returns>
		/// It returns the <see cref="UniformSegment"/> correponding to <paramref name="uniformName"/>, or null if
		/// no corrispondence was found.
		/// </returns>
		private UniformSegment GetUniform(string uniformName)
		{
			if (uniformName == null)
				throw new ArgumentNullException("uniformName");

			UniformSegment uniformSegment;

			if (_UniformSegments.TryGetValue(uniformName, out uniformSegment))
				return (uniformSegment);

			return (null);
		}

		/// <summary>
		/// Maap between <see cref="UniformSegment"/> and uniform names.
		/// </summary>
		internal readonly UniformSegmentDictionary _UniformSegments = new UniformSegmentDictionary();

		#endregion
	}
}