
// Copyright (C) 2013-2015 Luca Piccioni
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

namespace OpenGL.State
{
	/// <summary>
	/// Time state
	/// </summary>
	public class TimeState : ShaderUniformState
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static TimeState()
		{
			// Statically initialize uniform properties
			_UniformProperties = DetectUniformProperties(typeof(TimeState));
		}

		/// <summary>
		/// Construct a default TimeState.
		/// </summary>
		public TimeState()
		{
			
		}
		
		/// <summary>
		/// Construct a TimeState specifying the animation time and frame time interval.
		/// </summary>
		public TimeState(float animationTime, float frameInterval)
		{
			mAnimationTime = animationTime;
			mFrameInterval = frameInterval;
		}

		#endregion
		
		#region Time State
		
		/// <summary>
		/// The animation time, expressed in seconds.
		/// </summary>
		private float mAnimationTime;
		
		/// <summary>
		/// The frame time interval, expressed in seconds.
		/// </summary>
		private float mFrameInterval;
		
		#endregion

		#region Default State

		/// <summary>
		/// The system default state for CullFaceState.
		/// </summary>
		public static TimeState DefaultState { get { return (new TimeState()); } }

		#endregion
		
		#region ShaderUniformState Overrides

		/// <summary>
		/// The identifier for the time state.
		/// </summary>
		public static string StateId = "OpenGL.Time";

		/// <summary>
		/// The identifier of this GraphicsState.
		/// </summary>
		public override string StateIdentifier { get { return (StateId); } }

		/// <summary>
		/// Get the uniform state associated with this instance.
		/// </summary>
		protected override Dictionary<string, UniformStateMember> UniformState { get { return (_UniformProperties); } }

		/// <summary>
		/// The uniform state of this TransformStateBase.
		/// </summary>
		private static readonly Dictionary<string, UniformStateMember> _UniformProperties;

		#endregion
	}
}
