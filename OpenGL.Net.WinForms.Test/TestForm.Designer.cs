namespace OpenGL.Test
{
	partial class TestForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._GlControl = new OpenGL.GlControl();
			this.SuspendLayout();
			// 
			// _GlControl
			// 
			this._GlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this._GlControl.ColorBits = ((uint)(24u));
			this._GlControl.DepthBits = ((uint)(0u));
			this._GlControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this._GlControl.Location = new System.Drawing.Point(0, 0);
			this._GlControl.MultisampleBits = ((uint)(0u));
			this._GlControl.Name = "_GlControl";
			this._GlControl.Size = new System.Drawing.Size(391, 331);
			this._GlControl.StencilBits = ((uint)(0u));
			this._GlControl.TabIndex = 0;
			// 
			// TestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 331);
			this.Controls.Add(this._GlControl);
			this.Name = "TestForm";
			this.Text = "TestForm";
			this.ResumeLayout(false);

		}

		#endregion

		internal GlControl _GlControl;
	}
}