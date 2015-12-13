
// Copyright (C) 2011-2013 Luca Piccioni
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//  
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//  
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenGL
{
	/// <summary>
	/// Shader source string which can be included in other shader objects by means of #include preprocessor directive.
	/// </summary>
	public class ShaderInclude : GraphicsResource, IShaderInclude
	{
		#region Constructors

		/// <summary>
		/// Construct a ShaderInclude specifying only its path.
		/// </summary>
		/// <param name="path">
		/// A <see cref="System.String"/> that specifies the path used for including the include source string
		/// using GLSL #include preprocessor directive.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown is <paramref name="path"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="path"/> is not rooted (i.e. it doesn't start with '/' character), or if
		/// it specifies a directory path (i.e. it ends with '/' character) or if its value contains invalid path
		/// characters ('\n', '\t', '"', '&lt;', or '&gt;').
		/// </exception>
		protected ShaderInclude(string path)
		{
			if (path == null)
				throw new ArgumentNullException("path");
			if (path.StartsWith("/") == false)
				throw new ArgumentException("path not rooted", "path");
			if (path.EndsWith("/") == true)
				throw new ArgumentException("path has a trailing slash", "path");
			if (path.IndexOfAny(sInvalidPathChars) != -1)
				throw new ArgumentException(String.Format("path {0} contains invalid characters", path), "path");

			// Store include path
			mIncludePath = path;
		}

		/// <summary>
		/// Construct a ShaderInclude specifying only its path.
		/// </summary>
		/// <param name="path">
		/// A <see cref="System.String"/> that specifies the path used for including the include source string
		/// using GLSL #include preprocessor directive.
		/// </param>
		/// <param name="source">
		/// A <see cref="IEnumerable{String}"/> that specifies the shader include source text.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown is <paramref name="path"/> or <paramref name="source"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="path"/> is not rooted (i.e. it doesn't start with '/' character), or if
		/// it specifies a directory path (i.e. it ends with '/' character) or if its value contains invalid path
		/// characters ('\n', '\t', '"', '&lt;', or '&gt;').
		/// </exception>
		protected ShaderInclude(string path, IEnumerable<string> source) : this(path)
		{
			if (source == null)
				throw new ArgumentNullException("source");

			// Store include source
			mIncludeSource = new List<string>(source);
		}

		#endregion

		#region Include Path

		/// <summary>
		/// Path used for including this ShaderInclude source string.
		/// </summary>
		public string IncludePath { get { return (mIncludePath); } }

		/// <summary>
		/// Path used for including this ShaderInclude source string.
		/// </summary>
		private readonly string mIncludePath;

		private static readonly char[] sInvalidPathChars = new char[] {
			'\n', '\t', '"', '<', '>'
		};

		#endregion

		#region Include Source

		/// <summary>
		/// Include source strings.
		/// </summary>
		public virtual ICollection<string> IncludeSource
		{
			get {
				return (mIncludeSource.AsReadOnly());
			}
		}

		/// <summary>
		/// Include source strings.
		/// </summary>
		protected List<string> mIncludeSource;

		#endregion

		#region GraphicsResource Overrides

		/// <summary>
		/// Shader include object class.
		/// </summary>
		internal static readonly Guid ShaderIncludeObjectClass = new Guid("2B402F5B-15D2-4D3A-9A42-42D4C61AD650");

		/// <summary>
		/// Shader include object class.
		/// </summary>
		public override Guid ObjectClass { get { return (ShaderIncludeObjectClass); } }

		/// <summary>
		/// Determine whether this BufferObject really exists for a specific context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that would have created (or a sharing one) the object. This context shall be current to
		/// the calling thread.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this object exists in the object space of <paramref name="ctx"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The object existence is done by checking a valid object by its name <see cref="IRenderResource.ObjectName"/>. This routine will test whether
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
			
			// Base implementation
			if (!base.Exists(ctx))
				return (false);
			
			if (ctx.Caps.ShaderInclude == true)
				return (Gl.IsNamedStringARB(IncludePath.Length, IncludePath));

			return (true);
		}
		
		protected override bool RequiresName(GraphicsContext ctx)
		{
			return (false);
		}
		
		/// <summary>
		/// Actually create this ShaderObject resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void CreateObject(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			if (ctx.Caps.ShaderInclude) {
				StringBuilder sb = new StringBuilder();

				// Build include source string
				foreach (string line in IncludeSource)
					sb.AppendLine(line);

				// Create shader include
				Gl.NamedStringARB(Gl.SHADER_INCLUDE_ARB, -1, IncludePath, -1, sb.ToString());
			}
		}
		
		/// <summary>
		/// Delete this ShaderInclude.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for deleting this object.
		/// </param>
		public override void Delete(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			
			if (ctx.Caps.ShaderInclude)
				Gl.DeleteNamedStringARB(-1, IncludePath);
		}

		#endregion
	}
}
