Imports System.Data.OleDb

Public Class frmDormitory
    ' This is the connection to the local MS Access database.
    ' The database is needed in both the Debug and Release folders.
    'At Public Class level, you only need one connection for all procedures in the form. You will only be opening and closing them whenever you want to fetch records from the database
    Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "DBSTUDENTSNIDHAMU.mdb")


    'Also define the datasets and dataadapters at public class level so that they can be accessed by other procedures
    Dim dstDormitories As New DataSet

    Dim dtadptDormitories As OleDb.OleDbDataAdapter
    Private Sub frmDormitory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()


            'fetch data for the combobox 'ADMNO'

            'clear the previous record before fetching new record and bind it to the combobox 'ComboADNO'
            dstDormitories.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptDormitories = New OleDb.OleDbDataAdapter("SELECT DISTINCT ID, SNO, DORMITORY From tblDORMITORY", conn)

            ' Use the data adapter to fill data in the dataset
            dtadptDormitories.Fill(dstDormitories, "tblDORMITORY")


            conn.Close()


            Dim cbDormitories As New OleDb.OleDbCommandBuilder(dtadptDormitories)


            'bind the datagridview to the dataset 'dst2'
            dgvDORMITORY.DataSource = dstDormitories.Tables("tblDORMITORY")


            'Hide the ID, SNO columns
            dgvDORMITORY.Columns("ID").Visible = False

            dgvDORMITORY.Columns("SNO").Visible = False


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

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try


            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()




            'For single user updating, just use the command builder to overwrite the changes. This approach is called 'Last in Win"

            Dim cbDormitories As New OleDb.OleDbCommandBuilder(dtadptDormitories)
            cbDormitories.ConflictOption = ConflictOption.OverwriteChanges


            dtadptDormitories.Update(dstDormitories, "tblDORMITORY")


            MsgBox("Record(s) Successfully Saved!", MsgBoxStyle.OkOnly, "")

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvDORMITORY_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvDORMITORY.CellBeginEdit
        'Numbering items on a datagridview 'SNO'

        Dim CurrentRow As Integer = e.RowIndex
        dgvDORMITORY.Rows(CurrentRow).Cells("SNO").Value = CurrentRow + 1

    End Sub

    Private Sub BtnDeleteCurrentRecord_Click(sender As Object, e As EventArgs) Handles BtnDeleteCurrentRecord.Click

        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()


            'To delete a datagridview row use the Rows collection's Remove or RemoveAt method.
            'First check to see if the current row is new because you cannot delete a new row.
            'Then remove the current row.

            'Now check to see if the current row is not new and and proceed

            If Not dgvDORMITORY.CurrentRow.IsNewRow Then

                If MessageBox.Show("Are you sure you want to delete the Current Selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then

                    Exit Sub

                Else


                    dgvDORMITORY.Rows.Remove(dgvDORMITORY.CurrentRow)




                    Dim cbDormitories As New OleDb.OleDbCommandBuilder(dtadptDormitories)
                    cbDormitories.ConflictOption = ConflictOption.OverwriteChanges


                    dtadptDormitories.Update(dstDormitories, "tblDORMITORY")


                    MessageBox.Show("Record deleted", "Deletion Confirmed")


                End If
            End If


            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub dgvDORMITORY_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvDORMITORY.DataError
        Try

            'MessageBox.Show("Error:  " & e.Context.ToString())

            If (e.Context = DataGridViewDataErrorContexts.Commit) _
            Then
                MessageBox.Show("Commit error")
            End If
            If (e.Context = DataGridViewDataErrorContexts.CurrentCellChange) Then
                MessageBox.Show("Cell change")
            End If
            If (e.Context = DataGridViewDataErrorContexts.Parsing) Then
                MessageBox.Show("parsing error")
            End If
            If (e.Context = DataGridViewDataErrorContexts.LeaveControl) Then
                MessageBox.Show("leave control error")
            End If

            If (TypeOf (e.Exception) Is ConstraintException) Then
                Dim view As DataGridView = CType(sender, DataGridView)
                view.Rows(e.RowIndex).ErrorText = "an error"
                view.Rows(e.RowIndex).Cells(e.ColumnIndex) _
                .ErrorText = "an error"
                MsgBox("error")
                e.ThrowException = False
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class