
namespace OpenGL.Collections
{
	/// <summary>
	/// Node collected by a <see cref="QuadTree"/>.
	/// </summary>
	public interface IQuadTreeNode
	{
		/// <summary>
		/// Get the area covered by the IQuadTreeNode.
		/// </summary>
		QuadTreeArea NodeArea { get; }

		/// <summary>
		/// Get the resolution (on both axes) of the node in the specified area, in units per pixel.
		/// </summary>
		QuadTreeCoord NodeResolution { get; }
	}
}
