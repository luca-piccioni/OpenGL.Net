
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
using System.Windows.Forms;

namespace OpenGL
{
	/// <summary>
	/// Platform control.
	/// </summary>
	public interface IControl
	{
		/// <summary>
		/// 
		/// </summary>
		IntPtr Handle { get; }
	}

	static class IControlFactory
	{
		public static IControl Create(Control control)
		{
			if (control == null)
				throw new ArgumentNullException("control");
			return (new IControlControl(control));
		}

		private class IControlControl : IControl
		{
			public IControlControl(Control control) { _Control = control; }

			private readonly Control _Control;

			public IntPtr Handle { get { return (_Control.Handle); } }
		}
	}
}
