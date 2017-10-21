/*
 * Copyright (c) 2016-2017 The Khronos Group Inc.
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

/*! \file
 * \defgroup group_icd OpenVX ICD Loader API
 * \brief The OpenVX Installable Client Driver (ICD) Loader API.
 * \details The vx_khr_icd extension provides a mechanism for vendors to implement Installable Client Driver (ICD) for OpenVX. The OpenVX ICD Loader API provides a mechanism for applications to access these vendor implementations.
 */

#ifndef _VX_KHR_ICD_H_
#define _VX_KHR_ICD_H_

#include <VX/vx.h>
#include <VX/vxu.h>

/*! \brief Platform handle of an implementation.
 *  \ingroup group_icd
 */
typedef struct _vx_platform * vx_platform;

#ifdef __cplusplus
extern "C" {
#endif

/*! \brief Queries list of available platforms.
 * \param [in] capacity Maximum number of items that platform[] can hold.
 * \param [out] platform[] List of platform handles.
 * \param [out] pNumItems Number of platform handles returned.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors.
 * \retval VX_FAILURE If no platforms are found.
 * \ingroup group_icd
 */
vx_status VX_API_CALL vxIcdGetPlatforms(vx_size capacity, vx_platform platform[], vx_size * pNumItems);

/*! \brief Queries the platform for some specific information.
 * \param [in] platform The platform handle.
 * \param [in] attribute The attribute to query. Use one of the following:
 *               <tt>\ref VX_CONTEXT_VENDOR_ID</tt>,
 *               <tt>\ref VX_CONTEXT_VERSION</tt>,
 *               <tt>\ref VX_CONTEXT_EXTENSIONS_SIZE</tt>,
 *               <tt>\ref VX_CONTEXT_EXTENSIONS</tt>.
 * \param [out] ptr The location at which to store the resulting value.
 * \param [in] size The size in bytes of the container to which \a ptr points.
 * \return A <tt>\ref vx_status_e</tt> enumeration.
 * \retval VX_SUCCESS No errors.
 * \retval VX_ERROR_INVALID_REFERENCE If the platform is not a <tt>\ref vx_platform</tt>.
 * \retval VX_ERROR_INVALID_PARAMETERS If any of the other parameters are incorrect.
 * \retval VX_ERROR_NOT_SUPPORTED If the attribute is not supported on this implementation.
 * \ingroup group_icd
 */
vx_status VX_API_CALL vxQueryPlatform(vx_platform platform, vx_enum attribute, void *ptr, vx_size size);

/*! \brief Creates a <tt>\ref vx_context</tt> from a <tt>\ref vx_platform</tt>.
 * \details This creates a top-level object context for OpenVX from a platform handle.
 * \returns The reference to the implementation context <tt>\ref vx_context</tt>. Any possible errors
 * preventing a successful creation should be checked using <tt>\ref vxGetStatus</tt>.
 * \ingroup group_icd
 */
vx_context VX_API_CALL vxCreateContextFromPlatform(vx_platform platform);

#ifdef __cplusplus
}
#endif

#endif
