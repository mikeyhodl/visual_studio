Imports System.ComponentModel

Public Class frmClassListsReportviewer
    Private Sub frmClassListsReportviewer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.rvClassListsReportViewer.RefreshReport()
    End Sub

    Private Sub frmClassListsReportviewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rvClassListsReportViewer.RefreshReport()
    End Sub
End Class