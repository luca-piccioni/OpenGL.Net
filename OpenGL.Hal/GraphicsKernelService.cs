
// Copyright (C) 2009-2012 Luca Piccioni
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//  
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//  
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Threading;

namespace OpenGL
{
	/// <summary>
	/// RenderKernel service.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This class allow to execute application code scheduled by the RenderKernel instance. The service is scheduled
	/// using the following models:
	/// - <see cref="ExecutionModel.Context"/>: service is executed sequentially inside the main rendering thread, with the current OpenGL context;
	/// - <see cref="ExecutionModel.Multithread"/>: service is executed in a separated thread, without a current OpenGL context;
	/// - <see cref="ExecutionModel.MultithreadContext"/>: service is executed in a separate thread, with a current OpenGL context;
	/// - <see cref="ExecutionModel.MultithreadMixed"/>: service is executed in a separate thread without a current OpenGL context, but it will be executed
	///   inside the main rendering thread also, having a current OpenGL context.
	/// 
	/// For more information on service execution models, see <see cref="ExecutionModel"/>.
	/// </para>
	/// <para>
	/// Depending on the execution model choosen at construction time, derived classes shall implement at least one of the following methods:
	/// - <see cref="ContextExecute"/>
	/// - <see cref="ThreadExecute"/>
	/// 
	/// However, if any exception is caught, it is possible to request a fallback execution model support, as descripted in <see cref="IsExecutionModelSupported"/>.
	/// </para>
	/// <para>
	/// 
	/// </para>
	/// </remarks>
	public abstract class GraphicsKernelService : GraphicsResource
	{
		#region Constuctors

		/// <summary>
		/// Construct a RenderKernelService.
		/// </summary>
		/// <param name="name">
		/// A <see cref="System.String"/> specifying the service name. This name is used to getting service instances; since
		/// this information is controlled by use application too, it's better to choose well formed names, such as
		/// <i>Domain.ServiceName</i>. Services defined by Derm have the domain name part equals to "Derm".
		/// </param>
		/// <param name="execution">
		/// A <see cref="ExecutionModel"/> which specify how to schedule execution of this RenderKernelService.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="name"/> is null.
		/// </exception>
		protected GraphicsKernelService(string name, ExecutionModel execution)
		{
			if (name == null)
				throw new ArgumentNullException("name");

			// Store service name
			mServiceName = name;
			// Store execution model
			mExecutionModel = execution;
		}

		#endregion

		#region Execution Model

		/// <summary>
		/// Enumeration determining how service is scheduled.
		/// </summary>
		public enum ExecutionModel
		{
			/// <summary>
			/// Simple service.
			/// </summary>
			None,
			/// <summary>
			/// Single-thread execution with current OpenGL context.
			/// </summary>
			/// <remarks>
			/// <para>
			/// 
			/// </para>
			/// </remarks>
			Context,
			/// <summary>
			/// Multi-thread execution without current OpenGL context.
			/// </summary>
			Multithread,
			/// <summary>
			/// Multi-thread execution with current OpenGL context.
			/// </summary>
			MultithreadContext,
			/// <summary>
			/// Multi-thread execution without current OpenGL context, but falling back execution on main rendering thread.
			/// </summary>
			MultithreadMixed,
		}

		/// <summary>
		/// Determine whether a specific execution model is supported.
		/// </summary>
		/// <param name="model">
		/// A <see cref="ExecutionModel"/> to test for support.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this GraphicsContextService can change its execution model to the one
		/// specified by <paramref name="model"/>. The current implementation returns true only if <paramref name="model"/>
		/// equals to the one specified at construction time (this is done to follow method semantic, instead of returning
		/// always false or throwing NotImplementedException).
		/// </returns>
		/// <remarks>
		/// <para>
		/// Normally, an execution model is dependent on the service task. If a service doesn't requires a current OpenGL context
		/// sharing with the main OpenGL context (created by <see cref="RenderKernel"/>), there's no problem about the execution
		/// of the service. But if a service really requires a current OpenGL context sharing with the main OpenGL context (i.e.
		/// a Texture generation service), normally it requires the execution model <see cref="ExecutionModel.MultithreadContext"/>.
		/// </para>
		/// <para>
		/// Setting the execution model to <see cref="ExecutionModel.MultithreadContext"/> could lead to exceptions (caused by
		/// not sufficient system resources, incompatibility between OpenGL contextes or missing platform support). In the case
		/// an exception is caught, there are possibilities for the service to accomplish its task even if it is not possible
		/// to have a current OpenGL context.
		/// </para>
		/// <para>
		/// The first option would be the service execution change into <see cref="ExecutionModel.MultithreadMixed"/>. This would
		/// imply additional synchronization between the separated thread and the main thread executing this service. This option
		/// shall be selected by those services which can execute long-time tasks without requiring a current context, and apply
		/// task result reasonably fast.
		/// </para>
		/// <para>
		/// The second option would be the service execution change into <see cref="ExecutionModel.Context"/>. This would imply
		/// the loose of all advantages offered by multithreading, but it is a secure fallback execution model.
		/// </para>
		/// </remarks>
		protected virtual bool IsExecutionModelSupported(ExecutionModel model)
		{
			return (model == mExecutionModel);
		}

