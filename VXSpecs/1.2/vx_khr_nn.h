/* 
 * Copyright (c) 2012-2017 The Khronos Group Inc.
 *
 * Permission is hereby granted, free of charge, to any person obtaining a
 * copy of this software and/or associated documentation files (the
 * "Materials"), to deal in the Materials without restriction, including
 * without limitation the rights to use, copy, modify, merge, publish,
 * distribute, sublicense, and/or sell copies of the Materials, and to
 * permit persons to whom the Materials are furnished to do so, subject to
 * the following conditions:
 *
 * The above copyright notice and this permission notice shall be included
 * in all copies or substantial portions of the Materials.
 *
 * MODIFICATIONS TO THIS FILE MAY MEAN IT NO LONGER ACCURATELY REFLECTS
 * KHRONOS STANDARDS. THE UNMODIFIED, NORMATIVE VERSIONS OF KHRONOS
 * SPECIFICATIONS AND HEADER INFORMATION ARE LOCATED AT
 *    https://www.khronos.org/registry/
 *
 * THE MATERIALS ARE PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
 * IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
 * CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
 * TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
 * MATERIALS OR THE USE OR OTHER DEALINGS IN THE MATERIALS.
 */

#ifndef _VX_KHR_NN_H_
#define _VX_KHR_NN_H_

#ifdef  __cplusplus
extern "C" {
#endif

/*!
 * \file
 * \brief The Khronos Extension for Deep Convolutional Networks Functions.
 *
 * \defgroup group_cnn Extension: Deep Convolutional Networks API
 * \brief Convolutional Network Nodes.
 */

#define OPENVX_KHR_NN   "vx_khr_nn"


#include <VX/vx.h>



/*==============================================================================
CONVOLUTIONAL_NETWORK structs and enums
=============================================================================*/

/*! \brief The Neural Network Extension Library Set
 * \ingroup group_cnn
 */
#define VX_LIBRARY_KHR_NN_EXTENSION (0x1) 

/*! \brief The list of Neural Network Extension Kernels.
 * \ingroup group_cnn
 */
enum vx_kernel_nn_ext_e {
    /*! \brief The Neural Network Extension convolution Kernel.
    * \see group_cnn
    */
    VX_KERNEL_CONVOLUTION_LAYER = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_NN_EXTENSION) + 0x0,
    /*! \brief The Neural Network Extension fully connected Kernel.
    * \see group_cnn
    */
    VX_KERNEL_FULLYCONNECTED_LAYER = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_NN_EXTENSION) + 0x1,
    /*! \brief The Neural Network Extension pooling Kernel.
    * \see group_cnn
    */
    VX_KERNEL_POOLING_LAYER = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_NN_EXTENSION) + 0x2,
    /*! \brief The Neural Network Extension softmax Kernel.
    * \see group_cnn
    */
    VX_KERNEL_SOFTMAX_LAYER = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_NN_EXTENSION) + 0x3,
    /*! \brief The Neural Network Extension normalization Kernel.
    * \see group_cnn
    */
    VX_KERNEL_NORMALIZATION_LAYER = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_NN_EXTENSION) + 0x4,
    /*! \brief The Neural Network Extension activation Kernel.
    * \see group_cnn
    */
    VX_KERNEL_ACTIVATION_LAYER = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_NN_EXTENSION) + 0x5,
    /*! \brief The Neural Network POI Pooling Kernel.
    * \see group_cnn
    */
    VX_KERNEL_ROIPOOLING_LAYER = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_NN_EXTENSION) + 0x6,
    /*! \brief The Neural Network Extension Deconvolution Kernel.
    * \see group_cnn
    */
    VX_KERNEL_DECONVOLUTION_LAYER = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_NN_EXTENSION) + 0x7,
};

/*! \brief NN extension type enums.
 * \ingroup group_cnn
 */
