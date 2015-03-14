
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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_HALF_FLOAT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_half_float")]
		public const int HALF_FLOAT_NV = 0x140B;

		/// <summary>
		/// Binding for glVertex2hNV.
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
			CallLog("glVertex2hNV({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex2hvNV.
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
					CallLog("glVertex2hvNV({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex3hNV.
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
			CallLog("glVertex3hNV({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex3hvNV.
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
					CallLog("glVertex3hvNV({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex4hNV.
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
			CallLog("glVertex4hNV({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertex4hvNV.
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
					CallLog("glVertex4hvNV({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNormal3hNV.
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
			CallLog("glNormal3hNV({0}, {1}, {2})", nx, ny, nz);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNormal3hvNV.
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
					CallLog("glNormal3hvNV({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor3hNV.
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
			CallLog("glColor3hNV({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor3hvNV.
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
					CallLog("glColor3hvNV({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor4hNV.
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
			CallLog("glColor4hNV({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor4hvNV.
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
					CallLog("glColor4hvNV({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord1hNV.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void TexCoord1hNV(UInt16 s)
		{
			Debug.Assert(Delegates.pglTexCoord1hNV != null, "pglTexCoord1hNV not implemented");
			Delegates.pglTexCoord1hNV(s);
			CallLog("glTexCoord1hNV({0})", s);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord1hvNV.
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
					CallLog("glTexCoord1hvNV({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord2hNV.
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
			CallLog("glTexCoord2hNV({0}, {1})", s, t);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord2hvNV.
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
					CallLog("glTexCoord2hvNV({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord3hNV.
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
			CallLog("glTexCoord3hNV({0}, {1}, {2})", s, t, r);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord3hvNV.
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
					CallLog("glTexCoord3hvNV({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord4hNV.
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
			CallLog("glTexCoord4hNV({0}, {1}, {2}, {3})", s, t, r, q);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexCoord4hvNV.
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
					CallLog("glTexCoord4hvNV({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord1hNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void MultiTexCoord1hNV(int target, UInt16 s)
		{
			Debug.Assert(Delegates.pglMultiTexCoord1hNV != null, "pglMultiTexCoord1hNV not implemented");
			Delegates.pglMultiTexCoord1hNV(target, s);
			CallLog("glMultiTexCoord1hNV({0}, {1})", target, s);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord1hvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void MultiTexCoord1hNV(int target, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord1hvNV != null, "pglMultiTexCoord1hvNV not implemented");
					Delegates.pglMultiTexCoord1hvNV(target, p_v);
					CallLog("glMultiTexCoord1hvNV({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord2hNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void MultiTexCoord2hNV(int target, UInt16 s, UInt16 t)
		{
			Debug.Assert(Delegates.pglMultiTexCoord2hNV != null, "pglMultiTexCoord2hNV not implemented");
			Delegates.pglMultiTexCoord2hNV(target, s, t);
			CallLog("glMultiTexCoord2hNV({0}, {1}, {2})", target, s, t);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord2hvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void MultiTexCoord2hNV(int target, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord2hvNV != null, "pglMultiTexCoord2hvNV not implemented");
					Delegates.pglMultiTexCoord2hvNV(target, p_v);
					CallLog("glMultiTexCoord2hvNV({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord3hNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
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
		public static void MultiTexCoord3hNV(int target, UInt16 s, UInt16 t, UInt16 r)
		{
			Debug.Assert(Delegates.pglMultiTexCoord3hNV != null, "pglMultiTexCoord3hNV not implemented");
			Delegates.pglMultiTexCoord3hNV(target, s, t, r);
			CallLog("glMultiTexCoord3hNV({0}, {1}, {2}, {3})", target, s, t, r);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord3hvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void MultiTexCoord3hNV(int target, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord3hvNV != null, "pglMultiTexCoord3hvNV not implemented");
					Delegates.pglMultiTexCoord3hvNV(target, p_v);
					CallLog("glMultiTexCoord3hvNV({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord4hNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
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
		public static void MultiTexCoord4hNV(int target, UInt16 s, UInt16 t, UInt16 r, UInt16 q)
		{
			Debug.Assert(Delegates.pglMultiTexCoord4hNV != null, "pglMultiTexCoord4hNV not implemented");
			Delegates.pglMultiTexCoord4hNV(target, s, t, r, q);
			CallLog("glMultiTexCoord4hNV({0}, {1}, {2}, {3}, {4})", target, s, t, r, q);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord4hvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void MultiTexCoord4hNV(int target, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord4hvNV != null, "pglMultiTexCoord4hvNV not implemented");
					Delegates.pglMultiTexCoord4hvNV(target, p_v);
					CallLog("glMultiTexCoord4hvNV({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFogCoordhNV.
		/// </summary>
		/// <param name="fog">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void FogCoordhNV(UInt16 fog)
		{
			Debug.Assert(Delegates.pglFogCoordhNV != null, "pglFogCoordhNV not implemented");
			Delegates.pglFogCoordhNV(fog);
			CallLog("glFogCoordhNV({0})", fog);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFogCoordhvNV.
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
					CallLog("glFogCoordhvNV({0})", fog);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSecondaryColor3hNV.
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
			CallLog("glSecondaryColor3hNV({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSecondaryColor3hvNV.
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
					CallLog("glSecondaryColor3hvNV({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexWeighthNV.
		/// </summary>
		/// <param name="weight">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void VertexWeighthNV(UInt16 weight)
		{
			Debug.Assert(Delegates.pglVertexWeighthNV != null, "pglVertexWeighthNV not implemented");
			Delegates.pglVertexWeighthNV(weight);
			CallLog("glVertexWeighthNV({0})", weight);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexWeighthvNV.
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
					CallLog("glVertexWeighthvNV({0})", weight);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib1hNV.
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
			CallLog("glVertexAttrib1hNV({0}, {1})", index, x);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib1hvNV.
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
					CallLog("glVertexAttrib1hvNV({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib2hNV.
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
			CallLog("glVertexAttrib2hNV({0}, {1}, {2})", index, x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib2hvNV.
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
					CallLog("glVertexAttrib2hvNV({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib3hNV.
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
			CallLog("glVertexAttrib3hNV({0}, {1}, {2}, {3})", index, x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib3hvNV.
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
					CallLog("glVertexAttrib3hvNV({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib4hNV.
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
			CallLog("glVertexAttrib4hNV({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttrib4hvNV.
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
					CallLog("glVertexAttrib4hvNV({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribs1hvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void VertexAttribs1hvNV(UInt32 index, params UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs1hvNV != null, "pglVertexAttribs1hvNV not implemented");
					Delegates.pglVertexAttribs1hvNV(index, (Int32)v.Length, p_v);
					CallLog("glVertexAttribs1hvNV({0}, {1}, {2})", index, v.Length, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribs2hvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void VertexAttribs2hvNV(UInt32 index, params UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs2hvNV != null, "pglVertexAttribs2hvNV not implemented");
					Delegates.pglVertexAttribs2hvNV(index, (Int32)v.Length, p_v);
					CallLog("glVertexAttribs2hvNV({0}, {1}, {2})", index, v.Length, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribs3hvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void VertexAttribs3hvNV(UInt32 index, params UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs3hvNV != null, "pglVertexAttribs3hvNV not implemented");
					Delegates.pglVertexAttribs3hvNV(index, (Int32)v.Length, p_v);
					CallLog("glVertexAttribs3hvNV({0}, {1}, {2})", index, v.Length, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glVertexAttribs4hvNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_half_float")]
		public static void VertexAttribs4hvNV(UInt32 index, params UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribs4hvNV != null, "pglVertexAttribs4hvNV not implemented");
					Delegates.pglVertexAttribs4hvNV(index, (Int32)v.Length, p_v);
					CallLog("glVertexAttribs4hvNV({0}, {1}, {2})", index, v.Length, v);
				}
			}
			DebugCheckErrors();
		}

	}

}
