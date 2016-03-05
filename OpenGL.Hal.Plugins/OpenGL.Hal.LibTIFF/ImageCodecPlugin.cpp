
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

#include <cstdio>

#include <ImageCodecPlugin.h>

#ifdef __cplusplus
extern "C" {
#endif
	
	PLUGIN_API MediaCodecPlugin_Delegates CreateImageCodecPluginFactory();

	PLUGIN_API const char *GetName(PluginHandle pluginHandle);

	PLUGIN_API int CheckAvailability(PluginHandle);

#ifdef __cplusplus
}
#endif

PLUGIN_API MediaCodecPlugin_Delegates CreateImageCodecPluginFactory()
{
	MediaCodecPlugin_Delegates delegates;

	delegates.PluginDelegates.GetName = GetName;

	return (delegates);
}

PLUGIN_API const char *GetName(PluginHandle) { return ("OpenGL.Hal.LibTiff"); }

PLUGIN_API int CheckAvailability(PluginHandle) { return (1); }