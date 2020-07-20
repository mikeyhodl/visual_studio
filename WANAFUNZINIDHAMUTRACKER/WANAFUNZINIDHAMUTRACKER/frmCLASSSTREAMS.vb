Imports System.Data.OleDb
Public Class frmCLASSSTREAMS

    ' This is the connection to the local MS Access database.
    ' The database is needed in both the Debug and Release folders.
    'At Public Class level, you only need one connection for all procedures in the form. You will only be opening and closing them whenever you want to fetch records from the database
    Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "DBSTUDENTSNIDHAMU.mdb")


    'Also define the datasets and dataadapters at public class level so that they can be accessed by other procedures
    Dim dstCLASSSTREAMS As New DataSet
    Dim dstSTREAMS As New DataSet

    Dim dtadptCLASSSTREAMS As OleDb.OleDbDataAdapter
    Dim dtadptSTREAMS As OleDb.OleDbDataAdapter

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub frmCLASSSTREAMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()


            'fetch data for the combobox 'CLASS'

            'clear the previous record before fetching new record and bind it to the combobox 'CLASS'
            dstCLASSSTREAMS.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptCLASSSTREAMS = New OleDb.OleDbDataAdapter("SELECT DISTINCT ID, CCLASS From tblCLASSSTREAM", conn)

            ' Use the data adapter to fill data in the dataset
            dtadptCLASSSTREAMS.Fill(dstCLASSSTREAMS, "tblCLASSSTREAM")




            'fetch data for the combobox 'STREAM'

            'clear the previous record before fetching new record and bind it to the combobox STREAM'
            dstSTREAMS.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptSTREAMS = New OleDb.OleDbDataAdapter("SELECT DISTINCT ID, CSTREAM From tblSTREAM", conn)

            ' Use the data adapter to fill data in the dataset
            dtadptSTREAMS.Fill(dstSTREAMS, "tblSTREAM")

            conn.Close()



            Dim cbCLASSSTREAMS As New OleDb.OleDbCommandBuilder(dtadptCLASSSTREAMS)


            'bind the datagridview to the dataset 'dstCLASSSTREAMS'
            DGVCLASSSTREAMS.DataSource = dstCLASSSTREAMS.Tables("tblCLASSSTREAM")

            'Hide the ID column
            DGVCLASSSTREAMS.Columns("ID").Visible = False

            DGVCLASSSTREAMS.Columns("CCLASS").HeaderText = "CLASSES"
            DGVCLASSSTREAMS.ColumnHeadersDefaultCellStyle.ForeColor = Color.Brown


            ' Dim cbSTREAMS As New OleDb.OleDbCommandBuilder(dtadptSTREAMS)


            'bind the datagridview to the dataset 'dstSTREAMS'
            DGVSTREAMS.DataSource = dstSTREAMS.Tables("tblSTREAM")

            'Hide the ID column
            DGVSTREAMS.Columns("ID").Visible = False
            DGVSTREAMS.Columns("CSTREAM").HeaderText = "STREAMS"
            DGVSTREAMS.ColumnHeadersDefaultCellStyle.ForeColor = Color.Brown


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try


            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()





            ' Dim cbCLASSSTREAMS As New OleDb.OleDbCommandBuilder(dtadptCLASSSTREAMS)

            '  If dstCLASSSTREAMS.HasChanges Then

            ' Dim TemporaryDataset As DataSet

            'TemporaryDataset = dstCLASSSTREAMS.GetChanges()

            'dtadptCLASSSTREAMS.Update(TemporaryDataset)


            ' End If




            Dim cbCLASSSTREAMS As New OleDb.OleDbCommandBuilder(dtadptCLASSSTREAMS)

            cbCLASSSTREAMS.ConflictOption = ConflictOption.OverwriteChanges


            dtadptCLASSSTREAMS.Update(dstCLASSSTREAMS, "tblCLASSSTREAM")



            MsgBox("Record(s) Successfully Saved!", MsgBoxStyle.OkOnly, "")


            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnSaveStreams_Click(sender As Object, e As EventArgs) Handles BtnSaveStreams.Click
        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()


            Dim cbSTREAMS As New OleDb.OleDbCommandBuilder(dtadptSTREAMS)

            cbSTREAMS.ConflictOption = ConflictOption.OverwriteChanges


            dtadptSTREAMS.Update(dstSTREAMS, "tblSTREAM")


            MsgBox("Record(s) Successfully Saved!", MsgBoxStyle.OkOnly, "")


            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnDeleteCurrentClass_Click(sender As Object, e As EventArgs) Handles BtnDeleteCurrentClass.Click

        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()


            'To delete a datagridview row use the Rows collection's Remove or RemoveAt method.
            'First check to see if the current row is new because you cannot delete a new row.
            'Then remove the current row.

            'Now check to see if the current row is not new and and proceed

            If Not DGVCLASSSTREAMS.CurrentRow.IsNewRow Then

                If MessageBox.Show("Are you sure you want to delete the Current Selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then

                    Exit Sub

                Else


                    DGVCLASSSTREAMS.Rows.Remove(DGVCLASSSTREAMS.CurrentRow)




                    Dim cbCLASSSTREAMS As New OleDb.OleDbCommandBuilder(dtadptCLASSSTREAMS)

                    cbCLASSSTREAMS.ConflictOption = ConflictOption.OverwriteChanges


                    dtadptCLASSSTREAMS.Update(dstCLASSSTREAMS, "tblCLASSSTREAM")


                    MessageBox.Show("Record deleted", "Deletion Confirmed")


                End If
            End If


            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnDeleteStream_Click(sender As Object, e As EventArgs) Handles BtnDeleteStream.Click
        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()


            'To delete a datagridview row use the Rows collection's Remove or RemoveAt method.
            'First check to see if the current row is new because you cannot delete a new row.
            'Then remove the current row.

            'Now check to see if the current row is not new and and proceed

            If Not DGVSTREAMS.CurrentRow.IsNewRow Then

                If MessageBox.Show("Are you sure you want to delete the Current Selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then

                    Exit Sub

                Else


                    DGVSTREAMS.Rows.Remove(DGVSTREAMS.CurrentRow)



                    Dim cbSTREAMS As New OleDb.OleDbCommandBuilder(dtadptSTREAMS)

                    cbSTREAMS.ConflictOption = ConflictOption.OverwriteChanges


                    dtadptSTREAMS.Update(dstSTREAMS, "tblSTREAM")



                    MessageBox.Show("Record deleted", "Deletion Confirmed")


                End If
            End If


            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub DGVCLASSSTREAMS_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DGVCLASSSTREAMS.DataError
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


    Private Sub DGVSTREAMS_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DGVSTREAMS.DataError
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