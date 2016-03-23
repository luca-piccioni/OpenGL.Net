
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
		/// Value of GL_PERFQUERY_SINGLE_CONTEXT_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint PERFQUERY_SINGLE_CONTEXT_INTEL = 0x00000000;

		/// <summary>
		/// Value of GL_PERFQUERY_GLOBAL_CONTEXT_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint PERFQUERY_GLOBAL_CONTEXT_INTEL = 0x00000001;

		/// <summary>
		/// Value of GL_PERFQUERY_WAIT_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public const int PERFQUERY_WAIT_INTEL = 0x83FB;

		/// <summary>
		/// Value of GL_PERFQUERY_FLUSH_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public const int PERFQUERY_FLUSH_INTEL = 0x83FA;

		/// <summary>
		/// Value of GL_PERFQUERY_DONOT_FLUSH_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public const int PERFQUERY_DONOT_FLUSH_INTEL = 0x83F9;

		/// <summary>
		/// Value of GL_PERFQUERY_COUNTER_EVENT_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public const int PERFQUERY_COUNTER_EVENT_INTEL = 0x94F0;

		/// <summary>
		/// Value of GL_PERFQUERY_COUNTER_DURATION_NORM_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public const int PERFQUERY_COUNTER_DURATION_NORM_INTEL = 0x94F1;

		/// <summary>
		/// Value of GL_PERFQUERY_COUNTER_DURATION_RAW_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public const int PERFQUERY_COUNTER_DURATION_RAW_INTEL = 0x94F2;

		/// <summary>
		/// Value of GL_PERFQUERY_COUNTER_THROUGHPUT_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public const int PERFQUERY_COUNTER_THROUGHPUT_INTEL = 0x94F3;

		/// <summary>
		/// Value of GL_PERFQUERY_COUNTER_RAW_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public const int PERFQUERY_COUNTER_RAW_INTEL = 0x94F4;

		/// <summary>
		/// Value of GL_PERFQUERY_COUNTER_TIMESTAMP_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public const int PERFQUERY_COUNTER_TIMESTAMP_INTEL = 0x94F5;

		/// <summary>
		/// Value of GL_PERFQUERY_COUNTER_DATA_UINT32_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public const int PERFQUERY_COUNTER_DATA_UINT32_INTEL = 0x94F8;

		/// <summary>
		/// Value of GL_PERFQUERY_COUNTER_DATA_UINT64_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public const int PERFQUERY_COUNTER_DATA_UINT64_INTEL = 0x94F9;

		/// <summary>
		/// Value of GL_PERFQUERY_COUNTER_DATA_FLOAT_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public const int PERFQUERY_COUNTER_DATA_FLOAT_INTEL = 0x94FA;

		/// <summary>
		/// Value of GL_PERFQUERY_COUNTER_DATA_DOUBLE_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public const int PERFQUERY_COUNTER_DATA_DOUBLE_INTEL = 0x94FB;

		/// <summary>
		/// Value of GL_PERFQUERY_COUNTER_DATA_BOOL32_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public const int PERFQUERY_COUNTER_DATA_BOOL32_INTEL = 0x94FC;

		/// <summary>
		/// Value of GL_PERFQUERY_QUERY_NAME_LENGTH_MAX_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public const int PERFQUERY_QUERY_NAME_LENGTH_MAX_INTEL = 0x94FD;

		/// <summary>
		/// Value of GL_PERFQUERY_COUNTER_NAME_LENGTH_MAX_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public const int PERFQUERY_COUNTER_NAME_LENGTH_MAX_INTEL = 0x94FE;

		/// <summary>
		/// Value of GL_PERFQUERY_COUNTER_DESC_LENGTH_MAX_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public const int PERFQUERY_COUNTER_DESC_LENGTH_MAX_INTEL = 0x94FF;

		/// <summary>
		/// Value of GL_PERFQUERY_GPA_EXTENDED_COUNTERS_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public const int PERFQUERY_GPA_EXTENDED_COUNTERS_INTEL = 0x9500;

		/// <summary>
		/// Binding for glBeginPerfQueryINTEL.
		/// </summary>
		/// <param name="queryHandle">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public static void BeginPerfQueryINTEL(UInt32 queryHandle)
		{
			Debug.Assert(Delegates.pglBeginPerfQueryINTEL != null, "pglBeginPerfQueryINTEL not implemented");
			Delegates.pglBeginPerfQueryINTEL(queryHandle);
			LogFunction("glBeginPerfQueryINTEL({0})", queryHandle);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCreatePerfQueryINTEL.
		/// </summary>
		/// <param name="queryId">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="queryHandle">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public static void CreatePerfQueryINTEL(UInt32 queryId, UInt32[] queryHandle)
		{
			unsafe {
				fixed (UInt32* p_queryHandle = queryHandle)
				{
					Debug.Assert(Delegates.pglCreatePerfQueryINTEL != null, "pglCreatePerfQueryINTEL not implemented");
					Delegates.pglCreatePerfQueryINTEL(queryId, p_queryHandle);
					LogFunction("glCreatePerfQueryINTEL({0}, {1})", queryId, LogValue(queryHandle));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDeletePerfQueryINTEL.
		/// </summary>
		/// <param name="queryHandle">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public static void DeletePerfQueryINTEL(UInt32 queryHandle)
		{
			Debug.Assert(Delegates.pglDeletePerfQueryINTEL != null, "pglDeletePerfQueryINTEL not implemented");
			Delegates.pglDeletePerfQueryINTEL(queryHandle);
			LogFunction("glDeletePerfQueryINTEL({0})", queryHandle);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEndPerfQueryINTEL.
		/// </summary>
		/// <param name="queryHandle">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public static void EndPerfQueryINTEL(UInt32 queryHandle)
		{
			Debug.Assert(Delegates.pglEndPerfQueryINTEL != null, "pglEndPerfQueryINTEL not implemented");
			Delegates.pglEndPerfQueryINTEL(queryHandle);
			LogFunction("glEndPerfQueryINTEL({0})", queryHandle);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetFirstPerfQueryIdINTEL.
		/// </summary>
		/// <param name="queryId">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public static void GetFirstPerfQueryIdINTEL([Out] UInt32[] queryId)
		{
			unsafe {
				fixed (UInt32* p_queryId = queryId)
				{
					Debug.Assert(Delegates.pglGetFirstPerfQueryIdINTEL != null, "pglGetFirstPerfQueryIdINTEL not implemented");
					Delegates.pglGetFirstPerfQueryIdINTEL(p_queryId);
					LogFunction("glGetFirstPerfQueryIdINTEL({0})", LogValue(queryId));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetNextPerfQueryIdINTEL.
		/// </summary>
		/// <param name="queryId">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="nextQueryId">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public static void GetNextPerfQueryIdINTEL(UInt32 queryId, [Out] UInt32[] nextQueryId)
		{
			unsafe {
				fixed (UInt32* p_nextQueryId = nextQueryId)
				{
					Debug.Assert(Delegates.pglGetNextPerfQueryIdINTEL != null, "pglGetNextPerfQueryIdINTEL not implemented");
					Delegates.pglGetNextPerfQueryIdINTEL(queryId, p_nextQueryId);
					LogFunction("glGetNextPerfQueryIdINTEL({0}, {1})", queryId, LogValue(nextQueryId));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPerfCounterInfoINTEL.
		/// </summary>
		/// <param name="queryId">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="counterId">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="counterNameLength">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="counterName">
		/// A <see cref="T:String"/>.
		/// </param>
		/// <param name="counterDescLength">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="counterDesc">
		/// A <see cref="T:String"/>.
		/// </param>
		/// <param name="counterOffset">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="counterDataSize">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="counterTypeEnum">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="counterDataTypeEnum">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="rawCounterMaxValue">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public static void GetPerfCounterInfoINTEL(UInt32 queryId, UInt32 counterId, UInt32 counterNameLength, String counterName, UInt32 counterDescLength, String counterDesc, [Out] UInt32[] counterOffset, [Out] UInt32[] counterDataSize, [Out] UInt32[] counterTypeEnum, [Out] UInt32[] counterDataTypeEnum, [Out] UInt64[] rawCounterMaxValue)
		{
			unsafe {
				fixed (UInt32* p_counterOffset = counterOffset)
				fixed (UInt32* p_counterDataSize = counterDataSize)
				fixed (UInt32* p_counterTypeEnum = counterTypeEnum)
				fixed (UInt32* p_counterDataTypeEnum = counterDataTypeEnum)
				fixed (UInt64* p_rawCounterMaxValue = rawCounterMaxValue)
				{
					Debug.Assert(Delegates.pglGetPerfCounterInfoINTEL != null, "pglGetPerfCounterInfoINTEL not implemented");
					Delegates.pglGetPerfCounterInfoINTEL(queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, p_counterOffset, p_counterDataSize, p_counterTypeEnum, p_counterDataTypeEnum, p_rawCounterMaxValue);
					LogFunction("glGetPerfCounterInfoINTEL({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", queryId, counterId, counterNameLength, counterName, counterDescLength, counterDesc, LogValue(counterOffset), LogValue(counterDataSize), LogValue(counterTypeEnum), LogValue(counterDataTypeEnum), LogValue(rawCounterMaxValue));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPerfQueryDataINTEL.
		/// </summary>
		/// <param name="queryHandle">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="flags">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="dataSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="bytesWritten">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public static void GetPerfQueryDataINTEL(UInt32 queryHandle, UInt32 flags, Int32 dataSize, IntPtr data, [Out] UInt32[] bytesWritten)
		{
			unsafe {
				fixed (UInt32* p_bytesWritten = bytesWritten)
				{
					Debug.Assert(Delegates.pglGetPerfQueryDataINTEL != null, "pglGetPerfQueryDataINTEL not implemented");
					Delegates.pglGetPerfQueryDataINTEL(queryHandle, flags, dataSize, data.ToPointer(), p_bytesWritten);
					LogFunction("glGetPerfQueryDataINTEL({0}, {1}, {2}, 0x{3}, {4})", queryHandle, flags, dataSize, data.ToString("X8"), LogValue(bytesWritten));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPerfQueryDataINTEL.
		/// </summary>
		/// <param name="queryHandle">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="flags">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="dataSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="bytesWritten">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public static void GetPerfQueryDataINTEL(UInt32 queryHandle, UInt32 flags, Int32 dataSize, Object data, [Out] UInt32[] bytesWritten)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				GetPerfQueryDataINTEL(queryHandle, flags, dataSize, pin_data.AddrOfPinnedObject(), bytesWritten);
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glGetPerfQueryIdByNameINTEL.
		/// </summary>
		/// <param name="queryName">
		/// A <see cref="T:String"/>.
		/// </param>
		/// <param name="queryId">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public static void GetPerfQueryIdByNameINTEL(String queryName, [Out] UInt32[] queryId)
		{
			unsafe {
				fixed (UInt32* p_queryId = queryId)
				{
					Debug.Assert(Delegates.pglGetPerfQueryIdByNameINTEL != null, "pglGetPerfQueryIdByNameINTEL not implemented");
					Delegates.pglGetPerfQueryIdByNameINTEL(queryName, p_queryId);
					LogFunction("glGetPerfQueryIdByNameINTEL({0}, {1})", queryName, LogValue(queryId));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPerfQueryInfoINTEL.
		/// </summary>
		/// <param name="queryId">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="queryNameLength">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="queryName">
		/// A <see cref="T:String"/>.
		/// </param>
		/// <param name="dataSize">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="noCounters">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="noInstances">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="capsMask">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_performance_query", Api = "gl|gles2")]
		public static void GetPerfQueryInfoINTEL(UInt32 queryId, UInt32 queryNameLength, String queryName, [Out] UInt32[] dataSize, [Out] UInt32[] noCounters, [Out] UInt32[] noInstances, [Out] UInt32[] capsMask)
		{
			unsafe {
				fixed (UInt32* p_dataSize = dataSize)
				fixed (UInt32* p_noCounters = noCounters)
				fixed (UInt32* p_noInstances = noInstances)
				fixed (UInt32* p_capsMask = capsMask)
				{
					Debug.Assert(Delegates.pglGetPerfQueryInfoINTEL != null, "pglGetPerfQueryInfoINTEL not implemented");
					Delegates.pglGetPerfQueryInfoINTEL(queryId, queryNameLength, queryName, p_dataSize, p_noCounters, p_noInstances, p_capsMask);
					LogFunction("glGetPerfQueryInfoINTEL({0}, {1}, {2}, {3}, {4}, {5}, {6})", queryId, queryNameLength, queryName, LogValue(dataSize), LogValue(noCounters), LogValue(noInstances), LogValue(capsMask));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
