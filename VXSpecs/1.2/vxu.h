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

/*! \brief [Immediate] Computes the mean value and optionally the standard deviation.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image. <tt>\ref VX_DF_IMAGE_U8</tt> is supported.
 * \param [out] mean The average pixel value.
 * \param [out] stddev [optional]The standard deviation of the pixel values.
 * \ingroup group_vision_function_meanstddev
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuMeanStdDev(vx_context context, vx_image input, vx_float32 *mean, vx_float32 *stddev);

/*! \brief [Immediate] Threshold's an input image and produces a <tt>\ref VX_DF_IMAGE_U8</tt> boolean image.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image. Only images with format <tt>\ref VX_DF_IMAGE_U8</tt>
 * and <tt>\ref VX_DF_IMAGE_S16</tt> are supported.
 * \param [in] thresh The thresholding object that defines the parameters of
 * the operation: thresholding value(s) and true/false output values.
 * \param [out] output The output image, that will contain as pixel value
 * true and false values defined by \p thresh. Only images with format
 * <tt>\ref VX_DF_IMAGE_U8</tt> are supported.
 * \ingroup group_vision_function_threshold
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuThreshold(vx_context context, vx_image input, vx_threshold thresh, vx_image output);

/*! \brief [Immediate] Performs Non-Maxima Suppression on an image, producing an image of the same type.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \param [in] mask [optional] Constrict suppression to a ROI. The mask image is of type <tt>\ref VX_DF_IMAGE_U8</tt> and must be the same dimensions as the input image.
 * \param [in] win_size The size of window over which to perform the localized non-maxima suppression.  Must be odd, and less than or equal to the smallest dimension of the input image.
 * \param [out] output The output image, of the same type as the input, that has been non-maxima suppressed.
 * \ingroup group_vision_function_nms
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuNonMaxSuppression(vx_context context, vx_image input, vx_image mask, vx_int32 win_size, vx_image output);

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

/*! \brief [Immediate] Performs Non-linear Filtering.
 * \param [in] context The reference to the overall context.
 * \param [in] function The non-linear filter function. See <tt>\ref vx_non_linear_filter_e</tt>.
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> format.
 * \param [in] mask The mask to be applied to the Non-linear function. <tt>\ref VX_MATRIX_ORIGIN</tt> attribute is used
 * to place the mask appropriately when computing the resulting image. See <tt>\ref vxCreateMatrixFromPattern</tt> and <tt>\ref vxCreateMatrixFromPatternAndOrigin</tt>.
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
 * \param [in] input The input image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format.
 * \param [out] laplacian The Laplacian pyramid with <tt>\ref VX_DF_IMAGE_S16</tt> to construct.
 * \param [out] output The lowest resolution image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format necessary to reconstruct the input image from the pyramid. The output image format should be same as input image format.
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
 * \param [in] input The lowest resolution image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format for the Laplacian pyramid.
 * \param [out] output The output image in <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt> format with the highest possible resolution reconstructed from the Laplacian pyramid. The output image format should be same as input image format.
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
 * \param [out] minLoc [optional] The minimum <tt>\ref VX_TYPE_COORDINATES2D</tt> locations. If the input image has several minimums, the kernel will return up to the capacity of the array.
 * \param [out] maxLoc [optional] The maximum <tt>\ref VX_TYPE_COORDINATES2D</tt> locations. If the input image has several maximums, the kernel will return up to the capacity of the array.
 * \param [out] minCount [optional] The total number of detected minimums in image. Use a <tt>\ref VX_TYPE_SIZE</tt> scalar.
 * \param [out] maxCount [optional] The total number of detected maximums in image. Use a <tt>\ref VX_TYPE_SIZE</tt> scalar.
 * \ingroup group_vision_function_minmaxloc
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuMinMaxLoc(vx_context context, vx_image input,
                        vx_scalar minVal, vx_scalar maxVal,
                        vx_array minLoc, vx_array maxLoc,
                        vx_scalar minCount, vx_scalar maxCount);

/*! \brief [Immediate] Computes pixel-wise minimum values between two images.
 * \param [in] context The reference to the overall context.
 * \param [in] in1 The first input image. Must be of type <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt>.
 * \param [in] in2 The second input image. Must be of type <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt>.
 * \param [out] out The output image which will hold the result of min.
 * \ingroup group_vision_function_min.
 * \return  A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuMin(vx_context context, vx_image in1, vx_image in2, vx_image out);

/*! \brief [Immediate] Computes pixel-wise maximum values between two images.
 * \param [in]  context The reference to the overall context.
 * \param [in] in1 The first input image. Must be of type <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt>.
 * \param [in] in2 The second input image. Must be of type <tt>\ref VX_DF_IMAGE_U8</tt> or <tt>\ref VX_DF_IMAGE_S16</tt>.
 * \param [out] out The output image which will hold the result of max.
 * \ingroup group_vision_function_max
 * \return  A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuMax(vx_context context, vx_image in1, vx_image in2, vx_image out);

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
 * \param [out] num_corners [optional] The total number of detected corners in image. Use a \ref VX_TYPE_SIZE scalar
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
 * \param [out] num_corners [optional] The total number of detected corners in image. Use a \ref VX_TYPE_SIZE scalar.
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
							  
/*! \brief [Immediate]  The Node Compares an image template against overlapped image regions.
 * \details The detailed equation to the matching can be found in <tt>\ref vx_comp_metric_e</tt>.
 * The output of the template matching node is a comparison map as described in <tt>\ref vx_comp_metric_e</tt>.
 * The Node have a limitation on the template image size (width*height). It should not be larger then 65535.
 * If the valid region of the template image is smaller than the entire template image, the result in the destination image is implementation-dependent.
 * \param [in] context The reference to the overall context.
 * \param [in] src The input image of type <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [in] templateImage Searched template of type <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [in] matchingMethod attribute specifying the comparison method <tt>\ref vx_comp_metric_e</tt>. This function support only <tt>\ref VX_COMPARE_CCORR_NORM</tt> and <tt>\refVX_COMPARE_L2</tt>.
 * \param [out] output Map of comparison results. The output is an image of type VX_DF_IMAGE_S16
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 * \ingroup group_vision_function_match_template
 */
 VX_API_ENTRY vx_status VX_API_CALL vxuMatchTemplateNode(vx_context context, vx_image src, vx_image templateImage, vx_enum matchingMethod, vx_image output);

 /*! \brief [Immediate] Creates a node that extracts LBP image from an input image
 * \param [in] context The reference to the overall context.
 * \param [in] in		An input image in <tt>vx_image</tt>. Or \f$ SrcImg\f$ in the equations. the image is of type <tt>\ref VX_DF_IMAGE_U8</tt>
 * \param [in] format	A variation of LBP like original LBP and mLBP. see <tt> \ref vx_lbp_format_e </tt>
 * \param [in] kernel_size Kernel size. Only size of 3 and 5 are supported
 * \param [out] out	An output image in <tt>vx_image</tt>.Or \f$ DstImg\f$ in the equations. the image is of type <tt>\ref VX_DF_IMAGE_U8</tt>
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 * \ingroup group_vision_function_lbp
 */
