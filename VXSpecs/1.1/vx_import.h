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
#ifndef _OPENVX_IMPORT_H_
#define _OPENVX_IMPORT_H_
/*!
 * \file
 * \brief The OpenVX Import API
 * part of the OpenVX Export and Import extension API
 * and also part of the OpenVX SC deployment feature set.
 */
 
 /*! \brief An enumeration of export uses. See <tt>\ref vxExportObjectsToMemory</tt> and
 * <tt>\ref vxImportObjectsFromMemory</tt>
 * \ingroup vx_enum_e
 */
#define VX_ENUM_IX_USE      0x18
/*! \brief How to export and import an object
 * \ingroup group_import
 */
#define VX_IX_USE_APPLICATION_CREATE (VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_IX_USE) + 0x0) /*!< \brief The application will create the object before import. */
/*! \brief How to export and import an object
 * \ingroup group_import
 */
#define VX_IX_USE_EXPORT_VALUES (VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_IX_USE) + 0x1) /*!< \brief Data values are exported and restored upon import. */
/*! \brief How to export and import an object
 * \ingroup group_import
 */
#define VX_IX_USE_NO_EXPORT_VALUES (VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_IX_USE) + 0x2) /*!< \brief Data values are not exported. */

/*=============================================================================
IMPORT
=============================================================================*/
/*! \brief The Import Object. Import is a container of OpenVX objects, which may be retreived
 * by name
 * \ingroup group_import
 */
typedef struct _vx_import *vx_import;

/*! \brief The Object Type Enumeration for import.
 * \ingroup group_import
 */

#define VX_TYPE_IMPORT          0x814/*!< \brief A <tt>\ref vx_import</tt>. */

/*! \brief Imports objects into a context from a vendor-specific format in memory.\n
 *
 * \details This function imports objects from a memory blob previously created using <tt>\ref vxExportObjectsToMemory</tt>[*REQ*].\n
 * A pointer to memory is given where a list of references is stored, together with the list
 * of uses which describes how the references are used. The number of references given and the
 * list of uses must match that given upon export, or this function will not be sucessful[*REQ*].\n
 * The *uses* array specifies how the objects in the corresponding *refs* array will be imported:
 * - <tt>\ref VX_IX_USE_APPLICATION_CREATE</tt>\n
 * The application must create the object and supply the reference; the
 *  meta-data of the object must match exactly the meta-data of the object when it was exported,
 *  except that the name need not match[*REQ*].\n
 *  If the supplied reference has a different name to that stored, the supplied name is used[*REQ*].
 * - <tt>\ref VX_IX_USE_EXPORT_VALUES</tt>\n
 * The implementation will create the object and set the data in it[*REQ*].\n
 * Any data not defined at the time of export of the object will be set to a default value (zero in the
 * absence of any other definition) upon import[*REQ*].
 * - <tt>\ref VX_IX_USE_NO_EXPORT_VALUES</tt>\n
 * The implementation will create the object and the importing application will set values as applicable[*REQ*].
 *
 * References are obtained from the import API for those objects whose references were listed at the time of export.
 * These are not the same objects; they are equivalent objects created by the framework at import time.
 * The implementation guarantees that references will be available and valid for all objects listed at the time
 * of export, or the import will fail[*REQ*].\n
 * The import operation will fail if more than one object whose reference is listed at *refs*
 * has been given the same non-zero length name (via <tt>\ref vxSetReferenceName</tt>)[*REQ*].\n
 * The import will be unsuccessful if any of the parameters supplied is NULL[*REQ*].\n
 * After completion of the function the memory at *ptr* may be deallocated by the application as it will
 * not be used by any of the created objects[*REQ*].\n
 * Any delays imported with graphs for which they are registered for auto-aging remain registered
 * for auto-aging[*REQ*].\n
 * After import, a graph must execute with exactly the same effect with respect to its visible parameters
 * as before export[*REQ*].
 * \note The *refs* array must be the correct length to hold all references of the import; this will be the same length
 * that was supplied at the time of export. Only references for objects created by the application, where the
 * corresponding *uses* entry is <tt>\ref VX_IX_USE_APPLICATION_CREATE</tt> should be filled in by the application;
 * all other entries will be supplied by the framework and may be initialised by the application to NULL. The *uses* array
 * must have the identical length and content as given at the time of export, and the value of *numrefs* must also match;
 * these measures increase confidence that the import contains the correct data.
* \note Graph parameters may be changed after import by using the <tt>\ref vxSetGraphParameterByIndex</tt> API, and 
 * images may also be changed by using the <tt>\ref vxSwapImageHandle</tt> API.
 * When <tt>\ref vxSetGraphParameterByIndex</tt> is used, the framework will check that the new parameter is of the
 * correct type to run with the graph, which cannot be re-verified. If the reference supplied is not suitable, an error
 * will be returned, but there may be circumstances where changing graph parameters for unsuitable ones is not detected
 * and could lead to implementation-dependent behaviour; one such circumstance is when the new parameters are images
 * corresponding to overlapping regions of interest. The user should avoid these circumstances.
 * In other words,
 *  - The meta data of the new graph parameter must match the meta data of the graph parameter it replaces [*REQ*].
 *  - A graph parameter must not be NULL [*REQ*].
 * \param [in] context context into which to import objects, must be valid [*REQ*].
 * \param [in] numrefs number of references to import, must match export[*REQ*].
 * \param [in,out] refs references imported or application-created data which must match
 * meta-data of the export[*REQ*]
 * \param [in] uses how to import the references, must match export values[*REQ*]
 * \param [in] ptr pointer to binary buffer containing a valid binary export[*REQ*]
 * \param [in] length number of bytes at \*ptr, i.e. the length of the export[*REQ*]
 * \return A <tt>\ref vx_import</tt>[*REQ*].
 * Calling <tt>\ref vxGetStatus</tt> with the vx_import as a parameter will return VX_SUCCESS if the
 * function was successful[*REQ*].\n
 * Another value is given to indicate that there was an error[*REQ*].\n
 * An implementation may provide several different error codes to give useful diagnostic information
 * in the event of failure to import objects, but these are not required to indicate
 * possibly recovery mechanisms, and for safety critical use assume errors are not recoverable.
 * \post <tt>\ref vxReleaseImport</tt> is used to release the import object.
 * \post Use <tt>\ref vxReleaseReference</tt> or an appropriate specific release function to release
 * the references in the array refs when they are no longer required.
 * \ingroup group_import
 */
