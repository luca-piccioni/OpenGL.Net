
// Copyright (C) 2015 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_MAX_VERTEX_STREAMS_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public const int MAX_VERTEX_STREAMS_ATI = 0x876B;

		/// <summary>
		/// Value of GL_VERTEX_STREAM0_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public const int VERTEX_STREAM0_ATI = 0x876C;

		/// <summary>
		/// Value of GL_VERTEX_STREAM1_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public const int VERTEX_STREAM1_ATI = 0x876D;

		/// <summary>
		/// Value of GL_VERTEX_STREAM2_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public const int VERTEX_STREAM2_ATI = 0x876E;

		/// <summary>
		/// Value of GL_VERTEX_STREAM3_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public const int VERTEX_STREAM3_ATI = 0x876F;

		/// <summary>
		/// Value of GL_VERTEX_STREAM4_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public const int VERTEX_STREAM4_ATI = 0x8770;

		/// <summary>
		/// Value of GL_VERTEX_STREAM5_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public const int VERTEX_STREAM5_ATI = 0x8771;

		/// <summary>
		/// Value of GL_VERTEX_STREAM6_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public const int VERTEX_STREAM6_ATI = 0x8772;

		/// <summary>
		/// Value of GL_VERTEX_STREAM7_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public const int VERTEX_STREAM7_ATI = 0x8773;

		/// <summary>
		/// Value of GL_VERTEX_SOURCE_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public const int VERTEX_SOURCE_ATI = 0x8774;

		/// <summary>
		/// Binding for glVertexStream1sATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream1ATI(Int32 stream, Int16 x)
		{
			Debug.Assert(Delegates.pglVertexStream1sATI != null, "pglVertexStream1sATI not implemented");
			Delegates.pglVertexStream1sATI(stream, x);
			LogFunction("glVertexStream1sATI({0}, {1})", LogEnumName(stream), x);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream1svATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream1ATI(Int32 stream, Int16[] coords)
		{
			unsafe {
				fixed (Int16* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertexStream1svATI != null, "pglVertexStream1svATI not implemented");
					Delegates.pglVertexStream1svATI(stream, p_coords);
					LogFunction("glVertexStream1svATI({0}, {1})", LogEnumName(stream), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream1iATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream1ATI(Int32 stream, Int32 x)
		{
			Debug.Assert(Delegates.pglVertexStream1iATI != null, "pglVertexStream1iATI not implemented");
			Delegates.pglVertexStream1iATI(stream, x);
			LogFunction("glVertexStream1iATI({0}, {1})", LogEnumName(stream), x);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream1ivATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream1ATI(Int32 stream, Int32[] coords)
		{
			unsafe {
				fixed (Int32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertexStream1ivATI != null, "pglVertexStream1ivATI not implemented");
					Delegates.pglVertexStream1ivATI(stream, p_coords);
					LogFunction("glVertexStream1ivATI({0}, {1})", LogEnumName(stream), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream1fATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream1ATI(Int32 stream, float x)
		{
			Debug.Assert(Delegates.pglVertexStream1fATI != null, "pglVertexStream1fATI not implemented");
			Delegates.pglVertexStream1fATI(stream, x);
			LogFunction("glVertexStream1fATI({0}, {1})", LogEnumName(stream), x);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream1fvATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream1ATI(Int32 stream, float[] coords)
		{
			unsafe {
				fixed (float* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertexStream1fvATI != null, "pglVertexStream1fvATI not implemented");
					Delegates.pglVertexStream1fvATI(stream, p_coords);
					LogFunction("glVertexStream1fvATI({0}, {1})", LogEnumName(stream), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream1dATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream1ATI(Int32 stream, double x)
		{
			Debug.Assert(Delegates.pglVertexStream1dATI != null, "pglVertexStream1dATI not implemented");
			Delegates.pglVertexStream1dATI(stream, x);
			LogFunction("glVertexStream1dATI({0}, {1})", LogEnumName(stream), x);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream1dvATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream1ATI(Int32 stream, double[] coords)
		{
			unsafe {
				fixed (double* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertexStream1dvATI != null, "pglVertexStream1dvATI not implemented");
					Delegates.pglVertexStream1dvATI(stream, p_coords);
					LogFunction("glVertexStream1dvATI({0}, {1})", LogEnumName(stream), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream2sATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream2ATI(Int32 stream, Int16 x, Int16 y)
		{
			Debug.Assert(Delegates.pglVertexStream2sATI != null, "pglVertexStream2sATI not implemented");
			Delegates.pglVertexStream2sATI(stream, x, y);
			LogFunction("glVertexStream2sATI({0}, {1}, {2})", LogEnumName(stream), x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream2svATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream2ATI(Int32 stream, Int16[] coords)
		{
			unsafe {
				fixed (Int16* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertexStream2svATI != null, "pglVertexStream2svATI not implemented");
					Delegates.pglVertexStream2svATI(stream, p_coords);
					LogFunction("glVertexStream2svATI({0}, {1})", LogEnumName(stream), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream2iATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream2ATI(Int32 stream, Int32 x, Int32 y)
		{
			Debug.Assert(Delegates.pglVertexStream2iATI != null, "pglVertexStream2iATI not implemented");
			Delegates.pglVertexStream2iATI(stream, x, y);
			LogFunction("glVertexStream2iATI({0}, {1}, {2})", LogEnumName(stream), x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream2ivATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream2ATI(Int32 stream, Int32[] coords)
		{
			unsafe {
				fixed (Int32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertexStream2ivATI != null, "pglVertexStream2ivATI not implemented");
					Delegates.pglVertexStream2ivATI(stream, p_coords);
					LogFunction("glVertexStream2ivATI({0}, {1})", LogEnumName(stream), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream2fATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream2ATI(Int32 stream, float x, float y)
		{
			Debug.Assert(Delegates.pglVertexStream2fATI != null, "pglVertexStream2fATI not implemented");
			Delegates.pglVertexStream2fATI(stream, x, y);
			LogFunction("glVertexStream2fATI({0}, {1}, {2})", LogEnumName(stream), x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream2fvATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream2ATI(Int32 stream, float[] coords)
		{
			unsafe {
				fixed (float* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertexStream2fvATI != null, "pglVertexStream2fvATI not implemented");
					Delegates.pglVertexStream2fvATI(stream, p_coords);
					LogFunction("glVertexStream2fvATI({0}, {1})", LogEnumName(stream), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream2dATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream2ATI(Int32 stream, double x, double y)
		{
			Debug.Assert(Delegates.pglVertexStream2dATI != null, "pglVertexStream2dATI not implemented");
			Delegates.pglVertexStream2dATI(stream, x, y);
			LogFunction("glVertexStream2dATI({0}, {1}, {2})", LogEnumName(stream), x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream2dvATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream2ATI(Int32 stream, double[] coords)
		{
			unsafe {
				fixed (double* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertexStream2dvATI != null, "pglVertexStream2dvATI not implemented");
					Delegates.pglVertexStream2dvATI(stream, p_coords);
					LogFunction("glVertexStream2dvATI({0}, {1})", LogEnumName(stream), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream3sATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream3ATI(Int32 stream, Int16 x, Int16 y, Int16 z)
		{
			Debug.Assert(Delegates.pglVertexStream3sATI != null, "pglVertexStream3sATI not implemented");
			Delegates.pglVertexStream3sATI(stream, x, y, z);
			LogFunction("glVertexStream3sATI({0}, {1}, {2}, {3})", LogEnumName(stream), x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream3svATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream3ATI(Int32 stream, Int16[] coords)
		{
			unsafe {
				fixed (Int16* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertexStream3svATI != null, "pglVertexStream3svATI not implemented");
					Delegates.pglVertexStream3svATI(stream, p_coords);
					LogFunction("glVertexStream3svATI({0}, {1})", LogEnumName(stream), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream3iATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream3ATI(Int32 stream, Int32 x, Int32 y, Int32 z)
		{
			Debug.Assert(Delegates.pglVertexStream3iATI != null, "pglVertexStream3iATI not implemented");
			Delegates.pglVertexStream3iATI(stream, x, y, z);
			LogFunction("glVertexStream3iATI({0}, {1}, {2}, {3})", LogEnumName(stream), x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream3ivATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream3ATI(Int32 stream, Int32[] coords)
		{
			unsafe {
				fixed (Int32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertexStream3ivATI != null, "pglVertexStream3ivATI not implemented");
					Delegates.pglVertexStream3ivATI(stream, p_coords);
					LogFunction("glVertexStream3ivATI({0}, {1})", LogEnumName(stream), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream3fATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream3ATI(Int32 stream, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglVertexStream3fATI != null, "pglVertexStream3fATI not implemented");
			Delegates.pglVertexStream3fATI(stream, x, y, z);
			LogFunction("glVertexStream3fATI({0}, {1}, {2}, {3})", LogEnumName(stream), x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream3fvATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream3ATI(Int32 stream, float[] coords)
		{
			unsafe {
				fixed (float* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertexStream3fvATI != null, "pglVertexStream3fvATI not implemented");
					Delegates.pglVertexStream3fvATI(stream, p_coords);
					LogFunction("glVertexStream3fvATI({0}, {1})", LogEnumName(stream), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream3dATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream3ATI(Int32 stream, double x, double y, double z)
		{
			Debug.Assert(Delegates.pglVertexStream3dATI != null, "pglVertexStream3dATI not implemented");
			Delegates.pglVertexStream3dATI(stream, x, y, z);
			LogFunction("glVertexStream3dATI({0}, {1}, {2}, {3})", LogEnumName(stream), x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream3dvATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream3ATI(Int32 stream, double[] coords)
		{
			unsafe {
				fixed (double* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertexStream3dvATI != null, "pglVertexStream3dvATI not implemented");
					Delegates.pglVertexStream3dvATI(stream, p_coords);
					LogFunction("glVertexStream3dvATI({0}, {1})", LogEnumName(stream), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream4sATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream4ATI(Int32 stream, Int16 x, Int16 y, Int16 z, Int16 w)
		{
			Debug.Assert(Delegates.pglVertexStream4sATI != null, "pglVertexStream4sATI not implemented");
			Delegates.pglVertexStream4sATI(stream, x, y, z, w);
			LogFunction("glVertexStream4sATI({0}, {1}, {2}, {3}, {4})", LogEnumName(stream), x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream4svATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream4ATI(Int32 stream, Int16[] coords)
		{
			unsafe {
				fixed (Int16* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertexStream4svATI != null, "pglVertexStream4svATI not implemented");
					Delegates.pglVertexStream4svATI(stream, p_coords);
					LogFunction("glVertexStream4svATI({0}, {1})", LogEnumName(stream), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream4iATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream4ATI(Int32 stream, Int32 x, Int32 y, Int32 z, Int32 w)
		{
			Debug.Assert(Delegates.pglVertexStream4iATI != null, "pglVertexStream4iATI not implemented");
			Delegates.pglVertexStream4iATI(stream, x, y, z, w);
			LogFunction("glVertexStream4iATI({0}, {1}, {2}, {3}, {4})", LogEnumName(stream), x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream4ivATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream4ATI(Int32 stream, Int32[] coords)
		{
			unsafe {
				fixed (Int32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertexStream4ivATI != null, "pglVertexStream4ivATI not implemented");
					Delegates.pglVertexStream4ivATI(stream, p_coords);
					LogFunction("glVertexStream4ivATI({0}, {1})", LogEnumName(stream), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream4fATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream4ATI(Int32 stream, float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglVertexStream4fATI != null, "pglVertexStream4fATI not implemented");
			Delegates.pglVertexStream4fATI(stream, x, y, z, w);
			LogFunction("glVertexStream4fATI({0}, {1}, {2}, {3}, {4})", LogEnumName(stream), x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream4fvATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream4ATI(Int32 stream, float[] coords)
		{
			unsafe {
				fixed (float* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertexStream4fvATI != null, "pglVertexStream4fvATI not implemented");
					Delegates.pglVertexStream4fvATI(stream, p_coords);
					LogFunction("glVertexStream4fvATI({0}, {1})", LogEnumName(stream), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream4dATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream4ATI(Int32 stream, double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglVertexStream4dATI != null, "pglVertexStream4dATI not implemented");
			Delegates.pglVertexStream4dATI(stream, x, y, z, w);
			LogFunction("glVertexStream4dATI({0}, {1}, {2}, {3}, {4})", LogEnumName(stream), x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexStream4dvATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexStream4ATI(Int32 stream, double[] coords)
		{
			unsafe {
				fixed (double* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertexStream4dvATI != null, "pglVertexStream4dvATI not implemented");
					Delegates.pglVertexStream4dvATI(stream, p_coords);
					LogFunction("glVertexStream4dvATI({0}, {1})", LogEnumName(stream), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNormalStream3bATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="nx">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:sbyte"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void NormalStream3ATI(Int32 stream, sbyte nx, sbyte ny, sbyte nz)
		{
			Debug.Assert(Delegates.pglNormalStream3bATI != null, "pglNormalStream3bATI not implemented");
			Delegates.pglNormalStream3bATI(stream, nx, ny, nz);
			LogFunction("glNormalStream3bATI({0}, {1}, {2}, {3})", LogEnumName(stream), nx, ny, nz);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNormalStream3bvATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void NormalStream3ATI(Int32 stream, sbyte[] coords)
		{
			unsafe {
				fixed (sbyte* p_coords = coords)
				{
					Debug.Assert(Delegates.pglNormalStream3bvATI != null, "pglNormalStream3bvATI not implemented");
					Delegates.pglNormalStream3bvATI(stream, p_coords);
					LogFunction("glNormalStream3bvATI({0}, {1})", LogEnumName(stream), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNormalStream3sATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="nx">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void NormalStream3ATI(Int32 stream, Int16 nx, Int16 ny, Int16 nz)
		{
			Debug.Assert(Delegates.pglNormalStream3sATI != null, "pglNormalStream3sATI not implemented");
			Delegates.pglNormalStream3sATI(stream, nx, ny, nz);
			LogFunction("glNormalStream3sATI({0}, {1}, {2}, {3})", LogEnumName(stream), nx, ny, nz);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNormalStream3svATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void NormalStream3ATI(Int32 stream, Int16[] coords)
		{
			unsafe {
				fixed (Int16* p_coords = coords)
				{
					Debug.Assert(Delegates.pglNormalStream3svATI != null, "pglNormalStream3svATI not implemented");
					Delegates.pglNormalStream3svATI(stream, p_coords);
					LogFunction("glNormalStream3svATI({0}, {1})", LogEnumName(stream), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNormalStream3iATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="nx">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void NormalStream3ATI(Int32 stream, Int32 nx, Int32 ny, Int32 nz)
		{
			Debug.Assert(Delegates.pglNormalStream3iATI != null, "pglNormalStream3iATI not implemented");
			Delegates.pglNormalStream3iATI(stream, nx, ny, nz);
			LogFunction("glNormalStream3iATI({0}, {1}, {2}, {3})", LogEnumName(stream), nx, ny, nz);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNormalStream3ivATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void NormalStream3ATI(Int32 stream, Int32[] coords)
		{
			unsafe {
				fixed (Int32* p_coords = coords)
				{
					Debug.Assert(Delegates.pglNormalStream3ivATI != null, "pglNormalStream3ivATI not implemented");
					Delegates.pglNormalStream3ivATI(stream, p_coords);
					LogFunction("glNormalStream3ivATI({0}, {1})", LogEnumName(stream), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNormalStream3fATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="nx">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void NormalStream3ATI(Int32 stream, float nx, float ny, float nz)
		{
			Debug.Assert(Delegates.pglNormalStream3fATI != null, "pglNormalStream3fATI not implemented");
			Delegates.pglNormalStream3fATI(stream, nx, ny, nz);
			LogFunction("glNormalStream3fATI({0}, {1}, {2}, {3})", LogEnumName(stream), nx, ny, nz);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNormalStream3fvATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void NormalStream3ATI(Int32 stream, float[] coords)
		{
			unsafe {
				fixed (float* p_coords = coords)
				{
					Debug.Assert(Delegates.pglNormalStream3fvATI != null, "pglNormalStream3fvATI not implemented");
					Delegates.pglNormalStream3fvATI(stream, p_coords);
					LogFunction("glNormalStream3fvATI({0}, {1})", LogEnumName(stream), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNormalStream3dATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="nx">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void NormalStream3ATI(Int32 stream, double nx, double ny, double nz)
		{
			Debug.Assert(Delegates.pglNormalStream3dATI != null, "pglNormalStream3dATI not implemented");
			Delegates.pglNormalStream3dATI(stream, nx, ny, nz);
			LogFunction("glNormalStream3dATI({0}, {1}, {2}, {3})", LogEnumName(stream), nx, ny, nz);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNormalStream3dvATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void NormalStream3ATI(Int32 stream, double[] coords)
		{
			unsafe {
				fixed (double* p_coords = coords)
				{
					Debug.Assert(Delegates.pglNormalStream3dvATI != null, "pglNormalStream3dvATI not implemented");
					Delegates.pglNormalStream3dvATI(stream, p_coords);
					LogFunction("glNormalStream3dvATI({0}, {1})", LogEnumName(stream), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glClientActiveVertexStreamATI.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void ClientActiveVertexStreamATI(Int32 stream)
		{
			Debug.Assert(Delegates.pglClientActiveVertexStreamATI != null, "pglClientActiveVertexStreamATI not implemented");
			Delegates.pglClientActiveVertexStreamATI(stream);
			LogFunction("glClientActiveVertexStreamATI({0})", LogEnumName(stream));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexBlendEnviATI.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexBlendEnvATI(Int32 pname, Int32 param)
		{
			Debug.Assert(Delegates.pglVertexBlendEnviATI != null, "pglVertexBlendEnviATI not implemented");
			Delegates.pglVertexBlendEnviATI(pname, param);
			LogFunction("glVertexBlendEnviATI({0}, {1})", LogEnumName(pname), param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexBlendEnvfATI.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_streams")]
		public static void VertexBlendEnvATI(Int32 pname, float param)
		{
			Debug.Assert(Delegates.pglVertexBlendEnvfATI != null, "pglVertexBlendEnvfATI not implemented");
			Delegates.pglVertexBlendEnvfATI(pname, param);
			LogFunction("glVertexBlendEnvfATI({0}, {1})", LogEnumName(pname), param);
			DebugCheckErrors(null);
		}

	}

}
