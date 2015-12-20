
// Copyright (C) 2009-2013 Luca Piccioni
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//  
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//  
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
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
	/// This clas actually stores the data using a <see cref="AlignedMemoryBuffer"/>, indeed un unmanaged
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
		/// A <see cref="BufferTargetARB"/> that specifies the buffer object type.
		/// </param>
		/// <param name="hint">
		/// An <see cref="Hint"/> that specifies the data buffer usage hints.
		/// </param>
		protected BufferObject(BufferTargetARB type, Hint hint)
		{
			// Store the buffer object type
			mType = type;
			// Store the buffer data usage hints
			mHint = hint;
		}
		
		#endregion

		#region Buffer Data Definition

		/// <summary>
		/// Buffer usage hints.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumeration determine the BufferObject usage. It determines whether client memory shall be allocated
		/// and released.
		/// </para>
		/// <para>
		/// Additionally give an hint about the buffer basic operation (read, copy or draw) and ratio between source
		/// updates and draw updates.
		/// </para>
		/// </remarks>
		public enum Hint
		{
			/// <summary>
			/// Buffer used for drawing, specified once by application data.
			/// </summary>
			/// <remarks>
			/// <para>
			/// By using this hint, this BufferObject allocates client memory to set buffer object contents,
			/// and after done it release the client memory.
			/// </para>
			/// </remarks>
			StaticCpuDraw = Gl.STATIC_DRAW,
			/// <summary>
			/// Buffer used for drawing, specified once by OpenGL rendering.
			/// </summary>
			/// <remarks>
			/// <para>
			/// By using this hint, this BufferObject does not allocates client memory.
			/// </para>
			/// </remarks>
			StaticGpuDraw = Gl.STATIC_COPY,
			/// <summary>
			/// Buffer used for drawing, specified many times by application data.
			/// </summary>
			/// <remarks>
			/// <para>
			/// By using this hint, this BufferObject allocates client memory to set buffer object contents,
			/// and after done it does not release the client memory, in order to update frequently the
			/// buffer contents.
			/// </para>
			/// </remarks>
			DynamicCpuDraw = Gl.DYNAMIC_DRAW,
			/// <summary>
			/// Buffer used for drawing, specified many times by OpenGL rendering.
			/// </summary>
			/// <remarks>
			/// <para>
			/// By using this hint, this BufferObject does not allocates client memory.
			/// </para>
			/// </remarks>
			DynamicGpuDraw = Gl.DYNAMIC_COPY,
			/// <summary>
			/// Buffer used for reading, specified once by OpenGL rendering.
			/// </summary>
			/// <remarks>
			/// <para>
			/// By using this hint, this BufferObject allocates client memory to get buffer object contents.
			/// Client memory will be released at object disposition.
			/// </para>
			/// </remarks>
			StaticRead = Gl.STATIC_READ,
			/// <summary>
			/// Buffer used for reading, specified many times by OpenGL rendering.
			/// </summary>
			/// <remarks>
			/// <para>
			/// By using this hint, this BufferObject allocates client memory to get buffer object contents.
			/// Client memory will be released at object disposition.
			/// </para>
			/// </remarks>
			DynamicRead = Gl.DYNAMIC_READ
		}

		/// <summary>
		/// Get this BufferObject type.
		/// </summary>
		public BufferTargetARB BufferType { get { return (mType); } }

		/// <summary>
		/// Get this BufferObject hint.
		/// </summary>
		public Hint BufferHint { get { return (mHint); } }

		/// <summary>
		/// Get this BufferObject total size, in basic machine units.
		/// </summary>
		public uint BufferSize { get { return (mSize); } }

		/// <summary>
		/// Define this buffer object allocation.
		/// </summary>
		/// <param name="size">
		/// A <see cref="System.UInt32"/> that determine the size of the buffer object.
		/// </param>
		/// <remarks>
		/// <para>
		/// A call to this routine is required to create this BufferObject, since it determines the room necessary
		/// to this BufferObject.
		/// </para>
		/// <para>
		/// In the case the BufferObject hint is suggesting a GPU only object, no memory will be allocated by this
		/// routine. Otherwise, <see cref="MemoryBuffer"/> will allocate the requested room for client operations.
		/// </para>
		/// </remarks>
		protected void Allocate(uint size)
		{
			// Store buffer object size
			mSize = size;
			// Allocate memory, if required
			MemoryBuffer = new AlignedMemoryBuffer(mSize, 16);
		}

		/// <summary>
		/// BufferObject type, indicatinvg the usage pattern.
		/// </summary>
		private readonly BufferTargetARB mType;

		/// <summary>
		/// BufferObject hints.
		/// </summary>
		private readonly Hint mHint;

		/// <summary>
		/// Size of the buffer object, in basic machine units (bytes).
		/// </summary>
		private uint mSize;

		/// <summary>
		/// The buffer object representation in client memory.
		/// </summary>
		internal AlignedMemoryBuffer MemoryBuffer;
		
		#endregion

		#region Buffer Binding
		
		/// <summary>
		/// Bind this BufferObject.
		/// </summary>
		internal virtual void Bind(GraphicsContext ctx)
		{
			if (ObjectName == InvalidObjectName)
				throw new InvalidOperationException("invalid name");
			
			// Bind this buffer object
			Gl.BindBuffer(mType, ObjectName);
		}

		/// <summary>
		/// Unbind this BufferObject.
		/// </summary>
		internal virtual void Unbind(GraphicsContext ctx)
		{
			// Unbind actually binded buffer object
			Gl.BindBuffer(mType, 0);
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
		/// A <see cref="MapMask"/> that specifies the map access.
		/// </param>
		public void Map(GraphicsContext ctx, BufferAccessARB mask)
		{
			if (IsMapped())
				throw new InvalidOperationException("already mapped");

			if (Exists(ctx)) {
				// Map buffer object data (resident on server)
				mMappedBuffer = Gl.MapBuffer(mType, mask);
			} else {
				// Emulate mapping
				mMappedBuffer = MemoryBuffer.AlignedBuffer;
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
		/// A <typeparamref name="T"/> that specifies the mapped BufferObject element.
		/// </param>
		/// <param name="offset">
		/// A <see cref="Int64"/> that specifies the offset applied to the mapped BufferObject where <paramref name="value"/>
		/// is stored. This value is expressed in basic machine units (bytes).
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject is not mapped (<see cref="IsMapped"/>).
		/// </exception>
		public void MapSet<T>(GraphicsContext ctx, T value, Int64 offset) where T : struct
		{
			if (IsMapped() == false)
				throw new InvalidOperationException("BufferObject not mapped");

			Marshal.StructureToPtr(value, new IntPtr(mMappedBuffer.ToInt64()+offset), false);
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
		/// A <see cref="Int64"/> that specifies the offset applied to the mapped BufferObject to get the stored
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

			return ((T)Marshal.PtrToStructure(new IntPtr(mMappedBuffer.ToInt64()+offset), typeof(T)));
		}
		
		/// <summary>
		/// Unmap this RenderBufferObject data.
		/// </summary>
		public void Unmap(GraphicsContext ctx)
		{	
			if (IsMapped() == false)
				throw new InvalidOperationException("not mapped");

			if (Exists(ctx)) {
				// Unmap buffer object data (resident on server)
				bool uncorrupted = Gl.UnmapBuffer(mType);

				if (uncorrupted == false)
					throw new InvalidOperationException("corrupted when unmapping");
			}
			// Removes reference for mapped buffer data
			mMappedBuffer = IntPtr.Zero;
		}

		/// <summary>
		/// Check whether this RenderBufferObject data is mapped.
		/// </summary>
		/// <returns></returns>
		public bool IsMapped()
		{
			return (mMappedBuffer != IntPtr.Zero);
		}

		/// <summary>
		/// Mapped buffer.
		/// </summary>
		private IntPtr mMappedBuffer = IntPtr.Zero;

		#endregion
		
		#region Get Data
		
		public void GetBufferData(GraphicsContext ctx)
		{
			if (MemoryBuffer != null)
				MemoryBuffer.Dispose();
			
			MemoryBuffer = new AlignedMemoryBuffer(mSize, 16);
			
			Bind(ctx);
			
			Gl.GetBufferSubData(mType, IntPtr.Zero, mSize, MemoryBuffer.AlignedBuffer);
		}
		
		#endregion

		#region GraphicsResource Overrides

		/// <summary>
		/// Buffer object class.
		/// </summary>
		internal static readonly Guid BufferObjectClass = new Guid("BFE3C5F0-4E22-49F1-9AD6-4DB4B2711B67");

		/// <summary>
		/// Buffer object class.
		/// </summary>
		public override Guid ObjectClass { get { return (BufferObjectClass); } }

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
		/// The object existence is done by checking a valid object by its name <see cref="IRenderResource.ObjectName"/>. This routine will test whether
		/// <paramref name="ctx"/> has created this BufferObject (or is sharing with the creator).
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		public override bool Exists(GraphicsContext ctx)
		{
			// Object name space test (and 'ctx' sanity checks)
			if (base.Exists(ctx) == false)
				return (false);

			return (ctx.IsCurrent && Gl.IsBuffer(ObjectName));
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
		protected override uint CreateName(GraphicsContext ctx)
		{
			return (Gl.GenBuffer());
		}

		/// <summary>
		/// Delete a BufferObject name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for deleting this buffer object name.
		/// </param>
		/// <param name="name">
		/// A <see cref="System.UInt32"/> that specifies the object name to delete.
		/// </param>
		protected override void DeleteName(GraphicsContext ctx, uint name)
		{
			// Delete buffer object
			Gl.DeleteBuffers(name);
		}

		/// <summary>
		/// Actually create this BufferObject resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void CreateObject(GraphicsContext ctx)
		{
			if (mSize == 0)
				throw new InvalidOperationException("size not defined");
			if ((MemoryBuffer == null) && ((mHint != Hint.StaticCpuDraw) && (mHint != Hint.DynamicCpuDraw)))
				throw new InvalidOperationException("contents not defined");

			// Buffer must be bound
			Bind(ctx);

			// Define buffer object (type, size and hints)
			Gl.BufferData((int)mType, mSize, null, (int)mHint);

			// Define buffer object contents
			if (MemoryBuffer != null) {
				// Provide buffer contents
				Gl.BufferSubData(mType, IntPtr.Zero, mSize, MemoryBuffer.AlignedBuffer);
				// Release memory, if they are not required
				if (mHint == Hint.StaticCpuDraw) {
					MemoryBuffer.Dispose();
					MemoryBuffer = null;
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
