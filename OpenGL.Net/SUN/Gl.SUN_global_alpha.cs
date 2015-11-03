
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

#pragma warning disable 1734

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_GLOBAL_ALPHA_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_global_alpha")]
		public const int GLOBAL_ALPHA_SUN = 0x81D9;

		/// <summary>
		/// Value of GL_GLOBAL_ALPHA_FACTOR_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_global_alpha")]
		public const int GLOBAL_ALPHA_FACTOR_SUN = 0x81DA;

		/// <summary>
		/// Binding for glGlobalAlphaFactorbSUN.
		/// </summary>
		/// <param name="factor">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_global_alpha")]
		public static void GlobalAlphaFactorSUN(sbyte factor)
		{
			Debug.Assert(Delegates.pglGlobalAlphaFactorbSUN != null, "pglGlobalAlphaFactorbSUN not implemented");
			Delegates.pglGlobalAlphaFactorbSUN(factor);
			CallLog("glGlobalAlphaFactorbSUN({0})", factor);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGlobalAlphaFactorsSUN.
		/// </summary>
		/// <param name="factor">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_global_alpha")]
		public static void GlobalAlphaFactorSUN(Int16 factor)
		{
			Debug.Assert(Delegates.pglGlobalAlphaFactorsSUN != null, "pglGlobalAlphaFactorsSUN not implemented");
			Delegates.pglGlobalAlphaFactorsSUN(factor);
			CallLog("glGlobalAlphaFactorsSUN({0})", factor);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGlobalAlphaFactoriSUN.
		/// </summary>
		/// <param name="factor">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_global_alpha")]
		public static void GlobalAlphaFactorSUN(Int32 factor)
		{
			Debug.Assert(Delegates.pglGlobalAlphaFactoriSUN != null, "pglGlobalAlphaFactoriSUN not implemented");
			Delegates.pglGlobalAlphaFactoriSUN(factor);
			CallLog("glGlobalAlphaFactoriSUN({0})", factor);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGlobalAlphaFactorfSUN.
		/// </summary>
		/// <param name="factor">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_global_alpha")]
		public static void GlobalAlphaFactorSUN(float factor)
		{
			Debug.Assert(Delegates.pglGlobalAlphaFactorfSUN != null, "pglGlobalAlphaFactorfSUN not implemented");
			Delegates.pglGlobalAlphaFactorfSUN(factor);
			CallLog("glGlobalAlphaFactorfSUN({0})", factor);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGlobalAlphaFactordSUN.
		/// </summary>
		/// <param name="factor">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_global_alpha")]
		public static void GlobalAlphaFactorSUN(double factor)
		{
			Debug.Assert(Delegates.pglGlobalAlphaFactordSUN != null, "pglGlobalAlphaFactordSUN not implemented");
			Delegates.pglGlobalAlphaFactordSUN(factor);
			CallLog("glGlobalAlphaFactordSUN({0})", factor);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGlobalAlphaFactorubSUN.
		/// </summary>
		/// <param name="factor">
		/// A <see cref="T:byte"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_global_alpha")]
		public static void GlobalAlphaFactorubSUN(byte factor)
		{
			Debug.Assert(Delegates.pglGlobalAlphaFactorubSUN != null, "pglGlobalAlphaFactorubSUN not implemented");
			Delegates.pglGlobalAlphaFactorubSUN(factor);
			CallLog("glGlobalAlphaFactorubSUN({0})", factor);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGlobalAlphaFactorusSUN.
		/// </summary>
		/// <param name="factor">
		/// A <see cref="T:UInt16"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_global_alpha")]
		public static void GlobalAlphaFactorusSUN(UInt16 factor)
		{
			Debug.Assert(Delegates.pglGlobalAlphaFactorusSUN != null, "pglGlobalAlphaFactorusSUN not implemented");
			Delegates.pglGlobalAlphaFactorusSUN(factor);
			CallLog("glGlobalAlphaFactorusSUN({0})", factor);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGlobalAlphaFactoruiSUN.
		/// </summary>
		/// <param name="factor">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_global_alpha")]
		public static void GlobalAlphaFactoruiSUN(UInt32 factor)
		{
			Debug.Assert(Delegates.pglGlobalAlphaFactoruiSUN != null, "pglGlobalAlphaFactoruiSUN not implemented");
			Delegates.pglGlobalAlphaFactoruiSUN(factor);
			CallLog("glGlobalAlphaFactoruiSUN({0})", factor);
			DebugCheckErrors();
		}

	}

}
