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
 * \defgroup group_tensor Tensor API
 * \brief The Tensor API for Deep Convolutional Networks Functions.
 * \details The tensor is a multidimensional opaque object.Since the object have no visibility to the programmer. Vendors can introduce many optimization possibilities.
 * An example of such optimization can be found in the following article.http://arxiv.org/abs/1510.00149
 */

#define OPENVX_KHR_NN   "vx_khr_nn"


#include <VX/vx.h>

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
    /*! \brief The tensor multiply Kernel.
    * \see group_cnn
    */
    VX_KERNEL_TENSOR_MULTIPLY = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_NN_EXTENSION) + 0x6,

    /*! \brief The tensor add Kernel.
    * \see group_cnn
    */
    VX_KERNEL_TENSOR_ADD = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_NN_EXTENSION) + 0x7,

    /*! \brief The tensor subtract Kernel.
    * \see group_cnn
    */
    VX_KERNEL_TENSOR_SUBTRACT = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_NN_EXTENSION) + 0x8,

    /*! \brief The tensor table look up Kernel.
    * \see group_cnn
    */
    VX_KERNEL_TENSOR_TABLELOOKUP = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_NN_EXTENSION) + 0x9,

    /*! \brief The tensor transpose Kernel.
    * \see group_cnn
    */
    VX_KERNEL_TENSOR_TRANSPOSE = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_NN_EXTENSION) + 0xA
}; 

/*! \brief tensor Data attributes.
 * \ingroup group_tensor
 */
enum vx_tensor_attribute_e
{
    /*! \brief Number of dimensions. */
    VX_TENSOR_NUMBER_OF_DIMS = VX_ATTRIBUTE_BASE( VX_ID_KHRONOS, VX_TYPE_TENSOR ) + 0x0,
    /*! \brief Dimension sizes. */
    VX_TENSOR_DIMS        = VX_ATTRIBUTE_BASE( VX_ID_KHRONOS, VX_TYPE_TENSOR ) + 0x1,
    /*! \brief tensor Data element data type. <tt>vx_type_e</tt> */
    VX_TENSOR_DATA_TYPE   = VX_ATTRIBUTE_BASE( VX_ID_KHRONOS, VX_TYPE_TENSOR ) + 0x2,
    /*! \brief fixed point position when the input element type is int16. */
    VX_TENSOR_FIXED_POINT_POSITION = VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_TENSOR) + 0x3
};


/*! \brief A list of context attributes.
 * \ingroup group_tensor
 */
enum vx_tensor_context_attribute_e {
    /*! \brief tensor Data maximal number of dimensions supported by HW. */
    VX_CONTEXT_MAX_TENSOR_DIMS = VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_CONTEXT) + 0xE,
};


/*==============================================================================
CONVOLUTIONAL_NETWORK structs and enums
=============================================================================*/
/*! \brief The multidimensional data object (Tensor).
 * \see vxCreateTensor
 * \ingroup group_tensor
 * \extends vx_reference
 */
typedef struct _vx_tensor_t * vx_tensor;

/*! \brief The Convolutional Network down scaling size rounding type list.
 * \details rounding done downscaling, In convolution and pooling functions.
 * Relevant when input size is even.
 * \ingroup group_cnn
 */

/*! \brief Extra enums.
 * \ingroup group_cnn
 */
enum vx_nn_enum_e
{
    VX_ENUM_NN_ROUNDING_TYPE	= 0x18,
    VX_ENUM_NN_POOLING_TYPE	= 0x19,
    VX_ENUM_NN_NORMALIZATION_TYPE	= 0x1A,
    VX_ENUM_NN_ACTIVATION_FUNCTION	= 0x1B,
};


enum vx_nn_rounding_type_e
{
    /*! \brief floor rounding  */
    VX_NN_DS_SIZE_ROUNDING_FLOOR = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_ROUNDING_TYPE) + 0x0,
    /*! \brief ceil rounding */
    VX_NN_DS_SIZE_ROUNDING_CEILING = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_ROUNDING_TYPE) + 0x1
};


