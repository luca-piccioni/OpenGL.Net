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

#ifndef VX_1_0_1_NAMING_COMPATIBILITY
#define VX_1_0_1_NAMING_COMPATIBILITY

#define VX_TYPE_SCALAR_MAX         (VX_TYPE_BOOL + 1)

#define vx_border_mode_e           vx_border_e
#define vx_border_mode_policy_e    vx_border_policy_e
#define _vx_border_mode_t          _vx_border_t
#define vx_border_mode_t           vx_border_t

#define VX_ENUM_BORDER_MODE         VX_ENUM_BORDER
#define VX_BORDER_MODE_POLICY       VX_BORDER_POLICY
#define VX_BORDER_MODE_UNDEFINED    VX_BORDER_UNDEFINED
#define VX_BORDER_MODE_CONSTANT     VX_BORDER_CONSTANT
#define VX_BORDER_MODE_REPLICATE    VX_BORDER_REPLICATE
#define VX_BORDER_MODE_UNSUPPORTED_POLICY_DEFAULT_TO_UNDEFINED  VX_BORDER_POLICY_DEFAULT_TO_UNDEFINED
#define VX_BORDER_MODE_UNSUPPORTED_POLICY_RETURN_ERROR          VX_BORDER_POLICY_RETURN_ERROR

#define VX_CONTEXT_ATTRIBUTE_VENDOR_ID                          VX_CONTEXT_VENDOR_ID
#define VX_CONTEXT_ATTRIBUTE_VERSION                            VX_CONTEXT_VERSION
#define VX_CONTEXT_ATTRIBUTE_UNIQUE_KERNELS                     VX_CONTEXT_UNIQUE_KERNELS
#define VX_CONTEXT_ATTRIBUTE_MODULES                            VX_CONTEXT_MODULES
#define VX_CONTEXT_ATTRIBUTE_REFERENCES                         VX_CONTEXT_REFERENCES
#define VX_CONTEXT_ATTRIBUTE_IMPLEMENTATION                     VX_CONTEXT_IMPLEMENTATION
#define VX_CONTEXT_ATTRIBUTE_EXTENSIONS_SIZE                    VX_CONTEXT_EXTENSIONS_SIZE
#define VX_CONTEXT_ATTRIBUTE_EXTENSIONS                         VX_CONTEXT_EXTENSIONS
#define VX_CONTEXT_ATTRIBUTE_CONVOLUTION_MAXIMUM_DIMENSION      VX_CONTEXT_CONVOLUTION_MAX_DIMENSION
#define VX_CONTEXT_ATTRIBUTE_OPTICAL_FLOW_WINDOW_MAXIMUM_DIMENSION      VX_CONTEXT_OPTICAL_FLOW_MAX_WINDOW_DIMENSION
#define VX_CONTEXT_ATTRIBUTE_IMMEDIATE_BORDER_MODE                      VX_CONTEXT_IMMEDIATE_BORDER
#define VX_CONTEXT_ATTRIBUTE_UNIQUE_KERNEL_TABLE                        VX_CONTEXT_UNIQUE_KERNEL_TABLE

#define VX_KERNEL_ATTRIBUTE_PARAMETERS      VX_KERNEL_PARAMETERS
#define VX_KERNEL_ATTRIBUTE_NAME            VX_KERNEL_NAME
#define VX_KERNEL_ATTRIBUTE_ENUM            VX_KERNEL_ENUM
#define VX_KERNEL_ATTRIBUTE_LOCAL_DATA_SIZE VX_KERNEL_LOCAL_DATA_SIZE
#define VX_KERNEL_ATTRIBUTE_LOCAL_DATA_PTR  (VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_KERNEL) + 0x4)

#define VX_NODE_ATTRIBUTE_STATUS            VX_NODE_STATUS
#define VX_NODE_ATTRIBUTE_PERFORMANCE       VX_NODE_PERFORMANCE
#define VX_NODE_ATTRIBUTE_BORDER_MODE       VX_NODE_BORDER
#define VX_NODE_ATTRIBUTE_LOCAL_DATA_SIZE   VX_NODE_LOCAL_DATA_SIZE
#define VX_NODE_ATTRIBUTE_LOCAL_DATA_PTR    VX_NODE_LOCAL_DATA_PTR

