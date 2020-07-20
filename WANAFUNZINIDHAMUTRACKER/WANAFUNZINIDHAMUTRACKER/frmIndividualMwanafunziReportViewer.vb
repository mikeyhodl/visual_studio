Public Class frmIndividualMwanafunziReportViewer
    Private Sub frmIndividualMwanafunziReportViewer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.RvIndividualMwanafunziReportViewer.RefreshReport()
    End Sub

    Private Sub frmIndividualMwanafunziReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.RvIndividualMwanafunziReportViewer.RefreshReport()
    End Sub
End Class