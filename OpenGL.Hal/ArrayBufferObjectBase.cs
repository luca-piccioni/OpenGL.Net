
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

namespace OpenGL
{
	/// <summary>
	/// Array buffer object base class.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This class is a <see cref="BufferObject"/> specialized for storing data to be issued to a shader program execution.
	/// </para>
	/// </remarks>
	public abstract class ArrayBufferObjectBase : BufferObject
	{
		#region Constructors

		/// <summary>
		/// Construct an ArrayBufferObject specifying its item layout on CPU side.
		/// </summary>
		/// <param name="vertexBaseType">
		/// A <see cref="VertexBaseType"/> describing the item components base type on CPU side.
		/// </param>
		/// <param name="vertexLength">
		/// A <see cref="UInt32"/> that specify how many components have the array item.
		/// </param>
		/// <param name="vertexRank">
		/// A <see cref="UInt32"/> that specify how many columns have the array item of matrix type.
		/// </param>
		/// <param name="hint">
		/// An <see cref="BufferObjectHint"/> that specify the data buffer usage hints.
		/// </param>
		protected ArrayBufferObjectBase(BufferObjectHint hint) :
			base(BufferTargetARB.ArrayBuffer, hint)
		{
			
		}

		#endregion

		#region Array Buffer Information

		/// <summary>
		/// Get the item count allocated for this array buffer object. In the case this ArrayBufferObject
		/// has not been created yet, it returns the size of the client buffer.
		/// </summary>
		public uint ItemCount
		{
			get { return (BufferSize != 0 ? BufferSize / ItemSize : ClientBufferSize / ItemSize); }
		}

		/// <summary>
		/// Get the item count allocated in the client buffer of this buffer object. In the case this ArrayBufferObject
		/// has not been defined yet, it returns 0.
		/// </summary>
		public uint ClientItemCount
		{
			get { return (ClientBufferSize / ItemSize); }
		}

		/// <summary>
		/// Get the size of the item of this array buffer object, in bytes.
		/// </summary>
		public uint ItemSize
		{
			get { return (_ItemSize); }
			protected set
			{
				if (value == 0)
					throw new InvalidOperationException("invalid value");
				_ItemSize = value;
			}
		}

		/// <summary>
		/// Size of the storage of the array buffer object, in basic machine units (bytes).
		/// </summary>
		private uint _ItemSize;

		#endregion

		#region Array Section Interface

		/// <summary>
		/// Interface abstracting an array section.
		/// </summary>
		protected internal interface IArraySection
		{
			/// <summary>
			/// The type of the elements of the array section.
			/// </summary>
			ArrayBufferItemType ItemType { get; }

			/// <summary>
			/// Get whether the array elements should be meant normalized (fixed point precision values).
			/// </summary>
			bool Normalized { get; }

			/// <summary>
			/// Offset of the first element of the array section, in bytes.
			/// </summary>
			IntPtr Offset { get; }

			/// <summary>
			/// Offset between two element of the array section, in bytes.
			/// </summary>
			IntPtr Stride { get; }
		}

		/// <summary>
		/// Get the count of the array sections aggregated in this ArrayBufferObjectBase.
		/// </summary>
		protected internal abstract uint ArraySectionsCount { get; }

		/// <summary>
		/// Get the specified section information.
		/// </summary>
		/// <param name="index">
		/// The <see cref="UInt32"/> that specify the array section index.
		/// </param>
		/// <returns>
		/// It returns the <see cref="IArraySection"/> defining the array section.
		/// </returns>
		protected internal abstract IArraySection GetArraySection(uint index);

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
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			return (ctx.Caps.GlExtensions.VertexBufferObject_ARB);
		}

		#endregion
	}
}
