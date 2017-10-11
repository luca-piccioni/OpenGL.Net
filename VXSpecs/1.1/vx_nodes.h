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
                             vx_enum channel,
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
VX_API_ENTRY vx_node VX_API_CALL vxScaleImageNode(vx_graph graph, vx_image src, vx_image dst, vx_enum type);

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

/*! \brief [Graph] Creates a mean value and standard deviation node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input image. <tt>\ref VX_DF_IMAGE_U8</tt> is supported.
 * \param [out] mean The <tt>\ref VX_TYPE_FLOAT32</tt> average pixel value.
 * \param [out] stddev The <tt>\ref VX_TYPE_FLOAT32</tt> standard deviation of the pixel values.
 * \ingroup group_vision_function_meanstddev
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxMeanStdDevNode(vx_graph graph, vx_image input, vx_scalar mean, vx_scalar stddev);

/*! \brief [Graph] Creates a Threshold node.
 * \param [in] graph The reference to the graph.
 * \param [in] input The input image. <tt>\ref VX_DF_IMAGE_U8</tt> is supported.
 * \param [in] thresh The thresholding object that defines the parameters of
 * the operation. The <tt>\ref VX_THRESHOLD_TRUE_VALUE</tt> and <tt>\ref VX_THRESHOLD_FALSE_VALUE</tt> are taken into account.
 * \param [out] output The output Boolean image with values either <tt>\ref VX_THRESHOLD_TRUE_VALUE</tt> or
 * <tt>\ref VX_THRESHOLD_FALSE_VALUE</tt> from the \e thresh parameter.
 * \ingroup group_vision_function_threshold
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxThresholdNode(vx_graph graph, vx_image input, vx_threshold thresh, vx_image output);

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
VX_API_ENTRY vx_node VX_API_CALL vxNonLinearFilterNode(vx_graph graph, vx_enum function, vx_image input, vx_matrix mask, vx_image output);

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
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \param [out] laplacian The Laplacian pyramid with <tt>\ref VX_DF_IMAGE_S16</tt> to construct.
 * \param [out] output The lowest resolution image of type <tt>\ref VX_DF_IMAGE_S16</tt> necessary to reconstruct the input image from the pyramid.
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
 * \param [in] input The lowest resolution image of type <tt>\ref VX_DF_IMAGE_S16</tt> for the Laplacian pyramid
 * \param [out] output The output image of type <tt>\ref VX_DF_IMAGE_U8</tt> with the highest possible resolution reconstructed from the Laplacian pyramid.
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
 * \param [out] minLoc The minimum <tt>\ref VX_TYPE_COORDINATES2D</tt> locations (optional). If the input image has several minimums, the kernel will return up to the capacity of the array.
 * \param [out] maxLoc The maximum <tt>\ref VX_TYPE_COORDINATES2D</tt> locations (optional). If the input image has several maximums, the kernel will return up to the capacity of the array.
 * \param [out] minCount The total number of detected minimums in image (optional). Use a <tt>\ref VX_TYPE_UINT32</tt> scalar.
 * \param [out] maxCount The total number of detected maximums in image (optional). Use a <tt>\ref VX_TYPE_UINT32</tt> scalar.
 * \ingroup group_vision_function_minmaxloc
 * \return <tt>\ref vx_node</tt>.
 * \retval vx_node A node reference. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>
 */
VX_API_ENTRY vx_node VX_API_CALL vxMinMaxLocNode(vx_graph graph,
                        vx_image input,
                        vx_scalar minVal, vx_scalar maxVal,
                        vx_array minLoc, vx_array maxLoc,
                        vx_scalar minCount, vx_scalar maxCount);

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
                       vx_enum overflow_policy,
                       vx_enum rounding_policy,
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
                  vx_enum policy,
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
                       vx_enum policy,
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
VX_API_ENTRY vx_node VX_API_CALL vxConvertDepthNode(vx_graph graph, vx_image input, vx_image output, vx_enum policy, vx_scalar shift);

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
                                vx_int32 gradient_size, vx_enum norm_type,
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
VX_API_ENTRY vx_node VX_API_CALL vxWarpAffineNode(vx_graph graph, vx_image input, vx_matrix matrix, vx_enum type, vx_image output);

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
VX_API_ENTRY vx_node VX_API_CALL vxWarpPerspectiveNode(vx_graph graph, vx_image input, vx_matrix matrix, vx_enum type, vx_image output);

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
 * \param [out] num_corners The total number of detected corners in image (optional). Use a \ref VX_TYPE_SIZE scalar.
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
 * \param [out] num_corners The total number of detected corners in image (optional). Use a \ref VX_TYPE_SIZE scalar.
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
                               vx_enum termination,
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
                    vx_enum policy,
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

#ifdef __cplusplus
}
#endif

#endif