#define VX_PARAMETER_ATTRIBUTE_INDEX        VX_PARAMETER_INDEX
#define VX_PARAMETER_ATTRIBUTE_DIRECTION    VX_PARAMETER_DIRECTION
#define VX_PARAMETER_ATTRIBUTE_TYPE         VX_PARAMETER_TYPE
#define VX_PARAMETER_ATTRIBUTE_STATE        VX_PARAMETER_STATE
#define VX_PARAMETER_ATTRIBUTE_REF          VX_PARAMETER_REF

#define VX_IMAGE_ATTRIBUTE_WIDTH            VX_IMAGE_WIDTH
#define VX_IMAGE_ATTRIBUTE_HEIGHT           VX_IMAGE_HEIGHT
#define VX_IMAGE_ATTRIBUTE_FORMAT           VX_IMAGE_FORMAT
#define VX_IMAGE_ATTRIBUTE_PLANES           VX_IMAGE_PLANES
#define VX_IMAGE_ATTRIBUTE_SPACE            VX_IMAGE_SPACE
#define VX_IMAGE_ATTRIBUTE_RANGE            VX_IMAGE_RANGE
#define VX_IMAGE_ATTRIBUTE_SIZE             VX_IMAGE_SIZE

#define VX_SCALAR_ATTRIBUTE_TYPE            VX_SCALAR_TYPE

#define VX_GRAPH_ATTRIBUTE_NUMNODES         VX_GRAPH_NUMNODES
#define VX_GRAPH_ATTRIBUTE_STATUS           (VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_GRAPH) + 0x1)
#define VX_GRAPH_ATTRIBUTE_PERFORMANCE      VX_GRAPH_PERFORMANCE
#define VX_GRAPH_ATTRIBUTE_NUMPARAMETERS    VX_GRAPH_NUMPARAMETERS

#define VX_LUT_ATTRIBUTE_TYPE               VX_LUT_TYPE
#define VX_LUT_ATTRIBUTE_COUNT              VX_LUT_COUNT
#define VX_LUT_ATTRIBUTE_SIZE               VX_LUT_SIZE

#define VX_DISTRIBUTION_ATTRIBUTE_DIMENSIONS    VX_DISTRIBUTION_DIMENSIONS
#define VX_DISTRIBUTION_ATTRIBUTE_OFFSET        VX_DISTRIBUTION_OFFSET
#define VX_DISTRIBUTION_ATTRIBUTE_RANGE         VX_DISTRIBUTION_RANGE
#define VX_DISTRIBUTION_ATTRIBUTE_BINS          VX_DISTRIBUTION_BINS
#define VX_DISTRIBUTION_ATTRIBUTE_WINDOW        VX_DISTRIBUTION_WINDOW
#define VX_DISTRIBUTION_ATTRIBUTE_SIZE          VX_DISTRIBUTION_SIZE

#define VX_THRESHOLD_ATTRIBUTE_TYPE             VX_THRESHOLD_TYPE
#define VX_THRESHOLD_ATTRIBUTE_THRESHOLD_VALUE  VX_THRESHOLD_THRESHOLD_VALUE
#define VX_THRESHOLD_ATTRIBUTE_THRESHOLD_LOWER  VX_THRESHOLD_THRESHOLD_LOWER
#define VX_THRESHOLD_ATTRIBUTE_THRESHOLD_UPPER  VX_THRESHOLD_THRESHOLD_UPPER
#define VX_THRESHOLD_ATTRIBUTE_TRUE_VALUE       VX_THRESHOLD_TRUE_VALUE
#define VX_THRESHOLD_ATTRIBUTE_FALSE_VALUE      VX_THRESHOLD_FALSE_VALUE
#define VX_THRESHOLD_ATTRIBUTE_DATA_TYPE        VX_THRESHOLD_DATA_TYPE

#define VX_MATRIX_ATTRIBUTE_TYPE            VX_MATRIX_TYPE
#define VX_MATRIX_ATTRIBUTE_ROWS            VX_MATRIX_ROWS
#define VX_MATRIX_ATTRIBUTE_COLUMNS         VX_MATRIX_COLUMNS
#define VX_MATRIX_ATTRIBUTE_SIZE            VX_MATRIX_SIZE

