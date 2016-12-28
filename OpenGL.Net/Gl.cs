
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
			try {
				Initialize();
			} catch (NotSupportedException) {
				// Fail-safe
			}
		}

		/// <summary>
		/// Initialize OpenGL namespace static environment. This method shall be called before any other classes methods.
		/// </summary>
		public static void Initialize()
		{
			if (_Initialized == true)
				return; // Already initialized
			_Initialized = true;

#if DEBUG
			string envGlInit = Environment.GetEnvironmentVariable("GL_INIT");

			if (envGlInit != null && envGlInit == "NO")
				return;
#endif

			LogComment("OpenGL.Net is initializing");

			// Loader function			OS API			GL API
			// ------------------------------------------------------
			// Supported platform: Windows
			// wglGetProcAddress		WGL				GL
			// wglGetProcAddress		WGL				GLES2+ (with WGL_create_context_es(2)?_profile_EXT)
			// eglGetProcAddress		EGL(Angle)		GLES2+
			// ------------------------------------------------------
			// Supported platform: Linux
			// glXGetProcAddress		GLX				GL
			// glXGetProcAddress		GLX				GLES2+ (with GLX_create_context_es(2)?_profile_EXT)
			// ------------------------------------------------------
			// Supported platform: Android
			// eglGetProcAddress		EGL				GL
			// eglGetProcAddress		EGL				GLES2+

			try {
				// Create native window for getting preliminary information on desktop systems
				// This instance will be used for creating contexts without explictly specify a window
				_NativeWindow = DeviceContext.CreateHiddenWindow();

				// Create device context
				using (DeviceContext windowDevice = DeviceContext.Create()) {
					// Create basic OpenGL context
					IntPtr renderContext = windowDevice.CreateSimpleContext();
					if (renderContext == IntPtr.Zero)
						throw new NotImplementedException("unable to create a simple context");

					// Make contect current
					if (windowDevice.MakeCurrent(renderContext) == false)
						throw new InvalidOperationException("unable to make current", windowDevice.GetPlatformException());

					// Query OpenGL informations
					string glVersion = GetString(StringName.Version);
					_CurrentVersion = KhronosVersion.Parse(glVersion);

					// Obtain current OpenGL Shading Language version
					switch (_CurrentVersion.Api) {
						case KhronosVersion.ApiGl:
						case KhronosVersion.ApiGles2:
							string glslVersion = GetString(StringName.ShadingLanguageVersion);
							_CurrentShadingVersion = GlslVersion.Parse(glslVersion);
							break;
					}

					// Vendor/Render information
					_Vendor = GetString(StringName.Vendor);
					_Renderer = GetString(StringName.Renderer);

					// Query OpenGL extensions (current OpenGL implementation, CurrentCaps)
					_CurrentExtensions = new Extensions();
					_CurrentExtensions.Query();

					// Query OpenGL limits
					_CurrentLimits = Limits.Query(_CurrentExtensions);

					// Query platform extensions
					windowDevice.QueryPlatformExtensions();

					// Before deletion, make uncurrent
					windowDevice.MakeCurrent(IntPtr.Zero);
					// Detroy context
					if (windowDevice.DeleteContext(renderContext) == false)
						throw new InvalidOperationException("unable to delete OpenGL context");
				}

				LogComment("OpenGL.Net has been initialized");
			} catch (Exception excepton) {
				LogComment("Unable to initialize OpenGL.Net: {0}", excepton.ToString());
			}
		}

		/// <summary>
		/// Flag indicating whether <see cref="Gl"/> has been initialized.
		/// </summary>
		private static bool _Initialized;

		/// <summary>
		/// The native window used for initializing the OpenGL.Net state.
		/// </summary>
		internal static INativeWindow _NativeWindow;

		#endregion

		#region Versions, Extensions and Limits

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
		/// Get the OpenGL vendor.
		/// </summary>
		public static string CurrentVendor { get { return (_Vendor); } }

		/// <summary>
		/// OpenGL vendor.
		/// </summary>
		private static string _Vendor;

		/// <summary>
		/// Get the OpenGL renderer.
		/// </summary>
		public static string CurrentRenderer { get { return (_Renderer); } }

		/// <summary>
		/// OpenGL renderer.
		/// </summary>
		private static string _Renderer;

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

		#endregion

		#region Versions, Extensions and Limits Stacking

		/// <summary>
		/// Push current extensions.
		/// </summary>
		public static void PushExtensions()
		{
			// Enqueue the original state onto the stack...
			_StackExtensions.Push(_CurrentExtensions);
			// ...and copy the current one
			_CurrentExtensions = _CurrentExtensions.Clone();
		}

		/// <summary>
		/// Pop current extensions.
		/// </summary>
		public static void PopExtensions()
		{
			if (_StackExtensions.Count == 0)
				throw new InvalidOperationException("extensions stack underflow");
			_CurrentExtensions = _StackExtensions.Pop();
		}

		/// <summary>
		/// Stack of <see cref="Extensions"/> to emulate specific environments.
		/// </summary>
		private static readonly Stack<Extensions> _StackExtensions = new Stack<Extensions>();

		#endregion

		#region API Binding

		/// <summary>
		/// Bind the OpenGL delegates for the API corresponding to the current OpenGL context.
		/// </summary>
		public static void BindAPI()
		{
			BindAPI(DeviceContext.QueryContextVersion(), GetProcAddress.GetProcAddressGL);
		}

		/// <summary>
		/// Bind the OpenGL delegates to a specific API.
		/// </summary>
		/// <param name="version">
		/// A <see cref="KhronosVersion"/> that specifies the API to bind.
		/// </param>
		/// <param name="getProcAddress">
		/// The <see cref="IGetProcAddress"/> used for loading function pointers.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="version"/> or <paramref name="getProcAddress"/> is null.
		/// </exception>
		private static void BindAPI(KhronosVersion version, IGetProcAddress getProcAddress)
		{
			if (version == null)
				throw new ArgumentNullException("version");
			if (getProcAddress == null)
				throw new ArgumentNullException("getProcAddress");

			BindAPI<Gl>(GetPlatformLibrary(version), getProcAddress);
		}

		/// <summary>
		/// Bind a single OpenGL delegates to a specific API.
		/// </summary>
		/// <param name="version">
		/// A <see cref="KhronosVersion"/> that specifies the API to bind.
		/// </param>
		/// <param name="getProcAddress">
		/// The <see cref="IGetProcAddress"/> used for loading function pointers.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="version"/>, <paramref name="functionName"/> or <paramref name="getProcAddress"/> is null.
		/// </exception>
		internal static void BindAPIFunction(KhronosVersion version, string functionName, IGetProcAddress getProcAddress)
		{
			BindAPIFunction<Gl>(GetPlatformLibrary(version), functionName, getProcAddress);
		}

		/// <summary>
		/// Get the library name used for loading OpenGL functions.
		/// </summary>
		/// <param name="version">
		/// A <see cref="KhronosVersion"/> that specifies the API to bind.
		/// </param>
		/// <returns>
		/// It returns a <see cref="String"/> that specifies the library name to be used.
		/// </returns>
		private static string GetPlatformLibrary(KhronosVersion version)
		{
			switch (version.Api) {
				case KhronosVersion.ApiGl:
					switch (Platform.CurrentPlatformId) {
						case Platform.Id.Linux:
							return ("libGL.so.1");
						case Platform.Id.MacOS:
							return ("/usr/X11/lib/libGL.1.dylib");
						default:
							// EGL ignore library name
							return (Library);
					}
				case KhronosVersion.ApiGles1:
					switch (Platform.CurrentPlatformId) {
						case Platform.Id.Linux:
							return ("libGLESv2.so");
						default:
							return (Egl.IsRequired ? LibraryEs : Library);
					}
				case KhronosVersion.ApiGles2:
					switch (Platform.CurrentPlatformId) {
						case Platform.Id.Linux:
							return ("libGLESv2.so");
						default:
							return (Egl.IsRequired ? LibraryEs2 : Library);
					}
				default:
					throw new NotSupportedException(String.Format("binding API for OpenGL {0} not supported", version));
			}
		}

		/// <summary>
		/// Default import library.
		/// </summary>
		internal const string Library = "opengl32.dll";

		/// <summary>
		/// Default import library.
		/// </summary>
		internal const string LibraryEs = "libGLESv1_CM.dll";

		/// <summary>
		/// Default import library.
		/// </summary>
		internal const string LibraryEs2 = "libGLESv2.dll";

		#endregion

		#region Error Handling

		/// <summary>
		/// OpenGL error checking.
		/// </summary>
		/// <param name="returnValue">
		/// A <see cref="Object"/> that specifies the function returned value, if any.
		/// </param>
		[Conditional("GL_DEBUG")]
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
