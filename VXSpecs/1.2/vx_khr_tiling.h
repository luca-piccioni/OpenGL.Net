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

#ifndef _VX_KHR_TILING_H_
#define _VX_KHR_TILING_H_

/*!
 * \file
 * \brief The Khronos Extension for User Tiling Functions.
 *
 * \defgroup group_tiling Extension: User Tiling API
 * \brief The Khronos Extension for User Tiling Functions.
 */

#define OPENVX_KHR_TILING   "vx_khr_tiling"

#if defined(OPENVX_TILING_1_0)
#undef OPENVX_TILING_1_1
#endif

#include <VX/vx.h>
/* For vx_kernel_input_validate_f and vx_kernel_output_validate_f: */
#include <VX/vx_compatibility.h>


/*! \def VX_RESTRICT
 * \brief A platform wrapper for the restrict keyword.
 * \ingroup group_tiling
 */
//#if defined(_WIN32)
//#define VX_RESTRICT
//#else
//#if defined(__cplusplus) || defined(ANDROID)
//#define VX_RESTRICT     __restrict
//#else
//#define VX_RESTRICT     restrict
//#endif
//#endif

/*! \brief The User Tiling Function tile block size declaration.
 * \details The author of a User Tiling Kernel will use this structure to define
 * the dimensionality of the tile block.
 * \ingroup group_tiling
 */
typedef struct _vx_tile_block_size_t {
    vx_int32 width; /*!< \brief Tile block width in pixels. */
    vx_int32 height; /*!< \brief Tile block height in pixels. */
} vx_tile_block_size_t;

/*! \brief The User Tiling Function Neighborhood declaration.
 * \details The author of a User Tiling Kernel will use this structure to define
 * the neighborhood surrounding the tile block.
 * \ingroup group_tiling
 */
typedef struct _vx_neighborhood_size_t {
    vx_int32 left;   /*!< \brief Left of the tile block. */
    vx_int32 right;  /*!< \brief Right of the tile block. */
    vx_int32 top;    /*!< \brief Top of the tile block. */
    vx_int32 bottom; /*!< \brief Bottom of the tile block. */
} vx_neighborhood_size_t;

/*! \brief A structure which describes the tile's parent image.
 * \ingroup group_tiling
 */
typedef struct _vx_image_description_t {
    vx_uint32 width;  /*!< \brief Width of the image */
    vx_uint32 height; /*!< \brief Height of the image */
    vx_df_image format; /*!< \brief The <tt>\ref vx_df_image_e</tt> of the image */
    vx_uint32 planes; /*!< \brief The number of planes in the image */
    vx_enum range;    /*!< \brief The <tt>\ref vx_channel_range_e</tt> enumeration. */
    vx_enum space;    /*!< \brief The <tt>\ref vx_color_space_e</tt> enumeration. */
} vx_image_description_t;

/*! \brief The maximum number of planes in a tiled image.
 * \ingroup group_tiling
 */
#define VX_MAX_TILING_PLANES (4)

/*! \brief The tile structure declaration.
 * \ingroup group_tiling
 */
typedef struct _vx_tile_t {
    /*! \brief The array of pointers to the tile's image plane. */
    vx_uint8 * VX_RESTRICT base[VX_MAX_TILING_PLANES];
    /*! \brief The top left X pixel index within the width dimension of the image. */
    vx_uint32 tile_x;
    /*! \brief The top left Y pixel index within the height dimension of the image. */
    vx_uint32 tile_y;
    /*! \brief The array of addressing structure to describe each plane. */
    vx_imagepatch_addressing_t addr[VX_MAX_TILING_PLANES];
    /*! \brief The output block size structure. */
    vx_tile_block_size_t tile_block;
    /*! \brief The neighborhood definition. */
    vx_neighborhood_size_t neighborhood;
    /*! \brief The description and attributes of the image. */
    vx_image_description_t image;
} vx_tile_t;

#ifndef VX_TILE_ATTRIBUTES_DEFINITIONS

