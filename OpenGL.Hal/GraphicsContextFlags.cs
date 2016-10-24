
// Copyright (c) 2013-2016 Luca Piccioni
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
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace OpenGL
{
	/// <summary>
	/// Flags controlling the <see cref="GraphicsContext"/> bahvior.
	/// </summary>
	[Flags]
	public enum GraphicsContextFlags
	{
		/// <summary>
		/// No flags placeholder.
		/// </summary>
		None = 					0x0000,

		#region Flags

		/// <summary>
		/// Construct a context using the debug profile.
		/// </summary>
		/// <remarks>
		/// One of the following extension must be implemented for supporting this flag:
		/// - GLX_ARB_create_context
		/// - WGL_ARB_create_context
		/// </remarks>
		Debug = 				0x0001,
		
		/// <summary>
		/// Constant a forward compatible context.
		/// </summary>
		/// <remarks>
		/// Forward compatibility is considered only if the following extensions are implemented:
		/// - GLX_ARB_create_context
		/// - WGL_ARB_create_context
		/// </remarks>
		ForwardCompatible = 	0x0002,

		/// <summary>
		/// Construct a context using the robust profile.
		/// </summary>
		/// <remarks>
		/// One of the following extensions set must be implemented for supporting this flag:
		/// - GLX_ARB_create_context, GLX_ARB_create_context_robustness and GL_ARB_robustness
		/// - WGL_ARB_create_context, WGL_ARB_create_context_robustness and GL_ARB_robustness
		/// </remarks>
		Robust =				0x0004,

		/// <summary>
		/// Reset event is guaranteed to do not affect other applications.
		/// </summary>
		ResetIsolation =		0x0080,

		#endregion

		#region Profiles

		/// <summary>
		/// Construct a context using the compatibility profile.
		/// </summary>
		/// <remarks>
		/// One of the following extension must be implemented for supporting this flag:
		/// - GLX_ARB_create_context_profile
		/// - WGL_ARB_create_context_profile
		/// </remarks>
		CoreProfile =			0x0100,

		/// <summary>
		/// Construct a context using the compatibility profile.
		/// </summary>
		/// <remarks>
		/// One of the following extension must be implemented for supporting this flag:
		/// - GLX_ARB_create_context_profile
		/// - WGL_ARB_create_context_profile
		/// </remarks>
		CompatibilityProfile =	0x0200,
		
		/// <summary>
		/// Constant a context using a ES/ES2 compatible implementation.
		/// </summary>
		/// <remarks>
		/// One of the following extensions set must be implemented for supporting this flag:
		/// - GLX_ARB_create_context_profile and GLX_EXT_create_context_es_profile/GLX_EXT_create_context_es2_profile
		/// - WGL_ARB_create_context_profile and WGL_EXT_create_context_es_profile/WGL_EXT_create_context_es2_profile
		/// </remarks>
		EmbeddedProfile =		0x0400

		#endregion
	}

	/// <summary>
	/// The <see cref="UITypeEditor"/> for editing <see cref="GraphicsContextFlags"/> on designer.
	/// </summary>
	internal class GraphicsContextFlagsEditor : UITypeEditor
	{
		#region UITypeEditor Overrides

		public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
		{
			return (UITypeEditorEditStyle.DropDown);
		}

		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			IWindowsFormsEditorService editorService = null;
			if (provider != null)
				editorService = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;

			if (editorService != null) {
				UserControl userControl = new UserControl();

				userControl.BackColor = System.Drawing.SystemColors.Window;

				// Button
				Button button = new Button();

				button.Dock = DockStyle.Bottom;
				button.Text = "OK";
				button.Click += delegate (object sender, EventArgs e) {
					editorService.CloseDropDown();
				};

				userControl.Controls.Add(button);

				// CheckedListBox
				CheckedListBox checkedListBox = new CheckedListBox();
				GraphicsContextFlags currentValue = (GraphicsContextFlags)value;

				checkedListBox.CheckOnClick = true;
				checkedListBox.Dock = DockStyle.Fill;
				foreach (GraphicsContextFlags flag in Enum.GetValues(typeof(GraphicsContextFlags)))
					checkedListBox.Items.Add(flag, (currentValue & flag) != 0);

				checkedListBox.ItemCheck += delegate (object sender, ItemCheckEventArgs e) {
					GraphicsContextFlags checkedValue = (GraphicsContextFlags)checkedListBox.Items[e.Index];

					// Update current value
					switch (e.NewValue) {
						case CheckState.Checked:
							currentValue |= checkedValue;
							value = currentValue;
							break;
						case CheckState.Unchecked:
							currentValue &= ~checkedValue;
							value = currentValue;
							break;
					}
				};
				userControl.Controls.Add(checkedListBox);

				editorService.DropDownControl(userControl);
			}

			return (value);
		}

		#endregion
	}
}

