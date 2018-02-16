
// Copyright (C) 2015-2017 Luca Piccioni
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
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Utility for pinning a reference type (i.e. arrays).
	/// </summary>
	public sealed class MemoryLock : IDisposable
	{
		#region Constructors

		/// <summary>
		/// Construct a MemoryLock specifying the object to pin on memory.
		/// </summary>
		/// <param name="memoryObject">
		/// The <see cref="object"/> to be pinned.
		/// </param>
		public MemoryLock(object memoryObject)
		{
			_Handle = GCHandle.Alloc(memoryObject, GCHandleType.Pinned);
		}

		#endregion

		#region Address Of Pinned Object

		/// <summary>
		/// Address of the pinned memory.
		/// </summary>
		public IntPtr Address => _Handle.IsAllocated ? _Handle.AddrOfPinnedObject() : IntPtr.Zero;

		/// <summary>
		/// Handle of the object.
		/// </summary>
		private GCHandle _Handle;

		#endregion

		#region IDisposable Implementation

		/// <summary>
		/// Releases all resource used by the <see cref="MemoryLock"/> object.
		/// </summary>
		/// <remarks>
		/// Call <see cref="Dispose"/> when you are finished using the <see cref="MemoryLock"/>.
		/// </remarks>
		public void Dispose()
		{
			if (_Handle.IsAllocated)
				_Handle.Free();
		}

		#endregion
	}
}
