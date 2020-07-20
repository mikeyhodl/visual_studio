Imports System.ComponentModel

Public Class frmGenderIndisciplinePercentagesReportViewer
    Private Sub frmGenderIndisciplinePercentagesReportViewer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.RvGenderIndisciplinePercentagesReportViewer.RefreshReport()
    End Sub

    Private Sub frmGenderIndisciplinePercentagesReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.RvGenderIndisciplinePercentagesReportViewer.RefreshReport()
    End Sub
End Class