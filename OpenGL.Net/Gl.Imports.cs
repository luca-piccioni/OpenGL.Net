
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Security;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public unsafe partial class Gl
	{
		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glAccum(int op, float value);
			[ThreadStatic]
			internal static glAccum pglAccum;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glAccumxOES(int op, IntPtr value);
			[ThreadStatic]
			internal static glAccumxOES pglAccumxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glActiveProgramEXT(UInt32 program);
			[ThreadStatic]
			internal static glActiveProgramEXT pglActiveProgramEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glActiveShaderProgram(UInt32 pipeline, UInt32 program);
			[ThreadStatic]
			internal static glActiveShaderProgram pglActiveShaderProgram;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glActiveStencilFaceEXT(int face);
			[ThreadStatic]
			internal static glActiveStencilFaceEXT pglActiveStencilFaceEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glActiveTexture(int texture);
			[ThreadStatic]
			internal static glActiveTexture pglActiveTexture;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glActiveTextureARB(int texture);
			[ThreadStatic]
			internal static glActiveTextureARB pglActiveTextureARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glActiveVaryingNV(UInt32 program, String name);
			[ThreadStatic]
			internal static glActiveVaryingNV pglActiveVaryingNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glAlphaFragmentOp1ATI(int op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);
			[ThreadStatic]
			internal static glAlphaFragmentOp1ATI pglAlphaFragmentOp1ATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glAlphaFragmentOp2ATI(int op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);
			[ThreadStatic]
			internal static glAlphaFragmentOp2ATI pglAlphaFragmentOp2ATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glAlphaFragmentOp3ATI(int op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);
			[ThreadStatic]
			internal static glAlphaFragmentOp3ATI pglAlphaFragmentOp3ATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glAlphaFunc(int func, float @ref);
			[ThreadStatic]
			internal static glAlphaFunc pglAlphaFunc;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glAlphaFuncxOES(int func, IntPtr @ref);
			[ThreadStatic]
			internal static glAlphaFuncxOES pglAlphaFuncxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glApplyTextureEXT(int mode);
			[ThreadStatic]
			internal static glApplyTextureEXT pglApplyTextureEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glAreProgramsResidentNV(Int32 n, UInt32* programs, bool* residences);
			[ThreadStatic]
			internal static glAreProgramsResidentNV pglAreProgramsResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glAreTexturesResident(Int32 n, UInt32* textures, bool* residences);
			[ThreadStatic]
			internal static glAreTexturesResident pglAreTexturesResident;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glAreTexturesResidentEXT(Int32 n, UInt32* textures, bool* residences);
			[ThreadStatic]
			internal static glAreTexturesResidentEXT pglAreTexturesResidentEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glArrayElement(Int32 i);
			[ThreadStatic]
			internal static glArrayElement pglArrayElement;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glArrayElementEXT(Int32 i);
			[ThreadStatic]
			internal static glArrayElementEXT pglArrayElementEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glArrayObjectATI(int array, Int32 size, int type, Int32 stride, UInt32 buffer, UInt32 offset);
			[ThreadStatic]
			internal static glArrayObjectATI pglArrayObjectATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glAsyncMarkerSGIX(UInt32 marker);
			[ThreadStatic]
			internal static glAsyncMarkerSGIX pglAsyncMarkerSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glAttachObjectARB(UInt32 containerObj, UInt32 obj);
			[ThreadStatic]
			internal static glAttachObjectARB pglAttachObjectARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glAttachShader(UInt32 program, UInt32 shader);
			[ThreadStatic]
			internal static glAttachShader pglAttachShader;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBegin(int mode);
			[ThreadStatic]
			internal static glBegin pglBegin;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBeginConditionalRender(UInt32 id, int mode);
			[ThreadStatic]
			internal static glBeginConditionalRender pglBeginConditionalRender;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBeginConditionalRenderNV(UInt32 id, int mode);
			[ThreadStatic]
			internal static glBeginConditionalRenderNV pglBeginConditionalRenderNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBeginConditionalRenderNVX(UInt32 id);
			[ThreadStatic]
			internal static glBeginConditionalRenderNVX pglBeginConditionalRenderNVX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBeginFragmentShaderATI();
			[ThreadStatic]
			internal static glBeginFragmentShaderATI pglBeginFragmentShaderATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBeginOcclusionQueryNV(UInt32 id);
			[ThreadStatic]
			internal static glBeginOcclusionQueryNV pglBeginOcclusionQueryNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBeginPerfMonitorAMD(UInt32 monitor);
			[ThreadStatic]
			internal static glBeginPerfMonitorAMD pglBeginPerfMonitorAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBeginPerfQueryINTEL(UInt32 queryHandle);
			[ThreadStatic]
			internal static glBeginPerfQueryINTEL pglBeginPerfQueryINTEL;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBeginQuery(int target, UInt32 id);
			[ThreadStatic]
			internal static glBeginQuery pglBeginQuery;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBeginQueryARB(int target, UInt32 id);
			[ThreadStatic]
			internal static glBeginQueryARB pglBeginQueryARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBeginQueryIndexed(int target, UInt32 index, UInt32 id);
			[ThreadStatic]
			internal static glBeginQueryIndexed pglBeginQueryIndexed;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBeginTransformFeedback(int primitiveMode);
			[ThreadStatic]
			internal static glBeginTransformFeedback pglBeginTransformFeedback;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBeginTransformFeedbackEXT(int primitiveMode);
			[ThreadStatic]
			internal static glBeginTransformFeedbackEXT pglBeginTransformFeedbackEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBeginTransformFeedbackNV(int primitiveMode);
			[ThreadStatic]
			internal static glBeginTransformFeedbackNV pglBeginTransformFeedbackNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBeginVertexShaderEXT();
			[ThreadStatic]
			internal static glBeginVertexShaderEXT pglBeginVertexShaderEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBeginVideoCaptureNV(UInt32 video_capture_slot);
			[ThreadStatic]
			internal static glBeginVideoCaptureNV pglBeginVideoCaptureNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindAttribLocation(UInt32 program, UInt32 index, String name);
			[ThreadStatic]
			internal static glBindAttribLocation pglBindAttribLocation;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindAttribLocationARB(UInt32 programObj, UInt32 index, String name);
			[ThreadStatic]
			internal static glBindAttribLocationARB pglBindAttribLocationARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindBuffer(int target, UInt32 buffer);
			[ThreadStatic]
			internal static glBindBuffer pglBindBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindBufferARB(int target, UInt32 buffer);
			[ThreadStatic]
			internal static glBindBufferARB pglBindBufferARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindBufferBase(int target, UInt32 index, UInt32 buffer);
			[ThreadStatic]
			internal static glBindBufferBase pglBindBufferBase;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindBufferBaseEXT(int target, UInt32 index, UInt32 buffer);
			[ThreadStatic]
			internal static glBindBufferBaseEXT pglBindBufferBaseEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindBufferBaseNV(int target, UInt32 index, UInt32 buffer);
			[ThreadStatic]
			internal static glBindBufferBaseNV pglBindBufferBaseNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBindBufferOffsetEXT(int target, UInt32 index, UInt32 buffer, IntPtr offset);
			[ThreadStatic]
			internal static glBindBufferOffsetEXT pglBindBufferOffsetEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBindBufferOffsetNV(int target, UInt32 index, UInt32 buffer, IntPtr offset);
			[ThreadStatic]
			internal static glBindBufferOffsetNV pglBindBufferOffsetNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBindBufferRange(int target, UInt32 index, UInt32 buffer, IntPtr offset, UInt32 size);
			[ThreadStatic]
			internal static glBindBufferRange pglBindBufferRange;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBindBufferRangeEXT(int target, UInt32 index, UInt32 buffer, IntPtr offset, UInt32 size);
			[ThreadStatic]
			internal static glBindBufferRangeEXT pglBindBufferRangeEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBindBufferRangeNV(int target, UInt32 index, UInt32 buffer, IntPtr offset, UInt32 size);
			[ThreadStatic]
			internal static glBindBufferRangeNV pglBindBufferRangeNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBindBuffersBase(int target, UInt32 first, Int32 count, UInt32* buffers);
			[ThreadStatic]
			internal static glBindBuffersBase pglBindBuffersBase;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBindBuffersRange(int target, UInt32 first, Int32 count, UInt32* buffers, IntPtr* offsets, UInt32* sizes);
			[ThreadStatic]
			internal static glBindBuffersRange pglBindBuffersRange;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindFragDataLocation(UInt32 program, UInt32 color, String name);
			[ThreadStatic]
			internal static glBindFragDataLocation pglBindFragDataLocation;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindFragDataLocationEXT(UInt32 program, UInt32 color, String name);
			[ThreadStatic]
			internal static glBindFragDataLocationEXT pglBindFragDataLocationEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, String name);
			[ThreadStatic]
			internal static glBindFragDataLocationIndexed pglBindFragDataLocationIndexed;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindFragmentShaderATI(UInt32 id);
			[ThreadStatic]
			internal static glBindFragmentShaderATI pglBindFragmentShaderATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindFramebuffer(int target, UInt32 framebuffer);
			[ThreadStatic]
			internal static glBindFramebuffer pglBindFramebuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindFramebufferEXT(int target, UInt32 framebuffer);
			[ThreadStatic]
			internal static glBindFramebufferEXT pglBindFramebufferEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindImageTexture(UInt32 unit, UInt32 texture, Int32 level, bool layered, Int32 layer, int access, int format);
			[ThreadStatic]
			internal static glBindImageTexture pglBindImageTexture;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindImageTextureEXT(UInt32 index, UInt32 texture, Int32 level, bool layered, Int32 layer, int access, Int32 format);
			[ThreadStatic]
			internal static glBindImageTextureEXT pglBindImageTextureEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBindImageTextures(UInt32 first, Int32 count, UInt32* textures);
			[ThreadStatic]
			internal static glBindImageTextures pglBindImageTextures;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glBindLightParameterEXT(int light, int value);
			[ThreadStatic]
			internal static glBindLightParameterEXT pglBindLightParameterEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glBindMaterialParameterEXT(int face, int value);
			[ThreadStatic]
			internal static glBindMaterialParameterEXT pglBindMaterialParameterEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindMultiTextureEXT(int texunit, int target, UInt32 texture);
			[ThreadStatic]
			internal static glBindMultiTextureEXT pglBindMultiTextureEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glBindParameterEXT(int value);
			[ThreadStatic]
			internal static glBindParameterEXT pglBindParameterEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindProgramARB(int target, UInt32 program);
			[ThreadStatic]
			internal static glBindProgramARB pglBindProgramARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindProgramNV(int target, UInt32 id);
			[ThreadStatic]
			internal static glBindProgramNV pglBindProgramNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindProgramPipeline(UInt32 pipeline);
			[ThreadStatic]
			internal static glBindProgramPipeline pglBindProgramPipeline;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindRenderbuffer(int target, UInt32 renderbuffer);
			[ThreadStatic]
			internal static glBindRenderbuffer pglBindRenderbuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindRenderbufferEXT(int target, UInt32 renderbuffer);
			[ThreadStatic]
			internal static glBindRenderbufferEXT pglBindRenderbufferEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindSampler(UInt32 unit, UInt32 sampler);
			[ThreadStatic]
			internal static glBindSampler pglBindSampler;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBindSamplers(UInt32 first, Int32 count, UInt32* samplers);
			[ThreadStatic]
			internal static glBindSamplers pglBindSamplers;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glBindTexGenParameterEXT(int unit, int coord, int value);
			[ThreadStatic]
			internal static glBindTexGenParameterEXT pglBindTexGenParameterEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindTexture(int target, UInt32 texture);
			[ThreadStatic]
			internal static glBindTexture pglBindTexture;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindTextureEXT(int target, UInt32 texture);
			[ThreadStatic]
			internal static glBindTextureEXT pglBindTextureEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindTextureUnit(UInt32 unit, UInt32 texture);
			[ThreadStatic]
			internal static glBindTextureUnit pglBindTextureUnit;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glBindTextureUnitParameterEXT(int unit, int value);
			[ThreadStatic]
			internal static glBindTextureUnitParameterEXT pglBindTextureUnitParameterEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBindTextures(UInt32 first, Int32 count, UInt32* textures);
			[ThreadStatic]
			internal static glBindTextures pglBindTextures;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindTransformFeedback(int target, UInt32 id);
			[ThreadStatic]
			internal static glBindTransformFeedback pglBindTransformFeedback;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindTransformFeedbackNV(int target, UInt32 id);
			[ThreadStatic]
			internal static glBindTransformFeedbackNV pglBindTransformFeedbackNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindVertexArray(UInt32 array);
			[ThreadStatic]
			internal static glBindVertexArray pglBindVertexArray;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindVertexArrayAPPLE(UInt32 array);
			[ThreadStatic]
			internal static glBindVertexArrayAPPLE pglBindVertexArrayAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBindVertexBuffer(UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);
			[ThreadStatic]
			internal static glBindVertexBuffer pglBindVertexBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBindVertexBuffers(UInt32 first, Int32 count, UInt32* buffers, IntPtr* offsets, Int32* strides);
			[ThreadStatic]
			internal static glBindVertexBuffers pglBindVertexBuffers;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindVertexShaderEXT(UInt32 id);
			[ThreadStatic]
			internal static glBindVertexShaderEXT pglBindVertexShaderEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBindVideoCaptureStreamBufferNV(UInt32 video_capture_slot, UInt32 stream, int frame_region, IntPtr offset);
			[ThreadStatic]
			internal static glBindVideoCaptureStreamBufferNV pglBindVideoCaptureStreamBufferNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindVideoCaptureStreamTextureNV(UInt32 video_capture_slot, UInt32 stream, int frame_region, int target, UInt32 texture);
			[ThreadStatic]
			internal static glBindVideoCaptureStreamTextureNV pglBindVideoCaptureStreamTextureNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBinormal3bEXT(sbyte bx, sbyte by, sbyte bz);
			[ThreadStatic]
			internal static glBinormal3bEXT pglBinormal3bEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBinormal3bvEXT(sbyte* v);
			[ThreadStatic]
			internal static glBinormal3bvEXT pglBinormal3bvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBinormal3dEXT(double bx, double by, double bz);
			[ThreadStatic]
			internal static glBinormal3dEXT pglBinormal3dEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBinormal3dvEXT(double* v);
			[ThreadStatic]
			internal static glBinormal3dvEXT pglBinormal3dvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBinormal3fEXT(float bx, float by, float bz);
			[ThreadStatic]
			internal static glBinormal3fEXT pglBinormal3fEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBinormal3fvEXT(float* v);
			[ThreadStatic]
			internal static glBinormal3fvEXT pglBinormal3fvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBinormal3iEXT(Int32 bx, Int32 by, Int32 bz);
			[ThreadStatic]
			internal static glBinormal3iEXT pglBinormal3iEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBinormal3ivEXT(Int32* v);
			[ThreadStatic]
			internal static glBinormal3ivEXT pglBinormal3ivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBinormal3sEXT(Int16 bx, Int16 by, Int16 bz);
			[ThreadStatic]
			internal static glBinormal3sEXT pglBinormal3sEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBinormal3svEXT(Int16* v);
			[ThreadStatic]
			internal static glBinormal3svEXT pglBinormal3svEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBinormalPointerEXT(int type, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glBinormalPointerEXT pglBinormalPointerEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBitmap(Int32 width, Int32 height, float xorig, float yorig, float xmove, float ymove, byte* bitmap);
			[ThreadStatic]
			internal static glBitmap pglBitmap;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBitmapxOES(Int32 width, Int32 height, IntPtr xorig, IntPtr yorig, IntPtr xmove, IntPtr ymove, byte* bitmap);
			[ThreadStatic]
			internal static glBitmapxOES pglBitmapxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendBarrierKHR();
			[ThreadStatic]
			internal static glBlendBarrierKHR pglBlendBarrierKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendBarrierNV();
			[ThreadStatic]
			internal static glBlendBarrierNV pglBlendBarrierNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendColor(float red, float green, float blue, float alpha);
			[ThreadStatic]
			internal static glBlendColor pglBlendColor;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendColorEXT(float red, float green, float blue, float alpha);
			[ThreadStatic]
			internal static glBlendColorEXT pglBlendColorEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBlendColorxOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);
			[ThreadStatic]
			internal static glBlendColorxOES pglBlendColorxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendEquation(int mode);
			[ThreadStatic]
			internal static glBlendEquation pglBlendEquation;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendEquationEXT(int mode);
			[ThreadStatic]
			internal static glBlendEquationEXT pglBlendEquationEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendEquationIndexedAMD(UInt32 buf, int mode);
			[ThreadStatic]
			internal static glBlendEquationIndexedAMD pglBlendEquationIndexedAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendEquationSeparate(int modeRGB, int modeAlpha);
			[ThreadStatic]
			internal static glBlendEquationSeparate pglBlendEquationSeparate;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendEquationSeparateEXT(int modeRGB, int modeAlpha);
			[ThreadStatic]
			internal static glBlendEquationSeparateEXT pglBlendEquationSeparateEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendEquationSeparateIndexedAMD(UInt32 buf, int modeRGB, int modeAlpha);
			[ThreadStatic]
			internal static glBlendEquationSeparateIndexedAMD pglBlendEquationSeparateIndexedAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendEquationSeparatei(UInt32 buf, int modeRGB, int modeAlpha);
			[ThreadStatic]
			internal static glBlendEquationSeparatei pglBlendEquationSeparatei;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendEquationSeparateiARB(UInt32 buf, int modeRGB, int modeAlpha);
			[ThreadStatic]
			internal static glBlendEquationSeparateiARB pglBlendEquationSeparateiARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendEquationi(UInt32 buf, int mode);
			[ThreadStatic]
			internal static glBlendEquationi pglBlendEquationi;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendEquationiARB(UInt32 buf, int mode);
			[ThreadStatic]
			internal static glBlendEquationiARB pglBlendEquationiARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendFunc(int sfactor, int dfactor);
			[ThreadStatic]
			internal static glBlendFunc pglBlendFunc;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendFuncIndexedAMD(UInt32 buf, int src, int dst);
			[ThreadStatic]
			internal static glBlendFuncIndexedAMD pglBlendFuncIndexedAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendFuncSeparate(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha);
			[ThreadStatic]
			internal static glBlendFuncSeparate pglBlendFuncSeparate;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendFuncSeparateEXT(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha);
			[ThreadStatic]
			internal static glBlendFuncSeparateEXT pglBlendFuncSeparateEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendFuncSeparateINGR(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha);
			[ThreadStatic]
			internal static glBlendFuncSeparateINGR pglBlendFuncSeparateINGR;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendFuncSeparateIndexedAMD(UInt32 buf, int srcRGB, int dstRGB, int srcAlpha, int dstAlpha);
			[ThreadStatic]
			internal static glBlendFuncSeparateIndexedAMD pglBlendFuncSeparateIndexedAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendFuncSeparatei(UInt32 buf, int srcRGB, int dstRGB, int srcAlpha, int dstAlpha);
			[ThreadStatic]
			internal static glBlendFuncSeparatei pglBlendFuncSeparatei;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendFuncSeparateiARB(UInt32 buf, int srcRGB, int dstRGB, int srcAlpha, int dstAlpha);
			[ThreadStatic]
			internal static glBlendFuncSeparateiARB pglBlendFuncSeparateiARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendFunci(UInt32 buf, int src, int dst);
			[ThreadStatic]
			internal static glBlendFunci pglBlendFunci;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendFunciARB(UInt32 buf, int src, int dst);
			[ThreadStatic]
			internal static glBlendFunciARB pglBlendFunciARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendParameteriNV(int pname, Int32 value);
			[ThreadStatic]
			internal static glBlendParameteriNV pglBlendParameteriNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, uint mask, int filter);
			[ThreadStatic]
			internal static glBlitFramebuffer pglBlitFramebuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlitFramebufferEXT(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, uint mask, int filter);
			[ThreadStatic]
			internal static glBlitFramebufferEXT pglBlitFramebufferEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlitNamedFramebuffer(UInt32 readFramebuffer, UInt32 drawFramebuffer, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, uint mask, int filter);
			[ThreadStatic]
			internal static glBlitNamedFramebuffer pglBlitNamedFramebuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBufferAddressRangeNV(int pname, UInt32 index, UInt64 address, UInt32 length);
			[ThreadStatic]
			internal static glBufferAddressRangeNV pglBufferAddressRangeNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBufferData(int target, UInt32 size, IntPtr data, int usage);
			[ThreadStatic]
			internal static glBufferData pglBufferData;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBufferDataARB(int target, UInt32 size, IntPtr data, int usage);
			[ThreadStatic]
			internal static glBufferDataARB pglBufferDataARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBufferPageCommitmentARB(int target, IntPtr offset, UInt32 size, bool commit);
			[ThreadStatic]
			internal static glBufferPageCommitmentARB pglBufferPageCommitmentARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBufferParameteriAPPLE(int target, int pname, Int32 param);
			[ThreadStatic]
			internal static glBufferParameteriAPPLE pglBufferParameteriAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBufferStorage(int target, UInt32 size, IntPtr data, uint flags);
			[ThreadStatic]
			internal static glBufferStorage pglBufferStorage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBufferSubData(int target, IntPtr offset, UInt32 size, IntPtr data);
			[ThreadStatic]
			internal static glBufferSubData pglBufferSubData;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBufferSubDataARB(int target, IntPtr offset, UInt32 size, IntPtr data);
			[ThreadStatic]
			internal static glBufferSubDataARB pglBufferSubDataARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCallList(UInt32 list);
			[ThreadStatic]
			internal static glCallList pglCallList;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCallLists(Int32 n, int type, IntPtr lists);
			[ThreadStatic]
			internal static glCallLists pglCallLists;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int glCheckFramebufferStatus(int target);
			[ThreadStatic]
			internal static glCheckFramebufferStatus pglCheckFramebufferStatus;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int glCheckFramebufferStatusEXT(int target);
			[ThreadStatic]
			internal static glCheckFramebufferStatusEXT pglCheckFramebufferStatusEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int glCheckNamedFramebufferStatus(UInt32 framebuffer, int target);
			[ThreadStatic]
			internal static glCheckNamedFramebufferStatus pglCheckNamedFramebufferStatus;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int glCheckNamedFramebufferStatusEXT(UInt32 framebuffer, int target);
			[ThreadStatic]
			internal static glCheckNamedFramebufferStatusEXT pglCheckNamedFramebufferStatusEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClampColor(int target, int clamp);
			[ThreadStatic]
			internal static glClampColor pglClampColor;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClampColorARB(int target, int clamp);
			[ThreadStatic]
			internal static glClampColorARB pglClampColorARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClear(uint mask);
			[ThreadStatic]
			internal static glClear pglClear;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearAccum(float red, float green, float blue, float alpha);
			[ThreadStatic]
			internal static glClearAccum pglClearAccum;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearAccumxOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);
			[ThreadStatic]
			internal static glClearAccumxOES pglClearAccumxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearBufferData(int target, int internalformat, int format, int type, IntPtr data);
			[ThreadStatic]
			internal static glClearBufferData pglClearBufferData;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearBufferSubData(int target, int internalformat, IntPtr offset, UInt32 size, int format, int type, IntPtr data);
			[ThreadStatic]
			internal static glClearBufferSubData pglClearBufferSubData;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearBufferfi(int buffer, Int32 drawbuffer, float depth, Int32 stencil);
			[ThreadStatic]
			internal static glClearBufferfi pglClearBufferfi;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearBufferfv(int buffer, Int32 drawbuffer, float* value);
			[ThreadStatic]
			internal static glClearBufferfv pglClearBufferfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearBufferiv(int buffer, Int32 drawbuffer, Int32* value);
			[ThreadStatic]
			internal static glClearBufferiv pglClearBufferiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearBufferuiv(int buffer, Int32 drawbuffer, UInt32* value);
			[ThreadStatic]
			internal static glClearBufferuiv pglClearBufferuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearColor(float red, float green, float blue, float alpha);
			[ThreadStatic]
			internal static glClearColor pglClearColor;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearColorIiEXT(Int32 red, Int32 green, Int32 blue, Int32 alpha);
			[ThreadStatic]
			internal static glClearColorIiEXT pglClearColorIiEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearColorIuiEXT(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);
			[ThreadStatic]
			internal static glClearColorIuiEXT pglClearColorIuiEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearColorxOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);
			[ThreadStatic]
			internal static glClearColorxOES pglClearColorxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearDepth(double depth);
			[ThreadStatic]
			internal static glClearDepth pglClearDepth;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearDepthdNV(double depth);
			[ThreadStatic]
			internal static glClearDepthdNV pglClearDepthdNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearDepthf(float d);
			[ThreadStatic]
			internal static glClearDepthf pglClearDepthf;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearDepthfOES(float depth);
			[ThreadStatic]
			internal static glClearDepthfOES pglClearDepthfOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearDepthxOES(IntPtr depth);
			[ThreadStatic]
			internal static glClearDepthxOES pglClearDepthxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearIndex(float c);
			[ThreadStatic]
			internal static glClearIndex pglClearIndex;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearNamedBufferData(UInt32 buffer, int internalformat, int format, int type, IntPtr data);
			[ThreadStatic]
			internal static glClearNamedBufferData pglClearNamedBufferData;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearNamedBufferDataEXT(UInt32 buffer, int internalformat, int format, int type, IntPtr data);
			[ThreadStatic]
			internal static glClearNamedBufferDataEXT pglClearNamedBufferDataEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearNamedBufferSubData(UInt32 buffer, int internalformat, IntPtr offset, UInt32 size, int format, int type, IntPtr data);
			[ThreadStatic]
			internal static glClearNamedBufferSubData pglClearNamedBufferSubData;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearNamedBufferSubDataEXT(UInt32 buffer, int internalformat, UInt32 offset, UInt32 size, int format, int type, IntPtr data);
			[ThreadStatic]
			internal static glClearNamedBufferSubDataEXT pglClearNamedBufferSubDataEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearNamedFramebufferfi(UInt32 framebuffer, int buffer, float depth, Int32 stencil);
			[ThreadStatic]
			internal static glClearNamedFramebufferfi pglClearNamedFramebufferfi;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearNamedFramebufferfv(UInt32 framebuffer, int buffer, Int32 drawbuffer, float* value);
			[ThreadStatic]
			internal static glClearNamedFramebufferfv pglClearNamedFramebufferfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearNamedFramebufferiv(UInt32 framebuffer, int buffer, Int32 drawbuffer, Int32* value);
			[ThreadStatic]
			internal static glClearNamedFramebufferiv pglClearNamedFramebufferiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearNamedFramebufferuiv(UInt32 framebuffer, int buffer, Int32 drawbuffer, UInt32* value);
			[ThreadStatic]
			internal static glClearNamedFramebufferuiv pglClearNamedFramebufferuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearStencil(Int32 s);
			[ThreadStatic]
			internal static glClearStencil pglClearStencil;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearTexImage(UInt32 texture, Int32 level, int format, int type, IntPtr data);
			[ThreadStatic]
			internal static glClearTexImage pglClearTexImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, IntPtr data);
			[ThreadStatic]
			internal static glClearTexSubImage pglClearTexSubImage;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClientActiveTexture(int texture);
			[ThreadStatic]
			internal static glClientActiveTexture pglClientActiveTexture;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClientActiveTextureARB(int texture);
			[ThreadStatic]
			internal static glClientActiveTextureARB pglClientActiveTextureARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClientActiveVertexStreamATI(int stream);
			[ThreadStatic]
			internal static glClientActiveVertexStreamATI pglClientActiveVertexStreamATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClientAttribDefaultEXT(uint mask);
			[ThreadStatic]
			internal static glClientAttribDefaultEXT pglClientAttribDefaultEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int glClientWaitSync(int sync, uint flags, UInt64 timeout);
			[ThreadStatic]
			internal static glClientWaitSync pglClientWaitSync;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClipControl(int origin, int depth);
			[ThreadStatic]
			internal static glClipControl pglClipControl;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClipPlane(int plane, double* equation);
			[ThreadStatic]
			internal static glClipPlane pglClipPlane;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClipPlanefOES(int plane, float* equation);
			[ThreadStatic]
			internal static glClipPlanefOES pglClipPlanefOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClipPlanexOES(int plane, IntPtr* equation);
			[ThreadStatic]
			internal static glClipPlanexOES pglClipPlanexOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3b(sbyte red, sbyte green, sbyte blue);
			[ThreadStatic]
			internal static glColor3b pglColor3b;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3bv(sbyte* v);
			[ThreadStatic]
			internal static glColor3bv pglColor3bv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3d(double red, double green, double blue);
			[ThreadStatic]
			internal static glColor3d pglColor3d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3dv(double* v);
			[ThreadStatic]
			internal static glColor3dv pglColor3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3f(float red, float green, float blue);
			[ThreadStatic]
			internal static glColor3f pglColor3f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3fVertex3fSUN(float r, float g, float b, float x, float y, float z);
			[ThreadStatic]
			internal static glColor3fVertex3fSUN pglColor3fVertex3fSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3fVertex3fvSUN(float* c, float* v);
			[ThreadStatic]
			internal static glColor3fVertex3fvSUN pglColor3fVertex3fvSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3fv(float* v);
			[ThreadStatic]
			internal static glColor3fv pglColor3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3hNV(UInt16 red, UInt16 green, UInt16 blue);
			[ThreadStatic]
			internal static glColor3hNV pglColor3hNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3hvNV(UInt16* v);
			[ThreadStatic]
			internal static glColor3hvNV pglColor3hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3i(Int32 red, Int32 green, Int32 blue);
			[ThreadStatic]
			internal static glColor3i pglColor3i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3iv(Int32* v);
			[ThreadStatic]
			internal static glColor3iv pglColor3iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3s(Int16 red, Int16 green, Int16 blue);
			[ThreadStatic]
			internal static glColor3s pglColor3s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3sv(Int16* v);
			[ThreadStatic]
			internal static glColor3sv pglColor3sv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3ub(byte red, byte green, byte blue);
			[ThreadStatic]
			internal static glColor3ub pglColor3ub;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3ubv(byte* v);
			[ThreadStatic]
			internal static glColor3ubv pglColor3ubv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3ui(UInt32 red, UInt32 green, UInt32 blue);
			[ThreadStatic]
			internal static glColor3ui pglColor3ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3uiv(UInt32* v);
			[ThreadStatic]
			internal static glColor3uiv pglColor3uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3us(UInt16 red, UInt16 green, UInt16 blue);
			[ThreadStatic]
			internal static glColor3us pglColor3us;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3usv(UInt16* v);
			[ThreadStatic]
			internal static glColor3usv pglColor3usv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3xOES(IntPtr red, IntPtr green, IntPtr blue);
			[ThreadStatic]
			internal static glColor3xOES pglColor3xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3xvOES(IntPtr* components);
			[ThreadStatic]
			internal static glColor3xvOES pglColor3xvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);
			[ThreadStatic]
			internal static glColor4b pglColor4b;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4bv(sbyte* v);
			[ThreadStatic]
			internal static glColor4bv pglColor4bv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4d(double red, double green, double blue, double alpha);
			[ThreadStatic]
			internal static glColor4d pglColor4d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4dv(double* v);
			[ThreadStatic]
			internal static glColor4dv pglColor4dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4f(float red, float green, float blue, float alpha);
			[ThreadStatic]
			internal static glColor4f pglColor4f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4fNormal3fVertex3fSUN(float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
			[ThreadStatic]
			internal static glColor4fNormal3fVertex3fSUN pglColor4fNormal3fVertex3fSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4fNormal3fVertex3fvSUN(float* c, float* n, float* v);
			[ThreadStatic]
			internal static glColor4fNormal3fVertex3fvSUN pglColor4fNormal3fVertex3fvSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4fv(float* v);
			[ThreadStatic]
			internal static glColor4fv pglColor4fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4hNV(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);
			[ThreadStatic]
			internal static glColor4hNV pglColor4hNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4hvNV(UInt16* v);
			[ThreadStatic]
			internal static glColor4hvNV pglColor4hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4i(Int32 red, Int32 green, Int32 blue, Int32 alpha);
			[ThreadStatic]
			internal static glColor4i pglColor4i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4iv(Int32* v);
			[ThreadStatic]
			internal static glColor4iv pglColor4iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4s(Int16 red, Int16 green, Int16 blue, Int16 alpha);
			[ThreadStatic]
			internal static glColor4s pglColor4s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4sv(Int16* v);
			[ThreadStatic]
			internal static glColor4sv pglColor4sv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4ub(byte red, byte green, byte blue, byte alpha);
			[ThreadStatic]
			internal static glColor4ub pglColor4ub;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4ubVertex2fSUN(byte r, byte g, byte b, byte a, float x, float y);
			[ThreadStatic]
			internal static glColor4ubVertex2fSUN pglColor4ubVertex2fSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4ubVertex2fvSUN(byte* c, float* v);
			[ThreadStatic]
			internal static glColor4ubVertex2fvSUN pglColor4ubVertex2fvSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4ubVertex3fSUN(byte r, byte g, byte b, byte a, float x, float y, float z);
			[ThreadStatic]
			internal static glColor4ubVertex3fSUN pglColor4ubVertex3fSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4ubVertex3fvSUN(byte* c, float* v);
			[ThreadStatic]
			internal static glColor4ubVertex3fvSUN pglColor4ubVertex3fvSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4ubv(byte* v);
			[ThreadStatic]
			internal static glColor4ubv pglColor4ubv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4ui(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);
			[ThreadStatic]
			internal static glColor4ui pglColor4ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4uiv(UInt32* v);
			[ThreadStatic]
			internal static glColor4uiv pglColor4uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4us(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);
			[ThreadStatic]
			internal static glColor4us pglColor4us;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4usv(UInt16* v);
			[ThreadStatic]
			internal static glColor4usv pglColor4usv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4xOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);
			[ThreadStatic]
			internal static glColor4xOES pglColor4xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4xvOES(IntPtr* components);
			[ThreadStatic]
			internal static glColor4xvOES pglColor4xvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColorFormatNV(Int32 size, int type, Int32 stride);
			[ThreadStatic]
			internal static glColorFormatNV pglColorFormatNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColorFragmentOp1ATI(int op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);
			[ThreadStatic]
			internal static glColorFragmentOp1ATI pglColorFragmentOp1ATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColorFragmentOp2ATI(int op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);
			[ThreadStatic]
			internal static glColorFragmentOp2ATI pglColorFragmentOp2ATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColorFragmentOp3ATI(int op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);
			[ThreadStatic]
			internal static glColorFragmentOp3ATI pglColorFragmentOp3ATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColorMask(bool red, bool green, bool blue, bool alpha);
			[ThreadStatic]
			internal static glColorMask pglColorMask;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColorMaskIndexedEXT(UInt32 index, bool r, bool g, bool b, bool a);
			[ThreadStatic]
			internal static glColorMaskIndexedEXT pglColorMaskIndexedEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColorMaski(UInt32 index, bool r, bool g, bool b, bool a);
			[ThreadStatic]
			internal static glColorMaski pglColorMaski;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColorMaterial(int face, int mode);
			[ThreadStatic]
			internal static glColorMaterial pglColorMaterial;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColorP3ui(int type, UInt32 color);
			[ThreadStatic]
			internal static glColorP3ui pglColorP3ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColorP3uiv(int type, UInt32* color);
			[ThreadStatic]
			internal static glColorP3uiv pglColorP3uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColorP4ui(int type, UInt32 color);
			[ThreadStatic]
			internal static glColorP4ui pglColorP4ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColorP4uiv(int type, UInt32* color);
			[ThreadStatic]
			internal static glColorP4uiv pglColorP4uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColorPointer(Int32 size, int type, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glColorPointer pglColorPointer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColorPointerEXT(Int32 size, int type, Int32 stride, Int32 count, IntPtr pointer);
			[ThreadStatic]
			internal static glColorPointerEXT pglColorPointerEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColorPointerListIBM(Int32 size, int type, Int32 stride, IntPtr* pointer, Int32 ptrstride);
			[ThreadStatic]
			internal static glColorPointerListIBM pglColorPointerListIBM;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColorPointervINTEL(Int32 size, int type, IntPtr* pointer);
			[ThreadStatic]
			internal static glColorPointervINTEL pglColorPointervINTEL;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColorSubTable(int target, Int32 start, Int32 count, int format, int type, IntPtr data);
			[ThreadStatic]
			internal static glColorSubTable pglColorSubTable;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColorSubTableEXT(int target, Int32 start, Int32 count, int format, int type, IntPtr data);
			[ThreadStatic]
			internal static glColorSubTableEXT pglColorSubTableEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColorTable(int target, int internalformat, Int32 width, int format, int type, IntPtr table);
			[ThreadStatic]
			internal static glColorTable pglColorTable;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColorTableEXT(int target, int internalFormat, Int32 width, int format, int type, IntPtr table);
			[ThreadStatic]
			internal static glColorTableEXT pglColorTableEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColorTableParameterfv(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glColorTableParameterfv pglColorTableParameterfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColorTableParameterfvSGI(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glColorTableParameterfvSGI pglColorTableParameterfvSGI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColorTableParameteriv(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glColorTableParameteriv pglColorTableParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColorTableParameterivSGI(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glColorTableParameterivSGI pglColorTableParameterivSGI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColorTableSGI(int target, int internalformat, Int32 width, int format, int type, IntPtr table);
			[ThreadStatic]
			internal static glColorTableSGI pglColorTableSGI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCombinerInputNV(int stage, int portion, int variable, int input, int mapping, int componentUsage);
			[ThreadStatic]
			internal static glCombinerInputNV pglCombinerInputNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCombinerOutputNV(int stage, int portion, int abOutput, int cdOutput, int sumOutput, int scale, int bias, bool abDotProduct, bool cdDotProduct, bool muxSum);
			[ThreadStatic]
			internal static glCombinerOutputNV pglCombinerOutputNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCombinerParameterfNV(int pname, float param);
			[ThreadStatic]
			internal static glCombinerParameterfNV pglCombinerParameterfNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCombinerParameterfvNV(int pname, float* @params);
			[ThreadStatic]
			internal static glCombinerParameterfvNV pglCombinerParameterfvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCombinerParameteriNV(int pname, Int32 param);
			[ThreadStatic]
			internal static glCombinerParameteriNV pglCombinerParameteriNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCombinerParameterivNV(int pname, Int32* @params);
			[ThreadStatic]
			internal static glCombinerParameterivNV pglCombinerParameterivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCombinerStageParameterfvNV(int stage, int pname, float* @params);
			[ThreadStatic]
			internal static glCombinerStageParameterfvNV pglCombinerStageParameterfvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCompileShader(UInt32 shader);
			[ThreadStatic]
			internal static glCompileShader pglCompileShader;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCompileShaderARB(UInt32 shaderObj);
			[ThreadStatic]
			internal static glCompileShaderARB pglCompileShaderARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompileShaderIncludeARB(UInt32 shader, Int32 count, String[] path, Int32* length);
			[ThreadStatic]
			internal static glCompileShaderIncludeARB pglCompileShaderIncludeARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedMultiTexImage1DEXT(int texunit, int target, Int32 level, int internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr bits);
			[ThreadStatic]
			internal static glCompressedMultiTexImage1DEXT pglCompressedMultiTexImage1DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedMultiTexImage2DEXT(int texunit, int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr bits);
			[ThreadStatic]
			internal static glCompressedMultiTexImage2DEXT pglCompressedMultiTexImage2DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedMultiTexImage3DEXT(int texunit, int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr bits);
			[ThreadStatic]
			internal static glCompressedMultiTexImage3DEXT pglCompressedMultiTexImage3DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedMultiTexSubImage1DEXT(int texunit, int target, Int32 level, Int32 xoffset, Int32 width, int format, Int32 imageSize, IntPtr bits);
			[ThreadStatic]
			internal static glCompressedMultiTexSubImage1DEXT pglCompressedMultiTexSubImage1DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedMultiTexSubImage2DEXT(int texunit, int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, Int32 imageSize, IntPtr bits);
			[ThreadStatic]
			internal static glCompressedMultiTexSubImage2DEXT pglCompressedMultiTexSubImage2DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedMultiTexSubImage3DEXT(int texunit, int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, Int32 imageSize, IntPtr bits);
			[ThreadStatic]
			internal static glCompressedMultiTexSubImage3DEXT pglCompressedMultiTexSubImage3DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTexImage1D(int target, Int32 level, int internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);
			[ThreadStatic]
			internal static glCompressedTexImage1D pglCompressedTexImage1D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTexImage1DARB(int target, Int32 level, int internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);
			[ThreadStatic]
			internal static glCompressedTexImage1DARB pglCompressedTexImage1DARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTexImage2D(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
			[ThreadStatic]
			internal static glCompressedTexImage2D pglCompressedTexImage2D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTexImage2DARB(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
			[ThreadStatic]
			internal static glCompressedTexImage2DARB pglCompressedTexImage2DARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTexImage3D(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
			[ThreadStatic]
			internal static glCompressedTexImage3D pglCompressedTexImage3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTexImage3DARB(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
			[ThreadStatic]
			internal static glCompressedTexImage3DARB pglCompressedTexImage3DARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 width, int format, Int32 imageSize, IntPtr data);
			[ThreadStatic]
			internal static glCompressedTexSubImage1D pglCompressedTexSubImage1D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTexSubImage1DARB(int target, Int32 level, Int32 xoffset, Int32 width, int format, Int32 imageSize, IntPtr data);
			[ThreadStatic]
			internal static glCompressedTexSubImage1DARB pglCompressedTexSubImage1DARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, Int32 imageSize, IntPtr data);
			[ThreadStatic]
			internal static glCompressedTexSubImage2D pglCompressedTexSubImage2D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTexSubImage2DARB(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, Int32 imageSize, IntPtr data);
			[ThreadStatic]
			internal static glCompressedTexSubImage2DARB pglCompressedTexSubImage2DARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, Int32 imageSize, IntPtr data);
			[ThreadStatic]
			internal static glCompressedTexSubImage3D pglCompressedTexSubImage3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTexSubImage3DARB(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, Int32 imageSize, IntPtr data);
			[ThreadStatic]
			internal static glCompressedTexSubImage3DARB pglCompressedTexSubImage3DARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTextureImage1DEXT(UInt32 texture, int target, Int32 level, int internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr bits);
			[ThreadStatic]
			internal static glCompressedTextureImage1DEXT pglCompressedTextureImage1DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTextureImage2DEXT(UInt32 texture, int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr bits);
			[ThreadStatic]
			internal static glCompressedTextureImage2DEXT pglCompressedTextureImage2DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTextureImage3DEXT(UInt32 texture, int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr bits);
			[ThreadStatic]
			internal static glCompressedTextureImage3DEXT pglCompressedTextureImage3DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, int format, Int32 imageSize, IntPtr data);
			[ThreadStatic]
			internal static glCompressedTextureSubImage1D pglCompressedTextureSubImage1D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTextureSubImage1DEXT(UInt32 texture, int target, Int32 level, Int32 xoffset, Int32 width, int format, Int32 imageSize, IntPtr bits);
			[ThreadStatic]
			internal static glCompressedTextureSubImage1DEXT pglCompressedTextureSubImage1DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, Int32 imageSize, IntPtr data);
			[ThreadStatic]
			internal static glCompressedTextureSubImage2D pglCompressedTextureSubImage2D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTextureSubImage2DEXT(UInt32 texture, int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, Int32 imageSize, IntPtr bits);
			[ThreadStatic]
			internal static glCompressedTextureSubImage2DEXT pglCompressedTextureSubImage2DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, Int32 imageSize, IntPtr data);
			[ThreadStatic]
			internal static glCompressedTextureSubImage3D pglCompressedTextureSubImage3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCompressedTextureSubImage3DEXT(UInt32 texture, int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, Int32 imageSize, IntPtr bits);
			[ThreadStatic]
			internal static glCompressedTextureSubImage3DEXT pglCompressedTextureSubImage3DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glConvolutionFilter1D(int target, int internalformat, Int32 width, int format, int type, IntPtr image);
			[ThreadStatic]
			internal static glConvolutionFilter1D pglConvolutionFilter1D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glConvolutionFilter1DEXT(int target, int internalformat, Int32 width, int format, int type, IntPtr image);
			[ThreadStatic]
			internal static glConvolutionFilter1DEXT pglConvolutionFilter1DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glConvolutionFilter2D(int target, int internalformat, Int32 width, Int32 height, int format, int type, IntPtr image);
			[ThreadStatic]
			internal static glConvolutionFilter2D pglConvolutionFilter2D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glConvolutionFilter2DEXT(int target, int internalformat, Int32 width, Int32 height, int format, int type, IntPtr image);
			[ThreadStatic]
			internal static glConvolutionFilter2DEXT pglConvolutionFilter2DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glConvolutionParameterf(int target, int pname, float @params);
			[ThreadStatic]
			internal static glConvolutionParameterf pglConvolutionParameterf;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glConvolutionParameterfEXT(int target, int pname, float @params);
			[ThreadStatic]
			internal static glConvolutionParameterfEXT pglConvolutionParameterfEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glConvolutionParameterfv(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glConvolutionParameterfv pglConvolutionParameterfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glConvolutionParameterfvEXT(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glConvolutionParameterfvEXT pglConvolutionParameterfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glConvolutionParameteri(int target, int pname, Int32 @params);
			[ThreadStatic]
			internal static glConvolutionParameteri pglConvolutionParameteri;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glConvolutionParameteriEXT(int target, int pname, Int32 @params);
			[ThreadStatic]
			internal static glConvolutionParameteriEXT pglConvolutionParameteriEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glConvolutionParameteriv(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glConvolutionParameteriv pglConvolutionParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glConvolutionParameterivEXT(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glConvolutionParameterivEXT pglConvolutionParameterivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glConvolutionParameterxOES(int target, int pname, IntPtr param);
			[ThreadStatic]
			internal static glConvolutionParameterxOES pglConvolutionParameterxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glConvolutionParameterxvOES(int target, int pname, IntPtr* @params);
			[ThreadStatic]
			internal static glConvolutionParameterxvOES pglConvolutionParameterxvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCopyBufferSubData(int readTarget, int writeTarget, IntPtr readOffset, IntPtr writeOffset, UInt32 size);
			[ThreadStatic]
			internal static glCopyBufferSubData pglCopyBufferSubData;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyColorSubTable(int target, Int32 start, Int32 x, Int32 y, Int32 width);
			[ThreadStatic]
			internal static glCopyColorSubTable pglCopyColorSubTable;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyColorSubTableEXT(int target, Int32 start, Int32 x, Int32 y, Int32 width);
			[ThreadStatic]
			internal static glCopyColorSubTableEXT pglCopyColorSubTableEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyColorTable(int target, int internalformat, Int32 x, Int32 y, Int32 width);
			[ThreadStatic]
			internal static glCopyColorTable pglCopyColorTable;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyColorTableSGI(int target, int internalformat, Int32 x, Int32 y, Int32 width);
			[ThreadStatic]
			internal static glCopyColorTableSGI pglCopyColorTableSGI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyConvolutionFilter1D(int target, int internalformat, Int32 x, Int32 y, Int32 width);
			[ThreadStatic]
			internal static glCopyConvolutionFilter1D pglCopyConvolutionFilter1D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyConvolutionFilter1DEXT(int target, int internalformat, Int32 x, Int32 y, Int32 width);
			[ThreadStatic]
			internal static glCopyConvolutionFilter1DEXT pglCopyConvolutionFilter1DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyConvolutionFilter2D(int target, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glCopyConvolutionFilter2D pglCopyConvolutionFilter2D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyConvolutionFilter2DEXT(int target, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glCopyConvolutionFilter2DEXT pglCopyConvolutionFilter2DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyImageSubData(UInt32 srcName, int srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, int dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth);
			[ThreadStatic]
			internal static glCopyImageSubData pglCopyImageSubData;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyImageSubDataNV(UInt32 srcName, int srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, int dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 width, Int32 height, Int32 depth);
			[ThreadStatic]
			internal static glCopyImageSubDataNV pglCopyImageSubDataNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyMultiTexImage1DEXT(int texunit, int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
			[ThreadStatic]
			internal static glCopyMultiTexImage1DEXT pglCopyMultiTexImage1DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyMultiTexImage2DEXT(int texunit, int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
			[ThreadStatic]
			internal static glCopyMultiTexImage2DEXT pglCopyMultiTexImage2DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyMultiTexSubImage1DEXT(int texunit, int target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
			[ThreadStatic]
			internal static glCopyMultiTexSubImage1DEXT pglCopyMultiTexSubImage1DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyMultiTexSubImage2DEXT(int texunit, int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glCopyMultiTexSubImage2DEXT pglCopyMultiTexSubImage2DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyMultiTexSubImage3DEXT(int texunit, int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glCopyMultiTexSubImage3DEXT pglCopyMultiTexSubImage3DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCopyNamedBufferSubData(UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, UInt32 size);
			[ThreadStatic]
			internal static glCopyNamedBufferSubData pglCopyNamedBufferSubData;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyPathNV(UInt32 resultPath, UInt32 srcPath);
			[ThreadStatic]
			internal static glCopyPathNV pglCopyPathNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, int type);
			[ThreadStatic]
			internal static glCopyPixels pglCopyPixels;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTexImage1D(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
			[ThreadStatic]
			internal static glCopyTexImage1D pglCopyTexImage1D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTexImage1DEXT(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
			[ThreadStatic]
			internal static glCopyTexImage1DEXT pglCopyTexImage1DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTexImage2D(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
			[ThreadStatic]
			internal static glCopyTexImage2D pglCopyTexImage2D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTexImage2DEXT(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
			[ThreadStatic]
			internal static glCopyTexImage2DEXT pglCopyTexImage2DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
			[ThreadStatic]
			internal static glCopyTexSubImage1D pglCopyTexSubImage1D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTexSubImage1DEXT(int target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
			[ThreadStatic]
			internal static glCopyTexSubImage1DEXT pglCopyTexSubImage1DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glCopyTexSubImage2D pglCopyTexSubImage2D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTexSubImage2DEXT(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glCopyTexSubImage2DEXT pglCopyTexSubImage2DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glCopyTexSubImage3D pglCopyTexSubImage3D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTexSubImage3DEXT(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glCopyTexSubImage3DEXT pglCopyTexSubImage3DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTextureImage1DEXT(UInt32 texture, int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
			[ThreadStatic]
			internal static glCopyTextureImage1DEXT pglCopyTextureImage1DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTextureImage2DEXT(UInt32 texture, int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
			[ThreadStatic]
			internal static glCopyTextureImage2DEXT pglCopyTextureImage2DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
			[ThreadStatic]
			internal static glCopyTextureSubImage1D pglCopyTextureSubImage1D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTextureSubImage1DEXT(UInt32 texture, int target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
			[ThreadStatic]
			internal static glCopyTextureSubImage1DEXT pglCopyTextureSubImage1DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glCopyTextureSubImage2D pglCopyTextureSubImage2D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTextureSubImage2DEXT(UInt32 texture, int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glCopyTextureSubImage2DEXT pglCopyTextureSubImage2DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glCopyTextureSubImage3D pglCopyTextureSubImage3D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyTextureSubImage3DEXT(UInt32 texture, int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glCopyTextureSubImage3DEXT pglCopyTextureSubImage3DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCoverFillPathInstancedNV(Int32 numPaths, int pathNameType, IntPtr paths, UInt32 pathBase, int coverMode, int transformType, float* transformValues);
			[ThreadStatic]
			internal static glCoverFillPathInstancedNV pglCoverFillPathInstancedNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCoverFillPathNV(UInt32 path, int coverMode);
			[ThreadStatic]
			internal static glCoverFillPathNV pglCoverFillPathNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCoverStrokePathInstancedNV(Int32 numPaths, int pathNameType, IntPtr paths, UInt32 pathBase, int coverMode, int transformType, float* transformValues);
			[ThreadStatic]
			internal static glCoverStrokePathInstancedNV pglCoverStrokePathInstancedNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCoverStrokePathNV(UInt32 path, int coverMode);
			[ThreadStatic]
			internal static glCoverStrokePathNV pglCoverStrokePathNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCreateBuffers(Int32 n, UInt32* buffers);
			[ThreadStatic]
			internal static glCreateBuffers pglCreateBuffers;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCreateFramebuffers(Int32 n, UInt32* framebuffers);
			[ThreadStatic]
			internal static glCreateFramebuffers pglCreateFramebuffers;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCreatePerfQueryINTEL(UInt32 queryId, UInt32* queryHandle);
			[ThreadStatic]
			internal static glCreatePerfQueryINTEL pglCreatePerfQueryINTEL;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glCreateProgram();
			[ThreadStatic]
			internal static glCreateProgram pglCreateProgram;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glCreateProgramObjectARB();
			[ThreadStatic]
			internal static glCreateProgramObjectARB pglCreateProgramObjectARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCreateProgramPipelines(Int32 n, UInt32* pipelines);
			[ThreadStatic]
			internal static glCreateProgramPipelines pglCreateProgramPipelines;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCreateQueries(int target, Int32 n, UInt32* ids);
			[ThreadStatic]
			internal static glCreateQueries pglCreateQueries;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCreateRenderbuffers(Int32 n, UInt32* renderbuffers);
			[ThreadStatic]
			internal static glCreateRenderbuffers pglCreateRenderbuffers;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCreateSamplers(Int32 n, UInt32* samplers);
			[ThreadStatic]
			internal static glCreateSamplers pglCreateSamplers;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glCreateShader(int type);
			[ThreadStatic]
			internal static glCreateShader pglCreateShader;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glCreateShaderObjectARB(int shaderType);
			[ThreadStatic]
			internal static glCreateShaderObjectARB pglCreateShaderObjectARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glCreateShaderProgramEXT(int type, String @string);
			[ThreadStatic]
			internal static glCreateShaderProgramEXT pglCreateShaderProgramEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glCreateShaderProgramv(int type, Int32 count, String[] strings);
			[ThreadStatic]
			internal static glCreateShaderProgramv pglCreateShaderProgramv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glCreateSyncFromCLeventARB(IntPtr context, IntPtr @event, uint flags);
			[ThreadStatic]
			internal static glCreateSyncFromCLeventARB pglCreateSyncFromCLeventARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCreateTextures(int target, Int32 n, UInt32* textures);
			[ThreadStatic]
			internal static glCreateTextures pglCreateTextures;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCreateTransformFeedbacks(Int32 n, UInt32* ids);
			[ThreadStatic]
			internal static glCreateTransformFeedbacks pglCreateTransformFeedbacks;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCreateVertexArrays(Int32 n, UInt32* arrays);
			[ThreadStatic]
			internal static glCreateVertexArrays pglCreateVertexArrays;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCullFace(int mode);
			[ThreadStatic]
			internal static glCullFace pglCullFace;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCullParameterdvEXT(int pname, double* @params);
			[ThreadStatic]
			internal static glCullParameterdvEXT pglCullParameterdvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCullParameterfvEXT(int pname, float* @params);
			[ThreadStatic]
			internal static glCullParameterfvEXT pglCullParameterfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCurrentPaletteMatrixARB(Int32 index);
			[ThreadStatic]
			internal static glCurrentPaletteMatrixARB pglCurrentPaletteMatrixARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDebugMessageCallback(IntPtr callback, IntPtr userParam);
			[ThreadStatic]
			internal static glDebugMessageCallback pglDebugMessageCallback;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDebugMessageCallbackAMD(IntPtr callback, IntPtr userParam);
			[ThreadStatic]
			internal static glDebugMessageCallbackAMD pglDebugMessageCallbackAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDebugMessageCallbackARB(IntPtr callback, IntPtr userParam);
			[ThreadStatic]
			internal static glDebugMessageCallbackARB pglDebugMessageCallbackARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDebugMessageControl(int source, int type, int severity, Int32 count, UInt32* ids, bool enabled);
			[ThreadStatic]
			internal static glDebugMessageControl pglDebugMessageControl;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDebugMessageControlARB(int source, int type, int severity, Int32 count, UInt32* ids, bool enabled);
			[ThreadStatic]
			internal static glDebugMessageControlARB pglDebugMessageControlARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDebugMessageEnableAMD(int category, int severity, Int32 count, UInt32* ids, bool enabled);
			[ThreadStatic]
			internal static glDebugMessageEnableAMD pglDebugMessageEnableAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDebugMessageInsert(int source, int type, UInt32 id, int severity, Int32 length, String buf);
			[ThreadStatic]
			internal static glDebugMessageInsert pglDebugMessageInsert;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDebugMessageInsertAMD(int category, int severity, UInt32 id, Int32 length, String buf);
			[ThreadStatic]
			internal static glDebugMessageInsertAMD pglDebugMessageInsertAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDebugMessageInsertARB(int source, int type, UInt32 id, int severity, Int32 length, String buf);
			[ThreadStatic]
			internal static glDebugMessageInsertARB pglDebugMessageInsertARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDeformSGIX(uint mask);
			[ThreadStatic]
			internal static glDeformSGIX pglDeformSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeformationMap3dSGIX(int target, double u1, double u2, Int32 ustride, Int32 uorder, double v1, double v2, Int32 vstride, Int32 vorder, double w1, double w2, Int32 wstride, Int32 worder, double* points);
			[ThreadStatic]
			internal static glDeformationMap3dSGIX pglDeformationMap3dSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeformationMap3fSGIX(int target, float u1, float u2, Int32 ustride, Int32 uorder, float v1, float v2, Int32 vstride, Int32 vorder, float w1, float w2, Int32 wstride, Int32 worder, float* points);
			[ThreadStatic]
			internal static glDeformationMap3fSGIX pglDeformationMap3fSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDeleteAsyncMarkersSGIX(UInt32 marker, Int32 range);
			[ThreadStatic]
			internal static glDeleteAsyncMarkersSGIX pglDeleteAsyncMarkersSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteBuffers(Int32 n, UInt32* buffers);
			[ThreadStatic]
			internal static glDeleteBuffers pglDeleteBuffers;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteBuffersARB(Int32 n, UInt32* buffers);
			[ThreadStatic]
			internal static glDeleteBuffersARB pglDeleteBuffersARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteFencesAPPLE(Int32 n, UInt32* fences);
			[ThreadStatic]
			internal static glDeleteFencesAPPLE pglDeleteFencesAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteFencesNV(Int32 n, UInt32* fences);
			[ThreadStatic]
			internal static glDeleteFencesNV pglDeleteFencesNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDeleteFragmentShaderATI(UInt32 id);
			[ThreadStatic]
			internal static glDeleteFragmentShaderATI pglDeleteFragmentShaderATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteFramebuffers(Int32 n, UInt32* framebuffers);
			[ThreadStatic]
			internal static glDeleteFramebuffers pglDeleteFramebuffers;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteFramebuffersEXT(Int32 n, UInt32* framebuffers);
			[ThreadStatic]
			internal static glDeleteFramebuffersEXT pglDeleteFramebuffersEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDeleteLists(UInt32 list, Int32 range);
			[ThreadStatic]
			internal static glDeleteLists pglDeleteLists;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDeleteNamedStringARB(Int32 namelen, String name);
			[ThreadStatic]
			internal static glDeleteNamedStringARB pglDeleteNamedStringARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteNamesAMD(int identifier, UInt32 num, UInt32* names);
			[ThreadStatic]
			internal static glDeleteNamesAMD pglDeleteNamesAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDeleteObjectARB(UInt32 obj);
			[ThreadStatic]
			internal static glDeleteObjectARB pglDeleteObjectARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteOcclusionQueriesNV(Int32 n, UInt32* ids);
			[ThreadStatic]
			internal static glDeleteOcclusionQueriesNV pglDeleteOcclusionQueriesNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDeletePathsNV(UInt32 path, Int32 range);
			[ThreadStatic]
			internal static glDeletePathsNV pglDeletePathsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeletePerfMonitorsAMD(Int32 n, UInt32* monitors);
			[ThreadStatic]
			internal static glDeletePerfMonitorsAMD pglDeletePerfMonitorsAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDeletePerfQueryINTEL(UInt32 queryHandle);
			[ThreadStatic]
			internal static glDeletePerfQueryINTEL pglDeletePerfQueryINTEL;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDeleteProgram(UInt32 program);
			[ThreadStatic]
			internal static glDeleteProgram pglDeleteProgram;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteProgramPipelines(Int32 n, UInt32* pipelines);
			[ThreadStatic]
			internal static glDeleteProgramPipelines pglDeleteProgramPipelines;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteProgramsARB(Int32 n, UInt32* programs);
			[ThreadStatic]
			internal static glDeleteProgramsARB pglDeleteProgramsARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteProgramsNV(Int32 n, UInt32* programs);
			[ThreadStatic]
			internal static glDeleteProgramsNV pglDeleteProgramsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteQueries(Int32 n, UInt32* ids);
			[ThreadStatic]
			internal static glDeleteQueries pglDeleteQueries;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteQueriesARB(Int32 n, UInt32* ids);
			[ThreadStatic]
			internal static glDeleteQueriesARB pglDeleteQueriesARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteRenderbuffers(Int32 n, UInt32* renderbuffers);
			[ThreadStatic]
			internal static glDeleteRenderbuffers pglDeleteRenderbuffers;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteRenderbuffersEXT(Int32 n, UInt32* renderbuffers);
			[ThreadStatic]
			internal static glDeleteRenderbuffersEXT pglDeleteRenderbuffersEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteSamplers(Int32 count, UInt32* samplers);
			[ThreadStatic]
			internal static glDeleteSamplers pglDeleteSamplers;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDeleteShader(UInt32 shader);
			[ThreadStatic]
			internal static glDeleteShader pglDeleteShader;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDeleteSync(int sync);
			[ThreadStatic]
			internal static glDeleteSync pglDeleteSync;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteTextures(Int32 n, UInt32* textures);
			[ThreadStatic]
			internal static glDeleteTextures pglDeleteTextures;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteTexturesEXT(Int32 n, UInt32* textures);
			[ThreadStatic]
			internal static glDeleteTexturesEXT pglDeleteTexturesEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteTransformFeedbacks(Int32 n, UInt32* ids);
			[ThreadStatic]
			internal static glDeleteTransformFeedbacks pglDeleteTransformFeedbacks;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteTransformFeedbacksNV(Int32 n, UInt32* ids);
			[ThreadStatic]
			internal static glDeleteTransformFeedbacksNV pglDeleteTransformFeedbacksNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteVertexArrays(Int32 n, UInt32* arrays);
			[ThreadStatic]
			internal static glDeleteVertexArrays pglDeleteVertexArrays;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteVertexArraysAPPLE(Int32 n, UInt32* arrays);
			[ThreadStatic]
			internal static glDeleteVertexArraysAPPLE pglDeleteVertexArraysAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDeleteVertexShaderEXT(UInt32 id);
			[ThreadStatic]
			internal static glDeleteVertexShaderEXT pglDeleteVertexShaderEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDepthBoundsEXT(double zmin, double zmax);
			[ThreadStatic]
			internal static glDepthBoundsEXT pglDepthBoundsEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDepthBoundsdNV(double zmin, double zmax);
			[ThreadStatic]
			internal static glDepthBoundsdNV pglDepthBoundsdNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDepthFunc(int func);
			[ThreadStatic]
			internal static glDepthFunc pglDepthFunc;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDepthMask(bool flag);
			[ThreadStatic]
			internal static glDepthMask pglDepthMask;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDepthRange(double near, double far);
			[ThreadStatic]
			internal static glDepthRange pglDepthRange;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDepthRangeArrayv(UInt32 first, Int32 count, double* v);
			[ThreadStatic]
			internal static glDepthRangeArrayv pglDepthRangeArrayv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDepthRangeIndexed(UInt32 index, double n, double f);
			[ThreadStatic]
			internal static glDepthRangeIndexed pglDepthRangeIndexed;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDepthRangedNV(double zNear, double zFar);
			[ThreadStatic]
			internal static glDepthRangedNV pglDepthRangedNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDepthRangef(float n, float f);
			[ThreadStatic]
			internal static glDepthRangef pglDepthRangef;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDepthRangefOES(float n, float f);
			[ThreadStatic]
			internal static glDepthRangefOES pglDepthRangefOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDepthRangexOES(IntPtr n, IntPtr f);
			[ThreadStatic]
			internal static glDepthRangexOES pglDepthRangexOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDetachObjectARB(UInt32 containerObj, UInt32 attachedObj);
			[ThreadStatic]
			internal static glDetachObjectARB pglDetachObjectARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDetachShader(UInt32 program, UInt32 shader);
			[ThreadStatic]
			internal static glDetachShader pglDetachShader;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDetailTexFuncSGIS(int target, Int32 n, float* points);
			[ThreadStatic]
			internal static glDetailTexFuncSGIS pglDetailTexFuncSGIS;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDisable(int cap);
			[ThreadStatic]
			internal static glDisable pglDisable;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDisableClientState(int array);
			[ThreadStatic]
			internal static glDisableClientState pglDisableClientState;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDisableClientStateIndexedEXT(int array, UInt32 index);
			[ThreadStatic]
			internal static glDisableClientStateIndexedEXT pglDisableClientStateIndexedEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDisableClientStateiEXT(int array, UInt32 index);
			[ThreadStatic]
			internal static glDisableClientStateiEXT pglDisableClientStateiEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDisableIndexedEXT(int target, UInt32 index);
			[ThreadStatic]
			internal static glDisableIndexedEXT pglDisableIndexedEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDisableVariantClientStateEXT(UInt32 id);
			[ThreadStatic]
			internal static glDisableVariantClientStateEXT pglDisableVariantClientStateEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDisableVertexArrayAttrib(UInt32 vaobj, UInt32 index);
			[ThreadStatic]
			internal static glDisableVertexArrayAttrib pglDisableVertexArrayAttrib;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDisableVertexArrayAttribEXT(UInt32 vaobj, UInt32 index);
			[ThreadStatic]
			internal static glDisableVertexArrayAttribEXT pglDisableVertexArrayAttribEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDisableVertexArrayEXT(UInt32 vaobj, int array);
			[ThreadStatic]
			internal static glDisableVertexArrayEXT pglDisableVertexArrayEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDisableVertexAttribAPPLE(UInt32 index, int pname);
			[ThreadStatic]
			internal static glDisableVertexAttribAPPLE pglDisableVertexAttribAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDisableVertexAttribArray(UInt32 index);
			[ThreadStatic]
			internal static glDisableVertexAttribArray pglDisableVertexAttribArray;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDisableVertexAttribArrayARB(UInt32 index);
			[ThreadStatic]
			internal static glDisableVertexAttribArrayARB pglDisableVertexAttribArrayARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDisablei(int target, UInt32 index);
			[ThreadStatic]
			internal static glDisablei pglDisablei;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDispatchCompute(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z);
			[ThreadStatic]
			internal static glDispatchCompute pglDispatchCompute;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDispatchComputeGroupSizeARB(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z, UInt32 group_size_x, UInt32 group_size_y, UInt32 group_size_z);
			[ThreadStatic]
			internal static glDispatchComputeGroupSizeARB pglDispatchComputeGroupSizeARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDispatchComputeIndirect(IntPtr indirect);
			[ThreadStatic]
			internal static glDispatchComputeIndirect pglDispatchComputeIndirect;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawArrays(int mode, Int32 first, Int32 count);
			[ThreadStatic]
			internal static glDrawArrays pglDrawArrays;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawArraysEXT(int mode, Int32 first, Int32 count);
			[ThreadStatic]
			internal static glDrawArraysEXT pglDrawArraysEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawArraysIndirect(int mode, IntPtr indirect);
			[ThreadStatic]
			internal static glDrawArraysIndirect pglDrawArraysIndirect;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawArraysInstanced(int mode, Int32 first, Int32 count, Int32 instancecount);
			[ThreadStatic]
			internal static glDrawArraysInstanced pglDrawArraysInstanced;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawArraysInstancedARB(int mode, Int32 first, Int32 count, Int32 primcount);
			[ThreadStatic]
			internal static glDrawArraysInstancedARB pglDrawArraysInstancedARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawArraysInstancedBaseInstance(int mode, Int32 first, Int32 count, Int32 instancecount, UInt32 baseinstance);
			[ThreadStatic]
			internal static glDrawArraysInstancedBaseInstance pglDrawArraysInstancedBaseInstance;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawArraysInstancedEXT(int mode, Int32 start, Int32 count, Int32 primcount);
			[ThreadStatic]
			internal static glDrawArraysInstancedEXT pglDrawArraysInstancedEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawBuffer(int buf);
			[ThreadStatic]
			internal static glDrawBuffer pglDrawBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawBuffers(Int32 n, int* bufs);
			[ThreadStatic]
			internal static glDrawBuffers pglDrawBuffers;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawBuffersARB(Int32 n, int* bufs);
			[ThreadStatic]
			internal static glDrawBuffersARB pglDrawBuffersARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawBuffersATI(Int32 n, int* bufs);
			[ThreadStatic]
			internal static glDrawBuffersATI pglDrawBuffersATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawElementArrayAPPLE(int mode, Int32 first, Int32 count);
			[ThreadStatic]
			internal static glDrawElementArrayAPPLE pglDrawElementArrayAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawElementArrayATI(int mode, Int32 count);
			[ThreadStatic]
			internal static glDrawElementArrayATI pglDrawElementArrayATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawElements(int mode, Int32 count, int type, IntPtr indices);
			[ThreadStatic]
			internal static glDrawElements pglDrawElements;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawElementsBaseVertex(int mode, Int32 count, int type, IntPtr indices, Int32 basevertex);
			[ThreadStatic]
			internal static glDrawElementsBaseVertex pglDrawElementsBaseVertex;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawElementsIndirect(int mode, int type, IntPtr indirect);
			[ThreadStatic]
			internal static glDrawElementsIndirect pglDrawElementsIndirect;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawElementsInstanced(int mode, Int32 count, int type, IntPtr indices, Int32 instancecount);
			[ThreadStatic]
			internal static glDrawElementsInstanced pglDrawElementsInstanced;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawElementsInstancedARB(int mode, Int32 count, int type, IntPtr indices, Int32 primcount);
			[ThreadStatic]
			internal static glDrawElementsInstancedARB pglDrawElementsInstancedARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawElementsInstancedBaseInstance(int mode, Int32 count, int type, IntPtr indices, Int32 instancecount, UInt32 baseinstance);
			[ThreadStatic]
			internal static glDrawElementsInstancedBaseInstance pglDrawElementsInstancedBaseInstance;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawElementsInstancedBaseVertex(int mode, Int32 count, int type, IntPtr indices, Int32 instancecount, Int32 basevertex);
			[ThreadStatic]
			internal static glDrawElementsInstancedBaseVertex pglDrawElementsInstancedBaseVertex;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawElementsInstancedBaseVertexBaseInstance(int mode, Int32 count, int type, IntPtr indices, Int32 instancecount, Int32 basevertex, UInt32 baseinstance);
			[ThreadStatic]
			internal static glDrawElementsInstancedBaseVertexBaseInstance pglDrawElementsInstancedBaseVertexBaseInstance;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawElementsInstancedEXT(int mode, Int32 count, int type, IntPtr indices, Int32 primcount);
			[ThreadStatic]
			internal static glDrawElementsInstancedEXT pglDrawElementsInstancedEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawMeshArraysSUN(int mode, Int32 first, Int32 count, Int32 width);
			[ThreadStatic]
			internal static glDrawMeshArraysSUN pglDrawMeshArraysSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawPixels(Int32 width, Int32 height, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glDrawPixels pglDrawPixels;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawRangeElementArrayAPPLE(int mode, UInt32 start, UInt32 end, Int32 first, Int32 count);
			[ThreadStatic]
			internal static glDrawRangeElementArrayAPPLE pglDrawRangeElementArrayAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawRangeElementArrayATI(int mode, UInt32 start, UInt32 end, Int32 count);
			[ThreadStatic]
			internal static glDrawRangeElementArrayATI pglDrawRangeElementArrayATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawRangeElements(int mode, UInt32 start, UInt32 end, Int32 count, int type, IntPtr indices);
			[ThreadStatic]
			internal static glDrawRangeElements pglDrawRangeElements;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawRangeElementsBaseVertex(int mode, UInt32 start, UInt32 end, Int32 count, int type, IntPtr indices, Int32 basevertex);
			[ThreadStatic]
			internal static glDrawRangeElementsBaseVertex pglDrawRangeElementsBaseVertex;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawRangeElementsEXT(int mode, UInt32 start, UInt32 end, Int32 count, int type, IntPtr indices);
			[ThreadStatic]
			internal static glDrawRangeElementsEXT pglDrawRangeElementsEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawTextureNV(UInt32 texture, UInt32 sampler, float x0, float y0, float x1, float y1, float z, float s0, float t0, float s1, float t1);
			[ThreadStatic]
			internal static glDrawTextureNV pglDrawTextureNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawTransformFeedback(int mode, UInt32 id);
			[ThreadStatic]
			internal static glDrawTransformFeedback pglDrawTransformFeedback;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawTransformFeedbackInstanced(int mode, UInt32 id, Int32 instancecount);
			[ThreadStatic]
			internal static glDrawTransformFeedbackInstanced pglDrawTransformFeedbackInstanced;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawTransformFeedbackNV(int mode, UInt32 id);
			[ThreadStatic]
			internal static glDrawTransformFeedbackNV pglDrawTransformFeedbackNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawTransformFeedbackStream(int mode, UInt32 id, UInt32 stream);
			[ThreadStatic]
			internal static glDrawTransformFeedbackStream pglDrawTransformFeedbackStream;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawTransformFeedbackStreamInstanced(int mode, UInt32 id, UInt32 stream, Int32 instancecount);
			[ThreadStatic]
			internal static glDrawTransformFeedbackStreamInstanced pglDrawTransformFeedbackStreamInstanced;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEdgeFlag(bool flag);
			[ThreadStatic]
			internal static glEdgeFlag pglEdgeFlag;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEdgeFlagFormatNV(Int32 stride);
			[ThreadStatic]
			internal static glEdgeFlagFormatNV pglEdgeFlagFormatNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEdgeFlagPointer(Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glEdgeFlagPointer pglEdgeFlagPointer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEdgeFlagPointerEXT(Int32 stride, Int32 count, bool* pointer);
			[ThreadStatic]
			internal static glEdgeFlagPointerEXT pglEdgeFlagPointerEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEdgeFlagPointerListIBM(Int32 stride, bool[] pointer, Int32 ptrstride);
			[ThreadStatic]
			internal static glEdgeFlagPointerListIBM pglEdgeFlagPointerListIBM;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEdgeFlagv(bool* flag);
			[ThreadStatic]
			internal static glEdgeFlagv pglEdgeFlagv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glElementPointerAPPLE(int type, IntPtr pointer);
			[ThreadStatic]
			internal static glElementPointerAPPLE pglElementPointerAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glElementPointerATI(int type, IntPtr pointer);
			[ThreadStatic]
			internal static glElementPointerATI pglElementPointerATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnable(int cap);
			[ThreadStatic]
			internal static glEnable pglEnable;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnableClientState(int array);
			[ThreadStatic]
			internal static glEnableClientState pglEnableClientState;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnableClientStateIndexedEXT(int array, UInt32 index);
			[ThreadStatic]
			internal static glEnableClientStateIndexedEXT pglEnableClientStateIndexedEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnableClientStateiEXT(int array, UInt32 index);
			[ThreadStatic]
			internal static glEnableClientStateiEXT pglEnableClientStateiEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnableIndexedEXT(int target, UInt32 index);
			[ThreadStatic]
			internal static glEnableIndexedEXT pglEnableIndexedEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnableVariantClientStateEXT(UInt32 id);
			[ThreadStatic]
			internal static glEnableVariantClientStateEXT pglEnableVariantClientStateEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnableVertexArrayAttrib(UInt32 vaobj, UInt32 index);
			[ThreadStatic]
			internal static glEnableVertexArrayAttrib pglEnableVertexArrayAttrib;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnableVertexArrayAttribEXT(UInt32 vaobj, UInt32 index);
			[ThreadStatic]
			internal static glEnableVertexArrayAttribEXT pglEnableVertexArrayAttribEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnableVertexArrayEXT(UInt32 vaobj, int array);
			[ThreadStatic]
			internal static glEnableVertexArrayEXT pglEnableVertexArrayEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnableVertexAttribAPPLE(UInt32 index, int pname);
			[ThreadStatic]
			internal static glEnableVertexAttribAPPLE pglEnableVertexAttribAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnableVertexAttribArray(UInt32 index);
			[ThreadStatic]
			internal static glEnableVertexAttribArray pglEnableVertexAttribArray;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnableVertexAttribArrayARB(UInt32 index);
			[ThreadStatic]
			internal static glEnableVertexAttribArrayARB pglEnableVertexAttribArrayARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnablei(int target, UInt32 index);
			[ThreadStatic]
			internal static glEnablei pglEnablei;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnd();
			[ThreadStatic]
			internal static glEnd pglEnd;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEndConditionalRender();
			[ThreadStatic]
			internal static glEndConditionalRender pglEndConditionalRender;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEndConditionalRenderNV();
			[ThreadStatic]
			internal static glEndConditionalRenderNV pglEndConditionalRenderNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEndConditionalRenderNVX();
			[ThreadStatic]
			internal static glEndConditionalRenderNVX pglEndConditionalRenderNVX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEndFragmentShaderATI();
			[ThreadStatic]
			internal static glEndFragmentShaderATI pglEndFragmentShaderATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEndList();
			[ThreadStatic]
			internal static glEndList pglEndList;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEndOcclusionQueryNV();
			[ThreadStatic]
			internal static glEndOcclusionQueryNV pglEndOcclusionQueryNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEndPerfMonitorAMD(UInt32 monitor);
			[ThreadStatic]
			internal static glEndPerfMonitorAMD pglEndPerfMonitorAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEndPerfQueryINTEL(UInt32 queryHandle);
			[ThreadStatic]
			internal static glEndPerfQueryINTEL pglEndPerfQueryINTEL;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEndQuery(int target);
			[ThreadStatic]
			internal static glEndQuery pglEndQuery;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEndQueryARB(int target);
			[ThreadStatic]
			internal static glEndQueryARB pglEndQueryARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEndQueryIndexed(int target, UInt32 index);
			[ThreadStatic]
			internal static glEndQueryIndexed pglEndQueryIndexed;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEndTransformFeedback();
			[ThreadStatic]
			internal static glEndTransformFeedback pglEndTransformFeedback;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEndTransformFeedbackEXT();
			[ThreadStatic]
			internal static glEndTransformFeedbackEXT pglEndTransformFeedbackEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEndTransformFeedbackNV();
			[ThreadStatic]
			internal static glEndTransformFeedbackNV pglEndTransformFeedbackNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEndVertexShaderEXT();
			[ThreadStatic]
			internal static glEndVertexShaderEXT pglEndVertexShaderEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEndVideoCaptureNV(UInt32 video_capture_slot);
			[ThreadStatic]
			internal static glEndVideoCaptureNV pglEndVideoCaptureNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalCoord1d(double u);
			[ThreadStatic]
			internal static glEvalCoord1d pglEvalCoord1d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEvalCoord1dv(double* u);
			[ThreadStatic]
			internal static glEvalCoord1dv pglEvalCoord1dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalCoord1f(float u);
			[ThreadStatic]
			internal static glEvalCoord1f pglEvalCoord1f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEvalCoord1fv(float* u);
			[ThreadStatic]
			internal static glEvalCoord1fv pglEvalCoord1fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEvalCoord1xOES(IntPtr u);
			[ThreadStatic]
			internal static glEvalCoord1xOES pglEvalCoord1xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEvalCoord1xvOES(IntPtr* coords);
			[ThreadStatic]
			internal static glEvalCoord1xvOES pglEvalCoord1xvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalCoord2d(double u, double v);
			[ThreadStatic]
			internal static glEvalCoord2d pglEvalCoord2d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEvalCoord2dv(double* u);
			[ThreadStatic]
			internal static glEvalCoord2dv pglEvalCoord2dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalCoord2f(float u, float v);
			[ThreadStatic]
			internal static glEvalCoord2f pglEvalCoord2f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEvalCoord2fv(float* u);
			[ThreadStatic]
			internal static glEvalCoord2fv pglEvalCoord2fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEvalCoord2xOES(IntPtr u, IntPtr v);
			[ThreadStatic]
			internal static glEvalCoord2xOES pglEvalCoord2xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEvalCoord2xvOES(IntPtr* coords);
			[ThreadStatic]
			internal static glEvalCoord2xvOES pglEvalCoord2xvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalMapsNV(int target, int mode);
			[ThreadStatic]
			internal static glEvalMapsNV pglEvalMapsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalMesh1(int mode, Int32 i1, Int32 i2);
			[ThreadStatic]
			internal static glEvalMesh1 pglEvalMesh1;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalMesh2(int mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2);
			[ThreadStatic]
			internal static glEvalMesh2 pglEvalMesh2;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalPoint1(Int32 i);
			[ThreadStatic]
			internal static glEvalPoint1 pglEvalPoint1;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalPoint2(Int32 i, Int32 j);
			[ThreadStatic]
			internal static glEvalPoint2 pglEvalPoint2;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glExecuteProgramNV(int target, UInt32 id, float* @params);
			[ThreadStatic]
			internal static glExecuteProgramNV pglExecuteProgramNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glExtractComponentEXT(UInt32 res, UInt32 src, UInt32 num);
			[ThreadStatic]
			internal static glExtractComponentEXT pglExtractComponentEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFeedbackBuffer(Int32 size, int type, float* buffer);
			[ThreadStatic]
			internal static glFeedbackBuffer pglFeedbackBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFeedbackBufferxOES(Int32 n, int type, IntPtr* buffer);
			[ThreadStatic]
			internal static glFeedbackBufferxOES pglFeedbackBufferxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int glFenceSync(int condition, uint flags);
			[ThreadStatic]
			internal static glFenceSync pglFenceSync;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFinalCombinerInputNV(int variable, int input, int mapping, int componentUsage);
			[ThreadStatic]
			internal static glFinalCombinerInputNV pglFinalCombinerInputNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFinish();
			[ThreadStatic]
			internal static glFinish pglFinish;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate Int32 glFinishAsyncSGIX(UInt32* markerp);
			[ThreadStatic]
			internal static glFinishAsyncSGIX pglFinishAsyncSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFinishFenceAPPLE(UInt32 fence);
			[ThreadStatic]
			internal static glFinishFenceAPPLE pglFinishFenceAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFinishFenceNV(UInt32 fence);
			[ThreadStatic]
			internal static glFinishFenceNV pglFinishFenceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFinishObjectAPPLE(int @object, Int32 name);
			[ThreadStatic]
			internal static glFinishObjectAPPLE pglFinishObjectAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFinishTextureSUNX();
			[ThreadStatic]
			internal static glFinishTextureSUNX pglFinishTextureSUNX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFlush();
			[ThreadStatic]
			internal static glFlush pglFlush;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFlushMappedBufferRange(int target, IntPtr offset, UInt32 length);
			[ThreadStatic]
			internal static glFlushMappedBufferRange pglFlushMappedBufferRange;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFlushMappedBufferRangeAPPLE(int target, IntPtr offset, UInt32 size);
			[ThreadStatic]
			internal static glFlushMappedBufferRangeAPPLE pglFlushMappedBufferRangeAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFlushMappedNamedBufferRange(UInt32 buffer, IntPtr offset, UInt32 length);
			[ThreadStatic]
			internal static glFlushMappedNamedBufferRange pglFlushMappedNamedBufferRange;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFlushMappedNamedBufferRangeEXT(UInt32 buffer, IntPtr offset, UInt32 length);
			[ThreadStatic]
			internal static glFlushMappedNamedBufferRangeEXT pglFlushMappedNamedBufferRangeEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFlushPixelDataRangeNV(int target);
			[ThreadStatic]
			internal static glFlushPixelDataRangeNV pglFlushPixelDataRangeNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFlushRasterSGIX();
			[ThreadStatic]
			internal static glFlushRasterSGIX pglFlushRasterSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFlushStaticDataIBM(int target);
			[ThreadStatic]
			internal static glFlushStaticDataIBM pglFlushStaticDataIBM;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFlushVertexArrayRangeAPPLE(Int32 length, IntPtr pointer);
			[ThreadStatic]
			internal static glFlushVertexArrayRangeAPPLE pglFlushVertexArrayRangeAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFlushVertexArrayRangeNV();
			[ThreadStatic]
			internal static glFlushVertexArrayRangeNV pglFlushVertexArrayRangeNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFogCoordFormatNV(int type, Int32 stride);
			[ThreadStatic]
			internal static glFogCoordFormatNV pglFogCoordFormatNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogCoordPointer(int type, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glFogCoordPointer pglFogCoordPointer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogCoordPointerEXT(int type, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glFogCoordPointerEXT pglFogCoordPointerEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogCoordPointerListIBM(int type, Int32 stride, IntPtr* pointer, Int32 ptrstride);
			[ThreadStatic]
			internal static glFogCoordPointerListIBM pglFogCoordPointerListIBM;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFogCoordd(double coord);
			[ThreadStatic]
			internal static glFogCoordd pglFogCoordd;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFogCoorddEXT(double coord);
			[ThreadStatic]
			internal static glFogCoorddEXT pglFogCoorddEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogCoorddv(double* coord);
			[ThreadStatic]
			internal static glFogCoorddv pglFogCoorddv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogCoorddvEXT(double* coord);
			[ThreadStatic]
			internal static glFogCoorddvEXT pglFogCoorddvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFogCoordf(float coord);
			[ThreadStatic]
			internal static glFogCoordf pglFogCoordf;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFogCoordfEXT(float coord);
			[ThreadStatic]
			internal static glFogCoordfEXT pglFogCoordfEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogCoordfv(float* coord);
			[ThreadStatic]
			internal static glFogCoordfv pglFogCoordfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogCoordfvEXT(float* coord);
			[ThreadStatic]
			internal static glFogCoordfvEXT pglFogCoordfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFogCoordhNV(UInt16 fog);
			[ThreadStatic]
			internal static glFogCoordhNV pglFogCoordhNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogCoordhvNV(UInt16* fog);
			[ThreadStatic]
			internal static glFogCoordhvNV pglFogCoordhvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogFuncSGIS(Int32 n, float* points);
			[ThreadStatic]
			internal static glFogFuncSGIS pglFogFuncSGIS;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFogf(int pname, float param);
			[ThreadStatic]
			internal static glFogf pglFogf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogfv(int pname, float* @params);
			[ThreadStatic]
			internal static glFogfv pglFogfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFogi(int pname, Int32 param);
			[ThreadStatic]
			internal static glFogi pglFogi;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogiv(int pname, Int32* @params);
			[ThreadStatic]
			internal static glFogiv pglFogiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogxOES(int pname, IntPtr param);
			[ThreadStatic]
			internal static glFogxOES pglFogxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogxvOES(int pname, IntPtr* param);
			[ThreadStatic]
			internal static glFogxvOES pglFogxvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFragmentColorMaterialSGIX(int face, int mode);
			[ThreadStatic]
			internal static glFragmentColorMaterialSGIX pglFragmentColorMaterialSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFragmentLightModelfSGIX(int pname, float param);
			[ThreadStatic]
			internal static glFragmentLightModelfSGIX pglFragmentLightModelfSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFragmentLightModelfvSGIX(int pname, float* @params);
			[ThreadStatic]
			internal static glFragmentLightModelfvSGIX pglFragmentLightModelfvSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFragmentLightModeliSGIX(int pname, Int32 param);
			[ThreadStatic]
			internal static glFragmentLightModeliSGIX pglFragmentLightModeliSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFragmentLightModelivSGIX(int pname, Int32* @params);
			[ThreadStatic]
			internal static glFragmentLightModelivSGIX pglFragmentLightModelivSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFragmentLightfSGIX(int light, int pname, float param);
			[ThreadStatic]
			internal static glFragmentLightfSGIX pglFragmentLightfSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFragmentLightfvSGIX(int light, int pname, float* @params);
			[ThreadStatic]
			internal static glFragmentLightfvSGIX pglFragmentLightfvSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFragmentLightiSGIX(int light, int pname, Int32 param);
			[ThreadStatic]
			internal static glFragmentLightiSGIX pglFragmentLightiSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFragmentLightivSGIX(int light, int pname, Int32* @params);
			[ThreadStatic]
			internal static glFragmentLightivSGIX pglFragmentLightivSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFragmentMaterialfSGIX(int face, int pname, float param);
			[ThreadStatic]
			internal static glFragmentMaterialfSGIX pglFragmentMaterialfSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFragmentMaterialfvSGIX(int face, int pname, float* @params);
			[ThreadStatic]
			internal static glFragmentMaterialfvSGIX pglFragmentMaterialfvSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFragmentMaterialiSGIX(int face, int pname, Int32 param);
			[ThreadStatic]
			internal static glFragmentMaterialiSGIX pglFragmentMaterialiSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFragmentMaterialivSGIX(int face, int pname, Int32* @params);
			[ThreadStatic]
			internal static glFragmentMaterialivSGIX pglFragmentMaterialivSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFrameTerminatorGREMEDY();
			[ThreadStatic]
			internal static glFrameTerminatorGREMEDY pglFrameTerminatorGREMEDY;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFrameZoomSGIX(Int32 factor);
			[ThreadStatic]
			internal static glFrameZoomSGIX pglFrameZoomSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferDrawBufferEXT(UInt32 framebuffer, int mode);
			[ThreadStatic]
			internal static glFramebufferDrawBufferEXT pglFramebufferDrawBufferEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFramebufferDrawBuffersEXT(UInt32 framebuffer, Int32 n, int* bufs);
			[ThreadStatic]
			internal static glFramebufferDrawBuffersEXT pglFramebufferDrawBuffersEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferParameteri(int target, int pname, Int32 param);
			[ThreadStatic]
			internal static glFramebufferParameteri pglFramebufferParameteri;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferReadBufferEXT(UInt32 framebuffer, int mode);
			[ThreadStatic]
			internal static glFramebufferReadBufferEXT pglFramebufferReadBufferEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferRenderbuffer(int target, int attachment, int renderbuffertarget, UInt32 renderbuffer);
			[ThreadStatic]
			internal static glFramebufferRenderbuffer pglFramebufferRenderbuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferRenderbufferEXT(int target, int attachment, int renderbuffertarget, UInt32 renderbuffer);
			[ThreadStatic]
			internal static glFramebufferRenderbufferEXT pglFramebufferRenderbufferEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferTexture(int target, int attachment, UInt32 texture, Int32 level);
			[ThreadStatic]
			internal static glFramebufferTexture pglFramebufferTexture;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferTexture1D(int target, int attachment, int textarget, UInt32 texture, Int32 level);
			[ThreadStatic]
			internal static glFramebufferTexture1D pglFramebufferTexture1D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferTexture1DEXT(int target, int attachment, int textarget, UInt32 texture, Int32 level);
			[ThreadStatic]
			internal static glFramebufferTexture1DEXT pglFramebufferTexture1DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferTexture2D(int target, int attachment, int textarget, UInt32 texture, Int32 level);
			[ThreadStatic]
			internal static glFramebufferTexture2D pglFramebufferTexture2D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferTexture2DEXT(int target, int attachment, int textarget, UInt32 texture, Int32 level);
			[ThreadStatic]
			internal static glFramebufferTexture2DEXT pglFramebufferTexture2DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferTexture3D(int target, int attachment, int textarget, UInt32 texture, Int32 level, Int32 zoffset);
			[ThreadStatic]
			internal static glFramebufferTexture3D pglFramebufferTexture3D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferTexture3DEXT(int target, int attachment, int textarget, UInt32 texture, Int32 level, Int32 zoffset);
			[ThreadStatic]
			internal static glFramebufferTexture3DEXT pglFramebufferTexture3DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferTextureARB(int target, int attachment, UInt32 texture, Int32 level);
			[ThreadStatic]
			internal static glFramebufferTextureARB pglFramebufferTextureARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferTextureEXT(int target, int attachment, UInt32 texture, Int32 level);
			[ThreadStatic]
			internal static glFramebufferTextureEXT pglFramebufferTextureEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferTextureFaceARB(int target, int attachment, UInt32 texture, Int32 level, int face);
			[ThreadStatic]
			internal static glFramebufferTextureFaceARB pglFramebufferTextureFaceARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferTextureFaceEXT(int target, int attachment, UInt32 texture, Int32 level, int face);
			[ThreadStatic]
			internal static glFramebufferTextureFaceEXT pglFramebufferTextureFaceEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferTextureLayer(int target, int attachment, UInt32 texture, Int32 level, Int32 layer);
			[ThreadStatic]
			internal static glFramebufferTextureLayer pglFramebufferTextureLayer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferTextureLayerARB(int target, int attachment, UInt32 texture, Int32 level, Int32 layer);
			[ThreadStatic]
			internal static glFramebufferTextureLayerARB pglFramebufferTextureLayerARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferTextureLayerEXT(int target, int attachment, UInt32 texture, Int32 level, Int32 layer);
			[ThreadStatic]
			internal static glFramebufferTextureLayerEXT pglFramebufferTextureLayerEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFreeObjectBufferATI(UInt32 buffer);
			[ThreadStatic]
			internal static glFreeObjectBufferATI pglFreeObjectBufferATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFrontFace(int mode);
			[ThreadStatic]
			internal static glFrontFace pglFrontFace;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar);
			[ThreadStatic]
			internal static glFrustum pglFrustum;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFrustumfOES(float l, float r, float b, float t, float n, float f);
			[ThreadStatic]
			internal static glFrustumfOES pglFrustumfOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFrustumxOES(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f);
			[ThreadStatic]
			internal static glFrustumxOES pglFrustumxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glGenAsyncMarkersSGIX(Int32 range);
			[ThreadStatic]
			internal static glGenAsyncMarkersSGIX pglGenAsyncMarkersSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenBuffers(Int32 n, UInt32* buffers);
			[ThreadStatic]
			internal static glGenBuffers pglGenBuffers;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenBuffersARB(Int32 n, UInt32* buffers);
			[ThreadStatic]
			internal static glGenBuffersARB pglGenBuffersARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenFencesAPPLE(Int32 n, UInt32* fences);
			[ThreadStatic]
			internal static glGenFencesAPPLE pglGenFencesAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenFencesNV(Int32 n, UInt32* fences);
			[ThreadStatic]
			internal static glGenFencesNV pglGenFencesNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glGenFragmentShadersATI(UInt32 range);
			[ThreadStatic]
			internal static glGenFragmentShadersATI pglGenFragmentShadersATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenFramebuffers(Int32 n, UInt32* framebuffers);
			[ThreadStatic]
			internal static glGenFramebuffers pglGenFramebuffers;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenFramebuffersEXT(Int32 n, UInt32* framebuffers);
			[ThreadStatic]
			internal static glGenFramebuffersEXT pglGenFramebuffersEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glGenLists(Int32 range);
			[ThreadStatic]
			internal static glGenLists pglGenLists;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenNamesAMD(int identifier, UInt32 num, UInt32* names);
			[ThreadStatic]
			internal static glGenNamesAMD pglGenNamesAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenOcclusionQueriesNV(Int32 n, UInt32* ids);
			[ThreadStatic]
			internal static glGenOcclusionQueriesNV pglGenOcclusionQueriesNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glGenPathsNV(Int32 range);
			[ThreadStatic]
			internal static glGenPathsNV pglGenPathsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenPerfMonitorsAMD(Int32 n, UInt32* monitors);
			[ThreadStatic]
			internal static glGenPerfMonitorsAMD pglGenPerfMonitorsAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenProgramPipelines(Int32 n, UInt32* pipelines);
			[ThreadStatic]
			internal static glGenProgramPipelines pglGenProgramPipelines;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenProgramsARB(Int32 n, UInt32* programs);
			[ThreadStatic]
			internal static glGenProgramsARB pglGenProgramsARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenProgramsNV(Int32 n, UInt32* programs);
			[ThreadStatic]
			internal static glGenProgramsNV pglGenProgramsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenQueries(Int32 n, UInt32* ids);
			[ThreadStatic]
			internal static glGenQueries pglGenQueries;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenQueriesARB(Int32 n, UInt32* ids);
			[ThreadStatic]
			internal static glGenQueriesARB pglGenQueriesARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenRenderbuffers(Int32 n, UInt32* renderbuffers);
			[ThreadStatic]
			internal static glGenRenderbuffers pglGenRenderbuffers;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenRenderbuffersEXT(Int32 n, UInt32* renderbuffers);
			[ThreadStatic]
			internal static glGenRenderbuffersEXT pglGenRenderbuffersEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenSamplers(Int32 count, UInt32* samplers);
			[ThreadStatic]
			internal static glGenSamplers pglGenSamplers;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glGenSymbolsEXT(int datatype, int storagetype, int range, UInt32 components);
			[ThreadStatic]
			internal static glGenSymbolsEXT pglGenSymbolsEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenTextures(Int32 n, UInt32* textures);
			[ThreadStatic]
			internal static glGenTextures pglGenTextures;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenTexturesEXT(Int32 n, UInt32* textures);
			[ThreadStatic]
			internal static glGenTexturesEXT pglGenTexturesEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenTransformFeedbacks(Int32 n, UInt32* ids);
			[ThreadStatic]
			internal static glGenTransformFeedbacks pglGenTransformFeedbacks;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenTransformFeedbacksNV(Int32 n, UInt32* ids);
			[ThreadStatic]
			internal static glGenTransformFeedbacksNV pglGenTransformFeedbacksNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenVertexArrays(Int32 n, UInt32* arrays);
			[ThreadStatic]
			internal static glGenVertexArrays pglGenVertexArrays;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenVertexArraysAPPLE(Int32 n, UInt32* arrays);
			[ThreadStatic]
			internal static glGenVertexArraysAPPLE pglGenVertexArraysAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glGenVertexShadersEXT(UInt32 range);
			[ThreadStatic]
			internal static glGenVertexShadersEXT pglGenVertexShadersEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGenerateMipmap(int target);
			[ThreadStatic]
			internal static glGenerateMipmap pglGenerateMipmap;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGenerateMipmapEXT(int target);
			[ThreadStatic]
			internal static glGenerateMipmapEXT pglGenerateMipmapEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGenerateMultiTexMipmapEXT(int texunit, int target);
			[ThreadStatic]
			internal static glGenerateMultiTexMipmapEXT pglGenerateMultiTexMipmapEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGenerateTextureMipmap(UInt32 texture);
			[ThreadStatic]
			internal static glGenerateTextureMipmap pglGenerateTextureMipmap;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGenerateTextureMipmapEXT(UInt32 texture, int target);
			[ThreadStatic]
			internal static glGenerateTextureMipmapEXT pglGenerateTextureMipmapEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetActiveAtomicCounterBufferiv(UInt32 program, UInt32 bufferIndex, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetActiveAtomicCounterBufferiv pglGetActiveAtomicCounterBufferiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, Int32* length, Int32* size, int* type, [Out] StringBuilder name);
			[ThreadStatic]
			internal static glGetActiveAttrib pglGetActiveAttrib;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetActiveAttribARB(UInt32 programObj, UInt32 index, Int32 maxLength, Int32* length, Int32* size, int* type, [Out] StringBuilder name);
			[ThreadStatic]
			internal static glGetActiveAttribARB pglGetActiveAttribARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetActiveSubroutineName(UInt32 program, int shadertype, UInt32 index, Int32 bufsize, Int32* length, [Out] StringBuilder name);
			[ThreadStatic]
			internal static glGetActiveSubroutineName pglGetActiveSubroutineName;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetActiveSubroutineUniformName(UInt32 program, int shadertype, UInt32 index, Int32 bufsize, Int32* length, [Out] StringBuilder name);
			[ThreadStatic]
			internal static glGetActiveSubroutineUniformName pglGetActiveSubroutineUniformName;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetActiveSubroutineUniformiv(UInt32 program, int shadertype, UInt32 index, int pname, Int32* values);
			[ThreadStatic]
			internal static glGetActiveSubroutineUniformiv pglGetActiveSubroutineUniformiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, Int32* length, Int32* size, int* type, [Out] StringBuilder name);
			[ThreadStatic]
			internal static glGetActiveUniform pglGetActiveUniform;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetActiveUniformARB(UInt32 programObj, UInt32 index, Int32 maxLength, Int32* length, Int32* size, int* type, [Out] StringBuilder name);
			[ThreadStatic]
			internal static glGetActiveUniformARB pglGetActiveUniformARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, Int32* length, [Out] StringBuilder uniformBlockName);
			[ThreadStatic]
			internal static glGetActiveUniformBlockName pglGetActiveUniformBlockName;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetActiveUniformBlockiv(UInt32 program, UInt32 uniformBlockIndex, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetActiveUniformBlockiv pglGetActiveUniformBlockiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetActiveUniformName(UInt32 program, UInt32 uniformIndex, Int32 bufSize, Int32* length, [Out] StringBuilder uniformName);
			[ThreadStatic]
			internal static glGetActiveUniformName pglGetActiveUniformName;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetActiveUniformsiv(UInt32 program, Int32 uniformCount, UInt32* uniformIndices, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetActiveUniformsiv pglGetActiveUniformsiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetActiveVaryingNV(UInt32 program, UInt32 index, Int32 bufSize, Int32* length, Int32* size, int* type, [Out] StringBuilder name);
			[ThreadStatic]
			internal static glGetActiveVaryingNV pglGetActiveVaryingNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetArrayObjectfvATI(int array, int pname, float* @params);
			[ThreadStatic]
			internal static glGetArrayObjectfvATI pglGetArrayObjectfvATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetArrayObjectivATI(int array, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetArrayObjectivATI pglGetArrayObjectivATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetAttachedObjectsARB(UInt32 containerObj, Int32 maxCount, Int32* count, UInt32* obj);
			[ThreadStatic]
			internal static glGetAttachedObjectsARB pglGetAttachedObjectsARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetAttachedShaders(UInt32 program, Int32 maxCount, Int32* count, UInt32* shaders);
			[ThreadStatic]
			internal static glGetAttachedShaders pglGetAttachedShaders;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetAttribLocation(UInt32 program, String name);
			[ThreadStatic]
			internal static glGetAttribLocation pglGetAttribLocation;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetAttribLocationARB(UInt32 programObj, String name);
			[ThreadStatic]
			internal static glGetAttribLocationARB pglGetAttribLocationARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetBooleanIndexedvEXT(int target, UInt32 index, bool* data);
			[ThreadStatic]
			internal static glGetBooleanIndexedvEXT pglGetBooleanIndexedvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetBooleani_v(int target, UInt32 index, bool* data);
			[ThreadStatic]
			internal static glGetBooleani_v pglGetBooleani_v;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetBooleanv(int pname, bool* data);
			[ThreadStatic]
			internal static glGetBooleanv pglGetBooleanv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetBufferParameteri64v(int target, int pname, Int64* @params);
			[ThreadStatic]
			internal static glGetBufferParameteri64v pglGetBufferParameteri64v;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetBufferParameteriv(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetBufferParameteriv pglGetBufferParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetBufferParameterivARB(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetBufferParameterivARB pglGetBufferParameterivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetBufferParameterui64vNV(int target, int pname, UInt64* @params);
			[ThreadStatic]
			internal static glGetBufferParameterui64vNV pglGetBufferParameterui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetBufferPointerv(int target, int pname, IntPtr* @params);
			[ThreadStatic]
			internal static glGetBufferPointerv pglGetBufferPointerv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetBufferPointervARB(int target, int pname, IntPtr* @params);
			[ThreadStatic]
			internal static glGetBufferPointervARB pglGetBufferPointervARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetBufferSubData(int target, IntPtr offset, UInt32 size, IntPtr data);
			[ThreadStatic]
			internal static glGetBufferSubData pglGetBufferSubData;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetBufferSubDataARB(int target, IntPtr offset, UInt32 size, IntPtr data);
			[ThreadStatic]
			internal static glGetBufferSubDataARB pglGetBufferSubDataARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetClipPlane(int plane, double* equation);
			[ThreadStatic]
			internal static glGetClipPlane pglGetClipPlane;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetClipPlanefOES(int plane, float* equation);
			[ThreadStatic]
			internal static glGetClipPlanefOES pglGetClipPlanefOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetClipPlanexOES(int plane, IntPtr* equation);
			[ThreadStatic]
			internal static glGetClipPlanexOES pglGetClipPlanexOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetColorTable(int target, int format, int type, IntPtr table);
			[ThreadStatic]
			internal static glGetColorTable pglGetColorTable;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetColorTableEXT(int target, int format, int type, IntPtr data);
			[ThreadStatic]
			internal static glGetColorTableEXT pglGetColorTableEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetColorTableParameterfv(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glGetColorTableParameterfv pglGetColorTableParameterfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetColorTableParameterfvEXT(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glGetColorTableParameterfvEXT pglGetColorTableParameterfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetColorTableParameterfvSGI(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glGetColorTableParameterfvSGI pglGetColorTableParameterfvSGI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetColorTableParameteriv(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetColorTableParameteriv pglGetColorTableParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetColorTableParameterivEXT(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetColorTableParameterivEXT pglGetColorTableParameterivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetColorTableParameterivSGI(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetColorTableParameterivSGI pglGetColorTableParameterivSGI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetColorTableSGI(int target, int format, int type, IntPtr table);
			[ThreadStatic]
			internal static glGetColorTableSGI pglGetColorTableSGI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetCombinerInputParameterfvNV(int stage, int portion, int variable, int pname, float* @params);
			[ThreadStatic]
			internal static glGetCombinerInputParameterfvNV pglGetCombinerInputParameterfvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetCombinerInputParameterivNV(int stage, int portion, int variable, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetCombinerInputParameterivNV pglGetCombinerInputParameterivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetCombinerOutputParameterfvNV(int stage, int portion, int pname, float* @params);
			[ThreadStatic]
			internal static glGetCombinerOutputParameterfvNV pglGetCombinerOutputParameterfvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetCombinerOutputParameterivNV(int stage, int portion, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetCombinerOutputParameterivNV pglGetCombinerOutputParameterivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetCombinerStageParameterfvNV(int stage, int pname, float* @params);
			[ThreadStatic]
			internal static glGetCombinerStageParameterfvNV pglGetCombinerStageParameterfvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetCompressedMultiTexImageEXT(int texunit, int target, Int32 lod, IntPtr img);
			[ThreadStatic]
			internal static glGetCompressedMultiTexImageEXT pglGetCompressedMultiTexImageEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetCompressedTexImage(int target, Int32 level, IntPtr img);
			[ThreadStatic]
			internal static glGetCompressedTexImage pglGetCompressedTexImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetCompressedTexImageARB(int target, Int32 level, IntPtr img);
			[ThreadStatic]
			internal static glGetCompressedTexImageARB pglGetCompressedTexImageARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetCompressedTextureImage(UInt32 texture, Int32 level, Int32 bufSize, IntPtr pixels);
			[ThreadStatic]
			internal static glGetCompressedTextureImage pglGetCompressedTextureImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetCompressedTextureImageEXT(UInt32 texture, int target, Int32 lod, IntPtr img);
			[ThreadStatic]
			internal static glGetCompressedTextureImageEXT pglGetCompressedTextureImageEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetCompressedTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 bufSize, IntPtr pixels);
			[ThreadStatic]
			internal static glGetCompressedTextureSubImage pglGetCompressedTextureSubImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetConvolutionFilter(int target, int format, int type, IntPtr image);
			[ThreadStatic]
			internal static glGetConvolutionFilter pglGetConvolutionFilter;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetConvolutionFilterEXT(int target, int format, int type, IntPtr image);
			[ThreadStatic]
			internal static glGetConvolutionFilterEXT pglGetConvolutionFilterEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetConvolutionParameterfv(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glGetConvolutionParameterfv pglGetConvolutionParameterfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetConvolutionParameterfvEXT(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glGetConvolutionParameterfvEXT pglGetConvolutionParameterfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetConvolutionParameteriv(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetConvolutionParameteriv pglGetConvolutionParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetConvolutionParameterivEXT(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetConvolutionParameterivEXT pglGetConvolutionParameterivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetConvolutionParameterxvOES(int target, int pname, IntPtr* @params);
			[ThreadStatic]
			internal static glGetConvolutionParameterxvOES pglGetConvolutionParameterxvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 glGetDebugMessageLog(UInt32 count, Int32 bufSize, int* sources, int* types, UInt32* ids, int* severities, Int32* lengths, [Out] StringBuilder messageLog);
			[ThreadStatic]
			internal static glGetDebugMessageLog pglGetDebugMessageLog;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 glGetDebugMessageLogAMD(UInt32 count, Int32 bufsize, int* categories, UInt32* severities, UInt32* ids, Int32* lengths, [Out] StringBuilder message);
			[ThreadStatic]
			internal static glGetDebugMessageLogAMD pglGetDebugMessageLogAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 glGetDebugMessageLogARB(UInt32 count, Int32 bufSize, int* sources, int* types, UInt32* ids, int* severities, Int32* lengths, [Out] StringBuilder messageLog);
			[ThreadStatic]
			internal static glGetDebugMessageLogARB pglGetDebugMessageLogARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetDetailTexFuncSGIS(int target, float* points);
			[ThreadStatic]
			internal static glGetDetailTexFuncSGIS pglGetDetailTexFuncSGIS;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetDoubleIndexedvEXT(int target, UInt32 index, double* data);
			[ThreadStatic]
			internal static glGetDoubleIndexedvEXT pglGetDoubleIndexedvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetDoublei_v(int target, UInt32 index, double* data);
			[ThreadStatic]
			internal static glGetDoublei_v pglGetDoublei_v;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetDoublei_vEXT(int pname, UInt32 index, double* @params);
			[ThreadStatic]
			internal static glGetDoublei_vEXT pglGetDoublei_vEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetDoublev(int pname, double* data);
			[ThreadStatic]
			internal static glGetDoublev pglGetDoublev;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int glGetError();
			[ThreadStatic]
			internal static glGetError pglGetError;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFenceivNV(UInt32 fence, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetFenceivNV pglGetFenceivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFinalCombinerInputParameterfvNV(int variable, int pname, float* @params);
			[ThreadStatic]
			internal static glGetFinalCombinerInputParameterfvNV pglGetFinalCombinerInputParameterfvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFinalCombinerInputParameterivNV(int variable, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetFinalCombinerInputParameterivNV pglGetFinalCombinerInputParameterivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFirstPerfQueryIdINTEL(UInt32* queryId);
			[ThreadStatic]
			internal static glGetFirstPerfQueryIdINTEL pglGetFirstPerfQueryIdINTEL;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFixedvOES(int pname, IntPtr* @params);
			[ThreadStatic]
			internal static glGetFixedvOES pglGetFixedvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFloatIndexedvEXT(int target, UInt32 index, float* data);
			[ThreadStatic]
			internal static glGetFloatIndexedvEXT pglGetFloatIndexedvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFloati_v(int target, UInt32 index, float* data);
			[ThreadStatic]
			internal static glGetFloati_v pglGetFloati_v;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFloati_vEXT(int pname, UInt32 index, float* @params);
			[ThreadStatic]
			internal static glGetFloati_vEXT pglGetFloati_vEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFloatv(int pname, float* data);
			[ThreadStatic]
			internal static glGetFloatv pglGetFloatv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFogFuncSGIS(float* points);
			[ThreadStatic]
			internal static glGetFogFuncSGIS pglGetFogFuncSGIS;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetFragDataIndex(UInt32 program, String name);
			[ThreadStatic]
			internal static glGetFragDataIndex pglGetFragDataIndex;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetFragDataLocation(UInt32 program, String name);
			[ThreadStatic]
			internal static glGetFragDataLocation pglGetFragDataLocation;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetFragDataLocationEXT(UInt32 program, String name);
			[ThreadStatic]
			internal static glGetFragDataLocationEXT pglGetFragDataLocationEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFragmentLightfvSGIX(int light, int pname, float* @params);
			[ThreadStatic]
			internal static glGetFragmentLightfvSGIX pglGetFragmentLightfvSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFragmentLightivSGIX(int light, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetFragmentLightivSGIX pglGetFragmentLightivSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFragmentMaterialfvSGIX(int face, int pname, float* @params);
			[ThreadStatic]
			internal static glGetFragmentMaterialfvSGIX pglGetFragmentMaterialfvSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFragmentMaterialivSGIX(int face, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetFragmentMaterialivSGIX pglGetFragmentMaterialivSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFramebufferAttachmentParameteriv(int target, int attachment, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetFramebufferAttachmentParameteriv pglGetFramebufferAttachmentParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFramebufferAttachmentParameterivEXT(int target, int attachment, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetFramebufferAttachmentParameterivEXT pglGetFramebufferAttachmentParameterivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFramebufferParameteriv(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetFramebufferParameteriv pglGetFramebufferParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFramebufferParameterivEXT(UInt32 framebuffer, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetFramebufferParameterivEXT pglGetFramebufferParameterivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int glGetGraphicsResetStatus();
			[ThreadStatic]
			internal static glGetGraphicsResetStatus pglGetGraphicsResetStatus;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int glGetGraphicsResetStatusARB();
			[ThreadStatic]
			internal static glGetGraphicsResetStatusARB pglGetGraphicsResetStatusARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glGetHandleARB(int pname);
			[ThreadStatic]
			internal static glGetHandleARB pglGetHandleARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetHistogram(int target, bool reset, int format, int type, IntPtr values);
			[ThreadStatic]
			internal static glGetHistogram pglGetHistogram;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetHistogramEXT(int target, bool reset, int format, int type, IntPtr values);
			[ThreadStatic]
			internal static glGetHistogramEXT pglGetHistogramEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetHistogramParameterfv(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glGetHistogramParameterfv pglGetHistogramParameterfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetHistogramParameterfvEXT(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glGetHistogramParameterfvEXT pglGetHistogramParameterfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetHistogramParameteriv(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetHistogramParameteriv pglGetHistogramParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetHistogramParameterivEXT(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetHistogramParameterivEXT pglGetHistogramParameterivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetHistogramParameterxvOES(int target, int pname, IntPtr* @params);
			[ThreadStatic]
			internal static glGetHistogramParameterxvOES pglGetHistogramParameterxvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt64 glGetImageHandleARB(UInt32 texture, Int32 level, bool layered, Int32 layer, int format);
			[ThreadStatic]
			internal static glGetImageHandleARB pglGetImageHandleARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt64 glGetImageHandleNV(UInt32 texture, Int32 level, bool layered, Int32 layer, int format);
			[ThreadStatic]
			internal static glGetImageHandleNV pglGetImageHandleNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetImageTransformParameterfvHP(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glGetImageTransformParameterfvHP pglGetImageTransformParameterfvHP;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetImageTransformParameterivHP(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetImageTransformParameterivHP pglGetImageTransformParameterivHP;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetInfoLogARB(UInt32 obj, Int32 maxLength, Int32* length, [Out] StringBuilder infoLog);
			[ThreadStatic]
			internal static glGetInfoLogARB pglGetInfoLogARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetInstrumentsSGIX();
			[ThreadStatic]
			internal static glGetInstrumentsSGIX pglGetInstrumentsSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetInteger64i_v(int target, UInt32 index, Int64* data);
			[ThreadStatic]
			internal static glGetInteger64i_v pglGetInteger64i_v;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetInteger64v(int pname, Int64* data);
			[ThreadStatic]
			internal static glGetInteger64v pglGetInteger64v;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetIntegerIndexedvEXT(int target, UInt32 index, Int32* data);
			[ThreadStatic]
			internal static glGetIntegerIndexedvEXT pglGetIntegerIndexedvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetIntegeri_v(int target, UInt32 index, Int32* data);
			[ThreadStatic]
			internal static glGetIntegeri_v pglGetIntegeri_v;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetIntegerui64i_vNV(int value, UInt32 index, UInt64* result);
			[ThreadStatic]
			internal static glGetIntegerui64i_vNV pglGetIntegerui64i_vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetIntegerui64vNV(int value, UInt64* result);
			[ThreadStatic]
			internal static glGetIntegerui64vNV pglGetIntegerui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetIntegerv(int pname, Int32* data);
			[ThreadStatic]
			internal static glGetIntegerv pglGetIntegerv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetInternalformati64v(int target, int internalformat, int pname, Int32 bufSize, Int64* @params);
			[ThreadStatic]
			internal static glGetInternalformati64v pglGetInternalformati64v;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetInternalformativ(int target, int internalformat, int pname, Int32 bufSize, Int32* @params);
			[ThreadStatic]
			internal static glGetInternalformativ pglGetInternalformativ;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetInternalformatSampleivNV(int target, int internalformat, Int32 samples, int pname, Int32 bufSize, Int32* @params);
			[ThreadStatic]
			internal static glGetInternalformatSampleivNV pglGetInternalformatSampleivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetInvariantBooleanvEXT(UInt32 id, int value, bool* data);
			[ThreadStatic]
			internal static glGetInvariantBooleanvEXT pglGetInvariantBooleanvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetInvariantFloatvEXT(UInt32 id, int value, float* data);
			[ThreadStatic]
			internal static glGetInvariantFloatvEXT pglGetInvariantFloatvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetInvariantIntegervEXT(UInt32 id, int value, Int32* data);
			[ThreadStatic]
			internal static glGetInvariantIntegervEXT pglGetInvariantIntegervEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetLightfv(int light, int pname, float* @params);
			[ThreadStatic]
			internal static glGetLightfv pglGetLightfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetLightiv(int light, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetLightiv pglGetLightiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetLightxOES(int light, int pname, IntPtr* @params);
			[ThreadStatic]
			internal static glGetLightxOES pglGetLightxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetListParameterfvSGIX(UInt32 list, int pname, float* @params);
			[ThreadStatic]
			internal static glGetListParameterfvSGIX pglGetListParameterfvSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetListParameterivSGIX(UInt32 list, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetListParameterivSGIX pglGetListParameterivSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetLocalConstantBooleanvEXT(UInt32 id, int value, bool* data);
			[ThreadStatic]
			internal static glGetLocalConstantBooleanvEXT pglGetLocalConstantBooleanvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetLocalConstantFloatvEXT(UInt32 id, int value, float* data);
			[ThreadStatic]
			internal static glGetLocalConstantFloatvEXT pglGetLocalConstantFloatvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetLocalConstantIntegervEXT(UInt32 id, int value, Int32* data);
			[ThreadStatic]
			internal static glGetLocalConstantIntegervEXT pglGetLocalConstantIntegervEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMapAttribParameterfvNV(int target, UInt32 index, int pname, float* @params);
			[ThreadStatic]
			internal static glGetMapAttribParameterfvNV pglGetMapAttribParameterfvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMapAttribParameterivNV(int target, UInt32 index, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetMapAttribParameterivNV pglGetMapAttribParameterivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMapControlPointsNV(int target, UInt32 index, int type, Int32 ustride, Int32 vstride, bool packed, IntPtr points);
			[ThreadStatic]
			internal static glGetMapControlPointsNV pglGetMapControlPointsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMapParameterfvNV(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glGetMapParameterfvNV pglGetMapParameterfvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMapParameterivNV(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetMapParameterivNV pglGetMapParameterivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMapdv(int target, int query, double* v);
			[ThreadStatic]
			internal static glGetMapdv pglGetMapdv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMapfv(int target, int query, float* v);
			[ThreadStatic]
			internal static glGetMapfv pglGetMapfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMapiv(int target, int query, Int32* v);
			[ThreadStatic]
			internal static glGetMapiv pglGetMapiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMapxvOES(int target, int query, IntPtr* v);
			[ThreadStatic]
			internal static glGetMapxvOES pglGetMapxvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMaterialfv(int face, int pname, float* @params);
			[ThreadStatic]
			internal static glGetMaterialfv pglGetMaterialfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMaterialiv(int face, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetMaterialiv pglGetMaterialiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMaterialxOES(int face, int pname, IntPtr param);
			[ThreadStatic]
			internal static glGetMaterialxOES pglGetMaterialxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMinmax(int target, bool reset, int format, int type, IntPtr values);
			[ThreadStatic]
			internal static glGetMinmax pglGetMinmax;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMinmaxEXT(int target, bool reset, int format, int type, IntPtr values);
			[ThreadStatic]
			internal static glGetMinmaxEXT pglGetMinmaxEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMinmaxParameterfv(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glGetMinmaxParameterfv pglGetMinmaxParameterfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMinmaxParameterfvEXT(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glGetMinmaxParameterfvEXT pglGetMinmaxParameterfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMinmaxParameteriv(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetMinmaxParameteriv pglGetMinmaxParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMinmaxParameterivEXT(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetMinmaxParameterivEXT pglGetMinmaxParameterivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexEnvfvEXT(int texunit, int target, int pname, float* @params);
			[ThreadStatic]
			internal static glGetMultiTexEnvfvEXT pglGetMultiTexEnvfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexEnvivEXT(int texunit, int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetMultiTexEnvivEXT pglGetMultiTexEnvivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexGendvEXT(int texunit, int coord, int pname, double* @params);
			[ThreadStatic]
			internal static glGetMultiTexGendvEXT pglGetMultiTexGendvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexGenfvEXT(int texunit, int coord, int pname, float* @params);
			[ThreadStatic]
			internal static glGetMultiTexGenfvEXT pglGetMultiTexGenfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexGenivEXT(int texunit, int coord, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetMultiTexGenivEXT pglGetMultiTexGenivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexImageEXT(int texunit, int target, Int32 level, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glGetMultiTexImageEXT pglGetMultiTexImageEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexLevelParameterfvEXT(int texunit, int target, Int32 level, int pname, float* @params);
			[ThreadStatic]
			internal static glGetMultiTexLevelParameterfvEXT pglGetMultiTexLevelParameterfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexLevelParameterivEXT(int texunit, int target, Int32 level, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetMultiTexLevelParameterivEXT pglGetMultiTexLevelParameterivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexParameterIivEXT(int texunit, int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetMultiTexParameterIivEXT pglGetMultiTexParameterIivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexParameterIuivEXT(int texunit, int target, int pname, UInt32* @params);
			[ThreadStatic]
			internal static glGetMultiTexParameterIuivEXT pglGetMultiTexParameterIuivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexParameterfvEXT(int texunit, int target, int pname, float* @params);
			[ThreadStatic]
			internal static glGetMultiTexParameterfvEXT pglGetMultiTexParameterfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultiTexParameterivEXT(int texunit, int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetMultiTexParameterivEXT pglGetMultiTexParameterivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultisamplefv(int pname, UInt32 index, float* val);
			[ThreadStatic]
			internal static glGetMultisamplefv pglGetMultisamplefv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMultisamplefvNV(int pname, UInt32 index, float* val);
			[ThreadStatic]
			internal static glGetMultisamplefvNV pglGetMultisamplefvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedBufferParameteri64v(UInt32 buffer, int pname, Int64* @params);
			[ThreadStatic]
			internal static glGetNamedBufferParameteri64v pglGetNamedBufferParameteri64v;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedBufferParameteriv(UInt32 buffer, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetNamedBufferParameteriv pglGetNamedBufferParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedBufferParameterivEXT(UInt32 buffer, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetNamedBufferParameterivEXT pglGetNamedBufferParameterivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedBufferParameterui64vNV(UInt32 buffer, int pname, UInt64* @params);
			[ThreadStatic]
			internal static glGetNamedBufferParameterui64vNV pglGetNamedBufferParameterui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedBufferPointerv(UInt32 buffer, int pname, IntPtr* @params);
			[ThreadStatic]
			internal static glGetNamedBufferPointerv pglGetNamedBufferPointerv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedBufferPointervEXT(UInt32 buffer, int pname, IntPtr* @params);
			[ThreadStatic]
			internal static glGetNamedBufferPointervEXT pglGetNamedBufferPointervEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedBufferSubData(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data);
			[ThreadStatic]
			internal static glGetNamedBufferSubData pglGetNamedBufferSubData;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedBufferSubDataEXT(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data);
			[ThreadStatic]
			internal static glGetNamedBufferSubDataEXT pglGetNamedBufferSubDataEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedFramebufferAttachmentParameteriv(UInt32 framebuffer, int attachment, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetNamedFramebufferAttachmentParameteriv pglGetNamedFramebufferAttachmentParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedFramebufferAttachmentParameterivEXT(UInt32 framebuffer, int attachment, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetNamedFramebufferAttachmentParameterivEXT pglGetNamedFramebufferAttachmentParameterivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedFramebufferParameteriv(UInt32 framebuffer, int pname, Int32* param);
			[ThreadStatic]
			internal static glGetNamedFramebufferParameteriv pglGetNamedFramebufferParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedFramebufferParameterivEXT(UInt32 framebuffer, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetNamedFramebufferParameterivEXT pglGetNamedFramebufferParameterivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedProgramLocalParameterIivEXT(UInt32 program, int target, UInt32 index, Int32* @params);
			[ThreadStatic]
			internal static glGetNamedProgramLocalParameterIivEXT pglGetNamedProgramLocalParameterIivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedProgramLocalParameterIuivEXT(UInt32 program, int target, UInt32 index, UInt32* @params);
			[ThreadStatic]
			internal static glGetNamedProgramLocalParameterIuivEXT pglGetNamedProgramLocalParameterIuivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedProgramLocalParameterdvEXT(UInt32 program, int target, UInt32 index, double* @params);
			[ThreadStatic]
			internal static glGetNamedProgramLocalParameterdvEXT pglGetNamedProgramLocalParameterdvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedProgramLocalParameterfvEXT(UInt32 program, int target, UInt32 index, float* @params);
			[ThreadStatic]
			internal static glGetNamedProgramLocalParameterfvEXT pglGetNamedProgramLocalParameterfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedProgramStringEXT(UInt32 program, int target, int pname, IntPtr @string);
			[ThreadStatic]
			internal static glGetNamedProgramStringEXT pglGetNamedProgramStringEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedProgramivEXT(UInt32 program, int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetNamedProgramivEXT pglGetNamedProgramivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedRenderbufferParameteriv(UInt32 renderbuffer, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetNamedRenderbufferParameteriv pglGetNamedRenderbufferParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedRenderbufferParameterivEXT(UInt32 renderbuffer, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetNamedRenderbufferParameterivEXT pglGetNamedRenderbufferParameterivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedStringARB(Int32 namelen, String name, Int32 bufSize, Int32* stringlen, [Out] StringBuilder @string);
			[ThreadStatic]
			internal static glGetNamedStringARB pglGetNamedStringARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedStringivARB(Int32 namelen, String name, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetNamedStringivARB pglGetNamedStringivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNextPerfQueryIdINTEL(UInt32 queryId, UInt32* nextQueryId);
			[ThreadStatic]
			internal static glGetNextPerfQueryIdINTEL pglGetNextPerfQueryIdINTEL;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetObjectBufferfvATI(UInt32 buffer, int pname, float* @params);
			[ThreadStatic]
			internal static glGetObjectBufferfvATI pglGetObjectBufferfvATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetObjectBufferivATI(UInt32 buffer, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetObjectBufferivATI pglGetObjectBufferivATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetObjectLabel(int identifier, UInt32 name, Int32 bufSize, Int32* length, [Out] StringBuilder label);
			[ThreadStatic]
			internal static glGetObjectLabel pglGetObjectLabel;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetObjectLabelEXT(int type, UInt32 @object, Int32 bufSize, Int32* length, [Out] StringBuilder label);
			[ThreadStatic]
			internal static glGetObjectLabelEXT pglGetObjectLabelEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetObjectParameterfvARB(UInt32 obj, int pname, float* @params);
			[ThreadStatic]
			internal static glGetObjectParameterfvARB pglGetObjectParameterfvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetObjectParameterivAPPLE(int objectType, UInt32 name, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetObjectParameterivAPPLE pglGetObjectParameterivAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetObjectParameterivARB(UInt32 obj, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetObjectParameterivARB pglGetObjectParameterivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetObjectPtrLabel(IntPtr ptr, Int32 bufSize, Int32* length, [Out] StringBuilder label);
			[ThreadStatic]
			internal static glGetObjectPtrLabel pglGetObjectPtrLabel;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetOcclusionQueryivNV(UInt32 id, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetOcclusionQueryivNV pglGetOcclusionQueryivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetOcclusionQueryuivNV(UInt32 id, int pname, UInt32* @params);
			[ThreadStatic]
			internal static glGetOcclusionQueryuivNV pglGetOcclusionQueryuivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPathColorGenfvNV(int color, int pname, float* value);
			[ThreadStatic]
			internal static glGetPathColorGenfvNV pglGetPathColorGenfvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPathColorGenivNV(int color, int pname, Int32* value);
			[ThreadStatic]
			internal static glGetPathColorGenivNV pglGetPathColorGenivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPathCommandsNV(UInt32 path, byte* commands);
			[ThreadStatic]
			internal static glGetPathCommandsNV pglGetPathCommandsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPathCoordsNV(UInt32 path, float* coords);
			[ThreadStatic]
			internal static glGetPathCoordsNV pglGetPathCoordsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPathDashArrayNV(UInt32 path, float* dashArray);
			[ThreadStatic]
			internal static glGetPathDashArrayNV pglGetPathDashArrayNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate float glGetPathLengthNV(UInt32 path, Int32 startSegment, Int32 numSegments);
			[ThreadStatic]
			internal static glGetPathLengthNV pglGetPathLengthNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPathMetricRangeNV(uint metricQueryMask, UInt32 firstPathName, Int32 numPaths, Int32 stride, float* metrics);
			[ThreadStatic]
			internal static glGetPathMetricRangeNV pglGetPathMetricRangeNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPathMetricsNV(uint metricQueryMask, Int32 numPaths, int pathNameType, IntPtr paths, UInt32 pathBase, Int32 stride, float* metrics);
			[ThreadStatic]
			internal static glGetPathMetricsNV pglGetPathMetricsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPathParameterfvNV(UInt32 path, int pname, float* value);
			[ThreadStatic]
			internal static glGetPathParameterfvNV pglGetPathParameterfvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPathParameterivNV(UInt32 path, int pname, Int32* value);
			[ThreadStatic]
			internal static glGetPathParameterivNV pglGetPathParameterivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPathSpacingNV(int pathListMode, Int32 numPaths, int pathNameType, IntPtr paths, UInt32 pathBase, float advanceScale, float kerningScale, int transformType, float* returnedSpacing);
			[ThreadStatic]
			internal static glGetPathSpacingNV pglGetPathSpacingNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPathTexGenfvNV(int texCoordSet, int pname, float* value);
			[ThreadStatic]
			internal static glGetPathTexGenfvNV pglGetPathTexGenfvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPathTexGenivNV(int texCoordSet, int pname, Int32* value);
			[ThreadStatic]
			internal static glGetPathTexGenivNV pglGetPathTexGenivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPerfCounterInfoINTEL(UInt32 queryId, UInt32 counterId, UInt32 counterNameLength, String counterName, UInt32 counterDescLength, String counterDesc, UInt32* counterOffset, UInt32* counterDataSize, UInt32* counterTypeEnum, UInt32* counterDataTypeEnum, UInt64* rawCounterMaxValue);
			[ThreadStatic]
			internal static glGetPerfCounterInfoINTEL pglGetPerfCounterInfoINTEL;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPerfMonitorCounterDataAMD(UInt32 monitor, int pname, Int32 dataSize, UInt32* data, Int32* bytesWritten);
			[ThreadStatic]
			internal static glGetPerfMonitorCounterDataAMD pglGetPerfMonitorCounterDataAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPerfMonitorCounterInfoAMD(UInt32 group, UInt32 counter, int pname, IntPtr data);
			[ThreadStatic]
			internal static glGetPerfMonitorCounterInfoAMD pglGetPerfMonitorCounterInfoAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPerfMonitorCounterStringAMD(UInt32 group, UInt32 counter, Int32 bufSize, Int32* length, [Out] StringBuilder counterString);
			[ThreadStatic]
			internal static glGetPerfMonitorCounterStringAMD pglGetPerfMonitorCounterStringAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPerfMonitorCountersAMD(UInt32 group, Int32* numCounters, Int32* maxActiveCounters, Int32 counterSize, UInt32* counters);
			[ThreadStatic]
			internal static glGetPerfMonitorCountersAMD pglGetPerfMonitorCountersAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPerfMonitorGroupStringAMD(UInt32 group, Int32 bufSize, Int32* length, [Out] StringBuilder groupString);
			[ThreadStatic]
			internal static glGetPerfMonitorGroupStringAMD pglGetPerfMonitorGroupStringAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPerfMonitorGroupsAMD(Int32* numGroups, Int32 groupsSize, UInt32* groups);
			[ThreadStatic]
			internal static glGetPerfMonitorGroupsAMD pglGetPerfMonitorGroupsAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPerfQueryDataINTEL(UInt32 queryHandle, UInt32 flags, Int32 dataSize, void* data, UInt32* bytesWritten);
			[ThreadStatic]
			internal static glGetPerfQueryDataINTEL pglGetPerfQueryDataINTEL;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPerfQueryIdByNameINTEL(String queryName, UInt32* queryId);
			[ThreadStatic]
			internal static glGetPerfQueryIdByNameINTEL pglGetPerfQueryIdByNameINTEL;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPerfQueryInfoINTEL(UInt32 queryId, UInt32 queryNameLength, String queryName, UInt32* dataSize, UInt32* noCounters, UInt32* noInstances, UInt32* capsMask);
			[ThreadStatic]
			internal static glGetPerfQueryInfoINTEL pglGetPerfQueryInfoINTEL;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPixelMapfv(int map, float* values);
			[ThreadStatic]
			internal static glGetPixelMapfv pglGetPixelMapfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPixelMapuiv(int map, UInt32* values);
			[ThreadStatic]
			internal static glGetPixelMapuiv pglGetPixelMapuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPixelMapusv(int map, UInt16* values);
			[ThreadStatic]
			internal static glGetPixelMapusv pglGetPixelMapusv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPixelMapxv(int map, Int32 size, IntPtr* values);
			[ThreadStatic]
			internal static glGetPixelMapxv pglGetPixelMapxv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPixelTexGenParameterfvSGIS(int pname, float* @params);
			[ThreadStatic]
			internal static glGetPixelTexGenParameterfvSGIS pglGetPixelTexGenParameterfvSGIS;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPixelTexGenParameterivSGIS(int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetPixelTexGenParameterivSGIS pglGetPixelTexGenParameterivSGIS;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPixelTransformParameterfvEXT(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glGetPixelTransformParameterfvEXT pglGetPixelTransformParameterfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPixelTransformParameterivEXT(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetPixelTransformParameterivEXT pglGetPixelTransformParameterivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPointerIndexedvEXT(int target, UInt32 index, IntPtr* data);
			[ThreadStatic]
			internal static glGetPointerIndexedvEXT pglGetPointerIndexedvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPointeri_vEXT(int pname, UInt32 index, IntPtr* @params);
			[ThreadStatic]
			internal static glGetPointeri_vEXT pglGetPointeri_vEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPointerv(int pname, IntPtr* @params);
			[ThreadStatic]
			internal static glGetPointerv pglGetPointerv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPointervEXT(int pname, IntPtr* @params);
			[ThreadStatic]
			internal static glGetPointervEXT pglGetPointervEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPolygonStipple(byte* mask);
			[ThreadStatic]
			internal static glGetPolygonStipple pglGetPolygonStipple;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramBinary(UInt32 program, Int32 bufSize, Int32* length, int* binaryFormat, IntPtr binary);
			[ThreadStatic]
			internal static glGetProgramBinary pglGetProgramBinary;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramEnvParameterIivNV(int target, UInt32 index, Int32* @params);
			[ThreadStatic]
			internal static glGetProgramEnvParameterIivNV pglGetProgramEnvParameterIivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramEnvParameterIuivNV(int target, UInt32 index, UInt32* @params);
			[ThreadStatic]
			internal static glGetProgramEnvParameterIuivNV pglGetProgramEnvParameterIuivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramEnvParameterdvARB(int target, UInt32 index, double* @params);
			[ThreadStatic]
			internal static glGetProgramEnvParameterdvARB pglGetProgramEnvParameterdvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramEnvParameterfvARB(int target, UInt32 index, float* @params);
			[ThreadStatic]
			internal static glGetProgramEnvParameterfvARB pglGetProgramEnvParameterfvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramInfoLog(UInt32 program, Int32 bufSize, Int32* length, [Out] StringBuilder infoLog);
			[ThreadStatic]
			internal static glGetProgramInfoLog pglGetProgramInfoLog;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramInterfaceiv(UInt32 program, int programInterface, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetProgramInterfaceiv pglGetProgramInterfaceiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramLocalParameterIivNV(int target, UInt32 index, Int32* @params);
			[ThreadStatic]
			internal static glGetProgramLocalParameterIivNV pglGetProgramLocalParameterIivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramLocalParameterIuivNV(int target, UInt32 index, UInt32* @params);
			[ThreadStatic]
			internal static glGetProgramLocalParameterIuivNV pglGetProgramLocalParameterIuivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramLocalParameterdvARB(int target, UInt32 index, double* @params);
			[ThreadStatic]
			internal static glGetProgramLocalParameterdvARB pglGetProgramLocalParameterdvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramLocalParameterfvARB(int target, UInt32 index, float* @params);
			[ThreadStatic]
			internal static glGetProgramLocalParameterfvARB pglGetProgramLocalParameterfvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramNamedParameterdvNV(UInt32 id, Int32 len, byte* name, double* @params);
			[ThreadStatic]
			internal static glGetProgramNamedParameterdvNV pglGetProgramNamedParameterdvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramNamedParameterfvNV(UInt32 id, Int32 len, byte* name, float* @params);
			[ThreadStatic]
			internal static glGetProgramNamedParameterfvNV pglGetProgramNamedParameterfvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramParameterdvNV(int target, UInt32 index, int pname, double* @params);
			[ThreadStatic]
			internal static glGetProgramParameterdvNV pglGetProgramParameterdvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramParameterfvNV(int target, UInt32 index, int pname, float* @params);
			[ThreadStatic]
			internal static glGetProgramParameterfvNV pglGetProgramParameterfvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, Int32* length, [Out] StringBuilder infoLog);
			[ThreadStatic]
			internal static glGetProgramPipelineInfoLog pglGetProgramPipelineInfoLog;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramPipelineiv(UInt32 pipeline, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetProgramPipelineiv pglGetProgramPipelineiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glGetProgramResourceIndex(UInt32 program, int programInterface, String name);
			[ThreadStatic]
			internal static glGetProgramResourceIndex pglGetProgramResourceIndex;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetProgramResourceLocation(UInt32 program, int programInterface, String name);
			[ThreadStatic]
			internal static glGetProgramResourceLocation pglGetProgramResourceLocation;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetProgramResourceLocationIndex(UInt32 program, int programInterface, String name);
			[ThreadStatic]
			internal static glGetProgramResourceLocationIndex pglGetProgramResourceLocationIndex;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramResourceName(UInt32 program, int programInterface, UInt32 index, Int32 bufSize, Int32* length, [Out] StringBuilder name);
			[ThreadStatic]
			internal static glGetProgramResourceName pglGetProgramResourceName;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramResourcefvNV(UInt32 program, int programInterface, UInt32 index, Int32 propCount, int* props, Int32 bufSize, Int32* length, float* @params);
			[ThreadStatic]
			internal static glGetProgramResourcefvNV pglGetProgramResourcefvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramResourceiv(UInt32 program, int programInterface, UInt32 index, Int32 propCount, int* props, Int32 bufSize, Int32* length, Int32* @params);
			[ThreadStatic]
			internal static glGetProgramResourceiv pglGetProgramResourceiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramStageiv(UInt32 program, int shadertype, int pname, Int32* values);
			[ThreadStatic]
			internal static glGetProgramStageiv pglGetProgramStageiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramStringARB(int target, int pname, IntPtr @string);
			[ThreadStatic]
			internal static glGetProgramStringARB pglGetProgramStringARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramStringNV(UInt32 id, int pname, byte* program);
			[ThreadStatic]
			internal static glGetProgramStringNV pglGetProgramStringNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramSubroutineParameteruivNV(int target, UInt32 index, UInt32* param);
			[ThreadStatic]
			internal static glGetProgramSubroutineParameteruivNV pglGetProgramSubroutineParameteruivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramiv(UInt32 program, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetProgramiv pglGetProgramiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramivARB(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetProgramivARB pglGetProgramivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetProgramivNV(UInt32 id, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetProgramivNV pglGetProgramivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetQueryBufferObjecti64v(UInt32 id, UInt32 buffer, int pname, IntPtr offset);
			[ThreadStatic]
			internal static glGetQueryBufferObjecti64v pglGetQueryBufferObjecti64v;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetQueryBufferObjectiv(UInt32 id, UInt32 buffer, int pname, IntPtr offset);
			[ThreadStatic]
			internal static glGetQueryBufferObjectiv pglGetQueryBufferObjectiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetQueryBufferObjectui64v(UInt32 id, UInt32 buffer, int pname, IntPtr offset);
			[ThreadStatic]
			internal static glGetQueryBufferObjectui64v pglGetQueryBufferObjectui64v;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetQueryBufferObjectuiv(UInt32 id, UInt32 buffer, int pname, IntPtr offset);
			[ThreadStatic]
			internal static glGetQueryBufferObjectuiv pglGetQueryBufferObjectuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetQueryIndexediv(int target, UInt32 index, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetQueryIndexediv pglGetQueryIndexediv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetQueryObjecti64v(UInt32 id, int pname, Int64* @params);
			[ThreadStatic]
			internal static glGetQueryObjecti64v pglGetQueryObjecti64v;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetQueryObjecti64vEXT(UInt32 id, int pname, Int64* @params);
			[ThreadStatic]
			internal static glGetQueryObjecti64vEXT pglGetQueryObjecti64vEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetQueryObjectiv(UInt32 id, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetQueryObjectiv pglGetQueryObjectiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetQueryObjectivARB(UInt32 id, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetQueryObjectivARB pglGetQueryObjectivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetQueryObjectui64v(UInt32 id, int pname, UInt64* @params);
			[ThreadStatic]
			internal static glGetQueryObjectui64v pglGetQueryObjectui64v;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetQueryObjectui64vEXT(UInt32 id, int pname, UInt64* @params);
			[ThreadStatic]
			internal static glGetQueryObjectui64vEXT pglGetQueryObjectui64vEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetQueryObjectuiv(UInt32 id, int pname, UInt32* @params);
			[ThreadStatic]
			internal static glGetQueryObjectuiv pglGetQueryObjectuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetQueryObjectuivARB(UInt32 id, int pname, UInt32* @params);
			[ThreadStatic]
			internal static glGetQueryObjectuivARB pglGetQueryObjectuivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetQueryiv(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetQueryiv pglGetQueryiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetQueryivARB(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetQueryivARB pglGetQueryivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetRenderbufferParameteriv(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetRenderbufferParameteriv pglGetRenderbufferParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetRenderbufferParameterivEXT(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetRenderbufferParameterivEXT pglGetRenderbufferParameterivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetSamplerParameterIiv(UInt32 sampler, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetSamplerParameterIiv pglGetSamplerParameterIiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetSamplerParameterIuiv(UInt32 sampler, int pname, UInt32* @params);
			[ThreadStatic]
			internal static glGetSamplerParameterIuiv pglGetSamplerParameterIuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetSamplerParameterfv(UInt32 sampler, int pname, float* @params);
			[ThreadStatic]
			internal static glGetSamplerParameterfv pglGetSamplerParameterfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetSamplerParameteriv(UInt32 sampler, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetSamplerParameteriv pglGetSamplerParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetSeparableFilter(int target, int format, int type, IntPtr row, IntPtr column, IntPtr span);
			[ThreadStatic]
			internal static glGetSeparableFilter pglGetSeparableFilter;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetSeparableFilterEXT(int target, int format, int type, IntPtr row, IntPtr column, IntPtr span);
			[ThreadStatic]
			internal static glGetSeparableFilterEXT pglGetSeparableFilterEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetShaderInfoLog(UInt32 shader, Int32 bufSize, Int32* length, [Out] StringBuilder infoLog);
			[ThreadStatic]
			internal static glGetShaderInfoLog pglGetShaderInfoLog;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetShaderPrecisionFormat(int shadertype, int precisiontype, Int32* range, Int32* precision);
			[ThreadStatic]
			internal static glGetShaderPrecisionFormat pglGetShaderPrecisionFormat;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetShaderSource(UInt32 shader, Int32 bufSize, Int32* length, [Out] StringBuilder source);
			[ThreadStatic]
			internal static glGetShaderSource pglGetShaderSource;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetShaderSourceARB(UInt32 obj, Int32 maxLength, Int32* length, [Out] StringBuilder source);
			[ThreadStatic]
			internal static glGetShaderSourceARB pglGetShaderSourceARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetShaderiv(UInt32 shader, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetShaderiv pglGetShaderiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetSharpenTexFuncSGIS(int target, float* points);
			[ThreadStatic]
			internal static glGetSharpenTexFuncSGIS pglGetSharpenTexFuncSGIS;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glGetString(int name);
			[ThreadStatic]
			internal static glGetString pglGetString;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glGetStringi(int name, UInt32 index);
			[ThreadStatic]
			internal static glGetStringi pglGetStringi;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glGetSubroutineIndex(UInt32 program, int shadertype, String name);
			[ThreadStatic]
			internal static glGetSubroutineIndex pglGetSubroutineIndex;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetSubroutineUniformLocation(UInt32 program, int shadertype, String name);
			[ThreadStatic]
			internal static glGetSubroutineUniformLocation pglGetSubroutineUniformLocation;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetSynciv(int sync, int pname, Int32 bufSize, Int32* length, Int32* values);
			[ThreadStatic]
			internal static glGetSynciv pglGetSynciv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexBumpParameterfvATI(int pname, float* param);
			[ThreadStatic]
			internal static glGetTexBumpParameterfvATI pglGetTexBumpParameterfvATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexBumpParameterivATI(int pname, Int32* param);
			[ThreadStatic]
			internal static glGetTexBumpParameterivATI pglGetTexBumpParameterivATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexEnvfv(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glGetTexEnvfv pglGetTexEnvfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexEnviv(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetTexEnviv pglGetTexEnviv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexEnvxvOES(int target, int pname, IntPtr* @params);
			[ThreadStatic]
			internal static glGetTexEnvxvOES pglGetTexEnvxvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexFilterFuncSGIS(int target, int filter, float* weights);
			[ThreadStatic]
			internal static glGetTexFilterFuncSGIS pglGetTexFilterFuncSGIS;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexGendv(int coord, int pname, double* @params);
			[ThreadStatic]
			internal static glGetTexGendv pglGetTexGendv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexGenfv(int coord, int pname, float* @params);
			[ThreadStatic]
			internal static glGetTexGenfv pglGetTexGenfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexGeniv(int coord, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetTexGeniv pglGetTexGeniv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexGenxvOES(int coord, int pname, IntPtr* @params);
			[ThreadStatic]
			internal static glGetTexGenxvOES pglGetTexGenxvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexImage(int target, Int32 level, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glGetTexImage pglGetTexImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexLevelParameterfv(int target, Int32 level, int pname, float* @params);
			[ThreadStatic]
			internal static glGetTexLevelParameterfv pglGetTexLevelParameterfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexLevelParameteriv(int target, Int32 level, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetTexLevelParameteriv pglGetTexLevelParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexLevelParameterxvOES(int target, Int32 level, int pname, IntPtr* @params);
			[ThreadStatic]
			internal static glGetTexLevelParameterxvOES pglGetTexLevelParameterxvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexParameterIiv(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetTexParameterIiv pglGetTexParameterIiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexParameterIivEXT(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetTexParameterIivEXT pglGetTexParameterIivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexParameterIuiv(int target, int pname, UInt32* @params);
			[ThreadStatic]
			internal static glGetTexParameterIuiv pglGetTexParameterIuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexParameterIuivEXT(int target, int pname, UInt32* @params);
			[ThreadStatic]
			internal static glGetTexParameterIuivEXT pglGetTexParameterIuivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexParameterPointervAPPLE(int target, int pname, IntPtr* @params);
			[ThreadStatic]
			internal static glGetTexParameterPointervAPPLE pglGetTexParameterPointervAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexParameterfv(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glGetTexParameterfv pglGetTexParameterfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexParameteriv(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetTexParameteriv pglGetTexParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexParameterxvOES(int target, int pname, IntPtr* @params);
			[ThreadStatic]
			internal static glGetTexParameterxvOES pglGetTexParameterxvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt64 glGetTextureHandleARB(UInt32 texture);
			[ThreadStatic]
			internal static glGetTextureHandleARB pglGetTextureHandleARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt64 glGetTextureHandleNV(UInt32 texture);
			[ThreadStatic]
			internal static glGetTextureHandleNV pglGetTextureHandleNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureImage(UInt32 texture, Int32 level, int format, int type, Int32 bufSize, IntPtr pixels);
			[ThreadStatic]
			internal static glGetTextureImage pglGetTextureImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureImageEXT(UInt32 texture, int target, Int32 level, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glGetTextureImageEXT pglGetTextureImageEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureLevelParameterfv(UInt32 texture, Int32 level, int pname, float* @params);
			[ThreadStatic]
			internal static glGetTextureLevelParameterfv pglGetTextureLevelParameterfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureLevelParameterfvEXT(UInt32 texture, int target, Int32 level, int pname, float* @params);
			[ThreadStatic]
			internal static glGetTextureLevelParameterfvEXT pglGetTextureLevelParameterfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureLevelParameteriv(UInt32 texture, Int32 level, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetTextureLevelParameteriv pglGetTextureLevelParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureLevelParameterivEXT(UInt32 texture, int target, Int32 level, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetTextureLevelParameterivEXT pglGetTextureLevelParameterivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureParameterIiv(UInt32 texture, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetTextureParameterIiv pglGetTextureParameterIiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureParameterIivEXT(UInt32 texture, int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetTextureParameterIivEXT pglGetTextureParameterIivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureParameterIuiv(UInt32 texture, int pname, UInt32* @params);
			[ThreadStatic]
			internal static glGetTextureParameterIuiv pglGetTextureParameterIuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureParameterIuivEXT(UInt32 texture, int target, int pname, UInt32* @params);
			[ThreadStatic]
			internal static glGetTextureParameterIuivEXT pglGetTextureParameterIuivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureParameterfv(UInt32 texture, int pname, float* @params);
			[ThreadStatic]
			internal static glGetTextureParameterfv pglGetTextureParameterfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureParameterfvEXT(UInt32 texture, int target, int pname, float* @params);
			[ThreadStatic]
			internal static glGetTextureParameterfvEXT pglGetTextureParameterfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureParameteriv(UInt32 texture, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetTextureParameteriv pglGetTextureParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureParameterivEXT(UInt32 texture, int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetTextureParameterivEXT pglGetTextureParameterivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt64 glGetTextureSamplerHandleARB(UInt32 texture, UInt32 sampler);
			[ThreadStatic]
			internal static glGetTextureSamplerHandleARB pglGetTextureSamplerHandleARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt64 glGetTextureSamplerHandleNV(UInt32 texture, UInt32 sampler);
			[ThreadStatic]
			internal static glGetTextureSamplerHandleNV pglGetTextureSamplerHandleNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, Int32 bufSize, IntPtr pixels);
			[ThreadStatic]
			internal static glGetTextureSubImage pglGetTextureSubImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTrackMatrixivNV(int target, UInt32 address, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetTrackMatrixivNV pglGetTrackMatrixivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, Int32* length, Int32* size, int* type, [Out] StringBuilder name);
			[ThreadStatic]
			internal static glGetTransformFeedbackVarying pglGetTransformFeedbackVarying;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTransformFeedbackVaryingEXT(UInt32 program, UInt32 index, Int32 bufSize, Int32* length, Int32* size, int* type, [Out] StringBuilder name);
			[ThreadStatic]
			internal static glGetTransformFeedbackVaryingEXT pglGetTransformFeedbackVaryingEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTransformFeedbackVaryingNV(UInt32 program, UInt32 index, Int32* location);
			[ThreadStatic]
			internal static glGetTransformFeedbackVaryingNV pglGetTransformFeedbackVaryingNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTransformFeedbacki64_v(UInt32 xfb, int pname, UInt32 index, Int64* param);
			[ThreadStatic]
			internal static glGetTransformFeedbacki64_v pglGetTransformFeedbacki64_v;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTransformFeedbacki_v(UInt32 xfb, int pname, UInt32 index, Int32* param);
			[ThreadStatic]
			internal static glGetTransformFeedbacki_v pglGetTransformFeedbacki_v;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTransformFeedbackiv(UInt32 xfb, int pname, Int32* param);
			[ThreadStatic]
			internal static glGetTransformFeedbackiv pglGetTransformFeedbackiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glGetUniformBlockIndex(UInt32 program, String uniformBlockName);
			[ThreadStatic]
			internal static glGetUniformBlockIndex pglGetUniformBlockIndex;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetUniformBufferSizeEXT(UInt32 program, Int32 location);
			[ThreadStatic]
			internal static glGetUniformBufferSizeEXT pglGetUniformBufferSizeEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetUniformIndices(UInt32 program, Int32 uniformCount, String[] uniformNames, UInt32* uniformIndices);
			[ThreadStatic]
			internal static glGetUniformIndices pglGetUniformIndices;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetUniformLocation(UInt32 program, String name);
			[ThreadStatic]
			internal static glGetUniformLocation pglGetUniformLocation;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetUniformLocationARB(UInt32 programObj, String name);
			[ThreadStatic]
			internal static glGetUniformLocationARB pglGetUniformLocationARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glGetUniformOffsetEXT(UInt32 program, Int32 location);
			[ThreadStatic]
			internal static glGetUniformOffsetEXT pglGetUniformOffsetEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetUniformSubroutineuiv(int shadertype, Int32 location, UInt32* @params);
			[ThreadStatic]
			internal static glGetUniformSubroutineuiv pglGetUniformSubroutineuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetUniformdv(UInt32 program, Int32 location, double* @params);
			[ThreadStatic]
			internal static glGetUniformdv pglGetUniformdv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetUniformfv(UInt32 program, Int32 location, float* @params);
			[ThreadStatic]
			internal static glGetUniformfv pglGetUniformfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetUniformfvARB(UInt32 programObj, Int32 location, float* @params);
			[ThreadStatic]
			internal static glGetUniformfvARB pglGetUniformfvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetUniformi64vNV(UInt32 program, Int32 location, Int64* @params);
			[ThreadStatic]
			internal static glGetUniformi64vNV pglGetUniformi64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetUniformiv(UInt32 program, Int32 location, Int32* @params);
			[ThreadStatic]
			internal static glGetUniformiv pglGetUniformiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetUniformivARB(UInt32 programObj, Int32 location, Int32* @params);
			[ThreadStatic]
			internal static glGetUniformivARB pglGetUniformivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetUniformui64vNV(UInt32 program, Int32 location, UInt64* @params);
			[ThreadStatic]
			internal static glGetUniformui64vNV pglGetUniformui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetUniformuiv(UInt32 program, Int32 location, UInt32* @params);
			[ThreadStatic]
			internal static glGetUniformuiv pglGetUniformuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetUniformuivEXT(UInt32 program, Int32 location, UInt32* @params);
			[ThreadStatic]
			internal static glGetUniformuivEXT pglGetUniformuivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVariantArrayObjectfvATI(UInt32 id, int pname, float* @params);
			[ThreadStatic]
			internal static glGetVariantArrayObjectfvATI pglGetVariantArrayObjectfvATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVariantArrayObjectivATI(UInt32 id, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetVariantArrayObjectivATI pglGetVariantArrayObjectivATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVariantBooleanvEXT(UInt32 id, int value, bool* data);
			[ThreadStatic]
			internal static glGetVariantBooleanvEXT pglGetVariantBooleanvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVariantFloatvEXT(UInt32 id, int value, float* data);
			[ThreadStatic]
			internal static glGetVariantFloatvEXT pglGetVariantFloatvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVariantIntegervEXT(UInt32 id, int value, Int32* data);
			[ThreadStatic]
			internal static glGetVariantIntegervEXT pglGetVariantIntegervEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVariantPointervEXT(UInt32 id, int value, IntPtr* data);
			[ThreadStatic]
			internal static glGetVariantPointervEXT pglGetVariantPointervEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetVaryingLocationNV(UInt32 program, String name);
			[ThreadStatic]
			internal static glGetVaryingLocationNV pglGetVaryingLocationNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexArrayIndexed64iv(UInt32 vaobj, UInt32 index, int pname, Int64* param);
			[ThreadStatic]
			internal static glGetVertexArrayIndexed64iv pglGetVertexArrayIndexed64iv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexArrayIndexediv(UInt32 vaobj, UInt32 index, int pname, Int32* param);
			[ThreadStatic]
			internal static glGetVertexArrayIndexediv pglGetVertexArrayIndexediv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexArrayIntegeri_vEXT(UInt32 vaobj, UInt32 index, int pname, Int32* param);
			[ThreadStatic]
			internal static glGetVertexArrayIntegeri_vEXT pglGetVertexArrayIntegeri_vEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexArrayIntegervEXT(UInt32 vaobj, int pname, Int32* param);
			[ThreadStatic]
			internal static glGetVertexArrayIntegervEXT pglGetVertexArrayIntegervEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexArrayPointeri_vEXT(UInt32 vaobj, UInt32 index, int pname, IntPtr* param);
			[ThreadStatic]
			internal static glGetVertexArrayPointeri_vEXT pglGetVertexArrayPointeri_vEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexArrayPointervEXT(UInt32 vaobj, int pname, IntPtr* param);
			[ThreadStatic]
			internal static glGetVertexArrayPointervEXT pglGetVertexArrayPointervEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexArrayiv(UInt32 vaobj, int pname, Int32* param);
			[ThreadStatic]
			internal static glGetVertexArrayiv pglGetVertexArrayiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribArrayObjectfvATI(UInt32 index, int pname, float* @params);
			[ThreadStatic]
			internal static glGetVertexAttribArrayObjectfvATI pglGetVertexAttribArrayObjectfvATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribArrayObjectivATI(UInt32 index, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetVertexAttribArrayObjectivATI pglGetVertexAttribArrayObjectivATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribIiv(UInt32 index, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetVertexAttribIiv pglGetVertexAttribIiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribIivEXT(UInt32 index, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetVertexAttribIivEXT pglGetVertexAttribIivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribIuiv(UInt32 index, int pname, UInt32* @params);
			[ThreadStatic]
			internal static glGetVertexAttribIuiv pglGetVertexAttribIuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribIuivEXT(UInt32 index, int pname, UInt32* @params);
			[ThreadStatic]
			internal static glGetVertexAttribIuivEXT pglGetVertexAttribIuivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribLdv(UInt32 index, int pname, double* @params);
			[ThreadStatic]
			internal static glGetVertexAttribLdv pglGetVertexAttribLdv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribLdvEXT(UInt32 index, int pname, double* @params);
			[ThreadStatic]
			internal static glGetVertexAttribLdvEXT pglGetVertexAttribLdvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribLi64vNV(UInt32 index, int pname, Int64* @params);
			[ThreadStatic]
			internal static glGetVertexAttribLi64vNV pglGetVertexAttribLi64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribLui64vARB(UInt32 index, int pname, UInt64* @params);
			[ThreadStatic]
			internal static glGetVertexAttribLui64vARB pglGetVertexAttribLui64vARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribLui64vNV(UInt32 index, int pname, UInt64* @params);
			[ThreadStatic]
			internal static glGetVertexAttribLui64vNV pglGetVertexAttribLui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribPointerv(UInt32 index, int pname, IntPtr* pointer);
			[ThreadStatic]
			internal static glGetVertexAttribPointerv pglGetVertexAttribPointerv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribPointervARB(UInt32 index, int pname, IntPtr* pointer);
			[ThreadStatic]
			internal static glGetVertexAttribPointervARB pglGetVertexAttribPointervARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribPointervNV(UInt32 index, int pname, IntPtr* pointer);
			[ThreadStatic]
			internal static glGetVertexAttribPointervNV pglGetVertexAttribPointervNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribdv(UInt32 index, int pname, double* @params);
			[ThreadStatic]
			internal static glGetVertexAttribdv pglGetVertexAttribdv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribdvARB(UInt32 index, int pname, double* @params);
			[ThreadStatic]
			internal static glGetVertexAttribdvARB pglGetVertexAttribdvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribdvNV(UInt32 index, int pname, double* @params);
			[ThreadStatic]
			internal static glGetVertexAttribdvNV pglGetVertexAttribdvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribfv(UInt32 index, int pname, float* @params);
			[ThreadStatic]
			internal static glGetVertexAttribfv pglGetVertexAttribfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribfvARB(UInt32 index, int pname, float* @params);
			[ThreadStatic]
			internal static glGetVertexAttribfvARB pglGetVertexAttribfvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribfvNV(UInt32 index, int pname, float* @params);
			[ThreadStatic]
			internal static glGetVertexAttribfvNV pglGetVertexAttribfvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribiv(UInt32 index, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetVertexAttribiv pglGetVertexAttribiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribivARB(UInt32 index, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetVertexAttribivARB pglGetVertexAttribivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribivNV(UInt32 index, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetVertexAttribivNV pglGetVertexAttribivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVideoCaptureStreamdvNV(UInt32 video_capture_slot, UInt32 stream, int pname, double* @params);
			[ThreadStatic]
			internal static glGetVideoCaptureStreamdvNV pglGetVideoCaptureStreamdvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVideoCaptureStreamfvNV(UInt32 video_capture_slot, UInt32 stream, int pname, float* @params);
			[ThreadStatic]
			internal static glGetVideoCaptureStreamfvNV pglGetVideoCaptureStreamfvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVideoCaptureStreamivNV(UInt32 video_capture_slot, UInt32 stream, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetVideoCaptureStreamivNV pglGetVideoCaptureStreamivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVideoCaptureivNV(UInt32 video_capture_slot, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetVideoCaptureivNV pglGetVideoCaptureivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVideoi64vNV(UInt32 video_slot, int pname, Int64* @params);
			[ThreadStatic]
			internal static glGetVideoi64vNV pglGetVideoi64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVideoivNV(UInt32 video_slot, int pname, Int32* @params);
			[ThreadStatic]
			internal static glGetVideoivNV pglGetVideoivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVideoui64vNV(UInt32 video_slot, int pname, UInt64* @params);
			[ThreadStatic]
			internal static glGetVideoui64vNV pglGetVideoui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVideouivNV(UInt32 video_slot, int pname, UInt32* @params);
			[ThreadStatic]
			internal static glGetVideouivNV pglGetVideouivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnColorTable(int target, int format, int type, Int32 bufSize, IntPtr table);
			[ThreadStatic]
			internal static glGetnColorTable pglGetnColorTable;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnColorTableARB(int target, int format, int type, Int32 bufSize, IntPtr table);
			[ThreadStatic]
			internal static glGetnColorTableARB pglGetnColorTableARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnCompressedTexImage(int target, Int32 lod, Int32 bufSize, IntPtr pixels);
			[ThreadStatic]
			internal static glGetnCompressedTexImage pglGetnCompressedTexImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnCompressedTexImageARB(int target, Int32 lod, Int32 bufSize, IntPtr img);
			[ThreadStatic]
			internal static glGetnCompressedTexImageARB pglGetnCompressedTexImageARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnConvolutionFilter(int target, int format, int type, Int32 bufSize, IntPtr image);
			[ThreadStatic]
			internal static glGetnConvolutionFilter pglGetnConvolutionFilter;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnConvolutionFilterARB(int target, int format, int type, Int32 bufSize, IntPtr image);
			[ThreadStatic]
			internal static glGetnConvolutionFilterARB pglGetnConvolutionFilterARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnHistogram(int target, bool reset, int format, int type, Int32 bufSize, IntPtr values);
			[ThreadStatic]
			internal static glGetnHistogram pglGetnHistogram;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnHistogramARB(int target, bool reset, int format, int type, Int32 bufSize, IntPtr values);
			[ThreadStatic]
			internal static glGetnHistogramARB pglGetnHistogramARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnMapdv(int target, int query, Int32 bufSize, double* v);
			[ThreadStatic]
			internal static glGetnMapdv pglGetnMapdv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnMapdvARB(int target, int query, Int32 bufSize, double* v);
			[ThreadStatic]
			internal static glGetnMapdvARB pglGetnMapdvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnMapfv(int target, int query, Int32 bufSize, float* v);
			[ThreadStatic]
			internal static glGetnMapfv pglGetnMapfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnMapfvARB(int target, int query, Int32 bufSize, float* v);
			[ThreadStatic]
			internal static glGetnMapfvARB pglGetnMapfvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnMapiv(int target, int query, Int32 bufSize, Int32* v);
			[ThreadStatic]
			internal static glGetnMapiv pglGetnMapiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnMapivARB(int target, int query, Int32 bufSize, Int32* v);
			[ThreadStatic]
			internal static glGetnMapivARB pglGetnMapivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnMinmax(int target, bool reset, int format, int type, Int32 bufSize, IntPtr values);
			[ThreadStatic]
			internal static glGetnMinmax pglGetnMinmax;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnMinmaxARB(int target, bool reset, int format, int type, Int32 bufSize, IntPtr values);
			[ThreadStatic]
			internal static glGetnMinmaxARB pglGetnMinmaxARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnPixelMapfv(int map, Int32 bufSize, float* values);
			[ThreadStatic]
			internal static glGetnPixelMapfv pglGetnPixelMapfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnPixelMapfvARB(int map, Int32 bufSize, float* values);
			[ThreadStatic]
			internal static glGetnPixelMapfvARB pglGetnPixelMapfvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnPixelMapuiv(int map, Int32 bufSize, UInt32* values);
			[ThreadStatic]
			internal static glGetnPixelMapuiv pglGetnPixelMapuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnPixelMapuivARB(int map, Int32 bufSize, UInt32* values);
			[ThreadStatic]
			internal static glGetnPixelMapuivARB pglGetnPixelMapuivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnPixelMapusv(int map, Int32 bufSize, UInt16* values);
			[ThreadStatic]
			internal static glGetnPixelMapusv pglGetnPixelMapusv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnPixelMapusvARB(int map, Int32 bufSize, UInt16* values);
			[ThreadStatic]
			internal static glGetnPixelMapusvARB pglGetnPixelMapusvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnPolygonStipple(Int32 bufSize, byte* pattern);
			[ThreadStatic]
			internal static glGetnPolygonStipple pglGetnPolygonStipple;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnPolygonStippleARB(Int32 bufSize, byte* pattern);
			[ThreadStatic]
			internal static glGetnPolygonStippleARB pglGetnPolygonStippleARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnSeparableFilter(int target, int format, int type, Int32 rowBufSize, IntPtr row, Int32 columnBufSize, IntPtr column, IntPtr span);
			[ThreadStatic]
			internal static glGetnSeparableFilter pglGetnSeparableFilter;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnSeparableFilterARB(int target, int format, int type, Int32 rowBufSize, IntPtr row, Int32 columnBufSize, IntPtr column, IntPtr span);
			[ThreadStatic]
			internal static glGetnSeparableFilterARB pglGetnSeparableFilterARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnTexImage(int target, Int32 level, int format, int type, Int32 bufSize, IntPtr pixels);
			[ThreadStatic]
			internal static glGetnTexImage pglGetnTexImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnTexImageARB(int target, Int32 level, int format, int type, Int32 bufSize, IntPtr img);
			[ThreadStatic]
			internal static glGetnTexImageARB pglGetnTexImageARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnUniformdv(UInt32 program, Int32 location, Int32 bufSize, double* @params);
			[ThreadStatic]
			internal static glGetnUniformdv pglGetnUniformdv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnUniformdvARB(UInt32 program, Int32 location, Int32 bufSize, double* @params);
			[ThreadStatic]
			internal static glGetnUniformdvARB pglGetnUniformdvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnUniformfv(UInt32 program, Int32 location, Int32 bufSize, float* @params);
			[ThreadStatic]
			internal static glGetnUniformfv pglGetnUniformfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnUniformfvARB(UInt32 program, Int32 location, Int32 bufSize, float* @params);
			[ThreadStatic]
			internal static glGetnUniformfvARB pglGetnUniformfvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnUniformiv(UInt32 program, Int32 location, Int32 bufSize, Int32* @params);
			[ThreadStatic]
			internal static glGetnUniformiv pglGetnUniformiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnUniformivARB(UInt32 program, Int32 location, Int32 bufSize, Int32* @params);
			[ThreadStatic]
			internal static glGetnUniformivARB pglGetnUniformivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnUniformuiv(UInt32 program, Int32 location, Int32 bufSize, UInt32* @params);
			[ThreadStatic]
			internal static glGetnUniformuiv pglGetnUniformuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnUniformuivARB(UInt32 program, Int32 location, Int32 bufSize, UInt32* @params);
			[ThreadStatic]
			internal static glGetnUniformuivARB pglGetnUniformuivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGlobalAlphaFactorbSUN(sbyte factor);
			[ThreadStatic]
			internal static glGlobalAlphaFactorbSUN pglGlobalAlphaFactorbSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGlobalAlphaFactordSUN(double factor);
			[ThreadStatic]
			internal static glGlobalAlphaFactordSUN pglGlobalAlphaFactordSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGlobalAlphaFactorfSUN(float factor);
			[ThreadStatic]
			internal static glGlobalAlphaFactorfSUN pglGlobalAlphaFactorfSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGlobalAlphaFactoriSUN(Int32 factor);
			[ThreadStatic]
			internal static glGlobalAlphaFactoriSUN pglGlobalAlphaFactoriSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGlobalAlphaFactorsSUN(Int16 factor);
			[ThreadStatic]
			internal static glGlobalAlphaFactorsSUN pglGlobalAlphaFactorsSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGlobalAlphaFactorubSUN(byte factor);
			[ThreadStatic]
			internal static glGlobalAlphaFactorubSUN pglGlobalAlphaFactorubSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGlobalAlphaFactoruiSUN(UInt32 factor);
			[ThreadStatic]
			internal static glGlobalAlphaFactoruiSUN pglGlobalAlphaFactoruiSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glGlobalAlphaFactorusSUN(UInt16 factor);
			[ThreadStatic]
			internal static glGlobalAlphaFactorusSUN pglGlobalAlphaFactorusSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glHint(int target, int mode);
			[ThreadStatic]
			internal static glHint pglHint;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glHintPGI(int target, Int32 mode);
			[ThreadStatic]
			internal static glHintPGI pglHintPGI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glHistogram(int target, Int32 width, int internalformat, bool sink);
			[ThreadStatic]
			internal static glHistogram pglHistogram;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glHistogramEXT(int target, Int32 width, int internalformat, bool sink);
			[ThreadStatic]
			internal static glHistogramEXT pglHistogramEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glIglooInterfaceSGIX(int pname, IntPtr @params);
			[ThreadStatic]
			internal static glIglooInterfaceSGIX pglIglooInterfaceSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glImageTransformParameterfHP(int target, int pname, float param);
			[ThreadStatic]
			internal static glImageTransformParameterfHP pglImageTransformParameterfHP;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glImageTransformParameterfvHP(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glImageTransformParameterfvHP pglImageTransformParameterfvHP;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glImageTransformParameteriHP(int target, int pname, Int32 param);
			[ThreadStatic]
			internal static glImageTransformParameteriHP pglImageTransformParameteriHP;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glImageTransformParameterivHP(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glImageTransformParameterivHP pglImageTransformParameterivHP;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glImportSyncEXT(int external_sync_type, IntPtr external_sync, uint flags);
			[ThreadStatic]
			internal static glImportSyncEXT pglImportSyncEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glIndexFormatNV(int type, Int32 stride);
			[ThreadStatic]
			internal static glIndexFormatNV pglIndexFormatNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glIndexFuncEXT(int func, float @ref);
			[ThreadStatic]
			internal static glIndexFuncEXT pglIndexFuncEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glIndexMask(UInt32 mask);
			[ThreadStatic]
			internal static glIndexMask pglIndexMask;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glIndexMaterialEXT(int face, int mode);
			[ThreadStatic]
			internal static glIndexMaterialEXT pglIndexMaterialEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glIndexPointer(int type, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glIndexPointer pglIndexPointer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glIndexPointerEXT(int type, Int32 stride, Int32 count, IntPtr pointer);
			[ThreadStatic]
			internal static glIndexPointerEXT pglIndexPointerEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glIndexPointerListIBM(int type, Int32 stride, IntPtr* pointer, Int32 ptrstride);
			[ThreadStatic]
			internal static glIndexPointerListIBM pglIndexPointerListIBM;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glIndexd(double c);
			[ThreadStatic]
			internal static glIndexd pglIndexd;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glIndexdv(double* c);
			[ThreadStatic]
			internal static glIndexdv pglIndexdv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glIndexf(float c);
			[ThreadStatic]
			internal static glIndexf pglIndexf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glIndexfv(float* c);
			[ThreadStatic]
			internal static glIndexfv pglIndexfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glIndexi(Int32 c);
			[ThreadStatic]
			internal static glIndexi pglIndexi;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glIndexiv(Int32* c);
			[ThreadStatic]
			internal static glIndexiv pglIndexiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glIndexs(Int16 c);
			[ThreadStatic]
			internal static glIndexs pglIndexs;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glIndexsv(Int16* c);
			[ThreadStatic]
			internal static glIndexsv pglIndexsv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glIndexub(byte c);
			[ThreadStatic]
			internal static glIndexub pglIndexub;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glIndexubv(byte* c);
			[ThreadStatic]
			internal static glIndexubv pglIndexubv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glIndexxOES(IntPtr component);
			[ThreadStatic]
			internal static glIndexxOES pglIndexxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glIndexxvOES(IntPtr* component);
			[ThreadStatic]
			internal static glIndexxvOES pglIndexxvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glInitNames();
			[ThreadStatic]
			internal static glInitNames pglInitNames;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glInsertComponentEXT(UInt32 res, UInt32 src, UInt32 num);
			[ThreadStatic]
			internal static glInsertComponentEXT pglInsertComponentEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glInsertEventMarkerEXT(Int32 length, String marker);
			[ThreadStatic]
			internal static glInsertEventMarkerEXT pglInsertEventMarkerEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glInstrumentsBufferSGIX(Int32 size, Int32* buffer);
			[ThreadStatic]
			internal static glInstrumentsBufferSGIX pglInstrumentsBufferSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glInterleavedArrays(int format, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glInterleavedArrays pglInterleavedArrays;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glInterpolatePathsNV(UInt32 resultPath, UInt32 pathA, UInt32 pathB, float weight);
			[ThreadStatic]
			internal static glInterpolatePathsNV pglInterpolatePathsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glInvalidateBufferData(UInt32 buffer);
			[ThreadStatic]
			internal static glInvalidateBufferData pglInvalidateBufferData;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glInvalidateBufferSubData(UInt32 buffer, IntPtr offset, UInt32 length);
			[ThreadStatic]
			internal static glInvalidateBufferSubData pglInvalidateBufferSubData;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glInvalidateFramebuffer(int target, Int32 numAttachments, int* attachments);
			[ThreadStatic]
			internal static glInvalidateFramebuffer pglInvalidateFramebuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glInvalidateNamedFramebufferData(UInt32 framebuffer, Int32 numAttachments, int* attachments);
			[ThreadStatic]
			internal static glInvalidateNamedFramebufferData pglInvalidateNamedFramebufferData;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glInvalidateNamedFramebufferSubData(UInt32 framebuffer, Int32 numAttachments, int* attachments, Int32 x, Int32 y, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glInvalidateNamedFramebufferSubData pglInvalidateNamedFramebufferSubData;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glInvalidateSubFramebuffer(int target, Int32 numAttachments, int* attachments, Int32 x, Int32 y, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glInvalidateSubFramebuffer pglInvalidateSubFramebuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glInvalidateTexImage(UInt32 texture, Int32 level);
			[ThreadStatic]
			internal static glInvalidateTexImage pglInvalidateTexImage;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glInvalidateTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth);
			[ThreadStatic]
			internal static glInvalidateTexSubImage pglInvalidateTexSubImage;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsAsyncMarkerSGIX(UInt32 marker);
			[ThreadStatic]
			internal static glIsAsyncMarkerSGIX pglIsAsyncMarkerSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsBuffer(UInt32 buffer);
			[ThreadStatic]
			internal static glIsBuffer pglIsBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsBufferARB(UInt32 buffer);
			[ThreadStatic]
			internal static glIsBufferARB pglIsBufferARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsBufferResidentNV(int target);
			[ThreadStatic]
			internal static glIsBufferResidentNV pglIsBufferResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsEnabled(int cap);
			[ThreadStatic]
			internal static glIsEnabled pglIsEnabled;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsEnabledIndexedEXT(int target, UInt32 index);
			[ThreadStatic]
			internal static glIsEnabledIndexedEXT pglIsEnabledIndexedEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsEnabledi(int target, UInt32 index);
			[ThreadStatic]
			internal static glIsEnabledi pglIsEnabledi;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsFenceAPPLE(UInt32 fence);
			[ThreadStatic]
			internal static glIsFenceAPPLE pglIsFenceAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsFenceNV(UInt32 fence);
			[ThreadStatic]
			internal static glIsFenceNV pglIsFenceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsFramebuffer(UInt32 framebuffer);
			[ThreadStatic]
			internal static glIsFramebuffer pglIsFramebuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsFramebufferEXT(UInt32 framebuffer);
			[ThreadStatic]
			internal static glIsFramebufferEXT pglIsFramebufferEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsImageHandleResidentARB(UInt64 handle);
			[ThreadStatic]
			internal static glIsImageHandleResidentARB pglIsImageHandleResidentARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsImageHandleResidentNV(UInt64 handle);
			[ThreadStatic]
			internal static glIsImageHandleResidentNV pglIsImageHandleResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsList(UInt32 list);
			[ThreadStatic]
			internal static glIsList pglIsList;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsNameAMD(int identifier, UInt32 name);
			[ThreadStatic]
			internal static glIsNameAMD pglIsNameAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsNamedBufferResidentNV(UInt32 buffer);
			[ThreadStatic]
			internal static glIsNamedBufferResidentNV pglIsNamedBufferResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsNamedStringARB(Int32 namelen, String name);
			[ThreadStatic]
			internal static glIsNamedStringARB pglIsNamedStringARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsObjectBufferATI(UInt32 buffer);
			[ThreadStatic]
			internal static glIsObjectBufferATI pglIsObjectBufferATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsOcclusionQueryNV(UInt32 id);
			[ThreadStatic]
			internal static glIsOcclusionQueryNV pglIsOcclusionQueryNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsPathNV(UInt32 path);
			[ThreadStatic]
			internal static glIsPathNV pglIsPathNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsPointInFillPathNV(UInt32 path, UInt32 mask, float x, float y);
			[ThreadStatic]
			internal static glIsPointInFillPathNV pglIsPointInFillPathNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsPointInStrokePathNV(UInt32 path, float x, float y);
			[ThreadStatic]
			internal static glIsPointInStrokePathNV pglIsPointInStrokePathNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsProgram(UInt32 program);
			[ThreadStatic]
			internal static glIsProgram pglIsProgram;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsProgramARB(UInt32 program);
			[ThreadStatic]
			internal static glIsProgramARB pglIsProgramARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsProgramNV(UInt32 id);
			[ThreadStatic]
			internal static glIsProgramNV pglIsProgramNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsProgramPipeline(UInt32 pipeline);
			[ThreadStatic]
			internal static glIsProgramPipeline pglIsProgramPipeline;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsQuery(UInt32 id);
			[ThreadStatic]
			internal static glIsQuery pglIsQuery;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsQueryARB(UInt32 id);
			[ThreadStatic]
			internal static glIsQueryARB pglIsQueryARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsRenderbuffer(UInt32 renderbuffer);
			[ThreadStatic]
			internal static glIsRenderbuffer pglIsRenderbuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsRenderbufferEXT(UInt32 renderbuffer);
			[ThreadStatic]
			internal static glIsRenderbufferEXT pglIsRenderbufferEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsSampler(UInt32 sampler);
			[ThreadStatic]
			internal static glIsSampler pglIsSampler;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsShader(UInt32 shader);
			[ThreadStatic]
			internal static glIsShader pglIsShader;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsSync(int sync);
			[ThreadStatic]
			internal static glIsSync pglIsSync;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsTexture(UInt32 texture);
			[ThreadStatic]
			internal static glIsTexture pglIsTexture;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsTextureEXT(UInt32 texture);
			[ThreadStatic]
			internal static glIsTextureEXT pglIsTextureEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsTextureHandleResidentARB(UInt64 handle);
			[ThreadStatic]
			internal static glIsTextureHandleResidentARB pglIsTextureHandleResidentARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsTextureHandleResidentNV(UInt64 handle);
			[ThreadStatic]
			internal static glIsTextureHandleResidentNV pglIsTextureHandleResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsTransformFeedback(UInt32 id);
			[ThreadStatic]
			internal static glIsTransformFeedback pglIsTransformFeedback;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsTransformFeedbackNV(UInt32 id);
			[ThreadStatic]
			internal static glIsTransformFeedbackNV pglIsTransformFeedbackNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsVariantEnabledEXT(UInt32 id, int cap);
			[ThreadStatic]
			internal static glIsVariantEnabledEXT pglIsVariantEnabledEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsVertexArray(UInt32 array);
			[ThreadStatic]
			internal static glIsVertexArray pglIsVertexArray;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsVertexArrayAPPLE(UInt32 array);
			[ThreadStatic]
			internal static glIsVertexArrayAPPLE pglIsVertexArrayAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsVertexAttribEnabledAPPLE(UInt32 index, int pname);
			[ThreadStatic]
			internal static glIsVertexAttribEnabledAPPLE pglIsVertexAttribEnabledAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLabelObjectEXT(int type, UInt32 @object, Int32 length, String label);
			[ThreadStatic]
			internal static glLabelObjectEXT pglLabelObjectEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLightEnviSGIX(int pname, Int32 param);
			[ThreadStatic]
			internal static glLightEnviSGIX pglLightEnviSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLightModelf(int pname, float param);
			[ThreadStatic]
			internal static glLightModelf pglLightModelf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightModelfv(int pname, float* @params);
			[ThreadStatic]
			internal static glLightModelfv pglLightModelfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLightModeli(int pname, Int32 param);
			[ThreadStatic]
			internal static glLightModeli pglLightModeli;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightModeliv(int pname, Int32* @params);
			[ThreadStatic]
			internal static glLightModeliv pglLightModeliv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightModelxOES(int pname, IntPtr param);
			[ThreadStatic]
			internal static glLightModelxOES pglLightModelxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightModelxvOES(int pname, IntPtr* param);
			[ThreadStatic]
			internal static glLightModelxvOES pglLightModelxvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLightf(int light, int pname, float param);
			[ThreadStatic]
			internal static glLightf pglLightf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightfv(int light, int pname, float* @params);
			[ThreadStatic]
			internal static glLightfv pglLightfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLighti(int light, int pname, Int32 param);
			[ThreadStatic]
			internal static glLighti pglLighti;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightiv(int light, int pname, Int32* @params);
			[ThreadStatic]
			internal static glLightiv pglLightiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightxOES(int light, int pname, IntPtr param);
			[ThreadStatic]
			internal static glLightxOES pglLightxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightxvOES(int light, int pname, IntPtr* @params);
			[ThreadStatic]
			internal static glLightxvOES pglLightxvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLineStipple(Int32 factor, UInt16 pattern);
			[ThreadStatic]
			internal static glLineStipple pglLineStipple;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLineWidth(float width);
			[ThreadStatic]
			internal static glLineWidth pglLineWidth;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLineWidthxOES(IntPtr width);
			[ThreadStatic]
			internal static glLineWidthxOES pglLineWidthxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLinkProgram(UInt32 program);
			[ThreadStatic]
			internal static glLinkProgram pglLinkProgram;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLinkProgramARB(UInt32 programObj);
			[ThreadStatic]
			internal static glLinkProgramARB pglLinkProgramARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glListBase(UInt32 @base);
			[ThreadStatic]
			internal static glListBase pglListBase;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glListParameterfSGIX(UInt32 list, int pname, float param);
			[ThreadStatic]
			internal static glListParameterfSGIX pglListParameterfSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glListParameterfvSGIX(UInt32 list, int pname, float* @params);
			[ThreadStatic]
			internal static glListParameterfvSGIX pglListParameterfvSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glListParameteriSGIX(UInt32 list, int pname, Int32 param);
			[ThreadStatic]
			internal static glListParameteriSGIX pglListParameteriSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glListParameterivSGIX(UInt32 list, int pname, Int32* @params);
			[ThreadStatic]
			internal static glListParameterivSGIX pglListParameterivSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLoadIdentity();
			[ThreadStatic]
			internal static glLoadIdentity pglLoadIdentity;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLoadIdentityDeformationMapSGIX(uint mask);
			[ThreadStatic]
			internal static glLoadIdentityDeformationMapSGIX pglLoadIdentityDeformationMapSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLoadMatrixd(double* m);
			[ThreadStatic]
			internal static glLoadMatrixd pglLoadMatrixd;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLoadMatrixf(float* m);
			[ThreadStatic]
			internal static glLoadMatrixf pglLoadMatrixf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLoadMatrixxOES(IntPtr* m);
			[ThreadStatic]
			internal static glLoadMatrixxOES pglLoadMatrixxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLoadName(UInt32 name);
			[ThreadStatic]
			internal static glLoadName pglLoadName;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLoadProgramNV(int target, UInt32 id, Int32 len, byte* program);
			[ThreadStatic]
			internal static glLoadProgramNV pglLoadProgramNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLoadTransposeMatrixd(double* m);
			[ThreadStatic]
			internal static glLoadTransposeMatrixd pglLoadTransposeMatrixd;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLoadTransposeMatrixdARB(double* m);
			[ThreadStatic]
			internal static glLoadTransposeMatrixdARB pglLoadTransposeMatrixdARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLoadTransposeMatrixf(float* m);
			[ThreadStatic]
			internal static glLoadTransposeMatrixf pglLoadTransposeMatrixf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLoadTransposeMatrixfARB(float* m);
			[ThreadStatic]
			internal static glLoadTransposeMatrixfARB pglLoadTransposeMatrixfARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLoadTransposeMatrixxOES(IntPtr* m);
			[ThreadStatic]
			internal static glLoadTransposeMatrixxOES pglLoadTransposeMatrixxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLockArraysEXT(Int32 first, Int32 count);
			[ThreadStatic]
			internal static glLockArraysEXT pglLockArraysEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLogicOp(int opcode);
			[ThreadStatic]
			internal static glLogicOp pglLogicOp;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeBufferNonResidentNV(int target);
			[ThreadStatic]
			internal static glMakeBufferNonResidentNV pglMakeBufferNonResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeBufferResidentNV(int target, int access);
			[ThreadStatic]
			internal static glMakeBufferResidentNV pglMakeBufferResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeImageHandleNonResidentARB(UInt64 handle);
			[ThreadStatic]
			internal static glMakeImageHandleNonResidentARB pglMakeImageHandleNonResidentARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeImageHandleNonResidentNV(UInt64 handle);
			[ThreadStatic]
			internal static glMakeImageHandleNonResidentNV pglMakeImageHandleNonResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeImageHandleResidentARB(UInt64 handle, int access);
			[ThreadStatic]
			internal static glMakeImageHandleResidentARB pglMakeImageHandleResidentARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeImageHandleResidentNV(UInt64 handle, int access);
			[ThreadStatic]
			internal static glMakeImageHandleResidentNV pglMakeImageHandleResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeNamedBufferNonResidentNV(UInt32 buffer);
			[ThreadStatic]
			internal static glMakeNamedBufferNonResidentNV pglMakeNamedBufferNonResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeNamedBufferResidentNV(UInt32 buffer, int access);
			[ThreadStatic]
			internal static glMakeNamedBufferResidentNV pglMakeNamedBufferResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeTextureHandleNonResidentARB(UInt64 handle);
			[ThreadStatic]
			internal static glMakeTextureHandleNonResidentARB pglMakeTextureHandleNonResidentARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeTextureHandleNonResidentNV(UInt64 handle);
			[ThreadStatic]
			internal static glMakeTextureHandleNonResidentNV pglMakeTextureHandleNonResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeTextureHandleResidentARB(UInt64 handle);
			[ThreadStatic]
			internal static glMakeTextureHandleResidentARB pglMakeTextureHandleResidentARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeTextureHandleResidentNV(UInt64 handle);
			[ThreadStatic]
			internal static glMakeTextureHandleResidentNV pglMakeTextureHandleResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMap1d(int target, double u1, double u2, Int32 stride, Int32 order, double* points);
			[ThreadStatic]
			internal static glMap1d pglMap1d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMap1f(int target, float u1, float u2, Int32 stride, Int32 order, float* points);
			[ThreadStatic]
			internal static glMap1f pglMap1f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMap1xOES(int target, IntPtr u1, IntPtr u2, Int32 stride, Int32 order, IntPtr points);
			[ThreadStatic]
			internal static glMap1xOES pglMap1xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMap2d(int target, double u1, double u2, Int32 ustride, Int32 uorder, double v1, double v2, Int32 vstride, Int32 vorder, double* points);
			[ThreadStatic]
			internal static glMap2d pglMap2d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMap2f(int target, float u1, float u2, Int32 ustride, Int32 uorder, float v1, float v2, Int32 vstride, Int32 vorder, float* points);
			[ThreadStatic]
			internal static glMap2f pglMap2f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMap2xOES(int target, IntPtr u1, IntPtr u2, Int32 ustride, Int32 uorder, IntPtr v1, IntPtr v2, Int32 vstride, Int32 vorder, IntPtr points);
			[ThreadStatic]
			internal static glMap2xOES pglMap2xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glMapBuffer(int target, int access);
			[ThreadStatic]
			internal static glMapBuffer pglMapBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glMapBufferARB(int target, int access);
			[ThreadStatic]
			internal static glMapBufferARB pglMapBufferARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glMapBufferRange(int target, IntPtr offset, UInt32 length, uint access);
			[ThreadStatic]
			internal static glMapBufferRange pglMapBufferRange;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMapControlPointsNV(int target, UInt32 index, int type, Int32 ustride, Int32 vstride, Int32 uorder, Int32 vorder, bool packed, IntPtr points);
			[ThreadStatic]
			internal static glMapControlPointsNV pglMapControlPointsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMapGrid1d(Int32 un, double u1, double u2);
			[ThreadStatic]
			internal static glMapGrid1d pglMapGrid1d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMapGrid1f(Int32 un, float u1, float u2);
			[ThreadStatic]
			internal static glMapGrid1f pglMapGrid1f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMapGrid1xOES(Int32 n, IntPtr u1, IntPtr u2);
			[ThreadStatic]
			internal static glMapGrid1xOES pglMapGrid1xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMapGrid2d(Int32 un, double u1, double u2, Int32 vn, double v1, double v2);
			[ThreadStatic]
			internal static glMapGrid2d pglMapGrid2d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMapGrid2f(Int32 un, float u1, float u2, Int32 vn, float v1, float v2);
			[ThreadStatic]
			internal static glMapGrid2f pglMapGrid2f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMapGrid2xOES(Int32 n, IntPtr u1, IntPtr u2, IntPtr v1, IntPtr v2);
			[ThreadStatic]
			internal static glMapGrid2xOES pglMapGrid2xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glMapNamedBuffer(UInt32 buffer, int access);
			[ThreadStatic]
			internal static glMapNamedBuffer pglMapNamedBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glMapNamedBufferEXT(UInt32 buffer, int access);
			[ThreadStatic]
			internal static glMapNamedBufferEXT pglMapNamedBufferEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glMapNamedBufferRange(UInt32 buffer, IntPtr offset, UInt32 length, uint access);
			[ThreadStatic]
			internal static glMapNamedBufferRange pglMapNamedBufferRange;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glMapNamedBufferRangeEXT(UInt32 buffer, IntPtr offset, UInt32 length, uint access);
			[ThreadStatic]
			internal static glMapNamedBufferRangeEXT pglMapNamedBufferRangeEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glMapObjectBufferATI(UInt32 buffer);
			[ThreadStatic]
			internal static glMapObjectBufferATI pglMapObjectBufferATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMapParameterfvNV(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glMapParameterfvNV pglMapParameterfvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMapParameterivNV(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glMapParameterivNV pglMapParameterivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glMapTexture2DINTEL(UInt32 texture, Int32 level, uint access, Int32* stride, int* layout);
			[ThreadStatic]
			internal static glMapTexture2DINTEL pglMapTexture2DINTEL;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMapVertexAttrib1dAPPLE(UInt32 index, UInt32 size, double u1, double u2, Int32 stride, Int32 order, double* points);
			[ThreadStatic]
			internal static glMapVertexAttrib1dAPPLE pglMapVertexAttrib1dAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMapVertexAttrib1fAPPLE(UInt32 index, UInt32 size, float u1, float u2, Int32 stride, Int32 order, float* points);
			[ThreadStatic]
			internal static glMapVertexAttrib1fAPPLE pglMapVertexAttrib1fAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMapVertexAttrib2dAPPLE(UInt32 index, UInt32 size, double u1, double u2, Int32 ustride, Int32 uorder, double v1, double v2, Int32 vstride, Int32 vorder, double* points);
			[ThreadStatic]
			internal static glMapVertexAttrib2dAPPLE pglMapVertexAttrib2dAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMapVertexAttrib2fAPPLE(UInt32 index, UInt32 size, float u1, float u2, Int32 ustride, Int32 uorder, float v1, float v2, Int32 vstride, Int32 vorder, float* points);
			[ThreadStatic]
			internal static glMapVertexAttrib2fAPPLE pglMapVertexAttrib2fAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMaterialf(int face, int pname, float param);
			[ThreadStatic]
			internal static glMaterialf pglMaterialf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMaterialfv(int face, int pname, float* @params);
			[ThreadStatic]
			internal static glMaterialfv pglMaterialfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMateriali(int face, int pname, Int32 param);
			[ThreadStatic]
			internal static glMateriali pglMateriali;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMaterialiv(int face, int pname, Int32* @params);
			[ThreadStatic]
			internal static glMaterialiv pglMaterialiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMaterialxOES(int face, int pname, IntPtr param);
			[ThreadStatic]
			internal static glMaterialxOES pglMaterialxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMaterialxvOES(int face, int pname, IntPtr* param);
			[ThreadStatic]
			internal static glMaterialxvOES pglMaterialxvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixFrustumEXT(int mode, double left, double right, double bottom, double top, double zNear, double zFar);
			[ThreadStatic]
			internal static glMatrixFrustumEXT pglMatrixFrustumEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixIndexPointerARB(Int32 size, int type, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glMatrixIndexPointerARB pglMatrixIndexPointerARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixIndexubvARB(Int32 size, byte* indices);
			[ThreadStatic]
			internal static glMatrixIndexubvARB pglMatrixIndexubvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixIndexuivARB(Int32 size, UInt32* indices);
			[ThreadStatic]
			internal static glMatrixIndexuivARB pglMatrixIndexuivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixIndexusvARB(Int32 size, UInt16* indices);
			[ThreadStatic]
			internal static glMatrixIndexusvARB pglMatrixIndexusvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixLoad3x2fNV(int matrixMode, float* m);
			[ThreadStatic]
			internal static glMatrixLoad3x2fNV pglMatrixLoad3x2fNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixLoad3x3fNV(int matrixMode, float* m);
			[ThreadStatic]
			internal static glMatrixLoad3x3fNV pglMatrixLoad3x3fNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixLoadIdentityEXT(int mode);
			[ThreadStatic]
			internal static glMatrixLoadIdentityEXT pglMatrixLoadIdentityEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixLoadTranspose3x3fNV(int matrixMode, float* m);
			[ThreadStatic]
			internal static glMatrixLoadTranspose3x3fNV pglMatrixLoadTranspose3x3fNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixLoadTransposedEXT(int mode, double* m);
			[ThreadStatic]
			internal static glMatrixLoadTransposedEXT pglMatrixLoadTransposedEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixLoadTransposefEXT(int mode, float* m);
			[ThreadStatic]
			internal static glMatrixLoadTransposefEXT pglMatrixLoadTransposefEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixLoaddEXT(int mode, double* m);
			[ThreadStatic]
			internal static glMatrixLoaddEXT pglMatrixLoaddEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixLoadfEXT(int mode, float* m);
			[ThreadStatic]
			internal static glMatrixLoadfEXT pglMatrixLoadfEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixMode(int mode);
			[ThreadStatic]
			internal static glMatrixMode pglMatrixMode;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixMult3x2fNV(int matrixMode, float* m);
			[ThreadStatic]
			internal static glMatrixMult3x2fNV pglMatrixMult3x2fNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixMult3x3fNV(int matrixMode, float* m);
			[ThreadStatic]
			internal static glMatrixMult3x3fNV pglMatrixMult3x3fNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixMultTranspose3x3fNV(int matrixMode, float* m);
			[ThreadStatic]
			internal static glMatrixMultTranspose3x3fNV pglMatrixMultTranspose3x3fNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixMultTransposedEXT(int mode, double* m);
			[ThreadStatic]
			internal static glMatrixMultTransposedEXT pglMatrixMultTransposedEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixMultTransposefEXT(int mode, float* m);
			[ThreadStatic]
			internal static glMatrixMultTransposefEXT pglMatrixMultTransposefEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixMultdEXT(int mode, double* m);
			[ThreadStatic]
			internal static glMatrixMultdEXT pglMatrixMultdEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixMultfEXT(int mode, float* m);
			[ThreadStatic]
			internal static glMatrixMultfEXT pglMatrixMultfEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixOrthoEXT(int mode, double left, double right, double bottom, double top, double zNear, double zFar);
			[ThreadStatic]
			internal static glMatrixOrthoEXT pglMatrixOrthoEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixPopEXT(int mode);
			[ThreadStatic]
			internal static glMatrixPopEXT pglMatrixPopEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixPushEXT(int mode);
			[ThreadStatic]
			internal static glMatrixPushEXT pglMatrixPushEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixRotatedEXT(int mode, double angle, double x, double y, double z);
			[ThreadStatic]
			internal static glMatrixRotatedEXT pglMatrixRotatedEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixRotatefEXT(int mode, float angle, float x, float y, float z);
			[ThreadStatic]
			internal static glMatrixRotatefEXT pglMatrixRotatefEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixScaledEXT(int mode, double x, double y, double z);
			[ThreadStatic]
			internal static glMatrixScaledEXT pglMatrixScaledEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixScalefEXT(int mode, float x, float y, float z);
			[ThreadStatic]
			internal static glMatrixScalefEXT pglMatrixScalefEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixTranslatedEXT(int mode, double x, double y, double z);
			[ThreadStatic]
			internal static glMatrixTranslatedEXT pglMatrixTranslatedEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixTranslatefEXT(int mode, float x, float y, float z);
			[ThreadStatic]
			internal static glMatrixTranslatefEXT pglMatrixTranslatefEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMemoryBarrier(uint barriers);
			[ThreadStatic]
			internal static glMemoryBarrier pglMemoryBarrier;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMemoryBarrierByRegion(uint barriers);
			[ThreadStatic]
			internal static glMemoryBarrierByRegion pglMemoryBarrierByRegion;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMemoryBarrierEXT(uint barriers);
			[ThreadStatic]
			internal static glMemoryBarrierEXT pglMemoryBarrierEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMinSampleShading(float value);
			[ThreadStatic]
			internal static glMinSampleShading pglMinSampleShading;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMinSampleShadingARB(float value);
			[ThreadStatic]
			internal static glMinSampleShadingARB pglMinSampleShadingARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMinmax(int target, int internalformat, bool sink);
			[ThreadStatic]
			internal static glMinmax pglMinmax;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMinmaxEXT(int target, int internalformat, bool sink);
			[ThreadStatic]
			internal static glMinmaxEXT pglMinmaxEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultMatrixd(double* m);
			[ThreadStatic]
			internal static glMultMatrixd pglMultMatrixd;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultMatrixf(float* m);
			[ThreadStatic]
			internal static glMultMatrixf pglMultMatrixf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultMatrixxOES(IntPtr* m);
			[ThreadStatic]
			internal static glMultMatrixxOES pglMultMatrixxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultTransposeMatrixd(double* m);
			[ThreadStatic]
			internal static glMultTransposeMatrixd pglMultTransposeMatrixd;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultTransposeMatrixdARB(double* m);
			[ThreadStatic]
			internal static glMultTransposeMatrixdARB pglMultTransposeMatrixdARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultTransposeMatrixf(float* m);
			[ThreadStatic]
			internal static glMultTransposeMatrixf pglMultTransposeMatrixf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultTransposeMatrixfARB(float* m);
			[ThreadStatic]
			internal static glMultTransposeMatrixfARB pglMultTransposeMatrixfARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultTransposeMatrixxOES(IntPtr* m);
			[ThreadStatic]
			internal static glMultTransposeMatrixxOES pglMultTransposeMatrixxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiDrawArrays(int mode, Int32* first, Int32* count, Int32 drawcount);
			[ThreadStatic]
			internal static glMultiDrawArrays pglMultiDrawArrays;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiDrawArraysEXT(int mode, Int32* first, Int32* count, Int32 primcount);
			[ThreadStatic]
			internal static glMultiDrawArraysEXT pglMultiDrawArraysEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiDrawArraysIndirect(int mode, IntPtr indirect, Int32 drawcount, Int32 stride);
			[ThreadStatic]
			internal static glMultiDrawArraysIndirect pglMultiDrawArraysIndirect;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiDrawArraysIndirectAMD(int mode, IntPtr indirect, Int32 primcount, Int32 stride);
			[ThreadStatic]
			internal static glMultiDrawArraysIndirectAMD pglMultiDrawArraysIndirectAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiDrawArraysIndirectBindlessCountNV(int mode, IntPtr indirect, Int32 drawCount, Int32 maxDrawCount, Int32 stride, Int32 vertexBufferCount);
			[ThreadStatic]
			internal static glMultiDrawArraysIndirectBindlessCountNV pglMultiDrawArraysIndirectBindlessCountNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiDrawArraysIndirectBindlessNV(int mode, IntPtr indirect, Int32 drawCount, Int32 stride, Int32 vertexBufferCount);
			[ThreadStatic]
			internal static glMultiDrawArraysIndirectBindlessNV pglMultiDrawArraysIndirectBindlessNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiDrawArraysIndirectCountARB(int mode, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride);
			[ThreadStatic]
			internal static glMultiDrawArraysIndirectCountARB pglMultiDrawArraysIndirectCountARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiDrawElementArrayAPPLE(int mode, Int32* first, Int32* count, Int32 primcount);
			[ThreadStatic]
			internal static glMultiDrawElementArrayAPPLE pglMultiDrawElementArrayAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiDrawElements(int mode, Int32* count, int type, IntPtr* indices, Int32 drawcount);
			[ThreadStatic]
			internal static glMultiDrawElements pglMultiDrawElements;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiDrawElementsBaseVertex(int mode, Int32* count, int type, IntPtr* indices, Int32 drawcount, Int32* basevertex);
			[ThreadStatic]
			internal static glMultiDrawElementsBaseVertex pglMultiDrawElementsBaseVertex;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiDrawElementsEXT(int mode, Int32* count, int type, IntPtr* indices, Int32 primcount);
			[ThreadStatic]
			internal static glMultiDrawElementsEXT pglMultiDrawElementsEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiDrawElementsIndirect(int mode, int type, IntPtr indirect, Int32 drawcount, Int32 stride);
			[ThreadStatic]
			internal static glMultiDrawElementsIndirect pglMultiDrawElementsIndirect;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiDrawElementsIndirectAMD(int mode, int type, IntPtr indirect, Int32 primcount, Int32 stride);
			[ThreadStatic]
			internal static glMultiDrawElementsIndirectAMD pglMultiDrawElementsIndirectAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiDrawElementsIndirectBindlessCountNV(int mode, int type, IntPtr indirect, Int32 drawCount, Int32 maxDrawCount, Int32 stride, Int32 vertexBufferCount);
			[ThreadStatic]
			internal static glMultiDrawElementsIndirectBindlessCountNV pglMultiDrawElementsIndirectBindlessCountNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiDrawElementsIndirectBindlessNV(int mode, int type, IntPtr indirect, Int32 drawCount, Int32 stride, Int32 vertexBufferCount);
			[ThreadStatic]
			internal static glMultiDrawElementsIndirectBindlessNV pglMultiDrawElementsIndirectBindlessNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiDrawElementsIndirectCountARB(int mode, int type, IntPtr indirect, IntPtr drawcount, Int32 maxdrawcount, Int32 stride);
			[ThreadStatic]
			internal static glMultiDrawElementsIndirectCountARB pglMultiDrawElementsIndirectCountARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiDrawRangeElementArrayAPPLE(int mode, UInt32 start, UInt32 end, Int32* first, Int32* count, Int32 primcount);
			[ThreadStatic]
			internal static glMultiDrawRangeElementArrayAPPLE pglMultiDrawRangeElementArrayAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiModeDrawArraysIBM(int* mode, Int32* first, Int32* count, Int32 primcount, Int32 modestride);
			[ThreadStatic]
			internal static glMultiModeDrawArraysIBM pglMultiModeDrawArraysIBM;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiModeDrawElementsIBM(int* mode, Int32* count, int type, IntPtr* indices, Int32 primcount, Int32 modestride);
			[ThreadStatic]
			internal static glMultiModeDrawElementsIBM pglMultiModeDrawElementsIBM;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexBufferEXT(int texunit, int target, int internalformat, UInt32 buffer);
			[ThreadStatic]
			internal static glMultiTexBufferEXT pglMultiTexBufferEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord1bOES(int texture, sbyte s);
			[ThreadStatic]
			internal static glMultiTexCoord1bOES pglMultiTexCoord1bOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord1bvOES(int texture, sbyte* coords);
			[ThreadStatic]
			internal static glMultiTexCoord1bvOES pglMultiTexCoord1bvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord1d(int target, double s);
			[ThreadStatic]
			internal static glMultiTexCoord1d pglMultiTexCoord1d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord1dARB(int target, double s);
			[ThreadStatic]
			internal static glMultiTexCoord1dARB pglMultiTexCoord1dARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord1dv(int target, double* v);
			[ThreadStatic]
			internal static glMultiTexCoord1dv pglMultiTexCoord1dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord1dvARB(int target, double* v);
			[ThreadStatic]
			internal static glMultiTexCoord1dvARB pglMultiTexCoord1dvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord1f(int target, float s);
			[ThreadStatic]
			internal static glMultiTexCoord1f pglMultiTexCoord1f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord1fARB(int target, float s);
			[ThreadStatic]
			internal static glMultiTexCoord1fARB pglMultiTexCoord1fARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord1fv(int target, float* v);
			[ThreadStatic]
			internal static glMultiTexCoord1fv pglMultiTexCoord1fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord1fvARB(int target, float* v);
			[ThreadStatic]
			internal static glMultiTexCoord1fvARB pglMultiTexCoord1fvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord1hNV(int target, UInt16 s);
			[ThreadStatic]
			internal static glMultiTexCoord1hNV pglMultiTexCoord1hNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord1hvNV(int target, UInt16* v);
			[ThreadStatic]
			internal static glMultiTexCoord1hvNV pglMultiTexCoord1hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord1i(int target, Int32 s);
			[ThreadStatic]
			internal static glMultiTexCoord1i pglMultiTexCoord1i;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord1iARB(int target, Int32 s);
			[ThreadStatic]
			internal static glMultiTexCoord1iARB pglMultiTexCoord1iARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord1iv(int target, Int32* v);
			[ThreadStatic]
			internal static glMultiTexCoord1iv pglMultiTexCoord1iv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord1ivARB(int target, Int32* v);
			[ThreadStatic]
			internal static glMultiTexCoord1ivARB pglMultiTexCoord1ivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord1s(int target, Int16 s);
			[ThreadStatic]
			internal static glMultiTexCoord1s pglMultiTexCoord1s;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord1sARB(int target, Int16 s);
			[ThreadStatic]
			internal static glMultiTexCoord1sARB pglMultiTexCoord1sARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord1sv(int target, Int16* v);
			[ThreadStatic]
			internal static glMultiTexCoord1sv pglMultiTexCoord1sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord1svARB(int target, Int16* v);
			[ThreadStatic]
			internal static glMultiTexCoord1svARB pglMultiTexCoord1svARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord1xOES(int texture, IntPtr s);
			[ThreadStatic]
			internal static glMultiTexCoord1xOES pglMultiTexCoord1xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord1xvOES(int texture, IntPtr* coords);
			[ThreadStatic]
			internal static glMultiTexCoord1xvOES pglMultiTexCoord1xvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord2bOES(int texture, sbyte s, sbyte t);
			[ThreadStatic]
			internal static glMultiTexCoord2bOES pglMultiTexCoord2bOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord2bvOES(int texture, sbyte* coords);
			[ThreadStatic]
			internal static glMultiTexCoord2bvOES pglMultiTexCoord2bvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord2d(int target, double s, double t);
			[ThreadStatic]
			internal static glMultiTexCoord2d pglMultiTexCoord2d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord2dARB(int target, double s, double t);
			[ThreadStatic]
			internal static glMultiTexCoord2dARB pglMultiTexCoord2dARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord2dv(int target, double* v);
			[ThreadStatic]
			internal static glMultiTexCoord2dv pglMultiTexCoord2dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord2dvARB(int target, double* v);
			[ThreadStatic]
			internal static glMultiTexCoord2dvARB pglMultiTexCoord2dvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord2f(int target, float s, float t);
			[ThreadStatic]
			internal static glMultiTexCoord2f pglMultiTexCoord2f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord2fARB(int target, float s, float t);
			[ThreadStatic]
			internal static glMultiTexCoord2fARB pglMultiTexCoord2fARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord2fv(int target, float* v);
			[ThreadStatic]
			internal static glMultiTexCoord2fv pglMultiTexCoord2fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord2fvARB(int target, float* v);
			[ThreadStatic]
			internal static glMultiTexCoord2fvARB pglMultiTexCoord2fvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord2hNV(int target, UInt16 s, UInt16 t);
			[ThreadStatic]
			internal static glMultiTexCoord2hNV pglMultiTexCoord2hNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord2hvNV(int target, UInt16* v);
			[ThreadStatic]
			internal static glMultiTexCoord2hvNV pglMultiTexCoord2hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord2i(int target, Int32 s, Int32 t);
			[ThreadStatic]
			internal static glMultiTexCoord2i pglMultiTexCoord2i;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord2iARB(int target, Int32 s, Int32 t);
			[ThreadStatic]
			internal static glMultiTexCoord2iARB pglMultiTexCoord2iARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord2iv(int target, Int32* v);
			[ThreadStatic]
			internal static glMultiTexCoord2iv pglMultiTexCoord2iv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord2ivARB(int target, Int32* v);
			[ThreadStatic]
			internal static glMultiTexCoord2ivARB pglMultiTexCoord2ivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord2s(int target, Int16 s, Int16 t);
			[ThreadStatic]
			internal static glMultiTexCoord2s pglMultiTexCoord2s;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord2sARB(int target, Int16 s, Int16 t);
			[ThreadStatic]
			internal static glMultiTexCoord2sARB pglMultiTexCoord2sARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord2sv(int target, Int16* v);
			[ThreadStatic]
			internal static glMultiTexCoord2sv pglMultiTexCoord2sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord2svARB(int target, Int16* v);
			[ThreadStatic]
			internal static glMultiTexCoord2svARB pglMultiTexCoord2svARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord2xOES(int texture, IntPtr s, IntPtr t);
			[ThreadStatic]
			internal static glMultiTexCoord2xOES pglMultiTexCoord2xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord2xvOES(int texture, IntPtr* coords);
			[ThreadStatic]
			internal static glMultiTexCoord2xvOES pglMultiTexCoord2xvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord3bOES(int texture, sbyte s, sbyte t, sbyte r);
			[ThreadStatic]
			internal static glMultiTexCoord3bOES pglMultiTexCoord3bOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord3bvOES(int texture, sbyte* coords);
			[ThreadStatic]
			internal static glMultiTexCoord3bvOES pglMultiTexCoord3bvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord3d(int target, double s, double t, double r);
			[ThreadStatic]
			internal static glMultiTexCoord3d pglMultiTexCoord3d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord3dARB(int target, double s, double t, double r);
			[ThreadStatic]
			internal static glMultiTexCoord3dARB pglMultiTexCoord3dARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord3dv(int target, double* v);
			[ThreadStatic]
			internal static glMultiTexCoord3dv pglMultiTexCoord3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord3dvARB(int target, double* v);
			[ThreadStatic]
			internal static glMultiTexCoord3dvARB pglMultiTexCoord3dvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord3f(int target, float s, float t, float r);
			[ThreadStatic]
			internal static glMultiTexCoord3f pglMultiTexCoord3f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord3fARB(int target, float s, float t, float r);
			[ThreadStatic]
			internal static glMultiTexCoord3fARB pglMultiTexCoord3fARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord3fv(int target, float* v);
			[ThreadStatic]
			internal static glMultiTexCoord3fv pglMultiTexCoord3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord3fvARB(int target, float* v);
			[ThreadStatic]
			internal static glMultiTexCoord3fvARB pglMultiTexCoord3fvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord3hNV(int target, UInt16 s, UInt16 t, UInt16 r);
			[ThreadStatic]
			internal static glMultiTexCoord3hNV pglMultiTexCoord3hNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord3hvNV(int target, UInt16* v);
			[ThreadStatic]
			internal static glMultiTexCoord3hvNV pglMultiTexCoord3hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord3i(int target, Int32 s, Int32 t, Int32 r);
			[ThreadStatic]
			internal static glMultiTexCoord3i pglMultiTexCoord3i;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord3iARB(int target, Int32 s, Int32 t, Int32 r);
			[ThreadStatic]
			internal static glMultiTexCoord3iARB pglMultiTexCoord3iARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord3iv(int target, Int32* v);
			[ThreadStatic]
			internal static glMultiTexCoord3iv pglMultiTexCoord3iv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord3ivARB(int target, Int32* v);
			[ThreadStatic]
			internal static glMultiTexCoord3ivARB pglMultiTexCoord3ivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord3s(int target, Int16 s, Int16 t, Int16 r);
			[ThreadStatic]
			internal static glMultiTexCoord3s pglMultiTexCoord3s;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord3sARB(int target, Int16 s, Int16 t, Int16 r);
			[ThreadStatic]
			internal static glMultiTexCoord3sARB pglMultiTexCoord3sARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord3sv(int target, Int16* v);
			[ThreadStatic]
			internal static glMultiTexCoord3sv pglMultiTexCoord3sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord3svARB(int target, Int16* v);
			[ThreadStatic]
			internal static glMultiTexCoord3svARB pglMultiTexCoord3svARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord3xOES(int texture, IntPtr s, IntPtr t, IntPtr r);
			[ThreadStatic]
			internal static glMultiTexCoord3xOES pglMultiTexCoord3xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord3xvOES(int texture, IntPtr* coords);
			[ThreadStatic]
			internal static glMultiTexCoord3xvOES pglMultiTexCoord3xvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord4bOES(int texture, sbyte s, sbyte t, sbyte r, sbyte q);
			[ThreadStatic]
			internal static glMultiTexCoord4bOES pglMultiTexCoord4bOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord4bvOES(int texture, sbyte* coords);
			[ThreadStatic]
			internal static glMultiTexCoord4bvOES pglMultiTexCoord4bvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord4d(int target, double s, double t, double r, double q);
			[ThreadStatic]
			internal static glMultiTexCoord4d pglMultiTexCoord4d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord4dARB(int target, double s, double t, double r, double q);
			[ThreadStatic]
			internal static glMultiTexCoord4dARB pglMultiTexCoord4dARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord4dv(int target, double* v);
			[ThreadStatic]
			internal static glMultiTexCoord4dv pglMultiTexCoord4dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord4dvARB(int target, double* v);
			[ThreadStatic]
			internal static glMultiTexCoord4dvARB pglMultiTexCoord4dvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord4f(int target, float s, float t, float r, float q);
			[ThreadStatic]
			internal static glMultiTexCoord4f pglMultiTexCoord4f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord4fARB(int target, float s, float t, float r, float q);
			[ThreadStatic]
			internal static glMultiTexCoord4fARB pglMultiTexCoord4fARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord4fv(int target, float* v);
			[ThreadStatic]
			internal static glMultiTexCoord4fv pglMultiTexCoord4fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord4fvARB(int target, float* v);
			[ThreadStatic]
			internal static glMultiTexCoord4fvARB pglMultiTexCoord4fvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord4hNV(int target, UInt16 s, UInt16 t, UInt16 r, UInt16 q);
			[ThreadStatic]
			internal static glMultiTexCoord4hNV pglMultiTexCoord4hNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord4hvNV(int target, UInt16* v);
			[ThreadStatic]
			internal static glMultiTexCoord4hvNV pglMultiTexCoord4hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord4i(int target, Int32 s, Int32 t, Int32 r, Int32 q);
			[ThreadStatic]
			internal static glMultiTexCoord4i pglMultiTexCoord4i;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord4iARB(int target, Int32 s, Int32 t, Int32 r, Int32 q);
			[ThreadStatic]
			internal static glMultiTexCoord4iARB pglMultiTexCoord4iARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord4iv(int target, Int32* v);
			[ThreadStatic]
			internal static glMultiTexCoord4iv pglMultiTexCoord4iv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord4ivARB(int target, Int32* v);
			[ThreadStatic]
			internal static glMultiTexCoord4ivARB pglMultiTexCoord4ivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord4s(int target, Int16 s, Int16 t, Int16 r, Int16 q);
			[ThreadStatic]
			internal static glMultiTexCoord4s pglMultiTexCoord4s;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoord4sARB(int target, Int16 s, Int16 t, Int16 r, Int16 q);
			[ThreadStatic]
			internal static glMultiTexCoord4sARB pglMultiTexCoord4sARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord4sv(int target, Int16* v);
			[ThreadStatic]
			internal static glMultiTexCoord4sv pglMultiTexCoord4sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord4svARB(int target, Int16* v);
			[ThreadStatic]
			internal static glMultiTexCoord4svARB pglMultiTexCoord4svARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord4xOES(int texture, IntPtr s, IntPtr t, IntPtr r, IntPtr q);
			[ThreadStatic]
			internal static glMultiTexCoord4xOES pglMultiTexCoord4xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord4xvOES(int texture, IntPtr* coords);
			[ThreadStatic]
			internal static glMultiTexCoord4xvOES pglMultiTexCoord4xvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoordP1ui(int texture, int type, UInt32 coords);
			[ThreadStatic]
			internal static glMultiTexCoordP1ui pglMultiTexCoordP1ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoordP1uiv(int texture, int type, UInt32* coords);
			[ThreadStatic]
			internal static glMultiTexCoordP1uiv pglMultiTexCoordP1uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoordP2ui(int texture, int type, UInt32 coords);
			[ThreadStatic]
			internal static glMultiTexCoordP2ui pglMultiTexCoordP2ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoordP2uiv(int texture, int type, UInt32* coords);
			[ThreadStatic]
			internal static glMultiTexCoordP2uiv pglMultiTexCoordP2uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoordP3ui(int texture, int type, UInt32 coords);
			[ThreadStatic]
			internal static glMultiTexCoordP3ui pglMultiTexCoordP3ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoordP3uiv(int texture, int type, UInt32* coords);
			[ThreadStatic]
			internal static glMultiTexCoordP3uiv pglMultiTexCoordP3uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexCoordP4ui(int texture, int type, UInt32 coords);
			[ThreadStatic]
			internal static glMultiTexCoordP4ui pglMultiTexCoordP4ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoordP4uiv(int texture, int type, UInt32* coords);
			[ThreadStatic]
			internal static glMultiTexCoordP4uiv pglMultiTexCoordP4uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoordPointerEXT(int texunit, Int32 size, int type, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glMultiTexCoordPointerEXT pglMultiTexCoordPointerEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexEnvfEXT(int texunit, int target, int pname, float param);
			[ThreadStatic]
			internal static glMultiTexEnvfEXT pglMultiTexEnvfEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexEnvfvEXT(int texunit, int target, int pname, float* @params);
			[ThreadStatic]
			internal static glMultiTexEnvfvEXT pglMultiTexEnvfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexEnviEXT(int texunit, int target, int pname, Int32 param);
			[ThreadStatic]
			internal static glMultiTexEnviEXT pglMultiTexEnviEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexEnvivEXT(int texunit, int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glMultiTexEnvivEXT pglMultiTexEnvivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexGendEXT(int texunit, int coord, int pname, double param);
			[ThreadStatic]
			internal static glMultiTexGendEXT pglMultiTexGendEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexGendvEXT(int texunit, int coord, int pname, double* @params);
			[ThreadStatic]
			internal static glMultiTexGendvEXT pglMultiTexGendvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexGenfEXT(int texunit, int coord, int pname, float param);
			[ThreadStatic]
			internal static glMultiTexGenfEXT pglMultiTexGenfEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexGenfvEXT(int texunit, int coord, int pname, float* @params);
			[ThreadStatic]
			internal static glMultiTexGenfvEXT pglMultiTexGenfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexGeniEXT(int texunit, int coord, int pname, Int32 param);
			[ThreadStatic]
			internal static glMultiTexGeniEXT pglMultiTexGeniEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexGenivEXT(int texunit, int coord, int pname, Int32* @params);
			[ThreadStatic]
			internal static glMultiTexGenivEXT pglMultiTexGenivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexImage1DEXT(int texunit, int target, Int32 level, Int32 internalformat, Int32 width, Int32 border, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glMultiTexImage1DEXT pglMultiTexImage1DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexImage2DEXT(int texunit, int target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glMultiTexImage2DEXT pglMultiTexImage2DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexImage3DEXT(int texunit, int target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glMultiTexImage3DEXT pglMultiTexImage3DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexParameterIivEXT(int texunit, int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glMultiTexParameterIivEXT pglMultiTexParameterIivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexParameterIuivEXT(int texunit, int target, int pname, UInt32* @params);
			[ThreadStatic]
			internal static glMultiTexParameterIuivEXT pglMultiTexParameterIuivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexParameterfEXT(int texunit, int target, int pname, float param);
			[ThreadStatic]
			internal static glMultiTexParameterfEXT pglMultiTexParameterfEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexParameterfvEXT(int texunit, int target, int pname, float* @params);
			[ThreadStatic]
			internal static glMultiTexParameterfvEXT pglMultiTexParameterfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexParameteriEXT(int texunit, int target, int pname, Int32 param);
			[ThreadStatic]
			internal static glMultiTexParameteriEXT pglMultiTexParameteriEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexParameterivEXT(int texunit, int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glMultiTexParameterivEXT pglMultiTexParameterivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMultiTexRenderbufferEXT(int texunit, int target, UInt32 renderbuffer);
			[ThreadStatic]
			internal static glMultiTexRenderbufferEXT pglMultiTexRenderbufferEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexSubImage1DEXT(int texunit, int target, Int32 level, Int32 xoffset, Int32 width, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glMultiTexSubImage1DEXT pglMultiTexSubImage1DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexSubImage2DEXT(int texunit, int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glMultiTexSubImage2DEXT pglMultiTexSubImage2DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexSubImage3DEXT(int texunit, int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glMultiTexSubImage3DEXT pglMultiTexSubImage3DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedBufferData(UInt32 buffer, UInt32 size, IntPtr data, int usage);
			[ThreadStatic]
			internal static glNamedBufferData pglNamedBufferData;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedBufferDataEXT(UInt32 buffer, UInt32 size, IntPtr data, int usage);
			[ThreadStatic]
			internal static glNamedBufferDataEXT pglNamedBufferDataEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedBufferPageCommitmentARB(UInt32 buffer, IntPtr offset, UInt32 size, bool commit);
			[ThreadStatic]
			internal static glNamedBufferPageCommitmentARB pglNamedBufferPageCommitmentARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedBufferPageCommitmentEXT(UInt32 buffer, IntPtr offset, UInt32 size, bool commit);
			[ThreadStatic]
			internal static glNamedBufferPageCommitmentEXT pglNamedBufferPageCommitmentEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedBufferStorage(UInt32 buffer, UInt32 size, IntPtr data, uint flags);
			[ThreadStatic]
			internal static glNamedBufferStorage pglNamedBufferStorage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedBufferStorageEXT(UInt32 buffer, UInt32 size, IntPtr data, uint flags);
			[ThreadStatic]
			internal static glNamedBufferStorageEXT pglNamedBufferStorageEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedBufferSubData(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data);
			[ThreadStatic]
			internal static glNamedBufferSubData pglNamedBufferSubData;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedBufferSubDataEXT(UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data);
			[ThreadStatic]
			internal static glNamedBufferSubDataEXT pglNamedBufferSubDataEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedCopyBufferSubDataEXT(UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, UInt32 size);
			[ThreadStatic]
			internal static glNamedCopyBufferSubDataEXT pglNamedCopyBufferSubDataEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferDrawBuffer(UInt32 framebuffer, int buf);
			[ThreadStatic]
			internal static glNamedFramebufferDrawBuffer pglNamedFramebufferDrawBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedFramebufferDrawBuffers(UInt32 framebuffer, Int32 n, int* bufs);
			[ThreadStatic]
			internal static glNamedFramebufferDrawBuffers pglNamedFramebufferDrawBuffers;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferParameteri(UInt32 framebuffer, int pname, Int32 param);
			[ThreadStatic]
			internal static glNamedFramebufferParameteri pglNamedFramebufferParameteri;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferParameteriEXT(UInt32 framebuffer, int pname, Int32 param);
			[ThreadStatic]
			internal static glNamedFramebufferParameteriEXT pglNamedFramebufferParameteriEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferReadBuffer(UInt32 framebuffer, int src);
			[ThreadStatic]
			internal static glNamedFramebufferReadBuffer pglNamedFramebufferReadBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferRenderbuffer(UInt32 framebuffer, int attachment, int renderbuffertarget, UInt32 renderbuffer);
			[ThreadStatic]
			internal static glNamedFramebufferRenderbuffer pglNamedFramebufferRenderbuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferRenderbufferEXT(UInt32 framebuffer, int attachment, int renderbuffertarget, UInt32 renderbuffer);
			[ThreadStatic]
			internal static glNamedFramebufferRenderbufferEXT pglNamedFramebufferRenderbufferEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferTexture(UInt32 framebuffer, int attachment, UInt32 texture, Int32 level);
			[ThreadStatic]
			internal static glNamedFramebufferTexture pglNamedFramebufferTexture;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferTexture1DEXT(UInt32 framebuffer, int attachment, int textarget, UInt32 texture, Int32 level);
			[ThreadStatic]
			internal static glNamedFramebufferTexture1DEXT pglNamedFramebufferTexture1DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferTexture2DEXT(UInt32 framebuffer, int attachment, int textarget, UInt32 texture, Int32 level);
			[ThreadStatic]
			internal static glNamedFramebufferTexture2DEXT pglNamedFramebufferTexture2DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferTexture3DEXT(UInt32 framebuffer, int attachment, int textarget, UInt32 texture, Int32 level, Int32 zoffset);
			[ThreadStatic]
			internal static glNamedFramebufferTexture3DEXT pglNamedFramebufferTexture3DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferTextureEXT(UInt32 framebuffer, int attachment, UInt32 texture, Int32 level);
			[ThreadStatic]
			internal static glNamedFramebufferTextureEXT pglNamedFramebufferTextureEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferTextureFaceEXT(UInt32 framebuffer, int attachment, UInt32 texture, Int32 level, int face);
			[ThreadStatic]
			internal static glNamedFramebufferTextureFaceEXT pglNamedFramebufferTextureFaceEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferTextureLayer(UInt32 framebuffer, int attachment, UInt32 texture, Int32 level, Int32 layer);
			[ThreadStatic]
			internal static glNamedFramebufferTextureLayer pglNamedFramebufferTextureLayer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedFramebufferTextureLayerEXT(UInt32 framebuffer, int attachment, UInt32 texture, Int32 level, Int32 layer);
			[ThreadStatic]
			internal static glNamedFramebufferTextureLayerEXT pglNamedFramebufferTextureLayerEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedProgramLocalParameter4dEXT(UInt32 program, int target, UInt32 index, double x, double y, double z, double w);
			[ThreadStatic]
			internal static glNamedProgramLocalParameter4dEXT pglNamedProgramLocalParameter4dEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedProgramLocalParameter4dvEXT(UInt32 program, int target, UInt32 index, double* @params);
			[ThreadStatic]
			internal static glNamedProgramLocalParameter4dvEXT pglNamedProgramLocalParameter4dvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedProgramLocalParameter4fEXT(UInt32 program, int target, UInt32 index, float x, float y, float z, float w);
			[ThreadStatic]
			internal static glNamedProgramLocalParameter4fEXT pglNamedProgramLocalParameter4fEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedProgramLocalParameter4fvEXT(UInt32 program, int target, UInt32 index, float* @params);
			[ThreadStatic]
			internal static glNamedProgramLocalParameter4fvEXT pglNamedProgramLocalParameter4fvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedProgramLocalParameterI4iEXT(UInt32 program, int target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
			[ThreadStatic]
			internal static glNamedProgramLocalParameterI4iEXT pglNamedProgramLocalParameterI4iEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedProgramLocalParameterI4ivEXT(UInt32 program, int target, UInt32 index, Int32* @params);
			[ThreadStatic]
			internal static glNamedProgramLocalParameterI4ivEXT pglNamedProgramLocalParameterI4ivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedProgramLocalParameterI4uiEXT(UInt32 program, int target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
			[ThreadStatic]
			internal static glNamedProgramLocalParameterI4uiEXT pglNamedProgramLocalParameterI4uiEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedProgramLocalParameterI4uivEXT(UInt32 program, int target, UInt32 index, UInt32* @params);
			[ThreadStatic]
			internal static glNamedProgramLocalParameterI4uivEXT pglNamedProgramLocalParameterI4uivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedProgramLocalParameters4fvEXT(UInt32 program, int target, UInt32 index, Int32 count, float* @params);
			[ThreadStatic]
			internal static glNamedProgramLocalParameters4fvEXT pglNamedProgramLocalParameters4fvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedProgramLocalParametersI4ivEXT(UInt32 program, int target, UInt32 index, Int32 count, Int32* @params);
			[ThreadStatic]
			internal static glNamedProgramLocalParametersI4ivEXT pglNamedProgramLocalParametersI4ivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedProgramLocalParametersI4uivEXT(UInt32 program, int target, UInt32 index, Int32 count, UInt32* @params);
			[ThreadStatic]
			internal static glNamedProgramLocalParametersI4uivEXT pglNamedProgramLocalParametersI4uivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedProgramStringEXT(UInt32 program, int target, int format, Int32 len, IntPtr @string);
			[ThreadStatic]
			internal static glNamedProgramStringEXT pglNamedProgramStringEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedRenderbufferStorage(UInt32 renderbuffer, int internalformat, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glNamedRenderbufferStorage pglNamedRenderbufferStorage;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedRenderbufferStorageEXT(UInt32 renderbuffer, int internalformat, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glNamedRenderbufferStorageEXT pglNamedRenderbufferStorageEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedRenderbufferStorageMultisample(UInt32 renderbuffer, Int32 samples, int internalformat, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glNamedRenderbufferStorageMultisample pglNamedRenderbufferStorageMultisample;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedRenderbufferStorageMultisampleCoverageEXT(UInt32 renderbuffer, Int32 coverageSamples, Int32 colorSamples, int internalformat, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glNamedRenderbufferStorageMultisampleCoverageEXT pglNamedRenderbufferStorageMultisampleCoverageEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedRenderbufferStorageMultisampleEXT(UInt32 renderbuffer, Int32 samples, int internalformat, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glNamedRenderbufferStorageMultisampleEXT pglNamedRenderbufferStorageMultisampleEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNamedStringARB(int type, Int32 namelen, String name, Int32 stringlen, String @string);
			[ThreadStatic]
			internal static glNamedStringARB pglNamedStringARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNewList(UInt32 list, int mode);
			[ThreadStatic]
			internal static glNewList pglNewList;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 glNewObjectBufferATI(Int32 size, IntPtr pointer, int usage);
			[ThreadStatic]
			internal static glNewObjectBufferATI pglNewObjectBufferATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormal3b(sbyte nx, sbyte ny, sbyte nz);
			[ThreadStatic]
			internal static glNormal3b pglNormal3b;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3bv(sbyte* v);
			[ThreadStatic]
			internal static glNormal3bv pglNormal3bv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormal3d(double nx, double ny, double nz);
			[ThreadStatic]
			internal static glNormal3d pglNormal3d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3dv(double* v);
			[ThreadStatic]
			internal static glNormal3dv pglNormal3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormal3f(float nx, float ny, float nz);
			[ThreadStatic]
			internal static glNormal3f pglNormal3f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormal3fVertex3fSUN(float nx, float ny, float nz, float x, float y, float z);
			[ThreadStatic]
			internal static glNormal3fVertex3fSUN pglNormal3fVertex3fSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3fVertex3fvSUN(float* n, float* v);
			[ThreadStatic]
			internal static glNormal3fVertex3fvSUN pglNormal3fVertex3fvSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3fv(float* v);
			[ThreadStatic]
			internal static glNormal3fv pglNormal3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormal3hNV(UInt16 nx, UInt16 ny, UInt16 nz);
			[ThreadStatic]
			internal static glNormal3hNV pglNormal3hNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3hvNV(UInt16* v);
			[ThreadStatic]
			internal static glNormal3hvNV pglNormal3hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormal3i(Int32 nx, Int32 ny, Int32 nz);
			[ThreadStatic]
			internal static glNormal3i pglNormal3i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3iv(Int32* v);
			[ThreadStatic]
			internal static glNormal3iv pglNormal3iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormal3s(Int16 nx, Int16 ny, Int16 nz);
			[ThreadStatic]
			internal static glNormal3s pglNormal3s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3sv(Int16* v);
			[ThreadStatic]
			internal static glNormal3sv pglNormal3sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3xOES(IntPtr nx, IntPtr ny, IntPtr nz);
			[ThreadStatic]
			internal static glNormal3xOES pglNormal3xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3xvOES(IntPtr* coords);
			[ThreadStatic]
			internal static glNormal3xvOES pglNormal3xvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormalFormatNV(int type, Int32 stride);
			[ThreadStatic]
			internal static glNormalFormatNV pglNormalFormatNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormalP3ui(int type, UInt32 coords);
			[ThreadStatic]
			internal static glNormalP3ui pglNormalP3ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormalP3uiv(int type, UInt32* coords);
			[ThreadStatic]
			internal static glNormalP3uiv pglNormalP3uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormalPointer(int type, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glNormalPointer pglNormalPointer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormalPointerEXT(int type, Int32 stride, Int32 count, IntPtr pointer);
			[ThreadStatic]
			internal static glNormalPointerEXT pglNormalPointerEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormalPointerListIBM(int type, Int32 stride, IntPtr* pointer, Int32 ptrstride);
			[ThreadStatic]
			internal static glNormalPointerListIBM pglNormalPointerListIBM;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormalPointervINTEL(int type, IntPtr* pointer);
			[ThreadStatic]
			internal static glNormalPointervINTEL pglNormalPointervINTEL;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormalStream3bATI(int stream, sbyte nx, sbyte ny, sbyte nz);
			[ThreadStatic]
			internal static glNormalStream3bATI pglNormalStream3bATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormalStream3bvATI(int stream, sbyte* coords);
			[ThreadStatic]
			internal static glNormalStream3bvATI pglNormalStream3bvATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormalStream3dATI(int stream, double nx, double ny, double nz);
			[ThreadStatic]
			internal static glNormalStream3dATI pglNormalStream3dATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormalStream3dvATI(int stream, double* coords);
			[ThreadStatic]
			internal static glNormalStream3dvATI pglNormalStream3dvATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormalStream3fATI(int stream, float nx, float ny, float nz);
			[ThreadStatic]
			internal static glNormalStream3fATI pglNormalStream3fATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormalStream3fvATI(int stream, float* coords);
			[ThreadStatic]
			internal static glNormalStream3fvATI pglNormalStream3fvATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormalStream3iATI(int stream, Int32 nx, Int32 ny, Int32 nz);
			[ThreadStatic]
			internal static glNormalStream3iATI pglNormalStream3iATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormalStream3ivATI(int stream, Int32* coords);
			[ThreadStatic]
			internal static glNormalStream3ivATI pglNormalStream3ivATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormalStream3sATI(int stream, Int16 nx, Int16 ny, Int16 nz);
			[ThreadStatic]
			internal static glNormalStream3sATI pglNormalStream3sATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormalStream3svATI(int stream, Int16* coords);
			[ThreadStatic]
			internal static glNormalStream3svATI pglNormalStream3svATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glObjectLabel(int identifier, UInt32 name, Int32 length, String label);
			[ThreadStatic]
			internal static glObjectLabel pglObjectLabel;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glObjectPtrLabel(IntPtr ptr, Int32 length, String label);
			[ThreadStatic]
			internal static glObjectPtrLabel pglObjectPtrLabel;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int glObjectPurgeableAPPLE(int objectType, UInt32 name, int option);
			[ThreadStatic]
			internal static glObjectPurgeableAPPLE pglObjectPurgeableAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int glObjectUnpurgeableAPPLE(int objectType, UInt32 name, int option);
			[ThreadStatic]
			internal static glObjectUnpurgeableAPPLE pglObjectUnpurgeableAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar);
			[ThreadStatic]
			internal static glOrtho pglOrtho;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glOrthofOES(float l, float r, float b, float t, float n, float f);
			[ThreadStatic]
			internal static glOrthofOES pglOrthofOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glOrthoxOES(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f);
			[ThreadStatic]
			internal static glOrthoxOES pglOrthoxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPNTrianglesfATI(int pname, float param);
			[ThreadStatic]
			internal static glPNTrianglesfATI pglPNTrianglesfATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPNTrianglesiATI(int pname, Int32 param);
			[ThreadStatic]
			internal static glPNTrianglesiATI pglPNTrianglesiATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPassTexCoordATI(UInt32 dst, UInt32 coord, int swizzle);
			[ThreadStatic]
			internal static glPassTexCoordATI pglPassTexCoordATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPassThrough(float token);
			[ThreadStatic]
			internal static glPassThrough pglPassThrough;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPassThroughxOES(IntPtr token);
			[ThreadStatic]
			internal static glPassThroughxOES pglPassThroughxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPatchParameterfv(int pname, float* values);
			[ThreadStatic]
			internal static glPatchParameterfv pglPatchParameterfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPatchParameteri(int pname, Int32 value);
			[ThreadStatic]
			internal static glPatchParameteri pglPatchParameteri;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPathColorGenNV(int color, int genMode, int colorFormat, float* coeffs);
			[ThreadStatic]
			internal static glPathColorGenNV pglPathColorGenNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPathCommandsNV(UInt32 path, Int32 numCommands, byte* commands, Int32 numCoords, int coordType, IntPtr coords);
			[ThreadStatic]
			internal static glPathCommandsNV pglPathCommandsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPathCoordsNV(UInt32 path, Int32 numCoords, int coordType, IntPtr coords);
			[ThreadStatic]
			internal static glPathCoordsNV pglPathCoordsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPathCoverDepthFuncNV(int func);
			[ThreadStatic]
			internal static glPathCoverDepthFuncNV pglPathCoverDepthFuncNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPathDashArrayNV(UInt32 path, Int32 dashCount, float* dashArray);
			[ThreadStatic]
			internal static glPathDashArrayNV pglPathDashArrayNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPathFogGenNV(int genMode);
			[ThreadStatic]
			internal static glPathFogGenNV pglPathFogGenNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glPathGlyphIndexArrayNV(UInt32 firstPathName, int fontTarget, IntPtr fontName, uint fontStyle, UInt32 firstGlyphIndex, Int32 numGlyphs, UInt32 pathParameterTemplate, float emScale);
			[ThreadStatic]
			internal static glPathGlyphIndexArrayNV pglPathGlyphIndexArrayNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glPathGlyphIndexRangeNV(int fontTarget, IntPtr fontName, uint fontStyle, UInt32 pathParameterTemplate, float emScale, UInt32* baseAndCount);
			[ThreadStatic]
			internal static glPathGlyphIndexRangeNV pglPathGlyphIndexRangeNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPathGlyphRangeNV(UInt32 firstPathName, int fontTarget, IntPtr fontName, uint fontStyle, UInt32 firstGlyph, Int32 numGlyphs, int handleMissingGlyphs, UInt32 pathParameterTemplate, float emScale);
			[ThreadStatic]
			internal static glPathGlyphRangeNV pglPathGlyphRangeNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPathGlyphsNV(UInt32 firstPathName, int fontTarget, IntPtr fontName, uint fontStyle, Int32 numGlyphs, int type, IntPtr charcodes, int handleMissingGlyphs, UInt32 pathParameterTemplate, float emScale);
			[ThreadStatic]
			internal static glPathGlyphsNV pglPathGlyphsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glPathMemoryGlyphIndexArrayNV(UInt32 firstPathName, int fontTarget, UInt32 fontSize, IntPtr fontData, Int32 faceIndex, UInt32 firstGlyphIndex, Int32 numGlyphs, UInt32 pathParameterTemplate, float emScale);
			[ThreadStatic]
			internal static glPathMemoryGlyphIndexArrayNV pglPathMemoryGlyphIndexArrayNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPathParameterfNV(UInt32 path, int pname, float value);
			[ThreadStatic]
			internal static glPathParameterfNV pglPathParameterfNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPathParameterfvNV(UInt32 path, int pname, float* value);
			[ThreadStatic]
			internal static glPathParameterfvNV pglPathParameterfvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPathParameteriNV(UInt32 path, int pname, Int32 value);
			[ThreadStatic]
			internal static glPathParameteriNV pglPathParameteriNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPathParameterivNV(UInt32 path, int pname, Int32* value);
			[ThreadStatic]
			internal static glPathParameterivNV pglPathParameterivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPathStencilDepthOffsetNV(float factor, float units);
			[ThreadStatic]
			internal static glPathStencilDepthOffsetNV pglPathStencilDepthOffsetNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPathStencilFuncNV(int func, Int32 @ref, UInt32 mask);
			[ThreadStatic]
			internal static glPathStencilFuncNV pglPathStencilFuncNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPathStringNV(UInt32 path, int format, Int32 length, IntPtr pathString);
			[ThreadStatic]
			internal static glPathStringNV pglPathStringNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPathSubCommandsNV(UInt32 path, Int32 commandStart, Int32 commandsToDelete, Int32 numCommands, byte* commands, Int32 numCoords, int coordType, IntPtr coords);
			[ThreadStatic]
			internal static glPathSubCommandsNV pglPathSubCommandsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPathSubCoordsNV(UInt32 path, Int32 coordStart, Int32 numCoords, int coordType, IntPtr coords);
			[ThreadStatic]
			internal static glPathSubCoordsNV pglPathSubCoordsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPathTexGenNV(int texCoordSet, int genMode, Int32 components, float* coeffs);
			[ThreadStatic]
			internal static glPathTexGenNV pglPathTexGenNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPauseTransformFeedback();
			[ThreadStatic]
			internal static glPauseTransformFeedback pglPauseTransformFeedback;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPauseTransformFeedbackNV();
			[ThreadStatic]
			internal static glPauseTransformFeedbackNV pglPauseTransformFeedbackNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPixelDataRangeNV(int target, Int32 length, IntPtr pointer);
			[ThreadStatic]
			internal static glPixelDataRangeNV pglPixelDataRangeNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPixelMapfv(int map, Int32 mapsize, float* values);
			[ThreadStatic]
			internal static glPixelMapfv pglPixelMapfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPixelMapuiv(int map, Int32 mapsize, UInt32* values);
			[ThreadStatic]
			internal static glPixelMapuiv pglPixelMapuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPixelMapusv(int map, Int32 mapsize, UInt16* values);
			[ThreadStatic]
			internal static glPixelMapusv pglPixelMapusv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPixelMapx(int map, Int32 size, IntPtr* values);
			[ThreadStatic]
			internal static glPixelMapx pglPixelMapx;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelStoref(int pname, float param);
			[ThreadStatic]
			internal static glPixelStoref pglPixelStoref;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelStorei(int pname, Int32 param);
			[ThreadStatic]
			internal static glPixelStorei pglPixelStorei;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPixelStorex(int pname, IntPtr param);
			[ThreadStatic]
			internal static glPixelStorex pglPixelStorex;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelTexGenParameterfSGIS(int pname, float param);
			[ThreadStatic]
			internal static glPixelTexGenParameterfSGIS pglPixelTexGenParameterfSGIS;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPixelTexGenParameterfvSGIS(int pname, float* @params);
			[ThreadStatic]
			internal static glPixelTexGenParameterfvSGIS pglPixelTexGenParameterfvSGIS;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelTexGenParameteriSGIS(int pname, Int32 param);
			[ThreadStatic]
			internal static glPixelTexGenParameteriSGIS pglPixelTexGenParameteriSGIS;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPixelTexGenParameterivSGIS(int pname, Int32* @params);
			[ThreadStatic]
			internal static glPixelTexGenParameterivSGIS pglPixelTexGenParameterivSGIS;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelTexGenSGIX(int mode);
			[ThreadStatic]
			internal static glPixelTexGenSGIX pglPixelTexGenSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelTransferf(int pname, float param);
			[ThreadStatic]
			internal static glPixelTransferf pglPixelTransferf;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelTransferi(int pname, Int32 param);
			[ThreadStatic]
			internal static glPixelTransferi pglPixelTransferi;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPixelTransferxOES(int pname, IntPtr param);
			[ThreadStatic]
			internal static glPixelTransferxOES pglPixelTransferxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelTransformParameterfEXT(int target, int pname, float param);
			[ThreadStatic]
			internal static glPixelTransformParameterfEXT pglPixelTransformParameterfEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPixelTransformParameterfvEXT(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glPixelTransformParameterfvEXT pglPixelTransformParameterfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelTransformParameteriEXT(int target, int pname, Int32 param);
			[ThreadStatic]
			internal static glPixelTransformParameteriEXT pglPixelTransformParameteriEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPixelTransformParameterivEXT(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glPixelTransformParameterivEXT pglPixelTransformParameterivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelZoom(float xfactor, float yfactor);
			[ThreadStatic]
			internal static glPixelZoom pglPixelZoom;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPixelZoomxOES(IntPtr xfactor, IntPtr yfactor);
			[ThreadStatic]
			internal static glPixelZoomxOES pglPixelZoomxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glPointAlongPathNV(UInt32 path, Int32 startSegment, Int32 numSegments, float distance, float* x, float* y, float* tangentX, float* tangentY);
			[ThreadStatic]
			internal static glPointAlongPathNV pglPointAlongPathNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPointParameterf(int pname, float param);
			[ThreadStatic]
			internal static glPointParameterf pglPointParameterf;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPointParameterfARB(int pname, float param);
			[ThreadStatic]
			internal static glPointParameterfARB pglPointParameterfARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPointParameterfEXT(int pname, float param);
			[ThreadStatic]
			internal static glPointParameterfEXT pglPointParameterfEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPointParameterfSGIS(int pname, float param);
			[ThreadStatic]
			internal static glPointParameterfSGIS pglPointParameterfSGIS;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPointParameterfv(int pname, float* @params);
			[ThreadStatic]
			internal static glPointParameterfv pglPointParameterfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPointParameterfvARB(int pname, float* @params);
			[ThreadStatic]
			internal static glPointParameterfvARB pglPointParameterfvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPointParameterfvEXT(int pname, float* @params);
			[ThreadStatic]
			internal static glPointParameterfvEXT pglPointParameterfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPointParameterfvSGIS(int pname, float* @params);
			[ThreadStatic]
			internal static glPointParameterfvSGIS pglPointParameterfvSGIS;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPointParameteri(int pname, Int32 param);
			[ThreadStatic]
			internal static glPointParameteri pglPointParameteri;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPointParameteriNV(int pname, Int32 param);
			[ThreadStatic]
			internal static glPointParameteriNV pglPointParameteriNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPointParameteriv(int pname, Int32* @params);
			[ThreadStatic]
			internal static glPointParameteriv pglPointParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPointParameterivNV(int pname, Int32* @params);
			[ThreadStatic]
			internal static glPointParameterivNV pglPointParameterivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPointParameterxvOES(int pname, IntPtr* @params);
			[ThreadStatic]
			internal static glPointParameterxvOES pglPointParameterxvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPointSize(float size);
			[ThreadStatic]
			internal static glPointSize pglPointSize;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPointSizexOES(IntPtr size);
			[ThreadStatic]
			internal static glPointSizexOES pglPointSizexOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate Int32 glPollAsyncSGIX(UInt32* markerp);
			[ThreadStatic]
			internal static glPollAsyncSGIX pglPollAsyncSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate Int32 glPollInstrumentsSGIX(Int32* marker_p);
			[ThreadStatic]
			internal static glPollInstrumentsSGIX pglPollInstrumentsSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPolygonMode(int face, int mode);
			[ThreadStatic]
			internal static glPolygonMode pglPolygonMode;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPolygonOffset(float factor, float units);
			[ThreadStatic]
			internal static glPolygonOffset pglPolygonOffset;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPolygonOffsetEXT(float factor, float bias);
			[ThreadStatic]
			internal static glPolygonOffsetEXT pglPolygonOffsetEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPolygonOffsetxOES(IntPtr factor, IntPtr units);
			[ThreadStatic]
			internal static glPolygonOffsetxOES pglPolygonOffsetxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPolygonOffsetClampEXT(float factor, float units, float clamp);
			[ThreadStatic]
			internal static glPolygonOffsetClampEXT pglPolygonOffsetClampEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPolygonStipple(byte* mask);
			[ThreadStatic]
			internal static glPolygonStipple pglPolygonStipple;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPopAttrib();
			[ThreadStatic]
			internal static glPopAttrib pglPopAttrib;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPopClientAttrib();
			[ThreadStatic]
			internal static glPopClientAttrib pglPopClientAttrib;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPopDebugGroup();
			[ThreadStatic]
			internal static glPopDebugGroup pglPopDebugGroup;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPopGroupMarkerEXT();
			[ThreadStatic]
			internal static glPopGroupMarkerEXT pglPopGroupMarkerEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPopMatrix();
			[ThreadStatic]
			internal static glPopMatrix pglPopMatrix;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPopName();
			[ThreadStatic]
			internal static glPopName pglPopName;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPresentFrameDualFillNV(UInt32 video_slot, UInt64 minPresentTime, UInt32 beginPresentTimeId, UInt32 presentDurationId, int type, int target0, UInt32 fill0, int target1, UInt32 fill1, int target2, UInt32 fill2, int target3, UInt32 fill3);
			[ThreadStatic]
			internal static glPresentFrameDualFillNV pglPresentFrameDualFillNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPresentFrameKeyedNV(UInt32 video_slot, UInt64 minPresentTime, UInt32 beginPresentTimeId, UInt32 presentDurationId, int type, int target0, UInt32 fill0, UInt32 key0, int target1, UInt32 fill1, UInt32 key1);
			[ThreadStatic]
			internal static glPresentFrameKeyedNV pglPresentFrameKeyedNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPrimitiveRestartIndex(UInt32 index);
			[ThreadStatic]
			internal static glPrimitiveRestartIndex pglPrimitiveRestartIndex;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPrimitiveRestartIndexNV(UInt32 index);
			[ThreadStatic]
			internal static glPrimitiveRestartIndexNV pglPrimitiveRestartIndexNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPrimitiveRestartNV();
			[ThreadStatic]
			internal static glPrimitiveRestartNV pglPrimitiveRestartNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPrioritizeTextures(Int32 n, UInt32* textures, float* priorities);
			[ThreadStatic]
			internal static glPrioritizeTextures pglPrioritizeTextures;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPrioritizeTexturesEXT(Int32 n, UInt32* textures, float* priorities);
			[ThreadStatic]
			internal static glPrioritizeTexturesEXT pglPrioritizeTexturesEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPrioritizeTexturesxOES(Int32 n, UInt32* textures, IntPtr* priorities);
			[ThreadStatic]
			internal static glPrioritizeTexturesxOES pglPrioritizeTexturesxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramBinary(UInt32 program, int binaryFormat, IntPtr binary, Int32 length);
			[ThreadStatic]
			internal static glProgramBinary pglProgramBinary;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramBufferParametersIivNV(int target, UInt32 bindingIndex, UInt32 wordIndex, Int32 count, Int32* @params);
			[ThreadStatic]
			internal static glProgramBufferParametersIivNV pglProgramBufferParametersIivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramBufferParametersIuivNV(int target, UInt32 bindingIndex, UInt32 wordIndex, Int32 count, UInt32* @params);
			[ThreadStatic]
			internal static glProgramBufferParametersIuivNV pglProgramBufferParametersIuivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramBufferParametersfvNV(int target, UInt32 bindingIndex, UInt32 wordIndex, Int32 count, float* @params);
			[ThreadStatic]
			internal static glProgramBufferParametersfvNV pglProgramBufferParametersfvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramEnvParameter4dARB(int target, UInt32 index, double x, double y, double z, double w);
			[ThreadStatic]
			internal static glProgramEnvParameter4dARB pglProgramEnvParameter4dARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramEnvParameter4dvARB(int target, UInt32 index, double* @params);
			[ThreadStatic]
			internal static glProgramEnvParameter4dvARB pglProgramEnvParameter4dvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramEnvParameter4fARB(int target, UInt32 index, float x, float y, float z, float w);
			[ThreadStatic]
			internal static glProgramEnvParameter4fARB pglProgramEnvParameter4fARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramEnvParameter4fvARB(int target, UInt32 index, float* @params);
			[ThreadStatic]
			internal static glProgramEnvParameter4fvARB pglProgramEnvParameter4fvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramEnvParameterI4iNV(int target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
			[ThreadStatic]
			internal static glProgramEnvParameterI4iNV pglProgramEnvParameterI4iNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramEnvParameterI4ivNV(int target, UInt32 index, Int32* @params);
			[ThreadStatic]
			internal static glProgramEnvParameterI4ivNV pglProgramEnvParameterI4ivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramEnvParameterI4uiNV(int target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
			[ThreadStatic]
			internal static glProgramEnvParameterI4uiNV pglProgramEnvParameterI4uiNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramEnvParameterI4uivNV(int target, UInt32 index, UInt32* @params);
			[ThreadStatic]
			internal static glProgramEnvParameterI4uivNV pglProgramEnvParameterI4uivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramEnvParameters4fvEXT(int target, UInt32 index, Int32 count, float* @params);
			[ThreadStatic]
			internal static glProgramEnvParameters4fvEXT pglProgramEnvParameters4fvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramEnvParametersI4ivNV(int target, UInt32 index, Int32 count, Int32* @params);
			[ThreadStatic]
			internal static glProgramEnvParametersI4ivNV pglProgramEnvParametersI4ivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramEnvParametersI4uivNV(int target, UInt32 index, Int32 count, UInt32* @params);
			[ThreadStatic]
			internal static glProgramEnvParametersI4uivNV pglProgramEnvParametersI4uivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramLocalParameter4dARB(int target, UInt32 index, double x, double y, double z, double w);
			[ThreadStatic]
			internal static glProgramLocalParameter4dARB pglProgramLocalParameter4dARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramLocalParameter4dvARB(int target, UInt32 index, double* @params);
			[ThreadStatic]
			internal static glProgramLocalParameter4dvARB pglProgramLocalParameter4dvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramLocalParameter4fARB(int target, UInt32 index, float x, float y, float z, float w);
			[ThreadStatic]
			internal static glProgramLocalParameter4fARB pglProgramLocalParameter4fARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramLocalParameter4fvARB(int target, UInt32 index, float* @params);
			[ThreadStatic]
			internal static glProgramLocalParameter4fvARB pglProgramLocalParameter4fvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramLocalParameterI4iNV(int target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
			[ThreadStatic]
			internal static glProgramLocalParameterI4iNV pglProgramLocalParameterI4iNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramLocalParameterI4ivNV(int target, UInt32 index, Int32* @params);
			[ThreadStatic]
			internal static glProgramLocalParameterI4ivNV pglProgramLocalParameterI4ivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramLocalParameterI4uiNV(int target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
			[ThreadStatic]
			internal static glProgramLocalParameterI4uiNV pglProgramLocalParameterI4uiNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramLocalParameterI4uivNV(int target, UInt32 index, UInt32* @params);
			[ThreadStatic]
			internal static glProgramLocalParameterI4uivNV pglProgramLocalParameterI4uivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramLocalParameters4fvEXT(int target, UInt32 index, Int32 count, float* @params);
			[ThreadStatic]
			internal static glProgramLocalParameters4fvEXT pglProgramLocalParameters4fvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramLocalParametersI4ivNV(int target, UInt32 index, Int32 count, Int32* @params);
			[ThreadStatic]
			internal static glProgramLocalParametersI4ivNV pglProgramLocalParametersI4ivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramLocalParametersI4uivNV(int target, UInt32 index, Int32 count, UInt32* @params);
			[ThreadStatic]
			internal static glProgramLocalParametersI4uivNV pglProgramLocalParametersI4uivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramNamedParameter4dNV(UInt32 id, Int32 len, byte* name, double x, double y, double z, double w);
			[ThreadStatic]
			internal static glProgramNamedParameter4dNV pglProgramNamedParameter4dNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramNamedParameter4dvNV(UInt32 id, Int32 len, byte* name, double* v);
			[ThreadStatic]
			internal static glProgramNamedParameter4dvNV pglProgramNamedParameter4dvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramNamedParameter4fNV(UInt32 id, Int32 len, byte* name, float x, float y, float z, float w);
			[ThreadStatic]
			internal static glProgramNamedParameter4fNV pglProgramNamedParameter4fNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramNamedParameter4fvNV(UInt32 id, Int32 len, byte* name, float* v);
			[ThreadStatic]
			internal static glProgramNamedParameter4fvNV pglProgramNamedParameter4fvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramParameter4dNV(int target, UInt32 index, double x, double y, double z, double w);
			[ThreadStatic]
			internal static glProgramParameter4dNV pglProgramParameter4dNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramParameter4dvNV(int target, UInt32 index, double* v);
			[ThreadStatic]
			internal static glProgramParameter4dvNV pglProgramParameter4dvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramParameter4fNV(int target, UInt32 index, float x, float y, float z, float w);
			[ThreadStatic]
			internal static glProgramParameter4fNV pglProgramParameter4fNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramParameter4fvNV(int target, UInt32 index, float* v);
			[ThreadStatic]
			internal static glProgramParameter4fvNV pglProgramParameter4fvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramParameteri(UInt32 program, int pname, Int32 value);
			[ThreadStatic]
			internal static glProgramParameteri pglProgramParameteri;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramParameteriARB(UInt32 program, int pname, Int32 value);
			[ThreadStatic]
			internal static glProgramParameteriARB pglProgramParameteriARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramParameteriEXT(UInt32 program, int pname, Int32 value);
			[ThreadStatic]
			internal static glProgramParameteriEXT pglProgramParameteriEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramParameters4dvNV(int target, UInt32 index, Int32 count, double* v);
			[ThreadStatic]
			internal static glProgramParameters4dvNV pglProgramParameters4dvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramParameters4fvNV(int target, UInt32 index, Int32 count, float* v);
			[ThreadStatic]
			internal static glProgramParameters4fvNV pglProgramParameters4fvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramPathFragmentInputGenNV(UInt32 program, Int32 location, int genMode, Int32 components, float* coeffs);
			[ThreadStatic]
			internal static glProgramPathFragmentInputGenNV pglProgramPathFragmentInputGenNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramStringARB(int target, int format, Int32 len, IntPtr @string);
			[ThreadStatic]
			internal static glProgramStringARB pglProgramStringARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramSubroutineParametersuivNV(int target, Int32 count, UInt32* @params);
			[ThreadStatic]
			internal static glProgramSubroutineParametersuivNV pglProgramSubroutineParametersuivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform1d(UInt32 program, Int32 location, double v0);
			[ThreadStatic]
			internal static glProgramUniform1d pglProgramUniform1d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform1dEXT(UInt32 program, Int32 location, double x);
			[ThreadStatic]
			internal static glProgramUniform1dEXT pglProgramUniform1dEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform1dv(UInt32 program, Int32 location, Int32 count, double* value);
			[ThreadStatic]
			internal static glProgramUniform1dv pglProgramUniform1dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform1dvEXT(UInt32 program, Int32 location, Int32 count, double* value);
			[ThreadStatic]
			internal static glProgramUniform1dvEXT pglProgramUniform1dvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform1f(UInt32 program, Int32 location, float v0);
			[ThreadStatic]
			internal static glProgramUniform1f pglProgramUniform1f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform1fEXT(UInt32 program, Int32 location, float v0);
			[ThreadStatic]
			internal static glProgramUniform1fEXT pglProgramUniform1fEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform1fv(UInt32 program, Int32 location, Int32 count, float* value);
			[ThreadStatic]
			internal static glProgramUniform1fv pglProgramUniform1fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform1fvEXT(UInt32 program, Int32 location, Int32 count, float* value);
			[ThreadStatic]
			internal static glProgramUniform1fvEXT pglProgramUniform1fvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform1i(UInt32 program, Int32 location, Int32 v0);
			[ThreadStatic]
			internal static glProgramUniform1i pglProgramUniform1i;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform1i64NV(UInt32 program, Int32 location, Int64 x);
			[ThreadStatic]
			internal static glProgramUniform1i64NV pglProgramUniform1i64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform1i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);
			[ThreadStatic]
			internal static glProgramUniform1i64vNV pglProgramUniform1i64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform1iEXT(UInt32 program, Int32 location, Int32 v0);
			[ThreadStatic]
			internal static glProgramUniform1iEXT pglProgramUniform1iEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform1iv(UInt32 program, Int32 location, Int32 count, Int32* value);
			[ThreadStatic]
			internal static glProgramUniform1iv pglProgramUniform1iv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform1ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
			[ThreadStatic]
			internal static glProgramUniform1ivEXT pglProgramUniform1ivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform1ui(UInt32 program, Int32 location, UInt32 v0);
			[ThreadStatic]
			internal static glProgramUniform1ui pglProgramUniform1ui;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform1ui64NV(UInt32 program, Int32 location, UInt64 x);
			[ThreadStatic]
			internal static glProgramUniform1ui64NV pglProgramUniform1ui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform1ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);
			[ThreadStatic]
			internal static glProgramUniform1ui64vNV pglProgramUniform1ui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform1uiEXT(UInt32 program, Int32 location, UInt32 v0);
			[ThreadStatic]
			internal static glProgramUniform1uiEXT pglProgramUniform1uiEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform1uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
			[ThreadStatic]
			internal static glProgramUniform1uiv pglProgramUniform1uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform1uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
			[ThreadStatic]
			internal static glProgramUniform1uivEXT pglProgramUniform1uivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform2d(UInt32 program, Int32 location, double v0, double v1);
			[ThreadStatic]
			internal static glProgramUniform2d pglProgramUniform2d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform2dEXT(UInt32 program, Int32 location, double x, double y);
			[ThreadStatic]
			internal static glProgramUniform2dEXT pglProgramUniform2dEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform2dv(UInt32 program, Int32 location, Int32 count, double* value);
			[ThreadStatic]
			internal static glProgramUniform2dv pglProgramUniform2dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform2dvEXT(UInt32 program, Int32 location, Int32 count, double* value);
			[ThreadStatic]
			internal static glProgramUniform2dvEXT pglProgramUniform2dvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform2f(UInt32 program, Int32 location, float v0, float v1);
			[ThreadStatic]
			internal static glProgramUniform2f pglProgramUniform2f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform2fEXT(UInt32 program, Int32 location, float v0, float v1);
			[ThreadStatic]
			internal static glProgramUniform2fEXT pglProgramUniform2fEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform2fv(UInt32 program, Int32 location, Int32 count, float* value);
			[ThreadStatic]
			internal static glProgramUniform2fv pglProgramUniform2fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform2fvEXT(UInt32 program, Int32 location, Int32 count, float* value);
			[ThreadStatic]
			internal static glProgramUniform2fvEXT pglProgramUniform2fvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform2i(UInt32 program, Int32 location, Int32 v0, Int32 v1);
			[ThreadStatic]
			internal static glProgramUniform2i pglProgramUniform2i;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform2i64NV(UInt32 program, Int32 location, Int64 x, Int64 y);
			[ThreadStatic]
			internal static glProgramUniform2i64NV pglProgramUniform2i64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform2i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);
			[ThreadStatic]
			internal static glProgramUniform2i64vNV pglProgramUniform2i64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform2iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1);
			[ThreadStatic]
			internal static glProgramUniform2iEXT pglProgramUniform2iEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform2iv(UInt32 program, Int32 location, Int32 count, Int32* value);
			[ThreadStatic]
			internal static glProgramUniform2iv pglProgramUniform2iv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform2ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
			[ThreadStatic]
			internal static glProgramUniform2ivEXT pglProgramUniform2ivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform2ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1);
			[ThreadStatic]
			internal static glProgramUniform2ui pglProgramUniform2ui;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform2ui64NV(UInt32 program, Int32 location, UInt64 x, UInt64 y);
			[ThreadStatic]
			internal static glProgramUniform2ui64NV pglProgramUniform2ui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform2ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);
			[ThreadStatic]
			internal static glProgramUniform2ui64vNV pglProgramUniform2ui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform2uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1);
			[ThreadStatic]
			internal static glProgramUniform2uiEXT pglProgramUniform2uiEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform2uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
			[ThreadStatic]
			internal static glProgramUniform2uiv pglProgramUniform2uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform2uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
			[ThreadStatic]
			internal static glProgramUniform2uivEXT pglProgramUniform2uivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform3d(UInt32 program, Int32 location, double v0, double v1, double v2);
			[ThreadStatic]
			internal static glProgramUniform3d pglProgramUniform3d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform3dEXT(UInt32 program, Int32 location, double x, double y, double z);
			[ThreadStatic]
			internal static glProgramUniform3dEXT pglProgramUniform3dEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform3dv(UInt32 program, Int32 location, Int32 count, double* value);
			[ThreadStatic]
			internal static glProgramUniform3dv pglProgramUniform3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform3dvEXT(UInt32 program, Int32 location, Int32 count, double* value);
			[ThreadStatic]
			internal static glProgramUniform3dvEXT pglProgramUniform3dvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform3f(UInt32 program, Int32 location, float v0, float v1, float v2);
			[ThreadStatic]
			internal static glProgramUniform3f pglProgramUniform3f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform3fEXT(UInt32 program, Int32 location, float v0, float v1, float v2);
			[ThreadStatic]
			internal static glProgramUniform3fEXT pglProgramUniform3fEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform3fv(UInt32 program, Int32 location, Int32 count, float* value);
			[ThreadStatic]
			internal static glProgramUniform3fv pglProgramUniform3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform3fvEXT(UInt32 program, Int32 location, Int32 count, float* value);
			[ThreadStatic]
			internal static glProgramUniform3fvEXT pglProgramUniform3fvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform3i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);
			[ThreadStatic]
			internal static glProgramUniform3i pglProgramUniform3i;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform3i64NV(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z);
			[ThreadStatic]
			internal static glProgramUniform3i64NV pglProgramUniform3i64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform3i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);
			[ThreadStatic]
			internal static glProgramUniform3i64vNV pglProgramUniform3i64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform3iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);
			[ThreadStatic]
			internal static glProgramUniform3iEXT pglProgramUniform3iEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform3iv(UInt32 program, Int32 location, Int32 count, Int32* value);
			[ThreadStatic]
			internal static glProgramUniform3iv pglProgramUniform3iv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform3ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
			[ThreadStatic]
			internal static glProgramUniform3ivEXT pglProgramUniform3ivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform3ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
			[ThreadStatic]
			internal static glProgramUniform3ui pglProgramUniform3ui;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform3ui64NV(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z);
			[ThreadStatic]
			internal static glProgramUniform3ui64NV pglProgramUniform3ui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform3ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);
			[ThreadStatic]
			internal static glProgramUniform3ui64vNV pglProgramUniform3ui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform3uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
			[ThreadStatic]
			internal static glProgramUniform3uiEXT pglProgramUniform3uiEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform3uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
			[ThreadStatic]
			internal static glProgramUniform3uiv pglProgramUniform3uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform3uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
			[ThreadStatic]
			internal static glProgramUniform3uivEXT pglProgramUniform3uivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform4d(UInt32 program, Int32 location, double v0, double v1, double v2, double v3);
			[ThreadStatic]
			internal static glProgramUniform4d pglProgramUniform4d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform4dEXT(UInt32 program, Int32 location, double x, double y, double z, double w);
			[ThreadStatic]
			internal static glProgramUniform4dEXT pglProgramUniform4dEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform4dv(UInt32 program, Int32 location, Int32 count, double* value);
			[ThreadStatic]
			internal static glProgramUniform4dv pglProgramUniform4dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform4dvEXT(UInt32 program, Int32 location, Int32 count, double* value);
			[ThreadStatic]
			internal static glProgramUniform4dvEXT pglProgramUniform4dvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform4f(UInt32 program, Int32 location, float v0, float v1, float v2, float v3);
			[ThreadStatic]
			internal static glProgramUniform4f pglProgramUniform4f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform4fEXT(UInt32 program, Int32 location, float v0, float v1, float v2, float v3);
			[ThreadStatic]
			internal static glProgramUniform4fEXT pglProgramUniform4fEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform4fv(UInt32 program, Int32 location, Int32 count, float* value);
			[ThreadStatic]
			internal static glProgramUniform4fv pglProgramUniform4fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform4fvEXT(UInt32 program, Int32 location, Int32 count, float* value);
			[ThreadStatic]
			internal static glProgramUniform4fvEXT pglProgramUniform4fvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform4i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
			[ThreadStatic]
			internal static glProgramUniform4i pglProgramUniform4i;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform4i64NV(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z, Int64 w);
			[ThreadStatic]
			internal static glProgramUniform4i64NV pglProgramUniform4i64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform4i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);
			[ThreadStatic]
			internal static glProgramUniform4i64vNV pglProgramUniform4i64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform4iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
			[ThreadStatic]
			internal static glProgramUniform4iEXT pglProgramUniform4iEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform4iv(UInt32 program, Int32 location, Int32 count, Int32* value);
			[ThreadStatic]
			internal static glProgramUniform4iv pglProgramUniform4iv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform4ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
			[ThreadStatic]
			internal static glProgramUniform4ivEXT pglProgramUniform4ivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform4ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
			[ThreadStatic]
			internal static glProgramUniform4ui pglProgramUniform4ui;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform4ui64NV(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);
			[ThreadStatic]
			internal static glProgramUniform4ui64NV pglProgramUniform4ui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform4ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);
			[ThreadStatic]
			internal static glProgramUniform4ui64vNV pglProgramUniform4ui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform4uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
			[ThreadStatic]
			internal static glProgramUniform4uiEXT pglProgramUniform4uiEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform4uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
			[ThreadStatic]
			internal static glProgramUniform4uiv pglProgramUniform4uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform4uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
			[ThreadStatic]
			internal static glProgramUniform4uivEXT pglProgramUniform4uivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniformHandleui64ARB(UInt32 program, Int32 location, UInt64 value);
			[ThreadStatic]
			internal static glProgramUniformHandleui64ARB pglProgramUniformHandleui64ARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniformHandleui64NV(UInt32 program, Int32 location, UInt64 value);
			[ThreadStatic]
			internal static glProgramUniformHandleui64NV pglProgramUniformHandleui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformHandleui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* values);
			[ThreadStatic]
			internal static glProgramUniformHandleui64vARB pglProgramUniformHandleui64vARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformHandleui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* values);
			[ThreadStatic]
			internal static glProgramUniformHandleui64vNV pglProgramUniformHandleui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix2dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix2dv pglProgramUniformMatrix2dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix2dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix2dvEXT pglProgramUniformMatrix2dvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix2fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix2fv pglProgramUniformMatrix2fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix2fvEXT pglProgramUniformMatrix2fvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix2x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix2x3dv pglProgramUniformMatrix2x3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix2x3dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix2x3dvEXT pglProgramUniformMatrix2x3dvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix2x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix2x3fv pglProgramUniformMatrix2x3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix2x3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix2x3fvEXT pglProgramUniformMatrix2x3fvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix2x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix2x4dv pglProgramUniformMatrix2x4dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix2x4dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix2x4dvEXT pglProgramUniformMatrix2x4dvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix2x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix2x4fv pglProgramUniformMatrix2x4fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix2x4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix2x4fvEXT pglProgramUniformMatrix2x4fvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix3dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix3dv pglProgramUniformMatrix3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix3dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix3dvEXT pglProgramUniformMatrix3dvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix3fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix3fv pglProgramUniformMatrix3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix3fvEXT pglProgramUniformMatrix3fvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix3x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix3x2dv pglProgramUniformMatrix3x2dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix3x2dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix3x2dvEXT pglProgramUniformMatrix3x2dvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix3x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix3x2fv pglProgramUniformMatrix3x2fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix3x2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix3x2fvEXT pglProgramUniformMatrix3x2fvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix3x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix3x4dv pglProgramUniformMatrix3x4dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix3x4dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix3x4dvEXT pglProgramUniformMatrix3x4dvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix3x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix3x4fv pglProgramUniformMatrix3x4fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix3x4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix3x4fvEXT pglProgramUniformMatrix3x4fvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix4dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix4dv pglProgramUniformMatrix4dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix4dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix4dvEXT pglProgramUniformMatrix4dvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix4fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix4fv pglProgramUniformMatrix4fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix4fvEXT pglProgramUniformMatrix4fvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix4x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix4x2dv pglProgramUniformMatrix4x2dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix4x2dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix4x2dvEXT pglProgramUniformMatrix4x2dvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix4x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix4x2fv pglProgramUniformMatrix4x2fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix4x2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix4x2fvEXT pglProgramUniformMatrix4x2fvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix4x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix4x3dv pglProgramUniformMatrix4x3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix4x3dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix4x3dvEXT pglProgramUniformMatrix4x3dvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix4x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix4x3fv pglProgramUniformMatrix4x3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformMatrix4x3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glProgramUniformMatrix4x3fvEXT pglProgramUniformMatrix4x3fvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniformui64NV(UInt32 program, Int32 location, UInt64 value);
			[ThreadStatic]
			internal static glProgramUniformui64NV pglProgramUniformui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);
			[ThreadStatic]
			internal static glProgramUniformui64vNV pglProgramUniformui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramVertexLimitNV(int target, Int32 limit);
			[ThreadStatic]
			internal static glProgramVertexLimitNV pglProgramVertexLimitNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProvokingVertex(int provokeMode);
			[ThreadStatic]
			internal static glProvokingVertex pglProvokingVertex;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProvokingVertexEXT(int provokeMode);
			[ThreadStatic]
			internal static glProvokingVertexEXT pglProvokingVertexEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPushAttrib(uint mask);
			[ThreadStatic]
			internal static glPushAttrib pglPushAttrib;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPushClientAttrib(uint mask);
			[ThreadStatic]
			internal static glPushClientAttrib pglPushClientAttrib;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPushClientAttribDefaultEXT(uint mask);
			[ThreadStatic]
			internal static glPushClientAttribDefaultEXT pglPushClientAttribDefaultEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPushDebugGroup(int source, UInt32 id, Int32 length, String message);
			[ThreadStatic]
			internal static glPushDebugGroup pglPushDebugGroup;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPushGroupMarkerEXT(Int32 length, String marker);
			[ThreadStatic]
			internal static glPushGroupMarkerEXT pglPushGroupMarkerEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPushMatrix();
			[ThreadStatic]
			internal static glPushMatrix pglPushMatrix;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPushName(UInt32 name);
			[ThreadStatic]
			internal static glPushName pglPushName;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glQueryCounter(UInt32 id, int target);
			[ThreadStatic]
			internal static glQueryCounter pglQueryCounter;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate uint glQueryMatrixxOES(IntPtr* mantissa, Int32* exponent);
			[ThreadStatic]
			internal static glQueryMatrixxOES pglQueryMatrixxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glQueryObjectParameteruiAMD(int target, UInt32 id, int pname, UInt32 param);
			[ThreadStatic]
			internal static glQueryObjectParameteruiAMD pglQueryObjectParameteruiAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos2d(double x, double y);
			[ThreadStatic]
			internal static glRasterPos2d pglRasterPos2d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos2dv(double* v);
			[ThreadStatic]
			internal static glRasterPos2dv pglRasterPos2dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos2f(float x, float y);
			[ThreadStatic]
			internal static glRasterPos2f pglRasterPos2f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos2fv(float* v);
			[ThreadStatic]
			internal static glRasterPos2fv pglRasterPos2fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos2i(Int32 x, Int32 y);
			[ThreadStatic]
			internal static glRasterPos2i pglRasterPos2i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos2iv(Int32* v);
			[ThreadStatic]
			internal static glRasterPos2iv pglRasterPos2iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos2s(Int16 x, Int16 y);
			[ThreadStatic]
			internal static glRasterPos2s pglRasterPos2s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos2sv(Int16* v);
			[ThreadStatic]
			internal static glRasterPos2sv pglRasterPos2sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos2xOES(IntPtr x, IntPtr y);
			[ThreadStatic]
			internal static glRasterPos2xOES pglRasterPos2xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos2xvOES(IntPtr* coords);
			[ThreadStatic]
			internal static glRasterPos2xvOES pglRasterPos2xvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos3d(double x, double y, double z);
			[ThreadStatic]
			internal static glRasterPos3d pglRasterPos3d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos3dv(double* v);
			[ThreadStatic]
			internal static glRasterPos3dv pglRasterPos3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos3f(float x, float y, float z);
			[ThreadStatic]
			internal static glRasterPos3f pglRasterPos3f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos3fv(float* v);
			[ThreadStatic]
			internal static glRasterPos3fv pglRasterPos3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos3i(Int32 x, Int32 y, Int32 z);
			[ThreadStatic]
			internal static glRasterPos3i pglRasterPos3i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos3iv(Int32* v);
			[ThreadStatic]
			internal static glRasterPos3iv pglRasterPos3iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos3s(Int16 x, Int16 y, Int16 z);
			[ThreadStatic]
			internal static glRasterPos3s pglRasterPos3s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos3sv(Int16* v);
			[ThreadStatic]
			internal static glRasterPos3sv pglRasterPos3sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos3xOES(IntPtr x, IntPtr y, IntPtr z);
			[ThreadStatic]
			internal static glRasterPos3xOES pglRasterPos3xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos3xvOES(IntPtr* coords);
			[ThreadStatic]
			internal static glRasterPos3xvOES pglRasterPos3xvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos4d(double x, double y, double z, double w);
			[ThreadStatic]
			internal static glRasterPos4d pglRasterPos4d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos4dv(double* v);
			[ThreadStatic]
			internal static glRasterPos4dv pglRasterPos4dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos4f(float x, float y, float z, float w);
			[ThreadStatic]
			internal static glRasterPos4f pglRasterPos4f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos4fv(float* v);
			[ThreadStatic]
			internal static glRasterPos4fv pglRasterPos4fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos4i(Int32 x, Int32 y, Int32 z, Int32 w);
			[ThreadStatic]
			internal static glRasterPos4i pglRasterPos4i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos4iv(Int32* v);
			[ThreadStatic]
			internal static glRasterPos4iv pglRasterPos4iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos4s(Int16 x, Int16 y, Int16 z, Int16 w);
			[ThreadStatic]
			internal static glRasterPos4s pglRasterPos4s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos4sv(Int16* v);
			[ThreadStatic]
			internal static glRasterPos4sv pglRasterPos4sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos4xOES(IntPtr x, IntPtr y, IntPtr z, IntPtr w);
			[ThreadStatic]
			internal static glRasterPos4xOES pglRasterPos4xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos4xvOES(IntPtr* coords);
			[ThreadStatic]
			internal static glRasterPos4xvOES pglRasterPos4xvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReadBuffer(int src);
			[ThreadStatic]
			internal static glReadBuffer pglReadBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReadInstrumentsSGIX(Int32 marker);
			[ThreadStatic]
			internal static glReadInstrumentsSGIX pglReadInstrumentsSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glReadPixels pglReadPixels;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReadnPixels(Int32 x, Int32 y, Int32 width, Int32 height, int format, int type, Int32 bufSize, IntPtr data);
			[ThreadStatic]
			internal static glReadnPixels pglReadnPixels;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReadnPixelsARB(Int32 x, Int32 y, Int32 width, Int32 height, int format, int type, Int32 bufSize, IntPtr data);
			[ThreadStatic]
			internal static glReadnPixelsARB pglReadnPixelsARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRectd(double x1, double y1, double x2, double y2);
			[ThreadStatic]
			internal static glRectd pglRectd;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRectdv(double* v1, double* v2);
			[ThreadStatic]
			internal static glRectdv pglRectdv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRectf(float x1, float y1, float x2, float y2);
			[ThreadStatic]
			internal static glRectf pglRectf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRectfv(float* v1, float* v2);
			[ThreadStatic]
			internal static glRectfv pglRectfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRecti(Int32 x1, Int32 y1, Int32 x2, Int32 y2);
			[ThreadStatic]
			internal static glRecti pglRecti;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRectiv(Int32* v1, Int32* v2);
			[ThreadStatic]
			internal static glRectiv pglRectiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRects(Int16 x1, Int16 y1, Int16 x2, Int16 y2);
			[ThreadStatic]
			internal static glRects pglRects;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRectsv(Int16* v1, Int16* v2);
			[ThreadStatic]
			internal static glRectsv pglRectsv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRectxOES(IntPtr x1, IntPtr y1, IntPtr x2, IntPtr y2);
			[ThreadStatic]
			internal static glRectxOES pglRectxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRectxvOES(IntPtr* v1, IntPtr* v2);
			[ThreadStatic]
			internal static glRectxvOES pglRectxvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReferencePlaneSGIX(double* equation);
			[ThreadStatic]
			internal static glReferencePlaneSGIX pglReferencePlaneSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReleaseShaderCompiler();
			[ThreadStatic]
			internal static glReleaseShaderCompiler pglReleaseShaderCompiler;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glRenderMode(int mode);
			[ThreadStatic]
			internal static glRenderMode pglRenderMode;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRenderbufferStorage(int target, int internalformat, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glRenderbufferStorage pglRenderbufferStorage;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRenderbufferStorageEXT(int target, int internalformat, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glRenderbufferStorageEXT pglRenderbufferStorageEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRenderbufferStorageMultisample(int target, Int32 samples, int internalformat, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glRenderbufferStorageMultisample pglRenderbufferStorageMultisample;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRenderbufferStorageMultisampleCoverageNV(int target, Int32 coverageSamples, Int32 colorSamples, int internalformat, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glRenderbufferStorageMultisampleCoverageNV pglRenderbufferStorageMultisampleCoverageNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRenderbufferStorageMultisampleEXT(int target, Int32 samples, int internalformat, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glRenderbufferStorageMultisampleEXT pglRenderbufferStorageMultisampleEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReplacementCodePointerSUN(int type, Int32 stride, IntPtr* pointer);
			[ThreadStatic]
			internal static glReplacementCodePointerSUN pglReplacementCodePointerSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReplacementCodeubSUN(byte code);
			[ThreadStatic]
			internal static glReplacementCodeubSUN pglReplacementCodeubSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReplacementCodeubvSUN(byte* code);
			[ThreadStatic]
			internal static glReplacementCodeubvSUN pglReplacementCodeubvSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReplacementCodeuiColor3fVertex3fSUN(UInt32 rc, float r, float g, float b, float x, float y, float z);
			[ThreadStatic]
			internal static glReplacementCodeuiColor3fVertex3fSUN pglReplacementCodeuiColor3fVertex3fSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReplacementCodeuiColor3fVertex3fvSUN(UInt32* rc, float* c, float* v);
			[ThreadStatic]
			internal static glReplacementCodeuiColor3fVertex3fvSUN pglReplacementCodeuiColor3fVertex3fvSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReplacementCodeuiColor4fNormal3fVertex3fSUN(UInt32 rc, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
			[ThreadStatic]
			internal static glReplacementCodeuiColor4fNormal3fVertex3fSUN pglReplacementCodeuiColor4fNormal3fVertex3fSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReplacementCodeuiColor4fNormal3fVertex3fvSUN(UInt32* rc, float* c, float* n, float* v);
			[ThreadStatic]
			internal static glReplacementCodeuiColor4fNormal3fVertex3fvSUN pglReplacementCodeuiColor4fNormal3fVertex3fvSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReplacementCodeuiColor4ubVertex3fSUN(UInt32 rc, byte r, byte g, byte b, byte a, float x, float y, float z);
			[ThreadStatic]
			internal static glReplacementCodeuiColor4ubVertex3fSUN pglReplacementCodeuiColor4ubVertex3fSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReplacementCodeuiColor4ubVertex3fvSUN(UInt32* rc, byte* c, float* v);
			[ThreadStatic]
			internal static glReplacementCodeuiColor4ubVertex3fvSUN pglReplacementCodeuiColor4ubVertex3fvSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReplacementCodeuiNormal3fVertex3fSUN(UInt32 rc, float nx, float ny, float nz, float x, float y, float z);
			[ThreadStatic]
			internal static glReplacementCodeuiNormal3fVertex3fSUN pglReplacementCodeuiNormal3fVertex3fSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReplacementCodeuiNormal3fVertex3fvSUN(UInt32* rc, float* n, float* v);
			[ThreadStatic]
			internal static glReplacementCodeuiNormal3fVertex3fvSUN pglReplacementCodeuiNormal3fVertex3fvSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReplacementCodeuiSUN(UInt32 code);
			[ThreadStatic]
			internal static glReplacementCodeuiSUN pglReplacementCodeuiSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(UInt32 rc, float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
			[ThreadStatic]
			internal static glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN pglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(UInt32* rc, float* tc, float* c, float* n, float* v);
			[ThreadStatic]
			internal static glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN pglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(UInt32 rc, float s, float t, float nx, float ny, float nz, float x, float y, float z);
			[ThreadStatic]
			internal static glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN pglReplacementCodeuiTexCoord2fNormal3fVertex3fSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(UInt32* rc, float* tc, float* n, float* v);
			[ThreadStatic]
			internal static glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN pglReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReplacementCodeuiTexCoord2fVertex3fSUN(UInt32 rc, float s, float t, float x, float y, float z);
			[ThreadStatic]
			internal static glReplacementCodeuiTexCoord2fVertex3fSUN pglReplacementCodeuiTexCoord2fVertex3fSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReplacementCodeuiTexCoord2fVertex3fvSUN(UInt32* rc, float* tc, float* v);
			[ThreadStatic]
			internal static glReplacementCodeuiTexCoord2fVertex3fvSUN pglReplacementCodeuiTexCoord2fVertex3fvSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReplacementCodeuiVertex3fSUN(UInt32 rc, float x, float y, float z);
			[ThreadStatic]
			internal static glReplacementCodeuiVertex3fSUN pglReplacementCodeuiVertex3fSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReplacementCodeuiVertex3fvSUN(UInt32* rc, float* v);
			[ThreadStatic]
			internal static glReplacementCodeuiVertex3fvSUN pglReplacementCodeuiVertex3fvSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReplacementCodeuivSUN(UInt32* code);
			[ThreadStatic]
			internal static glReplacementCodeuivSUN pglReplacementCodeuivSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReplacementCodeusSUN(UInt16 code);
			[ThreadStatic]
			internal static glReplacementCodeusSUN pglReplacementCodeusSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReplacementCodeusvSUN(UInt16* code);
			[ThreadStatic]
			internal static glReplacementCodeusvSUN pglReplacementCodeusvSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRequestResidentProgramsNV(Int32 n, UInt32* programs);
			[ThreadStatic]
			internal static glRequestResidentProgramsNV pglRequestResidentProgramsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glResetHistogram(int target);
			[ThreadStatic]
			internal static glResetHistogram pglResetHistogram;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glResetHistogramEXT(int target);
			[ThreadStatic]
			internal static glResetHistogramEXT pglResetHistogramEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glResetMinmax(int target);
			[ThreadStatic]
			internal static glResetMinmax pglResetMinmax;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glResetMinmaxEXT(int target);
			[ThreadStatic]
			internal static glResetMinmaxEXT pglResetMinmaxEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glResizeBuffersMESA();
			[ThreadStatic]
			internal static glResizeBuffersMESA pglResizeBuffersMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glResumeTransformFeedback();
			[ThreadStatic]
			internal static glResumeTransformFeedback pglResumeTransformFeedback;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glResumeTransformFeedbackNV();
			[ThreadStatic]
			internal static glResumeTransformFeedbackNV pglResumeTransformFeedbackNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRotated(double angle, double x, double y, double z);
			[ThreadStatic]
			internal static glRotated pglRotated;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRotatef(float angle, float x, float y, float z);
			[ThreadStatic]
			internal static glRotatef pglRotatef;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRotatexOES(IntPtr angle, IntPtr x, IntPtr y, IntPtr z);
			[ThreadStatic]
			internal static glRotatexOES pglRotatexOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSampleCoverage(float value, bool invert);
			[ThreadStatic]
			internal static glSampleCoverage pglSampleCoverage;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSampleCoverageARB(float value, bool invert);
			[ThreadStatic]
			internal static glSampleCoverageARB pglSampleCoverageARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSampleCoverageOES(IntPtr value, bool invert);
			[ThreadStatic]
			internal static glSampleCoverageOES pglSampleCoverageOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSampleMapATI(UInt32 dst, UInt32 interp, int swizzle);
			[ThreadStatic]
			internal static glSampleMapATI pglSampleMapATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSampleMaskEXT(float value, bool invert);
			[ThreadStatic]
			internal static glSampleMaskEXT pglSampleMaskEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSampleMaskIndexedNV(UInt32 index, uint mask);
			[ThreadStatic]
			internal static glSampleMaskIndexedNV pglSampleMaskIndexedNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSampleMaskSGIS(float value, bool invert);
			[ThreadStatic]
			internal static glSampleMaskSGIS pglSampleMaskSGIS;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSampleMaski(UInt32 maskNumber, uint mask);
			[ThreadStatic]
			internal static glSampleMaski pglSampleMaski;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSamplePatternEXT(int pattern);
			[ThreadStatic]
			internal static glSamplePatternEXT pglSamplePatternEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSamplePatternSGIS(int pattern);
			[ThreadStatic]
			internal static glSamplePatternSGIS pglSamplePatternSGIS;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSamplerParameterIiv(UInt32 sampler, int pname, Int32* param);
			[ThreadStatic]
			internal static glSamplerParameterIiv pglSamplerParameterIiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSamplerParameterIuiv(UInt32 sampler, int pname, UInt32* param);
			[ThreadStatic]
			internal static glSamplerParameterIuiv pglSamplerParameterIuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSamplerParameterf(UInt32 sampler, int pname, float param);
			[ThreadStatic]
			internal static glSamplerParameterf pglSamplerParameterf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSamplerParameterfv(UInt32 sampler, int pname, float* param);
			[ThreadStatic]
			internal static glSamplerParameterfv pglSamplerParameterfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSamplerParameteri(UInt32 sampler, int pname, Int32 param);
			[ThreadStatic]
			internal static glSamplerParameteri pglSamplerParameteri;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSamplerParameteriv(UInt32 sampler, int pname, Int32* param);
			[ThreadStatic]
			internal static glSamplerParameteriv pglSamplerParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glScaled(double x, double y, double z);
			[ThreadStatic]
			internal static glScaled pglScaled;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glScalef(float x, float y, float z);
			[ThreadStatic]
			internal static glScalef pglScalef;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glScalexOES(IntPtr x, IntPtr y, IntPtr z);
			[ThreadStatic]
			internal static glScalexOES pglScalexOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glScissor(Int32 x, Int32 y, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glScissor pglScissor;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glScissorArrayv(UInt32 first, Int32 count, Int32* v);
			[ThreadStatic]
			internal static glScissorArrayv pglScissorArrayv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glScissorIndexed pglScissorIndexed;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glScissorIndexedv(UInt32 index, Int32* v);
			[ThreadStatic]
			internal static glScissorIndexedv pglScissorIndexedv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3b(sbyte red, sbyte green, sbyte blue);
			[ThreadStatic]
			internal static glSecondaryColor3b pglSecondaryColor3b;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3bEXT(sbyte red, sbyte green, sbyte blue);
			[ThreadStatic]
			internal static glSecondaryColor3bEXT pglSecondaryColor3bEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3bv(sbyte* v);
			[ThreadStatic]
			internal static glSecondaryColor3bv pglSecondaryColor3bv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3bvEXT(sbyte* v);
			[ThreadStatic]
			internal static glSecondaryColor3bvEXT pglSecondaryColor3bvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3d(double red, double green, double blue);
			[ThreadStatic]
			internal static glSecondaryColor3d pglSecondaryColor3d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3dEXT(double red, double green, double blue);
			[ThreadStatic]
			internal static glSecondaryColor3dEXT pglSecondaryColor3dEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3dv(double* v);
			[ThreadStatic]
			internal static glSecondaryColor3dv pglSecondaryColor3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3dvEXT(double* v);
			[ThreadStatic]
			internal static glSecondaryColor3dvEXT pglSecondaryColor3dvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3f(float red, float green, float blue);
			[ThreadStatic]
			internal static glSecondaryColor3f pglSecondaryColor3f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3fEXT(float red, float green, float blue);
			[ThreadStatic]
			internal static glSecondaryColor3fEXT pglSecondaryColor3fEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3fv(float* v);
			[ThreadStatic]
			internal static glSecondaryColor3fv pglSecondaryColor3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3fvEXT(float* v);
			[ThreadStatic]
			internal static glSecondaryColor3fvEXT pglSecondaryColor3fvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3hNV(UInt16 red, UInt16 green, UInt16 blue);
			[ThreadStatic]
			internal static glSecondaryColor3hNV pglSecondaryColor3hNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3hvNV(UInt16* v);
			[ThreadStatic]
			internal static glSecondaryColor3hvNV pglSecondaryColor3hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3i(Int32 red, Int32 green, Int32 blue);
			[ThreadStatic]
			internal static glSecondaryColor3i pglSecondaryColor3i;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3iEXT(Int32 red, Int32 green, Int32 blue);
			[ThreadStatic]
			internal static glSecondaryColor3iEXT pglSecondaryColor3iEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3iv(Int32* v);
			[ThreadStatic]
			internal static glSecondaryColor3iv pglSecondaryColor3iv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3ivEXT(Int32* v);
			[ThreadStatic]
			internal static glSecondaryColor3ivEXT pglSecondaryColor3ivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3s(Int16 red, Int16 green, Int16 blue);
			[ThreadStatic]
			internal static glSecondaryColor3s pglSecondaryColor3s;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3sEXT(Int16 red, Int16 green, Int16 blue);
			[ThreadStatic]
			internal static glSecondaryColor3sEXT pglSecondaryColor3sEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3sv(Int16* v);
			[ThreadStatic]
			internal static glSecondaryColor3sv pglSecondaryColor3sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3svEXT(Int16* v);
			[ThreadStatic]
			internal static glSecondaryColor3svEXT pglSecondaryColor3svEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3ub(byte red, byte green, byte blue);
			[ThreadStatic]
			internal static glSecondaryColor3ub pglSecondaryColor3ub;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3ubEXT(byte red, byte green, byte blue);
			[ThreadStatic]
			internal static glSecondaryColor3ubEXT pglSecondaryColor3ubEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3ubv(byte* v);
			[ThreadStatic]
			internal static glSecondaryColor3ubv pglSecondaryColor3ubv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3ubvEXT(byte* v);
			[ThreadStatic]
			internal static glSecondaryColor3ubvEXT pglSecondaryColor3ubvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3ui(UInt32 red, UInt32 green, UInt32 blue);
			[ThreadStatic]
			internal static glSecondaryColor3ui pglSecondaryColor3ui;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3uiEXT(UInt32 red, UInt32 green, UInt32 blue);
			[ThreadStatic]
			internal static glSecondaryColor3uiEXT pglSecondaryColor3uiEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3uiv(UInt32* v);
			[ThreadStatic]
			internal static glSecondaryColor3uiv pglSecondaryColor3uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3uivEXT(UInt32* v);
			[ThreadStatic]
			internal static glSecondaryColor3uivEXT pglSecondaryColor3uivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3us(UInt16 red, UInt16 green, UInt16 blue);
			[ThreadStatic]
			internal static glSecondaryColor3us pglSecondaryColor3us;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3usEXT(UInt16 red, UInt16 green, UInt16 blue);
			[ThreadStatic]
			internal static glSecondaryColor3usEXT pglSecondaryColor3usEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3usv(UInt16* v);
			[ThreadStatic]
			internal static glSecondaryColor3usv pglSecondaryColor3usv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3usvEXT(UInt16* v);
			[ThreadStatic]
			internal static glSecondaryColor3usvEXT pglSecondaryColor3usvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColorFormatNV(Int32 size, int type, Int32 stride);
			[ThreadStatic]
			internal static glSecondaryColorFormatNV pglSecondaryColorFormatNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColorP3ui(int type, UInt32 color);
			[ThreadStatic]
			internal static glSecondaryColorP3ui pglSecondaryColorP3ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColorP3uiv(int type, UInt32* color);
			[ThreadStatic]
			internal static glSecondaryColorP3uiv pglSecondaryColorP3uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColorPointer(Int32 size, int type, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glSecondaryColorPointer pglSecondaryColorPointer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColorPointerEXT(Int32 size, int type, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glSecondaryColorPointerEXT pglSecondaryColorPointerEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColorPointerListIBM(Int32 size, int type, Int32 stride, IntPtr* pointer, Int32 ptrstride);
			[ThreadStatic]
			internal static glSecondaryColorPointerListIBM pglSecondaryColorPointerListIBM;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSelectBuffer(Int32 size, UInt32* buffer);
			[ThreadStatic]
			internal static glSelectBuffer pglSelectBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSelectPerfMonitorCountersAMD(UInt32 monitor, bool enable, UInt32 group, Int32 numCounters, UInt32* counterList);
			[ThreadStatic]
			internal static glSelectPerfMonitorCountersAMD pglSelectPerfMonitorCountersAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSeparableFilter2D(int target, int internalformat, Int32 width, Int32 height, int format, int type, IntPtr row, IntPtr column);
			[ThreadStatic]
			internal static glSeparableFilter2D pglSeparableFilter2D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSeparableFilter2DEXT(int target, int internalformat, Int32 width, Int32 height, int format, int type, IntPtr row, IntPtr column);
			[ThreadStatic]
			internal static glSeparableFilter2DEXT pglSeparableFilter2DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSetFenceAPPLE(UInt32 fence);
			[ThreadStatic]
			internal static glSetFenceAPPLE pglSetFenceAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSetFenceNV(UInt32 fence, int condition);
			[ThreadStatic]
			internal static glSetFenceNV pglSetFenceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSetFragmentShaderConstantATI(UInt32 dst, float* value);
			[ThreadStatic]
			internal static glSetFragmentShaderConstantATI pglSetFragmentShaderConstantATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSetInvariantEXT(UInt32 id, int type, IntPtr addr);
			[ThreadStatic]
			internal static glSetInvariantEXT pglSetInvariantEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSetLocalConstantEXT(UInt32 id, int type, IntPtr addr);
			[ThreadStatic]
			internal static glSetLocalConstantEXT pglSetLocalConstantEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSetMultisamplefvAMD(int pname, UInt32 index, float* val);
			[ThreadStatic]
			internal static glSetMultisamplefvAMD pglSetMultisamplefvAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glShadeModel(int mode);
			[ThreadStatic]
			internal static glShadeModel pglShadeModel;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glShaderBinary(Int32 count, UInt32* shaders, int binaryformat, IntPtr binary, Int32 length);
			[ThreadStatic]
			internal static glShaderBinary pglShaderBinary;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glShaderOp1EXT(int op, UInt32 res, UInt32 arg1);
			[ThreadStatic]
			internal static glShaderOp1EXT pglShaderOp1EXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glShaderOp2EXT(int op, UInt32 res, UInt32 arg1, UInt32 arg2);
			[ThreadStatic]
			internal static glShaderOp2EXT pglShaderOp2EXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glShaderOp3EXT(int op, UInt32 res, UInt32 arg1, UInt32 arg2, UInt32 arg3);
			[ThreadStatic]
			internal static glShaderOp3EXT pglShaderOp3EXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glShaderSource(UInt32 shader, Int32 count, String[] @string, Int32* length);
			[ThreadStatic]
			internal static glShaderSource pglShaderSource;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glShaderSourceARB(UInt32 shaderObj, Int32 count, String[] @string, Int32* length);
			[ThreadStatic]
			internal static glShaderSourceARB pglShaderSourceARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glShaderStorageBlockBinding(UInt32 program, UInt32 storageBlockIndex, UInt32 storageBlockBinding);
			[ThreadStatic]
			internal static glShaderStorageBlockBinding pglShaderStorageBlockBinding;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSharpenTexFuncSGIS(int target, Int32 n, float* points);
			[ThreadStatic]
			internal static glSharpenTexFuncSGIS pglSharpenTexFuncSGIS;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSpriteParameterfSGIX(int pname, float param);
			[ThreadStatic]
			internal static glSpriteParameterfSGIX pglSpriteParameterfSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSpriteParameterfvSGIX(int pname, float* @params);
			[ThreadStatic]
			internal static glSpriteParameterfvSGIX pglSpriteParameterfvSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSpriteParameteriSGIX(int pname, Int32 param);
			[ThreadStatic]
			internal static glSpriteParameteriSGIX pglSpriteParameteriSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSpriteParameterivSGIX(int pname, Int32* @params);
			[ThreadStatic]
			internal static glSpriteParameterivSGIX pglSpriteParameterivSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStartInstrumentsSGIX();
			[ThreadStatic]
			internal static glStartInstrumentsSGIX pglStartInstrumentsSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStencilClearTagEXT(Int32 stencilTagBits, UInt32 stencilClearTag);
			[ThreadStatic]
			internal static glStencilClearTagEXT pglStencilClearTagEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glStencilFillPathInstancedNV(Int32 numPaths, int pathNameType, IntPtr paths, UInt32 pathBase, int fillMode, UInt32 mask, int transformType, float* transformValues);
			[ThreadStatic]
			internal static glStencilFillPathInstancedNV pglStencilFillPathInstancedNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStencilFillPathNV(UInt32 path, int fillMode, UInt32 mask);
			[ThreadStatic]
			internal static glStencilFillPathNV pglStencilFillPathNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStencilFunc(int func, Int32 @ref, UInt32 mask);
			[ThreadStatic]
			internal static glStencilFunc pglStencilFunc;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStencilFuncSeparate(int face, int func, Int32 @ref, UInt32 mask);
			[ThreadStatic]
			internal static glStencilFuncSeparate pglStencilFuncSeparate;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStencilFuncSeparateATI(int frontfunc, int backfunc, Int32 @ref, UInt32 mask);
			[ThreadStatic]
			internal static glStencilFuncSeparateATI pglStencilFuncSeparateATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStencilMask(UInt32 mask);
			[ThreadStatic]
			internal static glStencilMask pglStencilMask;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStencilMaskSeparate(int face, UInt32 mask);
			[ThreadStatic]
			internal static glStencilMaskSeparate pglStencilMaskSeparate;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStencilOp(int fail, int zfail, int zpass);
			[ThreadStatic]
			internal static glStencilOp pglStencilOp;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStencilOpSeparate(int face, int sfail, int dpfail, int dppass);
			[ThreadStatic]
			internal static glStencilOpSeparate pglStencilOpSeparate;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStencilOpSeparateATI(int face, int sfail, int dpfail, int dppass);
			[ThreadStatic]
			internal static glStencilOpSeparateATI pglStencilOpSeparateATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStencilOpValueAMD(int face, UInt32 value);
			[ThreadStatic]
			internal static glStencilOpValueAMD pglStencilOpValueAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glStencilStrokePathInstancedNV(Int32 numPaths, int pathNameType, IntPtr paths, UInt32 pathBase, Int32 reference, UInt32 mask, int transformType, float* transformValues);
			[ThreadStatic]
			internal static glStencilStrokePathInstancedNV pglStencilStrokePathInstancedNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStencilStrokePathNV(UInt32 path, Int32 reference, UInt32 mask);
			[ThreadStatic]
			internal static glStencilStrokePathNV pglStencilStrokePathNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glStencilThenCoverFillPathInstancedNV(Int32 numPaths, int pathNameType, IntPtr paths, UInt32 pathBase, int fillMode, UInt32 mask, int coverMode, int transformType, float* transformValues);
			[ThreadStatic]
			internal static glStencilThenCoverFillPathInstancedNV pglStencilThenCoverFillPathInstancedNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStencilThenCoverFillPathNV(UInt32 path, int fillMode, UInt32 mask, int coverMode);
			[ThreadStatic]
			internal static glStencilThenCoverFillPathNV pglStencilThenCoverFillPathNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glStencilThenCoverStrokePathInstancedNV(Int32 numPaths, int pathNameType, IntPtr paths, UInt32 pathBase, Int32 reference, UInt32 mask, int coverMode, int transformType, float* transformValues);
			[ThreadStatic]
			internal static glStencilThenCoverStrokePathInstancedNV pglStencilThenCoverStrokePathInstancedNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStencilThenCoverStrokePathNV(UInt32 path, Int32 reference, UInt32 mask, int coverMode);
			[ThreadStatic]
			internal static glStencilThenCoverStrokePathNV pglStencilThenCoverStrokePathNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStopInstrumentsSGIX(Int32 marker);
			[ThreadStatic]
			internal static glStopInstrumentsSGIX pglStopInstrumentsSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glStringMarkerGREMEDY(Int32 len, IntPtr @string);
			[ThreadStatic]
			internal static glStringMarkerGREMEDY pglStringMarkerGREMEDY;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSwizzleEXT(UInt32 res, UInt32 @in, int outX, int outY, int outZ, int outW);
			[ThreadStatic]
			internal static glSwizzleEXT pglSwizzleEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSyncTextureINTEL(UInt32 texture);
			[ThreadStatic]
			internal static glSyncTextureINTEL pglSyncTextureINTEL;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTagSampleBufferSGIX();
			[ThreadStatic]
			internal static glTagSampleBufferSGIX pglTagSampleBufferSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTangent3bEXT(sbyte tx, sbyte ty, sbyte tz);
			[ThreadStatic]
			internal static glTangent3bEXT pglTangent3bEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTangent3bvEXT(sbyte* v);
			[ThreadStatic]
			internal static glTangent3bvEXT pglTangent3bvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTangent3dEXT(double tx, double ty, double tz);
			[ThreadStatic]
			internal static glTangent3dEXT pglTangent3dEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTangent3dvEXT(double* v);
			[ThreadStatic]
			internal static glTangent3dvEXT pglTangent3dvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTangent3fEXT(float tx, float ty, float tz);
			[ThreadStatic]
			internal static glTangent3fEXT pglTangent3fEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTangent3fvEXT(float* v);
			[ThreadStatic]
			internal static glTangent3fvEXT pglTangent3fvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTangent3iEXT(Int32 tx, Int32 ty, Int32 tz);
			[ThreadStatic]
			internal static glTangent3iEXT pglTangent3iEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTangent3ivEXT(Int32* v);
			[ThreadStatic]
			internal static glTangent3ivEXT pglTangent3ivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTangent3sEXT(Int16 tx, Int16 ty, Int16 tz);
			[ThreadStatic]
			internal static glTangent3sEXT pglTangent3sEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTangent3svEXT(Int16* v);
			[ThreadStatic]
			internal static glTangent3svEXT pglTangent3svEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTangentPointerEXT(int type, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glTangentPointerEXT pglTangentPointerEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTbufferMask3DFX(UInt32 mask);
			[ThreadStatic]
			internal static glTbufferMask3DFX pglTbufferMask3DFX;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTessellationFactorAMD(float factor);
			[ThreadStatic]
			internal static glTessellationFactorAMD pglTessellationFactorAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTessellationModeAMD(int mode);
			[ThreadStatic]
			internal static glTessellationModeAMD pglTessellationModeAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glTestFenceAPPLE(UInt32 fence);
			[ThreadStatic]
			internal static glTestFenceAPPLE pglTestFenceAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glTestFenceNV(UInt32 fence);
			[ThreadStatic]
			internal static glTestFenceNV pglTestFenceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glTestObjectAPPLE(int @object, UInt32 name);
			[ThreadStatic]
			internal static glTestObjectAPPLE pglTestObjectAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexBuffer(int target, int internalformat, UInt32 buffer);
			[ThreadStatic]
			internal static glTexBuffer pglTexBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexBufferARB(int target, int internalformat, UInt32 buffer);
			[ThreadStatic]
			internal static glTexBufferARB pglTexBufferARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexBufferEXT(int target, int internalformat, UInt32 buffer);
			[ThreadStatic]
			internal static glTexBufferEXT pglTexBufferEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexBufferRange(int target, int internalformat, UInt32 buffer, IntPtr offset, UInt32 size);
			[ThreadStatic]
			internal static glTexBufferRange pglTexBufferRange;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexBumpParameterfvATI(int pname, float* param);
			[ThreadStatic]
			internal static glTexBumpParameterfvATI pglTexBumpParameterfvATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexBumpParameterivATI(int pname, Int32* param);
			[ThreadStatic]
			internal static glTexBumpParameterivATI pglTexBumpParameterivATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord1bOES(sbyte s);
			[ThreadStatic]
			internal static glTexCoord1bOES pglTexCoord1bOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord1bvOES(sbyte* coords);
			[ThreadStatic]
			internal static glTexCoord1bvOES pglTexCoord1bvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord1d(double s);
			[ThreadStatic]
			internal static glTexCoord1d pglTexCoord1d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord1dv(double* v);
			[ThreadStatic]
			internal static glTexCoord1dv pglTexCoord1dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord1f(float s);
			[ThreadStatic]
			internal static glTexCoord1f pglTexCoord1f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord1fv(float* v);
			[ThreadStatic]
			internal static glTexCoord1fv pglTexCoord1fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord1hNV(UInt16 s);
			[ThreadStatic]
			internal static glTexCoord1hNV pglTexCoord1hNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord1hvNV(UInt16* v);
			[ThreadStatic]
			internal static glTexCoord1hvNV pglTexCoord1hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord1i(Int32 s);
			[ThreadStatic]
			internal static glTexCoord1i pglTexCoord1i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord1iv(Int32* v);
			[ThreadStatic]
			internal static glTexCoord1iv pglTexCoord1iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord1s(Int16 s);
			[ThreadStatic]
			internal static glTexCoord1s pglTexCoord1s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord1sv(Int16* v);
			[ThreadStatic]
			internal static glTexCoord1sv pglTexCoord1sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord1xOES(IntPtr s);
			[ThreadStatic]
			internal static glTexCoord1xOES pglTexCoord1xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord1xvOES(IntPtr* coords);
			[ThreadStatic]
			internal static glTexCoord1xvOES pglTexCoord1xvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2bOES(sbyte s, sbyte t);
			[ThreadStatic]
			internal static glTexCoord2bOES pglTexCoord2bOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2bvOES(sbyte* coords);
			[ThreadStatic]
			internal static glTexCoord2bvOES pglTexCoord2bvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2d(double s, double t);
			[ThreadStatic]
			internal static glTexCoord2d pglTexCoord2d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2dv(double* v);
			[ThreadStatic]
			internal static glTexCoord2dv pglTexCoord2dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2f(float s, float t);
			[ThreadStatic]
			internal static glTexCoord2f pglTexCoord2f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2fColor3fVertex3fSUN(float s, float t, float r, float g, float b, float x, float y, float z);
			[ThreadStatic]
			internal static glTexCoord2fColor3fVertex3fSUN pglTexCoord2fColor3fVertex3fSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2fColor3fVertex3fvSUN(float* tc, float* c, float* v);
			[ThreadStatic]
			internal static glTexCoord2fColor3fVertex3fvSUN pglTexCoord2fColor3fVertex3fvSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2fColor4fNormal3fVertex3fSUN(float s, float t, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z);
			[ThreadStatic]
			internal static glTexCoord2fColor4fNormal3fVertex3fSUN pglTexCoord2fColor4fNormal3fVertex3fSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2fColor4fNormal3fVertex3fvSUN(float* tc, float* c, float* n, float* v);
			[ThreadStatic]
			internal static glTexCoord2fColor4fNormal3fVertex3fvSUN pglTexCoord2fColor4fNormal3fVertex3fvSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2fColor4ubVertex3fSUN(float s, float t, byte r, byte g, byte b, byte a, float x, float y, float z);
			[ThreadStatic]
			internal static glTexCoord2fColor4ubVertex3fSUN pglTexCoord2fColor4ubVertex3fSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2fColor4ubVertex3fvSUN(float* tc, byte* c, float* v);
			[ThreadStatic]
			internal static glTexCoord2fColor4ubVertex3fvSUN pglTexCoord2fColor4ubVertex3fvSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2fNormal3fVertex3fSUN(float s, float t, float nx, float ny, float nz, float x, float y, float z);
			[ThreadStatic]
			internal static glTexCoord2fNormal3fVertex3fSUN pglTexCoord2fNormal3fVertex3fSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2fNormal3fVertex3fvSUN(float* tc, float* n, float* v);
			[ThreadStatic]
			internal static glTexCoord2fNormal3fVertex3fvSUN pglTexCoord2fNormal3fVertex3fvSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2fVertex3fSUN(float s, float t, float x, float y, float z);
			[ThreadStatic]
			internal static glTexCoord2fVertex3fSUN pglTexCoord2fVertex3fSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2fVertex3fvSUN(float* tc, float* v);
			[ThreadStatic]
			internal static glTexCoord2fVertex3fvSUN pglTexCoord2fVertex3fvSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2fv(float* v);
			[ThreadStatic]
			internal static glTexCoord2fv pglTexCoord2fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2hNV(UInt16 s, UInt16 t);
			[ThreadStatic]
			internal static glTexCoord2hNV pglTexCoord2hNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2hvNV(UInt16* v);
			[ThreadStatic]
			internal static glTexCoord2hvNV pglTexCoord2hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2i(Int32 s, Int32 t);
			[ThreadStatic]
			internal static glTexCoord2i pglTexCoord2i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2iv(Int32* v);
			[ThreadStatic]
			internal static glTexCoord2iv pglTexCoord2iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2s(Int16 s, Int16 t);
			[ThreadStatic]
			internal static glTexCoord2s pglTexCoord2s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2sv(Int16* v);
			[ThreadStatic]
			internal static glTexCoord2sv pglTexCoord2sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2xOES(IntPtr s, IntPtr t);
			[ThreadStatic]
			internal static glTexCoord2xOES pglTexCoord2xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2xvOES(IntPtr* coords);
			[ThreadStatic]
			internal static glTexCoord2xvOES pglTexCoord2xvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord3bOES(sbyte s, sbyte t, sbyte r);
			[ThreadStatic]
			internal static glTexCoord3bOES pglTexCoord3bOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord3bvOES(sbyte* coords);
			[ThreadStatic]
			internal static glTexCoord3bvOES pglTexCoord3bvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord3d(double s, double t, double r);
			[ThreadStatic]
			internal static glTexCoord3d pglTexCoord3d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord3dv(double* v);
			[ThreadStatic]
			internal static glTexCoord3dv pglTexCoord3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord3f(float s, float t, float r);
			[ThreadStatic]
			internal static glTexCoord3f pglTexCoord3f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord3fv(float* v);
			[ThreadStatic]
			internal static glTexCoord3fv pglTexCoord3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord3hNV(UInt16 s, UInt16 t, UInt16 r);
			[ThreadStatic]
			internal static glTexCoord3hNV pglTexCoord3hNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord3hvNV(UInt16* v);
			[ThreadStatic]
			internal static glTexCoord3hvNV pglTexCoord3hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord3i(Int32 s, Int32 t, Int32 r);
			[ThreadStatic]
			internal static glTexCoord3i pglTexCoord3i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord3iv(Int32* v);
			[ThreadStatic]
			internal static glTexCoord3iv pglTexCoord3iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord3s(Int16 s, Int16 t, Int16 r);
			[ThreadStatic]
			internal static glTexCoord3s pglTexCoord3s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord3sv(Int16* v);
			[ThreadStatic]
			internal static glTexCoord3sv pglTexCoord3sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord3xOES(IntPtr s, IntPtr t, IntPtr r);
			[ThreadStatic]
			internal static glTexCoord3xOES pglTexCoord3xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord3xvOES(IntPtr* coords);
			[ThreadStatic]
			internal static glTexCoord3xvOES pglTexCoord3xvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord4bOES(sbyte s, sbyte t, sbyte r, sbyte q);
			[ThreadStatic]
			internal static glTexCoord4bOES pglTexCoord4bOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord4bvOES(sbyte* coords);
			[ThreadStatic]
			internal static glTexCoord4bvOES pglTexCoord4bvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord4d(double s, double t, double r, double q);
			[ThreadStatic]
			internal static glTexCoord4d pglTexCoord4d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord4dv(double* v);
			[ThreadStatic]
			internal static glTexCoord4dv pglTexCoord4dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord4f(float s, float t, float r, float q);
			[ThreadStatic]
			internal static glTexCoord4f pglTexCoord4f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord4fColor4fNormal3fVertex4fSUN(float s, float t, float p, float q, float r, float g, float b, float a, float nx, float ny, float nz, float x, float y, float z, float w);
			[ThreadStatic]
			internal static glTexCoord4fColor4fNormal3fVertex4fSUN pglTexCoord4fColor4fNormal3fVertex4fSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord4fColor4fNormal3fVertex4fvSUN(float* tc, float* c, float* n, float* v);
			[ThreadStatic]
			internal static glTexCoord4fColor4fNormal3fVertex4fvSUN pglTexCoord4fColor4fNormal3fVertex4fvSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord4fVertex4fSUN(float s, float t, float p, float q, float x, float y, float z, float w);
			[ThreadStatic]
			internal static glTexCoord4fVertex4fSUN pglTexCoord4fVertex4fSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord4fVertex4fvSUN(float* tc, float* v);
			[ThreadStatic]
			internal static glTexCoord4fVertex4fvSUN pglTexCoord4fVertex4fvSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord4fv(float* v);
			[ThreadStatic]
			internal static glTexCoord4fv pglTexCoord4fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord4hNV(UInt16 s, UInt16 t, UInt16 r, UInt16 q);
			[ThreadStatic]
			internal static glTexCoord4hNV pglTexCoord4hNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord4hvNV(UInt16* v);
			[ThreadStatic]
			internal static glTexCoord4hvNV pglTexCoord4hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord4i(Int32 s, Int32 t, Int32 r, Int32 q);
			[ThreadStatic]
			internal static glTexCoord4i pglTexCoord4i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord4iv(Int32* v);
			[ThreadStatic]
			internal static glTexCoord4iv pglTexCoord4iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord4s(Int16 s, Int16 t, Int16 r, Int16 q);
			[ThreadStatic]
			internal static glTexCoord4s pglTexCoord4s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord4sv(Int16* v);
			[ThreadStatic]
			internal static glTexCoord4sv pglTexCoord4sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord4xOES(IntPtr s, IntPtr t, IntPtr r, IntPtr q);
			[ThreadStatic]
			internal static glTexCoord4xOES pglTexCoord4xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord4xvOES(IntPtr* coords);
			[ThreadStatic]
			internal static glTexCoord4xvOES pglTexCoord4xvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoordFormatNV(Int32 size, int type, Int32 stride);
			[ThreadStatic]
			internal static glTexCoordFormatNV pglTexCoordFormatNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoordP1ui(int type, UInt32 coords);
			[ThreadStatic]
			internal static glTexCoordP1ui pglTexCoordP1ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoordP1uiv(int type, UInt32* coords);
			[ThreadStatic]
			internal static glTexCoordP1uiv pglTexCoordP1uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoordP2ui(int type, UInt32 coords);
			[ThreadStatic]
			internal static glTexCoordP2ui pglTexCoordP2ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoordP2uiv(int type, UInt32* coords);
			[ThreadStatic]
			internal static glTexCoordP2uiv pglTexCoordP2uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoordP3ui(int type, UInt32 coords);
			[ThreadStatic]
			internal static glTexCoordP3ui pglTexCoordP3ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoordP3uiv(int type, UInt32* coords);
			[ThreadStatic]
			internal static glTexCoordP3uiv pglTexCoordP3uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoordP4ui(int type, UInt32 coords);
			[ThreadStatic]
			internal static glTexCoordP4ui pglTexCoordP4ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoordP4uiv(int type, UInt32* coords);
			[ThreadStatic]
			internal static glTexCoordP4uiv pglTexCoordP4uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoordPointer(Int32 size, int type, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glTexCoordPointer pglTexCoordPointer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoordPointerEXT(Int32 size, int type, Int32 stride, Int32 count, IntPtr pointer);
			[ThreadStatic]
			internal static glTexCoordPointerEXT pglTexCoordPointerEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoordPointerListIBM(Int32 size, int type, Int32 stride, IntPtr* pointer, Int32 ptrstride);
			[ThreadStatic]
			internal static glTexCoordPointerListIBM pglTexCoordPointerListIBM;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoordPointervINTEL(Int32 size, int type, IntPtr* pointer);
			[ThreadStatic]
			internal static glTexCoordPointervINTEL pglTexCoordPointervINTEL;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexEnvf(int target, int pname, float param);
			[ThreadStatic]
			internal static glTexEnvf pglTexEnvf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexEnvfv(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glTexEnvfv pglTexEnvfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexEnvi(int target, int pname, Int32 param);
			[ThreadStatic]
			internal static glTexEnvi pglTexEnvi;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexEnviv(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glTexEnviv pglTexEnviv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexEnvxOES(int target, int pname, IntPtr param);
			[ThreadStatic]
			internal static glTexEnvxOES pglTexEnvxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexEnvxvOES(int target, int pname, IntPtr* @params);
			[ThreadStatic]
			internal static glTexEnvxvOES pglTexEnvxvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexFilterFuncSGIS(int target, int filter, Int32 n, float* weights);
			[ThreadStatic]
			internal static glTexFilterFuncSGIS pglTexFilterFuncSGIS;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexGend(int coord, int pname, double param);
			[ThreadStatic]
			internal static glTexGend pglTexGend;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexGendv(int coord, int pname, double* @params);
			[ThreadStatic]
			internal static glTexGendv pglTexGendv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexGenf(int coord, int pname, float param);
			[ThreadStatic]
			internal static glTexGenf pglTexGenf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexGenfv(int coord, int pname, float* @params);
			[ThreadStatic]
			internal static glTexGenfv pglTexGenfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexGeni(int coord, int pname, Int32 param);
			[ThreadStatic]
			internal static glTexGeni pglTexGeni;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexGeniv(int coord, int pname, Int32* @params);
			[ThreadStatic]
			internal static glTexGeniv pglTexGeniv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexGenxOES(int coord, int pname, IntPtr param);
			[ThreadStatic]
			internal static glTexGenxOES pglTexGenxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexGenxvOES(int coord, int pname, IntPtr* @params);
			[ThreadStatic]
			internal static glTexGenxvOES pglTexGenxvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexImage1D(int target, Int32 level, Int32 internalformat, Int32 width, Int32 border, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glTexImage1D pglTexImage1D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexImage2D(int target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glTexImage2D pglTexImage2D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexImage2DMultisample(int target, Int32 samples, int internalformat, Int32 width, Int32 height, bool fixedsamplelocations);
			[ThreadStatic]
			internal static glTexImage2DMultisample pglTexImage2DMultisample;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexImage2DMultisampleCoverageNV(int target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations);
			[ThreadStatic]
			internal static glTexImage2DMultisampleCoverageNV pglTexImage2DMultisampleCoverageNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexImage3D(int target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glTexImage3D pglTexImage3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexImage3DEXT(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glTexImage3DEXT pglTexImage3DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexImage3DMultisample(int target, Int32 samples, int internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);
			[ThreadStatic]
			internal static glTexImage3DMultisample pglTexImage3DMultisample;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexImage3DMultisampleCoverageNV(int target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations);
			[ThreadStatic]
			internal static glTexImage3DMultisampleCoverageNV pglTexImage3DMultisampleCoverageNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexImage4DSGIS(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 size4d, Int32 border, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glTexImage4DSGIS pglTexImage4DSGIS;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexPageCommitmentARB(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, bool resident);
			[ThreadStatic]
			internal static glTexPageCommitmentARB pglTexPageCommitmentARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexParameterIiv(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glTexParameterIiv pglTexParameterIiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexParameterIivEXT(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glTexParameterIivEXT pglTexParameterIivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexParameterIuiv(int target, int pname, UInt32* @params);
			[ThreadStatic]
			internal static glTexParameterIuiv pglTexParameterIuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexParameterIuivEXT(int target, int pname, UInt32* @params);
			[ThreadStatic]
			internal static glTexParameterIuivEXT pglTexParameterIuivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexParameterf(int target, int pname, float param);
			[ThreadStatic]
			internal static glTexParameterf pglTexParameterf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexParameterfv(int target, int pname, float* @params);
			[ThreadStatic]
			internal static glTexParameterfv pglTexParameterfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexParameteri(int target, int pname, Int32 param);
			[ThreadStatic]
			internal static glTexParameteri pglTexParameteri;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexParameteriv(int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glTexParameteriv pglTexParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexParameterxOES(int target, int pname, IntPtr param);
			[ThreadStatic]
			internal static glTexParameterxOES pglTexParameterxOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexParameterxvOES(int target, int pname, IntPtr* @params);
			[ThreadStatic]
			internal static glTexParameterxvOES pglTexParameterxvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexRenderbufferNV(int target, UInt32 renderbuffer);
			[ThreadStatic]
			internal static glTexRenderbufferNV pglTexRenderbufferNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexStorage1D(int target, Int32 levels, int internalformat, Int32 width);
			[ThreadStatic]
			internal static glTexStorage1D pglTexStorage1D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexStorage2D(int target, Int32 levels, int internalformat, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glTexStorage2D pglTexStorage2D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexStorage2DMultisample(int target, Int32 samples, int internalformat, Int32 width, Int32 height, bool fixedsamplelocations);
			[ThreadStatic]
			internal static glTexStorage2DMultisample pglTexStorage2DMultisample;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexStorage3D(int target, Int32 levels, int internalformat, Int32 width, Int32 height, Int32 depth);
			[ThreadStatic]
			internal static glTexStorage3D pglTexStorage3D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexStorage3DMultisample(int target, Int32 samples, int internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);
			[ThreadStatic]
			internal static glTexStorage3DMultisample pglTexStorage3DMultisample;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexStorageSparseAMD(int target, int internalFormat, Int32 width, Int32 height, Int32 depth, Int32 layers, uint flags);
			[ThreadStatic]
			internal static glTexStorageSparseAMD pglTexStorageSparseAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 width, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glTexSubImage1D pglTexSubImage1D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexSubImage1DEXT(int target, Int32 level, Int32 xoffset, Int32 width, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glTexSubImage1DEXT pglTexSubImage1DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glTexSubImage2D pglTexSubImage2D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexSubImage2DEXT(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glTexSubImage2DEXT pglTexSubImage2DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glTexSubImage3D pglTexSubImage3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexSubImage3DEXT(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glTexSubImage3DEXT pglTexSubImage3DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexSubImage4DSGIS(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 woffset, Int32 width, Int32 height, Int32 depth, Int32 size4d, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glTexSubImage4DSGIS pglTexSubImage4DSGIS;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureBarrier();
			[ThreadStatic]
			internal static glTextureBarrier pglTextureBarrier;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureBarrierNV();
			[ThreadStatic]
			internal static glTextureBarrierNV pglTextureBarrierNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureBuffer(UInt32 texture, int internalformat, UInt32 buffer);
			[ThreadStatic]
			internal static glTextureBuffer pglTextureBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureBufferEXT(UInt32 texture, int target, int internalformat, UInt32 buffer);
			[ThreadStatic]
			internal static glTextureBufferEXT pglTextureBufferEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureBufferRange(UInt32 texture, int internalformat, UInt32 buffer, IntPtr offset, UInt32 size);
			[ThreadStatic]
			internal static glTextureBufferRange pglTextureBufferRange;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureBufferRangeEXT(UInt32 texture, int target, int internalformat, UInt32 buffer, IntPtr offset, UInt32 size);
			[ThreadStatic]
			internal static glTextureBufferRangeEXT pglTextureBufferRangeEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureColorMaskSGIS(bool red, bool green, bool blue, bool alpha);
			[ThreadStatic]
			internal static glTextureColorMaskSGIS pglTextureColorMaskSGIS;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureImage1DEXT(UInt32 texture, int target, Int32 level, Int32 internalformat, Int32 width, Int32 border, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glTextureImage1DEXT pglTextureImage1DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureImage2DEXT(UInt32 texture, int target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glTextureImage2DEXT pglTextureImage2DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureImage2DMultisampleCoverageNV(UInt32 texture, int target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations);
			[ThreadStatic]
			internal static glTextureImage2DMultisampleCoverageNV pglTextureImage2DMultisampleCoverageNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureImage2DMultisampleNV(UInt32 texture, int target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations);
			[ThreadStatic]
			internal static glTextureImage2DMultisampleNV pglTextureImage2DMultisampleNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureImage3DEXT(UInt32 texture, int target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glTextureImage3DEXT pglTextureImage3DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureImage3DMultisampleCoverageNV(UInt32 texture, int target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations);
			[ThreadStatic]
			internal static glTextureImage3DMultisampleCoverageNV pglTextureImage3DMultisampleCoverageNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureImage3DMultisampleNV(UInt32 texture, int target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations);
			[ThreadStatic]
			internal static glTextureImage3DMultisampleNV pglTextureImage3DMultisampleNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureLightEXT(int pname);
			[ThreadStatic]
			internal static glTextureLightEXT pglTextureLightEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureMaterialEXT(int face, int mode);
			[ThreadStatic]
			internal static glTextureMaterialEXT pglTextureMaterialEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureNormalEXT(int mode);
			[ThreadStatic]
			internal static glTextureNormalEXT pglTextureNormalEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexturePageCommitmentEXT(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, bool resident);
			[ThreadStatic]
			internal static glTexturePageCommitmentEXT pglTexturePageCommitmentEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureParameterIiv(UInt32 texture, int pname, Int32* @params);
			[ThreadStatic]
			internal static glTextureParameterIiv pglTextureParameterIiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureParameterIivEXT(UInt32 texture, int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glTextureParameterIivEXT pglTextureParameterIivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureParameterIuiv(UInt32 texture, int pname, UInt32* @params);
			[ThreadStatic]
			internal static glTextureParameterIuiv pglTextureParameterIuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureParameterIuivEXT(UInt32 texture, int target, int pname, UInt32* @params);
			[ThreadStatic]
			internal static glTextureParameterIuivEXT pglTextureParameterIuivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureParameterf(UInt32 texture, int pname, float param);
			[ThreadStatic]
			internal static glTextureParameterf pglTextureParameterf;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureParameterfEXT(UInt32 texture, int target, int pname, float param);
			[ThreadStatic]
			internal static glTextureParameterfEXT pglTextureParameterfEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureParameterfv(UInt32 texture, int pname, float* param);
			[ThreadStatic]
			internal static glTextureParameterfv pglTextureParameterfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureParameterfvEXT(UInt32 texture, int target, int pname, float* @params);
			[ThreadStatic]
			internal static glTextureParameterfvEXT pglTextureParameterfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureParameteri(UInt32 texture, int pname, Int32 param);
			[ThreadStatic]
			internal static glTextureParameteri pglTextureParameteri;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureParameteriEXT(UInt32 texture, int target, int pname, Int32 param);
			[ThreadStatic]
			internal static glTextureParameteriEXT pglTextureParameteriEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureParameteriv(UInt32 texture, int pname, Int32* param);
			[ThreadStatic]
			internal static glTextureParameteriv pglTextureParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureParameterivEXT(UInt32 texture, int target, int pname, Int32* @params);
			[ThreadStatic]
			internal static glTextureParameterivEXT pglTextureParameterivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureRangeAPPLE(int target, Int32 length, IntPtr pointer);
			[ThreadStatic]
			internal static glTextureRangeAPPLE pglTextureRangeAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureRenderbufferEXT(UInt32 texture, int target, UInt32 renderbuffer);
			[ThreadStatic]
			internal static glTextureRenderbufferEXT pglTextureRenderbufferEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorage1D(UInt32 texture, Int32 levels, int internalformat, Int32 width);
			[ThreadStatic]
			internal static glTextureStorage1D pglTextureStorage1D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorage1DEXT(UInt32 texture, int target, Int32 levels, int internalformat, Int32 width);
			[ThreadStatic]
			internal static glTextureStorage1DEXT pglTextureStorage1DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorage2D(UInt32 texture, Int32 levels, int internalformat, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glTextureStorage2D pglTextureStorage2D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorage2DEXT(UInt32 texture, int target, Int32 levels, int internalformat, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glTextureStorage2DEXT pglTextureStorage2DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorage2DMultisample(UInt32 texture, Int32 samples, int internalformat, Int32 width, Int32 height, bool fixedsamplelocations);
			[ThreadStatic]
			internal static glTextureStorage2DMultisample pglTextureStorage2DMultisample;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorage2DMultisampleEXT(UInt32 texture, int target, Int32 samples, int internalformat, Int32 width, Int32 height, bool fixedsamplelocations);
			[ThreadStatic]
			internal static glTextureStorage2DMultisampleEXT pglTextureStorage2DMultisampleEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorage3D(UInt32 texture, Int32 levels, int internalformat, Int32 width, Int32 height, Int32 depth);
			[ThreadStatic]
			internal static glTextureStorage3D pglTextureStorage3D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorage3DEXT(UInt32 texture, int target, Int32 levels, int internalformat, Int32 width, Int32 height, Int32 depth);
			[ThreadStatic]
			internal static glTextureStorage3DEXT pglTextureStorage3DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorage3DMultisample(UInt32 texture, Int32 samples, int internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);
			[ThreadStatic]
			internal static glTextureStorage3DMultisample pglTextureStorage3DMultisample;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorage3DMultisampleEXT(UInt32 texture, int target, Int32 samples, int internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);
			[ThreadStatic]
			internal static glTextureStorage3DMultisampleEXT pglTextureStorage3DMultisampleEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorageSparseAMD(UInt32 texture, int target, int internalFormat, Int32 width, Int32 height, Int32 depth, Int32 layers, uint flags);
			[ThreadStatic]
			internal static glTextureStorageSparseAMD pglTextureStorageSparseAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glTextureSubImage1D pglTextureSubImage1D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureSubImage1DEXT(UInt32 texture, int target, Int32 level, Int32 xoffset, Int32 width, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glTextureSubImage1DEXT pglTextureSubImage1DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glTextureSubImage2D pglTextureSubImage2D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureSubImage2DEXT(UInt32 texture, int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glTextureSubImage2DEXT pglTextureSubImage2DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glTextureSubImage3D pglTextureSubImage3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTextureSubImage3DEXT(UInt32 texture, int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, IntPtr pixels);
			[ThreadStatic]
			internal static glTextureSubImage3DEXT pglTextureSubImage3DEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureView(UInt32 texture, int target, UInt32 origtexture, int internalformat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers);
			[ThreadStatic]
			internal static glTextureView pglTextureView;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTrackMatrixNV(int target, UInt32 address, int matrix, int transform);
			[ThreadStatic]
			internal static glTrackMatrixNV pglTrackMatrixNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTransformFeedbackAttribsNV(Int32 count, Int32* attribs, int bufferMode);
			[ThreadStatic]
			internal static glTransformFeedbackAttribsNV pglTransformFeedbackAttribsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTransformFeedbackBufferBase(UInt32 xfb, UInt32 index, UInt32 buffer);
			[ThreadStatic]
			internal static glTransformFeedbackBufferBase pglTransformFeedbackBufferBase;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTransformFeedbackBufferRange(UInt32 xfb, UInt32 index, UInt32 buffer, IntPtr offset, UInt32 size);
			[ThreadStatic]
			internal static glTransformFeedbackBufferRange pglTransformFeedbackBufferRange;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTransformFeedbackStreamAttribsNV(Int32 count, Int32* attribs, Int32 nbuffers, Int32* bufstreams, int bufferMode);
			[ThreadStatic]
			internal static glTransformFeedbackStreamAttribsNV pglTransformFeedbackStreamAttribsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTransformFeedbackVaryings(UInt32 program, Int32 count, String[] varyings, int bufferMode);
			[ThreadStatic]
			internal static glTransformFeedbackVaryings pglTransformFeedbackVaryings;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTransformFeedbackVaryingsEXT(UInt32 program, Int32 count, String[] varyings, int bufferMode);
			[ThreadStatic]
			internal static glTransformFeedbackVaryingsEXT pglTransformFeedbackVaryingsEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTransformFeedbackVaryingsNV(UInt32 program, Int32 count, Int32* locations, int bufferMode);
			[ThreadStatic]
			internal static glTransformFeedbackVaryingsNV pglTransformFeedbackVaryingsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTransformPathNV(UInt32 resultPath, UInt32 srcPath, int transformType, float* transformValues);
			[ThreadStatic]
			internal static glTransformPathNV pglTransformPathNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTranslated(double x, double y, double z);
			[ThreadStatic]
			internal static glTranslated pglTranslated;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTranslatef(float x, float y, float z);
			[ThreadStatic]
			internal static glTranslatef pglTranslatef;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTranslatexOES(IntPtr x, IntPtr y, IntPtr z);
			[ThreadStatic]
			internal static glTranslatexOES pglTranslatexOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform1d(Int32 location, double x);
			[ThreadStatic]
			internal static glUniform1d pglUniform1d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform1dv(Int32 location, Int32 count, double* value);
			[ThreadStatic]
			internal static glUniform1dv pglUniform1dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform1f(Int32 location, float v0);
			[ThreadStatic]
			internal static glUniform1f pglUniform1f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform1fARB(Int32 location, float v0);
			[ThreadStatic]
			internal static glUniform1fARB pglUniform1fARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform1fv(Int32 location, Int32 count, float* value);
			[ThreadStatic]
			internal static glUniform1fv pglUniform1fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform1fvARB(Int32 location, Int32 count, float* value);
			[ThreadStatic]
			internal static glUniform1fvARB pglUniform1fvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform1i(Int32 location, Int32 v0);
			[ThreadStatic]
			internal static glUniform1i pglUniform1i;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform1i64NV(Int32 location, Int64 x);
			[ThreadStatic]
			internal static glUniform1i64NV pglUniform1i64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform1i64vNV(Int32 location, Int32 count, Int64* value);
			[ThreadStatic]
			internal static glUniform1i64vNV pglUniform1i64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform1iARB(Int32 location, Int32 v0);
			[ThreadStatic]
			internal static glUniform1iARB pglUniform1iARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform1iv(Int32 location, Int32 count, Int32* value);
			[ThreadStatic]
			internal static glUniform1iv pglUniform1iv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform1ivARB(Int32 location, Int32 count, Int32* value);
			[ThreadStatic]
			internal static glUniform1ivARB pglUniform1ivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform1ui(Int32 location, UInt32 v0);
			[ThreadStatic]
			internal static glUniform1ui pglUniform1ui;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform1ui64NV(Int32 location, UInt64 x);
			[ThreadStatic]
			internal static glUniform1ui64NV pglUniform1ui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform1ui64vNV(Int32 location, Int32 count, UInt64* value);
			[ThreadStatic]
			internal static glUniform1ui64vNV pglUniform1ui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform1uiEXT(Int32 location, UInt32 v0);
			[ThreadStatic]
			internal static glUniform1uiEXT pglUniform1uiEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform1uiv(Int32 location, Int32 count, UInt32* value);
			[ThreadStatic]
			internal static glUniform1uiv pglUniform1uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform1uivEXT(Int32 location, Int32 count, UInt32* value);
			[ThreadStatic]
			internal static glUniform1uivEXT pglUniform1uivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform2d(Int32 location, double x, double y);
			[ThreadStatic]
			internal static glUniform2d pglUniform2d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform2dv(Int32 location, Int32 count, double* value);
			[ThreadStatic]
			internal static glUniform2dv pglUniform2dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform2f(Int32 location, float v0, float v1);
			[ThreadStatic]
			internal static glUniform2f pglUniform2f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform2fARB(Int32 location, float v0, float v1);
			[ThreadStatic]
			internal static glUniform2fARB pglUniform2fARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform2fv(Int32 location, Int32 count, float* value);
			[ThreadStatic]
			internal static glUniform2fv pglUniform2fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform2fvARB(Int32 location, Int32 count, float* value);
			[ThreadStatic]
			internal static glUniform2fvARB pglUniform2fvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform2i(Int32 location, Int32 v0, Int32 v1);
			[ThreadStatic]
			internal static glUniform2i pglUniform2i;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform2i64NV(Int32 location, Int64 x, Int64 y);
			[ThreadStatic]
			internal static glUniform2i64NV pglUniform2i64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform2i64vNV(Int32 location, Int32 count, Int64* value);
			[ThreadStatic]
			internal static glUniform2i64vNV pglUniform2i64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform2iARB(Int32 location, Int32 v0, Int32 v1);
			[ThreadStatic]
			internal static glUniform2iARB pglUniform2iARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform2iv(Int32 location, Int32 count, Int32* value);
			[ThreadStatic]
			internal static glUniform2iv pglUniform2iv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform2ivARB(Int32 location, Int32 count, Int32* value);
			[ThreadStatic]
			internal static glUniform2ivARB pglUniform2ivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform2ui(Int32 location, UInt32 v0, UInt32 v1);
			[ThreadStatic]
			internal static glUniform2ui pglUniform2ui;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform2ui64NV(Int32 location, UInt64 x, UInt64 y);
			[ThreadStatic]
			internal static glUniform2ui64NV pglUniform2ui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform2ui64vNV(Int32 location, Int32 count, UInt64* value);
			[ThreadStatic]
			internal static glUniform2ui64vNV pglUniform2ui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform2uiEXT(Int32 location, UInt32 v0, UInt32 v1);
			[ThreadStatic]
			internal static glUniform2uiEXT pglUniform2uiEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform2uiv(Int32 location, Int32 count, UInt32* value);
			[ThreadStatic]
			internal static glUniform2uiv pglUniform2uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform2uivEXT(Int32 location, Int32 count, UInt32* value);
			[ThreadStatic]
			internal static glUniform2uivEXT pglUniform2uivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform3d(Int32 location, double x, double y, double z);
			[ThreadStatic]
			internal static glUniform3d pglUniform3d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform3dv(Int32 location, Int32 count, double* value);
			[ThreadStatic]
			internal static glUniform3dv pglUniform3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform3f(Int32 location, float v0, float v1, float v2);
			[ThreadStatic]
			internal static glUniform3f pglUniform3f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform3fARB(Int32 location, float v0, float v1, float v2);
			[ThreadStatic]
			internal static glUniform3fARB pglUniform3fARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform3fv(Int32 location, Int32 count, float* value);
			[ThreadStatic]
			internal static glUniform3fv pglUniform3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform3fvARB(Int32 location, Int32 count, float* value);
			[ThreadStatic]
			internal static glUniform3fvARB pglUniform3fvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);
			[ThreadStatic]
			internal static glUniform3i pglUniform3i;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform3i64NV(Int32 location, Int64 x, Int64 y, Int64 z);
			[ThreadStatic]
			internal static glUniform3i64NV pglUniform3i64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform3i64vNV(Int32 location, Int32 count, Int64* value);
			[ThreadStatic]
			internal static glUniform3i64vNV pglUniform3i64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform3iARB(Int32 location, Int32 v0, Int32 v1, Int32 v2);
			[ThreadStatic]
			internal static glUniform3iARB pglUniform3iARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform3iv(Int32 location, Int32 count, Int32* value);
			[ThreadStatic]
			internal static glUniform3iv pglUniform3iv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform3ivARB(Int32 location, Int32 count, Int32* value);
			[ThreadStatic]
			internal static glUniform3ivARB pglUniform3ivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform3ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
			[ThreadStatic]
			internal static glUniform3ui pglUniform3ui;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform3ui64NV(Int32 location, UInt64 x, UInt64 y, UInt64 z);
			[ThreadStatic]
			internal static glUniform3ui64NV pglUniform3ui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform3ui64vNV(Int32 location, Int32 count, UInt64* value);
			[ThreadStatic]
			internal static glUniform3ui64vNV pglUniform3ui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform3uiEXT(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
			[ThreadStatic]
			internal static glUniform3uiEXT pglUniform3uiEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform3uiv(Int32 location, Int32 count, UInt32* value);
			[ThreadStatic]
			internal static glUniform3uiv pglUniform3uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform3uivEXT(Int32 location, Int32 count, UInt32* value);
			[ThreadStatic]
			internal static glUniform3uivEXT pglUniform3uivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform4d(Int32 location, double x, double y, double z, double w);
			[ThreadStatic]
			internal static glUniform4d pglUniform4d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform4dv(Int32 location, Int32 count, double* value);
			[ThreadStatic]
			internal static glUniform4dv pglUniform4dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform4f(Int32 location, float v0, float v1, float v2, float v3);
			[ThreadStatic]
			internal static glUniform4f pglUniform4f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform4fARB(Int32 location, float v0, float v1, float v2, float v3);
			[ThreadStatic]
			internal static glUniform4fARB pglUniform4fARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform4fv(Int32 location, Int32 count, float* value);
			[ThreadStatic]
			internal static glUniform4fv pglUniform4fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform4fvARB(Int32 location, Int32 count, float* value);
			[ThreadStatic]
			internal static glUniform4fvARB pglUniform4fvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
			[ThreadStatic]
			internal static glUniform4i pglUniform4i;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform4i64NV(Int32 location, Int64 x, Int64 y, Int64 z, Int64 w);
			[ThreadStatic]
			internal static glUniform4i64NV pglUniform4i64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform4i64vNV(Int32 location, Int32 count, Int64* value);
			[ThreadStatic]
			internal static glUniform4i64vNV pglUniform4i64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform4iARB(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
			[ThreadStatic]
			internal static glUniform4iARB pglUniform4iARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform4iv(Int32 location, Int32 count, Int32* value);
			[ThreadStatic]
			internal static glUniform4iv pglUniform4iv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform4ivARB(Int32 location, Int32 count, Int32* value);
			[ThreadStatic]
			internal static glUniform4ivARB pglUniform4ivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform4ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
			[ThreadStatic]
			internal static glUniform4ui pglUniform4ui;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform4ui64NV(Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);
			[ThreadStatic]
			internal static glUniform4ui64NV pglUniform4ui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform4ui64vNV(Int32 location, Int32 count, UInt64* value);
			[ThreadStatic]
			internal static glUniform4ui64vNV pglUniform4ui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform4uiEXT(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
			[ThreadStatic]
			internal static glUniform4uiEXT pglUniform4uiEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform4uiv(Int32 location, Int32 count, UInt32* value);
			[ThreadStatic]
			internal static glUniform4uiv pglUniform4uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform4uivEXT(Int32 location, Int32 count, UInt32* value);
			[ThreadStatic]
			internal static glUniform4uivEXT pglUniform4uivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding);
			[ThreadStatic]
			internal static glUniformBlockBinding pglUniformBlockBinding;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniformBufferEXT(UInt32 program, Int32 location, UInt32 buffer);
			[ThreadStatic]
			internal static glUniformBufferEXT pglUniformBufferEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniformHandleui64ARB(Int32 location, UInt64 value);
			[ThreadStatic]
			internal static glUniformHandleui64ARB pglUniformHandleui64ARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniformHandleui64NV(Int32 location, UInt64 value);
			[ThreadStatic]
			internal static glUniformHandleui64NV pglUniformHandleui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformHandleui64vARB(Int32 location, Int32 count, UInt64* value);
			[ThreadStatic]
			internal static glUniformHandleui64vARB pglUniformHandleui64vARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformHandleui64vNV(Int32 location, Int32 count, UInt64* value);
			[ThreadStatic]
			internal static glUniformHandleui64vNV pglUniformHandleui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformMatrix2dv(Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glUniformMatrix2dv pglUniformMatrix2dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformMatrix2fv(Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glUniformMatrix2fv pglUniformMatrix2fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformMatrix2fvARB(Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glUniformMatrix2fvARB pglUniformMatrix2fvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformMatrix2x3dv(Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glUniformMatrix2x3dv pglUniformMatrix2x3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformMatrix2x3fv(Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glUniformMatrix2x3fv pglUniformMatrix2x3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformMatrix2x4dv(Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glUniformMatrix2x4dv pglUniformMatrix2x4dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformMatrix2x4fv(Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glUniformMatrix2x4fv pglUniformMatrix2x4fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformMatrix3dv(Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glUniformMatrix3dv pglUniformMatrix3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformMatrix3fv(Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glUniformMatrix3fv pglUniformMatrix3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformMatrix3fvARB(Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glUniformMatrix3fvARB pglUniformMatrix3fvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformMatrix3x2dv(Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glUniformMatrix3x2dv pglUniformMatrix3x2dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformMatrix3x2fv(Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glUniformMatrix3x2fv pglUniformMatrix3x2fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformMatrix3x4dv(Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glUniformMatrix3x4dv pglUniformMatrix3x4dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformMatrix3x4fv(Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glUniformMatrix3x4fv pglUniformMatrix3x4fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformMatrix4dv(Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glUniformMatrix4dv pglUniformMatrix4dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformMatrix4fv(Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glUniformMatrix4fv pglUniformMatrix4fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformMatrix4fvARB(Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glUniformMatrix4fvARB pglUniformMatrix4fvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformMatrix4x2dv(Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glUniformMatrix4x2dv pglUniformMatrix4x2dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformMatrix4x2fv(Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glUniformMatrix4x2fv pglUniformMatrix4x2fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformMatrix4x3dv(Int32 location, Int32 count, bool transpose, double* value);
			[ThreadStatic]
			internal static glUniformMatrix4x3dv pglUniformMatrix4x3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformMatrix4x3fv(Int32 location, Int32 count, bool transpose, float* value);
			[ThreadStatic]
			internal static glUniformMatrix4x3fv pglUniformMatrix4x3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformSubroutinesuiv(int shadertype, Int32 count, UInt32* indices);
			[ThreadStatic]
			internal static glUniformSubroutinesuiv pglUniformSubroutinesuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniformui64NV(Int32 location, UInt64 value);
			[ThreadStatic]
			internal static glUniformui64NV pglUniformui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformui64vNV(Int32 location, Int32 count, UInt64* value);
			[ThreadStatic]
			internal static glUniformui64vNV pglUniformui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUnlockArraysEXT();
			[ThreadStatic]
			internal static glUnlockArraysEXT pglUnlockArraysEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glUnmapBuffer(int target);
			[ThreadStatic]
			internal static glUnmapBuffer pglUnmapBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glUnmapBufferARB(int target);
			[ThreadStatic]
			internal static glUnmapBufferARB pglUnmapBufferARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glUnmapNamedBuffer(UInt32 buffer);
			[ThreadStatic]
			internal static glUnmapNamedBuffer pglUnmapNamedBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glUnmapNamedBufferEXT(UInt32 buffer);
			[ThreadStatic]
			internal static glUnmapNamedBufferEXT pglUnmapNamedBufferEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUnmapObjectBufferATI(UInt32 buffer);
			[ThreadStatic]
			internal static glUnmapObjectBufferATI pglUnmapObjectBufferATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUnmapTexture2DINTEL(UInt32 texture, Int32 level);
			[ThreadStatic]
			internal static glUnmapTexture2DINTEL pglUnmapTexture2DINTEL;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUpdateObjectBufferATI(UInt32 buffer, UInt32 offset, Int32 size, IntPtr pointer, int preserve);
			[ThreadStatic]
			internal static glUpdateObjectBufferATI pglUpdateObjectBufferATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUseProgram(UInt32 program);
			[ThreadStatic]
			internal static glUseProgram pglUseProgram;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUseProgramObjectARB(UInt32 programObj);
			[ThreadStatic]
			internal static glUseProgramObjectARB pglUseProgramObjectARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUseProgramStages(UInt32 pipeline, uint stages, UInt32 program);
			[ThreadStatic]
			internal static glUseProgramStages pglUseProgramStages;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUseShaderProgramEXT(int type, UInt32 program);
			[ThreadStatic]
			internal static glUseShaderProgramEXT pglUseShaderProgramEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVDPAUFiniNV();
			[ThreadStatic]
			internal static glVDPAUFiniNV pglVDPAUFiniNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVDPAUGetSurfaceivNV(IntPtr surface, int pname, Int32 bufSize, Int32* length, Int32* values);
			[ThreadStatic]
			internal static glVDPAUGetSurfaceivNV pglVDPAUGetSurfaceivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVDPAUInitNV(IntPtr vdpDevice, IntPtr getProcAddress);
			[ThreadStatic]
			internal static glVDPAUInitNV pglVDPAUInitNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glVDPAUIsSurfaceNV(IntPtr surface);
			[ThreadStatic]
			internal static glVDPAUIsSurfaceNV pglVDPAUIsSurfaceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVDPAUMapSurfacesNV(Int32 numSurfaces, IntPtr* surfaces);
			[ThreadStatic]
			internal static glVDPAUMapSurfacesNV pglVDPAUMapSurfacesNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glVDPAURegisterOutputSurfaceNV(IntPtr vdpSurface, int target, Int32 numTextureNames, UInt32* textureNames);
			[ThreadStatic]
			internal static glVDPAURegisterOutputSurfaceNV pglVDPAURegisterOutputSurfaceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glVDPAURegisterVideoSurfaceNV(IntPtr vdpSurface, int target, Int32 numTextureNames, UInt32* textureNames);
			[ThreadStatic]
			internal static glVDPAURegisterVideoSurfaceNV pglVDPAURegisterVideoSurfaceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVDPAUSurfaceAccessNV(IntPtr surface, int access);
			[ThreadStatic]
			internal static glVDPAUSurfaceAccessNV pglVDPAUSurfaceAccessNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVDPAUUnmapSurfacesNV(Int32 numSurface, IntPtr* surfaces);
			[ThreadStatic]
			internal static glVDPAUUnmapSurfacesNV pglVDPAUUnmapSurfacesNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVDPAUUnregisterSurfaceNV(IntPtr surface);
			[ThreadStatic]
			internal static glVDPAUUnregisterSurfaceNV pglVDPAUUnregisterSurfaceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glValidateProgram(UInt32 program);
			[ThreadStatic]
			internal static glValidateProgram pglValidateProgram;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glValidateProgramARB(UInt32 programObj);
			[ThreadStatic]
			internal static glValidateProgramARB pglValidateProgramARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glValidateProgramPipeline(UInt32 pipeline);
			[ThreadStatic]
			internal static glValidateProgramPipeline pglValidateProgramPipeline;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVariantArrayObjectATI(UInt32 id, int type, Int32 stride, UInt32 buffer, UInt32 offset);
			[ThreadStatic]
			internal static glVariantArrayObjectATI pglVariantArrayObjectATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVariantPointerEXT(UInt32 id, int type, UInt32 stride, IntPtr addr);
			[ThreadStatic]
			internal static glVariantPointerEXT pglVariantPointerEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVariantbvEXT(UInt32 id, sbyte* addr);
			[ThreadStatic]
			internal static glVariantbvEXT pglVariantbvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVariantdvEXT(UInt32 id, double* addr);
			[ThreadStatic]
			internal static glVariantdvEXT pglVariantdvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVariantfvEXT(UInt32 id, float* addr);
			[ThreadStatic]
			internal static glVariantfvEXT pglVariantfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVariantivEXT(UInt32 id, Int32* addr);
			[ThreadStatic]
			internal static glVariantivEXT pglVariantivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVariantsvEXT(UInt32 id, Int16* addr);
			[ThreadStatic]
			internal static glVariantsvEXT pglVariantsvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVariantubvEXT(UInt32 id, byte* addr);
			[ThreadStatic]
			internal static glVariantubvEXT pglVariantubvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVariantuivEXT(UInt32 id, UInt32* addr);
			[ThreadStatic]
			internal static glVariantuivEXT pglVariantuivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVariantusvEXT(UInt32 id, UInt16* addr);
			[ThreadStatic]
			internal static glVariantusvEXT pglVariantusvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex2bOES(sbyte x, sbyte y);
			[ThreadStatic]
			internal static glVertex2bOES pglVertex2bOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex2bvOES(sbyte* coords);
			[ThreadStatic]
			internal static glVertex2bvOES pglVertex2bvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex2d(double x, double y);
			[ThreadStatic]
			internal static glVertex2d pglVertex2d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex2dv(double* v);
			[ThreadStatic]
			internal static glVertex2dv pglVertex2dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex2f(float x, float y);
			[ThreadStatic]
			internal static glVertex2f pglVertex2f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex2fv(float* v);
			[ThreadStatic]
			internal static glVertex2fv pglVertex2fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex2hNV(UInt16 x, UInt16 y);
			[ThreadStatic]
			internal static glVertex2hNV pglVertex2hNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex2hvNV(UInt16* v);
			[ThreadStatic]
			internal static glVertex2hvNV pglVertex2hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex2i(Int32 x, Int32 y);
			[ThreadStatic]
			internal static glVertex2i pglVertex2i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex2iv(Int32* v);
			[ThreadStatic]
			internal static glVertex2iv pglVertex2iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex2s(Int16 x, Int16 y);
			[ThreadStatic]
			internal static glVertex2s pglVertex2s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex2sv(Int16* v);
			[ThreadStatic]
			internal static glVertex2sv pglVertex2sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex2xOES(IntPtr x);
			[ThreadStatic]
			internal static glVertex2xOES pglVertex2xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex2xvOES(IntPtr* coords);
			[ThreadStatic]
			internal static glVertex2xvOES pglVertex2xvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex3bOES(sbyte x, sbyte y, sbyte z);
			[ThreadStatic]
			internal static glVertex3bOES pglVertex3bOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex3bvOES(sbyte* coords);
			[ThreadStatic]
			internal static glVertex3bvOES pglVertex3bvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex3d(double x, double y, double z);
			[ThreadStatic]
			internal static glVertex3d pglVertex3d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex3dv(double* v);
			[ThreadStatic]
			internal static glVertex3dv pglVertex3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex3f(float x, float y, float z);
			[ThreadStatic]
			internal static glVertex3f pglVertex3f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex3fv(float* v);
			[ThreadStatic]
			internal static glVertex3fv pglVertex3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex3hNV(UInt16 x, UInt16 y, UInt16 z);
			[ThreadStatic]
			internal static glVertex3hNV pglVertex3hNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex3hvNV(UInt16* v);
			[ThreadStatic]
			internal static glVertex3hvNV pglVertex3hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex3i(Int32 x, Int32 y, Int32 z);
			[ThreadStatic]
			internal static glVertex3i pglVertex3i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex3iv(Int32* v);
			[ThreadStatic]
			internal static glVertex3iv pglVertex3iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex3s(Int16 x, Int16 y, Int16 z);
			[ThreadStatic]
			internal static glVertex3s pglVertex3s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex3sv(Int16* v);
			[ThreadStatic]
			internal static glVertex3sv pglVertex3sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex3xOES(IntPtr x, IntPtr y);
			[ThreadStatic]
			internal static glVertex3xOES pglVertex3xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex3xvOES(IntPtr* coords);
			[ThreadStatic]
			internal static glVertex3xvOES pglVertex3xvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex4bOES(sbyte x, sbyte y, sbyte z, sbyte w);
			[ThreadStatic]
			internal static glVertex4bOES pglVertex4bOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex4bvOES(sbyte* coords);
			[ThreadStatic]
			internal static glVertex4bvOES pglVertex4bvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex4d(double x, double y, double z, double w);
			[ThreadStatic]
			internal static glVertex4d pglVertex4d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex4dv(double* v);
			[ThreadStatic]
			internal static glVertex4dv pglVertex4dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex4f(float x, float y, float z, float w);
			[ThreadStatic]
			internal static glVertex4f pglVertex4f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex4fv(float* v);
			[ThreadStatic]
			internal static glVertex4fv pglVertex4fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex4hNV(UInt16 x, UInt16 y, UInt16 z, UInt16 w);
			[ThreadStatic]
			internal static glVertex4hNV pglVertex4hNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex4hvNV(UInt16* v);
			[ThreadStatic]
			internal static glVertex4hvNV pglVertex4hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex4i(Int32 x, Int32 y, Int32 z, Int32 w);
			[ThreadStatic]
			internal static glVertex4i pglVertex4i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex4iv(Int32* v);
			[ThreadStatic]
			internal static glVertex4iv pglVertex4iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex4s(Int16 x, Int16 y, Int16 z, Int16 w);
			[ThreadStatic]
			internal static glVertex4s pglVertex4s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex4sv(Int16* v);
			[ThreadStatic]
			internal static glVertex4sv pglVertex4sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex4xOES(IntPtr x, IntPtr y, IntPtr z);
			[ThreadStatic]
			internal static glVertex4xOES pglVertex4xOES;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex4xvOES(IntPtr* coords);
			[ThreadStatic]
			internal static glVertex4xvOES pglVertex4xvOES;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayAttribBinding(UInt32 vaobj, UInt32 attribindex, UInt32 bindingindex);
			[ThreadStatic]
			internal static glVertexArrayAttribBinding pglVertexArrayAttribBinding;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayAttribFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, int type, bool normalized, UInt32 relativeoffset);
			[ThreadStatic]
			internal static glVertexArrayAttribFormat pglVertexArrayAttribFormat;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayAttribIFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, int type, UInt32 relativeoffset);
			[ThreadStatic]
			internal static glVertexArrayAttribIFormat pglVertexArrayAttribIFormat;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayAttribLFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, int type, UInt32 relativeoffset);
			[ThreadStatic]
			internal static glVertexArrayAttribLFormat pglVertexArrayAttribLFormat;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayBindVertexBufferEXT(UInt32 vaobj, UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);
			[ThreadStatic]
			internal static glVertexArrayBindVertexBufferEXT pglVertexArrayBindVertexBufferEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayBindingDivisor(UInt32 vaobj, UInt32 bindingindex, UInt32 divisor);
			[ThreadStatic]
			internal static glVertexArrayBindingDivisor pglVertexArrayBindingDivisor;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayColorOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, int type, Int32 stride, IntPtr offset);
			[ThreadStatic]
			internal static glVertexArrayColorOffsetEXT pglVertexArrayColorOffsetEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayEdgeFlagOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 stride, IntPtr offset);
			[ThreadStatic]
			internal static glVertexArrayEdgeFlagOffsetEXT pglVertexArrayEdgeFlagOffsetEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayElementBuffer(UInt32 vaobj, UInt32 buffer);
			[ThreadStatic]
			internal static glVertexArrayElementBuffer pglVertexArrayElementBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayFogCoordOffsetEXT(UInt32 vaobj, UInt32 buffer, int type, Int32 stride, IntPtr offset);
			[ThreadStatic]
			internal static glVertexArrayFogCoordOffsetEXT pglVertexArrayFogCoordOffsetEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayIndexOffsetEXT(UInt32 vaobj, UInt32 buffer, int type, Int32 stride, IntPtr offset);
			[ThreadStatic]
			internal static glVertexArrayIndexOffsetEXT pglVertexArrayIndexOffsetEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayMultiTexCoordOffsetEXT(UInt32 vaobj, UInt32 buffer, int texunit, Int32 size, int type, Int32 stride, IntPtr offset);
			[ThreadStatic]
			internal static glVertexArrayMultiTexCoordOffsetEXT pglVertexArrayMultiTexCoordOffsetEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayNormalOffsetEXT(UInt32 vaobj, UInt32 buffer, int type, Int32 stride, IntPtr offset);
			[ThreadStatic]
			internal static glVertexArrayNormalOffsetEXT pglVertexArrayNormalOffsetEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayParameteriAPPLE(int pname, Int32 param);
			[ThreadStatic]
			internal static glVertexArrayParameteriAPPLE pglVertexArrayParameteriAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayRangeAPPLE(Int32 length, IntPtr pointer);
			[ThreadStatic]
			internal static glVertexArrayRangeAPPLE pglVertexArrayRangeAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayRangeNV(Int32 length, IntPtr pointer);
			[ThreadStatic]
			internal static glVertexArrayRangeNV pglVertexArrayRangeNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArraySecondaryColorOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, int type, Int32 stride, IntPtr offset);
			[ThreadStatic]
			internal static glVertexArraySecondaryColorOffsetEXT pglVertexArraySecondaryColorOffsetEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayTexCoordOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, int type, Int32 stride, IntPtr offset);
			[ThreadStatic]
			internal static glVertexArrayTexCoordOffsetEXT pglVertexArrayTexCoordOffsetEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayVertexAttribBindingEXT(UInt32 vaobj, UInt32 attribindex, UInt32 bindingindex);
			[ThreadStatic]
			internal static glVertexArrayVertexAttribBindingEXT pglVertexArrayVertexAttribBindingEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayVertexAttribDivisorEXT(UInt32 vaobj, UInt32 index, UInt32 divisor);
			[ThreadStatic]
			internal static glVertexArrayVertexAttribDivisorEXT pglVertexArrayVertexAttribDivisorEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayVertexAttribFormatEXT(UInt32 vaobj, UInt32 attribindex, Int32 size, int type, bool normalized, UInt32 relativeoffset);
			[ThreadStatic]
			internal static glVertexArrayVertexAttribFormatEXT pglVertexArrayVertexAttribFormatEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayVertexAttribIFormatEXT(UInt32 vaobj, UInt32 attribindex, Int32 size, int type, UInt32 relativeoffset);
			[ThreadStatic]
			internal static glVertexArrayVertexAttribIFormatEXT pglVertexArrayVertexAttribIFormatEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayVertexAttribIOffsetEXT(UInt32 vaobj, UInt32 buffer, UInt32 index, Int32 size, int type, Int32 stride, IntPtr offset);
			[ThreadStatic]
			internal static glVertexArrayVertexAttribIOffsetEXT pglVertexArrayVertexAttribIOffsetEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayVertexAttribLFormatEXT(UInt32 vaobj, UInt32 attribindex, Int32 size, int type, UInt32 relativeoffset);
			[ThreadStatic]
			internal static glVertexArrayVertexAttribLFormatEXT pglVertexArrayVertexAttribLFormatEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayVertexAttribLOffsetEXT(UInt32 vaobj, UInt32 buffer, UInt32 index, Int32 size, int type, Int32 stride, IntPtr offset);
			[ThreadStatic]
			internal static glVertexArrayVertexAttribLOffsetEXT pglVertexArrayVertexAttribLOffsetEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayVertexAttribOffsetEXT(UInt32 vaobj, UInt32 buffer, UInt32 index, Int32 size, int type, bool normalized, Int32 stride, IntPtr offset);
			[ThreadStatic]
			internal static glVertexArrayVertexAttribOffsetEXT pglVertexArrayVertexAttribOffsetEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexArrayVertexBindingDivisorEXT(UInt32 vaobj, UInt32 bindingindex, UInt32 divisor);
			[ThreadStatic]
			internal static glVertexArrayVertexBindingDivisorEXT pglVertexArrayVertexBindingDivisorEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayVertexBuffer(UInt32 vaobj, UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);
			[ThreadStatic]
			internal static glVertexArrayVertexBuffer pglVertexArrayVertexBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayVertexBuffers(UInt32 vaobj, UInt32 first, Int32 count, UInt32* buffers, IntPtr* offsets, Int32* strides);
			[ThreadStatic]
			internal static glVertexArrayVertexBuffers pglVertexArrayVertexBuffers;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexArrayVertexOffsetEXT(UInt32 vaobj, UInt32 buffer, Int32 size, int type, Int32 stride, IntPtr offset);
			[ThreadStatic]
			internal static glVertexArrayVertexOffsetEXT pglVertexArrayVertexOffsetEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib1d(UInt32 index, double x);
			[ThreadStatic]
			internal static glVertexAttrib1d pglVertexAttrib1d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib1dARB(UInt32 index, double x);
			[ThreadStatic]
			internal static glVertexAttrib1dARB pglVertexAttrib1dARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib1dNV(UInt32 index, double x);
			[ThreadStatic]
			internal static glVertexAttrib1dNV pglVertexAttrib1dNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib1dv(UInt32 index, double* v);
			[ThreadStatic]
			internal static glVertexAttrib1dv pglVertexAttrib1dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib1dvARB(UInt32 index, double* v);
			[ThreadStatic]
			internal static glVertexAttrib1dvARB pglVertexAttrib1dvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib1dvNV(UInt32 index, double* v);
			[ThreadStatic]
			internal static glVertexAttrib1dvNV pglVertexAttrib1dvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib1f(UInt32 index, float x);
			[ThreadStatic]
			internal static glVertexAttrib1f pglVertexAttrib1f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib1fARB(UInt32 index, float x);
			[ThreadStatic]
			internal static glVertexAttrib1fARB pglVertexAttrib1fARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib1fNV(UInt32 index, float x);
			[ThreadStatic]
			internal static glVertexAttrib1fNV pglVertexAttrib1fNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib1fv(UInt32 index, float* v);
			[ThreadStatic]
			internal static glVertexAttrib1fv pglVertexAttrib1fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib1fvARB(UInt32 index, float* v);
			[ThreadStatic]
			internal static glVertexAttrib1fvARB pglVertexAttrib1fvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib1fvNV(UInt32 index, float* v);
			[ThreadStatic]
			internal static glVertexAttrib1fvNV pglVertexAttrib1fvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib1hNV(UInt32 index, UInt16 x);
			[ThreadStatic]
			internal static glVertexAttrib1hNV pglVertexAttrib1hNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib1hvNV(UInt32 index, UInt16* v);
			[ThreadStatic]
			internal static glVertexAttrib1hvNV pglVertexAttrib1hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib1s(UInt32 index, Int16 x);
			[ThreadStatic]
			internal static glVertexAttrib1s pglVertexAttrib1s;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib1sARB(UInt32 index, Int16 x);
			[ThreadStatic]
			internal static glVertexAttrib1sARB pglVertexAttrib1sARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib1sNV(UInt32 index, Int16 x);
			[ThreadStatic]
			internal static glVertexAttrib1sNV pglVertexAttrib1sNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib1sv(UInt32 index, Int16* v);
			[ThreadStatic]
			internal static glVertexAttrib1sv pglVertexAttrib1sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib1svARB(UInt32 index, Int16* v);
			[ThreadStatic]
			internal static glVertexAttrib1svARB pglVertexAttrib1svARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib1svNV(UInt32 index, Int16* v);
			[ThreadStatic]
			internal static glVertexAttrib1svNV pglVertexAttrib1svNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib2d(UInt32 index, double x, double y);
			[ThreadStatic]
			internal static glVertexAttrib2d pglVertexAttrib2d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib2dARB(UInt32 index, double x, double y);
			[ThreadStatic]
			internal static glVertexAttrib2dARB pglVertexAttrib2dARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib2dNV(UInt32 index, double x, double y);
			[ThreadStatic]
			internal static glVertexAttrib2dNV pglVertexAttrib2dNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib2dv(UInt32 index, double* v);
			[ThreadStatic]
			internal static glVertexAttrib2dv pglVertexAttrib2dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib2dvARB(UInt32 index, double* v);
			[ThreadStatic]
			internal static glVertexAttrib2dvARB pglVertexAttrib2dvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib2dvNV(UInt32 index, double* v);
			[ThreadStatic]
			internal static glVertexAttrib2dvNV pglVertexAttrib2dvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib2f(UInt32 index, float x, float y);
			[ThreadStatic]
			internal static glVertexAttrib2f pglVertexAttrib2f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib2fARB(UInt32 index, float x, float y);
			[ThreadStatic]
			internal static glVertexAttrib2fARB pglVertexAttrib2fARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib2fNV(UInt32 index, float x, float y);
			[ThreadStatic]
			internal static glVertexAttrib2fNV pglVertexAttrib2fNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib2fv(UInt32 index, float* v);
			[ThreadStatic]
			internal static glVertexAttrib2fv pglVertexAttrib2fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib2fvARB(UInt32 index, float* v);
			[ThreadStatic]
			internal static glVertexAttrib2fvARB pglVertexAttrib2fvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib2fvNV(UInt32 index, float* v);
			[ThreadStatic]
			internal static glVertexAttrib2fvNV pglVertexAttrib2fvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib2hNV(UInt32 index, UInt16 x, UInt16 y);
			[ThreadStatic]
			internal static glVertexAttrib2hNV pglVertexAttrib2hNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib2hvNV(UInt32 index, UInt16* v);
			[ThreadStatic]
			internal static glVertexAttrib2hvNV pglVertexAttrib2hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib2s(UInt32 index, Int16 x, Int16 y);
			[ThreadStatic]
			internal static glVertexAttrib2s pglVertexAttrib2s;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib2sARB(UInt32 index, Int16 x, Int16 y);
			[ThreadStatic]
			internal static glVertexAttrib2sARB pglVertexAttrib2sARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib2sNV(UInt32 index, Int16 x, Int16 y);
			[ThreadStatic]
			internal static glVertexAttrib2sNV pglVertexAttrib2sNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib2sv(UInt32 index, Int16* v);
			[ThreadStatic]
			internal static glVertexAttrib2sv pglVertexAttrib2sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib2svARB(UInt32 index, Int16* v);
			[ThreadStatic]
			internal static glVertexAttrib2svARB pglVertexAttrib2svARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib2svNV(UInt32 index, Int16* v);
			[ThreadStatic]
			internal static glVertexAttrib2svNV pglVertexAttrib2svNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib3d(UInt32 index, double x, double y, double z);
			[ThreadStatic]
			internal static glVertexAttrib3d pglVertexAttrib3d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib3dARB(UInt32 index, double x, double y, double z);
			[ThreadStatic]
			internal static glVertexAttrib3dARB pglVertexAttrib3dARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib3dNV(UInt32 index, double x, double y, double z);
			[ThreadStatic]
			internal static glVertexAttrib3dNV pglVertexAttrib3dNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib3dv(UInt32 index, double* v);
			[ThreadStatic]
			internal static glVertexAttrib3dv pglVertexAttrib3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib3dvARB(UInt32 index, double* v);
			[ThreadStatic]
			internal static glVertexAttrib3dvARB pglVertexAttrib3dvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib3dvNV(UInt32 index, double* v);
			[ThreadStatic]
			internal static glVertexAttrib3dvNV pglVertexAttrib3dvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib3f(UInt32 index, float x, float y, float z);
			[ThreadStatic]
			internal static glVertexAttrib3f pglVertexAttrib3f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib3fARB(UInt32 index, float x, float y, float z);
			[ThreadStatic]
			internal static glVertexAttrib3fARB pglVertexAttrib3fARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib3fNV(UInt32 index, float x, float y, float z);
			[ThreadStatic]
			internal static glVertexAttrib3fNV pglVertexAttrib3fNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib3fv(UInt32 index, float* v);
			[ThreadStatic]
			internal static glVertexAttrib3fv pglVertexAttrib3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib3fvARB(UInt32 index, float* v);
			[ThreadStatic]
			internal static glVertexAttrib3fvARB pglVertexAttrib3fvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib3fvNV(UInt32 index, float* v);
			[ThreadStatic]
			internal static glVertexAttrib3fvNV pglVertexAttrib3fvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib3hNV(UInt32 index, UInt16 x, UInt16 y, UInt16 z);
			[ThreadStatic]
			internal static glVertexAttrib3hNV pglVertexAttrib3hNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib3hvNV(UInt32 index, UInt16* v);
			[ThreadStatic]
			internal static glVertexAttrib3hvNV pglVertexAttrib3hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z);
			[ThreadStatic]
			internal static glVertexAttrib3s pglVertexAttrib3s;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib3sARB(UInt32 index, Int16 x, Int16 y, Int16 z);
			[ThreadStatic]
			internal static glVertexAttrib3sARB pglVertexAttrib3sARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib3sNV(UInt32 index, Int16 x, Int16 y, Int16 z);
			[ThreadStatic]
			internal static glVertexAttrib3sNV pglVertexAttrib3sNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib3sv(UInt32 index, Int16* v);
			[ThreadStatic]
			internal static glVertexAttrib3sv pglVertexAttrib3sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib3svARB(UInt32 index, Int16* v);
			[ThreadStatic]
			internal static glVertexAttrib3svARB pglVertexAttrib3svARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib3svNV(UInt32 index, Int16* v);
			[ThreadStatic]
			internal static glVertexAttrib3svNV pglVertexAttrib3svNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4Nbv(UInt32 index, sbyte* v);
			[ThreadStatic]
			internal static glVertexAttrib4Nbv pglVertexAttrib4Nbv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4NbvARB(UInt32 index, sbyte* v);
			[ThreadStatic]
			internal static glVertexAttrib4NbvARB pglVertexAttrib4NbvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4Niv(UInt32 index, Int32* v);
			[ThreadStatic]
			internal static glVertexAttrib4Niv pglVertexAttrib4Niv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4NivARB(UInt32 index, Int32* v);
			[ThreadStatic]
			internal static glVertexAttrib4NivARB pglVertexAttrib4NivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4Nsv(UInt32 index, Int16* v);
			[ThreadStatic]
			internal static glVertexAttrib4Nsv pglVertexAttrib4Nsv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4NsvARB(UInt32 index, Int16* v);
			[ThreadStatic]
			internal static glVertexAttrib4NsvARB pglVertexAttrib4NsvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib4Nub(UInt32 index, byte x, byte y, byte z, byte w);
			[ThreadStatic]
			internal static glVertexAttrib4Nub pglVertexAttrib4Nub;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib4NubARB(UInt32 index, byte x, byte y, byte z, byte w);
			[ThreadStatic]
			internal static glVertexAttrib4NubARB pglVertexAttrib4NubARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4Nubv(UInt32 index, byte* v);
			[ThreadStatic]
			internal static glVertexAttrib4Nubv pglVertexAttrib4Nubv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4NubvARB(UInt32 index, byte* v);
			[ThreadStatic]
			internal static glVertexAttrib4NubvARB pglVertexAttrib4NubvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4Nuiv(UInt32 index, UInt32* v);
			[ThreadStatic]
			internal static glVertexAttrib4Nuiv pglVertexAttrib4Nuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4NuivARB(UInt32 index, UInt32* v);
			[ThreadStatic]
			internal static glVertexAttrib4NuivARB pglVertexAttrib4NuivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4Nusv(UInt32 index, UInt16* v);
			[ThreadStatic]
			internal static glVertexAttrib4Nusv pglVertexAttrib4Nusv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4NusvARB(UInt32 index, UInt16* v);
			[ThreadStatic]
			internal static glVertexAttrib4NusvARB pglVertexAttrib4NusvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4bv(UInt32 index, sbyte* v);
			[ThreadStatic]
			internal static glVertexAttrib4bv pglVertexAttrib4bv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4bvARB(UInt32 index, sbyte* v);
			[ThreadStatic]
			internal static glVertexAttrib4bvARB pglVertexAttrib4bvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib4d(UInt32 index, double x, double y, double z, double w);
			[ThreadStatic]
			internal static glVertexAttrib4d pglVertexAttrib4d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib4dARB(UInt32 index, double x, double y, double z, double w);
			[ThreadStatic]
			internal static glVertexAttrib4dARB pglVertexAttrib4dARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib4dNV(UInt32 index, double x, double y, double z, double w);
			[ThreadStatic]
			internal static glVertexAttrib4dNV pglVertexAttrib4dNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4dv(UInt32 index, double* v);
			[ThreadStatic]
			internal static glVertexAttrib4dv pglVertexAttrib4dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4dvARB(UInt32 index, double* v);
			[ThreadStatic]
			internal static glVertexAttrib4dvARB pglVertexAttrib4dvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4dvNV(UInt32 index, double* v);
			[ThreadStatic]
			internal static glVertexAttrib4dvNV pglVertexAttrib4dvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib4f(UInt32 index, float x, float y, float z, float w);
			[ThreadStatic]
			internal static glVertexAttrib4f pglVertexAttrib4f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib4fARB(UInt32 index, float x, float y, float z, float w);
			[ThreadStatic]
			internal static glVertexAttrib4fARB pglVertexAttrib4fARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib4fNV(UInt32 index, float x, float y, float z, float w);
			[ThreadStatic]
			internal static glVertexAttrib4fNV pglVertexAttrib4fNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4fv(UInt32 index, float* v);
			[ThreadStatic]
			internal static glVertexAttrib4fv pglVertexAttrib4fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4fvARB(UInt32 index, float* v);
			[ThreadStatic]
			internal static glVertexAttrib4fvARB pglVertexAttrib4fvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4fvNV(UInt32 index, float* v);
			[ThreadStatic]
			internal static glVertexAttrib4fvNV pglVertexAttrib4fvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib4hNV(UInt32 index, UInt16 x, UInt16 y, UInt16 z, UInt16 w);
			[ThreadStatic]
			internal static glVertexAttrib4hNV pglVertexAttrib4hNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4hvNV(UInt32 index, UInt16* v);
			[ThreadStatic]
			internal static glVertexAttrib4hvNV pglVertexAttrib4hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4iv(UInt32 index, Int32* v);
			[ThreadStatic]
			internal static glVertexAttrib4iv pglVertexAttrib4iv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4ivARB(UInt32 index, Int32* v);
			[ThreadStatic]
			internal static glVertexAttrib4ivARB pglVertexAttrib4ivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
			[ThreadStatic]
			internal static glVertexAttrib4s pglVertexAttrib4s;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib4sARB(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
			[ThreadStatic]
			internal static glVertexAttrib4sARB pglVertexAttrib4sARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib4sNV(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
			[ThreadStatic]
			internal static glVertexAttrib4sNV pglVertexAttrib4sNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4sv(UInt32 index, Int16* v);
			[ThreadStatic]
			internal static glVertexAttrib4sv pglVertexAttrib4sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4svARB(UInt32 index, Int16* v);
			[ThreadStatic]
			internal static glVertexAttrib4svARB pglVertexAttrib4svARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4svNV(UInt32 index, Int16* v);
			[ThreadStatic]
			internal static glVertexAttrib4svNV pglVertexAttrib4svNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttrib4ubNV(UInt32 index, byte x, byte y, byte z, byte w);
			[ThreadStatic]
			internal static glVertexAttrib4ubNV pglVertexAttrib4ubNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4ubv(UInt32 index, byte* v);
			[ThreadStatic]
			internal static glVertexAttrib4ubv pglVertexAttrib4ubv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4ubvARB(UInt32 index, byte* v);
			[ThreadStatic]
			internal static glVertexAttrib4ubvARB pglVertexAttrib4ubvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4ubvNV(UInt32 index, byte* v);
			[ThreadStatic]
			internal static glVertexAttrib4ubvNV pglVertexAttrib4ubvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4uiv(UInt32 index, UInt32* v);
			[ThreadStatic]
			internal static glVertexAttrib4uiv pglVertexAttrib4uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4uivARB(UInt32 index, UInt32* v);
			[ThreadStatic]
			internal static glVertexAttrib4uivARB pglVertexAttrib4uivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4usv(UInt32 index, UInt16* v);
			[ThreadStatic]
			internal static glVertexAttrib4usv pglVertexAttrib4usv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttrib4usvARB(UInt32 index, UInt16* v);
			[ThreadStatic]
			internal static glVertexAttrib4usvARB pglVertexAttrib4usvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribArrayObjectATI(UInt32 index, Int32 size, int type, bool normalized, Int32 stride, UInt32 buffer, UInt32 offset);
			[ThreadStatic]
			internal static glVertexAttribArrayObjectATI pglVertexAttribArrayObjectATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribBinding(UInt32 attribindex, UInt32 bindingindex);
			[ThreadStatic]
			internal static glVertexAttribBinding pglVertexAttribBinding;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribDivisor(UInt32 index, UInt32 divisor);
			[ThreadStatic]
			internal static glVertexAttribDivisor pglVertexAttribDivisor;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribDivisorARB(UInt32 index, UInt32 divisor);
			[ThreadStatic]
			internal static glVertexAttribDivisorARB pglVertexAttribDivisorARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribFormat(UInt32 attribindex, Int32 size, int type, bool normalized, UInt32 relativeoffset);
			[ThreadStatic]
			internal static glVertexAttribFormat pglVertexAttribFormat;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribFormatNV(UInt32 index, Int32 size, int type, bool normalized, Int32 stride);
			[ThreadStatic]
			internal static glVertexAttribFormatNV pglVertexAttribFormatNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribI1i(UInt32 index, Int32 x);
			[ThreadStatic]
			internal static glVertexAttribI1i pglVertexAttribI1i;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribI1iEXT(UInt32 index, Int32 x);
			[ThreadStatic]
			internal static glVertexAttribI1iEXT pglVertexAttribI1iEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI1iv(UInt32 index, Int32* v);
			[ThreadStatic]
			internal static glVertexAttribI1iv pglVertexAttribI1iv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI1ivEXT(UInt32 index, Int32* v);
			[ThreadStatic]
			internal static glVertexAttribI1ivEXT pglVertexAttribI1ivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribI1ui(UInt32 index, UInt32 x);
			[ThreadStatic]
			internal static glVertexAttribI1ui pglVertexAttribI1ui;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribI1uiEXT(UInt32 index, UInt32 x);
			[ThreadStatic]
			internal static glVertexAttribI1uiEXT pglVertexAttribI1uiEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI1uiv(UInt32 index, UInt32* v);
			[ThreadStatic]
			internal static glVertexAttribI1uiv pglVertexAttribI1uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI1uivEXT(UInt32 index, UInt32* v);
			[ThreadStatic]
			internal static glVertexAttribI1uivEXT pglVertexAttribI1uivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribI2i(UInt32 index, Int32 x, Int32 y);
			[ThreadStatic]
			internal static glVertexAttribI2i pglVertexAttribI2i;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribI2iEXT(UInt32 index, Int32 x, Int32 y);
			[ThreadStatic]
			internal static glVertexAttribI2iEXT pglVertexAttribI2iEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI2iv(UInt32 index, Int32* v);
			[ThreadStatic]
			internal static glVertexAttribI2iv pglVertexAttribI2iv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI2ivEXT(UInt32 index, Int32* v);
			[ThreadStatic]
			internal static glVertexAttribI2ivEXT pglVertexAttribI2ivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribI2ui(UInt32 index, UInt32 x, UInt32 y);
			[ThreadStatic]
			internal static glVertexAttribI2ui pglVertexAttribI2ui;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribI2uiEXT(UInt32 index, UInt32 x, UInt32 y);
			[ThreadStatic]
			internal static glVertexAttribI2uiEXT pglVertexAttribI2uiEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI2uiv(UInt32 index, UInt32* v);
			[ThreadStatic]
			internal static glVertexAttribI2uiv pglVertexAttribI2uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI2uivEXT(UInt32 index, UInt32* v);
			[ThreadStatic]
			internal static glVertexAttribI2uivEXT pglVertexAttribI2uivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribI3i(UInt32 index, Int32 x, Int32 y, Int32 z);
			[ThreadStatic]
			internal static glVertexAttribI3i pglVertexAttribI3i;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribI3iEXT(UInt32 index, Int32 x, Int32 y, Int32 z);
			[ThreadStatic]
			internal static glVertexAttribI3iEXT pglVertexAttribI3iEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI3iv(UInt32 index, Int32* v);
			[ThreadStatic]
			internal static glVertexAttribI3iv pglVertexAttribI3iv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI3ivEXT(UInt32 index, Int32* v);
			[ThreadStatic]
			internal static glVertexAttribI3ivEXT pglVertexAttribI3ivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribI3ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z);
			[ThreadStatic]
			internal static glVertexAttribI3ui pglVertexAttribI3ui;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribI3uiEXT(UInt32 index, UInt32 x, UInt32 y, UInt32 z);
			[ThreadStatic]
			internal static glVertexAttribI3uiEXT pglVertexAttribI3uiEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI3uiv(UInt32 index, UInt32* v);
			[ThreadStatic]
			internal static glVertexAttribI3uiv pglVertexAttribI3uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI3uivEXT(UInt32 index, UInt32* v);
			[ThreadStatic]
			internal static glVertexAttribI3uivEXT pglVertexAttribI3uivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI4bv(UInt32 index, sbyte* v);
			[ThreadStatic]
			internal static glVertexAttribI4bv pglVertexAttribI4bv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI4bvEXT(UInt32 index, sbyte* v);
			[ThreadStatic]
			internal static glVertexAttribI4bvEXT pglVertexAttribI4bvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribI4i(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
			[ThreadStatic]
			internal static glVertexAttribI4i pglVertexAttribI4i;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribI4iEXT(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
			[ThreadStatic]
			internal static glVertexAttribI4iEXT pglVertexAttribI4iEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI4iv(UInt32 index, Int32* v);
			[ThreadStatic]
			internal static glVertexAttribI4iv pglVertexAttribI4iv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI4ivEXT(UInt32 index, Int32* v);
			[ThreadStatic]
			internal static glVertexAttribI4ivEXT pglVertexAttribI4ivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI4sv(UInt32 index, Int16* v);
			[ThreadStatic]
			internal static glVertexAttribI4sv pglVertexAttribI4sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI4svEXT(UInt32 index, Int16* v);
			[ThreadStatic]
			internal static glVertexAttribI4svEXT pglVertexAttribI4svEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI4ubv(UInt32 index, byte* v);
			[ThreadStatic]
			internal static glVertexAttribI4ubv pglVertexAttribI4ubv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI4ubvEXT(UInt32 index, byte* v);
			[ThreadStatic]
			internal static glVertexAttribI4ubvEXT pglVertexAttribI4ubvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribI4ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
			[ThreadStatic]
			internal static glVertexAttribI4ui pglVertexAttribI4ui;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribI4uiEXT(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
			[ThreadStatic]
			internal static glVertexAttribI4uiEXT pglVertexAttribI4uiEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI4uiv(UInt32 index, UInt32* v);
			[ThreadStatic]
			internal static glVertexAttribI4uiv pglVertexAttribI4uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI4uivEXT(UInt32 index, UInt32* v);
			[ThreadStatic]
			internal static glVertexAttribI4uivEXT pglVertexAttribI4uivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI4usv(UInt32 index, UInt16* v);
			[ThreadStatic]
			internal static glVertexAttribI4usv pglVertexAttribI4usv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribI4usvEXT(UInt32 index, UInt16* v);
			[ThreadStatic]
			internal static glVertexAttribI4usvEXT pglVertexAttribI4usvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribIFormat(UInt32 attribindex, Int32 size, int type, UInt32 relativeoffset);
			[ThreadStatic]
			internal static glVertexAttribIFormat pglVertexAttribIFormat;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribIFormatNV(UInt32 index, Int32 size, int type, Int32 stride);
			[ThreadStatic]
			internal static glVertexAttribIFormatNV pglVertexAttribIFormatNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribIPointer(UInt32 index, Int32 size, int type, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glVertexAttribIPointer pglVertexAttribIPointer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribIPointerEXT(UInt32 index, Int32 size, int type, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glVertexAttribIPointerEXT pglVertexAttribIPointerEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL1d(UInt32 index, double x);
			[ThreadStatic]
			internal static glVertexAttribL1d pglVertexAttribL1d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL1dEXT(UInt32 index, double x);
			[ThreadStatic]
			internal static glVertexAttribL1dEXT pglVertexAttribL1dEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL1dv(UInt32 index, double* v);
			[ThreadStatic]
			internal static glVertexAttribL1dv pglVertexAttribL1dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL1dvEXT(UInt32 index, double* v);
			[ThreadStatic]
			internal static glVertexAttribL1dvEXT pglVertexAttribL1dvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL1i64NV(UInt32 index, Int64 x);
			[ThreadStatic]
			internal static glVertexAttribL1i64NV pglVertexAttribL1i64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL1i64vNV(UInt32 index, Int64* v);
			[ThreadStatic]
			internal static glVertexAttribL1i64vNV pglVertexAttribL1i64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL1ui64ARB(UInt32 index, UInt64 x);
			[ThreadStatic]
			internal static glVertexAttribL1ui64ARB pglVertexAttribL1ui64ARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL1ui64NV(UInt32 index, UInt64 x);
			[ThreadStatic]
			internal static glVertexAttribL1ui64NV pglVertexAttribL1ui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL1ui64vARB(UInt32 index, UInt64* v);
			[ThreadStatic]
			internal static glVertexAttribL1ui64vARB pglVertexAttribL1ui64vARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL1ui64vNV(UInt32 index, UInt64* v);
			[ThreadStatic]
			internal static glVertexAttribL1ui64vNV pglVertexAttribL1ui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL2d(UInt32 index, double x, double y);
			[ThreadStatic]
			internal static glVertexAttribL2d pglVertexAttribL2d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL2dEXT(UInt32 index, double x, double y);
			[ThreadStatic]
			internal static glVertexAttribL2dEXT pglVertexAttribL2dEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL2dv(UInt32 index, double* v);
			[ThreadStatic]
			internal static glVertexAttribL2dv pglVertexAttribL2dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL2dvEXT(UInt32 index, double* v);
			[ThreadStatic]
			internal static glVertexAttribL2dvEXT pglVertexAttribL2dvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL2i64NV(UInt32 index, Int64 x, Int64 y);
			[ThreadStatic]
			internal static glVertexAttribL2i64NV pglVertexAttribL2i64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL2i64vNV(UInt32 index, Int64* v);
			[ThreadStatic]
			internal static glVertexAttribL2i64vNV pglVertexAttribL2i64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL2ui64NV(UInt32 index, UInt64 x, UInt64 y);
			[ThreadStatic]
			internal static glVertexAttribL2ui64NV pglVertexAttribL2ui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL2ui64vNV(UInt32 index, UInt64* v);
			[ThreadStatic]
			internal static glVertexAttribL2ui64vNV pglVertexAttribL2ui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL3d(UInt32 index, double x, double y, double z);
			[ThreadStatic]
			internal static glVertexAttribL3d pglVertexAttribL3d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL3dEXT(UInt32 index, double x, double y, double z);
			[ThreadStatic]
			internal static glVertexAttribL3dEXT pglVertexAttribL3dEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL3dv(UInt32 index, double* v);
			[ThreadStatic]
			internal static glVertexAttribL3dv pglVertexAttribL3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL3dvEXT(UInt32 index, double* v);
			[ThreadStatic]
			internal static glVertexAttribL3dvEXT pglVertexAttribL3dvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL3i64NV(UInt32 index, Int64 x, Int64 y, Int64 z);
			[ThreadStatic]
			internal static glVertexAttribL3i64NV pglVertexAttribL3i64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL3i64vNV(UInt32 index, Int64* v);
			[ThreadStatic]
			internal static glVertexAttribL3i64vNV pglVertexAttribL3i64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL3ui64NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z);
			[ThreadStatic]
			internal static glVertexAttribL3ui64NV pglVertexAttribL3ui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL3ui64vNV(UInt32 index, UInt64* v);
			[ThreadStatic]
			internal static glVertexAttribL3ui64vNV pglVertexAttribL3ui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL4d(UInt32 index, double x, double y, double z, double w);
			[ThreadStatic]
			internal static glVertexAttribL4d pglVertexAttribL4d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL4dEXT(UInt32 index, double x, double y, double z, double w);
			[ThreadStatic]
			internal static glVertexAttribL4dEXT pglVertexAttribL4dEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL4dv(UInt32 index, double* v);
			[ThreadStatic]
			internal static glVertexAttribL4dv pglVertexAttribL4dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL4dvEXT(UInt32 index, double* v);
			[ThreadStatic]
			internal static glVertexAttribL4dvEXT pglVertexAttribL4dvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL4i64NV(UInt32 index, Int64 x, Int64 y, Int64 z, Int64 w);
			[ThreadStatic]
			internal static glVertexAttribL4i64NV pglVertexAttribL4i64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL4i64vNV(UInt32 index, Int64* v);
			[ThreadStatic]
			internal static glVertexAttribL4i64vNV pglVertexAttribL4i64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL4ui64NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z, UInt64 w);
			[ThreadStatic]
			internal static glVertexAttribL4ui64NV pglVertexAttribL4ui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL4ui64vNV(UInt32 index, UInt64* v);
			[ThreadStatic]
			internal static glVertexAttribL4ui64vNV pglVertexAttribL4ui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribLFormat(UInt32 attribindex, Int32 size, int type, UInt32 relativeoffset);
			[ThreadStatic]
			internal static glVertexAttribLFormat pglVertexAttribLFormat;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribLFormatNV(UInt32 index, Int32 size, int type, Int32 stride);
			[ThreadStatic]
			internal static glVertexAttribLFormatNV pglVertexAttribLFormatNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribLPointer(UInt32 index, Int32 size, int type, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glVertexAttribLPointer pglVertexAttribLPointer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribLPointerEXT(UInt32 index, Int32 size, int type, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glVertexAttribLPointerEXT pglVertexAttribLPointerEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribP1ui(UInt32 index, int type, bool normalized, UInt32 value);
			[ThreadStatic]
			internal static glVertexAttribP1ui pglVertexAttribP1ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribP1uiv(UInt32 index, int type, bool normalized, UInt32* value);
			[ThreadStatic]
			internal static glVertexAttribP1uiv pglVertexAttribP1uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribP2ui(UInt32 index, int type, bool normalized, UInt32 value);
			[ThreadStatic]
			internal static glVertexAttribP2ui pglVertexAttribP2ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribP2uiv(UInt32 index, int type, bool normalized, UInt32* value);
			[ThreadStatic]
			internal static glVertexAttribP2uiv pglVertexAttribP2uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribP3ui(UInt32 index, int type, bool normalized, UInt32 value);
			[ThreadStatic]
			internal static glVertexAttribP3ui pglVertexAttribP3ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribP3uiv(UInt32 index, int type, bool normalized, UInt32* value);
			[ThreadStatic]
			internal static glVertexAttribP3uiv pglVertexAttribP3uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribP4ui(UInt32 index, int type, bool normalized, UInt32 value);
			[ThreadStatic]
			internal static glVertexAttribP4ui pglVertexAttribP4ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribP4uiv(UInt32 index, int type, bool normalized, UInt32* value);
			[ThreadStatic]
			internal static glVertexAttribP4uiv pglVertexAttribP4uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribParameteriAMD(UInt32 index, int pname, Int32 param);
			[ThreadStatic]
			internal static glVertexAttribParameteriAMD pglVertexAttribParameteriAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribPointer(UInt32 index, Int32 size, int type, bool normalized, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glVertexAttribPointer pglVertexAttribPointer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribPointerARB(UInt32 index, Int32 size, int type, bool normalized, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glVertexAttribPointerARB pglVertexAttribPointerARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribPointerNV(UInt32 index, Int32 fsize, int type, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glVertexAttribPointerNV pglVertexAttribPointerNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs1dvNV(UInt32 index, Int32 count, double* v);
			[ThreadStatic]
			internal static glVertexAttribs1dvNV pglVertexAttribs1dvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs1fvNV(UInt32 index, Int32 count, float* v);
			[ThreadStatic]
			internal static glVertexAttribs1fvNV pglVertexAttribs1fvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs1hvNV(UInt32 index, Int32 n, UInt16* v);
			[ThreadStatic]
			internal static glVertexAttribs1hvNV pglVertexAttribs1hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs1svNV(UInt32 index, Int32 count, Int16* v);
			[ThreadStatic]
			internal static glVertexAttribs1svNV pglVertexAttribs1svNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs2dvNV(UInt32 index, Int32 count, double* v);
			[ThreadStatic]
			internal static glVertexAttribs2dvNV pglVertexAttribs2dvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs2fvNV(UInt32 index, Int32 count, float* v);
			[ThreadStatic]
			internal static glVertexAttribs2fvNV pglVertexAttribs2fvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs2hvNV(UInt32 index, Int32 n, UInt16* v);
			[ThreadStatic]
			internal static glVertexAttribs2hvNV pglVertexAttribs2hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs2svNV(UInt32 index, Int32 count, Int16* v);
			[ThreadStatic]
			internal static glVertexAttribs2svNV pglVertexAttribs2svNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs3dvNV(UInt32 index, Int32 count, double* v);
			[ThreadStatic]
			internal static glVertexAttribs3dvNV pglVertexAttribs3dvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs3fvNV(UInt32 index, Int32 count, float* v);
			[ThreadStatic]
			internal static glVertexAttribs3fvNV pglVertexAttribs3fvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs3hvNV(UInt32 index, Int32 n, UInt16* v);
			[ThreadStatic]
			internal static glVertexAttribs3hvNV pglVertexAttribs3hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs3svNV(UInt32 index, Int32 count, Int16* v);
			[ThreadStatic]
			internal static glVertexAttribs3svNV pglVertexAttribs3svNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs4dvNV(UInt32 index, Int32 count, double* v);
			[ThreadStatic]
			internal static glVertexAttribs4dvNV pglVertexAttribs4dvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs4fvNV(UInt32 index, Int32 count, float* v);
			[ThreadStatic]
			internal static glVertexAttribs4fvNV pglVertexAttribs4fvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs4hvNV(UInt32 index, Int32 n, UInt16* v);
			[ThreadStatic]
			internal static glVertexAttribs4hvNV pglVertexAttribs4hvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs4svNV(UInt32 index, Int32 count, Int16* v);
			[ThreadStatic]
			internal static glVertexAttribs4svNV pglVertexAttribs4svNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribs4ubvNV(UInt32 index, Int32 count, byte* v);
			[ThreadStatic]
			internal static glVertexAttribs4ubvNV pglVertexAttribs4ubvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexBindingDivisor(UInt32 bindingindex, UInt32 divisor);
			[ThreadStatic]
			internal static glVertexBindingDivisor pglVertexBindingDivisor;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexBlendARB(Int32 count);
			[ThreadStatic]
			internal static glVertexBlendARB pglVertexBlendARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexBlendEnvfATI(int pname, float param);
			[ThreadStatic]
			internal static glVertexBlendEnvfATI pglVertexBlendEnvfATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexBlendEnviATI(int pname, Int32 param);
			[ThreadStatic]
			internal static glVertexBlendEnviATI pglVertexBlendEnviATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexFormatNV(Int32 size, int type, Int32 stride);
			[ThreadStatic]
			internal static glVertexFormatNV pglVertexFormatNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexP2ui(int type, UInt32 value);
			[ThreadStatic]
			internal static glVertexP2ui pglVertexP2ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexP2uiv(int type, UInt32* value);
			[ThreadStatic]
			internal static glVertexP2uiv pglVertexP2uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexP3ui(int type, UInt32 value);
			[ThreadStatic]
			internal static glVertexP3ui pglVertexP3ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexP3uiv(int type, UInt32* value);
			[ThreadStatic]
			internal static glVertexP3uiv pglVertexP3uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexP4ui(int type, UInt32 value);
			[ThreadStatic]
			internal static glVertexP4ui pglVertexP4ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexP4uiv(int type, UInt32* value);
			[ThreadStatic]
			internal static glVertexP4uiv pglVertexP4uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexPointer(Int32 size, int type, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glVertexPointer pglVertexPointer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexPointerEXT(Int32 size, int type, Int32 stride, Int32 count, IntPtr pointer);
			[ThreadStatic]
			internal static glVertexPointerEXT pglVertexPointerEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexPointerListIBM(Int32 size, int type, Int32 stride, IntPtr* pointer, Int32 ptrstride);
			[ThreadStatic]
			internal static glVertexPointerListIBM pglVertexPointerListIBM;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexPointervINTEL(Int32 size, int type, IntPtr* pointer);
			[ThreadStatic]
			internal static glVertexPointervINTEL pglVertexPointervINTEL;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream1dATI(int stream, double x);
			[ThreadStatic]
			internal static glVertexStream1dATI pglVertexStream1dATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream1dvATI(int stream, double* coords);
			[ThreadStatic]
			internal static glVertexStream1dvATI pglVertexStream1dvATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream1fATI(int stream, float x);
			[ThreadStatic]
			internal static glVertexStream1fATI pglVertexStream1fATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream1fvATI(int stream, float* coords);
			[ThreadStatic]
			internal static glVertexStream1fvATI pglVertexStream1fvATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream1iATI(int stream, Int32 x);
			[ThreadStatic]
			internal static glVertexStream1iATI pglVertexStream1iATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream1ivATI(int stream, Int32* coords);
			[ThreadStatic]
			internal static glVertexStream1ivATI pglVertexStream1ivATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream1sATI(int stream, Int16 x);
			[ThreadStatic]
			internal static glVertexStream1sATI pglVertexStream1sATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream1svATI(int stream, Int16* coords);
			[ThreadStatic]
			internal static glVertexStream1svATI pglVertexStream1svATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream2dATI(int stream, double x, double y);
			[ThreadStatic]
			internal static glVertexStream2dATI pglVertexStream2dATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream2dvATI(int stream, double* coords);
			[ThreadStatic]
			internal static glVertexStream2dvATI pglVertexStream2dvATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream2fATI(int stream, float x, float y);
			[ThreadStatic]
			internal static glVertexStream2fATI pglVertexStream2fATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream2fvATI(int stream, float* coords);
			[ThreadStatic]
			internal static glVertexStream2fvATI pglVertexStream2fvATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream2iATI(int stream, Int32 x, Int32 y);
			[ThreadStatic]
			internal static glVertexStream2iATI pglVertexStream2iATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream2ivATI(int stream, Int32* coords);
			[ThreadStatic]
			internal static glVertexStream2ivATI pglVertexStream2ivATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream2sATI(int stream, Int16 x, Int16 y);
			[ThreadStatic]
			internal static glVertexStream2sATI pglVertexStream2sATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream2svATI(int stream, Int16* coords);
			[ThreadStatic]
			internal static glVertexStream2svATI pglVertexStream2svATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream3dATI(int stream, double x, double y, double z);
			[ThreadStatic]
			internal static glVertexStream3dATI pglVertexStream3dATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream3dvATI(int stream, double* coords);
			[ThreadStatic]
			internal static glVertexStream3dvATI pglVertexStream3dvATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream3fATI(int stream, float x, float y, float z);
			[ThreadStatic]
			internal static glVertexStream3fATI pglVertexStream3fATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream3fvATI(int stream, float* coords);
			[ThreadStatic]
			internal static glVertexStream3fvATI pglVertexStream3fvATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream3iATI(int stream, Int32 x, Int32 y, Int32 z);
			[ThreadStatic]
			internal static glVertexStream3iATI pglVertexStream3iATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream3ivATI(int stream, Int32* coords);
			[ThreadStatic]
			internal static glVertexStream3ivATI pglVertexStream3ivATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream3sATI(int stream, Int16 x, Int16 y, Int16 z);
			[ThreadStatic]
			internal static glVertexStream3sATI pglVertexStream3sATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream3svATI(int stream, Int16* coords);
			[ThreadStatic]
			internal static glVertexStream3svATI pglVertexStream3svATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream4dATI(int stream, double x, double y, double z, double w);
			[ThreadStatic]
			internal static glVertexStream4dATI pglVertexStream4dATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream4dvATI(int stream, double* coords);
			[ThreadStatic]
			internal static glVertexStream4dvATI pglVertexStream4dvATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream4fATI(int stream, float x, float y, float z, float w);
			[ThreadStatic]
			internal static glVertexStream4fATI pglVertexStream4fATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream4fvATI(int stream, float* coords);
			[ThreadStatic]
			internal static glVertexStream4fvATI pglVertexStream4fvATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream4iATI(int stream, Int32 x, Int32 y, Int32 z, Int32 w);
			[ThreadStatic]
			internal static glVertexStream4iATI pglVertexStream4iATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream4ivATI(int stream, Int32* coords);
			[ThreadStatic]
			internal static glVertexStream4ivATI pglVertexStream4ivATI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream4sATI(int stream, Int16 x, Int16 y, Int16 z, Int16 w);
			[ThreadStatic]
			internal static glVertexStream4sATI pglVertexStream4sATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream4svATI(int stream, Int16* coords);
			[ThreadStatic]
			internal static glVertexStream4svATI pglVertexStream4svATI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexWeightPointerEXT(Int32 size, int type, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glVertexWeightPointerEXT pglVertexWeightPointerEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexWeightfEXT(float weight);
			[ThreadStatic]
			internal static glVertexWeightfEXT pglVertexWeightfEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexWeightfvEXT(float* weight);
			[ThreadStatic]
			internal static glVertexWeightfvEXT pglVertexWeightfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexWeighthNV(UInt16 weight);
			[ThreadStatic]
			internal static glVertexWeighthNV pglVertexWeighthNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexWeighthvNV(UInt16* weight);
			[ThreadStatic]
			internal static glVertexWeighthvNV pglVertexWeighthvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glVideoCaptureNV(UInt32 video_capture_slot, UInt32* sequence_num, UInt64* capture_time);
			[ThreadStatic]
			internal static glVideoCaptureNV pglVideoCaptureNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVideoCaptureStreamParameterdvNV(UInt32 video_capture_slot, UInt32 stream, int pname, double* @params);
			[ThreadStatic]
			internal static glVideoCaptureStreamParameterdvNV pglVideoCaptureStreamParameterdvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVideoCaptureStreamParameterfvNV(UInt32 video_capture_slot, UInt32 stream, int pname, float* @params);
			[ThreadStatic]
			internal static glVideoCaptureStreamParameterfvNV pglVideoCaptureStreamParameterfvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVideoCaptureStreamParameterivNV(UInt32 video_capture_slot, UInt32 stream, int pname, Int32* @params);
			[ThreadStatic]
			internal static glVideoCaptureStreamParameterivNV pglVideoCaptureStreamParameterivNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glViewport(Int32 x, Int32 y, Int32 width, Int32 height);
			[ThreadStatic]
			internal static glViewport pglViewport;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glViewportArrayv(UInt32 first, Int32 count, float* v);
			[ThreadStatic]
			internal static glViewportArrayv pglViewportArrayv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glViewportIndexedf(UInt32 index, float x, float y, float w, float h);
			[ThreadStatic]
			internal static glViewportIndexedf pglViewportIndexedf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glViewportIndexedfv(UInt32 index, float* v);
			[ThreadStatic]
			internal static glViewportIndexedfv pglViewportIndexedfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWaitSync(int sync, uint flags, UInt64 timeout);
			[ThreadStatic]
			internal static glWaitSync pglWaitSync;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWeightPathsNV(UInt32 resultPath, Int32 numPaths, UInt32* paths, float* weights);
			[ThreadStatic]
			internal static glWeightPathsNV pglWeightPathsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWeightPointerARB(Int32 size, int type, Int32 stride, IntPtr pointer);
			[ThreadStatic]
			internal static glWeightPointerARB pglWeightPointerARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWeightbvARB(Int32 size, sbyte* weights);
			[ThreadStatic]
			internal static glWeightbvARB pglWeightbvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWeightdvARB(Int32 size, double* weights);
			[ThreadStatic]
			internal static glWeightdvARB pglWeightdvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWeightfvARB(Int32 size, float* weights);
			[ThreadStatic]
			internal static glWeightfvARB pglWeightfvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWeightivARB(Int32 size, Int32* weights);
			[ThreadStatic]
			internal static glWeightivARB pglWeightivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWeightsvARB(Int32 size, Int16* weights);
			[ThreadStatic]
			internal static glWeightsvARB pglWeightsvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWeightubvARB(Int32 size, byte* weights);
			[ThreadStatic]
			internal static glWeightubvARB pglWeightubvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWeightuivARB(Int32 size, UInt32* weights);
			[ThreadStatic]
			internal static glWeightuivARB pglWeightuivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWeightusvARB(Int32 size, UInt16* weights);
			[ThreadStatic]
			internal static glWeightusvARB pglWeightusvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos2d(double x, double y);
			[ThreadStatic]
			internal static glWindowPos2d pglWindowPos2d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos2dARB(double x, double y);
			[ThreadStatic]
			internal static glWindowPos2dARB pglWindowPos2dARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos2dMESA(double x, double y);
			[ThreadStatic]
			internal static glWindowPos2dMESA pglWindowPos2dMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos2dv(double* v);
			[ThreadStatic]
			internal static glWindowPos2dv pglWindowPos2dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos2dvARB(double* v);
			[ThreadStatic]
			internal static glWindowPos2dvARB pglWindowPos2dvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos2dvMESA(double* v);
			[ThreadStatic]
			internal static glWindowPos2dvMESA pglWindowPos2dvMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos2f(float x, float y);
			[ThreadStatic]
			internal static glWindowPos2f pglWindowPos2f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos2fARB(float x, float y);
			[ThreadStatic]
			internal static glWindowPos2fARB pglWindowPos2fARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos2fMESA(float x, float y);
			[ThreadStatic]
			internal static glWindowPos2fMESA pglWindowPos2fMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos2fv(float* v);
			[ThreadStatic]
			internal static glWindowPos2fv pglWindowPos2fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos2fvARB(float* v);
			[ThreadStatic]
			internal static glWindowPos2fvARB pglWindowPos2fvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos2fvMESA(float* v);
			[ThreadStatic]
			internal static glWindowPos2fvMESA pglWindowPos2fvMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos2i(Int32 x, Int32 y);
			[ThreadStatic]
			internal static glWindowPos2i pglWindowPos2i;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos2iARB(Int32 x, Int32 y);
			[ThreadStatic]
			internal static glWindowPos2iARB pglWindowPos2iARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos2iMESA(Int32 x, Int32 y);
			[ThreadStatic]
			internal static glWindowPos2iMESA pglWindowPos2iMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos2iv(Int32* v);
			[ThreadStatic]
			internal static glWindowPos2iv pglWindowPos2iv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos2ivARB(Int32* v);
			[ThreadStatic]
			internal static glWindowPos2ivARB pglWindowPos2ivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos2ivMESA(Int32* v);
			[ThreadStatic]
			internal static glWindowPos2ivMESA pglWindowPos2ivMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos2s(Int16 x, Int16 y);
			[ThreadStatic]
			internal static glWindowPos2s pglWindowPos2s;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos2sARB(Int16 x, Int16 y);
			[ThreadStatic]
			internal static glWindowPos2sARB pglWindowPos2sARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos2sMESA(Int16 x, Int16 y);
			[ThreadStatic]
			internal static glWindowPos2sMESA pglWindowPos2sMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos2sv(Int16* v);
			[ThreadStatic]
			internal static glWindowPos2sv pglWindowPos2sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos2svARB(Int16* v);
			[ThreadStatic]
			internal static glWindowPos2svARB pglWindowPos2svARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos2svMESA(Int16* v);
			[ThreadStatic]
			internal static glWindowPos2svMESA pglWindowPos2svMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos3d(double x, double y, double z);
			[ThreadStatic]
			internal static glWindowPos3d pglWindowPos3d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos3dARB(double x, double y, double z);
			[ThreadStatic]
			internal static glWindowPos3dARB pglWindowPos3dARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos3dMESA(double x, double y, double z);
			[ThreadStatic]
			internal static glWindowPos3dMESA pglWindowPos3dMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos3dv(double* v);
			[ThreadStatic]
			internal static glWindowPos3dv pglWindowPos3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos3dvARB(double* v);
			[ThreadStatic]
			internal static glWindowPos3dvARB pglWindowPos3dvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos3dvMESA(double* v);
			[ThreadStatic]
			internal static glWindowPos3dvMESA pglWindowPos3dvMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos3f(float x, float y, float z);
			[ThreadStatic]
			internal static glWindowPos3f pglWindowPos3f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos3fARB(float x, float y, float z);
			[ThreadStatic]
			internal static glWindowPos3fARB pglWindowPos3fARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos3fMESA(float x, float y, float z);
			[ThreadStatic]
			internal static glWindowPos3fMESA pglWindowPos3fMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos3fv(float* v);
			[ThreadStatic]
			internal static glWindowPos3fv pglWindowPos3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos3fvARB(float* v);
			[ThreadStatic]
			internal static glWindowPos3fvARB pglWindowPos3fvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos3fvMESA(float* v);
			[ThreadStatic]
			internal static glWindowPos3fvMESA pglWindowPos3fvMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos3i(Int32 x, Int32 y, Int32 z);
			[ThreadStatic]
			internal static glWindowPos3i pglWindowPos3i;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos3iARB(Int32 x, Int32 y, Int32 z);
			[ThreadStatic]
			internal static glWindowPos3iARB pglWindowPos3iARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos3iMESA(Int32 x, Int32 y, Int32 z);
			[ThreadStatic]
			internal static glWindowPos3iMESA pglWindowPos3iMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos3iv(Int32* v);
			[ThreadStatic]
			internal static glWindowPos3iv pglWindowPos3iv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos3ivARB(Int32* v);
			[ThreadStatic]
			internal static glWindowPos3ivARB pglWindowPos3ivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos3ivMESA(Int32* v);
			[ThreadStatic]
			internal static glWindowPos3ivMESA pglWindowPos3ivMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos3s(Int16 x, Int16 y, Int16 z);
			[ThreadStatic]
			internal static glWindowPos3s pglWindowPos3s;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos3sARB(Int16 x, Int16 y, Int16 z);
			[ThreadStatic]
			internal static glWindowPos3sARB pglWindowPos3sARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos3sMESA(Int16 x, Int16 y, Int16 z);
			[ThreadStatic]
			internal static glWindowPos3sMESA pglWindowPos3sMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos3sv(Int16* v);
			[ThreadStatic]
			internal static glWindowPos3sv pglWindowPos3sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos3svARB(Int16* v);
			[ThreadStatic]
			internal static glWindowPos3svARB pglWindowPos3svARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos3svMESA(Int16* v);
			[ThreadStatic]
			internal static glWindowPos3svMESA pglWindowPos3svMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos4dMESA(double x, double y, double z, double w);
			[ThreadStatic]
			internal static glWindowPos4dMESA pglWindowPos4dMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos4dvMESA(double* v);
			[ThreadStatic]
			internal static glWindowPos4dvMESA pglWindowPos4dvMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos4fMESA(float x, float y, float z, float w);
			[ThreadStatic]
			internal static glWindowPos4fMESA pglWindowPos4fMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos4fvMESA(float* v);
			[ThreadStatic]
			internal static glWindowPos4fvMESA pglWindowPos4fvMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos4iMESA(Int32 x, Int32 y, Int32 z, Int32 w);
			[ThreadStatic]
			internal static glWindowPos4iMESA pglWindowPos4iMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos4ivMESA(Int32* v);
			[ThreadStatic]
			internal static glWindowPos4ivMESA pglWindowPos4ivMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos4sMESA(Int16 x, Int16 y, Int16 z, Int16 w);
			[ThreadStatic]
			internal static glWindowPos4sMESA pglWindowPos4sMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos4svMESA(Int16* v);
			[ThreadStatic]
			internal static glWindowPos4svMESA pglWindowPos4svMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWriteMaskEXT(UInt32 res, UInt32 @in, int outX, int outY, int outZ, int outW);
			[ThreadStatic]
			internal static glWriteMaskEXT pglWriteMaskEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCoverageModulationNV(int components);
			[ThreadStatic]
			internal static glCoverageModulationNV pglCoverageModulationNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCoverageModulationTableNV(Int32 n, float* v);
			[ThreadStatic]
			internal static glCoverageModulationTableNV pglCoverageModulationTableNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFragmentCoverageColorNV(UInt32 color);
			[ThreadStatic]
			internal static glFragmentCoverageColorNV pglFragmentCoverageColorNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFramebufferSampleLocationsfvNV(int target, UInt32 start, Int32 count, float* v);
			[ThreadStatic]
			internal static glFramebufferSampleLocationsfvNV pglFramebufferSampleLocationsfvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetCoverageModulationTableNV(Int32 bufsize, float* v);
			[ThreadStatic]
			internal static glGetCoverageModulationTableNV pglGetCoverageModulationTableNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedFramebufferSampleLocationsfvNV(UInt32 framebuffer, UInt32 start, Int32 count, float* v);
			[ThreadStatic]
			internal static glNamedFramebufferSampleLocationsfvNV pglNamedFramebufferSampleLocationsfvNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterSamplesEXT(UInt32 samples, bool fixedsamplelocations);
			[ThreadStatic]
			internal static glRasterSamplesEXT pglRasterSamplesEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glResolveDepthValuesNV();
			[ThreadStatic]
			internal static glResolveDepthValuesNV pglResolveDepthValuesNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSubpixelPrecisionBiasNV(UInt32 xbits, UInt32 ybits);
			[ThreadStatic]
			internal static glSubpixelPrecisionBiasNV pglSubpixelPrecisionBiasNV;

		}
	}

}