enum vx_nn_enum_e
{
    VX_ENUM_NN_ROUNDING_TYPE	= 0x18,
    VX_ENUM_NN_POOLING_TYPE	= 0x19,
    VX_ENUM_NN_NORMALIZATION_TYPE	= 0x1A,
    VX_ENUM_NN_ACTIVATION_FUNCTION_TYPE	= 0x1B,
};

/*! \brief down scale rounding.
 * \details Due to different scheme of downscale size calculation in the various training frameworks. Implementation must support 2 rounding methods for down scale calculation.
 * The floor and the ceiling. In convolution and pooling functions.
 * Relevant when input size is even.
 * \ingroup group_cnn
 */
enum vx_nn_rounding_type_e
{
    /*! \brief floor rounding  */
    VX_NN_DS_SIZE_ROUNDING_FLOOR = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_ROUNDING_TYPE) + 0x0,
    /*! \brief ceil rounding */
    VX_NN_DS_SIZE_ROUNDING_CEILING = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_ROUNDING_TYPE) + 0x1
};


/*! \brief The Neural Network pooling type list.
 * \details kind of pooling done in pooling function
 * \ingroup group_cnn
 */
enum vx_nn_pooling_type_e
{
    /*! \brief max pooling*/
    VX_NN_POOLING_MAX = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_POOLING_TYPE) + 0x0,
    /*! \brief average pooling*/
    VX_NN_POOLING_AVG = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_POOLING_TYPE) + 0x1
};


/*! \brief The Neural Network normalization type list.
 * \ingroup group_cnn
 */
enum vx_nn_norm_type_e
{
    /*! \brief normalization is done on same IFM*/
    VX_NN_NORMALIZATION_SAME_MAP = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_NORMALIZATION_TYPE) + 0x0,
    /*! \brief Normalization is done across different IFMs*/
    VX_NN_NORMALIZATION_ACROSS_MAPS = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_NORMALIZATION_TYPE) + 0x1,
};



/*! \brief The Neural Network activation functions list.
 * \details
 * <table>
 * <tr><td> <B>Function name </B> <td> <B>Mathematical definition</B> <td> <B>Parameters</B> <td> <B>Parameters type</B>
 * <tr><td>logistic <td> \f$f(x)=1/(1+e^{-x}) \f$  <td>  <td>
 * <tr><td>hyperbolic tangent <td> \f$f(x)=a\cdot tanh(b\cdot x) \f$  <td> a,b  <td> VX_FLOAT32
 * <tr><td>relu <td> \f$f(x)=max(0,x)\f$  <td>  <td>
 * <tr><td>bounded relu <td> \f$f(x)=min(a,max(0,x)) \f$  <td> a  <td> VX_FLOAT32
 * <tr><td>soft relu <td> \f$f(x)=log(1+e^{x}) \f$  <td>  <td>
 * <tr><td>abs <td> \f$f(x)=\mid x\mid \f$  <td>  <td>
 * <tr><td>square <td> \f$f(x)= x^2 \f$  <td>  <td>
 * <tr><td>square root <td> \f$f(x)=\sqrt{x} \f$  <td>  <td>
 * <tr><td>linear <td> \f$f(x)=ax+b \f$  <td>  a,b  <td> VX_FLOAT32
 * </table>
 * \ingroup group_cnn
 */
enum vx_nn_activation_function_e
{
    VX_NN_ACTIVATION_LOGISTIC = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_ACTIVATION_FUNCTION_TYPE) + 0x0,
    VX_NN_ACTIVATION_HYPERBOLIC_TAN = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_ACTIVATION_FUNCTION_TYPE) + 0x1,
    VX_NN_ACTIVATION_RELU = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_ACTIVATION_FUNCTION_TYPE) + 0x2,
    VX_NN_ACTIVATION_BRELU = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_ACTIVATION_FUNCTION_TYPE) + 0x3,
    VX_NN_ACTIVATION_SOFTRELU = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_ACTIVATION_FUNCTION_TYPE) + 0x4,
    VX_NN_ACTIVATION_ABS = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_ACTIVATION_FUNCTION_TYPE) + 0x5,
    VX_NN_ACTIVATION_SQUARE = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_ACTIVATION_FUNCTION_TYPE) + 0x6,
    VX_NN_ACTIVATION_SQRT = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_ACTIVATION_FUNCTION_TYPE) + 0x7,
    VX_NN_ACTIVATION_LINEAR = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_ACTIVATION_FUNCTION_TYPE) + 0x8,
};

