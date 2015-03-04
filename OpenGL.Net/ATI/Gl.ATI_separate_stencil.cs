
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
		/// Value of GL_STENCIL_BACK_FUNC_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_separate_stencil")]
		public const int STENCIL_BACK_FUNC_ATI = 0x8800;

		/// <summary>
		/// Value of GL_STENCIL_BACK_FAIL_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_separate_stencil")]
		public const int STENCIL_BACK_FAIL_ATI = 0x8801;

		/// <summary>
		/// Value of GL_STENCIL_BACK_PASS_DEPTH_FAIL_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_separate_stencil")]
		public const int STENCIL_BACK_PASS_DEPTH_FAIL_ATI = 0x8802;

		/// <summary>
		/// Value of GL_STENCIL_BACK_PASS_DEPTH_PASS_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_separate_stencil")]
		public const int STENCIL_BACK_PASS_DEPTH_PASS_ATI = 0x8803;

		/// <summary>
		/// Binding for glStencilOpSeparateATI.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="sfail">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dpfail">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dppass">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_separate_stencil")]
		public static void StencilOpSeparateATI(int face, int sfail, int dpfail, int dppass)
		{
			Debug.Assert(Delegates.pglStencilOpSeparateATI != null, "pglStencilOpSeparateATI not implemented");
			Delegates.pglStencilOpSeparateATI(face, sfail, dpfail, dppass);
			CallLog("glStencilOpSeparateATI({0}, {1}, {2}, {3})", face, sfail, dpfail, dppass);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glStencilOpSeparateATI.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="sfail">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dpfail">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dppass">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_separate_stencil")]
		public static void StencilOpSeparateATI(int face, StencilOp sfail, StencilOp dpfail, StencilOp dppass)
		{
			Debug.Assert(Delegates.pglStencilOpSeparateATI != null, "pglStencilOpSeparateATI not implemented");
			Delegates.pglStencilOpSeparateATI(face, (int)sfail, (int)dpfail, (int)dppass);
			CallLog("glStencilOpSeparateATI({0}, {1}, {2}, {3})", face, sfail, dpfail, dppass);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glStencilFuncSeparateATI.
		/// </summary>
		/// <param name="frontfunc">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="backfunc">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_separate_stencil")]
		public static void StencilFuncSeparateATI(int frontfunc, int backfunc, Int32 @ref, UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilFuncSeparateATI != null, "pglStencilFuncSeparateATI not implemented");
			Delegates.pglStencilFuncSeparateATI(frontfunc, backfunc, @ref, mask);
			CallLog("glStencilFuncSeparateATI({0}, {1}, {2}, {3})", frontfunc, backfunc, @ref, mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glStencilFuncSeparateATI.
		/// </summary>
		/// <param name="frontfunc">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="backfunc">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_separate_stencil")]
		public static void StencilFuncSeparateATI(StencilFunction frontfunc, StencilFunction backfunc, Int32 @ref, UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilFuncSeparateATI != null, "pglStencilFuncSeparateATI not implemented");
			Delegates.pglStencilFuncSeparateATI((int)frontfunc, (int)backfunc, @ref, mask);
			CallLog("glStencilFuncSeparateATI({0}, {1}, {2}, {3})", frontfunc, backfunc, @ref, mask);
			DebugCheckErrors();
		}

	}

}
