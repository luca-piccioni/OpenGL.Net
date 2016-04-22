
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

// Macro utility for enabling OpenGL function calls logging
#undef GL_LOG_ENABLED

using System;
using System.Reflection;

using NSubstitute;
using NUnit.Framework;

namespace OpenGL.Hal.Test
{
	[TestFixture, RequiresSTA]
	public class TestBase
	{
		#region Setup & Tear Down

		/// <summary>
		/// Create a window, create the device context and set a basic pixel format.
		/// </summary>
		[TestFixtureSetUp]
		public void FixtureSetUp()
		{
			try {
				// Support ES tests
				Egl.IsRequired = IsEsTest;

#if GL_LOG_ENABLED
				// Set logging
				Gl.QueryLogContext();
				Wgl.QueryLogContext();
				KhronosApi.RegisterApplicationLogDelegate(delegate(string format, object[] args) {
					Console.WriteLine(format, args);
				});
#endif

				// Create window on which tests are run
				_Window = new GraphicsWindow(800, 600);

				// Define window buffers
				GraphicsBuffersFormat graphicsBuffersFormat = new GraphicsBuffersFormat(PixelLayout.RGB24);

				//graphicsBuffersFormat.DefineDepthBuffer(24, GraphicsBuffersFormat.BufferPolicy.RequiredAndDegradable);
				//graphicsBuffersFormat.DefineDoubleBuffers(GraphicsBuffersFormat.BufferPolicy.RequiredAndDegradable);

				_Window.Create(graphicsBuffersFormat);
				// Create graphics context
				_Context = new GraphicsContext(_Window.GetDeviceContext(), null, null, GraphicsContextFlags.CompatibilityProfile);
			} catch {
				// Release resources manually
				FixtureTearDown();
				throw;
			}
		}

		[SetUp()]
		public void SetUp()
		{
			if (_Context.IsCurrent == false)
				_Context.MakeCurrent(true);
		}

		/// <summary>
		/// Release resources allocated by <see cref="FixtureSetUp"/>.
		/// </summary>
		[TestFixtureTearDown]
		public void FixtureTearDown()
		{
			// Dispose graphics context
			if (_Context != null) {
				_Context.Dispose();
				_Context = null;
			}
			// Dispose graphics window
			if (_Window != null) {
				_Window.Dispose();
				_Window = null;
			}
		}

		/// <summary>
		/// Determine whether this test is testing OpenGL ES API.
		/// </summary>
		protected virtual bool IsEsTest
		{
			get { return (false); }
		}

		/// <summary>
		/// The device context.
		/// </summary>
		protected IGraphicsSurface _Window;

		/// <summary>
		/// The graphics context.
		/// </summary>
		protected GraphicsContext _Context;

		#endregion

		#region OpenGL.Hal Types Support

		/// <summary>
		/// Interface implemented to support testing on a specific complex type defined in OpenGL.Hal.
		/// </summary>
		protected interface IGraphicsTypeSupport
		{
			/// <summary>
			/// Allocate an instance of the type.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			object Allocate(GraphicsContext ctx);

			/// <summary>
			/// Allocate an instance of the type mocked for spying.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			T AllocateSpy<T>(GraphicsContext ctx);

			/// <summary>
			/// Actually create resources associated to the type.
			/// </summary>
			/// <param name="instance">
			/// A <see cref="Object"/> that specifies the underlying instance.
			/// </param>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for creating the resources.
			/// </param>
			void Create(object instance, GraphicsContext ctx);

			/// <summary>
			/// Dispose resources associated to the type.
			/// </summary>
			/// <param name="instance">
			/// A <see cref="Object"/> that specifies the underlying instance.
			/// </param>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for disposing the resources.
			/// </param>
			void Dispose(object instance, GraphicsContext ctx);
		}

