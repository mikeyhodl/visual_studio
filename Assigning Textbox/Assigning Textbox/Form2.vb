Public Class frmSecond
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Number1 As Integer
        Number1 = 10
        Call IncrementVariable(Number1)
        MessageBox.Show(Number1)

    End Sub
    Private Sub IncrementVariable(ByRef Number1 As Integer)
        Number1 = Number1 + 1
    End Sub

    Private Sub frmSecond_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class