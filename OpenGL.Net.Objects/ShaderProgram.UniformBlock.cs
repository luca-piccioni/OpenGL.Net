
// Copyright (C) 2009-2016 Luca Piccioni
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

// Symbol for enabling shader program uniforms bindings caching: performance gain avoiding
// redundant hash-table lookups for uniform names.
#undef ENABLE_UNIFORM_BLOCK_CACHING

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OpenGL.Objects
{
	public partial class ShaderProgram
	{
		#region Uniform Blocks

		/// <summary>
		/// Shader program uniform block binding.
		/// </summary>
		[DebuggerDisplay("UniformBlockBinding: Name={Name} DataSize={DataSize} ActiveUniforms={ActiveUniforms}")]
		private class UniformBlockBinding
		{
			#region Constructors

			/// <summary>
			/// Construct an UniformBlockBinding.
			/// </summary>
			/// <param name="program">
			/// The <see cref="ShaderProgram"/> defining this uniform block.
			/// </param>
			/// <param name="uniformBlockIndex">
			/// A <see cref="UInt32"/> that specifies the index used for identifying the uniform block.
			/// </param>
			public UniformBlockBinding(ShaderProgram program, uint uniformBlockIndex)
			{
				if (program == null)
					throw new ArgumentNullException("program");

				int[] uniformBlockParams;

				// Index
				Index = uniformBlockIndex;

				// Name length
				int uniformBlockNameLength;

				uniformBlockParams = new int[1];
				Gl.GetActiveUniformBlock(program.ObjectName, Index, Gl.UNIFORM_BLOCK_NAME_LENGTH, uniformBlockParams);
				uniformBlockNameLength = uniformBlockParams[0];

				// Name
				StringBuilder uniformBlockNameBuffer = new StringBuilder(uniformBlockNameLength);
				int nameLength;
				Gl.GetActiveUniformBlockName(program.ObjectName, Index, uniformBlockNameBuffer.Capacity, out nameLength, uniformBlockNameBuffer);
				Gl.CheckErrors();
				
				Name = uniformBlockNameBuffer.ToString();

				// Data size
				uniformBlockParams = new int[1];
				Gl.GetActiveUniformBlock(program.ObjectName, Index, Gl.UNIFORM_BLOCK_DATA_SIZE, uniformBlockParams);

				DataSize = (uint)uniformBlockParams[0];

				// Active uniforms
				uniformBlockParams = new int[1];
				Gl.GetActiveUniformBlock(program.ObjectName, Index, Gl.UNIFORM_BLOCK_ACTIVE_UNIFORMS, uniformBlockParams);

				ActiveUniforms = (uint)uniformBlockParams[0];

				// Uniform indices
				uniformBlockParams = new int[ActiveUniforms];
				Gl.GetActiveUniformBlock(program.ObjectName, Index, Gl.UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES, uniformBlockParams);

				UniformIndices = uniformBlockParams;
			}

			#endregion

			#region Information

			/// <summary>
			/// Uniform block index.
			/// </summary>
			public readonly uint Index;

			/// <summary>
			/// The uniform block name.
			/// </summary>
			public readonly string Name;

			/// <summary>
			/// The uniform block data size, in bytes.
			/// </summary>
			public readonly uint DataSize;

			/// <summary>
			/// The count of the active uniforms hold by the uniform block.
			/// </summary>
			public readonly uint ActiveUniforms;

			/// <summary>
			/// 
			/// </summary>
			public readonly int[] UniformIndices;

			#endregion
		}

		/// <summary>
		/// Collection of active uniforms blocks on this ShaderProgram.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This list may be not exahustive as someone could think: this list is initialize at link time, and its contents
		/// is determined by the current OpenGL driver used. To check effectively the uniform variable activeness, use
		/// <see cref="IsActiveUniform"/> method.
		/// </para>
		/// <para>
		/// After a call to <see cref="IsActiveUniform"/> method, the uniform variable (only if active) will be collected in
		/// the collection returned by this property.
		/// </para>
		/// </remarks>
		public ICollection<string> ActiveUniformBlocks
		{
			get { return (_UniformBlockMap.Keys); }
		}

		/// <summary>
		/// Determine whether an uniform block is active or not.
		/// </summary>
		/// <param name="uniformBlockName">
		/// A <see cref="String"/> which specify the uniform block name.
		/// </param>
		/// <returns>
		/// </returns>
		public bool IsActiveUniformBlock(string uniformBlockName)
		{
			return (_UniformBlockMap.ContainsKey(uniformBlockName));
		}

		/// <summary>
		/// Request uniform block information.
		/// </summary>
		/// <param name="uniformBlockName">
		/// A <see cref="String"/> of the uniform block name.
		/// </param>
		/// <returns></returns>
		private UniformBlockBinding GetUniformBlock(string uniformBlockName)
		{
			if (uniformBlockName == null)
				throw new ArgumentNullException("uniformBlockName");

			UniformBlockBinding uniformBlockBinding;

			if (_UniformBlockMap.TryGetValue(uniformBlockName, out uniformBlockBinding))
				return (uniformBlockBinding);

			return (null);
		}

		/// <summary>
		/// Collect information about uniform blocks defined in a ShaderProgram instance.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for linking the ShaderProgram instance.
		/// </param>
		private void CollectActiveUniformBlocks(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			if (ctx.Extensions.UniformBufferObject_ARB == false)
				return;

			int activeUniformBlocks = 0;

			Gl.GetProgram(ObjectName, Gl.ACTIVE_UNIFORM_BLOCKS, out activeUniformBlocks);

			// Clear uniform mapping
			_UniformBlockMap.Clear();

			for (int i = 0; i < activeUniformBlocks; i++) {
				UniformBlockBinding uniformBlockBinding = new UniformBlockBinding(this, (uint)i);

				_UniformBlockMap.Add(uniformBlockBinding.Name, uniformBlockBinding);
			}
		}

		/// <summary>
		/// Map active uniform block location with block name.
		/// </summary>
		private readonly Dictionary<string, UniformBlockBinding> _UniformBlockMap = new Dictionary<string, UniformBlockBinding>();

		#endregion

		#region Uniform Block Creation

		public UniformBufferObject CreateUniformBlock(string uniformBlockName, BufferObjectHint hint)
		{
			UniformBlockBinding uniformBlockBinding = GetUniformBlock(uniformBlockName);
			if (uniformBlockBinding == null)
				throw new ArgumentException("no uniform block with such name", "uniformBlockName");

			UniformBufferObject uniformBuffer = new UniformBufferObject(hint);

			uniformBuffer.Create(uniformBlockBinding.DataSize);

			return (uniformBuffer);
		}

		public void CreateUniformBlock(string uniformBlockName, UniformBufferObject uniformBuffer)
		{
			if (uniformBuffer == null)
				throw new ArgumentNullException("uniformBuffer");

			UniformBlockBinding uniformBlockBinding = GetUniformBlock(uniformBlockName);
			if (uniformBlockBinding == null)
				throw new ArgumentException("no uniform block with such name", "uniformBlockName");

			// Create/Update
			uniformBuffer.Create(uniformBlockBinding.DataSize);
		}

		#endregion

		#region Set Uniform Blocks

		/// <summary>
		/// Set uniform state variable (floating-point variable).
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="v">
		/// A <see cref="Single"/> holding the uniform variabile data.
		/// </param>
		public void SetUniformBlock(GraphicsContext ctx, string uniformBlockName, UniformBufferObject uniformBuffer)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (uniformBuffer == null)
				throw new ArgumentNullException("uniformBuffer");

			UniformBlockBinding uniformBlockBinding = GetUniformBlock(uniformBlockName);
			if (uniformBlockBinding == null)
				throw new ArgumentException("no uniform block with such name", "uniformBlockName");

			// Select a binding point
			ctx.Bind(uniformBuffer);
			// Link the uniform buffer
			Gl.UniformBlockBinding(ObjectName, uniformBlockBinding.Index, uniformBuffer.BindingIndex);
		}

		#endregion
	}
}