VX_API_ENTRY vx_import VX_API_CALL vxImportObjectsFromMemory(
    vx_context context,  
    vx_size numrefs,     
    vx_reference *refs,  
    const vx_enum * uses,
    const vx_uint8 * ptr,
    vx_size length);    

/*! \brief Releases an import object when no longer required.\n
 * \details This function releases the reference to the import object [*REQ*].\n
 * Other objects including those imported at the time of creation of the import object are unaffected[*REQ*].\n
 * \param [in,out] import The pointer to the reference to the import object[*REQ*].
 * \post After returning sucessfully from this function the reference is zeroed[*REQ*].
 * \return A <tt>\ref vx_status</tt> value.
 * \retval VX_SUCCESS If no errors occurred and the import was sucessfully released[*REQ*].\n
 * An error is indicated when the return value is not VX_SUCCESS[*REQ*].\n
 * An implementation may provide several different return values to give useful diagnostic
 * information in the event of failure to export, but these are not required to indicate
 * possibly recovery mechanisms, and for safety critical use assume errors are not recoverable.
 * \pre <tt>\ref vxImportObjectsFromMemory</tt> is used to create an import object.
 * \ingroup group_import
 */
VX_API_ENTRY vx_status VX_API_CALL vxReleaseImport(vx_import *import);
/*! \brief Get a reference from the import object by name.\n
 *
 * \details All accessible references of the import object created using <tt>\ref vxImportObjectsFromMemory</tt> are
 * in the array *refs*, which is populated partly by the application before import, and partly by the
 * framework. However, it may be more convenient to access the references in the import object without
 * referring to this array, for example if the import object is passed as a parameter to another function.
 * In this case, references may be retreived by name, assuming that <tt>\ref vxSetReferenceName</tt>
 * was called to assign a name to the reference.
 * This function searches the given import for the given name and returns the associated reference[*REQ*].\n
 * The reference may have been named either before export or after import[*REQ*].\n
 * If more than one reference exists in the import with the given name, this is an error[*REQ*].\n
 * Only references in the array *refs* after calling <tt>\ref vxImportObjectsFromMemory</tt> may be retrieved
 * using this function[*REQ*].\n
 * A reference to a named object may be obtained from a valid import object using this API even if all other
 * references to the object have been released[*REQ*].
 * \param [in] import The import object in which to find the name; the function will fail if this parameter
 * is not valid[*REQ*].
 * \param [in] name The name to find, points to a string of at least one and less than VX_MAX_REFERENCE_NAME bytes
 * followed by a zero byte; the function will fail if this is not valid[*REQ*].
 * \return A <tt>\ref vx_reference</tt>[*REQ*].\n
 * Calling <tt>\ref vxGetStatus</tt> with the reference as a parameter will return VX_SUCCESS if the function
 * was successful[*REQ*].\n
 * Another value is given to indicate that there was an error[*REQ*].\n
 * On success, the reference count of the object in question is incremented[*REQ*].\n
 * An implementation may provide several different error codes to give useful diagnostic information
 * in the event of failure to retrieve a reference, but these are not required to indicate
 * possibly recovery mechanisms, and for safety critical use assume errors are not recoverable.
 * \pre <tt>\ref vxSetReferenceName</tt> was used to name the reference.
 * \post use <tt>ref vxReleaseReference</tt> or appropriate specific release function to release a reference
 * obtained by this method.
 * \ingroup group_import
 */
VX_API_ENTRY vx_reference VX_API_CALL vxGetImportReferenceByName(vx_import import, const vx_char *name);

#endif
