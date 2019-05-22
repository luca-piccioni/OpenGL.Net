
// Copyright (C) 2015-2019 Luca Piccioni
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
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace OpenGL.Objects
{
	/// <summary>
	/// Shaders library.
	/// </summary>
	[DataContract(Name = "ShadersLibrary")]
	internal sealed class ShadersLibrary
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static ShadersLibrary()
		{
			// Load OpenGL.Objects shaders library
			Instance.Merge("OpenGL.Objects.Shaders._ShadersLibrary.xml");
			Instance.Merge("OpenGL.Objects.Shaders.Light._ShadersLibrary.xml");
			Instance.Merge("OpenGL.Objects.Shaders.Standard._ShadersLibrary.xml");
			Instance.Merge("OpenGL.Objects.Shaders.Font._ShadersLibrary.xml");

			//Merge("OpenGL.Objects.Shaders.Specialized._ShadersLibrary.xml");
			//Merge("OpenGL.Objects.Shaders.Shadow._ShadersLibrary.xml");
			//Merge("OpenGL.Objects.Shaders.Skybox._ShadersLibrary.xml");
		}

		#endregion

		#region Includes

		/// <summary>
		/// Shader include object.
		/// </summary>
		[DataContract(Name = "Include")]
		[DebuggerDisplay("Include: Path={Path} Resource={Resource}")]
		public class Include
		{
			/// <summary>
			/// The path of the shader object source.
			/// </summary>
			[DataMember(Name = "Path", IsRequired = true, Order = 1)]
			public string Path;

			/// <summary>
			/// Preprocessor symbols affecting the shader object compilation.
			/// </summary>
			[DataMember(Name = "Resource", IsRequired = true, Order = 2)]
			public string Resource;
		}

		/// <summary>
		/// List of paths specifying shader include sources.
		/// </summary>
		[DataMember(Name = "Includes")]
		public List<Include> Includes;

		#endregion

		#region Objects

		/// <summary>
		/// Utility class for serializing shader object symbol list.
		/// </summary>
		[CollectionDataContract(ItemName = "Symbol")]
		public class SymbolList : List<string>
		{
			public SymbolList() { }

			public SymbolList(IEnumerable<string> items) : base(items) { }
		}

		/// <summary>
		/// Shader object.
		/// </summary>
		[DataContract(Name = "Object")]
		[DebuggerDisplay("Object: Resource={Resource} Stage={Stage}")]
		public class Object
		{
			/// <summary>
			/// The path of the shader object source.
			/// </summary>
			[DataMember(Name = "Resource", IsRequired = true, Order = 1)]
			public string Resource;

			/// <summary>
			/// Shader object stage. Meaninful only if used under /ShadersLibrary/Programs.
			/// </summary>
			[DataMember(Name = "Stage", Order = 2)]
			public ShaderType Stage = ShaderType.VertexShader;

			/// <summary>
			/// Shader object stages used for testing compilation. Multiple stages are specified by
			/// separating with spaces stage identifiers (<see cref="ShaderType"/>).
			/// </summary>
			[DataMember(Name = "TestStage", Order = 3)]
			public string TestStage;

			/// <summary>
			/// Shader object stages used for testing compilation.
			/// </summary>
			public IEnumerable<ShaderType> Stages
			{
				get
				{
					if (TestStage != null) {
						string[] stages = TestStage.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

						foreach (string stage in stages)
							yield return (ShaderType)Enum.Parse(typeof(ShaderType), stage);
					} else
						yield return Stage;
				}
			}

			/// <summary>
			/// Preprocessor symbols affecting the shader object compilation.
			/// </summary>
			[DataMember(Name = "Symbols")]
			public SymbolList Symbols;

			/// <summary>
			/// Create a shader object from this Object.
			/// </summary>
			/// <returns></returns>
			public Shader Create()
			{
				return Create(Stage);
			}

			/// <summary>
			/// Create a shader object from this Object.
			/// </summary>
			/// <returns></returns>
			public Shader Create(ShaderType stage)
			{
				Shader shaderObject = new Shader(stage);

				// Load source
				shaderObject.LoadSource(Resource);

				return shaderObject;
			}

			/// <summary>
			/// 
			/// </summary>
			/// <param name="cctx"></param>
			/// <returns></returns>
			internal void GetHashInfo(StringBuilder hashMessage, ShaderCompilerContext cctx)
			{
				if (hashMessage == null)
					throw new ArgumentNullException(nameof(hashMessage));

				// Shaders can be compiled at different stages
				hashMessage.Append(Stage);
				// All symbols known for this shader are included
				foreach (string define in cctx.Defines) {
					if (Symbols.Contains(define) == false)
						continue;
					hashMessage.Append(define);
				}
			}
		}

		/// <summary>
		/// List of <see cref="Object"/> instances describing the available shader objects in library.
		/// </summary>
		[DataMember(Name = "Objects")]
		public List<Object> Objects;

		/// <summary>
		/// Get the definition of a object.
		/// </summary>
		/// <param name="objectId">
		/// A <see cref="string"/> that specifies the object identifier.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Object"/> describing the object identified with <paramref name="objectId"/>, or null if not found.
		/// </returns>
		public Object GetObject(string objectId)
		{
			if (objectId == null)
				throw new ArgumentNullException(nameof(objectId));

			return Objects?.Find((item) => { return item.Resource == objectId; });
		}

		#endregion

		#region Programs

		/// <summary>
		/// Shader program tag.
		/// </summary>
		public class ProgramTag
		{
			/// <summary>
			/// Create a ProgramTag from a <see cref="Program"/>.
			/// </summary>
			/// <param name="program">
			/// The <see cref="Program"/> that specifies how to build the shader.
			/// </param>
			internal ProgramTag(Program program)
			{
				if (program == null)
					throw new ArgumentNullException("program");

				Id = program.Id;
				CompilerContext = program.GetCompilerContext();
			}

			/// <summary>
			/// Create a ProgramTag from a <see cref="Program"/>.
			/// </summary>
			/// <param name="program">
			/// The <see cref="Program"/> that specifies how to build the shader.
			/// </param>
			internal ProgramTag(Program program, ShaderCompilerContext cctx) : this(program)
			{
				if (cctx == null)
					throw new ArgumentNullException("cctx");

				CompilerContext.Merge(cctx);
			}

			/// <summary>
			/// The program identifier.
			/// </summary>
			public readonly string Id;

			/// <summary>
			/// Shader compiler paramaters.
			/// </summary>
			public ShaderCompilerContext CompilerContext;
		}

		/// <summary>
		/// Shader program attribute.
		/// </summary>
		[DataContract(Name = "Attribute")]
		[DebuggerDisplay("Attribute: Name={Name} Semantic={Semantic} Location={Location}")]
		public class Attribute
		{
			/// <summary>
			/// Attribute name.
			/// </summary>
			[DataMember(Name = "Name", IsRequired = true, Order = 1)]
			public string Name;

			/// <summary>
			/// Attribute semantic.
			/// </summary>
			[DataMember(Name = "Semantic", Order = 2)]
			public string Semantic;

			/// <summary>
			/// Attribute location.
			/// </summary>
			[DataMember(Name = "Location", EmitDefaultValue = false, Order = 3)]
			public int Location = -1;

			/// <summary>
			/// Utility for setting default values on deserialization.
			/// </summary>
			/// <param name="context">
			/// The <see cref="StreamingContext"/> of the deserializer.
			/// </param>
			[OnDeserializing]
			private void OnDeserializing(StreamingContext context)
			{
				Location = -1;
			}
		}

		/// <summary>
		/// Shader program uniform.
		/// </summary>
		[DataContract(Name = "Uniform")]
		[DebuggerDisplay("Uniform: Name={Name} Semantic={Semantic}")]
		public class Uniform
		{
			/// <summary>
			/// Uniform name.
			/// </summary>
			[DataMember(Name = "Name", IsRequired = true, Order = 1)]
			public string Name;

			/// <summary>
			/// Uniform semantic.
			/// </summary>
			[DataMember(Name = "Semantic", Order = 2)]
			public string Semantic;
		}

		/// <summary>
		/// Shader program.
		/// </summary>
		[DataContract(Name = "Program")]
		[DebuggerDisplay("Program: Id={Id}")]
		public class Program
		{
			/// <summary>
			/// The identifier of the shader program.
			/// </summary>
			[DataMember(Name = "Id", IsRequired = true, Order = 1)]
			public string Id;

			/// <summary>
			/// Object linked to this shader program.
			/// </summary>
			[DataMember(Name = "Objects", IsRequired = true, Order = 2)]
			public List<Object> Objects;

			/// <summary>
			/// Active attributes.
			/// </summary>
			[DataMember(Name = "Attributes", Order = 3)]
			public List<Attribute> Attributes;

			/// <summary>
			/// Active uniforms.
			/// </summary>
			[DataMember(Name = "Uniforms", Order = 4)]
			public List<Uniform> Uniforms;

			/// <summary>
			/// GLSL extensions.
			/// </summary>
			[DataMember(Name = "Extensions", Order = 5)]
			public List<ShaderExtension> Extensions;

			/// <summary>
			/// Create a program from this Program.
			/// </summary>
			/// <returns></returns>
			public ShaderProgram Create()
			{
				return Create(GetCompilerContext());
			}

			/// <summary>
			/// Create a program from this Program.
			/// </summary>
			/// <param name="cctx"></param>
			/// <returns></returns>
			public ShaderProgram Create(ShaderCompilerContext cctx)
			{
				if (string.IsNullOrEmpty(Id))
					throw new InvalidOperationException("invalid program identifier");
				if (cctx == null)
					throw new ArgumentNullException("cctx");

				ShaderProgram shaderProgram = new ShaderProgram(Id);

				// Attach required objects
				if (Objects != null)
					foreach (Object shaderProgramObject in Objects) {
						Shader shaderObject = new Shader(shaderProgramObject.Stage);

						// Load source
						shaderObject.LoadSource(shaderProgramObject.Resource);
						// Attach object
						shaderProgram.Attach(shaderObject);
					}

				// Register attributes semantic
				if (Attributes != null)
					foreach (Attribute attribute in Attributes) {
						shaderProgram.SetAttributeSemantic(attribute.Name, attribute.Semantic);
						if (attribute.Location >= 0)
							shaderProgram.SetAttributeLocation(attribute.Name, attribute.Location);
					}
					
				// Register uniforms semantic
				if (Uniforms != null)
					foreach (Uniform uniform in Uniforms)
						shaderProgram.SetUniformSemantic(uniform.Name, uniform.Semantic);

				shaderProgram.Create(cctx);

				return shaderProgram;
			}

			public ShaderCompilerContext GetCompilerContext()
			{
				ShaderCompilerContext shaderCompilerParams = new ShaderCompilerContext();

				// Preprocessor symbols
				foreach (Object shaderProgramObject in Objects) {
					if (shaderProgramObject.Symbols != null)
						foreach (string preprocessorSymbol in shaderProgramObject.Symbols)
							shaderCompilerParams.Defines.Add(preprocessorSymbol);
				}

				// Shader extensions
				if (Extensions != null)
					shaderCompilerParams.Extensions.AddRange(Extensions);

				return shaderCompilerParams;
			}

			/// <summary>
			/// 
			/// </summary>
			/// <param name="cctx"></param>
			/// <returns></returns>
			public string GetHashInfo(ShaderCompilerContext cctx)
			{
				StringBuilder hashMessage = new StringBuilder();

				// Take into account the shader program name
				hashMessage.Append(Id);

				// Objects hash
				if (Objects != null) {
					foreach (Object programObject in Objects)
						programObject.GetHashInfo(hashMessage, cctx);
				}

				// Compilation parameters (common to all shaders?)
				hashMessage.Append(cctx.ShaderVersion);

				if (cctx.Includes != null) {
					foreach (string includePath in cctx.Includes)
						hashMessage.Append(includePath);
				}

				hashMessage.Append(cctx.FeedbackVaryingsFormat);

				return (hashMessage.ToString());
			}
		}

		/// <summary>
		/// List of <see cref="Program"/> instances describing the available shader programs in library.
		/// </summary>
		[DataMember(Name = "Programs")]
		public List<Program> Programs;

		/// <summary>
		/// Get the programs identifier available in this ShaderLibrary.
		/// </summary>
		public ICollection<string> GetPrograms()
		{
			return Programs.ConvertAll(item => item.Id).ToArray();
		}

		/// <summary>
		/// Get the definition of a program.
		/// </summary>
		/// <param name="programId">
		/// A <see cref="string"/> that specifies the program identifier.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Program"/> describing the program identified with <paramref name="programId"/>.
		/// </returns>
		public Program GetProgram(string programId)
		{
			if (programId == null)
				throw new ArgumentNullException("programId");

			return (Programs.Find(delegate(Program item) { return (item.Id == programId); }));
		}

		/// <summary>
		/// Create a <see cref="ProgramTag"/> used for creating (lazily) a <see cref="ShaderProgram"/>.
		/// </summary>
		/// <param name="programId">
		/// A <see cref="string"/> that specifies the program identifier.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ProgramTag"/> for creating the program identified with <paramref name="programId"/>.
		/// </returns>
		public ProgramTag CreateProgramTag(string programId)
		{
			Program libraryProgram = GetProgram(programId);
			if (libraryProgram == null)
				throw new ArgumentException("no program with such identifier", "programId");

			return (new ProgramTag(libraryProgram));
		}

		/// <summary>
		/// Create a <see cref="ProgramTag"/> used for creating (lazily) a <see cref="ShaderProgram"/>.
		/// </summary>
		/// <param name="programId">
		/// A <see cref="string"/> that specifies the program identifier.
		/// </param>
		/// <param name="cctx">
		/// A <see cref="ShaderCompilerContext"/> that specifies *additional* parameters to be applied/merged to the default
		/// compiler parameters.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ProgramTag"/> for creating the program identified with <paramref name="programId"/>.
		/// </returns>
		public ProgramTag CreateProgramTag(string programId, ShaderCompilerContext cctx)
		{
			Program libraryProgram = GetProgram(programId);
			if (libraryProgram == null)
				throw new ArgumentException("no program with such identifier", "programId");

			return (new ProgramTag(libraryProgram, cctx));
		}

		/// <summary>
		/// Create a <see cref="ProgramTag"/> used for creating (lazily) a <see cref="ShaderProgram"/>.
		/// </summary>
		/// <param name="programId">
		/// A <see cref="string"/> that specifies the program identifier.
		/// </param>
		/// <param name="cctx">
		/// A <see cref="ShaderCompilerContext"/> that specifies *additional* parameters to be applied/merged to the default
		/// compiler parameters.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ProgramTag"/> for creating the program identified with <paramref name="programId"/>.
		/// </returns>
		public ProgramTag CreateProgramTag(string programId, params string[] defines)
		{
			Program libraryProgram = GetProgram(programId);
			if (libraryProgram == null)
				throw new ArgumentException("no program with such identifier", "programId");

			return (new ProgramTag(libraryProgram, new ShaderCompilerContext(defines)));
		}

		#endregion

		#region Serialization

		/// <summary>
		/// Load a ShadersLibrary from a Stream.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="Stream"/> that reads a <see cref="ShadersLibrary"/> information.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ShadersLibrary"/> read from <paramref name="stream"/>.
		/// </returns>
		public static ShadersLibrary Load(Stream stream)
		{
			if (stream == null)
				throw new ArgumentNullException(nameof(stream));

			using (XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(stream, new XmlDictionaryReaderQuotas())) {
				return (ShadersLibrary)_Serializer.ReadObject(reader, true);
			}
		}

		/// <summary>
		/// Save this ShadersLibrary to a Stream.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="Stream"/> that reads a <see cref="ShadersLibrary"/> information.
		/// </param>
		public void Save(Stream stream)
		{
			if (stream == null)
				throw new ArgumentNullException(nameof(stream));

			using (XmlDictionaryWriter writer = XmlDictionaryWriter.CreateTextWriter(stream, Encoding.UTF8)) {
				_Serializer.WriteObject(writer, this);
			}
		}

		/// <summary>
		/// The ShadersLibrary serialized.
		/// </summary>
		private static readonly DataContractSerializer _Serializer = new DataContractSerializer(typeof(ShadersLibrary));

		/// <summary>
		/// Load a ShadersLibrary from an embedded resource.
		/// </summary>
		/// <param name="resourcePath">
		/// A <see cref="string"/> that specify the embedded resource path.
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
		public static ShadersLibrary Load(string resourcePath)
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
				return _ShadersLibrary;
			}
		}

		/// <summary>
		/// Merge a ShaderLibrary loaded from an embedded resource with <see cref="Instance"/>.
		/// </summary>
		/// <param name="resourcePath">
		/// A <see cref="string"/> that specify the embedded resources.
		/// </param>
		public void Merge(string resourcePath)
		{
			ShadersLibrary embeddedShadersLibrary = ShadersLibrary.Load(resourcePath);

			Merge(embeddedShadersLibrary);
		}

		/// <summary>
		/// Merge a ShaderLibrary loaded from an embedded resource with <see cref="Instance"/>.
		/// </summary>
		/// <param name="shadersLibrary">
		/// A <see cref="ShadersLibrary"/> that specify the embedded resources.
		/// </param>
		public void Merge(ShadersLibrary shadersLibrary)
		{
			if (shadersLibrary == null)
				throw new ArgumentNullException(nameof(shadersLibrary));

			if (_ShadersLibrary.Includes == null)
				_ShadersLibrary.Includes = new List<Include>();
			if (shadersLibrary.Includes != null)
				_ShadersLibrary.Includes.AddRange(shadersLibrary.Includes);

			if (_ShadersLibrary.Objects == null)
				_ShadersLibrary.Objects = new List<Object>();
			if (shadersLibrary.Objects != null)
				_ShadersLibrary.Objects.AddRange(shadersLibrary.Objects);

			if (_ShadersLibrary.Programs == null)
				_ShadersLibrary.Programs = new List<Program>();
			if (shadersLibrary.Programs != null)
				_ShadersLibrary.Programs.AddRange(shadersLibrary.Programs);
		}

		/// <summary>
		/// The reference instance of <see cref="ShadersLibrary"/>.
		/// </summary>
		private static readonly ShadersLibrary _ShadersLibrary = new ShadersLibrary();

		#endregion
	}
}
