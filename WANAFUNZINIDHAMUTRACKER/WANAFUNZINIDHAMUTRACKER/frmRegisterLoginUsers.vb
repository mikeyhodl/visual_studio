Imports System.Data.OleDb

Public Class frmRegisterLoginUsers

    ' This is the connection to the local MS Access database.
    ' The database is needed in both the Debug and Release folders.
    Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "DBSTUDENTSNIDHAMU.mdb")


    Dim dsRegUsers As New DataSet()
    Dim IntUsers As Integer
    Dim dtadptUsers As OleDb.OleDbDataAdapter

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()


            'fetch data from the tblLoginUsers table

            'clear the previous record before fetching new record 
            dsRegUsers.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptUsers = New OleDb.OleDbDataAdapter("Select ID, UserName, PPassword, ConfirmPassword From tblLoginUsers", conn)



            ' Use the data adapter to fill data in the dataset
            dtadptUsers.Fill(dsRegUsers, "tblLoginUsers")


            'Close the database connection after filling the dataset
            conn.Close()



            Dim cbUsers As New OleDb.OleDbCommandBuilder(dtadptUsers)

            cbUsers.ConflictOption = ConflictOption.OverwriteChanges


            If dsRegUsers.Tables("tblLoginUsers").Rows.Count > 0 Then
                MessageBox.Show("Password already exists. Please use the User name and password you supplied to login.", "Login Credentials Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Exit Sub


                ' Check if username or password is empty

            ElseIf txtPassword.Text = "" Or txtUserName.Text = "" Or txtConfirmPassword.Text = "" Then
                MessageBox.Show("Please fill ALL the fields before proceeding...", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Exit Sub


            ElseIf dsRegUsers.Tables("tblLoginUsers").Rows(0).Item("UserName") = Me.txtUserName.Text And dsRegUsers.Tables("tblLoginUsers").Rows(0).Item("PPassword") = Me.txtPassword.Text Then

                MessageBox.Show("The user already exists", "User Exists", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                Exit Sub

            ElseIf Me.txtPassword.Text <> Me.txtConfirmPassword.Text Then

                MessageBox.Show("Passwords are different. Please confirm with identical password", "Inconsistent Passwords", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Exit Sub

            ElseIf dsRegUsers.Tables("tblLoginUsers").Rows(0).Item("UserName") <> Me.txtUserName.Text And dsRegUsers.Tables("tblLoginUsers").Rows(0).Item("PPassword") <> Me.txtPassword.Text Then

                dsRegUsers.Tables("tblLoginUsers").Rows(0).Item("UserName") = Me.txtUserName.Text

                dsRegUsers.Tables("tblLoginUsers").Rows(0).Item("PPassword") = Me.txtPassword.Text

                dsRegUsers.Tables("tblLoginUsers").Rows(0).Item("ConfirmPassword") = Me.txtConfirmPassword.Text


                MsgBox("You have Successfully Registered!", MsgBoxStyle.OkOnly, "")

                dtadptUsers.Update(dsRegUsers, "tblLoginUsers")

                Me.txtUserName.Text = ""
                Me.txtPassword.Text = ""
                Me.txtConfirmPassword.Text = ""
                Me.txtUserName.Focus()

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

        Try

            'User clicking on cancel button only clears field
            ' and refocus to first field
            txtUserName.Text = ""
            txtPassword.Text = ""
            txtConfirmPassword.Text = ""

            txtUserName.Focus()

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

    Private Sub BtnMultiUserReg_Click(sender As Object, e As EventArgs) Handles BtnMultiUserReg.Click
        Try


            ' Check if username or password is empty

            If txtPassword.Text = "" Or txtUserName.Text = "" Or txtConfirmPassword.Text = "" Then
                MessageBox.Show("Please fill ALL the fields before proceeding...", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Exit Sub

            ElseIf Me.txtPassword.Text <> Me.txtConfirmPassword.Text Then

                MessageBox.Show("Passwords are different. Please confirm with identical password", "Inconsistent Passwords", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Exit Sub


            Else


                If conn.State = ConnectionState.Open Then conn.Close()

                conn.Open()


                'fetch data from the tblLoginUsers table

                'clear the previous record before fetching new record 
                dsRegUsers.Clear()


                'Set the data adapter and fetch data from the database using select query
                dtadptUsers = New OleDb.OleDbDataAdapter("Select ID, UserName, PPassword, ConfirmPassword From tblLoginUsers", conn)



                ' Use the data adapter to fill data in the dataset
                dtadptUsers.Fill(dsRegUsers, "tblLoginUsers")


                'Close the database connection after filling the dataset
                conn.Close()


                'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx

                If IntUsers <> -1 Then


                    '   Dim cbUsers As New OleDb.OleDbCommandBuilder(dtadptUsers)

                    '   cbUsers.ConflictOption = ConflictOption.OverwriteChanges


                    IntUsers = 0




                    If dsRegUsers.Tables("tblLoginUsers").Rows.Count > 0 Then

                        For IntUsers = 0 To dsRegUsers.Tables("tblLoginUsers").Rows.Count - 1

                            If Me.txtUserName.Text = dsRegUsers.Tables("tblLoginUsers").Rows(IntUsers).Item("UserName") And Me.txtPassword.Text = dsRegUsers.Tables("tblLoginUsers").Rows(IntUsers).Item("PPassword") Then
                                MessageBox.Show("The user already exists", "User Exists", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                            End If

                        Next

                    End If
                End If
            End If
            'Exit Sub


            'xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx


            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()


            ' Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "DBSTUDENTSNIDHAMU.mdb")

            ' conn.Open()

            Dim cmd As OleDb.OleDbCommand
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into tblLoginUsers (UserName, PPassword, ConfirmPassword) VALUES (@UserName, @PPassword, @ConfirmPassword)"


            ' Dim SqlStr As String = "insert into tblLoginUsers (UserName, Password, ConfirmPassword) VALUES (@UserName, @Password, @ConfirmPassword)"
            'Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand(SqlStr, conn)


            cmd.Parameters.Add(New System.Data.OleDb.OleDbParameter("@UserName", System.Data.OleDb.OleDbType.VarChar, 40, Me.txtUserName.Text))
            cmd.Parameters.Add(New System.Data.OleDb.OleDbParameter("@PPassword", System.Data.OleDb.OleDbType.VarChar, 25, Me.txtPassword.Text))
            cmd.Parameters.Add(New System.Data.OleDb.OleDbParameter("@ConfirmPassword", System.Data.OleDb.OleDbType.VarChar, 25, Me.txtConfirmPassword.Text))


            ' RUN THE COMMAND
            cmd.Parameters("@UserName").Value = Me.txtUserName.Text
            cmd.Parameters("@PPassword").Value = Me.txtPassword.Text
            cmd.Parameters("@ConfirmPassword").Value = Me.txtConfirmPassword.Text


            cmd.ExecuteNonQuery()

            MessageBox.Show("You have Successfully Registered!!")


            Me.txtUserName.Text = ""
            Me.txtPassword.Text = ""
            Me.txtConfirmPassword.Text = ""
            Me.txtUserName.Focus()

            conn.Close()




        Catch ex As Exception
            MessageBox.Show("The user already exists:    " & ex.Message)
        End Try
    End Sub
End Class