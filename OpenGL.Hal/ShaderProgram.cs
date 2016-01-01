
// Copyright (C) 2009-2015 Luca Piccioni
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
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace OpenGL
{
	/// <summary>
	/// Shader program.
	/// </summary>
	/// <remarks>
	/// <para>
	/// ShaderProgram automatically determine the text of the program using the
	/// shader objects attached (and their dependencies). The text shall be compiled
	/// and then linked all toghether to obtain an effective ShaderProgram instance.
	/// </para>
	/// </remarks>
	public partial class ShaderProgram : GraphicsResource
	{
		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		static ShaderProgram()
		{
			// Initialize default shader library
			// ShaderLibrary.Touch();
		}

		/// <summary>
		/// Construct a ShaderProgram.
		/// </summary>
		/// <param name="programName">
		/// A <see cref="System.String"/> that specifies the shader program name.
		/// </param>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if the parameter <paramref name="programName"/> is not a valid name.
		/// </exception>
		public ShaderProgram(string programName)
			: this(programName, null)
		{

		}

		/// <summary>
		/// Construct a ShaderProgram.
		/// </summary>
		/// <param name="programName">
		/// A <see cref="System.String"/> that specifies the shader program name.
		/// </param>
		/// <param name="compilationParams">
		/// A <see cref="ShaderCompilerContext"/>
		/// </param>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if the parameter <paramref name="programName"/> is not a valid name.
		/// </exception>
		public ShaderProgram(string programName, ShaderCompilerContext compilationParams)
			: base(programName)
		{
			try {
				// GraphicsResource allows empty string, enforce check
				if (String.IsNullOrEmpty(programName))
					throw new ArgumentException("invalid", "programName");

				// Default compilation parameter
				_CompilationParams = compilationParams ?? new ShaderCompilerContext();
			} catch {
				// Avoid finalizer assertion failure (don't call dispose since it's virtual)
				GC.SuppressFinalize(this);
				throw;
			}
		}

		#endregion

		#region Program Linkage

		/// <summary>
		/// Attach a ShaderObject to this ShaderProgram.
		/// </summary>
		/// <param name="shaderObject">
		/// A <see cref="ShaderObject"/> to be attached to this ShaderProgram.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="shaderObject"/> is null.
		/// </exception>
		public void AttachShader(ShaderObject shaderObject)
		{
			if (shaderObject == null)
				throw new ArgumentNullException("sObject");

			// Link object
			_ProgramObjects.Add(shaderObject);
			// Force relink
			_Linked = false;
		}

		/// <summary>
		/// Detach an attached ShaderObject from this ShaderProgram.
		/// </summary>
		/// <param name="shaderObject">
		/// A <see cref="ShaderObject"/> to be detached to this ShaderProgram.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="shaderObject"/> is null.
		/// </exception>
		public void DetachShader(ShaderObject shaderObject)
		{
			if (shaderObject == null)
				throw new ArgumentNullException("shaderObject");

			// Remove shader
			_ProgramObjects.Remove(shaderObject);
        }

		/// <summary>
		/// Check the attachment state of a ShaderObject on this ShaderProgram.
		/// </summary>
		/// <param name="shaderObject"></param>
		/// <returns>
		/// It returns a boolean value indicating the attachment state of <paramref name="shaderObject"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="shaderObject"/> is null.
		/// </exception>
		public bool IsAttachedShader(ShaderObject shaderObject)
		{
			if (shaderObject == null)
				throw new ArgumentNullException("shaderObject");

			return (_ProgramObjects.Contains(shaderObject));
		}

		/// <summary>
		/// List of cached shader objects composing this shader program.
		/// </summary>
		private readonly List<ShaderObject> _ProgramObjects = new List<ShaderObject>();

		/// <summary>
		/// Link this ShaderProgram.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for linking this ShaderProgram.
		/// </param>
		/// <param name="cctx">
		/// A <see cref="ShaderCompilerContext"/> that specify additional compiler parameters.
		/// </param>
		/// <remarks>
		/// <para>
		/// Generate shader program source code, compile and link it. After a successfull
		/// link, obtain every information about active uniform and input variables.
		/// </para>
		/// <para>
		/// This routine generate the source code of each attached ShaderObject instance and
		/// compile it. This step is performed only if really required (tendentially every
		/// shader object is already compiled).
		/// </para>
		/// <para>
		/// After having compiled every attached shader object, it's performed the linkage between
		/// shader objects. After this process the ShaderProgram instance can be bound to issue
		/// rendering commands.
		/// </para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown in the case this ShaderProgram is already linked.
		/// </exception>
		/// <exception cref="ShaderException">
		/// Exception throw in the case this ShaderProgram is not linkable.
		/// </exception>
		private void Link(GraphicsContext ctx, ShaderCompilerContext cctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (cctx == null)
				throw new ArgumentNullException("cctx");
			
			// Using a deep copy of the shader compiler context, since it will be modified by this ShaderProgram
			// instance and the attached ShaderObject instances
			cctx = new ShaderCompilerContext(cctx);
			
			#region Compile and Attach Shader Objects
			
			// Ensure cached shader objects
			foreach (ShaderObject shaderObject in _ProgramObjects) {
				// Create shader object, if necessary
				if (shaderObject.Exists(ctx) == false)
					shaderObject.Create(ctx, cctx);
				// Attach shader object
				Gl.AttachShader(ObjectName, shaderObject.ObjectName);
			}

			#endregion

			#region Transform Feedback Definition

			if ((_FeedbackVaryings != null) && (_FeedbackVaryings.Count > 0)) {
				if (!ctx.Caps.GlExtensions.TransformFeedback_EXT)
					throw new InvalidOperationException("transform feedback not supported");

				sLog.Debug("Feedback varyings ({0}):", cctx.FeedbackVaryingsFormat);
				sLog.Indent();
				foreach (string feedbackVarying in _FeedbackVaryings)
					sLog.Debug("- {0}", feedbackVarying);
				sLog.Unindent();

				// Specify program feedback
				Gl.TransformFeedbackVaryings(ObjectName, _FeedbackVaryings.ToArray(), (int)cctx.FeedbackVaryingsFormat);
			}

			#endregion

			#region Bind Fragment Locations

			if (ctx.Caps.GlExtensions.GpuShader4_EXT) {
				// Setup fragment locations, where defined
				foreach (KeyValuePair<string, int> pair in _FragLocations) {
					if (pair.Value >= 0)
						Gl.BindFragDataLocation(ObjectName, (uint) pair.Value, pair.Key);
				}
			}

			#endregion

			#region Link Shader Program Objects

			int lStatus;

			sLog.Debug("Link shader program {0}", Identifier ?? "<Unnamed>");

			// Link shader program
			Gl.LinkProgram(ObjectName);
			// Check for linking errors
			Gl.GetProgram(ObjectName, Gl.LINK_STATUS, out lStatus);

			if (lStatus != Gl.TRUE) {
				const int MaxInfoLength = 4096;

				StringBuilder logInfo = new StringBuilder(MaxInfoLength);
				int logLength;

				// Obtain compilation log
				Gl.GetProgramInfoLog(ObjectName, MaxInfoLength, out logLength, logInfo);

				// Stop link process
				StringBuilder sb = new StringBuilder(logInfo.Capacity);

				string[] compilerLogLines = logInfo.ToString().Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
				foreach (string logLine in compilerLogLines)
					sb.AppendLine("  $ " + logLine);

				sLog.Error("Shader program \"{0}\" linkage failed: {1}", Identifier ?? "<Unnamed>", sb.ToString());

				throw new ShaderException("shader program is not valid. Linker output for {0}: {1}\n", Identifier ?? "<Unnamed>", sb.ToString());
			}
			// Set linked flag
			_Linked = true;

			#endregion

			#region Collect Active Program Uniforms

			int uniformBufferSize, attributeBufferSize;
			int uniformCount;

			// Get active uniforms count
			Gl.GetProgram(ObjectName, Gl.ACTIVE_UNIFORMS, out uniformCount);
			// Get uniforms maximum length for name
			Gl.GetProgram(ObjectName, Gl.ACTIVE_UNIFORM_MAX_LENGTH, out uniformBufferSize);

			// Clear uniform mapping
			_UniformMap.Clear();
			_DefaultBlockUniformSlots = 0;

			// Collect uniform information
			for (uint i = 0; i < (uint)uniformCount; i++) {
				int uniformNameLength, uniformSize, uniformType;

				// Mono optimize StringBuilder capacity after P/Invoke... ensure enought room
				StringBuilder uNameBuilder = new StringBuilder(uniformBufferSize + 2);
				uNameBuilder.EnsureCapacity(uniformBufferSize);

				// Obtain active uniform informations
				Gl.GetActiveUniform(ObjectName, i, uniformBufferSize, out uniformNameLength, out uniformSize, out uniformType, uNameBuilder);

				string uniformName = uNameBuilder.ToString();

				// Obtain active uniform location
				int uLocation = Gl.GetUniformLocation(ObjectName, uniformName);

				UniformBinding uniformBinding = new UniformBinding(uniformName, i, uLocation, (ShaderUniformType)uniformType);

				// Map active uniform
				_UniformMap[uniformName] = uniformBinding;
				// Keep track of used slot
				_DefaultBlockUniformSlots += GetUniformSlotCount(uniformBinding.UniformType);
			}

			// Log uniform location mapping
			List<string> uniformNames = new List<string>(_UniformMap.Keys);

			// Make uniform list invariant respect the used driver (ease log comparation)
			uniformNames.Sort();

			sLog.Debug("Shader program active uniforms:");
			foreach (string uniformName in uniformNames)
				sLog.Debug("\tUniform {0} (Type: {1}, Location: {2})", uniformName, _UniformMap[uniformName].UniformType, _UniformMap[uniformName].Location);

			sLog.Debug("Shader program active uniform slots: {0}", _DefaultBlockUniformSlots);

			#endregion

			#region Collect Active Program Inputs

			// Get active inputs count
			int activeInputs;

			Gl.GetProgram(ObjectName, Gl.ACTIVE_ATTRIBUTES, out activeInputs);
			// Get inputs maximum length for name
			Gl.GetProgram(ObjectName, Gl.ACTIVE_ATTRIBUTE_MAX_LENGTH, out attributeBufferSize);

			// Clear input mapping
			_AttributesMap.Clear();

			// Collect input location mapping
			for (uint i = 0; i < (uint)activeInputs; i++) {
				int aNameLength, aSize, aType;

				// Mono optimize StringBuilder capacity after P/Invoke... ensure enought room
				StringBuilder aNameBuilder = new StringBuilder(attributeBufferSize);
				aNameBuilder.EnsureCapacity(attributeBufferSize);

				// Obtain active input informations
				Gl.GetActiveAttrib(ObjectName, i, attributeBufferSize, out aNameLength, out aSize, out aType, aNameBuilder);
				// Obtain active input location
				int aLocation = Gl.GetAttribLocation(ObjectName, aNameBuilder.ToString());
				// Map active input
				AttributeBinding attributeBinding = new AttributeBinding();
				attributeBinding.Location = (uint)aLocation;
				attributeBinding.Type = (ShaderAttributeType) aType;
				_AttributesMap[aNameBuilder.ToString()] = attributeBinding;
			}

			// Log attribute location mapping
			List<string> attributeNames = new List<string>(_AttributesMap.Keys);

			// Make attribute list invariant respect the used driver (ease log comparation)
			attributeNames.Sort();

			sLog.Debug("Shader program active attributes:");
			foreach (string attributeName in attributeNames)
				sLog.Debug("\tAttribute {0} (Type: {1}, Location: {2})", attributeName, _AttributesMap[attributeName].Type, _AttributesMap[attributeName].Location);

			#endregion

			#region Collect Fragment Locations

			if (ctx.Caps.GlExtensions.GpuShader4_EXT) {
				// Get fragment locations, just in the case automatically assigned
				foreach (string fragOutputName in new List<string>(_FragLocations.Keys))
					_FragLocations[fragOutputName] = Gl.GetFragDataLocation(ObjectName, fragOutputName);
			}

			#endregion
			
			#region Collect Feedback Varyings
			
			if ((_FeedbackVaryings != null) && (_FeedbackVaryings.Count > 0)) {
				int feebackVaryings, feebackVaryingsMaxLength;
				
				Gl.GetProgram(ObjectName, Gl.TRANSFORM_FEEDBACK_VARYINGS, out feebackVaryings);
				Gl.GetProgram(ObjectName, Gl.TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH, out feebackVaryingsMaxLength);
				
				sLog.Debug("Effective feedback varyings:");
				sLog.Indent();
				for (uint i = 0; i < feebackVaryings; i++) {
					StringBuilder sb = new StringBuilder(feebackVaryingsMaxLength);
					int length = 0, size = 0, type = 0;
					
					Gl.GetTransformFeedbackVarying(ObjectName, (uint)i, feebackVaryingsMaxLength, out length, out size, out type, sb);
					
					sLog.Debug("- {0}: {1} ({2}))", sb.ToString(), (ShaderAttributeType)type, size);
				}
				sLog.Unindent();
			}
			
			#endregion
		}

		/// <summary>
		/// Get the number of slots occupied by an uniform type.
		/// </summary>
		/// <param name="uniformType"></param>
		/// <returns></returns>
		private static uint GetUniformSlotCount(ShaderUniformType uniformType)
		{
			switch (uniformType) {
				case ShaderUniformType.Float:
				case ShaderUniformType.Int:
				case ShaderUniformType.UInt:
				case ShaderUniformType.Bool:
					return (1);
				case ShaderUniformType.Vec2:
				case ShaderUniformType.IntVec2:
				case ShaderUniformType.UIntVec2:
				case ShaderUniformType.BoolVec2:
					return (2);
				case ShaderUniformType.Vec3:
				case ShaderUniformType.IntVec3:
				case ShaderUniformType.UIntVec3:
				case ShaderUniformType.BoolVec3:
					return (3);
				case ShaderUniformType.Vec4:
				case ShaderUniformType.IntVec4:
				case ShaderUniformType.UIntVec4:
				case ShaderUniformType.BoolVec4:
					return (4);
				case ShaderUniformType.Mat2x2:
					return (4);
				case ShaderUniformType.Mat3x3:
					return (9);
				case ShaderUniformType.Mat4x4:
					return (16);
				case ShaderUniformType.Mat2x3:
				case ShaderUniformType.Mat3x2:
					return (6);
				case ShaderUniformType.Mat2x4:
				case ShaderUniformType.Mat4x2:
					return (8);
				case ShaderUniformType.Mat3x4:
				case ShaderUniformType.Mat4x3:
					return (12);
				default:
					// Assume sampler type
					return (1);
				case ShaderUniformType.Unknown:
					throw new ArgumentException("invalid type", "uniformType");
			}
		}

		/// <summary>
		/// Property to determine program linkage status.
		/// </summary>
		public bool IsLinked
		{
			get { return (_Linked); }
		}

		/// <summary>
		/// Validate this shader program.
		/// </summary>
		/// <exception cref="Exception">
		/// Throw an Exception in the case the validation has failed.
		/// </exception>
		[Conditional("DEBUG")]
		private void Validate()
		{
			int lStatus;

			if (IsLinked == false)
				throw new InvalidOperationException("not linked");

			// Request program validation
			Gl.ValidateProgram(ObjectName);
			// Check for validation result
			Gl.GetProgram(ObjectName, Gl.VALIDATE_STATUS, out lStatus);

			if (lStatus != Gl.TRUE) {
				const int MaxInfoLength = 4096;

				StringBuilder logInfo = new StringBuilder(256, MaxInfoLength);
				int logLength;

				// Obtain compilation log
				Gl.GetProgramInfoLog(ObjectName, MaxInfoLength, out logLength, logInfo);

				// Stop link process
				StringBuilder sb = new StringBuilder(logInfo.Capacity);

				sb.AppendLine("shader program is not valid. Linker output:");
				string[] linkerLogLines = logInfo.ToString().Split(new char[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
				foreach (string logLine in linkerLogLines)
					sb.AppendLine("  > " + logLine);

				throw new InvalidOperationException(sb.ToString());
			}
		}

		/// <summary>
		/// Linked flag.
		/// </summary>
		private bool _Linked;

		#endregion

		#region Program Creation

		/// <summary>
		/// Create this ShaderProgram, specifying the compiler parameters.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object.
		/// </param>
		/// <param name="cctx">
		/// A <see cref="ShaderCompilerContext"/> that specify the compiler parameters used for compiling and
		/// linking this ShaderProgram.
		/// </param>
		public void Create(GraphicsContext ctx, ShaderCompilerContext cctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (cctx == null)
				throw new ArgumentNullException("cctx");

			// Cache compilation parameters (used by CreateObject)
			_CompilationParams = cctx;
			// Base implementation
			base.Create(ctx);
		}

		/// <summary>
		/// ShaderCompilerContext used for linkage.
		/// </summary>
		public ShaderCompilerContext CompilationParams
		{
			get { return (_CompilationParams); }
			set
			{
				if (IsLinked)
					throw new InvalidOperationException("already linked");
				_CompilationParams = value ?? new ShaderCompilerContext();
			}
		}

		/// <summary>
		/// ShaderCompilerContext used for compilation.
		/// </summary>
		private ShaderCompilerContext _CompilationParams;

		#endregion

		#region Program Binding

		/// <summary>
		/// Bind this ShaderProgram.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for binding.
		/// </param>
		public void Bind(GraphicsContext ctx)
		{
			// int currentProgram;
			
			if (IsLinked == false)
				throw new InvalidOperationException("not linked");

			// Bind this program
			Debug.Assert(ObjectName != InvalidObjectName, "not existing");
			Gl.UseProgram(ObjectName);

			return;

#if false
			// UseProgram only if a different shader program is bound
			Gl.Get(Gl.CURRENT_PROGRAM, out currentProgram);

			if (currentProgram != (int)ObjectName) {
				// Bind this program
				Gl.UseProgram(ObjectName);
			}
#endif
		}

		/// <summary>
		/// Unbind any ShaderProgram.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for binding.
		/// </param>
		public static void Unbind(GraphicsContext ctx)
		{
			// Unbind this program
			Gl.UseProgram(InvalidObjectName);
		}

#endregion

		#region Program Attributes

		/// <summary>
		/// Collection of active attributes on this ShaderProgram.
		/// </summary>
		public ICollection<string> ActiveAttributes
		{
			get {
				return (_AttributesMap.Keys);
			}
		}

		/// <summary>
		/// Determine whether an attributes is active or not.
		/// </summary>
		/// <param name="attributeName">
		/// A <see cref="String"/> which specify the input name.
		/// </param>
		/// <returns>
		/// It returns true in the case the input named <paramref name="attributeName"/> is active.
		/// </returns>
		public bool IsActiveAttribute(string attributeName)
		{
			return (_AttributesMap.ContainsKey(attributeName));
		}

		/// <summary>
		/// Active attributes binding information.
		/// </summary>
		/// <param name="attributeName"></param>
		/// <returns></returns>
		internal AttributeBinding GetActiveAttribute(string attributeName)
		{
			return (_AttributesMap[attributeName]);
		}

		/// <summary>
		/// Information about a shader program attribute.
		/// </summary>
		internal class AttributeBinding
		{
			/// <summary>
			/// Attribute location.
			/// </summary>
			public uint Location;

			/// <summary>
			/// The type of the shader program attribute.
			/// </summary>
			public ShaderAttributeType Type;
		}

		/// <summary>
		/// Map active uniform location with uniform name.
		/// </summary>
		private readonly Dictionary<string, AttributeBinding> _AttributesMap = new Dictionary<string, AttributeBinding>();

		#endregion

		#region Program Attributes Semantic

		/// <summary>
		/// 
		/// </summary>
		/// <param name="attributeName"></param>
		/// <returns></returns>
		public string GetAttributeSemantic(string attributeName)
		{
			string semantic;

			if (attributeName == null)
				throw new ArgumentNullException("attributeName");

			// Extract array name
			Match arrayMatch = Regex.Match(attributeName, @"(?<AttributeName>\w+)\[(?<AttributeIndex>\d+)\]");
			if (arrayMatch.Success)
				attributeName = arrayMatch.Groups["AttributeName"].Value;

			if (_AttributeSemantic.TryGetValue(attributeName, out semantic)) {
				if (arrayMatch.Success)
					semantic = String.Format("{0}[{1}]", semantic, arrayMatch.Groups["AttributeIndex"].Value);

				return (semantic);
			}

			return (null);
		}

		/// <summary>
		/// Define a shader program attribute semantic.
		/// </summary>
		/// <param name="attributeName">
		/// A <see cref="System.String"/> that specify the attribute name. This value doesn't have to match with the actual
		/// shader program attributes.
		/// </param>
		/// <param name="semantic">
		/// A <see cref="System.String"/> that specify the attribute semantic. It can be any value meaninfull for the application.
		/// </param>
		public void SetAttributeSemantic(string attributeName, string semantic)
		{
			if (attributeName == null)
				throw new ArgumentNullException("attributeName");
			if (semantic == null)
				throw new ArgumentNullException("semantic");

			_AttributeSemantic[attributeName] = semantic;
		}

		/// <summary>
		/// Remove a specific attribute semantic.
		/// </summary>
		/// <param name="attributeName">
		/// A <see cref="System.String"/> that specify the attribute name. This value doesn't have to match with the actual
		/// shader program attributes.
		/// </param>
		public void ResetAttributeSemantic(string attributeName)
		{
			if (attributeName == null)
				throw new ArgumentNullException("attributeName");

			_AttributeSemantic.Remove(attributeName);
		}

		/// <summary>
		/// Remove all defined attribute semantics.
		/// </summary>
		public void ClearAttributeSemantic()
		{
			_AttributeSemantic.Clear();
		}

		/// <summary>
		/// Map between program attribute names and attribute semantic.
		/// </summary>
		private readonly Dictionary<string, string> _AttributeSemantic = new Dictionary<string, string>();

		#endregion

		#region Program Feedback Varyings

		/// <summary>
		/// Adds a feedback varying.
		/// </summary>
		/// <param name='varying'>
		/// Varying variable name.
		/// </param>
		/// <exception cref='ArgumentNullException'>
		/// Is thrown when <paramref name="varying"/> passed to a method is invalid because it is <see langword="null" /> .
		/// </exception>
		protected void AddFeedbackVarying(string varying)
		{
			if (varying == null)
				throw new ArgumentNullException("varying");

			if (_FeedbackVaryings == null)
				_FeedbackVaryings = new List<string>();
			_FeedbackVaryings.Add(varying);
		}

		/// <summary>
		/// The feedback varyings of this program.
		/// </summary>
		protected List<string> _FeedbackVaryings;

		#endregion

		#region Fragment Locations

		/// <summary>
		/// Set location of the fragment shader outputs.
		/// </summary>
		/// <param name="fragmentOutputName">
		/// A <see cref="System.String"/> that specify the fragment shader output variable to bind for a specific
		/// location.
		/// </param>
		/// <param name="location">
		/// A <see cref="System.Int32"/> that will be the location of the fragment data written to
		/// <paramref name="fragmentOutputName"/>.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="fragmentOutputName"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="fragmentOutputName"/> starts with "gl_" (reserved name).
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the program has been already linked.
		/// </exception>
		public void SetFragmentLocation(string fragmentOutputName, int location)
		{
			if (fragmentOutputName == null)
				throw new ArgumentNullException("fragmentOutputName");
			if (fragmentOutputName.StartsWith("gl_"))
				throw new ArgumentException("reserved name");
			if (IsLinked)
				throw new InvalidOperationException("already linked");

			_FragLocations[fragmentOutputName] = location;
		}

		/// <summary>
		/// Get the location of the fragment shader output.
		/// </summary>
		/// <param name="fragOutputName"></param>
		/// <returns></returns>
		public int GetFragmentLocation(string fragOutputName)
		{
			if (fragOutputName == null)
				throw new ArgumentNullException("fragOutputName");
			if (fragOutputName.StartsWith("gl"))
				throw new ArgumentException("reserved name");

			return (_FragLocations[fragOutputName]);
		}

		/// <summary>
		/// The location of the fragment shader outputs.
		/// </summary>
		private readonly Dictionary<string, int> _FragLocations = new Dictionary<string, int>();

		/// <summary>
		/// Map between program attribute names and attribute semantic.
		/// </summary>
		private readonly Dictionary<string, string> _FragDataSemantic = new Dictionary<string, string>();

		#endregion

		#region Program Binary

		public void LoadBinary(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (!ctx.Caps.GlExtensions.GetProgramBinary_ARB)
				throw new NotSupportedException("get_program_binary not supported");

			string cachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

			cachePath = Path.Combine(cachePath, CompiledHash + ".glsl");

			byte[] programCache;

			using (FileStream fs = new FileStream(cachePath, FileMode.Open, FileAccess.Read)) {
				programCache = new byte[fs.Length];
				fs.Read(programCache, 0, programCache.Length);
			}

			Gl.ProgramBinary(ObjectName, 0, programCache, programCache.Length);
		}

		public void SaveBinary(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (!ctx.Caps.GlExtensions.GetProgramBinary_ARB)
				throw new NotSupportedException("get_program_binary not supported");
			if (!IsLinked)
				throw new InvalidOperationException("not linked");

			int programCacheLength;

			Gl.GetProgram(ObjectName, Gl.PROGRAM_BINARY_LENGTH, out programCacheLength);

			byte[] programCache = new byte[programCacheLength];
			int programCacheFormat;

			GCHandle programCacheBuffer = GCHandle.Alloc(programCache);

			try {
				Gl.GetProgramBinary(ObjectName, programCache.Length, out programCacheLength, out programCacheFormat, programCacheBuffer.AddrOfPinnedObject());
			} finally {
				programCacheBuffer.Free();
			}

			string cachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

			cachePath = Path.Combine(cachePath, CompiledHash + ".glsl");

			using (FileStream fs = new FileStream(cachePath, FileMode.Create, FileAccess.Write)) {
				fs.Write(programCache, 0, programCache.Length);
			}
		}

		#endregion

		#region Shader Programs Library Support

		/// <summary>
		/// Determine an unique identifier that specify the linked shader program.
		/// </summary>
		/// <param name="cctx">
		/// A <see cref="ShaderCompilerContext"/> determining the compiler parameteres.
		/// </param>
		/// <param name="libraryId">
		/// A <see cref="System.String"/> that identifies the shader object in library.
		/// </param>
		/// <returns>
		/// It returns a string that identify the a shader program classified with <paramref name="libraryId"/> by
		/// specifying <paramref name="cctx"/> as compiled parameters.
		/// </returns>
		internal static string ComputeLibraryHash(ShaderCompilerContext cctx, string libraryId)
		{
			StringBuilder hashMessage = new StringBuilder();

			// Take into account the shader program name
			hashMessage.Append(libraryId);
			// Take into account the shader version
			hashMessage.Append(cctx.ShaderVersion);

			// Do NOT take into account the shader program compilation symbols: they are considered
			// in attached shader objects.

			// Take into account the shader program include paths
			foreach (string includePath in cctx.Includes)
				hashMessage.AppendFormat("{0}", includePath);

			// Hash all information
			byte[] hashBytes;
			using (System.Security.Cryptography.HashAlgorithm hash = System.Security.Cryptography.HashAlgorithm.Create("SHA256")) {
				hashBytes = hash.ComputeHash(Encoding.ASCII.GetBytes(hashMessage.ToString()));
			}

			// ConvertItemType has to string
			return (Convert.ToBase64String(hashBytes));
		}

		/// <summary>
		/// The result of ComputeCompilerHash for this ShaderObject instance.
		/// </summary>
		internal string CompiledHash = String.Empty;

		#endregion

		#region Logging

		/// <summary>
		/// Logger of this class.
		/// </summary>
		protected static readonly ILogger sLog = Log.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		#endregion

		#region GraphicsResource Overrides

		/// <summary>
		/// Shader program object class.
		/// </summary>
		internal static readonly Guid ShaderProgramObjectClass = new Guid("63E57E43-9DD1-46E3-8EA0-DE87836818D7");

		/// <summary>
		/// Shader program object class.
		/// </summary>
		public override Guid ObjectClass { get { return (ShaderProgramObjectClass); } }

		/// <summary>
		/// Determine whether this ShaderProgram really exists for a specific context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that would have created (or a sharing one) the object. This context shall be current to
		/// the calling thread.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this ShaderProgram exists in the object space of <paramref name="ctx"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The object existence is done by checking a valid object by its name <see cref="IGraphicsResource.ObjectName"/>. This routine will test whether
		/// <paramref name="ctx"/> has created this ShaderProgram (or is sharing with the creator).
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current to the calling thread.
		/// </exception>
		public override bool Exists(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current", "ctx");
		
			// Object name space test (and 'ctx' sanity checks)
			if (base.Exists(ctx) == false)
				return (false);

			return (Gl.IsProgram(ObjectName));
		}

		/// <summary>
		/// Create this ShaderProgram.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object.
		/// </param>
		public override void Create(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			// Create default compilation, but only if necessary
			if (ReferenceEquals(CompilationParams, null))
				_CompilationParams = new ShaderCompilerContext(ctx.ShadingVersion);
			// Base implementation
			base.Create(ctx);
		}

		/// <summary>
		/// Create a ShaderProgram name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// It returns a valid object name for this ShaderProgram.
		/// </returns>
		protected override uint CreateName(GraphicsContext ctx)
		{
			// Create program
			return (Gl.CreateProgram());
		}

		/// <summary>
		/// Actually create this ShaderProgram resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void CreateObject(GraphicsContext ctx)
		{
			// Link this shader program
			Link(ctx, _CompilationParams);

			//// Lazy cache service registration
			//// Give a chance of caching this shader program: if the shader cache service is defined, and it has not cached
			//// this shader program, indeed this instance is a candidate for being cached.
			//ShaderCacheService cacheService = ShaderCacheService.GetService(ctx);

			//if (cacheService != null) {
			//	if (!cacheService.IsCachedShaderProgram(mCompilationParams, Identifier))
			//		cacheService.CacheShaderProgram(this);
			//}
		}

		/// <summary>
		/// Delete a ShaderProgram name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for deleting this object name.
		/// </param>
		/// <param name="name">
		/// A <see cref="System.UInt32"/> that specifies the object name to delete.
		/// </param>
		protected override void DeleteName(GraphicsContext ctx, uint name)
		{
			// Delete program
			Gl.DeleteProgram(name);
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="System.Boolean"/> indicating whether this method is called by <see cref="Dispose"/>. If it is false,
		/// this method is called by the finalizer.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				// Release reference to attached program objects
				foreach (ShaderObject programObject in _ProgramObjects)
					programObject.DecRef();
			}
			// Base implementation
			base.Dispose(disposing);
		}

		#endregion
	}
}
