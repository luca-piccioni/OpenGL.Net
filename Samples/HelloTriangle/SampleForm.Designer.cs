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
			this.RenderControl = new OpenGL.GlControl();
			this.SuspendLayout();
			// 
			// RenderControl
			// 
			this.RenderControl.BackColor = System.Drawing.Color.DimGray;
			this.RenderControl.ColorBits = ((uint)(24u));
			this.RenderControl.DepthBits = ((uint)(0u));
			this.RenderControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RenderControl.Location = new System.Drawing.Point(0, 0);
			this.RenderControl.MultisampleBits = ((uint)(0u));
			this.RenderControl.Name = "RenderControl";
			this.RenderControl.Size = new System.Drawing.Size(604, 428);
			this.RenderControl.StencilBits = ((uint)(0u));
			this.RenderControl.TabIndex = 0;
			this.RenderControl.Render += new System.EventHandler<OpenGL.GlControlEventArgs>(this.RenderControl_Render);
			// 
			// SampleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 428);
			this.Controls.Add(this.RenderControl);
			this.Name = "SampleForm";
			this.Text = "Hello triangle";
			this.ResumeLayout(false);

		}

		#endregion

		private OpenGL.GlControl RenderControl;
	}
}

