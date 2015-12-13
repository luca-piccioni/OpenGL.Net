
// Copyright (c) 2013 Luca Piccioni
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

namespace OpenGL
{
	/// <summary>
	/// Shader include library.
	/// </summary>
	class ShaderIncludeLibrary : GraphicsResource
	{
		#region Constructors
		
		public ShaderIncludeLibrary()
		{
			foreach (Type shaderIncludeType in ShaderLibrary.sIncludeLibrary) {
				IShaderInclude shaderInclude = (IShaderInclude)Activator.CreateInstance(shaderIncludeType);
				mIncludeSourceTree[shaderInclude.IncludePath] = shaderInclude;
			}
		}
		
		#endregion
		
		#region Shader Include Collection
		
		public bool IsPathDefined(string path)
		{
			return (mIncludeSourceTree.ContainsKey(path));
		}
		
		public IShaderInclude GetInclude(string path)
		{
			return (mIncludeSourceTree[path]);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public IEnumerable<string> GetIncludeTree()
		{
			List<string> treePaths = new List<string>(mIncludeSourceTree.Keys.Count);

			foreach (string key in mIncludeSourceTree.Keys)
				treePaths.Add(key);
			treePaths.Sort();

			return (treePaths);
		}
		
		/// <summary>
		/// Map between paths and include source strings.
		/// </summary>
		private readonly Dictionary<string, IShaderInclude> mIncludeSourceTree = new Dictionary<string,IShaderInclude>();
		
		#endregion
		
		#region GraphicsResource Overrides
		
		/// <summary>
		/// Shader include object class.
		/// </summary>
		internal static readonly Guid ShaderIncludeLibraryObjectClass = new Guid("2B702F5B-15D2-453A-9A42-4212C61AD650");

		/// <summary>
		/// Shader include object class.
		/// </summary>
		public override Guid ObjectClass { get { return (ShaderIncludeLibraryObjectClass); } }
		
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
			return (false);
		}
		
		/// <summary>
		/// Actually create this GraphicsResource resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void CreateObject(GraphicsContext ctx)
		{
			foreach (IShaderInclude shaderInclude in mIncludeSourceTree.Values)
				shaderInclude.Create(ctx);
		}
		
		/// <summary>
		/// Delete this GraphicsResource.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for deleting this object. The IRenderResource shall belong to the object space to this
		/// <see cref="GraphicsContext"/>. The <see cref="GraphicsContext"/> shall be current to the calling thread.
		/// </param>
		/// <remarks>
		/// <para>
		/// After this method, the resource must have deallocated every graphic resource associated with it. Normally it should be possible
		/// to create again the resources by calling <see cref="Create"/>.
		/// </para>
		/// <para>
		/// This methods shall be the preferred way to deallocate graphic resources.
		/// </para>
		/// <para>
		/// After a successfull call to Create, <see cref="Exists"/> shall return true.
		/// </para>
		/// <para>
		/// The actual implementation deletes the name (<see cref="DeleteName"/>) only if the implementation requires a context related name
		/// (<see cref="RequiresName"/>). In the case derived classes requires more complex resource deletion pattern, this method could
		/// be overriden for that purpose, paying attention to call the base implementation.
		/// </para>
		/// </remarks>
		/// <seealso cref="Create"/>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current to the calling thread.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if this object doesn't exists for <paramref name="ctx"/> (this is determined by calling <see cref="Exists"/>
		/// method), or this resource has a name and <paramref name="ctx"/> is not current to the calling thread.
		/// </exception>
		public override void Delete(GraphicsContext ctx)
		{
			foreach (IShaderInclude shaderInclude in mIncludeSourceTree.Values)
				shaderInclude.Delete(ctx);
			
			// Base implementation
			base.Delete(ctx);
		}
		
		#endregion
	}
}

