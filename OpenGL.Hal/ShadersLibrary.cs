
// Copyright (C) 2015 Luca Piccioni
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
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace OpenGL
{
	/// <summary>
	/// Shaders library.
	/// </summary>
	[XmlRoot("ShadersLibrary")]
	public sealed class ShadersLibrary
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static ShadersLibrary()
		{
			// Load OpenGL.Hal shaders library
			Merge("OpenGL.Shaders.ShadersLibrary.xml");
		}

		#endregion

		#region Includes

		/// <summary>
		/// Shader object.
		/// </summary>
		[XmlType("Include")]
		public class Include
		{
			/// <summary>
			/// The path of the shader object source.
			/// </summary>
			[XmlAttribute("Id")]
			public string Id;

			/// <summary>
			/// Preprocessor symbols affecting the shader object compilation.
			/// </summary>
			[XmlElement("Path")]
			public string Path;
		}

		/// <summary>
		/// List of paths specifying shader include sources.
		/// </summary>
		[XmlArray("Includes")]
		[XmlArrayItem("Include")]
		public readonly List<Include> Includes = new List<Include>();

		#endregion

		#region Objects

		/// <summary>
		/// Shader object.
		/// </summary>
		[XmlType("Object")]
		public class Object
		{
			/// <summary>
			/// The path of the shader object source.
			/// </summary>
			[XmlAttribute("Path")]
			public string Path;

			/// <summary>
			/// Preprocessor symbols affecting the shader object compilation.
			/// </summary>
			[XmlArray("Symbols")]
			[XmlArrayItem("Symbol")]
			public readonly List<string> Symbols = new List<string>();
		}

		/// <summary>
		/// List of <see cref="Object"/> instances describing the available shader objects in library.
		/// </summary>
		[XmlArray("Objects")]
		[XmlArrayItem("Object")]
		public readonly List<Object> Objects = new List<Object>();

		#endregion

		#region Serialization

		/// <summary>
		/// Load a ShadersLibrary from a Stream.
		/// </summary>
		/// <param name="libraryStream">
		/// A <see cref="Stream"/> that reads a <see cref="ShadersLibrary"/> information.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ShadersLibrary"/> read from <paramref name="libraryStream"/>.
		/// </returns>
		private static ShadersLibrary Load(Stream libraryStream)
		{
			if (libraryStream == null)
				throw new ArgumentNullException("libraryStream");

			XmlSerializer xmlSerializer = new XmlSerializer(typeof(ShadersLibrary));

			return ((ShadersLibrary)xmlSerializer.Deserialize(libraryStream));
		}

		/// <summary>
		/// Load a ShadersLibrary from an embedded resource.
		/// </summary>
		/// <param name="resourcePath">
		/// A <see cref="String"/> that specifies the embedded resource path.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ShadersLibrary"/> read from <paramref name="resourcePath"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="resourcePath"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if no embedded resource can be found.
		/// </exception>
		private static ShadersLibrary Load(string resourcePath)
		{
			if (resourcePath == null)
				throw new ArgumentNullException("resourcePath");

			Assembly[] resourceAssemblies = new Assembly[] {
				Assembly.GetExecutingAssembly(),
				Assembly.GetCallingAssembly(),
				Assembly.GetEntryAssembly()
			};
			Stream resourceStream = null;

			try {
				for (int i = 0; i < resourceAssemblies.Length && resourceStream == null; i++) {
					if (resourceAssemblies[i] == null)
						continue;
					resourceStream = resourceAssemblies[i].GetManifestResourceStream(resourcePath);
				}

				if (resourceStream == null)
					throw new ArgumentException("resource path not found", "resourcePath");

				return (Load(resourceStream));
			} finally {
				if (resourceStream != null)
					resourceStream.Dispose();
			}
		}

		#endregion

		#region Singleton

		/// <summary>
		/// Get the only instance of <see cref="ShadersLibrary"/>.
		/// </summary>
		public static ShadersLibrary Instance
		{
			get
			{
				return (_ShadersLibrary);
			}
		}

		/// <summary>
		/// Merge a ShaderLibrary loaded from an embedded resource with <see cref="Instance"/>.
		/// </summary>
		/// <param name="resourcePath">
		/// A <see cref="String"/> that specifies the embedded resource path.
		/// </param>
		public static void Merge(string resourcePath)
		{
			ShadersLibrary embeddedShadersLibrary = Load(resourcePath);

			// Merge information
			_ShadersLibrary.Includes.AddRange(embeddedShadersLibrary.Includes);
			_ShadersLibrary.Objects.AddRange(embeddedShadersLibrary.Objects);
		}

		/// <summary>
		/// The reference instance of <see cref="ShadersLibrary"/>.
		/// </summary>
		private static readonly ShadersLibrary _ShadersLibrary = new ShadersLibrary();

		#endregion
	}
}
