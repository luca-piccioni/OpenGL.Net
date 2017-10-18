
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

namespace OpenVX
{
	public delegate Status PublishKernelsCallback(IntPtr kernel);

	public delegate Status UnpublishKernelsCallback(IntPtr kernel);

	public delegate Status KernelCallback(IntPtr node, IntPtr[] parameters, uint num);

	public delegate Status KernelInitializeCallback(IntPtr node, IntPtr[] parameters, uint num);

	public delegate Status KernelDeinitializeCallback(IntPtr node, IntPtr[] parameters, uint num);

	public delegate Status KernelValidateCallbackCallback(IntPtr node, IntPtr[] parameters, uint num, IntPtr[] metas);

	public delegate Status KernelImageValidRectangleCallback(IntPtr node, uint index, Rectangle[] inputValid, Rectangle[] outputValid);

	public delegate void LogCallback(IntPtr context, IntPtr reference, Status status, string @string);

	public delegate Action NodeCompleteCallback(IntPtr node);

	// typedef void (*vx_tiling_kernel_f)(void * VX_RESTRICT parameters[], void * VX_RESTRICT tile_memory, vx_size tile_memory_size);
	public delegate void TilingKernelCallback(IntPtr[] parameters, IntPtr tileMemory, uint tileMemorySize);

	// typedef vx_status(VX_CALLBACK *vx_kernel_input_validate_f)(vx_node node, vx_uint32 index);
	public delegate Status KernelInputValidateCallback(Node node, uint index);

	// typedef vx_status(VX_CALLBACK *vx_kernel_output_validate_f)(vx_node node, vx_uint32 index, vx_meta_format meta);
	public delegate Status KernelOutputValidateCallback(Node node, uint index, MetaFormat meta);
}
