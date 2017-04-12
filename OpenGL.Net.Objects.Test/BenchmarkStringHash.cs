
// Copyright (C) 2016-2017 Luca Piccioni
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
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;

using NUnit.Framework;

using OpenGL.Objects.Collections;
using OpenGL.Test;

namespace OpenGL.Objects.Test
{
	[TestFixture, RequiresSTA]
	class BenchmarkStringHash : BenchmarkBase
	{
		static BenchmarkStringHash()
		{
			Random random = new Random((int)DateTime.UtcNow.Ticks);
			string[] dictStrings = new string[BenchmarkStringHashSize];

			for (int i = 0; i < dictStrings.Length; i++)
				dictStrings[i] = GetRandomString(random);

			_HashStrings = new string[BenchmarkStringHashSize * 2];
			for (int i = 0; i < _HashStrings.Length; i++) {
				switch (i % 2) {
					case 0:
						_HashStrings[i] = dictStrings[i / 2];
						break;
					case 1:
						_HashStrings[i] = dictStrings[i / 2] + GetRandomString(random);
						break;
				}
			}

			

			foreach (string item in dictStrings) {
				string keyValue = GetRandomString(random);

				// Dictionary<T, V>
				if (_HashDictionaryDefault.ContainsKey(item) == false)
					_HashDictionaryDefault.Add(item, keyValue);
				if (_HashDictionaryCustom1Hash.ContainsKey(item) == false)
					_HashDictionaryCustom1Hash.Add(item, keyValue);
				if (_HashDictionaryCustom2Hash.ContainsKey(item) == false)
					_HashDictionaryCustom2Hash.Add(item, keyValue);

				// Hashtable
				if (_HashTableDefault.ContainsKey(item) == false)
					_HashTableDefault.Add(item, keyValue);
				if (_HashTableCustom1Hash.ContainsKey(item) == false)
					_HashTableCustom1Hash.Add(item, keyValue);
				if (_HashTableCustom2Hash.ContainsKey(item) == false)
					_HashTableCustom2Hash.Add(item, keyValue);

				// Hashset
				if (_HashsetDefault.Contains(item) == false)
					_HashsetDefault.Add(item);
				if (_HashsetCustom1Hash.Contains(item) == false)
					_HashsetCustom1Hash.Add(item);
				if (_HashsetCustom2Hash.Contains(item) == false)
					_HashsetCustom2Hash.Add(item);

				// OpenGL.Net.Objects
				if (_ObjectsImpl.ContainsKey(item) == false)
					_ObjectsImpl.Add(item, keyValue);
			}
		}

		/// <summary>
		/// Test memory copy methods (one large buffer).
		/// </summary>
		[Test]
		public void BenchmarkStringHashes()
		{
			RunBenchmarks<BenchmarkStringHash>("BenchmarkStringHash");
		}

		/// <summary>
		/// Test worst performance for copying arrays using managed method.
		/// </summary>
		[Benchmark("BenchmarkStringHash_DictionaryDefault", Repetitions = BenchmarkStringHashRepetitions)]
		public static void BenchmarkStringHash_DictionaryDefault()
		{
			for (int i = 0; i < BenchmarkStringHashSize; i++) {
				object keyValue;
				_HashDictionaryDefault.TryGetValue(_HashStrings[i], out keyValue);
			}
		}

		/// <summary>
		/// Test worst performance for copying arrays using managed method.
		/// </summary>
		[Benchmark("BenchmarkStringHash_DictionaryCustom1Hash", Repetitions = BenchmarkStringHashRepetitions)]
		public static void BenchmarkStringHash_DictionaryCustom1Hash()
		{
			for (int i = 0; i < BenchmarkStringHashSize; i++) {
				object keyValue;
				_HashDictionaryCustom1Hash.TryGetValue(_HashStrings[i], out keyValue);
			}
		}

		class Custom1StringEqualityComparer : IEqualityComparer<string>, IEqualityComparer
		{
			public new bool Equals(object x, object y)
			{
				return (x.Equals(y));
			}

			public bool Equals(string x, string y)
			{
				return (x.Equals(y));
			}

			public int GetHashCode(object obj)
			{
				return (obj.GetHashCode());
			}

			public int GetHashCode(string obj)
			{
				return (obj.GetHashCode());
			}
		}

		/// <summary>
		/// Test worst performance for copying arrays using managed method.
		/// </summary>
		[Benchmark("BenchmarkStringHash_DictionaryCustom2Hash", Repetitions = BenchmarkStringHashRepetitions)]
		public static void BenchmarkStringHash_DictionaryCustom2Hash()
		{
			for (int i = 0; i < BenchmarkStringHashSize; i++) {
				object keyValue;
				_HashDictionaryCustom2Hash.TryGetValue(_HashStrings[i], out keyValue);
			}
		}

