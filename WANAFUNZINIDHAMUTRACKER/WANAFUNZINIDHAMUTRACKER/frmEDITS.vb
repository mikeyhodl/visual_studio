Imports System.Data.OleDb

Public Class frmEDITS

    ' This is the connection to the local MS Access database.
    ' The database is needed in both the Debug and Release folders.
    Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "DBSTUDENTSNIDHAMU.mdb")

    Private Sub BtnEditUploadedStudents_Click(sender As Object, e As EventArgs) Handles BtnEditUploadedStudents.Click
        Try

            frmEditUploadedStudentsNidhamu.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnEditNewStudents_Click(sender As Object, e As EventArgs) Handles BtnEditNewStudents.Click
        Try

            frmEditNewStudents.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnDiscontinueLeavers_Click(sender As Object, e As EventArgs) Handles BtnDiscontinueLeavers.Click
        Try

            frmDiscontueLeavers.Show()

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

    Private Sub BtnDeleteEntireDataBase_Click(sender As Object, e As EventArgs) Handles BtnDeleteEntireDataBase.Click
        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()


            MessageBox.Show("This Action will delete ALL the Students' Records from the System.", "CAUTION")


            If MessageBox.Show("Are you sure you want to delete ALL the Records?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then

                Exit Sub

            Else


                Dim delcmd1 As New OleDbCommand("DELETE * FROM tblSTUDENTSNIDHAMU", conn)
                delcmd1.ExecuteNonQuery()



                Dim delcmd2 As New OleDbCommand("DELETE * FROM tblNEWSTUDENTS", conn)
                delcmd2.ExecuteNonQuery()


                MessageBox.Show("All Students' Records Deleted", "Confirm Deletion")

            End If

            conn.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class