
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

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#if HAVE_NUMERICS
using System.Numerics;
#endif

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
#if HAVE_NUMERICS
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
#endif
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
