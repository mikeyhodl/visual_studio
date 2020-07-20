Imports System.Data.OleDb
Public Class frmOFFENSESCATEGORIES

    ' This is the connection to the local MS Access database.
    ' The database is needed in both the Debug and Release folders.
    'At Public Class level, you only need one connection for all procedures in the form. You will only be opening and closing them whenever you want to fetch records from the database
    Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "DBSTUDENTSNIDHAMU.mdb")


    'Also define the datasets and dataadapters at public class level so that they can be accessed by other procedures
    Dim dstOffensesCategories As New DataSet

    Dim dtadptOffensescategories As OleDb.OleDbDataAdapter

    Private Sub frmOFFENSESCATEGORIES_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()


            'fetch data for the combobox 'ADMNO'

            'clear the previous record before fetching new record and bind it to the combobox 'ComboADNO'
            dstOffensesCategories.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptOffensescategories = New OleDb.OleDbDataAdapter("SELECT DISTINCT SNO, ID, COFFENSECATEGORY From tblOFFENSESCATEGORIES ORDER BY SNO ASC", conn)

            ' Use the data adapter to fill data in the dataset
            dtadptOffensescategories.Fill(dstOffensesCategories, "tblOFFENSESCATEGORIES")


            conn.Close()


            ' Dim cbOffensescategories As New OleDb.OleDbCommandBuilder(dtadptOffensescategories)


            'bind the datagridview to the dataset 'dst2'
            DGVOffensesCategories.DataSource = dstOffensesCategories.Tables("tblOFFENSESCATEGORIES")


            'Make the first row of the datagridview automatically have the word 'DISCIPLINED'

            DGVOffensesCategories.Rows(0).Cells("COFFENSECATEGORY").Value = "DISCIPLINED"



            'Hide the ID, SNO columns
            DGVOffensesCategories.Columns("ID").Visible = False
            DGVOffensesCategories.Columns("SNO").Visible = False

            'Set column widths
            ' DGVOffensesCategories.Columns("SNO").Width = 30
            DGVOffensesCategories.Columns("COFFENSECATEGORY").Width = 200

            'set column headings
            DGVOffensesCategories.Columns("COFFENSECATEGORY").HeaderText = "OFFENCE CATEGORY"



            Dim cbOffensescategories As New OleDb.OleDbCommandBuilder(dtadptOffensescategories)

            cbOffensescategories.ConflictOption = ConflictOption.OverwriteChanges


            dtadptOffensescategories.Update(dstOffensesCategories, "tblOFFENSESCATEGORIES")



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()



            Dim cbOffensescategories As New OleDb.OleDbCommandBuilder(dtadptOffensescategories)

            cbOffensescategories.ConflictOption = ConflictOption.OverwriteChanges


            dtadptOffensescategories.Update(dstOffensesCategories, "tblOFFENSESCATEGORIES")



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



    Private Sub DGVOffensesCategories_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DGVOffensesCategories.CellBeginEdit

        'Numbering items on a datagridview 'SNO'

        Dim CurrentRow As Integer = e.RowIndex
        DGVOffensesCategories.Rows(CurrentRow).Cells(0).Value = CurrentRow + 1

    End Sub

    Private Sub BtnDeleteCurrentRecord_Click(sender As Object, e As EventArgs) Handles BtnDeleteCurrentRecord.Click
        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()


            'To delete a datagridview row use the Rows collection's Remove or RemoveAt method.
            'First check to see if the current row is new because you cannot delete a new row.
            'Then remove the current row.

            'Now check to see if the current row is not new and and proceed

            If Not DGVOffensesCategories.CurrentRow.IsNewRow Then

                If MessageBox.Show("Are you sure you want to delete the Current Selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then

                    Exit Sub

                Else


                    DGVOffensesCategories.Rows.Remove(DGVOffensesCategories.CurrentRow)




                    Dim cbOffensescategories As New OleDb.OleDbCommandBuilder(dtadptOffensescategories)

                    cbOffensescategories.ConflictOption = ConflictOption.OverwriteChanges


                    dtadptOffensescategories.Update(dstOffensesCategories, "tblOFFENSESCATEGORIES")



                    MessageBox.Show("Record deleted", "Deletion Confirmed")


                End If
            End If


            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub DGVOffensesCategories_MouseMove(sender As Object, e As MouseEventArgs) Handles DGVOffensesCategories.MouseMove

        Try


            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()




            'Make the first row of the datagridview automatically have the word 'DISCIPLINED'

            DGVOffensesCategories.Rows(0).Cells("COFFENSECATEGORY").Value = "DISCIPLINED"




            Dim cbOffensescategories As New OleDb.OleDbCommandBuilder(dtadptOffensescategories)

            cbOffensescategories.ConflictOption = ConflictOption.OverwriteChanges


            dtadptOffensescategories.Update(dstOffensesCategories, "tblOFFENSESCATEGORIES")


            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub frmOFFENSESCATEGORIES_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Try


            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()




            'Make the first row of the datagridview automatically have the word 'DISCIPLINED'

            DGVOffensesCategories.Rows(0).Cells("COFFENSECATEGORY").Value = "DISCIPLINED"




            Dim cbOffensescategories As New OleDb.OleDbCommandBuilder(dtadptOffensescategories)

            cbOffensescategories.ConflictOption = ConflictOption.OverwriteChanges


            dtadptOffensescategories.Update(dstOffensesCategories, "tblOFFENSESCATEGORIES")


            conn.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub DGVOffensesCategories_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DGVOffensesCategories.DataError

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