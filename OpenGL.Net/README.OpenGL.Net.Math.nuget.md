# OpenGL.Net.Math

Mathematics library for OpenGL.Net with vector, matrix, and color structures.

## What is OpenGL.Net.Math?

**OpenGL.Net.Math** provides a comprehensive set of mathematical data structures optimized for OpenGL applications. It includes strongly-typed vertex, matrix, color, and geometric primitives with full operator support and multiple precision levels.

### Key Features

- **Vertex Types** - 2D, 3D, and 4D vertices with multiple data types (byte, short, int, float, double)
- **Matrix Types** - 2x2, 3x3, 4x4 matrices with transformation operations (rotation, translation, scaling)
- **Color Types** - RGB and RGBA colors in various formats (8-bit, 16-bit, 32-bit, float, HalfFloat)
- **Geometric Primitives** - Plane, Quaternion for advanced 3D operations
- **Operator Overloading** - Full arithmetic and comparison operators for intuitive math operations
- **Type Conversions** - Seamless casting between different precision levels
- **Memory Layout Control** - Explicit struct layouts for direct GPU buffer usage

## Getting Started

### Requirements

- **.NET Standard 2.0** or higher

### Quick Start

#### Working with Vertices

```csharp
using OpenGL;

// Create 3D vertices
Vertex3f position = new Vertex3f(1.0f, 2.0f, 3.0f);
Vertex3f direction = new Vertex3f(0.0f, 1.0f, 0.0f);

// Vector operations
Vertex3f result = position + direction;
float length = position.Module();
Vertex3f normalized = position.Normalized;

// Dot and cross products
float dot = position * direction;
```

#### Working with Matrices

```csharp
// Create transformation matrices
Matrix4x4f translation = Matrix4x4f.Translated(10.0f, 0.0f, 0.0f);
Matrix4x4f rotation = Matrix4x4f.RotatedY(45.0f);
Matrix4x4f scale = Matrix4x4f.Scaled(2.0f, 2.0f, 2.0f);

// Combine transformations
Matrix4x4f transform = translation * rotation * scale;

// Transform vertices
Vertex3f transformed = transform * position;

// Matrix operations
Matrix4x4f inverse = transform.Inverse;
Matrix4x4f transposed = transform.Transposed;
float determinant = transform.Determinant;
```

#### Working with Colors

```csharp
// Create colors
ColorRGBA32 red = new ColorRGBA32(255, 0, 0, 255);
ColorRGBAF blue = new ColorRGBAF(0.0f, 0.0f, 1.0f, 1.0f);

// Predefined colors
ColorRGBA32 white = ColorRGBA32.ColorWhite;
ColorRGBA32 black = ColorRGBA32.ColorBlack;

// Color operations
ColorRGBA32 blended = red * 0.5f;

// Convert between formats
ColorRGBAF highPrecision = new ColorRGBAF(red[0], red[1], red[2], red[3]);
```

#### Working with Quaternions

```csharp
// Create quaternions for rotations
Quaternion rotation = Quaternion.RotationAxis(Vertex3f.UnitY, 90.0f);

// Quaternion operations
Quaternion conjugate = rotation.Conjugate;
Quaternion inverse = rotation.Inverse;
float magnitude = rotation.Magnitude;

// Apply rotation to vector
Vertex3f rotated = rotation.Rotate(position);
```

### Available Types

#### Vertex Types
- **Vertex2** - 2D vertices (byte, short, int, uint, float, double variants)
- **Vertex3** - 3D vertices (byte, short, int, uint, float, double, HalfFloat variants)
- **Vertex4** - 4D vertices (byte, short, int, uint, float, double, HalfFloat variants)

#### Matrix Types
- **Matrix2x2** - 2×2 matrices (float, double variants)
- **Matrix3x3** - 3×3 matrices (float, double variants)
- **Matrix4x4** - 4×4 matrices (float, double variants)

#### Color Types
- **ColorRGB** - RGB colors (24-bit, 48-bit, 96-bit float variants)
- **ColorRGBA** - RGBA colors (32-bit, 64-bit, 128-bit float, HalfFloat variants)

#### Geometric Types
- **Plane** - 3D plane representation (float, double variants)
- **Quaternion** - Rotation quaternions
- **Angle** - Angle utilities with degree/radian conversions

## Documentation

- **[GitHub Project](https://github.com/luca-piccioni/OpenGL.Net)** - Source code and releases
- **[Wiki](https://github.com/luca-piccioni/OpenGL.Net/wiki)** - Comprehensive documentation
- **[How Do I...](https://github.com/luca-piccioni/OpenGL.Net/wiki/Wiki-%5C-How-Do-I)** - Common usage patterns
- **[Main README](https://github.com/luca-piccioni/OpenGL.Net/blob/master/README.md)** - Project overview

## Feedback & Issues

Found a bug or have a feature request?

- **Report Issues**: [GitHub Issues](https://github.com/luca-piccioni/OpenGL.Net/issues)
- **Discussions**: [GitHub Discussions](https://github.com/luca-piccioni/OpenGL.Net/discussions)

Please include:
- OpenGL.Net.Math version
- Platform and .NET runtime version
- Minimal reproduction code

## Contributing

Contributions are welcome! See the main [OpenGL.Net Contributing Guide](https://github.com/luca-piccioni/OpenGL.Net/blob/master/CONTRIBUTING.md) for guidelines.

## License

OpenGL.Net.Math is licensed under the **[MIT License](https://opensource.org/licenses/MIT)**.

Copyright © 2015-2025 Luca Piccioni
