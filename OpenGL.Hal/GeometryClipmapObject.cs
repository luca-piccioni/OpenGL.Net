
// Copyright (C) 2016 Luca Piccioni
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
using System.Collections.Generic;

namespace OpenGL
{
	/// <summary>
	/// Geometry clipmap implementation.
	/// </summary>
	public class GeometryClipmapObject : GraphicsResource
	{
		#region Constructors

		/// <summary>
		/// Construct a GeometryClipmapObject.
		/// </summary>
		/// <param name="rank">
		/// A <see cref="UInt16"/> that specify the number of LODs composing this GeometryClipmapObject.
		/// </param>
		/// <param name="n">
		/// A <see cref="UInt16"/> that specify the number of vertices of the geometry clipmap block side.
		/// </param>
		public GeometryClipmapObject(ushort rank, ushort levels)
		{
			if (PrimitiveRestart.IsPrimitiveRestartSupported() == false)
				throw new NotSupportedException();

			StripStride = (uint)Math.Pow(2.0, rank) - 1;
			BlockVertices = (StripStride + 1) / 4;
			ClipmapLevels = levels;

			// Define clipmap resources
			_ClipmapLevels = new ClipmapLevel[levels];
			// Define geometry clipmap program
			_GeometryClipmapProgram = ShadersLibrary.Instance.CreateProgram("GeometryClipmap");
			_GeometryClipmapProgram.IncRef();
			// Define geometry clipmap vertex arrays
			CreateVertexArrays();
		}

		#endregion

		#region Definition

		/// <summary>
		/// The number of vertices composing a line of the clipmap level.
		/// </summary>
		public readonly uint StripStride;

		/// <summary>
		/// The number of vertices compsing a line of the clipmap block.
		/// </summary>
		public readonly uint BlockVertices;

		/// <summary>
		/// Number of levels composing this geometry clipmap.
		/// </summary>
		public readonly ushort ClipmapLevels;

		#endregion

		#region Geometry Clipmap Levels

		/// <summary>
		/// Geometry clipmap level abstarction.
		/// </summary>
		private class ClipmapLevel : IDisposable
		{
			#region Constructors

			/// <summary>
			/// Construct a ClipmapLevel.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="TextureArray2d"/> holding the elevation data for every clipmap.
			/// </param>
			/// <param name="lod">
			/// A <see cref="UInt32"/> that specify texture array LOD.
			/// </param>
			public ClipmapLevel(TextureArray2d texture, uint lod)
			{
				if (texture == null)
					throw new ArgumentNullException("texture");
				if (texture.Height < lod)
					throw new ArgumentOutOfRangeException("lod", "exceed clipmap levels");

				Texture = texture;
				Texture.IncRef();
				Lod = lod;
			}

			#endregion

			#region Level Information

			/// <summary>
			/// The underlying texture array storing clipmap elevation data.
			/// </summary>
			public readonly TextureArray2d Texture;

			/// <summary>
			/// The Level Of Detail of the texture (i.e. the texture array level).
			/// </summary>
			public readonly uint Lod;

			#endregion

			#region IDisposable Implementation

			/// <summary>
			/// Dispose resources.
			/// </summary>
			public void Dispose()
			{
				Texture.DecRef();
            }

			#endregion
		}

		/// <summary>
		/// Clipmap levels abstraction.
		/// </summary>
		private readonly ClipmapLevel[] _ClipmapLevels;

		#endregion

		#region Geometry Clipmap Blocks

		/// <summary>
		/// Geometry clipmap instanced attribute.
		/// </summary>
		/// <remarks>
		/// Each Clipmap block defines instanced attributes for the geometry clipmap block.
		/// </remarks>
		private struct ClipmapBlockInstance
		{
			#region Constructors

			/// <summary>
			/// Construct a ClipmapBlock.
			/// </summary>
			public ClipmapBlockInstance(uint n, uint m, int x, int y, uint lod) :
				this(n, m, x, y, lod, new ColorRGBAF(1.0f, 1.0f, 1.0f, 1.0f))
			{

			}

