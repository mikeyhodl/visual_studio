Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add(“Visual Studio 2018”)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim myitem
        myitem = InputBox(“Enter your Item”)
        ListBox1.Items.Add(myitem)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim myitem
        myitem = InputBox(“Enter your Item for Deletion”)
        ListBox1.Items.Remove(myitem)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub BtnAddc_Click_1(sender As Object, e As EventArgs) Handles BtnAddc.Click
        Dim myitem
        myitem = InputBox(“Enter your Item”)
        ComboBox1.Items.Add(myitem)
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ComboBox1.Items.Clear()
    End Sub
End Class
