namespace HelloVX
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
			this.glControl1 = new OpenGL.GlControl();
			this.SuspendLayout();
			// 
			// glControl1
			// 
			this.glControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.glControl1.ColorBits = ((uint)(24u));
			this.glControl1.DepthBits = ((uint)(0u));
			this.glControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.glControl1.Location = new System.Drawing.Point(0, 0);
			this.glControl1.MultisampleBits = ((uint)(0u));
			this.glControl1.Name = "glControl1";
			this.glControl1.Size = new System.Drawing.Size(532, 415);
			this.glControl1.StencilBits = ((uint)(0u));
			this.glControl1.TabIndex = 0;
			// 
			// SampleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(532, 415);
			this.Controls.Add(this.glControl1);
			this.Name = "SampleForm";
			this.Text = "OpenVX Sample";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SampleForm_FormClosing);
			this.Load += new System.EventHandler(this.SampleForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private OpenGL.GlControl glControl1;
	}
}

