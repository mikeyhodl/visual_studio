Public Class frmMajorOffencesReportViewerForm
    Private Sub frmMajorOffencesReportViewerForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.RvMajorOffencesReportViewer.RefreshReport()
    End Sub

    Private Sub frmMajorOffencesReportViewerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.RvMajorOffencesReportViewer.RefreshReport()
    End Sub
End Class