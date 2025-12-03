# OpenGL.Net.WinForms

Windows Forms integration for OpenGL.Net with the GlControl component.

## What is OpenGL.Net.WinForms?

**OpenGL.Net.WinForms** provides seamless OpenGL integration for Windows Forms applications through the `GlControl` component. It handles all the complexity of OpenGL context creation, pixel format selection, and rendering lifecycle, allowing you to focus on your graphics code.

### Key Features

- **Drop-in Control** - Add OpenGL rendering to any Windows Forms application
- **Designer Support** - Full Visual Studio designer integration with property grid configuration
- **Automatic Context Management** - Handles OpenGL context creation, sharing, and destruction
- **Flexible Pixel Formats** - Configure color depth, depth buffer, stencil buffer, and multisampling
- **Animation Support** - Built-in timer-based or continuous rendering modes
- **Context Sharing** - Share OpenGL resources between multiple controls
- **Profile Selection** - Choose between Core, Compatibility, Embedded (ES), or Security Critical profiles
- **Debug Support** - Automatic debug context creation when debugger is attached
- **V-Sync Control** - Configure swap interval for vertical synchronization

## Getting Started

### Requirements

- **.NET Framework 4.6.1** or higher / **.NET Core 3.1** or higher
- **Windows** operating system
- **OpenGL drivers** installed on your system

### Quick Start

#### Basic Usage

```csharp
using System;
using System.Windows.Forms;
using OpenGL;

public class MyForm : Form
{
    private GlControl glControl;

    public MyForm()
    {
        // Create the GlControl
        glControl = new GlControl();
        glControl.Dock = DockStyle.Fill;
        glControl.ColorBits = 24;
        glControl.DepthBits = 24;
        glControl.MultisampleBits = 4; // 4x MSAA
        
        // Subscribe to events
        glControl.ContextCreated += GlControl_ContextCreated;
        glControl.Render += GlControl_Render;
        
        Controls.Add(glControl);
    }

    private void GlControl_ContextCreated(object sender, GlControlEventArgs e)
    {
        // Initialize OpenGL resources here
        Gl.ClearColor(0.2f, 0.3f, 0.4f, 1.0f);
        Gl.Enable(EnableCap.DepthTest);
    }

    private void GlControl_Render(object sender, GlControlEventArgs e)
    {
        // Render your scene here
        Gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
        
        // Your rendering code...
        
        // Swap buffers is handled automatically
    }
}
```

#### Animation Mode

```csharp
// Enable continuous rendering
glControl.Animation = true;
glControl.AnimationTime = 0; // 0 = as fast as possible (limited by V-Sync)

// Or set a specific frame time (e.g., 60 FPS)
glControl.AnimationTime = 16; // ~60 FPS
```

#### Context Configuration

```csharp
// Request OpenGL 4.5 Core Profile
glControl.ContextVersion = new KhronosVersion(4, 5, KhronosVersion.ApiGl);
glControl.ContextProfile = GlControl.ProfileType.Core;

// Enable debug context (useful for development)
glControl.DebugContext = GlControl.AttributePermission.EnabledInDebugger;

// Request forward-compatible context
glControl.ForwardCompatibleContext = GlControl.AttributePermission.Enabled;
```

#### Framebuffer Configuration

```csharp
// Configure framebuffer
glControl.ColorBits = 24;        // 24-bit color
glControl.DepthBits = 24;        // 24-bit depth buffer
glControl.StencilBits = 8;       // 8-bit stencil buffer
glControl.MultisampleBits = 8;   // 8x MSAA
glControl.DoubleBuffer = true;   // Enable double buffering

// Configure V-Sync
glControl.SwapInterval = 1;      // Enable V-Sync
// glControl.SwapInterval = 0;   // Disable V-Sync
// glControl.SwapInterval = -1;  // Adaptive V-Sync (if supported)
```

#### Context Sharing

```csharp
// First control creates and owns the context
var glControl1 = new GlControl();
glControl1.ContextSharing = GlControl.ContextSharingOption.OwnContext;
glControl1.ContextSharingGroup = "MySharedGroup";

// Second control shares the same context
var glControl2 = new GlControl();
glControl2.ContextSharing = GlControl.ContextSharingOption.SingleContext;
glControl2.ContextSharingGroup = "MySharedGroup";

// Both controls can now share textures, buffers, shaders, etc.
```

### GlControl Properties

