
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
		/// [GL] Value of GL_INSTRUMENT_BUFFER_POINTER_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_instruments")]
		public const int INSTRUMENT_BUFFER_POINTER_SGIX = 0x8180;

		/// <summary>
		/// [GL] Value of GL_INSTRUMENT_MEASUREMENTS_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_instruments")]
		public const int INSTRUMENT_MEASUREMENTS_SGIX = 0x8181;

		/// <summary>
		/// Binding for glGetInstrumentsSGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_instruments")]
		public static Int32 GetInstrumentsSGIX()
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetInstrumentsSGIX != null, "pglGetInstrumentsSGIX not implemented");
			retValue = Delegates.pglGetInstrumentsSGIX();
			LogCommand("glGetInstrumentsSGIX", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glInstrumentsBufferSGIX.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_instruments")]
		public static void InstrumentsBufferSGIX(Int32[] buffer)
		{
			unsafe {
				fixed (Int32* p_buffer = buffer)
				{
					Debug.Assert(Delegates.pglInstrumentsBufferSGIX != null, "pglInstrumentsBufferSGIX not implemented");
					Delegates.pglInstrumentsBufferSGIX((Int32)buffer.Length, p_buffer);
					LogCommand("glInstrumentsBufferSGIX", null, buffer.Length, buffer					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPollInstrumentsSGIX.
		/// </summary>
		/// <param name="marker_p">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_instruments")]
		public static Int32 PollInstrumentsSGIX(Int32[] marker_p)
		{
			Int32 retValue;

			unsafe {
				fixed (Int32* p_marker_p = marker_p)
				{
					Debug.Assert(Delegates.pglPollInstrumentsSGIX != null, "pglPollInstrumentsSGIX not implemented");
					retValue = Delegates.pglPollInstrumentsSGIX(p_marker_p);
					LogCommand("glPollInstrumentsSGIX", retValue, marker_p					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glReadInstrumentsSGIX.
		/// </summary>
		/// <param name="marker">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_instruments")]
		public static void ReadInstrumentsSGIX(Int32 marker)
		{
			Debug.Assert(Delegates.pglReadInstrumentsSGIX != null, "pglReadInstrumentsSGIX not implemented");
			Delegates.pglReadInstrumentsSGIX(marker);
			LogCommand("glReadInstrumentsSGIX", null, marker			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glStartInstrumentsSGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_instruments")]
		public static void StartInstrumentsSGIX()
		{
			Debug.Assert(Delegates.pglStartInstrumentsSGIX != null, "pglStartInstrumentsSGIX not implemented");
			Delegates.pglStartInstrumentsSGIX();
			LogCommand("glStartInstrumentsSGIX", null			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glStopInstrumentsSGIX.
		/// </summary>
		/// <param name="marker">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_instruments")]
		public static void StopInstrumentsSGIX(Int32 marker)
		{
			Debug.Assert(Delegates.pglStopInstrumentsSGIX != null, "pglStopInstrumentsSGIX not implemented");
			Delegates.pglStopInstrumentsSGIX(marker);
			LogCommand("glStopInstrumentsSGIX", null, marker			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetInstrumentsSGIX", ExactSpelling = true)]
			internal extern static Int32 glGetInstrumentsSGIX();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glInstrumentsBufferSGIX", ExactSpelling = true)]
			internal extern static unsafe void glInstrumentsBufferSGIX(Int32 size, Int32* buffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPollInstrumentsSGIX", ExactSpelling = true)]
			internal extern static unsafe Int32 glPollInstrumentsSGIX(Int32* marker_p);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReadInstrumentsSGIX", ExactSpelling = true)]
			internal extern static void glReadInstrumentsSGIX(Int32 marker);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glStartInstrumentsSGIX", ExactSpelling = true)]
			internal extern static void glStartInstrumentsSGIX();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glStopInstrumentsSGIX", ExactSpelling = true)]
			internal extern static void glStopInstrumentsSGIX(Int32 marker);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_SGIX_instruments")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetInstrumentsSGIX();

			[ThreadStatic]
			internal static glGetInstrumentsSGIX pglGetInstrumentsSGIX;

			[RequiredByFeature("GL_SGIX_instruments")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glInstrumentsBufferSGIX(Int32 size, Int32* buffer);

			[ThreadStatic]
			internal static glInstrumentsBufferSGIX pglInstrumentsBufferSGIX;

			[RequiredByFeature("GL_SGIX_instruments")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate Int32 glPollInstrumentsSGIX(Int32* marker_p);

			[ThreadStatic]
			internal static glPollInstrumentsSGIX pglPollInstrumentsSGIX;

			[RequiredByFeature("GL_SGIX_instruments")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReadInstrumentsSGIX(Int32 marker);

			[ThreadStatic]
			internal static glReadInstrumentsSGIX pglReadInstrumentsSGIX;

			[RequiredByFeature("GL_SGIX_instruments")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStartInstrumentsSGIX();

			[ThreadStatic]
			internal static glStartInstrumentsSGIX pglStartInstrumentsSGIX;

			[RequiredByFeature("GL_SGIX_instruments")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStopInstrumentsSGIX(Int32 marker);

			[ThreadStatic]
			internal static glStopInstrumentsSGIX pglStopInstrumentsSGIX;

		}
	}

}
