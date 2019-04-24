
// Copyright (C) 2017 Luca Piccioni
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

// Symbol for disabling redundant texture unit object binding
#define ENABLE_LAZY_IMAGE_UNIT_BINDING

using System;
using System.Diagnostics;

namespace OpenGL.Objects
{
	/// <summary>
	/// The state of a <see cref="ImageUnit"/>.
	/// </summary>
	/// <remarks>
	/// Current texture object name is omitted due the resource management required.
	/// </remarks>
	internal class ImageUnitState : IEquatable<ImageUnitState>
	{
		#region State

		/// <summary>
		/// Level of bound texture object.
		/// </summary>
		public int Level;

		/// <summary>
		/// Texture object bound with multiple layers.
		/// </summary>
		public bool Layered;

		/// <summary>
		/// Layer of bound texture, if not layered.
		/// </summary>
		public int Layer;

		/// <summary>
		/// Read and/or write access for bound texture.
		/// </summary>
		public BufferAccess Access = BufferAccess.ReadOnly;

		/// <summary>
		/// Format used for accesses to bound texture.
		/// </summary>
		public virtual InternalFormat InternalFormat { get; set; } = InternalFormat.R8;

		#endregion

		#region Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="left">
		/// A <see cref="ImageUnitState"/> to compare with <paramref name="right"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="ImageUnitState"/> to compare with <paramref name="left"/>.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="left"/> equals <paramref name="right"/>.
		/// </returns>
		public static bool operator ==(ImageUnitState left, ImageUnitState right)
		{
			if (ReferenceEquals(left, right))
				return true;
			if (ReferenceEquals(left, null))
				return false;

			return left.Equals(right);
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="left">
		/// A <see cref="ImageUnitState"/> to compare with <paramref name="right"/>.
		/// </param>
		/// <param name="right">
		/// A <see cref="ImageUnitState"/> to compare with <paramref name="left"/>.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="left"/> doesn't equals <paramref name="right"/>.
		/// </returns>
		public static bool operator !=(ImageUnitState left, ImageUnitState right)
		{
			if (ReferenceEquals(left, right))
				return false;
			if (ReferenceEquals(left, null))
				return false;

			return !left.Equals(right);
		}

		#endregion

		#region Overrides

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return false;
			if (ReferenceEquals(this, obj))
				return true;

#if NETSTANDARD1_1 || NETSTANDARD1_4 || NETCORE
			if ((obj.GetType() != typeof(KhronosVersion)) && (obj.GetType().GetTypeInfo().IsSubclassOf(typeof(ImageUnitState)) == false))
				return (false);
#else
			if (obj.GetType() != typeof(ImageUnitState) && obj.GetType().IsSubclassOf(typeof(ImageUnitState)) == false)
				return false;
#endif

			return Equals((ImageUnitState)obj);
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = 0;

				result = (result * 397) ^ Level.GetHashCode();
				result = (result * 397) ^ Layered.GetHashCode();
				if (Layered)
					result = (result * 397) ^ Layer.GetHashCode();
				result = (result * 397) ^ Access.GetHashCode();
				result = (result * 397) ^ InternalFormat.GetHashCode();

				return result;
			}
		}

		#endregion

		#region IEquatable<ImageUnitState> Implementation

		/// <summary>
		/// Returns a boolean value indicating whether this instance is equal to <paramref name="other"/>.
		/// </summary>
		/// <param name="other">
		/// The ImageUnitState to be compared with this ImageUnitState.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="other"/> equals to this instance.
		/// </returns>
		public bool Equals(ImageUnitState other)
		{
			if (ReferenceEquals(null, other))
				return false;
			if (ReferenceEquals(this, other))
				return true;

			if (Level != other.Level)
				return false;
			if (Layered != other.Layered)
				return false;
			if (Layered && Layer != other.Layer)
				return false;
			if (Access != other.Access)
				return false;
			if (InternalFormat != other.InternalFormat)
				return false;

			return true;
		}

		#endregion
	}

	/// <summary>
	/// Image unit abstraction.
	/// </summary>
	/// <remarks>
	/// The current texture object is loosely tracked using a <see cref="WeakReference"/>.
	/// </remarks>
	sealed internal class ImageUnit : ImageUnitState
	{
		#region Constructors

		/// <summary>
		/// Construct an ImageUnit specifying its index.
		/// </summary>
		/// <param name="index"></param>
		public ImageUnit(uint index)
		{
			Index = index;
		}

		#endregion

		#region Information

		/// <summary>
		/// The index of the ImageUnit.
		/// </summary>
		public readonly uint Index;

		/// <summary>
		/// Get or set the texture currently bound on texture unit.
		/// </summary>
		public Texture Texture
		{
			get
			{
				Texture currTexture = null;

				if (_Texture != null && _Texture.IsAlive)
					currTexture = (Texture)_Texture.Target;

				return currTexture;
			}
			set
			{
				_Texture = new WeakReference(value);
			}
		}

		/// <summary>
		/// Texture currently bound on texture unit.
		/// </summary>
		private WeakReference _Texture;

		#endregion

		#region Bind

		/// <summary>
		/// Bind a <see cref="Texture"/> to this ImageUnit (core function).
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> managing this ImageUnit.
		/// </param>
		/// <param name="texture">
		/// The <see cref="uint"/> that specifies the name of the texture to be bound to this ImageUnit.
		/// </param>
		/// <param name="unitState">
		/// Specifies the state of the image unit.
		/// </param>
		internal void Bind(GraphicsContext ctx, Texture texture, ImageUnitState unitState)
		{
			GraphicsResource.CheckCurrentContext(ctx);
			if (unitState == null)
				throw new ArgumentNullException("unitState");

			uint bindTextureName = texture != null ? texture.ObjectName : GraphicsResource.InvalidObjectName;

			Texture currTexture = Texture;
			uint currTextureName = currTexture != null ? currTexture.ObjectName : GraphicsResource.InvalidObjectName;

			// Bind the texture on the image unit, if necessary
			bool bindImageTexture = false;

#if ENABLE_LAZY_IMAGE_UNIT_BINDING
			bindImageTexture |= currTextureName != bindTextureName;
			bindImageTexture |= this != unitState;
#else
			bindImageTexture = true;
#endif

			if (bindImageTexture) {
				// Since here, the texture is bound to the texture unit
				Gl.BindImageTexture(Index, bindTextureName, unitState.Level, unitState.Layered, unitState.Layer, unitState.Access, unitState.InternalFormat);
				Texture = texture;
			} else {
				// Texture already bound to image unit, Gl.BindImageTexture not necessary
			}
		}

		#endregion
	}
}
