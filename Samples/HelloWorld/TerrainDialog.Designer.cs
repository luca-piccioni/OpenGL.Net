namespace HelloNewton
{
	partial class TerrainDialog
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.TabUsgs = new System.Windows.Forms.TabPage();
			this.NumLat = new System.Windows.Forms.NumericUpDown();
			this.NumLon = new System.Windows.Forms.NumericUpDown();
			this.LblPosition = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.NumSizeY = new System.Windows.Forms.NumericUpDown();
			this.NumSizeX = new System.Windows.Forms.NumericUpDown();
			this.BtnUsgsDownload = new System.Windows.Forms.Button();
			this.ProgUsgsDownload = new System.Windows.Forms.ProgressBar();
			this.TxtUsgsLog = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.TabUsgs.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumLat)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumLon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumSizeY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumSizeX)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.TabUsgs);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(443, 366);
			this.tabControl1.TabIndex = 0;
			// 
			// TabUsgs
			// 
			this.TabUsgs.Controls.Add(this.TxtUsgsLog);
			this.TabUsgs.Controls.Add(this.ProgUsgsDownload);
			this.TabUsgs.Controls.Add(this.BtnUsgsDownload);
			this.TabUsgs.Controls.Add(this.label1);
			this.TabUsgs.Controls.Add(this.NumSizeY);
			this.TabUsgs.Controls.Add(this.NumSizeX);
			this.TabUsgs.Controls.Add(this.LblPosition);
			this.TabUsgs.Controls.Add(this.NumLon);
			this.TabUsgs.Controls.Add(this.NumLat);
			this.TabUsgs.Location = new System.Drawing.Point(4, 22);
			this.TabUsgs.Name = "TabUsgs";
			this.TabUsgs.Padding = new System.Windows.Forms.Padding(3);
			this.TabUsgs.Size = new System.Drawing.Size(435, 340);
			this.TabUsgs.TabIndex = 0;
			this.TabUsgs.Text = "USGS";
			this.TabUsgs.UseVisualStyleBackColor = true;
			// 
			// NumLat
			// 
			this.NumLat.Location = new System.Drawing.Point(61, 6);
			this.NumLat.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
			this.NumLat.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
			this.NumLat.Name = "NumLat";
			this.NumLat.Size = new System.Drawing.Size(54, 20);
			this.NumLat.TabIndex = 0;
			this.NumLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumLat.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
			// 
			// NumLon
			// 
			this.NumLon.Location = new System.Drawing.Point(121, 6);
			this.NumLon.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
			this.NumLon.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
			this.NumLon.Name = "NumLon";
			this.NumLon.Size = new System.Drawing.Size(54, 20);
			this.NumLon.TabIndex = 1;
			this.NumLon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumLon.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// LblPosition
			// 
			this.LblPosition.AutoSize = true;
			this.LblPosition.Location = new System.Drawing.Point(8, 8);
			this.LblPosition.Name = "LblPosition";
			this.LblPosition.Size = new System.Drawing.Size(47, 13);
			this.LblPosition.TabIndex = 2;
			this.LblPosition.Text = "Position:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Size:";
			// 
			// NumSizeY
			// 
			this.NumSizeY.Location = new System.Drawing.Point(121, 32);
			this.NumSizeY.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.NumSizeY.Name = "NumSizeY";
			this.NumSizeY.Size = new System.Drawing.Size(54, 20);
			this.NumSizeY.TabIndex = 4;
			this.NumSizeY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumSizeY.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			// 
			// NumSizeX
			// 
			this.NumSizeX.Location = new System.Drawing.Point(61, 32);
			this.NumSizeX.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
			this.NumSizeX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.NumSizeX.Name = "NumSizeX";
			this.NumSizeX.Size = new System.Drawing.Size(54, 20);
			this.NumSizeX.TabIndex = 3;
			this.NumSizeX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumSizeX.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			// 
			// BtnUsgsDownload
			// 
			this.BtnUsgsDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnUsgsDownload.Location = new System.Drawing.Point(353, 29);
			this.BtnUsgsDownload.Name = "BtnUsgsDownload";
			this.BtnUsgsDownload.Size = new System.Drawing.Size(74, 23);
			this.BtnUsgsDownload.TabIndex = 6;
			this.BtnUsgsDownload.Text = "Download";
			this.BtnUsgsDownload.UseVisualStyleBackColor = true;
			this.BtnUsgsDownload.Click += new System.EventHandler(this.BtnUsgsDownload_Click);
			// 
			// ProgUsgsDownload
			// 
			this.ProgUsgsDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ProgUsgsDownload.Location = new System.Drawing.Point(181, 29);
			this.ProgUsgsDownload.Name = "ProgUsgsDownload";
			this.ProgUsgsDownload.Size = new System.Drawing.Size(166, 23);
			this.ProgUsgsDownload.TabIndex = 7;
			// 
			// TxtUsgsLog
			// 
			this.TxtUsgsLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtUsgsLog.Location = new System.Drawing.Point(3, 58);
			this.TxtUsgsLog.Multiline = true;
			this.TxtUsgsLog.Name = "TxtUsgsLog";
			this.TxtUsgsLog.Size = new System.Drawing.Size(424, 274);
			this.TxtUsgsLog.TabIndex = 8;
			// 
			// TerrainDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(443, 366);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TerrainDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Manager terrain data...";
			this.tabControl1.ResumeLayout(false);
			this.TabUsgs.ResumeLayout(false);
			this.TabUsgs.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NumLat)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumLon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumSizeY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumSizeX)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage TabUsgs;
		private System.Windows.Forms.Button BtnUsgsDownload;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown NumSizeY;
		private System.Windows.Forms.NumericUpDown NumSizeX;
		private System.Windows.Forms.Label LblPosition;
		private System.Windows.Forms.NumericUpDown NumLon;
		private System.Windows.Forms.NumericUpDown NumLat;
		private System.Windows.Forms.TextBox TxtUsgsLog;
		private System.Windows.Forms.ProgressBar ProgUsgsDownload;
	}
}