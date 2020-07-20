Public Class frmStudentDisciplineByDormitoryReportViewer
    Private Sub frmStudentDisciplineByDormitoryReportViewer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.RvStudentDisciplineByDormitory.RefreshReport()
    End Sub

    Private Sub frmStudentDisciplineByDormitoryReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.RvStudentDisciplineByDormitory.RefreshReport()
    End Sub
End Class