/*!
 * \brief The full height of the tile's parent image in pixels.
 * \param [in] ptile The pointer to the \ref vx_tile_t structure.
 * \ingroup group_tiling
 */
#define vxImageHeight(ptile)    ((ptile))->image.height)

/*!
 * \brief The full width of the tile's parent image in pixels.
 * \param [in] ptile The pointer to the \ref vx_tile_t structure.
 * \ingroup group_tiling
 */
#define vxImageWidth(ptile)   ((ptile))->image.width)

/*!
 * \brief The offset between the left edge of the image and the left edge of the tile, in pixels.
 * \param [in] ptile The pointer to the \ref vx_tile_t structure.
 * \ingroup group_tiling
 */
#define vxTileX(ptile)        ((ptile)->tile_x)

/*!
 * \brief The offset between the top edge of the image and the top edge of the tile, in pixels.
 * \param [in] ptile The pointer to the \ref vx_tile_t structure.
 * \ingroup group_tiling
 */
#define vxTileY(ptile)        ((ptile)->tile_y)

/*!
 * \brief The width of the tile in pixels.
 * \param [in] ptile The pointer to the \ref vx_tile_t structure.
 * \param [in] index The plane index.
 * \ingroup group_tiling
 */
#define vxTileWidth(ptile, index)    ((ptile)->addr[index].dim_x)

/*!
 * \brief The height of the tile in pixels.
 * \param [in] ptile The pointer to the \ref vx_tile_t structure.
 * \param [in] index The plane index.
 * \ingroup group_tiling
 */
#define vxTileHeight(ptile, index)   ((ptile)->addr[index].dim_y)

/*!
 * \brief The tile block height.
 * \param [in] ptile The pointer to the \ref vx_tile_t structure.
 * \ingroup group_tiling
 */
#define vxTileBlockHeight(ptile)     ((ptile)->tile_block.height)

/*!
 * \brief The tile block width.
 * \param [in] ptile The pointer to the \ref vx_tile_t structure.
 * \ingroup group_tiling
 */
#define vxTileBlockWidth(ptile)      ((ptile)->tile_block.width)

/*!
 * \brief The simple wrapper to access each image's neighborhood -X value.
 * \param [in] ptile The pointer to the \ref vx_tile_t structure.
 * \ingroup group_tiling
 */
#define vxNeighborhoodLeft(ptile)    ((ptile)->neighborhood.left)

/*!
 * \brief The simple wrapper to access each image's neighborhood +X value.
 * \param [in] ptile The pointer to the \ref vx_tile_t structure.
 * \ingroup group_tiling
 */
#define vxNeighborhoodRight(ptile)   ((ptile)->neighborhood.right)

/*!
 * \brief The simple wrapper to access each image's neighborhood -Y value.
 * \param [in] ptile The pointer to the \ref vx_tile_t structure.
 * \ingroup group_tiling
 */
#define vxNeighborhoodTop(ptile)     ((ptile)->neighborhood.top)

/*!
 * \brief The simple wrapper to access each image's neighborhood +Y value.
 * \param [in] ptile The pointer to the \ref vx_tile_t structure.
 * \ingroup group_tiling
 */
#define vxNeighborhoodBottom(ptile)  ((ptile)->neighborhood.bottom)

#if 0
/*!
 * \brief The simple wrapper to access each image's stride X value.
 * \param [in] ptile The pointer to the \ref vx_tile_t structure.
 * \ingroup group_tiling
 */
#define vxStrideSizeX(ptile, index)  ((ptile)->addr[index].stride_x)

/*!
 * \brief The simple wrapper to access each image's stride Y value.
 * \param [in] ptile The pointer to the \ref vx_tile_t structure.
 * \ingroup group_tiling
 */
#define vxStrideSizeY(ptile, index)  ((ptile)->addr[index].stride_y)

/*!
 * \brief The simple wrapper to access each image's step X value.
 * \param [in] ptile The pointer to the \ref vx_tile_t structure.
 * \ingroup group_tiling
 */