VX_API_ENTRY vx_status VX_API_CALL vxuLBPNode(vx_context context,
	vx_image in, vx_enum format, vx_int8 kernel_size, vx_image out);
					  							  
/*! \brief [Immediate] Computes Histogram of Oriented Gradients features for the W1xW2 window in a sliding window fashion over the whole input image.
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
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image of type <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [in] magnitudes The gradient magnitudes of <tt>\ref vx_tensor</tt> of type <tt>\ref VX_TYPE_FLOAT32</tt> interpolated between adjacent bins. It is the output of <tt>\ref vxHOGCellsNode</tt>.
 * \param [in] bins       The gradient angle bins of <tt>\ref vx_tensor</tt> of type <tt>\ref VX_TYPE_INT8</tt> for the adjacent bins. It is the output of <tt>\ref vxHOGCellsNode</tt>.
 * \param [in] params The parameters of type <tt>\ref vx_hog_t</tt>.
 * \param [in] hog_param_size Size of <tt>\ref vx_hog_t</tt> in bytes.
 * \param [out] features The output HOG features of <tt>\ref vx_tensor</tt> of type <tt>\ref VX_TYPE_FLOAT32</tt>.
 *
 * \ingroup group_vision_function_hog
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
 
 
VX_API_ENTRY vx_status VX_API_CALL vxuHOGFeatures(vx_context context, vx_image input, vx_tensor magnitudes, vx_tensor bins, const vx_hog_t *params, vx_size hog_param_size, vx_tensor features);

/*! \brief [Immediate] Performs cell calculations for magnitude and histogram bins for Histogram of Oriented Gradients.
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
 * \param [in] context The reference to the overall context.
 * \param [in] input The input image of type <tt>\ref VX_DF_IMAGE_U8</tt>.
 * \param [in] cell_width The histogram cell width of type <tt>\ref VX_TYPE_INT32</tt>.
 * \param [in] cell_height The histogram cell height of type <tt>\ref VX_TYPE_INT32</tt>.
 * \param [in] num_bins  The histogram size of type <tt>\ref VX_TYPE_INT32</tt>.
 * \param [out] magnitudes The output gradient magnitudes of <tt>\ref vx_tensor</tt> of type <tt>\ref VX_TYPE_FLOAT32</tt> interpolated between adjacent bins.
 * \param [out] bins       The output gradient angle bins of <tt>\ref vx_tensor</tt> of type <tt>\ref VX_TYPE_INT8</tt> for the adjacent bins.
 *
 * \ingroup group_vision_function_hog
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuHOGCells(vx_context context, vx_image input, vx_int32 cell_size, vx_int32 num_bins, vx_tensor magnitudes, vx_tensor bins);

/*! \brief [Immediate] Finds the Probabilistic Hough Lines detected in the input binary image, each line is stored in the output array as a set of points (x1, y1, x2, y2) .
  * \details The algorithm contain randomness. Therefore in safety critical implementation.
 * it should be isolated and run in a lock step system. Were processing is done in redundancy mode outside a main processing system.
 * \param [in] context The reference to the overall context.
 * \param [in] input 8 bit, single channel binary source image
 * \param [in] params parameters of the struct <tt>\ref vx_hough_lines_p_t</tt>
 * \param [out] lines_array lines_array contains array of lines, see <tt>\ref vx_line2d_t</tt> The order of lines in implementation dependent
 * \param [out] num_lines [optional] The total number of detected lines in image. Use a VX_TYPE_SIZE scalar
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 * \ingroup group_vision_function_hough_lines_p
  */
