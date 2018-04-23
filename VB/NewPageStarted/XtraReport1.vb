Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace NewPageStarted
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Private pageCount As Integer = -1
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
			If PrintingSystem.Document.PageCount <> pageCount Then
				lblNewPage.Visible = True
				pageCount = PrintingSystem.Document.PageCount
				lblNewPage.Text = "New page: " & (pageCount + 1)
			Else
				lblNewPage.Visible = False
			End If
		End Sub

	End Class
End Namespace