#define VX_CONVOLUTION_ATTRIBUTE_ROWS       VX_CONVOLUTION_ROWS
#define VX_CONVOLUTION_ATTRIBUTE_COLUMNS    VX_CONVOLUTION_COLUMNS
#define VX_CONVOLUTION_ATTRIBUTE_SCALE      VX_CONVOLUTION_SCALE
#define VX_CONVOLUTION_ATTRIBUTE_SIZE       VX_CONVOLUTION_SIZE

#define VX_PYRAMID_ATTRIBUTE_LEVELS         VX_PYRAMID_LEVELS
#define VX_PYRAMID_ATTRIBUTE_SCALE          VX_PYRAMID_SCALE
#define VX_PYRAMID_ATTRIBUTE_WIDTH          VX_PYRAMID_WIDTH
#define VX_PYRAMID_ATTRIBUTE_HEIGHT         VX_PYRAMID_HEIGHT
#define VX_PYRAMID_ATTRIBUTE_FORMAT         VX_PYRAMID_FORMAT

#define VX_REMAP_ATTRIBUTE_SOURCE_WIDTH         VX_REMAP_SOURCE_WIDTH
#define VX_REMAP_ATTRIBUTE_SOURCE_HEIGHT        VX_REMAP_SOURCE_HEIGHT
#define VX_REMAP_ATTRIBUTE_DESTINATION_WIDTH    VX_REMAP_DESTINATION_WIDTH
#define VX_REMAP_ATTRIBUTE_DESTINATION_HEIGHT   VX_REMAP_DESTINATION_HEIGHT

#define VX_ARRAY_ATTRIBUTE_ITEMTYPE         VX_ARRAY_ITEMTYPE
#define VX_ARRAY_ATTRIBUTE_NUMITEMS         VX_ARRAY_NUMITEMS
#define VX_ARRAY_ATTRIBUTE_CAPACITY         VX_ARRAY_CAPACITY
#define VX_ARRAY_ATTRIBUTE_ITEMSIZE         VX_ARRAY_ITEMSIZE

#define VX_DELAY_ATTRIBUTE_TYPE             VX_DELAY_TYPE
#define VX_DELAY_ATTRIBUTE_SLOTS            VX_DELAY_SLOTS

#define VX_INTERPOLATION_TYPE_AREA                  VX_INTERPOLATION_AREA
#define VX_INTERPOLATION_TYPE_BILINEAR              VX_INTERPOLATION_BILINEAR
#define VX_INTERPOLATION_TYPE_NEAREST_NEIGHBOR      VX_INTERPOLATION_NEAREST_NEIGHBOR

#define VX_IMAGE_SIZE (VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_IMAGE) + 0x6)

#define VX_META_FORMAT_ATTRIBUTE_DELTA_RECTANGLE  (VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_META_FORMAT) + 0x0)
#define VX_HINT_SERIALIZE (VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_HINT) + 0x0)

#define vx_import_type_e        vx_memory_type_e
#define VX_ENUM_IMPORT_MEM      VX_ENUM_MEMORY_TYPE
#define VX_IMPORT_TYPE_NONE     VX_MEMORY_TYPE_NONE
#define VX_IMPORT_TYPE_HOST     VX_MEMORY_TYPE_HOST

#define VX_TYPE_OBJECT_MAX      VX_TYPE_KHRONOS_OBJECT_END
#define VX_TYPE_STRUCT_MAX      VX_TYPE_KHRONOS_STRUCT_MAX

#define VX_KERNEL_INVALID (VX_KERNEL_BASE(VX_ID_KHRONOS, VX_LIBRARY_KHR_BASE) + 0x0)

#define VX_THRESHOLD_THRESHOLD_VALUE (VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_THRESHOLD) + 0x1)
#define VX_THRESHOLD_THRESHOLD_LOWER (VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_THRESHOLD) + 0x2)
#define VX_THRESHOLD_THRESHOLD_UPPER (VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_THRESHOLD) + 0x3)
#define VX_THRESHOLD_TRUE_VALUE (VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_THRESHOLD) + 0x4)
#define VX_THRESHOLD_FALSE_VALUE (VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_THRESHOLD) + 0x5)
#define VX_THRESHOLD_DATA_TYPE (VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_THRESHOLD) + 0x6)

