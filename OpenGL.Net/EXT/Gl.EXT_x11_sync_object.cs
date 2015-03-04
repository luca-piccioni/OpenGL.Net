
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
		/// Value of GL_SYNC_X11_FENCE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_x11_sync_object")]
		public const int SYNC_X11_FENCE_EXT = 0x90E1;

		/// <summary>
		/// Binding for glImportSyncEXT.
		/// </summary>
		/// <param name="external_sync_type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="external_sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="flags">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_x11_sync_object")]
		public static int ImportSyncEXT(int external_sync_type, IntPtr external_sync, uint flags)
		{
			int retValue;

			Debug.Assert(Delegates.pglImportSyncEXT != null, "pglImportSyncEXT not implemented");
			retValue = Delegates.pglImportSyncEXT(external_sync_type, external_sync, flags);
			CallLog("glImportSyncEXT({0}, {1}, {2}) = {3}", external_sync_type, external_sync, flags, retValue);
			DebugCheckErrors();

			return (retValue);
		}

	}

}
