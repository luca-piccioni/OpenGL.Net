
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
		/// Binding for glGetGraphicsResetStatusEXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
		public static Int32 GetGraphicsResetStatusEXT()
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetGraphicsResetStatusEXT != null, "pglGetGraphicsResetStatusEXT not implemented");
			retValue = Delegates.pglGetGraphicsResetStatusEXT();
			LogFunction("glGetGraphicsResetStatusEXT() = {0}", retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetnUniformfvEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
		public static void GetnUniformEXT(UInt32 program, Int32 location, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformfvEXT != null, "pglGetnUniformfvEXT not implemented");
					Delegates.pglGetnUniformfvEXT(program, location, (Int32)@params.Length, p_params);
					LogFunction("glGetnUniformfvEXT({0}, {1}, {2}, {3})", program, location, @params.Length, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnUniformivEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
		public static void GetnUniformEXT(UInt32 program, Int32 location, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformivEXT != null, "pglGetnUniformivEXT not implemented");
					Delegates.pglGetnUniformivEXT(program, location, (Int32)@params.Length, p_params);
					LogFunction("glGetnUniformivEXT({0}, {1}, {2}, {3})", program, location, @params.Length, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