		protected IGraphicsTypeSupport GetGraphicsTypeSupport(Type type)
		{
			Type graphicsTypeSupport = typeof(TestBase).GetNestedType(String.Format("{0}TypeSupport", type.Name), BindingFlags.NonPublic);

			if (graphicsTypeSupport != null)
				return (Activator.CreateInstance(graphicsTypeSupport) as IGraphicsTypeSupport);

			return (new DefaultGraphicsTypeSupport(type));
		}

		/// <summary>
		/// Base class implementing <see cref="IGraphicsTypeSupport"/>.
		/// </summary>
		protected class DefaultGraphicsTypeSupport : IGraphicsTypeSupport
		{
			#region Constructors

			/// <summary>
			/// Construct a DefaultGraphicsTypeSupport specifying the underlying type.
			/// </summary>
			/// <param name="type">
			/// The <see cref="Type"/> that determine the type of the instance.
			/// </param>
			public DefaultGraphicsTypeSupport(Type type)
			{
				if (type == null)
					throw new ArgumentNullException("type");

				_InstanceType = type;
            }

			/// <summary>
			/// The underlying type.
			/// </summary>
			protected readonly Type _InstanceType;

			#endregion

			#region Mocking Support

			/// <summary>
			/// Create a NSubstitute partial of the specified type.
			/// </summary>
			/// <param name="type"></param>
			/// <param name="parameters"></param>
			/// <returns></returns>
			internal static object CreateTypeSpy(Type type, params object[] parameters)
			{
				var example = Substitute.For<IResource>();

				Type substituteType = typeof(Substitute);
				MethodInfo method = substituteType.GetMethod("ForPartsOf", BindingFlags.Public | BindingFlags.Static);
				MethodInfo methodGeneric = method.MakeGenericMethod(type);

				return (methodGeneric.Invoke(null, new object[1] { parameters }));
			}

			#endregion

			#region IGraphicsTypeSupport Implementation

			/// <summary>
			/// Allocate an instance of the type.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public virtual object Allocate(GraphicsContext ctx)
			{
				return (Activator.CreateInstance(_InstanceType));
			}

			/// <summary>
			/// Allocate an instance of the type mocked for spying.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public virtual T AllocateSpy<T>(GraphicsContext ctx)
			{
				return ((T)CreateTypeSpy(_InstanceType));
			}

			/// <summary>
			/// Actually create resources associated to the type.
			/// </summary>
			/// <param name="instance">
			/// A <see cref="Object"/> that specifies the underlying instance.
			/// </param>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for creating the resources.
			/// </param>
			public virtual void Create(object instance, GraphicsContext ctx)
			{
				IGraphicsResource graphicsResource = instance as IGraphicsResource;

				if (graphicsResource == null)
					throw new InvalidOperationException("not implementing IGraphicsResource");

				graphicsResource.Create(ctx);
			}

			/// <summary>
			/// Dispose resources associated to the type.
			/// </summary>
			/// <param name="instance">
			/// A <see cref="Object"/> that specifies the underlying instance.
			/// </param>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for disposing the resources.
			/// </param>
			public virtual void Dispose(object instance, GraphicsContext ctx)
			{
				IDisposable disposable = instance as IDisposable;

				if (disposable == null)
					throw new InvalidOperationException("not implementing IDisposable");

				disposable.Dispose();
			}

			#endregion
		}

		protected class GraphicsWindowTypeSupport : DefaultGraphicsTypeSupport
		{
			#region Constructors

			/// <summary>
			/// Construct a GraphicsWindowTypeSupport.
			/// </summary>
			public GraphicsWindowTypeSupport() :
				base(typeof(GraphicsWindow))
			{

			}

			#endregion

			#region DefaultGraphicsTypeSupport Overrides

			/// <summary>
			/// Allocate an instance of the type.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override object Allocate(GraphicsContext ctx)
			{
				GraphicsWindow graphicsWindow = new GraphicsWindow(16, 16);

				return (graphicsWindow);
			}

			/// <summary>
			/// Allocate an instance of the type mocked for spying.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override T AllocateSpy<T>(GraphicsContext ctx)
			{
				T shaderObjectSpy = (T)CreateTypeSpy(typeof(GraphicsWindow), 16U, 16U);

				return (shaderObjectSpy);
			}