		class Custom2StringEqualityComparer : IEqualityComparer<string>, IEqualityComparer
		{
			public new bool Equals(object x, object y)
			{
				return (Equals((string)x, (string)y));
			}

			public bool Equals(string x, string y)
			{
				return (x.Equals(y));
			}

			public int GetHashCode(object obj)
			{
				return (GetHashCode((string)obj));
			}

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

		/// <summary>
		/// Test worst performance for copying arrays using managed method.
		/// </summary>
		[Benchmark("BenchmarkStringHash_HashtableDefault", Repetitions = BenchmarkStringHashRepetitions)]
		public static void BenchmarkStringHash_HashtableDefault()
		{
			for (int i = 0; i < BenchmarkStringHashSize; i++) {
				object keyValue;
				keyValue = _HashTableDefault[_HashStrings[i]];
			}
		}

		/// <summary>
		/// Test worst performance for copying arrays using managed method.
		/// </summary>
		[Benchmark("BenchmarkStringHash_HashtableCustom1Hash", Repetitions = BenchmarkStringHashRepetitions)]
		public static void BenchmarkStringHash_HashtableCustom1Hash()
		{
			for (int i = 0; i < BenchmarkStringHashSize; i++) {
				object keyValue;
				keyValue = _HashTableCustom1Hash[_HashStrings[i]];
			}
		}

		/// <summary>
		/// Test worst performance for copying arrays using managed method.
		/// </summary>
		[Benchmark("BenchmarkStringHash_HashtableCustom2Hash", Repetitions = BenchmarkStringHashRepetitions)]
		public static void BenchmarkStringHash_HashtableCustom2Hash()
		{
			for (int i = 0; i < BenchmarkStringHashSize; i++) {
				object keyValue;
				keyValue = _HashTableCustom2Hash[_HashStrings[i]];
			}
		}

		/// <summary>
		/// Test worst performance for copying arrays using managed method.
		/// </summary>
		[Benchmark("BenchmarkStringHash_ObjectsHash", Repetitions = BenchmarkStringHashRepetitions)]
		public static void BenchmarkStringHash_ObjectsHash()
		{
			for (int i = 0; i < BenchmarkStringHashSize; i++) {
				object keyValue;
				keyValue = _ObjectsImpl.TryGetValue(_HashStrings[i], out keyValue);
			}
		}

		static string _HashChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789.";

		private static readonly string[] _HashStrings;

		private static readonly Dictionary<string, object> _HashDictionaryDefault = new Dictionary<string, object>();

		private static readonly Dictionary<string, object> _HashDictionaryCustom1Hash = new Dictionary<string, object>(new Custom1StringEqualityComparer());

		private static readonly Dictionary<string, object> _HashDictionaryCustom2Hash = new Dictionary<string, object>(new Custom2StringEqualityComparer());

		private static readonly Hashtable _HashTableDefault = new Hashtable();

		private static readonly Hashtable _HashTableCustom1Hash = new Hashtable(new Custom1StringEqualityComparer());

		private static readonly Hashtable _HashTableCustom2Hash = new Hashtable(new Custom2StringEqualityComparer());

		private static readonly HashSet<string> _HashsetDefault = new HashSet<string>();

		private static readonly HashSet<string> _HashsetCustom1Hash = new HashSet<string>(new Custom1StringEqualityComparer());

		private static readonly HashSet<string> _HashsetCustom2Hash = new HashSet<string>(new Custom2StringEqualityComparer());

		private static readonly StringDictionary<object> _ObjectsImpl = new StringDictionary<object>();

		private static string GetRandomString(Random random)
		{
			int stringLength = BenchmarkStringLengthAvg + (int)(random.NextDouble() - 0.5f * BenchmarkStringLengthAvg);
			char[] stringChars = new char[stringLength];

			for (int i = 0; i < stringLength; i++)
				stringChars[i] = _HashChars[random.Next(_HashChars.Length)];

			return (new string(stringChars));
		}

		/// <summary>
		/// Length of the strings.
		/// </summary>
		const int BenchmarkStringLengthAvg = 25;

		/// <summary>
		/// Size of the array used for testing: 80 items.
		/// </summary>
		const uint BenchmarkStringHashSize = 500;

		/// <summary>
		/// Number of repetitions for MemoryCopy.
		/// </summary>
		private const int BenchmarkStringHashRepetitions = 200000;
	}
}
