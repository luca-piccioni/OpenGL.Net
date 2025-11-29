
// Copyright (C) 2016-2017 Luca Piccioni
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
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

using OpenGL.Objects.State;

namespace OpenGL.Objects.Scene
{
	/// <summary>
	/// Basic <see cref="IImageCodecPlugin"/> implementation based on actual .NET framework implementation.
	/// </summary>
	/// <remarks>
	/// OBJ file format: http://www.martinreddy.net/gfx/3d/OBJ.spec
	/// MTL file format: http://www.fileformat.info/format/material/
	/// </remarks>
	public class SceneObjectCodecWavefront : ISceneObjectCodecPlugin
	{
		#region Wavefront OBJ File Format

		/// <summary>
		/// OBJ material.
		/// </summary>
		class ObjMaterial : IEquatable<ObjMaterial>
		{
			#region Constructors

			/// <summary>
			/// Construct a ObjMaterial.
			/// </summary>
			/// <param name="name">
			/// A <see cref="String"/> that specifies the name of the material.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="name"/> is null.
			/// </exception>
			public ObjMaterial(string name)
			{
				if (name == null)
					throw new ArgumentNullException("name");

				Name = name;
			}

			#endregion

			#region Information

			/// <summary>
			/// Material name.
			/// </summary>
			public readonly string Name;

			/// <summary>
			/// Ambient color.
			/// </summary>
			public ColorRGBAF Ambient = ColorRGBAF.ColorBlack;

			/// <summary>
			/// Ambient texture.
			/// </summary>
			public Texture2d AmbientTexture;

			/// <summary>
			/// Diffuse color.
			/// </summary>
			public ColorRGBAF Diffuse = ColorRGBAF.ColorWhite;

			/// <summary>
			/// Diffuse texture.
			/// </summary>
			public Texture2d DiffuseTexture;

			/// <summary>
			/// Specular color.
			/// </summary>
			public ColorRGBAF Specular = ColorRGBAF.ColorBlack;

			/// <summary>
			/// Specular texture.
			/// </summary>
			public Texture2d SpecularTexture;

			/// <summary>
			/// Specular exponent.
			/// </summary>
			public float SpecularExponent;

			/// <summary>
			/// Normal texture.
			/// </summary>
			public Texture2d NormalTexture;

			#endregion

			#region Equality Operators

			/// <summary>
			/// Equality operator.
			/// </summary>
			/// <param name="v1"></param>
			/// <param name="v2"></param>
			/// <returns></returns>
			public static bool operator ==(ObjMaterial v1, ObjMaterial v2)
			{
				return (v1.Equals(v2));
			}

			/// <summary>
			/// Inequality operator.
			/// </summary>
			/// <param name="v1"></param>
			/// <param name="v2"></param>
			/// <returns></returns>
			public static bool operator !=(ObjMaterial v1, ObjMaterial v2)
			{
				return (!v1.Equals(v2));
			}

			#endregion

			#region IEquatable<ObjMaterial> Implementation

			/// <summary>
			/// Indicates whether the this ObjMaterial is equal to another ObjMaterial.
			/// </summary>
			/// <param name="other">
			/// An ObjMaterial to compare with this object.
			/// </param>
			/// <returns>
			/// It returns true if the this ObjMaterial is equal to <paramref name="other"/>; otherwise, false.
			/// </returns>
			public bool Equals(ObjMaterial other)
			{
				if (ReferenceEquals(null, other))
					return false;

				if (Name != other.Name)
					return (false);
				if (Ambient != other.Ambient)
					return (false);
				if (Diffuse != other.Diffuse)
					return (false);
				if (Specular != other.Specular)
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

				ObjMaterial otherObj = obj as ObjMaterial;
				if (otherObj == null)
					return (false);

				return (Equals(otherObj));
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
					int result = Name.GetHashCode();
					result = (result * 397) ^ Ambient.GetHashCode();
					result = (result * 397) ^ Diffuse.GetHashCode();
					result = (result * 397) ^ Specular.GetHashCode();

					return result;
				}
			}

			#endregion
		}

		/// <summary>
		/// OBJ face vertex coordinate indices.
		/// </summary>
		class ObjFaceCoord
		{
			public int VertexIndex;

