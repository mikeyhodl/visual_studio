Public Class Form1
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        ds.Tables("AddressBook").Rows(inc).Item(1) = txtFirstName.Text
        ds.Tables("AddressBook").Rows(inc).Item(2) = txtSurname.Text
        da.Update(ds, "AddressBook")
        MessageBox.Show("Data updated")


    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click

    End Sub

    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub
End Class
