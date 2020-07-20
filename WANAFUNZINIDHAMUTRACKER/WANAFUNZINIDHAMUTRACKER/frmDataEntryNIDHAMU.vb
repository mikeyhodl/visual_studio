
Imports System.ComponentModel
Imports System.Data.OleDb


Public Class frmDataEntryNIDHAMU

    ' This is the connection to the local MS Access database.
    ' The database is needed in both the Debug and Release folders.


    '  This Is a roaming database connection

    Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "DBSTUDENTSNIDHAMU.mdb")


    'Another way of roaming database connection

    'Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\DBSTUDENTSNIDHAMU.mdb;Persist Security Info=False;")



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


    ' Private BSNidhamu As New BindingSource()


    Private Sub frmDataEntryNIDHAMU_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()

            'clear the previous record before fetching new record and bind it to the datagridview
            dst.Clear()


            'Set the data adapter and fetch data fro the database using select query
            dtadpt = New OleDb.OleDbDataAdapter("SELECT * From tblNEWSTUDENTS WHERE NOT ADMISSIONNUMBER IN (SELECT ADMISSIONNUMBER FROM tblSTUDENTSNIDHAMU WHERE ADMISSIONNUMBER <> Null) ORDER BY ADMISSIONNUMBER ASC", conn)



            With dst.Tables.Add("tblNEWSTUDENTS")
                .Columns.Add("ID", System.Type.GetType("System.Int32"))
                .Columns("ID").AutoIncrement = True
                .Columns("ID").AutoIncrementSeed = -1
                .Columns("ID").AutoIncrementStep = -1

            End With


            ' Use the data adapter to fill data in the dataset
            dtadpt.Fill(dst, "tblNEWSTUDENTS")





            'fetch data for the CLASS combobox on the datagridview

            'clear the previous record before fetching new record and bind it to the combobox on the datagridview
            dstCLASS.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptCLASS = New OleDb.OleDbDataAdapter("SELECT DISTINCT ID, CCLASS From tblCLASSSTREAM", conn)

            ' Use the data adapter to fill data in the dataset
            dtadptCLASS.Fill(dstCLASS, "tblCLASSSTREAM") 'For combobox on the datagridview




            'fetch data for the STREAM combobox on the datagridview

            'clear the previous record before fetching new record and bind it to the combobox on the datagridview
            dstStream.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptStream = New OleDb.OleDbDataAdapter("SELECT DISTINCT ID, CSTREAM From tblSTREAM", conn)

            ' Use the data adapter to fill data in the dataset
            dtadptStream.Fill(dstStream, "tblSTREAM") 'For combobox on the datagridview





            'fetch data for the Dormitory combobox on the datagridview


            'clear the previous record before fetching new record and bind it to the combobox on the datagridview
            dstDormitories.Clear()


            'Set the data adapter and fetch data from the database using select query
            dtadptDormitories = New OleDb.OleDbDataAdapter("SELECT DISTINCT ID, DORMITORY From tblDORMITORY", conn)

            ' Use the data adapter to fill data in the dataset
            dtadptDormitories.Fill(dstDormitories, "tblDORMITORY") 'For combobox on the datagridview



            'Close the database connection after filling the dataset
            conn.Close()




            'To save these data in the dataset(which is in memory form) databack to the database table tblNEWSTUDENTS, use the commandbuilder
            Dim cb As New OleDb.OleDbCommandBuilder(dtadpt)



            'fill the bindingsource
            '  BSNidhamu.DataSource = dst
            ' BSNidhamu.DataMember = "tblNEWSTUDENTS"

            'bind the datagridview to the bindingsource

            'DataGridViewDISCIPLINEREGISTRATION.DataSource = BSNidhamu



            'Or
            DataGridViewDISCIPLINEREGISTRATION.DataSource = dst.Tables("tblNEWSTUDENTS")




            'create a comboboxcolumn for Class on the datagridview

            Dim ComboCLASS As New DataGridViewComboBoxColumn()
            'ComboCLASS.DataSource = dstCLASS.Tables("tblCLASSSTREAM")
            ComboCLASS.Name = "ComboCLASS"
            ' ComboCLASS.ValueMember = "CCLASS"
            ' ComboCLASS.DisplayMember = "CCLASS"
            ' ComboCLASS.DataPropertyName = "CLASS" 'Bind to field on the child's table

            ComboCLASS.Items.AddRange("FORM 1", "FORM 2", "FORM 3", "FORM 4")
            ComboCLASS.DataPropertyName = "CLASS" 'Bind to field on the child's table


            ComboCLASS.HeaderText = "CLASS"
            ComboCLASS.DefaultCellStyle.Format = "d"

            DataGridViewDISCIPLINEREGISTRATION.Columns.Add(ComboCLASS)

            DataGridViewDISCIPLINEREGISTRATION.EditMode = DataGridViewEditMode.EditOnEnter
            'prevents having to click the ComboBox twice



            'create a comboboxcolumn for STREAM on the datagridview

            Dim ComboSTREAM As New DataGridViewComboBoxColumn()
            ComboSTREAM.DataSource = dstStream.Tables("tblSTREAM")
            ComboSTREAM.Name = "ComboSTREAM"
            ComboSTREAM.ValueMember = "CSTREAM"
            ComboSTREAM.DisplayMember = "CSTREAM"
            ComboSTREAM.DataPropertyName = "STREAM" 'Bind to field on the child's table

            ComboSTREAM.HeaderText = "STREAM"
            ComboSTREAM.DefaultCellStyle.Format = "d"

            DataGridViewDISCIPLINEREGISTRATION.Columns.Add(ComboSTREAM)

            DataGridViewDISCIPLINEREGISTRATION.EditMode = DataGridViewEditMode.EditOnEnter
            'prevents having to click the ComboBox twice






            'create a comboboxcolumn for SEX on the datagridview

            Dim ComboSEX = New DataGridViewComboBoxColumn()
            ' ComboSEX.DataSource = dst.Tables("tblCLASSSEX")
            ComboSEX.Name = "ComboSEX"
            'ComboSEX.ValueMember = "ID"
            'ComboSEX.DisplayMember = "SEX"


            ComboSEX.Items.AddRange("M", "F")
            ComboSEX.DataPropertyName = "GENDER"


            ComboSEX.HeaderText = "GENDER"
            ComboSEX.DefaultCellStyle.Format = "d"

            DataGridViewDISCIPLINEREGISTRATION.Columns.Add(ComboSEX)

            DataGridViewDISCIPLINEREGISTRATION.EditMode = DataGridViewEditMode.EditOnEnter
            'prevents having to click the ComboBox twice



            'create a comboboxcolumn for STREAM on the datagridview

            Dim ComboDormitory As New DataGridViewComboBoxColumn()
            ComboDormitory.DataSource = dstDormitories.Tables("tblDORMITORY")
            ComboDormitory.Name = "ComboDormitory"
            ComboDormitory.ValueMember = "DORMITORY"
            ComboDormitory.DisplayMember = "DORMITORY"
            ComboDormitory.DataPropertyName = "DORMITORIES" 'Bind to field on the child's table

            ComboDormitory.HeaderText = "DORMITORY"
            ComboDormitory.DefaultCellStyle.Format = "d"

            DataGridViewDISCIPLINEREGISTRATION.Columns.Add(ComboDormitory)

            DataGridViewDISCIPLINEREGISTRATION.EditMode = DataGridViewEditMode.EditOnEnter
            'prevents having to click the ComboBox twice



            ' re-order the comboSEX control on the datagridview appropriately:
            DataGridViewDISCIPLINEREGISTRATION.Columns("ADMISSIONNUMBER").DisplayIndex = 4
            DataGridViewDISCIPLINEREGISTRATION.Columns("ComboSEX").DisplayIndex = 5
            DataGridViewDISCIPLINEREGISTRATION.Columns("ComboCLASS").DisplayIndex = 6
            DataGridViewDISCIPLINEREGISTRATION.Columns("ComboSTREAM").DisplayIndex = 7
            DataGridViewDISCIPLINEREGISTRATION.Columns("ComboDormitory").DisplayIndex = 8



            'Make GENDER column invisible

            DataGridViewDISCIPLINEREGISTRATION.Columns("GENDER").Visible = False
            DataGridViewDISCIPLINEREGISTRATION.Columns("CLASS").Visible = False
            DataGridViewDISCIPLINEREGISTRATION.Columns("STREAM").Visible = False
            DataGridViewDISCIPLINEREGISTRATION.Columns("DORMITORIES").Visible = False


            'Set column widths
            DataGridViewDISCIPLINEREGISTRATION.Columns("ID").Width = 50
            DataGridViewDISCIPLINEREGISTRATION.Columns("ADMISSIONNUMBER").Width = 100
            DataGridViewDISCIPLINEREGISTRATION.Columns("NAMEOFSTUDENT").Width = 200

            DataGridViewDISCIPLINEREGISTRATION.Columns("ID").ReadOnly = True

            'Set column headings to shorter names

            DataGridViewDISCIPLINEREGISTRATION.Columns("ADMISSIONNUMBER").HeaderText = "ADMNO"
            DataGridViewDISCIPLINEREGISTRATION.Columns("NAMEOFSTUDENT").HeaderText = "NAME"
            DataGridViewDISCIPLINEREGISTRATION.Columns("DATEOFOCCURENCE").HeaderText = "REG DATE"
            DataGridViewDISCIPLINEREGISTRATION.Columns("FORMERSCHOOL").HeaderText = "FORMER SCHOOL"
            DataGridViewDISCIPLINEREGISTRATION.Columns("DATEOFADMISSION").HeaderText = "ADMISSION DATE"

            DataGridViewDISCIPLINEREGISTRATION.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine


            'Hide the ID and DISCONTINUED columns
            DataGridViewDISCIPLINEREGISTRATION.Columns("ID").Visible = False
            DataGridViewDISCIPLINEREGISTRATION.Columns("DISCONTINUED").Visible = False


            Me.Show()
            Me.WindowState = FormWindowState.Maximized


            If dst.Tables("tblNEWSTUDENTS").Rows.Count > 0 Then

                MsgBox("The above record(s) have not been aploaded to be stored permanently. Click on 'Upload New Students' to do so.",, "Records Not Uploaded")

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnViewaStudent_Click(sender As Object, e As EventArgs) Handles BtnViewaStudent.Click
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



            'bind the datagridview to the datasets 'dst2' 
            '  DataGridViewFirstStudentDetails.DataSource = dst2.Tables("tblSTUDENTSNIDHAMU")



            'Fill the null values in the database table

            Dim IntFillNulls As Integer

            IntFillNulls = 0

            If dst2.Tables("tblSTUDENTSNIDHAMU").Rows.Count > 0 Then

                For IntFillNulls = 0 To dst2.Tables("tblSTUDENTSNIDHAMU").Rows.Count - 1

                    'If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("DATEOFADMISSION")) = True Then
                    'dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("DATEOFADMISSION") = 000000
                    'End If

                    If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("KCPEMARKS")) = True Then
                        dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("KCPEMARKS") = 0
                    End If

                    If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("KCPEGRADE")) = True Then
                        dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("KCPEGRADE") = "MISSING"
                    End If

                    If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("CURRENTMARKS")) = True Then
                        dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("CURRENTMARKS") = 0
                    End If

                    If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("CURRENTPOINTS")) = True Then
                        dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("CURRENTPOINTS") = 0
                    End If

                    If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("CURRENTGRADE")) = True Then
                        dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("CURRENTGRADE") = "MISSING"
                    End If

                    If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("STUDENTVAP")) = True Then
                        dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("STUDENTVAP") = 0
                    End If

                    If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("FORMERSCHOOL")) = True Then
                        dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("FORMERSCHOOL") = "MISSING DATA"
                    End If

                    ' If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("DATEOFADMISSION")) = True Then
                    'dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("DATEOFADMISSION") = 00000000
                    'End If

                    If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("FEESBALANCE")) = True Then
                        dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("FEESBALANCE") = 0
                    End If

                    If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("FEEPAYER")) = True Then
                        dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("FEEPAYER") = "MISSING DATA"
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
                        dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("NAMEOFPARENT") = "MISSING DATA"
                    End If

                    If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("PARENTPHONENUMBER")) = True Then
                        dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("PARENTPHONENUMBER") = "MISSING DATA"
                    End If

                    If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("COUNTY")) = True Then
                        dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("COUNTY") = "MISSING DATA"
                    End If

                    If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("SUBCOUNTY")) = True Then
                        dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("SUBCOUNTY") = "MISSING DATA"
                    End If

                    If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("RESIDENCEESTATE")) = True Then
                        dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("RESIDENCEESTATE") = "MISSING DATA"
                    End If

                    ' If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("EXPECTEDDATEOFRETURN")) = True Then
                    'dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("EXPECTEDDATEOFRETURN") = 00000000
                    'End If

                    ' If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("ACTUALDATEOFRETURN")) = True Then
                    'dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("ACTUALDATEOFRETURN") = 00000000
                    'End If

                    If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("STATEOFAFFAIRS")) = True Then
                        dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("STATEOFAFFAIRS") = "MISSING DATA"
                    End If

                    If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("TYPEOFPUNISHMENT")) = True Then
                        dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("TYPEOFPUNISHMENT") = "Pending"
                    End If

                    If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("PUNSHMENTSTATE")) = True Then
                        dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("PUNSHMENTSTATE") = "MISSING DATA"
                    End If

                    ' If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("DATECOMPLETEDPUNSHMENT")) = True Then
                    'dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("DATECOMPLETEDPUNSHMENT") = 00000000
                    'End If

                    If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("PUNSHEDBY")) = True Then
                        dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("PUNSHEDBY") = "MISSING DATA"
                    End If

                    If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("RESPONSIBILITY")) = True Then
                        dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("RESPONSIBILITY") = "NONE"
                    End If

                    If IsDBNull(dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("REMARKS")) = True Then
                        dst2.Tables("tblSTUDENTSNIDHAMU").Rows(IntFillNulls).Item("REMARKS") = "NONE"
                    End If

                Next
            End If


            Dim cb2 As New OleDb.OleDbCommandBuilder(dtadpt2)


            cb2.ConflictOption = ConflictOption.OverwriteChanges


            dtadpt2.Update(dst2, "tblSTUDENTSNIDHAMU")




            frmNIDHAMUMain.Show()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()

            'clear the previous record before fetching new record and bind it to the datagridview
            dst.Clear()


            'Set the data adapter and fetch data fro the database using select query
            dtadpt = New OleDb.OleDbDataAdapter("SELECT * From tblNEWSTUDENTS WHERE NOT ADMISSIONNUMBER IN (SELECT ADMISSIONNUMBER FROM tblSTUDENTSNIDHAMU WHERE ADMISSIONNUMBER <> Null) ORDER BY ADMISSIONNUMBER ASC", conn)


            ' Use the data adapter to fill data in the dataset
            dtadpt.Fill(dst, "tblNEWSTUDENTS")

            conn.Close()


            DataGridViewDISCIPLINEREGISTRATION.DataSource = dst.Tables("tblNEWSTUDENTS")



            If dst.Tables("tblNEWSTUDENTS").Rows.Count > 0 Then

                MsgBox("The above record(s) have not been aploaded to be stored permanently. Click on 'Upload New Students' to do so Or delete if you do not need them.",, "Records Not Uploaded")


                'Return focus on the button to upload new students

                ' BtnUpdateNewStudents.Focus()

                Exit Sub

            Else

                'Close the form
                Me.Close()

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()



            Dim cb As New OleDb.OleDbCommandBuilder(dtadpt)

            cb.ConflictOption = ConflictOption.OverwriteChanges


            dtadpt.Update(dst, "tblNEWSTUDENTS")

            MsgBox("Record(s) successfully saved!", MsgBoxStyle.OkOnly, "")


            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnUpdateNewStudents_Click(sender As Object, e As EventArgs) Handles BtnUpdateNewStudents.Click
        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()

            'clear the previous record before fetching new record and bind it to the datagridview
            dst.Clear()


            'Set the data adapter and fetch data fro the database using select query
            dtadpt = New OleDb.OleDbDataAdapter("SELECT * From tblNEWSTUDENTS WHERE NOT ADMISSIONNUMBER IN (SELECT ADMISSIONNUMBER FROM tblSTUDENTSNIDHAMU WHERE ADMISSIONNUMBER <> Null) ORDER BY ADMISSIONNUMBER ASC", conn)



            ' Use the data adapter to fill data in the dataset
            dtadpt.Fill(dst, "tblNEWSTUDENTS")



            'Check to see  if user forgot the Reg Date and remind them and exit sub

            ' Dim IntCntDate As Integer

            ' If IntCntDate <> -1 Then


            'IntCntDate = 0



            'If dst.Tables("tblNEWSTUDENTS").Rows.Count > 0 Then

            'For IntCntDate = 0 To dst.Tables("tblNEWSTUDENTS").Rows.Count - 1
            'If IsDBNull(dst.Tables("tblNEWSTUDENTS").Rows(IntCntDate).Item("DATEOFOCCURENCE")) = True Then

            'LblREGDATE.text = "Please enter missing REG DATE"

            'End If
            'Next

            'MsgBox("REG DATE is Missing. Please Enter it before Uploading!", MsgBoxStyle.OkOnly, "MISSING REG DATE")

            'Exit Sub



            'Else



            'Proceed if the above is false


            'fetch data from the tblSTUDENTSNIDHAMU table

            'clear the previous record before fetching new record and bind it to the combobox 'ComboADNO'
            dstUpdateNewStudents.Clear()


                    'Set the data adapter and fetch data from the database using select query
                    dtadptUpdateNewStudents = New OleDb.OleDbDataAdapter("Select * From tblSTUDENTSNIDHAMU ORDER BY ADMISSIONNUMBER ASC", conn)

                    ' Use the data adapter to fill data in the dataset
                    dtadptUpdateNewStudents.Fill(dstUpdateNewStudents, "tblSTUDENTSNIDHAMU")


                    'Close the database connection after filling the dataset
                    conn.Close()





                    ' If IntCounterNIDHAM <> -1 And IntCounterREG <> -1 Then

                    If IntCounterREG <> -1 Then


                        Dim cbdtadptUpdateNewStudents As New OleDb.OleDbCommandBuilder(dtadptUpdateNewStudents)

                        Dim dstUpdateNewStudentsNewRow As DataRow

                        IntCounterREG = 0

                        If dst.Tables("tblNEWSTUDENTS").Rows.Count > 0 Then

                            For IntCounterREG = 0 To dst.Tables("tblNEWSTUDENTS").Rows.Count - 1

                                dstUpdateNewStudentsNewRow = dstUpdateNewStudents.Tables("tblSTUDENTSNIDHAMU").NewRow()
                                dstUpdateNewStudentsNewRow.Item("NAMEOFSTUDENT") = dst.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("NAMEOFSTUDENT").ToString
                                dstUpdateNewStudentsNewRow.Item("ADMISSIONNUMBER") = dst.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("ADMISSIONNUMBER").ToString
                                dstUpdateNewStudentsNewRow.Item("GENDER") = dst.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("GENDER").ToString
                                dstUpdateNewStudentsNewRow.Item("CLASS") = dst.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("CLASS").ToString
                                dstUpdateNewStudentsNewRow.Item("STREAM") = dst.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("STREAM").ToString
                                dstUpdateNewStudentsNewRow.Item("KCPEMARKS") = dst.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("KCPEMARKS")
                                dstUpdateNewStudentsNewRow.Item("KCPEGRADE") = dst.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("KCPEGRADE").ToString
                                dstUpdateNewStudentsNewRow.Item("STUDENTPHOTO") = dst.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("STUDENTPHOTO")     '.ToString
                                dstUpdateNewStudentsNewRow.Item("DORMITORIES") = dst.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("DORMITORIES").ToString
                        dstUpdateNewStudentsNewRow.Item("DATEOFOCCURENCE") = dst.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("DATEOFOCCURENCE")
                        dstUpdateNewStudentsNewRow.Item("FORMERSCHOOL") = dst.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("FORMERSCHOOL").ToString
                        dstUpdateNewStudentsNewRow.Item("DATEOFADMISSION") = dst.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("DATEOFADMISSION")
                        ' dstUpdateNewStudentsNewRow.Item("DATEOFOCCURENCE") = dst.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("DATEOFOCCURENCE")

                        dstUpdateNewStudentsNewRow.Item("ACADEMICYEAR") = dst.Tables("tblNEWSTUDENTS").Rows(IntCounterREG).Item("ACADEMICYEAR").ToString

                        dstUpdateNewStudents.Tables("tblSTUDENTSNIDHAMU").Rows.Add(dstUpdateNewStudentsNewRow)

                    Next

                    MsgBox("Record(s) successfully uploaded!", MsgBoxStyle.OkOnly, "Upload New Students")

                    'save data in the database table

                    dtadptUpdateNewStudents.Update(dstUpdateNewStudents, "tblSTUDENTSNIDHAMU")

                        Else

                    MsgBox("No Record(s) found to upload! Enter record(s) and click on upload New Students.", MsgBoxStyle.OkOnly, "No Records Found.")

                End If
                    End If



            '  End If

            ' End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnSavePhoto_Click(sender As Object, e As EventArgs) Handles BtnSavePhoto.Click

        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()



            'Assign student photo to the current row studentphoto cell
            DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("STUDENTPHOTO").Value = PictureBoxStudentPhoto.Image



            Dim cb As New OleDb.OleDbCommandBuilder(dtadpt)

            cb.ConflictOption = ConflictOption.OverwriteChanges


            dtadpt.Update(dst, "tblNEWSTUDENTS")

            MsgBox("Image successfully sent!. Now click on save.", MsgBoxStyle.OkOnly, "")


            conn.Close()


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
            PictureBoxStudentPhoto.Size = New System.Drawing.Size(110, 115)

            'To make the image fit the size of the picture box
            ' PictureBoxStudentPhoto.SizeMode = PictureBoxSizeMode.StretchImage

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnEditData_Click(sender As Object, e As EventArgs) Handles BtnEditData.Click
        Try

            frmEDITS.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub DataGridViewDISCIPLINEREGISTRATION_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewDISCIPLINEREGISTRATION.RowLeave
        Try

            ' If conn.State = ConnectionState.Open Then conn.Close()

            ' conn.Open()


            ' Dim cb As New OleDb.OleDbCommandBuilder(dtadpt)

            ' cb.ConflictOption = ConflictOption.OverwriteChanges


            ' dtadpt.Update(dst, "tblNEWSTUDENTS")


            ' conn.Close()




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridViewDISCIPLINEREGISTRATION_MouseLeave(sender As Object, e As EventArgs) Handles DataGridViewDISCIPLINEREGISTRATION.MouseLeave
        Try

            ' Dim cb As New OleDb.OleDbCommandBuilder(dtadpt)

            ' cb.ConflictOption = ConflictOption.OverwriteChanges


            ' dtadpt.Update(dst, "tblNEWSTUDENTS")

            ' MsgBox("Record(s) successfully saved!", MsgBoxStyle.OkOnly, "")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub DataGridViewDISCIPLINEREGISTRATION_Click(sender As Object, e As EventArgs) Handles DataGridViewDISCIPLINEREGISTRATION.Click

        Try

            'Assign the current year to the academicyear field
            DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("ACADEMICYEAR").Value = Date.Now.Year

            DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("ACADEMICYEAR").ReadOnly = True



            Dim KCPEMIDMARK As Single


            If IsDBNull(DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEMARKS").Value) = True Then
                DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEMARKS").Value = 0
            End If


            ' If IsDBNull(DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEPOINTS").Value) = True Then
            ' DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEPOINTS").Value = 0
            ' End If


            KCPEMIDMARK = Val(DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEMARKS").Value) / 5
            KCPEMIDMARK = FormatNumber(Val(KCPEMIDMARK), 0)

            Select Case KCPEMIDMARK


                Case 0

                    DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEGRADE").Value = "X"
                ' DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEPOINTS").Value = 0


                Case 1 To 24

                    DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEGRADE").Value = "E"
                ' DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEPOINTS").Value = "1"

                Case 25 To 29

                    DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEGRADE").Value = "D-"
                ' DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEPOINTS").Value = "2"

                Case 30 To 34

                    DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEGRADE").Value = "D"
                ' DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEPOINTS").Value = "3"

                Case 35 To 39

                    DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEGRADE").Value = "D+"
                '  DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEPOINTS").Value = "4"

                Case 40 To 44

                    DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEGRADE").Value = "C-"
                '  DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEPOINTS").Value = "5"

                Case 45 To 54

                    DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEGRADE").Value = "C"
                '   DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEPOINTS").Value = "6"

                Case 55 To 59

                    DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEGRADE").Value = "C+"
                ' DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEPOINTS").Value = "7"

                Case 60 To 64

                    DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEGRADE").Value = "B-"
                '  DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEPOINTS").Value = "8"

                Case 65 To 69

                    DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEGRADE").Value = "B"
                '   DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEPOINTS").Value = "9"

                Case 70 To 74

                    DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEGRADE").Value = "B+"
                '  DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEPOINTS").Value = "10"

                Case 75 To 79

                    DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEGRADE").Value = "A-"
                '  DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEPOINTS").Value = "11"

                Case 80 To 100

                    DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEGRADE").Value = "A"
                    '  DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("KCPEPOINTS").Value = "12"

            End Select



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnDeleteCurrentRecord_Click(sender As Object, e As EventArgs) Handles BtnDeleteCurrentRecord.Click
        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()



            If MessageBox.Show("Are you sure you want To delete the Current Selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then

                Exit Sub

            Else


                Dim delcmd As New OleDbCommand("DELETE * FROM tblNEWSTUDENTS WHERE ADMISSIONNUMBER = '" & DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("ADMISSIONNUMBER").Value & "'", conn)
                delcmd.ExecuteNonQuery()
                MsgBox("Record Is deleted")


            End If

        Catch ex As Exception
            MessageBox.Show("Admmission Number Missing. Therefore cannot delete the record." & ex.Message)
        End Try

    End Sub


    Private Sub DataGridViewDISCIPLINEREGISTRATION_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridViewDISCIPLINEREGISTRATION.CellBeginEdit

        Try

            DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("DATEOFOCCURENCE").Value = Today

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub DataGridViewDISCIPLINEREGISTRATION_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridViewDISCIPLINEREGISTRATION.DataError
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

    Private Sub DataGridViewDISCIPLINEREGISTRATION_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewDISCIPLINEREGISTRATION.CellContentClick

    End Sub

    Private Sub DataGridViewDISCIPLINEREGISTRATION_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewDISCIPLINEREGISTRATION.CellLeave

        Try


            ' To check if the ADMNO already exists in the database, connect to the database.

            Dim conn As New OleDb.OleDbConnection(connectionString:="Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source=" & System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & "DBSTUDENTSNIDHAMU.mdb")



            ' The Sql string holds the ADMISSIONNUMBER comparison in SQL Statement format. Astrerisk( * ) means that we are going to fetch every column on tblNewstudents
            'we 've created earlier on matched record in WHERE condition output.  In checking the required fields earlier, the condition must be TRUE in order to satisfy.
            'In here, it will proceed only if the condition is TRUE, Meaning username and password must be matched or it will fail. The sql will be executed and store in sqlRead variable.






            Dim sql As String = "SELECT * FROM tblNEWSTUDENTS WHERE ADMISSIONNUMBER = '" & DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("ADMISSIONNUMBER").Value & "'"
            Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

            'Open Database Connection
            sqlCom.Connection = conn
            conn.Open()

            Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader() 'sqlRead variable will store the result of the sql string


            'Now check if user enter different ADMISSIONNUMBER  in order to proceed. Create another form and name it as frmMain. 
            'When user has been authenticated, this frmMain will show And we're going to hide the frmLogin. 
            'Otherwise, we're going to display error message, clear username and password text box and set the focus to username text field.

            'The result of the sql string stored in the sqlRead variable is compared below with the user's input in the userName text field and the Password text field. 
            'If they match, the Sub will Continue Or Else show an Error message below.



            If sqlRead.Read() Then


                ' MsgBox("The ADMNO:" & " " & DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("ADMISSIONNUMBER").Value & " " & "already exists.",, "Admission No. already Exists")


                LblAvoidDuplicateADMNO.Text = "The ADMNO:" & " " & DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("ADMISSIONNUMBER").Value & " " & "already exists."


                'Set focus to the currentrow cell

                ' DataGridViewDISCIPLINEREGISTRATION.SelectionMode = DataGridViewSelectionMode.CellSelect

                ' DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("ADMISSIONNUMBER").Selected = True

                ' DataGridViewDISCIPLINEREGISTRATION.BeginEdit(True)



                Exit Sub


            Else

                Dim cb As New OleDb.OleDbCommandBuilder(dtadpt)

                cb.ConflictOption = ConflictOption.OverwriteChanges


                dtadpt.Update(dst, "tblNEWSTUDENTS")

            End If





            ' If DataGridViewDISCIPLINEREGISTRATION.CurrentRow.Cells("ADMISSIONNUMBER").Value Is Nothing Then

            'MsgBox("ADMNO is empty")

            ' End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnRefreshRecords_Click(sender As Object, e As EventArgs) Handles BtnRefreshRecords.Click

        Try

            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()

            'clear the previous record before fetching new record and bind it to the datagridview
            dst.Clear()


            'Set the data adapter and fetch data fro the database using select query
            dtadpt = New OleDb.OleDbDataAdapter("SELECT * From tblNEWSTUDENTS WHERE NOT ADMISSIONNUMBER IN (SELECT ADMISSIONNUMBER FROM tblSTUDENTSNIDHAMU WHERE ADMISSIONNUMBER <> Null) ORDER BY ADMISSIONNUMBER ASC", conn)


            ' Use the data adapter to fill data in the dataset
            dtadpt.Fill(dst, "tblNEWSTUDENTS")

            conn.Close()


            DataGridViewDISCIPLINEREGISTRATION.DataSource = dst.Tables("tblNEWSTUDENTS")



            If dst.Tables("tblNEWSTUDENTS").Rows.Count > 0 Then

                MsgBox("The above record(s) have not been aploaded to be stored permanently. Click on 'Upload New Students' to do so Or delete if you do not need them.",, "Records Not Uploaded")


                'Return focus on the button to upload new students

                ' BtnUpdateNewStudents.Focus()

                Exit Sub

            Else

                'Close the form
                Me.Close()

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class