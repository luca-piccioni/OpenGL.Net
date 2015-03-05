
// Copyright (C) 2015 Luca Piccioni
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

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_robustness")]
		public const uint CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB = 0x00000004;

		/// <summary>
		/// Value of GL_LOSE_CONTEXT_ON_RESET_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_robustness")]
		public const int LOSE_CONTEXT_ON_RESET_ARB = 0x8252;

		/// <summary>
		/// Value of GL_GUILTY_CONTEXT_RESET_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_robustness")]
		public const int GUILTY_CONTEXT_RESET_ARB = 0x8253;

		/// <summary>
		/// Value of GL_INNOCENT_CONTEXT_RESET_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_robustness")]
		public const int INNOCENT_CONTEXT_RESET_ARB = 0x8254;

		/// <summary>
		/// Value of GL_UNKNOWN_CONTEXT_RESET_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_robustness")]
		public const int UNKNOWN_CONTEXT_RESET_ARB = 0x8255;

		/// <summary>
		/// Value of GL_RESET_NOTIFICATION_STRATEGY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_robustness")]
		public const int RESET_NOTIFICATION_STRATEGY_ARB = 0x8256;

		/// <summary>
		/// Value of GL_NO_RESET_NOTIFICATION_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_robustness")]
		public const int NO_RESET_NOTIFICATION_ARB = 0x8261;

		/// <summary>
		/// Binding for glGetGraphicsResetStatusARB.
		/// </summary>
		[RequiredByFeature("GL_ARB_robustness")]
		public static int GetGraphicsResetStatusARB()
		{
			int retValue;

			Debug.Assert(Delegates.pglGetGraphicsResetStatusARB != null, "pglGetGraphicsResetStatusARB not implemented");
			retValue = Delegates.pglGetGraphicsResetStatusARB();
			CallLog("glGetGraphicsResetStatusARB() = {0}", retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetnTexImageARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="img">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnTexImageARB(int target, Int32 level, int format, int type, Int32 bufSize, IntPtr img)
		{
			Debug.Assert(Delegates.pglGetnTexImageARB != null, "pglGetnTexImageARB not implemented");
			Delegates.pglGetnTexImageARB(target, level, format, type, bufSize, img);
			CallLog("glGetnTexImageARB({0}, {1}, {2}, {3}, {4}, {5})", target, level, format, type, bufSize, img);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glReadnPixelsARB.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void ReadnPixelsARB(Int32 x, Int32 y, Int32 width, Int32 height, int format, int type, Int32 bufSize, IntPtr data)
		{
			Debug.Assert(Delegates.pglReadnPixelsARB != null, "pglReadnPixelsARB not implemented");
			Delegates.pglReadnPixelsARB(x, y, width, height, format, type, bufSize, data);
			CallLog("glReadnPixelsARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", x, y, width, height, format, type, bufSize, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnCompressedTexImageARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="lod">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="img">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnCompressedTexImageARB(int target, Int32 lod, Int32 bufSize, IntPtr img)
		{
			Debug.Assert(Delegates.pglGetnCompressedTexImageARB != null, "pglGetnCompressedTexImageARB not implemented");
			Delegates.pglGetnCompressedTexImageARB(target, lod, bufSize, img);
			CallLog("glGetnCompressedTexImageARB({0}, {1}, {2}, {3})", target, lod, bufSize, img);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnUniformfvARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnUniformARB(UInt32 program, Int32 location, Int32 bufSize, float[] @params)
		{
			Debug.Assert(@params.Length >= bufSize);
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformfvARB != null, "pglGetnUniformfvARB not implemented");
					Delegates.pglGetnUniformfvARB(program, location, bufSize, p_params);
					CallLog("glGetnUniformfvARB({0}, {1}, {2}, {3})", program, location, bufSize, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnUniformivARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnUniformARB(UInt32 program, Int32 location, Int32 bufSize, Int32[] @params)
		{
			Debug.Assert(@params.Length >= bufSize);
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformivARB != null, "pglGetnUniformivARB not implemented");
					Delegates.pglGetnUniformivARB(program, location, bufSize, p_params);
					CallLog("glGetnUniformivARB({0}, {1}, {2}, {3})", program, location, bufSize, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnUniformuivARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnUniformARB(UInt32 program, Int32 location, Int32 bufSize, UInt32[] @params)
		{
			Debug.Assert(@params.Length >= bufSize);
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformuivARB != null, "pglGetnUniformuivARB not implemented");
					Delegates.pglGetnUniformuivARB(program, location, bufSize, p_params);
					CallLog("glGetnUniformuivARB({0}, {1}, {2}, {3})", program, location, bufSize, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnUniformdvARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnUniformARB(UInt32 program, Int32 location, Int32 bufSize, double[] @params)
		{
			Debug.Assert(@params.Length >= bufSize);
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformdvARB != null, "pglGetnUniformdvARB not implemented");
					Delegates.pglGetnUniformdvARB(program, location, bufSize, p_params);
					CallLog("glGetnUniformdvARB({0}, {1}, {2}, {3})", program, location, bufSize, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnMapdvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="query">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnMapARB(int target, int query, Int32 bufSize, double[] v)
		{
			Debug.Assert(v.Length >= bufSize);
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglGetnMapdvARB != null, "pglGetnMapdvARB not implemented");
					Delegates.pglGetnMapdvARB(target, query, bufSize, p_v);
					CallLog("glGetnMapdvARB({0}, {1}, {2}, {3})", target, query, bufSize, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnMapfvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="query">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnMapARB(int target, int query, Int32 bufSize, float[] v)
		{
			Debug.Assert(v.Length >= bufSize);
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglGetnMapfvARB != null, "pglGetnMapfvARB not implemented");
					Delegates.pglGetnMapfvARB(target, query, bufSize, p_v);
					CallLog("glGetnMapfvARB({0}, {1}, {2}, {3})", target, query, bufSize, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnMapivARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="query">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnMapARB(int target, int query, Int32 bufSize, Int32[] v)
		{
			Debug.Assert(v.Length >= bufSize);
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglGetnMapivARB != null, "pglGetnMapivARB not implemented");
					Delegates.pglGetnMapivARB(target, query, bufSize, p_v);
					CallLog("glGetnMapivARB({0}, {1}, {2}, {3})", target, query, bufSize, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnPixelMapfvARB.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnPixelMapARB(int map, Int32 bufSize, float[] values)
		{
			Debug.Assert(values.Length >= bufSize);
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglGetnPixelMapfvARB != null, "pglGetnPixelMapfvARB not implemented");
					Delegates.pglGetnPixelMapfvARB(map, bufSize, p_values);
					CallLog("glGetnPixelMapfvARB({0}, {1}, {2})", map, bufSize, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnPixelMapuivARB.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnPixelMapARB(int map, Int32 bufSize, UInt32[] values)
		{
			Debug.Assert(values.Length >= bufSize);
			unsafe {
				fixed (UInt32* p_values = values)
				{
					Debug.Assert(Delegates.pglGetnPixelMapuivARB != null, "pglGetnPixelMapuivARB not implemented");
					Delegates.pglGetnPixelMapuivARB(map, bufSize, p_values);
					CallLog("glGetnPixelMapuivARB({0}, {1}, {2})", map, bufSize, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnPixelMapusvARB.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnPixelMapARB(int map, Int32 bufSize, UInt16[] values)
		{
			Debug.Assert(values.Length >= bufSize);
			unsafe {
				fixed (UInt16* p_values = values)
				{
					Debug.Assert(Delegates.pglGetnPixelMapusvARB != null, "pglGetnPixelMapusvARB not implemented");
					Delegates.pglGetnPixelMapusvARB(map, bufSize, p_values);
					CallLog("glGetnPixelMapusvARB({0}, {1}, {2})", map, bufSize, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnPolygonStippleARB.
		/// </summary>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pattern">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnPolygonStippleARB(Int32 bufSize, byte[] pattern)
		{
			Debug.Assert(pattern.Length >= bufSize);
			unsafe {
				fixed (byte* p_pattern = pattern)
				{
					Debug.Assert(Delegates.pglGetnPolygonStippleARB != null, "pglGetnPolygonStippleARB not implemented");
					Delegates.pglGetnPolygonStippleARB(bufSize, p_pattern);
					CallLog("glGetnPolygonStippleARB({0}, {1})", bufSize, pattern);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnColorTableARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnColorTableARB(int target, int format, int type, Int32 bufSize, IntPtr table)
		{
			Debug.Assert(Delegates.pglGetnColorTableARB != null, "pglGetnColorTableARB not implemented");
			Delegates.pglGetnColorTableARB(target, format, type, bufSize, table);
			CallLog("glGetnColorTableARB({0}, {1}, {2}, {3}, {4})", target, format, type, bufSize, table);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnConvolutionFilterARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnConvolutionFilterARB(int target, int format, int type, Int32 bufSize, IntPtr image)
		{
			Debug.Assert(Delegates.pglGetnConvolutionFilterARB != null, "pglGetnConvolutionFilterARB not implemented");
			Delegates.pglGetnConvolutionFilterARB(target, format, type, bufSize, image);
			CallLog("glGetnConvolutionFilterARB({0}, {1}, {2}, {3}, {4})", target, format, type, bufSize, image);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnSeparableFilterARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="rowBufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="columnBufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="span">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnSeparableFilterARB(int target, int format, int type, Int32 rowBufSize, IntPtr row, Int32 columnBufSize, IntPtr column, IntPtr span)
		{
			Debug.Assert(Delegates.pglGetnSeparableFilterARB != null, "pglGetnSeparableFilterARB not implemented");
			Delegates.pglGetnSeparableFilterARB(target, format, type, rowBufSize, row, columnBufSize, column, span);
			CallLog("glGetnSeparableFilterARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, format, type, rowBufSize, row, columnBufSize, column, span);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnHistogramARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnHistogramARB(int target, bool reset, int format, int type, Int32 bufSize, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetnHistogramARB != null, "pglGetnHistogramARB not implemented");
			Delegates.pglGetnHistogramARB(target, reset, format, type, bufSize, values);
			CallLog("glGetnHistogramARB({0}, {1}, {2}, {3}, {4}, {5})", target, reset, format, type, bufSize, values);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnMinmaxARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnMinmaxARB(int target, bool reset, int format, int type, Int32 bufSize, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetnMinmaxARB != null, "pglGetnMinmaxARB not implemented");
			Delegates.pglGetnMinmaxARB(target, reset, format, type, bufSize, values);
			CallLog("glGetnMinmaxARB({0}, {1}, {2}, {3}, {4}, {5})", target, reset, format, type, bufSize, values);
			DebugCheckErrors();
		}

	}

}
