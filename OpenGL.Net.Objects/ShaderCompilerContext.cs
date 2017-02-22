
// Copyright (C) 2011-2016 Luca Piccioni
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
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

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
		/// Set a preprocessor symbol controlling the shader compilation.
		/// </summary>
		/// <param name="def">
		/// A <see cref="String"/> representing the symbol string. This string will be
		/// presented after a <i>#define</i> preprocessor directive (i.e. "SYMBOL 1").
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="def"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if the parameter <paramref name="def"/> does not define a symbol
		/// name (i.e. an empty string) or if <paramref name="def"/> defines a symbol already defined.
		/// </exception>
		public void DefineSymbol(string def)
		{
			if (def == null)
				throw new ArgumentNullException("def");

			string symbol = GetDefineSymbol(def);

			if (IsDefinedSymbol(symbol))
				throw new ArgumentException(String.Format("symbol '{0}' already defined", symbol), "def");

			// Set symbol
			_Define.Add(def);
		}

		/// <summary>
		/// Set a preprocessor symbol controlling the shader compilation.
		/// </summary>
		/// <param name="def">
		/// A <see cref="String"/> representing the symbol string. This string will be
		/// presented after a <i>#define</i> preprocessor directive (i.e. "SYMBOL 1").
		/// </param>
		/// <param name="override">
		/// A <see cref="Boolean"/> indicating whether <paramref name="def"/> shall override
		/// the already registered symbol, if any.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="def"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if the parameter <paramref name="def"/> does not define a symbol
		/// name (i.e. an empty string) or if <paramref name="def"/> defines a symbol already defined.
		/// </exception>
		public void DefineSymbol(string def, bool @override)
		{
			// Override symbol
			if (@override) {
				string symbol = GetDefineSymbol(def);

				if (IsDefinedSymbol(symbol))
					RemoveSymbol(symbol);
			}

			DefineSymbol(def);
		}

		/// <summary>
		/// Check whether a specific preprocessor symbol is defined.
		/// </summary>
		/// <param name="symbol">
		/// A <see cref="String"/> representing the symbol string. Only the first token of the symbol
		/// has to be specified.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="symbol"/> is defined or not.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="symbol"/> is null.
		/// </exception>
		public bool IsDefinedSymbol(string symbol)
		{
			if (symbol == null)
				throw new ArgumentNullException("symbol");

			return (_Define.Exists(delegate(string item) { return (Regex.IsMatch(item, String.Format(@"{0}(\s+|\(|$)", symbol))); }));
		}

		public string GetSymbol(string symbol)
		{
			if (symbol == null)
				throw new ArgumentNullException("symbol");

			return (_Define.Find(delegate(string item) { return (Regex.IsMatch(item, String.Format(@"{0}(\s+|\(|$)", symbol))); }));
		}

		/// <summary>
		/// Remove a symbol definition.
		/// </summary>
		/// <param name="symbol">
		/// A <see cref="String"/> representing the symbol string. Only the first token of the symbol
		/// has to be specified.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="symbol"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if the parameter <paramref name="symbol"/> is not defined.
		/// </exception>
		public void RemoveSymbol(string symbol)
		{
			if (symbol == null)
				throw new ArgumentNullException("symbol");

			int symbolIndex = _Define.FindIndex(delegate(string item) { return (Regex.IsMatch(item, String.Format(@"{0}(\s+|\(|$)", symbol))); });

			if (symbolIndex < 0)
				throw new ArgumentException("not defined", "symbol");

			_Define.RemoveAt(symbolIndex);
		}

		/// <summary>
		/// Remove all symbols definition.
		/// </summary>
		public void RemoveSymbols()
		{
			_Define.Clear();
		}

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

		private static string GetDefineSymbol(string define)
		{
			if (define == null)
				throw new ArgumentNullException("define");

			string[] defTokens = define.Split(new char[] { ' ', '\t', '(' }, StringSplitOptions.RemoveEmptyEntries);

			if (defTokens.Length <= 0)
				throw new ArgumentException(String.Format("invalid value '{0}'", define), "define");

			return (defTokens[0]);
		}

		/// <summary>
		/// #define preprocessor directives used for compilation.
		/// </summary>
		/// <remarks>
		/// <para>
		/// The list has to be sorted for being independent on symbols order. This is mandatory for
		/// managing shaders caching.
		/// </para>
		/// <para>
		/// This imply that the symbol
		/// </para>
		/// </remarks>
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
		/// a <see cref="ShaderProgram"/>; however, each <see cref="ShaderObject"/> can override
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
