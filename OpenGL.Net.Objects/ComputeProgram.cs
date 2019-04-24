
// Copyright (C) 2019 Luca Piccioni
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
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace OpenGL.Objects
{
	/// <summary>
	/// Compute program.
	/// </summary>
	[DebuggerDisplay("ComputeProgram: Name={ObjectName} Id={Identifier} Linked={IsLinked}")]
	public class ComputeProgram : ShaderProgram
	{
		#region Constructors

		/// <summary>
		/// Construct a ComputeProgram.
		/// </summary>
		/// <param name="programName">
		/// A <see cref="String"/> that specify the shader program name.
		/// </param>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if the parameter <paramref name="programName"/> is not a valid name.
		/// </exception>
		public ComputeProgram(string programName) : base(programName)
		{
			
		}

		#endregion

		#region Compute

		/// <summary>
		/// Dispatch the compute shader.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> on which the compute is dispatched.
		/// </param>
		/// <param name="x">
		/// The number of work groups to be launched in the X dimension.
		/// </param>
		/// <param name="y">
		/// The number of work groups to be launched in the Y dimension.
		/// </param>
		/// <param name="z">
		/// The number of work groups to be launched in the Z dimension.
		/// </param>
		public void Compute(GraphicsContext ctx, uint x, uint y = 1, uint z = 1)
		{
			CheckCurrentContext(ctx);
			CheckThisExistence(ctx);

			// Ensure program bound
			ctx.Bind(this);
			// Ensure linked I/O
			BindImages(ctx);
			// Dispatch
			Gl.DispatchCompute(x, y, z);
		}

		#endregion

		#region Memory Barrier

		/// <summary>
		/// Defines a barrier ordering memory transactions
		/// </summary>
		/// <param name="memoryBarrierMask">
		/// Specifies the barriers to insert.
		/// </param>
		public void MemoryBarrier(MemoryBarrierMask memoryBarrierMask = MemoryBarrierMask.AllBarrierBits)
		{
			Gl.MemoryBarrier(memoryBarrierMask);
		}

		#endregion

		#region Image Support

		/// <summary>
		/// Link between image uniform and image unit preset.
		/// </summary>
		private class ImageUnitBinding : ImageUnitState, IDisposable
		{
			/// <summary>
			/// Construct a ImageUnitBinding.
			/// </summary>
			/// <param name="uniformName">
			/// The <see cref="string"/> that specifies the name of the uniform.
			/// </param>
			public ImageUnitBinding(string uniformName)
			{
				if (uniformName == null)
					throw new ArgumentNullException(nameof(uniformName));
				UniformName = uniformName;
			}

			/// <summary>
			/// The name of the image uniform.
			/// </summary>
			public readonly string UniformName;

			/// <summary>
			/// Get or set the texture currently bound on texture unit.
			/// </summary>
			public Texture Texture
			{
				get { return _Texture; }
				set { Swap(value, ref _Texture); }
			}

			/// <summary>
			/// Texture currently bound on texture unit.
			/// </summary>
			private Texture _Texture;

			/// <summary>
			/// Overrides the format used for accesses to bound texture.
			/// </summary>
			public InternalFormat? OverrideInternalFormat;

			/// <summary>
			/// Format used for accesses to bound texture.
			/// </summary>
			public override InternalFormat InternalFormat
			{
				get 
				{
					// Override first
					if (OverrideInternalFormat.HasValue)
						return OverrideInternalFormat.Value;
					
					// Match texture coordinate, if any.
					Texture texture = Texture;
					if (texture != null)
						return texture.PixelLayout.ToInternalFormat();

					// Base implementation (R8)
					return base.InternalFormat;
				}
				set { base.InternalFormat = value; }
			}

			public void Dispose()
			{
				_Texture?.DecRef();
			}
		}

		public void BindImage(string uniformName, Texture texture, BufferAccess access = BufferAccess.ReadOnly, int level = 0, InternalFormat? internalFormat = null)
		{
			ImageUnitBinding imageUnitBinding = new ImageUnitBinding(uniformName);

			imageUnitBinding.Texture = texture;
			imageUnitBinding.Level = level;
			imageUnitBinding.Access = access;
			imageUnitBinding.OverrideInternalFormat = internalFormat;

			_ImageUnitBindings[uniformName] = imageUnitBinding;
		}

		public void BindImage(string uniformName, Texture3D texture, int layer, BufferAccess access = BufferAccess.ReadOnly, int level = 0, InternalFormat? internalFormat = null)
		{
			ImageUnitBinding imageUnitBinding = new ImageUnitBinding(uniformName);

			imageUnitBinding.Texture = texture;
			imageUnitBinding.Level = level;
			imageUnitBinding.Layered = true;
			imageUnitBinding.Layer = layer;
			imageUnitBinding.Access = access;
			imageUnitBinding.OverrideInternalFormat = internalFormat;

			_ImageUnitBindings[uniformName] = imageUnitBinding;
		}

		public void BindImage(string uniformName, TextureArray2D texture, int layer, BufferAccess access = BufferAccess.ReadOnly, int level = 0, InternalFormat? internalFormat = null)
		{
			ImageUnitBinding imageUnitBinding = new ImageUnitBinding(uniformName);

			imageUnitBinding.Texture = texture;
			imageUnitBinding.Level = level;
			imageUnitBinding.Layered = true;
			imageUnitBinding.Layer = layer;
			imageUnitBinding.Access = access;
			imageUnitBinding.OverrideInternalFormat = internalFormat;

			_ImageUnitBindings[uniformName] = imageUnitBinding;
		}

		public void BindImage(string uniformName, TextureCube texture, int layer, BufferAccess access = BufferAccess.ReadOnly, int level = 0, InternalFormat? internalFormat = null)
		{
			ImageUnitBinding imageUnitBinding = new ImageUnitBinding(uniformName);

			imageUnitBinding.Texture = texture;
			imageUnitBinding.Level = level;
			imageUnitBinding.Layered = true;
			imageUnitBinding.Layer = layer;
			imageUnitBinding.Access = access;
			imageUnitBinding.OverrideInternalFormat = internalFormat;

			_ImageUnitBindings[uniformName] = imageUnitBinding;
		}

		private void BindImages(GraphicsContext ctx)
		{
			CheckCurrentContext(ctx);

			foreach (KeyValuePair<string, ImageUnitBinding> pair in _ImageUnitBindings) {
				ImageUnitBinding imageBinding = pair.Value;
				ImageUnit imageUnit = ctx.GetImageUnit(imageBinding.Texture, imageBinding);

				SetUniform(ctx, pair.Key, (int)imageUnit.Index);

				imageUnit.Bind(ctx, imageBinding.Texture, imageBinding);
			}
		}
		
		/// <summary>
		/// The image units to bind before computation.
		/// </summary>
		private readonly Dictionary<string, ImageUnitBinding> _ImageUnitBindings = new Dictionary<string, ImageUnitBinding>();

		#endregion

		#region Overrides

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="Boolean"/> indicating whether this method is called by <see cref="Dispose"/>. If it is false,
		/// this method is called by the finalizer.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				// Release references to texture used as images
				foreach (KeyValuePair<string, ImageUnitBinding> pair in _ImageUnitBindings)
					pair.Value.Dispose();
			}
			// Base implementation
			base.Dispose(disposing);
		}

		#endregion
	}
}
