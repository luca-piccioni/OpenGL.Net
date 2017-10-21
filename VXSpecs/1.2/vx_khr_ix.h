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
#ifndef _OPENVX_IMPORT_EXPORT_H_
#define _OPENVX_IMPORT_EXPORT_H_
/*!
 * \file
 * \brief The OpenVX Export and Import extension API.
 */
 
#define OPENVX_KHR_IX  "vx_khr_ix"
 
#include <VX/vx_import.h>
/*=============================================================================
Export to host memory
=============================================================================*/
/*! \brief Exports selected objects to memory in a vendor-specific format.\n
 *
 * \details A list of references in the given context is supplied to this function, and all information
 * required to re-create these is stored in memory in such a way that those objects may be re-created
 * with the corresponding import function, according to the usage specified by the *uses* parameter[*REQ*].\n
 * The information must be context independent in that it may be written to external storage for later
 * retreival with another instantiation of a compatible implementation[*REQ*].\n
 * The list of objects to export may contain only valid references (i.e. vxGetStatus() will return VX_SUCCESS)
 * to vx_graph and non-virtual data objects or the function will fail[*REQ*].
 * (Specifically not vx_context, vx_import, vx_node, vx_kernel, vx_parameter or vx_meta_format)\n
 * Some node creation functions take C parameters rather than OpenVX data objects (such as the *gradient_size*
 * parameter of <tt>\ref vxHarrisCornersNode</tt> that is provided as a vx_int32), because these are intended
 * to be fixed at node creation time; nevertheless OpenVX data objects may be assigned to them, for example if
 * the <tt>\ref vxCreateGenericNode</tt> API is used.
 * A data object corresponding to a node parameter that is intended to be fixed at node creation time must not be
 * in the list of exported objects nor attached as a graph parameter or the export operation will fail[*REQ*].\n
 * The *uses* array specifies how the objects in the corresponding *refs* array will be exported. A data object
 * will always have its meta-data (e.g. dimensions and format of an image) exported, and optionally
 * may have its data (e.g. pixel values) exported, and additionally you can decide whether the importing
 * application will create data objects to replace those attached to graphs, or if the implementation will
 * automatically create them:
 * - <tt>\ref VX_IX_USE_APPLICATION_CREATE</tt> \n
 * Export sufficient data to check that an application-supplied
 * object is compatible when the data is later imported[*REQ*].
 * \note This value must be given for images created from handles, or the the export operation
 * will fail[*REQ*]
 * - <tt>\ref VX_IX_USE_EXPORT_VALUES</tt>\n
 * Export complete information (for example image data or value of a
 * scalar)[*REQ*].
 * - <tt>\ref VX_IX_USE_NO_EXPORT_VALUES</tt>\n
 * Export meta-data only; the importing application will set values
 * as applicable[*REQ*]
 * 
 * The values in *uses* are applicable only for data objects and are ignored for vx_graph objects[*REQ*].\n
 * If the list *refs* contains vx_graph objects, these graphs will be verified during the export operation and the export operation will fail if verification fails; when successfully exported graphs are subsequently imported they will appear as verified [*REQ*].\n
 * \note The implementation may also choose to re-verify any previously verified graphs and apply
 * optimisations based upon which references are to be exported and how.\n
 * Any data objects attached to a graph that are hidden, i.e. their references are not in the list *refs*,
 * may be treated by the implementation as virtual objects, since they can never be visible when the graph is
 * subsequently imported.\n
 * Note that imported graphs cannot become unverified.  Attempts to change the
 * graph that might normally cause the graph to be unverified, e.g. calling
 * vxSetGraphParameterByIndex with an object with different metadata, will fail.\n
 * The implementation should make sure that all permissible changes of exported objects are possible
 * without re-verification. For example:
 * - A uniform image may be swapped for a non-uniform image, so corresponding optimisations should be
 * inhibited if a uniform image appears in the *refs* list
 * - An image that is a region of interest of another image may be similarly replaced by any other image of
 * matching size and format, and vice-versa
 *
 * If a graph is exported that has delays registered for auto-aging, then this information is also
 * exported[*REQ*].\n
 * If the function is called with NULL for any of its parameters, this is an error [*REQ*].\n
 * The reference counts of objects as visible to the calling application will not be affected
 * by calling this function [*REQ*].\n
 * The export operation will fail if more than one object whose reference is listed at *refs*
 * has been given the same non-zero length name (via <tt>\ref vxSetReferenceName</tt>)[*REQ*].\n
 * If a graph listed for export has any graph parameters not listed at *refs*, then the
 * export operation will fail[*REQ*].
 * \note The order of the references supplied in the *refs* array will be the order in which the
 * framwork will supply references for the corresponding import operation with <tt>\ref vxImportObjectsFromMemory</tt>.\n
 * The same length of *uses* array, containing the same values, and the same value of *numrefs*, must be supplied 
 * for the corresponding import operation.
 *
 * For objects not listed in *refs*, the following rules apply:
 * 1. In any one graph, if an object is not connected as an output of a node in a graph being exported
 * then its data values will be exported (for subsequent import)[*REQ*].
 * 2. Where the object in (1) is a composite object (such as a pyramid) then rule (1) applies to
 * all of its sub-objects[*REQ*].
 * 3. Where the object in (1) is a sub-object such as a region of interest, and the composite object
 * (in this case the parent image) does not meet the conditions of rule (1), then rule (1) applies
 * to the sub-object only[*REQ*].
 * \param [in] context context from which to export objects, must be valid [*REQ*].
 * \param [in] numrefs number of references to export [*REQ*].
 * \param [in] refs references to export. This is an array of length numrefs populated with
 * the references to export[*REQ*].
 * \param [in] uses how to export the references. This is an array of length numrefs containing
 * values as described above[*REQ*].
 * \param [out] ptr returns pointer to binary buffer. On error this is set to NULL[*REQ*].
 * \param [out] length number of bytes at \*ptr. On error this is set to zero[*REQ*].
 * \return A <tt>\ref vx_status</tt> value.
 * \retval VX_SUCCESS If no errors occurred and the objects were sucessfully exported[*REQ*].
 * An error is indicated when the return value is not VX_SUCCESS.\n
 * An implementation may provide several different return values to give useful diagnostic
 * information in the event of failure to export, but these are not required to indicate
 * possible recovery mechanisms, and for safety critical use assume errors are not recoverable.
 * \post <tt>\ref vxReleaseExportedMemory</tt> is used to deallocate the memory.
 * \ingroup group_import
 */