/*! \brief Input parameters for a convolution operation.
 * \ingroup group_cnn
 */
typedef struct _vx_nn_convolution_params_t
{
    vx_size padding_x;                 /*!< \brief Number of elements added at each side in the x dimension of the input. */
    vx_size padding_y;                 /*!< \brief Number of elements added at each side in the y dimension of the input. */
	vx_enum overflow_policy;         /*!< \brief A <tt> VX_TYPE_ENUM</tt> of the <tt> vx_convert_policy_e</tt> enumeration. */
    vx_enum rounding_policy;         /*!< \brief A <tt> VX_TYPE_ENUM</tt> of the <tt> vx_round_policy_e</tt> enumeration. */
    vx_enum down_scale_size_rounding; /*!< \brief Rounding method for calculating output dimensions. See <tt>\ref vx_nn_rounding_type_e</tt> */
    vx_size dilation_x;            /*!< \brief “inflate” the kernel by inserting zeros between the kernel elements in the x direction. The value is the number of zeros to insert.*/
    vx_size dilation_y;            /*!< \brief “inflate” the kernel by inserting zeros between the kernel elements in the y direction. The value is the number of zeros to insert.*/
} vx_nn_convolution_params_t;


/*! \brief Input parameters for a deconvolution operation.
 * \ingroup group_cnn
 */
typedef struct _vx_nn_deconvolution_params_t
{
    vx_size padding_x;                 /*!< \brief Number of elements subtracted at each side in the x dimension of the input. */
    vx_size padding_y;                 /*!< \brief Number of elements subtracted at each side in the y dimension of the input. */
	vx_enum overflow_policy;         /*!< \brief A <tt> VX_TYPE_ENUM</tt> of the <tt> vx_convert_policy_e</tt> enumeration. */
    vx_enum rounding_policy;         /*!< \brief A <tt> VX_TYPE_ENUM</tt> of the <tt> vx_round_policy_e</tt> enumeration. */
    vx_size a_x;                 /*!< \brief user-specified quantity used to distinguish between the \f$upscale_x\f$ different possible output sizes. */
    vx_size a_y;                 /*!< \brief user-specified quantity used to distinguish between the \f$upscale_y\f$ different possible output sizes. */
} vx_nn_deconvolution_params_t;

/*! \brief Input parameters for ROI pooling operation.
 * \ingroup group_cnn
 */
typedef struct _vx_nn_roi_pool_params_t
{
	vx_enum pool_type;  /*!< \brief Of type <tt>\ref vx_nn_pooling_type_e</tt>. Only <tt>\ref VX_NN_POOLING_MAX</tt> pooling is supported. */
} vx_nn_roi_pool_params_t;

