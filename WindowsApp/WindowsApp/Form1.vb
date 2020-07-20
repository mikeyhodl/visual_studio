Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Try

            txtAnswer.Text = Val(txtLength.Text) + Val(txtWidth.Text)


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
End Class
