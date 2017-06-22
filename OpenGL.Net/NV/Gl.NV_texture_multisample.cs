
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
		/// [GL] Value of GL_TEXTURE_COVERAGE_SAMPLES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_multisample")]
		public const int TEXTURE_COVERAGE_SAMPLES_NV = 0x9045;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_COLOR_SAMPLES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_multisample")]
		public const int TEXTURE_COLOR_SAMPLES_NV = 0x9046;

		/// <summary>
		/// [GL] Binding for glTexImage2DMultisampleCoverageNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
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
		public static void TexImage2DMultisampleCoverageNV(TextureTarget target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations)
		{
			Debug.Assert(Delegates.pglTexImage2DMultisampleCoverageNV != null, "pglTexImage2DMultisampleCoverageNV not implemented");
			Delegates.pglTexImage2DMultisampleCoverageNV((Int32)target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);
			LogCommand("glTexImage2DMultisampleCoverageNV", null, target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexImage3DMultisampleCoverageNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
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
		public static void TexImage3DMultisampleCoverageNV(TextureTarget target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations)
		{
			Debug.Assert(Delegates.pglTexImage3DMultisampleCoverageNV != null, "pglTexImage3DMultisampleCoverageNV not implemented");
			Delegates.pglTexImage3DMultisampleCoverageNV((Int32)target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);
			LogCommand("glTexImage3DMultisampleCoverageNV", null, target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTextureImage2DMultisampleNV.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
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
		public static void TextureImage2DMultisampleNV(UInt32 texture, TextureTarget target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations)
		{
			Debug.Assert(Delegates.pglTextureImage2DMultisampleNV != null, "pglTextureImage2DMultisampleNV not implemented");
			Delegates.pglTextureImage2DMultisampleNV(texture, (Int32)target, samples, internalFormat, width, height, fixedSampleLocations);
			LogCommand("glTextureImage2DMultisampleNV", null, texture, target, samples, internalFormat, width, height, fixedSampleLocations			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTextureImage3DMultisampleNV.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
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
		public static void TextureImage3DMultisampleNV(UInt32 texture, TextureTarget target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations)
		{
			Debug.Assert(Delegates.pglTextureImage3DMultisampleNV != null, "pglTextureImage3DMultisampleNV not implemented");
			Delegates.pglTextureImage3DMultisampleNV(texture, (Int32)target, samples, internalFormat, width, height, depth, fixedSampleLocations);
			LogCommand("glTextureImage3DMultisampleNV", null, texture, target, samples, internalFormat, width, height, depth, fixedSampleLocations			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTextureImage2DMultisampleCoverageNV.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
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
		public static void TextureImage2DMultisampleCoverageNV(UInt32 texture, TextureTarget target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations)
		{
			Debug.Assert(Delegates.pglTextureImage2DMultisampleCoverageNV != null, "pglTextureImage2DMultisampleCoverageNV not implemented");
			Delegates.pglTextureImage2DMultisampleCoverageNV(texture, (Int32)target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);
			LogCommand("glTextureImage2DMultisampleCoverageNV", null, texture, target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTextureImage3DMultisampleCoverageNV.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
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
		public static void TextureImage3DMultisampleCoverageNV(UInt32 texture, TextureTarget target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations)
		{
			Debug.Assert(Delegates.pglTextureImage3DMultisampleCoverageNV != null, "pglTextureImage3DMultisampleCoverageNV not implemented");
			Delegates.pglTextureImage3DMultisampleCoverageNV(texture, (Int32)target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);
			LogCommand("glTextureImage3DMultisampleCoverageNV", null, texture, target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexImage2DMultisampleCoverageNV", ExactSpelling = true)]
			internal extern static void glTexImage2DMultisampleCoverageNV(Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexImage3DMultisampleCoverageNV", ExactSpelling = true)]
			internal extern static void glTexImage3DMultisampleCoverageNV(Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureImage2DMultisampleNV", ExactSpelling = true)]
			internal extern static void glTextureImage2DMultisampleNV(UInt32 texture, Int32 target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureImage3DMultisampleNV", ExactSpelling = true)]
			internal extern static void glTextureImage3DMultisampleNV(UInt32 texture, Int32 target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureImage2DMultisampleCoverageNV", ExactSpelling = true)]
			internal extern static void glTextureImage2DMultisampleCoverageNV(UInt32 texture, Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureImage3DMultisampleCoverageNV", ExactSpelling = true)]
			internal extern static void glTextureImage3DMultisampleCoverageNV(UInt32 texture, Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_texture_multisample")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexImage2DMultisampleCoverageNV(Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations);

			[RequiredByFeature("GL_NV_texture_multisample")]
			[ThreadStatic]
			internal static glTexImage2DMultisampleCoverageNV pglTexImage2DMultisampleCoverageNV;

			[RequiredByFeature("GL_NV_texture_multisample")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexImage3DMultisampleCoverageNV(Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations);

			[RequiredByFeature("GL_NV_texture_multisample")]
			[ThreadStatic]
			internal static glTexImage3DMultisampleCoverageNV pglTexImage3DMultisampleCoverageNV;

			[RequiredByFeature("GL_NV_texture_multisample")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureImage2DMultisampleNV(UInt32 texture, Int32 target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations);

			[RequiredByFeature("GL_NV_texture_multisample")]
			[ThreadStatic]
			internal static glTextureImage2DMultisampleNV pglTextureImage2DMultisampleNV;

			[RequiredByFeature("GL_NV_texture_multisample")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureImage3DMultisampleNV(UInt32 texture, Int32 target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations);

			[RequiredByFeature("GL_NV_texture_multisample")]
			[ThreadStatic]
			internal static glTextureImage3DMultisampleNV pglTextureImage3DMultisampleNV;

			[RequiredByFeature("GL_NV_texture_multisample")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureImage2DMultisampleCoverageNV(UInt32 texture, Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations);

			[RequiredByFeature("GL_NV_texture_multisample")]
			[ThreadStatic]
			internal static glTextureImage2DMultisampleCoverageNV pglTextureImage2DMultisampleCoverageNV;

			[RequiredByFeature("GL_NV_texture_multisample")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureImage3DMultisampleCoverageNV(UInt32 texture, Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations);

			[RequiredByFeature("GL_NV_texture_multisample")]
			[ThreadStatic]
			internal static glTextureImage3DMultisampleCoverageNV pglTextureImage3DMultisampleCoverageNV;

		}
	}

}