/*==============================================================================
    NN Nodes
=============================================================================*/
/*! \brief [Graph] Creates a Convolutional Network Convolution Layer Node.
 * \details This function implement Convolutional Network Convolution layer.
 *  For fixed-point data types, a fixed point calculation is performed with round and saturate according to the number of accumulator bits. The number of the accumulator bits are implementation defined,
 * and should be at least 16.\n
 * round: rounding according the <tt>vx_round_policy_e</tt> enumeration. \n
 * saturate: A saturation according the <tt>vx_convert_policy_e</tt> enumeration.
 * The following equation is implemented: \n
 * \f$ outputs[j,k,i] = saturate(round(\sum_{l} (\sum_{m,n} inputs[j-m,k-n,l] \times weights[m,n,l,i])+biasses[j,k,i])) \f$\n
 * Where \f$m,n\f$ are indexes on the convolution matrices. \f$ l\f$ is an index on all the convolutions per input.\f$ i\f$ is an index per output.
 * \f$ j,k \f$ are the inputs/outputs spatial indexes.
 * Convolution is done on the width and height dimensions of the <tt>\ref vx_tensor</tt>. Therefore, we use here the term x for index along the width dimension and y for index along the height dimension.\n
 * before the Convolution is done, a padding with zeros of the width and height input dimensions is performed.
 * Then down scale is done by picking the results according to a skip jump. The skip in the x and y is determined by the output size dimensions.
 * The relation between input to output is as follows: \n
 * \f$ width_{output} = round(\frac{(width_{input} + 2 * padding_x - kernel_x - (kernel_x -1) * dilation_x)}{skip_x} + 1) \f$\n
 * and \n
 * \f$ height_{output} = round(\frac{(height + 2 * padding_y - kernel_y - (kernel_y -1) * dilation_y)}{skip_y} + 1) \f$\n 
 * where \f$width\f$ is the size of the input width dimension. \f$height\f$ is the size of the input height dimension.
 * \f$width_{output}\f$ is the size of the output width dimension. \f$height_{output}\f$ is the size of the output height dimension.
 * \f$kernel_x\f$ and \f$kernel_y\f$ are the convolution sizes in width and height dimensions.
 * skip is calculated by the relation between input and output.
 * rounding is done according to <tt>\ref vx_nn_rounding_type_e</tt>.
 * \param [in] graph The handle to the graph.
 * \param [in] inputs The input tensor data. 3 lower dimensions represent a single input, all following dimensions represent number of batches, possibly nested.
 * The dimension order is [width, height, #IFM, #batches]\n. Implementations must support input tensor data types indicated by the extension strings 'KHR_NN_8' or 'KHR_NN_8 KHR_NN_16'.  
 * \param [in] weights Weights are 4d tensor with dimensions [kernel_x, kernel_y, #IFM, #OFM]. see <tt>\ref vxCreateTensor</tt> and <tt>\ref vxCreateVirtualTensor</tt> \n Weights data type must match the data type of the inputs. 
 * \param [in] biases Optional, ignored if NULL. The biases, which may be shared (one per ofm) or unshared (one per ofm * output location). The possible layouts are
 * either [#OFM] or [width, height, #OFM]. Biases data type must match the data type of the inputs.  
 * \param [in] convolution_params Pointer to parameters of type <tt>\ref vx_nn_convolution_params_t</tt>
 * \param [in] size_of_convolution_params Size in bytes of convolution_params.
 * \param [out] outputs The output tensor data. Output will have the same number and structure of dimensions as input. Output tensor data type must be same as the inputs.
 * \return <tt> vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_cnn
 */
VX_API_ENTRY vx_node VX_API_CALL vxConvolutionLayer(vx_graph graph, vx_tensor inputs, vx_tensor weights, vx_tensor biases, const vx_nn_convolution_params_t *convolution_params, vx_size size_of_convolution_params, vx_tensor outputs);

