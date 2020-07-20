Imports System.ComponentModel

Public Class frmClassEnrolmentReportViewer
    Private Sub frmClassEnrolmentReportViewer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.rvClassEnrolmentReportViewer.RefreshReport()
    End Sub

    Private Sub frmClassEnrolmentReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rvClassEnrolmentReportViewer.RefreshReport()
    End Sub
End Class