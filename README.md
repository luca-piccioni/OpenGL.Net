[![build](https://ci.appveyor.com/api/projects/status/0xf5kf47uj3q586j?svg=true)](https://ci.appveyor.com/project/luca-piccioni/opengl-net)
[![nuget](https://img.shields.io/nuget/v/OpenGL.Net.svg?colorB=22CC22)](https://www.nuget.org/packages/OpenGL.Net/)
[![NuGet](https://img.shields.io/nuget/dt/OpenGL.Net.svg?colorB=22CC22&label=nuget%20downloads)](https://www.nuget.org/packages/OpenGL.Net/)

[![wiki](https://img.shields.io/badge/browse-the%20wiki-brown.svg)](https://github.com/luca-piccioni/OpenGL.Net/wiki)

# OpenGL.Net
Modern OpenGL bindings for C#.

Generated from the lastest official XML specification, _OpenGL.Net_ provides:
- Function pointer wrappers, with safe and unsafe parameters, pinning managed memory when necessary;
- Automatic entry points aliasing management: function loader is aware of the current OpenGL context;
- Strongly typed enumerants;
- OpenGL entry points overloading;
- Fully documented OpenGL entry points with the official manual pages;
- Vector, math and color data structures. With _System.Numerics.Vector_ support.
- Automatic OpenGL extensions and implementation limits query;
- Checking errors after each OpenGL command (Debug builds only);
- Integrated entry points call logging (Debug builds only);

Currently implemented API are:
- [OpenGL 4.5](https://www.opengl.org/registry/), including compatibility profile
- [OpenGL ES 3.2](https://www.khronos.org/registry/gles/), including OpenGL ES 1.0
- [OpenGL SC 2.0](https://www.khronos.org/openglsc/); OpenGL SC 1.0 is not supported.
- WGL, GLX 1.4 and [EGL (Native Platform Interface) 1.5](https://www.khronos.org/registry/egl/) as platform APIs.
- [Broadcom VideoCore IV](http://elinux.org/Raspberry_Pi_VideoCore_APIs) and [OpenWF Composition](https://www.khronos.org/openwf/) (alpha state)

If you need more [OOP](https://en.wikipedia.org/wiki/Object-oriented_programming) in OpenGL, you can give a try to [OpenGL.Net.Objects](https://github.com/luca-piccioni/OpenGL.Net.Objects).

# Instructions

In order to use _OpenGL.Net_ you only need to link the library; due the current state of the project, it is advisable to clone the repository and work directly with the library, since this method offers more flexible solution (i.e. Debug builds).

### Clone the repository

Follow the command below to clone and build the repository.

    git clone https://github.com/luca-piccioni/OpenGL.Net.git
    cd OpenGL.Net
    msbuild /p:Configuration=Release OpenGL.Net_VC14.sln`

### NuGet

Open the [Package Manager Console](https://docs.nuget.org/consume/package-manager-console) and run the following command:

    Install-Package OpenGL.Net
    
To integrate window systems, run the most appropriate command for your platform:

    Install-Package OpenGL.Net.WinForms
    Install-Package OpenGL.Net.Xamarin.Android
    Install-Package OpenGL.Net.VideoCore

Or just download the nuget binary packages:

- [OpenGL.Net](https://www.nuget.org/packages/OpenGL.Net/)
- [OpenGL.Net.WinForms](https://www.nuget.org/packages/OpenGL.Net.WinForms/): System.Windows.Forms UI integration (GlControl), supporting Windows and Linux.
- [OpenGL.Net.Xamarin.Android](https://www.nuget.org/packages/OpenGL.Net.Xamarin.Android/): Xamarin/Android UI integration.
- [OpenGL.Net.VideoCore](https://www.nuget.org/packages/OpenGL.Net.VideoCore/): Rpi Broadcom VC4 UI integration (native, no X11 support).

# Documentation

Go to the [wiki](https://github.com/luca-piccioni/OpenGL.Net/wiki) to look for information about the project.

# Contributing

If you use _OpenGL.Net_, and you're willing to improve the project, your contributions are welcome.

## Create an issue

If you find something wrong during the development, you can open an issue to get help. The issue should specify all information that helps to identify the problem. The minimal information to be included should be:

- _OpenGL.Net_ version and configuration;
- Operating system;
- GPU device driver vendor, if correlated with the problem.

The common reasons for creating an issue:

- **Unexpected exceptions**: if you get an unexpected exception from _OpenGL.Net_, the issue should specify the exception stack and message.
- **Missing OpenGL API**: if you expect a GL command, a GL constant or an enumeration, but it is missing or wrong, you can create an issue about it; you can go further by checking the local gl.xml specification, and if it is reasonable, create an issue to the [Khronos GitHub repository](https://github.com/KhronosGroup/OpenGL-API/issues).
- **Toolkit integration**: you can run _OpenGL.Net_ with any toolkit on any(*) platform, just find the display and window handles. You can open an issue for requesting a support library for integrating some toolkit.
- **Missing feature**: you can request any feature implementation, if it is related to the project target.

## Pull request

Once you have created an issue, you are free to submit a pull request relative to the issue.

## Donate

If you like the project, or if it has saved you time, or you just want to offer a free beer to me, you can [![Donate](https://img.shields.io/badge/paypal-me-blue.svg)](http://paypal.me/openglnet).
