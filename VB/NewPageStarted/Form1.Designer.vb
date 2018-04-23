Imports Microsoft.VisualBasic
Imports System
Namespace NewPageStarted
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.btnPreview = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' btnPreview
			' 
			Me.btnPreview.Location = New System.Drawing.Point(53, 13)
			Me.btnPreview.Name = "btnPreview"
			Me.btnPreview.Size = New System.Drawing.Size(173, 33)
			Me.btnPreview.TabIndex = 0
			Me.btnPreview.Text = "Show preview"
			Me.btnPreview.UseVisualStyleBackColor = True
'			Me.btnPreview.Click += New System.EventHandler(Me.btnPreview_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 58)
			Me.Controls.Add(Me.btnPreview)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents btnPreview As System.Windows.Forms.Button
	End Class
End Namespace

