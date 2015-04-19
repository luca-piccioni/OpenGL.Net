
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
		/// Value of GL_FRAGMENT_LIGHTING_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHTING_SGIX = 0x8400;

		/// <summary>
		/// Value of GL_FRAGMENT_COLOR_MATERIAL_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_COLOR_MATERIAL_SGIX = 0x8401;

		/// <summary>
		/// Value of GL_FRAGMENT_COLOR_MATERIAL_FACE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_COLOR_MATERIAL_FACE_SGIX = 0x8402;

		/// <summary>
		/// Value of GL_FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX = 0x8403;

		/// <summary>
		/// Value of GL_MAX_FRAGMENT_LIGHTS_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int MAX_FRAGMENT_LIGHTS_SGIX = 0x8404;

		/// <summary>
		/// Value of GL_MAX_ACTIVE_LIGHTS_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int MAX_ACTIVE_LIGHTS_SGIX = 0x8405;

		/// <summary>
		/// Value of GL_CURRENT_RASTER_NORMAL_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int CURRENT_RASTER_NORMAL_SGIX = 0x8406;

		/// <summary>
		/// Value of GL_LIGHT_ENV_MODE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int LIGHT_ENV_MODE_SGIX = 0x8407;

		/// <summary>
		/// Value of GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX = 0x8408;

		/// <summary>
		/// Value of GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX = 0x8409;

		/// <summary>
		/// Value of GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX = 0x840A;

		/// <summary>
		/// Value of GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX = 0x840B;

		/// <summary>
		/// Value of GL_FRAGMENT_LIGHT0_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT0_SGIX = 0x840C;

		/// <summary>
		/// Value of GL_FRAGMENT_LIGHT1_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT1_SGIX = 0x840D;

		/// <summary>
		/// Value of GL_FRAGMENT_LIGHT2_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT2_SGIX = 0x840E;

		/// <summary>
		/// Value of GL_FRAGMENT_LIGHT3_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT3_SGIX = 0x840F;

		/// <summary>
		/// Value of GL_FRAGMENT_LIGHT4_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT4_SGIX = 0x8410;

		/// <summary>
		/// Value of GL_FRAGMENT_LIGHT5_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT5_SGIX = 0x8411;

		/// <summary>
		/// Value of GL_FRAGMENT_LIGHT6_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT6_SGIX = 0x8412;

		/// <summary>
		/// Value of GL_FRAGMENT_LIGHT7_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public const int FRAGMENT_LIGHT7_SGIX = 0x8413;

		/// <summary>
		/// Binding for glFragmentColorMaterialSGIX.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:MaterialFace"/>.
		/// </param>
		/// <param name="mode">
		/// A <see cref="T:MaterialParameter"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentColorMaterialSGIX(MaterialFace face, MaterialParameter mode)
		{
			Debug.Assert(Delegates.pglFragmentColorMaterialSGIX != null, "pglFragmentColorMaterialSGIX not implemented");
			Delegates.pglFragmentColorMaterialSGIX((Int32)face, (Int32)mode);
			CallLog("glFragmentColorMaterialSGIX({0}, {1})", face, mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFragmentLightfSGIX.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentLightSGIX(Int32 light, Int32 pname, float param)
		{
			Debug.Assert(Delegates.pglFragmentLightfSGIX != null, "pglFragmentLightfSGIX not implemented");
			Delegates.pglFragmentLightfSGIX(light, pname, param);
			CallLog("glFragmentLightfSGIX({0}, {1}, {2})", light, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFragmentLightfvSGIX.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentLightSGIX(Int32 light, Int32 pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglFragmentLightfvSGIX != null, "pglFragmentLightfvSGIX not implemented");
					Delegates.pglFragmentLightfvSGIX(light, pname, p_params);
					CallLog("glFragmentLightfvSGIX({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFragmentLightiSGIX.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentLightSGIX(Int32 light, Int32 pname, Int32 param)
		{
			Debug.Assert(Delegates.pglFragmentLightiSGIX != null, "pglFragmentLightiSGIX not implemented");
			Delegates.pglFragmentLightiSGIX(light, pname, param);
			CallLog("glFragmentLightiSGIX({0}, {1}, {2})", light, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFragmentLightivSGIX.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentLightSGIX(Int32 light, Int32 pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglFragmentLightivSGIX != null, "pglFragmentLightivSGIX not implemented");
					Delegates.pglFragmentLightivSGIX(light, pname, p_params);
					CallLog("glFragmentLightivSGIX({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFragmentLightModelfSGIX.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:FragmentLightModelParameterSGIX"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentLightModelSGIX(FragmentLightModelParameterSGIX pname, float param)
		{
			Debug.Assert(Delegates.pglFragmentLightModelfSGIX != null, "pglFragmentLightModelfSGIX not implemented");
			Delegates.pglFragmentLightModelfSGIX((Int32)pname, param);
			CallLog("glFragmentLightModelfSGIX({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFragmentLightModelfvSGIX.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:FragmentLightModelParameterSGIX"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentLightModelSGIX(FragmentLightModelParameterSGIX pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglFragmentLightModelfvSGIX != null, "pglFragmentLightModelfvSGIX not implemented");
					Delegates.pglFragmentLightModelfvSGIX((Int32)pname, p_params);
					CallLog("glFragmentLightModelfvSGIX({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFragmentLightModeliSGIX.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:FragmentLightModelParameterSGIX"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentLightModelSGIX(FragmentLightModelParameterSGIX pname, Int32 param)
		{
			Debug.Assert(Delegates.pglFragmentLightModeliSGIX != null, "pglFragmentLightModeliSGIX not implemented");
			Delegates.pglFragmentLightModeliSGIX((Int32)pname, param);
			CallLog("glFragmentLightModeliSGIX({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFragmentLightModelivSGIX.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:FragmentLightModelParameterSGIX"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentLightModelSGIX(FragmentLightModelParameterSGIX pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglFragmentLightModelivSGIX != null, "pglFragmentLightModelivSGIX not implemented");
					Delegates.pglFragmentLightModelivSGIX((Int32)pname, p_params);
					CallLog("glFragmentLightModelivSGIX({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFragmentMaterialfSGIX.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:MaterialFace"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:MaterialParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentMaterialSGIX(MaterialFace face, MaterialParameter pname, float param)
		{
			Debug.Assert(Delegates.pglFragmentMaterialfSGIX != null, "pglFragmentMaterialfSGIX not implemented");
			Delegates.pglFragmentMaterialfSGIX((Int32)face, (Int32)pname, param);
			CallLog("glFragmentMaterialfSGIX({0}, {1}, {2})", face, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFragmentMaterialfvSGIX.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:MaterialFace"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:MaterialParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentMaterialSGIX(MaterialFace face, MaterialParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglFragmentMaterialfvSGIX != null, "pglFragmentMaterialfvSGIX not implemented");
					Delegates.pglFragmentMaterialfvSGIX((Int32)face, (Int32)pname, p_params);
					CallLog("glFragmentMaterialfvSGIX({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFragmentMaterialiSGIX.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:MaterialFace"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:MaterialParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentMaterialSGIX(MaterialFace face, MaterialParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglFragmentMaterialiSGIX != null, "pglFragmentMaterialiSGIX not implemented");
			Delegates.pglFragmentMaterialiSGIX((Int32)face, (Int32)pname, param);
			CallLog("glFragmentMaterialiSGIX({0}, {1}, {2})", face, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFragmentMaterialivSGIX.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:MaterialFace"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:MaterialParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void FragmentMaterialSGIX(MaterialFace face, MaterialParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglFragmentMaterialivSGIX != null, "pglFragmentMaterialivSGIX not implemented");
					Delegates.pglFragmentMaterialivSGIX((Int32)face, (Int32)pname, p_params);
					CallLog("glFragmentMaterialivSGIX({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetFragmentLightfvSGIX.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void GetFragmentLightSGIX(Int32 light, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFragmentLightfvSGIX != null, "pglGetFragmentLightfvSGIX not implemented");
					Delegates.pglGetFragmentLightfvSGIX(light, pname, p_params);
					CallLog("glGetFragmentLightfvSGIX({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetFragmentLightivSGIX.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void GetFragmentLightSGIX(Int32 light, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFragmentLightivSGIX != null, "pglGetFragmentLightivSGIX not implemented");
					Delegates.pglGetFragmentLightivSGIX(light, pname, p_params);
					CallLog("glGetFragmentLightivSGIX({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetFragmentMaterialfvSGIX.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:MaterialFace"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:MaterialParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void GetFragmentMaterialSGIX(MaterialFace face, MaterialParameter pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFragmentMaterialfvSGIX != null, "pglGetFragmentMaterialfvSGIX not implemented");
					Delegates.pglGetFragmentMaterialfvSGIX((Int32)face, (Int32)pname, p_params);
					CallLog("glGetFragmentMaterialfvSGIX({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetFragmentMaterialivSGIX.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:MaterialFace"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:MaterialParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void GetFragmentMaterialSGIX(MaterialFace face, MaterialParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFragmentMaterialivSGIX != null, "pglGetFragmentMaterialivSGIX not implemented");
					Delegates.pglGetFragmentMaterialivSGIX((Int32)face, (Int32)pname, p_params);
					CallLog("glGetFragmentMaterialivSGIX({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLightEnviSGIX.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:LightEnvParameterSGIX"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		public static void LightEnvSGIX(LightEnvParameterSGIX pname, Int32 param)
		{
			Debug.Assert(Delegates.pglLightEnviSGIX != null, "pglLightEnviSGIX not implemented");
			Delegates.pglLightEnviSGIX((Int32)pname, param);
			CallLog("glLightEnviSGIX({0}, {1})", pname, param);
			DebugCheckErrors();
		}

	}

}