			/// <summary>
			/// Actually create resources associated to the type.
			/// </summary>
			/// <param name="instance">
			/// A <see cref="Object"/> that specifies the underlying instance.
			/// </param>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for creating the resources.
			/// </param>
			public override void Create(object instance, GraphicsContext ctx)
			{
				GraphicsWindow graphicsWindow = (GraphicsWindow)instance;

				graphicsWindow.Create(new GraphicsBuffersFormat(PixelLayout.RGB24, 24));
			}

			#endregion
		}

		protected class ShaderObjectTypeSupport : DefaultGraphicsTypeSupport
		{
			#region Constructors

			/// <summary>
			/// Construct a ShaderObjectTypeSupport.
			/// </summary>
			public ShaderObjectTypeSupport() :
				base(typeof(ShaderObject))
			{
				
			}

			#endregion

			#region DefaultGraphicsTypeSupport Overrides

			/// <summary>
			/// Allocate an instance of the type.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override object Allocate(GraphicsContext ctx)
			{
				ShaderObject shaderObject = new ShaderObject(ShaderStage.Vertex);

				shaderObject.LoadSource(ShaderSource);

				return (shaderObject);
			}

			/// <summary>
			/// Allocate an instance of the type mocked for spying.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override T AllocateSpy<T>(GraphicsContext ctx)
			{
				T shaderObjectSpy = (T)CreateTypeSpy(typeof(ShaderObject), ShaderStage.Vertex);
				ShaderObject shaderObject = shaderObjectSpy as ShaderObject;

				if (shaderObject != null)
					shaderObject.LoadSource(ShaderSource);

				return (shaderObjectSpy);
			}

			private static readonly string[] ShaderSource = new string[] {
				"void main() {\n",
				"	gl_Position = vec4(0, 0, 0, 1);\n",
				"}\n"
			};

			#endregion
		}

		protected class ShaderIncludeTypeSupport : DefaultGraphicsTypeSupport
		{
			#region Constructors

			/// <summary>
			/// Construct a ShaderIncludeTypeSupport.
			/// </summary>
			public ShaderIncludeTypeSupport() :
				base(typeof(ShaderInclude))
			{

			}

			#endregion

			#region DefaultGraphicsTypeSupport Overrides

			/// <summary>
			/// Allocate an instance of the type.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override object Allocate(GraphicsContext ctx)
			{
				ShaderInclude shaderInclude = new ShaderInclude("/Test.glsl");

				shaderInclude.LoadSource(ShaderIncludeSource);

				return (shaderInclude);
			}

			/// <summary>
			/// Allocate an instance of the type mocked for spying.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override T AllocateSpy<T>(GraphicsContext ctx)
			{
				T shaderIncludeSpy = (T)CreateTypeSpy(_InstanceType, "/Test.glsl");
				ShaderInclude shaderInclude = shaderIncludeSpy as ShaderInclude;

				if (shaderInclude != null)
					shaderInclude.LoadSource(ShaderIncludeSource);

				return (shaderIncludeSpy);
			}

			private static readonly string[] ShaderIncludeSource = new string[] {
				"uniform mat4 modelViewProjection;\n"
			};

			#endregion
		}

		protected class ShaderProgramTypeSupport : DefaultGraphicsTypeSupport
		{
			#region Constructors

			/// <summary>
			/// Construct a ShaderProgramTypeSupport.
			/// </summary>
			public ShaderProgramTypeSupport() :
				base(typeof(ShaderProgram))
			{

			}

#endregion

			#region DefaultGraphicsTypeSupport Overrides

			/// <summary>
			/// Allocate an instance of the type.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override object Allocate(GraphicsContext ctx)
			{
				ShaderProgram shaderProgram = new ShaderProgram("TestProgram");

				ShaderObject vertexShaderObject = new ShaderObject(ShaderStage.Vertex);
				vertexShaderObject.LoadSource(VertexShaderSource);

				ShaderObject fragmentShaderObject = new ShaderObject(ShaderStage.Fragment);
				fragmentShaderObject.LoadSource(FragmentShaderSource);

				shaderProgram.AttachShader(vertexShaderObject);
				shaderProgram.AttachShader(fragmentShaderObject);

				return (shaderProgram);
			}

