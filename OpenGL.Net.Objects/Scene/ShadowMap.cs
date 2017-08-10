using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenGL.Objects.Scene
{
	/// <summary>
	/// Base class for shadow mapping.
	/// </summary>
	abstract class ShadowMap
	{
		#region Constructors

		protected ShadowMap(uint w, uint h)
		{
			Width = w;
			Height = h;
		}

		#endregion

		#region Information

		public readonly uint Width;

		public readonly uint Height;

		#endregion
	}
}
