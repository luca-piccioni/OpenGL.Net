
// Copyright (C) 2012-2016 Luca Piccioni
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

#undef ENABLE_REFS_ON_COPY

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace OpenGL.Objects.State
{
	/// <summary>
	/// Class describing a partial uniform state of a <see cref="ShaderProgram"/>
	/// </summary>
	/// <remarks>
	/// This class is able to setup <see cref="ShaderProgram"/> uniform state by detecting fields and properties of derived
	/// classes having the <see cref="ShaderUniformStateAttribute"/> attribute.
	/// </remarks>
	public abstract class ShaderUniformStateBase : GraphicsState
	{
		#region Uniform Block Support

		/// <summary>
		/// Get the shader uniform block semantic (used if the renderer support OpenGL uniform blocks).
		/// </summary>
		public virtual string BlockSemantic { get { return (null); } }

		#endregion

		#region Uniform State

		/// <summary>
		/// Attribute applied to those fields that are bound to a shader program uniform state.
		/// </summary>
		[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
		protected class ShaderUniformStateAttribute : Attribute
		{
			#region Constructors

			/// <summary>
			/// Assumes that the name is prefixes with a prefix framework-reserved ("glo_").
			/// </summary>
			internal ShaderUniformStateAttribute()
			{

			}

			/// <summary>
			/// Assumes that the name is prefixes with a prefix framework-reserved ("glo_").
			/// </summary>
			public ShaderUniformStateAttribute(string uniformName)
			{
				UniformName = uniformName;
			}

			#endregion

			#region Parameters

			/// <summary>
			/// A specific name of the uniform variable. If null, the name is implicit.
			/// </summary>
			public readonly string UniformName;

			#endregion
		}

		/// <summary>
		/// Delegate used for getting the uniform variable value.
		/// </summary>
		/// <param name="instance">
		/// The <see cref="Object"/> that specify the instance defining <paramref name="memberInfo"/>.
		/// </param>
		/// <param name="memberInfo">
		/// The <see cref="MemberInfo"/> that is used to get the uniform value.
		/// </param>
		/// <returns>
		/// It returns an object that specify the value of the underlying uniform variable.
		/// </returns>
		protected delegate object GetUniformValueDelegate(object instance, MemberInfo memberInfo);

		/// <summary>
		/// The <see cref="GetUniformValueDelegate"/> implementation for fields.
		/// </summary>
		/// <param name="instance">
		/// The <see cref="Object"/> that specify the instance defining <paramref name="memberInfo"/>.
		/// </param>
		/// <param name="memberInfo">
		/// The <see cref="MemberInfo"/> that is used to get the uniform value.
		/// </param>
		/// <returns>
		/// It returns an object that specify the value of the underlying uniform variable.
		/// </returns>
		private static object GetFieldUniformValue(object instance, MemberInfo memberInfo)
		{
			if (memberInfo == null)
				throw new ArgumentNullException("memberInfo");
			if (memberInfo.MemberType != MemberTypes.Field)
				throw new ArgumentException("not a field member", "memberInfo");

			FieldInfo fieldInfo = (FieldInfo)memberInfo;

			return (fieldInfo.GetValue(instance));
		}

		/// <summary>
		/// The <see cref="GetUniformValueDelegate"/> implementation for properties.
		/// </summary>
		/// <param name="instance">
		/// The <see cref="Object"/> that specify the instance defining <paramref name="memberInfo"/>.
		/// </param>
		/// <param name="memberInfo">
		/// The <see cref="MemberInfo"/> that is used to get the uniform value.
		/// </param>
		/// <returns>
		/// It returns an object that specify the value of the underlying uniform variable.
		/// </returns>
		private static object GetPropertyUniformValue(object instance, MemberInfo memberInfo)
		{
			if (memberInfo == null)
				throw new ArgumentNullException("memberInfo");
			if (memberInfo.MemberType != MemberTypes.Property)
				throw new ArgumentException("not a property member", "memberInfo");

			PropertyInfo propertyInfo = (PropertyInfo)memberInfo;

			return (propertyInfo.GetValue(instance, null));
		}

		/// <summary>
		/// Context used for compositing all information required for getting the uniform state.
		/// </summary>
		protected class UniformStateMember
		{
			/// <summary>
			/// Basic constructor.
			/// </summary>
			/// <param name="uniformName"></param>
			protected UniformStateMember(string uniformName)
			{
				if (uniformName == null)
					throw new ArgumentNullException("uniformName");
				UniformName = uniformName;
			}

			/// <summary>
			/// Construct a UniformStateMember.
			/// </summary>
			/// <param name="uniformName">
			/// A <see cref="String"/> that specifies the name of the uniform variable.
			/// </param>
			/// <param name="memberInfo">
			/// The <see cref="MemberInfo"/> that specify the uniform state variable.
			/// </param>
			/// <param name="getUniformValueDelegate">
			/// The <see cref="GetUniformValueDelegate"/> used for getting the uniform state from <paramref name="memberInfo"/>.
			/// </param>
			public UniformStateMember(string uniformName, MemberInfo memberInfo, GetUniformValueDelegate getUniformValueDelegate) :
				this(uniformName)
			{
				if (memberInfo == null)
					throw new ArgumentNullException("memberInfo");
				if (getUniformValueDelegate == null)
					throw new ArgumentNullException("getUniformValueDelegate");

				UniformName = uniformName;
				_Member = memberInfo;
				GetValueDelegate = getUniformValueDelegate;
			}

			/// <summary>
			/// The name of the uniform variable.
			/// </summary>
			public readonly string UniformName;

			/// <summary>
			/// The underlying member that specify the uniform state variable.
			/// </summary>
			private readonly MemberInfo _Member;

			/// <summary>
			/// The <see cref="GetUniformValueDelegate"/> used for getting the uniform state from <see cref="_Member"/>.
			/// </summary>
			public readonly GetUniformValueDelegate GetValueDelegate;

			/// <summary>
			/// Get the <see cref="Type"/> of the uniform value.
			/// </summary>
			/// <returns>
			/// It returns the <see cref="Type"/> corresponding to the uniform value.
			/// </returns>
			public virtual Type GetUniformType()
			{
				switch (_Member.MemberType) {
					case MemberTypes.Field:
						return (((FieldInfo)_Member).FieldType);
					case MemberTypes.Property:
						return (((PropertyInfo)_Member).PropertyType);
					default:
						throw new NotImplementedException();
				}
			}

			/// <summary>
			/// Get the uniform variable value.
			/// </summary>
			/// <param name="instance">
			/// The <see cref="Object"/> that specify the instance defining <paramref name="memberInfo"/>.
			/// </param>
			/// <returns></returns>
			public virtual object GetUniformValue(object instance) { return (GetValueDelegate(instance, _Member)); }
		}

		/// <summary>
		/// Utility routine for detecting fields and properties which value is bound to a shader program uniform
		/// state.
		/// </summary>
		/// <param name="shaderUniformStateType">
		/// The <see cref="Type"/> that is defining the fields and properties to be linked with the uniform state.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Dictionary{String, UniformStateMember}"/> that associate uniform variable names with
		/// the relative <see cref="UniformStateMember"/>, which define access to backing properties for getting uniform
		/// variable values.
		/// </returns>
		protected static Dictionary<string, UniformStateMember> DetectUniformProperties(Type shaderUniformStateType)
		{
			if (shaderUniformStateType == null)
				throw new ArgumentNullException("shaderUniformStateType");

			Dictionary<string, UniformStateMember> uniformMembers = new Dictionary<string, UniformStateMember>();

			// Fields
			FieldInfo[] uniformFields = shaderUniformStateType.GetFields(BindingFlags.Public | BindingFlags.Instance);

			foreach (FieldInfo uniformField in uniformFields) {
				ShaderUniformStateAttribute attribute = (ShaderUniformStateAttribute)Attribute.GetCustomAttribute(uniformField, typeof(ShaderUniformStateAttribute));
				if (attribute == null)
					continue;

				string uniformName = attribute.UniformName != null ? attribute.UniformName : "glo_" + uniformField.Name;

				uniformMembers.Add(uniformName, new UniformStateMember(uniformName, uniformField, GetFieldUniformValue));
			}

			// Properties
			PropertyInfo[] uniformProperties = shaderUniformStateType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

			foreach (PropertyInfo uniformProperty in uniformProperties) {
				if (uniformProperty.CanRead == false)
					continue;
				if (uniformProperty.GetIndexParameters().Length > 0)
					continue;

				ShaderUniformStateAttribute attribute = (ShaderUniformStateAttribute)Attribute.GetCustomAttribute(uniformProperty, typeof(ShaderUniformStateAttribute));
				if (attribute == null)
					continue;

				string uniformName = attribute.UniformName != null ? attribute.UniformName : "glo_" + uniformProperty.Name;

				uniformMembers.Add(uniformName, new UniformStateMember(uniformName, uniformProperty, GetPropertyUniformValue));
			}

			return (uniformMembers);
		}

		/// <summary>
		/// Get the uniform state associated with this instance.
		/// </summary>
		protected abstract Dictionary<string, UniformStateMember> UniformState { get; }

		protected static void DetectTypeProperties(Type shaderUniformStateType)
		{
			foreach (Type nestedType in shaderUniformStateType.GetNestedTypes(BindingFlags.Public)) {
				ShaderUniformStateAttribute attribute = (ShaderUniformStateAttribute)Attribute.GetCustomAttribute(nestedType, typeof(ShaderUniformStateAttribute));
				if (attribute == null)
					continue;

				DetetectNestedTypeProperties(nestedType);
			}
		}

		private static void DetetectNestedTypeProperties(Type shaderUniformStateType)
		{
			if (shaderUniformStateType == null)
				throw new ArgumentNullException("shaderUniformStateType");
			if (_TypeUniformState.ContainsKey(shaderUniformStateType))
				throw new ArgumentException("type known already");

			List<UniformStateMember> typeMembers = new List<UniformStateMember>();

			// Fields
			FieldInfo[] uniformFields = shaderUniformStateType.GetFields(BindingFlags.Public | BindingFlags.Instance);

			foreach (FieldInfo uniformField in uniformFields) {
				ShaderUniformStateAttribute attribute = (ShaderUniformStateAttribute)Attribute.GetCustomAttribute(uniformField, typeof(ShaderUniformStateAttribute));
				if (attribute == null)
					continue;

				string uniformName = attribute.UniformName != null ? attribute.UniformName : "glo_" + uniformField.Name;

				typeMembers.Add(new UniformStateMember(uniformName, uniformField, GetFieldUniformValue));
			}

			// Properties
			PropertyInfo[] uniformProperties = shaderUniformStateType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

			foreach (PropertyInfo uniformProperty in uniformProperties) {
				if (uniformProperty.CanRead == false)
					continue;
				if (uniformProperty.GetIndexParameters().Length > 0)
					continue;

				ShaderUniformStateAttribute attribute = (ShaderUniformStateAttribute)Attribute.GetCustomAttribute(uniformProperty, typeof(ShaderUniformStateAttribute));
				if (attribute == null)
					continue;

				string uniformName = attribute.UniformName != null ? attribute.UniformName : "glo_" + uniformProperty.Name;

				typeMembers.Add(new UniformStateMember(uniformName, uniformProperty, GetPropertyUniformValue));
			}

			_TypeUniformState.Add(shaderUniformStateType, typeMembers);
		}

		/// <summary>
		/// 
		/// </summary>
		private static readonly Dictionary<Type, List<UniformStateMember>> _TypeUniformState = new Dictionary<Type, List<UniformStateMember>>();

		/// <summary>
		/// Apply this state to a shader program.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used to share common state between shaders.
		/// </param>
		/// <param name="shaderProgram">
		/// A <see cref="ShaderProgram"/> that specify this uniform state.
		/// </param>
		/// <param name="uniformScope">
		/// A <see cref="String"/> that specify the scope the uniform variable.
		/// </param>
		private void ApplyState(GraphicsContext ctx, ShaderProgram shaderProgram, string uniformScope)
		{
			GraphicsResource.CheckCurrentContext(ctx);

			if (shaderProgram == null)
				throw new ArgumentNullException("shaderProgram");

			ApplyState(ctx, shaderProgram, null, UniformState.Values, this);
		}

		/// <summary>
		/// Apply this state to a shader program.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used to share common state between shaders.
		/// </param>
		/// <param name="shaderProgram">
		/// A <see cref="ShaderProgram"/> that specify this uniform state.
		/// </param>
		/// <param name="uniformScope">
		/// A <see cref="String"/> that specify the scope the uniform variable.
		/// </param>
		private void ApplyState(GraphicsContext ctx, ShaderProgram shaderProgram, string uniformScope, IEnumerable<UniformStateMember> uniforms, object uniformContainer)
		{
			foreach (UniformStateMember uniform in uniforms) {
				// Set the program uniform
				string uniformPattern = uniformScope != null ? String.Format("{0}.{1}", uniformScope, uniform.UniformName) : uniform.UniformName;

				// Matches also partial uniform variables (i.e. glo_Struct[0] or glo_Struct while glo_Struct[0].Member is active)
				// Indeed quite efficient when structures are not active (skip all members)
				if (shaderProgram.IsActiveUniform(uniformPattern) == false)
					continue;

				object uniformValue = uniform.GetUniformValue(uniformContainer);

				// Silently skip null references
				if (uniformValue == null)
					continue;

				Type uniformValueType = uniformValue.GetType();

				if (uniformValueType.IsArray) {
					Array uniformArray = (Array)uniformValue;

					for (int i = 0; i < uniformArray.Length; i++) {
						string uniformArrayPattern = String.Format("{0}[{1}]", uniformPattern, i);

						if (shaderProgram.IsActiveUniform(uniformArrayPattern) == false)
							continue;

						object uniformArrayValue = uniformArray.GetValue(i);

						// Silently skip null references
						if (uniformArrayValue == null)
							continue;

						ApplyUniform(ctx, shaderProgram, uniformArrayPattern, uniformArrayValue);
					}
				} else
					ApplyUniform(ctx, shaderProgram, uniformPattern, uniformValue);
			}
		}

		private void ApplyUniform(GraphicsContext ctx, ShaderProgram shaderProgram, string uniformPattern, object uniformValue)
		{
			List<UniformStateMember> structuredTypeMembers;

			if (_TypeUniformState.TryGetValue(uniformValue.GetType(), out structuredTypeMembers)) {
				// Recurse over structure fields
				ApplyState(ctx, shaderProgram, uniformPattern, structuredTypeMembers, uniformValue);
			} else
				shaderProgram.SetUniform(ctx, uniformPattern, uniformValue);
		}

		#endregion

		#region GraphicsState Overrides

		/// <summary>
		/// Flag indicating whether the state is context-bound.
		/// </summary>
		/// <remarks>
		/// It returns always false.
		/// </remarks>
		public override bool IsContextBound { get { return (false); } }

		/// <summary>
		/// Flag indicating whether the state can be applied on a <see cref="ShaderProgram"/>.
		/// </summary>
		public override bool IsShaderProgramBound { get { return (true); } }

		/// <summary>
		/// Create or update resources defined by this IGraphicsState.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		public override void CreateState(GraphicsContext ctx)
		{
			Dictionary<string, UniformStateMember> uniformState = UniformState;

			foreach (KeyValuePair<string, UniformStateMember> pair in uniformState) {
				if (pair.Value.GetUniformType().GetInterface("IGraphicsResource") == null)
					continue;

				IGraphicsResource graphicsResource = pair.Value.GetUniformValue(this) as IGraphicsResource;
				if (graphicsResource == null)
					continue;

				// Create the IGraphicsResource associated with the uniform state variable
				graphicsResource.Create(ctx);
			}
		}

		/// <summary>
		/// Apply this depth test render state.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> which has defined the shader program <paramref name="shaderProgram"/>.
		/// </param>
		/// <param name="shaderProgram">
		/// The <see cref="ShaderProgram"/> which has the state set.
		/// </param>
		public override void ApplyState(GraphicsContext ctx, ShaderProgram shaderProgram)
		{
			// Program must be bound
			ctx.Bind(shaderProgram);
			// Apply uniforms found using reflection
			ApplyState(ctx, shaderProgram, String.Empty);
		}

		/// <summary>
		/// Merge this state with another one.
		/// </summary>
		/// <param name="state">
		/// A <see cref="IGraphicsState"/> having the same <see cref="StateIdentifier"/> of this state.
		/// </param>
		public override void Merge(IGraphicsState state)
		{
			if (state == null)
				throw new ArgumentNullException("state");

			ShaderUniformStateBase otherState = state as ShaderUniformStateBase;

			if (otherState == null)
				throw new ArgumentException("not a ShaderUniformState", "state");
		}

		/// <summary>
		/// Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		/// <param name="other">
		/// A <see cref="GraphicsState"/> to compare to this GraphicsState.
		/// </param>
		/// <returns>
		/// It returns true if the current object is equal to <paramref name="other"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// This method test only whether <paramref name="other"/> type equals to this type.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="other"/> is null.
		/// </exception>
		public override bool Equals(IGraphicsState other)
		{
			if (base.Equals(other) == false)
				return (false);
			Debug.Assert(other is ShaderUniformStateBase);

			ShaderUniformStateBase otherState = (ShaderUniformStateBase) other;
			GraphicsContext ctx = GraphicsContext.GetCurrentContext();

			if (ctx == null)
				throw new InvalidOperationException("no current context");

			return (false);
		}

		/// <summary>
		/// Performs a deep copy of this <see cref="IGraphicsState"/>.
		/// </summary>
		/// <returns>
		/// It returns the equivalent of this <see cref="IGraphicsState"/>, but all objects referenced
		/// are not referred by both instances.
		/// </returns>
		public override IGraphicsState Copy()
		{
			ShaderUniformStateBase copiedState = (ShaderUniformStateBase)base.Copy();

#if ENABLE_REFS_ON_COPY
			foreach (KeyValuePair<string, UniformStateMember> pair in copiedState.UniformState) {
				//if (pair.Value.GetUniformType().GetInterface("IGraphicsResource") == null)
				//	continue;

				IGraphicsResource graphicsResource = pair.Value.GetUniformValue(this) as IGraphicsResource;
				if (graphicsResource == null)
					continue;

				// Copied share references
				graphicsResource.IncRef();
			}
#endif

			return (copiedState);
		}

		/// <summary>
		/// Dispose resources hold by this GraphicsState.
		/// </summary>
		public override void Dispose()
		{
#if ENABLE_REFS_ON_COPY

			foreach (KeyValuePair<string, UniformStateMember> pair in UniformState) {
				if (pair.Value.GetUniformType().GetInterface("IGraphicsResource") == null)
					continue;

				IGraphicsResource graphicsResource = pair.Value.GetUniformValue(this) as IGraphicsResource;
				if (graphicsResource == null)
					continue;
				graphicsResource.DecRef();
			}
#endif
		}

		#endregion
	}

	/// <summary>
	/// Class describing a partial uniform state of a <see cref="ShaderProgram"/>
	/// </summary>
	/// <remarks>
	/// This class is able to setup <see cref="ShaderProgram"/> uniform state by detecting fields and properties of derived
	/// classes having the <see cref="ShaderUniformStateAttribute"/> attribute.
	/// </remarks>
	public class ShaderUniformState : ShaderUniformStateBase
	{
		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		/// <param name="stateId">
		/// A <see cref="String"/> that specifies the state identifier.
		/// </param>
		public ShaderUniformState(string stateId)
		{
			if (stateId == null)
				throw new ArgumentNullException("stateId");

			_StateId = stateId;
		}

		#endregion

		#region Ad-Hoc Uniform State

		/// <summary>
		/// Context used for compositing all information required for getting the uniform state.
		/// </summary>
		protected class UniformStateVariable : UniformStateMember
		{
			/// <summary>
			/// Default constructor.
			/// </summary>
			/// <param name="uniformName">
			/// A <see cref="String"/> that specifies the name of the uniform variable.
			/// </param>
			public UniformStateVariable(string uniformName, object value) : base(uniformName)
			{
				if (value == null)
					throw new ArgumentNullException("value");
				UniformValue = value;
			}

			/// <summary>
			/// Get the <see cref="Type"/> of the uniform value.
			/// </summary>
			/// <returns>
			/// It returns the <see cref="Type"/> corresponding to the uniform value.
			/// </returns>
			public override Type GetUniformType()
			{
				return (UniformValue.GetType());
			}

			/// <summary>
			/// Get the uniform variable value.
			/// </summary>
			/// <param name="instance">
			/// The <see cref="Object"/> that specify the instance defining <paramref name="memberInfo"/>.
			/// </param>
			/// <returns></returns>
			public override object GetUniformValue(object instance) { return (UniformValue); }

			/// <summary>
			/// Get or set the uniform value.
			/// </summary>
			public object UniformValue;
		}

		/// <summary>
		/// Set uniform variable state.
		/// </summary>
		/// <param name="uniformName">
		/// 
		/// </param>
		/// <param name="value">
		/// 
		/// </param>
		public void SetUniformState(string uniformName, object value)
		{
			if (uniformName == null)
				throw new ArgumentNullException("uniformName");

			UniformStateMember uniformStateMember;

			if (_UniformProperties.TryGetValue(uniformName, out uniformStateMember)) {
				UniformStateVariable uniformStateVariable = (UniformStateVariable)uniformStateMember;

				IGraphicsResource prevResource = uniformStateVariable.UniformValue as IGraphicsResource;
				if (prevResource != null)
					prevResource.DecRef();

				IGraphicsResource currResource = value as IGraphicsResource;
				if (currResource != null)
					currResource.IncRef();

				uniformStateVariable.UniformValue = value;
			} else {
				IGraphicsResource currResource = value as IGraphicsResource;
				if (currResource != null)
					currResource.IncRef();

				_UniformProperties.Add(uniformName, new UniformStateVariable(uniformName, value));
			}
		}

		#endregion

		#region ShaderUniformStateBase Overrides

		/// <summary>
		/// Get the identifier of this ShaderUniformState.
		/// </summary>
		public override string StateIdentifier { get { return (_StateId); } }

		/// <summary>
		/// The identifier of this ShaderUniformState.
		/// </summary>
		private readonly string _StateId;

		/// <summary>
		/// Unique index assigned to this GraphicsState.
		/// </summary>
		public static int StateSetIndex { get { return (_StateIndex); } }

		/// <summary>
		/// Unique index assigned to this GraphicsState.
		/// </summary>
		public override int StateIndex { get { return (_StateIndex); } }

		/// <summary>
		/// The index for this GraphicsState.
		/// </summary>
		private static int _StateIndex = NextStateIndex();

		/// <summary>
		/// Get the uniform state associated with this instance.
		/// </summary>
		protected override Dictionary<string, UniformStateMember> UniformState { get { return (_UniformProperties); } }

		/// <summary>
		/// The uniform state of this TransformStateBase.
		/// </summary>
		private readonly Dictionary<string, UniformStateMember> _UniformProperties = new Dictionary<string, UniformStateMember>();

		#endregion
	}
}
