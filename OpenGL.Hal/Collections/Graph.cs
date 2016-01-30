
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

namespace OpenGL.Collections
{
	/// <summary>
	/// Graph collection utilities.
	/// </summary>
	public static class Graph<T> where T : IGraphNode
	{
		/// <summary>
		/// Delegate used for graph node testing.
		/// </summary>
		/// <param name="node"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public delegate bool GraphNodeDelegate(T node, object data);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="graph"></param>
		/// <param name="filter"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public static List<T> Find(T graph, GraphNodeDelegate filter, object data)
		{
			if (graph == null)
				throw new ArgumentNullException("graph");
			if (filter == null)
				throw new ArgumentNullException("filter");

			List<T> filtered = new List<T>();

			if (filter(graph, data)) filtered.Add(graph);

			foreach (T subnode in graph.SubNodes) {
				if (filter(subnode, data))
					filtered.Add(subnode);
			}

			return (filtered);
		}

		public static List<T> Find<TFind>(T graph) where TFind : IGraphNode
		{
			return (Find(graph, delegate(T node, object data) { return (node is T); }, null));
		}
	}
}