typedef vx_status(VX_CALLBACK *vx_kernel_input_validate_f)(vx_node node, vx_uint32 index);

typedef vx_status(VX_CALLBACK *vx_kernel_output_validate_f)(vx_node node, vx_uint32 index, vx_meta_format meta);

typedef struct _vx_delta_rectangle_t {
    vx_int32 delta_start_x; /*!< \brief The change in the start x. */
    vx_int32 delta_start_y; /*!< \brief The change in the start y. */
    vx_int32 delta_end_x;   /*!< \brief The change in the end x. */
    vx_int32 delta_end_y;   /*!< \brief The change in the end y. */
} vx_delta_rectangle_t;

#ifdef __cplusplus
extern "C" {
#endif

VX_API_ENTRY vx_kernel VX_API_CALL vxAddKernel(vx_context context,
                             const vx_char name[VX_MAX_KERNEL_NAME],
                             vx_enum enumeration,
                             vx_kernel_f func_ptr,
                             vx_uint32 numParams,
                             vx_kernel_input_validate_f input,
                             vx_kernel_output_validate_f output,
                             vx_kernel_initialize_f init,
                             vx_kernel_deinitialize_f deinit);

VX_API_ENTRY vx_size VX_API_CALL vxComputeImagePatchSize(vx_image image,
                                       const vx_rectangle_t *rect,
                                       vx_uint32 plane_index);

VX_API_ENTRY vx_status VX_API_CALL vxAccessImagePatch(vx_image image,
                                    const vx_rectangle_t *rect,
                                    vx_uint32 plane_index,
                                    vx_imagepatch_addressing_t *addr,
                                    void **ptr,
                                    vx_enum usage);

VX_API_ENTRY vx_status VX_API_CALL vxCommitImagePatch(vx_image image,
                                    const vx_rectangle_t *rect,
                                    vx_uint32 plane_index,
                                    const vx_imagepatch_addressing_t *addr,
                                    const void *ptr);

VX_API_ENTRY vx_status VX_API_CALL vxAccessArrayRange(vx_array arr, vx_size start, vx_size end, vx_size *stride, void **ptr, vx_enum usage);

VX_API_ENTRY vx_status VX_API_CALL vxCommitArrayRange(vx_array arr, vx_size start, vx_size end, const void *ptr);

VX_API_ENTRY vx_status VX_API_CALL vxAccessDistribution(vx_distribution distribution, void **ptr, vx_enum usage);

VX_API_ENTRY vx_status VX_API_CALL vxCommitDistribution(vx_distribution distribution, const void * ptr);

VX_API_ENTRY vx_status VX_API_CALL vxAccessLUT(vx_lut lut, void **ptr, vx_enum usage);

VX_API_ENTRY vx_status VX_API_CALL vxCommitLUT(vx_lut lut, const void *ptr);

VX_API_ENTRY vx_status VX_API_CALL vxReadMatrix(vx_matrix mat, void *array);

VX_API_ENTRY vx_status VX_API_CALL vxWriteMatrix(vx_matrix mat, const void *array);

VX_API_ENTRY vx_status VX_API_CALL vxReadConvolutionCoefficients(vx_convolution conv, vx_int16 *array);

VX_API_ENTRY vx_status VX_API_CALL vxWriteConvolutionCoefficients(vx_convolution conv, const vx_int16 *array);

VX_API_ENTRY vx_status VX_API_CALL vxReadScalarValue(vx_scalar ref, void *ptr);

VX_API_ENTRY vx_status VX_API_CALL vxWriteScalarValue(vx_scalar ref, const void *ptr);

VX_API_ENTRY vx_status VX_API_CALL vxSetRemapPoint(vx_remap table, vx_uint32 dst_x, vx_uint32 dst_y, vx_float32 src_x,vx_float32 src_y);

VX_API_ENTRY vx_status VX_API_CALL vxGetRemapPoint(vx_remap table, vx_uint32 dst_x, vx_uint32 dst_y, vx_float32 *src_x, vx_float32 *src_y);

VX_API_ENTRY vx_threshold VX_API_CALL vxCreateThreshold(vx_context c, vx_enum thresh_type, vx_enum data_type);

#ifdef __cplusplus
}
#endif

#endif /* VX_1_0_1_NAMING_COMPATIBILITY */
