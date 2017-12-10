
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
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
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] glGenQueryResourceTagNV: Binding for glGenQueryResourceTagNV.
		/// </summary>
		/// <param name="tagIds">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_query_resource_tag")]
		public static void GenQueryResourceTagNV(int[] tagIds)
		{
			unsafe {
				fixed (int* p_tagIds = tagIds)
				{
					Debug.Assert(Delegates.pglGenQueryResourceTagNV != null, "pglGenQueryResourceTagNV not implemented");
					Delegates.pglGenQueryResourceTagNV(tagIds.Length, p_tagIds);
					LogCommand("glGenQueryResourceTagNV", null, tagIds.Length, tagIds					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGenQueryResourceTagNV: Binding for glGenQueryResourceTagNV.
		/// </summary>
		[RequiredByFeature("GL_NV_query_resource_tag")]
		public static int GenQueryResourceTagNV()
		{
			int retValue;
			unsafe {
				Delegates.pglGenQueryResourceTagNV(1, &retValue);
				LogCommand("glGenQueryResourceTagNV", null, 1, "{ " + retValue + " }"				);
			}
			DebugCheckErrors(null);
			return (retValue);
		}

		/// <summary>
		/// [GL] glDeleteQueryResourceTagNV: Binding for glDeleteQueryResourceTagNV.
		/// </summary>
		/// <param name="tagIds">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_query_resource_tag")]
		public static void DeleteQueryResourceTagNV(int[] tagIds)
		{
			unsafe {
				fixed (int* p_tagIds = tagIds)
				{
					Debug.Assert(Delegates.pglDeleteQueryResourceTagNV != null, "pglDeleteQueryResourceTagNV not implemented");
					Delegates.pglDeleteQueryResourceTagNV(tagIds.Length, p_tagIds);
					LogCommand("glDeleteQueryResourceTagNV", null, tagIds.Length, tagIds					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glQueryResourceTagNV: Binding for glQueryResourceTagNV.
		/// </summary>
		/// <param name="tagId">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="tagString">
		/// A <see cref="T:string"/>.
		/// </param>
		[RequiredByFeature("GL_NV_query_resource_tag")]
		public static void QueryResourceTagNV(int tagId, string tagString)
		{
			Debug.Assert(Delegates.pglQueryResourceTagNV != null, "pglQueryResourceTagNV not implemented");
			Delegates.pglQueryResourceTagNV(tagId, tagString);
			LogCommand("glQueryResourceTagNV", null, tagId, tagString			);
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_NV_query_resource_tag")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGenQueryResourceTagNV(int n, int* tagIds);

			[RequiredByFeature("GL_NV_query_resource_tag")]
			[ThreadStatic]
			internal static glGenQueryResourceTagNV pglGenQueryResourceTagNV;

			[RequiredByFeature("GL_NV_query_resource_tag")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glDeleteQueryResourceTagNV(int n, int* tagIds);

			[RequiredByFeature("GL_NV_query_resource_tag")]
			[ThreadStatic]
			internal static glDeleteQueryResourceTagNV pglDeleteQueryResourceTagNV;

			[RequiredByFeature("GL_NV_query_resource_tag")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glQueryResourceTagNV(int tagId, string tagString);

			[RequiredByFeature("GL_NV_query_resource_tag")]
			[ThreadStatic]
			internal static glQueryResourceTagNV pglQueryResourceTagNV;

		}
	}

}
