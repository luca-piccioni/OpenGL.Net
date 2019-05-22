
// Copyright (C) 2013-2017 Luca Piccioni
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
	/// Shader include library.
	/// </summary>
	internal sealed class ShaderIncludeLibrary : GraphicsResource
	{
		#region Constructors

		/// <summary>
		/// Construct a ShaderIncludeLibrary.
		/// </summary>
		public ShaderIncludeLibrary()
		{
			// Load all include files defined by OpenGL.Net.Objects
			// Note: includes are meant to be usable by external users
			MergeLibrary(ShadersLibrary.Instance);
		}

		#endregion

		#region Shader Include Collection

		public void MergeLibrary(ShadersLibrary shadersLibrary)
		{
			if (shadersLibrary == null)
				throw new ArgumentNullException(nameof(shadersLibrary));

			if (shadersLibrary.Includes == null)
				return;

			foreach (ShadersLibrary.Include shaderLibraryInclude in shadersLibrary.Includes) {
				if (_IncludeFileSystem.ContainsKey(shaderLibraryInclude.Path))
					throw new InvalidOperationException(String.Format("include path '{0}' is duplicated", shaderLibraryInclude.Path));

				ShaderInclude shaderInclude;

				LinkResource(shaderInclude = new ShaderInclude(shaderLibraryInclude.Path));

				shaderInclude.LoadSource(shaderLibraryInclude.Resource);

				_IncludeFileSystem.Add(shaderInclude.IncludePath, shaderInclude);
			}
		}

		/// <summary>
		/// Determine whether an include source have a specific path.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specify an include file path.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="path"/> specify an include file.
		/// </returns>
		public bool IsPathDefined(string path)
		{
			return _IncludeFileSystem.ContainsKey(path);
		}
		
		public ShaderInclude GetInclude(string path)
		{
			return _IncludeFileSystem[path];
		}
		
		/// <summary>
		/// Map between paths and include source strings.
		/// </summary>
		private readonly Dictionary<string, ShaderInclude> _IncludeFileSystem = new Dictionary<string, ShaderInclude>();
		
		#endregion
		
		#region Overrides
		
		/// <summary>
		/// Shader include object class.
		/// </summary>
		internal static readonly Guid ThisObjectClass = new Guid("2B702F5B-15D2-453A-9A42-4212C61AD650");

		/// <summary>
		/// Shader include object class.
		/// </summary>
		public override Guid ObjectClass { get { return (ThisObjectClass); } }
		
		/// <summary>
		/// Determine whether this object requires a name bound to a context or not.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// <para>
		/// This implementation returns always false.
		/// </para>
		/// </returns>
		protected override bool RequiresName(GraphicsContext ctx)
		{
			return false;
		}
		
		/// <summary>
		/// Actually create this GraphicsResource resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void CreateObject(GraphicsContext ctx)
		{
			foreach (ShaderInclude shaderInclude in _IncludeFileSystem.Values)
				shaderInclude.Create(ctx);
		}

		#endregion
	}
}

