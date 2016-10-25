namespace HelloTriangle.ANGLE
{
	partial class SampleForm
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
			this.glControl1.ContextProfile = OpenGL.GlControl.ProfileType.Embedded;
			this.glControl1.DepthBits = ((uint)(0u));
			this.glControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.glControl1.Location = new System.Drawing.Point(0, 0);
			this.glControl1.MultisampleBits = ((uint)(0u));
			this.glControl1.Name = "glControl1";
			this.glControl1.Size = new System.Drawing.Size(762, 509);
			this.glControl1.StencilBits = ((uint)(0u));
			this.glControl1.TabIndex = 0;
			this.glControl1.ContextCreated += new System.EventHandler<OpenGL.GlControlEventArgs>(this.RenderControl_ContextCreated);
			this.glControl1.ContextDestroying += new System.EventHandler<OpenGL.GlControlEventArgs>(this.RenderControl_ContextDestroying);
			this.glControl1.Render += new System.EventHandler<OpenGL.GlControlEventArgs>(this.RenderControl_Render);
			// 
			// SampleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(762, 509);
			this.Controls.Add(this.glControl1);
			this.Name = "SampleForm";
			this.Text = "Hello triangle with ANGLE";
			this.Load += new System.EventHandler(this.SampleForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private OpenGL.GlControl glControl1;
	}
}

