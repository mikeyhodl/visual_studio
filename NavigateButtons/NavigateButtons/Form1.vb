Public Class Form1
    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim con As New OleDb.OleDbConnection

        Dim dbProvider As String
        Dim dbSource As String
        Dim MyDocumentsFolder As String
        Dim TheDatabase As String
        Dim FullDatabasePath As String

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"

        TheDatabase = "/dbfAddressBook1.mdb"
        MyDocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        FullDatabasePath = MyDocumentsFolder & TheDatabase

        dbSource = "Data Source = " & FullDatabasePath

        con.ConnectionString = dbProvider & dbSource

        con.Open()
        MessageBox.Show("Database is now open")

        con.Close()
        MessageBox.Show("Database is now Closed")


    End Sub
End Class