#define vxStepSizeX(ptile, index)    ((ptile)->addr[index].step_x)

/*!
 * \brief The simple wrapper to access each image's step Y value.
 * \param [in] ptile The pointer to the \ref vx_tile_t structure.
 * \ingroup group_tiling
 */
#define vxStepSizeY(ptile, index)    ((ptile)->addr[index].step_y)
#endif

#endif

/*! \brief The User Kernel Tiling Attributes.
 * \ingroup group_tiling
 */
enum vx_kernel_attribute_tiling_e {
    /*! \brief This allows a tiling mode kernel to set its input neighborhood. */
    VX_KERNEL_INPUT_NEIGHBORHOOD      = VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_KERNEL) + 0x7,
    /*! \brief This allows a tiling mode kernel to set its output tile block size. */
    VX_KERNEL_OUTPUT_TILE_BLOCK_SIZE  = VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_KERNEL) + 0x8,
    /*! \brief This allows the author to set the border mode on the tiling kernel. */
    VX_KERNEL_BORDER                  = VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_KERNEL) + 0x9,
    /*! \brief This determines the per tile memory allocation. */
    VX_KERNEL_TILE_MEMORY_SIZE        = VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_KERNEL) + 0xA,
#if defined(OPENVX_TILING_1_1)
    /*! \brief This allows a tiling mode kernel to set its input tile block size. */
    VX_KERNEL_INPUT_TILE_BLOCK_SIZE   = VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_KERNEL) + 0xB,
    /*! \brief This allows a tiling mode kernel to set its output neighborhood. */
    VX_KERNEL_OUTPUT_NEIGHBORHOOD     = VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_KERNEL) + 0xC,
#endif
};

/*! \brief The User Node Tiling Attributes.
 * \note These are largely unusable by the tiling function, as it doesn't give you the node reference!
 * \ingroup group_tiling
 */
enum vx_node_attribute_tiling_e {
    /*! \brief This allows a tiling mode node to get its input neighborhood. */
    VX_NODE_INPUT_NEIGHBORHOOD      = VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_NODE) + 0xB,
    /*! \brief This allows a tiling mode node to get its output tile block size. */
    VX_NODE_OUTPUT_TILE_BLOCK_SIZE  = VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_NODE) + 0xC,
    /*! \brief This is the size of the tile local memory area. */
    VX_NODE_TILE_MEMORY_SIZE        = VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_NODE) + 0xD,
#if defined(OPENVX_TILING_1_1)
    /*! \brief This allows a tiling mode node to get its input tile block size. */
    VX_NODE_INPUT_TILE_BLOCK_SIZE   = VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_NODE) + 0xE,
    /*! \brief This allows a tiling mode node to get its output neighborhood. */
    VX_NODE_OUTPUT_NEIGHBORHOOD     = VX_ATTRIBUTE_BASE(VX_ID_KHRONOS, VX_TYPE_NODE) + 0xF,
#endif
};

/*! \brief The tiling border mode extensions
 * \ingroup group_tiling
 */
enum vx_border_tiling_e {
    /*! \brief This value indicates that the author of the tiling kernel wrote
     * code to handle border conditions into the kernel itself. If this mode
     * is set, it can not be overriden by a call to the \ref vxSetNodeAttribute
     * with \ref VX_NODE_BORDER.
     */
    VX_BORDER_MODE_SELF = VX_ENUM_BASE(VX_ID_KHRONOS, VX_ENUM_BORDER) + 0x3,
};

/*! \typedef vx_tiling_kernel_f
 * \brief Tiling Kernel function typedef for User Tiling Kernels.
 * \note Tiles may come in any dimension and are not guaranteed to be delivered in
 * any particular order.
 * \param [in] parameters The array abstract pointers to parameters.
 * \param [in] tile_memory The local tile memory pointer if requested, otherwise NULL.
 * \param [in] tile_memory_size The size of the local tile memory, if not requested, 0.
 * \ingroup group_tiling
 */
