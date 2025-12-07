[![CI Build](https://github.com/luca-piccioni/OpenGL.Net/workflows/CI%20Build/badge.svg)](https://github.com/luca-piccioni/OpenGL.Net/actions) [![codecov](https://codecov.io/gh/luca-piccioni/OpenGL.Net/graph/badge.svg?token=eIRrFCqFPo)](https://codecov.io/gh/luca-piccioni/OpenGL.Net) [![nuget](https://img.shields.io/nuget/v/OpenGL.Net.svg?colorB=22CC22)](https://www.nuget.org/packages/OpenGL.Net/) [![NuGet](https://img.shields.io/nuget/dt/OpenGL.Net.svg?colorB=22CC22&label=nuget%20downloads)](https://www.nuget.org/packages/OpenGL.Net/) 

[![wiki](https://img.shields.io/badge/browse-the%20wiki-blue.svg)](https://github.com/luca-piccioni/OpenGL.Net/wiki)

# OpenGL.Net

Modern OpenGL bindings for C#.

**OpenGL.Net** is a comprehensive C# binding for OpenGL, OpenGL ES, and related APIs. It provides strongly-typed, fully documented access to modern OpenGL functionality with automatic error checking, extension management, and cross-platform support.

## Table of Contents

- [Features](#features)
- [Supported APIs](#supported-apis)
- [Platform & Framework Support](#platform--framework-support)
- [Installation](#installation)
- [Getting Started](#getting-started)
- [Building from Source](#building-from-source)
- [Documentation](#documentation)
- [Acknowledgements](#acknowledgements)
- [License](#license)

## Features

- **Generated from Official Specifications**: Bindings are automatically generated from the latest official Khronos XML specifications
- **Type Safety**: Strongly typed enumerants and function signatures
- **Memory Safety**: Function pointer wrappers with safe and unsafe parameter variants, automatically pinning managed memory when necessary
- **Smart Context Management**: Automatic entry point aliasing - the function loader is context-aware, allowing you to share code between OpenGL and OpenGL ES
- **Comprehensive Documentation**: All OpenGL entry points are fully documented with official manual pages
- **Extension Support**: Automatic querying of OpenGL extensions and implementation limits
- **Debug Features**: 
  - Automatic error checking after each OpenGL command (Debug builds only)
  - Integrated call logging for debugging (Debug builds only)
- **Math Library**: Vector, matrix, and color data structures with `System.Numerics.Vector` support
- **Function Overloading**: Multiple convenient overloads for OpenGL entry points
- **ANGLE Support**: Compatible with ANGLE backend for running OpenGL ES on DirectX

For a more object-oriented approach to OpenGL, see [OpenGL.Net.Objects](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects).

## Supported APIs

### OpenGL
- **[OpenGL 4.6](https://www.opengl.org/registry/)** - Full support including compatibility profile
- **[OpenGL ES 3.2](https://www.khronos.org/registry/gles/)** - Complete support, including OpenGL ES 1.0
- **[OpenGL SC 2.0](https://www.khronos.org/openglsc/)** - Safety Critical profile (OpenGL SC 1.0 is not supported)

### Platform APIs
- **WGL** - Windows OpenGL interface
- **GLX 1.4** - X Window System OpenGL interface
- **[EGL 1.5](https://www.khronos.org/registry/egl/)** - Native Platform Interface for embedded systems
- **[Broadcom VideoCore IV](http://elinux.org/Raspberry_Pi_VideoCore_APIs)** - Raspberry Pi GPU support

### Utilities
- **[GLU](https://www.opengl.org/resources/libraries/)** - OpenGL Utility Library (tessellator commands only)

## Installation

### NuGet Packages

The easiest way to use OpenGL.Net is via NuGet. Open the [Package Manager Console](https://docs.nuget.org/consume/package-manager-console) and run:

#### Core Library

```powershell
Install-Package OpenGL.Net
```

#### Profile-Specific Variants

If you want to restrict the available OpenGL profile:

```powershell
Install-Package OpenGL.Net.CoreProfile    # Core profile only
Install-Package OpenGL.Net.ES2Profile     # OpenGL ES 2.0 profile
Install-Package OpenGL.Net.SC2Profile     # OpenGL SC 2.0 profile
```

#### Math Library

```powershell
Install-Package OpenGL.Net.Math
```

#### Platform Integration

```powershell
Install-Package OpenGL.Net.WinForms           # Windows Forms
Install-Package OpenGL.Net.Xamarin.Android    # Xamarin Android
Install-Package OpenGL.Net.VideoCore          # Raspberry Pi
Install-Package OpenGL.Net.GTK3               # GTK# 3
```

#### Object-Oriented Layer

```powershell
Install-Package OpenGL.Net.Objects
```

## Getting Started

For complete examples, see the [Samples](https://github.com/luca-piccioni/OpenGL.Net/tree/master/Samples) directory, including the comprehensive [Hello Triangle](https://github.com/luca-piccioni/OpenGL.Net/blob/master/Samples/HelloTriangle/SampleForm.cs#L40) sample.

## Building from Source

### Prerequisites

- **Windows**: Visual Studio 2022/VS Code + .NET Core SDKs
- **Linux/macOS**: VS Code + .NET Core SDKs

### Clone and Build

```bash
git clone https://github.com/luca-piccioni/OpenGL.Net.git
cd OpenGL.Net
dotnet build
```

## Documentation

- **[Wiki](https://github.com/luca-piccioni/OpenGL.Net/wiki)** - Comprehensive project documentation
- **[How Do I...](https://github.com/luca-piccioni/OpenGL.Net/wiki/Wiki-%5C-How-Do-I)** - Common usage patterns and recipes
- **[Samples](https://github.com/luca-piccioni/OpenGL.Net/tree/master/Samples)** - Example applications for various platforms
- **[Hello Triangle](https://github.com/luca-piccioni/OpenGL.Net/blob/master/Samples/HelloTriangle/SampleForm.cs#L40)** - Comprehensive, documented starter application

## Acknowledgements

OpenGL.Net is built with the help of many excellent tools and services:

## License

OpenGL.Net is released under the **[MIT License](https://opensource.org/licenses/MIT)**.

**Copyright © 2015-2025 Luca Piccioni**

Previous versions of the project were licensed under LGPL2. The license was changed to MIT to ensure maximum compatibility across all platforms and use cases, aligning with the spirit of the [.NET Foundation](https://dotnetfoundation.org/).

---

**Note**: While OpenGL 4.6 (released July 2017) remains the latest version of OpenGL, the Khronos Group has shifted focus to Vulkan for future graphics API development. OpenGL.Net continues to provide comprehensive support for OpenGL 4.6 and OpenGL ES 3.2, which remain widely used across many platforms and applications.
