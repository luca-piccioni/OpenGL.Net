
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

// Symbol enabling debugging colors
#if DEBUG
#define CLIPMAP_COLOR_DEBUG
#endif

// Symbol enabling wireframe rendering
#undef CLIPMAP_DEBUG_WIREFRAME

// Symbol enabling clipmap level cap
#define CLIPMAP_CAP

// Symbol enabling position correction
#define POSITION_CORRECTION

// Symbol enabling elevation mapping
#define TEXTURING_ELEVATION

// Symbol enabling culling of the clipmap level blocks
#define CULLING_CLIPMAP_BLOCKS

// Symbol enabling culling of the clipmap level cap
#if !DEBUG
#define CULLING_CLIPMAP_CAP
#endif

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

using OpenGL.State;

namespace OpenGL.Scene
{
	/// <summary>
	/// Geometry clipmap implementation.
	/// </summary>
	public partial class GeometryClipmapObject : SceneGraphObject
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
			ClipmapVertices = (uint)Math.Pow(2.0, Math.Max(rank, 4.0)) - 1;
			BlockVertices = (ClipmapVertices + 1) / 4;
			ClipmapLevels = levels;
			BlockQuadUnit = unit;

			// Define clipmap resources
			_ClipmapLevels = new ClipmapLevel[levels];
			for (uint i = 0; i < levels; i++)
				_ClipmapLevels[i] = new ClipmapLevel(i);
			// Default the elevation sources (defaults to no sources)
			_TerrainElevationSources = new ITerrainElevationSource[ClipmapLevels];
			// Depth buffer enabled
			_ObjectState.DefineState(new DepthTestState(DepthFunction.Lequal));
#if CLIPMAP_DEBUG_WIREFRAME
			_ObjectState.DefineState(new PolygonModeState(PolygonMode.Line));
#endif