			public int NormalIndex = Int32.MinValue;

			public bool HasNormal { get { return (NormalIndex != Int32.MinValue); } }

			public int TexCoordIndex = Int32.MinValue;

			public bool HasTexCoord { get { return (NormalIndex != Int32.MinValue); } }
		}

		/// <summary>
		/// OBJ face polygon.
		/// </summary>
		class ObjFace
		{
			public readonly List<ObjFaceCoord> Coords = new List<ObjFaceCoord>();

			public bool HasNormal { get { return (Coords.TrueForAll(delegate (ObjFaceCoord item) { return (item.HasNormal); })); } }

			public bool HasTexCoord { get { return (Coords.TrueForAll(delegate (ObjFaceCoord item) { return (item.HasTexCoord); })); } }

			public List<ObjFaceCoord> Triangulate()
			{
				List<ObjFaceCoord> tris = new List<ObjFaceCoord>(Coords.Count);

				switch (Coords.Count) {
					case 0:
					case 1:
					case 2:
						// No triangle
						break;
					case 3:
						tris.AddRange(Coords);
						break;
					case 4:
						tris.Add(Coords[0]);
						tris.Add(Coords[1]);
						tris.Add(Coords[2]);
						tris.Add(Coords[0]);
						tris.Add(Coords[2]);
						tris.Add(Coords[3]);
						break;
					default:
						throw new NotSupportedException("polygons not supported");
				}

				return (tris);
			}
		}

		/// <summary>
		/// OBJ geometry (faces combined with material)
		/// </summary>
		class ObjGeometry
		{
			#region Constructors

			public ObjGeometry(ObjMaterial objMaterial)
			{
				if (objMaterial == null)
					throw new ArgumentNullException("objMaterial");

				Material = objMaterial;
			}

			#endregion

			#region Information

			/// <summary>
			/// Material used for drawing the geometry.
			/// </summary>
			public ObjMaterial Material;

			/// <summary>
			/// Faces compositing the geometry.
			/// </summary>
			public readonly List<ObjFace> Faces = new List<ObjFace>();

			public VertexArrays CreateArrays(ObjContext objContext)
			{
				if (objContext == null)
					throw new ArgumentNullException("objContext");

				VertexArrays vertexArray = new VertexArrays();
				List<ObjFaceCoord> coords = new List<ObjFaceCoord>();
				bool hasTexCoord = Material.DiffuseTexture != null;
				bool hasNormals = true;
				bool hasTanCoord = hasTexCoord && Material.NormalTexture != null;

				foreach (ObjFace f in Faces) {
					hasTexCoord |= f.HasTexCoord;
					hasNormals |= f.HasNormal;
					coords.AddRange(f.Triangulate());
				}

				uint vertexCount = (uint)coords.Count;

				Vertex4f[] position = new Vertex4f[vertexCount];
				Vertex3f[] normal = hasNormals ? new Vertex3f[vertexCount] : null;
				Vertex2f[] texcoord = new Vertex2f[vertexCount];

				for (int i = 0; i < position.Length; i++) {
					Debug.Assert(coords[i].VertexIndex < objContext.Vertices.Count);
					position[i] = objContext.Vertices[coords[i].VertexIndex];

					if (hasTexCoord) {
						Debug.Assert(coords[i].TexCoordIndex < objContext.TextureCoords.Count);
						texcoord[i] = objContext.TextureCoords[coords[i].TexCoordIndex];
					}

					if (hasNormals) {
						Debug.Assert(coords[i].NormalIndex < objContext.Normals.Count);
						normal[i] = objContext.Normals[coords[i].NormalIndex];
					}
				}

				// Position (mandatory)
				ArrayBuffer<Vertex4f> positionBuffer = new ArrayBuffer<Vertex4f>();
				positionBuffer.Create(position);
				vertexArray.SetArray(positionBuffer, VertexArraySemantic.Position);

				// Layout (triangles)
				vertexArray.SetElementArray(PrimitiveType.Triangles);

				// Texture
				if (hasTexCoord) {
					ArrayBuffer<Vertex2f> texCoordBuffer = new ArrayBuffer<Vertex2f>();
					texCoordBuffer.Create(texcoord);
					vertexArray.SetArray(texCoordBuffer, VertexArraySemantic.TexCoord);
				}

				// Normals
				if (hasNormals) {
					ArrayBuffer<Vertex3f> normalBuffer = new ArrayBuffer<Vertex3f>();
					normalBuffer.Create(normal);
					vertexArray.SetArray(normalBuffer, VertexArraySemantic.Normal);
				} else {
					ArrayBuffer<Vertex3f> normalBuffer = new ArrayBuffer<Vertex3f>();
					normalBuffer.Create(vertexCount);
					vertexArray.SetArray(normalBuffer, VertexArraySemantic.Normal);
					vertexArray.GenerateNormals();
				}

				// Tangents
				if (hasTanCoord) {
					ArrayBuffer<Vertex3f> tanCoordBuffer = new ArrayBuffer<Vertex3f>();
					tanCoordBuffer.Create(vertexCount);
					vertexArray.SetArray(tanCoordBuffer, VertexArraySemantic.Tangent);

					ArrayBuffer<Vertex3f> bitanCoordBuffer = new ArrayBuffer<Vertex3f>();
					bitanCoordBuffer.Create(vertexCount);
					vertexArray.SetArray(bitanCoordBuffer, VertexArraySemantic.Bitangent);

					vertexArray.GenerateTangents();
				}

				return (vertexArray);
			}

