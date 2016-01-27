using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenGL;

namespace HelloNewton
{
	public struct NewtonVertex
	{
		public Vertex3f Position;

		public Vertex3f Speed;

		public Vertex3f Acceleration;

		public float Mass;
	}
}
