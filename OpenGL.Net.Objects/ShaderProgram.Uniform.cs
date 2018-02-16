
// Copyright (C) 2009-2017 Luca Piccioni
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

using UniformDictionary = OpenGL.Objects.Collections.StringDictionary<OpenGL.Objects.ShaderProgram.UniformBinding>;

using UniformCacheDictionary = OpenGL.Objects.Collections.StringDictionary<object>;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace OpenGL.Objects
{
	public partial class ShaderProgram
	{
		#region Uniforms

		/// <summary>
		/// Shader program uniform binding.
		/// </summary>
		[DebuggerDisplay("UniformBinding: Name={Name} Location={Location} Type={UniformType} BlockIndex={BlockIndex}")]
		internal class UniformBinding
		{
			#region Constructors

			/// <summary>
			/// Construct a non-indexed uniform specifying only the location.
			/// </summary>
			/// <param name="name">
			/// A <see cref="String"/> that specifies the uniform name.
			/// </param>
			/// <param name="location">
			/// A <see cref="Int32"/> that specifies the uniform location. It can -1 to indicate that the uniform
			/// is not active.
			/// </param>
			public UniformBinding(string name, int location) :
				this(UInt32.MaxValue, name, location, ShaderUniformType.Unknown)
			{
				
			}

			/// <summary>
			/// Construct a non-indexed uniform specifying only the location.
			/// </summary>
			/// <param name="name">
			/// A <see cref="String"/> that specifies the uniform name.
			/// </param>
			/// <param name="location">
			/// A <see cref="Int32"/> that specifies the uniform location. It can -1 to indicate that the uniform
			/// is not active.
			/// </param>
			public UniformBinding(uint index, string name, int location, ShaderUniformType type)
			{
				if (name == null)
					throw new ArgumentNullException("name");

				Index = index;
				Name = name;
				Location = location;
				UniformType = type;
			}

			public UniformBinding(uint index, string name, int location, ShaderUniformType type, int blockIndex, int blockOffset, int blockArrayStride, int blockMatrixStride, bool blockMatrixRowMajor)
			{
				if (name == null)
					throw new ArgumentNullException("name");

				Index = index;
				Name = name;
				Location = location;
				UniformType = type;
				BlockIndex = blockIndex;
				BlockOffset = blockOffset;
				BlockArrayStride = blockArrayStride;
				BlockMatrixStride = blockMatrixStride;
				BlockMatrixRowMajor = blockMatrixRowMajor;
			}

			#endregion

			#region Information

			/// <summary>
			/// Uniform index.
			/// </summary>
			public readonly uint Index;

			/// <summary>
			/// The uniform variable name.
			/// </summary>
			public readonly string Name;

			/// <summary>
			/// Uniform location.
			/// </summary>
			public readonly int Location;

			/// <summary>
			/// Uniform type.
			/// </summary>
			public readonly ShaderUniformType UniformType;

			/// <summary>
			/// The uniform block index for this uniform, which can be used to query information about this block. If this
			/// uniform is not in a block, the value will be -1.
			/// </summary>
			public readonly int BlockIndex = -1;

			/// <summary>
			/// The byte offset into the beginning of the uniform block for this uniform. If the uniform is not in a block,
			/// the value will be -1.
			/// </summary>
			public readonly int BlockOffset = -1;

			/// <summary>
			/// The byte stride for elements of the array, for uniforms in a uniform block. For non-array uniforms in a block,
			/// this value is 0. For uniforms not in a block, the value will be -1.
			/// </summary>
			public readonly int BlockArrayStride = -1;

			/// <summary>
			/// The byte stride for columns of a column-major matrix or rows for a row-major matrix, for uniforms in a uniform
			/// block. For non-matrix uniforms in a block, this value is 0. For uniforms not in a block, the value will be -1.
			/// </summary>
			public readonly int BlockMatrixStride = -1;

			/// <summary>
			/// It's true if the matrix is row-major and the uniform is in a block. false is returned if the uniform is column-major,
			/// the uniform is not in a block (all non-block matrices are column-major), or simply not a matrix type.
			/// </summary>
			public readonly bool BlockMatrixRowMajor;

			#endregion

			#region Value Caching

			/// <summary>
			/// Cache the current uniform value. Used to minimize Uniform* calls at the cost of comparing the cached
			/// object with the call arguments.
			/// </summary>
			/// <param name="uniformValue">
			/// A <see cref="Object"/> that specifies the uniform variable value.
			/// </param>
			public void CacheValue(object uniformValue)
			{
				_CachedValue = uniformValue;
			}

			/// <summary>
			/// Cache the current uniform value. Used to minimize Uniform* calls at the cost of comparing the cached
			/// object with the call arguments.
			/// </summary>
			/// <param name="uniformValue">
			/// A <see cref="Object"/> that specifies the uniform variable value.
			/// </param>
			public void CacheValue(ICloneable uniformValue)
			{
				CacheValue(uniformValue.Clone());
			}

			/// <summary>
			/// Check whether the uniform value is chanding
			/// </summary>
			/// <param name="uniformValue"></param>
			/// <returns></returns>
			public bool IsValueChanged(object uniformValue)
			{
				return (uniformValue.Equals(_CachedValue) == false);
			}

			/// <summary>
			/// Current value cached.
			/// </summary>
			private object _CachedValue;

			#endregion
		}

		/// <summary>
		/// Collect program active uniforms.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> on which this program was created.
		/// </param>
		private void CollectActiveUniforms(GraphicsContext ctx)
		{
			// Clear uniform mapping
			_UniformMap.Clear();

			// Query
#if !MONODROID
			if      (ctx.Extensions.ProgramInterfaceQuery_ARB)
				CollectActiveUniforms_ProgramInterfaceQuery(ctx);
			else if (ctx.Extensions.UniformBufferObject_ARB)
				CollectActiveUniforms_UniformBufferObject(ctx);
			else
#endif
				CollectActiveUniforms_Compatible(ctx);

			LogActiveUniforms();
		}

#if !MONODROID

		/// <summary>
		/// Collect uniform information using GL_ARB_program_interface_query.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> on which this program was created.
		/// </param>
		private void CollectActiveUniforms_ProgramInterfaceQuery(GraphicsContext ctx)
		{
			int activeUniforms;

			Gl.GetProgramInterface(ObjectName, ProgramInterface.Uniform, ProgramInterfacePName.ActiveResources, out activeUniforms);

			int[] properties = new int[] {
				Gl.TYPE​,
				Gl.NAME_LENGTH,
				Gl.BLOCK_INDEX,
				Gl.OFFSET,
				Gl.ARRAY_STRIDE,
				Gl.MATRIX_STRIDE,
				Gl.IS_ROW_MAJOR,
				Gl.LOCATION
			};

			int[] values = new int[properties.Length];
			int valuesLength;

			for (uint i = 0; i < activeUniforms; i++) {
				// Get uniform information
				Gl.GetProgramResource(ObjectName, ProgramInterface.Uniform, i, properties, out valuesLength, values);

				// Get uniform name
				int nameLength, nameBufferSize = values[Array.IndexOf(properties, Gl.NAME_LENGTH)] + 2;

				StringBuilder uniformNameBuilder = new StringBuilder(nameBufferSize + 2);
				uniformNameBuilder.EnsureCapacity(nameBufferSize);

				Gl.GetProgramResourceName(ObjectName, ProgramInterface.Uniform, i, nameBufferSize, out nameLength, uniformNameBuilder);

				// Track uniform
				UniformBinding uniformBinding = new UniformBinding(i, uniformNameBuilder.ToString(),
					values[Array.IndexOf(properties, Gl.LOCATION)],
					(ShaderUniformType)values[Array.IndexOf(properties, Gl.TYPE​)],
					values[Array.IndexOf(properties, Gl.BLOCK_INDEX​)],
					values[Array.IndexOf(properties, Gl.OFFSET)],
					values[Array.IndexOf(properties, Gl.ARRAY_STRIDE)],
					values[Array.IndexOf(properties, Gl.MATRIX_STRIDE)],
					values[Array.IndexOf(properties, Gl.IS_ROW_MAJOR)] != 0
				);

				_UniformMap.Add(uniformBinding.Name, uniformBinding);
				_UniformIndexMap.Add(uniformBinding.Index, uniformBinding);

				CheckStructuredUniform(uniformBinding);
			}
		}

		/// <summary>
		/// Collect uniform information using GL_ARB_uniform_buffer_object.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> on which this program was created.
		/// </param>
		private void CollectActiveUniforms_UniformBufferObject(GraphicsContext ctx)
		{
			int activeUniforms;

			Gl.GetProgram(ObjectName, ProgramProperty.ActiveUniforms, out activeUniforms);

			// Get uniform information
			uint[] uniformIndices = new uint[activeUniforms];
			for (uint i = 0; i < activeUniforms; i++)
				uniformIndices[i] = i;

			int[] uniformType = new int[activeUniforms];
			int[] uniformNameLen = new int[activeUniforms];
			int[] uniformBlockIndex = new int[activeUniforms];
			int[] uniformOffset = new int[activeUniforms];
			int[] uniformArrayStride = new int[activeUniforms];
			int[] uniformMatrixStride = new int[activeUniforms];
			int[] uniformRowMajor = new int[activeUniforms];

			Gl.GetActiveUniforms(ObjectName, uniformIndices, UniformPName.UniformType, uniformType);
			Gl.GetActiveUniforms(ObjectName, uniformIndices, UniformPName.UniformNameLength, uniformNameLen);
			Gl.GetActiveUniforms(ObjectName, uniformIndices, UniformPName.UniformBlockIndex, uniformBlockIndex);
			Gl.GetActiveUniforms(ObjectName, uniformIndices, UniformPName.UniformOffset, uniformOffset);
			Gl.GetActiveUniforms(ObjectName, uniformIndices, UniformPName.UniformArrayStride, uniformArrayStride);
			Gl.GetActiveUniforms(ObjectName, uniformIndices, UniformPName.UniformMatrixStride, uniformMatrixStride);
			Gl.GetActiveUniforms(ObjectName, uniformIndices, UniformPName.UniformIsRowMajor, uniformRowMajor);

			for (uint i = 0; i < activeUniforms; i++) {
				// Get uniform name
				int uniformBufferSize = uniformNameLen[i] + 2;
				// Get uniform information
				StringBuilder uniformNameBuilder = new StringBuilder(uniformBufferSize + 2);
				int uniformNameLength;

				uniformNameBuilder.EnsureCapacity(uniformBufferSize);

				Gl.GetActiveUniformName(ObjectName, i, uniformBufferSize, out uniformNameLength, uniformNameBuilder);

				string uniformName = uniformNameBuilder.ToString();

				// Track uniform
				UniformBinding uniformBinding = new UniformBinding(i, uniformName,
					Gl.GetUniformLocation(ObjectName, uniformName),
					(ShaderUniformType)uniformType[i],
					uniformBlockIndex[i],
					uniformOffset[i],
					uniformArrayStride[i],
					uniformMatrixStride[i],
					uniformRowMajor[i] != 0
				);

				_UniformMap.Add(uniformBinding.Name, uniformBinding);
				_UniformIndexMap.Add(uniformBinding.Index, uniformBinding);

				CheckStructuredUniform(uniformBinding);
			}
		}

#endif

		/// <summary>
		/// Collect uniform information using GL_ARB_shader_objects.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> on which this program was created.
		/// </param>
		private void CollectActiveUniforms_Compatible(GraphicsContext ctx)
		{
			int activeUniforms, uniformBufferSize;

			Gl.GetProgram(ObjectName, ProgramProperty.ActiveUniforms, out activeUniforms);
			Gl.GetProgram(ObjectName, ProgramProperty.ActiveUniformMaxLength, out uniformBufferSize);

			for (uint i = 0; i < activeUniforms; i++) {
				// Get uniform information
				StringBuilder uniformNameBuilder = new StringBuilder(uniformBufferSize + 2);
				int uniformNameLength, uniformSize, uniformType;

				uniformNameBuilder.EnsureCapacity(uniformBufferSize);

				Gl.GetActiveUniform(ObjectName, i, uniformBufferSize, out uniformNameLength, out uniformSize, out uniformType, uniformNameBuilder);

				string uniformName = uniformNameBuilder.ToString();

				// Track uniform
				UniformBinding uniformBinding = new UniformBinding(i, uniformName,
					Gl.GetUniformLocation(ObjectName, uniformName),
					(ShaderUniformType)uniformType
				);

				_UniformMap.Add(uniformBinding.Name, uniformBinding);
				_UniformIndexMap.Add(uniformBinding.Index, uniformBinding);

				CheckStructuredUniform(uniformBinding);
			}
		}

		/// <summary>
		/// If an active uniform represent a structure or an array, it extract the basic string to detect
		/// active uniforms (of type of structure, or of type of array) by using the basic name.
		/// </summary>
		/// <param name="uniformBinding">
		/// The <see cref="UniformBinding"/> representing the active uniform.
		/// </param>
		private void CheckStructuredUniform(UniformBinding uniformBinding)
		{
			Match uniformStructure = Regex.Match(uniformBinding.Name, @"((?<Struct>[\w\d_]+(\[\d+\])?)(\.))+");
			if (uniformStructure.Success == false)
				return;

			string structurePattern = null;

			for (int j = 0; j < uniformStructure.Groups["Struct"].Captures.Count; j++) {
				string structureName = uniformStructure.Groups["Struct"].Captures[j].Value;

				if (structurePattern != null) {
					structurePattern = String.Format("{0}.{1}", structurePattern, structureName);
				} else
					structurePattern = structureName;

				Match uniformArrayMatch = Regex.Match(structurePattern, @"(?<ArrayName>[\w\d_]+)(?<Indexer>\[\d+\])");
				if (uniformArrayMatch.Success) {
					string arrayPattern = uniformArrayMatch.Groups["ArrayName"].Value;
					if (_UniformMap.ContainsKey(arrayPattern) == false)
						_UniformMap.Add(arrayPattern, null);
				}

				if (_UniformMap.ContainsKey(structurePattern) == false)
					_UniformMap.Add(structurePattern, null);
			}
		}

		/// <summary>
		/// Log program active uniforms.
		/// </summary>
		private void LogActiveUniforms()
		{
			if (LogEnabled == false)
				return;

			List<string> uniformNames = new List<string>(_UniformMap.Keys);

			// Make uniform list invariant respect the used driver (ease log comparation)
			uniformNames.Sort();

			Log("Shader program active uniforms:");
			foreach (string uniformName in uniformNames) {
				UniformBinding uniformBinding = _UniformMap[uniformName];
				if (uniformBinding != null)
					Log(
						"\tUniform {0} (Type: {1}, Location: {2}, BlockIndex: {3}, BlockOffset: {4})",
						uniformName, uniformBinding.UniformType, uniformBinding.Location,
						uniformBinding.BlockIndex, uniformBinding.BlockOffset
					);
			}
		}

		/// <summary>
		/// Map active uniform information with uniform name.
		/// </summary>
		private readonly UniformDictionary _UniformMap = new UniformDictionary();

		/// <summary>
		/// Map active uniform information with uniform index.
		/// </summary>
		private readonly Dictionary<uint, UniformBinding> _UniformIndexMap = new Dictionary<uint, UniformBinding>();

		/// <summary>
		/// Collection of active uniforms on this ShaderProgram.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This list may be not exahustive as someone could think: this list is initialize at link time, and its contents
		/// is determined by the current OpenGL driver used. To check effectively the uniform variable activeness, use
		/// <see cref="IsActiveUniform"/> method.
		/// </para>
		/// <para>
		/// After a call to <see cref="IsActiveUniform"/> method, the uniform variable (only if active) will be collected in
		/// the collection returned by this property.
		/// </para>
		/// </remarks>
		public ICollection<string> ActiveUniforms
		{
			get
			{
				return (_UniformMap.Keys);
			}
		}

		/// <summary>
		/// Determine whether an uniform is active or not.
		/// </summary>
		/// <param name="uniformName">
		/// A <see cref="String"/> which specify the uniform name.
		/// </param>
		/// <returns>
		/// </returns>
		public bool IsActiveUniform(string uniformName)
		{
			return (_UniformMap.ContainsKey(uniformName));
		}

		/// <summary>
		/// Request uniform variable location.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsCOntext"/> that has currently bound the program.
		/// </param>
		/// <param name="uniformName">
		/// A <see cref="String"/> of the uniform variable used.
		/// </param>
		/// <returns></returns>
		private UniformBinding GetUniform(GraphicsContext ctx, string uniformName)
		{
			if (uniformName == null)
				throw new ArgumentNullException("uniformName");

			UniformBinding uniformBinding;

			if (_UniformMap.TryGetValue(uniformName, out uniformBinding))
				return (uniformBinding);

			// Undiscovered uniform?
			int uniformLocation = Gl.GetUniformLocation(ObjectName, uniformName);
            // Do not repeat GetUniformLocation
            _UniformMap.Add(uniformName, uniformBinding = new UniformBinding(uniformName, uniformLocation));

			return (uniformBinding);
		}

		/// <summary>
		/// Request uniform variable location.
		/// </summary>
		/// <param name="uniformSemantic">
		/// A <see cref="String"/> of the uniform semantic.
		/// </param>
		/// <returns></returns>
		private UniformBinding GetUniformSemantic(string uniformSemantic)
		{
			if (uniformSemantic == null)
				throw new ArgumentNullException("uniformName");

			UniformBinding uniformBinding;
			string uniformName;

			// Known semantic overrides uniform name
			if (_UniformSemantic.TryGetValue(uniformSemantic, out uniformName))
				return (null);

			if (_UniformMap.TryGetValue(uniformName, out uniformBinding))
				return (uniformBinding);

			return (null);
		}

		/// <summary>
		/// Check uniform variable coherence.
		/// </summary>
		/// <param name="uniform">
		/// A <see cref="UniformBinding"/> that specify the uniform name to check.
		/// </param>
		/// <param name="uniformRequestTypes">
		/// A sequence of OpenGL constants that are the allowed types for the specified uniform.
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the type of the uniform variable <paramref name="uniform"/> does not match any value specified by <paramref name="uniformRequestTypes"/>.
		/// </exception>
		[Conditional("GL_DEBUG_PENDANTIC")]
		private static void CheckUniformType(UniformBinding uniform, params int[] uniformRequestTypes)
		{
			if (uniform == null)
				throw new ArgumentNullException("uniform");
			if (uniformRequestTypes == null)
				throw new ArgumentNullException("uniformRequestTypes");

			/* ! Check: required uniform type shall correspond */
			foreach (int uniformReqtype in uniformRequestTypes)
				if ((int)uniform.UniformType == uniformReqtype)
					return;

			// 3.3.0 NVIDIA 310.44 confuse float uniforms (maybe in structs?) as vec4
			if (uniform.UniformType == ShaderUniformType.Vec4)
				return;
			// Allow unknown uniform type
			if (uniform.UniformType == ShaderUniformType.Unknown)
				return;

			throw new InvalidOperationException("uniform type mismatch");
		}

		/// <summary>
		/// Check whether this ShaderProgram is bound.
		/// </summary>
		[Conditional("GL_DEBUG_PENDANTIC")]
		private void CheckProgramBinding()
		{
			int program;

			Gl.Get(Gl.CURRENT_PROGRAM, out program);

			if (program == InvalidObjectName || program != ObjectName)
				throw new InvalidOperationException("no shader program bound");
		}

		#endregion

		#region Uniform Backend Interface

		/// <summary>
		/// Bind this program for setting uniform values, if necessary.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for binding the underlying program.
		/// </param>
		public void BindUniform(GraphicsContext ctx)
		{
			_UniformBackend.Bind(ctx, this);
		}

		/// <summary>
		/// Backend implemented for loading uniform state.
		/// </summary>
		interface IUniformBackend
		{
			#region Program Binding

			/// <summary>
			/// Bind the program for setting uniforms.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for binding the underlying program.
			/// </param>
			/// <param name="program">
			/// The <see cref="ShaderProgram"/> to be bound for setting uniforms.
			/// </param>
			void Bind(GraphicsContext ctx, ShaderProgram program);

			#endregion

			#region Set/Get Uniform (single-precision floating-point vector data)

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, float v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, float x, float y);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, float x, float y, float z);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, float x, float y, float z, float w);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, float[] v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2f v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3f v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4f v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2f[] v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3f[] v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4f[] v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, ColorRGBAF c);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, ColorRGBAF[] c);

			#endregion

			#region Set/Get Uniform (integer vector data)

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, int v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, int x, int y);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, int x, int y, int z);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, int x, int y, int z, int w);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2i v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3i v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4i v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2i[] v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3i[] v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4i[] v);

			#endregion

			#region Set/Get Uniform (unsigned integer vector data)

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, uint v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, uint x, uint y);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, uint x, uint y, uint z);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, uint x, uint y, uint z, uint w);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2ui v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3ui v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4ui v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2ui[] v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3ui[] v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4ui[] v);

			#endregion

			#region Set/Get Uniform (boolean vector data)

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, bool v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, bool x, bool y);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, bool x, bool y, bool z);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, bool x, bool y, bool z, bool w);

			#endregion

			#region Set/Get Uniform (single-precision floating-point matrix data)

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Matrix3x3f m);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Matrix4x4f m);

			#endregion