			public MaterialState CreateMaterialState()
			{
				MaterialState objMaterial = new MaterialState();

				objMaterial.FrontMaterial.Ambient = Material.Ambient;
				if (Material.AmbientTexture != null) {
					objMaterial.FrontMaterialAmbientTexture = Material.AmbientTexture;
					objMaterial.FrontMaterialAmbientTexCoord = 0;
				}

				objMaterial.FrontMaterial.Diffuse = Material.Diffuse;
				if (Material.DiffuseTexture != null) {
					objMaterial.FrontMaterialDiffuseTexture = Material.DiffuseTexture;
					objMaterial.FrontMaterialDiffuseTexCoord = 0;
				}

				objMaterial.FrontMaterial.Specular = Material.Specular;
				objMaterial.FrontMaterial.Shininess = Material.SpecularExponent;

				if (Material.NormalTexture != null) {
					objMaterial.FrontMaterialNormalTexture = Material.NormalTexture;
					objMaterial.FrontMaterialNormalTexCoord = 0;
				}

				return (objMaterial);
			}

			public static ObjGeometry MergeGeometries(IEnumerable<ObjGeometry> geometries, ObjMaterial material)
			{
				ObjGeometry mergedGeometry = new ObjGeometry(material);

				foreach (ObjGeometry item in geometries)
					mergedGeometry.Faces.AddRange(item.Faces);

				return (mergedGeometry);
			}

			#endregion
		}

		/// <summary>
		/// OBJ group (geometries belonging to the same object)
		/// </summary>
		class ObjGroup
		{
			#region Constructors

			public ObjGroup(string name)
			{
				if (name == null)
					throw new ArgumentNullException("name");

				Name = name;
			}

			#endregion

			#region Information

			public readonly string Name;

			public readonly List<ObjGeometry> Geometries = new List<ObjGeometry>();

			public List<ObjGeometry> MergeGeometries()
			{
				List<ObjGeometry> geometries = new List<ObjGeometry>(Geometries);
				List<ObjGeometry> merged = new List<ObjGeometry>(Geometries.Count);

				while (geometries.Count > 0) {
					ObjMaterial mergedMaterial = geometries[0].Material;
					List<ObjGeometry> mergingGeometries = geometries.FindAll(delegate (ObjGeometry item) {
						return (item.Material == mergedMaterial);
					});

					merged.Add(ObjGeometry.MergeGeometries(mergingGeometries, mergedMaterial));

					foreach (ObjGeometry item in mergingGeometries)
						geometries.Remove(item);
				}

				return (merged);
			}

			#endregion
		}

		/// <summary>
		/// OBJ context.
		/// </summary>
		class ObjContext
		{
			#region Constructors

			public ObjContext(string path)
			{
				if (path == null)
					throw new ArgumentNullException("path");

				Path = path;
			}

			#endregion

			#region Information

			public readonly string Path;

