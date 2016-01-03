
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
using System.Collections.Generic;

namespace OpenGL
{
	/// <summary>
	/// Feedback buffer object.
	/// </summary>
	public class FeedbackBufferObject : BufferObject
	{
		#region Constructors

		/// <summary>
		/// Construct an FeedbackBufferObject.
		/// </summary>
		public FeedbackBufferObject()
			: base(BufferTargetARB.TransformFeedbackBuffer, BufferObject.Hint.DynamicGpuDraw)
		{

		}

		#endregion

		#region Array Buffer Attachment

		public void AttachArray(uint feedbackIndex, ArrayBufferObject bufferObject)
		{
			AttachArray(feedbackIndex, bufferObject, 0);
		}

		public void AttachArray(uint feedbackIndex, ArrayBufferObject bufferObject, uint bufferStreamIndex)
		{
			ArrayAttachment arrayAttachment = new ArrayAttachment();

			arrayAttachment.BufferObject = bufferObject;
			arrayAttachment.BufferInfo = bufferObject.GetSubArrayInfo(bufferStreamIndex);

			mAttachedArrays[feedbackIndex] = arrayAttachment;
		}

		private struct ArrayAttachment
		{
			internal ArrayBufferObject BufferObject;

			internal ArrayBufferObject.SubArrayBuffer BufferInfo;
		}
		
		private void MapBufferObjects(GraphicsContext ctx)
		{
			foreach (KeyValuePair<uint,ArrayAttachment> pair in mAttachedArrays) {
				ArrayAttachment arrayAttachment = pair.Value;
				
				if (arrayAttachment.BufferObject.Exists(ctx) == false)
					throw new InvalidOperationException(String.Format("attach buffer object at index {0} don't exist", pair.Key));

				Gl.BindBufferRange(Gl.TRANSFORM_FEEDBACK_BUFFER, pair.Key, arrayAttachment.BufferObject.ObjectName, IntPtr.Zero, arrayAttachment.BufferObject.BufferSize);
			}
		}
		
		/// <summary>
		/// The attached arrays to this feedback buffer.
		/// </summary>
		private readonly Dictionary<uint, ArrayAttachment> mAttachedArrays = new Dictionary<uint, ArrayAttachment>();

		#endregion
		
		#region Feedback Control
		
		/// <summary>
		/// Binds the array buffer attached to.
		/// </summary>
		/// <param name='index'>
		/// Index.
		/// </param>
		/// <exception cref='InvalidOperationException'>
		/// Is thrown when an operation cannot be performed.
		/// </exception>
		public void Begin(GraphicsContext ctx, PrimitiveType primitive)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ObjectName == 0)
				throw new InvalidOperationException("invalid name");
			
			// Make this feedback buffer current
			Bind(ctx);
			
			// Begin transform feedback
			switch (primitive) {
				case PrimitiveType.Points:
					Gl.BeginTransformFeedback((int)PrimitiveType.Points);
					break;
				case PrimitiveType.Lines:
				case PrimitiveType.LineStrip:
				case PrimitiveType.LineLoop:
					Gl.BeginTransformFeedback((int)PrimitiveType.Lines);
					break;
				case PrimitiveType.Triangles:
				case PrimitiveType.TriangleStrip:
				case PrimitiveType.TriangleFan:
					Gl.BeginTransformFeedback((int)PrimitiveType.Triangles);
					break;
				default:
					throw new InvalidOperationException();
			}
			
			// Disable rasterizer?
			if (EnableRasterizer == false)
				Gl.Enable(EnableCap.RasterizerDiscard);
			
