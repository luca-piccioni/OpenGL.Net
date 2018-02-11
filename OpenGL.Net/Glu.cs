
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
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security;

using Khronos;

namespace OpenGL
{
	/// <summary>
	/// The GL Utility library.
	/// </summary>
	[SuppressMessage("ReSharper", "InconsistentNaming")]
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
				LogComment($"Querying GLU from {platformLibrary}");
				BindAPI<Glu>(platformLibrary, GetProcAddressOS, null);
				LogComment($"GLU availability: {IsAvailable}");
			} catch (Exception exception) {
				/* Fail-safe (it may fail due Egl access) */
				LogComment($"GLU not available:\n{exception}");
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

		/// <summary>
		/// 
		/// </summary>
		public const int FALSE = 0;
		/// <summary>
		/// 
		/// </summary>
		public const int TRUE = 1;

		/* StringName */

		/// <summary>
		/// 
		/// </summary>
		public const int VERSION = 100800;
		
		/// <summary>
		/// 
		/// </summary>
		public const int EXTENSIONS = 100801;

		/* ErrorCode */
		
		/// <summary>
		/// 
		/// </summary>
		public const int INVALID_ENUM = 100900;
		
		/// <summary>
		/// 
		/// </summary>
		public const int INVALID_VALUE = 100901;
		
		/// <summary>
		/// 
		/// </summary>
		public const int OUT_OF_MEMORY = 100902;
		
		/// <summary>
		/// 
		/// </summary>
		public const int INCOMPATIBLE_GL_VERSION = 100903;
		
		/// <summary>
		/// 
		/// </summary>
		public const int INVALID_OPERATION = 100904;

		/* NurbsDisplay */
		/*      GLU_FILL */
		
		/// <summary>
		/// 
		/// </summary>
		public const int OUTLINE_POLYGON = 100240;
		
		/// <summary>
		/// 
		/// </summary>
		public const int OUTLINE_PATCH = 100241;

		/* NurbsCallback */
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_ERROR = 100103;
		
		/// <summary>
		/// 
		/// </summary>
		public const int ERROR = 100103;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_BEGIN = 100164;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_BEGIN_EXT = 100164;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_VERTEX = 100165;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_VERTEX_EXT = 100165;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_NORMAL = 100166;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_NORMAL_EXT = 100166;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_COLOR = 100167;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_COLOR_EXT = 100167;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_TEXTURE_COORD = 100168;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_TEX_COORD_EXT = 100168;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_END = 100169;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_END_EXT = 100169;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_BEGIN_DATA = 100170;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_BEGIN_DATA_EXT = 100170;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_VERTEX_DATA = 100171;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_VERTEX_DATA_EXT = 100171;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_NORMAL_DATA = 100172;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_NORMAL_DATA_EXT = 100172;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_COLOR_DATA = 100173;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_COLOR_DATA_EXT = 100173;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_TEXTURE_COORD_DATA = 100174;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_TEX_COORD_DATA_EXT = 100174;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_END_DATA = 100175;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_END_DATA_EXT = 100175;

		/* NurbsError */
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_ERROR1 = 100251;

		/* NurbsProperty */
		
		/// <summary>
		/// 
		/// </summary>
		public const int AUTO_LOAD_MATRIX = 100200;
		
		/// <summary>
		/// 
		/// </summary>
		public const int CULLING = 100201;
		
		/// <summary>
		/// 
		/// </summary>
		public const int SAMPLING_TOLERANCE = 100203;
		
		/// <summary>
		/// 
		/// </summary>
		public const int DISPLAY_MODE = 100204;
		
		/// <summary>
		/// 
		/// </summary>
		public const int PARAMETRIC_TOLERANCE = 100202;
		
		/// <summary>
		/// 
		/// </summary>
		public const int SAMPLING_METHOD = 100205;
		
		/// <summary>
		/// 
		/// </summary>
		public const int U_STEP = 100206;
		
		/// <summary>
		/// 
		/// </summary>
		public const int V_STEP = 100207;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_MODE = 100160;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_MODE_EXT = 100160;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_TESSELLATOR = 100161;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_TESSELLATOR_EXT = 100161;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_RENDERER = 100162;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NURBS_RENDERER_EXT = 100162;

		/* NurbsSampling */
		
		/// <summary>
		/// 
		/// </summary>
		public const int OBJECT_PARAMETRIC_ERROR = 100208;
		
		/// <summary>
		/// 
		/// </summary>
		public const int OBJECT_PARAMETRIC_ERROR_EXT = 100208;
		
		/// <summary>
		/// 
		/// </summary>
		public const int OBJECT_PATH_LENGTH = 100209;
		
		/// <summary>
		/// 
		/// </summary>
		public const int OBJECT_PATH_LENGTH_EXT = 100209;
		
		/// <summary>
		/// 
		/// </summary>
		public const int PATH_LENGTH = 100215;
		
		/// <summary>
		/// 
		/// </summary>
		public const int PARAMETRIC_ERROR = 100216;
		
		/// <summary>
		/// 
		/// </summary>
		public const int DOMAIN_DISTANCE = 100217;

		/* NurbsTrim */
		
		/// <summary>
		/// 
		/// </summary>
		public const int MAP1_TRIM_2 = 100210;
		
		/// <summary>
		/// 
		/// </summary>
		public const int MAP1_TRIM_3 = 100211;

		/* QuadricDrawStyle */
		
		/// <summary>
		/// 
		/// </summary>
		public const int POINT = 100010;
		
		/// <summary>
		/// 
		/// </summary>
		public const int LINE = 100011;
		
		/// <summary>
		/// 
		/// </summary>
		public const int FILL = 100012;
		
		/// <summary>
		/// 
		/// </summary>
		public const int SILHOUETTE = 100013;

		/* QuadricCallback */
		/*      GLU_ERROR */

		/* QuadricNormal */
		
		/// <summary>
		/// 
		/// </summary>
		public const int SMOOTH = 100000;
		
		/// <summary>
		/// 
		/// </summary>
		public const int FLAT = 100001;
		
		/// <summary>
		/// 
		/// </summary>
		public const int NONE = 100002;

		/* QuadricOrientation */
		
		/// <summary>
		/// 
		/// </summary>
		public const int OUTSIDE = 100020;
		
		/// <summary>
		/// 
		/// </summary>
		public const int INSIDE = 100021;

		/* TessCallback */
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_BEGIN = 100100;
		
		/// <summary>
		/// 
		/// </summary>
		public const int BEGIN = 100100;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_VERTEX = 100101;
		
		/// <summary>
		/// 
		/// </summary>
		public const int VERTEX = 100101;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_END = 100102;
		
		/// <summary>
		/// 
		/// </summary>
		public const int END = 100102;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_ERROR = 100103;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_EDGE_FLAG = 100104;
		
		/// <summary>
		/// 
		/// </summary>
		public const int EDGE_FLAG = 100104;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_COMBINE = 100105;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_BEGIN_DATA = 100106;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_VERTEX_DATA = 100107;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_END_DATA = 100108;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_ERROR_DATA = 100109;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_EDGE_FLAG_DATA = 100110;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_COMBINE_DATA = 100111;

		/* TessContour */
		
		/// <summary>
		/// 
		/// </summary>
		public const int CW = 100120;
		
		/// <summary>
		/// 
		/// </summary>
		public const int CCW = 100121;
		
		/// <summary>
		/// 
		/// </summary>
		public const int INTERIOR = 100122;
		
		/// <summary>
		/// 
		/// </summary>
		public const int EXTERIOR = 100123;
		
		/// <summary>
		/// 
		/// </summary>
		public const int UNKNOWN = 100124;

		/* TessProperty */
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_WINDING_RULE = 100140;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_BOUNDARY_ONLY = 100141;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_TOLERANCE = 100142;

		/* TessError */
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_ERROR1 = 100151;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_ERROR2 = 100152;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_ERROR3 = 100153;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_ERROR4 = 100154;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_ERROR5 = 100155;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_ERROR6 = 100156;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_ERROR7 = 100157;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_ERROR8 = 100158;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_MISSING_BEGIN_POLYGON = 100151;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_MISSING_BEGIN_CONTOUR = 100152;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_MISSING_END_POLYGON = 100153;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_MISSING_END_CONTOUR = 100154;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_COORD_TOO_LARGE = 100155;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_NEED_COMBINE_CALLBACK = 100156;

		/* TessWinding */
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_WINDING_ODD = 100130;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_WINDING_NONZERO = 100131;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_WINDING_POSITIVE = 100132;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_WINDING_NEGATIVE = 100133;
		
		/// <summary>
		/// 
		/// </summary>
		public const int TESS_WINDING_ABS_GEQ_TWO = 100134;

		#endregion

		#region GLU Enumerations

		
		/// <summary>
		/// 
		/// </summary>
		public enum StringName
		{
			/// <summary>
			/// 
			/// </summary>
			Version = 100800,

			/// <summary>
			/// 
			/// </summary>
			Extensions = 100801,
		}

		
		/// <summary>
		/// 
		/// </summary>
		public enum ErrorCode
		{
			/// <summary>
			/// 
			/// </summary>
			InvalidEnum = 100900,
			
			/// <summary>
			/// 
			/// </summary>
			InvalidValue = 100901,
			
			/// <summary>
			/// 
			/// </summary>
			OutOfMemory = 100902,
			
			/// <summary>
			/// 
			/// </summary>
			IncompatibleGL_Version = 100903,
			
			/// <summary>
			/// 
			/// </summary>
			InvalidOperation = 100904,
		}

		/* NurbsDisplay */
		/*      GLU_FILL */
		
		/// <summary>
		/// 
		/// </summary>
		public enum NurbsDisplay
		{
			/// <summary>
			/// 
			/// </summary>
			OutlinePolygon = 100240,
			
			/// <summary>
			/// 
			/// </summary>
			OutlinePatch = 100241,
		}

		/* NurbsCallback */
		
		/// <summary>
		/// 
		/// </summary>
		public enum NurbsCallback
		{
			/// <summary>
			/// 
			/// </summary>
			Error = 100103,
			
			/// <summary>
			/// 
			/// </summary>
			Begin = 100164,
			
			/// <summary>
			/// 
			/// </summary>
			Vertex = 100165,
			
			/// <summary>
			/// 
			/// </summary>
			Normal = 100166,
			
			/// <summary>
			/// 
			/// </summary>
			Color = 100167,
			
			/// <summary>
			/// 
			/// </summary>
			TextureCoord = 100168,
			
			/// <summary>
			/// 
			/// </summary>
			End = 100169,
			
			/// <summary>
			/// 
			/// </summary>
			BeginData = 100170,
			
			/// <summary>
			/// 
			/// </summary>
			VertexData = 100171,
			
			/// <summary>
			/// 
			/// </summary>
			NormalData = 100172,
			
			/// <summary>
			/// 
			/// </summary>
			ColorData = 100173,
			
			/// <summary>
			/// 
			/// </summary>
			TextureCoordData = 100174,
			
			/// <summary>
			/// 
			/// </summary>
			EndData = 100175,
		}

		/* NurbsError */
		
		/// <summary>
		/// 
		/// </summary>
		public enum NurbsError
		{
			/// <summary>
			/// 
			/// </summary>
			NurbsError1 = 100251,
		}

		/* NurbsProperty */
		
		/// <summary>
		/// 
		/// </summary>
		public enum NurbsProperty
		{
			/// <summary>
			/// 
			/// </summary>
			AutoLoadMatrix = 100200,
			
			/// <summary>
			/// 
			/// </summary>
			Culling = 100201,
			
			/// <summary>
			/// 
			/// </summary>
			SamplingTolerance = 100203,
			
			/// <summary>
			/// 
			/// </summary>
			DisplayMode = 100204,
			
			/// <summary>
			/// 
			/// </summary>
			ParametricTolerance = 100202,
			
			/// <summary>
			/// 
			/// </summary>
			SamplingMethod = 100205,
			
			/// <summary>
			/// 
			/// </summary>
			UStep = 100206,
			
			/// <summary>
			/// 
			/// </summary>
			VStep = 100207,
			
			/// <summary>
			/// 
			/// </summary>
			NurbsMode = 100160,
			
			/// <summary>
			/// 
			/// </summary>
			NurbsTessellator = 100161,
			
			/// <summary>
			/// 
			/// </summary>
			NurbsRenderer = 100162,
		}

		/* NurbsSampling */
		
		/// <summary>
		/// 
		/// </summary>
		public enum NurbsSampling
		{
			/// <summary>
			/// 
			/// </summary>
			ObjectParametricError = 100208,
			
			/// <summary>
			/// 
			/// </summary>
			ObjectPathLength = 100209,
			
			/// <summary>
			/// 
			/// </summary>
			PathLength = 100215,
			
			/// <summary>
			/// 
			/// </summary>
			ParametricError = 100216,
			
			/// <summary>
			/// 
			/// </summary>
			DomainDistance = 100217,
		}

		/* NurbsTrim */
		
		/// <summary>
		/// 
		/// </summary>
		public enum NurbsTrim
		{
			/// <summary>
			/// 
			/// </summary>
			Map1Trim2 = 100210,
			
			/// <summary>
			/// 
			/// </summary>
			Map1Trim3 = 100211,
		}

		/* QuadricDrawStyle */
		
		/// <summary>
		/// 
		/// </summary>
		public enum QuadricDrawStyle
		{
			/// <summary>
			/// 
			/// </summary>
			Point = 100010,
			
			/// <summary>
			/// 
			/// </summary>
			Line = 100011,
			
			/// <summary>
			/// 
			/// </summary>
			Fill = 100012,
			
			/// <summary>
			/// 
			/// </summary>
			Silhouette = 100013,
		}

		/* QuadricCallback */
		/*      GLU_Error */

		/* QuadricNormal */
		
		/// <summary>
		/// 
		/// </summary>
		public enum QuadricNormal
		{
			/// <summary>
			/// 
			/// </summary>
			Smooth = 100000,
			
			/// <summary>
			/// 
			/// </summary>
			Flat = 100001,
			
			/// <summary>
			/// 
			/// </summary>
			None = 100002,
		}

		/* QuadricOrientation */
		
		/// <summary>
		/// 
		/// </summary>
		public enum QuadricOrientation
		{
			Outside = 100020,
			Inside = 100021,
		}

		/* TessCallback */
		
		/// <summary>
		/// 
		/// </summary>
		public enum TessCallbackType : int
		{
			/// <summary>
			/// 
			/// </summary>
			TessBegin = 100100,
			
			/// <summary>
			/// 
			/// </summary>
			Begin = 100100,
			
			/// <summary>
			/// 
			/// </summary>
			TessVertex = 100101,
			
			/// <summary>
			/// 
			/// </summary>
			Vertex = 100101,
			
			/// <summary>
			/// 
			/// </summary>
			TessEnd = 100102,
			
			/// <summary>
			/// 
			/// </summary>
			End = 100102,
			
			/// <summary>
			/// 
			/// </summary>
			TessError = 100103,
			
			/// <summary>
			/// 
			/// </summary>
			TessEdgeFlag = 100104,
			
			/// <summary>
			/// 
			/// </summary>
			EdgeFlag = 100104,
			
			/// <summary>
			/// 
			/// </summary>
			TessCombine = 100105,
			
			/// <summary>
			/// 
			/// </summary>
			TessBeginData = 100106,
			
			/// <summary>
			/// 
			/// </summary>
			TessVertexData = 100107,
			
			/// <summary>
			/// 
			/// </summary>
			TessEndData = 100108,
			
			/// <summary>
			/// 
			/// </summary>
			TessErrorData = 100109,
			
			/// <summary>
			/// 
			/// </summary>
			TessEdgeFlagData = 100110,
			
			/// <summary>
			/// 
			/// </summary>
			TessCombineData = 100111,
		}

		/* TessContour */
		
		/// <summary>
		/// 
		/// </summary>
		public enum TessContour
		{
			/// <summary>
			/// 
			/// </summary>
			CW = 100120,
			
			/// <summary>
			/// 
			/// </summary>
			CCW = 100121,
			
			/// <summary>
			/// 
			/// </summary>
			Interior = 100122,
			
			/// <summary>
			/// 
			/// </summary>
			Exterior = 100123,
			
			/// <summary>
			/// 
			/// </summary>
			Unknown = 100124,
		}

		/* TessProperty */
		
		/// <summary>
		/// 
		/// </summary>
		public enum TessPropertyName
		{
			/// <summary>
			/// 
			/// </summary>
			TessWindingRule = 100140,
			
			/// <summary>
			/// 
			/// </summary>
			TessBoundaryOnly = 100141,
			
			/// <summary>
			/// 
			/// </summary>
			TessTolerance = 100142,
		}

		/* TessError */
		
		/// <summary>
		/// 
		/// </summary>
		public enum TessError
		{
			/// <summary>
			/// 
			/// </summary>
			TessError1 = 100151,
			
			/// <summary>
			/// 
			/// </summary>
			TessError2 = 100152,
			
			/// <summary>
			/// 
			/// </summary>
			TessError3 = 100153,
			
			/// <summary>
			/// 
			/// </summary>
			TessError4 = 100154,
			
			/// <summary>
			/// 
			/// </summary>
			TessError5 = 100155,
			
			/// <summary>
			/// 
			/// </summary>
			TessError6 = 100156,
			
			/// <summary>
			/// 
			/// </summary>
			TessError7 = 100157,
			
			/// <summary>
			/// 
			/// </summary>
			TessError8 = 100158,
			
			/// <summary>
			/// 
			/// </summary>
			TessMissingBeginPolygon = 100151,
			
			/// <summary>
			/// 
			/// </summary>
			TessMissingBeginContour = 100152,
			
			/// <summary>
			/// 
			/// </summary>
			TessMissingEndPolygon = 100153,
			
			/// <summary>
			/// 
			/// </summary>
			TessMissingEndContour = 100154,
			
			/// <summary>
			/// 
			/// </summary>
			TessCoordTooLarge = 100155,
			
			/// <summary>
			/// 
			/// </summary>
			TessNeedCombineCallback = 100156,
		}

		/* TessWinding */
		
		/// <summary>
		/// 
		/// </summary>
		public enum TessWinding
		{
			/// <summary>
			/// 
			/// </summary>
			TessWindingOdd = 100130,
			
			/// <summary>
			/// 
			/// </summary>
			TessWindingNonZero = 100131,
			
			/// <summary>
			/// 
			/// </summary>
			TessWindingPositive = 100132,
			
			/// <summary>
			/// 
			/// </summary>
			TessWindingNegative = 100133,
			
			/// <summary>
			/// 
			/// </summary>
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
		/// <param name="flag"></param>
		public delegate void CallbackEdgeFlagDelegate(bool flag);

		/// <summary>
		/// The GLU_TESS_EDGE_FLAG_DATA callback is the same as the GLU_TESS_EDGE_FLAG callback except that it takes an additional
		/// pointer argument. This pointer is identical to the opaque pointer provided when you call gluTessBeginPolygon.
		/// triangles.
		/// </summary>
		/// <param name="flag"></param>
		/// <param name="polygon_data"></param>
		public delegate void CallbackEdgeFlagDataDelegate(bool flag, IntPtr polygon_data);

		/// <summary>
		/// The GLU_TESS_VERTEX callback is invoked between the begin and end callbacks. It is similar to glVertex , and it defines
		/// the vertexes of the triangles created by the tessellation process. The function takes a pointer as its only argument.
		/// This pointer is identical to the opaque pointer that you provided when you defined the vertex (see gluTessVertex).
		/// </summary>
		/// <param name="vertex_data"></param>
		public delegate void CallbackTessVertexDelegate(IntPtr vertex_data);

		/// <summary>
		/// The GLU_TESS_VERTEX callback is invoked between the begin and end callbacks. It is similar to glVertex , and it defines
		/// the vertexes of the triangles created by the tessellation process. The function takes a pointer as its only argument.
		/// This pointer is identical to the opaque pointer that you provided when you defined the vertex (see gluTessVertex).
		/// </summary>
		/// <param name="vertex_data"></param>
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
		/// <param name="polygon_data"></param>
		public delegate void CallbackEndDataDelegate(IntPtr polygon_data);

		/// <summary>
		/// The GLU_TESS_ERROR callback is called when an error is encountered.
		/// </summary>
		/// <param name="errno"></param>
		public delegate void CallbackErrorDelegate(int errno);

		/// <summary>
		/// The GLU_TESS_ERROR_DATA callback is the same as the GLU_TESS_ERROR callback, except that it takes an additional pointer
		/// argument. This pointer is identical to the opaque pointer provided when you call gluTessBeginPolygon.
		/// </summary>
		/// <param name="errno"></param>
		/// <param name="polygon_data"></param>
		public delegate void CallbackErrorDataDelegate(int errno, IntPtr polygon_data);

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static IntPtr NewTess()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pgluNewTess != null, "pgluNewTess not implemented");
			retValue = Delegates.pgluNewTess();
			LogCommand("gluNewTess", retValue);

			return (retValue);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="tess"></param>
		public static void DeleteTess(IntPtr tess)
		{
			Debug.Assert(Delegates.pgluDeleteTess != null, "pgluDeleteTess not implemented");
			Delegates.pgluDeleteTess(tess);
			LogCommand("gluDeleteTess", null, tess);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="tess"></param>
		/// <param name="polygon_data"></param>
		public static void TessBeginPolygon(IntPtr tess, IntPtr polygon_data)
		{
			Debug.Assert(Delegates.pgluTessBeginPolygon != null, "pgluTessBeginPolygon not implemented");
			Delegates.pgluTessBeginPolygon(tess, polygon_data);
			LogCommand("gluTessBeginPolygon", null, tess, polygon_data);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="tess"></param>
		public static void TessEndPolygon(IntPtr tess)
		{
			Debug.Assert(Delegates.pgluTessEndPolygon != null, "pgluTessEndPolygon not implemented");
			Delegates.pgluTessEndPolygon(tess);
			LogCommand("gluTessBeginPolygon", null, tess);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="tess"></param>
		public static void TessBeginContour(IntPtr tess)
		{
			Debug.Assert(Delegates.pgluTessBeginContour != null, "pgluTessBeginContour not implemented");
			Delegates.pgluTessBeginContour(tess);
			LogCommand("gluTessBeginContour", null, tess);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="tess"></param>
		public static void TessEndContour(IntPtr tess)
		{
			Debug.Assert(Delegates.pgluTessEndContour != null, "pgluTessEndContour not implemented");
			Delegates.pgluTessEndContour(tess);
			LogCommand("gluTessEndContour", null, tess);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="tess"></param>
		/// <param name="coords"></param>
		/// <param name="data"></param>
		public static void TessVertex(IntPtr tess, IntPtr coords, IntPtr data)
		{
			Debug.Assert(Delegates.pgluTessVertex != null, "pgluTessVertex not implemented");
			Delegates.pgluTessVertex(tess, coords, data);
			LogCommand("gluTessVertex", null, tess, coords, data);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="tess"></param>
		/// <param name="valueX"></param>
		/// <param name="valueY"></param>
		/// <param name="valueZ"></param>
		public static void TessNormal(IntPtr tess, double valueX, double valueY, double valueZ)
		{
			Debug.Assert(Delegates.pgluTessNormal != null, "pgluTessNormal not implemented");
			Delegates.pgluTessNormal(tess, valueX, valueY, valueZ);
			LogCommand("gluTessNormal", null, tess, valueX, valueY, valueZ);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="tess"></param>
		/// <param name="which"></param>
		/// <param name="value"></param>
		public static void TessProperty(IntPtr tess, int which, double value)
		{
			Debug.Assert(Delegates.pgluTessProperty != null, "pgluTessProperty not implemented");
			Delegates.pgluTessProperty(tess, which, value);
			LogCommand("gluTessProperty", null, tess, which, value);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="tess"></param>
		/// <param name="which"></param>
		/// <param name="fn"></param>
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
