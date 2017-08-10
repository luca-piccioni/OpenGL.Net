
// Copyright (C) 2010-2017 Luca Piccioni
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

namespace OpenGL.Objects
{
	/// <summary>
	/// Interface used for allocating and releasing graphics objects.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This interface defines a common interface for those objects which are allocated on an OpenGL context. These
	/// objects belongs to one of the following classes:
	/// - Display list (actually not supported)
	/// - Textures object (<see cref="Texture"/>)
	/// - Buffer object (<see cref="Buffer"/>)
	/// - Shader object (<see cref="Shader"/>)
	/// - Shader program (<see cref="ShaderProgram"/>)
	/// - Shader program pipeline (actually not supported)
	/// - Render buffer object (<see cref="RenderBuffer"/>)
	/// - Framebuffer object (<see cref="Framebuffer"/>)
	/// - Query object (actually not supported)
	/// - Sync object (actually not supported)
	/// - Transform feedback object (actually not supported)
	/// </para>
	/// <para>
	/// These object classes can be shared between different <see cref="GraphicsContext"/> instances, constructed in the proper way. Actually current
	/// OpenGL specification are not officially supporting all those object classes, but in the real world it actually works thanks to drivers
	/// implementations.
	/// </para>
	/// <para>
	/// The IGraphicsResource exposes methods and properties which enable the interface user to identify the object by a name (<see cref="ObjectName"/>). It
	/// also enable the interface user to check effectively the IGraphicsResource existence (<see cref="Exists"/>).
	/// </para>
	/// <para>
	/// The IGraphicsResource defines methods used for allocating and releasing object resources (<see cref="Create"/>, <see cref="Delete"/>.
	/// The methods <see cref="Create"/> and <see cref="Delete"/> are context dependent, since the object creation and
	/// deletion is dependent on the current context of the executing thread.
	/// </para>
	/// <para>
	/// The object deletion (using <see cref="Delete"/> requires a current context on the calling thread. This cannot be always true, because design
	/// limitation (i.e. IGraphicsResource inherit IDisposable) or because application design (i.e. multithreading); but if the IGraphicsResource
	/// is not deleted by <see cref="Delete"/>, it causes a resource leak on an OpenGL context.
	/// 
	/// To avoid the resource leaks, it was introduced the <see cref="RenderGarbageService"/>, which is a garbage collector of IGraphicsResource instances.
	/// Pratically, a IGraphicsResource can be deleted in successive stages by collecting it in the only <see cref="RenderGarbageService"/> instance, and
	/// later request to delete all objects belonging to a <see cref="GraphicsContext"/>.
	/// 
	/// Here it comes the <see cref="Release"/> method. This method have the same functionality of <see cref="Delete"/>, but without requiring a current
	/// context. Ideally, a tipical implementation of this method would garbage the IGraphicsResource instance (by interacting with
	/// <see cref="RenderGarbageService"/>). However, it is necessary to schedule the object delection by using <see cref="RenderGarbageService.DeleteGarbage"/>.
	/// </para>
	/// <para>
	/// The IGraphicsResource interface inherits from <see cref="IDisposable"/>. The IDisposable implementation is used to ensure object resources
	/// by means of the <i>using</i> construct. Tipically <see cref="IDisposable.Dispose"/> implementation shall call <see cref="Release"/>,
	/// since it cannot be sure what (and if a) <see cref="GraphicsContext"/> is current on the calling thread.
	/// </para>
	/// <para>
	/// A direct implementation of this interface is the <see cref="GraphicsResource"/> class, which it can be inherited. This class implements most of
	/// IGraphicsResource interface, leaving to the inheritor a few ones to overrides. This is the suggested way to implement the IGraphicsResource interface,
	/// but there can be some special cases which is necessary the interface inherition; in the case implements the interface following the interface
	/// guidelines.
	/// </para>
	/// </remarks>
	/// <seealso cref="GraphicsResource"/>
	public interface IGraphicsResource : IResource, IGraphicsDisposable
	{
		#region Resource Identification

		/// <summary>
		/// Object class.
		/// </summary>
		/// <remarks>
		/// <para>
		/// The object class identify the resource type. It cannot be <see cref="Guid.Empty"/>, but a meaninfull
		/// value. The allowed values are determined in the concrete implementation of the IGraphicsResource
		/// implementation.
		/// </para>
		/// </remarks>
		Guid ObjectClass { get; }

		/// <summary>
		/// Object name used for this IGraphicsResource.
		/// </summary>
		uint ObjectName { get; }

		/// <summary>
		/// OpenGL object namespace used for creating this GraphicsResource.
		/// </summary>
		/// <remarks>
		/// This property determine the correct association between this object and the render contextes used
		/// for drawing.
		/// </remarks>
		Guid ObjectNamespace { get; }

		/// <summary>
		/// Determine whether this IGraphicsResource really exists for a specific context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that would have created (or a sharing one) the object. This context shall be current to
		/// the calling thread.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this object exists in the object space of <paramref name="ctx"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The object existence is done by checking a valid object by its name <see cref="ObjectName"/>. This routine will test whether
		/// <paramref name="ctx"/> has created this IGraphicsResource (or is sharing with the creator).
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current to the calling thread.
		/// </exception>
		bool Exists(GraphicsContext ctx);

		#endregion

		#region Resource Management

		/// <summary>
		/// Create this IGraphicsResource.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object. The object space of this <see cref="GraphicsContext"/> is used
		/// to generate <see cref="ObjectName"/>, and all contextes sharing lists with this parameter can handle this IGraphicsResource.
		/// The <see cref="GraphicsContext"/> shall be current to the calling thread.
		/// </param>
		/// <remarks>
		/// <para>
		/// After a successfull call to Create, <see cref="Exists"/> shall return true.
		/// </para>
		/// </remarks>
		/// <seealso cref="Delete"/>
		void Create(GraphicsContext ctx);

		/// <summary>
		/// Delete this IGraphicsResource.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for deleting this object. The IGraphicsResource shall belong to the object space to this
		/// <see cref="GraphicsContext"/>. The <see cref="GraphicsContext"/> shall be current to the calling thread.
		/// </param>
		/// <remarks>
		/// <para>
		/// After a successfull call to Create, <see cref="Exists"/> shall return true.
		/// </para>
		/// </remarks>
		/// <seealso cref="Create"/>
		void Delete(GraphicsContext ctx);

		#endregion
	}
}