			public readonly Dictionary<string, ObjMaterial> Materials = new Dictionary<string, ObjMaterial>();

			public readonly List<Vertex4f> Vertices = new List<Vertex4f>();

			public readonly List<Vertex3f> Normals = new List<Vertex3f>();

			public readonly List<Vertex2f> TextureCoords = new List<Vertex2f>();

			public readonly List<ObjGroup> Groups = new List<ObjGroup>();

			#endregion
		}

		private static ObjContext LoadOBJ(Stream stream, SceneObjectCodecCriteria criteria)
		{
			FileStream fileStream = stream as FileStream;
			if (fileStream == null)
				throw new InvalidOperationException("only FileStream are supported");

			ObjContext objContext = new ObjContext(fileStream.Name);

			using (StreamReader sr = new StreamReader(stream)) {
				string objLine;

				while ((objLine = sr.ReadLine()) != null) {
					// Trim spaces
					objLine = objLine.Trim();
					// Skip empty lines and comments
					if (objLine.Length == 0 || _CommentLine.IsMatch(objLine))
						continue;

					Match commandMatch = _ObjCommandLine.Match(objLine);

					if (commandMatch.Success == false)
						continue;

					string command = commandMatch.Groups["Command"].Value;
					string tokens = commandMatch.Groups["Tokens"].Value.Trim();
					string[] token = Regex.Split(tokens, " +");

					switch (command) {
						case "mtllib":
							ParseMaterialLib(objContext, token);
							break;
						case "usemtl":
							if (objContext.Groups.Count == 0)
								break;

							ObjMaterial objMaterial;

							if (objContext.Materials.TryGetValue(token[0], out objMaterial) == false)
								throw new InvalidOperationException(String.Format("unknown material '{0}'", token[0]));

							objContext.Groups[objContext.Groups.Count - 1].Geometries.Add(new ObjGeometry(objMaterial));
							break;
						case "v":
							ParseVertex(objContext, token);
							break;
						case "vn":
							ParseNormal(objContext, token);
							break;
						case "vt":
							ParseTexCoord(objContext, token);
							break;
						case "f":
							ParseFace(objContext, token);
							break;
						case "s":
							// ?
							break;
						case "g":
							if (token.Length < 1)
								throw new InvalidOperationException();
							objContext.Groups.Add(new ObjGroup(token[0]));
							break;
						case "vl":
						case "vp":
							// Ignored
							break;
						default:
							throw new InvalidOperationException(String.Format("unknown OBJ command {0}", command));
					}
				}
			}

			return (objContext);
		}

		private static SceneObject ProcessOBJ(ObjContext objContext)
		{
			if (objContext == null)
				throw new ArgumentNullException("objContext");

			SceneObjectGeometry sceneObject = new SceneObjectGeometry();

			// Program shader to all objects
			// sceneObject.ProgramTag = ShadersLibrary.Instance.CreateProgramTag("OpenGL.Standard+LambertVertex", new ShaderCompilerContext("GLO_DEBUG_NORMAL"));
            sceneObject.ProgramTag = ShadersLibrary.Instance.CreateProgramTag("OpenGL.Standard+PhongFragment");
            // sceneObject.ProgramTag = ShadersLibrary.Instance.CreateProgramTag("OpenGL.Standard+LambertVertex");

            foreach (ObjGroup objGroup in objContext.Groups) {
				foreach (ObjGeometry objGeometry in objGroup.MergeGeometries()) {
					VertexArrays vertexArray = objGeometry.CreateArrays(objContext);
					GraphicsStateSet objectState = new GraphicsStateSet();

					objectState.DefineState(objGeometry.CreateMaterialState());

					sceneObject.AddGeometry(vertexArray, objectState);
				}
			}

			return (sceneObject);
		}

		private static void ParseMaterialLib(ObjContext objContext, string[] token)
		{
			if (objContext == null)
				throw new ArgumentNullException("objContext");
			if (token == null)
				throw new ArgumentNullException("token");
			if (token.Length != 1)
				throw new ArgumentException("array too short", "token");

			string directoryPath = Path.GetDirectoryName(objContext.Path);
			string materialLibPath = Path.Combine(directoryPath, token[0]);

			using (FileStream fs = new FileStream(materialLibPath, FileMode.Open, FileAccess.Read)) {
				ParseMaterialLibFile(fs, objContext);
			}
		}

