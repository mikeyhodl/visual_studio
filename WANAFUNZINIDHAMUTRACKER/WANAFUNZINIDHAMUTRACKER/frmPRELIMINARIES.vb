Public Class frmPRELIMINARIES
    Private Sub BtnEnterOffensesCategories_Click(sender As Object, e As EventArgs) Handles BtnEnterOffensesCategories.Click
        Try

            frmOFFENSESCATEGORIES.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnEnterOffensesTypes_Click(sender As Object, e As EventArgs) Handles BtnEnterOffensesTypes.Click
        Try

            frmOFFENSETYPE.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnEnterClassesStreams_Click(sender As Object, e As EventArgs) Handles BtnEnterClassesStreams.Click
        Try

            frmCLASSSTREAMS.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnRegisterStudents_Click(sender As Object, e As EventArgs) Handles BtnRegisterStudents.Click
        Try

            frmDataEntryNIDHAMU.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnEnterDormitories_Click(sender As Object, e As EventArgs) Handles BtnEnterDormitories.Click
        Try

            frmDormitory.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class