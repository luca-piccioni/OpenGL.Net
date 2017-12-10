
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
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
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer

namespace OpenVX
{
	public partial class VX
	{
		public const string OPENVX_KHR_NN = "vx_khr_nn";

		public const int LIBRARY_KHR_NN_EXTENSION = 0x1;

		public const int KERNEL_CONVOLUTION_LAYER = (((ID_KHRONOS) << 20) | ( LIBRARY_KHR_NN_EXTENSION << 12)) + 0x0;

		public const int KERNEL_FULLYCONNECTED_LAYER = (((ID_KHRONOS) << 20) | ( LIBRARY_KHR_NN_EXTENSION << 12)) + 0x1;

		public const int KERNEL_POOLING_LAYER = (((ID_KHRONOS) << 20) | ( LIBRARY_KHR_NN_EXTENSION << 12)) + 0x2;

		public const int KERNEL_SOFTMAX_LAYER = (((ID_KHRONOS) << 20) | ( LIBRARY_KHR_NN_EXTENSION << 12)) + 0x3;

		public const int KERNEL_NORMALIZATION_LAYER = (((ID_KHRONOS) << 20) | ( LIBRARY_KHR_NN_EXTENSION << 12)) + 0x4;

		public const int KERNEL_ACTIVATION_LAYER = (((ID_KHRONOS) << 20) | ( LIBRARY_KHR_NN_EXTENSION << 12)) + 0x5;

		public const int KERNEL_ROIPOOLING_LAYER = (((ID_KHRONOS) << 20) | ( LIBRARY_KHR_NN_EXTENSION << 12)) + 0x6;

		public const int KERNEL_DECONVOLUTION_LAYER = (((ID_KHRONOS) << 20) | ( LIBRARY_KHR_NN_EXTENSION << 12)) + 0x7;

		public const int ENUM_NN_ROUNDING_TYPE = 0x18;

		public const int ENUM_NN_POOLING_TYPE = 0x19;

		public const int ENUM_NN_NORMALIZATION_TYPE = 0x1A;

		public const int ENUM_NN_ACTIVATION_FUNCTION_TYPE = 0x1B;

		public const int NN_DS_SIZE_ROUNDING_FLOOR = ((ID_KHRONOS << 20) | ( ENUM_NN_ROUNDING_TYPE << 12)) + 0x0;

		public const int NN_DS_SIZE_ROUNDING_CEILING = ((ID_KHRONOS << 20) | ( ENUM_NN_ROUNDING_TYPE << 12)) + 0x1;

		public const int NN_POOLING_MAX = ((ID_KHRONOS << 20) | ( ENUM_NN_POOLING_TYPE << 12)) + 0x0;

		public const int NN_POOLING_AVG = ((ID_KHRONOS << 20) | ( ENUM_NN_POOLING_TYPE << 12)) + 0x1;

		public const int NN_NORMALIZATION_SAME_MAP = ((ID_KHRONOS << 20) | ( ENUM_NN_NORMALIZATION_TYPE << 12)) + 0x0;

		public const int NN_NORMALIZATION_ACROSS_MAPS = ((ID_KHRONOS << 20) | ( ENUM_NN_NORMALIZATION_TYPE << 12)) + 0x1;

		public const int NN_ACTIVATION_LOGISTIC = ((ID_KHRONOS << 20) | ( ENUM_NN_ACTIVATION_FUNCTION_TYPE << 12)) + 0x0;

		public const int NN_ACTIVATION_HYPERBOLIC_TAN = ((ID_KHRONOS << 20) | ( ENUM_NN_ACTIVATION_FUNCTION_TYPE << 12)) + 0x1;

		public const int NN_ACTIVATION_RELU = ((ID_KHRONOS << 20) | ( ENUM_NN_ACTIVATION_FUNCTION_TYPE << 12)) + 0x2;

		public const int NN_ACTIVATION_BRELU = ((ID_KHRONOS << 20) | ( ENUM_NN_ACTIVATION_FUNCTION_TYPE << 12)) + 0x3;

		public const int NN_ACTIVATION_SOFTRELU = ((ID_KHRONOS << 20) | ( ENUM_NN_ACTIVATION_FUNCTION_TYPE << 12)) + 0x4;

		public const int NN_ACTIVATION_ABS = ((ID_KHRONOS << 20) | ( ENUM_NN_ACTIVATION_FUNCTION_TYPE << 12)) + 0x5;

		public const int NN_ACTIVATION_SQUARE = ((ID_KHRONOS << 20) | ( ENUM_NN_ACTIVATION_FUNCTION_TYPE << 12)) + 0x6;

		public const int NN_ACTIVATION_SQRT = ((ID_KHRONOS << 20) | ( ENUM_NN_ACTIVATION_FUNCTION_TYPE << 12)) + 0x7;

		public const int NN_ACTIVATION_LINEAR = ((ID_KHRONOS << 20) | ( ENUM_NN_ACTIVATION_FUNCTION_TYPE << 12)) + 0x8;

