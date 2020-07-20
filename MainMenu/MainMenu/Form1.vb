Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim MyVariable As String
        MyVariable = ComboBox1.Text
        MessageBox.Show(MyVariable)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ChosenSitCom As String
        If RadioButton1.Checked = True Then
            ChosenSitCom = RadioButton1.Text
        ElseIf RadioButton2.Checked = True Then
            ChosenSitCom = RadioButton2.Text
        ElseIf RadioButton3.Checked = True Then
            ChosenSitCom = RadioButton3.Text
        ElseIf RadioButton4.Checked = True Then
            ChosenSitCom = RadioButton4.Text
        ElseIf RadioButton5.Checked = True Then
            ChosenSitCom = RadioButton5.Text
        End If
        MessageBox.Show("You voted for " & ChosenSitCom)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        Me.Close()

    End Sub

    Private Sub MnuUndo_Click(sender As Object, e As EventArgs) Handles mnuUndo.Click
        TextBox1.Undo()
    End Sub

    Private Sub MnuClose_Click(sender As Object, e As EventArgs) Handles MnuClose.Click
        Me.Close()

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim SecondForm As New FrmSecond
        SecondForm.Show()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        TextBox1.Copy()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        TextBox1.Cut()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TextBox2.Paste()
    End Sub
End Class
