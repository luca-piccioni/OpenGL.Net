
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
		/// Binding for glActiveShaderProgramEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static void ActiveShaderProgramEXT(UInt32 pipeline, UInt32 program)
		{
			Debug.Assert(Delegates.pglActiveShaderProgramEXT != null, "pglActiveShaderProgramEXT not implemented");
			Delegates.pglActiveShaderProgramEXT(pipeline, program);
			CallLog("glActiveShaderProgramEXT({0}, {1})", pipeline, program);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glAlphaFuncQCOM.
		/// </summary>
		/// <param name="func">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void AlphaFuncQCOM(int func, float @ref)
		{
			Debug.Assert(Delegates.pglAlphaFuncQCOM != null, "pglAlphaFuncQCOM not implemented");
			Delegates.pglAlphaFuncQCOM(func, @ref);
			CallLog("glAlphaFuncQCOM({0}, {1})", func, @ref);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glAlphaFuncx.
		/// </summary>
		/// <param name="func">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void AlphaFunc(int func, IntPtr @ref)
		{
			Debug.Assert(Delegates.pglAlphaFuncx != null, "pglAlphaFuncx not implemented");
			Delegates.pglAlphaFuncx(func, @ref);
			CallLog("glAlphaFuncx({0}, {1})", func, @ref);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBeginQueryEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void BeginQueryEXT(int target, UInt32 id)
		{
			Debug.Assert(Delegates.pglBeginQueryEXT != null, "pglBeginQueryEXT not implemented");
			Delegates.pglBeginQueryEXT(target, id);
			CallLog("glBeginQueryEXT({0}, {1})", target, id);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBindFramebufferOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void BindFramebufferOES(int target, UInt32 framebuffer)
		{
			Debug.Assert(Delegates.pglBindFramebufferOES != null, "pglBindFramebufferOES not implemented");
			Delegates.pglBindFramebufferOES(target, framebuffer);
			CallLog("glBindFramebufferOES({0}, {1})", target, framebuffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBindProgramPipelineEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static void BindProgramPipelineEXT(UInt32 pipeline)
		{
			Debug.Assert(Delegates.pglBindProgramPipelineEXT != null, "pglBindProgramPipelineEXT not implemented");
			Delegates.pglBindProgramPipelineEXT(pipeline);
			CallLog("glBindProgramPipelineEXT({0})", pipeline);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBindRenderbufferOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void BindRenderbufferOES(int target, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglBindRenderbufferOES != null, "pglBindRenderbufferOES not implemented");
			Delegates.pglBindRenderbufferOES(target, renderbuffer);
			CallLog("glBindRenderbufferOES({0}, {1})", target, renderbuffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlendEquationOES.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void BlendEquationOES(int mode)
		{
			Debug.Assert(Delegates.pglBlendEquationOES != null, "pglBlendEquationOES not implemented");
			Delegates.pglBlendEquationOES(mode);
			CallLog("glBlendEquationOES({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlendEquationSeparateOES.
		/// </summary>
		/// <param name="modeRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="modeAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void BlendEquationSeparateOES(int modeRGB, int modeAlpha)
		{
			Debug.Assert(Delegates.pglBlendEquationSeparateOES != null, "pglBlendEquationSeparateOES not implemented");
			Delegates.pglBlendEquationSeparateOES(modeRGB, modeAlpha);
			CallLog("glBlendEquationSeparateOES({0}, {1})", modeRGB, modeAlpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlendFuncSeparateOES.
		/// </summary>
		/// <param name="srcRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dstRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="srcAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dstAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void BlendFuncSeparateOES(int srcRGB, int dstRGB, int srcAlpha, int dstAlpha)
		{
			Debug.Assert(Delegates.pglBlendFuncSeparateOES != null, "pglBlendFuncSeparateOES not implemented");
			Delegates.pglBlendFuncSeparateOES(srcRGB, dstRGB, srcAlpha, dstAlpha);
			CallLog("glBlendFuncSeparateOES({0}, {1}, {2}, {3})", srcRGB, dstRGB, srcAlpha, dstAlpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlitFramebufferANGLE.
		/// </summary>
		/// <param name="srcX0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcY0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcX1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcY1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstY0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstY1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="filter">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void BlitFramebufferANGLE(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, uint mask, int filter)
		{
			Debug.Assert(Delegates.pglBlitFramebufferANGLE != null, "pglBlitFramebufferANGLE not implemented");
			Delegates.pglBlitFramebufferANGLE(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			CallLog("glBlitFramebufferANGLE({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCheckFramebufferStatusOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		public static int CheckFramebufferStatusOES(int target)
		{
			int retValue;

			Debug.Assert(Delegates.pglCheckFramebufferStatusOES != null, "pglCheckFramebufferStatusOES not implemented");
			retValue = Delegates.pglCheckFramebufferStatusOES(target);
			CallLog("glCheckFramebufferStatusOES({0}) = {1}", target, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glClearColorx.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void ClearColor(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha)
		{
			Debug.Assert(Delegates.pglClearColorx != null, "pglClearColorx not implemented");
			Delegates.pglClearColorx(red, green, blue, alpha);
			CallLog("glClearColorx({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glClearDepthx.
		/// </summary>
		/// <param name="depth">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void ClearDepth(IntPtr depth)
		{
			Debug.Assert(Delegates.pglClearDepthx != null, "pglClearDepthx not implemented");
			Delegates.pglClearDepthx(depth);
			CallLog("glClearDepthx({0})", depth);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glClipPlanef.
		/// </summary>
		/// <param name="p">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="eqn">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void ClipPlane(int p, float[] eqn)
		{
			unsafe {
				fixed (float* p_eqn = eqn)
				{
					Debug.Assert(Delegates.pglClipPlanef != null, "pglClipPlanef not implemented");
					Delegates.pglClipPlanef(p, p_eqn);
					CallLog("glClipPlanef({0}, {1})", p, eqn);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glClipPlanefIMG.
		/// </summary>
		/// <param name="p">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="eqn">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void ClipPlaneIMG(int p, float[] eqn)
		{
			unsafe {
				fixed (float* p_eqn = eqn)
				{
					Debug.Assert(Delegates.pglClipPlanefIMG != null, "pglClipPlanefIMG not implemented");
					Delegates.pglClipPlanefIMG(p, p_eqn);
					CallLog("glClipPlanefIMG({0}, {1})", p, eqn);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glClipPlanex.
		/// </summary>
		/// <param name="plane">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="equation">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void ClipPlane(int plane, IntPtr[] equation)
		{
			unsafe {
				fixed (IntPtr* p_equation = equation)
				{
					Debug.Assert(Delegates.pglClipPlanex != null, "pglClipPlanex not implemented");
					Delegates.pglClipPlanex(plane, p_equation);
					CallLog("glClipPlanex({0}, {1})", plane, equation);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glClipPlanexIMG.
		/// </summary>
		/// <param name="p">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="eqn">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void ClipPlaneIMG(int p, IntPtr[] eqn)
		{
			unsafe {
				fixed (IntPtr* p_eqn = eqn)
				{
					Debug.Assert(Delegates.pglClipPlanexIMG != null, "pglClipPlanexIMG not implemented");
					Delegates.pglClipPlanexIMG(p, p_eqn);
					CallLog("glClipPlanexIMG({0}, {1})", p, eqn);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColor4x.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void Color4(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha)
		{
			Debug.Assert(Delegates.pglColor4x != null, "pglColor4x not implemented");
			Delegates.pglColor4x(red, green, blue, alpha);
			CallLog("glColor4x({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCopyTextureLevelsAPPLE.
		/// </summary>
		/// <param name="destinationTexture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="sourceTexture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="sourceBaseLevel">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="sourceLevelCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void CopyTextureLevelsAPPLE(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount)
		{
			Debug.Assert(Delegates.pglCopyTextureLevelsAPPLE != null, "pglCopyTextureLevelsAPPLE not implemented");
			Delegates.pglCopyTextureLevelsAPPLE(destinationTexture, sourceTexture, sourceBaseLevel, sourceLevelCount);
			CallLog("glCopyTextureLevelsAPPLE({0}, {1}, {2}, {3})", destinationTexture, sourceTexture, sourceBaseLevel, sourceLevelCount);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCoverageMaskNV.
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:bool"/>.
		/// </param>
		public static void CoverageMaskNV(bool mask)
		{
			Debug.Assert(Delegates.pglCoverageMaskNV != null, "pglCoverageMaskNV not implemented");
			Delegates.pglCoverageMaskNV(mask);
			CallLog("glCoverageMaskNV({0})", mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCoverageOperationNV.
		/// </summary>
		/// <param name="operation">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void CoverageOpNV(int operation)
		{
			Debug.Assert(Delegates.pglCoverageOperationNV != null, "pglCoverageOperationNV not implemented");
			Delegates.pglCoverageOperationNV(operation);
			CallLog("glCoverageOperationNV({0})", operation);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glCreateShaderProgramvEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="strings">
		/// A <see cref="T:String[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static UInt32 CreateShaderProgramEXT(int type, params String[] strings)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglCreateShaderProgramvEXT != null, "pglCreateShaderProgramvEXT not implemented");
			retValue = Delegates.pglCreateShaderProgramvEXT(type, (Int32)strings.Length, strings);
			CallLog("glCreateShaderProgramvEXT({0}, {1}, {2}) = {3}", type, strings.Length, strings, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glCurrentPaletteMatrixOES.
		/// </summary>
		/// <param name="matrixpaletteindex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void CurrentPaletteMatrixOES(UInt32 matrixpaletteindex)
		{
			Debug.Assert(Delegates.pglCurrentPaletteMatrixOES != null, "pglCurrentPaletteMatrixOES not implemented");
			Delegates.pglCurrentPaletteMatrixOES(matrixpaletteindex);
			CallLog("glCurrentPaletteMatrixOES({0})", matrixpaletteindex);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteFramebuffersOES.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="framebuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void DeleteFramebuffersOES(params UInt32[] framebuffers)
		{
			unsafe {
				fixed (UInt32* p_framebuffers = framebuffers)
				{
					Debug.Assert(Delegates.pglDeleteFramebuffersOES != null, "pglDeleteFramebuffersOES not implemented");
					Delegates.pglDeleteFramebuffersOES((Int32)framebuffers.Length, p_framebuffers);
					CallLog("glDeleteFramebuffersOES({0}, {1})", framebuffers.Length, framebuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteProgramPipelinesEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pipelines">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static void DeleteProgramPipelinesEXT(params UInt32[] pipelines)
		{
			unsafe {
				fixed (UInt32* p_pipelines = pipelines)
				{
					Debug.Assert(Delegates.pglDeleteProgramPipelinesEXT != null, "pglDeleteProgramPipelinesEXT not implemented");
					Delegates.pglDeleteProgramPipelinesEXT((Int32)pipelines.Length, p_pipelines);
					CallLog("glDeleteProgramPipelinesEXT({0}, {1})", pipelines.Length, pipelines);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteQueriesEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void DeleteQueriesEXT(params UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglDeleteQueriesEXT != null, "pglDeleteQueriesEXT not implemented");
					Delegates.pglDeleteQueriesEXT((Int32)ids.Length, p_ids);
					CallLog("glDeleteQueriesEXT({0}, {1})", ids.Length, ids);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteRenderbuffersOES.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="renderbuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void DeleteRenderbufferOES(params UInt32[] renderbuffers)
		{
			unsafe {
				fixed (UInt32* p_renderbuffers = renderbuffers)
				{
					Debug.Assert(Delegates.pglDeleteRenderbuffersOES != null, "pglDeleteRenderbuffersOES not implemented");
					Delegates.pglDeleteRenderbuffersOES((Int32)renderbuffers.Length, p_renderbuffers);
					CallLog("glDeleteRenderbuffersOES({0}, {1})", renderbuffers.Length, renderbuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDepthRangeArrayfvNV.
		/// </summary>
		/// <param name="first">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void DepthRangeArrayNV(UInt32 first, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglDepthRangeArrayfvNV != null, "pglDepthRangeArrayfvNV not implemented");
					Delegates.pglDepthRangeArrayfvNV(first, count, p_v);
					CallLog("glDepthRangeArrayfvNV({0}, {1}, {2})", first, count, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDepthRangeIndexedfNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void DepthRangeIndexedNV(UInt32 index, float n, float f)
		{
			Debug.Assert(Delegates.pglDepthRangeIndexedfNV != null, "pglDepthRangeIndexedfNV not implemented");
			Delegates.pglDepthRangeIndexedfNV(index, n, f);
			CallLog("glDepthRangeIndexedfNV({0}, {1}, {2})", index, n, f);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDepthRangex.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void DepthRange(IntPtr n, IntPtr f)
		{
			Debug.Assert(Delegates.pglDepthRangex != null, "pglDepthRangex not implemented");
			Delegates.pglDepthRangex(n, f);
			CallLog("glDepthRangex({0}, {1})", n, f);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDisableDriverControlQCOM.
		/// </summary>
		/// <param name="driverControl">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void DisableDriverControlQCOM(UInt32 driverControl)
		{
			Debug.Assert(Delegates.pglDisableDriverControlQCOM != null, "pglDisableDriverControlQCOM not implemented");
			Delegates.pglDisableDriverControlQCOM(driverControl);
			CallLog("glDisableDriverControlQCOM({0})", driverControl);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDiscardFramebufferEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="numAttachments">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="attachments">
		/// A <see cref="T:int[]"/>.
		/// </param>
		public static void DiscardFramebufferEXT(int target, params int[] attachments)
		{
			unsafe {
				fixed (int* p_attachments = attachments)
				{
					Debug.Assert(Delegates.pglDiscardFramebufferEXT != null, "pglDiscardFramebufferEXT not implemented");
					Delegates.pglDiscardFramebufferEXT(target, (Int32)attachments.Length, p_attachments);
					CallLog("glDiscardFramebufferEXT({0}, {1}, {2})", target, attachments.Length, attachments);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawBuffersIndexedEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void DrawBuffersIndexedEXT(int[] location, params Int32[] indices)
		{
			unsafe {
				fixed (int* p_location = location)
				fixed (Int32* p_indices = indices)
				{
					Debug.Assert(Delegates.pglDrawBuffersIndexedEXT != null, "pglDrawBuffersIndexedEXT not implemented");
					Delegates.pglDrawBuffersIndexedEXT((Int32)location.Length, p_location, p_indices);
					CallLog("glDrawBuffersIndexedEXT({0}, {1}, {2})", location.Length, location, indices);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawBuffersNV.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufs">
		/// A <see cref="T:int[]"/>.
		/// </param>
		public static void DrawBuffersNV(params int[] bufs)
		{
			unsafe {
				fixed (int* p_bufs = bufs)
				{
					Debug.Assert(Delegates.pglDrawBuffersNV != null, "pglDrawBuffersNV not implemented");
					Delegates.pglDrawBuffersNV((Int32)bufs.Length, p_bufs);
					CallLog("glDrawBuffersNV({0}, {1})", bufs.Length, bufs);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawTexfOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void DrawTexOES(float x, float y, float z, float width, float height)
		{
			Debug.Assert(Delegates.pglDrawTexfOES != null, "pglDrawTexfOES not implemented");
			Delegates.pglDrawTexfOES(x, y, z, width, height);
			CallLog("glDrawTexfOES({0}, {1}, {2}, {3}, {4})", x, y, z, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawTexfvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void DrawTexOES(float[] coords)
		{
			unsafe {
				fixed (float* p_coords = coords)
				{
					Debug.Assert(Delegates.pglDrawTexfvOES != null, "pglDrawTexfvOES not implemented");
					Delegates.pglDrawTexfvOES(p_coords);
					CallLog("glDrawTexfvOES({0})", coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawTexiOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void DrawTexOES(Int32 x, Int32 y, Int32 z, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglDrawTexiOES != null, "pglDrawTexiOES not implemented");
			Delegates.pglDrawTexiOES(x, y, z, width, height);
			CallLog("glDrawTexiOES({0}, {1}, {2}, {3}, {4})", x, y, z, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawTexivOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void DrawTexOES(Int32[] coords)
		{
			unsafe {
				fixed (Int32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglDrawTexivOES != null, "pglDrawTexivOES not implemented");
					Delegates.pglDrawTexivOES(p_coords);
					CallLog("glDrawTexivOES({0})", coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawTexsOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int16"/>.
		/// </param>
		public static void DrawTexOES(Int16 x, Int16 y, Int16 z, Int16 width, Int16 height)
		{
			Debug.Assert(Delegates.pglDrawTexsOES != null, "pglDrawTexsOES not implemented");
			Delegates.pglDrawTexsOES(x, y, z, width, height);
			CallLog("glDrawTexsOES({0}, {1}, {2}, {3}, {4})", x, y, z, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawTexsvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		public static void DrawTexOES(Int16[] coords)
		{
			unsafe {
				fixed (Int16* p_coords = coords)
				{
					Debug.Assert(Delegates.pglDrawTexsvOES != null, "pglDrawTexsvOES not implemented");
					Delegates.pglDrawTexsvOES(p_coords);
					CallLog("glDrawTexsvOES({0})", coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawTexxOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void DrawTexOES(IntPtr x, IntPtr y, IntPtr z, IntPtr width, IntPtr height)
		{
			Debug.Assert(Delegates.pglDrawTexxOES != null, "pglDrawTexxOES not implemented");
			Delegates.pglDrawTexxOES(x, y, z, width, height);
			CallLog("glDrawTexxOES({0}, {1}, {2}, {3}, {4})", x, y, z, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawTexxvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void DrawTexOES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglDrawTexxvOES != null, "pglDrawTexxvOES not implemented");
					Delegates.pglDrawTexxvOES(p_coords);
					CallLog("glDrawTexxvOES({0})", coords);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEGLImageTargetRenderbufferStorageOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void EGLImageTargetRenderbufferStorageOES(int target, IntPtr image)
		{
			Debug.Assert(Delegates.pglEGLImageTargetRenderbufferStorageOES != null, "pglEGLImageTargetRenderbufferStorageOES not implemented");
			Delegates.pglEGLImageTargetRenderbufferStorageOES(target, image);
			CallLog("glEGLImageTargetRenderbufferStorageOES({0}, {1})", target, image);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEGLImageTargetTexture2DOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void EGLImageTargetTexture2DOES(int target, IntPtr image)
		{
			Debug.Assert(Delegates.pglEGLImageTargetTexture2DOES != null, "pglEGLImageTargetTexture2DOES not implemented");
			Delegates.pglEGLImageTargetTexture2DOES(target, image);
			CallLog("glEGLImageTargetTexture2DOES({0}, {1})", target, image);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEnableDriverControlQCOM.
		/// </summary>
		/// <param name="driverControl">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void EnableDriverControlQCOM(UInt32 driverControl)
		{
			Debug.Assert(Delegates.pglEnableDriverControlQCOM != null, "pglEnableDriverControlQCOM not implemented");
			Delegates.pglEnableDriverControlQCOM(driverControl);
			CallLog("glEnableDriverControlQCOM({0})", driverControl);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEndQueryEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void EndQueryEXT(int target)
		{
			Debug.Assert(Delegates.pglEndQueryEXT != null, "pglEndQueryEXT not implemented");
			Delegates.pglEndQueryEXT(target);
			CallLog("glEndQueryEXT({0})", target);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEndTilingQCOM.
		/// </summary>
		/// <param name="preserveMask">
		/// A <see cref="T:uint"/>.
		/// </param>
		public static void EndQCOM(uint preserveMask)
		{
			Debug.Assert(Delegates.pglEndTilingQCOM != null, "pglEndTilingQCOM not implemented");
			Delegates.pglEndTilingQCOM(preserveMask);
			CallLog("glEndTilingQCOM({0})", preserveMask);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glExtGetBufferPointervQCOM.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void ExtGetBufferPointervQCOM(int target, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglExtGetBufferPointervQCOM != null, "pglExtGetBufferPointervQCOM not implemented");
					Delegates.pglExtGetBufferPointervQCOM(target, p_params);
					CallLog("glExtGetBufferPointervQCOM({0}, {1})", target, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glExtGetBuffersQCOM.
		/// </summary>
		/// <param name="buffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="maxBuffers">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numBuffers">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void ExtGetBuffersQCOM(UInt32[] buffers, Int32[] numBuffers)
		{
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				fixed (Int32* p_numBuffers = numBuffers)
				{
					Debug.Assert(Delegates.pglExtGetBuffersQCOM != null, "pglExtGetBuffersQCOM not implemented");
					Delegates.pglExtGetBuffersQCOM(p_buffers, (Int32)buffers.Length, p_numBuffers);
					CallLog("glExtGetBuffersQCOM({0}, {1}, {2})", buffers, buffers.Length, numBuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glExtGetFramebuffersQCOM.
		/// </summary>
		/// <param name="framebuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="maxFramebuffers">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numFramebuffers">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void ExtGetFramebuffersQCOM(UInt32[] framebuffers, Int32[] numFramebuffers)
		{
			unsafe {
				fixed (UInt32* p_framebuffers = framebuffers)
				fixed (Int32* p_numFramebuffers = numFramebuffers)
				{
					Debug.Assert(Delegates.pglExtGetFramebuffersQCOM != null, "pglExtGetFramebuffersQCOM not implemented");
					Delegates.pglExtGetFramebuffersQCOM(p_framebuffers, (Int32)framebuffers.Length, p_numFramebuffers);
					CallLog("glExtGetFramebuffersQCOM({0}, {1}, {2})", framebuffers, framebuffers.Length, numFramebuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glExtGetProgramBinarySourceQCOM.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="shadertype">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="source">
		/// A <see cref="T:String"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void ExtGetProgramBinarySourceQCOM(UInt32 program, int shadertype, String source, Int32[] length)
		{
			unsafe {
				fixed (Int32* p_length = length)
				{
					Debug.Assert(Delegates.pglExtGetProgramBinarySourceQCOM != null, "pglExtGetProgramBinarySourceQCOM not implemented");
					Delegates.pglExtGetProgramBinarySourceQCOM(program, shadertype, source, p_length);
					CallLog("glExtGetProgramBinarySourceQCOM({0}, {1}, {2}, {3})", program, shadertype, source, length);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glExtGetProgramsQCOM.
		/// </summary>
		/// <param name="programs">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="maxPrograms">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numPrograms">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void ExtGetProgramsQCOM(UInt32[] programs, Int32[] numPrograms)
		{
			unsafe {
				fixed (UInt32* p_programs = programs)
				fixed (Int32* p_numPrograms = numPrograms)
				{
					Debug.Assert(Delegates.pglExtGetProgramsQCOM != null, "pglExtGetProgramsQCOM not implemented");
					Delegates.pglExtGetProgramsQCOM(p_programs, (Int32)programs.Length, p_numPrograms);
					CallLog("glExtGetProgramsQCOM({0}, {1}, {2})", programs, programs.Length, numPrograms);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glExtGetRenderbuffersQCOM.
		/// </summary>
		/// <param name="renderbuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="maxRenderbuffers">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numRenderbuffers">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void ExtGetRenderbuffersQCOM(UInt32[] renderbuffers, Int32[] numRenderbuffers)
		{
			unsafe {
				fixed (UInt32* p_renderbuffers = renderbuffers)
				fixed (Int32* p_numRenderbuffers = numRenderbuffers)
				{
					Debug.Assert(Delegates.pglExtGetRenderbuffersQCOM != null, "pglExtGetRenderbuffersQCOM not implemented");
					Delegates.pglExtGetRenderbuffersQCOM(p_renderbuffers, (Int32)renderbuffers.Length, p_numRenderbuffers);
					CallLog("glExtGetRenderbuffersQCOM({0}, {1}, {2})", renderbuffers, renderbuffers.Length, numRenderbuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glExtGetShadersQCOM.
		/// </summary>
		/// <param name="shaders">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="maxShaders">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numShaders">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void ExtGetShadersQCOM(UInt32[] shaders, Int32[] numShaders)
		{
			unsafe {
				fixed (UInt32* p_shaders = shaders)
				fixed (Int32* p_numShaders = numShaders)
				{
					Debug.Assert(Delegates.pglExtGetShadersQCOM != null, "pglExtGetShadersQCOM not implemented");
					Delegates.pglExtGetShadersQCOM(p_shaders, (Int32)shaders.Length, p_numShaders);
					CallLog("glExtGetShadersQCOM({0}, {1}, {2})", shaders, shaders.Length, numShaders);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glExtGetTexLevelParameterivQCOM.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void ExtGetTexLevelParameterivQCOM(UInt32 texture, int face, Int32 level, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglExtGetTexLevelParameterivQCOM != null, "pglExtGetTexLevelParameterivQCOM not implemented");
					Delegates.pglExtGetTexLevelParameterivQCOM(texture, face, level, pname, p_params);
					CallLog("glExtGetTexLevelParameterivQCOM({0}, {1}, {2}, {3}, {4})", texture, face, level, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glExtGetTexSubImageQCOM.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="texels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void ExtGetTexSubImageQCOM(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, IntPtr texels)
		{
			Debug.Assert(Delegates.pglExtGetTexSubImageQCOM != null, "pglExtGetTexSubImageQCOM not implemented");
			Delegates.pglExtGetTexSubImageQCOM(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels);
			CallLog("glExtGetTexSubImageQCOM({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, texels);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glExtGetTexturesQCOM.
		/// </summary>
		/// <param name="textures">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="maxTextures">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numTextures">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void ExtGetTexturesQCOM(UInt32[] textures, Int32 maxTextures, Int32[] numTextures)
		{
			unsafe {
				fixed (UInt32* p_textures = textures)
				fixed (Int32* p_numTextures = numTextures)
				{
					Debug.Assert(Delegates.pglExtGetTexturesQCOM != null, "pglExtGetTexturesQCOM not implemented");
					Delegates.pglExtGetTexturesQCOM(p_textures, maxTextures, p_numTextures);
					CallLog("glExtGetTexturesQCOM({0}, {1}, {2})", textures, maxTextures, numTextures);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glExtIsProgramBinaryQCOM.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static bool ExtIsProgramBinaryQCOM(UInt32 program)
		{
			bool retValue;

			Debug.Assert(Delegates.pglExtIsProgramBinaryQCOM != null, "pglExtIsProgramBinaryQCOM not implemented");
			retValue = Delegates.pglExtIsProgramBinaryQCOM(program);
			CallLog("glExtIsProgramBinaryQCOM({0}) = {1}", program, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glExtTexObjectStateOverrideiQCOM.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void ExtTexObjectStateOverrideiQCOM(int target, int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglExtTexObjectStateOverrideiQCOM != null, "pglExtTexObjectStateOverrideiQCOM not implemented");
			Delegates.pglExtTexObjectStateOverrideiQCOM(target, pname, param);
			CallLog("glExtTexObjectStateOverrideiQCOM({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFogx.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void Fog(int pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglFogx != null, "pglFogx not implemented");
			Delegates.pglFogx(pname, param);
			CallLog("glFogx({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFogxv.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void Fog(int pname, IntPtr[] param)
		{
			unsafe {
				fixed (IntPtr* p_param = param)
				{
					Debug.Assert(Delegates.pglFogxv != null, "pglFogxv not implemented");
					Delegates.pglFogxv(pname, p_param);
					CallLog("glFogxv({0}, {1})", pname, param);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFramebufferRenderbufferOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="renderbuffertarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void FramebufferRenderbufferOES(int target, int attachment, int renderbuffertarget, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglFramebufferRenderbufferOES != null, "pglFramebufferRenderbufferOES not implemented");
			Delegates.pglFramebufferRenderbufferOES(target, attachment, renderbuffertarget, renderbuffer);
			CallLog("glFramebufferRenderbufferOES({0}, {1}, {2}, {3})", target, attachment, renderbuffertarget, renderbuffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFramebufferTexture2DMultisampleEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="textarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void FramebufferTexture2DMultisampleEXT(int target, int attachment, int textarget, UInt32 texture, Int32 level, Int32 samples)
		{
			Debug.Assert(Delegates.pglFramebufferTexture2DMultisampleEXT != null, "pglFramebufferTexture2DMultisampleEXT not implemented");
			Delegates.pglFramebufferTexture2DMultisampleEXT(target, attachment, textarget, texture, level, samples);
			CallLog("glFramebufferTexture2DMultisampleEXT({0}, {1}, {2}, {3}, {4}, {5})", target, attachment, textarget, texture, level, samples);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFramebufferTexture2DMultisampleIMG.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="textarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void FramebufferTexture2DMultisampleIMG(int target, int attachment, int textarget, UInt32 texture, Int32 level, Int32 samples)
		{
			Debug.Assert(Delegates.pglFramebufferTexture2DMultisampleIMG != null, "pglFramebufferTexture2DMultisampleIMG not implemented");
			Delegates.pglFramebufferTexture2DMultisampleIMG(target, attachment, textarget, texture, level, samples);
			CallLog("glFramebufferTexture2DMultisampleIMG({0}, {1}, {2}, {3}, {4}, {5})", target, attachment, textarget, texture, level, samples);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFramebufferTexture2DOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="textarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void FramebufferTexture2DOES(int target, int attachment, int textarget, UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglFramebufferTexture2DOES != null, "pglFramebufferTexture2DOES not implemented");
			Delegates.pglFramebufferTexture2DOES(target, attachment, textarget, texture, level);
			CallLog("glFramebufferTexture2DOES({0}, {1}, {2}, {3}, {4})", target, attachment, textarget, texture, level);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFrustumf.
		/// </summary>
		/// <param name="l">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void Frustum(float l, float r, float b, float t, float n, float f)
		{
			Debug.Assert(Delegates.pglFrustumf != null, "pglFrustumf not implemented");
			Delegates.pglFrustumf(l, r, b, t, n, f);
			CallLog("glFrustumf({0}, {1}, {2}, {3}, {4}, {5})", l, r, b, t, n, f);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFrustumx.
		/// </summary>
		/// <param name="l">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void Frustum(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f)
		{
			Debug.Assert(Delegates.pglFrustumx != null, "pglFrustumx not implemented");
			Delegates.pglFrustumx(l, r, b, t, n, f);
			CallLog("glFrustumx({0}, {1}, {2}, {3}, {4}, {5})", l, r, b, t, n, f);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenFramebuffersOES.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="framebuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void GenFramebuffersOES(UInt32[] framebuffers)
		{
			unsafe {
				fixed (UInt32* p_framebuffers = framebuffers)
				{
					Debug.Assert(Delegates.pglGenFramebuffersOES != null, "pglGenFramebuffersOES not implemented");
					Delegates.pglGenFramebuffersOES((Int32)framebuffers.Length, p_framebuffers);
					CallLog("glGenFramebuffersOES({0}, {1})", framebuffers.Length, framebuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenFramebuffersOES.
		/// </summary>
		public static UInt32 GenFramebuffersOES()
		{
			UInt32[] retValue = new UInt32[1];
			GenFramebuffersOES(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// Binding for glGenProgramPipelinesEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pipelines">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static void GenProgramPipelinesEXT(UInt32[] pipelines)
		{
			unsafe {
				fixed (UInt32* p_pipelines = pipelines)
				{
					Debug.Assert(Delegates.pglGenProgramPipelinesEXT != null, "pglGenProgramPipelinesEXT not implemented");
					Delegates.pglGenProgramPipelinesEXT((Int32)pipelines.Length, p_pipelines);
					CallLog("glGenProgramPipelinesEXT({0}, {1})", pipelines.Length, pipelines);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenProgramPipelinesEXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static UInt32 GenProgramPipelinesEXT()
		{
			UInt32[] retValue = new UInt32[1];
			GenProgramPipelinesEXT(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// Binding for glGenQueriesEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void GenQueriesEXT(UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglGenQueriesEXT != null, "pglGenQueriesEXT not implemented");
					Delegates.pglGenQueriesEXT((Int32)ids.Length, p_ids);
					CallLog("glGenQueriesEXT({0}, {1})", ids.Length, ids);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenQueriesEXT.
		/// </summary>
		public static UInt32 GenQueriesEXT()
		{
			UInt32[] retValue = new UInt32[1];
			GenQueriesEXT(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// Binding for glGenRenderbuffersOES.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="renderbuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void GenRenderbufferOES(UInt32[] renderbuffers)
		{
			unsafe {
				fixed (UInt32* p_renderbuffers = renderbuffers)
				{
					Debug.Assert(Delegates.pglGenRenderbuffersOES != null, "pglGenRenderbuffersOES not implemented");
					Delegates.pglGenRenderbuffersOES((Int32)renderbuffers.Length, p_renderbuffers);
					CallLog("glGenRenderbuffersOES({0}, {1})", renderbuffers.Length, renderbuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenRenderbuffersOES.
		/// </summary>
		public static UInt32 GenRenderbufferOES()
		{
			UInt32[] retValue = new UInt32[1];
			GenRenderbufferOES(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// Binding for glGenerateMipmapOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void GenerateMipmapOES(int target)
		{
			Debug.Assert(Delegates.pglGenerateMipmapOES != null, "pglGenerateMipmapOES not implemented");
			Delegates.pglGenerateMipmapOES(target);
			CallLog("glGenerateMipmapOES({0})", target);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetClipPlanef.
		/// </summary>
		/// <param name="plane">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="equation">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void GetClipPlane(int plane, float[] equation)
		{
			unsafe {
				fixed (float* p_equation = equation)
				{
					Debug.Assert(Delegates.pglGetClipPlanef != null, "pglGetClipPlanef not implemented");
					Delegates.pglGetClipPlanef(plane, p_equation);
					CallLog("glGetClipPlanef({0}, {1})", plane, equation);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetClipPlanex.
		/// </summary>
		/// <param name="plane">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="equation">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void GetClipPlane(int plane, IntPtr[] equation)
		{
			unsafe {
				fixed (IntPtr* p_equation = equation)
				{
					Debug.Assert(Delegates.pglGetClipPlanex != null, "pglGetClipPlanex not implemented");
					Delegates.pglGetClipPlanex(plane, p_equation);
					CallLog("glGetClipPlanex({0}, {1})", plane, equation);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetDriverControlStringQCOM.
		/// </summary>
		/// <param name="driverControl">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="driverControlString">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		public static void GetDriverControlStringQCOM(UInt32 driverControl, Int32 bufSize, Int32[] length, [Out] StringBuilder driverControlString)
		{
			unsafe {
				fixed (Int32* p_length = length)
				{
					Debug.Assert(Delegates.pglGetDriverControlStringQCOM != null, "pglGetDriverControlStringQCOM not implemented");
					Delegates.pglGetDriverControlStringQCOM(driverControl, bufSize, p_length, driverControlString);
					CallLog("glGetDriverControlStringQCOM({0}, {1}, {2}, {3})", driverControl, bufSize, length, driverControlString);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetDriverControlsQCOM.
		/// </summary>
		/// <param name="num">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="driverControls">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void GetDriverControlsQCOM(Int32[] num, params UInt32[] driverControls)
		{
			unsafe {
				fixed (Int32* p_num = num)
				fixed (UInt32* p_driverControls = driverControls)
				{
					Debug.Assert(Delegates.pglGetDriverControlsQCOM != null, "pglGetDriverControlsQCOM not implemented");
					Delegates.pglGetDriverControlsQCOM(p_num, (Int32)driverControls.Length, p_driverControls);
					CallLog("glGetDriverControlsQCOM({0}, {1}, {2})", num, driverControls.Length, driverControls);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetFixedv.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void GetFixed(int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFixedv != null, "pglGetFixedv not implemented");
					Delegates.pglGetFixedv(pname, p_params);
					CallLog("glGetFixedv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetFramebufferAttachmentParameterivOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void GetFramebufferAttachmentParameterOES(int target, int attachment, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFramebufferAttachmentParameterivOES != null, "pglGetFramebufferAttachmentParameterivOES not implemented");
					Delegates.pglGetFramebufferAttachmentParameterivOES(target, attachment, pname, p_params);
					CallLog("glGetFramebufferAttachmentParameterivOES({0}, {1}, {2}, {3})", target, attachment, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetGraphicsResetStatusEXT.
		/// </summary>
		public static int GetGraphicsResetStatusEXT()
		{
			int retValue;

			Debug.Assert(Delegates.pglGetGraphicsResetStatusEXT != null, "pglGetGraphicsResetStatusEXT not implemented");
			retValue = Delegates.pglGetGraphicsResetStatusEXT();
			CallLog("glGetGraphicsResetStatusEXT() = {0}", retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetIntegeri_vEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void GetIntegerEXT(int target, UInt32 index, Int32[] data)
		{
			unsafe {
				fixed (Int32* p_data = data)
				{
					Debug.Assert(Delegates.pglGetIntegeri_vEXT != null, "pglGetIntegeri_vEXT not implemented");
					Delegates.pglGetIntegeri_vEXT(target, index, p_data);
					CallLog("glGetIntegeri_vEXT({0}, {1}, {2})", target, index, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetLightxv.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void GetLightxv(int light, int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetLightxv != null, "pglGetLightxv not implemented");
					Delegates.pglGetLightxv(light, pname, p_params);
					CallLog("glGetLightxv({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetLightxvOES.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void GetLightxvOES(int light, int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetLightxvOES != null, "pglGetLightxvOES not implemented");
					Delegates.pglGetLightxvOES(light, pname, p_params);
					CallLog("glGetLightxvOES({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetMaterialxv.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void GetMaterial(int face, int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMaterialxv != null, "pglGetMaterialxv not implemented");
					Delegates.pglGetMaterialxv(face, pname, p_params);
					CallLog("glGetMaterialxv({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetMaterialxvOES.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void GetMaterialOES(int face, int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMaterialxvOES != null, "pglGetMaterialxvOES not implemented");
					Delegates.pglGetMaterialxvOES(face, pname, p_params);
					CallLog("glGetMaterialxvOES({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetProgramPipelineInfoLogEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="infoLog">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static void GetProgramPipelineInfoLogEXT(UInt32 pipeline, Int32 bufSize, out Int32 length, [Out] StringBuilder infoLog)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetProgramPipelineInfoLogEXT != null, "pglGetProgramPipelineInfoLogEXT not implemented");
					Delegates.pglGetProgramPipelineInfoLogEXT(pipeline, bufSize, p_length, infoLog);
					CallLog("glGetProgramPipelineInfoLogEXT({0}, {1}, {2}, {3})", pipeline, bufSize, length, infoLog);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetProgramPipelineivEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static void GetProgramPipelineEXT(UInt32 pipeline, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramPipelineivEXT != null, "pglGetProgramPipelineivEXT not implemented");
					Delegates.pglGetProgramPipelineivEXT(pipeline, pname, p_params);
					CallLog("glGetProgramPipelineivEXT({0}, {1}, {2})", pipeline, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetQueryObjectuivEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void GetQueryObjectuivEXT(UInt32 id, int pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryObjectuivEXT != null, "pglGetQueryObjectuivEXT not implemented");
					Delegates.pglGetQueryObjectuivEXT(id, pname, p_params);
					CallLog("glGetQueryObjectuivEXT({0}, {1}, {2})", id, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetQueryivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void GetQueryEXT(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryivEXT != null, "pglGetQueryivEXT not implemented");
					Delegates.pglGetQueryivEXT(target, pname, p_params);
					CallLog("glGetQueryivEXT({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetRenderbufferParameterivOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void GetRenderbufferParameterOES(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetRenderbufferParameterivOES != null, "pglGetRenderbufferParameterivOES not implemented");
					Delegates.pglGetRenderbufferParameterivOES(target, pname, p_params);
					CallLog("glGetRenderbufferParameterivOES({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexEnvxv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void GetTexEnv(int target, int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexEnvxv != null, "pglGetTexEnvxv not implemented");
					Delegates.pglGetTexEnvxv(target, pname, p_params);
					CallLog("glGetTexEnvxv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexGenfvOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void GetTexGenOES(int coord, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGenfvOES != null, "pglGetTexGenfvOES not implemented");
					Delegates.pglGetTexGenfvOES(coord, pname, p_params);
					CallLog("glGetTexGenfvOES({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexGenivOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void GetTexGenOES(int coord, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGenivOES != null, "pglGetTexGenivOES not implemented");
					Delegates.pglGetTexGenivOES(coord, pname, p_params);
					CallLog("glGetTexGenivOES({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexParameterxv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void GetTexParameter(int target, int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameterxv != null, "pglGetTexParameterxv not implemented");
					Delegates.pglGetTexParameterxv(target, pname, p_params);
					CallLog("glGetTexParameterxv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTranslatedShaderSourceANGLE.
		/// </summary>
		/// <param name="shader">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bufsize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="source">
		/// A <see cref="T:String"/>.
		/// </param>
		public static void GetTranslatedShaderSourceANGLE(UInt32 shader, Int32 bufsize, out Int32 length, String source)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetTranslatedShaderSourceANGLE != null, "pglGetTranslatedShaderSourceANGLE not implemented");
					Delegates.pglGetTranslatedShaderSourceANGLE(shader, bufsize, p_length, source);
					CallLog("glGetTranslatedShaderSourceANGLE({0}, {1}, {2}, {3})", shader, bufsize, length, source);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnUniformfvEXT.
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
		public static void GetnUniformEXT(UInt32 program, Int32 location, params float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformfvEXT != null, "pglGetnUniformfvEXT not implemented");
					Delegates.pglGetnUniformfvEXT(program, location, (Int32)@params.Length, p_params);
					CallLog("glGetnUniformfvEXT({0}, {1}, {2}, {3})", program, location, @params.Length, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnUniformivEXT.
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
		public static void GetnUniformEXT(UInt32 program, Int32 location, params Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformivEXT != null, "pglGetnUniformivEXT not implemented");
					Delegates.pglGetnUniformivEXT(program, location, (Int32)@params.Length, p_params);
					CallLog("glGetnUniformivEXT({0}, {1}, {2}, {3})", program, location, @params.Length, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIsFramebufferOES.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static bool IsFramebufferOES(UInt32 framebuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsFramebufferOES != null, "pglIsFramebufferOES not implemented");
			retValue = Delegates.pglIsFramebufferOES(framebuffer);
			CallLog("glIsFramebufferOES({0}) = {1}", framebuffer, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glIsProgramPipelineEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static bool IsProgramPipelineEXT(UInt32 pipeline)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsProgramPipelineEXT != null, "pglIsProgramPipelineEXT not implemented");
			retValue = Delegates.pglIsProgramPipelineEXT(pipeline);
			CallLog("glIsProgramPipelineEXT({0}) = {1}", pipeline, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glIsQueryEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static bool IsQueryEXT(UInt32 id)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsQueryEXT != null, "pglIsQueryEXT not implemented");
			retValue = Delegates.pglIsQueryEXT(id);
			CallLog("glIsQueryEXT({0}) = {1}", id, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glIsRenderbufferOES.
		/// </summary>
		/// <param name="renderbuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static bool IsRenderbufferOES(UInt32 renderbuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsRenderbufferOES != null, "pglIsRenderbufferOES not implemented");
			retValue = Delegates.pglIsRenderbufferOES(renderbuffer);
			CallLog("glIsRenderbufferOES({0}) = {1}", renderbuffer, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glLightModelx.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void LightModel(int pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglLightModelx != null, "pglLightModelx not implemented");
			Delegates.pglLightModelx(pname, param);
			CallLog("glLightModelx({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLightModelxv.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void LightModel(int pname, IntPtr[] param)
		{
			unsafe {
				fixed (IntPtr* p_param = param)
				{
					Debug.Assert(Delegates.pglLightModelxv != null, "pglLightModelxv not implemented");
					Delegates.pglLightModelxv(pname, p_param);
					CallLog("glLightModelxv({0}, {1})", pname, param);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLightx.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void Lightx(int light, int pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglLightx != null, "pglLightx not implemented");
			Delegates.pglLightx(light, pname, param);
			CallLog("glLightx({0}, {1}, {2})", light, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLightxv.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void Lightxv(int light, int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightxv != null, "pglLightxv not implemented");
					Delegates.pglLightxv(light, pname, p_params);
					CallLog("glLightxv({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLineWidthx.
		/// </summary>
		/// <param name="width">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void LineWidth(IntPtr width)
		{
			Debug.Assert(Delegates.pglLineWidthx != null, "pglLineWidthx not implemented");
			Delegates.pglLineWidthx(width);
			CallLog("glLineWidthx({0})", width);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLoadMatrixx.
		/// </summary>
		/// <param name="m">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void LoadMatrixx(IntPtr[] m)
		{
			unsafe {
				fixed (IntPtr* p_m = m)
				{
					Debug.Assert(Delegates.pglLoadMatrixx != null, "pglLoadMatrixx not implemented");
					Delegates.pglLoadMatrixx(p_m);
					CallLog("glLoadMatrixx({0})", m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLoadPaletteFromModelViewMatrixOES.
		/// </summary>
		public static void LoadPaletteFromModelViewMatrixOES()
		{
			Debug.Assert(Delegates.pglLoadPaletteFromModelViewMatrixOES != null, "pglLoadPaletteFromModelViewMatrixOES not implemented");
			Delegates.pglLoadPaletteFromModelViewMatrixOES();
			CallLog("glLoadPaletteFromModelViewMatrixOES()");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMaterialx.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void Material(int face, int pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglMaterialx != null, "pglMaterialx not implemented");
			Delegates.pglMaterialx(face, pname, param);
			CallLog("glMaterialx({0}, {1}, {2})", face, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMaterialxv.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void Material(int face, int pname, IntPtr[] param)
		{
			unsafe {
				fixed (IntPtr* p_param = param)
				{
					Debug.Assert(Delegates.pglMaterialxv != null, "pglMaterialxv not implemented");
					Delegates.pglMaterialxv(face, pname, p_param);
					CallLog("glMaterialxv({0}, {1}, {2})", face, pname, param);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMatrixIndexPointerOES.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void MatrixIndexPointerOES(Int32 size, int type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglMatrixIndexPointerOES != null, "pglMatrixIndexPointerOES not implemented");
			Delegates.pglMatrixIndexPointerOES(size, type, stride, pointer);
			CallLog("glMatrixIndexPointerOES({0}, {1}, {2}, {3})", size, type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMatrixIndexPointerOES.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		public static void MatrixIndexPointerOES(Int32 size, int type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				MatrixIndexPointerOES(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glMultMatrixx.
		/// </summary>
		/// <param name="m">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void MultMatrixx(IntPtr[] m)
		{
			unsafe {
				fixed (IntPtr* p_m = m)
				{
					Debug.Assert(Delegates.pglMultMatrixx != null, "pglMultMatrixx not implemented");
					Delegates.pglMultMatrixx(p_m);
					CallLog("glMultMatrixx({0})", m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiTexCoord4x.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="q">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void MultiTexCoord4(int texture, IntPtr s, IntPtr t, IntPtr r, IntPtr q)
		{
			Debug.Assert(Delegates.pglMultiTexCoord4x != null, "pglMultiTexCoord4x not implemented");
			Delegates.pglMultiTexCoord4x(texture, s, t, r, q);
			CallLog("glMultiTexCoord4x({0}, {1}, {2}, {3}, {4})", texture, s, t, r, q);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNormal3x.
		/// </summary>
		/// <param name="nx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void Normal3(IntPtr nx, IntPtr ny, IntPtr nz)
		{
			Debug.Assert(Delegates.pglNormal3x != null, "pglNormal3x not implemented");
			Delegates.pglNormal3x(nx, ny, nz);
			CallLog("glNormal3x({0}, {1}, {2})", nx, ny, nz);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glOrthof.
		/// </summary>
		/// <param name="l">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void Ortho(float l, float r, float b, float t, float n, float f)
		{
			Debug.Assert(Delegates.pglOrthof != null, "pglOrthof not implemented");
			Delegates.pglOrthof(l, r, b, t, n, f);
			CallLog("glOrthof({0}, {1}, {2}, {3}, {4}, {5})", l, r, b, t, n, f);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glOrthox.
		/// </summary>
		/// <param name="l">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void Orthox(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f)
		{
			Debug.Assert(Delegates.pglOrthox != null, "pglOrthox not implemented");
			Delegates.pglOrthox(l, r, b, t, n, f);
			CallLog("glOrthox({0}, {1}, {2}, {3}, {4}, {5})", l, r, b, t, n, f);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPointParameterx.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void PointParameter(int pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglPointParameterx != null, "pglPointParameterx not implemented");
			Delegates.pglPointParameterx(pname, param);
			CallLog("glPointParameterx({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPointParameterxOES.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void PointParameterOES(int pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglPointParameterxOES != null, "pglPointParameterxOES not implemented");
			Delegates.pglPointParameterxOES(pname, param);
			CallLog("glPointParameterxOES({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPointParameterxv.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void PointParameter(int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglPointParameterxv != null, "pglPointParameterxv not implemented");
					Delegates.pglPointParameterxv(pname, p_params);
					CallLog("glPointParameterxv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPointSizePointerOES.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void PointSizePointerOES(int type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglPointSizePointerOES != null, "pglPointSizePointerOES not implemented");
			Delegates.pglPointSizePointerOES(type, stride, pointer);
			CallLog("glPointSizePointerOES({0}, {1}, {2})", type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPointSizePointerOES.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		public static void PointSizePointerOES(int type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				PointSizePointerOES(type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glPointSizex.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void PointSize(IntPtr size)
		{
			Debug.Assert(Delegates.pglPointSizex != null, "pglPointSizex not implemented");
			Delegates.pglPointSizex(size);
			CallLog("glPointSizex({0})", size);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPolygonOffsetx.
		/// </summary>
		/// <param name="factor">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="units">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void PolygonOffset(IntPtr factor, IntPtr units)
		{
			Debug.Assert(Delegates.pglPolygonOffsetx != null, "pglPolygonOffsetx not implemented");
			Delegates.pglPolygonOffsetx(factor, units);
			CallLog("glPolygonOffsetx({0}, {1})", factor, units);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPrimitiveBoundingBoxEXT.
		/// </summary>
		/// <param name="minX">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="minY">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="minZ">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="minW">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="maxX">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="maxY">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="maxZ">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="maxW">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void PrimitiveEXT(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW)
		{
			Debug.Assert(Delegates.pglPrimitiveBoundingBoxEXT != null, "pglPrimitiveBoundingBoxEXT not implemented");
			Delegates.pglPrimitiveBoundingBoxEXT(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
			CallLog("glPrimitiveBoundingBoxEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPrimitiveBoundingBoxOES.
		/// </summary>
		/// <param name="minX">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="minY">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="minZ">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="minW">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="maxX">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="maxY">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="maxZ">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="maxW">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void PrimitiveOES(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW)
		{
			Debug.Assert(Delegates.pglPrimitiveBoundingBoxOES != null, "pglPrimitiveBoundingBoxOES not implemented");
			Delegates.pglPrimitiveBoundingBoxOES(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
			CallLog("glPrimitiveBoundingBoxOES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glReadBufferIndexedEXT.
		/// </summary>
		/// <param name="src">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void ReadBufferIndexedEXT(int src, Int32 index)
		{
			Debug.Assert(Delegates.pglReadBufferIndexedEXT != null, "pglReadBufferIndexedEXT not implemented");
			Delegates.pglReadBufferIndexedEXT(src, index);
			CallLog("glReadBufferIndexedEXT({0}, {1})", src, index);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glReadBufferNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void ReadBufferNV(int mode)
		{
			Debug.Assert(Delegates.pglReadBufferNV != null, "pglReadBufferNV not implemented");
			Delegates.pglReadBufferNV(mode);
			CallLog("glReadBufferNV({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRenderbufferStorageMultisampleANGLE.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void RenderbufferStorageMultisampleANGLE(int target, Int32 samples, int internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageMultisampleANGLE != null, "pglRenderbufferStorageMultisampleANGLE not implemented");
			Delegates.pglRenderbufferStorageMultisampleANGLE(target, samples, internalformat, width, height);
			CallLog("glRenderbufferStorageMultisampleANGLE({0}, {1}, {2}, {3}, {4})", target, samples, internalformat, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRenderbufferStorageMultisampleAPPLE.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void RenderbufferStorageMultisampleAPPLE(int target, Int32 samples, int internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageMultisampleAPPLE != null, "pglRenderbufferStorageMultisampleAPPLE not implemented");
			Delegates.pglRenderbufferStorageMultisampleAPPLE(target, samples, internalformat, width, height);
			CallLog("glRenderbufferStorageMultisampleAPPLE({0}, {1}, {2}, {3}, {4})", target, samples, internalformat, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRenderbufferStorageMultisampleIMG.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void RenderbufferStorageMultisampleIMG(int target, Int32 samples, int internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageMultisampleIMG != null, "pglRenderbufferStorageMultisampleIMG not implemented");
			Delegates.pglRenderbufferStorageMultisampleIMG(target, samples, internalformat, width, height);
			CallLog("glRenderbufferStorageMultisampleIMG({0}, {1}, {2}, {3}, {4})", target, samples, internalformat, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRenderbufferStorageOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void RenderbufferStorageOES(int target, int internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageOES != null, "pglRenderbufferStorageOES not implemented");
			Delegates.pglRenderbufferStorageOES(target, internalformat, width, height);
			CallLog("glRenderbufferStorageOES({0}, {1}, {2}, {3})", target, internalformat, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glResolveMultisampleFramebufferAPPLE.
		/// </summary>
		public static void ResolveMultisampleFramebufferAPPLE()
		{
			Debug.Assert(Delegates.pglResolveMultisampleFramebufferAPPLE != null, "pglResolveMultisampleFramebufferAPPLE not implemented");
			Delegates.pglResolveMultisampleFramebufferAPPLE();
			CallLog("glResolveMultisampleFramebufferAPPLE()");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glRotatex.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void Rotate(IntPtr angle, IntPtr x, IntPtr y, IntPtr z)
		{
			Debug.Assert(Delegates.pglRotatex != null, "pglRotatex not implemented");
			Delegates.pglRotatex(angle, x, y, z);
			CallLog("glRotatex({0}, {1}, {2}, {3})", angle, x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSampleCoveragex.
		/// </summary>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="invert">
		/// A <see cref="T:bool"/>.
		/// </param>
		public static void SampleCoverage(Int32 value, bool invert)
		{
			Debug.Assert(Delegates.pglSampleCoveragex != null, "pglSampleCoveragex not implemented");
			Delegates.pglSampleCoveragex(value, invert);
			CallLog("glSampleCoveragex({0}, {1})", value, invert);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSampleCoveragexOES.
		/// </summary>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="invert">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void SampleCoverageOES(Int32 value, bool invert)
		{
			Debug.Assert(Delegates.pglSampleCoveragexOES != null, "pglSampleCoveragexOES not implemented");
			Delegates.pglSampleCoveragexOES(value, invert);
			CallLog("glSampleCoveragexOES({0}, {1})", value, invert);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glScalex.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void Scale(IntPtr x, IntPtr y, IntPtr z)
		{
			Debug.Assert(Delegates.pglScalex != null, "pglScalex not implemented");
			Delegates.pglScalex(x, y, z);
			CallLog("glScalex({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glStartTilingQCOM.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="preserveMask">
		/// A <see cref="T:uint"/>.
		/// </param>
		public static void StartQCOM(UInt32 x, UInt32 y, UInt32 width, UInt32 height, uint preserveMask)
		{
			Debug.Assert(Delegates.pglStartTilingQCOM != null, "pglStartTilingQCOM not implemented");
			Delegates.pglStartTilingQCOM(x, y, width, height, preserveMask);
			CallLog("glStartTilingQCOM({0}, {1}, {2}, {3}, {4})", x, y, width, height, preserveMask);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexEnvx.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void TexEnv(int target, int pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglTexEnvx != null, "pglTexEnvx not implemented");
			Delegates.pglTexEnvx(target, pname, param);
			CallLog("glTexEnvx({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexEnvxv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void TexEnv(int target, int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexEnvxv != null, "pglTexEnvxv not implemented");
					Delegates.pglTexEnvxv(target, pname, p_params);
					CallLog("glTexEnvxv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexGenfOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void TexGenOES(int coord, int pname, float param)
		{
			Debug.Assert(Delegates.pglTexGenfOES != null, "pglTexGenfOES not implemented");
			Delegates.pglTexGenfOES(coord, pname, param);
			CallLog("glTexGenfOES({0}, {1}, {2})", coord, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexGenfvOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void TexGenOES(int coord, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGenfvOES != null, "pglTexGenfvOES not implemented");
					Delegates.pglTexGenfvOES(coord, pname, p_params);
					CallLog("glTexGenfvOES({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexGeniOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void TexGenOES(int coord, int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTexGeniOES != null, "pglTexGeniOES not implemented");
			Delegates.pglTexGeniOES(coord, pname, param);
			CallLog("glTexGeniOES({0}, {1}, {2})", coord, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexGenivOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void TexGenOES(int coord, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGenivOES != null, "pglTexGenivOES not implemented");
					Delegates.pglTexGenivOES(coord, pname, p_params);
					CallLog("glTexGenivOES({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexParameterx.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void TexParameter(int target, int pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglTexParameterx != null, "pglTexParameterx not implemented");
			Delegates.pglTexParameterx(target, pname, param);
			CallLog("glTexParameterx({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexParameterxv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		public static void TexParameter(int target, int pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameterxv != null, "pglTexParameterxv not implemented");
					Delegates.pglTexParameterxv(target, pname, p_params);
					CallLog("glTexParameterxv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTranslatex.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void Translate(IntPtr x, IntPtr y, IntPtr z)
		{
			Debug.Assert(Delegates.pglTranslatex != null, "pglTranslatex not implemented");
			Delegates.pglTranslatex(x, y, z);
			CallLog("glTranslatex({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUseProgramStagesEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stages">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static void UseProgramStageEXT(UInt32 pipeline, uint stages, UInt32 program)
		{
			Debug.Assert(Delegates.pglUseProgramStagesEXT != null, "pglUseProgramStagesEXT not implemented");
			Delegates.pglUseProgramStagesEXT(pipeline, stages, program);
			CallLog("glUseProgramStagesEXT({0}, {1}, {2})", pipeline, stages, program);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glValidateProgramPipelineEXT.
		/// </summary>
		/// <param name="pipeline">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_separate_shader_objects")]
		public static void ValidateProgramPipelineEXT(UInt32 pipeline)
		{
			Debug.Assert(Delegates.pglValidateProgramPipelineEXT != null, "pglValidateProgramPipelineEXT not implemented");
			Delegates.pglValidateProgramPipelineEXT(pipeline);
			CallLog("glValidateProgramPipelineEXT({0})", pipeline);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWeightPointerOES.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void WeightPointerOES(Int32 size, int type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglWeightPointerOES != null, "pglWeightPointerOES not implemented");
			Delegates.pglWeightPointerOES(size, type, stride, pointer);
			CallLog("glWeightPointerOES({0}, {1}, {2}, {3})", size, type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWeightPointerOES.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		public static void WeightPointerOES(Int32 size, int type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				WeightPointerOES(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

	}

}
