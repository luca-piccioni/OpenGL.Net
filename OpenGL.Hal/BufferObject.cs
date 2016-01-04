
// Copyright (C) 2009-2015 Luca Piccioni
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
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Data buffer object abstraction.
	/// </summary>
	/// <remarks>
	/// <para>
	/// Any data that is transferred from and to the GPU shall be organized into a BufferObject instances.
	/// </para>
	/// <para>
	/// This class actually stores the data using a <see cref="AlignedMemoryBuffer"/>, indeed un unmanaged
	/// chunk of memory (aligned to 16 byte boundaries).
	/// </para>
	/// <para>
	/// Any BufferObject instance can be mapped into userspace memory, offering the possibility to modify
	/// partially the buffer object, minimizing the data transfer between CPU and GPU.
	/// </para>
	/// </remarks>
	public abstract class BufferObject : GraphicsResource
	{
		#region Constructors

		/// <summary>
		/// Construct a BufferObject determining its type, data usage and transfer mode.
		/// </summary>
		/// <param name="type">
		/// A <see cref="BufferTargetARB"/> that specify the buffer object type.
		/// </param>
		/// <param name="hint">
		/// An <see cref="BufferObjectHint"/> that specify the data buffer usage hints.
		/// </param>
		protected BufferObject(BufferTargetARB type, BufferObjectHint hint)
		{
			// Store the buffer object type
			_Type = type;
			// Store the buffer data usage hints
			_Hint = hint;
		}
		
		#endregion

		#region Buffer Definition

		/// <summary>
		/// Get this BufferObject type.
		/// </summary>
		public BufferTargetARB BufferType { get { return (_Type); } }

		/// <summary>
		/// BufferObject type, indicatinvg the usage pattern.
		/// </summary>
		private readonly BufferTargetARB _Type;

		/// <summary>
		/// Get this BufferObject hint.
		/// </summary>
		public BufferObjectHint BufferHint { get { return (_Hint); } }

		/// <summary>
		/// BufferObject usage hint.
		/// </summary>
		private readonly BufferObjectHint _Hint;

		/// <summary>
		/// Get this BufferObject total size, in bytes.
		/// </summary>
		public uint BufferSize
		{
			get { return (_BufferSize); }
			protected set { _BufferSize = value; }
		}

		/// <summary>
		/// Size of the buffer object, in basic machine units (bytes).
		/// </summary>
		private uint _BufferSize;

		#endregion

		#region Client Memory

		/// <summary>
		/// Allocate client memory for this BufferObject.
		/// </summary>
		/// <param name="size">
		/// A <see cref="UInt32"/> that determine the size of the buffer object client memory, in bytes.
		/// </param>
		/// <remarks>
		/// <para>
		/// A call to this routine is required to create this BufferObject, since it determines the room necessary
		/// to this BufferObject.
		/// </para>
		/// </remarks>
		protected void Allocate(uint size)
		{
			// Discard previous buffer
			if (MemoryBuffer != null)
				MemoryBuffer.Dispose();
			// Allocate memory, if required
			MemoryBuffer = new AlignedMemoryBuffer(size, DefaultBufferAlignment);
			// Store buffer object size
			_BufferSize = size;
		}

		/// <summary>
		/// Ensure that buffer has at least the specified size.
		/// </summary>
		/// <param name="size">
		/// A <see cref="UInt32"/> that determine the size of the buffer object, in bytes.
		/// </param>
		protected void Reallocate(uint size)
		{
			if (MemoryBuffer != null) {
				MemoryBuffer.Realloc(size);
				_BufferSize = size;
			} else {
				Allocate(size);
			}
		}

		/// <summary>
		/// The buffer object representation in client memory.
		/// </summary>
		internal AlignedMemoryBuffer MemoryBuffer;

		/// <summary>
		/// The default memory alignment required.
		/// </summary>
		protected const uint DefaultBufferAlignment = 16;

		#endregion

		#region Buffer Binding

		/// <summary>
		/// Bind this BufferObject.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for binding this BufferObject.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if <see cref="GraphicsResource.ObjectName"/> represents an invalid object name.
		/// </exception>
		internal virtual void Bind(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current", "ctx");
			if (ObjectName == InvalidObjectName)
				throw new InvalidOperationException("invalid name");
			
			if (ctx.Caps.GlExtensions.VertexArrayObject_ARB) {
				// Bind this buffer object
				Gl.BindBuffer(_Type, ObjectName);
			}
		}

		/// <summary>
		/// Unbind this BufferObject.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for unbinding any BufferObject.
		/// </param>
		internal virtual void Unbind(GraphicsContext ctx)
		{
			if (ctx.Caps.GlExtensions.VertexArrayObject_ARB) {
				// Unbind actually binded buffer object
				Gl.BindBuffer(_Type, InvalidObjectName);
			}
		}

		#endregion

		#region Buffer Mapping

		/// <summary>
		/// Map this BufferObject.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> required for mapping this BufferObject.
		/// </param>
		/// <param name="mask">
		/// A <see cref="BufferAccessARB"/> that specify the map access.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject is already mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject does not exist, and no client memory buffer is allocated.
		/// </exception>
		/// <remarks>
		/// <para>
		/// This method does not care whether the BufferObject is actually created (i.e. an actual GPU
		/// buffer is allocated): in the case the GL_ARB_vertex_array_object is not supported, nor
		/// the buffer is not yet created, the mapped buffer corresponds with the client buffer object memory.
		/// </para>
		/// <para>
		/// After being mapped, the mapped buffer is accessible via <see cref="MapGet{T}(GraphicsContext, long)"/> or
		/// <see cref="MapSet{T}(GraphicsContext, T, long)"/>, or via <see cref="MappedBuffer"/> as raw pointer.
		/// </para>
		/// </remarks>
		public void Map(GraphicsContext ctx, BufferAccessARB mask)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			if (IsMapped())
				throw new InvalidOperationException("already mapped");

			if (Exists(ctx) && ctx.Caps.GlExtensions.VertexArrayObject_ARB) {
				// Map buffer object data (resident on server)
				_MappedBuffer = Gl.MapBuffer(_Type, mask);
			} else {
				if (MemoryBuffer == null)
					throw new InvalidOperationException("not buffer defined");
				// Emulate mapping
				_MappedBuffer = MemoryBuffer.AlignedBuffer;
			}
		}

		/// <summary>
		/// Set an element to this mapped BufferObject.
		/// </summary>
		/// <typeparam name="T">
		/// A structure representing this BufferObject element.
		/// </typeparam>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/>
		/// </param>
		/// <param name="value">
		/// A <typeparamref name="T"/> that specify the mapped BufferObject element.
		/// </param>
		/// <param name="offset">
		/// A <see cref="Int64"/> that specify the offset applied to the mapped BufferObject where <paramref name="value"/>
		/// is stored. This value is expressed in basic machine units (bytes).
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject is not mapped (<see cref="IsMapped"/>).
		/// </exception>
		public void MapSet<T>(GraphicsContext ctx, T value, Int64 offset) where T : struct
		{
			if (IsMapped() == false)
				throw new InvalidOperationException("BufferObject not mapped");

			Marshal.StructureToPtr(value, new IntPtr(_MappedBuffer.ToInt64()+offset), false);
		}

		/// <summary>
		/// Get an element from this mapped BufferObject.
		/// </summary>
		/// <typeparam name="T">
		/// A structure representing this BufferObject element.
		/// </typeparam>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/>
		/// </param>
		/// <param name="offset">
		/// A <see cref="Int64"/> that specify the offset applied to the mapped BufferObject to get the stored
		/// value. This value is expressed in basic machine units (bytes).
		/// </param>
		/// <returns>
		/// It returns a structure of type <typeparamref name="T"/>, read from the mapped BufferObject
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject is not mapped (<see cref="IsMapped"/>).
		/// </exception>
		public T MapGet<T>(GraphicsContext ctx, Int64 offset) where T : struct
		{
			if (IsMapped() == false)
				throw new InvalidOperationException("not mapped");

			return ((T)Marshal.PtrToStructure(new IntPtr(_MappedBuffer.ToInt64()+offset), typeof(T)));
		}

		/// <summary>
		/// Unmap this BufferObject data.
		/// </summary>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject is not mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject has been corrupted after being unmapped.
		/// </exception>
		public void Unmap(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (IsMapped() == false)
				throw new InvalidOperationException("not mapped");

			if (Exists(ctx) && ctx.Caps.GlExtensions.VertexArrayObject_ARB) {
				// Unmap buffer object data (resident on server)
				bool uncorrupted = Gl.UnmapBuffer(_Type);

				if (uncorrupted == false)
					throw new InvalidOperationException("corrupted buffer");
			}
			// Removes reference for mapped buffer data
			_MappedBuffer = IntPtr.Zero;
		}

		/// <summary>
		/// Check whether this BufferObject data is mapped.
		/// </summary>
		/// <returns>
		/// It returns a boolean value indicating whether this BufferObject is mapped.
		/// </returns>
		public bool IsMapped()
		{
			return (_MappedBuffer != IntPtr.Zero);
		}

		/// <summary>
		/// Get the mapped buffer address.
		/// </summary>
		protected IntPtr MappedBuffer { get { return (_MappedBuffer); } }

		/// <summary>
		/// Mapped buffer.
		/// </summary>
		private IntPtr _MappedBuffer = IntPtr.Zero;

		#endregion

		#region Get Data

		/// <summary>
		/// Retrieve the buffer object context
		/// </summary>
		/// <param name="ctx"></param>
		public void GetBufferData(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current", "ctx");

			if (ctx.Caps.GlExtensions.VertexArrayObject_ARB) {
				Reallocate(_BufferSize);

				Bind(ctx);

				Gl.GetBufferSubData(_Type, IntPtr.Zero, _BufferSize, MemoryBuffer.AlignedBuffer);
			}
		}
		
		#endregion

		#region GraphicsResource Overrides

		/// <summary>
		/// Buffer object class.
		/// </summary>
		internal static readonly Guid ThisObjectClass = new Guid("BFE3C5F0-4E22-49F1-9AD6-4DB4B2711B67");

		/// <summary>
		/// Buffer object class.
		/// </summary>
		public override Guid ObjectClass { get { return (ThisObjectClass); } }

		/// <summary>
		/// Determine whether this BufferObject really exists for a specific context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that would have created (or a sharing one) the object. This context shall be current to
		/// the calling thread.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this BufferObject exists in the object space of <paramref name="ctx"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The object existence is done by checking a valid object by its name <see cref="IGraphicsResource.ObjectName"/>. This routine will test whether
		/// <paramref name="ctx"/> has created this BufferObject (or is sharing with the creator).
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		public override bool Exists(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current");

			// Object name space test (and 'ctx' sanity checks)
			if (base.Exists(ctx) == false)
				return (false);

			return (!ctx.Caps.GlExtensions.VertexArrayObject_ARB || Gl.IsBuffer(ObjectName));
		}

		/// <summary>
		/// Create a BufferObject name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this buffer object name.
		/// </param>
		/// <returns>
		/// It returns a valid object name for this BufferObject.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		protected override uint CreateName(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current");

			Debug.Assert(ctx.Caps.GlExtensions.VertexArrayObject_ARB);

			return (Gl.GenBuffer());
		}

		/// <summary>
		/// Delete a BufferObject name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for deleting this buffer object name.
		/// </param>
		/// <param name="name">
		/// A <see cref="UInt32"/> that specify the object name to delete.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject does not exist.
		/// </exception>
		protected override void DeleteName(GraphicsContext ctx, uint name)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current");
			if (Exists(ctx) == false)
				throw new InvalidOperationException("not existing");

			Debug.Assert(ctx.Caps.GlExtensions.VertexArrayObject_ARB);

			// Delete buffer object
			Gl.DeleteBuffers(name);
		}

		/// <summary>
		/// Actually create this BufferObject resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject has not client memory allocated and the hint is different from
		/// <see cref="BufferObjectHint.StaticCpuDraw"/> or <see cref="BufferObjectHint.DynamicCpuDraw"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject is currently mapped.
		/// </exception>
		protected override void CreateObject(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current");
			if (_BufferSize == 0)
				throw new InvalidOperationException("size not defined");
			if ((MemoryBuffer == null) && ((_Hint != BufferObjectHint.StaticCpuDraw) && (_Hint != BufferObjectHint.DynamicCpuDraw)))
				throw new InvalidOperationException("contents not defined");

			// Buffer must be bound
			Bind(ctx);

			if (ctx.Caps.GlExtensions.VertexArrayObject_ARB) {
				if (IsMapped())
					throw new InvalidOperationException("mapped");

				// Define buffer object (type, size and hints)
				Gl.BufferData((int)_Type, _BufferSize, null, (int)_Hint);

				// Define buffer object contents
				if (MemoryBuffer != null) {
					// Provide buffer contents
					Gl.BufferSubData(_Type, IntPtr.Zero, _BufferSize, MemoryBuffer.AlignedBuffer);
					// Release memory, if it is not required anymore
					if (_Hint == BufferObjectHint.StaticCpuDraw) {
						MemoryBuffer.Dispose();
						MemoryBuffer = null;
					}
				}
			}
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown in the case <see cref="GraphicsResource.RefCount"/> is greater than zero. This means that the method is trying to dispose
		/// an object that is actually referenced by something else.
		/// </exception>
		protected override void Dispose(bool disposing)
		{
			// Base implementation
			base.Dispose(disposing);
			// Release memory buffer
			if ((disposing == true) && (MemoryBuffer != null)) {
				MemoryBuffer.Dispose();
				MemoryBuffer = null;
			}
		}

		#endregion
	}
}
