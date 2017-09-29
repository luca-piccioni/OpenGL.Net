
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
using System.Text.RegularExpressions;
using System.Xml.Serialization;

using Khronos;

namespace OpenGL.Objects
{
	/// <summary>
	/// Shader compiler parameters abstraction..
	/// </summary>
	/// <remarks>
	/// <para>
	/// This class shall group all elements which influence the compilation process:
	/// - Shading Language version
	/// - Preprocessor symbols (i.e. #define statements)
	/// - Preprocessor include paths
	/// - Extension directives (i.e. #extension statements)
	/// - Feedback buffer format
	/// </para>
	/// </remarks>
	[XmlType("ShaderCompilerContext")]
	public class ShaderCompilerContext : IEquatable<ShaderCompilerContext>
	{
		#region Constructors

		/// <summary>
		/// Default compilation context.
		/// </summary>
		public ShaderCompilerContext() : this(Gl.CurrentShadingVersion, null)
		{

		}

		/// <summary>
		/// Default compilation context.
		/// </summary>
		/// <param name="defines">
		/// The list of preprocessor definitions included in each shader source.
		/// </param>
		public ShaderCompilerContext(params string[] defines) : this(Gl.CurrentShadingVersion, defines)
		{

		}

		/// <summary>
		/// Compilation context that specify GLSL version and preprocessor definitions.
		/// </summary>
		/// <param name="version">
		/// The <see cref="KhronosVersion"/> used for shader object compilation.
		/// </param>
		/// <param name="defines">
		/// The list of preprocessor definitions included in each shader source.
		/// </param>
		public ShaderCompilerContext(KhronosVersion version, params string[] defines)
		{
			_ShaderVersion = version;

			if (defines != null) {
				_Define = new List<string>(defines);
				_Define.Sort();
			}
		}

		/// <summary>
		/// Copy another compilation context.
		/// </summary>
		/// <param name="otherCompilerContext">
		/// The <see cref="ShaderCompilerContext"/> to be copied into in this instance.
		/// </param>
		public ShaderCompilerContext(ShaderCompilerContext otherCompilerContext)
		{
			if (otherCompilerContext == null)
				throw new ArgumentNullException("otherCompilerContext");

			_ShaderVersion = otherCompilerContext._ShaderVersion;
			_Define = new List<string>(otherCompilerContext._Define);
			Extensions = new List<ShaderExtension>(otherCompilerContext.Extensions);
			_Includes = new List<string>(otherCompilerContext._Includes);
			_FeedbackVaryingsFormat = otherCompilerContext._FeedbackVaryingsFormat;
		}

		#endregion

		#region Compiler Parameters

		#region Shading Language Version

		/// <summary>
		/// The shading language version used by compiler.
		/// </summary>
		/// <remarks>
		/// If the property is set to null, the property will be defined as <see cref="GraphicsContext.CurrentGLSLVersion"/>. In this way the
		/// value of this property will always specify a concrete GLSL version value.
		/// </remarks>
		[XmlElement("ShaderVersion")]
		public KhronosVersion ShaderVersion
		{
			get { return (_ShaderVersion); }
			set
			{
				_ShaderVersion = value == null ? Gl.CurrentShadingVersion : value;
			}
		}

		/// <summary>
		/// The shading language version used by compiler.
		/// </summary>
		private KhronosVersion _ShaderVersion;

		#endregion

		#region Preprocessor Symbols

		/// <summary>
		/// #define preprocessor directives used for compilation.
		/// </summary>
		[XmlElement("PreprocessorSymbol")]
		public List<string> Defines
		{
			get { return (_Define); }
			set
			{
				_Define.Clear();
				_Define.AddRange(value);
			}
		}

		/// <summary>
		/// #define preprocessor directives used for compilation.
		/// </summary>
		private readonly List<string> _Define = new List<string>();

		#endregion

		#region Preprocessor Include Paths

