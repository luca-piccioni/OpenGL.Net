
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
		/// Value of GL_SAMPLE_POSITION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int SAMPLE_POSITION_NV = 0x8E50;

		/// <summary>
		/// Value of GL_SAMPLE_MASK_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int SAMPLE_MASK_NV = 0x8E51;

		/// <summary>
		/// Value of GL_SAMPLE_MASK_VALUE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int SAMPLE_MASK_VALUE_NV = 0x8E52;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_RENDERBUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int TEXTURE_BINDING_RENDERBUFFER_NV = 0x8E53;

		/// <summary>
		/// Value of GL_TEXTURE_RENDERBUFFER_DATA_STORE_BINDING_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int TEXTURE_RENDERBUFFER_DATA_STORE_BINDING_NV = 0x8E54;

		/// <summary>
		/// Value of GL_TEXTURE_RENDERBUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int TEXTURE_RENDERBUFFER_NV = 0x8E55;

		/// <summary>
		/// Value of GL_SAMPLER_RENDERBUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int SAMPLER_RENDERBUFFER_NV = 0x8E56;

		/// <summary>
		/// Value of GL_INT_SAMPLER_RENDERBUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int INT_SAMPLER_RENDERBUFFER_NV = 0x8E57;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_RENDERBUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int UNSIGNED_INT_SAMPLER_RENDERBUFFER_NV = 0x8E58;

		/// <summary>
		/// Value of GL_MAX_SAMPLE_MASK_WORDS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public const int MAX_SAMPLE_MASK_WORDS_NV = 0x8E59;

		/// <summary>
		/// Binding for glGetMultisamplefvNV.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="val">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public static void GetMultisampleNV(int pname, UInt32 index, float[] val)
		{
			unsafe {
				fixed (float* p_val = val)
				{
					Debug.Assert(Delegates.pglGetMultisamplefvNV != null, "pglGetMultisamplefvNV not implemented");
					Delegates.pglGetMultisamplefvNV(pname, index, p_val);
					CallLog("glGetMultisamplefvNV({0}, {1}, {2})", pname, index, val);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSampleMaskIndexedNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public static void SampleMaskIndexedNV(UInt32 index, uint mask)
		{
			Debug.Assert(Delegates.pglSampleMaskIndexedNV != null, "pglSampleMaskIndexedNV not implemented");
			Delegates.pglSampleMaskIndexedNV(index, mask);
			CallLog("glSampleMaskIndexedNV({0}, {1})", index, mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexRenderbufferNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_explicit_multisample")]
		public static void TexRenderbufferNV(TextureTarget target, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglTexRenderbufferNV != null, "pglTexRenderbufferNV not implemented");
			Delegates.pglTexRenderbufferNV((int)target, renderbuffer);
			CallLog("glTexRenderbufferNV({0}, {1})", target, renderbuffer);
			DebugCheckErrors();
		}

	}

}
