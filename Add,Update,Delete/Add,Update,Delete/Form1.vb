Public Class Form1
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        ds.Tables("AddressBook").Rows(inc).Item(1) = txtFirstName.Text
        ds.Tables("AddressBook").Rows(inc).Item(2) = txtSurname.Text
        da.Update(ds, "AddressBook")
        MessageBox.Show("Data updated")

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        btnCommit.Enabled = True btnAddNew.Enabled = False
btnUpdate.Enabled = False
        btnDelete.Enabled = False
        txtFirstName.Clear()
        txtSurname.Clear()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
btnClear:
        btnCommit.Enabled = False
        btnAddNew.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        inc = 0
        NavigateRecords()

    End Sub

    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        If inc <> -1 Then
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim dsNewRow As DataRow
            dsNewRow = ds.Tables("AddressBook").NewRow()
            dsNewRow.Item("FirstName") = txtFirstName.Text
            dsNewRow.Item("Surname") = txtSurname.Text
            ds.Tables("AddressBook").Rows.Add(dsNewRow)
            da.Update(ds, "AddressBook")
            MessageBox.Show("New Record added to the Database")
            btnCommit.Enabled = False
            btnAddNew.Enabled = True
            btnUpdate.Enabled = True >
btnDelete.Enabled = True
        End If

    End Sub
End Class
