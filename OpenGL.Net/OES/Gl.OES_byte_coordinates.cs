
// Copyright (C) 2015-2017 Luca Piccioni
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Binding for glMultiTexCoord1bOES.
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
			Delegates.pglMultiTexCoord1bOES((Int32)texture, s);
			LogCommand("glMultiTexCoord1bOES", null, texture, s			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoord1bvOES.
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
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoord1bvOES != null, "pglMultiTexCoord1bvOES not implemented");
					Delegates.pglMultiTexCoord1bvOES((Int32)texture, p_coords);
					LogCommand("glMultiTexCoord1bvOES", null, texture, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoord2bOES.
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
			Delegates.pglMultiTexCoord2bOES((Int32)texture, s, t);
			LogCommand("glMultiTexCoord2bOES", null, texture, s, t			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoord2bvOES.
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
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoord2bvOES != null, "pglMultiTexCoord2bvOES not implemented");
					Delegates.pglMultiTexCoord2bvOES((Int32)texture, p_coords);
					LogCommand("glMultiTexCoord2bvOES", null, texture, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoord3bOES.
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
			Delegates.pglMultiTexCoord3bOES((Int32)texture, s, t, r);
			LogCommand("glMultiTexCoord3bOES", null, texture, s, t, r			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoord3bvOES.
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
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoord3bvOES != null, "pglMultiTexCoord3bvOES not implemented");
					Delegates.pglMultiTexCoord3bvOES((Int32)texture, p_coords);
					LogCommand("glMultiTexCoord3bvOES", null, texture, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoord4bOES.
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
			Delegates.pglMultiTexCoord4bOES((Int32)texture, s, t, r, q);
			LogCommand("glMultiTexCoord4bOES", null, texture, s, t, r, q			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoord4bvOES.
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
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoord4bvOES != null, "pglMultiTexCoord4bvOES not implemented");
					Delegates.pglMultiTexCoord4bvOES((Int32)texture, p_coords);
					LogCommand("glMultiTexCoord4bvOES", null, texture, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexCoord1bOES.
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
		/// Binding for glTexCoord1bvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void TexCoord1OES(sbyte[] coords)
		{
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
		/// Binding for glTexCoord2bOES.
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
		/// Binding for glTexCoord2bvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void TexCoord2OES(sbyte[] coords)
		{
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
		/// Binding for glTexCoord3bOES.
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
		/// Binding for glTexCoord3bvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void TexCoord3OES(sbyte[] coords)
		{
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
		/// Binding for glTexCoord4bOES.
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
		/// Binding for glTexCoord4bvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void TexCoord4OES(sbyte[] coords)
		{
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
		/// Binding for glVertex2bOES.
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
		/// Binding for glVertex2bvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void Vertex2OES(sbyte[] coords)
		{
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
		/// Binding for glVertex3bOES.
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
		/// Binding for glVertex3bvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void Vertex3OES(sbyte[] coords)
		{
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
		/// Binding for glVertex4bOES.
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
		/// Binding for glVertex4bvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_byte_coordinates")]
		public static void Vertex4OES(sbyte[] coords)
		{
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

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoord1bOES", ExactSpelling = true)]
			internal extern static void glMultiTexCoord1bOES(Int32 texture, sbyte s);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoord1bvOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord1bvOES(Int32 texture, sbyte* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoord2bOES", ExactSpelling = true)]
			internal extern static void glMultiTexCoord2bOES(Int32 texture, sbyte s, sbyte t);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoord2bvOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord2bvOES(Int32 texture, sbyte* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoord3bOES", ExactSpelling = true)]
			internal extern static void glMultiTexCoord3bOES(Int32 texture, sbyte s, sbyte t, sbyte r);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoord3bvOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord3bvOES(Int32 texture, sbyte* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoord4bOES", ExactSpelling = true)]
			internal extern static void glMultiTexCoord4bOES(Int32 texture, sbyte s, sbyte t, sbyte r, sbyte q);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoord4bvOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord4bvOES(Int32 texture, sbyte* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord1bOES", ExactSpelling = true)]
			internal extern static void glTexCoord1bOES(sbyte s);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord1bvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord1bvOES(sbyte* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2bOES", ExactSpelling = true)]
			internal extern static void glTexCoord2bOES(sbyte s, sbyte t);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2bvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2bvOES(sbyte* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord3bOES", ExactSpelling = true)]
			internal extern static void glTexCoord3bOES(sbyte s, sbyte t, sbyte r);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord3bvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord3bvOES(sbyte* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4bOES", ExactSpelling = true)]
			internal extern static void glTexCoord4bOES(sbyte s, sbyte t, sbyte r, sbyte q);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4bvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4bvOES(sbyte* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex2bOES", ExactSpelling = true)]
			internal extern static void glVertex2bOES(sbyte x, sbyte y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex2bvOES", ExactSpelling = true)]
			internal extern static unsafe void glVertex2bvOES(sbyte* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex3bOES", ExactSpelling = true)]
			internal extern static void glVertex3bOES(sbyte x, sbyte y, sbyte z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex3bvOES", ExactSpelling = true)]
			internal extern static unsafe void glVertex3bvOES(sbyte* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex4bOES", ExactSpelling = true)]
			internal extern static void glVertex4bOES(sbyte x, sbyte y, sbyte z, sbyte w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex4bvOES", ExactSpelling = true)]
			internal extern static unsafe void glVertex4bvOES(sbyte* coords);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord1bOES(Int32 texture, sbyte s);

			[ThreadStatic]
			internal static glMultiTexCoord1bOES pglMultiTexCoord1bOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord1bvOES(Int32 texture, sbyte* coords);

			[ThreadStatic]
			internal static glMultiTexCoord1bvOES pglMultiTexCoord1bvOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord2bOES(Int32 texture, sbyte s, sbyte t);

			[ThreadStatic]
			internal static glMultiTexCoord2bOES pglMultiTexCoord2bOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord2bvOES(Int32 texture, sbyte* coords);

			[ThreadStatic]
			internal static glMultiTexCoord2bvOES pglMultiTexCoord2bvOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord3bOES(Int32 texture, sbyte s, sbyte t, sbyte r);

			[ThreadStatic]
			internal static glMultiTexCoord3bOES pglMultiTexCoord3bOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord3bvOES(Int32 texture, sbyte* coords);

			[ThreadStatic]
			internal static glMultiTexCoord3bvOES pglMultiTexCoord3bvOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord4bOES(Int32 texture, sbyte s, sbyte t, sbyte r, sbyte q);

			[ThreadStatic]
			internal static glMultiTexCoord4bOES pglMultiTexCoord4bOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord4bvOES(Int32 texture, sbyte* coords);

			[ThreadStatic]
			internal static glMultiTexCoord4bvOES pglMultiTexCoord4bvOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord1bOES(sbyte s);

			[ThreadStatic]
			internal static glTexCoord1bOES pglTexCoord1bOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord1bvOES(sbyte* coords);

			[ThreadStatic]
			internal static glTexCoord1bvOES pglTexCoord1bvOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2bOES(sbyte s, sbyte t);

			[ThreadStatic]
			internal static glTexCoord2bOES pglTexCoord2bOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2bvOES(sbyte* coords);

			[ThreadStatic]
			internal static glTexCoord2bvOES pglTexCoord2bvOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord3bOES(sbyte s, sbyte t, sbyte r);

			[ThreadStatic]
			internal static glTexCoord3bOES pglTexCoord3bOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord3bvOES(sbyte* coords);

			[ThreadStatic]
			internal static glTexCoord3bvOES pglTexCoord3bvOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord4bOES(sbyte s, sbyte t, sbyte r, sbyte q);

			[ThreadStatic]
			internal static glTexCoord4bOES pglTexCoord4bOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord4bvOES(sbyte* coords);

			[ThreadStatic]
			internal static glTexCoord4bvOES pglTexCoord4bvOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex2bOES(sbyte x, sbyte y);

			[ThreadStatic]
			internal static glVertex2bOES pglVertex2bOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex2bvOES(sbyte* coords);

			[ThreadStatic]
			internal static glVertex2bvOES pglVertex2bvOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex3bOES(sbyte x, sbyte y, sbyte z);

			[ThreadStatic]
			internal static glVertex3bOES pglVertex3bOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex3bvOES(sbyte* coords);

			[ThreadStatic]
			internal static glVertex3bvOES pglVertex3bvOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex4bOES(sbyte x, sbyte y, sbyte z, sbyte w);

			[ThreadStatic]
			internal static glVertex4bOES pglVertex4bOES;

			[RequiredByFeature("GL_OES_byte_coordinates")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex4bvOES(sbyte* coords);

			[ThreadStatic]
			internal static glVertex4bvOES pglVertex4bvOES;

		}
	}

}
