Imports System.Data.OleDb
Public Class frmEditNewStudents

    ' This is the connection to the local MS Access database.
    ' The database is needed in both the Debug and Release folders.


    '  This Is a roaming database connection

    Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "DBSTUDENTSNIDHAMU.mdb")


    'Another way of roaming database connection

    'Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\DBSTUDENTSNIDHAMU.mdb;Persist Security Info=False;")



    Dim dstEditNewStudents As New DataSet()

    Dim dtadptEditNewStudents As OleDb.OleDbDataAdapter
    Private Sub frmEditNewStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()


            Dim dstADMNO As New DataSet()
            Dim dtadptADMNO As OleDb.OleDbDataAdapter

            'fetch data for the combobox 'ADMNO'

            'clear the previous record before fetching new record and bind it to the combobox 'ComboADNO'
            dstADMNO.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptADMNO = New OleDb.OleDbDataAdapter("SELECT DISTINCT ADMISSIONNUMBER From tblNEWSTUDENTS", conn)

            dtadptADMNO.Fill(dstADMNO, "tblNEWSTUDENTS")


            'Close the database connection after filling the dataset
            conn.Close()


            'Fill the combobox 'ComboADMNO'

            ComboADMNO.DataSource = dstADMNO.Tables("tblNEWSTUDENTS")
                ComboADMNO.DisplayMember = "ADMISSIONNUMBER"
                ComboADMNO.ValueMember = "ADMISSIONNUMBER"


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


            Dim cbEditNewStudents As New OleDb.OleDbCommandBuilder(dtadptEditNewStudents)

            cbEditNewStudents.ConflictOption = ConflictOption.OverwriteChanges


            dtadptEditNewStudents.Update(dstEditNewStudents, "tblNEWSTUDENTS")

            MsgBox("Record(s) successfully saved!", MsgBoxStyle.OkOnly, "")

            conn.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub DgvEditNewStudents_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEditNewStudents.RowLeave
        Try
            ' Dim cbEditNewStudents As New OleDb.OleDbCommandBuilder(dtadptEditNewStudents)

            ' cbEditNewStudents.ConflictOption = ConflictOption.OverwriteChanges


            ' dtadptEditNewStudents.Update(dstEditNewStudents, "tblNEWSTUDENTS")

            ' MsgBox("Record(s) successfully saved!", MsgBoxStyle.OkOnly, "")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DgvEditNewStudents_MouseLeave(sender As Object, e As EventArgs) Handles DgvEditNewStudents.MouseLeave
        Try
            '  Dim cbEditNewStudents As New OleDb.OleDbCommandBuilder(dtadptEditNewStudents)

            '  cbEditNewStudents.ConflictOption = ConflictOption.OverwriteChanges


            ' dtadptEditNewStudents.Update(dstEditNewStudents, "tblNEWSTUDENTS")

            ' MsgBox("Record(s) successfully saved!", MsgBoxStyle.OkOnly, "")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ComboADMNO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboADMNO.SelectedIndexChanged
        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()

            'fetch data from the tblNEWSTUDENTS table

            'clear the previous record before fetching new record 
            dstEditNewStudents.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptEditNewStudents = New OleDb.OleDbDataAdapter("SELECT * From tblNEWSTUDENTS WHERE ADMISSIONNUMBER = '" & ComboADMNO.Text & "' ORDER BY ADMISSIONNUMBER ASC", conn)

            ' Use the data adapter to fill data in the dataset
            dtadptEditNewStudents.Fill(dstEditNewStudents, "tblNEWSTUDENTS")


            'Close the database connection after filling the dataset
            conn.Close()


            Dim cbEditNewStudents As New OleDb.OleDbCommandBuilder(dtadptEditNewStudents)

            ' If dstEditNewStudents.Tables("tblNEWSTUDENTS").Rows.Count > 0 Then

            DgvEditNewStudents.DataSource = dstEditNewStudents.Tables("tblNEWSTUDENTS")

            '  End If


            DgvEditNewStudents.Columns("ID").Visible = False
            DgvEditNewStudents.Columns("DISCONTINUED").Visible = False

            DgvEditNewStudents.Columns("ACADEMICYEAR").ReadOnly = True












        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub DgvEditNewStudents_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DgvEditNewStudents.DataError
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

    Private Sub DgvEditNewStudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEditNewStudents.CellContentClick

    End Sub
End Class