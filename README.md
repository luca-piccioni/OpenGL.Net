[![build](https://ci.appveyor.com/api/projects/status/0xf5kf47uj3q586j?svg=true)](https://ci.appveyor.com/project/luca-piccioni/opengl-net)
[![nuget](https://img.shields.io/nuget/v/OpenGL.Net.svg?colorB=22CC22)](https://www.nuget.org/packages/OpenGL.Net/)
[![NuGet](https://img.shields.io/nuget/dt/OpenGL.Net.svg?colorB=22CC22&label=nuget%20downloads)](https://www.nuget.org/packages/OpenGL.Net/)

[![wiki](https://img.shields.io/badge/browse-the%20wiki-blue.svg)](https://github.com/luca-piccioni/OpenGL.Net/wiki)

# OpenGL.Net
Modern OpenGL binding for C#.

Generated from the lastest official XML specification, _OpenGL.Net_ provides:
- Strongly typed enumerants;
- Function pointer wrappers, with safe and unsafe parameters, pinning managed memory when necessary;
- OpenGL entry points overloading;
- Automatic entry points aliasing management: function loader is aware of the current OpenGL context;
- Fully documented OpenGL entry points with the official manual pages;
- Checking errors after each OpenGL command (Debug builds only);
- Integrated entry points call logging (Debug builds only);
- Vector, math and color data structures. With _System.Numerics.Vector_ support.
- Automatic OpenGL extensions and implementation limits query;

Currently implemented API are:
- [OpenGL 4.5](https://www.opengl.org/registry/), including compatibility profile
- [OpenGL ES 3.2](https://www.khronos.org/registry/gles/), including OpenGL ES 1.0
- WGL, GLX 1.4 and [EGL (Native Platform Interface) 1.5](https://www.khronos.org/registry/egl/) as platform APIs.
- [Broadcom VideoCore IV](http://elinux.org/Raspberry_Pi_VideoCore_APIs) (alpha state)
- [OpenWF Composition](https://www.khronos.org/openwf/) (alpha state)

If you need more [OOP](https://en.wikipedia.org/wiki/Object-oriented_programming) in OpenGL, you can give a try to [OpenGL.Net.Objects](https://github.com/luca-piccioni/OpenGL.Net.Objects).

# Instructions

In order to use _OpenGL.Net_ you only need to link the library; Then it is just to write code.
Due the current state of the project, it is advisable to clone the repository and work directly with the library, since this method offers more flexible solution (i.e. Debug builds).

### Clone the repository

Follow the command below to clone and build the repository.

    git clone https://github.com/luca-piccioni/OpenGL.Net.git
    cd OpenGL.Net
    msbuild /p:Configuration=Release OpenGL.Net_VC14.sln`

The executable will be located at `OpenGL.Net/OpenGL.Net/bin/net35/Release/OpenGL.Net.dll` and `OpenGL.Net/OpenGL.Net/bin/net461/Release/OpenGL.Net.dll`.

### NuGet

Open the [Package Manager Console](https://docs.nuget.org/consume/package-manager-console) and run the following command:

    Install-Package OpenGL.Net

or just download the [nuget binary package](https://www.nuget.org/packages/OpenGL.Net/)

The nuget package does not implement any UI integration. If you need it, install one of the following nuget packages:
- [System.Windows.Forms](https://www.nuget.org/packages/OpenGL.Net.WinForms/) UI integration (GlControl).
- [Xamarin.Android](https://www.nuget.org/packages/OpenGL.Net.Xamarin.Android/) UI integration.
- [Rasperry PI 2](https://www.nuget.org/packages/OpenGL.Net.VideoCore/) UI integration (native, no X11 support).

# Documentation

Go to the [wiki](https://github.com/luca-piccioni/OpenGL.Net/wiki) to look for information about the project.

# Basic Samples

- [Hello Triangle](https://github.com/luca-piccioni/OpenGL.Net/tree/master/Samples/HelloTriangle)
- [Hello Triangle](https://github.com/luca-piccioni/OpenGL.Net/tree/master/Samples/HelloTriangle.ANGLE) using OpenGL ES 2 via ANGLE
- [Hello Triangle](https://github.com/luca-piccioni/OpenGL.Net/tree/master/Samples/HelloTriangle.Xamarin.Android) on Android
- [Hello Triangle](https://github.com/luca-piccioni/OpenGL.Net/tree/master/Samples/HelloTriangle.VideoCore) on Raspberry Pi
- [Hello Triangle](https://github.com/luca-piccioni/OpenGL.Net/tree/master/Samples/HelloTriangle.VB) in VB.Net
- [Hello Triangle](https://github.com/luca-piccioni/OpenGL.Net/tree/master/Samples/HelloTriangle.WPF) on WPF
- [Offscren Triangle](https://github.com/luca-piccioni/OpenGL.Net/tree/master/Samples/OffscreenTriangle)



