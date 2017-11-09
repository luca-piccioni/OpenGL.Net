
// Copyright (C) 2015-2017 Luca Piccioni
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

#pragma warning disable 618, 649
//, 1734

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;

using Khronos;

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
#if !NETSTANDARD1_1
			// Optional initialization
			string envGlStaticInit = Environment.GetEnvironmentVariable("OPENGL_NET_GL_STATIC_INIT");
			if (envGlStaticInit != null && envGlStaticInit == "NO")
				return;
#endif
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
#if !NETSTANDARD1_1
			// Optional initialization
			string envGlInit = Environment.GetEnvironmentVariable("OPENGL_NET_INIT");
			if (envGlInit != null && envGlInit == "NO")
				return;
#endif
			// Environment options
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
			// eglGetProcAddress		EGL				GLES2+
			// ------------------------------------------------------
			// Supported platform: Android
			// eglGetProcAddress		EGL				GL
			// eglGetProcAddress		EGL				GLES2+

			try {
#if !MONODROID
				// Determine whether use EGL as device context backend
				if (Egl.IsAvailable) {
					switch (Platform.CurrentPlatformId) {
						case Platform.Id.Linux:
							if (Glx.IsAvailable == false)
								Egl.IsRequired = true;
							break;
					}
				}
#endif

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

#if !MONODROID
					// Reload platform function pointers, if required
					if (Egl.IsRequired == false) {
						switch (Platform.CurrentPlatformId) {
							case Platform.Id.WindowsNT:
								Wgl.BindAPI();
								break;
						}
					}
#endif

					// Query OpenGL informations
					string glVersion = GetString(StringName.Version);
					_CurrentVersion = KhronosVersion.Parse(glVersion);

					// Query OpenGL extensions (current OpenGL implementation, CurrentCaps)
					_CurrentExtensions = new Extensions();
					_CurrentExtensions.Query();
					// Query platform extensions
					windowDevice.QueryPlatformExtensions();
					// Query OpenGL limits
					_CurrentLimits = Limits.Query(Gl.CurrentVersion, _CurrentExtensions);

					// Obtain current OpenGL Shading Language version
					string glslVersion = null;

					switch (_CurrentVersion.Api) {
						case KhronosVersion.ApiGl:
							if (_CurrentVersion >= Version_200 || _CurrentExtensions.ShadingLanguage100_ARB)
								glslVersion = GetString(StringName.ShadingLanguageVersion);
							break;
						case KhronosVersion.ApiGles2:
							glslVersion = GetString(StringName.ShadingLanguageVersion);
							break;
					}

					if (glslVersion != null)
						_CurrentShadingVersion = GlslVersion.Parse(glslVersion, _CurrentVersion.Api);

					// Vendor/Render information
					_Vendor = GetString(StringName.Vendor);
					_Renderer = GetString(StringName.Renderer);

					if (EnvDebug || EnvExperimental) {
						Debug.Assert(CurrentVersion != null && CurrentExtensions != null);
						CheckExtensionCommands<Gl>(CurrentVersion, CurrentExtensions, EnvExperimental);
					}

					// Before deletion, make uncurrent
					windowDevice.MakeCurrent(IntPtr.Zero);
					// Detroy context
					if (windowDevice.DeleteContext(renderContext) == false)
						throw new InvalidOperationException("unable to delete OpenGL context");
				}

				LogComment("OpenGL.Net has been initialized");
			} catch (Exception excepton) {
				_InitializationException = excepton;
				LogComment("Unable to initialize OpenGL.Net: {0}", _InitializationException.ToString());
			}
		}

		/// <summary>
		/// Flag indicating whether <see cref="Gl"/> has been initialized.
		/// </summary>
		private static bool _Initialized;

		/// <summary>
		/// Eventual exception raised during Gl initialization.
		/// </summary>
		internal static Exception _InitializationException;

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

		#region Experimental Extensions

		/// <summary>
		/// Check whether commands implemented by the current driver have a corresponding extension not enabled by driver.
		/// </summary>
		public static void EnableExperimentalExtensions()
		{
			CheckExtensionCommands<Gl>(CurrentVersion, CurrentExtensions, true);
		}

		/// <summary>
		/// Check whether commands implemented by the current driver have a corresponding extension not enabled by driver.
		/// </summary>
		public static void EnableExperimentalExtensions(KhronosVersion version, Extensions extensions)
		{
			CheckExtensionCommands<Gl>(version, extensions, true);
		}

		#endregion

		#region API Binding

		/// <summary>
		/// Bind the OpenGL delegates for the API corresponding to the current OpenGL context.
		/// </summary>
		public static void BindAPI()
		{
			BindAPI(QueryContextVersionCore(), CurrentExtensions);
		}

		/// <summary>
		/// Bind the OpenGL delegates to a specific API.
		/// </summary>
		/// <param name="version">
		/// A <see cref="KhronosVersion"/> that specifies the API to bind.
		/// </param>
		/// <param name="extensions">
		/// A <see cref="KhronosApi.ExtensionsCollection"/> that specifies the extensions supported. It can be null.
		/// </param>
		public static void BindAPI(KhronosVersion version, ExtensionsCollection extensions)
		{
			if (version == null)
				throw new ArgumentNullException("version");

			BindAPI<Gl>(GetPlatformLibrary(version), GetProcAddressGLOS, version, extensions);
		}

		/// <summary>
		/// Query the version of the current OpenGL context.
		/// </summary>
		/// <returns>
		/// It returns the <see cref="KhronosVersion"/> specifying the actual version of the context current on this thread.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if no GL context is current on the calling thread.
		/// </exception>
		public static KhronosVersion QueryContextVersion()
		{
			IntPtr ctx = DeviceContext.GetCurrentContext();
			if (ctx == IntPtr.Zero)
				throw new InvalidOperationException("no current context");

			// Parse version string (effective for detecting Desktop and ES contextes)
			KhronosVersion glversion = KhronosVersion.Parse(Gl.GetString(StringName.Version));

			// Context profile
			if (glversion.Api == KhronosVersion.ApiGl && glversion >= Gl.Version_320) {
				string glProfile = null;
				int ctxProfile = 0;

				Gl.Get(Gl.CONTEXT_PROFILE_MASK, out ctxProfile);

				if     ((ctxProfile & Gl.CONTEXT_COMPATIBILITY_PROFILE_BIT) != 0)
					glProfile = KhronosVersion.ProfileCompatibility;
				else if ((ctxProfile & Gl.CONTEXT_CORE_PROFILE_BIT) != 0)
					glProfile = KhronosVersion.ProfileCore;
				else
					glProfile = KhronosVersion.ProfileCompatibility;

				return (new KhronosVersion(glversion, glProfile));
			} else
				return (new KhronosVersion(glversion, KhronosVersion.ProfileCompatibility));
		}

		/// <summary>
		/// Query the version of the current OpenGL context.
		/// </summary>
		/// <returns>
		/// It returns the <see cref="KhronosVersion"/> specifying the actual version of the context current on this thread.
		/// </returns>
		private static KhronosVersion QueryContextVersionCore()
		{
			// Load minimal Gl functions for querying information
			if (Egl.IsRequired == false) {
				BindAPIFunction(Gl.Version_100, null, "glGetError");
				BindAPIFunction(Gl.Version_100, null, "glGetString");
				BindAPIFunction(Gl.Version_100, null, "glGetIntegerv");
			} else {
				// ???
				BindAPIFunction(Gl.Version_320_ES, null, "glGetError");
				BindAPIFunction(Gl.Version_320_ES, null, "glGetString");
				BindAPIFunction(Gl.Version_320_ES, null, "glGetIntegerv");
			}

			return (QueryContextVersion());
		}

		/// <summary>
		/// Bind a single OpenGL delegates to a specific API.
		/// </summary>
		/// <param name="version">
		/// A <see cref="KhronosVersion"/> that specifies the API to bind.
		/// </param>
		/// <param name="extensions">
		/// A <see cref="ExtensionsCollection"/> that specifies the extensions supported. It can be null.
		/// </param>
		/// <param name="functionName">
		/// A <see cref="String"/> that specifies the name of the function to bind.
		/// </param>
		internal static void BindAPIFunction(KhronosVersion version, ExtensionsCollection extensions, string functionName)
		{
            GetAddressDelegate getAddrDelegate = GetProcAddressGLOS;

            switch (Platform.CurrentPlatformId) {
                case Platform.Id.Linux:
                    getAddrDelegate = GetProcAddressOS;
                    break;
            }

			BindAPIFunction<Gl>(GetPlatformLibrary(version), functionName, getAddrDelegate, version, extensions);
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
				case KhronosVersion.ApiGlsc2:
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
		public static void CheckErrors()
		{
			ErrorCode error = GetError();

			if (error != ErrorCode.NoError)
				throw new GlException(error);
		}

		/// <summary>
		/// OpenGL error checking.
		/// </summary>
		/// <param name="returnValue">
		/// A <see cref="Object"/> that specifies the function returned value, if any.
		/// </param>
		[Conditional("GL_DEBUG")]
		private static void DebugCheckErrors(object returnValue)
		{
			CheckErrors();
		}

		#endregion

		#region Command Logging

		/// <summary>
		/// Load an API command call.
		/// </summary>
		/// <param name="name">
		/// A <see cref="String"/> that specifies the name of the API command.
		/// </param>
		/// <param name="returnValue">
		/// A <see cref="Object"/> that specifies the returned value, if any.
		/// </param>
		/// <param name="args">
		/// A <see cref="T:Object[]"/> that specifies the API command arguments, if any.
		/// </param>
		[Conditional("GL_DEBUG")]
		protected static new void LogCommand(string name, object returnValue, params object[] args)
		{
			if (_LogContext == null)
				_LogContext = new KhronosLogContext(typeof(Gl));
			RaiseLog(new KhronosLogEventArgs(_LogContext, name, args, returnValue));
		}

		/// <summary>
		/// Context for logging enumerant names instead of numerical values.
		/// </summary>
		private static KhronosLogContext _LogContext;

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

			/// <summary>
			/// Special value for <see cref="Gl.DebugMessageControl"/>.
			/// </summary>
			DontCare =				Gl.DONT_CARE,
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

			/// <summary>
			/// Special value for <see cref="Gl.DebugMessageControl"/>.
			/// </summary>
			DontCare =				Gl.DONT_CARE,
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

			/// <summary>
			/// Special value for <see cref="Gl.DebugMessageControl"/>.
			/// </summary>
			DontCare =				Gl.DONT_CARE,
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
		/// 
		/// </summary>
		/// <returns></returns>
		public delegate IntPtr VulkanProc();

		/// <summary>
		/// specify values to record in transform feedback buffers
		/// </summary>
		/// <param name="program">
		/// The name of the target program object.
		/// </param>
		/// <param name="varyings">
		/// An array of zero-terminated strings specifying the names of the varying variables to use for 
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
		/// Gl.INVALID_VALUE is generated if <paramref name="bufferMode"/> is Gl.SEPARATE_ATTRIBS and the length of <paramref name="varyings"/> is 
		/// greater than the implementation-dependent limit Gl.MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS.
		/// </exception>
		/// <seealso cref="Gl.BeginTransformFeedback"/>
		/// <seealso cref="Gl.EndTransformFeedback"/>
		/// <seealso cref="Gl.GetTransformFeedbackVarying"/>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public static void TransformFeedbackVaryings(UInt32 program, IntPtr[] varyings, Int32 bufferMode)
		{
			unsafe
			{
				fixed (IntPtr* p_varyings = varyings)
				{
					Debug.Assert(Delegates.pglTransformFeedbackVaryings_Unmanaged != null, "pglTransformFeedbackVaryings not implemented");
					Delegates.pglTransformFeedbackVaryings_Unmanaged(program, (Int32)varyings.Length, p_varyings, bufferMode);
					LogCommand("glTransformFeedbackVaryings", null, program, varyings.Length, varyings, bufferMode);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTransformFeedbackVaryings_Unmanaged(UInt32 program, Int32 count, IntPtr* varyings, Int32 bufferMode);

			[RequiredByFeature("GL_VERSION_3_0", EntryPoint = "glTransformFeedbackVaryings")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2", EntryPoint = "glTransformFeedbackVaryings")]
			[RequiredByFeature("GL_EXT_transform_feedback", EntryPoint = "glTransformFeedbackVaryingsEXT")]
			[ThreadStatic]
			internal static glTransformFeedbackVaryings_Unmanaged pglTransformFeedbackVaryings_Unmanaged;
		}

		#endregion
	}
}
