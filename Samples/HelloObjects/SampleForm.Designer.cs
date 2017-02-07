namespace HelloObjects
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
			this.components = new System.ComponentModel.Container();
			this.ObjectsControl = new OpenGL.GlControl();
			this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// ObjectsControl
			// 
			this.ObjectsControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ObjectsControl.ColorBits = ((uint)(24u));
			this.ObjectsControl.DepthBits = ((uint)(24u));
			this.ObjectsControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ObjectsControl.Location = new System.Drawing.Point(0, 0);
			this.ObjectsControl.MultisampleBits = ((uint)(8u));
			this.ObjectsControl.Name = "ObjectsControl";
			this.ObjectsControl.Size = new System.Drawing.Size(568, 406);
			this.ObjectsControl.StencilBits = ((uint)(0u));
			this.ObjectsControl.TabIndex = 0;
			this.ObjectsControl.ContextCreated += new System.EventHandler<OpenGL.GlControlEventArgs>(this.ObjectsControl_ContextCreated);
			this.ObjectsControl.ContextDestroying += new System.EventHandler<OpenGL.GlControlEventArgs>(this.ObjectsControl_ContextDestroying);
			this.ObjectsControl.Render += new System.EventHandler<OpenGL.GlControlEventArgs>(this.ObjectsControl_Render);
			this.ObjectsControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ObjectsControl_KeyDown);
			this.ObjectsControl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ObjectsControl_KeyUp);
			this.ObjectsControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ObjectsControl_MouseDown);
			this.ObjectsControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ObjectsControl_MouseMove);
			this.ObjectsControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ObjectsControl_MouseUp);
			// 
			// AnimationTimer
			// 
			this.AnimationTimer.Interval = 10;
			this.AnimationTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
			// 
			// SampleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(568, 406);
			this.Controls.Add(this.ObjectsControl);
			this.Name = "SampleForm";
			this.Text = "OpenGL.Objects Sample";
			this.Load += new System.EventHandler(this.SampleForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private OpenGL.GlControl ObjectsControl;
		private System.Windows.Forms.Timer AnimationTimer;
	}
}

