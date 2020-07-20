Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim FILE_NAME As String = "F:\Mike.txt"
        Dim i As Integer
        Dim aryText(4) As String
        aryText(0) = "Hello mike"
        aryText(1) = "Hope you are fine"
        aryText(2) = "Pass my greetings"
        aryText(3) = "To"
        aryText(4) = "Everyone LOL"
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME, False)
        For i = 0 To 4
            objWriter.WriteLine(aryText(i))
        Next
        objWriter.Close()
        MessageBox.Show("Text Appended to the File")

    End Sub
End Class
