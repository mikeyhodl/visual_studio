Imports System.Data.OleDb





Public Class frmStudentsMarks


    Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "DbfStudentsMarks.mdb")


    Dim dsMarks As New dataset()
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


            With dsMarks.Tables.Add("tblParentsContacts")
                .Columns.Add("ID", System.Type.GetType("System.Int32"))
                .Columns("ID").AutoIncrement = True
                .Columns("ID").AutoIncrementSeed = -1
                .Columns("ID").AutoIncrementStep = -1

            End With


            datdapter.Fill(dsMarks, "tblStudentMarks")


            conn.Close()

            Dim cbStudMarks As New OleDb.OleDbCommandBuilder(datdapter)



            dgvStudentMarks.DataSource = dsMarks.Tables("tblStudentMarks")



            dgvStudentMarks.Columns("ID").Width = 40
            dgvStudentMarks.Columns("NameOfParent").Width = 200

            dgvStudentMarks.Columns("Adress").Width = 300



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub
End Class