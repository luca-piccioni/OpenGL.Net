[![build](https://ci.appveyor.com/api/projects/status/0xf5kf47uj3q586j?svg=true)](https://ci.appveyor.com/project/luca-piccioni/opengl-net) ![build](https://travis-ci.org/luca-piccioni/OpenGL.Net.svg?branch=master) [![codecov](https://codecov.io/gh/luca-piccioni/OpenGL.Net/branch/master/graph/badge.svg)](https://codecov.io/gh/luca-piccioni/OpenGL.Net) [![nuget](https://img.shields.io/nuget/v/OpenGL.Net.svg?colorB=22CC22)](https://www.nuget.org/packages/OpenGL.Net/) [![NuGet](https://img.shields.io/nuget/dt/OpenGL.Net.svg?colorB=22CC22&label=nuget%20downloads)](https://www.nuget.org/packages/OpenGL.Net/) 

[![wiki](https://img.shields.io/badge/browse-the%20wiki-blue.svg)](https://github.com/luca-piccioni/OpenGL.Net/wiki)

# OpenGL.Net
Modern OpenGL bindings for C#.

### OpenGL and related API
- [OpenGL 4.6](https://www.opengl.org/registry/), including compatibility profile.
- [OpenGL ES 3.2](https://www.khronos.org/registry/gles/), including OpenGL ES 1.0.
- [OpenGL SC 2.0](https://www.khronos.org/openglsc/); OpenGL SC 1.0 is not supported.
- WGL, GLX 1.4 and [EGL (Native Platform Interface) 1.5](https://www.khronos.org/registry/egl/) as platform APIs.
- [Broadcom VideoCore IV](http://elinux.org/Raspberry_Pi_VideoCore_APIs).
- [OpenWF Composition](https://www.khronos.org/openwf/).
- [GLU](https://www.opengl.org/resources/libraries/) (only tessellator commands).

### Features
- Generated from the lastest official XML specification
- Function pointer wrappers, with safe and unsafe parameters, pinning managed memory when necessary;
- Automatic entry points aliasing management: function loader is aware of the current OpenGL context; you can share code for OpenGL and OpenGL ES;
- Strongly typed enumerants;
- OpenGL entry points overloading;
- Fully documented OpenGL entry points with the official manual pages;
- Vector, math and color data structures. With _System.Numerics.Vector_ support.
- Automatic OpenGL extensions and implementation limits query;
- Checking errors after each OpenGL command (Debug builds only);
- Integrated entry points call logging (Debug builds only);
- Support ANGLE backend (for OpenGL ES on DirectX);

If you need more [OOP](https://en.wikipedia.org/wiki/Object-oriented_programming) with OpenGL, you can give a try to [OpenGL.Net.Objects](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects).

### Frameworks
_OpenGL.Net_ is running on a number of .NET frameworks:
- .NET Framework 3.5
- .NET Framework 4.6.1
- .NET Core 1.1
- .NET Core 2.0
- .NET Standard 2.0
- Xamarin/Android

### Toolkits
_OpenGL.Net_ is not aware(*) about the underlying platform or graphical toolkit you're running on. To create a GL context, users are required to provide a window handle and a display handle. There are sub-projects that automate the GL viewport definition and creation.

- _System.Windows.Forms_ toolkit, using an custom UserControl.
- _GTK#_ toolkit, using a custom Widget.
- _Android_, using a SurfaceView.
- _Raspberry Pi 2 VC4_, using the platform SDK.
- _OpenWF_ compatible video systems.

# Instructions

In order to use _OpenGL.Net_ you only need to link the library; due the current state of the project, it is advisable to clone the repository and work directly with the library, since this method offers more flexible solution (i.e. Debug builds).

### Clone the repository

Follow the command below to clone and build the repository.

    git clone https://github.com/luca-piccioni/OpenGL.Net.git
    cd OpenGL.Net
    msbuild /p:Configuration=Release OpenGL.Net_VC14.sln
    msbuild /p:Configuration=Release OpenGL.Net_VC15.sln

The following environments can be used:
- Visual Studio 2015 for _OpenGL.Net_VC14.sln_
- Visual Studio 2017 15.3 (Preview 2) for _OpenGL.Net_VC15.sln_

### NuGet

Open the [Package Manager Console](https://docs.nuget.org/consume/package-manager-console) and run the following command:

    Install-Package OpenGL.Net
    
You can choose to restrict the available GL profile:

    Install-Package OpenGL.Net.CoreProfile
    Install-Package OpenGL.Net.ES2Profile
    
To integrate window systems, run the most appropriate command for your platform:

    Install-Package OpenGL.Net.WinForms
    Install-Package OpenGL.Net.Xamarin.Android
    Install-Package OpenGL.Net.VideoCore

Or just download the nuget binary packages:

- [OpenGL.Net](https://www.nuget.org/packages/OpenGL.Net/)
- [OpenGL.Net - Core Profile](https://www.nuget.org/packages/OpenGL.Net.CoreProfile/)
- [OpenGL.Net - ES2+ Profile](https://www.nuget.org/packages/OpenGL.Net.ES2Profile/)
- [OpenGL.Net.WinForms](https://www.nuget.org/packages/OpenGL.Net.WinForms/): System.Windows.Forms UI integration (GlControl), supporting Windows and Linux.
- [OpenGL.Net.Xamarin.Android](https://www.nuget.org/packages/OpenGL.Net.Xamarin.Android/): Xamarin/Android UI integration.
- [OpenGL.Net.VideoCore](https://www.nuget.org/packages/OpenGL.Net.VideoCore/): Rpi Broadcom VC4 UI integration (native, no X11 support).

# Documentation

Go to the [wiki](https://github.com/luca-piccioni/OpenGL.Net/wiki) to look for information about the project. There is also a [Samples](https://github.com/luca-piccioni/OpenGL.Net/tree/master/Samples) directory, where application skeleton are implemented for various platforms.

# Licensing

The project is released under the [MIT](https://opensource.org/licenses/MIT) license. Previous revisions of the project were licensed under the _LGPL2_ licence; this kind of license seems limiting the deployment of the binary forms on some platform (ironic, isn't it?). Since the project is maintained to be useful on the widest range of platforms/user-cases, and considering the spirit of the technology used to build it ([.NET Fundation](https://dotnetfoundation.org/)), the MIT license was preferred. The [WTFPL](http://www.wtfpl.net/about/) license was considered also, but it hasn not met all requirements.
