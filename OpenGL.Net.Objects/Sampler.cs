
// Copyright (C) 2017 Luca Piccioni
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
	/// <summary>
	/// Texture sampler object.
	/// </summary>
	public class Sampler : GraphicsResource
	{
		#region Constructors

		/// <summary>
		/// Construct the default Sampler.
		/// </summary>
		public Sampler()
		{

		}

		#endregion

		#region Parameters

		/// <summary>
		/// Sampler parameters.
		/// </summary>
		public readonly SamplerParameters Parameters = new SamplerParameters();

		/// <summary>
		/// Currently applied sampler parameters.
		/// </summary>
		private readonly SamplerParameters _ObjectParams = new SamplerParameters();

		#endregion

		#region Texture Unit Parameters

		internal void Bind(GraphicsContext ctx, TextureUnit textureUnit)
		{
			if (ctx.Extensions.SamplerObjects_ARB) {
				// Associate sampler to texture unit
				Gl.BindSampler(textureUnit.Index, ObjectName);
				// Update sampler parameters
				TexParameters(Parameters);
			}
		}

		internal static void Unbind(GraphicsContext ctx, TextureUnit textureUnit)
		{
			if (ctx.Extensions.SamplerObjects_ARB) {
				// Associate sampler to texture unit
				Gl.BindSampler(textureUnit.Index, InvalidObjectName);
			}
		}

		private void TexParameters(SamplerParameters samplerParams)
		{
			if (samplerParams.MinFilter != _ObjectParams.MinFilter) {
				Gl.SamplerParameter(ObjectName, SamplerParameterName.TextureMinFilter, (int)samplerParams.MinFilter);
				_ObjectParams.MinFilter = samplerParams.MinFilter;
			}
			
			if (samplerParams.MagFilter != _ObjectParams.MagFilter) {
				Gl.SamplerParameter(ObjectName, SamplerParameterName.TextureMagFilter, (int)samplerParams.MagFilter);
				_ObjectParams.MagFilter = samplerParams.MagFilter;
			}
			
			if (samplerParams.WrapCoordR != _ObjectParams.WrapCoordR) {
				Gl.SamplerParameter(ObjectName, SamplerParameterName.TextureWrapR, (int)samplerParams.WrapCoordR);
				_ObjectParams.WrapCoordR = samplerParams.WrapCoordR;
			}
			
			if (samplerParams.WrapCoordS != _ObjectParams.WrapCoordS) {
				Gl.SamplerParameter(ObjectName, SamplerParameterName.TextureWrapS, (int)samplerParams.WrapCoordS);
				_ObjectParams.WrapCoordS = samplerParams.WrapCoordS;
			}
			
			if (samplerParams.WrapCoordT != _ObjectParams.WrapCoordT) {
				Gl.SamplerParameter(ObjectName, SamplerParameterName.TextureWrapT, (int)samplerParams.WrapCoordT);
				_ObjectParams.WrapCoordT = samplerParams.WrapCoordT;
			}

#if !MONODROID
			if (samplerParams.CompareMode != _ObjectParams.CompareMode) {
				Gl.SamplerParameter(ObjectName, SamplerParameterName.TextureCompareMode, samplerParams.CompareMode ? Gl.COMPARE_R_TO_TEXTURE : Gl.NONE);
				_ObjectParams.CompareMode = samplerParams.CompareMode;
			}
#endif

			if (samplerParams.CompareFunc != _ObjectParams.CompareFunc) {
				Gl.SamplerParameter(ObjectName, SamplerParameterName.TextureCompareFunc, (int)samplerParams.CompareFunc);
				_ObjectParams.CompareFunc = samplerParams.CompareFunc;
			}
		}

		#endregion

		#region GraphicsResource Overrides

		/// <summary>
		/// Texture object class.
		/// </summary>
		internal static readonly Guid ThisObjectClass = new Guid("8ACF187E-4FF7-4330-A2AA-52362589B07E");

		/// <summary>
		/// Texture object class.
		/// </summary>
		public override Guid ObjectClass { get { return (ThisObjectClass); } }

		/// <summary>
		/// Determine whether this Texture really exists for a specific context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that would have created (or a sharing one) the object. This context shall be current to
		/// the calling thread.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this Texture exists in the object space of <paramref name="ctx"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The object existence is done by checking a valid object by its name <see cref="IGraphicsResource.ObjectName"/>. This routine will test whether
		/// <paramref name="ctx"/> has created this Texture (or is sharing with the creator).
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
			// Object name space test (and 'ctx' sanity checks)
			if (base.Exists(ctx) == false)
				return (false);

			return (!ctx.Extensions.SamplerObjects_ARB || Gl.IsSampler(ObjectName));
		}

		/// <summary>
		/// Determine whether this object requires a name bound to a context or not.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// .
		/// </returns>
		protected override bool RequiresName(GraphicsContext ctx)
		{
			return (ctx.Extensions.SamplerObjects_ARB);
		}

		/// <summary>
		/// Create a Texture name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// It returns a valid object name for this Texture.
		/// </returns>
		protected override uint CreateName(GraphicsContext ctx)
		{
			// Generate texture name
			return (Gl.GenSampler());
		}

		/// <summary>
		/// Delete a Texture name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for deleting this object name.
		/// </param>
		/// <param name="name">
		/// A <see cref="UInt32"/> that specify the object name to delete.
		/// </param>
		protected override void DeleteName(GraphicsContext ctx, uint name)
		{
			// Delete texture name
			Gl.DeleteSamplers(name);
		}

		/// <summary>
		/// Actually create this GraphicsResource resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void CreateObject(GraphicsContext ctx)
		{
			CheckCurrentContext(ctx);
		}

		#endregion
	}
}
