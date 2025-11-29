# OpenGL.Net Objects

Object Oriented OpenGL for C#.

OpenGL.Net.Objects abstracts OpenGL objects to reduce the effort for managing OpenGL resources and operations. The project is
implemented over [OpenGL.Net](https://github.com/luca-piccioni/OpenGL.Net), and its status is quite stable; however be warned: this is a fun-for-free-time project.

## Framework features

- Towards forward compatility, but trying to mantain older implementation support, abstracting OpenGL versions and extensions support.
- OpenGL objects abstractions
  - Graphics context, holding the OpenGL context state
  - Framebuffers and render buffers.
  - Shaders programs, objects and includes
  - Textures, samplers and texture units
  - Buffers (array, elements, uniforms, etc.) and vertex arrays
  - Server states (blending, depth test, etc.)
- Minimize OpenGL calls, by avoiding redundant calls or using an OpenGL extension.
- Standard shaders library
  - Standard shader supporting various configurations
    - Color-only
    - Material, supporting textures for diffuse, ambient, specular, normal.
    - Lighting, per vertex or per fragment
    - Shadow mapping
  - Line shader (line width state has been deprecated/removed)
  - Shader #include preprocessor, if [GL_ARB_shading_language_include](https://www.khronos.org/registry/OpenGL/extensions/ARB/ARB_shading_language_include.txt) is not supported.
  - Compatibility header for writing shaders on a variety of OpenGL implementations.
- Scene graph implementation
  - Static geometries, bounding boxes and view frustum culling
  - Camera
  - Lighting (point, directional and spot)
  - Forward rendering with state sorting
- Font drawing
  - Vector and texture font glyphs
  - Automatic vertex and texture generation
  - Instanced drawing, if supported
  - Font effects

## Class Reference

Below is a quick reference to the most important classes exposed by **OpenGL.Net.Objects**.  
Each section provides the primary responsibilities, key properties/methods, and typical usage patterns.

### 1. `GraphicsContext`

| Responsibility | Description |
|----------------|-------------|
| **State Management** | Encapsulates the current OpenGL context, including viewport, current program, bound buffers, and various render states. |
| **Context Creation** | Provides helper constructors for creating OpenGL contexts of a specific version, profile, or with debug flags. |
| **Current Context** | Static property `Current` allows retrieving the thread‑local current context. |

**Key Methods**

| Method | Purpose |
|--------|---------|
| `MakeCurrent()` | Binds the context to the current thread. |
| `SwapBuffers()` | Swaps the front and back buffers. |
| `SetState<T>(T state)` | Sets a render state object (e.g., `BlendState`). |
| `Begin()` / `End()` | Wraps a set of draw calls ensuring proper state binding. |

**Example**

```csharp
using (var ctx = new GraphicsContext(4, 5, ContextProfile.Core))
{
    ctx.MakeCurrent();
    // set clear color, enable depth test, etc.
    ctx.SwapBuffers();
}
```

---

### 2. `Framebuffer`

The **Framebuffer** class represents an OpenGL framebuffer object (FBO).  
An FBO is a collection of attachments (color, depth, stencil, and multisample buffers) that can be rendered to directly instead of the default window framebuffer.  
This class wraps all the low‑level `gl*Framebuffer*` calls and offers a type‑safe, resource‑managed API that is fully integrated with the rest of the `OpenGL.Net.Objects` framework.

| Property | Description |
|----------|-------------|
| `Id` | The native framebuffer handle. |
| `ColorAttachments` | Collection of attached color textures. |
| `DepthAttachment` | Depth renderbuffer or texture. |
| `IsComplete` | Checks `glCheckFramebufferStatus`. |

**Key Methods**

- `AttachTexture(Texture tex, FramebufferAttachment attachment)`
- `AttachRenderbuffer(Renderbuffer rb, FramebufferAttachment attachment)`
- `Bind()`, `Unbind()`

---

### 3. `Renderbuffer`

Encapsulates a renderbuffer object used typically for depth or stencil buffers.

| Property | Description |
|----------|-------------|
| `Id` | Renderbuffer handle. |
| `Format` | Internal format (e.g., `Depth24Stencil8`). |
| `Size` | Width/height of the renderbuffer. |

**Key Methods**

- `AllocateStorage(RenderbufferStorage format, int width, int height)`
- `Bind()`, `Unbind()`

---

### 4. `ShaderProgram`

Represents a linked shader program.

| Property | Description |
|----------|-------------|
| `Id` | Program handle. |
| `AttachedShaders` | List of attached `ShaderObject` instances. |
| `IsLinked` | Status of the link operation. |

**Key Methods**

- `Attach(ShaderObject shader)`
- `Link()`
- `Use()` – makes the program current.
- `SetUniform(string name, ...)` – overloaded to set ints, floats, vectors, matrices, etc.

**Example**

```csharp
var program = new ShaderProgram();
program.Attach(new ShaderObject(ShaderType.Vertex, vertSrc));
program.Attach(new ShaderObject(ShaderType.Fragment, fragSrc));
program.Link();
program.Use();
program.SetUniform("modelViewProjection", mvpMatrix);
```

---

### 5. `ShaderObject`

Represents a single shader stage (vertex, fragment, geometry, etc.).

| Property | Description |
|----------|-------------|
| `Id` | Shader handle. |
| `Type` | Shader stage (`ShaderType`). |
| `Source` | Source code string. |
| `IsCompiled` | Compilation status. |

**Key Methods**

- `Compile()`
- `GetInfoLog()`

---

### 6. `Texture`

Base class for all texture types (1D, 2D, 3D, cube map, etc.).

| Property | Description |
|----------|-------------|
| `Id` | Texture handle. |
| `Target` | Texture target (`TextureTarget`). |
| `InternalFormat` | Internal format (e.g., `RGBA8`). |
| `Size` | Texture dimensions. |

**Key Methods**

- `SetData(IntPtr data, PixelFormat format, PixelType type)`
- `SetParameters(TextureParameter param, int value)`
- `Bind(TextureUnit unit)`

**Derived classes**  
`Texture1D`, `Texture2D`, `Texture3D`, `TextureCubeMap`, etc.

---

### 7. `Sampler`

Encapsulates sampler state objects.

| Property | Description |
|----------|-------------|
| `Id` | Sampler handle. |
| `MinFilter`, `MagFilter`, `WrapS`, `WrapT`, `WrapR` | Sampler parameters. |

**Key Methods**

- `SetParameter(SamplerParameter pname, int param)`
- `Bind(TextureUnit unit)`

---

### 8. `Buffer<T>`

Generic buffer wrapper for array, element, uniform, or shader storage buffers.

| Property | Description |
|----------|-------------|
| `Id` | Buffer handle. |
| `Target` | Buffer target (`BufferTarget`). |
| `Size` | Size in bytes. |
| `Data` | Current data array. |

**Key Methods**

- `SetData(T[] data, BufferUsage usage)`
- `Bind()`, `Unbind()`
- `Map<T>()`, `Unmap()`

**Specialized buffers**  
`VertexBuffer`, `ElementBuffer`, `UniformBuffer`, `ShaderStorageBuffer`.

---

### 9. `VertexArray`

Wraps an OpenGL Vertex Array Object (VAO).

| Property | Description |
|----------|-------------|
| `Id` | VAO handle. |
| `Attributes` | List of enabled vertex attributes. |

**Key Methods**

- `EnableAttribute(int location, int size, VertexAttribPointerType type, bool normalized, int stride, int offset)`
- `Bind()`, `Unbind()`

---

### 10. `State` objects

Represent render states that can be applied globally:

- `BlendState`
- `DepthState`
- `CullState`
- `ViewportState`
- `StencilState`
- `RasterizerState`

Each state class exposes properties that map directly to the corresponding OpenGL enums and values, with convenience methods such as `Apply(GraphicsContext ctx)`.

---

## Extending the API

The library is designed to be **extensible**:

1. **Custom Shaders** – Use `ShaderProgram` and `ShaderObject` to load your own GLSL code.
2. **User‑defined State** – Derive from `State` and implement your own rendering logic.
3. **Custom Meshes** – Create `VertexBuffer`/`ElementBuffer` combinations and attach them to a `VertexArray`.

## Getting Started

1. Add the package via NuGet:
   ```bash
   dotnet add package OpenGL.Net.Objects
   ```
2. Initialize a context:
   ```csharp
   var ctx = new GraphicsContext(4, 5, ContextProfile.Core);
   ctx.MakeCurrent();
   ```
3. Create and use a simple textured quad:
   ```csharp
   var tex = new Texture2D();
   tex.SetData(imageData, PixelFormat.Rgba, PixelType.UnsignedByte);

   var vbo = new VertexBuffer(new float[] { ... }, BufferUsage.StaticDraw);
   var vao = new VertexArray();
   vao.EnableAttribute(0, 3, VertexAttribPointerType.Float, false, 5 * sizeof(float), 0);
   vao.EnableAttribute(1, 2, VertexAttribPointerType.Float, false, 5 * sizeof(float), 3 * sizeof(float));

   var shader = new ShaderProgram();
   shader.Attach(new ShaderObject(ShaderType.Vertex, vertSrc));
   shader.Attach(new ShaderObject(ShaderType.Fragment, fragSrc));
   shader.Link();
   shader.Use();

   // Render loop
   while (!window.ShouldClose)
   {
       ctx.Clear(ClearBuffer.Color | ClearBuffer.Depth);
       vao.Bind();
       vbo.Bind();
       tex.Bind(TextureUnit.Texture0);
       shader.Use();
       GL.DrawArrays(PrimitiveType.Triangles, 0, 6);
       ctx.SwapBuffers();
   }