/*! \brief [Graph] Creates a Fully connected Convolutional Network Layer Node.
 * \details This function implement Fully connected Convolutional Network layers.
 * For fixed-point data types, a fixed point calculation is performed with round and saturate according to the number of accumulator bits. The number of the accumulator bits are implementation defined,
 * and should be at least 16.\n
 * round: rounding according the <tt>vx_round_policy_e</tt> enumeration. \n
 * saturate: A saturation according the <tt>vx_convert_policy_e</tt> enumeration.
 * The equation for Fully connected layer:\n
 * \f$ outputs[i] = saturate(round(\sum_{j} (inputs[j] \times weights[j,i])+biasses[i])) \f$\n
 * Where \f$j\f$ is a index on the input feature and \f$i\f$ is a index on the output.
 * before the fully connected is done, a padding of the input is performed.
 * Then down scale is done by picking the results according to a skip jump. The skip is determined by the output size dimensions.
 * The relation between input to output is as follows:
 * \f$ size_{output} = round(\frac{(size_{input} + 2 * padding)}{skip} + 1) \f$\n
 * where \f$size_{input}\f$ is the size of the input dimension.
 * \f$size_{output}\f$ is the size of the output dimension.
 * skip is calculated by the relation between input and output.
 * rounding is done according to <tt>\ref vx_nn_rounding_type_e</tt>.
 * \param [in] graph The handle to the graph.
 * \param [in] inputs The input tensor data. There two possible input layouts:
 * 1. [#IFM, #batches]. See <tt>\ref vxCreateTensor</tt> and <tt>\ref vxCreateVirtualTensor</tt>.
 * 2. [width, height, #IFM, #batches]. See <tt>\ref vxCreateTensor</tt> and <tt>\ref vxCreateVirtualTensor</tt>\n
 * In both cases number of batches are optional and may be multidimensional.
 * The second option is a special case to deal with convolution layer followed by fully connected.
 * The dimension order is [#IFM, #batches]. See <tt>\ref vxCreateTensor</tt> and <tt>\ref vxCreateVirtualTensor</tt>. Note that batch may be multidimensional. Implementations must support input tensor data types indicated by the extension strings 'KHR_NN_8' or 'KHR_NN_8 KHR_NN_16'. 
 * \param [in] weights Number of dimensions is 2. Dimensions are [#IFM, #OFM]. See <tt>\ref vxCreateTensor</tt> and <tt>\ref vxCreateVirtualTensor</tt>.\n Implementations must support input tensor data type same as the inputs.
 * \param [in] biases Optional, ignored if NULL. The biases have one dimension [#OFM]. Implementations must support input tensor data type same as the inputs.
 * \param [in] overflow_policy A <tt> VX_TYPE_ENUM</tt> of the <tt> vx_convert_policy_e</tt> enumeration.
 * \param [in] rounding_policy A <tt> VX_TYPE_ENUM</tt> of the <tt> vx_round_policy_e</tt> enumeration.
 * \param [out] outputs The output tensor data. Output dimension layout is [#OFM,#batches]. See <tt>\ref vxCreateTensor</tt> and <tt>\ref vxCreateVirtualTensor</tt>, where #batches may be multidimensional. Output tensor data type must be same as the inputs.
 * \return <tt> vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_cnn
 */
VX_API_ENTRY vx_node VX_API_CALL vxFullyConnectedLayer(vx_graph graph, vx_tensor inputs, vx_tensor weights, vx_tensor biases, vx_enum overflow_policy, vx_enum rounding_policy, vx_tensor outputs);


/*! \brief [Graph] Creates a Convolutional Network Pooling Layer Node.
 * \details Pooling is done on the width and height dimensions of the <tt>\ref vx_tensor</tt>. Therefore, we use here the term x for the width dimension and y for the height dimension.\n
 * Pooling operation is a function operation over a rectangle size and then a nearest neighbour down scale.
 * Here we use pooling_size_x and pooling_size_y to specify the rectangle size on which the operation
 * is performed. \n
 * before the operation is done (average or maximum value). the data is padded with zeros in width and height dimensions .
 * The down scale is done by picking the results according to a skip jump. The skip in the x and y dimension is determined by the output size dimensions.
 * The first pixel of the down scale output is the first pixel in the input.
 * \param [in] graph The handle to the graph.
 * \param [in] inputs The input tensor data. 3 lower dimensions represent a single input, 4th dimension for batch of inputs is optional.Dimension layout is [width, height, #IFM, #batches].
 * See <tt>\ref vxCreateTensor</tt> and <tt>\ref vxCreateVirtualTensor</tt> 
 * Implementations must support input tensor data types indicated by the extension strings 'KHR_NN_8' or 'KHR_NN_8 KHR_NN_16'. 
 * \param [in] pooling_type Either max pooling or average pooling (see <tt>\ref vx_nn_pooling_type_e</tt>).
 * \param [in] pooling_size_x Size of the pooling region in the x dimension
 * \param [in] pooling_size_y Size of the pooling region in the y dimension.
 * \param [in] pooling_padding_x Padding size in the x dimension.
 * \param [in] pooling_padding_y Padding size in the y dimension.
 * \param [in] rounding, Rounding method for calculating output dimensions. See <tt>\ref vx_nn_rounding_type_e</tt>
 * \param [out] outputs The output tensor data. Output will have the same number of dimensions as input. Output tensor data type must be same as the inputs.
 * \return <tt> vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_cnn
 */