#ifdef __cplusplus
typedef void (*vx_tiling_kernel_f)(void * VX_RESTRICT parameters[],
                                   void * VX_RESTRICT tile_memory,
                                   vx_size tile_memory_size);
#else
typedef void (*vx_tiling_kernel_f)(void * VX_RESTRICT parameters[VX_RESTRICT],
                                   void * VX_RESTRICT tile_memory,
                                   vx_size tile_memory_size);
#endif

#ifndef VX_IMAGE_PIXEL_DEFINITION

/*! \def vxImageOffset
 * \brief Computes the offset within an image.
 * \param [in] ptile The pointer to the \ref vx_tile_t structure.
 * \param [in] i The plane index.
 * \param [in] x The Width Coordinates.
 * \param [in] y The Height Coordinates.
 * \param [in] ox The X offset.
 * \param [in] oy The Y offset.
 * \ingroup group_tiling
 */
#define vxImageOffset(ptile, i, x, y, ox, oy) \
        ((ptile)->addr[i].stride_y * (vx_int32)(((vx_int32)((oy)+(y)) * (vx_int32)(ptile)->addr[i].scale_y)/(vx_int32)VX_SCALE_UNITY)) + \
        ((ptile)->addr[i].stride_x * (vx_int32)(((vx_int32)((ox)+(x)) * (vx_int32)(ptile)->addr[i].scale_x)/(vx_int32)VX_SCALE_UNITY))


/*! \def vxImagePixel
 * \brief Accesses an image pixel as a type-cast indexed pointer dereference.
 * \param [in] type The type of the image pixel. Example values are <tt>\ref vx_uint8</tt>, <tt>\ref vx_uint16</tt>, <tt>\ref vx_uint32</tt>, etc.
 * \param [in] ptile The pointer to the \ref vx_tile_t structure.
 * \param [in] i The plane index.
 * \param [in] x The Center Pixel in Width Coordinates.
 * \param [in] y The Center Pixel in Height Coordinates.
 * \param [in] ox The X offset.
 * \param [in] oy The Y offset.
 * \ingroup group_tiling
 */
#define vxImagePixel(type, ptile, i, x, y, ox, oy) \
    *((type *)(&((vx_uint8 *)(ptile)->base[i])[vxImageOffset(ptile, i, x, y, ox, oy)]))

#endif

/*! \brief Allows a user to add a tile-able kernel to the OpenVX system.
 * \param [in] context The handle to the implementation context.
 * \param [in] name The string to be used to match the kernel.
 * \param [in] enumeration The enumerated value of the kernel to be used by clients.
 * \param [in] flexible_func_ptr The process-local flexible function pointer to be invoked.
 * \param [in] fast_func_ptr The process-local fast function pointer to be invoked.
 * \param [in] num_params The number of parameters for this kernel.
 * \param [in] input The pointer to a function which will validate the
 * input parameters to this kernel.
 * \param [in] output The pointer to a function which will validate the
 * output parameters to this kernel.
 * \note Tiling Kernels do not have access to any of the normal node attributes listed
 * in \ref vx_node_attribute_e.
 * \post Call <tt>\ref vxAddParameterToKernel</tt> for as many parameters as the function has,
 * then call <tt>\ref vxFinalizeKernel</tt>.
 * \retval 0 Indicates that an error occurred when adding the kernel.
 * Note that the fast or flexible formula, but not both, can be NULL.
 * \ingroup group_tiling
 */
VX_API_ENTRY vx_kernel VX_API_CALL vxAddTilingKernel(vx_context context,
                            vx_char name[VX_MAX_KERNEL_NAME],
                            vx_enum enumeration,
                            vx_tiling_kernel_f flexible_func_ptr,
                            vx_tiling_kernel_f fast_func_ptr,
                            vx_uint32 num_params,
                            vx_kernel_input_validate_f input,
                            vx_kernel_output_validate_f output);

#endif