#if !MONODROID

			#region Set/Get Uniform (double-precision floating-point vector data)

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, double v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, double x, double y);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, double x, double y, double z);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, double x, double y, double z, double w);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2d v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3d v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4d v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2d[] v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3d[] v);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4d[] v);

			#endregion

			#region Set/Get Uniform (double-precision floating-point matrix data)

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Matrix3x3d m);

			void SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Matrix4x4d m);

			#endregion

#endif
		}

		/// <summary>
		/// Current uniform backend used for setting this program uniform state.
		/// </summary>
		private IUniformBackend _UniformBackend;

		#endregion

		#region Uniform Backend (GL_ARB_shader_objects)

		/// <summary>
		/// The <see cref="IUniformBackend"/> implementation for compatibility implementation based on glUniform*
		/// commands. They had been superseeded by glProgramUniform* commands available with ARB_separate_shader_object.
		/// </summary>
		class UniformBackendCompatible : IUniformBackend
		{
			#region IUniformBackend Implementation

			#region Program Binding

			/// <summary>
			/// Bind the program for setting uniforms.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for binding the underlying program.
			/// </param>
			/// <param name="program">
			/// The <see cref="ShaderProgram"/> to be bound for setting uniforms.
			/// </param>
			public void Bind(GraphicsContext ctx, ShaderProgram program)
			{
				ctx.Bind(program);
			}

			#endregion

			#region Set/Get Uniform (single-precision floating-point vector data)

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, float v)
			{
				Gl.Uniform1(uniform.Location, v);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, float x, float y)
			{
				Gl.Uniform2(uniform.Location, x, y);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, float x, float y, float z)
			{
				Gl.Uniform3(uniform.Location, x, y, z);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, float x, float y, float z, float w)
			{
				Gl.Uniform4(uniform.Location, x, y, z, w);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2f v)
			{
				unsafe {
					Gl.Uniform2(uniform.Location, 1, (float*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3f v)
			{
				unsafe {
					Gl.Uniform3(uniform.Location, 1, (float*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4f v)
			{
				unsafe {
					Gl.Uniform4(uniform.Location, 1, (float*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, float[] v)
			{
				unsafe {
					fixed (float* p_v = v) {
						Gl.Uniform2(uniform.Location, v.Length, p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2f[] v)
			{
				unsafe {
					fixed (Vertex2f* p_v = v) {
						Gl.Uniform2(uniform.Location, v.Length, (float*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3f[] v)
			{
				unsafe {
					fixed (Vertex3f* p_v = v) {
						Gl.Uniform3(uniform.Location, v.Length, (float*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4f[] v)
			{
				unsafe {
					fixed (Vertex4f* p_v = v) {
						Gl.Uniform4(uniform.Location, v.Length, (float*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, ColorRGBAF c)
			{
				unsafe {
					Gl.Uniform4(uniform.Location, 1, (float*)&c);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, ColorRGBAF[] c)
			{
				unsafe {
					fixed (ColorRGBAF* p_c = c) {
						Gl.Uniform4(uniform.Location, c.Length, (float*)p_c);
					}
				}
			}

			#endregion

			#region Set/Get Uniform (integer vector data)

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, int v)
			{
				Gl.Uniform1(uniform.Location, v);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, int x, int y)
			{
				Gl.Uniform2(uniform.Location, x, y);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, int x, int y, int z)
			{
				Gl.Uniform3(uniform.Location, x, y, z);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, int x, int y, int z, int w)
			{
				Gl.Uniform4(uniform.Location, x, y, z, w);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2i v)
			{
				unsafe {
					Gl.Uniform2(uniform.Location, 1, (int*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3i v)
			{
				unsafe {
					Gl.Uniform3(uniform.Location, 1, (int*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4i v)
			{
				unsafe {
					Gl.Uniform4(uniform.Location, 1, (int*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2i[] v)
			{
				unsafe {
					fixed (Vertex2i* p_v = v) {
						Gl.Uniform2(uniform.Location, v.Length, (int*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3i[] v)
			{
				unsafe {
					fixed (Vertex3i* p_v = v) {
						Gl.Uniform3(uniform.Location, v.Length, (int*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4i[] v)
			{
				unsafe {
					fixed (Vertex4i* p_v = v) {
						Gl.Uniform4(uniform.Location, v.Length, (int*)p_v);
					}
				}
			}

			#endregion

			#region Set/Get Uniform (unsigned integer vector data)

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, uint v)
			{
				Gl.Uniform1(uniform.Location, v);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, uint x, uint y)
			{
				Gl.Uniform2(uniform.Location, x, y);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, uint x, uint y, uint z)
			{
				Gl.Uniform3(uniform.Location, x, y, z);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, uint x, uint y, uint z, uint w)
			{
				Gl.Uniform4(uniform.Location, x, y, z, w);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2ui v)
			{
				unsafe {
					Gl.Uniform2(uniform.Location, 1, (uint*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3ui v)
			{
				unsafe {
					Gl.Uniform3(uniform.Location, 1, (uint*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4ui v)
			{
				unsafe {
					Gl.Uniform4(uniform.Location, 1, (uint*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2ui[] v)
			{
				unsafe {
					fixed (Vertex2ui* p_v = v) {
						Gl.Uniform2(uniform.Location, v.Length, (uint*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3ui[] v)
			{
				unsafe {
					fixed (Vertex3ui* p_v = v) {
						Gl.Uniform3(uniform.Location, v.Length, (uint*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4ui[] v)
			{
				unsafe {
					fixed (Vertex4ui* p_v = v) {
						Gl.Uniform4(uniform.Location, v.Length, (uint*)p_v);
					}
				}
			}

			#endregion

			#region Set/Get Uniform (boolean vector data)

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, bool v)
			{
				Gl.Uniform1(uniform.Location, v ? 1 : 0);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, bool x, bool y)
			{
				Gl.Uniform2(uniform.Location, x ? 1 : 0, y ? 1 : 0);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, bool x, bool y, bool z)
			{
				Gl.Uniform3(uniform.Location, x ? 1 : 0, y ? 1 : 0, z ? 1 : 0);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, bool x, bool y, bool z, bool w)
			{
				Gl.Uniform4(uniform.Location, x ? 1 : 0, y ? 1 : 0, z ? 1 : 0, w ? 1 : 0);
			}

			#endregion

			#region Set/Get Uniform (single-precision floating-point matrix data)

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Matrix3x3f m)
			{
				Gl.UniformMatrix3f(uniform.Location, 1, false, m);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Matrix4x4f m)
			{
				Gl.UniformMatrix4f(uniform.Location, 1, false, m);
			}

			#endregion

#if !MONODROID

			#region Set/Get Uniform (double-precision floating-point vector data)

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, double v)
			{
				Gl.Uniform1(uniform.Location, v);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, double x, double y)
			{
				Gl.Uniform2(uniform.Location, x, y);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, double x, double y, double z)
			{
				Gl.Uniform3(uniform.Location, x, y, z);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, double x, double y, double z, double w)
			{
				Gl.Uniform4(uniform.Location, x, y, z, w);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2d v)
			{
				unsafe {
					Gl.Uniform2(uniform.Location, 1, (double*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3d v)
			{
				unsafe {
					Gl.Uniform3(uniform.Location, 1, (double*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4d v)
			{
				unsafe {
					Gl.Uniform4(uniform.Location, 1, (double*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2d[] v)
			{
				unsafe {
					fixed (Vertex2d* p_v = v) {
						Gl.Uniform2(uniform.Location, v.Length, (double*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3d[] v)
			{
				unsafe {
					fixed (Vertex3d* p_v = v) {
						Gl.Uniform3(uniform.Location, v.Length, (double*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4d[] v)
			{
				unsafe {
					fixed (Vertex4d* p_v = v) {
						Gl.Uniform4(uniform.Location, v.Length, (double*)p_v);
					}
				}
			}

			#endregion

			#region Set/Get Uniform (double-precision floating-point matrix data)

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Matrix3x3d m)
			{
				Gl.UniformMatrix3d(uniform.Location, 1, false, m);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Matrix4x4d m)
			{
				Gl.UniformMatrix4d(uniform.Location, 1, false, m);
			}

			#endregion

#endif

			#endregion
		}

		#endregion

		#region Uniform Backend (GL_ARB_separate_shader_objects)

		/// <summary>
		/// The <see cref="IUniformBackend"/> implementation for compatibility implementation based on glProgramUniform*
		/// commands.
		/// </summary>
		class UniformBackendSeparate : IUniformBackend
		{
			#region IUniformBackend Implementation

			#region Program Binding

			/// <summary>
			/// Bind the program for setting uniforms.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for binding the underlying program.
			/// </param>
			/// <param name="program">
			/// The <see cref="ShaderProgram"/> to be bound for setting uniforms.
			/// </param>
			public void Bind(GraphicsContext ctx, ShaderProgram program)
			{
				// Program is not required to be bound
			}

			#endregion

			#region Set/Get Uniform (single-precision floating-point vector data)

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, float v)
			{
				Gl.ProgramUniform1(program.ObjectName, uniform.Location, v);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, float x, float y)
			{
				Gl.ProgramUniform2(program.ObjectName, uniform.Location, x, y);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, float x, float y, float z)
			{
				Gl.ProgramUniform3(program.ObjectName, uniform.Location, x, y, z);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, float x, float y, float z, float w)
			{
				Gl.ProgramUniform4(program.ObjectName, uniform.Location, x, y, z, w);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2f v)
			{
				unsafe {
					Gl.ProgramUniform2(program.ObjectName, uniform.Location, 1, (float*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3f v)
			{
				unsafe {
					Gl.ProgramUniform3(program.ObjectName, uniform.Location, 1, (float*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4f v)
			{
				unsafe {
					Gl.ProgramUniform4(program.ObjectName, uniform.Location, 1, (float*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, float[] v)
			{
				unsafe {
					fixed (float* p_v = v) {
						Gl.ProgramUniform1(program.ObjectName, uniform.Location, v.Length, p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2f[] v)
			{
				unsafe {
					fixed (Vertex2f* p_v = v) {
						Gl.ProgramUniform2(program.ObjectName, uniform.Location, v.Length, (float*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3f[] v)
			{
				unsafe {
					fixed (Vertex3f* p_v = v) {
						Gl.ProgramUniform3(program.ObjectName, uniform.Location, v.Length, (float*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4f[] v)
			{
				unsafe {
					fixed (Vertex4f* p_v = v) {
						Gl.ProgramUniform4(program.ObjectName, uniform.Location, v.Length, (float*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, ColorRGBAF c)
			{
				unsafe {
					Gl.ProgramUniform4(program.ObjectName, uniform.Location, 1, (float*)&c);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, ColorRGBAF[] c)
			{
				unsafe {
					fixed (ColorRGBAF* p_c = c) {
						Gl.ProgramUniform4(program.ObjectName, uniform.Location, c.Length, (float*)p_c);
					}
				}
			}

			#endregion

			#region Set/Get Uniform (integer vector data)

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, int v)
			{
				Gl.ProgramUniform1(program.ObjectName, uniform.Location, v);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, int x, int y)
			{
				Gl.ProgramUniform2(program.ObjectName, uniform.Location, x, y);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, int x, int y, int z)
			{
				Gl.ProgramUniform3(program.ObjectName, uniform.Location, x, y, z);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, int x, int y, int z, int w)
			{
				Gl.ProgramUniform4(program.ObjectName, uniform.Location, x, y, z, w);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2i v)
			{
				unsafe {
					Gl.ProgramUniform2(program.ObjectName, uniform.Location, 1, (int*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3i v)
			{
				unsafe {
					Gl.ProgramUniform3(program.ObjectName, uniform.Location, 1, (int*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4i v)
			{
				unsafe {
					Gl.ProgramUniform4(program.ObjectName, uniform.Location, 1, (int*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2i[] v)
			{
				unsafe {
					fixed (Vertex2i* p_v = v) {
						Gl.ProgramUniform2(program.ObjectName, uniform.Location, v.Length, (int*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3i[] v)
			{
				unsafe {
					fixed (Vertex3i* p_v = v) {
						Gl.ProgramUniform3(program.ObjectName, uniform.Location, v.Length, (int*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4i[] v)
			{
				unsafe {
					fixed (Vertex4i* p_v = v) {
						Gl.ProgramUniform4(program.ObjectName, uniform.Location, v.Length, (int*)p_v);
					}
				}
			}

			#endregion

			#region Set/Get Uniform (unsigned integer vector data)

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, uint v)
			{
				Gl.ProgramUniform1(program.ObjectName, uniform.Location, v);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, uint x, uint y)
			{
				Gl.ProgramUniform2(program.ObjectName, uniform.Location, x, y);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, uint x, uint y, uint z)
			{
				Gl.ProgramUniform3(program.ObjectName, uniform.Location, x, y, z);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, uint x, uint y, uint z, uint w)
			{
				Gl.ProgramUniform4(program.ObjectName, uniform.Location, x, y, z, w);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2ui v)
			{
				unsafe {
					Gl.ProgramUniform2(program.ObjectName, uniform.Location, 1, (uint*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3ui v)
			{
				unsafe {
					Gl.ProgramUniform3(program.ObjectName, uniform.Location, 1, (uint*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4ui v)
			{
				unsafe {
					Gl.ProgramUniform4(program.ObjectName, uniform.Location, 1, (uint*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2ui[] v)
			{
				unsafe {
					fixed (Vertex2ui* p_v = v) {
						Gl.ProgramUniform2(program.ObjectName, uniform.Location, v.Length, (uint*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3ui[] v)
			{
				unsafe {
					fixed (Vertex3ui* p_v = v) {
						Gl.ProgramUniform3(program.ObjectName, uniform.Location, v.Length, (uint*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4ui[] v)
			{
				unsafe {
					fixed (Vertex4ui* p_v = v) {
						Gl.ProgramUniform4(program.ObjectName, uniform.Location, v.Length, (uint*)p_v);
					}
				}
			}

			#endregion

			#region Set/Get Uniform (boolean vector data)

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, bool v)
			{
				Gl.ProgramUniform1(program.ObjectName, uniform.Location, v ? 1 : 0);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, bool x, bool y)
			{
				Gl.ProgramUniform2(program.ObjectName, uniform.Location, x ? 1 : 0, y ? 1 : 0);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, bool x, bool y, bool z)
			{
				Gl.ProgramUniform3(program.ObjectName, uniform.Location, x ? 1 : 0, y ? 1 : 0, z ? 1 : 0);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, bool x, bool y, bool z, bool w)
			{
				Gl.ProgramUniform4(program.ObjectName, uniform.Location, x ? 1 : 0, y ? 1 : 0, z ? 1 : 0, w ? 1 : 0);
			}

			#endregion

			#region Set/Get Uniform (single-precision floating-point matrix data)

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Matrix3x3f m)
			{
				Gl.ProgramUniformMatrix3f(program.ObjectName, uniform.Location, 1, false, m);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Matrix4x4f m)
			{
				Gl.ProgramUniformMatrix4f(program.ObjectName, uniform.Location, 1, false, m);
			}

			#endregion

#if !MONODROID

			#region Set/Get Uniform (double-precision floating-point vector data)

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, double v)
			{
				Gl.ProgramUniform1(program.ObjectName, uniform.Location, v);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, double x, double y)
			{
				Gl.ProgramUniform2(program.ObjectName, uniform.Location, x, y);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, double x, double y, double z)
			{
				Gl.ProgramUniform3(program.ObjectName, uniform.Location, x, y, z);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, double x, double y, double z, double w)
			{
				Gl.ProgramUniform4(program.ObjectName, uniform.Location, x, y, z, w);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2d v)
			{
				unsafe {
					Gl.ProgramUniform2(program.ObjectName, uniform.Location, 1, (double*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3d v)
			{
				unsafe {
					Gl.ProgramUniform3(program.ObjectName, uniform.Location, 1, (double*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4d v)
			{
				unsafe {
					Gl.ProgramUniform4(program.ObjectName, uniform.Location, 1, (double*)&v);
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex2d[] v)
			{
				unsafe {
					fixed (Vertex2d* p_v = v) {
						Gl.ProgramUniform2(program.ObjectName, uniform.Location, v.Length, (double*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex3d[] v)
			{
				unsafe {
					fixed (Vertex3d* p_v = v) {
						Gl.ProgramUniform3(program.ObjectName, uniform.Location, v.Length, (double*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Vertex4d[] v)
			{
				unsafe {
					fixed (Vertex4d* p_v = v) {
						Gl.ProgramUniform4(program.ObjectName, uniform.Location, v.Length, (double*)p_v);
					}
				}
			}

			#endregion

			#region Set/Get Uniform (double-precision floating-point matrix data)

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Matrix3x3d m)
			{
				Gl.ProgramUniformMatrix3d(program.ObjectName, uniform.Location, 1, false, m);
			}

			void IUniformBackend.SetUniform(GraphicsContext ctx, ShaderProgram program, UniformBinding uniform, Matrix4x4d m)
			{
				Gl.ProgramUniformMatrix4d(program.ObjectName, uniform.Location, 1, false, m);
			}

			#endregion

#endif

			#endregion
		}

		#endregion
	}
}
