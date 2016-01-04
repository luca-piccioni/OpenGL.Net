
// Copyright (C) 2009-2015 Luca Piccioni
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
	public class QueryObject : GraphicsResource
	{
		#region Constructors

		/// <summary>
		/// Construct a QueryObject specify its target.
		/// </summary>
		/// <param name="target"></param>
		public QueryObject(QueryTarget target)
		{
			mTarget = target;
		}

		#endregion

		#region Query Method

		public QueryTarget Target { get { return (mTarget); } }

		public void Begin(GraphicsContext ctx)
		{
			Gl.BeginQuery((int)mTarget, ObjectName);
		}

		public void End(GraphicsContext ctx)
		{
			Gl.EndQuery((int)mTarget);
		}

		public bool IsAvailable(GraphicsContext ctx)
		{
			int availability = 0;

			Gl.GetQueryObject(ObjectName, Gl.QUERY_RESULT_AVAILABLE, out availability);

			return (availability != 0);
		}

		public void GetResult(GraphicsContext ctx, out int result)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			Gl.GetQueryObject(ObjectName, Gl.QUERY_RESULT, out result);
		}

		public void GetResult(GraphicsContext ctx, out uint result)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			Gl.GetQueryObject(ObjectName, Gl.QUERY_RESULT, out result);
		}

		public void GetResult(GraphicsContext ctx, out long result)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			if (ctx.Caps.GlExtensions.TimerQuery_ARB) {
				Gl.GetQueryObject(ObjectName, Gl.QUERY_RESULT, out result);
			} else {
				int intResult;

				GetResult(ctx, out intResult);

				result = intResult;
			}
		}

		public void GetResult(GraphicsContext ctx, out ulong result)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			if (ctx.Caps.GlExtensions.TimerQuery_ARB) {
				Gl.GetQueryObject(ObjectName, Gl.QUERY_RESULT, out result);
			} else {
				uint uintResult;

				GetResult(ctx, out uintResult);

				result = uintResult;
			}
		}

		private readonly QueryTarget mTarget;

		#endregion

		#region GraphicsResource Overrides

		/// <summary>
		/// Buffer object class.
		/// </summary>
		internal static readonly Guid ThisObjectClass = new Guid("E36CF107-AEC3-47B5-AC4E-184CDEC29053");

		/// <summary>
		/// Buffer object class.
		/// </summary>
		public override Guid ObjectClass { get { return (ThisObjectClass); } }

		/// <summary>
		/// Determine whether this BufferObject really exists for a specific context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that would have created (or a sharing one) the object. This context shall be current to
		/// the calling thread.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this BufferObject exists in the object space of <paramref name="ctx"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The object existence is done by checking a valid object by its name <see cref="IGraphicsResource.ObjectName"/>. This routine will test whether
		/// <paramref name="ctx"/> has created this BufferObject (or is sharing with the creator).
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current to the calling thread.
		/// </exception>
		public override bool Exists(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current", "ctx");

			// Object name space test (and 'ctx' sanity checks)
			if (base.Exists(ctx) == false)
				return (false);

			return (Gl.IsQuery(ObjectName));
		}

		/// <summary>
		/// Create a BufferObject name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this buffer object name.
		/// </param>
		/// <returns>
		/// It returns a valid object name for this BufferObject.
		/// </returns>
		protected override uint CreateName(GraphicsContext ctx)
		{
			switch (mTarget) {
				case QueryTarget.SamplesPassed:
					if (!ctx.Caps.GlExtensions.OcclusionQuery_ARB)
						throw new InvalidOperationException("occlusion query not available");
					break;
				case QueryTarget.TimeElapsed:
					if (!ctx.Caps.GlExtensions.TimerQuery_ARB)
						throw new InvalidOperationException("timer query not available");
					break;
				case QueryTarget.PrimitivesGenerated:
				case QueryTarget.TransformFeedbackPrimitivesGenerated:
					if (!ctx.Caps.GlExtensions.TransformFeedback_EXT && !ctx.Caps.GlExtensions.TransformFeedback_NV)
						throw new InvalidOperationException("timer query not available");
					break;
				case QueryTarget.AnySamplesPassed:
					if (!ctx.Caps.GlExtensions.OcclusionQuery2_ARB)
						throw new InvalidOperationException("(any) occlusion query not available");
					break;
				default:
					throw new InvalidOperationException(String.Format("unknown query target {0}", mTarget));
			}

			// Create buffer object;
			return (Gl.GenQuery());
		}

		/// <summary>
		/// Delete a BufferObject name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for deleting this buffer object name.
		/// </param>
		/// <param name="name">
		/// A <see cref="UInt32"/> that specify the object name to delete.
		/// </param>
		protected override void DeleteName(GraphicsContext ctx, uint name)
		{
			// Delete buffer object
			Gl.DeleteQueries(name);
		}

		#endregion
	}
}
