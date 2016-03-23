
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
		/// Value of GL_TEXTURE_COVERAGE_SAMPLES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_multisample")]
		public const int TEXTURE_COVERAGE_SAMPLES_NV = 0x9045;

		/// <summary>
		/// Value of GL_TEXTURE_COLOR_SAMPLES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_multisample")]
		public const int TEXTURE_COLOR_SAMPLES_NV = 0x9046;

		/// <summary>
		/// Binding for glTexImage2DMultisampleCoverageNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coverageSamples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="colorSamples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalFormat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fixedSampleLocations">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_NV_texture_multisample")]
		public static void TexImage2DMultisampleCoverageNV(Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations)
		{
			Debug.Assert(Delegates.pglTexImage2DMultisampleCoverageNV != null, "pglTexImage2DMultisampleCoverageNV not implemented");
			Delegates.pglTexImage2DMultisampleCoverageNV(target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);
			LogFunction("glTexImage2DMultisampleCoverageNV({0}, {1}, {2}, {3}, {4}, {5}, {6})", LogEnumName(target), coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexImage3DMultisampleCoverageNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coverageSamples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="colorSamples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalFormat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fixedSampleLocations">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_NV_texture_multisample")]
		public static void TexImage3DMultisampleCoverageNV(Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations)
		{
			Debug.Assert(Delegates.pglTexImage3DMultisampleCoverageNV != null, "pglTexImage3DMultisampleCoverageNV not implemented");
			Delegates.pglTexImage3DMultisampleCoverageNV(target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);
			LogFunction("glTexImage3DMultisampleCoverageNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", LogEnumName(target), coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureImage2DMultisampleNV.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalFormat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fixedSampleLocations">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_NV_texture_multisample")]
		public static void TextureImage2DMultisampleNV(UInt32 texture, Int32 target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations)
		{
			Debug.Assert(Delegates.pglTextureImage2DMultisampleNV != null, "pglTextureImage2DMultisampleNV not implemented");
			Delegates.pglTextureImage2DMultisampleNV(texture, target, samples, internalFormat, width, height, fixedSampleLocations);
			LogFunction("glTextureImage2DMultisampleNV({0}, {1}, {2}, {3}, {4}, {5}, {6})", texture, LogEnumName(target), samples, internalFormat, width, height, fixedSampleLocations);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureImage3DMultisampleNV.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalFormat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fixedSampleLocations">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_NV_texture_multisample")]
		public static void TextureImage3DMultisampleNV(UInt32 texture, Int32 target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations)
		{
			Debug.Assert(Delegates.pglTextureImage3DMultisampleNV != null, "pglTextureImage3DMultisampleNV not implemented");
			Delegates.pglTextureImage3DMultisampleNV(texture, target, samples, internalFormat, width, height, depth, fixedSampleLocations);
			LogFunction("glTextureImage3DMultisampleNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", texture, LogEnumName(target), samples, internalFormat, width, height, depth, fixedSampleLocations);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureImage2DMultisampleCoverageNV.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coverageSamples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="colorSamples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalFormat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fixedSampleLocations">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_NV_texture_multisample")]
		public static void TextureImage2DMultisampleCoverageNV(UInt32 texture, Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations)
		{
			Debug.Assert(Delegates.pglTextureImage2DMultisampleCoverageNV != null, "pglTextureImage2DMultisampleCoverageNV not implemented");
			Delegates.pglTextureImage2DMultisampleCoverageNV(texture, target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);
			LogFunction("glTextureImage2DMultisampleCoverageNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", texture, LogEnumName(target), coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureImage3DMultisampleCoverageNV.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coverageSamples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="colorSamples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalFormat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="fixedSampleLocations">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_NV_texture_multisample")]
		public static void TextureImage3DMultisampleCoverageNV(UInt32 texture, Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations)
		{
			Debug.Assert(Delegates.pglTextureImage3DMultisampleCoverageNV != null, "pglTextureImage3DMultisampleCoverageNV not implemented");
			Delegates.pglTextureImage3DMultisampleCoverageNV(texture, target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);
			LogFunction("glTextureImage3DMultisampleCoverageNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", texture, LogEnumName(target), coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);
			DebugCheckErrors(null);
		}

	}

}
