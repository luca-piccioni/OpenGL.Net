
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

#ifndef _OPENGL_HAL_PLUGIN_H_
#define _OPENGL_HAL_PLUGIN_H_

#include <PluginApi.h>

#ifdef __cplusplus
extern "C" {
#endif

	/// The type of the plugin handle.
	/// Plugin implementation can store any opaque structure. It will be passed on each callback implemented.
	typedef void *PluginHandle;

	/// Plugin callback: create handle
	/// Called for instantiating a plugin instance.
	typedef PluginHandle (*Plugin_Create)();

	/// Plugin callback: destroy handle
	/// Called for disposing a plugin instance.
	typedef void (*Plugin_Destroy)(PluginHandle);

	/// Plugin callback: get name
	/// 
	typedef const char *(*Plugin_GetName)(PluginHandle);

	/// Plugin callback: get name
	/// 
	typedef int (*Plugin_CheckAvailability)(PluginHandle);

#pragma pack(push, 4)

	/// Aggregate of delegates for OpenGL.IPlugin interface.
	///
	typedef struct _Plugin_Delegates
	{
		/// Create callback
		///
		Plugin_Create Create;

		/// Destroy callback
		///
		Plugin_Destroy Destroy;

		/// GetName callback
		///
		Plugin_GetName GetName;

		/// CheckAvailability callback
		///
		Plugin_CheckAvailability CheckAvailability;

	} Plugin_Delegates;

#pragma pack(pop)

#ifdef __cplusplus
}
#endif

#endif
