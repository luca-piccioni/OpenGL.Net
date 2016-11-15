
// Copyright (C) 2015-2016 Luca Piccioni
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
	public partial class Wfc
	{
		/// <summary>
		/// Value of OPENWFC_VERSION_1_0 symbol.
		/// </summary>
		public const int OPENWFC_VERSION_1_0 = (1);

		/// <summary>
		/// Value of WFC_NONE symbol.
		/// </summary>
		public const int NONE = (0);

		/// <summary>
		/// Value of WFC_INVALID_HANDLE symbol.
		/// </summary>
		public const int INVALID_HANDLE = 0;

		/// <summary>
		/// Value of WFC_DEFAULT_DEVICE_ID symbol.
		/// </summary>
		public const int DEFAULT_DEVICE_ID = (0);

		/// <summary>
		/// Value of WFC_ERROR_NONE symbol.
		/// </summary>
		public const int ERROR_NONE = 0;

		/// <summary>
		/// Value of WFC_ERROR_OUT_OF_MEMORY symbol.
		/// </summary>
		public const int ERROR_OUT_OF_MEMORY = 0x7001;

		/// <summary>
		/// Value of WFC_ERROR_ILLEGAL_ARGUMENT symbol.
		/// </summary>
		public const int ERROR_ILLEGAL_ARGUMENT = 0x7002;

		/// <summary>
		/// Value of WFC_ERROR_UNSUPPORTED symbol.
		/// </summary>
		public const int ERROR_UNSUPPORTED = 0x7003;

		/// <summary>
		/// Value of WFC_ERROR_BAD_ATTRIBUTE symbol.
		/// </summary>
		public const int ERROR_BAD_ATTRIBUTE = 0x7004;

		/// <summary>
		/// Value of WFC_ERROR_IN_USE symbol.
		/// </summary>
		public const int ERROR_IN_USE = 0x7005;

		/// <summary>
		/// Value of WFC_ERROR_BUSY symbol.
		/// </summary>
		public const int ERROR_BUSY = 0x7006;

		/// <summary>
		/// Value of WFC_ERROR_BAD_DEVICE symbol.
		/// </summary>
		public const int ERROR_BAD_DEVICE = 0x7007;

		/// <summary>
		/// Value of WFC_ERROR_BAD_HANDLE symbol.
		/// </summary>
		public const int ERROR_BAD_HANDLE = 0x7008;

		/// <summary>
		/// Value of WFC_ERROR_INCONSISTENCY symbol.
		/// </summary>
		public const int ERROR_INCONSISTENCY = 0x7009;

		/// <summary>
		/// Value of WFC_ERROR_FORCE_32BIT symbol.
		/// </summary>
		public const int ERROR_FORCE_32BIT = 0x7FFFFFFF;

		/// <summary>
		/// Value of WFC_DEVICE_FILTER_SCREEN_NUMBER symbol.
		/// </summary>
		public const int DEVICE_FILTER_SCREEN_NUMBER = 0x7020;

		/// <summary>
		/// Value of WFC_DEVICE_FILTER_FORCE_32BIT symbol.
		/// </summary>
		public const int DEVICE_FILTER_FORCE_32BIT = 0x7FFFFFFF;

		/// <summary>
		/// Value of WFC_DEVICE_CLASS symbol.
		/// </summary>
		public const int DEVICE_CLASS = 0x7030;

		/// <summary>
		/// Value of WFC_DEVICE_ID symbol.
		/// </summary>
		public const int DEVICE_ID = 0x7031;

		/// <summary>
		/// Value of WFC_DEVICE_FORCE_32BIT symbol.
		/// </summary>
		public const int DEVICE_FORCE_32BIT = 0x7FFFFFFF;

		/// <summary>
		/// Value of WFC_DEVICE_CLASS_FULLY_CAPABLE symbol.
		/// </summary>
		public const int DEVICE_CLASS_FULLY_CAPABLE = 0x7040;

		/// <summary>
		/// Value of WFC_DEVICE_CLASS_OFF_SCREEN_ONLY symbol.
		/// </summary>
		public const int DEVICE_CLASS_OFF_SCREEN_ONLY = 0x7041;

		/// <summary>
		/// Value of WFC_DEVICE_CLASS_FORCE_32BIT symbol.
		/// </summary>
		public const int DEVICE_CLASS_FORCE_32BIT = 0x7FFFFFFF;

		/// <summary>
		/// Value of WFC_CONTEXT_TYPE symbol.
		/// </summary>
		public const int CONTEXT_TYPE = 0x7051;

		/// <summary>
		/// Value of WFC_CONTEXT_TARGET_HEIGHT symbol.
		/// </summary>
		public const int CONTEXT_TARGET_HEIGHT = 0x7052;

		/// <summary>
		/// Value of WFC_CONTEXT_TARGET_WIDTH symbol.
		/// </summary>
		public const int CONTEXT_TARGET_WIDTH = 0x7053;

		/// <summary>
		/// Value of WFC_CONTEXT_LOWEST_ELEMENT symbol.
		/// </summary>
		public const int CONTEXT_LOWEST_ELEMENT = 0x7054;

		/// <summary>
		/// Value of WFC_CONTEXT_ROTATION symbol.
		/// </summary>
		public const int CONTEXT_ROTATION = 0x7061;

		/// <summary>
		/// Value of WFC_CONTEXT_BG_COLOR symbol.
		/// </summary>
		public const int CONTEXT_BG_COLOR = 0x7062;

		/// <summary>
		/// Value of WFC_CONTEXT_FORCE_32BIT symbol.
		/// </summary>
		public const int CONTEXT_FORCE_32BIT = 0x7FFFFFFF;

		/// <summary>
		/// Value of WFC_CONTEXT_TYPE_ON_SCREEN symbol.
		/// </summary>
		public const int CONTEXT_TYPE_ON_SCREEN = 0x7071;

		/// <summary>
		/// Value of WFC_CONTEXT_TYPE_OFF_SCREEN symbol.
		/// </summary>
		public const int CONTEXT_TYPE_OFF_SCREEN = 0x7072;

		/// <summary>
		/// Value of WFC_CONTEXT_TYPE_FORCE_32BIT symbol.
		/// </summary>
		public const int CONTEXT_TYPE_FORCE_32BIT = 0x7FFFFFFF;

		/// <summary>
		/// Value of WFC_ROTATION_0 symbol.
		/// </summary>
		public const int ROTATION_0 = 0x7081;

		/// <summary>
		/// Value of WFC_ROTATION_90 symbol.
		/// </summary>
		public const int ROTATION_90 = 0x7082;

		/// <summary>
		/// Value of WFC_ROTATION_180 symbol.
		/// </summary>
		public const int ROTATION_180 = 0x7083;

		/// <summary>
		/// Value of WFC_ROTATION_270 symbol.
		/// </summary>
		public const int ROTATION_270 = 0x7084;

		/// <summary>
		/// Value of WFC_ROTATION_FORCE_32BIT symbol.
		/// </summary>
		public const int ROTATION_FORCE_32BIT = 0x7FFFFFFF;

		/// <summary>
		/// Value of WFC_ELEMENT_DESTINATION_RECTANGLE symbol.
		/// </summary>
		public const int ELEMENT_DESTINATION_RECTANGLE = 0x7101;

		/// <summary>
		/// Value of WFC_ELEMENT_SOURCE symbol.
		/// </summary>
		public const int ELEMENT_SOURCE = 0x7102;

		/// <summary>
		/// Value of WFC_ELEMENT_SOURCE_RECTANGLE symbol.
		/// </summary>
		public const int ELEMENT_SOURCE_RECTANGLE = 0x7103;

		/// <summary>
		/// Value of WFC_ELEMENT_SOURCE_FLIP symbol.
		/// </summary>
		public const int ELEMENT_SOURCE_FLIP = 0x7104;

		/// <summary>
		/// Value of WFC_ELEMENT_SOURCE_ROTATION symbol.
		/// </summary>
		public const int ELEMENT_SOURCE_ROTATION = 0x7105;

		/// <summary>
		/// Value of WFC_ELEMENT_SOURCE_SCALE_FILTER symbol.
		/// </summary>
		public const int ELEMENT_SOURCE_SCALE_FILTER = 0x7106;

		/// <summary>
		/// Value of WFC_ELEMENT_TRANSPARENCY_TYPES symbol.
		/// </summary>
		public const int ELEMENT_TRANSPARENCY_TYPES = 0x7107;

		/// <summary>
		/// Value of WFC_ELEMENT_GLOBAL_ALPHA symbol.
		/// </summary>
		public const int ELEMENT_GLOBAL_ALPHA = 0x7108;

		/// <summary>
		/// Value of WFC_ELEMENT_MASK symbol.
		/// </summary>
		public const int ELEMENT_MASK = 0x7109;

		/// <summary>
		/// Value of WFC_ELEMENT_FORCE_32BIT symbol.
		/// </summary>
		public const int ELEMENT_FORCE_32BIT = 0x7FFFFFFF;

		/// <summary>
		/// Value of WFC_SCALE_FILTER_NONE symbol.
		/// </summary>
		public const int SCALE_FILTER_NONE = 0x7151;

		/// <summary>
		/// Value of WFC_SCALE_FILTER_FASTER symbol.
		/// </summary>
		public const int SCALE_FILTER_FASTER = 0x7152;

		/// <summary>
		/// Value of WFC_SCALE_FILTER_BETTER symbol.
		/// </summary>
		public const int SCALE_FILTER_BETTER = 0x7153;

		/// <summary>
		/// Value of WFC_SCALE_FILTER_FORCE_32BIT symbol.
		/// </summary>
		public const int SCALE_FILTER_FORCE_32BIT = 0x7FFFFFFF;

		/// <summary>
		/// Value of WFC_TRANSPARENCY_NONE symbol.
		/// </summary>
		public const int TRANSPARENCY_NONE = 0;

		/// <summary>
		/// Value of WFC_TRANSPARENCY_ELEMENT_GLOBAL_ALPHA symbol.
		/// </summary>
		public const int TRANSPARENCY_ELEMENT_GLOBAL_ALPHA = (1 << 0);

		/// <summary>
		/// Value of WFC_TRANSPARENCY_SOURCE symbol.
		/// </summary>
		public const int TRANSPARENCY_SOURCE = (1 << 1);

		/// <summary>
		/// Value of WFC_TRANSPARENCY_MASK symbol.
		/// </summary>
		public const int TRANSPARENCY_MASK = (1 << 2);

		/// <summary>
		/// Value of WFC_TRANSPARENCY_FORCE_32BIT symbol.
		/// </summary>
		public const int TRANSPARENCY_FORCE_32BIT = 0x7FFFFFFF;

		/// <summary>
		/// Value of WFC_VENDOR symbol.
		/// </summary>
		public const int VENDOR = 0x7200;

		/// <summary>
		/// Value of WFC_RENDERER symbol.
		/// </summary>
		public const int RENDERER = 0x7201;

		/// <summary>
		/// Value of WFC_VERSION symbol.
		/// </summary>
		public const int VERSION = 0x7202;

		/// <summary>
		/// Value of WFC_EXTENSIONS symbol.
		/// </summary>
		public const int EXTENSIONS = 0x7203;

		/// <summary>
		/// Value of WFC_STRINGID_FORCE_32BIT symbol.
		/// </summary>
		public const int STRINGID_FORCE_32BIT = 0x7FFFFFFF;

		public static int EnumerateDevices(int[] deviceIds, int deviceIdsCount, int[] filterList)
		{
			int retValue;

			unsafe {
				fixed (int* p_deviceIds = deviceIds)
				fixed (int* p_filterList = filterList)
				{
					Debug.Assert(Delegates.pwfcEnumerateDevices != null, "pwfcEnumerateDevices not implemented");
					retValue = Delegates.pwfcEnumerateDevices(p_deviceIds, deviceIdsCount, p_filterList);
					LogFunction("wfcEnumerateDevices({0}, {1}, {2}) = {3}", LogValue(deviceIds), deviceIdsCount, LogValue(filterList), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static UInt32 CreateDevice(int deviceId, int[] attribList)
		{
			UInt32 retValue;

			unsafe {
				fixed (int* p_attribList = attribList)
				{
					Debug.Assert(Delegates.pwfcCreateDevice != null, "pwfcCreateDevice not implemented");
					retValue = Delegates.pwfcCreateDevice(deviceId, p_attribList);
					LogFunction("wfcCreateDevice({0}, {1}) = {2}", deviceId, LogValue(attribList), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static WFCErrorCode GetError(UInt32 dev)
		{
			WFCErrorCode retValue;

			Debug.Assert(Delegates.pwfcGetError != null, "pwfcGetError not implemented");
			retValue = Delegates.pwfcGetError(dev);
			LogFunction("wfcGetError({0}) = {1}", dev, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static int GetDeviceAttribi(UInt32 dev, WFCDeviceAttrib attrib)
		{
			int retValue;

			Debug.Assert(Delegates.pwfcGetDeviceAttribi != null, "pwfcGetDeviceAttribi not implemented");
			retValue = Delegates.pwfcGetDeviceAttribi(dev, attrib);
			LogFunction("wfcGetDeviceAttribi({0}, {1}) = {2}", dev, attrib, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static WFCErrorCode DestroyDevice(UInt32 dev)
		{
			WFCErrorCode retValue;

			Debug.Assert(Delegates.pwfcDestroyDevice != null, "pwfcDestroyDevice not implemented");
			retValue = Delegates.pwfcDestroyDevice(dev);
			LogFunction("wfcDestroyDevice({0}) = {1}", dev, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static UInt32 Create(UInt32 dev, int screenNumber, int[] attribList)
		{
			UInt32 retValue;

			unsafe {
				fixed (int* p_attribList = attribList)
				{
					Debug.Assert(Delegates.pwfcCreateOnScreenContext != null, "pwfcCreateOnScreenContext not implemented");
					retValue = Delegates.pwfcCreateOnScreenContext(dev, screenNumber, p_attribList);
					LogFunction("wfcCreateOnScreenContext({0}, {1}, {2}) = {3}", dev, screenNumber, LogValue(attribList), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static UInt32 Create(UInt32 dev, UInt32 stream, int[] attribList)
		{
			UInt32 retValue;

			unsafe {
				fixed (int* p_attribList = attribList)
				{
					Debug.Assert(Delegates.pwfcCreateOffScreenContext != null, "pwfcCreateOffScreenContext not implemented");
					retValue = Delegates.pwfcCreateOffScreenContext(dev, stream, p_attribList);
					LogFunction("wfcCreateOffScreenContext({0}, {1}, {2}) = {3}", dev, stream, LogValue(attribList), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static void Commit(UInt32 dev, UInt32 ctx, bool wait)
		{
			Debug.Assert(Delegates.pwfcCommit != null, "pwfcCommit not implemented");
			Delegates.pwfcCommit(dev, ctx, wait);
			LogFunction("wfcCommit({0}, {1}, {2})", dev, ctx, wait);
			DebugCheckErrors(null);
		}

		public static int GetContextAttribi(UInt32 dev, UInt32 ctx, WFCContextAttrib attrib)
		{
			int retValue;

			Debug.Assert(Delegates.pwfcGetContextAttribi != null, "pwfcGetContextAttribi not implemented");
			retValue = Delegates.pwfcGetContextAttribi(dev, ctx, attrib);
			LogFunction("wfcGetContextAttribi({0}, {1}, {2}) = {3}", dev, ctx, attrib, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static void GetContextAttribfv(UInt32 dev, UInt32 ctx, WFCContextAttrib attrib, int count, [Out] float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pwfcGetContextAttribfv != null, "pwfcGetContextAttribfv not implemented");
					Delegates.pwfcGetContextAttribfv(dev, ctx, attrib, count, p_values);
					LogFunction("wfcGetContextAttribfv({0}, {1}, {2}, {3}, {4})", dev, ctx, attrib, count, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		public static void SetContextAttribi(UInt32 dev, UInt32 ctx, WFCContextAttrib attrib, int value)
		{
			Debug.Assert(Delegates.pwfcSetContextAttribi != null, "pwfcSetContextAttribi not implemented");
			Delegates.pwfcSetContextAttribi(dev, ctx, attrib, value);
			LogFunction("wfcSetContextAttribi({0}, {1}, {2}, {3})", dev, ctx, attrib, value);
			DebugCheckErrors(null);
		}

		public static void SetContextAttribfv(UInt32 dev, UInt32 ctx, WFCContextAttrib attrib, int count, float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pwfcSetContextAttribfv != null, "pwfcSetContextAttribfv not implemented");
					Delegates.pwfcSetContextAttribfv(dev, ctx, attrib, count, p_values);
					LogFunction("wfcSetContextAttribfv({0}, {1}, {2}, {3}, {4})", dev, ctx, attrib, count, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		public static void Destroy(UInt32 dev, UInt32 ctx)
		{
			Debug.Assert(Delegates.pwfcDestroyContext != null, "pwfcDestroyContext not implemented");
			Delegates.pwfcDestroyContext(dev, ctx);
			LogFunction("wfcDestroyContext({0}, {1})", dev, ctx);
			DebugCheckErrors(null);
		}

		public static UInt32 CreateSourceFromStream(UInt32 dev, UInt32 ctx, UInt32 stream, int[] attribList)
		{
			UInt32 retValue;

			unsafe {
				fixed (int* p_attribList = attribList)
				{
					Debug.Assert(Delegates.pwfcCreateSourceFromStream != null, "pwfcCreateSourceFromStream not implemented");
					retValue = Delegates.pwfcCreateSourceFromStream(dev, ctx, stream, p_attribList);
					LogFunction("wfcCreateSourceFromStream({0}, {1}, {2}, {3}) = {4}", dev, ctx, stream, LogValue(attribList), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static void DestroySource(UInt32 dev, UInt32 src)
		{
			Debug.Assert(Delegates.pwfcDestroySource != null, "pwfcDestroySource not implemented");
			Delegates.pwfcDestroySource(dev, src);
			LogFunction("wfcDestroySource({0}, {1})", dev, src);
			DebugCheckErrors(null);
		}

		public static UInt32 CreateMaskFromStream(UInt32 dev, UInt32 ctx, UInt32 stream, int[] attribList)
		{
			UInt32 retValue;

			unsafe {
				fixed (int* p_attribList = attribList)
				{
					Debug.Assert(Delegates.pwfcCreateMaskFromStream != null, "pwfcCreateMaskFromStream not implemented");
					retValue = Delegates.pwfcCreateMaskFromStream(dev, ctx, stream, p_attribList);
					LogFunction("wfcCreateMaskFromStream({0}, {1}, {2}, {3}) = {4}", dev, ctx, stream, LogValue(attribList), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static void DestroyMask(UInt32 dev, UInt32 mask)
		{
			Debug.Assert(Delegates.pwfcDestroyMask != null, "pwfcDestroyMask not implemented");
			Delegates.pwfcDestroyMask(dev, mask);
			LogFunction("wfcDestroyMask({0}, {1})", dev, mask);
			DebugCheckErrors(null);
		}

		public static UInt32 CreateElement(UInt32 dev, UInt32 ctx, int[] attribList)
		{
			UInt32 retValue;

			unsafe {
				fixed (int* p_attribList = attribList)
				{
					Debug.Assert(Delegates.pwfcCreateElement != null, "pwfcCreateElement not implemented");
					retValue = Delegates.pwfcCreateElement(dev, ctx, p_attribList);
					LogFunction("wfcCreateElement({0}, {1}, {2}) = {3}", dev, ctx, LogValue(attribList), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static int GetElementAttribi(UInt32 dev, UInt32 element, WFCElementAttrib attrib)
		{
			int retValue;

			Debug.Assert(Delegates.pwfcGetElementAttribi != null, "pwfcGetElementAttribi not implemented");
			retValue = Delegates.pwfcGetElementAttribi(dev, element, attrib);
			LogFunction("wfcGetElementAttribi({0}, {1}, {2}) = {3}", dev, element, attrib, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static float GetElementAttribf(UInt32 dev, UInt32 element, WFCElementAttrib attrib)
		{
			float retValue;

			Debug.Assert(Delegates.pwfcGetElementAttribf != null, "pwfcGetElementAttribf not implemented");
			retValue = Delegates.pwfcGetElementAttribf(dev, element, attrib);
			LogFunction("wfcGetElementAttribf({0}, {1}, {2}) = {3}", dev, element, attrib, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static void GetElementAttribi(UInt32 dev, UInt32 element, WFCElementAttrib attrib, int count, [Out] int[] values)
		{
			unsafe {
				fixed (int* p_values = values)
				{
					Debug.Assert(Delegates.pwfcGetElementAttribiv != null, "pwfcGetElementAttribiv not implemented");
					Delegates.pwfcGetElementAttribiv(dev, element, attrib, count, p_values);
					LogFunction("wfcGetElementAttribiv({0}, {1}, {2}, {3}, {4})", dev, element, attrib, count, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		public static void GetElementAttribf(UInt32 dev, UInt32 element, WFCElementAttrib attrib, int count, [Out] float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pwfcGetElementAttribfv != null, "pwfcGetElementAttribfv not implemented");
					Delegates.pwfcGetElementAttribfv(dev, element, attrib, count, p_values);
					LogFunction("wfcGetElementAttribfv({0}, {1}, {2}, {3}, {4})", dev, element, attrib, count, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		public static void SetElementAttribi(UInt32 dev, UInt32 element, WFCElementAttrib attrib, int value)
		{
			Debug.Assert(Delegates.pwfcSetElementAttribi != null, "pwfcSetElementAttribi not implemented");
			Delegates.pwfcSetElementAttribi(dev, element, attrib, value);
			LogFunction("wfcSetElementAttribi({0}, {1}, {2}, {3})", dev, element, attrib, value);
			DebugCheckErrors(null);
		}

		public static void SetElementAttribf(UInt32 dev, UInt32 element, WFCElementAttrib attrib, float value)
		{
			Debug.Assert(Delegates.pwfcSetElementAttribf != null, "pwfcSetElementAttribf not implemented");
			Delegates.pwfcSetElementAttribf(dev, element, attrib, value);
			LogFunction("wfcSetElementAttribf({0}, {1}, {2}, {3})", dev, element, attrib, value);
			DebugCheckErrors(null);
		}

		public static void SetElementAttribi(UInt32 dev, UInt32 element, WFCElementAttrib attrib, int count, int[] values)
		{
			unsafe {
				fixed (int* p_values = values)
				{
					Debug.Assert(Delegates.pwfcSetElementAttribiv != null, "pwfcSetElementAttribiv not implemented");
					Delegates.pwfcSetElementAttribiv(dev, element, attrib, count, p_values);
					LogFunction("wfcSetElementAttribiv({0}, {1}, {2}, {3}, {4})", dev, element, attrib, count, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		public static void SetElementAttribf(UInt32 dev, UInt32 element, WFCElementAttrib attrib, int count, float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pwfcSetElementAttribfv != null, "pwfcSetElementAttribfv not implemented");
					Delegates.pwfcSetElementAttribfv(dev, element, attrib, count, p_values);
					LogFunction("wfcSetElementAttribfv({0}, {1}, {2}, {3}, {4})", dev, element, attrib, count, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		public static void InsertElement(UInt32 dev, UInt32 element, UInt32 subordinate)
		{
			Debug.Assert(Delegates.pwfcInsertElement != null, "pwfcInsertElement not implemented");
			Delegates.pwfcInsertElement(dev, element, subordinate);
			LogFunction("wfcInsertElement({0}, {1}, {2})", dev, element, subordinate);
			DebugCheckErrors(null);
		}

		public static void RemoveElement(UInt32 dev, UInt32 element)
		{
			Debug.Assert(Delegates.pwfcRemoveElement != null, "pwfcRemoveElement not implemented");
			Delegates.pwfcRemoveElement(dev, element);
			LogFunction("wfcRemoveElement({0}, {1})", dev, element);
			DebugCheckErrors(null);
		}

		public static UInt32 GetElementAbove(UInt32 dev, UInt32 element)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pwfcGetElementAbove != null, "pwfcGetElementAbove not implemented");
			retValue = Delegates.pwfcGetElementAbove(dev, element);
			LogFunction("wfcGetElementAbove({0}, {1}) = {2}", dev, element, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static UInt32 GetElementBelow(UInt32 dev, UInt32 element)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pwfcGetElementBelow != null, "pwfcGetElementBelow not implemented");
			retValue = Delegates.pwfcGetElementBelow(dev, element);
			LogFunction("wfcGetElementBelow({0}, {1}) = {2}", dev, element, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static void DestroyElement(UInt32 dev, UInt32 element)
		{
			Debug.Assert(Delegates.pwfcDestroyElement != null, "pwfcDestroyElement not implemented");
			Delegates.pwfcDestroyElement(dev, element);
			LogFunction("wfcDestroyElement({0}, {1})", dev, element);
			DebugCheckErrors(null);
		}

		public static void Activate(UInt32 dev, UInt32 ctx)
		{
			Debug.Assert(Delegates.pwfcActivate != null, "pwfcActivate not implemented");
			Delegates.pwfcActivate(dev, ctx);
			LogFunction("wfcActivate({0}, {1})", dev, ctx);
			DebugCheckErrors(null);
		}

		public static void Deactivate(UInt32 dev, UInt32 ctx)
		{
			Debug.Assert(Delegates.pwfcDeactivate != null, "pwfcDeactivate not implemented");
			Delegates.pwfcDeactivate(dev, ctx);
			LogFunction("wfcDeactivate({0}, {1})", dev, ctx);
			DebugCheckErrors(null);
		}

		public static void Compose(UInt32 dev, UInt32 ctx, bool wait)
		{
			Debug.Assert(Delegates.pwfcCompose != null, "pwfcCompose not implemented");
			Delegates.pwfcCompose(dev, ctx, wait);
			LogFunction("wfcCompose({0}, {1}, {2})", dev, ctx, wait);
			DebugCheckErrors(null);
		}

		public static void Fence(UInt32 dev, UInt32 ctx, IntPtr dpy, IntPtr sync)
		{
			Debug.Assert(Delegates.pwfcFence != null, "pwfcFence not implemented");
			Delegates.pwfcFence(dev, ctx, dpy, sync);
			LogFunction("wfcFence({0}, {1}, 0x{2}, 0x{3})", dev, ctx, dpy.ToString("X8"), sync.ToString("X8"));
			DebugCheckErrors(null);
		}

		public static int GetStrings(UInt32 dev, WFCStringID name, [Out] IntPtr[] strings, int stringsCount)
		{
			int retValue;

			unsafe {
				fixed (IntPtr* p_strings = strings)
				{
					Debug.Assert(Delegates.pwfcGetStrings != null, "pwfcGetStrings not implemented");
					retValue = Delegates.pwfcGetStrings(dev, name, p_strings, stringsCount);
					LogFunction("wfcGetStrings({0}, {1}, {2}, {3}) = {4}", dev, name, LogValue(strings), stringsCount, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static bool IsExtensionSupported(UInt32 dev, [Out] char[] @string)
		{
			bool retValue;

			unsafe {
				fixed (char* p_string = @string)
				{
					Debug.Assert(Delegates.pwfcIsExtensionSupported != null, "pwfcIsExtensionSupported not implemented");
					retValue = Delegates.pwfcIsExtensionSupported(dev, p_string);
					LogFunction("wfcIsExtensionSupported({0}, {1}) = {2}", dev, LogValue(@string), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcEnumerateDevices", ExactSpelling = true)]
			internal extern static unsafe int wfcEnumerateDevices(int* deviceIds, int deviceIdsCount, int* filterList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcCreateDevice", ExactSpelling = true)]
			internal extern static unsafe UInt32 wfcCreateDevice(int deviceId, int* attribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcGetError", ExactSpelling = true)]
			internal extern static WFCErrorCode wfcGetError(UInt32 dev);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcGetDeviceAttribi", ExactSpelling = true)]
			internal extern static int wfcGetDeviceAttribi(UInt32 dev, WFCDeviceAttrib attrib);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcDestroyDevice", ExactSpelling = true)]
			internal extern static WFCErrorCode wfcDestroyDevice(UInt32 dev);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcCreateOnScreenContext", ExactSpelling = true)]
			internal extern static unsafe UInt32 wfcCreateOnScreenContext(UInt32 dev, int screenNumber, int* attribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcCreateOffScreenContext", ExactSpelling = true)]
			internal extern static unsafe UInt32 wfcCreateOffScreenContext(UInt32 dev, UInt32 stream, int* attribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcCommit", ExactSpelling = true)]
			internal extern static void wfcCommit(UInt32 dev, UInt32 ctx, bool wait);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcGetContextAttribi", ExactSpelling = true)]
			internal extern static int wfcGetContextAttribi(UInt32 dev, UInt32 ctx, WFCContextAttrib attrib);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcGetContextAttribfv", ExactSpelling = true)]
			internal extern static unsafe void wfcGetContextAttribfv(UInt32 dev, UInt32 ctx, WFCContextAttrib attrib, int count, float* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcSetContextAttribi", ExactSpelling = true)]
			internal extern static void wfcSetContextAttribi(UInt32 dev, UInt32 ctx, WFCContextAttrib attrib, int value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcSetContextAttribfv", ExactSpelling = true)]
			internal extern static unsafe void wfcSetContextAttribfv(UInt32 dev, UInt32 ctx, WFCContextAttrib attrib, int count, float* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcDestroyContext", ExactSpelling = true)]
			internal extern static void wfcDestroyContext(UInt32 dev, UInt32 ctx);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcCreateSourceFromStream", ExactSpelling = true)]
			internal extern static unsafe UInt32 wfcCreateSourceFromStream(UInt32 dev, UInt32 ctx, UInt32 stream, int* attribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcDestroySource", ExactSpelling = true)]
			internal extern static void wfcDestroySource(UInt32 dev, UInt32 src);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcCreateMaskFromStream", ExactSpelling = true)]
			internal extern static unsafe UInt32 wfcCreateMaskFromStream(UInt32 dev, UInt32 ctx, UInt32 stream, int* attribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcDestroyMask", ExactSpelling = true)]
			internal extern static void wfcDestroyMask(UInt32 dev, UInt32 mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcCreateElement", ExactSpelling = true)]
			internal extern static unsafe UInt32 wfcCreateElement(UInt32 dev, UInt32 ctx, int* attribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcGetElementAttribi", ExactSpelling = true)]
			internal extern static int wfcGetElementAttribi(UInt32 dev, UInt32 element, WFCElementAttrib attrib);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcGetElementAttribf", ExactSpelling = true)]
			internal extern static float wfcGetElementAttribf(UInt32 dev, UInt32 element, WFCElementAttrib attrib);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcGetElementAttribiv", ExactSpelling = true)]
			internal extern static unsafe void wfcGetElementAttribiv(UInt32 dev, UInt32 element, WFCElementAttrib attrib, int count, int* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcGetElementAttribfv", ExactSpelling = true)]
			internal extern static unsafe void wfcGetElementAttribfv(UInt32 dev, UInt32 element, WFCElementAttrib attrib, int count, float* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcSetElementAttribi", ExactSpelling = true)]
			internal extern static void wfcSetElementAttribi(UInt32 dev, UInt32 element, WFCElementAttrib attrib, int value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcSetElementAttribf", ExactSpelling = true)]
			internal extern static void wfcSetElementAttribf(UInt32 dev, UInt32 element, WFCElementAttrib attrib, float value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcSetElementAttribiv", ExactSpelling = true)]
			internal extern static unsafe void wfcSetElementAttribiv(UInt32 dev, UInt32 element, WFCElementAttrib attrib, int count, int* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcSetElementAttribfv", ExactSpelling = true)]
			internal extern static unsafe void wfcSetElementAttribfv(UInt32 dev, UInt32 element, WFCElementAttrib attrib, int count, float* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcInsertElement", ExactSpelling = true)]
			internal extern static void wfcInsertElement(UInt32 dev, UInt32 element, UInt32 subordinate);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcRemoveElement", ExactSpelling = true)]
			internal extern static void wfcRemoveElement(UInt32 dev, UInt32 element);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcGetElementAbove", ExactSpelling = true)]
			internal extern static UInt32 wfcGetElementAbove(UInt32 dev, UInt32 element);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcGetElementBelow", ExactSpelling = true)]
			internal extern static UInt32 wfcGetElementBelow(UInt32 dev, UInt32 element);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcDestroyElement", ExactSpelling = true)]
			internal extern static void wfcDestroyElement(UInt32 dev, UInt32 element);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcActivate", ExactSpelling = true)]
			internal extern static void wfcActivate(UInt32 dev, UInt32 ctx);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcDeactivate", ExactSpelling = true)]
			internal extern static void wfcDeactivate(UInt32 dev, UInt32 ctx);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcCompose", ExactSpelling = true)]
			internal extern static void wfcCompose(UInt32 dev, UInt32 ctx, bool wait);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcFence", ExactSpelling = true)]
			internal extern static unsafe void wfcFence(UInt32 dev, UInt32 ctx, IntPtr dpy, IntPtr sync);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcGetStrings", ExactSpelling = true)]
			internal extern static unsafe int wfcGetStrings(UInt32 dev, WFCStringID name, IntPtr* strings, int stringsCount);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wfcIsExtensionSupported", ExactSpelling = true)]
			internal extern static unsafe bool wfcIsExtensionSupported(UInt32 dev, char* @string);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int wfcEnumerateDevices(int* deviceIds, int deviceIdsCount, int* filterList);

			internal static wfcEnumerateDevices pwfcEnumerateDevices;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 wfcCreateDevice(int deviceId, int* attribList);

			internal static wfcCreateDevice pwfcCreateDevice;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate WFCErrorCode wfcGetError(UInt32 dev);

			internal static wfcGetError pwfcGetError;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int wfcGetDeviceAttribi(UInt32 dev, WFCDeviceAttrib attrib);

			internal static wfcGetDeviceAttribi pwfcGetDeviceAttribi;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate WFCErrorCode wfcDestroyDevice(UInt32 dev);

			internal static wfcDestroyDevice pwfcDestroyDevice;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 wfcCreateOnScreenContext(UInt32 dev, int screenNumber, int* attribList);

			internal static wfcCreateOnScreenContext pwfcCreateOnScreenContext;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 wfcCreateOffScreenContext(UInt32 dev, UInt32 stream, int* attribList);

			internal static wfcCreateOffScreenContext pwfcCreateOffScreenContext;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfcCommit(UInt32 dev, UInt32 ctx, bool wait);

			internal static wfcCommit pwfcCommit;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int wfcGetContextAttribi(UInt32 dev, UInt32 ctx, WFCContextAttrib attrib);

			internal static wfcGetContextAttribi pwfcGetContextAttribi;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wfcGetContextAttribfv(UInt32 dev, UInt32 ctx, WFCContextAttrib attrib, int count, float* values);

			internal static wfcGetContextAttribfv pwfcGetContextAttribfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfcSetContextAttribi(UInt32 dev, UInt32 ctx, WFCContextAttrib attrib, int value);

			internal static wfcSetContextAttribi pwfcSetContextAttribi;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wfcSetContextAttribfv(UInt32 dev, UInt32 ctx, WFCContextAttrib attrib, int count, float* values);

			internal static wfcSetContextAttribfv pwfcSetContextAttribfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfcDestroyContext(UInt32 dev, UInt32 ctx);

			internal static wfcDestroyContext pwfcDestroyContext;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 wfcCreateSourceFromStream(UInt32 dev, UInt32 ctx, UInt32 stream, int* attribList);

			internal static wfcCreateSourceFromStream pwfcCreateSourceFromStream;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfcDestroySource(UInt32 dev, UInt32 src);

			internal static wfcDestroySource pwfcDestroySource;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 wfcCreateMaskFromStream(UInt32 dev, UInt32 ctx, UInt32 stream, int* attribList);

			internal static wfcCreateMaskFromStream pwfcCreateMaskFromStream;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfcDestroyMask(UInt32 dev, UInt32 mask);

			internal static wfcDestroyMask pwfcDestroyMask;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 wfcCreateElement(UInt32 dev, UInt32 ctx, int* attribList);

			internal static wfcCreateElement pwfcCreateElement;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int wfcGetElementAttribi(UInt32 dev, UInt32 element, WFCElementAttrib attrib);

			internal static wfcGetElementAttribi pwfcGetElementAttribi;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate float wfcGetElementAttribf(UInt32 dev, UInt32 element, WFCElementAttrib attrib);

			internal static wfcGetElementAttribf pwfcGetElementAttribf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wfcGetElementAttribiv(UInt32 dev, UInt32 element, WFCElementAttrib attrib, int count, int* values);

			internal static wfcGetElementAttribiv pwfcGetElementAttribiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wfcGetElementAttribfv(UInt32 dev, UInt32 element, WFCElementAttrib attrib, int count, float* values);

			internal static wfcGetElementAttribfv pwfcGetElementAttribfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfcSetElementAttribi(UInt32 dev, UInt32 element, WFCElementAttrib attrib, int value);

			internal static wfcSetElementAttribi pwfcSetElementAttribi;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfcSetElementAttribf(UInt32 dev, UInt32 element, WFCElementAttrib attrib, float value);

			internal static wfcSetElementAttribf pwfcSetElementAttribf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wfcSetElementAttribiv(UInt32 dev, UInt32 element, WFCElementAttrib attrib, int count, int* values);

			internal static wfcSetElementAttribiv pwfcSetElementAttribiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wfcSetElementAttribfv(UInt32 dev, UInt32 element, WFCElementAttrib attrib, int count, float* values);

			internal static wfcSetElementAttribfv pwfcSetElementAttribfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfcInsertElement(UInt32 dev, UInt32 element, UInt32 subordinate);

			internal static wfcInsertElement pwfcInsertElement;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfcRemoveElement(UInt32 dev, UInt32 element);

			internal static wfcRemoveElement pwfcRemoveElement;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 wfcGetElementAbove(UInt32 dev, UInt32 element);

			internal static wfcGetElementAbove pwfcGetElementAbove;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 wfcGetElementBelow(UInt32 dev, UInt32 element);

			internal static wfcGetElementBelow pwfcGetElementBelow;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfcDestroyElement(UInt32 dev, UInt32 element);

			internal static wfcDestroyElement pwfcDestroyElement;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfcActivate(UInt32 dev, UInt32 ctx);

			internal static wfcActivate pwfcActivate;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfcDeactivate(UInt32 dev, UInt32 ctx);

			internal static wfcDeactivate pwfcDeactivate;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wfcCompose(UInt32 dev, UInt32 ctx, bool wait);

			internal static wfcCompose pwfcCompose;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wfcFence(UInt32 dev, UInt32 ctx, IntPtr dpy, IntPtr sync);

			internal static wfcFence pwfcFence;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int wfcGetStrings(UInt32 dev, WFCStringID name, IntPtr* strings, int stringsCount);

			internal static wfcGetStrings pwfcGetStrings;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wfcIsExtensionSupported(UInt32 dev, char* @string);

			internal static wfcIsExtensionSupported pwfcIsExtensionSupported;

		}
	}

}