/*! \brief The Convolutional Network pooling type list.
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


/*! \brief The Convolutional Network normalization type list.
 * \ingroup group_cnn
 */
enum vx_nn_norm_type_e
{
    /*! \brief normalization is done on same IFM*/
    VX_NN_NORMALIZATION_SAME_MAP = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_NORMALIZATION_TYPE) + 0x0,
    /*! \brief Normalization is done across different IFMs*/
    VX_NN_NORMALIZATION_ACROSS_MAPS = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_NORMALIZATION_TYPE) + 0x1,
};



/*! \brief The Convolutional Network activation functions list.
 * \details
 * <table>
 * <tr><td> <B>Function name </B> <td> <B>Mathematical definition</B> <td> <B>Parameters</B> <td> <B>Parameters type</B>
 * <tr><td>logistic <td> \f$f(x)=1/(1+e^{-x}) \f$  <td>  <td>
 * <tr><td>hyperbolic tangent <td> \f$f(x)=a\cdot tanh(b\cdot x) \f$  <td> a,b  <td> VX_INT32
 * <tr><td>relu <td> \f$f(x)=max(0,x)\f$  <td>  <td>
 * <tr><td>bounded relu <td> \f$f(x)=min(a,max(0,x)) \f$  <td> a  <td> VX_INT32
 * <tr><td>soft relu <td> \f$f(x)=log(1+e^{x}) \f$  <td>  <td>
 * <tr><td>abs <td> \f$f(x)=\mid x\mid \f$  <td>  <td>
 * <tr><td>square <td> \f$f(x)= x^2 \f$  <td>  <td>
 * <tr><td>square root <td> \f$f(x)=\sqrt{x} \f$  <td>  <td>
 * <tr><td>linear <td> \f$f(x)=ax+b \f$  <td>  a,b  <td> VX_INT32
 * </table>
 * \ingroup group_cnn
 */
enum vx_nn_activation_function_e
{
    VX_NN_ACTIVATION_LOGISTIC = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_ACTIVATION_FUNCTION) + 0x0,
    VX_NN_ACTIVATION_HYPERBOLIC_TAN = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_ACTIVATION_FUNCTION) + 0x1,
    VX_NN_ACTIVATION_RELU = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_ACTIVATION_FUNCTION) + 0x2,
    VX_NN_ACTIVATION_BRELU = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_ACTIVATION_FUNCTION) + 0x3,
    VX_NN_ACTIVATION_SOFTRELU = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_ACTIVATION_FUNCTION) + 0x4,
    VX_NN_ACTIVATION_ABS = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_ACTIVATION_FUNCTION) + 0x5,
    VX_NN_ACTIVATION_SQUARE = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_ACTIVATION_FUNCTION) + 0x6,
    VX_NN_ACTIVATION_SQRT = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_ACTIVATION_FUNCTION) + 0x7,
    VX_NN_ACTIVATION_LINEAR = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_NN_ACTIVATION_FUNCTION) + 0x8,
};

/* END CNN types*/

/*==============================================================================
    TENSOR DATA FUNCTIONS
=============================================================================*/
/*! \brief Creates an opaque reference to a tensor data buffer.
 * \details Not guaranteed to exist until the <tt>vx_graph</tt> containing it has been verified.
 * \param [in] context The reference to the implementation context.
 * \param [in] number_of_dimensions The number of dimensions.
 * \param [in] dimensions Dimensions sizes in elements.
 * \param [in] data_type The <tt>vx_type_t</tt> that represents the data type of the tensor data elements. Implementations must support data type <tt>VX_TYPE_INT16</tt>. with fixed_point_position 8. 
 * \param [in] fixed_point_position Specifies the fixed point position when the input element type is int16, if 0 calculations are performed in integer math
 * \return A tensor data reference. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_tensor
 */
