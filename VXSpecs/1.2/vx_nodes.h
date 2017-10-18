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

#ifndef _OPENVX_NODES_H_
#define _OPENVX_NODES_H_

/*!
 * \file vx_nodes.h
 * \brief The "Simple" API interface for OpenVX. These APIs are just
 * wrappers around the more verbose functions defined in <tt>\ref vx_api.h</tt>.
 */

#ifdef __cplusplus
extern "C" {
#endif

/*! \brief [Graph] Creates a color conversion node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input image from which to convert.
 * \param [out] output The output image to which to convert.
 * \see <tt>VX_KERNEL_COLOR_CONVERT</tt>
 * \ingroup group_vision_function_colorconvert
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxColorConvertNode(vx_graph graph, vx_image input, vx_image output);

/*! \brief [Graph] Creates a channel extract node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input image. Must be one of the defined \ref vx_df_image_e multi-channel formats.
 * \param [in] channel The <tt>\ref vx_channel_e</tt> channel to extract.
 * \param [out] output The output image. Must be <tt>\ref VX_DF_IMAGE_U8</tt>.
 * <tt>\see VX_KERNEL_CHANNEL_EXTRACT</tt>
 * \ingroup group_vision_function_channelextract
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxChannelExtractNode(vx_graph graph,
                             vx_image input,
                             vx_channel_e channel,
                             vx_image output);

/*! \brief [Graph] Creates a channel combine node.
 * \param [in] graph The graph reference.
 * \param [in] plane0 The plane that forms channel 0. Must be <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [in] plane1 The plane that forms channel 1. Must be <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [in] plane2 [optional] The plane that forms channel 2. Must be <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [in] plane3 [optional] The plane that forms channel 3. Must be <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [out] output The output image. The format of the image must be defined, even if the image is virtual.
 * \see <tt>VX_KERNEL_CHANNEL_COMBINE</tt>
 * \ingroup group_vision_function_channelcombine
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxChannelCombineNode(vx_graph graph,
                             vx_image plane0,
                             vx_image plane1,
                             vx_image plane2,
                             vx_image plane3,
                             vx_image output);

/*! \brief [Graph] Creates a Phase node.
 * \param [in] graph The reference to the graph.
 * \param [in] grad_x The input x image. This must be in <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \param [in] grad_y The input y image. This must be in <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \param [out] orientation The phase image. This is in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \see <tt>VX_KERNEL_PHASE</tt>
 * \ingroup group_vision_function_phase
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxPhaseNode(vx_graph graph, vx_image grad_x, vx_image grad_y, vx_image orientation);

/*! \brief [Graph] Creates a Sobel3x3 node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \param [out] output_x [optional] The output gradient in the x direction in <tt>\ref VX_DF_IMAGE_S16</tt>.
 * \param [out] output_y [optional] The output gradient in the y direction in <tt>\ref VX_DF_IMAGE_S16</tt>.
 * \see <tt>VX_KERNEL_SOBEL_3x3</tt>
 * \ingroup group_vision_function_sobel3x3
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxSobel3x3Node(vx_graph graph, vx_image input, vx_image output_x, vx_image output_y);


/*! \brief [Graph] Create a Magnitude node.
 * \param [in] graph The reference to the graph.
 * \param [in] grad_x The input x image. This must be in <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \param [in] grad_y The input y image. This must be in <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \param [out] mag The magnitude image. This is in <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \see <tt>VX_KERNEL_MAGNITUDE</tt>
 * \ingroup group_vision_function_magnitude
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxMagnitudeNode(vx_graph graph, vx_image grad_x, vx_image grad_y, vx_image mag);

/*! \brief [Graph] Creates a Scale Image Node.
 * \param [in] graph The reference to the graph.
 * \param [in] src The source image of type <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [out] dst The destination image of type <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [in] type The interpolation type to use. \see vx_interpolation_type_e.
 * \ingroup group_vision_function_scale_image
 * \note The destination image must have a defined size and format. The border modes
 *  <tt>\ref VX_NODE_BORDER</tt> value <tt>\ref VX_BORDER_UNDEFINED</tt>,
 *  <tt>\ref VX_BORDER_REPLICATE</tt> and <tt>\ref VX_BORDER_CONSTANT</tt> are supported.
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxScaleImageNode(vx_graph graph, vx_image src, vx_image dst, vx_interpolation_type_e type);

/*! \brief [Graph] Creates a Table Lookup node. If a value from the input image is not present in the lookup table, the result is undefined.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt>.
 * \param [in] lut The LUT which is of type <tt>\ref VX_TYPE_UINT8</tt> or <tt>\ref VX_TYPE_INT16</tt>.
 * \param [out] output The output image of the same type as the input image.
 * \ingroup group_vision_function_lut
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_node VX_API_CALL vxTableLookupNode(vx_graph graph, vx_image input, vx_lut lut, vx_image output);

/*! \brief [Graph] Creates a Histogram node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [out] distribution The output distribution.
 * \ingroup group_vision_function_histogram
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxHistogramNode(vx_graph graph, vx_image input, vx_distribution distribution);

/*! \brief [Graph] Creates a Histogram Equalization node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The grayscale input image in <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [out] output The grayscale output image of type <tt>\ref VX_DF_IMAGE_U8</tt> with equalized brightness and contrast.
 * \ingroup group_vision_function_equalize_hist
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxEqualizeHistNode(vx_graph graph, vx_image input, vx_image output);

/*! \brief [Graph] Creates an AbsDiff node.
 * \param [in] graph The reference to the graph.
 * \param [in] in1 An input image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \param [in] in2 An input image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \param [out] out The output image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \ingroup group_vision_function_absdiff
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxAbsDiffNode(vx_graph graph, vx_image in1, vx_image in2, vx_image out);

/*! \brief [Graph] Creates a mean value and optionally, a standard deviation node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input image. <tt>\ref VX_DF_IMAGE_U8</tt> is supported.
 * \param [out] mean The <tt>\ref VX_TYPE_FLOAT32</tt> average pixel value.
 * \param [out] stddev [optional] The <tt>\ref VX_TYPE_FLOAT32</tt> standard deviation of the pixel values.
 * \ingroup group_vision_function_meanstddev
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxMeanStdDevNode(vx_graph graph, vx_image input, vx_scalar mean, vx_scalar stddev);

/*! \brief [Graph] Creates a Threshold node and returns a reference to it.
 * \param [in] graph The reference to the graph in which the node is created.
 * \param [in] input The input image. Only images with format <tt>\ref VX_DF_IMAGE_U8</tt>
 * and <tt>\ref VX_DF_IMAGE_S16</tt> are supported.
 * \param [in] thresh The thresholding object that defines the parameters of
 * the operation: thresholding value(s) and true/false output values.
 * \param [out] output The output image, that will contain as pixel value
 * true and false values defined by \p thresh. Only images with format
 * <tt>\ref VX_DF_IMAGE_U8</tt> are supported.
 * \ingroup group_vision_function_threshold
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation
 * should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxThresholdNode(vx_graph graph, vx_image input, vx_threshold thresh, vx_image output);

/*! \brief [Graph] Creates a Non-Maxima Suppression node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \param [in] mask [optional] Constrict suppression to a ROI. The mask image is of type <tt>\ref VX_DF_IMAGE_U8</tt> and must be the same dimensions as the input image.
 * \param [in] win_size The size of window over which to perform the localized non-maxima suppression. Must be odd, and less than or equal to the smallest dimension of the input image.
 * \param [out] output The output image, of the same type and size as the input, that has been non-maxima suppressed. 
 * \ingroup group_vision_function_nms
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxNonMaxSuppressionNode(vx_graph graph, vx_image input, vx_image mask, vx_int32 win_size, vx_image output);

/*! \brief [Graph] Creates an Integral Image Node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \param [out] output The output image in <tt>\ref VX_DF_IMAGE_U32</tt> format.
 * \ingroup group_vision_function_integral_image
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxIntegralImageNode(vx_graph graph, vx_image input, vx_image output);

/*! \brief [Graph] Creates an Erosion Image Node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \param [out] output The output image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \ingroup group_vision_function_erode_image
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxErode3x3Node(vx_graph graph, vx_image input, vx_image output);

/*! \brief [Graph] Creates a Dilation Image Node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \param [out] output The output image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \ingroup group_vision_function_dilate_image
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxDilate3x3Node(vx_graph graph, vx_image input, vx_image output);

/*! \brief [Graph] Creates a Median Image Node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \param [out] output The output image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \ingroup group_vision_function_median_image
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxMedian3x3Node(vx_graph graph, vx_image input, vx_image output);

/*! \brief [Graph] Creates a Box Filter Node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \param [out] output The output image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \ingroup group_vision_function_box_image
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxBox3x3Node(vx_graph graph, vx_image input, vx_image output);

/*! \brief [Graph] Creates a Gaussian Filter Node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \param [out] output The output image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \ingroup group_vision_function_gaussian_image
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxGaussian3x3Node(vx_graph graph, vx_image input, vx_image output);

/*! \brief [Graph] Creates a Non-linear Filter Node.
 * \param [in] graph The reference to the graph.
 * \param [in] function The non-linear filter function. See <tt>\ref vx_non_linear_filter_e</tt>.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \param [in] mask The mask to be applied to the Non-linear function. <tt>\ref VX_MATRIX_ORIGIN</tt> attribute is used
 *  to place the mask appropriately when computing the resulting image. See <tt>\ref vxCreateMatrixFromPattern</tt>.
 * \param [out] output The output image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 * \ingroup group_vision_function_nonlinear_filter
 */
VX_API_ENTRY vx_node VX_API_CALL vxNonLinearFilterNode(vx_graph graph, vx_non_linear_filter_e function, vx_image input, vx_matrix mask, vx_image output);

/*! \brief [Graph] Creates a custom convolution node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \param [in] conv The <tt>\ref vx_int16</tt> convolution matrix.
 * \param [out] output The output image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \ingroup group_vision_function_custom_convolution
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxConvolveNode(vx_graph graph, vx_image input, vx_convolution conv, vx_image output);

/*! \brief [Graph] Creates a node for a Gaussian Image Pyramid.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \param [out] gaussian The Gaussian pyramid with <tt>\ref VX_DF_IMAGE_U8</tt> to construct.
 * \ingroup group_vision_function_gaussian_pyramid
 * \see group_pyramid
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxGaussianPyramidNode(vx_graph graph, vx_image input, vx_pyramid gaussian);

/*! \brief [Graph] Creates a node for a Laplacian Image Pyramid.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \param [out] laplacian The Laplacian pyramid with <tt>\ref VX_DF_IMAGE_S16</tt> to construct.
 * \param [out] output The lowest resolution image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format necessary to reconstruct the input image from the pyramid. The output image format should be same as input image format.
 * \ingroup group_vision_function_laplacian_pyramid
 * \see group_pyramid
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxLaplacianPyramidNode(vx_graph graph, vx_image input,
                                   vx_pyramid laplacian, vx_image output);

/*! \brief [Graph] Reconstructs an image from a Laplacian Image pyramid.
 * \param [in] graph The reference to the graph.
 * \param [in] laplacian The Laplacian pyramid with <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \param [in] input The lowest resolution image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format for the Laplacian pyramid.
 * \param [out] output The output image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format with the highest possible resolution reconstructed from the Laplacian pyramid. The output image format should be same as input image format.
 * \ingroup group_vision_function_laplacian_reconstruct
 * \see group_pyramid
 * \return <tt>\ref vx_node</tt>.
 * \retval 0 Node could not be created.
 * \retval * Node handle.
 */
VX_API_ENTRY vx_node VX_API_CALL vxLaplacianReconstructNode(vx_graph graph, vx_pyramid laplacian, vx_image input,
                                       vx_image output);

/*! \brief [Graph] Creates an accumulate node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \param [in,out] accum The accumulation image in <tt>\ref VX_DF_IMAGE_S16</tt>.
 * \ingroup group_vision_function_accumulate
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxAccumulateImageNode(vx_graph graph, vx_image input, vx_image accum);

/*! \brief [Graph] Creates a weighted accumulate node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \param [in] alpha The input <tt>\ref VX_TYPE_FLOAT32</tt> scalar value with a value in the range of \f$ 0.0 \le \alpha \le 1.0 \f$.
 * \param [in,out] accum The <tt>\ref VX_DF_IMAGE_U8</tt> accumulation image.
 * \ingroup group_vision_function_accumulate_weighted
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxAccumulateWeightedImageNode(vx_graph graph, vx_image input, vx_scalar alpha, vx_image accum);

/*! \brief [Graph] Creates an accumulate square node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \param [in] shift The input <tt>\ref VX_TYPE_UINT32</tt> with a value in the range of \f$ 0 \le shift \le 15 \f$.
 * \param [in,out] accum The accumulation image in <tt>\ref VX_DF_IMAGE_S16</tt>.
 * \ingroup group_vision_function_accumulate_square
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxAccumulateSquareImageNode(vx_graph graph, vx_image input, vx_scalar shift, vx_image accum);

/*! \brief [Graph] Creates a min,max,loc node.
 * \param [in] graph The reference to create the graph.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \param [out] minVal The minimum value in the image, which corresponds to the type of the input.
 * \param [out] maxVal The maximum value in the image, which corresponds to the type of the input.
 * \param [out] minLoc [optional] The minimum <tt>\ref VX_TYPE_COORDINATES2D</tt> locations. If the input image has several minimums, the kernel will return up to the capacity of the array.
 * \param [out] maxLoc [optional] The maximum <tt>\ref VX_TYPE_COORDINATES2D</tt> locations. If the input image has several maximums, the kernel will return up to the capacity of the array.
 * \param [out] minCount [optional] The total number of detected minimums in image. Use a <tt>\ref VX_TYPE_SIZE</tt> scalar.
 * \param [out] maxCount [optional] The total number of detected maximums in image. Use a <tt>\ref VX_TYPE_SIZE</tt> scalar.
 * \ingroup group_vision_function_minmaxloc
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxMinMaxLocNode(vx_graph graph,
                        vx_image input,
                        vx_scalar minVal, vx_scalar maxVal,
                        vx_array minLoc, vx_array maxLoc,
                        vx_scalar minCount, vx_scalar maxCount);

/*! \brief [Graph] Creates a pixel-wise minimum kernel.
 * \param [in] graph The reference to the graph where to create the node.
 * \param [in] in1 The first input image. Must be of type <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt>.
 * \param [in] in2 The second input image. Must be of type <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt>.
 * \param [out] out The output image which will hold the result of min.
 * \ingroup group_vision_function_min.
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxMinNode(vx_graph graph, vx_image in1, vx_image in2, vx_image out);

/*! \brief [Graph] Creates a pixel-wise maximum kernel.
 * \param [in] graph The reference to the graph where to create the node.
 * \param [in] in1 The first input image. Must be of type <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt>.
 * \param [in] in2 The second input image. Must be of type <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt>.
 * \param [out] out The output image which will hold the result of max.
 * \ingroup group_vision_function_max
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxMaxNode(vx_graph graph, vx_image in1, vx_image in2, vx_image out);

/*! \brief [Graph] Creates a bitwise AND node.
 * \param [in] graph The reference to the graph.
 * \param [in] in1 A <tt>\ref VX_DF_IMAGE_U8</tt> input image.
 * \param [in] in2 A <tt>\ref VX_DF_IMAGE_U8</tt> input image.
 * \param [out] out The <tt>\ref VX_DF_IMAGE_U8</tt> output image.
 * \ingroup group_vision_function_and
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxAndNode(vx_graph graph, vx_image in1, vx_image in2, vx_image out);

/*! \brief [Graph] Creates a bitwise INCLUSIVE OR node.
 * \param [in] graph The reference to the graph.
 * \param [in] in1 A <tt>\ref VX_DF_IMAGE_U8</tt> input image.
 * \param [in] in2 A <tt>\ref VX_DF_IMAGE_U8</tt> input image.
 * \param [out] out The <tt>\ref VX_DF_IMAGE_U8</tt> output image.
 * \ingroup group_vision_function_or
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxOrNode(vx_graph graph, vx_image in1, vx_image in2, vx_image out);

/*! \brief [Graph] Creates a bitwise EXCLUSIVE OR node.
 * \param [in] graph The reference to the graph.
 * \param [in] in1 A <tt>\ref VX_DF_IMAGE_U8</tt> input image.
 * \param [in] in2 A <tt>\ref VX_DF_IMAGE_U8</tt> input image.
 * \param [out] out The <tt>\ref VX_DF_IMAGE_U8</tt> output image.
 * \ingroup group_vision_function_xor
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxXorNode(vx_graph graph, vx_image in1, vx_image in2, vx_image out);

/*! \brief [Graph] Creates a bitwise NOT node.
 * \param [in] graph The reference to the graph.
 * \param [in] input A <tt>\ref VX_DF_IMAGE_U8</tt> input image.
 * \param [out] output The <tt>\ref VX_DF_IMAGE_U8</tt> output image.
 * \ingroup group_vision_function_not
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxNotNode(vx_graph graph, vx_image input, vx_image output);

/*! \brief [Graph] Creates a scalar operation node.
 * \param [in] graph The reference to the graph.
 * \param [in] scalar_operation A <tt>\ref VX_TYPE_ENUM</tt> of the <tt>\ref vx_scalar_operation_e</tt> enumeration.
 * \param [in] a First scalar operand.
 * \param [in] b Second scalar operand.
 * \param [out] output Result of the scalar operation.
 * \ingroup group_control_flow
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxScalarOperationNode(vx_graph graph, vx_scalar_operation_e scalar_operation, vx_scalar a, vx_scalar b, vx_scalar output);

/*! \brief [Graph] Selects one of two data objects depending on the the value of a condition (boolean scalar), and copies its data into another data object.
 * \details This node supports predicated execution flow within a graph. All the data objects passed to this kernel shall
 * have the same object type and meta data. It is important to note that an implementation may optimize away the select and copy when virtual data
 * objects are used.\n
 * If there is a kernel node that contribute only into virtual data objects during the graph execution due to certain data path being eliminated by not
 * taken argument of select node, then the OpenVX implementation guarantees that there will not be any side effects to graph execution and node state.\n
 * If the path to a select node contains non-virtual objects, user nodes, or  nodes with completion callbacks, then that path may not be "optimized out"
 * because the callback must be executed and the non-virtual objects must be modified.
 * \param [in] graph The reference to the graph.
 * \param [in] condition <tt>\ref VX_TYPE_BOOL</tt> predicate variable.
 * \param [in] true_value Data object for true.
 * \param [in] false_value Data object for false.
 * \param [out] output Output data object.
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 * \ingroup group_control_flow
  */
VX_API_ENTRY vx_node VX_API_CALL vxSelectNode(vx_graph graph, vx_scalar condition, vx_reference true_value, vx_reference false_value, vx_reference output);

/*! \brief [Graph] Creates an pixelwise-multiplication node.
 * \param [in] graph The reference to the graph.
 * \param [in] in1 An input image, <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt>.
 * \param [in] in2 An input image, <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt>.
 * \param [in] scale A non-negative <tt>\ref VX_TYPE_FLOAT32</tt> multiplied to each product before overflow handling.
 * \param [in] overflow_policy A <tt>\ref VX_TYPE_ENUM</tt> of the <tt>\ref vx_convert_policy_e</tt> enumeration.
 * \param [in] rounding_policy A <tt>\ref VX_TYPE_ENUM</tt> of the <tt>\ref vx_round_policy_e</tt> enumeration.
 * \param [out] out The output image, a <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> image.
 * \ingroup group_vision_function_mult
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxMultiplyNode(vx_graph graph,
                       vx_image in1, vx_image in2,
                       vx_scalar scale,
                       vx_convert_policy_e overflow_policy,
                       vx_round_policy_e rounding_policy,
                       vx_image out);

/*! \brief [Graph] Creates an arithmetic addition node.
 * \param [in] graph The reference to the graph.
 * \param [in] in1 An input image, <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt>.
 * \param [in] in2 An input image, <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt>.
 * \param [in] policy A <tt>\ref VX_TYPE_ENUM</tt> of the \ref vx_convert_policy_e enumeration.
 * \param [out] out The output image, a <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> image.
 * \ingroup group_vision_function_add
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxAddNode(vx_graph graph,
                  vx_image in1, vx_image in2,
                  vx_convert_policy_e policy,
                  vx_image out);

/*! \brief [Graph] Creates an arithmetic subtraction node.
 * \param [in] graph The reference to the graph.
 * \param [in] in1 An input image, <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt>, the minuend.
 * \param [in] in2 An input image, <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt>, the subtrahend.
 * \param [in] policy A <tt>\ref VX_TYPE_ENUM</tt> of the \ref vx_convert_policy_e enumeration.
 * \param [out] out The output image, a <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> image.
 * \ingroup group_vision_function_sub
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxSubtractNode(vx_graph graph,
                       vx_image in1, vx_image in2,
                       vx_convert_policy_e policy,
                       vx_image out);

/*! \brief [Graph] Creates a bit-depth conversion node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input image.
 * \param [out] output The output image.
 * \param [in] policy A <tt>\ref VX_TYPE_ENUM</tt> of the <tt>\ref vx_convert_policy_e</tt> enumeration.
 * \param [in] shift A scalar containing a <tt>\ref VX_TYPE_INT32</tt> of the shift value.
 * \ingroup group_vision_function_convertdepth
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxConvertDepthNode(vx_graph graph, vx_image input, vx_image output, vx_convert_policy_e policy, vx_scalar shift);

/*! \brief [Graph] Creates a Canny Edge Detection Node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \param [in] hyst The double threshold for hysteresis. The threshold data_type shall be either <tt>\ref VX_TYPE_UINT8</tt>
 * or <tt>\ref VX_TYPE_INT16</tt>. The <tt>\ref VX_THRESHOLD_TRUE_VALUE</tt> and <tt>\ref VX_THRESHOLD_FALSE_VALUE</tt>
 * of <tt>\ref vx_threshold</tt> are ignored.
 * \param [in] gradient_size The size of the Sobel filter window, must support at least 3, 5, and 7.
 * \param [in] norm_type A flag indicating the norm used to compute the gradient, <tt>\ref VX_NORM_L1</tt> or VX_NORM_L2.
 * \param [out] output The output image in <tt>\ref VX_DF_IMAGE_U8</tt> format with values either 0 or 255.
 * \ingroup group_vision_function_canny
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxCannyEdgeDetectorNode(vx_graph graph, vx_image input, vx_threshold hyst,
                                vx_int32 gradient_size, vx_norm_type_e norm_type,
                                vx_image output);

/*! \brief [Graph] Creates an Affine Warp Node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \param [in] matrix The affine matrix. Must be 2x3 of type \ref VX_TYPE_FLOAT32.
 * \param [in] type The interpolation type from <tt>\ref vx_interpolation_type_e</tt>.
 * <tt>\ref VX_INTERPOLATION_AREA</tt> is not supported.
 * \param [out] output The output <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \ingroup group_vision_function_warp_affine
 * \note The border modes <tt>\ref VX_NODE_BORDER</tt> value <tt>\ref VX_BORDER_UNDEFINED</tt> and
 * <tt>\ref VX_BORDER_CONSTANT</tt> are supported.
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxWarpAffineNode(vx_graph graph, vx_image input, vx_matrix matrix, vx_interpolation_type_e type, vx_image output);

/*! \brief [Graph] Creates a Perspective Warp Node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \param [in] matrix The perspective matrix. Must be 3x3 of type <tt>\ref VX_TYPE_FLOAT32</tt>.
 * \param [in] type The interpolation type from <tt>\ref vx_interpolation_type_e</tt>.
 * <tt>\ref VX_INTERPOLATION_AREA</tt> is not supported.
 * \param [out] output The output <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \ingroup group_vision_function_warp_perspective
 * \note The border modes <tt>\ref VX_NODE_BORDER</tt> value <tt>\ref VX_BORDER_UNDEFINED</tt> and
 * <tt>\ref VX_BORDER_CONSTANT</tt> are supported.
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxWarpPerspectiveNode(vx_graph graph, vx_image input, vx_matrix matrix, vx_interpolation_type_e type, vx_image output);

/*! \brief [Graph] Creates a Harris Corners Node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \param [in] strength_thresh The <tt>\ref VX_TYPE_FLOAT32</tt> minimum threshold with which to eliminate Harris Corner scores (computed using the normalized Sobel kernel).
 * \param [in] min_distance The <tt>\ref VX_TYPE_FLOAT32</tt> radial Euclidean distance for non-maximum suppression.
 * \param [in] sensitivity The <tt>\ref VX_TYPE_FLOAT32</tt> scalar sensitivity threshold \f$ k \f$ from the Harris-Stephens equation.
 * \param [in] gradient_size The gradient window size to use on the input. The
 * implementation must support at least 3, 5, and 7.
 * \param [in] block_size The block window size used to compute the Harris Corner score.
 * The implementation must support at least 3, 5, and 7.
 * \param [out] corners The array of <tt>\ref VX_TYPE_KEYPOINT</tt> objects. The order of the keypoints in this array is implementation dependent.
 * \param [out] num_corners [optional] The total number of detected corners in image. Use a \ref VX_TYPE_SIZE scalar.
 * \ingroup group_vision_function_harris
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxHarrisCornersNode(vx_graph graph,
                            vx_image input,
                            vx_scalar strength_thresh,
                            vx_scalar min_distance,
                            vx_scalar sensitivity,
                            vx_int32 gradient_size,
                            vx_int32 block_size,
                            vx_array corners,
                            vx_scalar num_corners);

/*! \brief [Graph] Creates a FAST Corners Node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \param [in] strength_thresh Threshold on difference between intensity of the central pixel and pixels on Bresenham's circle
 * of radius 3 (<tt>\ref VX_TYPE_FLOAT32</tt> scalar), with a value in the range of 0.0 \f$\le\f$ strength_thresh < 256.0.
 *  Any fractional value will be truncated to an integer.
 * \param [in] nonmax_suppression If true, non-maximum suppression is applied to
 * detected corners before being placed in the <tt>\ref vx_array</tt> of <tt>\ref VX_TYPE_KEYPOINT</tt> objects.
 * \param [out] corners Output corner <tt>\ref vx_array</tt> of <tt>\ref VX_TYPE_KEYPOINT</tt>. The order of the
 *                      keypoints in this array is implementation dependent.
 * \param [out] num_corners [optional] The total number of detected corners in image. Use a \ref VX_TYPE_SIZE scalar.
 * \ingroup group_vision_function_fast
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxFastCornersNode(vx_graph graph, vx_image input, vx_scalar strength_thresh, vx_bool nonmax_suppression, vx_array corners, vx_scalar num_corners);

/*! \brief [Graph] Creates a Lucas Kanade Tracking Node.
 * \param [in] graph The reference to the graph.
 * \param [in] old_images Input of first (old) image pyramid in <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [in] new_images Input of destination (new) image pyramid <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [in] old_points An array of key points in a <tt>\ref vx_array</tt> of <tt>\ref VX_TYPE_KEYPOINT</tt>; those key points are defined at
 *  the \a old_images high resolution pyramid.
 * \param [in] new_points_estimates An array of estimation on what is the output key points in a <tt>\ref vx_array</tt> of
 *  <tt>\ref VX_TYPE_KEYPOINT</tt>; those keypoints are defined at the \a new_images high resolution pyramid.
 * \param [out] new_points An output array of key points in a <tt>\ref vx_array</tt> of <tt>\ref VX_TYPE_KEYPOINT</tt>; those key points are
 *  defined at the \a new_images high resolution pyramid.
 * \param [in] termination The termination can be <tt>\ref VX_TERM_CRITERIA_ITERATIONS</tt> or <tt>\ref VX_TERM_CRITERIA_EPSILON</tt> or
 * <tt>\ref VX_TERM_CRITERIA_BOTH</tt>.
 * \param [in] epsilon The <tt>\ref vx_float32</tt> error for terminating the algorithm.
 * \param [in] num_iterations The number of iterations. Use a <tt>\ref VX_TYPE_UINT32</tt> scalar.
 * \param [in] use_initial_estimate Use a <tt>\ref VX_TYPE_BOOL</tt> scalar.
 * \param [in] window_dimension The size of the window on which to perform the algorithm. See
 *  <tt>\ref VX_CONTEXT_OPTICAL_FLOW_MAX_WINDOW_DIMENSION</tt>
 * \ingroup group_vision_function_opticalflowpyrlk
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxOpticalFlowPyrLKNode(vx_graph graph,
                               vx_pyramid old_images,
                               vx_pyramid new_images,
                               vx_array old_points,
                               vx_array new_points_estimates,
                               vx_array new_points,
                               vx_termination_criteria_e termination,
                               vx_scalar epsilon,
                               vx_scalar num_iterations,
                               vx_scalar use_initial_estimate,
                               vx_size window_dimension);

/*! \brief [Graph] Creates a Remap Node.
 * \param [in] graph The reference to the graph that will contain the node.
 * \param [in] input The input <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \param [in] table The remap table object.
 * \param [in] policy An interpolation type from <tt>\ref vx_interpolation_type_e</tt>.
 * <tt>\ref VX_INTERPOLATION_AREA</tt> is not supported.
 * \param [out] output The output <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \note The border modes <tt>\ref VX_NODE_BORDER</tt> value <tt>\ref VX_BORDER_UNDEFINED</tt> and
 * <tt>\ref VX_BORDER_CONSTANT</tt> are supported.
 * \return A <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 * \ingroup group_vision_function_remap
 */
VX_API_ENTRY vx_node VX_API_CALL vxRemapNode(vx_graph graph,
                    vx_image input,
                    vx_remap table,
                    vx_interpolation_type_e policy,
                    vx_image output);

/*! \brief [Graph] Performs a Gaussian Blur on an image then half-scales it. The interpolation mode used is nearest-neighbor.
 * \details The output image size is determined by:
 * \f[
 * W_{output} = \frac{W_{input} + 1}{2} \\
 * ,
 * H_{output} = \frac{H_{input} + 1}{2}
 * \f]
 * \param [in] graph The reference to the graph.
 * \param [in] input The input <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \param [out] output The output <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \param [in] kernel_size The input size of the Gaussian filter. Supported values are 1, 3 and 5.
 * \ingroup group_vision_function_scale_image
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxHalfScaleGaussianNode(vx_graph graph, vx_image input, vx_image output, vx_int32 kernel_size);

/*! \brief [Graph]  The Node Compares an image template against overlapped image regions.
 * \details The detailed equation to the matching can be found in <tt>\ref vx_comp_metric_e</tt>.
 * The output of the template matching node is a comparison map as described in <tt>\ref vx_comp_metric_e</tt>.
 * The Node have a limitation on the template image size (width*height). It should not be larger then 65535.
 * If the valid region of the template image is smaller than the entire template image, the result in the destination image is implementation-dependent.
 * \param [in] graph The reference to the graph.
 * \param [in] src The input image of type <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [in] templateImage Searched template of type <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [in] matchingMethod attribute specifying the comparison method <tt>\ref vx_comp_metric_e</tt>. This function support only <tt>\ref VX_COMPARE_CCORR_NORM</tt> and <tt>\refVX_COMPARE_L2</tt>.
 * \param [out] output Map of comparison results. The output is an image of type VX_DF_IMAGE_S16
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 * \ingroup group_vision_function_match_template
 */
 VX_API_ENTRY vx_node VX_API_CALL vxMatchTemplateNode(vx_graph graph, vx_image src, vx_image templateImage, vx_comp_metric_e matchingMethod, vx_image output);

 /*! \brief [Graph] Creates a node that extracts LBP image from an input image
* \param [in] graph	The reference to the graph.
* \param [in] in		An input image in <tt>vx_image</tt>. Or \f$ SrcImg\f$ in the equations. the image is of type <tt>\ref VX_DF_IMAGE_U8</tt>
* \param [in] format	A variation of LBP like original LBP and mLBP. see <tt> \ref vx_lbp_format_e </tt>
* \param [in] kernel_size Kernel size. Only size of 3 and 5 are supported
* \param [out] out	An output image in <tt>vx_image</tt>.Or \f$ DstImg\f$ in the equations. the image is of type <tt>\ref VX_DF_IMAGE_U8</tt>
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
* \ingroup group_vision_function_lbp
*/
VX_API_ENTRY vx_node VX_API_CALL vxLBPNode(vx_graph graph,
	vx_image in, vx_lbp_format_e format, vx_int8 kernel_size, vx_image out);

/*! \brief [Graph] The node produces HOG features for the W1xW2 window in a sliding window fashion over the whole input image. Each position produces a HOG feature vector.
 * \details To account for changes in illumination and contrast, the gradient strengths must be locally normalized, which requires grouping the cells together into larger, spatially connected blocks. 
 * The HOG descriptor is then the concatenated vector of the components of the normalized cell histograms from all of the block regions. 
 * These blocks typically overlap, meaning that each cell contributes more than once to the final descriptor.
 * Blocks are square grids, represented by three parameters: the number of cells per block, the number of pixels per cell, and the number of channels per cell histogram.
 * The W1xW2 window starting position is at coordinates 0x0.
 * If the input image has dimensions that are not an integer multiple of W1xW2 blocks with the specified stride, then the last positions that contain only a partial W1xW2 window
 * will be calculated with the remaining part of the W1xW2 window padded with zeroes.
 * The Window W1xW2 must also have a size so that it contains an integer number of cells, otherwise the HOG node is not well-defined.
 * The descriptor calculation follows the details outlined in:\n
 * N. Dalal and B. Triggs. Histograms of Oriented Gradients for Human Detection.
 * INRIA, 2005.  https://lear.inrialpes.fr/people/triggs/pubs/Dalal-cvpr05.pdf\n
 * The output features tensor have 3 dimensions, given by:\n
 * \f[ (floor((image_{widt}h-window_{width})/window_{stride}) + 1)\f]
 * \f[ (floor((image_{height}-window_{height})/window_{stride}) + 1)\f]
 * \f[ floor((window_{width} - block_{width})/block_{stride} + 1) * floor((window_{height} - block_{height})/block_{stride} + 1) * num_{bins}] \f]
 * See <tt>\ref vxCreateTensor</tt> and <tt>\ref vxCreateVirtualTensor</tt>.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input image of type <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [in] magnitudes The gradient magnitudes of <tt>\ref vx_tensor</tt> of type <tt>\ref VX_TYPE_FLOAT32</tt> interpolated between adjacent bins. It is the output of <tt>\ref vxHOGCellsNode</tt>.
 * \param [in] bins       The gradient angle bins of <tt>\ref vx_tensor</tt> of type <tt>\ref VX_TYPE_INT8</tt> for the adjacent bins. It is the output of <tt>\ref vxHOGCellsNode</tt>.
 * \param [in] params The parameters of type <tt>\ref vx_hog_t</tt>.
 * \param [in] hog_param_size Size of <tt>\ref vx_hog_t</tt> in bytes.
 * \param [out] features The output HOG features of <tt>\ref vx_tensor</tt> of type <tt>\ref VX_TYPE_FLOAT32</tt>.
 * \return <tt>\ref vx_node</tt>.
 * \retval 0 Node could not be created.
 * \retval * Node handle.
 * \ingroup group_vision_function_hog
 */
VX_API_ENTRY vx_node VX_API_CALL vxHOGFeaturesNode(vx_graph graph, vx_image input, vx_tensor magnitudes, vx_tensor bins, const vx_hog_t *params, vx_size hog_param_size, vx_tensor features);

/*! \brief [Graph] Performs cell calculations for magnitude and histogram bins for Histogram of Oriented Gradients.
 * \details The first step of calculation is the computation of the gradient values. 
 * We apply a 1-D centred, point discrete derivative mask both of the horizontal and vertical directions. 
 * \f[ G_x = [-1, 0, 1] \f] and \f[ G_y = [-1, 0, 1]^T \f]
 * The second step of calculation is creating the cell histograms. 
 * Each pixel within the cell casts a weighted vote for an orientation-based histogram channel based on the values found in the gradient computation. 
 * The cells themselves are rectangular in shape, and the histogram channels are evenly spread over 0 to 360 degrees.
 * The magnitudes are calculated by the following formula:
 * \f[ magnitude = \sqrt{G_x^2 + G_y^2} \f]
 * Tensor size of output of magnitudes is \f[ [floor(image_{width}/cell_{width}) ,floor(image_{height}/cell_{height}) ] \f]
 * Tensor size of output of bins is \f[ [floor(image_{width}/cell_{width}) ,floor(image_{height}/cell_{height}) ,num_{bins}] \f]
 * \param [in] graph The reference to the graph.
 * \param [in] input The input image of type <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [in] cell_width The histogram cell width of type <tt>\ref VX_TYPE_INT32</tt>.
 * \param [in] cell_height The histogram cell height of type <tt>\ref VX_TYPE_INT32</tt>.
 * \param [in] num_bins  The histogram size of type <tt>\ref VX_TYPE_INT32</tt>.
 * \param [out] magnitudes The output gradient magnitudes of <tt>\ref vx_tensor</tt> of type <tt>\ref VX_TYPE_FLOAT32</tt> interpolated between adjacent bins.
 * \param [out] bins       The output gradient angle bins of <tt>\ref vx_tensor</tt> of type <tt>\ref VX_TYPE_INT8</tt> for the adjacent bins.
 * \return <tt>\ref vx_node</tt>.
 * \retval 0 Node could not be created.
 * \retval * Node handle.
 * \ingroup group_vision_function_hog
 */
VX_API_ENTRY vx_node VX_API_CALL vxHOGCellsNode(vx_graph graph, vx_image input, vx_int32 cell_width, vx_int32 cell_height, vx_int32 num_bins, vx_tensor magnitudes, vx_tensor bins);

/*! \brief [Graph] Finds the Probabilistic Hough Lines detected in the input binary image, each line is stored in the output array as a set of points (x1, y1, x2, y2) .
  * \details The algorithm contain randomness. Therefore in safety critical implementation.
 * it should be isolated and run in a lock step system. Were processing is done in redundancy mode outside a main processing system.
 * \param [in] graph graph handle
 * \param [in] input 8 bit, single channel binary source image
 * \param [in] params parameters of the struct <tt>\ref vx_hough_lines_p_t</tt>
 * \param [out] lines_array lines_array contains array of lines, see <tt>\ref vx_line2d_t</tt> The order of lines in implementation dependent
 * \param [out] num_lines [optional] The total number of detected lines in image. Use a VX_TYPE_SIZE scalar
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 * \ingroup group_vision_function_hough_lines_p
  */
VX_API_ENTRY vx_node VX_API_CALL vxHoughLinesPNode(vx_graph graph, vx_image input, const vx_hough_lines_p_t *params, vx_array lines_array, vx_scalar num_lines);

/*! \brief [Graph] The function applies bilateral filtering to the input tensor.
* \param [in] graph The reference to the graph.
* \param [in] src The input data a <tt>\ref vx_tensor</tt>. maximum 3 dimension and minimum 2. The tensor is of type <tt>\ref VX_TYPE_UINT8</tt> or <tt>\ref VX_TYPE_INT16</tt>.
* dimensions are [radiometric ,width,height] or [width,height].See <tt>\ref vxCreateTensor</tt> and <tt>\ref vxCreateVirtualTensor</tt>.
* \param [in] diameter of each pixel neighbourhood that is used during filtering. Values of diameter must be odd. Bigger then 3 and smaller then 10.
* \param [in] sigmaValues Filter sigma in the radiometric space. Supported values are bigger then 0 and smaller or equal 20.
* \param [in] sigmaSpace Filter sigma in the spatial space. Supported values are bigger then 0 and smaller or equal 20.
* \param [out] dst The output data a <tt>\ref vx_tensor</tt>,Of type <tt>\ref VX_TYPE_UINT8</tt> or <tt>\ref VX_TYPE_INT16</tt>. And must be the same type and size of the input.
* \note The border modes
*  <tt>\ref VX_NODE_BORDER</tt> value
*  <tt>\ref VX_BORDER_REPLICATE</tt> and <tt>\ref VX_BORDER_CONSTANT</tt> are supported.
* \return <tt>vx_node</tt>.
* \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>vxGetStatus</tt>
* \ingroup group_vision_function_bilateral_filter
*/
VX_API_ENTRY vx_node VX_API_CALL vxBilateralFilterNode(vx_graph graph, vx_tensor src, vx_int32 diameter, vx_float32 sigmaSpace, vx_float32 sigmaValues, vx_tensor dst);

/*! \brief [Graph] Performs element wise multiplications on element values in the input tensor data with a scale.
 * \param [in] graph The handle to the graph.
 * \param [in] input1 Input tensor data.  Implementations must support input tensor data type <tt>\ref VX_TYPE_INT16</tt> with fixed_point_position 8,
 * and tensor data types <tt>\ref VX_TYPE_UINT8</tt> and <tt>\ref VX_TYPE_INT8</tt>, with fixed_point_position 0.  
 * \param [in] input2 Input tensor data. The dimensions and sizes of input2 match those of input1, unless the vx_tensor of one or more dimensions in input2 is 1.
 * In this case, those dimensions are treated as if this tensor was expanded to match the size of the corresponding dimension of input1,
 * and data was duplicated on all terms in that dimension. After this expansion, the dimensions will be equal.
 * The data type must match the data type of Input1.
 * \param [in] scale A non-negative <tt>\ref VX_TYPE_FLOAT32</tt> multiplied to each product before overflow handling.
 * \param [in] overflow_policy A <tt>\ref vx_convert_policy_e</tt> enumeration.
 * \param [in] rounding_policy A <tt>\ref vx_round_policy_e</tt> enumeration.
 * \param [out] output The output tensor data with the same dimensions as the input tensor data.
 * \ingroup group_vision_function_tensor_multiply
 * \return <tt>\ref vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_node VX_API_CALL vxTensorMultiplyNode(vx_graph graph, vx_tensor input1, vx_tensor input2, vx_scalar scale, vx_convert_policy_e overflow_policy,
        vx_round_policy_e rounding_policy, vx_tensor output);

/*! \brief [Graph] Performs arithmetic addition on element values in the input tensor data.
 * \param [in] graph The handle to the graph.
 * \param [in] input1 Input tensor data.  Implementations must support input tensor data type <tt>\ref VX_TYPE_INT16</tt> with fixed_point_position 8,
 * and tensor data types <tt>\ref VX_TYPE_UINT8</tt> and <tt>\ref VX_TYPE_INT8</tt>, with fixed_point_position 0.  
 * \param [in] input2 Input tensor data. The dimensions and sizes of input2 match those of input1, unless the vx_tensor of one or more dimensions in input2 is 1.
 * In this case, those dimensions are treated as if this tensor was expanded to match the size of the corresponding dimension of input1,
 * and data was duplicated on all terms in that dimension. After this expansion, the dimensions will be equal. 
 * The data type must match the data type of Input1. 
 * \param [in] policy A <tt>\ref vx_convert_policy_e</tt> enumeration.
 * \param [out] output The output tensor data with the same dimensions as the input tensor data.
 * \ingroup group_vision_function_tensor_add
 * \return <tt>\ref vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_node VX_API_CALL vxTensorAddNode(vx_graph graph, vx_tensor input1, vx_tensor input2, vx_convert_policy_e policy, vx_tensor output);

/*! \brief [Graph] Performs arithmetic subtraction on element values in the input tensor data.
 * \param [in] graph The handle to the graph.
 * \param [in] input1 Input tensor data.  Implementations must support input tensor data type <tt>\ref VX_TYPE_INT16</tt> with fixed_point_position 8,
 * and tensor data types <tt>\ref VX_TYPE_UINT8</tt> and <tt\ref >VX_TYPE_INT8</tt>, with fixed_point_position 0.  
 * \param [in] input2 Input tensor data. The dimensions and sizes of input2 match those of input1, unless the vx_tensor of one or more dimensions in input2 is 1.
 * In this case, those dimensions are treated as if this tensor was expanded to match the size of the corresponding dimension of input1,
 * and data was duplicated on all terms in that dimension. After this expansion, the dimensions will be equal. 
 * The data type must match the data type of Input1. 
 * \param [in] policy A <tt>\ref vx_convert_policy_e</tt> enumeration.
 * \param [out] output The output tensor data with the same dimensions as the input tensor data.
 * \ingroup group_vision_function_tensor_subtract
 * \return <tt>\ref vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_node VX_API_CALL vxTensorSubtractNode(vx_graph graph, vx_tensor input1, vx_tensor input2, vx_convert_policy_e policy, vx_tensor output);

/*! \brief [Graph] Performs LUT on element values in the input tensor data.
 * \param [in] graph The handle to the graph.
 * \param [in] input1 Input tensor data. Implementations must support input tensor data type <tt>\ref VX_TYPE_INT16</tt> with fixed_point_position 8, 
 * and tensor data types <tt>\ref VX_TYPE_UINT8</tt> and <tt>\ref VX_TYPE_INT8</tt>, with fixed_point_position 0. 
 * \param [in] lut The look-up table to use, of type <tt>\ref vx_lut</tt>.
 * The elements of input1 are treated as unsigned integers to determine an index into the look-up table.
 * The data type of the items in the look-up table must match that of the output tensor.
 * \param [out] output The output tensor data with the same dimensions as the input tensor data.
 * \ingroup group_vision_function_tensor_tablelookup
 * \return <tt>\ref vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_node VX_API_CALL vxTensorTableLookupNode(vx_graph graph, vx_tensor input1, vx_lut lut, vx_tensor output);

/*! \brief [Graph] Performs transpose on the input tensor.
 * The node transpose the tensor according to a specified 2 indexes in the tensor (0-based indexing)
 * \param [in] graph The handle to the graph.
 * \param [in] input Input tensor data, Implementations must support input tensor data type <tt>\ref VX_TYPE_INT16</tt> with fixed_point_position 8,
 * and tensor data types <tt>\ref VX_TYPE_UINT8</tt> and <tt>\ref VX_TYPE_INT8</tt>, with fixed_point_position 0. 
 * \param [out] output output tensor data,
 * \param [in] dimension1 Dimension index that is transposed with dim 2.
 * \param [in] dimension2 Dimension index that is transposed with dim 1.
 * \ingroup group_vision_function_tensor_transpose
 * \return <tt>\ref vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_node VX_API_CALL vxTensorTransposeNode(vx_graph graph, vx_tensor input, vx_tensor output, vx_size dimension1, vx_size dimension2);
/*! \brief [Graph] Creates a bit-depth conversion node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input tensor. Implementations must support input tensor data type <tt>\ref VX_TYPE_INT16</tt> with fixed_point_position 8,
 * and tensor data types <tt>\ref VX_TYPE_UINT8</tt> and <tt>\ref VX_TYPE_INT8</tt>, with fixed_point_position 0.
 * \param [in] policy A <tt>\ref VX_TYPE_ENUM</tt> of the <tt>\ref vx_convert_policy_e</tt> enumeration.
 * \param [in] norm A scalar containing a <tt>\ref VX_TYPE_FLOAT32</tt> of the normalization value.
 * \param [in] offset A scalar containing a <tt>\ref VX_TYPE_FLOAT32</tt> of the offset value subtracted before normalization.
 * \param [out] output The output tensor. Implementations must support input tensor data type <tt>\ref VX_TYPE_INT16</tt>. with fixed_point_position 8. 
 * And <tt>\ref VX_TYPE_UINT8</tt> with fixed_point_position 0.
 * \ingroup group_vision_function_tensor_convert_depth
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxTensorConvertDepthNode(vx_graph graph, vx_tensor input, vx_convert_policy_e policy, vx_scalar norm, vx_scalar offset, vx_tensor output);

/*! \brief [Graph] Creates a generalized matrix multiplication node.
 * \param [in] graph The reference to the graph.
 * \param [in] input1 The first input 2D tensor of type <tt>\ref  VX_TYPE_INT16</tt> with fixed_point_pos 8, or tensor data types <tt>\ref VX_TYPE_UINT8</tt> or <tt>\ref VX_TYPE_INT8</tt>, with fixed_point_pos 0.
 * \param [in] input2 The second 2D tensor. Must be in the same data type as input1.
 * \param [in] input3 The third 2D tensor. Must be in the same data type as input1. [optional].
 * \param [in] matrix_multiply_params Matrix multiply parameters, see <tt>\ref vx_matrix_multiply_params_t </tt>.
 * \param [out] output The output 2D tensor. Must be in the same data type as input1. Output dimension must agree the formula in the description.
 * \ingroup group_vision_function_tensor_matrix_multiply
 * \return <tt>\ref vx_node</tt>.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_node VX_API_CALL vxMatrixMultiplyNode(vx_graph graph, vx_tensor input1, vx_tensor input2, vx_tensor input3,
    const vx_matrix_multiply_params_t *matrix_multiply_params, vx_tensor output);

/*! \brief Copy data from one object to another.
 * \note An implementation may optimize away the copy when virtual data objects are used.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input data object.
 * \param [out] output The output data object.
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation
 * should be checked using <tt>\ref vxGetStatus</tt>
 * \ingroup group_vision_function_copy
 */
VX_API_ENTRY vx_node VX_API_CALL vxCopyNode(vx_graph graph, vx_reference input, vx_reference output);

#ifdef __cplusplus
}
#endif

#endif