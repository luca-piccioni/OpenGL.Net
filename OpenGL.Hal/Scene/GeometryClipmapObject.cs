
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

namespace OpenGL.Scene
{
	/// <summary>
	/// Geometry clipmap implementation.
	/// </summary>
	public class GeometryClipmapObject : SceneGraphObject
	{
		#region Constructors

		/// <summary>
		/// Construct a GeometryClipmapObject.
		/// </summary>
		/// <param name="rank">
		/// A <see cref="UInt16"/> that specify the number of LODs composing this GeometryClipmapObject using a logarithmic scale.
		/// </param>
		/// <param name="levels">
		/// A <see cref="UInt16"/> that specify the number of levels to draw.
		/// </param>
		/// <param name="unit">
		/// A <see cref="Single"/> that specify the size of a single quad unit.
		/// </param>
		public GeometryClipmapObject(ushort rank, ushort levels, float unit)
		{
			if (GraphicsContext.CurrentCaps.GlExtensions.InstancedArrays == false)
				throw new NotSupportedException();
			if (PrimitiveRestart.IsPrimitiveRestartSupported() == false)
				throw new NotSupportedException();

			// Clipmap properties
			StripStride = (uint)Math.Pow(2.0, rank) - 1;
			BlockVertices = (StripStride + 1) / 4;
			ClipmapLevels = levels;
			BlockQuadUnit = unit;

			// Define clipmap resources
			_ClipmapLevels = new ClipmapLevel[levels];
			// Define geometry clipmap program
			_GeometryClipmapProgram = ShadersLibrary.Instance.CreateProgram("GeometryClipmap");
			LinkResource(_GeometryClipmapProgram);
			// Create elevation texture
			uint elevationTextureSize = (uint)((BlockVertices + 1) * 2);

			_ElevationTexture = new TextureArray2d(elevationTextureSize, elevationTextureSize, ClipmapLevels, PixelLayout.GRAYF);
			_ElevationTexture.MinFilter = Texture.Filter.Nearest;
			_ElevationTexture.MagFilter = Texture.Filter.Nearest;
			_ElevationTexture.WrapCoordR = Texture.Wrap.Clamp;
			_ElevationTexture.WrapCoordS = Texture.Wrap.Clamp;
			LinkResource(_ElevationTexture);
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

		/// <summary>
		/// The world units that occupy a single quad of a block.
		/// </summary>
		public readonly float BlockQuadUnit;

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
			public ClipmapBlockInstance(uint n, uint m, int x, int y, uint lod, float unit) :
				this(n, m, x, y, lod, unit, new ColorRGBAF(1.0f, 1.0f, 1.0f, 1.0f))
			{

			}

			/// <summary>
			/// Construct a ClipmapBlock.
			/// </summary>
			public ClipmapBlockInstance(uint n, uint m, int x, int y, uint lod, float unit, ColorRGBAF color)
			{
				float scale = (float)Math.Pow(2.0, lod) * unit;
				float positionOffset = -1.0f;

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
		private readonly List<ClipmapBlockInstance> _InstancesClipmapBlock = new List<ClipmapBlockInstance>();

		/// <summary>
		/// Ring fix (horizontal).
		/// </summary>
		private readonly List<ClipmapBlockInstance> _InstancesRingFixH = new List<ClipmapBlockInstance>();

		/// <summary>
		/// Ring fix (vertical).
		/// </summary>
		private readonly List<ClipmapBlockInstance> _InstancesRingFixV = new List<ClipmapBlockInstance>();

		/// <summary>
		/// Exterior (horizontal).
		/// </summary>
		private readonly List<ClipmapBlockInstance> _InstancesExteriorH = new List<ClipmapBlockInstance>();

		/// <summary>
		/// Exterior (vertical).
		/// </summary>
		private readonly List<ClipmapBlockInstance> _InstancesExteriorV = new List<ClipmapBlockInstance>();

		#endregion

		#region Resources

		/// <summary>
		/// Create vertex arrays required for drawing the geometry clipmap blocks.
		/// </summary>
		private void CreateVertexArrays()
		{
			ushort BlockSubdivs = (ushort)(BlockVertices - 1);
			int semiStripStride = ((int)StripStride - 1) / 2;

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

			// Instances
			GenerateLevelBlocks();
			_ArrayClipmapBlockInstances = new ArrayBufferObjectInterleaved<ClipmapBlockInstance>(BufferObjectHint.DynamicCpuDraw);
			_ArrayClipmapBlockInstances.Create((uint)_InstancesClipmapBlock.Count);

			// Create blocks array
			_BlockArray = CreateVertexArrays(arrayBufferPosition, _ArrayClipmapBlockInstances, arrayBufferIndices, 0, 0);
			LinkResource(_BlockArray);

			#endregion

			#region Clipmap Ring Fixes (Horizontal)

			// Instances
			GenerateRingFixInstancesH();
			_ArrayRingFixHInstances = new ArrayBufferObjectInterleaved<ClipmapBlockInstance>(BufferObjectHint.DynamicCpuDraw);
			_ArrayRingFixHInstances.Create((uint)_InstancesRingFixH.Count);

			// Create ring fixes array
			_RingFixArrayH = CreateVertexArrays(arrayBufferPosition, _ArrayRingFixHInstances, arrayBufferIndices, 0, BlockVertices * 4 + 3);
			LinkResource(_RingFixArrayH);

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

			// Instances
			GenerateRingFixInstancesV();
			_ArrayRingFixVInstances = new ArrayBufferObjectInterleaved<ClipmapBlockInstance>(BufferObjectHint.StaticCpuDraw);
			_ArrayRingFixVInstances.Create((uint)_InstancesRingFixV.Count);

			// Create ring fixes array
			_RingFixArrayV = CreateVertexArrays(arrayBufferPosition, _ArrayRingFixVInstances, arrayBufferIndicesV, 0, 0);
			LinkResource(_RingFixArrayV);
			
			#endregion

			#region Interiors (Horizontal)

			GenerateExteriorInstancesH();
			_ArrayExteriorHInstances = new ArrayBufferObjectInterleaved<ClipmapBlockInstance>(BufferObjectHint.DynamicCpuDraw);
			_ArrayExteriorHInstances.Create((uint)_InstancesExteriorH.Count);

			// Create interior arrays
			// Reuse indices array buffer, but limiting to 2 triangle strips
			_InteriorArrayH = CreateVertexArrays(arrayBufferPosition, _ArrayExteriorHInstances, arrayBufferIndices, 0, BlockVertices * 4 + 3);
			LinkResource(_InteriorArrayH);
			
			#endregion

			#region Interiors (Vertical)

			ColorRGBAF OuterColor = new ColorRGBAF(0.7f, 0.7f, 0.0f);

			GenerateExteriorInstancesV();
			_ArrayExteriorVInstances = new ArrayBufferObjectInterleaved<ClipmapBlockInstance>(BufferObjectHint.DynamicCpuDraw);
			_ArrayExteriorVInstances.Create((uint)_InstancesExteriorV.Count);

			// Create interior arrays
			// Reuse indices array buffer, but limiting to 2 triangle strips
			_InteriorArrayV = CreateVertexArrays(arrayBufferPosition, _ArrayExteriorVInstances, arrayBufferIndicesV, 0, 0);
			LinkResource(_InteriorArrayV);

			#endregion
		}

		private VertexArrayObject CreateVertexArrays(ArrayBufferObjectBase positions, ArrayBufferObjectBase instances, ElementBufferObject indices, uint offset, uint count)
		{
			VertexArrayObject _RingFixArrayH = new VertexArrayObject();

			// Reuse position array buffer
			_RingFixArrayH.SetArray(positions, VertexArraySemantic.Position);

			_RingFixArrayH.SetInstancedArray(instances, 0, 1, "hal_BlockOffset", null);
			_RingFixArrayH.SetInstancedArray(instances, 1, 1, "hal_MapOffset", null);
			_RingFixArrayH.SetInstancedArray(instances, 2, 1, "hal_Lod", null);
			_RingFixArrayH.SetInstancedArray(instances, 3, 1, "hal_BlockColor", null);

			// Reuse indices array buffer, but limiting to 2 triangle strips
			_RingFixArrayH.SetElementArray(PrimitiveType.TriangleStrip, indices, offset, count);

			return (_RingFixArrayH);
		}

		private void GenerateLevelBlocks()
		{
			ushort BlockSubdivs = (ushort)(BlockVertices - 1);

			int semiStripStride = ((int)StripStride - 1) / 2;
			int xBlock, yBlock;

			for (ushort level = 0; level < ClipmapLevels; level++) {
				// Line 1
				yBlock = -semiStripStride;
				// Line 1 - 2 left
				xBlock = -semiStripStride;
				for (int i = 0; i < 2; i++, xBlock += BlockSubdivs)
					_InstancesClipmapBlock.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit));
				// Line 1 - 2 right
				xBlock = +semiStripStride - BlockSubdivs * 2;
				for (int i = 0; i < 2; i++, xBlock += BlockSubdivs)
					_InstancesClipmapBlock.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit));