VX_API_ENTRY vx_tensor VX_API_CALL vxCreateTensor(vx_context context, vx_size number_of_dims, const vx_size * dims, vx_enum data_type,vx_uint8 fixed_point_position);

/*! \brief Creates an array of images into the multi-dimension data, this can be adjacent 2D images or not depending on the stride value.
 * The stride value is representing bytes in the third dimension.
 * The OpenVX image object that points to a three dimension data and access it as an array of images.
 * This has to be portion of the third lowest dimension, and the stride correspond to that third dimension.
 * The returned Object array is an array of images. Where the image data is pointing to a specific memory in the input tensor.
 * \param [in] tensor The tensor data from which to extract the images. Has to be a 3d tensor.
 * \param [in] rect Image coordinates within tensor data.
 * \param [in] array_size Number of images to extract.
 * \param [in] stride Delta between two images in the array.
 * \param [in] image_format The requested image format. Should match the tensor data's data type.
 * \return An array of images pointing to the tensor data's data.
 * \ingroup group_tensor
 */
VX_API_ENTRY vx_object_array VX_API_CALL vxCreateImageObjectArrayFromTensor(vx_tensor tensor, const vx_rectangle_t *rect, vx_size array_size, vx_size jump, vx_df_image image_format);

/*! \brief Creates a tensor data from another tensor data given a view. This second
 * reference refers to the data in the original tensor data. Updates to this tensor data
 * updates the parent tensor data. The view must be defined within the dimensions
 * of the parent tensor data.
 * \param [in] tensor The reference to the parent tensor data.
 * \param [in] number_of_dimensions Number of dimensions in the view. Error return if 0 or greater than number of
 * tensor dimensions. If smaller than number of tensor dimensions, the lower dimensions are assumed.
 * \param [in] view_start View start coordinates
 * \param [in] view_end View end coordinates
 * \return The reference to the sub-tensor. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_tensor
 */
VX_API_ENTRY vx_tensor VX_API_CALL vxCreateTensorFromView(vx_tensor tensor, vx_size number_of_dims, const vx_size * view_start, const vx_size * view_end);

/*! \brief Creates an opaque reference to a tensor data buffer with no direct
 * user access. This function allows setting the tensor data dimensions or data format.
 * \details Virtual data objects allow users to connect various nodes within a
 * graph via data references without access to that data, but they also permit the
 * implementation to take maximum advantage of possible optimizations. Use this
 * API to create a data reference to link two or more nodes together when the
 * intermediate data are not required to be accessed by outside entities. This API
 * in particular allows the user to define the tensor data format of the data without
 * requiring the exact dimensions. Virtual objects are scoped within the graph
 * they are declared a part of, and can't be shared outside of this scope.
 * \param [in] graph The reference to the parent graph.
 * \param [in] number_of_dimensions The number of dimensions.
 * \param [in] dimensions Dimensions sizes in elements.
 * \param [in] data_type The <tt>vx_type_t</tt> that represents the data type of the tensor data elements. Implementations must support data type <tt>VX_TYPE_INT16</tt>. with fixed_point_position 8. 
 * \param [in] fixed_point_position Specifies the fixed point position when the input element type is int16, if 0 calculations are performed in integer math
 * \return A tensor data reference.Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \note Passing this reference to <tt>\ref vxCopyTensorPatch</tt> will return an error.
 * \ingroup group_tensor
 */
VX_API_ENTRY vx_tensor VX_API_CALL vxCreateVirtualTensor(vx_graph graph, vx_size number_of_dims, vx_size *dims, vx_enum data_type, vx_uint8 fixed_point_position);


