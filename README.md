[![build](https://ci.appveyor.com/api/projects/status/0xf5kf47uj3q586j?svg=true)](https://ci.appveyor.com/project/luca-piccioni/opengl-net) ![build](https://travis-ci.org/luca-piccioni/OpenGL.Net.svg?branch=master) [![codecov](https://codecov.io/gh/luca-piccioni/OpenGL.Net/branch/master/graph/badge.svg)](https://codecov.io/gh/luca-piccioni/OpenGL.Net) [![nuget](https://img.shields.io/nuget/v/OpenGL.Net.svg?colorB=22CC22)](https://www.nuget.org/packages/OpenGL.Net/) [![NuGet](https://img.shields.io/nuget/dt/OpenGL.Net.svg?colorB=22CC22&label=nuget%20downloads)](https://www.nuget.org/packages/OpenGL.Net/) 

[![wiki](https://img.shields.io/badge/browse-the%20wiki-blue.svg)](https://github.com/luca-piccioni/OpenGL.Net/wiki)

# OpenGL.Net
Modern OpenGL bindings for C#.

## OpenGL
- [OpenGL 4.6](https://www.opengl.org/registry/), including compatibility profile.
- [OpenGL ES 3.2](https://www.khronos.org/registry/gles/), including OpenGL ES 1.0.
- [OpenGL SC 2.0](https://www.khronos.org/openglsc/); OpenGL SC 1.0 is not supported.
- WGL, GLX 1.4 and [EGL (Native Platform Interface) 1.5](https://www.khronos.org/registry/egl/) as platform APIs.
- [Broadcom VideoCore IV](http://elinux.org/Raspberry_Pi_VideoCore_APIs).
- [GLU](https://www.opengl.org/resources/libraries/) (only tessellator commands).

### Features
- Generated from the lastest official XML specification
- Function pointer wrappers, with safe and unsafe parameters, pinning managed memory when necessary;
- Automatic entry points aliasing management: function loader is aware of the current OpenGL context; you can share code for OpenGL and OpenGL ES;
- Strongly typed enumerants;
- OpenGL entry points overloading;
- Fully documented OpenGL entry points with the official manual pages;
- Automatic OpenGL extensions and implementation limits query;
- Checking errors after each OpenGL command (Debug builds only);
- Integrated entry points call logging (Debug builds only);
- Support ANGLE backend (for OpenGL ES on DirectX);
- Vector, math and color data structures. With _System.Numerics.Vector_ support.

If you need more [OOP](https://en.wikipedia.org/wiki/Object-oriented_programming) with OpenGL, you can give a try to [OpenGL.Net.Objects](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects).

### Frameworks
_OpenGL.Net_ is running on a number of .NET frameworks:
- .NET Framework 3.5
- .NET Framework 4.6.1
- Xamarin/Android
- .NET Core 1.1
- .NET Core 2.0
- .NET Standard 2.0/1.4/1.1 (under development)

### Toolkits
_OpenGL.Net_ is not aware(*) about the underlying platform or graphical toolkit you're running on. To create a GL context, users are required to provide a window handle and a display handle. There are sub-projects that automate the GL viewport definition and creation.

- _System.Windows.Forms_ toolkit, using an custom UserControl.
- _GTK#_ toolkit, using a custom Widget (need support).
- _Android_, using a SurfaceView (need support).
- _Raspberry Pi 2 VC4_, using the platform SDK (need support).
- _OpenWF_ compatible video systems (need support).

### NuGet
Open the [Package Manager Console](https://docs.nuget.org/consume/package-manager-console) and run the following command:

    Install-Package OpenGL.Net
    
You can choose to restrict the available GL profile:

    Install-Package OpenGL.Net.CoreProfile
    Install-Package OpenGL.Net.ES2Profile

Math data structures:

    Install-Package OpenGL.Net.Math
    
To integrate window systems, run the most appropriate command for your platform:

    Install-Package OpenGL.Net.WinForms
    Install-Package OpenGL.Net.Xamarin.Android
    Install-Package OpenGL.Net.VideoCore

## OpenVX
Bindings for [OpenVX 1.2](https://www.khronos.org/openvx/); currently under development, but the sample is running well.

### Features
- Strongly typed;
- Includes VXU commands;

## OpenWF
[OpenWF Composition](https://www.khronos.org/openwf/).

# Instructions

In order to use _OpenGL.Net_ you only need to link the library; due the current state of the project, it is advisable to clone the repository and work directly with the library, since this method offers more flexible solution (i.e. Debug builds).

### Clone the repository

Follow the command below to clone and build the repository.

    git clone https://github.com/luca-piccioni/OpenGL.Net.git
    cd OpenGL.Net
    msbuild /p:Configuration=Release OpenGL.Net_VC14.sln
    msbuild /p:Configuration=Release OpenGL.Net_VC15.sln
    msbuild /p:Configuration=Release OpenGL.Net_Mono.sln

The following environments can be used:
- Visual Studio 2015 for _OpenGL.Net_VC14.sln_
- Visual Studio 2017 15.3 (Preview 2) for _OpenGL.Net_VC15.sln_
- Mono 4.5 for _OpenGL.Net_Mono.sln_; as alternative, you can build using `xbuild`

# Documentation

Go to the [wiki](https://github.com/luca-piccioni/OpenGL.Net/wiki) to look for information about the project. There is also a [Samples](https://github.com/luca-piccioni/OpenGL.Net/tree/master/Samples) directory, where application skeleton are implemented for various platforms.

# Acknowledgements

Many tools and services are required to build and run OpenGL.Net.

[<img src="https://github.com/luca-piccioni/OpenGL.Net/blob/master/Wiki/Supporter-AppVeyor.png" width="335" height="70">](https://www.appveyor.com/)[<img src="https://github.com/luca-piccioni/OpenGL.Net/blob/master/Wiki/Supporter-TravisCI.png" width="125" height="124">](https://travis-ci.org/)[<img src="https://files.readme.io/9d08c4c-back.png" width="125" height="125">](https://codecov.io/)

[<img src="https://upload.wikimedia.org/wikipedia/commons/thumb/6/61/Visual_Studio_2017_logo_and_wordmark.svg/640px-Visual_Studio_2017_logo_and_wordmark.svg.png" width="640" height="108">](https://www.visualstudio.com/)
[<img src="https://upload.wikimedia.org/wikipedia/commons/thumb/6/68/Xamarin_logo_and_wordmark.png/320px-Xamarin_logo_and_wordmark.png" width="320" height="87">](https://www.xamarin.com/)
[<img src="https://github.com/luca-piccioni/OpenGL.Net/blob/master/Wiki/Supporter-Resharper.png" width="125" height="125">](https://www.jetbrains.com/resharper/)[<img src="https://raw.githubusercontent.com/nunit/resources/master/images/icon/nunit_256.png" width="125" height="125">](https://github.com/nunit/nunit)



# Licensing

The project is released under the [MIT](https://opensource.org/licenses/MIT) license. Previous revisions of the project were licensed under the _LGPL2_ licence; this kind of license seems limiting the deployment of the binary forms on some platform (ironic, isn't it?). Since the project is maintained to be useful on the widest range of platforms/user-cases, and considering the spirit of the technology used to build it ([.NET Fundation](https://dotnetfoundation.org/)), the MIT license was preferred. The [WTFPL](http://www.wtfpl.net/about/) license was considered also, but it has not met all requirements.
