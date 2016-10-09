
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
	public abstract partial class BufferObject : GraphicsResource, IBindingResource
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
			get { return (_GpuBufferSize != 0 ? _GpuBufferSize : ClientBufferSize); }
		}

		/// <summary>
		/// Reset the allocated GPU buffer for this BufferObject.
		/// </summary>
		/// <param name="size">
		/// A <see cref="UInt32"/> that determine the size of the buffer object GPU buffer, in bytes.
		/// </param>
		protected void AllocateGpuBuffer(uint size, object data)
		{
			// Define buffer object (type, size and hints)
			Gl.BufferData((int)BufferType, size, data, (int)Hint);
			// Store GPU buffer size
			_GpuBufferSize = size;
		}

		/// <summary>
		/// Get the address of the simulated GPU buffer of this BufferObject, if defined. Otherwise it returns
		/// <see cref="IntPtr.Zero"/>.
		/// </summary>
		protected internal IntPtr GpuBufferAddress
		{
			get { return (_GpuBuffer != null ? _GpuBuffer.AlignedBuffer : IntPtr.Zero); }
		}

		/// <summary>
		/// An reference used for simulating the GPU buffer in the case the relative OpenGL extension is
		/// not supported by current implementation. If this is not the case, the field is set to null.
		/// </summary>
		protected AlignedMemoryBuffer _GpuBuffer;

		/// <summary>
		/// Size of the storage allocated for this buffer object, in bytes.
		/// </summary>
		protected uint GpuBufferSize { get { return (_GpuBufferSize); } }

		/// <summary>
		/// Size of the storage allocated for this buffer object, in bytes.
		/// </summary>
		private uint _GpuBufferSize;

		#endregion

		#region Client Buffer

		/// <summary>
		/// Allocate a new client buffer for this BufferObject.
		/// </summary>
		/// <param name="size">
		/// A <see cref="UInt32"/> that determine the size of the buffer object client buffer, in bytes.
		/// </param>
		protected virtual void AllocateClientBuffer(uint size)
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
		protected virtual void ReallocateClientBuffer(uint size)
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
		protected virtual void ReleaseClientBuffer()
		{
			if (_ClientBuffer != null) {
				_ClientBuffer.Dispose();
				_ClientBuffer = null;
			}
		}

		/// <summary>
		/// Get the address of the client buffer of this BufferObject.
		/// </summary>
		protected internal virtual IntPtr ClientBufferAddress
		{
			get
			{
				if (_ClientBuffer != null && !_ClientBuffer.IsDisposed)
					return (_ClientBuffer.AlignedBuffer);

				return (IntPtr.Zero);
			}
		}

		/// <summary>
		/// Get the size of the client storage allocated  for this buffer object. In the case this BufferObject
		/// has not been defined yet, it returns 0.
		/// </summary>
		public virtual uint ClientBufferSize
		{
			get { return (_ClientBuffer != null ? _ClientBuffer.Size : 0); }
			protected set { _ClientBufferSize = value; }
		}

		/// <summary>
		/// Size of the storage to be allocated for this buffer object, in bytes. Normally is aligned with
		/// <see cref="_ClientBuffer"/>, size, altought it is not meant to be.
		/// </summary>
		private uint _ClientBufferSize;

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
		/// Define the fake GPU buffer (when GL_ARB_vertex_array_object is not supported) using the current client buffer.
		/// </summary>
		protected virtual void UploadClientBuffer()
		{
			if (_MemoryBufferAutoDispose == false) {

				// Note: client buffer is expected to be allocated and modificable; even while the GPU is rendering
				// using the simulated GPU buffer. We need to copy: in this way it is implemented the double buffer
				// mechanism of the GL_ARB_vertex_buffer_object extension

				// Allocate a new GPU buffer
				_GpuBuffer = new AlignedMemoryBuffer(ClientBufferSize, MinimumBufferAlignment);
				// Copy from client buffer
				Memory.MemoryCopy(_GpuBuffer.AlignedBuffer, ClientBufferAddress, ClientBufferSize);

			} else {

				// Note: since client buffer need to be disposed (ending set to null), we do not copy
				// client buffer to GPU buffer; instead, switch references and do not dispose the client buffer

				// Allocate GPU buffer
				_GpuBuffer = _ClientBuffer;
				// Do not need disposition (not really sure, but apart ClientBufferAddress, no reference of _ClientBuffer
				// should be out of here
				_ClientBuffer = null;
			}
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
		/// The buffer object representation in client memory.
		/// </summary>
		private AlignedMemoryBuffer _ClientBuffer;

		/// <summary>
		/// The default memory alignment required.
		/// </summary>
		protected const uint MinimumBufferAlignment = 16;

		#endregion

		#region Buffer Mapping

		/// <summary>
		/// Map the client buffer allocated by this BufferObject.
		/// </summary>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject is already mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject has no client buffer allocated.
		/// </exception>
		/// <remarks>
		/// <para>
		/// After being mapped, the mapped buffer is accessible via <see cref="MapGet{T}(GraphicsContext, long)"/> or
		/// <see cref="MapSet{T}(GraphicsContext, T, long)"/>, or via <see cref="MappedBuffer"/> as raw pointer.
		/// </para>
		/// </remarks>
		public void Map()
		{
			if (IsMapped)
				throw new InvalidOperationException("already mapped");

			// Emulate mapping
			_MappedBuffer = ClientBufferAddress;
			// Check actual mapped buffer
			if (_MappedBuffer == IntPtr.Zero)
				throw new InvalidOperationException("no client buffer");
		}

		/// <summary>
		/// Map the GPU buffer allocated by this BufferObject.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> required for mapping this BufferObject.
		/// </param>
		/// <param name="mask">
		/// A <see cref="BufferAccessARB"/> that specify the map access.
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject is already mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject does not exist for <paramref name="ctx"/>.
		/// </exception>
		/// <remarks>
		/// <para>
		/// After being mapped, the mapped buffer is accessible via <see cref="MapGet{T}(GraphicsContext, long)"/> or
		/// <see cref="MapSet{T}(GraphicsContext, T, long)"/>, or via <see cref="MappedBuffer"/> as raw pointer.
		/// </para>
		/// </remarks>
		public void Map(GraphicsContext ctx, BufferAccessARB mask)
		{
			CheckThisExistence(ctx);

			Debug.Assert(Glx.CurrentExtensions.VertexBufferObject_ARB || _GpuBuffer != null);
			// Map GPU buffer (actual or fake)
			_MappedBuffer = Glx.CurrentExtensions.VertexBufferObject_ARB ? Gl.MapBuffer(BufferType, mask) : _GpuBuffer.AlignedBuffer;
		}

		/// <summary>
		/// Unmap this BufferObject data.
		/// </summary>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject is not mapped, or if it was mapped using <see cref="Map(GraphicsContext, BufferAccessARB)"/>
		/// method.
		/// </exception>
		public void Unmap()
		{
			if (IsMapped == false)
				throw new InvalidOperationException("not mapped");
			if (MappedBuffer != ClientBufferAddress)
				throw new InvalidOperationException("cannot Unmap when mapped with Map(GraphicsContext, BufferAccessARB)");

			// Removes reference for mapped buffer data
			_MappedBuffer = IntPtr.Zero;
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
			if (IsMapped == false)
				throw new InvalidOperationException("not mapped");

			if (Exists(ctx) && Glx.CurrentExtensions.VertexBufferObject_ARB) {
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
		public bool IsMapped { get { return (_MappedBuffer != IntPtr.Zero); } }

		/// <summary>
		/// Get the mapped buffer address.
		/// </summary>
		protected IntPtr MappedBuffer { get { return (_MappedBuffer); } }

		/// <summary>
		/// Mapped buffer.
		/// </summary>
		private IntPtr _MappedBuffer = IntPtr.Zero;

		#endregion

		#region Buffer Map Access

		/// <summary>
		/// Set an element to this mapped BufferObject.
		/// </summary>
		/// <typeparam name="T">
		/// A structure representing this BufferObject element.
		/// </typeparam>
		/// <param name="value">
		/// A <typeparamref name="T"/> that specify the mapped BufferObject element.
		/// </param>
		/// <param name="offset">
		/// A <see cref="UInt64"/> that specify the offset applied to the mapped BufferObject where <paramref name="value"/>
		/// is stored. This value is expressed in basic machine units (bytes).
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject is not mapped (<see cref="IsMapped"/>).
		/// </exception>
		public void Set<T>(T value, UInt64 offset) where T : struct
		{
			if (IsMapped == false)
				throw new InvalidOperationException("not mapped");

			Marshal.StructureToPtr(value, new IntPtr(_MappedBuffer.ToInt64() + (Int64)offset), false);
		}

		/// <summary>
		/// Set an element to this mapped BufferObject.
		/// </summary>
		/// <param name="value">
		/// A <see cref="Vertex2f"/> that specify the mapped BufferObject element.
		/// </param>
		/// <param name="offset">
		/// A <see cref="UInt64"/> that specify the offset applied to the mapped BufferObject where <paramref name="value"/>
		/// is stored. This value is expressed in basic machine units (bytes).
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject is not mapped (<see cref="IsMapped"/>).
		/// </exception>
		public void Set(Vertex2f value, UInt64 offset)
		{
			if (IsMapped == false)
				throw new InvalidOperationException("not mapped");

			unsafe
			{
				byte* bufferPtr = (byte*)MappedBuffer.ToPointer();
				Vertex2f* bufferItemPtr = (Vertex2f*)(bufferPtr + offset);

				bufferItemPtr[0] = value;
			}
		}

		/// <summary>
		/// Set an element to this mapped BufferObject.
		/// </summary>
		/// <param name="value">
		/// A <see cref="Vertex3f"/> that specify the mapped BufferObject element.
		/// </param>
		/// <param name="offset">
		/// A <see cref="UInt64"/> that specify the offset applied to the mapped BufferObject where <paramref name="value"/>
		/// is stored. This value is expressed in basic machine units (bytes).
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject is not mapped (<see cref="IsMapped"/>).
		/// </exception>
		public void Set(Vertex3f value, UInt64 offset)
		{
			if (IsMapped == false)
				throw new InvalidOperationException("not mapped");

			unsafe
			{
				byte* bufferPtr = (byte*)MappedBuffer.ToPointer();
				Vertex3f* bufferItemPtr = (Vertex3f*)(bufferPtr + offset);

				bufferItemPtr[0] = value;
			}
		}

		/// <summary>
		/// Get an element from this mapped BufferObject.
		/// </summary>
		/// <typeparam name="T">
		/// A structure representing this BufferObject element.
		/// </typeparam>
		/// <param name="offset">
		/// A <see cref="UInt64"/> that specify the offset applied to the mapped BufferObject to get the stored
		/// value. This value is expressed in basic machine units (bytes).
		/// </param>
		/// <returns>
		/// It returns a structure of type <typeparamref name="T"/>, read from the mapped BufferObject
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject is not mapped (<see cref="IsMapped"/>).
		/// </exception>
		public T Get<T>(UInt64 offset) where T : struct
		{
			if (IsMapped == false)
				throw new InvalidOperationException("not mapped");

			return ((T)Marshal.PtrToStructure(new IntPtr(_MappedBuffer.ToInt64() + (Int64)offset), typeof(T)));
		}

		/// <summary>
		/// Get an element from this mapped BufferObject.
		/// </summary>
		/// <param name="offset">
		/// A <see cref="Int64"/> that specify the offset applied to the mapped BufferObject to get the stored
		/// value, in bytes.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex3f"/>, read from the mapped BufferObject at the specified offset.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject is not mapped (<see cref="IsMapped"/>).
		/// </exception>
		public Vertex3f Get(UInt64 offset)
		{
			unsafe
			{
				byte* bufferPtr = (byte*)MappedBuffer.ToPointer();
				Vertex3f* bufferItemPtr = (Vertex3f*)(bufferPtr + offset);

				return (bufferItemPtr[0]);
			}
		}

		#endregion

		#region Get Data

		/// <summary>
		/// Retrieve the buffer object content , and store it in the client buffer.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for creating this BufferObject.
		/// </param>
		public virtual void GetBufferData(GraphicsContext ctx)
		{
			CheckThisExistence(ctx);

			// Discard client buffer, if required
			if (ClientBufferSize != BufferSize) {
				ReleaseClientBuffer();
				AllocateClientBuffer(BufferSize);
				Debug.Assert(ClientBufferAddress != IntPtr.Zero);
				Debug.Assert(ClientBufferSize == BufferSize);
			}

			if (Glx.CurrentExtensions.VertexBufferObject_ARB) {
				// Read this buffer object
				ctx.Bind(this);
				// Get the GPU buffer content
				Gl.GetBufferSubData(BufferType, IntPtr.Zero, _GpuBufferSize, ClientBufferAddress);
			} else {
				// Copy GPU buffer into client buffer
				Memory.MemoryCopy(ClientBufferAddress, _GpuBuffer.AlignedBuffer, BufferSize);
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
			// Object name space test (and 'ctx' sanity checks)
			if (base.Exists(ctx) == false)
				return (false);

			return (Glx.CurrentExtensions.VertexBufferObject_ARB ? Gl.IsBuffer(ObjectName) : _GpuBuffer != null);
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
			CheckCurrentContext(ctx);

			Debug.Assert(Glx.CurrentExtensions.VertexBufferObject_ARB);

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
			CheckThisExistence(ctx);

			Debug.Assert(Glx.CurrentExtensions.VertexBufferObject_ARB);

			// Delete buffer object
			Gl.DeleteBuffers(name);
			// Reset GPU buffer size
			_GpuBufferSize = 0;
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
			CheckCurrentContext(ctx);

			if ((ClientBufferAddress == IntPtr.Zero) && ((Hint != BufferObjectHint.StaticCpuDraw) && (Hint != BufferObjectHint.DynamicCpuDraw)))
				throw new InvalidOperationException("no client buffer");

			// Determine the client buffer size
			uint clientBufferSize = _ClientBufferSize;

			if (ClientBufferAddress != IntPtr.Zero)
				clientBufferSize = ClientBufferSize;

			Debug.Assert(clientBufferSize > 0);

			// Buffer must be bound
			ctx.Bind(this);

			if (Glx.CurrentExtensions.VertexBufferObject_ARB) {
				if (IsMapped)
					throw new InvalidOperationException("mapped");

				// Define buffer object (type, size and hints)
				AllocateGpuBuffer(clientBufferSize, null);

				// Define buffer object contents
				if (ClientBufferAddress != IntPtr.Zero) {
					// Provide buffer contents
					Gl.BufferSubData(BufferType, IntPtr.Zero, _GpuBufferSize, ClientBufferAddress);
					// Release memory, if it is not required anymore
					if (_MemoryBufferAutoDispose)
						ReleaseClientBuffer();
				}
			} else {
				// Discard previous GPU buffer, if any
				if (_GpuBuffer != null)
					_GpuBuffer.Dispose();

				if (ClientBufferAddress == IntPtr.Zero) {
					// Note: GPU buffer size specified by _ClientBufferSize
					Debug.Assert(_ClientBufferSize > 0);
					// Allocate simulated GPU buffer
					_GpuBuffer = new AlignedMemoryBuffer(_ClientBufferSize, MinimumBufferAlignment);
				} else {
					// Let a virtual implementation decide how pass information from the client buffer and the "GPU" buffer
					UploadClientBuffer();
				}

				// Store GPU buffer size
				_GpuBufferSize = _GpuBuffer.Size;
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
					_GpuBufferSize = 0;
				}

				// Release client buffer
				ReleaseClientBuffer();
			}
		}

		#endregion

		#region IBindingResource Implementation

		/// <summary>
		/// Get the identifier of the binding point.
		/// </summary>
		int IBindingResource.BindingTarget
		{
			get
			{
				// Cannot lazy binding on textures if GL_ARB_vertex_array_object is not supported
				if (Gl.CurrentExtensions.VertexArrayObject_ARB == false)
					return (0);
				
				// All-in-one implementation for all targets
				switch (BufferType) {
					case BufferTargetARB.ArrayBuffer:
						return (Gl.ARRAY_BUFFER_BINDING);
					case BufferTargetARB.ElementArrayBuffer:
						return (Gl.ELEMENT_ARRAY_BUFFER_BINDING);
					case BufferTargetARB.TransformFeedbackBuffer:
						return (Gl.TRANSFORM_FEEDBACK_BINDING);

					default:
						throw new NotSupportedException(String.Format("buffer target 0x{0:X2} not supported", (int)BufferType));
				}
			}
		}

		/// <summary>
		/// Bind this IBindingResource.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for binding.
		/// </param>
		void IBindingResource.Bind(GraphicsContext ctx)
		{
			BindCore(ctx);
		}

		/// <summary>
		/// Virtual Bind implementation.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for binding.
		/// </param>
		protected virtual void BindCore(GraphicsContext ctx)
		{
			if (Glx.CurrentExtensions.VertexBufferObject_ARB)
				Gl.BindBuffer(BufferType, ObjectName);
		}

		/// <summary>
		/// Bind this IBindingResource.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for binding.
		/// </param>
		void IBindingResource.Unbind(GraphicsContext ctx)
		{
			CheckThisExistence(ctx);

			UnbindCore(ctx);
		}

		/// <summary>
		/// Virtual Unbind implementation.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for binding.
		/// </param>
		protected virtual void UnbindCore(GraphicsContext ctx)
		{
			if (Glx.CurrentExtensions.VertexBufferObject_ARB)
				Gl.BindBuffer(BufferType, InvalidObjectName);
		}

		/// <summary>
		/// Check whether this IBindingResource is currently bound on the specified graphics context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for querying the current binding state.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this IBindingResource is currently bound on <paramref name="ctx"/>.
		/// </returns>
		bool IBindingResource.IsBound(GraphicsContext ctx)
		{
			int currentBufferObject;

			Debug.Assert(((IBindingResource)this).BindingTarget != 0);
			Gl.Get(((IBindingResource)this).BindingTarget, out currentBufferObject);

			return (currentBufferObject == (int)ObjectName);
		}

		#endregion
	}

	/// <summary>
	/// Data buffer object abstraction (generic variant).
	/// </summary>
	/// <remarks>
	/// This derivation allows to allocate the client buffer using a strongly typed array.
	/// </remarks>
	public abstract class BufferObject<T> : BufferObject where T : struct
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
		protected BufferObject(BufferTargetARB type, BufferObjectHint hint) :
			base(type, hint)
		{
			_ClientBufferElementSize = (uint)Marshal.SizeOf(typeof(T));
		}

		#endregion

		#region Buffer Object Overrides

		/// <summary>
		/// Allocate a new client buffer for this BufferObject.
		/// </summary>
		/// <param name="size">
		/// A <see cref="UInt32"/> that determine the size of the buffer object client buffer, in bytes.
		/// </param>
		protected override void AllocateClientBuffer(uint size)
		{
			// Discard previous buffer
			ReleaseClientBuffer();
			// Allocate memory, if required
			_TypedClientBuffer = new T[size];
			// Pin client buffer (ugly, but necessary till ClientBufferAddress has not Create/Delete pattern)
			_TypedClientBufferHandle = GCHandle.Alloc(_TypedClientBuffer, GCHandleType.Pinned);
		}

		/// <summary>
		/// Reallocate a new client buffer for this BufferObject.
		/// </summary>
		/// <param name="size">
		/// A <see cref="UInt32"/> that determine the size of the buffer object, in bytes.
		/// </param>
		protected override void ReallocateClientBuffer(uint size)
		{
			if (_TypedClientBuffer != null) {
				T[] reallocClientBuffer = new T[size];

				// Copy previous client buffer contents
				Array.Copy(_TypedClientBuffer, reallocClientBuffer, _TypedClientBuffer.Length);
				// Unpin and release previous client buffer
				ReleaseClientBuffer();

				// Substitute previous client buffer
				_TypedClientBuffer = reallocClientBuffer;
				// Pin client buffer (ugly, but necessary till ClientBufferAddress has not Create/Delete pattern)
				_TypedClientBufferHandle = GCHandle.Alloc(_TypedClientBuffer, GCHandleType.Pinned);
			} else {
				AllocateClientBuffer(size);
			}
		}

		/// <summary>
		/// Release the client buffer of this BufferObject.
		/// </summary>
		protected override void ReleaseClientBuffer()
		{
			// Unpin client buffer
			if (_TypedClientBufferHandle.HasValue) {
				_TypedClientBufferHandle.Value.Free();
				_TypedClientBufferHandle = null;
			}
			// Let the GC to collect the client buffer
			_TypedClientBuffer = null;
		}

		/// <summary>
		/// Get the address of the client buffer of this BufferObject.
		/// </summary>
		protected internal override IntPtr ClientBufferAddress
		{
			get
			{
				if (_TypedClientBufferHandle.HasValue)
					return (_TypedClientBufferHandle.Value.AddrOfPinnedObject());

				return (IntPtr.Zero);
			}
		}

		/// <summary>
		/// Get the size of the client storage allocated for this buffer object. In the case this BufferObject
		/// has not been defined yet, it returns 0.
		/// </summary>
		public override uint ClientBufferSize
		{
			get { return (_TypedClientBuffer != null ? (uint)(_TypedClientBuffer.Length * _ClientBufferElementSize) : 0); }
			protected set { base.ClientBufferSize = value; }
		}

		/// <summary>
		/// Define the fake GPU buffer (when GL_ARB_vertex_array_object is not supported) using the current client buffer.
		/// </summary>
		protected override void UploadClientBuffer()
		{
			// Allocate a new GPU buffer
			_GpuBuffer = new AlignedMemoryBuffer(ClientBufferSize, MinimumBufferAlignment);
			// Upload client buffer
			Memory.MemoryCopy(_GpuBuffer.AlignedBuffer, ClientBufferAddress, ClientBufferSize);
			// Automatically dispose client buffer
			if (AutoDisposeClientBuffer)
				ReleaseClientBuffer();
		}

		/// <summary>
		/// The size of the elements of <see cref="_TypedClientBuffer"/>, in bytes.
		/// </summary>
		private readonly uint _ClientBufferElementSize;

		/// <summary>
		/// The client buffer, allocated using a stringly typed array.
		/// </summary>
		private T[] _TypedClientBuffer;

		/// <summary>
		/// GC handle for <see cref="_TypedClientBuffer"/>.
		/// </summary>
		private GCHandle? _TypedClientBufferHandle;

		#endregion
	}
}
