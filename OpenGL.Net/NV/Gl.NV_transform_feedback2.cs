
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
		/// Binding for glBindTransformFeedbackNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:BufferTargetARB"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_transform_feedback2")]
		public static void BindTransformFeedbackNV(BufferTargetARB target, UInt32 id)
		{
			Debug.Assert(Delegates.pglBindTransformFeedbackNV != null, "pglBindTransformFeedbackNV not implemented");
			Delegates.pglBindTransformFeedbackNV((Int32)target, id);
			LogFunction("glBindTransformFeedbackNV({0}, {1})", target, id);
			DebugCheckErrors(null);
		}

	}

}
