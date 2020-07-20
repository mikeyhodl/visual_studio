Imports System.ComponentModel
Imports System.Data.OleDb
Public Class frmPromotionsSwitchboard

    ' This is the connection to the local MS Access database.
    ' The database is needed in both the Debug and Release folders.


    '  This Is a roaming database connection

    Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "DBSTUDENTSNIDHAMU.mdb")


    'Another way of roaming database connection

    'Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\DBSTUDENTSNIDHAMU.mdb;Persist Security Info=False;")



    Dim IntCounterArchive As Integer


    Dim dst As New DataSet()
    Dim dstUpdateArchive As New DataSet()


    Dim dtadpt As OleDb.OleDbDataAdapter
    Dim dtadptUpdateArchive As OleDb.OleDbDataAdapter


    'Other declarations

    Dim IntCounterREG As Integer
    Dim IntCounterNIDHAM As Integer

    Dim dstR As New DataSet()
    Dim dstUpdateNewStudents As New DataSet()


    Dim dtadptR As OleDb.OleDbDataAdapter
    Dim dtadptUpdateNewStudents As OleDb.OleDbDataAdapter


    Private Sub BtnPromoteForm1ToForm2_Click(sender As Object, e As EventArgs) Handles BtnPromoteForm1ToForm2.Click

        Try

            frmPromoteForm1ToForm2.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnPromoteForm2ToForm3_Click(sender As Object, e As EventArgs) Handles BtnPromoteForm2ToForm3.Click

        Try

            frmPromoteForm2ToForm3.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnPromoteForm3ToForm4_Click(sender As Object, e As EventArgs) Handles BtnPromoteForm3ToForm4.Click

        Try

            frmPromoteForm3ToForm4.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnPromoteForm4ToForm5_Click(sender As Object, e As EventArgs) Handles BtnPromoteForm4ToForm5.Click

        Try

            frmPromoteForm4ToForm5.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnPromoteForm5ToForm6_Click(sender As Object, e As EventArgs) Handles BtnPromoteForm5ToForm6.Click

        Try

            frmPromoteForm5ToForm6.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnSendForm4LeaversToArchive_Click(sender As Object, e As EventArgs) Handles BtnSendForm4LeaversToArchive.Click

        Try

            frmSendForm4LeaversToArchive.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnSendForm6LeaversToArchive_Click(sender As Object, e As EventArgs) Handles BtnSendForm6LeaversToArchive.Click

        Try

            frmSendForm6LeaversToArchive.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnArchiveAllClasses_Click(sender As Object, e As EventArgs) Handles BtnArchiveAllClasses.Click

        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()

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
                            LblConfirmStudentPromotion.Text = "Students already promoted to the next class"
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

    Private Sub frmPromotionsSwitchboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            'Assign 'txtCurrentYear' textbox current year
            txtCurrentYear.Text = Date.Now.Year


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmPromotionsSwitchboard_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
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

                    MsgBox("Record(s) successfully uploaded!", MsgBoxStyle.OkOnly, "Upload New Students")

                    'save data in the database table

                    dtadptUpdateNewStudents.Update(dstUpdateNewStudents, "tblSTUDENTSNIDHAMU")

                Else

                    MsgBox("No Record(s) found to upload! Enter record(s) and click on upload New Students.", MsgBoxStyle.OkOnly, "No Records Found.")

                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmPromotionsSwitchboard_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub
End Class