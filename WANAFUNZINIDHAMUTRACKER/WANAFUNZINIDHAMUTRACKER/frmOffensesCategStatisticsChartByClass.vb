Imports System.ComponentModel

Public Class frmOffensesCategStatisticsChartByClass
    Private Sub frmOffensesCategStatisticsChartByClass_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.RvOffensesCategStatisticsChartByClass.RefreshReport()
    End Sub

    Private Sub frmOffensesCategStatisticsChartByClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.RvOffensesCategStatisticsChartByClass.RefreshReport()
    End Sub
End Class