
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

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;

using Khronos;

namespace OpenGL
{
	/// <summary>
	/// The GL Utility library.
	/// </summary>
	public class Glu : KhronosApi
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static Glu()
		{
			// Load procedures
			string platformLibrary = GetPlatformLibrary();
			try {
				LogComment("Querying GLU from {0}", platformLibrary);
				BindAPI<Glu>(platformLibrary, GetProcAddressOS, null);
				LogComment("GLU availability: {0}", IsAvailable);
			} catch (Exception exception) {
				/* Fail-safe (it may fail due Egl access) */
				LogComment("GLU not available:\n{0}", exception.ToString());
			}
		}

		#endregion

		#region API Binding

		/// <summary>
		/// Get whether OpenWF Composition layer is avaialable.
		/// </summary>
		public static bool IsAvailable { get { return (Delegates.pgluNewTess != null); } }

		/// <summary>
		/// Get the library name used for loading OpenGL functions.
		/// </summary>
		/// <returns>
		/// It returns a <see cref="String"/> that specifies the library name to be used.
		/// </returns>
		private static string GetPlatformLibrary()
		{
			switch (Platform.CurrentPlatformId) {
				default:
					return (Library);
			}
		}

		/// <summary>
		/// Default import library.
		/// </summary>
		internal const string Library = "Glu32.dll";

		#endregion

		#region Error Handling

		/// <summary>
		/// GLU error checking.
		/// </summary>
		public static void CheckErrors()
		{
			
		}

		/// <summary>
		/// GLU error checking.
		/// </summary>
		private static void DebugCheckErrors(object returnValue)
		{
			
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
				_LogContext = new KhronosLogContext(typeof(Glu));
			RaiseLog(new KhronosLogEventArgs(_LogContext, name, args, returnValue));
		}

		/// <summary>
		/// Context for logging enumerant names instead of numerical values.
		/// </summary>
		private static KhronosLogContext _LogContext;

		#endregion

		#region GLU Constants

		/* Boolean */
		public const int FALSE = 0;
		public const int TRUE = 1;

		/* StringName */
		public const int VERSION = 100800;
		public const int EXTENSIONS = 100801;

		/* ErrorCode */
		public const int INVALID_ENUM = 100900;
		public const int INVALID_VALUE = 100901;
		public const int OUT_OF_MEMORY = 100902;
		public const int INCOMPATIBLE_GL_VERSION = 100903;
		public const int INVALID_OPERATION = 100904;

		/* NurbsDisplay */
		/*      GLU_FILL */
		public const int OUTLINE_POLYGON = 100240;
		public const int OUTLINE_PATCH = 100241;

		/* NurbsCallback */
		public const int NURBS_ERROR = 100103;
		public const int ERROR = 100103;
		public const int NURBS_BEGIN = 100164;
		public const int NURBS_BEGIN_EXT = 100164;
		public const int NURBS_VERTEX = 100165;
		public const int NURBS_VERTEX_EXT = 100165;
		public const int NURBS_NORMAL = 100166;
		public const int NURBS_NORMAL_EXT = 100166;
		public const int NURBS_COLOR = 100167;
		public const int NURBS_COLOR_EXT = 100167;
		public const int NURBS_TEXTURE_COORD = 100168;
		public const int NURBS_TEX_COORD_EXT = 100168;
		public const int NURBS_END = 100169;
		public const int NURBS_END_EXT = 100169;
		public const int NURBS_BEGIN_DATA = 100170;
		public const int NURBS_BEGIN_DATA_EXT = 100170;
		public const int NURBS_VERTEX_DATA = 100171;
		public const int NURBS_VERTEX_DATA_EXT = 100171;
		public const int NURBS_NORMAL_DATA = 100172;
		public const int NURBS_NORMAL_DATA_EXT = 100172;
		public const int NURBS_COLOR_DATA = 100173;
		public const int NURBS_COLOR_DATA_EXT = 100173;
		public const int NURBS_TEXTURE_COORD_DATA = 100174;
		public const int NURBS_TEX_COORD_DATA_EXT = 100174;
		public const int NURBS_END_DATA = 100175;
		public const int NURBS_END_DATA_EXT = 100175;

