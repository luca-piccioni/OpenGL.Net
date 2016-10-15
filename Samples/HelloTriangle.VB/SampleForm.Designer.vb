<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SampleForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.RenderControl = New OpenGL.GlControl()
		Me.SuspendLayout()
		'
		'RenderControl
		'
		Me.RenderControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.RenderControl.ColorBits = CType(24UI, UInteger)
		Me.RenderControl.DepthBits = CType(0UI, UInteger)
		Me.RenderControl.Dock = System.Windows.Forms.DockStyle.Fill
		Me.RenderControl.Location = New System.Drawing.Point(0, 0)
		Me.RenderControl.MultisampleBits = CType(0UI, UInteger)
		Me.RenderControl.Name = "RenderControl"
		Me.RenderControl.Size = New System.Drawing.Size(601, 486)
		Me.RenderControl.StencilBits = CType(0UI, UInteger)
		Me.RenderControl.TabIndex = 0
		'
		'SampleForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(601, 486)
		Me.Controls.Add(Me.RenderControl)
		Me.Name = "SampleForm"
		Me.Text = "Hello triangle"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents RenderControl As OpenGL.GlControl
End Class
