
// Copyright (C) 2011-2017 Luca Piccioni
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
using System.IO;
using System.Text;

namespace OpenGL.Objects
{
	/// <summary>
	/// Shader source string which can be included in other shader objects by means of #include preprocessor directive.
	/// </summary>
	public class ShaderInclude : GraphicsResource
	{
		#region Constructors

		/// <summary>
		/// Construct a ShaderInclude specifying only its path.
		/// </summary>
		/// <param name="resourcePath">
		/// A <see cref="String"/> that specify the path used for including the include source string
		/// using GLSL #include preprocessor directive.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown is <paramref name="resourcePath"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="resourcePath"/> is not rooted (i.e. it doesn't start with '/' character), or if
		/// it specify a directory path (i.e. it ends with '/' character) or if its value contains invalid path
		/// characters ('\n', '\t', '"', '&lt;', or '&gt;').
		/// </exception>
		public ShaderInclude(string resourcePath)
		{
			if (resourcePath == null)
				throw new ArgumentNullException("path");
			if (resourcePath.StartsWith("/") == false)
				throw new ArgumentException("path not rooted", "path");
			if (resourcePath.EndsWith("/") == true)
				throw new ArgumentException("path has a trailing slash", "path");
			if (resourcePath.IndexOfAny(_InvalidPathChars) != -1)
				throw new ArgumentException(String.Format("path {0} contains invalid characters", resourcePath), "path");

			// Store include path
			_IncludePath = resourcePath;
		}

		/// <summary>
		/// Construct a ShaderInclude specifying its path and the relative source lines.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specify the path used for including the include source string
		/// using GLSL #include preprocessor directive.
		/// </param>
		/// <param name="source">
		/// A <see cref="IEnumerable{String}"/> that specify the shader include source text.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown is <paramref name="path"/> or <paramref name="source"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="path"/> is not rooted (i.e. it doesn't start with '/' character), or if
		/// it specify a directory path (i.e. it ends with '/' character) or if its value contains invalid path
		/// characters ('\n', '\t', '"', '&lt;', or '&gt;').
		/// </exception>
		public ShaderInclude(string path, IEnumerable<string> source) :
			this(path)
		{
			if (source == null)
				throw new ArgumentNullException("source");

			// Store include source
			_SourceStrings = new List<string>(source);
		}

		#endregion

		#region Source Loading

		/// <summary>
		/// Load the shader source from a stream.
		/// </summary>
		/// <param name="sourceStream">
		/// A <see cref="Stream"/>that holds the source lines.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown in the case <paramref name="sourceStream"/> is null.
		/// </exception>
		public void LoadSource(Stream sourceStream)
		{
			_SourceStrings = Shader.LoadSourceLines(sourceStream);
		}

		/// <summary>
		/// Load the shader source from an embedded resource
		/// </summary>
		/// <param name="resourcePath">
		/// A <see cref="String"/> that specify the embedded resource path.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="resourcePath"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if no embedded resource can be found.
		/// </exception>
		public void LoadSource(string resourcePath)
		{
			_SourceStrings = Shader.LoadSourceLines(resourcePath);
		}

		/// <summary>
		/// Load the shader include source from a string.
		/// </summary>
		/// <param name="sourceStrings">
		/// A <see cref="IEnumerator{String}"/> that specify the shader source strings.
		/// </param>
		public void LoadSource(IEnumerable<string> sourceStrings)
		{
			if (sourceStrings == null)
				throw new ArgumentNullException("sourceStrings");

			_SourceStrings = new List<string>(sourceStrings);
		}

		#endregion

		#region Shader Include

		/// <summary>
		/// Path used for including this ShaderInclude source string.
		/// </summary>
		public string IncludePath { get { return (_IncludePath); } }

		/// <summary>
		/// Path used for including this ShaderInclude source string.
		/// </summary>
		private readonly string _IncludePath;

		/// <summary>
		/// Invalid characters for path specification.
		/// </summary>
		private static readonly char[] _InvalidPathChars = new char[] {
			'\n', '\t', '"', '<', '>'
		};

		/// <summary>
		/// Include source strings.
		/// </summary>
		public virtual ICollection<string> Source
		{
			get
			{
				return (_SourceStrings.AsReadOnly());
			}
		}

		/// <summary>
		/// Include source strings.
		/// </summary>
		protected List<string> _SourceStrings;

		#endregion

		#region GraphicsResource Overrides

		/// <summary>
		/// Shader include object class.
		/// </summary>
		internal static readonly Guid ThisObjectClass = new Guid("2B402F5B-15D2-4D3A-9A42-42D4C61AD650");

		/// <summary>
		/// Shader include object class.
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
		/// It returns a boolean value indicating whether this object exists in the object space of <paramref name="ctx"/>.
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
			// Base implementation
			if (!base.Exists(ctx))
				return (false);

#if !MONODROID
			if (ctx.Extensions.ShadingLanguageInclude_ARB == true)
				return (Gl.IsNamedStringARB(IncludePath.Length, IncludePath));

			return (true);
#else
			return (false);
#endif
		}

		/// <summary>
		/// Determine whether this object requires a name bound to a context or not.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// It returns always false, since the named strings does not have an actual name.
		/// </returns>
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
#if !MONODROID
			CheckCurrentContext(ctx);

			if (ctx.Extensions.ShadingLanguageInclude_ARB) {
				List<string> source = Shader.CleanSource(Source);

				// Build include source string
				StringBuilder sb = new StringBuilder();
				foreach (string line in Source)
					sb.Append(line);

				// Create shader include
				Gl.NamedStringARB(Gl.SHADER_INCLUDE_ARB, -1, IncludePath, -1, sb.ToString());
			}
#endif
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

			// Base implementation
			base.Delete(ctx);
#if !MONODROID
			// Delete named string
			if (ctx.Extensions.ShadingLanguageInclude_ARB)
				Gl.DeleteNamedStringARB(-1, IncludePath);
#endif
		}

		#endregion
	}
}