		/* NurbsError */
		public const int NURBS_ERROR1 = 100251;

		/* NurbsProperty */
		public const int AUTO_LOAD_MATRIX = 100200;
		public const int CULLING = 100201;
		public const int SAMPLING_TOLERANCE = 100203;
		public const int DISPLAY_MODE = 100204;
		public const int PARAMETRIC_TOLERANCE = 100202;
		public const int SAMPLING_METHOD = 100205;
		public const int U_STEP = 100206;
		public const int V_STEP = 100207;
		public const int NURBS_MODE = 100160;
		public const int NURBS_MODE_EXT = 100160;
		public const int NURBS_TESSELLATOR = 100161;
		public const int NURBS_TESSELLATOR_EXT = 100161;
		public const int NURBS_RENDERER = 100162;
		public const int NURBS_RENDERER_EXT = 100162;

		/* NurbsSampling */
		public const int OBJECT_PARAMETRIC_ERROR = 100208;
		public const int OBJECT_PARAMETRIC_ERROR_EXT = 100208;
		public const int OBJECT_PATH_LENGTH = 100209;
		public const int OBJECT_PATH_LENGTH_EXT = 100209;
		public const int PATH_LENGTH = 100215;
		public const int PARAMETRIC_ERROR = 100216;
		public const int DOMAIN_DISTANCE = 100217;

		/* NurbsTrim */
		public const int MAP1_TRIM_2 = 100210;
		public const int MAP1_TRIM_3 = 100211;

		/* QuadricDrawStyle */
		public const int POINT = 100010;
		public const int LINE = 100011;
		public const int FILL = 100012;
		public const int SILHOUETTE = 100013;

		/* QuadricCallback */
		/*      GLU_ERROR */

		/* QuadricNormal */
		public const int SMOOTH = 100000;
		public const int FLAT = 100001;
		public const int NONE = 100002;

		/* QuadricOrientation */
		public const int OUTSIDE = 100020;
		public const int INSIDE = 100021;

		/* TessCallback */
		public const int TESS_BEGIN = 100100;
		public const int BEGIN = 100100;
		public const int TESS_VERTEX = 100101;
		public const int VERTEX = 100101;
		public const int TESS_END = 100102;
		public const int END = 100102;
		public const int TESS_ERROR = 100103;
		public const int TESS_EDGE_FLAG = 100104;
		public const int EDGE_FLAG = 100104;
		public const int TESS_COMBINE = 100105;
		public const int TESS_BEGIN_DATA = 100106;
		public const int TESS_VERTEX_DATA = 100107;
		public const int TESS_END_DATA = 100108;
		public const int TESS_ERROR_DATA = 100109;
		public const int TESS_EDGE_FLAG_DATA = 100110;
		public const int TESS_COMBINE_DATA = 100111;

		/* TessContour */
		public const int CW = 100120;
		public const int CCW = 100121;
		public const int INTERIOR = 100122;
		public const int EXTERIOR = 100123;
		public const int UNKNOWN = 100124;

		/* TessProperty */
		public const int TESS_WINDING_RULE = 100140;
		public const int TESS_BOUNDARY_ONLY = 100141;
		public const int TESS_TOLERANCE = 100142;

