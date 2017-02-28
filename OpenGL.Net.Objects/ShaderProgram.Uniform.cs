
// Copyright (C) 2009-2016 Luca Piccioni
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
			public UniformBinding(string name, int location)
			{
				if (name == null)
					throw new ArgumentNullException("name");

				Index = UInt32.MaxValue;
				Name = name;
				Location = location;
			}

			public UniformBinding(GraphicsContext ctx, ShaderProgram program, uint uniformIndex)
			{
				// Name, size, type
				int uniformBufferSize;

				Gl.GetProgram(program.ObjectName, Gl.ACTIVE_UNIFORM_MAX_LENGTH, out uniformBufferSize);

				StringBuilder uniformNameBuilder = new StringBuilder(uniformBufferSize + 2);
				int uniformNameLength, uniformSize, uniformType;

				uniformNameBuilder.EnsureCapacity(uniformBufferSize);

				Gl.GetActiveUniform(program.ObjectName, uniformIndex, uniformBufferSize, out uniformNameLength, out uniformSize, out uniformType, uniformNameBuilder);

				// Uniform information
				Index = uniformIndex;
				Name = uniformNameBuilder.ToString();
				UniformType = (ShaderUniformType)uniformType;
				Location = Gl.GetUniformLocation(program.ObjectName, Name);

				// Uniform block information
				BlockIndex = -1;
				BlockOffset = -1;
				BlockArrayStride = -1;
				BlockMatrixStride = -1;
				BlockMatrixRowMajor = false;
			}

			public UniformBinding(
				GraphicsContext ctx, ShaderProgram program, uint uniformIndex, int nameLen, int uniformType,
				int blockIndex, int blockOffset, int blockArrayStride, int blockMatrixStride, bool rowMajor
				)
			{
				Debug.Assert(ctx.Version >= Gl.Version_310 || ctx.Extensions.UniformBufferObject_ARB);

				// Name
				StringBuilder uniformNameBuilder = new StringBuilder(nameLen + 2);
				int uniformNameLength;

				uniformNameBuilder.EnsureCapacity(nameLen);

				Gl.GetActiveUniformName(program.ObjectName, uniformIndex, nameLen, out uniformNameLength, uniformNameBuilder);

				// Uniform information
				Index = uniformIndex;
				Name = uniformNameBuilder.ToString();
				UniformType = (ShaderUniformType)uniformType;
				Location = Gl.GetUniformLocation(program.ObjectName, Name);

				// Uniform block information
				BlockIndex = blockIndex;
				BlockOffset = blockOffset;
				BlockArrayStride = blockArrayStride;
				BlockMatrixStride = blockMatrixStride;
				BlockMatrixRowMajor = rowMajor;
			}

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
			public readonly ShaderUniformType UniformType = ShaderUniformType.Unknown;

			/// <summary>
			/// The uniform block index for this uniform, which can be used to query information about this block. If this
			/// uniform is not in a block, the value will be -1.
			/// </summary>
			public readonly int BlockIndex;

			/// <summary>
			/// The byte offset into the beginning of the uniform block for this uniform. If the uniform is not in a block,
			/// the value will be -1.
			/// </summary>
			public readonly int BlockOffset;

			/// <summary>
			/// The byte stride for elements of the array, for uniforms in a uniform block. For non-array uniforms in a block,
			/// this value is 0. For uniforms not in a block, the value will be -1.
			/// </summary>
			public readonly int BlockArrayStride;

			/// <summary>
			/// The byte stride for columns of a column-major matrix or rows for a row-major matrix, for uniforms in a uniform
			/// block. For non-matrix uniforms in a block, this value is 0. For uniforms not in a block, the value will be -1.
			/// </summary>
			public readonly int BlockMatrixStride;

			/// <summary>
			/// It's true if the matrix is row-major and the uniform is in a block. false is returned if the uniform is column-major,
			/// the uniform is not in a block (all non-block matrices are column-major), or simply not a matrix type.
			/// </summary>
			public readonly bool BlockMatrixRowMajor;
		}

		private void CollectActiveUniforms(GraphicsContext ctx)
		{
			int activeUniforms;

			Gl.GetProgram(ObjectName, Gl.ACTIVE_UNIFORMS, out activeUniforms);

			// Clear uniform mapping
			_UniformMap.Clear();
			_DefaultBlockUniformSlots = 0;

			if ((ctx.Version >= Gl.Version_310) || (ctx.Extensions.UniformBufferObject_ARB == true)) {
				uint[] uniformIndices = new uint[activeUniforms];
				for (uint i = 0; i < activeUniforms; i++) uniformIndices[i] = i;

				int[] uniformType = new int[activeUniforms];
				int[] uniformNameLen = new int[activeUniforms];
				int[] uniformBlockIndex = new int[activeUniforms];
				int[] uniformOffset = new int[activeUniforms];
				int[] uniformArrayStride = new int[activeUniforms];
				int[] uniformMatrixStride = new int[activeUniforms];
				int[] uniformRowMajor = new int[activeUniforms];

				Gl.GetActiveUniforms(ObjectName, uniformIndices, Gl.UNIFORM_TYPE, uniformType);
				Gl.GetActiveUniforms(ObjectName, uniformIndices, Gl.UNIFORM_NAME_LENGTH, uniformNameLen);
				Gl.GetActiveUniforms(ObjectName, uniformIndices, Gl.UNIFORM_BLOCK_INDEX, uniformBlockIndex);
				Gl.GetActiveUniforms(ObjectName, uniformIndices, Gl.UNIFORM_OFFSET, uniformOffset);
				Gl.GetActiveUniforms(ObjectName, uniformIndices, Gl.UNIFORM_ARRAY_STRIDE, uniformArrayStride);
				Gl.GetActiveUniforms(ObjectName, uniformIndices, Gl.UNIFORM_MATRIX_STRIDE, uniformMatrixStride);
				Gl.GetActiveUniforms(ObjectName, uniformIndices, Gl.UNIFORM_IS_ROW_MAJOR, uniformRowMajor);

				for (int i = 0; i < activeUniforms; i++) {
					UniformBinding uniformBinding = new UniformBinding(
						ctx, this, (uint)i, uniformNameLen[i], uniformType[i],
						uniformBlockIndex[i], uniformOffset[i], uniformArrayStride[i], uniformMatrixStride[i], uniformRowMajor[i] != Gl.FALSE
					);

					_UniformMap.Add(uniformBinding.Name, uniformBinding);

					CheckStructuredUniform(uniformBinding);
				}
			} else {
				for (int i = 0; i < activeUniforms; i++) {
					UniformBinding uniformBinding = new UniformBinding(ctx, this, (uint)i);

					_UniformMap.Add(uniformBinding.Name, uniformBinding);

					CheckStructuredUniform(uniformBinding);
				}
			}

			// Log uniform location mapping
			List<string> uniformNames = new List<string>(_UniformMap.Keys);

			// Make uniform list invariant respect the used driver (ease log comparation)
			uniformNames.Sort();

			if (LogEnabled) {
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

				Log("Shader program active uniform slots: {0}", _DefaultBlockUniformSlots);
			}
		}

		private void CheckStructuredUniform(UniformBinding uniformBinding)
		{
			Match uniformStructure = Regex.Match(uniformBinding.Name, @"((?<Struct>[\w\d_]+(\[\d+\])?)(\.))+");

			if (uniformStructure.Success) {
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
		}

		/// <summary>
		/// Map active uniform location with uniform name.
		/// </summary>
		private readonly UniformDictionary _UniformMap = new UniformDictionary();

		/// <summary>
		/// The number of slots used for storing uniform data.
		/// </summary>
		public uint UniformSlots { get { return (_DefaultBlockUniformSlots); } }

		/// <summary>
		/// Uniform slots used by the default block of this shader program.
		/// </summary>
		private uint _DefaultBlockUniformSlots;

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
		/// Backend implemented for loading uniform state.
		/// </summary>
		interface IUniformBackend
		{
			#region Set/Get Uniform (single-precision floating-point vector data)

			void SetUniform(ShaderProgram program, UniformBinding uniform, float v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, float x, float y);

			void SetUniform(ShaderProgram program, UniformBinding uniform, float x, float y, float z);

			void SetUniform(ShaderProgram program, UniformBinding uniform, float x, float y, float z, float w);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2f v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3f v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4f v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2f[] v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3f[] v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4f[] v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, ColorRGBAF c);

			void SetUniform(ShaderProgram program, UniformBinding uniform, ColorRGBAF[] c);

			#endregion

			#region Set/Get Uniform (integer vector data)

			void SetUniform(ShaderProgram program, UniformBinding uniform, int v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, int x, int y);

			void SetUniform(ShaderProgram program, UniformBinding uniform, int x, int y, int z);

			void SetUniform(ShaderProgram program, UniformBinding uniform, int x, int y, int z, int w);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2i v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3i v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4i v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2i[] v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3i[] v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4i[] v);

			#endregion

			#region Set/Get Uniform (unsigned integer vector data)

			void SetUniform(ShaderProgram program, UniformBinding uniform, uint v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, uint x, uint y);

			void SetUniform(ShaderProgram program, UniformBinding uniform, uint x, uint y, uint z);

			void SetUniform(ShaderProgram program, UniformBinding uniform, uint x, uint y, uint z, uint w);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2ui v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3ui v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4ui v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2ui[] v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3ui[] v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4ui[] v);

			#endregion

			#region Set/Get Uniform (boolean vector data)

			void SetUniform(ShaderProgram program, UniformBinding uniform, bool v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, bool x, bool y);

			void SetUniform(ShaderProgram program, UniformBinding uniform, bool x, bool y, bool z);

			void SetUniform(ShaderProgram program, UniformBinding uniform, bool x, bool y, bool z, bool w);

			#endregion

			#region Set/Get Uniform (single-precision floating-point matrix data)

			void SetUniform(ShaderProgram program, UniformBinding uniform, Matrix m);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Matrix3x3 m);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Matrix4x4 m);

			#endregion

			#region Set/Get Uniform (sampler-compatible data)

			void SetUniform(ShaderProgram program, UniformBinding uniform, Texture texture);

			#endregion

			#region Set/Get Uniform (double-precision floating-point vector data)

			void SetUniform(ShaderProgram program, UniformBinding uniform, double v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, double x, double y);

			void SetUniform(ShaderProgram program, UniformBinding uniform, double x, double y, double z);

			void SetUniform(ShaderProgram program, UniformBinding uniform, double x, double y, double z, double w);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2d v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3d v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4d v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2d[] v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3d[] v);

			void SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4d[] v);

			#endregion

			#region Set/Get Uniform (double-precision floating-point matrix data)

			void SetUniform(ShaderProgram program, UniformBinding uniform, MatrixDouble m);

			void SetUniform(ShaderProgram program, UniformBinding uniform, MatrixDouble3x3 m);

			void SetUniform(ShaderProgram program, UniformBinding uniform, MatrixDouble4x4 m);

			#endregion
		}

		/// <summary>
		/// Current uniform backend used for setting this program uniform state.
		/// </summary>
		private IUniformBackend _UniformBackend;

		#endregion

		#region Uniform Backend (Compatible)

		/// <summary>
		/// The <see cref="IUniformBackend"/> implementation for compatibility implementation based on glUniform*
		/// commands. They had been superseeded by glProgramUniform* commands available with ARB_separate_shader_object.
		/// </summary>
		class UniformBackendCompatible : IUniformBackend
		{
			#region IUniformBackend Implementation

			#region Set/Get Uniform (single-precision floating-point vector data)

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, float v)
			{
				Gl.Uniform1(uniform.Location, v);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, float x, float y)
			{
				Gl.Uniform2(uniform.Location, x, y);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, float x, float y, float z)
			{
				Gl.Uniform3(uniform.Location, x, y, z);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, float x, float y, float z, float w)
			{
				Gl.Uniform4(uniform.Location, x, y, z, w);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2f v)
			{
				unsafe {
					Gl.Uniform2(uniform.Location, 1, (float*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3f v)
			{
				unsafe {
					Gl.Uniform3(uniform.Location, 1, (float*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4f v)
			{
				unsafe {
					Gl.Uniform4(uniform.Location, 1, (float*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2f[] v)
			{
				unsafe {
					fixed (Vertex2f* p_v = v) {
						Gl.Uniform2(uniform.Location, v.Length, (float*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3f[] v)
			{
				unsafe {
					fixed (Vertex3f* p_v = v) {
						Gl.Uniform3(uniform.Location, v.Length, (float*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4f[] v)
			{
				unsafe {
					fixed (Vertex4f* p_v = v) {
						Gl.Uniform4(uniform.Location, v.Length, (float*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, ColorRGBAF c)
			{
				unsafe {
					Gl.Uniform4(uniform.Location, 1, (float*)&c);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, ColorRGBAF[] c)
			{
				unsafe {
					fixed (ColorRGBAF* p_c = c) {
						Gl.Uniform4(uniform.Location, c.Length, (float*)p_c);
					}
				}
			}

			#endregion

			#region Set/Get Uniform (integer vector data)

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, int v)
			{
				Gl.Uniform1(uniform.Location, v);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, int x, int y)
			{
				Gl.Uniform2(uniform.Location, x, y);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, int x, int y, int z)
			{
				Gl.Uniform3(uniform.Location, x, y, z);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, int x, int y, int z, int w)
			{
				Gl.Uniform4(uniform.Location, x, y, z, w);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2i v)
			{
				unsafe {
					Gl.Uniform2(uniform.Location, 1, (int*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3i v)
			{
				unsafe {
					Gl.Uniform3(uniform.Location, 1, (int*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4i v)
			{
				unsafe {
					Gl.Uniform4(uniform.Location, 1, (int*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2i[] v)
			{
				unsafe {
					fixed (Vertex2i* p_v = v) {
						Gl.Uniform2(uniform.Location, v.Length, (int*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3i[] v)
			{
				unsafe {
					fixed (Vertex3i* p_v = v) {
						Gl.Uniform3(uniform.Location, v.Length, (int*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4i[] v)
			{
				unsafe {
					fixed (Vertex4i* p_v = v) {
						Gl.Uniform4(uniform.Location, v.Length, (int*)p_v);
					}
				}
			}

			#endregion

			#region Set/Get Uniform (unsigned integer vector data)

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, uint v)
			{
				Gl.Uniform1(uniform.Location, v);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, uint x, uint y)
			{
				Gl.Uniform2(uniform.Location, x, y);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, uint x, uint y, uint z)
			{
				Gl.Uniform3(uniform.Location, x, y, z);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, uint x, uint y, uint z, uint w)
			{
				Gl.Uniform4(uniform.Location, x, y, z, w);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2ui v)
			{
				unsafe {
					Gl.Uniform2(uniform.Location, 1, (uint*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3ui v)
			{
				unsafe {
					Gl.Uniform3(uniform.Location, 1, (uint*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4ui v)
			{
				unsafe {
					Gl.Uniform4(uniform.Location, 1, (uint*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2ui[] v)
			{
				unsafe {
					fixed (Vertex2ui* p_v = v) {
						Gl.Uniform2(uniform.Location, v.Length, (uint*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3ui[] v)
			{
				unsafe {
					fixed (Vertex3ui* p_v = v) {
						Gl.Uniform3(uniform.Location, v.Length, (uint*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4ui[] v)
			{
				unsafe {
					fixed (Vertex4ui* p_v = v) {
						Gl.Uniform4(uniform.Location, v.Length, (uint*)p_v);
					}
				}
			}

			#endregion

			#region Set/Get Uniform (boolean vector data)

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, bool v)
			{
				Gl.Uniform1(uniform.Location, v ? 1 : 0);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, bool x, bool y)
			{
				Gl.Uniform2(uniform.Location, x ? 1 : 0, y ? 1 : 0);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, bool x, bool y, bool z)
			{
				Gl.Uniform3(uniform.Location, x ? 1 : 0, y ? 1 : 0, z ? 1 : 0);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, bool x, bool y, bool z, bool w)
			{
				Gl.Uniform4(uniform.Location, x ? 1 : 0, y ? 1 : 0, z ? 1 : 0, w ? 1 : 0);
			}

			#endregion

			#region Set/Get Uniform (single-precision floating-point matrix data)

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Matrix m)
			{
				switch (uniform.UniformType) {
					case ShaderUniformType.Mat2x2:
						if ((m.Width != 2) || (m.Height != 2))
							throw new ArgumentException("matrix size mismatch");
						Gl.UniformMatrix2(uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat2x3:
						if ((m.Width != 2) || (m.Height != 3))
							throw new ArgumentException("matrix size mismatch");
						Gl.UniformMatrix2x3(uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat2x4:
						if ((m.Width != 2) || (m.Height != 4))
							throw new ArgumentException("matrix size mismatch");
						Gl.UniformMatrix2x4(uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat3x2:
						if ((m.Width != 3) || (m.Height != 2))
							throw new ArgumentException("matrix size mismatch");
						Gl.UniformMatrix3x2(uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat3x3:
						if ((m.Width != 3) || (m.Height != 3))
							throw new ArgumentException("matrix size mismatch");
						Gl.UniformMatrix3(uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat3x4:
						if ((m.Width != 3) || (m.Height != 4))
							throw new ArgumentException("matrix size mismatch");
						Gl.UniformMatrix3x4(uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat4x2:
						if ((m.Width != 4) || (m.Height != 2))
							throw new ArgumentException("matrix size mismatch");
						Gl.UniformMatrix4x2(uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat4x3:
						if ((m.Width != 4) || (m.Height != 3))
							throw new ArgumentException("matrix size mismatch");
						Gl.UniformMatrix4x3(uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat4x4:
						if ((m.Width != 4) || (m.Height != 4))
							throw new ArgumentException("matrix size mismatch");
						Gl.UniformMatrix4(uniform.Location, 1, false, m.Buffer);
						break;
					default:
						throw new NotSupportedException(String.Format("uniform type {0} not assignable from Matrix{1}x{2}", uniform.UniformType, m.Width, m.Height));
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Matrix3x3 m)
			{
				Gl.UniformMatrix3(uniform.Location, 1, false, m.Buffer);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Matrix4x4 m)
			{
				Gl.UniformMatrix4(uniform.Location, 1, false, m.Buffer);
			}

			#endregion

			#region Set/Get Uniform (sampler-compatible data)

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Texture texture)
			{
				// Set uniform value (sampler)
				// Cast to Int32 since the sampler type can be set only with glUniform1i
				Gl.Uniform1(uniform.Location, (int)texture.ActiveTextureUnit);
			}

			#endregion

			#region Set/Get Uniform (double-precision floating-point vector data)

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, double v)
			{
				Gl.Uniform1(uniform.Location, v);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, double x, double y)
			{
				Gl.Uniform2(uniform.Location, x, y);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, double x, double y, double z)
			{
				Gl.Uniform3(uniform.Location, x, y, z);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, double x, double y, double z, double w)
			{
				Gl.Uniform4(uniform.Location, x, y, z, w);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2d v)
			{
				unsafe {
					Gl.Uniform2(uniform.Location, 1, (double*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3d v)
			{
				unsafe {
					Gl.Uniform3(uniform.Location, 1, (double*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4d v)
			{
				unsafe {
					Gl.Uniform4(uniform.Location, 1, (double*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2d[] v)
			{
				unsafe {
					fixed (Vertex2d* p_v = v) {
						Gl.Uniform2(uniform.Location, v.Length, (double*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3d[] v)
			{
				unsafe {
					fixed (Vertex3d* p_v = v) {
						Gl.Uniform3(uniform.Location, v.Length, (double*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4d[] v)
			{
				unsafe {
					fixed (Vertex4d* p_v = v) {
						Gl.Uniform4(uniform.Location, v.Length, (double*)p_v);
					}
				}
			}

			#endregion

			#region Set/Get Uniform (double-precision floating-point matrix data)

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, MatrixDouble m)
			{
				switch (uniform.UniformType) {
					case ShaderUniformType.Mat2x2:
						if ((m.Width != 2) || (m.Height != 2))
							throw new ArgumentException("matrix size mismatch");
						Gl.UniformMatrix2(uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat2x3:
						if ((m.Width != 2) || (m.Height != 3))
							throw new ArgumentException("matrix size mismatch");
						Gl.UniformMatrix2x3(uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat2x4:
						if ((m.Width != 2) || (m.Height != 4))
							throw new ArgumentException("matrix size mismatch");
						Gl.UniformMatrix2x4(uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat3x2:
						if ((m.Width != 3) || (m.Height != 2))
							throw new ArgumentException("matrix size mismatch");
						Gl.UniformMatrix3x2(uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat3x3:
						if ((m.Width != 3) || (m.Height != 3))
							throw new ArgumentException("matrix size mismatch");
						Gl.UniformMatrix3(uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat3x4:
						if ((m.Width != 3) || (m.Height != 4))
							throw new ArgumentException("matrix size mismatch");
						Gl.UniformMatrix3x4(uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat4x2:
						if ((m.Width != 4) || (m.Height != 2))
							throw new ArgumentException("matrix size mismatch");
						Gl.UniformMatrix4x2(uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat4x3:
						if ((m.Width != 4) || (m.Height != 3))
							throw new ArgumentException("matrix size mismatch");
						Gl.UniformMatrix4x3(uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat4x4:
						if ((m.Width != 4) || (m.Height != 4))
							throw new ArgumentException("matrix size mismatch");
						Gl.UniformMatrix4(uniform.Location, 1, false, m.Buffer);
						break;
					default:
						throw new NotSupportedException(String.Format("uniform type {0} not assignable from Matrix{1}x{2}", uniform.UniformType, m.Width, m.Height));
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, MatrixDouble3x3 m)
			{
				Gl.UniformMatrix3(uniform.Location, 1, false, m.Buffer);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, MatrixDouble4x4 m)
			{
				Gl.UniformMatrix4(uniform.Location, 1, false, m.Buffer);
			}

			#endregion

			#endregion
		}

		#endregion

		#region Uniform Backend (Separable)

		/// <summary>
		/// The <see cref="IUniformBackend"/> implementation for compatibility implementation based on glProgramUniform*
		/// commands.
		/// </summary>
		class UniformBackendSeparable : IUniformBackend
		{
			#region IUniformBackend Implementation

			#region Set/Get Uniform (single-precision floating-point vector data)

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, float v)
			{
				Gl.ProgramUniform1(program.ObjectName, uniform.Location, v);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, float x, float y)
			{
				Gl.ProgramUniform2(program.ObjectName, uniform.Location, x, y);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, float x, float y, float z)
			{
				Gl.ProgramUniform3(program.ObjectName, uniform.Location, x, y, z);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, float x, float y, float z, float w)
			{
				Gl.ProgramUniform4(program.ObjectName, uniform.Location, x, y, z, w);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2f v)
			{
				unsafe {
					Gl.ProgramUniform2(program.ObjectName, uniform.Location, 1, (float*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3f v)
			{
				unsafe {
					Gl.ProgramUniform3(program.ObjectName, uniform.Location, 1, (float*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4f v)
			{
				unsafe {
					Gl.ProgramUniform4(program.ObjectName, uniform.Location, 1, (float*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2f[] v)
			{
				unsafe {
					fixed (Vertex2f* p_v = v) {
						Gl.ProgramUniform2(program.ObjectName, uniform.Location, v.Length, (float*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3f[] v)
			{
				unsafe {
					fixed (Vertex3f* p_v = v) {
						Gl.ProgramUniform3(program.ObjectName, uniform.Location, v.Length, (float*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4f[] v)
			{
				unsafe {
					fixed (Vertex4f* p_v = v) {
						Gl.ProgramUniform4(program.ObjectName, uniform.Location, v.Length, (float*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, ColorRGBAF c)
			{
				unsafe {
					Gl.ProgramUniform4(program.ObjectName, uniform.Location, 1, (float*)&c);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, ColorRGBAF[] c)
			{
				unsafe {
					fixed (ColorRGBAF* p_c = c) {
						Gl.ProgramUniform4(program.ObjectName, uniform.Location, c.Length, (float*)p_c);
					}
				}
			}

			#endregion

			#region Set/Get Uniform (integer vector data)

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, int v)
			{
				Gl.ProgramUniform1(program.ObjectName, uniform.Location, v);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, int x, int y)
			{
				Gl.ProgramUniform2(program.ObjectName, uniform.Location, x, y);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, int x, int y, int z)
			{
				Gl.ProgramUniform3(program.ObjectName, uniform.Location, x, y, z);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, int x, int y, int z, int w)
			{
				Gl.ProgramUniform4(program.ObjectName, uniform.Location, x, y, z, w);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2i v)
			{
				unsafe {
					Gl.ProgramUniform2(program.ObjectName, uniform.Location, 1, (int*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3i v)
			{
				unsafe {
					Gl.ProgramUniform3(program.ObjectName, uniform.Location, 1, (int*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4i v)
			{
				unsafe {
					Gl.ProgramUniform4(program.ObjectName, uniform.Location, 1, (int*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2i[] v)
			{
				unsafe {
					fixed (Vertex2i* p_v = v) {
						Gl.ProgramUniform2(program.ObjectName, uniform.Location, v.Length, (int*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3i[] v)
			{
				unsafe {
					fixed (Vertex3i* p_v = v) {
						Gl.ProgramUniform3(program.ObjectName, uniform.Location, v.Length, (int*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4i[] v)
			{
				unsafe {
					fixed (Vertex4i* p_v = v) {
						Gl.ProgramUniform4(program.ObjectName, uniform.Location, v.Length, (int*)p_v);
					}
				}
			}

			#endregion

			#region Set/Get Uniform (unsigned integer vector data)

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, uint v)
			{
				Gl.ProgramUniform1(program.ObjectName, uniform.Location, v);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, uint x, uint y)
			{
				Gl.ProgramUniform2(program.ObjectName, uniform.Location, x, y);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, uint x, uint y, uint z)
			{
				Gl.ProgramUniform3(program.ObjectName, uniform.Location, x, y, z);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, uint x, uint y, uint z, uint w)
			{
				Gl.ProgramUniform4(program.ObjectName, uniform.Location, x, y, z, w);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2ui v)
			{
				unsafe {
					Gl.ProgramUniform2(program.ObjectName, uniform.Location, 1, (uint*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3ui v)
			{
				unsafe {
					Gl.ProgramUniform3(program.ObjectName, uniform.Location, 1, (uint*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4ui v)
			{
				unsafe {
					Gl.ProgramUniform4(program.ObjectName, uniform.Location, 1, (uint*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2ui[] v)
			{
				unsafe {
					fixed (Vertex2ui* p_v = v) {
						Gl.ProgramUniform2(program.ObjectName, uniform.Location, v.Length, (uint*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3ui[] v)
			{
				unsafe {
					fixed (Vertex3ui* p_v = v) {
						Gl.ProgramUniform3(program.ObjectName, uniform.Location, v.Length, (uint*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4ui[] v)
			{
				unsafe {
					fixed (Vertex4ui* p_v = v) {
						Gl.ProgramUniform4(program.ObjectName, uniform.Location, v.Length, (uint*)p_v);
					}
				}
			}

			#endregion

			#region Set/Get Uniform (boolean vector data)

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, bool v)
			{
				Gl.ProgramUniform1(program.ObjectName, uniform.Location, v ? 1 : 0);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, bool x, bool y)
			{
				Gl.ProgramUniform2(program.ObjectName, uniform.Location, x ? 1 : 0, y ? 1 : 0);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, bool x, bool y, bool z)
			{
				Gl.ProgramUniform3(program.ObjectName, uniform.Location, x ? 1 : 0, y ? 1 : 0, z ? 1 : 0);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, bool x, bool y, bool z, bool w)
			{
				Gl.ProgramUniform4(program.ObjectName, uniform.Location, x ? 1 : 0, y ? 1 : 0, z ? 1 : 0, w ? 1 : 0);
			}

			#endregion

			#region Set/Get Uniform (single-precision floating-point matrix data)

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Matrix m)
			{
				switch (uniform.UniformType) {
					case ShaderUniformType.Mat2x2:
						if ((m.Width != 2) || (m.Height != 2))
							throw new ArgumentException("matrix size mismatch");
						Gl.ProgramUniformMatrix2(program.ObjectName, uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat2x3:
						if ((m.Width != 2) || (m.Height != 3))
							throw new ArgumentException("matrix size mismatch");
						Gl.ProgramUniformMatrix2x3(program.ObjectName, uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat2x4:
						if ((m.Width != 2) || (m.Height != 4))
							throw new ArgumentException("matrix size mismatch");
						Gl.ProgramUniformMatrix2x4(program.ObjectName, uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat3x2:
						if ((m.Width != 3) || (m.Height != 2))
							throw new ArgumentException("matrix size mismatch");
						Gl.ProgramUniformMatrix3x2(program.ObjectName, uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat3x3:
						if ((m.Width != 3) || (m.Height != 3))
							throw new ArgumentException("matrix size mismatch");
						Gl.ProgramUniformMatrix3(program.ObjectName, uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat3x4:
						if ((m.Width != 3) || (m.Height != 4))
							throw new ArgumentException("matrix size mismatch");
						Gl.ProgramUniformMatrix3x4(program.ObjectName, uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat4x2:
						if ((m.Width != 4) || (m.Height != 2))
							throw new ArgumentException("matrix size mismatch");
						Gl.ProgramUniformMatrix4x2(program.ObjectName, uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat4x3:
						if ((m.Width != 4) || (m.Height != 3))
							throw new ArgumentException("matrix size mismatch");
						Gl.ProgramUniformMatrix4x3(program.ObjectName, uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat4x4:
						if ((m.Width != 4) || (m.Height != 4))
							throw new ArgumentException("matrix size mismatch");
						Gl.ProgramUniformMatrix4(program.ObjectName, uniform.Location, 1, false, m.Buffer);
						break;
					default:
						throw new NotSupportedException(String.Format("uniform type {0} not assignable from Matrix{1}x{2}", uniform.UniformType, m.Width, m.Height));
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Matrix3x3 m)
			{
				Gl.ProgramUniformMatrix3(program.ObjectName, uniform.Location, 1, false, m.Buffer);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Matrix4x4 m)
			{
				Gl.ProgramUniformMatrix4(program.ObjectName, uniform.Location, 1, false, m.Buffer);
			}

			#endregion

			#region Set/Get Uniform (sampler-compatible data)

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Texture texture)
			{
				// Set uniform value (sampler)
				// Cast to Int32 since the sampler type can be set only with glUniform1i
				Gl.ProgramUniform1(program.ObjectName, uniform.Location, (int)texture.ActiveTextureUnit);
			}

			#endregion

			#region Set/Get Uniform (double-precision floating-point vector data)

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, double v)
			{
				Gl.ProgramUniform1(program.ObjectName, uniform.Location, v);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, double x, double y)
			{
				Gl.ProgramUniform2(program.ObjectName, uniform.Location, x, y);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, double x, double y, double z)
			{
				Gl.ProgramUniform3(program.ObjectName, uniform.Location, x, y, z);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, double x, double y, double z, double w)
			{
				Gl.ProgramUniform4(program.ObjectName, uniform.Location, x, y, z, w);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2d v)
			{
				unsafe {
					Gl.ProgramUniform2(program.ObjectName, uniform.Location, 1, (double*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3d v)
			{
				unsafe {
					Gl.ProgramUniform3(program.ObjectName, uniform.Location, 1, (double*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4d v)
			{
				unsafe {
					Gl.ProgramUniform4(program.ObjectName, uniform.Location, 1, (double*)&v);
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex2d[] v)
			{
				unsafe {
					fixed (Vertex2d* p_v = v) {
						Gl.ProgramUniform2(program.ObjectName, uniform.Location, v.Length, (double*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex3d[] v)
			{
				unsafe {
					fixed (Vertex3d* p_v = v) {
						Gl.ProgramUniform3(program.ObjectName, uniform.Location, v.Length, (double*)p_v);
					}
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, Vertex4d[] v)
			{
				unsafe {
					fixed (Vertex4d* p_v = v) {
						Gl.ProgramUniform4(program.ObjectName, uniform.Location, v.Length, (double*)p_v);
					}
				}
			}

			#endregion

			#region Set/Get Uniform (double-precision floating-point matrix data)

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, MatrixDouble m)
			{
				switch (uniform.UniformType) {
					case ShaderUniformType.Mat2x2:
						if ((m.Width != 2) || (m.Height != 2))
							throw new ArgumentException("matrix size mismatch");
						Gl.ProgramUniformMatrix2(program.ObjectName, uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat2x3:
						if ((m.Width != 2) || (m.Height != 3))
							throw new ArgumentException("matrix size mismatch");
						Gl.ProgramUniformMatrix2x3(program.ObjectName, uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat2x4:
						if ((m.Width != 2) || (m.Height != 4))
							throw new ArgumentException("matrix size mismatch");
						Gl.ProgramUniformMatrix2x4(program.ObjectName, uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat3x2:
						if ((m.Width != 3) || (m.Height != 2))
							throw new ArgumentException("matrix size mismatch");
						Gl.ProgramUniformMatrix3x2(program.ObjectName, uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat3x3:
						if ((m.Width != 3) || (m.Height != 3))
							throw new ArgumentException("matrix size mismatch");
						Gl.ProgramUniformMatrix3(program.ObjectName, uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat3x4:
						if ((m.Width != 3) || (m.Height != 4))
							throw new ArgumentException("matrix size mismatch");
						Gl.ProgramUniformMatrix3x4(program.ObjectName, uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat4x2:
						if ((m.Width != 4) || (m.Height != 2))
							throw new ArgumentException("matrix size mismatch");
						Gl.ProgramUniformMatrix4x2(program.ObjectName, uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat4x3:
						if ((m.Width != 4) || (m.Height != 3))
							throw new ArgumentException("matrix size mismatch");
						Gl.ProgramUniformMatrix4x3(program.ObjectName, uniform.Location, 1, false, m.Buffer);
						break;
					case ShaderUniformType.Mat4x4:
						if ((m.Width != 4) || (m.Height != 4))
							throw new ArgumentException("matrix size mismatch");
						Gl.ProgramUniformMatrix4(program.ObjectName, uniform.Location, 1, false, m.Buffer);
						break;
					default:
						throw new NotSupportedException(String.Format("uniform type {0} not assignable from Matrix{1}x{2}", uniform.UniformType, m.Width, m.Height));
				}
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, MatrixDouble3x3 m)
			{
				Gl.ProgramUniformMatrix3(program.ObjectName, uniform.Location, 1, false, m.Buffer);
			}

			void IUniformBackend.SetUniform(ShaderProgram program, UniformBinding uniform, MatrixDouble4x4 m)
			{
				Gl.ProgramUniformMatrix4(program.ObjectName, uniform.Location, 1, false, m.Buffer);
			}

			#endregion

			#endregion
		}

		#endregion

		#region Uniform State Caching

		/// <summary>
		/// Cache the current uniform value. Used to minimize Uniform* calls at the cost of comparing the cached
		/// object with the call arguments.
		/// </summary>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specifies the uniform variable name.
		/// </param>
		/// <param name="uniformValue">
		/// A <see cref="Object"/> that specifies the uniform variable value.
		/// </param>
		private void CacheUniformValue(string uniformName, object uniformValue)
		{
			Log("  Set uniform: {0} = {1}", uniformName, uniformValue);
			_UniformValues[uniformName] = uniformValue;
		}

		/// <summary>
		/// Cache the current uniform value. Used to minimize Uniform* calls at the cost of comparing the cached
		/// object with the call arguments.
		/// </summary>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specifies the uniform variable name.
		/// </param>
		/// <param name="uniformValue">
		/// A <see cref="Object"/> that specifies the uniform variable value.
		/// </param>
		private void CacheUniformValue(string uniformName, ICloneable uniformValue)
		{
			CacheUniformValue(uniformName, uniformValue.Clone());
		}

		/// <summary>
		/// Determine whether if an uniform value is different from the one currently cached.
		/// </summary>
		/// <param name="uniformName">
		/// A <see cref="String"/> that specifies the uniform variable name.
		/// </param>
		/// <param name="uniformValue">
		/// A <see cref="Object"/> that specifies the uniform variable value updated.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="uniformValue"/> is actually
		/// different from the current uniform value.
		/// </returns>
		private bool IsUniformValueChanged(string uniformName, object uniformValue)
		{
			object cachedValue;

			if (_UniformValues.TryGetValue(uniformName, out cachedValue) == false)
				return (true);

			return (uniformValue.Equals(cachedValue) == false);
		}

		/// <summary>
		/// Map program uniforms with the last value set with SetUniform methods. Used to avoid redundant calls at the cost
		/// of checking for values equality, per program instance.
		/// </summary>
		private readonly UniformCacheDictionary _UniformValues = new UniformCacheDictionary();

		#endregion
	}
}
