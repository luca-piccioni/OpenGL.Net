
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

namespace OpenGL.Objects
{
	/// <summary>
	/// BufferObject usage hints.
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
	public enum BufferObjectHint
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
		StaticCpuDraw = BufferUsageARB.StaticDraw,

		/// <summary>
		/// Buffer used for drawing, specified once by OpenGL rendering.
		/// </summary>
		/// <remarks>
		/// <para>
		/// By using this hint, this BufferObject does not allocates client memory.
		/// </para>
		/// </remarks>
		StaticGpuDraw = BufferUsageARB.StaticCopy,

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
		DynamicCpuDraw = BufferUsageARB.DynamicDraw,

		/// <summary>
		/// Buffer used for drawing, specified many times by OpenGL rendering.
		/// </summary>
		/// <remarks>
		/// <para>
		/// By using this hint, this BufferObject does not allocates client memory.
		/// </para>
		/// </remarks>
		DynamicGpuDraw = BufferUsageARB.DynamicCopy,

		/// <summary>
		/// Buffer used for reading, specified once by OpenGL rendering.
		/// </summary>
		/// <remarks>
		/// <para>
		/// By using this hint, this BufferObject allocates client memory to get buffer object contents.
		/// Client memory will be released at object disposition.
		/// </para>
		/// </remarks>
		StaticRead = BufferUsageARB.StaticRead,

		/// <summary>
		/// Buffer used for reading, specified many times by OpenGL rendering.
		/// </summary>
		/// <remarks>
		/// <para>
		/// By using this hint, this BufferObject allocates client memory to get buffer object contents.
		/// Client memory will be released at object disposition.
		/// </para>
		/// </remarks>
		DynamicRead = BufferUsageARB.DynamicRead
	}
}
