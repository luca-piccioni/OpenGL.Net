
namespace OpenGL.Collections
{
	public struct QuadTreeArea
	{
		public QuadTreeArea(QuadTreeCoord pivot, QuadTreeCoord size)
		{
			Pivot = pivot;
			Size = size;
		}

		/// <summary>
		/// The coordinate of the center of the QuadTreeArea.
		/// </summary>
		public QuadTreeCoord Pivot;

		/// <summary>
		/// The extents of the QuadTreeArea.
		/// </summary>
		public QuadTreeCoord Size;
	}
}