		private static void ParseVertex(ObjContext objContext, string[] token)
		{
			if (objContext == null)
				throw new ArgumentNullException("objContext");
			if (token == null)
				throw new ArgumentNullException("token");
			if (token.Length < 3)
				throw new ArgumentException("array too short", "token");

			float[] values = Array.ConvertAll(token, delegate(string item) {
				return (Single.Parse(item, NumberFormatInfo.InvariantInfo));
			});

			objContext.Vertices.Add(new Vertex4f(values[0], values[1], values[2], values.Length > 3 ? values[3] : 1.0f));
		}

		private static void ParseNormal(ObjContext objContext, string[] token)
		{
			if (objContext == null)
				throw new ArgumentNullException("objContext");
			if (token == null)
				throw new ArgumentNullException("token");
			if (token.Length != 3)
				throw new ArgumentException("wrong array length", "token");

			float[] values = Array.ConvertAll(token, delegate(string item) {
				return (Single.Parse(item, NumberFormatInfo.InvariantInfo));
			});

			objContext.Normals.Add(new Vertex3f(values[0], values[1], values[2]));
		}

		private static void ParseTexCoord(ObjContext objContext, string[] token)
		{
			if (objContext == null)
				throw new ArgumentNullException("objContext");
			if (token == null)
				throw new ArgumentNullException("token");
			if (token.Length < 2)
				throw new ArgumentException("wrong array length", "token");

			float[] values = Array.ConvertAll(token, delegate(string item) {
				return (Single.Parse(item, NumberFormatInfo.InvariantInfo));
			});

			objContext.TextureCoords.Add(new Vertex2f(values[0], values[1]));
		}

		private static void ParseFace(ObjContext objContext, string[] token)
		{
			if (objContext == null)
				throw new ArgumentNullException("objContext");
			if (token == null)
				throw new ArgumentNullException("token");
			if (token.Length < 3)
				throw new ArgumentException("wrong array length", "token");

			if (objContext.Groups.Count == 0)
				throw new InvalidOperationException("no group");
			ObjGroup objGroup = objContext.Groups[objContext.Groups.Count - 1];

			if (objGroup.Geometries.Count == 0)
				throw new InvalidOperationException("no geometry");
			ObjGeometry objGeometry = objGroup.Geometries[objGroup.Geometries.Count - 1];

			ObjFace objFace = new ObjFace();

			foreach (string values in token) {
				string[] indices = Regex.Split(values, "/");
				int[] indicesValues = Array.ConvertAll(indices, delegate(string item) {
					if (String.IsNullOrEmpty(item) == false)
						return (Int32.Parse(item, NumberFormatInfo.InvariantInfo));
					else
						return (Int32.MinValue);
				});

				int indexVertex = indicesValues[0];
				int indexNormal = indicesValues[2];
				int indexTexCoord = indicesValues[1];

				ObjFaceCoord objFaceCoord = new ObjFaceCoord();

				// Position
				if (indexVertex < 0)
					indexVertex = objContext.Vertices.Count + indexVertex + 1;
				objFaceCoord.VertexIndex = indexVertex - 1;

				// Normal (optional)
				if (indexNormal != Int32.MinValue) {
					if (indexNormal < 0)
						indexNormal = objContext.Normals.Count + indexNormal + 1;
					objFaceCoord.NormalIndex = indexNormal - 1;
				}
				
				// Tex coord (optional)
				if (indexTexCoord != Int32.MinValue) {
					if (indexTexCoord < 0)
					indexTexCoord = objContext.TextureCoords.Count + indexTexCoord + 1;
					objFaceCoord.TexCoordIndex = indexTexCoord - 1;
				}

				objFace.Coords.Add(objFaceCoord);
			}

			objGeometry.Faces.Add(objFace);
		}

