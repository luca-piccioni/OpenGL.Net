# OpenGL.Net

Modern OpenGL bindings for C#.

## What is OpenGL.Net?

**OpenGL.Net** is a comprehensive C# binding for OpenGL 4.6, OpenGL ES 3.2, and related platform APIs (WGL, GLX, EGL). It provides strongly-typed, fully documented access to modern OpenGL functionality with automatic error checking, extension management, and cross-platform support.

### Key Features

- **Generated from Official Specifications** - Bindings automatically generated from Khronos XML specifications
- **Type-Safe** - Strongly typed enumerants and function signatures
- **Memory-Safe** - Automatic managed memory pinning with safe/unsafe parameter variants
- **Smart Context Management** - Context-aware function loading with automatic entry point aliasing
- **Fully Documented** - All entry points include official manual page documentation
- **Debug Support** - Automatic error checking and integrated call logging (Debug builds)
- **Cross-Platform** - Windows, Linux, macOS, Android, and Raspberry Pi support

### Supported APIs

- OpenGL 4.6 (including compatibility profile)
- OpenGL ES 3.2 (including ES 1.0)
- OpenGL SC 2.0 (Safety Critical)
- WGL, GLX 1.4, EGL 1.5
- Broadcom VideoCore IV (Raspberry Pi)

## Getting Started

### Requirements

- **.NET Standard 2.0** or higher
- **Platform**: Windows, Linux, macOS, Android, or Raspberry Pi
- **OpenGL drivers** installed on your system

### UI Integration

For UI framework integration, install the appropriate package:

```powershell
Install-Package OpenGL.Net.WinForms
Install-Package OpenGL.Net.CoreUI
```

## Documentation

- **[GitHub Project](https://github.com/luca-piccioni/OpenGL.Net)** - Source code and releases
- **[Wiki](https://github.com/luca-piccioni/OpenGL.Net/wiki)** - Comprehensive documentation
- **[How Do I...](https://github.com/luca-piccioni/OpenGL.Net/wiki/Wiki-%5C-How-Do-I)** - Common usage patterns
- **[Samples](https://github.com/luca-piccioni/OpenGL.Net/tree/master/Samples)** - Example applications
- **[Hello Triangle](https://github.com/luca-piccioni/OpenGL.Net/blob/master/Samples/HelloTriangle/SampleForm.cs#L40)** - Comprehensive starter application

## Feedback & Issues

Found a bug or have a feature request?

- **Report Issues**: [GitHub Issues](https://github.com/luca-piccioni/OpenGL.Net/issues)
- **Discussions**: [GitHub Discussions](https://github.com/luca-piccioni/OpenGL.Net/discussions)

Please include:
- OpenGL.Net version
- Platform and .NET runtime version
- GPU and driver information
- Minimal reproduction code

## Contributing

Contributions are welcome! Here's how you can help:

1. **Fork** the repository
2. **Create** a feature branch (`git checkout -b feature/amazing-feature`)
3. **Commit** your changes (`git commit -m 'Add amazing feature'`)
4. **Push** to the branch (`git push origin feature/amazing-feature`)
5. **Open** a Pull Request

### Development Setup

- **Windows**: Visual Studio 2022
- **Linux/macOS**: .NET SDK or Mono 4.5+

```bash
git clone https://github.com/luca-piccioni/OpenGL.Net.git
cd OpenGL.Net
dotnet build OpenGL.Net.sln
```

See the [Contributing Guide](https://github.com/luca-piccioni/OpenGL.Net/blob/master/CONTRIBUTING.md) for detailed guidelines.

## License

OpenGL.Net is licensed under the **[MIT License](https://opensource.org/licenses/MIT)**.

Copyright © 2015-2025 Luca Piccioni