		/// <summary>
		/// Current service execution model.
		/// </summary>
		/// <remarks>
		/// This field shall be modified by following indications returned by <see cref="IsExecutionModelSupported"/>
		/// </remarks>
		internal ExecutionModel Model
		{
			get { return (mExecutionModel); }
			set {
				mExecutionModel = value;
			}
		}

		/// <summary>
		/// Determine whether <see cref="ContextExecute"/> shall be called for this RenderKernelService.
		/// </summary>
		internal bool RequiresKernelContext
		{
			get {
				switch (mExecutionModel) {
					case ExecutionModel.Context:
					case ExecutionModel.MultithreadMixed:
						return (true);
					default:
						return (false);
				}
			}
		}

		/// <summary>
		/// Determine whether <see cref="ThreadExecute"/> shall be called for this RenderKernelService.
		/// </summary>
		/// <remarks>
		/// The method <see cref="ThreadExecute"/> is called in a separate thread, by calling <see cref="Start"/> methods.
		/// </remarks>
		internal bool IsMultithreadModel
		{
			get {
				switch (mExecutionModel) {
					case ExecutionModel.Context:
						return (false);
					default:
						return (true);
				}
			}
		}

		/// <summary>
		/// Current service execution model.
		/// </summary>
		private ExecutionModel mExecutionModel;

		#endregion

		#region Context Execution Management

		/// <summary>
		/// Execute this service in the main rendering thread.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> available for this method execution. The context specified is always defined and it is
		/// always current to the executing thread.
		/// </param>
		/// <exception cref="NotImplementedException">
		/// Exception always thrown. The implementors shall override this method in the case the execution model specified
		/// at construction time is <see cref="ExecutionModel.Context"/> or <see cref="ExecutionModel.MultithreadMixed"/>.
		/// </exception>
		public virtual void ContextExecute(GraphicsContext ctx)
		{
			throw new NotImplementedException("RenderKernelService.ContextExecute(GraphicsContext) not overriden, but executing in main thread");
		}

		#endregion

		#region Multithread Execution Management

		/// <summary>
		/// This RenderKernelService name.
		/// </summary>
		public string ServiceName
		{
			get { return (mServiceName); }
		}

		/// <summary>
		/// Determine whether the executing thread is the one running this service.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This property determine whether the current thread is the one executing this service. This
		/// could be useful for those routines which need to know whether they are executed by the service
		/// or not.
		/// </para>
		/// <para>
		/// By default, this property implementation returns always false. In order to make it work as expected,
		/// the inheritors shall implement this in the following way:
		/// 
		/// \code
		/// [ThreadStatic()]
		/// private static bool mIsCurrent = false;
		/// 
		/// public override bool IsCurrent { get { return (mIsCurrent); } }
		/// 
		/// protected virtual void ThreadExecute(GraphicsContext ctx)
		/// {
		///		// This thread is the service one
		///		mIsCurrent = true;
		/// 
		///		// .... Do service job
		/// }
		/// \endcode
		/// </para>
		/// </remarks>
		public virtual bool IsCurrent { get { return (false); } }

		/// <summary>
		/// Execute this service is a separate thread.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> available for the executing thread.
		/// If this parameter is not null, the GraphicsContext will be current on the executing thread, sharing object name
		/// space with the main rendering thread context.
		/// If this parameter is null, no context is provided; however, thread is still able to create new GraphicsContext.
		/// </param>
		/// <remarks>
		/// A tipical implementation shall check <see cref="TestCancel"/> returned value to terminate thread as soon as possible:
		/// 
		/// \code
		/// while (TestCancel == false) {
		///		// Do some work
		///		// Do not saturate CPU
		///		Thread.Sleep(1);
		/// }
		/// \endcode
		/// </remarks>
		/// <seealso cref="TestCancel"/>
		/// <exception cref="NotImplementedException">
		/// Exception always thrown. The implementors shall override this method in the case the execution model specified
		/// at construction time is not <see cref="ExecutionModel.Context"/>.
		/// </exception>
		protected virtual void ThreadExecute(GraphicsContext ctx)
		{
			throw new NotImplementedException("RenderKernelService.ThreadExecute(GraphicsContext) not overriden, but executing in Multithread");
		}

