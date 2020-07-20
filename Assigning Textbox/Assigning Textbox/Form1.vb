Public Class Form1
    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim FirstName As String
        Dim LastName As String
        Dim WholeName As String
        FirstName = txtFirstName.Text
        LastName = txtLastName.Text
        WholeName = FirstName & " " & LastName
        MessageBox.Show(WholeName)
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim FirstName As String
        Dim LastName As String
        Dim WholeName As String
        FirstName = txtFirstName.Text
        LastName = txtLastName.Text
        WholeName = FirstName & " " & LastName
        TextBox1.Text = WholeName


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub txtWholeName_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnShowSecond_Click(sender As Object, e As EventArgs) Handles btnShowSecond.Click
        Dim SecondForm As New frmSecond
        SecondForm.Show()

    End Sub
End Class
