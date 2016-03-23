
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
		/// Value of GL_IMAGE_SCALE_X_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int IMAGE_SCALE_X_HP = 0x8155;

		/// <summary>
		/// Value of GL_IMAGE_SCALE_Y_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int IMAGE_SCALE_Y_HP = 0x8156;

		/// <summary>
		/// Value of GL_IMAGE_TRANSLATE_X_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int IMAGE_TRANSLATE_X_HP = 0x8157;

		/// <summary>
		/// Value of GL_IMAGE_TRANSLATE_Y_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int IMAGE_TRANSLATE_Y_HP = 0x8158;

		/// <summary>
		/// Value of GL_IMAGE_ROTATE_ANGLE_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int IMAGE_ROTATE_ANGLE_HP = 0x8159;

		/// <summary>
		/// Value of GL_IMAGE_ROTATE_ORIGIN_X_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int IMAGE_ROTATE_ORIGIN_X_HP = 0x815A;

		/// <summary>
		/// Value of GL_IMAGE_ROTATE_ORIGIN_Y_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int IMAGE_ROTATE_ORIGIN_Y_HP = 0x815B;

		/// <summary>
		/// Value of GL_IMAGE_MAG_FILTER_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int IMAGE_MAG_FILTER_HP = 0x815C;

		/// <summary>
		/// Value of GL_IMAGE_MIN_FILTER_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int IMAGE_MIN_FILTER_HP = 0x815D;

		/// <summary>
		/// Value of GL_IMAGE_CUBIC_WEIGHT_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int IMAGE_CUBIC_WEIGHT_HP = 0x815E;

		/// <summary>
		/// Value of GL_CUBIC_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int CUBIC_HP = 0x815F;

		/// <summary>
		/// Value of GL_AVERAGE_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int AVERAGE_HP = 0x8160;

		/// <summary>
		/// Value of GL_IMAGE_TRANSFORM_2D_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int IMAGE_TRANSFORM_2D_HP = 0x8161;

		/// <summary>
		/// Value of GL_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8162;

		/// <summary>
		/// Value of GL_PROXY_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_image_transform")]
		public const int PROXY_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8163;

		/// <summary>
		/// Binding for glImageTransformParameteriHP.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_HP_image_transform")]
		public static void ImageTransformParameterHP(Int32 target, Int32 pname, Int32 param)
		{
			Debug.Assert(Delegates.pglImageTransformParameteriHP != null, "pglImageTransformParameteriHP not implemented");
			Delegates.pglImageTransformParameteriHP(target, pname, param);
			LogFunction("glImageTransformParameteriHP({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glImageTransformParameterfHP.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_HP_image_transform")]
		public static void ImageTransformParameterHP(Int32 target, Int32 pname, float param)
		{
			Debug.Assert(Delegates.pglImageTransformParameterfHP != null, "pglImageTransformParameterfHP not implemented");
			Delegates.pglImageTransformParameterfHP(target, pname, param);
			LogFunction("glImageTransformParameterfHP({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glImageTransformParameterivHP.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_HP_image_transform")]
		public static void ImageTransformParameterHP(Int32 target, Int32 pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglImageTransformParameterivHP != null, "pglImageTransformParameterivHP not implemented");
					Delegates.pglImageTransformParameterivHP(target, pname, p_params);
					LogFunction("glImageTransformParameterivHP({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glImageTransformParameterfvHP.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_HP_image_transform")]
		public static void ImageTransformParameterHP(Int32 target, Int32 pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglImageTransformParameterfvHP != null, "pglImageTransformParameterfvHP not implemented");
					Delegates.pglImageTransformParameterfvHP(target, pname, p_params);
					LogFunction("glImageTransformParameterfvHP({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetImageTransformParameterivHP.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_HP_image_transform")]
		public static void GetImageTransformParameterHP(Int32 target, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetImageTransformParameterivHP != null, "pglGetImageTransformParameterivHP not implemented");
					Delegates.pglGetImageTransformParameterivHP(target, pname, p_params);
					LogFunction("glGetImageTransformParameterivHP({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetImageTransformParameterfvHP.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_HP_image_transform")]
		public static void GetImageTransformParameterHP(Int32 target, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetImageTransformParameterfvHP != null, "pglGetImageTransformParameterfvHP not implemented");
					Delegates.pglGetImageTransformParameterfvHP(target, pname, p_params);
					LogFunction("glGetImageTransformParameterfvHP({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
