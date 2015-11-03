
// Copyright (C) 2011-2013 Luca Piccioni
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
	/// Aligned memory buffer.
	/// </summary>
	public class AlignedMemoryBuffer : IDisposable
	{
		#region Constructors

		/// <summary>
		/// Construct an AlignedMemoryBuffer.
		/// </summary>
		/// <param name="size">
		/// A <see cref="System.UInt32"/> that specify the aligned buffer size, in basic machine units (bytes).
		/// </param>
		/// <param name="alignment">
		/// A <see cref="System.UInt32"/> that specify the aligned buffer alignment.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="size"/> is 0.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="alignment"/> is not 4, 8, 16 and 32.
		/// </exception>
		/// <exception cref="OutOfMemoryException">
		/// There is insufficient memory to satisfy the request of allocated memory.
		/// </exception>
		public AlignedMemoryBuffer(uint size, uint alignment)
		{
			if (size == 0)
				throw new ArgumentException("invalid", "size");
			if ((alignment != 4) && (alignment != 8) && (alignment != 16) && (alignment != 32))
				throw new ArgumentException("invalid", "alignment");

			// Store alignment
			mAlignment = alignment;
			// Store size
			mSize = size;
			// Allocate unmanaged buffer
			mUnmanagedBuffer = Marshal.AllocHGlobal(new IntPtr(size + alignment));

			// Align buffer pointer
			long misalignment = (long)((ulong)mUnmanagedBuffer.ToInt64() % alignment);
			
			mAlignedBuffer = misalignment != 0 ? new IntPtr(mUnmanagedBuffer.ToInt64() + alignment - misalignment) : mUnmanagedBuffer;
		}

		#endregion

		#region Aligned Buffer Management

		/// <summary>
		/// The aligned memory buffer.
		/// </summary>
		/// <exception cref="ObjectDisposedException">
		/// Exception thrown in the case the AlignedMemoryBuffer instance aws disposed.
		/// </exception>
		public IntPtr AlignedBuffer
		{
			get
			{
				if (IsDisposed)
					throw new ObjectDisposedException("AlignedMemoryBuffer");
				return (mAlignedBuffer);
			}
		}

		/// <summary>
		/// The size of the buffer, is basic machine units (bytes).
		/// </summary>
		public uint Size { get { return (mSize); } }

		/// <summary>
		/// The <see cref="AlignedBuffer"/> alignment.
		/// </summary>
		public uint Alignment { get { return (mAlignment); } }

		/// <summary>
		/// Unmanaged buffer.
		/// </summary>
		private IntPtr mUnmanagedBuffer;

		/// <summary>
		/// Point to 'mUnmanagedBuffer' in a way it is aligned.
		/// </summary>
		private IntPtr mAlignedBuffer;

		/// <summary>
		/// The 'mAlignedBuffer' pointer alignment.
		/// </summary>
		private readonly uint mAlignment;

		/// <summary>
		/// The size of the buffer, is basic machine units (bytes).
		/// </summary>
		private readonly uint mSize;

		#endregion

		#region Memory Buffer Copy

		/// <summary>
		/// Copy data from another AlignedMemoryBuffer. 
		/// </summary>
		/// <param name="otherMemoryBuffer">
		/// A <see cref="AlignedMemoryBuffer"/> which has allocated the data to be copied.
		/// </param>
		/// <param name="otherOffset">
		/// A <see cref="System.UInt64"/> which specify an additional offset (in bytes) to apply to <paramref name="otherMemoryBuffer"/>.
		/// </param>
		/// <param name="thisOffset">
		/// A <see cref="System.UInt64"/> which specify an additional offset (in bytes) to apply to this AlignedMemoryBuffer.
		/// </param>
		/// <param name="bytesCopied">
		/// A <see cref="System.UInt64"/> which specify the number of bytes to be copied.
		/// </param>
		public void CopyBuffer(AlignedMemoryBuffer otherMemoryBuffer, ulong otherOffset, ulong thisOffset, ulong bytesCopied)
		{
			if (IsDisposed)
				throw new ObjectDisposedException("AlignedMemoryBuffer");
			if (otherMemoryBuffer == null)
				throw new ArgumentNullException("otherMemoryBuffer");
			if (otherMemoryBuffer.mUnmanagedBuffer == IntPtr.Zero)
				throw new ArgumentException("disposed", "otherMemoryBuffer");
			if (thisOffset + bytesCopied >= otherMemoryBuffer.Size - otherOffset)
				throw new InvalidOperationException("copying out of bounds");

			if (bytesCopied > 0) {
				IntPtr src = new IntPtr(otherMemoryBuffer.AlignedBuffer.ToInt64() + (long)otherOffset);
				IntPtr dst = new IntPtr(AlignedBuffer.ToInt64() + (long)thisOffset);

				Memory.MemoryCopy(dst, src, bytesCopied);
			}
		}

		#endregion

		#region IDisposable Implementation

		/// <summary>
		/// Finalizer.
		/// </summary>
		~AlignedMemoryBuffer()
		{
			Dispose(false);
		}

		/// <summary>
		/// Get whether this instance has been disposed.
		/// </summary>
		public bool IsDisposed { get { return (mDisposed); } }

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// </param>
		private void Dispose(bool disposing)
		{
			if (disposing) {
				if (mUnmanagedBuffer != IntPtr.Zero) {
					// Release unmanaged buffer
					Marshal.FreeHGlobal(mUnmanagedBuffer);
					// Reset pointers
					mUnmanagedBuffer = mAlignedBuffer = IntPtr.Zero;
				}
			}
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			// Do not call dispose twice
			GC.SuppressFinalize(this);
			// Dispose this instance
			Dispose(true);
			// Mark as disposed
			mDisposed = true;
		}

		/// <summary>
		/// Flag indicating that this instance has been disposed.
		/// </summary>
		private bool mDisposed;

		#endregion
	}
}
