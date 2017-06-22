
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
		/// [GL] Binding for glVertex2hNV.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void Vertex2hNV(UInt16 x, UInt16 y)
		{
			Debug.Assert(Delegates.pglVertex2hNV != null, "pglVertex2hNV not implemented");
			Delegates.pglVertex2hNV(x, y);
			LogCommand("glVertex2hNV", null, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertex2hvNV.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void Vertex2hNV(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex2hvNV != null, "pglVertex2hvNV not implemented");
					Delegates.pglVertex2hvNV(p_v);
					LogCommand("glVertex2hvNV", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertex3hNV.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void Vertex3hNV(UInt16 x, UInt16 y, UInt16 z)
		{
			Debug.Assert(Delegates.pglVertex3hNV != null, "pglVertex3hNV not implemented");
			Delegates.pglVertex3hNV(x, y, z);
			LogCommand("glVertex3hNV", null, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertex3hvNV.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void Vertex3hNV(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex3hvNV != null, "pglVertex3hvNV not implemented");
					Delegates.pglVertex3hvNV(p_v);
					LogCommand("glVertex3hvNV", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertex4hNV.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void Vertex4hNV(UInt16 x, UInt16 y, UInt16 z, UInt16 w)
		{
			Debug.Assert(Delegates.pglVertex4hNV != null, "pglVertex4hNV not implemented");
			Delegates.pglVertex4hNV(x, y, z, w);
			LogCommand("glVertex4hNV", null, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertex4hvNV.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void Vertex4hNV(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex4hvNV != null, "pglVertex4hvNV not implemented");
					Delegates.pglVertex4hvNV(p_v);
					LogCommand("glVertex4hvNV", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glNormal3hNV.
		/// </summary>
		/// <param name="nx">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void Normal3hNV(UInt16 nx, UInt16 ny, UInt16 nz)
		{
			Debug.Assert(Delegates.pglNormal3hNV != null, "pglNormal3hNV not implemented");
			Delegates.pglNormal3hNV(nx, ny, nz);
			LogCommand("glNormal3hNV", null, nx, ny, nz			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glNormal3hvNV.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void Normal3hNV(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglNormal3hvNV != null, "pglNormal3hvNV not implemented");
					Delegates.pglNormal3hvNV(p_v);
					LogCommand("glNormal3hvNV", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glColor3hNV.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void Color3hNV(UInt16 red, UInt16 green, UInt16 blue)
		{
			Debug.Assert(Delegates.pglColor3hNV != null, "pglColor3hNV not implemented");
			Delegates.pglColor3hNV(red, green, blue);
			LogCommand("glColor3hNV", null, red, green, blue			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glColor3hvNV.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void Color3hNV(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3hvNV != null, "pglColor3hvNV not implemented");
					Delegates.pglColor3hvNV(p_v);
					LogCommand("glColor3hvNV", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glColor4hNV.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void Color4hNV(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha)
		{
			Debug.Assert(Delegates.pglColor4hNV != null, "pglColor4hNV not implemented");
			Delegates.pglColor4hNV(red, green, blue, alpha);
			LogCommand("glColor4hNV", null, red, green, blue, alpha			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glColor4hvNV.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void Color4hNV(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4hvNV != null, "pglColor4hvNV not implemented");
					Delegates.pglColor4hvNV(p_v);
					LogCommand("glColor4hvNV", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord1hNV.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void TexCoord1hNV(UInt16 s)
		{
			Debug.Assert(Delegates.pglTexCoord1hNV != null, "pglTexCoord1hNV not implemented");
			Delegates.pglTexCoord1hNV(s);
			LogCommand("glTexCoord1hNV", null, s			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord1hvNV.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void TexCoord1hNV(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord1hvNV != null, "pglTexCoord1hvNV not implemented");
					Delegates.pglTexCoord1hvNV(p_v);
					LogCommand("glTexCoord1hvNV", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord2hNV.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void TexCoord2hNV(UInt16 s, UInt16 t)
		{
			Debug.Assert(Delegates.pglTexCoord2hNV != null, "pglTexCoord2hNV not implemented");
			Delegates.pglTexCoord2hNV(s, t);
			LogCommand("glTexCoord2hNV", null, s, t			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord2hvNV.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void TexCoord2hNV(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord2hvNV != null, "pglTexCoord2hvNV not implemented");
					Delegates.pglTexCoord2hvNV(p_v);
					LogCommand("glTexCoord2hvNV", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord3hNV.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void TexCoord3hNV(UInt16 s, UInt16 t, UInt16 r)
		{
			Debug.Assert(Delegates.pglTexCoord3hNV != null, "pglTexCoord3hNV not implemented");
			Delegates.pglTexCoord3hNV(s, t, r);
			LogCommand("glTexCoord3hNV", null, s, t, r			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord3hvNV.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void TexCoord3hNV(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord3hvNV != null, "pglTexCoord3hvNV not implemented");
					Delegates.pglTexCoord3hvNV(p_v);
					LogCommand("glTexCoord3hvNV", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord4hNV.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="q">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void TexCoord4hNV(UInt16 s, UInt16 t, UInt16 r, UInt16 q)
		{
			Debug.Assert(Delegates.pglTexCoord4hNV != null, "pglTexCoord4hNV not implemented");
			Delegates.pglTexCoord4hNV(s, t, r, q);
			LogCommand("glTexCoord4hNV", null, s, t, r, q			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord4hvNV.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void TexCoord4hNV(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord4hvNV != null, "pglTexCoord4hvNV not implemented");
					Delegates.pglTexCoord4hvNV(p_v);
					LogCommand("glTexCoord4hvNV", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMultiTexCoord1hNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void MultiTexCoord1hNV(TextureUnit target, UInt16 s)
		{
			Debug.Assert(Delegates.pglMultiTexCoord1hNV != null, "pglMultiTexCoord1hNV not implemented");
			Delegates.pglMultiTexCoord1hNV((Int32)target, s);
			LogCommand("glMultiTexCoord1hNV", null, target, s			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMultiTexCoord1hvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void MultiTexCoord1hNV(TextureUnit target, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord1hvNV != null, "pglMultiTexCoord1hvNV not implemented");
					Delegates.pglMultiTexCoord1hvNV((Int32)target, p_v);
					LogCommand("glMultiTexCoord1hvNV", null, target, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMultiTexCoord2hNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void MultiTexCoord2hNV(TextureUnit target, UInt16 s, UInt16 t)
		{
			Debug.Assert(Delegates.pglMultiTexCoord2hNV != null, "pglMultiTexCoord2hNV not implemented");
			Delegates.pglMultiTexCoord2hNV((Int32)target, s, t);
			LogCommand("glMultiTexCoord2hNV", null, target, s, t			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMultiTexCoord2hvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void MultiTexCoord2hNV(TextureUnit target, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord2hvNV != null, "pglMultiTexCoord2hvNV not implemented");
					Delegates.pglMultiTexCoord2hvNV((Int32)target, p_v);
					LogCommand("glMultiTexCoord2hvNV", null, target, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMultiTexCoord3hNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void MultiTexCoord3hNV(TextureUnit target, UInt16 s, UInt16 t, UInt16 r)
		{
			Debug.Assert(Delegates.pglMultiTexCoord3hNV != null, "pglMultiTexCoord3hNV not implemented");
			Delegates.pglMultiTexCoord3hNV((Int32)target, s, t, r);
			LogCommand("glMultiTexCoord3hNV", null, target, s, t, r			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMultiTexCoord3hvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void MultiTexCoord3hNV(TextureUnit target, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord3hvNV != null, "pglMultiTexCoord3hvNV not implemented");
					Delegates.pglMultiTexCoord3hvNV((Int32)target, p_v);
					LogCommand("glMultiTexCoord3hvNV", null, target, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMultiTexCoord4hNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="q">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void MultiTexCoord4hNV(TextureUnit target, UInt16 s, UInt16 t, UInt16 r, UInt16 q)
		{
			Debug.Assert(Delegates.pglMultiTexCoord4hNV != null, "pglMultiTexCoord4hNV not implemented");
			Delegates.pglMultiTexCoord4hNV((Int32)target, s, t, r, q);
			LogCommand("glMultiTexCoord4hNV", null, target, s, t, r, q			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMultiTexCoord4hvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void MultiTexCoord4hNV(TextureUnit target, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord4hvNV != null, "pglMultiTexCoord4hvNV not implemented");
					Delegates.pglMultiTexCoord4hvNV((Int32)target, p_v);
					LogCommand("glMultiTexCoord4hvNV", null, target, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glFogCoordhNV.
		/// </summary>
		/// <param name="fog">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void FogCoordhNV(UInt16 fog)
		{
			Debug.Assert(Delegates.pglFogCoordhNV != null, "pglFogCoordhNV not implemented");
			Delegates.pglFogCoordhNV(fog);
			LogCommand("glFogCoordhNV", null, fog			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glFogCoordhvNV.
		/// </summary>
		/// <param name="fog">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void FogCoordhNV(UInt16[] fog)
		{
			unsafe {
				fixed (UInt16* p_fog = fog)
				{
					Debug.Assert(Delegates.pglFogCoordhvNV != null, "pglFogCoordhvNV not implemented");
					Delegates.pglFogCoordhvNV(p_fog);
					LogCommand("glFogCoordhvNV", null, fog					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glSecondaryColor3hNV.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void SecondaryColor3hNV(UInt16 red, UInt16 green, UInt16 blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3hNV != null, "pglSecondaryColor3hNV not implemented");
			Delegates.pglSecondaryColor3hNV(red, green, blue);
			LogCommand("glSecondaryColor3hNV", null, red, green, blue			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glSecondaryColor3hvNV.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void SecondaryColor3hNV(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3hvNV != null, "pglSecondaryColor3hvNV not implemented");
					Delegates.pglSecondaryColor3hvNV(p_v);
					LogCommand("glSecondaryColor3hvNV", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertexWeighthNV.
		/// </summary>
		/// <param name="weight">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void VertexWeighthNV(UInt16 weight)
		{
			Debug.Assert(Delegates.pglVertexWeighthNV != null, "pglVertexWeighthNV not implemented");
			Delegates.pglVertexWeighthNV(weight);
			LogCommand("glVertexWeighthNV", null, weight			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertexWeighthvNV.
		/// </summary>
		/// <param name="weight">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void VertexWeighthNV(UInt16[] weight)
		{
			unsafe {
				fixed (UInt16* p_weight = weight)
				{
					Debug.Assert(Delegates.pglVertexWeighthvNV != null, "pglVertexWeighthvNV not implemented");
					Delegates.pglVertexWeighthvNV(p_weight);
					LogCommand("glVertexWeighthvNV", null, weight					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertexAttrib1hNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void VertexAttrib1NV(UInt32 index, UInt16 x)
		{
			Debug.Assert(Delegates.pglVertexAttrib1hNV != null, "pglVertexAttrib1hNV not implemented");
			Delegates.pglVertexAttrib1hNV(index, x);
			LogCommand("glVertexAttrib1hNV", null, index, x			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertexAttrib1hvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void VertexAttrib1hvNV(UInt32 index, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib1hvNV != null, "pglVertexAttrib1hvNV not implemented");
					Delegates.pglVertexAttrib1hvNV(index, p_v);
					LogCommand("glVertexAttrib1hvNV", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertexAttrib2hNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void VertexAttrib2NV(UInt32 index, UInt16 x, UInt16 y)
		{
			Debug.Assert(Delegates.pglVertexAttrib2hNV != null, "pglVertexAttrib2hNV not implemented");
			Delegates.pglVertexAttrib2hNV(index, x, y);
			LogCommand("glVertexAttrib2hNV", null, index, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertexAttrib2hvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void VertexAttrib2hvNV(UInt32 index, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib2hvNV != null, "pglVertexAttrib2hvNV not implemented");
					Delegates.pglVertexAttrib2hvNV(index, p_v);
					LogCommand("glVertexAttrib2hvNV", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertexAttrib3hNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void VertexAttrib3NV(UInt32 index, UInt16 x, UInt16 y, UInt16 z)
		{
			Debug.Assert(Delegates.pglVertexAttrib3hNV != null, "pglVertexAttrib3hNV not implemented");
			Delegates.pglVertexAttrib3hNV(index, x, y, z);
			LogCommand("glVertexAttrib3hNV", null, index, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertexAttrib3hvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void VertexAttrib3hvNV(UInt32 index, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib3hvNV != null, "pglVertexAttrib3hvNV not implemented");
					Delegates.pglVertexAttrib3hvNV(index, p_v);
					LogCommand("glVertexAttrib3hvNV", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertexAttrib4hNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void VertexAttrib4NV(UInt32 index, UInt16 x, UInt16 y, UInt16 z, UInt16 w)
		{
			Debug.Assert(Delegates.pglVertexAttrib4hNV != null, "pglVertexAttrib4hNV not implemented");
			Delegates.pglVertexAttrib4hNV(index, x, y, z, w);
			LogCommand("glVertexAttrib4hNV", null, index, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertexAttrib4hvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void VertexAttrib4hvNV(UInt32 index, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttrib4hvNV != null, "pglVertexAttrib4hvNV not implemented");
					Delegates.pglVertexAttrib4hvNV(index, p_v);
					LogCommand("glVertexAttrib4hvNV", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertexAttribs1hvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void VertexAttribs1hvNV(UInt32 index, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs1hvNV != null, "pglVertexAttribs1hvNV not implemented");
					Delegates.pglVertexAttribs1hvNV(index, (Int32)v.Length, p_v);
					LogCommand("glVertexAttribs1hvNV", null, index, v.Length, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertexAttribs2hvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void VertexAttribs2hvNV(UInt32 index, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs2hvNV != null, "pglVertexAttribs2hvNV not implemented");
					Delegates.pglVertexAttribs2hvNV(index, (Int32)v.Length, p_v);
					LogCommand("glVertexAttribs2hvNV", null, index, v.Length, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertexAttribs3hvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void VertexAttribs3hvNV(UInt32 index, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs3hvNV != null, "pglVertexAttribs3hvNV not implemented");
					Delegates.pglVertexAttribs3hvNV(index, (Int32)v.Length, p_v);
					LogCommand("glVertexAttribs3hvNV", null, index, v.Length, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertexAttribs4hvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void VertexAttribs4hvNV(UInt32 index, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs4hvNV != null, "pglVertexAttribs4hvNV not implemented");
					Delegates.pglVertexAttribs4hvNV(index, (Int32)v.Length, p_v);
					LogCommand("glVertexAttribs4hvNV", null, index, v.Length, v					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex2hNV", ExactSpelling = true)]
			internal extern static void glVertex2hNV(UInt16 x, UInt16 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex2hvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertex2hvNV(UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex3hNV", ExactSpelling = true)]
			internal extern static void glVertex3hNV(UInt16 x, UInt16 y, UInt16 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex3hvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertex3hvNV(UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex4hNV", ExactSpelling = true)]
			internal extern static void glVertex4hNV(UInt16 x, UInt16 y, UInt16 z, UInt16 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex4hvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertex4hvNV(UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3hNV", ExactSpelling = true)]
			internal extern static void glNormal3hNV(UInt16 nx, UInt16 ny, UInt16 nz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3hvNV", ExactSpelling = true)]
			internal extern static unsafe void glNormal3hvNV(UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3hNV", ExactSpelling = true)]
			internal extern static void glColor3hNV(UInt16 red, UInt16 green, UInt16 blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3hvNV", ExactSpelling = true)]
			internal extern static unsafe void glColor3hvNV(UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4hNV", ExactSpelling = true)]
			internal extern static void glColor4hNV(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4hvNV", ExactSpelling = true)]
			internal extern static unsafe void glColor4hvNV(UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord1hNV", ExactSpelling = true)]
			internal extern static void glTexCoord1hNV(UInt16 s);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord1hvNV", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord1hvNV(UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2hNV", ExactSpelling = true)]
			internal extern static void glTexCoord2hNV(UInt16 s, UInt16 t);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2hvNV", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2hvNV(UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord3hNV", ExactSpelling = true)]
			internal extern static void glTexCoord3hNV(UInt16 s, UInt16 t, UInt16 r);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord3hvNV", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord3hvNV(UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4hNV", ExactSpelling = true)]
			internal extern static void glTexCoord4hNV(UInt16 s, UInt16 t, UInt16 r, UInt16 q);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4hvNV", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4hvNV(UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoord1hNV", ExactSpelling = true)]
			internal extern static void glMultiTexCoord1hNV(Int32 target, UInt16 s);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoord1hvNV", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord1hvNV(Int32 target, UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoord2hNV", ExactSpelling = true)]
			internal extern static void glMultiTexCoord2hNV(Int32 target, UInt16 s, UInt16 t);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoord2hvNV", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord2hvNV(Int32 target, UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoord3hNV", ExactSpelling = true)]
			internal extern static void glMultiTexCoord3hNV(Int32 target, UInt16 s, UInt16 t, UInt16 r);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoord3hvNV", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord3hvNV(Int32 target, UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoord4hNV", ExactSpelling = true)]
			internal extern static void glMultiTexCoord4hNV(Int32 target, UInt16 s, UInt16 t, UInt16 r, UInt16 q);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoord4hvNV", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord4hvNV(Int32 target, UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFogCoordhNV", ExactSpelling = true)]
			internal extern static void glFogCoordhNV(UInt16 fog);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFogCoordhvNV", ExactSpelling = true)]
			internal extern static unsafe void glFogCoordhvNV(UInt16* fog);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSecondaryColor3hNV", ExactSpelling = true)]
			internal extern static void glSecondaryColor3hNV(UInt16 red, UInt16 green, UInt16 blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSecondaryColor3hvNV", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3hvNV(UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexWeighthNV", ExactSpelling = true)]
			internal extern static void glVertexWeighthNV(UInt16 weight);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexWeighthvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexWeighthvNV(UInt16* weight);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttrib1hNV", ExactSpelling = true)]
			internal extern static void glVertexAttrib1hNV(UInt32 index, UInt16 x);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttrib1hvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib1hvNV(UInt32 index, UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttrib2hNV", ExactSpelling = true)]
			internal extern static void glVertexAttrib2hNV(UInt32 index, UInt16 x, UInt16 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttrib2hvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib2hvNV(UInt32 index, UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttrib3hNV", ExactSpelling = true)]
			internal extern static void glVertexAttrib3hNV(UInt32 index, UInt16 x, UInt16 y, UInt16 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttrib3hvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib3hvNV(UInt32 index, UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttrib4hNV", ExactSpelling = true)]
			internal extern static void glVertexAttrib4hNV(UInt32 index, UInt16 x, UInt16 y, UInt16 z, UInt16 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttrib4hvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttrib4hvNV(UInt32 index, UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribs1hvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs1hvNV(UInt32 index, Int32 n, UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribs2hvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs2hvNV(UInt32 index, Int32 n, UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribs3hvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs3hvNV(UInt32 index, Int32 n, UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribs4hvNV", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribs4hvNV(UInt32 index, Int32 n, UInt16* v);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex2hNV(UInt16 x, UInt16 y);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glVertex2hNV pglVertex2hNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex2hvNV(UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glVertex2hvNV pglVertex2hvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex3hNV(UInt16 x, UInt16 y, UInt16 z);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glVertex3hNV pglVertex3hNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex3hvNV(UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glVertex3hvNV pglVertex3hvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex4hNV(UInt16 x, UInt16 y, UInt16 z, UInt16 w);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glVertex4hNV pglVertex4hNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex4hvNV(UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glVertex4hvNV pglVertex4hvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormal3hNV(UInt16 nx, UInt16 ny, UInt16 nz);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glNormal3hNV pglNormal3hNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3hvNV(UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glNormal3hvNV pglNormal3hvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3hNV(UInt16 red, UInt16 green, UInt16 blue);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glColor3hNV pglColor3hNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3hvNV(UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glColor3hvNV pglColor3hvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4hNV(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glColor4hNV pglColor4hNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4hvNV(UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glColor4hvNV pglColor4hvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord1hNV(UInt16 s);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glTexCoord1hNV pglTexCoord1hNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord1hvNV(UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glTexCoord1hvNV pglTexCoord1hvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2hNV(UInt16 s, UInt16 t);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glTexCoord2hNV pglTexCoord2hNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2hvNV(UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glTexCoord2hvNV pglTexCoord2hvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord3hNV(UInt16 s, UInt16 t, UInt16 r);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glTexCoord3hNV pglTexCoord3hNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord3hvNV(UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glTexCoord3hvNV pglTexCoord3hvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord4hNV(UInt16 s, UInt16 t, UInt16 r, UInt16 q);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glTexCoord4hNV pglTexCoord4hNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord4hvNV(UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glTexCoord4hvNV pglTexCoord4hvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord1hNV(Int32 target, UInt16 s);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glMultiTexCoord1hNV pglMultiTexCoord1hNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord1hvNV(Int32 target, UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glMultiTexCoord1hvNV pglMultiTexCoord1hvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord2hNV(Int32 target, UInt16 s, UInt16 t);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glMultiTexCoord2hNV pglMultiTexCoord2hNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord2hvNV(Int32 target, UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glMultiTexCoord2hvNV pglMultiTexCoord2hvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord3hNV(Int32 target, UInt16 s, UInt16 t, UInt16 r);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glMultiTexCoord3hNV pglMultiTexCoord3hNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord3hvNV(Int32 target, UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glMultiTexCoord3hvNV pglMultiTexCoord3hvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord4hNV(Int32 target, UInt16 s, UInt16 t, UInt16 r, UInt16 q);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glMultiTexCoord4hNV pglMultiTexCoord4hNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord4hvNV(Int32 target, UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glMultiTexCoord4hvNV pglMultiTexCoord4hvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFogCoordhNV(UInt16 fog);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glFogCoordhNV pglFogCoordhNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogCoordhvNV(UInt16* fog);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glFogCoordhvNV pglFogCoordhvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3hNV(UInt16 red, UInt16 green, UInt16 blue);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glSecondaryColor3hNV pglSecondaryColor3hNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3hvNV(UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glSecondaryColor3hvNV pglSecondaryColor3hvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexWeighthNV(UInt16 weight);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glVertexWeighthNV pglVertexWeighthNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexWeighthvNV(UInt16* weight);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glVertexWeighthvNV pglVertexWeighthvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib1hNV(UInt32 index, UInt16 x);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glVertexAttrib1hNV pglVertexAttrib1hNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib1hvNV(UInt32 index, UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glVertexAttrib1hvNV pglVertexAttrib1hvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib2hNV(UInt32 index, UInt16 x, UInt16 y);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glVertexAttrib2hNV pglVertexAttrib2hNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib2hvNV(UInt32 index, UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glVertexAttrib2hvNV pglVertexAttrib2hvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib3hNV(UInt32 index, UInt16 x, UInt16 y, UInt16 z);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glVertexAttrib3hNV pglVertexAttrib3hNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib3hvNV(UInt32 index, UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glVertexAttrib3hvNV pglVertexAttrib3hvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib4hNV(UInt32 index, UInt16 x, UInt16 y, UInt16 z, UInt16 w);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glVertexAttrib4hNV pglVertexAttrib4hNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4hvNV(UInt32 index, UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glVertexAttrib4hvNV pglVertexAttrib4hvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs1hvNV(UInt32 index, Int32 n, UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glVertexAttribs1hvNV pglVertexAttribs1hvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs2hvNV(UInt32 index, Int32 n, UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glVertexAttribs2hvNV pglVertexAttribs2hvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs3hvNV(UInt32 index, Int32 n, UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glVertexAttribs3hvNV pglVertexAttribs3hvNV;

			[RequiredByFeature("GL_NV_half_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs4hvNV(UInt32 index, Int32 n, UInt16* v);

			[RequiredByFeature("GL_NV_half_float")]
			[ThreadStatic]
			internal static glVertexAttribs4hvNV pglVertexAttribs4hvNV;

		}
	}

}
