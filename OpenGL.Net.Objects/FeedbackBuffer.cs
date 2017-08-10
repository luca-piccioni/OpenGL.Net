
// Copyright (C) 2009-2017 Luca Piccioni
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

namespace OpenGL.Objects
{
	/// <summary>
	/// Feedback buffer object.
	/// </summary>
	public class FeedbackBuffer : Buffer
	{
		#region Constructors

		/// <summary>
		/// Construct an FeedbackBufferObject.
		/// </summary>
		public FeedbackBuffer()
			: base(BufferTarget.TransformFeedbackBuffer, BufferUsage.DynamicCopy)
		{

		}

		#endregion

		#region Array Buffer Attachment

		public void AttachArray(uint varyingLocation, ArrayBufferBase arrayBuffer)
		{
			AttachArray(varyingLocation, arrayBuffer, 0);
		}

		public void AttachArray(uint varyingLocation, ArrayBufferBase arrayBuffer, uint sectionIndex)
		{
			_AttachedArrays[varyingLocation] = new ArrayAttachment(arrayBuffer, sectionIndex);
		}

		private class ArrayAttachment : IDisposable
		{
			#region Constructors

			/// <summary>
			/// 
			/// </summary>
			/// <param name="arrayBuffer"></param>
			/// <param name="sectionIndex"></param>
			public ArrayAttachment(ArrayBufferBase arrayBuffer, uint sectionIndex)
			{
				if (arrayBuffer == null)
					throw new ArgumentNullException("arrayBuffer");

				ArrayBuffer = arrayBuffer;
				ArrayBuffer.IncRef();
				ArraySectionIndex = sectionIndex;
			}

			#endregion

			#region Array Information

			/// <summary>
			/// The array buffer object used as transform feedback target.
			/// </summary>
			public readonly ArrayBufferBase ArrayBuffer;

			/// <summary>
			/// The vertex array sub-buffer index.
			/// </summary>
			public readonly uint ArraySectionIndex;

			#endregion

			#region IDisposable Implementation

			/// <summary>
			/// Dispose this VertexArray.
			/// </summary>
			public void Dispose()
			{
				ArrayBuffer.DecRef();
			}

			#endregion
		}

		private void MapBufferObjects(GraphicsContext ctx)
		{
			foreach (KeyValuePair<uint,ArrayAttachment> pair in _AttachedArrays) {
				ArrayAttachment arrayAttachment = pair.Value;
				ArrayBufferBase.IArraySection arraySection = arrayAttachment.ArrayBuffer.GetArraySection(arrayAttachment.ArraySectionIndex);

				Gl.BindBufferRange(BufferTarget.TransformFeedbackBuffer, pair.Key, arrayAttachment.ArrayBuffer.ObjectName, arraySection.Offset, arrayAttachment.ArrayBuffer.GpuBufferSize - (uint)arraySection.Offset.ToInt32());
			}
		}
		
		/// <summary>
		/// The attached arrays to this feedback buffer.
		/// </summary>
		private readonly Dictionary<uint, ArrayAttachment> _AttachedArrays = new Dictionary<uint, ArrayAttachment>();

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
			CheckThisExistence(ctx);
			
			// Make this feedback buffer current
			ctx.Bind(this);
			
			// Begin transform feedback
			switch (primitive) {
				case PrimitiveType.Points:
					Gl.BeginTransformFeedback(PrimitiveType.Points);
					break;
				case PrimitiveType.Lines:
				case PrimitiveType.LineStrip:
				case PrimitiveType.LineLoop:
					Gl.BeginTransformFeedback(PrimitiveType.Lines);
					break;
				case PrimitiveType.Triangles:
				case PrimitiveType.TriangleStrip:
				case PrimitiveType.TriangleFan:
					Gl.BeginTransformFeedback(PrimitiveType.Triangles);
					break;
				default:
					throw new InvalidOperationException();
			}
			
			// Disable rasterizer?
			if (EnableRasterizer == false)
				Gl.Enable(EnableCap.RasterizerDiscard);
			