		/// <summary>
		/// Test for service stop request(s).
		/// </summary>
		protected bool TestCancel { get { return (mServiceStop); } }

		/// <summary>
		/// Start this kernel service.
		/// </summary>
		internal void Start()
		{
			Start(null);
		}

		/// <summary>
		/// Start this kernel service.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/>
		/// </param>
		internal void Start(GraphicsContext ctx)
		{
			// Service is running
			mServiceStop = false;
			// Create and start service thread
			mServiceThread = new Thread(KernelServiceMain);
			mServiceThread.Name = mServiceName;
			mServiceThread.Start(new object[] { this, ctx });
		}

		/// <summary>
		/// Request to stop this kernel service.
		/// </summary>
		internal void Join()
		{
			// Request to stop service
			mServiceStop = true;
			// Wait for service termination (no timeout)
			mServiceThread.Join();
		}

		/// <summary>
		/// Main routine for every RenderKernelService thread.
		/// </summary>
		/// <param name="data"></param>
		private static void KernelServiceMain(object data)
		{
			object[] args = (object[])data;
			GraphicsKernelService kService = (GraphicsKernelService)args[0];
			GraphicsContext ctx = (GraphicsContext)args[1];

			// Make the context current
			if (ctx != null)
				ctx.MakeCurrent(true);

			// Execute this service in another thread
			kService.ThreadExecute(ctx);

			// Dispose current context, if any
			if (ctx != null)
				ctx.Dispose();
		}

		/// <summary>
		/// This service name.
		/// </summary>
		private string mServiceName;

		/// <summary>
		/// Service thread.
		/// </summary>
		private Thread mServiceThread = null;

		/// <summary>
		/// Flag indicating to stop service.
		/// </summary>
		private bool mServiceStop = false;

		#endregion

		#region Object Name Space Locality

		/// <summary>
		/// Bind this RenderKernelService to no specific object name space.
		/// </summary>
		internal void BindObjectNameSpace()
		{
			BindObjectNameSpace(sNoObjectNameSpace);
		}

		/// <summary>
		/// Bind this RenderKernelService to a specific object name space.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that specifies the object name space used.
		/// </param>
		internal void BindObjectNameSpace(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.ObjectNameSpace == Guid.Empty)
				throw new ArgumentException("no object name space", "ctx");

			BindObjectNameSpace(ctx.ObjectNameSpace);
		}

		/// <summary>
		/// Unbind this RenderKernelService from a specific object name space.
		/// </summary>
		internal void UnbindObjectNameSpace()
		{
			if (mObjectNameSpace == Guid.Empty)
				throw new InvalidOperationException("not bound");

			UnbindObjectNameSpace(mObjectNameSpace);
		}

		/// <summary>
		/// Bind this RenderKernelService to a specific object name space.
		/// </summary>
		/// <param name="sObjectNameSpace">
		/// A <see cref="System.Guid"/> that specifies the object name space used.
		/// </param>
		private void BindObjectNameSpace(Guid sObjectNameSpace)
		{
			if ((mObjectNameSpace != Guid.Empty) && (mObjectNameSpace != sObjectNameSpace))
				throw new InvalidOperationException("service cannot be bound to two object name spaces");
			// Set object name space for this RenderKernelService
			mObjectNameSpace = sObjectNameSpace;

			lock (sKernelServicesLock) {
				GraphicsKernelService service = GetService(sObjectNameSpace, mServiceName);

				if (service == null) {
					List<GraphicsKernelService> services = (sKernelServices.ContainsKey(mObjectNameSpace) == true) ?
						sKernelServices[mObjectNameSpace] :
						new List<GraphicsKernelService>()
					;

					// Append this service to the services bound to this
					services.Add(this);

					sKernelServices[mObjectNameSpace] = services;
				}
			}
		}

