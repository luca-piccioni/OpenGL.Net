
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer

namespace OpenVX
{
	public partial class VX
	{
		public const string OPENVX_KHR_XML = "vx_khr_xml";

		public const int IMPORT_TYPE_XML = 0;

		public const int IMPORT_ATTRIBUTE_COUNT = (((ID_KHRONOS) << 20) | ( TYPE_IMPORT << 8)) + 0x0;

		public const int IMPORT_ATTRIBUTE_TYPE = (((ID_KHRONOS) << 20) | ( TYPE_IMPORT << 8)) + 0x1;

		public static Status ExportToXML(Context context, string xmlfile)
		{
			Status retValue;

			Debug.Assert(Delegates.pvxExportToXML != null, "pvxExportToXML not implemented");
			retValue = Delegates.pvxExportToXML(context, xmlfile);
			LogCommand("vxExportToXML", retValue, context, xmlfile			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static Import ImportFromXML(Context context, string xmlfile)
		{
			Import retValue;

			Debug.Assert(Delegates.pvxImportFromXML != null, "pvxImportFromXML not implemented");
			retValue = Delegates.pvxImportFromXML(context, xmlfile);
			LogCommand("vxImportFromXML", retValue, context, xmlfile			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static Reference GetImportReferenceByIndex(Import import, uint index)
		{
			Reference retValue;

			Debug.Assert(Delegates.pvxGetImportReferenceByIndex != null, "pvxGetImportReferenceByIndex not implemented");
			retValue = Delegates.pvxGetImportReferenceByIndex(import, index);
			LogCommand("vxGetImportReferenceByIndex", retValue, import, index			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static Status Query(Import import, int attribute, IntPtr ptr, UIntPtr size)
		{
			Status retValue;

			unsafe {
				{
					Debug.Assert(Delegates.pvxQueryImport != null, "pvxQueryImport not implemented");
					retValue = Delegates.pvxQueryImport(import, attribute, ptr.ToPointer(), size);
					LogCommand("vxQueryImport", retValue, import, attribute, ptr, size					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal static unsafe partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity]
			internal delegate Status vxExportToXML(Context context, string xmlfile);

			internal static vxExportToXML pvxExportToXML;

			[SuppressUnmanagedCodeSecurity]
			internal delegate Import vxImportFromXML(Context context, string xmlfile);

			internal static vxImportFromXML pvxImportFromXML;

			[SuppressUnmanagedCodeSecurity]
			internal delegate Reference vxGetImportReferenceByIndex(Import import, uint index);

			internal static vxGetImportReferenceByIndex pvxGetImportReferenceByIndex;

			[SuppressUnmanagedCodeSecurity]
			internal delegate Status vxQueryImport(Import import, int attribute, void* ptr, UIntPtr size);

			internal static vxQueryImport pvxQueryImport;

		}
	}

}
