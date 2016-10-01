
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

#pragma warning disable 618, 649, 1734

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	/// <summary>
	/// Modern OpenGL bindings.
	/// </summary>
	public partial class Gl : KhronosApi
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static Gl()
		{
			// Cache imports & delegates
			_Delegates = GetDelegateList(typeof(Gl));
			_ImportMap = GetImportMap(typeof(Gl));
			// Load procedures (OpenGL desktop by default) @todo Really necessary?
			LoadProcDelegates(_ImportMap, _Delegates);

			// Create temporary context for getting preliminary information on desktop systems
			using (INativeWindow nativeWindow = DeviceContext.CreateWindow()) {
				// Create device context
				_HiddenWindowDevice = DeviceContext.Create(nativeWindow.Handle);
				_HiddenWindowDevice.IncRef();

				// Create basic OpenGL context
				IntPtr renderContext;

				if      (_HiddenWindowDevice is WindowsDeviceContext)
					renderContext = CreateWinSimpleContext(_HiddenWindowDevice);
				else if (_HiddenWindowDevice is XServerDeviceContext)
					renderContext = CreateX11SimpleContext(_HiddenWindowDevice);
				else if (_HiddenWindowDevice is NativeDeviceContext)
					renderContext = CreateEglSimpleContext(_HiddenWindowDevice);
				else
					throw new NotImplementedException(String.Format("{0} is not a supported device context", _HiddenWindowDevice.GetType()));

				// Query OpenGL informations
				if (_HiddenWindowDevice.MakeCurrent(renderContext) == false)
					throw new InvalidOperationException("unable to make current");

				// Obtain current OpenGL implementation
				string glVersion = Gl.GetString(StringName.Version);
				_CurrentVersion = KhronosVersion.Parse(glVersion);

				// Obtain current OpenGL Shading Language version
				string glslVersion = Gl.GetString(StringName.ShadingLanguageVersion);
				_CurrentShadingVersion = GlslVersion.Parse(glslVersion);

				// Query OpenGL extensions (current OpenGL implementation, CurrentCaps)
				_CurrentExtensions = new Extensions();
				_CurrentExtensions.Query();
				// Query OpenGL limits
				_CurrentLimits = Limits.Query(_CurrentExtensions);

				if        (_HiddenWindowDevice is WindowsDeviceContext) {
					Wgl._CurrentExtensions = new Wgl.Extensions();
					Wgl._CurrentExtensions.Query((WindowsDeviceContext)_HiddenWindowDevice);
				} else if (_HiddenWindowDevice is XServerDeviceContext) {
					Glx._CurrentExtensions = new Glx.Extensions();
					Glx._CurrentExtensions.Query((XServerDeviceContext)_HiddenWindowDevice);
				} else if (_HiddenWindowDevice is NativeDeviceContext) {
					Egl._CurrentExtensions = new Egl.Extensions();
					Egl._CurrentExtensions.Query((NativeDeviceContext)_HiddenWindowDevice);
				}

				// Before deletion, make uncurrent
				_HiddenWindowDevice.MakeCurrent(IntPtr.Zero);
				// Detroy context
				if (_HiddenWindowDevice.DeleteContext(renderContext) == false)
					throw new InvalidOperationException("unable to delete OpenGL context");
			}
		}

		/// <summary>
		/// Initialize OpenGL namespace static environment. This method shall be called before any other classes methods.
		/// </summary>
		public static void Initialize() { }

		/// <summary>
		/// OpenGL version currently implemented.
		/// </summary>
		/// <remarks>
		/// Higher OpenGL versions versions cannot be requested to be implemented.
		/// </remarks>
		public static KhronosVersion CurrentVersion { get { return (_CurrentVersion); } }

		/// <summary>
		/// OpenGL version currently implemented.
		/// </summary>
		/// <remarks>
		/// Higher OpenGL versions versions cannot be requested to be implemented.
		/// </remarks>
		private static KhronosVersion _CurrentVersion;

		/// <summary>
		/// OpenGL Shading Language version currently implemented.
		/// </summary>
		/// <remarks>
		/// Higher OpenGL Shading Language versions cannot be requested to be implemented.
		/// </remarks>
		public static GlslVersion CurrentShadingVersion { get { return (_CurrentShadingVersion); } }

		/// <summary>
		/// OpenGL Shading Language version currently implemented.
		/// </summary>
		/// <remarks>
		/// Higher OpenGL Shading Language versions cannot be requested to be implemented.
		/// </remarks>
		private static GlslVersion _CurrentShadingVersion;

		/// <summary>
		/// OpenGL extension support.
		/// </summary>
		public static Extensions CurrentExtensions { get { return (_CurrentExtensions); } }

		/// <summary>
		/// OpenGL extension support.
		/// </summary>
		private static Extensions _CurrentExtensions;

		/// <summary>
		/// OpenGL limits.
		/// </summary>
		public static Limits CurrentLimits { get { return (_CurrentLimits); } }

		/// <summary>
		/// OpenGL limits.
		/// </summary>
		private static Limits _CurrentLimits;

		/// <summary>
		/// Creates an OpenGL context from a Windows platform.
		/// </summary>
		/// <returns>
		/// A <see cref="IDeviceContext"/> that specify the device context.
		/// </returns>
		private static IntPtr CreateWinSimpleContext(IDeviceContext rDevice)
		{
			WindowsDeviceContext winDeviceContext = (WindowsDeviceContext)rDevice;
			IntPtr rContext;

			// Define most compatible pixel format
			Wgl.PIXELFORMATDESCRIPTOR pfd = new Wgl.PIXELFORMATDESCRIPTOR(24);
			int pFormat;
			bool res;

			// Find pixel format match
			pfd.dwFlags |= Wgl.PixelFormatDescriptorFlags.DepthDontCare | Wgl.PixelFormatDescriptorFlags.DoublebufferDontCare | Wgl.PixelFormatDescriptorFlags.StereoDontCare;

			pFormat = Wgl.ChoosePixelFormat(winDeviceContext.DeviceContext, ref pfd);
			Debug.Assert(pFormat != 0);

			// Get exact description of the pixel format
			res = Wgl.DescribePixelFormat(winDeviceContext.DeviceContext, pFormat, (uint)pfd.nSize, ref pfd);
			Debug.Assert(res);

			// Set pixel format before creating OpenGL context
			res = Wgl.SetPixelFormat(winDeviceContext.DeviceContext, pFormat, ref pfd);
			Debug.Assert(res);

			// Create a dummy OpenGL context to retrieve initial informations.
			rContext = winDeviceContext.CreateContext(IntPtr.Zero);
			Debug.Assert(rContext != IntPtr.Zero);

			return (rContext);
		}

		/// <summary>
		/// Creates an OpenGL context from a Unix/Linux platform.
		/// </summary>
		/// <returns>
		/// A <see cref="IDeviceContext"/> that specify the device context.
		/// </returns>
		private static IntPtr CreateX11SimpleContext(IDeviceContext rDevice)
		{
			XServerDeviceContext x11DeviceCtx = (XServerDeviceContext)rDevice;
			IntPtr rContext;

			using (Glx.XLock xLock = new Glx.XLock(x11DeviceCtx.Display)) {
				int[] attributes = new int[] {
					Glx.RENDER_TYPE, (int)Glx.RGBA_BIT,
					0
				};

				// Get basic visual
				unsafe {
					int[] choosenConfigCount = new int[1];
					IntPtr* choosenConfigs = Glx.ChooseFBConfig(x11DeviceCtx.Display, x11DeviceCtx.Screen, attributes, choosenConfigCount);

					if (choosenConfigCount[0] == 0)
						throw new InvalidOperationException("unable to find basic visual");

					IntPtr choosenConfig = *choosenConfigs;

					x11DeviceCtx.XVisualInfo = Glx.GetVisualFromFBConfig(x11DeviceCtx.Display, choosenConfig);
					x11DeviceCtx.FBConfig = choosenConfig;

					Glx.UnsafeNativeMethods.XFree((IntPtr)choosenConfigs);
				}

				// Create direct context
				rContext = x11DeviceCtx.CreateContext(IntPtr.Zero);
				if (rContext == IntPtr.Zero) {
					// Fallback to not direct context
					rContext = Glx.CreateContext(x11DeviceCtx.Display, x11DeviceCtx.XVisualInfo, IntPtr.Zero, false);
				}

				if (rContext == IntPtr.Zero)
					throw new InvalidOperationException("unable to create context");

				return (rContext);
			}
		}

		/// <summary>
		/// Creates an OpenGL context from a Unix/Linux platform.
		/// </summary>
		/// <returns>
		/// A <see cref="IDeviceContext"/> that specify the device context.
		/// </returns>
		private static IntPtr CreateEglSimpleContext(IDeviceContext rDevice)
		{
			NativeDeviceContext eglDeviceCtx = (NativeDeviceContext)rDevice;
			IntPtr ctx;

			List<int> configAttribs = new List<int>();

			if (eglDeviceCtx.Version >= Egl.Version_120)
				configAttribs.AddRange(new int[] { Egl.RENDERABLE_TYPE, Egl.OPENGL_ES2_BIT });
			configAttribs.AddRange(new int[] {
				Egl.RED_SIZE, 8,
				Egl.GREEN_SIZE, 8,
				Egl.BLUE_SIZE, 8,
			});
			configAttribs.Add(Egl.NONE);

			int[] configCount = new int[1];
			IntPtr[] configs = new IntPtr[8];

			if (Egl.BindAPI(Egl.OPENGL_ES_API) == false)
				throw new InvalidOperationException("no ES API");

			if (Egl.ChooseConfig(eglDeviceCtx.Display, configAttribs.ToArray(), configs, configs.Length, configCount) == false)
				throw new InvalidOperationException("unable to choose configuration");
			if (configCount[0] == 0)
				throw new InvalidOperationException("no available configuration");

			List<int> contextAttribs = new List<int>();

			if (eglDeviceCtx.Version >= Egl.Version_130)
				contextAttribs.AddRange(new int[] { Egl.CONTEXT_CLIENT_VERSION, 2 });
			contextAttribs.Add(Egl.NONE);

			if ((ctx = Egl.CreateContext(eglDeviceCtx.Display, configs[configs.Length - 1], IntPtr.Zero, contextAttribs.ToArray())) == IntPtr.Zero)
				throw new InvalidOperationException("unable to create context");

			List<int> surfaceAttribs = new List<int>();

			surfaceAttribs.Add(Egl.NONE);
			// Egl.RENDER_BUFFER, Egl.BACK_BUFFER,

			eglDeviceCtx.Surface = Egl.CreateWindowSurface(eglDeviceCtx.Display, configs[configs.Length - 1], eglDeviceCtx.NativeWindow, surfaceAttribs.ToArray());

			return (ctx);
		}

		/// <summary>
		/// Device context handle created from <see cref="_HiddenWindow"/>.
		/// </summary>
		private static IDeviceContext _HiddenWindowDevice;

		#endregion

		#region Imports/Delegates Management

		/// <summary>
		/// Synchronize OpenGL delegates.
		/// </summary>
		public static void SyncDelegates()
		{
			LoadProcDelegates(_ImportMap, _Delegates);
		}

		/// <summary>
		/// Synchronize OpenGL ES delegates.
		/// </summary>
		public static void SyncEsDelegates()
		{
			LoadProcDelegates(LibraryEs, _ImportMap, _Delegates);
		}

		/// <summary>
		/// Default import library.
		/// </summary>
		private const string Library = "opengl32.dll";

		/// <summary>
		/// Default import library.
		/// </summary>
		private const string LibraryEs = "libGLESv2.dll";

		/// <summary>
		/// Imported functions delegates.
		/// </summary>
		private static List<FieldInfo> _Delegates;

		/// <summary>
		/// Build a string->MethodInfo map to speed up extension loading.
		/// </summary>
		internal static SortedList<string, MethodInfo> _ImportMap;

		#endregion

		#region Error Handling

		/// <summary>
		/// OpenGL error checking.
		/// </summary>
		/// <param name="returnValue">
		/// A <see cref="Object"/> that specifies the function returned value, if any.
		/// </param>
		[Conditional("DEBUG")]
		private static void DebugCheckErrors(object returnValue)
		{
			ErrorCode error = GetError();

			if (error != ErrorCode.NoError)
				throw new GlException(error);
		}

		#endregion

		#region Procedure Logging

		/// <summary>
		/// Query <see cref="Gl"/> enumeration names, for logging purposes.
		/// </summary>
		/// <remarks>
		/// After having called this method, the method <see cref="LogFunction"/> will output known enumeration
		/// names instead of the numerical value.
		/// </remarks>
		public static void QueryLogContext()
		{
			_LogContext = QueryLogContext(typeof(Gl));
		}

		/// <summary>
		/// Log an enumeration value.
		/// </summary>
		/// <param name="enumValue">
		/// A <see cref="Int32"/> that specifies the enumeration value.
		/// </param>
		/// <returns>
		/// It returns a <see cref="String"/> that represents <paramref name="enumValue"/> as hexadecimal value. If the
		/// name of the enumeration value is detected, it returns the relative OpenGL specification name.
		/// </returns>
		protected static new string LogEnumName(int enumValue)
		{
			string enumName;

			if (_LogContext.EnumNames != null && _LogContext.EnumNames.TryGetValue(enumValue, out enumName))
				return (enumName);
			else
				return (KhronosApi.LogEnumName(enumValue));
		}

		/// <summary>
		/// Log an enumeration value.
		/// </summary>
		/// <param name="enumValues">
		/// An array of <see cref="Int32"/> that specifies the enumeration values.
		/// </param>
		/// <returns>
		/// It returns a <see cref="String"/> that represents <paramref name="enumValues"/> as hexadecimal value.
		/// </returns>
		protected static new string LogEnumName(int[] enumValues)
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("{");
			foreach (int enumValue in enumValues)
				sb.AppendFormat("{0},", LogEnumName(enumValue));
			if (enumValues.Length > 0)
				sb.Remove(sb.Length - 1, 1);
			sb.Append("}");

			return (sb.ToString());
		}

		/// <summary>
		/// Log an bitmask value.
		/// </summary>
		/// <param name="bitmaskName">
		/// A <see cref="String"/> that specifies the enumeration bitmask name.
		/// </param>
		/// <param name="bitmaskValue">
		/// A <see cref="Int32"/> that specifies the enumeration bitmask value.
		/// </param>
		/// <returns>
		/// It returns a <see cref="String"/> that represents <paramref name="bitmaskValue"/>.
		/// </returns>
		protected static new string LogEnumBitmask(string bitmaskName, long bitmaskValue)
		{
			Dictionary<long, String> bitmaskNames;

			if (_LogContext.EnumBitmasks.TryGetValue(bitmaskName, out bitmaskNames) == false)
				return (KhronosApi.LogEnumBitmask(bitmaskName, bitmaskValue));

			return (KhronosApi.LogEnumBitmask(bitmaskValue, bitmaskNames));
		}

		/// <summary>
		/// Enumeration names indexed by their value.
		/// </summary>
		private static LogContext _LogContext = new LogContext();

		#endregion

		#region Hand-crafted Bindings

		/// <summary>
		/// The source of the generated debug messages.
		/// </summary>
		public enum DebugSource : int
		{
			/// <summary>
			/// The source of the generated message is the OpenGL API.
			/// </summary>
			Api =					Gl.DEBUG_SOURCE_API,

			/// <summary>
			/// The source of the generated message is the window system API.
			/// </summary>
			WindowSystem =			Gl.DEBUG_SOURCE_WINDOW_SYSTEM,

			/// <summary>
			/// The source of the generated message is a compiler for the shader language.
			/// </summary>
			ShaderCompiler =		Gl.DEBUG_SOURCE_SHADER_COMPILER,

			/// <summary>
			/// The source of the generated message is a third party component.
			/// </summary>
			ThirdParty =			Gl.DEBUG_SOURCE_THIRD_PARTY,

			/// <summary>
			/// The source of the generated message is the application itself.
			/// </summary>
			Application =			Gl.DEBUG_SOURCE_APPLICATION,

			/// <summary>
			/// The source of the generated message is not any source not listed in enumeration.
			/// </summary>
			Other =					Gl.DEBUG_SOURCE_OTHER,
		}

		/// <summary>
		/// The type of the generated debug messages.
		/// </summary>
		public enum DebugType : int
		{
			/// <summary>
			/// An error, typically from the API.
			/// </summary>
			Error =					Gl.DEBUG_TYPE_ERROR,

			/// <summary>
			/// Some behavior marked deprecated has been used.
			/// </summary>
			DeprecatedBehavior =	Gl.DEBUG_TYPE_DEPRECATED_BEHAVIOR,

			/// <summary>
			/// Something has invoked undefined behavior.
			/// </summary>
			UndefinedBehavior =		Gl.DEBUG_TYPE_UNDEFINED_BEHAVIOR,

			/// <summary>
			/// Some functionality the user relies upon is not portable.
			/// </summary>
			Portability =			Gl.DEBUG_TYPE_PORTABILITY,

			/// <summary>
			/// Code has triggered possible performance issues.
			/// </summary>
			Performance =			Gl.DEBUG_TYPE_PERFORMANCE,

			/// <summary>
			/// Command stream annotation.
			/// </summary>
			Marker =				Gl.DEBUG_TYPE_MARKER,

			/// <summary>
			/// Scoped group push.
			/// </summary>
			PushGroup =				Gl.DEBUG_TYPE_PUSH_GROUP,

			/// <summary>
			/// Scoped group pop.
			/// </summary>
			PopGroup =				Gl.DEBUG_TYPE_POP_GROUP,

			/// <summary>
			/// The type of the generated message is not any type not listed in enumeration.
			/// </summary>
			Other =					Gl.DEBUG_TYPE_OTHER,
		}

		/// <summary>
		/// The severity of the generated debug messages.
		/// </summary>
		public enum DebugSeverity : int
		{
			/// <summary>
			/// All OpenGL Errors, shader compilation/linking errors, or highly-dangerous undefined behavior.
			/// </summary>
			High =					Gl.DEBUG_SEVERITY_HIGH,

			/// <summary>
			/// Major performance warnings, shader compilation/linking warnings, or the use of deprecated functionality.
			/// </summary>
			Medium =				Gl.DEBUG_SEVERITY_MEDIUM,

			/// <summary>
			/// Redundant state change performance warning, or unimportant undefined behavior.
			/// </summary>
			Low =					Gl.DEBUG_SEVERITY_LOW,

			/// <summary>
			/// Anything that isn't an error or performance issue.
			/// </summary>
			Notification =			Gl.DEBUG_SEVERITY_NOTIFICATION,
		}

		/// <summary>
		/// Specify a callback to receive debugging messages from the GL.
		/// </summary>
		/// <param name="source">
		/// A <see cref="DebugSource"/> that specify the source of the message.
		/// </param>
		/// <param name="type">
		/// A <see cref="DebugType"/> that specify the type of the message.
		/// </param>
		/// <param name="id">
		/// A <see cref="UInt32"/> that specify the identifier of the message.
		/// </param>
		/// <param name="severity">
		/// A <see cref="DebugSeverity"/> that specify the severity of the message.
		/// </param>
		/// <param name="length">
		/// The length of the message.
		/// </param>
		/// <param name="message">
		/// A <see cref="IntPtr"/> that specify a pointer to a null-terminated ASCII C string, representing the content of the message.
		/// </param>
		/// <param name="userParam">
		/// A <see cref="IntPtr"/> that specify the user-specified parameter.
		/// </param>
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		public delegate void DebugProc(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, IntPtr message, IntPtr userParam);

		/// <summary>
		/// specify values to record in transform feedback buffers
		/// </summary>
		/// <param name="program">
		/// The name of the target program object.
		/// </param>
		/// <param name="varyings">
		/// An array of <paramref name="count"/> zero-terminated strings specifying the names of the varying variables to use for 
		/// transform feedback.
		/// </param>
		/// <param name="bufferMode">
		/// Identifies the mode used to capture the varying variables when transform feedback is active. <paramref 
		/// name="bufferMode"/> must be Gl.INTERLEAVED_ATTRIBS or Gl.SEPARATE_ATTRIBS.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not the name of a program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bufferMode"/> is Gl.SEPARATE_ATTRIBS and <paramref name="count"/> is 
		/// greater than the implementation-dependent limit Gl.MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS.
		/// </exception>
		/// <seealso cref="Gl.BeginTransformFeedback"/>
		/// <seealso cref="Gl.EndTransformFeedback"/>
		/// <seealso cref="Gl.GetTransformFeedbackVarying"/>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void TransformFeedbackVaryings(UInt32 program, IntPtr[] varyings, Int32 bufferMode)
		{
			unsafe
			{
				fixed (IntPtr* p_varyings = varyings)
				{
					Debug.Assert(Delegates.pglTransformFeedbackVaryings_Unmanaged != null, "pglTransformFeedbackVaryings not implemented");
					Delegates.pglTransformFeedbackVaryings_Unmanaged(program, (Int32)varyings.Length, p_varyings, bufferMode);
					LogFunction("glTransformFeedbackVaryings({0}, {1}, {2}, {3})", program, varyings.Length, LogValue(varyings), LogEnumName(bufferMode));
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTransformFeedbackVaryings_Unmanaged(UInt32 program, Int32 count, IntPtr* varyings, Int32 bufferMode);
			[AliasOf("glTransformFeedbackVaryings")]
			[AliasOf("glTransformFeedbackVaryingsEXT")]
			[ThreadStatic]
			internal static glTransformFeedbackVaryings_Unmanaged pglTransformFeedbackVaryings_Unmanaged;
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTransformFeedbackVaryings", ExactSpelling = true)]
			internal extern static void glTransformFeedbackVaryings_Unmanaged(UInt32 program, Int32 count, IntPtr* varyings, Int32 bufferMode);
		}

		#endregion
	}
}
