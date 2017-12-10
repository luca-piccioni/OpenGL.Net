
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
		public const string OPENVX_KHR_IX = "vx_khr_ix";

		public static Status ExportObjectsToMemory(Context context, UIntPtr numrefs, Reference[] refs, int[] uses, IntPtr[] ptr, UIntPtr[] length)
		{
			Status retValue;

			unsafe {
				fixed (Reference* p_refs = refs)
				fixed (int* p_uses = uses)
				fixed (IntPtr* p_ptr = ptr)
				fixed (UIntPtr* p_length = length)
				{
					Debug.Assert(Delegates.pvxExportObjectsToMemory != null, "pvxExportObjectsToMemory not implemented");
					retValue = Delegates.pvxExportObjectsToMemory(context, numrefs, p_refs, p_uses, p_ptr, p_length);
					LogCommand("vxExportObjectsToMemory", retValue, context, numrefs, refs, uses, ptr, length					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static Status ReleaseExportedMemory(Context context, IntPtr[] ptr)
		{
			Status retValue;

			unsafe {
				fixed (IntPtr* p_ptr = ptr)
				{
					Debug.Assert(Delegates.pvxReleaseExportedMemory != null, "pvxReleaseExportedMemory not implemented");
					retValue = Delegates.pvxReleaseExportedMemory(context, p_ptr);
					LogCommand("vxReleaseExportedMemory", retValue, context, ptr					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal static unsafe partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity]
			internal delegate Status vxExportObjectsToMemory(Context context, UIntPtr numrefs, Reference* refs, int* uses, IntPtr* ptr, UIntPtr* length);

			internal static vxExportObjectsToMemory pvxExportObjectsToMemory;

			[SuppressUnmanagedCodeSecurity]
			internal delegate Status vxReleaseExportedMemory(Context context, IntPtr* ptr);

			internal static vxReleaseExportedMemory pvxReleaseExportedMemory;

		}
	}

}
