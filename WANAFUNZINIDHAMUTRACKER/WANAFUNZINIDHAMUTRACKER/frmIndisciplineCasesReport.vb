Public Class frmIndisciplineCasesReportVewer
    Private Sub frmIndisciplineCasesReportVewer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub frmIndisciplineCasesReportVewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub


End Class