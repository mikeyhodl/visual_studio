Public Class frmOffensesCategStatisticsChartReportViewer
    Private Sub frmOffensesCategStatisticsChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.RvOffensesCategStatisticsChartReportViewer.RefreshReport()
    End Sub

    Private Sub frmOffensesCategStatisticsChartReportViewer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.RvOffensesCategStatisticsChartReportViewer.RefreshReport()
    End Sub

    Private Sub RvOffensesCategStatisticsChartReportViewer_Load(sender As Object, e As EventArgs) Handles RvOffensesCategStatisticsChartReportViewer.Load

    End Sub
End Class