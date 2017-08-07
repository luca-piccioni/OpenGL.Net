
// Copyright (C) 2017 Luca Piccioni
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

#undef ENABLE_ENABLE

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security;

using NUnit.Framework;

namespace OpenGL.Test
{
	[TestFixture]
	[Category("Benchmark")]
	class BenchmarkPInvoke : TestBaseGL
	{
		#region Setup & Tear Down

		/// <summary>
		/// Initialize resources for test.
		/// </summary>
		[TestFixtureSetUp]
		public new void FixtureSetUp()
		{
			Initialize_GetDelegateForFunctionPointer();
			Initialize_Emit();
		}

		#endregion

		/// <summary>
		/// Test various P/Invoke implementations.
		/// </summary>
		[Test]
		public void BenchmarkPInvokeInvocations()
		{
			TestBaseBenchmark.RunBenchmarks<BenchmarkPInvoke>("BenchmarkPInvoke");
		}

		#region Straight .Net

		[Benchmark("BenchmarkPInvoke_Straight", Repetitions = PInvokeRepetitions)]
		public static void BenchmarkPInvoke_Straight()
		{
			for (int i = 0; i < PInvokeRepetitionsInternal; i++) {
				glFlush();
			}
#if ENABLE_ENABLE
			for (int i = 0; i < PInvokeRepetitionsInternal; i++) {
				glEnable(Gl.CULL_FACE);
			}
#endif
		}

		/// <summary>
		/// Maps glFlush on opengl32.dll. Other environments requires dllmap.
		/// </summary>
		/// <remarks>
		/// - Current approach is not applicable because it cannot be ThreadStatic
		/// - Not sure if it is the same implementation of the delegate <see cref="pglFlush"/>, since the
		///   address is returned by wglGetProcAddress using the current context: this field is not, probably
		///   pointing to the GL 1.4 implementation on Windows.
		/// </remarks>
		[SuppressUnmanagedCodeSecurity()]
		[DllImport("opengl32", EntryPoint = "glFlush", ExactSpelling = true)]
		private extern static void glFlush();

		[SuppressUnmanagedCodeSecurity()]
		[DllImport("opengl32", EntryPoint = "glEnable", ExactSpelling = true)]
		internal extern static void glEnable(Int32 cap);

		#endregion

		#region Marshal.GetDelegateForFunctionPointer

		private static void Initialize_GetDelegateForFunctionPointer()
		{
			IntPtr glFlushAddress = GetProcAddressGL.GetProcAddress("glFlush");
			Assert.AreNotEqual(IntPtr.Zero, glFlushAddress);

			Delegate delegatePtr = Marshal.GetDelegateForFunctionPointer(glFlushAddress, typeof(glFlushDelegate));
			Assert.AreNotEqual(null, delegatePtr, "Marshal.GetDelegateForFunctionPointer has failed");

			pglFlush = (glFlushDelegate)delegatePtr;
			pglFlushHandle = glFlushAddress;

			IntPtr glEnableAddress = GetProcAddressGL.GetProcAddress("glFlush");
			Assert.AreNotEqual(IntPtr.Zero, glFlushAddress);

			Delegate glEnableDelegate = Marshal.GetDelegateForFunctionPointer(glEnableAddress, typeof(glEnableDelegate));
			Assert.AreNotEqual(null, delegatePtr, "Marshal.GetDelegateForFunctionPointer has failed");

			pglEnable = (glEnableDelegate)glEnableDelegate;
			pglEnableHandle = glEnableAddress;
		}

		/// <summary>
		/// Delegate for glFlush.
		/// </summary>
		[SuppressUnmanagedCodeSecurity()]
		internal delegate void glFlushDelegate();

		[SuppressUnmanagedCodeSecurity()]
		internal delegate void glEnableDelegate(Int32 cap);

		[Benchmark("Marshal.GetDelegateForFunctionPointer", Repetitions = PInvokeRepetitions)]
		public static void BenchmarkPInvoke_GetDelegateForFunctionPointer()
		{
			for (int i = 0; i < PInvokeRepetitionsInternal; i++) {
				pglFlush();
			}
#if ENABLE_ENABLE
			for (int i = 0; i < PInvokeRepetitionsInternal; i++) {
				pglEnable(Gl.TEXTURE_2D);
			}
#endif
		}

