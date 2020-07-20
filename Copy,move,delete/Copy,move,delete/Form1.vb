Public Class Form1
    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click

        Dim FileToCopy As String
        Dim NewCopy As String
        FileToCopy = "F:\Mike.txt"
        NewCopy = "F:\MikeTest.txt"
        If System.IO.File.Exists(FileToCopy) = True Then
            System.IO.File.Copy(FileToCopy, NewCopy)
            MessageBox.Show("File Copied")
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim FileToDelete As String
        FileToDelete = "F:\Mike.txt"
        If System.IO.File.Exists(FileToDelete) = True Then
            System.IO.File.Delete(FileToDelete)
            MessageBox.Show("File Deleted")
        End If

    End Sub

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        Dim FileToMove As String
        Dim MoveLocation As String
        FileToMove = "F:\Mike.txt"
        MoveLocation = "F:\PHOTOS\Mike.txt"
        If System.IO.File.Exists(FileToMove) = True Then
            System.IO.File.Move(FileToMove, MoveLocation)
            MessageBox.Show("File Moved")
        End If

    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim FILE_NAME As String = "F:\Mike.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objReader As New System.IO.StreamReader(FILE_NAME)
            TextBox1.Text = objReader.ReadToEnd
            objReader.Close()
        Else
            MessageBox.Show("File Does Not Exist")
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnWritetoFile_Click(sender As Object, e As EventArgs) Handles btnWritetoFile.Click

        Dim FILE_NAME As String = "F:\Mike.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            objWriter.Write(TextBox1.Text)
            objWriter.Close()
            MessageBox.Show("Text written to file")
        Else
            MessageBox.Show("File Does Not Exist")
        End If

    End Sub
End Class
