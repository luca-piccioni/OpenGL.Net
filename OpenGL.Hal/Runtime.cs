
// Copyright (C) 2013 Luca Piccioni
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
using System.Reflection;

namespace OpenGL
{
	/// <summary>
	/// Class able to detect the actual runtime.
	/// </summary>
	static class Runtime
	{
		/// <summary>
		/// Initializes the <see cref="Derm.Runtime"/> class.
		/// </summary>
		static Runtime()
		{
			Type monoRuntime = Type.GetType("Mono.Runtime", false);
			
			if (monoRuntime != null) {
				mRunningVersion = RuntimeVersion.MonoGeneric;
				try {
					MethodInfo mi = monoRuntime.GetMethod ("GetDisplayName", BindingFlags.Static | BindingFlags.NonPublic);
					if (mi != null)
						mVersionString = mi.Invoke(null, new object [0]) as string;
				} catch { /* Ignore */ }
			}
		}
		
		/// <summary>
		/// Get whether the running runtime is a Mono instance.
		/// </summary>
		public static bool RunningMono
		{
			get
			{
				switch (mRunningVersion) {
					case RuntimeVersion.MonoGeneric:
						return (true);
					default:
						return (false);
				}
			}
		}
		
		/// <summary>
		/// By default, suppose running on .NET runtime.
		/// </summary>
		public static RuntimeVersion Version { get { return (mRunningVersion); } }
		
		/// <summary>
		/// Detailed version string, if available.
		/// </summary>
		public static string VersionString { get { return (mVersionString); } }
		
		/// <summary>
		/// By default, suppose running on .NET runtime.
		/// </summary>
		private static readonly RuntimeVersion mRunningVersion = RuntimeVersion.DotNet;
		
		/// <summary>
		/// Detailed version string, if available.
		/// </summary>
		private static readonly string mVersionString;
	}
}

