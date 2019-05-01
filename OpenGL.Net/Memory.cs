
// Copyright (C) 2011-2018 Luca Piccioni
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

// Field is never assigned to, and will always have its default value null
// Note: fields in Memory class will be assigned by means of reflections, indeed disable the warning on this module
#pragma warning disable 649

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Reflection.Emit;
using System.Security;

using Khronos;

// ReSharper disable SwitchStatementMissingSomeCases

namespace OpenGL
{
	/// <summary>
	/// Main interface for executing operations on memory.
	/// </summary>
	public unsafe class Memory
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static Memory()
		{
			_CopyPointer = GetPlatformMemcpy();

			if (_CopyPointer == null) {
				// Fallback to managed implementation
				_CopyPointer = CopyDelegate_Managed;
				_UseSystemCopy = false;
				_HasSystemCopy = false;
			}
		}

		#endregion

		#region Set

		/// <summary>
		/// Set memory to a specific value.
		/// </summary>
		/// <param name="addr">
		/// The <see cref="IntPtr"/> that specify the memory address.
		/// </param>
		/// <param name="value">
		/// The <see cref="byte"/> that specify the value to set.
		/// </param>
		/// <param name="count">
		/// The <see cref="uint"/> that specify the number of bytes to set.
		/// </param>
		public static void Set(IntPtr addr, byte value, uint count)
		{
			_MemsetDelegate(addr, value, count);
		}

		/// <summary>
		/// Utility route for generating 'memset' delegate.
		/// </summary>
		private static Action<IntPtr, byte, uint> GenerateMemsetDelegate()
		{
#if NETSTANDARD1_1 || NETSTANDARD1_4 || NETSTANDARD2_0 || NETCOREAPP1_1
			return (new Action<IntPtr, byte, uint>(delegate(IntPtr addr, byte value, uint count) { throw new NotImplementedException(); })); // XXX
#else
			DynamicMethod dynamicMethod = new DynamicMethod(
				"Memset", MethodAttributes.Public | MethodAttributes.Static, CallingConventions.Standard,
				null,
				new [] { typeof(IntPtr), typeof(byte), typeof(uint) },
				typeof(Memory), true
			);

			ILGenerator generator = dynamicMethod.GetILGenerator();
			generator.Emit(OpCodes.Ldarg_0);
			generator.Emit(OpCodes.Ldarg_1);
			generator.Emit(OpCodes.Ldarg_2);
			generator.Emit(OpCodes.Initblk);
			generator.Emit(OpCodes.Ret);

			return (Action<IntPtr, byte, uint>)dynamicMethod.CreateDelegate(typeof(Action<IntPtr, byte, uint>));
#endif
		}

		/// <summary>
		/// Delegate executing a memory set operation.
		/// </summary>
		private static readonly Action<IntPtr, byte, uint> _MemsetDelegate = GenerateMemsetDelegate();

		#endregion

		#region Copy

		/// <summary>
		/// Delegate used for copy memory.
		/// </summary>
		/// <param name="dst">
		/// A <see cref="T:void*"/> that specify the address of the destination unmanaged memory.
		/// </param>
		/// <param name="src">
		/// A <see cref="T:void*"/> that specify the source array object.
		/// </param>
		/// <param name="bytes">
		/// A <see cref="ulong"/> that specify the number of bytes to copy.
		/// </param>
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[SuppressUnmanagedCodeSecurity]
		private delegate void CopyDelegate(void *dst, void* src, ulong bytes);

		/// <summary>
		/// Cached delegate for copy memory.
		/// </summary>
		private static CopyDelegate _CopyPointer;

		/// <summary>
		/// Copy memory.
		/// </summary>
		/// <param name="dst">
		/// A <see cref="T:void*"/> that specify the address of the destination unmanaged memory.
		/// </param>
		/// <param name="src">
		/// A <see cref="T:void*"/> that specify the source array object.
		/// </param>
		/// <param name="bytes">
		/// A <see cref="ulong"/> that specify the number of bytes to copy.
		/// </param>
		public static void Copy(void* dst, void* src, ulong bytes)
		{
			_CopyPointer(dst, src, bytes);
		}

		/// <summary>
		/// Copy memory.
		/// </summary>
		/// <param name="dst">
		/// A <see cref="IntPtr"/> that specify the address of the destination unmanaged memory.
		/// </param>
		/// <param name="src">
		/// A <see cref="IntPtr"/> that specify the source array object.
		/// </param>
		/// <param name="bytes">
		/// A <see cref="ulong"/> that specify the number of bytes to copy.
		/// </param>
		public static void Copy(IntPtr dst, IntPtr src, ulong bytes)
		{
			Copy(dst.ToPointer(), src.ToPointer(), bytes);
		}