		/* TessError */
		public const int TESS_ERROR1 = 100151;
		public const int TESS_ERROR2 = 100152;
		public const int TESS_ERROR3 = 100153;
		public const int TESS_ERROR4 = 100154;
		public const int TESS_ERROR5 = 100155;
		public const int TESS_ERROR6 = 100156;
		public const int TESS_ERROR7 = 100157;
		public const int TESS_ERROR8 = 100158;
		public const int TESS_MISSING_BEGIN_POLYGON = 100151;
		public const int TESS_MISSING_BEGIN_CONTOUR = 100152;
		public const int TESS_MISSING_END_POLYGON = 100153;
		public const int TESS_MISSING_END_CONTOUR = 100154;
		public const int TESS_COORD_TOO_LARGE = 100155;
		public const int TESS_NEED_COMBINE_CALLBACK = 100156;

		/* TessWinding */
		public const int TESS_WINDING_ODD = 100130;
		public const int TESS_WINDING_NONZERO = 100131;
		public const int TESS_WINDING_POSITIVE = 100132;
		public const int TESS_WINDING_NEGATIVE = 100133;
		public const int TESS_WINDING_ABS_GEQ_TWO = 100134;

		#endregion

		#region GLU Enumerations

		public enum StringName
		{
			Version = 100800,
			Extensions = 100801,
		}

		public enum ErrorCode
		{
			InvalidEnum = 100900,
			InvalidValue = 100901,
			OutOfMemory = 100902,
			IncompatibleGL_Version = 100903,
			InvalidOperation = 100904,
		}

		/* NurbsDisplay */
		/*      GLU_FILL */
		public enum NurbsDisplay
		{
			OutlinePolygon = 100240,
			OutlinePatch = 100241,
		}

		/* NurbsCallback */
		public enum NurbsCallback
		{
			Error = 100103,
			Begin = 100164,
			Vertex = 100165,
			Normal = 100166,
			Color = 100167,
			TextureCoord = 100168,
			End = 100169,
			BeginData = 100170,
			VertexData = 100171,
			NormalData = 100172,
			ColorData = 100173,
			TextureCoordData = 100174,
			EndData = 100175,
		}

		/* NurbsError */
		public enum NurbsError
		{
			NurbsError1 = 100251,
		}

		/* NurbsProperty */
		public enum NurbsProperty
		{
			AutoLoadMatrix = 100200,
			Culling = 100201,
			SamplingTolerance = 100203,
			DisplayMode = 100204,
			ParametricTolerance = 100202,
			SamplingMethod = 100205,
			UStep = 100206,
			VStep = 100207,
			NurbsMode = 100160,
			NurbsTessellator = 100161,
			NurbsRenderer = 100162,
		}

		/* NurbsSampling */
		public enum NurbsSampling
		{
			ObjectParametricError = 100208,
			ObjectPathLength = 100209,
			PathLength = 100215,
			ParametricError = 100216,
			DomainDistance = 100217,
		}

		/* NurbsTrim */
		public enum NurbsTrim
		{
			Map1Trim2 = 100210,
			Map1Trim3 = 100211,
		}

		/* QuadricDrawStyle */
		public enum QuadricDrawStyle
		{
			Point = 100010,
			Line = 100011,
			Fill = 100012,
			Silhouette = 100013,
		}

		/* QuadricCallback */
		/*      GLU_Error */

		/* QuadricNormal */
		public enum QuadricNormal
		{
			Smooth = 100000,
			Flat = 100001,
			None = 100002,
		}

		/* QuadricOrientation */
		public enum QuadricOrientation
		{
			Outside = 100020,
			Inside = 100021,
		}

		/* TessCallback */
		public enum TessCallbackType : int
		{
			TessBegin = 100100,
			Begin = 100100,
			TessVertex = 100101,
			Vertex = 100101,
			TessEnd = 100102,
			End = 100102,
			TessError = 100103,
			TessEdgeFlag = 100104,
			EdgeFlag = 100104,
			TessCombine = 100105,
			TessBeginData = 100106,
			TessVertexData = 100107,
			TessEndData = 100108,
			TessErrorData = 100109,
			TessEdgeFlagData = 100110,
			TessCombineData = 100111,
		}

