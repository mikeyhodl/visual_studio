Imports System.Data.OleDb

Public Class FrmStudentsMarks

    Dim conn As New OleDb.OleDbConnection(connectionString:="provider=microsoft.Jet.OleDb.4.0; Data source = |DataDirectory|\\ dbStudentsmarks.mdb;persist Security infomation = false;")

    Dim dstMarks As New DataSet
    Dim dtdAptMarks As OleDb.OleDbDataAdapter


    Private Sub FrmStudentsMarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If conn.State = ConnectionState.Open Then conn.Close()

        conn.Open()

        dstMarks.Clear()

        dtdAptMarks = New OleDb.OleDbDataAdapter("Select * FROM tblMarks", conn)

        dtdAptMarks.Fill(dstMarks, "tblMarks")

        conn.Close()


        Dim cbMarks As New OleDb.OleDbCommandBuilder(dtdAptMarks)

        dgvMarks.DataSource = dstMarks.Tables("tblMarks")

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMarks.CellContentClick

    End Sub
End Class