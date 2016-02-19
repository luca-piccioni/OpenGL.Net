namespace HelloNewton
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.MenuTerrain = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuTerrainManage = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.MenuQuit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// SampleGraphicsControl
			// 
			this.SampleGraphicsControl.DepthBits = ((uint)(0u));
			this.SampleGraphicsControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SampleGraphicsControl.Location = new System.Drawing.Point(0, 24);
			this.SampleGraphicsControl.MultisampleBits = ((uint)(0u));
			this.SampleGraphicsControl.Name = "SampleGraphicsControl";
			this.SampleGraphicsControl.Size = new System.Drawing.Size(687, 553);
			this.SampleGraphicsControl.StencilBits = ((uint)(0u));
			this.SampleGraphicsControl.TabIndex = 0;
			this.SampleGraphicsControl.GraphicsContextCreated += new System.EventHandler<OpenGL.GraphicsControlEventArgs>(this.SampleGraphicsControl_GraphicsContextCreated);
			this.SampleGraphicsControl.Render += new System.EventHandler<OpenGL.GraphicsControlEventArgs>(this.SampleGraphicsControl_Render);
			this.SampleGraphicsControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SampleGraphicsControl_KeyDown);
			this.SampleGraphicsControl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SampleGraphicsControl_KeyUp);
			this.SampleGraphicsControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SampleGraphicsControl_MouseDown);
			this.SampleGraphicsControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SampleGraphicsControl_MouseMove);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTerrain});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(687, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// MenuTerrain
			// 
			this.MenuTerrain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTerrainManage,
            this.toolStripSeparator1,
            this.MenuQuit});
			this.MenuTerrain.Name = "MenuTerrain";
			this.MenuTerrain.Size = new System.Drawing.Size(56, 20);
			this.MenuTerrain.Text = "Terrain";
			// 
			// MenuTerrainManage
			// 
			this.MenuTerrainManage.Name = "MenuTerrainManage";
			this.MenuTerrainManage.Size = new System.Drawing.Size(152, 22);
			this.MenuTerrainManage.Text = "Manage...";
			this.MenuTerrainManage.Click += new System.EventHandler(this.MenuTerrainManage_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// MenuQuit
			// 
			this.MenuQuit.Name = "MenuQuit";
			this.MenuQuit.Size = new System.Drawing.Size(152, 22);
			this.MenuQuit.Text = "Quit";
			this.MenuQuit.Click += new System.EventHandler(this.MenuQuit_Click);
			// 
			// SampleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(687, 577);
			this.Controls.Add(this.SampleGraphicsControl);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "SampleForm";
			this.Text = "Hello World";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private OpenGL.GraphicsControl SampleGraphicsControl;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem MenuTerrain;
		private System.Windows.Forms.ToolStripMenuItem MenuTerrainManage;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem MenuQuit;
	}
}

