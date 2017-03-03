
// Copyright (C) 2010-2017 Luca Piccioni
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

namespace OpenGL.Objects
{
	/// <summary>
	/// A buffer object containing a set of uniform variables, which can be bound to a <see cref="ShaderProgram"/>.
	/// </summary>
	public partial class UniformBufferObject : BufferObject, IShaderUniformContainer
	{
		#region Constructors

		/// <summary>
		/// Construct an UniformBufferObject.
		/// </summary>
		/// <param name="hint">
		/// An <see cref="BufferObjectHint"/> that specify the data buffer usage hint.
		/// </param>
		public UniformBufferObject(BufferObjectHint hint) :
			base(BufferTargetARB.UniformBuffer, hint)
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
			AllocateClientBuffer(dataSize);
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
			if (ClientBufferAddress != IntPtr.Zero)
				AllocateClientBuffer(dataSize);
			// If not exists, set GPU buffer size; otherwise keep in synch with client buffer size
			ClientBufferSize = dataSize;
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

		internal class UniformSegment
		{
			public uint UniformIndex;

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

			public int Offset;

			public int ArrayStride;

			public int MatrixStride;

			public bool RowMajor;
		}

		private UniformSegment GetUniform(string uniformName)
		{
			if (uniformName == null)
				throw new ArgumentNullException("uniformName");

			UniformSegment uniformSegment;

			if (_UniformSegments.TryGetValue(uniformName, out uniformSegment))
				return (uniformSegment);

			return (null);
		}

		internal readonly Dictionary<string, UniformSegment> _UniformSegments = new Dictionary<string, UniformSegment>();

		#endregion
	}
}