				// Line 2
				yBlock += (int)(BlockVertices - 1);
				// Line 2 - 1 left
				xBlock = -semiStripStride;
				_InstancesClipmapBlock.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit));
				// Bottom right
				xBlock = +semiStripStride - BlockSubdivs;
				_InstancesClipmapBlock.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit));

				// Line 3
				yBlock = +semiStripStride - BlockSubdivs * 2;
				// Line 3 - 1 left
				xBlock = -semiStripStride;
				_InstancesClipmapBlock.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit));
				// Line 3 - 1 right
				xBlock = +semiStripStride - BlockSubdivs;
				_InstancesClipmapBlock.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit));

				// Line 4
				yBlock = +semiStripStride - BlockSubdivs;
				// Line 4 - 2 left
				xBlock = -semiStripStride;
				for (int i = 0; i < 2; i++, xBlock += BlockSubdivs)
					_InstancesClipmapBlock.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit));
				// Line 4 - 2 right
				xBlock = +semiStripStride - BlockSubdivs * 2;
				for (int i = 0; i < 2; i++, xBlock += BlockSubdivs)
					_InstancesClipmapBlock.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit));
			}
		}

		private void GenerateRingFixInstancesH()
		{
			ColorRGBAF RingFixColor = new ColorRGBAF(1.0f, 0.0f, 1.0f);
			ushort BlockSubdivs = (ushort)(BlockVertices - 1);

			int semiStripStride = ((int)StripStride - 1) / 2;
			int xBlock, yBlock;

			for (ushort level = 0; level < ClipmapLevels; level++) {
				xBlock = -semiStripStride;
				yBlock = -1;
				_InstancesRingFixH.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, RingFixColor));
				xBlock = +semiStripStride - BlockSubdivs;
				yBlock = -1;
				_InstancesRingFixH.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, RingFixColor));
			}
		}

		private void GenerateRingFixInstancesV()
		{
			ColorRGBAF RingFixColor = new ColorRGBAF(1.0f, 0.0f, 1.0f);
			ushort BlockSubdivs = (ushort)(BlockVertices - 1);

			int semiStripStride = ((int)StripStride - 1) / 2;
			int xBlock, yBlock;

			for (ushort level = 0; level < ClipmapLevels; level++) {
				xBlock = -1;
				yBlock = -semiStripStride;
				_InstancesRingFixV.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, RingFixColor));
				xBlock = -1;
				yBlock = +semiStripStride - BlockSubdivs;
				_InstancesRingFixV.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, RingFixColor));
			}
		}

		private void GenerateExteriorInstancesH()
		{
			ColorRGBAF ExteriorColor = new ColorRGBAF(1.0f, 1.0f, 0.0f);
			ushort BlockSubdivs = (ushort)(BlockVertices - 1);

			int semiStripStride = ((int)StripStride - 1) / 2;
			int xBlock, yBlock;

			int interiorInstancesCountH = ((int)StripStride + 1) / BlockSubdivs;

			for (ushort level = 0; level < ClipmapLevels; level++) {
				yBlock = -semiStripStride - 2;
				xBlock = -semiStripStride - 2;
				for (int i = 0; i < interiorInstancesCountH; i++, xBlock += BlockSubdivs)
					_InstancesExteriorH.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, ExteriorColor));

				yBlock = -semiStripStride - 2;
				xBlock = +semiStripStride - BlockSubdivs;
				_InstancesExteriorH.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, ExteriorColor));
			}
		}

		private void GenerateExteriorInstancesV()
		{
			ColorRGBAF ExteriorColor = new ColorRGBAF(1.0f, 1.0f, 0.0f);
			ushort BlockSubdivs = (ushort)(BlockVertices - 1);

			int semiStripStride = ((int)StripStride - 1) / 2;
			int xBlock, yBlock;

			int interiorInstancesCountV = ((int)StripStride + 1) / BlockSubdivs;

			for (ushort level = 0; level < ClipmapLevels; level++) {
				xBlock = -semiStripStride - 2;
				yBlock = -semiStripStride - 2;
				for (int i = 0; i < interiorInstancesCountV; i++, yBlock += BlockSubdivs)
					_InstancesExteriorV.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, ExteriorColor));

				xBlock = -semiStripStride - 2;
				yBlock = +semiStripStride - BlockSubdivs;
				_InstancesExteriorV.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, ExteriorColor));
			}
		}

		private List<ClipmapBlockInstance> GenerateLevelBlocksCap(uint level)
		{
			List<ClipmapBlockInstance> capBlocks = new List<ClipmapBlockInstance>();

			ushort BlockSubdivs = (ushort)(BlockVertices - 1);

			int semiStripStride = ((int)StripStride - 1) / 2;

			capBlocks.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)0, (int)0, level, BlockQuadUnit));
			capBlocks.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)-BlockSubdivs, (int)0, level, BlockQuadUnit));
			capBlocks.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)0, (int)-BlockSubdivs, level, BlockQuadUnit));
			capBlocks.Add(new ClipmapBlockInstance(StripStride, BlockVertices, (int)-BlockSubdivs, (int)-BlockSubdivs, level, BlockQuadUnit));

			return (capBlocks);
		}

		/// <summary>
		/// Shader program used for drawing geometry clipmap.
		/// </summary>
		private ShaderProgram _GeometryClipmapProgram;

		/// <summary>
		/// Array buffer object defining instances attributes.
		/// </summary>
		private ArrayBufferObjectInterleaved<ClipmapBlockInstance> _ArrayClipmapBlockInstances;

		/// <summary>
		/// Array buffer object defining instances attributes.
		/// </summary>
		private ArrayBufferObjectInterleaved<ClipmapBlockInstance> _ArrayRingFixHInstances;

		/// <summary>
		/// Array buffer object defining instances attributes.
		/// </summary>
		private ArrayBufferObjectInterleaved<ClipmapBlockInstance> _ArrayRingFixVInstances;

		/// <summary>
		/// Array buffer object defining instances attributes.
		/// </summary>
		private ArrayBufferObjectInterleaved<ClipmapBlockInstance> _ArrayExteriorHInstances;

		/// <summary>
		/// Array buffer object defining instances attributes.
		/// </summary>
		private ArrayBufferObjectInterleaved<ClipmapBlockInstance> _ArrayExteriorVInstances;

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

		#region SceneGraphObject Overrides

		/// <summary>
		/// Draw this SceneGraphObject hierarchy.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="ctxScene">
		/// The <see cref="SceneGraphContext"/> used for drawing.
		/// </param>
		protected internal override void Draw(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			if (ctxScene == null)
				throw new ArgumentNullException("ctxScene");

			Vertex3d currentPosition = (Vertex3d)ctxScene.CurrentView.LocalModel.Position;

			// Compute visible clipmap levels
			const float HeightGain = 2.5f;

			float viewerHeight = currentPosition.Y;
			float clipmap0Size = BlockQuadUnit * (StripStride - 1);

			_CurrentLevel = 0;
			while (clipmap0Size * Math.Pow(2.0, _CurrentLevel) < viewerHeight * HeightGain)
				_CurrentLevel++;

			// Compute position module
			double positionModule = BlockQuadUnit * Math.Pow(2.0, _CurrentLevel);

			// Reset to ground
			currentPosition.y = 0.0;
			// Update the model
			LocalModel.SetIdentity();
			LocalModel.Translate(currentPosition + (currentPosition % positionModule));

			// Draw as usual
			base.Draw(ctx, ctxScene);
		}

		protected override void DrawThis(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			if (ctxScene == null)
				throw new ArgumentNullException("ctx");

			CheckCurrentContext(ctx);

			ctxScene.GraphicsStateStack.Current.Apply(ctx, _GeometryClipmapProgram);

			_GeometryClipmapProgram.Bind(ctx);
			_GeometryClipmapProgram.ResetTextureUnits();
			_GeometryClipmapProgram.SetUniform(ctx, "hal_ElevationMap", _ElevationTexture);

			// Instance culling
			List<ClipmapBlockInstance> instancesClipmapBlock = new List<ClipmapBlockInstance>(_InstancesClipmapBlock);

			// Include cap in clipmap blocks
			instancesClipmapBlock.AddRange(GenerateLevelBlocksCap(_CurrentLevel));

			// Cull instances
			uint instancesClipmapBlockCount = CullInstances(ctx, instancesClipmapBlock, _ArrayClipmapBlockInstances);
			uint instancesRingFixHCount = CullInstances(ctx, _InstancesRingFixH, _ArrayRingFixHInstances);
			uint instancesRingFixVCount = CullInstances(ctx, _InstancesRingFixV, _ArrayRingFixVInstances);
			uint instancesExteriorHCount = CullInstances(ctx, _InstancesExteriorH, _ArrayExteriorHInstances);
			uint instancesExteriorVCount = CullInstances(ctx, _InstancesExteriorV, _ArrayExteriorVInstances);

			// Draw clipmap blocks using instanced rendering
			_BlockArray.DrawInstanced(ctx, _GeometryClipmapProgram, instancesClipmapBlockCount);
			_RingFixArrayH.DrawInstanced(ctx, _GeometryClipmapProgram, instancesRingFixHCount);
			_RingFixArrayV.DrawInstanced(ctx, _GeometryClipmapProgram, instancesRingFixVCount);
			_InteriorArrayH.DrawInstanced(ctx, _GeometryClipmapProgram, instancesExteriorHCount);
			_InteriorArrayV.DrawInstanced(ctx, _GeometryClipmapProgram, instancesExteriorVCount);
		}

		private uint CullInstances(GraphicsContext ctx, List<ClipmapBlockInstance> instances, ArrayBufferObjectInterleaved<ClipmapBlockInstance> arrayBuffer)
		{
			List<ClipmapBlockInstance> cull = new List<ClipmapBlockInstance>(instances);

			// Filter by level
			// Exclude finer levels depending on viewer height
			cull = cull.FindAll(delegate (ClipmapBlockInstance item) {
				return (item.Lod >= _CurrentLevel);
			});

			// Update instance arrays
			arrayBuffer.Update(ctx, cull.ToArray());

			return ((uint)cull.Count);
		}

		/// <summary>
		/// Temporary field used by <see cref="Draw"/> and <see cref="DrawThis"/>.
		/// </summary>
		private uint _CurrentLevel;

		#endregion
	}
}