VX_API_ENTRY vx_node VX_API_CALL vxPoolingLayer(vx_graph graph, vx_tensor inputs, vx_enum pooling_type,
        vx_size pooling_size_x,
        vx_size pooling_size_y,
        vx_size pooling_padding_x,
        vx_size pooling_padding_y,
        vx_enum rounding, 
        vx_tensor outputs);

/*! \brief [Graph] Creates a Convolutional Network Softmax Layer Node.
 * \details  the softmax function, is a generalization of the logistic function that "squashes" a K-dimensional vector \f$ z \f$ of arbitrary real values to a K-dimensional vector
 * \f$ \sigma(z) \f$ of real values in the range (0, 1) that add up to 1. The function is given by:
 * \f$ \sigma(z) = \frac{\exp^z}{\sum_i \exp^{z_i}} \f$
 * \param [in] graph The handle to the graph.
 * \param [in] inputs The input tensor,  with the number of dimensions according to the following scheme. 
 * In case IFM dimension is 1. Softmax is be calculated on that dimension.
 * In case IFM dimension is 2. Softmax is be calculated on the first dimension. The second dimension is batching.
 * In case IFM dimension is 3. Dimensions are [Width, Height, Classes]. And Softmax is calculated on the third dimension.
 * In case IFM dimension is 4. Dimensions are [Width, Height, Classes, batching]. Softmax is calculated on the third dimension.
 * Regarding the layout specification, see <tt>\ref vxCreateTensor</tt> and <tt>\ref vxCreateVirtualTensor</tt>.
 * In all cases Implementations must support input tensor data types indicated by the extension strings 'KHR_NN_8' or 'KHR_NN_8 KHR_NN_16'. 
 * \param [out] outputs The output tensor. Output will have the same number of dimensions as input. Output tensor data type must be same as the inputs.
 * \ingroup group_cnn
 * \return <tt> vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */

VX_API_ENTRY vx_node VX_API_CALL vxSoftmaxLayer(vx_graph graph, vx_tensor inputs, vx_tensor outputs);

