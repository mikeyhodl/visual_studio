Imports System.ComponentModel

Public Class frmOffenceNarrationsReportViewer
    Private Sub frmOffenceNarrationsReportViewer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.RvOffenceNarrationsReportViewer.RefreshReport()
    End Sub

    Private Sub frmOffenceNarrationsReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.RvOffenceNarrationsReportViewer.RefreshReport()
    End Sub
End Class