			/// <summary>
			/// Construct a ClipmapBlock.
			/// </summary>
			public ClipmapBlockInstance(uint n, uint m, int x, int y, uint lod, ColorRGBAF color)
			{
				float scale = (float)Math.Pow(2.0, lod);
				float positionOffset = -1.0f;

				//float xPosition = x * scale + positionOffset;
				//float yPosition = y * scale + positionOffset;
				float xPosition = (x + positionOffset) * scale;
				float yPosition = (y + positionOffset) * scale;

				// Position offset and scale
				Offset = new Vertex4f(xPosition, yPosition, (m - 1) * scale, (m - 1) * scale);
				// Texture coordinate offset and scale
				float texOffset = 0.5f;
				float texScale = (n + 1) / 3601.0f;

				MapOffset = new Vertex4f(texOffset, texOffset, texScale, texScale);
				// LOD
				Lod = lod;
				// Instance color
				BlockColor = color;
			}

			#endregion

			#region Structure

			/// <summary>
			/// Position offset (XY) and scale (ZW).
			/// </summary>
			public Vertex4f Offset;

			/// <summary>
			/// Texture coordinate offset (XY) and scale (ZW).
			/// </summary>
			public Vertex4f MapOffset;

			/// <summary>
			/// The texture level of detail.
			/// </summary>
			public float Lod;

			/// <summary>
			/// Debugging color for instancing.
			/// </summary>
			public ColorRGBAF BlockColor;

			#endregion
		}

		/// <summary>
		/// Blocks array.
		/// </summary>
		private readonly List<ClipmapBlockInstance> _ClipmapBlocks = new List<ClipmapBlockInstance>();

		/// <summary>
		/// Ring fix (horizontal).
		/// </summary>
		private readonly List<ClipmapBlockInstance> _ClipmapRingFixesH = new List<ClipmapBlockInstance>();

		/// <summary>
		/// Ring fix (vertical).
		/// </summary>
		private readonly List<ClipmapBlockInstance> _ClipmapRingFixesV = new List<ClipmapBlockInstance>();

		/// <summary>
		/// Interior (horizontal).
		/// </summary>
		private readonly List<ClipmapBlockInstance> _ClipmapInteriorH = new List<ClipmapBlockInstance>();

		/// <summary>
		/// Interior (vertical).
		/// </summary>
		private readonly List<ClipmapBlockInstance> _ClipmapInteriorV = new List<ClipmapBlockInstance>();

		#endregion

		#region Drawing

		/// <summary>
		/// Draw the attributes of this vertex array.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for rendering.
		/// </param>
		public void Draw(GraphicsContext ctx, IMatrix4x4 modelviewproj)
		{
			_GeometryClipmapProgram.Bind(ctx);
			_GeometryClipmapProgram.ResetTextureUnits();
			_GeometryClipmapProgram.SetUniform(ctx, "hal_ModelViewProjection", modelviewproj);
			_GeometryClipmapProgram.SetUniform(ctx, "hal_ElevationMap", _ElevationTexture);

			// Draw clipmap blocks using instanced rendering
			_BlockArray.DrawInstanced(ctx, _GeometryClipmapProgram, (uint)_ClipmapBlocks.Count);
			_RingFixArrayH.DrawInstanced(ctx, _GeometryClipmapProgram, (uint)_ClipmapRingFixesH.Count);
			_RingFixArrayV.DrawInstanced(ctx, _GeometryClipmapProgram, (uint)_ClipmapRingFixesV.Count);
			_InteriorArrayH.DrawInstanced(ctx, _GeometryClipmapProgram, (uint)_ClipmapInteriorH.Count);
			_InteriorArrayV.DrawInstanced(ctx, _GeometryClipmapProgram, (uint)_ClipmapInteriorV.Count);
		}

