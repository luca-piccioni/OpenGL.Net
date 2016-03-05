
// Copyright (C) 2016 Luca Piccioni
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
using System.Reflection;
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Base class for supporting unmanaged plugin implementations.
	/// </summary>
	abstract class Plugin : IPlugin
	{
		#region Constructors

		protected Plugin(string assemblyPath, string factoryFunction)
		{
			if (assemblyPath == null)
				throw new ArgumentNullException("assemblyPath");

			if ((_CreatePluginFactoryPtr = GetProcAddress.GetAddress(assemblyPath, factoryFunction)) == IntPtr.Zero)
				throw new ArgumentException("not a valid factory function", "factoryFunction");

			// Marshal.GetDelegateForFunctionPointer(createFactoryPtr, factoryFunction);
		}

		#endregion

		#region Plugin Factory

		protected Delegate CreatePluginFactoryDelegate<T>()
		{
			Delegate createPluginFactoryDelegate = Marshal.GetDelegateForFunctionPointer(_CreatePluginFactoryPtr, typeof(T));

			if (createPluginFactoryDelegate == null)
				throw new InvalidOperationException("cannot create delegate");

			return (createPluginFactoryDelegate);
		}

		private readonly IntPtr _CreatePluginFactoryPtr;

		#endregion

		#region P/Invoke On Plugin

		/// <summary>
		/// Delegate for instantiating the plugin instance.
		/// </summary>
		protected delegate IntPtr CreateDelegate();

		/// <summary>
		/// Delegate for disposing the plugin instance.
		/// </summary>
		protected delegate void DestroyDelegate(IntPtr handle);

		/// <summary>
		/// Delegate for <see cref="Name"/> getter.
		/// </summary>
		protected delegate string GetNameDelegate(IntPtr handle);

		/// <summary>
		/// Delegate for <see cref="CheckAvailability"/> getter.
		/// </summary>
		protected delegate bool CheckAvailabilityDelegate(IntPtr handle);

		/// <summary>
		/// Aggregate of delegates for implementing <see cref="IPlugin"/> interface.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, Pack = 4)]
		protected struct Delegates
		{
			/// <summary>
			///  Delegate for instantiating the plugin instance.
			/// </summary>
			public CreateDelegate Create;

			/// <summary>
			/// Delegate for disposing the plugin instance.
			/// </summary>
			public DestroyDelegate Destroy;

			/// <summary>
			/// Delegate for <see cref="MediaCodecPlugin.Name"/> getter.
			/// </summary>
			public GetNameDelegate GetName;

			/// <summary>
			/// Delegate for <see cref="MediaCodecPlugin.CheckAvailability"/> getter.
			/// </summary>
			public CheckAvailabilityDelegate CheckAvailability;
		}

		#endregion

		#region IPlugin Implementation

		/// <summary>
		/// Plugin name.
		/// </summary>
		/// <remarks>
		/// This name identity the plugin implementation. It shall be unique in the plugin set available at runtime.
		/// </remarks>
		public abstract string Name { get; }

		/// <summary>
		/// Determine whether this plugin is available for the current process.
		/// </summary>
		/// <returns>
		/// It returns a boolean value indicating whether the plugin is available for the current process.
		/// </returns>
		public abstract bool CheckAvailability();

		#endregion
	}
}
