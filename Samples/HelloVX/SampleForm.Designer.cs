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
			this.VisionControl = new OpenGL.GlControl();
			this.SuspendLayout();
			// 
			// VisionControl
			// 
			this.VisionControl.Animation = true;
			this.VisionControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.VisionControl.ColorBits = ((uint)(24u));
			this.VisionControl.DepthBits = ((uint)(0u));
			this.VisionControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VisionControl.Location = new System.Drawing.Point(0, 0);
			this.VisionControl.MultisampleBits = ((uint)(0u));
			this.VisionControl.Name = "VisionControl";
			this.VisionControl.Size = new System.Drawing.Size(532, 415);
			this.VisionControl.StencilBits = ((uint)(0u));
			this.VisionControl.TabIndex = 0;
			this.VisionControl.ContextCreated += new System.EventHandler<OpenGL.GlControlEventArgs>(this.VisionControl_ContextCreated);
			this.VisionControl.Render += new System.EventHandler<OpenGL.GlControlEventArgs>(this.VisionControl_Render);
			this.VisionControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VisionControl_KeyPress);
			// 
			// SampleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(532, 415);
			this.Controls.Add(this.VisionControl);
			this.Name = "SampleForm";
			this.Text = "OpenVX Sample";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SampleForm_FormClosing);
			this.Load += new System.EventHandler(this.SampleForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private OpenGL.GlControl VisionControl;
	}
}

