
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
	/// This class actually stores the data in a client buffer using a <see cref="AlignedMemoryBuffer"/>, indeed
	/// an unmanaged chunk of memory (aligned to 16 byte boundaries).
	/// </para>
	/// <para>
	/// Any BufferObject instance can be mapped into userspace memory, offering the possibility to modify
	/// partially the buffer object, minimizing the data transfer between CPU and GPU.
	/// </para>
	/// <para>
	/// Normally a BufferObject interface is resolved either the relative OpenGL extension is supported or not. Generally
	/// this is implemented by defining up to two client buffers to emulate the "simulated" GPU buffer allocation behavior.
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
			BufferType = type;
			// Store the buffer data usage hints
			Hint = hint;
			// Automatically dispose client buffer?
			_MemoryBufferAutoDispose = IsClientBufferAutoDisposable(hint);
		}
		
		#endregion

		#region Buffer Definition

		/// <summary>
		/// BufferObject type, indicatinvg the usage pattern.
		/// </summary>
		public readonly BufferTargetARB BufferType;

		/// <summary>
		/// The usage hint of this BufferObject.
		/// </summary>
		public readonly BufferObjectHint Hint;

		/// <summary>
		/// Get the size of the storage allocated for this buffer object, in bytes. In the case this BufferObject
		/// has not been created yet, it returns the size of the client buffer.
		/// </summary>
		public uint BufferSize
		{
			get { return (_BufferSize != 0 ? _BufferSize : ClientBufferSize); }
		}

		/// <summary>
		/// Get the size of the client storage allocated  for this buffer object. In the case this BufferObject
		/// has not been defined yet, it returns 0.
		/// </summary>
		public uint ClientBufferSize
		{
			get { return (_ClientBuffer != null ? _ClientBuffer.Size : 0); }
			protected set { _ClientBufferSize = value; }
		}

		/// <summary>
		/// Size of the storage allocated for this buffer object, in bytes.
		/// </summary>
		private uint _BufferSize;

		/// <summary>
		/// Size of the storage to be allocated for this buffer object, in bytes. Normally is aligned with
		/// <see cref="_ClientBuffer"/>, size, altought it is not meant to be.
		/// </summary>
		private uint _ClientBufferSize;

		#endregion

		#region Client Buffer

		/// <summary>
		/// Allocate a new client buffer for this BufferObject.
		/// </summary>
		/// <param name="size">
		/// A <see cref="UInt32"/> that determine the size of the buffer object client buffer, in bytes.
		/// </param>
		protected void AllocateClientBuffer(uint size)
		{
			// Discard previous buffer
			ReleaseClientBuffer();
			// Allocate memory, if required
			_ClientBuffer = new AlignedMemoryBuffer(size, MinimumBufferAlignment);
		}

		/// <summary>
		/// Reallocate a new client buffer for this BufferObject.
		/// </summary>
		/// <param name="size">
		/// A <see cref="UInt32"/> that determine the size of the buffer object, in bytes.
		/// </param>
		protected void ReallocateClientBuffer(uint size)
		{
			if (_ClientBuffer != null) {
				_ClientBuffer.Realloc(size);
			} else {
				AllocateClientBuffer(size);
			}
		}

		/// <summary>
		/// Release the client buffer of this BufferObject.
		/// </summary>
		protected void ReleaseClientBuffer()
		{
			if (_ClientBuffer != null) {
				_ClientBuffer.Dispose();
				_ClientBuffer = null;
			}
		}

		/// <summary>
		/// Get the address of the client buffer of this BufferObject.
		/// </summary>
		protected IntPtr ClientBufferAddress
		{
			get
			{
				if (_ClientBuffer != null && !_ClientBuffer.IsDisposed)
					return (_ClientBuffer.AlignedBuffer);

				return (IntPtr.Zero);
			}
		}

		/// <summary>
		/// Get or set whether the client buffer must be disposed once this BufferObject is created; this
		/// attribute is ignored when the required buffer cannot be managed at GPU side (i.e.
		/// <see cref="IGraphicsResource.RequiresName(GraphicsContext)"/>.
		/// </summary>
		protected virtual bool AutoDisposeClientBuffer
		{
			get { return (_MemoryBufferAutoDispose); }
			set { _MemoryBufferAutoDispose = value; }
		}

		/// <summary>
		/// Determine whether <see cref="_ClientBuffer"/> should be disposed have got it uploaded to GPU.
		/// </summary>
		private bool _MemoryBufferAutoDispose;

		/// <summary>
		/// Determine the default value of <see cref="AutoDisposeClientBuffer"/>.
		/// </summary>
		/// <param name="hint">
		/// A <see cref="BufferObjectHint"/> that hints the buffer usage.
		/// </param>
		/// <returns></returns>
		protected static bool IsClientBufferAutoDisposable(BufferObjectHint hint)
		{
			return (hint == BufferObjectHint.StaticCpuDraw);
		}

		/// <summary>
		/// An reference used for simulating the GPU buffer in the case the relative OpenGL extension is
		/// not supported by current implementation. If this is not the case, the field is set to null.
		/// </summary>
		protected AlignedMemoryBuffer _GpuBuffer;

		/// <summary>
		/// The buffer object representation in client memory.
		/// </summary>
		private AlignedMemoryBuffer _ClientBuffer;

		/// <summary>
		/// The default memory alignment required.
		/// </summary>
		protected const uint MinimumBufferAlignment = 16;

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
			
			if (ctx.Caps.GlExtensions.VertexBufferObject_ARB)
				Gl.BindBuffer(BufferType, ObjectName);
		}

		/// <summary>
		/// Unbind this BufferObject.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for unbinding any BufferObject.
		/// </param>
		internal virtual void Unbind(GraphicsContext ctx)
		{
			if (ctx.Caps.GlExtensions.VertexBufferObject_ARB)
				Gl.BindBuffer(BufferType, InvalidObjectName);
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
		/// buffer is allocated): in the case the GL_ARB_vertex_buffer_object is not supported, nor
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

			if (Exists(ctx)) {
				Debug.Assert(ctx.Caps.GlExtensions.VertexBufferObject_ARB || _GpuBuffer != null);
				// Map GPU buffer (actual or fake)
				_MappedBuffer = ctx.Caps.GlExtensions.VertexBufferObject_ARB ? Gl.MapBuffer(BufferType, mask) : _GpuBuffer.AlignedBuffer;
			} else {
				if (_ClientBuffer == null)
					throw new InvalidOperationException("no client buffer");

				// Emulate mapping
				_MappedBuffer = _ClientBuffer.AlignedBuffer;
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

			if (Exists(ctx) && ctx.Caps.GlExtensions.VertexBufferObject_ARB) {
				// Unmap buffer object data (resident on server)
				bool uncorrupted = Gl.UnmapBuffer(BufferType);

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
		public virtual void GetBufferData(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current", "ctx");
			if (Exists(ctx) == false)
				throw new InvalidOperationException("not existing");

			if (ctx.Caps.GlExtensions.VertexBufferObject_ARB) {
				// Ensure client buffer storage
				ReallocateClientBuffer(_BufferSize);
				// Read this buffer object
				Bind(ctx);
				// Get the GPU buffer content
				Gl.GetBufferSubData(BufferType, IntPtr.Zero, _BufferSize, _ClientBuffer.AlignedBuffer);
			} else {
				// Discard client buffer, if required
				if (ClientBufferSize != BufferSize) {
					ReleaseClientBuffer();
					AllocateClientBuffer(BufferSize);
				}
				// Copy GPU buffer into client buffer
				Memory.MemoryCopy(_ClientBuffer.AlignedBuffer, _GpuBuffer.AlignedBuffer, BufferSize);
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

			return (ctx.Caps.GlExtensions.VertexBufferObject_ARB ? Gl.IsBuffer(ObjectName) : _GpuBuffer != null);
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

			Debug.Assert(ctx.Caps.GlExtensions.VertexBufferObject_ARB);

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

			Debug.Assert(ctx.Caps.GlExtensions.VertexBufferObject_ARB);

			// Delete buffer object
			Gl.DeleteBuffers(name);
			// Reset GPU buffer size
			_BufferSize = 0;
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
				throw new ArgumentException("not current", "ctx");
			if ((_ClientBuffer == null) && ((Hint != BufferObjectHint.StaticCpuDraw) && (Hint != BufferObjectHint.DynamicCpuDraw)))
				throw new InvalidOperationException("contents not defined");

			uint clientBufferSize = _ClientBufferSize;

			if (_ClientBuffer != null)
				clientBufferSize = _ClientBuffer.Size;

			// Buffer must be bound
			Bind(ctx);

			if (ctx.Caps.GlExtensions.VertexBufferObject_ARB) {
				if (IsMapped())
					throw new InvalidOperationException("mapped");

				// Define buffer object (type, size and hints)
				Gl.BufferData((int)BufferType, clientBufferSize, null, (int)Hint);
				// Store GPU buffer size
				_BufferSize = clientBufferSize;

				// Define buffer object contents
				if (_ClientBuffer != null) {
					// Provide buffer contents
					Gl.BufferSubData(BufferType, IntPtr.Zero, _BufferSize, _ClientBuffer.AlignedBuffer);
					// Release memory, if it is not required anymore
					if (_MemoryBufferAutoDispose)
						ReleaseClientBuffer();
				}
			} else {
				// Discard previous GPU buffer, if any
				if (_GpuBuffer != null)
					_GpuBuffer.Dispose();

				if (_ClientBuffer != null) {
					if (_MemoryBufferAutoDispose == false) {

						// Note: client buffer is expected to be allocated and modificable; even while the GPU is rendering
						// using the simulated GPU buffer. We need to copy: in this way it is implemented the double buffer
						// mechanism of the GL_ARB_vertex_buffer_object extension

						// Allocate a new GPU buffer
						_GpuBuffer = new AlignedMemoryBuffer(_ClientBuffer.Size, _ClientBuffer.Alignment);
						// Copy from client buffer
						Memory.MemoryCopy(_GpuBuffer.AlignedBuffer, _ClientBuffer.AlignedBuffer, _ClientBuffer.Size);

					} else {

						// Note: since client buffer need to be disposed (ending set to null), we do not copy
						// client buffer to GPU buffer; instead, switch references and do not dispose the client buffer
						
						// Allocate GPU buffer
						_GpuBuffer = _ClientBuffer;
						// Do not need disposition (not really sure, but apart ClientBufferAddress, no reference of _ClientBuffer
						// should be out of here
						_ClientBuffer = null;
					}
				} else {
					
					// Note: GPU buffer size specified by _ClientBufferSize
					Debug.Assert(_ClientBufferSize > 0);

					// Allocate simulated GPU buffer
					_GpuBuffer = new AlignedMemoryBuffer(_ClientBufferSize, MinimumBufferAlignment);
				}

				// Store GPU buffer size
				_BufferSize = _GpuBuffer.Size;
			}

			// Reset requested client buffer size
			_ClientBufferSize = 0;
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
			
			if (disposing == true) {
				// Simulated GPU buffer is disposed at disposition
				if (_GpuBuffer != null) {
					_GpuBuffer.Dispose();
					_GpuBuffer = null;
					// Reset GPU buffer size
					_BufferSize = 0;
				}

				// Release client buffer
				ReleaseClientBuffer();
			}
		}

		#endregion
	}
}
