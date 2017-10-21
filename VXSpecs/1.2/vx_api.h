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

#ifndef _OPENVX_API_H_
#define _OPENVX_API_H_

/*!
 * \file
 * \brief The API definition for OpenVX.
 */

#ifdef  __cplusplus
extern "C" {
#endif

/*==============================================================================
 CONTEXT
 =============================================================================*/

/*! \brief Creates a <tt>\ref vx_context</tt>.
 * \details This creates a top-level object context for OpenVX.
 * \note This is required to do anything else.
 * \returns The reference to the implementation context <tt>\ref vx_context</tt>. Any possible errors
 * preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_context
 * \post <tt>\ref vxReleaseContext</tt>
 */
VX_API_ENTRY vx_context VX_API_CALL vxCreateContext();

/*! \brief Releases the OpenVX object context.
 * \details All reference counted objects are garbage-collected by the return of this call.
 * No calls are possible using the parameter context after the context has been
 * released until a new reference from <tt>\ref vxCreateContext</tt> is returned.
 * All outstanding references to OpenVX objects from this context are invalid
 * after this call.
 * \param [in] context The pointer to the reference to the context.
 * \post After returning from this function the reference is zeroed.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE context is not a valid <tt>\ref vx_context</tt> reference.
 * \ingroup group_context
 * \pre <tt>\ref vxCreateContext</tt>
 */
VX_API_ENTRY vx_status VX_API_CALL vxReleaseContext(vx_context *context);

/*! \brief Retrieves the context from any reference from within a context.
 * \param [in] reference The reference from which to extract the context.
 * \ingroup group_context
 * \return The overall context that created the particular
 * reference. Any possible errors preventing a successful completion of this function
 * should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_context VX_API_CALL vxGetContext(vx_reference reference);

/*! \brief Queries the context for some specific information.
 * \param [in] context The reference to the context.
 * \param [in] attribute The attribute to query. Use a <tt>\ref vx_context_attribute_e</tt>.
 * \param [out] ptr The location at which to store the resulting value.
 * \param [in] size The size in bytes of the container to which \a ptr points.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE context is not a valid <tt>\ref vx_context</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS If any of the other parameters are incorrect.
 * \retval VX_ERROR_NOT_SUPPORTED If the attribute is not supported on this implementation.
 * \ingroup group_context
 */
VX_API_ENTRY vx_status VX_API_CALL vxQueryContext(vx_context context, vx_context_attribute_e attribute, void *ptr, vx_size size);

/*! \brief Sets an attribute on the context.
 * \param [in] context The handle to the overall context.
 * \param [in] attribute The attribute to set from <tt>\ref vx_context_attribute_e</tt>.
 * \param [in] ptr The pointer to the data to which to set the attribute.
 * \param [in] size The size in bytes of the data to which \a ptr points.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE context is not a valid <tt>\ref vx_context</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS If any of the other parameters are incorrect.
 * \retval VX_ERROR_NOT_SUPPORTED If the attribute is not settable.
 * \ingroup group_context
 */
VX_API_ENTRY vx_status VX_API_CALL vxSetContextAttribute(vx_context context, vx_context_attribute_e attribute, const void *ptr, vx_size size);

/*! \brief Provides a generic API to give platform-specific hints to the implementation.
 * \param [in] reference The reference to the object to hint at.
 * This could be <tt>\ref vx_context</tt>, <tt>\ref vx_graph</tt>, <tt>\ref vx_node</tt>, <tt>\ref vx_image</tt>, <tt>\ref vx_array</tt>, or any other reference.
 * \param [in] hint A <tt>\ref vx_hint_e</tt> \a hint to give to a \ref vx_context. This is a platform-specific optimization or implementation mechanism.
 * \param [in] data Optional vendor specific data.
 * \param [in] data_size Size of the data structure \p data.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE reference is not a valid <tt>\ref vx_reference</tt> reference.
 * \retval VX_ERROR_NOT_SUPPORTED If the hint is not supported.
 * \ingroup group_hint
 */
VX_API_ENTRY vx_status VX_API_CALL vxHint(vx_reference reference, vx_hint_e hint, const void* data, vx_size data_size);

/*! \brief Provides a generic API to give platform-specific directives to the implementations.
 * \param [in] reference The reference to the object to set the directive on.
 * This could be <tt>\ref vx_context</tt>, <tt>\ref vx_graph</tt>, <tt>\ref vx_node</tt>, <tt>\ref vx_image</tt>, <tt>\ref vx_array</tt>, or any other reference.
 * \param [in] directive The directive to set. See <tt>\ref vx_directive_e</tt>.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE reference is not a valid <tt>\ref vx_reference</tt> reference.
 * \retval VX_ERROR_NOT_SUPPORTED If the directive is not supported.
 * \note The performance counter directives are only available for the reference \ref vx_context.
 *       Error VX_ERROR_NOT_SUPPORTED is returned when used with any other reference.
 * \ingroup group_directive
 */
VX_API_ENTRY vx_status VX_API_CALL vxDirective(vx_reference reference, vx_directive_e directive);

/*! \brief Provides a generic API to return status values from Object constructors if they
 * fail.
 * \note Users do not need to strictly check every object creator as the errors
 * should properly propagate and be detected during verification time or run-time.
 * \code
 * vx_image img = vxCreateImage(context, 639, 480, VX_DF_IMAGE_UYVY);
 * vx_status status = vxGetStatus((vx_reference)img);
 * // status == VX_ERROR_INVALID_DIMENSIONS
 * vxReleaseImage(&img);
 * \endcode
 * \pre Appropriate Object Creator function.
 * \post Appropriate Object Release function.
 * \param [in] reference The reference to check for construction errors.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval * Some error occurred, please check enumeration list and constructor.
 * \ingroup group_basic_features
 */
VX_API_ENTRY vx_status VX_API_CALL vxGetStatus(vx_reference reference);

/*!
 * \brief Registers user-defined structures to the context.
 * \param [in] context  The reference to the implementation context.
 * \param [in] size     The size of user struct in bytes.
 * \return A <tt>\ref vx_enum</tt> value that is a type given to the User
 * to refer to their custom structure when declaring a <tt>\ref vx_array</tt>
 * of that structure.
 * \retval VX_TYPE_INVALID If the namespace of types has been exhausted.
 * \note This call should only be used once within the lifetime of a context for
 * a specific structure.
 * \ingroup group_adv_array
 */
VX_API_ENTRY vx_type_e VX_API_CALL vxRegisterUserStruct(vx_context context, vx_size size);

/*!
 * \brief Allocates and registers user-defined kernel enumeration to a context.
 * The allocated enumeration is from available pool of 4096 enumerations reserved
 * for dynamic allocation from VX_KERNEL_BASE(VX_ID_USER,0).
 * \param [in] context  The reference to the implementation context.
 * \param [out] pKernelEnumId  pointer to return <tt>\ref vx_enum</tt> for user-defined kernel.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE If the context is not a valid <tt>\ref vx_context</tt> reference.
 * \retval VX_ERROR_NO_RESOURCES The enumerations has been exhausted.
 * \ingroup group_user_kernels
 */
VX_API_ENTRY vx_status VX_API_CALL vxAllocateUserKernelId(vx_context context, vx_type_e * pKernelEnumId);

/*!
 * \brief Allocates and registers user-defined kernel library ID to a context.
 *
 * The allocated library ID is from available pool of library IDs (1..255)
 * reserved for dynamic allocation. The returned libraryId can be used by
 * user-kernel library developer to specify individual kernel enum IDs in
 * a header file, shown below:
 * \code
 * #define MY_KERNEL_ID1(libraryId) (VX_KERNEL_BASE(VX_ID_USER,libraryId) + 0);
 * #define MY_KERNEL_ID2(libraryId) (VX_KERNEL_BASE(VX_ID_USER,libraryId) + 1);
 * #define MY_KERNEL_ID3(libraryId) (VX_KERNEL_BASE(VX_ID_USER,libraryId) + 2);
 * \endcode
 * \param [in] context  The reference to the implementation context.
 * \param [out] pLibraryId  pointer to <tt>\ref vx_enum</tt> for user-kernel libraryId.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_NO_RESOURCES The enumerations has been exhausted.
 * \ingroup group_user_kernels
 */
VX_API_ENTRY vx_status VX_API_CALL vxAllocateUserKernelLibraryId(vx_context context, vx_enum * pLibraryId);

/*! \brief Sets the default target of the immediate mode. Upon successful execution of this
 * function any future execution of immediate mode function is attempted on the new default
 * target of the context.
 * \param [in] context  The reference to the implementation context.
 * \param [in] target_enum  The default immediate mode target enum to be set
 * to the <tt>\ref vx_context</tt> object. Use a <tt>\ref vx_target_e</tt>.
 * \param [in] target_string  The target name ASCII string. This contains a valid value
 * when target_enum is set to <tt>\ref VX_TARGET_STRING</tt>, otherwise it is ignored.
 * \ingroup group_context
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Default target set; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE If the context is not a valid <tt>\ref vx_context</tt> reference.
 * \retval VX_ERROR_NOT_SUPPORTED If the specified target is not supported in this context.
 */
VX_API_ENTRY vx_status VX_API_CALL vxSetImmediateModeTarget(vx_context context, vx_target_e target_enum, const char* target_string);

/*==============================================================================
 IMAGE
 =============================================================================*/

/*! \brief Creates an opaque reference to an image buffer.
 * \details Not guaranteed to exist until the <tt>\ref vx_graph</tt> containing it has been verified.
 * \param [in] context The reference to the implementation context.
 * \param [in] width The image width in pixels. The image in the formats of
 * <tt>\ref VX_DF_IMAGE_NV12</tt>, <tt>\ref VX_DF_IMAGE_NV21</tt>, <tt>\ref VX_DF_IMAGE_IYUV</tt>,
 * <tt>\ref VX_DF_IMAGE_UYVY</tt>, <tt>\ref VX_DF_IMAGE_YUYV</tt> must have even width.
 * \param [in] height The image height in pixels. The image in the formats of
 * <tt>\ref VX_DF_IMAGE_NV12</tt>, <tt>\ref VX_DF_IMAGE_NV21</tt>, <tt>\ref VX_DF_IMAGE_IYUV</tt>
 * must have even height.
 * \param [in] color The VX_DF_IMAGE (<tt>\ref vx_df_image_e</tt>) code that represents the format
 * of the image and the color space.
 * \returns An image reference <tt>\ref vx_image</tt>. Any possible errors preventing a successful
 * creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \see vxMapImagePatch to obtain direct memory access to the image data.
 * \ingroup group_image
 */
VX_API_ENTRY vx_image VX_API_CALL vxCreateImage(vx_context context, vx_uint32 width, vx_uint32 height, vx_df_image color);

/*! \brief Creates an image from another image given a rectangle. This second
 * reference refers to the data in the original image. Updates to this image
 * updates the parent image. The rectangle must be defined within the pixel space
 * of the parent image.
 * \param [in] img The reference to the parent image.
 * \param [in] rect The region of interest rectangle. Must contain points within
 * the parent image pixel space.
 * \returns An image reference <tt>\ref vx_image</tt> to the sub-image. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_image
 */
VX_API_ENTRY vx_image VX_API_CALL vxCreateImageFromROI(vx_image img, const vx_rectangle_t *rect);

/*! \brief Creates a reference to an image object that has a singular,
 * uniform value in all pixels. The uniform image created is read-only.
 * \param [in] context The reference to the implementation context.
 * \param [in] width The image width in pixels. The image in the formats of
 * <tt>\ref VX_DF_IMAGE_NV12</tt>, <tt>\ref VX_DF_IMAGE_NV21</tt>, <tt>\ref VX_DF_IMAGE_IYUV</tt>,
 * <tt>\ref VX_DF_IMAGE_UYVY</tt>, <tt>\ref VX_DF_IMAGE_YUYV</tt> must have even width.
 * \param [in] height The image height in pixels. The image in the formats of
 * <tt>\ref VX_DF_IMAGE_NV12</tt>, <tt>\ref VX_DF_IMAGE_NV21</tt>,
 * <tt>\ref VX_DF_IMAGE_IYUV</tt> must have even height.
 * \param [in] color The VX_DF_IMAGE (\ref vx_df_image_e) code that represents the format of the image and the color space.
 * \param [in] value The pointer to the pixel value to which to set all pixels. See <tt>\ref vx_pixel_value_t</tt>.
 * \returns An image reference <tt>\ref vx_image</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * <tt>\see vxMapImagePatch</tt> to obtain direct memory access to the image data.
 * \note <tt>\ref vxMapImagePatch</tt> and <tt>\ref vxUnmapImagePatch</tt> may be called with
 * a uniform image reference.
 * \ingroup group_image
 */
VX_API_ENTRY vx_image VX_API_CALL vxCreateUniformImage(vx_context context, vx_uint32 width, vx_uint32 height, vx_df_image color, const vx_pixel_value_t *value);

/*! \brief Creates an opaque reference to an image buffer with no direct
 * user access. This function allows setting the image width, height, or format.
 * \details Virtual data objects allow users to connect various nodes within a
 * graph via data references without access to that data, but they also permit the
 * implementation to take maximum advantage of possible optimizations. Use this
 * API to create a data reference to link two or more nodes together when the
 * intermediate data are not required to be accessed by outside entities. This API
 * in particular allows the user to define the image format of the data without
 * requiring the exact dimensions. Virtual objects are scoped within the graph
 * they are declared a part of, and can't be shared outside of this scope.
 * All of the following constructions of virtual images are valid.
 * \code
 * vx_context context = vxCreateContext();
 * vx_graph graph = vxCreateGraph(context);
 * vx_image virt[] = {
 *     vxCreateVirtualImage(graph, 0, 0, VX_DF_IMAGE_U8), // no specified dimension
 *     vxCreateVirtualImage(graph, 320, 240, VX_DF_IMAGE_VIRT), // no specified format
 *     vxCreateVirtualImage(graph, 640, 480, VX_DF_IMAGE_U8), // no user access
 * };
 * \endcode
 * \param [in] graph The reference to the parent graph.
 * \param [in] width The width of the image in pixels. A value of zero informs the interface
 * that the value is unspecified. The image in the formats of <tt>\ref VX_DF_IMAGE_NV12</tt>,
 * <tt>\ref VX_DF_IMAGE_NV21</tt>, <tt>\ref VX_DF_IMAGE_IYUV</tt>, <tt>\ref VX_DF_IMAGE_UYVY</tt>,
 * <tt>\ref VX_DF_IMAGE_YUYV</tt> must have even width.
 * \param [in] height The height of the image in pixels. A value of zero informs the interface
 * that the value is unspecified. The image in the formats of <tt>\ref VX_DF_IMAGE_NV12</tt>,
 * <tt>\ref VX_DF_IMAGE_NV21</tt>, <tt>\ref VX_DF_IMAGE_IYUV</tt> must have even height.
 * \param [in] color The VX_DF_IMAGE (<tt>\ref vx_df_image_e</tt>) code that represents the format
 * of the image and the color space. A value of <tt>\ref VX_DF_IMAGE_VIRT</tt> informs the
 * interface that the format is unspecified.
 * \returns An image reference <tt>\ref vx_image</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \note Passing this reference to <tt>\ref vxMapImagePatch</tt> will return an error.
 * \ingroup group_image
 */
VX_API_ENTRY vx_image VX_API_CALL vxCreateVirtualImage(vx_graph graph, vx_uint32 width, vx_uint32 height, vx_df_image color);

/*! \brief Creates a reference to an image object that was externally allocated.
 * \param [in] context The reference to the implementation context.
 * \param [in] color See the <tt>\ref vx_df_image_e</tt> codes. This mandates the
 * number of planes needed to be valid in the \a addrs and \a ptrs arrays based on the format given.
 * \param [in] addrs[] The array of image patch addressing structures that
 * define the dimension and stride of the array of pointers. See note below.
 * \param [in] ptrs[] The array of platform-defined references to each plane. See note below.
 * \param [in] memory_type <tt>\ref vx_memory_type_e</tt>. When giving <tt>\ref VX_MEMORY_TYPE_HOST</tt>
 * the \a ptrs array is assumed to be HOST accessible pointers to memory.
 * \returns An image reference <tt>\ref vx_image</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \note The user must call vxMapImagePatch prior to accessing the pixels of an image, even if the
 * image was created via <tt>\ref vxCreateImageFromHandle</tt>. Reads or writes to memory referenced
 * by ptrs[ ] after calling <tt>\ref vxCreateImageFromHandle</tt> without first calling
 * <tt>\ref vxMapImagePatch</tt> will result in undefined behavior.
 * The property of addr[] and ptrs[] arrays is kept by the caller (It means that the implementation will
 * make an internal copy of the provided information. \a addr and \a ptrs can then simply be application's
 * local variables).
 * Only \a dim_x, \a dim_y, \a stride_x and \a stride_y fields of the <tt>\ref vx_imagepatch_addressing_t</tt> need to be
 * provided by the application. Other fields (\a step_x, \a step_y, \a scale_x & \a scale_y) are ignored by this function.
 * The layout of the imported memory must follow a row-major order. In other words, \a stride_x should be
 * sufficiently large so that there is no overlap between data elements corresponding to different
 * pixels, and \a stride_y >= \a stride_x * \a dim_x.
 *
 * In order to release the image back to the application we should use <tt>\ref vxSwapImageHandle</tt>.
 *
 * Import type of the created image is available via the image attribute <tt>\ref vx_image_attribute_e</tt> parameter.
 *
 * \ingroup group_image
 */
VX_API_ENTRY vx_image VX_API_CALL vxCreateImageFromHandle(vx_context context, vx_df_image color, const vx_imagepatch_addressing_t addrs[], void *const ptrs[], vx_memory_type_e memory_type);

/*! \brief Swaps the image handle of an image previously created from handle.
 *
 * This function sets the new image handle (i.e. pointer to all image planes)
 * and returns the previous one.
 *
 * Once this function call has completed, the application gets back the
 * ownership of the memory referenced by the previous handle. This memory
 * contains up-to-date pixel data, and the application can safely reuse or
 * release it.
 *
 * The memory referenced by the new handle must have been allocated
 * consistently with the image properties since the import type,
 * memory layout and dimensions are unchanged (see addrs, color, and
 * memory_type in <tt>\ref vxCreateImageFromHandle</tt>).
 *
 * All images created from ROI or channel with this image as parent or ancestor
 * will automatically use the memory referenced by the new handle.
 *
 * The behavior of <tt>\ref vxSwapImageHandle</tt> when called from a user node is undefined.
 * \param [in] image The reference to an image created from handle
 * \param [in] new_ptrs[] pointer to a caller owned array that contains
 * the new image handle (image plane pointers)
 * \arg new_ptrs is non NULL. new_ptrs[i] must be non NULL for each i such as
 * 0 < i < nbPlanes, otherwise, this is an error. The address of the storage memory
 * for image plane i is set to new_ptrs[i]
 * \arg new_ptrs is NULL: the previous image storage memory is reclaimed by the
 * caller, while no new handle is provided.
 * \param [out] prev_ptrs[] pointer to a caller owned array in which
 * the application returns the previous image handle
 * \arg prev_ptrs is non NULL. prev_ptrs must have at least as many
 * elements as the number of image planes. For each i such as
 * 0 < i < nbPlanes , prev_ptrs[i] is set to the address of the previous storage
 * memory for plane i.
 * \arg prev_ptrs NULL: the previous handle is not returned.
 * \param [in] num_planes Number of planes in the image. This must be set equal to the number of planes of the input image.
 *  The number of elements in new_ptrs and prev_ptrs arrays must be equal to or greater than num_planes.
 * If either array has more than num_planes elements, the extra elements are ignored. If either array is smaller
 * than num_planes, the results are undefined.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors.
 * \retval VX_ERROR_INVALID_REFERENCE image is not a valid <tt>\ref vx_image</tt> reference.
 * reference.
 * \retval VX_ERROR_INVALID_PARAMETERS The image was not created from handle or
 * the content of new_ptrs is not valid.
 * \retval VX_FAILURE The image was already being accessed.
 * \ingroup group_image
 */

VX_API_ENTRY vx_status VX_API_CALL vxSwapImageHandle(vx_image image, void* const new_ptrs[], void* prev_ptrs[], vx_size num_planes);

/*! \brief Retrieves various attributes of an image.
 * \param [in] image The reference to the image to query.
 * \param [in] attribute The attribute to query. Use a <tt>\ref vx_image_attribute_e</tt>.
 * \param [out] ptr The location at which to store the resulting value.
 * \param [in] size The size in bytes of the container to which \a ptr points.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE image is not a valid <tt>\ref vx_image</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS If any of the other parameters are incorrect.
 * \retval VX_ERROR_NOT_SUPPORTED If the attribute is not supported on this implementation.
 * \ingroup group_image
 */
VX_API_ENTRY vx_status VX_API_CALL vxQueryImage(vx_image image, vx_image_attribute_e attribute, void *ptr, vx_size size);

/*! \brief Allows setting attributes on the image.
 * \param [in] image The reference to the image on which to set the attribute.
 * \param [in] attribute The attribute to set. Use a <tt>\ref vx_image_attribute_e</tt> enumeration.
 * \param [in] ptr The pointer to the location from which to read the value.
 * \param [in] size The size in bytes of the object pointed to by \a ptr.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE image is not a valid <tt>\ref vx_image</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS If any of the other parameters are incorrect.
 * \ingroup group_image
 */
VX_API_ENTRY vx_status VX_API_CALL vxSetImageAttribute(vx_image image, vx_image_attribute_e attribute, const void *ptr, vx_size size);

/*! \brief Initialize an image with constant pixel value.
 * \param [in] image The reference to the image to initialize.
 * \param [in] pixel_value The pointer to the constant pixel value to initialize all image pixels. See <tt>\ref vx_pixel_value_t</tt>.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors.
 * \retval VX_ERROR_INVALID_REFERENCE If the image is a uniform image, a virtual image, or not a <tt>\ref vx_image</tt>.
 * \retval VX_ERROR_INVALID_PARAMETERS If any of the other parameters are incorrect.
 * \note All pixels of the entire image are initialized to the indicated pixel value, independently from the valid region. The valid region of the image is unaffected by this function. The image remains mutable after the call to this function, so its pixels and mutable attributes may be changed by subsequent functions.
 * \ingroup group_image
 */
VX_API_ENTRY vx_status VX_API_CALL vxSetImagePixelValues(vx_image image, const vx_pixel_value_t *pixel_value);

/*! \brief Releases a reference to an image object.
 * The object may not be garbage collected until its total reference count is zero.
 *
 * An implementation may defer the actual object destruction after its total
 * reference count is zero (potentially until context destruction). Thus,
 * releasing an image created from handle
 * (see <tt>\ref vxCreateImageFromHandle</tt>) and all others objects that may
 * reference it (nodes, ROI, or channel for instance) are not sufficient to get back the
 * ownership of the memory referenced by the current image handle. The only way
 * for this is to call <tt>\ref vxSwapImageHandle</tt>) before releasing the
 * image.
 *
 * \param [in] image The pointer to the image to release.
 * \post After returning from this function the reference is zeroed.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE image is not a valid <tt>\ref vx_image</tt> reference.
 * \ingroup group_image
 */
VX_API_ENTRY vx_status VX_API_CALL vxReleaseImage(vx_image *image);

/*!
 * \brief Accesses a specific indexed pixel in an image patch.
 * \param [in] ptr The base pointer of the patch as returned from <tt>\ref vxMapImagePatch</tt>.
 * \param [in] index The 0 based index of the pixel count in the patch. Indexes increase horizontally by 1 then wrap around to the next row.
 * \param [in] addr The pointer to the addressing mode information returned from <tt>\ref vxMapImagePatch</tt>.
 * \return void * Returns the pointer to the specified pixel.
 * \pre <tt>\ref vxMapImagePatch</tt>
 * \ingroup group_image
 */
VX_API_ENTRY void * VX_API_CALL vxFormatImagePatchAddress1d(void *ptr, vx_uint32 index, const vx_imagepatch_addressing_t *addr);

/*!
 * \brief Accesses a specific pixel at a 2d coordinate in an image patch.
 * \param [in] ptr The base pointer of the patch as returned from <tt>\ref vxMapImagePatch</tt>.
 * \param [in] x The x dimension within the patch.
 * \param [in] y The y dimension within the patch.
 * \param [in] addr The pointer to the addressing mode information returned from <tt>\ref vxMapImagePatch</tt>.
 * \return void * Returns the pointer to the specified pixel.
 * \pre <tt>\ref vxMapImagePatch</tt>
 * \ingroup group_image
 */
VX_API_ENTRY void * VX_API_CALL vxFormatImagePatchAddress2d(void *ptr, vx_uint32 x, vx_uint32 y, const vx_imagepatch_addressing_t *addr);

/*! \brief Retrieves the valid region of the image as a rectangle.
 * \param [in] image The image from which to retrieve the valid region.
 * \param [out] rect The destination rectangle.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE image is not a valid <tt>\ref vx_image</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS Invalid rect.
 * \note This rectangle can be passed directly to <tt>\ref vxMapImagePatch</tt> to get
 * the full valid region of the image.
 * \ingroup group_image
 */
VX_API_ENTRY vx_status VX_API_CALL vxGetValidRegionImage(vx_image image, vx_rectangle_t *rect);

/*! \brief Allows the application to copy a rectangular patch from/into an image object plane.
 * \param [in] image The reference to the image object that is the source or the
 * destination of the copy.
 * \param [in] image_rect The coordinates of the image patch. The patch must be within
 * the bounds of the image. (start_x, start_y) gives the coordinates of the topleft
 * pixel inside the patch, while (end_x, end_y) gives the coordinates of the bottomright
 * element out of the patch. Must be 0 <= start < end <= number of pixels in the image dimension.
 * \param [in] image_plane_index The plane index of the image object that is the source or the
 * destination of the patch copy.
 * \param [in] user_addr The address of a structure describing the layout of the
 * user memory location pointed by user_ptr. In the structure, only dim_x, dim_y,
 * stride_x and stride_y fields must be provided, other fields are ignored by the function.
 * The layout of the user memory must follow a row major order:
 * stride_x >= pixel size in bytes, and stride_y >= stride_x * dim_x.
 * \param [in] user_ptr The address of the memory location where to store the requested data
 * if the copy was requested in read mode, or from where to get the data to store into the image
 * object if the copy was requested in write mode. The accessible memory must be large enough
 * to contain the specified patch with the specified layout:
 * accessible memory in bytes >= (end_y - start_y) * stride_y.
 * \param [in] usage This declares the effect of the copy with regard to the image object
 * using the <tt>\ref vx_accessor_e</tt> enumeration. For uniform images, only VX_READ_ONLY
 * is supported. For other images, Only <tt>\ref VX_READ_ONLY</tt> and <tt>\ref VX_WRITE_ONLY</tt> are supported:
 * \arg <tt>\ref VX_READ_ONLY</tt> means that data is copied from the image object into the application memory
 * \arg <tt>\ref VX_WRITE_ONLY</tt> means that data is copied into the image object from the application memory
 * \param [in] user_mem_type A <tt>\ref vx_memory_type_e</tt> enumeration that specifies
 * the memory type of the memory referenced by the user_addr.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_OPTIMIZED_AWAY This is a reference to a virtual image that cannot be
 * accessed by the application.
 * \retval VX_ERROR_INVALID_REFERENCE image is not a valid <tt>\ref vx_image</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 * \note The application may ask for data outside the bounds of the valid region, but
 * such data has an undefined value.
 * \ingroup group_image
 */
VX_API_ENTRY vx_status VX_API_CALL vxCopyImagePatch(vx_image image, const vx_rectangle_t *image_rect, vx_uint32 image_plane_index, const vx_imagepatch_addressing_t *user_addr, void * user_ptr, vx_accessor_e usage, vx_memory_type_e user_mem_type);


/*! \brief Allows the application to get direct access to a rectangular patch of an image object plane.
 * \param [in] image The reference to the image object that contains the patch to map.
 * \param [in] rect The coordinates of image patch. The patch must be within the
 * bounds of the image. (start_x, start_y) gives the coordinate of the topleft
 * element inside the patch, while (end_x, end_y) give the coordinate of
 * the bottomright element out of the patch. Must be 0 <= start < end.
 * \param [in] plane_index The plane index of the image object to be accessed.
 * \param [out] map_id The address of a <tt>\ref vx_map_id</tt> variable where the function
 * returns a map identifier.
 * \arg (*map_id) must eventually be provided as the map_id parameter of a call to
 * <tt>\ref vxUnmapImagePatch</tt>.
 * \param [out] addr The address of a structure describing the memory layout of the
 * image patch to access. The function fills the structure pointed by addr with the
 * layout information that the application must consult to access the pixel data
 * at address (*ptr). The layout of the mapped memory follows a row-major order:
 * stride_x>0, stride_y>0 and stride_y >= stride_x * dim_x.
 * If the image object being accessed was created via
 * <tt>\ref vxCreateImageFromHandle</tt>, then the returned memory layout will be
 * the identical to that of the addressing structure provided when
 * <tt>\ref vxCreateImageFromHandle</tt> was called.
 * \param [out] ptr The address of a pointer that the function sets to the
 * address where the requested data can be accessed. This returned (*ptr) address
 * is only valid between the call to this function and the corresponding call to
 * <tt>\ref vxUnmapImagePatch</tt>.
 * If image was created via <tt>\ref vxCreateImageFromHandle</tt> then the returned
 * address (*ptr) will be the address of the patch in the original pixel buffer
 * provided when image was created.
 * \param [in] usage This declares the access mode for the image patch, using
 * the <tt>\ref vx_accessor_e</tt> enumeration. For uniform images, only VX_READ_ONLY
 * is supported.
 * \arg <tt>\ref VX_READ_ONLY</tt>: after the function call, the content of the memory location
 * pointed by (*ptr) contains the image patch data. Writing into this memory location
 * is forbidden and its behavior is undefined.
 * \arg <tt>\ref VX_READ_AND_WRITE</tt>: after the function call, the content of the memory
 * location pointed by (*ptr) contains the image patch data; writing into this memory
 * is allowed only for the location of pixels only and will result in a modification
 * of the written pixels in the image object once the patch is unmapped. Writing into
 * a gap between pixels (when addr->stride_x > pixel size in bytes or addr->stride_y > addr->stride_x*addr->dim_x)
 * is forbidden and its behavior is undefined.
 * \arg <tt>\ref VX_WRITE_ONLY</tt>: after the function call, the memory location pointed by (*ptr)
 * contains undefined data; writing each pixel of the patch is required prior to
 * unmapping. Pixels not written by the application before unmap will become
 * undefined after unmap, even if they were well defined before map. Like for
 * VX_READ_AND_WRITE, writing into a gap between pixels is forbidden and its behavior
 * is undefined.
 * \param [in] mem_type A <tt>\ref vx_memory_type_e</tt> enumeration that
 * specifies the type of the memory where the image patch is requested to be mapped.
 * \param [in] flags An integer that allows passing options to the map operation.
 * Use the <tt>\ref vx_map_flag_e</tt> enumeration.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_OPTIMIZED_AWAY This is a reference to a virtual image that cannot be
 * accessed by the application.
 * \retval VX_ERROR_INVALID_REFERENCE image is not a valid <tt>\ref vx_image</tt> reference.
 * reference.
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 * \note The user may ask for data outside the bounds of the valid region, but
 * such data has an undefined value.
 * \ingroup group_image
 * \post <tt>\ref vxUnmapImagePatch </tt> with same (*map_id) value.
 */
VX_API_ENTRY vx_status VX_API_CALL vxMapImagePatch(vx_image image, const vx_rectangle_t *rect, vx_uint32 plane_index, vx_map_id *map_id, vx_imagepatch_addressing_t *addr, void **ptr, vx_accessor_e usage, vx_memory_type_e mem_type, vx_map_flag_e flags);


/*! \brief Unmap and commit potential changes to a image object patch that were previously mapped.
 * Unmapping an image patch invalidates the memory location from which the patch could
 * be accessed by the application. Accessing this memory location after the unmap function
 * completes has an undefined behavior.
 * \param [in] image The reference to the image object to unmap.
 * \param [out] map_id The unique map identifier that was returned by <tt>\ref vxMapImagePatch</tt> .
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE image is not a valid <tt>\ref vx_image</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 * \ingroup group_image
 * \pre <tt>\ref vxMapImagePatch</tt> with same map_id value
 */
VX_API_ENTRY vx_status VX_API_CALL vxUnmapImagePatch(vx_image image, vx_map_id map_id);

/*! \brief Create a sub-image from a single plane channel of another image.
 *
 * The sub-image refers to the data in the original image. Updates to this image
 * update the parent image and reversely.
 *
 * The function supports only channels that occupy an entire plane of a multi-planar
 * images, as listed below. Other cases are not supported.
 *     VX_CHANNEL_Y from YUV4, IYUV, NV12, NV21
 *     VX_CHANNEL_U from YUV4, IYUV
 *     VX_CHANNEL_V from YUV4, IYUV
 *
 * \param [in] img          The reference to the parent image.
 * \param [in] channel      The <tt>\ref vx_channel_e</tt> channel to use.

 * \returns An image reference <tt>\ref vx_image</tt> to the sub-image. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_image
 */
VX_API_ENTRY vx_image VX_API_CALL vxCreateImageFromChannel(vx_image img, vx_channel_e channel);


/*! \brief Sets the valid rectangle for an image according to a supplied rectangle.
 * \note Setting or changing the valid region from within a user node by means other than the call-back, for
 * example by calling <tt>\ref vxSetImageValidRectangle</tt>, might result in an incorrect valid region calculation
 * by the framework.
 * \param [in] image  The reference to the image.
 * \param [in] rect   The value to be set to the image valid rectangle. A NULL indicates that the valid region is the entire image.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE image is not a valid <tt>\ref vx_image</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS The rect does not define a proper valid rectangle.
 * \ingroup group_image
 */
VX_API_ENTRY vx_status VX_API_CALL vxSetImageValidRectangle(vx_image image, const vx_rectangle_t *rect);



/*==============================================================================
 KERNEL
 =============================================================================*/

/*! \brief Loads a library of kernels, called module, into a context.
 *
 * The module must be a dynamic library with by convention, two exported functions
 * named <tt>vxPublishKernels</tt> and <tt>vxUnpublishKernels</tt>.
 *
 * <tt>vxPublishKernels</tt> must have type <tt>\ref vx_publish_kernels_f</tt>,
 * and must add kernels to the context by calling <tt>\ref vxAddUserKernel</tt>
 * for each new kernel. <tt>vxPublishKernels</tt> is called by <tt>\ref vxLoadKernels</tt>.
 *
 * <tt>vxUnpublishKernels</tt> must have type <tt>\ref vx_unpublish_kernels_f</tt>,
 * and must remove kernels from the context by calling <tt>\ref vxRemoveKernel</tt>
 * for each kernel the <tt>vxPublishKernels</tt> has added.
 * <tt>vxUnpublishKernels</tt> is called by <tt>\ref vxUnloadKernels</tt>.
 *
 * \note When all references to loaded kernels are released, the module
 * may be automatically unloaded.
 * \param [in] context The reference to the context the kernels must be added to.
 * \param [in] module The short name of the module to load. On systems where
 * there are specific naming conventions for modules, the name passed
 * should ignore such conventions. For example: \c libxyz.so should be
 * passed as just \c xyz and the implementation will <i>do the right thing</i> that
 * the platform requires.
 * \note This API uses the system pre-defined paths for modules.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE context is not a valid <tt>\ref vx_context</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS If any of the other parameters are incorrect.
 * \ingroup group_user_kernels
 * \see vxGetKernelByName
 */
VX_API_ENTRY vx_status VX_API_CALL vxLoadKernels(vx_context context, const vx_char *module);

/*! \brief Unloads all kernels from the OpenVX context that had been loaded from
 * the module using the \ref vxLoadKernels function.
 *
 * The kernel unloading is performed by calling the <tt>vxUnpublishKernels</tt>
 * exported function of the module.
 * \note <tt>vxUnpublishKernels</tt> is defined in the description of
 * <tt>\ref vxLoadKernels</tt>.
 *
 * \param [in] context The reference to the context the kernels must be removed from.
 * \param [in] module The short name of the module to unload. On systems where
 * there are specific naming conventions for modules, the name passed
 * should ignore such conventions. For example: \c libxyz.so should be
 * passed as just \c xyz and the implementation will <i>do the right thing</i>
 * that the platform requires.
 * \note This API uses the system pre-defined paths for modules.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE context is not a valid <tt>\ref vx_context</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS If any of the other parameters are
 incorrect.
 * \ingroup group_user_kernels
 * \see vxLoadKernels
 */
VX_API_ENTRY vx_status VX_API_CALL vxUnloadKernels(vx_context context, const vx_char *module);

/*! \brief Obtains a reference to a kernel using a string to specify the name.
 * \details User Kernels follow a "dotted" heirarchical syntax. For example:
 * "com.company.example.xyz". The following are strings specifying the kernel names:

 * org.khronos.openvx.color_convert

 * org.khronos.openvx.channel_extract

 * org.khronos.openvx.channel_combine

 * org.khronos.openvx.sobel_3x3

 * org.khronos.openvx.magnitude

 * org.khronos.openvx.phase

 * org.khronos.openvx.scale_image

 * org.khronos.openvx.table_lookup

 * org.khronos.openvx.histogram

 * org.khronos.openvx.equalize_histogram

 * org.khronos.openvx.absdiff

 * org.khronos.openvx.mean_stddev

 * org.khronos.openvx.threshold

 * org.khronos.openvx.integral_image

 * org.khronos.openvx.dilate_3x3

 * org.khronos.openvx.erode_3x3

 * org.khronos.openvx.median_3x3

 * org.khronos.openvx.box_3x3

 * org.khronos.openvx.gaussian_3x3

 * org.khronos.openvx.custom_convolution

 * org.khronos.openvx.gaussian_pyramid

 * org.khronos.openvx.accumulate

 * org.khronos.openvx.accumulate_weighted

 * org.khronos.openvx.accumulate_square

 * org.khronos.openvx.minmaxloc

 * org.khronos.openvx.convertdepth

 * org.khronos.openvx.canny_edge_detector

 * org.khronos.openvx.and

 * org.khronos.openvx.or

 * org.khronos.openvx.xor

 * org.khronos.openvx.not

 * org.khronos.openvx.multiply

 * org.khronos.openvx.add

 * org.khronos.openvx.subtract

 * org.khronos.openvx.warp_affine

 * org.khronos.openvx.warp_perspective

 * org.khronos.openvx.harris_corners

 * org.khronos.openvx.fast_corners

 * org.khronos.openvx.optical_flow_pyr_lk

 * org.khronos.openvx.remap

 * org.khronos.openvx.halfscale_gaussian

 * org.khronos.openvx.laplacian_pyramid

 * org.khronos.openvx.laplacian_reconstruct

 * org.khronos.openvx.non_linear_filter

 * org.khronos.openvx.tensor_multiply
 
 * org.khronos.openvx.tensor_add
 
 * org.khronos.openvx.tensor_subtract
 
 * org.khronos.openvx.tensor_table_lookup
 
 * org.khronos.openvx.tensor_transpose
 
 * org.khronos.openvx.tensor_convert_depth
 
 * org.khronos.openvx.matrix_multiply
 
 * org.khronos.openvx.copy
 
 * org.khronos.openvx.non_max_suppression
 
 * org.khronos.openvx.scalar_operation
 
 * org.khronos.openvx.hog_features
 
 * org.khronos.openvx.hog_cells
 
 * org.khronos.openvx.bilateral_filter
 
 * org.khronos.openvx.select
 
 * \param [in] context The reference to the implementation context.
 * \param [in] name The string of the name of the kernel to get.
 * \return A kernel reference. Any possible errors preventing a successful
 * completion of the function should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_kernel
 * \pre <tt>\ref vxLoadKernels</tt> if the kernel is not provided by the
 * OpenVX implementation.
 * \note User Kernels should follow a "dotted" hierarchical syntax. For example:
 * "com.company.example.xyz".
 */
VX_API_ENTRY vx_kernel VX_API_CALL vxGetKernelByName(vx_context context, const vx_char *name);

/*! \brief Obtains a reference to the kernel using the <tt>\ref vx_kernel_e</tt> enumeration.
 * \details Enum values above the standard set are assumed to apply to
 * loaded libraries.
 * \param [in] context The reference to the implementation context.
 * \param [in] kernel A value from <tt>\ref vx_kernel_e</tt> or a vendor or client-defined value.
 * \return A <tt>\ref vx_kernel</tt> reference. Any possible errors preventing a successful completion
 * of the function should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_kernel
 * \pre <tt>\ref vxLoadKernels</tt> if the kernel is not provided by the
 * OpenVX implementation.
 */
VX_API_ENTRY vx_kernel VX_API_CALL vxGetKernelByEnum(vx_context context, vx_kernel_e kernel);

/*! \brief This allows the client to query the kernel to get information about
 * the number of parameters, enum values, etc.
 * \param [in] kernel The kernel reference to query.
 * \param [in] attribute The attribute to query. Use a <tt>\ref vx_kernel_attribute_e</tt>.
 * \param [out] ptr The pointer to the location at which to store the resulting value.
 * \param [in] size The size of the container to which \a ptr points.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE kernel is not a valid <tt>\ref vx_kernel</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS If any of the other parameters are incorrect.
 * \retval VX_ERROR_NOT_SUPPORTED If the attribute value is not supported in this implementation.
 * \ingroup group_kernel
 */
VX_API_ENTRY vx_status VX_API_CALL vxQueryKernel(vx_kernel kernel, vx_kernel_attribute_e attribute, void *ptr, vx_size size);

/*! \brief Release the reference to the kernel.
 * The object may not be garbage collected until its total reference count is zero.
 * \param [in] kernel The pointer to the kernel reference to release.
 * \post After returning from this function the reference is zeroed.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE kernel is not a valid <tt>\ref vx_kernel</tt> reference.
 * \ingroup group_kernel
 */
VX_API_ENTRY vx_status VX_API_CALL vxReleaseKernel(vx_kernel *kernel);

/*! \brief Allows users to add custom kernels to a context at run-time.
 * \param [in] context The reference to the context the kernel must be added to.
 * \param [in] name The string to use to match the kernel.
 * \param [in] enumeration The enumerated value of the kernel to be used by clients.
 * \param [in] func_ptr The process-local function pointer to be invoked.
 * \param [in] numParams The number of parameters for this kernel.
 * \param [in] validate The pointer to <tt>\ref vx_kernel_validate_f</tt>, which validates
 * parameters to this kernel.
 * \param [in] init The kernel initialization function.
 * \param [in] deinit The kernel de-initialization function.
 * \return A <tt>\ref vx_kernel</tt> reference. Any possible errors
 * preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_user_kernels
 */
VX_API_ENTRY vx_kernel VX_API_CALL vxAddUserKernel(vx_context context,
                             const vx_char name[VX_MAX_KERNEL_NAME],
                             vx_enum enumeration,
                             vx_kernel_f func_ptr,
                             vx_uint32 numParams,
                             vx_kernel_validate_f validate,
                             vx_kernel_initialize_f init,
                             vx_kernel_deinitialize_f deinit);

/*! \brief This API is called after all parameters have been added to the
 * kernel and the kernel is \e ready to be used. Notice that the reference to the kernel created
 * by vxAddUserKernel is still valid after the call to vxFinalizeKernel.
 * If an error occurs, the kernel is not available for usage by the clients of OpenVX. Typically
 * this is due to a mismatch between the number of parameters requested and given.
 * \param [in] kernel The reference to the loaded kernel from <tt>\ref vxAddUserKernel</tt>.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE kernel is not a valid <tt>\ref vx_kernel</tt> reference.
 * \pre <tt>\ref vxAddUserKernel</tt> and <tt>\ref vxAddParameterToKernel</tt>
 * \ingroup group_user_kernels
 */
VX_API_ENTRY vx_status VX_API_CALL vxFinalizeKernel(vx_kernel kernel);

/*! \brief Allows users to set the signatures of the custom kernel.
 * \param [in] kernel The reference to the kernel added with <tt>\ref vxAddUserKernel</tt>.
 * \param [in] index The index of the parameter to add.
 * \param [in] dir The direction of the parameter. This must be either <tt>\ref VX_INPUT</tt> or
 * <tt>\ref VX_OUTPUT</tt>. <tt>\ref VX_BIDIRECTIONAL</tt> is not supported for this function.
 * \param [in] data_type The type of parameter. This must be a value from <tt>\ref vx_type_e</tt>.
 * \param [in] state The state of the parameter (required or not). This must be a value from <tt>\ref vx_parameter_state_e</tt>.
 * \return A <tt>\ref vx_status_e</tt> enumerated value.
 * \retval VX_SUCCESS Parameter is successfully set on kernel; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE kernel is not a valid <tt>\ref vx_kernel</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS If the parameter is not valid for any reason.
 * \pre <tt>\ref vxAddUserKernel</tt>
 * \ingroup group_user_kernels
 */
VX_API_ENTRY vx_status VX_API_CALL vxAddParameterToKernel(vx_kernel kernel, vx_uint32 index, vx_direction_e dir, vx_type_e data_type, vx_parameter_state_e state);

/*! \brief Removes a custom kernel from its context and releases it.
 * \param [in] kernel The reference to the kernel to remove. Returned from <tt>\ref vxAddUserKernel</tt>.
 * \note Any kernel enumerated in the base standard
 * cannot be removed; only kernels added through <tt>\ref vxAddUserKernel</tt> can
 * be removed.
 * \return A <tt>\ref vx_status_e</tt> enumeration. The function returns to the
 * application full control over the memory resources provided at the kernel creation time.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE kernel is not a valid <tt>\ref vx_kernel</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS If a base kernel is passed in.
 * \retval VX_FAILURE If the application has not released all references to the kernel
 * object OR if the application has not released all references to a node that is using
 * this kernel OR if the application has not released all references to a graph which
 * has nodes that is using this kernel.
 * \ingroup group_user_kernels
 */
VX_API_ENTRY vx_status VX_API_CALL vxRemoveKernel(vx_kernel kernel);

/*! \brief Sets kernel attributes.
 * \param [in] kernel The reference to the kernel.
 * \param [in] attribute The enumeration of the attributes. See <tt>\ref vx_kernel_attribute_e</tt>.
 * \param [in] ptr The pointer to the location from which to read the attribute.
 * \param [in] size The size in bytes of the data area indicated by \a ptr in bytes.
 * \note After a kernel has been passed to <tt>\ref vxFinalizeKernel</tt>, no attributes
 * can be altered.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE kernel is not a valid <tt>\ref vx_kernel</tt> reference.
 * \ingroup group_user_kernels
 */
VX_API_ENTRY vx_status VX_API_CALL vxSetKernelAttribute(vx_kernel kernel, vx_kernel_attribute_e attribute, const void *ptr, vx_size size);

/*! \brief Retrieves a <tt>\ref vx_parameter</tt> from a <tt>\ref vx_kernel</tt>.
 * \param [in] kernel The reference to the kernel.
 * \param [in] index The index of the parameter.
 * \return A <tt>\ref vx_parameter</tt> reference. Any possible errors preventing a
 * successful completion of the function should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_parameter
 */
VX_API_ENTRY vx_parameter VX_API_CALL vxGetKernelParameterByIndex(vx_kernel kernel, vx_uint32 index);

/*==============================================================================
 GRAPH
 =============================================================================*/

/*! \brief Creates an empty graph.
 * \param [in] context The reference to the implementation context.
 * \returns A graph reference <tt>\ref vx_graph</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_graph
 */
VX_API_ENTRY vx_graph VX_API_CALL vxCreateGraph(vx_context context);

/*! \brief Releases a reference to a graph.
 * The object may not be garbage collected until its total reference count is zero.
 * Once the reference count is zero, all node references in the graph are automatically
 * released as well. Releasing the graph will only release the nodes if the nodes were
 * not previously released by the application. Data referenced by those nodes may not
 * be released as the user may still have references to the data.
 * \param [in] graph The pointer to the graph to release.
 * \post After returning from this function the reference is zeroed.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE graph is not a valid <tt>\ref vx_graph</tt> reference.
 * \ingroup group_graph
 */
VX_API_ENTRY vx_status VX_API_CALL vxReleaseGraph(vx_graph *graph);

/*! \brief Verifies the state of the graph before it is executed.
 * This is useful to catch programmer errors and contract errors. If not verified,
 * the graph verifies before being processed.
 * \pre Memory for data objects is not guarenteed to exist before
 * this call. \post After this call data objects exist unless
 * the implementation optimized them out.
 * \param [in] graph The reference to the graph to verify.
 * \return A status code for graphs with more than one error; it is
 * undefined which error will be returned. Register a log callback using <tt>\ref vxRegisterLogCallback</tt>
 * to receive each specific error in the graph.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE graph is not a valid <tt>\ref vx_graph</tt> reference.
 * \retval VX_ERROR_MULTIPLE_WRITERS If the graph contains more than one writer
 * to any data object.
 * \retval VX_ERROR_INVALID_NODE If a node in the graph is invalid or failed be created.
 * \retval VX_ERROR_INVALID_GRAPH If the graph contains cycles or some other invalid topology.
 * \retval VX_ERROR_INVALID_TYPE If any parameter on a node is given the wrong type.
 * \retval VX_ERROR_INVALID_VALUE If any value of any parameter is out of bounds of specification.
 * \retval VX_ERROR_INVALID_FORMAT If the image format is not compatible.
 * \ingroup group_graph
 * \see vxProcessGraph
 */
VX_API_ENTRY vx_status VX_API_CALL vxVerifyGraph(vx_graph graph);

/*! \brief This function causes the synchronous processing of a graph. If the graph
 * has not been verified, then the implementation verifies the graph
 * immediately. If verification fails this function returns a status
 * identical to what <tt>\ref vxVerifyGraph</tt> would return. After
 * the graph verfies successfully then processing occurs. If the graph was
 * previously verified via <tt>\ref vxVerifyGraph</tt> or <tt>\ref vxProcessGraph</tt>
 * then the graph is processed. This function blocks until the graph is completed.
 * \param [in] graph The graph to execute.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Graph has been processed; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE graph is not a valid <tt>\ref vx_graph</tt> reference.
 * \retval VX_FAILURE A catastrophic error occurred during processing.
 * \ingroup group_graph
 */
VX_API_ENTRY vx_status VX_API_CALL vxProcessGraph(vx_graph graph);

/*! \brief Schedules a graph for future execution. If the graph
 * has not been verified, then the implementation verifies the graph
 * immediately. If verification fails this function returns a status
 * identical to what <tt>\ref vxVerifyGraph</tt> would return. After
 * the graph verfies successfully then processing occurs. If the graph was
 * previously verified via <tt>\ref vxVerifyGraph</tt> or <tt>\ref vxProcessGraph</tt>
 * then the graph is processed.
 * \param [in] graph The graph to schedule.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS The graph has been scheduled; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE graph is not a valid <tt>\ref vx_graph</tt> reference.
 * \retval VX_ERROR_NO_RESOURCES The graph cannot be scheduled now.
 * \retval VX_ERROR_NOT_SUFFICIENT The graph is not verified and has failed
 * forced verification.
 * \ingroup group_graph
 */
VX_API_ENTRY vx_status VX_API_CALL vxScheduleGraph(vx_graph graph);

/*! \brief Waits for a specific graph to complete. If the graph has been scheduled multiple
 * times since the last call to vxWaitGraph, then vxWaitGraph returns only when the last
 * scheduled execution completes.
 * \param [in] graph The graph to wait on.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS The graph has successfully completed execution and its outputs are the
 * valid results of the most recent execution; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE graph is not a valid <tt>\ref vx_graph</tt> reference.
 * \retval VX_FAILURE An error occurred or the graph was never scheduled. Output data of the
 * graph is undefined.
 * \pre <tt>\ref vxScheduleGraph</tt>
 * \ingroup group_graph
 */
VX_API_ENTRY vx_status VX_API_CALL vxWaitGraph(vx_graph graph);

/*! \brief Allows the user to query attributes of the Graph.
 * \param [in] graph The reference to the created graph.
 * \param [in] attribute The <tt>\ref vx_graph_attribute_e</tt> type needed.
 * \param [out] ptr The location at which to store the resulting value.
 * \param [in] size The size in bytes of the container to which \a ptr points.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE graph is not a valid <tt>\ref vx_graph</tt> reference.
 * \ingroup group_graph
 */
VX_API_ENTRY vx_status VX_API_CALL vxQueryGraph(vx_graph graph, vx_graph_attribute_e attribute, void *ptr, vx_size size);

/*! \brief Allows the attributes of the Graph to be set to the provided value.
 * \param [in] graph The reference to the graph.
 * \param [in] attribute The <tt>\ref vx_graph_attribute_e</tt> type needed.
 * \param [in] ptr The location from which to read the value.
 * \param [in] size The size in bytes of the container to which \a ptr points.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE graph is not a valid <tt>\ref vx_graph</tt> reference.
 * \ingroup group_graph
 */
VX_API_ENTRY vx_status VX_API_CALL vxSetGraphAttribute(vx_graph graph, vx_graph_attribute_e attribute, const void *ptr, vx_size size);

/*! \brief Adds the given parameter extracted from a <tt>\ref vx_node</tt> to the graph.
 * \param [in] graph The graph reference that contains the node.
 * \param [in] parameter The parameter reference to add to the graph from the node.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Parameter added to Graph; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE graph is not a valid <tt>\ref vx_graph</tt> reference or parameter is not a valid <tt>\ref vx_parameter</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS The parameter is of a node not in this
 * graph.
 * \ingroup group_graph_parameters
 */
VX_API_ENTRY vx_status VX_API_CALL vxAddParameterToGraph(vx_graph graph, vx_parameter parameter);

/*! \brief Sets a reference to the parameter on the graph. The implementation
 * must set this parameter on the originating node as well.
 * \param [in] graph The graph reference.
 * \param [in] index The parameter index.
 * \param [in] value The reference to set to the parameter.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Parameter set to Graph; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE graph is not a valid <tt>\ref vx_graph</tt> reference or
 * value is not a valid <tt>\ref vx_reference</tt>.
 * \retval VX_ERROR_INVALID_PARAMETERS The parameter index is out of bounds or the
 * dir parameter is incorrect.
 * \ingroup group_graph_parameters
 */
VX_API_ENTRY vx_status VX_API_CALL vxSetGraphParameterByIndex(vx_graph graph, vx_uint32 index, vx_reference value);

/*! \brief Retrieves a <tt>\ref vx_parameter</tt> from a <tt>\ref vx_graph</tt>.
 * \param [in] graph The graph.
 * \param [in] index The index of the parameter.
 * \return <tt>\ref vx_parameter</tt> reference. Any possible errors preventing a successful
 * function completion should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_graph_parameters
 */
VX_API_ENTRY vx_parameter VX_API_CALL vxGetGraphParameterByIndex(vx_graph graph, vx_uint32 index);

/*! \brief Returns a Boolean to indicate the state of graph verification.
 * \param [in] graph The reference to the graph to check.
 * \return A <tt>\ref vx_bool</tt> value.
 * \retval vx_true_e The graph is verified.
 * \retval vx_false_e The graph is not verified. It must be verified before
 * execution either through <tt>\ref vxVerifyGraph</tt> or automatically through
 * <tt>\ref vxProcessGraph</tt> or <tt>\ref vxScheduleGraph</tt>.
 * \ingroup group_graph
 */
VX_API_ENTRY vx_bool VX_API_CALL vxIsGraphVerified(vx_graph graph);

/*==============================================================================
 NODE
 =============================================================================*/

/*! \brief Creates a reference to a node object for a given kernel.
 * \details This node has no references assigned as parameters after completion.
 * The client is then required to set these parameters manually by <tt>\ref vxSetParameterByIndex</tt>.
 * When clients supply their own node creation functions (for use with User Kernels), this is the API
 * to use along with the parameter setting API.
 * \param [in] graph The reference to the graph in which this node exists.
 * \param [in] kernel The kernel reference to associate with this new node.
 * \returns A node reference <tt>\ref vx_node</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \note A call to this API sets all parameters to NULL.
 * \ingroup group_adv_node
 * \post Call <tt>\ref vxSetParameterByIndex</tt> for as many parameters as needed to be set.
 */
VX_API_ENTRY vx_node VX_API_CALL vxCreateGenericNode(vx_graph graph, vx_kernel kernel);

/*! \brief Allows a user to query information out of a node.
 * \param [in] node The reference to the node to query.
 * \param [in] attribute Use <tt>\ref vx_node_attribute_e</tt> value to query for information.
 * \param [out] ptr The location at which to store the resulting value.
 * \param [in] size The size in bytesin bytes of the container to which \a ptr points.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE node is not a valid <tt>\ref vx_node</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS The type or size is incorrect.
 * \ingroup group_node
 */
VX_API_ENTRY vx_status VX_API_CALL vxQueryNode(vx_node node, vx_node_attribute_e attribute, void *ptr, vx_size size);

/*! \brief Allows a user to set attribute of a node before Graph Validation.
 * \param [in] node The reference to the node to set.
 * \param [in] attribute Use <tt>\ref vx_node_attribute_e</tt> value to set the desired attribute.
 * \param [in] ptr The pointer to the desired value of the attribute.
 * \param [in] size The size in bytes of the objects to which \a ptr points.
 * \note Some attributes are inherited from the <tt>\ref vx_kernel</tt>, which was used
 * to create the node. Some of these can be overridden using this API, notably
 * \ref VX_NODE_LOCAL_DATA_SIZE and \ref VX_NODE_LOCAL_DATA_PTR.
 * \ingroup group_node
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS The attribute was set; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE node is not a valid <tt>\ref vx_node</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS size is not correct for the type needed.
 */
VX_API_ENTRY vx_status VX_API_CALL vxSetNodeAttribute(vx_node node, vx_node_attribute_e attribute, const void *ptr, vx_size size);

/*! \brief Releases a reference to a Node object.
 * The object may not be garbage collected until its total reference count is zero.
 * \param [in] node The pointer to the reference of the node to release.
 * \ingroup group_node
 * \post After returning from this function the reference is zeroed.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE node is not a valid <tt>\ref vx_node</tt> reference.
 */
VX_API_ENTRY vx_status VX_API_CALL vxReleaseNode(vx_node *node);

/*! \brief Removes a Node from its parent Graph and releases it.
 * \param [in] node The pointer to the node to remove and release.
 * \ingroup group_node
 * \post After returning from this function the reference is zeroed.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE node is not a valid <tt>\ref vx_node</tt> reference.
 */
VX_API_ENTRY vx_status VX_API_CALL vxRemoveNode(vx_node *node);

/*! \brief Assigns a callback to a node.
 * If a callback already exists in this node, this function must return an error
 * and the user may clear the callback by passing a NULL pointer as the callback.
 * \param [in] node The reference to the node.
 * \param [in] callback The callback to associate with completion of this
 * specific node.
 * \warning This must be used with <b><i>extreme</i></b> caution as it can \e ruin
 * optimizations in the power/performance efficiency of a graph.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Callback assigned; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE node is not a valid <tt>\ref vx_node</tt> reference.
 * \ingroup group_node_callback
 */
VX_API_ENTRY vx_status VX_API_CALL vxAssignNodeCallback(vx_node node, vx_nodecomplete_f callback);

/*! \brief Retrieves the current node callback function pointer set on the node.
 * \param [in] node The reference to the <tt>\ref vx_node</tt> object.
 * \ingroup group_node_callback
 * \return vx_nodecomplete_f The pointer to the callback function.
 * \retval NULL No callback is set.
 * \retval * The node callback function.
 */
VX_API_ENTRY vx_nodecomplete_f VX_API_CALL vxRetrieveNodeCallback(vx_node node);

/*! \brief Sets the node target to the provided value. A success invalidates the graph
 * that the node belongs to (<tt>\ref vxVerifyGraph</tt> must be called before the next execution)
 * \param [in] node  The reference to the <tt>\ref vx_node</tt> object.
 * \param [in] target_enum  The target enum to be set to the <tt>\ref vx_node</tt> object.
 * Use a <tt>\ref vx_target_e</tt>.
 * \param [in] target_string  The target name ASCII string. This contains a valid value
 * when target_enum is set to <tt>\ref VX_TARGET_STRING</tt>, otherwise it is ignored.
 * \ingroup group_node
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Node target set; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE node is not a valid <tt>\ref vx_node</tt> reference.
 * \retval VX_ERROR_NOT_SUPPORTED If the node kernel is not supported by the specified target.
 */
VX_API_ENTRY vx_status VX_API_CALL vxSetNodeTarget(vx_node node, vx_target_e target_enum, const char* target_string);

/*! \brief Creates replicas of the same node first_node to process a set of objects
 * stored in <tt>\ref vx_pyramid</tt> or <tt>\ref vx_object_array</tt>.
 * first_node needs to have as parameter levels 0 of a <tt>\ref vx_pyramid</tt> or the index 0 of a <tt>\ref vx_object_array</tt>.
 * Replica nodes are not accessible by the application through any means. An application request for removal of
 * first_node from the graph will result in removal of all replicas. Any change of parameter or attribute of
 * first_node will be propagated to the replicas. <tt>\ref vxVerifyGraph</tt> shall enforce consistency of parameters and attributes
 * in the replicas.
 * \param [in] graph The reference to the graph.
 * \param [in] first_node The reference to the node in the graph that will be replicated.
 * \param [in] replicate an array of size equal to the number of node parameters, vx_true_e for the parameters
 * that should be iterated over (should be a reference to a vx_pyramid or a vx_object_array),
 * vx_false_e for the parameters that should be the same across replicated nodes and for optional
 * parameters that are not used. Should be vx_true_e for all output and bidirectional parameters.
 * \param [in] number_of_parameters number of elements in the replicate array
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE graph is not a valid <tt>\ref vx_graph</tt> reference, or first_node is not a
 * valid <tt>\ref vx_node</tt> reference.
 * \retval VX_ERROR_NOT_COMPATIBLE At least one of replicated parameters is not of level 0 of a pyramid or at index 0 of an object array.
 * \retval VX_FAILURE If the node does not belong to the graph, or the number of objects in the parent objects of inputs and output are not the same.
 * \ingroup group_node
 */
VX_API_ENTRY vx_status VX_API_CALL vxReplicateNode(vx_graph graph, vx_node first_node, vx_bool replicate[], vx_uint32 number_of_parameters);

/*==============================================================================
 PARAMETER
 =============================================================================*/

/*! \brief Retrieves a <tt>\ref vx_parameter</tt> from a <tt>\ref vx_node</tt>.
 * \param [in] node The node from which to extract the parameter.
 * \param [in] index The index of the parameter to which to get a reference.
 * \return A parameter reference <tt>\ref vx_parameter</tt>. Any possible errors preventing a successful
 * completion of the function should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_parameter
 */
VX_API_ENTRY vx_parameter VX_API_CALL vxGetParameterByIndex(vx_node node, vx_uint32 index);

/*! \brief Releases a reference to a parameter object.
 * The object may not be garbage collected until its total reference count is zero.
 * \param [in] param The pointer to the parameter to release.
 * \ingroup group_parameter
 * \post After returning from this function the reference is zeroed.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE param is not a valid <tt>\ref vx_parameter</tt> reference.
 */
VX_API_ENTRY vx_status VX_API_CALL vxReleaseParameter(vx_parameter *param);

/*! \brief Sets the specified parameter data for a kernel on the node.
 * \param [in] node The node that contains the kernel.
 * \param [in] index The index of the parameter desired.
 * \param [in] value The desired value of the parameter.
 * \note A user may not provide a NULL value for a mandatory parameter of this API.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE node is not a valid <tt>\ref vx_node</tt> reference, or value
 * is not a valid <tt>\ref vx_reference</tt> reference.
 * \ingroup group_parameter
 * \see vxSetParameterByReference
 */
VX_API_ENTRY vx_status VX_API_CALL vxSetParameterByIndex(vx_node node, vx_uint32 index, vx_reference value);

/*! \brief Associates a parameter reference and a data reference with a kernel
 * on a node.
 * \param [in] parameter The reference to the kernel parameter.
 * \param [in] value The value to associate with the kernel parameter.
 * \note A user may not provide a NULL value for a mandatory parameter of this API.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE parameter is not a valid <tt>\ref vx_parameter</tt> reference,
 * or value is not a valid <tt>\ref vx_reference</tt> reference..
 * \ingroup group_parameter
 * \see vxGetParameterByIndex
 */
VX_API_ENTRY vx_status VX_API_CALL vxSetParameterByReference(vx_parameter parameter, vx_reference value);

/*! \brief Allows the client to query a parameter to determine its meta-information.
 * \param [in] parameter The reference to the parameter.
 * \param [in] attribute The attribute to query. Use a <tt>\ref vx_parameter_attribute_e</tt>.
 * \param [out] ptr The location at which to store the resulting value.
 * \param [in] size The size in bytes of the container to which \a ptr points.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE parameter is not a valid <tt>\ref vx_parameter</tt> reference.
 * \ingroup group_parameter
 */
VX_API_ENTRY vx_status VX_API_CALL vxQueryParameter(vx_parameter parameter, vx_parameter_attribute_e attribute, void *ptr, vx_size size);

/*==============================================================================
 SCALAR
 =============================================================================*/

/*! \brief Creates a reference to a scalar object. Also see \ref sub_node_parameters.
 * \param [in] context The reference to the system context.
 * \param [in] data_type The type of data to hold. Must be greater than
 * <tt>\ref VX_TYPE_INVALID</tt> and less than or equal to <tt>\ref VX_TYPE_VENDOR_STRUCT_END</tt>.
 * Or must be a <tt>\ref vx_enum</tt> returned from <tt>\ref vxRegisterUserStruct</tt>.
 * \param [in] ptr The pointer to the initial value of the scalar.
 * \ingroup group_scalar
 * \returns A scalar reference <tt>\ref vx_scalar</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_scalar VX_API_CALL vxCreateScalar(vx_context context, vx_type_e data_type, const void *ptr);

/*! \brief Creates a reference to a scalar object. Also see \ref sub_node_parameters.
 * \param [in] context The reference to the system context.
 * \param [in] data_type The type of data to hold. Must be greater than
 * <tt>\ref VX_TYPE_INVALID</tt> and less than or equal to <tt>\ref VX_TYPE_VENDOR_STRUCT_END</tt>.
 * Or must be a <tt>\ref vx_enum</tt> returned from <tt>\ref vxRegisterUserStruct</tt>.
 * \param [in] ptr The pointer to the initial value of the scalar.
 * \param [in] size Size of data at ptr in bytes.
 * \ingroup group_scalar
 * \returns A scalar reference <tt>\ref vx_scalar</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_scalar VX_API_CALL vxCreateScalarWithSize(vx_context context, vx_type_e data_type, const void *ptr, vx_size size);

/*! \brief Creates an opaque reference to a scalar object with no direct user access.
 * \param [in] graph The reference to the parent graph.
 * \param [in] data_type The type of data to hold. Must be greater than
 * <tt>\ref VX_TYPE_INVALID</tt> and less than or equal to <tt>\ref VX_TYPE_VENDOR_STRUCT_END</tt>.
 * Or must be a <tt>\ref vx_enum</tt> returned from <tt>\ref vxRegisterUserStruct</tt>.
 * \see <tt>\ref vxCreateScalar</tt>
 * \ingroup group_scalar
 * \returns A scalar reference <tt>\ref vx_scalar</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_scalar VX_API_CALL vxCreateVirtualScalar(vx_graph graph, vx_type_e data_type);

/*! \brief Releases a reference to a scalar object.
 * The object may not be garbage collected until its total reference count is zero.
 * \param [in] scalar The pointer to the scalar to release.
 * \ingroup group_scalar
 * \post After returning from this function the reference is zeroed.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE scalar is not a valid <tt>\ref vx_scalar</tt> reference.
 */
VX_API_ENTRY vx_status VX_API_CALL vxReleaseScalar(vx_scalar *scalar);

/*! \brief Queries attributes from a scalar.
 * \param [in] scalar The scalar object.
 * \param [in] attribute The enumeration to query. Use a <tt>\ref vx_scalar_attribute_e</tt> enumeration.
 * \param [out] ptr The location at which to store the resulting value.
 * \param [in] size The size of the container to which \a ptr points.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE scalar is not a valid <tt>\ref vx_scalar</tt> reference.
 * \ingroup group_scalar
 */
VX_API_ENTRY vx_status VX_API_CALL vxQueryScalar(vx_scalar scalar, vx_scalar_attribute_e attribute, void *ptr, vx_size size);

/*! \brief Allows the application to copy from/into a scalar object.
 * \param [in] scalar The reference to the scalar object that is the source or the
 * destination of the copy.
 * \param [in] user_ptr The address of the memory location where to store the requested data
 * if the copy was requested in read mode, or from where to get the data to store into the
 * scalar object if the copy was requested in write mode. In the user memory, the scalar is
 * a variable of the type corresponding to <tt>\ref VX_SCALAR_TYPE</tt>.
 * The accessible memory must be large enough to contain this variable.
 * \param [in] usage This declares the effect of the copy with regard to the scalar object
 * using the <tt>\ref vx_accessor_e</tt> enumeration. Only <tt>\ref VX_READ_ONLY</tt> and <tt>\ref VX_WRITE_ONLY</tt>
 * are supported:
 * \arg <tt>\ref VX_READ_ONLY</tt> means that data are copied from the scalar object into the user memory.
 * \arg <tt>\ref VX_WRITE_ONLY</tt> means that data are copied into the scalar object from the user memory.
 * \param [in] user_mem_type A <tt>\ref vx_memory_type_e</tt> enumeration that specifies
 * the memory type of the memory referenced by the user_addr.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE scalar is not a valid <tt>\ref vx_scalar</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 * \ingroup group_scalar
 */
VX_API_ENTRY vx_status VX_API_CALL vxCopyScalar(vx_scalar scalar, void *user_ptr, vx_accessor_e usage, vx_memory_type_e user_mem_type);

/*! \brief Allows the application to copy from/into a scalar object with size.
 * \param [in] scalar The reference to the scalar object that is the source or the
 * destination of the copy.
 * \param [in] size The size in bytes of the container to which \a user_ptr points.
 * \param [in] user_ptr The address of the memory location where to store the requested data
 * if the copy was requested in read mode, or from where to get the data to store into the
 * scalar object if the copy was requested in write mode. In the user memory, the scalar is
 * a variable of the type corresponding to <tt>\ref VX_SCALAR_TYPE</tt>.
 * The accessible memory must be large enough to contain this variable.
 * \param [in] usage This declares the effect of the copy with regard to the scalar object
 * using the <tt>\ref vx_accessor_e</tt> enumeration. Only <tt>\ref VX_READ_ONLY</tt> and <tt>\ref VX_WRITE_ONLY</tt>
 * are supported:
 * \arg <tt>\ref VX_READ_ONLY</tt> means that data are copied from the scalar object into the user memory.
 * \arg <tt>\ref VX_WRITE_ONLY</tt> means that data are copied into the scalar object from the user memory.
 * \param [in] user_mem_type A <tt>\ref vx_memory_type_e</tt> enumeration that specifies
 * the memory type of the memory referenced by the user_addr.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_ERROR_INVALID_REFERENCE The scalar reference is not actually a scalar reference.
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 * \ingroup group_scalar
 */
VX_API_ENTRY vx_status vxCopyScalarWithSize(vx_scalar scalar, vx_size size, void *user_ptr, vx_accessor_e usage, vx_memory_type_e user_mem_type);

/*==============================================================================
 REFERENCE
 =============================================================================*/

/*! \brief Queries any reference type for some basic information like count or type.
 * \param [in] ref The reference to query.
 * \param [in] attribute The value for which to query. Use <tt>\ref vx_reference_attribute_e</tt>.
 * \param [out] ptr The location at which to store the resulting value.
 * \param [in] size The size in bytes of the container to which ptr points.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE ref is not a valid <tt>\ref vx_reference</tt> reference.
 * \ingroup group_reference
 */
VX_API_ENTRY vx_status VX_API_CALL vxQueryReference(vx_reference ref, vx_reference_attribute_e attribute, void *ptr, vx_size size);

/*! \brief Releases a reference. The reference may potentially refer to multiple OpenVX objects of different types.
 * This function can be used instead of calling a specific release function for each individual object type
 * (e.g. vxRelease<object>). The object will not be destroyed until its total reference count is zero.
 * \note After returning from this function the reference is zeroed.
 * \param [in] ref_ptr The pointer to the reference of the object to release.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE ref_ptr is not a valid <tt>\ref vx_reference</tt> reference.
 * \ingroup group_reference
 */
VX_API_ENTRY vx_status VX_API_CALL vxReleaseReference(vx_reference* ref_ptr);

/*!
 * \brief Increments the reference counter of an object
 * This function is used to express the fact that the OpenVX object is referenced
 * multiple times by an application. Each time this function is called for
 * an object, the application will need to release the object one additional
 * time before it can be destructed
 * \param [in] ref The reference to retain.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE ref is not a valid <tt>\ref vx_reference</tt> reference.
 * \ingroup group_reference
 */
VX_API_ENTRY vx_status VX_API_CALL vxRetainReference(vx_reference ref);

/*! \brief Name a reference
 * \ingroup group_reference
 *
 * This function is used to associate a name to a referenced object. This name
 * can be used by the OpenVX implementation in log messages and any
 * other reporting mechanisms.
 *
 * The OpenVX implementation will not check if the name is unique in
 * the reference scope (context or graph). Several references can then
 * have the same name.
 *
 * \param [in] ref The reference to the object to be named.
 * \param [in] name Pointer to the '\0' terminated string that identifies
 *             the referenced object.
 *             The string is copied by the function so that it
 *             stays the property of the caller.
 *             NULL means that the reference is not named.
 *             The length of the string shall be lower than VX_MAX_REFERENCE_NAME bytes.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE ref is not a valid <tt>\ref vx_reference</tt> reference.
 */
VX_API_ENTRY vx_status VX_API_CALL vxSetReferenceName(vx_reference ref, const vx_char *name);

/*==============================================================================
 DELAY
 =============================================================================*/

/*! \brief Queries a <tt>\ref vx_delay</tt> object attribute.
 * \param [in] delay The reference to a delay object.
 * \param [in] attribute The attribute to query. Use a <tt>\ref vx_delay_attribute_e</tt> enumeration.
 * \param [out] ptr The location at which to store the resulting value.
 * \param [in] size The size of the container to which \a ptr points.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE delay is not a valid <tt>\ref vx_delay</tt> reference.
 * \ingroup group_delay
 */
VX_API_ENTRY vx_status VX_API_CALL vxQueryDelay(vx_delay delay, vx_delay_attribute_e attribute, void *ptr, vx_size size);

/*! \brief Releases a reference to a delay object.
 * The object may not be garbage collected until its total reference count is zero.
 * \param [in] delay The pointer to the delay object reference to release.
 * \post After returning from this function the reference is zeroed.
 * \ingroup group_delay
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE delay is not a valid <tt>\ref vx_delay</tt> reference.
 */
VX_API_ENTRY vx_status VX_API_CALL vxReleaseDelay(vx_delay *delay);


/*! \brief Creates a Delay object.
 * \details This function creates a delay object with \p num_slots slots. Each slot
 * contains a clone of the exemplar. The clones only inherit the metadata of the
 * exemplar. The data content of the exemplar is ignored and the clones have their
 * data undefined at delay creation time.
 * The function does not alter the exemplar. Also, it doesn't retain or release the
 * reference to the exemplar.
 * \note For the definition of metadata attributes see \ref vxSetMetaFormatAttribute.
 * \param [in] context The reference to the context.
 * \param [in] exemplar The exemplar object. Supported exemplar object types are:<br>
 * \arg \ref VX_TYPE_ARRAY
 * \arg \ref VX_TYPE_CONVOLUTION
 * \arg \ref VX_TYPE_DISTRIBUTION
 * \arg \ref VX_TYPE_IMAGE
 * \arg \ref VX_TYPE_LUT
 * \arg \ref VX_TYPE_MATRIX
 * \arg \ref VX_TYPE_OBJECT_ARRAY
 * \arg \ref VX_TYPE_PYRAMID
 * \arg \ref VX_TYPE_REMAP
 * \arg \ref VX_TYPE_SCALAR
 * \arg \ref VX_TYPE_THRESHOLD
 * \arg \ref VX_TYPE_TENSOR
 * \param [in] num_slots The number of objects in the delay.
 * \returns A delay reference <tt>\ref vx_delay</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_delay
 */
VX_API_ENTRY vx_delay VX_API_CALL vxCreateDelay(vx_context context,
                              vx_reference exemplar,
                              vx_size num_slots);

/*! \brief Retrieves a reference to a delay slot object.
 * \param [in] delay The reference to the delay object.
 * \param [in] index The index of the delay slot from which to extract the object reference.
 * \return <tt>\ref vx_reference</tt>. Any possible errors preventing a successful
 * completion of the function should be checked using <tt>\ref vxGetStatus</tt>.
 * \note The delay index is in the range \f$ [-count+1,0] \f$. 0 is always the
 * \e current object.
 * \ingroup group_delay
 * \note A reference retrieved with this function must not be given to its associated
 * release API (e.g. <tt>\ref vxReleaseImage</tt>) unless <tt>\ref vxRetainReference</tt> is used.
 */
VX_API_ENTRY vx_reference VX_API_CALL vxGetReferenceFromDelay(vx_delay delay, vx_int32 index);

/*! \brief Shifts the internal delay ring by one.
 *
 * This function performs a shift of the internal delay ring by one. This means that,
 * the data originally at index 0 move to index -1 and so forth until index
 * \f$ -count+1 \f$. The data originally at index \f$ -count+1 \f$ move to index 0.
 * Here \f$ count \f$ is the number of slots in delay ring.
 * When a delay is aged, any graph making use of this delay (delay object itself or data
 * objects in delay slots) gets its data automatically updated accordingly.
 * \param [in] delay
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS Delay was aged; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE delay is not a valid <tt>\ref vx_delay</tt> reference.
 * \ingroup group_delay
 */
VX_API_ENTRY vx_status VX_API_CALL vxAgeDelay(vx_delay delay);

/*! \brief Register a delay for auto-aging.
 *
 * This function registers a delay object to be auto-aged by the graph.
 * This delay object will be automatically aged after each successful completion of
 * this graph. Aging of a delay object cannot be called during graph execution.
 * A graph abandoned due to a node callback will trigger an auto-aging.
 *
 * If a delay is registered for auto-aging multiple times in a same graph,
 * the delay will be only aged a single time at each graph completion.
 * If a delay is registered for auto-aging in multiple graphs, this delay will
 * aged automatically after each successful completion of any of these graphs.
 *
 * \param [in] graph The graph to which the delay is registered for auto-aging.
 * \param [in] delay The delay to automatically age.
 *
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE graph is not a valid <tt>\ref vx_graph</tt> reference, or
 * delay is not a valid <tt>\ref vx_delay</tt> reference.
 * \ingroup group_graph
 */
VX_API_ENTRY vx_status VX_API_CALL vxRegisterAutoAging(vx_graph graph, vx_delay delay);

/*==============================================================================
 LOGGING
 =============================================================================*/

/*! \brief Adds a line to the log.
 * \param [in] ref The reference to add the log entry against. Some valid value must be provided.
 * \param [in] status The status code. <tt>\ref VX_SUCCESS</tt> status entries are ignored and not added.
 * \param [in] message The human readable message to add to the log.
 * \param [in] ... a list of variable arguments to the message.
 * \note Messages may not exceed <tt>\ref VX_MAX_LOG_MESSAGE_LEN</tt> bytes and will be truncated in the log if they exceed this limit.
 * \ingroup group_log
 */
VX_API_ENTRY void VX_API_CALL vxAddLogEntry(vx_reference ref, vx_status status, const char *message, ...);

/*! \brief Registers a callback facility to the OpenVX implementation to receive error logs.
 * \param [in] context The overall context to OpenVX.
 * \param [in] callback The callback function. If NULL, the previous callback is removed.
 * \param [in] reentrant If reentrancy flag is <tt>\ref vx_true_e</tt>, then the callback may be entered from multiple
 * simultaneous tasks or threads (if the host OS supports this).
 * \ingroup group_log
 */
VX_API_ENTRY void VX_API_CALL vxRegisterLogCallback(vx_context context, vx_log_callback_f callback, vx_bool reentrant);

/*==============================================================================
 LUT
 =============================================================================*/

/*! \brief Creates LUT object of a given type. The value of <tt>\ref VX_LUT_OFFSET</tt> is equal to 0
 * for data_type = <tt>\ref VX_TYPE_UINT8</tt>, and (vx_uint32)(count/2) for <tt>\ref VX_TYPE_INT16</tt>.
 * \param [in] context The reference to the context.
 * \param [in] data_type The type of data stored in the LUT.
 * \param [in] count The number of entries desired.
 * \note data_type can only be \ref VX_TYPE_UINT8 or \ref VX_TYPE_INT16. If data_type
 * is \ref VX_TYPE_UINT8, count should be not greater than 256. If data_type is \ref VX_TYPE_INT16,
 * count should not be greater than 65536.
 * \returns An LUT reference <tt>\ref vx_lut</tt>. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_lut
 */
VX_API_ENTRY vx_lut VX_API_CALL vxCreateLUT(vx_context context, vx_type_e data_type, vx_size count);

/*! \brief Creates an opaque reference to a LUT object with no direct user access.
 * \param [in] graph The reference to the parent graph.
 * \param [in] data_type The type of data stored in the LUT.
 * \param [in] count The number of entries desired.
 * \see <tt>\ref vxCreateLUT</tt>
 * \note data_type can only be \ref VX_TYPE_UINT8 or \ref VX_TYPE_INT16. If data_type
 * is \ref VX_TYPE_UINT8, count should be not greater than 256. If data_type is \ref VX_TYPE_INT16,
 * count should not be greater than 65536.
 * \returns An LUT reference <tt>\ref vx_lut</tt>. Any possible errors preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_lut
 */
VX_API_ENTRY vx_lut VX_API_CALL vxCreateVirtualLUT(vx_graph graph, vx_type_e data_type, vx_size count);

/*! \brief Releases a reference to a LUT object.
 * The object may not be garbage collected until its total reference count is zero.
 * \param [in] lut The pointer to the LUT to release.
 * \post After returning from this function the reference is zeroed.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE lut is not a valid <tt>\ref vx_lut</tt> reference.
 * \ingroup group_lut
 */
VX_API_ENTRY vx_status VX_API_CALL vxReleaseLUT(vx_lut *lut);

/*! \brief Queries attributes from a LUT.
 * \param [in] lut The LUT to query.
 * \param [in] attribute The attribute to query. Use a <tt>\ref vx_lut_attribute_e</tt> enumeration.
 * \param [out] ptr The location at which to store the resulting value.
 * \param [in] size The size in bytes of the container to which \a ptr points.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE lut is not a valid <tt>\ref vx_lut</tt> reference.
 * \ingroup group_lut
 */
VX_API_ENTRY vx_status VX_API_CALL vxQueryLUT(vx_lut lut, vx_lut_attribute_e attribute, void *ptr, vx_size size);

/*! \brief Allows the application to copy from/into a LUT object.
 * \param [in] lut The reference to the LUT object that is the source or the
 * destination of the copy.
 * \param [in] user_ptr The address of the memory location where to store the requested data
 * if the copy was requested in read mode, or from where to get the data to store into the LUT
 * object if the copy was requested in write mode. In the user memory, the LUT is
 * represented as a array with elements of the type corresponding to
 * <tt>\ref VX_LUT_TYPE</tt>, and with a number of elements equal to the value
 * returned via <tt>\ref VX_LUT_COUNT</tt>. The accessible memory must be large enough
 * to contain this array:
 * accessible memory in bytes >= sizeof(data_element) * count.
 * \param [in] usage This declares the effect of the copy with regard to the LUT object
 * using the <tt>\ref vx_accessor_e</tt> enumeration. Only <tt>\ref VX_READ_ONLY</tt> and <tt>\ref VX_WRITE_ONLY</tt>
 * are supported:
 * \arg <tt>\ref VX_READ_ONLY</tt> means that data are copied from the LUT object into the user memory.
 * \arg <tt>\ref VX_WRITE_ONLY</tt> means that data are copied into the LUT object from the user memory.
 * \param [in] user_mem_type A <tt>\ref vx_memory_type_e</tt> enumeration that specifies
 * the memory type of the memory referenced by the user_addr.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE lut is not a valid <tt>\ref vx_lut</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 * \ingroup group_lut
 */
VX_API_ENTRY vx_status VX_API_CALL vxCopyLUT(vx_lut lut, void *user_ptr, vx_accessor_e usage, vx_memory_type_e user_mem_type);

/*! \brief Allows the application to get direct access to LUT object.
 * \param [in] lut The reference to the LUT object to map.
 * \param [out] map_id The address of a <tt>\ref vx_map_id</tt> variable where the function
 * returns a map identifier.
 * \arg (*map_id) must eventually be provided as the map_id parameter of a call to
 * <tt>\ref vxUnmapLUT</tt>.
 * \param [out] ptr The address of a pointer that the function sets to the
 * address where the requested data can be accessed. In the mapped memory area,
 * the LUT data are structured as an array with elements of the type corresponding
 * to <tt>\ref VX_LUT_TYPE</tt>, with a number of elements equal to
 * the value returned via <tt>\ref VX_LUT_COUNT</tt>. Accessing the
 * memory out of the bound of this array is forbidden and has an undefined behavior.
 * The returned (*ptr) address is only valid between the call to the function and
 * the corresponding call to <tt>\ref vxUnmapLUT</tt>.
 * \param [in] usage This declares the access mode for the LUT, using
 * the <tt>\ref vx_accessor_e</tt> enumeration.
 * \arg <tt>\ref VX_READ_ONLY</tt>: after the function call, the content of the memory location
 * pointed by (*ptr) contains the LUT data. Writing into this memory location
 * is forbidden and its behavior is undefined.
 * \arg <tt>\ref VX_READ_AND_WRITE</tt>: after the function call, the content of the memory
 * location pointed by (*ptr) contains the LUT data; writing into this memory
 * is allowed only for the location of entries and will result in a modification
 * of the affected entries in the LUT object once the LUT is unmapped.
 * \arg <tt>\ref VX_WRITE_ONLY</tt>: after the function call, the memory location pointed by(*ptr)
 * contains undefined data; writing each entry of LUT is required prior to
 * unmapping. Entries not written by the application before unmap will become
 * undefined after unmap, even if they were well defined before map.
 * \param [in] mem_type A <tt>\ref vx_memory_type_e</tt> enumeration that
 * specifies the type of the memory where the LUT is requested to be mapped.
 * \param [in] flags An integer that allows passing options to the map operation.
 * Use 0 for this option.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE lut is not a valid <tt>\ref vx_lut</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 * \ingroup group_lut
 * \post <tt>\ref vxUnmapLUT </tt> with same (*map_id) value.
 */
VX_API_ENTRY vx_status VX_API_CALL vxMapLUT(vx_lut lut, vx_map_id *map_id, void **ptr, vx_accessor_e usage, vx_memory_type_e mem_type, vx_bitfield flags);

/*! \brief Unmap and commit potential changes to LUT object that was previously mapped.
 * Unmapping a LUT invalidates the memory location from which the LUT data could
 * be accessed by the application. Accessing this memory location after the unmap function
 * completes has an undefined behavior.
 * \param [in] lut The reference to the LUT object to unmap.
 * \param [out] map_id The unique map identifier that was returned when calling
 * <tt>\ref vxMapLUT</tt> .
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE lut is not a valid <tt>\ref vx_lut</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 * \ingroup group_lut
 * \pre <tt>\ref vxMapLUT</tt> returning the same map_id value
 */
VX_API_ENTRY vx_status VX_API_CALL vxUnmapLUT(vx_lut lut, vx_map_id map_id);

/*==============================================================================
 DISTRIBUTION
 =============================================================================*/

/*! \brief Creates a reference to a 1D Distribution of a consecutive interval [offset, offset + range - 1]
 * defined by a start offset and valid range, divided equally into numBins parts.
 * \param [in] context The reference to the overall context.
 * \param [in] numBins The number of bins in the distribution.
 * \param [in] offset The start offset into the range value that marks the begining of the 1D Distribution.
 * \param [in] range  The total number of the consecutive values of the distribution interval.
 * \returns A distribution reference <tt>\ref vx_distribution</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_distribution
 */
VX_API_ENTRY vx_distribution VX_API_CALL vxCreateDistribution(vx_context context, vx_size numBins, vx_int32 offset, vx_uint32 range);

/*! \brief Creates an opaque reference to a 1D Distribution object without direct user access.
 * \param [in] graph The reference to the parent graph.
 * \param [in] numBins The number of bins in the distribution.
 * \param [in] offset The start offset into the range value that marks the begining of the 1D Distribution.
 * \param [in] range  The total number of the consecutive values of the distribution interval.
 * \see <tt>\ref vxCreateDistribution</tt>
 * \returns A distribution reference <tt>\ref vx_distribution</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_distribution
 */
VX_API_ENTRY vx_distribution VX_API_CALL vxCreateVirtualDistribution(vx_graph graph, vx_size numBins, vx_int32 offset, vx_uint32 range);

/*! \brief Releases a reference to a distribution object.
 * The object may not be garbage collected until its total reference count is zero.
 * \param [in] distribution The reference to the distribution to release.
 * \post After returning from this function the reference is zeroed.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE distribution is not a valid <tt>\ref vx_distribution</tt> reference.
 * \ingroup group_distribution
 */
VX_API_ENTRY vx_status VX_API_CALL vxReleaseDistribution(vx_distribution *distribution);

/*! \brief Queries a Distribution object.
 * \param [in] distribution The reference to the distribution to query.
 * \param [in] attribute The attribute to query. Use a <tt>\ref vx_distribution_attribute_e</tt> enumeration.
 * \param [out] ptr The location at which to store the resulting value.
 * \param [in] size The size in bytes of the container to which \a ptr points.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE distribution is not a valid <tt>\ref vx_distribution</tt> reference.
 * \ingroup group_distribution
 */
VX_API_ENTRY vx_status VX_API_CALL vxQueryDistribution(vx_distribution distribution, vx_distribution_attribute_e attribute, void *ptr, vx_size size);

/*! \brief Allows the application to copy from/into a distribution object.
 * \param [in] distribution The reference to the distribution object that is the source or the
 * destination of the copy.
 * \param [in] user_ptr The address of the memory location where to store the requested data
 * if the copy was requested in read mode, or from where to get the data to store into the distribution
 * object if the copy was requested in write mode. In the user memory, the distribution is
 * represented as a <tt>\ref vx_uint32</tt> array with a number of elements equal to the value returned via
 * <tt>\ref VX_DISTRIBUTION_BINS</tt>. The accessible memory must be large enough
 * to contain this vx_uint32 array:
 * accessible memory in bytes >= sizeof(vx_uint32) * num_bins.
 * \param [in] usage This declares the effect of the copy with regard to the distribution object
 * using the <tt>\ref vx_accessor_e</tt> enumeration. Only <tt>\ref VX_READ_ONLY</tt> and <tt>\ref VX_WRITE_ONLY</tt>
 * are supported:
 * \arg <tt>\ref VX_READ_ONLY</tt> means that data are copied from the distribution object into the user memory.
 * \arg <tt>\ref VX_WRITE_ONLY</tt> means that data are copied into the distribution object from the user memory.
 * \param [in] user_mem_type A <tt>\ref vx_memory_type_e</tt> enumeration that specifies
 * the memory type of the memory referenced by the user_addr.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE distribution is not a valid <tt>\ref vx_distribution</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 * \ingroup group_distribution
 */
VX_API_ENTRY vx_status VX_API_CALL vxCopyDistribution(vx_distribution distribution, void *user_ptr, vx_accessor_e usage, vx_memory_type_e user_mem_type);

/*! \brief Allows the application to get direct access to distribution object.
 * \param [in] distribution The reference to the distribution object to map.
 * \param [out] map_id The address of a <tt>\ref vx_map_id</tt> variable where the function
 * returns a map identifier.
 * \arg (*map_id) must eventually be provided as the map_id parameter of a call to
 * <tt>\ref vxUnmapDistribution</tt>.
 * \param [out] ptr The address of a pointer that the function sets to the
 * address where the requested data can be accessed. In the mapped memory area,
 * data are structured as a vx_uint32 array with a number of elements equal to
 * the value returned via <tt>\ref VX_DISTRIBUTION_BINS</tt>. Each
 * element of this array corresponds to a bin of the distribution, with a range-major
 * ordering. Accessing the memory out of the bound of this array
 * is forbidden and has an undefined behavior. The returned (*ptr) address
 * is only valid between the call to the function and the corresponding call to
 * <tt>\ref vxUnmapDistribution</tt>.
 * \param [in] usage This declares the access mode for the distribution, using
 * the <tt>\ref vx_accessor_e</tt> enumeration.
 * \arg <tt>\ref VX_READ_ONLY</tt>: after the function call, the content of the memory location
 * pointed by (*ptr) contains the distribution data. Writing into this memory location
 * is forbidden and its behavior is undefined.
 * \arg <tt>\ref VX_READ_AND_WRITE</tt>: after the function call, the content of the memory
 * location pointed by (*ptr) contains the distribution data; writing into this memory
 * is allowed only for the location of bins and will result in a modification of the
 * affected bins in the distribution object once the distribution is unmapped.
 * \arg <tt>\ref VX_WRITE_ONLY</tt>: after the function call, the memory location pointed by (*ptr)
 * contains undefined data; writing each bin of distribution is required prior to
 * unmapping. Bins not written by the application before unmap will become
 * undefined after unmap, even if they were well defined before map.
 * \param [in] mem_type A <tt>\ref vx_memory_type_e</tt> enumeration that
 * specifies the type of the memory where the distribution is requested to be mapped.
 * \param [in] flags An integer that allows passing options to the map operation.
 * Use 0 for this option.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE distribution is not a valid <tt>\ref vx_distribution</tt> reference.
 * reference.
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 * \ingroup group_distribution
 * \post <tt>\ref vxUnmapDistribution </tt> with same (*map_id) value.
 */
VX_API_ENTRY vx_status VX_API_CALL vxMapDistribution(vx_distribution distribution, vx_map_id *map_id, void **ptr, vx_accessor_e usage, vx_memory_type_e mem_type, vx_bitfield flags);

/*! \brief Unmap and commit potential changes to distribution object that was previously mapped.
 * Unmapping a distribution invalidates the memory location from which the distribution data
 * could be accessed by the application. Accessing this memory location after the unmap
 * function completes has an undefined behavior.
 * \param [in] distribution The reference to the distribution object to unmap.
 * \param [out] map_id The unique map identifier that was returned when calling
 * <tt>\ref vxMapDistribution</tt> .
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE distribution is not a valid <tt>\ref vx_distribution</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 * \ingroup group_distribution
 * \pre <tt>\ref vxMapDistribution</tt> returning the same map_id value
 */
VX_API_ENTRY vx_status VX_API_CALL vxUnmapDistribution(vx_distribution distribution, vx_map_id map_id);


/*==============================================================================
 THRESHOLD
 =============================================================================*/

/*! \brief Creates a threshold object and returns a reference to it.
 *
 * The threshold object defines the parameters of a thresholding operation
 * to an input image, that generates an output image that can have a different
 * format. The thresholding 'false' or 'true' output values are specified per
 * pixel channels of the output format and can be modified with
 * <tt>\ref vxCopyThresholdOutput</tt>. The default 'false' output value of
 * pixels channels should be 0, and the default 'true' value should be non-zero.
 * For standard image formats, default output pixel values are defined as
 * following:
 *  \arg \ref VX_DF_IMAGE_RGB: false={0, 0, 0}, true={255,255,255}
 *  \arg \ref VX_DF_IMAGE_RGBX: false={0, 0, 0, 0}, true={255,255,255,255}
 *  \arg \ref VX_DF_IMAGE_NV12: false={0, 0, 0}, true={255,255,255}
 *  \arg \ref VX_DF_IMAGE_NV21: false={0, 0, 0}, true={255,255,255}
 *  \arg \ref VX_DF_IMAGE_UYVY: false={0, 0, 0}, true={255,255,255}
 *  \arg \ref VX_DF_IMAGE_YUYV: false={0, 0, 0}, true={255,255,255}
 *  \arg \ref VX_DF_IMAGE_IYUV: false={0, 0, 0}, true={255,255,255}
 *  \arg \ref VX_DF_IMAGE_YUV4: false={0, 0, 0}, true={255,255,255}
 *  \arg \ref VX_DF_IMAGE_U8: false=0, true=0xFF
 *  \arg \ref VX_DF_IMAGE_S16: false=0, true=-1
 *  \arg \ref VX_DF_IMAGE_U16: false=0, true=0xFFFF
 *  \arg \ref VX_DF_IMAGE_S32: false=0, true=-1
 *  \arg \ref VX_DF_IMAGE_U32: false=0, true=0xFFFFFFFF
 * \param [in] context The reference to the context in which the object is
 * created.
 * \param [in] thresh_type The type of thresholding operation.
 * \param [in] input_format The format of images that will be used as input of
 * the thresholding operation.
 * \param [in] output_format The format of images that will be generated by the
 * thresholding operation.
 * \returns A threshold reference <tt>\ref vx_threshold</tt>. Any possible
 * errors preventing a successful creation should be checked using
 * <tt>\ref vxGetStatus</tt>.
 * \ingroup group_threshold
 */
VX_API_ENTRY vx_threshold VX_API_CALL vxCreateThresholdForImage(vx_context context,
                                                                vx_enum thresh_type,
                                                                vx_df_image input_format,
                                                                vx_df_image output_format);

/*! \brief Creates an opaque reference to a threshold object without direct user access.
 * 
 * \param [in] graph The reference to the parent graph.
 * \param [in] thresh_type The type of thresholding operation.
 * \param [in] input_format The format of images that will be used as input of
 * the thresholding operation.
 * \param [in] output_format The format of images that will be generated by the
 * thresholding operation.
 * \see <tt>\ref vxCreateThresholdForImage</tt>
 * \returns A threshold reference <tt>\ref vx_threshold</tt>. Any possible
 * errors preventing a successful creation should be checked using
 * <tt>\ref vxGetStatus</tt>.
 * \ingroup group_threshold
 */
VX_API_ENTRY vx_threshold VX_API_CALL vxCreateVirtualThresholdForImage(vx_graph graph,
                                                                       vx_enum thresh_type,
                                                                       vx_df_image input_format,
                                                                       vx_df_image output_format);

/*! \brief Allows the application to copy the thresholding value from/into a
 * threshold object with type <tt>\ref VX_THRESHOLD_TYPE_BINARY</tt>.
 * \param [in] thresh The reference to the threshold object that is the source
 * or the destination of the copy.
 * \param [in,out] value_ptr The address of the memory location where to store
 * the thresholding value if the copy was requested in read mode, or from where
 * to get the thresholding value to store into the threshold object if the copy
 * was requested in write mode.
 * \param [in] usage This declares the effect of the copy with regard to the
 * threshold object using the <tt>\ref vx_accessor_e</tt> enumeration. Only
 * <tt>\ref VX_READ_ONLY</tt> and <tt>\ref VX_WRITE_ONLY</tt> are supported:
 * \arg <tt>\ref VX_READ_ONLY</tt> means that the thresholding value is copied
 * from the threshold object into the user memory. After the copy, only the
 * field of the (*value_ptr) union that corresponds to the input image format
 * of the threshold object is meaningful.
 * \arg <tt>\ref VX_WRITE_ONLY</tt> means the field of the (*value_ptr) union
 * corresponding  to the input format of the threshold object is copied into
 * the threshold object.
 * \param [in] user_mem_type A <tt>\ref vx_memory_type_e</tt> enumeration that
 * specifies the type of the memory referenced by \p value_ptr.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_ERROR_INVALID_REFERENCE The threshold reference is not actually a
 * threshold reference.
 * \retval VX_ERROR_NOT_COMPATIBLE The threshold object doesn't have type
 * <tt>\ref VX_THRESHOLD_TYPE_BINARY</tt>
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 * \ingroup group_threshold
 */
VX_API_ENTRY vx_status VX_API_CALL vxCopyThresholdValue(vx_threshold thresh,
                                                        vx_pixel_value_t * value_ptr,
                                                        vx_accessor_e usage,
                                                        vx_memory_type_e user_mem_type
                                                        );

/*! \brief Allows the application to copy thresholding values from/into a
 * threshold object with type <tt>\ref VX_THRESHOLD_TYPE_RANGE</tt>.
 * \param [in] thresh The reference to the threshold object that is the source
 * or the destination of the copy.
 * \param [in,out] lower_value_ptr The address of the memory location where to
 * store the lower thresholding value if the copy was requested in read mode,
 * or from where to get the lower thresholding value to store into the threshold
 * object if the copy was requested in write mode.
 * \param [in,out] upper_value_ptr The address of the memory location where to
 * store the upper thresholding value if the copy was requested in read mode, or
 * from where to get the upper thresholding value to store into the threshold
 * object if the copy was requested in write mode.
 * \param [in] usage This declares the effect of the copy with regard to the
 * threshold object using the <tt>\ref vx_accessor_e</tt> enumeration. Only
 * <tt>\ref VX_READ_ONLY</tt> and <tt>\ref VX_WRITE_ONLY</tt> are supported:
 * \arg <tt>\ref VX_READ_ONLY</tt> means that thresholding values are copied
 * from the threshold object into the user memory. After the copy, only the
 * field of (*lower_value_ptr) and (*upper_value_ptr) unions that corresponds
 * to the input image format of the threshold object is meaningful.
 * \arg <tt>\ref VX_WRITE_ONLY</tt> means the field of the (*lower_value_ptr)
 * and (*upper_value_ptr) unions corresponding to the input format of the
 * threshold object is copied into the threshold object.
 * \param [in] user_mem_type A <tt>\ref vx_memory_type_e</tt> enumeration that
 * specifies the type of the memory referenced by \p lower_value_ptr and
 * \p upper_value_ptr.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_ERROR_INVALID_REFERENCE The threshold reference is not actually
 * a threshold reference.
 * \retval VX_ERROR_NOT_COMPATIBLE The threshold object doesn't have type
 * <tt>\ref VX_THRESHOLD_TYPE_RANGE</tt>
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 * \ingroup group_threshold
 */
VX_API_ENTRY vx_status VX_API_CALL vxCopyThresholdRange(vx_threshold thresh,
                                                        vx_pixel_value_t * lower_value_ptr,
                                                        vx_pixel_value_t * upper_value_ptr,
                                                        vx_accessor_e usage,
                                                        vx_memory_type_e user_mem_type);

/*! \brief Allows the application to copy the true and false output values
 * from/into a threshold object.
 * \param [in] thresh The reference to the threshold object that is the source
 * or the destination of the copy.
 * \param [in,out] true_value_ptr The address of the memory location where to
 * store the true output value if the copy was requested in read mode,
 * or from where to get the true output value to store into the threshold
 * object if the copy was requested in write mode.
 * \param [in,out] false_value_ptr The address of the memory location where to
 * store the false output value if the copy was requested in read mode, or
 * from where to get the false output value to store into the threshold
 * object if the copy was requested in write mode.
 * \param [in] usage This declares the effect of the copy with regard to the
 * threshold object using the <tt>\ref vx_accessor_e</tt> enumeration. Only
 * <tt>\ref VX_READ_ONLY</tt> and <tt>\ref VX_WRITE_ONLY</tt> are supported:
 * \arg <tt>\ref VX_READ_ONLY</tt> means that true and false output values
 * are copied from the threshold object into the user memory. After the copy,
 * only the field of (*true_value_ptr) and (*false_value_ptr) unions that
 * corresponds to the output image format of the threshold object is meaningful.
 * \arg <tt>\ref VX_WRITE_ONLY</tt> means the field of the (*true_value_ptr)
 * and (*false_value_ptr) unions corresponding to the output format of the
 * threshold object is copied into the threshold object.
 * \param [in] user_mem_type A <tt>\ref vx_memory_type_e</tt> enumeration that
 * specifies the type of the memory referenced by \p true_value_ptr and
 * \p false_value_ptr.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_ERROR_INVALID_REFERENCE The threshold reference is not actually
 * a threshold reference.
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 * \ingroup group_threshold
 */
VX_API_ENTRY vx_status VX_API_CALL vxCopyThresholdOutput(vx_threshold thresh,
                                                         vx_pixel_value_t * true_value_ptr,
                                                         vx_pixel_value_t * false_value_ptr,
                                                         vx_accessor_e usage,
                                                         vx_memory_type_e user_mem_type);

/*! \brief Releases a reference to a threshold object.
 * The object may not be garbage collected until its total reference count is zero.
 * \param [in] thresh The pointer to the threshold to release.
 * \post After returning from this function the reference is zeroed.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE thresh is not a valid <tt>\ref vx_threshold</tt> reference.
 * \ingroup group_threshold
 */
VX_API_ENTRY vx_status VX_API_CALL vxReleaseThreshold(vx_threshold *thresh);

/*! \brief Sets attributes on the threshold object.
 * \param [in] thresh The threshold object to set.
 * \param [in] attribute The attribute to modify. Use a <tt>\ref vx_threshold_attribute_e</tt> enumeration.
 * \param [in] ptr The pointer to the value to which to set the attribute.
 * \param [in] size The size of the data pointed to by \a ptr.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE thresh is not a valid <tt>\ref vx_threshold</tt> reference.
 * \ingroup group_threshold
 */
VX_API_ENTRY vx_status VX_API_CALL vxSetThresholdAttribute(vx_threshold thresh, vx_threshold_attribute_e attribute, const void *ptr, vx_size size);

/*! \brief Queries an attribute on the threshold object.
 * \param [in] thresh The threshold object to set.
 * \param [in] attribute The attribute to query. Use a <tt>\ref vx_threshold_attribute_e</tt> enumeration.
 * \param [out] ptr The location at which to store the resulting value.
 * \param [in] size The size of the container to which \a ptr points.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE thresh is not a valid <tt>\ref vx_threshold</tt> reference.
 * \ingroup group_threshold
 */
VX_API_ENTRY vx_status VX_API_CALL vxQueryThreshold(vx_threshold thresh, vx_threshold_attribute_e attribute, void *ptr, vx_size size);

/*==============================================================================
 MATRIX
 =============================================================================*/

/*! \brief Creates a reference to a matrix object.
 * \param [in] c The reference to the overall context.
 * \param [in] data_type The unit format of the matrix. <tt>\ref VX_TYPE_UINT8</tt> or <tt>\ref VX_TYPE_INT32</tt> or <tt>\ref VX_TYPE_FLOAT32</tt>.
 * \param [in] columns The first dimensionality.
 * \param [in] rows The second dimensionality.
 * \returns An matrix reference <tt>\ref vx_matrix</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_matrix
 */
VX_API_ENTRY vx_matrix VX_API_CALL vxCreateMatrix(vx_context c, vx_type_e data_type, vx_size columns, vx_size rows);

/*! \brief Creates an opaque reference to a matrix object without direct user access.
 * \param [in] graph The reference to the parent graph.
 * \param [in] data_type The unit format of the matrix. <tt>\ref VX_TYPE_UINT8</tt> or <tt>\ref VX_TYPE_INT32</tt> or <tt>\ref VX_TYPE_FLOAT32</tt>.
 * \param [in] columns The first dimensionality.
 * \param [in] rows The second dimensionality.
 * \see <tt>\ref vxCreateMatrix</tt>
 * \returns An matrix reference <tt>\ref vx_matrix</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_matrix
 */
VX_API_ENTRY vx_matrix VX_API_CALL vxCreateVirtualMatrix(vx_graph graph, vx_type_e data_type, vx_size columns, vx_size rows);

/*! \brief Releases a reference to a matrix object.
 * The object may not be garbage collected until its total reference count is zero.
 * \param [in] mat The matrix reference to release.
 * \post After returning from this function the reference is zeroed.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE mat is not a valid <tt>\ref vx_matrix</tt> reference.
 * \ingroup group_matrix
 */
VX_API_ENTRY vx_status VX_API_CALL vxReleaseMatrix(vx_matrix *mat);

/*! \brief Queries an attribute on the matrix object.
 * \param [in] mat The matrix object to set.
 * \param [in] attribute The attribute to query. Use a <tt>\ref vx_matrix_attribute_e</tt> enumeration.
 * \param [out] ptr The location at which to store the resulting value.
 * \param [in] size The size in bytes of the container to which \a ptr points.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE mat is not a valid <tt>\ref vx_matrix</tt> reference.
 * \ingroup group_matrix
 */
VX_API_ENTRY vx_status VX_API_CALL vxQueryMatrix(vx_matrix mat, vx_matrix_attribute_e attribute, void *ptr, vx_size size);

/*! \brief Allows the application to copy from/into a matrix object.
 * \param [in] matrix The reference to the matrix object that is the source or the
 * destination of the copy.
 * \param [in] user_ptr The address of the memory location where to store the requested data
 * if the copy was requested in read mode, or from where to get the data to store into the matrix
 * object if the copy was requested in write mode. In the user memory, the matrix is
 * structured as a row-major 2D array with elements of the type corresponding to
 * <tt>\ref VX_MATRIX_TYPE</tt>, with a number of rows corresponding to
 * <tt>\ref VX_MATRIX_ROWS</tt> and a number of columns corresponding to
 * <tt>\ref VX_MATRIX_COLUMNS</tt>. The accessible memory must be large
 * enough to contain this 2D array:
 * accessible memory in bytes >= sizeof(data_element) * rows * columns.
 * \param [in] usage This declares the effect of the copy with regard to the matrix object
 * using the <tt>\ref vx_accessor_e</tt> enumeration. Only <tt>\ref VX_READ_ONLY</tt> and <tt>\ref VX_WRITE_ONLY</tt>
 * are supported:
 * \arg <tt>\ref VX_READ_ONLY</tt> means that data are copied from the matrix object into the user memory.
 * \arg <tt>\ref VX_WRITE_ONLY</tt> means that data are copied into the matrix object from the user memory.
 * \param [in] user_mem_type A <tt>\ref vx_memory_type_e</tt> enumeration that specifies
 * the memory type of the memory referenced by the user_addr.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE matrix is not a valid <tt>\ref vx_matrix</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 * \ingroup group_matrix
 */
VX_API_ENTRY vx_status VX_API_CALL vxCopyMatrix(vx_matrix matrix, void *user_ptr, vx_accessor_e usage, vx_memory_type_e user_mem_type);

/*! \brief Creates a reference to a matrix object from a boolean pattern.
 * \see <tt>\ref vxCreateMatrixFromPatternAndOrigin</tt> for a description of the matrix pattern.
 * \param [in] context The reference to the overall context.
 * \param [in] pattern The pattern of the matrix. See <tt>\ref VX_MATRIX_PATTERN</tt>.
 * \param [in] columns The first dimensionality.
 * \param [in] rows The second dimensionality.
 * \see <tt>\ref vxCreateMatrixFromPatternAndOrigin</tt>.
 * \returns A matrix reference <tt>\ref vx_matrix</tt> of type <tt>\ref vx_uint8</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_matrix
 */
VX_API_ENTRY vx_matrix VX_API_CALL vxCreateMatrixFromPattern(vx_context context, vx_matrix_attribute_e pattern, vx_size columns, vx_size rows);

/*! \brief Creates a reference to a matrix object from a boolean pattern, with a user-specified origin.
 *
 * The matrix created by this function is of type <tt>\ref vx_uint8</tt>, with the value 0 representing False,
 * and the value 255 representing True. It supports patterns described below. See <tt>\ref vx_pattern_e</tt>.
 * - VX_PATTERN_BOX is a matrix with dimensions equal to the given number of rows and columns, and all cells equal to 255.
 *   Dimensions of 3x3 and 5x5 must be supported.
 * - VX_PATTERN_CROSS is a matrix with dimensions equal to the given number of rows and columns, which both must be odd numbers.
 *   All cells in the center row and center column are equal to 255, and the rest are equal to zero.
 *   Dimensions of 3x3 and 5x5 must be supported.
 * - VX_PATTERN_DISK is an RxC matrix, where R and C are odd and cell (c, r) is 255 if: \n
 *   (r-R/2 + 0.5)^2 / (R/2)^2 + (c-C/2 + 0.5)^2/(C/2)^2 is less than or equal to 1,\n and 0 otherwise.
 * - VX_PATTERN_OTHER is any other pattern than the above (matrix created is still binary, with a value of 0 or 255).
 *
 * If the matrix was created via <tt>\ref vxCreateMatrixFromPattern</tt>, this attribute must be set to the
 * appropriate pattern enum. Otherwise the attribute must be set to VX_PATTERN_OTHER.
 * The vx_matrix objects returned by this function are read-only. The behavior when attempting to modify such a matrix is undefined.
 *
 * \param [in] context The reference to the overall context.
 * \param [in] pattern The pattern of the matrix. See <tt>\ref VX_MATRIX_PATTERN</tt>.
 * \param [in] columns The first dimensionality.
 * \param [in] rows The second dimensionality.
 * \param [in] origin_col The origin (first dimensionality).
 * \param [in] origin_row The origin (second dimensionality).
 * \returns A matrix reference <tt>\ref vx_matrix</tt> of type <tt>\ref vx_uint8</tt>. Any possible errors
 * preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_matrix
 */
VX_API_ENTRY vx_matrix VX_API_CALL vxCreateMatrixFromPatternAndOrigin(vx_context context, vx_pattern_e pattern, vx_size columns, vx_size rows, vx_size origin_col, vx_size origin_row);


/*==============================================================================
 CONVOLUTION
 =============================================================================*/

/*! \brief Creates a reference to a convolution matrix object.
 * \param [in] context The reference to the overall context.
 * \param [in] columns The columns dimension of the convolution.
 * Must be odd and greater than or equal to 3 and less than the value returned
 * from <tt>\ref VX_CONTEXT_CONVOLUTION_MAX_DIMENSION</tt>.
 * \param [in] rows The rows dimension of the convolution.
 * Must be odd and greater than or equal to 3 and less than the value returned
 * from <tt>\ref VX_CONTEXT_CONVOLUTION_MAX_DIMENSION</tt>.
 * \returns A convolution reference <tt>\ref vx_convolution</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_convolution
 */
VX_API_ENTRY vx_convolution VX_API_CALL vxCreateConvolution(vx_context context, vx_size columns, vx_size rows);

/*! \brief Creates an opaque reference to a convolution matrix object without direct user access.
 * \param [in] graph The reference to the parent graph.
 * \param [in] columns The columns dimension of the convolution.
 * Must be odd and greater than or equal to 3 and less than the value returned
 * from <tt>\ref VX_CONTEXT_CONVOLUTION_MAX_DIMENSION</tt>.
 * \param [in] rows The rows dimension of the convolution.
 * Must be odd and greater than or equal to 3 and less than the value returned
 * from <tt>\ref VX_CONTEXT_CONVOLUTION_MAX_DIMENSION</tt>.
 * \see <tt>\ref vxCreateConvolution</tt>
 * \returns A convolution reference <tt>\ref vx_convolution</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_convolution
 */
VX_API_ENTRY vx_convolution VX_API_CALL vxCreateVirtualConvolution(vx_graph graph, vx_size columns, vx_size rows);

/*! \brief Releases the reference to a convolution matrix.
 * The object may not be garbage collected until its total reference count is zero.
 * \param [in] conv The pointer to the convolution matrix to release.
 * \post After returning from this function the reference is zeroed.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE conv is not a valid <tt>\ref vx_convolution</tt> reference.
 * \ingroup group_convolution
 */
VX_API_ENTRY vx_status VX_API_CALL vxReleaseConvolution(vx_convolution *conv);

/*! \brief Queries an attribute on the convolution matrix object.
 * \param [in] conv The convolution matrix object to set.
 * \param [in] attribute The attribute to query. Use a <tt>\ref vx_convolution_attribute_e</tt> enumeration.
 * \param [out] ptr The location at which to store the resulting value.
 * \param [in] size The size in bytes of the container to which \a ptr points.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE conv is not a valid <tt>\ref vx_convolution</tt> reference.
 * \ingroup group_convolution
 */
VX_API_ENTRY vx_status VX_API_CALL vxQueryConvolution(vx_convolution conv, vx_convolution_attribute_e attribute, void *ptr, vx_size size);

/*! \brief Sets attributes on the convolution object.
 * \param [in] conv The coordinates object to set.
 * \param [in] attribute The attribute to modify. Use a <tt>\ref vx_convolution_attribute_e</tt> enumeration.
 * \param [in] ptr The pointer to the value to which to set the attribute.
 * \param [in] size The size in bytes of the data pointed to by \a ptr.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE conv is not a valid <tt>\ref vx_convolution</tt> reference.
 * \ingroup group_convolution
 */
VX_API_ENTRY vx_status VX_API_CALL vxSetConvolutionAttribute(vx_convolution conv, vx_convolution_attribute_e attribute, const void *ptr, vx_size size);

/*! \brief Allows the application to copy coefficients from/into a convolution object.
 * \param [in] conv The reference to the convolution object that is the source or the destination of the copy.
 * \param [in] user_ptr The address of the memory location where to store the requested
 * coefficient data if the copy was requested in read mode, or from where to get the
 * coefficient data to store into the convolution object if the copy was requested in
 * write mode. In the user memory, the convolution coefficient data is structured as a
 * row-major 2D array with elements of the type corresponding
 * to <tt>\ref VX_TYPE_CONVOLUTION</tt>, with a number of rows corresponding to
 * <tt>\ref VX_CONVOLUTION_ROWS</tt> and a number of columns corresponding to
 * <tt>\ref VX_CONVOLUTION_COLUMNS</tt>. The accessible memory must be large
 * enough to contain this 2D array:
 * accessible memory in bytes >= sizeof(data_element) * rows * columns.
 * \param [in] usage This declares the effect of the copy with regard to the convolution object
 * using the <tt>\ref vx_accessor_e</tt> enumeration. Only <tt>\ref VX_READ_ONLY</tt> and <tt>\ref VX_WRITE_ONLY</tt>
 * are supported:
 * \arg <tt>\ref VX_READ_ONLY</tt> means that data are copied from the convolution object into the user memory.
 * \arg <tt>\ref VX_WRITE_ONLY</tt> means that data are copied into the convolution object from the user memory.
 * \param [in] user_mem_type A <tt>\ref vx_memory_type_e</tt> enumeration that specifies
 * the memory type of the memory referenced by the user_addr.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE conv is not a valid <tt>\ref vx_convolution</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 * \ingroup group_convolution
 */
VX_API_ENTRY vx_status VX_API_CALL vxCopyConvolutionCoefficients(vx_convolution conv, void *user_ptr, vx_accessor_e usage, vx_memory_type_e user_mem_type);


/*==============================================================================
 PYRAMID
 =============================================================================*/

/*! \brief Creates a reference to a pyramid object of the supplied number of levels.
 * \param [in] context The reference to the overall context.
 * \param [in] levels The number of levels desired. This is required to be a non-zero value.
 * \param [in] scale Used to indicate the scale between pyramid levels. This is required to be a non-zero positive value.
 * <tt>\ref VX_SCALE_PYRAMID_HALF</tt> and <tt>\ref VX_SCALE_PYRAMID_ORB</tt> must be supported.
 * \param [in] width The width of the 0th level image in pixels.
 * \param [in] height The height of the 0th level image in pixels.
 * \param [in] format The format of all images in the pyramid. NV12, NV21, IYUV, UYVY and YUYV formats are not supported.
 * \returns A pyramid reference <tt>\ref vx_pyramid</tt> containing the sub-images. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_pyramid
 */
VX_API_ENTRY vx_pyramid VX_API_CALL vxCreatePyramid(vx_context context, vx_size levels, vx_float32 scale, vx_uint32 width, vx_uint32 height, vx_df_image format);

/*! \brief Creates a reference to a virtual pyramid object of the supplied number of levels.
 * \details Virtual Pyramids can be used to connect Nodes together when the contents of the pyramids will
 * not be accessed by the user of the API.
 * All of the following constructions are valid:
 * \code
 * vx_context context = vxCreateContext();
 * vx_graph graph = vxCreateGraph(context);
 * vx_pyramid virt[] = {
 *     vxCreateVirtualPyramid(graph, 4, VX_SCALE_PYRAMID_HALF, 0, 0, VX_DF_IMAGE_VIRT), // no dimension and format specified for level 0
 *     vxCreateVirtualPyramid(graph, 4, VX_SCALE_PYRAMID_HALF, 640, 480, VX_DF_IMAGE_VIRT), // no format specified.
 *     vxCreateVirtualPyramid(graph, 4, VX_SCALE_PYRAMID_HALF, 640, 480, VX_DF_IMAGE_U8), // no access
 * };
 * \endcode
 * \param [in] graph The reference to the parent graph.
 * \param [in] levels The number of levels desired. This is required to be a non-zero value.
 * \param [in] scale Used to indicate the scale between pyramid levels. This is required to be a non-zero positive value.
 * <tt>\ref VX_SCALE_PYRAMID_HALF</tt> and <tt>\ref VX_SCALE_PYRAMID_ORB</tt> must be supported.
 * \param [in] width The width of the 0th level image in pixels. This may be set to zero to indicate to the interface that the value is unspecified.
 * \param [in] height The height of the 0th level image in pixels. This may be set to zero to indicate to the interface that the value is unspecified.
 * \param [in] format The format of all images in the pyramid. This may be set to <tt>\ref VX_DF_IMAGE_VIRT</tt> to indicate that the format is unspecified.
 * \returns A pyramid reference <tt>\ref vx_pyramid</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \note Images extracted with <tt>\ref vxGetPyramidLevel</tt> behave as Virtual Images and
 * cause <tt>\ref vxMapImagePatch</tt> to return errors.
 * \ingroup group_pyramid
 */
VX_API_ENTRY vx_pyramid VX_API_CALL vxCreateVirtualPyramid(vx_graph graph, vx_size levels, vx_float32 scale, vx_uint32 width, vx_uint32 height, vx_df_image format);


/*! \brief Releases a reference to a pyramid object.
 * The object may not be garbage collected until its total reference count is zero.
 * \param [in] pyr The pointer to the pyramid to release.
 * \ingroup group_pyramid
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE pyr is not a valid <tt>\ref vx_pyramid</tt> reference.
 * \post After returning from this function the reference is zeroed.
 */
VX_API_ENTRY vx_status VX_API_CALL vxReleasePyramid(vx_pyramid *pyr);

/*! \brief Queries an attribute from an image pyramid.
 * \param [in] pyr The pyramid to query.
 * \param [in] attribute The attribute for which to query. Use a <tt>\ref vx_pyramid_attribute_e</tt> enumeration.
 * \param [out] ptr The location at which to store the resulting value.
 * \param [in] size The size in bytes of the container to which \a ptr points.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE pyr is not a valid <tt>\ref vx_pyramid</tt> reference.
 * \ingroup group_pyramid
 */
VX_API_ENTRY vx_status VX_API_CALL vxQueryPyramid(vx_pyramid pyr, vx_pyramid_attribute_e attribute, void *ptr, vx_size size);

/*! \brief Retrieves a level of the pyramid as a <tt>\ref vx_image</tt>, which can be used
 * elsewhere in OpenVX. A call to vxReleaseImage is necessary to release an image for each
 * call of vxGetPyramidLevel.
 * \param [in] pyr The pyramid object.
 * \param [in] index The index of the level, such that index is less than levels.
 * \return A <tt>\ref vx_image</tt> reference. Any possible errors preventing a successful
 * function completion should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_pyramid
 */
VX_API_ENTRY vx_image VX_API_CALL vxGetPyramidLevel(vx_pyramid pyr, vx_uint32 index);

/*==============================================================================
 REMAP
 =============================================================================*/

/*! \brief Creates a remap table object.
 * \param [in] context The reference to the overall context.
 * \param [in] src_width Width of the source image in pixel.
 * \param [in] src_height Height of the source image in pixels.
 * \param [in] dst_width Width of the destination image in pixels.
 * \param [in] dst_height Height of the destination image in pixels.
 * \ingroup group_remap
 * \returns A remap reference <tt>\ref vx_remap</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_remap VX_API_CALL vxCreateRemap(vx_context context,
                              vx_uint32 src_width,
                              vx_uint32 src_height,
                              vx_uint32 dst_width,
                              vx_uint32 dst_height);

/*! \brief Creates an opaque reference to a remap table object without direct user access.
 * \param [in] graph The reference to the parent graph.
 * \param [in] src_width Width of the source image in pixel.
 * \param [in] src_height Height of the source image in pixels.
 * \param [in] dst_width Width of the destination image in pixels.
 * \param [in] dst_height Height of the destination image in pixels.
 * \see <tt>\ref vxCreateRemap</tt>
 * \ingroup group_remap
 * \returns A remap reference <tt>\ref vx_remap</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 */
VX_API_ENTRY vx_remap VX_API_CALL vxCreateVirtualRemap(vx_graph graph,
                              vx_uint32 src_width,
                              vx_uint32 src_height,
                              vx_uint32 dst_width,
                              vx_uint32 dst_height);

/*! \brief Releases a reference to a remap table object. The object may not be
 * garbage collected until its total reference count is zero.
 * \param [in] table The pointer to the remap table to release.
 * \post After returning from this function the reference is zeroed.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE table is not a valid <tt>\ref vx_remap</tt> reference.
 * \ingroup group_remap
 */
VX_API_ENTRY vx_status VX_API_CALL vxReleaseRemap(vx_remap *table);

/*! \brief Allows the application to get direct access to a rectangular patch of a remap object.
 *
 * The patch is specified within the destination dimensions and its
 * data provide the corresponding coordinate within the source dimensions.
 * The patch is mapped as a 2D array of elements of type <ELEMENT_TYPE>,
 * <ELEMENT_TYPE> being the type associated with the \p coordinate_type parameter
 * (i.e., <tt>\ref vx_coordinates2df_t</tt> for <tt>\ref VX_TYPE_COORDINATES2DF</tt>).
 * The memory layout of the mapped 2D array follows a row-major order where rows are
 * compact (without any gap between elements), and where the potential
 * padding after each lines is determined by (* \p stride_y).
 *
 * \param [in] remap The reference to the remap object that contains the
 * patch to map.
 *
 * \param [in] rect The coordinates of remap patch. The patch must be specified
 * within the bounds of the remap destination dimensions
 * (<tt>\ref VX_REMAP_DESTINATION_WIDTH</tt> x <tt>\ref VX_REMAP_DESTINATION_HEIGHT</tt>).
 * (start_x, start_y) gives the coordinate of the topleft element inside the patch,
 * while (end_x, end_y) gives the coordinate of the bottomright element out of the patch.
 *
 * \param [out] map_id The address of a <tt>\ref vx_map_id</tt> variable
 * where the function returns a map identifier.
 * \arg (*map_id) must eventually be provided as the map_id parameter of a call
 * to <tt>\ref vxUnmapRemapPatch</tt>.
 *
 * \param [out] stride_y The address of a vx_size variable where the function
 * returns the difference between the address of the first element of two
 * successive lines in the mapped remap patch. The stride value follows the
 * following rule :
 * (*stride_y) >= sizeof(<ELEMENT_TYPE>) * (rect->end_x - rect->start_x)
 *
 * \param [out] ptr The address of a pointer where the function returns where
 * remap patch data can be accessed. (*ptr) is the address of the the top-left
 * element of the remap patch.
 * The returned (*ptr) address is only valid between the call to this function
 * and the corresponding call to <tt>\ref vxUnmapRemapPatch</tt>.
 *
 * \param [in] coordinate_type This declares the type of the source coordinate
 * data that the application wants to access in the remap patch.
 * It must be <tt>\ref VX_TYPE_COORDINATES2DF</tt>.
 *
 * \param [in] usage This declares the access mode for the remap patch, using
 * the <tt>\ref vx_accessor_e</tt> enumeration.
 * \arg <tt>\ref VX_READ_ONLY</tt>: after the function call, the content of the
 * memory location pointed by (*ptr) contains the remap patch data. Writing into
 * this memory location is forbidden and its behavior is undefined.
 * \arg <tt>\ref VX_READ_AND_WRITE</tt>: after the function call, the content of
 * the memory location pointed by (*ptr) contains the remap patch data; writing
 * into this memory is allowed for the location of elements only and will
 * result in a modification of the written elements in the remap object once the
 * patch is unmapped. Writing into a gap between element lines
 * (when (*stride_y) > sizeof(<ELEMENT_TYPE>) * (rect->end_x - rect->start_x))
 * is forbidden and its behavior is undefined.
 * \arg <tt>\ref VX_WRITE_ONLY</tt>: after the function call, the memory location
 * pointed by (*ptr) contains undefined data; writing each element of the patch is
 * required prior to unmapping. Elements not written by the application before
 * unmap will become undefined after unmap, even if they were well defined before
 * map. Like for <tt>\ref VX_READ_AND_WRITE</tt>, writing into a gap between
 * element lines is forbidden and its behavior is undefined.
 *
 * \param [in] mem_type A <tt>\ref vx_memory_type_e</tt> enumeration that
 * specifies the type of the memory where the remap patch is requested to be mapped.
 *
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE remap is not a valid <tt>\ref vx_remap</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 *
 * \ingroup group_remap
 * \post <tt>\ref vxUnmapRemapPatch </tt> with same (*map_id) value.
 */
VX_API_ENTRY vx_status VX_API_CALL vxMapRemapPatch(vx_remap remap,
                                                   const vx_rectangle_t *rect,
                                                   vx_map_id *map_id,
                                                   vx_size *stride_y,
                                                   void **ptr,
                                                   vx_type_e coordinate_type,
                                                   vx_accessor_e usage,
                                                   vx_memory_type_e mem_type);

/*! \brief Unmap and commit potential changes to a remap object patch that was previously mapped.
 *
 * Unmapping a remap patch invalidates the memory location from which the patch could
 * be accessed by the application. Accessing this memory location after the unmap function
 * completes has an undefined behavior.
 * \param [in] remap The reference to the remap object to unmap.
 * \param [out] map_id The unique map identifier that was returned by <tt>\ref vxMapRemapPatch</tt> .
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE remap is not a valid <tt>\ref vx_remap</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 * \ingroup group_remap
 * \pre <tt>\ref vxMapRemapPatch</tt> with same map_id value
*/
VX_API_ENTRY vx_status VX_API_CALL vxUnmapRemapPatch(vx_remap remap, vx_map_id map_id);

/*! \brief Allows the application to copy a rectangular patch from/into a remap object.
 *
 * The patch is specified within the destination dimensions and its
 * data provide the corresponding coordinate within the source dimensions.
 * The patch in user memory is a 2D array of elements of type
 * <ELEMENT_TYPE>, <ELEMENT_TYPE> being the type associated with the
 * \p coordinate_type parameter
 * (i.e., <tt>\ref vx_coordinates2df_t</tt> for <tt>\ref VX_TYPE_COORDINATES2DF</tt>).
 * The memory layout of this array follows a row-major order where rows are
 * compact (without any gap between elements), and where the potential padding
 * after each line is determined by the \p user_stride_y parameter.

 * \param [in] remap The reference to the remap object that is the source or the
 * destination of the patch copy.
 *
 * \param [in] rect The coordinates of remap patch. The patch must be specified
 * within the bounds of the remap destination dimensions
 * (<tt>\ref VX_REMAP_DESTINATION_WIDTH</tt> x <tt>\ref VX_REMAP_DESTINATION_HEIGHT</tt>).
 * (start_x, start_y) gives the coordinate of the topleft element inside the patch,
 * while (end_x, end_y) gives the coordinate of the bottomright element out of the patch.
 *
 * \param [in] user_stride_y The difference between the address of the first element
 * of two successive lines of the remap patch in user memory (pointed by
 * \p user_ptr). The layout of the user memory must follow a row major order and user_stride_y
 * must follow the following rule :
 *  user_stride_y >= sizeof(<ELEMENT_TYPE>) * (rect->end_x - rect->start_x).
 *
 * \param [in] user_ptr The address of the user memory location where to store the requested
 * remap data if the copy was requested in read mode, or from where to get the remap data to
 * store into the remap object if the copy was requested in write mode. \p user_ptr is the
 * address of the the top-left element of the remap patch.
 * The accessible user memory must be large enough to contain the specified patch with
 * the specified layout:
 * accessible memory in bytes >= (rect->end_y - rect->start_y) * user_stride_y.
 *
 * \param [in] user_coordinate_type This declares the type of the source coordinate remap
 * data in the user memory. It must be <tt>\ref VX_TYPE_COORDINATES2DF</tt>.
 *
 * \param [in] usage This declares the effect of the copy with regard to the remap object
 * using the <tt>\ref vx_accessor_e</tt> enumeration. Only VX_READ_ONLY and VX_WRITE_ONLY are
 * supported:
 * \arg <tt>\ref VX_READ_ONLY</tt> means that data is copied from the remap object into the user
 * memory pointer by \p user_ptr. The potential padding after each line in user
 * memory will stay unchanged.
 * \arg <tt>\ref VX_WRITE_ONLY</tt> means that data is copied into the remap object from
 * the user memory.
 *
 * \param [in] user_mem_type A <tt>\ref vx_memory_type_e</tt> enumeration that specifies
 * the type of the memory pointer by \p user_ptr.
 *
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE remap is not a valid <tt>\ref vx_remap</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 *
 * \ingroup group_remap
*/
VX_API_ENTRY vx_status VX_API_CALL vxCopyRemapPatch(vx_remap remap,
                                                    const vx_rectangle_t *rect,
                                                    vx_size user_stride_y,
                                                    void * user_ptr,
                                                    vx_type_e user_coordinate_type,
                                                    vx_accessor_e usage,
                                                    vx_memory_type_e user_mem_type);

/*! \brief Queries attributes from a Remap table.
 * \param [in] table The remap to query.
 * \param [in] attribute The attribute to query. Use a <tt>\ref vx_remap_attribute_e</tt> enumeration.
 * \param [out] ptr The location at which to store the resulting value.
 * \param [in] size The size in bytes of the container to which \a ptr points.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE table is not a valid <tt>\ref vx_remap</tt> reference.
 * \ingroup group_remap
 */
VX_API_ENTRY vx_status VX_API_CALL vxQueryRemap(vx_remap table, vx_remap_attribute_e attribute, void *ptr, vx_size size);

/*==============================================================================
 ARRAY
 =============================================================================*/

/*!
 * \brief Creates a reference to an Array object.
 *
 * User must specify the Array capacity (i.e., the maximal number of items that the array can hold).
 *
 * \param [in] context      The reference to the overall Context.
 * \param [in] item_type The type of data to hold. Must be greater than
 * <tt>\ref VX_TYPE_INVALID</tt> and less than or equal to <tt>\ref VX_TYPE_VENDOR_STRUCT_END</tt>.
 * Or must be a <tt>\ref vx_enum</tt> returned from <tt>\ref vxRegisterUserStruct</tt>.
 * \param [in] capacity     The maximal number of items that the array can hold.
 *
 * \returns An array reference <tt>\ref vx_array</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 *
 * \ingroup group_array
 */
VX_API_ENTRY vx_array VX_API_CALL vxCreateArray(vx_context context, vx_type_e item_type, vx_size capacity);

/*!
 * \brief Creates an opaque reference to a virtual Array with no direct user access.
 *
 * Virtual Arrays are useful when item type or capacity are unknown ahead of time
 * and the Array is used as internal graph edge. Virtual arrays are scoped within the parent graph only.
 *
 * All of the following constructions are allowed.
 * \code
 * vx_context context = vxCreateContext();
 * vx_graph graph = vxCreateGraph(context);
 * vx_array virt[] = {
 *     vxCreateVirtualArray(graph, 0, 0), // totally unspecified
 *     vxCreateVirtualArray(graph, VX_TYPE_KEYPOINT, 0), // unspecified capacity
 *     vxCreateVirtualArray(graph, VX_TYPE_KEYPOINT, 1000), // no access
 * };
 * \endcode
 *
 * \param [in] graph        The reference to the parent graph.
 * \param [in] item_type The type of data to hold. Must be greater than
 * <tt>\ref VX_TYPE_INVALID</tt> and less than or equal to <tt>\ref VX_TYPE_VENDOR_STRUCT_END</tt>.
 * Or must be a <tt>\ref vx_enum</tt> returned from <tt>\ref vxRegisterUserStruct</tt>.
 *                          This may to set to zero to indicate an unspecified item type.
 * \param [in] capacity     The maximal number of items that the array can hold.
 *                          This may be to set to zero to indicate an unspecified capacity.
 * \see vxCreateArray for a type list.
 * \returns A array reference <tt>\ref vx_array</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 *
 * \ingroup group_array
 */
VX_API_ENTRY vx_array VX_API_CALL vxCreateVirtualArray(vx_graph graph, vx_type_e item_type, vx_size capacity);

/*!
 * \brief Releases a reference of an Array object.
 * The object may not be garbage collected until its total reference count is zero.
 * After returning from this function the reference is zeroed.
 * \param [in] arr          The pointer to the Array to release.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE arr is not a valid <tt>\ref vx_array</tt> reference.
 * \ingroup group_array
 */
VX_API_ENTRY vx_status VX_API_CALL vxReleaseArray(vx_array *arr);

/*!
 * \brief Queries the Array for some specific information.
 *
 * \param [in] arr          The reference to the Array.
 * \param [in] attribute    The attribute to query. Use a <tt>\ref vx_array_attribute_e</tt>.
 * \param [out] ptr         The location at which to store the resulting value.
 * \param [in] size         The size in bytes of the container to which \a ptr points.
 *
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS                   No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE   arr is not a valid <tt>\ref vx_array</tt> reference.
 * \retval VX_ERROR_NOT_SUPPORTED       If the \a attribute is not a value supported on this implementation.
 * \retval VX_ERROR_INVALID_PARAMETERS  If any of the other parameters are incorrect.
 *
 * \ingroup group_array
 */
VX_API_ENTRY vx_status VX_API_CALL vxQueryArray(vx_array arr, vx_array_attribute_e attribute, void *ptr, vx_size size);

/*!
 * \brief Adds items to the Array.
 *
 * This function increases the container size.
 *
 * By default, the function does not reallocate memory,
 * so if the container is already full (number of elements is equal to capacity)
 * or it doesn't have enough space,
 * the function returns <tt>\ref VX_FAILURE</tt> error code.
 *
 * \param [in] arr          The reference to the Array.
 * \param [in] count        The total number of elements to insert.
 * \param [in] ptr          The location from which to read the input values.
 * \param [in] stride       The number of bytes between the beginning of two consecutive elements.
 *
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS                   No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE   arr is not a valid <tt>\ref vx_array</tt> reference.
 * \retval VX_FAILURE                   If the Array is full.
 * \retval VX_ERROR_INVALID_PARAMETERS  If any of the other parameters are incorrect.
 *
 * \ingroup group_array
 */
VX_API_ENTRY vx_status VX_API_CALL vxAddArrayItems(vx_array arr, vx_size count, const void *ptr, vx_size stride);

/*!
 * \brief Truncates an Array (remove items from the end).
 *
 * \param [in,out] arr          The reference to the Array.
 * \param [in] new_num_items    The new number of items for the Array.
 *
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS                   No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE   arr is not a valid <tt>\ref vx_array</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS  The \a new_size is greater than the current size.
 *
 * \ingroup group_array
 */
VX_API_ENTRY vx_status VX_API_CALL vxTruncateArray(vx_array arr, vx_size new_num_items);

/*! \brief Allows the application to copy a range from/into an array object.
 * \param [in] array The reference to the array object that is the source or the
 * destination of the copy.
 * \param [in] range_start The index of the first item of the array object to copy.
 * \param [in] range_end The index of the item following the last item of the
 * array object to copy. (range_end range_start) items are copied from index
 * range_start included. The range must be within the bounds of the array:
 * 0 <= range_start < range_end <= number of items in the array.
 * \param [in] user_stride The number of bytes between the beginning of two consecutive
 * items in the user memory pointed by user_ptr. The layout of the user memory must
 * follow an item major order:
 * user_stride >= element size in bytes.
 * \param [in] user_ptr The address of the memory location where to store the requested data
 * if the copy was requested in read mode, or from where to get the data to store into the array
 * object if the copy was requested in write mode. The accessible memory must be large enough
 * to contain the specified range with the specified stride:
 * accessible memory in bytes >= (range_end range_start) * user_stride.
 * \param [in] usage This declares the effect of the copy with regard to the array object
 * using the <tt>\ref vx_accessor_e</tt> enumeration. Only <tt>\ref VX_READ_ONLY</tt> and <tt>\ref VX_WRITE_ONLY</tt>
 * are supported:
 * \arg <tt>\ref VX_READ_ONLY</tt> means that data are copied from the array object into the user memory.
 * \arg <tt>\ref VX_WRITE_ONLY</tt> means that data are copied into the array object from the user memory.
 * \param [in] user_mem_type A <tt>\ref vx_memory_type_e</tt> enumeration that specifies
 * the memory type of the memory referenced by the user_addr.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_OPTIMIZED_AWAY This is a reference to a virtual array that cannot be
 * accessed by the application.
 * \retval VX_ERROR_INVALID_REFERENCE array is not a valid <tt>\ref vx_array</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 * \ingroup group_array
 */
VX_API_ENTRY vx_status VX_API_CALL vxCopyArrayRange(vx_array array, vx_size range_start, vx_size range_end, vx_size user_stride, void *user_ptr, vx_accessor_e usage, vx_memory_type_e user_mem_type);

/*! \brief Allows the application to get direct access to a range of an array object.
 * \param [in] array The reference to the array object that contains the range to map.
 * \param [in] range_start The index of the first item of the array object to map.
 * \param [in] range_end The index of the item following the last item of the
 * array object to map. (range_end range_start) items are mapped, starting from index
 * range_start included. The range must be within the bounds of the array:
 * Must be 0 <= range_start < range_end <= number of items.
 * \param [out] map_id The address of a <tt>\ref vx_map_id</tt> variable where the function
 * returns a map identifier.
 * \arg (*map_id) must eventually be provided as the map_id parameter of a call to
 * <tt>\ref vxUnmapArrayRange</tt>.
 * \param [out] stride The address of a vx_size variable where the function
 * returns the memory layout of the mapped array range. The function sets (*stride)
 * to the number of bytes between the beginning of two consecutive items.
 * The application must consult (*stride) to access the array items starting from
 * address (*ptr). The layout of the mapped array follows an item major order:
 * (*stride) >= item size in bytes.
 * \param [out] ptr The address of a pointer that the function sets to the
 * address where the requested data can be accessed. The returned (*ptr) address
 * is only valid between the call to the function and the corresponding call to
 * <tt>\ref vxUnmapArrayRange</tt>.
 * \param [in] usage This declares the access mode for the array range, using
 * the <tt>\ref vx_accessor_e</tt> enumeration.
 * \arg <tt>\ref VX_READ_ONLY</tt>: after the function call, the content of the memory location
 * pointed by (*ptr) contains the array range data. Writing into this memory location
 * is forbidden and its behavior is undefined.
 * \arg <tt>\ref VX_READ_AND_WRITE</tt>: after the function call, the content of the memory
 * location pointed by (*ptr) contains the array range data; writing into this memory
 * is allowed only for the location of items and will result in a modification of the
 * affected items in the array object once the range is unmapped. Writing into
 * a gap between items (when (*stride) > item size in bytes) is forbidden and its
 * behavior is undefined.
 * \arg <tt>\ref VX_WRITE_ONLY</tt>: after the function call, the memory location pointed by (*ptr)
 * contains undefined data; writing each item of the range is required prior to
 * unmapping. Items not written by the application before unmap will become
 * undefined after unmap, even if they were well defined before map. Like for
 * VX_READ_AND_WRITE, writing into a gap between items is forbidden and its behavior
 * is undefined.
 * \param [in] mem_type A <tt>\ref vx_memory_type_e</tt> enumeration that
 * specifies the type of the memory where the array range is requested to be mapped.
 * \param [in] flags An integer that allows passing options to the map operation.
 * Use the <tt>\ref vx_map_flag_e</tt> enumeration.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_OPTIMIZED_AWAY This is a reference to a virtual array that cannot be
 * accessed by the application.
 * \retval VX_ERROR_INVALID_REFERENCE array is not a valid <tt>\ref vx_array</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 * \ingroup group_array
 * \post <tt>\ref vxUnmapArrayRange </tt> with same (*map_id) value.
 */
VX_API_ENTRY vx_status VX_API_CALL vxMapArrayRange(vx_array array, vx_size range_start, vx_size range_end, vx_map_id *map_id, vx_size *stride, void **ptr, vx_accessor_e usage, vx_memory_type_e mem_type, vx_uint32 flags);

/*! \brief Unmap and commit potential changes to an array object range that was previously mapped.
 * Unmapping an array range invalidates the memory location from which the range could
 * be accessed by the application. Accessing this memory location after the unmap function
 * completes has an undefined behavior.
 * \param [in] array The reference to the array object to unmap.
 * \param [out] map_id The unique map identifier that was returned when calling
 * <tt>\ref vxMapArrayRange</tt> .
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE array is not a valid <tt>\ref vx_array</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS An other parameter is incorrect.
 * \ingroup group_array
 * \pre <tt>\ref vxMapArrayRange</tt> returning the same map_id value
 */
VX_API_ENTRY vx_status VX_API_CALL vxUnmapArrayRange(vx_array array, vx_map_id map_id);

/*!
 * \brief Accesses a specific indexed element in an array.
 * \param [in] ptr The base pointer for the array range.
 * \param [in] index The index of the element, not byte, to access.
 * \param [in] stride The 'number of bytes' between the beginning of two consecutive elements.
 * \ingroup group_array
 */
#define vxFormatArrayPointer(ptr, index, stride) \
    (&(((vx_uint8*)(ptr))[(index) * (stride)]))

/*!
 * \brief Allows access to an array item as a typecast pointer deference.
 * \param [in] type The type of the item to access.
 * \param [in] ptr The base pointer for the array range.
 * \param [in] index The index of the element, not byte, to access.
 * \param [in] stride The 'number of bytes' between the beginning of two consecutive elements.
 * \ingroup group_array
 */
#define vxArrayItem(type, ptr, index, stride) \
    (*(type *)(vxFormatArrayPointer((ptr), (index), (stride))))


/*==============================================================================
 OBJECT ARRAY
 =============================================================================*/
/*!
 * \brief Creates a reference to an ObjectArray of count objects.
 *
 * It uses the metadata of the exemplar to determine the object attributes,
 * ignoring the object data. It does not alter the exemplar or keep or release
 * the reference to the exemplar. For the definition of supported attributes see
 * <tt>\ref vxSetMetaFormatAttribute</tt>. In case the exemplar is a virtual object
 * it must be of immutable metadata, thus it is not allowed to be dimensionless or formatless.
 *
 * \param [in] context      The reference to the overall Context.
 * \param [in] exemplar     The exemplar object that defines the metadata of the created objects in the ObjectArray.
 * \param [in] count        Number of Objects to create in the ObjectArray.
 *
 * \returns An ObjectArray reference <tt>\ref vx_object_array</tt>. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>. Data objects are not initialized by this function.
 *
 * \ingroup group_object_array
 */
VX_API_ENTRY vx_object_array VX_API_CALL vxCreateObjectArray(vx_context context, vx_reference exemplar, vx_size count);

/*!
 * \brief Creates an opaque reference to a virtual ObjectArray with no direct user access.
 *
 * This function creates an ObjectArray of count objects with similar behavior as
 * <tt>\ref vxCreateObjectArray</tt>. The only difference is that the objects that are
 * created are virtual in the given graph.
 *
 * \param [in] graph      Reference to the graph where to create the virtual ObjectArray.
 * \param [in] exemplar   The exemplar object that defines the type of object in the ObjectArray.
 *                        Only exemplar type of <tt>\ref vx_image</tt>, <tt>\ref vx_array</tt> and
 *                        <tt>\ref vx_pyramid</tt> are allowed.
 * \param [in] count      Number of Objects to create in the ObjectArray.
 * \returns               A ObjectArray reference <tt>\ref vx_object_array</tt>. Any possible errors preventing a
 *                        successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_object_array
 */
VX_API_ENTRY vx_object_array VX_API_CALL vxCreateVirtualObjectArray(vx_graph graph, vx_reference exemplar, vx_size count);

/*!
 * \brief                 Retrieves the reference to the OpenVX Object in location index of the ObjectArray.
 *
 * This is a vx_reference, which can be used elsewhere in OpenVX. A call to vxRelease<Object> or <tt>\ref vxReleaseReference</tt>
 * is necessary to release the Object for each call to this function.
 *
 * \param [in] arr       The ObjectArray.
 * \param [in] index     The index of the object in the ObjectArray.
 * \return A reference to an OpenVX data object. Any possible errors preventing a successful
 * completion of the function should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_object_array
 */
VX_API_ENTRY vx_reference VX_API_CALL vxGetObjectArrayItem(vx_object_array arr, vx_uint32 index);

/*!
 * \brief Releases a reference of an ObjectArray object.
 *
 * The object may not be garbage collected until its total reference and its contained objects
 * count is zero. After returning from this function the reference is zeroed/cleared.
 *
 * \param [in] arr          The pointer to the ObjectArray to release.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE arr is not a valid <tt>\ref vx_object_array</tt> reference.
 * \ingroup group_object_array
 */
VX_API_ENTRY vx_status VX_API_CALL vxReleaseObjectArray(vx_object_array *arr);

/*!
 * \brief Queries an atribute from the ObjectArray.
 *
 * \param [in] arr          The reference to the ObjectArray.
 * \param [in] attribute    The attribute to query. Use a <tt>\ref vx_object_array_attribute_e</tt>.
 * \param [out] ptr         The location at which to store the resulting value.
 * \param [in] size         The size in bytes of the container to which \a ptr points.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS                   No errors; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE   arr is not a valid <tt>\ref vx_object_array</tt> reference.
 * \retval VX_ERROR_NOT_SUPPORTED       If the \a attribute is not a value supported on this implementation.
 * \retval VX_ERROR_INVALID_PARAMETERS  If any of the other parameters are incorrect.
 *
 * \ingroup group_object_array
 */
VX_API_ENTRY vx_status VX_API_CALL vxQueryObjectArray(vx_object_array arr, vx_object_array_attribute_e attribute, void *ptr, vx_size size);


/*==============================================================================
 META FORMAT
 =============================================================================*/

/*! \brief This function allows a user to set the attributes of a <tt>\ref vx_meta_format</tt> object in a kernel output validator.
 *
 * The \ref vx_meta_format object contains two types of information: data object meta data and
 * some specific information that defines how the valid region of an image changes
 *
 * The meta data attributes that can be set are identified by this list:
 * - \ref vx_image : \ref VX_IMAGE_FORMAT, \ref VX_IMAGE_HEIGHT, \ref VX_IMAGE_WIDTH
 * - \ref vx_array : \ref VX_ARRAY_CAPACITY, \ref VX_ARRAY_ITEMTYPE
 * - \ref vx_pyramid : \ref VX_PYRAMID_FORMAT, \ref VX_PYRAMID_HEIGHT, \ref VX_PYRAMID_WIDTH, \ref VX_PYRAMID_LEVELS, \ref VX_PYRAMID_SCALE
 * - \ref vx_scalar : \ref VX_SCALAR_TYPE
 * - \ref vx_matrix : \ref VX_MATRIX_TYPE, \ref VX_MATRIX_ROWS, \ref VX_MATRIX_COLUMNS
 * - \ref vx_distribution : \ref VX_DISTRIBUTION_BINS, \ref VX_DISTRIBUTION_OFFSET, \ref VX_DISTRIBUTION_RANGE
 * - \ref vx_remap : \ref VX_REMAP_SOURCE_WIDTH, \ref VX_REMAP_SOURCE_HEIGHT, \ref VX_REMAP_DESTINATION_WIDTH, \ref VX_REMAP_DESTINATION_HEIGHT
 * - \ref vx_lut : \ref VX_LUT_TYPE, \ref VX_LUT_COUNT
 * - \ref vx_threshold : \ref VX_THRESHOLD_TYPE, \ref VX_THRESHOLD_DATA_TYPE
 * - \ref vx_object_array : \ref VX_OBJECT_ARRAY_NUMITEMS, \ref VX_OBJECT_ARRAY_ITEMTYPE
 * - \ref vx_tensor : \ref VX_TENSOR_NUMBER_OF_DIMS, \ref VX_TENSOR_DIMS, \ref VX_TENSOR_DATA_TYPE, \ref VX_TENSOR_FIXED_POINT_POSITION
 * - \ref VX_VALID_RECT_CALLBACK
 * \note For vx_image, a specific attribute can be used to specify the valid region evolution. This information is not a meta data.
 *
 * \param [in] meta The reference to the \ref vx_meta_format struct to set
 * \param [in] attribute Use the subset of data object attributes that define the meta data of this object or attributes from <tt>\ref vx_meta_format</tt>.
 * \param [in] ptr The input pointer of the value to set on the meta format object.
 * \param [in] size The size in bytes of the object to which \a ptr points.
 * \ingroup group_user_kernels
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS The attribute was set; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE meta is not a valid <tt>\ref vx_meta_format</tt> reference.
 * \retval VX_ERROR_INVALID_PARAMETERS size was not correct for the type needed.
 * \retval VX_ERROR_NOT_SUPPORTED the object attribute was not supported on the meta format object.
 * \retval VX_ERROR_INVALID_TYPE attribute type did not match known meta format type.
 */
VX_API_ENTRY vx_status VX_API_CALL vxSetMetaFormatAttribute(vx_meta_format meta, vx_enum attribute, const void *ptr, vx_size size);

/*! \brief Set a meta format object from an exemplar data object reference
 *
 * This function sets a \ref vx_meta_format object from the meta data of the exemplar
 *
 * \param [in] meta The meta format object to set
 * \param [in] exemplar The exemplar data object.
 * \ingroup group_user_kernels
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS The meta format was correctly set; any other value indicates failure.
 * \retval VX_ERROR_INVALID_REFERENCE meta is not a valid <tt>\ref vx_meta_format</tt> reference,
 * or exemplar is not a valid <tt>\ref vx_reference</tt> reference.
 */
VX_API_ENTRY vx_status VX_API_CALL vxSetMetaFormatFromReference(vx_meta_format meta, vx_reference exemplar);
/*==============================================================================
    TENSOR DATA FUNCTIONS
=============================================================================*/
/*! \brief Creates an opaque reference to a tensor data buffer.
 * \details Not guaranteed to exist until the <tt>\ref vx_graph</tt> containing it has been verified.
 * Since functions using tensors, need to understand the context of each dimension. We describe a layout of the dimensions in each function using tensors.
 * That layout is not mandatory. It is done specifically to explain the functions and not to mandate layout. Different implementation may have different layout.
 * Therefore the layout description is logical and not physical. It refers to the order of dimensions given in this function.
 * \param [in] context The reference to the implementation context.
 * \param [in] number_of_dimensions The number of dimensions.
 * \param [in] dimensions Dimensions sizes in elements.
 * \param [in] data_type The <tt>\ref vx_type_t</tt> that represents the data type of the tensor data elements. 
 * \param [in] fixed_point_position Specifies the fixed point position when the input element type is integer. if 0, calculations are performed in integer math.
 * \return A tensor data reference. Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_object_tensor
 */
VX_API_ENTRY vx_tensor VX_API_CALL vxCreateTensor(vx_context context, vx_size number_of_dims, const vx_size * dims, vx_type_e data_type, vx_int8 fixed_point_position);

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
 * \ingroup group_object_tensor
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
 * \ingroup group_object_tensor
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
 * Since functions using tensors, need to understand the context of each dimension. We describe a layout of the dimensions in each function.
 * That layout is not mandated. It is done specifically to explain the functions and not to mandate layout. Different implementation may have different layout.
 * Therfore the layout description is logical and not physical. It refers to the order of dimensions given in <tt>\ref vxCreateTensor</tt> and <tt>\ref vxCreateVirtualTensor</tt>.
 * \param [in] graph The reference to the parent graph.
 * \param [in] number_of_dimensions The number of dimensions.
 * \param [in] dimensions Dimensions sizes in elements.
 * \param [in] data_type The <tt>\ref vx_type_e</tt> that represents the data type of the tensor data elements.
 * \param [in] fixed_point_position Specifies the fixed point position when the input element type is integer. If 0, calculations are performed in integer math.
 * \return A tensor data reference.Any possible errors preventing a
 * successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \note Passing this reference to <tt>\ref vxCopyTensorPatch</tt> will return an error.
 * \ingroup group_object_tensor
 */
VX_API_ENTRY vx_tensor VX_API_CALL vxCreateVirtualTensor(vx_graph graph, vx_size number_of_dims, vx_size *dims, vx_type_e data_type, vx_int8 fixed_point_position);


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
 * using the <tt>\ref vx_accessor_e</tt> enumeration. Only <tt>\ref VX_READ_ONLY</tt> and <tt>\ref VX_WRITE_ONLY</tt> are supported:
 * \arg <tt>\ref VX_READ_ONLY</tt> means that data is copied from the tensor object into the application memory
 * \arg <tt>\ref VX_WRITE_ONLY</tt> means that data is copied into the tensor object from the application memory
 * \param [in] user_memory_type A <tt>\ref vx_memory_type_e</tt> enumeration that specifies
 * the memory type of the memory referenced by the user_addr.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval <tt>\ref VX_ERROR_OPTIMIZED_AWAY</tt> This is a reference to a virtual tensor that cannot be
 * accessed by the application.
 * \retval <tt>\ref VX_ERROR_INVALID_REFERENCE</tt> The tensor reference is not actually an tensor reference.
 * \retval <tt>\ref VX_ERROR_INVALID_PARAMETERS</tt> An other parameter is incorrect.
 * \ingroup group_object_tensor
 */
VX_API_ENTRY vx_status VX_API_CALL vxCopyTensorPatch(vx_tensor tensor, vx_size number_of_dims, const vx_size * view_start, const vx_size * view_end,
        const vx_size * user_stride, void * user_ptr, vx_accessor_e usage, vx_memory_type_e user_memory_type);

/*! \brief Retrieves various attributes of a tensor data.
 * \param [in] tensor The reference to the tensor data to query.
 * \param [in] attribute The attribute to query. Use a <tt>\ref vx_tensor_attribute_e</tt>.
 * \param [out] ptr The location at which to store the resulting value.
 * \param [in] size The size of the container to which \a ptr points.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval <tt>\ref VX_SUCCESS</tt> No errors.
 * \retval <tt>\ref VX_ERROR_INVALID_REFERENCE</tt> If data is not a <tt>\ref vx_tensor</tt>.
 * \retval <tt>\ref VX_ERROR_INVALID_PARAMETERS</tt> If any of the other parameters are incorrect.
 * \ingroup group_object_tensor
 */
VX_API_ENTRY vx_status VX_API_CALL vxQueryTensor(vx_tensor tensor, vx_tensor_attribute_e attribute, void *ptr, vx_size size);

/*! \brief Releases a reference to a tensor data object.
 * The object may not be garbage collected until its total reference count is zero.
 * \param [in] tensor The pointer to the tensor data to release.
 * \post After returning from this function the reference is zeroed.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval <tt>\ref VX_SUCCESS</tt> No errors; all other values indicate failure
 * \retval * An error occurred. See <tt\ref >vx_status_e</tt>.
 * \ingroup group_object_tensor
 */
VX_API_ENTRY vx_status VX_API_CALL vxReleaseTensor(vx_tensor *tensor);

#ifdef  __cplusplus
}
#endif

#endif
