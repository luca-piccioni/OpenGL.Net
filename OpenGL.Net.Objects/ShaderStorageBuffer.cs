
// Copyright (C) 2017 Luca Piccioni
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

namespace OpenGL.Objects
{
	/// <summary>
	/// 
	/// </summary>
	public sealed class ShaderStorageBuffer : Buffer, IBindingIndexResource
	{
		#region Constructors

		/// <summary>
		/// Construct an ShaderStorageBuffer.
		/// </summary>
		/// <param name="hint">
		/// An <see cref="BufferUsage"/> that specifies the data buffer usage hints.
		/// </param>
		public ShaderStorageBuffer(BufferUsage hint) :
			base(BufferTarget.ShaderStorageBuffer, hint)
		{
			
		}

		/// <summary>
		/// Construct an ShaderStorageBuffer.
		/// </summary>
		/// <param name="usageMask">
		/// A <see cref="MapBufferUsageMask"/> that specifies the data buffer usage mask.
		/// </param>
		public ShaderStorageBuffer(MapBufferUsageMask usageMask) :
			base(BufferTarget.ShaderStorageBuffer, usageMask)
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

		#region BufferObject Overrides

		/// <summary>
		/// Determine whether this object requires a name bound to a context or not.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// <para>
		/// It returns a boolean value indicating whether this GraphicsResource implementation requires a name
		/// generation on creation. In the case this routine returns true, the routine <see cref="CreateName"/>
		/// will be called (and it must be overriden). In  the case this routine returns false, the routine
		/// <see cref="CreateName"/> won't be called (and indeed it is not necessary to override it) and a
		/// name is generated automatically in a context-independent manner.
		/// </para>
		/// <para>
		/// This implementation check the GL_ARB_vertex_array_object extension availability.
		/// </para>
		/// </returns>
		protected override bool RequiresName(GraphicsContext ctx)
		{
			return (true);
		}

		#endregion

		#region IBindingIndexResource Implementation

		/// <summary>
		/// Get the identifier of the binding point.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for binding.
		/// </param>
		BufferTarget IBindingIndexResource.GetBindingTarget(GraphicsContext ctx)
		{
			return (BufferTarget.ShaderStorageBuffer);
		}

		/// <summary>
		/// Current binding point of the IBindingIndexResource.
		/// </summary>
		uint IBindingIndexResource.BindingIndex { get; set; }

		#endregion
	}
}
