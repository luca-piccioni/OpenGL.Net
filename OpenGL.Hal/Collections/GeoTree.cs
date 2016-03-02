
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
using System.Diagnostics;

namespace OpenGL.Collections
{
	/// <summary>
	/// Quad-Tree collection specialized for indexing geographic information efficiently.
	/// </summary>
	public class GeoTree<T> where T : IGeoTreeNode
	{
		#region Constructors

		/// <summary>
		/// Construct a GeoTree.
		/// </summary>
		/// <param name="maxDepth">
		/// A <see cref="UInt32"/> that specify how deep should the geographic information indexed within
		/// this collection.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="maxDepth"/> is not an allowed value.
		/// </exception>
		public GeoTree(uint maxDepth)
		{
			if (maxDepth == 0)
				throw new ArgumentException("maxDepth");

			MaxDepth = maxDepth;
			_Root = new GeoTreePartition(this, Area);
		}

		#endregion

		#region Properties

		/// <summary>
		/// The geographic area partitioned by this GeoTree.
		/// </summary>
		private readonly GeoTreeArea Area =  new GeoTreeArea(Vertex2d.Zero, new Vertex2d(360.0, 180.0));

		/// <summary>
		/// Maximum depth of this GeoTree.
		/// </summary>
		public readonly uint MaxDepth;

		#endregion

		#region Tree Partitioning

		/// <summary>
		/// The node of the GeoTree.
		/// </summary>
		[DebuggerDisplay("Partition: NodeArea={Area}")]
		protected class GeoTreePartition
		{
			#region Constructors

			/// <summary>
			/// Construct a GeoTree node, defining the underlying area.
			/// </summary>
			/// <param name="tree">
			/// The <see cref="GeoTree{T}"/> which this Node belongs to.
			/// </param>
			/// <param name="area">
			/// A <see cref="GeoTreeArea"/>
			/// </param>
			public GeoTreePartition(GeoTree<T> tree, GeoTreeArea area)
			{
				if (tree == null)
					throw new ArgumentNullException("tree");

				Tree = tree;
				Area = area;

				mPartition[0] = CreatePartitionLL();
				mPartition[1] = CreatePartitionLR();
				mPartition[2] = CreatePartitionUL();
				mPartition[3] = CreatePartitionUR();
			}

			#endregion

			#region Properties

			/// <summary>
			/// The GeoTree which this node belongs to.
			/// </summary>
			public readonly GeoTree<T> Tree;

			/// <summary>
			/// The geographic area covered by this GeoTreePartition.
			/// </summary>
			public readonly GeoTreeArea Area;

			/// <summary>
			/// Get the depth of this Node within the GeoTree structure.
			/// </summary>
			public uint Depth
			{
				get
				{
					uint divisor = (uint)(Tree.Area.Size.X / Area.Size.X);

					return ((uint)Math.Log(divisor, 2.0));
				}
			}

			#endregion

			#region Space Partitioning

			/// <summary>
			/// Insert a <typeparamref name="T"/>.
			/// </summary>
			/// <param name="item">
			/// The <typeparamref name="T"/> to be inserted in the GeoTree.
			/// </param>
			public virtual void Insert(T item)
			{
				if (item == null)
					throw new ArgumentNullException("item");

				Debug.Assert(Area.Intersect(item.Area));

				foreach (GeoTreePartition spacePartition in mPartition) {
					if ((spacePartition != null) && (spacePartition.Area.Intersect(item.Area)))
						spacePartition.Insert(item);
				}
			}

			/// <summary>
			/// Select a list of <typeparamref name="T"/> which area intersect with the specified one.
			/// </summary>
			/// <param name="area">
			/// A <see cref="GeoTreeArea"/> which delimits the <typeparamref name="T"/> instances to be selected.
			/// </param>
			/// <param name="selectedNodes">
			/// A <see cref="Dictionary{Guid,T}"/> that collectes the selected nodes.
			/// </param>
			public virtual void Select(GeoTreeArea area, Dictionary<Guid, T> selectedNodes)
			{
				foreach (GeoTreePartition spacePartition in mPartition) {
					if ((spacePartition != null) && (spacePartition.Area.Intersect(area)))
						spacePartition.Select(area, selectedNodes);
				}
			}