			// Start queries
			_PrimitivesGenerated.Begin(ctx);
			_PrimitivesWritten.Begin(ctx);
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
			_PrimitivesGenerated.End(ctx);
			_PrimitivesWritten.End(ctx);
			
			_PrimitivesGenerated.GetResult(ctx, out mPrimitivesGeneratedCached);
			_PrimitivesWritten.GetResult(ctx, out mPrimitivesWrittenCached);
			
			// End tranform feedback
			Gl.EndTransformFeedback();
		
			// Enable rasterizer?
			if (EnableRasterizer == false)
				Gl.Disable(EnableCap.RasterizerDiscard);
			
			// This feedback buffer is not current anymore
			ctx.Unbind(this);
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
		
		private Query _PrimitivesGenerated;
		
		private ulong mPrimitivesGeneratedCached;
		
		private Query _PrimitivesWritten;
		
		private ulong mPrimitivesWrittenCached;
		
		#endregion
		
		#region BufferObject Overrides
		
		
		
		#endregion

		#region BufferObject Overrides

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
			// Object name space test
			if (base.Exists(ctx) == false)
				return (false);

			return (!ctx.Extensions.TransformFeedback2_ARB || Gl.IsTransformFeedback(ObjectName));
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
			
			return (ctx.Extensions.TransformFeedback2_ARB || Gl.CurrentExtensions.TransformFeedback_EXT);
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
			
			if (ctx.Extensions.TransformFeedback2_ARB) {
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
		/// A <see cref="UInt32"/> that specify the object name to delete.
		/// </param>
		protected override void DeleteName(GraphicsContext ctx, uint name)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			
			if (ctx.Extensions.TransformFeedback2_ARB) {
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
			if (_AttachedArrays.Count == 0)
				throw new InvalidOperationException("no feedback attachments");
			
			if (ctx.Extensions.TransformFeedback2_ARB) {
				// Bind/create feedback buffer
				Gl.BindTransformFeedback(TransformFeedbackTarget.TransformFeedback, ObjectName);
				
				// Define feedback buffer
				MapBufferObjects(ctx);
	
				// Reset feedback target binding
				Gl.BindTransformFeedback(TransformFeedbackTarget.TransformFeedback, 0);
			} else {
				
				ctx.Bind(this);
				
				// Define feedback buffer
				MapBufferObjects(ctx);
			}
			
			// Create queries
			_PrimitivesGenerated = new Query(QueryTarget.PrimitivesGenerated);
			_PrimitivesGenerated.Create(ctx);
			
			_PrimitivesWritten = new Query(QueryTarget.TransformFeedbackPrimitivesWritten);
			_PrimitivesWritten.Create(ctx);
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
			if (_PrimitivesGenerated != null) {
				_PrimitivesGenerated.Dispose(ctx);
				_PrimitivesGenerated = null;
			}

			if (_PrimitivesWritten != null) {
				_PrimitivesWritten.Dispose(ctx);
				_PrimitivesWritten = null;
			}

			// Base implementation
			base.Dispose(ctx);
		}

		/// <summary>
		/// Virtual Bind implementation.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for binding.
		/// </param>
		protected override void BindCore(GraphicsContext ctx)
		{
			if (ctx.Extensions.TransformFeedback2_ARB) {
				// Bind this feedback buffer
				Gl.BindTransformFeedback(TransformFeedbackTarget.TransformFeedback, ObjectName);
			} else {
				base.BindCore(ctx);
				MapBufferObjects(ctx);
			}
		}

		/// <summary>
		/// Virtual Unbind implementation.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for binding.
		/// </param>
		protected override void UnbindCore(GraphicsContext ctx)
		{
			if (ctx.Extensions.TransformFeedback2_ARB) {
				// Bind this  feedback buffer
				Gl.BindTransformFeedback(TransformFeedbackTarget.TransformFeedback, InvalidObjectName);
			} else
				base.UnbindCore(ctx);
		}

		#endregion
	}
}

