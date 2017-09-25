
// Copyright (C) 2009-2017 Luca Piccioni
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

// Symbol for enabling shader program uniforms bindings caching: performance gain avoiding
// redundant hash-table lookups for uniform names.
#define ENABLE_UNIFORM_BLOCK_CACHING

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
				Gl.GetActiveUniformBlock(program.ObjectName, Index, UniformBlockPName.UniformBlockNameLength, uniformBlockParams);
				uniformBlockNameLength = uniformBlockParams[0];

				// Name
				StringBuilder uniformBlockNameBuffer = new StringBuilder(uniformBlockNameLength);
				int nameLength;
				Gl.GetActiveUniformBlockName(program.ObjectName, Index, uniformBlockNameBuffer.Capacity, out nameLength, uniformBlockNameBuffer);
				Gl.CheckErrors();
				
				Name = uniformBlockNameBuffer.ToString();

				// Data size
				uniformBlockParams = new int[1];
				Gl.GetActiveUniformBlock(program.ObjectName, Index, UniformBlockPName.UniformBlockDataSize, uniformBlockParams);

				DataSize = (uint)uniformBlockParams[0];

				// Active uniforms
				uniformBlockParams = new int[1];
				Gl.GetActiveUniformBlock(program.ObjectName, Index, UniformBlockPName.UniformBlockActiveUniforms, uniformBlockParams);

				ActiveUniforms = (uint)uniformBlockParams[0];

				// Uniform indices
				uniformBlockParams = new int[ActiveUniforms];
				Gl.GetActiveUniformBlock(program.ObjectName, Index, UniformBlockPName.UniformBlockActiveUniformIndices, uniformBlockParams);

				UniformIndices = Array.ConvertAll(uniformBlockParams, delegate(int item) { return ((uint)item); });
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
			/// Indices of the uniforms belonging to this uniform buffer.
			/// </summary>
			public readonly uint[] UniformIndices;

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

			Gl.GetProgram(ObjectName, ProgramProperty.ActiveUniformBlocks, out activeUniformBlocks);

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

		#region Uniform Block Mapping/Creation

		/// <summary>
		/// Create an <see cref="UniformBuffer"/> useful for backing with a buffer object the specified uniform block.
		/// </summary>
		/// <param name="uniformBlockName"></param>
		/// <param name="hint"></param>
		/// <returns></returns>
		public UniformBuffer CreateUniformBlock(string uniformBlockName, BufferUsage hint)
		{
			UniformBlockBinding uniformBlockBinding = GetUniformBlock(uniformBlockName);
			if (uniformBlockBinding == null)
				throw new ArgumentException("no uniform block with such name", "uniformBlockName");

			UniformBuffer uniformBuffer = new UniformBuffer(hint);

			// Allocate client storage
			uniformBuffer.Create(uniformBlockBinding.DataSize);
			// Map uniform names with 
			MapUniformBlock(uniformBlockName, uniformBuffer);

			return (uniformBuffer);
		}

		/// <summary>
		/// Create an <see cref="UniformBuffer"/> useful for backing with a buffer object the specified uniform block.
		/// </summary>
		/// <param name="uniformBlockName"></param>
		/// <param name="usageMask"></param>
		/// <returns></returns>
		public UniformBuffer CreateUniformBlock(string uniformBlockName, MapBufferUsageMask usageMask)
		{
			UniformBlockBinding uniformBlockBinding = GetUniformBlock(uniformBlockName);
			if (uniformBlockBinding == null)
				throw new ArgumentException("no uniform block with such name", "uniformBlockName");

			UniformBuffer uniformBuffer = new UniformBuffer(usageMask);

			// Allocate client storage
			uniformBuffer.Create(uniformBlockBinding.DataSize);
			// Map uniform names with 
			MapUniformBlock(uniformBlockName, uniformBuffer);

			return (uniformBuffer);
		}

		private void MapUniformBlock(string uniformBlockName, UniformBuffer uniformBuffer)
		{
			UniformBlockBinding uniformBlockBinding = GetUniformBlock(uniformBlockName);
			if (uniformBlockBinding == null)
				throw new ArgumentException("no uniform block with such name", "uniformBlockName");

			for (int i = 0; i < uniformBlockBinding.UniformIndices.Length; i++) {
				uint uniformIndex = uniformBlockBinding.UniformIndices[i];

				UniformBinding uniformBinding;

				if (_UniformIndexMap.TryGetValue(uniformIndex, out uniformBinding) == false)
					throw new InvalidOperationException("uniform buffer index mismatch with uniforms");

				UniformBuffer.UniformSegment uniformSegment = new UniformBuffer.UniformSegment();

				uniformSegment.UniformIndex = uniformIndex;
				uniformSegment.Type = uniformBinding.UniformType;
				uniformSegment.Offset = uniformBinding.BlockOffset;
				uniformSegment.ArrayStride = uniformBinding.BlockArrayStride;
				uniformSegment.MatrixStride = uniformBinding.BlockMatrixStride;
				uniformSegment.RowMajor = uniformBinding.BlockMatrixRowMajor;

				uniformBuffer._UniformSegments[uniformBinding.Name] = uniformSegment;
			}

			foreach (KeyValuePair<string, UniformBinding> pair in _UniformMap) {
				if (pair.Value != null)
					continue;

				uniformBuffer._UniformSegments[pair.Key] = null;
			}
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
		public void SetUniformBlock(GraphicsContext ctx, string uniformBlockName, UniformBuffer uniformBuffer)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (uniformBuffer == null)
				throw new ArgumentNullException("uniformBuffer");

			// Select a binding point, if still invalid
			ctx.Bind(uniformBuffer);

			UniformBlockBinding uniformBlockBinding = GetUniformBlock(uniformBlockName);
			if (uniformBlockBinding == null)
				throw new ArgumentException("no uniform block with such name", "uniformBlockName");

#if ENABLE_UNIFORM_BLOCK_CACHING
			if (IsUniformBlockChanged(uniformBlockBinding.Index, uniformBuffer) == false)
				return;
#endif

			// Link the uniform buffer
			Gl.UniformBlockBinding(ObjectName, uniformBlockBinding.Index, uniformBuffer.BindingIndex);

#if ENABLE_UNIFORM_BLOCK_CACHING
			CacheUniformBlock(uniformBlockBinding.Index, uniformBuffer);
#endif
		}

		#endregion

		#region Uniform Block Caching

		/// <summary>
		/// Cache the current uniform value. Used to minimize Uniform* calls at the cost of comparing the cached
		/// object with the call arguments.
		/// </summary>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specifies the uniform variable name.
		/// </param>
		/// <param name="uniformValue">
		/// A <see cref="Object"/> that specifies the uniform variable value.
		/// </param>
		private void CacheUniformBlock(uint index, UniformBuffer uniformBuffer)
		{
			Debug.Assert(uniformBuffer != null);
			_UniformBlocks[index] = uniformBuffer.BindingIndex;
		}

		/// <summary>
		/// Determine whether if an uniform value is different from the one currently cached.
		/// </summary>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specifies the uniform variable name.
		/// </param>
		/// <param name="uniformValue">
		/// A <see cref="Object"/> that specifies the uniform variable value updated.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="uniformValue"/> is actually
		/// different from the current uniform value.
		/// </returns>
		private bool IsUniformBlockChanged(uint index, UniformBuffer uniformBuffer)
		{
			uint cachedBindingIndex;

			if (_UniformBlocks.TryGetValue(index, out cachedBindingIndex) == false)
				return (true);

			return (cachedBindingIndex != uniformBuffer.BindingIndex);
		}

		/// <summary>
		/// Map program uniform blocks with the last value set with UniformBlockBinding method.
		/// </summary>
		private readonly Dictionary<uint, uint> _UniformBlocks = new Dictionary<uint, uint>();

		#endregion
	}
}