/*! \brief Allows the application to copy a view patch from/into an tensor object .
 * \param [in] tensor The reference to the tensor object that is the source or the
 * destination of the copy.
 * \param [in] number_of_dimensions Number of patch dimension. Error return if 0 or greater than number of
 * tensor dimensions. If smaller than number of tensor dimensions, the lower dimensions are assumed.
 * \param [in] view_start Array of patch start points in each dimension
 * \param [in] view_end Array of patch end points in each dimension
 * \param [in] user_stride Array of user memory strides in each dimension
 * \param [in] user_ptr The address of the memory location where to store the requested data
 * if the copy was requested in read mode, or from where to get the data to store into the tensor
 * object if the copy was requested in write mode. The accessible memory must be large enough
 * to contain the specified patch with the specified layout:\n
 * accessible memory in bytes >= (end[last_dimension] - start[last_dimension]) * stride[last_dimension].\m
 * The layout of the user memory must follow a row major order.
 * \param [in] usage This declares the effect of the copy with regard to the tensor object
 * using the <tt>vx_accessor_e</tt> enumeration. Only VX_READ_ONLY and VX_WRITE_ONLY are supported:
 * \arg VX_READ_ONLY means that data is copied from the tensor object into the application memory
 * \arg VX_WRITE_ONLY means that data is copied into the tensor object from the application memory
 * \param [in] user_memory_type A <tt>vx_memory_type_e</tt> enumeration that specifies
 * the memory type of the memory referenced by the user_addr.
 * \return A <tt>vx_status_e</tt> enumeration.
 * \retval VX_ERROR_OPTIMIZED_AWAY This is a reference to a virtual tensor that cannot be
 * accessed by the application.
 * \retval VX_ERROR_INVALID_REFERENCE The tensor reference is not actually an tensor reference.
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 * \ingroup group_tensor
 */
VX_API_ENTRY vx_status VX_API_CALL vxCopyTensorPatch(vx_tensor tensor, vx_size number_of_dims, const vx_size * view_start, const vx_size * view_end,
        const vx_size * user_stride, void * user_ptr, vx_enum usage, vx_enum user_memory_type);

/*! \brief Retrieves various attributes of a tensor data.
 * \param [in] tensor The reference to the tensor data to query.
 * \param [in] attribute The attribute to query. Use a <tt>\ref vx_tensor_attribute_e</tt>.
 * \param [out] ptr The location at which to store the resulting value.
 * \param [in] size The size of the container to which \a ptr points.
 * \return A <tt>vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors.
 * \retval VX_ERROR_INVALID_REFERENCE If data is not a <tt>\ref vx_tensor</tt>.
 * \retval VX_ERROR_INVALID_PARAMETERS If any of the other parameters are incorrect.
 * \ingroup group_tensor
 */
VX_API_ENTRY vx_status VX_API_CALL vxQueryTensor(vx_tensor tensor, vx_enum attribute, void *ptr, vx_size size);

/*! \brief Releases a reference to a tensor data object.
 * The object may not be garbage collected until its total reference count is zero.
 * \param [in] tensor The pointer to the tensor data to release.
 * \post After returning from this function the reference is zeroed.
 * \return A <tt>vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; all other values indicate failure
 * \retval * An error occurred. See <tt>vx_status_e</tt>.
 * \ingroup group_tensor
 */
VX_API_ENTRY vx_status VX_API_CALL vxReleaseTensor(vx_tensor *tensor);




