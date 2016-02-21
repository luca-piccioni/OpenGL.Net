
// Copyright (C) 2016Luca Piccioni
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

namespace OpenGL.State
{
	/// <summary>
	/// Utility class for saving <see cref="GraphicsState"/> instances to be applied
	/// </summary>
	public sealed class GraphicsStateKeeper : IDisposable
	{
		#region Constructors

		/// <summary>
		/// Construct a GraphicsStateKeeper.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used to restore the states.
		/// </param>
		public GraphicsStateKeeper(GraphicsContext ctx)
		{
			GraphicsResource.CheckCurrentContext(ctx);

			// Temporarly store the graphics context for used at disposition
			_GraphicsContext = ctx;
		}

		#endregion

		#region State Keeping

		/// <summary>
		/// Keep the specified graphics state, identified using its identifier.
		/// </summary>
		/// <param name="graphicsStateId">
		/// A <see cref="String"/> that identify the graphics state to keep.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="graphicsStateId"/> is null.
		/// </exception>
		/// <exception cref="NotSupportedException">
		/// Exception thrown if <paramref name="graphicsStateId"/> specify a graphics state that is not supported.
		/// </exception>
		public void Keep(string graphicsStateId)
		{
			if (graphicsStateId == null)
				throw new ArgumentNullException("graphicsStateId");

			switch (graphicsStateId) {
				case BlendState.StateId:
					Keep(new BlendState(_GraphicsContext));
					break;
				case ViewportState.StateId:
					Keep(new ViewportState(_GraphicsContext));
					break;
				default:
					throw new NotSupportedException(String.Format("the graphics state {0} is not supported", graphicsStateId));
			}
		}

		/// <summary>
		/// Keep the specified graphics state, identified using its identifier.
		/// </summary>
		/// <param name="graphicsState">
		/// A <see cref="GraphicsState"/> that holds the graphics state to keep.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="graphicsState"/> is null.
		/// </exception>
		private void Keep(GraphicsState graphicsState)
		{
			if (graphicsState == null)
				throw new ArgumentNullException("graphicsState");
			GraphicsResource.CheckCurrentContext(_GraphicsContext);

			GraphicsState previousGraphicsState;

			if (_KeepedStates.TryGetValue(graphicsState.StateIdentifier, out previousGraphicsState))
				previousGraphicsState.Dispose(_GraphicsContext);
			_KeepedStates[graphicsState.StateIdentifier] = graphicsState;
		}

		/// <summary>
		/// The <see cref="GraphicsContext"/> specifies at construction.
		/// </summary>
		private readonly GraphicsContext _GraphicsContext;

		/// <summary>
		/// Current <see cref="GraphicsState"/> instances to restore at disposition.
		/// </summary>
		private readonly Dictionary<string, GraphicsState> _KeepedStates = new Dictionary<string, GraphicsState>();

		#endregion

		#region IDisposable Implementation

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			GraphicsResource.CheckCurrentContext(_GraphicsContext);

			foreach (KeyValuePair<string, GraphicsState> pair in _KeepedStates) {
				// Restore keeped state
				pair.Value.ApplyState(_GraphicsContext, null);
				// Release resources
				pair.Value.Dispose(_GraphicsContext);
			}
			GC.SuppressFinalize(this);
		}


		#endregion
	}
}