		private static void ParseMaterialLibFile(Stream stream, ObjContext objContext)
		{
			using (StreamReader sr = new StreamReader(stream)) {
				string objLine;

				while ((objLine = sr.ReadLine()) != null) {
					// Trim spaces
					objLine = objLine.Trim();
					// Skip empty lines and comments
					if (objLine.Length == 0 || _CommentLine.IsMatch(objLine))
						continue;

					Match commandMatch = _MtlCommandLine.Match(objLine);

					if (commandMatch.Success == false)
						continue;

					string command = commandMatch.Groups["Command"].Value;
					string tokens = commandMatch.Groups["Tokens"].Value.Trim();
					string[] token = Regex.Split(tokens, " +");

					switch (command) {
						case "newmtl":
							ParseMaterial(sr, objContext, token);
							break;
						default:
							throw new InvalidOperationException(String.Format("unknown OBJ/MTL command {0}", command));
					}
				}
			}
		}

		private static void ParseMaterial(StreamReader sr, ObjContext objContext, string[] token)
		{
			ObjMaterial objMaterial = new ObjMaterial(token[0]);
			string objLine;

			while ((objLine = sr.ReadLine()) != null) {
				// Trim spaces
				objLine = objLine.Trim();
				// Skip comments
				if (_CommentLine.IsMatch(objLine))
					continue;
				// Stop material parsing on empty line
				// Note: is this robust enought? I don't think so.
				if (objLine.Length == 0)
					break;

				Match commandMatch = _MtlParamLine.Match(objLine);

				if (commandMatch.Success == false)
					continue;

				string command = commandMatch.Groups["Command"].Value;
				string commandToken = commandMatch.Groups["Tokens"].Value.Trim();
				string[] commandTokens = Regex.Split(commandToken, " +");

				switch (command) {
					case "Ka":          // Ambient
						objMaterial.Ambient = ParseMaterialColor(objMaterial, commandTokens);
						break;
					case "Kd":          // Diffuse
						objMaterial.Diffuse = ParseMaterialColor(objMaterial, commandTokens);
						break;
					case "Ks":          // Specular
						objMaterial.Specular = ParseMaterialColor(objMaterial, commandTokens);
						break;
					case "Tf":          // Transmission Filter
						break;
					case "illum":       // Illumination model
						break;
					case "d":           // Dissolve factor
						break;
					case "Ns":          // Specular exponent
						objMaterial.SpecularExponent = Single.Parse(commandTokens[0]);
						break;
					case "sharpness":	// Reflection sharpness
						break;
					case "Ni":          // Index of refrection
						break;
					case "map_Ka":
						objMaterial.AmbientTexture = ParseMaterialTexture(objContext, objMaterial, commandTokens);
						break;
					case "map_Kd":
						objMaterial.DiffuseTexture = ParseMaterialTexture(objContext, objMaterial, commandTokens);
						break;
					case "map_Ks":
						objMaterial.SpecularTexture = ParseMaterialTexture(objContext, objMaterial, commandTokens);
						break;
					case "map_d":
					case "map_Ns":
					case "map_aat":
					case "decal":
					case "disp":
					case "bump":
					case "refl":
					default:
						// Ignore
						break;

						// Custom
					case "map_n":
						objMaterial.NormalTexture = ParseMaterialTexture(objContext, objMaterial, commandTokens);
						break;
				}
			}

			// Collect material
			objContext.Materials.Add(objMaterial.Name, objMaterial);
		}

		private static ColorRGBAF ParseMaterialColor(ObjMaterial objMaterial, string[] commandTokens)
		{
			// Kd spectral file.rfl factor
			//
			// The "Ka spectral" statement specifies the specular reflectivity using a spectral curve.
			// "file.rfl" is the name of the .rfl file. "factor" is an optional argument. "factor" is a multiplier
			// for the values in the .rfl file and defaults to 1.0, if not specified. 
			if (commandTokens[0] == "spectral")
				throw new NotSupportedException("spectral specular parameter not supported");

			// Kd xyz x y z
			//
			// The "Ka xyz" statement specifies the specular reflectivity using CIEXYZ values. "x y z" are the values
			// of the CIEXYZ color space. The y and z arguments are optional. If only x is specified, then y and z are
			// assumed to be equal to x. The x y z values are normally in the range of 0 to 1. Values outside this range
			// increase or decrease the reflectivity accordingly. 
			if (commandTokens[0] == "xzy")
				throw new NotSupportedException("CIEXYZ specular parameter not supported");

			// Kd r g b
			// 
			// Note: The Ka statement specifies the specular reflectivity using RGB values. "r g b" are the values for the red, green,
			// and blue components of the color. The g and b arguments are optional. If only r is specified, then g, and b are
			// assumed to be equal to r. The r g b values are normally in the range of 0.0 to 1.0. Values outside this range increase
			// or decrease the relectivity accordingly.
			if (commandTokens.Length != 3)
				throw new ArgumentException("wrong array length", "token");

			float[] rgbValues = Array.ConvertAll(commandTokens, delegate(string item) {
				return (Single.Parse(item, NumberFormatInfo.InvariantInfo));
			});

			return (new ColorRGBAF(rgbValues[0], rgbValues[1], rgbValues[2]));
		}

