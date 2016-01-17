namespace HelloTriangle
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
			this.SampleGraphicsControl = new OpenGL.GraphicsControl();
			this.SuspendLayout();
			// 
			// SampleGraphicsControl
			// 
			this.SampleGraphicsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SampleGraphicsControl.DepthBits = ((uint)(0u));
			this.SampleGraphicsControl.DoubleBuffer = true;
			this.SampleGraphicsControl.Location = new System.Drawing.Point(12, 12);
			this.SampleGraphicsControl.MultisampleBits = ((uint)(0u));
			this.SampleGraphicsControl.Name = "SampleGraphicsControl";
			this.SampleGraphicsControl.Size = new System.Drawing.Size(663, 553);
			this.SampleGraphicsControl.StencilBits = ((uint)(0u));
			this.SampleGraphicsControl.TabIndex = 0;
			this.SampleGraphicsControl.GraphicsContextCreated += new System.EventHandler<OpenGL.GraphicsControlEventArgs>(this.SampleGraphicsControl_GraphicsContextCreated);
			this.SampleGraphicsControl.GraphicsContextDestroyed += new System.EventHandler<OpenGL.GraphicsControlEventArgs>(this.SampleGraphicsControl_GraphicsContextDestroyed);
			this.SampleGraphicsControl.Render += new System.EventHandler<OpenGL.GraphicsControlEventArgs>(this.SampleGraphicsControl_Render);
			// 
			// SampleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(687, 577);
			this.Controls.Add(this.SampleGraphicsControl);
			this.Name = "SampleForm";
			this.Text = "Hello Triangle";
			this.ResumeLayout(false);

		}

		#endregion

		private OpenGL.GraphicsControl SampleGraphicsControl;
	}
}

