
// Copyright (C) 2017 Luca Piccioni
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
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using System.Numerics;

namespace OpenGL.Objects.Collections
{
	/// <summary>
	/// Dictionary specialized for mapping generic types against a string key.
	/// </summary>
	/// <typeparam name="T">
	/// Any type to be mapped against a string key.
	/// </typeparam>
	internal class StringDictionary<T> : Dictionary<string, T>
	{
		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public StringDictionary() : base(new StringEqualityComparer())
		{
			
		}

		#endregion

		#region String Equality Comparer

		/// <summary>
		/// A <see cref="IEqualityComparer{T}"/> able to index dictionary keys of type <see cref="String"/>.
		/// </summary>
		class StringEqualityComparer : IEqualityComparer<string>
		{
			/// <summary>
			/// Determines whether the specified objects are equal.
			/// </summary>
			/// <param name="x">
			/// A <see cref="String"/> that is the first object to compare.
			/// </param>
			/// <param name="y">
			/// A <see cref="String"/> that is the second object to compare.
			/// </param>
			/// <returns>
			/// It returns a boolean value indicating that <paramref name="x"/> and <paramref name="y"/> are equal.
			/// </returns>
			public bool Equals(string x, string y)
			{
				return (x.Equals(y));
			}

			/// <summary>
			/// Returns a hash code for the specified object.
			/// </summary>
			/// <param name="obj">
			/// The <see cref="String"/> for which a hash code is to be returned.
			/// </param>
			/// <returns>
			/// A hash code for the specified object <paramref name="obj"/>.
			/// </returns>
			public int GetHashCode(string obj)
			{
				unsafe { 
					fixed (char *src = obj) {
						int hash = 5381;
						int len = obj.Length * 2;

						byte* srcPtrBase = (byte*)src;
						ushort* srcPtr16;
						int srcPtr16Len;

						if (Vector.IsHardwareAccelerated) {
							int* srcPtrVec = (int*)srcPtrBase;
							int srcPtrVecLen = len / (Vector<int>.Count * 4);

							if (srcPtrVecLen > 0) {
								Vector<int> hashVec = new Vector<int>(hash);
								for (int i = 0; i < srcPtrVecLen; i++, srcPtrVec += Vector<int>.Count)
									hashVec = hashVec ^ Unsafe.Read<Vector<int>>(srcPtrVec);

								hash = hashVec[0] ^ hashVec[1] ^ hashVec[2] ^ hashVec[3];
								len -= srcPtrVecLen * Vector<int>.Count * 4;
								srcPtrBase = (byte*)srcPtrVec;
							}
						}

						if (IntPtr.Size == 8) {
							long hash64 = hash;
							long* srcPtr64 = (long*)srcPtrBase;
							int srcPtr64Len = len / 8;

							for (int i = 0; i < srcPtr64Len; i++, srcPtr64++)
								hash64 ^= *srcPtr64;

							hash = (int)(hash64 >> 32) ^ (int)(hash64 & 0xFFFFFFFF);

							srcPtr16 = (ushort*)srcPtr64;
							srcPtr16Len = len - srcPtr64Len * 8;

							for (int i = 0; i < srcPtr16Len; i++, srcPtr16++)
								hash ^= *srcPtr16;
						} else {
							int* srcPtr32 = (int*)srcPtrBase;
							int srcPtr32Len = len / 4;

							for (int i = 0; i < srcPtr32Len; i++, srcPtr32++)
								hash ^= *srcPtr32;

							srcPtr16 = (ushort*)srcPtr32;
							srcPtr16Len = len - srcPtr32Len * 4;

							for (int i = 0; i < srcPtr16Len; i++, srcPtr16++)
								hash ^= *srcPtr16;
						}

						return (hash);
					}
				}
			}
		}

		#endregion
	}
}
