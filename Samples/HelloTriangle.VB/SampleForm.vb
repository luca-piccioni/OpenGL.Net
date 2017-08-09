
' Copyright (C) 2016-2017 Luca Piccioni
' 
' Permission Is hereby granted, free of charge, to any person obtaining a copy
' of this software And associated documentation files (the "Software"), to deal
' in the Software without restriction, including without limitation the rights
' to use, copy, modify, merge, publish, distribute, sublicense, And/Or sell
' copies of the Software, And to permit persons to whom the Software Is
' furnished to do so, subject to the following conditions:
' 
' The above copyright notice And this permission notice shall be included in all
' copies Or substantial portions of the Software.
' 
' THE SOFTWARE Is PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS Or
' IMPLIED, INCLUDING BUT Not LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
' FITNESS FOR A PARTICULAR PURPOSE And NONINFRINGEMENT. IN NO EVENT SHALL THE
' AUTHORS Or COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES Or OTHER
' LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT Or OTHERWISE, ARISING FROM,
' OUT OF Or IN CONNECTION WITH THE SOFTWARE Or THE USE Or OTHER DEALINGS IN THE
' SOFTWARE.

Imports OpenGL

Public Class SampleForm

	Private Sub RenderControl_ContextCreated(sender As Object, e As OpenGL.GlControlEventArgs) Handles RenderControl.ContextCreated

		' Here you can allocate resources Or initialize state
		Gl.MatrixMode(MatrixMode.Projection)
		Gl.LoadIdentity()
		Gl.Ortho(0.0, 1.0F, 0.0, 1.0, 0.0, 1.0)

		Gl.MatrixMode(MatrixMode.Modelview)
		Gl.LoadIdentity()

	End Sub

	Private Sub RenderControl_Render(sender As Object, e As GlControlEventArgs) Handles RenderControl.Render

		Dim senderControl As Control = CType(sender, Control)

		' Note: conflicting commands are scoped in Gl.VB class
		Gl.VB.Viewport(0, 0, senderControl.ClientSize.Width, senderControl.ClientSize.Height)
		Gl.VB.Clear(ClearBufferMask.ColorBufferBit)

		' Note: conflicting enumerants are scoped in Gl.VBEnum class
		Dim currentViewport As Integer() = New Integer(3) {0, 0, 0, 0}
		Gl.Get(Gl.VBEnum.VIEWPORT, currentViewport)

		If (Gl.CurrentVersion >= Gl.Version_110) Then
			' Old school OpenGL 1.1
			' Setup & enable client states to specify vertex arrays, And use Gl.DrawArrays instead of Gl.Begin/End paradigm
			Using vertexArrayLock As New MemoryLock(_ArrayPosition)
				Using vertexColorLock As New MemoryLock(_ArrayColor)
					' Note: the use of MemoryLock objects Is necessary to pin vertex arrays since they can be reallocated by GC
					' at any time between the Gl.VertexPointer execution And the Gl.DrawArrays execution

					Gl.VertexPointer(2, VertexPointerType.Float, 0, vertexArrayLock.Address)
					Gl.EnableClientState(EnableCap.VertexArray)

					Gl.ColorPointer(3, ColorPointerType.Float, 0, vertexColorLock.Address)
					Gl.EnableClientState(EnableCap.ColorArray)

					Gl.DrawArrays(PrimitiveType.Triangles, 0, 3)
				End Using
			End Using
		Else
			' Old school OpenGL
			Gl.Begin(PrimitiveType.Triangles)
			Gl.Color3(1.0F, 0.0F, 0.0F)
			Gl.Vertex2(0.0F, 0.0F)
			Gl.Color3(0.0F, 1.0F, 0.0F)
			Gl.Vertex2(0.5F, 1.0F)
			Gl.Color3(0.0F, 0.0F, 1.0F)
			Gl.Vertex2(1.0F, 0.0F)
			Gl.End()
		End If

	End Sub

	Private Sub RenderControl_ContextDestroying(sender As Object, e As OpenGL.GlControlEventArgs) Handles RenderControl.ContextDestroying
		' Here you can dispose resources allocated in RenderControl_ContextCreated
	End Sub

	''' <summary>
	''' Vertex position array.
	''' </summary>
	Private ReadOnly _ArrayPosition As Single() = {
		0.0F, 0.0F,
		0.5F, 1.0F,
		1.0F, 0.0F
	}

	''' <summary>
	''' Vertex color array.
	''' </summary>
	Private ReadOnly _ArrayColor As Single() = {
		1.0F, 0.0F, 0.0F,
		0.0F, 1.0F, 0.0F,
		0.0F, 0.0F, 1.0F
	}
End Class