#### Context Properties
- **ContextVersion** - OpenGL version to request (e.g., 4.6, 3.3)
- **ContextProfile** - Profile type (Core, Compatibility, Embedded, SecurityCritical)
- **DebugContext** - Enable debug context for error checking
- **ForwardCompatibleContext** - Request forward-compatible context
- **RobustContext** - Enable robust buffer access

#### Framebuffer Properties
- **ColorBits** - Color buffer bit depth (default: 24)
- **DepthBits** - Depth buffer bit depth (default: 0)
- **StencilBits** - Stencil buffer bit depth (default: 0)
- **MultisampleBits** - Multisample anti-aliasing samples (default: 0)
- **DoubleBuffer** - Enable double buffering (default: true)
- **SwapInterval** - V-Sync interval (default: 1)

#### Animation Properties
- **Animation** - Enable automatic rendering (default: false)
- **AnimationTime** - Time between frames in milliseconds (default: 0)
- **AnimationTimer** - Use timer-based animation (default: true)

#### Context Sharing Properties
- **ContextSharing** - Sharing mode (OwnContext, SingleContext)
- **ContextSharingGroup** - Name of the sharing group

### GlControl Events

- **ContextCreated** - Raised when OpenGL context is created (initialize resources here)
- **ContextDestroying** - Raised before context destruction (cleanup resources here)
- **Render** - Raised when the control needs to render (draw your scene here)

### Advanced Example

```csharp
public class AdvancedGlForm : Form
{
    private GlControl glControl;
    private uint vao, vbo;

    public AdvancedGlForm()
    {
        glControl = new GlControl
        {
            Dock = DockStyle.Fill,
            ColorBits = 32,
            DepthBits = 24,
            StencilBits = 8,
            MultisampleBits = 4,
            ContextVersion = new KhronosVersion(4, 5, KhronosVersion.ApiGl),
            ContextProfile = GlControl.ProfileType.Core,
            Animation = true
        };

        glControl.ContextCreated += OnContextCreated;
        glControl.ContextDestroying += OnContextDestroying;
        glControl.Render += OnRender;

        Controls.Add(glControl);
    }

    private void OnContextCreated(object sender, GlControlEventArgs e)
    {
        // Check OpenGL version
        Console.WriteLine($"OpenGL {Gl.CurrentVersion}");
        Console.WriteLine($"GLSL {Gl.CurrentShadingVersion}");
        Console.WriteLine($"Renderer: {Gl.CurrentRenderer}");

        // Create vertex array and buffer
        vao = Gl.GenVertexArray();
        vbo = Gl.GenBuffer();

        // Setup rendering state
        Gl.ClearColor(0.1f, 0.1f, 0.1f, 1.0f);
        Gl.Enable(EnableCap.DepthTest);
        Gl.Enable(EnableCap.Multisample);
    }

    private void OnContextDestroying(object sender, GlControlEventArgs e)
    {
        // Cleanup OpenGL resources
        Gl.DeleteBuffers(vbo);
        Gl.DeleteVertexArrays(vao);
    }

    private void OnRender(object sender, GlControlEventArgs e)
    {
        // Clear buffers
        Gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

        // Render your scene...
        
        // Buffer swap is automatic
    }
}
```

## Documentation

- **[GitHub Project](https://github.com/luca-piccioni/OpenGL.Net)** - Source code and releases
- **[Wiki](https://github.com/luca-piccioni/OpenGL.Net/wiki)** - Comprehensive documentation
- **[Samples](https://github.com/luca-piccioni/OpenGL.Net/tree/master/Samples)** - Example applications
- **[Hello Triangle](https://github.com/luca-piccioni/OpenGL.Net/blob/master/Samples/HelloTriangle/SampleForm.cs#L40)** - Complete WinForms example

## Feedback & Issues

Found a bug or have a feature request?

- **Report Issues**: [GitHub Issues](https://github.com/luca-piccioni/OpenGL.Net/issues)
- **Discussions**: [GitHub Discussions](https://github.com/luca-piccioni/OpenGL.Net/discussions)

Please include:
- OpenGL.Net.WinForms version
- Windows and .NET version
- GPU and driver information
- Minimal reproduction code

## Contributing

Contributions are welcome! See the main [OpenGL.Net Contributing Guide](https://github.com/luca-piccioni/OpenGL.Net/blob/master/CONTRIBUTING.md) for guidelines.

## License

OpenGL.Net.WinForms is licensed under the **[MIT License](https://opensource.org/licenses/MIT)**.

Copyright © 2015-2025 Luca Piccioni
