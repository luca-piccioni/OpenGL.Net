
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
		/// [GL] Value of GL_COUNTER_TYPE_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
		public const int COUNTER_TYPE_AMD = 0x8BC0;

		/// <summary>
		/// [GL] Value of GL_COUNTER_RANGE_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
		public const int COUNTER_RANGE_AMD = 0x8BC1;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT64_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
		public const int UNSIGNED_INT64_AMD = 0x8BC2;

		/// <summary>
		/// [GL] Value of GL_PERCENTAGE_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
		public const int PERCENTAGE_AMD = 0x8BC3;

		/// <summary>
		/// [GL] Value of GL_PERFMON_RESULT_AVAILABLE_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
		public const int PERFMON_RESULT_AVAILABLE_AMD = 0x8BC4;

		/// <summary>
		/// [GL] Value of GL_PERFMON_RESULT_SIZE_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
		public const int PERFMON_RESULT_SIZE_AMD = 0x8BC5;

		/// <summary>
		/// [GL] Value of GL_PERFMON_RESULT_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
		public const int PERFMON_RESULT_AMD = 0x8BC6;

		/// <summary>
		/// Binding for glGetPerfMonitorGroupsAMD.
		/// </summary>
		/// <param name="numGroups">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="groups">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
		public static void GetPerfMonitorGroupsAMD(out Int32 numGroups, [Out] UInt32[] groups)
		{
			unsafe {
				fixed (Int32* p_numGroups = &numGroups)
				fixed (UInt32* p_groups = groups)
				{
					Debug.Assert(Delegates.pglGetPerfMonitorGroupsAMD != null, "pglGetPerfMonitorGroupsAMD not implemented");
					Delegates.pglGetPerfMonitorGroupsAMD(p_numGroups, (Int32)groups.Length, p_groups);
					LogCommand("glGetPerfMonitorGroupsAMD", null, numGroups, groups.Length, groups					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPerfMonitorCountersAMD.
		/// </summary>
		/// <param name="group">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numCounters">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="maxActiveCounters">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="counters">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
		public static void GetPerfMonitorCountersAMD(UInt32 group, out Int32 numCounters, out Int32 maxActiveCounters, [Out] UInt32[] counters)
		{
			unsafe {
				fixed (Int32* p_numCounters = &numCounters)
				fixed (Int32* p_maxActiveCounters = &maxActiveCounters)
				fixed (UInt32* p_counters = counters)
				{
					Debug.Assert(Delegates.pglGetPerfMonitorCountersAMD != null, "pglGetPerfMonitorCountersAMD not implemented");
					Delegates.pglGetPerfMonitorCountersAMD(group, p_numCounters, p_maxActiveCounters, (Int32)counters.Length, p_counters);
					LogCommand("glGetPerfMonitorCountersAMD", null, group, numCounters, maxActiveCounters, counters.Length, counters					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPerfMonitorGroupStringAMD.
		/// </summary>
		/// <param name="group">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="groupString">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
		public static void GetPerfMonitorGroupStringAMD(UInt32 group, Int32 bufSize, out Int32 length, [Out] StringBuilder groupString)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetPerfMonitorGroupStringAMD != null, "pglGetPerfMonitorGroupStringAMD not implemented");
					Delegates.pglGetPerfMonitorGroupStringAMD(group, bufSize, p_length, groupString);
					LogCommand("glGetPerfMonitorGroupStringAMD", null, group, bufSize, length, groupString					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPerfMonitorCounterStringAMD.
		/// </summary>
		/// <param name="group">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="counter">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="counterString">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
		public static void GetPerfMonitorCounterStringAMD(UInt32 group, UInt32 counter, Int32 bufSize, out Int32 length, [Out] StringBuilder counterString)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetPerfMonitorCounterStringAMD != null, "pglGetPerfMonitorCounterStringAMD not implemented");
					Delegates.pglGetPerfMonitorCounterStringAMD(group, counter, bufSize, p_length, counterString);
					LogCommand("glGetPerfMonitorCounterStringAMD", null, group, counter, bufSize, length, counterString					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPerfMonitorCounterInfoAMD.
		/// </summary>
		/// <param name="group">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="counter">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
		public static void GetPerfMonitorCounterInfoAMD(UInt32 group, UInt32 counter, Int32 pname, IntPtr data)
		{
			Debug.Assert(Delegates.pglGetPerfMonitorCounterInfoAMD != null, "pglGetPerfMonitorCounterInfoAMD not implemented");
			Delegates.pglGetPerfMonitorCounterInfoAMD(group, counter, pname, data);
			LogCommand("glGetPerfMonitorCounterInfoAMD", null, group, counter, pname, data			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPerfMonitorCounterInfoAMD.
		/// </summary>
		/// <param name="group">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="counter">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
		public static void GetPerfMonitorCounterInfoAMD(UInt32 group, UInt32 counter, Int32 pname, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				GetPerfMonitorCounterInfoAMD(group, counter, pname, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glGenPerfMonitorsAMD.
		/// </summary>
		/// <param name="monitors">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
		public static void GenPerfMonitorsAMD(UInt32[] monitors)
		{
			unsafe {
				fixed (UInt32* p_monitors = monitors)
				{
					Debug.Assert(Delegates.pglGenPerfMonitorsAMD != null, "pglGenPerfMonitorsAMD not implemented");
					Delegates.pglGenPerfMonitorsAMD((Int32)monitors.Length, p_monitors);
					LogCommand("glGenPerfMonitorsAMD", null, monitors.Length, monitors					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenPerfMonitorsAMD.
		/// </summary>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
		public static UInt32 GenPerfMonitorsAMD()
		{
			UInt32[] retValue = new UInt32[1];
			GenPerfMonitorsAMD(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// Binding for glDeletePerfMonitorsAMD.
		/// </summary>
		/// <param name="monitors">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
		public static void DeletePerfMonitorsAMD(params UInt32[] monitors)
		{
			unsafe {
				fixed (UInt32* p_monitors = monitors)
				{
					Debug.Assert(Delegates.pglDeletePerfMonitorsAMD != null, "pglDeletePerfMonitorsAMD not implemented");
					Delegates.pglDeletePerfMonitorsAMD((Int32)monitors.Length, p_monitors);
					LogCommand("glDeletePerfMonitorsAMD", null, monitors.Length, monitors					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSelectPerfMonitorCountersAMD.
		/// </summary>
		/// <param name="monitor">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="enable">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="group">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="counterList">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
		public static void SelectPerfMonitorCountersAMD(UInt32 monitor, bool enable, UInt32 group, UInt32[] counterList)
		{
			unsafe {
				fixed (UInt32* p_counterList = counterList)
				{
					Debug.Assert(Delegates.pglSelectPerfMonitorCountersAMD != null, "pglSelectPerfMonitorCountersAMD not implemented");
					Delegates.pglSelectPerfMonitorCountersAMD(monitor, enable, group, (Int32)counterList.Length, p_counterList);
					LogCommand("glSelectPerfMonitorCountersAMD", null, monitor, enable, group, counterList.Length, counterList					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBeginPerfMonitorAMD.
		/// </summary>
		/// <param name="monitor">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
		public static void BeginPerfMonitorAMD(UInt32 monitor)
		{
			Debug.Assert(Delegates.pglBeginPerfMonitorAMD != null, "pglBeginPerfMonitorAMD not implemented");
			Delegates.pglBeginPerfMonitorAMD(monitor);
			LogCommand("glBeginPerfMonitorAMD", null, monitor			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEndPerfMonitorAMD.
		/// </summary>
		/// <param name="monitor">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
		public static void EndPerfMonitorAMD(UInt32 monitor)
		{
			Debug.Assert(Delegates.pglEndPerfMonitorAMD != null, "pglEndPerfMonitorAMD not implemented");
			Delegates.pglEndPerfMonitorAMD(monitor);
			LogCommand("glEndPerfMonitorAMD", null, monitor			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPerfMonitorCounterDataAMD.
		/// </summary>
		/// <param name="monitor">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="bytesWritten">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
		public static void GetPerfMonitorCounterDataAMD(UInt32 monitor, Int32 pname, [Out] UInt32[] data, out Int32 bytesWritten)
		{
			unsafe {
				fixed (UInt32* p_data = data)
				fixed (Int32* p_bytesWritten = &bytesWritten)
				{
					Debug.Assert(Delegates.pglGetPerfMonitorCounterDataAMD != null, "pglGetPerfMonitorCounterDataAMD not implemented");
					Delegates.pglGetPerfMonitorCounterDataAMD(monitor, pname, (Int32)data.Length, p_data, p_bytesWritten);
					LogCommand("glGetPerfMonitorCounterDataAMD", null, monitor, pname, data.Length, data, bytesWritten					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetPerfMonitorGroupsAMD", ExactSpelling = true)]
			internal extern static unsafe void glGetPerfMonitorGroupsAMD(Int32* numGroups, Int32 groupsSize, UInt32* groups);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetPerfMonitorCountersAMD", ExactSpelling = true)]
			internal extern static unsafe void glGetPerfMonitorCountersAMD(UInt32 group, Int32* numCounters, Int32* maxActiveCounters, Int32 counterSize, UInt32* counters);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetPerfMonitorGroupStringAMD", ExactSpelling = true)]
			internal extern static unsafe void glGetPerfMonitorGroupStringAMD(UInt32 group, Int32 bufSize, Int32* length, String groupString);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetPerfMonitorCounterStringAMD", ExactSpelling = true)]
			internal extern static unsafe void glGetPerfMonitorCounterStringAMD(UInt32 group, UInt32 counter, Int32 bufSize, Int32* length, String counterString);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetPerfMonitorCounterInfoAMD", ExactSpelling = true)]
			internal extern static unsafe void glGetPerfMonitorCounterInfoAMD(UInt32 group, UInt32 counter, Int32 pname, IntPtr data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGenPerfMonitorsAMD", ExactSpelling = true)]
			internal extern static unsafe void glGenPerfMonitorsAMD(Int32 n, UInt32* monitors);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDeletePerfMonitorsAMD", ExactSpelling = true)]
			internal extern static unsafe void glDeletePerfMonitorsAMD(Int32 n, UInt32* monitors);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSelectPerfMonitorCountersAMD", ExactSpelling = true)]
			internal extern static unsafe void glSelectPerfMonitorCountersAMD(UInt32 monitor, bool enable, UInt32 group, Int32 numCounters, UInt32* counterList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBeginPerfMonitorAMD", ExactSpelling = true)]
			internal extern static void glBeginPerfMonitorAMD(UInt32 monitor);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEndPerfMonitorAMD", ExactSpelling = true)]
			internal extern static void glEndPerfMonitorAMD(UInt32 monitor);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetPerfMonitorCounterDataAMD", ExactSpelling = true)]
			internal extern static unsafe void glGetPerfMonitorCounterDataAMD(UInt32 monitor, Int32 pname, Int32 dataSize, UInt32* data, Int32* bytesWritten);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPerfMonitorGroupsAMD(Int32* numGroups, Int32 groupsSize, UInt32* groups);

			[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glGetPerfMonitorGroupsAMD pglGetPerfMonitorGroupsAMD;

			[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPerfMonitorCountersAMD(UInt32 group, Int32* numCounters, Int32* maxActiveCounters, Int32 counterSize, UInt32* counters);

			[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glGetPerfMonitorCountersAMD pglGetPerfMonitorCountersAMD;

			[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPerfMonitorGroupStringAMD(UInt32 group, Int32 bufSize, Int32* length, [Out] StringBuilder groupString);

			[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glGetPerfMonitorGroupStringAMD pglGetPerfMonitorGroupStringAMD;

			[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPerfMonitorCounterStringAMD(UInt32 group, UInt32 counter, Int32 bufSize, Int32* length, [Out] StringBuilder counterString);

			[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glGetPerfMonitorCounterStringAMD pglGetPerfMonitorCounterStringAMD;

			[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPerfMonitorCounterInfoAMD(UInt32 group, UInt32 counter, Int32 pname, IntPtr data);

			[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glGetPerfMonitorCounterInfoAMD pglGetPerfMonitorCounterInfoAMD;

			[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenPerfMonitorsAMD(Int32 n, UInt32* monitors);

			[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glGenPerfMonitorsAMD pglGenPerfMonitorsAMD;

			[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeletePerfMonitorsAMD(Int32 n, UInt32* monitors);

			[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glDeletePerfMonitorsAMD pglDeletePerfMonitorsAMD;

			[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSelectPerfMonitorCountersAMD(UInt32 monitor, bool enable, UInt32 group, Int32 numCounters, UInt32* counterList);

			[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glSelectPerfMonitorCountersAMD pglSelectPerfMonitorCountersAMD;

			[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBeginPerfMonitorAMD(UInt32 monitor);

			[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glBeginPerfMonitorAMD pglBeginPerfMonitorAMD;

			[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEndPerfMonitorAMD(UInt32 monitor);

			[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glEndPerfMonitorAMD pglEndPerfMonitorAMD;

			[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPerfMonitorCounterDataAMD(UInt32 monitor, Int32 pname, Int32 dataSize, UInt32* data, Int32* bytesWritten);

			[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glGetPerfMonitorCounterDataAMD pglGetPerfMonitorCounterDataAMD;

		}
	}

}
