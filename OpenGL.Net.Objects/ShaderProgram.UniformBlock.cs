
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OpenGL.Objects
{
	public partial class ShaderProgram
	{
		#region Shader Program Uniform Blocks

		/// <summary>
		/// Shader program uniform block binding.
		/// </summary>
		[DebuggerDisplay("UniformBlockBinding: Name={Name} Location={Location}")]
		private class UniformBlockBinding
		{
			/// <summary>
			/// Construct a UniformBlockBinding.
			/// </summary>
			/// <param name="uniformName">
			/// A <see cref="String"/> that specify the uniform variable name.
			/// </param>
			/// <param name="uniformIndex">
			/// </param>
			/// <param name="uniformLocation">
			/// </param>
			public UniformBlockBinding(string uniformName, uint uniformIndex, int uniformLocation)
			{
				if (uniformName == null)
					throw new ArgumentNullException("uniformName");

				Name = uniformName;
				Index = uniformIndex;
				Location = uniformLocation;
			}

			/// <summary>
			/// The uniform block name.
			/// </summary>
			public readonly string Name;

			/// <summary>
			/// Uniform block index.
			/// </summary>
			public readonly uint Index;

			/// <summary>
			/// Uniform location.
			/// </summary>
			public readonly int Location;
		}

		private void CollectActiveUniformBlocks(GraphicsContext ctx)
		{
			if (ctx.Extensions.UniformBufferObject_ARB == false)
				return;

			int activeUniformBlocks = 0;

			Gl.GetProgram(ObjectName, Gl.ACTIVE_UNIFORM_BLOCKS, out activeUniformBlocks);
			for (int i = 1; i < activeUniformBlocks; i++) {
				uint uniformBlockIndex = (uint)i;
				int[] uniformBlockParams;

				try {
					// Get name length
					int uniformBlockNameLength;

					uniformBlockParams = new int[1];
					Gl.GetActiveUniformBlock(ObjectName, uniformBlockIndex, Gl.UNIFORM_BLOCK_NAME_LENGTH, uniformBlockParams);
					uniformBlockNameLength = uniformBlockParams[0];

					// Get uniform block name
					StringBuilder uniformBlockName = new StringBuilder(uniformBlockNameLength);
					int nameLength;

					Gl.GetActiveUniformBlockName(ObjectName, (uint)i, uniformBlockName.Capacity, out nameLength, uniformBlockName);
					Gl.CheckErrors();
				} catch (InvalidOperationException) {
					// Note: NVIDIA 266.72 on GeForce GT 540M on Windows 7 x64 does not manage very well uniform blocks.
					continue;
				}

				uniformBlockParams = new int[1];
				Gl.GetActiveUniformBlock(ObjectName, uniformBlockIndex, Gl.UNIFORM_BLOCK_DATA_SIZE, uniformBlockParams);

				uniformBlockParams = new int[1];
				Gl.GetActiveUniformBlock(ObjectName, uniformBlockIndex, Gl.UNIFORM_BLOCK_ACTIVE_UNIFORMS, uniformBlockParams);

				//uniformBlockParams = new int[1];
				//Gl.GetActiveUniformBlock(ObjectName, uniformBlockIndex, Gl.UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES, uniformBlockParams);
			}
		}

		/// <summary>
		/// Map active uniform block location with block name.
		/// </summary>
		private readonly Dictionary<string, UniformBlockBinding> _UniformBlockMap = new Dictionary<string, UniformBlockBinding>();

		#endregion
	}
}