		/// <summary>
		/// Create vertex arrays required for drawing the geometry clipmap blocks.
		/// </summary>
		private void CreateVertexArrays()
		{
			ushort BlockSubdivs = (ushort)(BlockVertices - 1);

			int semiStripStride = ((int)StripStride - 1) / 2;
			int xBlock, yBlock;

			#region Clipmap Blocks

			#region Position

			// Note: this array is shared with ring fixes (horizontal)

			// Create position array buffer ((n+1) x (n+1) vertices equally spaced)
			ArrayBufferObject<Vertex2f> arrayBufferPosition = new ArrayBufferObject<Vertex2f>(BufferObjectHint.StaticCpuDraw);
			float positionStep = 1.0f / BlockSubdivs;
			uint positionIndex = 0;

			arrayBufferPosition.Create((uint)(BlockVertices * BlockVertices));
			arrayBufferPosition.Map();
			for (float y = 0.0f; y <= 1.0f; y += positionStep)
				for (float x = 0.0f; x <= 1.0f; x += positionStep, positionIndex++) {
					System.Diagnostics.Debug.Assert(positionIndex < BlockVertices * BlockVertices);
					arrayBufferPosition.Set(new Vertex2f(x, y), positionIndex);
				}
					
			arrayBufferPosition.Unmap();

			#endregion

			#region Elements

			// Note: this array is shared with ring fixes (horizontal)

			// Create elements indices
			ElementBufferObject<ushort> arrayBufferIndices = new ElementBufferObject<ushort>(BufferObjectHint.StaticCpuDraw);
			List<ushort> arrayBufferElements = new List<ushort>();

			arrayBufferIndices.RestartIndexEnabled = true;

			for (short i = 0; i < BlockSubdivs; i++) {
				ushort baseIndex = (ushort)(i * (BlockSubdivs + 1));

				arrayBufferElements.Add((ushort)(baseIndex));

				for (ushort x = 0; x < BlockSubdivs; x++) {
					arrayBufferElements.Add((ushort)(baseIndex + x + BlockSubdivs + 1));
					arrayBufferElements.Add((ushort)(baseIndex + x + 1));
				}
				arrayBufferElements.Add((ushort)(baseIndex + BlockSubdivs + 1 + BlockSubdivs));

				if (i < BlockSubdivs - 1)
					arrayBufferElements.Add((ushort)arrayBufferIndices.RestartIndexKey);
			}
			
			arrayBufferIndices.Create(arrayBufferElements.ToArray());

			#endregion

			#region Instances

			ArrayBufferObjectInterleaved<ClipmapBlockInstance> instancedBlockArray = new ArrayBufferObjectInterleaved<ClipmapBlockInstance>(BufferObjectHint.StaticCpuDraw);

			for (ushort level = 0; level < ClipmapLevels; level++) {
				// Line 1
				yBlock = -semiStripStride;
				// Line 1 - 2 left
				xBlock = -semiStripStride;
				for (int i = 0; i < 2; i++, xBlock += BlockSubdivs)
					_ClipmapBlocks.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level));
				// Line 1 - 2 right
				xBlock = +semiStripStride - BlockSubdivs * 2;
				for (int i = 0; i < 2; i++, xBlock += BlockSubdivs)
					_ClipmapBlocks.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level));

				// Line 2
				yBlock += (int)(BlockVertices - 1);
				// Line 2 - 1 left
				xBlock = -semiStripStride;
				_ClipmapBlocks.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level));
				// Bottom right
				xBlock = +semiStripStride - BlockSubdivs;
				_ClipmapBlocks.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level));

				// Line 3
				yBlock = +semiStripStride - BlockSubdivs * 2;
				// Line 3 - 1 left
				xBlock = -semiStripStride;
				_ClipmapBlocks.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level));
				// Line 3 - 1 right
				xBlock = +semiStripStride - BlockSubdivs;
				_ClipmapBlocks.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level));

				// Line 4
				yBlock = +semiStripStride - BlockSubdivs;
				// Line 4 - 2 left
				xBlock = -semiStripStride;
				for (int i = 0; i < 2; i++, xBlock += BlockSubdivs)
					_ClipmapBlocks.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level));
				// Line 4 - 2 right
				xBlock = +semiStripStride - BlockSubdivs * 2;
				for (int i = 0; i < 2; i++, xBlock += BlockSubdivs)
					_ClipmapBlocks.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level));
			}

			instancedBlockArray.Create(_ClipmapBlocks.ToArray());

			#endregion

			#region Vertex Array

			// Create blocks array
			_BlockArray = new VertexArrayObject();

			_BlockArray.SetArray(arrayBufferPosition, VertexArraySemantic.Position);

			_BlockArray.SetInstancedArray(instancedBlockArray, 0, 1, "hal_BlockOffset", null);
			_BlockArray.SetInstancedArray(instancedBlockArray, 1, 1, "hal_MapOffset", null);
			_BlockArray.SetInstancedArray(instancedBlockArray, 2, 1, "hal_Lod", null);
			_BlockArray.SetInstancedArray(instancedBlockArray, 3, 1, "hal_BlockColor", null);

			_BlockArray.SetElementArray(PrimitiveType.TriangleStrip, arrayBufferIndices);

			#endregion

			#endregion

			#region Clipmap Ring Fixes (Horizontal)

			#region Instances

			ColorRGBAF RingFixColor = new ColorRGBAF(1.0f, 0.0f, 1.0f);

			ArrayBufferObjectInterleaved<ClipmapBlockInstance> instancedRingArrayH = new ArrayBufferObjectInterleaved<ClipmapBlockInstance>(BufferObjectHint.StaticCpuDraw);

			for (ushort level = 0; level < ClipmapLevels; level++) {
				xBlock = -semiStripStride;
				yBlock = -1;
				_ClipmapRingFixesH.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, RingFixColor));
				xBlock = +semiStripStride - BlockSubdivs;
				yBlock = -1;
				_ClipmapRingFixesH.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, RingFixColor));
			}

			instancedRingArrayH.Create(_ClipmapRingFixesH.ToArray());

			#endregion

			#region Vertex Array

			// Create ring fixes array
			_RingFixArrayH = new VertexArrayObject();

			// Reuse position array buffer
			_RingFixArrayH.SetArray(arrayBufferPosition, VertexArraySemantic.Position);

			_RingFixArrayH.SetInstancedArray(instancedRingArrayH, 0, 1, "hal_BlockOffset", null);
			_RingFixArrayH.SetInstancedArray(instancedRingArrayH, 1, 1, "hal_MapOffset", null);
			_RingFixArrayH.SetInstancedArray(instancedRingArrayH, 2, 1, "hal_Lod", null);
			_RingFixArrayH.SetInstancedArray(instancedRingArrayH, 3, 1, "hal_BlockColor", null);

			// Reuse indices array buffer, but limiting to 2 triangle strips
			_RingFixArrayH.SetElementArray(PrimitiveType.TriangleStrip, arrayBufferIndices, 0, BlockVertices * 4 + 3);

			#endregion

			#endregion

			#region Clipmap Ring Fixes (Vertical)

			#region Elements

			// Create custom elements indices for ring fixes (vertical only)
			ElementBufferObject<ushort> arrayBufferIndicesV = new ElementBufferObject<ushort>(BufferObjectHint.StaticCpuDraw);
			List<ushort> arrayBufferElementsV = new List<ushort>();

			arrayBufferIndicesV.RestartIndexEnabled = true;

			for (ushort i = 0; i < 2; i++) {
				ushort baseIndex = i;

				arrayBufferElementsV.Add((ushort)(baseIndex));

				for (ushort y = 0; y < BlockSubdivs; y++) {
					arrayBufferElementsV.Add((ushort)(baseIndex + (y * BlockVertices) + 1));
					arrayBufferElementsV.Add((ushort)(baseIndex + ((y + 1) * BlockVertices)));
				}
				arrayBufferElementsV.Add((ushort)(baseIndex + (BlockSubdivs * BlockVertices) + 1));

				if (i < 1)
					arrayBufferElementsV.Add((ushort)arrayBufferIndices.RestartIndexKey);
			}

			arrayBufferIndicesV.Create(arrayBufferElementsV.ToArray());

			#endregion

			#region Instances

			ArrayBufferObjectInterleaved<ClipmapBlockInstance> instancedRingArrayV = new ArrayBufferObjectInterleaved<ClipmapBlockInstance>(BufferObjectHint.StaticCpuDraw);

			for (ushort level = 0; level < ClipmapLevels; level++) {
				xBlock = -1;
				yBlock = -semiStripStride;
				_ClipmapRingFixesV.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, RingFixColor));
				xBlock = -1;
				yBlock = +semiStripStride - BlockSubdivs;
				_ClipmapRingFixesV.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, RingFixColor));
			}

			instancedRingArrayV.Create(_ClipmapRingFixesV.ToArray());

			#endregion

			#region Vertex Array

			// Create ring fixes array
			_RingFixArrayV = new VertexArrayObject();

			// Reuse position array buffer
			_RingFixArrayV.SetArray(arrayBufferPosition, VertexArraySemantic.Position);

			_RingFixArrayV.SetInstancedArray(instancedRingArrayV, 0, 1, "hal_BlockOffset", null);
			_RingFixArrayV.SetInstancedArray(instancedRingArrayV, 1, 1, "hal_MapOffset", null);
			_RingFixArrayV.SetInstancedArray(instancedRingArrayV, 2, 1, "hal_Lod", null);
			_RingFixArrayV.SetInstancedArray(instancedRingArrayV, 3, 1, "hal_BlockColor", null);

			_RingFixArrayV.SetElementArray(PrimitiveType.TriangleStrip, arrayBufferIndicesV);

			#endregion

			#endregion

			#region Interiors (Horizontal)

			#region Instances

			ColorRGBAF InteriorColor = new ColorRGBAF(1.0f, 1.0f, 0.0f);

			ArrayBufferObjectInterleaved<ClipmapBlockInstance> instancedInteriorArrayH = new ArrayBufferObjectInterleaved<ClipmapBlockInstance>(BufferObjectHint.StaticCpuDraw);

			for (ushort level = 0; level < ClipmapLevels; level++) {
				yBlock = -semiStripStride - 2;
				xBlock = -semiStripStride - 2;
				for (int i = 0; i < 4; i++, xBlock += BlockSubdivs)
					_ClipmapInteriorH.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, InteriorColor));

				yBlock = -semiStripStride - 2;
				xBlock = +semiStripStride - BlockSubdivs;
				_ClipmapInteriorH.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, InteriorColor));
			}

			instancedInteriorArrayH.Create(_ClipmapInteriorH.ToArray());

			#endregion

			#region Vertex Array

			_InteriorArrayH = new VertexArrayObject();

			// Reuse position array buffer for ring fixes (horizontal)
			_InteriorArrayH.SetArray(arrayBufferPosition, VertexArraySemantic.Position);

			_InteriorArrayH.SetInstancedArray(instancedInteriorArrayH, 0, 1, "hal_BlockOffset", null);
			_InteriorArrayH.SetInstancedArray(instancedInteriorArrayH, 1, 1, "hal_MapOffset", null);
			_InteriorArrayH.SetInstancedArray(instancedInteriorArrayH, 2, 1, "hal_Lod", null);
			_InteriorArrayH.SetInstancedArray(instancedInteriorArrayH, 3, 1, "hal_BlockColor", null);

			// Reuse indices array buffer, but limiting to 2 triangle strips
			_InteriorArrayH.SetElementArray(PrimitiveType.TriangleStrip, arrayBufferIndices, 0, BlockVertices * 4 + 3);

			#endregion

			#endregion

			#region Interiors (Vertical)

			#region Instances

			ColorRGBAF OuterColor = new ColorRGBAF(0.7f, 0.7f, 0.0f);

			ArrayBufferObjectInterleaved<ClipmapBlockInstance> instancedInteriorArrayV = new ArrayBufferObjectInterleaved<ClipmapBlockInstance>(BufferObjectHint.StaticCpuDraw);

			for (ushort level = 0; level < ClipmapLevels; level++) {
				xBlock = -semiStripStride - 2;
				yBlock = -semiStripStride - 2;
				for (int i = 0; i < 4; i++, yBlock += BlockSubdivs)
					_ClipmapInteriorV.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, OuterColor));

				xBlock = -semiStripStride - 2;
				yBlock = +semiStripStride - BlockSubdivs;
				_ClipmapInteriorV.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, OuterColor));
			}

			instancedInteriorArrayV.Create(_ClipmapInteriorV.ToArray());

			#endregion

			#region Vertex Array

			_InteriorArrayV = new VertexArrayObject();

			// Reuse position array buffer for ring fixes (horizontal)
			_InteriorArrayV.SetArray(arrayBufferPosition, VertexArraySemantic.Position);

			_InteriorArrayV.SetInstancedArray(instancedInteriorArrayV, 0, 1, "hal_BlockOffset", null);
			_InteriorArrayV.SetInstancedArray(instancedInteriorArrayV, 1, 1, "hal_MapOffset", null);
			_InteriorArrayV.SetInstancedArray(instancedInteriorArrayV, 2, 1, "hal_Lod", null);
			_InteriorArrayV.SetInstancedArray(instancedInteriorArrayV, 3, 1, "hal_BlockColor", null);

			// Reuse indices array buffer, but limiting to 2 triangle strips
			_InteriorArrayV.SetElementArray(PrimitiveType.TriangleStrip, arrayBufferIndicesV);

			#endregion

			#endregion
		}

		/// <summary>
		/// Shader program used for drawing geometry clipmap.
		/// </summary>
		private ShaderProgram _GeometryClipmapProgram;

		/// <summary>
		/// Vertex arrays for drawing 
		/// </summary>
		private VertexArrayObject _BlockArray;

		/// <summary>
		/// Vertex arrays for drawing 
		/// </summary>
		private VertexArrayObject _RingFixArrayH;

		/// <summary>
		/// Vertex arrays for drawing 
		/// </summary>
		private VertexArrayObject _RingFixArrayV;

		/// <summary>
		/// Vertex arrays for drawing interiors.
		/// </summary>
		private VertexArrayObject _InteriorArrayH;

		/// <summary>
		/// Vertex arrays for drawing interiors.
		/// </summary>
		private VertexArrayObject _InteriorArrayV;

		/// <summary>
		/// Elevation texture.
		/// </summary>
		private TextureArray2d _ElevationTexture;

		#endregion

		#region GraphicsResource Overrides

		/// <summary>
		/// GeometryClipmapObject class.
		/// </summary>
		internal static readonly Guid ThisObjectClass = new Guid("5340F306-B36B-46EA-8F5B-0886BB0FB78B");

		/// <summary>
		/// GeometryClipmapObject class.
		/// </summary>
		public override Guid ObjectClass { get { return (ThisObjectClass); } }

		/// <summary>
		/// Determine whether this object requires a name bound to a context or not.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// <para>
		/// This implementation returns always false.
		/// </para>
		/// </returns>
		protected override bool RequiresName(GraphicsContext ctx) { return (false); }

		/// <summary>
		/// Determine whether this GeometryClipmapObject really exists for a specific context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that would have created (or a sharing one) the object. This context shall be current to
		/// the calling thread.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this GeometryClipmapObject exists in the object space of <paramref name="ctx"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The object existence is done by checking a valid object by its name <see cref="IGraphicsResource.ObjectName"/>. This routine will test whether
		/// <paramref name="ctx"/> has created this GeometryClipmapObject (or is sharing with the creator).
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		public override bool Exists(GraphicsContext ctx)
		{
			// Object name space test (and 'ctx' sanity checks)
			if (base.Exists(ctx) == false)
				return (false);

			return (true);
		}

		/// <summary>
		/// Actually create this BufferObject resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject has not client memory allocated and the hint is different from
		/// <see cref="BufferObjectHint.StaticCpuDraw"/> or <see cref="BufferObjectHint.DynamicCpuDraw"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject is currently mapped.
		/// </exception>
		protected override void CreateObject(GraphicsContext ctx)
		{
			CheckCurrentContext(ctx);

			// Create shader program
			if (_GeometryClipmapProgram.Exists(ctx) == false)
				_GeometryClipmapProgram.Create(ctx);
			// Create vertex arrays
			_BlockArray.Create(ctx);
			_RingFixArrayH.Create(ctx);
			_RingFixArrayV.Create(ctx);
			_InteriorArrayH.Create(ctx);
			_InteriorArrayV.Create(ctx);
			// Create elevation texture
			uint elevationTextureSize = (uint)((BlockVertices + 1) * 2);

			_ElevationTexture = new TextureArray2d(elevationTextureSize, elevationTextureSize, ClipmapLevels, PixelLayout.GRAYF);
			_ElevationTexture.MinFilter = Texture.Filter.Nearest;
			_ElevationTexture.MagFilter = Texture.Filter.Nearest;
			_ElevationTexture.WrapCoordR = Texture.Wrap.Clamp;
			_ElevationTexture.WrapCoordS = Texture.Wrap.Clamp;
			_ElevationTexture.Create(ctx);
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown in the case <see cref="GraphicsResource.RefCount"/> is greater than zero. This means that the method is trying to dispose
		/// an object that is actually referenced by something else.
		/// </exception>
		protected override void Dispose(bool disposing)
		{
			// Base implementation
			base.Dispose(disposing);

			if (disposing == true) {
				if (_GeometryClipmapProgram != null) {
					_GeometryClipmapProgram.DecRef();
					_GeometryClipmapProgram = null;
				}

				if (_BlockArray != null) {
					_BlockArray.Dispose();
					_BlockArray = null;
				}

				if (_RingFixArrayH != null) {
					_RingFixArrayH.Dispose();
					_RingFixArrayH = null;
				}

				if (_RingFixArrayV != null) {
					_RingFixArrayV.Dispose();
					_RingFixArrayV = null;
				}

				if (_InteriorArrayH != null) {
					_InteriorArrayH.Dispose();
					_InteriorArrayH = null;
				}

				if (_InteriorArrayV != null) {
					_InteriorArrayV.Dispose();
					_InteriorArrayV = null;
				}

				foreach (ClipmapLevel clipmapLevel in _ClipmapLevels)
					if (clipmapLevel != null)
						clipmapLevel.Dispose();
			}
		}

		#endregion
	}
}
