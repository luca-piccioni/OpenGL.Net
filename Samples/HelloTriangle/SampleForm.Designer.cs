namespace HelloTriangle
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
			this.Graphics = new OpenGL.GraphicsControl();
			this.SuspendLayout();
			// 
			// Graphics
			// 
			this.Graphics.ContextFlags = OpenGL.GraphicsContextFlags.CompatibilityProfile;
			this.Graphics.DepthBits = ((uint)(0u));
			this.Graphics.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Graphics.Location = new System.Drawing.Point(0, 0);
			this.Graphics.MultisampleBits = ((uint)(0u));
			this.Graphics.Name = "Graphics";
			this.Graphics.Size = new System.Drawing.Size(604, 428);
			this.Graphics.StencilBits = ((uint)(0u));
			this.Graphics.TabIndex = 0;
			this.Graphics.GraphicsContextCreated += new System.EventHandler<OpenGL.GraphicsControlEventArgs>(this.Graphics_GraphicsContextCreated);
			this.Graphics.Render += new System.EventHandler<OpenGL.GraphicsControlEventArgs>(this.Graphics_Render);
			// 
			// SampleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 428);
			this.Controls.Add(this.Graphics);
			this.Name = "SampleForm";
			this.Text = "Hello triangle";
			this.ResumeLayout(false);

		}

		#endregion

		private OpenGL.GraphicsControl Graphics;
	}
}