			/// <summary>
			/// Allocate an instance of the type mocked for spying.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override T AllocateSpy<T>(GraphicsContext ctx)
			{
				T shaderProgramSpy = (T)CreateTypeSpy(_InstanceType, "Test");
				ShaderProgram shaderProgram = shaderProgramSpy as ShaderProgram;

				if (shaderProgram != null) {
					ShaderObject vertexShaderObject = new ShaderObject(ShaderStage.Vertex);
					vertexShaderObject.LoadSource(VertexShaderSource);

					ShaderObject fragmentShaderObject = new ShaderObject(ShaderStage.Fragment);
					fragmentShaderObject.LoadSource(FragmentShaderSource);

					shaderProgram.AttachShader(vertexShaderObject);
					shaderProgram.AttachShader(fragmentShaderObject);
				}

				return (shaderProgramSpy);
			}

			private static readonly string[] VertexShaderSource = new string[] {
				"void main() {\n",
				"	gl_Position = vec4(0, 0, 0, 1);\n",
				"}\n"
			};

			private static readonly string[] FragmentShaderSource = new string[] {
				"#include </OpenGL/Compatibility.glsl>\n",
				"OUT vec4 test_Color;\n",
				"void main() {\n",
				"	test_Color = vec4(0, 0, 0, 1);\n",
				"}\n"
			};

			#endregion
		}

		protected class ArrayBufferObjectTypeSupport : DefaultGraphicsTypeSupport
		{
			#region Constructors

			/// <summary>
			/// Construct a ShaderProgramTypeSupport.
			/// </summary>
			public ArrayBufferObjectTypeSupport() :
				base(typeof(ArrayBufferObject))
			{

			}

			#endregion

			#region DefaultGraphicsTypeSupport Overrides

			/// <summary>
			/// Allocate an instance of the type.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override object Allocate(GraphicsContext ctx)
			{
				ArrayBufferObject arrayBufferObject = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw);

				arrayBufferObject.Create(16);

				return (arrayBufferObject);
			}

			/// <summary>
			/// Allocate an instance of the type mocked for spying.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override T AllocateSpy<T>(GraphicsContext ctx)
			{
				T arrayBufferObjectSpy = (T)CreateTypeSpy(_InstanceType, VertexBaseType.Float, 3U, BufferObjectHint.StaticCpuDraw);
				ArrayBufferObject arrayBufferObject = arrayBufferObjectSpy as ArrayBufferObject;

				if (arrayBufferObject != null)
					arrayBufferObject.Create(16);

				return (arrayBufferObjectSpy);
			}

			#endregion
		}

		protected class ArrayBufferObjectInterleavedTypeSupport : DefaultGraphicsTypeSupport
		{
			#region Constructors

			/// <summary>
			/// Construct a ArrayBufferObjectInterleavedTypeSupport.
			/// </summary>
			public ArrayBufferObjectInterleavedTypeSupport() :
				base(typeof(ArrayBufferObjectInterleaved))
			{

			}

			#endregion

			#region DefaultGraphicsTypeSupport Overrides

			/// <summary>
			/// Allocate an instance of the type.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override object Allocate(GraphicsContext ctx)
			{
				ArrayBufferObjectInterleaved arrayBufferObject = new ArrayBufferObjectInterleaved(typeof(ComplexVertexElement), BufferObjectHint.StaticCpuDraw);

				arrayBufferObject.Create(16);

				return (arrayBufferObject);
			}

			/// <summary>
			/// Allocate an instance of the type mocked for spying.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override T AllocateSpy<T>(GraphicsContext ctx)
			{
				T arrayBufferObjectSpy = (T)CreateTypeSpy(_InstanceType, typeof(ComplexVertexElement), BufferObjectHint.StaticCpuDraw);
				ArrayBufferObjectInterleaved arrayBufferObject = arrayBufferObjectSpy as ArrayBufferObjectInterleaved;

				if (arrayBufferObject != null)
					arrayBufferObject.Create(16);

				return (arrayBufferObjectSpy);
			}

