
// Copyright (C) 2015-2016 Luca Piccioni
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
			LogFunction("glGlobalAlphaFactorbSUN({0})", factor);
			DebugCheckErrors(null);
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
			LogFunction("glGlobalAlphaFactorsSUN({0})", factor);
			DebugCheckErrors(null);
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
			LogFunction("glGlobalAlphaFactoriSUN({0})", factor);
			DebugCheckErrors(null);
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
			LogFunction("glGlobalAlphaFactorfSUN({0})", factor);
			DebugCheckErrors(null);
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
			LogFunction("glGlobalAlphaFactordSUN({0})", factor);
			DebugCheckErrors(null);
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
			LogFunction("glGlobalAlphaFactorubSUN({0})", factor);
			DebugCheckErrors(null);
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
			LogFunction("glGlobalAlphaFactorusSUN({0})", factor);
			DebugCheckErrors(null);
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
			LogFunction("glGlobalAlphaFactoruiSUN({0})", factor);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGlobalAlphaFactorbSUN", ExactSpelling = true)]
			internal extern static void glGlobalAlphaFactorbSUN(sbyte factor);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGlobalAlphaFactorsSUN", ExactSpelling = true)]
			internal extern static void glGlobalAlphaFactorsSUN(Int16 factor);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGlobalAlphaFactoriSUN", ExactSpelling = true)]
			internal extern static void glGlobalAlphaFactoriSUN(Int32 factor);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGlobalAlphaFactorfSUN", ExactSpelling = true)]
			internal extern static void glGlobalAlphaFactorfSUN(float factor);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGlobalAlphaFactordSUN", ExactSpelling = true)]
			internal extern static void glGlobalAlphaFactordSUN(double factor);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGlobalAlphaFactorubSUN", ExactSpelling = true)]
			internal extern static void glGlobalAlphaFactorubSUN(byte factor);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGlobalAlphaFactorusSUN", ExactSpelling = true)]
			internal extern static void glGlobalAlphaFactorusSUN(UInt16 factor);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGlobalAlphaFactoruiSUN", ExactSpelling = true)]
			internal extern static void glGlobalAlphaFactoruiSUN(UInt32 factor);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGlobalAlphaFactorbSUN(sbyte factor);

			[ThreadStatic]
			internal static glGlobalAlphaFactorbSUN pglGlobalAlphaFactorbSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGlobalAlphaFactorsSUN(Int16 factor);

			[ThreadStatic]
			internal static glGlobalAlphaFactorsSUN pglGlobalAlphaFactorsSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGlobalAlphaFactoriSUN(Int32 factor);

			[ThreadStatic]
			internal static glGlobalAlphaFactoriSUN pglGlobalAlphaFactoriSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGlobalAlphaFactorfSUN(float factor);

			[ThreadStatic]
			internal static glGlobalAlphaFactorfSUN pglGlobalAlphaFactorfSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGlobalAlphaFactordSUN(double factor);

			[ThreadStatic]
			internal static glGlobalAlphaFactordSUN pglGlobalAlphaFactordSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGlobalAlphaFactorubSUN(byte factor);

			[ThreadStatic]
			internal static glGlobalAlphaFactorubSUN pglGlobalAlphaFactorubSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGlobalAlphaFactorusSUN(UInt16 factor);

			[ThreadStatic]
			internal static glGlobalAlphaFactorusSUN pglGlobalAlphaFactorusSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGlobalAlphaFactoruiSUN(UInt32 factor);

			[ThreadStatic]
			internal static glGlobalAlphaFactoruiSUN pglGlobalAlphaFactoruiSUN;

		}
	}

}