		/// <summary>
		/// Set the include paths.
		/// </summary>
		/// <param name="paths">
		/// An ordered string collection that specify the list of the paths used
		/// for resolving shader inclusion by usinh <i>#include</i> preprocessor directive.
		/// </param>
		/// <remarks>
		/// This method reset the entire include path used by compiler.
		/// </remarks>
		public void SetIncludePaths(IEnumerable<string> paths)
		{
			if (paths == null)
				throw new ArgumentNullException("paths");

			_Includes.Clear();
			foreach (string path in paths) {
				if (String.IsNullOrEmpty(path) == true)
					throw new ArgumentException("invalid path", "paths");
				_Includes.Add(path);
			}
		}

		/// <summary>
		/// Ordered paths for relative #include preprocessor directives.
		/// </summary>
		public ICollection<string> Includes { get { return (_Includes.AsReadOnly()); } }

		/// <summary>
		/// Ordered paths for relative #include preprocessor directives.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		private readonly List<string> _Includes = new List<string>();

		#endregion

		#region Common Extension Behavior

		/// <summary>
		/// The extensions behavior used for compiling a <see cref="ShaderProgram"/>.
		/// </summary>
		/// <remarks>
		/// This property determine the default extension behavior for each object attached to
		/// a <see cref="ShaderProgram"/>; however, each <see cref="Shader"/> can override
		/// the behavior for its compilation.
		/// </remarks>
		public readonly List<ShaderExtension> Extensions = new List<ShaderExtension>();
		
		#endregion
		
		#region Various

		/// <summary>
		/// Get/set the feedback varyings format.
		/// </summary>
		public FeedbackBufferFormat FeedbackVaryingsFormat
		{
			get { return (_FeedbackVaryingsFormat); }
			set { _FeedbackVaryingsFormat = value; }
		}

		/// <summary>
		/// The feedback varyings format.
		/// </summary>
		private FeedbackBufferFormat _FeedbackVaryingsFormat = FeedbackBufferFormat.Interleaved;

		#endregion

		#endregion

		#region Merge

		public void Merge(ShaderCompilerContext cctx)
		{
			if (cctx == null)
				throw new ArgumentNullException("cctx");

			foreach (string symbol in cctx.Defines) {
				if (Defines.Contains(symbol) == false)
					Defines.Add(symbol);
			}
			Defines.Sort();
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Test for equality two <see cref="ShaderCompilerContext"/> instances.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static bool operator ==(ShaderCompilerContext a, ShaderCompilerContext b)
		{
			if (ReferenceEquals(null, b))
				return (false);

			return (a.Equals(b));
		}

		public static bool operator !=(ShaderCompilerContext a, ShaderCompilerContext b)
		{
			return (a.Equals(b));
		}

		#endregion

		#region IEquatable<ShaderCompilerContext> Implementation

		/// <summary>
		/// Indicates whether the this Matrix is equal to another Matrix.
		/// </summary>
		/// <param name="other">
		/// A ShaderCompilerContext to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this Matrix is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(ShaderCompilerContext other)
		{
			if (ReferenceEquals(null, other))
				return (false);
			if (ReferenceEquals(this, other))
				return (true);

			// Compare shading language version
			if (ShaderVersion != other.ShaderVersion)
				return (false);

			// Compare preprocessor definitions (order independent)
			if (Defines.Count != other.Defines.Count)
				return (false);
			foreach (string defineSymbol in Defines)
				if (other.Defines.Contains(defineSymbol) == false)
					return (false);

			// Compare preprocessor includes (order dependent)
			if (Includes.Count != other.Includes.Count)
				return (false);
			for (int i = 0; i < _Includes.Count; i++)
				if (_Includes[i] != other._Includes[i])
					return (false);

			// Feedback varying format
			if (_FeedbackVaryingsFormat != other._FeedbackVaryingsFormat)
				return (false);

			return (true);
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
			if ((obj.GetType() != typeof(ShaderCompilerContext)) && (obj.GetType().IsSubclassOf(typeof(ShaderCompilerContext)) == false))
				return (false);

			return (Equals((ShaderCompilerContext)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = ShaderVersion.GetHashCode();

				foreach (string define in Defines)
					result = (result * 397) ^ define.GetHashCode();

				return result;
			}
		}

		#endregion
	}
}
