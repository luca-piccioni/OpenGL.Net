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

#ifndef _OPENVX_UTILITY_H_
#define _OPENVX_UTILITY_H_

/*!
 * \file
 * \brief The OpenVX Utility Library.
 */

#ifdef __cplusplus
extern "C" {
#endif

/*! \brief [Immediate] Invokes an immediate Color Conversion.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image.
 * \param [out] output The output image.
 * \ingroup group_vision_function_colorconvert
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuColorConvert(vx_context context, vx_image input, vx_image output);

/*! \brief [Immediate] Invokes an immediate Channel Extract.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image. Must be one of the defined <tt>\ref vx_df_image_e</tt> multi-channel formats.
 * \param [in] channel The <tt>\ref vx_channel_e</tt> enumeration to extract.
 * \param [out] output The output image. Must be <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \ingroup group_vision_function_channelextract
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuChannelExtract(vx_context context, vx_image input, vx_enum channel, vx_image output);

/*! \brief [Immediate] Invokes an immediate Channel Combine.
 * \param [in] context The reference to the overall context.
 * \param [in] plane0 The plane that forms channel 0. Must be <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [in] plane1 The plane that forms channel 1. Must be <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [in] plane2 [optional] The plane that forms channel 2. Must be <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [in] plane3 [optional] The plane that forms channel 3. Must be <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [out] output The output image.
 * \ingroup group_vision_function_channelcombine
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuChannelCombine(vx_context context, vx_image plane0, vx_image plane1, vx_image plane2, vx_image plane3, vx_image output);

/*! \brief [Immediate] Invokes an immediate Sobel 3x3.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \param [out] output_x [optional] The output gradient in the x direction in <tt>\ref VX_DF_IMAGE_S16</tt>.
 * \param [out] output_y [optional] The output gradient in the y direction in <tt>\ref VX_DF_IMAGE_S16</tt>.
 * \ingroup group_vision_function_sobel3x3
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuSobel3x3(vx_context context, vx_image input, vx_image output_x, vx_image output_y);

/*! \brief [Immediate] Invokes an immediate Magnitude.
 * \param [in] context The reference to the overall context.
 * \param [in] grad_x The input x image. This must be in <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \param [in] grad_y The input y image. This must be in <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \param [out] mag The magnitude image. This will be in <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \ingroup group_vision_function_magnitude
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuMagnitude(vx_context context, vx_image grad_x, vx_image grad_y, vx_image mag);

/*! \brief [Immediate] Invokes an immediate Phase.
 * \param [in] context The reference to the overall context.
 * \param [in] grad_x The input x image. This must be in <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \param [in] grad_y The input y image. This must be in <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \param [out] orientation The phase image. This will be in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \ingroup group_vision_function_phase
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuPhase(vx_context context, vx_image grad_x, vx_image grad_y, vx_image orientation);

/*! \brief [Immediate] Scales an input image to an output image.
 * \param [in] context The reference to the overall context.
 * \param [in] src The source image of type <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [out] dst The destintation image of type <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [in] type The interpolation type. \see vx_interpolation_type_e.
 * \ingroup group_vision_function_scale_image
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuScaleImage(vx_context context, vx_image src, vx_image dst, vx_enum type);

/*! \brief [Immediate] Processes the image through the LUT.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt>.
 * \param [in] lut The LUT which is of type <tt>\ref VX_TYPE_UINT8</tt> or <tt>\ref VX_TYPE_INT16</tt>.
 * \param [out] output The output image of the same type as the input image.
 * \ingroup group_vision_function_lut
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuTableLookup(vx_context context, vx_image input, vx_lut lut, vx_image output);

/*! \brief [Immediate] Generates a distribution from an image.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt>
 * \param [out] distribution The output distribution.
 * \ingroup group_vision_function_histogram
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuHistogram(vx_context context, vx_image input, vx_distribution distribution);

/*! \brief [Immediate] Equalizes the Histogram of a grayscale image.
 * \param [in] context The reference to the overall context.
 * \param [in] input The grayscale input image in <tt>\ref VX_DF_IMAGE_U8</tt>
 * \param [out] output The grayscale output image of type <tt>\ref VX_DF_IMAGE_U8</tt> with equalized brightness and contrast.
 * \ingroup group_vision_function_equalize_hist
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuEqualizeHist(vx_context context, vx_image input, vx_image output);

/*! \brief [Immediate] Computes the absolute difference between two images.
 * \param [in] context The reference to the overall context.
 * \param [in] in1 An input image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \param [in] in2 An input image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \param [out] out The output image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \ingroup group_vision_function_absdiff
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuAbsDiff(vx_context context, vx_image in1, vx_image in2, vx_image out);

/*! \brief [Immediate] Computes the mean value and standard deviation.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image. <tt>\ref VX_DF_IMAGE_U8</tt> is supported.
 * \param [out] mean The average pixel value.
 * \param [out] stddev The standard deviation of the pixel values.
 * \ingroup group_vision_function_meanstddev
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuMeanStdDev(vx_context context, vx_image input, vx_float32 *mean, vx_float32 *stddev);

/*! \brief [Immediate] Threshold's an input image and produces a <tt>\ref VX_DF_IMAGE_U8</tt>  * boolean image.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image. <tt>\ref VX_DF_IMAGE_U8</tt> is supported.
 * \param [in] thresh The thresholding object that defines the parameters of
 * the operation. The <tt>\ref VX_THRESHOLD_TRUE_VALUE</tt> and <tt>\ref VX_THRESHOLD_FALSE_VALUE</tt> are taken into account.
 * \param [out] output The output Boolean image with values either <tt>\ref VX_THRESHOLD_TRUE_VALUE</tt> or
 * <tt>\ref VX_THRESHOLD_FALSE_VALUE</tt> from the \e thresh parameter.
 * \ingroup group_vision_function_threshold
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuThreshold(vx_context context, vx_image input, vx_threshold thresh, vx_image output);

/*! \brief [Immediate] Computes the integral image of the input.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \param [out] output The output image in <tt>\ref VX_DF_IMAGE_U32</tt> format.
 * \ingroup group_vision_function_integral_image
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuIntegralImage(vx_context context, vx_image input, vx_image output);

/*! \brief [Immediate] Erodes an image by a 3x3 window.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \param [out] output The output image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \ingroup group_vision_function_erode_image
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuErode3x3(vx_context context, vx_image input, vx_image output);

/*! \brief [Immediate] Dilates an image by a 3x3 window.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \param [out] output The output image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \ingroup group_vision_function_dilate_image
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuDilate3x3(vx_context context, vx_image input, vx_image output);

/*! \brief [Immediate] Computes a median filter on the image by a 3x3 window.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \param [out] output The output image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \ingroup group_vision_function_median_image
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuMedian3x3(vx_context context, vx_image input, vx_image output);

/*! \brief [Immediate] Computes a box filter on the image by a 3x3 window.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \param [out] output The output image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \ingroup group_vision_function_box_image
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuBox3x3(vx_context context, vx_image input, vx_image output);

/*! \brief [Immediate] Computes a gaussian filter on the image by a 3x3 window.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \param [out] output The output image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \ingroup group_vision_function_gaussian_image
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuGaussian3x3(vx_context context, vx_image input, vx_image output);

/*! \brief [Immediate] Creates a Non-linear Filter Node.
 * \param [in] context The reference to the overall context.
 * \param [in] function The non-linear filter function. See <tt>\ref vx_non_linear_filter_e</tt>.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \param [in] mask The mask to be applied to the Non-linear function. <tt>\ref VX_MATRIX_ORIGIN</tt> attribute is used
 * to place the mask appropriately when computing the resulting image. See <tt>\ref vxCreateMatrixFromPattern</tt>.
 * \param [out] output The output image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 * \ingroup group_vision_function_nonlinear_filter
 */
VX_API_ENTRY vx_status VX_API_CALL vxuNonLinearFilter(vx_context context, vx_enum function, vx_image input, vx_matrix mask, vx_image output);


/*! \brief [Immediate] Computes a convolution on the input image with the supplied
 * matrix.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \param [in] conv The <tt>\ref vx_int16</tt> convolution matrix.
 * \param [out] output The output image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \ingroup group_vision_function_custom_convolution
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuConvolve(vx_context context, vx_image input, vx_convolution conv, vx_image output);

/*! \brief [Immediate] Computes a Gaussian pyramid from an input image.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt>
 * \param [out] gaussian The Gaussian pyramid with <tt>\ref VX_DF_IMAGE_U8</tt> to construct.
 * \ingroup group_vision_function_gaussian_pyramid
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuGaussianPyramid(vx_context context, vx_image input, vx_pyramid gaussian);

/*! \brief [Immediate] Computes a Laplacian pyramid from an input image.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \param [out] laplacian The Laplacian pyramid with <tt>\ref VX_DF_IMAGE_S16</tt> to construct.
 * \param [out] output The lowest resolution image of type <tt>\ref VX_DF_IMAGE_S16</tt> necessary to reconstruct the input image from the pyramid.
 * \ingroup group_vision_function_laplacian_pyramid
 * \see group_pyramid
 * \return A <tt>\ref vx_status</tt> enumeration.
 * \retval VX_SUCCESS Success.
 * \retval * An error occured. See <tt>\ref vx_status_e</tt>
 */
VX_API_ENTRY vx_status VX_API_CALL vxuLaplacianPyramid(vx_context context, vx_image input, vx_pyramid laplacian, vx_image output);

/*! \brief [Immediate] Reconstructs an image from a Laplacian Image pyramid.
 * \param [in] context The reference to the overall context.
 * \param [in] laplacian The Laplacian pyramid with <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \param [in] input The lowest resolution image of type <tt>\ref VX_DF_IMAGE_S16</tt> for the Laplacian pyramid
 * \param [out] output The output image of type <tt>\ref VX_DF_IMAGE_U8</tt> with the highest possible resolution reconstructed from the Laplacian pyramid.
 * \ingroup group_vision_function_laplacian_reconstruct
 * \see group_pyramid
 * \return A <tt>\ref vx_status</tt> enumeration.
 * \retval VX_SUCCESS Success.
 * \retval * An error occured. See <tt>\ref vx_status_e</tt>
 */
VX_API_ENTRY vx_status VX_API_CALL vxuLaplacianReconstruct(vx_context context, vx_pyramid laplacian, vx_image input,
                                       vx_image output);

/*! \brief [Immediate] Computes an accumulation.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \param [in,out] accum The accumulation image in <tt>\ref VX_DF_IMAGE_S16</tt>
 * \ingroup group_vision_function_accumulate
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuAccumulateImage(vx_context context, vx_image input, vx_image accum);

/*! \brief [Immediate] Computes a weighted accumulation.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \param [in] alpha A <tt>\ref VX_TYPE_FLOAT32</tt> type, the input value with the range \f$ 0.0 \le \alpha \le 1.0 \f$.
 * \param [in,out] accum The <tt>\ref VX_DF_IMAGE_U8</tt> accumulation image.
 * \ingroup group_vision_function_accumulate_weighted
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuAccumulateWeightedImage(vx_context context, vx_image input, vx_scalar alpha, vx_image accum);

/*! \brief [Immediate] Computes a squared accumulation.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \param [in] shift A <tt>\ref VX_TYPE_UINT32</tt> type, the input value with the range \f$ 0 \le shift \le 15 \f$.
 * \param [in,out] accum The accumulation image in <tt>\ref VX_DF_IMAGE_S16</tt>
 * \ingroup group_vision_function_accumulate_square
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuAccumulateSquareImage(vx_context context, vx_image input, vx_scalar shift, vx_image accum);

/*! \brief [Immediate] Computes the minimum and maximum values of the image.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \param [out] minVal The minimum value in the image, which corresponds to the type of the input.
 * \param [out] maxVal The maximum value in the image, which corresponds to the type of the input.
 * \param [out] minLoc The minimum <tt>\ref VX_TYPE_COORDINATES2D</tt> locations (optional). If the input image has several minimums, the kernel will return up to the capacity of the array.
 * \param [out] maxLoc The maximum <tt>\ref VX_TYPE_COORDINATES2D</tt> locations (optional). If the input image has several maximums, the kernel will return up to the capacity of the array.
 * \param [out] minCount The total number of detected minimums in image (optional). Use a <tt>\ref VX_TYPE_UINT32</tt> scalar.
 * \param [out] maxCount The total number of detected maximums in image (optional). Use a <tt>\ref VX_TYPE_UINT32</tt> scalar.
 * \ingroup group_vision_function_minmaxloc
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuMinMaxLoc(vx_context context, vx_image input,
                        vx_scalar minVal, vx_scalar maxVal,
                        vx_array minLoc, vx_array maxLoc,
                        vx_scalar minCount, vx_scalar maxCount);

/*! \brief [Immediate] Converts the input images bit-depth into the output image.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image.
 * \param [out] output The output image.
 * \param [in] policy A <tt>\ref VX_TYPE_ENUM</tt> of the <tt>\ref vx_convert_policy_e</tt> enumeration.
 * \param [in] shift A scalar containing a <tt>\ref VX_TYPE_INT32</tt> of the shift value.
 * \ingroup group_vision_function_convertdepth
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>..
 */
VX_API_ENTRY vx_status VX_API_CALL vxuConvertDepth(vx_context context, vx_image input, vx_image output, vx_enum policy, vx_int32 shift);

/*! \brief [Immediate] Computes Canny Edges on the input image into the output image.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \param [in] hyst The double threshold for hysteresis. The threshold data_type shall be either <tt>\ref VX_TYPE_UINT8</tt>
 * or <tt>\ref VX_TYPE_INT16</tt>. The <tt>\ref VX_THRESHOLD_TRUE_VALUE</tt> and <tt>\ref VX_THRESHOLD_FALSE_VALUE</tt>
 * of <tt>\ref vx_threshold</tt> are ignored.
 * \param [in] gradient_size The size of the Sobel filter window, must support at least 3, 5 and 7.
 * \param [in] norm_type A flag indicating the norm used to compute the gradient, VX_NORM_L1 or VX_NORM_L2.
 * \param [out] output The output image in <tt>\ref VX_DF_IMAGE_U8</tt> format with values either 0 or 255.
 * \ingroup group_vision_function_canny
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuCannyEdgeDetector(vx_context context, vx_image input, vx_threshold hyst,
                               vx_int32 gradient_size, vx_enum norm_type,
                               vx_image output);

/*! \brief [Immediate] Performs a Gaussian Blur on an image then half-scales it. The interpolation mode used is nearest-neighbor.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \param [out] output The output <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \param [in] kernel_size The input size of the Gaussian filter. Supported values are 1, 3 and 5.
 * \ingroup group_vision_function_scale_image
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuHalfScaleGaussian(vx_context context, vx_image input, vx_image output, vx_int32 kernel_size);

/*! \brief [Immediate] Computes the bitwise and between two images.
 * \param [in] context The reference to the overall context.
 * \param [in] in1 A <tt>\ref VX_DF_IMAGE_U8</tt> input image
 * \param [in] in2 A <tt>\ref VX_DF_IMAGE_U8</tt> input image
 * \param [out] out The <tt>\ref VX_DF_IMAGE_U8</tt> output image.
 * \ingroup group_vision_function_and
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuAnd(vx_context context, vx_image in1, vx_image in2, vx_image out);

/*! \brief [Immediate] Computes the bitwise inclusive-or between two images.
 * \param [in] context The reference to the overall context.
 * \param [in] in1 A <tt>\ref VX_DF_IMAGE_U8</tt> input image
 * \param [in] in2 A <tt>\ref VX_DF_IMAGE_U8</tt> input image
 * \param [out] out The <tt>\ref VX_DF_IMAGE_U8</tt> output image.
 * \ingroup group_vision_function_or
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuOr(vx_context context, vx_image in1, vx_image in2, vx_image out);

/*! \brief [Immediate] Computes the bitwise exclusive-or between two images.
 * \param [in] context The reference to the overall context.
 * \param [in] in1 A <tt>\ref VX_DF_IMAGE_U8</tt> input image
 * \param [in] in2 A <tt>\ref VX_DF_IMAGE_U8</tt> input image
 * \param [out] out The <tt>\ref VX_DF_IMAGE_U8</tt> output image.
 * \ingroup group_vision_function_xor
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuXor(vx_context context, vx_image in1, vx_image in2, vx_image out);

/*! \brief [Immediate] Computes the bitwise not of an image.
 * \param [in] context The reference to the overall context.
 * \param [in] input The <tt>\ref VX_DF_IMAGE_U8</tt> input image
 * \param [out] output The <tt>\ref VX_DF_IMAGE_U8</tt> output image.
 * \ingroup group_vision_function_not
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuNot(vx_context context, vx_image input, vx_image output);

/*! \brief [Immediate] Performs elementwise multiplications on pixel values in the input images and a scale.
 * \param [in] context The reference to the overall context.
 * \param [in] in1 A <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> input image.
 * \param [in] in2 A <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> input image.
 * \param [in] scale A non-negative <tt>\ref VX_TYPE_FLOAT32</tt> multiplied to each product before overflow handling.
 * \param [in] overflow_policy A <tt>\ref vx_convert_policy_e</tt> enumeration.
 * \param [in] rounding_policy A <tt>\ref vx_round_policy_e</tt> enumeration.
 * \param [out] out The output image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \ingroup group_vision_function_mult
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuMultiply(vx_context context, vx_image in1, vx_image in2, vx_float32 scale, vx_enum overflow_policy, vx_enum rounding_policy, vx_image out);

/*! \brief [Immediate] Performs arithmetic addition on pixel values in the input images.
 * \param [in] context The reference to the overall context.
 * \param [in] in1 A <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> input image.
 * \param [in] in2 A <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> input image.
 * \param [in] policy A \ref vx_convert_policy_e enumeration.
 * \param [out] out The output image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \ingroup group_vision_function_add
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuAdd(vx_context context, vx_image in1, vx_image in2, vx_enum policy, vx_image out);

/*! \brief [Immediate] Performs arithmetic subtraction on pixel values in the input images.
 * \param [in] context The reference to the overall context.
 * \param [in] in1 A <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> input image, the minuend.
 * \param [in] in2 A <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> input image, the subtrahend.
 * \param [in] policy A \ref vx_convert_policy_e enumeration.
 * \param [out] out The output image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \ingroup group_vision_function_sub
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuSubtract(vx_context context, vx_image in1, vx_image in2, vx_enum policy, vx_image out);

/*! \brief [Immediate] Performs an Affine warp on an image.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \param [in] matrix The affine matrix. Must be 2x3 of type \ref VX_TYPE_FLOAT32.
 * \param [in] type The interpolation type from \ref vx_interpolation_type_e.
 * \ref VX_INTERPOLATION_AREA is not supported.
 * \param [out] output The output <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \ingroup group_vision_function_warp_affine
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuWarpAffine(vx_context context, vx_image input, vx_matrix matrix, vx_enum type, vx_image output);

/*! \brief [Immediate] Performs an Perspective warp on an image.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \param [in] matrix The perspective matrix. Must be 3x3 of type \ref VX_TYPE_FLOAT32.
 * \param [in] type The interpolation type from \ref vx_interpolation_type_e.
 * \ref VX_INTERPOLATION_AREA is not supported.
 * \param [out] output The output <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \ingroup group_vision_function_warp_perspective
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuWarpPerspective(vx_context context, vx_image input, vx_matrix matrix, vx_enum type, vx_image output);

/*! \brief [Immediate] Computes the Harris Corners over an image and produces the array of scored points.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \param [in] strength_thresh The <tt>\ref VX_TYPE_FLOAT32</tt> minimum threshold which to eliminate Harris Corner scores (computed using the normalized Sobel kernel).
 * \param [in] min_distance The <tt>\ref VX_TYPE_FLOAT32</tt> radial Euclidean distance for non-maximum suppression.
 * \param [in] sensitivity The <tt>\ref VX_TYPE_FLOAT32</tt> scalar sensitivity threshold \f$ k \f$ from the Harris-Stephens equation.
 * \param [in] gradient_size The gradient window size to use on the input. The
 * implementation must support at least 3, 5, and 7.
 * \param [in] block_size The block window size used to compute the harris corner score.
 * The implementation must support at least 3, 5, and 7.
 * \param [out] corners The array of <tt>\ref VX_TYPE_KEYPOINT</tt> structs. The order of the keypoints in this array is implementation dependent.
 * \param [out] num_corners The total number of detected corners in image (optional). Use a \ref VX_TYPE_SIZE scalar
 * \ingroup group_vision_function_harris
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuHarrisCorners(vx_context context,
                           vx_image input,
                           vx_scalar strength_thresh,
                           vx_scalar min_distance,
                           vx_scalar sensitivity,
                           vx_int32 gradient_size,
                           vx_int32 block_size,
                           vx_array corners,
                           vx_scalar num_corners);


/*! \brief [Immediate] Computes corners on an image using FAST algorithm and produces the array of feature points.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \param [in] strength_thresh Threshold on difference between intensity of the central pixel and pixels on Bresenham's circle
 * of radius 3 (<tt>\ref VX_TYPE_FLOAT32</tt> scalar), with a value in the range of 0.0 \f$\le\f$ strength_thresh < 256.0.
 *  Any fractional value will be truncated to an integer.
 * \param [in] nonmax_suppression If true, non-maximum suppression is applied to
 * detected corners before being places in the <tt>\ref vx_array</tt> of <tt>\ref VX_TYPE_KEYPOINT</tt> structs.
 * \param [out] corners Output corner <tt>\ref vx_array</tt> of <tt>\ref VX_TYPE_KEYPOINT</tt>. The order of the keypoints in this array is implementation dependent.
 * \param [out] num_corners The total number of detected corners in image (optional). Use a \ref VX_TYPE_SIZE scalar.
 * \ingroup group_vision_function_fast
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval *          An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuFastCorners(vx_context context, vx_image input, vx_scalar strength_thresh, vx_bool nonmax_suppression, vx_array corners, vx_scalar num_corners);

/*! \brief [Immediate] Computes an optical flow on two images.
 * \param [in] context The reference to the overall context.
 * \param [in] old_images Input of first (old) image pyramid in <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [in] new_images Input of destination (new) image pyramid in <tt>\ref VX_DF_IMAGE_U8</tt>
 * \param [in] old_points an array of key points in a vx_array of <tt>\ref VX_TYPE_KEYPOINT</tt> those key points are defined at
 *  the old_images high resolution pyramid
 * \param [in] new_points_estimates an array of estimation on what is the output key points in a <tt>\ref vx_array</tt> of
 * <tt>\ref VX_TYPE_KEYPOINT</tt> those keypoints are defined at the new_images high resolution pyramid
 * \param [out] new_points an output array of key points in a <tt>\ref vx_array</tt> of <tt>\ref VX_TYPE_KEYPOINT</tt> those key points are
 *  defined at the new_images high resolution pyramid
 * \param [in] termination termination can be <tt>\ref VX_TERM_CRITERIA_ITERATIONS</tt> or <tt>\ref VX_TERM_CRITERIA_EPSILON</tt> or
 * <tt>\ref VX_TERM_CRITERIA_BOTH</tt>
 * \param [in] epsilon is the <tt>\ref vx_float32</tt> error for terminating the algorithm
 * \param [in] num_iterations is the number of iterations. Use a <tt>\ref VX_TYPE_UINT32</tt> scalar.
 * \param [in] use_initial_estimate Can be set to either <tt>\ref vx_false_e</tt> or <tt>\ref vx_true_e</tt>.
 * \param [in] window_dimension The size of the window on which to perform the algorithm. See
 *  <tt>\ref VX_CONTEXT_OPTICAL_FLOW_MAX_WINDOW_DIMENSION</tt>
 *
 * \ingroup group_vision_function_opticalflowpyrlk
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuOpticalFlowPyrLK(vx_context context,
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

/*! \brief [Immediate] Remaps an output image from an input image.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \param [in] table The remap table object.
 * \param [in] policy The interpolation policy from \ref vx_interpolation_type_e.
 * \ref VX_INTERPOLATION_AREA is not supported.
 * \param [out] output The output <tt>\ref VX_DF_IMAGE_U8</tt> image.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \ingroup group_vision_function_remap
 */
VX_API_ENTRY vx_status VX_API_CALL vxuRemap(vx_context context,
                  vx_image input,
                  vx_remap table,
                  vx_enum policy,
                  vx_image output);

#ifdef __cplusplus
}
#endif

#endif
