Imports System.Data.OleDb
Public Class frmWelcome
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try

            frmLogin.Show()

            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Try

            frmRegisterLoginUsers.Show()

            ' Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class