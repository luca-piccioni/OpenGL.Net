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

/*! \defgroup wfd OpenWF Display SI
 * @{
 */

/*! \file wfd.h
 *
 *  \brief OpenWF Display public API, type definitions and function prototypes
 *
 *  This is one of the three header files defined by the specification.
 *  This file contains the portable definitions of data types
 *  and function prototypes.

 *  Refer to OpenWF Display specification for the
 *  additional documentation.
 *
 */

/*! @} */

#ifndef _WFD_H_
#define _WFD_H_

#include <WF/wfdplatform.h>

#ifdef __cplusplus
extern "C" {
#endif

#define OPENWFD_VERSION_1_0         (1)

#define WFD_NONE                    (0)

#define WFD_INVALID_PORT_ID         (0)
#define WFD_INVALID_PIPELINE_ID     (0)
#define WFD_INVALID_PIPELINE_LAYER  (0)

#define WFD_DEFAULT_DEVICE_ID       (0)

typedef enum
{ WFD_FALSE = KHR_BOOLEAN_FALSE,
  WFD_TRUE  = KHR_BOOLEAN_TRUE
} WFDboolean;


#define WFD_MAX_INT   ((WFDint)16777216)
#define WFD_MAX_FLOAT ((WFDfloat)16777216)

#define WFD_INVALID_HANDLE ((WFDHandle)0)

typedef WFDHandle WFDDevice;
typedef WFDHandle WFDEvent;
typedef WFDHandle WFDPort;
typedef WFDHandle WFDPortMode;
typedef WFDHandle WFDPipeline;
typedef WFDHandle WFDSource;
typedef WFDHandle WFDMask;

typedef enum
{ WFD_VENDOR                                = 0x7500,
  WFD_RENDERER                              = 0x7501,
  WFD_VERSION                               = 0x7502,
  WFD_EXTENSIONS                            = 0x7503,
  WFD_STRING_ID_FORCE_32BIT                 = 0x7FFFFFFF
} WFDStringID;

typedef enum
{ WFD_ERROR_NONE                            = 0,
  WFD_ERROR_OUT_OF_MEMORY                   = 0x7510,
  WFD_ERROR_ILLEGAL_ARGUMENT                = 0x7511,
  WFD_ERROR_NOT_SUPPORTED                   = 0x7512,
  WFD_ERROR_BAD_ATTRIBUTE                   = 0x7513,
  WFD_ERROR_IN_USE                          = 0x7514,
  WFD_ERROR_BUSY                            = 0x7515,
  WFD_ERROR_BAD_DEVICE                      = 0x7516,
  WFD_ERROR_BAD_HANDLE                      = 0x7517,
  WFD_ERROR_INCONSISTENCY                   = 0x7518,
  WFD_ERROR_FORCE_32BIT                     = 0x7FFFFFFF
} WFDErrorCode;

typedef enum
{ WFD_DEVICE_FILTER_PORT_ID                 = 0x7530,
  WFD_DEVICE_FILTER_FORCE_32BIT             = 0x7FFFFFFF
} WFDDeviceFilter;

typedef enum
{ WFD_COMMIT_ENTIRE_DEVICE                  = 0x7550,
  WFD_COMMIT_ENTIRE_PORT                    = 0x7551,
  WFD_COMMIT_PIPELINE                       = 0x7552,
  WFD_COMMIT_FORCE_32BIT                    = 0x7FFFFFFF
} WFDCommitType;

typedef enum
{ WFD_DEVICE_ID                             = 0x7560,
  WFD_DEVICE_ATTRIB_FORCE_32BIT             = 0x7FFFFFFF
} WFDDeviceAttrib;

typedef enum
{ WFD_EVENT_INVALID                         = 0x7580,
  WFD_EVENT_NONE                            = 0x7581,
  WFD_EVENT_DESTROYED                       = 0x7582,
  WFD_EVENT_PORT_ATTACH_DETACH              = 0x7583,
  WFD_EVENT_PORT_PROTECTION_FAILURE         = 0x7584,
  WFD_EVENT_PIPELINE_BIND_SOURCE_COMPLETE   = 0x7585,
  WFD_EVENT_PIPELINE_BIND_MASK_COMPLETE     = 0x7586,
  WFD_EVENT_FORCE_32BIT                     = 0x7FFFFFFF
} WFDEventType;

typedef enum
{ /* Configuration Attributes */
  WFD_EVENT_PIPELINE_BIND_QUEUE_SIZE        = 0x75C0,

  /* Generic Event Attributes */
  WFD_EVENT_TYPE                            = 0x75C1,

  /* Port Attach Event Attributes */
  WFD_EVENT_PORT_ATTACH_PORT_ID             = 0x75C2,
  WFD_EVENT_PORT_ATTACH_STATE               = 0x75C3,

  /* Port Protection Event Attributes */
  WFD_EVENT_PORT_PROTECTION_PORT_ID         = 0x75C4,

  /* Pipeline Bind Complete Event Attributes */
  WFD_EVENT_PIPELINE_BIND_PIPELINE_ID       = 0x75C5,
  WFD_EVENT_PIPELINE_BIND_SOURCE            = 0x75C6,
  WFD_EVENT_PIPELINE_BIND_MASK              = 0x75C7,
  WFD_EVENT_PIPELINE_BIND_QUEUE_OVERFLOW    = 0x75C8,

  WFD_EVENT_ATTRIB_FORCE_32BIT              = 0x7FFFFFFF
} WFDEventAttrib;

typedef enum
{ WFD_PORT_MODE_WIDTH                       = 0x7600,
  WFD_PORT_MODE_HEIGHT                      = 0x7601,
  WFD_PORT_MODE_REFRESH_RATE                = 0x7602,
  WFD_PORT_MODE_FLIP_MIRROR_SUPPORT         = 0x7603,
  WFD_PORT_MODE_ROTATION_SUPPORT            = 0x7604,
  WFD_PORT_MODE_INTERLACED                  = 0x7605,
  WFD_PORT_MODE_ATTRIB_FORCE_32BIT          = 0x7FFFFFFF
} WFDPortModeAttrib;

typedef enum
{ WFD_PORT_ID                               = 0x7620,
  WFD_PORT_TYPE                             = 0x7621,
  WFD_PORT_DETACHABLE                       = 0x7622,
  WFD_PORT_ATTACHED                         = 0x7623,
  WFD_PORT_NATIVE_RESOLUTION                = 0x7624,
  WFD_PORT_PHYSICAL_SIZE                    = 0x7625,
  WFD_PORT_FILL_PORT_AREA                   = 0x7626,
  WFD_PORT_BACKGROUND_COLOR                 = 0x7627,
  WFD_PORT_FLIP                             = 0x7628,
  WFD_PORT_MIRROR                           = 0x7629,
  WFD_PORT_ROTATION                         = 0x762A,
  WFD_PORT_POWER_MODE                       = 0x762B,
  WFD_PORT_GAMMA_RANGE                      = 0x762C,
  WFD_PORT_GAMMA                            = 0x762D,
  WFD_PORT_PARTIAL_REFRESH_SUPPORT          = 0x762E,
  WFD_PORT_PARTIAL_REFRESH_MAXIMUM          = 0x762F,
  WFD_PORT_PARTIAL_REFRESH_ENABLE           = 0x7630,
  WFD_PORT_PARTIAL_REFRESH_RECTANGLE        = 0x7631,
  WFD_PORT_PIPELINE_ID_COUNT                = 0x7632,
  WFD_PORT_BINDABLE_PIPELINE_IDS            = 0x7633,
  WFD_PORT_PROTECTION_ENABLE                = 0x7634,
  WFD_PORT_ATTRIB_FORCE_32BIT               = 0x7FFFFFFF
} WFDPortConfigAttrib;

typedef enum
{ WFD_PORT_TYPE_INTERNAL                    = 0x7660,
  WFD_PORT_TYPE_COMPOSITE                   = 0x7661,
  WFD_PORT_TYPE_SVIDEO                      = 0x7662,
  WFD_PORT_TYPE_COMPONENT_YPbPr             = 0x7663,
  WFD_PORT_TYPE_COMPONENT_RGB               = 0x7664,
  WFD_PORT_TYPE_COMPONENT_RGBHV             = 0x7665,
  WFD_PORT_TYPE_DVI                         = 0x7666,
  WFD_PORT_TYPE_HDMI                        = 0x7667,
  WFD_PORT_TYPE_DISPLAYPORT                 = 0x7668,
  WFD_PORT_TYPE_OTHER                       = 0x7669,
  WFD_PORT_TYPE_FORCE_32BIT                 = 0x7FFFFFFF
} WFDPortType;

typedef enum
{ WFD_POWER_MODE_OFF                        = 0x7680,
  WFD_POWER_MODE_SUSPEND                    = 0x7681,
  WFD_POWER_MODE_LIMITED_USE                = 0x7682,
  WFD_POWER_MODE_ON                         = 0x7683,
  WFD_POWER_MODE_FORCE_32BIT                = 0x7FFFFFFF
} WFDPowerMode;

typedef enum
{ WFD_PARTIAL_REFRESH_NONE                  = 0x7690,
  WFD_PARTIAL_REFRESH_VERTICAL              = 0x7691,
  WFD_PARTIAL_REFRESH_HORIZONTAL            = 0x7692,
  WFD_PARTIAL_REFRESH_BOTH                  = 0x7693,
  WFD_PARTIAL_REFRESH_FORCE_32BIT           = 0x7FFFFFFF
} WFDPartialRefresh;

typedef enum
{ WFD_DISPLAY_DATA_FORMAT_NONE              = 0x76A0,
  WFD_DISPLAY_DATA_FORMAT_EDID_V1           = 0x76A1,
  WFD_DISPLAY_DATA_FORMAT_EDID_V2           = 0x76A2,
  WFD_DISPLAY_DATA_FORMAT_DISPLAYID         = 0x76A3,
  WFD_DISPLAY_DATA_FORMAT_FORCE_32BIT       = 0x7FFFFFFF
} WFDDisplayDataFormat;

typedef enum
{ WFD_ROTATION_SUPPORT_NONE                 = 0x76D0,
  WFD_ROTATION_SUPPORT_LIMITED              = 0x76D1,
  WFD_ROTATION_SUPPORT_FORMAT_FORCE_32BIT   = 0x7FFFFFFF
} WFDRotationSupport;

typedef enum
{ WFD_PIPELINE_ID                           = 0x7720,
  WFD_PIPELINE_PORTID                       = 0x7721,
  WFD_PIPELINE_LAYER                        = 0x7722,
  WFD_PIPELINE_SHAREABLE                    = 0x7723,
  WFD_PIPELINE_DIRECT_REFRESH               = 0x7724,
  WFD_PIPELINE_MAX_SOURCE_SIZE              = 0x7725,
  WFD_PIPELINE_SOURCE_RECTANGLE             = 0x7726,
  WFD_PIPELINE_FLIP                         = 0x7727,
  WFD_PIPELINE_MIRROR                       = 0x7728,
  WFD_PIPELINE_ROTATION_SUPPORT             = 0x7729,
  WFD_PIPELINE_ROTATION                     = 0x772A,
  WFD_PIPELINE_SCALE_RANGE                  = 0x772B,
  WFD_PIPELINE_SCALE_FILTER                 = 0x772C,
  WFD_PIPELINE_DESTINATION_RECTANGLE        = 0x772D,
  WFD_PIPELINE_TRANSPARENCY_ENABLE          = 0x772E,
  WFD_PIPELINE_GLOBAL_ALPHA                 = 0x772F,
  WFD_PIPELINE_ATTRIB_FORCE_32BIT           = 0x7FFFFFFF
} WFDPipelineConfigAttrib;

typedef enum
{ WFD_SCALE_FILTER_NONE                     = 0x7760,
  WFD_SCALE_FILTER_FASTER                   = 0x7761,
  WFD_SCALE_FILTER_BETTER                   = 0x7762,
  WFD_SCALE_FILTER_FORCE_32BIT              = 0x7FFFFFFF
} WFDScaleFilter;

typedef enum
{ WFD_TRANSPARENCY_NONE                     = 0,
  WFD_TRANSPARENCY_SOURCE_COLOR             = (1 << 0),
  WFD_TRANSPARENCY_GLOBAL_ALPHA             = (1 << 1),
  WFD_TRANSPARENCY_SOURCE_ALPHA             = (1 << 2),
  WFD_TRANSPARENCY_MASK                     = (1 << 3),
  WFD_TRANSPARENCY_FORCE_32BIT              = 0x7FFFFFFF
} WFDTransparency;

typedef enum
{ WFD_TSC_FORMAT_UINT8_RGB_8_8_8_LINEAR     = 0x7790,
  WFD_TSC_FORMAT_UINT8_RGB_5_6_5_LINEAR     = 0x7791,
  WFD_TSC_FORMAT_FORCE_32BIT                = 0x7FFFFFFF
} WFDTSColorFormat;

typedef enum
{ WFD_TRANSITION_INVALID                    = 0x77E0,
  WFD_TRANSITION_IMMEDIATE                  = 0x77E1,
  WFD_TRANSITION_AT_VSYNC                   = 0x77E2,
  WFD_TRANSITION_FORCE_32BIT                = 0x7FFFFFFF
} WFDTransition;

typedef struct
{ WFDint offsetX;
  WFDint offsetY;
  WFDint width;
  WFDint height;
} WFDRect;

/* Function Prototypes */

/* Implementation Information */

WFD_API_CALL WFDint WFD_APIENTRY
    wfdGetStrings(WFDDevice device,
                  WFDStringID name,
                  const char **strings,
                  WFDint stringsCount) WFD_APIEXIT;

WFD_API_CALL WFDboolean WFD_APIENTRY
    wfdIsExtensionSupported(WFDDevice device,
                            const char *string) WFD_APIEXIT;

/* Error */

WFD_API_CALL WFDErrorCode WFD_APIENTRY
    wfdGetError(WFDDevice device) WFD_APIEXIT;

/* Device */

WFD_API_CALL WFDint WFD_APIENTRY
    wfdEnumerateDevices(WFDint *deviceIds,
                        WFDint deviceIdsCount,
                        const WFDint *filterList) WFD_APIEXIT;

WFD_API_CALL WFDDevice WFD_APIENTRY
    wfdCreateDevice(WFDint deviceId,
                    const WFDint *attribList) WFD_APIEXIT;

WFD_API_CALL WFDErrorCode WFD_APIENTRY
    wfdDestroyDevice(WFDDevice device) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdDeviceCommit(WFDDevice device,
                    WFDCommitType type,
                    WFDHandle handle) WFD_APIEXIT;

WFD_API_CALL WFDint WFD_APIENTRY
    wfdGetDeviceAttribi(WFDDevice device,
                        WFDDeviceAttrib attrib) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdSetDeviceAttribi(WFDDevice device,
                        WFDDeviceAttrib attrib,
                        WFDint value) WFD_APIEXIT;

WFD_API_CALL WFDEvent WFD_APIENTRY
    wfdCreateEvent(WFDDevice device,
                   const WFDint *attribList) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdDestroyEvent(WFDDevice device,
                    WFDEvent event) WFD_APIEXIT;

WFD_API_CALL WFDint WFD_APIENTRY
    wfdGetEventAttribi(WFDDevice device,
                       WFDEvent event,
                       WFDEventAttrib attrib) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdDeviceEventAsync(WFDDevice device,
                        WFDEvent event,
                        WFDEGLDisplay display,
                        WFDEGLSync sync) WFD_APIEXIT;

WFD_API_CALL WFDEventType WFD_APIENTRY
    wfdDeviceEventWait(WFDDevice device,
                       WFDEvent event,
                       WFDtime timeout) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdDeviceEventFilter(WFDDevice device,
                         WFDEvent event,
                         const WFDEventType *filter) WFD_APIEXIT;

/* Port */

WFD_API_CALL WFDint WFD_APIENTRY
    wfdEnumeratePorts(WFDDevice device,
                      WFDint *portIds,
                      WFDint portIdsCount,
                      const WFDint *filterList) WFD_APIEXIT;

WFD_API_CALL WFDPort WFD_APIENTRY
    wfdCreatePort(WFDDevice device,
                  WFDint portId,
                  const WFDint *attribList) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdDestroyPort(WFDDevice device, WFDPort port) WFD_APIEXIT;

WFD_API_CALL WFDint WFD_APIENTRY
    wfdGetPortModes(WFDDevice device,
                    WFDPort port,
                    WFDPortMode *modes,
                    WFDint modesCount) WFD_APIEXIT;

WFD_API_CALL WFDint WFD_APIENTRY
    wfdGetPortModeAttribi(WFDDevice device,
                          WFDPort port,
                          WFDPortMode mode,
                          WFDPortModeAttrib attrib) WFD_APIEXIT;

WFD_API_CALL WFDfloat WFD_APIENTRY
    wfdGetPortModeAttribf(WFDDevice device,
                          WFDPort port,
                          WFDPortMode mode,
                          WFDPortModeAttrib attrib) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdSetPortMode(WFDDevice device,
                   WFDPort port,
                   WFDPortMode mode) WFD_APIEXIT;

WFD_API_CALL WFDPortMode WFD_APIENTRY
    wfdGetCurrentPortMode(WFDDevice device, WFDPort port) WFD_APIEXIT;

WFD_API_CALL WFDint WFD_APIENTRY
    wfdGetPortAttribi(WFDDevice device,
                      WFDPort port,
                      WFDPortConfigAttrib attrib) WFD_APIEXIT;

WFD_API_CALL WFDfloat WFD_APIENTRY
    wfdGetPortAttribf(WFDDevice device,
                      WFDPort port,
                      WFDPortConfigAttrib attrib) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdGetPortAttribiv(WFDDevice device,
                       WFDPort port,
                       WFDPortConfigAttrib attrib,
                       WFDint count,
                       WFDint *value) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdGetPortAttribfv(WFDDevice device,
                       WFDPort port,
                       WFDPortConfigAttrib attrib,
                       WFDint count,
                       WFDfloat *value) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdSetPortAttribi(WFDDevice device,
                      WFDPort port,
                      WFDPortConfigAttrib attrib,
                      WFDint value) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdSetPortAttribf(WFDDevice device,
                      WFDPort port,
                      WFDPortConfigAttrib attrib,
                      WFDfloat value) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdSetPortAttribiv(WFDDevice device,
                       WFDPort port,
                       WFDPortConfigAttrib attrib,
                       WFDint count,
                       const WFDint *value) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdSetPortAttribfv(WFDDevice device,
                       WFDPort port,
                       WFDPortConfigAttrib attrib,
                       WFDint count,
                       const WFDfloat *value) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdBindPipelineToPort(WFDDevice device,
                          WFDPort port,
                          WFDPipeline pipeline) WFD_APIEXIT;

WFD_API_CALL WFDint WFD_APIENTRY
    wfdGetDisplayDataFormats(WFDDevice device,
                             WFDPort port,
                             WFDDisplayDataFormat *format,
                             WFDint formatCount) WFD_APIEXIT;

WFD_API_CALL WFDint WFD_APIENTRY
    wfdGetDisplayData(WFDDevice device,
                      WFDPort port,
                      WFDDisplayDataFormat format,
                      WFDuint8 *data,
                      WFDint dataCount) WFD_APIEXIT;

/* Pipeline */

WFD_API_CALL WFDint WFD_APIENTRY
    wfdEnumeratePipelines(WFDDevice device,
                          WFDint *pipelineIds,
                          WFDint pipelineIdsCount,
                          const WFDint *filterList) WFD_APIEXIT;

WFD_API_CALL WFDPipeline WFD_APIENTRY
    wfdCreatePipeline(WFDDevice device,
                      WFDint pipelineId,
                      const WFDint *attribList) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdDestroyPipeline(WFDDevice device,
                       WFDPipeline pipeline) WFD_APIEXIT;

WFD_API_CALL WFDSource WFD_APIENTRY
    wfdCreateSourceFromImage(WFDDevice device,
                             WFDPipeline pipeline,
                             WFDEGLImage image,
                             const WFDint *attribList) WFD_APIEXIT;

WFD_API_CALL WFDSource WFD_APIENTRY
    wfdCreateSourceFromStream(WFDDevice device,
                              WFDPipeline pipeline,
                              WFDNativeStreamType stream,
                              const WFDint *attribList) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdDestroySource(WFDDevice device,
                     WFDSource source) WFD_APIEXIT;

WFD_API_CALL WFDMask WFD_APIENTRY
    wfdCreateMaskFromImage(WFDDevice device,
                           WFDPipeline pipeline,
                           WFDEGLImage image,
                           const WFDint *attribList) WFD_APIEXIT;

WFD_API_CALL WFDMask WFD_APIENTRY
    wfdCreateMaskFromStream(WFDDevice device,
                            WFDPipeline pipeline,
                            WFDNativeStreamType stream,
                            const WFDint *attribList) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdDestroyMask(WFDDevice device,
                   WFDMask mask) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdBindSourceToPipeline(WFDDevice device,
                            WFDPipeline pipeline,
                            WFDSource source,
                            WFDTransition transition,
                            const WFDRect *region) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdBindMaskToPipeline(WFDDevice device,
                          WFDPipeline pipeline,
                          WFDMask mask,
                          WFDTransition transition) WFD_APIEXIT;

WFD_API_CALL WFDint WFD_APIENTRY
    wfdGetPipelineAttribi(WFDDevice device,
                          WFDPipeline pipeline,
                          WFDPipelineConfigAttrib attrib) WFD_APIEXIT;

WFD_API_CALL WFDfloat WFD_APIENTRY
    wfdGetPipelineAttribf(WFDDevice device,
                          WFDPipeline pipeline,
                          WFDPipelineConfigAttrib attrib) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdGetPipelineAttribiv(WFDDevice device,
                           WFDPipeline pipeline,
                           WFDPipelineConfigAttrib attrib,
                           WFDint count,
                           WFDint *value) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdGetPipelineAttribfv(WFDDevice device,
                           WFDPipeline pipeline,
                           WFDPipelineConfigAttrib attrib,
                           WFDint count,
                           WFDfloat *value) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdSetPipelineAttribi(WFDDevice device,
                          WFDPipeline pipeline,
                          WFDPipelineConfigAttrib attrib,
                          WFDint value) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdSetPipelineAttribf(WFDDevice device,
                          WFDPipeline pipeline,
                          WFDPipelineConfigAttrib attrib,
                          WFDfloat value) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdSetPipelineAttribiv(WFDDevice device,
                           WFDPipeline pipeline,
                           WFDPipelineConfigAttrib attrib,
                           WFDint count,
                           const WFDint *value) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdSetPipelineAttribfv(WFDDevice device,
                           WFDPipeline pipeline,
                           WFDPipelineConfigAttrib attrib,
                           WFDint count,
                           const WFDfloat *value) WFD_APIEXIT;

WFD_API_CALL WFDint WFD_APIENTRY
    wfdGetPipelineTransparency(WFDDevice device,
                               WFDPipeline pipeline,
                               WFDbitfield *trans,
                               WFDint transCount) WFD_APIEXIT;

WFD_API_CALL void WFD_APIENTRY
    wfdSetPipelineTSColor(WFDDevice device,
                          WFDPipeline pipeline,
                          WFDTSColorFormat colorFormat,
                          WFDint count,
                          const void *color) WFD_APIEXIT;

WFD_API_CALL WFDint WFD_APIENTRY
    wfdGetPipelineLayerOrder(WFDDevice device,
                             WFDPort port,
                             WFDPipeline pipeline) WFD_APIEXIT;

#ifdef __cplusplus
}
#endif

#endif /* _WFD_H_ */
