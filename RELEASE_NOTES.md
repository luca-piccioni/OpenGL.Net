
Changes with OpenGL.Net 0.4.0													03 Nov 2016
- Mantain OpenGL.Net binaries support .NET Framework 3.5 and .NET Framework 4.6.1.
- Performance improvements.

Changes with OpenGL.Net 0.3.0													03 Nov 2016

- Decoupled from System.Window.Forms dependency. OpenGL.Gl static initialization uses P/Invoke on the detected platform
  to create a native window.
- Added OpenGL.Net.WinForms: support Windows and Linux platform using .NET native window system with GlControl.
- Added OpenGL.Net.Xamarin.Android: support Android platform with GLSurfaceView
- Inherited basic code from OpenGL.Hal (and from now on excluded from repo):
	- Vertex(2|3|4)(f|i|...) and Color* structures
	- Matrix math

Changes with OpenGL.Net 0.2.1													15 Apr 2016

- Added OpenGL.GlControl, a System.Windows.Forms.UserControl allowing rendering.
- OpenGL.Gl static initialization automatically probe versions, extensions and limits of the platform (see Gl.Current*).
- OpenGL ES tested with Google ANGLE project.

Changes with OpenGL.Net 0.2.0													24 Mar 2016

- OpenGL ES 3.2 and relative extensions
- Native Platform Interface 1.5 (EGL) and relative extensions

Changes with OpenGL.Net 0.1.0													03 Mar 2016

The first public version. Exposes the following APIs:
- OpenGL 4.5 and relative extensions
- OpenGL for Windows (WGL) and relative extensions
- OpenGL for X11 1.4 (XGL) and relative extensions
- Native Platform Interface 1.5 (EGL) and relative extensions

Notable features:
- Automatic OpenGL procedure loading, including the extensions procedures
- Managed procedure arguments marshalling
- Strongly typed OpenGL enumerant constants
- Fluent OpenGL procedures overloading
- Device context abstraction (seamless management of WGL, GLX and EGL device contextes)
- Automated OpenGL, WGL, GLX and EGL extensions support query
