namespace SingleContext
{
	partial class SharingForm
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
			this.glControl1 = new OpenGL.GlControl();
			this.SuspendLayout();
			// 
			// glControl1
			// 
			this.glControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.glControl1.ColorBits = ((uint)(24u));
			this.glControl1.ContextSharing = OpenGL.GlControl.ContextSharingOption.SingleContext;
			this.glControl1.ContextSharingGroup = "MainContext";
			this.glControl1.DepthBits = ((uint)(0u));
			this.glControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.glControl1.Location = new System.Drawing.Point(0, 0);
			this.glControl1.MultisampleBits = ((uint)(0u));
			this.glControl1.Name = "glControl1";
			this.glControl1.Size = new System.Drawing.Size(567, 455);
			this.glControl1.StencilBits = ((uint)(0u));
			this.glControl1.TabIndex = 0;
			this.glControl1.Click += new System.EventHandler(this.glControl1_Click);
			// 
			// SharingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(567, 455);
			this.Controls.Add(this.glControl1);
			this.Name = "SharingForm";
			this.Text = "Main Window";
			this.ResumeLayout(false);

		}

		#endregion

		private OpenGL.GlControl glControl1;
	}
}

