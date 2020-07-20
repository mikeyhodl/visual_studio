Imports System.ComponentModel

Public Class frmIndisciplinePercentagesReportViewer
    Private Sub frmIndisciplinePercentagesReportViewer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.RvIndisciplinePercentagesReportViewer.RefreshReport()
    End Sub

    Private Sub frmIndisciplinePercentagesReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.RvIndisciplinePercentagesReportViewer.RefreshReport()
    End Sub

    Private Sub RvIndisciplinePercentagesReportViewer_Load(sender As Object, e As EventArgs) Handles RvIndisciplinePercentagesReportViewer.Load

    End Sub
End Class