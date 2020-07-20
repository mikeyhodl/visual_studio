Public Class Form1
    Private Sub LblAns_Click(sender As Object, e As EventArgs) Handles LblAns.Click

    End Sub

    Private Sub BtnCal_Click(sender As Object, e As EventArgs) Handles BtnCal.Click
        Dim num1 As Single = Val(txtNum1.Text)
        Dim num2 As Single = Val(txtNum2.Text)
        Dim Sum As Single = num1 + num2
        LblAns.Text = Sum.ToString

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
