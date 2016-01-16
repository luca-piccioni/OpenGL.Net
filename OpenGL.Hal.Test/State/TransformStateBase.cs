
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

using System;

using NUnit.Framework;

using OpenGL.State;

namespace OpenGL.Hal.Test
{
	[TestFixture(typeof(TransformStateSingle))]
	[TestFixture(typeof(TransformStateDouble))]
	class TransformStateBaseTest<T> : TestBase where T : TransformStateBase
	{
		#region LocalProjection

		[Test]
		public void LocalProjection()
		{
			using (T transformState = Activator.CreateInstance<T>()) {
				IMatrix4x4 projectionMatrix;

				// By default, LocalProjection is null
				Assert.IsNull(transformState.LocalProjection);
				// Allow to set custom projections
				projectionMatrix = new OrthoProjectionMatrix();
				Assert.DoesNotThrow(delegate () { transformState.LocalProjection = projectionMatrix; });
				// LocalProjection reference another clone
				Assert.IsNotNull(transformState.LocalProjection);
				Assert.AreNotSame(projectionMatrix, transformState.LocalProjection);
				// Allow to reset projection
				Assert.DoesNotThrow(delegate () { transformState.LocalProjection = null; });
				Assert.IsNull(transformState.LocalProjection);
			}
		}

		#endregion

		#region LocalModel

		[Test]
		public void LocalModel()
		{
			using (T transformState = Activator.CreateInstance<T>()) {
				// By default, LocalModel is not null
				Assert.IsNotNull(transformState.LocalModel);
			}
		}

		#endregion
	}
}
