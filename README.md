# OpenGL.Net

Modern OpenGL binding for C#.

Generated from the lastest official XML specification, OpenGL.Net provides:
- Strongly typed enumerants: we like strongly-typed enumerations and flags. 
- Function pointer wrappers, with unsafe and strongly-typed arguments: because the garbage collector we're required to pin
  managed objects in order to use the OpenGL entry points; OpenGL.Net functions already fix the arguments for you. Of course
  the unmanaged pointer capability is reserved for those situation that you'll face.
- OpenGL entry points overloading.
- Automatic entry points aliasing management: many OpenGL commands were introduced in extensions, which were promoted from ARB
  or in core specification; if the semantic of these commands didn't change, they can be called equivalently. When the OpenGL
  specification assert a command equivalency, the corresponding OpenGL.Net function will fallback to equivalent commands in
  case the current host does not implement the specific core function.
- Fully documented OpenGL entry points with the official manual pages (GL2 and GL4 repositories): having a nice and complete
  documentation integrated with your IDE will be of great help.
- Integrated entry points call logging: every OpenGL call could be logged for debugging. Additionally every OpenGL command is
  checked for errors, to catch a soon as possible OpenGL errors.
- OpenGL feature-oriented design: it is possible to build a subset of the OpenGL.Net binding simply excluding specific modules.
