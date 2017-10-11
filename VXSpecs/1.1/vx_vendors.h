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
 * THE MATERIALS ARE PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
 * MERCHANTABILITY,\todo FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
 * IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
 * CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
 * TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
 * MATERIALS OR THE USE OR OTHER DEALINGS IN THE MATERIALS.
 */

#ifndef _OPENVX_VENDORS_H_
#define _OPENVX_VENDORS_H_

/*!
 * \file
 * \brief The Vendor ID list for OpenVX.
 */

/*! \brief The Vendor ID of the Implementation. As new vendors submit their
 * implementations, this enumeration will grow.
 * \ingroup group_basic_features
 */
enum vx_vendor_id_e {
    VX_ID_KHRONOS   = 0x000, /*!< \brief The Khronos Group */
    VX_ID_TI        = 0x001, /*!< \brief Texas Instruments, Inc. */
    VX_ID_QUALCOMM  = 0x002, /*!< \brief Qualcomm, Inc. */
    VX_ID_NVIDIA    = 0x003, /*!< \brief NVIDIA Corporation */
    VX_ID_ARM       = 0x004, /*!< \brief ARM Ltd. */
    VX_ID_BDTI      = 0x005, /*!< \brief Berkley Design Technology, Inc. */
    VX_ID_RENESAS   = 0x006, /*!< \brief Renasas Electronics */
    VX_ID_VIVANTE   = 0x007, /*!< \brief Vivante Corporation */
    VX_ID_XILINX    = 0x008, /*!< \brief Xilinx Inc. */
    VX_ID_AXIS      = 0x009, /*!< \brief Axis Communications */
    VX_ID_MOVIDIUS  = 0x00A, /*!< \brief Movidius Ltd. */
    VX_ID_SAMSUNG   = 0x00B, /*!< \brief Samsung Electronics */
    VX_ID_FREESCALE = 0x00C, /*!< \brief Freescale Semiconductor */
    VX_ID_AMD       = 0x00D, /*!< \brief Advanced Micro Devices */
    VX_ID_BROADCOM  = 0x00E, /*!< \brief Broadcom Corporation */
    VX_ID_INTEL     = 0x00F, /*!< \brief Intel Corporation */
    VX_ID_MARVELL   = 0x010, /*!< \brief Marvell Technology Group Ltd. */
    VX_ID_MEDIATEK  = 0x011, /*!< \brief MediaTek, Inc. */
    VX_ID_ST        = 0x012, /*!< \brief STMicroelectronics */
    VX_ID_CEVA      = 0x013, /*!< \brief CEVA DSP */
    VX_ID_ITSEEZ    = 0x014, /*!< \brief Itseez, Inc. */
    VX_ID_IMAGINATION=0x015, /*!< \brief Imagination Technologies */
    VX_ID_NXP       = 0x016, /*!< \brief NXP Semiconductors */
    VX_ID_VIDEANTIS = 0x017, /*!< \brief Videantis */
    VX_ID_SYNOPSYS  = 0x018, /*!< \brief Synopsys */
    VX_ID_CADENCE   = 0x019, /*!< \brief Cadence */
    VX_ID_HUAWEI    = 0x01A, /*!< \brief Huawei */
    /* Add new vendor code above this line */
    VX_ID_USER      = 0xFFE, /*!< \brief For use by vxAllocateUserKernelId and vxAllocateUserKernelLibraryId */
    VX_ID_MAX       = 0xFFF,
    /*! \brief For use by all Kernel authors until they can obtain an assigned ID. */
    VX_ID_DEFAULT = VX_ID_MAX,
};

#endif