			/// <summary>
			/// Get the nested node partitioning the area cover
			/// </summary>
			/// <param name="coord">
			/// A <see cref="Vertex2d"/> that specified the space coordinate used for selecting the nested node.
			/// </param>
			/// <returns>
			/// It returns the <see cref="GeoTreePartition"/> that cover the coordinate <paramref name="coord"/>.
			/// </returns>
			public GeoTreePartition GetPartition(Vertex2d coord)
			{
				if (mPartition == null)
					throw new InvalidOperationException("can't partition a leaf node");

				GeoTreePartition spacePartitionNode;

				if (coord.Y < Area.Centre.Y) {
					if (coord.X < Area.Centre.X) {
						// Lower/Left
						if (mPartition[0] == null)
							mPartition[0] = CreatePartitionLL();
						spacePartitionNode = mPartition[0];
					} else {
						// Lower/Right
						if (mPartition[1] == null)
							mPartition[1] = CreatePartitionLR();
						spacePartitionNode = mPartition[1];
					}
				} else {
					if (coord.X < Area.Centre.X) {
						// Upper/Left
						if (mPartition[2] == null)
							mPartition[2] = CreatePartitionUL();
						spacePartitionNode = mPartition[2];
					} else {
						// Upper/Right
						if (mPartition[3] == null)
							mPartition[3] = CreatePartitionUR();
						spacePartitionNode = mPartition[3];
					}
				}

				Debug.Assert(spacePartitionNode.Area.Intersect(coord));
				return (spacePartitionNode);
			}

			private GeoTreePartition CreatePartitionLL()
			{
				Vertex2d size2 = Area.Size / 2.0, size4 = Area.Size / 4.0;
					
				return (CreatePartitionNode(new GeoTreeArea(Area.Centre + new Vertex2d(-size4.X, -size4.Y), size2)));
			}

			private GeoTreePartition CreatePartitionLR()
			{
				Vertex2d size2 = Area.Size / 2.0, size4 = Area.Size / 4.0;
							
				return (CreatePartitionNode(new GeoTreeArea(Area.Centre + new Vertex2d(+size4.X, -size4.Y), size2)));
			}

			private GeoTreePartition CreatePartitionUL()
			{
				Vertex2d size2 = Area.Size / 2.0, size4 = Area.Size / 4.0;
							
				return (CreatePartitionNode(new GeoTreeArea(Area.Centre + new Vertex2d(-size4.X, +size4.Y), size2)));
			}

			private GeoTreePartition CreatePartitionUR()
			{
				Vertex2d size2 = Area.Size / 2.0, size4 = Area.Size / 4.0;
							
				return (CreatePartitionNode(new GeoTreeArea(Area.Centre + new Vertex2d(+size4.X, +size4.Y), size2)));
			}

			/// <summary>
			/// Method used for creating partition nodes lazily.
			/// </summary>
			/// <param name="area">
			/// The <see cref="Vertex2d"/> convered by the returned Node.
			/// </param>
			/// <returns>
			/// It returns the <see cref="GeoTreePartition"/> covering the area <paramref name="area"/>.
			/// </returns>
			private GeoTreePartition CreatePartitionNode(GeoTreeArea area)
			{
				if        (Depth < Tree.MaxDepth - 1) {
					return (Tree.CreateNode(area));
				} else if (Depth == Tree.MaxDepth - 1) {
					return (Tree.CreateLeafNode(area));
				} else
					return (null);
			}

			/// <summary>
			/// Node partitioning the space defined by <see cref="Area"/>.
			/// </summary>
			private readonly GeoTreePartition[] mPartition = new GeoTreePartition[4];

			#endregion
		}

		/// <summary>
		/// Create a GeoTree node.
		/// </summary>
		/// <param name="area">
		/// The <see cref="Vertex2d"/> that specify the geographic coverage for the returned node.
		/// </param>
		/// <returns>
		/// It returns a <see cref="GeoTreePartition"/> belonging to this GeoTree.
		/// </returns>
		protected virtual GeoTreePartition CreateNode(GeoTreeArea area)
		{
			return (new GeoTreePartition(this, area));
		}

