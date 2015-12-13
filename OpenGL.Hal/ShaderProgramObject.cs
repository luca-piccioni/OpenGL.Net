
// Copyright (C) 2009-2012 Luca Piccioni
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
using System.Xml.Serialization;

namespace OpenGL
{
	/// <summary>
	/// Utility structure to collect information for creating ShaderObject instances.
	/// </summary>
	[XmlType("ShaderProgramObject")]
	public class ShaderProgramObject : IEquatable<ShaderProgramObject>
	{
		#region Constructors

		/// <summary>
		/// Construct a ShaderProgramObject.
		/// </summary>
		public ShaderProgramObject()
			: this(String.Empty, null, ShaderObject.Stage.Vertex)
		{
			
		}

		/// <summary>
		/// Construct a ShaderProgramObject specifying directly the shader object instance.
		/// </summary>
		/// <param name="shader">
		/// The <see cref="ShaderObject"/> instance.
		/// </param>
		public ShaderProgramObject(ShaderObject shader)
		{
			if (shader == null)
				throw new ArgumentNullException("shader");

			Shader = shader;
		}

		/// <summary>
		/// Construct a ShaderProgramObject specifying directly the shader object instance and
		/// the interface implemented by the shader object.
		/// </summary>
		/// <param name="shader"></param>
		/// <param name="interface"></param>
		public ShaderProgramObject(ShaderObject shader, string @interface)
			: this(shader)
		{
			Interface = @interface;
		}

		/// <summary>
		/// Construct a ShaderProgramObject specifying the shader object library identifier, and
		/// the execution stage.
		/// </summary>
		/// <param name="identifier">
		/// A <see cref="System.String"/> that is the shader object library identifier.
		/// </param>
		/// <param name="stage">
		/// A <see cref="ShaderObject.Stage"/> that specify the execution stage of the shader object.
		/// </param>
		public ShaderProgramObject(string identifier, ShaderObject.Stage stage)
			: this(identifier, null, stage)
		{

		}

		/// <summary>
		/// Construct a ShaderProgramObject specifying the shader object library identifier, and
		/// the execution stage.
		/// </summary>
		/// <param name="identifier">
		/// A <see cref="System.String"/> that is the shader object library identifier.
		/// </param>
		/// <param name="interface">
		/// 
		/// </param>
		/// <param name="stage">
		/// A <see cref="ShaderObject.Stage"/> that specify the execution stage of the shader object.
		/// </param>
		public ShaderProgramObject(string identifier, string @interface, ShaderObject.Stage stage)
		{
			if (identifier == null)
				throw new ArgumentNullException("identifier");

			Id = identifier;
			Interface = @interface;
			Stage = stage;
		}

		#endregion

		#region Cached Shader Information

		/// <summary>
		/// Get the shader object.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating the shader object, if needed.
		/// </param>
		/// <param name="cctx">
		/// A <see cref="ShaderCompilerContext"/> that specify the compiler options for creating
		/// the shader object.
		/// </param>
		/// <returns></returns>
		public ShaderObject GetShaderObject(GraphicsContext ctx, ShaderCompilerContext cctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (cctx == null)
				throw new ArgumentNullException("cctx");

			if (Shader == null) {
				ShaderCacheService cacheService = ShaderCacheService.GetService(ctx);

				return (cacheService.CreateShaderObject(ctx, cctx, Id, Stage));
			} else {
				if ((Shader.ObjectNamespace != Guid.Empty) && (Shader.ObjectNamespace != ctx.ObjectNameSpace))
					throw new InvalidOperationException("shader object namespace mismatch with context namespace");

				return (Shader);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cctx"></param>
		/// <returns></returns>
		public string ComputeCompilerHash(ShaderCompilerContext cctx)
		{
			return (Shader == null ? (ShaderObject.ComputeCompilerHash(cctx, Id, Stage)) : (Shader.CompiledHash));
		}

		/// <summary>
		/// Shader object identifier.
		/// </summary>
		[XmlAttribute("Id")]
		public string Id { get { return (mId); } set { mId = value; } }

		/// <summary>
		/// Shader object stage.
		/// </summary>
		[XmlAttribute("Stage")]
		public ShaderObject.Stage Stage { get { return (mStage); } set { mStage = value; } }

		/// <summary>
		/// Cached shader object.
		/// </summary>
		[XmlIgnore]
		public ShaderObject Shader;

		/// <summary>
		/// Implemented interface by the shader object.
		/// </summary>
		public readonly string Interface;

		/// <summary>
		/// Shader object identifier.
		/// </summary>
		private string mId;

		/// <summary>
		/// Shader object stage.
		/// </summary>
		public ShaderObject.Stage mStage;

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static bool operator ==(ShaderProgramObject a, ShaderProgramObject b)
		{
			return (Equals(a, b));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static bool operator !=(ShaderProgramObject a, ShaderProgramObject b)
		{
			return (!Equals(a, b));
		}

		#endregion
		
		#region Logging

		/// <summary>
		/// Logger of this class.
		/// </summary>
		private static readonly ILogger sLog = Log.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion
		
		#region IEquatable<ShaderProgramObject> Implementation

		/// <summary>
		/// Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		/// <returns>
		/// true if the current object is equal to the other parameter; otherwise, false.
		/// </returns>
		/// <param name="other">An object to compare with this object.</param>
		public bool Equals(ShaderProgramObject other)
		{
			if (ReferenceEquals(null, other))
				return (false);
			if (ReferenceEquals(this, other))
				return (true);

			if (Shader == null && other.Shader == null) {
				if (Id != other.Id)
					return (false);
				if (Stage != other.Stage)
					return (false);

				// Interface is ignored

				return (true);
			} else
				return (ReferenceEquals(Shader, other.Shader));
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (ReferenceEquals(this, obj))
				return (true);
			if ((obj.GetType() != typeof(ShaderProgramObject)) && (obj.GetType().IsSubclassOf(typeof(ShaderProgramObject)) == false))
				return (false);

			return Equals((ShaderProgramObject)obj);
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for use in hashing
		/// algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = (Id != null ? Id.GetHashCode() : 0);

				result = (result * 397) ^ Stage.GetHashCode();

				result = (result * 397) ^ (Shader != null ? Shader.GetHashCode() : 0);

				return result;
			}
		}

		#endregion
	}
}
