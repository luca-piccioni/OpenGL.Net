
// Copyright (C) 2015 Luca Piccioni
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
using System.Runtime.InteropServices;

namespace OpenGL
{
	public sealed class MemoryLock : IDisposable
	{
		#region Constructors

		/// <summary>
		/// Construct a MemoryLock specifying the object to pin on memory.
		/// </summary>
		/// <param name="memoryObject"></param>
		public MemoryLock(object memoryObject)
		{
			_Handle = GCHandle.Alloc(memoryObject, GCHandleType.Pinned);
		}

		#endregion

		#region Address Of Pinned Object

		/// <summary>
		/// Address of the pinned memory.
		/// </summary>
		public IntPtr Address
		{
			get
			{
				return (_Handle.AddrOfPinnedObject());
			}
		}

		/// <summary>
		/// Handle of the object.
		/// </summary>
		private readonly GCHandle _Handle;

		#endregion

		#region IDisposable Implementation

		// <summary>
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