		/// <summary>
		/// Unbind this RenderKernelService from a specific object name space.
		/// </summary>
		/// <param name="sObjectNameSpace">
		/// A <see cref="System.Guid"/> that specifies the object name space used.
		/// </param>
		private void UnbindObjectNameSpace(Guid sObjectNameSpace)
		{
			lock (sKernelServicesLock) {
				if (sKernelServices.ContainsKey(mObjectNameSpace) == false)
					throw new ArgumentException("unknown object name space", "sObjectNameSpace");

				GraphicsKernelService service = GetService(sObjectNameSpace, mServiceName);
				List<GraphicsKernelService> services = sKernelServices[mObjectNameSpace];

				if (service == null)
					throw new InvalidOperationException("not bound to any object name space");

				// Remove this service, if reference count is 0
				services.Remove(this);
				// List namespace list, if no service remains
				if (services.Count == 0)
					sKernelServices.Remove(mObjectNameSpace);
				// No object name space bound (no more referencing context)
				mObjectNameSpace = Guid.Empty;
			}
		}

		/// <summary>
		/// Get the RenderKernelService for the calling thread by name.
		/// </summary>
		/// <param name="sObjectNameSpace">
		/// A <see cref="System.Guid"/> that specify the object name space of the service.
		/// </param>
		/// <param name="sName">
		/// A <see cref="System.String"/> that specifies the service name.
		/// </param>
		/// <returns>
		/// It returns the RenderKernelService with the name <paramref name="sName"/> for the calling thread. In the case
		/// no RenderKernelService is registered under <paramref name="sName"/>, it returns null.
		/// </returns>
		/// <remarks>
		/// Derived RenderKernelService classes shall use this protected method to expose an utility routine to get access to
		/// the RenderKernelService instance for the calling thread. For example:
		/// 
		/// \code
		/// class MyService : RenderKernelService
		/// {
		///		public MyService() : base("Domain.MyService", ExecutionModel.Multithread) { }
		/// 
		///		public static MyService GetService() { return (GetService(ServiceName)); }
		/// }
		/// \endcode
		/// 
		/// In this way, user code can access to the <i>MyService</i> instance for the calling thread simply calling a static
		/// method.
		/// </remarks>
		protected static GraphicsKernelService GetService(Guid sObjectNameSpace, string sName)
		{
			if (sName == null)
				throw new ArgumentNullException("sName");

			lock (sKernelServicesLock) {
				if (sKernelServices.ContainsKey(sObjectNameSpace) == false)
					return (null);
				foreach (GraphicsKernelService service in sKernelServices[sObjectNameSpace]) {
					if (service.ServiceName == sName)
						return (service);
				}

				return (null);
			}
		}

		/// <summary>
		/// Bound object name space.
		/// </summary>
		private Guid mObjectNameSpace = Guid.Empty;

		/// <summary>
		/// Predefined object name space for indicating no real object name space.
		/// </summary>
		private static Guid sNoObjectNameSpace = new Guid("15316C3D-6CE5-4dc9-8A39-1A73106E1B57");

		/// <summary>
		/// Map between object name space and a list of kernel services.
		/// </summary>
		private static Dictionary<Guid, List<GraphicsKernelService>> sKernelServices = new Dictionary<Guid,List<GraphicsKernelService>>();

		/// <summary>
		/// Lock for accessing <see cref="sKernelServices"/>.
		/// </summary>
		private static object sKernelServicesLock = new object();

		#endregion

		#region Logging

		/// <summary>
		/// Logger of this class.
		/// </summary>
		private static readonly ILogger sLog = Log.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion

		#region GraphicsResource Overrides

		/// <summary>
		/// Shader include object class.
		/// </summary>
		internal static readonly Guid ThisObjectClass = new Guid("CD7B206B-919D-40e2-9AB1-C5C3B8C98A8A");

		/// <summary>
		/// Shader include object class.
		/// </summary>
		public override Guid ObjectClass { get { return (ThisObjectClass); } }

		/// <summary>
		/// Determine whether this object requires a name bound to a context or not.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// <para>
		/// It returns a boolean value indicating whether this GraphicsResource implementation requires a name
		/// generation on creation. In the case this routine returns true, the routine <see cref="GraphicsResource.CreateName"/>
		/// will be called (and it must be overriden). In  the case this routine returns false, the routine
		/// <see cref="GraphicsResource.CreateName"/> won't be called (and indeed it is not necessary to override it) and a
		/// name is generated automatically in a context-independent manner.
		/// </para>
		/// <para>
		/// This implementation returns always true.
		/// </para>
		/// </returns>
		protected override bool RequiresName(GraphicsContext ctx)
		{
			return (false);
		}

		#endregion
	}
}