		/// <summary>
		/// Loads glFlush as a GL application should.
		/// </summary>
		/// <remarks>
		/// - This technique allows to have a thread storage for function pointers.
		/// - It can map multiple function pointers from different libraries.
		/// </remarks>
		[ThreadStatic]
		internal static glFlushDelegate pglFlush;

		[ThreadStatic]
		public static IntPtr pglFlushHandle;

		[ThreadStatic]
		internal static glEnableDelegate pglEnable;

		[ThreadStatic]
		public static IntPtr pglEnableHandle;

		#endregion

		#region Emit

		private static void Initialize_Emit()
		{
			ILGenerator gen;

			// glFlush
			DynamicMethod glFlushMethod = new DynamicMethod("glFlush", null, new Type[0], typeof(glFlushDelegate).Module);

			gen = glFlushMethod.GetILGenerator();
			// gen.Emit(OpCodes.Ldc_I8, (long)pglFlushHandle);
			gen.Emit(OpCodes.Ldsfld, typeof(BenchmarkPInvoke).GetField("pglFlushHandle", BindingFlags.Public | BindingFlags.Static));
			gen.Emit(OpCodes.Conv_I);
			gen.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, null, new Type[0]);
			gen.Emit(OpCodes.Ret);

			pglFlushEmit = (glFlushDelegate)glFlushMethod.CreateDelegate(typeof(glFlushDelegate));

			// glEnable
			DynamicMethod glEnableMethod = new DynamicMethod("glEnable", null, new Type[] { typeof(int) }, typeof(glEnableDelegate).Module);

			gen = glEnableMethod.GetILGenerator();
			gen.Emit(OpCodes.Ldarg_0);
			// gen.Emit(OpCodes.Ldc_I8, (long)pglEnableHandle);
			gen.Emit(OpCodes.Ldsfld, typeof(BenchmarkPInvoke).GetField("pglEnableHandle", BindingFlags.Public | BindingFlags.Static));
			gen.Emit(OpCodes.Conv_I);
			gen.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, null, new Type[] { typeof(int) });
			gen.Emit(OpCodes.Ret);

			pglEnableEmit = (glEnableDelegate)glEnableMethod.CreateDelegate(typeof(glEnableDelegate));
		}

		[Benchmark("Marshal.BenchmarkPInvoke_Emit", Repetitions = PInvokeRepetitions)]
		public static void BenchmarkPInvoke_Emit()
		{
			for (int i = 0; i < PInvokeRepetitionsInternal; i++) {
				pglFlushEmit();
			}
#if ENABLE_ENABLE
			for (int i = 0; i < PInvokeRepetitionsInternal; i++) {
				pglEnableEmit(Gl.TEXTURE_2D);
			}
#endif
		}

		[ThreadStatic]
		internal static glFlushDelegate pglFlushEmit;

		[ThreadStatic]
		internal static glEnableDelegate pglEnableEmit;

		#endregion

		#region OpenGL.Net

		/// <summary>
		/// Current OpenGL.Net implementation.
		/// </summary>
		[Benchmark("BenchmarkPInvoke_OpenGL.Net", Repetitions = PInvokeRepetitions)]
		public static void BenchmarkPInvoke_OpenGL_Net()
		{
			for (int i = 0; i < PInvokeRepetitionsInternal; i++) {
				// No arguments, no return value
				Gl.Flush();
			}

			for (int i = 0; i < PInvokeRepetitionsInternal; i++) {
				// One integer argument (in), no return value
				Gl.Enable(EnableCap.Texture2d);
			}
		}

		#endregion

		/// <summary>
		/// Number of repetitions.
		/// </summary>
		private const int PInvokeRepetitions = 1;

		/// <summary>
		/// Number of repetitions.
		/// </summary>
		private const int PInvokeRepetitionsInternal = 1 << 20;
	}
}
