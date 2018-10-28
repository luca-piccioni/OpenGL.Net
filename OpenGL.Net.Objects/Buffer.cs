
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

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OpenGL.Objects
{
	/// <summary>
	/// Buffer object abstraction.
	/// </summary>
	/// <remarks>
	/// Implements:
	/// - Double buffering: CPU (client) and GPU (server) buffers are kepts as separate buffers.
	/// - Mapping
	/// - Immutable storage support (GL_ARB_buffer_storage)
	/// </remarks>
	public abstract class Buffer : GraphicsResource, IBindingResource
	{
		#region Constructors

		/// <summary>
		/// Construct a mutable Buffer determining its type, data usage and transfer mode.
		/// </summary>
		/// <param name="type">
		/// A <see cref="BufferTarget"/> that specify the buffer object type.
		/// </param>
		/// <param name="hint">
		/// An <see cref="BufferUsage"/> that specify the data buffer usage hints.
		/// </param>
		protected Buffer(BufferTarget type, BufferUsage hint)
		{
			// Store the buffer object type
			Target = type;
			// Store the buffer data usage hints
			Hint = hint;
			// Guess appropriate storage flags
			_UsageMask = HintToUsageMask(hint);
		}

		/// <summary>
		/// Construct a immutable Buffer determining its type, data usage and storage mode.
		/// </summary>
		/// <param name="type">
		/// A <see cref="BufferTarget"/> that specify the buffer object type.
		/// </param>
		/// <param name="usageMask">
		/// An <see cref="MapBufferUsageMask"/> that specify the buffer storage usage mask.
		/// </param>
		protected Buffer(BufferTarget type, MapBufferUsageMask usageMask)
		{
			// Store the buffer object type
			Target = type;
			// Store the buffer data usage hints
			Hint = UsageMaskToHint(usageMask);
			// Guess appropriate storage flags
			_UsageMask = usageMask;

			// Let be immutable
			Immutable = true;
		}
		
		#endregion

		#region Target

		/// <summary>
		/// Buffer target, indicating the buffer class.
		/// </summary>
		public readonly BufferTarget Target;

		/// <summary>
		/// The usage hint of this Buffer.
		/// </summary>
		public readonly BufferUsage Hint;

		#endregion

		#region Buffer Alignment

		/// <summary>
		/// The default memory alignment required for buffers.
		/// </summary>
		protected const uint DefaultBufferAlignment = 16;

		#endregion

		#region CPU Buffer

		/// <summary>
		/// Get the address of the CPU buffer of this Buffer.
		/// </summary>
		protected IntPtr CpuBufferAddress
		{
			get
			{
				if (_CpuBuffer != null && !_CpuBuffer.IsDisposed)
					return _CpuBuffer.AlignedBuffer;

				return _CpuBufferAddress;
			}
			set { _CpuBufferAddress = value; }
		}

		/// <summary>
		/// Get the address of the CPU buffer of this Buffer.
		/// </summary>
		private IntPtr _CpuBufferAddress = IntPtr.Zero;

		/// <summary>
		/// The buffer object representation in CPU memory.
		/// </summary>
		private AlignedMemoryBuffer _CpuBuffer;

		/// <summary>
		/// Get the size of the CPU storage allocated  for this buffer object. In the case this Buffer
		/// has not been defined yet, it returns 0.
		/// </summary>
		public uint CpuBufferSize
		{
			get { return _CpuBuffer?.Size ?? 0; }
			protected set { _CpuBufferSize = value; }
		}

		/// <summary>
		/// Size of the storage to be allocated for this buffer object, in bytes. Normally is aligned with
		/// <see cref="_CpuBuffer"/>, size, altought it is not meant to be.
		/// </summary>
		private uint _CpuBufferSize;

		/// <summary>
		/// Allocate a new CPU buffer for this Buffer.
		/// </summary>
		/// <param name="size">
		/// A <see cref="UInt32"/> that determine the size of the buffer object CPU buffer, in bytes.
		/// </param>
		protected void CreateCpuBuffer(uint size)
		{
			// Discard previous buffer
			DeleteCpuBuffer();
			// Allocate memory, if required
			_CpuBuffer = new AlignedMemoryBuffer(size, DefaultBufferAlignment);
			_CpuBuffer.ResetBuffer();
		}

		/// <summary>
		/// Release the CPU buffer of this Buffer.
		/// </summary>
		protected void DeleteCpuBuffer()
		{
			if (_CpuBuffer != null) {
				_CpuBuffer.Dispose();
				_CpuBuffer = null;
			}
		}

		#endregion

		#region GPU Buffer

		/// <summary>
		/// Get the address of the simulated GPU buffer of this Buffer, if defined. Otherwise it returns
		/// <see cref="IntPtr.Zero"/>.
		/// </summary>
		protected internal IntPtr GpuBufferAddress
		{
			get { return GpuBuffer?.AlignedBuffer ?? IntPtr.Zero; }
		}

		/// <summary>
		/// A <see cref="AlignedMemoryBuffer"/> instance for simulating the GPU buffer in the case GL_ARB_vertex_array_object
		/// is not supported.
		/// </summary>
		protected AlignedMemoryBuffer GpuBuffer;

		/// <summary>
		/// Size of the storage allocated for this buffer object, in bytes.
		/// </summary>
		protected internal uint GpuBufferSize { get { return _GpuBufferSize; } }

		/// <summary>
		/// Size of the storage allocated for this buffer object, in bytes.
		/// </summary>
		private uint _GpuBufferSize;

		/// <summary>
		/// Reset the allocated GPU buffer for this Buffer.
		/// </summary>
		/// <param name="ctx">
		/// 
		/// </param>
		/// <param name="size">
		/// A <see cref="UInt32"/> that determine the size of the buffer object GPU buffer, in bytes.
		/// </param>
		/// <param name="data">
		/// 
		/// </param>
		protected void CreateGpuBuffer(GraphicsContext ctx, uint size, IntPtr data)
		{
			if (Immutable && _GpuBufferSize > 0)
				throw new InvalidOperationException("buffer is immutable");

			if (Immutable && ctx.Extensions.BufferStorage_ARB) {
				Gl.BufferStorage(Target, size, data, _UsageMask);
				Gl.CheckErrors();
			} else {
				Gl.BufferData(Target, size, data, Hint);
				if (CpuBufferAddress != IntPtr.Zero)
					Gl.BufferSubData(Target, IntPtr.Zero, _GpuBufferSize, CpuBufferAddress);
			}

			// Store GPU buffer size
			_GpuBufferSize = size;
		}

		#endregion

		#region Mapping

		/// <summary>
		/// Map the CPU buffer allocated by this Buffer.
		/// </summary>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this Buffer is already mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this Buffer has no CPU buffer allocated.
		/// </exception>
		public void Map()
		{
			if (IsMapped)
				throw new InvalidOperationException("already mapped");

			// Emulate mapping
			_MappedBuffer = CpuBufferAddress;
			// Check actual mapped buffer
			if (_MappedBuffer == IntPtr.Zero)
				throw new InvalidOperationException("no CPU buffer");
		}

		/// <summary>
		/// Map the GPU buffer allocated by this Buffer.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> required for mapping this Buffer.
		/// </param>
		/// <param name="mask">
		/// A <see cref="BufferAccess"/> that specify the map access.
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this Buffer is already mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this Buffer does not exist for <paramref name="ctx"/>.
		/// </exception>
		public void Map(GraphicsContext ctx, BufferAccess mask)
		{
			CheckThisExistence(ctx);

			Debug.Assert(ctx.Extensions.VertexBufferObject_ARB || ctx.Version.IsCompatible(Gl.Version_200_ES) || GpuBuffer != null);
			if (ctx.Extensions.VertexBufferObject_ARB || ctx.Version.IsCompatible(Gl.Version_200_ES)) {
				BindCore(ctx);

				_MappedBuffer = Gl.MapBuffer(Target, mask);
			} else
				_MappedBuffer = GpuBuffer.AlignedBuffer;
		}

		/// <summary>
		/// Unmap this Buffer data.
		/// </summary>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this Buffer is not mapped, or if it was mapped using <see cref="Map(GraphicsContext, BufferAccess)"/>
		/// method.
		/// </exception>
		public void Unmap()
		{
			if (IsMapped == false)
				throw new InvalidOperationException("not mapped");
			if (MappedBuffer != CpuBufferAddress)
				throw new InvalidOperationException("cannot Unmap when mapped with Map(GraphicsContext, BufferAccess)");

			// Removes reference for mapped buffer data
			_MappedBuffer = IntPtr.Zero;
		}

		/// <summary>
		/// Unmap this Buffer data.
		/// </summary>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this Buffer is not mapped.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this Buffer has been corrupted after being unmapped.
		/// </exception>
		public void Unmap(GraphicsContext ctx)
		{
			if (IsMapped == false)
				throw new InvalidOperationException("not mapped");

			if (ctx.Extensions.VertexBufferObject_ARB || ctx.Version.IsCompatible(Gl.Version_200_ES)) {
				// Unmap buffer object data (resident on server)
				bool uncorrupted = Gl.UnmapBuffer(Target);

				if (uncorrupted == false)
					throw new InvalidOperationException("corrupted buffer");
			}
			// Removes reference for mapped buffer data
			_MappedBuffer = IntPtr.Zero;
		}

		/// <summary>
		/// Check whether this Buffer data is mapped.
		/// </summary>
		public bool IsMapped { get { return _MappedBuffer != IntPtr.Zero; } }

		/// <summary>
		/// Get the mapped buffer address.
		/// </summary>
		public IntPtr MappedBuffer { get { return _MappedBuffer; } }

		/// <summary>
		/// Mapped buffer.
		/// </summary>
		private IntPtr _MappedBuffer = IntPtr.Zero;

		/// <summary>
		/// Set an element to this mapped Buffer.
		/// </summary>
		/// <typeparam name="T">
		/// A structure representing this Buffer element.
		/// </typeparam>
		/// <param name="value">
		/// A <typeparamref name="T"/> that specify the mapped Buffer element.
		/// </param>
		/// <param name="offset">
		/// A <see cref="UInt64"/> that specify the offset applied to the mapped Buffer where <paramref name="value"/>
		/// is stored. This value is expressed in basic machine units (bytes).
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this Buffer is not mapped (<see cref="IsMapped"/>).
		/// </exception>
		public void Set<T>(T value, ulong offset) where T : struct
		{
			if (IsMapped == false)
				throw new InvalidOperationException("not mapped");

#if HAVE_UNSAFE
			unsafe
			{
				Unsafe.Write((byte*)MappedBuffer.ToPointer() + offset, value);
			}
#else
			throw new NotImplementedException();
#endif
		}

		/// <summary>
		/// Set an array of elements to this mapped Buffer.
		/// </summary>
		/// <typeparam name="T">
		/// A structure representing this Buffer element.
		/// </typeparam>
		/// <param name="array">
		/// A <typeparamref name="T:T[]"/> that specify the mapped Buffer element.
		/// </param>
		/// <param name="offset">
		/// A <see cref="ulong"/> that specify the offset applied to the mapped Buffer where <paramref name="array"/>
		/// is stored. This value is expressed in basic machine units (bytes).
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this Buffer is not mapped (<see cref="IsMapped"/>).
		/// </exception>
		public void Set<T>(T[] array, ulong offset) where T : struct
		{
			if (IsMapped == false)
				throw new InvalidOperationException("not mapped");

#if HAVE_UNSAFE
			unsafe
			{
				byte* ptr = (byte*)MappedBuffer.ToPointer() + offset;
				int stride = Marshal.SizeOf(typeof(T));

				for (int i = 0; i < array.Length; i++, ptr += stride)
					Unsafe.Write(ptr, array[i]);
			}
#else
			throw new NotImplementedException();
#endif
		}

		/// <summary>
		/// Get an element from this mapped Buffer.
		/// </summary>
		/// <typeparam name="T">
		/// A structure representing this Buffer element.
		/// </typeparam>
		/// <param name="offset">
		/// A <see cref="UInt64"/> that specify the offset applied to the mapped Buffer to get the stored
		/// value. This value is expressed in basic machine units (bytes).
		/// </param>
		/// <returns>
		/// It returns a structure of type <typeparamref name="T"/>, read from the mapped Buffer
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this Buffer is not mapped (<see cref="IsMapped"/>).
		/// </exception>
		public T Get<T>(ulong offset) where T : struct
		{
			if (IsMapped == false)
				throw new InvalidOperationException("not mapped");

#if HAVE_UNSAFE
			unsafe
			{
				return Unsafe.Read<T>((byte*)MappedBuffer.ToPointer() + offset);
			}
#else
			throw new NotImplementedException();
#endif
		}

		#endregion

		#region Immutable Storage

		/// <summary>
		/// Get whether this Buffer is immutable (GL_ARB_buffer_storage).
		/// </summary>
		public readonly bool Immutable;

		/// <summary>
		/// Get the <see cref="MapBufferUsageMask"/> corresponding to a <see cref="BufferUsage"/>.
		/// </summary>
		/// <param name="hint"></param>
		/// <returns></returns>
		private static MapBufferUsageMask HintToUsageMask(BufferUsage hint)
		{
			switch (hint) {
				case BufferUsage.StaticDraw:
				case BufferUsage.StaticCopy:
				case BufferUsage.DynamicCopy:
					return MapBufferUsageMask.None;
				case BufferUsage.DynamicDraw:
					return MapBufferUsageMask.MapWriteBit;
				case BufferUsage.StaticRead:
				case BufferUsage.DynamicRead:
					return MapBufferUsageMask.MapReadBit;
				default:
					return MapBufferUsageMask.None;
			}
		}

		/// <summary>
		/// Get the <see cref="BufferUsage"/> corresponding to a <see cref="MapBufferUsageMask"/>.
		/// </summary>
		/// <param name="usageMask"></param>
		/// <returns></returns>
		private static BufferUsage UsageMaskToHint(MapBufferUsageMask usageMask)
		{
			// By default, uses StaticDraw
			BufferUsage hint = BufferUsage.StaticDraw;

			// Common usage: map for writing before rendering
			if ((usageMask & MapBufferUsageMask.MapWriteBit) != 0)
				hint = BufferUsage.DynamicDraw;
			// Common usage: transform feedback
			if ((usageMask & MapBufferUsageMask.MapReadBit) != 0)
				hint = BufferUsage.DynamicRead;

			return hint;
		}

		/// <summary>
		/// Map storage flags, valid when GL_ARB_buffer_storage is implemented.
		/// </summary>
		private readonly MapBufferUsageMask _UsageMask;

		#endregion

		#region GraphicsResource Overrides

		/// <summary>
		/// Buffer object class.
		/// </summary>
		internal static readonly Guid ThisObjectClass = new Guid("BFE3C5F0-4E22-49F1-9AD6-4DB4B2711B67");

		/// <summary>
		/// Buffer object class.
		/// </summary>
		public override Guid ObjectClass { get { return ThisObjectClass; } }

		/// <summary>
		/// Determine whether this Buffer really exists for a specific context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that would have created (or a sharing one) the object. This context shall be current to
		/// the calling thread.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this Buffer exists in the object space of <paramref name="ctx"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The object existence is done by checking a valid object by its name <see cref="IGraphicsResource.ObjectName"/>. This routine will test whether
		/// <paramref name="ctx"/> has created this Buffer (or is sharing with the creator).
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
				return false;

			return ctx.Extensions.VertexBufferObject_ARB || ctx.Version.IsCompatible(Gl.Version_200_ES) ? Gl.IsBuffer(ObjectName) : GpuBuffer != null;
		}

		/// <summary>
		/// Create a Buffer name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this buffer object name.
		/// </param>
		/// <returns>
		/// It returns a valid object name for this Buffer.
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

			Debug.Assert(ctx.Extensions.VertexBufferObject_ARB || ctx.Version.IsCompatible(Gl.Version_200_ES));

			return Gl.GenBuffer();
		}

		/// <summary>
		/// Delete a Buffer name.
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
		/// Exception thrown if this Buffer does not exist.
		/// </exception>
		protected override void DeleteName(GraphicsContext ctx, uint name)
		{
			CheckThisExistence(ctx);

			Debug.Assert(ctx.Extensions.VertexBufferObject_ARB || ctx.Version.IsCompatible(Gl.Version_200_ES));

			// Delete buffer object
			Gl.DeleteBuffers(name);
			// Reset GPU buffer size
			_GpuBufferSize = 0;
		}

		/// <summary>
		/// Actually create this Buffer resources.
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
		/// Exception thrown if this Buffer is currently mapped.
		/// </exception>
		protected override void CreateObject(GraphicsContext ctx)
		{
			CheckCurrentContext(ctx);

			if (CpuBufferAddress == IntPtr.Zero && Hint != BufferUsage.StaticDraw && Hint != BufferUsage.DynamicDraw)
				throw new InvalidOperationException("no CPU buffer");

			// Determine the CPU buffer size
			uint clientBufferSize = _CpuBufferSize;

			if (CpuBufferAddress != IntPtr.Zero)
				clientBufferSize = CpuBufferSize;

			Debug.Assert(clientBufferSize > 0);

			// Buffer must be bound
			ctx.Bind(this, true);

			if (ctx.Extensions.VertexBufferObject_ARB || ctx.Version.IsCompatible(Gl.Version_200_ES))
				CreateObject_VertexArrayObjectARB(ctx, clientBufferSize);
			else
				CreateObject_Compatible(ctx, clientBufferSize);

			// Reset requested CPU buffer size
			_CpuBufferSize = 0;
		}

		/// <summary>
		/// Create the GPU buffer in case GL_ARB_vertex_buffer_object is not supported.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		/// <param name="size">
		/// A <see cref="UInt32"/> that specifies the size of the GPU buffer, in bytes.
		/// </param>
		protected void CreateObject_Compatible(GraphicsContext ctx, uint size)
		{
			// Discard previous GPU buffer, if any
			GpuBuffer?.Dispose();

			if (CpuBufferAddress != IntPtr.Zero) {
				// Swap CPU/GPU buffers
				GpuBuffer = _CpuBuffer;
				_CpuBuffer = null;
			} else {
				// Allocate simulated GPU buffer
				GpuBuffer = new AlignedMemoryBuffer(size, DefaultBufferAlignment);
			}

			// Store GPU buffer size
			_GpuBufferSize = GpuBuffer.Size;
		}

		/// <summary>
		/// Create the GPU buffer in case GL_ARB_vertex_buffer_object is supported.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		/// <param name="size">
		/// A <see cref="UInt32"/> that specifies the size of the GPU buffer, in bytes.
		/// </param>
		protected void CreateObject_VertexArrayObjectARB(GraphicsContext ctx, uint size)
		{
			// Define buffer object (type, size and hints)
			CreateGpuBuffer(ctx, size, CpuBufferAddress);
			// Release memory, if it is not required anymore
			DeleteCpuBuffer();
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
			
			if (disposing) {
				// Simulated GPU buffer is disposed at disposition
				if (GpuBuffer != null) {
					GpuBuffer.Dispose();
					GpuBuffer = null;
					// Reset GPU buffer size
					_GpuBufferSize = 0;
				}

				// Release CPU buffer
				DeleteCpuBuffer();
			}
		}

		#endregion

		#region IBindingResource Implementation

		/// <summary>
		/// Get the identifier of the binding point.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for binding.
		/// </param>
		int IBindingResource.GetBindingTarget(GraphicsContext ctx)
		{
			// Cannot lazy binding on buffer objects if GL_ARB_vertex_array_object is not supported
			if (!ctx.Extensions.VertexArrayObject_ARB && !ctx.Version.IsCompatible(Gl.Version_200_ES))
				return 0;
				
			// All-in-one implementation for all targets
			switch (Target) {
				case BufferTarget.ArrayBuffer:
					return Gl.ARRAY_BUFFER_BINDING;
				case BufferTarget.ElementArrayBuffer:
					return Gl.ELEMENT_ARRAY_BUFFER_BINDING;
				case BufferTarget.TransformFeedbackBuffer:
					return Gl.TRANSFORM_FEEDBACK_BINDING;
				case BufferTarget.UniformBuffer:
					return Gl.UNIFORM_BUFFER;
				case BufferTarget.ShaderStorageBuffer:
					return Gl.SHADER_STORAGE_BUFFER_BINDING;

				default:
					throw new NotSupportedException($"buffer target {Target} not supported");
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
			if (ctx.Extensions.VertexBufferObject_ARB || ctx.Version.IsCompatible(Gl.Version_200_ES))
				Gl.BindBuffer(Target, ObjectName);
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
			if (ctx.Extensions.VertexBufferObject_ARB || ctx.Version.IsCompatible(Gl.Version_200_ES))
				Gl.BindBuffer(Target, InvalidObjectName);
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
			int bindingTarget = ((IBindingResource)this).GetBindingTarget(ctx);
			int currentBufferObject;

			Debug.Assert(bindingTarget != 0);
			Gl.Get(bindingTarget, out currentBufferObject);

			return currentBufferObject == (int)ObjectName;
		}

		#endregion
	}
}
