
// Copyright (C) 2009-2015 Luca Piccioni
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

namespace OpenGL.Objects
{
	public class Query : GraphicsResource
	{
		#region Constructors

		/// <summary>
		/// Construct a QueryObject specify its target.
		/// </summary>
		/// <param name="target"></param>
		public Query(QueryTarget target)
		{
			mTarget = target;
		}

		#endregion

		#region Query Method

		public QueryTarget Target { get { return (mTarget); } }

		public void Begin(GraphicsContext ctx)
		{
			Gl.BeginQuery(mTarget, ObjectName);
		}

		public void End(GraphicsContext ctx)
		{
			Gl.EndQuery(mTarget);
		}

		public bool IsAvailable(GraphicsContext ctx)
		{
			int availability = 0;

			Gl.GetQueryObject(ObjectName, QueryObjectParameterName.QueryResultAvailable , out availability);

			return (availability != 0);
		}

		public void GetResult(GraphicsContext ctx, out int result)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			Gl.GetQueryObject(ObjectName, QueryObjectParameterName.QueryResult, out result);
		}

		public void GetResult(GraphicsContext ctx, out uint result)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			Gl.GetQueryObject(ObjectName, QueryObjectParameterName.QueryResult, out result);
		}

		public void GetResult(GraphicsContext ctx, out long result)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			if (ctx.Extensions.TimerQuery_ARB) {
				Gl.GetQueryObject(ObjectName, QueryObjectParameterName.QueryResult, out result);
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

			if (ctx.Extensions.TimerQuery_ARB) {
				Gl.GetQueryObject(ObjectName, QueryObjectParameterName.QueryResult, out result);
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
#if !MONODROID
				case QueryTarget.SamplesPassed:
					if (!ctx.Extensions.OcclusionQuery_ARB)
						throw new InvalidOperationException("occlusion query not available");
					break;
#endif
				case QueryTarget.TimeElapsed:
					if (!ctx.Extensions.TimerQuery_ARB)
						throw new InvalidOperationException("timer query not available");
					break;
				case QueryTarget.PrimitivesGenerated:
				case QueryTarget.TransformFeedbackPrimitivesWritten:
					if (!ctx.Extensions.TransformFeedback_EXT && !Gl.CurrentExtensions.TransformFeedback_NV)
						throw new InvalidOperationException("timer query not available");
					break;
				case QueryTarget.AnySamplesPassed:
					if (!ctx.Extensions.OcclusionQuery2_ARB)
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
