
// Copyright (C) 2015-2017 Luca Piccioni
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
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
			LogCommand("glVertexStream1sATI", null, stream, x			);
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
					LogCommand("glVertexStream1svATI", null, stream, coords					);
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
			LogCommand("glVertexStream1iATI", null, stream, x			);
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
					LogCommand("glVertexStream1ivATI", null, stream, coords					);
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
			LogCommand("glVertexStream1fATI", null, stream, x			);
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
					LogCommand("glVertexStream1fvATI", null, stream, coords					);
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
			LogCommand("glVertexStream1dATI", null, stream, x			);
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
					LogCommand("glVertexStream1dvATI", null, stream, coords					);
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
			LogCommand("glVertexStream2sATI", null, stream, x, y			);
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
					LogCommand("glVertexStream2svATI", null, stream, coords					);
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
			LogCommand("glVertexStream2iATI", null, stream, x, y			);
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
					LogCommand("glVertexStream2ivATI", null, stream, coords					);
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
			LogCommand("glVertexStream2fATI", null, stream, x, y			);
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
					LogCommand("glVertexStream2fvATI", null, stream, coords					);
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
			LogCommand("glVertexStream2dATI", null, stream, x, y			);
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
					LogCommand("glVertexStream2dvATI", null, stream, coords					);
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
			LogCommand("glVertexStream3sATI", null, stream, x, y, z			);
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
					LogCommand("glVertexStream3svATI", null, stream, coords					);
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
			LogCommand("glVertexStream3iATI", null, stream, x, y, z			);
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
					LogCommand("glVertexStream3ivATI", null, stream, coords					);
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
			LogCommand("glVertexStream3fATI", null, stream, x, y, z			);
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
					LogCommand("glVertexStream3fvATI", null, stream, coords					);
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
			LogCommand("glVertexStream3dATI", null, stream, x, y, z			);
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
					LogCommand("glVertexStream3dvATI", null, stream, coords					);
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
			LogCommand("glVertexStream4sATI", null, stream, x, y, z, w			);
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
					LogCommand("glVertexStream4svATI", null, stream, coords					);
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
			LogCommand("glVertexStream4iATI", null, stream, x, y, z, w			);
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
					LogCommand("glVertexStream4ivATI", null, stream, coords					);
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
			LogCommand("glVertexStream4fATI", null, stream, x, y, z, w			);
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
					LogCommand("glVertexStream4fvATI", null, stream, coords					);
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
			LogCommand("glVertexStream4dATI", null, stream, x, y, z, w			);
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
					LogCommand("glVertexStream4dvATI", null, stream, coords					);
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
			LogCommand("glNormalStream3bATI", null, stream, nx, ny, nz			);
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
					LogCommand("glNormalStream3bvATI", null, stream, coords					);
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
			LogCommand("glNormalStream3sATI", null, stream, nx, ny, nz			);
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
					LogCommand("glNormalStream3svATI", null, stream, coords					);
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
			LogCommand("glNormalStream3iATI", null, stream, nx, ny, nz			);
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
					LogCommand("glNormalStream3ivATI", null, stream, coords					);
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
			LogCommand("glNormalStream3fATI", null, stream, nx, ny, nz			);
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
					LogCommand("glNormalStream3fvATI", null, stream, coords					);
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
			LogCommand("glNormalStream3dATI", null, stream, nx, ny, nz			);
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
					LogCommand("glNormalStream3dvATI", null, stream, coords					);
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
			LogCommand("glClientActiveVertexStreamATI", null, stream			);
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
			LogCommand("glVertexBlendEnviATI", null, pname, param			);
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
			LogCommand("glVertexBlendEnvfATI", null, pname, param			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream1sATI", ExactSpelling = true)]
			internal extern static void glVertexStream1sATI(Int32 stream, Int16 x);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream1svATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream1svATI(Int32 stream, Int16* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream1iATI", ExactSpelling = true)]
			internal extern static void glVertexStream1iATI(Int32 stream, Int32 x);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream1ivATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream1ivATI(Int32 stream, Int32* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream1fATI", ExactSpelling = true)]
			internal extern static void glVertexStream1fATI(Int32 stream, float x);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream1fvATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream1fvATI(Int32 stream, float* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream1dATI", ExactSpelling = true)]
			internal extern static void glVertexStream1dATI(Int32 stream, double x);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream1dvATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream1dvATI(Int32 stream, double* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream2sATI", ExactSpelling = true)]
			internal extern static void glVertexStream2sATI(Int32 stream, Int16 x, Int16 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream2svATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream2svATI(Int32 stream, Int16* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream2iATI", ExactSpelling = true)]
			internal extern static void glVertexStream2iATI(Int32 stream, Int32 x, Int32 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream2ivATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream2ivATI(Int32 stream, Int32* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream2fATI", ExactSpelling = true)]
			internal extern static void glVertexStream2fATI(Int32 stream, float x, float y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream2fvATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream2fvATI(Int32 stream, float* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream2dATI", ExactSpelling = true)]
			internal extern static void glVertexStream2dATI(Int32 stream, double x, double y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream2dvATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream2dvATI(Int32 stream, double* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream3sATI", ExactSpelling = true)]
			internal extern static void glVertexStream3sATI(Int32 stream, Int16 x, Int16 y, Int16 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream3svATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream3svATI(Int32 stream, Int16* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream3iATI", ExactSpelling = true)]
			internal extern static void glVertexStream3iATI(Int32 stream, Int32 x, Int32 y, Int32 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream3ivATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream3ivATI(Int32 stream, Int32* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream3fATI", ExactSpelling = true)]
			internal extern static void glVertexStream3fATI(Int32 stream, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream3fvATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream3fvATI(Int32 stream, float* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream3dATI", ExactSpelling = true)]
			internal extern static void glVertexStream3dATI(Int32 stream, double x, double y, double z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream3dvATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream3dvATI(Int32 stream, double* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream4sATI", ExactSpelling = true)]
			internal extern static void glVertexStream4sATI(Int32 stream, Int16 x, Int16 y, Int16 z, Int16 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream4svATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream4svATI(Int32 stream, Int16* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream4iATI", ExactSpelling = true)]
			internal extern static void glVertexStream4iATI(Int32 stream, Int32 x, Int32 y, Int32 z, Int32 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream4ivATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream4ivATI(Int32 stream, Int32* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream4fATI", ExactSpelling = true)]
			internal extern static void glVertexStream4fATI(Int32 stream, float x, float y, float z, float w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream4fvATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream4fvATI(Int32 stream, float* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream4dATI", ExactSpelling = true)]
			internal extern static void glVertexStream4dATI(Int32 stream, double x, double y, double z, double w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexStream4dvATI", ExactSpelling = true)]
			internal extern static unsafe void glVertexStream4dvATI(Int32 stream, double* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormalStream3bATI", ExactSpelling = true)]
			internal extern static void glNormalStream3bATI(Int32 stream, sbyte nx, sbyte ny, sbyte nz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormalStream3bvATI", ExactSpelling = true)]
			internal extern static unsafe void glNormalStream3bvATI(Int32 stream, sbyte* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormalStream3sATI", ExactSpelling = true)]
			internal extern static void glNormalStream3sATI(Int32 stream, Int16 nx, Int16 ny, Int16 nz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormalStream3svATI", ExactSpelling = true)]
			internal extern static unsafe void glNormalStream3svATI(Int32 stream, Int16* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormalStream3iATI", ExactSpelling = true)]
			internal extern static void glNormalStream3iATI(Int32 stream, Int32 nx, Int32 ny, Int32 nz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormalStream3ivATI", ExactSpelling = true)]
			internal extern static unsafe void glNormalStream3ivATI(Int32 stream, Int32* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormalStream3fATI", ExactSpelling = true)]
			internal extern static void glNormalStream3fATI(Int32 stream, float nx, float ny, float nz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormalStream3fvATI", ExactSpelling = true)]
			internal extern static unsafe void glNormalStream3fvATI(Int32 stream, float* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormalStream3dATI", ExactSpelling = true)]
			internal extern static void glNormalStream3dATI(Int32 stream, double nx, double ny, double nz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormalStream3dvATI", ExactSpelling = true)]
			internal extern static unsafe void glNormalStream3dvATI(Int32 stream, double* coords);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClientActiveVertexStreamATI", ExactSpelling = true)]
			internal extern static void glClientActiveVertexStreamATI(Int32 stream);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexBlendEnviATI", ExactSpelling = true)]
			internal extern static void glVertexBlendEnviATI(Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexBlendEnvfATI", ExactSpelling = true)]
			internal extern static void glVertexBlendEnvfATI(Int32 pname, float param);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream1sATI(Int32 stream, Int16 x);

			[ThreadStatic]
			internal static glVertexStream1sATI pglVertexStream1sATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream1svATI(Int32 stream, Int16* coords);

			[ThreadStatic]
			internal static glVertexStream1svATI pglVertexStream1svATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream1iATI(Int32 stream, Int32 x);

			[ThreadStatic]
			internal static glVertexStream1iATI pglVertexStream1iATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream1ivATI(Int32 stream, Int32* coords);

			[ThreadStatic]
			internal static glVertexStream1ivATI pglVertexStream1ivATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream1fATI(Int32 stream, float x);

			[ThreadStatic]
			internal static glVertexStream1fATI pglVertexStream1fATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream1fvATI(Int32 stream, float* coords);

			[ThreadStatic]
			internal static glVertexStream1fvATI pglVertexStream1fvATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream1dATI(Int32 stream, double x);

			[ThreadStatic]
			internal static glVertexStream1dATI pglVertexStream1dATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream1dvATI(Int32 stream, double* coords);

			[ThreadStatic]
			internal static glVertexStream1dvATI pglVertexStream1dvATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream2sATI(Int32 stream, Int16 x, Int16 y);

			[ThreadStatic]
			internal static glVertexStream2sATI pglVertexStream2sATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream2svATI(Int32 stream, Int16* coords);

			[ThreadStatic]
			internal static glVertexStream2svATI pglVertexStream2svATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream2iATI(Int32 stream, Int32 x, Int32 y);

			[ThreadStatic]
			internal static glVertexStream2iATI pglVertexStream2iATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream2ivATI(Int32 stream, Int32* coords);

			[ThreadStatic]
			internal static glVertexStream2ivATI pglVertexStream2ivATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream2fATI(Int32 stream, float x, float y);

			[ThreadStatic]
			internal static glVertexStream2fATI pglVertexStream2fATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream2fvATI(Int32 stream, float* coords);

			[ThreadStatic]
			internal static glVertexStream2fvATI pglVertexStream2fvATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream2dATI(Int32 stream, double x, double y);

			[ThreadStatic]
			internal static glVertexStream2dATI pglVertexStream2dATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream2dvATI(Int32 stream, double* coords);

			[ThreadStatic]
			internal static glVertexStream2dvATI pglVertexStream2dvATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream3sATI(Int32 stream, Int16 x, Int16 y, Int16 z);

			[ThreadStatic]
			internal static glVertexStream3sATI pglVertexStream3sATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream3svATI(Int32 stream, Int16* coords);

			[ThreadStatic]
			internal static glVertexStream3svATI pglVertexStream3svATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream3iATI(Int32 stream, Int32 x, Int32 y, Int32 z);

			[ThreadStatic]
			internal static glVertexStream3iATI pglVertexStream3iATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream3ivATI(Int32 stream, Int32* coords);

			[ThreadStatic]
			internal static glVertexStream3ivATI pglVertexStream3ivATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream3fATI(Int32 stream, float x, float y, float z);

			[ThreadStatic]
			internal static glVertexStream3fATI pglVertexStream3fATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream3fvATI(Int32 stream, float* coords);

			[ThreadStatic]
			internal static glVertexStream3fvATI pglVertexStream3fvATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream3dATI(Int32 stream, double x, double y, double z);

			[ThreadStatic]
			internal static glVertexStream3dATI pglVertexStream3dATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream3dvATI(Int32 stream, double* coords);

			[ThreadStatic]
			internal static glVertexStream3dvATI pglVertexStream3dvATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream4sATI(Int32 stream, Int16 x, Int16 y, Int16 z, Int16 w);

			[ThreadStatic]
			internal static glVertexStream4sATI pglVertexStream4sATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream4svATI(Int32 stream, Int16* coords);

			[ThreadStatic]
			internal static glVertexStream4svATI pglVertexStream4svATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream4iATI(Int32 stream, Int32 x, Int32 y, Int32 z, Int32 w);

			[ThreadStatic]
			internal static glVertexStream4iATI pglVertexStream4iATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream4ivATI(Int32 stream, Int32* coords);

			[ThreadStatic]
			internal static glVertexStream4ivATI pglVertexStream4ivATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream4fATI(Int32 stream, float x, float y, float z, float w);

			[ThreadStatic]
			internal static glVertexStream4fATI pglVertexStream4fATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream4fvATI(Int32 stream, float* coords);

			[ThreadStatic]
			internal static glVertexStream4fvATI pglVertexStream4fvATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexStream4dATI(Int32 stream, double x, double y, double z, double w);

			[ThreadStatic]
			internal static glVertexStream4dATI pglVertexStream4dATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexStream4dvATI(Int32 stream, double* coords);

			[ThreadStatic]
			internal static glVertexStream4dvATI pglVertexStream4dvATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormalStream3bATI(Int32 stream, sbyte nx, sbyte ny, sbyte nz);

			[ThreadStatic]
			internal static glNormalStream3bATI pglNormalStream3bATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormalStream3bvATI(Int32 stream, sbyte* coords);

			[ThreadStatic]
			internal static glNormalStream3bvATI pglNormalStream3bvATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormalStream3sATI(Int32 stream, Int16 nx, Int16 ny, Int16 nz);

			[ThreadStatic]
			internal static glNormalStream3sATI pglNormalStream3sATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormalStream3svATI(Int32 stream, Int16* coords);

			[ThreadStatic]
			internal static glNormalStream3svATI pglNormalStream3svATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormalStream3iATI(Int32 stream, Int32 nx, Int32 ny, Int32 nz);

			[ThreadStatic]
			internal static glNormalStream3iATI pglNormalStream3iATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormalStream3ivATI(Int32 stream, Int32* coords);

			[ThreadStatic]
			internal static glNormalStream3ivATI pglNormalStream3ivATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormalStream3fATI(Int32 stream, float nx, float ny, float nz);

			[ThreadStatic]
			internal static glNormalStream3fATI pglNormalStream3fATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormalStream3fvATI(Int32 stream, float* coords);

			[ThreadStatic]
			internal static glNormalStream3fvATI pglNormalStream3fvATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormalStream3dATI(Int32 stream, double nx, double ny, double nz);

			[ThreadStatic]
			internal static glNormalStream3dATI pglNormalStream3dATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormalStream3dvATI(Int32 stream, double* coords);

			[ThreadStatic]
			internal static glNormalStream3dvATI pglNormalStream3dvATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClientActiveVertexStreamATI(Int32 stream);

			[ThreadStatic]
			internal static glClientActiveVertexStreamATI pglClientActiveVertexStreamATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexBlendEnviATI(Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glVertexBlendEnviATI pglVertexBlendEnviATI;

			[RequiredByFeature("GL_ATI_vertex_streams")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexBlendEnvfATI(Int32 pname, float param);

			[ThreadStatic]
			internal static glVertexBlendEnvfATI pglVertexBlendEnvfATI;

		}
	}

}