		/* TessContour */
		public enum TessContour
		{
			CW = 100120,
			CCW = 100121,
			Interior = 100122,
			Exterior = 100123,
			Unknown = 100124,
		}

		/* TessProperty */
		public enum TessPropertyName
		{
			TessWindingRule = 100140,
			TessBoundaryOnly = 100141,
			TessTolerance = 100142,
		}

		/* TessError */
		public enum TessError
		{
			TessError1 = 100151,
			TessError2 = 100152,
			TessError3 = 100153,
			TessError4 = 100154,
			TessError5 = 100155,
			TessError6 = 100156,
			TessError7 = 100157,
			TessError8 = 100158,
			TessMissingBeginPolygon = 100151,
			TessMissingBeginContour = 100152,
			TessMissingEndPolygon = 100153,
			TessMissingEndContour = 100154,
			TessCoordTooLarge = 100155,
			TessNeedCombineCallback = 100156,
		}

		/* TessWinding */
		public enum TessWinding
		{
			TessWindingOdd = 100130,
			TessWindingNonZero = 100131,
			TessWindingPositive = 100132,
			TessWindingNegative = 100133,
			TessWindingAbsGeqTwo = 100134,
		}

		#endregion

		#region GLU Methods

		/// <summary>
		/// The GLU_TESS_BEGIN callback is invoked like glBegin to indicate the start of a (triangle) primitive. The function
		/// takes a single argument of type GLenum. If you set the GLU_TESS_BOUNDARY_ONLY property to GL_FALSE, the argument
		/// is set to either GL_TRIANGLE_FAN, GL_TRIANGLE_STRIP, or GL_TRIANGLES. If you set the GLU_TESS_BOUNDARY_ONLY property
		/// to GL_TRUE, the argument is set to GL_LINE_LOOP.
		/// </summary>
		/// <param name="type"></param>
		public delegate void CallbackBeginDelegate(PrimitiveType type);

		/// <summary>
		/// GLU_TESS_BEGIN_DATA is the same as the GLU_TESS_BEGIN callback except that it takes an additional pointer argument. This
		/// pointer is identical to the opaque pointer provided when you call gluTessBeginPolygon.
		/// </summary>
		/// <param name="type"></param>
		/// <param name="polygon_data"></param>
		public delegate void CallbackBeginDataDelegate(PrimitiveType type, IntPtr polygon_data);

		/// <summary>
		/// The GLU_TESS_EDGE_FLAG callback is similar to glEdgeFlag. The function takes a single Boolean flag that indicates
		/// which edges lie on the polygon boundary. If the flag is GL_TRUE, then each vertex that follows begins an edge that
		/// lies on the polygon boundary; that is, an edge which separates an interior region from an exterior one. If the flag
		/// is GL_FALSE, then each vertex that follows begins an edge that lies in the polygon interior. The GLU_TESS_EDGE_FLAG
		/// callback (if defined) is invoked before the first vertex callback is made.
		/// 
		/// Because triangle fans and triangle strips do not support edge flags, the begin callback is not called with GL_TRIANGLE_FAN
		/// or GL_TRIANGLE_STRIP if an edge flag callback is provided. Instead, the fans and strips are converted to independent
		/// triangles.
		/// </summary>
		/// <param name="type"></param>
		/// <param name="polygon_data"></param>
		public delegate void CallbackEdgeFlagDelegate(bool flag);

		/// <summary>
		/// The GLU_TESS_EDGE_FLAG_DATA callback is the same as the GLU_TESS_EDGE_FLAG callback except that it takes an additional
		/// pointer argument. This pointer is identical to the opaque pointer provided when you call gluTessBeginPolygon.
		/// triangles.
		/// </summary>
		/// <param name="type"></param>
		/// <param name="polygon_data"></param>
		public delegate void CallbackEdgeFlagDataDelegate(bool flag, IntPtr polygon_data);