VX_API_ENTRY vx_status VX_API_CALL vxuHoughLinesPNode(vx_context context, vx_image input, const vx_hough_lines_p_t *params, vx_array lines_array, vx_scalar num_lines);

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

/*! \brief [Immediate] The function applies bilateral filtering to the input tensor.
* \param [in] context The reference to the overall context.
* \param [in] src The input data a <tt>\ref vx_tensor</tt>. maximum 3 dimension and minimum 2. The tensor is of type <tt>\ref VX_TYPE_UINT8</tt> or <tt>\ref VX_TYPE_INT16</tt>.
* dimensions are [radiometric ,width,height] or [width,height]
* \param [in] diameter of each pixel neighbourhood that is used during filtering. Values of diameter must be odd. Bigger then 3 and smaller then 10.
* \param [in] sigmaValues Filter sigma in the radiometric space. Supported values are bigger then 0 and smaller or equal 20.
* \param [in] sigmaSpace Filter sigma in the spatial space. Supported values are bigger then 0 and smaller or equal 20.
* \param [out] dst The output data a <tt>\ref vx_tensor</tt>,Of type <tt>\ref VX_TYPE_UINT8</tt> or <tt>\ref VX_TYPE_INT16</tt>. And must be the same type and size of the input.
* \note The border modes
*  <tt>\ref VX_NODE_BORDER</tt> value
*  <tt>\ref VX_BORDER_REPLICATE</tt> and <tt>\ref VX_BORDER_CONSTANT</tt> are supported.
* \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
* \ingroup group_vision_function_bilateral_filter
*/
VX_API_ENTRY vx_status VX_API_CALL vxuBilateralFilter(vx_context context, vx_tensor src, vx_int32 diameter, vx_float32 sigmaSpace, vx_float32 sigmaValues, vx_tensor dst);

