using System;
using System.Collections.Generic;

namespace OpenGL.Collections
{
	/// <summary>
	/// Quadrilateral tree collection.
	/// </summary>
	/// <remarks>
	/// The implementation defines the following restrictions:
	/// - 
	/// </remarks>
	public sealed class QuadTree
	{
		#region Constructors

		/// <summary>
		/// 
		/// </summary>
		/// <param name="size"></param>
		/// <param name="maxDepth"></param>
		public QuadTree(QuadTreeArea area, uint maxDepth)
		{
			TreeSize = area.Size;
			MaxDepthAllowed = maxDepth;
			mRoot = new Node(this, area.Pivot, area.Size);
		}

		#endregion

		#region Properties

		/// <summary>
		/// The size of the space partitioned by this QuadTree.
		/// </summary>
		public readonly QuadTreeCoord TreeSize;

		/// <summary>
		/// The minimum size of the smallest space partitioned by this QuadTree.
		/// </summary>
		public QuadTreeCoord MinTreeSize
		{
			get { return (TreeSize / Math.Pow(2.0, MaxDepthAllowed)); }
		}

		/// <summary>
		/// The maximum depth allowed.
		/// </summary>
		public readonly uint MaxDepthAllowed;

		/// <summary>
		/// The maximum resolution allowed by the indexed node.
		/// </summary>
		public readonly uint MaxResolutionAllowed;

		#endregion

		#region Collection Management

		/// <summary>
		/// 
		/// </summary>
		private class Node
		{
			public Node(QuadTree tree, QuadTreeCoord coord, QuadTreeCoord size)
			{
				Tree = tree;
				PivotCoord = coord;
				NodeSize = size;

				if (NodeLevel < Tree.MaxDepthAllowed) {
					QuadTreeCoord size2 = size / 2.0;

					mSubNodes = new Node[] {
						new Node(tree, coord - new QuadTreeCoord(-size2.X, -size2.Y), size2),		// LL
						new Node(tree, coord - new QuadTreeCoord(+size2.X, -size2.Y), size2),		// LR
						new Node(tree, coord - new QuadTreeCoord(-size2.X, +size2.Y), size2),		// UL
						new Node(tree, coord - new QuadTreeCoord(+size2.X, +size2.Y), size2),		// UR
					};
				}
			}

			/// <summary>
			/// The QuadTree to which this node belongs.
			/// </summary>
			public readonly QuadTree Tree;

			/// <summary>
			/// Get the node pivot point.
			/// </summary>
			public readonly QuadTreeCoord PivotCoord;

			/// <summary>
			/// Get the node size.
			/// </summary>
			public readonly QuadTreeCoord NodeSize;

			/// <summary>
			/// The level of the Node within the QuadTree.
			/// </summary>
			public uint NodeLevel
			{
				get { return (uint)Math.Round(Tree.TreeSize.X / NodeSize.X, 0); }
			}

			/// <summary>
			/// Get whether this Node is a leaf node.
			/// </summary>
			public bool IsLeafNode
			{
				get { return (mSubNodes == null); }
			}

			public void AddSubNode(IQuadTreeNode node)
			{
				
			}

			/// <summary>
			/// Get the sub-node where a coordinate is
			/// </summary>
			/// <param name="coord"></param>
			/// <returns></returns>
			public Node GetSubNode(QuadTreeCoord coord)
			{
				if (IsLeafNode)
					throw new InvalidOperationException("leaf node");

				if (coord.Y < PivotCoord.Y) {
					if (coord.X < PivotCoord.X)
						return (mSubNodes[0]);
					else
						return (mSubNodes[1]);
				} else {
					if (coord.X < PivotCoord.X)
						return (mSubNodes[2]);
					else
						return (mSubNodes[3]);
				}
			}

			/// <summary>
			/// Subnodes partitioning the space defined for this node.
			/// </summary>
			private readonly Node[] mSubNodes;

			/// <summary>
			/// Items belonging to this node.
			/// </summary>
			public readonly List<IQuadTreeNode> Items = new List<IQuadTreeNode>();
		}

		/// <summary>
		/// The root node.
		/// </summary>
		private readonly Node mRoot;

		#endregion

		#region Tree Operations

		public void Add(IQuadTreeNode node)
		{
			
		}

		public void FindNodes(QuadTreeCoord coord)
		{
			
		}

		#endregion
	}
}