/*==============================================================================
    NN Nodes
=============================================================================*/
/*! \brief [Graph] Creates a Convolutional Network Convolution Layer Node.
 * \details This function implement Convolutional Network Convolution layer.
 * In case the input and output <tt>\ref vx_tensor</tt> are signed 16. A fixed point calculation is performed with round and saturate according to the number of accumulator bits. \n
 * round: rounding according the <tt>vx_round_policy_e</tt> enumeration. \n
 * saturate: A saturation according the <tt>vx_convert_policy_e</tt> enumeration.
 * The following equation is implemented: \n
 * \f$ outputs[j,k,i] = (\sum_{l} \sum_{m,n} saturate(round(inputs[j-m,k-n,l] \times weights[m,n,l,i])))+biasses[j,k,i] \f$\n
 * Where \f$m,n\f$ are indexes on the convolution matrices. \f$ l\f$ is an index on all the convolutions per input.\f$ i\f$ is an index per output.
 * \f$ j,k \f$ are the inputs/outputs spatial indexes.
 * Convolution is done on the first 2 dimensions of the <tt>\ref vx_tensor</tt>. Therefore, we use here the term x for the first dimension and y for the second.\n
 * before the Convolution is done, a padding of the first 2D with zeros is performed.
 * Then down scale is done by picking the results according to a skip jump. The skip in the x and y dimension is determined by the output size dimensions.
 * The relation between input to output is as follows: \n
 * \f$ width_{output} = round(\frac{(width_{input} + 2 * padding_x - kernel_x)}{skip_x} + 1) \f$\n
 * and \n
 * \f$ height_{output} = round(\frac{(height + 2 * padding_y - kernel_y)}{skip_y} + 1) \f$\n // skip_y = (height + 2*padding - kernel_y)/(output_height - 1)
 * where \f$width\f$ is the size of the first input dimension. \f$height\f$ is the size of the second input dimension.
 * \f$width_{output}\f$ is the size of the first output dimension. \f$height_{output}\f$ is the size of the second output dimension.
 * \f$kernel_x\f$ and \f$kernel_y\f$ are the convolution sizes in x and y.
 * skip is calculated by the relation between input and output.
 * rounding is done according to <tt>\ref vx_nn_rounding_type_e</tt>.
 * \param [in] graph The handle to the graph.
 * \param [in] inputs The input tensor data. 3 lower dimensions represent a single input, all following dimensions represent number of batches, possibly nested.
 * The dimensions order is [width, height, #IFM, #batches]\n. Implementations must support input tensor data type <tt>VX_TYPE_INT16</tt>. with fixed_point_position 8. 
 * \param [in] weights Weights are 4d tensor with dimensions [kernel_x, kernel_y, #IFM, #OFM].\n Implementations must support input tensor data type <tt>VX_TYPE_INT16</tt>. with fixed_point_position 8. 
 * \param [in] biases Optional, ignored if NULL. The biases, which may be shared (one per ofm) or unshared (one per ofm * output location). The possible layouts are
 * either [#OFM] or [width, height, #OFM]. Implementations must support input tensor data type <tt>VX_TYPE_INT16</tt>. with fixed_point_position 8. 
 * \param [in] padding_x Number of elements added at each side in the x dimension of the input.
 * \param [in] padding_y Number of elements added at each side in the y dimension of the input. In fully connected layers this input is ignored.
 * \param [in] overflow_policy A <tt> VX_TYPE_ENUM</tt> of the <tt> vx_convert_policy_e</tt> enumeration.
 * \param [in] rounding_policy A <tt> VX_TYPE_ENUM</tt> of the <tt> vx_round_policy_e</tt> enumeration.
 * \param [in] down_scale_size_rounding Rounding method for calculating output dimensions. See <tt>\ref vx_nn_rounding_type_e</tt>
 * \param [out] outputs The output tensor data. Output will have the same number and structure of dimensions as input.
 * \return <tt> vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_cnn
 */
VX_API_ENTRY vx_node VX_API_CALL vxConvolutionLayer(vx_graph graph, vx_tensor inputs, vx_tensor weights, vx_tensor biases,
        vx_size padding_x,
        vx_size padding_y,
        vx_enum overflow_policy, //WRAP
        vx_enum rounding_policy, //NEAREST_TO_ZERO
        vx_enum down_scale_size_rounding,	// FLOOR
        vx_tensor outputs);

