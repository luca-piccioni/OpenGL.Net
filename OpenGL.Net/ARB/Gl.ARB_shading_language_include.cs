
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
		/// [GL] Value of GL_SHADER_INCLUDE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shading_language_include", Api = "gl|glcore")]
		public const int SHADER_INCLUDE_ARB = 0x8DAE;

		/// <summary>
		/// [GL] Value of GL_NAMED_STRING_LENGTH_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shading_language_include", Api = "gl|glcore")]
		public const int NAMED_STRING_LENGTH_ARB = 0x8DE9;

		/// <summary>
		/// [GL] Value of GL_NAMED_STRING_TYPE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_shading_language_include", Api = "gl|glcore")]
		public const int NAMED_STRING_TYPE_ARB = 0x8DEA;

		/// <summary>
		/// Binding for glNamedStringARB.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="namelen">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:String"/>.
		/// </param>
		/// <param name="stringlen">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_shading_language_include", Api = "gl|glcore")]
		public static void NamedStringARB(Int32 type, Int32 namelen, String name, Int32 stringlen, String @string)
		{
			Debug.Assert(Delegates.pglNamedStringARB != null, "pglNamedStringARB not implemented");
			Delegates.pglNamedStringARB(type, namelen, name, stringlen, @string);
			LogCommand("glNamedStringARB", null, type, namelen, name, stringlen, @string			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDeleteNamedStringARB.
		/// </summary>
		/// <param name="namelen">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_shading_language_include", Api = "gl|glcore")]
		public static void DeleteNamedStringARB(Int32 namelen, String name)
		{
			Debug.Assert(Delegates.pglDeleteNamedStringARB != null, "pglDeleteNamedStringARB not implemented");
			Delegates.pglDeleteNamedStringARB(namelen, name);
			LogCommand("glDeleteNamedStringARB", null, namelen, name			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCompileShaderIncludeARB.
		/// </summary>
		/// <param name="shader">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="path">
		/// A <see cref="T:String[]"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_shading_language_include", Api = "gl|glcore")]
		public static void CompileShaderIncludeARB(UInt32 shader, String[] path, Int32[] length)
		{
			unsafe {
				fixed (Int32* p_length = length)
				{
					Debug.Assert(Delegates.pglCompileShaderIncludeARB != null, "pglCompileShaderIncludeARB not implemented");
					Delegates.pglCompileShaderIncludeARB(shader, (Int32)path.Length, path, p_length);
					LogCommand("glCompileShaderIncludeARB", null, shader, path.Length, path, length					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glIsNamedStringARB.
		/// </summary>
		/// <param name="namelen">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_shading_language_include", Api = "gl|glcore")]
		public static bool IsNamedStringARB(Int32 namelen, String name)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsNamedStringARB != null, "pglIsNamedStringARB not implemented");
			retValue = Delegates.pglIsNamedStringARB(namelen, name);
			LogCommand("glIsNamedStringARB", retValue, namelen, name			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetNamedStringARB.
		/// </summary>
		/// <param name="namelen">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:String"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stringlen">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_shading_language_include", Api = "gl|glcore")]
		public static void GetNamedStringARB(Int32 namelen, String name, Int32 bufSize, out Int32 stringlen, [Out] StringBuilder @string)
		{
			unsafe {
				fixed (Int32* p_stringlen = &stringlen)
				{
					Debug.Assert(Delegates.pglGetNamedStringARB != null, "pglGetNamedStringARB not implemented");
					Delegates.pglGetNamedStringARB(namelen, name, bufSize, p_stringlen, @string);
					LogCommand("glGetNamedStringARB", null, namelen, name, bufSize, stringlen, @string					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetNamedStringivARB.
		/// </summary>
		/// <param name="namelen">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:String"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_shading_language_include", Api = "gl|glcore")]
		public static void GetNamedStringARB(Int32 namelen, String name, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetNamedStringivARB != null, "pglGetNamedStringivARB not implemented");
					Delegates.pglGetNamedStringivARB(namelen, name, pname, p_params);
					LogCommand("glGetNamedStringivARB", null, namelen, name, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetNamedStringivARB.
		/// </summary>
		/// <param name="namelen">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:String"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_shading_language_include", Api = "gl|glcore")]
		public static void GetNamedStringARB(Int32 namelen, String name, Int32 pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetNamedStringivARB != null, "pglGetNamedStringivARB not implemented");
					Delegates.pglGetNamedStringivARB(namelen, name, pname, p_params);
					LogCommand("glGetNamedStringivARB", null, namelen, name, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedStringARB", ExactSpelling = true)]
			internal extern static void glNamedStringARB(Int32 type, Int32 namelen, String name, Int32 stringlen, String @string);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDeleteNamedStringARB", ExactSpelling = true)]
			internal extern static void glDeleteNamedStringARB(Int32 namelen, String name);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCompileShaderIncludeARB", ExactSpelling = true)]
			internal extern static unsafe void glCompileShaderIncludeARB(UInt32 shader, Int32 count, String[] path, Int32* length);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIsNamedStringARB", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsNamedStringARB(Int32 namelen, String name);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedStringARB", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedStringARB(Int32 namelen, String name, Int32 bufSize, Int32* stringlen, String @string);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedStringivARB", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedStringivARB(Int32 namelen, String name, Int32 pname, Int32* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ARB_shading_language_include", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedStringARB(Int32 type, Int32 namelen, String name, Int32 stringlen, String @string);

			[ThreadStatic]
			internal static glNamedStringARB pglNamedStringARB;

			[RequiredByFeature("GL_ARB_shading_language_include", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDeleteNamedStringARB(Int32 namelen, String name);

			[ThreadStatic]
			internal static glDeleteNamedStringARB pglDeleteNamedStringARB;

			[RequiredByFeature("GL_ARB_shading_language_include", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompileShaderIncludeARB(UInt32 shader, Int32 count, String[] path, Int32* length);

			[ThreadStatic]
			internal static glCompileShaderIncludeARB pglCompileShaderIncludeARB;

			[RequiredByFeature("GL_ARB_shading_language_include", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsNamedStringARB(Int32 namelen, String name);

			[ThreadStatic]
			internal static glIsNamedStringARB pglIsNamedStringARB;

			[RequiredByFeature("GL_ARB_shading_language_include", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedStringARB(Int32 namelen, String name, Int32 bufSize, Int32* stringlen, [Out] StringBuilder @string);

			[ThreadStatic]
			internal static glGetNamedStringARB pglGetNamedStringARB;

			[RequiredByFeature("GL_ARB_shading_language_include", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedStringivARB(Int32 namelen, String name, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetNamedStringivARB pglGetNamedStringivARB;

		}
	}

}
