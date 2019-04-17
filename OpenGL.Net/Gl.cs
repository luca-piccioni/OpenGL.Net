
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
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security;

using Khronos;

// ReSharper disable InheritdocConsiderUsage
// ReSharper disable SwitchStatementMissingSomeCases
// ReSharper disable RedundantIfElseBlock

namespace OpenGL
{
	/// <summary>
	/// Modern OpenGL bindings.
	/// </summary>
	[SuppressMessage("ReSharper", "InconsistentNaming")]
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
			if (_Initialized)
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
					// Note: on Linux without GLX
					if (Platform.CurrentPlatformId == Platform.Id.Linux && Glx.IsAvailable == false)
						Egl.IsRequired = true;
#if !NETSTANDARD1_1
					// Explict initialization
					string envPlatform = Environment.GetEnvironmentVariable("OPENGL_NET_PLATFORM");
					if (envPlatform != null && envPlatform == "EGL")
						Egl.IsRequired = true;
#endif
				}
#endif

				// Create native window for getting preliminary information on desktop systems
				// This instance will be used for creating contexts without explictly specify a window
				NativeWindow = DeviceContext.CreateHiddenWindow();

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
					if (Egl.IsRequired == false && Platform.CurrentPlatformId == Platform.Id.WindowsNT)
						Wgl.BindAPI();
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
					_CurrentLimits = Limits.Query(CurrentVersion, _CurrentExtensions);

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
				InitializationException = excepton;
				LogComment($"Unable to initialize OpenGL.Net: {InitializationException}");
			}
		}

		/// <summary>
		/// Flag indicating whether <see cref="Gl"/> has been initialized.
		/// </summary>
		private static bool _Initialized;

		/// <summary>
		/// Eventual exception raised during Gl initialization.
		/// </summary>
		internal static Exception InitializationException;

		/// <summary>
		/// The native window used for initializing the OpenGL.Net state.
		/// </summary>
		internal static INativeWindow NativeWindow;

		#endregion

		#region Versions, Extensions and Limits

		/// <summary>
		/// OpenGL version currently implemented.
		/// </summary>
		/// <remarks>
		/// Higher OpenGL versions versions cannot be requested to be implemented.
		/// </remarks>
		public static KhronosVersion CurrentVersion => _CurrentVersion;

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
		public static GlslVersion CurrentShadingVersion => _CurrentShadingVersion;

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
		public static string CurrentVendor => _Vendor;

		/// <summary>
		/// OpenGL vendor.
		/// </summary>
		private static string _Vendor;

		/// <summary>
		/// Get the OpenGL renderer.
		/// </summary>
		public static string CurrentRenderer => _Renderer;

		/// <summary>
		/// OpenGL renderer.
		/// </summary>
		private static string _Renderer;

		/// <summary>
		/// OpenGL extension support.
		/// </summary>
		public static Extensions CurrentExtensions => _CurrentExtensions;

		/// <summary>
		/// OpenGL extension support.
		/// </summary>
		private static Extensions _CurrentExtensions;

		/// <summary>
		/// OpenGL limits.
		/// </summary>
		public static Limits CurrentLimits => _CurrentLimits;

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
		/// Get or set the delegate used for loading function pointers for this API.
		/// </summary>
		public GetAddressDelegate GetFunctionPointerDelegate
		{
			get { return _GetAddressDelegate; }
			set { _GetAddressDelegate = value ?? GetProcAddressGLOS; }
		}

		/// <summary>
		/// Delegate used for loading function pointers for this API.
		/// </summary>
		private static GetAddressDelegate _GetAddressDelegate = GetProcAddressGLOS;

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
		/// A <see cref="Khronos.KhronosApi.ExtensionsCollection"/> that specifies the extensions supported. It can be null.
		/// </param>
		public static void BindAPI(KhronosVersion version, ExtensionsCollection extensions)
		{
			if (version == null)
				throw new ArgumentNullException(nameof(version));

			BindAPI<Gl>(GetPlatformLibrary(version), _GetAddressDelegate, version, extensions);
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
			// Parse version string (effective for detecting Desktop and ES contextes)
			KhronosVersion glversion = KhronosVersion.Parse(GetString(StringName.Version));

			// Context profile
			if (glversion.Api == KhronosVersion.ApiGl && glversion >= Version_320) {
				string glProfile;
				int ctxProfile;

				Get(CONTEXT_PROFILE_MASK, out ctxProfile);

				if     ((ctxProfile & CONTEXT_COMPATIBILITY_PROFILE_BIT) != 0)
					glProfile = KhronosVersion.ProfileCompatibility;
				else if ((ctxProfile & CONTEXT_CORE_PROFILE_BIT) != 0)
					glProfile = KhronosVersion.ProfileCore;
				else
					glProfile = KhronosVersion.ProfileCompatibility;

				return new KhronosVersion(glversion, glProfile);
			} else
				return new KhronosVersion(glversion, KhronosVersion.ProfileCompatibility);
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
				BindAPIFunction(Version_100, null, "glGetError");
				BindAPIFunction(Version_100, null, "glGetString");
				BindAPIFunction(Version_100, null, "glGetIntegerv");
			} else {
				// ???
				BindAPIFunction(Version_320_ES, null, "glGetError");
				BindAPIFunction(Version_320_ES, null, "glGetString");
				BindAPIFunction(Version_320_ES, null, "glGetIntegerv");
			}

			return QueryContextVersion();
		}

		/// <summary>
		/// Bind a single OpenGL delegates to a specific API.
		/// </summary>
		/// <param name="version">
		/// A <see cref="KhronosVersion"/> that specifies the API to bind.
		/// </param>
		/// <param name="extensions">
		/// A <see cref="Khronos.KhronosApi.ExtensionsCollection"/> that specifies the extensions supported. It can be null.
		/// </param>
		/// <param name="functionName">
		/// A <see cref="String"/> that specifies the name of the function to bind.
		/// </param>
		internal static void BindAPIFunction(KhronosVersion version, ExtensionsCollection extensions, string functionName)
		{
			BindAPIFunction<Gl>(GetPlatformLibrary(version), functionName, _GetAddressDelegate, version, extensions);
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
							return "libGL.so.1";
						case Platform.Id.MacOS:
							return "/usr/X11/lib/libGL.1.dylib";
						default:
							// EGL ignore library name
							return Library;
					}
				case KhronosVersion.ApiGles1:
					switch (Platform.CurrentPlatformId) {
						case Platform.Id.Linux:
							return "libGLESv2.so";
						default:
							return Egl.IsRequired ? LibraryEs : Library;
					}
				case KhronosVersion.ApiGles2:
					switch (Platform.CurrentPlatformId) {
						case Platform.Id.Linux:
							return "libGLESv2.so";
						default:
							return Egl.IsRequired ? LibraryEs2 : Library;
					}
				default:
					throw new NotSupportedException($"binding API for OpenGL {version} not supported");
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
		/// Flush GL errors queue.
		/// </summary>
		private static void ClearErrors()
		{
			while (GetError() != ErrorCode.NoError)
				// ReSharper disable once EmptyEmbeddedStatement
				;
		}

		/// <summary>
		/// OpenGL error checking.
		/// </summary>
		/// <param name="returnValue">
		/// A <see cref="Object"/> that specifies the function returned value, if any.
		/// </param>
		[Conditional("GL_DEBUG")]
		// ReSharper disable once UnusedParameter.Local
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
		protected new static void LogCommand(string name, object returnValue, params object[] args)
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
		public static void TransformFeedbackVaryings(uint program, IntPtr[] varyings, int bufferMode)
		{
			unsafe
			{
				fixed (IntPtr* p_varyings = varyings)
				{
					Debug.Assert(Delegates.pglTransformFeedbackVaryings_Unmanaged != null, "pglTransformFeedbackVaryings not implemented");
					Delegates.pglTransformFeedbackVaryings_Unmanaged(program, varyings.Length, p_varyings, bufferMode);
					LogCommand("glTransformFeedbackVaryings", null, program, varyings.Length, varyings, bufferMode);
				}
			}
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glTransformFeedbackVaryings_Unmanaged(uint program, int count, IntPtr* varyings, int bufferMode);

			[RequiredByFeature("GL_VERSION_3_0", EntryPoint = "glTransformFeedbackVaryings")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2", EntryPoint = "glTransformFeedbackVaryings")]
			[RequiredByFeature("GL_EXT_transform_feedback", EntryPoint = "glTransformFeedbackVaryingsEXT")]
			[ThreadStatic]
			internal static glTransformFeedbackVaryings_Unmanaged pglTransformFeedbackVaryings_Unmanaged;
		}

		#endregion
	}
}
