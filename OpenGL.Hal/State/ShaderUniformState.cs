
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace OpenGL.State
{
	/// <summary>
	/// Class describing a partial uniform state of a <see cref="ShaderProgram"/>
	/// </summary>
	/// <remarks>
	/// This class is able to setup <see cref="ShaderProgram"/> uniform state by detecting fields and properties of derived
	/// classes having the <see cref="ShaderUniformStateAttribute"/> attribute.
	/// </remarks>
	public abstract class ShaderUniformState : GraphicsState
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
		[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
		protected class ShaderUniformStateAttribute : Attribute
		{

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
			/// Construct a UniformStateMember.
			/// </summary>
			/// <param name="memberInfo">
			/// The <see cref="MemberInfo"/> that specify the uniform state variable.
			/// </param>
			/// <param name="getUniformValueDelegate">
			/// The <see cref="GetUniformValueDelegate"/> used for getting the uniform state from <paramref name="memberInfo"/>.
			/// </param>
			public UniformStateMember(MemberInfo memberInfo, GetUniformValueDelegate getUniformValueDelegate)
			{
				if (memberInfo == null)
					throw new ArgumentNullException("memberInfo");
				if (getUniformValueDelegate == null)
					throw new ArgumentNullException("getUniformValueDelegate");

				Member = memberInfo;
				GetValueDelegate = getUniformValueDelegate;
			}

			/// <summary>
			/// The underlying member that specify the uniform state variable.
			/// </summary>
			public readonly MemberInfo Member;

			/// <summary>
			/// The <see cref="GetUniformValueDelegate"/> used for getting the uniform state from <see cref="Member"/>.
			/// </summary>
			public readonly GetUniformValueDelegate GetValueDelegate;

			public Type GetUniformType()
			{
				switch (Member.MemberType) {
					case MemberTypes.Field:
						return (((FieldInfo)Member).FieldType);
					case MemberTypes.Property:
						return (((PropertyInfo)Member).PropertyType);
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
			public object GetUniformValue(object instance) { return (GetValueDelegate(instance, Member)); } }

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

				uniformMembers.Add("hal_" + uniformField.Name, new UniformStateMember(uniformField, GetFieldUniformValue));
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

				uniformMembers.Add("hal_" + uniformProperty.Name, new UniformStateMember(uniformProperty, GetPropertyUniformValue));
			}

			return (uniformMembers);
		}

		/// <summary>
		/// Get the uniform state associated with this instance.
		/// </summary>
		protected abstract Dictionary<string, UniformStateMember> UniformState { get; }

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
			CheckCurrentContext(ctx);

			if (shaderProgram == null)
				throw new ArgumentNullException("shaderProgram");

			Dictionary<string, UniformStateMember> uniformState = UniformState;

			foreach (string activeUniform in shaderProgram.ActiveUniforms) {
				UniformStateMember uniformStateMember;
				string uniformName = activeUniform;

				// Get the underlying member
				if (uniformState.TryGetValue(uniformName, out uniformStateMember) == false)
					continue;

				// Set the program uniform
				shaderProgram.SetUniform(ctx, uniformName, uniformStateMember.GetUniformValue(this));
			}
		}

		#endregion

		#region GraphicsState Overrides

		/// <summary>
		/// Actually create this GraphicsResource resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void CreateObject(GraphicsContext ctx)
		{
			Dictionary<string, UniformStateMember> uniformState = UniformState;

			foreach (KeyValuePair<string, UniformStateMember> pair in uniformState) {
				if (pair.Value.GetUniformType().GetInterface("IGraphicsResource") == null)
					continue;

				IGraphicsResource graphicsResource = pair.Value.GetUniformValue(this) as IGraphicsResource;

				// Create the IGraphicsResource associated with the uniform state variable
				Debug.Assert(graphicsResource != null);
				graphicsResource.Create(ctx);
			}
		}

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

			ShaderUniformState otherState = state as ShaderUniformState;

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
			Debug.Assert(other is ShaderUniformState);

			return (false);
		}

		#endregion
	}
}