/*! \brief [Graph] Creates a Fully connected Convolutional Network Layer Node.
 * \details This function implement Fully connected Convolutional Network layers.
 * In case the input and output <tt>\ref vx_tensor</tt> are signed 16. A fixed point calculation is performed with round and saturate according to the number of accumulator bits. \n
 * round: rounding according the <tt>vx_round_policy_e</tt> enumeration. \n
 * saturate: A saturation according the <tt>vx_convert_policy_e</tt> enumeration.
 * The equation for Fully connected layer:\n
 * \f$ outputs[i] = ( \sum_{j} saturate(round(inputs[j] \times weights[j,i])))+biasses[i] \f$\n
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
 * 1. [#IFM, #batches].
 * 2. [width, height, #IFM, #batches]
 * In both cases number of batches are optional and may be multidimensional.
 * The second option is a special case to deal with convolution layer followed by fully connected.
 * The dimensions order is [#IFM, #batches].Note that batch may be multidimensional. Implementations must support input tensor data type <tt>VX_TYPE_INT16</tt>. with fixed_point_position 8. 
 * \param [in] weights Number of dimensions is 2. Dimensions are [#IFM, #OFM].\n Implementations must support input tensor data type <tt>VX_TYPE_INT16</tt>. with fixed_point_position 8. 
 * \param [in] biases Optional, ignored if NULL The biases have one dimension [#OFM]. Implementations must support input tensor data type <tt>VX_TYPE_INT16</tt>. with fixed_point_position 8. 
 * \param [in] overflow_policy A <tt> VX_TYPE_ENUM</tt> of the <tt> vx_convert_policy_e</tt> enumeration.
 * \param [in] rounding_policy A <tt> VX_TYPE_ENUM</tt> of the <tt> vx_round_policy_e</tt> enumeration.
 * \param [out] outputs The output tensor data. Output dimension layout is [#OFM,#batches], where #batches may be multidimensional.
 * \return <tt> vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_cnn
 */
VX_API_ENTRY vx_node VX_API_CALL vxFullyConnectedLayer(vx_graph graph, vx_tensor inputs, vx_tensor weights, vx_tensor biases,
        vx_enum overflow_policy, //wrap
        vx_enum rounding_policy,// nearest_to_zero
        vx_tensor outputs);


/*! \brief [Graph] Creates a Convolutional Network Pooling Layer Node.
 * \details Pooling is done on the first 2 dimensions or the <tt>\ref vx_tensor</tt>. Therefore, we use here the term x for the first dimension and y for the second.\n
 * Pooling operation is a function operation over a rectangle size and then a nearest neighbour down scale.
 * Here we use pooling_size_x and pooling_size_y to specify the rectangle size on which the operation
 * is performed. \n
 * before the operation is done (average or maximum value). the data is padded in the first 2D with zeros.
 * The down scale is done by picking the results according to a skip jump. The skip in the x and y dimension is determined by the output size dimensions.
 * \param [in] graph The handle to the graph.
 * \param [in] inputs The input tensor data. 3 lower dimensions represent a single input, 4th dimension for batch of inputs is optional.Dimensions layout is [width, height, IFM, #batches]. 
 * Implementations must support input tensor data type <tt>VX_TYPE_INT16</tt>. with fixed_point_position 8. 
 * \param [in] pooling_type Either max pooling or average pooling (see <tt>\ref vx_nn_pooling_type_e</tt>).
 * \param [in] pooling_size_x Size of the pooling region in the x dimension
 * \param [in] pooling_size_y Size of the pooling region in the y dimension.
 * \param [in] pooling_padding_x Padding size in the x dimension.
 * \param [in] pooling_padding_y Padding size in the y dimension.
 * \param [in] rounding, Rounding method for calculating output dimensions. See <tt>\ref vx_nn_rounding_type_e</tt>
 * \param [out] outputs The output tensor data. Output will have the same number of dimensions as input.
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
        vx_enum rounding, // floor
        vx_tensor outputs);

/*! \brief [Graph] Creates a Convolutional Network Softmax Layer Node.
 * \details  the softmax function, is a generalization of the logistic function that "squashes" a K-dimensional vector \f$ z \f$ of arbitrary real values to a K-dimensional vector
 * \f$ \sigma(z) \f$ of real values in the range (0, 1) that add up to 1. The function is given by:
 * \f$ \sigma(z) = \frac{\exp^z}{\sum_i \exp^{z_i}} \f$
 * \param [in] graph The handle to the graph.
 * \param [in] inputs The input tensor,  with number of dimensions according the the following scheme.
 * In case IFM dimension is 1. Softmax is be calculated on that dimension.
 * In case IFM dimension is 2. Softmax is be calculated on the first dimension. The second dimension is batching.
 * In case IFM dimension is 3. Dimensions are [Width, Height, Classes]. And Softmax is calculated on the third dimension.
 * In case IFM dimension is 4. Dimensions are [Width, Height, Classes, batching]. Softmax is calculated on the third dimension.
 * In all cases implementations must support input tensor data type <tt>VX_TYPE_INT16</tt>. with fixed_point_position 8. 
 * \param [out] outputs The output tensor. Output will have the same number of dimensions as input.
 * \ingroup group_cnn
 * \return <tt> vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */

