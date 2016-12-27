# OpenGL.Net Objects

Object Oriented OpenGL for C#.

OpenGL.Net.Objects abstracts OpenGL objects to reduce the effort for managing OpenGL resources and operations. The project is
implemented over OpenGL.Net, and its status is quite stable; however be warned: this is a fun-for-free-time project.

Framework features:
- Towards forward compatility, but trying to mantain older implementation support, abstracting OpenGL versions and extensions support.
- Minimize OpenGL calls, by avoiding redundant calls or using an OpenGL extension.

## Framework OpenGL objects

OpenGL defines a set of objects classes; each object instance holds a state and a set of functions to process the information. The
implementation try to be the most complete and correct, with respect to the OpenGL specification.

### [GraphicsContext](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects/)

The graphics context is the abstraction of the OpenGL server state, holding all the information required for rasterizing the information
provided to the GPU.

GraphicsContext features:
- Context thread currency
- Lazy resource binding
- Asynchronous GL resource management

### Textures
	
- [1D Texture](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects/Texture1d.cs)
- [2D Texture](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects/Texture2d.cs)
- [Rectangle Texture](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects/TextureRectangle.cs)
- [3D Texture](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects/Texture3d.cs)
- [Array 2D Texture](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects/TextureArray2d.cs)
- [Cube Texture](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects/TextureCube.cs)

### Buffers

- [Array Buffer](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects/ArrayBufferObject.cs)
- [Element Buffer](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects/ElementBufferObject.cs)
- [Feedback Buffer](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects/FeedbackBufferObject.cs)
- [Vertex Array](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects/VertexArrayObject.cs)

### Shading

- [Shader Object](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects/ShaderObject.cs)
- [Shader Program](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects/ShaderProgram.cs)
- [Shader Include](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects/ShaderInclude.cs)

### OpenGL States

- [Blend](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects/BlendState.cs)
- [Culling](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects/CullFaceState.cs)
- [Polygon Mode](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects/PolygonModeState.cs)
- [Polygon Offset](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects/PolygonOffsetState.cs)
- [Depth Test](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects/DepthTestState.cs)

## Framework shaders

The framework already implements variuos shader functions and programs. It exposes shading objects implementing commong
functions, and fluently integrates with ShaderProgram and GraphicsState implementations.

- Light Shading
	- Lights: directional, point, spot (*)
	- Materials
	- Light models: Lambert, Blinn, Phong (*)
- Standard shading
	- Constant color
	- Lighting per-vertex
	- Lighting per-fragment
	- Lighting per-vertex, but separated specular lighting per-fragment
	- Refraction and reflections (*)
- Sky box shading

## Framework scene graph:

## Framework utilities:
	
- Image Codecs
- Mesh Codecs
- [Vincenty implementation](https://github.com/luca-piccioni/OpenGL.Net/tree/master/OpenGL.Net.Objects/Vincenty.cs)