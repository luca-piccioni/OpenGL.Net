
// Copyright (C) 2016 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

#ifndef _OPENGL_HAL_MEDIA_CODEC_PLUGIN_H_
#define _OPENGL_HAL_MEDIA_CODEC_PLUGIN_H_

#include <Plugin.h>

#ifdef __cplusplus
extern "C" {
#endif

	/// Media format type definition.
	/// Merely a pointer to a constant string that identifies a generic media format.
	typedef const char *MediaFormat;

	typedef void *StreamHandle;

	typedef StreamHandle (*MediaCodecPlugin_Stream_Open)(const char *path, const char *mode);

	typedef void (*MediaCodecPlugin_Stream_Close)(StreamHandle streamHandle);

	typedef int (*MediaCodecPlugin_Stream_Read)(StreamHandle streamHandle, char *buffer, unsigned int bufferSize);

	typedef int (*MediaCodecPlugin_Stream_Write)(StreamHandle streamHandle, char *buffer, unsigned int bufferSize);

	typedef void(*MediaCodecPlugin_Stream_Seek)(StreamHandle streamHandle, int position);

	typedef struct _MediaCodecPlugin_StreamDelegates
	{
		MediaCodecPlugin_Stream_Open Open;
		MediaCodecPlugin_Stream_Close Close;
		MediaCodecPlugin_Stream_Read Read;
		MediaCodecPlugin_Stream_Write Write;
		MediaCodecPlugin_Stream_Seek Seek;
	} MediaCodecPlugin_StreamDelegates;

	typedef int (*MediaCodecPlugin_SetStreamCallbacks)(MediaCodecPlugin_StreamDelegates streamDelegates);

	/// Plugin callback: GetSupportedReadFormats
	/// 
	typedef void (*MediaCodecPlugin_GetSupportedReadFormats)(PluginHandle, MediaFormat *supportedFormats, int *count);

	/// Plugin callback: IsReadSupported
	/// 
	typedef int (*MediaCodecPlugin_IsReadSupported)(PluginHandle, MediaFormat);

	/// Plugin callback: GetSupportedWriteFormats
	/// 
	typedef void(*MediaCodecPlugin_GetSupportedWriteFormats)(PluginHandle, MediaFormat *supportedFormats, int *count);

	/// Plugin callback: IsWriteSupported
	/// 
	typedef int (*MediaCodecPlugin_IsWriteSupported)(PluginHandle, MediaFormat);

#pragma pack(push, 4)

	/// Aggregate of delegates for OpenGL.IPlugin interface.
	///
	typedef struct _MediaCodecPlugin_Delegates
	{
		/// Delegates header
		///
		Plugin_Delegates PluginDelegates;

		/// SetStreamCallbacks callback
		///
		MediaCodecPlugin_SetStreamCallbacks SetStreamCallbacks;

		/// GetSupportedReadFormats callback
		///
		MediaCodecPlugin_GetSupportedReadFormats GetSupportedReadFormats;

		/// IsReadSupported callback
		///
		MediaCodecPlugin_IsReadSupported IsReadSupported;

		/// GetSupportedWriteFormats callback
		///
		MediaCodecPlugin_GetSupportedWriteFormats GetSupportedWriteFormats;

		/// IsWriteSupported callback
		///
		MediaCodecPlugin_IsWriteSupported IsWriteSupported;

	} MediaCodecPlugin_Delegates;

#pragma pack(pop)

#ifdef __cplusplus
}
#endif

#endif