			#endregion
		}

		protected class ArrayBufferObjectPackedTypeSupport : DefaultGraphicsTypeSupport
		{
			#region Constructors

			/// <summary>
			/// Construct a ArrayBufferObjectPackedTypeSupport.
			/// </summary>
			public ArrayBufferObjectPackedTypeSupport() :
				base(typeof(ArrayBufferObjectPacked))
			{

			}

			#endregion

			#region DefaultGraphicsTypeSupport Overrides

			/// <summary>
			/// Allocate an instance of the type.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override object Allocate(GraphicsContext ctx)
			{
				ArrayBufferObjectPacked arrayBufferObject = new ArrayBufferObjectPacked(typeof(ComplexVertexElement), BufferObjectHint.StaticCpuDraw);

				arrayBufferObject.Create(16);

				return (arrayBufferObject);
			}

			/// <summary>
			/// Allocate an instance of the type mocked for spying.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override T AllocateSpy<T>(GraphicsContext ctx)
			{
				T arrayBufferObjectSpy = (T)CreateTypeSpy(_InstanceType, typeof(ComplexVertexElement), BufferObjectHint.StaticCpuDraw);
				ArrayBufferObjectPacked arrayBufferObject = arrayBufferObjectSpy as ArrayBufferObjectPacked;

				if (arrayBufferObject != null)
					arrayBufferObject.Create(16);

				return (arrayBufferObjectSpy);
			}

			#endregion
		}

		protected class ElementBufferObjectTypeSupport : DefaultGraphicsTypeSupport
		{
			#region Constructors

			/// <summary>
			/// Construct a ElementBufferObjectTypeSupport.
			/// </summary>
			public ElementBufferObjectTypeSupport() :
				base(typeof(ElementBufferObject))
			{

			}

			#endregion

			#region DefaultGraphicsTypeSupport Overrides

			/// <summary>
			/// Allocate an instance of the type.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override object Allocate(GraphicsContext ctx)
			{
				ElementBufferObject arrayBufferObject = new ElementBufferObject(DrawElementsType.UnsignedInt);

				arrayBufferObject.Create(16);

				return (arrayBufferObject);
			}

			/// <summary>
			/// Allocate an instance of the type mocked for spying.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override T AllocateSpy<T>(GraphicsContext ctx)
			{
				T elementBufferObjectSpy = (T)CreateTypeSpy(_InstanceType, DrawElementsType.UnsignedInt);
				ElementBufferObject elementBufferObject = elementBufferObjectSpy as ElementBufferObject;

				if (elementBufferObject != null)
					elementBufferObject.Create(16);

				return (elementBufferObjectSpy);
			}

			#endregion
		}

		protected class VertexArrayObjectTypeSupport : DefaultGraphicsTypeSupport
		{
			#region Constructors

			/// <summary>
			/// Construct a VertexArrayObjectTypeSupport.
			/// </summary>
			public VertexArrayObjectTypeSupport() :
				base(typeof(VertexArrayObject))
			{

			}

			#endregion

			#region DefaultGraphicsTypeSupport Overrides

			/// <summary>
			/// Allocate an instance of the type.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override object Allocate(GraphicsContext ctx)
			{
				VertexArrayObject vertexArrayObject = new VertexArrayObject();
				ArrayBufferObject arrayBufferObject;

				arrayBufferObject = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw);
				arrayBufferObject.Create(16);
				vertexArrayObject.SetArray(arrayBufferObject, VertexArraySemantic.Position);

				arrayBufferObject = new ArrayBufferObject(VertexBaseType.Float, 2, BufferObjectHint.StaticCpuDraw);
				arrayBufferObject.Create(16);
				vertexArrayObject.SetArray(arrayBufferObject, VertexArraySemantic.TexCoord);

