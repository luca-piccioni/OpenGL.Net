
// Copyright (C) 2017 Luca Piccioni
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
		public Sampler() : this(true)
		{

		}

		/// <summary>
		/// Construct a Sampler with the possibility to choose compatible implementation.
		/// </summary>
		/// <param name="samplerObject">
		/// A <see cref="Boolean"/> that specifies whether this is a sampler object in terms of
		/// GL_ARB_sampler_objects. If false, it acts as immediate sampler (using <see cref="Gl.TexParameter"/>).
		/// </param>
		internal Sampler(bool samplerObject)
		{
			_SamplerObject = samplerObject;
		}

		#endregion

		#region Filtering

		/// <summary>
		/// Minification filter property.
		/// </summary>
		public TextureMinFilter MinFilter
		{
			get { return (_MinFilter); }
			set
			{
				if (_MinFilter != value)
					_MinFilterDirty = true;
				_MinFilter = value;
			}
		}

		/// <summary>
		/// Minification filter.
		/// </summary>
		private TextureMinFilter _MinFilter = TextureMinFilter.NearestMipmapLinear;

		/// <summary>
		/// Flag for applying <see cref="_MinFilter"/> only if changes.
		/// </summary>
		private bool _MinFilterDirty = true;

		/// <summary>
		/// Magnification filter property.
		/// </summary>
		public TextureMagFilter MagFilter
		{
			get { return (_MagFilter); }
			set
			{
				if (_MagFilter != value)
					_MagFilterDirty = true;
				_MagFilter = value;
			}
		}

		/// <summary>
		/// Magnification filter.
		/// </summary>
		private TextureMagFilter _MagFilter = TextureMagFilter.Linear;

		/// <summary>
		/// Flag for applying <see cref="_MagFilter"/> only if changes.
		/// </summary>
		private bool _MagFilterDirty = true;

		#endregion

		#region Wrap Mode

		/// <summary>
		/// Wrapping on texture S coordinate.
		/// </summary>
		public TextureWrapMode WrapCoordS
		{
			get { return (_WrapS); }
			set
			{
				if (_WrapS != value)
					_WrapSDirty = true;
				_WrapS = value;
			}
		}

		/// <summary>
		/// Wrapping on S coordinate.
		/// </summary>
		private TextureWrapMode _WrapS = TextureWrapMode.Repeat;

		/// <summary>
		/// Flag for applying <see cref="_MinFilter"/> only if changes.
		/// </summary>
		private bool _WrapSDirty = true;

		/// <summary>
		/// Wrapping on texture T coordinate.
		/// </summary>
		public TextureWrapMode WrapCoordT
		{
			get { return (_WrapT); }
			set
			{
				if (_WrapT != value)
					_WrapTDirty = true;
				_WrapT = value;
			}
		}

		/// <summary>
		/// Wrapping on T coordinate.
		/// </summary>
		private TextureWrapMode _WrapT = TextureWrapMode.Repeat;

		/// <summary>
		/// Flag for applying <see cref="_MinFilter"/> only if changes.
		/// </summary>
		private bool _WrapTDirty = true;

		/// <summary>
		/// Wrapping on texture R coordinate.
		/// </summary>
		public TextureWrapMode WrapCoordR
		{
			get { return (_WrapR); }
			set
			{
				if (_WrapR != value)
					_WrapRDirty = true;
				_WrapR = value;
			}
		}

		/// <summary>
		/// Wrapping on R coordinate.
		/// </summary>
		private TextureWrapMode _WrapR = TextureWrapMode.Repeat;

		/// <summary>
		/// Flag for applying <see cref="_MinFilter"/> only if changes.
		/// </summary>
		private bool _WrapRDirty = true;

		#endregion

		#region Parameters Application

		/// <summary>
		/// Apply sampler parameters the active texture unit.
		/// </summary>
		/// <param name="ctx"></param>
		/// <param name="texture"></param>
		/// <param name="force"></param>
		public void Apply(GraphicsContext ctx, Texture texture, bool force)
		{
			if (!_SamplerObject || !ctx.Extensions.SamplerObjects_ARB) {

				// Affect currently active texture unit

				if (_MinFilterDirty || force) {
					Gl.TexParameter(texture.TextureTarget, TextureParameterName.TextureMinFilter, (int)MinFilter);
					_MinFilterDirty = false;
				}
			
				if (_MagFilterDirty || force) {
					Gl.TexParameter(texture.TextureTarget, TextureParameterName.TextureMagFilter, (int)MagFilter);
					_MagFilterDirty = false;
				}
			
				if (_WrapRDirty || force) {
					Gl.TexParameter(texture.TextureTarget, TextureParameterName.TextureWrapR, (int)WrapCoordR);
					_WrapRDirty = false;
				}
			
				if (_WrapSDirty || force) {
					Gl.TexParameter(texture.TextureTarget, TextureParameterName.TextureWrapS, (int)WrapCoordS);
					_WrapSDirty = false;
				}
			
				if (_WrapTDirty || force) {
					Gl.TexParameter(texture.TextureTarget, TextureParameterName.TextureWrapT, (int)WrapCoordT);
					_WrapTDirty = false;
				}
			} else {
				// Update sampler parameters
				UpdateSamplerParameters(ctx);
			}
		}

		private void UpdateSamplerParameters(GraphicsContext ctx)
		{
			if (_MinFilterDirty) {
				Gl.SamplerParameter(ObjectName, (int)TextureParameterName.TextureMinFilter, (int)MinFilter);
				_MinFilterDirty = false;
			}
			
			if (_MagFilterDirty) {
				Gl.SamplerParameter(ObjectName, (int)TextureParameterName.TextureMagFilter, (int)MagFilter);
				_MagFilterDirty = false;
			}
			
			if (_WrapRDirty) {
				Gl.SamplerParameter(ObjectName, (int)TextureParameterName.TextureWrapR, (int)WrapCoordR);
				_WrapRDirty = false;
			}
			
			if (_WrapSDirty) {
				Gl.SamplerParameter(ObjectName, (int)TextureParameterName.TextureWrapS, (int)WrapCoordS);
				_WrapSDirty = false;
			}
			
			if (_WrapTDirty) {
				Gl.SamplerParameter(ObjectName, (int)TextureParameterName.TextureWrapT, (int)WrapCoordT);
				_WrapTDirty = false;
			}
		}

		/// <summary>
		/// Flag indicating whether this instance is taking advantage of GL_ARB_sampler_object, if supported. If false,
		/// it emulates sampler interface using texture parameters.
		/// </summary>
		private bool _SamplerObject;

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

			return (!_SamplerObject || !ctx.Extensions.SamplerObjects_ARB || Gl.IsSampler(ObjectName));
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
			return (_SamplerObject && ctx.Extensions.SamplerObjects_ARB);
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

			if (_SamplerObject && ctx.Extensions.SamplerObjects_ARB)
				UpdateSamplerParameters(ctx);
		}

		#endregion
	}
}
