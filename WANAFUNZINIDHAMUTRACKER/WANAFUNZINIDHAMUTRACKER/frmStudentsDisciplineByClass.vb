Public Class frmStudentsDisciplineByClassReportViewer
    Private Sub frmStudentsDisciplineByClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.RvStudentsDisciplineByClass.RefreshReport()
    End Sub

    Private Sub frmStudentsDisciplineByClassReportViewer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.RvStudentsDisciplineByClass.RefreshReport()
    End Sub
End Class