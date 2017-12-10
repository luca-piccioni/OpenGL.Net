
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
		/// [GL] glMultiTexCoord1bOES: Binding for glMultiTexCoord1bOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void MultiTexCoord1OES(TextureUnit texture, sbyte s)
		{
			Debug.Assert(Delegates.pglMultiTexCoord1bOES != null, "pglMultiTexCoord1bOES not implemented");
			Delegates.pglMultiTexCoord1bOES((int)texture, s);
			LogCommand("glMultiTexCoord1bOES", null, texture, s			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMultiTexCoord1bvOES: Binding for glMultiTexCoord1bvOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void MultiTexCoord1OES(TextureUnit texture, sbyte[] coords)
		{
			Debug.Assert(coords.Length >= 1);
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoord1bvOES != null, "pglMultiTexCoord1bvOES not implemented");
					Delegates.pglMultiTexCoord1bvOES((int)texture, p_coords);
					LogCommand("glMultiTexCoord1bvOES", null, texture, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMultiTexCoord2bOES: Binding for glMultiTexCoord2bOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void MultiTexCoord2OES(TextureUnit texture, sbyte s, sbyte t)
		{
			Debug.Assert(Delegates.pglMultiTexCoord2bOES != null, "pglMultiTexCoord2bOES not implemented");
			Delegates.pglMultiTexCoord2bOES((int)texture, s, t);
			LogCommand("glMultiTexCoord2bOES", null, texture, s, t			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMultiTexCoord2bvOES: Binding for glMultiTexCoord2bvOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void MultiTexCoord2OES(TextureUnit texture, sbyte[] coords)
		{
			Debug.Assert(coords.Length >= 2);
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoord2bvOES != null, "pglMultiTexCoord2bvOES not implemented");
					Delegates.pglMultiTexCoord2bvOES((int)texture, p_coords);
					LogCommand("glMultiTexCoord2bvOES", null, texture, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMultiTexCoord3bOES: Binding for glMultiTexCoord3bOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void MultiTexCoord3OES(TextureUnit texture, sbyte s, sbyte t, sbyte r)
		{
			Debug.Assert(Delegates.pglMultiTexCoord3bOES != null, "pglMultiTexCoord3bOES not implemented");
			Delegates.pglMultiTexCoord3bOES((int)texture, s, t, r);
			LogCommand("glMultiTexCoord3bOES", null, texture, s, t, r			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMultiTexCoord3bvOES: Binding for glMultiTexCoord3bvOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void MultiTexCoord3OES(TextureUnit texture, sbyte[] coords)
		{
			Debug.Assert(coords.Length >= 3);
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoord3bvOES != null, "pglMultiTexCoord3bvOES not implemented");
					Delegates.pglMultiTexCoord3bvOES((int)texture, p_coords);
					LogCommand("glMultiTexCoord3bvOES", null, texture, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMultiTexCoord4bOES: Binding for glMultiTexCoord4bOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="q">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void MultiTexCoord4OES(TextureUnit texture, sbyte s, sbyte t, sbyte r, sbyte q)
		{
			Debug.Assert(Delegates.pglMultiTexCoord4bOES != null, "pglMultiTexCoord4bOES not implemented");
			Delegates.pglMultiTexCoord4bOES((int)texture, s, t, r, q);
			LogCommand("glMultiTexCoord4bOES", null, texture, s, t, r, q			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMultiTexCoord4bvOES: Binding for glMultiTexCoord4bvOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void MultiTexCoord4OES(TextureUnit texture, sbyte[] coords)
		{
			Debug.Assert(coords.Length >= 4);
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoord4bvOES != null, "pglMultiTexCoord4bvOES not implemented");
					Delegates.pglMultiTexCoord4bvOES((int)texture, p_coords);
					LogCommand("glMultiTexCoord4bvOES", null, texture, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glTexCoord1bOES: Binding for glTexCoord1bOES.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void TexCoord1OES(sbyte s)
		{
			Debug.Assert(Delegates.pglTexCoord1bOES != null, "pglTexCoord1bOES not implemented");
			Delegates.pglTexCoord1bOES(s);
			LogCommand("glTexCoord1bOES", null, s			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glTexCoord1bvOES: Binding for glTexCoord1bvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void TexCoord1OES(sbyte[] coords)
		{
			Debug.Assert(coords.Length >= 1);
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoord1bvOES != null, "pglTexCoord1bvOES not implemented");
					Delegates.pglTexCoord1bvOES(p_coords);
					LogCommand("glTexCoord1bvOES", null, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glTexCoord2bOES: Binding for glTexCoord2bOES.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void TexCoord2OES(sbyte s, sbyte t)
		{
			Debug.Assert(Delegates.pglTexCoord2bOES != null, "pglTexCoord2bOES not implemented");
			Delegates.pglTexCoord2bOES(s, t);
			LogCommand("glTexCoord2bOES", null, s, t			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glTexCoord2bvOES: Binding for glTexCoord2bvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void TexCoord2OES(sbyte[] coords)
		{
			Debug.Assert(coords.Length >= 2);
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoord2bvOES != null, "pglTexCoord2bvOES not implemented");
					Delegates.pglTexCoord2bvOES(p_coords);
					LogCommand("glTexCoord2bvOES", null, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glTexCoord3bOES: Binding for glTexCoord3bOES.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void TexCoord3OES(sbyte s, sbyte t, sbyte r)
		{
			Debug.Assert(Delegates.pglTexCoord3bOES != null, "pglTexCoord3bOES not implemented");
			Delegates.pglTexCoord3bOES(s, t, r);
			LogCommand("glTexCoord3bOES", null, s, t, r			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glTexCoord3bvOES: Binding for glTexCoord3bvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void TexCoord3OES(sbyte[] coords)
		{
			Debug.Assert(coords.Length >= 3);
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoord3bvOES != null, "pglTexCoord3bvOES not implemented");
					Delegates.pglTexCoord3bvOES(p_coords);
					LogCommand("glTexCoord3bvOES", null, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glTexCoord4bOES: Binding for glTexCoord4bOES.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="q">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void TexCoord4OES(sbyte s, sbyte t, sbyte r, sbyte q)
		{
			Debug.Assert(Delegates.pglTexCoord4bOES != null, "pglTexCoord4bOES not implemented");
			Delegates.pglTexCoord4bOES(s, t, r, q);
			LogCommand("glTexCoord4bOES", null, s, t, r, q			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glTexCoord4bvOES: Binding for glTexCoord4bvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void TexCoord4OES(sbyte[] coords)
		{
			Debug.Assert(coords.Length >= 4);
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoord4bvOES != null, "pglTexCoord4bvOES not implemented");
					Delegates.pglTexCoord4bvOES(p_coords);
					LogCommand("glTexCoord4bvOES", null, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertex2bOES: Binding for glVertex2bOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void Vertex2OES(sbyte x, sbyte y)
		{
			Debug.Assert(Delegates.pglVertex2bOES != null, "pglVertex2bOES not implemented");
			Delegates.pglVertex2bOES(x, y);
			LogCommand("glVertex2bOES", null, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertex2bvOES: Binding for glVertex2bvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void Vertex2OES(sbyte[] coords)
		{
			Debug.Assert(coords.Length >= 2);
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertex2bvOES != null, "pglVertex2bvOES not implemented");
					Delegates.pglVertex2bvOES(p_coords);
					LogCommand("glVertex2bvOES", null, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertex3bOES: Binding for glVertex3bOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void Vertex3OES(sbyte x, sbyte y, sbyte z)
		{
			Debug.Assert(Delegates.pglVertex3bOES != null, "pglVertex3bOES not implemented");
			Delegates.pglVertex3bOES(x, y, z);
			LogCommand("glVertex3bOES", null, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertex3bvOES: Binding for glVertex3bvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void Vertex3OES(sbyte[] coords)
		{
			Debug.Assert(coords.Length >= 3);
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertex3bvOES != null, "pglVertex3bvOES not implemented");
					Delegates.pglVertex3bvOES(p_coords);
					LogCommand("glVertex3bvOES", null, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertex4bOES: Binding for glVertex4bOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void Vertex4OES(sbyte x, sbyte y, sbyte z, sbyte w)
		{
			Debug.Assert(Delegates.pglVertex4bOES != null, "pglVertex4bOES not implemented");
			Delegates.pglVertex4bOES(x, y, z, w);
			LogCommand("glVertex4bOES", null, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertex4bvOES: Binding for glVertex4bvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void Vertex4OES(sbyte[] coords)
		{
			Debug.Assert(coords.Length >= 4);
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertex4bvOES != null, "pglVertex4bvOES not implemented");
					Delegates.pglVertex4bvOES(p_coords);
					LogCommand("glVertex4bvOES", null, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glMultiTexCoord1bOES(int texture, sbyte s);

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[ThreadStatic]
			internal static glMultiTexCoord1bOES pglMultiTexCoord1bOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glMultiTexCoord1bvOES(int texture, sbyte* coords);

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[ThreadStatic]
			internal static glMultiTexCoord1bvOES pglMultiTexCoord1bvOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glMultiTexCoord2bOES(int texture, sbyte s, sbyte t);

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[ThreadStatic]
			internal static glMultiTexCoord2bOES pglMultiTexCoord2bOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glMultiTexCoord2bvOES(int texture, sbyte* coords);

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[ThreadStatic]
			internal static glMultiTexCoord2bvOES pglMultiTexCoord2bvOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glMultiTexCoord3bOES(int texture, sbyte s, sbyte t, sbyte r);

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[ThreadStatic]
			internal static glMultiTexCoord3bOES pglMultiTexCoord3bOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glMultiTexCoord3bvOES(int texture, sbyte* coords);

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[ThreadStatic]
			internal static glMultiTexCoord3bvOES pglMultiTexCoord3bvOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glMultiTexCoord4bOES(int texture, sbyte s, sbyte t, sbyte r, sbyte q);

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[ThreadStatic]
			internal static glMultiTexCoord4bOES pglMultiTexCoord4bOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glMultiTexCoord4bvOES(int texture, sbyte* coords);

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[ThreadStatic]
			internal static glMultiTexCoord4bvOES pglMultiTexCoord4bvOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glTexCoord1bOES(sbyte s);

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[ThreadStatic]
			internal static glTexCoord1bOES pglTexCoord1bOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glTexCoord1bvOES(sbyte* coords);

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[ThreadStatic]
			internal static glTexCoord1bvOES pglTexCoord1bvOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glTexCoord2bOES(sbyte s, sbyte t);

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[ThreadStatic]
			internal static glTexCoord2bOES pglTexCoord2bOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glTexCoord2bvOES(sbyte* coords);

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[ThreadStatic]
			internal static glTexCoord2bvOES pglTexCoord2bvOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glTexCoord3bOES(sbyte s, sbyte t, sbyte r);

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[ThreadStatic]
			internal static glTexCoord3bOES pglTexCoord3bOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glTexCoord3bvOES(sbyte* coords);

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[ThreadStatic]
			internal static glTexCoord3bvOES pglTexCoord3bvOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glTexCoord4bOES(sbyte s, sbyte t, sbyte r, sbyte q);

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[ThreadStatic]
			internal static glTexCoord4bOES pglTexCoord4bOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glTexCoord4bvOES(sbyte* coords);

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[ThreadStatic]
			internal static glTexCoord4bvOES pglTexCoord4bvOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glVertex2bOES(sbyte x, sbyte y);

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[ThreadStatic]
			internal static glVertex2bOES pglVertex2bOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glVertex2bvOES(sbyte* coords);

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[ThreadStatic]
			internal static glVertex2bvOES pglVertex2bvOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glVertex3bOES(sbyte x, sbyte y, sbyte z);

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[ThreadStatic]
			internal static glVertex3bOES pglVertex3bOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glVertex3bvOES(sbyte* coords);

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[ThreadStatic]
			internal static glVertex3bvOES pglVertex3bvOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glVertex4bOES(sbyte x, sbyte y, sbyte z, sbyte w);

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[ThreadStatic]
			internal static glVertex4bOES pglVertex4bOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glVertex4bvOES(sbyte* coords);

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[ThreadStatic]
			internal static glVertex4bvOES pglVertex4bvOES;

		}
	}

}