			// Start queries
			mPrimitivesGenerated.Begin(ctx);
			mPrimitivesWritten.Begin(ctx);
		}

		/// <summary>
		/// Binds the array buffer attached to.
		/// </summary>
		/// <param name='index'>
		/// Index.
		/// </param>
		/// <exception cref='InvalidOperationException'>
		/// Is thrown when an operation cannot be performed.
		/// </exception>
		public void End(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			
			// Start queries
			mPrimitivesGenerated.End(ctx);
			mPrimitivesWritten.End(ctx);
			
			mPrimitivesGenerated.GetResult(ctx, out mPrimitivesGeneratedCached);
			mPrimitivesWritten.GetResult(ctx, out mPrimitivesWrittenCached);
			
			// End tranform feedback
			Gl.EndTransformFeedback();
		
			// Enable rasterizer?
			if (EnableRasterizer == false)
				Gl.Disable(EnableCap.RasterizerDiscard);
			
			// This feedback buffer is not current anymore
			Unbind(ctx);
		}
		
		#endregion
		
		#region Rasterizer Control
		
		/// <summary>
		/// The rasterizer enabled flag.
		/// </summary>
		public bool EnableRasterizer;
		
		#endregion
		
		#region Primitives Query
		
		public ulong PrimitivesGenerated
		{
			get { return (mPrimitivesGeneratedCached); }
		}
		
		public ulong PrimitivesWritten
		{
			get { return (mPrimitivesWrittenCached); }
		}
		
		public bool Overflow { get { return (mPrimitivesWrittenCached != 0 && mPrimitivesGeneratedCached > mPrimitivesWrittenCached); } }
		
		private QueryObject mPrimitivesGenerated;
		
		private ulong mPrimitivesGeneratedCached;
		
		private QueryObject mPrimitivesWritten;
		
		private ulong mPrimitivesWrittenCached;
		
		#endregion
		
		#region BufferObject Overrides
		
		/// <summary>
		/// Bind this BufferObject.
		/// </summary>
		internal override void Bind(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			
			if (ctx.Caps.GlExtensions.TransformFeedback2_ARB) {
				// Bind this  feedback buffer
				Gl.BindTransformFeedback(Gl.TRANSFORM_FEEDBACK, ObjectName);
			} else {
				base.Bind(ctx);
				MapBufferObjects(ctx);
			}
		}

		/// <summary>
		/// Unbind this BufferObject.
		/// </summary>
		internal override void Unbind(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			
			if (ctx.Caps.GlExtensions.TransformFeedback2_ARB) {
				// Bind this  feedback buffer
				Gl.BindTransformFeedback(Gl.TRANSFORM_FEEDBACK, 0);
			}
#if false
			else {
				// Manually map buffer objects
				foreach (KeyValuePair<uint,ArrayAttachment> pair in mAttachedArrays) {
					Gl.BindBufferBase(Gl.TRANSFORM_FEEDBACK_BUFFER, pair.Key, 0);
					RenderException.DebugCheckErrors();
				}
			}
#endif
		}
		
		#endregion

		#region GraphicsResource Overrides

		/// <summary>
		/// Feedback buffer object class.
		/// </summary>
		internal static new readonly Guid ThisObjectClass = new Guid("B013C3F0-4E31-49F1-9AF6-4DB4B2711B67");

		/// <summary>
		/// Feedback buffer object class.
		/// </summary>
		public override Guid ObjectClass { get { return (ThisObjectClass); } }

		/// <summary>
		/// Determine whether this FeedbackBufferObject really exists for a specific context.
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

			return (!ctx.Caps.GlExtensions.TransformFeedback2_ARB || Gl.IsTransformFeedback(ObjectName));
		}
		
		/// <summary>
		/// Determine whether this object requires a name bound to a context or not.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// <para>
		/// This implementation check whether the GL_ARB_transform_feedback2 is implemented.
		/// </para>
		/// </returns>
		protected override bool RequiresName(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			
			return (ctx.Caps.GlExtensions.TransformFeedback2_ARB || ctx.Caps.GlExtensions.TransformFeedback_EXT);
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
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			
			uint name;
			
			if (ctx.Caps.GlExtensions.TransformFeedback2_ARB) {
				// Create buffer object
				name = Gl.GenTransformFeedback();
			} else
				name = base.CreateName(ctx);
			
			return (name);
		}

		/// <summary>
		/// Delete a BufferObject name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for deleting this buffer object name.
		/// </param>
		/// <param name="name">
		/// A <see cref="System.UInt32"/> that specify the object name to delete.
		/// </param>
		protected override void DeleteName(GraphicsContext ctx, uint name)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			
			if (ctx.Caps.GlExtensions.TransformFeedback2_ARB) {
				// Delete buffer object
				Gl.DeleteTransformFeedbacks(name);
			} else
				base.DeleteName(ctx, name);
		}

		/// <summary>
		/// Actually create this GraphicsResource resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void CreateObject(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (mAttachedArrays.Count == 0)
				throw new InvalidOperationException("no feedback attachments");
			
			if (ctx.Caps.GlExtensions.TransformFeedback2_ARB) {
				// Bind/create feedback buffer
				Gl.BindTransformFeedback(Gl.TRANSFORM_FEEDBACK, ObjectName);
				
				// Define feedback buffer
				MapBufferObjects(ctx);
	
				// Reset feedback target binding
				Gl.BindTransformFeedback(Gl.TRANSFORM_FEEDBACK, 0);
			} else {
				
				Bind(ctx);
				
				// Define feedback buffer
				MapBufferObjects(ctx);
			}
			
			// Create queries
			mPrimitivesGenerated = new QueryObject(QueryTarget.PrimitivesGenerated);
			mPrimitivesGenerated.Create(ctx);
			
			mPrimitivesWritten = new QueryObject(QueryTarget.TransformFeedbackPrimitivesGenerated);
			mPrimitivesWritten.Create(ctx);
		}

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
		public override void Dispose(GraphicsContext ctx)
		{
			if (mPrimitivesGenerated != null) {
				mPrimitivesGenerated.Dispose(ctx);
				mPrimitivesGenerated = null;
			}

			if (mPrimitivesWritten != null) {
				mPrimitivesWritten.Dispose(ctx);
				mPrimitivesWritten = null;
			}

			// Base implementation
			base.Dispose(ctx);
		}

		#endregion
	}
}

