Imports System.ComponentModel

Public Class frmClassOffensesCategStatisticsChartReportViewer
    Private Sub frmClassOffensesCategStatisticsChartReportViewer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.RvClassOffensesCategStatisticsChart.RefreshReport()
    End Sub

    Private Sub frmClassOffensesCategStatisticsChartReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.RvClassOffensesCategStatisticsChart.RefreshReport()
    End Sub
End Class