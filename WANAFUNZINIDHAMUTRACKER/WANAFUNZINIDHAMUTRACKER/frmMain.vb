Imports System.Data.OleDb

Public Class frmMain

    ' This is the connection to the local MS Access database.
    ' The database is needed in both the Debug and Release folders.
    Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "DBSTUDENTSNIDHAMU.mdb")
    Dim IntCounterREG As Integer
    Dim IntCounterNIDHAM As Integer

    Dim dst As New DataSet()
    Dim dstUpdateNewStudents As New DataSet()
    Dim dstEditStudentsNidhamu As New DataSet()
    Dim dstCLASS As New DataSet
    Dim dstStream As New DataSet
    Dim dstDormitories As New DataSet()

    Dim dtadpt As OleDb.OleDbDataAdapter
    Dim dtadptUpdateNewStudents As OleDb.OleDbDataAdapter
    Dim dtadptEditStudentsNidhamu As OleDb.OleDbDataAdapter
    Dim dtadptCLASS As OleDb.OleDbDataAdapter
    Dim dtadptStream As OleDb.OleDbDataAdapter
    Dim dtadptDormitories As OleDb.OleDbDataAdapter

    'Others
    Dim IntCounterArchive As Integer


    ' Dim dst As New DataSet()
    Dim dstUpdateArchive As New DataSet()


    ' Dim dtadpt As OleDb.OleDbDataAdapter
    Dim dtadptUpdateArchive As OleDb.OleDbDataAdapter


    'Other declarations

    'Dim IntCounterREG As Integer
    ' Dim IntCounterNIDHAM As Integer

    Dim dstR As New DataSet()
    ' Dim dstUpdateNewStudents As New DataSet()


    Dim dtadptR As OleDb.OleDbDataAdapter
    ' Dim dtadptUpdateNewStudents As OleDb.OleDbDataAdapter

    Private Sub MnuExit_Click(sender As Object, e As EventArgs) Handles MnuExit.Click
        Try

            For Each form As Form In My.Application.OpenForms
                form.Close()
            Next

            'Me.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MnuEnterStudentsData_Click(sender As Object, e As EventArgs) Handles MnuEnterStudentsData.Click

        Try


            Dim dst2 As New DataSet
            Dim dtadpt2 As OleDb.OleDbDataAdapter


            'Close the connection and open again within the same load event to fetch data and handle the nulls

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()

            'clear the previous record before fetching new record and bind it to the datagridview
            dst2.Clear()

            Dim SQLstudnts As String

            SQLstudnts = "Select ID, DATEOFOCCURENCE, NAMEOFSTUDENT, ADMISSIONNUMBER, GENDER, CLASS, STREAM, FORMERSCHOOL, DATEOFADMISSION, KCPEMARKS, KCPEGRADE, CURRENTMARKS, CURRENTPOINTS, CURRENTGRADE, STUDENTVAP, CLASSPOSITION, STREAMPOSITION, FEESBALANCE, "

            SQLstudnts &= "FEEPAYER, OFFENSECOMMITED, TYPEOFOFFENSE, OFFENSECATEGORY, EXPECTEDDATEOFRETURN, DIDSTUDENTRETURN, ACTUALDATEOFRETURN, STATEOFAFFAIRS, TYPEOFPUNISHMENT, DIDPUNSHMENT, PUNSHMENTSTATE, DATECOMPLETEDPUNSHMENT, "

            SQLstudnts &= "PUNSHEDBY, FAMILYSITUATION, NAMEOFPARENT,  PARENTPHONENUMBER, COUNTY, SUBCOUNTY, RESIDENCEESTATE, RESPONSIBILITY, REMARKS FROM tblSTUDENTSNIDHAMU"


            'Set the data adapter and fetch the records from the database using the select query
            dtadpt2 = New OleDb.OleDbDataAdapter(SQLstudnts, conn)




            ' Use the data adapter to fill data in the dataset
            dtadpt2.Fill(dst2, "tblSTUDENTSNIDHAMU") 'Record source for first datagridview  'DataGridViewFirstStudentDetails'


            'Close the database after filling the datasets
            conn.Close()



            If Not dst2.Tables("tblSTUDENTSNIDHAMU").Rows.Count > 0 Then

                MsgBox("There are no any uploaded records in the database. Please upload them to proceed.",, "Records Missing")



                Exit Sub


            Else

                'Fill the null values in the database table

                Dim IntFillNulls As Integer

                IntFillNulls = 0

                If dst2.Tables("tblSTUDENTSNIDHAMU").Rows.Count > 0 Then

                    For IntFillNulls = 0 To dst2.Tables("tblSTUDENTSNIDHAMU").Rows.Count - 1

                        'If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("DATEOFADMISSION")) = True Then
                        'dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("DATEOFADMISSION") = 0
                        'End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("KCPEMARKS")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("KCPEMARKS") = 0
                        End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("KCPEGRADE")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("KCPEGRADE") = "-"
                        End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("CURRENTMARKS")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("CURRENTMARKS") = 0
                        End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("CURRENTPOINTS")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("CURRENTPOINTS") = 0
                        End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("CURRENTGRADE")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("CURRENTGRADE") = "-"
                        End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("STUDENTVAP")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("STUDENTVAP") = 0
                        End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("FORMERSCHOOL")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("FORMERSCHOOL") = "-"
                        End If


                        ' If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("DATEOFADMISSION")) = True Then
                        'dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("DATEOFADMISSION") = 00000000
                        'End If


                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("FEESBALANCE")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("FEESBALANCE") = 0
                        End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("FEEPAYER")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("FEEPAYER") = "-"
                        End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("CLASSPOSITION")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("CLASSPOSITION") = "X"
                        End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("STREAMPOSITION")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("STREAMPOSITION") = "X"
                        End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("OFFENSECOMMITED")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("OFFENSECOMMITED") = "NO OFFENSE"
                        End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("TYPEOFOFFENSE")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("TYPEOFOFFENSE") = "NONE"
                        End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("OFFENSECATEGORY")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("OFFENSECATEGORY") = "DISCIPLINED"
                        End If

                        'If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("STUDENTPHOTO")) = True Then
                        'dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("STUDENTPHOTO") = "MISSING DATA"
                        ' End If

                        '   If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("FAMILYSITUATION")) = True Then
                        ' dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("FAMILYSITUATION") = "MISSING DATA"
                        'End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("NAMEOFPARENT")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("NAMEOFPARENT") = "-"
                        End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("PARENTPHONENUMBER")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("PARENTPHONENUMBER") = "-"
                        End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("COUNTY")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("COUNTY") = "-"
                        End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("SUBCOUNTY")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("SUBCOUNTY") = "-"
                        End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("RESIDENCEESTATE")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("RESIDENCEESTATE") = "-"
                        End If

                        ' If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("EXPECTEDDATEOFRETURN")) = True Then
                        'dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("EXPECTEDDATEOFRETURN") = 00000000
                        'End If

                        ' If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("ACTUALDATEOFRETURN")) = True Then
                        'dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("ACTUALDATEOFRETURN") = 00000000
                        'End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("STATEOFAFFAIRS")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("STATEOFAFFAIRS") = "-"
                        End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("TYPEOFPUNISHMENT")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("TYPEOFPUNISHMENT") = "Pending"
                        End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("PUNSHMENTSTATE")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("PUNSHMENTSTATE") = "-"
                        End If

                        ' If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("DATECOMPLETEDPUNSHMENT")) = True Then
                        'dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("DATECOMPLETEDPUNSHMENT") = 00000000
                        'End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("PUNSHEDBY")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("PUNSHEDBY") = "-"
                        End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("RESPONSIBILITY")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("RESPONSIBILITY") = "NONE"
                        End If

                        If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("REMARKS")) = True Then
                            dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("REMARKS") = "NONE"
                        End If

                    Next
                End If

            End If


            Dim cb2 As New OleDb.OleDbCommandBuilder(dtadpt2)


            cb2.ConflictOption = ConflictOption.OverwriteChanges


            dtadpt2.Update(dst2, "tblSTUDENTSNIDHAMU")




            frmNIDHAMUMain.Show()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MnuRegisterPreliminariesInformation_Click(sender As Object, e As EventArgs) Handles MnuRegisterPreliminariesInformation.Click
        Try
            frmPRELIMINARIES.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MnuEditOrCorrectData_Click(sender As Object, e As EventArgs) Handles MnuEditOrCorrectData.Click

        Try

            frmEDITS.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MnuRegisterStudents_Click(sender As Object, e As EventArgs) Handles MnuRegisterStudents.Click
        Try
            frmDataEntryNIDHAMU.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MnuDatabaseBackUp_Click(sender As Object, e As EventArgs) Handles MnuDatabaseBackUp.Click

        Try



            ' Once it(the App) Is installed, you can access the Special Folder by


            If MessageBox.Show("Frequent Backing up of your database after adding new information is highly recommended so that you can retrieve it later should anything go wrong with the current data on the system. Are you sure you want to backup your database?", "Database Backup Copy", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then

                'Restore the database from a backup copy. 




                FileCopy(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "DBSTUDENTSNIDHAMU.mdb", "C:\NidhamuBackup\DBSTUDENTSNIDHAMU.mdb")



                MsgBox("Backup Successful",, "Database Backup")


            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MnuDatabaseRestoration_Click(sender As Object, e As EventArgs) Handles MnuDatabaseRestoration.Click

        Try

            If MessageBox.Show("Restoring the database from a backup copy will erase any changes you have made to the current database since your last backup. Are you sure you want to restore the database from a backup copy?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then

                'Restore the database from a backup copy. 


                FileCopy("C:\NidhamuBackup\DBSTUDENTSNIDHAMU.mdb", System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "DBSTUDENTSNIDHAMU.mdb")


                MsgBox("Database Restoration Successful",, "Database Restoration")

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MnuPromoteToNextClass_Click(sender As Object, e As EventArgs) Handles MnuPromoteToNextClass.Click

        Try

            frmPromotionsSwitchboard.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MnuDemoteToLowerClass_Click(sender As Object, e As EventArgs) Handles MnuDemoteToLowerClass.Click

        Try



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MnuSendToArchive_Click(sender As Object, e As EventArgs) Handles MnuSendToArchive.Click

        Try

            ' If MessageBox.Show("Restoring the database from a backup copy will erase any changes you have made to the current database since your last backup. Are you sure you want to restore the database from a backup copy?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then

            'Restore the database from a backup copy. 


            'FileCopy("C:\NidhamuBackup\DBSTUDENTSNIDHAMU.mdb", System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "DBSTUDENTSNIDHAMU.mdb")


            'MsgBox("Database Restoration Successful",, "Database Restoration")

            ' End If




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()


            'Assign 'txtCurrentYear' textbox current year
            txtCurrentYear.Text = Date.Now.Year


            'clear the previous record before fetching new record 
            dst.Clear() 'Current records table 'tblSTUDENTSNIDHAMU'


            'Set the data adapter and fetch data fro the database using select query
            dtadpt = New OleDb.OleDbDataAdapter("SELECT * From tblSTUDENTSNIDHAMU WHERE ACADEMICYEAR <> '" & txtCurrentYear.Text & "' AND NOT ACADEMICYEAR IN (SELECT ACADEMICYEAR FROM tblSTUDENTSNIDHAMUArchive) ORDER BY ACADEMICYEAR ASC", conn)



            ' Use the data adapter to fill data in the dataset
            dtadpt.Fill(dst, "tblSTUDENTSNIDHAMU") 'Current records table 'tblSTUDENTSNIDHAMU'



            'fetch data from the tblSTUDENTSNIDHAMUArchive table

            'clear the previous record before fetching new records 
            dstUpdateArchive.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptUpdateArchive = New OleDb.OleDbDataAdapter("Select * From tblSTUDENTSNIDHAMUArchive ORDER BY ACADEMICYEAR ASC", conn)

            ' Use the data adapter to fill data in the dataset
            dtadptUpdateArchive.Fill(dstUpdateArchive, "tblSTUDENTSNIDHAMUArchive")


            'Close the database connection after filling the dataset
            ' conn.Close()


            ' If IntCounterNIDHAM <> -1 And IntCounterArchive <> -1 Then



            If IntCounterArchive <> -1 Then

                'Check if records have already been copied to archive and students promoted and the exit sub or else continue with the operation

                IntCounterArchive = 0

                If dstUpdateArchive.Tables("tblSTUDENTSNIDHAMUArchive").Rows.Count > 0 Then

                    For IntCounterArchive = 0 To dstUpdateArchive.Tables("tblSTUDENTSNIDHAMUArchive").Rows.Count - 1

                        If dstUpdateArchive.Tables("tblSTUDENTSNIDHAMUArchive").Rows(IntCounterArchive).Item("ACADEMICYEAR") = Date.Now.Year - 1 Then
                            LblConfirmStudentPromotion.Text = "The students are already promoted to their next classes for the current year:"
                        End If
                    Next


                    Exit Sub



                Else


                    If IntCounterArchive <> -1 Then


                        Dim cbdtadptUpdateArchive As New OleDb.OleDbCommandBuilder(dtadptUpdateArchive)
                        cbdtadptUpdateArchive.ConflictOption = ConflictOption.OverwriteChanges

                        Dim dstUpdateArchiveNewRow As DataRow

                        IntCounterArchive = 0




                        If dst.Tables("tblSTUDENTSNIDHAMU").Rows.Count > 0 Then

                            For IntCounterArchive = 0 To dst.Tables("tblSTUDENTSNIDHAMU").Rows.Count - 1

                                dstUpdateArchiveNewRow = dstUpdateArchive.Tables("tblSTUDENTSNIDHAMUArchive").NewRow()

                                'dstUpdateArchiveNewRow.Item("ID") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("ID")
                                dstUpdateArchiveNewRow.Item("NAMEOFSTUDENT") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("NAMEOFSTUDENT").ToString
                                dstUpdateArchiveNewRow.Item("ADMISSIONNUMBER") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("ADMISSIONNUMBER").ToString
                                dstUpdateArchiveNewRow.Item("GENDER") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("GENDER").ToString
                                dstUpdateArchiveNewRow.Item("CLASS") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("CLASS").ToString
                                dstUpdateArchiveNewRow.Item("STREAM") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("STREAM").ToString
                                dstUpdateArchiveNewRow.Item("KCPEMARKS") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("KCPEMARKS")
                                dstUpdateArchiveNewRow.Item("KCPEGRADE") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("KCPEGRADE").ToString
                                dstUpdateArchiveNewRow.Item("STUDENTPHOTO") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("STUDENTPHOTO")
                                dstUpdateArchiveNewRow.Item("DORMITORIES") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("DORMITORIES").ToString
                                dstUpdateArchiveNewRow.Item("TERM") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("TERM").ToString
                                dstUpdateArchiveNewRow.Item("FORMERSCHOOL") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("FORMERSCHOOL").ToString
                                dstUpdateArchiveNewRow.Item("DATEOFADMISSION") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("DATEOFADMISSION")
                                dstUpdateArchiveNewRow.Item("DATEOFOCCURENCE") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("DATEOFOCCURENCE")
                                dstUpdateArchiveNewRow.Item("ACADEMICYEAR") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("ACADEMICYEAR").ToString



                                dstUpdateArchiveNewRow.Item("KCPEPOINTS") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("KCPEPOINTS")
                                dstUpdateArchiveNewRow.Item("CURRENTMARKS") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("CURRENTMARKS")
                                dstUpdateArchiveNewRow.Item("CURRENTPOINTS") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("CURRENTPOINTS")
                                dstUpdateArchiveNewRow.Item("CURRENTGRADE") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("CURRENTGRADE").ToString
                                dstUpdateArchiveNewRow.Item("STUDENTVAP") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("STUDENTVAP")
                                dstUpdateArchiveNewRow.Item("FEESBALANCE") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("FEESBALANCE")
                                dstUpdateArchiveNewRow.Item("FEEPAYER") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("FEEPAYER").ToString
                                dstUpdateArchiveNewRow.Item("CLASSPOSITION") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("CLASSPOSITION").ToString
                                dstUpdateArchiveNewRow.Item("STREAMPOSITION") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("STREAMPOSITION").ToString
                                dstUpdateArchiveNewRow.Item("OFFENSECOMMITED") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("OFFENSECOMMITED").ToString
                                dstUpdateArchiveNewRow.Item("TYPEOFOFFENSE") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("TYPEOFOFFENSE").ToString
                                dstUpdateArchiveNewRow.Item("OFFENSECATEGORY") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("OFFENSECATEGORY").ToString
                                dstUpdateArchiveNewRow.Item("FAMILYSITUATION") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("FAMILYSITUATION").ToString





                                dstUpdateArchiveNewRow.Item("NAMEOFPARENT") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("NAMEOFPARENT").ToString
                                dstUpdateArchiveNewRow.Item("PARENTPHONENUMBER") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("PARENTPHONENUMBER").ToString
                                dstUpdateArchiveNewRow.Item("COUNTY") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("COUNTY").ToString
                                dstUpdateArchiveNewRow.Item("SUBCOUNTY") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("SUBCOUNTY").ToString
                                dstUpdateArchiveNewRow.Item("RESIDENCEESTATE") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("RESIDENCEESTATE").ToString
                                dstUpdateArchiveNewRow.Item("EXPECTEDDATEOFRETURN") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("EXPECTEDDATEOFRETURN")
                                dstUpdateArchiveNewRow.Item("ACTUALDATEOFRETURN") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("ACTUALDATEOFRETURN")
                                dstUpdateArchiveNewRow.Item("DIDSTUDENTRETURN") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("DIDSTUDENTRETURN")
                                dstUpdateArchiveNewRow.Item("STATEOFAFFAIRS") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("STATEOFAFFAIRS").ToString
                                dstUpdateArchiveNewRow.Item("TYPEOFPUNISHMENT") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("TYPEOFPUNISHMENT").ToString
                                dstUpdateArchiveNewRow.Item("DIDPUNSHMENT") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("DIDPUNSHMENT")
                                dstUpdateArchiveNewRow.Item("PUNSHMENTSTATE") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("PUNSHMENTSTATE").ToString
                                dstUpdateArchiveNewRow.Item("DATECOMPLETEDPUNSHMENT") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("DATECOMPLETEDPUNSHMENT")




                                dstUpdateArchiveNewRow.Item("PUNSHEDBY") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("PUNSHEDBY").ToString
                                dstUpdateArchiveNewRow.Item("STUDENTVIEWPOINT") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("STUDENTVIEWPOINT").ToString
                                dstUpdateArchiveNewRow.Item("GUIDED") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("GUIDED")
                                dstUpdateArchiveNewRow.Item("GUIDEDDATE") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("GUIDEDDATE")
                                dstUpdateArchiveNewRow.Item("DISCONTINUED") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("DISCONTINUED")
                                dstUpdateArchiveNewRow.Item("RESPONSIBILITY") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("RESPONSIBILITY").ToString
                                dstUpdateArchiveNewRow.Item("REMARKS") = dst.Tables("tblSTUDENTSNIDHAMU").Rows(IntCounterArchive).Item("REMARKS").ToString


                                dstUpdateArchive.Tables("tblSTUDENTSNIDHAMUArchive").Rows.Add(dstUpdateArchiveNewRow)

                            Next

                            'save data in the database table

                            dtadptUpdateArchive.Update(dstUpdateArchive, "tblSTUDENTSNIDHAMUArchive")









                            'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

                            'Declare variables
                            Dim dstNewSt As New DataSet()
                            Dim dstNewStArchive As New DataSet()
                            Dim dtadptNewSt As OleDb.OleDbDataAdapter
                            Dim dtadptNewStArchive As OleDb.OleDbDataAdapter




                            'clear the previous record before fetching new record 
                            dstNewSt.Clear() 'Current records table 'tblNEWSTUDENTS'


                            'Set the data adapter and fetch data fro the database using select query
                            dtadptNewSt = New OleDb.OleDbDataAdapter("SELECT * From tblNEWSTUDENTS WHERE ACADEMICYEAR <> '" & txtCurrentYear.Text & "' AND NOT ACADEMICYEAR IN (SELECT ACADEMICYEAR FROM tblNEWSTUDENTSArchive) ORDER BY ACADEMICYEAR ASC", conn)



                            ' Use the data adapter to fill data in the dataset
                            dtadptNewSt.Fill(dstNewSt, "tblNEWSTUDENTS") 'Current records table 'tblNEWSTUDENTS'



                            'fetch data from the tblNEWSTUDENTSArchive table

                            'clear the previous record before fetching new records 
                            dstNewStArchive.Clear()


                            'Set the data adapter and fetch data from the database using select query
                            dtadptNewStArchive = New OleDb.OleDbDataAdapter("Select * From tblNEWSTUDENTSArchive ORDER BY ACADEMICYEAR ASC", conn)

                            ' Use the data adapter to fill data in the dataset
                            dtadptNewStArchive.Fill(dstNewStArchive, "tblNEWSTUDENTSArchive")



                            Dim IntCounterNewStArchive As Integer

                            If IntCounterNewStArchive <> -1 Then


                                Dim cbdtadptNewStArchive As New OleDb.OleDbCommandBuilder(dtadptNewStArchive)
                                cbdtadptNewStArchive.ConflictOption = ConflictOption.OverwriteChanges


                                Dim dstNewStArchiveNewRow As DataRow

                                IntCounterNewStArchive = 0




                                If dstNewSt.Tables("tblNEWSTUDENTS").Rows.Count > 0 Then

                                    For IntCounterNewStArchive = 0 To dstNewSt.Tables("tblNEWSTUDENTS").Rows.Count - 1

                                        dstNewStArchiveNewRow = dstNewStArchive.Tables("tblNEWSTUDENTSArchive").NewRow()

                                        dstNewStArchiveNewRow.Item("NAMEOFSTUDENT") = dstNewSt.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("NAMEOFSTUDENT").ToString
                                        dstNewStArchiveNewRow.Item("ADMISSIONNUMBER") = dstNewSt.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("ADMISSIONNUMBER").ToString
                                        dstNewStArchiveNewRow.Item("GENDER") = dstNewSt.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("GENDER").ToString
                                        dstNewStArchiveNewRow.Item("CLASS") = dstNewSt.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("CLASS").ToString
                                        dstNewStArchiveNewRow.Item("STREAM") = dstNewSt.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("STREAM").ToString
                                        dstNewStArchiveNewRow.Item("KCPEMARKS") = dstNewSt.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("KCPEMARKS")
                                        dstNewStArchiveNewRow.Item("KCPEGRADE") = dstNewSt.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("KCPEGRADE").ToString
                                        dstNewStArchiveNewRow.Item("STUDENTPHOTO") = dstNewSt.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("STUDENTPHOTO")     '.ToString
                                        dstNewStArchiveNewRow.Item("DORMITORIES") = dstNewSt.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("DORMITORIES").ToString
                                        dstNewStArchiveNewRow.Item("DATEOFOCCURENCE") = dstNewSt.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("DATEOFOCCURENCE")
                                        dstNewStArchiveNewRow.Item("FORMERSCHOOL") = dstNewSt.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("FORMERSCHOOL").ToString
                                        dstNewStArchiveNewRow.Item("DATEOFADMISSION") = dstNewSt.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("DATEOFADMISSION")
                                        ' dstNewStArchiveNewRow.Item("DATEOFOCCURENCE") = dstNewSt.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("DATEOFOCCURENCE")
                                        dstNewStArchiveNewRow.Item("ACADEMICYEAR") = dstNewSt.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("ACADEMICYEAR").ToString

                                        dstNewStArchive.Tables("tblNEWSTUDENTSArchive").Rows.Add(dstNewStArchiveNewRow)

                                    Next

                                    'save data in the database table

                                    dtadptNewStArchive.Update(dstNewStArchive, "tblNEWSTUDENTSArchive")



                                    'delete all data in the tblSTUDENTSNIDHAMU so as to assign it promoted students for the current year

                                    Dim delcmd1 As New OleDbCommand("DELETE * FROM tblSTUDENTSNIDHAMU WHERE ACADEMICYEAR <> '" & txtCurrentYear.Text & "'", conn)
                                    delcmd1.ExecuteNonQuery()



                                    Dim delcmd2 As New OleDbCommand("DELETE * FROM tblNEWSTUDENTS WHERE CLASS = 'FORM 4' AND ACADEMICYEAR <> '" & txtCurrentYear.Text & "'", conn)
                                    delcmd2.ExecuteNonQuery()


                                    ' Dim delcmd3 As New OleDbCommand("DELETE * FROM tblNEWSTUDENTS WHERE CLASS = 'FORM 6' AND ACADEMICYEAR <> '" & txtCurrentYear.Text & "'", conn)
                                    ' delcmd3.ExecuteNonQuery()






                                    'Promote students from one class to the next

                                    Dim dstNewStF1 As New DataSet()
                                    Dim dstNewStF2 As New DataSet()
                                    Dim dstNewStF3 As New DataSet()
                                    ' Dim dstNewStF5 As New DataSet()

                                    Dim dtadptNewStF1 As OleDb.OleDbDataAdapter
                                    Dim dtadptNewStF2 As OleDb.OleDbDataAdapter
                                    Dim dtadptNewStF3 As OleDb.OleDbDataAdapter
                                    ' Dim dtadptNewStF5 As OleDb.OleDbDataAdapter


                                    'Pull form 1 records and assign them form 2

                                    'clear the previous record before fetching new record 
                                    dstNewStF1.Clear() 'Current records table 'tblNEWSTUDENTS'


                                    'Set the data adapter and fetch data fro the database using select query
                                    dtadptNewStF1 = New OleDb.OleDbDataAdapter("SELECT * From tblNEWSTUDENTS WHERE CLASS = 'FORM 1' AND ACADEMICYEAR <> '" & txtCurrentYear.Text & "' ORDER BY ACADEMICYEAR ASC", conn)

                                    ' Use the data adapter to fill data in the dataset
                                    dtadptNewStF1.Fill(dstNewStF1, "tblNEWSTUDENTS")


                                    Dim cbdtadptChangeClassF1 As New OleDb.OleDbCommandBuilder(dtadptNewStF1)
                                    cbdtadptChangeClassF1.ConflictOption = ConflictOption.OverwriteChanges

                                    IntCounterNewStArchive = 0


                                    If dstNewStF1.Tables("tblNEWSTUDENTS").Rows.Count > 0 Then

                                        For IntCounterNewStArchive = 0 To dstNewStF1.Tables("tblNEWSTUDENTS").Rows.Count - 1

                                            'If dstNewStF1.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("CLASS") = "FORM 1" Then
                                            dstNewStF1.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("CLASS") = "FORM 2"
                                            dstNewStF1.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("DATEOFOCCURENCE") = Today
                                            dstNewStF1.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("ACADEMICYEAR") = Date.Now.Year
                                            'End If
                                        Next



                                        'Pull form 2 records and assign them form 3

                                        'clear the previous record before fetching new record 
                                        dstNewStF2.Clear() 'Current records table 'tblNEWSTUDENTS'


                                        'Set the data adapter and fetch data fro the database using select query
                                        dtadptNewStF2 = New OleDb.OleDbDataAdapter("SELECT * From tblNEWSTUDENTS WHERE CLASS = 'FORM 2' AND ACADEMICYEAR <> '" & txtCurrentYear.Text & "' ORDER BY ACADEMICYEAR ASC", conn)

                                        ' Use the data adapter to fill data in the dataset
                                        dtadptNewStF2.Fill(dstNewStF2, "tblNEWSTUDENTS")


                                        Dim cbdtadptChangeClassF2 As New OleDb.OleDbCommandBuilder(dtadptNewStF2)
                                        cbdtadptChangeClassF2.ConflictOption = ConflictOption.OverwriteChanges

                                        IntCounterNewStArchive = 0


                                        If dstNewStF2.Tables("tblNEWSTUDENTS").Rows.Count > 0 Then

                                            For IntCounterNewStArchive = 0 To dstNewStF2.Tables("tblNEWSTUDENTS").Rows.Count - 1

                                                ' If dstNewStF2.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("CLASS") = "FORM 2" Then
                                                dstNewStF2.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("CLASS") = "FORM 3"
                                                dstNewStF2.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("DATEOFOCCURENCE") = Today
                                                dstNewStF2.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("ACADEMICYEAR") = Date.Now.Year
                                                ' End If
                                            Next



                                            'Pull form 3 records and assign them form 4

                                            'clear the previous record before fetching new record 
                                            dstNewStF3.Clear() 'Current records table 'tblNEWSTUDENTS'


                                            'Set the data adapter and fetch data fro the database using select query
                                            dtadptNewStF3 = New OleDb.OleDbDataAdapter("SELECT * From tblNEWSTUDENTS WHERE CLASS = 'FORM 3' AND ACADEMICYEAR <> '" & txtCurrentYear.Text & "' ORDER BY ACADEMICYEAR ASC", conn)

                                            ' Use the data adapter to fill data in the dataset
                                            dtadptNewStF3.Fill(dstNewStF3, "tblNEWSTUDENTS")


                                            Dim cbdtadptChangeClassF3 As New OleDb.OleDbCommandBuilder(dtadptNewStF3)
                                            cbdtadptChangeClassF3.ConflictOption = ConflictOption.OverwriteChanges

                                            IntCounterNewStArchive = 0


                                            If dstNewStF3.Tables("tblNEWSTUDENTS").Rows.Count > 0 Then

                                                For IntCounterNewStArchive = 0 To dstNewStF3.Tables("tblNEWSTUDENTS").Rows.Count - 1

                                                    ' If dstNewStF3.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("CLASS") = "FORM 3" Then
                                                    dstNewStF3.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("CLASS") = "FORM 4"
                                                    dstNewStF3.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("DATEOFOCCURENCE") = Today
                                                    dstNewStF3.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("ACADEMICYEAR") = Date.Now.Year
                                                    ' End If
                                                Next




                                                'Pull form 5 records and assign them form 6

                                                'clear the previous record before fetching new record 
                                                ' dstNewStF5.Clear() 'Current records table 'tblNEWSTUDENTS'


                                                'Set the data adapter and fetch data fro the database using select query
                                                '  dtadptNewStF5 = New OleDb.OleDbDataAdapter("SELECT * From tblNEWSTUDENTS WHERE CLASS = 'FORM 5' AND ACADEMICYEAR <> '" & txtCurrentYear.Text & "' ORDER BY ACADEMICYEAR ASC", conn)

                                                ' Use the data adapter to fill data in the dataset
                                                ' dtadptNewStF5.Fill(dstNewStF5, "tblNEWSTUDENTS")


                                                '  Dim cbdtadptChangeClassF5 As New OleDb.OleDbCommandBuilder(dtadptNewStF5)
                                                '  cbdtadptChangeClassF5.ConflictOption = ConflictOption.OverwriteChanges

                                                '  IntCounterNewStArchive = 0


                                                '  If dstNewStF5.Tables("tblNEWSTUDENTS").Rows.Count > 0 Then

                                                'For IntCounterNewStArchive = 0 To dstNewStF5.Tables("tblNEWSTUDENTS").Rows.Count - 1

                                                ' If dstNewStF5.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("CLASS") = "FORM 5" Then
                                                'dstNewStF5.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("CLASS") = "FORM 6"
                                                'dstNewStF5.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("DATEOFOCCURENCE") = Today
                                                'dstNewStF5.Tables("tblNEWSTUDENTS").Rows(IntCounterNewStArchive).Item("ACADEMICYEAR") = Date.Now.Year
                                                ' End If
                                                'Next


                                                'save data in the four datasets to the database table "tblNEWSTUDENTS" after all classes have been assigned to avoid confusion of wrong classes being picked.

                                                dtadptNewStF1.Update(dstNewStF1, "tblNEWSTUDENTS")
                                                dtadptNewStF2.Update(dstNewStF2, "tblNEWSTUDENTS")
                                                dtadptNewStF3.Update(dstNewStF3, "tblNEWSTUDENTS")
                                                ' dtadptNewStF5.Update(dstNewStF5, "tblNEWSTUDENTS")



                                                'End If

                                            End If

                                        End If

                                    End If

                                End If

                            End If

                        End If

                    End If

                End If

            End If

            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()


            'clear the previous record before fetching new record and bind it to the datagridview
            dstR.Clear()


            'Set the data adapter and fetch data fro the database using select query
            dtadptR = New OleDb.OleDbDataAdapter("SELECT * From tblNEWSTUDENTS WHERE NOT ADMISSIONNUMBER IN (SELECT ADMISSIONNUMBER FROM tblSTUDENTSNIDHAMU WHERE ADMISSIONNUMBER <> Null) ORDER BY ADMISSIONNUMBER ASC", conn)



            ' Use the data adapter to fill data in the dataset
            dtadptR.Fill(dstR, "tblNEWSTUDENTS")



            'fetch data from the tblSTUDENTSNIDHAMU table

            'clear the previous record before fetching new record 
            dstUpdateNewStudents.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptUpdateNewStudents = New OleDb.OleDbDataAdapter("Select * From tblSTUDENTSNIDHAMU ORDER BY ADMISSIONNUMBER ASC", conn)

            ' Use the data adapter to fill data in the dataset
            dtadptUpdateNewStudents.Fill(dstUpdateNewStudents, "tblSTUDENTSNIDHAMU")


            'Close the database connection after filling the dataset
            conn.Close()



            If IntCounterREG <> -1 Then


                Dim cbdtadptUpdateNewStudents As New OleDb.OleDbCommandBuilder(dtadptUpdateNewStudents)
                cbdtadptUpdateNewStudents.ConflictOption = ConflictOption.OverwriteChanges


                Dim dstUpdateNewStudentsNewRow As DataRow

                IntCounterREG = 0

                If dstR.Tables("tblNEWSTUDENTS").Rows.Count > 0 Then

                    For IntCounterREG = 0 To dstR.Tables("tblNEWSTUDENTS").Rows.Count - 1

                        dstUpdateNewStudentsNewRow = dstUpdateNewStudents.Tables("tblSTUDENTSNIDHAMU").NewRow()
                        dstUpdateNewStudentsNewRow.Item("NAMEOFSTUDENT") = dstR.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("NAMEOFSTUDENT").ToString
                        dstUpdateNewStudentsNewRow.Item("ADMISSIONNUMBER") = dstR.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("ADMISSIONNUMBER").ToString
                        dstUpdateNewStudentsNewRow.Item("GENDER") = dstR.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("GENDER").ToString
                        dstUpdateNewStudentsNewRow.Item("CLASS") = dstR.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("CLASS").ToString
                        dstUpdateNewStudentsNewRow.Item("STREAM") = dstR.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("STREAM").ToString
                        dstUpdateNewStudentsNewRow.Item("KCPEMARKS") = dstR.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("KCPEMARKS")
                        dstUpdateNewStudentsNewRow.Item("KCPEGRADE") = dstR.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("KCPEGRADE").ToString
                        dstUpdateNewStudentsNewRow.Item("STUDENTPHOTO") = dstR.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("STUDENTPHOTO")     '.ToString
                        dstUpdateNewStudentsNewRow.Item("DORMITORIES") = dstR.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("DORMITORIES").ToString
                        dstUpdateNewStudentsNewRow.Item("DATEOFOCCURENCE") = dstR.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("DATEOFOCCURENCE")
                        dstUpdateNewStudentsNewRow.Item("FORMERSCHOOL") = dstR.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("FORMERSCHOOL").ToString
                        dstUpdateNewStudentsNewRow.Item("DATEOFADMISSION") = dstR.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("DATEOFADMISSION")
                        ' dstUpdateNewStudentsNewRow.Item("DATEOFOCCURENCE") = dstR.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("DATEOFOCCURENCE")

                        dstUpdateNewStudentsNewRow.Item("ACADEMICYEAR") = Date.Now.Year    'dstR.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("ACADEMICYEAR").ToString

                        dstUpdateNewStudents.Tables("tblSTUDENTSNIDHAMU").Rows.Add(dstUpdateNewStudentsNewRow)

                    Next

                    ' MsgBox("Record(s) successfully uploaded!", MsgBoxStyle.OkOnly, "Upload New Students")

                    LblUploadStatus.Text = "Student(s) successfully placed in their new classes for the current year!"

                    'save data in the database table

                    dtadptUpdateNewStudents.Update(dstUpdateNewStudents, "tblSTUDENTSNIDHAMU")

                Else

                    ' MsgBox("No Record(s) found to upload! Enter record(s) and click on upload New Students.", MsgBoxStyle.OkOnly, "No Records Found.")

                    LblUploadStatus.Text = "Students' current classes upto date."

                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class