		/// <summary>
		/// The GLU_TESS_VERTEX callback is invoked between the begin and end callbacks. It is similar to glVertex , and it defines
		/// the vertexes of the triangles created by the tessellation process. The function takes a pointer as its only argument.
		/// This pointer is identical to the opaque pointer that you provided when you defined the vertex (see gluTessVertex).
		/// </summary>
		/// <param name="type"></param>
		/// <param name="polygon_data"></param>
		public delegate void CallbackTessVertexDelegate(IntPtr vertex_data);

		/// <summary>
		/// The GLU_TESS_VERTEX callback is invoked between the begin and end callbacks. It is similar to glVertex , and it defines
		/// the vertexes of the triangles created by the tessellation process. The function takes a pointer as its only argument.
		/// This pointer is identical to the opaque pointer that you provided when you defined the vertex (see gluTessVertex).
		/// </summary>
		/// <param name="type"></param>
		/// <param name="polygon_data"></param>
		public delegate void CallbackTessVertexDataDelegate(IntPtr vertex_data, IntPtr polygon_data);

		/// <summary>
		/// The GLU_TESS_END callback serves the same purpose as glEnd. It indicates the end of a primitive, and it takes no arguments.
		/// </summary>
		/// <param name="type"></param>
		public delegate void CallbackEndDelegate();

		/// <summary>
		/// The GLU_TESS_END_DATA callback is the same as the GLU_TESS_END callback except that it takes an additional pointer argument.
		/// This pointer is identical to the opaque pointer provided when you call gluTessBeginPolygon.
		/// </summary>
		/// <param name="type"></param>
		public delegate void CallbackEndDataDelegate(IntPtr polygon_data);

		/// <summary>
		/// The GLU_TESS_ERROR callback is called when an error is encountered.
		/// </summary>
		/// <param name="type"></param>
		public delegate void CallbackErrorDelegate(int errno);

		/// <summary>
		/// The GLU_TESS_ERROR_DATA callback is the same as the GLU_TESS_ERROR callback, except that it takes an additional pointer
		/// argument. This pointer is identical to the opaque pointer provided when you call gluTessBeginPolygon.
		/// </summary>
		/// <param name="type"></param>
		public delegate void CallbackErrorDataDelegate(int errno, IntPtr polygon_data);

