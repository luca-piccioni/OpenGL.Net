
// Copyright (C) 2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace OpenGL.Objects
{
	/// <summary>
	/// Class for tessellating polygons using GLU.
	/// </summary>
	public class Tessellator : IDisposable
	{
		#region Constructors

		/// <summary>
		/// Construct a Tessellator.
		/// </summary>
		public Tessellator()
		{
			if (Glu.IsAvailable == false)
				throw new NotSupportedException("GLU is required");

			_Tess = Glu.NewTess();

			// Register callbacks
			TessCallback(Glu.TessCallbackType.TessBegin, new Glu.CallbackBeginDelegate(BeginCallback));
			TessCallback(Glu.TessCallbackType.TessEnd, new Glu.CallbackEndDelegate(EndCallback));
			TessCallback(Glu.TessCallbackType.TessVertex, new Glu.CallbackTessVertexDelegate(VertexCallback));
			TessCallback(Glu.TessCallbackType.TessEdgeFlag, new Glu.CallbackTessVertexDelegate(EdgeFlagCallback));
		}

		#endregion

		#region Resources

		private void BeginCallback(PrimitiveType type)
		{
			Begin?.Invoke(this, new TessellatorBeginEventArgs(type));
		}

		private void EndCallback()
		{
			End?.Invoke(this, EventArgs.Empty);
		}

		private void VertexCallback(IntPtr vertex_data)
		{
			Vertex?.Invoke(this, new TessellatorVertexEventArgs(vertex_data));
		}

		private void EdgeFlagCallback(IntPtr vertex_data)
		{
			// Force triangle generation
		}

		private void TessCallback(Glu.TessCallbackType callbackType, Delegate callback)
		{
			// Avoid GC management
			_DelegatePins.Add(GCHandle.Alloc(callback));

			Glu.TessCallback(_Tess, callbackType, Marshal.GetFunctionPointerForDelegate(callback));
		}

		/// <summary>
		/// Tessellator handle.
		/// </summary>
		private IntPtr _Tess;

		/// <summary>
		/// Delegates pinned.
		/// </summary>
		private readonly List<GCHandle> _DelegatePins = new List<GCHandle>();

		#endregion

		#region Interface

		/// <summary>
		/// Begin a polygon.
		/// </summary>
		public void BeginPolygon()
		{
			Glu.TessBeginPolygon(_Tess, IntPtr.Zero);
		}

		/// <summary>
		/// End a polygon started with <see cref="Begin"/>.
		/// </summary>
		public void EndPolygon()
		{
			Glu.TessEndPolygon(_Tess);

			// Release countours
			foreach (MemoryLock memoryLock in _CountourLocks)
				memoryLock.Dispose();
			_CountourLocks.Clear();
		}

		/// <summary>
		/// Add a contour to the current polygon.
		/// </summary>
		/// <param name="contourVertices">
		/// 
		/// </param>
		public void AddContour(Vertex2f[] contourVertices, Vertex3f normal)
		{
			Vertex3d[] fixedVertices = new Vertex3d[contourVertices.Length];

			for (int i = 0; i < contourVertices.Length; i++)
				fixedVertices[i] = contourVertices[i];

			AddContour(fixedVertices, normal);
		}

		/// <summary>
		/// Add a contour to the current polygon.
		/// </summary>
		/// <param name="contourVertices">
		/// 
		/// </param>
		public void AddContour(Vertex3f[] contourVertices, Vertex3f normal)
		{
			Vertex3d[] fixedVertices = new Vertex3d[contourVertices.Length];

			for (int i = 0; i < contourVertices.Length; i++)
				fixedVertices[i] = contourVertices[i];

			AddContour(fixedVertices, normal);
		}

		/// <summary>
		/// Add a contour to the current polygon.
		/// </summary>
		/// <param name="contourVertices">
		/// 
		/// </param>
		public void AddContour(Vertex3d[] contourVertices, Vertex3d normal)
		{
			if (contourVertices == null)
				throw new ArgumentNullException("contourVertices");

			MemoryLock countourLock = new MemoryLock(contourVertices);

			// Dispose later
			_CountourLocks.Add(countourLock);

			// Set to Vertex3d.Zero to compute automatically
			Glu.TessNormal(_Tess, normal.x, normal.x, normal.z);

			IntPtr vLockAddr = countourLock.Address;

			Glu.TessBeginContour(_Tess);
			foreach (Vertex3d v in contourVertices) {
				Glu.TessVertex(_Tess, vLockAddr, vLockAddr);
				vLockAddr = new IntPtr(vLockAddr.ToInt64() + 24);
			}
			Glu.TessEndContour(_Tess);
		}

		/// <summary>
		/// Collection of <see cref="MemoryLock"/> instances used for fixing countour
		/// vertices to be tessellated. Release when tessellation process has ended.
		/// </summary>
		private readonly List<MemoryLock> _CountourLocks = new List<MemoryLock>();

		#endregion

		#region Events

		/// <summary>
		/// Event raised when the tessellator begin to generate a primitive.
		/// </summary>
		public event EventHandler<TessellatorBeginEventArgs> Begin;

		/// <summary>
		/// Event raised when the tessellator ends a primitive.
		/// </summary>
		public event EventHandler<EventArgs> End;

		/// <summary>
		/// Event raised when the tessellator ends a primitive.
		/// </summary>
		public event EventHandler<TessellatorVertexEventArgs> Vertex;

		#endregion

		#region IDisposable Implementation

		public void Dispose()
		{
			if (_Tess != IntPtr.Zero) {
				Glu.DeleteTess(_Tess);
				_Tess = IntPtr.Zero;
			}

			foreach (GCHandle delegatePin in _DelegatePins)
				delegatePin.Free();
			_DelegatePins.Clear();
		}

		#endregion
	}

	public sealed class TessellatorBeginEventArgs : EventArgs
	{
		public TessellatorBeginEventArgs(PrimitiveType type)
		{
			Type = type;
		}

		public readonly PrimitiveType Type;
	}

	public sealed class TessellatorVertexEventArgs : EventArgs
	{
		public TessellatorVertexEventArgs(IntPtr vertex_data)
		{
#if HAVE_UNSAFE
			unsafe
			{
				Vertex = Unsafe.Read<Vertex3d>(vertex_data.ToPointer());
			}
#else
			throw new NotImplementedException();
#endif
		}

		public readonly Vertex3d Vertex;
	}
}