		private static Texture2d ParseMaterialTexture(ObjContext objContext, ObjMaterial objMaterial, string[] commandTokens)
		{
			string textureFileName = commandTokens[commandTokens.Length - 1];
			string textureFilePath = Path.Combine(Path.GetDirectoryName(objContext.Path), textureFileName);

			try {
				Image textureImage = ImageCodec.Instance.Load(textureFilePath);
				Texture2d texture = new Texture2d();

				texture.Create(textureImage);
				texture.GenerateMipmaps();

				return (texture);
			} catch (Exception exception) {
				throw new InvalidOperationException(String.Format("unable to load texture {0}", textureFileName), exception);
			}
		}

		private static readonly Regex _CommentLine = new Regex(@"#.*");

		private static readonly Regex _ObjCommandLine = new Regex(@"^(?<Command>(v|vp|vl|vn|vt|f|s|g|mtllib|usemtl)) (?<Tokens>.*)$");

		private static readonly Regex _MtlCommandLine = new Regex(@"^(?<Command>(newmtl)) (?<Tokens>.*)$");

		private static readonly Regex _MtlParamLine = new Regex(@"^(?<Command>((map_)?Ka|(map_)?Kd|(map_)?Ks|Tf|illum|(map_)?d|(map_)?Ns|sharpness|Ni|map_aat|decal|disp|bump|refl|map_n)) (?<Tokens>.*)$");

		#endregion

		#region ISceneObjectCodecPlugin Implementation

		/// <summary>
		/// Plugin name.
		/// </summary>
		public string Name { get { return ("Wavefront"); } }

		/// <summary>
		/// Determine whether this plugin is available for the current process.
		/// </summary>
		/// <returns>
		/// It returns a boolean value indicating whether the plugin is available for the current
		/// process.
		/// </returns>
		public bool CheckAvailability()
		{
			// This plugin is always available
			return (true);
		}

		/// <summary>
		/// Gets the list of media formats supported for reading.
		/// </summary>
		/// <value>
		/// The supported formats which this media codec plugin can read.
		/// </value>
		public IEnumerable<string> SupportedReadFormats
		{
			get
			{
				return (new string[] { SceneObjectFormat.Wavefront });
			}
		}

		/// <summary>
		/// Check whether an media format is supported for reading.
		/// </summary>
		/// <param name="format">
		/// A <see cref="String"/> that specify the media format to test for read support.
		/// </param>
		/// <returns>
		/// A <see cref="Boolean"/> indicating whether <paramref name="format"/> is supported.
		/// </returns>
		public bool IsReadSupported(string format)
		{
			return (format == SceneObjectFormat.Wavefront);
		}

		/// <summary>
		/// Gets the list of media formats supported for writing.
		/// </summary>
		/// <value>
		/// The supported formats which this media codec plugin can write.
		/// </value>
		public IEnumerable<string> SupportedWriteFormats
		{
			get
			{
				return (new string[0]);
			}
		}

		/// <summary>
		/// Check whether an media format is supported for writing.
		/// </summary>
		/// <param name="format">
		/// An <see cref="String"/> that specify the media format to test for write support.
		/// </param>
		/// <returns>
		/// A <see cref="Boolean"/> indicating whether <paramref name="format"/> is supported.
		/// </returns>
		public bool IsWriteSupported(string format)
		{
			return (false);
		}

