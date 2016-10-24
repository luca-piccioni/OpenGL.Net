namespace HelloTriangle.Hal
{
	partial class SampleForm
	{
		/// <summary>
		/// Variabile di progettazione necessaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Pulire le risorse in uso.
		/// </summary>
		/// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Codice generato da Progettazione Windows Form

		/// <summary>
		/// Metodo necessario per il supporto della finestra di progettazione. Non modificare
		/// il contenuto del metodo con l'editor di codice.
		/// </summary>
		private void InitializeComponent()
		{
			this.GraphicsControl = new OpenGL.GraphicsControl();
			this.SuspendLayout();
			// 
			// GraphicsControl
			// 
			this.GraphicsControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.GraphicsControl.ColorBits = ((uint)(24u));
			this.GraphicsControl.DepthBits = ((uint)(0u));
			this.GraphicsControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GraphicsControl.Location = new System.Drawing.Point(0, 0);
			this.GraphicsControl.MultisampleBits = ((uint)(0u));
			this.GraphicsControl.Name = "GraphicsControl";
			this.GraphicsControl.Size = new System.Drawing.Size(565, 488);
			this.GraphicsControl.StencilBits = ((uint)(0u));
			this.GraphicsControl.TabIndex = 0;
			this.GraphicsControl.ContextCreated += new System.EventHandler<OpenGL.GlControlEventArgs>(this.GraphicsControl_GraphicsContextCreated);
			this.GraphicsControl.ContextDestroying += new System.EventHandler<OpenGL.GlControlEventArgs>(this.GraphicsControl_GraphicsContextDestroying);
			this.GraphicsControl.Render += new System.EventHandler<OpenGL.GlControlEventArgs>(this.GraphicsControl_Draw);
			// 
			// SampleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(565, 488);
			this.Controls.Add(this.GraphicsControl);
			this.Name = "SampleForm";
			this.Text = "Hello Triangle (HAL)";
			this.ResumeLayout(false);

		}

		#endregion

		private OpenGL.GraphicsControl GraphicsControl;
	}
}