		/// <summary>
		/// Copy memory.
		/// </summary>
		/// <param name="dst">
		/// A <see cref="Array"/> that specify the address of the destination unmanaged memory.
		/// </param>
		/// <param name="src">
		/// A <see cref="IntPtr"/> that specify the source array object.
		/// </param>
		/// <param name="bytes">
		/// A <see cref="ulong"/> that specify the number of bytes to copy.
		/// </param>
		public static void Copy(Array dst, IntPtr src, ulong bytes)
		{
			using (MemoryLock dstLock = new MemoryLock(dst)) {
				_CopyPointer(
					dstLock.Address.ToPointer(), 
					src.ToPointer(),
					bytes
				);
			}
		}

		/// <summary>
		/// Copy memory.
		/// </summary>
		/// <param name="dst">
		/// A <see cref="IntPtr"/> that specify the address of the destination unmanaged memory.
		/// </param>
		/// <param name="src">
		/// A <see cref="Array"/> that specify the source array object.
		/// </param>
		/// <param name="bytes">
		/// A <see cref="ulong"/> that specify the number of bytes to copy.
		/// </param>
		public static void Copy(IntPtr dst, Array src, ulong bytes)
		{
			using (MemoryLock srcLock = new MemoryLock(src)) {
				_CopyPointer(
					dst.ToPointer(),
					srcLock.Address.ToPointer(),
					bytes
				);
			}
		}

		/// <summary>
		/// Managed-unsafe implementation of Copy.
		/// </summary>
		/// <param name="dst">
		/// A <see cref="T:void*"/> that specify the address of the destination unmanaged memory.
		/// </param>
		/// <param name="src">
		/// A <see cref="T:void*"/> that specify the source array object.
		/// </param>
		/// <param name="bytes">
		/// A <see cref="ulong"/> that specify the number of bytes to copy.
		/// </param>
		private static void CopyDelegate_Managed(void *dst, void* src, ulong bytes)
		{
			if (IntPtr.Size == 8) {
				// Copy word by word
				ulong *dstPtr8 = (ulong*)dst, srcPtr8 = (ulong*)src;
				for (; bytes >= 8; bytes -= 8)
					*dstPtr8++ = *srcPtr8++;

				// Copy remaining bytes
				byte *dstPtr1 = (byte*)dstPtr8, srcPtr1 = (byte*)srcPtr8;
				for (; bytes >= 1; bytes -= 1)
					*dstPtr1++ = *srcPtr1++;
			} else {
				// Copy word by word
				uint *dstPtr4 = (uint*)dst, srcPtr4 = (uint*)src;
				for (; bytes >= 4; bytes -= 4)
					*dstPtr4++ = *srcPtr4++;

				// Copy remaining bytes
				byte *dstPtr1 = (byte*)dstPtr4, srcPtr1 = (byte*)srcPtr4;
				for (; bytes >= 1; bytes -= 1)
					*dstPtr1++ = *srcPtr1++;
			}
		}

		/// <summary>
		/// Get the <see cref="CopyDelegate"/> defined by hosting system, if possible.
		/// </summary>
		/// <returns></returns>
		private static CopyDelegate GetPlatformMemcpy()
		{
			IntPtr memoryCopyPtr;

			switch (Platform.CurrentPlatformId) {
				case Platform.Id.WindowsNT:
					memoryCopyPtr = GetProcAddressOS.GetProcAddress("msvcrt.dll", "memcpy");
					if (memoryCopyPtr != IntPtr.Zero)
						return (CopyDelegate)Marshal.GetDelegateForFunctionPointer(memoryCopyPtr, typeof(CopyDelegate));
					return null;
				case Platform.Id.Linux:
					memoryCopyPtr = GetProcAddressOS.GetProcAddress("libc.so.6", "memcpy");
					if (memoryCopyPtr != IntPtr.Zero)
						return (CopyDelegate)Marshal.GetDelegateForFunctionPointer(memoryCopyPtr, typeof(CopyDelegate));
					return null;
				default:
					return null;
			}
		}

		/// <summary>
		/// Determine whether use system libraries to perform memory copy, or use managed/internal implementation. By default,
		/// use the hosting system functions, if possible.
		/// </summary>
		public static bool UseSystemCopy
		{
			get { return _UseSystemCopy && _HasSystemCopy; }
			set
			{
				if (_UseSystemCopy == value)
					return;
				if (!_HasSystemCopy)
					return;

				_UseSystemCopy = value;
				_CopyPointer = _UseSystemCopy ? GetPlatformMemcpy() : CopyDelegate_Managed;
			}
		}

		/// <summary>
		/// Flag to get consistent getter/setter behavior.
		/// </summary>
		private static bool _UseSystemCopy = true;

		/// <summary>
		/// Flag indicating whether it is possible to call <see cref="GetPlatformMemcpy"/>.
		/// </summary>
		private static readonly bool _HasSystemCopy = true;

		#endregion
	}
}
