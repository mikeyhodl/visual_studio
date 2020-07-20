Imports System.ComponentModel

Public Class frmDormitoryOffensesCategStatisticsChartReportViewer
    Private Sub frmDormitoryOffensesCategStatisticsChartReportViewer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.RvDormitoryOffensesCategStatisticsChart.RefreshReport()
    End Sub

    Private Sub frmDormitoryOffensesCategStatisticsChartReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.RvDormitoryOffensesCategStatisticsChart.RefreshReport()
    End Sub
End Class