Public Class frmComparisonMajorMinorOffences
    Private Sub frmComparisonMajorMinorOffences_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.rvComparisonMajorMinorOffences.RefreshReport()
    End Sub

    Private Sub frmComparisonMajorMinorOffences_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rvComparisonMajorMinorOffences.RefreshReport()
    End Sub
End Class