			CreateGeometryResources();
			CreateTextureResources();
		}

		#endregion

		#region Definition

		/// <summary>
		/// The number of vertices composing a line of the clipmap level.
		/// </summary>
		public readonly uint ClipmapVertices;

		/// <summary>
		/// Get the number of subdivisions composing a line of the clipmap level.
		/// </summary>
		private uint ClipmapSubdivs { get { return (ClipmapVertices - 1); } }

		/// <summary>
		/// The number of vertices composing a line of the clipmap block.
		/// </summary>
		public readonly uint BlockVertices;

		/// <summary>
		/// Get the number of subdivisions composing a line of the clipmap block.
		/// </summary>
		private uint BlockSubdivs { get { return (BlockVertices - 1); } }

		/// <summary>
		/// Get the number of vertices composing a line of the clipmap level exterior.
		/// </summary>
		private uint ExteriorVertices { get { return (ClipmapVertices + 4); } }

		/// <summary>
		/// Get the number of subdivisions composing a line of the clipmap level exterior.
		/// </summary>
		private uint ExteriorSubdivs { get { return (ExteriorVertices - 1); } }

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
			/// <param name="lod">
			/// A <see cref="UInt32"/> that specify texture array LOD.
			/// </param>
			public ClipmapLevel(uint lod)
			{
				Lod = lod;
			}

			#endregion

			#region Level Information

			/// <summary>
			/// The Level Of Detail of the texture (i.e. the texture array level).
			/// </summary>
			public readonly uint Lod;

			/// <summary>
			/// Position on the grid of the clipmap level. Used to determine offsets.
			/// </summary>
			public Vertex2d GridPosition;

			#endregion

			#region Methods

			public void UpdateGridPosition(Vertex2d position, double unitScale)
			{
				double lodUnitScale = Math.Pow(2.0, Lod) * unitScale;
				Vertex2d positionDelta = (position - GridPosition) / lodUnitScale;

				positionDelta = new Vertex2d(Math.Truncate(positionDelta.x), Math.Truncate(positionDelta.y));

				if (Math.Abs(positionDelta.x) < 1.0 && Math.Abs(positionDelta.y) < 1.0)
					return;

				GridPosition = GridPosition + positionDelta * lodUnitScale;

				// Trace.TraceInformation("Grid LOD {0} reposition: {1}", Lod, GridPosition);
			}

			#endregion

			#region IDisposable Implementation

			/// <summary>
			/// Dispose resources.
			/// </summary>
			public void Dispose()
			{
				
			}

			#endregion
		}

		/// <summary>
		/// Clipmap levels abstraction.
		/// </summary>
		private readonly ClipmapLevel[] _ClipmapLevels;

		public bool PositionCorrection
		{
			get { return (_PositionCorrection); }
			set
			{
				_PositionCorrection = value;
			}
		}

		/// <summary>
		/// Flag used for enabling position correction.
		/// </summary>
		private bool _PositionCorrection = true;

		#endregion

		#region Geometry Clipmap Blocks

		/// <summary>
		/// Geometry clipmap instanced attribute.
		/// </summary>
		/// <remarks>
		/// Each Clipmap block defines instanced attributes for the geometry clipmap block.
		/// </remarks>
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		[DebuggerDisplay("ClipmapBlockInstance: Lod={Lod} PosMin={PositionMin} PosMax={PositionMax}")]
		private struct ClipmapBlockInstance
		{
			#region Constructors

			/// <summary>
			/// Construct a ClipmapBlock.
			/// </summary>
			/// <param name="n">
			/// Number of vertices composing the clipmap level (used for texturing).
			/// </param>
			/// <param name="m">
			/// The number of vertices defining the block area normalized in the range [0.0, 1.0].
			/// </param>
			/// <param name="x">
			/// The offset on X axis of the lower-left corner of the block, in block quad units (position and texturing).
			/// </param>
			/// <param name="y">
			/// The offset on Z axis of the lower-left corner of the block, in block quad units (position and texturing).
			/// </param>
			/// <param name="lod">
			/// The Level Of Detail of the block (determine which clipmap level is included into, indeed the scale factor).
			/// </param>
			/// <param name="unit">
			/// The unit of a block quad (scale factor).
			/// </param>
			public ClipmapBlockInstance(uint n, uint m, int x, int y, uint lod, float unit) :
				this(n, m, x, y, lod, unit, new ColorRGBAF(1.0f, 1.0f, 1.0f, 1.0f))
			{

			}

			/// <summary>
			/// Construct a ClipmapBlock.
			/// </summary>
			/// <param name="n">
			/// Number of vertices composing the clipmap level (used for texturing).
			/// </param>
			/// <param name="m">
			/// The number of vertices defining the block area normalized in the range [0.0, 1.0].
			/// </param>
			/// <param name="x">
			/// The offset on X axis of the lower-left corner of the block, in block quad units (position and texturing).
			/// </param>
			/// <param name="y">
			/// The offset on Z axis of the lower-left corner of the block, in block quad units (position and texturing).
			/// </param>
			/// <param name="lod">
			/// The Level Of Detail of the block (determine which clipmap level is included into, indeed the scale factor).
			/// </param>
			/// <param name="unit">
			/// The unit of a block quad (scale factor).
			/// </param>
			/// <param name="color">
			/// The debugging color of the block.
			/// </param>
			public ClipmapBlockInstance(uint n, uint m, int x, int y, uint lod, float unit, ColorRGBAF color) :
				this(n, m, m, x, y, lod, unit, color)
			{

			}

			/// <summary>
			/// Construct a ClipmapBlock.
			/// </summary>
			/// <param name="n">
			/// Number of vertices composing the clipmap level (used for texturing).
			/// </param>
			/// <param name="m">
			/// The number of vertices defining the block area normalized in the range [0.0, 1.0].
			/// </param>
			/// <param name="x">
			/// The offset on X axis of the lower-left corner of the block, in block quad units (position and texturing).
			/// </param>
			/// <param name="y">
			/// The offset on Z axis of the lower-left corner of the block, in block quad units (position and texturing).
			/// </param>
			/// <param name="lod">
			/// The Level Of Detail of the block (determine which clipmap level is included into, indeed the scale factor).
			/// </param>
			/// <param name="unit">
			/// The unit of a block quad (scale factor).
			/// </param>
			/// <param name="color">
			/// The debugging color of the block.
			/// </param>
			public ClipmapBlockInstance(uint n, uint mw, uint mh, int x, int y, uint lod, float unit, ColorRGBAF color)
			{
				if (mw < 2)
					throw new ArgumentOutOfRangeException("mw");
				if (mh < 2)
					throw new ArgumentOutOfRangeException("mh");

				float scale = (float)Math.Pow(2.0, lod) * unit;

				// Position offset and scale
				Offset = new Vertex4f(x, y, mw - 1, mh - 1) * scale;		// Position is always build on clipmap grid
				// Texture coordinate offset and scale
				float texNormalizedSize = (1.0f - (1.0f / (n + 1)));

				float clipmapLevelSize = (float)(n - 1);
				float clipmapLevelSize2 = clipmapLevelSize / 2.0f;

				float xTexOffset = (x + clipmapLevelSize2) / clipmapLevelSize;
				float yTexOffset = (y + clipmapLevelSize2) / clipmapLevelSize;
				float xTexScale = (float)(mw - 1) / (n - 1);
				float yTexScale = (float)(mh - 1) / (n - 1);

				MapOffset = new Vertex4f(xTexOffset, yTexOffset, xTexScale, yTexScale) * texNormalizedSize;
				// LOD
				Lod = new Vertex2f(lod, lod);
				// Instance color
#if CLIPMAP_COLOR_DEBUG
				BlockColor = color;
#else
				BlockColor = new ColorRGBAF(1.0f, 1.0f, 1.0f, 1.0f);
#endif
			}

			#endregion

			#region Level Of Detail

			/// <summary>
			/// Increment the LOD used for texturing, mantaining the position offset and scale.
			/// </summary>
			/// <param name="n">
			/// Number of vertices composing the clipmap level.
			/// </param>
			public void IncTextureLod(uint n)
			{
				float texNormalizedSizeLod0 = (1.0f - (1.0f / (n + 1)));

				// LOD - access to coarser texture, but mantains the position offset/scale
				// Note: because this, we need Linear filter for texturing for this block
				Lod = new Vertex2f(Lod.X + 1.0f, Lod.Y);
				// Scale to next LOD
				Vertex4f mapOffset = MapOffset / texNormalizedSizeLod0;		// Normalize in range [0.0,1.0]

				float x = (mapOffset.X + 0.5f) / 2.0f;
				float y = (mapOffset.Y + 0.5f) / 2.0f;
				float x2 = ((mapOffset.X + mapOffset.Z) + 0.5f) / 2.0f;
				float y2 = ((mapOffset.Y + mapOffset.W) + 0.5f) / 2.0f;

				MapOffset = new Vertex4f(x, y, x2 - x, y2 - y) * texNormalizedSizeLod0;
			}

			#endregion

			#region Culling

			/// <summary>
			/// The bounding volume containing the clipmap block.
			/// </summary>
			public IBoundingVolume GetBoundingVolume(Vertex2f[] gridOffsets)
			{
				if (gridOffsets == null)
					throw new ArgumentNullException("gridOffsets");
				if (gridOffsets.Length <= (int)Lod.Y)
					throw new ArgumentException("no offset for LOD");

				const float MinY = -3000.0f, MaxY = 8848.0f;

				Vertex2f gridOffset = gridOffsets[(int)Lod.Y];
				Vertex3f min = new Vertex3f(Offset.X + gridOffset.x,            MinY, Offset.Y + gridOffset.y);
				Vertex3f max = new Vertex3f(Offset.X + gridOffset.x + Offset.Z, MaxY, Offset.Y + gridOffset.y + Offset.W);

				return (new BoundingBox(min, max));
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
			public Vertex2f Lod;

			/// <summary>
			/// Debugging color for instancing.
			/// </summary>
			public ColorRGBAF BlockColor;

			#endregion

			#region Attributes

			public Vertex2f PositionMin { get { return (new Vertex2f(Offset.x, Offset.y)); } }

			public Vertex2f PositionMax { get { return (new Vertex2f(Offset.x + Offset.z, Offset.y + Offset.w)); } }

			public float PositionWidth { get { return (Offset.z - Offset.x); } }

			public float PositionHeight { get { return (Offset.w - Offset.y); } }

			public Vertex2f TexCoordMin { get { return (new Vertex2f(MapOffset.x, MapOffset.y)); } }

			public Vertex2f TexCoordMax { get { return (new Vertex2f(MapOffset.x + MapOffset.z, MapOffset.y + MapOffset.w)); } }

			#endregion
		}

		/// <summary>
		/// Blocks array.
		/// </summary>
		private readonly List<ClipmapBlockInstance> _InstancesClipmapBlock = new List<ClipmapBlockInstance>();

		/// <summary>
		/// Ring fix (horizontal).
		/// </summary>
		private readonly List<ClipmapBlockInstance> _InstancesRingFixH = new List<ClipmapBlockInstance>(), _InstancesRingFixV = new List<ClipmapBlockInstance>();

		/// <summary>
		/// Ring fix (vertical).
		/// </summary>
		private readonly List<ClipmapBlockInstance> _InstancesExteriorH = new List<ClipmapBlockInstance>(), _InstancesExteriorV = new List<ClipmapBlockInstance>();

		#endregion

		#region Elevation Texture Source

		/// <summary>
		/// Factory pattern interface for creating <see cref="ITerrainElevationSource"/> instances.
		/// </summary>
		public interface ITerrainElevationFactory
		{
			/// <summary>
			/// Creates the <see cref="ITerrainElevationSource"/> for the specified LOD.
			/// </summary>
			/// <param name="lod">
			/// A <see cref="UInt32"/> that specify the Level Of Detail of the terrain elevation data.
			/// </param>
			/// <param name="size">
			/// A <see cref="UInt32"/> that specify the size of the required terrain elevation source, in pixels, to be
			/// applied for both extents.
			/// </param>
			/// <param name="unitScale">
			/// A <see cref="Single"/> that specify the scale to be applied to a single terrain elevation fragment, in meters.
			/// </param>
			/// <returns>
			/// It returns a <see cref="ITerrainElevationSource"/> that satisfy the specified parameters.
			/// </returns>
			ITerrainElevationSource CreateTerrainElevationSource(uint lod, uint size, float unitScale);
		}

		/// <summary>
		/// Interface implemented by those objects able to provide terrain elevation data, feeding information required
		/// to implement the geometry clipmap.
		/// </summary>
		public interface ITerrainElevationSource : IDisposable
		{
			/// <summary>
			/// Get the terrain elevation map corresponding to the specified position.
			/// </summary>
			/// <param name="viewPosition">
			/// The <see cref="Vertex2d"/> that specify the current view position, using an absolute cartesian reference system.
			/// </param>
			/// <returns>
			/// It returns the <see cref="Image"/> that contains the terrain elevation data corresponding to <paramref name="viewPosition"/>.
			/// </returns>
			Image GetTerrainElevationMap(Vertex2d viewPosition);
		}

		/// <summary>
		/// Set the default terrain elevation factory.
		/// </summary>
		/// <param name="lat">
		/// The <see cref="Double"/> that specify the reference latitude coordinate, in degrees.
		/// </param>
		/// <param name="lon">
		/// The <see cref="Double"/> that specify the reference longitude coordinate, in degrees.
		/// </param>
		public void SetTerrainElevationFactory(string databaseRoot, double lat, double lon)
		{
			SetTerrainElevationFactory(new DefaultTerrainElevationFactory(databaseRoot, lat, lon, ClipmapLevels));
		}

		/// <summary>
		/// Set the terrain elevation source.
		/// </summary>
		/// <param name="terrainElevationFactory">
		/// The <see cref="ITerrainElevationFactory"/> that is able to create the terrain elevation sources for each
		/// geometry clipmap level.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="terrainElevationFactory"/> is null.
		/// </exception>
		public void SetTerrainElevationFactory(ITerrainElevationFactory terrainElevationFactory)
		{
			if (terrainElevationFactory == null)
				throw new ArgumentNullException("terrainElevationFactory");

			for (ushort i = 0; i < ClipmapLevels; i++) {
				if (_TerrainElevationSources[i] != null)
					_TerrainElevationSources[i].Dispose();
				_TerrainElevationSources[i] = terrainElevationFactory.CreateTerrainElevationSource(i, ClipmapVertices + 1, BlockQuadUnit);
			}
		}

		#endregion

		#region Elevation Texture Update

		/// <summary>
		/// Create resources required for updating the elevation texture.
		/// </summary>
		private void CreateTextureResources()
		{
			// Create elevation texture
			uint elevationTextureSize = (uint)Math.Min(ClipmapVertices + 1, GraphicsContext.CurrentCaps.Limits.MaxTexture2DSize);

			_ElevationSource = new Texture2d(elevationTextureSize, elevationTextureSize, PixelLayout.GRAY16S);
			_ElevationSource.MinFilter = Texture.Filter.Nearest;
			_ElevationSource.MagFilter = Texture.Filter.Nearest;
			_ElevationSource.WrapCoordR = Texture.Wrap.Clamp;
			_ElevationSource.WrapCoordS = Texture.Wrap.Clamp;
			LinkResource(_ElevationSource);

			// Elevation texture framebuffer
			_ElevationFramebuffer = new Framebuffer();
			LinkResource(_ElevationFramebuffer);

			// Create vertex arrays
			ArrayBufferObject<Vertex2f> arrayBufferPosition = new ArrayBufferObject<Vertex2f>(BufferObjectHint.StaticCpuDraw);

			arrayBufferPosition.Create(new Vertex2f[] {
				new Vertex2f(0.0f, 0.0f),
				new Vertex2f(1.0f, 0.0f),
				new Vertex2f(0.0f, 1.0f),
				new Vertex2f(1.0f, 1.0f),
			}, 4);

			_ElevationTexQuad = new VertexArrayObject();
			_ElevationTexQuad.SetArray(arrayBufferPosition, VertexArraySemantic.Position);
			_ElevationTexQuad.SetArray(arrayBufferPosition, VertexArraySemantic.TexCoord);
			_ElevationTexQuad.SetElementArray(PrimitiveType.TriangleStrip);
			LinkResource(_ElevationTexQuad);

			// Create shader program
			_GeometryClipmapTextureProgram = ShadersLibrary.Instance.CreateProgram("GeometryClipmapTexture");
			LinkResource(_GeometryClipmapTextureProgram);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ctx"></param>
		/// <param name="ctxScene"></param>
		private void UpdateTerrainElevationTextures(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			if (PositionCorrection == false)
				return;

			Vertex3d viewPosition = ctxScene.CurrentView.LocalModel.Position;

			for (int i = ClipmapLevels - 1; i >= 0; i--) {
				if (_TerrainElevationSources[i] == null)
					continue;

				Image elevationMap = _TerrainElevationSources[i].GetTerrainElevationMap(new Vertex2d(viewPosition.x, viewPosition.z));
#if DEBUG
				Debug.Assert((elevationMap != null) == _GridOffsetsUpdated[i]);
#endif
				if (elevationMap == null)
					continue;       // No update required

#if TEXTURING_ELEVATION
				// Update elevation map texture for this LOD
				_ElevationSource.Create(ctx, elevationMap);
				// Generate elevation map used for rendering
				_ElevationFramebuffer.AttachColor(0, _ElevationTexture, (uint)i);
				_ElevationFramebuffer.BindDraw(ctx);

				using (GraphicsStateKeeper graphicsStateKeeper = new GraphicsStateKeeper(ctx)) {
					// Keep states
					graphicsStateKeeper.Keep(PolygonModeState.StateId);
					graphicsStateKeeper.Keep(ViewportState.StateId);
					// Set new state
					graphicsStateKeeper.DefineState(new PolygonModeState(PolygonMode.Fill));
					graphicsStateKeeper.DefineState(new ViewportState(_ElevationFramebuffer));
					graphicsStateKeeper.Apply(ctx, _GeometryClipmapTextureProgram);
					// Set program uniforms
					ctx.Bind(_GeometryClipmapTextureProgram);
					_GeometryClipmapTextureProgram.SetUniform(ctx, "hal_ModelViewProjection", new OrthoProjectionMatrix(0.0f, 1.0f, 0.0f, 1.0f));
					_GeometryClipmapTextureProgram.SetUniform(ctx, "hal_ElevationMap", _ElevationSource);
					_GeometryClipmapTextureProgram.SetUniform(ctx, "hal_ElevationMapQuadUnit", (float)(BlockQuadUnit * Math.Pow(2.0, i)));

					// Update texture layer
					_ElevationTexQuad.Draw(ctx, _GeometryClipmapTextureProgram);
				}

				_ElevationFramebuffer.UnbindDraw(ctx);
#endif
			}
		}

		/// <summary>
		/// The source of the terrain elevation maps.
		/// </summary>
		private readonly ITerrainElevationSource[] _TerrainElevationSources;

		/// <summary>
		/// Shader program used for updating geometry clipmap texture.
		/// </summary>
		private ShaderProgram _GeometryClipmapTextureProgram;

		/// <summary>
		/// Framebuffer used for generating elevation texture.
		/// </summary>
		private Framebuffer _ElevationFramebuffer;

		/// <summary>
		/// Vertex arrays for drawing ring fix (horizontal and vertical patches).
		/// </summary>
		private VertexArrayObject _ElevationTexQuad;

		/// <summary>
		/// Temporary texture used for inputting elevation data to the elevation map.
		/// </summary>
		private Texture2d _ElevationSource;

		#endregion

		#region Geometry Resources

		/// <summary>
		/// Create resources required for geometry.
		/// </summary>
		private void CreateGeometryResources()
		{
			// Define geometry clipmap programs
			_GeometryClipmapProgram = ShadersLibrary.Instance.CreateProgram("GeometryClipmap");
			LinkResource(_GeometryClipmapProgram);

			// Create elevation texture
			uint elevationTextureSize = (uint)Math.Min(ClipmapVertices + 1, GraphicsContext.CurrentCaps.Limits.MaxTexture2DSize);

			_ElevationTexture = new TextureArray2d(elevationTextureSize, elevationTextureSize, ClipmapLevels, PixelLayout.RGBAF);
			_ElevationTexture.MinFilter = Texture.Filter.Nearest;
			_ElevationTexture.MagFilter = Texture.Filter.Nearest;
			_ElevationTexture.WrapCoordR = Texture.Wrap.Clamp;
			_ElevationTexture.WrapCoordS = Texture.Wrap.Clamp;
			LinkResource(_ElevationTexture);

			// Create elevation banding texture
			_ElevationBandingTexture = new Texture1d();
			_ElevationBandingTexture.MinFilter = Texture.Filter.Nearest;
			_ElevationBandingTexture.MagFilter = Texture.Filter.Nearest;
			_ElevationBandingTexture.WrapCoordR = Texture.Wrap.MirroredRepeat;
			_ElevationBandingTexture.WrapCoordS = Texture.Wrap.Clamp;
			_ElevationBandingTexture.CreateFromResource("OpenGL.Shaders.GeometryClipmap.DefaultElevationBanding.png", ImageFormat.Png);
			LinkResource(_ElevationBandingTexture);

			// Define geometry clipmap vertex arrays
			CreateGeometryVertexArrays();
		}

		/// <summary>
		/// Create vertex arrays required for drawing the geometry clipmap blocks.
		/// </summary>
		private void CreateGeometryVertexArrays()
		{
			#region Clipmap Blocks

			// Create position array buffer ((n+1) x (n+1) vertices equally spaced)
			// Note: this array is shared with ring fixes
			ArrayBufferObject<Vertex2f> arrayBufferPosition = CreateClipmapBlockPositionArray();

			// Create elements indices
			// Note: this array is shared with ring fixes (horizontal)
			ElementBufferObject<ushort> arrayBufferIndices = CreateClipmapBlockElementArray();

			// Instances list (total instances to be culled)
			GenerateLevelBlocks();
			// Instances
			_ArrayClipmapBlockInstances = new ArrayBufferObjectInterleaved<ClipmapBlockInstance>(BufferObjectHint.DynamicCpuDraw);
			_ArrayClipmapBlockInstances.Create((uint)_InstancesClipmapBlock.Count);

			// Create blocks array
			_BlockArray = CreateVertexArrays(arrayBufferPosition, _ArrayClipmapBlockInstances, arrayBufferIndices, 0, 0);
			LinkResource(_BlockArray);

			#endregion

			#region Clipmap Ring Fixes (Horizontal)

			// Instances list (total instances to be culled)
			GenerateRingFixInstancesH();
			// Instances
			_ArrayRingFixHInstances = new ArrayBufferObjectInterleaved<ClipmapBlockInstance>(BufferObjectHint.DynamicCpuDraw);
			_ArrayRingFixHInstances.Create((uint)_InstancesRingFixH.Count);

			// Create ring fixes array
			_RingFixArrayH = CreateVertexArrays(arrayBufferPosition, _ArrayRingFixHInstances, arrayBufferIndices, 0, BlockVertices * 4 + 3);
			LinkResource(_RingFixArrayH);

			#endregion

			#region Clipmap Ring Fixes (Vertical)

			// Create custom elements indices for ring fixes (vertical only)
			ElementBufferObject<ushort> arrayBufferIndicesV = CreateRingFixVElementArray();

			// Instances list (total instances to be culled)
			GenerateRingFixInstancesV();
			// Instances
			_ArrayRingFixVInstances = new ArrayBufferObjectInterleaved<ClipmapBlockInstance>(BufferObjectHint.StaticCpuDraw);
			_ArrayRingFixVInstances.Create((uint)_InstancesRingFixV.Count);

			// Vertex array
			_RingFixArrayV = CreateVertexArrays(arrayBufferPosition, _ArrayRingFixVInstances, arrayBufferIndicesV, 0, 0);
			LinkResource(_RingFixArrayV);

			#endregion

			#region Exterior (Horizontal)

			// Create position array buffer
			ArrayBufferObject<Vertex2f> exteriorHPosition = CreateExteriorHPositionArray();

			// Create elements indices
			ElementBufferObject<ushort> exteriorHIndices = CreateExteriorHElementArray();

			// Instances list (total instances to be culled)
			GenerateExteriorInstancesH();
			// Instances
			_ArrayExteriorHInstances = new ArrayBufferObjectInterleaved<ClipmapBlockInstance>(BufferObjectHint.DynamicCpuDraw);
			_ArrayExteriorHInstances.Create((uint)_InstancesExteriorH.Count);

			// Vertex array
			_LevelExteriorH = CreateVertexArrays(exteriorHPosition, _ArrayExteriorHInstances, exteriorHIndices, 0, 0);
			LinkResource(_LevelExteriorH);

			#endregion

			#region Exterior (Vertical)

			// Create position array buffer
			ArrayBufferObject<Vertex2f> exteriorVPosition = CreateExteriorVPositionArray();

			// Create elements indices
			ElementBufferObject<ushort> exteriorVIndices = CreateExteriorVElementArray();

			// Instances list (total instances to be culled)
			GenerateExteriorInstancesV();
			// Instances
			_ArrayExteriorVInstances = new ArrayBufferObjectInterleaved<ClipmapBlockInstance>(BufferObjectHint.DynamicCpuDraw);
			_ArrayExteriorVInstances.Create((uint)_InstancesExteriorV.Count);

			// Vertex array
			_LevelExteriorV = CreateVertexArrays(exteriorVPosition, _ArrayExteriorVInstances, exteriorVIndices, 0, 0);
			LinkResource(_LevelExteriorV);

			#endregion

			#region Cap Exterior

			// Vertex array
			_LevelCapExterior = new VertexArrayObject();
			_LevelCapExterior.SetArrayDefault(new Vertex4f(), "hal_BlockColor", null);
			LinkResource(_LevelCapExterior);

			#endregion
		}

		private ArrayBufferObject<Vertex2f> CreateClipmapBlockPositionArray()
		{
			ArrayBufferObject<Vertex2f> arrayBufferPosition = new ArrayBufferObject<Vertex2f>(BufferObjectHint.StaticCpuDraw);

			arrayBufferPosition.Create((uint)(BlockVertices * BlockVertices));
			arrayBufferPosition.Map();

			float positionStep = 1.0f / BlockSubdivs;
			uint positionIndex = 0;
			
			for (float y = 0.0f; y <= 1.0f; y += positionStep) {
				for (float x = 0.0f; x <= 1.0f; x += positionStep, positionIndex++) {
					Debug.Assert(positionIndex < arrayBufferPosition.ClientItemCount);
					arrayBufferPosition.Set(new Vertex2f(x, y), positionIndex);
				}
			}
			arrayBufferPosition.Unmap();

			return (arrayBufferPosition);
		}

		private ElementBufferObject<ushort> CreateClipmapBlockElementArray()
		{
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

			return (arrayBufferIndices);
		}

		private ElementBufferObject<ushort> CreateRingFixVElementArray()
		{
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
					arrayBufferElementsV.Add((ushort)arrayBufferIndicesV.RestartIndexKey);
			}

			arrayBufferIndicesV.Create(arrayBufferElementsV.ToArray());

			return (arrayBufferIndicesV);
		}

		private ArrayBufferObject<Vertex2f> CreateExteriorHPositionArray()
		{
			uint ExteriorVertices = ClipmapVertices + 4;
			ushort ExteriorkSubdivs = (ushort)(ExteriorVertices - 1);

			// Create position array buffer
			ArrayBufferObject<Vertex2f> exteriorHPosition = new ArrayBufferObject<Vertex2f>(BufferObjectHint.StaticCpuDraw);

			exteriorHPosition.Create((uint)(ExteriorVertices * 2));
			exteriorHPosition.Map();

			float xPositionStep = 1.0f / ExteriorkSubdivs;
			uint positionIndex = 0;

			for (float y = 0.0f; y <= 1.0f; y += 1.0f) {
				float x = 0.0f;

				for (int i = 0; i < ExteriorVertices; i++, x += xPositionStep, positionIndex++) {
					Debug.Assert(positionIndex < exteriorHPosition.ClientItemCount);
					exteriorHPosition.Set(new Vertex2f((float)x, y), positionIndex);
				}
			}
			exteriorHPosition.Unmap();
			Debug.Assert(positionIndex == exteriorHPosition.ClientItemCount);

			return (exteriorHPosition);
		}

		private ElementBufferObject<ushort> CreateExteriorHElementArray()
		{
			// Create elements indices
			ElementBufferObject<ushort> exteriorHIndices = new ElementBufferObject<ushort>(BufferObjectHint.StaticCpuDraw);
			List<ushort> exteriorHElements = new List<ushort>();

			exteriorHIndices.RestartIndexEnabled = false; // Only 1 strip, primitive restart not required

			exteriorHElements.Add(0);

			for (ushort x = 0; x < ExteriorSubdivs; x++) {
				exteriorHElements.Add((ushort)(x + ExteriorSubdivs + 1));
				exteriorHElements.Add((ushort)(x + 1));
			}
			exteriorHElements.Add((ushort)(ExteriorVertices * 2 - 1));

			exteriorHIndices.Create(exteriorHElements.ToArray());

			return (exteriorHIndices);
		}

		private ArrayBufferObject<Vertex2f> CreateExteriorVPositionArray()
		{
			uint ExteriorVertices = ClipmapVertices + 4;
			ushort ExteriorkSubdivs = (ushort)(ExteriorVertices - 1);

			ArrayBufferObject<Vertex2f> exteriorVPosition = new ArrayBufferObject<Vertex2f>(BufferObjectHint.StaticCpuDraw);

			exteriorVPosition.Create((uint)((ClipmapVertices + 4) * 2));
			exteriorVPosition.Map();

			float yPositionStep = 1.0f / ExteriorkSubdivs;
			uint positionIndex = 0;

			for (float x = 0.0f; x <= 1.0f; x += 1.0f) {
				float y = 0.0f;

				for (int i = 0; i < ExteriorVertices; i++, y += yPositionStep, positionIndex++) {
					Debug.Assert(positionIndex < exteriorVPosition.ClientItemCount);
					exteriorVPosition.Set(new Vertex2f((float)x, y), positionIndex);
				}
			}
			exteriorVPosition.Unmap();
			Debug.Assert(positionIndex == exteriorVPosition.ClientItemCount);

			return (exteriorVPosition);
		}

		private ElementBufferObject<ushort> CreateExteriorVElementArray()
		{
			ElementBufferObject<ushort> exteriorVIndices = new ElementBufferObject<ushort>(BufferObjectHint.StaticCpuDraw);
			List<ushort> exteriorVElements = new List<ushort>();

			exteriorVIndices.RestartIndexEnabled = false; // Only 1 strip, primitive restart not required

			exteriorVElements.Add(0);

			for (ushort x = 0; x < ExteriorSubdivs; x++) {
				exteriorVElements.Add((ushort)(x + ExteriorSubdivs + 1));
				exteriorVElements.Add((ushort)(x + 1));
			}
			exteriorVElements.Add((ushort)(ExteriorVertices * 2 - 1));

			exteriorVIndices.Create(exteriorVElements.ToArray());

			return (exteriorVIndices);
		}

		private VertexArrayObject CreateVertexArrays(ArrayBufferObjectBase positions, ArrayBufferObjectBase instances, ElementBufferObject indices, uint offset, uint count)
		{
			VertexArrayObject vertexArray = new VertexArrayObject();

			// Reuse position array buffer
			vertexArray.SetArray(positions, VertexArraySemantic.Position);

			vertexArray.SetInstancedArray(instances, 0, 1, "hal_BlockOffset", null);
			vertexArray.SetInstancedArray(instances, 1, 1, "hal_MapOffset", null);
			vertexArray.SetInstancedArray(instances, 2, 1, "hal_Lod", null);
			vertexArray.SetInstancedArray(instances, 3, 1, "hal_BlockColor", null);

			// Reuse indices array buffer, but limiting to 2 triangle strips
			vertexArray.SetElementArray(PrimitiveType.TriangleStrip, indices, offset, count);

			return (vertexArray);
		}

		private void GenerateLevelBlocks()
		{
			ColorRGBAF ColorEven = new ColorRGBAF(0.5f, 0.5f, 0.5f);
			ColorRGBAF ColorOdd = new ColorRGBAF(0.7f, 0.7f, 0.7f);

			int semiClipmapSize = (int)ClipmapSubdivs / 2;
			int xBlock, yBlock;

			for (ushort level = 0; level < ClipmapLevels; level++) {
				// Line 1
				yBlock = -semiClipmapSize;
				// Line 1 - 2 left
				xBlock = -semiClipmapSize;
				for (int i = 0; i < 2; i++, xBlock += (int)BlockSubdivs)
					_InstancesClipmapBlock.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, (i % 2) == 0 ? ColorEven : ColorOdd));
				// Line 1 - 2 right
				xBlock = +semiClipmapSize - (int)BlockSubdivs * 2;
				for (int i = 0; i < 2; i++, xBlock += (int)BlockSubdivs)
					_InstancesClipmapBlock.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, (i % 2) == 0 ? ColorEven : ColorOdd));

				// Line 2
				yBlock += (int)(BlockVertices - 1);
				// Line 2 - 1 left
				xBlock = -semiClipmapSize;
				_InstancesClipmapBlock.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit));
				// Bottom right
				xBlock = +semiClipmapSize - (int)BlockSubdivs;
				_InstancesClipmapBlock.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit));

				// Line 3
				yBlock = +semiClipmapSize - (int)BlockSubdivs * 2;
				// Line 3 - 1 left
				xBlock = -semiClipmapSize;
				_InstancesClipmapBlock.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit));
				// Line 3 - 1 right
				xBlock = +semiClipmapSize - (int)BlockSubdivs;
				_InstancesClipmapBlock.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit));

				// Line 4
				yBlock = +semiClipmapSize - (int)BlockSubdivs;
				// Line 4 - 2 left
				xBlock = -semiClipmapSize;
				for (int i = 0; i < 2; i++, xBlock += (int)BlockSubdivs)
					_InstancesClipmapBlock.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, (i % 2) == 0 ? ColorEven : ColorOdd));
				// Line 4 - 2 right
				xBlock = +semiClipmapSize - (int)BlockSubdivs * 2;
				for (int i = 0; i < 2; i++, xBlock += (int)BlockSubdivs)
					_InstancesClipmapBlock.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, (i % 2) == 0 ? ColorEven : ColorOdd));
			}
		}

		private void GenerateRingFixInstancesH()
		{
			ColorRGBAF RingFixColor = new ColorRGBAF(1.0f, 0.0f, 1.0f);

			int semiClipmapSize = (int)ClipmapSubdivs / 2;
			int xBlock, yBlock;

			for (ushort level = 0; level < ClipmapLevels; level++) {
				ClipmapBlockInstance clipmapBlockInstance;

				xBlock = -semiClipmapSize;
				yBlock = -1;
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, RingFixColor);
				_InstancesRingFixH.Add(clipmapBlockInstance);

				xBlock = (int)(+semiClipmapSize - BlockSubdivs);
				yBlock = -1;
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, RingFixColor);
				_InstancesRingFixH.Add(clipmapBlockInstance);
			}
		}

		private void GenerateRingFixInstancesV()
		{
			ColorRGBAF RingFixColor = new ColorRGBAF(1.0f, 0.0f, 1.0f);

			int semiClipmapSize = (int)ClipmapSubdivs / 2;
			int xBlock, yBlock;

			for (ushort level = 0; level < ClipmapLevels; level++) {
				ClipmapBlockInstance clipmapBlockInstance;

				xBlock = -1;
				yBlock = -semiClipmapSize;
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, RingFixColor);
				_InstancesRingFixV.Add(clipmapBlockInstance);

				xBlock = -1;
				yBlock = (int)(+semiClipmapSize - BlockSubdivs);
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, RingFixColor);
				_InstancesRingFixV.Add(clipmapBlockInstance);
			}
		}

		private void GenerateExteriorInstancesH()
		{
			ColorRGBAF ExteriorColor = new ColorRGBAF(1.0f, 0.5f, 0.5f);
			uint ExteriorVertices = ClipmapVertices + 4;
			ushort ExteriorkSubdivs = (ushort)(ExteriorVertices - 1);

			int semiClipmapSize = (int)ClipmapSubdivs / 2;
			int xBlock, yBlock;

			for (ushort level = 0; level < ClipmapLevels - 1; level++) {
				ClipmapBlockInstance clipmapBlockInstance;

				xBlock = -semiClipmapSize - 2;
				yBlock = -semiClipmapSize - 1;
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, ExteriorVertices, 2, (int)xBlock, (int)yBlock, level, BlockQuadUnit, ExteriorColor);
				clipmapBlockInstance.IncTextureLod(ClipmapVertices);
				_InstancesExteriorH.Add(clipmapBlockInstance);

				xBlock = -semiClipmapSize - 2;
				yBlock = -semiClipmapSize - 2;
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, ExteriorVertices, 2, (int)xBlock, (int)yBlock, level, BlockQuadUnit, ExteriorColor);
				clipmapBlockInstance.IncTextureLod(ClipmapVertices);
				_InstancesExteriorH.Add(clipmapBlockInstance);

				xBlock = -semiClipmapSize - 2;
				yBlock = +semiClipmapSize;
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, ExteriorVertices, 2, (int)xBlock, (int)yBlock, level, BlockQuadUnit, ExteriorColor);
				clipmapBlockInstance.IncTextureLod(ClipmapVertices);
				_InstancesExteriorH.Add(clipmapBlockInstance);

				xBlock = -semiClipmapSize - 2;
				yBlock = +semiClipmapSize + 1;
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, ExteriorVertices, 2, (int)xBlock, (int)yBlock, level, BlockQuadUnit, ExteriorColor);
				clipmapBlockInstance.IncTextureLod(ClipmapVertices);
				_InstancesExteriorH.Add(clipmapBlockInstance);
			}
		}

		private void GenerateExteriorInstancesV()
		{
			ColorRGBAF ExteriorColor = new ColorRGBAF(1.0f, 0.5f, 0.5f);
			uint ExteriorVertices = ClipmapVertices + 4;
			ushort ExteriorkSubdivs = (ushort)(ExteriorVertices - 1);

			int semiClipmapSize = (int)ClipmapSubdivs / 2;
			int xBlock, yBlock;

			for (ushort level = 0; level < ClipmapLevels - 1; level++) {
				ClipmapBlockInstance clipmapBlockInstance;

				xBlock = -semiClipmapSize - 1;
				yBlock = -semiClipmapSize - 2;
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, 2, ExteriorVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, ExteriorColor);
				clipmapBlockInstance.IncTextureLod(ClipmapVertices);
				_InstancesExteriorV.Add(clipmapBlockInstance);

				xBlock = -semiClipmapSize - 2;
				yBlock = -semiClipmapSize - 2;
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, 2, ExteriorVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, ExteriorColor);
				clipmapBlockInstance.IncTextureLod(ClipmapVertices);
				_InstancesExteriorV.Add(clipmapBlockInstance);

				xBlock = +semiClipmapSize;
				yBlock = -semiClipmapSize - 2;
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, 2, ExteriorVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, ExteriorColor);
				clipmapBlockInstance.IncTextureLod(ClipmapVertices);
				_InstancesExteriorV.Add(clipmapBlockInstance);

				xBlock = +semiClipmapSize + 1;
				yBlock = -semiClipmapSize - 2;
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, 2, ExteriorVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, ExteriorColor);
				clipmapBlockInstance.IncTextureLod(ClipmapVertices);
				_InstancesExteriorV.Add(clipmapBlockInstance);
			}
		}

		/// <summary>
		/// Generate a <see cref="List{ClipmapBlockInstance}"/> defining instances to cap the clipmap level.
		/// </summary>
		/// <param name="level">
		/// The <see cref="UInt32"/> that specify the level of the cap.
		/// </param>
		/// <returns>
		/// It returns a <see cref="List{ClipmapBlockInstance}"/> defining instances parameters used for capping
		/// the geometry clipmap cap to be draw with <see cref="_BlockArray"/>.
		/// </returns>
		private List<ClipmapBlockInstance> GenerateLevelBlocksCap(uint level)
		{
			List<ClipmapBlockInstance> capBlocks = new List<ClipmapBlockInstance>();

			ushort BlockSubdivs = (ushort)(BlockVertices - 1);
			int offsetx = -1, offsety = -1;

			int semiClipmapSize = (int)ClipmapSubdivs / 2;

			capBlocks.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)offsetx, (int)offsety, level, BlockQuadUnit));
			capBlocks.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)-BlockSubdivs + offsetx, (int)offsety, level, BlockQuadUnit));
			capBlocks.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)offsetx, (int)-BlockSubdivs + offsety, level, BlockQuadUnit));
			capBlocks.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)-BlockSubdivs + offsetx, (int)-BlockSubdivs + offsety, level, BlockQuadUnit));

			return (capBlocks);
		}

		private List<ClipmapBlockInstance> GenerateLevelBlocksCapFixH(uint level)
		{
			List<ClipmapBlockInstance> capBlocks = new List<ClipmapBlockInstance>();

			capBlocks.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)-BlockSubdivs - 1, (int)BlockSubdivs - 1, level, BlockQuadUnit));
			capBlocks.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, -1, (int)BlockSubdivs - 1, level, BlockQuadUnit));
			capBlocks.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, +1, (int)BlockSubdivs - 1, level, BlockQuadUnit));

			return (capBlocks);
		}

		private List<ClipmapBlockInstance> GenerateLevelBlocksCapFixV(uint level)
		{
			List<ClipmapBlockInstance> capBlocks = new List<ClipmapBlockInstance>();

			capBlocks.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)BlockSubdivs - 1, -(int)BlockSubdivs - 1, level, BlockQuadUnit));
			capBlocks.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)BlockSubdivs - 1, -1, level, BlockQuadUnit));

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
		private ArrayBufferObjectInterleaved<ClipmapBlockInstance> _ArrayRingFixHInstances, _ArrayRingFixVInstances;

		/// <summary>
		/// Array buffer object defining instances attributes.
		/// </summary>
		private ArrayBufferObjectInterleaved<ClipmapBlockInstance> _ArrayExteriorHInstances, _ArrayExteriorVInstances;

		/// <summary>
		/// Vertex arrays for drawing 
		/// </summary>
		private VertexArrayObject _BlockArray;

		/// <summary>
		/// Vertex arrays for drawing ring fix (horizontal and vertical patches).
		/// </summary>
		private VertexArrayObject _RingFixArrayH, _RingFixArrayV;

		/// <summary>
		/// Vertex arrays for drawing level exterior (horizontal and vertical patches).
		/// </summary>
		private VertexArrayObject _LevelExteriorH, _LevelExteriorV;

		/// <summary>
		/// Vertex arrays for drawing level cap exterior.
		/// </summary>
		private VertexArrayObject _LevelCapExterior;

		/// <summary>
		/// Elevation texture.
		/// </summary>
		private TextureArray2d _ElevationTexture;

		/// <summary>
		/// Elevation banding texture.
		/// </summary>
		private Texture1d _ElevationBandingTexture;

		#endregion

		#region SceneGraphObject Overrides

		/// <summary>
		/// Update this SceneGraphObject instance.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="ctxScene">
		/// The <see cref="SceneGraphContext"/> used for drawing.
		/// </param>
		protected override void UpdateThis(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			if (ctxScene == null)
				throw new ArgumentNullException("ctxScene");
			if (ctxScene.CurrentView == null)
				throw new ArgumentException("no view defined",  "ctxScene");

			Vertex3d currentPosition = ctxScene.CurrentView.LocalModel.Position;

			// Compute visible clipmap levels
			const float HeightGain = 2.5f;

			float viewerHeight = currentPosition.Y;
			float clipmap0Size = BlockQuadUnit * ClipmapSubdivs;

			_CurrentLevel = 0;
			while (clipmap0Size * Math.Pow(2.0, _CurrentLevel) < viewerHeight * HeightGain)
				_CurrentLevel++;

			// Update  grid offsets
			UpdateGridOffsets(ctx, ctxScene);
			// Update elevation maps
			UpdateTerrainElevationTextures(ctx, ctxScene);
		}

		/// <summary>
		/// Draw this SceneGraphObject instance.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="ctxScene">
		/// The <see cref="SceneGraphContext"/> used for drawing.
		/// </param>
		protected override void DrawThis(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			if (ctxScene == null)
				throw new ArgumentNullException("ctxScene");

			CheckCurrentContext(ctx);

			ctxScene.GraphicsStateStack.Current.Apply(ctx, _GeometryClipmapProgram);

			ctx.Bind(_GeometryClipmapProgram);

			_GeometryClipmapProgram.ResetTextureUnits();
			_GeometryClipmapProgram.SetUniform(ctx, "hal_ElevationMap", _ElevationTexture);
			_GeometryClipmapProgram.SetUniform(ctx, "hal_ElevationMapSize", (float)_ElevationTexture.Width);
			_GeometryClipmapProgram.SetUniform(ctx, "hal_GridUnitScale", BlockQuadUnit);
#if POSITION_CORRECTION
			_GeometryClipmapProgram.SetUniform(ctx, "hal_GridOffset", _GridOffsets);
#endif
			if (_GeometryClipmapProgram.IsActiveUniform("hal_ElevationBanding"))
				_GeometryClipmapProgram.SetUniform(ctx, "hal_ElevationBanding", _ElevationBandingTexture);

			// Instance culling
			List<ClipmapBlockInstance> instancesClipmapBlock = new List<ClipmapBlockInstance>(_InstancesClipmapBlock);
			List<ClipmapBlockInstance> instancesRingFixH = new List<ClipmapBlockInstance>(_InstancesRingFixH);
			List<ClipmapBlockInstance> instancesRingFixV = new List<ClipmapBlockInstance>(_InstancesRingFixV);

			#region Cap Instances

			// Base LOD cap instances
#if CLIPMAP_CAP
#if CULLING_CLIPMAP_CAP
			// Include cap in clipmap blocks
			if (_CurrentLevel < ClipmapLevels) {
				instancesClipmapBlock.AddRange(GenerateLevelBlocksCap(_CurrentLevel));
				instancesRingFixH.AddRange(GenerateLevelBlocksCapFixH(_CurrentLevel));
				instancesRingFixV.AddRange(GenerateLevelBlocksCapFixV(_CurrentLevel));
			}
#else
			// Include cap in clipmap blocks
			instancesClipmapBlock.AddRange(GenerateLevelBlocksCap(0));
			instancesRingFixH.AddRange(GenerateLevelBlocksCapFixH(0));
			instancesRingFixV.AddRange(GenerateLevelBlocksCapFixV(0));
#endif
#endif

			#endregion

			//Debug.Assert(instancesClipmapBlock.TrueForAll(delegate (ClipmapBlockInstance item) {
			//	return
			//		(item.TexCoordMin.x >= 0.0f && item.TexCoordMin.x <= 1.0f && item.TexCoordMin.y >= 0.0f && item.TexCoordMin.y <= 1.0f) &&
			//		(item.TexCoordMax.x >= 0.0f && item.TexCoordMax.x <= 1.0f && item.TexCoordMax.y >= 0.0f && item.TexCoordMax.y <= 1.0f);
			//}));

			#region Cull Instances

			// Compute clipping planes
			IMatrix4x4 matrixProjection = ctxScene.Scene.LocalProjection;
			IModelMatrix matrixModelView = ctxScene.Scene.LocalModel;
			IMatrix4x4 matrixMVP = matrixProjection.Multiply(matrixModelView);

			_ClippingPlanes = Plane.GetFrustumPlanes(matrixMVP);

			// Cull instances
			uint instancesClipmapBlockCount = CullInstances(ctx, ctxScene, instancesClipmapBlock, _ArrayClipmapBlockInstances);
			uint instancesRingFixHCount = CullInstances(ctx, ctxScene, instancesRingFixH, _ArrayRingFixHInstances);
			uint instancesRingFixVCount = CullInstances(ctx, ctxScene, instancesRingFixV, _ArrayRingFixVInstances);
			uint instancesExteriorHCount = CullInstances(ctx, ctxScene, _InstancesExteriorH, _ArrayExteriorHInstances);
			uint instancesExteriorVCount = CullInstances(ctx, ctxScene, _InstancesExteriorV, _ArrayExteriorVInstances);
			uint instancesCount =
				(uint)instancesClipmapBlock.Count +
				(uint)instancesRingFixH.Count + (uint)instancesRingFixV.Count +
				(uint)_InstancesExteriorH.Count + (uint)_InstancesExteriorV.Count;
			uint culledInstancesCount =
				instancesClipmapBlockCount +
				instancesRingFixHCount + instancesRingFixVCount +
				instancesExteriorHCount + instancesExteriorVCount;

			// Trace.TraceInformation("Drawing {0}/{1} instances.", culledInstancesCount, instancesCount);

			#endregion

			// Draw clipmap blocks using instanced rendering

			_ElevationTexture.MinFilter = _ElevationTexture.MagFilter = Texture.Filter.Nearest;
			_ElevationTexture.ApplyParameters(ctx);

			if (instancesClipmapBlockCount > 0)
				_BlockArray.DrawInstanced(ctx, _GeometryClipmapProgram, instancesClipmapBlockCount);
			if (instancesRingFixHCount > 0)
				_RingFixArrayH.DrawInstanced(ctx, _GeometryClipmapProgram, instancesRingFixHCount);
			if (instancesRingFixVCount > 0)
				_RingFixArrayV.DrawInstanced(ctx, _GeometryClipmapProgram, instancesRingFixVCount);

			_ElevationTexture.MinFilter = _ElevationTexture.MagFilter = Texture.Filter.Linear;
			_ElevationTexture.ApplyParameters(ctx);

			if (instancesExteriorHCount > 0)
				_LevelExteriorH.DrawInstanced(ctx, _GeometryClipmapProgram, instancesExteriorHCount);
			if (instancesExteriorVCount > 0)
				_LevelExteriorV.DrawInstanced(ctx, _GeometryClipmapProgram, instancesExteriorVCount);
		}

		private void UpdateGridOffsets(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			if (PositionCorrection == false)
				return;

			Vertex2f[] gridOffsets = new Vertex2f[ClipmapLevels];
			Vertex3d currentPosition = ctxScene.CurrentView.LocalModel.Position;
			Vertex2d gridOffset = new Vertex2d(currentPosition.x, currentPosition.z);

			for (int i = 0; i < ClipmapLevels; i++) {
				_ClipmapLevels[i].UpdateGridPosition(gridOffset, BlockQuadUnit);
				gridOffsets[i] = _ClipmapLevels[i].GridPosition;
			}

#if DEBUG
			bool[] gridOffsetsUpdated = new bool[ClipmapLevels];

			if (_GridOffsets != null) {
				for (int i = 0; i < ClipmapLevels; i++)
					gridOffsetsUpdated[i] = _GridOffsets[i] != gridOffsets[i];
			} else {
				for (int i = 0; i < ClipmapLevels; i++)
					gridOffsetsUpdated[i] = true;
			}
			_GridOffsetsUpdated = gridOffsetsUpdated;
#endif

			// Store current offsets
			_GridOffsets = gridOffsets;
		}

		/// <summary>
		/// Filter an array of <see cref="ClipmapBlockInstance"/> and updates the specifies array buffer.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for updating <paramref name="arrayBuffer"/>.
		/// </param>
		/// <param name="instances">
		/// The <see cref="List{ClipmapBlockInstance}"/> to be filtered.
		/// </param>
		/// <param name="arrayBuffer">
		/// The <see cref="ArrayBufferObjectInterleaved{ClipmapBlockInstance}"/> to be updated.
		/// </param>
		/// <returns>
		/// It returns the number of items of <paramref name="instances"/> filtered.
		/// </returns>
		private uint CullInstances(GraphicsContext ctx, SceneGraphContext ctxScene, List<ClipmapBlockInstance> instances, ArrayBufferObjectInterleaved<ClipmapBlockInstance> arrayBuffer)
		{
			List<ClipmapBlockInstance> cull = instances;

#if CULLING_CLIPMAP_CAP
			// Filter by level
			// Exclude finer levels depending on viewer height
			cull = instances.FindAll(delegate (ClipmapBlockInstance item) {
				return (item.Lod.Y >= _CurrentLevel);
			});
#endif

#if CULLING_CLIPMAP_BLOCKS
			// Filter using bounding volumes
			cull = cull.FindAll(delegate (ClipmapBlockInstance item) {
				return (item.GetBoundingVolume(_GridOffsets).IsClipped(_ClippingPlanes) == false);
			});
#endif

			// Update instance arrays
			if (cull.Count > 0)
				arrayBuffer.Update(ctx, cull.ToArray());

			return ((uint)cull.Count);
		}

		/// <summary>
		/// Temporary field used by <see cref="Draw"/> and <see cref="DrawThis"/>.
		/// </summary>
		private uint _CurrentLevel;

		/// <summary>
		/// Clipping planes for the current geometry clipmap.
		/// </summary>
		private IEnumerable<Plane> _ClippingPlanes;

		/// <summary>
		/// Actual position offsets applied to
		/// </summary>
		private Vertex2f[] _GridOffsets;

#if DEBUG
		/// <summary>
		/// 
		/// </summary>
		private bool[] _GridOffsetsUpdated;
#endif

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="Boolean"/> indicating whether this method is called by <see cref="Dispose()"/>. If it is false,
		/// this method is called by the finalizer.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			// Base implementation
			base.Dispose(disposing);

			// Dispose previous terrain elevation sources
			for (ushort i = 0; i < ClipmapLevels; i++)
				if (_TerrainElevationSources[i] != null)
					_TerrainElevationSources[i].Dispose();
		}

		#endregion
	}
}
