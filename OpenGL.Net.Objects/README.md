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