VX_API_ENTRY vx_status VX_API_CALL vxExportObjectsToMemory(
    vx_context context,         
    vx_size numrefs,            
    const vx_reference *refs,   
    const vx_enum * uses,       
    const vx_uint8 ** ptr,      
    vx_size * length);          
/*! \brief Releases memory allocated for a binary export when it is no longer required.
 * \details This function releases memory allocated by <tt>\ref vxExportObjectsToMemory</tt>[*REQ*].
 * \param [in] context The context for which <tt>\ref vxExportObjectsToMemory</tt> was called[*REQ*].
 * \param [in,out] ptr A pointer previously set by calling <tt>\ref vxExportObjectsToMemory</tt>[*REQ*].
 * The function will fail if <code>*ptr</code> does not contain an address of memory previously
 * allocated by <tt>\ref vxExportObjectsToMemory</tt>[*REQ*].
 * \post After returning from sucessfully from this function \*ptr is set to NULL[*REQ*].
 * \return A <tt>\ref vx_status</tt> value.
 * \retval VX_SUCCESS If no errors occurred and the memory was sucessfully released[*REQ*].\n
 * An error is indicated when the return value is not VX_SUCCESS[*REQ*].\n
 * An implementation may provide several different return values to give useful diagnostic
 * information in the event of failure to export, but these are not required to indicate
 * possible recovery mechanisms, and for safety critical use assume errors are not recoverable.
 * \pre <tt>\ref vxExportObjectsToMemory</tt> is used to allocate the memory.
 * \ingroup group_import
 */
VX_API_ENTRY vx_status VX_API_CALL vxReleaseExportedMemory(
    vx_context context, const vx_uint8 ** ptr);
#endif
