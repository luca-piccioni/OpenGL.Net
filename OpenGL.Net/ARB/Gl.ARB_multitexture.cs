
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
		/// Value of GL_TEXTURE0_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int TEXTURE0_ARB = 0x84C0;

		/// <summary>
		/// Value of GL_TEXTURE1_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		[RequiredByFeature("GL_NV_register_combiners")]
		public const int TEXTURE1_ARB = 0x84C1;

		/// <summary>
		/// Value of GL_TEXTURE2_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE2_ARB = 0x84C2;

		/// <summary>
		/// Value of GL_TEXTURE3_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE3_ARB = 0x84C3;

		/// <summary>
		/// Value of GL_TEXTURE4_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE4_ARB = 0x84C4;

		/// <summary>
		/// Value of GL_TEXTURE5_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE5_ARB = 0x84C5;

		/// <summary>
		/// Value of GL_TEXTURE6_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE6_ARB = 0x84C6;

		/// <summary>
		/// Value of GL_TEXTURE7_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE7_ARB = 0x84C7;

		/// <summary>
		/// Value of GL_TEXTURE8_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE8_ARB = 0x84C8;

		/// <summary>
		/// Value of GL_TEXTURE9_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE9_ARB = 0x84C9;

		/// <summary>
		/// Value of GL_TEXTURE10_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE10_ARB = 0x84CA;

		/// <summary>
		/// Value of GL_TEXTURE11_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE11_ARB = 0x84CB;

		/// <summary>
		/// Value of GL_TEXTURE12_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE12_ARB = 0x84CC;

		/// <summary>
		/// Value of GL_TEXTURE13_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE13_ARB = 0x84CD;

		/// <summary>
		/// Value of GL_TEXTURE14_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE14_ARB = 0x84CE;

		/// <summary>
		/// Value of GL_TEXTURE15_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE15_ARB = 0x84CF;

		/// <summary>
		/// Value of GL_TEXTURE16_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE16_ARB = 0x84D0;

		/// <summary>
		/// Value of GL_TEXTURE17_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE17_ARB = 0x84D1;

		/// <summary>
		/// Value of GL_TEXTURE18_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE18_ARB = 0x84D2;

		/// <summary>
		/// Value of GL_TEXTURE19_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE19_ARB = 0x84D3;

		/// <summary>
		/// Value of GL_TEXTURE20_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE20_ARB = 0x84D4;

		/// <summary>
		/// Value of GL_TEXTURE21_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE21_ARB = 0x84D5;

		/// <summary>
		/// Value of GL_TEXTURE22_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE22_ARB = 0x84D6;

		/// <summary>
		/// Value of GL_TEXTURE23_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE23_ARB = 0x84D7;

		/// <summary>
		/// Value of GL_TEXTURE24_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE24_ARB = 0x84D8;

		/// <summary>
		/// Value of GL_TEXTURE25_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE25_ARB = 0x84D9;

		/// <summary>
		/// Value of GL_TEXTURE26_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE26_ARB = 0x84DA;

		/// <summary>
		/// Value of GL_TEXTURE27_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE27_ARB = 0x84DB;

		/// <summary>
		/// Value of GL_TEXTURE28_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE28_ARB = 0x84DC;

		/// <summary>
		/// Value of GL_TEXTURE29_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE29_ARB = 0x84DD;

		/// <summary>
		/// Value of GL_TEXTURE30_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE30_ARB = 0x84DE;

		/// <summary>
		/// Value of GL_TEXTURE31_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int TEXTURE31_ARB = 0x84DF;

		/// <summary>
		/// Value of GL_ACTIVE_TEXTURE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int ACTIVE_TEXTURE_ARB = 0x84E0;

		/// <summary>
		/// Value of GL_CLIENT_ACTIVE_TEXTURE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int CLIENT_ACTIVE_TEXTURE_ARB = 0x84E1;

		/// <summary>
		/// Value of GL_MAX_TEXTURE_UNITS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_multitexture")]
		public const int MAX_TEXTURE_UNITS_ARB = 0x84E2;

		/// <summary>
		/// Binding for glActiveTextureARB.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void ActiveTextureARB(int texture)
		{
			Debug.Assert(Delegates.pglActiveTextureARB != null, "pglActiveTextureARB not implemented");
			Delegates.pglActiveTextureARB(texture);
			CallLog("glActiveTextureARB({0})", texture);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glClientActiveTextureARB.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void ClientActiveTextureARB(int texture)
		{
			Debug.Assert(Delegates.pglClientActiveTextureARB != null, "pglClientActiveTextureARB not implemented");
			Delegates.pglClientActiveTextureARB(texture);
			CallLog("glClientActiveTextureARB({0})", texture);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord1dARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord1ARB(int target, double s)
		{
			Debug.Assert(Delegates.pglMultiTexCoord1dARB != null, "pglMultiTexCoord1dARB not implemented");
			Delegates.pglMultiTexCoord1dARB(target, s);
			CallLog("glMultiTexCoord1dARB({0}, {1})", target, s);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord1dvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord1ARB(int target, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord1dvARB != null, "pglMultiTexCoord1dvARB not implemented");
					Delegates.pglMultiTexCoord1dvARB(target, p_v);
					CallLog("glMultiTexCoord1dvARB({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord1fARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord1ARB(int target, float s)
		{
			Debug.Assert(Delegates.pglMultiTexCoord1fARB != null, "pglMultiTexCoord1fARB not implemented");
			Delegates.pglMultiTexCoord1fARB(target, s);
			CallLog("glMultiTexCoord1fARB({0}, {1})", target, s);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord1fvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord1ARB(int target, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord1fvARB != null, "pglMultiTexCoord1fvARB not implemented");
					Delegates.pglMultiTexCoord1fvARB(target, p_v);
					CallLog("glMultiTexCoord1fvARB({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord1iARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord1ARB(int target, Int32 s)
		{
			Debug.Assert(Delegates.pglMultiTexCoord1iARB != null, "pglMultiTexCoord1iARB not implemented");
			Delegates.pglMultiTexCoord1iARB(target, s);
			CallLog("glMultiTexCoord1iARB({0}, {1})", target, s);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord1ivARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord1ARB(int target, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord1ivARB != null, "pglMultiTexCoord1ivARB not implemented");
					Delegates.pglMultiTexCoord1ivARB(target, p_v);
					CallLog("glMultiTexCoord1ivARB({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord1sARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord1ARB(int target, Int16 s)
		{
			Debug.Assert(Delegates.pglMultiTexCoord1sARB != null, "pglMultiTexCoord1sARB not implemented");
			Delegates.pglMultiTexCoord1sARB(target, s);
			CallLog("glMultiTexCoord1sARB({0}, {1})", target, s);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord1svARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord1ARB(int target, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord1svARB != null, "pglMultiTexCoord1svARB not implemented");
					Delegates.pglMultiTexCoord1svARB(target, p_v);
					CallLog("glMultiTexCoord1svARB({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord2dARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord2ARB(int target, double s, double t)
		{
			Debug.Assert(Delegates.pglMultiTexCoord2dARB != null, "pglMultiTexCoord2dARB not implemented");
			Delegates.pglMultiTexCoord2dARB(target, s, t);
			CallLog("glMultiTexCoord2dARB({0}, {1}, {2})", target, s, t);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord2dvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord2ARB(int target, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord2dvARB != null, "pglMultiTexCoord2dvARB not implemented");
					Delegates.pglMultiTexCoord2dvARB(target, p_v);
					CallLog("glMultiTexCoord2dvARB({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord2fARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord2ARB(int target, float s, float t)
		{
			Debug.Assert(Delegates.pglMultiTexCoord2fARB != null, "pglMultiTexCoord2fARB not implemented");
			Delegates.pglMultiTexCoord2fARB(target, s, t);
			CallLog("glMultiTexCoord2fARB({0}, {1}, {2})", target, s, t);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord2fvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord2ARB(int target, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord2fvARB != null, "pglMultiTexCoord2fvARB not implemented");
					Delegates.pglMultiTexCoord2fvARB(target, p_v);
					CallLog("glMultiTexCoord2fvARB({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord2iARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord2ARB(int target, Int32 s, Int32 t)
		{
			Debug.Assert(Delegates.pglMultiTexCoord2iARB != null, "pglMultiTexCoord2iARB not implemented");
			Delegates.pglMultiTexCoord2iARB(target, s, t);
			CallLog("glMultiTexCoord2iARB({0}, {1}, {2})", target, s, t);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord2ivARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord2ARB(int target, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord2ivARB != null, "pglMultiTexCoord2ivARB not implemented");
					Delegates.pglMultiTexCoord2ivARB(target, p_v);
					CallLog("glMultiTexCoord2ivARB({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord2sARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord2ARB(int target, Int16 s, Int16 t)
		{
			Debug.Assert(Delegates.pglMultiTexCoord2sARB != null, "pglMultiTexCoord2sARB not implemented");
			Delegates.pglMultiTexCoord2sARB(target, s, t);
			CallLog("glMultiTexCoord2sARB({0}, {1}, {2})", target, s, t);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord2svARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord2ARB(int target, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord2svARB != null, "pglMultiTexCoord2svARB not implemented");
					Delegates.pglMultiTexCoord2svARB(target, p_v);
					CallLog("glMultiTexCoord2svARB({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord3dARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord3ARB(int target, double s, double t, double r)
		{
			Debug.Assert(Delegates.pglMultiTexCoord3dARB != null, "pglMultiTexCoord3dARB not implemented");
			Delegates.pglMultiTexCoord3dARB(target, s, t, r);
			CallLog("glMultiTexCoord3dARB({0}, {1}, {2}, {3})", target, s, t, r);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord3dvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord3ARB(int target, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord3dvARB != null, "pglMultiTexCoord3dvARB not implemented");
					Delegates.pglMultiTexCoord3dvARB(target, p_v);
					CallLog("glMultiTexCoord3dvARB({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord3fARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord3ARB(int target, float s, float t, float r)
		{
			Debug.Assert(Delegates.pglMultiTexCoord3fARB != null, "pglMultiTexCoord3fARB not implemented");
			Delegates.pglMultiTexCoord3fARB(target, s, t, r);
			CallLog("glMultiTexCoord3fARB({0}, {1}, {2}, {3})", target, s, t, r);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord3fvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord3ARB(int target, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord3fvARB != null, "pglMultiTexCoord3fvARB not implemented");
					Delegates.pglMultiTexCoord3fvARB(target, p_v);
					CallLog("glMultiTexCoord3fvARB({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord3iARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord3ARB(int target, Int32 s, Int32 t, Int32 r)
		{
			Debug.Assert(Delegates.pglMultiTexCoord3iARB != null, "pglMultiTexCoord3iARB not implemented");
			Delegates.pglMultiTexCoord3iARB(target, s, t, r);
			CallLog("glMultiTexCoord3iARB({0}, {1}, {2}, {3})", target, s, t, r);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord3ivARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord3ARB(int target, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord3ivARB != null, "pglMultiTexCoord3ivARB not implemented");
					Delegates.pglMultiTexCoord3ivARB(target, p_v);
					CallLog("glMultiTexCoord3ivARB({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord3sARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord3ARB(int target, Int16 s, Int16 t, Int16 r)
		{
			Debug.Assert(Delegates.pglMultiTexCoord3sARB != null, "pglMultiTexCoord3sARB not implemented");
			Delegates.pglMultiTexCoord3sARB(target, s, t, r);
			CallLog("glMultiTexCoord3sARB({0}, {1}, {2}, {3})", target, s, t, r);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord3svARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord3ARB(int target, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord3svARB != null, "pglMultiTexCoord3svARB not implemented");
					Delegates.pglMultiTexCoord3svARB(target, p_v);
					CallLog("glMultiTexCoord3svARB({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord4dARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="q">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord4ARB(int target, double s, double t, double r, double q)
		{
			Debug.Assert(Delegates.pglMultiTexCoord4dARB != null, "pglMultiTexCoord4dARB not implemented");
			Delegates.pglMultiTexCoord4dARB(target, s, t, r, q);
			CallLog("glMultiTexCoord4dARB({0}, {1}, {2}, {3}, {4})", target, s, t, r, q);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord4dvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord4ARB(int target, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord4dvARB != null, "pglMultiTexCoord4dvARB not implemented");
					Delegates.pglMultiTexCoord4dvARB(target, p_v);
					CallLog("glMultiTexCoord4dvARB({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord4fARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="q">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord4ARB(int target, float s, float t, float r, float q)
		{
			Debug.Assert(Delegates.pglMultiTexCoord4fARB != null, "pglMultiTexCoord4fARB not implemented");
			Delegates.pglMultiTexCoord4fARB(target, s, t, r, q);
			CallLog("glMultiTexCoord4fARB({0}, {1}, {2}, {3}, {4})", target, s, t, r, q);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord4fvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord4ARB(int target, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord4fvARB != null, "pglMultiTexCoord4fvARB not implemented");
					Delegates.pglMultiTexCoord4fvARB(target, p_v);
					CallLog("glMultiTexCoord4fvARB({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord4iARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="q">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord4ARB(int target, Int32 s, Int32 t, Int32 r, Int32 q)
		{
			Debug.Assert(Delegates.pglMultiTexCoord4iARB != null, "pglMultiTexCoord4iARB not implemented");
			Delegates.pglMultiTexCoord4iARB(target, s, t, r, q);
			CallLog("glMultiTexCoord4iARB({0}, {1}, {2}, {3}, {4})", target, s, t, r, q);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord4ivARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord4ARB(int target, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord4ivARB != null, "pglMultiTexCoord4ivARB not implemented");
					Delegates.pglMultiTexCoord4ivARB(target, p_v);
					CallLog("glMultiTexCoord4ivARB({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord4sARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="q">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord4ARB(int target, Int16 s, Int16 t, Int16 r, Int16 q)
		{
			Debug.Assert(Delegates.pglMultiTexCoord4sARB != null, "pglMultiTexCoord4sARB not implemented");
			Delegates.pglMultiTexCoord4sARB(target, s, t, r, q);
			CallLog("glMultiTexCoord4sARB({0}, {1}, {2}, {3}, {4})", target, s, t, r, q);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord4svARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_multitexture")]
		public static void MultiTexCoord4ARB(int target, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglMultiTexCoord4svARB != null, "pglMultiTexCoord4svARB not implemented");
					Delegates.pglMultiTexCoord4svARB(target, p_v);
					CallLog("glMultiTexCoord4svARB({0}, {1})", target, v);
				}
			}
			DebugCheckErrors();
		}

	}

}
