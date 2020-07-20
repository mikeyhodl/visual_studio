Imports System.Data.OleDb
Public Class frmStudentsMarks

    ' This is the connection to the local MS Access database.
    ' The database is needed in both the Debug and Release folders.
    'At Public Class level, you only need one connection for all procedures in the form. You will only be opening and closing them whenever you want to fetch records from the database


    Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\DbfStudentsMarks.mdb;Persist Security Info=False;")


    'Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "DbfStudentsMarks.mdb")


    Dim dsMarks As New DataSet()
    Dim datdapter As OleDb.OleDbDataAdapter


    Private Sub frmStudentsMarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()


            'fetch data 

            'clear the previous record before fetching new record and bind it to the datagridview
            dsMarks.Clear()


            'Set the data adapter and fetch data from the database using select query
            datdapter = New OleDb.OleDbDataAdapter("Select * From tblStudentMarks", conn)


            'To increment the ID field. 


            With dsMarks.Tables.Add("tblStudentMarks")
                .Columns.Add("ID", System.Type.GetType("System.Int32"))
                .Columns("ID").AutoIncrement = True
                .Columns("ID").AutoIncrementSeed = -1
                .Columns("ID").AutoIncrementStep = -1

            End With


            datdapter.Fill(dsMarks, "tblStudentMarks")


            conn.Close()

            Dim cbStudMarks As New OleDb.OleDbCommandBuilder(datdapter)



            dgvStudentMarks.DataSource = dsMarks.Tables("tblStudentMarks")


            dgvStudentMarks.Columns("ID").Visible = False


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub btnSaveRecord_Click(sender As Object, e As EventArgs) Handles btnSaveRecord.Click

        Try

            Dim cbStudMarks As New OleDb.OleDbCommandBuilder(datdapter)

            cbStudMarks.ConflictOption = ConflictOption.OverwriteChanges

            datdapter.Update(dsMarks, "tblStudentMarks")

            MessageBox.Show("record sucessfully saved")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Try

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class