/*! \brief [Graph] Creates a Convolutional Network Normalization Layer Node. This function is optional for 8-bit extension with the extension string 'KHR_NN_8'. 
 * \details Normalizing over local input regions. Each input value is divided by \f$ (1+\frac{\alpha}{n}\sum_i x^2_i)^\beta \f$ , where n is the number of elements to normalize across.
 * and the sum is taken over a rectangle region centred at that value (zero padding is added where necessary).
 * \param [in] graph The handle to the graph.
 * \param [in] inputs The input tensor data. 3 lower dimensions represent a single input, 4th dimension for batch of inputs is optional.Dimension layout is [width, height, IFM, #batches].
 * See <tt>\ref vxCreateTensor</tt> and <tt>\ref vxCreateVirtualTensor</tt>.
 * Implementations must support input tensor data types indicated by the extension strings 'KHR_NN_8 KHR_NN_16'. 
 * Since this function is optional for 'KHR_NN_8', so implementations only must support <tt>VX_TYPE_INT16</tt> with fixed_point_position 8.
 * \param [in] type Either same map or across maps (see <tt>\ref vx_nn_norm_type_e</tt>).
 * \param [in] normalization_size Number of elements to normalize across. Must be a positive odd number with maximum size of 7 and minimum of 3.
 * \param [in] alpha Alpha parameter in the normalization equation. must be positive.
 * \param [in] beta  Beta parameter in the normalization equation. must be positive.
 * \param [out] outputs The output tensor data. Output will have the same number of dimensions as input.
 * \ingroup group_cnn
 * \return <tt> vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_node VX_API_CALL vxNormalizationLayer(vx_graph graph, vx_tensor inputs, vx_enum type,
        vx_size normalization_size,
        vx_float32 alpha,
        vx_float32 beta,
        vx_tensor outputs);

/*! \brief [Graph] Creates a Convolutional Network Activation Layer Node.
 * The function operate a specific function (Specified in <tt>\ref vx_nn_activation_function_e</tt>), On the input data.
 * the equation for the layer is:
 * \f$ outputs(i,j,k,l) = function(inputs(i,j,k,l), a, b) \f$ for all i,j,k,l.
 * \param [in] graph The handle to the graph.
 * \param [in] inputs The input tensor data.
 * Implementations must support input tensor data types indicated by the extension strings 'KHR_NN_8' or 'KHR_NN_8 KHR_NN_16'. 
 * \param [in] function Non-linear function (see <tt>\ref vx_nn_activation_function_e</tt>). Implementations must support <tt>\ref VX_NN_ACTIVATION_LOGISTIC</tt>, <tt>\ref VX_NN_ACTIVATION_HYPERBOLIC_TAN</tt> and <tt>\ref VX_NN_ACTIVATION_RELU</tt>
 * \param [in] a Function parameters a. must be positive.
 * \param [in] b Function parameters b. must be positive.
 * \param [out] outputs The output tensor data. Output will have the same number of dimensions as input.
 * \ingroup group_cnn
 * \return <tt> vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_node VX_API_CALL vxActivationLayer(vx_graph graph, vx_tensor inputs, vx_enum function, vx_float32 a,vx_float32 b, vx_tensor outputs); 

/*! \brief [Graph] Creates a Convolutional Network ROI pooling node
 * \details Pooling is done on the width and height dimensions of the <tt>\ref vx_tensor</tt>. The ROI Pooling get an array of roi rectangles, and an input tensor.
 * The kernel crop the width and height dimensions of the input tensor with the ROI rectangles and down scale the result to the size of the output tensor. The output tensor width and height are the pooled width and pooled height.
 * The down scale method is determined by the pool_type.
 * \param [in] graph The handle to the graph.
 * \param [in] inputs The input tensor data. 3 lower dimensions represent a single input, 4th dimension for batch of inputs is optional. Dimension layout is [width, height, #IFM, #batches]. 
 * See <tt>\ref vxCreateTensor</tt> and <tt>\ref vxCreateVirtualTensor</tt>.
 * Implementations must support input tensor data types indicated by the extension strings 'KHR_NN_8' or 'KHR_NN_8 KHR_NN_16'. 
 * \param [in] inputs_rois The roi array tensor. ROI array with dimensions [4, roi_count, #batches] where the first dimension represents 4 coordinates of the top left and bottom right corners of the roi rectangles, based on the input tensor width and height.
 * #batches is optional and must be the same as in inputs. roi_count is the number of ROI rectangles.
 * \param [in] pool_type Of type <tt>\ref vx_nn_pooling_type_e</tt>. Only <tt>\ref VX_NN_POOLING_MAX</tt> pooling is supported. 
 * \param [in] size_of_roi_params Size in bytes of roi_pool_params.
 * \param [out] output_arr The output tensor. Output will have [output_width, output_height, #IFM, #batches] dimensions. #batches is optional and must be the same as in inputs.
 * \ingroup group_cnn
 * \return <tt> vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_node vxROIPoolingLayer(vx_graph graph, vx_tensor input_data, vx_tensor input_rois,const vx_nn_roi_pool_params_t *roi_pool_params,vx_size size_of_roi_params, vx_tensor output_arr);
				
				
/*! \brief [Graph] Creates a Convolutional Network Deconvolution Layer Node.
 * \details  Deconvolution denote a sort of reverse convolution, which importantly and confusingly is not actually a proper mathematical deconvolution.
 * Convolutional Network Deconvolution is up-sampling of an image by learned Deconvolution coefficients.
 * The operation is similar to convolution but can be implemented by up-sampling the inputs with zeros insertions between the inputs,
 * and convolving the Deconvolution kernels on the up-sampled result. 
 * For fixed-point data types, a fixed point calculation is performed with round and saturate according to the number of accumulator bits. The number of the accumulator bits are implementation defined,
 * and should be at least 16.\n
 * round: rounding according the <tt>vx_round_policy_e</tt> enumeration. \n
 * saturate: A saturation according the <tt>vx_convert_policy_e</tt> enumeration.
 * The following equation is implemented: \n
 * \f$ outputs[j,k,i] =  saturate(round(\sum_{l} \sum_{m,n}(inputs_{upscaled}[j-m,k-n,l] \times weights[m,n,l,i])+biasses[j,k,i])) \f$\n
 * Where \f$m,n\f$ are indexes on the convolution matrices. \f$ l\f$ is an index on all the convolutions per input.\f$ i\f$ is an index per output.
 * \f$ j,k \f$ are the inputs/outputs spatial indexes.
 * Deconvolution is done on the width and height dimensions of the <tt>\ref vx_tensor</tt>. Therefore, we use here the term x for the width dimension and y for the height dimension.\n
 * before the Deconvolution is done, up-scaling the width and height dimensions with zeros is performed.
 * The relation between input to output is as follows: \n
 * \f$ width_{output} = round( (width_{input} -1) * upscale_x  - 2 * padding_x + kernel_x + a_x) \f$\n
 * and \n
 * \f$ height_{output} = round( (height_{input} - 1) * upscale_y - 2 * padding_y + kernel_y + a_y) \f$\n 
 * where \f$width_{input}\f$ is the size of the input width dimension. \f$height_{input}\f$ is the size of the input height dimension.
 * \f$width_{output}\f$ is the size of the output width dimension. \f$height_{output}\f$ is the size of the output height dimension.
 * \f$kernel_x\f$ and \f$kernel_y\f$ are the convolution sizes in width and height. \f$a_x\f$ and \f$a_y\f$ are user-specified quantity used to distinguish between the \f$upscale_x\f$ and \f$upscale_y\f$ different possible output sizes
 * \f$upscale_x\f$ and \f$upscale_y\f$ are calculated by the relation between input and output.
 * rounding is done according to <tt>\ref vx_nn_rounding_type_e</tt>.
 * \param [in] graph The handle to the graph.
 * \param [in] inputs The input tensor. 3 lower dimensions represent a single input, and an optional 4th dimension for batch of inputs. Dimension layout is [width, height, #IFM, #batches].
 * See <tt>\ref vxCreateTensor</tt> and <tt>\ref vxCreateVirtualTensor</tt>.
 * Implementations must support input tensor data types indicated by the extension strings 'KHR_NN_8' or 'KHR_NN_8 KHR_NN_16'. 
 * \param [in] weights The 4d weights with dimensions [width, height, #IFM, #OFM]. See <tt>\ref vxCreateTensor</tt> and <tt>\ref vxCreateVirtualTensor</tt>.
 * \param [in] biases Optional, ignored if NULL. The biases have one dimension [#OFM]. Implementations must support input tensor data type same as the inputs.
 * \param [in] deconvolution_params Pointer to parameters of type <tt>\ref vx_nn_deconvolution_params_t</tt>
 * \param [in] size_of_deconv_params Size in bytes of deconvolution_params.
 * \param [out] outputs The output tensor. The output has the same number of dimensions as the input.
 * \ingroup group_cnn
 * \return <tt> vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_node VX_API_CALL vxDeconvolutionLayer(vx_graph graph, vx_tensor inputs, vx_tensor weights, vx_tensor  biases, const vx_nn_deconvolution_params_t *deconvolution_params, vx_size size_of_deconv_params, vx_tensor outputs);


#ifdef  __cplusplus
}
#endif


#endif
