
namespace OpenGL.Collections
{
	public struct QuadTreeCoord
	{
		public QuadTreeCoord(double x, double y)
		{
			X = x;
			Y = y;
		}

		/// <summary>
		/// The horizontal value, in whatever units.
		/// </summary>
		public double X;

		/// <summary>
		/// The vertical value, in whatever units.
		/// </summary>
		public double Y;

		public static QuadTreeCoord operator +(QuadTreeCoord value, double factor)
		{
			return (new QuadTreeCoord(value.X + factor, value.Y + factor));
		}

		public static QuadTreeCoord operator -(QuadTreeCoord value, double factor)
		{
			return (new QuadTreeCoord(value.X - factor, value.Y - factor));
		}

		public static QuadTreeCoord operator -(QuadTreeCoord x, QuadTreeCoord y)
		{
			return (new QuadTreeCoord(x.X - y.X, x.Y - y.Y));
		}

		public static QuadTreeCoord operator *(QuadTreeCoord value, double factor)
		{
			return (new QuadTreeCoord(value.X * factor, value.Y * factor));
		}

		public static QuadTreeCoord operator /(QuadTreeCoord value, double factor)
		{
			return (new QuadTreeCoord(value.X / factor, value.Y / factor));
		}
	}
}
