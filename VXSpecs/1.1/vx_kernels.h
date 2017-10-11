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

#ifndef _OPENVX_KERNELS_H_
#define _OPENVX_KERNELS_H_

/*!
 * \file
 * \brief The list of supported kernels in the OpenVX standard.
 */

#ifdef  __cplusplus
extern "C" {
#endif

/*!
 * \brief The standard list of available libraries
 * \ingroup group_kernel
 */
enum vx_library_e {
    /*! \brief The base set of kernels as defined by Khronos. */
    VX_LIBRARY_KHR_BASE = 0x0,
};

/*!
 * \brief The standard list of available vision kernels.
 *
 * Each kernel listed here can be used with the <tt>\ref vxGetKernelByEnum</tt> call.
 * When programming the parameters, use
 * \arg <tt>\ref VX_INPUT</tt> for [in]
 * \arg <tt>\ref VX_OUTPUT</tt> for [out]
 * \arg <tt>\ref VX_BIDIRECTIONAL</tt> for [in,out]
 *
 * When programming the parameters, use
 * \arg <tt>\ref VX_TYPE_IMAGE</tt> for a <tt>\ref vx_image</tt> in the size field of <tt>\ref vxGetParameterByIndex</tt> or <tt>\ref vxSetParameterByIndex</tt>  * \arg <tt>\ref VX_TYPE_ARRAY</tt> for a <tt>\ref vx_array</tt> in the size field of <tt>\ref vxGetParameterByIndex</tt> or <tt>\ref vxSetParameterByIndex</tt>  * \arg or other appropriate types in \ref vx_type_e.
 * \ingroup group_kernel
 */
enum vx_kernel_e {

    /*!
     * \brief The Color Space conversion kernel.
     * \details The conversions are based on the <tt>\ref vx_df_image_e</tt> code in the images.
     * \see group_vision_function_colorconvert
     */
    VX_KERNEL_COLOR_CONVERT = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x1,

    /*!
     * \brief The Generic Channel Extraction Kernel.
     * \details This kernel can remove individual color channels from an interleaved
     * or semi-planar, planar, sub-sampled planar image. A client could extract
     * a red channel from an interleaved RGB image or do a Luma extract from a
     * YUV format.
     * \see group_vision_function_channelextract
     */
    VX_KERNEL_CHANNEL_EXTRACT = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x2,

    /*!
     * \brief The Generic Channel Combine Kernel.
     * \details This kernel combine multiple individual planes into a single
     * multiplanar image of the type specified in the output image.
     * \see group_vision_function_channelcombine
     */
    VX_KERNEL_CHANNEL_COMBINE = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x3,

    /*! \brief The Sobel 3x3 Filter Kernel.
     * \see group_vision_function_sobel3x3
     */
    VX_KERNEL_SOBEL_3x3 = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x4,

    /*!
     * \brief The Magnitude Kernel.
     * \details This kernel produces a magnitude plane from two input gradients.
     * \see group_vision_function_magnitude
     */
    VX_KERNEL_MAGNITUDE = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x5,

    /*!
     * \brief The Phase Kernel.
     * \details This kernel produces a phase plane from two input gradients.
     * \see group_vision_function_phase
     */
    VX_KERNEL_PHASE = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x6,

    /*!
     * \brief The Scale Image Kernel.
     * \details This kernel provides resizing of an input image to an output image.
     * The scaling factor is determined but the relative sizes of the input and
     * output.
     * \see group_vision_function_scale_image
     */
    VX_KERNEL_SCALE_IMAGE = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x7,

    /*! \brief The Table Lookup kernel
     * \see group_vision_function_lut
     */
    VX_KERNEL_TABLE_LOOKUP = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x8,

    /*! \brief The Histogram Kernel.
     * \see group_vision_function_histogram
     */
    VX_KERNEL_HISTOGRAM = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x9,

    /*! \brief The Histogram Equalization Kernel.
     * \see group_vision_function_equalize_hist
     */
    VX_KERNEL_EQUALIZE_HISTOGRAM = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0xA,

    /*! \brief The Absolute Difference Kernel.
     * \see group_vision_function_absdiff
     */
    VX_KERNEL_ABSDIFF = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0xB,

    /*! \brief The Mean and Standard Deviation Kernel.
     * \see group_vision_function_meanstddev
     */
    VX_KERNEL_MEAN_STDDEV = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0xC,

    /*! \brief The Threshold Kernel.
     * \see group_vision_function_threshold
     */
    VX_KERNEL_THRESHOLD = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0xD,

    /*! \brief The Integral Image Kernel.
     * \see group_vision_function_integral_image
     */
    VX_KERNEL_INTEGRAL_IMAGE = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0xE,

    /*! \brief The dilate kernel.
     * \see group_vision_function_dilate_image
     */
    VX_KERNEL_DILATE_3x3 = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0xF,

    /*! \brief The erode kernel.
     * \see group_vision_function_erode_image
     */
    VX_KERNEL_ERODE_3x3 = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x10,

    /*! \brief The median image filter.
     * \see group_vision_function_median_image
     */
    VX_KERNEL_MEDIAN_3x3 = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x11,

    /*! \brief The box filter kernel.
     * \see group_vision_function_box_image
     */
    VX_KERNEL_BOX_3x3 = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x12,

    /*! \brief The gaussian filter kernel.
     * \see group_vision_function_gaussian_image
     */
    VX_KERNEL_GAUSSIAN_3x3 = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x13,

    /*! \brief The custom convolution kernel.
     * \see group_vision_function_custom_convolution
     */
    VX_KERNEL_CUSTOM_CONVOLUTION = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x14,

    /*! \brief The gaussian image pyramid kernel.
     * \see group_vision_function_gaussian_pyramid
     */
    VX_KERNEL_GAUSSIAN_PYRAMID = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x15,

    /*! \brief The accumulation kernel.
     * \see group_vision_function_accumulate
     */
    VX_KERNEL_ACCUMULATE = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x16,

    /*! \brief The weigthed accumulation kernel.
     * \see group_vision_function_accumulate_weighted
     */
    VX_KERNEL_ACCUMULATE_WEIGHTED = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x17,

    /*! \brief The squared accumulation kernel.
     * \see group_vision_function_accumulate_square
     */
    VX_KERNEL_ACCUMULATE_SQUARE = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x18,

    /*! \brief The min and max location kernel.
     * \see group_vision_function_minmaxloc
     */
    VX_KERNEL_MINMAXLOC = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x19,

    /*! \brief The bit-depth conversion kernel.
     * \see group_vision_function_convertdepth
     */
    VX_KERNEL_CONVERTDEPTH = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x1A,

    /*! \brief The Canny Edge Detector.
     * \see group_vision_function_canny
     */
    VX_KERNEL_CANNY_EDGE_DETECTOR = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x1B,

    /*! \brief The Bitwise And Kernel.
     * \see group_vision_function_and
     */
    VX_KERNEL_AND = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x1C,

    /*! \brief The Bitwise Inclusive Or Kernel.
     * \see group_vision_function_or
     */
    VX_KERNEL_OR = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x1D,

    /*! \brief The Bitwise Exclusive Or Kernel.
     * \see group_vision_function_xor
     */
    VX_KERNEL_XOR = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x1E,

    /*! \brief The Bitwise Not Kernel.
     * \see group_vision_function_not
     */
    VX_KERNEL_NOT = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x1F,

    /*! \brief The Pixelwise Multiplication Kernel.
     * \see group_vision_function_mult
     */
    VX_KERNEL_MULTIPLY = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x20,

    /*! \brief The Addition Kernel.
     * \see group_vision_function_add
     */
    VX_KERNEL_ADD = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x21,

    /*! \brief The Subtraction Kernel.
     * \see group_vision_function_sub
     */
    VX_KERNEL_SUBTRACT = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x22,

    /*! \brief The Warp Affine Kernel.
     * \see group_vision_function_warp_affine
     */
    VX_KERNEL_WARP_AFFINE = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x23,

    /*! \brief The Warp Perspective Kernel.
     * \see group_vision_function_warp_perspective
     */
    VX_KERNEL_WARP_PERSPECTIVE = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x24,

    /*! \brief The Harris Corners Kernel.
     * \see group_vision_function_harris
     */
    VX_KERNEL_HARRIS_CORNERS = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x25,

    /*! \brief The FAST Corners Kernel.
     * \see group_vision_function_fast
     */
    VX_KERNEL_FAST_CORNERS = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x26,

    /*! \brief The Optical Flow Pyramid (LK) Kernel.
     * \see group_vision_function_opticalflowpyrlk
     */
    VX_KERNEL_OPTICAL_FLOW_PYR_LK = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x27,

    /*! \brief The Remap Kernel.
     * \see group_vision_function_remap
     */
    VX_KERNEL_REMAP = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x28,

    /*! \brief The Half Scale Gaussian Kernel.
     * \see group_vision_function_scale_image
     */
    VX_KERNEL_HALFSCALE_GAUSSIAN = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x29,

    /* kernel added in OpenVX 1.1 */

    /*! \brief The Laplacian Image Pyramid Kernel.
    * \see group_vision_function_laplacian_pyramid
    */
    VX_KERNEL_LAPLACIAN_PYRAMID = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x2A,

    /*! \brief The Laplacian Pyramid Reconstruct Kernel.
    * \see group_vision_function_laplacian_pyramid
    */
    VX_KERNEL_LAPLACIAN_RECONSTRUCT = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x2B,

    /*! \brief The Non Linear Filter Kernel.
    * \see group_vision_function_nonlinear_filter
    */
    VX_KERNEL_NON_LINEAR_FILTER = VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x2C,

    /* insert new kernels here */
    VX_KERNEL_MAX_1_0, /*!< \internal Used for bounds checking in the conformance test. */
};

#ifdef  __cplusplus
}
#endif

#endif  /* _OPEN_VISION_LIBRARY_KERNELS_H_ */
