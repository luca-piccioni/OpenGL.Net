
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
		/// Value of GL_INSTRUMENT_BUFFER_POINTER_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_instruments")]
		public const int INSTRUMENT_BUFFER_POINTER_SGIX = 0x8180;

		/// <summary>
		/// Value of GL_INSTRUMENT_MEASUREMENTS_SGIX symbol.
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
			LogFunction("glGetInstrumentsSGIX() = {0}", retValue);
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
					LogFunction("glInstrumentsBufferSGIX({0}, {1})", buffer.Length, LogValue(buffer));
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
					LogFunction("glPollInstrumentsSGIX({0}) = {1}", LogValue(marker_p), retValue);
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
			LogFunction("glReadInstrumentsSGIX({0})", marker);
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
			LogFunction("glStartInstrumentsSGIX()");
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
			LogFunction("glStopInstrumentsSGIX({0})", marker);
			DebugCheckErrors(null);
		}

	}

}
