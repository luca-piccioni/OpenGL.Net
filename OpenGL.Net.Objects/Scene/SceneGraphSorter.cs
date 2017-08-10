
// Copyright (C) 2016-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Collections.Generic;

using OpenGL.Objects.State;

namespace OpenGL.Objects.Scene
{
	/// <summary>
	/// Scene graph object sorter.
	/// </summary>
	abstract class SceneGraphSorter
	{
		/// <summary>
		/// Sort a sequence of <see cref="SceneObjectBatch"/>.
		/// </summary>
		/// <param name="objects">
		/// A <see cref="List{SceneObjectBatch}"/> indicating the sequence of scene objects to be sorted.
		/// </param>
		/// <returns>
		/// It returns a <see cref="List{SceneObjectBatch}"/> containing all objects found in <paramref name="objects"/>, but
		/// ordered following the concrete implementation criteria.
		/// </returns>
		public virtual List<SceneObjectBatch> Sort(List<SceneObjectBatch> objects)
		{
			List<SceneObjectBatch> sorted = new List<SceneObjectBatch>(objects.Count);
			KeyValuePair<SceneGraphSorter, List<SceneObjectBatch>>[] chunks = Split(objects);

			// Sort recursively
			foreach (KeyValuePair<SceneGraphSorter, List<SceneObjectBatch>> pair in chunks) {
				if (pair.Key != null)
					sorted.AddRange(pair.Key.Sort(pair.Value));
				else
					sorted.AddRange(pair.Value);
			}

			return (sorted);
		}

		/// <summary>
		/// Split the input sequence into smaller sequences, associated to a <see cref="SceneGraphSorter"/> used for sorting recursively
		/// the individual sequences.
		/// </summary>
		/// <param name="objects">
		/// A <see cref="List{SceneObjectBatch}"/> indicating the sequence of scene objects to be splitted in sub-sequences.
		/// </param>
		/// <returns>
		/// It returns a <see cref="T:KeyValuePair{SceneGraphSorter, List{SceneObjectBatch}}[]"/> indicating a set of <see cref="List{SceneObjectBatch}"/>
		/// associated to a <see cref="SceneGraphSorter"/>.
		/// </returns>
		protected abstract KeyValuePair<SceneGraphSorter, List<SceneObjectBatch>>[] Split(List<SceneObjectBatch> objects);
	}

	/// <summary>
	/// Scene graph object sorter, binary filtering (useful for simplae states).
	/// </summary>
	abstract class SceneObjectSorterBinary : SceneGraphSorter
	{
		#region Sorter Chaining

		public SceneGraphSorter SorterA
		{
			get; set;
		}

		public SceneGraphSorter SorterB
		{
			get; set;
		}

		protected abstract bool ComparePriority(SceneObjectBatch objectBatch);

		#endregion

		#region ObjectSorter Overrides

		/// <summary>
		/// Split the input sequence into smaller sequences, associated to a <see cref="SceneGraphSorter"/> used for sorting recursively
		/// the individual sequences.
		/// </summary>
		/// <param name="objects"></param>
		/// <returns></returns>
		protected override KeyValuePair<SceneGraphSorter, List<SceneObjectBatch>>[] Split(List<SceneObjectBatch> objects)
		{
			if (objects == null)
				throw new ArgumentNullException("objects");

			List<SceneObjectBatch> a = new List<SceneObjectBatch>();
			List<SceneObjectBatch> b = new List<SceneObjectBatch>();

			foreach (SceneObjectBatch objectBatch in objects) {
				if (ComparePriority(objectBatch))
					a.Add(objectBatch);
				else
					b.Add(objectBatch);
			}

			return (new KeyValuePair<SceneGraphSorter, List<SceneObjectBatch>>[] {
				new KeyValuePair<SceneGraphSorter, List<SceneObjectBatch>>(SorterA, a),
				new KeyValuePair<SceneGraphSorter, List<SceneObjectBatch>>(SorterB, b)
			});
		}

		#endregion
	}

	abstract class SceneObjectSorterCompare : SceneGraphSorter, IComparer<SceneObjectBatch>
	{
		#region IComparer<ObjectBatch> Implementation

		public abstract int Compare(SceneObjectBatch x, SceneObjectBatch y);

		#endregion

		#region ObjectSorterBase Overrides

		/// <summary>
		/// 
		/// </summary>
		/// <param name="objects"></param>
		/// <returns></returns>
		public override List<SceneObjectBatch> Sort(List<SceneObjectBatch> objects)
		{
			if (objects == null)
				throw new ArgumentNullException("objects");

			objects.Sort(this);

			return (objects);
		}

		#endregion
	}

	class SceneObjectSorterBlend : SceneObjectSorterBinary
	{
		#region ObjectSorterBinary Overrides

		protected override bool ComparePriority(SceneObjectBatch objectBatch)
		{
			BlendState blendState = (BlendState)objectBatch.State[BlendState.StateSetIndex];

			return (blendState == null || !blendState.Enabled);
		}

		#endregion
	}

	class SceneObjectSorterProgram : SceneGraphSorter
	{
		#region Sorter Chaining

		public SceneGraphSorter Sorter
		{
			get; set;
		}

		#endregion

		#region SceneGraphSorter Overrides

		/// <summary>
		/// Split the input sequence into smaller sequences, associated to a <see cref="SceneGraphSorter"/> used for sorting recursively
		/// the individual sequences.
		/// </summary>
		/// <param name="objects"></param>
		/// <returns></returns>
		protected override KeyValuePair<SceneGraphSorter, List<SceneObjectBatch>>[] Split(List<SceneObjectBatch> objects)
		{
			Dictionary<ShaderProgram, List<SceneObjectBatch>> programLists = new Dictionary<ShaderProgram, List<SceneObjectBatch>>();

			foreach (SceneObjectBatch objectBatch in objects) {
				List<SceneObjectBatch> programList;

				if (programLists.TryGetValue(objectBatch.Program, out programList)) {
					programList.Add(objectBatch);
					continue;
				}

				programList = new List<SceneObjectBatch>();
				programList.Add(objectBatch);
				programLists.Add(objectBatch.Program, programList);
			}

			List<KeyValuePair<SceneGraphSorter, List<SceneObjectBatch>>> subseqs = new List<KeyValuePair<SceneGraphSorter, List<SceneObjectBatch>>>();
			foreach (KeyValuePair<ShaderProgram, List<SceneObjectBatch>> pair in programLists)
				subseqs.Add(new KeyValuePair<SceneGraphSorter, List<SceneObjectBatch>>(Sorter, pair.Value));
			return (subseqs.ToArray());
		}

		#endregion
	}
}