		#endregion

		#region Tree Leafs

		/// <summary>
		/// The leaf node of the GeoTree.
		/// </summary>
		[DebuggerDisplay("LeafNode: NodeArea={NodeArea} ItemsCount={Items.Count}")]
		protected class LeafNode : GeoTreePartition
		{
			#region Constructors

			/// <summary>
			/// Construct a GeoTree node, defining the underlying area.
			/// </summary>
			/// <param name="tree">
			/// The <see cref="GeoTree{T}"/> which this Node belongs to.
			/// </param>
			/// <param name="area">
			/// A <see cref="GeoTreeArea"/>
			/// </param>
			public LeafNode(GeoTree<T> tree, GeoTreeArea area)
				: base(tree, area)
			{
				
			}

			#endregion

			#region Items Collection

			/// <summary>
			/// Items collected by this LeafNode.
			/// </summary>
			public readonly List<T> Items = new List<T>();

			#endregion

			#region Node Overrides

			/// <summary>
			/// Insert a <typeparamref name="T"/>.
			/// </summary>
			/// <param name="item">
			/// The <typeparamref name="T"/> to be inserted in the GeoTree.
			/// </param>
			public override void Insert(T item)
			{
				if (item == null)
					throw new ArgumentNullException("item");

				Debug.Assert(Area.Intersect(item.Area));
				Items.Add(item);
			}

			/// <summary>
			/// Select a list of <typeparamref name="T"/> which area intersect with the specified one.
			/// </summary>
			/// <param name="area">
			/// A <see cref="GeoTreeArea"/> which delimits the <typeparamref name="T"/> instances to be selected.
			/// </param>
			/// <param name="selectedNodes">
			/// A <see cref="Dictionary{Guid,T}"/> that collectes the selected nodes.
			/// </param>
			public override void Select(GeoTreeArea area, Dictionary<Guid, T> selectedNodes)
			{
				Debug.Assert(Area.Intersect(area));

				foreach (T item in Items) {
					// Node may not intersect with the area requested
					if (item.Area.Intersect(area) == false)
						continue;
					// Node may belongs to multiple leaf nodes
					if (selectedNodes.ContainsKey(item.Id) == false)
						selectedNodes.Add(item.Id, item);
				}
			}

			#endregion
		}

		/// <summary>
		/// Create a GeoTree leaf node.
		/// </summary>
		/// <returns>
		/// It returns a <see cref="LeafNode"/> belonging to this GeoTree.
		/// </returns>
		protected virtual LeafNode CreateLeafNode(GeoTreeArea area)
		{
			return (new LeafNode(this, area));
		}

		#endregion

		#region Collection

		/// <summary>
		/// Insert a range of <typeparamref name="T"/>.
		/// </summary>
		/// <param name="item">
		/// The <see cref="IEnumerable{T}"/> to be inserted in the GeoTree.
		/// </param>
		public void Insert(IEnumerable<T> items)
		{
			if (items == null)
				throw new ArgumentNullException("items");

			foreach (T item in items)
				Insert(item);
		}

		/// <summary>
		/// Insert a <typeparamref name="T"/>.
		/// </summary>
		/// <param name="item">
		/// The <typeparamref name="T"/> to be inserted in the GeoTree.
		/// </param>
		public void Insert(T item)
		{
			if (item == null)
				throw new ArgumentNullException("item");

			_Root.Insert(item);
		}

		/// <summary>
		/// Select a list of <typeparamref name="T"/> which area intersect with the specified one.
		/// </summary>
		/// <param name="area">
		/// A <see cref="GeoTreeArea"/> which delimits the <typeparamref name="T"/> instances to be selected.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ICollection{T}"/> containing all <typeparamref name="T"/> instances intersecting
		/// with <paramref name="area"/>.
		/// </returns>
		public ICollection<T> Select(GeoTreeArea area)
		{
			Dictionary<Guid, T> selectedNodes = new Dictionary<Guid, T>();

			_Root.Select(area, selectedNodes);

			return (selectedNodes.Values);
		}

		/// <summary>
		/// The root of the tree.
		/// </summary>
		private readonly GeoTreePartition _Root;

		#endregion
	}
}
