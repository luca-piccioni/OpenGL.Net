
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
		/// Binding for glCopyTexImage1DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_copy_texture")]
		public static void CopyTexImage1DEXT(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 border)
		{
			Debug.Assert(Delegates.pglCopyTexImage1DEXT != null, "pglCopyTexImage1DEXT not implemented");
			Delegates.pglCopyTexImage1DEXT(target, level, internalformat, x, y, width, border);
			CallLog("glCopyTexImage1DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, internalformat, x, y, width, border);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCopyTexImage1DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_copy_texture")]
		public static void CopyTexImage1DEXT(TextureTarget target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 border)
		{
			Debug.Assert(Delegates.pglCopyTexImage1DEXT != null, "pglCopyTexImage1DEXT not implemented");
			Delegates.pglCopyTexImage1DEXT((int)target, level, internalformat, x, y, width, border);
			CallLog("glCopyTexImage1DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, internalformat, x, y, width, border);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCopyTexImage2DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_copy_texture")]
		public static void CopyTexImage2DEXT(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border)
		{
			Debug.Assert(Delegates.pglCopyTexImage2DEXT != null, "pglCopyTexImage2DEXT not implemented");
			Delegates.pglCopyTexImage2DEXT(target, level, internalformat, x, y, width, height, border);
			CallLog("glCopyTexImage2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, internalformat, x, y, width, height, border);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCopyTexImage2DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="border">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_copy_texture")]
		public static void CopyTexImage2DEXT(TextureTarget target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border)
		{
			Debug.Assert(Delegates.pglCopyTexImage2DEXT != null, "pglCopyTexImage2DEXT not implemented");
			Delegates.pglCopyTexImage2DEXT((int)target, level, internalformat, x, y, width, height, border);
			CallLog("glCopyTexImage2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, internalformat, x, y, width, height, border);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCopyTexSubImage1DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_copy_texture")]
		public static void CopyTexSubImage1DEXT(int target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width)
		{
			Debug.Assert(Delegates.pglCopyTexSubImage1DEXT != null, "pglCopyTexSubImage1DEXT not implemented");
			Delegates.pglCopyTexSubImage1DEXT(target, level, xoffset, x, y, width);
			CallLog("glCopyTexSubImage1DEXT({0}, {1}, {2}, {3}, {4}, {5})", target, level, xoffset, x, y, width);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCopyTexSubImage1DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_copy_texture")]
		public static void CopyTexSubImage1DEXT(TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width)
		{
			Debug.Assert(Delegates.pglCopyTexSubImage1DEXT != null, "pglCopyTexSubImage1DEXT not implemented");
			Delegates.pglCopyTexSubImage1DEXT((int)target, level, xoffset, x, y, width);
			CallLog("glCopyTexSubImage1DEXT({0}, {1}, {2}, {3}, {4}, {5})", target, level, xoffset, x, y, width);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCopyTexSubImage2DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_copy_texture")]
		public static void CopyTexSubImage2DEXT(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglCopyTexSubImage2DEXT != null, "pglCopyTexSubImage2DEXT not implemented");
			Delegates.pglCopyTexSubImage2DEXT(target, level, xoffset, yoffset, x, y, width, height);
			CallLog("glCopyTexSubImage2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, xoffset, yoffset, x, y, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCopyTexSubImage2DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_copy_texture")]
		public static void CopyTexSubImage2DEXT(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglCopyTexSubImage2DEXT != null, "pglCopyTexSubImage2DEXT not implemented");
			Delegates.pglCopyTexSubImage2DEXT((int)target, level, xoffset, yoffset, x, y, width, height);
			CallLog("glCopyTexSubImage2DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, xoffset, yoffset, x, y, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCopyTexSubImage3DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_copy_texture")]
		public static void CopyTexSubImage3DEXT(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglCopyTexSubImage3DEXT != null, "pglCopyTexSubImage3DEXT not implemented");
			Delegates.pglCopyTexSubImage3DEXT(target, level, xoffset, yoffset, zoffset, x, y, width, height);
			CallLog("glCopyTexSubImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, zoffset, x, y, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCopyTexSubImage3DEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_copy_texture")]
		public static void CopyTexSubImage3DEXT(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglCopyTexSubImage3DEXT != null, "pglCopyTexSubImage3DEXT not implemented");
			Delegates.pglCopyTexSubImage3DEXT((int)target, level, xoffset, yoffset, zoffset, x, y, width, height);
			CallLog("glCopyTexSubImage3DEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, zoffset, x, y, width, height);
			DebugCheckErrors();
		}

	}

}