		public static Node ConvolutionLayer(Graph graph, Tensor inputs, Tensor weights, Tensor biases, NnConvolutionParams[] convolution_params, UIntPtr size_of_convolution_params, Tensor outputs)
		{
			Node retValue;

			unsafe {
				fixed (NnConvolutionParams* p_convolution_params = convolution_params)
				{
					Debug.Assert(Delegates.pvxConvolutionLayer != null, "pvxConvolutionLayer not implemented");
					retValue = Delegates.pvxConvolutionLayer(graph, inputs, weights, biases, p_convolution_params, size_of_convolution_params, outputs);
					LogCommand("vxConvolutionLayer", retValue, graph, inputs, weights, biases, convolution_params, size_of_convolution_params, outputs					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static Node FullyConnectedLayer(Graph graph, Tensor inputs, Tensor weights, Tensor biases, int overflow_policy, int rounding_policy, Tensor outputs)
		{
			Node retValue;

			Debug.Assert(Delegates.pvxFullyConnectedLayer != null, "pvxFullyConnectedLayer not implemented");
			retValue = Delegates.pvxFullyConnectedLayer(graph, inputs, weights, biases, overflow_policy, rounding_policy, outputs);
			LogCommand("vxFullyConnectedLayer", retValue, graph, inputs, weights, biases, overflow_policy, rounding_policy, outputs			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static Node PoolingLayer(Graph graph, Tensor inputs, int pooling_type, UIntPtr pooling_size_x, UIntPtr pooling_size_y, UIntPtr pooling_padding_x, UIntPtr pooling_padding_y, int rounding, Tensor outputs)
		{
			Node retValue;

			Debug.Assert(Delegates.pvxPoolingLayer != null, "pvxPoolingLayer not implemented");
			retValue = Delegates.pvxPoolingLayer(graph, inputs, pooling_type, pooling_size_x, pooling_size_y, pooling_padding_x, pooling_padding_y, rounding, outputs);
			LogCommand("vxPoolingLayer", retValue, graph, inputs, pooling_type, pooling_size_x, pooling_size_y, pooling_padding_x, pooling_padding_y, rounding, outputs			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static Node SoftmaxLayer(Graph graph, Tensor inputs, Tensor outputs)
		{
			Node retValue;

			Debug.Assert(Delegates.pvxSoftmaxLayer != null, "pvxSoftmaxLayer not implemented");
			retValue = Delegates.pvxSoftmaxLayer(graph, inputs, outputs);
			LogCommand("vxSoftmaxLayer", retValue, graph, inputs, outputs			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static Node NormalizationLayer(Graph graph, Tensor inputs, int type, UIntPtr normalization_size, float alpha, float beta, Tensor outputs)
		{
			Node retValue;

			Debug.Assert(Delegates.pvxNormalizationLayer != null, "pvxNormalizationLayer not implemented");
			retValue = Delegates.pvxNormalizationLayer(graph, inputs, type, normalization_size, alpha, beta, outputs);
			LogCommand("vxNormalizationLayer", retValue, graph, inputs, type, normalization_size, alpha, beta, outputs			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static Node ActivationLayer(Graph graph, Tensor inputs, int function, float a, float b, Tensor outputs)
		{
			Node retValue;

			Debug.Assert(Delegates.pvxActivationLayer != null, "pvxActivationLayer not implemented");
			retValue = Delegates.pvxActivationLayer(graph, inputs, function, a, b, outputs);
			LogCommand("vxActivationLayer", retValue, graph, inputs, function, a, b, outputs			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public static Node DeconvolutionLayer(Graph graph, Tensor inputs, Tensor weights, Tensor biases, NnDeconvolutionParams[] deconvolution_params, UIntPtr size_of_deconv_params, Tensor outputs)
		{
			Node retValue;

			unsafe {
				fixed (NnDeconvolutionParams* p_deconvolution_params = deconvolution_params)
				{
					Debug.Assert(Delegates.pvxDeconvolutionLayer != null, "pvxDeconvolutionLayer not implemented");
					retValue = Delegates.pvxDeconvolutionLayer(graph, inputs, weights, biases, p_deconvolution_params, size_of_deconv_params, outputs);
					LogCommand("vxDeconvolutionLayer", retValue, graph, inputs, weights, biases, deconvolution_params, size_of_deconv_params, outputs					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal static unsafe partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity]
			internal delegate Node vxConvolutionLayer(Graph graph, Tensor inputs, Tensor weights, Tensor biases, NnConvolutionParams* convolution_params, UIntPtr size_of_convolution_params, Tensor outputs);

			internal static vxConvolutionLayer pvxConvolutionLayer;

			[SuppressUnmanagedCodeSecurity]
			internal delegate Node vxFullyConnectedLayer(Graph graph, Tensor inputs, Tensor weights, Tensor biases, int overflow_policy, int rounding_policy, Tensor outputs);

			internal static vxFullyConnectedLayer pvxFullyConnectedLayer;

			[SuppressUnmanagedCodeSecurity]
			internal delegate Node vxPoolingLayer(Graph graph, Tensor inputs, int pooling_type, UIntPtr pooling_size_x, UIntPtr pooling_size_y, UIntPtr pooling_padding_x, UIntPtr pooling_padding_y, int rounding, Tensor outputs);

			internal static vxPoolingLayer pvxPoolingLayer;

			[SuppressUnmanagedCodeSecurity]
			internal delegate Node vxSoftmaxLayer(Graph graph, Tensor inputs, Tensor outputs);

			internal static vxSoftmaxLayer pvxSoftmaxLayer;

			[SuppressUnmanagedCodeSecurity]
			internal delegate Node vxNormalizationLayer(Graph graph, Tensor inputs, int type, UIntPtr normalization_size, float alpha, float beta, Tensor outputs);

			internal static vxNormalizationLayer pvxNormalizationLayer;

			[SuppressUnmanagedCodeSecurity]
			internal delegate Node vxActivationLayer(Graph graph, Tensor inputs, int function, float a, float b, Tensor outputs);

			internal static vxActivationLayer pvxActivationLayer;

			[SuppressUnmanagedCodeSecurity]
			internal delegate Node vxDeconvolutionLayer(Graph graph, Tensor inputs, Tensor weights, Tensor biases, NnDeconvolutionParams* deconvolution_params, UIntPtr size_of_deconv_params, Tensor outputs);

			internal static vxDeconvolutionLayer pvxDeconvolutionLayer;

		}
	}

}
