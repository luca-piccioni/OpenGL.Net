/* Copyright (c) 2009 The Khronos Group Inc.
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
 * THE MATERIALS ARE PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
 * IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
 * CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
 * TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
 * MATERIALS OR THE USE OR OTHER DEALINGS IN THE MATERIALS.
 */

/*! \ingroup wfd
 *  \file wfdext.h
 *
 *  \brief Header file for defining available extension on a platform
 *
 *  See OpenWF specification for usage of this header file.
 */

#ifndef WFDEXT_H_
#define WFDEXT_H_

#ifdef __cplusplus
extern "C" {
#endif


/*!
 * \brief Vendor, renderer and version strings
 *
 *
 */
static const char* wfd_strings[] =
{
        "Ardites",
        "Sample Implementation",
        "1.0",
};

#define WFD_VENDOR_INDEX        (0)
#define WFD_RENDERER_INDEX      (1)
#define WFD_VERSION_INDEX       (2)

/*!
 * \brief Names of the supported extensions
 *
 * This array can be dynamically loaded by the wfd
 * during set-up. Implementation depends on how
 * dynamic loading of extension is done on
 * the platform in question.
 *
 * If extensions are static, the array can be
 * statically initialized in the header file.
 *
 * In both cases the implementator must take care
 * that the array IS ALWAYS null-terminated.
 */

static const char* wfd_extensions[] =
{
     /* wfdSampleExtensionName, */
     NULL
};

/*
 * Static extension declarations
 */

 #ifdef WFD_EXT_SampleExtension
    WFD_API_CALL void WFD_APIENTRY
    wfdSampleExtensionFunc() WFD_API_EXIT;
 #endif

#ifdef __cplusplus
}
#endif


#endif /* WFDEXT_H_ */
