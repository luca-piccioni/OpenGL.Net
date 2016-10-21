namespace SingleContext
{
	partial class SharingDialog
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
			this.RenderControl = new OpenGL.GlControl();
			this.SuspendLayout();
			// 
			// RenderControl
			// 
			this.RenderControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.RenderControl.ColorBits = ((uint)(24u));
			this.RenderControl.ContextSharing = OpenGL.GlControl.ContextSharingOption.SingleContext;
			this.RenderControl.ContextSharingGroup = "MainContext";
			this.RenderControl.DepthBits = ((uint)(0u));
			this.RenderControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RenderControl.Location = new System.Drawing.Point(0, 0);
			this.RenderControl.MultisampleBits = ((uint)(0u));
			this.RenderControl.Name = "RenderControl";
			this.RenderControl.Size = new System.Drawing.Size(572, 487);
			this.RenderControl.StencilBits = ((uint)(0u));
			this.RenderControl.TabIndex = 0;
			// 
			// SharingDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(572, 487);
			this.Controls.Add(this.RenderControl);
			this.Name = "SharingDialog";
			this.Text = "Sharing Dialog";
			this.ResumeLayout(false);

		}

		#endregion

		private OpenGL.GlControl RenderControl;
	}
}