				vertexArrayObject.SetElementArray(PrimitiveType.Lines);

				return (vertexArrayObject);
			}

			/// <summary>
			/// Allocate an instance of the type mocked for spying.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override T AllocateSpy<T>(GraphicsContext ctx)
			{
				T arrayBufferObjectSpy = (T)CreateTypeSpy(_InstanceType);
				VertexArrayObject vertexArrayObject = arrayBufferObjectSpy as VertexArrayObject;

				if (vertexArrayObject != null) {
					ArrayBufferObject arrayBufferObject;

					arrayBufferObject = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw);
					arrayBufferObject.Create(16);
					vertexArrayObject.SetArray(arrayBufferObject, VertexArraySemantic.Position);

					arrayBufferObject = new ArrayBufferObject(VertexBaseType.Float, 2, BufferObjectHint.StaticCpuDraw);
					arrayBufferObject.Create(16);
					vertexArrayObject.SetArray(arrayBufferObject, VertexArraySemantic.TexCoord);

					vertexArrayObject.SetElementArray(PrimitiveType.Lines);
				}

				return (arrayBufferObjectSpy);
			}

			#endregion
		}

		protected class VertexArrayBatchObjectTypeSupport : DefaultGraphicsTypeSupport
		{
			#region Constructors

			/// <summary>
			/// Construct a VertexArrayObjectTypeSupport.
			/// </summary>
			public VertexArrayBatchObjectTypeSupport() :
				base(typeof(VertexArrayBatchObject))
			{

			}

			#endregion

			#region DefaultGraphicsTypeSupport Overrides

			/// <summary>
			/// Allocate an instance of the type.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override object Allocate(GraphicsContext ctx)
			{
				VertexArrayBatchObject vertexArrayObject = new VertexArrayBatchObject();
				ArrayBufferObject arrayBufferObject;

				arrayBufferObject = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw);
				arrayBufferObject.Create(16);
				vertexArrayObject.SetArray(arrayBufferObject, VertexArraySemantic.Position);

				arrayBufferObject = new ArrayBufferObject(VertexBaseType.Float, 2, BufferObjectHint.StaticCpuDraw);
				arrayBufferObject.Create(16);
				vertexArrayObject.SetArray(arrayBufferObject, VertexArraySemantic.TexCoord);

				vertexArrayObject.SetElementArray(PrimitiveType.Lines);

				return (vertexArrayObject);
			}

			/// <summary>
			/// Allocate an instance of the type mocked for spying.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override T AllocateSpy<T>(GraphicsContext ctx)
			{
				T arrayBufferObjectSpy = (T)CreateTypeSpy(_InstanceType);
				VertexArrayBatchObject vertexArrayObject = arrayBufferObjectSpy as VertexArrayBatchObject;

				if (vertexArrayObject != null) {
					ArrayBufferObject arrayBufferObject;

					arrayBufferObject = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw);
					arrayBufferObject.Create(16);
					vertexArrayObject.SetArray(arrayBufferObject, VertexArraySemantic.Position);

					arrayBufferObject = new ArrayBufferObject(VertexBaseType.Float, 2, BufferObjectHint.StaticCpuDraw);
					arrayBufferObject.Create(16);
					vertexArrayObject.SetArray(arrayBufferObject, VertexArraySemantic.TexCoord);

					vertexArrayObject.SetElementArray(PrimitiveType.Lines);
				}

				return (arrayBufferObjectSpy);
			}

			#endregion
		}

		protected class QueryObjectTypeSupport : DefaultGraphicsTypeSupport
		{
			#region Constructors

			/// <summary>
			/// Construct a QueryObjectTypeSupport.
			/// </summary>
			public QueryObjectTypeSupport() :
				base(typeof(QueryObject))
			{

			}

			#endregion

			#region DefaultGraphicsTypeSupport Overrides

			/// <summary>
			/// Allocate an instance of the type.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override object Allocate(GraphicsContext ctx)
			{
				return (new QueryObject(QueryTarget.SamplesPassed));
			}

			/// <summary>
			/// Allocate an instance of the type mocked for spying.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override T AllocateSpy<T>(GraphicsContext ctx)
			{
				return ((T)CreateTypeSpy(_InstanceType, QueryTarget.SamplesPassed));
			}

			#endregion
		}

		protected class RenderBufferTypeSupport : DefaultGraphicsTypeSupport
		{
			#region Constructors

			/// <summary>
			/// Construct a RenderBufferTypeSupport.
			/// </summary>
			public RenderBufferTypeSupport() :
				base(typeof(RenderBuffer))
			{

			}

			#endregion

			#region DefaultGraphicsTypeSupport Overrides

			/// <summary>
			/// Allocate an instance of the type.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override object Allocate(GraphicsContext ctx)
			{
				return (new RenderBuffer(RenderBuffer.Type.Color, PixelLayout.RGB24, 16, 16));
			}

			/// <summary>
			/// Allocate an instance of the type mocked for spying.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override T AllocateSpy<T>(GraphicsContext ctx)
			{
				return ((T)CreateTypeSpy(_InstanceType, RenderBuffer.Type.Color, PixelLayout.RGB24, 16U, 16U));
			}

			#endregion
		}

		protected class Texture2dTypeSupport : DefaultGraphicsTypeSupport
		{
			#region Constructors

			/// <summary>
			/// Construct a Texture2dTypeSupport.
			/// </summary>
			public Texture2dTypeSupport() :
				base(typeof(Texture2d))
			{

			}

			#endregion

			#region DefaultGraphicsTypeSupport Overrides

			/// <summary>
			/// Actually create resources associated to the type.
			/// </summary>
			/// <param name="instance">
			/// A <see cref="Object"/> that specifies the underlying instance.
			/// </param>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for creating the resources.
			/// </param>
			public override void Create(object instance, GraphicsContext ctx)
			{
				Texture2d texture = instance as Texture2d;

				if (texture == null)
					throw new InvalidOperationException("not implementing Texture2d");

				texture.Create(ctx, 16, 16, PixelLayout.RGB24);
			}

			#endregion
		}

		protected class TextureRectangleTypeSupport : DefaultGraphicsTypeSupport
		{
			#region Constructors

			/// <summary>
			/// Construct a TextureRectangleTypeSupport.
			/// </summary>
			public TextureRectangleTypeSupport() :
				base(typeof(TextureRectangle))
			{

			}

			#endregion

			#region DefaultGraphicsTypeSupport Overrides

			/// <summary>
			/// Actually create resources associated to the type.
			/// </summary>
			/// <param name="instance">
			/// A <see cref="Object"/> that specifies the underlying instance.
			/// </param>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for creating the resources.
			/// </param>
			public override void Create(object instance, GraphicsContext ctx)
			{
				Texture2d texture = instance as Texture2d;

				if (texture == null)
					throw new InvalidOperationException("not implementing TextureRectangle");

				texture.Create(ctx, 16, 16, PixelLayout.RGB24);
			}

			#endregion
		}

		protected class ViewportStateTypeSupport : DefaultGraphicsTypeSupport
		{
			#region Constructors

			/// <summary>
			/// Construct a ViewportStateTypeSupport.
			/// </summary>
			public ViewportStateTypeSupport() :
				base(typeof(State.ViewportState))
			{

			}

			#endregion

			#region DefaultGraphicsTypeSupport Overrides

			/// <summary>
			/// Allocate an instance of the type.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override object Allocate(GraphicsContext ctx)
			{
				return (new State.ViewportState(16, 16));
			}

			/// <summary>
			/// Allocate an instance of the type mocked for spying.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating the instance.
			/// </param>
			/// <returns>
			/// It returns an instance of a specific type.
			/// </returns>
			public override T AllocateSpy<T>(GraphicsContext ctx)
			{
				return ((T)CreateTypeSpy(_InstanceType, 16.0f, 16.0f));
			}

#endregion
		}

		#endregion
	}
}
