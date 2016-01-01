
// Copyright (C) 2012-2015 Luca Piccioni
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

namespace OpenGL
{
	/// <summary>
	/// Disposable interface extended to support graphics resources disposition.
	/// </summary>
	public interface IGraphicsDisposable : IDisposable
	{
		/// <summary>
		/// Dispose graphics resources using the underlying <see cref="GraphicsContext"/>.
		/// </summary>
		/// <param name='ctx'>
		/// A <see cref="GraphicsContext"/> which have access to the <see cref="IRenderDisposable"/> graphics resources.
		/// </param>
		/// <remarks>
		/// <para>
		/// The instance shall be considered disposed as it were called <see cref="IDisposable.Dispose"/>, but in addition
		/// this method will release this instance resources.
		/// </para>
		/// <para>
		/// The <see cref="Dispose()"/> method should try to release the underlying resources by getting the optional graphics
		/// context current on the calling thread.
		/// </para>
		/// </remarks>
		void Dispose(GraphicsContext ctx);
	}
}