VX_API_ENTRY vx_node VX_API_CALL vxSoftmaxLayer(vx_graph graph, vx_tensor inputs, vx_tensor outputs);

/*! \brief [Graph] Creates a Convolutional Network Normalization Layer Node.
 * \details Normalizing over local input regions. Each input value is divided by \f$ (1+\frac{\alpha}{n}\sum_i x^2_i)^\beta \f$ , where n is the number of elements to normalize across.
 * and the sum is taken over the region centred at that value (zero padding is added where necessary).
 * \param [in] graph The handle to the graph.
 * \param [in] inputs The input tensor data. 3 lower dimensions represent a single input, 4th dimension for batch of inputs is optional.Dimensions layout is [width, height, IFM, #batches].
 * Implementations must support input tensor data type <tt>VX_TYPE_INT16</tt>. with fixed_point_position 8. 
 * \param [in] type Either same map or across maps (see vx_nn_norm_type_e).
 * \param [in] normalization_size Number of elements to normalize across.
 * \param [in] alpha Alpha parameter in the normalization equation.
 * \param [in] beta  Beta parameter in the normalization equation.
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
 * \param [in] graph The handle to the graph.
 * \param [in] inputs The input tensor data. The dimensions order is [width, height, #IFM, #batches].#batches is optional. Implementations must support input tensor data type <tt>VX_TYPE_INT16</tt>. with fixed_point_position 8. 
 * \param [in] function Non-linear function (see <tt>\ref vx_nn_activation_function_e</tt>). Implementations must support <tt>VX_NN_ACTIVATION_LOGISTIC</tt>, <tt>VX_NN_ACTIVATION_HYPERBOLIC_TAN</tt> and <tt>VX_NN_ACTIVATION_RELU</tt>
 * \param [in] a Function parameters a.
 * \param [in] b Function parameters b.
 * \param [out] outputs The output tensor data. Output will have the same number of dimensions as input.
 * \ingroup group_cnn
 * \return <tt> vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_node VX_API_CALL vxActivationLayer(vx_graph graph, vx_tensor inputs, vx_enum function, vx_float32 a,vx_float32 b, vx_tensor outputs); // a > 0, b > 0




/*! \brief [Graph] Performs element wise multiplications on element values in the input tensor data's with a scale.
 * \param [in] graph The handle to the graph.
 * \param [in] input1 input tensor data.  Implementations must support input tensor data type <tt>VX_TYPE_INT16</tt>. with fixed_point_position 8. 
 * \param [in] input2 input tensor data, inputs must be of equal in dimensions.
 * else, If in one of the vx_mddata dimension is 1.
 * That dimension is considered as a const on all the dimension terms.
 * And will perform as if the values are duplicated on all terms in that dimensions.
 * After the expansion. The dimensions are equal.  Implementations must support input tensor data type <tt>VX_TYPE_INT16</tt>. with fixed_point_position 8. 
 * \param [in] scale The scale value.
 * \param [in] overflow_policy A <tt>vx_convert_policy_e</tt> enumeration.
 * \param [in] rounding_policy A <tt>vx_round_policy_e</tt> enumeration.
 * \param [out] output The output tensor data with the same dimensions as the input tensor data's.
 * \ingroup group_tensor
 * \return <tt> vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_node VX_API_CALL vxTensorMultiplyNode(vx_graph graph, vx_tensor input1, vx_tensor input2, vx_scalar scale, vx_enum overflow_policy,
        vx_enum rounding_policy, vx_tensor output);

/*! \brief [Graph] Performs arithmetic addition on element values in the input tensor data's.
 * \param [in] graph The handle to the graph.
 * \param [in] input1 input tensor data,. Implementations must support input tensor data type <tt>VX_TYPE_INT16</tt>. with fixed_point_position 8. 
 * \param [in] inout2 input tensor data, inputs must be of equal in dimensions.
 * else, If in one of the vx_mddata dimension is 1.
 * That dimension is considered as a const on all the dimension terms.
 * And will perform as if the values are duplicated on all terms in that dimensions.
 * After the expansion. The dimensions are equal.  Implementations must support input tensor data type <tt>VX_TYPE_INT16</tt>. with fixed_point_position 8. 
 * \param [in] policy A vx_convert_policy_e enumeration.
 * \param [out] output The output tensor data with the same dimensions as the input tensor data's.
 * \ingroup group_tensor
 * \return <tt> vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_node VX_API_CALL vxTensorAddNode(vx_graph graph, vx_tensor input1, vx_tensor input2, vx_enum policy, vx_tensor output);

/*! \brief [Graph] Performs arithmetic subtraction on element values in the input tensor data's.
 * \param [in] graph The handle to the graph.
 * \param [in] input1 input tensor data. Implementations must support input tensor data type <tt>VX_TYPE_INT16</tt>. with fixed_point_position 8. 
 * \param [in] input2 input tensor data, inputs must be of equal in dimensions.
 * else, If in one of the vx_mddata dimension is 1.
 * That dimension is considered as a const on all the dimension terms.
 * And will perform as if the values are duplicated on all terms in that dimensions. Implementations must support input tensor data type <tt>VX_TYPE_INT16</tt>. with fixed_point_position 8. 
 * After the expansion. The dimensions are equal.
 * \param [in] policy A vx_convert_policy_e enumeration.
 * \param [out] output The output tensor data with the same dimensions as the input tensor data's.
 * \ingroup group_tensor
 * \return <tt> vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_node VX_API_CALL vxTensorSubtractNode(vx_graph graph, vx_tensor input1, vx_tensor input2, vx_enum policy, vx_tensor output);

/*! \brief [Graph] Performs LUT on element values in the input tensor data's.
 * \param [in] graph The handle to the graph.
 * \param [in] input1 input tensor data. Implementations must support input tensor data type <tt>VX_TYPE_INT16</tt>. with fixed_point_position 8. 
 * \param [in] lut of type <tt>vx_lut</tt>. The Lut is as if data was cast to unsigned integer In the input. And cast from unsigned integer integer to the required data type at the output.
 * \param [out] output The output tensor data with the same dimensions as the input tensor data's.
 * \ingroup group_tensor
 * \return <tt> vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_node VX_API_CALL vxTensorTableLookupNode(vx_graph graph, vx_tensor input1, vx_lut lut, vx_tensor output);


/*! \brief [Graph] Performs transpose on the input tensor.
 * The node transpose the tensor according to a specified 2 indexes in the tensor (0-based indexing)
 * \param [in] graph The handle to the graph.
 * \param [in] input input tensor data, Implementations must support input tensor data type <tt>VX_TYPE_INT16</tt>. with fixed_point_position 8. 
 * \param [out] output output tensor data,
 * \param [in] dimension1 that is transposed with dim 2.
 * \param [in] dimension2 that is transposed with dim 1.
 * \ingroup group_tensor
 * \return <tt> vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_node VX_API_CALL vxTensorTransposeNode(vx_graph graph, vx_tensor input, vx_tensor output, vx_size dimension1, vx_size dimension2);


#ifdef  __cplusplus
}
#endif


#endif
