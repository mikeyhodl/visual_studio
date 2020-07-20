Imports System.ComponentModel
Imports System.Data.OleDb
Public Class frmEditUploadedStudentsNidhamu

    ' This is the connection to the local MS Access database.
    ' The database is needed in both the Debug and Release folders.
    Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "DBSTUDENTSNIDHAMU.mdb")



    Dim dstEditNewStudents As New DataSet()

    Dim dtadptEditNewStudents As OleDb.OleDbDataAdapter


    Dim dstEditUploadedStudents As New DataSet()

    Dim dtadptEditUploadedStudents As OleDb.OleDbDataAdapter
    Private Sub frmEditUploadedStudentsNidhamu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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



            'Save tblSTUDENTSNIDHAMU

            Dim cbEditUploadedStudents As New OleDb.OleDbCommandBuilder(dtadptEditUploadedStudents)

                cbEditUploadedStudents.ConflictOption = ConflictOption.OverwriteChanges

                dtadptEditUploadedStudents.Update(dstEditUploadedStudents, "tblSTUDENTSNIDHAMU")



                'Save tblNEWSTUDENTS

                Dim cbEditNewStudents As New OleDb.OleDbCommandBuilder(dtadptEditNewStudents)

                cbEditNewStudents.ConflictOption = ConflictOption.OverwriteChanges


                dtadptEditNewStudents.Update(dstEditNewStudents, "tblNEWSTUDENTS")



            MsgBox("Record(s) successfully saved!", MsgBoxStyle.OkOnly, "")


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnGetPhoto_Click(sender As Object, e As EventArgs) Handles BtnGetPhoto.Click
        Try
            If OFGSelectImageStudentPhoto.ShowDialog = DialogResult.OK Then
                PictureBoxStudentPhoto.Image = Image.FromFile(OFGSelectImageStudentPhoto.FileName)
            End If

            'To make the image fit the given size
            PictureBoxStudentPhoto.Size = New System.Drawing.Size(100, 100)

            'To make the image fit the size of the picture box
            ' PictureBoxStudentPhoto.SizeMode = PictureBoxSizeMode.StretchImage

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnSavePhoto_Click(sender As Object, e As EventArgs) Handles BtnSavePhoto.Click

        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()



            DgvEditUploadedStudents.CurrentRow.Cells("STUDENTPHOTO").Value = PictureBoxStudentPhoto.Image


            Dim cbEditUploadedStudents As New OleDb.OleDbCommandBuilder(dtadptEditUploadedStudents)

            cbEditUploadedStudents.ConflictOption = ConflictOption.OverwriteChanges


            dtadptEditUploadedStudents.Update(dstEditUploadedStudents, "tblSTUDENTSNIDHAMU")

            MsgBox("Image successfully sent!. Now click on save.", MsgBoxStyle.OkOnly, "")



            conn.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DgvEditUploadedStudents_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DgvEditUploadedStudents.DataError
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

    Private Sub ComboADMNO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboADMNO.SelectedIndexChanged


        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()

            'fetch data from the tblNEWSTUDENTS table

            'clear the previous record before fetching new record 
            dstEditNewStudents.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptEditNewStudents = New OleDb.OleDbDataAdapter("SELECT ID, NAMEOFSTUDENT, ADMISSIONNUMBER, GENDER, CLASS, STREAM, DORMITORIES, KCPEMARKS, FORMERSCHOOL, DATEOFADMISSION, STUDENTPHOTO From tblNEWSTUDENTS WHERE ADMISSIONNUMBER = '" & ComboADMNO.Text & "'", conn)

            ' Use the data adapter to fill data in the dataset
            dtadptEditNewStudents.Fill(dstEditNewStudents, "tblNEWSTUDENTS")




            'fetch data from the tblSTUDENTSNIDHAMU table

            'clear the previous record before fetching new record 
            dstEditUploadedStudents.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptEditUploadedStudents = New OleDb.OleDbDataAdapter("SELECT ID, NAMEOFSTUDENT, ADMISSIONNUMBER, GENDER, CLASS, STREAM, DORMITORIES, KCPEMARKS, FORMERSCHOOL, DATEOFADMISSION, STUDENTPHOTO From tblSTUDENTSNIDHAMU WHERE ADMISSIONNUMBER = '" & ComboADMNO.Text & "'", conn)

            ' Use the data adapter to fill data in the dataset
            dtadptEditUploadedStudents.Fill(dstEditUploadedStudents, "tblSTUDENTSNIDHAMU")




            'Close the database connection after filling the dataset
            conn.Close()


            Dim cbEditNewStudents As New OleDb.OleDbCommandBuilder(dtadptEditNewStudents)

            ' If dstEditNewStudents.Tables("tblNEWSTUDENTS").Rows.Count > 0 Then

            DgvEditNewStudents.DataSource = dstEditNewStudents.Tables("tblNEWSTUDENTS")

            '  End If


            DgvEditNewStudents.Columns("ID").Visible = False
            DgvEditNewStudents.Columns("STUDENTPHOTO").Visible = False
            DgvEditNewStudents.Columns("NAMEOFSTUDENT").HeaderText = "NAME OF STUDENT"
            DgvEditNewStudents.Columns("ADMISSIONNUMBER").HeaderText = "ADMISSION NUMBER"
            DgvEditNewStudents.Columns("KCPEMARKS").HeaderText = "KCPE MARKS"
            DgvEditNewStudents.Columns("FORMERSCHOOL").HeaderText = "FORMER SCHOOL"
            DgvEditNewStudents.Columns("DATEOFADMISSION").HeaderText = "DATE OF ADMISSION"


            'JJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ

            'Fill uploaded students datagridview


            Dim cbEditUploadedStudents As New OleDb.OleDbCommandBuilder(dtadptEditUploadedStudents)



            ' If dstEditUploadedStudents.Tables("tblSTUDENTSNIDHAMU").Rows.Count > 0 Then

            DgvEditUploadedStudents.DataSource = dstEditUploadedStudents.Tables("tblSTUDENTSNIDHAMU")

            ' End If



            DgvEditUploadedStudents.Columns("ID").Visible = False
            DgvEditUploadedStudents.Columns("ID").Visible = False
            DgvEditUploadedStudents.Columns("NAMEOFSTUDENT").HeaderText = "NAME OF STUDENT"
            DgvEditUploadedStudents.Columns("ADMISSIONNUMBER").HeaderText = "ADMISSION NUMBER"
            DgvEditUploadedStudents.Columns("KCPEMARKS").HeaderText = "KCPE MARKS"
            DgvEditUploadedStudents.Columns("FORMERSCHOOL").HeaderText = "FORMER SCHOOL"
            DgvEditUploadedStudents.Columns("DATEOFADMISSION").HeaderText = "DATE OF ADMISSION"



            'Hide them

            DgvEditUploadedStudents.Columns("ID").Visible = False
            DgvEditUploadedStudents.Columns("GENDER").Visible = False
            DgvEditUploadedStudents.Columns("NAMEOFSTUDENT").Visible = False
            DgvEditUploadedStudents.Columns("ADMISSIONNUMBER").Visible = False
            DgvEditUploadedStudents.Columns("KCPEMARKS").Visible = False
            DgvEditUploadedStudents.Columns("FORMERSCHOOL").Visible = False
            DgvEditUploadedStudents.Columns("DATEOFADMISSION").Visible = False
            DgvEditUploadedStudents.Columns("CLASS").Visible = False
            DgvEditUploadedStudents.Columns("STREAM").Visible = False
            DgvEditUploadedStudents.Columns("DORMITORIES").Visible = False


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub DgvEditNewStudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEditNewStudents.CellContentClick

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

    Private Sub DgvEditNewStudents_MouseMove(sender As Object, e As MouseEventArgs) Handles DgvEditNewStudents.MouseMove

        Try

            For i As Integer = 0 To DgvEditUploadedStudents.RowCount - 1

                DgvEditUploadedStudents.Rows(i).Cells("ADMISSIONNUMBER").Value = DgvEditNewStudents.Rows(0).Cells("ADMISSIONNUMBER").Value
                DgvEditUploadedStudents.Rows(i).Cells("NAMEOFSTUDENT").Value = DgvEditNewStudents.Rows(0).Cells("NAMEOFSTUDENT").Value
                DgvEditUploadedStudents.Rows(i).Cells("GENDER").Value = DgvEditNewStudents.Rows(0).Cells("GENDER").Value
                DgvEditUploadedStudents.Rows(i).Cells("KCPEMARKS").Value = DgvEditNewStudents.Rows(0).Cells("KCPEMARKS").Value
                DgvEditUploadedStudents.Rows(i).Cells("FORMERSCHOOL").Value = DgvEditNewStudents.Rows(0).Cells("FORMERSCHOOL").Value
                DgvEditUploadedStudents.Rows(i).Cells("DATEOFADMISSION").Value = DgvEditNewStudents.Rows(0).Cells("DATEOFADMISSION").Value

            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class