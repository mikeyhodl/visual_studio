Imports System.ComponentModel

Public Class frmGenderDisciplineReportViewer
    Private Sub frmGenderDisciplineReportViewer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.rvGenderDiscipline.RefreshReport()
    End Sub

    Private Sub frmGenderDisciplineReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rvGenderDiscipline.RefreshReport()
    End Sub
End Class