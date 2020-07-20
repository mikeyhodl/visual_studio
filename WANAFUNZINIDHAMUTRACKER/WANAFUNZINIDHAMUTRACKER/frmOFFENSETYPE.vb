Imports System.Data.OleDb
Public Class frmOFFENSETYPE

    ' This is the connection to the local MS Access database.
    ' The database is needed in both the Debug and Release folders.
    'At Public Class level, you only need one connection for all procedures in the form. You will only be opening and closing them whenever you want to fetch records from the database
    Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "DBSTUDENTSNIDHAMU.mdb")


    'Also define the datasets and dataadapters at public class level so that they can be accessed by other procedures
    Dim dstOffensesTYPES As New DataSet

    Dim dtadptOffensesTYPES As OleDb.OleDbDataAdapter
    Private Sub frmOFFENSETYPE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()


            'fetch data for the combobox 'ADMNO'

            'clear the previous record before fetching new record and bind it to the combobox 'ComboADNO'
            dstOffensesTYPES.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptOffensesTYPES = New OleDb.OleDbDataAdapter("SELECT DISTINCT ID, OFFENSETYPE From tblOFFENSESTYPES", conn)

            ' Use the data adapter to fill data in the dataset
            dtadptOffensesTYPES.Fill(dstOffensesTYPES, "tblOFFENSESTYPES")


            conn.Close()


            ' Dim cbOffensesTYPES As New OleDb.OleDbCommandBuilder(dtadptOffensesTYPES)


            'bind the datagridview to the dataset 'dst2'
            DGVOFFENSETYPES.DataSource = dstOffensesTYPES.Tables("tblOFFENSESTYPES")


            'Make the first row of the datagridview automatically have the word 'NONE'

            DGVOFFENSETYPES.Rows(0).Cells("OFFENSETYPE").Value = "NONE"


            'Hide the ID column
            DGVOFFENSETYPES.Columns("ID").Visible = False

            'Set column heading
            DGVOFFENSETYPES.Columns("OFFENSETYPE").HeaderText = "OFFENCE TYPE"



            Dim cbOffensesTYPES As New OleDb.OleDbCommandBuilder(dtadptOffensesTYPES)

            cbOffensesTYPES.ConflictOption = ConflictOption.OverwriteChanges


            dtadptOffensesTYPES.Update(dstOffensesTYPES, "tblOFFENSESTYPES")




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()


            Dim cbOffensesTYPES As New OleDb.OleDbCommandBuilder(dtadptOffensesTYPES)

            cbOffensesTYPES.ConflictOption = ConflictOption.OverwriteChanges


            dtadptOffensesTYPES.Update(dstOffensesTYPES, "tblOFFENSESTYPES")



            MsgBox("Record(s) Successfully Saved!", MsgBoxStyle.OkOnly, "")


            conn.Close()


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

    Private Sub BtnDeleteCurrentRecord_Click(sender As Object, e As EventArgs) Handles BtnDeleteCurrentRecord.Click
        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()


            'To delete a datagridview row use the Rows collection's Remove or RemoveAt method.
            'First check to see if the current row is new because you cannot delete a new row.
            'Then remove the current row.

            'Now check to see if the current row is not new and and proceed

            If Not DGVOFFENSETYPES.CurrentRow.IsNewRow Then

                If MessageBox.Show("Are you sure you want to delete the Current Selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then

                    Exit Sub

                Else


                    DGVOFFENSETYPES.Rows.Remove(DGVOFFENSETYPES.CurrentRow)




                    Dim cbOffensesTYPES As New OleDb.OleDbCommandBuilder(dtadptOffensesTYPES)

                    cbOffensesTYPES.ConflictOption = ConflictOption.OverwriteChanges


                    dtadptOffensesTYPES.Update(dstOffensesTYPES, "tblOFFENSESTYPES")


                    MessageBox.Show("Record deleted", "Deletion Confirmed")


                End If
            End If


            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmOFFENSETYPE_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()



            DGVOFFENSETYPES.Rows(0).Cells("OFFENSETYPE").Value = "NONE"


            Dim cbOffensesTYPES As New OleDb.OleDbCommandBuilder(dtadptOffensesTYPES)

            cbOffensesTYPES.ConflictOption = ConflictOption.OverwriteChanges


            dtadptOffensesTYPES.Update(dstOffensesTYPES, "tblOFFENSESTYPES")


            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DGVOFFENSETYPES_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVOFFENSETYPES.CellContentClick

    End Sub

    Private Sub DGVOFFENSETYPES_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DGVOFFENSETYPES.DataError
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
