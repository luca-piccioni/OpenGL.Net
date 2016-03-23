
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
		/// Value of GL_COUNTER_TYPE_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|gles2")]
		public const int COUNTER_TYPE_AMD = 0x8BC0;

		/// <summary>
		/// Value of GL_COUNTER_RANGE_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|gles2")]
		public const int COUNTER_RANGE_AMD = 0x8BC1;

		/// <summary>
		/// Value of GL_UNSIGNED_INT64_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|gles2")]
		public const int UNSIGNED_INT64_AMD = 0x8BC2;

		/// <summary>
		/// Value of GL_PERCENTAGE_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|gles2")]
		public const int PERCENTAGE_AMD = 0x8BC3;

		/// <summary>
		/// Value of GL_PERFMON_RESULT_AVAILABLE_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|gles2")]
		public const int PERFMON_RESULT_AVAILABLE_AMD = 0x8BC4;

		/// <summary>
		/// Value of GL_PERFMON_RESULT_SIZE_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|gles2")]
		public const int PERFMON_RESULT_SIZE_AMD = 0x8BC5;

		/// <summary>
		/// Value of GL_PERFMON_RESULT_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|gles2")]
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
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|gles2")]
		public static void GetPerfMonitorGroupsAMD(out Int32 numGroups, [Out] UInt32[] groups)
		{
			unsafe {
				fixed (Int32* p_numGroups = &numGroups)
				fixed (UInt32* p_groups = groups)
				{
					Debug.Assert(Delegates.pglGetPerfMonitorGroupsAMD != null, "pglGetPerfMonitorGroupsAMD not implemented");
					Delegates.pglGetPerfMonitorGroupsAMD(p_numGroups, (Int32)groups.Length, p_groups);
					LogFunction("glGetPerfMonitorGroupsAMD({0}, {1}, {2})", numGroups, groups.Length, LogValue(groups));
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
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|gles2")]
		public static void GetPerfMonitorCountersAMD(UInt32 group, out Int32 numCounters, out Int32 maxActiveCounters, [Out] UInt32[] counters)
		{
			unsafe {
				fixed (Int32* p_numCounters = &numCounters)
				fixed (Int32* p_maxActiveCounters = &maxActiveCounters)
				fixed (UInt32* p_counters = counters)
				{
					Debug.Assert(Delegates.pglGetPerfMonitorCountersAMD != null, "pglGetPerfMonitorCountersAMD not implemented");
					Delegates.pglGetPerfMonitorCountersAMD(group, p_numCounters, p_maxActiveCounters, (Int32)counters.Length, p_counters);
					LogFunction("glGetPerfMonitorCountersAMD({0}, {1}, {2}, {3}, {4})", group, numCounters, maxActiveCounters, counters.Length, LogValue(counters));
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
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|gles2")]
		public static void GetPerfMonitorGroupStringAMD(UInt32 group, Int32 bufSize, out Int32 length, [Out] StringBuilder groupString)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetPerfMonitorGroupStringAMD != null, "pglGetPerfMonitorGroupStringAMD not implemented");
					Delegates.pglGetPerfMonitorGroupStringAMD(group, bufSize, p_length, groupString);
					LogFunction("glGetPerfMonitorGroupStringAMD({0}, {1}, {2}, {3})", group, bufSize, length, groupString);
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
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|gles2")]
		public static void GetPerfMonitorCounterStringAMD(UInt32 group, UInt32 counter, Int32 bufSize, out Int32 length, [Out] StringBuilder counterString)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetPerfMonitorCounterStringAMD != null, "pglGetPerfMonitorCounterStringAMD not implemented");
					Delegates.pglGetPerfMonitorCounterStringAMD(group, counter, bufSize, p_length, counterString);
					LogFunction("glGetPerfMonitorCounterStringAMD({0}, {1}, {2}, {3}, {4})", group, counter, bufSize, length, counterString);
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
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|gles2")]
		public static void GetPerfMonitorCounterInfoAMD(UInt32 group, UInt32 counter, Int32 pname, IntPtr data)
		{
			Debug.Assert(Delegates.pglGetPerfMonitorCounterInfoAMD != null, "pglGetPerfMonitorCounterInfoAMD not implemented");
			Delegates.pglGetPerfMonitorCounterInfoAMD(group, counter, pname, data);
			LogFunction("glGetPerfMonitorCounterInfoAMD({0}, {1}, {2}, 0x{3})", group, counter, LogEnumName(pname), data.ToString("X8"));
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
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|gles2")]
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
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|gles2")]
		public static void GenPerfMonitorsAMD(UInt32[] monitors)
		{
			unsafe {
				fixed (UInt32* p_monitors = monitors)
				{
					Debug.Assert(Delegates.pglGenPerfMonitorsAMD != null, "pglGenPerfMonitorsAMD not implemented");
					Delegates.pglGenPerfMonitorsAMD((Int32)monitors.Length, p_monitors);
					LogFunction("glGenPerfMonitorsAMD({0}, {1})", monitors.Length, LogValue(monitors));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenPerfMonitorsAMD.
		/// </summary>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|gles2")]
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
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|gles2")]
		public static void DeletePerfMonitorsAMD(params UInt32[] monitors)
		{
			unsafe {
				fixed (UInt32* p_monitors = monitors)
				{
					Debug.Assert(Delegates.pglDeletePerfMonitorsAMD != null, "pglDeletePerfMonitorsAMD not implemented");
					Delegates.pglDeletePerfMonitorsAMD((Int32)monitors.Length, p_monitors);
					LogFunction("glDeletePerfMonitorsAMD({0}, {1})", monitors.Length, LogValue(monitors));
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
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|gles2")]
		public static void SelectPerfMonitorCountersAMD(UInt32 monitor, bool enable, UInt32 group, UInt32[] counterList)
		{
			unsafe {
				fixed (UInt32* p_counterList = counterList)
				{
					Debug.Assert(Delegates.pglSelectPerfMonitorCountersAMD != null, "pglSelectPerfMonitorCountersAMD not implemented");
					Delegates.pglSelectPerfMonitorCountersAMD(monitor, enable, group, (Int32)counterList.Length, p_counterList);
					LogFunction("glSelectPerfMonitorCountersAMD({0}, {1}, {2}, {3}, {4})", monitor, enable, group, counterList.Length, LogValue(counterList));
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
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|gles2")]
		public static void BeginPerfMonitorAMD(UInt32 monitor)
		{
			Debug.Assert(Delegates.pglBeginPerfMonitorAMD != null, "pglBeginPerfMonitorAMD not implemented");
			Delegates.pglBeginPerfMonitorAMD(monitor);
			LogFunction("glBeginPerfMonitorAMD({0})", monitor);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEndPerfMonitorAMD.
		/// </summary>
		/// <param name="monitor">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|gles2")]
		public static void EndPerfMonitorAMD(UInt32 monitor)
		{
			Debug.Assert(Delegates.pglEndPerfMonitorAMD != null, "pglEndPerfMonitorAMD not implemented");
			Delegates.pglEndPerfMonitorAMD(monitor);
			LogFunction("glEndPerfMonitorAMD({0})", monitor);
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
		[RequiredByFeature("GL_AMD_performance_monitor", Api = "gl|gles2")]
		public static void GetPerfMonitorCounterDataAMD(UInt32 monitor, Int32 pname, [Out] UInt32[] data, out Int32 bytesWritten)
		{
			unsafe {
				fixed (UInt32* p_data = data)
				fixed (Int32* p_bytesWritten = &bytesWritten)
				{
					Debug.Assert(Delegates.pglGetPerfMonitorCounterDataAMD != null, "pglGetPerfMonitorCounterDataAMD not implemented");
					Delegates.pglGetPerfMonitorCounterDataAMD(monitor, pname, (Int32)data.Length, p_data, p_bytesWritten);
					LogFunction("glGetPerfMonitorCounterDataAMD({0}, {1}, {2}, {3}, {4})", monitor, LogEnumName(pname), data.Length, LogValue(data), bytesWritten);
				}
			}
			DebugCheckErrors(null);
		}

	}

}
