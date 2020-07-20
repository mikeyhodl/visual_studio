Imports System.Data.OleDb

Public Class frmLogin


    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        'Step 1: Need to ensure that the user provide both username and password. To do so, use If Else condition statement and OR comparison operator.

        ' Check if username or password is empty

        If txtPassword.Text = "" Or txtUserName.Text = "" Then
            MessageBox.Show("Please Enter your User Name and Password before proceeding..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' If User Name and Password were supplied then check if the user exists in the database.

            ' To check if the user exists in the database, connect to the database.

            Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "DBSTUDENTSNIDHAMU.mdb")

            'Use Try and Catch the Exception
            Try

                'conn.Open()
                'MsgBox("Susscess")


                ' The Sql string holds the username And password comparison in SQL Statement format. Astrerisk( * ) means that we are going to fetch every column on tbl_user
                'we 've created earlier on matched record in WHERE condition output.  In checking the required fields earlier, we used OR comparison operator in which only one conditions must be TRUE in order to satisfy.
                'In here, we're going to use AND as it will proceed only if both conditions are TRUE. Meaning username and password must be matched or it will fail. The sql will be executed and store in sqlRead variable.


                Dim sql As String = "SELECT * FROM tblLoginUsers WHERE UserName = '" & txtUserName.Text & "' AND PPassword = '" & txtPassword.Text & "'"
                Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

                'Open Database Connection
                sqlCom.Connection = conn
                conn.Open()

                Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader() 'sqlRead variable will store the result of the sql string


                'Now check if user enter correct username and password in order to proceed. Create another form and name it as frmMain. 
                'When user has been authenticated, this frmMain will show And we're going to hide the frmLogin. 
                'Otherwise, we're going to display error message, clear username and password text box and set the focus to username text field.

                'The result of the sql string stored in the sqlRead variable is compared below with the user's input in the userName text field and the Password text field. 
                'If they match, the Sub will Continue Or Else show an Error message below.

                If sqlRead.Read() Then
                    frmMain.Show()
                    frmMain.WindowState = FormWindowState.Maximized

                    Me.Hide()
                Else
                    ' If user enter wrong username and password combination
                    ' Throw an error message
                    MessageBox.Show("Wrong Username or Password..", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    'Clear all fields
                    txtPassword.Text = ""
                    txtUserName.Text = ""

                    'Focus on Username field
                    txtUserName.Focus()

                End If



                'The MessageBox instances are the same as the previous one except we concatenate( ampersand & ) the exception message to let us know the exact error.
            Catch ex As Exception
                MessageBox.Show("Failed to connect to Database.. System Error Message:  " & ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End If

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Try
            Me.Close()
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
            txtUserName.Focus()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

        Try
            txtPassword.PasswordChar = "*"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnRegisterUser_Click(sender As Object, e As EventArgs) Handles BtnRegisterUser.Click
        Try

            frmRegisterLoginUsers.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnBackupDataBase_Click(sender As Object, e As EventArgs) Handles BtnBackupDataBase.Click
        Try
            Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "DBSTUDENTSNIDHAMU.mdb")


            conn.Open()

            'My.Application.Info.DirectoryPath
            'Dim portfolioPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            ' Dim portfolioPath As String = "C:\Users\Admin\AppData\Roaming"



            ' Once it(the App) Is installed, you can access the Special Folder by

            Dim folderPath As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData.ToCharArray()



            FileCopy(folderPath & "\DBSTUDENTSNIDHAMU.mdb", "D:\")                     ' "D:\Backup\EmployeesInfo.mdb")
            MsgBox("Backup Successful")

            Conn.close

            'Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LblToOrder_Click(sender As Object, e As EventArgs) Handles LblToOrder.Click

    End Sub

    Private Sub LblCopyright_Click(sender As Object, e As EventArgs) Handles LblCopyright.Click

    End Sub
End Class