/*! \brief [Immediate] Performs element wise multiplications on element values in the input tensor data with a scale.
 * \param [in] context The reference to the overall context.
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
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuTensorMultiply(vx_context context, vx_tensor input1, vx_tensor input2, vx_scalar scale, vx_enum overflow_policy,
        vx_enum rounding_policy, vx_tensor output);

/*! \brief [Immediate] Performs arithmetic addition on element values in the input tensor data.
 * \param [in] context The reference to the overall context.
 * \param [in] input1 Input tensor data.  Implementations must support input tensor data type <tt>\ref VX_TYPE_INT16</tt> with fixed_point_position 8,
 * and tensor data types <tt>\ref VX_TYPE_UINT8</tt> and <tt>\ref VX_TYPE_INT8</tt>, with fixed_point_position 0.  
 * \param [in] input2 Input tensor data. The dimensions and sizes of input2 match those of input1, unless the vx_tensor of one or more dimensions in input2 is 1.
 * In this case, those dimensions are treated as if this tensor was expanded to match the size of the corresponding dimension of input1,
 * and data was duplicated on all terms in that dimension. After this expansion, the dimensions will be equal. 
 * The data type must match the data type of Input1. 
 * \param [in] policy A <tt>\ref vx_convert_policy_e</tt> enumeration.
 * \param [out] output The output tensor data with the same dimensions as the input tensor data.
 * \ingroup group_vision_function_tensor_add
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuTensorAdd(vx_context context, vx_tensor input1, vx_tensor input2, vx_enum policy, vx_tensor output);

/*! \brief [Immediate] Performs arithmetic subtraction on element values in the input tensor data.
 * \param [in] context The reference to the overall context.
 * \param [in] input1 Input tensor data.  Implementations must support input tensor data type <tt>\ref VX_TYPE_INT16</tt> with fixed_point_position 8,
 * and tensor data types <tt>\ref VX_TYPE_UINT8</tt> and <tt>\ref VX_TYPE_INT8</tt>, with fixed_point_position 0.  
 * \param [in] input2 Input tensor data. The dimensions and sizes of input2 match those of input1, unless the vx_tensor of one or more dimensions in input2 is 1.
 * In this case, those dimensions are treated as if this tensor was expanded to match the size of the corresponding dimension of input1,
 * and data was duplicated on all terms in that dimension. After this expansion, the dimensions will be equal. 
 * The data type must match the data type of Input1. 
 * \param [in] policy A <tt>\ref vx_convert_policy_e</tt> enumeration.
 * \param [out] output The output tensor data with the same dimensions as the input tensor data.
 * \ingroup group_vision_function_tensor_subtract
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuTensorSubtract(vx_context context, vx_tensor input1, vx_tensor input2, vx_enum policy, vx_tensor output);

/*! \brief [Immediate] Performs LUT on element values in the input tensor data.
 * \param [in] context The reference to the overall context.
 * \param [in] input1 Input tensor data. Implementations must support input tensor data type <tt>\ref VX_TYPE_INT16</tt> with fixed_point_position 8, 
 * and tensor data types <tt>\ref VX_TYPE_UINT8</tt> and <tt>\ref VX_TYPE_INT8</tt>, with fixed_point_position 0. 
 * \param [in] lut The look-up table to use, of type <tt>\ref vx_lut</tt>.
 * The elements of input1 are treated as unsigned integers to determine an index into the look-up table.
 * The data type of the items in the look-up table must match that of the output tensor.
 * \param [out] output The output tensor data with the same dimensions as the input tensor data.
 * \ingroup group_vision_function_tensor_tablelookup
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuTensorTableLookup(vx_context context, vx_tensor input1, vx_lut lut, vx_tensor output);

/*! \brief [Immediate] Performs transpose on the input tensor.
 * The tensor is transposed according to a specified 2 indexes in the tensor (0-based indexing)
 * \param [in] context The reference to the overall context.
 * \param [in] input Input tensor data, Implementations must support input tensor data type <tt>\ref VX_TYPE_INT16</tt> with fixed_point_position 8,
 * and tensor data types <tt>\ref VX_TYPE_UINT8</tt> and <tt>\ref VX_TYPE_INT8</tt>, with fixed_point_position 0. 
 * \param [out] output output tensor data,
 * \param [in] dimension1 Dimension index that is transposed with dim 2.
 * \param [in] dimension2 Dimension index that is transposed with dim 1.
 * \ingroup group_vision_function_tensor_transpose
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuTensorTranspose(vx_context context, vx_tensor input, vx_tensor output, vx_size dimension1, vx_size dimension2);

/*! \brief [Immediate] Performs a bit-depth conversion.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input tensor. Implementations must support input tensor data type <tt>\ref VX_TYPE_INT16</tt> with fixed_point_position 8,
 * and tensor data types <tt>\ref VX_TYPE_UINT8</tt> and <tt>\ref VX_TYPE_INT8</tt>, with fixed_point_position 0.
 * \param [in] policy A <tt>\ref VX_TYPE_ENUM</tt> of the <tt>\ref vx_convert_policy_e</tt> enumeration.
 * \param [in] norm A scalar containing a <tt>\ref VX_TYPE_FLOAT32</tt> of the normalization value.
 * \param [in] offset A scalar containing a <tt>\ref VX_TYPE_FLOAT32</tt> of the offset value subtracted before normalization.
 * \param [out] output The output tensor. Implementations must support input tensor data type <tt>VX_TYPE_INT16</tt>. with fixed_point_position 8.
 * And <tt>VX_TYPE_UINT8</tt> with fixed_point_position 0.
 * \ingroup group_vision_function_tensor_convert_depth
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuTensorConvertDepth(vx_context context, vx_tensor input, vx_enum policy, vx_scalar norm, vx_scalar offset, vx_tensor output);

/*! \brief [Immediate] Performs a generalized matrix multiplication.
 * \param [in] context The reference to the overall context.
 * \param [in] input1 The first input 2D tensor of type <tt>\ref VX_TYPE_INT16</tt> with fixed_point_pos 8, or tensor data types <tt>\ref VX_TYPE_UINT8</tt> or <tt>\ref VX_TYPE_INT8</tt>, with fixed_point_pos 0.
 * \param [in] input2 The second 2D tensor. Must be in the same data type as input1.
 * \param [in] input3 The third 2D tensor. Must be in the same data type as input1. [optional].
 * \param [in] matrix_multiply_params Matrix multiply parameters, see <tt>\ref vx_matrix_multiply_params_t </tt>.
 * \param [out] output The output 2D tensor. Must be in the same data type as input1. Output dimension must agree the formula in the description.
 * \ingroup group_vision_function_tensor_matrix_multiply
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 */
VX_API_ENTRY vx_status VX_API_CALL vxuMatrixMultiply(vx_context context, vx_tensor input1, vx_tensor input2, vx_tensor input3,
    const vx_matrix_multiply_params_t *matrix_multiply_params, vx_tensor output);
					  

/*! \brief [Immediate] Copy data from one object to another.
 * \param [in] context The reference to the overall context.
 * \param [in] input The input data object.
 * \param [out] output The output data object.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Success
 * \retval * An error occurred. See <tt>\ref vx_status_e</tt>.
 * \ingroup group_vision_function_copy
 */
VX_API_ENTRY vx_status VX_API_CALL vxuCopy(vx_context context, vx_reference input, vx_reference output);

#ifdef __cplusplus
}
#endif

#endif