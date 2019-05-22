
// Copyright (C) 2019 Luca Piccioni
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
using System.Text;

namespace OpenGL.Objects
{
	public partial class ShaderProgram
	{
		#region Storage Buffers

		/// <summary>
		/// Shader program storage buffer binding.
		/// </summary>
		[DebuggerDisplay("StorageBufferBinding: Name={Name} DataSize={DataSize}")]
		private class StorageBufferBinding
		{
			#region Constructors

			/// <summary>
			/// Construct a StorageBufferBinding.
			/// </summary>
			/// <param name="index">
			/// A <see cref="uint"/> that specifies the index used for identifying the storage buffer.
			/// </param>
			/// <param name="name">
			/// A <see cref="string"/> that specifies the name used in source for the storage buffer.
			/// </param>
			public StorageBufferBinding(uint index, string name)
			{
				Index = index;
				Name = name;
			}

			#endregion

			#region Information

			/// <summary>
			/// Storage buffer index.
			/// </summary>
			public readonly uint Index;

			/// <summary>
			/// The storage buffer name.
			/// </summary>
			public readonly string Name;

			/// <summary>
			/// The current binding point index linked to.
			/// </summary>
			public uint BufferBinding;

			#endregion
		}

		/// <summary>
		/// Collect information about uniform blocks defined in a ShaderProgram instance.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for linking the ShaderProgram instance.
		/// </param>
		private void CollectActiveStorageBuffers(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException(nameof(ctx));

#if !MONODROID
			if (!ctx.Extensions.ShaderStorageBufferObject_ARB || !ctx.Extensions.ProgramInterfaceQuery_ARB)
				return;

			CollectActiveStorageBuffers_ProgramInterfaceQuery(ctx);
#endif
		}

#if !MONODROID

		/// <summary>
		/// Collect storage buffers information using GL_ARB_program_interface_query.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> on which this program was created.
		/// </param>
		private void CollectActiveStorageBuffers_ProgramInterfaceQuery(GraphicsContext ctx)
		{
			int activeResources;

			Gl.GetProgramInterface(ObjectName, ProgramInterface.ShaderStorageBlock, ProgramInterfacePName.ActiveResources, out activeResources);

			int[] properties = new int[] {
				Gl.NAME_LENGTH,
				Gl.BUFFER_BINDING
			};

			int[] values = new int[properties.Length];
			int valuesLength;

			for (uint i = 0; i < activeResources; i++) {
				// Get resource information
				Gl.GetProgramResource(ObjectName, ProgramInterface.ShaderStorageBlock, i, properties, out valuesLength, values);

				// Get resource name
				int nameLength, nameBufferSize = values[Array.IndexOf(properties, Gl.NAME_LENGTH)] + 2;

				StringBuilder nameBuilder = new StringBuilder(nameBufferSize + 2);
				nameBuilder.EnsureCapacity(nameBufferSize);

				Gl.GetProgramResourceName(ObjectName, ProgramInterface.ShaderStorageBlock, i, nameBufferSize, out nameLength, nameBuilder);

				// Track resource
				StorageBufferBinding resourceBinding = new StorageBufferBinding(i, nameBuilder.ToString());

				// - Get the default binding
				resourceBinding.BufferBinding = (uint)values[Array.IndexOf(properties, Gl.BUFFER_BINDING)];

				_StorageBufferMap.Add(resourceBinding.Name, resourceBinding);
			}
		}

#endif

		/// <summary>
		/// Collection of active storage buffers on this ShaderProgram.
		/// </summary>
		public ICollection<string> ActiveStorageBuffers
		{
			get
			{
				return _StorageBufferMap.Keys;
			}
		}

		/// <summary>
		/// Determine whether an storage buffer is active or not.
		/// </summary>
		/// <param name="storageBufferName">
		/// A <see cref="string"/> which specify the uniform name.
		/// </param>
		/// <returns>
		/// </returns>
		public bool IsStorageBuffer(string storageBufferName)
		{
			return _StorageBufferMap.ContainsKey(storageBufferName);
		}

		/// <summary>
		/// Map active storage buffer location with block name.
		/// </summary>
		private readonly Dictionary<string, StorageBufferBinding> _StorageBufferMap = new Dictionary<string, StorageBufferBinding>();

		#endregion

		#region Set Storage Buffer

		/// <summary>
		/// Link a <see cref="ShaderStorageBuffer"/> to this ShaderProgram.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for operations.
		/// </param>
		/// <param name="storageBufferName">
		/// A <see cref="String"/> that specify the variable name in the shader source.
		/// </param>
		/// <param name="storageBuffer">
		/// The <see cref="Buffer"/> to be linked to <paramref name="storageBufferName"/>.
		/// </param>
		public void SetStorageBuffer(GraphicsContext ctx, string storageBufferName, Buffer storageBuffer)
		{
			CheckCurrentContext(ctx);
			if (storageBufferName == null)
				throw new ArgumentNullException(nameof(storageBufferName));
			CheckThisExistence(ctx);
			CheckThatExistence(ctx, storageBuffer);

			if (!ctx.Extensions.ShaderStorageBufferObject_ARB)
				throw new InvalidOperationException("GL_ARB_shader_storage_buffer_object not supported");

			StorageBufferBinding storageBufferBinding;

			if (!_StorageBufferMap.TryGetValue(storageBufferName, out storageBufferBinding))
				throw new InvalidOperationException($"unrecognized storage buffer '{storageBufferName}'");

			// Bind to the most appropriate binding index
			IBindingIndexResource bindingIndexResource = storageBuffer;

			ctx.BindIndex(bindingIndexResource);

			// Avoid unnecessary glShaderStorageBlockBinding call
			//if (storageBufferBinding.BufferBinding == bindingIndexResource.BindingIndex)
			//	return;

			Gl.ShaderStorageBlockBinding(ObjectName, storageBufferBinding.Index, bindingIndexResource.BindingIndex);
			storageBufferBinding.BufferBinding = bindingIndexResource.BindingIndex;
		}

		#endregion
	}
}
