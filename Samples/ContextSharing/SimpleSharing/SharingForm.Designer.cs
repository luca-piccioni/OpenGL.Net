namespace SimpleSharing
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.GlControl1 = new OpenGL.GlControl();
			this.GlControl2 = new OpenGL.GlControl();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.GlControl1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.GlControl2);
			this.splitContainer1.Size = new System.Drawing.Size(933, 603);
			this.splitContainer1.SplitterDistance = 452;
			this.splitContainer1.TabIndex = 0;
			// 
			// GlControl1
			// 
			this.GlControl1.Animation = true;
			this.GlControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.GlControl1.ColorBits = ((uint)(24u));
			this.GlControl1.ContextSharingGroup = "TestGroup";
			this.GlControl1.DepthBits = ((uint)(0u));
			this.GlControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GlControl1.Location = new System.Drawing.Point(0, 0);
			this.GlControl1.MultisampleBits = ((uint)(0u));
			this.GlControl1.Name = "GlControl1";
			this.GlControl1.Size = new System.Drawing.Size(452, 603);
			this.GlControl1.StencilBits = ((uint)(0u));
			this.GlControl1.TabIndex = 0;
			this.GlControl1.ContextCreated += new System.EventHandler<OpenGL.GlControlEventArgs>(this.GlControl1_ContextCreated);
			this.GlControl1.Render += new System.EventHandler<OpenGL.GlControlEventArgs>(this.GlControl_Render);
			// 
			// GlControl2
			// 
			this.GlControl2.Animation = true;
			this.GlControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.GlControl2.ColorBits = ((uint)(24u));
			this.GlControl2.ContextSharingGroup = "TestGroup";
			this.GlControl2.DepthBits = ((uint)(0u));
			this.GlControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GlControl2.Location = new System.Drawing.Point(0, 0);
			this.GlControl2.MultisampleBits = ((uint)(0u));
			this.GlControl2.Name = "GlControl2";
			this.GlControl2.Size = new System.Drawing.Size(477, 603);
			this.GlControl2.StencilBits = ((uint)(0u));
			this.GlControl2.TabIndex = 0;
			this.GlControl2.ContextCreated += new System.EventHandler<OpenGL.GlControlEventArgs>(this.GlControl2_ContextCreated);
			this.GlControl2.Render += new System.EventHandler<OpenGL.GlControlEventArgs>(this.GlControl_Render);
			// 
			// SharingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(933, 603);
			this.Controls.Add(this.splitContainer1);
			this.Name = "SharingForm";
			this.Text = "Form1";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private OpenGL.GlControl GlControl1;
		private OpenGL.GlControl GlControl2;
	}
}