		/// <summary>
		/// Determine the plugin priority for a certain sceneObject format.
		/// </summary>
		/// <param name="format">
		/// An <see cref="SceneObjectFormat"/> specifying the sceneObject format to test for priority.
		/// </param>
		/// <returns>
		/// It returns an integer value indicating the priority of this implementation respect other ones supporting the same
		/// sceneObject format. Conventionally, a value of 0 indicates a totally impartial plugin implementation; a value less than 0 indicates
		/// a more confident implementation respect other plugins; a value greater than 0 indicates a fallback implementation respect other
		/// plugins.
		/// 
		/// This implementation of this routine returns -1. The reasoning is that this plugin implementation is very slow in Query and Load, due
		/// the .NET abstraction. However, it is a very usefull fallback plugin since it can open the most of common sceneObject formats.
		/// </returns>
		public int GetPriority(string format)
		{
			switch (format) {
				default:
					return (-1);
			}
		}

		/// <summary>
		/// Query media informations.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specify the media path.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an media stream.
		/// </param>
		/// <returns>
		/// A <see cref="SceneObjectInfo"/> containing information about the specified media.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/> or <paramref name="criteria"/> is null.
		/// </exception>
		public SceneObjectInfo QueryInfo(string path, SceneObjectCodecCriteria criteria)
		{
			using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read)) {
				return (QueryInfo(fs, criteria));
			}
		}

		/// <summary>
		/// Query media informations.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specify the media path.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an media stream.
		/// </param>
		/// <returns>
		/// A <see cref="SceneObjectInfo"/> containing information about the specified media.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/> or <paramref name="criteria"/> is null.
		/// </exception>
		public SceneObjectInfo QueryInfo(Stream stream, SceneObjectCodecCriteria criteria)
		{
			if (stream == null)
				throw new ArgumentNullException("stream");
			if (criteria == null)
				throw new ArgumentNullException("criteria");

			SceneObjectInfo info = new SceneObjectInfo();
			
			return (info);
		}

		/// <summary>
		/// Load media from stream.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="Stream"/> where the media data is stored.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an media stream.
		/// </param>
		/// <returns>
		/// An <see cref="SceneObject"/> holding the media data.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/> or <paramref name="criteria"/> is null.
		/// </exception>
		public SceneObject Load(string path, SceneObjectCodecCriteria criteria)
		{
			using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read)) {
				return (Load(fs, criteria));
			}
		}

		/// <summary>
		/// Load media from stream.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="Stream"/> where the media data is stored.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an media stream.
		/// </param>
		/// <returns>
		/// An <see cref="SceneObject"/> holding the media data.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/> or <paramref name="criteria"/> is null.
		/// </exception>
		public SceneObject Load(Stream stream, SceneObjectCodecCriteria criteria)
		{
			if (stream == null)
				throw new ArgumentNullException("stream");
			if (criteria == null)
				throw new ArgumentNullException("criteria");

			// Load OBJ information
			ObjContext objContext = LoadOBJ(stream, criteria);
			// Process OBJ information
			return (ProcessOBJ(objContext));
		}

		/// <summary>
		/// Save media to stream.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specify the media path.
		/// </param>
		/// <param name="sceneObject">
		/// A <see cref="SceneObject"/> holding the data to be stored.
		/// </param>
		/// <param name="format">
		/// A <see cref="String"/> that specify the media format to used for saving <paramref name="sceneObject"/>.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an sceneObject stream.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/>, <paramref name="sceneObject"/> or <paramref name="criteria"/> is null.
		/// </exception>
		public void Save(string path, SceneObject sceneObject, string format, SceneObjectCodecCriteria criteria)
		{
			using (FileStream fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write)) {
				Save(fs, sceneObject, format, criteria);
			}
		}

		/// <summary>
		/// Save media to stream.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="IO.Stream"/> which stores the media data.
		/// </param>
		/// <param name="sceneObject">
		/// A <see cref="SceneObject"/> holding the data to be stored.
		/// </param>
		/// <param name="format">
		/// A <see cref="String"/> that specify the media format to used for saving <paramref name="sceneObject"/>.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an sceneObject stream.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/>, <paramref name="sceneObject"/> or <paramref name="criteria"/> is null.
		/// </exception>
		public void Save(Stream stream, SceneObject sceneObject, string format, SceneObjectCodecCriteria criteria)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
