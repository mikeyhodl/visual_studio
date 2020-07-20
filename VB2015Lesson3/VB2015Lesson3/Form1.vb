Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnView.Click

        If OFGSelectImage.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OFGSelectImage.FileName)
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = Image.FromFile(“F:\PHOTOS\2018\1514541994018.jpg”)
    End Sub
End Class