		public static IntPtr NewTess()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pgluNewTess != null, "pgluNewTess not implemented");
			retValue = Delegates.pgluNewTess();
			LogCommand("gluNewTess", retValue);

			return (retValue);
		}

		public static void DeleteTess(IntPtr tess)
		{
			Debug.Assert(Delegates.pgluDeleteTess != null, "pgluDeleteTess not implemented");
			Delegates.pgluDeleteTess(tess);
			LogCommand("gluDeleteTess", null, tess);
		}

		public static void TessBeginPolygon(IntPtr tess, IntPtr polygon_data)
		{
			Debug.Assert(Delegates.pgluTessBeginPolygon != null, "pgluTessBeginPolygon not implemented");
			Delegates.pgluTessBeginPolygon(tess, polygon_data);
			LogCommand("gluTessBeginPolygon", null, tess, polygon_data);
		}

		public static void TessEndPolygon(IntPtr tess)
		{
			Debug.Assert(Delegates.pgluTessEndPolygon != null, "pgluTessEndPolygon not implemented");
			Delegates.pgluTessEndPolygon(tess);
			LogCommand("gluTessBeginPolygon", null, tess);
		}

		public static void TessBeginContour(IntPtr tess)
		{
			Debug.Assert(Delegates.pgluTessBeginContour != null, "pgluTessBeginContour not implemented");
			Delegates.pgluTessBeginContour(tess);
			LogCommand("gluTessBeginContour", null, tess);
		}

		public static void TessEndContour(IntPtr tess)
		{
			Debug.Assert(Delegates.pgluTessEndContour != null, "pgluTessEndContour not implemented");
			Delegates.pgluTessEndContour(tess);
			LogCommand("gluTessEndContour", null, tess);
		}

		public static void TessVertex(IntPtr tess, IntPtr coords, IntPtr data)
		{
			Debug.Assert(Delegates.pgluTessVertex != null, "pgluTessVertex not implemented");
			Delegates.pgluTessVertex(tess, coords, data);
			LogCommand("gluTessVertex", null, tess, coords, data);
		}

		public static void TessNormal(IntPtr tess, double valueX, double valueY, double valueZ)
		{
			Debug.Assert(Delegates.pgluTessNormal != null, "pgluTessNormal not implemented");
			Delegates.pgluTessNormal(tess, valueX, valueY, valueZ);
			LogCommand("gluTessNormal", null, tess, valueX, valueY, valueZ);
		}

		public static void TessProperty(IntPtr tess, int which, double value)
		{
			Debug.Assert(Delegates.pgluTessProperty != null, "pgluTessProperty not implemented");
			Delegates.pgluTessProperty(tess, which, value);
			LogCommand("gluTessProperty", null, tess, which, value);
		}

		public static void TessCallback(IntPtr tess, TessCallbackType which, IntPtr fn)
		{
			Debug.Assert(Delegates.pgluTessCallback != null, "pgluTessCallback not implemented");
			Delegates.pgluTessCallback(tess, (int)which, fn);
			LogCommand("gluTessCallback", null, tess, which, fn);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "gluNewTess", ExactSpelling = true)]
			internal extern static IntPtr gluNewTess();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "gluDeleteTess", ExactSpelling = true)]
			internal extern static void gluDeleteTess(IntPtr tess);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "gluTessBeginPolygon", ExactSpelling = true)]
			internal extern static void gluTessBeginPolygon(IntPtr tess, IntPtr polygon_data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "gluTessEndPolygon", ExactSpelling = true)]
			internal extern static void gluTessEndPolygon(IntPtr tess);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "gluTessBeginContour", ExactSpelling = true)]
			internal extern static void gluTessBeginContour(IntPtr tess);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "gluTessEndContour", ExactSpelling = true)]
			internal extern static void gluTessEndContour(IntPtr tess);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "gluTessVertex", ExactSpelling = true)]
			internal extern static void gluTessVertex(IntPtr tess, IntPtr coords, IntPtr data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "gluTessNormal", ExactSpelling = true)]
			internal extern static void gluTessNormal(IntPtr tess, double valueX, double valueY, double valueZ);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "gluTessProperty", ExactSpelling = true)]
			internal extern static void gluTessProperty(IntPtr tess, int which, double value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "gluTessCallback", ExactSpelling = true)]
			internal extern static void gluTessCallback(IntPtr tess, int which, IntPtr fn);
		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr gluNewTess();

			internal static gluNewTess pgluNewTess;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void gluDeleteTess(IntPtr tess);

			internal static gluDeleteTess pgluDeleteTess;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void gluTessBeginPolygon(IntPtr tess, IntPtr polygon_data);

			internal static gluTessBeginPolygon pgluTessBeginPolygon;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void gluTessEndPolygon(IntPtr tess);

			internal static gluTessEndPolygon pgluTessEndPolygon;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void gluTessBeginContour(IntPtr tess);

			internal static gluTessBeginContour pgluTessBeginContour;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void gluTessEndContour(IntPtr tess);

			internal static gluTessEndContour pgluTessEndContour;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void gluTessVertex(IntPtr tess, IntPtr coords, IntPtr data);

			internal static gluTessVertex pgluTessVertex;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void gluTessNormal(IntPtr tess, double valueX, double valueY, double valueZ);

			internal static gluTessNormal pgluTessNormal;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void gluTessProperty(IntPtr tess, int which, double value);

			internal static gluTessProperty pgluTessProperty;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void gluTessCallback(IntPtr tess, int which, IntPtr fn);

			internal static gluTessCallback pgluTessCallback;
		}

		#endregion
	}
}
