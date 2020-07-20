Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyText(4) As String
        Dim i As Integer
        MyText(0) = "This"
        MyText(1) = "is"
        MyText(2) = "a"
        MyText(3) = "String"
        MyText(4) = "Array"
        For i = 0 To 4
            ListBox1.Items.Add(MyText(i))
        Next i

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numbers() As Integer
        Dim startAt As Integer
        Dim endAt As Integer
        Dim times As Integer
        Dim StoreAnswer As Integer
        Dim i As Integer
        times = Val(TextBox1.Text)
        startAt = Val(TextBox2.Text)
        endAt = Val(TextBox3.Text)
        ReDim numbers(endAt)
        For i = startAt To endAt
            StoreAnswer = i * times
            numbers(i) = StoreAnswer
            ListBox2.Items.Add(times & " times " & i & " = " & numbers(i))
        Next i

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub
End Class
