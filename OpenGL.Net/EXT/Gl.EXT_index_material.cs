
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
		/// Value of GL_INDEX_MATERIAL_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_index_material")]
		public const int INDEX_MATERIAL_EXT = 0x81B8;

		/// <summary>
		/// Value of GL_INDEX_MATERIAL_PARAMETER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_index_material")]
		public const int INDEX_MATERIAL_PARAMETER_EXT = 0x81B9;

		/// <summary>
		/// Value of GL_INDEX_MATERIAL_FACE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_index_material")]
		public const int INDEX_MATERIAL_FACE_EXT = 0x81BA;

		/// <summary>
		/// Binding for glIndexMaterialEXT.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:MaterialFace"/>.
		/// </param>
		/// <param name="mode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_index_material")]
		public static void IndexMaterialEXT(MaterialFace face, Int32 mode)
		{
			Debug.Assert(Delegates.pglIndexMaterialEXT != null, "pglIndexMaterialEXT not implemented");
			Delegates.pglIndexMaterialEXT((Int32)face, mode);
			LogFunction("glIndexMaterialEXT({0}, {1})", face, LogEnumName(mode));
			DebugCheckErrors(null);
		}

	}

}
